using ProdutoApi.DTOs;
using ProdutoApi.Models;
using ProdutoApi.Repositories;
using System.Collections.Generic;

namespace ProdutoApi.Services
{
    public class ProdutoService
    {
        private readonly IProdutoRepository _repository;

        public ProdutoService(IProdutoRepository repository)
        {
            _repository = repository;
        }

        public void AdicionarProduto(ProdutoDTO dto)
        {
            var produto = new Produto
            {
                Nome = dto.Nome,
                Preco = dto.Preco,
                Categoria = dto.Categoria
            };
            _repository.Adicionar(produto);
        }

        public IEnumerable<Produto> ListarProdutos()
        {
            return _repository.Listar();
        }

        public void ExcluirProduto(int id)
        {
            _repository.Excluir(id);
        }

        public void AtualizarProduto(Produto produto)
        {
            _repository.Atualizar(produto);
        }
    }
}