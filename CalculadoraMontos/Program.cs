// See https://aka.ms/new-console-template for more information
Console.WriteLine("**Calculadora d Montos**");
Console.WriteLine(" ");

int cantidad;
double precio, monto ;

Console.WriteLine("ingrese la cantidad de producto seleccionada: ");
cantidad = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el precio del producto C$:");
precio = double.Parse(Console.ReadLine());

monto = cantidad * precio;

Console.WriteLine("_______________________________________");
Console.WriteLine("su Monto a cancelar es de C$: " + monto.ToString("0.00"));

