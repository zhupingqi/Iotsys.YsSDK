萤石开放平台 .net sdk
https://open.ys7.com/help/19

1. 根据需求使用 Iotsys.YsSDK 重新生成类库(也可以不重新生成)

2. 将Iotsys.Ezviz拷贝到自己的项目中

3. 修改Iotsys.Ezviz/Ys7Client.cs文件中 appKey , appSecret 为自身项目信息

4. 修改以下方法

```
public static AccessTokenResponseData ReadAccsessToken()
{
    //var token = Repository.Setting.Get("ys_accessToken");
    //if (token != null)
    //{
    //    return JsonConvert.DeserializeObject<AccessTokenResponseData>(token.Value);
    //}

   return null;
}

public static void UpdateAccessToken(AccessTokenResponseData token)
{
    //Repository.Setting.Update("ys_accessToken", JsonConvert.SerializeObject(accessTokenData));
}
```

修改注释部分代码，以实现Token持久化

5. 编译项目运行

 ** 联系方式** 

![输入图片说明](https://images.gitee.com/uploads/images/2022/0106/164720_1a41a6f0_1970137.png "屏幕截图.png")
![输入图片说明](https://images.gitee.com/uploads/images/2022/0106/164728_a64d0838_1970137.png "屏幕截图.png")
