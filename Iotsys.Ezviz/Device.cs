using Newtonsoft.Json;
using RestSharp;
using System;

namespace Iotsys.Ezviz
{
    public class Device
    {
       
    /// <summary>
    /// 添加设备
    /// https://open.ys7.com/help/54#device_option-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    ///<param name="validateCode">设备验证码，设备机身上的六位大写字母 </param>
    public static ResponseBase DeviceAdd(string deviceSerial, string validateCode)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "device/add";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);
        request.AddQueryParameter("validateCode", validateCode);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 添加设备
    /// https://open.ys7.com/help/54#device_option-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    public static ResponseBase DeviceDelete(string deviceSerial)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "device/delete";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 添加设备
    /// https://open.ys7.com/help/54#device_option-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    ///<param name="deviceName">设备名称，长度不大于50字节，不能包含特殊字符 </param>
    public static ResponseBase DeviceNameUpdate(string deviceSerial, string deviceName)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "device/name/update";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);
        request.AddQueryParameter("deviceName", deviceName);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 添加设备
    /// https://open.ys7.com/help/54#device_option-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    ///<param name="channelNo">通道号，IPC设备填写1 </param>
    public static DeviceCaptureResponse DeviceCapture(string deviceSerial, int channelNo)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "device/capture";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);
        request.AddQueryParameter("channelNo", channelNo.ToString());

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<DeviceCaptureResponse>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 添加设备
    /// https://open.ys7.com/help/54#device_option-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    ///<param name="ipcSerial">待关联的IPC设备序列号 </param>
    ///<param name="channelNo">非必选参数，不为空表示给指定通道关联IPC，为空表示给通道1关联IPC </param>
    ///<param name="validateCode">非必选参数，IPC设备验证码，默认为空 </param>
    public static ResponseBase DeviceIpcAdd(string deviceSerial, string ipcSerial, int? channelNo = null, string validateCode = "")
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "device/ipc/add";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);
        request.AddQueryParameter("ipcSerial", ipcSerial);
        if (channelNo.HasValue)  
            request.AddQueryParameter("channelNo", channelNo.Value.ToString());
        if (!string.IsNullOrEmpty(validateCode))  
            request.AddQueryParameter("validateCode", validateCode);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 添加设备
    /// https://open.ys7.com/help/54#device_option-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    ///<param name="ipcSerial">待关联的IPC设备序列号 </param>
    ///<param name="channelNo">非必选参数，不为空表示给指定通道关联IPC，为空表示给通道1关联IPC </param>
    public static ResponseBase DeviceIpcDelete(string deviceSerial, string ipcSerial, int? channelNo = null)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "device/ipc/delete";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);
        request.AddQueryParameter("ipcSerial", ipcSerial);
        if (channelNo.HasValue)  
            request.AddQueryParameter("channelNo", channelNo.Value.ToString());

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 添加设备
    /// https://open.ys7.com/help/54#device_option-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    ///<param name="oldPassword">设备旧的加密密码 </param>
    ///<param name="newPassword">设备新的加密密码，长度大超过12字节 </param>
    public static ResponseBase DevicePasswordUpdate(string deviceSerial, string oldPassword, string newPassword)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "device/password/update";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);
        request.AddQueryParameter("oldPassword", oldPassword);
        request.AddQueryParameter("newPassword", newPassword);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 添加设备
    /// https://open.ys7.com/help/54#device_option-api1
    /// </summary>
    ///<param name="ssid">路由器SSID，即WIFI名称，建议不要设置中文名称 </param>
    ///<param name="password">WIFI密码 </param>
    public static DeviceWifiQrcodeResponse DeviceWifiQrcode(string ssid, string password)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "device/wifi/qrcode";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("ssid", ssid);
        request.AddQueryParameter("password", password);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<DeviceWifiQrcodeResponse>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 添加设备
    /// https://open.ys7.com/help/54#device_option-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    ///<param name="name">通道名称，长度不大于50字节，不能包含特殊字符 </param>
    ///<param name="channelNo">非必选参数，不为空表示修改指定通道名称，为空表示修改通道1名称 </param>
    public static ResponseBase CameraNameUpdate(string deviceSerial, string name, int? channelNo = null)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "camera/name/update";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);
        request.AddQueryParameter("name", name);
        if (channelNo.HasValue)  
            request.AddQueryParameter("channelNo", channelNo.Value.ToString());

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 获取设备列表
    /// https://open.ys7.com/help/55#device_select-api1
    /// </summary>
    ///<param name="pageStart">分页起始页，从0开始 </param>
    ///<param name="pageSize">分页大小，默认为10，最大为50 </param>
    public static DeviceListResponse DeviceList(int? pageStart = null, int? pageSize = null)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "device/list";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        if (pageStart.HasValue)  
            request.AddQueryParameter("pageStart", pageStart.Value.ToString());
        if (pageSize.HasValue)  
            request.AddQueryParameter("pageSize", pageSize.Value.ToString());

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<DeviceListResponse>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 获取设备列表
    /// https://open.ys7.com/help/55#device_select-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    public static DeviceInfoResponse DeviceInfo(string deviceSerial)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "device/info";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<DeviceInfoResponse>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 获取设备列表
    /// https://open.ys7.com/help/55#device_select-api1
    /// </summary>
    ///<param name="pageStart">分页起始页，从0开始 </param>
    ///<param name="pageSize">分页大小，默认为10，最大为50 </param>
    public static CameraListResponse CameraList(int? pageStart = null, int? pageSize = null)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "camera/list";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        if (pageStart.HasValue)  
            request.AddQueryParameter("pageStart", pageStart.Value.ToString());
        if (pageSize.HasValue)  
            request.AddQueryParameter("pageSize", pageSize.Value.ToString());

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<CameraListResponse>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 获取设备列表
    /// https://open.ys7.com/help/55#device_select-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    ///<param name="channel">通道号,默认为1 </param>
    public static DeviceStatusGetResponse DeviceStatusGet(string deviceSerial, int? channel = null)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "device/status/get";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);
        if (channel.HasValue)  
            request.AddQueryParameter("channel", channel.Value.ToString());

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<DeviceStatusGetResponse>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 获取设备列表
    /// https://open.ys7.com/help/55#device_select-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    public static DeviceCameraListResponse DeviceCameraList(string deviceSerial)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "device/camera/list";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<DeviceCameraListResponse>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 获取设备列表
    /// https://open.ys7.com/help/55#device_select-api1
    /// </summary>
    ///<param name="appKey">用户appKey </param>
    ///<param name="model">设备型号 </param>
    ///<param name="version">设备版本号 </param>
    public static DeviceSupportEzvizResponse DeviceSupportEzviz(string appKey, string model, string version)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "device/support/ezviz";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("appKey", appKey);
        request.AddQueryParameter("model", model);
        request.AddQueryParameter("version", version);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<DeviceSupportEzvizResponse>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 获取设备列表
    /// https://open.ys7.com/help/55#device_select-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    public static ResponseBase DeviceCapacity(string deviceSerial)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "device/capacity";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 获取设备列表
    /// https://open.ys7.com/help/55#device_select-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    ///<param name="channelNo">通道号，非必选，默认为1 </param>
    ///<param name="startTime">起始时间，时间格式为：1378345128000。非必选，默认为当天0点 </param>
    ///<param name="endTime">结束时间，时间格式为：1378345128000。非必选，默认为当前时间 </param>
    ///<param name="recType">回放源，0-系统自动选择，1-云存储，2-本地录像。非必选，默认为0 </param>
    public static VideoByTimeResponse VideoByTime(string deviceSerial, int? channelNo = null, long? startTime = null, long? endTime = null, int? recType = null)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "video/by/time";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);
        if (channelNo.HasValue)  
            request.AddQueryParameter("channelNo", channelNo.Value.ToString());
        if (startTime.HasValue)  
            request.AddQueryParameter("startTime", startTime.Value.ToString());
        if (endTime.HasValue)  
            request.AddQueryParameter("endTime", endTime.Value.ToString());
        if (recType.HasValue)  
            request.AddQueryParameter("recType", recType.Value.ToString());

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<VideoByTimeResponse>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 设备布撤防
    /// https://open.ys7.com/help/56#device_switch-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    ///<param name="isDefence">具有防护能力设备布撤防状态：0-睡眠，8-在家，16-外出，普通IPC设备布撤防状态：`0-撤防，1-布防 </param>
    public static ResponseBase DeviceDefenceSet(string deviceSerial, int isDefence)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "device/defence/set";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);
        request.AddQueryParameter("isDefence", isDefence.ToString());

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 设备布撤防
    /// https://open.ys7.com/help/56#device_switch-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    ///<param name="validateCode">设备验证码，设备机身上的六位大写字母 </param>
    public static ResponseBase DeviceEncryptOff(string deviceSerial, string validateCode)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "device/encrypt/off";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);
        request.AddQueryParameter("validateCode", validateCode);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 设备布撤防
    /// https://open.ys7.com/help/56#device_switch-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    public static ResponseBase DeviceEncryptOn(string deviceSerial)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "device/encrypt/on";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 设备布撤防
    /// https://open.ys7.com/help/56#device_switch-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    public static DeviceSoundSwitchStatusResponse DeviceSoundSwitchStatus(string deviceSerial)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "device/sound/switch/status";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<DeviceSoundSwitchStatusResponse>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 设备布撤防
    /// https://open.ys7.com/help/56#device_switch-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    ///<param name="enable">状态：0-关闭，1-开启 </param>
    ///<param name="channelNo">通道号，不传表示设备本身 </param>
    public static ResponseBase DeviceSoundSwitchSet(string deviceSerial, int enable, int? channelNo = null)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "device/sound/switch/set";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);
        request.AddQueryParameter("enable", enable.ToString());
        if (channelNo.HasValue)  
            request.AddQueryParameter("channelNo", channelNo.Value.ToString());

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 设备布撤防
    /// https://open.ys7.com/help/56#device_switch-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    public static DeviceSceneSwitchStatusResponse DeviceSceneSwitchStatus(string deviceSerial)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "device/scene/switch/status";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<DeviceSceneSwitchStatusResponse>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 设备布撤防
    /// https://open.ys7.com/help/56#device_switch-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    ///<param name="enable">状态：0-关闭，1-开启 </param>
    ///<param name="channelNo">通道号，不传表示设备本身 </param>
    public static ResponseBase DeviceSceneSwitchSet(string deviceSerial, int enable, int? channelNo = null)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "device/scene/switch/set";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);
        request.AddQueryParameter("enable", enable.ToString());
        if (channelNo.HasValue)  
            request.AddQueryParameter("channelNo", channelNo.Value.ToString());

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 设备布撤防
    /// https://open.ys7.com/help/56#device_switch-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    public static DeviceSslSwitchStatusResponse DeviceSslSwitchStatus(string deviceSerial)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "device/ssl/switch/status";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<DeviceSslSwitchStatusResponse>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 设备布撤防
    /// https://open.ys7.com/help/56#device_switch-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    ///<param name="enable">状态：0-关闭，1-开启 </param>
    ///<param name="channelNo">通道号，不传表示设备本身 </param>
    public static ResponseBase DeviceSslSwitchSet(string deviceSerial, int enable, int? channelNo = null)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "device/ssl/switch/set";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);
        request.AddQueryParameter("enable", enable.ToString());
        if (channelNo.HasValue)  
            request.AddQueryParameter("channelNo", channelNo.Value.ToString());

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 设备布撤防
    /// https://open.ys7.com/help/56#device_switch-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    ///<param name="channelNo">非必选参数，不为空表示获取指定通道布撤防计划，为空表示获取设备本身布撤防计划 </param>
    public static DeviceDefencePlanGetResponse DeviceDefencePlanGet(string deviceSerial, int? channelNo = null)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "device/defence/plan/get";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);
        if (channelNo.HasValue)  
            request.AddQueryParameter("channelNo", channelNo.Value.ToString());

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<DeviceDefencePlanGetResponse>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 设备布撤防
    /// https://open.ys7.com/help/56#device_switch-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    ///<param name="channelNo">通道号，不传表示设备本身 </param>
    ///<param name="startTime">开始时间，如16:00，默认为00:00 </param>
    ///<param name="stopTime">结束时间，如16:30;如果为第二天,在时间前加上n,如n00:00.结束时间必须在开始时间之后,间隔不能超过24个小时 </param>
    ///<param name="period">周一~周日，用0~6表示，英文逗号分隔，默认为0,1,2,3,4,5,6 </param>
    ///<param name="enable">是否启用：1-启用，0-不启用，默认为1 </param>
    public static ResponseBase DeviceDefencePlanSet(string deviceSerial, int? channelNo = null, string startTime = "", string stopTime = "", string period = "", string enable = "")
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "device/defence/plan/set";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);
        if (channelNo.HasValue)  
            request.AddQueryParameter("channelNo", channelNo.Value.ToString());
        if (!string.IsNullOrEmpty(startTime))  
            request.AddQueryParameter("startTime", startTime);
        if (!string.IsNullOrEmpty(stopTime))  
            request.AddQueryParameter("stopTime", stopTime);
        if (!string.IsNullOrEmpty(period))  
            request.AddQueryParameter("period", period);
        if (!string.IsNullOrEmpty(enable))  
            request.AddQueryParameter("enable", enable);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 设备布撤防
    /// https://open.ys7.com/help/56#device_switch-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    public static DeviceLightSwitchStatusResponse DeviceLightSwitchStatus(string deviceSerial)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "device/light/switch/status";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<DeviceLightSwitchStatusResponse>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 设备布撤防
    /// https://open.ys7.com/help/56#device_switch-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    ///<param name="enable">状态：0-关闭，1-开启 </param>
    ///<param name="channelNo">通道号，不传表示设备本身 </param>
    public static ResponseBase DeviceLightSwitchSet(string deviceSerial, int enable, int? channelNo = null)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "device/light/switch/set";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);
        request.AddQueryParameter("enable", enable.ToString());
        if (channelNo.HasValue)  
            request.AddQueryParameter("channelNo", channelNo.Value.ToString());

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 设备布撤防
    /// https://open.ys7.com/help/56#device_switch-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    public static DeviceFulldayRecordSwitchStatusResponse DeviceFulldayRecordSwitchStatus(string deviceSerial)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "device/fullday/record/switch/status";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<DeviceFulldayRecordSwitchStatusResponse>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 设备布撤防
    /// https://open.ys7.com/help/56#device_switch-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    ///<param name="enable">状态：0-关闭，1-开启 </param>
    ///<param name="channelNo">通道号，不传表示设备本身 </param>
    public static ResponseBase DeviceFulldayRecordSwitchSet(string deviceSerial, int enable, int? channelNo = null)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "device/fullday/record/switch/set";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);
        request.AddQueryParameter("enable", enable.ToString());
        if (channelNo.HasValue)  
            request.AddQueryParameter("channelNo", channelNo.Value.ToString());

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 设备布撤防
    /// https://open.ys7.com/help/56#device_switch-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    public static DeviceAlgorithmConfigGetResponse DeviceAlgorithmConfigGet(string deviceSerial)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "device/algorithm/config/get";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<DeviceAlgorithmConfigGetResponse>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 设备布撤防
    /// https://open.ys7.com/help/56#device_switch-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    ///<param name="value">type为0时，该值为0~6，0表示灵敏度最低 </param>
    ///<param name="channelNo">通道号，不传表示设备本身 </param>
    ///<param name="type">智能算法模式：0-移动侦测灵敏度。非必选，默认为0 </param>
    public static ResponseBase DeviceAlgorithmConfigSet(string deviceSerial, int value, int? channelNo = null, int? type = null)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "device/algorithm/config/set";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);
        request.AddQueryParameter("value", value.ToString());
        if (channelNo.HasValue)  
            request.AddQueryParameter("channelNo", channelNo.Value.ToString());
        if (type.HasValue)  
            request.AddQueryParameter("type", type.Value.ToString());

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 设备布撤防
    /// https://open.ys7.com/help/56#device_switch-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    ///<param name="type">声音类型：0-短叫，1-长叫，2-静音 </param>
    public static ResponseBase DeviceAlarmSoundSet(string deviceSerial, int type)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "device/alarm/sound/set";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);
        request.AddQueryParameter("type", type.ToString());

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 设备布撤防
    /// https://open.ys7.com/help/56#device_switch-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    ///<param name="enable">状态：0-关闭，1-开启 </param>
    public static ResponseBase DeviceNotifySwitch(string deviceSerial, int enable)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "device/notify/switch";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);
        request.AddQueryParameter("enable", enable.ToString());

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 设备布撤防
    /// https://open.ys7.com/help/56#device_switch-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    public static CameraVideoSoundStatusResponse CameraVideoSoundStatus(string deviceSerial)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "camera/video/sound/status";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<CameraVideoSoundStatusResponse>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 设备布撤防
    /// https://open.ys7.com/help/56#device_switch-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    ///<param name="enable">开关状态 </param>
    public static ResponseBase CameraVideoSoundSet(string deviceSerial, string enable)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "camera/video/sound/set";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);
        request.AddQueryParameter("enable", enable);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 设备布撤防
    /// https://open.ys7.com/help/56#device_switch-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    ///<param name="enable">开关状态 </param>
    ///<param name="channelNo">通道 </param>
    public static ResponseBase DeviceMobileStatusSet(string deviceSerial, string enable, string channelNo = "")
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "device/mobile/status/set";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);
        request.AddQueryParameter("enable", enable);
        if (!string.IsNullOrEmpty(channelNo))  
            request.AddQueryParameter("channelNo", channelNo);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 设备布撤防
    /// https://open.ys7.com/help/56#device_switch-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    public static ResponseBase DeviceMobileStatusGet(string deviceSerial)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "device/mobile/status/get";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 设备布撤防
    /// https://open.ys7.com/help/56#device_switch-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    ///<param name="osdName">需设置的osd内容 </param>
    ///<param name="channelNo">通道号,默认为1 </param>
    public static ResponseBase DeviceUpdateOsdName(string deviceSerial, string osdName, string channelNo = "")
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "device/update/osd/name";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);
        request.AddQueryParameter("osdName", osdName);
        if (!string.IsNullOrEmpty(channelNo))  
            request.AddQueryParameter("channelNo", channelNo);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 设备布撤防
    /// https://open.ys7.com/help/56#device_switch-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    ///<param name="type">智能检测开关类型 302-人形过滤,304人脸抠图, 不传则代表人形过滤 </param>
    public static ResponseBase DeviceIntelligenceDetectionSwitchStatus(string deviceSerial, string type = "")
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "device/intelligence/detection/switch/status";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);
        if (!string.IsNullOrEmpty(type))  
            request.AddQueryParameter("type", type);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 设备布撤防
    /// https://open.ys7.com/help/56#device_switch-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    ///<param name="enable">状态： 0-关闭， 1-开启 </param>
    ///<param name="channelNo">通道号，非必选参数，不传表示设备本身 </param>
    ///<param name="type">智能检测开关类型 302-人形过滤,304人脸抠图, 不传则代表人形过滤 </param>
    public static ResponseBase DeviceIntelligenceDetectionSwitchSet(string deviceSerial, string enable, string channelNo = "", string type = "")
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "device/intelligence/detection/switch/set";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);
        request.AddQueryParameter("enable", enable);
        if (!string.IsNullOrEmpty(channelNo))  
            request.AddQueryParameter("channelNo", channelNo);
        if (!string.IsNullOrEmpty(type))  
            request.AddQueryParameter("type", type);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 获取设备版本信息
    /// https://open.ys7.com/help/58#device_upgrade-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    public static DeviceVersionInfoResponse DeviceVersionInfo(string deviceSerial)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "device/version/info";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<DeviceVersionInfoResponse>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 获取设备版本信息
    /// https://open.ys7.com/help/58#device_upgrade-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    public static ResponseBase DeviceUpgrade(string deviceSerial)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "device/upgrade";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 获取设备版本信息
    /// https://open.ys7.com/help/58#device_upgrade-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    public static DeviceUpgradeStatusResponse DeviceUpgradeStatus(string deviceSerial)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "device/upgrade/status";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<DeviceUpgradeStatusResponse>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 开始云台控制
    /// https://open.ys7.com/help/59#device_ptz-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    ///<param name="channelNo">通道号 </param>
    ///<param name="direction">操作命令：0-上，1-下，2-左，3-右，4-左上，5-左下，6-右上，7-右下，8-放大，9-缩小，10-近焦距，11-远焦距 </param>
    ///<param name="speed">云台速度：0-慢，1-适中，2-快，海康设备参数不可为0 </param>
    public static ResponseBase DevicePtzStart(string deviceSerial, int channelNo, int direction, int speed)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "device/ptz/start";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);
        request.AddQueryParameter("channelNo", channelNo.ToString());
        request.AddQueryParameter("direction", direction.ToString());
        request.AddQueryParameter("speed", speed.ToString());

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 开始云台控制
    /// https://open.ys7.com/help/59#device_ptz-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    ///<param name="channelNo">通道号 </param>
    ///<param name="direction">操作命令：0-上，1-下，2-左，3-右，4-左上，5-左下，6-右上，7-右下，8-放大，9-缩小，10-近焦距，11-远焦距 </param>
    public static ResponseBase DevicePtzStop(string deviceSerial, int channelNo, int? direction = null)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "device/ptz/stop";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);
        request.AddQueryParameter("channelNo", channelNo.ToString());
        if (direction.HasValue)  
            request.AddQueryParameter("direction", direction.Value.ToString());

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 开始云台控制
    /// https://open.ys7.com/help/59#device_ptz-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    ///<param name="channelNo">通道号 </param>
    ///<param name="command">镜像方向：0-上下, 1-左右, 2-中心 </param>
    public static ResponseBase DevicePtzMirror(string deviceSerial, int channelNo, int command)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "device/ptz/mirror";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);
        request.AddQueryParameter("channelNo", channelNo.ToString());
        request.AddQueryParameter("command", command.ToString());

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 开始云台控制
    /// https://open.ys7.com/help/59#device_ptz-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    ///<param name="channelNo">通道号 </param>
    public static DevicePresetAddResponse DevicePresetAdd(string deviceSerial, int channelNo)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "device/preset/add";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);
        request.AddQueryParameter("channelNo", channelNo.ToString());

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<DevicePresetAddResponse>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 开始云台控制
    /// https://open.ys7.com/help/59#device_ptz-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    ///<param name="channelNo">通道号 </param>
    ///<param name="index">预置点，C6设备预置点是1-12 </param>
    public static ResponseBase DevicePresetMove(string deviceSerial, int channelNo, int index)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "device/preset/move";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);
        request.AddQueryParameter("channelNo", channelNo.ToString());
        request.AddQueryParameter("index", index.ToString());

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 开始云台控制
    /// https://open.ys7.com/help/59#device_ptz-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    ///<param name="channelNo">通道号 </param>
    ///<param name="index">预置点，C6设备预置点是1-12 </param>
    public static ResponseBase DevicePresetClear(string deviceSerial, int channelNo, int index)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "device/preset/clear";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);
        request.AddQueryParameter("channelNo", channelNo.ToString());
        request.AddQueryParameter("index", index.ToString());

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 获取所有告警信息列表
    /// https://open.ys7.com/help/60#device_alarm-api1
    /// </summary>
    ///<param name="startTime">告警查询开始时间，时间格式为1457420564508，精确到毫秒，默认为今日0点，最多查询当前时间7天前以内的数据 </param>
    ///<param name="endTime">告警查询结束时间，时间格式为1457420771029，精确到毫秒，默认为当前时间 </param>
    ///<param name="alarmType">告警类型，默认为-1（全部） </param>
    ///<param name="status">告警消息状态：2-所有，1-已读，0-未读，默认为0（未读状态） </param>
    ///<param name="pageStart">分页起始页，从0开始，默认为0 </param>
    ///<param name="pageSize">分页大小，默认为10，最大为50 </param>
    public static AlarmListResponse AlarmList(long? startTime = null, long? endTime = null, int? alarmType = null, int? status = null, int? pageStart = null, int? pageSize = null)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "alarm/list";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        if (startTime.HasValue)  
            request.AddQueryParameter("startTime", startTime.Value.ToString());
        if (endTime.HasValue)  
            request.AddQueryParameter("endTime", endTime.Value.ToString());
        if (alarmType.HasValue)  
            request.AddQueryParameter("alarmType", alarmType.Value.ToString());
        if (status.HasValue)  
            request.AddQueryParameter("status", status.Value.ToString());
        if (pageStart.HasValue)  
            request.AddQueryParameter("pageStart", pageStart.Value.ToString());
        if (pageSize.HasValue)  
            request.AddQueryParameter("pageSize", pageSize.Value.ToString());

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<AlarmListResponse>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 获取所有告警信息列表
    /// https://open.ys7.com/help/60#device_alarm-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    ///<param name="pageSize">分页大小，默认为10，最大为,50 </param>
    ///<param name="pageStart">分页起始页，从0开始 </param>
    ///<param name="startTime">告警查询开始时间，时间格式为1457420564508，精确到毫秒，默认为今日0点，最多查询当前时间起前推7天以内的数据 </param>
    ///<param name="endTime">告警查询结束时间，时间格式为1457420771029，默认为当前时间 </param>
    ///<param name="status">告警消息状态：2-所有，1-已读，0-未读，默认为0（未读状态） </param>
    ///<param name="alarmType">告警类型，默认为-1（全部） </param>
    public static AlarmDeviceListResponse AlarmDeviceList(string deviceSerial, int? pageSize = null, int? pageStart = null, long? startTime = null, long? endTime = null, int? status = null, int? alarmType = null)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "alarm/device/list";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);
        if (pageSize.HasValue)  
            request.AddQueryParameter("pageSize", pageSize.Value.ToString());
        if (pageStart.HasValue)  
            request.AddQueryParameter("pageStart", pageStart.Value.ToString());
        if (startTime.HasValue)  
            request.AddQueryParameter("startTime", startTime.Value.ToString());
        if (endTime.HasValue)  
            request.AddQueryParameter("endTime", endTime.Value.ToString());
        if (status.HasValue)  
            request.AddQueryParameter("status", status.Value.ToString());
        if (alarmType.HasValue)  
            request.AddQueryParameter("alarmType", alarmType.Value.ToString());

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<AlarmDeviceListResponse>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 获取探测器列表
    /// https://open.ys7.com/help/61#device_detector-api1
    /// </summary>
    ///<param name="deviceSerial">网关设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    ///<param name="detectorSerial">探测器序列号 </param>
    ///<param name="safeMode">安全模式：0-在家，1-外出，2-睡眠 </param>
    ///<param name="enable">状态：0-关闭，1-开启 </param>
    public static ResponseBase DetectorStatusSet(string deviceSerial, string detectorSerial, int safeMode, int enable)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "detector/status/set";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);
        request.AddQueryParameter("detectorSerial", detectorSerial);
        request.AddQueryParameter("safeMode", safeMode.ToString());
        request.AddQueryParameter("enable", enable.ToString());

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 获取探测器列表
    /// https://open.ys7.com/help/61#device_detector-api1
    /// </summary>
    ///<param name="deviceSerial">网关设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    ///<param name="detectorSerial">探测器序列号 </param>
    public static ResponseBase DetectorDelete(string deviceSerial, string detectorSerial)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "detector/delete";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);
        request.AddQueryParameter("detectorSerial", detectorSerial);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 获取探测器列表
    /// https://open.ys7.com/help/61#device_detector-api1
    /// </summary>
    ///<param name="deviceSerial">网关设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    public static DetectorIpcListBindableResponse DetectorIpcListBindable(string deviceSerial)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "detector/ipc/list/bindable";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<DetectorIpcListBindableResponse>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 获取探测器列表
    /// https://open.ys7.com/help/61#device_detector-api1
    /// </summary>
    ///<param name="deviceSerial">网关设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    ///<param name="detectorSerial">探测器序列号 </param>
    public static DetectorIpcListBindResponse DetectorIpcListBind(string deviceSerial, string detectorSerial)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "detector/ipc/list/bind";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);
        request.AddQueryParameter("detectorSerial", detectorSerial);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<DetectorIpcListBindResponse>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 获取探测器列表
    /// https://open.ys7.com/help/61#device_detector-api1
    /// </summary>
    ///<param name="deviceSerial">网关设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    ///<param name="detectorSerial">探测器序列号 </param>
    ///<param name="ipcSerial">IPC设备序列号 </param>
    ///<param name="operation">操作：0-删除，1-绑定 </param>
    public static ResponseBase DetectorIpcRelationSet(string deviceSerial, string detectorSerial, string ipcSerial, int operation)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "detector/ipc/relation/set";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);
        request.AddQueryParameter("detectorSerial", detectorSerial);
        request.AddQueryParameter("ipcSerial", ipcSerial);
        request.AddQueryParameter("operation", operation.ToString());

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 获取探测器列表
    /// https://open.ys7.com/help/61#device_detector-api1
    /// </summary>
    ///<param name="deviceSerial">网关设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    ///<param name="detectorSerial">探测器序列号 </param>
    ///<param name="newName">新名称，长度不大于50且不包含特殊字符 </param>
    public static ResponseBase DetectorNameChange(string deviceSerial, string detectorSerial, string newName)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "detector/name/change";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);
        request.AddQueryParameter("detectorSerial", detectorSerial);
        request.AddQueryParameter("newName", newName);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 获取探测器列表
    /// https://open.ys7.com/help/61#device_detector-api1
    /// </summary>
    ///<param name="deviceSerial">网关设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    public static ResponseBase DetectorCancelAlarm(string deviceSerial)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "detector/cancelAlarm";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 获取客流统计开关状态
    /// https://open.ys7.com/help/62#device_flow-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    public static PassengerflowSwitchStatusResponse PassengerflowSwitchStatus(string deviceSerial)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "passengerflow/switch/status";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<PassengerflowSwitchStatusResponse>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 获取客流统计开关状态
    /// https://open.ys7.com/help/62#device_flow-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    ///<param name="enable">状态：0-关闭，1-开启 </param>
    ///<param name="channelNo">通道号，不传表示设备本身 </param>
    public static ResponseBase PassengerflowSwitchSet(string deviceSerial, int enable, int? channelNo = null)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "passengerflow/switch/set";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);
        request.AddQueryParameter("enable", enable.ToString());
        if (channelNo.HasValue)  
            request.AddQueryParameter("channelNo", channelNo.Value.ToString());

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 获取客流统计开关状态
    /// https://open.ys7.com/help/62#device_flow-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    ///<param name="channelNo">通道号 </param>
    ///<param name="date">时间戳日期，精确至毫秒，默认为今天，date参数只能是0时0点0分0秒（如1561046400000可以，1561050000000不行） </param>
    public static PassengerflowDailyResponse PassengerflowDaily(string deviceSerial, int channelNo, long? date = null)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "passengerflow/daily";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);
        request.AddQueryParameter("channelNo", channelNo.ToString());
        if (date.HasValue)  
            request.AddQueryParameter("date", date.Value.ToString());

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<PassengerflowDailyResponse>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 获取客流统计开关状态
    /// https://open.ys7.com/help/62#device_flow-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    ///<param name="channelNo">通道号 </param>
    ///<param name="date">时间戳日期，精确至毫秒，默认为今天 </param>
    public static PassengerflowHourlyResponse PassengerflowHourly(string deviceSerial, int channelNo, long? date = null)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "passengerflow/hourly";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);
        request.AddQueryParameter("channelNo", channelNo.ToString());
        if (date.HasValue)  
            request.AddQueryParameter("date", date.Value.ToString());

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<PassengerflowHourlyResponse>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 获取客流统计开关状态
    /// https://open.ys7.com/help/62#device_flow-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    ///<param name="line">统计线的两个坐标点，坐标范围为0到1之间的7位浮点数，(0,0)坐标在左上角，格式如{"x1": "0.0","y1": "0.5","x2": "1","y2": "0.5"} </param>
    ///<param name="direction">指示方向的两个坐标点，(x1,y1)为起始点，(x2,y2)为结束点格式如{"x1": "0.5","y1": "0.5","x2": "0.5","y2": "0.6"}，最好与统计线保持垂直 </param>
    ///<param name="channelNo">非必选参数，不为空表示配置指定通道客流统计信息，为空表示配置设备本身信息 </param>
    public static ResponseBase PassengerflowConfigSet(string deviceSerial, string line, int direction, int? channelNo = null)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "passengerflow/config/set";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);
        request.AddQueryParameter("line", line);
        request.AddQueryParameter("direction", direction.ToString());
        if (channelNo.HasValue)  
            request.AddQueryParameter("channelNo", channelNo.Value.ToString());

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 获取客流统计开关状态
    /// https://open.ys7.com/help/62#device_flow-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    ///<param name="channelNo">非必选参数，不为空表示获取指定通道客流统计配置信息，为空表示获取设备本身配置信息 </param>
    public static PassengerflowConfigGetResponse PassengerflowConfigGet(string deviceSerial, int? channelNo = null)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "passengerflow/config/get";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);
        if (channelNo.HasValue)  
            request.AddQueryParameter("channelNo", channelNo.Value.ToString());

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<PassengerflowConfigGetResponse>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 使用卡密给设备开通云存储
    /// https://open.ys7.com/help/63#cloud-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    ///<param name="channelNo">非必选参数，不为空表示操作指定通道云存储，为空表示操作设备本身云存储，默认是1 </param>
    public static CloudV2StorageDeviceInfoResponse CloudV2StorageDeviceInfo(string deviceSerial, int? channelNo = null)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "cloud/v2/storage/device/info";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);
        if (channelNo.HasValue)  
            request.AddQueryParameter("channelNo", channelNo.Value.ToString());

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<CloudV2StorageDeviceInfoResponse>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 使用卡密给设备开通云存储
    /// https://open.ys7.com/help/63#cloud-api1
    /// </summary>
    ///<param name="deviceSerial">开通云存储用户的设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    ///<param name="enable">开启或关闭云存储：0-关闭，1-开启 </param>
    ///<param name="phone">开通云存储用户的手机号，非必选参数，为空表示为当前用户开通云存储 </param>
    ///<param name="channelNo">非必选参数，不为空表示操作指定通道云存储，为空表示操作设备本身云存储，默认是1 </param>
    public static ResponseBase CloudStorageEnable(string deviceSerial, int enable, string phone = "", int? channelNo = null)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "cloud/storage/enable";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);
        request.AddQueryParameter("enable", enable.ToString());
        if (!string.IsNullOrEmpty(phone))  
            request.AddQueryParameter("phone", phone);
        if (channelNo.HasValue)  
            request.AddQueryParameter("channelNo", channelNo.Value.ToString());

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 使用卡密给设备开通云存储
    /// https://open.ys7.com/help/63#cloud-api1
    /// </summary>
    ///<param name="deviceSerial">开通云存储用户的设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    ///<param name="channelNo">非必选参数，不为空表示操作指定通道云存储，为空表示操作设备本身云存储，默认是1 </param>
    ///<param name="cloudType">云存储类型,需要由 ( 获取设备可开通的云存储类型 ) 接口获取 </param>
    ///<param name="requestId">请求ID,建议使用UUID, 注:相同的请求ID会被认为是同一个请求 </param>
    ///<param name="isImmediately">是否立即开通：0-否，1-是，默认是0. 为0表示不立即开通，当前云存储服务结束后再开始；为1表示立即开通，如果存在云服务且云服务类型一致则在当前云服务上续期，如果不一致直接覆盖当设备存在延迟生效的云存储时, 该参数选择立即开通时, 设备的云存储会全部被覆盖,只剩下新开通的云存储 </param>
    public static CloudStorageServiceOpenResponse CloudStorageServiceOpen(string deviceSerial, int channelNo, string cloudType, string requestId, int? isImmediately = null)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "cloud/storage/service/open";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);
        request.AddQueryParameter("channelNo", channelNo.ToString());
        request.AddQueryParameter("cloudType", cloudType);
        request.AddQueryParameter("requestId", requestId);
        if (isImmediately.HasValue)  
            request.AddQueryParameter("isImmediately", isImmediately.Value.ToString());

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<CloudStorageServiceOpenResponse>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 使用卡密给设备开通云存储
    /// https://open.ys7.com/help/63#cloud-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    ///<param name="channelNo">非必选参数，不为空表示操作指定通道云存储，为空表示操作设备本身云存储，默认是1 </param>
    public static CloudStorageDeviceSupportResponse CloudStorageDeviceSupport(string deviceSerial, int? channelNo = null)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "cloud/storage/device/support";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);
        if (channelNo.HasValue)  
            request.AddQueryParameter("channelNo", channelNo.Value.ToString());

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<CloudStorageDeviceSupportResponse>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 使用卡密给设备开通云存储
    /// https://open.ys7.com/help/63#cloud-api1
    /// </summary>
    ///<param name="deviceSerial">试用云存储的设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    ///<param name="requestId">请求ID, 建议UUID, 注:相同的请求ID会被认为是同一个请求 </param>
    ///<param name="channelNo">非必选参数，不为空表示操作指定通道云存储，为空表示操作设备本身云存储，默认是1 </param>
    public static CloudStorageTrialResponse CloudStorageTrial(string deviceSerial, string requestId, int? channelNo = null)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "cloud/storage/trial";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);
        request.AddQueryParameter("requestId", requestId);
        if (channelNo.HasValue)  
            request.AddQueryParameter("channelNo", channelNo.Value.ToString());

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<CloudStorageTrialResponse>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 使用卡密给设备开通云存储
    /// https://open.ys7.com/help/63#cloud-api1
    /// </summary>
    ///<param name="fromDeviceSerial">云存储转出设备的设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    ///<param name="toDeviceSerial">云存储转入设备的设备序列号 </param>
    ///<param name="requestId">请求ID, 建议UUID, 注:相同的请求ID会被认为是同一个请求 </param>
    ///<param name="fromChannelNo">非必选参数，不为空表示操作指定通道云存储，为空表示操作设备本身云存储，默认是1 </param>
    ///<param name="toChannelNo">非必选参数，不为空表示操作指定通道云存储，为空表示操作设备本身云存储，默认是1 </param>
    public static ResponseBase CloudStorageTrans(string fromDeviceSerial, string toDeviceSerial, string requestId, int? fromChannelNo = null, int? toChannelNo = null)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "cloud/storage/trans";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("fromDeviceSerial", fromDeviceSerial);
        request.AddQueryParameter("toDeviceSerial", toDeviceSerial);
        request.AddQueryParameter("requestId", requestId);
        if (fromChannelNo.HasValue)  
            request.AddQueryParameter("fromChannelNo", fromChannelNo.Value.ToString());
        if (toChannelNo.HasValue)  
            request.AddQueryParameter("toChannelNo", toChannelNo.Value.ToString());

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 使用卡密给设备开通云存储
    /// https://open.ys7.com/help/63#cloud-api1
    /// </summary>
    ///<param name="deviceSerial">开通云存储用户的设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    ///<param name="phone">开通云存储用户的手机号，非必选参数 </param>
    ///<param name="channelNo">非必选参数，不为空表示查询指定通道云存储信息，为空表示查询设备本身云存储信息，默认是1 </param>
    public static CloudStorageDeviceInfoResponse CloudStorageDeviceInfo(string deviceSerial, string phone = "", int? channelNo = null)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "cloud/storage/device/info";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);
        if (!string.IsNullOrEmpty(phone))  
            request.AddQueryParameter("phone", phone);
        if (channelNo.HasValue)  
            request.AddQueryParameter("channelNo", channelNo.Value.ToString());

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<CloudStorageDeviceInfoResponse>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 使用卡密给设备开通云存储
    /// https://open.ys7.com/help/63#cloud-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    ///<param name="channelNo">非必选参数，不为空表示操作指定通道云存储，为空表示操作设备本身云存储，默认是1 </param>
    public static CloudStorageServiceOpenInfoResponse CloudStorageServiceOpenInfo(string deviceSerial, int? channelNo = null)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "cloud/storage/service/open/info";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);
        if (channelNo.HasValue)  
            request.AddQueryParameter("channelNo", channelNo.Value.ToString());

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<CloudStorageServiceOpenInfoResponse>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 获取通话状态
    /// https://open.ys7.com/help/64#building-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    public static ResponseBase BuildingDeviceCallStatus(string deviceSerial)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "building/device/call/status";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 获取通话状态
    /// https://open.ys7.com/help/64#building-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    ///<param name="type">开锁类型，1-监视开锁；2-通话开锁 </param>
    ///<param name="channel">监视通道，1-主门口机，2-1号从门口机，3-2号从门口机，不能为1-9之外的数字 </param>
    ///<param name="lockId">锁ID，0本地锁，1外接锁 </param>
    public static ResponseBase BuildingDeviceUnlock(string deviceSerial, int type, int channel, int? lockId = null)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "building/device/unlock";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);
        request.AddQueryParameter("type", type.ToString());
        request.AddQueryParameter("channel", channel.ToString());
        if (lockId.HasValue)  
            request.AddQueryParameter("lockId", lockId.Value.ToString());

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 获取通话状态
    /// https://open.ys7.com/help/64#building-api1
    /// </summary>
    ///<param name="deviceSerial">萤石云设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    ///<param name="type">操作类型：2-接听，3-拒接， 4-响铃超时，5-挂断，6-被叫正在通话中 </param>
    public static ResponseBase BuildingDeviceCall(string deviceSerial, int type)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "building/device/call";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);
        request.AddQueryParameter("type", type.ToString());

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 获取通话状态
    /// https://open.ys7.com/help/64#building-api1
    /// </summary>
    ///<param name="deviceSerial">萤石云设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    public static ResponseBase BuildingDeviceDialingGet(string deviceSerial)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "building/device/dialing/get";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 获取通话状态
    /// https://open.ys7.com/help/64#building-api1
    /// </summary>
    ///<param name="deviceSerial">萤石云设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    public static ResponseBase BuildingDeviceList(string deviceSerial)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "building/device/list";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 获取通话状态
    /// https://open.ys7.com/help/64#building-api1
    /// </summary>
    ///<param name="deviceSerial">萤石云设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    ///<param name="type">0-配置扬声器音量；1-配置麦克风音量 </param>
    ///<param name="value">0-10之间的数字，代表配置扬声器或麦克风的音量大小 </param>
    public static ResponseBase BuildingDeviceAudioConfig(string deviceSerial, int type, int value)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "building/device/audio/config";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);
        request.AddQueryParameter("type", type.ToString());
        request.AddQueryParameter("value", value.ToString());

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 获取通话状态
    /// https://open.ys7.com/help/64#building-api1
    /// </summary>
    ///<param name="deviceSerial">萤石云设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    public static ResponseBase BuildingDeviceAudioConfigGet(string deviceSerial)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "building/device/audio/config/get";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 获取通话状态
    /// https://open.ys7.com/help/64#building-api1
    /// </summary>
    ///<param name="deviceSerial">萤石云设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    ///<param name="enable">移动侦测开关，0表示关，1表示开 </param>
    ///<param name="sensitivity">1-6之间的整数，表示移动侦测灵敏度 </param>
    public static ResponseBase BuildingDeviceDefenceConfig(string deviceSerial, int enable, int sensitivity)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "building/device/defence/config";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);
        request.AddQueryParameter("enable", enable.ToString());
        request.AddQueryParameter("sensitivity", sensitivity.ToString());

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 获取通话状态
    /// https://open.ys7.com/help/64#building-api1
    /// </summary>
    ///<param name="deviceSerial">萤石云设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    public static ResponseBase BuildingDeviceDefenceConfigGet(string deviceSerial)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "building/device/defence/config/get";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 获取通话状态
    /// https://open.ys7.com/help/64#building-api1
    /// </summary>
    ///<param name="deviceSerial">萤石云设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    public static ResponseBase BuildingDeviceStorageStatus(string deviceSerial)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "building/device/storage/status";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 获取通话状态
    /// https://open.ys7.com/help/64#building-api1
    /// </summary>
    ///<param name="deviceSerial">萤石云设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    public static ResponseBase BuildingDeviceStorageFormat(string deviceSerial)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "building/device/storage/format";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 获取通话状态
    /// https://open.ys7.com/help/64#building-api1
    /// </summary>
    ///<param name="deviceSerial">萤石云设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    public static ResponseBase BuildingDeviceInfoLogin(string deviceSerial)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "building/device/info/login";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 获取通话状态
    /// https://open.ys7.com/help/64#building-api1
    /// </summary>
    ///<param name="deviceSerial">萤石云设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    public static ResponseBase BuildingDeviceSmartlockList(string deviceSerial)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "building/device/smartlock/list";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 获取通话状态
    /// https://open.ys7.com/help/64#building-api1
    /// </summary>
    ///<param name="deviceSerial">萤石云设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    ///<param name="lockId">锁ID </param>
    ///<param name="password">锁密码 </param>
    public static ResponseBase BuildingDeviceSmartlockUnlock(string deviceSerial, int lockId, string password)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "building/device/smartlock/unlock";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);
        request.AddQueryParameter("lockId", lockId.ToString());
        request.AddQueryParameter("password", password);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 启动指纹锁验证
    /// https://open.ys7.com/help/65#keylock-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    public static ResponseBase KeylockLocalVerify(string deviceSerial)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "keylock/local/verify";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 启动指纹锁验证
    /// https://open.ys7.com/help/65#keylock-api1
    /// </summary>
    ///<param name="deviceSerial">设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    public static ResponseBase KeylockUserList(string deviceSerial)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "keylock/user/list";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 启动指纹锁验证
    /// https://open.ys7.com/help/65#keylock-api1
    /// </summary>
    ///<param name="deviceSerial">萤石云设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    ///<param name="pageStart">分页起始页，从0开始 </param>
    ///<param name="pageSize">分页大小，默认为10，最大为50 </param>
    public static ResponseBase KeylockOpenList(string deviceSerial, int? pageStart = null, int? pageSize = null)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "keylock/open/list";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);
        if (pageStart.HasValue)  
            request.AddQueryParameter("pageStart", pageStart.Value.ToString());
        if (pageSize.HasValue)  
            request.AddQueryParameter("pageSize", pageSize.Value.ToString());

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 获取子设备列表
    /// https://open.ys7.com/help/66#device_hub-api1
    /// </summary>
    ///<param name="deviceSerial">HUB设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    public static HubDeviceSubListResponse HubDeviceSubList(string deviceSerial)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "hub/device/sub/list";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<HubDeviceSubListResponse>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 获取子设备列表
    /// https://open.ys7.com/help/66#device_hub-api1
    /// </summary>
    ///<param name="deviceSerial">HUB子设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    public static HubDeviceSubInfoResponse HubDeviceSubInfo(string deviceSerial)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "hub/device/sub/info";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<HubDeviceSubInfoResponse>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 获取子设备列表
    /// https://open.ys7.com/help/66#device_hub-api1
    /// </summary>
    ///<param name="deviceSerial">子设备序列号,存在英文字母的设备序列号，字母需为大写 </param>
    public static HubDeviceCameraListResponse HubDeviceCameraList(string deviceSerial)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "hub/device/camera/list";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<HubDeviceCameraListResponse>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 获取单个子账户信息
    /// https://open.ys7.com/help/67#account-api2
    /// </summary>
    ///<param name="accountId">子账户Id </param>
    ///<param name="accountName">子账户Name </param>
    public static RamAccountGetResponse RamAccountGet(string accountId = "", string accountName = "")
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "ram/account/get";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        if (!string.IsNullOrEmpty(accountId))  
            request.AddQueryParameter("accountId", accountId);
        if (!string.IsNullOrEmpty(accountName))  
            request.AddQueryParameter("accountName", accountName);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<RamAccountGetResponse>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 获取单个子账户信息
    /// https://open.ys7.com/help/67#account-api2
    /// </summary>
    ///<param name="pageStart">分页起始页，从0开始 </param>
    ///<param name="pageSize">分页大小，默认为10，最大为50 </param>
    public static RamAccountListResponse RamAccountList(int? pageStart = null, int? pageSize = null)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "ram/account/list";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        if (pageStart.HasValue)  
            request.AddQueryParameter("pageStart", pageStart.Value.ToString());
        if (pageSize.HasValue)  
            request.AddQueryParameter("pageSize", pageSize.Value.ToString());

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<RamAccountListResponse>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 获取单个子账户信息
    /// https://open.ys7.com/help/67#account-api2
    /// </summary>
    ///<param name="accountId">子账户ID </param>
    ///<param name="oldPassword">老的密码，LowerCase(MD5(AppKey#密码明文)) </param>
    ///<param name="newPassword">新的密码，LowerCase(MD5(AppKey#密码明文)) </param>
    public static ResponseBase RamAccountUpdatePassword(string accountId, string oldPassword, string newPassword)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "ram/account/updatePassword";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("accountId", accountId);
        request.AddQueryParameter("oldPassword", oldPassword);
        request.AddQueryParameter("newPassword", newPassword);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 获取单个子账户信息
    /// https://open.ys7.com/help/67#account-api2
    /// </summary>
    ///<param name="accountId">子账户Id </param>
    ///<param name="policy">授权策略,Policy语法结构 </param>
    public static ResponseBase RamPolicySet(string accountId, string policy)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "ram/policy/set";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("accountId", accountId);
        request.AddQueryParameter("policy", policy);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 获取单个子账户信息
    /// https://open.ys7.com/help/67#account-api2
    /// </summary>
    ///<param name="accountId">子账户Id </param>
    ///<param name="statement">授权语句,Statement语法结构,示例：{"Permission": "GET", "Resource": ["dev:469631729"]} </param>
    public static ResponseBase RamStatementAdd(string accountId, string statement)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "ram/statement/add";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("accountId", accountId);
        request.AddQueryParameter("statement", statement);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 获取单个子账户信息
    /// https://open.ys7.com/help/67#account-api2
    /// </summary>
    ///<param name="accountId">子账户Id </param>
    ///<param name="deviceSerial">设备序列号 </param>
    public static ResponseBase RamStatementDelete(string accountId, string deviceSerial)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "ram/statement/delete";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("accountId", accountId);
        request.AddQueryParameter("deviceSerial", deviceSerial);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 获取单个子账户信息
    /// https://open.ys7.com/help/67#account-api2
    /// </summary>
    ///<param name="accountId">子账户Id </param>
    public static ResponseBase RamTokenGet(string accountId)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "ram/token/get";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("accountId", accountId);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 获取单个子账户信息
    /// https://open.ys7.com/help/67#account-api2
    /// </summary>
    ///<param name="accountId">子账户Id </param>
    public static ResponseBase RamAccountDelete(string accountId)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "ram/account/delete";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("accountId", accountId);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 通用文字识别
    /// https://open.ys7.com/help/70#ocr-api1
    /// </summary>
    ///<param name="dataType">数据类型(0:图片URL; 1:base64编码的二进制图片数据) </param>
    ///<param name="image">待分析的图片数据或URL,图片数据大小最大2M. 注:下载图片时可能由于网络等原因导致下载图片时间过长,建议使用base64参数直接上传图片;不支持对获得的图片数据进行加解密操作 </param>
    public static IntelligenceOcrBankCardResponse IntelligenceOcrBankCard(int dataType, string image)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "intelligence/ocr/bankCard";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("dataType", dataType.ToString());
        request.AddQueryParameter("image", image);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<IntelligenceOcrBankCardResponse>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 通用文字识别
    /// https://open.ys7.com/help/70#ocr-api1
    /// </summary>
    ///<param name="dataType">数据类型(0：图片URL; 1:base64 编码的二进制图片数据) </param>
    ///<param name="image">待分析的图片数据或URL,图片数据大小最大2M. 注:下载图片时可能由于网络等原因导致下载图片时间过长,建议使用base64参数直接上传图片;不支持对获得的图片数据进行加解密操作 </param>
    ///<param name="front">是否身份证正面带照片的一面,true - 正面, false - 反面 </param>
    ///<param name="operation">默认仅返回文字,rect-返回文字坐标 </param>
    public static IntelligenceOcrIdCardResponse IntelligenceOcrIdCard(int dataType, string image, bool front, string operation)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "intelligence/ocr/idCard";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("dataType", dataType.ToString());
        request.AddQueryParameter("image", image);
        request.AddQueryParameter("front", front.ToString());
        request.AddQueryParameter("operation", operation);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<IntelligenceOcrIdCardResponse>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 通用文字识别
    /// https://open.ys7.com/help/70#ocr-api1
    /// </summary>
    ///<param name="dataType">数据类型(0:图片URL; 1:base64 编码的二进制图片数据) </param>
    ///<param name="image">待分析的图片数据或URL,图片数据大小最大2M. 注:下载图片时可能由于网络等原因导致下载图片时间过长,建议使用base64 参数直接上传图片;不支持对获得的图片数据进行加解密操作 </param>
    public static IntelligenceOcrDriverLicenseResponse IntelligenceOcrDriverLicense(int dataType, string image)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "intelligence/ocr/driverLicense";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("dataType", dataType.ToString());
        request.AddQueryParameter("image", image);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<IntelligenceOcrDriverLicenseResponse>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 通用文字识别
    /// https://open.ys7.com/help/70#ocr-api1
    /// </summary>
    ///<param name="dataType">数据类型(0：图片URL; 1:base64编码的二进制图片数据) </param>
    ///<param name="image">待分析的图片数据或URL,图片数据大小最大2M. 注:下载图片时可能由于网络等原因导致下载图片时间过长,建议使用base64 参数直接上传图片;不支持对获得的图片数据进行加解密操作 </param>
    public static IntelligenceOcrVehicleLicenseResponse IntelligenceOcrVehicleLicense(int dataType, string image)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "intelligence/ocr/vehicleLicense";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("dataType", dataType.ToString());
        request.AddQueryParameter("image", image);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<IntelligenceOcrVehicleLicenseResponse>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 通用文字识别
    /// https://open.ys7.com/help/70#ocr-api1
    /// </summary>
    ///<param name="dataType">数据类型(0：图片URL; 1:base64编码的二进制图片数据) </param>
    ///<param name="image">待分析的图片数据或URL,图片数据大小最大2M. 注：下载图片时可能由于网络等原因导致下载图片时间过长,建议使用base64 参数直接上传图片;不支持对获得的图片数据进行加解密操作 </param>
    ///<param name="operation">默认仅返回文字,rect:返回文字坐标 </param>
    public static IntelligenceOcrBusinessLicenseResponse IntelligenceOcrBusinessLicense(int dataType, string image, string operation)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "intelligence/ocr/businessLicense";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("dataType", dataType.ToString());
        request.AddQueryParameter("image", image);
        request.AddQueryParameter("operation", operation);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<IntelligenceOcrBusinessLicenseResponse>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 通用文字识别
    /// https://open.ys7.com/help/70#ocr-api1
    /// </summary>
    ///<param name="dataType">数据类型(0:图片URL; 1:base64编码的二进制图片数据;) </param>
    ///<param name="image">待分析的图片数据或URL,图片数据大小最大2M. 注:下载图片时可能由于网络等原因导致下载图片时间过长,建议使用base64参数直接上传图片;不支持对获得的图片数据进行加解密操作 </param>
    public static IntelligenceOcrLicensePlateResponse IntelligenceOcrLicensePlate(int dataType, string image)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "intelligence/ocr/licensePlate";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("dataType", dataType.ToString());
        request.AddQueryParameter("image", image);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<IntelligenceOcrLicensePlateResponse>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 人体属性识别
    /// https://open.ys7.com/help/71#body-api1
    /// </summary>
    ///<param name="dataType">数据类型(0：图片URL; 1:base64编码的二进制图片数据) </param>
    ///<param name="image">图片，分辨率范围：50W~900W像素，图片最大2M. 注：下载图片时可能由于网络等原因导致下载图片时间过长，建议使用image_base64 参数直接上传图片；不支持对获得的图片数据进行加解密操作 </param>
    public static IntelligenceHumanAnalysisBodyResponse IntelligenceHumanAnalysisBody(int dataType, string image)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "intelligence/human/analysis/body";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("dataType", dataType.ToString());
        request.AddQueryParameter("image", image);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<IntelligenceHumanAnalysisBodyResponse>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 人体属性识别
    /// https://open.ys7.com/help/71#body-api1
    /// </summary>
    ///<param name="dataType">数据类型: 1-base64编码的二进制图片数据 </param>
    ///<param name="image">待分析的 base64 图片数据,图片数据大小不超过 2M,尺寸最大:1280*1280 </param>
    ///<param name="operation">默认仅返回是否有人,可选属性列表: number-返回具体人数, rect-返回检测的人形坐标数据,只能二选一 </param>
    public static IntelligenceHumanAnalysisDetectResponse IntelligenceHumanAnalysisDetect(int dataType, string image, string operation = "")
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "intelligence/human/analysis/detect";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("dataType", dataType.ToString());
        request.AddQueryParameter("image", image);
        if (!string.IsNullOrEmpty(operation))  
            request.AddQueryParameter("operation", operation);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<IntelligenceHumanAnalysisDetectResponse>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 创建人脸集合
    /// https://open.ys7.com/help/72#ai_face-api1
    /// </summary>
    ///<param name="setName">集合名称, 长度不大于 50 字节,不能包含特殊字符 </param>
    public static IntelligenceFaceSetCreateResponse IntelligenceFaceSetCreate(string setName)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "intelligence/face/set/create";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("setName", setName);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<IntelligenceFaceSetCreateResponse>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 创建人脸集合
    /// https://open.ys7.com/help/72#ai_face-api1
    /// </summary>
    ///<param name="setTokens">人脸集合的唯一标识，多个以英文逗号分割,一次最多支持 10 个 </param>
    public static ResponseBase IntelligenceFaceSetDelete(string setTokens)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "intelligence/face/set/delete";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("setTokens", setTokens);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 创建人脸集合
    /// https://open.ys7.com/help/72#ai_face-api1
    /// </summary>
    ///<param name="faceTokens">已检测的人脸唯一标识,多个以,分割,一次最多支持 10 个 </param>
    ///<param name="setToken">人脸集合的唯一标识 </param>
    public static ResponseBase IntelligenceFaceSetRegister(string faceTokens, int setToken)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "intelligence/face/set/register";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("faceTokens", faceTokens);
        request.AddQueryParameter("setToken", setToken.ToString());

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 创建人脸集合
    /// https://open.ys7.com/help/72#ai_face-api1
    /// </summary>
    ///<param name="faceTokens">已检测的人脸唯一标识,多个以,分割,一次最多支持 10 个 </param>
    ///<param name="setToken">人脸集合的唯一标识 </param>
    public static ResponseBase IntelligenceFaceSetRemove(string faceTokens, int setToken)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "intelligence/face/set/remove";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("faceTokens", faceTokens);
        request.AddQueryParameter("setToken", setToken.ToString());

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 创建人脸集合
    /// https://open.ys7.com/help/72#ai_face-api1
    /// </summary>
    ///<param name="dataType">数据类型： 1-base64编码的二进制图片数据, 2-已检测出人脸的 faceToken </param>
    ///<param name="imageParam1">需要比对的 faceToken1 或图片数据1 注:单张图片中必须仅一张人脸,多张人脸的图片无法比对成功 </param>
    ///<param name="imageParam2">需要比对的 faceToken2 或图片数据2 注:单张图片中必须仅一张人脸,多张人脸的图片无法比对成功 </param>
    public static IntelligenceFaceAnalysisCompareResponse IntelligenceFaceAnalysisCompare(string dataType, string imageParam1, string imageParam2)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "intelligence/face/analysis/compare";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("dataType", dataType);
        request.AddQueryParameter("imageParam1", imageParam1);
        request.AddQueryParameter("imageParam2", imageParam2);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<IntelligenceFaceAnalysisCompareResponse>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 创建人脸集合
    /// https://open.ys7.com/help/72#ai_face-api1
    /// </summary>
    ///<param name="dataType">数据类型: 2-已检测出人脸的 faceToken </param>
    ///<param name="image">需要检索的人脸 faceToken </param>
    ///<param name="operation">搜索选项：需要检索的人脸集合唯一标识,阈值与最大匹配次数:[ {            "setToken":"a66f9f63-968d-4194-9e99-731be196e6ae", /* 指定需要检索的人脸集合唯一标识*/          "threshold":80,/*识别阈值，范围为 0~100 之间，默认 80*/           "matchCount":1 /* 匹配成功计数，默认为 1 表示匹配成功一次后即结束识别, 0 表示需要识别集合中的所有人脸*/} ]检索的人脸集合可多个 </param>
    ///<param name="topNum">返回最相似人脸的个数,默认 1 个, 最多返回 5 个 </param>
    public static IntelligenceFaceAnalysisSearchResponse IntelligenceFaceAnalysisSearch(int dataType, string image, object[] operation, int topNum)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "intelligence/face/analysis/search";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("dataType", dataType.ToString());
        request.AddQueryParameter("image", image);
        request.AddQueryParameter("operation", operation.ToString());
        request.AddQueryParameter("topNum", topNum.ToString());

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<IntelligenceFaceAnalysisSearchResponse>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 车辆属性检测
    /// https://open.ys7.com/help/73#vehicle-api1
    /// </summary>
    ///<param name="dataType">数据类型(0:图片URL; 1:base64编码的二进制图片数据) </param>
    ///<param name="image">图片,分辨率范围：48W~900W像素,图片最大2M. 注:下载图片时可能由于网络等原因导致下载图片时间过长,建议使用base64参数直接上传图片;不支持对获得的图片数据进行加解密操作 </param>
    public static ResponseBase IntelligenceVehicleAnalysisProps(int dataType, string image)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "intelligence/vehicle/analysis/props";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("dataType", dataType.ToString());
        request.AddQueryParameter("image", image);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<ResponseBase>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 车辆属性检测
    /// https://open.ys7.com/help/73#vehicle-api1
    /// </summary>
    ///<param name="dataType">数据类型(0:图片URL; 1:base64编码的二进制图片数据) </param>
    ///<param name="image">图片，分辨率范围: 50W~900W像素,图片最大2M. 注:下载图片时可能由于网络等原因导致下载图片时间过长,建议使用base64参数直接上传图片; 不支持对获得的图片数据进行加解密操作 </param>
    public static IntelligenceVehicleAnalysisTrafficResponse IntelligenceVehicleAnalysisTraffic(int dataType, string image)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "intelligence/vehicle/analysis/traffic";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("dataType", dataType.ToString());
        request.AddQueryParameter("image", image);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<IntelligenceVehicleAnalysisTrafficResponse>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 安全帽检测
    /// https://open.ys7.com/help/74#target-api1
    /// </summary>
    ///<param name="dataType">数据类型(0:图片URL; 1:base64编码的二进制图片数据) </param>
    ///<param name="image">分辨率范围：1010 ~ 60006000 ; 图片最大2M安全帽检测建议图片范围：最小  640 * 480 最大 3840*2160 注:下载图片时可能由于网络等原因导致下载图片时间过长,建议使用base64参数直接上传图片;不支持对获得的图片数据进行加解密操作 </param>
    ///<param name="serviceType">服务类型(只能选一个)："helmet"(安全帽检测) </param>
    public static IntelligenceTargetAnalysisResponse IntelligenceTargetAnalysis(int dataType, string image, string serviceType)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "intelligence/target/analysis";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("dataType", dataType.ToString());
        request.AddQueryParameter("image", image);
        request.AddQueryParameter("serviceType", serviceType);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<IntelligenceTargetAnalysisResponse>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 获取播放地址
    /// https://open.ys7.com/help/82#address-api
    /// </summary>
    ///<param name="deviceSerial">直播源，例如427734222，均采用英文符号，限制50个 </param>
    ///<param name="channelNo">通道号,，非必选，默认为1 </param>
    ///<param name="code">ezopen协议地址的设备的视频加密密码 </param>
    ///<param name="expireTime">过期时长，单位秒；针对hls/rtmp设置有效期，相对时间；30秒-720天 </param>
    ///<param name="protocol">流播放协议，1-ezopen、2-hls、3-rtmp、4-flv，默认为1 </param>
    ///<param name="quality">视频清晰度，1-高清（主码流）、2-流畅（子码流） </param>
    ///<param name="startTime">ezopen协议地址的本地录像/云存储录像回放开始时间,示例：2019-12-01 00:00:00 </param>
    ///<param name="stopTime">ezopen协议地址的本地录像/云存储录像回放结束时间,示例：2019-12-01 00:00:00 </param>
    ///<param name="type">ezopen协议地址的类型，1-预览，2-本地录像回放，3-云存储录像回放，非必选，默认为1 </param>
    ///<param name="supportH265">是否要求播放视频为H265编码格式,1表示需要，0表示不要求 </param>
    ///<param name="gbchannel">国标设备的通道编号，视频通道编号ID </param>
    public static V2LiveAddressGetResponse V2LiveAddressGet(string deviceSerial, int? channelNo = null, string code = "", int? expireTime = null, int? protocol = null, int? quality = null, string startTime = "", string stopTime = "", string type = "", int? supportH265 = null, string gbchannel = "")
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "v2/live/address/get";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);
        if (channelNo.HasValue)  
            request.AddQueryParameter("channelNo", channelNo.Value.ToString());
        if (!string.IsNullOrEmpty(code))  
            request.AddQueryParameter("code", code);
        if (expireTime.HasValue)  
            request.AddQueryParameter("expireTime", expireTime.Value.ToString());
        if (protocol.HasValue)  
            request.AddQueryParameter("protocol", protocol.Value.ToString());
        if (quality.HasValue)  
            request.AddQueryParameter("quality", quality.Value.ToString());
        if (!string.IsNullOrEmpty(startTime))  
            request.AddQueryParameter("startTime", startTime);
        if (!string.IsNullOrEmpty(stopTime))  
            request.AddQueryParameter("stopTime", stopTime);
        if (!string.IsNullOrEmpty(type))  
            request.AddQueryParameter("type", type);
        if (supportH265.HasValue)  
            request.AddQueryParameter("supportH265", supportH265.Value.ToString());
        if (!string.IsNullOrEmpty(gbchannel))  
            request.AddQueryParameter("gbchannel", gbchannel);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<V2LiveAddressGetResponse>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 查询账号下流量消耗汇总
    /// https://open.ys7.com/help/84#traffic-api1
    /// </summary>
    public static TrafficUserTotalResponse TrafficUserTotal()
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "traffic/user/total";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<TrafficUserTotalResponse>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 查询账号下流量消耗汇总
    /// https://open.ys7.com/help/84#traffic-api1
    /// </summary>
    ///<param name="startTime">开始时间，时间格式为1457420564508，精确到毫秒，默认为当前日期往前推算1周。最多只能查询当前日期往前1周内的数据 </param>
    ///<param name="endTime">结束时间，时间格式为1457420564508，精确到毫秒，默认为当前日期往前推算1天。只能查询1天前的数据 </param>
    ///<param name="pageStart">分页起始页，从0开始，默认为0 </param>
    ///<param name="pageSize">分页大小，默认为10，最大为50 </param>
    public static TrafficUserDetailResponse TrafficUserDetail(long? startTime = null, long? endTime = null, int? pageStart = null, int? pageSize = null)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "traffic/user/detail";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        if (startTime.HasValue)  
            request.AddQueryParameter("startTime", startTime.Value.ToString());
        if (endTime.HasValue)  
            request.AddQueryParameter("endTime", endTime.Value.ToString());
        if (pageStart.HasValue)  
            request.AddQueryParameter("pageStart", pageStart.Value.ToString());
        if (pageSize.HasValue)  
            request.AddQueryParameter("pageSize", pageSize.Value.ToString());

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<TrafficUserDetailResponse>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 查询账号下流量消耗汇总
    /// https://open.ys7.com/help/84#traffic-api1
    /// </summary>
    ///<param name="flowTime">日期，时间格式为1457420564508，精确到毫秒，默认为当前日期往前1天。只能查询当前日期往前推算7天内、1天前的数据 </param>
    ///<param name="pageStart">分页起始页，从0开始，默认为0 </param>
    ///<param name="pageSize">分页大小，默认为10，最大为50 </param>
    public static TrafficDayDetailResponse TrafficDayDetail(long? flowTime = null, int? pageStart = null, int? pageSize = null)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "traffic/day/detail";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        if (flowTime.HasValue)  
            request.AddQueryParameter("flowTime", flowTime.Value.ToString());
        if (pageStart.HasValue)  
            request.AddQueryParameter("pageStart", pageStart.Value.ToString());
        if (pageSize.HasValue)  
            request.AddQueryParameter("pageSize", pageSize.Value.ToString());

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<TrafficDayDetailResponse>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
       
    /// <summary>
    /// 查询账号下流量消耗汇总
    /// https://open.ys7.com/help/84#traffic-api1
    /// </summary>
    ///<param name="deviceSerial"> </param>
    ///<param name="startTime">开始时间，时间格式为1457420564508，精确到毫秒，默认为当前日期往前推算1周。最多只能查询当前日期往前1周内的数据 </param>
    ///<param name="endTime">结束时间，时间格式为1457420564508，精确到毫秒，默认为当前日期往前推算1天。只能查询1天前的数据 </param>
    ///<param name="pageStart">分页起始页，从0开始，默认为0 </param>
    ///<param name="pageSize">分页大小，默认为10，最大为50 </param>
    public static TrafficDeviceDetailResponse TrafficDeviceDetail(string deviceSerial, long? startTime = null, long? endTime = null, int? pageStart = null, int? pageSize = null)
    {
        var client = Iotsys.Ezviz.Ys7Client.GetClient(false);
        var request = new RestRequest(Method.POST);
        request.Resource = "traffic/device/detail";

        request.AddQueryParameter("accessToken", Iotsys.Ezviz.Ys7Client.TokenData.AccessToken);
        request.AddQueryParameter("deviceSerial", deviceSerial);
        if (startTime.HasValue)  
            request.AddQueryParameter("startTime", startTime.Value.ToString());
        if (endTime.HasValue)  
            request.AddQueryParameter("endTime", endTime.Value.ToString());
        if (pageStart.HasValue)  
            request.AddQueryParameter("pageStart", pageStart.Value.ToString());
        if (pageSize.HasValue)  
            request.AddQueryParameter("pageSize", pageSize.Value.ToString());

        var tryTimes = 0;

        while (tryTimes++ < 3)
        {
            var response = client.Execute(request);
            var result = JsonConvert.DeserializeObject<TrafficDeviceDetailResponse>(response.Content);

            if (result.Code == "10002")
            {
                Iotsys.Ezviz.Ys7Client.UpdateAccessToken();
                continue;
            }

            return result;
        }

        return null;
    }
    }
}