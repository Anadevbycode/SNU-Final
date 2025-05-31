using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SNU.Dominio;
using SNU.Repositorio;
using SNU.Servico;

namespace SNU.Servico
{
    public class AlunoServico : IAlunoServico
    {
        private readonly IAlunoRepositorio _alunoRepositorio;

        public AlunoServico(IAlunoRepositorio alunoRepositorio)
        {
            _alunoRepositorio = alunoRepositorio;
        }

        public void Adicionar(AlunoDto alunoDto)
        {
            var aluno = new Aluno(alunoDto.Nome, alunoDto.Nota);
            _alunoRepositorio.Salvar(aluno);
        }

        public IEnumerable<AlunoDto> Listar()
        {
            return _alunoRepositorio.Listar().Select(aluno =>
                        new AlunoDto { Nome = aluno.Nome, Nota = aluno.Nota });
        }
    }
}