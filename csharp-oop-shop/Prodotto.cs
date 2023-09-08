using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    internal class Prodotto
    {
        // ATTRIBUTI con eventuali GETTER e SETTER

        public string Codice { get; }

        public string Nome { get; set; }
        public string Descrizione { get; set; }

        public double Prezzo { get; set; }

        public int Iva { get; set; }

        // COSTRUTTORI
        public Prodotto(string nome, string descrizione, double prezzo, int iva)
        {
            int codiceGenerato = GeneraCodiceRandom();
            this.Codice = codiceGenerato.ToString("D8"); //genero un pad left di 0 per arrivare a 8 caratteri
            this.Nome = nome;   
            this.Descrizione = descrizione;
            this.Prezzo = prezzo;
            this.Iva = iva;
        }

        // METODI
        // funzione che genera un numero da 100 a 99999999
        private int GeneraCodiceRandom()
        {
            Random randomNumber = new Random();
            return randomNumber.Next(1, 100000000);
        }
        // funzione che visualizza il prezzo base
        public string VisualizzaPrezzoBase()
        {
            return this.Prezzo.ToString("0.00") + " €";
        }
        // funzione che visualizza il prezzo base aggiunto di iva
        public string VisualizzaPrezzoPiuIva()
        {
            double calcoloIva = (this.Prezzo * this.Iva) / 100;
            return (this.Prezzo + calcoloIva).ToString("0.00") + " €";
        }
        // funzione che visualizza il nome esteso
        public string VisualizzaNomeEsteso()
        {
            return "#" + this.Codice + " " + this.Nome;
        }

        // funzione che stampoa tutti i dettagli di un Prodotto
        public void StampaProdotto()
        {
            Console.WriteLine($"Nome: {this.Nome}");
            Console.WriteLine($"Codice: #{this.Codice}");
            Console.WriteLine($"Prezzo: {this.VisualizzaPrezzoPiuIva()}");
            Console.WriteLine($"Descrizione: {this.Descrizione};");
        }
    }
}
