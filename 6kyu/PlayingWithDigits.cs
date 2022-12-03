public class DigPow
{
    public static long digPow(int n, int p)
    {
        int sum = 0;
        int k = -1;
        string convertedN = n.ToString();
        //multiply out number
        foreach(char input in convertedN){
            sum += Math.Pow(int.Parse(input.ToString()), p);
        }
        // for (int count = 0; count < splitValues.Length; count++)
        // {
        //     sum += (splitValues[count] * p++);            
        // }
        //divide multiplied number with original
        k = sum / n;
        if(k >= 1){ //int will round down a double number
            return k;
        }
        else{ //if K does not equal at least 1 return -1
            return -1;
        }        
    }
}