using System.Collections.ObjectModel;
using TurboCollections;

namespace P1_3_Iterator;
public class iterator
{
    
    public static void Main()
    {
        List<int> numbers = new List<int> {1, 1, 2, 3, 5};
        IEnumerable<int> enumerable = numbers;
        
        IEnumerator<int> enumerator = enumerable.GetEnumerator();
        int sum = 0;
        
        while (enumerator.MoveNext())
        {
            sum += enumerator.Current;
            
            Console.WriteLine(enumerator.Current);
        }
        Console.WriteLine(sum);

        //TurboMaths.GetEvenNumbersList(12);
        //TurboMaths.GetEvenNumbers(12)

       /* foreach (var oddNumber in TurboMaths.GetOddNumbers(1_000_000_000))
        {
            Console.WriteLine(oddNumber);
        }*/

        foreach (var oddNumber in TurboMaths.GetOddNumberList(1_000_000_000))
        {
            Console.WriteLine(oddNumber);
        }
    }

}

