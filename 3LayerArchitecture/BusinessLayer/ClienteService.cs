using _3LayerArchitecture.DataLayer;

namespace _3LayerArchitecture.BusinessLayer;

public class ClienteService : IClienteRepository, IClienteService
{
    private readonly IClienteRepository _clienteRepository;

    public ClienteService(IClienteRepository clienteRepository)
    {
        _clienteRepository = clienteRepository;
    }

    public List<Cliente> GetAll()
    {
        return _clienteRepository.GetAll();
    }

    public Cliente GetById(int id)
    {
        Cliente? cliente =
            _clienteRepository
            .GetAll()
            .FirstOrDefault(x => x.ID == id);
        
        if (cliente == null)
        {
            return null!;
        }

        return cliente!;
    }
}
