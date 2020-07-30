using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idioma
{   
    //VISIBILIDADE = publica
    //Pode ser Chamada e utilizda de qualquer parte do programa
    public class CumprimentadorPtBr: Cumprimentador
    {
        //VISIBILIDADE = publica
        //Pode ser Chamada e utilizda de qualquer parte do programa
        public CumprimentadorPtBr(string NomeUsuário): base(NomeUsuário)
        {
            Ola = "Olá! Tudo Bem?";
        }

    }
}
