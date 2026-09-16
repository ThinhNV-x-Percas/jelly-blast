using System.Runtime.InteropServices;

namespace BFS.Essential.TweenCore
{
	[global::Cpp2ILInjected.Token(Token = "0x2000119")]
	public class DoVector : global::BFS.Essential.Tween
	{
		[StructLayout((LayoutKind)3)]
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200011A")]
		private struct _003CValueTo_003Ed__0 : global::System.Runtime.CompilerServices.IAsyncStateMachine
		{
			[global::Cpp2ILInjected.Token(Token = "0x400057D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[global::Cpp2ILInjected.Token(Token = "0x400057E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder _003C_003Et__builder;

			[global::Cpp2ILInjected.Token(Token = "0x400057F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public global::BFS.Essential.TweenCore.DoVector _003C_003E4__this;

			[global::Cpp2ILInjected.Token(Token = "0x4000580")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public float duration;

			[global::Cpp2ILInjected.Token(Token = "0x4000581")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public global::System.Action<global::UnityEngine.Vector3> callback;

			[global::Cpp2ILInjected.Token(Token = "0x4000582")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public global::UnityEngine.Vector3 start;

			[global::Cpp2ILInjected.Token(Token = "0x4000583")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
			public global::UnityEngine.Vector3 end;

			[global::Cpp2ILInjected.Token(Token = "0x4000584")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			private float _003Clerp_003E5__2;

			[global::Cpp2ILInjected.Token(Token = "0x4000585")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
			private global::System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter _003C_003Eu__1;

			[global::Cpp2ILInjected.Token(Token = "0x60004F1")]
			[global::Cpp2ILInjected.Address(RVA = "0x102998C", Offset = "0x102998C", Length = "0x378")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_002C;\n\tv33 = Il2CppMethodInfo;\n\tv34 = v33 + 0x250;\n\tv35 = \"il2cpp_codegen_initialize_runtime_metadata\"(v34, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv66 = CollectParticleData[];\n\tv67 = v66 + 0xCA0;\n\tv68 = \"il2cpp_codegen_initialize_runtime_metadata\"(v67, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv73 = System.Net.Configuration.SettingsSectionInternal;\n\tv74 = v73 + 0x748;\n\tv75 = \"il2cpp_codegen_initialize_runtime_metadata\"(v74, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv149 = Sponge+<>c__DisplayClass7_0;\n\tv150 = v149 + 0x9D0;\n\tv52 = \"il2cpp_codegen_initialize_runtime_metadata\"(v150, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv54 = 1;\n\t*([302AB33]) = v54;\nL_002C:\n\tv64 = this.<>4__this;\n\tv65 = this.<>1__state == 0;\n\tif (v65) goto L_0038;\n\tv69 = this.<>4__this == 0;\n\tif (v69) goto L_003C;\n\tv64.m_Run = 1;\n\tthis.<lerp>5__2 = 0f;\n\tgoto L_0043;\nL_0038:\n\tthis.<>u__1 = 0;\n\tthis.<>1__state = 0xFFFFFFFF;\n\tgoto L_00A5;\nL_003C:\n\tv78 = new System.NullReferenceException();\n\tgoto L_003F;\n\tgoto L_00FA;\nL_003F:\n\t// 63 Interrupt\nL_0040:\n\tv203 = this.<>4__this == 0;\n\tif (v203) goto L_00E9;\nL_0043:\n\tv207 = ~v64.m_Run;\n\tif (v207) goto L_00BF;\n\tv213 = UnityEngine.Time::get_deltaTime();\n\tv300 = v213 / this.duration;\n\tv301 = v198 + v300;\n\tv305 = v301 - 1f;\n\tv306 = v305 < 0;\n\tv307 = v305 == 0;\n\tv308 = v301 ^ 1f;\n\tv309 = v301 ^ v305;\n\tv310 = v308 & v309;\n\tv311 = v310 < 0;\n\tv312 = v306 == v311;\n\tv102 = ~v307;\n\tv105 = v312 & v102;\n\tv313 = ~v105;\n\tif (v313) goto L_FFFFFFFF;\n\tgoto L_0067;\nL_0067:\n\tv99 = v301 >= 0;\n\tif (v99) goto L_FFFFFFFF;\n\tgoto L_006D;\nL_006D:\n\tthis.<lerp>5__2 = v287;\n\tv80 = this.callback;\n\tv374 = this.callback == 0;\n\tif (v374) goto L_008C;\n\tv297 = v64.m_Interpolator;\n\tv295 = v64.m_Interpolator == 0;\n\tif (v295) goto L_00EB;\n\tv297.invoke_impl(this, v297.method_code, v297.method, v37, v38, v39, v40, v41, v42, v287, v285, v84, v86, v47, v48, v49, v50);\n\tv398 = this.end - this.start;\n\tv399 = v398 * v400;\n\tv86 = this.start + v399;\n\tv401 = *([this @ X0 (BFS.Essential.TweenCore.DoVector+<ValueTo>d__0)+4C]) - *([this @ X0 (BFS.Essential.TweenCore.DoVector+<ValueTo>d__0)+40]);\n\tv402 = v401 * v287;\n\tv84 = *([this @ X0 (BFS.Essential.TweenCore.DoVector+<ValueTo>d__0)+40]) + v402;\n\tv80.invoke_impl(this, v80.method_code, v80.method, v37, v38, v39, v40, v41, v42, v86, v403, v84, v86, v47, v48, v49, v50);\nL_008C:\n\tgoto L_008F;\n\tv405 = \"il2cpp_codegen_runtime_class_init\"(v391, v377, v37, v38, v39, v40, v41, v42, v134, v132, v84, v86, v47, v48, v49, v50);\nL_008F:\n\tv408 = System.Threading.Tasks.Task::Yield();\n\tv411 = System.Runtime.CompilerServices.YieldAwaitable::GetAwaiter(&v408 @ X0_v24 (System.Runtime.CompilerServices.YieldAwaitable));\n\tgoto L_009D;\n\tv416 = \"il2cpp_codegen_runtime_class_init\"(v413, v410, v37, v38, v39, v40, v41, v42, v134, v132, v84, v86, v47, v48, v49, v50);\nL_009D:\n\tv140 = System.Runtime.CompilerServices.YieldAwaitable+YieldAwaiter::get_IsCompleted(&v135 @ stack_-61_v4 (System.Runtime.CompilerServices.YieldAwaitable+YieldAwaiter));\n\tv142 = v140 == 0;\n\tif (v142) goto L_00CB;\nL_00A5:\n\tgoto L_00A9;\n\tv208 = \"il2cpp_codegen_runtime_class_init\"(v145, v87, v37, v38, v39, v40, v41, v42, v133, v131, v83, v85, v47, v48, v49, v50);\nL_00A9:\n\tSystem.Runtime.CompilerServices.YieldAwaitable+YieldAwaiter::GetResult(&v135 @ stack_-61_v4 (System.Runtime.CompilerServices.YieldAwaitable+YieldAwaiter));\n\tv198 = this.<lerp>5__2;\n\tv241 = this.<lerp>5__2 < 1f;\n\tif (v241) goto L_0040;\n\tv255 = this.<>4__this == 0;\n\tif (v255) goto L_00ED;\n\tthis = BFS.Essential.Tween::Kill(this.<>4__this, 1);\nL_00BF:\n\tthis.<>1__state = 0xFFFFFFFE;\n\tv259 = this + 8;\n\tgoto L_00C9;\n\tv314 = \"il2cpp_codegen_runtime_class_init\"(v260, v220, v215, v38, v39, v40, v41, v42, v247, v246, v218, v219, v47, v48, v49, v50);\nL_00C9:\n\tSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetResult(v259);\n\tgoto L_00E8;\nL_00CB:\n\tthis.<>1__state = 0;\n\tthis.<>u__1 = this.<>u__1;\n\tgoto L_00D4;\n\tv424 = \"il2cpp_codegen_runtime_class_init\"(v421, v88, v37, v38, v39, v40, v41, v42, v134, v132, v84, v86, v47, v48, v49, v50);\nL_00D4:\n\tv354 = this + 8;\n\tSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted(v354, &v135 @ stack_-61_v4 (System.Runtime.CompilerServices.YieldAwaitable+YieldAwaiter), this);\nL_00E8:\n\treturn;\nL_00E9:\n\tv291 = new System.NullReferenceException();\n\tgoto L_003F;\nL_00EB:\n\tv292 = new System.NullReferenceException();\n\tgoto L_003F;\nL_00ED:\n\tv293 = new System.NullReferenceException();\n\tgoto L_003F;\n\tgoto L_00FA;\n\tgoto L_00FA;\n\tgoto L_00FA;\n\tgoto L_00FA;\n\tgoto L_00FA;\n\tgoto L_00FA;\n\tgoto L_00FA;\n\tgoto L_00FA;\n\tgoto L_00FA;\n\tgoto L_00FA;\n\tgoto L_00FA;\nL_00FA:\n\tX20 = X0;\n\tC = X1 < 1;\n\tC = ~C;\n\tTEMP1 = X1 - 1;\n\tN = TEMP1 < 0;\n\tTEMP2 = X1 ^ 1;\n\tTEMP3 = X1 ^ TEMP1;\n\tTEMP4 = TEMP2 & TEMP3;\n\tV = TEMP4 < 0;\n\tTEMPCOND = ~Z;\n\tif (TEMPCOND) goto L_0131;\n\tX0 = X20;\n\tX0 = 0x274A080(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX20 = X0;\n\tX0 = X0 + 0x108;\n\tX0 = 0xF3F22C(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX8 = *([X20]);\n\tX1 = *([X8]);\n\tX0 = 0xF3F978(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tif (TEMP) goto L_0126;\n\tX20 = *([X20]);\n\tX8 = stack[10];\n\tX9 = &stack[8];\n\t*([X9+X8*8]) = X20;\n\tX0 = 0x274A098(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX8 = 0xFFFFFFFE;\n\t*([X19]) = X8;\n\tX19 = X19 + 8;\n\tX0 = X0 + 0xCA0;\n\tX0 = 0xF3F22C(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX8 = *([X0+E0]);\n\tTEMP = ~TEMP;\n\tif (TEMP) goto L_0121;\n\tX0 = 0xF3F368(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\nL_0121:\n\tX0 = X19;\n\tX1 = X20;\n\tX2 = 0;\n\tSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetException(X0, X1, X2);\n\tgoto L_00E8;\nL_0126:\n\tX0 = 8;\n\tX0 = 0x274A068(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX8 = *([X20]);\n\t*([X0]) = X8;\n\tX1 = X1 + 0x398;\n\tX2 = 0;\n\tX0 = 0x274A0EC(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tgoto L_003F;\n\tX20 = X0;\n\tX0 = 0x274A098(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\nL_0131:\n\tX0 = X20;\n\tX0 = 0x27498DC(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX0 = 0xD6F8(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\treturn;\n// 140 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
			private unsafe void MoveNext()
			{
				//IL_03ed: Expected O, but got Ref
				//IL_0114: Expected O, but got F4
				//IL_0121: Expected O, but got F4
				//IL_024e: Expected O, but got I
				//IL_036f: Expected O, but got Ref
				global::BFS.Essential.TweenCore.DoVector doVector = _003C_003E4__this;
				float num = default(float);
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E4__this != null)
					{
						doVector.m_Run = true;
						_003Clerp_003E5__2 = 0f;
						num = 0f;
						goto IL_008d;
					}
					global::System.NullReferenceException ex = new global::System.NullReferenceException();
					goto IL_0447;
				}
				_003C_003Eu__1 = default(global::System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter);
				_003C_003E1__state = -1;
				global::System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter awaiter = _003C_003Eu__1;
				goto IL_02d2;
				IL_02d2:
				awaiter.GetResult();
				num = _003Clerp_003E5__2;
				if (!(_003Clerp_003E5__2 < 1f))
				{
					if (_003C_003E4__this != null)
					{
						_003C_003E4__this.Kill(playOnComplete: true);
						goto IL_03d7;
					}
					global::System.NullReferenceException ex2 = new global::System.NullReferenceException();
				}
				goto IL_0447;
				IL_008d:
				if (doVector.m_Run)
				{
					float deltaTime = global::UnityEngine.Time.deltaTime;
					float num2 = deltaTime / duration;
					float num3 = num + num2;
					float num7 = (_003Clerp_003E5__2 = global::UnityEngine.Mathf.Clamp01(num3));
					global::System.Action<global::UnityEngine.Vector3> action = callback;
					if (callback != null)
					{
						global::System.Func<float, float> interpolator = doVector.m_Interpolator;
						if (doVector.m_Interpolator == null)
						{
							global::System.NullReferenceException ex3 = new global::System.NullReferenceException();
							goto IL_0447;
						}
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v297.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
						float num8 = end.x - start.x;
						object obj3 = default(object);
						float num9 = num8 * (float)obj3;
						float num10 = start.x + num9;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BFS.Essential.TweenCore.DoVector+<ValueTo>d__0)+4C]");
						nint num11 = 0;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BFS.Essential.TweenCore.DoVector+<ValueTo>d__0)+40]");
						object obj4 = num11 - 0;
						float num12 = (float)obj4 * num7;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BFS.Essential.TweenCore.DoVector+<ValueTo>d__0)+40]");
						float num13 = 0f + num12;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v80.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
					}
					global::System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter awaiter2 = global::System.Threading.Tasks.Task.Yield().GetAwaiter();
					if (awaiter.IsCompleted)
					{
						goto IL_02d2;
					}
					_003C_003E1__state = 0;
					_003C_003Eu__1 = _003C_003Eu__1;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_03d7;
				IL_03d7:
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetResult();
				return;
				IL_0447:
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
			[global::Cpp2ILInjected.Token(Token = "0x60004F2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1029D04", Offset = "0x1029D04", Length = "0x6C")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_001B;\n\tv25 = CollectParticleData[];\n\tv26 = v25 + 0xCA0;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, stateMachine, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41);\n\tv44 = 1;\n\t*([302AB34]) = v44;\nL_001B:\n\tgoto L_001D;\n\tv49 = \"il2cpp_codegen_runtime_class_init\"(v45, stateMachine, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41);\nL_001D:\n\tv51 = this + 8;\n\tSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetStateMachine(v51, stateMachine);\n\treturn;\n// 30 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
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

		[global::System.Runtime.CompilerServices.AsyncStateMachine(typeof(global::BFS.Essential.TweenCore.DoVector._003CValueTo_003Ed__0))]
		[global::Cpp2ILInjected.Token(Token = "0x60004EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1029834", Offset = "0x1029834", Length = "0x158")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_002F;\n\tv59 = Il2CppMethodInfo;\n\tv60 = v59 + 0x2C0;\n\tv61 = \"il2cpp_codegen_initialize_runtime_metadata\"(v60, callback, methodInfo, v63, v64, v65, v66, v67, start, v0, v2, end, v3, v5, duration, v68);\n\tv86 = CollectParticleData[];\n\tv87 = v86 + 0xCA0;\n\tv70 = \"il2cpp_codegen_initialize_runtime_metadata\"(v87, callback, methodInfo, v63, v64, v65, v66, v67, start, v0, v2, end, v3, v5, duration, v68);\n\tv72 = 1;\n\t*([302AB32]) = v72;\nL_002F:\n\t;\n\tv81 = 0;\n\tgoto L_0040;\n\tv88 = \"il2cpp_codegen_runtime_class_init\"(v82, callback, methodInfo, v63, v64, v65, v66, v67, v76, v0, v2, end, v3, v5, duration, v68);\nL_0040:\n\tv93 = System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Create();\n\tv101 = &v81 @ stack_-E0_v1 (System.Int32) | 8;\n\tv108 = 0xF3F1B4(v101, 0, methodInfo, v63, v64, v65, v66, v67, v93.m_builder, start.y, start.z, end, end.y, end.z, duration, v68);\n\tv109 = &v81 @ stack_-E0_v1 (System.Int32) + 0x20;\n\tv112 = 0xF3F1B4(v109, this, methodInfo, v63, v64, v65, v66, v67, v93.m_builder, start.y, start.z, end, end.y, end.z, duration, v68);\n\tv120 = &v81 @ stack_-E0_v1 (System.Int32) + 0x30;\n\tv123 = 0xF3F1B4(v120, callback, methodInfo, v63, v64, v65, v66, v67, v93.m_builder, start.y, start.z, end, end.y, end.z, duration, v68);\n\tv125 = 0xFFFFFFFF;\n\tSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder::Start(v101, &v125 @ stack_-E0_v2 (BFS.Essential.TweenCore.DoVector+<ValueTo>d__0));\n\treturnVal1 = System.Runtime.CompilerServices.AsyncTaskMethodBuilder::get_Task(v101);\n\treturn returnVal1;\n// 98 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		internal unsafe global::System.Threading.Tasks.Task ValueTo(global::UnityEngine.Vector3 start, global::UnityEngine.Vector3 end, float duration, global::System.Action<global::UnityEngine.Vector3> callback)
		{
			//IL_003b: Expected O, but got I
			//IL_0054: Expected O, but got I
			//IL_0070: Expected O, but got I8
			global::BFS.Essential.TweenCore.DoVector._003CValueTo_003Ed__0 stateMachine = default(global::BFS.Essential.TweenCore.DoVector._003CValueTo_003Ed__0);
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

		[global::Cpp2ILInjected.Token(Token = "0x60004EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1028288", Offset = "0x1028288", Length = "0x34")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv20 = BFS.Essential.TweenCore.DoVector::ValueTo(this, start, end, duration, callback);\n\tv26 = this + 0x20;\n\tthis.m_Task = v20;\n\tv27 = 0xF3F1B4(v26, v20, methodInfo, v28, v29, v30, v31, v32, start, start.y, start.z, end, end.y, end.z, duration, v33);\n\treturn this;\n// 21 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public global::BFS.Essential.Tween Play(global::UnityEngine.Vector3 start, global::UnityEngine.Vector3 end, float duration, global::System.Action<global::UnityEngine.Vector3> callback)
		{
			//IL_0026: Expected O, but got I
			global::System.Threading.Tasks.Task task = ValueTo(start, end, duration, callback);
			m_Task = task;
			return this;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60004F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1028208", Offset = "0x1028208", Length = "0x80")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv16 = 0x302A000;\n\tv18 = System.Net.Configuration.SettingsSectionInternal;\n\tv20 = *([302AB48]) & 1;\n\tv21 = v20 == 0;\n\tif (v21) goto L_0022;\n\tv22 = *([v18 @ X21_v1 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+B38]);\n\tv24 = *([v22 @ X0_v10+E0]) == 0;\n\tif (v24) goto L_0031;\nL_001C:\n\tBFS.Essential.Tween::.ctor(this);\n\treturn;\nL_0022:\n\t*([v16 @ X20_v1+B48]) = 1;\n\tv44 = *([v18 @ X21_v1 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+B38]);\n\tv61 = *([v44 @ X0_v7+E0]) == 0;\n\tv46 = ~v61;\n\tif (v46) goto L_001C;\nL_0031:\n\tBFS.Essential.Tween::.ctor(this);\n\treturn;\n// 34 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public DoVector()
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