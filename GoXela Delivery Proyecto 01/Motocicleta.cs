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