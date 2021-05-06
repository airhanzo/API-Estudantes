using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplicaçãodeAlunos.Models
{
    public class Turmas
    {
        public Turmas (int id)
        {
            Id = id;
            Alunos = new List<Aluno>();
        }

        public int Id { get; private set; }
        public int Id { get; private set; }
        public List<Aluno> Alunos { get; private set; }
    }
}
