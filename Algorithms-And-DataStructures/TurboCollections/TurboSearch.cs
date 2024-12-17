using System.Collections;

namespace TurboCollections;

public class TurboSearch
{
    public static int LinearSearch<T> (IEnumerable<T>list, T targetItem)
    {
        int index = 0;
        foreach (var item in list)
        {
            if (EqualityComparer<T>.Default.Equals(item, targetItem))
            {
                return index;
            }
            index++;
        }

        return -1;
    }
    public static int BinarySearch<T>(IList<T> list, T value)
    {
        int lowerBound = 0;
        int upperBound = list.Count - 1;

        while (lowerBound <= upperBound)
        {
            int midPoint = (lowerBound + upperBound) / 2;
            int comparison = Comparer<T>.Default.Compare(list[midPoint], value);

            if (comparison == 0)
            {
                return midPoint; 
            }
            if (comparison < 0)
            {
                lowerBound = midPoint + 1; 
            }
            else
            {
                upperBound = midPoint - 1; 
            }
        }

        return -1; 
    }

}