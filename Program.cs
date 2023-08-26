double notaum, notadois, notatres, notaquatro, media;

Console.WriteLine("Média 4 Notas");
Console.WriteLine("Digite sua primeira nota");
notaum = Convert.ToDouble(Console.ReadLine()!);

Console.WriteLine("Digite sua segunda nota");
notadois = Convert.ToDouble(Console.ReadLine()!);

Console.WriteLine("Digite sua terceira nota");
notatres = Convert.ToDouble(Console.ReadLine()!);

Console.WriteLine("Digite sua quarta nota");
notaquatro = Convert.ToDouble(Console.ReadLine()!);

if(notaum<0 | notaum>10 | notadois<0 | notadois>10 | notatres<0 | notatres>10 | notaquatro<0 | notaquatro>10){
    Console.WriteLine("Digite apenas numeros de 0 a 10");
}
else 
{
    media = (notaum + notadois + notatres + notaquatro) / 4;
 if (media < 5){
    Console.WriteLine($"Sua media é = {media:N1}    Resultado: Reprovado");
 }
 else if( media > 6){
    Console.WriteLine($"Sua media é = {media:N1}    Resultado: Aprovado");
 }
 else{
    Console.WriteLine($"Sua media é = {media:N1}    Resultado: Recuperação");
 }
   }