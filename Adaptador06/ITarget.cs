namespace Adaptador06
{
    // Esta es la interfaz que conoce el cliente
    interface ITarget
    {
        int Sumar(int pA, int pB);
        int Restar(int pA, int pB);
        int Multiplicar(int pA, int pB);
        int Dividir(int pA, int pB);
    }
}
