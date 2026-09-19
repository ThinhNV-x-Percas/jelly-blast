[global::Cpp2ILInjected.Token(Token = "0x2000068")]
public class Fish : SpecialFluid
{
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x200006C")]
	private sealed class _003CRotateBlob_003Ed__31 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
	{
		[global::Cpp2ILInjected.Token(Token = "0x40001DF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[global::Cpp2ILInjected.Token(Token = "0x40001E0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[global::Cpp2ILInjected.Token(Token = "0x40001E1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public Fish _003C_003E4__this;

		[global::Cpp2ILInjected.Token(Token = "0x40001E2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private float _003CstartTime_003E5__2;

		[global::Cpp2ILInjected.Token(Token = "0x40001E3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private float _003Cduration_003E5__3;

		[global::Cpp2ILInjected.Token(Token = "0x40001E4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private float _003CendTime_003E5__4;

		[global::Cpp2ILInjected.Token(Token = "0x17000018")]
		object global::System.Collections.Generic.IEnumerator<object>.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000236")]
			[global::Cpp2ILInjected.Address(RVA = "0xFF8568", Offset = "0xFF8568", Length = "0x8")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn this.<>2__current;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
			get
			{
				return _003C_003E2__current;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000019")]
		object global::System.Collections.IEnumerator.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000238")]
			[global::Cpp2ILInjected.Address(RVA = "0xFF85B0", Offset = "0xFF85B0", Length = "0x8")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn this.<>2__current;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
			get
			{
				return _003C_003E2__current;
			}
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x6000233")]
		[global::Cpp2ILInjected.Address(RVA = "0xFF6C20", Offset = "0xFF6C20", Length = "0x2C")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tSystem.Object::.ctor(this);\n\tthis.<>1__state = <>1__state;\n\treturn;\n// 14 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public _003CRotateBlob_003Ed__31(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x6000234")]
		[global::Cpp2ILInjected.Address(RVA = "0xFF8464", Offset = "0xFF8464", Length = "0x4")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn;\n")]
		void global::System.IDisposable.Dispose()
		{
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000235")]
		[global::Cpp2ILInjected.Address(RVA = "0xFF8468", Offset = "0xFF8468", Length = "0x100")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = this.<>1__state == 1;\n\tif (v18) goto L_004D;\n\tv23 = this.<>1__state == 0;\n\tv24 = ~v23;\n\tif (v24) goto L_0066;\n\tthis.<>1__state = 0xFFFFFFFF;\n\tv30 = UnityEngine.Time::get_time();\n\tthis.<startTime>5__2 = v30;\n\tthis.<duration>5__3 = 0.35f;\n\tv80 = v30 + 0x3EB33333;\n\tthis.<endTime>5__4 = v80;\n\tv82 = UnityEngine.Time::get_time();\n\tv140 = v82 >= this.<endTime>5__4;\n\tif (v140) goto L_005F;\nL_0030:\n\tv159 = UnityEngine.Time::get_time();\n\tv176 = v159 - this.<startTime>5__2;\n\tv177 = v176 / this.<duration>5__3;\n\tv162 = EasingFunction::EaseOutQuad(v177);\n\tv179 = v162 + -1f;\n\tv99 = v179 * 0.5f;\n\tFish::<RotateBlob>g__SetRot|31_0(this.<>4__this, v99);\n\tv181 = this + 0x18;\n\tthis.<>2__current = 0;\n\tv183 = 0xF3F1B4(v181, 0, v165, v166, v167, v168, v169, v170, v99, 0.5f, this.<duration>5__3, v171, v172, v173, v174, v175);\n\tthis.<>1__state = 1;\n\treturn 1;\nL_004D:\n\tthis.<>1__state = 0xFFFFFFFF;\n\tv27 = UnityEngine.Time::get_time();\n\tv71 = v27 < this.<endTime>5__4;\n\tif (v71) goto L_0030;\nL_005F:\n\tFish::<RotateBlob>g__SetRot|31_0(this.<>4__this, 1f);\nL_0066:\n\treturn 0;\n\treturnVal2 = new System.NullReferenceException();\n\treturn returnVal2;\n// 71 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
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
			_003C_003E4__this._003CRotateBlob_003Eg__SetRot_007C31_0(1f);
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
			_003C_003E4__this._003CRotateBlob_003Eg__SetRot_007C31_0(rot);
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
		[global::Cpp2ILInjected.Token(Token = "0x6000237")]
		[global::Cpp2ILInjected.Address(RVA = "0xFF8570", Offset = "0xFF8570", Length = "0x40")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv10 = Facebook.Unity.Windows.IWindowsFacebook + 0xF30;\n\tv11 = 0xF3F22C(v10, methodInfo, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26);\n\tv27 = new v11();\n\tSystem.NotSupportedException::.ctor(v27);\n\tv31 = Il2CppMethodInfo + 0xD18;\n\tv32 = 0xF3F22C(v31, 0, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26);\n\tthrow v27;\n// 13 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		void global::System.Collections.IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0039: Expected O, but got I
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F22C");
			global::System.NotSupportedException ex = new global::System.NotSupportedException();
			object obj2 = (nint)0 + (nint)3352;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F22C");
			throw ex;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x40001BB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public global::UnityEngine.Transform fish;

	[global::Cpp2ILInjected.Token(Token = "0x40001BC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public float fishMoveMag;

	[global::Cpp2ILInjected.Token(Token = "0x40001BD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xBC")]
	public float fishMoveFreq;

	[global::Cpp2ILInjected.Token(Token = "0x40001BE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public float fishMoveOffset;

	[global::Cpp2ILInjected.Token(Token = "0x40001BF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public global::UnityEngine.Animator animator;

	[global::Cpp2ILInjected.Token(Token = "0x40001C0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public bool hasSwum;

	[global::Cpp2ILInjected.Token(Token = "0x40001C1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	private global::DG.Tweening.Tween _danceTween;

	[global::Cpp2ILInjected.Token(Token = "0x40001C2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	private global::UnityEngine.Vector3 pendingCenter;

	[global::Cpp2ILInjected.Token(Token = "0x40001C3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xEC")]
	private global::UnityEngine.Vector3 pendingMenu;

	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x40001C4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
	private global::System.Action m_OnMenuReached;

	[global::UnityEngine.SerializeField]
	[global::UnityEngine.Header("Ease Curves")]
	[global::Cpp2ILInjected.Token(Token = "0x40001C5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
	private global::UnityEngine.AnimationCurve centerEase;

	[global::UnityEngine.SerializeField]
	[global::Cpp2ILInjected.Token(Token = "0x40001C6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	private global::UnityEngine.AnimationCurve menuEase;

	[global::UnityEngine.Tooltip("Ease for the scale-up (0→1 over the first leg)")]
	[global::UnityEngine.Header("Scale Settings")]
	[global::UnityEngine.SerializeField]
	[global::Cpp2ILInjected.Token(Token = "0x40001C7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
	private global::UnityEngine.AnimationCurve scaleEase;

	[global::UnityEngine.Header("Face Blend-Shapes")]
	[global::UnityEngine.SerializeField]
	[global::Cpp2ILInjected.Token(Token = "0x40001C8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
	private global::UnityEngine.SkinnedMeshRenderer faceRenderer;

	[global::UnityEngine.Header("Dive Settings")]
	[global::UnityEngine.SerializeField]
	[global::Cpp2ILInjected.Token(Token = "0x40001C9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
	private float diveAngle;

	[global::UnityEngine.SerializeField]
	[global::Cpp2ILInjected.Token(Token = "0x40001CA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x124")]
	private float fallWaitTime;

	[global::UnityEngine.Header("Dive & Rise Durations")]
	[global::UnityEngine.SerializeField]
	[global::Cpp2ILInjected.Token(Token = "0x40001CB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
	private float riseRotationDuration;

	[global::UnityEngine.Header("Move Durations")]
	[global::Cpp2ILInjected.Token(Token = "0x40001CC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x12C")]
	private float centerMoveDuration;

	[global::Cpp2ILInjected.Token(Token = "0x40001CD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
	private float menuMoveDuration;

	[global::UnityEngine.Tooltip("How much bigger the fish gets at centre (1 = no change)")]
	[global::UnityEngine.SerializeField]
	[global::UnityEngine.Header("Scale Multipliers")]
	[global::Cpp2ILInjected.Token(Token = "0x40001CE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x134")]
	private float growScaleMultiplier;

	[global::UnityEngine.Tooltip("How small the fish should be when it hits the menu (1 = no change)")]
	[global::UnityEngine.SerializeField]
	[global::Cpp2ILInjected.Token(Token = "0x40001CF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
	private float shrinkScaleMultiplier;

	[global::Cpp2ILInjected.Token(Token = "0x40001D0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x13C")]
	private bool _isFinalFish;

	[global::Cpp2ILInjected.Token(Token = "0x40001D1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x13D")]
	public bool isBig;

	[global::Cpp2ILInjected.Token(Token = "0x14000001")]
	public event global::System.Action OnMenuReached
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x6000218")]
		[global::Cpp2ILInjected.Address(RVA = "0xFF631C", Offset = "0xFF631C", Length = "0xA4")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0015;\n\tv23 = CollectParticleData[];\n\tv24 = v23 + 0x990;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, value, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv42 = 1;\n\t*([302A9D7]) = v42;\nL_0015:\n\tv43 = CollectParticleData[];\n\tv45 = this + 0xF8;\n\tgoto L_002C;\nL_001D:\n\tv79 = 0xFAC9D8(v45, v89, v84, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv63 = v79 == v84;\n\tif (v63) goto L_0045;\nL_002C:\n\tv89 = System.Delegate::Combine(v84, value);\n\tv81 = v89 == 0;\n\tif (v81) goto L_001D;\n\tv96 = *([v89 @ X0_v4 (System.Delegate)]) == *([v43 @ X22_v1 (Il2CppClass<CollectParticleData[]>)+990]);\n\tif (v96) goto L_001D;\n\tthrow System.InvalidCastException;\nL_0045:\n\treturn;\n// 51 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		add
		{
			//IL_009a: Expected I, but got O
			//IL_00a6: Expected O, but got I
			global::System.Delegate obj2 = this.m_OnMenuReached;
			bool flag;
			global::System.Delegate obj4 = default(global::System.Delegate);
			do
			{
				global::System.Delegate obj3 = global::System.Delegate.Combine(obj2, value);
				if ((object)obj3 != null)
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X22_v1 (Il2CppClass<CollectParticleData[]>)+990]");
					if ((object)obj3 != null)
					{
						throw new global::System.InvalidCastException();
					}
				}
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FAC9D8");
				flag = (object)obj4 == obj2;
				obj2 = obj4;
			}
			while (!flag);
		}
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x6000219")]
		[global::Cpp2ILInjected.Address(RVA = "0xFF63C0", Offset = "0xFF63C0", Length = "0xA4")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0015;\n\tv23 = CollectParticleData[];\n\tv24 = v23 + 0x990;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, value, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv42 = 1;\n\t*([302A9D8]) = v42;\nL_0015:\n\tv43 = CollectParticleData[];\n\tv45 = this + 0xF8;\n\tgoto L_002C;\nL_001D:\n\tv79 = 0xFAC9D8(v45, v89, v84, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv63 = v79 == v84;\n\tif (v63) goto L_0045;\nL_002C:\n\tv89 = System.Delegate::Remove(v84, value);\n\tv81 = v89 == 0;\n\tif (v81) goto L_001D;\n\tv96 = *([v89 @ X0_v4 (System.Delegate)]) == *([v43 @ X22_v1 (Il2CppClass<CollectParticleData[]>)+990]);\n\tif (v96) goto L_001D;\n\tthrow System.InvalidCastException;\nL_0045:\n\treturn;\n// 51 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		remove
		{
			//IL_009a: Expected I, but got O
			//IL_00a6: Expected O, but got I
			global::System.Delegate obj2 = this.m_OnMenuReached;
			bool flag;
			global::System.Delegate obj4 = default(global::System.Delegate);
			do
			{
				global::System.Delegate obj3 = global::System.Delegate.Remove(obj2, value);
				if ((object)obj3 != null)
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X22_v1 (Il2CppClass<CollectParticleData[]>)+990]");
					if ((object)obj3 != null)
					{
						throw new global::System.InvalidCastException();
					}
				}
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FAC9D8");
				flag = (object)obj4 == obj2;
				obj2 = obj4;
			}
			while (!flag);
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x600021A")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF6464", Offset = "0xFF6464", Length = "0x2A8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0021;\n\tv35 = Il2CppMethodInfo;\n\tv36 = v35 + 0xF80;\n\tv37 = \"il2cpp_codegen_initialize_runtime_metadata\"(v36, methodInfo, v39, v40, v41, v42, v43, v44, worldMenuTarget, v0, v2, v45, v46, v47, v48, v49);\n\tv56 = \"Scrollbar Horizontal\";\n\tv57 = v56 + 0x9B0;\n\tv51 = \"il2cpp_codegen_initialize_runtime_metadata\"(v57, methodInfo, v39, v40, v41, v42, v43, v44, worldMenuTarget, v0, v2, v45, v46, v47, v48, v49);\n\tv53 = 1;\n\t*([302AA2E]) = v53;\nL_0021:\n\tv55 = ~this.hasSwum;\n\tif (v55) goto L_0030;\n\treturn;\nL_0030:\n\tthis.hasSwum = 1;\n\tthis.pendingMenu = worldMenuTarget;\n\tthis.pendingMenu.y = worldMenuTarget.y;\n\tthis.pendingMenu.z = worldMenuTarget.z;\n\tv70 = UnityEngine.Camera::get_main();\n\tv157 = UnityEngine.Transform::get_position(this.fish);\n\tv195 = UnityEngine.Camera::WorldToViewportPoint(v70, v157);\n\tv199 = v195.z + -6f;\n\t// 76 MakeStruct v102 @ AGGFF652C_1_v2 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), 0.5f, 0.5f, v199 @ V2_v5 (System.Single)\n\tv162 = UnityEngine.Camera::ViewportToWorldPoint(v70, v102);\n\tthis.pendingCenter = v162;\n\tthis.pendingCenter.y = v162.y;\n\tthis.pendingCenter.z = v162.z;\n\tUnityEngine.SkinnedMeshRenderer::SetBlendShapeWeight(this.faceRenderer, 1, 100f);\n\tUnityEngine.SkinnedMeshRenderer::SetBlendShapeWeight(this.faceRenderer, 2, 0f);\n\tv203 = \"Scrollbar Horizontal\";\n\tUnityEngine.Animator::SetBool(this.animator, *([v203 @ X8_v7 (System.String)+9B0]), 1);\n\tv205 = UnityEngine.Transform::get_localRotation(this.fish);\n\tv213 = this.diveAngle * 0x3C8EFA35;\n\t// 127 MakeStruct v89 @ AGGFF65CC_0_v2 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), v213 @ V0_v11 (System.Single), 0, 0\n\tv217 = UnityEngine.Quaternion::Internal_FromEulerRad(v89);\n\tv221 = v205.w * v217;\n\tv222 = v205 * v217.w;\n\tv223 = v221 + v222;\n\tv224 = v205.y * v217.z;\n\tv225 = v224 + v223;\n\tv226 = v205.z * v217.y;\n\tv79 = v225 - v226;\n\tv227 = v205.w * v217.y;\n\tv228 = v205.y * v217.w;\n\tv229 = v227 + v228;\n\tv230 = v205.z * v217;\n\tv231 = v230 + v229;\n\tv232 = v205 * v217.z;\n\tv82 = v231 - v232;\n\tv233 = v205.w * v217.z;\n\tv234 = v205.z * v217.w;\n\tv235 = v233 + v234;\n\tv236 = v205 * v217.y;\n\tv237 = v236 + v235;\n\tv238 = v205.y * v217;\n\tv76 = v237 - v238;\n\tv239 = v205.w * v217.w;\n\tv240 = v205 * v217;\n\tv241 = v239 - v240;\n\tv242 = v205.y * v217.y;\n\tv243 = v241 - v242;\n\tv244 = v205.z * v217.z;\n\tv92 = v243 - v244;\n\t// 168 MakeStruct v73 @ AGGFF6660_1_v2 (UnityEngine.Quaternion), typeof(UnityEngine.Quaternion), v79 @ V7_v2 (System.Single), v82 @ V5_v8 (System.Single), v76 @ V6_v5 (System.Single), v92 @ V3_v5 (System.Single)\n\tv249 = DG.Tweening.ShortcutExtensions::DOLocalRotateQuaternion(this.fish, v73, 0.2f);\n\tv250 = Il2CppMethodInfo;\n\tv176 = DG.Tweening.TweenSettingsExtensions::SetEase /* +1 sharing this address */(v249, 5, *([v250 @ X8_v13 (Il2CppMethodInfo)+F80]));\n\tv252 = this.solver + 0x220;\n\tUnity.Jobs.JobHandle::Complete(v252);\n\tv256 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tgoto L_00C3;\n\tv260 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv261 = v260 + 0xB28;\n\tv262 = \"il2cpp_codegen_initialize_runtime_metadata\"(v261, v253, v161, v95, v41, v42, v43, v44, v109, v152, v149, v92, v85, v82, v76, v79);\n\tv264 = 1;\n\t*([302AA2F]) = v264;\nL_00C3:\n\tv266 = new *([v256 @ X21_v1 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+B28])();\n\tSystem.Object::.ctor(v266);\n\t*([v266 @ X0_v20 (System.Object)+10]) = 0;\n\tv270 = v266 + 0x20;\n\t*([v266 @ X0_v20 (System.Object)+20]) = this;\n\tv272 = 0xF3F1B4(v270, this, *([v250 @ X8_v13 (Il2CppMethodInfo)+F80]), 0, v41, v42, v43, v44, v79, v82, v76, v92, 0x3E4CCCCD, v82, v76, v79);\n\t*([v266 @ X0_v20 (System.Object)+28]) = v205;\n\t*([v266 @ X0_v20 (System.Object)+2C]) = v205.y;\n\t*([v266 @ X0_v20 (System.Object)+30]) = v205.z;\n\t*([v266 @ X0_v20 (System.Object)+34]) = v205.w;\n\tv124 = UnityEngine.MonoBehaviour::StartCoroutine(this, v266);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 139 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public unsafe void PlayHitWaterAnimation(global::UnityEngine.Vector3 worldMenuTarget)
	{
		if (hasSwum)
		{
			return;
		}
		hasSwum = true;
		pendingMenu = worldMenuTarget;
		global::UnityEngine.Camera main = global::UnityEngine.Camera.main;
		float viewportZ = main.WorldToViewportPoint(fish.position).z - 6f;
		pendingCenter = main.ViewportToWorldPoint(new global::UnityEngine.Vector3(0.5f, 0.5f, viewportZ));
		faceRenderer.SetBlendShapeWeight(1, 100f);
		faceRenderer.SetBlendShapeWeight(2, 0f);
		animator.SetBool("IsSwimming", true);
		global::UnityEngine.Quaternion localRotation = fish.localRotation;
		global::UnityEngine.Quaternion diveRotation = global::UnityEngine.Quaternion.Euler(diveAngle, 0f, 0f);
		global::UnityEngine.Quaternion endValue = localRotation * diveRotation;
		global::DG.Tweening.TweenSettingsExtensions.SetEase(global::DG.Tweening.ShortcutExtensions.DOLocalRotateQuaternion(fish, endValue, 0.2f), (global::DG.Tweening.Ease)5);
		solver._lastJob.Complete();
		StartCoroutine(FallThenFly(localRotation));
	}

	[global::Cpp2ILInjected.Token(Token = "0x600021B")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF67B8", Offset = "0xFF67B8", Length = "0x8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tthis._isFinalFish = isFinal;\n\treturn;\n")]
	public void SetFinalFish(bool isFinal)
	{
		_isFinalFish = isFinal;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600021C")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF67C0", Offset = "0xFF67C0", Length = "0x1A4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0022;\n\tv25 = Il2CppMethodInfo;\n\tv26 = v25 + 0x968;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv53 = Il2CppMethodInfo;\n\tv54 = v53 + 0x970;\n\tv55 = \"il2cpp_codegen_initialize_runtime_metadata\"(v54, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv126 = Il2CppMethodInfo;\n\tv127 = v126 + 0x978;\n\tv128 = \"il2cpp_codegen_initialize_runtime_metadata\"(v127, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv129 = Il2CppMethodInfo;\n\tv130 = v129 + 0x998;\n\tv131 = \"il2cpp_codegen_initialize_runtime_metadata\"(v130, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv174 = Il2CppMethodInfo;\n\tv175 = v174 + 0xC28;\n\tv44 = \"il2cpp_codegen_initialize_runtime_metadata\"(v175, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv46 = 1;\n\t*([302A9D9]) = v46;\nL_0022:\n\tv47 = 0;\n\tv52 = this.particleIds == 0;\n\tif (v52) goto L_006E;\n\tv58 = Il2CppMethodInfo;\n\tv60 = Il2CppMethodInfo;\n\tv62 = Il2CppMethodInfo;\n\tv114 = Il2CppMethodInfo + 0x968;\n\tv67 = System.Collections.Generic.HashSet`1<System.Int32>::GetEnumerator(this.particleIds);\nL_0039:\n\tv162 = System.Collections.Generic.HashSet`1+Enumerator::MoveNext /* +1 sharing this address */(&v47 @ stack_-58_v1, *([v58 @ X22_v4 (Il2CppMethodInfo)+970]));\n\tv177 = v162 == 0;\n\tif (v177) goto L_005E;\n\tv192 = this.solver == 0;\n\tif (v192) goto L_006A;\n\tv217 = this.solver + 0x1F8;\n\tv152 = Unity.Collections.NativeHashMap`2::TryGetValue /* +1 sharing this address */(v217, 0, &v144 @ stack_-5C_v7, *([v60 @ X23_v4 (Il2CppMethodInfo)+C28]));\n\tv256 = v152 & 1;\n\tv154 = v256 == 0;\n\tif (v154) goto L_0039;\n\tv286 = this.solver;\n\tv158 = v286.waterDensities;\n\tv132 = *([v158 @ X8_v13 (Unity.Collections.NativeArray`1<System.Single>)+v144 @ stack_-5C_v7*4]) <= 0;\n\tif (v132) goto L_0039;\nL_005E:\n\tSystem.Collections.Generic.HashSet`1+Enumerator::Dispose /* +1 sharing this address */(&v47 @ stack_-58_v1, *([v62 @ X21_v4 (Il2CppMethodInfo)+968]));\nL_0069:\n\treturn v243;\nL_006A:\n\tv218 = new System.NullReferenceException();\n\tgoto L_006D;\n\tv287 = new System.NullReferenceException();\nL_006D:\n\t// 109 Interrupt\nL_006E:\n\tv125 = new System.NullReferenceException();\n\tgoto L_007C;\n\tgoto L_007C;\n\tgoto L_007C;\nL_007C:\n\tv173 = v182 != 1;\n\tif (v173) goto L_008F;\n\tv179 = 0x274A080(v125, v182, v145, v147, v31, v32, v33, v34, *([v158 @ X8_v13 (Unity.Collections.NativeArray`1<System.Single>)+v144 @ stack_-5C_v7*4]), v36, v37, v38, v39, v40, v41, v42);\n\tv214 = 0x274A098(v179, v182, v145, v147, v31, v32, v33, v34, *([v158 @ X8_v13 (Unity.Collections.NativeArray`1<System.Single>)+v144 @ stack_-5C_v7*4]), v36, v37, v38, v39, v40, v41, v42);\n\tv182 = *([v114 @ X21_v1]);\n\tSystem.Collections.Generic.HashSet`1+Enumerator::Dispose /* +1 sharing this address */(&v47 @ stack_-58_v1, *([v114 @ X21_v1]));\n\tv285 = *([v179 @ X0_v12]) == 0;\n\tv187 = ~v285;\n\tif (v187) goto L_008C;\n\tgoto L_0069;\nL_008C:\n\tv185 = new System.OutOfMemoryException();\nL_008F:\n\tv191 = 0xBF092C(&v111 @ stack_-70 (System.Int32), v182, v145, v147, v31, v32, v33, v34, *([v158 @ X8_v13 (Unity.Collections.NativeArray`1<System.Single>)+v144 @ stack_-5C_v7*4]), v36, v37, v38, v39, v40, v41, v42);\n\tv216 = 0x27498DC(v188, v182, v145, v147, v31, v32, v33, v34, *([v158 @ X8_v13 (Unity.Collections.NativeArray`1<System.Single>)+v144 @ stack_-5C_v7*4]), v36, v37, v38, v39, v40, v41, v42);\n\treturnVal2 = 0xD6F8(v216, v182, v145, v147, v31, v32, v33, v34, *([v158 @ X8_v13 (Unity.Collections.NativeArray`1<System.Single>)+v144 @ stack_-5C_v7*4]), v36, v37, v38, v39, v40, v41, v42);\n\treturn returnVal2;\n// 83 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private bool IsInWater()
	{
		if (particleIds == null || solver == null)
		{
			return false;
		}
		foreach (int id in particleIds)
		{
			if (solver.idToIndex.TryGetValue(id, out var index) && solver.waterDensities[index] > 0f)
			{
				return true;
			}
		}
		return false;
	}

	private global::System.Collections.IEnumerator FallThenFly(global::UnityEngine.Quaternion uprightRot)
	{
		global::UnityEngine.Vector3 startScale = fish.localScale;
		fish.localScale = new global::UnityEngine.Vector3(startScale.x, startScale.y, (startScale.x + startScale.y) * 0.5f);
		float elapsed = 0f;
		bool leftWaterEarly = false;
		if (fallWaitTime > 0f)
		{
			while (true)
			{
				if (!IsInWater())
				{
					leftWaterEarly = true;
					break;
				}
				if (elapsed >= fallWaitTime)
				{
					break;
				}
				elapsed += global::UnityEngine.Time.deltaTime;
				yield return null;
			}
		}
		if (leftWaterEarly)
		{
			hasSwum = false;
			animator.SetBool("IsSwimming", false);
			faceRenderer.SetBlendShapeWeight(1, 0f);
			faceRenderer.SetBlendShapeWeight(2, 100f);
			m_OnMenuReached = null;
			global::DG.Tweening.TweenSettingsExtensions.SetEase(global::DG.Tweening.ShortcutExtensions.DOLocalRotateQuaternion(fish, uprightRot, 0.1f), (global::DG.Tweening.Ease)5);
			yield break;
		}
		mr.enabled = false;
		solver.RemoveParticles(particleIds);
		if (!_isFinalFish)
		{
			GoalData goalData = global::Singleton<GameManager>.Instance.level.goals.Find((GoalData g) => g.goalType == GoalType.Fish);
			if (goalData != null && goalData.displayedCount + 1 >= goalData.count)
			{
				_isFinalFish = true;
			}
		}
		if (_isFinalFish)
		{
			global::DG.Tweening.Sequence sequence = global::DG.Tweening.DOTween.Sequence();
			float halfRise = riseRotationDuration * 0.3f;
			float riseDuration = halfRise + halfRise;
			float centerDone = centerMoveDuration + riseDuration;
			global::DG.Tweening.Tween moveToCenter = global::DG.Tweening.ShortcutExtensions.DOMove(fish, pendingCenter, centerDone);
			global::DG.Tweening.TweenSettingsExtensions.Append(sequence, moveToCenter);
			global::UnityEngine.Quaternion diveRotation = global::UnityEngine.Quaternion.Euler(-20f, 0f, 0f);
			global::DG.Tweening.Tween diveTween = global::DG.Tweening.ShortcutExtensions.DOLocalRotateQuaternion(fish, uprightRot * diveRotation, halfRise);
			global::DG.Tweening.TweenSettingsExtensions.Insert(sequence, 0f, diveTween);
			global::UnityEngine.Quaternion riseRotation = global::UnityEngine.Quaternion.Euler(-45f, 0f, 0f);
			global::DG.Tweening.Tween riseTween = global::DG.Tweening.ShortcutExtensions.DOLocalRotateQuaternion(fish, uprightRot * riseRotation, halfRise);
			global::DG.Tweening.TweenSettingsExtensions.Insert(sequence, halfRise, riseTween);
			global::DG.Tweening.Tween uprightTween = global::DG.Tweening.ShortcutExtensions.DOLocalRotateQuaternion(fish, uprightRot, centerMoveDuration);
			global::DG.Tweening.TweenSettingsExtensions.Insert(sequence, riseDuration, uprightTween);
			global::DG.Tweening.Tween growTween = global::DG.Tweening.ShortcutExtensions.DOScale(fish, growScaleMultiplier, centerMoveDuration);
			global::DG.Tweening.TweenSettingsExtensions.Insert(sequence, riseDuration, growTween);
			global::DG.Tweening.Tween moveToMenu = global::DG.Tweening.ShortcutExtensions.DOMove(fish, pendingMenu, menuMoveDuration);
			global::DG.Tweening.TweenSettingsExtensions.Append(sequence, moveToMenu);
			global::DG.Tweening.Tween shrinkTween = global::DG.Tweening.ShortcutExtensions.DOScale(fish, shrinkScaleMultiplier, menuMoveDuration);
			global::DG.Tweening.TweenSettingsExtensions.Join(sequence, shrinkTween);
			global::UnityEngine.Quaternion menuRotation = global::UnityEngine.Quaternion.Euler(-45f, 0f, 0f);
			global::DG.Tweening.Tween menuRotateTween = global::DG.Tweening.ShortcutExtensions.DOLocalRotateQuaternion(fish, menuRotation, menuMoveDuration);
			global::DG.Tweening.TweenSettingsExtensions.Join(sequence, menuRotateTween);
			global::DG.Tweening.TweenSettingsExtensions.OnComplete(sequence, delegate
			{
				m_OnMenuReached?.Invoke();
			});
		}
		else
		{
			global::DG.Tweening.Sequence sequence2 = global::DG.Tweening.DOTween.Sequence();
			global::DG.Tweening.Tween moveToCenter2 = global::DG.Tweening.TweenSettingsExtensions.SetEase(global::DG.Tweening.ShortcutExtensions.DOMove(fish, pendingCenter, centerMoveDuration), centerEase);
			global::DG.Tweening.TweenSettingsExtensions.Append(sequence2, moveToCenter2);
			global::DG.Tweening.Tween growTween2 = global::DG.Tweening.TweenSettingsExtensions.SetEase(global::DG.Tweening.ShortcutExtensions.DOScale(fish, growScaleMultiplier, centerMoveDuration), scaleEase);
			global::DG.Tweening.TweenSettingsExtensions.Join(sequence2, growTween2);
			global::DG.Tweening.Tween moveToMenu2 = global::DG.Tweening.TweenSettingsExtensions.SetEase(global::DG.Tweening.ShortcutExtensions.DOMove(fish, pendingMenu, menuMoveDuration), menuEase);
			global::DG.Tweening.TweenSettingsExtensions.Append(sequence2, moveToMenu2);
			global::DG.Tweening.Tween shrinkTween2 = global::DG.Tweening.TweenSettingsExtensions.SetEase(global::DG.Tweening.ShortcutExtensions.DOScale(fish, shrinkScaleMultiplier, menuMoveDuration), scaleEase);
			global::DG.Tweening.TweenSettingsExtensions.Join(sequence2, shrinkTween2);
			global::DG.Tweening.TweenSettingsExtensions.OnComplete(sequence2, delegate
			{
				m_OnMenuReached?.Invoke();
			});
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x600021E")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF6990", Offset = "0xFF6990", Length = "0x18C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tSpecialFluid::OnPreComputeUpdate(this);\n\tv27 = ~this.hasSwum;\n\tif (v27) goto L_005D;\n\tv35 = UnityEngine.Component::get_transform(this.fish);\n\tgoto L_0025;\n\tv108 = System.Xml.ValidateNames;\n\tv109 = v108 + 0xD0;\n\tv110 = \"il2cpp_codegen_initialize_runtime_metadata\"(v109, v34, v85, v86, v87, v88, v89, v90, v48, v44, v40, v91, v92, v93, v94, v95);\n\tv112 = 1;\n\t*([2DD441A]) = v112;\nL_0025:\n\tv173 = System.Xml.ValidateNames;\n\tv175 = *([v173 @ X8_v12 (Il2CppClass<System.Xml.ValidateNames>)+D0]);\n\tv81 = *([v175 @ X8_v14+B8]);\n\tv66 = UnityEngine.Component::get_transform(this.fish);\n\tv49 = UnityEngine.Transform::get_localScale(v66);\n\tv68 = UnityEngine.Component::get_transform(this.fish);\n\tv50 = UnityEngine.Transform::get_localScale(v68);\n\tv179 = v49 + v50.y;\n\tv180 = *([v81 @ X8_v15+14]) * v179;\n\tv134 = v180 * 0.5f;\n\tv182 = *([v81 @ X8_v15+C]) * v183;\n\tv140 = v182 * 0x3F;\n\t// 86 MakeStruct v119 @ AGGFF6A84_1_v1 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), v140 @ V0_v11, v185 @ V0.S1, v134 @ V2_v7 (System.Single)\n\tUnityEngine.Transform::set_localScale(v35, v119);\n\treturn;\nL_005D:\n\tgoto L_0063;\n\tv96 = System.Xml.ValidateNames;\n\tv97 = v96 + 0xD0;\n\tv98 = \"il2cpp_codegen_initialize_runtime_metadata\"(v97, methodInfo, v85, v86, v87, v88, v89, v90, v48, v44, v40, v91, v92, v93, v94, v95);\n\tv101 = 1;\n\t*([2DD441B]) = v101;\nL_0063:\n\tv102 = System.Xml.ValidateNames;\n\tv104 = *([v102 @ X8_v5 (Il2CppClass<System.Xml.ValidateNames>)+D0]);\n\tv82 = *([v104 @ X8_v7+B8]);\n\tv51 = UnityEngine.Time::get_time();\n\tv170 = v51 * this.fishMoveFreq;\n\tv171 = v170 + this.fishMoveOffset;\n\tv172 = 0x274B058(0, methodInfo, v85, v86, v87, v88, v89, v90, v171, this.fishMoveFreq, this.fishMoveOffset, v91, v92, v93, v94, v95);\n\tv176 = *([v82 @ X8_v8+20]) * v171;\n\tv135 = this.fishMoveMag * v176;\n\tv177 = *([v82 @ X8_v8+1C]) * v171;\n\tv138 = this.fishMoveMag * v177;\n\tv178 = *([v82 @ X8_v8+18]) * v171;\n\tv141 = this.fishMoveMag * v178;\n\t// 135 MakeStruct v115 @ AGGFF6B14_1_v1 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), v141 @ V0_v6 (System.Single), v138 @ V1_v5 (System.Single), v135 @ V2_v3 (System.Single)\n\tUnityEngine.Transform::set_localPosition(this.fish, v115);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 91 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public override void OnPreComputeUpdate()
	{
		//IL_023c: Expected I, but got O
		//IL_024c: Expected O, but got I
		//IL_025c: Expected O, but got I
		//IL_0043: Expected I, but got O
		//IL_0053: Expected O, but got I
		//IL_0063: Expected O, but got I
		//IL_0105: Expected O, but got I
		//IL_0114: Expected O, but got I
		//IL_0121: Expected F4, but got O
		//IL_012e: Expected F4, but got O
		base.OnPreComputeUpdate();
		if (hasSwum)
		{
			global::UnityEngine.Vector3 localScale = fish.localScale;
			fish.localScale = new global::UnityEngine.Vector3(localScale.x, localScale.y, (localScale.x + localScale.y) * 0.5f);
		}
		else
		{
			float angle = global::UnityEngine.Time.time * fishMoveFreq + fishMoveOffset;
			float sin = global::UnityEngine.Mathf.Sin(angle);
			float cos = global::UnityEngine.Mathf.Cos(angle);
			fish.localPosition = new global::UnityEngine.Vector3(fishMoveMag * cos, fishMoveMag * sin, fishMoveMag * sin);
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x600021F")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF6B1C", Offset = "0xFF6B1C", Length = "0x8C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tthis.id = _id;\n\tUnityEngine.Renderer::set_material(this.mr, _material);\n\tthis.isBig = _isBig;\n\tv49 = UnityEngine.Random::Range(0f, 360f);\n\tthis.fishMoveOffset = v49;\n\tSpecialFluid::Init(this, _solver, _particleIds, _fluidType, _compute);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 39 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void Init(FluidSolver _solver, int _id, global::System.Collections.Generic.HashSet<int> _particleIds, int _fluidType, FluidCompute _compute, global::UnityEngine.Material _material, bool _isBig)
	{
		id = _id;
		mr.material = _material;
		isBig = _isBig;
		float num = global::UnityEngine.Random.Range(0f, 360f);
		fishMoveOffset = num;
		base.Init(_solver, _particleIds, _fluidType, _compute);
	}

	[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(Fish._003CRotateBlob_003Ed__31))]
	[global::Cpp2ILInjected.Token(Token = "0x6000220")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF6BA8", Offset = "0xFF6BA8", Length = "0x78")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tgoto L_0017;\n\tv23 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv24 = v23 + 0xB30;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv43 = 1;\n\t*([302AA30]) = v43;\nL_0017:\n\tv45 = new *([v18 @ X21_v1 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+B30])();\n\tSystem.Object::.ctor(v45);\n\t*([v45 @ X0_v3 (System.Object)+10]) = 0;\n\tv49 = v45 + 0x20;\n\t*([v45 @ X0_v3 (System.Object)+20]) = this;\n\tv51 = 0xF3F1B4(v49, this, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\treturn v45;\n// 28 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public global::System.Collections.IEnumerator RotateBlob()
	{
		return new _003CRotateBlob_003Ed__31(0)
		{
			_003C_003E4__this = this
		};
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000221")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF6C4C", Offset = "0xFF6C4C", Length = "0xDC")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv17 = UnityEngine.AnimationCurve::EaseInOut(0f, 0f, 1f, 1f);\n\tv19 = this + 0x100;\n\tthis.centerEase = v17;\n\tv20 = 0xF3F1B4(v19, v17, v21, v22, v23, v24, v25, v26, 0, 0, 1f, 1f, v27, v28, v29, v30);\n\tv36 = UnityEngine.AnimationCurve::Linear(0f, 0f, 1f, 1f);\n\tv38 = this + 0x108;\n\tthis.menuEase = v36;\n\tv39 = 0xF3F1B4(v38, v36, v21, v22, v23, v24, v25, v26, 0, 0, 1f, 1f, v27, v28, v29, v30);\n\tv45 = UnityEngine.AnimationCurve::EaseInOut(0f, 0f, 1f, 1f);\n\tv47 = this + 0x110;\n\tthis.scaleEase = v45;\n\tv48 = 0xF3F1B4(v47, v45, v21, v22, v23, v24, v25, v26, 0, 0, 1f, 1f, v27, v28, v29, v30);\n\tthis.diveAngle = *([28759A0]);\n\tthis.menuMoveDuration = 0.007812501842272468d;\n\tthis.shrinkScaleMultiplier = 0.5f;\n\tthis.zPos = -1f;\n\tthis.particleSize = 0.8f;\n\tthis.particleBoundsRadius = 0.4f;\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 42 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public Fish()
	{
		global::UnityEngine.AnimationCurve animationCurve = global::UnityEngine.AnimationCurve.EaseInOut(0f, 0f, 1f, 1f);
		centerEase = animationCurve;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		global::UnityEngine.AnimationCurve animationCurve2 = global::UnityEngine.AnimationCurve.Linear(0f, 0f, 1f, 1f);
		menuEase = animationCurve2;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		global::UnityEngine.AnimationCurve animationCurve3 = global::UnityEngine.AnimationCurve.EaseInOut(0f, 0f, 1f, 1f);
		scaleEase = animationCurve3;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [28759A0]");
		diveAngle = 0f;
		menuMoveDuration = 0.8f;
		growScaleMultiplier = 1f;
		shrinkScaleMultiplier = 0.5f;
		zPos = -1f;
		particleSize = 0.8f;
		particleBoundsRadius = 0.4f;
	}

	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x6000225")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF6F4C", Offset = "0xFF6F4C", Length = "0x90")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_001A;\n\tv23 = \"Writing object reference to Id '{0}' for {1}.\";\n\tv24 = v23 + 0x8C0;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, methodInfo, v27, v28, v29, v30, v31, v32, rot, v33, v34, v35, v36, v37, v38, v39);\n\tv42 = 1;\n\t*([302A9DD]) = v42;\nL_001A:\n\tUnityEngine.Renderer::GetPropertyBlock(this.mr, this._propBlock);\n\tv62 = \"Writing object reference to Id '{0}' for {1}.\";\n\tUnityEngine.MaterialPropertyBlock::SetFloat(this._propBlock, *([v62 @ X8_v4 (System.String)+8C0]), rot);\n\tUnityEngine.Renderer::SetPropertyBlock(this.mr, this._propBlock);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 39 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void _003CRotateBlob_003Eg__SetRot_007C31_0(float rot)
	{
		//IL_003f: Expected O, but got I
		mr.GetPropertyBlock(_propBlock);
		_propBlock.SetFloat("_Rotation", rot);
		mr.SetPropertyBlock(_propBlock);
	}
}
