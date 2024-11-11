
namespace _3LayerArchitecture.DataLayer;

/**
 * Importante:
 * Aquí simulamos que estamos conectado a una base dedatos 
 * y desde allí podemos acceder a los datos. Este ejemplo 
 * está construido con código para la simulación.
 */
public class ClienteRepository : IClienteRepository
{
    public List<Cliente> GetAll()
    {
        List<Cliente> cliente = new List<Cliente>([
            new Cliente() {
                ID = 1,
                Razon = "SOLUTIX SRL",
                Movil = "+5491144337788",
                Email = "info@solutix.com.ar"
            },
            new Cliente() {
                ID = 2,
                Razon = "FRENCH HNS",
                Movil = "+5491166997733",
                Email = "contacto@frenchhermanos.com.ar"
            },
            new Cliente() {
                ID = 3,
                Razon = "GRUPO CIVERICO SA",
                Movil = "+5491144337788",
                Email = "ventas@grupociverico.com.ar"
            },
        ]);
        return cliente;
    }
}
