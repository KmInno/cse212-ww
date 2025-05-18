public static class Arrays
{
    /// <summary>
    /// function generates an array of doubles that are multiples of the given number.
    /// generates an array of length 'length' where each element is a multiple of 'number'.
    /// default value of 'number' is 0.0. because it's adoublle array
    /// the loop starts from 0 to 'length - 1' 
    /// calculates the multiple by multiplying 'number' with (i + 1) and assigns it to the result array.
    /// </summary>
    public static double[] MultiplesOf(double number, int length)
    {
        double[] result = new double[length];
        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }
        return result;
    }

    /// <summary>
    /// function rotates the elements of a list to the right by a specified amount.
    /// retrieve the total number of elements in the list
    /// ensures the rotation amount is within the bounds of the list size
    /// uses modulus (%) to handle cases where the rotation amount exceeds the list size
    /// handles no rotation cases
    /// extracts the last 'amount' elements from the list and stores them in a temporary list
    /// appends the remaining elements from the original list to the temporary list
    /// modify the original List
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        int count = data.Count;
        amount %= count;

        if (amount == 0) return;

        List<int> temp = new List<int>(data.GetRange(count - amount, amount));
        temp.AddRange(data.GetRange(0, count - amount));

        for (int i = 0; i < count; i++)  // Fixed condition
        {
            data[i] = temp[i];
        }
    }

}
