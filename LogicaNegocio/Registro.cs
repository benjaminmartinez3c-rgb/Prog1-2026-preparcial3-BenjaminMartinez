namespace LogicaNegocio;

public class Registro
{
    public int ID {get;set;}
    public Vehiculo VehiculoIngresado {get;set;}
    public int CantidadHoras{get;set;}
    public static int id;  

    public Registro(Vehiculo vehiculoIngresado, int cantidadHoras)
    {
        if (cantidadHoras <= 0)
            throw new Exception("La cantidad de horas debe ser mayor a cero.");
        
        ID = ++id;
        VehiculoIngresado = vehiculoIngresado;
        CantidadHoras = cantidadHoras;
    }

    public decimal ObtenerTotal()
    {
        return VehiculoIngresado.CalcularPrecio(CantidadHoras);
    }

}
