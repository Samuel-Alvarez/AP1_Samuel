using Microsoft.EntityFrameworkCore;

public class AportesBLL
{
    private Contexto _contexto;
    public AportesBLL(Contexto contexto)
    {
        _contexto = contexto;
    }

    public bool Guardar(Aportes aporte)
    {
        if (!Existe(aporte.AporteId))
            return Insertar(aporte);
        else
            return Modificar(aporte);
    }
public bool Existe(int AporteId)
    {
        return _contexto.aportes.Any(o => o.AporteId == AporteId);
    }

    private bool Insertar(Aportes aportes)
    {
        _contexto.aportes.Add(aportes);
        int cantidad = _contexto.SaveChanges();
        return cantidad > 0;
    }

    private bool Modificar(Aportes aportes)
    {
        _contexto.Entry(aportes).State = EntityState.Modified;
        int cantidad = _contexto.SaveChanges();
        return cantidad > 0;
    }

    public Aportes Buscar(int AporteId)
    {
        var aportes = _contexto.aportes.Find(AporteId);

        return aportes;
    }
    public bool Eliminar(int Id){

        bool paso = false;

        try

        {
            var aportes = _contexto.aportes.Find(Id);

            if(aportes != null){

                _contexto.aportes.Remove(aportes);

                paso = _contexto.SaveChanges() > 0;

            }
        }
        catch (Exception)
        {
            throw;
        }
        return paso;
    } 
    public List<Aportes> GetAportes()
    {
        return _contexto.aportes.ToList();
    }

}