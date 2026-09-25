using UnityEngine;

[global::Cpp2ILInjected.Token(Token = "0x20000C1")]
public class NumberFormatter : MonoBehaviour
{
	#region Public Methods
	public static string FormatNumber(float num)
	{
		if (num >= 1000000f)
			return FormatWithSuffix(num, 1000000, "m");
		if (num >= 1000f)
			return FormatWithSuffix(num, 1000, "k");
		return num.ToString();
	}
	#endregion

	#region Private Methods
	private static string FormatWithSuffix(float num, int divisor, string suffix)
	{
		double scaled = (double)num / divisor;
		int decimals = System.Math.Max(0, 2 - (int)System.Math.Floor(System.Math.Log10(scaled)));
		return scaled.ToString("0." + new string('#', decimals)) + suffix;
	}
	#endregion
}
