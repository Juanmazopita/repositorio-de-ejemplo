// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var cuenta = new CuantasBancarias();
cuenta.Depositar(1300600.22);
cuenta.Retirar(600000);
Console.WriteLine("-----------------------------------------------------------------------------------------------------");
var Estudiante = new Estudiantes();
Estudiante.Materia.Add(new Materias() { ID = 1, Nombre = "calculo diferencial" });
Estudiante.Cedula = "12345";
Estudiante.Edad = 25;
Estudiante.Sexo = "por favor";
Estudiante.Nombre = "pedro perez pereira";
Console.WriteLine($"el estudiante {Estudiante.Nombre} con cedula: {Estudiante.Cedula} de edad {Estudiante.Edad} está matriculado en la materia {Estudiante.Materia[0].Nombre}");


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
public class Estudiantes
{
    public string Nombre = "";
    public string? Cedula = "";
    public int Edad = 0;
    public string? Sexo = "";
    public List<Materias> Materia = new List<Materias>();
}

public class Materias
{
    public int ID = 0;
    public string? Nombre = "";
}