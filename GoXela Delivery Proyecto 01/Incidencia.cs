class Incidencia
{
    private string codigo;

    public string Codigo
    {
        get { return codigo; }
        set { codigo = value; }
    }

    private string tipo;

    public string Tipo
    {
        get { return tipo; }
        set { tipo = value; }
    }

    private string descripcion;

    public string Descripcion
    {
        get { return descripcion; }
        set { descripcion = value; }
    }

    private string fecha;

    public string Fecha
    {
        get { return fecha; }
        set { fecha = value; }
    }

    private string estadoIncidencia;

    public string EstadoIncidencia
    {
        get { return estadoIncidencia; }
        set { estadoIncidencia = value; }
    }

    public Incidencia(string codigo, string tipo, string descripcion, string fecha, string estadoIncidencia)
    {
        Codigo = codigo;
        Tipo = tipo;
        Descripcion = descripcion;
        Fecha = fecha;
        EstadoIncidencia = estadoIncidencia;
    }
}