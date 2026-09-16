using System.Runtime.InteropServices;

namespace BFS.Essential
{
	[global::Cpp2ILInjected.Token(Token = "0x200010D")]
	public class DoRotation : global::BFS.Essential.Tween
	{
		[StructLayout((LayoutKind)3)]
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200010E")]
		private struct _003CValueTo_003Ed__0 : global::System.Runtime.CompilerServices.IAsyncStateMachine
		{
			[global::Cpp2ILInjected.Token(Token = "0x4000553")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[global::Cpp2ILInjected.Token(Token = "0x4000554")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder _003C_003Et__builder;

			[global::Cpp2ILInjected.Token(Token = "0x4000555")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public global::BFS.Essential.DoRotation _003C_003E4__this;

			[global::Cpp2ILInjected.Token(Token = "0x4000556")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public float duration;

			[global::Cpp2ILInjected.Token(Token = "0x4000557")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public global::System.Action<global::UnityEngine.Quaternion> callback;

			[global::Cpp2ILInjected.Token(Token = "0x4000558")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public global::UnityEngine.Quaternion start;

			[global::Cpp2ILInjected.Token(Token = "0x4000559")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			public global::UnityEngine.Quaternion end;

			[global::Cpp2ILInjected.Token(Token = "0x400055A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			private float _003Clerp_003E5__2;

			[global::Cpp2ILInjected.Token(Token = "0x400055B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
			private global::System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter _003C_003Eu__1;

			[global::Cpp2ILInjected.Token(Token = "0x60004C8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1027778", Offset = "0x1027778", Length = "0x398")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0030;\n\tv41 = Il2CppMethodInfo;\n\tv42 = v41 + 0x248;\n\tv43 = \"il2cpp_codegen_initialize_runtime_metadata\"(v42, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58);\n\tv74 = CollectParticleData[];\n\tv75 = v74 + 0xCA0;\n\tv76 = \"il2cpp_codegen_initialize_runtime_metadata\"(v75, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58);\n\tv81 = System.Net.Configuration.SettingsSectionInternal;\n\tv82 = v81 + 0x748;\n\tv83 = \"il2cpp_codegen_initialize_runtime_metadata\"(v82, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58);\n\tv182 = Sponge+<>c__DisplayClass7_0;\n\tv183 = v182 + 0x9D0;\n\tv60 = \"il2cpp_codegen_initialize_runtime_metadata\"(v183, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58);\n\tv62 = 1;\n\t*([302AB1F]) = v62;\nL_0030:\n\tv72 = this.<>4__this;\n\tv73 = this.<>1__state == 0;\n\tif (v73) goto L_003C;\n\tv77 = this.<>4__this == 0;\n\tif (v77) goto L_0040;\n\tv72.m_Run = 1;\n\tthis.<lerp>5__2 = 0f;\n\tgoto L_0047;\nL_003C:\n\tthis.<>u__1 = 0;\n\tthis.<>1__state = 0xFFFFFFFF;\n\tgoto L_00B5;\nL_0040:\n\tv86 = new System.NullReferenceException();\n\tgoto L_0043;\n\tgoto L_010F;\nL_0043:\n\t// 67 Interrupt\nL_0044:\n\tv258 = this.<>4__this == 0;\n\tif (v258) goto L_00FD;\nL_0047:\n\tv262 = ~v72.m_Run;\n\tif (v262) goto L_00CF;\n\tv268 = UnityEngine.Time::get_deltaTime();\n\tv377 = v268 / this.duration;\n\tv378 = v253 + v377;\n\tv382 = v378 - 1f;\n\tv383 = v382 < 0;\n\tv384 = v382 == 0;\n\tv385 = v378 ^ 1f;\n\tv386 = v378 ^ v382;\n\tv387 = v385 & v386;\n\tv388 = v387 < 0;\n\tv389 = v383 == v388;\n\tv135 = ~v384;\n\tv138 = v389 & v135;\n\tv390 = ~v138;\n\tif (v390) goto L_FFFFFFFF;\n\tgoto L_006B;\nL_006B:\n\tv132 = v378 >= 0;\n\tif (v132) goto L_FFFFFFFF;\n\tgoto L_0071;\nL_0071:\n\tthis.<lerp>5__2 = v364;\n\tv88 = this.callback;\n\tv466 = this.callback == 0;\n\tif (v466) goto L_009C;\n\tv374 = v72.m_Interpolator;\n\tv372 = v72.m_Interpolator == 0;\n\tif (v372) goto L_00FF;\n\tv374.invoke_impl(this, v374.method_code, v374.method, v45, v46, v47, v48, v49, v50, v364, v362, v108, v106, v104, v102, v100, v98);\n\tv487 = UnityEngine.Quaternion::LerpUnclamped(this.start, this.end, v364);\n\tv108 = v487.z;\n\tv106 = v487.w;\n\tv88.invoke_impl(this, v88.method_code, v88.method, v45, v46, v47, v48, v49, v50, v487, v487.y, v487.z, v487.w, this.end, *([this @ X0 (BFS.Essential.DoRotation+<ValueTo>d__0)+4C]), *([this @ X0 (BFS.Essential.DoRotation+<ValueTo>d__0)+50]), *([this @ X0 (BFS.Essential.DoRotation+<ValueTo>d__0)+54]));\nL_009C:\n\tgoto L_009F;\n\tv506 = \"il2cpp_codegen_runtime_class_init\"(v494, v476, v45, v46, v47, v48, v49, v50, v167, v165, v108, v106, v104, v102, v100, v98);\nL_009F:\n\tv509 = System.Threading.Tasks.Task::Yield();\n\tv513 = System.Runtime.CompilerServices.YieldAwaitable::GetAwaiter(&v509 @ X0_v24 (System.Runtime.CompilerServices.YieldAwaitable));\n\tgoto L_00AD;\n\tv518 = \"il2cpp_codegen_runtime_class_init\"(v515, v512, v45, v46, v47, v48, v49, v50, v167, v165, v108, v106, v104, v102, v100, v98);\nL_00AD:\n\tv173 = System.Runtime.CompilerServices.YieldAwaitable+YieldAwaiter::get_IsCompleted(&v168 @ stack_-81_v4 (System.Runtime.CompilerServices.YieldAwaitable+YieldAwaiter));\n\tv175 = v173 == 0;\n\tif (v175) goto L_00DB;\nL_00B5:\n\tgoto L_00B9;\n\tv263 = \"il2cpp_codegen_runtime_class_init\"(v178, v112, v45, v46, v47, v48, v49, v50, v166, v164, v107, v105, v103, v101, v99, v97);\nL_00B9:\n\tSystem.Runtime.CompilerServices.YieldAwaitable+YieldAwaiter::GetResult(&v168 @ stack_-81_v4 (System.Runtime.CompilerServices.YieldAwaitable+YieldAwaiter));\n\tv253 = this.<lerp>5__2;\n\tv307 = this.<lerp>5__2 < 1f;\n\tif (v307) goto L_0044;\n\tv321 = this.<>4__this == 0;\n\tif (v321) goto L_0101;\n\tthis = BFS.Essential.Tween::Kill(this.<>4__this, 1);\nL_00CF:\n\tthis.<>1__state = 0xFFFFFFFE;\n\tv325 = this + 8;\n\tgoto L_00D9;\n\tv391 = \"il2cpp_codegen_runtime_class_init\"(v326, v282, v270, v46, v47, v48, v49, v50, v313, v312, v280, v279, v278, v277, v276, v275);\nL_00D9:\n\tSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetResult(v325);\n\tgoto L_00FC;\nL_00DB:\n\tthis.<>1__state = 0;\n\tthis.<>u__1 = this.<>u__1;\n\tgoto L_00E4;\n\tv526 = \"il2cpp_codegen_runtime_class_init\"(v523, v113, v45, v46, v47, v48, v49, v50, v167, v165, v108, v106, v104, v102, v100, v98);\nL_00E4:\n\tv442 = this + 8;\n\tSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted(v442, &v168 @ stack_-81_v4 (System.Runtime.CompilerServices.YieldAwaitable+YieldAwaiter), this);\nL_00FC:\n\treturn;\nL_00FD:\n\tv368 = new System.NullReferenceException();\n\tgoto L_0043;\nL_00FF:\n\tv369 = new System.NullReferenceException();\n\tgoto L_0043;\nL_0101:\n\tv370 = new System.NullReferenceException();\n\tgoto L_0043;\n\tgoto L_010F;\n\tgoto L_010F;\n\tgoto L_010F;\n\tgoto L_010F;\n\tgoto L_010F;\n\tgoto L_010F;\n\tgoto L_010F;\n\tgoto L_010F;\n\tgoto L_010F;\n\tgoto L_010F;\n\tgoto L_010F;\n\tgoto L_010F;\nL_010F:\n\tX20 = X0;\n\tC = X1 < 1;\n\tC = ~C;\n\tTEMP1 = X1 - 1;\n\tN = TEMP1 < 0;\n\tTEMP2 = X1 ^ 1;\n\tTEMP3 = X1 ^ TEMP1;\n\tTEMP4 = TEMP2 & TEMP3;\n\tV = TEMP4 < 0;\n\tTEMPCOND = ~Z;\n\tif (TEMPCOND) goto L_0146;\n\tX0 = X20;\n\tX0 = 0x274A080(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX20 = X0;\n\tX0 = X0 + 0x108;\n\tX0 = 0xF3F22C(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX8 = *([X20]);\n\tX1 = *([X8]);\n\tX0 = 0xF3F978(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tif (TEMP) goto L_013B;\n\tX20 = *([X20]);\n\tX8 = stack[10];\n\tX9 = &stack[8];\n\t*([X9+X8*8]) = X20;\n\tX0 = 0x274A098(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX8 = 0xFFFFFFFE;\n\t*([X19]) = X8;\n\tX19 = X19 + 8;\n\tX0 = X0 + 0xCA0;\n\tX0 = 0xF3F22C(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX8 = *([X0+E0]);\n\tTEMP = ~TEMP;\n\tif (TEMP) goto L_0136;\n\tX0 = 0xF3F368(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\nL_0136:\n\tX0 = X19;\n\tX1 = X20;\n\tX2 = 0;\n\tSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetException(X0, X1, X2);\n\tgoto L_00FC;\nL_013B:\n\tX0 = 8;\n\tX0 = 0x274A068(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX8 = *([X20]);\n\t*([X0]) = X8;\n\tX1 = X1 + 0x398;\n\tX2 = 0;\n\tX0 = 0x274A0EC(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tgoto L_0043;\n\tX20 = X0;\n\tX0 = 0x274A098(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\nL_0146:\n\tX0 = X20;\n\tX0 = 0x27498DC(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX0 = 0xD6F8(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\treturn;\n// 163 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
			private unsafe void MoveNext()
			{
				//IL_03d6: Expected O, but got Ref
				//IL_0114: Expected O, but got F4
				//IL_0121: Expected O, but got F4
				//IL_023d: Expected O, but got I
				//IL_024d: Expected O, but got I
				//IL_025d: Expected O, but got I
				//IL_0358: Expected O, but got Ref
				global::BFS.Essential.DoRotation doRotation = _003C_003E4__this;
				float num = default(float);
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E4__this != null)
					{
						doRotation.m_Run = true;
						_003Clerp_003E5__2 = 0f;
						num = 0f;
						goto IL_008d;
					}
					global::System.NullReferenceException ex = new global::System.NullReferenceException();
					goto IL_0430;
				}
				_003C_003Eu__1 = default(global::System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter);
				_003C_003E1__state = -1;
				global::System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter awaiter = _003C_003Eu__1;
				goto IL_02bb;
				IL_02bb:
				awaiter.GetResult();
				num = _003Clerp_003E5__2;
				if (!(_003Clerp_003E5__2 < 1f))
				{
					if (_003C_003E4__this != null)
					{
						_003C_003E4__this.Kill(playOnComplete: true);
						goto IL_03c0;
					}
					global::System.NullReferenceException ex2 = new global::System.NullReferenceException();
				}
				goto IL_0430;
				IL_008d:
				if (doRotation.m_Run)
				{
					float deltaTime = global::UnityEngine.Time.deltaTime;
					float num2 = deltaTime / duration;
					float num3 = num + num2;
					float t = (_003Clerp_003E5__2 = global::UnityEngine.Mathf.Clamp01(num3));
					global::System.Action<global::UnityEngine.Quaternion> action = callback;
					if (callback != null)
					{
						global::System.Func<float, float> interpolator = doRotation.m_Interpolator;
						if (doRotation.m_Interpolator == null)
						{
							global::System.NullReferenceException ex3 = new global::System.NullReferenceException();
							goto IL_0430;
						}
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v374.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
						global::UnityEngine.Quaternion quaternion = global::UnityEngine.Quaternion.LerpUnclamped(start, end, t);
						float z = quaternion.z;
						float w = quaternion.w;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v88.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BFS.Essential.DoRotation+<ValueTo>d__0)+54]");
						object obj3 = 0;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BFS.Essential.DoRotation+<ValueTo>d__0)+50]");
						object obj4 = 0;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BFS.Essential.DoRotation+<ValueTo>d__0)+4C]");
						object obj5 = 0;
						global::UnityEngine.Quaternion quaternion2 = end;
					}
					global::System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter awaiter2 = global::System.Threading.Tasks.Task.Yield().GetAwaiter();
					if (awaiter.IsCompleted)
					{
						goto IL_02bb;
					}
					_003C_003E1__state = 0;
					_003C_003Eu__1 = _003C_003Eu__1;
					_003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_03c0;
				IL_03c0:
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetResult();
				return;
				IL_0430:
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
			[global::Cpp2ILInjected.Token(Token = "0x60004C9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1027B10", Offset = "0x1027B10", Length = "0x6C")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_001B;\n\tv25 = CollectParticleData[];\n\tv26 = v25 + 0xCA0;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, stateMachine, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41);\n\tv44 = 1;\n\t*([302AB20]) = v44;\nL_001B:\n\tgoto L_001D;\n\tv49 = \"il2cpp_codegen_runtime_class_init\"(v45, stateMachine, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41);\nL_001D:\n\tv51 = this + 8;\n\tSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder::SetStateMachine(v51, stateMachine);\n\treturn;\n// 30 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
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

		[global::System.Runtime.CompilerServices.AsyncStateMachine(typeof(global::BFS.Essential.DoRotation._003CValueTo_003Ed__0))]
		[global::Cpp2ILInjected.Token(Token = "0x60004C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x102738C", Offset = "0x102738C", Length = "0x164")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0033;\n\tv61 = Il2CppMethodInfo;\n\tv62 = v61 + 0x2B8;\n\tv63 = \"il2cpp_codegen_initialize_runtime_metadata\"(v62, callback, methodInfo, v65, v66, v67, v68, v69, start, v0, v2, v3, end, v4, v6, v7);\n\tv88 = CollectParticleData[];\n\tv89 = v88 + 0xCA0;\n\tv71 = \"il2cpp_codegen_initialize_runtime_metadata\"(v89, callback, methodInfo, v65, v66, v67, v68, v69, start, v0, v2, v3, end, v4, v6, v7);\n\tv73 = 1;\n\t*([302AB1E]) = v73;\nL_0033:\n\t;\n\tv82 = 0;\n\tgoto L_0044;\n\tv90 = \"il2cpp_codegen_runtime_class_init\"(v84, callback, methodInfo, v65, v66, v67, v68, v69, v77, v0, v2, v3, end, v4, v6, v7);\nL_0044:\n\tv95 = System.Runtime.CompilerServices.AsyncTaskMethodBuilder::Create();\n\tv103 = &v82 @ stack_-E0_v1 (System.Int32) | 8;\n\tv110 = 0xF3F1B4(v103, 0, methodInfo, v65, v66, v67, v68, v69, v95.m_builder, start.y, start.z, start.w, end, end.y, end.z, end.w);\n\tv111 = &v82 @ stack_-E0_v1 (System.Int32) + 0x20;\n\tv114 = 0xF3F1B4(v111, this, methodInfo, v65, v66, v67, v68, v69, v95.m_builder, start.y, start.z, start.w, end, end.y, end.z, end.w);\n\tv125 = &v82 @ stack_-E0_v1 (System.Int32) + 0x30;\n\tv128 = 0xF3F1B4(v125, callback, methodInfo, v65, v66, v67, v68, v69, end.w, start.y, start.z, start.w, end, end.y, end.z, end.w);\n\tv130 = 0xFFFFFFFF;\n\tSystem.Runtime.CompilerServices.AsyncTaskMethodBuilder::Start(v103, &v130 @ stack_-E0_v2 (BFS.Essential.DoRotation+<ValueTo>d__0));\n\treturnVal1 = System.Runtime.CompilerServices.AsyncTaskMethodBuilder::get_Task(v103);\n\treturn returnVal1;\n// 105 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		internal unsafe global::System.Threading.Tasks.Task ValueTo(global::UnityEngine.Quaternion start, global::UnityEngine.Quaternion end, float duration, global::System.Action<global::UnityEngine.Quaternion> callback)
		{
			//IL_003b: Expected O, but got I
			//IL_0054: Expected O, but got I
			//IL_0070: Expected O, but got I8
			global::BFS.Essential.DoRotation._003CValueTo_003Ed__0 stateMachine = default(global::BFS.Essential.DoRotation._003CValueTo_003Ed__0);
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

		[global::Cpp2ILInjected.Token(Token = "0x60004C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x10274F0", Offset = "0x10274F0", Length = "0x44")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv16 = &v17 @ stack_-10_v2;\n\tv24 = BFS.Essential.DoRotation::ValueTo(this, start, end, *([v16 @ X29_v1+10]), callback);\n\tv29 = this + 0x20;\n\tthis.m_Task = v24;\n\tv30 = 0xF3F1B4(v29, v24, methodInfo, v31, v32, v33, v34, v35, start, start.y, start.z, start.w, end, end.y, end.z, end.w);\n\treturn this;\n// 24 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public global::BFS.Essential.Tween Play(global::UnityEngine.Quaternion start, global::UnityEngine.Quaternion end, float duration, global::System.Action<global::UnityEngine.Quaternion> callback)
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

		[global::Cpp2ILInjected.Token(Token = "0x60004C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1027534", Offset = "0x1027534", Length = "0x80")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv16 = 0x302A000;\n\tv18 = System.Net.Configuration.SettingsSectionInternal;\n\tv20 = *([302AB3F]) & 1;\n\tv21 = v20 == 0;\n\tif (v21) goto L_0022;\n\tv22 = *([v18 @ X21_v1 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+B38]);\n\tv24 = *([v22 @ X0_v10+E0]) == 0;\n\tif (v24) goto L_0031;\nL_001C:\n\tBFS.Essential.Tween::.ctor(this);\n\treturn;\nL_0022:\n\t*([v16 @ X20_v1+B3F]) = 1;\n\tv44 = *([v18 @ X21_v1 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+B38]);\n\tv61 = *([v44 @ X0_v7+E0]) == 0;\n\tv46 = ~v61;\n\tif (v46) goto L_001C;\nL_0031:\n\tBFS.Essential.Tween::.ctor(this);\n\treturn;\n// 34 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public DoRotation()
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