namespace TurboCollections;

public class TurboMaths
{
    // Returns all Odd Numbers until the given number. e.g.:
// GetEvenNumbersList(12) -> {0, 2, 4, 8, 10, 12};
// GetEvenNumbersList(15) -> {0, 2, 4, 8, 10, 12, 14};
// GetEvenNumbersList(-1) -> {};
// GetEvenNumbersList(0) -> {0};
    public static List<int> GetOddNumberList(int maxOddNumber)
    {
        List<int> oddNumbers = new List<int>(maxOddNumber);
        for (int i = 0; i <=maxOddNumber; i +=2)
        {
            oddNumbers.Add(i);
        }

        return oddNumbers;
    }

    /*public static List<int> GetEvenNumbersList(int maxNumber)
    {
        List<int> evenNumbers = new List<int>(maxNumber);
        for (int i = 0; i <=maxNumber; i +=2)
        {
            evenNumbers.Add(i);
        }

        return evenNumbers;
    }*/
    
    public static IEnumerable<int> GetOddNumbers(int maxOddNumber){

        for (int i = 0; i <=maxOddNumber; i+=2)
        {
            yield return i;
        }
    }// Returns all Odd Numbers until the given number. e.g.:
// GetEvenNumbers(12) -> {0, 2, 4, 8, 10, 12};
// GetEvenNumbers(15) -> {0, 2, 4, 8, 10, 12, 14};
// GetEvenNumbers(-1) -> {};
// GetEvenNumbers(0) -> {0};
    /*public static IEnumerable<int> GetEvenNumbers(int maxNumber){

        for (int i = 0; i <=maxNumber; i+=2)
        {
            yield return i;
        }
    }*/
}