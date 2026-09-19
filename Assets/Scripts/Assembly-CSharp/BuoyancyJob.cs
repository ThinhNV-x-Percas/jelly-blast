[global::Unity.Burst.BurstCompile]
[global::Cpp2ILInjected.Token(Token = "0x200007F")]
public struct BuoyancyJob : global::Unity.Jobs.IJobParallelFor
{
	[global::Unity.Collections.ReadOnly]
	[global::Cpp2ILInjected.Token(Token = "0x400024D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
	public global::Unity.Collections.NativeArray<float> waterDensities;

	[global::Unity.Collections.ReadOnly]
	[global::Cpp2ILInjected.Token(Token = "0x400024E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public global::Unity.Collections.NativeArray<bool> isWater;

	[global::Unity.Collections.ReadOnly]
	[global::Cpp2ILInjected.Token(Token = "0x400024F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public global::Unity.Collections.NativeArray<int> fishIds;

	[global::Cpp2ILInjected.Token(Token = "0x4000250")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> deltaVel;

	[global::Cpp2ILInjected.Token(Token = "0x4000251")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public float buoyancyStrength;

	[global::Cpp2ILInjected.Token(Token = "0x4000252")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
	public float dt;

	[global::Cpp2ILInjected.Token(Token = "0x600024E")]
	[global::Cpp2ILInjected.Address(RVA = "0xFFAA40", Offset = "0xFFAA40", Length = "0x64")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv0 = this.isWater;\n\tv5 = *([v0 @ X9_v1 (Unity.Collections.NativeArray`1<System.Boolean>)+i @ X1 (System.Int32)]) == 0;\n\tif (v5) goto L_0006;\n\treturn;\nL_0006:\n\tv6 = this.waterDensities;\n\tv7 = i << 2;\n\tv11 = *([v6 @ X9_v3 (Unity.Collections.NativeArray`1<System.Single>)+v7 @ X10_v1 (System.Int32)]) * this.buoyancyStrength;\n\tv57 = v11 * this.dt;\n\tv13 = this.fishIds;\n\tv16 = v57 / 1.5f;\n\tv17 = *([v13 @ X9_v4 (Unity.Collections.NativeArray`1<System.Int32>)+v7 @ X10_v1 (System.Int32)]) + 1;\n\tv19 = v17 == 0;\n\tv22 = ~v19;\n\tif (v22) goto L_FFFFFFFF;\n\tgoto L_001D;\nL_001D:\n\tv28 = i << 3;\n\tv52 = this.deltaVel + v28;\n\tv47 = v57 + *([v52 @ X8_v2+4]);\n\t*([v52 @ X8_v2]) = *([v52 @ X8_v2]);\n\t*([v52 @ X8_v2+4]) = v47;\n\treturn;\n// 18 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void Execute(int i)
	{
		//IL_00a2: Expected O, but got I
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		global::Unity.Collections.NativeArray<bool> nativeArray = isWater;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X9_v1 (Unity.Collections.NativeArray`1<System.Boolean>)+i @ X1 (System.Int32)]");
		if ((nint)0 == 0)
		{
			global::Unity.Collections.NativeArray<float> nativeArray2 = waterDensities;
			int num = i << 2;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ X9_v3 (Unity.Collections.NativeArray`1<System.Single>)+v7 @ X10_v1 (System.Int32)]");
			float num2 = 0f * buoyancyStrength;
			float num3 = num2 * dt;
			global::Unity.Collections.NativeArray<int> nativeArray3 = fishIds;
			float num4 = num3 / 1.5f;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ X9_v4 (Unity.Collections.NativeArray`1<System.Int32>)+v7 @ X10_v1 (System.Int32)]");
			object obj = (nint)0 + (nint)1;
			if (obj != null)
			{
				num3 = num4;
			}
			global::Unity.Mathematics.float2 deltaVelValue = deltaVel[i];
			float num6 = num3;
			float num7 = num6 + deltaVelValue.y;
			deltaVel[i] = new global::Unity.Mathematics.float2(deltaVelValue.x, num7);
		}
	}
}
