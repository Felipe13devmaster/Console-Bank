﻿using ConsoleBank.Funcionarios;
using ConsoleBank.Sistemas;

namespace ConsoleBank
{
    public abstract class FuncionarioAutenticavel : Funcionario, Autenticavel
    {
        public string Senha { get; set; }
        public FuncionarioAutenticavel (string cpf, double salario) : base(cpf, salario)
        {

        }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
