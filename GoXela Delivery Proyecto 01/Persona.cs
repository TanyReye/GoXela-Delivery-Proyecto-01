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
class Cliente : Persona
{
    private string correoElectronico;

    public string CorreoElectronico
    {
        get { return correoElectronico; }
        set { correoElectronico = value; }
    }
    private string direccion;

    public string Direccion
    {
        get { return direccion; }
        set { direccion = value; }
    }
    private int solicitudesRealizadas;

    public int SolicitudesRealizadas
    {
        get { return solicitudesRealizadas; }
        set { solicitudesRealizadas = value; }
    }
    public Cliente(string codigo, string nombreCompleto, int edad, string numeroTelefono, string correoElectronico, string direccion, int solicitudesRealizadas)
        : base(codigo, nombreCompleto, edad, numeroTelefono)
    {
        CorreoElectronico = correoElectronico;
        Direccion = direccion;
        SolicitudesRealizadas = solicitudesRealizadas;
    }
}
class Repartidor : Persona
{
    private string numeroLicencia;

    public string NumeroLicencia
    {
        get { return numeroLicencia; }
        set { numeroLicencia = value; }
    }
    private string tipoLicencia;

    public string TipoLicencia
    {
        get { return tipoLicencia; }
        set { tipoLicencia = value; }
    }
    private string estadoDisponibilidad;

    public string EstadoDisponibilidad
    {
        get { return estadoDisponibilidad; }
        set { estadoDisponibilidad = value; }
    }
    private int entregasRealizadas;

    public int EntregasRealizadas
    {
        get { return entregasRealizadas; }
        set { entregasRealizadas = value; }
    }
    private double calificacion;

    public double Calificacion
    {
        get { return calificacion; }
        set { calificacion = value; }
    }
    public Repartidor(string codigo, string nombreCompleto, int edad, string numeroTelefono, string numeroLicencia, string tipoLicencia, string estadoDisponibilidad, int entregasRealizadas, double calificacion)
        : base(codigo, nombreCompleto, edad, numeroTelefono)
    {
        NumeroLicencia = numeroLicencia;
        TipoLicencia = tipoLicencia;
        EstadoDisponibilidad = estadoDisponibilidad;
        EntregasRealizadas = entregasRealizadas;
        Calificacion = calificacion;
    }

}