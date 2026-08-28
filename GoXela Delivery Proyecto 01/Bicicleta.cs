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