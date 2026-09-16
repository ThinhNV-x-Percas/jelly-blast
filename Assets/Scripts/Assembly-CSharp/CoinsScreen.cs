[global::Cpp2ILInjected.Token(Token = "0x20000E5")]
public class CoinsScreen : Viewport
{
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x20000E6")]
	private sealed class _003CHandleStartShow_003Ed__21 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
	{
		[global::Cpp2ILInjected.Token(Token = "0x40004C7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[global::Cpp2ILInjected.Token(Token = "0x40004C8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[global::Cpp2ILInjected.Token(Token = "0x40004C9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public CoinsScreen _003C_003E4__this;

		[global::Cpp2ILInjected.Token(Token = "0x17000048")]
		object global::System.Collections.Generic.IEnumerator<object>.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000426")]
			[global::Cpp2ILInjected.Address(RVA = "0x101D338", Offset = "0x101D338", Length = "0x8")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn this.<>2__current;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
			get
			{
				return _003C_003E2__current;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000049")]
		object global::System.Collections.IEnumerator.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000428")]
			[global::Cpp2ILInjected.Address(RVA = "0x101D380", Offset = "0x101D380", Length = "0x8")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn this.<>2__current;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
			get
			{
				return _003C_003E2__current;
			}
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x6000423")]
		[global::Cpp2ILInjected.Address(RVA = "0x101CBE0", Offset = "0x101CBE0", Length = "0x2C")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tSystem.Object::.ctor(this);\n\tthis.<>1__state = <>1__state;\n\treturn;\n// 14 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public _003CHandleStartShow_003Ed__21(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x6000424")]
		[global::Cpp2ILInjected.Address(RVA = "0x101D1FC", Offset = "0x101D1FC", Length = "0x4")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn;\n")]
		void global::System.IDisposable.Dispose()
		{
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000425")]
		[global::Cpp2ILInjected.Address(RVA = "0x101D200", Offset = "0x101D200", Length = "0x138")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0015;\n\tv21 = System.Xml.ValidateNames;\n\tv22 = v21 + 0x258;\n\tv23 = \"il2cpp_codegen_initialize_runtime_metadata\"(v22, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv41 = 1;\n\t*([302AAD4]) = v41;\nL_0015:\n\tv43 = this.<>4__this;\n\tv44 = this.<>1__state == 0;\n\tif (v44) goto L_004F;\n\tv54 = this.<>1__state != 1;\n\tif (v54) goto L_0040;\n\tthis.<>1__state = 0xFFFFFFFF;\n\tv115 = UnityEngine.Component::get_gameObject(v43.coinCountElasticScale);\n\tUnityEngine.GameObject::SetActive(v115, 1);\n\tElasticScale::SetScale(v43.coinCountElasticScale, 0f);\n\tElasticScale::Pop(v43.coinCountElasticScale);\nL_0040:\n\tv74 = this.<>1__state == 0;\n\treturn v74;\nL_004F:\n\tthis.<>1__state = 0xFFFFFFFF;\n\tv117 = UnityEngine.Component::get_gameObject(v43.coinCountElasticScale);\n\tUnityEngine.GameObject::SetActive(v117, 0);\n\tv166 = System.Xml.ValidateNames;\n\tv169 = new *([v166 @ X8_v5 (Il2CppClass<System.Xml.ValidateNames>)+258])();\n\tUnityEngine.WaitForSeconds::.ctor(v169, 0.3f);\n\tv174 = this + 0x18;\n\tthis.<>2__current = v169;\n\tv176 = 0xF3F1B4(v174, v169, 0, v26, v27, v28, v29, v30, 0x3E99999A, v32, v33, v34, v35, v36, v37, v38);\n\tthis.<>1__state = 1;\n\tv147 = this.<>1__state == 0;\n\treturn v147;\n\treturnVal2 = new System.NullReferenceException();\n\treturn returnVal2;\n// 97 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		private bool MoveNext()
		{
			//IL_00e5: Expected I, but got O
			//IL_0105: Expected O, but got I
			CoinsScreen coinsScreen = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					global::UnityEngine.GameObject gameObject = coinsScreen.coinCountElasticScale.gameObject;
					gameObject.SetActive(value: true);
					coinsScreen.coinCountElasticScale.SetScale(0f);
					coinsScreen.coinCountElasticScale.Pop();
				}
				return _003C_003E1__state == 0;
			}
			_003C_003E1__state = -1;
			global::UnityEngine.GameObject gameObject2 = coinsScreen.coinCountElasticScale.gameObject;
			gameObject2.SetActive(value: false);
			global::UnityEngine.WaitForSeconds waitForSeconds = new global::UnityEngine.WaitForSeconds(0.3f);
			_003C_003E2__current = waitForSeconds;
			_003C_003E1__state = 1;
			return _003C_003E1__state == 0;
		}

		bool global::System.Collections.IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x6000427")]
		[global::Cpp2ILInjected.Address(RVA = "0x101D340", Offset = "0x101D340", Length = "0x40")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv10 = Facebook.Unity.Windows.IWindowsFacebook + 0xF30;\n\tv11 = 0xF3F22C(v10, methodInfo, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26);\n\tv27 = new v11();\n\tSystem.NotSupportedException::.ctor(v27);\n\tv31 = Il2CppMethodInfo + 0x40;\n\tv32 = 0xF3F22C(v31, 0, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26);\n\tthrow v27;\n// 13 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		void global::System.Collections.IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0039: Expected O, but got I
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F22C");
			global::System.NotSupportedException ex = new global::System.NotSupportedException();
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F22C");
			throw ex;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x40004B4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public global::TMPro.TextMeshProUGUI coinCountText;

	[global::Cpp2ILInjected.Token(Token = "0x40004B5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public ElasticScale coinCountElasticScale;

	[global::Cpp2ILInjected.Token(Token = "0x40004B6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public CoinParticle coinParticlePrefab;

	[global::Cpp2ILInjected.Token(Token = "0x40004B7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public int maxCoinParticleCount;

	[global::Cpp2ILInjected.Token(Token = "0x40004B8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x74")]
	public float coinParticleRadius;

	[global::Cpp2ILInjected.Token(Token = "0x40004B9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public float maxCoinParticleVelocity;

	[global::Cpp2ILInjected.Token(Token = "0x40004BA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	private CoinParticle[] coinParticles;

	[global::Cpp2ILInjected.Token(Token = "0x40004BB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public float coinParticleCollectionRadius;

	[global::Cpp2ILInjected.Token(Token = "0x40004BC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x8C")]
	public float coinParticleForce;

	[global::Cpp2ILInjected.Token(Token = "0x40004BD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public float maxStartDelay;

	[global::Cpp2ILInjected.Token(Token = "0x40004BE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x94")]
	public float minStartCollectionDelay;

	[global::Cpp2ILInjected.Token(Token = "0x40004BF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public float maxStartCollectionDelay;

	[global::Cpp2ILInjected.Token(Token = "0x40004C0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x9C")]
	public float scaleDuration;

	[global::Cpp2ILInjected.Token(Token = "0x40004C1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	private float[] startTimes;

	[global::Cpp2ILInjected.Token(Token = "0x40004C2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	private float[] collectionStartTimes;

	[global::Cpp2ILInjected.Token(Token = "0x40004C3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public int coinsCollected;

	[global::Cpp2ILInjected.Token(Token = "0x40004C4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB4")]
	public int displayedCoinCount;

	[global::Cpp2ILInjected.Token(Token = "0x40004C5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	private int particleCount;

	[global::Cpp2ILInjected.Token(Token = "0x40004C6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xBC")]
	private int particlesCollected;

	[global::Cpp2ILInjected.Token(Token = "0x600041D")]
	[global::Cpp2ILInjected.Address(RVA = "0x101C51C", Offset = "0x101C51C", Length = "0x130")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0018;\n\tv21 = Il2CppMethodInfo;\n\tv22 = v21 + 0xC90;\n\tv23 = \"il2cpp_codegen_initialize_runtime_metadata\"(v22, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv45 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv46 = v45 + 0xA48;\n\tv40 = \"il2cpp_codegen_initialize_runtime_metadata\"(v46, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv42 = 1;\n\t*([302AB36]) = v42;\nL_0018:\n\tv44 = ApplicationManager::get_appData();\n\tv48 = v44.playerData;\n\tv71 = Il2CppMethodInfo;\n\tgoto L_002A;\n\tv75 = \"il2cpp_codegen_runtime_class_init\"(v72, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\nL_002A:\n\tv58 = Singleton`1::get_Instance /* +1 sharing this address */(*([v71 @ X21_v2 (Il2CppMethodInfo)+C90]));\n\tv65 = v48.coinCount - *([v58 @ X0_v9+A0]);\n\tthis.displayedCoinCount = v65;\n\tv68 = this.coinCountText;\n\tv59 = NumberFormatter::FormatNumber(v65);\n\tv106 = *([v68 @ X20_v4 (TMPro.TextMeshProUGUI)]);\n\tv109 = TMPro.TMP_Text::set_text(v68, v59);\n\tthis.particlesCollected = 0;\n\tv112 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tgoto L_004B;\n\tv116 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv117 = v116 + 0x1E0;\n\tv118 = \"il2cpp_codegen_initialize_runtime_metadata\"(v117, v105, v107, v26, v27, v28, v29, v30, v51, v32, v33, v34, v35, v36, v37, v38);\n\tv120 = 1;\n\t*([302AB37]) = v120;\nL_004B:\n\tv122 = new *([v112 @ X21_v4 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+1E0])();\n\tSystem.Object::.ctor(v122);\n\t*([v122 @ X0_v16 (System.Object)+10]) = 0;\n\tv126 = v122 + 0x20;\n\t*([v122 @ X0_v16 (System.Object)+20]) = this;\n\tv128 = 0xF3F1B4(v126, this, *([v106 @ X8_v8 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]), v26, v27, v28, v29, v30, v65, v32, v33, v34, v35, v36, v37, v38);\n\tv92 = UnityEngine.MonoBehaviour::StartCoroutine(this, v122);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 60 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	protected internal override void OnStartShow()
	{
		//IL_0057: Expected I4, but got F4
		//IL_007b: Expected I, but got O
		//IL_00a1: Expected I, but got O
		//IL_00e2: Expected O, but got I
		ApplicationData appData = ApplicationManager.appData;
		PlayerData playerData = appData.playerData;
		nint num = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
		float num2 = playerData.coinCount;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v9+A0]");
		float num3 = num2 - 0f;
		displayedCoinCount = (int)num3;
		global::TMPro.TextMeshProUGUI textMeshProUGUI = coinCountText;
		string text = NumberFormatter.FormatNumber(num3);
		textMeshProUGUI.text = text;
		particlesCollected = 0;
		global::UnityEngine.Coroutine coroutine = StartCoroutine(HandleStartShow());
	}

	[global::Cpp2ILInjected.Token(Token = "0x600041E")]
	[global::Cpp2ILInjected.Address(RVA = "0x101C724", Offset = "0x101C724", Length = "0x4BC")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0032;\n\tv39 = CollectParticleData[];\n\tv40 = v39 + 0xCF8;\n\tv41 = \"il2cpp_codegen_initialize_runtime_metadata\"(v40, count, methodInfo, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55);\n\tv71 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv72 = v71 + 0xFF8;\n\tv73 = \"il2cpp_codegen_initialize_runtime_metadata\"(v72, count, methodInfo, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55);\n\tv207 = Il2CppMethodInfo;\n\tv208 = v207 + 0x40;\n\tv209 = \"il2cpp_codegen_initialize_runtime_metadata\"(v208, count, methodInfo, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55);\n\tv288 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv289 = v288 + 0xFD8;\n\tv290 = \"il2cpp_codegen_initialize_runtime_metadata\"(v289, count, methodInfo, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55);\n\tv302 = CollectParticleData[];\n\tv303 = v302 + 0x4B8;\n\tv304 = \"il2cpp_codegen_initialize_runtime_metadata\"(v303, count, methodInfo, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55);\n\tv307 = Il2CppMethodInfo;\n\tv308 = v307 + 0xC70;\n\tv309 = \"il2cpp_codegen_initialize_runtime_metadata\"(v308, count, methodInfo, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55);\n\tv314 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv315 = v314 + 0xA38;\n\tv316 = \"il2cpp_codegen_initialize_runtime_metadata\"(v315, count, methodInfo, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55);\n\tv321 = \"__sort-indicator\";\n\tv322 = v321 + 0xD70;\n\tv57 = \"il2cpp_codegen_initialize_runtime_metadata\"(v322, count, methodInfo, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55);\n\tv59 = 1;\n\t*([302AAD1]) = v59;\nL_0032:\n\tthis.coinsCollected = count;\n\tv70 = count < 1;\n\tif (v70) goto L_01C6;\n\tv76 = Il2CppMethodInfo;\n\tv78 = CollectParticleData[];\n\tv174 = this.maxCoinParticleCount;\n\tv83 = count - this.maxCoinParticleCount;\n\tv84 = v83 < 0;\n\tv86 = count ^ this.maxCoinParticleCount;\n\tv87 = count ^ v83;\n\tv88 = v86 & v87;\n\tv89 = v88 < 0;\n\tv90 = v84 == v89;\n\tv91 = ~v90;\n\tv92 = ~v91;\n\tif (v92) goto L_0057;\n\tgoto L_0057;\nL_0057:\n\tv292 = count < 5;\n\tv293 = ~v292;\n\tv301 = ~v293;\n\tv144 = ~v301;\n\tif (v144) goto L_0068;\n\tgoto L_0068;\nL_0068:\n\tthis.particleCount = v174;\n\tgoto L_0070;\n\tv317 = \"il2cpp_codegen_runtime_class_init\"(v310, count, methodInfo, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55);\nL_0070:\n\tv320 = Singleton`1::get_Instance /* +1 sharing this address */(*([v76 @ X22_v3 (Il2CppMethodInfo)+C70]));\n\tv325 = new *([v78 @ X21_v4 (Il2CppClass<CollectParticleData[]>)+CF8])();\n\tAudioClipSettings::.ctor(v325);\n\tv325.pitch = 1.25f;\n\tv469 = \"__sort-indicator\";\n\tv471 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv472 = CollectParticleData[];\n\tAudioManager::PlayClip(v320, *([v469 @ X8_v11 (System.String)+D70]), v325);\n\tv526 = \"SzArrayNew\"(*([v471 @ X22_v8 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+FF8]), this.particleCount, v325, 0, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55);\n\tv533 = this + 0x80;\n\tthis.coinParticles = v526;\n\tv534 = 0xF3F1B4(v533, v526, v325, 0, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55);\n\tv537 = \"SzArrayNew\"(*([v472 @ X23_v6 (Il2CppClass<CollectParticleData[]>)+4B8]), this.particleCount, v325, 0, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55);\n\tv192 = this + 0xA8;\n\tthis.collectionStartTimes = v537;\n\tv541 = 0xF3F1B4(v192, v537, v325, 0, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55);\n\tv544 = \"SzArrayNew\"(*([v472 @ X23_v6 (Il2CppClass<CollectParticleData[]>)+4B8]), this.particleCount, v325, 0, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55);\n\tv190 = this + 0xA0;\n\tthis.startTimes = v544;\n\tv181 = 0xF3F1B4(v190, v544, v325, 0, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55);\n\tv147 = this.particleCount < 1;\n\tif (v147) goto L_01C6;\n\tv551 = System.Xml.ValidateNames;\nL_00BB:\n\tgoto L_00BD;\n\tv563 = \"il2cpp_codegen_runtime_class_init\"(v559, v553, v378, v376, v44, v45, v46, v47, v356, v351, v347, v343, v52, v53, v54, v55);\nL_00BD:\n\tv565 = Il2CppMethodInfo;\n\tv445 = UnityEngine.Object::Instantiate /* +1 sharing this address */(this.coinParticlePrefab, *([v565 @ X8_v18 (Il2CppMethodInfo)+40]));\n\tv568 = UnityEngine.Component::get_transform(v445);\n\tv446 = UnityEngine.Component::get_transform(this);\n\tUnityEngine.Transform::SetParent(v568, v446, 0);\n\tgoto L_00DD;\n\tv574 = v179;\n\tv575 = \"il2cpp_codegen_initialize_runtime_metadata\"(v574, v385, v379, v133, v44, v45, v46, v47, v356, v351, v347, v343, v52, v53, v54, v55);\n\tv576 = 1;\n\t*([2DD4424]) = v576;\nL_00DD:\n\tv577 = *([v551 @ X22_v10 (Il2CppClass<System.Xml.ValidateNames>)+98]);\n\tv578 = *([v577 @ X8_v22+B8]);\n\t// 227 MakeStruct v118 @ AGG101C988_1_v6 (UnityEngine.Vector2), typeof(UnityEngine.Vector2), [v578 @ X8_v23], [v578 @ X8_v23+4]\n\tUnityEngine.RectTransform::set_anchoredPosition(*([v445 @ X0_v34 (UnityEngine.Component)+20]), v118);\n\tgoto L_00F3;\n\tv584 = System.Xml.ValidateNames;\n\tv585 = v584 + 0xD0;\n\tv586 = \"il2cpp_codegen_initialize_runtime_metadata\"(v585, v386, v379, v133, v44, v45, v46, v47, v361, v354, v347, v343, v52, v53, v54, v55);\n\tv588 = 1;\n\t*([2DD4419]) = v588;\nL_00F3:\n\tv589 = System.Xml.ValidateNames;\n\tv591 = *([v589 @ X8_v27 (Il2CppClass<System.Xml.ValidateNames>)+D0]);\n\tv592 = *([v591 @ X8_v29+B8]);\n\t// 252 MakeStruct v113 @ AGG101C9D8_1_v6 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), [v592 @ X8_v30], [v592 @ X8_v30+4], [v592 @ X8_v30+8]\n\tUnityEngine.Transform::set_localScale(*([v445 @ X0_v34 (UnityEngine.Component)+20]), v113);\n\tv599 = UnityEngine.Random::Range(0, 0x168);\n\t*([v445 @ X0_v34 (UnityEngine.Component)+50]) = v599;\n\tv622 = UnityEngine.Random::get_insideUnitCircle();\n\tv606 = *([2DD4421]) == 0;\n\tif (v606) goto L_01A9;\n\tgoto L_0111;\nL_0111:\n\tv636 = v622 * v622;\n\tv637 = v622.y * v622.y;\n\tv638 = v636 + v637;\n\tv115 = UnityEngine.Mathf::Sqrt(v638);\n\tv389 = v115 <= 0x3727C5AC;\n\tif (v389) goto L_012C;\n\t// 294 NotImplemented \"Instruction DUP not yet implemented.\"\n\tv338 = v622 / v622.y;\n\tgoto L_0137;\nL_012C:\n\tgoto L_0131;\n\tv667 = v179;\n\tv668 = \"il2cpp_codegen_initialize_runtime_metadata\"(v667, v384, v136, v133, v44, v45, v46, v47, v622, v619, v115, v110, v52, v53, v54, v55);\n\tv670 = 1;\n\t*([2DD4424]) = v670;\nL_0131:\n\tv671 = *([v551 @ X22_v10 (Il2CppClass<System.Xml.ValidateNames>)+98]);\n\tv663 = *([v671 @ X8_v50+B8]);\n\tv338 = *([v663 @ X8_v51]);\nL_0137:\n\tv666 = UnityEngine.Random::Range(0.75f, 1f);\n\tv672 = v338 * v673;\n\tv357 = v672 * v654;\n\t*([v445 @ X0_v34 (UnityEngine.Component)+30]) = v357;\n\tv515 = 0xF3F36C(v445, CoinParticle, 0, 0, v44, v45, v46, v47, v357, this.maxCoinParticleVelocity, v115, 0x3727C5AC, v52, v53, v54, v55);\n\tv517 = v515 == 0;\n\tif (v517) goto L_01C9;\n\tv676 = this.coinParticles + v372;\n\t*([v676 @ X0_v57]) = v445;\n\tv677 = 0xF3F1B4(v676, v445, 0, 0, v44, v45, v46, v47, v357, this.maxCoinParticleVelocity, v115, 0x3727C5AC, v52, v53, v54, v55);\n\tv370 = this.startTimes;\n\tv679 = UnityEngine.Time::get_time();\n\tv358 = UnityEngine.Random::Range(0f, this.maxStartDelay);\n\tv359 = v679 + v358;\n\t*([v370 @ X25_v9 (System.Single[])+v374 @ X28_v7 (System.Int32)*4]) = v359;\n\tv463 = this.startTimes;\n\tv126 = this.collectionStartTimes;\n\tv360 = UnityEngine.Random::Range(this.minStartCollectionDelay, this.maxStartCollectionDelay);\n\tv122 = *([v463 @ X8_v45 (System.Single[])+v374 @ X28_v7 (System.Int32)*4]) + v360;\n\t*([v126 @ X25_v10 (System.Single[])+v374 @ X28_v7 (System.Int32)*4]) = v122;\n\tv175 = v374 - 7;\n\tv374 = v374 + 1;\n\tv372 = v372 + 8;\n\tv148 = v175 < this.particleCount;\n\tif (v148) goto L_00BB;\n\tgoto L_01C6;\nL_01A9:\n\t*([2DD4421]) = 1;\n\tgoto L_0111;\n\tv618 = v641;\n\tv617 = v642;\n\tv629 = \"il2cpp_codegen_runtime_class_init\"(v643, v384, v136, v133, v44, v45, v46, v47, v642, v641, v594, v343, v52, v53, v54, v55);\n\tv621 = v618;\n\tv624 = v617;\n\tgoto L_0111;\nL_01C6:\n\treturn;\n\tv468 = new System.NullReferenceException();\n\tv523 = new System.IndexOutOfRangeException();\nL_01C9:\n\tv530 = new System.ArrayTypeMisma\n// ... truncated")]
	public void ShowCoinAnim(int count)
	{
		//IL_0019: Expected I, but got O
		//IL_010e: Expected I, but got O
		//IL_011c: Expected I, but got O
		//IL_0135: Expected O, but got I
		//IL_0150: Expected O, but got I
		//IL_017f: Expected O, but got I
		//IL_01ae: Expected O, but got I
		//IL_01ef: Expected I, but got O
		//IL_025e: Expected O, but got I
		//IL_026e: Expected O, but got I
		//IL_027b: Expected F4, but got O
		//IL_0290: Expected F4, but got I
		//IL_02a5: Expected O, but got I
		//IL_02b8: Expected I, but got O
		//IL_02c8: Expected O, but got I
		//IL_02d8: Expected O, but got I
		//IL_02e5: Expected F4, but got O
		//IL_02fa: Expected F4, but got I
		//IL_030f: Expected F4, but got I
		//IL_0324: Expected O, but got I
		//IL_0614: Expected O, but got I
		//IL_0624: Expected O, but got I
		//IL_062c: Expected F4, but got O
		//IL_0448: Expected O, but got I
		coinsCollected = count;
		if (count < 1)
		{
			return;
		}
		nint num = 0;
		int num3 = maxCoinParticleCount;
		int num4 = count - maxCoinParticleCount;
		bool flag = num4 < 0;
		int num5 = count ^ maxCoinParticleCount;
		int num6 = count ^ num4;
		int num7 = num5 & num6;
		bool flag2 = num7 < 0;
		if (flag != flag2)
		{
			num3 = count;
		}
		if (count < 5)
		{
			num3 = 5;
		}
		particleCount = num3;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
		AudioClipSettings audioClipSettings = new AudioClipSettings();
		audioClipSettings.pitch = 1.25f;
		string text = "__sort-indicator";
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X8_v11 (System.String)+D70]");
		AudioManager audioManager = default(AudioManager);
		audioManager.PlayClip(null, audioClipSettings);
		CoinParticle[] array = new CoinParticle[particleCount];
		coinParticles = array;
		float[] array2 = new float[particleCount];
		collectionStartTimes = array2;
		float[] array3 = new float[particleCount];
		startTimes = array3;
		if (particleCount < 1)
		{
			return;
		}
		int num11 = 32;
		int num12 = 8;
		CoinParticle component = null;
		global::UnityEngine.Vector2 anchoredPosition = default(global::UnityEngine.Vector2);
		global::UnityEngine.Vector3 localScale = default(global::UnityEngine.Vector3);
		object obj10 = default(object);
		object obj11 = default(object);
		object obj12 = default(object);
		while (true)
		{
			component = global::UnityEngine.Object.Instantiate(coinParticlePrefab);
			global::UnityEngine.Transform transform = component.transform;
			global::UnityEngine.Transform parent = base.transform;
			transform.SetParent(parent, worldPositionStays: false);
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v551 @ X22_v10 (Il2CppClass<System.Xml.ValidateNames>)+98]");
			object obj4 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X8_v22+B8]");
			object obj5 = 0;
			anchoredPosition.x = (float)obj5;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v578 @ X8_v23+4]");
			anchoredPosition.y = 0f;
			component.rt.anchoredPosition = anchoredPosition;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X8_v27 (Il2CppClass<System.Xml.ValidateNames>)+D0]");
			object obj6 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ X8_v29+B8]");
			object obj7 = 0;
			localScale.x = (float)obj7;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ X8_v30+4]");
			localScale.y = 0f;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ X8_v30+8]");
			localScale.z = 0f;
			component.rt.localScale = localScale;
			int num15 = global::UnityEngine.Random.Range(0, 360);
			global::UnityEngine.Vector2 insideUnitCircle = global::UnityEngine.Random.insideUnitCircle;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2DD4421]");
			if ((nint)0 == 0)
			{
				_ = 1;
			}
			float num16 = insideUnitCircle.x * insideUnitCircle.x;
			float num17 = insideUnitCircle.y * insideUnitCircle.y;
			float f = num16 + num17;
			float num18 = global::UnityEngine.Mathf.Sqrt(f);
			float num19;
			if (num18 > 1E-05f)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				num19 = insideUnitCircle.x / insideUnitCircle.y;
			}
			else
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v551 @ X22_v10 (Il2CppClass<System.Xml.ValidateNames>)+98]");
				object obj8 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v671 @ X8_v50+B8]");
				object obj9 = 0;
				num19 = (float)obj9;
			}
			float num20 = global::UnityEngine.Random.Range(0.75f, 1f);
			float num21 = num19 * (float)obj10;
			float num22 = num21 * (float)obj11;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F36C");
			if (obj12 == null)
			{
				break;
			}
			coinParticles[(num11 - 32) / 8] = component;
			float[] array4 = startTimes;
			float time = global::UnityEngine.Time.time;
			float num23 = global::UnityEngine.Random.Range(0f, maxStartDelay);
			float num24 = time + num23;
			float[] array5 = startTimes;
			float[] array6 = collectionStartTimes;
			float num25 = global::UnityEngine.Random.Range(minStartCollectionDelay, maxStartCollectionDelay);
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X8_v45 (System.Single[])+v374 @ X28_v7 (System.Int32)*4]");
			float num26 = 0f + num25;
			int num27 = num12 - 7;
			num12++;
			num11 += 8;
			if (num27 >= particleCount)
			{
				return;
			}
		}
		global::System.ArrayTypeMismatchException ex = new global::System.ArrayTypeMismatchException();
		throw ex;
	}

	[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(CoinsScreen._003CHandleStartShow_003Ed__21))]
	[global::Cpp2ILInjected.Token(Token = "0x600041F")]
	[global::Cpp2ILInjected.Address(RVA = "0x101C6AC", Offset = "0x101C6AC", Length = "0x78")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tgoto L_0017;\n\tv23 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv24 = v23 + 0x1E0;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv43 = 1;\n\t*([302AB37]) = v43;\nL_0017:\n\tv45 = new *([v18 @ X21_v1 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+1E0])();\n\tSystem.Object::.ctor(v45);\n\t*([v45 @ X0_v3 (System.Object)+10]) = 0;\n\tv49 = v45 + 0x20;\n\t*([v45 @ X0_v3 (System.Object)+20]) = this;\n\tv51 = 0xF3F1B4(v49, this, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\treturn v45;\n// 28 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private global::System.Collections.IEnumerator HandleStartShow()
	{
		//IL_000e: Expected I, but got O
		//IL_0037: Expected O, but got I
		_003CHandleStartShow_003Ed__21 _003CHandleStartShow_003Ed__ = new _003CHandleStartShow_003Ed__21(0);
		_003CHandleStartShow_003Ed__._003C_003E4__this = this;
		return _003CHandleStartShow_003Ed__;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000420")]
	[global::Cpp2ILInjected.Address(RVA = "0x101CC0C", Offset = "0x101CC0C", Length = "0x544")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0030;\n\tv49 = CollectParticleData[];\n\tv50 = v49 + 0xCF8;\n\tv51 = \"il2cpp_codegen_initialize_runtime_metadata\"(v50, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv74 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv75 = v74 + 0xFD8;\n\tv76 = \"il2cpp_codegen_initialize_runtime_metadata\"(v75, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv80 = Il2CppMethodInfo;\n\tv81 = v80 + 0xC70;\n\tv82 = \"il2cpp_codegen_initialize_runtime_metadata\"(v81, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv405 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv406 = v405 + 0xA38;\n\tv407 = \"il2cpp_codegen_initialize_runtime_metadata\"(v406, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv476 = \"__sort-indicator\";\n\tv477 = v476 + 0xD68;\n\tv68 = \"il2cpp_codegen_initialize_runtime_metadata\"(v477, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv70 = 1;\n\t*([302AAD2]) = v70;\nL_0030:\n\tv73 = UnityEngine.Component::get_transform(this);\n\tv84 = TMPro.TMP_Text::get_transform(this.coinCountText);\n\tv325 = UnityEngine.Transform::get_position(v84);\n\tv570 = UnityEngine.Transform::InverseTransformPoint(v73, v325);\n\tv584 = this.particleCount < 1;\n\tif (v584) goto L_0249;\n\tv586 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv587 = System.Xml.ValidateNames;\n\tgoto L_0075;\nL_0061:\n\tv846 = \"__sort-indicator\";\n\tAudioManager::PlayClip(v841, *([v846 @ X8_v45 (System.String)+D68]), v356);\nL_0068:\n\tv179 = v179 + 1;\n\tv621 = v179 >= this.particleCount;\n\tif (v621) goto L_0249;\nL_0075:\n\tv384 = this.coinParticles;\n\tv642 = *([v586 @ X26_v5 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv644 = *([v642 @ X0_v13+E0]) == 0;\n\tif (v644) goto L_0095;\n\tv648 = UnityEngine.Object::op_Inequality(v384[v179 @ X25_v6 (System.Int32)], 0);\n\tv650 = ~v648;\n\tif (v650) goto L_0068;\n\tgoto L_0099;\nL_0095:\n\tv654 = UnityEngine.Object::op_Inequality(v384[v179 @ X25_v6 (System.Int32)], 0);\n\tv668 = ~v654;\n\tif (v668) goto L_0068;\nL_0099:\n\tv327 = UnityEngine.Time::get_time();\n\tv385 = this.startTimes;\n\tv678 = v327 - v385[v179 @ X25_v6 (System.Int32)];\n\tv679 = v678 / this.scaleDuration;\n\tv682 = v679 - 1f;\n\tv683 = v682 < 0;\n\tv684 = v682 == 0;\n\tv685 = v679 ^ 1f;\n\tv686 = v679 ^ v682;\n\tv687 = v685 & v686;\n\tv688 = v687 < 0;\n\tv689 = v683 == v688;\n\tv122 = ~v684;\n\tv185 = v689 & v122;\n\tv690 = ~v185;\n\tif (v690) goto L_FFFFFFFF;\n\tgoto L_00C9;\nL_00C9:\n\tv117 = v679 >= 0;\n\tif (v117) goto L_FFFFFFFF;\n\tgoto L_00D0;\nL_00D0:\n\tv328 = EasingFunction::EaseInOutCubic(v696);\n\tv386 = this.coinParticles;\n\tv387 = v386[v179 @ X25_v6 (System.Int32)];\n\tgoto L_00EF;\n\tv701 = v403;\n\tv702 = \"il2cpp_codegen_initialize_runtime_metadata\"(v701, v338, v162, v159, v55, v56, v57, v58, v328, v318, v311, v106, v63, v64, v65, v66);\n\t*([2DD441A]) = v169;\nL_00EF:\n\tv703 = *([v587 @ X20_v7 (Il2CppClass<System.Xml.ValidateNames>)+D0]);\n\tv704 = *([v703 @ X8_v17+B8]);\n\tv312 = v328 * *([v704 @ X8_v18+14]);\n\tv319 = v328 * *([v704 @ X8_v18+10]);\n\tv707 = v328 * *([v704 @ X8_v18+C]);\n\t// 249 MakeStruct v104 @ AGG101CE44_1_v5 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), v707 @ V0_v14 (System.Single), v319 @ V1_v9 (System.Single), v312 @ V2_v8 (System.Single)\n\tUnityEngine.Transform::set_localScale(v387.rt, v104);\n\tv329 = UnityEngine.Time::get_time();\n\tv388 = this.startTimes;\n\tv186 = v329 <= v388[v179 @ X25_v6 (System.Int32)];\n\tif (v186) goto L_0068;\n\tv330 = UnityEngine.Time::get_time();\n\tv389 = this.collectionStartTimes;\n\tv187 = v330 <= v389[v179 @ X25_v6 (System.Int32)];\n\tif (v187) goto L_0190;\n\tv390 = this.coinParticles;\n\tv127 = v390[v179 @ X25_v6 (System.Int32)];\n\tv744 = UnityEngine.RectTransform::get_anchoredPosition(v127.rt);\n\tv747 = *([2DD4421]) == 0;\n\tif (v747) goto L_022C;\n\tgoto L_0161;\nL_0161:\n\tv764 = v570 - v744;\n\tv765 = v570.y - v744.y;\n\tv766 = v764 * v764;\n\tv767 = v765 * v765;\n\tv768 = v766 + v767;\n\tv733 = UnityEngine.Mathf::Sqrt(v768);\n\tv724 = v733 <= 0x3727C5AC;\n\tif (v724) goto L_017E;\n\tv793 = v764 / v733;\n\tv791 = v765 / v733;\n\tgoto L_018A;\nL_017E:\n\tgoto L_0184;\n\tv799 = System.Xml.ValidateNames;\n\tv800 = v799 + 0x98;\n\tv801 = \"il2cpp_codegen_initialize_runtime_metadata\"(v800, v736, v162, v159, v55, v56, v57, v58, v764, v765, v733, v722, v63, v64, v65, v66);\n\t*([2DD4424]) = v169;\nL_0184:\n\tv804 = System.Xml.ValidateNames;\n\tv806 = *([v804 @ X8_v59 (Il2CppClass<System.Xml.ValidateNames>)+98]);\n\tv796 = *([v806 @ X8_v61+B8]);\n\tv793 = *([v796 @ X8_v62]);\n\tv791 = *([v796 @ X8_v62+4]);\nL_018A:\n\tv797 = this.coinParticleForce * v793;\n\tv798 = this.coinParticleForce * v791;\n\tv735 = v127.acceleration + v797;\n\tv734 = v127.acceleration.y + v798;\n\tv127.acceleration = v735;\n\tv127.acceleration.y = v734;\nL_0190:\n\tv401 = this.coinParticles;\n\tCoinParticle::UpdatePhysics(v401[v179 @ X25_v6 (System.Int32)]);\n\tv393 = this.coinParticles;\n\tv353 = v393[v179 @ X25_v6 (System.Int32)];\n\tv189 = *([v353 @ X0_v23 (UnityEngine.Component)+3C]) <= v570.y;\n\tif (v189) goto L_0068;\n\tv780 = UnityEngine.Component::get_gameObject(v393[v179 @ X25_v6 (System.Int32)]);\n\tgoto L_01D1;\n\tv807 = \"il2cpp_codegen_runtime_class_init\"(v787, v779, v162, v159, v55, v56, v57, v58, v332, v322, v313, v108, v63, v64, v65, v66);\nL_01D1:\n\tUnityEngine.Object::Destroy(v780);\n\tv395 = this.particlesCollected + 1;\n\tthis.particlesCollected = v395;\n\tv354 = ApplicationManager::get_appData();\n\tv396 = v354.playerData;\n\tv814 = v396.coinCount - this.coinsCollected;\n\tv819 = this.coinsCollected * this.particlesCollected;\n\tv820 = v819 / this.particleCount;\n\tv334 = v820 + v814;\n\tv118 = v334 != 0x7F800000;\n\tif (v118) goto L_FFFFFFFF;\n\tgoto L_01FB;\nL_01FB:\n\tthis.displayedCoinCount = v87;\n\tElasticScale::Pop(this.coinCountElasticScale);\n\tv355 = NumberFormatter::FormatNumber(v87);\n\tv829 = TMPro.TMP_Text::set_text(this.coinCountText, v355);\n\tgoto L_0215;\n\tv836 = \"il2cpp_codegen_runtime_class_init\"(v832, v826, v163, v159, v55, v56, v57, v58, v333, v323, v314, v109, v63, v64, v65, v66);\nL_0215:\n\tv838 = Il2CppMethodInfo;\n\tv841 = Singleton`1::get_Instance /* +1 sharing this address */(*([v838 @ X8_v39 (Il2CppMethodInfo)+C70]));\n\tv842 = CollectParticleData[];\n\tv356 = new *([v842 @ X8_v41 (Il2CppClass<CollectParticleData[]>)+CF8])();\n\tAudioClipSettings::.ctor(v356);\n\tv356.pitchVariance = 0.4f;\n\tv845 = v841 == 0;\n\tv379 = ~v845;\n\tif (v379) goto L_0061;\n\tgoto L_024A;\nL_022C:\n\t*([2DD4421]) = 1;\n\tgoto L_0161;\n\tv756 = \"il2cpp_codegen_runtime_class_init\"(v769, v736, v162, v159, v55, v56, v57, v58, v744, v745, v312, v107, v63, v64, v65, v66);\n\tgoto L_0161;\nL_0249:\n\treturn;\nL_024A:\n\tv404 = new System.NullReferenceException();\n\tthrow System.IndexOutOfRangeException;\n// 427 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void FixedUpdate()
	{
		//IL_0069: Expected I, but got O
		//IL_0077: Expected I, but got O
		//IL_00fb: Expected O, but got I
		//IL_020c: Expected O, but got F4
		//IL_0219: Expected O, but got F4
		//IL_02d7: Expected O, but got I
		//IL_02e7: Expected O, but got I
		//IL_07ec: Expected I, but got O
		//IL_07fc: Expected O, but got I
		//IL_080c: Expected O, but got I
		//IL_0814: Expected F4, but got O
		//IL_0824: Expected F4, but got I
		//IL_07c7: Expected O, but got F4
		//IL_0833: Expected I4, but got F4
		//IL_069a: Expected I, but got O
		//IL_00a8: Expected O, but got I
		global::UnityEngine.Transform transform = base.transform;
		global::UnityEngine.Transform transform2 = coinCountText.transform;
		global::UnityEngine.Vector3 position = transform2.position;
		global::UnityEngine.Vector3 vector = transform.InverseTransformPoint(position);
		if (particleCount < 1)
		{
			return;
		}
		int num3 = 0;
		global::UnityEngine.Vector3 localScale = default(global::UnityEngine.Vector3);
		AudioManager audioManager = default(AudioManager);
		while (true)
		{
			CoinParticle[] array = coinParticles;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ X26_v5 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]");
			object obj = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v642 @ X0_v13+E0]");
			if ((nint)0 != 0)
			{
				if (!(array[num3] != null))
				{
					goto IL_00ad;
				}
			}
			else if (!(array[num3] != null))
			{
				goto IL_00ad;
			}
			float time = global::UnityEngine.Time.time;
			float[] array2 = startTimes;
			float num4 = time - array2[num3];
			float num5 = num4 / scaleDuration;
			float t = global::UnityEngine.Mathf.Clamp01(num5);
			float num9 = EasingFunction.EaseInOutCubic(t);
			CoinParticle[] array3 = coinParticles;
			CoinParticle coinParticle = array3[num3];
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X20_v7 (Il2CppClass<System.Xml.ValidateNames>)+D0]");
			object obj4 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v703 @ X8_v17+B8]");
			object obj5 = 0;
			float num10 = num9;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X8_v18+14]");
			float z = num10 * 0f;
			float num11 = num9;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X8_v18+10]");
			float y = num11 * 0f;
			float num12 = num9;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X8_v18+C]");
			float x = num12 * 0f;
			localScale.x = x;
			localScale.y = y;
			localScale.z = z;
			coinParticle.rt.localScale = localScale;
			float time2 = global::UnityEngine.Time.time;
			float[] array4 = startTimes;
			if (time2 > array4[num3])
			{
				float time3 = global::UnityEngine.Time.time;
				float[] array5 = collectionStartTimes;
				if (time3 > array5[num3])
				{
					CoinParticle[] array6 = coinParticles;
					CoinParticle coinParticle2 = array6[num3];
					global::UnityEngine.Vector2 anchoredPosition = coinParticle2.rt.anchoredPosition;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2DD4421]");
					if ((nint)0 == 0)
					{
						_ = 1;
					}
					float num13 = vector.x - anchoredPosition.x;
					float num14 = vector.y - anchoredPosition.y;
					float num15 = num13 * num13;
					float num16 = num14 * num14;
					float f = num15 + num16;
					float num17 = global::UnityEngine.Mathf.Sqrt(f);
					float num18;
					float num19;
					if (num17 > 1E-05f)
					{
						num18 = num13 / num17;
						num19 = num14 / num17;
					}
					else
					{
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v804 @ X8_v59 (Il2CppClass<System.Xml.ValidateNames>)+98]");
						object obj6 = 0;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v806 @ X8_v61+B8]");
						object obj7 = 0;
						num18 = (float)obj7;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v796 @ X8_v62+4]");
						num19 = 0f;
					}
					float num21 = coinParticleForce * num18;
					float num22 = coinParticleForce * num19;
					float num23 = coinParticle2.acceleration.x + num21;
					float y2 = coinParticle2.acceleration.y + num22;
					coinParticle2.acceleration.x = num23;
					coinParticle2.acceleration.y = y2;
				}
				CoinParticle[] array7 = coinParticles;
				array7[num3].UpdatePhysics();
				CoinParticle[] array8 = coinParticles;
				global::UnityEngine.Component component = array8[num3];
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X0_v23 (UnityEngine.Component)+3C]");
				if (0f > vector.y)
				{
					global::UnityEngine.GameObject obj8 = array8[num3].gameObject;
					global::UnityEngine.Object.Destroy(obj8);
					int num24 = particlesCollected + 1;
					particlesCollected = num24;
					ApplicationData appData = ApplicationManager.appData;
					PlayerData playerData = appData.playerData;
					int num25 = playerData.coinCount - coinsCollected;
					int num26 = coinsCollected * particlesCollected;
					int num27 = num26 / particleCount;
					int num28 = num27 + num25;
					float num29 = ((num28 != 2139095040) ? ((float)num28) : -0f);
					displayedCoinCount = (int)num29;
					coinCountElasticScale.Pop();
					string text = NumberFormatter.FormatNumber(num29);
					coinCountText.text = text;
					nint num30 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
					AudioClipSettings audioClipSettings = new AudioClipSettings();
					audioClipSettings.pitchVariance = 0.4f;
					if ((object)audioManager == null)
					{
						break;
					}
					string text2 = "__sort-indicator";
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v846 @ X8_v45 (System.String)+D68]");
					audioManager.PlayClip(null, audioClipSettings);
				}
			}
			goto IL_00ad;
			IL_00ad:
			num3++;
			if (num3 < particleCount)
			{
				continue;
			}
			return;
		}
		global::System.NullReferenceException ex = new global::System.NullReferenceException();
		throw new global::System.IndexOutOfRangeException();
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000421")]
	[global::Cpp2ILInjected.Address(RVA = "0x101C64C", Offset = "0x101C64C", Length = "0x60")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv14 = ~pop;\n\tif (v14) goto L_000F;\n\tElasticScale::Pop(this.coinCountElasticScale);\nL_000F:\n\tv22 = this.coinCountText;\n\tv25 = NumberFormatter::FormatNumber(count);\n\tv47 = *([v22 @ X20_v3 (TMPro.TextMeshProUGUI)]);\n\tv48 = *([v47 @ X8_v1 (Il2CppClass<TMPro.TextMeshProUGUI>)+558]);\n\tv49 = *([v47 @ X8_v1 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]);\n\t// 31 IndirectJump v48 @ X3_v1, v22 @ X20_v3 (TMPro.TextMeshProUGUI), v22 @ X20_v3 (TMPro.TextMeshProUGUI), v25 @ X0_v5 (System.String), v49 @ X2_v1, v48 @ X3_v1, v35 @ X4, v36 @ X5, v37 @ X6, v38 @ X7, count @ X1 (System.Int32), v39 @ V1, v40 @ V2, v41 @ V3, v42 @ V4, v43 @ V5, v44 @ V6, v45 @ V7\n\tthrow System.NullReferenceException;\n\treturn;\n// 23 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void UpdateDisplayedCoinCount(int count, bool pop = false)
	{
		//IL_004e: Expected I, but got O
		//IL_005e: Expected O, but got I
		//IL_006e: Expected O, but got I
		if (pop)
		{
			coinCountElasticScale.Pop();
		}
		global::TMPro.TextMeshProUGUI textMeshProUGUI = coinCountText;
		string text = NumberFormatter.FormatNumber(count);
		textMeshProUGUI.text = text;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000422")]
	[global::Cpp2ILInjected.Address(RVA = "0x101D150", Offset = "0x101D150", Length = "0xAC")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = System.Xml.ValidateNames;\n\tgoto L_0017;\n\tv23 = System.Xml.ValidateNames;\n\tv24 = v23 + 0x198;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv43 = 1;\n\t*([302AAD3]) = v43;\nL_0017:\n\tthis.maxCoinParticleCount = 0x28;\n\t// 25 NotImplemented \"Instruction DUP not yet implemented.\"\n\tthis.coinParticleRadius = v33;\n\tthis.coinParticleCollectionRadius = *([2875AC0]);\n\t// 32 NotImplemented \"Instruction DUP not yet implemented.\"\n\tthis.maxStartCollectionDelay = *([2875AC0]);\n\tv50 = *([v18 @ X20_v1 (Il2CppClass<System.Xml.ValidateNames>)+198]);\n\tv52 = *([v50 @ X0_v2+E0]) == 0;\n\tif (v52) goto L_003B;\n\tViewport::.ctor(this);\n\treturn;\nL_003B:\n\tViewport::.ctor(this);\n\treturn;\n// 41 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public CoinsScreen()
	{
		//IL_000e: Expected I, but got O
		//IL_0045: Expected F4, but got O
		//IL_0057: Expected F4, but got I
		//IL_0073: Expected F4, but got I
		//IL_0083: Expected O, but got I
		maxCoinParticleCount = 40;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		object obj = default(object);
		coinParticleRadius = (float)obj;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2875AC0]");
		coinParticleCollectionRadius = 0f;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2875AC0]");
		maxStartCollectionDelay = 0f;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X20_v1 (Il2CppClass<System.Xml.ValidateNames>)+198]");
		object obj2 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v2+E0]");
		if ((nint)0 != 0)
		{
		}
		else
		{
		}
	}
}
