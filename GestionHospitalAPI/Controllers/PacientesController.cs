using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class PacientesController : ControllerBase
{
    private static readonly List<Paciente> Pacientes = new List<Paciente>();

    [HttpGet]
    public ActionResult<IEnumerable<Paciente>> GetPacientes()
    {
        return Ok(Pacientes);
    }

    [HttpGet("{id}")]
    public ActionResult<Paciente> GetPaciente(int id)
    {
        var paciente = Pacientes.FirstOrDefault(p => p.ID_Paciente == id);
        if (paciente == null)
        {
            return NotFound();
        }
        return Ok(paciente);
    }

    [HttpPost]
    public ActionResult<Paciente> CreatePaciente(Paciente paciente)
    {
        paciente.ID_Paciente = Pacientes.Count + 1;
        Pacientes.Add(paciente);
        return CreatedAtAction(nameof(GetPaciente), new { id = paciente.ID_Paciente }, paciente);
    }

    [HttpPut("{id}")]
    public IActionResult UpdatePaciente(int id, Paciente updatedPaciente)
    {
        var paciente = Pacientes.FirstOrDefault(p => p.ID_Paciente == id);
        if (paciente == null)
        {
            return NotFound();
        }
        paciente.Nombre = updatedPaciente.Nombre;
        paciente.Edad = updatedPaciente.Edad;
        // Actualiza otros campos
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeletePaciente(int id)
    {
        var paciente = Pacientes.FirstOrDefault(p => p.ID_Paciente == id);
        if (paciente == null)
        {
            return NotFound();
        }
        Pacientes.Remove(paciente);
        return NoContent();
    }
}
