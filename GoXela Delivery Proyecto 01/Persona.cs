using static System.Runtime.InteropServices.JavaScript.JSType;

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
    private string nombreCompleto;

    public string NombreCompleto
    {
        get { return nombreCompleto; }
        set
        {
            if (value != "")
            {
                nombreCompleto = value;
            }
            else
            {
                Console.WriteLine("El nombre no puede estar vacio");
            }
        }
    }
    private int edad;

    public int Edad
    {
        get { return edad; }
        set { edad = value; }
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
    public Persona(string codigo, string nombreCompleto, int edad, string numeroTelefono)
    {
        Codigo = codigo; NombreCompleto = nombreCompleto; Edad = edad; NumeroTelefono = numeroTelefono;
    }
    public virtual void MostrarInformacion()
    {

        Console.WriteLine("Codigo: " + Codigo);
        Console.WriteLine("Nombre: " + NombreCompleto);
        Console.WriteLine("Número de telefono: " + NumeroTelefono);
        Console.WriteLine("Edad: " + Edad);
    }

}
