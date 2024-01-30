using System;

namespace ConsoleApp3
{
    internal class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Eta { get; set; }

        public Persona(string nome)
        {
            Nome = nome;
        }

        public Persona(int eta)
        {
            Eta = eta;
        }
        public Persona(string nome, string cognome)
        {
            Nome = nome;
            Cognome = cognome;
        }
        public Persona(string nome, string cognome, int eta)
        {
            Nome = nome;
            Cognome = cognome;
            Eta = eta;
        }

        public string GetNome()
        {
            return Nome;
        }

        public string GetCognome()
        {
            return Cognome;
        }

        public int GetEta()
        {
            return Eta;
        }

        public string GetDetails()
        {
            return "Il nome é " + GetNome() + ", il suo cognome é " + GetCognome() + " e la sua etá é " + GetEta();
        }

        public void VerificaEta()
        {
            if (Eta >= 18)
            {
                Console.WriteLine("Sei maggiorenne puoi proseguire oltre, Utente Verificato!");
                Console.WriteLine("Premi un tasto per continuare");
            }
            else if (Eta == 17)
            {
                Console.WriteLine("Mi dispiace, non puoi proseguire oltre torna tra un anno per sapere cosa nascondiamo");
                Console.WriteLine("Ciao a presto");
            }
            else
            {
                Console.WriteLine("Mi dispiace, non puoi proseguire oltre torna tra " + (18 - Eta) + " un anni per sapere cosa nascondiamo");
                Console.WriteLine("Ciao ci rivedremo quando crescerai!");
            }
        }

    }
}
