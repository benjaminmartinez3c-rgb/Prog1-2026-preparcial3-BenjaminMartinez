namespace LogicaNegocio;

public class Registro
{
    public int ID {get;set;}
    public Vehiculo VehiculoIngresado {get;set;}
    public int CantidadHoras{get;set;}
    public static int id;  

    public Registro(Vehiculo vehiculoIngresado, int cantidadHoras)
    {
        ID = ++id;
        VehiculoIngresado = vehiculoIngresado;
        CantidadHoras = cantidadHoras;
    }

    public decimal ObtenerTotal()
    {
        return VehiculoIngresado.CalcularPrecio(CantidadHoras);
    }

}
