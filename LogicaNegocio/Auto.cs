namespace LogicaNegocio;

public class Auto : Vehiculo
{
    public bool EsElectrico {get;set;}

    public Auto(string patente, string nombre, decimal precioBasePorHora, bool esElectrico) : base (patente, nombre, precioBasePorHora)
    {
        EsElectrico = esElectrico;
    }

    public override decimal CalcularPrecio(int horas)
    {
        decimal precio = PrecioBasePorHora;
        if (EsElectrico)
        {
            precio = PrecioBasePorHora*0.90m*horas;
        }
        return precio;
    }
}
