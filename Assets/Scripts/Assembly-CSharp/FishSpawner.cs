[global::Cpp2ILInjected.Token(Token = "0x2000038")]
public class FishSpawner : global::UnityEngine.MonoBehaviour
{
	[global::UnityEngine.SerializeField]
	[global::Cpp2ILInjected.Token(Token = "0x40000D8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private int fishCount;

	[global::Cpp2ILInjected.Token(Token = "0x6000148")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE6508", Offset = "0xFE6508", Length = "0x140")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv22 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv268 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression> + 0xA48;\n\tv24 = *([302A95D]) & 1;\n\tv25 = v24 == 0;\n\tif (v25) goto L_0059;\n\tv124 = Il2CppMethodInfo + 0xC90;\n\tv28 = *([v22 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A48]);\n\tv269 = *([v28 @ X0_v35+E0]);\n\tv30 = *([v28 @ X0_v35+E0]) == 0;\n\tif (v30) goto L_0063;\nL_0019:\n\tv175 = Singleton`1::get_Instance /* +1 sharing this address */(*([v124 @ X21_v12]));\nL_001D:\n\tv182 = CollectParticleData[];\n\tv183 = Il2CppMethodInfo;\n\tv268 = v175 + 0x90;\n\tv185 = new *([v182 @ X23_v8 (Il2CppClass<CollectParticleData[]>)+990])();\n\tSystem.Action::.ctor(v185, this, *([v183 @ X24_v8 (Il2CppMethodInfo)+530]));\n\tv232 = System.Delegate::Combine(*([v268 @ X20_v3]), v185);\n\tv79 = v232 == 0;\n\tif (v79) goto L_0068;\n\tv32 = *([v232 @ X0_v29 (System.Delegate)]) != *([v182 @ X23_v8 (Il2CppClass<CollectParticleData[]>)+990]);\n\tif (v32) goto L_FFFFFFFF;\n\t*([v268 @ X20_v3]) = v232;\n\tv251 = *([v232 @ X0_v29 (System.Delegate)]) == *([v182 @ X23_v8 (Il2CppClass<CollectParticleData[]>)+990]);\n\tif (v251) goto L_0074;\n\tthrow System.InvalidCastException;\nL_0059:\n\t*([v84 @ X21_v7 (System.Delegate)+95D]) = 1;\n\tv124 = Il2CppMethodInfo + 0xC90;\n\tv118 = *([v268 @ X20_v3]);\n\tv269 = *([v118 @ X0_v24+E0]);\n\tv239 = *([v118 @ X0_v24+E0]) == 0;\n\tv120 = ~v239;\n\tif (v120) goto L_0019;\nL_0063:\n\tv175 = Singleton`1::get_Instance /* +1 sharing this address */(*([v148 @ X21_v6]));\n\tv208 = v175 == 0;\n\tv177 = ~v208;\n\tif (v177) goto L_001D;\n\tthrow System.NullReferenceException;\nL_0068:\n\t*([v268 @ X20_v3]) = 0;\nL_0074:\n\tv281 = 0xF3F1B4(v268, v269, v262, v260, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100);\n\treturn;\n// 78 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
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
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302A95D]");
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
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X24_v8 (Il2CppMethodInfo)+530]");
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

	[global::Cpp2ILInjected.Token(Token = "0x6000149")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE6648", Offset = "0xFE6648", Length = "0xD8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0024;\n\tv25 = Il2CppMethodInfo;\n\tv26 = v25 + 0xC90;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv59 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv60 = v59 + 0xA48;\n\tv44 = \"il2cpp_codegen_initialize_runtime_metadata\"(v60, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv46 = 1;\n\t*([302A95E]) = v46;\nL_0024:\n\tv58 = this.fishCount < 1;\n\tif (v58) goto L_005D;\n\tv64 = Il2CppMethodInfo;\nL_002F:\n\tgoto L_0032;\n\tv174 = \"il2cpp_codegen_runtime_class_init\"(v137, v131, v127, v30, v31, v32, v33, v34, v130, v129, v128, v38, v39, v40, v41, v42);\nL_0032:\n\tv177 = Singleton`1::get_Instance /* +1 sharing this address */(*([v64 @ X23_v3 (Il2CppMethodInfo)+C90]));\n\tv181 = UnityEngine.Component::get_transform(this);\n\tv94 = UnityEngine.Transform::get_position(v181);\n\t// 68 MakeStruct v85 @ AGGFE66F4_1_v3 (UnityEngine.Vector2), typeof(UnityEngine.Vector2), v94 @ V0_v4 (UnityEngine.Vector3), v94.y (System.Single)\n\tv102 = FluidSolver::AddFish(*([v177 @ X0_v7+30]), v85, 0);\n\tv132 = v132 + 1;\n\tv67 = v132 < this.fishCount;\n\tif (v67) goto L_002F;\nL_005D:\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 71 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void SpawnFish()
	{
		//IL_0087: Expected O, but got I
		if (fishCount >= 1)
		{
			nint num = 0;
			int num2 = 0;
			global::UnityEngine.Vector2 pos = default(global::UnityEngine.Vector2);
			do
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
				global::UnityEngine.Transform transform = base.transform;
				global::UnityEngine.Vector3 position = transform.position;
				pos.x = position.x;
				pos.y = position.y;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v7+30]");
				Fish fish = Singleton<FluidSolver>.Instance.AddFish(pos);
				num2++;
			}
			while (num2 < fishCount);
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x600014A")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE6720", Offset = "0xFE6720", Length = "0x10")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tthis.fishCount = 1;\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 2 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public FishSpawner()
	{
		fishCount = 1;
	}
}
