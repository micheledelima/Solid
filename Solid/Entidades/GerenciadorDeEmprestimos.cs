using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Entidades
{
    internal class GerenciadorDeEmprestimos
    {
        private readonly GerenciadorDeLivros _livros;
        private Dictionary<string, RegistroEmprestimo> _registrosEmprestimo;

        public GerenciadorDeEmprestimos(GerenciadorDeLivros livros)
        {
            _livros = livros;
            _registrosEmprestimo = new Dictionary<string, RegistroEmprestimo>();
        }

        public void EmprestarLivro(string usuarioId, Livro livro)
        {
            if (_livros.ObterLivros().Contains(livro))
            {
                _registrosEmprestimo[usuarioId] = new RegistroEmprestimo(usuarioId, livro, DateTime.Now);
                _livros.RemoverLivro(livro);
            }
        }

        public void DevolverLivro(string usuarioId, Livro livro)
        {
            if (_registrosEmprestimo.TryGetValue(usuarioId, out var registro) && registro.Livro.Equals(livro))
            {
                _livros.AdicionarLivro(livro);
                _registrosEmprestimo.Remove(usuarioId);
            }
        }

        public double CalcularMulta(string usuarioId)
        {
            if (_registrosEmprestimo.TryGetValue(usuarioId, out var registro))
            {
                var diasEmprestados = (DateTime.Now - registro.DataEmprestimo).TotalDays;
                if (diasEmprestados > 14)
                {
                    return (diasEmprestados - 14) * 0.5;
                }
            }
            return 0.0;
        }
    }
}
