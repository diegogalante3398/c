using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19Data
{
    /// <summary>
    /// Classe que representa um registo de report de dados sobre o Covid-19
    /// Origem dos dados: Site da OMS (WHO) - https://covid19.who.int/
    /// Date_reported,Country_code,Country,WHO_region,New_cases,Cumulative_cases,New_deaths,Cumulative_deaths
    /// </summary>
    public class CovidModel
    {
        /// <summary>
        /// Data quando foi reportado esta alteração nos dados do COVID-19
        /// </summary>
        public DateTime Date_reported;
        
        /// <summary>
        /// Código do pais do relatório
        /// </summary>
        public string Country_code;

        /// <summary>
        /// Nome do pais do relatório
        /// </summary>
        public string Country;

        /// <summary>
        /// Código do pais na OMS
        /// </summary>
        public string WHO_region;

        /// <summary>
        /// Número de novos casos
        /// </summary>
        public int New_cases;

        /// <summary>
        /// Número de casos acumulados
        /// </summary>
        public int Cumulative_cases;

        /// <summary>
        /// Número de mortes
        /// </summary>
        public int New_deaths;

        /// <summary>
        /// Número acumulado de mortes
        /// </summary>
        public int Cumulative_deaths;
    }
}
