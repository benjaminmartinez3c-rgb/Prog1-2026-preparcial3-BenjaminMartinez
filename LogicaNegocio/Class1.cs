namespace LogicaNegocio;

public abstract class Vehiculo
{
    public string Patente {get;set;}
    public string Nombre {get;set;}
    public decimal PrecioBasePorHora {get;set;}

    public Vehiculo(string patente, string nombre, decimal precioBasePorHora)
    {

        if (string.IsNullOrWhiteSpace(patente))
            throw new Exception("La patente no puede estar vacía.");

        if (precioBasePorHora <= 0)
            throw new Exception("El precio base por hora debe ser mayor a cero.");

        Patente = patente;
        Nombre = nombre;
        PrecioBasePorHora = precioBasePorHora;
    }

    public abstract decimal CalcularPrecio(int horas);
}
