using System;
using System.Collections.Generic;
using System.Linq;

namespace Covid19Data
{
    public class CovidPais
    {
        public void ListraFiltrada(string cod_pais)
        {
            CovidProvider p = new CovidProvider();
            p.Carrega();

            List<CovidModel> listafiltrada = p.Lista.Where(covid => covid.Country_code == cod_pais).ToList();

            foreach (var covid in listafiltrada)
            {
                Console.WriteLine($"Data -> {covid.Date_reported} Codigo -> {covid.Country_code} País -> {covid.Country} Região -> {covid.WHO_region} Casos -> {covid.Cumulative_cases} Mortes -> {covid.Cumulative_deaths}");
            }
        }
        public void PrimeiroDaLista(String cod_pais)
        {
            CovidProvider cv = new CovidProvider();
            cv.Carrega();

            CovidModel primeiroDaLista = cv.Lista.FirstOrDefault(covid => covid.Country_code == cod_pais);
            CovidModel primeiraMorte = cv.Lista.FirstOrDefault(covid => covid.Cumulative_deaths == 1 && covid.Country_code == cod_pais);
            CovidModel dataFinal = cv.Lista.LastOrDefault(covid => covid.Country_code == cod_pais);

            Console.WriteLine($"Data-> {primeiroDaLista.Date_reported.Date} País-> {primeiroDaLista.Country} Casos-> {primeiroDaLista.Cumulative_cases}");
            Console.WriteLine($"Data-> {primeiraMorte.Date_reported.Date} País-> {primeiraMorte.Country} Mortes-> {primeiraMorte.Cumulative_deaths}");
            Console.WriteLine($"Data-> {dataFinal.Date_reported} Codigo-> {dataFinal.Country_code} País-> {dataFinal.Country} Região-> {dataFinal.WHO_region} Casos-> {dataFinal.Cumulative_cases} Mortes-> {dataFinal.Cumulative_deaths}");
        }

        public double VelocidadeContaminacao(string cod_pais)
        {
            CovidProvider cp = new CovidProvider();
            cp.Carrega();

            //listra filtrada por país
            List<CovidModel> vc = cp.Lista.Where(covid => covid.Country_code == cod_pais).ToList();
            
            //lista que armazena os casos
            List<int> ls = new List<int>();

            //percorre a lista filtrada
            foreach (var lista in vc)
            {
                //adiciona cada caso novo a instancia lista de inteiros
                ls.Add(lista.New_cases);
            }
            
            double sub_casos = 0;
            int qtd_repeticao = ls.Count() - 1;

            //subtrai a quantidade de novo caso na posição do contador +1 por caso na posicao atual do contador
            //armazena o valor da subtração na variavel fora do For
            for (int cont = 0; cont < ls.Count(); cont++)
            {
                if (qtd_repeticao <= cont)
                    continue;
                
                sub_casos += ls.ToArray()[cont + 1] - ls.ToArray()[cont];
            }

            //divide o total de casos pela quantidade de repetições
            return Math.Round(sub_casos / qtd_repeticao, 1);
        }
        public double VelocidadeLetalidade(string cod_pais)
        {
            CovidProvider cp = new CovidProvider();
            cp.Carrega();

            List<CovidModel> vc = cp.Lista.Where(covid => covid.Country_code == cod_pais).ToList();
            List<int> ls = new List<int>();

            foreach (var lista in vc)
            {
                ls.Add(lista.New_deaths);
            }

            double sub_casos = 0;
            int qtd_repeticao = ls.Count() - 1;

            for (int cont = 0; cont < ls.Count(); cont++)
            {
                if (qtd_repeticao <= cont)
                    continue;

                sub_casos += ls.ToArray()[cont + 1] - ls.ToArray()[cont];
            }

            return Math.Round(sub_casos / qtd_repeticao, 1);

        }
    }
}