namespace LogicaNegocio;

public class Camioneta : Vehiculo
{
    public int NumeroDeCarga {get;set;}

      public Camioneta(string patente, string nombre, decimal precioBasePorHora, int numeroDeCarga) : base (patente, nombre, precioBasePorHora)
    {
        NumeroDeCarga = numeroDeCarga;
    }

    public override decimal CalcularPrecio(int horas)
    {
        return (PrecioBasePorHora * horas)*1.30m;
    }
}
