using ProdutoApi.Models;
using System.Collections.Generic;

namespace ProdutoApi.Repositories
{
    public interface IProdutoRepository
    {
        void Adicionar(Produto produto);
        IEnumerable<Produto> Listar();
        void Excluir(int id);
        void Atualizar(Produto produto);
    }
}
