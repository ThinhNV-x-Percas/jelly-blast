[global::Cpp2ILInjected.Token(Token = "0x20000D5")]
public class SpongeSpawner : global::UnityEngine.MonoBehaviour
{
	[global::Cpp2ILInjected.Token(Token = "0x400047A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private int subSpongeParticleCount;

	[global::Cpp2ILInjected.Token(Token = "0x400047B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public float spawnRadius;

	[global::Cpp2ILInjected.Token(Token = "0x60003C7")]
	[global::Cpp2ILInjected.Address(RVA = "0x10179A4", Offset = "0x10179A4", Length = "0x140")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv22 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv268 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression> + 0xA48;\n\tv24 = *([302AA93]) & 1;\n\tv25 = v24 == 0;\n\tif (v25) goto L_0059;\n\tv124 = Il2CppMethodInfo + 0xC90;\n\tv28 = *([v22 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A48]);\n\tv269 = *([v28 @ X0_v35+E0]);\n\tv30 = *([v28 @ X0_v35+E0]) == 0;\n\tif (v30) goto L_0063;\nL_0019:\n\tv175 = Singleton`1::get_Instance /* +1 sharing this address */(*([v124 @ X21_v12]));\nL_001D:\n\tv182 = CollectParticleData[];\n\tv183 = Il2CppMethodInfo;\n\tv268 = v175 + 0x90;\n\tv185 = new *([v182 @ X23_v8 (Il2CppClass<CollectParticleData[]>)+990])();\n\tSystem.Action::.ctor(v185, this, *([v183 @ X24_v8 (Il2CppMethodInfo)+B98]));\n\tv232 = System.Delegate::Combine(*([v268 @ X20_v3]), v185);\n\tv79 = v232 == 0;\n\tif (v79) goto L_0068;\n\tv32 = *([v232 @ X0_v29 (System.Delegate)]) != *([v182 @ X23_v8 (Il2CppClass<CollectParticleData[]>)+990]);\n\tif (v32) goto L_FFFFFFFF;\n\t*([v268 @ X20_v3]) = v232;\n\tv251 = *([v232 @ X0_v29 (System.Delegate)]) == *([v182 @ X23_v8 (Il2CppClass<CollectParticleData[]>)+990]);\n\tif (v251) goto L_0074;\n\tthrow System.InvalidCastException;\nL_0059:\n\t*([v84 @ X21_v7 (System.Delegate)+A93]) = 1;\n\tv124 = Il2CppMethodInfo + 0xC90;\n\tv118 = *([v268 @ X20_v3]);\n\tv269 = *([v118 @ X0_v24+E0]);\n\tv239 = *([v118 @ X0_v24+E0]) == 0;\n\tv120 = ~v239;\n\tif (v120) goto L_0019;\nL_0063:\n\tv175 = Singleton`1::get_Instance /* +1 sharing this address */(*([v148 @ X21_v6]));\n\tv208 = v175 == 0;\n\tv177 = ~v208;\n\tif (v177) goto L_001D;\n\tthrow System.NullReferenceException;\nL_0068:\n\t*([v268 @ X20_v3]) = 0;\nL_0074:\n\tv281 = 0xF3F1B4(v268, v269, v262, v260, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100);\n\treturn;\n// 78 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void Awake()
	{
		//IL_000e: Expected I, but got O
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_0050: Expected O, but got I4
		//IL_01e4: Expected O, but got I
		//IL_01fc: Expected O, but got I
		//IL_006a: Expected O, but got I
		//IL_007a: Expected O, but got I
		//IL_008a: Expected O, but got I
		//IL_00d4: Expected I, but got O
		//IL_00e9: Expected O, but got I
		//IL_012e: Expected O, but got I4
		//IL_0137: Expected O, but got I4
		//IL_027a: Expected O, but got I4
		//IL_01c3: Expected O, but got I4
		//IL_01cc: Expected O, but got I4
		//IL_019b: Expected O, but got I4
		//IL_01a4: Expected O, but got I4
		object obj = (nint)0 + (nint)2632;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302AA93]");
		int num2 = (int)((nint)0 & (nint)1);
		bool flag = num2 == 0;
		global::System.Delegate obj2 = null;
		global::System.Delegate obj5;
		object obj8 = default(object);
		if (!flag)
		{
			object obj3 = (nint)0 + (nint)3216;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A48]");
			object obj4 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ X0_v35+E0]");
			obj5 = null;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ X0_v35+E0]");
			bool flag2 = (nint)0 == 0;
			object obj6 = obj3;
			if (!flag2)
			{
				goto IL_00b7;
			}
		}
		else
		{
			_ = 1;
			object obj3 = (nint)0 + (nint)3216;
			object obj7 = obj;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v24+E0]");
			obj5 = null;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v24+E0]");
			bool flag3 = (nint)0 == 0;
			bool flag4 = !flag3;
			object obj6 = obj3;
			if (flag4)
			{
				goto IL_00b7;
			}
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
		if (obj8 == null)
		{
			throw new global::System.NullReferenceException();
		}
		goto IL_00c6;
		IL_00c6:
		nint num4 = 0;
		obj = (nint)obj8 + 144;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X24_v8 (Il2CppMethodInfo)+B98]");
		global::System.Action b = null;
		global::System.Delegate obj9 = global::System.Delegate.Combine((global::System.Delegate)obj, b);
		bool flag5 = (object)obj9 == null;
		object obj10 = 0;
		object obj11 = 0;
		obj5 = obj9;
		if (!flag5)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X23_v8 (Il2CppClass<CollectParticleData[]>)+990]");
			if ((object)obj9 == null)
			{
				obj = obj9;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X23_v8 (Il2CppClass<CollectParticleData[]>)+990]");
				bool flag6 = (object)obj9 == null;
				obj10 = 0;
				obj11 = 0;
				obj5 = obj9;
				if (flag6)
				{
					goto IL_027f;
				}
			}
			obj10 = 0;
			obj11 = 0;
			throw new global::System.InvalidCastException();
		}
		obj = 0;
		goto IL_027f;
		IL_00b7:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
		goto IL_00c6;
		IL_027f:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003C8")]
	[global::Cpp2ILInjected.Address(RVA = "0x1017AE4", Offset = "0x1017AE4", Length = "0x1AC")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv30 = CollectParticleData[];\n\tgoto L_0025;\n\tv35 = Il2CppMethodInfo;\n\tv36 = v35 + 0xC90;\n\tv37 = \"il2cpp_codegen_initialize_runtime_metadata\"(v36, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\tv61 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv62 = v61 + 0xA48;\n\tv63 = \"il2cpp_codegen_initialize_runtime_metadata\"(v62, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\tv76 = CollectParticleData[];\n\tv77 = v76 + 0x718;\n\tv54 = \"il2cpp_codegen_initialize_runtime_metadata\"(v77, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\tv56 = 1;\n\t*([302AA94]) = v56;\nL_0025:\n\tv60 = \"SzArrayNew\"(*([v30 @ X20_v1 (Il2CppClass<CollectParticleData[]>)+718]), this.subSpongeParticleCount, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\tv75 = this.subSpongeParticleCount < 1;\n\tif (v75) goto L_006D;\n\tv78 = v60 == 0;\n\tif (v78) goto L_0090;\n\tv143 = v60 + 0x24;\nL_003A:\n\tv195 = UnityEngine.Component::get_transform(this);\n\tv250 = UnityEngine.Transform::get_position(v195);\n\tv275 = UnityEngine.Random::get_insideUnitCircle();\n\tv289 = v275 * this.spawnRadius;\n\tv290 = v275.y * this.spawnRadius;\n\tv291 = v289 * 0.5f;\n\tv292 = v290 * 0.5f;\n\tv293 = v250 + v291;\n\tv294 = v250.y + v292;\n\t// 78 MakeStruct v80 @ AGG1017BB8_0_v6 (UnityEngine.Vector2), typeof(UnityEngine.Vector2), v293 @ V0_v16 (System.Single), v294 @ V1_v16 (System.Single)\n\tv91 = Unity.Mathematics.float2::op_Implicit(v80);\n\t*([v143 @ X23_v7-4]) = v91;\n\t*([v143 @ X23_v7]) = v91.y;\n\tv145 = v145 + 1;\n\tv143 = v143 + 8;\n\tv101 = this.subSpongeParticleCount != v145;\n\tif (v101) goto L_003A;\nL_006D:\n\tv126 = Il2CppMethodInfo;\n\tgoto L_0076;\n\tv171 = \"il2cpp_codegen_runtime_class_init\"(v128, v92, v39, v40, v41, v42, v43, v44, v90, v88, v86, v48, v49, v50, v51, v52);\nL_0076:\n\tv174 = Singleton`1::get_Instance /* +1 sharing this address */(*([v126 @ X19_v4 (Il2CppMethodInfo)+C90]));\n\tv271 = FluidSolver::AddSponge(*([v174 @ X0_v14+30]), v60);\n\treturn;\n\tthrow System.IndexOutOfRangeException;\nL_0090:\n\tv244 = UnityEngine.Component::get_transform(this);\n\tv196 = v244 == 0;\n\tv197 = ~v196;\n\tif (v197) goto L_0096;\n\tv224 = new System.NullReferenceException();\nL_0096:\n\tv249 = UnityEngine.Transform::get_position(v244);\n\tv256 = UnityEngine.Random::get_insideUnitCircle();\n\tv278 = v256 * v247.spawnRadius;\n\tv279 = v256.y * v247.spawnRadius;\n\tv281 = v278 * 0.5f;\n\tv282 = v279 * 0.5f;\n\tv283 = v249 + v281;\n\tv284 = v249.y + v282;\n\t// 167 MakeStruct v286 @ AGG1017C88_0_v1 (UnityEngine.Vector2), typeof(UnityEngine.Vector2), v283 @ V0_v6 (System.Single), v284 @ V1_v6 (System.Single)\n\tv287 = Unity.Mathematics.float2::op_Implicit(v286);\n\tthrow System.NullReferenceException;\n\treturn;\n// 112 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void OnInit()
	{
		//IL_000e: Expected I, but got O
		//IL_0187: Expected O, but got I
		//IL_003f: Expected O, but got I
		//IL_011a: Expected O, but got F4
		//IL_0137: Expected O, but got I
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"SzArrayNew\"");
		global::Unity.Mathematics.float2[] array = new global::Unity.Mathematics.float2[subSpongeParticleCount];
		if (subSpongeParticleCount >= 1)
		{
			if (array == null)
			{
				global::UnityEngine.Transform transform = base.transform;
				bool flag = (object)transform == null;
				bool flag2 = !flag;
				SpongeSpawner spongeSpawner = this;
				if (!flag2)
				{
					global::System.NullReferenceException ex = new global::System.NullReferenceException();
					transform = (global::UnityEngine.Transform)(object)ex;
					spongeSpawner = this;
				}
				global::UnityEngine.Vector3 position = transform.position;
				global::UnityEngine.Vector2 insideUnitCircle = global::UnityEngine.Random.insideUnitCircle;
				float num2 = insideUnitCircle.x * spongeSpawner.spawnRadius;
				float num3 = insideUnitCircle.y * spongeSpawner.spawnRadius;
				float num4 = num2 * 0.5f;
				float num5 = num3 * 0.5f;
				float x = position.x + num4;
				float y = position.y + num5;
				global::UnityEngine.Vector2 vector = default(global::UnityEngine.Vector2);
				vector.x = x;
				vector.y = y;
				global::Unity.Mathematics.float2 float5 = vector;
				throw new global::System.NullReferenceException();
			}
			int num6 = 0;
			global::UnityEngine.Vector2 vector2 = default(global::UnityEngine.Vector2);
			do
			{
				global::UnityEngine.Transform transform2 = base.transform;
				global::UnityEngine.Vector3 position2 = transform2.position;
				global::UnityEngine.Vector2 insideUnitCircle2 = global::UnityEngine.Random.insideUnitCircle;
				float num7 = insideUnitCircle2.x * spawnRadius;
				float num8 = insideUnitCircle2.y * spawnRadius;
				float num9 = num7 * 0.5f;
				float num10 = num8 * 0.5f;
				float x2 = position2.x + num9;
				float y2 = position2.y + num10;
				vector2.x = x2;
				vector2.y = y2;
				array[num6] = vector2;
				num6++;
			}
			while (subSpongeParticleCount != num6);
		}
		nint num11 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v14+30]");
		Sponge sponge = Singleton<FluidSolver>.Instance.AddSponge(array);
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003C9")]
	[global::Cpp2ILInjected.Address(RVA = "0x1017C90", Offset = "0x1017C90", Length = "0x14")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tthis.subSpongeParticleCount = 0x4040000000000007;\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 3 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public SpongeSpawner()
	{
		//IL_0015: Expected I4, but got I8
		subSpongeParticleCount = 7;
	}
}
