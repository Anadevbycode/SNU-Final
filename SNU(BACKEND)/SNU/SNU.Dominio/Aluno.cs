using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNU.Dominio
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Nota { get; set; }

        public Aluno(string nome, decimal nota)
        {
            Nome = nome;
            Nota = nota;
        }

        public bool Aprovado()
        {
            return Nota > 7;
        }
    }
}
