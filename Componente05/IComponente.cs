using System;
using System.Text;

namespace Componente04
{
    interface IComponente<T>
    {
        T Nombre { get; set; }
        double Promedio { get; set; }
        void Adicionar(IComponente<T> pElemento);
        IComponente<T> Borrar(T pElemento);
        IComponente<T> Buscar(T pElemento);
        string Mostrar(int pProfundidad);
        double CalcularPromedio();
    }
}
