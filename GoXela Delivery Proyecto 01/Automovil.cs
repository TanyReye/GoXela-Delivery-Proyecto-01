class Automovil : Vehiculo
{
    private string placa;

    public string Placa
    {
        get { return placa; }
        set
        {
            if (value != "")
            {
                placa = value;
            }
            else
            {
                Console.WriteLine("La placa no puede estar vacía");
            }
        }
    }

    private string transmision;

    public string Transmision
    {
        get { return transmision; }
        set
        {
            if (value != "")
            {
                transmision = value;
            }
            else
            {
                Console.WriteLine("La transmisión no puede estar vacía");
            }
        }
    }

    public Automovil(string codigo, string tipo, string marca, string modelo, double capacidad, string estado, string placa, string transmision)
        : base(codigo, tipo, marca, modelo, capacidad, estado)
    {
        Placa = placa;
        Transmision = transmision;
    }

    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine("Placa: " + Placa);
        Console.WriteLine("Transmisión: " + Transmision);
    }
}