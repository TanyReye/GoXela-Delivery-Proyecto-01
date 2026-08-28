class Entrega
{
    private Cliente cliente;

    public Cliente Cliente
    {
        get { return cliente; }
        set { cliente = value; }
    }

    private Paquete paquete;

    public Paquete Paquete
    {
        get { return paquete; }
        set { paquete = value; }
    }

    private Repartidor repartidor;

    public Repartidor Repartidor
    {
        get { return repartidor; }
        set { repartidor = value; }
    }

    private Vehiculo vehiculo;

    public Vehiculo Vehiculo
    {
        get { return vehiculo; }
        set { vehiculo = value; }
    }

    private string fechaSolicitud;

    public string FechaSolicitud
    {
        get { return fechaSolicitud; }
        set { fechaSolicitud = value; }
    }

    private string direccionOrigen;

    public string DireccionOrigen
    {
        get { return direccionOrigen; }
        set { direccionOrigen = value; }
    }

    private string direccionDestino;

    public string DireccionDestino
    {
        get { return direccionDestino; }
        set { direccionDestino = value; }
    }

    private double distanciaEstimada;

    public double DistanciaEstimada
    {
        get { return distanciaEstimada; }
        set { distanciaEstimada = value; }
    }

    private string tipoServicio;

    public string TipoServicio
    {
        get { return tipoServicio; }
        set { tipoServicio = value; }
    }

    private string estado;

    public string Estado
    {
        get { return estado; }
        set { estado = value; }
    }

    private string estadoExtra;

    public string EstadoExtra
    {
        get { return estadoExtra; }
        set { estadoExtra = value; }
    }

    private double tarifaBase;

    public double TarifaBase
    {
        get { return tarifaBase; }
        set { tarifaBase = value; }
    }

    private double recargos;

    public double Recargos
    {
        get { return recargos; }
        set { recargos = value; }
    }

    private double descuentos;

    public double Descuentos
    {
        get { return descuentos; }
        set { descuentos = value; }
    }

    private double total;

    public double Total
    {
        get { return total; }
        set { total = value; }
    }

    private string incidenciasRegistradas;

    public string IncidenciasRegistradas
    {
        get { return incidenciasRegistradas; }
        set { incidenciasRegistradas = value; }
    }

    public Entrega(Cliente cliente, Paquete paquete, Repartidor repartidor, Vehiculo vehiculo, string fechaSolicitud, string direccionOrigen, string direccionDestino, double distanciaEstimada, string tipoServicio, string estado, string estadoExtra, double tarifaBase, double recargos, double descuentos, double total, string incidenciasRegistradas)
    {
        Cliente = cliente;
        Paquete = paquete;
        Repartidor = repartidor;
        Vehiculo = vehiculo;
        FechaSolicitud = fechaSolicitud;
        DireccionOrigen = direccionOrigen;
        DireccionDestino = direccionDestino;
        DistanciaEstimada = distanciaEstimada;
        TipoServicio = tipoServicio;
        Estado = estado;
        EstadoExtra = estadoExtra;
        TarifaBase = tarifaBase;
        Recargos = recargos;
        Descuentos = descuentos;
        Total = total;
        IncidenciasRegistradas = incidenciasRegistradas;
    }
}