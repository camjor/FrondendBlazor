  using BlazorAppPrueba2.Models;
    using System.Net.Http.Json;

namespace BlazorAppPrueba2.Services
{
  

    public class PersonaService
    {
        private readonly HttpClient _http;

        public PersonaService(HttpClient http)
        {
            _http = http;
        }

        // LOGIN de usuario
        public async Task<PersonaResponseDto?> LoginAsync(PersonaLoginRequestDto request)
        {
            var response = await _http.PostAsJsonAsync("personas/login", request);
            return await response.Content.ReadFromJsonAsync<PersonaResponseDto>();
        }

        // REGISTRAR nuevo usuario
        public async Task<PersonaResponseDto?> RegistrarAsync(PersonaRegistroRequestDto request)
        {
            var response = await _http.PostAsJsonAsync("personas/registrar", request);
            return await response.Content.ReadFromJsonAsync<PersonaResponseDto>();
        }

        // OBTENER usuario autenticado
        public async Task<PersonaResponseDto?> GetUsuarioAsync()
        {
            return await _http.GetFromJsonAsync<PersonaResponseDto>("personas");
        }

        // OBTENER todas las personas
        public async Task<List<Persona>?> GetAllPersonasAsync()
        {
            return await _http.GetFromJsonAsync<List<Persona>>("personas/all");
        }

        // ACTUALIZAR persona
        public async Task<bool> UpdatePersonaAsync(string identificacion, Persona persona)
        {
            var response = await _http.PutAsJsonAsync($"personas/{identificacion}", persona);
            return response.IsSuccessStatusCode;
        }

        // ELIMINAR persona
        public async Task<bool> DeletePersonaAsync(string identificacion)
        {
            var response = await _http.DeleteAsync($"personas/{identificacion}");
            return response.IsSuccessStatusCode;
        }
    }

}
