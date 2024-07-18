namespace TurboCollections;

public class TurboBubble
{
    public static void BubbleSort(int[] list)
    {
        int loop = list.Length;

        for (int i = loop-1; i > 0; i--)
        {
            bool swapped = false;
            for (int j = 0; j < i; j++)
            {
                if (list[j] > list[j+1])
                {
                    (list[j], list[j+1]) = (list[j+1], list[j]);
                    swapped = true;
                }
            }

            if (!swapped)
            {
                break;
            }
        }
        
    }
}