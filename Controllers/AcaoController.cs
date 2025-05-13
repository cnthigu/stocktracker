using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using StockTracker.Models;

namespace StockTracker.Controllers
{
    public class AcaoController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;

        public AcaoController(IHttpClientFactory httpClientFactory, IConfiguration config)
        {
            _httpClient = httpClientFactory.CreateClient();
            _apiKey = config["TwelveData:ApiKey"];
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Buscar(string simbolo)
        {
            if (string.IsNullOrEmpty(simbolo))
            {
                ViewBag.Erro = "Informe um símbolo de ação (ex: AAPL)";
                return View("Index");
            }

            var url = $"https://api.twelvedata.com/quote?symbol={simbolo}&apikey={_apiKey}";

            var resposta = await _httpClient.GetAsync(url);
            var json = await resposta.Content.ReadAsStringAsync();
            var dados = JObject.Parse(json);

            if (dados["code"] != null)
            {
                ViewBag.Erro = dados["message"]?.ToString();
                return View("Index");
            }

            var acao = new Acao
            {
                Nome = dados["name"]?.ToString(),
                Simbolo = dados["symbol"]?.ToString(),
                Bolsa = dados["exchange"]?.ToString(),
                Moeda = dados["currency"]?.ToString(),
                Preco = dados["close"]?.ToString() 
            };

            return View("Resultado", acao);
        }
    }
}
