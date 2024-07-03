namespace Solid.Entidades
{
    public class RegistroEmprestimo
    {
        public string UsuarioId { get; }
        public Livro Livro { get; }
        public DateTime DataEmprestimo { get; }

        public RegistroEmprestimo(string usuarioId, Livro livro, DateTime dataEmprestimo)
        {
            UsuarioId = usuarioId;
            Livro = livro;
            DataEmprestimo = dataEmprestimo;
        }
    }
}
