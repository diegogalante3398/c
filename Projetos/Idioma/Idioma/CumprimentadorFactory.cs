using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idioma
{
    //VISIBILIDADE = publica
    //Pode ser Chamada e utilizda de qualquer parte do programa
    public class CumprimentadorFactory
    {
        //VISIBILIDADE = privada 
        //Vista e utilizada apenas pela classe CumprimentadorFactory
        private string nomeUsuário;

        //VISIBILIDADE = publica
        //Pode ser Chamada e utilizda de qualquer parte do programa
        public CumprimentadorFactory(string NomeUsuario)
        {
            nomeUsuário = NomeUsuario;
        }

        //VISIBILIDADE = publica
        //Pode ser Chamada e utilizda de qualquer parte do programa
        public Cumprimentador NewCumprimentador(string Idioma)
        {
            Cumprimentador c;

            if(Idioma == "pt")
            {
                c = new CumprimentadorPtBr(nomeUsuário);
            }
            else
            {
                c = new CumprimentadorEnUs(nomeUsuário);
            }

            return c;
        }
    }
}
