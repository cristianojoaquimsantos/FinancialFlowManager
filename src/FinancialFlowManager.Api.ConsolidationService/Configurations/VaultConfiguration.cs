using Newtonsoft.Json.Linq;

namespace FinancialFlowManager.Api.ConsolidationService.Configurations
{
    public class VaultService
    {
        private readonly string _vaultAddress;
        private readonly string _vaultToken;

        public VaultService(IConfiguration configuration)
        {
            _vaultAddress = configuration["Vault__Address"];
            _vaultToken = configuration["Vault__Token"];
        }

        public async Task<string> GetConnectionStringAsync()
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("X-Vault-Token", _vaultToken);

            var response = await client.GetAsync($"{_vaultAddress}/v1/secret/data/financialmanager");
            response.EnsureSuccessStatusCode();

            var json = JObject.Parse(await response.Content.ReadAsStringAsync());
            return json["data"]["data"]["ConnectionString"].ToString();
        }
    }
}
