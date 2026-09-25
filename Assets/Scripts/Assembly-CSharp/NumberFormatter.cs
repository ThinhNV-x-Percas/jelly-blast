using System;
using UnityEngine;

public class NumberFormatter : MonoBehaviour
{
    public static string FormatNumber(float num)
    {
        if (num >= 1000000f)
        {
            return FormatWithSuffix(num, 1000000, "m");
        }
        if (num >= 1000f)
        {
            return FormatWithSuffix(num, 1000, "k");
        }
        return num.ToString();
    }

    private static string FormatWithSuffix(float num, int divisor, string suffix)
    {
        double scaled = num / divisor;
        int decimals = Math.Max(0, 2 - (int)Math.Floor(Math.Log10(scaled)));
        return scaled.ToString("0." + new string('#', decimals)) + suffix;
    }
}
