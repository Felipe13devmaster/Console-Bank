using ConsoleBank.Funcionarios;

namespace ConsoleBank.Sistemas
{
    public interface IAutenticavel 
    {
        bool Autenticar(string senha);
    }
}
