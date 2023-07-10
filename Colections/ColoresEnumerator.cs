// Collections
//Collecion de String

using System.Collections;

internal class ColoresEnumerator : IEnumerable
{
    public ColoresEnumerator(Colores[] colores)
    {
        Colores = colores;
    }

    public Colores[] Colores { get; }
}