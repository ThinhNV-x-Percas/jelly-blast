[global::Cpp2ILInjected.Token(Token = "0x20000F4")]
public class LevelIntroScreen : Viewport
{
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x20000F5")]
	private sealed class _003CHandleStartShow_003Ed__8 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000506")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[global::Cpp2ILInjected.Token(Token = "0x4000507")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[global::Cpp2ILInjected.Token(Token = "0x4000508")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public LevelIntroScreen _003C_003E4__this;

		[global::Cpp2ILInjected.Token(Token = "0x17000056")]
		object global::System.Collections.Generic.IEnumerator<object>.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000472")]
			[global::Cpp2ILInjected.Address(RVA = "0x10209D8", Offset = "0x10209D8", Length = "0x8")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn this.<>2__current;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
			get
			{
				return _003C_003E2__current;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000057")]
		object global::System.Collections.IEnumerator.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000474")]
			[global::Cpp2ILInjected.Address(RVA = "0x1020A20", Offset = "0x1020A20", Length = "0x8")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn this.<>2__current;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
			get
			{
				return _003C_003E2__current;
			}
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x600046F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1020720", Offset = "0x1020720", Length = "0x2C")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tSystem.Object::.ctor(this);\n\tthis.<>1__state = <>1__state;\n\treturn;\n// 14 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public _003CHandleStartShow_003Ed__8(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x6000470")]
		[global::Cpp2ILInjected.Address(RVA = "0x10207D4", Offset = "0x10207D4", Length = "0x4")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn;\n")]
		void global::System.IDisposable.Dispose()
		{
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000471")]
		[global::Cpp2ILInjected.Address(RVA = "0x10207D8", Offset = "0x10207D8", Length = "0x200")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0016;\n\tv17 = Il2CppMethodInfo;\n\tv18 = v17 + 0x630;\n\tv19 = \"il2cpp_codegen_initialize_runtime_metadata\"(v18, methodInfo, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34);\n\tv50 = System.Xml.ValidateNames;\n\tv51 = v50 + 0x258;\n\tv36 = \"il2cpp_codegen_initialize_runtime_metadata\"(v51, methodInfo, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34);\n\tv38 = 1;\n\t*([302AAF3]) = v38;\nL_0016:\n\tv40 = this.<>4__this;\n\tv45 = this.<>1__state == 2;\n\tif (v45) goto L_005C;\n\tv56 = this.<>1__state == 1;\n\tif (v56) goto L_007C;\n\tv63 = this.<>1__state == 0;\n\tv64 = ~v63;\n\tif (v64) goto L_007A;\n\tthis.<>1__state = 0xFFFFFFFF;\n\tv95 = UnityEngine.Component::get_gameObject(v40.levelText);\n\tUnityEngine.GameObject::SetActive(v95, 0);\n\tv97 = UnityEngine.Component::get_gameObject(v40.goalDialog);\n\tUnityEngine.GameObject::SetActive(v97, 0);\n\tv184 = System.Xml.ValidateNames;\n\tv186 = new *([v184 @ X8_v16 (Il2CppClass<System.Xml.ValidateNames>)+258])();\n\tUnityEngine.WaitForSeconds::.ctor(v186, 0.5f);\n\tv197 = this + 0x18;\n\tthis.<>2__current = v186;\n\tv199 = 0xF3F1B4(v197, v186, 0, v22, v23, v24, v25, v26, 0.5f, v28, v29, v30, v31, v32, v33, v34);\n\tthis.<>1__state = 1;\n\treturn 1;\nL_005C:\n\tthis.<>1__state = 0xFFFFFFFF;\n\tv98 = UnityEngine.Component::get_gameObject(v40.goalDialog);\n\tUnityEngine.GameObject::SetActive(v98, 1);\n\tElasticScale::SetScale(v40.goalDialog, 0f);\n\tElasticScale::Pop(v40.goalDialog);\nL_007A:\n\treturn 0;\nL_007C:\n\tthis.<>1__state = 0xFFFFFFFF;\n\tv102 = UnityEngine.Component::get_gameObject(v40.levelText);\n\tUnityEngine.GameObject::SetActive(v102, 1);\n\tv177 = Il2CppMethodInfo;\n\tv104 = UnityEngine.Component::GetComponent /* +1 sharing this address */(v40.levelText, *([v177 @ X8_v8 (Il2CppMethodInfo)+630]));\n\tElasticScale::SetScale(v104, 0f);\n\tElasticScale::Pop(v104);\n\tv187 = System.Xml.ValidateNames;\n\tv190 = new *([v187 @ X8_v10 (Il2CppClass<System.Xml.ValidateNames>)+258])();\n\tUnityEngine.WaitForSeconds::.ctor(v190, 0.2f);\n\tv200 = this + 0x18;\n\tthis.<>2__current = v190;\n\tv202 = 0xF3F1B4(v200, v190, 0, v22, v23, v24, v25, v26, 0x3E4CCCCD, v28, v29, v30, v31, v32, v33, v34);\n\tthis.<>1__state = 2;\n\treturn 1;\n\treturnVal2 = new System.NullReferenceException();\n\treturn returnVal2;\n// 126 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		private bool MoveNext()
		{
			//IL_01e9: Expected I, but got O
			//IL_0209: Expected O, but got I
			//IL_00bb: Expected I, but got O
			//IL_00db: Expected O, but got I
			LevelIntroScreen levelIntroScreen = _003C_003E4__this;
			if (_003C_003E1__state != 2)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					global::UnityEngine.GameObject gameObject = levelIntroScreen.levelText.gameObject;
					gameObject.SetActive(value: true);
					nint num = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @111C708 (UnityEngine.Component::GetComponent, and 1 more at this address)");
					ElasticScale elasticScale = default(ElasticScale);
					elasticScale.SetScale(0f);
					elasticScale.Pop();
					global::UnityEngine.WaitForSeconds waitForSeconds = new global::UnityEngine.WaitForSeconds(0.2f);
					_003C_003E2__current = waitForSeconds;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
					_003C_003E1__state = 2;
					return true;
				}
				if (_003C_003E1__state == 0)
				{
					_003C_003E1__state = -1;
					global::UnityEngine.GameObject gameObject2 = levelIntroScreen.levelText.gameObject;
					gameObject2.SetActive(value: false);
					global::UnityEngine.GameObject gameObject3 = levelIntroScreen.goalDialog.gameObject;
					gameObject3.SetActive(value: false);
					global::UnityEngine.WaitForSeconds waitForSeconds2 = new global::UnityEngine.WaitForSeconds(0.5f);
					_003C_003E2__current = waitForSeconds2;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
					_003C_003E1__state = 1;
					return true;
				}
			}
			else
			{
				_003C_003E1__state = -1;
				global::UnityEngine.GameObject gameObject4 = levelIntroScreen.goalDialog.gameObject;
				gameObject4.SetActive(value: true);
				levelIntroScreen.goalDialog.SetScale(0f);
				levelIntroScreen.goalDialog.Pop();
			}
			return false;
		}

		bool global::System.Collections.IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x6000473")]
		[global::Cpp2ILInjected.Address(RVA = "0x10209E0", Offset = "0x10209E0", Length = "0x40")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv10 = Facebook.Unity.Windows.IWindowsFacebook + 0xF30;\n\tv11 = 0xF3F22C(v10, methodInfo, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26);\n\tv27 = new v11();\n\tSystem.NotSupportedException::.ctor(v27);\n\tv31 = Il2CppMethodInfo + 0x138;\n\tv32 = 0xF3F22C(v31, 0, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26);\n\tthrow v27;\n// 13 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		void global::System.Collections.IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0039: Expected O, but got I
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F22C");
			global::System.NotSupportedException ex = new global::System.NotSupportedException();
			object obj2 = (nint)0 + (nint)312;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F22C");
			throw ex;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x4000501")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public GoalUI goalPrefab;

	[global::Cpp2ILInjected.Token(Token = "0x4000502")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public global::UnityEngine.RectTransform goalParent;

	[global::Cpp2ILInjected.Token(Token = "0x4000503")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public GoalUI[] goals;

	[global::Cpp2ILInjected.Token(Token = "0x4000504")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public global::TMPro.TextMeshProUGUI levelText;

	[global::Cpp2ILInjected.Token(Token = "0x4000505")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public ElasticScale goalDialog;

	[global::Cpp2ILInjected.Token(Token = "0x600046A")]
	[global::Cpp2ILInjected.Address(RVA = "0x1020240", Offset = "0x1020240", Length = "0x12C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0021;\n\tv27 = CollectParticleData[];\n\tv28 = v27 + 0x990;\n\tv29 = \"il2cpp_codegen_initialize_runtime_metadata\"(v28, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\tv53 = Il2CppMethodInfo;\n\tv54 = v53 + 0xF60;\n\tv55 = \"il2cpp_codegen_initialize_runtime_metadata\"(v54, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\tv60 = Il2CppMethodInfo;\n\tv61 = v60 + 0xC90;\n\tv62 = \"il2cpp_codegen_initialize_runtime_metadata\"(v61, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\tv67 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv68 = v67 + 0xA48;\n\tv46 = \"il2cpp_codegen_initialize_runtime_metadata\"(v68, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\tv48 = 1;\n\t*([302AAEF]) = v48;\nL_0021:\n\tv49 = Il2CppMethodInfo;\n\tViewport::Awake(this);\n\tgoto L_002D;\n\tv63 = \"il2cpp_codegen_runtime_class_init\"(v56, v52, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\nL_002D:\n\tv66 = Singleton`1::get_Instance /* +1 sharing this address */(*([v49 @ X21_v2 (Il2CppMethodInfo)+C90]));\n\tv71 = CollectParticleData[];\n\tv73 = Il2CppMethodInfo;\n\tv75 = v66 + 0x90;\n\tv78 = new *([v71 @ X23_v1 (Il2CppClass<CollectParticleData[]>)+990])();\n\tSystem.Action::.ctor(v78, this, *([v73 @ X24_v1 (Il2CppMethodInfo)+F60]));\n\tv87 = System.Delegate::Combine(*([v75 @ X20_v4]), v78);\n\tv133 = v87 == 0;\n\tif (v133) goto L_0060;\n\tv155 = *([v87 @ X0_v11 (System.Delegate)]) != *([v71 @ X23_v1 (Il2CppClass<CollectParticleData[]>)+990]);\n\tif (v155) goto L_005F;\n\t*([v75 @ X20_v4]) = v87;\n\tv183 = *([v87 @ X0_v11 (System.Delegate)]) == *([v71 @ X23_v1 (Il2CppClass<CollectParticleData[]>)+990]);\n\tif (v183) goto L_006C;\nL_005F:\n\tthrow System.InvalidCastException;\nL_0060:\n\t*([v75 @ X20_v4]) = 0;\nL_006C:\n\tv131 = 0xF3F1B4(v75, v87, 0, 0, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 73 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	protected internal override void Awake()
	{
		base.Awake();
		global::GameManager gameManager = global::Singleton<global::GameManager>.Instance;
		if (gameManager != null)
		{
			gameManager.OnInit += OnInit;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x600046B")]
	[global::Cpp2ILInjected.Address(RVA = "0x102036C", Offset = "0x102036C", Length = "0x2BC")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv194 = *([302AAF0]);\n\tv30 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv32 = *([302AAF0]) & 1;\n\tv33 = v32 == 0;\n\tif (v33) goto L_0038;\n\tv83 = Il2CppMethodInfo + 0xC90;\n\tv36 = *([v30 @ X24_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A48]);\n\tv194 = *([v36 @ X0_v71+E0]);\n\tv38 = *([v36 @ X0_v71+E0]) == 0;\n\tif (v38) goto L_0042;\nL_001D:\n\tv82 = Singleton`1::get_Instance /* +1 sharing this address */(*([v83 @ X25_v4]));\n\tv75 = v82 == 0;\n\tv76 = ~v75;\n\tif (v76) goto L_0045;\n\tgoto L_00E4;\nL_0038:\n\t*([302AAF0]) = 1;\n\tv83 = Il2CppMethodInfo + 0xC90;\n\tv58 = *([v30 @ X24_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A48]);\n\tv194 = *([v58 @ X0_v67+E0]);\n\tv300 = *([v58 @ X0_v67+E0]) == 0;\n\tv62 = ~v300;\n\tif (v62) goto L_001D;\nL_0042:\n\tv82 = Singleton`1::get_Instance /* +1 sharing this address */(*([v68 @ X25_v6]));\nL_0045:\n\tv194 = *([v82 @ X0_v8+78]);\n\tv194 = *([v194 @ X8_v12 (System.Int32)+50]);\n\tv237 = CollectParticleData[];\n\tv239 = Il2CppMethodInfo;\n\tv242 = \"SzArrayNew\"(*([v237 @ X9_v4 (Il2CppClass<CollectParticleData[]>)+1E0]), *([v194 @ X8_v12 (System.Int32)+18]), v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56);\n\tv198 = this + 0x68;\n\tthis.goals = v242;\n\tv251 = 0xF3F1B4(v198, v242, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56);\n\tgoto L_0063;\n\tv328 = \"il2cpp_codegen_runtime_class_init\"(v322, v320, v304, v303, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56);\nL_0063:\n\tv168 = Singleton`1::get_Instance /* +1 sharing this address */(*([v83 @ X25_v4]));\n\tv194 = *([v168 @ X0_v16+78]);\n\tv194 = *([v194 @ X8_v12 (System.Int32)+50]);\n\tv194 = *([v194 @ X8_v12 (System.Int32)+18]);\n\tv116 = v152 >= *([v194 @ X8_v12 (System.Int32)+18]);\n\tif (v116) goto L_00BC;\n\tgoto L_0081;\n\tv384 = \"il2cpp_codegen_runtime_class_init\"(v380, v154, v102, v99, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56);\nL_0081:\n\tv169 = UnityEngine.Object::Instantiate /* +1 sharing this address */(this.goalPrefab, *([v239 @ X28_v4 (Il2CppMethodInfo)+60]));\n\tv387 = UnityEngine.Component::get_transform(v169);\n\tv171 = UnityEngine.Component::get_transform(this.goalParent);\n\tUnityEngine.Transform::SetParent(v387, v171, 0);\n\tGoalUI::Init(v169, v152);\n\tv108 = this.goals;\n\tv228 = 0xF3F36C(v169, GoalUI, 0, 0, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56);\n\tv231 = v228 == 0;\n\tif (v231) goto L_00E5;\n\tv108[v152 @ X21_v5 (System.Int32)] = v169;\n\tv402 = v108 + v150;\n\tv403 = 0xF3F1B4(v402, v169, 0, 0, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56);\n\tv152 = v152 + 1;\n\tv150 = v150 + 8;\n\tgoto L_0063;\n\tgoto L_FFFFFFFF;\nL_00BC:\n\tv173 = ApplicationManager::get_appData();\n\tv195 = v173.playerData;\n\tv194 = v195.levelIndex;\n\tv194 = v194 + 1;\n\tv392 = System.Int32::ToString(&v194 @ X8_v12 (System.Int32));\n\tv393 = \"IsCyrillic\";\n\tv174 = System.String::Concat(*([v393 @ X8_v16 (System.String)+7E8]), v392);\n\tv365 = TMPro.TMP_Text::set_text(this.levelText, v174);\n\treturn;\nL_00E4:\n\tv201 = new System.NullReferenceException();\nL_00E5:\n\tv236 = new System.ArrayTypeMismatchException();\n\tthrow v236;\n\tthrow System.IndexOutOfRangeException;\n// 164 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void OnInit()
	{
		//IL_001e: Expected I, but got O
		//IL_00f3: Expected O, but got I
		//IL_0103: Expected O, but got I
		//IL_005d: Expected O, but got I
		//IL_006d: Expected O, but got I
		//IL_019f: Expected I, but got O
		//IL_01bb: Expected O, but got I
		//IL_039f: Expected O, but got I
		//IL_030e: Expected O, but got I
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302AAF0]");
		int num = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302AAF0]");
		object obj3;
		object obj;
		if ((uint)((nuint)0u & (nuint)1u) != 0)
		{
			obj = (nint)0 + (nint)3216;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ X24_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A48]");
			object obj2 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X0_v71+E0]");
			num = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X0_v71+E0]");
			bool flag = (nint)0 == 0;
			obj3 = obj;
			if (!flag)
			{
				goto IL_00aa;
			}
		}
		else
		{
			_ = 1;
			obj = (nint)0 + (nint)3216;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ X24_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A48]");
			object obj4 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v67+E0]");
			num = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v67+E0]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			obj3 = obj;
			if (flag3)
			{
				goto IL_00aa;
			}
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
		obj = obj3;
		goto IL_0167;
		IL_03c6:
		global::System.ArrayTypeMismatchException ex = new global::System.ArrayTypeMismatchException();
		throw ex;
		IL_0167:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v8+78]");
		num = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v12 (System.Int32)+50]");
		num = 0;
		nint num4 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"SzArrayNew\"");
		GoalUI[] array = default(GoalUI[]);
		goals = array;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		int num5 = 32;
		int num6 = 0;
		global::UnityEngine.Component component = default(global::UnityEngine.Component);
		object obj6 = default(object);
		while (true)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v16+78]");
			num = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v12 (System.Int32)+50]");
			num = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v12 (System.Int32)+18]");
			num = 0;
			int num7 = num6;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v12 (System.Int32)+18]");
			if ((nint)num7 < (nint)0)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1171058 (UnityEngine.Object::Instantiate, and 1 more at this address)");
				global::UnityEngine.Transform transform = component.transform;
				global::UnityEngine.Transform parent = goalParent.transform;
				transform.SetParent(parent, worldPositionStays: false);
				((GoalUI)component).Init(num6);
				GoalUI[] array2 = goals;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F36C");
				if (obj6 == null)
				{
					break;
				}
				array2[num6] = (GoalUI)component;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
				num6++;
				num5 += 8;
				continue;
			}
			ApplicationData appData = ApplicationManager.appData;
			PlayerData playerData = appData.playerData;
			num = playerData.levelIndex;
			string text = (num + 1).ToString();
			string text2 = "IsCyrillic";
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X8_v16 (System.String)+7E8]");
			string text3 = (string)null + text;
			levelText.text = text3;
			return;
		}
		goto IL_03c6;
		IL_00aa:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
		object obj8 = default(object);
		if (obj8 != null)
		{
			goto IL_0167;
		}
		global::System.NullReferenceException ex2 = new global::System.NullReferenceException();
		goto IL_03c6;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600046C")]
	[global::Cpp2ILInjected.Address(RVA = "0x1020628", Offset = "0x1020628", Length = "0x80")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = TMPro.KerningTable+<>c__DisplayClass3_0;\n\tgoto L_0017;\n\tv23 = TMPro.KerningTable+<>c__DisplayClass3_0;\n\tv24 = v23 + 0x180;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv43 = 1;\n\t*([302AAF1]) = v43;\nL_0017:\n\tv45 = new *([v18 @ X21_v1 (Il2CppClass<TMPro.KerningTable+<>c__DisplayClass3_0>)+180])();\n\tSystem.Object::.ctor(v45);\n\t*([v45 @ X0_v3 (System.Object)+10]) = 0;\n\tv49 = v45 + 0x20;\n\t*([v45 @ X0_v3 (System.Object)+20]) = this;\n\tv51 = 0xF3F1B4(v49, this, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv61 = UnityEngine.MonoBehaviour::StartCoroutine(this, v45);\n\treturn;\n// 30 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	protected internal override void OnStartShow()
	{
		//IL_000e: Expected I, but got O
		//IL_0041: Expected O, but got I
		global::UnityEngine.Coroutine coroutine = StartCoroutine(HandleStartShow());
	}

	[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(LevelIntroScreen._003CHandleStartShow_003Ed__8))]
	[global::Cpp2ILInjected.Token(Token = "0x600046D")]
	[global::Cpp2ILInjected.Address(RVA = "0x10206A8", Offset = "0x10206A8", Length = "0x78")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = TMPro.KerningTable+<>c__DisplayClass3_0;\n\tgoto L_0017;\n\tv23 = TMPro.KerningTable+<>c__DisplayClass3_0;\n\tv24 = v23 + 0x180;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv43 = 1;\n\t*([302AAF1]) = v43;\nL_0017:\n\tv45 = new *([v18 @ X21_v1 (Il2CppClass<TMPro.KerningTable+<>c__DisplayClass3_0>)+180])();\n\tSystem.Object::.ctor(v45);\n\t*([v45 @ X0_v3 (System.Object)+10]) = 0;\n\tv49 = v45 + 0x20;\n\t*([v45 @ X0_v3 (System.Object)+20]) = this;\n\tv51 = 0xF3F1B4(v49, this, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\treturn v45;\n// 28 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private global::System.Collections.IEnumerator HandleStartShow()
	{
		//IL_000e: Expected I, but got O
		//IL_0037: Expected O, but got I
		_003CHandleStartShow_003Ed__8 stateMachine = new _003CHandleStartShow_003Ed__8(0);
		stateMachine._003C_003E4__this = this;
		return stateMachine;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600046E")]
	[global::Cpp2ILInjected.Address(RVA = "0x102074C", Offset = "0x102074C", Length = "0x88")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv16 = 0x302A000;\n\tv18 = System.Xml.ValidateNames;\n\tv20 = *([302AAF2]) & 1;\n\tv21 = v20 == 0;\n\tif (v21) goto L_0023;\n\tv22 = *([v18 @ X21_v1 (Il2CppClass<System.Xml.ValidateNames>)+198]);\n\tv24 = *([v22 @ X0_v10+E0]) == 0;\n\tif (v24) goto L_0033;\nL_001D:\n\tViewport::.ctor(this);\n\treturn;\nL_0023:\n\t*([v16 @ X20_v1+AF2]) = 1;\n\tv44 = *([v18 @ X21_v1 (Il2CppClass<System.Xml.ValidateNames>)+198]);\n\tv62 = *([v44 @ X0_v7+E0]) == 0;\n\tv46 = ~v62;\n\tif (v46) goto L_001D;\nL_0033:\n\tViewport::.ctor(this);\n\treturn;\n// 36 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public LevelIntroScreen()
	{
		//IL_0009: Expected O, but got I4
		//IL_0017: Expected I, but got O
		//IL_009c: Expected O, but got I
		//IL_005a: Expected O, but got I
		object obj = 50503680;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302AAF2]");
		if ((uint)((nuint)0u & (nuint)1u) != 0)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X21_v1 (Il2CppClass<System.Xml.ValidateNames>)+198]");
			object obj2 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X0_v10+E0]");
			if ((nint)0 != 0)
			{
				goto IL_007f;
			}
		}
		else
		{
			_ = 1;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X21_v1 (Il2CppClass<System.Xml.ValidateNames>)+198]");
			object obj3 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v7+E0]");
			if ((nint)0 != 0)
			{
				goto IL_007f;
			}
		}
		return;
		IL_007f:
		;
	}
}
