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
        private int codice;

        public int Codice { get; }

        private string nome;

        public string Nome { get; set; }

        private string descrizione;
        public string Descrizione { get; set; }

        private double prezzo;

        public double Prezzo { get; set; }

        private int iva;

        public int Iva { get; set; }

        // COSTRUTTORI
        public Prodotto(string nome, string descrizione, double prezzo, int iva)
        {
            this.codice = GeneraCodiceRandom();
            this.nome = nome;   
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.iva = iva;
        }

        // METODI
        // funzione che genera un numero da 1000 a 9999
        private int GeneraCodiceRandom()
        {
            Random randomNumber = new Random();
            return randomNumber.Next(1000, 10000);
        }
        // funzione che visualizza il prezzo base
        public string VisualizzaPrezzoBase()
        {
            return this.Prezzo + " €";
        }
        // funzione che visualizza il prezzo base aggiunto di iva
        public string VisualizzaPrezzoPiuIva()
        {
            double calcoloIva = (this.Prezzo * this.Iva) / 100;
            return (this.Prezzo + calcoloIva) + " €";
        }
        // funzione che visualizza il nome esteso
        public string VisualizzaNomeEsteso()
        {
            return this.Codice + " " + this.Nome;
        }
    }
}
