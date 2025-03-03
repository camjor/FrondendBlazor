using BlazorAppPrueba2.Models;

namespace BlazorAppPrueba2.Services
{
    public class TareaService
    {
        private readonly HttpClient _http;

        public TareaService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Tarea>> GetTareasAsync()
        {
            return await _http.GetFromJsonAsync<List<Tarea>>("Tarea"); // Endpoint del backend
        }

        public async Task<Tarea> GetTareaByIdAsync(int id)
        {
            return await _http.GetFromJsonAsync<Tarea>($"Tarea/{id}");
        }

        public async Task CreateTareaAsync(Tarea tarea)
        {
            await _http.PostAsJsonAsync("Tarea", tarea);
        }

        public async Task DeleteTareaAsync(int id)
        {
            await _http.DeleteAsync($"Tarea/{id}");
        }
    }
}
