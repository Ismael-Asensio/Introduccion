// See https://aka.ms/new-console-template for more information
Console.WriteLine("**Conversion de medidas**");

double m, p, y, pl,ct,cm;

Console.WriteLine("Digite la cantidad de tela que desea convertir: ");
ct = double.Parse(Console.ReadLine());

Console.WriteLine(" ");

m = ct * 1;
cm = ct * 100;
pl = ct * 39.3701;
y = ct * 1.09361;
p = ct * 3.28084;

Console.WriteLine("_______________________________________________________");
Console.WriteLine("Su cantidad de tela en metros es: "+m.ToString("0.000"));
Console.WriteLine("_______________________________________________________");
Console.WriteLine("Su cantidad de tela en Centimetros es: " + cm.ToString("0.000"));
Console.WriteLine("_______________________________________________________");
Console.WriteLine("Su cantidad de tela en Pulgadas es: " + pl.ToString("0.000"));
Console.WriteLine("_______________________________________________________");
Console.WriteLine("Su cantidad de tela en Yardas es: " + y.ToString("0.000"));
Console.WriteLine("_______________________________________________________");
Console.WriteLine("Su cantidad de tela en Pies es: " + p.ToString("0.000"));



