[global::UnityEngine.CreateAssetMenu(fileName = "AudioClipManager", menuName = "Custom/AudioClipManager", order = 1)]
[global::Cpp2ILInjected.Token(Token = "0x200003D")]
public class AudioClipManager : global::UnityEngine.ScriptableObject
{
	[global::Cpp2ILInjected.Token(Token = "0x40000E9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public global::UnityEngine.AudioClip[] clips;

	[global::Cpp2ILInjected.Token(Token = "0x40000EA")]
	private static AudioClipManager m_Instance;

	[global::Cpp2ILInjected.Token(Token = "0x40000EB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public global::System.Collections.Generic.Dictionary<string, global::UnityEngine.AudioClip> m_ClipData;

	[global::Cpp2ILInjected.Token(Token = "0x1700000F")]
	public static AudioClipManager Instance
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000161")]
		[global::Cpp2ILInjected.Address(RVA = "0xFE7664", Offset = "0xFE7664", Length = "0x13C")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv14 = 0x302A000;\n\tv16 = CollectParticleData[];\n\tv18 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv20 = *([302A967]) & 1;\n\tv21 = v20 == 0;\n\tif (v21) goto L_003D;\n\tv22 = *([v16 @ X20_v1 (Il2CppClass<CollectParticleData[]>)+CF0]);\n\tv23 = *([v22 @ X8_v25+B8]);\n\tv52 = *([v23 @ X8_v26]);\n\tv25 = *([v18 @ X21_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv27 = *([v25 @ X0_v33+E0]) == 0;\n\tif (v27) goto L_004A;\nL_001B:\n\tv57 = UnityEngine.Object::op_Equality(v52, 0);\n\tv66 = ~v57;\n\tv67 = ~v66;\n\tif (v67) goto L_004D;\nL_001F:\n\tv82 = *([v16 @ X20_v1 (Il2CppClass<CollectParticleData[]>)+CF0]);\n\tv83 = *([v82 @ X8_v22+B8]);\n\tv105 = *([v83 @ X8_v23]);\nL_0024:\n\tAudioClipManager::InitClipData(v105);\n\tv128 = *([v16 @ X20_v1 (Il2CppClass<CollectParticleData[]>)+CF0]);\n\tv129 = *([v128 @ X8_v19+B8]);\n\treturn *([v129 @ X8_v20]);\nL_003D:\n\t*([v14 @ X19_v1+967]) = 1;\n\tv125 = *([v16 @ X20_v1 (Il2CppClass<CollectParticleData[]>)+CF0]);\n\tv126 = *([v125 @ X8_v15+B8]);\n\tv52 = *([v126 @ X8_v16]);\n\tv47 = *([v18 @ X21_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv127 = *([v47 @ X0_v25+E0]) == 0;\n\tv49 = ~v127;\n\tif (v49) goto L_001B;\nL_004A:\n\tv71 = UnityEngine.Object::op_Equality(v61, 0);\n\tv79 = ~v71;\n\tif (v79) goto L_001F;\nL_004D:\n\tv92 = \"Argument must be of type {0}.\";\n\tv95 = Il2CppMethodInfo;\n\tv98 = UnityEngine.Resources::Load /* +1 sharing this address */(*([v92 @ X8_v4 (System.String)+348]), *([v95 @ X8_v6 (Il2CppMethodInfo)+EA8]));\n\tv119 = *([v16 @ X20_v1 (Il2CppClass<CollectParticleData[]>)+CF0]);\n\tv120 = *([v119 @ X8_v8+B8]);\n\t*([v120 @ X8_v9]) = v98;\n\tv121 = *([v16 @ X20_v1 (Il2CppClass<CollectParticleData[]>)+CF0]);\n\tv123 = 0xF3F1B4(*([v121 @ X8_v10+B8]), v98, v86, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tv137 = *([v16 @ X20_v1 (Il2CppClass<CollectParticleData[]>)+CF0]);\n\tv110 = *([v137 @ X8_v11+B8]);\n\tv105 = *([v110 @ X8_v12]);\n\tv138 = *([v110 @ X8_v12]) == 0;\n\tv108 = ~v138;\n\tif (v108) goto L_0024;\n\treturnVal2 = new System.NullReferenceException();\n\treturn returnVal2;\n// 49 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0017: Expected I, but got O
			//IL_0025: Expected I, but got O
			//IL_016a: Expected O, but got I
			//IL_017a: Expected O, but got I
			//IL_0192: Expected O, but got I
			//IL_00eb: Expected O, but got I4
			//IL_0068: Expected O, but got I
			//IL_0078: Expected O, but got I
			//IL_0090: Expected O, but got I
			//IL_0229: Expected O, but got I
			//IL_0239: Expected O, but got I
			//IL_0251: Expected O, but got I
			//IL_0270: Expected O, but got I
			//IL_0280: Expected O, but got I
			//IL_0109: Expected O, but got I
			//IL_0119: Expected O, but got I
			//IL_01f2: Expected O, but got I4
			//IL_013f: Expected O, but got I
			//IL_014f: Expected O, but got I
			object obj = 50503680;
			nint num = (nint)typeof(CollectParticleData[]);
			nint num2 = (nint)typeof(global::Facebook.Unity.Windows.IWindowsFacebook);
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302A967]");
			global::UnityEngine.Object obj4;
			global::UnityEngine.Object obj6;
			if ((uint)((nuint)0u & (nuint)1u) != 0)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X20_v1 (Il2CppClass<CollectParticleData[]>)+CF0]");
				object obj2 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X8_v25+B8]");
				object obj3 = 0;
				obj4 = (global::UnityEngine.Object)obj3;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X21_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]");
				object obj5 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X0_v33+E0]");
				bool flag = (nint)0 == 0;
				obj6 = (global::UnityEngine.Object)obj3;
				if (!flag)
				{
					goto IL_00bd;
				}
			}
			else
			{
				_ = 1;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X20_v1 (Il2CppClass<CollectParticleData[]>)+CF0]");
				object obj7 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v15+B8]");
				object obj8 = 0;
				obj4 = (global::UnityEngine.Object)obj8;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X21_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]");
				object obj9 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v25+E0]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				obj6 = (global::UnityEngine.Object)obj8;
				if (flag3)
				{
					goto IL_00bd;
				}
			}
			bool flag4 = obj6 == null;
			bool flag5 = !flag4;
			object obj10 = 0;
			if (flag5)
			{
				goto IL_00f9;
			}
			goto IL_0200;
			IL_00f9:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X20_v1 (Il2CppClass<CollectParticleData[]>)+CF0]");
			object obj11 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v22+B8]");
			object obj12 = 0;
			AudioClipManager audioClipManager = (AudioClipManager)obj12;
			goto IL_0126;
			IL_0126:
			audioClipManager.InitClipData();
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X20_v1 (Il2CppClass<CollectParticleData[]>)+CF0]");
			object obj13 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v19+B8]");
			return (AudioClipManager)0;
			IL_0200:
			string text = "Argument must be of type {0}.";
			nint num3 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @118E120 (UnityEngine.Resources::Load, and 1 more at this address)");
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X20_v1 (Il2CppClass<CollectParticleData[]>)+CF0]");
			object obj14 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v8+B8]");
			object obj15 = 0;
			global::UnityEngine.Object obj16 = default(global::UnityEngine.Object);
			obj15 = obj16;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X20_v1 (Il2CppClass<CollectParticleData[]>)+CF0]");
			object obj17 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X20_v1 (Il2CppClass<CollectParticleData[]>)+CF0]");
			object obj18 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v11+B8]");
			object obj19 = 0;
			audioClipManager = (AudioClipManager)obj19;
			if (obj19 == null)
			{
				return (AudioClipManager)(object)new global::System.NullReferenceException();
			}
			goto IL_0126;
			IL_00bd:
			bool flag6 = obj4 == null;
			bool flag7 = !flag6;
			bool flag8 = !flag7;
			obj10 = 0;
			if (!flag8)
			{
				goto IL_00f9;
			}
			goto IL_0200;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000162")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE77A0", Offset = "0xFE77A0", Length = "0x14C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv26 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tgoto L_0026;\n\tv33 = Il2CppMethodInfo;\n\tv34 = v33 + 0x808;\n\tv35 = \"il2cpp_codegen_initialize_runtime_metadata\"(v34, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv57 = Il2CppMethodInfo;\n\tv58 = v57 + 0x810;\n\tv59 = \"il2cpp_codegen_initialize_runtime_metadata\"(v58, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv62 = Il2CppMethodInfo;\n\tv63 = v62 + 0x800;\n\tv64 = \"il2cpp_codegen_initialize_runtime_metadata\"(v63, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv69 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv70 = v69 + 0x590;\n\tv52 = \"il2cpp_codegen_initialize_runtime_metadata\"(v70, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv54 = 1;\n\t*([302A968]) = v54;\nL_0026:\n\tv56 = new *([v26 @ X22_v1 (Il2CppClass<System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>>)+590])();\n\tSystem.Collections.Generic.Dictionary`2<System.String, UnityEngine.AudioClip>::.ctor(v56);\n\tv65 = this + 0x20;\n\tthis.m_ClipData = v56;\n\tv68 = 0xF3F1B4(v65, v56, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv71 = this.clips;\n\tv84 = v71.Length < 1;\n\tif (v84) goto L_007B;\n\tgoto L_0059;\nL_0047:\n\tv97 = v97 + 1;\n\tv159 = v97 >= v71.Length;\n\tif (v159) goto L_007B;\nL_0059:\n\tv131 = UnityEngine.Object::get_name(v71[v97 @ X23_v5 (System.Int32)]);\n\tv227 = System.Collections.Generic.Dictionary`2<System.String, UnityEngine.AudioClip>::ContainsKey(this.m_ClipData, v131);\n\tv229 = v227 == 0;\n\tv230 = ~v229;\n\tif (v230) goto L_0047;\n\tv132 = UnityEngine.Object::get_name(v71[v97 @ X23_v5 (System.Int32)]);\n\tSystem.Collections.Generic.Dictionary`2<System.String, UnityEngine.AudioClip>::Add(this.m_ClipData, v132, v71[v97 @ X23_v5 (System.Int32)]);\n\tgoto L_0047;\nL_007B:\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 87 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void InitClipData()
	{
		//IL_000e: Expected I, but got O
		//IL_012a: Expected O, but got I
		nint num = (nint)typeof(global::System.Linq.Expressions.Interpreter.CastInstruction.CastInstructionT<char>);
		global::System.Collections.Generic.Dictionary<string, global::UnityEngine.AudioClip> clipData = new global::System.Collections.Generic.Dictionary<string, global::UnityEngine.AudioClip>();
		object obj = (nint)this + 32;
		m_ClipData = clipData;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		global::UnityEngine.AudioClip[] array = clips;
		if (array.Length < 1)
		{
			return;
		}
		int num2 = 0;
		do
		{
			string key = array[num2].name;
			if (!m_ClipData.ContainsKey(key))
			{
				string key2 = array[num2].name;
				m_ClipData.Add(key2, array[num2]);
			}
			num2++;
		}
		while (num2 < array.Length);
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000163")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE78EC", Offset = "0xFE78EC", Length = "0xC8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0019;\n\tv25 = Il2CppMethodInfo;\n\tv26 = v25 + 0x810;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, id, result, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv46 = Il2CppMethodInfo;\n\tv47 = v46 + 0x818;\n\tv42 = \"il2cpp_codegen_initialize_runtime_metadata\"(v47, id, result, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv44 = 1;\n\t*([302A969]) = v44;\nL_0019:\n\tv45 = id == 0;\n\tif (v45) goto L_FFFFFFFF;\n\tv51 = Il2CppMethodInfo;\n\tv67 = *([v51 @ X8_v5 (Il2CppMethodInfo)+810]);\n\tv55 = System.Collections.Generic.Dictionary`2<System.String, UnityEngine.AudioClip>::ContainsKey(this.m_ClipData, id);\n\tv72 = ~v55;\n\tif (v72) goto L_FFFFFFFF;\n\tv98 = Il2CppMethodInfo;\n\tv67 = *([v98 @ X8_v7 (Il2CppMethodInfo)+818]);\n\tv70 = System.Collections.Generic.Dictionary`2<System.String, UnityEngine.AudioClip>::get_Item(this.m_ClipData, id);\n\tgoto L_0034;\n\tgoto L_0034;\nL_0034:\n\t*([result @ X2 (UnityEngine.AudioClip&)]) = v64;\n\tv79 = 0xF3F1B4(result, v64, v67, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\treturn v75;\n\treturnVal1 = new System.NullReferenceException();\n\treturn returnVal1;\n// 40 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public unsafe bool GetAudioClip(string id, out global::UnityEngine.AudioClip result)
	{
		//IL_00ed: Expected I4, but got O
		//IL_008b: Expected O, but got I4
		result = null;
		global::UnityEngine.AudioClip audioClip2;
		string text;
		if (id != null)
		{
			nint num = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v5 (Il2CppMethodInfo)+810]");
			ref global::UnityEngine.AudioClip reference = ref *(global::UnityEngine.AudioClip*)null;
			if (m_ClipData.ContainsKey(id))
			{
				nint num2 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v7 (Il2CppMethodInfo)+818]");
				reference = ref *(global::UnityEngine.AudioClip*)null;
				global::UnityEngine.AudioClip audioClip = m_ClipData[id];
				audioClip2 = audioClip;
				text = (string)1;
			}
			else
			{
				audioClip2 = null;
				text = null;
			}
		}
		else
		{
			audioClip2 = null;
			ref global::UnityEngine.AudioClip reference = ref result;
			text = id;
		}
		ref global::UnityEngine.AudioClip reference2 = ref *(global::UnityEngine.AudioClip*)audioClip2;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		return (byte)(int)text != 0;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000164")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE79B4", Offset = "0xFE79B4", Length = "0x8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tUnityEngine.ScriptableObject::.ctor(this);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public AudioClipManager()
	{
	}
}
