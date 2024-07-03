namespace Solid.Entidades
{
    internal class GerenciadorDeLivros
    {
        private readonly List<Livro> livros;

        public GerenciadorDeLivros()
        {
            livros = new List<Livro>();
        }

        public void AdicionarLivro(Livro livro)
        {
            livros.Add(livro);
        }

        public void RemoverLivro(Livro livro)
        {
            livros.Remove(livro);
        }

        public List<Livro> ObterLivros()
        {
            return livros;
        }
    }
}
