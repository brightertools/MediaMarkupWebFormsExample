using System.Configuration;

public static class Settings
{
    public static string MediaMarkupBaseUrl
    {
        get
        {
            if (string.IsNullOrWhiteSpace(ConfigurationManager.AppSettings["MediaMarkup.BaseUrl"]))
            {
                return string.Empty;
            }

            return ConfigurationManager.AppSettings["MediaMarkup.BaseUrl"];
        }
    }  

    public static string MediaMarkupClientId
    {
        get
        {
            if (string.IsNullOrWhiteSpace(ConfigurationManager.AppSettings["MediaMarkup.ClientId"]))
            {
                return string.Empty;
            }

            return ConfigurationManager.AppSettings["MediaMarkup.ClientId"];
        }
    }  

    public static string MediaMarkupSecretKey
    {
        get
        {
            if (string.IsNullOrWhiteSpace(ConfigurationManager.AppSettings["MediaMarkup.SecretKey"]))
            {
                return string.Empty;
            }

            return ConfigurationManager.AppSettings["MediaMarkup.SecretKey"];
        }
    }  
}