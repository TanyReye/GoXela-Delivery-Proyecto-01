class Paquete
{
    private string codigo;

    public string Codigo
    {
        get { return codigo; }
        set { codigo = value; }
    }

    private string descripcion;

    public string Descripcion
    {
        get { return descripcion; }
        set { descripcion = value; }
    }

    private double peso;

    public double Peso
    {
        get { return peso; }
        set { peso = value; }
    }

    private double valorDeclarado;

    public double ValorDeclarado
    {
        get { return valorDeclarado; }
        set { valorDeclarado = value; }
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

    private string estado;

    public string Estado
    {
        get { return estado; }
        set { estado = value; }
    }

    private string tipoPaquete;

    public string TipoPaquete
    {
        get { return tipoPaquete; }
        set { tipoPaquete = value; }
    }

    public Paquete(string codigo, string descripcion, double peso, double valorDeclarado, string direccionOrigen, string direccionDestino, string estado, string tipoPaquete)
    {
        Codigo = codigo;
        Descripcion = descripcion;
        Peso = peso;
        ValorDeclarado = valorDeclarado;
        DireccionOrigen = direccionOrigen;
        DireccionDestino = direccionDestino;
        Estado = estado;
        TipoPaquete = tipoPaquete;
    }
}