using System.Runtime.InteropServices;

namespace BFS.Essential.TweenCore
{
	[global::Cpp2ILInjected.Token(Token = "0x2000117")]
	public class DoFloat : global::BFS.Essential.Tween
	{
		[StructLayout((LayoutKind)3)]
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000118")]
		private struct _003CValueTo_003Ed__0 : global::System.Runtime.CompilerServices.IAsyncStateMachine
		{
			[global::Cpp2ILInjected.Token(Token = "0x4000574")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[global::Cpp2ILInjected.Token(Token = "0x4000575")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder _003C_003Et__builder;

			[global::Cpp2ILInjected.Token(Token = "0x4000576")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public global::BFS.Essential.TweenCore.DoFloat _003C_003E4__this;

			[global::Cpp2ILInjected.Token(Token = "0x4000577")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public float duration;

			[global::Cpp2ILInjected.Token(Token = "0x4000578")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public global::System.Action<float> callback;

			[global::Cpp2ILInjected.Token(Token = "0x4000579")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public float start;

			[global::Cpp2ILInjected.Token(Token = "0x400057A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
			public float end;

			[global::Cpp2ILInjected.Token(Token = "0x400057B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private float _003Clerp_003E5__2;

			[global::Cpp2ILInjected.Token(Token = "0x400057C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
			private global::System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter _003C_003Eu__1;

			[global::Cpp2ILInjected.Token(Token = "0x60004EC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1029478", Offset = "0x1029478", Length = "0x350")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_002A;\n\tv29 = Il2CppMethodInfo;\n\tv30 = v29 + 0x240;\n\tv31 = \"il2cpp_codegen_initialize_runtime_metadata\"(v30, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv62 = CollectParticleData[];\n\tv63 = v62 + 0xCA0;\n\tv64 = \"il2cpp_codegen_initialize_runtime_metadata\"(v63, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv69 = System.Net.Configuration.SettingsSectionInternal;\n\tv70 = v69 + 0x748;\n\tv71 = \"il2cpp_codegen_initialize_runtime_metadata\"(v70, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv137 = Sponge+<>c__DisplayClass7_0;\n\tv138 = v137 + 0x9D0;\n\tv48 = \"il2cpp_codegen_initialize_runtime_metadata\"(v138, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv50 = 1;\n\t*([302AB30]) = v50;\nL_002A:\n\tv60 = this.<>4__this;\n\tv61 = this.<>1__state == 0;\n\tif (v61) goto L_0036;\n\tv65 = this.<>4__this == 0;\n\tif (v65) goto L_003A;\n\tv60.m_Run = 1;\n\tthis.<lerp>5__2 = 0f;\n\tgoto L_0041;\nL_0036:\n\tthis.<>u__1 = 0;\n\tthis.<>1__state = 0xFFFFFFFF;\n\tgoto L_009C;\nL_003A:\n\tv74 = new System.NullReferenceException();\n\tgoto L_003D;\n\tgoto L_00EF;\nL_003D:\n\t// 61 Interrupt\nL_003E:\n\tv183 = this.<>4__this == 0;\n\tif (v183) goto L_00DE;\nL_0041:\n\tv187 = ~v60.m_Run;\n\tif (v187) goto L_00B6;\n\tv193 = UnityEngine.Time::get_deltaTime();\n\tv272 = v193 / this.duration;\n\tv273 = v178 + v272;\n\tv277 = v273 - 1f;\n\tv278 = v277 < 0;\n\tv279 = v277 == 0;\n\tv280 = v273 ^ 1f;\n\tv281 = v273 ^ v277;\n\tv282 = v280 & v281;\n\tv283 = v282 < 0;\n\tv284 = v278 == v283;\n\tv90 = ~v279;\n\tv93 = v284 & v90;\n\tv285 = ~v93;\n\tif (v285) goto L_FFFFFFFF;\n\tgoto L_0065;\nL_0065:\n\tv87 = v273 >= 0;\n\tif (v87) goto L_FFFFFFFF;\n\tgoto L_006B;\nL_006B:\n\tthis.<lerp>5__2 = v259;\n\tv76 = this.callback;\n\tv340 = this.callback == 0;\n\tif (v340) goto L_0083;\n\tv269 = v60.m_Interpolator;\n\tv267 = v60.m_Interpolator == 0;\n\tif (v267) goto L_00E0;\n\tv269.invoke_impl(this, v269.method_code, v269.method, v33, v34, v35, v36, v37, v38, v259, v257, v41, v42, v43, v44, v45, v46);\n\tv345 = this.end - this.start;\n\tv360 = v345 * v259;\n\tv346 = this.start + v360;\n\tv76.invoke_impl(this, v76.method_code, v76.method, v33, v34, v35, v36, v37, v38, v346, v345, v41, v42, v43, v44, v45, v46);\nL_0083:\n\tgoto L_0086;\n\tv362 = \"il2cpp_codegen_runtime_class_init\"(v353, v341, v33, v34, v35, v36, v37, v38, v122, v120, v41, v42, v43, v44, v45, v46);\nL_0086:\n\tv365 = System.Threading.Tasks.Task::Yield();\n\tv368 = System.Runtime.CompilerServices.YieldAwaitable::GetAwaiter(&v365 @ X0_v24 (System.Runtime.CompilerServices.YieldAwaitable));\n\tgoto L_0094;\n\tv373 = \"il2cpp_codegen_runtime_class_init\"(v370, v367, v33, v34, v35, v36, v37, v38, v122, v120, v41, v42, v43, v44, v45, v46);\nL_0094:\n\tv128 = System.Runtime.CompilerServices.YieldAwaitable+YieldAwaiter::get_IsCompleted(&v123 @ stack_-51_v4 (System.Runtime.CompilerServices.YieldAwaitable+YieldAwaiter));\n\tv130 = v128 == 0;\n\tif (v130) goto L_00C2;\nL_009C:\n\tgoto L_00A0;\n\tv188 = \"il2cpp_codegen_runtime_class_init\"(v133, v79, v33, v34, v35, v36, v37, v38, v121, v119, v41, v42, v43, v44, v45, v46);\nL_00A0:\n\tSystem.Runtime.CompilerServices.YieldAwaitable+YieldAwaiter::GetResult(&v123 @ stack_-51_v4 (System.Runtime.CompilerServices.YieldAwaitable+YieldAwaiter));\n\tv178 = this.<lerp>5__2;\n\tv217 = this.<lerp>5__2 < 1f;\n\tif (v217) goto L_003E;\n\tv231 = this.<>4__this == 0;\n\tif (v231) goto L_00E2;\n\tthis = BFS.Essential.Tween::Kill(this.<>4__this, 1);\nL_00B6:\n\tthis.<>1__state = 0xFFFFFFFE;\n\tv235 = this + 8;\n\tgoto L_00C0;\n\tv286 = \"il2cpp_codegen_runtime_class_init\"(v236, v198, v195, v34, v35, v36, v37, v38, v223, v222, v41, v42, v43, v44, v45, v46);\nL_00C0:\n\tSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetResult(v235);\n\tgoto L_00DD;\nL_00C2:\n\tthis.<>1__state = 0;\n\tthis.<>u__1 = this.<>u__1;\n\tgoto L_00CB;\n\tv381 = \"il2cpp_codegen_runtime_class_init\"(v378, v80, v33, v34, v35, v36, v37, v38, v122, v120, v41, v42, v43, v44, v45, v46);\nL_00CB:\n\tv322 = this + 8;\n\tSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted(v322, &v123 @ stack_-51_v4 (System.Runtime.CompilerServices.YieldAwaitable+YieldAwaiter), this);\nL_00DD:\n\treturn;\nL_00DE:\n\tv263 = new System.NullReferenceException();\n\tgoto L_003D;\nL_00E0:\n\tv264 = new System.NullReferenceException();\n\tgoto L_003D;\nL_00E2:\n\tv265 = new System.NullReferenceException();\n\tgoto L_003D;\n\tgoto L_00EF;\n\tgoto L_00EF;\n\tgoto L_00EF;\n\tgoto L_00EF;\n\tgoto L_00EF;\n\tgoto L_00EF;\n\tgoto L_00EF;\n\tgoto L_00EF;\n\tgoto L_00EF;\n\tgoto L_00EF;\n\tgoto L_00EF;\nL_00EF:\n\tX20 = X0;\n\tC = X1 < 1;\n\tC = ~C;\n\tTEMP1 = X1 - 1;\n\tN = TEMP1 < 0;\n\tTEMP2 = X1 ^ 1;\n\tTEMP3 = X1 ^ TEMP1;\n\tTEMP4 = TEMP2 & TEMP3;\n\tV = TEMP4 < 0;\n\tTEMPCOND = ~Z;\n\tif (TEMPCOND) goto L_0126;\n\tX0 = X20;\n\tX0 = 0x274A080(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX20 = X0;\n\tX0 = X0 + 0x108;\n\tX0 = 0xF3F22C(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX8 = *([X20]);\n\tX1 = *([X8]);\n\tX0 = 0xF3F978(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tif (TEMP) goto L_011B;\n\tX20 = *([X20]);\n\tX8 = stack[10];\n\tX9 = &stack[8];\n\t*([X9+X8*8]) = X20;\n\tX0 = 0x274A098(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX8 = 0xFFFFFFFE;\n\t*([X19]) = X8;\n\tX19 = X19 + 8;\n\tX0 = X0 + 0xCA0;\n\tX0 = 0xF3F22C(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX8 = *([X0+E0]);\n\tTEMP = ~TEMP;\n\tif (TEMP) goto L_0116;\n\tX0 = 0xF3F368(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\nL_0116:\n\tX0 = X19;\n\tX1 = X20;\n\tX2 = 0;\n\tSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetException(X0, X1, X2);\n\tgoto L_00DD;\nL_011B:\n\tX0 = 8;\n\tX0 = 0x274A068(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX8 = *([X20]);\n\t*([X0]) = X8;\n\tX1 = X1 + 0x398;\n\tX2 = 0;\n\tX0 = 0x274A0EC(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tgoto L_003D;\n\tX20 = X0;\n\tX0 = 0x274A098(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\nL_0126:\n\tX0 = X20;\n\tX0 = 0x27498DC(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX0 = 0xD6F8(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\treturn;\n// 132 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
			private unsafe void MoveNext()
			{
				//IL_0399: Expected O, but got Ref
				//IL_0114: Expected O, but got F4
				//IL_0121: Expected O, but got F4
				//IL_031b: Expected O, but got Ref
				global::BFS.Essential.TweenCore.DoFloat doFloat = _003C_003E4__this;
				float num = default(float);
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E4__this != null)
					{
						doFloat.m_Run = true;
						_003Clerp_003E5__2 = 0f;
						num = 0f;
						goto IL_008d;
					}
					global::System.NullReferenceException ex = new global::System.NullReferenceException();
					goto IL_03f3;
				}
				_003C_003Eu__1 = default(global::System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter);
				_003C_003E1__state = -1;
				global::System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter awaiter = _003C_003Eu__1;
				goto IL_027e;
				IL_027e:
				awaiter.GetResult();
				num = _003Clerp_003E5__2;
				if (!(_003Clerp_003E5__2 < 1f))
				{
					if (_003C_003E4__this != null)
					{
						_003C_003E4__this.Kill(playOnComplete: true);
						goto IL_0383;
					}
					global::System.NullReferenceException ex2 = new global::System.NullReferenceException();
				}
				goto IL_03f3;
				IL_008d:
				if (doFloat.m_Run)
				{
					float deltaTime = global::UnityEngine.Time.deltaTime;
					float num2 = deltaTime / duration;
					float num3 = num + num2;
					float num7 = (_003Clerp_003E5__2 = global::UnityEngine.Mathf.Clamp01(num3));
					global::System.Action<float> action = callback;
					if (callback != null)
					{
						global::System.Func<float, float> interpolator = doFloat.m_Interpolator;
						if (doFloat.m_Interpolator == null)
						{
							global::System.NullReferenceException ex3 = new global::System.NullReferenceException();
							goto IL_03f3;
						}
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v269.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
						float num8 = end - start;
						float num9 = num8 * num7;
						float num10 = start + num9;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v76.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
					}
					global::System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter awaiter2 = global::System.Threading.Tasks.Task.Yield().GetAwaiter();
					if (awaiter.IsCompleted)
					{
						goto IL_027e;
					}
					_003C_003E1__state = 0;
					_003C_003Eu__1 = _003C_003Eu__1;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_0383;
				IL_0383:
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetResult();
				return;
				IL_03f3:
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
			[global::Cpp2ILInjected.Token(Token = "0x60004ED")]
			[global::Cpp2ILInjected.Address(RVA = "0x10297C8", Offset = "0x10297C8", Length = "0x6C")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_001B;\n\tv25 = CollectParticleData[];\n\tv26 = v25 + 0xCA0;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, stateMachine, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41);\n\tv44 = 1;\n\t*([302AB31]) = v44;\nL_001B:\n\tgoto L_001D;\n\tv49 = \"il2cpp_codegen_runtime_class_init\"(v45, stateMachine, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41);\nL_001D:\n\tv51 = this + 8;\n\tSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetStateMachine(v51, stateMachine);\n\treturn;\n// 30 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
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

		[global::System.Runtime.CompilerServices.AsyncStateMachine(typeof(global::BFS.Essential.TweenCore.DoFloat._003CValueTo_003Ed__0))]
		[global::Cpp2ILInjected.Token(Token = "0x60004E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x102934C", Offset = "0x102934C", Length = "0x12C")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0023;\n\tv43 = Il2CppMethodInfo;\n\tv44 = v43 + 0x2B0;\n\tv45 = \"il2cpp_codegen_initialize_runtime_metadata\"(v44, callback, methodInfo, v47, v48, v49, v50, v51, start, end, duration, v52, v53, v54, v55, v56);\n\tv73 = CollectParticleData[];\n\tv74 = v73 + 0xCA0;\n\tv58 = \"il2cpp_codegen_initialize_runtime_metadata\"(v74, callback, methodInfo, v47, v48, v49, v50, v51, start, end, duration, v52, v53, v54, v55, v56);\n\tv60 = 1;\n\t*([302AB2F]) = v60;\nL_0023:\n\t;\n\tv67 = 0;\n\tgoto L_0033;\n\tv75 = \"il2cpp_codegen_runtime_class_init\"(v69, callback, methodInfo, v47, v48, v49, v50, v51, v64, end, duration, v52, v53, v54, v55, v56);\nL_0033:\n\tv80 = System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Create();\n\tv88 = &v67 @ stack_-B0_v1 (System.Int32) | 8;\n\tv95 = 0xF3F1B4(v88, 0, methodInfo, v47, v48, v49, v50, v51, v80.m_builder, end, duration, v52, v53, v54, v55, v56);\n\tv96 = &v67 @ stack_-B0_v1 (System.Int32) + 0x20;\n\tv99 = 0xF3F1B4(v96, this, methodInfo, v47, v48, v49, v50, v51, v80.m_builder, end, duration, v52, v53, v54, v55, v56);\n\tv103 = &v67 @ stack_-B0_v1 (System.Int32) + 0x30;\n\tv106 = 0xF3F1B4(v103, callback, methodInfo, v47, v48, v49, v50, v51, v80.m_builder, end, duration, v52, v53, v54, v55, v56);\n\tv108 = 0xFFFFFFFF;\n\tSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder::Start(v88, &v108 @ stack_-B0_v2 (BFS.Essential.TweenCore.DoFloat+<ValueTo>d__0));\n\treturnVal1 = System.Runtime.CompilerServices.AsyncTaskMethodBuilder::get_Task(v88);\n\treturn returnVal1;\n// 77 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		internal unsafe global::System.Threading.Tasks.Task ValueTo(float start, float end, float duration, global::System.Action<float> callback)
		{
			//IL_003b: Expected O, but got I
			//IL_0054: Expected O, but got I
			//IL_0070: Expected O, but got I8
			global::BFS.Essential.TweenCore.DoFloat._003CValueTo_003Ed__0 stateMachine = default(global::BFS.Essential.TweenCore.DoFloat._003CValueTo_003Ed__0);
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

		[global::Cpp2ILInjected.Token(Token = "0x60004EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1027CFC", Offset = "0x1027CFC", Length = "0x34")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv12 = BFS.Essential.TweenCore.DoFloat::ValueTo(this, start, end, duration, callback);\n\tv20 = this + 0x20;\n\tthis.m_Task = v12;\n\tv21 = 0xF3F1B4(v20, v12, methodInfo, v22, v23, v24, v25, v26, start, end, duration, v27, v28, v29, v30, v31);\n\treturn this;\n// 15 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public global::BFS.Essential.Tween Play(float start, float end, float duration, global::System.Action<float> callback)
		{
			//IL_0026: Expected O, but got I
			global::System.Threading.Tasks.Task task = ValueTo(start, end, duration, callback);
			m_Task = task;
			return this;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60004EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1027C7C", Offset = "0x1027C7C", Length = "0x80")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv16 = 0x302A000;\n\tv18 = System.Net.Configuration.SettingsSectionInternal;\n\tv20 = T & 1;\n\tv21 = v20 == 0;\n\tif (v21) goto L_0022;\n\tv22 = *([v18 @ X21_v1 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+B38]);\n\tv24 = *([v22 @ X0_v10+E0]) == 0;\n\tif (v24) goto L_0031;\nL_001C:\n\tBFS.Essential.Tween::.ctor(this);\n\treturn;\nL_0022:\n\t*([v16 @ X20_v1+B47]) = 1;\n\tv44 = *([v18 @ X21_v1 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+B38]);\n\tv61 = *([v44 @ X0_v7+E0]) == 0;\n\tv46 = ~v61;\n\tif (v46) goto L_001C;\nL_0031:\n\tBFS.Essential.Tween::.ctor(this);\n\treturn;\n// 34 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public DoFloat()
		{
			//IL_0009: Expected O, but got I4
			//IL_0017: Expected I, but got O
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected I4, but got Unknown
			//IL_009a: Expected O, but got I
			//IL_0058: Expected O, but got I
			// The original body was a runtime class-initialization guard (checking whether this
			// class's static metadata was already initialized) that, on every path, falls through
			// to calling the base constructor with no other observable effect.
		}
	}
}