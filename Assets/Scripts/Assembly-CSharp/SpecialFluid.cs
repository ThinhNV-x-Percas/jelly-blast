[global::Cpp2ILInjected.Token(Token = "0x2000060")]
public class SpecialFluid : FluidRendererBase
{
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x2000062")]
	private sealed class _003CHandleFlash_003Ed__15 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000199")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[global::Cpp2ILInjected.Token(Token = "0x400019A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[global::Cpp2ILInjected.Token(Token = "0x400019B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public SpecialFluid _003C_003E4__this;

		[global::Cpp2ILInjected.Token(Token = "0x400019C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private float _003CstartTime_003E5__2;

		[global::Cpp2ILInjected.Token(Token = "0x400019D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private float _003CflashDuration_003E5__3;

		[global::Cpp2ILInjected.Token(Token = "0x17000012")]
		object global::System.Collections.Generic.IEnumerator<object>.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000202")]
			[global::Cpp2ILInjected.Address(RVA = "0xFF4AD8", Offset = "0xFF4AD8", Length = "0x8")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn this.<>2__current;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
			get
			{
				return _003C_003E2__current;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000013")]
		object global::System.Collections.IEnumerator.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000204")]
			[global::Cpp2ILInjected.Address(RVA = "0xFF4B20", Offset = "0xFF4B20", Length = "0x8")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn this.<>2__current;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
			get
			{
				return _003C_003E2__current;
			}
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x60001FF")]
		[global::Cpp2ILInjected.Address(RVA = "0xFF3DC8", Offset = "0xFF3DC8", Length = "0x2C")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tSystem.Object::.ctor(this);\n\tthis.<>1__state = <>1__state;\n\treturn;\n// 14 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public _003CHandleFlash_003Ed__15(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x6000200")]
		[global::Cpp2ILInjected.Address(RVA = "0xFF4A00", Offset = "0xFF4A00", Length = "0x4")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn;\n")]
		void global::System.IDisposable.Dispose()
		{
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000201")]
		[global::Cpp2ILInjected.Address(RVA = "0xFF4A04", Offset = "0xFF4A04", Length = "0xD4")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = this.<>1__state == 1;\n\tif (v18) goto L_0042;\n\tv23 = this.<>1__state == 0;\n\tv24 = ~v23;\n\tif (v24) goto L_005C;\n\tthis.<>1__state = 0xFFFFFFFF;\n\tv30 = UnityEngine.Time::get_time();\n\tthis.<startTime>5__2 = v30;\n\tthis.<flashDuration>5__3 = 0.2f;\n\tv41 = UnityEngine.Time::get_time();\n\tv95 = this.<flashDuration>5__3;\n\tv98 = this.<startTime>5__2 + this.<flashDuration>5__3;\n\tv142 = v41 >= v98;\n\tif (v142) goto L_0055;\nL_002F:\n\tv101 = UnityEngine.Time::get_time();\n\tSpecialFluid::<HandleFlash>g__SetAlpha|15_0(this.<>4__this, v101);\n\tv175 = this + 0x18;\n\tthis.<>2__current = 0;\n\tv177 = 0xF3F1B4(v175, 0, v163, v164, v165, v166, v167, v168, v101, v98, v95, v169, v170, v171, v172, v173);\n\tthis.<>1__state = 1;\n\treturn 1;\nL_0042:\n\tthis.<>1__state = 0xFFFFFFFF;\n\tv41 = UnityEngine.Time::get_time();\n\tv95 = this.<flashDuration>5__3;\n\tv98 = this.<startTime>5__2 + this.<flashDuration>5__3;\n\tv76 = v41 < v98;\n\tif (v76) goto L_002F;\nL_0055:\n\tSpecialFluid::<HandleFlash>g__SetAlpha|15_0(this.<>4__this, v41);\nL_005C:\n\treturn 0;\n\treturnVal2 = new System.NullReferenceException();\n\treturn returnVal2;\n// 64 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		private bool MoveNext()
		{
			//IL_00e7: Expected O, but got I
			float time2;
			if (_003C_003E1__state != 1)
			{
				if (_003C_003E1__state != 0)
				{
					goto IL_0171;
				}
				_003C_003E1__state = -1;
				float time = global::UnityEngine.Time.time;
				_003CstartTime_003E5__2 = time;
				_003CflashDuration_003E5__3 = 0.2f;
				time2 = global::UnityEngine.Time.time;
				float num = _003CflashDuration_003E5__3;
				float num2 = _003CstartTime_003E5__2 + _003CflashDuration_003E5__3;
				if (time2 < num2)
				{
					goto IL_00be;
				}
			}
			else
			{
				_003C_003E1__state = -1;
				time2 = global::UnityEngine.Time.time;
				float num = _003CflashDuration_003E5__3;
				float num2 = _003CstartTime_003E5__2 + _003CflashDuration_003E5__3;
				if (time2 < num2)
				{
					goto IL_00be;
				}
			}
			_003C_003E4__this._003CHandleFlash_003Eg__SetAlpha_007C15_0(time2);
			goto IL_0171;
			IL_0171:
			return false;
			IL_00be:
			float time3 = global::UnityEngine.Time.time;
			_003C_003E4__this._003CHandleFlash_003Eg__SetAlpha_007C15_0(time3);
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
		[global::Cpp2ILInjected.Token(Token = "0x6000203")]
		[global::Cpp2ILInjected.Address(RVA = "0xFF4AE0", Offset = "0xFF4AE0", Length = "0x40")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv10 = Facebook.Unity.Windows.IWindowsFacebook + 0xF30;\n\tv11 = 0xF3F22C(v10, methodInfo, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26);\n\tv27 = new v11();\n\tSystem.NotSupportedException::.ctor(v27);\n\tv31 = Il2CppMethodInfo + 0xFB8;\n\tv32 = 0xF3F22C(v31, 0, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26);\n\tthrow v27;\n// 13 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		void global::System.Collections.IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0039: Expected O, but got I
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F22C");
			global::System.NotSupportedException ex = new global::System.NotSupportedException();
			object obj2 = (nint)0 + (nint)4024;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F22C");
			throw ex;
		}
	}

	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x2000063")]
	private sealed class _003CHandlePopIn_003Ed__13 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
	{
		[global::Cpp2ILInjected.Token(Token = "0x400019E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[global::Cpp2ILInjected.Token(Token = "0x400019F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[global::Cpp2ILInjected.Token(Token = "0x40001A0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public SpecialFluid _003C_003E4__this;

		[global::Cpp2ILInjected.Token(Token = "0x40001A1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private float _003CstartTime_003E5__2;

		[global::Cpp2ILInjected.Token(Token = "0x40001A2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private float _003CshowDuration_003E5__3;

		[global::Cpp2ILInjected.Token(Token = "0x17000014")]
		object global::System.Collections.Generic.IEnumerator<object>.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000208")]
			[global::Cpp2ILInjected.Address(RVA = "0xFF4C24", Offset = "0xFF4C24", Length = "0x8")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn this.<>2__current;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
			get
			{
				return _003C_003E2__current;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000015")]
		object global::System.Collections.IEnumerator.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600020A")]
			[global::Cpp2ILInjected.Address(RVA = "0xFF4C6C", Offset = "0xFF4C6C", Length = "0x8")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn this.<>2__current;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
			get
			{
				return _003C_003E2__current;
			}
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x6000205")]
		[global::Cpp2ILInjected.Address(RVA = "0xFF3D24", Offset = "0xFF3D24", Length = "0x2C")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tSystem.Object::.ctor(this);\n\tthis.<>1__state = <>1__state;\n\treturn;\n// 14 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public _003CHandlePopIn_003Ed__13(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x6000206")]
		[global::Cpp2ILInjected.Address(RVA = "0xFF4B28", Offset = "0xFF4B28", Length = "0x4")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn;\n")]
		void global::System.IDisposable.Dispose()
		{
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000207")]
		[global::Cpp2ILInjected.Address(RVA = "0xFF4B2C", Offset = "0xFF4B2C", Length = "0xF8")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = this.<>1__state == 1;\n\tif (v18) goto L_004B;\n\tv23 = this.<>1__state == 0;\n\tv24 = ~v23;\n\tif (v24) goto L_0066;\n\tthis.<>1__state = 0xFFFFFFFF;\n\tv30 = UnityEngine.Time::get_time();\n\tthis.<startTime>5__2 = v30;\n\tthis.<showDuration>5__3 = 0.75f;\n\tv84 = UnityEngine.Time::get_time();\n\tv143 = this.<startTime>5__2 + this.<showDuration>5__3;\n\tv141 = v84 >= v143;\n\tif (v141) goto L_005F;\nL_002E:\n\tv163 = UnityEngine.Time::get_time();\n\tv181 = v163 - this.<startTime>5__2;\n\tv182 = v181 / this.<showDuration>5__3;\n\tv100 = EasingFunction::EaseOutElastic(v182, 1.75f, 0.3f);\n\tSpecialFluid::<HandlePopIn>g__SetScale|13_0(this.<>4__this, v100);\n\tv185 = this + 0x18;\n\tthis.<>2__current = 0;\n\tv187 = 0xF3F1B4(v185, 0, v168, v169, v170, v171, v172, v173, v100, 1.75f, 0x3E99999A, v174, v175, v176, v177, v178);\n\tthis.<>1__state = 1;\n\treturn 1;\nL_004B:\n\tthis.<>1__state = 0xFFFFFFFF;\n\tv27 = UnityEngine.Time::get_time();\n\tv72 = this.<startTime>5__2 + this.<showDuration>5__3;\n\tv76 = v27 < v72;\n\tif (v76) goto L_002E;\nL_005F:\n\tSpecialFluid::<HandlePopIn>g__SetScale|13_0(this.<>4__this, 1f);\nL_0066:\n\treturn 0;\n\treturnVal2 = new System.NullReferenceException();\n\treturn returnVal2;\n// 73 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		private bool MoveNext()
		{
			//IL_0116: Expected O, but got I
			if (_003C_003E1__state != 1)
			{
				if (_003C_003E1__state != 0)
				{
					goto IL_0197;
				}
				_003C_003E1__state = -1;
				float time = global::UnityEngine.Time.time;
				_003CstartTime_003E5__2 = time;
				_003CshowDuration_003E5__3 = 0.75f;
				float time2 = global::UnityEngine.Time.time;
				float num = _003CstartTime_003E5__2 + _003CshowDuration_003E5__3;
				if (time2 < num)
				{
					goto IL_00b4;
				}
			}
			else
			{
				_003C_003E1__state = -1;
				float time3 = global::UnityEngine.Time.time;
				float num2 = _003CstartTime_003E5__2 + _003CshowDuration_003E5__3;
				if (time3 < num2)
				{
					goto IL_00b4;
				}
			}
			_003C_003E4__this._003CHandlePopIn_003Eg__SetScale_007C13_0(1f);
			goto IL_0197;
			IL_0197:
			return false;
			IL_00b4:
			float time4 = global::UnityEngine.Time.time;
			float num3 = time4 - _003CstartTime_003E5__2;
			float t = num3 / _003CshowDuration_003E5__3;
			float scale = EasingFunction.EaseOutElastic(t, 1.75f);
			_003C_003E4__this._003CHandlePopIn_003Eg__SetScale_007C13_0(scale);
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
		[global::Cpp2ILInjected.Token(Token = "0x6000209")]
		[global::Cpp2ILInjected.Address(RVA = "0xFF4C2C", Offset = "0xFF4C2C", Length = "0x40")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv10 = Facebook.Unity.Windows.IWindowsFacebook + 0xF30;\n\tv11 = 0xF3F22C(v10, methodInfo, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26);\n\tv27 = new v11();\n\tSystem.NotSupportedException::.ctor(v27);\n\tv31 = Il2CppMethodInfo + 0xFC0;\n\tv32 = 0xF3F22C(v31, 0, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26);\n\tthrow v27;\n// 13 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		void global::System.Collections.IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0039: Expected O, but got I
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F22C");
			global::System.NotSupportedException ex = new global::System.NotSupportedException();
			object obj2 = (nint)0 + (nint)4032;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F22C");
			throw ex;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x400018C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
	public int id;

	[global::Cpp2ILInjected.Token(Token = "0x400018D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public FluidSolver solver;

	[global::Cpp2ILInjected.Token(Token = "0x400018E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public int fluidType;

	[global::Cpp2ILInjected.Token(Token = "0x400018F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	protected internal global::UnityEngine.MaterialPropertyBlock _propBlock;

	[global::Cpp2ILInjected.Token(Token = "0x4000190")]
	protected const float depthStride = 5E-06f;

	[global::Cpp2ILInjected.Token(Token = "0x4000191")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public global::System.Collections.Generic.HashSet<int> particleIds;

	[global::Cpp2ILInjected.Token(Token = "0x4000192")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public float zPos;

	[global::Cpp2ILInjected.Token(Token = "0x4000193")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public int[] solverIds;

	[global::Cpp2ILInjected.Token(Token = "0x4000194")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public int[] computeIds;

	[global::Cpp2ILInjected.Token(Token = "0x4000195")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public float particleSize;

	[global::Cpp2ILInjected.Token(Token = "0x4000196")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xAC")]
	private float fixedDeltaTime;

	[global::Cpp2ILInjected.Token(Token = "0x60001F1")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF3A4C", Offset = "0xFF3A4C", Length = "0x110")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv24 = *([302A9C7]) & 1;\n\tv25 = v24 == 0;\n\tif (v25) goto L_0033;\n\tv38 = this.maxParticles <= needed;\n\tif (v38) goto L_0042;\nL_0028:\n\treturn;\nL_0033:\n\t*([302A9C7]) = 1;\n\tv62 = this.maxParticles > needed;\n\tif (v62) goto L_0028;\nL_0042:\n\t;\n\tv105 = needed + 1;\n\tv109 = UnityEngine.Mathf::NextPowerOfTwo(v105);\n\tv147 = this + 0x98;\n\tSystem.Array::Resize(v147, v109);\n\tv152 = this + 0xA0;\n\tSystem.Array::Resize(v152, v109);\n\tv158 = this + 0x38;\n\tSystem.Array::Resize(v158, v109);\n\tv161 = this + 0x30;\n\tSystem.Array::Resize(v161, v109);\n\tv119 = this + 0x40;\n\tSystem.Array::Resize(v119, v109);\n\tthis.maxParticles = v109;\n\treturn;\n// 83 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private unsafe void EnsureCapacity(int needed)
	{
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302A9C7]");
		if ((uint)((nuint)0u & (nuint)1u) != 0)
		{
			if (maxParticles > needed)
			{
				return;
			}
		}
		else
		{
			_ = 1;
			if (maxParticles > needed)
			{
				return;
			}
		}
		int value = needed + 1;
		int newSize = global::UnityEngine.Mathf.NextPowerOfTwo(value);
		global::System.Array.Resize(ref solverIds, newSize);
		global::System.Array.Resize(ref computeIds, newSize);
		global::System.Array.Resize(ref positions, newSize);
		global::System.Array.Resize(ref interpPositions, newSize);
		global::System.Array.Resize(ref scales, newSize);
		maxParticles = newSize;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001F2")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF253C", Offset = "0xFF253C", Length = "0x3B8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_003F;\n\tv39 = System.Collections.Generic.NullableComparer`1;\n\tv40 = v39 + 0xDB8;\n\tv41 = \"il2cpp_codegen_initialize_runtime_metadata\"(v40, _solver, _particleIds, _fluidType, _compute, methodInfo, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\tv67 = Il2CppMethodInfo;\n\tv68 = v67 + 0x968;\n\tv69 = \"il2cpp_codegen_initialize_runtime_metadata\"(v68, _solver, _particleIds, _fluidType, _compute, methodInfo, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\tv74 = Il2CppMethodInfo;\n\tv75 = v74 + 0x970;\n\tv76 = \"il2cpp_codegen_initialize_runtime_metadata\"(v75, _solver, _particleIds, _fluidType, _compute, methodInfo, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\tv81 = Il2CppMethodInfo;\n\tv82 = v81 + 0x978;\n\tv83 = \"il2cpp_codegen_initialize_runtime_metadata\"(v82, _solver, _particleIds, _fluidType, _compute, methodInfo, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\tv85 = Il2CppMethodInfo;\n\tv86 = v85 + 0x998;\n\tv87 = \"il2cpp_codegen_initialize_runtime_metadata\"(v86, _solver, _particleIds, _fluidType, _compute, methodInfo, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\tv149 = Il2CppMethodInfo;\n\tv150 = v149 + 0x9B0;\n\tv151 = \"il2cpp_codegen_initialize_runtime_metadata\"(v150, _solver, _particleIds, _fluidType, _compute, methodInfo, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\tv177 = CollectParticleData[];\n\tv178 = v177 + 0x2D0;\n\tv179 = \"il2cpp_codegen_initialize_runtime_metadata\"(v178, _solver, _particleIds, _fluidType, _compute, methodInfo, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\tv182 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv183 = v182 + 0x900;\n\tv184 = \"il2cpp_codegen_initialize_runtime_metadata\"(v183, _solver, _particleIds, _fluidType, _compute, methodInfo, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\tv196 = Il2CppMethodInfo;\n\tv197 = v196 + 0xC90;\n\tv198 = \"il2cpp_codegen_initialize_runtime_metadata\"(v197, _solver, _particleIds, _fluidType, _compute, methodInfo, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\tv220 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv221 = v220 + 0xA48;\n\tv222 = \"il2cpp_codegen_initialize_runtime_metadata\"(v221, _solver, _particleIds, _fluidType, _compute, methodInfo, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\tv231 = \"Writing object reference to Id '{0}' for {1}.\";\n\tv232 = v231 + 0x970;\n\tv233 = \"il2cpp_codegen_initialize_runtime_metadata\"(v232, _solver, _particleIds, _fluidType, _compute, methodInfo, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\tv240 = \"Writing object reference to Id '{0}' for {1}.\";\n\tv241 = v240 + 0x9E0;\n\tv54 = \"il2cpp_codegen_initialize_runtime_metadata\"(v241, _solver, _particleIds, _fluidType, _compute, methodInfo, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\tv56 = 1;\n\t*([302A9C8]) = v56;\nL_003F:\n\tv57 = Il2CppMethodInfo;\n\tv59 = 0;\n\tv63 = this + 0x70;\n\tthis.solver = _solver;\n\tv66 = 0xF3F1B4(v63, _solver, _particleIds, _fluidType, _compute, methodInfo, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\tgoto L_0051;\n\tv77 = \"il2cpp_codegen_runtime_class_init\"(v70, v65, _particleIds, _fluidType, _compute, methodInfo, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\nL_0051:\n\tv80 = Singleton`1::get_Instance /* +1 sharing this address */(*([v57 @ X26_v1 (Il2CppMethodInfo)+C90]));\n\tv88 = *([v80 @ X0_v7+38]);\n\tthis.fixedDeltaTime = *([v88 @ X8_v7+28]);\n\tthis.fluidType = _fluidType;\n\tv142 = this + 0x88;\n\tthis.particleIds = _particleIds;\n\tv155 = 0xF3F1B4(v142, _particleIds, _particleIds, _fluidType, _compute, methodInfo, v43, v44, *([v88 @ X8_v7+28]), v46, v47, v48, v49, v50, v51, v52);\n\tv181 = this + 0x20;\n\tthis.compute = _compute;\n\tv113 = 0xF3F1B4(v181, _compute, _particleIds, _fluidType, _compute, methodInfo, v43, v44, *([v88 @ X8_v7+28]), v46, v47, v48, v49, v50, v51, v52);\n\tv199 = CollectParticleData[];\n\tv201 = Facebook.Unity.Windows.IWindowsFacebook;\n\tthis.maxParticles = _particleIds._count;\n\tv204 = \"SzArrayNew\"(*([v199 @ X23_v6 (Il2CppClass<CollectParticleData[]>)+2D0]), _particleIds._count, _particleIds, _fluidType, _compute, methodInfo, v43, v44, *([v88 @ X8_v7+28]), v46, v47, v48, v49, v50, v51, v52);\n\tv225 = this + 0x98;\n\tthis.solverIds = v204;\n\tv226 = 0xF3F1B4(v225, v204, _particleIds, _fluidType, _compute, methodInfo, v43, v44, *([v88 @ X8_v7+28]), v46, v47, v48, v49, v50, v51, v52);\n\tv236 = \"SzArrayNew\"(*([v199 @ X23_v6 (Il2CppClass<CollectParticleData[]>)+2D0]), this.maxParticles, _particleIds, _fluidType, _compute, methodInfo, v43, v44, *([v88 @ X8_v7+28]), v46, v47, v48, v49, v50, v51, v52);\n\tv244 = this + 0xA0;\n\tthis.computeIds = v236;\n\tv245 = 0xF3F1B4(v244, v236, _particleIds, _fluidType, _compute, methodInfo, v43, v44, *([v88 @ X8_v7+28]), v46, v47, v48, v49, v50, v51, v52);\n\tFluidRendererBase::Init(this);\n\tv330 = new *([v201 @ X24_v6 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+900])();\n\tUnityEngine.MaterialPropertyBlock::.ctor(v330);\n\tv140 = this + 0x80;\n\tthis._propBlock = v330;\n\tv334 = 0xF3F1B4(v140, v330, _particleIds, _fluidType, _compute, methodInfo, v43, v44, *([v88 @ X8_v7+28]), v46, v47, v48, v49, v50, v51, v52);\n\tUnityEngine.Renderer::GetPropertyBlock(this.mr, this._propBlock);\n\tv335 = \"Writing object reference to Id '{0}' for {1}.\";\n\tUnityEngine.MaterialPropertyBlock::SetInt(this._propBlock, *([v335 @ X8_v8 (System.String)+9E0]), this.fluidType);\n\tv336 = \"Writing object reference to Id '{0}' for {1}.\";\n\tUnityEngine.MaterialPropertyBlock::SetFloat(this._propBlock, *([v336 @ X8_v10 (System.String)+970]), 1f);\n\tUnityEngine.Renderer::SetPropertyBlock(this.mr, this._propBlock);\n\tv132 = this.solver;\n\tv337 = System.Collections.Generic.NullableComparer`1;\n\tv134 = this.solver + 0x260;\n\tv339 = new *([v337 @ X24_v8 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+DB8])();\n\tv129 = this->klass;\n\tSystem.Action`2<System.Object, System.Boolean>::.ctor(v339, this, *([v129 @ X8_v13 (Il2CppClass<SpecialFluid>)+1C0]));\n\tv344 = System.Delegate::Combine(v132.OnStartRemoveParticles, v339);\n\tv345 = v344 == 0;\n\tif (v345) goto L_00F5;\n\tv172 = *([v337 @ X24_v8 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+DB8]);\n\tv162 = 0xF3F36C(v344, *([v337 @ X24_v8 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+DB8]), 0, 0, _compute, methodInfo, v43, v44, 1f, v46, v47, v48, v49, v50, v51, v52);\n\tv165 = v162 == 0;\n\tif (v165) goto L_00FF;\n\tv132.OnStartRemoveParticles = v162;\n\tv172 = *([v337 @ X24_v8 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+DB8]);\n\tv163 = 0xF3F36C(v344, *([v337 @ X24_v8 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+DB8]), 0, 0, _compute, methodInfo, v43, v44, 1f, v46, v47, v48, v49, v50, v51, v52);\n\tv166 = v163 == 0;\n\tif (v166) goto L_00FF;\n\tv362 = 0xF3F1B4(v134, v163, 0, 0, _compute, methodInfo, v43, v44, 1f, v46, v47, v48, v49, v50, v51, v52);\n\tv352 = this.particleIds;\nL_00CF:\n\t;\n\tv357 = Il2CppMethodInfo;\n\tv358 = Il2CppMethodInfo;\n\tv360 = System.Collections.Generic.HashSet`1<System.Int32>::GetEnumerator(v352);\nL_00DD:\n\tv370 = System.Collections.Generic.HashSet`1+Enumerator::MoveNext /* +1 sharing this address */(&v59 @ stack_-68_v1, *([v357 @ X21_v9 (Il2CppMethodInfo)+970]));\n\tv371 = v370 & 1;\n\tv278 = v371 == 0;\n\tif (v278) goto L_00E7;\n\tSpecialFluid::AddSolverParticle(this, 0);\n\tgoto L_00DD;\nL_00E7:\n\tSystem.Collections.Generic.HashSet`1+Enumerator::Dispose /* +1 sharing this address */(&v59 @ stack_-68_v1, *([v358 @ X20_v8 (Il2CppMethodInfo)+968]));\nL_00F3:\n\treturn;\nL_00F5:\n\tv132.OnStartRemoveParticles = 0;\n\tv347 = 0xF3F1B4(v134, 0, 0, 0, _compute, methodInfo, v43, v44, 1f, v46, v47, v48, v49, v50, v51, v52);\n\tv352 = this.particleIds;\n\tv348 = this.particleIds == 0;\n\tv120 = ~v348;\n\tif (v120) goto L_00CF;\n\tthrow System.NullReferenceException;\nL_00FF:\n\tv176 = new System.InvalidCastException();\n\tgoto L_010B;\nL_010B:\n\tv195 = v172 != 1;\n\tif (v195) goto L_011B;\n\tv206 = 0x274A080(v176, v172, v157, v156, _compute, methodInfo, v43, v44, v160, v46, v47, v48, v49, v50, v51, v52);\n\tv228 = 0x274A098(v206, v172, v157, v156, _compute, methodInfo, v43, v44, v160, v46, v47, v48, v49, v50, v51, v52);\n\tv210 = v142.m_value;\n\tSystem.Collections.Gene\n// ... truncated")]
	public unsafe virtual void Init(FluidSolver _solver, global::System.Collections.Generic.HashSet<int> _particleIds, int _fluidType, FluidCompute _compute)
	{
		solver = _solver;
		fixedDeltaTime = global::UnityEngine.Time.fixedDeltaTime;
		fluidType = _fluidType;
		particleIds = _particleIds;
		compute = _compute;
		maxParticles = _particleIds.Count;
		solverIds = new int[maxParticles];
		computeIds = new int[maxParticles];
		base.Init();
		_propBlock = new global::UnityEngine.MaterialPropertyBlock();
		mr.GetPropertyBlock(_propBlock);
		_propBlock.SetInt("_FluidType", fluidType);
		_propBlock.SetFloat("_Alpha", 1f);
		mr.SetPropertyBlock(_propBlock);
		solver.OnStartRemoveParticles += OnSolverRemoveParticlesStart;
		foreach (int id in particleIds)
		{
			AddSolverParticle(id);
		}
	}

	[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(SpecialFluid._003CHandlePopIn_003Ed__13))]
	[global::Cpp2ILInjected.Token(Token = "0x60001F3")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF3580", Offset = "0xFF3580", Length = "0x78")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = TMPro.KerningTable+<>c__DisplayClass3_0;\n\tgoto L_0017;\n\tv23 = TMPro.KerningTable+<>c__DisplayClass3_0;\n\tv24 = v23 + 0xFF0;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv43 = 1;\n\t*([302AA2D]) = v43;\nL_0017:\n\tv45 = new *([v18 @ X21_v1 (Il2CppClass<TMPro.KerningTable+<>c__DisplayClass3_0>)+FF0])();\n\tSystem.Object::.ctor(v45);\n\t*([v45 @ X0_v3 (System.Object)+10]) = 0;\n\tv49 = v45 + 0x20;\n\t*([v45 @ X0_v3 (System.Object)+20]) = this;\n\tv51 = 0xF3F1B4(v49, this, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\treturn v45;\n// 28 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public global::System.Collections.IEnumerator HandlePopIn()
	{
		return new _003CHandlePopIn_003Ed__13(0)
		{
			_003C_003E4__this = this
		};
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001F4")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF35F8", Offset = "0xFF35F8", Length = "0x4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn;\n")]
	public void Flash()
	{
	}

	[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(SpecialFluid._003CHandleFlash_003Ed__15))]
	[global::Cpp2ILInjected.Token(Token = "0x60001F5")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF3D50", Offset = "0xFF3D50", Length = "0x78")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = TMPro.KerningTable+<>c__DisplayClass3_0;\n\tgoto L_0017;\n\tv23 = TMPro.KerningTable+<>c__DisplayClass3_0;\n\tv24 = v23 + 0xFE8;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv43 = 1;\n\t*([302A9C9]) = v43;\nL_0017:\n\tv45 = new *([v18 @ X21_v1 (Il2CppClass<TMPro.KerningTable+<>c__DisplayClass3_0>)+FE8])();\n\tSystem.Object::.ctor(v45);\n\t*([v45 @ X0_v3 (System.Object)+10]) = 0;\n\tv49 = v45 + 0x20;\n\t*([v45 @ X0_v3 (System.Object)+20]) = this;\n\tv51 = 0xF3F1B4(v49, this, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\treturn v45;\n// 28 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private global::System.Collections.IEnumerator HandleFlash()
	{
		return new _003CHandleFlash_003Ed__15(0)
		{
			_003C_003E4__this = this
		};
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001F6")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF3DF4", Offset = "0xFF3DF4", Length = "0x18C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0023;\n\tv27 = Il2CppMethodInfo;\n\tv28 = v27 + 0x968;\n\tv29 = \"il2cpp_codegen_initialize_runtime_metadata\"(v28, positionsToAdd, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv53 = Il2CppMethodInfo;\n\tv54 = v53 + 0x970;\n\tv55 = \"il2cpp_codegen_initialize_runtime_metadata\"(v54, positionsToAdd, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv87 = Il2CppMethodInfo;\n\tv88 = v87 + 0x978;\n\tv89 = \"il2cpp_codegen_initialize_runtime_metadata\"(v88, positionsToAdd, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv90 = Il2CppMethodInfo;\n\tv91 = v90 + 0x980;\n\tv92 = \"il2cpp_codegen_initialize_runtime_metadata\"(v91, positionsToAdd, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv112 = Il2CppMethodInfo;\n\tv113 = v112 + 0x998;\n\tv45 = \"il2cpp_codegen_initialize_runtime_metadata\"(v113, positionsToAdd, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv47 = 1;\n\t*([302A9CA]) = v47;\nL_0023:\n\tv48 = 0;\n\tv52 = this.solver == 0;\n\tif (v52) goto L_005D;\n\tv59 = FluidSolver::AddParticles(this.solver, v118, this.fluidType, 0);\n\tv79 = v59 == 0;\n\tif (v79) goto L_005D;\n\tv95 = Il2CppMethodInfo;\n\tv97 = Il2CppMethodInfo;\n\tv83 = Il2CppMethodInfo + 0x968;\n\tv100 = System.Collections.Generic.HashSet`1<System.Int32>::GetEnumerator(v59);\nL_003F:\n\tv136 = System.Collections.Generic.HashSet`1+Enumerator::MoveNext /* +1 sharing this address */(&v48 @ stack_-58_v1, *([v95 @ X22_v4 (Il2CppMethodInfo)+970]));\n\tv141 = v136 & 1;\n\tv142 = v141 == 0;\n\tif (v142) goto L_0050;\n\tv149 = System.Collections.Generic.HashSet`1<System.Int32>::Add(this.particleIds, 0);\n\tSpecialFluid::AddSolverParticle(this, 0);\n\tgoto L_003F;\nL_0050:\n\tSystem.Collections.Generic.HashSet`1+Enumerator::Dispose /* +1 sharing this address */(&v48 @ stack_-58_v1, *([v97 @ X21_v5 (Il2CppMethodInfo)+968]));\nL_005A:\n\treturn;\n\tv76 = new System.NullReferenceException();\nL_005D:\n\tv86 = new System.NullReferenceException();\n\tgoto L_006B;\n\tgoto L_006B;\n\tgoto L_006B;\nL_006B:\n\tv111 = v118 != 1;\n\tif (v111) goto L_007B;\n\tv115 = 0x274A080(v86, v118, v73, v70, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv138 = 0x274A098(v115, v118, v73, v70, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv118 = *([v82 @ X21_v2 (System.Int32)]);\n\tSystem.Collections.Generic.HashSet`1+Enumerator::Dispose /* +1 sharing this address */(&v48 @ stack_-58_v1, *([v82 @ X21_v2 (System.Int32)]));\n\tv123 = *([v115 @ X0_v12]) == 0;\n\tif (v123) goto L_005A;\n\tv121 = new System.OutOfMemoryException();\nL_007B:\n\tv127 = 0xBF092C(&v65 @ stack_-68 (System.Int32), v118, v73, v70, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv140 = 0x27498DC(v124, v118, v73, v70, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv144 = 0xD6F8(v140, v118, v73, v70, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\treturn;\n// 73 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public virtual void AddParticles(global::Unity.Mathematics.float2[] positionsToAdd)
	{
		if (solver == null)
		{
			return;
		}
		global::System.Collections.Generic.HashSet<int> hashSet = solver.AddParticles(positionsToAdd, fluidType);
		if (hashSet == null)
		{
			return;
		}
		foreach (int id in hashSet)
		{
			particleIds.Add(id);
			AddSolverParticle(id);
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001F7")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF3B5C", Offset = "0xFF3B5C", Length = "0x1C8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv24 = TMPro.KerningTable+<>c__DisplayClass3_0;\n\tgoto L_0023;\n\tv29 = System.Collections.Generic.NullableComparer`1;\n\tv30 = v29 + 0xD10;\n\tv31 = \"il2cpp_codegen_initialize_runtime_metadata\"(v30, id, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tv52 = Il2CppMethodInfo;\n\tv53 = v52 + 0xC30;\n\tv54 = \"il2cpp_codegen_initialize_runtime_metadata\"(v53, id, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tv57 = Il2CppMethodInfo;\n\tv58 = v57 + 0xFB0;\n\tv59 = \"il2cpp_codegen_initialize_runtime_metadata\"(v58, id, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tv61 = TMPro.KerningTable+<>c__DisplayClass3_0;\n\tv62 = v61 + 0xFE0;\n\tv47 = \"il2cpp_codegen_initialize_runtime_metadata\"(v62, id, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tv49 = 1;\n\t*([302A9CB]) = v49;\nL_0023:\n\tv51 = new *([v24 @ X22_v1 (Il2CppClass<TMPro.KerningTable+<>c__DisplayClass3_0>)+FE0])();\n\tSystem.Object::.ctor(v51);\n\tv64 = v51 + 0x10;\n\t*([v51 @ X0_v3 (System.Object)+10]) = this;\n\tv66 = 0xF3F1B4(v64, this, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tSpecialFluid::EnsureCapacity(this, this.activeCount);\n\tv137 = this.solverIds;\n\tv118 = this.activeCount;\n\tv137[v118 @ X9_v3 (System.Int32)] = id;\n\tv216 = Il2CppMethodInfo;\n\tv217 = this.solver + 0x1F8;\n\tv218 = Unity.Collections.NativeHashMap`2::get_Item /* +1 sharing this address */(v217, id, *([v216 @ X9_v4 (Il2CppMethodInfo)+C30]));\n\t*([v51 @ X0_v3 (System.Object)+18]) = v218;\n\tv127 = IdGenerator::Next();\n\tv139 = this.computeIds;\n\tv120 = this.activeCount;\n\tv221 = System.Collections.Generic.NullableComparer`1;\n\tv222 = Il2CppMethodInfo;\n\tv139[v120 @ X9_v6 (System.Int32)] = v127;\n\tv142 = this.compute;\n\tv128 = new *([v221 @ X10_v5 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+D10])();\n\tSystem.Action`1<ParticleInitData>::.ctor(v128, v51, *([v222 @ X24_v3 (Il2CppMethodInfo)+FB0]));\n\tFluidCompute::InitParticle(this.compute, v127, v142.activeCount);\n\tv202 = v128 == 0;\n\tif (v202) goto L_0085;\n\tParticleInitData::.ctor(&v231 @ stack_-50_v3 (ParticleInitData), v142.activeCount, v127, 0);\n\tv128.invoke_impl(v238, v128.method_code, v231, 0, v128.method, 0, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\nL_0085:\n\tv242 = v142.activeCount + 1;\n\tv142.activeCount = v242;\n\tv206 = this.activeCount + 1;\n\tthis.activeCount = v206;\n\treturn;\n\tv143 = new System.NullReferenceException();\n\tthrow System.IndexOutOfRangeException;\n\treturn;\n// 100 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void AddSolverParticle(int id)
	{
		EnsureCapacity(activeCount);
		solverIds[activeCount] = id;
		int computeId = IdGenerator.Next();
		computeIds[activeCount] = computeId;
		compute.AddParticle(computeId);
		activeCount++;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001F8")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF42D0", Offset = "0xFF42D0", Length = "0x2F0")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_002B;\n\tv27 = Il2CppMethodInfo;\n\tv28 = v27 + 0xC88;\n\tv29 = \"il2cpp_codegen_initialize_runtime_metadata\"(v28, ids, explode, methodInfo, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv52 = Il2CppMethodInfo;\n\tv53 = v52 + 0x968;\n\tv54 = \"il2cpp_codegen_initialize_runtime_metadata\"(v53, ids, explode, methodInfo, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv190 = Il2CppMethodInfo;\n\tv191 = v190 + 0x970;\n\tv192 = \"il2cpp_codegen_initialize_runtime_metadata\"(v191, ids, explode, methodInfo, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv243 = Il2CppMethodInfo;\n\tv244 = v243 + 0x978;\n\tv245 = \"il2cpp_codegen_initialize_runtime_metadata\"(v244, ids, explode, methodInfo, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv274 = Il2CppMethodInfo;\n\tv275 = v274 + 0x990;\n\tv276 = \"il2cpp_codegen_initialize_runtime_metadata\"(v275, ids, explode, methodInfo, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv307 = Il2CppMethodInfo;\n\tv308 = v307 + 0x998;\n\tv45 = \"il2cpp_codegen_initialize_runtime_metadata\"(v308, ids, explode, methodInfo, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv47 = 1;\n\t*([302A9CC]) = v47;\nL_002B:\n\t;\n\tv57 = Il2CppMethodInfo;\n\tv59 = Il2CppMethodInfo;\n\tv63 = Il2CppMethodInfo;\n\tv64 = Il2CppMethodInfo + 0x968;\n\tv69 = System.Collections.Generic.HashSet`1<System.Int32>::GetEnumerator(ids);\nL_0042:\n\tv273 = System.Collections.Generic.HashSet`1+Enumerator::MoveNext /* +1 sharing this address */(&v162 @ stack_-78_v5 (System.Int32), *([v57 @ X23_v13 (Il2CppMethodInfo)+970]));\n\tv277 = v273 & 1;\n\tv278 = v277 == 0;\n\tif (v278) goto L_0069;\n\tv236 = System.Array::IndexOf(this.solverIds, v196);\n\tv267 = v236 + 1;\n\tv258 = v267 == 0;\n\tif (v258) goto L_0042;\n\tv214 = this.computeIds;\n\tv238 = this.computeIds == 0;\n\tif (v238) goto L_0134;\n\tv415 = v236 < v214.Length;\n\tv218 = ~v415;\n\tif (v218) goto L_0132;\n\tFluidCompute::RemoveParticle(this.compute, v214[v236 @ X0_v33 (System.Int32)]);\n\tgoto L_0042;\nL_0069:\n\tSystem.Collections.Generic.HashSet`1+Enumerator::Dispose /* +1 sharing this address */(&v162 @ stack_-78_v5 (System.Int32), *([v63 @ X22_v13 (Il2CppMethodInfo)+968]));\nL_0075:\n\tv359 = this.activeCount < 1;\n\tif (v359) goto L_FFFFFFFF;\n\tgoto L_008E;\nL_007F:\n\tv119[v429 @ X22_v11 (System.Int32)] = v119[v173 @ X23_v11 (System.Int32)];\nL_0080:\n\tv429 = v429 + 1;\nL_0081:\n\tv173 = v173 + 1;\n\tv417 = v173 >= this.activeCount;\n\tif (v417) goto L_0126;\nL_008E:\n\tv184 = this.solverIds;\n\tv176 = System.Collections.Generic.HashSet`1<System.Int32>::Contains(ids, v184[v173 @ X23_v11 (System.Int32)]);\n\tv553 = v176 == 0;\n\tv554 = ~v553;\n\tif (v554) goto L_0081;\n\tv137 = v173 == v429;\n\tif (v137) goto L_0080;\n\tv116 = this.solverIds;\n\tv116[v429 @ X22_v11 (System.Int32)] = v116[v173 @ X23_v11 (System.Int32)];\n\tv117 = this.computeIds;\n\tv117[v429 @ X22_v11 (System.Int32)] = v117[v173 @ X23_v11 (System.Int32)];\n\tv599 = v173 << 3;\n\tv74 = this.positions + v599;\n\tv84 = v429 << 3;\n\tv600 = this.positions + v84;\n\t*([v600 @ X9_v17+20]) = *([v74 @ X10_v17+20]);\n\tv119 = this.scales;\n\tv602 = v429 < v119.Length;\n\tv534 = ~v602;\n\tv508 = ~v534;\n\tif (v508) goto L_007F;\n\tthrow System.IndexOutOfRangeException;\nL_0126:\n\tthis.activeCount = v450;\n\treturn;\n\tv189 = new System.NullReferenceException();\nL_0132:\n\tv242 = new System.IndexOutOfRangeException();\n\tgoto L_0137;\nL_0134:\n\tv303 = new System.NullReferenceException();\n\tgoto L_0137;\n\tv302 = new System.NullReferenceException();\nL_0137:\n\t// 311 Interrupt\n\tgoto L_0146;\n\tgoto L_0146;\n\tgoto L_0146;\n\tgoto L_0146;\n\tgoto L_0146;\nL_0146:\n\tv321 = v362 != 1;\n\tif (v321) goto L_0156;\n\tv360 = 0x274A080(v364, v362, *([v59 @ X24_v6 (Il2CppMethodInfo)+C88]), methodInfo, v32, v33, v34, v35, v162, v37, v38, v39, v40, v41, v42, v43);\n\tv412 = 0x274A098(v360, v362, *([v59 @ X24_v6 (Il2CppMethodInfo)+C88]), methodInfo, v32, v33, v34, v35, v162, v37, v38, v39, v40, v41, v42, v43);\n\tv362 = *([v64 @ X22_v14]);\n\tSystem.Collections.Generic.HashSet`1+Enumerator::Dispose /* +1 sharing this address */(&v162 @ stack_-78_v5 (System.Int32), *([v64 @ X22_v14]));\n\tv345 = *([v360 @ X0_v9]) == 0;\n\tif (v345) goto L_0075;\n\tv364 = new System.OutOfMemoryException();\nL_0156:\n\tv370 = 0xBF092C(&v162 @ stack_-78_v5 (System.Int32), v362, *([v59 @ X24_v6 (Il2CppMethodInfo)+C88]), methodInfo, v32, v33, v34, v35, v162, v37, v38, v39, v40, v41, v42, v43);\n\tv414 = 0x27498DC(v364, v362, *([v59 @ X24_v6 (Il2CppMethodInfo)+C88]), methodInfo, v32, v33, v34, v35, v162, v37, v38, v39, v40, v41, v42, v43);\n\tv463 = 0xD6F8(v414, v362, *([v59 @ X24_v6 (Il2CppMethodInfo)+C88]), methodInfo, v32, v33, v34, v35, v162, v37, v38, v39, v40, v41, v42, v43);\n\treturn;\n// 246 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public virtual void OnSolverRemoveParticlesStart(global::System.Collections.Generic.HashSet<int> ids, bool explode)
	{
		foreach (int id in ids)
		{
			int index = global::System.Array.IndexOf(solverIds, id);
			if (index == -1)
			{
				continue;
			}
			compute.RemoveParticle(computeIds[index]);
		}
		int writeIndex = 0;
		for (int i = 0; i < activeCount; i++)
		{
			if (ids.Contains(solverIds[i]))
			{
				continue;
			}
			if (i != writeIndex)
			{
				solverIds[writeIndex] = solverIds[i];
				computeIds[writeIndex] = computeIds[i];
				positions[writeIndex] = positions[i];
				scales[writeIndex] = scales[i];
			}
			writeIndex++;
		}
		activeCount = writeIndex;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001F9")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF2054", Offset = "0xFF2054", Length = "0x430")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_002B;\n\tv45 = Il2CppMethodInfo;\n\tv46 = v45 + 0x268;\n\tv47 = \"il2cpp_codegen_initialize_runtime_metadata\"(v46, methodInfo, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62);\n\tv70 = Il2CppMethodInfo;\n\tv71 = v70 + 0xC28;\n\tv72 = \"il2cpp_codegen_initialize_runtime_metadata\"(v71, methodInfo, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62);\n\tv75 = \"Writing object reference to Id '{0}' for {1}.\";\n\tv76 = v75 + 0x8B0;\n\tv77 = \"il2cpp_codegen_initialize_runtime_metadata\"(v76, methodInfo, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62);\n\tv462 = \"Writing object reference to Id '{0}' for {1}.\";\n\tv463 = v462 + 0x8B8;\n\tv64 = \"il2cpp_codegen_initialize_runtime_metadata\"(v463, methodInfo, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62);\n\tv66 = 1;\n\t*([302A9CD]) = v66;\nL_002B:\n\tv69 = UnityEngine.Time::get_time();\n\tv73 = this.solver;\n\tv89 = this.activeCount < 1;\n\tif (v89) goto L_018A;\n\tv466 = Il2CppMethodInfo;\n\tv469 = v69 - v73.<lastStepWallTime>k__BackingField;\n\tv471 = v469 / this.fixedDeltaTime;\n\tv475 = v471 - 1f;\n\tv476 = v475 < 0;\n\tv477 = v475 == 0;\n\tv478 = v471 ^ 1f;\n\tv479 = v471 ^ v475;\n\tv480 = v478 & v479;\n\tv481 = v480 < 0;\n\tv482 = v476 == v481;\n\tv234 = ~v477;\n\tv483 = v482 & v234;\n\tv484 = ~v483;\n\tif (v484) goto L_0063;\n\tgoto L_0063;\nL_0063:\n\tv230 = v471 >= 0;\n\tif (v230) goto L_FFFFFFFF;\n\tgoto L_FFFFFFFF;\n\tgoto L_007F;\nL_006B:\n\tv678 = v146 << 4;\n\tv690 = v136 + v678;\n\t*([v690 @ X8_v35+20]) = v244;\n\tv136[v146 @ stack_-98_v7 (System.Int32)].y = v244.y;\n\tv136[v146 @ stack_-98_v7 (System.Int32)].z = v244.z;\n\tv136[v146 @ stack_-98_v7 (System.Int32)].w = v244.w;\nL_0071:\n\tv269 = v269 + 1;\n\tv459 = v459 + 8;\n\tv522 = v269 >= this.activeCount;\n\tif (v522) goto L_018A;\nL_007F:\n\tv445 = this.solverIds;\n\tv673 = this.solver + 0x1F8;\n\tv404 = Unity.Collections.NativeHashMap`2::TryGetValue /* +1 sharing this address */(v673, v445[v269 @ X21_v5 (System.Int32)], &v189 @ stack_-94_v5, *([v466 @ X22_v4 (Il2CppMethodInfo)+C28]));\n\tv674 = v404 == 0;\n\tif (v674) goto L_0071;\n\tv446 = this.solver;\n\tv219 = v189 << 3;\n\tv447 = v446.positions + v219;\n\t// 164 MakeStruct v178 @ AGGFF21A8_0_v6 (Unity.Mathematics.float2), typeof(Unity.Mathematics.float2), [v447 @ X8_v18], [v447 @ X8_v18+4]\n\tv238 = Unity.Mathematics.float2::op_Implicit(v178);\n\tv698 = this.positions + v459;\n\t*([v698 @ X8_v20+20]) = v238;\n\t*([v698 @ X8_v20+24]) = v238.y;\n\tv448 = this.solver;\n\tv220 = v189 << 3;\n\tv700 = v448.positionsPrev + v220;\n\t// 194 MakeStruct v173 @ AGGFF21E4_0_v6 (Unity.Mathematics.float2), typeof(Unity.Mathematics.float2), [v700 @ X8_v23], [v700 @ X8_v23+4]\n\tv239 = Unity.Mathematics.float2::op_Implicit(v173);\n\tv706 = v269 << 3;\n\tv707 = this.positions + v706;\n\tv710 = *([v707 @ X8_v25+20]) - v239;\n\tv254 = v710 * v711;\n\tv240 = v239 + v254;\n\tv221 = v269 << 3;\n\tv450 = this.interpPositions + v221;\n\t*([v450 @ X8_v26+20]) = v240;\n\tv394 = this.solver;\n\tv451 = this.scales;\n\tv395 = v394.scales;\n\tv241 = this.particleSize * *([v395 @ X9_v14 (Unity.Collections.NativeArray`1<System.Single>)+v189 @ stack_-94_v5*4]);\n\tv451[v269 @ X21_v5 (System.Int32)] = v241;\n\tv452 = this.computeIds;\n\tv396 = this.compute;\n\tv408 = System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>::TryGetValue(v396.idToIndex, v452[v269 @ X21_v5 (System.Int32)], &v146 @ stack_-98_v7 (System.Int32));\n\tv688 = ~v408;\n\tif (v688) goto L_0071;\n\tv453 = this.compute;\n\tv718 = v269 << 3;\n\tv719 = this.interpPositions + v718;\n\tv224 = v146 << 3;\n\tv720 = v453.positions + v224;\n\t*([v720 @ X9_v19+20]) = *([v719 @ X9_v18+20]);\n\tv398 = this.scales;\n\tv153 = v453.scales;\n\tv153[v146 @ stack_-98_v7 (System.Int32)] = v398[v269 @ X21_v5 (System.Int32)];\n\tv399 = this.solver;\n\tv136 = v453.emissionColors;\n\tv226 = v189 << 4;\n\tv454 = v399.emissionColors + v226;\n\t// 373 MakeStruct v126 @ AGGFF2344_0_v6 (Unity.Mathematics.float4), typeof(Unity.Mathematics.float4), [v454 @ X8_v33], [v454 @ X8_v33+4], [v454 @ X8_v33+8], [v454 @ X8_v33+C]\n\tv244 = Unity.Mathematics.float4::op_Implicit(v126);\n\tv731 = v146 < v136.Length;\n\tv665 = ~v731;\n\tv657 = ~v665;\n\tif (v657) goto L_006B;\n\tthrow System.IndexOutOfRangeException;\nL_018A:\n\tFluidRendererBase::OnPreComputeUpdate(this);\n\tv410 = UnityEngine.Camera::get_main();\n\t// 403 MakeStruct v122 @ AGGFF237C_1_v2 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), this.position (UnityEngine.Vector2), this.position.y (System.Single), 0\n\tv246 = UnityEngine.Camera::WorldToViewportPoint(v410, v122);\n\tv411 = UnityEngine.Camera::get_main();\n\t// 418 MakeStruct v113 @ AGGFF23A4_1_v2 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), this.min (UnityEngine.Vector2), this.min.y (System.Single), 0\n\tv247 = UnityEngine.Camera::WorldToViewportPoint(v411, v113);\n\tv412 = UnityEngine.Camera::get_main();\n\t// 432 MakeStruct v106 @ AGGFF23C8_1_v2 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), this.max (UnityEngine.Vector2), this.max.y (System.Single), 0\n\tv248 = UnityEngine.Camera::WorldToViewportPoint(v412, v106);\n\tUnityEngine.Renderer::GetPropertyBlock(this.mr, this._propBlock);\n\tv697 = \"Writing object reference to Id '{0}' for {1}.\";\n\t// 455 MakeStruct v99 @ AGGFF2410_2_v2 (UnityEngine.Vector4), typeof(UnityEngine.Vector4), v246 @ V0_v5 (UnityEngine.Vector3), v246.y (System.Single), v246.z (System.Single), 0\n\tUnityEngine.MaterialPropertyBlock::SetVector(this._propBlock, *([v697 @ X8_v6 (System.String)+8B8]), v99);\n\tv703 = \"Writing object reference to Id '{0}' for {1}.\";\n\t// 462 NotImplemented \"Instruction FABD not yet implemented.\"\n\t// 463 NotImplemented \"Instruction FABD not yet implemented.\"\n\t// 468 MakeStruct v96 @ AGGFF243C_2_v2 (UnityEngine.Vector4), typeof(UnityEngine.Vector4), v246 @ V0_v5 (UnityEngine.Vector3), v246.y (System.Single), 0, 0\n\tUnityEngine.MaterialPropertyBlock::SetVector(this._propBlock, *([v703 @ X8_v8 (System.String)+8B0]), v96);\n\tUnityEngine.Renderer::SetPropertyBlock(this.mr, this._propBlock);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 370 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public override void OnPreComputeUpdate()
	{
		float time = global::UnityEngine.Time.time;
		FluidSolver fluidSolver = solver;
		if (activeCount >= 1)
		{
			float alpha = global::UnityEngine.Mathf.Clamp01((time - fluidSolver.lastStepWallTime) / fixedDeltaTime);
			for (int i = 0; i < activeCount; i++)
			{
				if (fluidSolver.idToIndex.TryGetValue(solverIds[i], out var slot))
				{
					global::UnityEngine.Vector2 currentPos = fluidSolver.positions[slot];
					global::UnityEngine.Vector2 prevPos = fluidSolver.positionsPrev[slot];
					positions[i] = currentPos;
					interpPositions[i] = global::UnityEngine.Vector2.Lerp(prevPos, currentPos, alpha);
					scales[i] = particleSize * fluidSolver.scales[slot];
					if (compute.idToIndex.TryGetValue(computeIds[i], out var gpuIndex))
					{
						compute.positions[gpuIndex] = interpPositions[i];
						compute.scales[gpuIndex] = scales[i];
						global::Unity.Mathematics.float4 emission = fluidSolver.emissionColors[slot];
						compute.emissionColors[gpuIndex] = new global::UnityEngine.Vector4(emission.x, emission.y, emission.z, emission.w);
					}
				}
			}
		}
		base.OnPreComputeUpdate();
		global::UnityEngine.Camera main = global::UnityEngine.Camera.main;
		global::UnityEngine.Vector3 viewportPos = main.WorldToViewportPoint(new global::UnityEngine.Vector3(position.x, position.y, 0f));
		global::UnityEngine.Vector3 viewportMin = main.WorldToViewportPoint(new global::UnityEngine.Vector3(min.x, min.y, 0f));
		global::UnityEngine.Vector3 viewportMax = main.WorldToViewportPoint(new global::UnityEngine.Vector3(max.x, max.y, 0f));
		mr.GetPropertyBlock(_propBlock);
		_propBlock.SetVector("_ViewportPos", new global::UnityEngine.Vector4(viewportPos.x, viewportPos.y, viewportPos.z, 0f));
		_propBlock.SetVector("_ViewportSize", new global::UnityEngine.Vector4(global::UnityEngine.Mathf.Abs(viewportMax.x - viewportMin.x), global::UnityEngine.Mathf.Abs(viewportMax.y - viewportMin.y), 0f, 0f));
		mr.SetPropertyBlock(_propBlock);
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001FA")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF24AC", Offset = "0xFF24AC", Length = "0x28")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tthis.zPos = -1f;\n\tthis.particleSize = 0.8f;\n\tthis.particleBoundsRadius = 0.4f;\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 6 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public SpecialFluid()
	{
		zPos = -1f;
		particleSize = 0.8f;
		particleBoundsRadius = 0.4f;
	}

	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x60001FB")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF45C0", Offset = "0xFF45C0", Length = "0x19C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0025;\n\tv31 = Il2CppMethodInfo;\n\tv32 = v31 + 0x968;\n\tv33 = \"il2cpp_codegen_initialize_runtime_metadata\"(v32, methodInfo, v35, v36, v37, v38, v39, v40, scale, v41, v42, v43, v44, v45, v46, v47);\n\tv58 = Il2CppMethodInfo;\n\tv59 = v58 + 0x970;\n\tv60 = \"il2cpp_codegen_initialize_runtime_metadata\"(v59, methodInfo, v35, v36, v37, v38, v39, v40, scale, v41, v42, v43, v44, v45, v46, v47);\n\tv101 = Il2CppMethodInfo;\n\tv102 = v101 + 0x978;\n\tv103 = \"il2cpp_codegen_initialize_runtime_metadata\"(v102, methodInfo, v35, v36, v37, v38, v39, v40, scale, v41, v42, v43, v44, v45, v46, v47);\n\tv104 = Il2CppMethodInfo;\n\tv105 = v104 + 0x998;\n\tv106 = \"il2cpp_codegen_initialize_runtime_metadata\"(v105, methodInfo, v35, v36, v37, v38, v39, v40, scale, v41, v42, v43, v44, v45, v46, v47);\n\tv138 = Il2CppMethodInfo;\n\tv139 = v138 + 0xC28;\n\tv49 = \"il2cpp_codegen_initialize_runtime_metadata\"(v139, methodInfo, v35, v36, v37, v38, v39, v40, scale, v41, v42, v43, v44, v45, v46, v47);\n\tv51 = 1;\n\t*([302A9CE]) = v51;\nL_0025:\n\tv52 = 0;\n\tv57 = this.particleIds == 0;\n\tif (v57) goto L_0065;\n\tv63 = Il2CppMethodInfo;\n\tv65 = Il2CppMethodInfo;\n\tv67 = Il2CppMethodInfo;\n\tv99 = Il2CppMethodInfo + 0x968;\n\tv72 = System.Collections.Generic.HashSet`1<System.Int32>::GetEnumerator(this.particleIds);\nL_003C:\n\tv126 = System.Collections.Generic.HashSet`1+Enumerator::MoveNext /* +1 sharing this address */(&v52 @ stack_-68_v1, *([v63 @ X21_v4 (Il2CppMethodInfo)+970]));\n\tv140 = v126 & 1;\n\tv141 = v140 == 0;\n\tif (v141) goto L_0054;\n\tv156 = this.solver == 0;\n\tif (v156) goto L_0061;\n\tv163 = this.solver + 0x1F8;\n\tv117 = Unity.Collections.NativeHashMap`2::TryGetValue /* +1 sharing this address */(v163, 0, &v109 @ stack_-6C_v6, *([v65 @ X22_v4 (Il2CppMethodInfo)+C28]));\n\tv210 = v117 & 1;\n\tv119 = v210 == 0;\n\tif (v119) goto L_003C;\n\tv240 = this.solver;\n\tv123 = v240.scales;\n\t*([v123 @ X8_v12 (Unity.Collections.NativeArray`1<System.Single>)+v109 @ stack_-6C_v6*4]) = scale;\n\tgoto L_003C;\nL_0054:\n\tSystem.Collections.Generic.HashSet`1+Enumerator::Dispose /* +1 sharing this address */(&v52 @ stack_-68_v1, *([v67 @ X20_v5 (Il2CppMethodInfo)+968]));\nL_0060:\n\treturn;\nL_0061:\n\tv164 = new System.NullReferenceException();\n\tgoto L_0064;\n\tv241 = new System.NullReferenceException();\nL_0064:\n\t// 100 Interrupt\nL_0065:\n\tv100 = new System.NullReferenceException();\n\tgoto L_0073;\n\tgoto L_0073;\n\tgoto L_0073;\nL_0073:\n\tv137 = v146 != 1;\n\tif (v137) goto L_0083;\n\tv143 = 0x274A080(v100, v146, v110, v112, v37, v38, v39, v40, scale, v41, v42, v43, v44, v45, v46, v47);\n\tv160 = 0x274A098(v143, v146, v110, v112, v37, v38, v39, v40, scale, v41, v42, v43, v44, v45, v46, v47);\n\tv146 = *([v99 @ X20_v2 (System.Int32)]);\n\tSystem.Collections.Generic.HashSet`1+Enumerator::Dispose /* +1 sharing this address */(&v52 @ stack_-68_v1, *([v99 @ X20_v2 (System.Int32)]));\n\tv151 = *([v143 @ X0_v12]) == 0;\n\tif (v151) goto L_0060;\n\tv149 = new System.OutOfMemoryException();\nL_0083:\n\tv155 = 0xBF092C(&v87 @ stack_-80 (System.Int32), v146, v110, v112, v37, v38, v39, v40, scale, v41, v42, v43, v44, v45, v46, v47);\n\tv162 = 0x27498DC(v152, v146, v110, v112, v37, v38, v39, v40, scale, v41, v42, v43, v44, v45, v46, v47);\n\tv209 = 0xD6F8(v162, v146, v110, v112, v37, v38, v39, v40, scale, v41, v42, v43, v44, v45, v46, v47);\n\treturn;\n// 72 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void _003CHandlePopIn_003Eg__SetScale_007C13_0(float scale)
	{
		if (particleIds == null || solver == null)
		{
			return;
		}
		foreach (int id in particleIds)
		{
			if (solver.idToIndex.TryGetValue(id, out var index))
			{
				solver.scales[index] = scale;
			}
		}
	}

	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x60001FC")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF475C", Offset = "0xFF475C", Length = "0x1A0")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0022;\n\tv25 = Il2CppMethodInfo;\n\tv26 = v25 + 0x968;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, methodInfo, v29, v30, v31, v32, v33, v34, val, v36, v37, v38, v39, v40, v41, v42);\n\tv53 = Il2CppMethodInfo;\n\tv54 = v53 + 0x970;\n\tv55 = \"il2cpp_codegen_initialize_runtime_metadata\"(v54, methodInfo, v29, v30, v31, v32, v33, v34, val, v36, v37, v38, v39, v40, v41, v42);\n\tv101 = Il2CppMethodInfo;\n\tv102 = v101 + 0x978;\n\tv103 = \"il2cpp_codegen_initialize_runtime_metadata\"(v102, methodInfo, v29, v30, v31, v32, v33, v34, val, v36, v37, v38, v39, v40, v41, v42);\n\tv106 = Il2CppMethodInfo;\n\tv107 = v106 + 0x998;\n\tv108 = \"il2cpp_codegen_initialize_runtime_metadata\"(v107, methodInfo, v29, v30, v31, v32, v33, v34, val, v36, v37, v38, v39, v40, v41, v42);\n\tv141 = Il2CppMethodInfo;\n\tv142 = v141 + 0xC28;\n\tv44 = \"il2cpp_codegen_initialize_runtime_metadata\"(v142, methodInfo, v29, v30, v31, v32, v33, v34, val, v36, v37, v38, v39, v40, v41, v42);\n\tv46 = 1;\n\t*([302A9CF]) = v46;\nL_0022:\n\tv47 = 0;\n\tv52 = this.particleIds == 0;\n\tif (v52) goto L_0064;\n\tv58 = Il2CppMethodInfo;\n\tv60 = Il2CppMethodInfo;\n\tv62 = Il2CppMethodInfo;\n\tv99 = Il2CppMethodInfo + 0x968;\n\tv67 = System.Collections.Generic.HashSet`1<System.Int32>::GetEnumerator(this.particleIds);\nL_003C:\n\tv129 = System.Collections.Generic.HashSet`1+Enumerator::MoveNext /* +1 sharing this address */(&v47 @ stack_-58_v1, *([v58 @ X21_v4 (Il2CppMethodInfo)+970]));\n\tv143 = v129 & 1;\n\tv144 = v143 == 0;\n\tif (v144) goto L_0055;\n\tv159 = this.solver == 0;\n\tif (v159) goto L_0060;\n\tv166 = this.solver + 0x1F8;\n\tv120 = Unity.Collections.NativeHashMap`2::TryGetValue /* +1 sharing this address */(v166, 0, &v111 @ stack_-5C_v6, *([v60 @ X22_v4 (Il2CppMethodInfo)+C28]));\n\tv213 = v120 & 1;\n\tv122 = v213 == 0;\n\tif (v122) goto L_003C;\n\tv243 = this.solver;\n\tv126 = v243.emissionColors;\n\t*([v126 @ X8_v13 (Unity.Collections.NativeArray`1<Unity.Mathematics.float4>)+v111 @ stack_-5C_v6*16]) = *([2875980]);\n\tgoto L_003C;\nL_0055:\n\tSystem.Collections.Generic.HashSet`1+Enumerator::Dispose /* +1 sharing this address */(&v47 @ stack_-58_v1, *([v62 @ X20_v5 (Il2CppMethodInfo)+968]));\nL_005F:\n\treturn;\nL_0060:\n\tv167 = new System.NullReferenceException();\n\tgoto L_0063;\n\tv244 = new System.NullReferenceException();\nL_0063:\n\t// 99 Interrupt\nL_0064:\n\tv100 = new System.NullReferenceException();\n\tgoto L_0072;\n\tgoto L_0072;\n\tgoto L_0072;\nL_0072:\n\tv140 = v149 != 1;\n\tif (v140) goto L_0082;\n\tv146 = 0x274A080(v100, v149, v112, v114, v31, v32, v33, v34, *([2875980]), v36, v37, v38, v39, v40, v41, v42);\n\tv163 = 0x274A098(v146, v149, v112, v114, v31, v32, v33, v34, *([2875980]), v36, v37, v38, v39, v40, v41, v42);\n\tv149 = *([v99 @ X20_v2 (System.Int32)]);\n\tSystem.Collections.Generic.HashSet`1+Enumerator::Dispose /* +1 sharing this address */(&v47 @ stack_-58_v1, *([v99 @ X20_v2 (System.Int32)]));\n\tv154 = *([v146 @ X0_v12]) == 0;\n\tif (v154) goto L_005F;\n\tv152 = new System.OutOfMemoryException();\nL_0082:\n\tv158 = 0xBF092C(&v87 @ stack_-70 (System.Int32), v149, v112, v114, v31, v32, v33, v34, *([2875980]), v36, v37, v38, v39, v40, v41, v42);\n\tv165 = 0x27498DC(v155, v149, v112, v114, v31, v32, v33, v34, *([2875980]), v36, v37, v38, v39, v40, v41, v42);\n\tv212 = 0xD6F8(v165, v149, v112, v114, v31, v32, v33, v34, *([2875980]), v36, v37, v38, v39, v40, v41, v42);\n\treturn;\n// 71 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void _003CHandleFlash_003Eg__SetAlpha_007C15_0(float val)
	{
		if (particleIds == null || solver == null)
		{
			return;
		}
		foreach (int id in particleIds)
		{
			if (solver.idToIndex.TryGetValue(id, out var index))
			{
				solver.emissionColors[index] = new global::Unity.Mathematics.float4(1f, 1f, 1f, val);
			}
		}
	}
}
