class Motocicleta : Vehiculo
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

    public Motocicleta(string codigo, string tipo, string marca, string modelo, double capacidad, string estado, string placa)
        : base(codigo, tipo, marca, modelo, capacidad, estado)
    {
        Placa = placa;
    }

    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine("Placa: " + Placa);
    }
}