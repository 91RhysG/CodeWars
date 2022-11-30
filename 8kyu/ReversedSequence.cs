using System;

public static class Kata
{
    public static int[] ReverseSeq(int n)
    {
        int[] newArr = new int[n];
        int index = 0;
        for (int count = n; count > 0; count--){
            newArr[index] = count;
            index++;
        }
        return newArr;
    }
}