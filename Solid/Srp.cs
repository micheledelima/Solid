using Solid.Entidades;
using Solid.Repositorios;

namespace Solid
{
    public class Biblioteca
    {
        private readonly GerenciadorDeLivros _livros;
        private readonly GerenciadorDeEmprestimos _emprestimos;
        private readonly BibliotecaRepositorio _bibliotecaRepo;

        public Biblioteca()
        {
            _livros = new GerenciadorDeLivros();
            _emprestimos = new GerenciadorDeEmprestimos(_livros);
            _bibliotecaRepo = new BibliotecaRepositorio();
        }

        public void AdicionarLivro(Livro livro)
        {
            _livros.AdicionarLivro(livro);
        }

        public void RemoverLivro(Livro livro)
        {
            _livros.RemoverLivro(livro);
        }

        public List<Livro> ObterLivros()
        {
            return _livros.ObterLivros();
        }

        public void EmprestarLivro(string usuarioId, Livro livro)
        {
            _emprestimos.EmprestarLivro(usuarioId, livro);
        }

        public void DevolverLivro(string usuarioId, Livro livro)
        {
            _emprestimos.DevolverLivro(usuarioId, livro);
        }

        public double CalcularMulta(string usuarioId)
        {
            return _emprestimos.CalcularMulta(usuarioId);
        }

        public void SalvarDadosBiblioteca()
        {
            _bibliotecaRepo.SalvarDadosBiblioteca();
        }

        public void CarregarDadosBiblioteca()
        {
            _bibliotecaRepo.CarregarDadosBiblioteca();
        }

        public void GerarRelatorio()
        {
            _bibliotecaRepo.GerarRelatorio();
        }
    }
}
