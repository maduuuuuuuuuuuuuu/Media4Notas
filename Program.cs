Console.WriteLine("Veja sua média de 4 notas!");

Console.WriteLine("Digite sua primeira nota:");

double notaum;

notaum = Convert.ToDouble(Console.ReadLine()!);

Console.WriteLine("Digite sua segunda nota:");

double notadois;

notadois = Convert.ToDouble(Console.ReadLine()!);

Console.WriteLine("Digite sua terceira nota:");

double notatres;

notatres = Convert.ToDouble(Console.ReadLine())!;

Console.WriteLine("Digite sua quarta e última nota:");

double notaquatro;

notaquatro = Convert.ToDouble(Console.ReadLine()!);

double media;

 

if (notaum < 0 || notaum > 10

 || notadois < 0 || notadois > 10

 || notatres < 0 || notatres > 10

 || notaquatro < 0 || notaquatro > 10){

    Console.WriteLine("Digite somente numeros de 0 a 10");
 }
 else {media = (notaum + notadois + notatres + notaquatro) / 4;
 
if(media < 5.00){

    Console.Write("Resultado: Reprovado.");

Console.Write($"Sua média é de {media}! ");

if(media > 6.00){

    Console.Write("Resultado: Aprovado.");
}
else{

    Console.Write("Resultado: Recuperação.");

}
}
 }