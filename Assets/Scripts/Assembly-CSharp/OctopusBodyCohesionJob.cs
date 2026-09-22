[global::Unity.Burst.BurstCompile]
[global::Cpp2ILInjected.Token(Token = "0x200007D")]
internal struct OctopusBodyCohesionJob : global::Unity.Jobs.IJobParallelFor
{
	[global::Unity.Collections.ReadOnly]
	[global::Cpp2ILInjected.Token(Token = "0x4000240")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
	public global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> positions;

	[global::Cpp2ILInjected.Token(Token = "0x4000241")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> deltaVel;

	[global::Unity.Collections.ReadOnly]
	[global::Cpp2ILInjected.Token(Token = "0x4000242")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public global::Unity.Collections.NativeArray<bool> regionHasHead;

	[global::Unity.Collections.ReadOnly]
	[global::Cpp2ILInjected.Token(Token = "0x4000243")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public global::Unity.Collections.NativeArray<int> octopusIds;

	[global::Unity.Collections.ReadOnly]
	[global::Cpp2ILInjected.Token(Token = "0x4000244")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public global::Unity.Collections.NativeHashMap<int, global::Unity.Mathematics.float2> octopusHeadMidpoints;

	[global::Cpp2ILInjected.Token(Token = "0x4000245")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public float bodyCohesionForce;

	[global::Cpp2ILInjected.Token(Token = "0x4000246")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
	public float dt;

	[global::Cpp2ILInjected.Token(Token = "0x600024C")]
	[global::Cpp2ILInjected.Address(RVA = "0xFFA524", Offset = "0xFFA524", Length = "0x148")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0017;\n\tv27 = Il2CppMethodInfo;\n\tv28 = v27 + 0xC68;\n\tv29 = \"il2cpp_codegen_initialize_runtime_metadata\"(v28, index, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv46 = 1;\n\t*([302A9EE]) = v46;\nL_0017:\n\tv47 = this.octopusIds;\n\tv49 = *([v47 @ X8_v3 (Unity.Collections.NativeArray`1<System.Int32>)+index @ X1 (System.Int32)*4]) + 1;\n\tv51 = v49 == 0;\n\tif (v51) goto L_002D;\n\tv55 = this.regionHasHead;\n\tv57 = *([v55 @ X8_v5 (Unity.Collections.NativeArray`1<System.Boolean>)+index @ X1 (System.Int32)]) == 0;\n\tif (v57) goto L_002E;\nL_002D:\n\treturn;\nL_002E:\n\tv69 = this + 0x40;\n\tv73 = Unity.Collections.NativeHashMap`2<System.Int32, Unity.Mathematics.float2>::get_Item(v69, *([v47 @ X8_v3 (Unity.Collections.NativeArray`1<System.Int32>)+index @ X1 (System.Int32)*4]));\n\tv113 = this.positions;\n\tv118 = *([2DD4420]) == 0;\n\tif (v118) goto L_0061;\n\tv133 = v73 - *([v113 @ X8_v9 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+index @ X1 (System.Int32)*8]);\n\tgoto L_0042;\nL_0042:\n\tv143 = v133 * v133;\n\t// 67 NotImplemented \"Instruction FADDP not yet implemented.\"\n\tv144 = UnityEngine.Mathf::Sqrt(v143);\n\tv103 = this.deltaVel;\n\tv81 = index << 3;\n\tv153 = v133 * v154;\n\tv155 = v153 * v115;\n\tv156 = v155 * v157;\n\tv88 = *([v103 @ X8_v17 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v81 @ X9_v1 (System.Int32)]) + v156;\n\t*([v103 @ X8_v17 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v81 @ X9_v1 (System.Int32)]) = v88;\n\treturn;\nL_0061:\n\t*([2DD4420]) = 1;\n\tv133 = v73 - *([v113 @ X8_v9 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+index @ X1 (System.Int32)*8]);\n\tgoto L_0042;\n\tv137 = \"il2cpp_codegen_runtime_class_init\"(v145, v48, v72, v31, v32, v33, v34, v35, v132, v112, v38, v39, v40, v41, v42, v43);\n\tgoto L_0042;\n\treturn;\n// 71 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void Execute(int index)
{
int blobId = octopusIds[index];

// The native reconstruction tests (blobId + 1) against zero,
// which is equivalent to skipping the sentinel value -1.
if (blobId == -1)
{
return;
}

// Regions that still contain a head are handled by OctopusHeadCohesionJob;
// only headless regions are pulled back toward the octopus head midpoint.
if (regionHasHead[index])
{
return;
}

global::Unity.Mathematics.float2 midpoint = octopusHeadMidpoints[blobId];
global::Unity.Mathematics.float2 offset = midpoint - positions[index];
float distanceSq = global::Unity.Mathematics.math.lengthsq(offset);

if (distanceSq <= 0f)
{
return;
}

float distance = global::Unity.Mathematics.math.sqrt(distanceSq);
global::Unity.Mathematics.float2 direction = offset / distance;
deltaVel[index] += direction * (bodyCohesionForce * dt);
}
}
