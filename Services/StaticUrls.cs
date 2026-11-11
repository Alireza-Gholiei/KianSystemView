namespace Services;

public static class StaticUrls
{
    public static void Init(string? devUrl, string? sSOUrl, string? docUrl, string? wfUrl)
    {
        DevUrl = devUrl ?? "";
        DocUrl = docUrl ?? "";
        SSOUrl = sSOUrl ?? "";
        WfUrl = wfUrl ?? "";
    }

    public static string DevUrl = "";
    public static string DocUrl = "";
    public static string SSOUrl = "";
    public static string WfUrl = "";
}