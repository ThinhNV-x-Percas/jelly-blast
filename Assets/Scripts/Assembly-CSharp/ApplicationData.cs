[global::UnityEngine.CreateAssetMenu(fileName = "ApplicationData", menuName = "Custom/ApplicationData", order = 1)]
[global::Cpp2ILInjected.Token(Token = "0x2000039")]
public class ApplicationData : global::UnityEngine.ScriptableObject
{
	[global::Cpp2ILInjected.Token(Token = "0x40000D9")]
	private const string playerDataFileName = "playerData";

	[global::Cpp2ILInjected.Token(Token = "0x40000DA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public PlayerData playerData;

	[global::Cpp2ILInjected.Token(Token = "0x600014B")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE6730", Offset = "0xFE6730", Length = "0x100")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0027;\n\tv27 = CollectParticleData[];\n\tv28 = v27 + 0xB30;\n\tv29 = \"il2cpp_codegen_initialize_runtime_metadata\"(v28, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\tv55 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv56 = v55 + 0x3D8;\n\tv57 = \"il2cpp_codegen_initialize_runtime_metadata\"(v56, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\tv66 = System.Runtime.Serialization.ObjectHolderList;\n\tv67 = v66 + 0x1F0;\n\tv68 = \"il2cpp_codegen_initialize_runtime_metadata\"(v67, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\tv74 = \"papayawhip\";\n\tv75 = v74 + 0x1A8;\n\tv46 = \"il2cpp_codegen_initialize_runtime_metadata\"(v75, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\tv48 = 1;\n\t*([302A95F]) = v48;\nL_0027:\n\tgoto L_0029;\n\tv58 = \"il2cpp_codegen_runtime_class_init\"(v51, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\nL_0029:\n\tv60 = \"papayawhip\";\n\tv65 = UnityEngine.Application::get_persistentDataPath();\n\tgoto L_0039;\n\tv76 = \"il2cpp_codegen_runtime_class_init\"(v70, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\nL_0039:\n\tv81 = System.IO.Path::Combine(v65, *([v60 @ X23_v1 (System.String)+1A8]));\n\tgoto L_0045;\n\tv88 = \"il2cpp_codegen_runtime_class_init\"(v84, v78, v80, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\nL_0045:\n\tv93 = Newtonsoft.Json.JsonConvert::SerializeObject(this.playerData, 1);\n\tSystem.IO.File::WriteAllText(v81, v93);\n\treturn;\n// 57 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void SavePlayerData()
	{
		//IL_0031: Expected O, but got I
		string text = "papayawhip";
		string persistentDataPath = global::UnityEngine.Application.persistentDataPath;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X23_v1 (System.String)+1A8]");
		string path = global::System.IO.Path.Combine(persistentDataPath, (string)0);
		string contents = global::Newtonsoft.Json.JsonConvert.SerializeObject(playerData, global::Newtonsoft.Json.Formatting.Indented);
		global::System.IO.File.WriteAllText(path, contents);
	}

	[global::Cpp2ILInjected.Token(Token = "0x600014C")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE6830", Offset = "0xFE6830", Length = "0x174")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_002B;\n\tv23 = CollectParticleData[];\n\tv24 = v23 + 0xB30;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv51 = Il2CppMethodInfo;\n\tv52 = v51 + 0x8D8;\n\tv53 = \"il2cpp_codegen_initialize_runtime_metadata\"(v52, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv60 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv61 = v60 + 0x3D8;\n\tv62 = \"il2cpp_codegen_initialize_runtime_metadata\"(v61, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv68 = System.Runtime.Serialization.ObjectHolderList;\n\tv69 = v68 + 0x1F0;\n\tv70 = \"il2cpp_codegen_initialize_runtime_metadata\"(v69, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv77 = System.Runtime.Serialization.ObjectHolderList;\n\tv78 = v77 + 0x2D8;\n\tv79 = \"il2cpp_codegen_initialize_runtime_metadata\"(v78, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv83 = \"papayawhip\";\n\tv84 = v83 + 0x1A8;\n\tv42 = \"il2cpp_codegen_initialize_runtime_metadata\"(v84, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv44 = 1;\n\t*([302A960]) = v44;\nL_002B:\n\tgoto L_002D;\n\tv54 = \"il2cpp_codegen_runtime_class_init\"(v47, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\nL_002D:\n\tv56 = \"papayawhip\";\n\tv59 = UnityEngine.Application::get_persistentDataPath();\n\tgoto L_003B;\n\tv71 = \"il2cpp_codegen_runtime_class_init\"(v64, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\nL_003B:\n\tv76 = System.IO.Path::Combine(v59, *([v56 @ X22_v1 (System.String)+1A8]));\n\tv82 = System.IO.File::Exists(v76);\n\tv85 = ~v82;\n\tif (v85) goto L_005F;\n\tv88 = Il2CppMethodInfo;\n\tv92 = System.IO.File::ReadAllText(v76);\n\tgoto L_0051;\n\tv105 = \"il2cpp_codegen_runtime_class_init\"(v98, v91, v75, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\nL_0051:\n\tv109 = Newtonsoft.Json.JsonConvert::DeserializeObject /* +1 sharing this address */(v92, *([v88 @ X21_v5 (Il2CppMethodInfo)+8D8]));\n\tv115 = this + 0x18;\n\tthis.playerData = v109;\n\tv123 = 0xF3F1B4(v115, v109, 0, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\treturn;\nL_005F:\n\tv93 = System.Runtime.Serialization.ObjectHolderList;\n\tv96 = new *([v93 @ X8_v5 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+2D8])();\n\t*([v96 @ X0_v12 (System.Object)+10]) = 0x101;\n\tSystem.Object::.ctor(v96);\n\tv111 = this + 0x18;\n\tthis.playerData = v96;\n\tv113 = 0xF3F1B4(v111, v96, 0, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tApplicationData::SavePlayerData(this);\n\treturn;\n// 70 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void LoadPlayerData()
	{
		//IL_0031: Expected O, but got I
		//IL_00b6: Expected I, but got O
		//IL_00d7: Expected O, but got I
		//IL_008e: Expected O, but got I
		string text = "papayawhip";
		string persistentDataPath = global::UnityEngine.Application.persistentDataPath;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X22_v1 (System.String)+1A8]");
		string path = global::System.IO.Path.Combine(persistentDataPath, (string)0);
		if (global::System.IO.File.Exists(path))
		{
			nint num = 0;
			string text2 = global::System.IO.File.ReadAllText(path);
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1151500 (Newtonsoft.Json.JsonConvert::DeserializeObject, and 1 more at this address)");
			object obj = (nint)this + 24;
			PlayerData playerData = default(PlayerData);
			this.playerData = playerData;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		}
		else
		{
			nint num2 = (nint)typeof(global::System.Runtime.Serialization.ObjectHolderList);
			object obj2 = new object();
			_ = 257;
			object obj3 = (nint)this + 24;
			this.playerData = (PlayerData)obj2;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
			SavePlayerData();
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x600014D")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE69B4", Offset = "0xFE69B4", Length = "0x110")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0025;\n\tv23 = CollectParticleData[];\n\tv24 = v23 + 0xB30;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv51 = System.Runtime.Serialization.ObjectHolderList;\n\tv52 = v51 + 0x1F0;\n\tv53 = \"il2cpp_codegen_initialize_runtime_metadata\"(v52, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv60 = System.Runtime.Serialization.ObjectHolderList;\n\tv61 = v60 + 0x2D8;\n\tv62 = \"il2cpp_codegen_initialize_runtime_metadata\"(v61, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv68 = \"papayawhip\";\n\tv69 = v68 + 0x1A8;\n\tv42 = \"il2cpp_codegen_initialize_runtime_metadata\"(v69, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv44 = 1;\n\t*([302A961]) = v44;\nL_0025:\n\tgoto L_0027;\n\tv54 = \"il2cpp_codegen_runtime_class_init\"(v47, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\nL_0027:\n\tv56 = \"papayawhip\";\n\tv59 = UnityEngine.Application::get_persistentDataPath();\n\tgoto L_0032;\n\tv70 = \"il2cpp_codegen_runtime_class_init\"(v64, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\nL_0032:\n\tv72 = System.Runtime.Serialization.ObjectHolderList;\n\tv77 = System.IO.Path::Combine(v59, *([v56 @ X22_v1 (System.String)+1A8]));\n\tv80 = System.IO.File::Exists(v77);\n\tv81 = ~v80;\n\tif (v81) goto L_0041;\n\tSystem.IO.File::Delete(v77);\nL_0041:\n\tv87 = new *([v72 @ X21_v4 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+2D8])();\n\t*([v87 @ X0_v13 (System.Object)+10]) = 0x101;\n\tSystem.Object::.ctor(v87);\n\tv92 = this + 0x18;\n\tthis.playerData = v87;\n\tv94 = 0xF3F1B4(v92, v87, 0, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tApplicationData::SavePlayerData(this);\n\treturn;\n// 51 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void ClearPlayerData()
	{
		//IL_002a: Expected I, but got O
		//IL_003f: Expected O, but got I
		//IL_009d: Expected O, but got I
		string text = "papayawhip";
		string persistentDataPath = global::UnityEngine.Application.persistentDataPath;
		nint num = (nint)typeof(global::System.Runtime.Serialization.ObjectHolderList);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X22_v1 (System.String)+1A8]");
		string path = global::System.IO.Path.Combine(persistentDataPath, (string)0);
		if (global::System.IO.File.Exists(path))
		{
			global::System.IO.File.Delete(path);
		}
		object obj = new object();
		_ = 257;
		object obj2 = (nint)this + 24;
		playerData = (PlayerData)obj;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		SavePlayerData();
	}

	[global::Cpp2ILInjected.Token(Token = "0x600014E")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE6AC4", Offset = "0xFE6AC4", Length = "0x8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tUnityEngine.ScriptableObject::.ctor(this);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public ApplicationData()
	{
	}
}
