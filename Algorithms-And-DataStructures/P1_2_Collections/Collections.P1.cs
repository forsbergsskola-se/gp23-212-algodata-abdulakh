using System.Collections;

namespace P1_2_Collections;

class Collections
{ 
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        numbers.Add(137);
        numbers.Add(1000);
        numbers.Add(-200);

        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        ArrayList arrayList = new ArrayList{true, "Forsbergs", 'a', 1000, 0.12};

        for (int i = 0; i < arrayList.Count; i++)
        {
            Console.WriteLine(arrayList[i]);
        }
    }
}