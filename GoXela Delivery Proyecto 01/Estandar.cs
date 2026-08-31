class PaqueteEstandar : Paquete
{
    public PaqueteEstandar(string codigo, string descripcion, double peso, double valorDeclarado, string direccionOrigen, string direccionDestino, string estado, string tipoPaquete)
        : base(codigo, descripcion, peso, valorDeclarado, direccionOrigen, direccionDestino, estado, tipoPaquete)
    {
    }
}
