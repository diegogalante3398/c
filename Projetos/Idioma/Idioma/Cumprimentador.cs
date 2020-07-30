using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idioma
{
    //VISIBILIDADE = publica
    //Pode ser Chamada e utilizda de qualquer parte do programa
    public class Cumprimentador
    {
        //VISIBILIDADE = protegida 
        //Vista e utilizada somente pelas classes e suas subclasses CumprimentadorPtBr, CumprimentadorEnUs
        protected string Ola = "";

        //VISIBILIDADE = privada 
        //Vista e utilizada apenas pela classe Cumprimentador
        private string nomeUsuario = "";

        //VISIBILIDADE = publica 
        //Pode ser Chamada e utilizda de qualquer parte do programa
        public Cumprimentador(string NomeUsuario)
        {
            nomeUsuario = NomeUsuario;
        }

        //VISIBILIDADE = publica
        //Pode ser Chamada e utilizda de qualquer parte do programa
        public string Dizer()
        {
            return nomeUsuario + ", " + Ola;
        }
    }
    
}
