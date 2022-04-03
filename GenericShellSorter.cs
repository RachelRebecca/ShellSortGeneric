using System;
public class GenericShellSorter<T> where T : IComparable
{
    public T[] sort(T[] array)
    {
        int nrValues = array.Length;
        int gap = nrValues / 2;

        do
        {
            for (int ixO = gap; ixO < nrValues; ixO++)
            {
                T tmp = array[ixO];
                int ixI = ixO;
                while (ixI >= gap && array[ixI - gap].CompareTo(tmp) > 0)
                {
                    array[ixI] = array[ixI - gap];
                    ixI -= gap;
                }
                array[ixI] = tmp;
            }
            gap /= 2;
        }
        while (gap > 0);
        return array;

    }

}