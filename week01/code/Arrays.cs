public static class Arrays
{
    public static void Run() {
        var results = MultiplesOf(3, 5);
        Console.WriteLine($"Multiples of 3 (length 5): [{string.Join(", ", results)}]"); 
         
        Console.WriteLine("\nRotate list right by 3:");
        var data = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9};
        RotateListRight(data, 3);
        Console.WriteLine(string.Join(", ", data));
    }
   
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Create an array of doubles withe the specified length
        double[] results = new double[length];

        // Loop through the array and fill each element with the appropriate multiple of the number
        for(int i = 0; i < length; i++)
        {
            // Calculate each multiple by multiplying the number with (i + 1)
            results[i] = (i + 1) * number;
        }

        // Return the completed array
        return results; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Look for where to split the list
        int splitIndex = data.Count - amount;

        // Copy the right portion of the list that will be moved to the front
        List<int> rightPortion = data.GetRange(splitIndex, amount);

        // Copy the left portion of the list that will be moved to the baclk
        List<int> leftPortion = data.GetRange(0, splitIndex);

        // Combine the right portion and left portion to create the rotated list
        List<int> rotatedList = new List<int>();
        rotatedList.AddRange(rightPortion);
        rotatedList.AddRange(leftPortion);

        // Clear the original list and add the rotated elements back to it
        data.Clear();
        data.AddRange(rotatedList);

        // Todo Problem 2 End
    }
}
