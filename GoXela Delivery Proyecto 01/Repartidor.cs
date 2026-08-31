class Repartidor : Persona
{
    private string numeroLicencia;

    public string NumeroLicencia
    {
        get { return numeroLicencia; }
        set
        {
            if (value != "")
            {
                numeroLicencia = value;
            }
            else
            {
                Console.WriteLine("El número de licencia no puede estar vacío");
            }
        }
    }

    private string tipoLicencia;

    public string TipoLicencia
    {
        get { return tipoLicencia; }
        set
        {
            if (value != "")
            {
                tipoLicencia = value;
            }
            else
            {
                Console.WriteLine("El tipo de licencia no puede estar vacío");
            }
        }
    }

    private string estadoDisponibilidad;

    public string EstadoDisponibilidad
    {
        get { return estadoDisponibilidad; }
        set
        {
            if (value != "")
            {
                estadoDisponibilidad = value;
            }
            else
            {
                Console.WriteLine("El estado de disponibilidad no puede estar vacío");
            }
        }
    }

    private int cantidadEntregasRealizadas;

    public int CantidadEntregasRealizadas
    {
        get { return cantidadEntregasRealizadas; }
        set
        {
            if (value >= 0)
            {
                cantidadEntregasRealizadas = value;
            }
            else
            {
                Console.WriteLine("La cantidad de entregas no puede ser negativa");
            }
        }
    }

    private double calificacionPromedio;

    public double CalificacionPromedio
    {
        get { return calificacionPromedio; }
        set
        {
            if (value >= 0 && value <= 5)
            {
                calificacionPromedio = value;
            }
            else
            {
                Console.WriteLine("La calificación debe estar entre 0 y 5");
            }
        }
    }

    public Repartidor(string codigo, string nombre, string numeroTelefono, int edad, string numeroLicencia, string tipoLicencia, string estadoDisponibilidad, int cantidadEntregasRealizadas, double calificacionPromedio)
    : base(codigo, nombre, numeroTelefono, edad)
    {
        NumeroLicencia = numeroLicencia;
        TipoLicencia = tipoLicencia;
        EstadoDisponibilidad = estadoDisponibilidad;
        CantidadEntregasRealizadas = cantidadEntregasRealizadas;
        CalificacionPromedio = calificacionPromedio;
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine("======INFORMACIÓN REPARTIDOR======");
        base.MostrarInformacion();
        Console.WriteLine("Número de licencia: " + NumeroLicencia);
        Console.WriteLine("Tipo de licencia: " + TipoLicencia);
        Console.WriteLine("Estado de disponibilidad: " + EstadoDisponibilidad);
        Console.WriteLine("Cantidad de entregas realizadas: " + CantidadEntregasRealizadas);
        Console.WriteLine("Calificación promedio: " + CalificacionPromedio);
    }
}