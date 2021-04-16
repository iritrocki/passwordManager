using System;

namespace gestor
{
    public class Categoria
    {
        public Categoria(){}

        public Categoria(string v)
        {
            nombre = v;
        }

        public string nombre { get; set; }

        public void modificar(Categoria c, string v)
        {
            c.nombre = v;
        }

        public bool validarNombre(string unString)
        {
            if(unString.Length >= 3 && unString.Length <= 15)
                return true;
            return false;
        }

    }
}