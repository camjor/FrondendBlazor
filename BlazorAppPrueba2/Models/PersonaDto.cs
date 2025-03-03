namespace BlazorAppPrueba2.Models;
 // Asegúrate de que coincide con el namespace de tu proyecto Blazor

public class PersonaResponseDto
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string UserName { get; set; }
    public string Identificacion { get; set; }
}

public class PersonaLoginRequestDto
{
    public string UserName { get; set; }
    public string Password { get; set; }
}

public class PersonaRegistroRequestDto
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string UserName { get; set; }
    public string Identificacion { get; set; }
    public string Password { get; set; }
}
