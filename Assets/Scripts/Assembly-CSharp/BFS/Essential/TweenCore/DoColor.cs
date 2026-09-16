using System.Runtime.InteropServices;

namespace BFS.Essential.TweenCore
{
	[global::Cpp2ILInjected.Token(Token = "0x2000113")]
	public class DoColor : global::BFS.Essential.Tween
	{
		[StructLayout((LayoutKind)3)]
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000114")]
		private struct _003CValueTo_003Ed__0 : global::System.Runtime.CompilerServices.IAsyncStateMachine
		{
			[global::Cpp2ILInjected.Token(Token = "0x4000564")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[global::Cpp2ILInjected.Token(Token = "0x4000565")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder _003C_003Et__builder;

			[global::Cpp2ILInjected.Token(Token = "0x4000566")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public global::BFS.Essential.TweenCore.DoColor _003C_003E4__this;

			[global::Cpp2ILInjected.Token(Token = "0x4000567")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public float duration;

			[global::Cpp2ILInjected.Token(Token = "0x4000568")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public global::System.Action<global::UnityEngine.Color> callback;

			[global::Cpp2ILInjected.Token(Token = "0x4000569")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public global::UnityEngine.Color start;

			[global::Cpp2ILInjected.Token(Token = "0x400056A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			public global::UnityEngine.Color end;

			[global::Cpp2ILInjected.Token(Token = "0x400056B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			private float _003Clerp_003E5__2;

			[global::Cpp2ILInjected.Token(Token = "0x400056C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
			private global::System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter _003C_003Eu__1;

			[global::Cpp2ILInjected.Token(Token = "0x60004E2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1028AE0", Offset = "0x1028AE0", Length = "0x368")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_002A;\n\tv29 = Il2CppMethodInfo;\n\tv30 = v29 + 0x230;\n\tv31 = \"il2cpp_codegen_initialize_runtime_metadata\"(v30, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv62 = CollectParticleData[];\n\tv63 = v62 + 0xCA0;\n\tv64 = \"il2cpp_codegen_initialize_runtime_metadata\"(v63, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv69 = System.Net.Configuration.SettingsSectionInternal;\n\tv70 = v69 + 0x748;\n\tv71 = \"il2cpp_codegen_initialize_runtime_metadata\"(v70, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv145 = Sponge+<>c__DisplayClass7_0;\n\tv146 = v145 + 0x9D0;\n\tv48 = \"il2cpp_codegen_initialize_runtime_metadata\"(v146, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv50 = 1;\n\t*([302AB2A]) = v50;\nL_002A:\n\tv60 = this.<>4__this;\n\tv61 = this.<>1__state == 0;\n\tif (v61) goto L_0036;\n\tv65 = this.<>4__this == 0;\n\tif (v65) goto L_003A;\n\tv60.m_Run = 1;\n\tthis.<lerp>5__2 = 0f;\n\tgoto L_0041;\nL_0036:\n\tthis.<>u__1 = 0;\n\tthis.<>1__state = 0xFFFFFFFF;\n\tgoto L_00A3;\nL_003A:\n\tv74 = new System.NullReferenceException();\n\tgoto L_003D;\n\tgoto L_00F6;\nL_003D:\n\t// 61 Interrupt\nL_003E:\n\tv196 = this.<>4__this == 0;\n\tif (v196) goto L_00E5;\nL_0041:\n\tv200 = ~v60.m_Run;\n\tif (v200) goto L_00BD;\n\tv206 = UnityEngine.Time::get_deltaTime();\n\tv291 = v206 / this.duration;\n\tv292 = v134 + v291;\n\tv296 = v292 - 1f;\n\tv297 = v296 < 0;\n\tv298 = v296 == 0;\n\tv299 = v292 ^ 1f;\n\tv300 = v292 ^ v296;\n\tv301 = v299 & v300;\n\tv302 = v301 < 0;\n\tv303 = v297 == v302;\n\tv98 = ~v298;\n\tv101 = v303 & v98;\n\tv304 = ~v101;\n\tif (v304) goto L_FFFFFFFF;\n\tgoto L_0065;\nL_0065:\n\tv95 = v292 >= 0;\n\tif (v95) goto L_FFFFFFFF;\n\tgoto L_006B;\nL_006B:\n\tthis.<lerp>5__2 = v278;\n\tv76 = this.callback;\n\tv362 = this.callback == 0;\n\tif (v362) goto L_008A;\n\tv288 = v60.m_Interpolator;\n\tv286 = v60.m_Interpolator == 0;\n\tif (v286) goto L_00E7;\n\tv288.invoke_impl(this, v288.method_code, v288.method, v33, v34, v35, v36, v37, v38, v278, this.end, this.start, v80, v43, v44, v45, v46);\n\tv388 = this.end - this.start;\n\tv389 = v388 * v390;\n\tv371 = this.start + v389;\n\tv76.invoke_impl(this, v76.method_code, v76.method, v33, v34, v35, v36, v37, v38, v371, v391, v392, v393, v43, v44, v45, v46);\nL_008A:\n\tgoto L_008D;\n\tv395 = \"il2cpp_codegen_runtime_class_init\"(v377, v364, v33, v34, v35, v36, v37, v38, v130, v128, v93, v80, v43, v44, v45, v46);\nL_008D:\n\tv398 = System.Threading.Tasks.Task::Yield();\n\tv401 = System.Runtime.CompilerServices.YieldAwaitable::GetAwaiter(&v398 @ X0_v24 (System.Runtime.CompilerServices.YieldAwaitable));\n\tgoto L_009B;\n\tv406 = \"il2cpp_codegen_runtime_class_init\"(v403, v400, v33, v34, v35, v36, v37, v38, v130, v128, v93, v80, v43, v44, v45, v46);\nL_009B:\n\tv136 = System.Runtime.CompilerServices.YieldAwaitable+YieldAwaiter::get_IsCompleted(&v131 @ stack_-51_v4 (System.Runtime.CompilerServices.YieldAwaitable+YieldAwaiter));\n\tv138 = v136 == 0;\n\tif (v138) goto L_00C9;\nL_00A3:\n\tgoto L_00A7;\n\tv201 = \"il2cpp_codegen_runtime_class_init\"(v141, v81, v33, v34, v35, v36, v37, v38, v129, v127, v92, v79, v43, v44, v45, v46);\nL_00A7:\n\tSystem.Runtime.CompilerServices.YieldAwaitable+YieldAwaiter::GetResult(&v131 @ stack_-51_v4 (System.Runtime.CompilerServices.YieldAwaitable+YieldAwaiter));\n\tv134 = this.<lerp>5__2;\n\tv233 = this.<lerp>5__2 < 1f;\n\tif (v233) goto L_003E;\n\tv247 = this.<>4__this == 0;\n\tif (v247) goto L_00E9;\n\tthis = BFS.Essential.Tween::Kill(this.<>4__this, 1);\nL_00BD:\n\tthis.<>1__state = 0xFFFFFFFE;\n\tv251 = this + 8;\n\tgoto L_00C7;\n\tv305 = \"il2cpp_codegen_runtime_class_init\"(v252, v212, v208, v34, v35, v36, v37, v38, v239, v238, v218, v211, v43, v44, v45, v46);\nL_00C7:\n\tSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetResult(v251);\n\tgoto L_00E4;\nL_00C9:\n\tthis.<>1__state = 0;\n\tthis.<>u__1 = this.<>u__1;\n\tgoto L_00D2;\n\tv414 = \"il2cpp_codegen_runtime_class_init\"(v411, v82, v33, v34, v35, v36, v37, v38, v130, v128, v93, v80, v43, v44, v45, v46);\nL_00D2:\n\tv344 = this + 8;\n\tSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted(v344, &v131 @ stack_-51_v4 (System.Runtime.CompilerServices.YieldAwaitable+YieldAwaiter), this);\nL_00E4:\n\treturn;\nL_00E5:\n\tv282 = new System.NullReferenceException();\n\tgoto L_003D;\nL_00E7:\n\tv283 = new System.NullReferenceException();\n\tgoto L_003D;\nL_00E9:\n\tv284 = new System.NullReferenceException();\n\tgoto L_003D;\n\tgoto L_00F6;\n\tgoto L_00F6;\n\tgoto L_00F6;\n\tgoto L_00F6;\n\tgoto L_00F6;\n\tgoto L_00F6;\n\tgoto L_00F6;\n\tgoto L_00F6;\n\tgoto L_00F6;\n\tgoto L_00F6;\n\tgoto L_00F6;\nL_00F6:\n\tX20 = X0;\n\tC = X1 < 1;\n\tC = ~C;\n\tTEMP1 = X1 - 1;\n\tN = TEMP1 < 0;\n\tTEMP2 = X1 ^ 1;\n\tTEMP3 = X1 ^ TEMP1;\n\tTEMP4 = TEMP2 & TEMP3;\n\tV = TEMP4 < 0;\n\tTEMPCOND = ~Z;\n\tif (TEMPCOND) goto L_012D;\n\tX0 = X20;\n\tX0 = 0x274A080(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX20 = X0;\n\tX0 = X0 + 0x108;\n\tX0 = 0xF3F22C(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX8 = *([X20]);\n\tX1 = *([X8]);\n\tX0 = 0xF3F978(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tif (TEMP) goto L_0122;\n\tX20 = *([X20]);\n\tX8 = stack[30];\n\tX9 = &stack[28];\n\t*([X9+X8*8]) = X20;\n\tX0 = 0x274A098(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX8 = 0xFFFFFFFE;\n\t*([X19]) = X8;\n\tX19 = X19 + 8;\n\tX0 = X0 + 0xCA0;\n\tX0 = 0xF3F22C(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX8 = *([X0+E0]);\n\tTEMP = ~TEMP;\n\tif (TEMP) goto L_011D;\n\tX0 = 0xF3F368(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\nL_011D:\n\tX0 = X19;\n\tX1 = X20;\n\tX2 = 0;\n\tSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetException(X0, X1, X2);\n\tgoto L_00E4;\nL_0122:\n\tX0 = 8;\n\tX0 = 0x274A068(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX8 = *([X20]);\n\t*([X0]) = X8;\n\tX1 = X1 + 0x398;\n\tX2 = 0;\n\tX0 = 0x274A0EC(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tgoto L_003D;\n\tX20 = X0;\n\tX0 = 0x274A098(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\nL_012D:\n\tX0 = X20;\n\tX0 = 0x27498DC(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX0 = 0xD6F8(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\treturn;\n// 139 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
			private unsafe void MoveNext()
			{
				//IL_03b0: Expected O, but got Ref
				//IL_0114: Expected O, but got F4
				//IL_0121: Expected O, but got F4
				//IL_0332: Expected O, but got Ref
				global::BFS.Essential.TweenCore.DoColor doColor = _003C_003E4__this;
				float num = default(float);
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E4__this != null)
					{
						doColor.m_Run = true;
						_003Clerp_003E5__2 = 0f;
						num = 0f;
						goto IL_008d;
					}
					global::System.NullReferenceException ex = new global::System.NullReferenceException();
					goto IL_040a;
				}
				_003C_003Eu__1 = default(global::System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter);
				_003C_003E1__state = -1;
				global::System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter awaiter = _003C_003Eu__1;
				goto IL_0295;
				IL_0295:
				awaiter.GetResult();
				num = _003Clerp_003E5__2;
				if (!(_003Clerp_003E5__2 < 1f))
				{
					if (_003C_003E4__this != null)
					{
						_003C_003E4__this.Kill(playOnComplete: true);
						goto IL_039a;
					}
					global::System.NullReferenceException ex2 = new global::System.NullReferenceException();
				}
				goto IL_040a;
				IL_008d:
				if (doColor.m_Run)
				{
					float deltaTime = global::UnityEngine.Time.deltaTime;
					float num2 = deltaTime / duration;
					float num3 = num + num2;
					float num7 = (_003Clerp_003E5__2 = global::UnityEngine.Mathf.Clamp01(num3));
					global::System.Action<global::UnityEngine.Color> action = callback;
					if (callback != null)
					{
						global::System.Func<float, float> interpolator = doColor.m_Interpolator;
						if (doColor.m_Interpolator == null)
						{
							global::System.NullReferenceException ex3 = new global::System.NullReferenceException();
							goto IL_040a;
						}
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v288.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
						float num8 = end.r - start.r;
						object obj3 = default(object);
						float num9 = num8 * (float)obj3;
						float num10 = start.r + num9;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v76.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
						object obj5 = default(object);
						object obj4 = obj5;
					}
					global::System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter awaiter2 = global::System.Threading.Tasks.Task.Yield().GetAwaiter();
					if (awaiter.IsCompleted)
					{
						goto IL_0295;
					}
					_003C_003E1__state = 0;
					_003C_003Eu__1 = _003C_003Eu__1;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_039a;
				IL_039a:
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetResult();
				return;
				IL_040a:
				while (_003C_003E4__this == null)
				{
					global::System.NullReferenceException ex4 = new global::System.NullReferenceException();
				}
				goto IL_008d;
			}

			void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60004E3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1028E48", Offset = "0x1028E48", Length = "0x6C")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_001B;\n\tv25 = CollectParticleData[];\n\tv26 = v25 + 0xCA0;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, stateMachine, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41);\n\tv44 = 1;\n\t*([302AB2B]) = v44;\nL_001B:\n\tgoto L_001D;\n\tv49 = \"il2cpp_codegen_runtime_class_init\"(v45, stateMachine, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41);\nL_001D:\n\tv51 = this + 8;\n\tSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetStateMachine(v51, stateMachine);\n\treturn;\n// 30 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
			private unsafe void SetStateMachine(global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
			{
				//IL_0010: Expected O, but got Ref
				_003C_003Et__builder.SetStateMachine(stateMachine);
			}

			void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[global::System.Runtime.CompilerServices.AsyncStateMachine(typeof(global::BFS.Essential.TweenCore.DoColor._003CValueTo_003Ed__0))]
		[global::Cpp2ILInjected.Token(Token = "0x60004DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x102897C", Offset = "0x102897C", Length = "0x164")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0033;\n\tv61 = Il2CppMethodInfo;\n\tv62 = v61 + 0x2A0;\n\tv63 = \"il2cpp_codegen_initialize_runtime_metadata\"(v62, callback, methodInfo, v65, v66, v67, v68, v69, start, v0, v2, v3, end, v4, v6, v7);\n\tv88 = CollectParticleData[];\n\tv89 = v88 + 0xCA0;\n\tv71 = \"il2cpp_codegen_initialize_runtime_metadata\"(v89, callback, methodInfo, v65, v66, v67, v68, v69, start, v0, v2, v3, end, v4, v6, v7);\n\tv73 = 1;\n\t*([302AB29]) = v73;\nL_0033:\n\t;\n\tv82 = 0;\n\tgoto L_0044;\n\tv90 = \"il2cpp_codegen_runtime_class_init\"(v84, callback, methodInfo, v65, v66, v67, v68, v69, v77, v0, v2, v3, end, v4, v6, v7);\nL_0044:\n\tv95 = System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Create();\n\tv103 = &v82 @ stack_-E0_v1 (System.Int32) | 8;\n\tv110 = 0xF3F1B4(v103, 0, methodInfo, v65, v66, v67, v68, v69, v95.m_builder, start.g, start.b, start.a, end, end.g, end.b, end.a);\n\tv111 = &v82 @ stack_-E0_v1 (System.Int32) + 0x20;\n\tv114 = 0xF3F1B4(v111, this, methodInfo, v65, v66, v67, v68, v69, v95.m_builder, start.g, start.b, start.a, end, end.g, end.b, end.a);\n\tv125 = &v82 @ stack_-E0_v1 (System.Int32) + 0x30;\n\tv128 = 0xF3F1B4(v125, callback, methodInfo, v65, v66, v67, v68, v69, end.a, start.g, start.b, start.a, end, end.g, end.b, end.a);\n\tv130 = 0xFFFFFFFF;\n\tSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder::Start(v103, &v130 @ stack_-E0_v2 (BFS.Essential.TweenCore.DoColor+<ValueTo>d__0));\n\treturnVal1 = System.Runtime.CompilerServices.AsyncTaskMethodBuilder::get_Task(v103);\n\treturn returnVal1;\n// 105 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		internal unsafe global::System.Threading.Tasks.Task ValueTo(global::UnityEngine.Color start, global::UnityEngine.Color end, float duration, global::System.Action<global::UnityEngine.Color> callback)
		{
			//IL_003b: Expected O, but got I
			//IL_0054: Expected O, but got I
			//IL_0070: Expected O, but got I8
			global::BFS.Essential.TweenCore.DoColor._003CValueTo_003Ed__0 stateMachine = default(global::BFS.Essential.TweenCore.DoColor._003CValueTo_003Ed__0);
			stateMachine._003C_003Et__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			stateMachine._003C_003E4__this = this;
			stateMachine.start = start;
			stateMachine.end = end;
			stateMachine.duration = duration;
			stateMachine.callback = callback;
			stateMachine._003C_003E1__state = -1;
			stateMachine._003C_003Et__builder.Start(ref stateMachine);
			return stateMachine._003C_003Et__builder.Task;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60004E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1028094", Offset = "0x1028094", Length = "0x44")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv16 = &v17 @ stack_-10_v2;\n\tv24 = BFS.Essential.TweenCore.DoColor::ValueTo(this, start, end, *([v16 @ X29_v1+10]), callback);\n\tv29 = this + 0x20;\n\tthis.m_Task = v24;\n\tv30 = 0xF3F1B4(v29, v24, methodInfo, v31, v32, v33, v34, v35, start, start.g, start.b, start.a, end, end.g, end.b, end.a);\n\treturn this;\n// 24 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public global::BFS.Essential.Tween Play(global::UnityEngine.Color start, global::UnityEngine.Color end, float duration, global::System.Action<global::UnityEngine.Color> callback)
		{
			//IL_0026: Expected F4, but got I
			//IL_0036: Expected O, but got I
			object obj2 = default(object);
			object obj = obj2;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X29_v1+10]");
			global::System.Threading.Tasks.Task task = ValueTo(start, end, 0f, callback);
			m_Task = task;
			return this;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60004E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1028014", Offset = "0x1028014", Length = "0x80")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv16 = 0x302A000;\n\tv18 = System.Net.Configuration.SettingsSectionInternal;\n\tv20 = *([302AB45]) & 1;\n\tv21 = v20 == 0;\n\tif (v21) goto L_0022;\n\tv22 = *([v18 @ X21_v1 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+B38]);\n\tv24 = *([v22 @ X0_v10+E0]) == 0;\n\tif (v24) goto L_0031;\nL_001C:\n\tBFS.Essential.Tween::.ctor(this);\n\treturn;\nL_0022:\n\t*([v16 @ X20_v1+B45]) = 1;\n\tv44 = *([v18 @ X21_v1 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+B38]);\n\tv61 = *([v44 @ X0_v7+E0]) == 0;\n\tv46 = ~v61;\n\tif (v46) goto L_001C;\nL_0031:\n\tBFS.Essential.Tween::.ctor(this);\n\treturn;\n// 34 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public DoColor()
		{
			//IL_0009: Expected O, but got I4
			//IL_0017: Expected I, but got O
			//IL_009c: Expected O, but got I
			//IL_005a: Expected O, but got I
			// The original body was a runtime class-initialization guard (checking whether this
			// class's static metadata was already initialized) that, on every path, falls through
			// to calling the base constructor with no other observable effect.
		}
	}
}