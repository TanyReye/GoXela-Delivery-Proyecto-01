class Cliente : Persona
{
    private string correo;
    public string Correo
    {
        get { return correo; }
        set
        {
            if (value != "")
            {
                correo = value;
            }
            else
            {
                Console.WriteLine("El correo no puede estar vacío");
            }
        }
    }
    private string direccion;
    public string Direccion
    {
        get { return direccion; }
        set
        {
            if (value != "")
            {
                direccion = value;
            }
            else
            {
                Console.WriteLine("La dirección no puede estar vacia");
            }
        }
    }
    private int cantidadSolicitudes;
    public int CantidadSolicitudes
    {
        get { return cantidadSolicitudes; }
        set
        {
            if (value > 0)
            {
                cantidadSolicitudes = value;
            }
            else
            {
                Console.WriteLine("La cantidad de solicitudes debe ser mayor a 0");
            }
        }
    }


    public Cliente(string codigo, string nombre, string numeroTelefono, int edad, string correo, string direccion, int cantidadSolicitudes)
    : base(codigo, nombre, numeroTelefono, edad)
    {
        Correo = correo;
        Direccion = direccion;
        CantidadSolicitudes = cantidadSolicitudes;
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine("========INFORMACIÓN CLIENTE========");
        base.MostrarInformacion();
        Console.WriteLine("Correo: " + Correo);
        Console.WriteLine("Dirección: " + Direccion);
        Console.WriteLine("Cantidad solicitudes: " + CantidadSolicitudes);
    }
}