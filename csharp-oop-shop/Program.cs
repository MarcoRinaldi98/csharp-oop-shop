using csharp_oop_shop;

Console.OutputEncoding = System.Text.Encoding.UTF8; // per far leggere alla console simboli speciali come il simbolo dell'euro

Prodotto iPhone = new Prodotto("iPhone 14", "Telefono cellulare di casa Apple", 850.99d, 22);


Console.WriteLine($"Codice: #{iPhone.Codice}");
Console.WriteLine($"Nome: {iPhone.Nome}");
Console.WriteLine($"Descrizione: {iPhone.Descrizione}");
Console.WriteLine($"Prezzo Base: {iPhone.Prezzo.ToString("0.00")} €");
Console.WriteLine($"IVA: {iPhone.Iva}%");

Console.WriteLine();

Console.WriteLine($"Nome esteso: {iPhone.VisualizzaNomeEsteso()}");
Console.WriteLine($"Prezzo Base: {iPhone.VisualizzaPrezzoBase()}");
Console.WriteLine($"Prezzo compreso di IVA: {iPhone.VisualizzaPrezzoPiuIva()}");

Console.WriteLine();

iPhone.Nome = "iPhone 15";
iPhone.Descrizione = "Nuovo modello di cellulare della Apple";

Console.WriteLine($"Nome modificato: {iPhone.Nome}");
Console.WriteLine($"Descrizione modificata: {iPhone.Descrizione}");

Console.WriteLine(Environment.NewLine);

// BONUS
//Usando un array fisso di 5 prodotti, dichiarate un elenco dei prodotti di un negozio e inseriteci al suo interno qualche prodotto che vi aspettate di trovare nel negozio. Stampate poi l’elenco dei vostri prodotti che avete previsto nel negozio.
Prodotto iPad = new Prodotto("iPad", "Tablet di casa Apple", 400.00d, 22);
Prodotto macBook = new Prodotto("MacBook", "Computer portatile della Apple", 1100.00d, 22);
Prodotto iPod = new Prodotto("iPod", "Lettore di musica della Apple", 200.00d, 22);
Prodotto watch = new Prodotto("Apple Watch", "Orologio touch screen leggero", 300.00d, 22);

// Creazione di un array di prodotti
Prodotto[] apple = { iPhone, iPad, macBook, iPod, watch };

// Stampa dell'elenco dei prodotti nel negozio
Console.WriteLine("Il negozio Apple ha a disposizione questi prodotti:");
for (int i = 0; i < apple.Length; i++)
{
    Console.WriteLine();
    Console.WriteLine($"- Prodotto {i + 1}:");
    apple[i].StampaProdotto();
}