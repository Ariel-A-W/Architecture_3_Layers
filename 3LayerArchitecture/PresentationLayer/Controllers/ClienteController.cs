using _3LayerArchitecture.BusinessLayer;
using _3LayerArchitecture.DataLayer;
using Microsoft.AspNetCore.Mvc;

namespace _3LayerArchitecture.PresentationLayer.Controllers;

[ApiController]
[Route("[controller]")]
public class ClienteController : ControllerBase
{
    private readonly ClienteService _cliente;

    public ClienteController(ClienteService cliente)
    {
        _cliente = cliente;
    }

    [HttpGet]
    public IEnumerable<Cliente> Get()
    {
        return _cliente.GetAll();
    }

    [HttpGet("getbyid")]
    public ActionResult<Cliente> GetById(int id)
    {
        if (_cliente.GetById(id) == null)
            return NotFound("No encontrado.");

        return Ok(_cliente.GetById(id));
    }
}
