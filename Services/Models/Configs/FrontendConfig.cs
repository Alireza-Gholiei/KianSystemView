namespace Services.Models.Configs;

public class FrontendConfig
{
    public LoginUrls LoginUrls { get; set; } = null!;
    public WebServiceUrl WebServiceUrl { get; set; } = null!;
}

public class LoginUrls
{
    public string RefreshTokenApi { get; set; } = null!;
    public string PermissionUrls { get; set; } = null!;
    public string RefreshTokenUrl { get; set; } = null!;
}

public class WebServiceUrl
{
    public string DevUrl { get; set; } = null!;
    public string DocUrl { get; set; } = null!;
    public string SSOUrl { get; set; } = null!;
    public string WfUrl { get; set; } = null!;
}