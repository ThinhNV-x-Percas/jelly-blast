[global::Cpp2ILInjected.Token(Token = "0x200003B")]
public class ApplicationManager : Singleton<ApplicationManager>
{
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x200003C")]
	private sealed class _003CExecuteLoadScene_003Ed__12 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
	{
		[global::Cpp2ILInjected.Token(Token = "0x40000E4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[global::Cpp2ILInjected.Token(Token = "0x40000E5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[global::Cpp2ILInjected.Token(Token = "0x40000E6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public ApplicationManager _003C_003E4__this;

		[global::Cpp2ILInjected.Token(Token = "0x40000E7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public int buildIndex;

		[global::Cpp2ILInjected.Token(Token = "0x40000E8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private global::UnityEngine.AsyncOperation _003Coperation_003E5__2;

		[global::Cpp2ILInjected.Token(Token = "0x1700000D")]
		object global::System.Collections.Generic.IEnumerator<object>.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600015E")]
			[global::Cpp2ILInjected.Address(RVA = "0xFE7614", Offset = "0xFE7614", Length = "0x8")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn this.<>2__current;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
			get
			{
				return _003C_003E2__current;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700000E")]
		object global::System.Collections.IEnumerator.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000160")]
			[global::Cpp2ILInjected.Address(RVA = "0xFE765C", Offset = "0xFE765C", Length = "0x8")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn this.<>2__current;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
			get
			{
				return _003C_003E2__current;
			}
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x600015B")]
		[global::Cpp2ILInjected.Address(RVA = "0xFE7138", Offset = "0xFE7138", Length = "0x2C")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tSystem.Object::.ctor(this);\n\tthis.<>1__state = <>1__state;\n\treturn;\n// 14 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public _003CExecuteLoadScene_003Ed__12(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x600015C")]
		[global::Cpp2ILInjected.Address(RVA = "0xFE7418", Offset = "0xFE7418", Length = "0x4")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn;\n")]
		void global::System.IDisposable.Dispose()
		{
		}

		[global::Cpp2ILInjected.Token(Token = "0x600015D")]
		[global::Cpp2ILInjected.Address(RVA = "0xFE741C", Offset = "0xFE741C", Length = "0x1F8")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_001D;\n\tv25 = CollectParticleData[];\n\tv26 = v25 + 0xB48;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv58 = System.Runtime.Serialization.ObjectHolderList;\n\tv59 = v58 + 0xDA0;\n\tv60 = \"il2cpp_codegen_initialize_runtime_metadata\"(v59, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv71 = System.Xml.ValidateNames;\n\tv72 = v71 + 0x260;\n\tv44 = \"il2cpp_codegen_initialize_runtime_metadata\"(v72, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv46 = 1;\n\t*([302A966]) = v46;\nL_001D:\n\tv48 = v43.<>4__this;\n\tv53 = v43.<>1__state == 2;\n\tif (v53) goto L_005A;\n\tv65 = v43.<>1__state == 1;\n\tif (v65) goto L_005D;\n\tv73 = v43.<>1__state == 0;\n\tv74 = ~v73;\n\tif (v74) goto L_009F;\n\tv43.<>1__state = 0xFFFFFFFF;\n\tv48.loadingScene = 1;\n\tv133 = ApplicationManager::get_appData();\n\tApplicationData::SavePlayerData(v133);\n\tv216 = System.Xml.ValidateNames;\n\tv218 = new *([v216 @ X8_v18 (Il2CppClass<System.Xml.ValidateNames>)+260])();\n\tUnityEngine.WaitForSecondsRealtime::.ctor(v218, v48.sceneTransitionDuration);\n\tv225 = v43 + 0x18;\n\tv43.<>2__current = v218;\n\tv227 = 0xF3F1B4(v225, v218, v29, v30, v31, v32, v33, v34, v48.sceneTransitionDuration, v36, v37, v38, v39, v40, v41, v42);\n\tv43.<>1__state = 1;\n\treturn 1;\nL_005A:\n\tv43.<>1__state = 0xFFFFFFFF;\n\tgoto L_0073;\nL_005D:\n\tv43.<>1__state = 0xFFFFFFFF;\n\tgoto L_0069;\n\tv112 = \"il2cpp_codegen_runtime_class_init\"(v79, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\nL_0069:\n\tv116 = UnityEngine.SceneManagement.SceneManager::LoadSceneAsync(v43.buildIndex);\n\tv202 = v43 + 0x30;\n\tv43.<operation>5__2 = v116;\n\tv94 = 0xF3F1B4(v202, v116, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\nL_0073:\n\tv213 = UnityEngine.AsyncOperation::get_isDone(v43.<operation>5__2);\n\tv203 = ~v213;\n\tif (v203) goto L_00A4;\n\tv204 = CollectParticleData[];\n\tv206 = *([v204 @ X8_v7 (Il2CppClass<CollectParticleData[]>)+B48]);\n\tv207 = *([v206 @ X8_v9+B8]);\n\tv142 = *([v207 @ X8_v10+8]);\n\tv208 = *([v207 @ X8_v10+8]) == 0;\n\tif (v208) goto L_0081;\n\t*([v142 @ X8_v11+18])(v213, *([v142 @ X8_v11+40]), *([v142 @ X8_v11+28]), v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\nL_0081:\n\tv134 = ApplicationManager::get_appData();\n\tApplicationData::LoadPlayerData(v134);\n\tv48.loadingScene = 0;\n\treturn 0;\nL_009F:\n\treturn 0;\nL_00A4:\n\tv164 = UnityEngine.AsyncOperation::get_progress(v43.<operation>5__2);\n\tv219 = v43 + 0x18;\n\tv43.<>2__current = 0;\n\tv221 = 0xF3F1B4(v219, 0, v29, v30, v31, v32, v33, v34, v164, v36, v37, v38, v39, v40, v41, v42);\n\tv43.<>1__state = 2;\n\treturn 1;\n\treturnVal2 = new System.NullReferenceException();\n\treturn returnVal2;\n// 122 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		private bool MoveNext()
		{
			//IL_0212: Expected O, but got I
			//IL_0169: Expected I, but got O
			//IL_0179: Expected O, but got I
			//IL_0189: Expected O, but got I
			//IL_0199: Expected O, but got I
			//IL_011a: Expected O, but got I
			//IL_0091: Expected I, but got O
			//IL_00b5: Expected O, but got I
			ApplicationManager applicationManager = _003C_003E4__this;
			if (_003C_003E1__state != 2)
			{
				if (_003C_003E1__state != 1)
				{
					if (_003C_003E1__state == 0)
					{
						_003C_003E1__state = -1;
						applicationManager.loadingScene = true;
						ApplicationData appData = ApplicationManager.appData;
						appData.SavePlayerData();
						nint num = (nint)typeof(global::System.Xml.ValidateNames);
						global::UnityEngine.WaitForSecondsRealtime waitForSecondsRealtime = new global::UnityEngine.WaitForSecondsRealtime(applicationManager.sceneTransitionDuration);
						object obj = (nint)this + 24;
						_003C_003E2__current = waitForSecondsRealtime;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
						_003C_003E1__state = 1;
						return true;
					}
					return false;
				}
				_003C_003E1__state = -1;
				global::UnityEngine.AsyncOperation asyncOperation = global::UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(buildIndex);
				object obj2 = (nint)this + 48;
				_003Coperation_003E5__2 = asyncOperation;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
			}
			else
			{
				_003C_003E1__state = -1;
			}
			if (_003Coperation_003E5__2.isDone)
			{
				nint num2 = (nint)typeof(CollectParticleData[]);
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v7 (Il2CppClass<CollectParticleData[]>)+B48]");
				object obj3 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v9+B8]");
				object obj4 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v10+8]");
				object obj5 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v10+8]");
				if ((nint)0 != 0)
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v142 @ X8_v11+18] (should have been resolved before IL gen)");
				}
				ApplicationData appData2 = ApplicationManager.appData;
				appData2.LoadPlayerData();
				applicationManager.loadingScene = false;
				return false;
			}
			float progress = _003Coperation_003E5__2.progress;
			object obj6 = (nint)this + 24;
			_003C_003E2__current = null;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
			_003C_003E1__state = 2;
			return true;
		}

		bool global::System.Collections.IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x600015F")]
		[global::Cpp2ILInjected.Address(RVA = "0xFE761C", Offset = "0xFE761C", Length = "0x40")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv10 = Facebook.Unity.Windows.IWindowsFacebook + 0xF30;\n\tv11 = 0xF3F22C(v10, methodInfo, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26);\n\tv27 = new v11();\n\tSystem.NotSupportedException::.ctor(v27);\n\tv31 = Il2CppMethodInfo + 0xDC8;\n\tv32 = 0xF3F22C(v31, 0, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26);\n\tthrow v27;\n// 13 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		void global::System.Collections.IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0039: Expected O, but got I
			object obj = typeof(global::Facebook.Unity.Windows.IWindowsFacebook) + 3888;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F22C");
			global::System.NotSupportedException ex = new global::System.NotSupportedException();
			object obj2 = (nint)0 + (nint)3528;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F22C");
			throw ex;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x40000DF")]
	private static ApplicationData _applicationData;

	[global::Cpp2ILInjected.Token(Token = "0x40000E0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x21")]
	private bool loadingScene;

	[global::Cpp2ILInjected.Token(Token = "0x40000E1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	private float sceneTransitionDuration;

	[global::Cpp2ILInjected.Token(Token = "0x40000E2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public bool isDeveloperMode;

	[global::Cpp2ILInjected.Token(Token = "0x40000E3")]
	public static global::System.Action OnSceneChanged;

	[global::Cpp2ILInjected.Token(Token = "0x1700000C")]
	public static ApplicationData appData
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000150")]
		[global::Cpp2ILInjected.Address(RVA = "0xFE6ACC", Offset = "0xFE6ACC", Length = "0x1A0")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv14 = 0x302A000;\n\tv16 = CollectParticleData[];\n\tv18 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv20 = *([302A962]) & 1;\n\tv21 = v20 == 0;\n\tif (v21) goto L_002D;\n\tv22 = *([v16 @ X20_v1 (Il2CppClass<CollectParticleData[]>)+B48]);\n\tv23 = *([v22 @ X8_v26+B8]);\n\tv52 = *([v23 @ X8_v27]);\n\tv25 = *([v18 @ X21_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv27 = *([v25 @ X0_v28+E0]) == 0;\n\tif (v27) goto L_003A;\nL_001B:\n\tv57 = UnityEngine.Object::op_Equality(v52, 0);\n\tv66 = ~v57;\n\tv67 = ~v66;\n\tif (v67) goto L_003D;\n\tgoto L_009A;\nL_002D:\n\t*([v14 @ X19_v1+962]) = 1;\n\tv152 = *([v16 @ X20_v1 (Il2CppClass<CollectParticleData[]>)+B48]);\n\tv153 = *([v152 @ X8_v22+B8]);\n\tv52 = *([v153 @ X8_v23]);\n\tv47 = *([v18 @ X21_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv154 = *([v47 @ X0_v24+E0]) == 0;\n\tv49 = ~v154;\n\tif (v49) goto L_001B;\nL_003A:\n\tv71 = UnityEngine.Object::op_Equality(v61, 0);\n\tv79 = ~v71;\n\tif (v79) goto L_009A;\nL_003D:\n\tv82 = \"<'width'>\";\n\tv86 = UnityEngine.Resources::Load(*([v82 @ X8_v6 (System.String)+EE8]));\n\tv138 = v86 == 0;\n\tif (v138) goto L_0057;\n\tv155 = CollectParticleData[];\n\tv157 = *([v155 @ X9_v3 (Il2CppClass<CollectParticleData[]>)+B38]);\n\tv158 = *([v86 @ X0_v5 (UnityEngine.Object)]);\n\tv161 = *([v158 @ X10_v3 (Il2CppClass<UnityEngine.Object>)+130]) < *([v157 @ X8_v13+130]);\n\tv162 = ~v161;\n\tif (v162) goto L_005E;\n\tgoto L_0070;\nL_0057:\n\tv171 = *([v16 @ X20_v1 (Il2CppClass<CollectParticleData[]>)+B48]);\n\tv172 = *([v171 @ X8_v9+B8]);\n\t*([v172 @ X8_v10]) = 0;\n\tv173 = *([v16 @ X20_v1 (Il2CppClass<CollectParticleData[]>)+B48]);\n\tv140 = *([v173 @ X8_v11+B8]);\n\tgoto L_0099;\nL_005E:\n\tv177 = *([v157 @ X8_v13+130]) << 3;\n\tv178 = *([v158 @ X10_v3 (Il2CppClass<UnityEngine.Object>)+C8]) + v177;\n\tv189 = *([v178 @ X10_v12-8]) != v157;\n\tif (v189) goto L_FFFFFFFF;\n\tgoto L_0070;\nL_0070:\n\tv232 = *([v16 @ X20_v1 (Il2CppClass<CollectParticleData[]>)+B48]);\n\tv233 = *([v232 @ X10_v5+B8]);\n\t*([v233 @ X10_v6]) = v229;\n\tv234 = *([v16 @ X20_v1 (Il2CppClass<CollectParticleData[]>)+B48]);\n\tv140 = *([v234 @ X8_v15+B8]);\n\tv214 = *([v155 @ X9_v3 (Il2CppClass<CollectParticleData[]>)+B38]);\n\tv212 = *([v86 @ X0_v5 (UnityEngine.Object)]);\n\tv235 = *([v212 @ X10_v7 (Il2CppClass<UnityEngine.Object>)+130]) < *([v214 @ X9_v5+130]);\n\tv208 = ~v235;\n\tif (v208) goto L_0086;\n\tgoto L_0099;\nL_0086:\n\tv193 = *([v214 @ X9_v5+130]) << 3;\n\tv237 = *([v212 @ X10_v7 (Il2CppClass<UnityEngine.Object>)+C8]) + v193;\n\tv191 = *([v237 @ X10_v9-8]) != v214;\n\tif (v191) goto L_FFFFFFFF;\n\tgoto L_0099;\nL_0099:\n\tv136 = 0xF3F1B4(v140, v134, v75, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\nL_009A:\n\tv142 = *([v16 @ X20_v1 (Il2CppClass<CollectParticleData[]>)+B48]);\n\tv143 = *([v142 @ X8_v3+B8]);\n\treturn *([v143 @ X8_v4]);\n// 95 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0017: Expected I, but got O
			//IL_0025: Expected I, but got O
			//IL_0113: Expected O, but got I
			//IL_0123: Expected O, but got I
			//IL_013b: Expected O, but got I
			//IL_00ea: Expected O, but got I4
			//IL_0068: Expected O, but got I
			//IL_0078: Expected O, but got I
			//IL_0090: Expected O, but got I
			//IL_01c2: Expected O, but got I
			//IL_025a: Expected O, but got I
			//IL_026a: Expected O, but got I
			//IL_0273: Expected O, but got I4
			//IL_0283: Expected O, but got I
			//IL_0293: Expected O, but got I
			//IL_019a: Expected O, but got I4
			//IL_01f1: Expected I, but got O
			//IL_0201: Expected O, but got I
			//IL_0209: Expected I, but got O
			//IL_0389: Expected O, but got I
			//IL_0399: Expected O, but got I
			//IL_02c8: Expected O, but got I
			//IL_03ae: Expected O, but got I
			//IL_03be: Expected O, but got I
			//IL_03d6: Expected O, but got I
			//IL_03e6: Expected O, but got I
			//IL_03f6: Expected O, but got I
			//IL_03fe: Expected I, but got O
			//IL_033b: Expected O, but got I
			object obj = 50503680;
			nint num = (nint)typeof(CollectParticleData[]);
			nint num2 = (nint)typeof(global::Facebook.Unity.Windows.IWindowsFacebook);
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302A962]");
			global::UnityEngine.Object obj4;
			global::UnityEngine.Object obj6;
			if ((uint)((nuint)0u & (nuint)1u) != 0)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X20_v1 (Il2CppClass<CollectParticleData[]>)+B48]");
				object obj2 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X8_v26+B8]");
				object obj3 = 0;
				obj4 = (global::UnityEngine.Object)obj3;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X21_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]");
				object obj5 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X0_v28+E0]");
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
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X20_v1 (Il2CppClass<CollectParticleData[]>)+B48]");
				object obj7 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v22+B8]");
				object obj8 = 0;
				obj4 = (global::UnityEngine.Object)obj8;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X21_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]");
				object obj9 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v24+E0]");
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
			if (!flag5)
			{
				goto IL_01a8;
			}
			goto IL_0379;
			IL_0379:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X20_v1 (Il2CppClass<CollectParticleData[]>)+B48]");
			object obj11 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v3+B8]");
			return (ApplicationData)0;
			IL_01a8:
			string text = "<'width'>";
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v6 (System.String)+EE8]");
			global::UnityEngine.Object obj12 = global::UnityEngine.Resources.Load((string)0);
			if ((object)obj12 != null)
			{
				nint num3 = (nint)typeof(CollectParticleData[]);
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X9_v3 (Il2CppClass<CollectParticleData[]>)+B38]");
				object obj13 = 0;
				nint num4 = (nint)obj12;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X10_v3 (Il2CppClass<UnityEngine.Object>)+130]");
				nint num5 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v13+130]");
				global::UnityEngine.Object obj14;
				if (num5 < 0)
				{
					obj14 = null;
				}
				else
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v13+130]");
					int num6 = (int)((nint)0 << 3);
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X10_v3 (Il2CppClass<UnityEngine.Object>)+C8]");
					object obj15 = (nint)0 + (nint)num6;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X10_v12-8]");
					obj14 = ((0 != (nint)obj13) ? null : obj12);
				}
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X20_v1 (Il2CppClass<CollectParticleData[]>)+B48]");
				object obj16 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X10_v5+B8]");
				object obj17 = 0;
				obj17 = obj14;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X20_v1 (Il2CppClass<CollectParticleData[]>)+B48]");
				object obj18 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v15+B8]");
				object obj19 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X9_v3 (Il2CppClass<CollectParticleData[]>)+B38]");
				object obj20 = 0;
				nint num7 = (nint)obj12;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X10_v7 (Il2CppClass<UnityEngine.Object>)+130]");
				nint num8 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X9_v5+130]");
				if (num8 < 0)
				{
					global::UnityEngine.Object obj21 = null;
				}
				else
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X9_v5+130]");
					int num9 = (int)((nint)0 << 3);
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X10_v7 (Il2CppClass<UnityEngine.Object>)+C8]");
					object obj22 = (nint)0 + (nint)num9;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X10_v9-8]");
					if (0 == (nint)obj20)
					{
						global::UnityEngine.Object obj21 = obj12;
					}
					else
					{
						global::UnityEngine.Object obj21 = null;
					}
				}
			}
			else
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X20_v1 (Il2CppClass<CollectParticleData[]>)+B48]");
				object obj23 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v9+B8]");
				object obj24 = 0;
				obj24 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X20_v1 (Il2CppClass<CollectParticleData[]>)+B48]");
				object obj25 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v11+B8]");
				object obj19 = 0;
				global::UnityEngine.Object obj21 = null;
			}
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
			goto IL_0379;
			IL_00bd:
			bool flag6 = obj4 == null;
			bool flag7 = !flag6;
			bool flag8 = !flag7;
			obj10 = 0;
			if (flag8)
			{
				goto IL_01a8;
			}
			goto IL_0379;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000151")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE6C6C", Offset = "0xFE6C6C", Length = "0x1A4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0029;\n\tv25 = CollectParticleData[];\n\tv26 = v25 + 0xB30;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv53 = System.ComponentModel.BooleanConverter;\n\tv54 = v53 + 0x7D8;\n\tv55 = \"il2cpp_codegen_initialize_runtime_metadata\"(v54, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv61 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv62 = v61 + 0x9B8;\n\tv63 = \"il2cpp_codegen_initialize_runtime_metadata\"(v62, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv69 = Il2CppMethodInfo;\n\tv70 = v69 + 0xB8;\n\tv71 = \"il2cpp_codegen_initialize_runtime_metadata\"(v70, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv76 = Il2CppMethodInfo;\n\tv77 = v76 + 0xDE0;\n\tv44 = \"il2cpp_codegen_initialize_runtime_metadata\"(v77, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv47 = 1;\n\t*([302A963]) = v47;\nL_0029:\n\tSystem.Nullable`1<System.Boolean>::.ctor(&v51 @ stack_-32_v2 (System.Nullable`1<System.Boolean>), 0);\n\tSystem.Nullable`1<System.Boolean>::.ctor(&v59 @ stack_-34_v2 (System.Nullable`1<System.Boolean>), 1);\n\tSystem.Nullable`1<System.Int32Enum>::.ctor(&v67 @ stack_-40_v2 (System.Nullable`1<System.Int32Enum>), 2);\n\tgoto L_003E;\n\tv78 = \"il2cpp_codegen_runtime_class_init\"(v72, v68, v65, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\nL_003E:\n\tv84 = DG.Tweening.DOTween::Init(v51, v59, v67);\n\tv87 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv90 = *([v84 @ X0_v8 (DG.Tweening.IDOTweenInit)]);\n\tv186 = *([v90 @ X8_v7 (Il2CppClass<DG.Tweening.IDOTweenInit>)+12E]);\n\tv92 = *([v90 @ X8_v7 (Il2CppClass<DG.Tweening.IDOTweenInit>)+12E]) == 0;\n\tif (v92) goto L_0065;\n\tv185 = *([v90 @ X8_v7 (Il2CppClass<DG.Tweening.IDOTweenInit>)+B0]) + 8;\nL_0050:\n\tv191 = *([v185 @ X10_v6-8]) == *([v87 @ X8_v5 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+9B8]);\n\tif (v191) goto L_0068;\n\tv185 = v185 + 0x10;\n\tv171 = v186 - 1;\n\tv151 = v186 != 1;\n\tif (v151) goto L_0050;\nL_0065:\n\tv237 = 0xF7087C(v84, *([v87 @ X8_v5 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+9B8]), 0, 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tgoto L_0070;\nL_0068:\n\tv233 = *([v185 @ X10_v6]) << 4;\n\tv234 = v90 + v233;\n\tv237 = v234 + 0x138;\nL_0070:\n\t*([v237 @ X0_v11])(v240, v84, 0x3E8, 0x64, *([v237 @ X0_v11+8]), v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv139 = ApplicationManager::get_appData();\n\tApplicationData::LoadPlayerData(v139);\n\tgoto L_007F;\n\tv245 = \"il2cpp_codegen_runtime_class_init\"(v243, v135, v137, v133, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\nL_007F:\n\tUnityEngine.Application::set_targetFrameRate(0x3C);\n\tUnityEngine.Input::set_multiTouchEnabled(0);\n\tApplicationManager::WarmUpJsonHelper(0);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 90 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	protected override void OnAwake()
	{
		//IL_0034: Expected I, but got O
		//IL_003c: Expected I, but got O
		//IL_004c: Expected O, but got I
		//IL_0087: Expected O, but got I
		//IL_00ef: Expected I4, but got O
		//IL_00fd: Expected O, but got I
		//IL_010c: Expected O, but got I
		//IL_009b: Expected O, but got I
		//IL_00aa: Expected O, but got I
		bool? recycleAllByDefault = false;
		bool? useSafeMode = true;
		global::System.Int32Enum? logBehaviour = (global::System.Int32Enum)2;
		global::DG.Tweening.IDOTweenInit iDOTweenInit = global::DG.Tweening.DOTween.Init(recycleAllByDefault, useSafeMode, (global::DG.Tweening.LogBehaviour?)logBehaviour);
		nint num = (nint)typeof(global::UnityEngine.UIElements.EnumFieldHelpers);
		nint num2 = (nint)iDOTweenInit;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v7 (Il2CppClass<DG.Tweening.IDOTweenInit>)+12E]");
		object obj = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v7 (Il2CppClass<DG.Tweening.IDOTweenInit>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00d2;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v7 (Il2CppClass<DG.Tweening.IDOTweenInit>)+B0]");
		object obj2 = (nint)0 + (nint)8;
		while (true)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X10_v6-8]");
			nint num3 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v5 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+9B8]");
			if (num3 == 0)
			{
				break;
			}
			obj2 = (nint)obj2 + 16;
			object obj3 = (nint)obj - 1;
			bool flag = (nint)obj != 1;
			obj = obj3;
			if (flag)
			{
				continue;
			}
			goto IL_00d2;
		}
		int num4 = obj2 << 4;
		object obj4 = num2 + num4;
		object obj5 = (nint)obj4 + 312;
		goto IL_019a;
		IL_00d2:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
		goto IL_019a;
		IL_019a:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v237 @ X0_v11] (should have been resolved before IL gen)");
		ApplicationData applicationData = appData;
		applicationData.LoadPlayerData();
		global::UnityEngine.Application.targetFrameRate = 60;
		global::UnityEngine.Input.multiTouchEnabled = false;
		((ApplicationManager)null).WarmUpJsonHelper();
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000152")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE6E10", Offset = "0xFE6E10", Length = "0xEC")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv20 = System.Collections.Generic.NullableComparer`1;\n\tv22 = \"system.security.cryptography.des\";\n\tv24 = Sponge+<>c__DisplayClass7_0;\n\tgoto L_002C;\n\tv31 = Il2CppMethodInfo;\n\tv32 = v31 + 0x928;\n\tv33 = \"il2cpp_codegen_initialize_runtime_metadata\"(v32, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48);\n\tv60 = Il2CppMethodInfo;\n\tv61 = v60 + 0x930;\n\tv62 = \"il2cpp_codegen_initialize_runtime_metadata\"(v61, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48);\n\tv66 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv67 = v66 + 0x418;\n\tv68 = \"il2cpp_codegen_initialize_runtime_metadata\"(v67, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48);\n\tv73 = Sponge+<>c__DisplayClass7_0;\n\tv74 = v73 + 0xC40;\n\tv75 = \"il2cpp_codegen_initialize_runtime_metadata\"(v74, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48);\n\tv81 = System.Collections.Generic.NullableComparer`1;\n\tv82 = v81 + 0xC38;\n\tv83 = \"il2cpp_codegen_initialize_runtime_metadata\"(v82, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48);\n\tv94 = \"system.security.cryptography.des\";\n\tv95 = v94 + 0xC50;\n\tv50 = \"il2cpp_codegen_initialize_runtime_metadata\"(v95, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48);\n\tv53 = 1;\n\t*([302A964]) = v53;\nL_002C:\n\tv54 = Il2CppMethodInfo;\n\tv56 = Il2CppMethodInfo;\n\tv59 = new *([v20 @ X19_v1 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+C38])();\n\t<>f__AnonymousType0`1::.ctor /* +1 sharing this address */(v59, *([v22 @ X21_v1 (System.String)+C50]), *([v24 @ X22_v1 (Il2CppClass<Sponge+<>c__DisplayClass7_0>)+C40]));\n\tgoto L_003E;\n\tv76 = \"il2cpp_codegen_runtime_class_init\"(v69, v64, v65, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48);\nL_003E:\n\tv80 = JsonHelper::Serialize /* +1 sharing this address */(v59, *([v54 @ X24_v1 (Il2CppMethodInfo)+930]));\n\tv93 = JsonHelper::Deserialize /* +1 sharing this address */(v80, *([v56 @ X23_v2 (Il2CppMethodInfo)+928]));\n\treturn;\n// 42 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void WarmUpJsonHelper()
	{
		//IL_000e: Expected I, but got O
		//IL_0025: Expected I, but got O
		nint num = (nint)typeof(global::System.Collections.Generic.NullableComparer<>);
		string text = "system.security.cryptography.des";
		nint num2 = (nint)typeof(Sponge._003C_003Ec__DisplayClass7_0);
		nint num3 = 0;
		nint num4 = 0;
		object obj = null;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12F9024 (<>f__AnonymousType0`1::.ctor, and 1 more at this address)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1152534 (JsonHelper::Serialize, and 1 more at this address)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @115234C (JsonHelper::Deserialize, and 1 more at this address)");
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000153")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE6EFC", Offset = "0xFE6EFC", Length = "0x1C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv6 = ApplicationManager::get_appData();\n\tApplicationData::SavePlayerData(v6);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 9 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void OnApplicationQuit()
	{
		ApplicationData applicationData = appData;
		applicationData.SavePlayerData();
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000154")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE6F18", Offset = "0xFE6F18", Length = "0x100")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_001A;\n\tv23 = System.Runtime.Serialization.ObjectHolderList;\n\tv24 = v23 + 0xDA0;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv43 = 1;\n\t*([302A9AD]) = v43;\nL_001A:\n\tgoto L_001D;\n\tv48 = \"il2cpp_codegen_runtime_class_init\"(v44, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\nL_001D:\n\tv51 = UnityEngine.SceneManagement.SceneManager::GetActiveScene();\n\tv55 = UnityEngine.SceneManagement.Scene::get_buildIndex(&v51 @ X0_v5 (UnityEngine.SceneManagement.Scene));\n\tv57 = ~this.loadingScene;\n\tif (v57) goto L_0030;\n\treturn;\nL_0030:\n\tv67 = System.Xml.ValidateNames;\n\tgoto L_003B;\n\tv93 = System.Xml.ValidateNames;\n\tv94 = v93 + 0xFA8;\n\tv95 = \"il2cpp_codegen_initialize_runtime_metadata\"(v94, v54, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv97 = 1;\n\t*([302A9AE]) = v97;\nL_003B:\n\tv51 = *([v67 @ X22_v1 (Il2CppClass<System.Xml.ValidateNames>)+FA8]);\n\tv99 = new *([v67 @ X22_v1 (Il2CppClass<System.Xml.ValidateNames>)+FA8])();\n\tSystem.Object::.ctor(v99);\n\t*([v99 @ X0_v10 (System.Object)+10]) = 0;\n\tv51 = v99 + 0x20;\n\t*([v99 @ X0_v10 (System.Object)+20]) = this;\n\tv51 = 0xF3F1B4(v51, this, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\t*([v99 @ X0_v10 (System.Object)+28]) = v55;\n\tv81 = UnityEngine.MonoBehaviour::StartCoroutine(this, v99);\n\treturn;\n// 53 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void ReloadActiveScene()
	{
		//IL_004a: Expected I, but got O
		//IL_0078: Expected O, but got I
		//IL_0097: Expected O, but got I
		int buildIndex = global::UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex;
		if (!loadingScene)
		{
			nint num = (nint)typeof(global::System.Xml.ValidateNames);
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X22_v1 (Il2CppClass<System.Xml.ValidateNames>)+FA8]");
			global::UnityEngine.SceneManagement.Scene scene = (global::UnityEngine.SceneManagement.Scene)0;
			object obj = new object();
			_ = 0;
			scene = (global::UnityEngine.SceneManagement.Scene)((nint)obj + 32);
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
			global::UnityEngine.Coroutine coroutine = StartCoroutine((global::System.Collections.IEnumerator)obj);
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000155")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE7018", Offset = "0xFE7018", Length = "0xA0")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv16 = ~this.loadingScene;\n\tif (v16) goto L_0017;\n\treturn;\nL_0017:\n\tv28 = System.Xml.ValidateNames;\n\tgoto L_0023;\n\tv55 = System.Xml.ValidateNames;\n\tv56 = v55 + 0xFA8;\n\tv57 = \"il2cpp_codegen_initialize_runtime_metadata\"(v56, buildIndex, methodInfo, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70);\n\tv72 = 1;\n\t*([302A9AE]) = v72;\nL_0023:\n\tv74 = new *([v28 @ X22_v1 (Il2CppClass<System.Xml.ValidateNames>)+FA8])();\n\tSystem.Object::.ctor(v74);\n\t*([v74 @ X0_v3 (System.Object)+10]) = 0;\n\tv78 = v74 + 0x20;\n\t*([v74 @ X0_v3 (System.Object)+20]) = this;\n\tv80 = 0xF3F1B4(v78, this, methodInfo, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70);\n\t*([v74 @ X0_v3 (System.Object)+28]) = buildIndex;\n\tv39 = UnityEngine.MonoBehaviour::StartCoroutine(this, v74);\n\treturn;\n// 39 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void LoadScene(int buildIndex)
	{
		//IL_002a: Expected I, but got O
		//IL_0062: Expected O, but got I
		if (!loadingScene)
		{
			nint num = (nint)typeof(global::System.Xml.ValidateNames);
			object obj = new object();
			_ = 0;
			object obj2 = (nint)obj + 32;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
			global::UnityEngine.Coroutine coroutine = StartCoroutine((global::System.Collections.IEnumerator)obj);
		}
	}

	[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(ApplicationManager._003CExecuteLoadScene_003Ed__12))]
	[global::Cpp2ILInjected.Token(Token = "0x6000156")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE70B8", Offset = "0xFE70B8", Length = "0x80")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv20 = System.Xml.ValidateNames;\n\tgoto L_0018;\n\tv25 = System.Xml.ValidateNames;\n\tv26 = v25 + 0xFA8;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, buildIndex, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41);\n\tv44 = 1;\n\t*([302A9AE]) = v44;\nL_0018:\n\tv46 = new *([v20 @ X22_v1 (Il2CppClass<System.Xml.ValidateNames>)+FA8])();\n\tSystem.Object::.ctor(v46);\n\t*([v46 @ X0_v3 (System.Object)+10]) = 0;\n\tv50 = v46 + 0x20;\n\t*([v46 @ X0_v3 (System.Object)+20]) = this;\n\tv52 = 0xF3F1B4(v50, this, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41);\n\t*([v46 @ X0_v3 (System.Object)+28]) = buildIndex;\n\treturn v46;\n// 29 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private global::System.Collections.IEnumerator ExecuteLoadScene(int buildIndex)
	{
		//IL_000e: Expected I, but got O
		//IL_003c: Expected O, but got I
		nint num = (nint)typeof(global::System.Xml.ValidateNames);
		object obj = new object();
		_ = 0;
		object obj2 = (nint)obj + 32;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		return (global::System.Collections.IEnumerator)obj;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000157")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE7164", Offset = "0xFE7164", Length = "0x104")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0014;\n\tv15 = Il2CppMethodInfo;\n\tv16 = v15 + 0xC70;\n\tv17 = \"il2cpp_codegen_initialize_runtime_metadata\"(v16, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32);\n\tv39 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv40 = v39 + 0xA38;\n\tv34 = \"il2cpp_codegen_initialize_runtime_metadata\"(v40, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32);\n\tv37 = 1;\n\t*([302A9AF]) = v37;\nL_0014:\n\tv38 = ApplicationManager::get_appData();\n\tv42 = v38.playerData;\n\tv108 = Il2CppMethodInfo;\n\tv83 = v42.soundsOn ^ 1;\n\tv42.soundsOn = v83;\n\tgoto L_0028;\n\tv113 = \"il2cpp_codegen_runtime_class_init\"(v110, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32);\nL_0028:\n\tv150 = Singleton`1::get_Instance /* +1 sharing this address */(*([v108 @ X19_v3 (Il2CppMethodInfo)+C70]));\n\tgoto L_0038;\n\tv147 = \"l1\";\n\tv148 = v147 + 0x450;\n\tv149 = \"il2cpp_codegen_initialize_runtime_metadata\"(v148, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32);\n\tv151 = 1;\n\t*([302A9B0]) = v151;\nL_0038:\n\tv90 = ApplicationManager::get_appData();\n\tv101 = v90.playerData;\n\tv152 = \"l1\";\n\tif (v101.soundsOn) goto L_FFFFFFFF;\n\tgoto L_0058;\nL_0058:\n\tv159 = UnityEngine.Audio.AudioMixer::SetFloat(*([v150 @ X0_v9+28]), *([v152 @ X9_v4 (System.String)+450]), v54);\n\tv91 = ApplicationManager::get_appData();\n\tApplicationData::SavePlayerData(v91);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 67 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static void ToggleSounds()
	{
		//IL_00e7: Expected O, but got I
		//IL_00e7: Expected O, but got I
		ApplicationData applicationData = appData;
		PlayerData playerData = applicationData.playerData;
		nint num = 0;
		int soundsOn = (playerData.soundsOn ? 1 : 0) ^ 1;
		playerData.soundsOn = (byte)soundsOn != 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
		ApplicationData applicationData2 = appData;
		PlayerData playerData2 = applicationData2.playerData;
		string text = "l1";
		float value = (playerData2.soundsOn ? 0f : (-80f));
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v9+28]");
		nint num2 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X9_v4 (System.String)+450]");
		bool flag = ((global::UnityEngine.Audio.AudioMixer)num2).SetFloat((string)0, value);
		ApplicationData applicationData3 = appData;
		applicationData3.SavePlayerData();
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000158")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE72EC", Offset = "0xFE72EC", Length = "0x50")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv10 = ApplicationManager::get_appData();\n\tv13 = v10.playerData;\n\tv14 = ApplicationManager::get_appData();\n\tv17 = v14.playerData;\n\tv18 = v17.hapticOn ^ 1;\n\tv13.hapticOn = v18;\n\tv26 = ApplicationManager::get_appData();\n\tApplicationData::SavePlayerData(v26);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 22 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static void ToggleHaptic()
	{
		ApplicationData applicationData = appData;
		PlayerData playerData = applicationData.playerData;
		ApplicationData applicationData2 = appData;
		PlayerData playerData2 = applicationData2.playerData;
		int hapticOn = (playerData2.hapticOn ? 1 : 0) ^ 1;
		playerData.hapticOn = (byte)hapticOn != 0;
		ApplicationData applicationData3 = appData;
		applicationData3.SavePlayerData();
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000159")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE733C", Offset = "0xFE733C", Length = "0x3C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv12 = ApplicationManager::get_appData();\n\tApplicationData::ClearPlayerData(v12);\n\tv18 = ApplicationManager::get_appData();\n\tApplicationData::LoadPlayerData(v18);\n\tApplicationManager::ReloadActiveScene(this);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 17 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void ResetApplication()
	{
		ApplicationData applicationData = appData;
		applicationData.ClearPlayerData();
		ApplicationData applicationData2 = appData;
		applicationData2.LoadPlayerData();
		ReloadActiveScene();
	}

	[global::Cpp2ILInjected.Token(Token = "0x600015A")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE7378", Offset = "0xFE7378", Length = "0xA0")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tgoto L_0019;\n\tv23 = Il2CppMethodInfo;\n\tv24 = v23 + 0xC58;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv52 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv53 = v52 + 0xA30;\n\tv42 = \"il2cpp_codegen_initialize_runtime_metadata\"(v53, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv44 = 1;\n\t*([302A965]) = v44;\nL_0019:\n\tv45 = Il2CppMethodInfo;\n\tthis.sceneTransitionDuration = 0.75f;\n\tthis.isDeveloperMode = 1;\n\tv49 = *([v18 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A30]);\n\tv51 = *([v49 @ X0_v2+E0]) == 0;\n\tif (v51) goto L_0038;\n\tSingleton`1::.ctor /* +1 sharing this address */(this, *([v45 @ X21_v2 (Il2CppMethodInfo)+C58]));\n\treturn;\nL_0038:\n\tSingleton`1::.ctor /* +1 sharing this address */(this, *([v45 @ X21_v2 (Il2CppMethodInfo)+C58]));\n\treturn;\n// 38 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public ApplicationManager()
	{
		//IL_000e: Expected I, but got O
		//IL_005a: Expected O, but got I
		nint num = (nint)typeof(global::System.Collections.Generic.List<global::UnityEngine.UIElements.StyleSheets.Syntax.Expression>);
		nint num2 = 0;
		sceneTransitionDuration = 0.75f;
		isDeveloperMode = true;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A30]");
		object obj = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+E0]");
		if ((nint)0 != 0)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18ABE40 (Singleton`1::.ctor, and 1 more at this address)");
		}
		else
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18ABE40 (Singleton`1::.ctor, and 1 more at this address)");
		}
	}
}
