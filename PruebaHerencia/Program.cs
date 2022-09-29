using PruebaHerencia;

EmpleadoBaseMasComision2 empleado = new EmpleadoBaseMasComision2("Susana",
    "Jiménez", "222-22-2222", .06M, 10000.00M, 300.00M);

Console.WriteLine("Información del empleado obtenida por las propiedades y " +
    "los métodos:\n");
Console.WriteLine("{0} {1}", "El primer nombre es", empleado.PrimerNombre);
Console.WriteLine("{0} {1}", "El apellido es", empleado.ApellidoPaterno);
Console.WriteLine("{0} {1}", "El número de seguro social es", empleado.NumeroSeguroSocial);
Console.WriteLine("{0} {1:C}", "Las ventas brutas son", empleado.VentasBrutas);
Console.WriteLine("{0} {1:F2}", "La tarifa de comisión es", empleado.TarifaComision);
Console.WriteLine("{0} {1:C}", "El salario base es", empleado.SalarioBase);
Console.WriteLine("{0} {1:C}", "Los ingresos son", empleado.Ingresos());

empleado.VentasBrutas = 5000.00M;
empleado.TarifaComision = .1M;
empleado.SalarioBase = 1000.00M;

Console.WriteLine("\n{0}:\n\n{1}",
    "Se actualizó la información del empleado por ToString", empleado);
Console.WriteLine("imgresos: {0:C}", empleado.Ingresos());
