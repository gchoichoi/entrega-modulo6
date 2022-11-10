using Microsoft.EntityFrameworkCore;
using OncovoApi.Database;
using OncovoApi.Model;

namespace OncovoApi.Repository
{
    public class DestinoRepository : IDestinoRepository
    {
        //Injetar dependencia do contexto
        private readonly DestinoDbContext _context;
        
        public DestinoRepository(DestinoDbContext context){
            _context = context;
        }

        public void AddDestino(Destino destino)
        {
            _context.Add(destino);
        }

        public void AtualizarDestino(Destino destino)
        {
            _context.Update(destino);
        }

        public void DeletarDestino(Destino destino)
        {
            _context.Remove(destino);
        }

        public async Task<Destino> GetDestinosById(int Id)
        {
            return await _context.Destinos.Where(x => x.Id == Id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Destino>> GetDestinos()
        {
            return await _context.Destinos.ToListAsync();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}