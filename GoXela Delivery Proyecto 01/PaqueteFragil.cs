class PaqueteFragil : Paquete
{
    public PaqueteFragil(string codigo, string descripcion, double peso,
        string valorDeclarado, string direccionOrigen,
        string direccionDestino, string estado)
        : base(codigo, descripcion, peso, valorDeclarado, direccionOrigen, direccionDestino, estado, "Paquete frágil")
    {
    }

    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
    }

    public override void CalcularTarifa()
    {
        Console.WriteLine("Tarifa correspondiente a paquete frágil.");
    }

    public override void PuedeSerTransportado()
    {
        Console.WriteLine("El paquete frágil requiere cuidado especial.");
    }
}