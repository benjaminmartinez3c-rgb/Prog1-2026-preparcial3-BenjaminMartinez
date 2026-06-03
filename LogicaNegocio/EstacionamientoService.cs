namespace LogicaNegocio;

public class EstacionamientoService
{
    private List<Registro> registros;

    public EstacionamientoService()
    {
        registros =new List<Registro>();
    }

    public void AgregarRegistro(Registro registro)
    {
        registros.Add(registro);
    }
    
    public List<Registro> ObtenerRegistroPorNombre(string nombre)
    {
        List<Registro> resultado = new List<Registro>();
        foreach (var r in registros)
        {
            if (r.VehiculoIngresado.Nombre.Trim().ToLower() == nombre.Trim().ToLower())
            {
                resultado.Add(r);
            }
        }

        return resultado;
    }

    public decimal ObtenerTotalporRegistrados()
    {
        decimal total = 0;

        foreach (var r in registros)
        {
            total += r.ObtenerTotal();
        }
        return total;
    }

    public Registro ObtenerMayorRegistro()
    {
        if (registros.Count == 0)
        {
            return null;
        }

        Registro mayor = registros[0];

        foreach (var r in registros)
        {
            if (r.ObtenerTotal() > mayor.ObtenerTotal())
            {
                mayor = r;
            }
        }

        return mayor;
    }
}
