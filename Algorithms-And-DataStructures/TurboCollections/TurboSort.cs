namespace TurboCollections;

public static class TurboSort
{

    public static void SelectionSort(List<int>numbers)
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            int minValue = i;

            for (int j = i +1; j < numbers.Count ; j++)
            {
                if (numbers[j] < numbers[minValue])
                {
                    minValue = j;
                }
            }

            if (minValue !=i)
            {
                (numbers[i], numbers[minValue]) = (numbers[minValue], numbers[i]);
            }
        }
        
    }
}