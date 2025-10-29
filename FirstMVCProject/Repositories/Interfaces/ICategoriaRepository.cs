using FirstMVCProject.Models;

namespace FirstMVCProject.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }

        }
}
