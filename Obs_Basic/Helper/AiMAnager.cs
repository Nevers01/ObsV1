using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Obs_Basic.Helper
{
    internal class AiManager
    {
        private readonly string apiUrl = "http://141.98.112.152:5000/api/ai"; // kendi endpoint'in

        public async Task<string> GetAiResponseAsync(string prompt)
        {
            if (string.IsNullOrWhiteSpace(prompt))
                return "Lütfen bir mesaj yazın.";

            using (HttpClient client = new HttpClient())
            {
                var data = new { Prompt = prompt };
                var json = JsonConvert.SerializeObject(data);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                try
                {
                    var response = await client.PostAsync(apiUrl, content);

                    if (response.IsSuccessStatusCode)
                        return await response.Content.ReadAsStringAsync();
                    else
                        return $"Hata: {response.StatusCode}";
                }
                catch (Exception ex)
                {
                    return $"İstisna: {ex.Message}";
                }
            }
        }
    }
}