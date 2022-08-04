// See https://aka.ms/new-console-template for more information
Console.WriteLine("***Promedio Notas***");
Console.WriteLine(" ");

String alumno;
int nota1, nota2, nota3;
double promedio;

Console.WriteLine("Digite el nombre del alumno: ");
alumno = Console.ReadLine();

Console.WriteLine("Ingrese la nota 1: ");
nota1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la nota 2: ");
nota2 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la nota 3: ");
nota3 = int.Parse(Console.ReadLine());

promedio = (nota1 + nota2 + nota3) / 3;
Console.WriteLine("_______________________________________");
Console.WriteLine("Su promedio es de: "+ promedio.ToString());

