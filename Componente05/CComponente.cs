using System;
using System.Text;

namespace Componente04
{
    class CComponente<T> : IComponente<T>
    {
        public T Nombre { get; set; }
        public double Promedio { get; set; }

        public CComponente(T pNombre, double pPromedio)
        {
            Nombre = pNombre;
            Promedio = pPromedio;
        }

        public void Adicionar(IComponente<T> pElemento)
        {
            Console.WriteLine("No se puede adicionar a un componente simple.");
        }

        public IComponente<T> Borrar(T pElemento)
        {
            Console.WriteLine("No se puede borrar un componente simple.");
            return this;
        }

        public IComponente<T> Buscar(T pElemento)
        {
            if (Nombre.Equals(pElemento))
                return this;
            return null;
        }

        public string Mostrar(int pProfundidad)
        {
            return new String('-', pProfundidad) + Nombre + " Promedio: " + Promedio + "\n\r";
        }

        public double CalcularPromedio()
        {
            return Promedio;
        }
    }
}
