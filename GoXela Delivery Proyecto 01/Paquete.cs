class Paquete
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

    private string descripcion;

    public string Descripcion
    {
        get { return descripcion; }
        set
        {
            if (value != "")
            {
                descripcion = value;
            }
            else
            {
                Console.WriteLine("La descripción no puede estar vacía");
            }
        }
    }

    private double peso;

    public double Peso
    {
        get { return peso; }
        set
        {
            if (value > 0)
            {
                peso = value;
            }
            else
            {
                Console.WriteLine("El peso debe ser mayor a 0");
            }
        }
    }

    private string valorDeclarado;

    public string ValorDeclarado
    {
        get { return valorDeclarado; }
        set
        {
            if (value != "")
            {
                valorDeclarado = value;
            }
            else
            {
                Console.WriteLine("El valor declarado no puede estar vacío");
            }
        }
    }

    private string direccionOrigen;

    public string DireccionOrigen
    {
        get { return direccionOrigen; }
        set
        {
            if (value != "")
            {
                direccionOrigen = value;
            }
            else
            {
                Console.WriteLine("La dirección de origen no puede estar vacía");
            }
        }
    }

    private string direccionDestino;

    public string DireccionDestino
    {
        get { return direccionDestino; }
        set
        {
            if (value != "")
            {
                direccionDestino = value;
            }
            else
            {
                Console.WriteLine("La dirección de destino no puede estar vacía");
            }
        }
    }

    private string estado;

    public string Estado
    {
        get { return estado; }
        set
        {
            if (value != "")
            {
                estado = value;
            }
            else
            {
                Console.WriteLine("El estado no puede estar vacío");
            }
        }
    }

    private string tipoPaquete;

    public string TipoPaquete
    {
        get { return tipoPaquete; }
        set
        {
            if (value != "")
            {
                tipoPaquete = value;
            }
            else
            {
                Console.WriteLine("El tipo de paquete no puede estar vacío");
            }
        }
    }

    public Paquete(string codigo, string descripcion, double peso, string valorDeclarado, string direccionOrigen,
        string direccionDestino, string estado, string tipoPaquete)
    {
        Codigo = codigo;
        Descripcion = descripcion;
        Peso = peso;
        ValorDeclarado = valorDeclarado;
        DireccionOrigen = direccionOrigen;
        DireccionDestino = direccionDestino;
        Estado = estado;
        TipoPaquete = tipoPaquete;
    }

    public virtual void MostrarInformacion()
    {
        Console.WriteLine("======= INFORMACIÓN DEL PAQUETE =======");
        Console.WriteLine("Código: " + Codigo);
        Console.WriteLine("Descripción: " + Descripcion);
        Console.WriteLine("Peso: " + Peso);
        Console.WriteLine("Valor declarado: " + ValorDeclarado);
        Console.WriteLine("Dirección de origen: " + DireccionOrigen);
        Console.WriteLine("Dirección de destino: " + DireccionDestino);
        Console.WriteLine("Estado: " + Estado);
        Console.WriteLine("Tipo de paquete: " + TipoPaquete);
    }

    public virtual void CalcularTarifa()
    {
        Console.WriteLine("Calculando tarifa...");
    }

    public virtual void PuedeSerTransportado()
    {
        Console.WriteLine("Verificando transporte...");
    }
}