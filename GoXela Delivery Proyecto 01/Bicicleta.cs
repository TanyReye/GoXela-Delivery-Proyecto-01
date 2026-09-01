class Bicicleta : Vehiculo
{
    private string material;

    public string Material
    {
        get { return material; }
        set
        {
            if (value != "")
            {
                material = value;
            }
            else
            {
                Console.WriteLine("El material no puede estar vacío");
            }
        }
    }

    public Bicicleta(string codigo, string tipo, string marca, string modelo, double capacidad,
        string estado, string material)
        : base(codigo, tipo, marca, modelo, capacidad, estado)
    {
        Material = material;
    }

    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine("Material: " + Material);
    }
}