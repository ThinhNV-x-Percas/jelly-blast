[global::Cpp2ILInjected.Token(Token = "0x2000041")]
public class BeeSpawner : global::UnityEngine.MonoBehaviour
{
	[global::Cpp2ILInjected.Token(Token = "0x40000F2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private int particleCount;

	[global::Cpp2ILInjected.Token(Token = "0x40000F3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public float spawnRadius;

	[global::Cpp2ILInjected.Token(Token = "0x6000170")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE7EC0", Offset = "0xFE7EC0", Length = "0x140")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv22 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv268 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression> + 0xA48;\n\tv24 = *([302A96E]) & 1;\n\tv25 = v24 == 0;\n\tif (v25) goto L_0059;\n\tv124 = Il2CppMethodInfo + 0xC90;\n\tv28 = *([v22 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A48]);\n\tv269 = *([v28 @ X0_v35+E0]);\n\tv30 = *([v28 @ X0_v35+E0]) == 0;\n\tif (v30) goto L_0063;\nL_0019:\n\tv175 = Singleton`1::get_Instance /* +1 sharing this address */(*([v124 @ X21_v12]));\nL_001D:\n\tv182 = CollectParticleData[];\n\tv183 = Il2CppMethodInfo;\n\tv268 = v175 + 0x90;\n\tv185 = new *([v182 @ X23_v8 (Il2CppClass<CollectParticleData[]>)+990])();\n\tSystem.Action::.ctor(v185, this, *([v183 @ X24_v8 (Il2CppMethodInfo)+610]));\n\tv232 = System.Delegate::Combine(*([v268 @ X20_v3]), v185);\n\tv79 = v232 == 0;\n\tif (v79) goto L_0068;\n\tv32 = *([v232 @ X0_v29 (System.Delegate)]) != *([v182 @ X23_v8 (Il2CppClass<CollectParticleData[]>)+990]);\n\tif (v32) goto L_FFFFFFFF;\n\t*([v268 @ X20_v3]) = v232;\n\tv251 = *([v232 @ X0_v29 (System.Delegate)]) == *([v182 @ X23_v8 (Il2CppClass<CollectParticleData[]>)+990]);\n\tif (v251) goto L_0074;\n\tthrow System.InvalidCastException;\nL_0059:\n\t*([v84 @ X21_v7 (System.Delegate)+96E]) = 1;\n\tv124 = Il2CppMethodInfo + 0xC90;\n\tv118 = *([v268 @ X20_v3]);\n\tv269 = *([v118 @ X0_v24+E0]);\n\tv239 = *([v118 @ X0_v24+E0]) == 0;\n\tv120 = ~v239;\n\tif (v120) goto L_0019;\nL_0063:\n\tv175 = Singleton`1::get_Instance /* +1 sharing this address */(*([v148 @ X21_v6]));\n\tv208 = v175 == 0;\n\tv177 = ~v208;\n\tif (v177) goto L_001D;\n\tthrow System.NullReferenceException;\nL_0068:\n\t*([v268 @ X20_v3]) = 0;\nL_0074:\n\tv281 = 0xF3F1B4(v268, v269, v262, v260, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100);\n\treturn;\n// 78 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void Awake()
	{
		Singleton<GameManager>.Instance.OnInit += OnInit;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000171")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE8000", Offset = "0xFE8000", Length = "0x1A8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv26 = CollectParticleData[];\n\tgoto L_0022;\n\tv31 = Il2CppMethodInfo;\n\tv32 = v31 + 0xC90;\n\tv33 = \"il2cpp_codegen_initialize_runtime_metadata\"(v32, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48);\n\tv56 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv57 = v56 + 0xA48;\n\tv58 = \"il2cpp_codegen_initialize_runtime_metadata\"(v57, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48);\n\tv72 = CollectParticleData[];\n\tv73 = v72 + 0x718;\n\tv50 = \"il2cpp_codegen_initialize_runtime_metadata\"(v73, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48);\n\tv52 = 1;\n\t*([302A96F]) = v52;\nL_0022:\n\tv55 = \"SzArrayNew\"(*([v26 @ X20_v1 (Il2CppClass<CollectParticleData[]>)+718]), this.particleCount, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48);\n\tv71 = this.particleCount < 1;\n\tif (v71) goto L_006D;\n\tv74 = v55 == 0;\n\tif (v74) goto L_008E;\n\tv139 = v55 + 0x24;\nL_0038:\n\tv192 = UnityEngine.Component::get_transform(this);\n\tv247 = UnityEngine.Transform::get_position(v192);\n\tv270 = UnityEngine.Random::get_insideUnitCircle();\n\tv284 = v270 * this.spawnRadius;\n\tv285 = v270.y * this.spawnRadius;\n\tv286 = v284 * 0.5f;\n\tv287 = v285 * 0.5f;\n\tv288 = v247 + v286;\n\tv289 = v247.y + v287;\n\t// 76 MakeStruct v76 @ AGGFE80D0_0_v6 (UnityEngine.Vector2), typeof(UnityEngine.Vector2), v288 @ V0_v16 (System.Single), v289 @ V1_v16 (System.Single)\n\tv87 = Unity.Mathematics.float2::op_Implicit(v76);\n\t*([v139 @ X22_v7-4]) = v87;\n\t*([v139 @ X22_v7]) = v87.y;\n\tv164 = v164 + 1;\n\tv139 = v139 + 8;\n\tv95 = v164 < this.particleCount;\n\tif (v95) goto L_0038;\nL_006D:\n\tv122 = Il2CppMethodInfo;\n\tgoto L_0076;\n\tv168 = \"il2cpp_codegen_runtime_class_init\"(v124, v88, v35, v36, v37, v38, v39, v40, v86, v84, v82, v44, v45, v46, v47, v48);\nL_0076:\n\tv171 = Singleton`1::get_Instance /* +1 sharing this address */(*([v122 @ X19_v4 (Il2CppMethodInfo)+C90]));\n\tv266 = FluidSolver::AddBee(*([v171 @ X0_v14+30]), v55);\n\treturn;\n\tthrow System.IndexOutOfRangeException;\nL_008E:\n\tv240 = UnityEngine.Component::get_transform(this);\n\tv193 = v240 == 0;\n\tv194 = ~v193;\n\tif (v194) goto L_0094;\n\tv221 = new System.NullReferenceException();\nL_0094:\n\tv246 = UnityEngine.Transform::get_position(v240);\n\tv253 = UnityEngine.Random::get_insideUnitCircle();\n\tv273 = v253 * v244.spawnRadius;\n\tv274 = v253.y * v244.spawnRadius;\n\tv276 = v273 * 0.5f;\n\tv277 = v274 * 0.5f;\n\tv278 = v246 + v276;\n\tv279 = v246.y + v277;\n\t// 165 MakeStruct v281 @ AGGFE81A0_0_v1 (UnityEngine.Vector2), typeof(UnityEngine.Vector2), v278 @ V0_v6 (System.Single), v279 @ V1_v6 (System.Single)\n\tv282 = Unity.Mathematics.float2::op_Implicit(v281);\n\tthrow System.NullReferenceException;\n\treturn;\n// 110 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void OnInit()
	{
		global::Unity.Mathematics.float2[] positions = new global::Unity.Mathematics.float2[particleCount];
		global::UnityEngine.Vector3 center = transform.position;
		for (int i = 0; i < particleCount; i++)
		{
			global::UnityEngine.Vector2 offset = global::UnityEngine.Random.insideUnitCircle * spawnRadius * 0.5f;
			positions[i] = new global::Unity.Mathematics.float2(center.x + offset.x, center.y + offset.y);
		}
		Singleton<GameManager>.Instance.solver.AddBee(positions);
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000172")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE81A8", Offset = "0xFE81A8", Length = "0x14")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tthis.particleCount = 0x3F00000000000005;\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 3 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public BeeSpawner()
	{
		particleCount = 5;
		spawnRadius = 0.5f;
	}
}
