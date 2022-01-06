using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;
using System.Xml;
using RazorEngine;
using RazorEngine.Templating;
using System.IO;
using RuiJi.Net.Core.Crawler;

namespace Iotsys.YsSDK
{
    public partial class Form1 : Form
    {
        private List<int> ids = new List<int>();
        private string template_api = "";
        private string template_class = "";
        private string template_device = "";
        private List<string> apiCode = new List<string>();
        private List<string> igs = new List<string>()
        {
            "DetectorList",
            "CloudStorageOpen",//td tr不匹配
            "IntelligenceOcrGeneric",
            "IntelligenceOcrReceipt",
            "IntelligenceFaceAnalysisDetect"
        };

        public Form1()
        {
            InitializeComponent();
            template_api = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "Template/Api.temp");
            template_class = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "Template/Class.temp");
            template_device = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "Template/Device.temp");

            for (int i = 0; i < this.checkedListBox1.Items.Count; i++)
            {
                this.checkedListBox1.SetItemChecked(i, true);
            }
        }

        private string download(int id)
        {
            var baseUrl = $"https://open.ys7.com/help/{id}";

            var crawler = new RuiJiCrawler();
            var request = new Request($"https://open.ys7.com/help/api/help_doc/doc/list?_r=0.6586677698096981&pageStart=1&pageSize=1&tag=1&docId={id}");
            var response = crawler.Request(request);

            var content = response.Data.ToString();

            var obj = JObject.Parse(content);
            var v = obj.SelectToken("$..list[0].htmlContent");

            return v.ToString();
        }

        private void setLog(string text)
        {
            label1.Invoke(new Action(() => {
                label1.Text = text;
            }));
        }

        private string transType(string type,string des)
        {
            type = type.ToLower();

            if (type == "boolean")
                return "bool";
            if (type == "integer")
                return  "int";
            if (type == "map<string,string>")
                return "Dictionary<string,string>";
            if(type == "map<string,location>")
                return "Dictionary<string,Location>";
            if (type == "location")
                return "Location";
            if (type == "list")
                return "object[]";
            if (type == "array")
                return "object[]";
            if(type== "array[account]")
                return "object[]";
            if (type == "s")
                return "string";
            if (type == "policy")
                return "object";
            if (type == "object" && des == "语音文件信息")
                return "ResponseVoice";

            return type.ToLower();
        }

        private void processPage(int id)
        {
            var baseUrl = $"https://open.ys7.com/help/{id}";

            setLog(baseUrl);

            var content = download(id);

            var hms = Regex.Matches(content, @"\<h2\>(.*?)<a id=""(.*?)"".*?\</h2\>", RegexOptions.IgnoreCase);

            var sp = Regex.Split(content, @"\<h2\>.*?\</h2\>", RegexOptions.IgnoreCase).ToList();
            sp.RemoveAt(0);

            var index = 0;

            foreach (var c in sp)
            {
                var ms = Regex.Match(c, @"\>(https://open.ys7.com/api/lapp/(.*?))\<");
                var url = ms.Groups[1].Value;
                var api = ms.Groups[2].Value;
                var funName = "";
                if (api != "")
                    funName = String.Join("", api.Split('/').Select(m => m.First().ToString().ToUpper() + m.Substring(1)).ToArray());
                else
                    funName = "unknow";

                if (igs.Contains(funName))
                    continue;

                var doc = new XmlDocument();
                doc.LoadXml("<doc>" + c + "</doc>");

                var intro = doc.SelectSingleNode("//li").FirstChild.InnerText;
                var ps = doc.SelectNodes("//table[1]/tbody/tr");
                var li = doc.SelectNodes("//li[text()='返回数据']");
                var preCode = li.Item(0).ParentNode.NextSibling.InnerText;
                if (preCode.EndsWith("\n}\n\n}\n"))
                    preCode = preCode.Substring(0, preCode.Length - 4);

                var json = JObject.Parse(preCode);

                JToken dataToken;
                json.TryGetValue("data", out dataToken);
                JToken pageToken;
                json.TryGetValue("page", out pageToken);

                var pds = new List<ParamDes>();

                foreach (var p in ps)
                {
                    var ele = p as XmlElement;
                    var d = new ParamDes();
                    d.Name = ele.ChildNodes[0].InnerText;                    
                    d.Description = ele.ChildNodes[2].InnerText;
                    d.Type = transType(ele.ChildNodes[1].InnerText, d.Description);
                    d.Required = ele.ChildNodes[3].InnerText == "Y" ? true : false;

                    if(id == 57)
                    {
                        d.Description = ele.ChildNodes[3].InnerText;
                        d.Type = transType(ele.ChildNodes[1].InnerText, d.Description);
                        d.Required = ele.ChildNodes[4].InnerText == "Y" ? true : false;
                    }

                    if (d.Name == "accessToken")
                        continue;

                    pds.Add(d);
                }

                var rp = new List<ReturnParam>();
                ps = doc.SelectNodes("//table[2]//tr");
                if (ps.Count > 0 && ps[0].ChildNodes[0].InnerText == "字段名")
                {
                    for (int i = 1; i < ps.Count; i++)
                    {
                        var ele = ps[i] as XmlElement;
                        var d = new ReturnParam();
                        d.Name = ele.ChildNodes[0].InnerText;                        
                        d.Description = ele.ChildNodes[2].InnerText;
                        d.Type = transType(ele.ChildNodes[1].InnerText,d.Description);

                        if (d.Name == "page")
                            continue;

                        rp.Add(d);
                    }
                }

                pds = pds.OrderByDescending(p => p.Required).ToList();

                var pps = new List<string>();
                foreach (var p in pds)
                {
                    if (p.Name == "accessToken")
                        continue;

                    var n = p.Required ? "" : "?";
                    var ne = "";
                    if (n == "?")
                    {
                        if (p.Type == "string")
                        {
                            n = "";
                            ne = @" = """"";
                        }
                        else
                            ne = " = null";
                    }                        

                    pps.Add($"{p.Type}{n} {p.Name}{ne}");
                }

                var code = Engine.Razor.RunCompile(template_api, "template_api", null, new
                {
                    intro = hms[index].Groups[1].Value,
                    baseUrl,
                    api,
                    funName,
                    link = hms[index].Groups[2].Value,
                    pds,
                    pps = string.Join(", ", pps.ToArray()),
                    rt = rp.Count > 0 ? funName + "Response" : "ResponseBase"
                });

                apiCode.Add(code);

                //返回值
                if (rp.Count > 0)
                {
                    var ccode = Engine.Razor.RunCompile(template_class, "template_class", null, new
                    {
                        rp,
                        baseUrl,
                        api,
                        funName,
                        link = hms[index].Groups[2].Value,
                        pds,
                        pps = string.Join(", ", pps.ToArray()),
                        dataType = dataToken.Type.ToString() == "Array" ? $"List<{funName}Data>" : $"{funName}Data",
                        pageToken
                    });

                    File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + $"../../../Iotsys.Ezviz/{funName}Response.cs", ccode);
                }
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await new TaskFactory().StartNew(() => {
                var p1 = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + $"../../../Iotsys.Ezviz/");
                var fs = Directory.GetFiles(p1,"*.cs");
                foreach (var f in fs)
                {
                    File.Delete(f);
                }

                var p2 = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + $"../../Ezviz/");
                fs = Directory.GetFiles(p2);
                foreach (var f in fs)
                {
                    var fname = (new FileInfo(f)).Name;

                    File.Copy(f, p1 + fname, true);
                }

                apiCode.Clear();

                for (int i = 0; i < this.checkedListBox1.Items.Count; i++)
                {
                    if (checkedListBox1.GetItemChecked(i))
                    {
                        var t = checkedListBox1.Items[i].ToString();
                        var id = Convert.ToInt32(t.Split('|')[0]);

                        ids.Add(id);
                    }
                }

                foreach (var id in ids.ToList())
                {
                    processPage(id);
                }

                var dcode = Engine.Razor.RunCompile(template_device, "template_device", null, new
                {
                    apiCode
                });

                File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + $"../../../Iotsys.Ezviz/Device.cs", dcode);

                setLog("完成");
            });
        }
    }
}