using System;
using System.Collections.Generic;
using System.IO;

namespace Covid19Data
{
    public class CovidProvider
    {
        public List<CovidModel> Lista = new List<CovidModel>();

        private readonly string file = "WHO-COVID-19-global-data.csv";

        private bool primeiraLinha = true;

        public void Carrega()
        {
            string[] linhas = File.ReadAllLines(file);

            foreach (var linha in linhas)
            {
                string[] campos = linha.Split(',');

                if (primeiraLinha)
                {
                    primeiraLinha = false;
                }
                else
                {
                    CovidModel model = new CovidModel();

                    model.Date_reported = DateTime.ParseExact(campos[0], "yyyy-MM-ddThh:mm:ssZ", null);
                    model.Country_code = campos[1];
                    model.Country = campos[2];
                    model.WHO_region = campos[3];
                    model.New_cases = Convert.ToInt32(campos[4]);
                    model.Cumulative_cases = Convert.ToInt32(campos[5]);
                    model.New_deaths = Convert.ToInt32(campos[6]);
                    model.Cumulative_deaths = Convert.ToInt32(campos[7]);

                    Lista.Add(model);
                }

            }
        }
    }
}
