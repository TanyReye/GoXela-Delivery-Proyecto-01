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

class Bicicleta : Vehiculo
{
    private string material;

    public string Material
    {
        get { return material; }
        set { material = value; }
    }

    public Bicicleta(string codigo, string marca, string modelo, double capacidadMaximaCarga, string estado, double costoOperativo, string estadoDisponibilidad, string material)
        : base(codigo, marca, modelo, capacidadMaximaCarga, estado, costoOperativo, estadoDisponibilidad)
    {
        Material = material;
    }
}

class Motocicleta : Vehiculo
{
    private string placa;

    public string Placa
    {
        get { return placa; }
        set { placa = value; }
    }

    public Motocicleta(string codigo, string marca, string modelo, double capacidadMaximaCarga, string estado, double costoOperativo, string estadoDisponibilidad, string placa)
        : base(codigo, marca, modelo, capacidadMaximaCarga, estado, costoOperativo, estadoDisponibilidad)
    {
        Placa = placa;
    }
}

class Automovil : Vehiculo
{
    private string placa;

    public string Placa
    {
        get { return placa; }
        set { placa = value; }
    }

    private string transmision;

    public string Transmision
    {
        get { return transmision; }
        set { transmision = value; }
    }

    public Automovil(string codigo, string marca, string modelo, double capacidadMaximaCarga, string estado, double costoOperativo, string estadoDisponibilidad, string placa, string transmision)
        : base(codigo, marca, modelo, capacidadMaximaCarga, estado, costoOperativo, estadoDisponibilidad)
    {
        Placa = placa;
        Transmision = transmision;
    }
}