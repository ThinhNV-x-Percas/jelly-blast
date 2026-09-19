[global::Cpp2ILInjected.Token(Token = "0x20000A3")]
public class GameManager : Singleton<GameManager>
{
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x20000A7")]
	private sealed class _003CHandleIntro_003Ed__54 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
	{
		[global::Cpp2ILInjected.Token(Token = "0x40003B9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[global::Cpp2ILInjected.Token(Token = "0x40003BA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[global::Cpp2ILInjected.Token(Token = "0x40003BB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public GameManager _003C_003E4__this;

		[global::Cpp2ILInjected.Token(Token = "0x17000028")]
		object global::System.Collections.Generic.IEnumerator<object>.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000307")]
			[global::Cpp2ILInjected.Address(RVA = "0x100CC1C", Offset = "0x100CC1C", Length = "0x8")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn this.<>2__current;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
			get
			{
				return _003C_003E2__current;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000029")]
		object global::System.Collections.IEnumerator.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000309")]
			[global::Cpp2ILInjected.Address(RVA = "0x100CC64", Offset = "0x100CC64", Length = "0x8")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn this.<>2__current;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
			get
			{
				return _003C_003E2__current;
			}
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x6000304")]
		[global::Cpp2ILInjected.Address(RVA = "0x100B000", Offset = "0x100B000", Length = "0x2C")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tSystem.Object::.ctor(this);\n\tthis.<>1__state = <>1__state;\n\treturn;\n// 14 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public _003CHandleIntro_003Ed__54(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x6000305")]
		[global::Cpp2ILInjected.Address(RVA = "0x100CB20", Offset = "0x100CB20", Length = "0x4")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn;\n")]
		void global::System.IDisposable.Dispose()
		{
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000306")]
		[global::Cpp2ILInjected.Address(RVA = "0x100CB24", Offset = "0x100CB24", Length = "0xF8")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0015;\n\tv21 = System.Xml.ValidateNames;\n\tv22 = v21 + 0x258;\n\tv23 = \"il2cpp_codegen_initialize_runtime_metadata\"(v22, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv41 = 1;\n\t*([302AA53]) = v41;\nL_0015:\n\tv43 = this.<>1__state == 0;\n\tif (v43) goto L_004F;\n\tv53 = this.<>1__state != 1;\n\tif (v53) goto L_0040;\n\tv59 = this.<>4__this;\n\tthis.<>1__state = 0xFFFFFFFF;\n\tv81 = v59._gameState == 3;\n\tif (v81) goto L_0040;\n\tv59._gameState = 3;\n\tv93 = v59.OnGameStateChanged;\n\tv91 = v59.OnGameStateChanged == 0;\n\tif (v91) goto L_0040;\n\tv93.invoke_impl(v89, v93.method_code, v59._gameState, 3, v93.method, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\nL_0040:\n\tv98 = this.<>1__state == 0;\n\treturn v98;\nL_004F:\n\tthis.<>1__state = 0xFFFFFFFF;\n\tv55 = System.Xml.ValidateNames;\n\tv58 = new *([v55 @ X8_v4 (Il2CppClass<System.Xml.ValidateNames>)+258])();\n\tUnityEngine.WaitForSeconds::.ctor(v58, 4f);\n\tv157 = this + 0x18;\n\tthis.<>2__current = v58;\n\tv158 = 0xF3F1B4(v157, v58, v25, v26, v27, v28, v29, v30, 4f, v32, v33, v34, v35, v36, v37, v38);\n\tthis.<>1__state = 1;\n\tv138 = this.<>1__state == 0;\n\treturn v138;\n\treturnVal2 = new System.NullReferenceException();\n\treturn returnVal2;\n// 82 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		private bool MoveNext()
		{
			//IL_00c8: Expected I, but got O
			//IL_00e8: Expected O, but got I
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					GameManager gameManager = _003C_003E4__this;
					_003C_003E1__state = -1;
					if (gameManager._gameState != GameState.Gameplay)
					{
						gameManager._gameState = GameState.Gameplay;
						global::System.Action<GameState, GameState> action = gameManager.m_OnGameStateChanged;
						if (gameManager.m_OnGameStateChanged != null)
						{
							action(gameManager._gameState, GameState.Gameplay);
						}
					}
				}
				return _003C_003E1__state == 0;
			}
			_003C_003E1__state = -1;
			nint num = 0;
			global::UnityEngine.WaitForSeconds waitForSeconds = new global::UnityEngine.WaitForSeconds(4f);
			_003C_003E2__current = waitForSeconds;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
			_003C_003E1__state = 1;
			return _003C_003E1__state == 0;
		}

		bool global::System.Collections.IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x6000308")]
		[global::Cpp2ILInjected.Address(RVA = "0x100CC24", Offset = "0x100CC24", Length = "0x40")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv10 = Facebook.Unity.Windows.IWindowsFacebook + 0xF30;\n\tv11 = 0xF3F22C(v10, methodInfo, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26);\n\tv27 = new v11();\n\tSystem.NotSupportedException::.ctor(v27);\n\tv31 = Il2CppMethodInfo + 0xE60;\n\tv32 = 0xF3F22C(v31, 0, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26);\n\tthrow v27;\n// 13 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		void global::System.Collections.IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0039: Expected O, but got I
			object obj = null;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F22C");
			global::System.NotSupportedException ex = new global::System.NotSupportedException();
			object obj2 = (nint)0 + (nint)3680;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F22C");
			throw ex;
		}
	}

	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x20000A8")]
	private sealed class _003CMonitorFailCondition_003Ed__58 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
	{
		[global::Cpp2ILInjected.Token(Token = "0x40003BC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[global::Cpp2ILInjected.Token(Token = "0x40003BD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[global::Cpp2ILInjected.Token(Token = "0x40003BE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public GameManager _003C_003E4__this;

		[global::Cpp2ILInjected.Token(Token = "0x40003BF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private float _003CstartFailTimerTime_003E5__2;

		[global::Cpp2ILInjected.Token(Token = "0x1700002A")]
		object global::System.Collections.Generic.IEnumerator<object>.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600030D")]
			[global::Cpp2ILInjected.Address(RVA = "0x100CD70", Offset = "0x100CD70", Length = "0x8")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn this.<>2__current;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
			get
			{
				return _003C_003E2__current;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700002B")]
		object global::System.Collections.IEnumerator.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600030F")]
			[global::Cpp2ILInjected.Address(RVA = "0x100CDB8", Offset = "0x100CDB8", Length = "0x8")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn this.<>2__current;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
			get
			{
				return _003C_003E2__current;
			}
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x600030A")]
		[global::Cpp2ILInjected.Address(RVA = "0x100BCE0", Offset = "0x100BCE0", Length = "0x2C")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tSystem.Object::.ctor(this);\n\tthis.<>1__state = <>1__state;\n\treturn;\n// 14 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public _003CMonitorFailCondition_003Ed__58(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x600030B")]
		[global::Cpp2ILInjected.Address(RVA = "0x100CC6C", Offset = "0x100CC6C", Length = "0x4")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn;\n")]
		void global::System.IDisposable.Dispose()
		{
		}

		[global::Cpp2ILInjected.Token(Token = "0x600030C")]
		[global::Cpp2ILInjected.Address(RVA = "0x100CC70", Offset = "0x100CC70", Length = "0x100")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0013;\n\tv17 = Il2CppMethodInfo;\n\tv18 = v17 + 0x9B0;\n\tv19 = \"il2cpp_codegen_initialize_runtime_metadata\"(v18, methodInfo, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34);\n\tv37 = 1;\n\t*([302AA54]) = v37;\nL_0013:\n\tv39 = this.<>4__this;\n\tv44 = this.<>1__state == 1;\n\tif (v44) goto L_0028;\n\tv49 = this.<>1__state == 0;\n\tv50 = ~v49;\n\tif (v50) goto L_0074;\n\tthis.<>1__state = 0xFFFFFFFF;\n\tv54 = UnityEngine.Time::get_time();\n\tthis.<startFailTimerTime>5__2 = v54;\n\tgoto L_0035;\nL_0028:\n\tthis.<>1__state = 0xFFFFFFFF;\nL_0035:\n\tv62 = v39._gameState != 3;\n\tif (v62) goto L_0074;\n\tv142 = UnityEngine.Time::get_time();\n\tv58 = this.<startFailTimerTime>5__2 + v39.failTimerDuration;\n\tv115 = v142 >= v58;\n\tif (v115) goto L_006A;\n\tv163 = v39.solver;\n\tv164 = v163.exploding;\n\tv148 = v164._count == 0;\n\tif (v148) goto L_0053;\n\tv142 = UnityEngine.Time::get_time();\n\tthis.<startFailTimerTime>5__2 = v142;\nL_0053:\n\tv171 = this + 0x18;\n\tthis.<>2__current = 0;\n\tv173 = 0xF3F1B4(v171, 0, v21, v22, v23, v24, v25, v26, v142, v58, v39.failTimerDuration, v30, v31, v32, v33, v34);\n\tthis.<>1__state = 1;\n\treturn 1;\nL_006A:\n\tv60 = v39._gameState != 3;\n\tif (v60) goto L_0074;\n\tGameManager::Fail(v39);\nL_0074:\n\treturn 0;\n\treturnVal2 = new System.NullReferenceException();\n\treturn returnVal2;\n// 79 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		private bool MoveNext()
		{
			//IL_0193: Expected O, but got I
			GameManager gameManager = _003C_003E4__this;
			if (_003C_003E1__state != 1)
			{
				if (_003C_003E1__state != 0)
				{
					goto IL_0158;
				}
				_003C_003E1__state = -1;
				float time = global::UnityEngine.Time.time;
				_003CstartFailTimerTime_003E5__2 = time;
			}
			else
			{
				_003C_003E1__state = -1;
			}
			if (gameManager._gameState == GameState.Gameplay)
			{
				float time2 = global::UnityEngine.Time.time;
				float num = _003CstartFailTimerTime_003E5__2 + gameManager.failTimerDuration;
				if (time2 < num)
				{
					FluidSolver solver = gameManager.solver;
					global::System.Collections.Generic.HashSet<int> exploding = solver.exploding;
					if (exploding.Count != 0)
					{
						time2 = global::UnityEngine.Time.time;
						_003CstartFailTimerTime_003E5__2 = time2;
					}
					_003C_003E2__current = null;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
					_003C_003E1__state = 1;
					return true;
				}
				if (gameManager._gameState == GameState.Gameplay)
				{
					gameManager.Fail();
				}
			}
			goto IL_0158;
			IL_0158:
			return false;
		}

		bool global::System.Collections.IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x600030E")]
		[global::Cpp2ILInjected.Address(RVA = "0x100CD78", Offset = "0x100CD78", Length = "0x40")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv10 = Facebook.Unity.Windows.IWindowsFacebook + 0xF30;\n\tv11 = 0xF3F22C(v10, methodInfo, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26);\n\tv27 = new v11();\n\tSystem.NotSupportedException::.ctor(v27);\n\tv31 = Il2CppMethodInfo + 0xE68;\n\tv32 = 0xF3F22C(v31, 0, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26);\n\tthrow v27;\n// 13 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		void global::System.Collections.IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0039: Expected O, but got I
			object obj = null;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F22C");
			global::System.NotSupportedException ex = new global::System.NotSupportedException();
			object obj2 = (nint)0 + (nint)3688;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F22C");
			throw ex;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x4000381")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public GameState _gameState;

	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x4000382")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private global::System.Action<GameState, GameState> m_OnGameStateChanged;

	[global::Cpp2ILInjected.Token(Token = "0x4000383")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public FluidSolver solver;

	[global::Cpp2ILInjected.Token(Token = "0x4000384")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public FluidPhysicsCoupler coupler;

	[global::Cpp2ILInjected.Token(Token = "0x4000385")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public FluidDisplay display;

	[global::Cpp2ILInjected.Token(Token = "0x4000386")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public int targetParticleCount;

	[global::UnityEngine.Tooltip("Number of coloured particles that must spawn before a new fish appears")]
	[global::UnityEngine.Header("Fish Spawn Settings")]
	[global::Cpp2ILInjected.Token(Token = "0x4000387")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
	public int fishSpawnThreshold;

	[global::Cpp2ILInjected.Token(Token = "0x4000388")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	private int _particlesSpawnedSinceLastFish;

	[global::Cpp2ILInjected.Token(Token = "0x4000389")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
	private int _fishSpawnedCount;

	[global::Cpp2ILInjected.Token(Token = "0x400038A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	private int _activeFishCount;

	[global::Cpp2ILInjected.Token(Token = "0x400038B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
	private int _fishGoalTarget;

	[global::Cpp2ILInjected.Token(Token = "0x400038C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public float selectionRadius;

	[global::Cpp2ILInjected.Token(Token = "0x400038D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
	public int minRemoveParticles;

	[global::Cpp2ILInjected.Token(Token = "0x400038E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public float powerUpMergeDistance;

	[global::UnityEngine.Header("Lighting")]
	[global::Cpp2ILInjected.Token(Token = "0x400038F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
	public global::UnityEngine.Vector3 lightRot;

	[global::Cpp2ILInjected.Token(Token = "0x4000390")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public Level level;

	[global::Cpp2ILInjected.Token(Token = "0x4000391")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public global::System.Action OnUserMove;

	[global::Cpp2ILInjected.Token(Token = "0x4000392")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public global::System.Action<global::System.Collections.Generic.HashSet<int>> OnRejectInput;

	[global::Cpp2ILInjected.Token(Token = "0x4000393")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public global::System.Action OnInit;

	[global::Cpp2ILInjected.Token(Token = "0x4000394")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public global::System.Action<global::UnityEngine.Vector2> OnTooSmallReject;

	[global::Cpp2ILInjected.Token(Token = "0x4000395")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public int coinsCollected;

	[global::Cpp2ILInjected.Token(Token = "0x4000396")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public global::System.Collections.Generic.List<Water> waters;

	[global::Cpp2ILInjected.Token(Token = "0x4000397")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public Mud mudPrefab;

	[global::Cpp2ILInjected.Token(Token = "0x4000398")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public Snow snowPrefab;

	[global::Cpp2ILInjected.Token(Token = "0x4000399")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public Water waterPrefab;

	[global::Cpp2ILInjected.Token(Token = "0x400039A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public Sponge spongePrefab;

	[global::Cpp2ILInjected.Token(Token = "0x400039B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public Octopus octopusPrefab;

	[global::Cpp2ILInjected.Token(Token = "0x400039C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public Caterpillar caterpillarPrefab;

	[global::Cpp2ILInjected.Token(Token = "0x400039D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public Bee beePrefab;

	[global::Cpp2ILInjected.Token(Token = "0x400039E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public Ice icePrefab;

	[global::Cpp2ILInjected.Token(Token = "0x400039F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	public Stone stonePrefab;

	[global::Cpp2ILInjected.Token(Token = "0x40003A0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
	public Fish fishPrefab;

	[global::Cpp2ILInjected.Token(Token = "0x40003A1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
	public Butterfly butterflyPrefab;

	[global::Cpp2ILInjected.Token(Token = "0x40003A2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	public FluidCompute compute;

	[global::Cpp2ILInjected.Token(Token = "0x40003A3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
	public float failTimerDuration;

	[global::Cpp2ILInjected.Token(Token = "0x40003A4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
	public Honey honeyTest;

	[global::Cpp2ILInjected.Token(Token = "0x40003A5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
	public FluidCollectDisplay mudCollectDisplay;

	[global::Cpp2ILInjected.Token(Token = "0x40003A6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
	public global::UnityEngine.Material mudMaterial;

	[global::Cpp2ILInjected.Token(Token = "0x40003A7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
	public global::UnityEngine.Material honeyMaterial;

	[global::Cpp2ILInjected.Token(Token = "0x40003A8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
	public global::UnityEngine.Material snowMaterial;

	[global::Cpp2ILInjected.Token(Token = "0x40003A9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
	public global::UnityEngine.Material colorMaterial;

	[global::Cpp2ILInjected.Token(Token = "0x40003AA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
	public global::UnityEngine.Material octopusMaterial;

	[global::Cpp2ILInjected.Token(Token = "0x40003AB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
	public global::UnityEngine.Material beeMaterial;

	[global::Cpp2ILInjected.Token(Token = "0x40003AC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
	public global::UnityEngine.Light light;

	[global::Cpp2ILInjected.Token(Token = "0x40003AD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
	public SplashEffect splashEffectPrefab;

	[global::Cpp2ILInjected.Token(Token = "0x40003AE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
	public global::System.Collections.Generic.List<ParticleQueueData> particleQueue;

	[global::Cpp2ILInjected.Token(Token = "0x40003AF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x170")]
	private int queuedCount;

	[global::System.NonSerialized]
	[global::Cpp2ILInjected.Token(Token = "0x40003B0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x174")]
	public int pendingFish;

	[global::Cpp2ILInjected.Token(Token = "0x17000027")]
	public GameState gameState
	{
		[global::Cpp2ILInjected.Token(Token = "0x60002E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1009D08", Offset = "0x1009D08", Length = "0x8")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn this._gameState;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		get
		{
			return _gameState;
		}
		[global::Cpp2ILInjected.Token(Token = "0x60002EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1009D10", Offset = "0x1009D10", Length = "0x30")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv8 = this._gameState == value;\n\tif (v8) goto L_0014;\n\tthis._gameState = value;\n\tv13 = this.OnGameStateChanged;\n\tv14 = this.OnGameStateChanged == 0;\n\tif (v14) goto L_0014;\n\t// 19 IndirectJump v13.invoke_impl (System.IntPtr), v13.method_code (System.IntPtr), v13.method_code (System.IntPtr), this._gameState (GameState), value @ X1 (GameState), v13.method (System.IntPtr), v13.invoke_impl (System.IntPtr), v22 @ X5, v23 @ X6, v24 @ X7, v25 @ V0, v26 @ V1, v27 @ V2, v28 @ V3, v29 @ V4, v30 @ V5, v31 @ V6, v32 @ V7\nL_0014:\n\treturn;\n// 13 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		set
		{
			if (_gameState != value)
			{
				_gameState = value;
				global::System.Action<GameState, GameState> action = this.m_OnGameStateChanged;
				if (this.m_OnGameStateChanged != null)
				{
					action(this._gameState, value);
				}
			}
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x14000002")]
	public event global::System.Action<GameState, GameState> OnGameStateChanged
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x60002EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1009D40", Offset = "0x1009D40", Length = "0xB4")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0017;\n\tv27 = System.Collections.Generic.NullableComparer`1;\n\tv28 = v27 + 0xDF8;\n\tv29 = \"il2cpp_codegen_initialize_runtime_metadata\"(v28, value, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv46 = 1;\n\t*([302AAB4]) = v46;\nL_0017:\n\tv47 = System.Collections.Generic.NullableComparer`1;\n\tv49 = this + 0x28;\n\tgoto L_002E;\nL_001F:\n\tv84 = 0xFAC9D8(v49, v82, v87, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv70 = v84 == v87;\n\tif (v70) goto L_0045;\nL_002E:\n\tv92 = System.Delegate::Combine(v87, value);\n\tv93 = v92 == 0;\n\tif (v93) goto L_FFFFFFFF;\n\tv97 = 0xF3F36C(v92, *([v47 @ X24_v1 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+DF8]), 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv100 = v97 == 0;\n\tv101 = ~v100;\n\tif (v101) goto L_001F;\n\tthrow System.InvalidCastException;\nL_0045:\n\treturn;\n// 49 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		add
		{
			//IL_0090: Expected I, but got O
			//IL_009c: Expected O, but got I
			nint num = 0;
			global::System.Delegate obj2 = this.m_OnGameStateChanged;
			int num3 = default(int);
			bool flag3;
			global::System.Delegate obj4 = default(global::System.Delegate);
			do
			{
				global::System.Delegate obj3 = global::System.Delegate.Combine(obj2, value);
				if ((object)obj3 == null)
				{
					int num2 = 0;
				}
				else
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F36C");
					bool flag = num3 == 0;
					bool flag2 = !flag;
					int num2 = num3;
					if (!flag2)
					{
						throw new global::System.InvalidCastException();
					}
				}
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FAC9D8");
				flag3 = (object)obj4 == obj2;
				obj2 = obj4;
			}
			while (!flag3);
		}
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x60002EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1009DF4", Offset = "0x1009DF4", Length = "0xB4")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0017;\n\tv27 = System.Collections.Generic.NullableComparer`1;\n\tv28 = v27 + 0xDF8;\n\tv29 = \"il2cpp_codegen_initialize_runtime_metadata\"(v28, value, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv46 = 1;\n\t*([302AA46]) = v46;\nL_0017:\n\tv47 = System.Collections.Generic.NullableComparer`1;\n\tv49 = this + 0x28;\n\tgoto L_002E;\nL_001F:\n\tv84 = 0xFAC9D8(v49, v82, v87, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv70 = v84 == v87;\n\tif (v70) goto L_0045;\nL_002E:\n\tv92 = System.Delegate::Remove(v87, value);\n\tv93 = v92 == 0;\n\tif (v93) goto L_FFFFFFFF;\n\tv97 = 0xF3F36C(v92, *([v47 @ X24_v1 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+DF8]), 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv100 = v97 == 0;\n\tv101 = ~v100;\n\tif (v101) goto L_001F;\n\tthrow System.InvalidCastException;\nL_0045:\n\treturn;\n// 49 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		remove
		{
			//IL_0090: Expected I, but got O
			//IL_009c: Expected O, but got I
			nint num = 0;
			global::System.Delegate obj2 = this.m_OnGameStateChanged;
			int num3 = default(int);
			bool flag3;
			global::System.Delegate obj4 = default(global::System.Delegate);
			do
			{
				global::System.Delegate obj3 = global::System.Delegate.Remove(obj2, value);
				if ((object)obj3 == null)
				{
					int num2 = 0;
				}
				else
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F36C");
					bool flag = num3 == 0;
					bool flag2 = !flag;
					int num2 = num3;
					if (!flag2)
					{
						throw new global::System.InvalidCastException();
					}
				}
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FAC9D8");
				flag3 = (object)obj4 == obj2;
				obj2 = obj4;
			}
			while (!flag3);
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x60002ED")]
	[global::Cpp2ILInjected.Address(RVA = "0x1009EA8", Offset = "0x1009EA8", Length = "0x3A8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0038;\n\tv25 = CollectParticleData[];\n\tv26 = v25 + 0x990;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv56 = Il2CppMethodInfo;\n\tv57 = v56 + 0x898;\n\tv58 = \"il2cpp_codegen_initialize_runtime_metadata\"(v57, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv73 = Il2CppMethodInfo;\n\tv74 = v73 + 0x68;\n\tv75 = \"il2cpp_codegen_initialize_runtime_metadata\"(v74, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv80 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv81 = v80 + 0xFD8;\n\tv82 = \"il2cpp_codegen_initialize_runtime_metadata\"(v81, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv86 = Il2CppMethodInfo;\n\tv87 = v86 + 0xC90;\n\tv88 = \"il2cpp_codegen_initialize_runtime_metadata\"(v87, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv90 = Il2CppMethodInfo;\n\tv91 = v90 + 0xCA0;\n\tv92 = \"il2cpp_codegen_initialize_runtime_metadata\"(v91, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv249 = Il2CppMethodInfo;\n\tv250 = v249 + 0xCB8;\n\tv251 = \"il2cpp_codegen_initialize_runtime_metadata\"(v250, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv252 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv253 = v252 + 0xA48;\n\tv254 = \"il2cpp_codegen_initialize_runtime_metadata\"(v253, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv311 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv312 = v311 + 0xA50;\n\tv313 = \"il2cpp_codegen_initialize_runtime_metadata\"(v312, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv327 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv328 = v327 + 0xA60;\n\tv329 = \"il2cpp_codegen_initialize_runtime_metadata\"(v328, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv353 = Il2CppFieldInfo;\n\tv354 = v353 + 0x960;\n\tv44 = \"il2cpp_codegen_initialize_runtime_metadata\"(v354, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv46 = 1;\n\t*([302AAB5]) = v46;\nL_0038:\n\tv51 = Facebook.Unity.Windows.IWindowsFacebook;\n\tgoto L_0043;\n\tv59 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv60 = v59 + 0x78;\n\tv61 = \"il2cpp_codegen_initialize_runtime_metadata\"(v60, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv64 = 1;\n\t*([302AAB9]) = v64;\nL_0043:\n\tv65 = Il2CppMethodInfo;\n\tv67 = *([v51 @ X22_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+78]);\n\tv68 = *([v67 @ X8_v5+B8]);\n\t*([v68 @ X8_v6]) = 0;\n\tgoto L_004F;\n\tv76 = \"il2cpp_codegen_runtime_class_init\"(v69, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\nL_004F:\n\tv79 = Singleton`1::get_Instance /* +1 sharing this address */(*([v65 @ X21_v2 (Il2CppMethodInfo)+CA0]));\n\tv85 = ApplicationManager::get_appData();\n\tv93 = v85.playerData;\n\tv373 = *([v79 @ X0_v6+28]);\n\tv202 = v93.levelIndex;\n\tv199 = v93.levelIndex - v373.invoke_impl;\n\tv326 = v93.levelIndex >= v373.invoke_impl;\n\tif (v326) goto L_0132;\nL_006D:\n\tv199 = Facebook.Unity.Windows.IWindowsFacebook + 0xFD8;\n\tv376 = Il2CppMethodInfo;\n\tv136 = v202 << 3;\n\tv377 = v373 + v136;\n\tgoto L_007B;\n\tv410 = \"il2cpp_codegen_runtime_class_init\"(v379, v356, v119, v115, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\nL_007B:\n\tv414 = UnityEngine.Object::Instantiate /* +1 sharing this address */(*([v377 @ X8_v16+20]), *([v376 @ X21_v11 (Il2CppMethodInfo)+68]));\n\tv244 = this + 0x78;\n\tthis.level = v414;\n\tv444 = 0xF3F1B4(v244, v414, 0, v116, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv463 = UnityEngine.Component::get_transform(this.level);\n\tv209 = UnityEngine.Component::get_transform(this);\n\tUnityEngine.Transform::SetParent(v463, v209);\n\tLevel::Init(this.level);\n\tFluidPhysicsCoupler::Init(this.coupler);\n\tv466 = FluidDisplay::Init(this.display);\n\tv470 = Honey::Init(this.honeyTest);\n\tv175 = this._gameState == 1;\n\tif (v175) goto L_00BE;\n\tthis._gameState = 1;\n\tv473 = this.OnGameStateChanged;\n\tv474 = this.OnGameStateChanged == 0;\n\tif (v474) goto L_00BE;\n\tv116 = v473.method;\n\tv473.invoke_impl(v479, v473.method_code, this._gameState, 1, v473.method, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\nL_00BE:\n\tv214 = ApplicationManager::get_appData();\n\tv483 = Il2CppFieldInfo;\n\tv485 = v214.playerData + 0x14;\n\tv486 = Il2CppMethodInfo;\n\tv488 = System.Int32::ToString(v485);\n\tv108 = v488 != 0;\n\tif (v108) goto L_FFFFFFFF;\n\tgoto L_00DF;\nL_00DF:\n\tGameAnalyticsSDK.GameAnalytics::NewProgressionEvent(1, v131);\n\tgoto L_00E7;\n\tv497 = \"il2cpp_codegen_runtime_class_init\"(v494, v131, v122, v116, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\nL_00E7:\n\tv215 = Singleton`1::get_Instance /* +1 sharing this address */(*([v486 @ X20_v15 (Il2CppMethodInfo)+CB8]));\n\tUIIconGenerator::UpdateIcons(v215);\n\tv501 = this.OnInit;\n\tv502 = this.OnInit == 0;\n\tif (v502) goto L_00F4;\n\tv501.invoke_impl(v506, v501.method_code, v501.method, 0, v116, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\nL_00F4:\n\tv508 = Il2CppMethodInfo;\n\tgoto L_00FD;\n\tv512 = \"il2cpp_codegen_runtime_class_init\"(v509, v132, v122, v116, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\nL_00FD:\n\tv216 = Singleton`1::get_Instance /* +1 sharing this address */(*([v508 @ X21_v16 (Il2CppMethodInfo)+C90]));\n\tv241 = *([v216 @ X0_v50+30]);\n\tv515 = CollectParticleData[];\n\tv516 = Il2CppMethodInfo;\n\tv460 = *([v216 @ X0_v50+30]) + 0x470;\n\tv518 = new *([v515 @ X23_v8 (Il2CppClass<CollectParticleData[]>)+990])();\n\tSystem.Action::.ctor(v518, this, *([v516 @ X24_v8 (Il2CppMethodInfo)+898]));\n\tv438 = System.Delegate::Combine(*([v241 @ X8_v26+470]), v518);\n\tv349 = v438 == 0;\n\tif (v349) goto L_0145;\n\tv337 = *([v438 @ X0_v54 (System.Delegate)]) != *([v515 @ X23_v8 (Il2CppClass<CollectParticleData[]>)+990]);\n\tif (v337) goto L_0131;\n\t*([v460 @ X20_v6]) = v438;\n\tv454 = *([v438 @ X0_v54 (System.Delegate)]) == *([v515 @ X23_v8 (Il2CppClass<CollectParticleData[]>)+990]);\n\tif (v454) goto L_0151;\nL_0131:\n\tv347 = new System.InvalidCastException();\nL_0132:\n\tv373 = *([v460 @ X20_v6+30]);\n\tv408 = v199 / v373.invoke_impl;\n\tv372 = v408 * v373.invoke_impl;\n\tv202 = v199 - v372;\n\tv409 = v202 < v373.invoke_impl;\n\tv367 = ~v409;\n\tv359 = ~v367;\n\tif (v359) goto L_006D;\n\tthrow System.IndexOutOfRangeException;\nL_0145:\n\t*([v460 @ X20_v6]) = 0;\nL_0151:\n\tv300 = 0xF3F1B4(v460, v304, v270, v268, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 209 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private unsafe void Start()
	{
		//IL_0498: Expected I, but got O
		//IL_04ea: Expected O, but got I
		//IL_04fa: Expected O, but got I
		//IL_0503: Expected O, but got I4
		//IL_003f: Expected O, but got I
		//IL_03f0: Expected O, but got I
		//IL_0460: Expected O, but got I4
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected I4, but got Unknown
		//IL_00cf: Expected O, but got I
		//IL_00ea: Expected O, but got I
		//IL_023a: Expected O, but got I
		//IL_02bb: Expected O, but got I
		//IL_02ce: Expected I, but got O
		//IL_02ea: Expected O, but got I
		//IL_031b: Expected O, but got I
		//IL_0341: Expected O, but got I4
		//IL_0485: Expected O, but got I4
		//IL_03b2: Expected O, but got I4
		ApplicationData appData = ApplicationManager.appData;
		PlayerData playerData = appData.playerData;
		Level levelPrefab = global::Singleton<LevelSequenceManager>.Instance.GetLevelPrefab(playerData.levelIndex);
		this.level = global::UnityEngine.Object.Instantiate(levelPrefab);
		global::UnityEngine.Transform transform = this.level.transform;
		global::UnityEngine.Transform parent = base.transform;
		transform.SetParent(parent);
		this.level.Init();
		coupler.Init();
		display.Init();
		honeyTest.Init();
		if (_gameState != GameState.EstablishingShot)
		{
			_gameState = GameState.EstablishingShot;
			m_OnGameStateChanged?.Invoke(_gameState, GameState.EstablishingShot);
		}
		global::Singleton<UIIconGenerator>.Instance.UpdateIcons();
		OnInit?.Invoke();
	}

	[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(GameManager._003CHandleIntro_003Ed__54))]
	[global::Cpp2ILInjected.Token(Token = "0x60002EE")]
	[global::Cpp2ILInjected.Address(RVA = "0x100AF88", Offset = "0x100AF88", Length = "0x78")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tgoto L_0017;\n\tv23 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv24 = v23 + 0xCC0;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv43 = 1;\n\t*([302AA47]) = v43;\nL_0017:\n\tv45 = new *([v18 @ X21_v1 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+CC0])();\n\tSystem.Object::.ctor(v45);\n\t*([v45 @ X0_v3 (System.Object)+10]) = 0;\n\tv49 = v45 + 0x20;\n\t*([v45 @ X0_v3 (System.Object)+20]) = this;\n\tv51 = 0xF3F1B4(v49, this, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\treturn v45;\n// 28 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private global::System.Collections.IEnumerator HandleIntro()
	{
		//IL_000e: Expected I, but got O
		//IL_0037: Expected O, but got I
		nint num = 0;
		object obj = new object();
		_ = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		return (global::System.Collections.IEnumerator)obj;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60002EF")]
	[global::Cpp2ILInjected.Address(RVA = "0x100B02C", Offset = "0x100B02C", Length = "0x3F4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_002D;\n\tv37 = Il2CppMethodInfo;\n\tv38 = v37 + 0x9B0;\n\tv39 = \"il2cpp_codegen_initialize_runtime_metadata\"(v38, methodInfo, v41, v42, v43, v44, v45, v46, mousePos, v0, v47, v48, v49, v50, v51, v52);\n\tv70 = Il2CppMethodInfo;\n\tv71 = v70 + 0x78;\n\tv72 = \"il2cpp_codegen_initialize_runtime_metadata\"(v71, methodInfo, v41, v42, v43, v44, v45, v46, mousePos, v0, v47, v48, v49, v50, v51, v52);\n\tv89 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv90 = v89 + 0xFD8;\n\tv91 = \"il2cpp_codegen_initialize_runtime_metadata\"(v90, methodInfo, v41, v42, v43, v44, v45, v46, mousePos, v0, v47, v48, v49, v50, v51, v52);\n\tv254 = Il2CppMethodInfo;\n\tv255 = v254 + 0xC70;\n\tv256 = \"il2cpp_codegen_initialize_runtime_metadata\"(v255, methodInfo, v41, v42, v43, v44, v45, v46, mousePos, v0, v47, v48, v49, v50, v51, v52);\n\tv323 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv324 = v323 + 0xA38;\n\tv325 = \"il2cpp_codegen_initialize_runtime_metadata\"(v324, methodInfo, v41, v42, v43, v44, v45, v46, mousePos, v0, v47, v48, v49, v50, v51, v52);\n\tv409 = \"l1\";\n\tv410 = v409 + 0x850;\n\tv54 = \"il2cpp_codegen_initialize_runtime_metadata\"(v410, methodInfo, v41, v42, v43, v44, v45, v46, mousePos, v0, v47, v48, v49, v50, v51, v52);\n\tv56 = 1;\n\t*([302AA48]) = v56;\nL_002D:\n\tv58 = this._gameState - 1;\n\tv59 = v58 < 1;\n\tv60 = ~v59;\n\tv61 = v58 - 1;\n\tv63 = v61 == 0;\n\tv68 = ~v63;\n\tv69 = v60 & v68;\n\tif (v69) goto L_0044;\n\tthis._gameState = 3;\n\tv74 = this.OnGameStateChanged;\n\tv75 = this.OnGameStateChanged == 0;\n\tif (v75) goto L_0044;\n\tv206 = v74.method;\n\tv74.invoke_impl(v84, v74.method_code, this._gameState, 3, v74.method, v43, v44, v45, v46, mousePos, mousePos.y, v47, v48, v49, v50, v51, v52);\nL_0044:\n\tv87 = this.level;\n\tv104 = v87.moveCount < 1;\n\tif (v104) goto L_009E;\n\tv212 = UnityEngine.Camera::get_main();\n\tv213 = UnityEngine.Component::get_transform(v212);\n\tv144 = UnityEngine.Transform::get_position(v213);\n\tv214 = UnityEngine.Camera::get_main();\n\tv412 = -v144.z;\n\t// 105 MakeStruct v134 @ AGG100B13C_1_v3 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), mousePos @ V0 (UnityEngine.Vector2), mousePos.y (System.Single), v412 @ V2_v4\n\tv147 = UnityEngine.Camera::ScreenToWorldPoint(v214, v134);\n\tv142 = this.selectionRadius;\n\t// 116 MakeStruct v128 @ AGG100B158_1_v3 (UnityEngine.Vector2), typeof(UnityEngine.Vector2), v147 @ V0_v6 (UnityEngine.Vector3), v147.y (System.Single)\n\tv301 = FluidSolver::FindClosestParticle(this.solver, v128, this.selectionRadius);\n\tv304 = v301 + 1;\n\tv181 = v304 == 0;\n\tif (v181) goto L_009E;\n\tv415 = FluidSolver::FindContiguousRegionIndices(this.solver, v301);\n\tv217 = this.solver;\n\tv416 = v301 & 0xFFFFFFFF;\n\tv299 = v416 << 2;\n\tv417 = v217.fishIds;\n\tv303 = *([v417 @ X8_v9 (Unity.Collections.NativeArray`1<System.Int32>)+v299 @ X9_v4 (System.Int32)]) + 1;\n\tv285 = v303 == 0;\n\tif (v285) goto L_00A0;\nL_009E:\n\treturn;\nL_00A0:\n\tv418 = v217.octopusIds;\n\tv420 = *([v418 @ X10_v3 (Unity.Collections.NativeArray`1<System.Int32>)+v301 @ X0_v12 (System.Int32)*4]) + 1;\n\tv422 = v420 == 0;\n\tif (v422) goto L_00FC;\nL_00A8:\n\tv238 = this.OnRejectInput;\n\tv442 = this.OnRejectInput == 0;\n\tif (v442) goto L_00B5;\n\tv238.invoke_impl(v447, v238.method_code, v415, v238.method, v206, v43, v44, v45, v46, v146, v147.y, v142, v48, v49, v50, v51, v52);\nL_00B5:\n\tFluidSolver::StartRejectFlash(this.solver, v415);\n\tgoto L_00BF;\n\tv461 = \"il2cpp_codegen_runtime_class_init\"(v455, v449, v201, v205, v43, v44, v45, v46, v146, v251, v141, v48, v49, v50, v51, v52);\nL_00BF:\n\tv463 = Il2CppMethodInfo;\n\tv218 = UnityEngine.Object::Instantiate /* +1 sharing this address */(this.splashEffectPrefab, *([v463 @ X8_v29 (Il2CppMethodInfo)+78]));\n\tv467 = UnityEngine.Component::get_transform(v218);\n\tgoto L_00D6;\n\tv485 = System.Xml.ValidateNames;\n\tv486 = v485 + 0xD0;\n\tv487 = \"il2cpp_codegen_initialize_runtime_metadata\"(v486, v158, v201, v205, v43, v44, v45, v46, v146, v251, v141, v48, v49, v50, v51, v52);\n\tv488 = 1;\n\t*([2DD4422]) = v488;\nL_00D6:\n\tv501 = System.Xml.ValidateNames;\n\tv503 = *([v501 @ X8_v33 (Il2CppClass<System.Xml.ValidateNames>)+D0]);\n\tv390 = *([v503 @ X8_v35+B8]);\n\tv506 = *([v390 @ X8_v36+58]) * 0;\n\tv512 = *([v390 @ X8_v36+54]) * 9f;\n\tv513 = v147 + v512;\n\t// 232 MakeStruct v330 @ AGG100B2B0_1_v1 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), v513 @ V0_v14 (System.Single), v506 @ V0_v11, v514 @ V1.S1\n\tUnityEngine.Transform::set_position(v467, v330);\n\tUnityEngine.Object::Destroy(v218, 0.5f);\n\treturn;\nL_00FC:\n\tv335 = v217.powerUpIds;\n\tv388 = *([v335 @ X10_v5 (Unity.Collections.NativeArray`1<System.Int32>)+v299 @ X9_v4 (System.Int32)]) + 1;\n\tv374 = v388 == 0;\n\tif (v374) goto L_0119;\n\tFluidSolver::RadialDestroy(v217, *([v335 @ X10_v5 (Unity.Collections.NativeArray`1<System.Int32>)+v299 @ X9_v4 (System.Int32)]));\n\tTapticPlugin.TapticManager::Impact(2);\n\tGameManager::TakeMove(this);\n\treturn;\nL_0119:\n\tv116 = v217.spongeIds;\n\tv438 = *([v116 @ X10_v6 (Unity.Collections.NativeArray`1<System.Int32>)+v299 @ X9_v4 (System.Int32)]) + 1;\n\tv428 = v438 == 0;\n\tv426 = ~v428;\n\tif (v426) goto L_00A8;\n\tv451 = v217.isWater;\n\tv452 = *([v451 @ X9_v6 (Unity.Collections.NativeArray`1<System.Boolean>)+v301 @ X0_v12 (System.Int32)]) == 0;\n\tv439 = ~v452;\n\tif (v439) goto L_00A8;\n\tv459 = v217.isHoneyCoated;\n\tv460 = *([v459 @ X9_v8 (Unity.Collections.NativeArray`1<System.Boolean>)+v301 @ X0_v12 (System.Int32)]) == 0;\n\tv440 = ~v460;\n\tif (v440) goto L_00A8;\n\tv209 = v217.particleTypes;\n\tv161 = *([v209 @ X9_v10 (Unity.Collections.NativeArray`1<System.Int32>)+v301 @ X0_v12 (System.Int32)*4]) > 7;\n\tif (v161) goto L_00A8;\n\tv162 = v415._count <= this.minRemoveParticles;\n\tif (v162) goto L_0159;\n\t// 340 MakeStruct v482 @ AGG100B394_3_v4 (UnityEngine.Vector2), typeof(UnityEngine.Vector2), v147 @ V0_v6 (UnityEngine.Vector3), v147.y (System.Single)\n\tFluidSolver::UserRemoveRegion(v217, v415, v301, v482, 0.3f);\n\tGameManager::TakeMove(this);\n\tgoto L_0164;\nL_0159:\n\tv483 = this.OnTooSmallReject;\n\tv484 = this.OnTooSmallReject == 0;\n\tif (v484) goto L_0164;\n\tv483.invoke_impl(v495, v483.method_code, v483.method, 0, v206, v43, v44, v45, v46, v147, v147.y, this.selectionRadius, v48, v49, v50, v51, v52);\nL_0164:\n\tTapticPlugin.TapticManager::Impact(1);\n\tgoto L_016D;\n\tv523 = \"il2cpp_codegen_runtime_class_init\"(v519, v156, v202, v206, v43, v44, v45, v46, v147, v252, v142, v48, v49, v50, v51, v52);\nL_016D:\n\tv525 = Il2CppMethodInfo;\n\tv219 = Singleton`1::get_Instance /* +1 sharing this address */(*([v525 @ X8_v17 (Il2CppMethodInfo)+C70]));\n\tv527 = \"l1\";\n\tAudioManager::PlayClip(v219, *([v527 @ X8_v19 (System.String)+850]));\n\tv274 = v415._count > this.minRemoveParticles;\n\tif (v274) goto L_009E;\n\tgoto L_00A8;\n\tthrow System.NullReferenceException;\n\treturn;\n// 256 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void OnClickUserInputPanel(global::UnityEngine.Vector2 mousePos)
	{
		//IL_00c0: Expected O, but got F4
		//IL_00f1: Expected F4, but got O
		//IL_01ad: Expected I4, but got I8
		//IL_01de: Expected O, but got I
		//IL_021f: Expected O, but got I
		//IL_03fd: Expected O, but got I
		//IL_02c5: Expected I, but got O
		//IL_02d5: Expected O, but got I
		//IL_02e5: Expected O, but got I
		//IL_02fb: Expected O, but got I
		//IL_0341: Expected F4, but got O
		//IL_034e: Expected F4, but got O
		//IL_05e3: Expected O, but got I
		int num = (int)(_gameState - 1);
		bool flag = num < 1;
		bool flag2 = !flag;
		int num2 = num - 1;
		bool flag3 = num2 == 0;
		bool flag4 = !flag3;
		if (!(flag2 && flag4))
		{
			_gameState = GameState.Gameplay;
			m_OnGameStateChanged?.Invoke(_gameState, GameState.Gameplay);
		}
		Level level = this.level;
		if (level.moveCount < 1)
		{
			return;
		}
		global::UnityEngine.Camera main = global::UnityEngine.Camera.main;
		global::UnityEngine.Transform transform = main.transform;
		global::UnityEngine.Vector3 position = transform.position;
		global::UnityEngine.Camera main2 = global::UnityEngine.Camera.main;
		object obj = 0f - position.z;
		global::UnityEngine.Vector3 position2 = default(global::UnityEngine.Vector3);
		global::UnityEngine.Vector2 vector = default(global::UnityEngine.Vector2);
		position2.x = vector.x;
		position2.y = mousePos.y;
		position2.z = (float)obj;
		global::UnityEngine.Vector3 vector2 = main2.ScreenToWorldPoint(position2);
		float num3 = selectionRadius;
		global::UnityEngine.Vector2 worldPos = default(global::UnityEngine.Vector2);
		worldPos.x = vector2.x;
		worldPos.y = vector2.y;
		int num4 = solver.FindClosestParticle(worldPos, selectionRadius);
		if (num4 + 1 == 0)
		{
			return;
		}
		global::System.Collections.Generic.HashSet<int> hashSet = solver.FindContiguousRegionIndices(num4);
		FluidSolver fluidSolver = solver;
		int num5 = (int)(num4 & 0xFFFFFFFFL);
		int num6 = num5 << 2;
		global::Unity.Collections.NativeArray<int> fishIds = fluidSolver.fishIds;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X8_v9 (Unity.Collections.NativeArray`1<System.Int32>)+v299 @ X9_v4 (System.Int32)]");
		object obj2 = (nint)0 + (nint)1;
		if (obj2 != null)
		{
			return;
		}
		global::Unity.Collections.NativeArray<int> octopusIds = fluidSolver.octopusIds;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X10_v3 (Unity.Collections.NativeArray`1<System.Int32>)+v301 @ X0_v12 (System.Int32)*4]");
		object obj3 = (nint)0 + (nint)1;
		bool flag5 = obj3 == null;
		global::UnityEngine.Vector3 vector3 = vector2;
		if (flag5)
		{
			global::Unity.Collections.NativeArray<int> powerUpIds = fluidSolver.powerUpIds;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X10_v5 (Unity.Collections.NativeArray`1<System.Int32>)+v299 @ X9_v4 (System.Int32)]");
			if ((uint)((nuint)0u + (nuint)1u) != 0)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X10_v5 (Unity.Collections.NativeArray`1<System.Int32>)+v299 @ X9_v4 (System.Int32)]");
				fluidSolver.RadialDestroy(0);
				global::TapticPlugin.TapticManager.Impact(global::TapticPlugin.ImpactFeedback.Heavy);
				TakeMove();
				return;
			}
			global::Unity.Collections.NativeArray<int> spongeIds = fluidSolver.spongeIds;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X10_v6 (Unity.Collections.NativeArray`1<System.Int32>)+v299 @ X9_v4 (System.Int32)]");
			object obj4 = (nint)0 + (nint)1;
			bool flag6 = obj4 == null;
			bool flag7 = !flag6;
			vector3 = vector2;
			if (!flag7)
			{
				global::Unity.Collections.NativeArray<bool> isWater = fluidSolver.isWater;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ X9_v6 (Unity.Collections.NativeArray`1<System.Boolean>)+v301 @ X0_v12 (System.Int32)]");
				bool flag8 = (nint)0 == 0;
				bool flag9 = !flag8;
				vector3 = vector2;
				if (!flag9)
				{
					global::Unity.Collections.NativeArray<bool> isHoneyCoated = fluidSolver.isHoneyCoated;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ X9_v8 (Unity.Collections.NativeArray`1<System.Boolean>)+v301 @ X0_v12 (System.Int32)]");
					bool flag10 = (nint)0 == 0;
					bool flag11 = !flag10;
					vector3 = vector2;
					if (!flag11)
					{
						global::Unity.Collections.NativeArray<int> particleTypes = fluidSolver.particleTypes;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X9_v10 (Unity.Collections.NativeArray`1<System.Int32>)+v301 @ X0_v12 (System.Int32)*4]");
						bool flag12 = (nint)0 > (nint)7;
						vector3 = vector2;
						if (!flag12)
						{
							if (hashSet.Count > minRemoveParticles)
							{
								global::UnityEngine.Vector2 wPos = default(global::UnityEngine.Vector2);
								wPos.x = vector2.x;
								wPos.y = vector2.y;
								fluidSolver.UserRemoveRegion(hashSet, num4, wPos);
								TakeMove();
								num3 = 0.3f;
								global::System.IntPtr method = default(global::System.IntPtr);
							}
							else
							{
								global::System.Action<global::UnityEngine.Vector2> onTooSmallReject = OnTooSmallReject;
								if (OnTooSmallReject != null)
								{
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v483.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
								}
							}
							global::TapticPlugin.TapticManager.Impact(global::TapticPlugin.ImpactFeedback.Medium);
							nint num7 = 0;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
							string text = "l1";
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ X8_v19 (System.String)+850]");
							AudioManager audioManager = default(AudioManager);
							audioManager.PlayClip((string)0);
							if (hashSet.Count > minRemoveParticles)
							{
								return;
							}
							vector3 = vector2;
						}
					}
				}
			}
		}
		global::System.Action<global::System.Collections.Generic.HashSet<int>> onRejectInput = OnRejectInput;
		if (OnRejectInput != null)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v238.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		solver.StartRejectFlash(hashSet);
		nint num8 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1171058 (UnityEngine.Object::Instantiate, and 1 more at this address)");
		global::UnityEngine.Component component = default(global::UnityEngine.Component);
		global::UnityEngine.Transform transform2 = component.transform;
		nint num9 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X8_v33 (Il2CppClass<System.Xml.ValidateNames>)+D0]");
		object obj5 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X8_v35+B8]");
		object obj6 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X8_v36+58]");
		object obj7 = (nint)0 * (nint)0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X8_v36+54]");
		float num10 = 0f * 9f;
		float x = vector2.x + num10;
		global::UnityEngine.Vector3 position3 = default(global::UnityEngine.Vector3);
		position3.x = x;
		position3.y = (float)obj7;
		object obj8 = default(object);
		position3.z = (float)obj8;
		transform2.position = position3;
		global::UnityEngine.Object.Destroy(component, 0.5f);
	}

	[global::Cpp2ILInjected.Token(Token = "0x60002F0")]
	[global::Cpp2ILInjected.Address(RVA = "0x100B524", Offset = "0x100B524", Length = "0x528")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_003A;\n\tv41 = CollectParticleData[];\n\tv42 = v41 + 0x990;\n\tv43 = \"il2cpp_codegen_initialize_runtime_metadata\"(v42, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58);\n\tv65 = Il2CppMethodInfo;\n\tv66 = v65 + 0x890;\n\tv67 = \"il2cpp_codegen_initialize_runtime_metadata\"(v66, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58);\n\tv341 = CollectParticleData[];\n\tv342 = v341 + 0x2D0;\n\tv343 = \"il2cpp_codegen_initialize_runtime_metadata\"(v342, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58);\n\tv405 = Il2CppMethodInfo;\n\tv406 = v405 + 0xA10;\n\tv407 = \"il2cpp_codegen_initialize_runtime_metadata\"(v406, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58);\n\tv462 = Il2CppMethodInfo;\n\tv463 = v462 + 0xA18;\n\tv464 = \"il2cpp_codegen_initialize_runtime_metadata\"(v463, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58);\n\tv476 = Il2CppMethodInfo;\n\tv477 = v476 + 0xA20;\n\tv478 = \"il2cpp_codegen_initialize_runtime_metadata\"(v477, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58);\n\tv481 = Il2CppMethodInfo;\n\tv482 = v481 + 0xA28;\n\tv483 = \"il2cpp_codegen_initialize_runtime_metadata\"(v482, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58);\n\tv486 = \"Writing object reference to Id '{0}' for {1}.\";\n\tv487 = v486 + 0xA98;\n\tv488 = \"il2cpp_codegen_initialize_runtime_metadata\"(v487, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58);\n\tv601 = CollectParticleData[];\n\tv602 = v601 + 0x718;\n\tv60 = \"il2cpp_codegen_initialize_runtime_metadata\"(v602, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58);\n\tv62 = 1;\n\t*([302AAB6]) = v62;\nL_003A:\n\tv69 = UnityEngine.Component::get_transform(this.light);\n\tv408 = \"Writing object reference to Id '{0}' for {1}.\";\n\tv261 = UnityEngine.Transform::get_forward(v69);\n\tv251 = v261.z;\n\t// 70 MakeStruct v246 @ AGG100B5FC_1_v4 (UnityEngine.Vector4), typeof(UnityEngine.Vector4), v261 @ V0_v8 (UnityEngine.Vector3), v261.y (System.Single), v261.z (System.Single), 0\n\tUnityEngine.Shader::SetGlobalVector(*([v408 @ X20_v5 (System.String)+A98]), v246);\n\tv318 = this.level;\n\tv485 = ~v318.shouldSpawnParticles;\n\tif (v485) goto L_0093;\n\tv319 = this.solver;\n\tv320 = this.queuedCount + v319.<ActiveCount>k__BackingField;\n\tv139 = v320 >= this.targetParticleCount;\n\tif (v139) goto L_0093;\n\tv624 = UnityEngine.Random::Range(4, 7);\n\tv120 = this.particleQueue;\n\tv262 = UnityEngine.Time::get_time();\n\tv631 = v120._version + 1;\n\tv120._version = v631;\n\tv239 = v120._items;\n\tv511 = v262 + 1f;\n\tv512 = v624 | v511;\n\tv635 = v120._size < v239.Length;\n\tv509 = ~v635;\n\tif (v509) goto L_008A;\n\tv639 = v120._size + 1;\n\tv120._size = v639;\n\tv640 = v120._size << 3;\n\tv641 = v239 + v640;\n\t*([v641 @ X8_v72+20]) = v512;\n\tgoto L_0090;\nL_008A:\n\t;\n\tSystem.Collections.Generic.List`1<ParticleQueueData>::AddWithResize(v120, v512);\nL_0090:\n\tv516 = this.queuedCount + v624;\n\tthis.queuedCount = v516;\nL_0093:\n\tv518 = this._gameState & 0xFFFFFFFE;\n\tv140 = v518 != 2;\n\tif (v140) goto L_01E2;\n\tv322 = this.particleQueue;\n\tv141 = v322._size < 1;\n\tif (v141) goto L_01E2;\n\tv264 = UnityEngine.Time::get_time();\n\tv632 = Il2CppMethodInfo;\n\tv620 = System.Collections.Generic.List`1<ParticleQueueData>::get_Item(this.particleQueue, 0);\n\tv324 = v620 >> 0x20;\n\tv142 = v264 <= v324;\n\tif (v142) goto L_01E2;\n\tv132 = *([v632 @ X20_v10 (Il2CppMethodInfo)+A28]);\n\tv290 = System.Collections.Generic.List`1<ParticleQueueData>::get_Item(this.particleQueue, 0);\n\tv122 = this.level;\n\tgoto L_00E1;\n\tv652 = Il2CppMethodInfo;\n\tv653 = v652 + 0x5B0;\n\tv654 = \"il2cpp_codegen_initialize_runtime_metadata\"(v653, v276, v131, v46, v47, v48, v49, v50, v265, v255, v250, v248, v55, v56, v57, v58);\n\tv658 = Il2CppMethodInfo;\n\tv659 = v658 + 0x5B8;\n\tv656 = \"il2cpp_codegen_initialize_runtime_metadata\"(v659, v276, v131, v46, v47, v48, v49, v50, v265, v255, v250, v248, v55, v56, v57, v58);\n\tv657 = 1;\n\t*([302AABD]) = v657;\nL_00E1:\n\tv296 = v122.sections;\n\tv143 = v296._size <= v122.currentSection;\n\tif (v143) goto L_00FC;\n\tv665 = Il2CppMethodInfo;\n\tv132 = *([v665 @ X8_v57 (Il2CppMethodInfo)+5B8]);\n\tv668 = System.Collections.Generic.List`1<LevelSection>::get_Item(v296, v122.currentSection);\n\tv672 = v668 == 0;\n\tif (v672) goto L_00FC;\n\tv108 = v668.y;\nL_00FC:\n\tv291 = UnityEngine.Camera::get_main();\n\tv266 = UnityEngine.Camera::get_orthographicSize(v291);\n\tv326 = this.level;\n\tv109 = v108 + v266;\n\tv144 = v326.fluidSpawnMode != 1;\n\tif (v144) goto L_0120;\n\tv678 = UnityEngine.Random::Range(v326.fluidSpawnXRange, v326.fluidSpawnXRange.y);\n\tv97 = v109 + 2f;\n\tgoto L_0131;\nL_0120:\n\tgoto L_0126;\n\tv689 = System.Xml.ValidateNames;\n\tv690 = v689 + 0x98;\n\tv691 = \"il2cpp_codegen_initialize_runtime_metadata\"(v690, v278, v132, v46, v47, v48, v49, v50, v266, v255, v250, v248, v55, v56, v57, v58);\n\tv694 = 1;\n\t*([2DD4426]) = v694;\nL_0126:\n\tv695 = System.Xml.ValidateNames;\n\tv697 = *([v695 @ X8_v50 (Il2CppClass<System.Xml.ValidateNames>)+98]);\n\tv698 = *([v697 @ X8_v52+B8]);\n\tv251 = v109 + 2f;\n\tv99 = v251 * *([v698 @ X8_v53+10]);\n\tv97 = v251 * *([v698 @ X8_v53+14]);\nL_0131:\n\tv267 = UnityEngine.Random::get_insideUnitCircle();\n\tv711 = CollectParticleData[];\n\tv715 = \"SzArrayNew\"(*([v711 @ X8_v23 (Il2CppClass<CollectParticleData[]>)+2D0]), v290, v132, v46, v47, v48, v49, v50, v267, v267.y, v251, 0, v55, v56, v57, v58);\n\tv716 = CollectParticleData[];\n\tv292 = \"SzArrayNew\"(*([v716 @ X8_v25 (Il2CppClass<CollectParticleData[]>)+718]), v290, v132, v46, v47, v48, v49, v50, v267, v267.y, v251, 0, v55, v56, v57, v58);\n\tv327 = this.level;\n\tv328 = v327.colors;\n\tv719 = v267 * v95;\n\tv100 = v99 + v719;\n\tv456 = UnityEngine.Random::Range(0, v328.Length);\n\tv430 = v290 < 1;\n\tif (v430) goto L_018E;\n\tv453 = v267.y * v95;\n\tv357 = v97 + v453;\n\tv400 = v292 == 0;\n\tif (v400) goto L_01E6;\n\tv353 = v290 & 0xFFFFFFFF;\n\tv351 = v292 + 0x24;\nL_0163:\n\tv755 = UnityEngine.Random::get_insideUnitCircle();\n\tv761 = v755 * 0x3E19999A;\n\tv762 = v755.y * 0x3E19999A;\n\tv763 = v100 + v761;\n\tv764 = v357 + v762;\n\t// 363 MakeStruct v347 @ AGG100B8F0_0_v7 (UnityEngine.Vector2), typeof(UnityEngine.Vector2), v763 @ V0_v24 (System.Single), v764 @ V1_v19 (System.Single)\n\tv395 = Unity.Mathematics.float2::op_Implicit(v347);\n\t*([v351 @ X25_v8-4]) = v395;\n\t*([v351 @ X25_v8]) = v395.y;\n\tv355 = v355 + 1;\n\tv351 = v351 + 8;\n\tv725 = v353 != v355;\n\tif (v725) goto L_0163;\nL_018E:\n\tv739 = FluidSolver::AddClump(this.solver, v292, v456);\n\tv757 = this._particlesSpawnedSinceLastFish + v290;\n\tthis._particlesSpawnedSinceLastFish = v757;\n\tv759 = GameManager::ShouldSpawnFish(this);\n\tv765 = ~v759;\n\tif (v765) goto L_01C9;\n\tv146 = this._particlesSpawnedSinceLastFish < this.fishSpawnThreshold;\n\tif (v146) goto L_01C9;\n\t// 427 MakeStruct v72 @ AGG100B968_1_v6 (UnityEngine.Vector2), typeof(UnityEngine.Vector2), v100 @ V9_v7 (System.Single), v109 @ V8_v9 (System.Single)\n\tv780 = FluidSolver::AddFish(this.solver, v72, 0);\n\tv783 = this._activeFishCount + 1;\n\tthis._activeFishCount = v783;\n\tv784 = CollectParticleData[];\n\tv295 = new *([v784 @ X8_v40 (Il2CppClass<CollectParticleData[]>)+990])();\n\tv787 = Il2CppMethodInfo;\n\tSystem.Action::.ctor(v295, this, *([v787 @ X8_v42 (Il2CppMethodInfo)+890]));\n\tFish::add_OnMenuReached(v780, v295);\n\tv774 = this._fishSpawnedCount + 1;\n\tthis._particlesSpawnedSinceLastFish = 0;\n\tthis._fishSpawnedCount = v774;\nL_01C9:\n\t;\n\tSystem.Collections.Generic.List`1<ParticleQueueData>::RemoveAt(this.particleQueue, 0);\n\tv621 = this.queuedCount - v290;\n\tthis.queuedCount = v621;\nL_01E2:\n\treturn;\n\tv340 = new System.NullReferenceException();\n\tthrow System.IndexOutOfRangeException;\nL_01E6:\n\tv461 = UnityEngine.Random::get_insideUnitCircle();\n\tv469 = v461 * 0x3E19999A;\n\tv470 = v461.y * 0x3E19999A;\n\tv471 = v421 + v469;\n\tv472 = v417 + v470;\n\t// 496 MakeStruct v474 @ AGG100BA44_0_v1 (UnityEngine.Vector2), typeof(UnityEngine.Vector2), v471 @ V0_v4 (System.Single), v472 @ V1_v4 (System.Single)\n\tv475 = Unity.Mathematics.float2::op_Implicit(v474);\n\tthrow System.NullReferenceException;\n// 317 bookkeeping instructions omitted: flag reg\n// ... truncated")]
	private void Update()
	{
		//IL_0095: Expected O, but got I
		//IL_0751: Expected I4, but got I8
		//IL_0299: Expected I4, but got O
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected O, but got Unknown
		//IL_02cb: Expected O, but got I
		//IL_01f6: Expected O, but got I
		//IL_033b: Expected O, but got I
		//IL_07de: Expected I, but got O
		//IL_07ee: Expected O, but got I
		//IL_07fe: Expected O, but got I
		//IL_0845: Expected O, but got F4
		//IL_0417: Expected O, but got I4
		//IL_07a9: Expected I, but got O
		//IL_07c1: Expected I, but got O
		//IL_057c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Expected I4, but got Unknown
		//IL_06a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ab: Expected I4, but got Unknown
		//IL_04eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f0: Expected I4, but got Unknown
		//IL_04ff: Expected O, but got I
		//IL_062d: Expected I, but got O
		//IL_051f: Expected O, but got F4
		//IL_053c: Expected O, but got I
		global::UnityEngine.Transform transform = light.transform;
		string text = "Writing object reference to Id '{0}' for {1}.";
		global::UnityEngine.Vector3 forward = transform.forward;
		float z = forward.z;
		global::UnityEngine.Vector4 value = default(global::UnityEngine.Vector4);
		value.x = forward.x;
		value.y = forward.y;
		value.z = forward.z;
		value.w = 0f;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X20_v5 (System.String)+A98]");
		global::UnityEngine.Shader.SetGlobalVector((string)0, value);
		Level level = this.level;
		if (level.shouldSpawnParticles)
		{
			FluidSolver fluidSolver = solver;
			int num = queuedCount + fluidSolver.ActiveCount;
			if (num < targetParticleCount)
			{
				int num2 = global::UnityEngine.Random.Range(4, 7);
				global::System.Collections.Generic.List<ParticleQueueData> list = particleQueue;
				float time = global::UnityEngine.Time.time;
				ParticleQueueData item = new ParticleQueueData
				{
					count = num2,
					time = time
				};
				list.Add(item);
				int num5 = queuedCount + num2;
				queuedCount = num5;
			}
		}
		int num6 = (int)((long)_gameState & 0xFFFFFFFEL);
		if (num6 != 2)
		{
			return;
		}
		global::System.Collections.Generic.List<ParticleQueueData> list2 = particleQueue;
		if (list2.Count < 1)
		{
			return;
		}
		float time2 = global::UnityEngine.Time.time;
		nint num7 = 0;
		ParticleQueueData particleQueueData = particleQueue[0];
		int num8 = (object)particleQueueData >> 32;
		if (!(time2 > (float)num8))
		{
			return;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v632 @ X20_v10 (Il2CppMethodInfo)+A28]");
		object obj2 = 0;
		ParticleQueueData particleQueueData2 = particleQueue[0];
		Level level2 = this.level;
		global::System.Collections.Generic.List<LevelSection> sections = level2.sections;
		bool flag = sections.Count <= level2.currentSection;
		float num9 = 0f;
		if (!flag)
		{
			nint num10 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v665 @ X8_v57 (Il2CppMethodInfo)+5B8]");
			obj2 = 0;
			LevelSection levelSection = sections[level2.currentSection];
			bool flag2 = levelSection == null;
			num9 = 0f;
			if (!flag2)
			{
				num9 = levelSection.y;
			}
		}
		global::UnityEngine.Camera main = global::UnityEngine.Camera.main;
		float orthographicSize = main.orthographicSize;
		Level level3 = this.level;
		float num11 = num9 + orthographicSize;
		float num13;
		object obj3;
		float num14;
		if (level3.fluidSpawnMode == FluidSpawnMode.CustomRange)
		{
			float num12 = global::UnityEngine.Random.Range(level3.fluidSpawnXRange.x, level3.fluidSpawnXRange.y);
			num13 = num11 + 2f;
			obj3 = 1045220557;
			num14 = num12;
		}
		else
		{
			nint num15 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v695 @ X8_v50 (Il2CppClass<System.Xml.ValidateNames>)+98]");
			object obj4 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v697 @ X8_v52+B8]");
			object obj5 = 0;
			z = num11 + 2f;
			float num16 = z;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v698 @ X8_v53+10]");
			num14 = num16 * 0f;
			float num17 = z;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v698 @ X8_v53+14]");
			num13 = num17 * 0f;
			obj3 = 2f;
		}
		global::UnityEngine.Vector2 insideUnitCircle = global::UnityEngine.Random.insideUnitCircle;
		nint num18 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"SzArrayNew\"");
		nint num19 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"SzArrayNew\"");
		Level level4 = this.level;
		global::UnityEngine.Color[] colors = level4.colors;
		float num20 = insideUnitCircle.x * (float)obj3;
		float num21 = num14 + num20;
		int type = global::UnityEngine.Random.Range(0, colors.Length);
		global::Unity.Mathematics.float2[] array = default(global::Unity.Mathematics.float2[]);
		if ((nint)particleQueueData2 >= 1)
		{
			float num22 = insideUnitCircle.y * (float)obj3;
			float num23 = num13 + num22;
			if (array == null)
			{
				global::UnityEngine.Vector2 insideUnitCircle2 = global::UnityEngine.Random.insideUnitCircle;
				float num24 = insideUnitCircle2.x * 0.15f;
				float num25 = insideUnitCircle2.y * 0.15f;
				float num26 = default(float);
				float x = num26 + num24;
				float num27 = default(float);
				float y = num27 + num25;
				global::UnityEngine.Vector2 vector = default(global::UnityEngine.Vector2);
				vector.x = x;
				vector.y = y;
				global::Unity.Mathematics.float2 float5 = vector;
				throw new global::System.NullReferenceException();
			}
			int num28 = (int)(particleQueueData2 & 0xFFFFFFFFL);
			object obj6 = (nint)array + 36;
			int num29 = 0;
			global::UnityEngine.Vector2 vector2 = default(global::UnityEngine.Vector2);
			do
			{
				global::UnityEngine.Vector2 insideUnitCircle3 = global::UnityEngine.Random.insideUnitCircle;
				float num30 = insideUnitCircle3.x * 0.15f;
				float num31 = insideUnitCircle3.y * 0.15f;
				float x2 = num21 + num30;
				float y2 = num23 + num31;
				vector2.x = x2;
				vector2.y = y2;
				obj6 = ((global::Unity.Mathematics.float2)vector2).y;
				num29++;
				obj6 = (nint)obj6 + 8;
			}
			while (num28 != num29);
		}
		Clump clump = solver.AddClump(array, type);
		int particlesSpawnedSinceLastFish = _particlesSpawnedSinceLastFish + particleQueueData2;
		_particlesSpawnedSinceLastFish = particlesSpawnedSinceLastFish;
		if (ShouldSpawnFish() && _particlesSpawnedSinceLastFish >= fishSpawnThreshold)
		{
			global::UnityEngine.Vector2 pos = default(global::UnityEngine.Vector2);
			pos.x = num21;
			pos.y = num11;
			Fish fish = solver.AddFish(pos);
			int activeFishCount = _activeFishCount + 1;
			_activeFishCount = activeFishCount;
			nint num32 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X8_v42 (Il2CppMethodInfo)+890]");
			global::System.Action value2 = null;
			nint num33 = 0;
			fish.OnMenuReached += value2;
			int fishSpawnedCount = _fishSpawnedCount + 1;
			_particlesSpawnedSinceLastFish = 0;
			_fishSpawnedCount = fishSpawnedCount;
		}
		particleQueue.RemoveAt(0);
		int num34 = queuedCount - particleQueueData2;
		queuedCount = num34;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60002F1")]
	[global::Cpp2ILInjected.Address(RVA = "0x100B454", Offset = "0x100B454", Length = "0xD0")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv54 = this.level;\n\tv19 = v54.moveCount - 1;\n\tv54.moveCount = v19;\n\tv20 = this.OnUserMove;\n\tv21 = this.OnUserMove == 0;\n\tif (v21) goto L_001A;\n\tv20.invoke_impl(v26, v20.method_code, v20.method, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48);\n\tv54 = this.level;\nL_001A:\n\tv56 = v54.moveCount == 0;\n\tif (v56) goto L_0026;\n\treturn;\nL_0026:\n\tv65 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tgoto L_0032;\n\tv92 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv93 = v92 + 0xCC8;\n\tv94 = \"il2cpp_codegen_initialize_runtime_metadata\"(v93, v51, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48);\n\tv96 = 1;\n\t*([302AA49]) = v96;\nL_0032:\n\tv98 = new *([v65 @ X21_v1 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+CC8])();\n\tSystem.Object::.ctor(v98);\n\t*([v98 @ X0_v6 (System.Object)+10]) = 0;\n\tv102 = v98 + 0x20;\n\t*([v98 @ X0_v6 (System.Object)+20]) = this;\n\tv104 = 0xF3F1B4(v102, this, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48);\n\tv83 = UnityEngine.MonoBehaviour::StartCoroutine(this, v98);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 46 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void TakeMove()
	{
		//IL_00a2: Expected I, but got O
		//IL_00d5: Expected O, but got I
		Level level = this.level;
		int moveCount = level.moveCount - 1;
		level.moveCount = moveCount;
		global::System.Action onUserMove = OnUserMove;
		if (OnUserMove != null)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v20.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			level = this.level;
		}
		if (level.moveCount == 0)
		{
			nint num = 0;
			object obj = new object();
			_ = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
			global::UnityEngine.Coroutine coroutine = StartCoroutine((global::System.Collections.IEnumerator)obj);
		}
	}

	[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(GameManager._003CMonitorFailCondition_003Ed__58))]
	[global::Cpp2ILInjected.Token(Token = "0x60002F2")]
	[global::Cpp2ILInjected.Address(RVA = "0x100BC68", Offset = "0x100BC68", Length = "0x78")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tgoto L_0017;\n\tv23 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv24 = v23 + 0xCC8;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv43 = 1;\n\t*([302AA49]) = v43;\nL_0017:\n\tv45 = new *([v18 @ X21_v1 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+CC8])();\n\tSystem.Object::.ctor(v45);\n\t*([v45 @ X0_v3 (System.Object)+10]) = 0;\n\tv49 = v45 + 0x20;\n\t*([v45 @ X0_v3 (System.Object)+20]) = this;\n\tv51 = 0xF3F1B4(v49, this, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\treturn v45;\n// 28 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private global::System.Collections.IEnumerator MonitorFailCondition()
	{
		//IL_000e: Expected I, but got O
		//IL_0037: Expected O, but got I
		nint num = 0;
		object obj = new object();
		_ = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		return (global::System.Collections.IEnumerator)obj;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60002F3")]
	[global::Cpp2ILInjected.Address(RVA = "0x100BD0C", Offset = "0x100BD0C", Length = "0x150")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0029;\n\tv25 = Il2CppMethodInfo;\n\tv26 = v25 + 0x588;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv58 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv59 = v58 + 0x1B0;\n\tv60 = \"il2cpp_codegen_initialize_runtime_metadata\"(v59, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv94 = Il2CppMethodInfo;\n\tv95 = v94 + 0xE48;\n\tv96 = \"il2cpp_codegen_initialize_runtime_metadata\"(v95, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv126 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv127 = v126 + 0xCA8;\n\tv44 = \"il2cpp_codegen_initialize_runtime_metadata\"(v127, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv46 = 1;\n\t*([302AA4A]) = v46;\nL_0029:\n\tv57 = this._gameState != 3;\n\tif (v57) goto L_0078;\n\tv61 = this.level;\n\tv97 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv98 = *([v97 @ X23_v3 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+CA8]);\n\tv100 = *([v98 @ X0_v4+E0]) == 0;\n\tif (v100) goto L_003C;\n\tv161 = *([v98 @ X0_v4+B8]);\n\tv75 = *([v161 @ X8_v11+8]);\n\tv130 = *([v161 @ X8_v11+8]) == 0;\n\tv131 = ~v130;\n\tif (v131) goto L_005B;\n\tgoto L_0045;\nL_003C:\n\tv144 = *([v97 @ X23_v3 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+CA8]);\n\tv161 = *([v144 @ X0_v18+B8]);\n\tv75 = *([v161 @ X8_v11+8]);\n\tv153 = *([v161 @ X8_v11+8]) == 0;\n\tv147 = ~v153;\n\tif (v147) goto L_005B;\nL_0045:\n\tgoto L_004A;\n\tv159 = \"il2cpp_codegen_runtime_class_init\"(v155, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv167 = *([v77 @ X23_v4]);\n\tv162 = *([v167 @ X8_v17+B8]);\nL_004A:\n\tv163 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv166 = new *([v163 @ X8_v12 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+1B0])();\n\tv168 = Il2CppMethodInfo;\n\tSystem.Func`2<System.Object, System.Boolean>::.ctor(v166, *([v161 @ X8_v11]), *([v168 @ X8_v14 (Il2CppMethodInfo)+E48]));\n\tv149 = *([v97 @ X23_v3 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+CA8]);\n\tv172 = *([v149 @ X8_v16+B8]) + 8;\n\t*([v172 @ X0_v14]) = v166;\n\tv143 = 0xF3F1B4(v172, v166, *([v168 @ X8_v14 (Il2CppMethodInfo)+E48]), 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\nL_005B:\n\tv151 = Il2CppMethodInfo;\n\tv79 = System.Linq.Enumerable::All /* +1 sharing this address */(v61.goals, v75, *([v151 @ X8_v8 (Il2CppMethodInfo)+588]));\n\tv81 = v79 == 0;\n\tif (v81) goto L_0078;\n\tGameManager::Win(this);\n\treturn;\nL_0078:\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 68 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void CheckWinCondition()
	{
		//IL_0022: Expected I, but got O
		//IL_0032: Expected O, but got I
		//IL_00bc: Expected O, but got I
		//IL_00cc: Expected O, but got I
		//IL_00dc: Expected O, but got I
		//IL_0067: Expected O, but got I
		//IL_0077: Expected O, but got I
		//IL_0176: Expected I, but got O
		//IL_01a6: Expected O, but got I
		//IL_01bc: Expected O, but got I
		if (_gameState != GameState.Gameplay)
		{
			return;
		}
		Level level = this.level;
		nint num = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X23_v3 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+CA8]");
		object obj = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v4+E0]");
		object obj2;
		object obj3;
		if ((nint)0 != 0)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v4+B8]");
			obj2 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v11+8]");
			obj3 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v11+8]");
			if ((nint)0 != 0)
			{
				goto IL_0111;
			}
		}
		else
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X23_v3 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+CA8]");
			object obj4 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v18+B8]");
			obj2 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v11+8]");
			obj3 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v11+8]");
			if ((nint)0 != 0)
			{
				goto IL_0111;
			}
		}
		nint num2 = 0;
		object obj5 = obj2;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X8_v14 (Il2CppMethodInfo)+E48]");
		object obj6 = null;
		nint num3 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X23_v3 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+CA8]");
		object obj7 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v16+B8]");
		object obj8 = (nint)0 + (nint)8;
		obj8 = obj6;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		obj3 = obj6;
		goto IL_0111;
		IL_0111:
		nint num4 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @112902C (System.Linq.Enumerable::All, and 1 more at this address)");
		object obj9 = default(object);
		if (obj9 != null)
		{
			Win();
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x60002F4")]
	[global::Cpp2ILInjected.Address(RVA = "0x100BF74", Offset = "0x100BF74", Length = "0xB0")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv21 = this._gameState == 2;\n\tif (v21) goto L_0020;\n\tthis._gameState = 2;\n\tv27 = this.OnGameStateChanged;\n\tv28 = this.OnGameStateChanged == 0;\n\tif (v28) goto L_0020;\n\tv27.invoke_impl(v36, v27.method_code, this._gameState, 2, v27.method, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63);\nL_0020:\n\tv46 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tgoto L_002C;\n\tv64 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv65 = v64 + 0xCC0;\n\tv66 = \"il2cpp_codegen_initialize_runtime_metadata\"(v65, v16, v29, v32, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63);\n\tv69 = 1;\n\t*([302AA47]) = v69;\nL_002C:\n\tv71 = new *([v46 @ X21_v1 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+CC0])();\n\tSystem.Object::.ctor(v71);\n\t*([v71 @ X0_v4 (System.Object)+10]) = 0;\n\tv75 = v71 + 0x20;\n\t*([v71 @ X0_v4 (System.Object)+20]) = this;\n\tv77 = 0xF3F1B4(v75, this, 2, v27.method, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63);\n\tv87 = UnityEngine.MonoBehaviour::StartCoroutine(this, v71);\n\treturn;\n// 44 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void StartIntroScreen()
	{
		//IL_007f: Expected I, but got O
		//IL_00a3: Expected O, but got I
		if (_gameState != GameState.IntroScreen)
		{
			_gameState = GameState.IntroScreen;
			m_OnGameStateChanged?.Invoke(_gameState, GameState.IntroScreen);
		}
		nint num = 0;
		object obj = new object();
		_ = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		global::UnityEngine.Coroutine coroutine = StartCoroutine((global::System.Collections.IEnumerator)obj);
	}

	[global::Cpp2ILInjected.Token(Token = "0x60002F5")]
	[global::Cpp2ILInjected.Address(RVA = "0x100B420", Offset = "0x100B420", Length = "0x34")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv6 = this._gameState == 3;\n\tif (v6) goto L_0015;\n\tthis._gameState = 3;\n\tv12 = this.OnGameStateChanged;\n\tv13 = this.OnGameStateChanged == 0;\n\tif (v13) goto L_0015;\n\t// 20 IndirectJump v12.invoke_impl (System.IntPtr), v12.method_code (System.IntPtr), v12.method_code (System.IntPtr), this._gameState (GameState), 3, v12.method (System.IntPtr), v12.invoke_impl (System.IntPtr), v22 @ X5, v23 @ X6, v24 @ X7, v25 @ V0, v26 @ V1, v27 @ V2, v28 @ V3, v29 @ V4, v30 @ V5, v31 @ V6, v32 @ V7\nL_0015:\n\treturn;\n// 14 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void EndIntro()
	{
		if (_gameState != GameState.Gameplay)
		{
			_gameState = GameState.Gameplay;
			m_OnGameStateChanged?.Invoke(_gameState, GameState.Gameplay);
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x60002F6")]
	[global::Cpp2ILInjected.Address(RVA = "0x100BE5C", Offset = "0x100BE5C", Length = "0x118")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0017;\n\tv17 = Il2CppFieldInfo;\n\tv18 = v17 + 0x960;\n\tv19 = \"il2cpp_codegen_initialize_runtime_metadata\"(v18, methodInfo, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34);\n\tv37 = 1;\n\t*([302AA4B]) = v37;\nL_0017:\n\tv43 = this._gameState == 5;\n\tif (v43) goto L_0028;\n\tthis._gameState = 5;\n\tv49 = this.OnGameStateChanged;\n\tv50 = this.OnGameStateChanged == 0;\n\tif (v50) goto L_0028;\n\tv49.invoke_impl(v59, v49.method_code, this._gameState, 5, v49.method, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34);\nL_0028:\n\tv63 = ApplicationManager::get_appData();\n\tv66 = v63.playerData;\n\tv77 = v66.levelIndex + 1;\n\tv66.levelIndex = v77;\n\tv95 = UnityEngine.Random::Range(0x32, 0x64);\n\tthis.coinsCollected = v95;\n\tv80 = ApplicationManager::get_appData();\n\tv90 = v80.playerData;\n\tv78 = this.coinsCollected + v90.coinCount;\n\tv90.coinCount = v78;\n\tv81 = ApplicationManager::get_appData();\n\tApplicationData::SavePlayerData(v81);\n\tv82 = ApplicationManager::get_appData();\n\tv138 = Il2CppFieldInfo;\n\tv140 = v82.playerData + 0x14;\n\tv142 = System.Int32::ToString(v140);\n\tv100 = v142 != 0;\n\tif (v100) goto L_FFFFFFFF;\n\tgoto L_006A;\nL_006A:\n\tGameAnalyticsSDK.GameAnalytics::NewProgressionEvent(2, v120);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 74 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public unsafe void Win()
	{
		//IL_0154: Expected O, but got I
		if (_gameState != GameState.Win)
		{
			_gameState = GameState.Win;
			m_OnGameStateChanged?.Invoke(_gameState, GameState.Win);
		}
		ApplicationData appData = ApplicationManager.appData;
		PlayerData playerData = appData.playerData;
		int levelIndex = playerData.levelIndex + 1;
		playerData.levelIndex = levelIndex;
		int num = global::UnityEngine.Random.Range(50, 100);
		coinsCollected = num;
		ApplicationData appData2 = ApplicationManager.appData;
		PlayerData playerData2 = appData2.playerData;
		int coinCount = coinsCollected + playerData2.coinCount;
		playerData2.coinCount = coinCount;
		ApplicationData appData3 = ApplicationManager.appData;
		appData3.SavePlayerData();
		ApplicationData appData4 = ApplicationManager.appData;
		nint num2 = 0;
		int num3 = (int)((nint)appData4.playerData + 20);
		string text = num3.ToString();
		string progression;
		if (text == null)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X19_v2 (Il2CppFieldInfo)+960]");
			progression = (string)0;
		}
		else
		{
			progression = text;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x60002F7")]
	[global::Cpp2ILInjected.Address(RVA = "0x100C024", Offset = "0x100C024", Length = "0xAC")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0017;\n\tv17 = Il2CppFieldInfo;\n\tv18 = v17 + 0x960;\n\tv19 = \"il2cpp_codegen_initialize_runtime_metadata\"(v18, methodInfo, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34);\n\tv37 = 1;\n\t*([302AA4C]) = v37;\nL_0017:\n\tv43 = this._gameState == 4;\n\tif (v43) goto L_0028;\n\tthis._gameState = 4;\n\tv49 = this.OnGameStateChanged;\n\tv50 = this.OnGameStateChanged == 0;\n\tif (v50) goto L_0028;\n\tv49.invoke_impl(v59, v49.method_code, this._gameState, 4, v49.method, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34);\nL_0028:\n\tv63 = ApplicationManager::get_appData();\n\tv71 = Il2CppFieldInfo;\n\tv73 = v63.playerData + 0x14;\n\tv75 = System.Int32::ToString(v73);\n\tv86 = v75 != 0;\n\tif (v86) goto L_FFFFFFFF;\n\tgoto L_004A;\nL_004A:\n\tGameAnalyticsSDK.GameAnalytics::NewProgressionEvent(3, v100);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 54 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public unsafe void Fail()
	{
		//IL_009f: Expected O, but got I
		if (_gameState != GameState.Fail)
		{
			_gameState = GameState.Fail;
			m_OnGameStateChanged?.Invoke(_gameState, GameState.Fail);
		}
		ApplicationData appData = ApplicationManager.appData;
		nint num = 0;
		int num2 = (int)((nint)appData.playerData + 20);
		string text = num2.ToString();
		string progression;
		if (text == null)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X19_v2 (Il2CppFieldInfo)+960]");
			progression = (string)0;
		}
		else
		{
			progression = text;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x60002F8")]
	[global::Cpp2ILInjected.Address(RVA = "0x100C0D0", Offset = "0x100C0D0", Length = "0xA4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0018;\n\tv17 = Il2CppMethodInfo;\n\tv18 = v17 + 0xC60;\n\tv19 = \"il2cpp_codegen_initialize_runtime_metadata\"(v18, methodInfo, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34);\n\tv43 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv44 = v43 + 0xA30;\n\tv36 = \"il2cpp_codegen_initialize_runtime_metadata\"(v44, methodInfo, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34);\n\tv38 = 1;\n\t*([302AA4D]) = v38;\nL_0018:\n\tv42 = this._gameState == 0;\n\tif (v42) goto L_0023;\n\tthis._gameState = 0;\n\tv45 = this.OnGameStateChanged;\n\tv46 = this.OnGameStateChanged == 0;\n\tif (v46) goto L_0023;\n\tv45.invoke_impl(v55, v45.method_code, this._gameState, 0, v45.method, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34);\nL_0023:\n\tv58 = Il2CppMethodInfo;\n\tgoto L_002C;\n\tv65 = \"il2cpp_codegen_runtime_class_init\"(v60, v41, v47, v49, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34);\nL_002C:\n\tv68 = Singleton`1::get_Instance /* +1 sharing this address */(*([v58 @ X19_v2 (Il2CppMethodInfo)+C60]));\n\tApplicationManager::ReloadActiveScene(v68);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 33 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void Reset()
	{
		if (_gameState != GameState.None)
		{
			_gameState = default(GameState);
			m_OnGameStateChanged?.Invoke(_gameState, default(GameState));
		}
		nint num = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
		ApplicationManager applicationManager = default(ApplicationManager);
		applicationManager.ReloadActiveScene();
	}

	[global::Cpp2ILInjected.Token(Token = "0x60002F9")]
	[global::Cpp2ILInjected.Address(RVA = "0x100C174", Offset = "0x100C174", Length = "0x5A0")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0051;\n\tv33 = CollectParticleData[];\n\tv34 = v33 + 0x990;\n\tv35 = \"il2cpp_codegen_initialize_runtime_metadata\"(v34, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv64 = Il2CppMethodInfo;\n\tv65 = v64 + 0x788;\n\tv66 = \"il2cpp_codegen_initialize_runtime_metadata\"(v65, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv72 = Il2CppMethodInfo;\n\tv73 = v72 + 0x968;\n\tv74 = \"il2cpp_codegen_initialize_runtime_metadata\"(v73, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv183 = Il2CppMethodInfo;\n\tv184 = v183 + 0x970;\n\tv185 = \"il2cpp_codegen_initialize_runtime_metadata\"(v184, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv261 = Il2CppMethodInfo;\n\tv262 = v261 + 0x790;\n\tv263 = \"il2cpp_codegen_initialize_runtime_metadata\"(v262, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv315 = Il2CppMethodInfo;\n\tv316 = v315 + 0x978;\n\tv317 = \"il2cpp_codegen_initialize_runtime_metadata\"(v316, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv474 = Il2CppMethodInfo;\n\tv475 = v474 + 0x798;\n\tv476 = \"il2cpp_codegen_initialize_runtime_metadata\"(v475, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv505 = Il2CppMethodInfo;\n\tv506 = v505 + 0x998;\n\tv507 = \"il2cpp_codegen_initialize_runtime_metadata\"(v506, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv509 = Il2CppMethodInfo;\n\tv510 = v509 + 0xF58;\n\tv511 = \"il2cpp_codegen_initialize_runtime_metadata\"(v510, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv525 = Il2CppMethodInfo;\n\tv526 = v525 + 0xC8;\n\tv527 = \"il2cpp_codegen_initialize_runtime_metadata\"(v526, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv576 = Il2CppMethodInfo;\n\tv577 = v576 + 0xD0;\n\tv578 = \"il2cpp_codegen_initialize_runtime_metadata\"(v577, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv584 = Il2CppMethodInfo;\n\tv585 = v584 + 0xC28;\n\tv586 = \"il2cpp_codegen_initialize_runtime_metadata\"(v585, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv589 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv590 = v589 + 0xCB0;\n\tv591 = \"il2cpp_codegen_initialize_runtime_metadata\"(v590, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv593 = Il2CppMethodInfo;\n\tv594 = v593 + 0xE58;\n\tv595 = \"il2cpp_codegen_initialize_runtime_metadata\"(v594, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv597 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv598 = v597 + 0xCB8;\n\tv599 = \"il2cpp_codegen_initialize_runtime_metadata\"(v598, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv606 = Il2CppMethodInfo;\n\tv607 = v606 + 0xCA8;\n\tv608 = \"il2cpp_codegen_initialize_runtime_metadata\"(v607, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv611 = System.Xml.ValidateNames;\n\tv612 = v611 + 0x198;\n\tv52 = \"il2cpp_codegen_initialize_runtime_metadata\"(v612, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv54 = 1;\n\t*([302AA4E]) = v54;\nL_0051:\n\tv62 = this.solver;\n\tv79 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv81 = Il2CppMethodInfo;\n\tv83 = Il2CppMethodInfo;\n\tv88 = System.Collections.Generic.List`1<Fish>::GetEnumerator(v62.fishes);\n\tgoto L_0072;\nL_006D:\n\tv649 = v288 == 0;\n\tv306 = ~v649;\n\tif (v306) goto L_00F3;\nL_0072:\n\tv314 = System.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>::MoveNext(&v87 @ stack_-C0_v5 (System.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>));\n\tv319 = v314 == 0;\n\tif (v319) goto L_0176;\n\tv478 = new *([v79 @ X25_v6 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+CB0])();\n\tSystem.Object::.ctor(v478);\n\tv448 = v478 == 0;\n\tif (v448) goto L_018C;\n\tv529 = v478 + 0x18;\n\t*([v478 @ X0_v28 (System.Object)+18]) = this;\n\tv531 = 0xF3F1B4(v529, this, v383, v390, v39, v40, v41, v42, v411, v197, v196, v46, v47, v48, v49, v50);\n\tv296 = v478 + 0x10;\n\t*([v478 @ X0_v28 (System.Object)+10]) = v189;\n\tv304 = 0xF3F1B4(v296, v189, v383, v390, v39, v40, v41, v42, v411, v197, v196, v46, v47, v48, v49, v50);\n\tv310 = *([v478 @ X0_v28 (System.Object)+10]);\n\tv449 = *([v478 @ X0_v28 (System.Object)+10]) == 0;\n\tif (v449) goto L_018E;\n\tv592 = *([v310 @ X8_v17+D0]) == 0;\n\tv307 = ~v592;\n\tif (v307) goto L_0072;\n\tv451 = *([v310 @ X8_v17+88]) == 0;\n\tif (v451) goto L_0198;\n\tv600 = Il2CppMethodInfo;\n\tv605 = System.Collections.Generic.HashSet`1::GetEnumerator /* +1 sharing this address */(*([v310 @ X8_v17+88]), *([v600 @ X8_v18 (Il2CppMethodInfo)+998]));\nL_009D:\n\tv420 = *([v81 @ X27_v6 (Il2CppMethodInfo)+970]);\n\tv632 = System.Collections.Generic.HashSet`1+Enumerator::MoveNext /* +1 sharing this address */(&v87 @ stack_-C0_v5 (System.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>), *([v81 @ X27_v6 (Il2CppMethodInfo)+970]));\n\tv633 = v632 & 1;\n\tv634 = v633 == 0;\n\tif (v634) goto L_00C2;\n\tv446 = this.solver == 0;\n\tif (v446) goto L_00D9;\n\tv640 = this.solver + 0x1F8;\n\tv222 = *([v83 @ X28_v6 (Il2CppMethodInfo)+C28]);\n\tv627 = Unity.Collections.NativeHashMap`2::TryGetValue /* +1 sharing this address */(v640, v189, &v382 @ stack_-A4_v9, *([v83 @ X28_v6 (Il2CppMethodInfo)+C28]));\n\tv642 = v627 & 1;\n\tv638 = v642 == 0;\n\tif (v638) goto L_00C2;\n\tv462 = this.solver;\n\tv447 = this.solver == 0;\n\tif (v447) goto L_00DB;\n\tv630 = v462.waterDensities;\n\tv241 = *([v630 @ X8_v49 (Unity.Collections.NativeArray`1<System.Single>)+v382 @ stack_-A4_v9*4]);\n\tv646 = *([v630 @ X8_v49 (Unity.Collections.NativeArray`1<System.Single>)+v382 @ stack_-A4_v9*4]) < 0;\n\tv621 = ~v646;\n\tv618 = *([v630 @ X8_v49 (Unity.Collections.NativeArray`1<System.Single>)+v382 @ stack_-A4_v9*4]) == 0;\n\tv647 = ~v618;\n\tv613 = v621 & v647;\n\tif (v613) goto L_009D;\nL_00C2:\n\tv288 = v632 ^ 1;\nL_00C5:\n\tv641 = Il2CppMethodInfo;\n\tv420 = *([v641 @ X8_v24 (Il2CppMethodInfo)+968]);\n\tSystem.Collections.Generic.HashSet`1+Enumerator::Dispose /* +1 sharing this address */(&v87 @ stack_-C0_v5 (System.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>), *([v641 @ X8_v24 (Il2CppMethodInfo)+968]));\n\tgoto L_0196;\n\tgoto L_006D;\n\tgoto L_FFFFFFFF;\n\tgoto L_0176;\nL_00D9:\n\tv431 = new System.NullReferenceException();\n\tgoto L_01AD;\nL_00DB:\n\tv432 = new System.NullReferenceException();\n\tgoto L_01AD;\n\tgoto L_00E0;\n\tgoto L_00E0;\n\tgoto L_00E0;\nL_00E0:\n\tC = X1 < 1;\n\tC = ~C;\n\tTEMP1 = X1 - 1;\n\tN = TEMP1 < 0;\n\tTEMP2 = X1 ^ 1;\n\tTEMP3 = X1 ^ TEMP1;\n\tTEMP4 = TEMP2 & TEMP3;\n\tV = TEMP4 < 0;\n\tTEMPCOND = ~Z;\n\tif (TEMPCOND) goto L_0190;\n\tX0 = 0x274A080(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX21 = *([X0]);\n\tstack[10] = X21;\n\tX0 = 0x274A098(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX23 = 0;\n\tX22 = 1;\n\tX0 = stack[18];\n\tgoto L_00C5;\nL_00F3:\n\tv464 = this.level;\n\tv651 = this.level == 0;\n\tif (v651) goto L_019A;\n\tv653 = Il2CppMethodInfo;\n\tgoto L_00FE;\nL_00FA:\n\tv235 = v235 + 1;\n\tv464 = this.level;\n\tv666 = this.level == 0;\n\tif (v666) goto L_019A;\nL_00FE:\n\tv495 = v464.goals;\n\tv453 = v464.goals == 0;\n\tif (v453) goto L_019C;\n\tv331 = v235 >= v495._size;\n\tif (v331) goto L_0176;\n\tv220 = *([v653 @ X22_v11 (Il2CppMethodInfo)+D0]);\n\tv665 = System.Collections.Generic.List`1<GoalData>::get_Item(v464.goals, v235);\n\tv454 = v665 == 0;\n\tif (v454) goto L_019E;\n\tv681 = v665.goalType != 5;\n\tif (v681) goto L_00FA;\n\tv201 = v665.count < 1;\n\tif (v201) goto L_00FA;\n\tv686 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv252 = new *([v686 @ X8_v32 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+CB8])();\n\tSystem.Object::.ctor(v252);\n\tv254 = v252 == 0;\n\tif (v254) goto L_01A2;\n\tv471 = v252 + 0x20;\n\t*([v252 @ X0_v54 (System.Object)+20]) = v478;\n\tv690 = 0xF3F1B4(v471, v478, *([v653 @ X22_v11 (Il2CppMethodInfo)+D0]), v222, v39, v40, v41, v42, v241, v197, v196, v46, v47, v48, v49, v50);\n\tgoto L_0142;\n\tv697 = \"il2cpp_codegen_ru\n// ... truncated")]
	private unsafe void CheckFishHitWater()
	{
		//IL_0015: Expected I, but got O
		//IL_0110: Expected O, but got I
		//IL_012b: Expected O, but got I
		//IL_014f: Expected O, but got I
		//IL_0ba6: Expected I4, but got O
		//IL_088f: Expected I4, but got O
		//IL_0397: Expected O, but got I4
		//IL_03a8: Expected O, but got I4
		//IL_03d3: Expected I4, but got O
		//IL_0226: Expected O, but got I
		//IL_0236: Expected O, but got I
		//IL_02c2: Expected O, but got I
		//IL_0333: Expected O, but got I
		//IL_0343: Expected O, but got I
		FluidSolver fluidSolver = solver;
		nint num = 0;
		nint num2 = 0;
		nint num3 = 0;
		global::System.Collections.Generic.List<Fish>.Enumerator enumerator = fluidSolver.fishes.GetEnumerator();
		global::System.IntPtr intPtr2 = default(global::System.IntPtr);
		global::System.IntPtr intPtr = intPtr2;
		object obj2 = default(object);
		object obj = obj2;
		global::System.Collections.Generic.List<object>.Enumerator enumerator3 = default(global::System.Collections.Generic.List<object>.Enumerator);
		global::System.Collections.Generic.List<object>.Enumerator enumerator2 = enumerator3;
		object obj9 = default(object);
		global::System.IntPtr intPtr3 = default(global::System.IntPtr);
		global::UnityEngine.Vector2 vector = default(global::UnityEngine.Vector2);
		global::System.Action action = default(global::System.Action);
		object obj13 = default(object);
		object obj14 = default(object);
		object obj15 = default(object);
		float num12 = default(float);
		global::System.NullReferenceException ex = default(global::System.NullReferenceException);
		int num7 = default(int);
		object obj16 = default(object);
		nint num9 = default(nint);
		object obj10 = default(object);
		global::System.Collections.Generic.List<object>.Enumerator enumerator5 = default(global::System.Collections.Generic.List<object>.Enumerator);
		global::System.NullReferenceException ex4 = default(global::System.NullReferenceException);
		object obj17 = default(object);
		while (true)
		{
			bool flag = enumerator3.MoveNext();
			bool flag2 = !flag;
			object obj3 = enumerator3;
			int num4 = 0;
			if (!flag2)
			{
				object obj4 = new object();
				if (obj4 == null)
				{
					throw obj4;
				}
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ X0_v28 (System.Object)+10]");
				object obj7 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ X0_v28 (System.Object)+10]");
				if ((nint)0 != 0)
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v17+D0]");
					if ((nint)0 != 0)
					{
						continue;
					}
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v17+88]");
					if ((nint)0 != 0)
					{
						nint num5 = 0;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @15C35B0 (System.Collections.Generic.HashSet`1::GetEnumerator, and 1 more at this address)");
						nint num6 = intPtr;
						object obj8 = obj;
						global::System.Collections.Generic.List<object>.Enumerator enumerator4 = enumerator3;
						while (true)
						{
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X27_v6 (Il2CppMethodInfo)+970]");
							num7 = 0;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C8 (System.Collections.Generic.HashSet`1+Enumerator::MoveNext, and 1 more at this address)");
							int num8 = (int)((nint)obj9 & 1);
							bool flag3 = num8 == 0;
							num9 = num6;
							obj10 = obj8;
							enumerator5 = enumerator4;
							object obj11;
							float num11;
							global::System.OutOfMemoryException ex3;
							if (!flag3)
							{
								if ((object)solver == null)
								{
									ex = new global::System.NullReferenceException();
									obj11 = 0;
									intPtr = intPtr3;
									obj = 0;
									obj3 = enumerator3;
									num4 = 0;
									enumerator2 = (global::System.Collections.Generic.List<object>.Enumerator)vector;
									enumerator3 = default(global::System.Collections.Generic.List<object>.Enumerator);
									num7 = (int)action;
									break;
								}
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X28_v6 (Il2CppMethodInfo)+C28]");
								obj10 = 0;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17E754C (Unity.Collections.NativeHashMap`2::TryGetValue, and 1 more at this address)");
								int num10 = (int)((nint)obj13 & 1);
								bool flag4 = num10 == 0;
								num9 = (nint)obj14;
								enumerator5 = enumerator4;
								if (!flag4)
								{
									FluidSolver fluidSolver2 = solver;
									if ((object)solver == null)
									{
										global::System.NullReferenceException ex2 = new global::System.NullReferenceException();
										obj11 = obj15;
										num11 = num12;
										intPtr = num6;
										obj = obj8;
										obj3 = enumerator3;
										num4 = 0;
										enumerator2 = enumerator4;
										enumerator3 = default(global::System.Collections.Generic.List<object>.Enumerator);
										ex3 = (global::System.OutOfMemoryException)(object)ex;
										break;
									}
									global::Unity.Collections.NativeArray<float> waterDensities = fluidSolver2.waterDensities;
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X8_v49 (Unity.Collections.NativeArray`1<System.Single>)+v382 @ stack_-A4_v9*4]");
									enumerator5 = (global::System.Collections.Generic.List<object>.Enumerator)0;
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X8_v49 (Unity.Collections.NativeArray`1<System.Single>)+v382 @ stack_-A4_v9*4]");
									bool flag5 = (nint)0 < (nint)0;
									bool flag6 = !flag5;
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X8_v49 (Unity.Collections.NativeArray`1<System.Single>)+v382 @ stack_-A4_v9*4]");
									bool flag7 = (nint)0 == 0;
									bool flag8 = !flag7;
									bool flag9 = flag6 && flag8;
									num9 = (nint)obj14;
									num6 = (nint)obj14;
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X28_v6 (Il2CppMethodInfo)+C28]");
									obj8 = 0;
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X8_v49 (Unity.Collections.NativeArray`1<System.Single>)+v382 @ stack_-A4_v9*4]");
									enumerator4 = (global::System.Collections.Generic.List<object>.Enumerator)0;
									if (flag9)
									{
										continue;
									}
								}
							}
							int num13 = (int)((nint)obj9 ^ 1);
							nint num14 = 0;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v641 @ X8_v24 (Il2CppMethodInfo)+968]");
							num7 = 0;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C4 (System.Collections.Generic.HashSet`1+Enumerator::Dispose, and 1 more at this address)");
							ex3 = new global::System.OutOfMemoryException();
							obj11 = obj15;
							num11 = num12;
							obj3 = enumerator3;
							num4 = 0;
							num7 = (int)obj16;
							ex3 = (global::System.OutOfMemoryException)(object)ex4;
							break;
						}
					}
					else
					{
						global::System.NullReferenceException ex5 = new global::System.NullReferenceException();
						object obj11 = obj15;
						float num11 = num12;
						intPtr = num9;
						obj = obj10;
						obj3 = enumerator3;
						num4 = 0;
						enumerator2 = enumerator5;
						enumerator3 = default(global::System.Collections.Generic.List<object>.Enumerator);
					}
				}
				else
				{
					ex4 = new global::System.NullReferenceException();
					object obj11 = obj15;
					float num11 = num12;
					obj3 = enumerator3;
					num4 = 0;
					num7 = 0;
				}
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BF092C");
				if (num7 != 1)
				{
					break;
				}
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A080 (inside System.__Il2CppComDelegate::Finalize +0xF54)");
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A098 (inside System.__Il2CppComDelegate::Finalize +0xF6C)");
				num4 = (int)obj17;
			}
			obj3.Dispose();
			if (num4 == 0)
			{
				return;
			}
			global::System.OutOfMemoryException ex6 = new global::System.OutOfMemoryException();
			throw ex6;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BF0F2C");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27498DC (inside System.__Il2CppComDelegate::Finalize +0x7B0)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D6F8");
	}

	[global::Cpp2ILInjected.Token(Token = "0x60002FA")]
	[global::Cpp2ILInjected.Address(RVA = "0x100BAFC", Offset = "0x100BAFC", Length = "0x16C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_001F;\n\tv25 = Il2CppMethodInfo;\n\tv26 = v25 + 0xB8;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv49 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv50 = v49 + 0x8D0;\n\tv51 = \"il2cpp_codegen_initialize_runtime_metadata\"(v50, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv82 = Il2CppMethodInfo;\n\tv83 = v82 + 0xE50;\n\tv84 = \"il2cpp_codegen_initialize_runtime_metadata\"(v83, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv90 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv91 = v90 + 0xCA8;\n\tv44 = \"il2cpp_codegen_initialize_runtime_metadata\"(v91, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv46 = 1;\n\t*([302AA4F]) = v46;\nL_001F:\n\tv47 = this.level;\n\tv53 = ~v47.disableAutoFishSpawning;\n\tif (v53) goto L_0031;\nL_002F:\n\treturn returnVal2;\nL_0031:\n\tv86 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv87 = *([v86 @ X23_v4 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+CA8]);\n\tv89 = *([v87 @ X0_v5+E0]) == 0;\n\tif (v89) goto L_0063;\n\tv199 = *([v87 @ X0_v5+B8]);\n\tv101 = *([v199 @ X8_v8+10]);\n\tv122 = *([v199 @ X8_v8+10]) == 0;\n\tif (v122) goto L_006C;\nL_003D:\n\t;\n\tv106 = System.Collections.Generic.List`1<GoalData>::Find(v47.goals, v101);\n\tv108 = v106 == 0;\n\tif (v108) goto L_002F;\n\tv171 = this._fishGoalTarget;\n\tv210 = this._fishGoalTarget == 0;\n\tv169 = ~v210;\n\tif (v169) goto L_004E;\n\tv171 = v106.count;\n\tthis._fishGoalTarget = v106.count;\nL_004E:\n\tv147 = this._fishSpawnedCount - v171;\n\tv144 = v147 < 0;\n\tv138 = this._fishSpawnedCount ^ v171;\n\tv135 = this._fishSpawnedCount ^ v147;\n\tv132 = v138 & v135;\n\tv129 = v132 < 0;\n\tv215 = v144 == v129;\n\tv126 = ~v215;\n\treturn v126;\nL_0063:\n\tv179 = *([v86 @ X23_v4 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+CA8]);\n\tv199 = *([v179 @ X0_v15+B8]);\n\tv101 = *([v199 @ X8_v8+10]);\n\tv189 = *([v199 @ X8_v8+10]) == 0;\n\tv181 = ~v189;\n\tif (v181) goto L_003D;\nL_006C:\n\tgoto L_0071;\n\tv197 = \"il2cpp_codegen_runtime_class_init\"(v184, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv205 = *([v66 @ X23_v5]);\n\tv200 = *([v205 @ X8_v14+B8]);\nL_0071:\n\tv201 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv204 = new *([v201 @ X8_v9 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+8D0])();\n\tv206 = Il2CppMethodInfo;\n\tSystem.Predicate`1<System.Object>::.ctor(v204, *([v199 @ X8_v8]), *([v206 @ X8_v11 (Il2CppMethodInfo)+E50]));\n\tv77 = *([v86 @ X23_v4 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+CA8]);\n\tv212 = *([v77 @ X8_v13+B8]) + 0x10;\n\t*([v212 @ X0_v11]) = v204;\n\tv71 = 0xF3F1B4(v212, v204, *([v206 @ X8_v11 (Il2CppMethodInfo)+E50]), 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv216 = v47.goals == 0;\n\tv74 = ~v216;\n\tif (v74) goto L_003D;\n\treturnVal1 = new System.NullReferenceException();\n\treturn returnVal1;\n// 66 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private bool ShouldSpawnFish()
	{
		//IL_003f: Expected I, but got O
		//IL_004f: Expected O, but got I
		//IL_015a: Expected O, but got I
		//IL_016a: Expected O, but got I
		//IL_017a: Expected O, but got I
		//IL_00e7: Expected I4, but got O
		//IL_0084: Expected O, but got I
		//IL_0094: Expected O, but got I
		//IL_028a: Expected I, but got O
		//IL_02ba: Expected O, but got I
		//IL_02d0: Expected O, but got I
		//IL_01f2: Expected I4, but got O
		Level level = this.level;
		bool result;
		if (level.disableAutoFishSpawning)
		{
			result = false;
			goto IL_0201;
		}
		nint num = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X23_v4 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+CA8]");
		object obj = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v5+E0]");
		object obj2;
		global::System.Predicate<object> match;
		if ((nint)0 != 0)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v5+B8]");
			obj2 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v8+10]");
			match = (global::System.Predicate<object>)0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v8+10]");
			if ((nint)0 != 0)
			{
				goto IL_00b9;
			}
		}
		else
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X23_v4 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+CA8]");
			object obj3 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X0_v15+B8]");
			obj2 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v8+10]");
			match = (global::System.Predicate<object>)0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v8+10]");
			if ((nint)0 != 0)
			{
				goto IL_00b9;
			}
		}
		nint num2 = 0;
		object obj4 = obj2;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v11 (Il2CppMethodInfo)+E50]");
		global::System.Predicate<object> predicate = null;
		nint num3 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X23_v4 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+CA8]");
		object obj5 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v13+B8]");
		object obj6 = (nint)0 + (nint)16;
		obj6 = predicate;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		bool flag = level.goals == null;
		bool flag2 = !flag;
		match = predicate;
		if (!flag2)
		{
			global::System.NullReferenceException ex = new global::System.NullReferenceException();
			return (byte)(int)ex != 0;
		}
		goto IL_00b9;
		IL_0201:
		return result;
		IL_00b9:
		GoalData goalData = level.goals.Find(match);
		bool flag3 = goalData == null;
		result = (byte)(int)goalData != 0;
		if (!flag3)
		{
			int num4 = _fishGoalTarget;
			if (_fishGoalTarget == 0)
			{
				num4 = goalData.count;
				_fishGoalTarget = goalData.count;
			}
			int num5 = _fishSpawnedCount - num4;
			bool flag4 = num5 < 0;
			int num6 = _fishSpawnedCount ^ num4;
			int num7 = _fishSpawnedCount ^ num5;
			int num8 = num6 & num7;
			bool flag5 = num8 < 0;
			bool flag6 = flag4 == flag5;
			return !flag6;
		}
		goto IL_0201;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60002FB")]
	[global::Cpp2ILInjected.Address(RVA = "0x100C724", Offset = "0x100C724", Length = "0x154")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv26 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv30 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tgoto L_0031;\n\tv39 = Il2CppMethodInfo;\n\tv40 = v39 + 0xA08;\n\tv41 = \"il2cpp_codegen_initialize_runtime_metadata\"(v40, methodInfo, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56);\n\tv71 = Il2CppMethodInfo;\n\tv72 = v71 + 0xCF0;\n\tv73 = \"il2cpp_codegen_initialize_runtime_metadata\"(v72, methodInfo, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56);\n\tv76 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv77 = v76 + 0x230;\n\tv78 = \"il2cpp_codegen_initialize_runtime_metadata\"(v77, methodInfo, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56);\n\tv84 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv85 = v84 + 0x558;\n\tv86 = \"il2cpp_codegen_initialize_runtime_metadata\"(v85, methodInfo, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56);\n\tv90 = Il2CppMethodInfo;\n\tv91 = v90 + 0xC88;\n\tv92 = \"il2cpp_codegen_initialize_runtime_metadata\"(v91, methodInfo, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56);\n\tv95 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv96 = v95 + 0xA48;\n\tv58 = \"il2cpp_codegen_initialize_runtime_metadata\"(v96, methodInfo, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56);\n\tv60 = 1;\n\t*([302AA50]) = v60;\nL_0031:\n\tv61 = Il2CppMethodInfo;\n\tthis.targetParticleCount = 6.36598737512E-312d;\n\tthis.selectionRadius = 0.5f;\n\tthis.powerUpMergeDistance = 1f;\n\tthis.coinsCollected = 0x64;\n\tv70 = new *([v26 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+558])();\n\tSystem.Collections.Generic.List`1<Water>::.ctor(v70);\n\tv80 = this + 0xA8;\n\tthis.waters = v70;\n\tv83 = 0xF3F1B4(v80, v70, v43, v44, v45, v46, v47, v48, 6.36598737512E-312d, v50, v51, v52, v53, v54, v55, v56);\n\tthis.failTimerDuration = 3f;\n\tv89 = new *([v30 @ X24_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+230])();\n\tSystem.Collections.Generic.List`1<ParticleQueueData>::.ctor(v89);\n\tv97 = v80 + 0xC0;\n\tthis.particleQueue = v89;\n\tv99 = 0xF3F1B4(v97, v89, v43, v44, v45, v46, v47, v48, 6.36598737512E-312d, v50, v51, v52, v53, v54, v55, v56);\n\tgoto L_0066;\n\tv104 = \"il2cpp_codegen_runtime_class_init\"(v100, v98, v43, v44, v45, v46, v47, v48, v64, v50, v51, v52, v53, v54, v55, v56);\nL_0066:\n\tSingleton`1::.ctor /* +1 sharing this address */(this, *([v61 @ X25_v2 (Il2CppMethodInfo)+C88]));\n\treturn;\n// 61 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public GameManager()
	{
		//IL_000e: Expected I, but got O
		//IL_001d: Expected I, but got O
		//IL_0085: Expected I4, but got F8
		//IL_009a: Expected I4, but got F8
		//IL_00d1: Expected O, but got I
		//IL_004c: Expected O, but got I
		nint num = 0;
		nint num2 = 0;
		nint num3 = 0;
		targetParticleCount = 0;
		fishSpawnThreshold = 6.36598737512E-312 >> 32;
		selectionRadius = 0.5f;
		powerUpMergeDistance = 1f;
		coinsCollected = 100;
		global::System.Collections.Generic.List<Water> list = new global::System.Collections.Generic.List<Water>();
		object obj = (nint)this + 168;
		waters = list;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		failTimerDuration = 3f;
		global::System.Collections.Generic.List<ParticleQueueData> list2 = new global::System.Collections.Generic.List<ParticleQueueData>();
		particleQueue = list2;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18ABE40 (Singleton`1::.ctor, and 1 more at this address)");
	}
}
