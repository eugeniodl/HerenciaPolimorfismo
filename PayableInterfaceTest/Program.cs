
using PayableInterfaceTest;

// create a List<IPayable> and initialize it with four
// objects of classes that implement interface IPayable
var payableObjects = new List<IPayable>()
{
    new Invoice("01234", "seat", 2, 375.00M),
    new Invoice("56789", "tire", 4, 79.95M),
    new SalariedEmployee("Rodrigo", "Espinoza", "111-11-1111", 800.00M),
    new SalariedEmployee("Elizabeth", "Báez", "222-22-2222", 1200.00M)
};

Console.WriteLine("Invoices and Employees processed " +
    "polymorphically:\n");

// generically process each element in payableObjects
foreach (var payable in payableObjects)
{
    // output payable and its appropiate payment amount
    Console.WriteLine($"{payable}");
    Console.WriteLine(
        $"payment due: {payable.GetPaymentAmount():C}\n");
}
