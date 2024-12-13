using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FinancialFlowManager.Api.ConsolidationService.Configurations
{
    public class VaultService
    {
        private readonly string _vaultAddress;
        private readonly string _vaultToken;

        public VaultService(IConfiguration configuration)
        {
            _vaultAddress = configuration["Vault:Address"];
            _vaultToken = configuration["Vault:Token"];
        }

        public async Task<string> GetConnectionStringAsync()
        {
            // Configurações
            var vaultAddress = "http://vault:8200"; // Certifique-se de que está configurado corretamente
            var vaultToken = "root"; // Token do Vault
            var secretsPath = "v1/FinancialFlow/ConnectionString"; // Path correto para kv v1

            using var client = new HttpClient { BaseAddress = new Uri(vaultAddress) };

            // Adiciona o token do Vault como cabeçalho
            client.DefaultRequestHeaders.Add("X-Vault-Token", vaultToken);

            try
            {
                // Faz a requisição GET para o Vault
                var response = await client.GetAsync(secretsPath);
                response.EnsureSuccessStatusCode(); // Lança uma exceção se a resposta não for bem-sucedida

                // Lê o conteúdo da resposta e o desserializa
                var json = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<dynamic>(json);

                // Retorna a ConnectionString
                return data?.data?.ConnectionString;
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Erro ao acessar o Vault: {ex.Message}");
                throw new InvalidOperationException("Erro ao obter a ConnectionString do Vault.", ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro inesperado: {ex.Message}");
                throw;
            }
        }

    }
}
