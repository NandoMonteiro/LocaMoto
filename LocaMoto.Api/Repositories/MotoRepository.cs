using LocaMoto.Api.Context;
using LocaMoto.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace LocaMoto.Api.Repositories;

public class MotoRepository : IMotoRepository
{
    private readonly AppDbContext _context;
    public MotoRepository(AppDbContext context) 
    { 
        _context = context; 
    }

    public async Task<Moto> GetMoto(int id)
    {
       var moto = _context.Motos
                    .Include(c=> c.Categoria)
                    .SingleOrDefault(c => c.Id == id);

        return moto;
    }

    public async Task<IEnumerable<Moto>> GetMotos()
    {
        var motos = await _context.Motos
                    .Include(m => m.Categoria)
                    .ToListAsync();

        return motos;
    }

    public async Task<IEnumerable<Moto>> GetMotosPorCategoria(int id)
    {
        var motos = await _context.Motos
                    .Include(m => m.Categoria)
                    .Where(m => m.Id == id).ToListAsync();

        return motos;
    }
}
