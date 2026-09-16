[global::Cpp2ILInjected.Token(Token = "0x20000D1")]
public class Sponge : SpecialFluid
{
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x20000D3")]
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000474")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public int i;

		[global::Cpp2ILInjected.Token(Token = "0x4000475")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public Sponge _003C_003E4__this;

		[global::Cpp2ILInjected.Token(Token = "0x60003BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x10171C0", Offset = "0x10171C0", Length = "0x8")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tSystem.Object::.ctor(this);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public _003C_003Ec__DisplayClass7_0()
		{
		}

		internal global::UnityEngine.Vector2 _003CSuckUpWater_003Eb__0()
		{
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Expected O, but got Unknown
			//IL_0050: Expected F4, but got O
			//IL_0065: Expected F4, but got I
			Sponge sponge = _003C_003E4__this;
			FluidSolver solver = sponge.solver;
			global::Unity.Mathematics.float2 float5 = solver.positions[i];
			return float5;
		}

		internal void _003CSuckUpWater_003Eb__1(global::UnityEngine.Vector2 x)
		{
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Expected O, but got Unknown
			Sponge sponge = _003C_003E4__this;
			FluidSolver solver = sponge.solver;
			global::Unity.Mathematics.float2 float5 = x;
			solver.positions[i] = float5;
		}
	}

	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x20000D4")]
	private sealed class _003CSuckUpWater_003Ed__7 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000476")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[global::Cpp2ILInjected.Token(Token = "0x4000477")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[global::Cpp2ILInjected.Token(Token = "0x4000478")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public Water w;

		[global::Cpp2ILInjected.Token(Token = "0x4000479")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public Sponge _003C_003E4__this;

		[global::Cpp2ILInjected.Token(Token = "0x1700003F")]
		object global::System.Collections.Generic.IEnumerator<object>.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60003C4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1017954", Offset = "0x1017954", Length = "0x8")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn this.<>2__current;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
			get
			{
				return _003C_003E2__current;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000040")]
		object global::System.Collections.IEnumerator.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60003C6")]
			[global::Cpp2ILInjected.Address(RVA = "0x101799C", Offset = "0x101799C", Length = "0x8")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn this.<>2__current;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
			get
			{
				return _003C_003E2__current;
			}
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x60003C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1017010", Offset = "0x1017010", Length = "0x2C")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tSystem.Object::.ctor(this);\n\tthis.<>1__state = <>1__state;\n\treturn;\n// 14 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public _003CSuckUpWater_003Ed__7(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x60003C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1017244", Offset = "0x1017244", Length = "0x4")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn;\n")]
		void global::System.IDisposable.Dispose()
		{
		}

		[global::Cpp2ILInjected.Token(Token = "0x60003C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1017248", Offset = "0x1017248", Length = "0x70C")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0059;\n\tv41 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv42 = v41 + 0x2B0;\n\tv43 = \"il2cpp_codegen_initialize_runtime_metadata\"(v42, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58);\n\tv78 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv79 = v78 + 0x300;\n\tv80 = \"il2cpp_codegen_initialize_runtime_metadata\"(v79, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58);\n\tv87 = System.ComponentModel.BooleanConverter;\n\tv88 = v87 + 0x7D8;\n\tv89 = \"il2cpp_codegen_initialize_runtime_metadata\"(v88, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58);\n\tv262 = Il2CppMethodInfo;\n\tv263 = v262 + 0x968;\n\tv264 = \"il2cpp_codegen_initialize_runtime_metadata\"(v263, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58);\n\tv398 = Il2CppMethodInfo;\n\tv399 = v398 + 0x970;\n\tv400 = \"il2cpp_codegen_initialize_runtime_metadata\"(v399, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58);\n\tv416 = Il2CppMethodInfo;\n\tv417 = v416 + 0x978;\n\tv418 = \"il2cpp_codegen_initialize_runtime_metadata\"(v417, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58);\n\tv559 = Il2CppMethodInfo;\n\tv560 = v559 + 0x980;\n\tv561 = \"il2cpp_codegen_initialize_runtime_metadata\"(v560, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58);\n\tv608 = Il2CppMethodInfo;\n\tv609 = v608 + 0x998;\n\tv610 = \"il2cpp_codegen_initialize_runtime_metadata\"(v609, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58);\n\tv678 = Il2CppMethodInfo;\n\tv679 = v678 + 0x968;\n\tv680 = \"il2cpp_codegen_initialize_runtime_metadata\"(v679, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58);\n\tv707 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv708 = v707 + 0x5D8;\n\tv709 = \"il2cpp_codegen_initialize_runtime_metadata\"(v708, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58);\n\tv733 = Il2CppMethodInfo;\n\tv734 = v733 + 0xC28;\n\tv735 = \"il2cpp_codegen_initialize_runtime_metadata\"(v734, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58);\n\tv743 = System.Net.Configuration.SettingsSectionInternal;\n\tv744 = v743 + 0xB48;\n\tv745 = \"il2cpp_codegen_initialize_runtime_metadata\"(v744, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58);\n\tv753 = Il2CppMethodInfo;\n\tv754 = v753 + 0xF08;\n\tv755 = \"il2cpp_codegen_initialize_runtime_metadata\"(v754, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58);\n\tv757 = Il2CppMethodInfo;\n\tv758 = v757 + 0xF88;\n\tv759 = \"il2cpp_codegen_initialize_runtime_metadata\"(v758, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58);\n\tv765 = Il2CppMethodInfo;\n\tv766 = v765 + 0xFC8;\n\tv767 = \"il2cpp_codegen_initialize_runtime_metadata\"(v766, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58);\n\tv769 = Il2CppMethodInfo;\n\tv770 = v769 + 0xFD0;\n\tv771 = \"il2cpp_codegen_initialize_runtime_metadata\"(v770, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58);\n\tv776 = Il2CppMethodInfo;\n\tv777 = v776 + 0xFD8;\n\tv778 = \"il2cpp_codegen_initialize_runtime_metadata\"(v777, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58);\n\tv780 = Sponge+<>c__DisplayClass7_0;\n\tv781 = v780 + 0;\n\tv782 = \"il2cpp_codegen_initialize_runtime_metadata\"(v781, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58);\n\tv783 = TMPro.KerningTable+<>c__DisplayClass3_0;\n\tv784 = v783 + 0xFF8;\n\tv60 = \"il2cpp_codegen_initialize_runtime_metadata\"(v784, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58);\n\tv62 = 1;\n\t*([302AA92]) = v62;\nL_0059:\n\tv68 = this.<>4__this;\n\tv73 = this.<>1__state == 1;\n\tif (v73) goto L_00A8;\n\tv82 = this.<>1__state == 0;\n\tv83 = ~v82;\n\tif (v83) goto L_01A5;\n\tthis.<>1__state = 0xFFFFFFFF;\n\tv91 = this.w;\n\tv406 = System.Collections.Generic.HashSet`1<System.Int32>::GetEnumerator(v91.particleIds);\n\tv421 = this.<>4__this == 0;\n\tif (v421) goto L_0167;\n\tv562 = Il2CppMethodInfo;\n\tv563 = Il2CppMethodInfo;\nL_0082:\n\tv336 = *([v562 @ X21_v24 (Il2CppMethodInfo)+970]);\n\tv621 = System.Collections.Generic.HashSet`1+Enumerator::MoveNext /* +1 sharing this address */(&v351 @ stack_-C0_v9 (UnityEngine.Vector2), *([v562 @ X21_v24 (Il2CppMethodInfo)+970]));\n\tv681 = v621 & 1;\n\tv682 = v681 == 0;\n\tif (v682) goto L_016F;\n\tv541 = v68.solver == 0;\n\tif (v541) goto L_01B8;\n\tv736 = v68.solver + 0x1F8;\n\tv320 = *([v563 @ X22_v16 (Il2CppMethodInfo)+C28]);\n\tv614 = Unity.Collections.NativeHashMap`2::TryGetValue /* +1 sharing this address */(v736, v410, &v493 @ stack_-A4_v11, *([v563 @ X22_v16 (Il2CppMethodInfo)+C28]));\n\tv746 = v614 & 1;\n\tv617 = v746 == 0;\n\tif (v617) goto L_0082;\n\tv551 = v68.solver;\n\tv543 = v68.solver == 0;\n\tif (v543) goto L_01BC;\n\tv485 = v493 << 3;\n\tv761 = v551.positions + v485;\n\t// 157 MakeStruct v477 @ AGG1017434_0_v10 (Unity.Mathematics.float2), typeof(Unity.Mathematics.float2), [v761 @ X8_v83], [v761 @ X8_v83+4]\n\tv177 = Unity.Mathematics.float2::op_Implicit(v477);\n\tv310 = v177.y;\n\tv552 = v68.solver;\n\tv544 = v68.solver == 0;\n\tif (v544) goto L_01BE;\n\tv619 = v552.isSimulated;\n\t*([v619 @ X8_v85 (Unity.Collections.NativeArray`1<System.Boolean>)+v493 @ stack_-A4_v11]) = 0;\n\tgoto L_0082;\nL_00A8:\n\tthis.<>1__state = 0xFFFFFFFF;\n\tv85 = this.w;\n\tv352 = System.Collections.Generic.HashSet`1<System.Int32>::GetEnumerator(v85.particleIds);\n\tv415 = this.<>4__this == 0;\n\tif (v415) goto L_017C;\n\tv422 = Il2CppMethodInfo;\n\tv424 = Sponge+<>c__DisplayClass7_0;\n\tv426 = Il2CppMethodInfo;\n\tv430 = TMPro.KerningTable+<>c__DisplayClass3_0;\n\tv432 = Il2CppMethodInfo;\n\tgoto L_00D0;\nL_00CA:\n\tv318 = *([v432 @ X27_v10 (Il2CppMethodInfo)+F08]);\n\tv583 = DG.Tweening.TweenSettingsExtensions::OnComplete /* +1 sharing this address */(v833, v577, *([v432 @ X27_v10 (Il2CppMethodInfo)+F08]));\nL_00D0:\n\tv594 = System.Collections.Generic.HashSet`1+Enumerator::MoveNext /* +1 sharing this address */(&v351 @ stack_-C0_v9 (UnityEngine.Vector2), *([v422 @ X23_v10 (Il2CppMethodInfo)+970]));\n\tv623 = v594 & 1;\n\tv624 = v623 == 0;\n\tif (v624) goto L_0160;\n\tv740 = new *([v424 @ X24_v10 (Il2CppClass<Sponge+<>c__DisplayClass7_0>)])();\n\tSystem.Object::.ctor(v740);\n\tv737 = v740 == 0;\n\tif (v737) goto L_01CF;\n\tv748 = v740 + 0x18;\n\t*([v740 @ X0_v29 (System.Object)+18]) = this.<>4__this;\n\tv749 = 0xF3F1B4(v748, this.<>4__this, v318, v320, v47, v48, v49, v50, v332, v310, v288, v54, v55, v56, v57, v58);\n\tv542 = v68.solver == 0;\n\tif (v542) goto L_01BA;\n\tv764 = v68.solver + 0x1F8;\n\tv318 = v740 + 0x10;\n\tv320 = *([v426 @ X25_v10 (Il2CppMethodInfo)+C28]);\n\tv584 = Unity.Collections.NativeHashMap`2::TryGetValue /* +1 sharing this address */(v764, v410, v318, *([v426 @ X25_v10 (Il2CppMethodInfo)+C28]));\n\tv768 = v584 & 1;\n\tv587 = v768 == 0;\n\tif (v587) goto L_00D0;\n\tv772 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv775 = new *([v772 @ X8_v31 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+5D8])();\n\tv779 = Il2CppMethodInfo;\n\tSystem.Collections.Generic.HashSet`1::.ctor /* +1 sharing this address */(v775, *([v779 @ X8_v33 (Il2CppMethodInfo)+968]));\n\tv545 = v775 == 0;\n\tif (v545) goto L_01C0;\n\tv785 = Il2CppMethodInfo;\n\tv790 = System.Collections.Generic.HashSet`1::Add /* +1 sharing this address */(v775, v410, *([v785 @ X8_v35 (Il2CppMethodInfo)+980]));\n\tv791 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv794 = new *([v791 @ X8_v37 (Il2CppClass<System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>>)+2B0])();\n\tv796 = Il2CppMethodInfo;\n\tDG.Tweening.Core.DOGetter`1<UnityEngine.Vector2>::.ctor(v794, v740, *([v796 @ X8_v39 (Il2CppMethodInfo)+FD0]));\n\tv801 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv804 = new *([v801 @ X8_v41 (Il2CppClass<System.Linq.Expressions.Interpreter.C\n// ... truncated")]
		private bool MoveNext()
		{
			//IL_0955: Expected I, but got O
			//IL_025c: Expected I, but got O
			//IL_0270: Expected I, but got O
			//IL_074e: Expected O, but got I
			//IL_09a0: Expected O, but got I
			//IL_0643: Expected O, but got I
			//IL_06c5: Expected O, but got I
			//IL_0b44: Expected O, but got I
			//IL_033a: Expected O, but got I
			//IL_0a85: Expected O, but got I
			//IL_0acf: Expected I4, but got O
			//IL_0381: Expected O, but got I
			//IL_0390: Expected O, but got I
			//IL_03a0: Expected O, but got I
			//IL_00d3: Expected O, but got I
			//IL_00e3: Expected O, but got I
			//IL_03e4: Expected I, but got O
			//IL_08b2: Expected O, but got I
			//IL_016c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0171: Expected O, but got Unknown
			//IL_017e: Expected F4, but got O
			//IL_0193: Expected F4, but got I
			//IL_0439: Expected I, but got O
			//IL_090e: Expected O, but got I
			//IL_046c: Expected I, but got O
			//IL_051a: Expected O, but got I
			//IL_05ad: Expected O, but got I
			//IL_05bd: Expected O, but got I
			//IL_05cd: Expected O, but got I
			//IL_05f8: Expected O, but got I4
			//IL_0293: Expected O, but got I
			//IL_054f: Expected O, but got I
			//IL_055f: Expected O, but got I
			//IL_058a: Expected O, but got I4
			//IL_0b88: Expected I, but got O
			//IL_0bb8: Expected O, but got I
			//IL_0bce: Expected O, but got I
			//IL_0614: Expected O, but got I4
			SpecialFluid specialFluid = _003C_003E4__this;
			global::UnityEngine.Vector2 vector2 = default(global::UnityEngine.Vector2);
			object obj6 = default(object);
			global::UnityEngine.Vector2 vector;
			global::System.NullReferenceException ex;
			int num;
			SpecialFluid specialFluid2 = default(SpecialFluid);
			float y = default(float);
			object obj5 = default(object);
			object obj3 = default(object);
			float num24 = default(float);
			float num31 = default(float);
			float num32 = default(float);
			object obj26 = default(object);
			object obj27 = default(object);
			SpecialFluid specialFluid3 = default(SpecialFluid);
			if (_003C_003E1__state != 1)
			{
				bool flag = _003C_003E1__state == 0;
				bool flag2 = !flag;
				num = 0;
				if (!flag2)
				{
					_003C_003E1__state = -1;
					Water water = w;
					global::System.Collections.Generic.HashSet<int>.Enumerator enumerator = water.particleIds.GetEnumerator();
					if ((object)_003C_003E4__this != null)
					{
						nint num2 = 0;
						nint num3 = 0;
						vector = vector2;
						object obj = default(object);
						object obj4 = default(object);
						global::Unity.Mathematics.float2 float5 = default(global::Unity.Mathematics.float2);
						while (true)
						{
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X21_v24 (Il2CppMethodInfo)+970]");
							specialFluid2 = null;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C8 (System.Collections.Generic.HashSet`1+Enumerator::MoveNext, and 1 more at this address)");
							if ((int)((nint)obj & 1) == 0)
							{
								break;
							}
							if ((object)specialFluid.solver == null)
							{
								goto IL_07f1;
							}
							object obj2 = (nint)specialFluid.solver + 504;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X22_v16 (Il2CppMethodInfo)+C28]");
							obj3 = 0;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17E754C (Unity.Collections.NativeHashMap`2::TryGetValue, and 1 more at this address)");
							int num4 = (int)((nint)obj4 & 1);
							bool flag3 = num4 == 0;
							obj5 = obj6;
							if (flag3)
							{
								continue;
							}
							FluidSolver solver = specialFluid.solver;
							if ((object)specialFluid.solver == null)
							{
								goto IL_0881;
							}
							int num5 = (int)((nint)obj6 << 3);
							object obj7 = solver.positions + num5;
							float5.x = (float)obj7;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v761 @ X8_v83+4]");
							float5.y = 0f;
							vector = float5;
							y = vector.y;
							FluidSolver solver2 = specialFluid.solver;
							if ((object)specialFluid.solver != null)
							{
								global::Unity.Collections.NativeArray<bool> isSimulated = solver2.isSimulated;
								_ = 0;
								obj5 = obj6;
								continue;
							}
							goto IL_08d8;
						}
					}
					else
					{
						nint num6 = 0;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C8 (System.Collections.Generic.HashSet`1+Enumerator::MoveNext, and 1 more at this address)");
						object obj8 = default(object);
						bool flag4 = obj8 == null;
						bool flag5 = !flag4;
						vector = vector2;
						if (flag5)
						{
							ex = new global::System.NullReferenceException();
							goto IL_0a02;
						}
					}
					nint num7 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C4 (System.Collections.Generic.HashSet`1+Enumerator::Dispose, and 1 more at this address)");
					object obj9 = (nint)this + 24;
					_003C_003E2__current = null;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
					_003C_003E1__state = 1;
					num = 1;
				}
				goto IL_0b21;
			}
			_003C_003E1__state = -1;
			Water water2 = w;
			global::System.Collections.Generic.HashSet<int>.Enumerator enumerator2 = water2.particleIds.GetEnumerator();
			object obj11;
			int num26;
			global::UnityEngine.Vector2 vector3;
			if ((object)_003C_003E4__this != null)
			{
				nint num8 = 0;
				nint num9 = 0;
				nint num10 = 0;
				nint num11 = 0;
				nint num12 = 0;
				vector3 = vector2;
				object obj10 = default(object);
				object obj14 = default(object);
				global::UnityEngine.Vector2 endValue = default(global::UnityEngine.Vector2);
				while (true)
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C8 (System.Collections.Generic.HashSet`1+Enumerator::MoveNext, and 1 more at this address)");
					if ((int)((nint)obj10 & 1) == 0)
					{
						break;
					}
					obj11 = new object();
					float num20;
					if (obj11 != null)
					{
						object obj12 = (nint)obj11 + 24;
						_ = _003C_003E4__this;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
						if ((object)specialFluid.solver != null)
						{
							object obj13 = (nint)specialFluid.solver + 504;
							obj5 = (nint)obj11 + 16;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X25_v10 (Il2CppMethodInfo)+C28]");
							obj3 = 0;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17E754C (Unity.Collections.NativeHashMap`2::TryGetValue, and 1 more at this address)");
							if ((int)((nint)obj14 & 1) == 0)
							{
								continue;
							}
							nint num13 = 0;
							object obj15 = null;
							nint num14 = 0;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @15C269C (System.Collections.Generic.HashSet`1::.ctor, and 1 more at this address)");
							if (obj15 != null)
							{
								nint num15 = 0;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @15C3C78 (System.Collections.Generic.HashSet`1::Add, and 1 more at this address)");
								nint num16 = 0;
								object obj16 = obj11;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v796 @ X8_v39 (Il2CppMethodInfo)+FD0]");
								global::DG.Tweening.Core.DOGetter<global::UnityEngine.Vector2> getter = new global::DG.Tweening.Core.DOGetter<global::UnityEngine.Vector2>(obj16, (global::System.IntPtr)0);
								nint num17 = 0;
								nint num18 = 0;
								object obj17 = obj11;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v806 @ X8_v43 (Il2CppMethodInfo)+FD8]");
								global::DG.Tweening.Core.DOSetter<global::UnityEngine.Vector2> setter = new global::DG.Tweening.Core.DOSetter<global::UnityEngine.Vector2>(obj17, (global::System.IntPtr)0);
								nint num19 = 0;
								num20 = global::UnityEngine.Random.Range(0.15f, 0.3f);
								endValue.x = specialFluid.position.x;
								endValue.y = specialFluid.position.y;
								global::DG.Tweening.Core.TweenerCore<global::UnityEngine.Vector2, global::UnityEngine.Vector2, global::DG.Tweening.Plugins.Options.VectorOptions> tweenerCore = global::DG.Tweening.DOTween.To(getter, setter, endValue, num20);
								nint num21 = 0;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B1590 (DG.Tweening.TweenSettingsExtensions::SetEase, and 1 more at this address)");
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X26_v10 (Il2CppClass<TMPro.KerningTable+<>c__DisplayClass3_0>)+FF8]");
								object obj18 = 0;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v834 @ X0_v66+E0]");
								object obj19;
								global::DG.Tweening.TweenCallback tweenCallback;
								if ((nint)0 != 0)
								{
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v834 @ X0_v66+B8]");
									obj19 = 0;
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v867 @ X8_v54+8]");
									tweenCallback = (global::DG.Tweening.TweenCallback)0;
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v867 @ X8_v54+8]");
									bool flag6 = (nint)0 == 0;
									bool flag7 = !flag6;
									obj3 = 0;
									if (flag7)
									{
										goto IL_0283;
									}
								}
								else
								{
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X26_v10 (Il2CppClass<TMPro.KerningTable+<>c__DisplayClass3_0>)+FF8]");
									object obj20 = 0;
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v852 @ X0_v76+B8]");
									obj19 = 0;
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v867 @ X8_v54+8]");
									tweenCallback = (global::DG.Tweening.TweenCallback)0;
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v867 @ X8_v54+8]");
									bool flag8 = (nint)0 == 0;
									bool flag9 = !flag8;
									obj3 = 0;
									if (flag9)
									{
										goto IL_0283;
									}
								}
								nint num22 = 0;
								object obj21 = obj19;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v874 @ X8_v57 (Il2CppMethodInfo)+FC8]");
								global::DG.Tweening.TweenCallback tweenCallback2 = new global::DG.Tweening.TweenCallback(obj21, (global::System.IntPtr)0);
								nint num23 = 0;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X26_v10 (Il2CppClass<TMPro.KerningTable+<>c__DisplayClass3_0>)+FF8]");
								object obj22 = 0;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v857 @ X8_v59+B8]");
								object obj23 = (nint)0 + (nint)8;
								obj23 = tweenCallback2;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
								obj3 = 0;
								tweenCallback = tweenCallback2;
								goto IL_0283;
							}
							throw obj15;
						}
						goto IL_0838;
					}
					goto IL_098c;
					IL_0283:
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X27_v10 (Il2CppMethodInfo)+F08]");
					obj5 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B0CBC (DG.Tweening.TweenSettingsExtensions::OnComplete, and 1 more at this address)");
					num24 = num20;
					y = specialFluid.position.y;
					vector3 = specialFluid.position;
				}
				nint num25 = 0;
				num = (int)((nint)0 + (nint)2408);
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v695 @ X8_v28 (Il2CppMethodInfo)+968]");
				specialFluid2 = null;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C4 (System.Collections.Generic.HashSet`1+Enumerator::Dispose, and 1 more at this address)");
				num26 = 10;
				goto IL_0777;
			}
			nint num27 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C8 (System.Collections.Generic.HashSet`1+Enumerator::MoveNext, and 1 more at this address)");
			object obj24 = default(object);
			int num29;
			if (obj24 == null)
			{
				nint num28 = 0;
				num = (int)((nint)0 + (nint)2408);
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v628 @ X8_v25 (Il2CppMethodInfo)+968]");
				specialFluid2 = null;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C4 (System.Collections.Generic.HashSet`1+Enumerator::Dispose, and 1 more at this address)");
				num26 = 10;
				vector3 = vector2;
				num29 = 0;
				goto IL_0add;
			}
			nint num30 = 0;
			obj11 = new object();
			if (obj11 == null)
			{
				goto IL_098c;
			}
			object obj25 = (nint)obj11 + 24;
			_ = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
			ex = new global::System.NullReferenceException();
			num31 = num24;
			num32 = y;
			obj26 = obj5;
			obj27 = obj3;
			object obj28 = vector2;
			vector3 = vector2;
			num29 = 0;
			specialFluid2 = null;
			goto IL_0a02;
			IL_0838:
			ex = new global::System.NullReferenceException();
			num31 = num24;
			num32 = y;
			obj26 = obj5;
			obj27 = obj3;
			obj28 = vector2;
			num29 = 0;
			specialFluid2 = _003C_003E4__this;
			goto IL_0a02;
			IL_0a02:
			bool flag10 = true;
			num24 = num31;
			y = num32;
			obj5 = obj26;
			obj3 = obj27;
			global::System.OutOfMemoryException ex2 = (global::System.OutOfMemoryException)(object)ex;
			if (!flag10)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A080 (inside System.__Il2CppComDelegate::Finalize +0xF54)");
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A098 (inside System.__Il2CppComDelegate::Finalize +0xF6C)");
				nint num33 = 0;
				num = (int)((nint)0 + (nint)2408);
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v732 @ X8_v7 (Il2CppMethodInfo)+968]");
				specialFluid2 = null;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C4 (System.Collections.Generic.HashSet`1+Enumerator::Dispose, and 1 more at this address)");
				object obj29 = default(object);
				bool flag11 = obj29 == null;
				num26 = 0;
				num24 = num31;
				y = num32;
				obj5 = obj26;
				obj3 = obj27;
				num29 = (int)obj29;
				if (flag11)
				{
					goto IL_0777;
				}
				goto IL_0add;
			}
			goto IL_0be5;
			IL_0881:
			ex = new global::System.NullReferenceException();
			num31 = num24;
			num32 = y;
			obj26 = obj6;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X22_v16 (Il2CppMethodInfo)+C28]");
			obj27 = 0;
			obj28 = vector2;
			vector3 = vector;
			num29 = 0;
			specialFluid3 = default(SpecialFluid);
			specialFluid2 = specialFluid3;
			goto IL_0a02;
			IL_08d8:
			ex = new global::System.NullReferenceException();
			num31 = num24;
			num32 = vector.y;
			obj26 = obj6;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X22_v16 (Il2CppMethodInfo)+C28]");
			obj27 = 0;
			obj28 = vector2;
			vector3 = vector;
			num29 = 0;
			specialFluid2 = specialFluid3;
			goto IL_0a02;
			IL_0b21:
			return (byte)(num & 1) != 0;
			IL_0777:
			if (num26 == 10 || num26 == 0)
			{
				global::System.Collections.IEnumerator routine = _003C_003E4__this.HandlePopIn();
				global::UnityEngine.Coroutine coroutine = _003C_003E4__this.StartCoroutine(routine);
				num = 0;
			}
			goto IL_0b21;
			IL_0be5:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BF092C");
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27498DC (inside System.__Il2CppComDelegate::Finalize +0x7B0)");
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D6F8");
			bool result = default(bool);
			return result;
			IL_0add:
			global::System.OutOfMemoryException ex3 = new global::System.OutOfMemoryException();
			ex2 = ex3;
			goto IL_0be5;
			IL_07f1:
			ex = new global::System.NullReferenceException();
			num31 = num24;
			num32 = y;
			obj26 = obj5;
			obj27 = obj3;
			obj28 = vector2;
			vector3 = vector;
			num29 = 0;
			goto IL_0a02;
			IL_098c:
			throw obj11;
		}

		bool global::System.Collections.IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x60003C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x101795C", Offset = "0x101795C", Length = "0x40")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv10 = Facebook.Unity.Windows.IWindowsFacebook + 0xF30;\n\tv11 = 0xF3F22C(v10, methodInfo, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26);\n\tv27 = new v11();\n\tSystem.NotSupportedException::.ctor(v27);\n\tv31 = Il2CppMethodInfo + 0xFE0;\n\tv32 = 0xF3F22C(v31, 0, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26);\n\tthrow v27;\n// 13 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		void global::System.Collections.IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0039: Expected O, but got I
			object obj = typeof(global::Facebook.Unity.Windows.IWindowsFacebook) + 3888;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F22C");
			global::System.NotSupportedException ex = new global::System.NotSupportedException();
			object obj2 = (nint)0 + (nint)4064;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F22C");
			throw ex;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x400046E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	private readonly global::System.Collections.Generic.Dictionary<int, global::UnityEngine.Vector2> prevOffset;

	[global::Cpp2ILInjected.Token(Token = "0x400046F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public float zRotation;

	[global::Cpp2ILInjected.Token(Token = "0x4000470")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	private global::System.Collections.Generic.HashSet<int> removedParticles;

	[global::Cpp2ILInjected.Token(Token = "0x4000471")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	private bool isCleared;

	[global::Cpp2ILInjected.Token(Token = "0x60003B5")]
	[global::Cpp2ILInjected.Address(RVA = "0x10163E8", Offset = "0x10163E8", Length = "0xC")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tthis.id = _id;\n\tSpecialFluid::Init(this, _solver, _particleIds, _fluidType, _compute);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void Init(FluidSolver _solver, global::System.Collections.Generic.HashSet<int> _particleIds, int _fluidType, FluidCompute _compute, int _id)
	{
		id = _id;
		base.Init(_solver, _particleIds, _fluidType, _compute);
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003B6")]
	[global::Cpp2ILInjected.Address(RVA = "0x10163F4", Offset = "0x10163F4", Length = "0x8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tthis.isCleared = 0;\n\treturn;\n")]
	private void Start()
	{
		isCleared = false;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003B7")]
	[global::Cpp2ILInjected.Address(RVA = "0x10163FC", Offset = "0x10163FC", Length = "0xB88")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0061;\n\tv49 = System.Collections.Generic.NullableComparer`1;\n\tv50 = v49 + 0xD10;\n\tv51 = \"il2cpp_codegen_initialize_runtime_metadata\"(v50, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv86 = Il2CppMethodInfo;\n\tv87 = v86 + 0x530;\n\tv88 = \"il2cpp_codegen_initialize_runtime_metadata\"(v87, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv90 = Il2CppMethodInfo;\n\tv91 = v90 + 0x538;\n\tv92 = \"il2cpp_codegen_initialize_runtime_metadata\"(v91, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv138 = Il2CppMethodInfo;\n\tv139 = v138 + 0xED8;\n\tv140 = \"il2cpp_codegen_initialize_runtime_metadata\"(v139, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv315 = Il2CppMethodInfo;\n\tv316 = v315 + 0x968;\n\tv317 = \"il2cpp_codegen_initialize_runtime_metadata\"(v316, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv512 = Il2CppMethodInfo;\n\tv513 = v512 + 0x970;\n\tv514 = \"il2cpp_codegen_initialize_runtime_metadata\"(v513, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv636 = Il2CppMethodInfo;\n\tv637 = v636 + 0xEE0;\n\tv638 = \"il2cpp_codegen_initialize_runtime_metadata\"(v637, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv829 = Il2CppMethodInfo;\n\tv830 = v829 + 0x978;\n\tv831 = \"il2cpp_codegen_initialize_runtime_metadata\"(v830, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv1094 = Il2CppMethodInfo;\n\tv1095 = v1094 + 0xEE8;\n\tv1096 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1095, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv1099 = Il2CppMethodInfo;\n\tv1100 = v1099 + 0x990;\n\tv1101 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1100, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv1148 = Il2CppMethodInfo;\n\tv1149 = v1148 + 0x998;\n\tv1150 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1149, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv1174 = Il2CppMethodInfo;\n\tv1175 = v1174 + 0x9B0;\n\tv1176 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1175, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv1180 = Il2CppMethodInfo;\n\tv1181 = v1180 + 0x18;\n\tv1182 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1181, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv1190 = Il2CppMethodInfo;\n\tv1191 = v1190 + 0xD00;\n\tv1192 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1191, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv1204 = Il2CppMethodInfo;\n\tv1205 = v1204 + 0xC28;\n\tv1206 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1205, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv1213 = Il2CppMethodInfo;\n\tv1214 = v1213 + 0xC68;\n\tv1215 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1214, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv1308 = Il2CppMethodInfo;\n\tv1309 = v1308 + 0xC90;\n\tv1310 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1309, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv1386 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv1387 = v1386 + 0xA48;\n\tv1388 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1387, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv1400 = Il2CppMethodInfo;\n\tv1401 = v1400 + 0xB90;\n\tv1402 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1401, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv1428 = \"Writing object reference to Id '{0}' for {1}.\";\n\tv1429 = v1428 + 0x8C8;\n\tv1430 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1429, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv1449 = \"Writing object reference to Id '{0}' for {1}.\";\n\tv1450 = v1449 + 0x980;\n\tv1451 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1450, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv1462 = CollectParticleData[];\n\tv1463 = v1462 + 0x718;\n\tv68 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1463, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv70 = 1;\n\t*([302AAC2]) = v70;\nL_0061:\n\tv71 = 0;\n\tv85 = UnityEngine.Input::GetKeyDown(0x73);\n\tv89 = ~v85;\n\tif (v89) goto L_00A1;\n\tv93 = CollectParticleData[];\n\tv99 = \"SzArrayNew\"(*([v93 @ X8_v106 (Il2CppClass<CollectParticleData[]>)+718]), 1, v896, v895, v100, v56, v57, v58, v59, v900, v61, v62, v644, v64, v65, v66);\n\t// 125 MakeStruct v111 @ AGG10165A4_0_v10 (UnityEngine.Vector2), typeof(UnityEngine.Vector2), this.position (UnityEngine.Vector2), this.position.y (System.Single)\n\tv116 = Unity.Mathematics.float2::op_Implicit(v111);\n\tv900 = v116.y;\n\t*([v99 @ X0_v144 (Unity.Mathematics.float2[])+20]) = v116;\n\t*([v99 @ X0_v144 (Unity.Mathematics.float2[])+24]) = v116.y;\n\tv639 = System.Collections.Generic.NullableComparer`1;\n\tv481 = new *([v639 @ X8_v109 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+D10])();\n\tv832 = Il2CppMethodInfo;\n\tSystem.Action`1<ParticleInitData>::.ctor(v481, this, *([v832 @ X8_v111 (Il2CppMethodInfo)+B90]));\n\tv1105 = FluidSolver::AddParticles(this.solver, v99, this.fluidType, v481);\n\tv1151 = Il2CppMethodInfo;\n\tv896 = *([v1151 @ X8_v113 (Il2CppMethodInfo)+18]);\n\tUnity.VisualScripting.LinqUtility::AddRange /* +1 sharing this address */(this.particleIds, v1105, *([v1151 @ X8_v113 (Il2CppMethodInfo)+18]));\nL_00A1:\n\tv129 = Il2CppMethodInfo;\n\tv130 = Il2CppMethodInfo + 0x970;\n\tv131 = Il2CppMethodInfo;\n\tv132 = Il2CppMethodInfo + 0xC28;\n\tv133 = &v71 @ stack_-D0_v1;\n\tv136 = Facebook.Unity.Windows.IWindowsFacebook + 0x918;\n\tv137 = ~this.isCleared;\n\tif (v137) goto L_0219;\nL_00AD:\n\tSpecialFluid::OnPreComputeUpdate(this);\n\tv321 = UnityEngine.Camera::get_main();\n\tv780 = this.solver + 0x3A8;\n\tv781 = Unity.Collections.NativeHashMap`2<System.Int32, Unity.Mathematics.float2>::get_Item(v780, this.id);\n\tv457 = Unity.Mathematics.float2::op_Implicit(v781);\n\t// 197 MakeStruct v418 @ AGG1016694_1_v9 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), v457 @ V0_v10 (UnityEngine.Vector2), v457.y (System.Single), 0\n\tv458 = UnityEngine.Camera::WorldToViewportPoint(v321, v418);\n\tv1177 = \"Writing object reference to Id '{0}' for {1}.\";\n\t// 209 MakeStruct v412 @ AGG10166B4_2_v9 (UnityEngine.Vector4), typeof(UnityEngine.Vector4), v458 @ V0_v11 (UnityEngine.Vector3), v458.y (System.Single), v458.z (System.Single), 0\n\tUnityEngine.MaterialPropertyBlock::SetVector(this._propBlock, *([v1177 @ X8_v14 (System.String)+980]), v412);\n\tUnityEngine.Renderer::SetPropertyBlock(this.mr, this._propBlock);\n\tv485 = UnityEngine.Component::get_transform(this);\n\tv1313 = UnityEngine.Transform::get_position(v485);\n\tgoto L_00F0;\n\tv1403 = System.Xml.ValidateNames;\n\tv1404 = v1403 + 0xD0;\n\tv1405 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1404, v1312, v440, v282, v280, v56, v57, v58, v1313, v1389, v1390, v414, v147, v64, v65, v66);\n\tv1408 = 1;\n\t*([2DD4413]) = v1408;\nL_00F0:\n\tv1409 = System.Xml.ValidateNames;\n\tv1411 = *([v1409 @ X8_v18 (Il2CppClass<System.Xml.ValidateNames>)+D0]);\n\tv1412 = *([v1411 @ X8_v20+B8]);\n\tv1420 = this.id * 0x36A7C5AC;\n\tv887 = v1420 + -2f;\n\tv1421 = *([v1412 @ X8_v21+48]) * v887;\n\tv1422 = *([v1412 @ X8_v21+4C]) * v887;\n\tv1423 = *([v1412 @ X8_v21+50]) * v887;\n\tv459 = v1313 + v1421;\n\tv760 = v1313.y + v1422;\n\tv889 = v1313.z + v1423;\n\t// 263 MakeStruct v329 @ AGG101676C_1_v9 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), v459 @ V0_v15 (System.Single), v760 @ V1_v2 (System.Single), v889 @ V2_v3 (System.Single)\n\tUnityEngine.Transform::set_position(v485, v329);\n\tv1452 = Il2CppMethodInfo;\n\tv1453 = Il2CppMethodInfo;\n\tv1459 = System.Collections.Generic.HashSet`1<System.Int32>::GetEnumerator(this.particleIds);\n\t*([v286 @ X24_v10]) = v1458;\nL_0125:\n\t;\n\tv1484 = System.Collections.Generic.HashSet`1+Enumerator::MoveNext /* +1 sharing t\n// ... truncated")]
	public unsafe override void OnPreComputeUpdate()
	{
		//IL_11c4: Expected O, but got I4
		//IL_0104: Expected O, but got I
		//IL_0116: Expected O, but got I
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		//IL_0160: Expected O, but got I4
		//IL_0013: Expected I, but got O
		//IL_01a4: Expected O, but got I
		//IL_0086: Expected I, but got O
		//IL_154c: Expected O, but got I4
		//IL_00db: Expected O, but got I
		//IL_0279: Expected O, but got I
		//IL_08ad: Expected O, but got I
		//IL_08e5: Expected O, but got I
		//IL_11ff: Expected I, but got O
		//IL_120f: Expected O, but got I
		//IL_121f: Expected O, but got I
		//IL_02d4: Expected O, but got F4
		//IL_02f6: Expected O, but got I4
		//IL_117c: Expected I4, but got O
		//IL_0940: Unknown result type (might be due to invalid IL or missing references)
		//IL_0945: Expected O, but got Unknown
		//IL_0954: Expected F4, but got O
		//IL_0969: Expected F4, but got I
		//IL_1193: Expected I4, but got O
		//IL_0836: Expected O, but got I
		//IL_032b: Expected O, but got I
		//IL_0363: Expected O, but got I4
		//IL_09e2: Expected O, but got I
		//IL_09f6: Expected O, but got I
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected O, but got Unknown
		//IL_03c9: Expected F4, but got O
		//IL_03de: Expected F4, but got I
		//IL_1147: Expected O, but got I4
		//IL_041a: Expected O, but got I
		//IL_0506: Expected O, but got F4
		//IL_0536: Expected O, but got I
		//IL_1385: Expected O, but got F4
		//IL_138e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1393: Expected I4, but got Unknown
		//IL_0641: Expected O, but got F4
		//IL_064e: Expected O, but got F4
		//IL_071d: Expected O, but got I
		//IL_0abf: Expected O, but got I
		//IL_0af7: Expected O, but got I
		//IL_0b52: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b57: Expected O, but got Unknown
		//IL_0b66: Expected F4, but got O
		//IL_0b7b: Expected F4, but got I
		//IL_0c4e: Expected O, but got I
		//IL_0ca4: Expected O, but got I
		//IL_0ce1: Expected O, but got I
		//IL_148a: Expected I, but got O
		//IL_14a4: Expected O, but got I
		//IL_0d1f: Expected O, but got I
		//IL_0d51: Expected O, but got I
		//IL_0d5a: Expected O, but got I4
		object obj = 0;
		global::System.Action<ParticleInitData> action2 = default(global::System.Action<ParticleInitData>);
		if (global::UnityEngine.Input.GetKeyDown(global::UnityEngine.KeyCode.S))
		{
			nint num = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"SzArrayNew\"");
			global::UnityEngine.Vector2 vector = default(global::UnityEngine.Vector2);
			vector.x = position.x;
			vector.y = position.y;
			global::Unity.Mathematics.float2 float5 = vector;
			float y = float5.y;
			_ = float5.y;
			nint num2 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v832 @ X8_v111 (Il2CppMethodInfo)+B90]");
			global::System.Action<ParticleInitData> action = new global::System.Action<ParticleInitData>(this, (global::System.IntPtr)0);
			nint num3 = 0;
			global::Unity.Mathematics.float2[] spawnPositions = default(global::Unity.Mathematics.float2[]);
			global::System.Collections.Generic.HashSet<int> hashSet = solver.AddParticles(spawnPositions, fluidType, action);
			nint num4 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1151 @ X8_v113 (Il2CppMethodInfo)+18]");
			object obj2 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1166880 (Unity.VisualScripting.LinqUtility::AddRange, and 1 more at this address)");
			action2 = action;
		}
		nint num5 = 0;
		object obj3 = (nint)0 + (nint)2416;
		nint num6 = 0;
		object obj4 = (nint)0 + (nint)3112;
		object obj5 = obj;
		global::System.Collections.Generic.HashSet<int> hashSet2 = (global::System.Collections.Generic.HashSet<int>)(typeof(global::Facebook.Unity.Windows.IWindowsFacebook) + 2328);
		bool flag = !isCleared;
		float num8 = default(float);
		float num7 = num8;
		object obj6 = obj4;
		object obj7 = obj3;
		object obj8 = 0;
		object obj9 = obj;
		global::System.Collections.Generic.HashSet<int> hashSet3 = hashSet2;
		global::System.Collections.Generic.List<object>.Enumerator enumerator2 = default(global::System.Collections.Generic.List<object>.Enumerator);
		object obj13 = default(object);
		float num14;
		float num13;
		float num16;
		if (flag)
		{
			global::System.Collections.Generic.HashSet<int>.Enumerator enumerator = particleIds.GetEnumerator();
			obj5 = enumerator2;
			nint num9 = 0;
			global::System.Collections.Generic.List<object>.Enumerator enumerator3 = enumerator2;
			object obj10 = default(object);
			object obj12 = default(object);
			while (true)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C8 (System.Collections.Generic.HashSet`1+Enumerator::MoveNext, and 1 more at this address)");
				if ((int)((nint)obj10 & 1) == 0)
				{
					break;
				}
				if ((object)solver != null)
				{
					object obj11 = (nint)solver + 504;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17E754C (Unity.Collections.NativeHashMap`2::TryGetValue, and 1 more at this address)");
					int num10 = (int)((nint)obj12 & 1);
					bool flag2 = num10 == 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X26_v10 (Il2CppMethodInfo)+C28]");
					action2 = (global::System.Action<ParticleInitData>)0;
					object obj2 = obj13;
					if (flag2)
					{
						continue;
					}
					goto IL_08fb;
				}
				goto IL_106b;
			}
			int num11 = 3;
			object obj14 = obj;
			int num12 = 0;
			num13 = num8;
			float num15 = default(float);
			num14 = num15;
			float num17 = default(float);
			num16 = num17;
			obj6 = obj4;
			obj7 = obj3;
			obj8 = 0;
			int num18 = 0;
			hashSet3 = hashSet2;
			object obj15 = default(object);
			while (true)
			{
				nint num19 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C4 (System.Collections.Generic.HashSet`1+Enumerator::Dispose, and 1 more at this address)");
				if (num18 != 0)
				{
					global::System.OutOfMemoryException ex = new global::System.OutOfMemoryException();
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D6F8");
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BF134C");
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1173 @ X8_v4 (Il2CppMethodInfo)+968]");
					if ((nint)0 == 1)
					{
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A080 (inside System.__Il2CppComDelegate::Finalize +0xF54)");
						num18 = (int)obj15;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A098 (inside System.__Il2CppComDelegate::Finalize +0xF6C)");
						num12 = (int)obj15;
						num11 = 0;
						continue;
					}
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BF092C");
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27498DC (inside System.__Il2CppComDelegate::Finalize +0x7B0)");
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D6F8");
					return;
				}
				break;
			}
			bool flag3 = num11 == 3;
			num7 = num13;
			obj9 = obj;
			if (!flag3)
			{
				bool flag4 = num11 == 0;
				num7 = num13;
				obj9 = obj;
				if (!flag4)
				{
					return;
				}
			}
		}
		base.OnPreComputeUpdate();
		global::UnityEngine.Camera main = global::UnityEngine.Camera.main;
		global::Unity.Collections.NativeHashMap<int, global::Unity.Mathematics.float2> nativeParallelHashMap = (global::Unity.Collections.NativeHashMap<int, global::Unity.Mathematics.float2>)((nint)solver + 936);
		global::Unity.Mathematics.float2 float6 = (*(global::Unity.Collections.NativeHashMap<int, global::Unity.Mathematics.float2>*)nativeParallelHashMap)[id];
		global::UnityEngine.Vector2 vector2 = float6;
		global::UnityEngine.Vector3 vector3 = default(global::UnityEngine.Vector3);
		vector3.x = vector2.x;
		vector3.y = vector2.y;
		vector3.z = 0f;
		global::UnityEngine.Vector3 vector4 = main.WorldToViewportPoint(vector3);
		string text = "Writing object reference to Id '{0}' for {1}.";
		global::UnityEngine.Vector4 value = default(global::UnityEngine.Vector4);
		value.x = vector4.x;
		value.y = vector4.y;
		value.z = vector4.z;
		value.w = 0f;
		global::UnityEngine.MaterialPropertyBlock propBlock = _propBlock;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1177 @ X8_v14 (System.String)+980]");
		propBlock.SetVector((string)0, value);
		mr.SetPropertyBlock(_propBlock);
		global::UnityEngine.Transform transform = base.transform;
		global::UnityEngine.Vector3 vector5 = transform.position;
		nint num20 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1409 @ X8_v18 (Il2CppClass<System.Xml.ValidateNames>)+D0]");
		object obj16 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1411 @ X8_v20+B8]");
		object obj17 = 0;
		int num21 = id * 916964780;
		num14 = (float)num21 + -2f;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1412 @ X8_v21+48]");
		float num22 = 0f * num14;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1412 @ X8_v21+4C]");
		float num23 = 0f * num14;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1412 @ X8_v21+50]");
		float num24 = 0f * num14;
		float x = vector5.x + num22;
		float y2 = vector5.y + num23;
		num16 = vector5.z + num24;
		global::UnityEngine.Vector3 vector6 = default(global::UnityEngine.Vector3);
		vector6.x = x;
		vector6.y = y2;
		vector6.z = num16;
		transform.position = vector6;
		nint num25 = 0;
		nint num26 = 0;
		global::System.Collections.Generic.HashSet<int>.Enumerator enumerator4 = particleIds.GetEnumerator();
		float num27 = default(float);
		obj9 = num27;
		num13 = num7;
		float num28 = 0f;
		global::System.Action<ParticleInitData> action3 = action2;
		object obj18 = 0;
		object obj19 = default(object);
		object obj21 = default(object);
		int num30 = default(int);
		global::Unity.Mathematics.float2 float7 = default(global::Unity.Mathematics.float2);
		global::UnityEngine.Vector2 value2 = default(global::UnityEngine.Vector2);
		global::UnityEngine.Vector4 value3 = default(global::UnityEngine.Vector4);
		float num40 = default(float);
		object obj24 = default(object);
		float num41 = default(float);
		global::UnityEngine.Vector2 value4 = default(global::UnityEngine.Vector2);
		float num35;
		while (true)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C8 (System.Collections.Generic.HashSet`1+Enumerator::MoveNext, and 1 more at this address)");
			float num32;
			float num33;
			object obj23;
			float num34;
			if ((int)((nint)obj19 & 1) != 0)
			{
				object obj14;
				int num12;
				if ((object)solver != null)
				{
					object obj20 = (nint)solver + 504;
					action3 = (global::System.Action<ParticleInitData>)obj6;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17E754C (Unity.Collections.NativeHashMap`2::TryGetValue, and 1 more at this address)");
					int num29 = (int)((nint)obj21 & 1);
					bool flag5 = num29 == 0;
					obj18 = num30;
					if (flag5)
					{
						continue;
					}
					FluidSolver fluidSolver = solver;
					if ((object)solver != null)
					{
						int num31 = num30 << 3;
						object obj22 = fluidSolver.positions + num31;
						float7.x = (float)obj22;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1093 @ X8_v40+4]");
						float7.y = 0f;
						global::UnityEngine.Vector2 vector7 = float7;
						if (prevOffset != null)
						{
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1452 @ X22_v14 (Il2CppMethodInfo)+530]");
							action3 = (global::System.Action<ParticleInitData>)0;
							bool flag6 = prevOffset.TryGetValue(num30, out value2);
							num32 = vector7.x - position.x;
							num33 = vector7.y - position.y;
							if (flag6)
							{
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2DD4435]");
								bool flag7 = (nint)0 == 0;
								obj23 = value2;
								num34 = num13;
								if (!flag7)
								{
									goto IL_04b6;
								}
							}
							else
							{
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2DD4435]");
								bool flag8 = (nint)0 == 0;
								bool flag9 = !flag8;
								num13 = num33;
								obj23 = num32;
								num34 = num33;
								if (flag9)
								{
									goto IL_04b6;
								}
							}
							_ = 1;
							goto IL_0527;
						}
						global::System.NullReferenceException ex2 = new global::System.NullReferenceException();
						num35 = -2f;
						obj18 = num30;
						break;
					}
					global::System.NullReferenceException ex3 = new global::System.NullReferenceException();
					obj14 = obj;
					num12 = 0;
					obj18 = obj13;
					break;
				}
				global::System.NullReferenceException ex4 = new global::System.NullReferenceException();
				int num36 = 0;
				obj14 = obj;
				num12 = 0;
				break;
			}
			nint num37 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C4 (System.Collections.Generic.HashSet`1+Enumerator::Dispose, and 1 more at this address)");
			global::System.Collections.Generic.HashSet<int> hashSet4 = particleIds;
			float num38 = num28 / (float)hashSet4.Count;
			float num39 = num38 * (-(float)global::System.Math.PI / 180f);
			float x2 = (zRotation += num39);
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A170");
			mr.GetPropertyBlock(_propBlock);
			string text2 = "Writing object reference to Id '{0}' for {1}.";
			value3.x = x2;
			value3.y = zRotation;
			value3.z = 0f;
			value3.w = 0f;
			global::UnityEngine.MaterialPropertyBlock propBlock2 = _propBlock;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1559 @ X8_v35 (System.String)+8C8]");
			propBlock2.SetVector((string)0, value3);
			mr.SetPropertyBlock(_propBlock);
			return;
			IL_04b6:
			num13 = num40;
			obj23 = obj24;
			num34 = num41;
			goto IL_0527;
			IL_0527:
			object obj25 = (nint)obj23 * (nint)obj23;
			float num42 = num34 * num34;
			float num43 = (float)obj25 + num42;
			float num44 = num32 * num32;
			float num45 = num33 * num33;
			float num46 = num44 + num45;
			float f = num46 * num43;
			float num47 = global::UnityEngine.Mathf.Sqrt(f);
			bool flag10 = num47 < 1E-15f;
			float num48 = 0f;
			if (!flag10)
			{
				float num49 = num32 * (float)obj23;
				float num50 = num33 * num34;
				float num51 = num49 + num50;
				float num52 = num51 / num47;
				float num53 = num52 - 1f;
				bool flag11 = num53 < 0f;
				bool flag12 = num53 == 0f;
				float num55 = ((!(num52 > 1f)) ? num52 : 1f);
				float num56 = ((!(num52 < -1f)) ? num55 : (-1f));
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A230");
				num48 = num56 * 57.29578f;
			}
			float num57 = num33 * (float)obj23;
			float num58 = num32 * num34;
			y2 = num57 - num58;
			num16 = 0f - num48;
			bool flag16 = y2 < 0f;
			if (flag16)
			{
				num48 = num16;
			}
			num28 += num48;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1453 @ X23_v11 (Il2CppMethodInfo)+538]");
			obj18 = 0;
			value4.x = num32;
			value4.y = num33;
			prevOffset[num30] = value4;
			y2 = num33;
		}
		goto IL_11eb;
		IL_08fb:
		FluidSolver fluidSolver2 = solver;
		if ((object)solver != null)
		{
			int num60 = (int)((nint)obj13 << 3);
			object obj29 = fluidSolver2.positions + num60;
			global::Unity.Mathematics.float2 float8 = default(global::Unity.Mathematics.float2);
			float8.x = (float)obj29;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1185 @ X8_v64+4]");
			float8.y = 0f;
			global::UnityEngine.Vector2 vector8 = float8;
			nint num61 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
			object obj30 = default(object);
			if (obj30 != null)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1212 @ X0_v90+A8]");
				if ((nint)0 != 0)
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1212 @ X0_v90+A8]");
					object enumerator5 = ((global::System.Collections.Generic.List<object>)0).GetEnumerator();
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X26_v10 (Il2CppMethodInfo)+C28]");
					global::System.Action<ParticleInitData> action4 = (global::System.Action<ParticleInitData>)0;
					object obj31 = obj13;
					float y3 = vector8.y;
					global::System.Collections.Generic.List<object>.Enumerator enumerator6 = enumerator2;
					if (enumerator2.MoveNext())
					{
						int num62 = default(int);
						if (num62 != 0)
						{
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v519 @ stack_-128 (System.Int32)+88]");
							object obj36 = default(object);
							if ((nint)0 != 0)
							{
								nint num63 = 0;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @15C35B0 (System.Collections.Generic.HashSet`1::GetEnumerator, and 1 more at this address)");
								global::System.Action<ParticleInitData> action5 = action4;
								object obj32 = obj31;
								float num64 = y3;
								float num66 = default(float);
								float num65 = num66;
								object obj33 = default(object);
								object obj35 = default(object);
								global::Unity.Mathematics.float2 float9 = default(global::Unity.Mathematics.float2);
								while (true)
								{
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C8 (System.Collections.Generic.HashSet`1+Enumerator::MoveNext, and 1 more at this address)");
									int num36;
									object obj14;
									int num12;
									if ((int)((nint)obj33 & 1) != 0)
									{
										if ((object)solver == null)
										{
											global::System.NullReferenceException ex5 = new global::System.NullReferenceException();
											num35 = -2f;
											obj18 = value2;
											break;
										}
										object obj34 = (nint)solver + 504;
										global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17E754C (Unity.Collections.NativeHashMap`2::TryGetValue, and 1 more at this address)");
										int num67 = (int)((nint)obj35 & 1);
										bool flag18 = num67 == 0;
										global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X26_v10 (Il2CppMethodInfo)+C28]");
										action5 = (global::System.Action<ParticleInitData>)0;
										obj32 = obj36;
										if (flag18)
										{
											continue;
										}
										FluidSolver fluidSolver3 = solver;
										if ((object)solver == null)
										{
											global::System.NullReferenceException ex6 = new global::System.NullReferenceException();
											num36 = 0;
											obj14 = obj;
											num12 = 0;
											break;
										}
										int num68 = (int)((nint)obj36 << 3);
										object obj37 = fluidSolver3.positions + num68;
										float9.x = (float)obj37;
										global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1563 @ X8_v94+4]");
										float9.y = 0f;
										global::UnityEngine.Vector2 vector9 = float9;
										global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2DD4425]");
										if ((nint)0 == 0)
										{
											_ = 1;
										}
										float num69 = vector8.y - vector9.y;
										float num70 = vector8.x - vector9.x;
										float num71 = num70 * num70;
										float num72 = num69 * num69;
										float f2 = num71 + num72;
										float num73 = global::UnityEngine.Mathf.Sqrt(f2);
										bool flag19 = !(num73 < 0.1f);
										global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X26_v10 (Il2CppMethodInfo)+C28]");
										action5 = (global::System.Action<ParticleInitData>)0;
										obj32 = obj36;
										num64 = 0.1f;
										num65 = num73;
										if (flag19)
										{
											continue;
										}
										if (removedParticles == null)
										{
											global::System.NullReferenceException ex7 = new global::System.NullReferenceException();
											num36 = 0;
											obj14 = obj;
											num12 = 0;
											obj18 = obj36;
											break;
										}
										global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ X21_v16 (Il2CppMethodInfo)+990]");
										obj32 = 0;
										bool flag20 = removedParticles.Contains(num62);
										bool flag21 = !flag20;
										bool flag22 = !flag21;
										global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X26_v10 (Il2CppMethodInfo)+C28]");
										action5 = (global::System.Action<ParticleInitData>)0;
										num64 = 0.1f;
										num65 = num73;
										if (flag22)
										{
											continue;
										}
										isCleared = true;
										nint num74 = 0;
										object obj38 = new object();
										object obj39 = (nint)obj38 + 40;
										_ = 0;
										global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
										object obj40 = (nint)obj38 + 32;
										global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
										global::UnityEngine.Coroutine coroutine = StartCoroutine((global::System.Collections.IEnumerator)obj38);
										global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X26_v10 (Il2CppMethodInfo)+C28]");
										action5 = (global::System.Action<ParticleInitData>)0;
										obj32 = 0;
										num64 = 0.1f;
										num65 = num73;
										int num11 = 10;
									}
									else
									{
										int num11 = 6;
									}
									nint num75 = 0;
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C4 (System.Collections.Generic.HashSet`1+Enumerator::Dispose, and 1 more at this address)");
									global::System.OutOfMemoryException ex8 = new global::System.OutOfMemoryException();
									num36 = 0;
									obj14 = obj;
									num12 = 0;
									break;
								}
							}
							else
							{
								global::System.NullReferenceException ex9 = new global::System.NullReferenceException();
								int num36 = 0;
								object obj14 = obj;
								int num12 = 0;
								obj18 = obj36;
								y2 = 0.1f;
							}
						}
						else
						{
							global::System.NullReferenceException ex10 = new global::System.NullReferenceException();
							int num36 = 0;
							object obj14 = obj;
							int num12 = 0;
						}
					}
					else
					{
						global::System.Action<ParticleInitData> action6 = action4;
						object obj41 = obj31;
						float num76 = y3;
						global::System.Collections.Generic.List<object>.Enumerator enumerator7 = enumerator6;
						int num11 = 4;
						enumerator2.Dispose();
						global::System.OutOfMemoryException ex11 = new global::System.OutOfMemoryException();
					}
				}
				else
				{
					global::System.NullReferenceException ex12 = new global::System.NullReferenceException();
					object obj14 = obj;
					int num12 = 0;
					obj18 = obj13;
				}
			}
			else
			{
				global::System.NullReferenceException ex13 = new global::System.NullReferenceException();
				object obj14 = obj;
				int num12 = 0;
				obj18 = obj13;
			}
		}
		else
		{
			global::System.NullReferenceException ex14 = new global::System.NullReferenceException();
			int num36 = 0;
			object obj14 = obj;
			int num12 = 0;
		}
		goto IL_11eb;
		IL_106b:
		global::System.NullReferenceException ex15 = new global::System.NullReferenceException();
		num35 = -2f;
		goto IL_11eb;
		IL_11eb:
		throw new global::System.IndexOutOfRangeException();
	}

	[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(Sponge._003CSuckUpWater_003Ed__7))]
	[global::Cpp2ILInjected.Token(Token = "0x60003B8")]
	[global::Cpp2ILInjected.Address(RVA = "0x1016F84", Offset = "0x1016F84", Length = "0x8C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv20 = Sponge+<>c__DisplayClass7_0;\n\tgoto L_0018;\n\tv25 = Sponge+<>c__DisplayClass7_0;\n\tv26 = v25 + 8;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, w, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41);\n\tv44 = 1;\n\t*([302AAC3]) = v44;\nL_0018:\n\tv46 = new *([v20 @ X22_v1 (Il2CppClass<Sponge+<>c__DisplayClass7_0>)+8])();\n\tSystem.Object::.ctor(v46);\n\t*([v46 @ X0_v3 (System.Object)+10]) = 0;\n\tv50 = v46 + 0x28;\n\t*([v46 @ X0_v3 (System.Object)+28]) = this;\n\tv52 = 0xF3F1B4(v50, this, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41);\n\tv54 = v46 + 0x20;\n\t*([v46 @ X0_v3 (System.Object)+20]) = w;\n\tv56 = 0xF3F1B4(v54, w, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41);\n\treturn v46;\n// 31 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private global::System.Collections.IEnumerator SuckUpWater(Water w)
	{
		//IL_000e: Expected I, but got O
		//IL_0055: Expected O, but got I
		//IL_0022: Expected O, but got I
		nint num = 0;
		object obj = new object();
		_ = 0;
		object obj2 = (nint)obj + 40;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		object obj3 = (nint)obj + 32;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		return (global::System.Collections.IEnumerator)obj;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003B9")]
	[global::Cpp2ILInjected.Address(RVA = "0x101703C", Offset = "0x101703C", Length = "0xE0")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv22 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv26 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tgoto L_0028;\n\tv33 = Il2CppMethodInfo;\n\tv34 = v33 + 0x528;\n\tv35 = \"il2cpp_codegen_initialize_runtime_metadata\"(v34, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv57 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv58 = v57 + 0x4F0;\n\tv59 = \"il2cpp_codegen_initialize_runtime_metadata\"(v58, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv62 = Il2CppMethodInfo;\n\tv63 = v62 + 0x968;\n\tv64 = \"il2cpp_codegen_initialize_runtime_metadata\"(v63, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv69 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv70 = v69 + 0x5D8;\n\tv52 = \"il2cpp_codegen_initialize_runtime_metadata\"(v70, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv54 = 1;\n\t*([302AA90]) = v54;\nL_0028:\n\tv56 = new *([v22 @ X24_v1 (Il2CppClass<System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>>)+4F0])();\n\tSystem.Collections.Generic.Dictionary`2<System.Int32, UnityEngine.Vector2>::.ctor(v56);\n\tv66 = this + 0xB0;\n\tthis.prevOffset = v56;\n\tv68 = 0xF3F1B4(v66, v56, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv72 = new *([v26 @ X22_v1 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+5D8])();\n\tSystem.Collections.Generic.HashSet`1<System.Int32>::.ctor(v72);\n\tv76 = this + 0xC0;\n\tthis.removedParticles = v72;\n\tv78 = 0xF3F1B4(v76, v72, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tSpecialFluid::.ctor(this);\n\treturn;\n// 43 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public Sponge()
	{
		//IL_0014: Expected I, but got O
		//IL_0023: Expected I, but got O
		//IL_0074: Expected O, but got I
		//IL_0044: Expected O, but got I
		base._002Ector();
		nint num = 0;
		nint num2 = 0;
		global::System.Collections.Generic.Dictionary<int, global::UnityEngine.Vector2> dictionary = new global::System.Collections.Generic.Dictionary<int, global::UnityEngine.Vector2>();
		object obj = (nint)this + 176;
		prevOffset = dictionary;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		global::System.Collections.Generic.HashSet<int> hashSet = new global::System.Collections.Generic.HashSet<int>();
		object obj2 = (nint)this + 192;
		removedParticles = hashSet;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
	}
}
