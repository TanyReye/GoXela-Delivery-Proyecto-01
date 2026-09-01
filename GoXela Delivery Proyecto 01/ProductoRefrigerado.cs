class ProductoRefrigerado : Paquete
{
    public ProductoRefrigerado(string codigo, string descripcion, double peso,
        string valorDeclarado, string direccionOrigen,
        string direccionDestino, string estado)
        : base(codigo, descripcion, peso, valorDeclarado, direccionOrigen, direccionDestino, estado, "Producto refrigerado")
    {
    }

    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
    }

    public override void CalcularTarifa()
    {
        Console.WriteLine("Tarifa correspondiente a producto refrigerado.");
    }

    public override void PuedeSerTransportado()
    {
        Console.WriteLine("El producto refrigerado requiere condiciones especiales.");
    }
}