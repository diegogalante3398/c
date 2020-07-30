using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idioma
{
    //VISIBILIDADE = publica
    //Pode ser Chamada e utilizda de qualquer parte do programa
    class CumprimentadorEnUs : Cumprimentador
    {
        //VISIBILIDADE = publica
        //Pode ser Chamada e utilizda de qualquer parte do programa
        public CumprimentadorEnUs(string NomeUsuario): base(NomeUsuario)
        {
            Ola = "Hello! All well?";
        }
    }
}
