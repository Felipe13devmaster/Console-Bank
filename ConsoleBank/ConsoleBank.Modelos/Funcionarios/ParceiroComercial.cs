using ConsoleBank.Modelos.Helper;
using ConsoleBank.Modelos.Sistemas;

namespace ConsoleBank.Modelos.Funcionarios
{
    public class ParceiroComercial : IAutenticavel
    {
        private AutenticacaoHelper _autenticacaoHelper = new AutenticacaoHelper();
        public string Senha { get; set; }
        public bool Autenticar(string senha)
        {
            return _autenticacaoHelper.CompararSenhas(Senha, senha);
        }
    }
}
