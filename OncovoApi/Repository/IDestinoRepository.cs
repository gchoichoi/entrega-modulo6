using OncovoApi.Model;

namespace OncovoApi.Repository
{
    public interface IDestinoRepository
    {
        //Get all
        Task<IEnumerable<Destino>> GetDestinos();

        //Get by Id
        Task<Destino> GetDestinosById(int Id);

        //Add destino
        void AddDestino(Destino destino);

        //Atualizar destino
        void AtualizarDestino(Destino destino);

        //Deletar destino
        void DeletarDestino(Destino destino);

        //Executar tudo isso no banco
        Task<bool> SaveChangesAsync();
    }
}