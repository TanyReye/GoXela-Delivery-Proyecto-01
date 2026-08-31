class Persona
{
    private string codigo;
    public string Codigo
    {
        get { return codigo; }
        set
        {
            if (value != "")
            {
                codigo = value;
            }
            else
            {
                Console.WriteLine("El código no puede estar vacio");
            }
        }
    }
    private string nombre;
    public string Nombre
    {
        get { return nombre; }
        set
        {
            if (value != "")
            {
                nombre = value;
            }
            else
            {
                Console.WriteLine("El nombre no puede estar vacio");
            }
        }
    }
    private string numeroTelefono;
    public string NumeroTelefono
    {
        get { return numeroTelefono; }
        set
        {
            if (value != "")
            {
                numeroTelefono = value;
            }
            else
            {
                Console.WriteLine("El número de telefono no puede estar vacio");
            }
        }
    }
    private int edad;
    public int Edad
    {
        get { return edad; }
        set
        {
            if (value >= 18 && value <= 90)
            {
                edad = value;
            }
            else
            {
                Console.WriteLine("La edad debe ser mayor a 0");
            }
        }
    }


    public Persona(string codigo, string nombre, string numeroTelefono, int edad)
    {
        Codigo = codigo;
        Nombre = nombre;
        NumeroTelefono = numeroTelefono;
        Edad = edad;
    }
    public virtual void MostrarInformacion()
    {

        Console.WriteLine("Codigo: " + Codigo);
        Console.WriteLine("Nombre: " + Nombre);
        Console.WriteLine("Número de telefono: " + NumeroTelefono);
        Console.WriteLine("Edad: " + Edad);
    }

}