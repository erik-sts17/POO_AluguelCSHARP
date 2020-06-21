using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Vetor1
{
    class Estudante
    {
        private string _nome;
        private string _email;

        public Estudante(string nome, string email)
        {
            _nome = nome;
            _email = email;
        }

        public string Nome { get => _nome; set => _nome = value; }
        public string Email { get => _email; set => _email = value; }

        public override string ToString()
        {
            return Nome + "," + Email;
        }

        

    }
}
