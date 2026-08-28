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