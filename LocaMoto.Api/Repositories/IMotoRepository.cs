using LocaMoto.Api.Entities;

namespace LocaMoto.Api.Repositories;

public interface IMotoRepository
{
    Task<IEnumerable<Moto>> GetMotos();
    Task<Moto> GetMoto(int id);
    Task<IEnumerable<Moto>> GetMotosPorCategoria(int id);
}
