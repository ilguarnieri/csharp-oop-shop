// Nel progetto csharp-oop-shop, creare la classe Prodotto che gestisce i prodotti dello shop.
// Un prodotto è caratterizzato da:
// codice(numero intero)
// nome
// descrizione
// prezzo
// iva Usate
// opportunamente i livelli di accesso (public, private), i costruttori,
// i metodi getter e setter ed eventuali altri metodi di “utilità” per fare in modo che:
// alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random
// Il codice prodotto sia accessibile solo in lettura
// Gli altri attributi siano accessibili sia in lettura che in scrittura
// Il prodotto esponga sia un metodo per avere il prezzo base
// che uno per avere il prezzo comprensivo di iva
// Il prodotto esponga un metodo per avere il nome esteso,
// ottenuto concatenando codice + nome
// Nel vostro programma principale, testate tutte le funzionalità della classe Prodotto.

// BONUS: create un metodo che restituisca il codice con un pad left di 0 per arrivare a
// 8 caratteri (ad esempio codice 91 diventa 00000091, mentre codice 123445567 resta come è)

using csharp_oop_shop;

Prodotto prodotto1 = new Prodotto();
prodotto1.NameProduct = "RayBan";
prodotto1.DescriptionProduct = "Occhiali da sole tartarugati con lenti scure";
prodotto1.PriceProduct = float.Parse("105,99");
prodotto1.IvaProduct = int.Parse("22");
prodotto1.PrintProduct();


Prodotto prodotto2 = new Prodotto();
prodotto2.NameProduct = "Gucci";
prodotto2.DescriptionProduct = "Occhiali da sole con Swarovski";
prodotto2.PriceProduct = float.Parse("250,99");
prodotto2.IvaProduct = int.Parse("22");
prodotto2.PrintProduct();


Prodotto prodotto3 = new Prodotto();
prodotto3.NameProduct = "Versace";
prodotto3.DescriptionProduct = "Occhiali da sole con aste in oro";
prodotto3.PriceProduct = float.Parse("368,99");
prodotto3.IvaProduct = int.Parse("22");
prodotto3.PrintProduct();