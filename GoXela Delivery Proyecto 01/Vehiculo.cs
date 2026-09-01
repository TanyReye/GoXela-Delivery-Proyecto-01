class Vehiculo
{
    private string codigo;

    public string Codigo
    {
        get { return codigo; }
        set
        {
            if (value != "")
            {
                codigo = value;
            }
            else
            {
                Console.WriteLine("El código no puede estar vacío");
            }
        }
    }

    private string tipo;

    public string Tipo
    {
        get { return tipo; }
        set
        {
            if (value != "")
            {
                tipo = value;
            }
            else
            {
                Console.WriteLine("El tipo de vehículo no puede estar vacío");
            }
        }
    }

    private string marca;

    public string Marca
    {
        get { return marca; }
        set
        {
            if (value != "")
            {
                marca = value;
            }
            else
            {
                Console.WriteLine("La marca no puede estar vacía");
            }
        }
    }

    private string modelo;

    public string Modelo
    {
        get { return modelo; }
        set
        {
            if (value != "")
            {
                modelo = value;
            }
            else
            {
                Console.WriteLine("El modelo no puede estar vacío");
            }
        }
    }

    private double capacidad;

    public double Capacidad
    {
        get { return capacidad; }
        set
        {
            if (value > 0)
            {
                capacidad = value;
            }
            else
            {
                Console.WriteLine("La capacidad debe ser mayor a 0");
            }
        }
    }

    private string estado;

    public string Estado
    {
        get { return estado; }
        set
        {
            if (value == "Disponible" || value == "No disponible")
            {
                estado = value;
            }
            else
            {
                Console.WriteLine("El estado debe ser Disponible o No disponible");
            }
        }
    }

    public Vehiculo(string codigo, string tipo, string marca, string modelo, double capacidad, string estado)
    {
        Codigo = codigo;
        Tipo = tipo;
        Marca = marca;
        Modelo = modelo;
        Capacidad = capacidad;
        Estado = estado;
    }

    public virtual void MostrarInformacion()
    {
        Console.WriteLine("======= INFORMACIÓN DEL VEHÍCULO =======");
        Console.WriteLine("Código: " + Codigo);
        Console.WriteLine("Tipo: " + Tipo);
        Console.WriteLine("Marca: " + Marca);
        Console.WriteLine("Modelo: " + Modelo);
        Console.WriteLine("Capacidad: " + Capacidad + " kg");
        Console.WriteLine("Estado: " + Estado);
    }

    public virtual void CalcularCapacidad()
    {
        Console.WriteLine("La capacidad del vehículo es de " + Capacidad + " kg");
    }
}