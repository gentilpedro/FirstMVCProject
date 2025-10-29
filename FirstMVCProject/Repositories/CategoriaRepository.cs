using FirstMVCProject.Context;
using FirstMVCProject.Models;
using FirstMVCProject.Repositories.Interfaces;

namespace FirstMVCProject.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
                private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
