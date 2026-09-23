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
			// The shipped body is `if (m_Instance == null) m_Instance = Resources.Load(...);
			// m_Instance.InitClipData(); return m_Instance;` - the decompiler lost the asset
			// name and left a chain of casts from null that threw InvalidCastException on
			// every call, i.e. on every sound the game tried to play.
			if (m_Instance == null)
			{
				m_Instance = global::UnityEngine.Resources.Load<AudioClipManager>("AudioClipManager");
			}

			if (m_Instance == null)
			{
				return null;
			}

			m_Instance.InitClipData();
			return m_Instance;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000162")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE77A0", Offset = "0xFE77A0", Length = "0x14C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv26 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tgoto L_0026;\n\tv33 = Il2CppMethodInfo;\n\tv34 = v33 + 0x808;\n\tv35 = \"il2cpp_codegen_initialize_runtime_metadata\"(v34, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv57 = Il2CppMethodInfo;\n\tv58 = v57 + 0x810;\n\tv59 = \"il2cpp_codegen_initialize_runtime_metadata\"(v58, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv62 = Il2CppMethodInfo;\n\tv63 = v62 + 0x800;\n\tv64 = \"il2cpp_codegen_initialize_runtime_metadata\"(v63, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv69 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv70 = v69 + 0x590;\n\tv52 = \"il2cpp_codegen_initialize_runtime_metadata\"(v70, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv54 = 1;\n\t*([302A968]) = v54;\nL_0026:\n\tv56 = new *([v26 @ X22_v1 (Il2CppClass<System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>>)+590])();\n\tSystem.Collections.Generic.Dictionary`2<System.String, UnityEngine.AudioClip>::.ctor(v56);\n\tv65 = this + 0x20;\n\tthis.m_ClipData = v56;\n\tv68 = 0xF3F1B4(v65, v56, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv71 = this.clips;\n\tv84 = v71.Length < 1;\n\tif (v84) goto L_007B;\n\tgoto L_0059;\nL_0047:\n\tv97 = v97 + 1;\n\tv159 = v97 >= v71.Length;\n\tif (v159) goto L_007B;\nL_0059:\n\tv131 = UnityEngine.Object::get_name(v71[v97 @ X23_v5 (System.Int32)]);\n\tv227 = System.Collections.Generic.Dictionary`2<System.String, UnityEngine.AudioClip>::ContainsKey(this.m_ClipData, v131);\n\tv229 = v227 == 0;\n\tv230 = ~v229;\n\tif (v230) goto L_0047;\n\tv132 = UnityEngine.Object::get_name(v71[v97 @ X23_v5 (System.Int32)]);\n\tSystem.Collections.Generic.Dictionary`2<System.String, UnityEngine.AudioClip>::Add(this.m_ClipData, v132, v71[v97 @ X23_v5 (System.Int32)]);\n\tgoto L_0047;\nL_007B:\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 87 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void InitClipData()
	{
		//IL_000e: Expected I, but got O
		//IL_012a: Expected O, but got I
		global::System.Collections.Generic.Dictionary<string, global::UnityEngine.AudioClip> clipData = new global::System.Collections.Generic.Dictionary<string, global::UnityEngine.AudioClip>();
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
		bool result2;
		if (id != null)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v5 (Il2CppMethodInfo)+810]");
			if (m_ClipData.ContainsKey(id))
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v7 (Il2CppMethodInfo)+818]");
				global::UnityEngine.AudioClip audioClip = m_ClipData[id];
				result = audioClip;
				result2 = true;
			}
			else
			{
				result2 = false;
			}
		}
		else
		{
			result2 = false;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		return result2;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000164")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE79B4", Offset = "0xFE79B4", Length = "0x8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tUnityEngine.ScriptableObject::.ctor(this);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public AudioClipManager()
	{
	}
}
