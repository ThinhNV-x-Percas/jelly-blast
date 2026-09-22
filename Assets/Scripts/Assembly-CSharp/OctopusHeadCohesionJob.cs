[global::Unity.Burst.BurstCompile]
[global::Cpp2ILInjected.Token(Token = "0x200007C")]
public struct OctopusHeadCohesionJob : global::Unity.Jobs.IJobParallelFor
{
	[global::Unity.Collections.ReadOnly]
	[global::Cpp2ILInjected.Token(Token = "0x4000238")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
	public global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> positions;

	[global::Cpp2ILInjected.Token(Token = "0x4000239")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> deltaVel;

	[global::Unity.Collections.ReadOnly]
	[global::Cpp2ILInjected.Token(Token = "0x400023A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public global::Unity.Collections.NativeArray<int> octopusIds;

	[global::Unity.Collections.ReadOnly]
	[global::Cpp2ILInjected.Token(Token = "0x400023B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public global::Unity.Collections.NativeArray<bool> inOctopusHead;

	[global::Unity.Collections.ReadOnly]
	[global::Cpp2ILInjected.Token(Token = "0x400023C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public global::Unity.Collections.NativeHashMap<int, global::Unity.Mathematics.float2> octopusMidpoints;

	[global::Cpp2ILInjected.Token(Token = "0x400023D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public float headCohesionRadius;

	[global::Cpp2ILInjected.Token(Token = "0x400023E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
	public float headSpringStrength;

	[global::Cpp2ILInjected.Token(Token = "0x400023F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public float dt;

	[global::Cpp2ILInjected.Token(Token = "0x600024B")]
	[global::Cpp2ILInjected.Address(RVA = "0xFFA3E0", Offset = "0xFFA3E0", Length = "0x144")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0017;\n\tv27 = Il2CppMethodInfo;\n\tv28 = v27 + 0xC68;\n\tv29 = \"il2cpp_codegen_initialize_runtime_metadata\"(v28, index, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv46 = 1;\n\t*([302A9ED]) = v46;\nL_0017:\n\tv47 = this.octopusIds;\n\tv49 = *([v47 @ X8_v3 (Unity.Collections.NativeArray`1<System.Int32>)+index @ X1 (System.Int32)*4]) + 1;\n\tv51 = v49 == 0;\n\tif (v51) goto L_0070;\n\tv55 = this.inOctopusHead;\n\tv57 = *([v55 @ X8_v5 (Unity.Collections.NativeArray`1<System.Boolean>)+index @ X1 (System.Int32)]) == 0;\n\tif (v57) goto L_0070;\n\tv125 = this + 0x40;\n\tv128 = Unity.Collections.NativeHashMap`2<System.Int32, Unity.Mathematics.float2>::get_Item(v125, *([v47 @ X8_v3 (Unity.Collections.NativeArray`1<System.Int32>)+index @ X1 (System.Int32)*4]));\n\tv130 = this.positions;\n\tv134 = *([2DD4420]) == 0;\n\tif (v134) goto L_0077;\n\tv98 = v128 - *([v130 @ X8_v9 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+index @ X1 (System.Int32)*8]);\n\tgoto L_0038;\nL_0038:\n\tv157 = v98 * v98;\n\t// 57 NotImplemented \"Instruction FADDP not yet implemented.\"\n\tv104 = UnityEngine.Mathf::Sqrt(v157);\n\tv167 = v104 == 0;\n\tv172 = ~v167;\n\tv69 = ~v172;\n\tif (v69) goto L_FFFFFFFF;\n\tv173 = v104 < this.headCohesionRadius;\n\tv93 = ~v173;\n\tv175 = v104 - this.headCohesionRadius;\n\tv86 = v175 == 0;\n\tgoto L_0057;\nL_0057:\n\tv186 = ~v93;\n\tv72 = v186 | v86;\n\tif (v72) goto L_0070;\n\t// 90 NotImplemented \"Instruction DUP not yet implemented.\"\n\tv67 = v98 / v38;\n\tv112 = this.deltaVel;\n\tv64 = index << 3;\n\tv189 = v67 * v190;\n\tv191 = v189 * v132;\n\tv192 = v191 * v193;\n\tv103 = *([v112 @ X8_v17 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v64 @ X9_v2 (System.Int32)]) + v192;\n\t*([v112 @ X8_v17 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v64 @ X9_v2 (System.Int32)]) = v103;\nL_0070:\n\treturn;\nL_0077:\n\t*([2DD4420]) = 1;\n\tv98 = v128 - *([v130 @ X8_v9 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+index @ X1 (System.Int32)*8]);\n\tgoto L_0038;\n\tv152 = \"il2cpp_codegen_runtime_class_init\"(v158, v48, v106, v31, v32, v33, v34, v35, v150, v129, v38, v39, v40, v41, v42, v43);\n\tgoto L_0038;\n\treturn;\n// 80 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void Execute(int index)
{
int blobId = octopusIds[index];

// The native reconstruction tests (blobId + 1) against zero,
// which is equivalent to skipping the sentinel value -1.
if (blobId == -1)
{
return;
}

// Only particles flagged as part of the octopus head receive head cohesion.
if (!inOctopusHead[index])
{
return;
}

global::Unity.Mathematics.float2 midpoint = octopusMidpoints[blobId];
global::Unity.Mathematics.float2 offset = midpoint - positions[index];
float distanceSq = global::Unity.Mathematics.math.lengthsq(offset);

if (distanceSq <= 0f)
{
return;
}

float distance = global::Unity.Mathematics.math.sqrt(distanceSq);

// Spring only engages once the particle drifts beyond the cohesion radius.
if (distance <= headCohesionRadius)
{
return;
}

global::Unity.Mathematics.float2 direction = offset / distance;
float displacement = distance - headCohesionRadius;
deltaVel[index] += direction * displacement * headSpringStrength * dt;
}
}
