[global::Cpp2ILInjected.Token(Token = "0x200005F")]
public class OctopusSpawner : global::UnityEngine.MonoBehaviour
{
	[global::UnityEngine.Range(1f, 4f)]
	[global::Cpp2ILInjected.Token(Token = "0x4000189")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public int tier;

	[global::Cpp2ILInjected.Token(Token = "0x400018A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	private int baseParticleCount;

	[global::Cpp2ILInjected.Token(Token = "0x400018B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public float spawnRadius;

	[global::Cpp2ILInjected.Token(Token = "0x60001EE")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF3720", Offset = "0xFF3720", Length = "0x140")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv22 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv268 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression> + 0xA48;\n\tv24 = *([302A9C5]) & 1;\n\tv25 = v24 == 0;\n\tif (v25) goto L_0059;\n\tv124 = Il2CppMethodInfo + 0xC90;\n\tv28 = *([v22 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A48]);\n\tv269 = *([v28 @ X0_v35+E0]);\n\tv30 = *([v28 @ X0_v35+E0]) == 0;\n\tif (v30) goto L_0063;\nL_0019:\n\tv175 = Singleton`1::get_Instance /* +1 sharing this address */(*([v124 @ X21_v12]));\nL_001D:\n\tv182 = CollectParticleData[];\n\tv183 = Il2CppMethodInfo;\n\tv268 = v175 + 0x90;\n\tv185 = new *([v182 @ X23_v8 (Il2CppClass<CollectParticleData[]>)+990])();\n\tSystem.Action::.ctor(v185, this, *([v183 @ X24_v8 (Il2CppMethodInfo)+270]));\n\tv232 = System.Delegate::Combine(*([v268 @ X20_v3]), v185);\n\tv79 = v232 == 0;\n\tif (v79) goto L_0068;\n\tv32 = *([v232 @ X0_v29 (System.Delegate)]) != *([v182 @ X23_v8 (Il2CppClass<CollectParticleData[]>)+990]);\n\tif (v32) goto L_FFFFFFFF;\n\t*([v268 @ X20_v3]) = v232;\n\tv251 = *([v232 @ X0_v29 (System.Delegate)]) == *([v182 @ X23_v8 (Il2CppClass<CollectParticleData[]>)+990]);\n\tif (v251) goto L_0074;\n\tthrow System.InvalidCastException;\nL_0059:\n\t*([v84 @ X21_v7 (System.Delegate)+9C5]) = 1;\n\tv124 = Il2CppMethodInfo + 0xC90;\n\tv118 = *([v268 @ X20_v3]);\n\tv269 = *([v118 @ X0_v24+E0]);\n\tv239 = *([v118 @ X0_v24+E0]) == 0;\n\tv120 = ~v239;\n\tif (v120) goto L_0019;\nL_0063:\n\tv175 = Singleton`1::get_Instance /* +1 sharing this address */(*([v148 @ X21_v6]));\n\tv208 = v175 == 0;\n\tv177 = ~v208;\n\tif (v177) goto L_001D;\n\tthrow System.NullReferenceException;\nL_0068:\n\t*([v268 @ X20_v3]) = 0;\nL_0074:\n\tv281 = 0xF3F1B4(v268, v269, v262, v260, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100);\n\treturn;\n// 78 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
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
		nint num = (nint)typeof(global::System.Collections.Generic.List<global::UnityEngine.UIElements.StyleSheets.Syntax.Expression>);
		object obj = typeof(global::System.Collections.Generic.List<global::UnityEngine.UIElements.StyleSheets.Syntax.Expression>) + 2632;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302A9C5]");
		int num2 = (int)((nint)0 & (nint)1);
		bool flag = num2 == 0;
		global::System.Delegate obj2 = (global::System.Delegate)50503680;
		global::System.Delegate obj5;
		if (!flag)
		{
			object obj3 = (nint)0 + (nint)3216;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A48]");
			object obj4 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ X0_v35+E0]");
			obj5 = (global::System.Delegate)0;
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
			obj5 = (global::System.Delegate)0;
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
		object obj8 = default(object);
		if (obj8 == null)
		{
			throw new global::System.NullReferenceException();
		}
		goto IL_00c6;
		IL_00c6:
		nint num3 = (nint)typeof(CollectParticleData[]);
		nint num4 = 0;
		obj = (nint)obj8 + 144;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X24_v8 (Il2CppMethodInfo)+270]");
		global::System.Action b = new global::System.Action(this, (global::System.IntPtr)0);
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

	[global::Cpp2ILInjected.Token(Token = "0x60001EF")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF3860", Offset = "0xFF3860", Length = "0x1D0")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv30 = CollectParticleData[];\n\tgoto L_0025;\n\tv35 = Il2CppMethodInfo;\n\tv36 = v35 + 0xC90;\n\tv37 = \"il2cpp_codegen_initialize_runtime_metadata\"(v36, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\tv61 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv62 = v61 + 0xA48;\n\tv63 = \"il2cpp_codegen_initialize_runtime_metadata\"(v62, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\tv78 = CollectParticleData[];\n\tv79 = v78 + 0x718;\n\tv54 = \"il2cpp_codegen_initialize_runtime_metadata\"(v79, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\tv56 = 1;\n\t*([302A9C6]) = v56;\nL_0025:\n\tv60 = 0x274A890(this.tier, methodInfo, v39, v40, v41, v42, v43, v44, 1f, v46, v47, v48, v49, v50, v51, v52);\n\tv77 = 1f != 0x7F800000;\n\tif (v77) goto L_FFFFFFFF;\n\tgoto L_0039;\nL_0039:\n\tv83 = v82 * this.baseParticleCount;\n\tv86 = \"SzArrayNew\"(*([v30 @ X20_v1 (Il2CppClass<CollectParticleData[]>)+718]), v83, v39, v40, v41, v42, v43, v44, 1f, 0x7F800000, v47, v48, v49, v50, v51, v52);\n\tv98 = v83 < 1;\n\tif (v98) goto L_0084;\n\tv99 = v86 == 0;\n\tif (v99) goto L_00A7;\n\tv163 = v86 + 0x24;\nL_0051:\n\tv216 = UnityEngine.Component::get_transform(this);\n\tv271 = UnityEngine.Transform::get_position(v216);\n\tv296 = UnityEngine.Random::get_insideUnitCircle();\n\tv310 = v296 * this.spawnRadius;\n\tv311 = v296.y * this.spawnRadius;\n\tv312 = v310 * 0.5f;\n\tv313 = v311 * 0.5f;\n\tv314 = v271 + v312;\n\tv315 = v271.y + v313;\n\t// 101 MakeStruct v101 @ AGGFF3958_0_v6 (UnityEngine.Vector2), typeof(UnityEngine.Vector2), v314 @ V0_v17 (System.Single), v315 @ V1_v17 (System.Single)\n\tv110 = Unity.Mathematics.float2::op_Implicit(v101);\n\t*([v163 @ X23_v7-4]) = v110;\n\t*([v163 @ X23_v7]) = v110.y;\n\tv165 = v165 + 1;\n\tv163 = v163 + 8;\n\tv120 = v83 != v165;\n\tif (v120) goto L_0051;\nL_0084:\n\tv147 = Il2CppMethodInfo;\n\tgoto L_008D;\n\tv192 = \"il2cpp_codegen_runtime_class_init\"(v149, v111, v39, v40, v41, v42, v43, v44, v109, v137, v107, v48, v49, v50, v51, v52);\nL_008D:\n\tv195 = Singleton`1::get_Instance /* +1 sharing this address */(*([v147 @ X21_v6 (Il2CppMethodInfo)+C90]));\n\tv292 = FluidSolver::AddOctopus(*([v195 @ X0_v16+30]), v86, this.tier);\n\treturn;\n\tthrow System.IndexOutOfRangeException;\nL_00A7:\n\tv265 = UnityEngine.Component::get_transform(this);\n\tv217 = v265 == 0;\n\tv218 = ~v217;\n\tif (v218) goto L_00AD;\n\tv245 = new System.NullReferenceException();\nL_00AD:\n\tv270 = UnityEngine.Transform::get_position(v265);\n\tv277 = UnityEngine.Random::get_insideUnitCircle();\n\tv299 = v277 * this.spawnRadius;\n\tv300 = v277.y * this.spawnRadius;\n\tv302 = v299 * 0.5f;\n\tv303 = v300 * 0.5f;\n\tv304 = v270 + v302;\n\tv305 = v270.y + v303;\n\t// 190 MakeStruct v307 @ AGGFF3A28_0_v1 (UnityEngine.Vector2), typeof(UnityEngine.Vector2), v304 @ V0_v7 (System.Single), v305 @ V1_v7 (System.Single)\n\tv308 = Unity.Mathematics.float2::op_Implicit(v307);\n\tthrow System.NullReferenceException;\n\treturn;\n// 130 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void OnInit()
	{
		//IL_000e: Expected I, but got O
		//IL_01aa: Expected O, but got I
		//IL_005b: Expected O, but got I
		//IL_0136: Expected O, but got F4
		//IL_0153: Expected O, but got I
		nint num = (nint)typeof(CollectParticleData[]);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A890");
		float num2 = ((1f != float.PositiveInfinity) ? 1f : -0f);
		float num3 = num2 * (float)baseParticleCount;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"SzArrayNew\"");
		global::Unity.Mathematics.float2[] array = default(global::Unity.Mathematics.float2[]);
		if (!(num3 < float.Epsilon))
		{
			if (array == null)
			{
				global::UnityEngine.Transform transform = base.transform;
				if ((object)transform == null)
				{
					global::System.NullReferenceException ex = new global::System.NullReferenceException();
					transform = (global::UnityEngine.Transform)(object)ex;
				}
				global::UnityEngine.Vector3 position = transform.position;
				global::UnityEngine.Vector2 insideUnitCircle = global::UnityEngine.Random.insideUnitCircle;
				float num4 = insideUnitCircle.x * spawnRadius;
				float num5 = insideUnitCircle.y * spawnRadius;
				float num6 = num4 * 0.5f;
				float num7 = num5 * 0.5f;
				float x = position.x + num6;
				float y = position.y + num7;
				global::UnityEngine.Vector2 vector = default(global::UnityEngine.Vector2);
				vector.x = x;
				vector.y = y;
				global::Unity.Mathematics.float2 float5 = vector;
				throw new global::System.NullReferenceException();
			}
			object obj = (nint)array + 36;
			int num8 = 0;
			global::UnityEngine.Vector2 vector2 = default(global::UnityEngine.Vector2);
			do
			{
				global::UnityEngine.Transform transform2 = base.transform;
				global::UnityEngine.Vector3 position2 = transform2.position;
				global::UnityEngine.Vector2 insideUnitCircle2 = global::UnityEngine.Random.insideUnitCircle;
				float num9 = insideUnitCircle2.x * spawnRadius;
				float num10 = insideUnitCircle2.y * spawnRadius;
				float num11 = num9 * 0.5f;
				float num12 = num10 * 0.5f;
				float x2 = position2.x + num11;
				float y2 = position2.y + num12;
				vector2.x = x2;
				vector2.y = y2;
				obj = ((global::Unity.Mathematics.float2)vector2).y;
				num8++;
				obj = (nint)obj + 8;
			}
			while (num3 != (float)num8);
		}
		nint num13 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X0_v16+30]");
		Octopus octopus = ((FluidSolver)0).AddOctopus(array, tier);
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001F0")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF3A30", Offset = "0xFF3A30", Length = "0x1C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tthis.tier = 1.0609978957E-313d;\n\tthis.spawnRadius = 3f;\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 4 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public OctopusSpawner()
	{
		//IL_0015: Expected I4, but got F8
		//IL_002a: Expected I4, but got F8
		base._002Ector();
		tier = 0;
		baseParticleCount = 1.0609978957E-313 >> 32;
		spawnRadius = 3f;
	}
}
