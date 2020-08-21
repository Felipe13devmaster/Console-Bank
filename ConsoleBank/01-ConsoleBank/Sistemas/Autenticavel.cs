using ConsoleBank.Funcionarios;

namespace ConsoleBank.Sistemas
{
    public interface Autenticavel 
    {
        bool Autenticar(string senha);
    }
}
