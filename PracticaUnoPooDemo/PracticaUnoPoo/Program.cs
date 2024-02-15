public class Empleado
{
    public string Nombre { get; set; }
    public string Departamento { get; set; }
    public double Salario { get; set; }

    public double DineroSucio { get; set; }

    public Empleado(string Nombre, string departamento, double salario, double dineroSucio)
    {
        this.Nombre = Nombre;
        Departamento = departamento;
        Salario = salario;
        DineroSucio = dineroSucio;
    }

    public virtual double CalcularBono()
    {
        return Salario * 0.1;
    }

    public virtual double CalcularDineroSucio()
    {
        return DineroSucio * 2.0;
    }
}

public class Gerente : Empleado
{
    public string AreaResponsabilidad { get; set; }

    public Gerente(string x, string departamento, double salario, string areaResponsabilidad, double dineroSucio)
        : base(x, departamento, salario, dineroSucio)
    {
        AreaResponsabilidad = areaResponsabilidad;
    }

    public override double CalcularBono()
    {
        return Salario * 0.15;
    }

    public override double CalcularDineroSucio()
    {
        return DineroSucio * 2.20;
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        List<Empleado> empleados = new List<Empleado>();

        empleados.Add(new Empleado("Cintia", "Ventas", 1000, 20000));
        empleados.Add(new Gerente("Raquel", "Marketing", 4000, "Campañas", 15000));

        foreach (var empleado in empleados)
        {
            Console.WriteLine($"Nombre: {empleado.Nombre}, Area de Departamento: {empleado.Departamento}, Salario Total: {empleado.Salario}, Bono: {empleado.CalcularBono()}, Dinero sucio: {empleado.CalcularDineroSucio()}");
        }
    }
}