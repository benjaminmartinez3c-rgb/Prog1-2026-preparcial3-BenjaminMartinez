namespace LogicaNegocio;

public abstract class Vehiculo
{
    public string Patente {get;set;}
    public string Nombre {get;set;}
    public decimal PrecioBasePorHora {get;set;}

    public Vehiculo(string patente, string nombre, decimal precioBasePorHora)
    {
        Patente = patente;
        Nombre = nombre;
        PrecioBasePorHora = precioBasePorHora;
    }

    public abstract decimal CalcularPrecio();
}
