using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Alura.LeilaoOnline.WebApp.Models;

// System.Data - Ado.NET
// System.Data.SqlClient - provider Sql Server

namespace Alura.LeilaoOnline.WebApp.Dados.EfCore
{
    public class LeilaoDaoComEfCore : ILeilaoDao
    {

        AppDbContext _context;

        public LeilaoDaoComEfCore()
        {
            _context = new AppDbContext();
        }

        public IEnumerable<Categoria> BuscarCategorias()
        {
            return _context.Categorias.ToList();
        }

        public IEnumerable<Leilao> BuscarLeiloes()
        {
            return _context.Leiloes
                .Include(l => l.Categoria)
                .ToList();
        }

        public Leilao BuscarLeilao(int leilao)
        {
            return _context.Leiloes.Find(leilao);
        }

        public void Incluir(Leilao leilao)
        {
            _context.Leiloes.Add(leilao);
            _context.SaveChanges();
        }

        public void Alterar(Leilao leilao)
        {
            _context.Leiloes.Update(leilao);
            _context.SaveChanges();
        }

        public void Excluir(Leilao leilao)
        {
            _context.Leiloes.Remove(leilao);
            _context.SaveChanges();
        }

        public Leilao BuscaPorId(int id)
        {
            return _context.Leiloes.First(l => l.Id == id);
        }
    }
}
