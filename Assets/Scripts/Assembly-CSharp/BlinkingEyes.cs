[global::Cpp2ILInjected.Token(Token = "0x2000053")]
public class BlinkingEyes : global::UnityEngine.MonoBehaviour
{
	[global::Cpp2ILInjected.Token(Token = "0x400012B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private float blinkStartTime;

	[global::Cpp2ILInjected.Token(Token = "0x400012C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	private float blinkDuration;

	[global::Cpp2ILInjected.Token(Token = "0x400012D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private float blinkHold;

	[global::Cpp2ILInjected.Token(Token = "0x400012E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	private float blinkPeriod;

	[global::Cpp2ILInjected.Token(Token = "0x400012F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private global::UnityEngine.MeshRenderer mr;

	[global::Cpp2ILInjected.Token(Token = "0x4000130")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	private global::UnityEngine.MaterialPropertyBlock _propBlock;

	[global::Cpp2ILInjected.Token(Token = "0x60001C3")]
	[global::Cpp2ILInjected.Address(RVA = "0xFEE21C", Offset = "0xFEE21C", Length = "0xB0")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv20 = Il2CppMethodInfo;\n\tgoto L_001E;\n\tv25 = Il2CppMethodInfo;\n\tv26 = v25 + 0x6A8;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv51 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv52 = v51 + 0x900;\n\tv44 = \"il2cpp_codegen_initialize_runtime_metadata\"(v52, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv46 = 1;\n\t*([302A99E]) = v46;\nL_001E:\n\tv50 = UnityEngine.Random::Range(0f, this.blinkPeriod);\n\tthis.blinkStartTime = v50;\n\tv54 = new *([v18 @ X20_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+900])();\n\tUnityEngine.MaterialPropertyBlock::.ctor(v54);\n\tv58 = this + 0x38;\n\tthis._propBlock = v54;\n\tv60 = 0xF3F1B4(v58, v54, v29, v30, v31, v32, v33, v34, v50, this.blinkPeriod, v37, v38, v39, v40, v41, v42);\n\tv63 = UnityEngine.Component::GetComponent /* +1 sharing this address */(this, *([v20 @ X21_v1 (Il2CppMethodInfo)+6A8]));\n\tv65 = this + 0x30;\n\tthis.mr = v63;\n\tv73 = 0xF3F1B4(v65, v63, v29, v30, v31, v32, v33, v34, v50, this.blinkPeriod, v37, v38, v39, v40, v41, v42);\n\treturn;\n// 35 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void Start()
	{
		//IL_000e: Expected I, but got O
		//IL_0025: Expected O, but got I
		//IL_0054: Expected O, but got I
		nint num2 = 0;
		float num3 = global::UnityEngine.Random.Range(0f, blinkPeriod);
		blinkStartTime = num3;
		global::UnityEngine.MaterialPropertyBlock propBlock = new global::UnityEngine.MaterialPropertyBlock();
		_propBlock = propBlock;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @111C708 (UnityEngine.Component::GetComponent, and 1 more at this address)");
		global::UnityEngine.MeshRenderer meshRenderer = default(global::UnityEngine.MeshRenderer);
		mr = meshRenderer;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001C4")]
	[global::Cpp2ILInjected.Address(RVA = "0xFEE2CC", Offset = "0xFEE2CC", Length = "0x19C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0016;\n\tv21 = \"Writing object reference to Id '{0}' for {1}.\";\n\tv22 = v21 + 0x970;\n\tv23 = \"il2cpp_codegen_initialize_runtime_metadata\"(v22, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv41 = 1;\n\t*([302A99F]) = v41;\nL_0016:\n\tv44 = this.blinkDuration + this.blinkHold;\n\tv46 = UnityEngine.Time::get_time();\n\tv49 = v46 - this.blinkStartTime;\n\tv50 = 0x274A5CC(0, methodInfo, v25, v26, v27, v28, v29, v30, v49, this.blinkPeriod, this.blinkStartTime, v34, v35, v36, v37, v38);\n\tv51 = v49 / v44;\n\tv62 = v51 >= 0.5f;\n\tif (v62) goto L_006C;\n\tv63 = v51 + v51;\n\tv64 = v63 + v63;\n\tv68 = v64 - 1f;\n\tv69 = v68 < 0;\n\tv76 = v64 + -2f;\n\tv77 = v76 * v76;\n\tv78 = v76 * v77;\n\tv80 = v78 + 2f;\n\tv81 = v80 * 0.5f;\n\tv82 = v64 * 0.5f;\n\tv83 = v64 * v82;\n\tv145 = v64 * v83;\n\tv85 = ~v69;\n\tv86 = ~v85;\n\tif (v86) goto L_0047;\n\tgoto L_0047;\nL_0047:\n\tv147 = 1f - v145;\n\tv156 = v145 - 1f;\n\tv157 = v156 < 0;\n\tv158 = v156 == 0;\n\tv159 = v145 ^ 1f;\n\tv160 = v145 ^ v156;\n\tv161 = v159 & v160;\n\tv162 = v161 < 0;\n\tv164 = v157 == v162;\n\tv165 = ~v158;\n\tv166 = v164 & v165;\n\tv167 = ~v166;\n\tif (v167) goto L_FFFFFFFF;\n\tgoto L_0064;\nL_0064:\n\tv121 = v145 >= 0;\n\tif (v121) goto L_FFFFFFFF;\n\tgoto L_006A;\nL_006A:\n\tgoto L_00C1;\nL_006C:\n\tv88 = this.blinkHold / v44;\n\tv89 = v88 + 0.5f;\n\tv94 = v51 < v89;\n\tif (v94) goto L_00C1;\n\tv103 = v88 + 1f;\n\tv113 = v51 >= v103;\n\tif (v113) goto L_00C1;\n\tv169 = v51 + -0.5f;\n\tv170 = v169 - v88;\n\tv171 = v170 + v170;\n\tv172 = v171 + v171;\n\tv176 = v172 - 1f;\n\tv177 = v176 < 0;\n\tv184 = v172 + -2f;\n\tv185 = v184 * v184;\n\tv186 = v184 * v185;\n\tv188 = v186 + 2f;\n\tv190 = v188 * 0.5f;\n\tv191 = v172 * 0.5f;\n\tv192 = v172 * v191;\n\tv145 = v172 * v192;\n\tv194 = ~v177;\n\tv195 = ~v194;\n\tif (v195) goto L_00AB;\n\tgoto L_00AB;\nL_00AB:\n\tv236 = v145 - 1f;\n\tv234 = v236 < 0;\n\tv232 = v236 == 0;\n\tv230 = v145 ^ 1f;\n\tv228 = v145 ^ v236;\n\tv226 = v230 & v228;\n\tv224 = v226 < 0;\n\tv244 = v234 == v224;\n\tv217 = ~v232;\n\tv222 = v244 & v217;\n\tv220 = ~v222;\n\tif (v220) goto L_FFFFFFFF;\n\tgoto L_FFFFFFFF;\n\tgoto L_0064;\nL_00C1:\n\tUnityEngine.Renderer::GetPropertyBlock(this.mr, this._propBlock);\n\tv245 = \"Writing object reference to Id '{0}' for {1}.\";\n\tUnityEngine.MaterialPropertyBlock::SetFloat(this._propBlock, *([v245 @ X8_v4 (System.String)+970]), v117);\n\tUnityEngine.Renderer::SetPropertyBlock(this.mr, this._propBlock);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 126 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void LateUpdate()
	{
		//IL_0312: Expected O, but got I
		//IL_03e1: Expected O, but got F4
		//IL_03ee: Expected O, but got F4
		//IL_0490: Expected O, but got F4
		//IL_049d: Expected O, but got F4
		float num = blinkDuration + blinkHold;
		float time = global::UnityEngine.Time.time;
		float num2 = time - blinkStartTime;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A5CC");
		float num3 = num2 / num;
		float num14;
		float num15;
		float num18;
		if (num3 < 0.5f)
		{
			float num4 = num3 + num3;
			float num5 = num4 + num4;
			float num6 = num5 - 1f;
			bool flag = num6 < 0f;
			float num7 = num5 + -2f;
			float num8 = num7 * num7;
			float num9 = num7 * num8;
			float num10 = num9 + 2f;
			float num11 = num10 * 0.5f;
			float num12 = num5 * 0.5f;
			float num13 = num5 * num12;
			num14 = num5 * num13;
			if (!flag)
			{
				num14 = num11;
			}
			num15 = 1f - num14;
			float num16 = num14 - 1f;
			bool flag2 = num16 < 0f;
			bool flag3 = num16 == 0f;
			object obj = num14 ^ 1f;
			object obj2 = num14 ^ num16;
			int num17 = (int)((nint)obj & (nint)obj2);
			bool flag4 = num17 < 0;
			bool flag5 = flag2 == flag4;
			bool flag6 = !flag3;
			if (flag5 && flag6)
			{
				num15 = 0f;
				num18 = 1f;
			}
			else
			{
				num18 = 1f;
			}
			goto IL_0508;
		}
		float num19 = blinkHold / num;
		float num20 = num19 + 0.5f;
		bool flag7 = num3 < num20;
		float value = 0f;
		if (!flag7)
		{
			float num21 = num19 + 1f;
			bool flag8 = !(num3 < num21);
			value = 1f;
			if (!flag8)
			{
				float num22 = num3 + -0.5f;
				float num23 = num22 - num19;
				float num24 = num23 + num23;
				float num25 = num24 + num24;
				float num26 = num25 - 1f;
				bool flag9 = num26 < 0f;
				float num27 = num25 + -2f;
				float num28 = num27 * num27;
				float num29 = num27 * num28;
				float num30 = num29 + 2f;
				float num31 = num30 * 0.5f;
				float num32 = num25 * 0.5f;
				float num33 = num25 * num32;
				num14 = num25 * num33;
				if (!flag9)
				{
					num14 = num31;
				}
				float num34 = num14 - 1f;
				bool flag10 = num34 < 0f;
				bool flag11 = num34 == 0f;
				object obj3 = num14 ^ 1f;
				object obj4 = num14 ^ num34;
				int num35 = (int)((nint)obj3 & (nint)obj4);
				bool flag12 = num35 < 0;
				bool flag13 = flag10 == flag12;
				bool flag14 = !flag11;
				num15 = ((!(flag13 && flag14)) ? num14 : 1f);
				num18 = 0f;
				goto IL_0508;
			}
		}
		goto IL_02d8;
		IL_0508:
		value = ((!(num14 < 0f)) ? num15 : num18);
		goto IL_02d8;
		IL_02d8:
		mr.GetPropertyBlock(_propBlock);
		string text = "Writing object reference to Id '{0}' for {1}.";
		global::UnityEngine.MaterialPropertyBlock propBlock = _propBlock;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v4 (System.String)+970]");
		propBlock.SetFloat((string)0, value);
		mr.SetPropertyBlock(_propBlock);
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001C5")]
	[global::Cpp2ILInjected.Address(RVA = "0xFEE468", Offset = "0xFEE468", Length = "0x20")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\t// 2 NotImplemented \"Instruction DUP not yet implemented.\"\n\tthis.blinkDuration = v3;\n\tthis.blinkPeriod = 5f;\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 4 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public BlinkingEyes()
	{
		//IL_001a: Expected F4, but got O
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		object obj = default(object);
		blinkDuration = (float)obj;
		blinkPeriod = 5f;
	}
}
