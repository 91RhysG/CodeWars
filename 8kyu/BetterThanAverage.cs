public class Kata
{
    public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
    {
        int total = 0;
        int average = 0;
        foreach (int number in ClassPoints)
        {
            total += number;
        }
        average = total / ClassPoints.Length;
        if (YourPoints > average)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}