class Vehiculo
{
    private string codigo;

    public string Codigo
    {
        get { return codigo; }
        set { codigo = value; }
    }

    private string marca;

    public string Marca
    {
        get { return marca; }
        set { marca = value; }
    }

    private string modelo;

    public string Modelo
    {
        get { return modelo; }
        set { modelo = value; }
    }

    private double capacidadMaximaCarga;

    public double CapacidadMaximaCarga
    {
        get { return capacidadMaximaCarga; }
        set { capacidadMaximaCarga = value; }
    }

    private string estado;

    public string Estado
    {
        get { return estado; }
        set { estado = value; }
    }

    private double costoOperativo;

    public double CostoOperativo
    {
        get { return costoOperativo; }
        set { costoOperativo = value; }
    }

    private string estadoDisponibilidad;

    public string EstadoDisponibilidad
    {
        get { return estadoDisponibilidad; }
        set { estadoDisponibilidad = value; }
    }

    public Vehiculo(string codigo, string marca, string modelo, double capacidadMaximaCarga, string estado, double costoOperativo, string estadoDisponibilidad)
    {
        Codigo = codigo;
        Marca = marca;
        Modelo = modelo;
        CapacidadMaximaCarga = capacidadMaximaCarga;
        Estado = estado;
        CostoOperativo = costoOperativo;
        EstadoDisponibilidad = estadoDisponibilidad;
    }
}