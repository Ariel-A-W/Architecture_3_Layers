using _3LayerArchitecture.DataLayer;

namespace _3LayerArchitecture.BusinessLayer;

public interface IClienteService 
{
    List<Cliente> GetAll();
    Cliente GetById(int id);
}
