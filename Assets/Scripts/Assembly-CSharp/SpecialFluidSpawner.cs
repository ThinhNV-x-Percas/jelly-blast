[global::Cpp2ILInjected.Token(Token = "0x2000064")]
public class SpecialFluidSpawner : global::UnityEngine.MonoBehaviour
{
	[global::Cpp2ILInjected.Token(Token = "0x2000065")]
	public enum SpecialFluidType
	{
		[global::Cpp2ILInjected.Token(Token = "0x40001A7")]
		Mud = 0,
		[global::Cpp2ILInjected.Token(Token = "0x40001A8")]
		Water = 1,
		[global::Cpp2ILInjected.Token(Token = "0x40001A9")]
		Snow = 2
	}

	[global::Cpp2ILInjected.Token(Token = "0x40001A3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public SpecialFluidSpawner.SpecialFluidType type;

	[global::Cpp2ILInjected.Token(Token = "0x40001A4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public int particleCount;

	[global::Cpp2ILInjected.Token(Token = "0x40001A5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public float spawnRadius;

	[global::Cpp2ILInjected.Token(Token = "0x600020B")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF4C74", Offset = "0xFF4C74", Length = "0x140")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv22 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv268 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression> + 0xA48;\n\tv24 = *([302A9D0]) & 1;\n\tv25 = v24 == 0;\n\tif (v25) goto L_0059;\n\tv124 = Il2CppMethodInfo + 0xC90;\n\tv28 = *([v22 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A48]);\n\tv269 = *([v28 @ X0_v35+E0]);\n\tv30 = *([v28 @ X0_v35+E0]) == 0;\n\tif (v30) goto L_0063;\nL_0019:\n\tv175 = Singleton`1::get_Instance /* +1 sharing this address */(*([v124 @ X21_v12]));\nL_001D:\n\tv182 = CollectParticleData[];\n\tv183 = Il2CppMethodInfo;\n\tv268 = v175 + 0x90;\n\tv185 = new *([v182 @ X23_v8 (Il2CppClass<CollectParticleData[]>)+990])();\n\tSystem.Action::.ctor(v185, this, *([v183 @ X24_v8 (Il2CppMethodInfo)+B60]));\n\tv232 = System.Delegate::Combine(*([v268 @ X20_v3]), v185);\n\tv79 = v232 == 0;\n\tif (v79) goto L_0068;\n\tv32 = *([v232 @ X0_v29 (System.Delegate)]) != *([v182 @ X23_v8 (Il2CppClass<CollectParticleData[]>)+990]);\n\tif (v32) goto L_FFFFFFFF;\n\t*([v268 @ X20_v3]) = v232;\n\tv251 = *([v232 @ X0_v29 (System.Delegate)]) == *([v182 @ X23_v8 (Il2CppClass<CollectParticleData[]>)+990]);\n\tif (v251) goto L_0074;\n\tthrow System.InvalidCastException;\nL_0059:\n\t*([v84 @ X21_v7 (System.Delegate)+9D0]) = 1;\n\tv124 = Il2CppMethodInfo + 0xC90;\n\tv118 = *([v268 @ X20_v3]);\n\tv269 = *([v118 @ X0_v24+E0]);\n\tv239 = *([v118 @ X0_v24+E0]) == 0;\n\tv120 = ~v239;\n\tif (v120) goto L_0019;\nL_0063:\n\tv175 = Singleton`1::get_Instance /* +1 sharing this address */(*([v148 @ X21_v6]));\n\tv208 = v175 == 0;\n\tv177 = ~v208;\n\tif (v177) goto L_001D;\n\tthrow System.NullReferenceException;\nL_0068:\n\t*([v268 @ X20_v3]) = 0;\nL_0074:\n\tv281 = 0xF3F1B4(v268, v269, v262, v260, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100);\n\treturn;\n// 78 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
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
		object obj = typeof(global::System.Collections.Generic.List<global::UnityEngine.UIElements.StyleSheets.Syntax.Expression>) + 2632;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302A9D0]");
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
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X24_v8 (Il2CppMethodInfo)+B60]");
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

	[global::Cpp2ILInjected.Token(Token = "0x600020C")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF4DB4", Offset = "0xFF4DB4", Length = "0x274")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv26 = CollectParticleData[];\n\tgoto L_0022;\n\tv31 = Il2CppMethodInfo;\n\tv32 = v31 + 0xC90;\n\tv33 = \"il2cpp_codegen_initialize_runtime_metadata\"(v32, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48);\n\tv56 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv57 = v56 + 0xA48;\n\tv58 = \"il2cpp_codegen_initialize_runtime_metadata\"(v57, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48);\n\tv72 = CollectParticleData[];\n\tv73 = v72 + 0x718;\n\tv50 = \"il2cpp_codegen_initialize_runtime_metadata\"(v73, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48);\n\tv52 = 1;\n\t*([302A9D1]) = v52;\nL_0022:\n\tv55 = \"SzArrayNew\"(*([v26 @ X19_v1 (Il2CppClass<CollectParticleData[]>)+718]), this.particleCount, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48);\n\tv71 = this.particleCount < 1;\n\tif (v71) goto L_006C;\n\tv74 = v55 == 0;\n\tif (v74) goto L_00EF;\n\tv133 = v55 + 0x24;\nL_0038:\n\tv197 = UnityEngine.Component::get_transform(this);\n\tv302 = UnityEngine.Transform::get_position(v197);\n\tv386 = UnityEngine.Random::get_insideUnitCircle();\n\tv397 = v386 * this.spawnRadius;\n\tv398 = v386.y * this.spawnRadius;\n\tv399 = v397 * 0.5f;\n\tv400 = v398 * 0.5f;\n\tv401 = v302 + v399;\n\tv402 = v302.y + v400;\n\t// 76 MakeStruct v76 @ AGGFF4E84_0_v6 (UnityEngine.Vector2), typeof(UnityEngine.Vector2), v401 @ V0_v16 (System.Single), v402 @ V1_v16 (System.Single)\n\tv87 = Unity.Mathematics.float2::op_Implicit(v76);\n\t*([v133 @ X22_v10-4]) = v87;\n\t*([v133 @ X22_v10]) = v87.y;\n\tv158 = v158 + 1;\n\tv133 = v133 + 8;\n\tv95 = v158 < this.particleCount;\n\tif (v95) goto L_0038;\nL_006C:\n\tv121 = this.type == 0;\n\tif (v121) goto L_00A8;\n\tv166 = this.type == 2;\n\tif (v166) goto L_00C7;\n\tv209 = this.type != 1;\n\tif (v209) goto L_00EB;\n\tgoto L_008B;\n\tv309 = \"il2cpp_codegen_runtime_class_init\"(v284, v88, v35, v36, v37, v38, v39, v40, v86, v84, v82, v44, v45, v46, v47, v48);\nL_008B:\n\tv311 = Il2CppMethodInfo;\n\tv241 = Singleton`1::get_Instance /* +1 sharing this address */(*([v311 @ X8_v21 (Il2CppMethodInfo)+C90]));\n\tv361 = FluidSolver::AddWaterParticles(*([v241 @ X0_v28+30]), v55);\n\treturn;\nL_00A8:\n\tgoto L_00AA;\n\tv216 = \"il2cpp_codegen_runtime_class_init\"(v173, v88, v35, v36, v37, v38, v39, v40, v86, v84, v82, v44, v45, v46, v47, v48);\nL_00AA:\n\tv218 = Il2CppMethodInfo;\n\tv221 = Singleton`1::get_Instance /* +1 sharing this address */(*([v218 @ X8_v11 (Il2CppMethodInfo)+C90]));\n\tv362 = FluidSolver::AddMud(*([v221 @ X0_v14+30]), v55);\n\treturn;\nL_00C7:\n\tgoto L_00C9;\n\tv298 = \"il2cpp_codegen_runtime_class_init\"(v212, v88, v35, v36, v37, v38, v39, v40, v86, v84, v82, v44, v45, v46, v47, v48);\nL_00C9:\n\tv300 = Il2CppMethodInfo;\n\tv244 = Singleton`1::get_Instance /* +1 sharing this address */(*([v300 @ X8_v16 (Il2CppMethodInfo)+C90]));\n\tv363 = FluidSolver::AddSnow(*([v244 @ X0_v21+30]), v55);\n\treturn;\nL_00EB:\n\treturn;\n\tthrow System.IndexOutOfRangeException;\nL_00EF:\n\tv276 = UnityEngine.Component::get_transform(this);\n\tv198 = v276 == 0;\n\tv199 = ~v198;\n\tif (v199) goto L_00F5;\n\tv257 = new System.NullReferenceException();\nL_00F5:\n\tv281 = UnityEngine.Transform::get_position(v276);\n\tv308 = UnityEngine.Random::get_insideUnitCircle();\n\tv389 = v308 * this.spawnRadius;\n\tv390 = v308.y * this.spawnRadius;\n\tv391 = v389 * 0.5f;\n\tv392 = v390 * 0.5f;\n\tv393 = v281 + v391;\n\tv394 = v281.y + v392;\n\t// 262 MakeStruct v315 @ AGGFF5020_0_v1 (UnityEngine.Vector2), typeof(UnityEngine.Vector2), v393 @ V0_v6 (System.Single), v394 @ V1_v6 (System.Single)\n\tv338 = Unity.Mathematics.float2::op_Implicit(v315);\n\tthrow System.NullReferenceException;\n\treturn;\n// 188 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void OnInit()
	{
		//IL_000e: Expected I, but got O
		//IL_0218: Expected O, but got I
		//IL_003f: Expected O, but got I
		//IL_024c: Expected O, but got I
		//IL_011a: Expected O, but got F4
		//IL_0137: Expected O, but got I
		//IL_01e4: Expected O, but got I
		nint num = (nint)typeof(CollectParticleData[]);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"SzArrayNew\"");
		global::Unity.Mathematics.float2[] array = default(global::Unity.Mathematics.float2[]);
		if (particleCount >= 1)
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
				float num2 = insideUnitCircle.x * spawnRadius;
				float num3 = insideUnitCircle.y * spawnRadius;
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
			object obj = (nint)array + 36;
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
				obj = ((global::Unity.Mathematics.float2)vector2).y;
				num6++;
				obj = (nint)obj + 8;
			}
			while (num6 < particleCount);
		}
		if (type != SpecialFluidSpawner.SpecialFluidType.Mud)
		{
			if (type != SpecialFluidSpawner.SpecialFluidType.Snow)
			{
				if (type == SpecialFluidSpawner.SpecialFluidType.Water)
				{
					nint num11 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X0_v28+30]");
					Water water = ((FluidSolver)0).AddWaterParticles(array);
				}
			}
			else
			{
				nint num12 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X0_v21+30]");
				Snow snow = ((FluidSolver)0).AddSnow(array);
			}
		}
		else
		{
			nint num13 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X0_v14+30]");
			Mud mud = ((FluidSolver)0).AddMud(array);
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x600020D")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF5650", Offset = "0xFF5650", Length = "0x14")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tthis.particleCount = 0x404000000000001E;\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 3 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public SpecialFluidSpawner()
	{
		//IL_0015: Expected I4, but got I8
		base._002Ector();
		particleCount = 30;
	}
}
