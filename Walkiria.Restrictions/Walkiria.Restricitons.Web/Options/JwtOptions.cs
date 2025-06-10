namespace Walkiria.Restricitons.Web.Options;

public class JwtOptions
{
    public string Issure { get; set; }

    public string Audience { get; set; }

    public string Expires { get; set; }

    public string SecretKey { get; set; }
}