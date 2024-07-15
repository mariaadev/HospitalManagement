public class Paciente
{
    public int ID_Paciente { get; set; }
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Fecha_Nacimiento { get; set; }
    public string Sintomas { get; set; }
    public string Estado { get; set; } = "Pendiente de cama";
    public DateTime Fecha_Registro { get; set; } = DateTime.Now;
    public string Seguridad_Social { get; set; }
    public string Direccion { get; set; }
    public string Telefono { get; set; }
    public string Email { get; set; }
    public string Historial_Medico { get; set; }

}
