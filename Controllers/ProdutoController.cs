using Microsoft.AspNetCore.Mvc;
using ProdutoApi.DTOs;
using ProdutoApi.Models;
using ProdutoApi.Services;
using System.Collections.Generic;

namespace ProdutoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly ProdutoService _service;

        public ProdutoController(ProdutoService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Adicionar([FromBody] ProdutoDTO dto)
        {
            _service.AdicionarProduto(dto);
            return CreatedAtAction(nameof(Listar), null);
        }

        [HttpGet]
        public IEnumerable<Produto> Listar()
        {
            return _service.ListarProdutos();
        }

        [HttpDelete]
        public IActionResult Excluir([FromQuery] int id)
        {
            _service.ExcluirProduto(id);
            return NoContent();
        }

        [HttpPut]
        public IActionResult Atualizar([FromBody] Produto produto)
        {
            _service.AtualizarProduto(produto);
            return NoContent();
        }
    }
}
