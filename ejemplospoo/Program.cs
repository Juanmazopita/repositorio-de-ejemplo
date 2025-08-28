// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var cuenta = new CuantasBancarias();
cuenta.Depositar(1300600.22);
cuenta.Retirar(600000);

public class CuantasBancarias
{
    public double Saldo = 0;

    public void Depositar(double monto)
    {
        Saldo += monto;
        Console.WriteLine($"la cantidad de dinero en la cuenta actualmente es:{Saldo}");
    }
    
    public void Retirar(double monto)
    {
        Saldo -= monto;
        Console.WriteLine($"la cantidad de dinero en la cuenta actualmente es:{Saldo}"); 
    }
}