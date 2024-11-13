using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shuai_C
{
    internal class cassaforte
    {
        private string matric;
        private string produttore;
        private string modello;
        private bool aperta = false;
        private string codiceSblocco;  
        private string codiceUtente; 
        private bool statoBlocco; 
        private int tentativiFalliti; 
        private string dateTime;  

        public cassaforte(string matric, string produttore, string modello, string codiceUtente, string codiceSblocco, string dateTime)
        {
            this.matric = matric;
            this.produttore = produttore;
            this.modello = modello;
            this.codiceUtente = codiceUtente;
            this.codiceSblocco = codiceSblocco;
            this.dateTime = dateTime;
        }

        public string Matric
        {
            get { return matric; }
        }
        public string Produttore { get { return produttore; } }
        public string Modello { get { return modello; } }

        public string CodiceSblocco
        {
            get { return codiceSblocco; }
            set { codiceSblocco = value; }
        }
        public bool Aperta
        {
            get { return aperta; }
        }

        public string CodiceUtente
        {
            get { return codiceUtente; }
            set { codiceUtente = value; }
        }

        public string DateTime
        {
            get { return dateTime; }
            set { dateTime = value; }
        }

        public void ImpostaCodiceUtente(string cdUtente)
        {
            if (cdUtente.Length == 5)
            {
                codiceUtente = cdUtente;
            }
            else
            {
                
                return;
            }

        }

        public void Apri(string cdUtente)
        {
            /*
            if (statoBlocco==true)
                return statoBlocco = false;
            */

            if (cdUtente == codiceUtente)
            {
                tentativiFalliti = 0;
                aperta = true;
            }
            else
            {
                tentativiFalliti++;
                if (tentativiFalliti >= 5)
                    statoBlocco = true;
            }
        }


        public void Chiudi()
        {
            aperta = false;
        }

        public void Sblocca(string cdUtente)
        {
            if (codiceSblocco == cdUtente)
            {
                statoBlocco = false;
                tentativiFalliti = 0;
                aperta = true;
                //Console.WriteLine("hai sbloccato la cassa");
            
            }

        }

        public void ImpostaDataProgrammata(string data)
        {
            dateTime = data;
        }

        public void AperturaProgrammata(string cdUtente, string data)
        {

            if (statoBlocco == true)
            {
                return;
            }
            else
            {


                if (codiceUtente == CodiceUtente && dateTime == data)
                {
                    tentativiFalliti = 0;
                    aperta = true;
                }
                else
                {
                    tentativiFalliti++;
                    if (tentativiFalliti >= 5)
                        statoBlocco = true;
                 
                }
            }

        }
    }
}
