namespace Dsw2026Ej11.Collections;

using Dsw2026Ej11.Domain;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    private List<Alumno> _alumnos = new List<Alumno>();

    public void Agregar(Alumno alumno)
    {
        _alumnos.Add(alumno);
    }

    public List<Alumno> GetLista()
    {
        return _alumnos;
    }

    public Alumno? BuscarPorNombre(string nombre)
    {
        return _alumnos.FirstOrDefault(a => a.Nombre == nombre);
    }

    public void Eliminar (Alumno alumno)
    {
        _alumnos.Remove (alumno);
    }

    public void EliminarEnPosicion (int posicion)
    {
        _alumnos.RemoveAt(posicion);
    }



}
