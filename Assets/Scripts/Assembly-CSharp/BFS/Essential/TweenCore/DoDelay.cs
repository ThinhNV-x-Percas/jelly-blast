using System.Runtime.InteropServices;

namespace BFS.Essential.TweenCore
{
	[global::Cpp2ILInjected.Token(Token = "0x2000115")]
	public class DoDelay : global::BFS.Essential.Tween
	{
		[StructLayout((LayoutKind)3)]
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000116")]
		private struct _003CDelay_003Ed__0 : global::System.Runtime.CompilerServices.IAsyncStateMachine
		{
			[global::Cpp2ILInjected.Token(Token = "0x400056D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[global::Cpp2ILInjected.Token(Token = "0x400056E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder _003C_003Et__builder;

			[global::Cpp2ILInjected.Token(Token = "0x400056F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public global::BFS.Essential.TweenCore.DoDelay _003C_003E4__this;

			[global::Cpp2ILInjected.Token(Token = "0x4000570")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public float duration;

			[global::Cpp2ILInjected.Token(Token = "0x4000571")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public global::System.Action callback;

			[global::Cpp2ILInjected.Token(Token = "0x4000572")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			private float _003Clerp_003E5__2;

			[global::Cpp2ILInjected.Token(Token = "0x4000573")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
			private global::System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter _003C_003Eu__1;

			[global::Cpp2ILInjected.Token(Token = "0x60004E7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1028FC8", Offset = "0x1028FC8", Length = "0x318")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_002A;\n\tv29 = Il2CppMethodInfo;\n\tv30 = v29 + 0x238;\n\tv31 = \"il2cpp_codegen_initialize_runtime_metadata\"(v30, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv62 = CollectParticleData[];\n\tv63 = v62 + 0xCA0;\n\tv64 = \"il2cpp_codegen_initialize_runtime_metadata\"(v63, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv69 = System.Net.Configuration.SettingsSectionInternal;\n\tv70 = v69 + 0x748;\n\tv71 = \"il2cpp_codegen_initialize_runtime_metadata\"(v70, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv133 = Sponge+<>c__DisplayClass7_0;\n\tv134 = v133 + 0x9D0;\n\tv48 = \"il2cpp_codegen_initialize_runtime_metadata\"(v134, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv50 = 1;\n\t*([302AB2D]) = v50;\nL_002A:\n\tv60 = this.<>4__this;\n\tv61 = this.<>1__state == 0;\n\tif (v61) goto L_0036;\n\tv65 = this.<>4__this == 0;\n\tif (v65) goto L_003A;\n\tv60.m_Run = 1;\n\tthis.<lerp>5__2 = 0f;\n\tgoto L_0041;\nL_0036:\n\tthis.<>u__1 = 0;\n\tthis.<>1__state = 0xFFFFFFFF;\n\tgoto L_0089;\nL_003A:\n\tv74 = new System.NullReferenceException();\n\tgoto L_003D;\n\tgoto L_00DF;\nL_003D:\n\t// 61 Interrupt\nL_003E:\n\tv173 = this.<>4__this == 0;\n\tif (v173) goto L_00D2;\nL_0041:\n\tv177 = ~v60.m_Run;\n\tif (v177) goto L_00AA;\n\tv183 = UnityEngine.Time::get_deltaTime();\n\tv256 = v183 / this.duration;\n\tv257 = v122 + v256;\n\tv261 = v257 - 1f;\n\tv262 = v261 < 0;\n\tv263 = v261 == 0;\n\tv264 = v257 ^ 1f;\n\tv265 = v257 ^ v261;\n\tv266 = v264 & v265;\n\tv267 = v266 < 0;\n\tv268 = v262 == v267;\n\tv86 = ~v263;\n\tv89 = v268 & v86;\n\tv269 = ~v89;\n\tif (v269) goto L_FFFFFFFF;\n\tgoto L_0065;\nL_0065:\n\tv83 = v257 >= 0;\n\tif (v83) goto L_FFFFFFFF;\n\tgoto L_006B;\nL_006B:\n\tthis.<lerp>5__2 = v118;\n\tgoto L_0073;\n\tv332 = \"il2cpp_codegen_runtime_class_init\"(v328, v136, v33, v34, v35, v36, v37, v38, v118, v116, v41, v42, v43, v44, v45, v46);\nL_0073:\n\tv335 = System.Threading.Tasks.Task::Yield();\n\tv338 = System.Runtime.CompilerServices.YieldAwaitable::GetAwaiter(&v335 @ X0_v26 (System.Runtime.CompilerServices.YieldAwaitable));\n\tgoto L_0081;\n\tv343 = \"il2cpp_codegen_runtime_class_init\"(v340, v337, v33, v34, v35, v36, v37, v38, v118, v116, v41, v42, v43, v44, v45, v46);\nL_0081:\n\tv124 = System.Runtime.CompilerServices.YieldAwaitable+YieldAwaiter::get_IsCompleted(&v119 @ stack_-51_v4 (System.Runtime.CompilerServices.YieldAwaitable+YieldAwaiter));\n\tv126 = v124 == 0;\n\tif (v126) goto L_00B6;\nL_0089:\n\tgoto L_008D;\n\tv178 = \"il2cpp_codegen_runtime_class_init\"(v129, v78, v33, v34, v35, v36, v37, v38, v117, v115, v41, v42, v43, v44, v45, v46);\nL_008D:\n\tSystem.Runtime.CompilerServices.YieldAwaitable+YieldAwaiter::GetResult(&v119 @ stack_-51_v4 (System.Runtime.CompilerServices.YieldAwaitable+YieldAwaiter));\n\tv122 = this.<lerp>5__2;\n\tv205 = this.<lerp>5__2 < 1f;\n\tif (v205) goto L_003E;\n\tv253 = this.callback;\n\tv275 = this.callback == 0;\n\tif (v275) goto L_00A1;\n\tv253.invoke_impl(this, v253.method_code, v253.method, v33, v34, v35, v36, v37, v38, 1f, v115, v41, v42, v43, v44, v45, v46);\nL_00A1:\n\tv219 = this.<>4__this == 0;\n\tif (v219) goto L_00D4;\n\tthis = BFS.Essential.Tween::Kill(this.<>4__this, 1);\nL_00AA:\n\tthis.<>1__state = 0xFFFFFFFE;\n\tv223 = this + 8;\n\tgoto L_00B4;\n\tv270 = \"il2cpp_codegen_runtime_class_init\"(v224, v188, v184, v34, v35, v36, v37, v38, v211, v210, v41, v42, v43, v44, v45, v46);\nL_00B4:\n\tSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetResult(v223);\n\tgoto L_00D1;\nL_00B6:\n\tthis.<>1__state = 0;\n\tthis.<>u__1 = this.<>u__1;\n\tgoto L_00BF;\n\tv351 = \"il2cpp_codegen_runtime_class_init\"(v348, v79, v33, v34, v35, v36, v37, v38, v118, v116, v41, v42, v43, v44, v45, v46);\nL_00BF:\n\tv309 = this + 8;\n\tSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted(v309, &v119 @ stack_-51_v4 (System.Runtime.CompilerServices.YieldAwaitable+YieldAwaiter), this);\nL_00D1:\n\treturn;\nL_00D2:\n\tv249 = new System.NullReferenceException();\n\tgoto L_003D;\nL_00D4:\n\tv250 = new System.NullReferenceException();\n\tgoto L_003D;\n\tgoto L_00DF;\n\tgoto L_00DF;\n\tgoto L_00DF;\n\tgoto L_00DF;\n\tgoto L_00DF;\n\tgoto L_00DF;\n\tgoto L_00DF;\n\tgoto L_00DF;\n\tgoto L_00DF;\nL_00DF:\n\tX20 = X0;\n\tC = X1 < 1;\n\tC = ~C;\n\tTEMP1 = X1 - 1;\n\tN = TEMP1 < 0;\n\tTEMP2 = X1 ^ 1;\n\tTEMP3 = X1 ^ TEMP1;\n\tTEMP4 = TEMP2 & TEMP3;\n\tV = TEMP4 < 0;\n\tTEMPCOND = ~Z;\n\tif (TEMPCOND) goto L_0116;\n\tX0 = X20;\n\tX0 = 0x274A080(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX20 = X0;\n\tX0 = X0 + 0x108;\n\tX0 = 0xF3F22C(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX8 = *([X20]);\n\tX1 = *([X8]);\n\tX0 = 0xF3F978(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tif (TEMP) goto L_010B;\n\tX20 = *([X20]);\n\tX8 = stack[10];\n\tX9 = &stack[8];\n\t*([X9+X8*8]) = X20;\n\tX0 = 0x274A098(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX8 = 0xFFFFFFFE;\n\t*([X19]) = X8;\n\tX19 = X19 + 8;\n\tX0 = X0 + 0xCA0;\n\tX0 = 0xF3F22C(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX8 = *([X0+E0]);\n\tTEMP = ~TEMP;\n\tif (TEMP) goto L_0106;\n\tX0 = 0xF3F368(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\nL_0106:\n\tX0 = X19;\n\tX1 = X20;\n\tX2 = 0;\n\tSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetException(X0, X1, X2);\n\tgoto L_00D1;\nL_010B:\n\tX0 = 8;\n\tX0 = 0x274A068(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX8 = *([X20]);\n\t*([X0]) = X8;\n\tX1 = X1 + 0x398;\n\tX2 = 0;\n\tX0 = 0x274A0EC(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tgoto L_003D;\n\tX20 = X0;\n\tX0 = 0x274A098(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\nL_0116:\n\tX0 = X20;\n\tX0 = 0x27498DC(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX0 = 0xD6F8(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\treturn;\n// 127 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
			private unsafe void MoveNext()
			{
				//IL_0329: Expected O, but got Ref
				//IL_0114: Expected O, but got F4
				//IL_0121: Expected O, but got F4
				//IL_02b9: Expected O, but got Ref
				global::BFS.Essential.TweenCore.DoDelay doDelay = _003C_003E4__this;
				float num = default(float);
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E4__this != null)
					{
						doDelay.m_Run = true;
						_003Clerp_003E5__2 = 0f;
						num = 0f;
						goto IL_008d;
					}
					global::System.NullReferenceException ex = new global::System.NullReferenceException();
					goto IL_035f;
				}
				_003C_003Eu__1 = default(global::System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter);
				_003C_003E1__state = -1;
				global::System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter awaiter = _003C_003Eu__1;
				goto IL_0203;
				IL_0203:
				awaiter.GetResult();
				num = _003Clerp_003E5__2;
				if (!(_003Clerp_003E5__2 < 1f))
				{
					global::System.Action action = callback;
					if (callback != null)
					{
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v253.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
					}
					if (_003C_003E4__this != null)
					{
						_003C_003E4__this.Kill(playOnComplete: true);
						goto IL_0313;
					}
					global::System.NullReferenceException ex2 = new global::System.NullReferenceException();
				}
				goto IL_035f;
				IL_008d:
				if (doDelay.m_Run)
				{
					float deltaTime = global::UnityEngine.Time.deltaTime;
					float num2 = deltaTime / duration;
					float num3 = num + num2;
					float num7 = (_003Clerp_003E5__2 = global::UnityEngine.Mathf.Clamp01(num3));
					global::System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter awaiter2 = global::System.Threading.Tasks.Task.Yield().GetAwaiter();
					if (awaiter.IsCompleted)
					{
						goto IL_0203;
					}
					_003C_003E1__state = 0;
					_003C_003Eu__1 = _003C_003Eu__1;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_0313;
				IL_035f:
				while (_003C_003E4__this == null)
				{
					global::System.NullReferenceException ex3 = new global::System.NullReferenceException();
				}
				goto IL_008d;
				IL_0313:
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetResult();
			}

			void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60004E8")]
			[global::Cpp2ILInjected.Address(RVA = "0x10292E0", Offset = "0x10292E0", Length = "0x6C")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_001B;\n\tv25 = CollectParticleData[];\n\tv26 = v25 + 0xCA0;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, stateMachine, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41);\n\tv44 = 1;\n\t*([302AB2E]) = v44;\nL_001B:\n\tgoto L_001D;\n\tv49 = \"il2cpp_codegen_runtime_class_init\"(v45, stateMachine, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41);\nL_001D:\n\tv51 = this + 8;\n\tSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetStateMachine(v51, stateMachine);\n\treturn;\n// 30 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
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

		[global::System.Runtime.CompilerServices.AsyncStateMachine(typeof(global::BFS.Essential.TweenCore.DoDelay._003CDelay_003Ed__0))]
		[global::Cpp2ILInjected.Token(Token = "0x60004E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1028EB4", Offset = "0x1028EB4", Length = "0x114")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_001F;\n\tv35 = Il2CppMethodInfo;\n\tv36 = v35 + 0x2A8;\n\tv37 = \"il2cpp_codegen_initialize_runtime_metadata\"(v36, callback, methodInfo, v39, v40, v41, v42, v43, duration, v44, v45, v46, v47, v48, v49, v50);\n\tv66 = CollectParticleData[];\n\tv67 = v66 + 0xCA0;\n\tv52 = \"il2cpp_codegen_initialize_runtime_metadata\"(v67, callback, methodInfo, v39, v40, v41, v42, v43, duration, v44, v45, v46, v47, v48, v49, v50);\n\tv54 = 1;\n\t*([302AB2C]) = v54;\nL_001F:\n\t;\n\tv60 = 0;\n\tgoto L_002E;\n\tv68 = \"il2cpp_codegen_runtime_class_init\"(v62, callback, methodInfo, v39, v40, v41, v42, v43, v57, v44, v45, v46, v47, v48, v49, v50);\nL_002E:\n\tv73 = System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Create();\n\tv81 = &v60 @ stack_-90_v1 (System.Int32) | 8;\n\tv88 = 0xF3F1B4(v81, 0, methodInfo, v39, v40, v41, v42, v43, v73.m_builder, v44, v45, v46, v47, v48, v49, v50);\n\tv89 = &v60 @ stack_-90_v1 (System.Int32) + 0x20;\n\tv92 = 0xF3F1B4(v89, this, methodInfo, v39, v40, v41, v42, v43, v73.m_builder, v44, v45, v46, v47, v48, v49, v50);\n\tv94 = &v60 @ stack_-90_v1 (System.Int32) + 0x30;\n\tv97 = 0xF3F1B4(v94, callback, methodInfo, v39, v40, v41, v42, v43, v73.m_builder, v44, v45, v46, v47, v48, v49, v50);\n\tv99 = 0xFFFFFFFF;\n\tSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder::Start(v81, &v99 @ stack_-90_v2 (BFS.Essential.TweenCore.DoDelay+<Delay>d__0));\n\treturnVal1 = System.Runtime.CompilerServices.AsyncTaskMethodBuilder::get_Task(v81);\n\treturn returnVal1;\n// 68 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		internal unsafe global::System.Threading.Tasks.Task Delay(float duration, global::System.Action callback)
		{
			//IL_003b: Expected O, but got I
			//IL_0054: Expected O, but got I
			//IL_0070: Expected O, but got I8
			global::BFS.Essential.TweenCore.DoDelay._003CDelay_003Ed__0 stateMachine = default(global::BFS.Essential.TweenCore.DoDelay._003CDelay_003Ed__0);
			stateMachine._003C_003Et__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			stateMachine._003C_003E4__this = this;
			stateMachine.duration = duration;
			stateMachine.callback = callback;
			stateMachine._003C_003E1__state = -1;
			stateMachine._003C_003Et__builder.Start(ref stateMachine);
			return stateMachine._003C_003Et__builder.Task;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60004E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1027E98", Offset = "0x1027E98", Length = "0x34")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv12 = BFS.Essential.TweenCore.DoDelay::Delay(this, duration, callback);\n\tv18 = this + 0x20;\n\tthis.m_Task = v12;\n\tv19 = 0xF3F1B4(v18, v12, methodInfo, v20, v21, v22, v23, v24, duration, v25, v26, v27, v28, v29, v30, v31);\n\treturn this;\n// 15 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public global::BFS.Essential.Tween Play(float duration, global::System.Action callback)
		{
			//IL_001e: Expected O, but got I
			global::System.Threading.Tasks.Task task = Delay(duration, callback);
			m_Task = task;
			return this;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60004E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1027E18", Offset = "0x1027E18", Length = "0x80")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv16 = 0x302A000;\n\tv18 = System.Net.Configuration.SettingsSectionInternal;\n\tv20 = *([302AB46]) & 1;\n\tv21 = v20 == 0;\n\tif (v21) goto L_0022;\n\tv22 = *([v18 @ X21_v1 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+B38]);\n\tv24 = *([v22 @ X0_v10+E0]) == 0;\n\tif (v24) goto L_0031;\nL_001C:\n\tBFS.Essential.Tween::.ctor(this);\n\treturn;\nL_0022:\n\t*([v16 @ X20_v1+B46]) = 1;\n\tv44 = *([v18 @ X21_v1 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+B38]);\n\tv61 = *([v44 @ X0_v7+E0]) == 0;\n\tv46 = ~v61;\n\tif (v46) goto L_001C;\nL_0031:\n\tBFS.Essential.Tween::.ctor(this);\n\treturn;\n// 34 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public DoDelay()
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