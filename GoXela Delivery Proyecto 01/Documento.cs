class Documento : Paquete
{
    public Documento(string codigo, string descripcion, double peso, string valorDeclarado, string direccionOrigen, string direccionDestino, string estado)
        : base(codigo, descripcion, peso, valorDeclarado, direccionOrigen, direccionDestino, estado, "Documento")
    {
    }

    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
    }

    public override void CalcularTarifa()
    {
        Console.WriteLine("Tarifa correspondiente a documento.");
    }

    public override void PuedeSerTransportado()
    {
        Console.WriteLine("El documento puede ser transportado.");
    }
}