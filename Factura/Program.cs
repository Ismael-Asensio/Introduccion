// See https://aka.ms/new-console-template for more information
Console.WriteLine("**Capital**");
double ap1, ap2, ap3, ps1,ps2,ps3, capital;

Console.WriteLine("Digite la aportacion del socio 1: ");
ap1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite la aportacion del socio 2: ");
ap2 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite la aportacion del socio 3: ");
ap3 = double.Parse(Console.ReadLine());

capital = ap1 + ap2 + ap3; 

ps1= (ap1 * 100) / capital; 
ps2= (ap2 * 100) / capital; 
ps3= (ap3 * 100) / capital;

Console.WriteLine("___________________________________________________");
Console.WriteLine("El capital de la Empresa es de: " + capital.ToString());
Console.WriteLine("___________________________________________________");
Console.WriteLine("El porcentaje de aportacion del socio 1 es: " + ps1.ToString() + "%");
Console.WriteLine("___________________________________________________");
Console.WriteLine("El porcentaje de aportacion del socio 2 es: " + ps2.ToString() + "%");
Console.WriteLine("___________________________________________________");
Console.WriteLine("El porcentaje de aportacion del socio 2 es: " + ps3.ToString() + "%");

