class PaqueteEstandar : Paquete
{
    public PaqueteEstandar(string codigo, string descripcion, double peso,
        string valorDeclarado, string direccionOrigen,
        string direccionDestino, string estado)
        : base(codigo, descripcion, peso, valorDeclarado, direccionOrigen, direccionDestino, estado, "Paquete estándar")
    {
    }

    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
    }

    public override void CalcularTarifa()
    {
        Console.WriteLine("Tarifa correspondiente a paquete estándar.");
    }

    public override void PuedeSerTransportado()
    {
        Console.WriteLine("El paquete estándar puede ser transportado.");
    }
}