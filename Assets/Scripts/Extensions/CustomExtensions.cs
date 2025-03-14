using System.Collections.Generic;
using UnityEngine;

public static class CustomExtensions
{
    public static int GetEmptyIndex<T>(this IEnumerable<T> collection)
    {
        var count = 0;

        foreach (var item in collection)
        {
            if (item.Equals(default(T))) return count;
            
            count++;
        }

        return -1;
    }    
}
