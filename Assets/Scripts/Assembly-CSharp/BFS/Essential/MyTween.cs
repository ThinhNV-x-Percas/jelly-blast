namespace BFS.Essential
{
	[global::Cpp2ILInjected.Token(Token = "0x200010F")]
	public static class MyTween
	{
		[global::Cpp2ILInjected.Token(Token = "0x60004CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1027B7C", Offset = "0x1027B7C", Length = "0x100")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv32 = System.ComponentModel.BooleanConverter;\n\tgoto L_001E;\n\tv37 = System.ComponentModel.BooleanConverter;\n\tv38 = v37 + 0xDD0;\n\tv39 = \"il2cpp_codegen_initialize_runtime_metadata\"(v38, methodInfo, v41, v42, v43, v44, v45, v46, start, end, duration, v47, v48, v49, v50, v51);\n\tv54 = 1;\n\t*([302AB40]) = v54;\nL_001E:\n\tv56 = new *([v32 @ X21_v1 (Il2CppClass<System.ComponentModel.BooleanConverter>)+DD0])();\n\tv58 = 0x302A000;\n\tv60 = System.Net.Configuration.SettingsSectionInternal;\n\tv62 = T & 1;\n\tv63 = v62 == 0;\n\tif (v63) goto L_004B;\n\tv64 = *([v60 @ X21_v3 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+B38]);\n\tv66 = *([v64 @ X0_v22+E0]) == 0;\n\tif (v66) goto L_0053;\nL_002C:\n\tBFS.Essential.Tween::.ctor(v56);\nL_0034:\n\tv94 = BFS.Essential.TweenCore.DoFloat::ValueTo(v56, start, end, duration, callback);\n\tv102 = v56 + 0x20;\n\tv56.m_Task = v94;\n\tv103 = 0xF3F1B4(v102, v94, v41, v42, v43, v44, v45, v46, start, end, duration, v47, v48, v49, v50, v51);\n\treturn v56;\nL_004B:\n\t*([v58 @ X22_v1+B47]) = 1;\n\tv71 = *([v60 @ X21_v3 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+B38]);\n\tv82 = *([v71 @ X0_v12+E0]) == 0;\n\tv73 = ~v82;\n\tif (v73) goto L_002C;\nL_0053:\n\tBFS.Essential.Tween::.ctor(v56);\n\tv99 = v56 == 0;\n\tv87 = ~v99;\n\tif (v87) goto L_0034;\n\treturnVal1 = new System.NullReferenceException();\n\treturn returnVal1;\n// 56 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public static global::BFS.Essential.Tween DoFloat(float start, float end, float duration, global::System.Action<float> callback)
		{
			//IL_000e: Expected I, but got O
			//IL_012d: Expected O, but got I4
			//IL_013b: Expected I, but got O
			//IL_014a: Unknown result type (might be due to invalid IL or missing references)
			//IL_014f: Expected I4, but got Unknown
			//IL_00b0: Expected O, but got I
			//IL_0079: Expected O, but got I
			//IL_0023: Expected O, but got I
			// The original body guarded static class initialization before allocating the tween and
			// always used the concrete DoFloat instance afterward (see the cast below); the guard's
			// metadata references do not resolve in this project and have no other observable effect.
			global::BFS.Essential.Tween tween = new global::BFS.Essential.TweenCore.DoFloat();
			global::System.Threading.Tasks.Task task = ((global::BFS.Essential.TweenCore.DoFloat)tween).ValueTo(start, end, duration, callback);
			tween.m_Task = task;
			return tween;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60004CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1027D30", Offset = "0x1027D30", Length = "0xE8")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv24 = System.ComponentModel.BooleanConverter;\n\tgoto L_001A;\n\tv29 = System.ComponentModel.BooleanConverter;\n\tv30 = v29 + 0xDC8;\n\tv31 = \"il2cpp_codegen_initialize_runtime_metadata\"(v30, methodInfo, v33, v34, v35, v36, v37, v38, duration, v39, v40, v41, v42, v43, v44, v45);\n\tv48 = 1;\n\t*([302AB41]) = v48;\nL_001A:\n\tv50 = new *([v24 @ X21_v1 (Il2CppClass<System.ComponentModel.BooleanConverter>)+DC8])();\n\tv52 = 0x302A000;\n\tv54 = System.Net.Configuration.SettingsSectionInternal;\n\tv56 = *([302AB46]) & 1;\n\tv57 = v56 == 0;\n\tif (v57) goto L_0043;\n\tv58 = *([v54 @ X21_v3 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+B38]);\n\tv60 = *([v58 @ X0_v22+E0]) == 0;\n\tif (v60) goto L_004B;\nL_0028:\n\tBFS.Essential.Tween::.ctor(v50);\nL_002E:\n\tv86 = BFS.Essential.TweenCore.DoDelay::Delay(v50, duration, callback);\n\tv94 = v50 + 0x20;\n\tv50.m_Task = v86;\n\tv95 = 0xF3F1B4(v94, v86, v33, v34, v35, v36, v37, v38, duration, v39, v40, v41, v42, v43, v44, v45);\n\treturn v50;\nL_0043:\n\t*([v52 @ X22_v1+B46]) = 1;\n\tv65 = *([v54 @ X21_v3 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+B38]);\n\tv76 = *([v65 @ X0_v12+E0]) == 0;\n\tv67 = ~v76;\n\tif (v67) goto L_0028;\nL_004B:\n\tBFS.Essential.Tween::.ctor(v50);\n\tv91 = v50 == 0;\n\tv81 = ~v91;\n\tif (v81) goto L_002E;\n\treturnVal1 = new System.NullReferenceException();\n\treturn returnVal1;\n// 48 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public static global::BFS.Essential.Tween DoDelay(float duration, global::System.Action callback)
		{
			//IL_000e: Expected I, but got O
			//IL_0125: Expected O, but got I4
			//IL_0133: Expected I, but got O
			//IL_00a8: Expected O, but got I
			//IL_0071: Expected O, but got I
			//IL_0023: Expected O, but got I
			// The original body guarded static class initialization before allocating the tween and
			// always used the concrete DoDelay instance afterward (see the cast below); the guard's
			// metadata references do not resolve in this project and have no other observable effect.
			global::BFS.Essential.Tween tween = new global::BFS.Essential.TweenCore.DoDelay();
			global::System.Threading.Tasks.Task task = ((global::BFS.Essential.TweenCore.DoDelay)tween).Delay(duration, callback);
			tween.m_Task = task;
			return tween;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60004CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1027ECC", Offset = "0x1027ECC", Length = "0x148")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv36 = &v37 @ stack_-10_v2;\n\tv50 = System.ComponentModel.BooleanConverter;\n\tgoto L_002D;\n\tv55 = System.ComponentModel.BooleanConverter;\n\tv56 = v55 + 0xDC0;\n\tv57 = \"il2cpp_codegen_initialize_runtime_metadata\"(v56, methodInfo, v59, v60, v61, v62, v63, v64, start, v0, v2, v3, end, v4, v6, v7);\n\tv67 = 1;\n\t*([302AB42]) = v67;\nL_002D:\n\tv69 = new *([v50 @ X21_v1 (Il2CppClass<System.ComponentModel.BooleanConverter>)+DC0])();\n\tv71 = 0x302A000;\n\tv73 = System.Net.Configuration.SettingsSectionInternal;\n\tv75 = *([302AB45]) & 1;\n\tv76 = v75 == 0;\n\tif (v76) goto L_0067;\n\tv77 = *([v73 @ X21_v3 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+B38]);\n\tv79 = *([v77 @ X0_v22+E0]) == 0;\n\tif (v79) goto L_006F;\nL_003B:\n\tBFS.Essential.Tween::.ctor(v69);\nL_004C:\n\tv116 = BFS.Essential.TweenCore.DoColor::ValueTo(v69, start, end, *([v36 @ X29_v1+10]), callback);\n\tv124 = v69 + 0x20;\n\tv69.m_Task = v116;\n\tv125 = 0xF3F1B4(v124, v116, v59, v60, v61, v62, v63, v64, start, start.g, start.b, start.a, end, end.g, end.b, end.a);\n\treturn v69;\nL_0067:\n\t*([v71 @ X22_v1+B45]) = 1;\n\tv84 = *([v73 @ X21_v3 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+B38]);\n\tv95 = *([v84 @ X0_v12+E0]) == 0;\n\tv86 = ~v95;\n\tif (v86) goto L_003B;\nL_006F:\n\tBFS.Essential.Tween::.ctor(v69);\n\tv121 = v69 == 0;\n\tv100 = ~v121;\n\tif (v100) goto L_004C;\n\treturnVal1 = new System.NullReferenceException();\n\treturn returnVal1;\n// 83 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public static global::BFS.Essential.Tween DoColor(global::UnityEngine.Color start, global::UnityEngine.Color end, float duration, global::System.Action<global::UnityEngine.Color> callback)
		{
			//IL_0016: Expected I, but got O
			//IL_013d: Expected O, but got I4
			//IL_014b: Expected I, but got O
			//IL_00c0: Expected O, but got I
			//IL_0076: Expected F4, but got I
			//IL_0089: Expected O, but got I
			//IL_002b: Expected O, but got I
			object obj2 = default(object);
			object obj = obj2;
			// The original body guarded static class initialization before allocating the tween and
			// always used the concrete DoColor instance afterward (see the cast below); the guard's
			// metadata references do not resolve in this project and have no other observable effect.
			global::BFS.Essential.Tween tween = new global::BFS.Essential.TweenCore.DoColor();
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X29_v1+10]");
			global::System.Threading.Tasks.Task task = ((global::BFS.Essential.TweenCore.DoColor)tween).ValueTo(start, end, 0f, callback);
			tween.m_Task = task;
			return tween;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60004CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x10280D8", Offset = "0x10280D8", Length = "0x130")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv48 = System.ComponentModel.BooleanConverter;\n\tgoto L_002A;\n\tv53 = System.ComponentModel.BooleanConverter;\n\tv54 = v53 + 0xDE0;\n\tv55 = \"il2cpp_codegen_initialize_runtime_metadata\"(v54, methodInfo, v57, v58, v59, v60, v61, v62, start, v0, v2, end, v3, v5, duration, v63);\n\tv66 = 1;\n\t*([302AB43]) = v66;\nL_002A:\n\tv68 = new *([v48 @ X21_v1 (Il2CppClass<System.ComponentModel.BooleanConverter>)+DE0])();\n\tv70 = 0x302A000;\n\tv72 = System.Net.Configuration.SettingsSectionInternal;\n\tv74 = *([302AB48]) & 1;\n\tv75 = v74 == 0;\n\tif (v75) goto L_0061;\n\tv76 = *([v72 @ X21_v3 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+B38]);\n\tv78 = *([v76 @ X0_v22+E0]) == 0;\n\tif (v78) goto L_0069;\nL_0038:\n\tBFS.Essential.Tween::.ctor(v68);\nL_0046:\n\tv112 = BFS.Essential.TweenCore.DoVector::ValueTo(v68, start, end, duration, callback);\n\tv120 = v68 + 0x20;\n\tv68.m_Task = v112;\n\tv121 = 0xF3F1B4(v120, v112, v57, v58, v59, v60, v61, v62, start, start.y, start.z, end, end.y, end.z, duration, v63);\n\treturn v68;\nL_0061:\n\t*([v70 @ X22_v1+B48]) = 1;\n\tv83 = *([v72 @ X21_v3 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+B38]);\n\tv94 = *([v83 @ X0_v12+E0]) == 0;\n\tv85 = ~v94;\n\tif (v85) goto L_0038;\nL_0069:\n\tBFS.Essential.Tween::.ctor(v68);\n\tv117 = v68 == 0;\n\tv99 = ~v117;\n\tif (v99) goto L_0046;\n\treturnVal1 = new System.NullReferenceException();\n\treturn returnVal1;\n// 78 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public static global::BFS.Essential.Tween DoVector(global::UnityEngine.Vector3 start, global::UnityEngine.Vector3 end, float duration, global::System.Action<global::UnityEngine.Vector3> callback)
		{
			//IL_000e: Expected I, but got O
			//IL_012d: Expected O, but got I4
			//IL_013b: Expected I, but got O
			//IL_00b0: Expected O, but got I
			//IL_0079: Expected O, but got I
			//IL_0023: Expected O, but got I
			// The original body guarded static class initialization before allocating the tween and
			// always used the concrete DoVector instance afterward (see the cast below); the guard's
			// metadata references do not resolve in this project and have no other observable effect.
			global::BFS.Essential.Tween tween = new global::BFS.Essential.TweenCore.DoVector();
			global::System.Threading.Tasks.Task task = ((global::BFS.Essential.TweenCore.DoVector)tween).ValueTo(start, end, duration, callback);
			tween.m_Task = task;
			return tween;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60004CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x10282BC", Offset = "0x10282BC", Length = "0x148")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv36 = &v37 @ stack_-10_v2;\n\tv50 = System.ComponentModel.BooleanConverter;\n\tgoto L_002D;\n\tv55 = System.ComponentModel.BooleanConverter;\n\tv56 = v55 + 0xDD8;\n\tv57 = \"il2cpp_codegen_initialize_runtime_metadata\"(v56, methodInfo, v59, v60, v61, v62, v63, v64, start, v0, v2, v3, end, v4, v6, v7);\n\tv67 = 1;\n\t*([302AB44]) = v67;\nL_002D:\n\tv69 = new *([v50 @ X21_v1 (Il2CppClass<System.ComponentModel.BooleanConverter>)+DD8])();\n\tv71 = 0x302A000;\n\tv73 = System.Net.Configuration.SettingsSectionInternal;\n\tv75 = *([302AB3F]) & 1;\n\tv76 = v75 == 0;\n\tif (v76) goto L_0067;\n\tv77 = *([v73 @ X21_v3 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+B38]);\n\tv79 = *([v77 @ X0_v22+E0]) == 0;\n\tif (v79) goto L_006F;\nL_003B:\n\tBFS.Essential.Tween::.ctor(v69);\nL_004C:\n\tv116 = BFS.Essential.DoRotation::ValueTo(v69, start, end, *([v36 @ X29_v1+10]), callback);\n\tv124 = v69 + 0x20;\n\tv69.m_Task = v116;\n\tv125 = 0xF3F1B4(v124, v116, v59, v60, v61, v62, v63, v64, start, start.y, start.z, start.w, end, end.y, end.z, end.w);\n\treturn v69;\nL_0067:\n\t*([v71 @ X22_v1+B3F]) = 1;\n\tv84 = *([v73 @ X21_v3 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+B38]);\n\tv95 = *([v84 @ X0_v12+E0]) == 0;\n\tv86 = ~v95;\n\tif (v86) goto L_003B;\nL_006F:\n\tBFS.Essential.Tween::.ctor(v69);\n\tv121 = v69 == 0;\n\tv100 = ~v121;\n\tif (v100) goto L_004C;\n\treturnVal1 = new System.NullReferenceException();\n\treturn returnVal1;\n// 83 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public static global::BFS.Essential.Tween DoRotation(global::UnityEngine.Quaternion start, global::UnityEngine.Quaternion end, float duration, global::System.Action<global::UnityEngine.Quaternion> callback)
		{
			//IL_0016: Expected I, but got O
			//IL_013d: Expected O, but got I4
			//IL_014b: Expected I, but got O
			//IL_00c0: Expected O, but got I
			//IL_0076: Expected F4, but got I
			//IL_0089: Expected O, but got I
			//IL_002b: Expected O, but got I
			object obj2 = default(object);
			object obj = obj2;
			// The original body guarded static class initialization before allocating the tween and
			// always used the concrete DoRotation instance afterward (see the cast below); the guard's
			// metadata references do not resolve in this project and have no other observable effect.
			global::BFS.Essential.Tween tween = new global::BFS.Essential.DoRotation();
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X29_v1+10]");
			global::System.Threading.Tasks.Task task = ((global::BFS.Essential.DoRotation)tween).ValueTo(start, end, 0f, callback);
			tween.m_Task = task;
			return tween;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60004CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1028404", Offset = "0x1028404", Length = "0xEC")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv16 = System.Net.Configuration.SettingsSectionInternal;\n\tgoto L_0033;\n\tv23 = Il2CppMethodInfo;\n\tv24 = v23 + 0x908;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv90 = Il2CppMethodInfo;\n\tv91 = v90 + 0x910;\n\tv92 = \"il2cpp_codegen_initialize_runtime_metadata\"(v91, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv98 = System.Net.Configuration.SettingsSectionInternal;\n\tv99 = v98 + 0xB38;\n\tv81 = \"il2cpp_codegen_initialize_runtime_metadata\"(v99, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv86 = 1;\n\t*([302AB21]) = v86;\n\tgoto L_0033;\nL_001F:\n\tv141 = *([v100 @ X0_v5+E0]) == 0;\n\tv142 = ~v141;\n\tif (v142) goto L_002B;\n\tv168 = *([v16 @ X19_v1 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+B38]);\n\tv169 = *([v168 @ X8_v8+B8]);\n\tv133 = *([v169 @ X8_v9]);\nL_002B:\n\tv128 = System.Collections.Generic.List`1<System.Object>::get_Item(v133, 0);\n\tv85 = *([v128 @ X0_v8]);\n\t*([v85 @ X8_v7+1A8])(v79, v128, 0, *([v85 @ X8_v7+1B0]), v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\nL_0033:\n\tv100 = *([v16 @ X19_v1 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+B38]);\n\tv89 = *([v100 @ X0_v5+E0]) == 0;\n\tif (v89) goto L_003E;\n\tv93 = *([v100 @ X0_v5+B8]);\n\tv133 = *([v93 @ X8_v13]);\n\tv95 = *([v93 @ X8_v13]) == 0;\n\tv96 = ~v95;\n\tif (v96) goto L_004F;\n\tgoto L_0059;\nL_003E:\n\tv100 = *([v16 @ X19_v1 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+B38]);\n\tv109 = *([v100 @ X0_v5+B8]);\n\tv133 = *([v109 @ X8_v11]);\nL_004F:\n\tv45 = *([v133 @ X8_v6+18]) > 0;\n\tif (v45) goto L_001F;\n\treturn;\nL_0059:\n\tthrow System.NullReferenceException;\n// 52 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public static void KillAll()
		{
			//IL_000e: Expected I, but got O
			//IL_014d: Expected O, but got I
			//IL_00f4: Expected O, but got I
			//IL_0104: Expected O, but got I
			//IL_00af: Expected O, but got I
			//IL_0054: Expected O, but got I
			//IL_0064: Expected O, but got I
			while (true)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X19_v1 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+B38]");
				object obj = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v5+E0]");
				object obj3;
				if ((nint)0 != 0)
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v5+B8]");
					object obj2 = 0;
					obj3 = obj2;
					if (obj2 == null)
					{
						break;
					}
				}
				else
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X19_v1 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+B38]");
					obj = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v5+B8]");
					object obj4 = 0;
					obj3 = obj4;
				}
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v6+18]");
				if ((nint)0 > (nint)0)
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v5+E0]");
					if ((nint)0 == 0)
					{
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X19_v1 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+B38]");
						object obj5 = 0;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X8_v8+B8]");
						object obj6 = 0;
						obj3 = obj6;
					}
					object obj7 = ((global::System.Collections.Generic.List<object>)obj3)[0];
					object obj8 = obj7;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v85 @ X8_v7+1A8] (should have been resolved before IL gen)");
					continue;
				}
				return;
			}
			throw new global::System.NullReferenceException();
		}
	}
}
