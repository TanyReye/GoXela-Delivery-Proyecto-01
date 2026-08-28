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