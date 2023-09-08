using csharp_oop_shop;

Prodotto telefono = new Prodotto("iPhone 14", "Telecono cellulare di casa Apple", 850.99f, 22);


Console.WriteLine($"Codice: #{telefono.Codice}");
Console.WriteLine($"Nome: {telefono.Nome}");
Console.WriteLine($"Descrizione: {telefono.Descrizione}");
Console.WriteLine($"Prezzo Base: {telefono.Prezzo}€");
Console.WriteLine($"IVA: {telefono.Iva}%");

Console.WriteLine();

Console.WriteLine($"Nome esteso: {telefono.VisualizzaNomeEsteso}");
Console.WriteLine($"Prezzo Base: {telefono.VisualizzaPrezzoBase}");
Console.WriteLine($"Prezzo compreso di IVA: {telefono.VisualizzaPrezzoPiuIva}");

Console.WriteLine();

telefono.Nome = "Nuovo nome";
telefono.Descrizione = "Nuova descrizione";

Console.WriteLine($"Nome modificato: {telefono.Nome}");
Console.WriteLine($"Descrizione modificata: {telefono.Descrizione}");