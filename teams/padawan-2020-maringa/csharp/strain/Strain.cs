using System;
using System.Collections.Generic;
using System.Linq;

public static class Strain
{
    public static IEnumerable<T> Keep<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        //return collection.Where(predicate);
        //var mantem = new List<T>();
        foreach (var x in collection)
        {
            if (predicate(x))
                yield return x;
        }
        //return mantem;
    }

    public static IEnumerable<T> Discard<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        foreach (var x in collection)
        {
            if (!predicate(x))
                yield return x;
        }

    }
}


