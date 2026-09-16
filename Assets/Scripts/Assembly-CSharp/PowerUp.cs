[global::Cpp2ILInjected.Token(Token = "0x20000C4")]
public class PowerUp : SpecialFluid
{
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x20000C5")]
	private sealed class _003CHandleInAnim_003Ed__11 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000449")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[global::Cpp2ILInjected.Token(Token = "0x400044A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[global::Cpp2ILInjected.Token(Token = "0x17000039")]
		object global::System.Collections.Generic.IEnumerator<object>.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000389")]
			[global::Cpp2ILInjected.Address(RVA = "0x101434C", Offset = "0x101434C", Length = "0x8")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn this.<>2__current;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
			get
			{
				return _003C_003E2__current;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700003A")]
		object global::System.Collections.IEnumerator.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600038B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1014394", Offset = "0x1014394", Length = "0x8")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn this.<>2__current;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
			get
			{
				return _003C_003E2__current;
			}
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x6000386")]
		[global::Cpp2ILInjected.Address(RVA = "0x1013E30", Offset = "0x1013E30", Length = "0x2C")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tSystem.Object::.ctor(this);\n\tthis.<>1__state = <>1__state;\n\treturn;\n// 14 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public _003CHandleInAnim_003Ed__11(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x6000387")]
		[global::Cpp2ILInjected.Address(RVA = "0x101429C", Offset = "0x101429C", Length = "0x4")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn;\n")]
		void global::System.IDisposable.Dispose()
		{
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000388")]
		[global::Cpp2ILInjected.Address(RVA = "0x10142A0", Offset = "0x10142A0", Length = "0xAC")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0015;\n\tv21 = System.Xml.ValidateNames;\n\tv22 = v21 + 0x258;\n\tv23 = \"il2cpp_codegen_initialize_runtime_metadata\"(v22, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv41 = 1;\n\t*([302AA7D]) = v41;\nL_0015:\n\tv43 = this.<>1__state == 0;\n\tif (v43) goto L_0025;\n\tv53 = this.<>1__state != 1;\n\tif (v53) goto L_003B;\n\tgoto L_0036;\nL_0025:\n\tthis.<>1__state = 0xFFFFFFFF;\n\tv55 = System.Xml.ValidateNames;\n\tv58 = new *([v55 @ X8_v6 (Il2CppClass<System.Xml.ValidateNames>)+258])();\n\tUnityEngine.WaitForSeconds::.ctor(v58, 0.1f);\n\tv122 = this + 0x18;\n\tthis.<>2__current = v58;\n\tv119 = 0xF3F1B4(v122, v58, v25, v26, v27, v28, v29, v30, 0x3DCCCCCD, v32, v33, v34, v35, v36, v37, v38);\nL_0036:\n\tthis.<>1__state = v85;\nL_003B:\n\tv92 = this.<>1__state == 0;\n\treturn v92;\n// 52 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		private bool MoveNext()
		{
			//IL_004e: Expected I, but got O
			//IL_006e: Expected O, but got I
			int num;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					goto IL_00af;
				}
				num = -1;
			}
			else
			{
				_003C_003E1__state = -1;
				nint num2 = (nint)typeof(global::System.Xml.ValidateNames);
				global::UnityEngine.WaitForSeconds waitForSeconds = new global::UnityEngine.WaitForSeconds(0.1f);
				object obj = (nint)this + 24;
				_003C_003E2__current = waitForSeconds;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
				num = 1;
			}
			_003C_003E1__state = num;
			goto IL_00af;
			IL_00af:
			return _003C_003E1__state == 0;
		}

		bool global::System.Collections.IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x600038A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1014354", Offset = "0x1014354", Length = "0x40")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv10 = Facebook.Unity.Windows.IWindowsFacebook + 0xF30;\n\tv11 = 0xF3F22C(v10, methodInfo, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26);\n\tv27 = new v11();\n\tSystem.NotSupportedException::.ctor(v27);\n\tv31 = Il2CppMethodInfo + 0x520;\n\tv32 = 0xF3F22C(v31, 0, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26);\n\tthrow v27;\n// 13 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		void global::System.Collections.IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0039: Expected O, but got I
			object obj = typeof(global::Facebook.Unity.Windows.IWindowsFacebook) + 3888;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F22C");
			global::System.NotSupportedException ex = new global::System.NotSupportedException();
			object obj2 = (nint)0 + (nint)1312;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F22C");
			throw ex;
		}
	}

	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x20000C6")]
	private sealed class _003CRotateBlob_003Ed__13 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
	{
		[global::Cpp2ILInjected.Token(Token = "0x400044B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[global::Cpp2ILInjected.Token(Token = "0x400044C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[global::Cpp2ILInjected.Token(Token = "0x400044D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public PowerUp _003C_003E4__this;

		[global::Cpp2ILInjected.Token(Token = "0x400044E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private float _003CstartTime_003E5__2;

		[global::Cpp2ILInjected.Token(Token = "0x400044F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private float _003Cduration_003E5__3;

		[global::Cpp2ILInjected.Token(Token = "0x4000450")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private float _003CendTime_003E5__4;

		[global::Cpp2ILInjected.Token(Token = "0x1700003B")]
		object global::System.Collections.Generic.IEnumerator<object>.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600038F")]
			[global::Cpp2ILInjected.Address(RVA = "0x10144A0", Offset = "0x10144A0", Length = "0x8")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn this.<>2__current;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
			get
			{
				return _003C_003E2__current;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700003C")]
		object global::System.Collections.IEnumerator.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000391")]
			[global::Cpp2ILInjected.Address(RVA = "0x10144E8", Offset = "0x10144E8", Length = "0x8")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn this.<>2__current;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
			get
			{
				return _003C_003E2__current;
			}
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x600038C")]
		[global::Cpp2ILInjected.Address(RVA = "0x10140B0", Offset = "0x10140B0", Length = "0x2C")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tSystem.Object::.ctor(this);\n\tthis.<>1__state = <>1__state;\n\treturn;\n// 14 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public _003CRotateBlob_003Ed__13(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x600038D")]
		[global::Cpp2ILInjected.Address(RVA = "0x101439C", Offset = "0x101439C", Length = "0x4")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn;\n")]
		void global::System.IDisposable.Dispose()
		{
		}

		[global::Cpp2ILInjected.Token(Token = "0x600038E")]
		[global::Cpp2ILInjected.Address(RVA = "0x10143A0", Offset = "0x10143A0", Length = "0x100")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = this.<>1__state == 1;\n\tif (v18) goto L_004D;\n\tv23 = this.<>1__state == 0;\n\tv24 = ~v23;\n\tif (v24) goto L_0066;\n\tthis.<>1__state = 0xFFFFFFFF;\n\tv30 = UnityEngine.Time::get_time();\n\tthis.<startTime>5__2 = v30;\n\tthis.<duration>5__3 = 0.35f;\n\tv80 = v30 + 0x3EB33333;\n\tthis.<endTime>5__4 = v80;\n\tv82 = UnityEngine.Time::get_time();\n\tv140 = v82 >= this.<endTime>5__4;\n\tif (v140) goto L_005F;\nL_0030:\n\tv159 = UnityEngine.Time::get_time();\n\tv176 = v159 - this.<startTime>5__2;\n\tv177 = v176 / this.<duration>5__3;\n\tv162 = EasingFunction::EaseOutQuad(v177);\n\tv179 = v162 + -1f;\n\tv99 = v179 * 0.5f;\n\tPowerUp::<RotateBlob>g__SetRot|13_0(this.<>4__this, v99);\n\tv181 = this + 0x18;\n\tthis.<>2__current = 0;\n\tv183 = 0xF3F1B4(v181, 0, v165, v166, v167, v168, v169, v170, v99, 0.5f, this.<duration>5__3, v171, v172, v173, v174, v175);\n\tthis.<>1__state = 1;\n\treturn 1;\nL_004D:\n\tthis.<>1__state = 0xFFFFFFFF;\n\tv27 = UnityEngine.Time::get_time();\n\tv71 = v27 < this.<endTime>5__4;\n\tif (v71) goto L_0030;\nL_005F:\n\tPowerUp::<RotateBlob>g__SetRot|13_0(this.<>4__this, 1f);\nL_0066:\n\treturn 0;\n\treturnVal2 = new System.NullReferenceException();\n\treturn returnVal2;\n// 71 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		private bool MoveNext()
		{
			//IL_0135: Expected O, but got I
			if (_003C_003E1__state != 1)
			{
				if (_003C_003E1__state != 0)
				{
					goto IL_01a5;
				}
				_003C_003E1__state = -1;
				float num = (_003CstartTime_003E5__2 = global::UnityEngine.Time.time);
				_003Cduration_003E5__3 = 0.35f;
				float num2 = num + 0.35f;
				_003CendTime_003E5__4 = num2;
				float time = global::UnityEngine.Time.time;
				if (time < _003CendTime_003E5__4)
				{
					goto IL_00bd;
				}
			}
			else
			{
				_003C_003E1__state = -1;
				float time2 = global::UnityEngine.Time.time;
				if (time2 < _003CendTime_003E5__4)
				{
					goto IL_00bd;
				}
			}
			_003C_003E4__this._003CRotateBlob_003Eg__SetRot_007C13_0(1f);
			goto IL_01a5;
			IL_01a5:
			return false;
			IL_00bd:
			float time3 = global::UnityEngine.Time.time;
			float num3 = time3 - _003CstartTime_003E5__2;
			float t = num3 / _003Cduration_003E5__3;
			float num4 = EasingFunction.EaseOutQuad(t);
			float num5 = num4 + -1f;
			float rot = num5 * 0.5f;
			_003C_003E4__this._003CRotateBlob_003Eg__SetRot_007C13_0(rot);
			object obj = (nint)this + 24;
			_003C_003E2__current = null;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
			_003C_003E1__state = 1;
			return true;
		}

		bool global::System.Collections.IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x6000390")]
		[global::Cpp2ILInjected.Address(RVA = "0x10144A8", Offset = "0x10144A8", Length = "0x40")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv10 = Facebook.Unity.Windows.IWindowsFacebook + 0xF30;\n\tv11 = 0xF3F22C(v10, methodInfo, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26);\n\tv27 = new v11();\n\tSystem.NotSupportedException::.ctor(v27);\n\tv31 = Il2CppMethodInfo + 0x528;\n\tv32 = 0xF3F22C(v31, 0, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26);\n\tthrow v27;\n// 13 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		void global::System.Collections.IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0039: Expected O, but got I
			object obj = typeof(global::Facebook.Unity.Windows.IWindowsFacebook) + 3888;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F22C");
			global::System.NotSupportedException ex = new global::System.NotSupportedException();
			object obj2 = (nint)0 + (nint)1320;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F22C");
			throw ex;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x400043F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public int mergeIndex;

	[global::Cpp2ILInjected.Token(Token = "0x4000440")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public global::UnityEngine.Transform upArrow;

	[global::Cpp2ILInjected.Token(Token = "0x4000441")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public global::UnityEngine.Transform downArrow;

	[global::Cpp2ILInjected.Token(Token = "0x4000442")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public global::UnityEngine.Transform leftArrow;

	[global::Cpp2ILInjected.Token(Token = "0x4000443")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public global::UnityEngine.Transform rightArrow;

	[global::Cpp2ILInjected.Token(Token = "0x4000444")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public float arrowSpacing;

	[global::Cpp2ILInjected.Token(Token = "0x4000445")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xDC")]
	public float arrowZOffset;

	[global::Cpp2ILInjected.Token(Token = "0x4000446")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public global::UnityEngine.Sprite[] sprites;

	[global::Cpp2ILInjected.Token(Token = "0x4000447")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public global::UnityEngine.Sprite[] activeSprites;

	[global::Cpp2ILInjected.Token(Token = "0x4000448")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	public bool isBig;

	[global::Cpp2ILInjected.Token(Token = "0x600037C")]
	[global::Cpp2ILInjected.Address(RVA = "0x1013C30", Offset = "0x1013C30", Length = "0xE8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv20 = &v21 @ stack_-10_v2;\n\tthis.id = _id;\n\tthis.mergeIndex = _mergeIndex;\n\tUnityEngine.Renderer::set_material(this.mr, _material);\n\tthis.isBig = *([v20 @ X29_v1+10]);\n\tPowerUp::InitArrows(this);\n\tv61 = this.mergeIndex < 1;\n\tif (v61) goto L_0052;\n\tv119 = TMPro.KerningTable+<>c__DisplayClass3_0;\n\tgoto L_0038;\n\tv134 = TMPro.KerningTable+<>c__DisplayClass3_0;\n\tv135 = v134 + 0x848;\n\tv136 = \"il2cpp_codegen_initialize_runtime_metadata\"(v135, v37, v39, _particleIds, _fluidType, _compute, _mergeIndex, _material, v41, v42, v43, v44, v45, v46, v47, v48);\n\tv137 = 1;\n\t*([302AA7A]) = v137;\nL_0038:\n\tv140 = new *([v119 @ X25_v3 (Il2CppClass<TMPro.KerningTable+<>c__DisplayClass3_0>)+848])();\n\tSystem.Object::.ctor(v140);\n\t*([v140 @ X0_v8 (System.Object)+10]) = 0;\n\tv131 = UnityEngine.MonoBehaviour::StartCoroutine(this, v140);\nL_0052:\n\tSpecialFluid::Init(this, _solver, _particleIds, _fluidType, _compute);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 63 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void Init(FluidSolver _solver, int _id, global::System.Collections.Generic.HashSet<int> _particleIds, int _fluidType, FluidCompute _compute, int _mergeIndex, global::UnityEngine.Material _material, bool _isBig)
	{
		//IL_007a: Expected I, but got O
		object obj2 = default(object);
		object obj = obj2;
		id = _id;
		mergeIndex = _mergeIndex;
		mr.material = _material;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X29_v1+10]");
		isBig = false;
		InitArrows();
		if (mergeIndex >= 1)
		{
			nint num = (nint)typeof(global::TMPro.KerningTable._003C_003Ec__DisplayClass3_0);
			object routine = new object();
			_ = 0;
			global::UnityEngine.Coroutine coroutine = StartCoroutine((global::System.Collections.IEnumerator)routine);
		}
		base.Init(_solver, _particleIds, _fluidType, _compute);
	}

	[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(PowerUp._003CHandleInAnim_003Ed__11))]
	[global::Cpp2ILInjected.Token(Token = "0x600037D")]
	[global::Cpp2ILInjected.Address(RVA = "0x1013DD4", Offset = "0x1013DD4", Length = "0x5C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv12 = TMPro.KerningTable+<>c__DisplayClass3_0;\n\tgoto L_0014;\n\tv17 = TMPro.KerningTable+<>c__DisplayClass3_0;\n\tv18 = v17 + 0x848;\n\tv19 = \"il2cpp_codegen_initialize_runtime_metadata\"(v18, methodInfo, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34);\n\tv38 = 1;\n\t*([302AA7A]) = v38;\nL_0014:\n\tv40 = new *([v12 @ X20_v1 (Il2CppClass<TMPro.KerningTable+<>c__DisplayClass3_0>)+848])();\n\tSystem.Object::.ctor(v40);\n\t*([v40 @ X0_v3 (System.Object)+10]) = 0;\n\treturn v40;\n// 21 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public global::System.Collections.IEnumerator HandleInAnim()
	{
		//IL_000e: Expected I, but got O
		nint num = (nint)typeof(global::TMPro.KerningTable._003C_003Ec__DisplayClass3_0);
		object result = new object();
		_ = 0;
		return (global::System.Collections.IEnumerator)result;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600037E")]
	[global::Cpp2ILInjected.Address(RVA = "0x1013E5C", Offset = "0x1013E5C", Length = "0x94")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tSpecialFluid::OnPreComputeUpdate(this);\n\tPowerUp::UpdateArrows(this);\n\tv20 = UnityEngine.Component::get_transform(this);\n\tv23 = UnityEngine.Transform::get_position(v20);\n\tv41 = UnityEngine.Component::get_transform(this);\n\tv88 = this.id * 0x36A7C5AC;\n\tv72 = v88 + -5f;\n\t// 47 MakeStruct v58 @ AGG1013EE8_1_v1 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), v23 @ V0_v2 (UnityEngine.Vector3), v23.y (System.Single), v72 @ V2_v3 (System.Single)\n\tUnityEngine.Transform::set_position(v41, v58);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 40 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public override void OnPreComputeUpdate()
	{
		base.OnPreComputeUpdate();
		UpdateArrows();
		global::UnityEngine.Transform transform = base.transform;
		global::UnityEngine.Vector3 vector = transform.position;
		global::UnityEngine.Transform transform2 = base.transform;
		int num = id * 916964780;
		float z = (float)num + -5f;
		global::UnityEngine.Vector3 vector2 = default(global::UnityEngine.Vector3);
		vector2.x = vector.x;
		vector2.y = vector.y;
		vector2.z = z;
		transform2.position = vector2;
	}

	[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(PowerUp._003CRotateBlob_003Ed__13))]
	[global::Cpp2ILInjected.Token(Token = "0x600037F")]
	[global::Cpp2ILInjected.Address(RVA = "0x1014038", Offset = "0x1014038", Length = "0x78")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = TMPro.KerningTable+<>c__DisplayClass3_0;\n\tgoto L_0017;\n\tv23 = TMPro.KerningTable+<>c__DisplayClass3_0;\n\tv24 = v23 + 0x850;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv43 = 1;\n\t*([302AA7B]) = v43;\nL_0017:\n\tv45 = new *([v18 @ X21_v1 (Il2CppClass<TMPro.KerningTable+<>c__DisplayClass3_0>)+850])();\n\tSystem.Object::.ctor(v45);\n\t*([v45 @ X0_v3 (System.Object)+10]) = 0;\n\tv49 = v45 + 0x20;\n\t*([v45 @ X0_v3 (System.Object)+20]) = this;\n\tv51 = 0xF3F1B4(v49, this, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\treturn v45;\n// 28 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public global::System.Collections.IEnumerator RotateBlob()
	{
		//IL_000e: Expected I, but got O
		//IL_0037: Expected O, but got I
		nint num = (nint)typeof(global::TMPro.KerningTable._003C_003Ec__DisplayClass3_0);
		object obj = new object();
		_ = 0;
		object obj2 = (nint)obj + 32;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		return (global::System.Collections.IEnumerator)obj;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000380")]
	[global::Cpp2ILInjected.Address(RVA = "0x1013D18", Offset = "0x1013D18", Length = "0xBC")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv15 = UnityEngine.Component::get_gameObject(this.upArrow);\n\tv56 = this.mergeIndex - 1;\n\tv46 = v56 == 0;\n\tUnityEngine.GameObject::SetActive(v15, v46);\n\tv87 = UnityEngine.Component::get_gameObject(this.downArrow);\n\tv57 = this.mergeIndex - 1;\n\tv47 = v57 == 0;\n\tUnityEngine.GameObject::SetActive(v87, v47);\n\tv89 = UnityEngine.Component::get_gameObject(this.leftArrow);\n\tv58 = this.mergeIndex - 2;\n\tv53 = v58 < 0;\n\tv43 = this.mergeIndex ^ 2;\n\tv38 = this.mergeIndex ^ v58;\n\tv33 = v43 & v38;\n\tv28 = v33 < 0;\n\tv143 = v53 == v28;\n\tv18 = ~v143;\n\tUnityEngine.GameObject::SetActive(v89, v18);\n\tv91 = UnityEngine.Component::get_gameObject(this.rightArrow);\n\tv128 = this.mergeIndex - 2;\n\tv126 = v128 < 0;\n\tv122 = this.mergeIndex ^ 2;\n\tv120 = this.mergeIndex ^ v128;\n\tv118 = v122 & v120;\n\tv116 = v118 < 0;\n\tv145 = v126 == v116;\n\tv112 = ~v145;\n\tUnityEngine.GameObject::SetActive(v91, v112);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 68 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void InitArrows()
	{
		global::UnityEngine.GameObject gameObject = upArrow.gameObject;
		int num = mergeIndex - 1;
		bool active = num == 0;
		gameObject.SetActive(active);
		global::UnityEngine.GameObject gameObject2 = downArrow.gameObject;
		int num2 = mergeIndex - 1;
		bool active2 = num2 == 0;
		gameObject2.SetActive(active2);
		global::UnityEngine.GameObject gameObject3 = leftArrow.gameObject;
		int num3 = mergeIndex - 2;
		bool flag = num3 < 0;
		int num4 = mergeIndex ^ 2;
		int num5 = mergeIndex ^ num3;
		int num6 = num4 & num5;
		bool flag2 = num6 < 0;
		bool flag3 = flag == flag2;
		bool active3 = !flag3;
		gameObject3.SetActive(active3);
		global::UnityEngine.GameObject gameObject4 = rightArrow.gameObject;
		int num7 = mergeIndex - 2;
		bool flag4 = num7 < 0;
		int num8 = mergeIndex ^ 2;
		int num9 = mergeIndex ^ num7;
		int num10 = num8 & num9;
		bool flag5 = num10 < 0;
		bool flag6 = flag4 == flag5;
		bool active4 = !flag6;
		gameObject4.SetActive(active4);
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000381")]
	[global::Cpp2ILInjected.Address(RVA = "0x10140DC", Offset = "0x10140DC", Length = "0x4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn;\n")]
	public void Activate()
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000382")]
	[global::Cpp2ILInjected.Address(RVA = "0x1013EF0", Offset = "0x1013EF0", Length = "0x148")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0014;\n\tv21 = System.Xml.ValidateNames;\n\tv22 = v21 + 0x98;\n\tv23 = \"il2cpp_codegen_initialize_runtime_metadata\"(v22, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv41 = 1;\n\t*([2DD4426]) = v41;\nL_0014:\n\tv42 = System.Xml.ValidateNames;\n\tv44 = *([v42 @ X21_v2 (Il2CppClass<System.Xml.ValidateNames>)+98]);\n\tv45 = *([v44 @ X8_v3+B8]);\n\tv49 = *([v45 @ X8_v4+10]) * this.arrowSpacing;\n\tv50 = *([v45 @ X8_v4+14]) * this.arrowSpacing;\n\t// 31 MakeStruct v53 @ AGG1013F50_2_v1 (UnityEngine.Vector2), typeof(UnityEngine.Vector2), v49 @ V0_v2 (System.Single), v50 @ V1_v2 (System.Single)\n\tPowerUp::<UpdateArrows>g__UpdateArrowPostion|16_0(this, this.upArrow, v53);\n\tgoto L_002C;\n\tv59 = System.Xml.ValidateNames;\n\tv60 = v59 + 0x98;\n\tv61 = \"il2cpp_codegen_initialize_runtime_metadata\"(v60, v52, v25, v26, v27, v28, v29, v30, v49, v50, v48, v34, v35, v36, v37, v38);\n\tv64 = 1;\n\t*([2DD4423]) = v64;\nL_002C:\n\tv65 = *([v42 @ X21_v2 (Il2CppClass<System.Xml.ValidateNames>)+98]);\n\tv66 = *([v65 @ X8_v7+B8]);\n\tv70 = *([v66 @ X8_v8+18]) * this.arrowSpacing;\n\tv71 = *([v66 @ X8_v8+1C]) * this.arrowSpacing;\n\t// 53 MakeStruct v74 @ AGG1013F98_2_v1 (UnityEngine.Vector2), typeof(UnityEngine.Vector2), v70 @ V0_v4 (System.Single), v71 @ V1_v4 (System.Single)\n\tPowerUp::<UpdateArrows>g__UpdateArrowPostion|16_0(this, this.downArrow, v74);\n\tgoto L_0042;\n\tv80 = System.Xml.ValidateNames;\n\tv81 = v80 + 0x98;\n\tv82 = \"il2cpp_codegen_initialize_runtime_metadata\"(v81, v73, v25, v26, v27, v28, v29, v30, v70, v71, v69, v34, v35, v36, v37, v38);\n\tv85 = 1;\n\t*([2DD4433]) = v85;\nL_0042:\n\tv86 = *([v42 @ X21_v2 (Il2CppClass<System.Xml.ValidateNames>)+98]);\n\tv87 = *([v86 @ X8_v11+B8]);\n\tv91 = *([v87 @ X8_v12+20]) * this.arrowSpacing;\n\tv92 = *([v87 @ X8_v12+24]) * this.arrowSpacing;\n\t// 75 MakeStruct v95 @ AGG1013FE0_2_v1 (UnityEngine.Vector2), typeof(UnityEngine.Vector2), v91 @ V0_v6 (System.Single), v92 @ V1_v6 (System.Single)\n\tPowerUp::<UpdateArrows>g__UpdateArrowPostion|16_0(this, this.leftArrow, v95);\n\tgoto L_0058;\n\tv101 = System.Xml.ValidateNames;\n\tv102 = v101 + 0x98;\n\tv103 = \"il2cpp_codegen_initialize_runtime_metadata\"(v102, v94, v25, v26, v27, v28, v29, v30, v91, v92, v90, v34, v35, v36, v37, v38);\n\tv106 = 1;\n\t*([2DD4432]) = v106;\nL_0058:\n\tv107 = *([v42 @ X21_v2 (Il2CppClass<System.Xml.ValidateNames>)+98]);\n\tv108 = *([v107 @ X8_v15+B8]);\n\tv112 = *([v108 @ X8_v16+28]) * this.arrowSpacing;\n\tv113 = *([v108 @ X8_v16+2C]) * this.arrowSpacing;\n\t// 104 MakeStruct v122 @ AGG1014034_2_v1 (UnityEngine.Vector2), typeof(UnityEngine.Vector2), v112 @ V0_v8 (System.Single), v113 @ V1_v8 (System.Single)\n\tPowerUp::<UpdateArrows>g__UpdateArrowPostion|16_0(this, this.rightArrow, v122);\n\treturn;\n// 57 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void UpdateArrows()
	{
		//IL_0013: Expected I, but got O
		//IL_0023: Expected O, but got I
		//IL_0033: Expected O, but got I
		//IL_00a4: Expected O, but got I
		//IL_00b4: Expected O, but got I
		//IL_0125: Expected O, but got I
		//IL_0135: Expected O, but got I
		//IL_01a6: Expected O, but got I
		//IL_01b6: Expected O, but got I
		nint num = (nint)typeof(global::System.Xml.ValidateNames);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X21_v2 (Il2CppClass<System.Xml.ValidateNames>)+98]");
		object obj = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3+B8]");
		object obj2 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+10]");
		float x = 0f * arrowSpacing;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v4+14]");
		float y = 0f * arrowSpacing;
		global::UnityEngine.Vector2 localPos = default(global::UnityEngine.Vector2);
		localPos.x = x;
		localPos.y = y;
		UpdateArrowPostion(upArrow, localPos);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X21_v2 (Il2CppClass<System.Xml.ValidateNames>)+98]");
		object obj3 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v7+B8]");
		object obj4 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v8+18]");
		float x2 = 0f * arrowSpacing;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X8_v8+1C]");
		float y2 = 0f * arrowSpacing;
		global::UnityEngine.Vector2 localPos2 = default(global::UnityEngine.Vector2);
		localPos2.x = x2;
		localPos2.y = y2;
		UpdateArrowPostion(downArrow, localPos2);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X21_v2 (Il2CppClass<System.Xml.ValidateNames>)+98]");
		object obj5 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v11+B8]");
		object obj6 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v12+20]");
		float x3 = 0f * arrowSpacing;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v12+24]");
		float y3 = 0f * arrowSpacing;
		global::UnityEngine.Vector2 localPos3 = default(global::UnityEngine.Vector2);
		localPos3.x = x3;
		localPos3.y = y3;
		UpdateArrowPostion(leftArrow, localPos3);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X21_v2 (Il2CppClass<System.Xml.ValidateNames>)+98]");
		object obj7 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v15+B8]");
		object obj8 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v16+28]");
		float x4 = 0f * arrowSpacing;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v16+2C]");
		float y4 = 0f * arrowSpacing;
		global::UnityEngine.Vector2 localPos4 = default(global::UnityEngine.Vector2);
		localPos4.x = x4;
		localPos4.y = y4;
		UpdateArrowPostion(rightArrow, localPos4);
		[global::Cpp2ILInjected.Token(Token = "0x6000385")]
		[global::Cpp2ILInjected.Address(RVA = "0x10140E0", Offset = "0x10140E0", Length = "0x118")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv36 = UnityEngine.Component::get_transform(arrow);\n\tv68 = UnityEngine.Component::get_transform(this.mr);\n\tv57 = UnityEngine.Transform::get_position(v68);\n\tv70 = UnityEngine.Component::get_transform(this.mr);\n\tv58 = UnityEngine.Transform::get_localScale(v70);\n\tgoto L_0041;\n\tv142 = System.Xml.ValidateNames;\n\tv143 = v142 + 0xD0;\n\tv144 = \"il2cpp_codegen_initialize_runtime_metadata\"(v143, v65, methodInfo, v87, v88, v89, v90, v91, v58, v84, v55, v92, v93, v94, v95, v96);\n\tv145 = 1;\n\t*([2DD4413]) = v145;\nL_0041:\n\tv147 = v58.z * 0;\n\tv148 = System.Xml.ValidateNames;\n\tv150 = v57.z + v147;\n\tv151 = *([v148 @ X8_v4 (Il2CppClass<System.Xml.ValidateNames>)+D0]);\n\tv105 = *([v151 @ X8_v6+B8]);\n\tv119 = v150 + *([v105 @ X8_v7+50]);\n\tv153 = localPos.y * v58.y;\n\tv154 = v57.y + v153;\n\tv138 = v154 + *([v105 @ X8_v7+4C]);\n\tv156 = localPos * v58;\n\tv157 = v57 + v156;\n\tv121 = v157 + *([v105 @ X8_v7+48]);\n\t// 96 MakeStruct v98 @ AGG10141F0_1_v1 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), v121 @ V0_v11 (System.Single), v138 @ V1_v7 (System.Single), v119 @ V2_v4 (System.Single)\n\tUnityEngine.Transform::set_position(v36, v98);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 73 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		void UpdateArrowPostion(global::UnityEngine.Transform arrow, global::UnityEngine.Vector2 vector2)
		{
			//IL_0081: Expected I, but got O
			//IL_00a5: Expected O, but got I
			//IL_00b5: Expected O, but got I
			global::UnityEngine.Transform transform = arrow.transform;
			global::UnityEngine.Transform transform2 = mr.transform;
			global::UnityEngine.Vector3 vector = transform2.position;
			global::UnityEngine.Transform transform3 = mr.transform;
			global::UnityEngine.Vector3 localScale = transform3.localScale;
			float num2 = localScale.z * 0f;
			nint num3 = (nint)typeof(global::System.Xml.ValidateNames);
			float num4 = vector.z + num2;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v4 (Il2CppClass<System.Xml.ValidateNames>)+D0]");
			object obj9 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v6+B8]");
			object obj10 = 0;
			float num5 = num4;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v7+50]");
			float z = num5 + 0f;
			float num6 = vector2.y * localScale.y;
			float num7 = vector.y + num6;
			float num8 = num7;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v7+4C]");
			float y5 = num8 + 0f;
			global::UnityEngine.Vector2 vector3 = default(global::UnityEngine.Vector2);
			float num9 = vector3.x * localScale.x;
			float num10 = vector.x + num9;
			float num11 = num10;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v7+48]");
			float x5 = num11 + 0f;
			global::UnityEngine.Vector3 vector4 = default(global::UnityEngine.Vector3);
			vector4.x = x5;
			vector4.y = y5;
			vector4.z = z;
			transform.position = vector4;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000383")]
	[global::Cpp2ILInjected.Address(RVA = "0x10141F8", Offset = "0x10141F8", Length = "0x14")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tthis.arrowSpacing = -0.007812501848093234d;\n\tSpecialFluid::.ctor(this);\n\treturn;\n// 3 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public PowerUp()
	{
		arrowSpacing = 1f;
		arrowZOffset = -1f;
	}

	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x6000384")]
	[global::Cpp2ILInjected.Address(RVA = "0x101420C", Offset = "0x101420C", Length = "0x90")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_001A;\n\tv23 = \"Writing object reference to Id '{0}' for {1}.\";\n\tv24 = v23 + 0x8C0;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, methodInfo, v27, v28, v29, v30, v31, v32, rot, v33, v34, v35, v36, v37, v38, v39);\n\tv42 = 1;\n\t*([302AA7C]) = v42;\nL_001A:\n\tUnityEngine.Renderer::GetPropertyBlock(this.mr, this._propBlock);\n\tv62 = \"Writing object reference to Id '{0}' for {1}.\";\n\tUnityEngine.MaterialPropertyBlock::SetFloat(this._propBlock, *([v62 @ X8_v4 (System.String)+8C0]), rot);\n\tUnityEngine.Renderer::SetPropertyBlock(this.mr, this._propBlock);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 39 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void _003CRotateBlob_003Eg__SetRot_007C13_0(float rot)
	{
		//IL_003f: Expected O, but got I
		mr.GetPropertyBlock(_propBlock);
		string text = "Writing object reference to Id '{0}' for {1}.";
		global::UnityEngine.MaterialPropertyBlock propBlock = _propBlock;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v4 (System.String)+8C0]");
		propBlock.SetFloat((string)0, rot);
		mr.SetPropertyBlock(_propBlock);
	}
}
