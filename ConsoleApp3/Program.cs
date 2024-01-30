using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* SENZA IMPUT, STATICA   */
            Persona persona1 = new Persona("Salvatore");
            Persona persona2 = new Persona("Salvatore", "D'Amico");
            Persona persona3 = new Persona("Salvatore", "D'Amico", 27);

            Console.WriteLine("\t" + "\t" + " SECONDA CONSOLE " + "\t" + "\t");
            Console.WriteLine("Creato con costruttori");
            Console.WriteLine("\n");

            Console.WriteLine("Nome, preso con GetNome");
            Console.WriteLine("\t" + "\t" + persona1.GetNome() + "\t" + "\t");
            Console.WriteLine("\n");

            Console.WriteLine("Nome e " + "Cognome, presi con GetNome e GetCognome");
            Console.WriteLine("\t" + "\t" + "\t" + persona2.GetNome() + "\t" + persona2.GetCognome() + "\t" + "\t");
            Console.WriteLine("\n");

            Console.WriteLine("Dettagli completi presi con GetDetails");
            Console.WriteLine("\t" + persona3.GetDetails() + " anni" + "\t" + "\t");
            Console.WriteLine("\n");


            /////////////////////////////////////////////////////////////////////////////////////
            // Richiamando i metodi

            Console.WriteLine("\n");
            Persona metodoNome = new Persona("Solo nome");
            Persona metodoCognome = new Persona("Nome e ", "Cognome");
            Persona metodoEta = new Persona(27);
            Persona metodoDetails = new Persona("Nome", "Cognome", 27);

            Console.WriteLine(metodoNome.GetNome());
            Console.WriteLine(metodoCognome.GetCognome());
            Console.WriteLine(metodoEta.GetEta());
            Console.WriteLine(metodoDetails.GetDetails());
            Console.WriteLine("\n");


            //////////////////////////////////////////////////////////////////////////
            //CON IMPUT
            Console.WriteLine("Con richiesta di imput per proseguire");
            Console.WriteLine("\n");

            Console.WriteLine("Inserisci il tuo nome");
            string nome = Console.ReadLine();

            Console.WriteLine("\n");

            Console.WriteLine("Inserisci il tuo cognome");
            string cognome = Console.ReadLine();

            Console.WriteLine("\n");

            Console.WriteLine("Inserisci la tua età");
            int eta = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("\n");

            // inizializzo
            Persona user = new Persona(nome, cognome, eta);

            // Mostro la classe persona inizializzata sopra
            Console.WriteLine(user.GetDetails());
            // Verifica Eta con imput
            user.VerificaEta();


            Console.ReadLine();

        }
    }
}
