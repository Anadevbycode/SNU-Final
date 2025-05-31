using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SNU.Servico;

namespace SNU.Servico
{
    public interface IAlunoServico
    {
        void Adicionar(AlunoDto alunoDto);
        IEnumerable<AlunoDto> Listar();
    }
}