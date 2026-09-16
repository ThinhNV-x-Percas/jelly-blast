[global::Cpp2ILInjected.Token(Token = "0x2000036")]
public class Loader : Singleton<Loader>, global::GameAnalyticsSDK.IGameAnalyticsATTListener
{
	[global::Cpp2ILInjected.Token(Token = "0x600013D")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE6048", Offset = "0xFE6048", Length = "0xA4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv16 = 0x302A000;\n\tv18 = CollectParticleData[];\n\tv20 = *([302A95A]) & 1;\n\tv21 = v20 == 0;\n\tif (v21) goto L_0030;\n\tv22 = *([v18 @ X21_v1 (Il2CppClass<CollectParticleData[]>)+B30]);\n\tv24 = *([v22 @ X0_v16+E0]) == 0;\n\tif (v24) goto L_0038;\nL_0015:\n\tv50 = UnityEngine.Application::get_platform();\n\tv66 = v50 != 8;\n\tif (v66) goto L_004B;\nL_002A:\n\tGameAnalyticsSDK.GameAnalytics::RequestTrackingAuthorization(this);\n\treturn;\nL_0030:\n\t*([v16 @ X20_v1+95A]) = 1;\n\tv44 = *([v18 @ X21_v1 (Il2CppClass<CollectParticleData[]>)+B30]);\n\tv56 = *([v44 @ X0_v10+E0]) == 0;\n\tv46 = ~v56;\n\tif (v46) goto L_0015;\nL_0038:\n\tv68 = UnityEngine.Application::get_platform();\n\tv80 = v68 == 8;\n\tif (v80) goto L_002A;\nL_004B:\n\tLoader::InitAnalytics(this);\n\treturn;\n// 54 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void Start()
	{
		//IL_0009: Expected O, but got I4
		//IL_0017: Expected I, but got O
		//IL_00c5: Expected O, but got I
		//IL_005a: Expected O, but got I
		object obj = 50503680;
		nint num = (nint)typeof(CollectParticleData[]);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302A95A]");
		if ((uint)((nuint)0u & (nuint)1u) != 0)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X21_v1 (Il2CppClass<CollectParticleData[]>)+B30]");
			object obj2 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X0_v16+E0]");
			if ((nint)0 != 0)
			{
				goto IL_007f;
			}
		}
		else
		{
			_ = 1;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X21_v1 (Il2CppClass<CollectParticleData[]>)+B30]");
			object obj3 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v10+E0]");
			if ((nint)0 != 0)
			{
				goto IL_007f;
			}
		}
		global::UnityEngine.RuntimePlatform platform = global::UnityEngine.Application.platform;
		if (platform == global::UnityEngine.RuntimePlatform.IPhonePlayer)
		{
			goto IL_00a8;
		}
		goto IL_0120;
		IL_00a8:
		global::GameAnalyticsSDK.GameAnalytics.RequestTrackingAuthorization(this);
		return;
		IL_0120:
		InitAnalytics();
		return;
		IL_007f:
		global::UnityEngine.RuntimePlatform platform2 = global::UnityEngine.Application.platform;
		if (platform2 == global::UnityEngine.RuntimePlatform.IPhonePlayer)
		{
			goto IL_00a8;
		}
		goto IL_0120;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600013E")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE6348", Offset = "0xFE6348", Length = "0x4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tLoader::InitAnalytics(this);\n\treturn;\n")]
	public void GameAnalyticsATTListenerAuthorized()
	{
		InitAnalytics();
	}

	[global::Cpp2ILInjected.Token(Token = "0x600013F")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE634C", Offset = "0xFE634C", Length = "0x4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tLoader::InitAnalytics(this);\n\treturn;\n")]
	public void GameAnalyticsATTListenerDenied()
	{
		InitAnalytics();
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000140")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE6350", Offset = "0xFE6350", Length = "0x4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tLoader::InitAnalytics(this);\n\treturn;\n")]
	public void GameAnalyticsATTListenerNotDetermined()
	{
		InitAnalytics();
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000141")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE6354", Offset = "0xFE6354", Length = "0x4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tLoader::InitAnalytics(this);\n\treturn;\n")]
	public void GameAnalyticsATTListenerRestricted()
	{
		InitAnalytics();
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000142")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE60EC", Offset = "0xFE60EC", Length = "0x25C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_002A;\n\tv27 = CollectParticleData[];\n\tv28 = v27 + 0xB30;\n\tv29 = \"il2cpp_codegen_initialize_runtime_metadata\"(v28, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\tv52 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv53 = v52 + 0x1F0;\n\tv54 = \"il2cpp_codegen_initialize_runtime_metadata\"(v53, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\tv59 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv60 = v59 + 0x720;\n\tv61 = \"il2cpp_codegen_initialize_runtime_metadata\"(v60, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\tv66 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv67 = v66 + 0x118;\n\tv68 = \"il2cpp_codegen_initialize_runtime_metadata\"(v67, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\tv70 = Il2CppMethodInfo;\n\tv71 = v70 + 0x98;\n\tv72 = \"il2cpp_codegen_initialize_runtime_metadata\"(v71, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\tv76 = Il2CppMethodInfo;\n\tv77 = v76 + 0x198;\n\tv78 = \"il2cpp_codegen_initialize_runtime_metadata\"(v77, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\tv82 = TMPro.KerningTable+<>c__DisplayClass3_0;\n\tv83 = v82 + 0x1E0;\n\tv46 = \"il2cpp_codegen_initialize_runtime_metadata\"(v83, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\tv48 = 1;\n\t*([302A9AB]) = v48;\nL_002A:\n\tv49 = UnityEngine.UIElements.EnumFieldHelpers;\n\tGameAnalyticsSDK.GameAnalytics::Initialize();\n\tgoto L_0035;\n\tv62 = \"il2cpp_codegen_runtime_class_init\"(v55, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\nL_0035:\n\tv65 = UnityEngine.Application::get_version();\n\tGameAnalyticsSDK.GameAnalytics::SetBuildAllPlatforms(v65);\n\tv73 = *([v49 @ X22_v1 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]);\n\tv75 = *([v73 @ X0_v7+E0]) == 0;\n\tif (v75) goto L_0070;\n\tv80 = Facebook.Unity.FB::get_IsInitialized();\n\tv85 = v80 == 0;\n\tif (v85) goto L_0075;\nL_0045:\n\tgoto L_0048;\n\tv103 = \"il2cpp_codegen_runtime_class_init\"(v91, v69, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\nL_0048:\n\tFacebook.Unity.FB::ActivateApp();\n\tgoto L_0059;\n\tv124 = System.Runtime.Serialization.ObjectHolderList;\n\tv125 = v124 + 0xDA0;\n\tv126 = \"il2cpp_codegen_initialize_runtime_metadata\"(v125, v69, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\tv141 = \"IsCyrillic\";\n\tv142 = v141 + 0xBF8;\n\tv128 = \"il2cpp_codegen_initialize_runtime_metadata\"(v142, v69, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\tv130 = 1;\n\t*([302A9AC]) = v130;\nL_0059:\n\tv131 = \"IsCyrillic\";\n\tgoto L_006C;\n\tv143 = \"il2cpp_codegen_runtime_class_init\"(v133, v69, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\nL_006C:\n\tUnityEngine.SceneManagement.SceneManager::LoadScene(*([v131 @ X20_v6 (System.String)+BF8]));\n\treturn;\nL_0070:\n\tv87 = Facebook.Unity.FB::get_IsInitialized();\n\tv102 = v87 == 0;\n\tv90 = ~v102;\n\tif (v90) goto L_0045;\nL_0075:\n\tv97 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv100 = new *([v97 @ X8_v5 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+118])();\n\tv107 = Il2CppMethodInfo;\n\tFacebook.Unity.InitDelegate::.ctor(v100, this, *([v107 @ X8_v7 (Il2CppMethodInfo)+98]));\n\tv119 = TMPro.KerningTable+<>c__DisplayClass3_0;\n\tv121 = *([v119 @ X23_v1 (Il2CppClass<TMPro.KerningTable+<>c__DisplayClass3_0>)+1E0]);\n\tv123 = *([v121 @ X0_v11+E0]) == 0;\n\tif (v123) goto L_00A0;\n\tv217 = *([v121 @ X0_v11+B8]);\n\tv202 = *([v217 @ X8_v11+8]);\n\tv139 = *([v217 @ X8_v11+8]) == 0;\n\tif (v139) goto L_00A9;\nL_008E:\n\tgoto L_009D;\n\tv193 = \"il2cpp_codegen_runtime_class_init\"(v183, v181, v179, v177, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\nL_009D:\n\tFacebook.Unity.FB::Init(v100, v202, 0);\n\treturn;\nL_00A0:\n\tv156 = *([v119 @ X23_v1 (Il2CppClass<TMPro.KerningTable+<>c__DisplayClass3_0>)+1E0]);\n\tv217 = *([v156 @ X0_v22+B8]);\n\tv202 = *([v217 @ X8_v11+8]);\n\tv174 = *([v217 @ X8_v11+8]) == 0;\n\tv158 = ~v174;\n\tif (v158) goto L_008E;\nL_00A9:\n\tgoto L_00AE;\n\tv215 = \"il2cpp_codegen_runtime_class_init\"(v167, v110, v109, v111, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\tv238 = *([v120 @ X23_v2]);\n\tv218 = *([v238 @ X8_v18+B8]);\nL_00AE:\n\tv219 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv222 = new *([v219 @ X8_v12 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+720])();\n\tv239 = Il2CppMethodInfo;\n\tFacebook.Unity.HideUnityDelegate::.ctor(v222, *([v217 @ X8_v11]), *([v239 @ X8_v14 (Il2CppMethodInfo)+198]));\n\tv242 = *([v119 @ X23_v1 (Il2CppClass<TMPro.KerningTable+<>c__DisplayClass3_0>)+1E0]);\n\tv244 = *([v242 @ X8_v16+B8]) + 8;\n\t*([v244 @ X0_v17]) = v222;\n\tv245 = 0xF3F1B4(v244, v222, *([v239 @ X8_v14 (Il2CppMethodInfo)+198]), 0, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\tgoto L_009D;\n\tgoto L_FFFFFFFF;\n\treturn;\n// 104 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void InitAnalytics()
	{
		//IL_021a: Expected I, but got O
		//IL_002c: Expected O, but got I
		//IL_00dc: Expected I, but got O
		//IL_010c: Expected I, but got O
		//IL_011c: Expected O, but got I
		//IL_01aa: Expected O, but got I
		//IL_01ba: Expected O, but got I
		//IL_01ca: Expected O, but got I
		//IL_0097: Expected O, but got I
		//IL_0151: Expected O, but got I
		//IL_0161: Expected O, but got I
		//IL_0240: Expected I, but got O
		//IL_0270: Expected O, but got I
		//IL_0286: Expected O, but got I
		nint num = (nint)typeof(global::UnityEngine.UIElements.EnumFieldHelpers);
		global::GameAnalyticsSDK.GameAnalytics.Initialize();
		string version = global::UnityEngine.Application.version;
		global::GameAnalyticsSDK.GameAnalytics.SetBuildAllPlatforms(version);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X22_v1 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]");
		object obj = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v7+E0]");
		if ((nint)0 != 0)
		{
			if (global::Facebook.Unity.FB.IsInitialized)
			{
				goto IL_007c;
			}
		}
		else if (global::Facebook.Unity.FB.IsInitialized)
		{
			goto IL_007c;
		}
		nint num2 = (nint)typeof(global::Facebook.Unity.Windows.IWindowsFacebook);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v7 (Il2CppMethodInfo)+98]");
		global::Facebook.Unity.InitDelegate onInitComplete = new global::Facebook.Unity.InitDelegate(this, (global::System.IntPtr)0);
		nint num3 = 0;
		nint num4 = (nint)typeof(global::TMPro.KerningTable._003C_003Ec__DisplayClass3_0);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X23_v1 (Il2CppClass<TMPro.KerningTable+<>c__DisplayClass3_0>)+1E0]");
		object obj2 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v11+E0]");
		object obj3;
		global::Facebook.Unity.HideUnityDelegate onHideUnity;
		if ((nint)0 != 0)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v11+B8]");
			obj3 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v11+8]");
			onHideUnity = (global::Facebook.Unity.HideUnityDelegate)0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v11+8]");
			if ((nint)0 != 0)
			{
				goto IL_018b;
			}
		}
		else
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X23_v1 (Il2CppClass<TMPro.KerningTable+<>c__DisplayClass3_0>)+1E0]");
			object obj4 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v22+B8]");
			obj3 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v11+8]");
			onHideUnity = (global::Facebook.Unity.HideUnityDelegate)0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v11+8]");
			if ((nint)0 != 0)
			{
				goto IL_018b;
			}
		}
		nint num5 = (nint)typeof(global::UnityEngine.UIElements.EnumFieldHelpers);
		object obj5 = obj3;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v14 (Il2CppMethodInfo)+198]");
		global::Facebook.Unity.HideUnityDelegate hideUnityDelegate = new global::Facebook.Unity.HideUnityDelegate(obj5, (global::System.IntPtr)0);
		nint num6 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X23_v1 (Il2CppClass<TMPro.KerningTable+<>c__DisplayClass3_0>)+1E0]");
		object obj6 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v16+B8]");
		object obj7 = (nint)0 + (nint)8;
		obj7 = hideUnityDelegate;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		onHideUnity = hideUnityDelegate;
		goto IL_018b;
		IL_018b:
		global::Facebook.Unity.FB.Init(onInitComplete, onHideUnity);
		return;
		IL_007c:
		global::Facebook.Unity.FB.ActivateApp();
		string text = "IsCyrillic";
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X20_v6 (System.String)+BF8]");
		global::UnityEngine.SceneManagement.SceneManager.LoadScene((string)0);
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000143")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE6358", Offset = "0xFE6358", Length = "0x94")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv10 = 0x302A000;\n\tv12 = System.Runtime.Serialization.ObjectHolderList;\n\tv14 = *([302A9AC]) & 1;\n\tv15 = v14 == 0;\n\tif (v15) goto L_0023;\n\tv45 = \"IsCyrillic\" + 0xBF8;\n\tv18 = *([v12 @ X19_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+DA0]);\n\tv20 = *([v18 @ X0_v13+E0]) == 0;\n\tif (v20) goto L_0033;\nL_001A:\n\tUnityEngine.SceneManagement.SceneManager::LoadScene(*([v45 @ X20_v6]));\n\treturn;\nL_0023:\n\t*([v10 @ X20_v1+9AC]) = 1;\n\tv45 = \"IsCyrillic\" + 0xBF8;\n\tv40 = *([v12 @ X19_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+DA0]);\n\tv69 = *([v40 @ X0_v10+E0]) == 0;\n\tv42 = ~v69;\n\tif (v42) goto L_001A;\nL_0033:\n\tUnityEngine.SceneManagement.SceneManager::LoadScene(*([v56 @ X20_v2]));\n\treturn;\n// 34 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void StartGame()
	{
		//IL_0009: Expected O, but got I4
		//IL_0017: Expected I, but got O
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00c5: Expected O, but got I
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0069: Expected O, but got I
		object obj = 50503680;
		nint num = (nint)typeof(global::System.Runtime.Serialization.ObjectHolderList);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302A9AC]");
		object obj2;
		object sceneName;
		if ((uint)((nuint)0u & (nuint)1u) != 0)
		{
			obj2 = "IsCyrillic" + 3064;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X19_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+DA0]");
			object obj3 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X0_v13+E0]");
			bool flag = (nint)0 == 0;
			sceneName = obj2;
			if (!flag)
			{
				goto IL_0096;
			}
		}
		else
		{
			_ = 1;
			obj2 = "IsCyrillic" + 3064;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X19_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+DA0]");
			object obj4 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v10+E0]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			sceneName = obj2;
			if (flag3)
			{
				goto IL_0096;
			}
		}
		global::UnityEngine.SceneManagement.SceneManager.LoadScene((string)sceneName);
		return;
		IL_0096:
		global::UnityEngine.SceneManagement.SceneManager.LoadScene((string)obj2);
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000144")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE63EC", Offset = "0xFE63EC", Length = "0xA4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv16 = 0x302A000;\n\tv18 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv20 = T & 1;\n\tv21 = v20 == 0;\n\tif (v21) goto L_0028;\n\tv51 = Il2CppMethodInfo + 0xCA8;\n\tv24 = *([v18 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A58]);\n\tv26 = *([v24 @ X0_v13+E0]) == 0;\n\tif (v26) goto L_003A;\nL_001F:\n\tSingleton`1::.ctor /* +1 sharing this address */(this, *([v51 @ X21_v6]));\n\treturn;\nL_0028:\n\t*([v16 @ X21_v1+95B]) = 1;\n\tv51 = Il2CppMethodInfo + 0xCA8;\n\tv46 = *([v18 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A58]);\n\tv79 = *([v46 @ X0_v10+E0]) == 0;\n\tv48 = ~v79;\n\tif (v48) goto L_001F;\nL_003A:\n\tSingleton`1::.ctor /* +1 sharing this address */(this, *([v64 @ X21_v2]));\n\treturn;\n// 41 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public Loader()
	{
		//IL_0009: Expected O, but got I4
		//IL_0017: Expected I, but got O
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected I4, but got Unknown
		//IL_00ae: Expected O, but got I
		//IL_00be: Expected O, but got I
		//IL_0054: Expected O, but got I
		//IL_0064: Expected O, but got I
		object obj = 50503680;
		nint num = (nint)typeof(global::System.Collections.Generic.List<global::UnityEngine.UIElements.StyleSheets.Syntax.Expression>);
		if ((typeof(_00210) & 1) != 0)
		{
			object obj2 = (nint)0 + (nint)3240;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A58]");
			object obj3 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X0_v13+E0]");
			bool flag = (nint)0 == 0;
			object obj4 = obj2;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj2 = (nint)0 + (nint)3240;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A58]");
			object obj5 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v10+E0]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			object obj4 = obj2;
			if (flag3)
			{
				goto IL_0091;
			}
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18ABE40 (Singleton`1::.ctor, and 1 more at this address)");
		return;
		IL_0091:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18ABE40 (Singleton`1::.ctor, and 1 more at this address)");
	}
}
