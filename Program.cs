string[] cibiPreferiti = { "Pizza", "Hamburger", "Pasta", "Patatine", "Pollo", "Cheesecake", "Crepes", "Latte",};
string[] cibiPreferitiClassifica = { "Pizza", "Hamburger", "Patatine", "Pollo", "Cheesecake", "latte", "Crepes", "Pasta"};


Console.WriteLine("La lunghezza dell'array è: " + cibiPreferitiClassifica.Length);


var contatore = 1;
for (int i = 0; i < cibiPreferitiClassifica.Length; i++)
{
    Console.WriteLine("Al " + contatore + " Posto " + cibiPreferitiClassifica[i]);
    contatore++;
}

Console.WriteLine("Al primo posto c'è: " + cibiPreferitiClassifica[0]);
Console.WriteLine("All'ultimo posto c'è: " + cibiPreferitiClassifica[7]);


var lunghezzaArray = cibiPreferitiClassifica.Length;
var modulo = lunghezzaArray % 2;
if (modulo == 0)
{
    var primoElemento = lunghezzaArray / 2;
    var secondoElemento = primoElemento - 1;
    Console.WriteLine("A metà classifica troviamo " + cibiPreferitiClassifica[secondoElemento] + " e " + cibiPreferitiClassifica[primoElemento]);
    

}else if (modulo == 1)
{
    lunghezzaArray /= 2;
    Console.WriteLine("A metà classifica troviamo " + cibiPreferitiClassifica[lunghezzaArray]);
}