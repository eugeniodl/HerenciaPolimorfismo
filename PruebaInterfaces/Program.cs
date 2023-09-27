using PruebaInterfaces;

int opcion = 0;
double valor1 = 0;
double valor2 = 0;

IOperacion operacion = new Suma();

while(opcion != 5)
{
    Console.WriteLine("1- Suma\n" +
        "2- Resta\n" +
        "3- Multiplicación\n" +
        "4- División\n" +
        "5- Salir");
    Console.WriteLine("Digite la opción que desee");
    opcion = Convert.ToInt32(Console.ReadLine());

    Console.Write("Digite el primer valor ");
    valor1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Digite el segundo valor ");
    valor2 = Convert.ToDouble(Console.ReadLine());

    // Polimorfismo
    if(opcion == 1)
        operacion = new Suma();
    if (opcion == 2)
        operacion = new Resta();
    if (opcion == 3)
        operacion = new Multiplicacion();
    if (opcion == 4)
        operacion = new Division();

    operacion.Calcular(valor1, valor2);
    operacion.Mostrar();
}