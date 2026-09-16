namespace BFS.Essential
{
	[global::Cpp2ILInjected.Token(Token = "0x2000110")]
	public abstract class Tween
	{
		[global::Cpp2ILInjected.Token(Token = "0x400055C")]
		public static global::System.Collections.Generic.List<global::BFS.Essential.Tween> _Tweens;

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400055D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private global::System.Action m_m_OnComplete;

		[global::Cpp2ILInjected.Token(Token = "0x400055E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		protected internal bool m_Run;

		[global::Cpp2ILInjected.Token(Token = "0x400055F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		protected internal global::System.Threading.Tasks.Task m_Task;

		[global::Cpp2ILInjected.Token(Token = "0x4000560")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public global::System.Func<float, float> m_Interpolator;

		[global::Cpp2ILInjected.Token(Token = "0x1700005A")]
		protected bool Run
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004D2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1028638", Offset = "0x1028638", Length = "0x8")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn this.m_Run;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
			get
			{
				return m_Run;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700005B")]
		public global::System.Threading.Tasks.Task Task
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004D3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1028640", Offset = "0x1028640", Length = "0x8")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn this.m_Task;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
			get
			{
				return Task;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x14000003")]
		protected event global::System.Action m_OnComplete
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60004D0")]
			[global::Cpp2ILInjected.Address(RVA = "0x10284F0", Offset = "0x10284F0", Length = "0xA4")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0015;\n\tv23 = CollectParticleData[];\n\tv24 = v23 + 0x990;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, value, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv42 = 1;\n\t*([302AB22]) = v42;\nL_0015:\n\tv43 = CollectParticleData[];\n\tv45 = this + 0x10;\n\tgoto L_002C;\nL_001D:\n\tv79 = 0xFAC9D8(v45, v89, v84, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv63 = v79 == v84;\n\tif (v63) goto L_0045;\nL_002C:\n\tv89 = System.Delegate::Combine(v84, value);\n\tv81 = v89 == 0;\n\tif (v81) goto L_001D;\n\tv96 = *([v89 @ X0_v4 (System.Delegate)]) == *([v43 @ X22_v1 (Il2CppClass<CollectParticleData[]>)+990]);\n\tif (v96) goto L_001D;\n\tthrow System.InvalidCastException;\nL_0045:\n\treturn;\n// 51 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
			add
			{
				//IL_009a: Expected I, but got O
				//IL_00a6: Expected O, but got I
				nint num = (nint)typeof(CollectParticleData[]);
				object obj = (nint)this + 16;
				global::System.Delegate obj2 = this.m_m_OnComplete;
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
			[global::Cpp2ILInjected.Token(Token = "0x60004D1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1028594", Offset = "0x1028594", Length = "0xA4")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0015;\n\tv23 = CollectParticleData[];\n\tv24 = v23 + 0x990;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, value, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv42 = 1;\n\t*([302AB23]) = v42;\nL_0015:\n\tv43 = CollectParticleData[];\n\tv45 = this + 0x10;\n\tgoto L_002C;\nL_001D:\n\tv79 = 0xFAC9D8(v45, v89, v84, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv63 = v79 == v84;\n\tif (v63) goto L_0045;\nL_002C:\n\tv89 = System.Delegate::Remove(v84, value);\n\tv81 = v89 == 0;\n\tif (v81) goto L_001D;\n\tv96 = *([v89 @ X0_v4 (System.Delegate)]) == *([v43 @ X22_v1 (Il2CppClass<CollectParticleData[]>)+990]);\n\tif (v96) goto L_001D;\n\tthrow System.InvalidCastException;\nL_0045:\n\treturn;\n// 51 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
			remove
			{
				//IL_009a: Expected I, but got O
				//IL_00a6: Expected O, but got I
				nint num = (nint)typeof(CollectParticleData[]);
				object obj = (nint)this + 16;
				global::System.Delegate obj2 = this.m_m_OnComplete;
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

		[global::Cpp2ILInjected.Token(Token = "0x60004D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x10275B4", Offset = "0x10275B4", Length = "0x1C4")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv16 = 0x302A000;\n\tv18 = Sponge+<>c__DisplayClass7_0;\n\tv20 = *([302AB24]) & 1;\n\tv21 = v20 == 0;\n\tif (v21) goto L_002C;\n\tv43 = *([v18 @ X22_v1 (Il2CppClass<Sponge+<>c__DisplayClass7_0>)+378]);\n\tv24 = *([v43 @ X0_v44+E0]) == 0;\n\tif (v24) goto L_0033;\nL_0014:\n\tv106 = *([v43 @ X0_v44+B8]);\n\tv96 = *([v106 @ X8_v13+8]);\n\tv51 = *([v106 @ X8_v13+8]) == 0;\n\tif (v51) goto L_003C;\nL_0018:\n\tv67 = this == 0;\n\tv68 = ~v67;\n\tif (v68) goto L_0054;\n\tgoto L_009B;\nL_002C:\n\t*([v16 @ X20_v1+B24]) = 1;\n\tv43 = *([v18 @ X22_v1 (Il2CppClass<Sponge+<>c__DisplayClass7_0>)+378]);\n\tv147 = *([v43 @ X0_v44+E0]) == 0;\n\tv46 = ~v147;\n\tif (v46) goto L_0014;\nL_0033:\n\tv60 = *([v18 @ X22_v1 (Il2CppClass<Sponge+<>c__DisplayClass7_0>)+378]);\n\tv106 = *([v60 @ X0_v26+B8]);\n\tv96 = *([v106 @ X8_v13+8]);\n\tv76 = *([v106 @ X8_v13+8]) == 0;\n\tv62 = ~v76;\n\tif (v62) goto L_0018;\nL_003C:\n\tgoto L_0041;\n\tv104 = \"il2cpp_codegen_runtime_class_init\"(v69, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv133 = *([v19 @ X22_v2]);\n\tv107 = *([v133 @ X8_v19+B8]);\nL_0041:\n\tv108 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv111 = new *([v108 @ X8_v14 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+2E8])();\n\tv134 = Il2CppMethodInfo;\n\tSystem.Func`2<System.Single, System.Single>::.ctor(v111, *([v106 @ X8_v13]), *([v134 @ X8_v16 (Il2CppMethodInfo)+2F0]));\n\tv95 = *([v18 @ X22_v1 (Il2CppClass<Sponge+<>c__DisplayClass7_0>)+378]);\n\tv145 = *([v95 @ X8_v18+B8]) + 8;\n\t*([v145 @ X0_v21]) = v111;\n\tv91 = 0xF3F1B4(v145, v111, *([v134 @ X8_v16 (Il2CppMethodInfo)+2F0]), 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\nL_0054:\n\tv98 = System.Net.Configuration.SettingsSectionInternal;\n\tv101 = this + 0x28;\n\tthis.m_Interpolator = v96;\n\tv103 = 0xF3F1B4(v101, v96, *([v134 @ X8_v16 (Il2CppMethodInfo)+2F0]), 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tSystem.Object::.ctor(this);\n\tv213 = *([v98 @ X21_v3 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+B38]);\n\tgoto L_0065;\n\tv212 = \"il2cpp_codegen_runtime_class_init\"(v140, v118, v86, v82, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv214 = *([v99 @ X21_v4]);\nL_0065:\n\tv129 = *([v213 @ X0_v9+B8]);\n\tv123 = *([v129 @ X8_v5]);\n\tv218 = *([v123 @ X0_v10+1C]) + 1;\n\t*([v123 @ X0_v10+1C]) = v218;\n\tv121 = *([v123 @ X0_v10+10]);\n\tv219 = *([v123 @ X0_v10+18]) < *([v121 @ X9_v5+18]);\n\tv176 = ~v219;\n\tif (v176) goto L_008E;\n\tv201 = *([v123 @ X0_v10+18]) + 1;\n\t*([v123 @ X0_v10+18]) = v201;\n\tv152 = *([v123 @ X0_v10+18]) << 3;\n\tv220 = v121 + v152;\n\tv221 = v220 + 0x20;\n\t*([v221 @ X0_v12]) = this;\n\tv195 = 0xF3F1B4(v221, this, *([v134 @ X8_v16 (Il2CppMethodInfo)+2F0]), 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\treturn;\nL_008E:\n\t;\n\tSystem.Collections.Generic.List`1<System.Object>::AddWithResize(v123, this);\n\treturn;\nL_009B:\n\tthrow System.NullReferenceException;\n// 89 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		protected internal Tween()
		{
			//IL_000f: Expected O, but got I4
			//IL_001d: Expected I, but got O
			//IL_010a: Expected O, but got I
			//IL_0095: Expected O, but got I
			//IL_00a5: Expected O, but got I
			//IL_0060: Expected O, but got I
			//IL_014a: Expected O, but got I
			//IL_015a: Expected O, but got I
			//IL_016a: Expected O, but got I
			//IL_02dc: Expected I, but got O
			//IL_030c: Expected O, but got I
			//IL_0322: Expected O, but got I
			//IL_01ba: Expected I, but got O
			//IL_01c6: Expected O, but got I
			//IL_01ef: Expected O, but got I
			//IL_0349: Expected O, but got I
			//IL_020c: Expected O, but got I
			//IL_0221: Expected O, but got I
			//IL_0273: Expected O, but got I
			//IL_029c: Expected O, but got I
			//IL_02ab: Expected O, but got I
			base._002Ector();
			object obj = 50503680;
			nint num = (nint)typeof(Sponge._003C_003Ec__DisplayClass7_0);
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302AB24]");
			if ((uint)((nuint)0u & (nuint)1u) != 0)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X22_v1 (Il2CppClass<Sponge+<>c__DisplayClass7_0>)+378]");
				object obj2 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v44+E0]");
				if ((nint)0 != 0)
				{
					goto IL_0085;
				}
			}
			else
			{
				_ = 1;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X22_v1 (Il2CppClass<Sponge+<>c__DisplayClass7_0>)+378]");
				object obj2 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v44+E0]");
				if ((nint)0 != 0)
				{
					goto IL_0085;
				}
			}
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X22_v1 (Il2CppClass<Sponge+<>c__DisplayClass7_0>)+378]");
			object obj3 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v26+B8]");
			object obj4 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v13+8]");
			global::System.Func<float, float> interpolator = (global::System.Func<float, float>)0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v13+8]");
			if ((nint)0 != 0)
			{
				goto IL_00ca;
			}
			goto IL_02ce;
			IL_01ac:
			nint num2 = (nint)typeof(global::System.Net.Configuration.SettingsSectionInternal);
			object obj5 = (nint)this + 40;
			m_Interpolator = interpolator;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X21_v3 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+B38]");
			object obj6 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v9+B8]");
			object obj7 = 0;
			object obj8 = obj7;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v10+1C]");
			object obj9 = (nint)0 + (nint)1;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v10+10]");
			object obj10 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v10+18]");
			nint num3 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X9_v5+18]");
			if (num3 < 0)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v10+18]");
				object obj11 = (nint)0 + (nint)1;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v10+18]");
				int num4 = (int)((nint)0 << 3);
				object obj12 = (nint)obj10 + num4;
				object obj13 = (nint)obj12 + 32;
				obj13 = this;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
			}
			else
			{
				((global::System.Collections.Generic.List<object>)obj8).Add((object)this);
			}
			return;
			IL_00ca:
			if (this == null)
			{
				throw new global::System.NullReferenceException();
			}
			goto IL_01ac;
			IL_02ce:
			nint num5 = (nint)typeof(global::System.Func<global::UnityEngine.UIElements.ValidateCommandEvent>);
			object obj14 = obj4;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v16 (Il2CppMethodInfo)+2F0]");
			global::System.Func<float, float> func = new global::System.Func<float, float>(obj14, (global::System.IntPtr)0);
			nint num6 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X22_v1 (Il2CppClass<Sponge+<>c__DisplayClass7_0>)+378]");
			object obj15 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v18+B8]");
			object obj16 = (nint)0 + (nint)8;
			obj16 = func;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
			interpolator = func;
			goto IL_01ac;
			IL_0085:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v44+B8]");
			obj4 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v13+8]");
			interpolator = (global::System.Func<float, float>)0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v13+8]");
			if ((nint)0 != 0)
			{
				goto IL_00ca;
			}
			goto IL_02ce;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60004D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1028648", Offset = "0x1028648", Length = "0x28")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv12 = this + 0x10;\n\tthis.m_OnComplete = callback;\n\tv14 = 0xF3F1B4(v12, callback, methodInfo, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28);\n\treturn this;\n// 13 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public virtual global::BFS.Essential.Tween OnComplete(global::System.Action callback)
		{
			//IL_000c: Expected O, but got I
			object obj = (nint)this + 16;
			this.m_OnComplete = callback;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
			return this;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60004D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1028670", Offset = "0x1028670", Length = "0xD8")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv24 = Sponge+<>c__DisplayClass7_0;\n\tgoto L_0020;\n\tv29 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv30 = v29 + 0x2E8;\n\tv31 = \"il2cpp_codegen_initialize_runtime_metadata\"(v30, curve, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tv52 = Il2CppMethodInfo;\n\tv53 = v52 + 0x2F8;\n\tv54 = \"il2cpp_codegen_initialize_runtime_metadata\"(v53, curve, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tv57 = Sponge+<>c__DisplayClass7_0;\n\tv58 = v57 + 0x380;\n\tv47 = \"il2cpp_codegen_initialize_runtime_metadata\"(v58, curve, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tv49 = 1;\n\t*([302AB25]) = v49;\nL_0020:\n\tv51 = new *([v24 @ X22_v1 (Il2CppClass<Sponge+<>c__DisplayClass7_0>)+380])();\n\tSystem.Object::.ctor(v51);\n\tv60 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv62 = Il2CppMethodInfo;\n\tv65 = v51 + 0x10;\n\t*([v51 @ X0_v3 (System.Object)+10]) = curve;\n\tv67 = 0xF3F1B4(v65, curve, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tv70 = new *([v60 @ X22_v3 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+2E8])();\n\tSystem.Func`2<System.Single, System.Single>::.ctor(v70, v51, *([v62 @ X23_v1 (Il2CppMethodInfo)+2F8]));\n\tv92 = this->klass;\n\tv80 = this->klass->vtable[6];\n\tv82 = this->klass->vtable[6];\n\t// 68 IndirectJump v80 @ X3_v2, this @ X0 (BFS.Essential.Tween), this @ X0 (BFS.Essential.Tween), v70 @ X0_v9 (System.Func`2<System.Single, System.Single>), v82 @ X2_v2, v80 @ X3_v2, v34 @ X4, v35 @ X5, v36 @ X6, v37 @ X7, v38 @ V0, v39 @ V1, v40 @ V2, v41 @ V3, v42 @ V4, v43 @ V5, v44 @ V6, v45 @ V7\n\treturnVal1 = new System.NullReferenceException();\n\treturn returnVal1;\n// 43 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public virtual global::BFS.Essential.Tween SetCurve(global::UnityEngine.AnimationCurve curve)
		{
			//IL_000e: Expected I, but got O
			//IL_0021: Expected I, but got O
			//IL_0036: Expected O, but got I
			//IL_0069: Expected I, but got O
			//IL_0079: Expected O, but got I
			//IL_0089: Expected O, but got I
			nint num = (nint)typeof(Sponge._003C_003Ec__DisplayClass7_0);
			while (true)
			{
				object obj = new object();
				nint num2 = (nint)typeof(global::System.Func<global::UnityEngine.UIElements.ValidateCommandEvent>);
				nint num3 = 0;
				object obj2 = (nint)obj + 16;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X23_v1 (Il2CppMethodInfo)+2F8]");
				global::System.Func<float, float> func = new global::System.Func<float, float>(obj, (global::System.IntPtr)0);
				nint num4 = (nint)this;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v3 (Il2CppClass<BFS.Essential.Tween>)+198]");
				object obj3 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v3 (Il2CppClass<BFS.Essential.Tween>)+1A0]");
				object obj4 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v80 @ X3_v2 (should have been resolved before IL gen)");
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60004D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1028750", Offset = "0x1028750", Length = "0x28")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv12 = this + 0x28;\n\tthis.m_Interpolator = interpolator;\n\tv14 = 0xF3F1B4(v12, interpolator, methodInfo, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28);\n\treturn this;\n// 13 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public virtual global::BFS.Essential.Tween SetInterpolator(global::System.Func<float, float> interpolator)
		{
			//IL_000c: Expected O, but got I
			object obj = (nint)this + 40;
			m_Interpolator = interpolator;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
			return this;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60004D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1028778", Offset = "0x1028778", Length = "0xD0")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0018;\n\tv23 = Il2CppMethodInfo;\n\tv24 = v23 + 0x900;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, playOnComplete, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv50 = System.Net.Configuration.SettingsSectionInternal;\n\tv51 = v50 + 0xB38;\n\tv41 = \"il2cpp_codegen_initialize_runtime_metadata\"(v51, playOnComplete, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv43 = 1;\n\t*([302AB26]) = v43;\nL_0018:\n\tv44 = System.Net.Configuration.SettingsSectionInternal;\n\tv47 = this + 0x20;\n\tthis.m_Task = 0;\n\tthis.m_Run = 0;\n\tv49 = 0xF3F1B4(v47, 0, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv52 = ~playOnComplete;\n\tif (v52) goto L_002A;\n\tv53 = this.m_OnComplete;\n\tv54 = this.m_OnComplete == 0;\n\tif (v54) goto L_002A;\n\tv53.invoke_impl(v61, v53.method_code, v53.method, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\nL_002A:\n\tv65 = this + 0x10;\n\tthis.m_OnComplete = 0;\n\tv67 = 0xF3F1B4(v65, 0, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv74 = *([v44 @ X21_v2 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+B38]);\n\tgoto L_0035;\n\tv73 = \"il2cpp_codegen_runtime_class_init\"(v69, v66, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv75 = *([v45 @ X21_v3]);\nL_0035:\n\tv76 = *([v74 @ X0_v10+B8]);\n\tv89 = System.Collections.Generic.List`1<System.Object>::Remove(*([v76 @ X8_v5]), this);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 40 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public virtual void Kill(bool playOnComplete = false)
		{
			//IL_005b: Expected I, but got O
			//IL_0067: Expected O, but got I
			//IL_00a8: Expected O, but got I
			//IL_00c9: Expected O, but got I
			//IL_00de: Expected O, but got I
			nint num = (nint)typeof(global::System.Net.Configuration.SettingsSectionInternal);
			object obj = (nint)this + 32;
			m_Task = null;
			m_Run = false;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
			if (playOnComplete)
			{
				global::System.Action action = this.m_OnComplete;
				if (this.m_OnComplete != null)
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v53.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
			}
			object obj2 = (nint)this + 16;
			this.m_OnComplete = null;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X21_v2 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+B38]");
			object obj3 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v10+B8]");
			object obj4 = 0;
			bool flag = ((global::System.Collections.Generic.List<object>)obj4).Remove((object)this);
		}

		[global::Cpp2ILInjected.Token(Token = "0x60004D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1028848", Offset = "0x1028848", Length = "0x9C")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv16 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv20 = System.Net.Configuration.SettingsSectionInternal;\n\tgoto L_0020;\n\tv25 = Il2CppMethodInfo;\n\tv26 = v25 + 0x8F0;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv50 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv51 = v50 + 0x4B8;\n\tv52 = \"il2cpp_codegen_initialize_runtime_metadata\"(v51, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv55 = System.Net.Configuration.SettingsSectionInternal;\n\tv56 = v55 + 0xB38;\n\tv44 = \"il2cpp_codegen_initialize_runtime_metadata\"(v56, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv47 = 1;\n\t*([302AB27]) = v47;\nL_0020:\n\tv49 = new *([v16 @ X22_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+4B8])();\n\tSystem.Collections.Generic.List`1<System.Object>::.ctor(v49);\n\tv57 = *([v20 @ X20_v1 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+B38]);\n\tv58 = *([v57 @ X8_v3+B8]);\n\t*([v58 @ X8_v4]) = v49;\n\tv59 = *([v20 @ X20_v1 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+B38]);\n\tv68 = 0xF3F1B4(*([v59 @ X8_v5+B8]), v49, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\treturn;\n// 29 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		static Tween()
		{
			//IL_000e: Expected I, but got O
			//IL_001d: Expected I, but got O
			//IL_003d: Expected O, but got I
			//IL_004d: Expected O, but got I
			//IL_0065: Expected O, but got I
			nint num = (nint)typeof(global::System.Collections.Generic.List<global::UnityEngine.UIElements.StyleSheets.Syntax.Expression>);
			nint num2 = (nint)typeof(global::System.Net.Configuration.SettingsSectionInternal);
			object obj = new global::System.Collections.Generic.List<object>();
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X20_v1 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+B38]");
			object obj2 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v3+B8]");
			object obj3 = 0;
			obj3 = obj;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X20_v1 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+B38]");
			object obj4 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		}
	}
}
