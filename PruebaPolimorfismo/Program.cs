using PruebaHerencia;

EmpleadoPorComision empleadoPorComision = new EmpleadoPorComision("Susana",
    "Figueroa", "222-22-2222", .06M, 10000.00M);

EmpleadoBaseMasComision2 empleadoBaseMasComision = new EmpleadoBaseMasComision2(
    "Roberto", "López", "333-33-3333", .04M, 5000.00M, 300.00M);

Console.WriteLine("{0} {1}:\n\n{2}\n{3}: {4:C}\n",
    "Llama a ToString de EmpleadoPorComision con referencia de clase base ",
    "a objeto de clase base", empleadoPorComision.ToString(),
    "ingresos", empleadoPorComision.Ingresos());

Console.WriteLine("{0} {1}:\n\n{2}\n{3}: {4:C}\n",
    "Llama a ToString de empleadoBaseMasComision con referencia de clase ",
    "derivada a objeto de clase derivada", empleadoBaseMasComision.ToString(),
    "ingresos", empleadoBaseMasComision.Ingresos());

EmpleadoPorComision empleadoPorComision2 = empleadoBaseMasComision;

Console.WriteLine("{0} {1}:\n\n{2}\n{3}: {4:C}\n",
    "Llama a ToString de empleadoBaseMasComision con referencia de clase ",
    "base a objeto de clase derivada", empleadoPorComision2.ToString(),
    "ingresos", empleadoPorComision2.Ingresos());
