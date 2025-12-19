using Microsoft.AspNetCore.Mvc;
using NetCoreAI.Project02_ApiConsumeUI.DTOs;
using Newtonsoft.Json;

namespace NetCoreAI.Project02_ApiConsumeUI.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CustomerController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> CustomerList()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7116/api/Customers");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultCustomerDTO>>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public IActionResult AddCustomer()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddCustomer(CreateCustomerDTO createCustomerDTO)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createCustomerDTO);
            StringContent stringContent = new StringContent(jsonData, System.Text.Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7116/api/Customers", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("CustomerList");
            }
            return View();
        }
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7116/api/Customers?id={id}");
            return RedirectToAction("CustomerList");
        }
        [HttpGet]
        public async Task<IActionResult> UpdateCustomer(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7116/api/Customers/GetCustomer?id={id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<GetByIdCustomerDTO>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateCustomer(UpdateCustomerDTO updateCustomerDTO)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateCustomerDTO);
            StringContent stringContent = new StringContent(jsonData, System.Text.Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7116/api/Customers", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("CustomerList");
            }
            return View();
        }
    }
}
