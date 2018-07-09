using System;
using System.Threading.Tasks;
using System.Web.UI;

public partial class _Default : System.Web.UI.Page 
{
    protected  void Page_Load(object sender, EventArgs e)
    {
        RegisterAsyncTask(new PageAsyncTask(PageLoadAsync));
    }

    // Async Page Load
    public async Task PageLoadAsync()
    {
        // Get Client Settings
        var clientSettings = new MediaMarkup.Settings
        {
            ApiBaseUrl = Settings.MediaMarkupBaseUrl,
            ClientId = Settings.MediaMarkupClientId,
            SecretKey = Settings.MediaMarkupSecretKey
        };

        // Create API Client
        var apiClient = new MediaMarkup.ApiClient(clientSettings);

        // Initialise API Client (Validates api keys and gets an api token for subsequest api calls)
        var token = await apiClient.InitializeAsync();

        // Check authentication
        Label1.Text = (await apiClient.Authenticated()).ToString().ToLower() == "true" ? "Yes" : "No";
    }
}