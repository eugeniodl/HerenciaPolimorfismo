using PruebaInterfazPorPagar;

IPorPagar[] objetosPorPagar = new IPorPagar[4];

objetosPorPagar[0] = new Factura("01234", "asiento", 2, 375.00M);
objetosPorPagar[1] = new Factura("56789", "llanta", 4, 79.95M);
objetosPorPagar[2] = new EmpleadoAsalariado("Juan", "Soto",
    "111-11-1111", 800.00M);
objetosPorPagar[3] = new EmpleadoAsalariado("Elizabeth", "Báez",
    "888-88-8888", 1200.00M);

Console.WriteLine(
    "Facturas y Empleados procesados en forma polimórfica:\n");

foreach(IPorPagar porPagarActual in objetosPorPagar)
{
    Console.WriteLine("{0} \n{1}: {2:C}\n", porPagarActual,
        "pago vencido", porPagarActual.ObtenerMontoPago());
}