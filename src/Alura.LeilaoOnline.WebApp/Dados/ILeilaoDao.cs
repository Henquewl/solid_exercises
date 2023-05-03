using System.Collections.Generic;
using Alura.LeilaoOnline.WebApp.Models;

namespace Alura.LeilaoOnline.WebApp.Dados
{
    public interface ILeilaoDao
    {
        IEnumerable<Categoria> BuscarCategorias();

        IEnumerable<Leilao> BuscarLeiloes();

        Leilao BuscarLeilao(int leilao);

        void Incluir(Leilao leilao);

        void Alterar(Leilao leilao);

        void Excluir(Leilao leilao);

        Leilao BuscaPorId(int id);
    }
}
