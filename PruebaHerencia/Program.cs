
using PruebaHerencia;

EmpleadoPorComision empleadoPorComision = new("Susana",
    "López", "222-22-2222", .06M, 10000.00M);

Console.WriteLine("{0} {1}: \n\n{2}\n{3}: {4:C}\n",
    "Llama a ToString de EmpleadoPorComision con referencia de " +
    "clase base", "a objeto de clase base", 
    empleadoPorComision.ToString(),
    "ingresos", empleadoPorComision.Ingresos());

EmpleadoBaseMasComision2 empleadoBaseMasComision = new("Roberto",
    "Pérez", "333-33-3333", .04M, 5000.00M, 300.0M);

Console.WriteLine("{0} {1}: \n\n{2}\n{3}: {4:C}\n",
    "Llama a ToString de EmpleadoBaseMasComision con referencia de " +
    "clase derivada", "a objeto de clase derivada",
    empleadoBaseMasComision.ToString(),
    "ingresos", empleadoBaseMasComision.Ingresos());

EmpleadoPorComision empleadoPorComision2 = empleadoBaseMasComision;

Console.WriteLine("{0} {1}: \n\n{2}\n{3}: {4:C}\n",
    "Llama a ToString de EmpleadoBaseMasComision con referencia de " +
    "clase base", "a objeto de clase derivada",
    empleadoPorComision2.ToString(),
    "ingresos", empleadoPorComision2.Ingresos());

empleadoBaseMasComision.VentasBrutas = 4000.00M;
empleadoBaseMasComision.TarifaComision = .1M;
empleadoBaseMasComision.SalarioBase = 100000.00M;

Console.WriteLine("\n{0}:\n\n{1}",
    "Se actualizó la información del empleadoBaseMasComision por" +
    "ToString", empleadoBaseMasComision);
Console.WriteLine("ingresos: {0:C}", empleadoBaseMasComision.Ingresos());
