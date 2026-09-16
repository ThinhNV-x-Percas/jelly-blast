[global::Unity.Burst.BurstCompile(global::Unity.Burst.FloatPrecision.Low, global::Unity.Burst.FloatMode.Fast)]
[global::Cpp2ILInjected.Token(Token = "0x2000083")]
internal struct OctUF_FlagHeadJob : global::Unity.Jobs.IJobParallelFor
{
	[global::Unity.Collections.NativeDisableParallelForRestriction]
	[global::Cpp2ILInjected.Token(Token = "0x4000261")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
	public global::Unity.Collections.NativeArray<int> parent;

	[global::Unity.Collections.ReadOnly]
	[global::Cpp2ILInjected.Token(Token = "0x4000262")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public global::Unity.Collections.NativeArray<byte> isHead;

	[global::Unity.Collections.NativeDisableParallelForRestriction]
	[global::Cpp2ILInjected.Token(Token = "0x4000263")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public global::Unity.Collections.NativeArray<byte> componentHasHead;

	[global::Cpp2ILInjected.Token(Token = "0x6000254")]
	[global::Cpp2ILInjected.Address(RVA = "0xFFB6D4", Offset = "0xFFB6D4", Length = "0x40")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\nL_000D:\n\tv7 = *([p @ X1 (Unity.Collections.NativeArray`1<System.Int32>)+v32 @ X9_v2 (System.Int32)*4]) != v32;\n\tif (v7) goto L_000D;\n\tv37 = x << 2;\n\tv71 = p + v37;\n\tv69 = *([v71 @ X8_v4]);\n\tv44 = *([v71 @ X8_v4]) == *([p @ X1 (Unity.Collections.NativeArray`1<System.Int32>)+v32 @ X9_v2 (System.Int32)*4]);\n\tif (v44) goto L_002B;\nL_001C:\n\t*([v71 @ X8_v4]) = v32;\n\tv68 = v69 << 2;\n\tv71 = p + v68;\n\tv69 = *([v71 @ X8_v4]);\n\tv50 = *([v71 @ X8_v4]) != v32;\n\tif (v50) goto L_001C;\nL_002B:\n\treturn v32;\n// 30 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private static int Find(int x, global::Unity.Collections.NativeArray<int> p)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0038: Expected I4, but got O
		//IL_0064: Expected O, but got I4
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0087: Expected I4, but got O
		int num = x;
		int num2 = default(int);
		num = num2;
		bool flag;
		do
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [p @ X1 (Unity.Collections.NativeArray`1<System.Int32>)+v32 @ X9_v2 (System.Int32)*4]");
			flag = (nint)0 != num;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [p @ X1 (Unity.Collections.NativeArray`1<System.Int32>)+v32 @ X9_v2 (System.Int32)*4]");
			num = 0;
		}
		while (flag);
		int num3 = x << 2;
		object obj = p + num3;
		int num4 = (int)obj;
		object obj2 = obj;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [p @ X1 (Unity.Collections.NativeArray`1<System.Int32>)+v32 @ X9_v2 (System.Int32)*4]");
		if (obj2 != null)
		{
			do
			{
				obj = num;
				int num5 = num4 << 2;
				obj = p + num5;
				num4 = (int)obj;
			}
			while ((nint)obj != num);
		}
		return num;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000255")]
	[global::Cpp2ILInjected.Address(RVA = "0xFFB714", Offset = "0xFFB714", Length = "0x44")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv10 = this.isHead;\n\tv14 = *([v10 @ X8_v1 (Unity.Collections.NativeArray`1<System.Byte>)+i @ X1 (System.Int32)]) == 0;\n\tif (v14) goto L_0018;\n\tv20 = OctUF_FlagHeadJob::Find(i, this.parent);\n\tv30 = this.componentHasHead;\n\t*([v30 @ X8_v5 (Unity.Collections.NativeArray`1<System.Byte>)+v20 @ X0_v3 (System.Int32)]) = 1;\nL_0018:\n\treturn;\n// 18 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void Execute(int i)
	{
		global::Unity.Collections.NativeArray<byte> nativeArray = isHead;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v10 @ X8_v1 (Unity.Collections.NativeArray`1<System.Byte>)+i @ X1 (System.Int32)]");
		if ((nint)0 != 0)
		{
			int num = Find(i, parent);
			global::Unity.Collections.NativeArray<byte> nativeArray2 = componentHasHead;
			_ = 1;
		}
	}
}
