[global::Cpp2ILInjected.Token(Token = "0x200000C")]
public class LogScroller : global::UnityEngine.MonoBehaviour
{
	[global::UnityEngine.SerializeField]
	[global::Cpp2ILInjected.Token(Token = "0x4000048")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private global::UnityEngine.GameObject _content;

	[global::UnityEngine.HideInInspector]
	[global::Cpp2ILInjected.Token(Token = "0x4000049")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public global::System.Collections.Generic.List<string> texts;

	[global::Cpp2ILInjected.Token(Token = "0x400004A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private string DATE_FORMAT;

	[global::Cpp2ILInjected.Token(Token = "0x400004B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	private int index;

	[global::Cpp2ILInjected.Token(Token = "0x600007C")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD783C", Offset = "0xFD783C", Length = "0x4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn;\n")]
	private void Start()
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x600007D")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD7840", Offset = "0xFD7840", Length = "0x340")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0022;\n\tv25 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv26 = v25 + 0x9F0;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv50 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv51 = v50 + 0xA90;\n\tv52 = \"il2cpp_codegen_initialize_runtime_metadata\"(v51, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv147 = Il2CppMethodInfo;\n\tv148 = v147 + 0x318;\n\tv149 = \"il2cpp_codegen_initialize_runtime_metadata\"(v148, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv212 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv213 = v212 + 0xFD8;\n\tv214 = \"il2cpp_codegen_initialize_runtime_metadata\"(v213, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv215 = System.Net.Configuration.SettingsSectionInternal;\n\tv216 = v215 + 0xAA8;\n\tv44 = \"il2cpp_codegen_initialize_runtime_metadata\"(v216, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv46 = 1;\n\t*([302A8E4]) = v46;\nL_0022:\n\tv47 = 0;\n\tv48 = this.texts;\n\tv274 = v48._size;\n\tv55 = v48._version + 1;\n\tv48._size = 0;\n\tv48._version = v55;\n\tv66 = v48._size < 1;\n\tif (v66) goto L_003F;\n\tSystem.Array::Clear(v48._items, 0, v48._size);\nL_003F:\n\tv135 = UnityEngine.GameObject::get_transform(this._content);\n\tv228 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv229 = System.Net.Configuration.SettingsSectionInternal;\n\tv231 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv338 = UnityEngine.UIElements.EnumFieldHelpers + 0x9F0;\n\tv233 = UnityEngine.Transform::GetEnumerator(v135);\n\tgoto L_0057;\nL_0055:\n\tUnityEngine.Object::Destroy(v644);\nL_0057:\n\tv285 = v86 == 0;\n\tif (v285) goto L_0124;\n\tv293 = *([v86 @ stack_-48_v6]);\n\tv431 = *([v293 @ X8_v17+12E]);\n\tv295 = *([v293 @ X8_v17+12E]) == 0;\n\tif (v295) goto L_007A;\n\tv421 = *([v293 @ X8_v17+B0]) + 8;\nL_0065:\n\tv436 = *([v421 @ X10_v24-8]) == *([v228 @ X20_v8 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]);\n\tif (v436) goto L_007D;\n\tv421 = v421 + 0x10;\n\tv324 = v431 - 1;\n\tv306 = v431 != 1;\n\tif (v306) goto L_0065;\nL_007A:\n\tv528 = 0xF7087C(v86, *([v228 @ X20_v8 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]), 0, v342, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tgoto L_0083;\nL_007D:\n\tv525 = *([v421 @ X10_v24]) << 4;\n\tv526 = v293 + v525;\n\tv528 = v526 + 0x138;\nL_0083:\n\t*([v528 @ X0_v32])(v531, v86, *([v528 @ X0_v32+8]), v365, v342, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv532 = v531 & 1;\n\tv533 = v532 == 0;\n\tif (v533) goto L_00E1;\n\tv470 = v86 == 0;\n\tif (v470) goto L_0126;\n\tv565 = *([v86 @ stack_-48_v6]);\n\tv608 = *([v565 @ X8_v21+12E]);\n\tv567 = *([v565 @ X8_v21+12E]) == 0;\n\tif (v567) goto L_00AB;\n\tv598 = *([v565 @ X8_v21+B0]) + 8;\nL_0096:\n\tv613 = *([v598 @ X10_v19-8]) == *([v228 @ X20_v8 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]);\n\tif (v613) goto L_00AE;\n\tv598 = v598 + 0x10;\n\tv593 = v608 - 1;\n\tv575 = v608 != 1;\n\tif (v575) goto L_0096;\nL_00AB:\n\tv624 = 0xF7087C(v86, *([v228 @ X20_v8 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]), 1, v342, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tgoto L_00B5;\nL_00AE:\n\tv620 = *([v598 @ X10_v19]) + 1;\n\tv621 = v620 << 4;\n\tv622 = v565 + v621;\n\tv624 = v622 + 0x138;\nL_00B5:\n\t*([v624 @ X0_v38])(v627, v86, *([v624 @ X0_v38+8]), v198, v342, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv176 = *([v229 @ X22_v7 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+AA8]);\n\tv628 = *([v627 @ X0_v40 (UnityEngine.Component)]);\n\tv629 = *([v628 @ X8_v24 (Il2CppClass<UnityEngine.Component>)+130]) < *([v176 @ X1_v3 (Il2CppMethodInfo)+130]);\n\tv630 = ~v629;\n\tv638 = ~v630;\n\tif (v638) goto L_0122;\n\tv249 = *([v176 @ X1_v3 (Il2CppMethodInfo)+130]) << 3;\n\tv640 = *([v628 @ X8_v24 (Il2CppClass<UnityEngine.Component>)+C8]) + v249;\n\tv255 = *([v640 @ X8_v27-8]) != v176;\n\tif (v255) goto L_0122;\n\tv644 = UnityEngine.Component::get_gameObject(v627);\n\tgoto L_0055;\n\tv647 = \"il2cpp_codegen_runtime_class_init\"(v645, v643, v275, v95, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tgoto L_0055;\nL_00E1:\n\tv372 = &v86 @ stack_-48_v6;\n\tv341 = &v47 @ stack_-50_v1;\n\tv176 = *([v231 @ X21_v6 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+9F0]);\n\tv367 = 0xF3F36C(*([v372 @ X8_v20]), *([v231 @ X21_v6 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+9F0]), v365, v342, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\t*([v341 @ X22_v9]) = v367;\n\tv370 = v367 == 0;\n\tif (v370) goto L_0115;\nL_00EB:\n\tv378 = *([v367 @ X0_v18]);\n\tv545 = *([v378 @ X8_v9+12E]);\n\tv380 = *([v378 @ X8_v9+12E]) == 0;\n\tif (v380) goto L_010B;\n\tv535 = *([v378 @ X8_v9+B0]) + 8;\nL_00F6:\n\tv550 = *([v535 @ X10_v9-8]) == *([v338 @ X21_v5]);\n\tif (v550) goto L_010E;\n\tv535 = v535 + 0x10;\n\tv519 = v545 - 1;\n\tv501 = v545 != 1;\n\tif (v501) goto L_00F6;\nL_010B:\n\tv561 = 0xF7087C(v367, *([v338 @ X21_v5]), 0, v342, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tgoto L_0112;\nL_010E:\n\tv558 = *([v535 @ X10_v9]) << 4;\n\tv559 = v378 + v558;\n\tv561 = v559 + 0x138;\nL_0112:\n\tv176 = *([v561 @ X0_v19+8]);\n\t*([v561 @ X0_v19])(v490, v367, *([v561 @ X0_v19+8]), v198, v342, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\nL_0115:\n\tv493 = v209 == 0;\n\tv203 = ~v493;\n\tif (v203) goto L_012C;\n\treturn;\nL_0122:\n\tv467 = new System.InvalidCastException();\n\tgoto L_0129;\nL_0124:\n\tv296 = new System.NullReferenceException();\n\tgoto L_0129;\nL_0126:\n\tv468 = new System.NullReferenceException();\n\tgoto L_0129;\n\tv466 = new System.NullReferenceException();\nL_0129:\n\t// 297 Interrupt\n\tthrow System.NullReferenceException;\nL_012C:\n\tv211 = new System.OutOfMemoryException();\n\tgoto L_013C;\n\tgoto L_013C;\n\tgoto L_013C;\n\tgoto L_013C;\n\tgoto L_013C;\nL_013C:\n\tv227 = v176 != 1;\n\tif (v227) goto L_014F;\n\tv235 = 0x274A080(v211, v176, v198, v175, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv374 = *([v235 @ X0_v14]);\n\tv243 = 0x274A098(v235, v176, v198, v175, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv176 = *([v169 @ X21_v1]);\n\tv367 = 0xF3F36C(*([v162 @ stack_-60_v3]), *([v169 @ X21_v1]), v198, v175, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\t*([v160 @ stack_-58_v3]) = v367;\n\tv297 = v367 == 0;\n\tv298 = ~v297;\n\tif (v298) goto L_00EB;\n\tgoto L_0115;\n\tX19 = X0;\nL_014F:\n\tv237 = 0xBF079C(&v82 @ stack_-68_v2 (System.Int32), v176, v198, v175, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv245 = 0x27498DC(v211, v176, v198, v175, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv291 = 0xD6F8(v245, v176, v198, v175, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\treturn;\n// 188 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void ClearLogs()
	{
		//IL_06af: Expected O, but got I4
		//IL_00ae: Expected I, but got O
		//IL_00bc: Expected I, but got O
		//IL_00ca: Expected I, but got O
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_0087: Expected O, but got I4
		//IL_013d: Expected O, but got I
		//IL_0178: Expected O, but got I
		//IL_01e9: Expected I4, but got O
		//IL_01f7: Expected O, but got I
		//IL_0206: Expected O, but got I
		//IL_04ae: Expected O, but got I
		//IL_018c: Expected O, but got I
		//IL_019b: Expected O, but got I
		//IL_0248: Expected O, but got I
		//IL_04e9: Expected O, but got I
		//IL_060e: Expected I4, but got O
		//IL_0283: Expected O, but got I
		//IL_0626: Expected I, but got O
		//IL_066a: Expected I4, but got O
		//IL_055a: Expected I4, but got O
		//IL_0568: Expected O, but got I
		//IL_0577: Expected O, but got I
		//IL_0345: Expected I, but got O
		//IL_04fd: Expected O, but got I
		//IL_050c: Expected O, but got I
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected O, but got Unknown
		//IL_0311: Expected O, but got I
		//IL_0320: Expected O, but got I
		//IL_0688: Expected I4, but got O
		//IL_06a0: Expected I4, but got O
		//IL_03b2: Expected O, but got I
		//IL_0297: Expected O, but got I
		//IL_02a6: Expected O, but got I
		object obj = 0;
		global::System.Collections.Generic.List<string> list = texts;
		int num = list.Count;
		list.Clear();
		object obj2 = default(object);
		global::UnityEngine.Transform transform = _content.transform;
		object obj3 = 0;
		global::System.Collections.IEnumerator enumerator = transform.GetEnumerator();
		object obj4 = default(object);
		object obj13 = default(object);
		object obj15 = default(object);
		global::UnityEngine.Component component = default(global::UnityEngine.Component);
		object obj27 = default(object);
		object obj14;
		object obj18;
		int num11;
		while (true)
		{
			int num7;
			if (obj4 != null)
			{
				object obj5 = obj4;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X8_v17+12E]");
				object obj6 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X8_v17+12E]");
				if ((nint)0 == 0)
				{
					goto IL_01c3;
				}
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X8_v17+B0]");
				object obj7 = (nint)0 + (nint)8;
				while (true)
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X10_v24-8]");
					nint num5 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X20_v8 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]");
					if (num5 == 0)
					{
						break;
					}
					obj7 = (nint)obj7 + 16;
					object obj8 = (nint)obj6 - 1;
					bool flag = (nint)obj6 != 1;
					obj6 = obj8;
					if (flag)
					{
						continue;
					}
					goto IL_01c3;
				}
				int num6 = (int)((nint)obj7 << 4);
				object obj9 = (nint)obj5 + num6;
				num7 = num;
				goto IL_06f0;
			}
			global::System.NullReferenceException ex = new global::System.NullReferenceException();
			break;
			IL_0761:
			int num8;
			object obj11;
			object obj12;
			int num10;
			object obj16;
			object obj17;
			int num12;
			nint num9;
			while (true)
			{
				bool flag2 = num8 == 0;
				bool flag3 = !flag2;
				obj3 = obj11;
				obj2 = obj12;
				if (!flag3)
				{
					return;
				}
				global::System.OutOfMemoryException ex2 = new global::System.OutOfMemoryException();
				if (num9 == 1)
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A080 (inside System.__Il2CppComDelegate::Finalize +0xF54)");
					num10 = (int)obj13;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A098 (inside System.__Il2CppComDelegate::Finalize +0xF6C)");
					num9 = (nint)obj11;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F36C");
					obj14 = obj15;
					bool flag4 = obj15 == null;
					bool flag5 = !flag4;
					obj16 = obj14;
					obj17 = obj18;
					num11 = (int)obj13;
					num7 = num12;
					if (flag5)
					{
						break;
					}
					num11 = (int)obj13;
					obj11 = obj11;
					obj12 = obj12;
					num8 = (int)obj13;
					continue;
				}
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BF079C");
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27498DC (inside System.__Il2CppComDelegate::Finalize +0x7B0)");
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D6F8");
				return;
			}
			goto IL_0496;
			IL_0496:
			object obj19 = obj15;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X8_v9+12E]");
			object obj20 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X8_v9+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0534;
			}
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X8_v9+B0]");
			object obj21 = (nint)0 + (nint)8;
			while (true)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X10_v9-8]");
				if (0 == (nint)obj3)
				{
					break;
				}
				obj21 = (nint)obj21 + 16;
				object obj22 = (nint)obj20 - 1;
				bool flag6 = (nint)obj20 != 1;
				obj20 = obj22;
				if (flag6)
				{
					continue;
				}
				goto IL_0534;
			}
			int num13 = (int)((nint)obj21 << 4);
			object obj23 = (nint)obj19 + num13;
			num12 = num7;
			goto IL_07bd;
			IL_02ce:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
			num12 = 1;
			goto IL_0752;
			IL_0752:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v624 @ X0_v38] (should have been resolved before IL gen)");
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X22_v7 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+AA8]");
			num9 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v628 @ X8_v24 (Il2CppClass<UnityEngine.Component>)+130]");
			nint num15 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X1_v3 (Il2CppMethodInfo)+130]");
			if (num15 >= 0)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X1_v3 (Il2CppMethodInfo)+130]");
				int num16 = (int)((nint)0 << 3);
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v628 @ X8_v24 (Il2CppClass<UnityEngine.Component>)+C8]");
				object obj25 = (nint)0 + (nint)num16;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X8_v27-8]");
				if (0 == num9)
				{
					global::UnityEngine.GameObject obj26 = component.gameObject;
					global::UnityEngine.Object.Destroy(obj26);
					num = num12;
					continue;
				}
			}
			global::System.InvalidCastException ex3 = new global::System.InvalidCastException();
			break;
			IL_01c3:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
			num7 = 0;
			goto IL_06f0;
			IL_06f0:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v528 @ X0_v32] (should have been resolved before IL gen)");
			if ((int)((nint)obj27 & 1) != 0)
			{
				if (obj4 != null)
				{
					object obj28 = obj4;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v565 @ X8_v21+12E]");
					object obj29 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v565 @ X8_v21+12E]");
					if ((nint)0 == 0)
					{
						goto IL_02ce;
					}
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v565 @ X8_v21+B0]");
					object obj30 = (nint)0 + (nint)8;
					while (true)
					{
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ X10_v19-8]");
						nint num17 = 0;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X20_v8 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]");
						if (num17 == 0)
						{
							break;
						}
						obj30 = (nint)obj30 + 16;
						object obj31 = (nint)obj29 - 1;
						bool flag7 = (nint)obj29 != 1;
						obj29 = obj31;
						if (flag7)
						{
							continue;
						}
						goto IL_02ce;
					}
					object obj32 = (nint)obj30 + 1;
					int num18 = (int)((nint)obj32 << 4);
					object obj33 = (nint)obj28 + num18;
					num12 = num7;
					goto IL_0752;
				}
				global::System.NullReferenceException ex4 = new global::System.NullReferenceException();
				break;
			}
			object obj35 = obj4;
			object obj36 = obj;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X21_v6 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+9F0]");
			num9 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F36C");
			obj36 = obj15;
			bool flag8 = obj15 == null;
			obj16 = obj;
			obj17 = obj4;
			num11 = 0;
			num10 = 0;
			obj14 = obj;
			obj18 = obj4;
			num11 = 0;
			obj11 = obj3;
			obj12 = obj2;
			num12 = num7;
			num8 = 0;
			if (!flag8)
			{
				goto IL_0496;
			}
			goto IL_0761;
			IL_07bd:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v561 @ X0_v19+8]");
			num9 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v561 @ X0_v19] (should have been resolved before IL gen)");
			obj14 = obj16;
			obj18 = obj17;
			obj11 = obj3;
			obj12 = obj2;
			num8 = num10;
			goto IL_0761;
			IL_0534:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
			num12 = 0;
			goto IL_07bd;
		}
		obj14 = obj;
		obj18 = obj4;
		num11 = 0;
		throw new global::System.NullReferenceException();
	}

	[global::Cpp2ILInjected.Token(Token = "0x600007E")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD5F38", Offset = "0xFD5F38", Length = "0x294")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv24 = \"system.security.cryptography.des\";\n\tv26 = UnityEngine.UIElements.EnumFieldHelpers;\n\tgoto L_0030;\n\tv31 = System.ComponentModel.BooleanConverter;\n\tv32 = v31 + 0xB30;\n\tv33 = \"il2cpp_codegen_initialize_runtime_metadata\"(v32, text, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47);\n\tv58 = Il2CppMethodInfo;\n\tv59 = v58 + 0x9F8;\n\tv60 = \"il2cpp_codegen_initialize_runtime_metadata\"(v59, text, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47);\n\tv65 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv66 = v65 + 0x520;\n\tv67 = \"il2cpp_codegen_initialize_runtime_metadata\"(v66, text, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47);\n\tv71 = Il2CppMethodInfo;\n\tv72 = v71 + 0x330;\n\tv73 = \"il2cpp_codegen_initialize_runtime_metadata\"(v72, text, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47);\n\tv77 = Il2CppMethodInfo;\n\tv78 = v77 + 0xEA0;\n\tv79 = \"il2cpp_codegen_initialize_runtime_metadata\"(v78, text, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47);\n\tv81 = \"Argument must be of type {0}.\";\n\tv82 = v81 + 0x48;\n\tv83 = \"il2cpp_codegen_initialize_runtime_metadata\"(v82, text, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47);\n\tv148 = \"system.security.cryptography.des\";\n\tv149 = v148 + 0x2A0;\n\tv150 = \"il2cpp_codegen_initialize_runtime_metadata\"(v149, text, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47);\n\tv151 = \"x-cp50227\";\n\tv152 = v151 + 0x4C0;\n\tv49 = \"il2cpp_codegen_initialize_runtime_metadata\"(v152, text, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47);\n\tv51 = 1;\n\t*([302A8E5]) = v51;\nL_0030:\n\tv52 = this.index;\n\tv52 = v52 + 1;\n\tthis.index = v52;\n\tv57 = System.Int32::ToString(&v52 @ X8_v3 (System.Int32));\n\tv64 = System.String::Concat(*([v24 @ X22_v1 (System.String)+2A0]), v57);\n\tthis = *([v26 @ X21_v1 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+520]);\n\tv70 = new *([v26 @ X21_v1 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+520])();\n\tUnityEngine.GameObject::.ctor(v70, v64);\n\tv86 = UnityEngine.GameObject::get_transform(v70);\n\tv121 = UnityEngine.GameObject::get_transform(this._content);\n\tUnityEngine.Transform::set_parent(v86, v121);\n\tv122 = UnityEngine.GameObject::get_transform(v70);\n\t// 92 MakeStruct v98 @ AGGFD607C_1_v2 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), 0, 0, 0\n\tUnityEngine.Transform::set_localPosition(v122, v98);\n\tv123 = UnityEngine.GameObject::get_transform(v70);\n\t// 103 MakeStruct v95 @ AGGFD60A0_1_v2 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), 1f, 1f, 1f\n\tUnityEngine.Transform::set_localScale(v123, v95);\n\tv124 = UnityEngine.GameObject::get_transform(v70);\n\tv201 = \"x-cp50227\";\n\tUnityEngine.Transform::SetAsFirstSibling(v124);\n\tgoto L_007B;\n\tv206 = \"il2cpp_codegen_runtime_class_init\"(v203, v202, v109, v35, v36, v37, v38, v39, v107, v104, v101, v43, v44, v45, v46, v47);\nL_007B:\n\tv209 = System.DateTime::get_Now();\n\tv213 = System.DateTime::ToString(&v209 @ X0_v24 (System.DateTime), this.DATE_FORMAT);\n\tv215 = System.String::Format(*([v201 @ X22_v6 (System.String)+4C0]), v213, text);\n\tv217 = Il2CppMethodInfo;\n\tSystem.Collections.Generic.List`1<System.String>::Insert(this.texts, 0, v215);\n\tv126 = UnityEngine.GameObject::AddComponent /* +1 sharing this address */(v70, *([v217 @ X19_v3 (Il2CppMethodInfo)+9F8]));\n\tv221 = \"Argument must be of type {0}.\";\n\tv223 = Il2CppMethodInfo;\n\tthis = UnityEngine.UI.Text::set_text(v126, v215);\n\tv232 = UnityEngine.Resources::GetBuiltinResource /* +1 sharing this address */(*([v221 @ X21_v4 (System.String)+48]), *([v223 @ X22_v8 (Il2CppMethodInfo)+EA0]));\n\tUnityEngine.UI.Text::set_font(v126, v232);\n\tthis = UnityEngine.UI.Graphic::set_color(v126, Color_arg);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 123 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void Log(string text)
	{
		//IL_0017: Expected I, but got O
		//IL_023e: Expected O, but got I
		//IL_0252: Expected O, but got I
		//IL_0149: Expected O, but got I
		string text2 = "system.security.cryptography.des";
		int num2 = index;
		num2 = (index = num2 + 1);
		string text3 = num2.ToString();
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X22_v1 (System.String)+2A0]");
		string text4 = string.Empty + text3;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ X21_v1 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+520]");
		global::UnityEngine.GameObject gameObject = new global::UnityEngine.GameObject(text4);
		global::UnityEngine.Transform transform = gameObject.transform;
		global::UnityEngine.Transform parent = _content.transform;
		transform.parent = parent;
		global::UnityEngine.Transform transform2 = gameObject.transform;
		global::UnityEngine.Vector3 localPosition = default(global::UnityEngine.Vector3);
		localPosition.x = 0f;
		localPosition.y = 0f;
		localPosition.z = 0f;
		transform2.localPosition = localPosition;
		global::UnityEngine.Transform transform3 = gameObject.transform;
		global::UnityEngine.Vector3 localScale = default(global::UnityEngine.Vector3);
		localScale.x = 1f;
		localScale.y = 1f;
		localScale.z = 1f;
		transform3.localScale = localScale;
		global::UnityEngine.Transform transform4 = gameObject.transform;
		string text5 = "x-cp50227";
		transform4.SetAsFirstSibling();
		string arg = global::System.DateTime.Now.ToString(DATE_FORMAT);
		string text6 = string.Format("[{0}] {1}", arg, text);
		nint num3 = 0;
		texts.Insert(0, text6);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11481F4 (UnityEngine.GameObject::AddComponent, and 1 more at this address)");
		string text7 = "Argument must be of type {0}.";
		nint num4 = 0;
		global::UnityEngine.UI.Text text8 = default(global::UnityEngine.UI.Text);
		text8.text = text6;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @118E028 (UnityEngine.Resources::GetBuiltinResource, and 1 more at this address)");
		global::UnityEngine.Font font = default(global::UnityEngine.Font);
		text8.font = font;
		global::UnityEngine.Color color = default(global::UnityEngine.Color);
		color.r = 1f;
		color.g = 1f;
		color.b = 1f;
		color.a = 1f;
		text8.color = color;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600007F")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD7B80", Offset = "0xFD7B80", Length = "0xB8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv22 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv26 = \"IsCyrillic\";\n\tgoto L_0023;\n\tv31 = Il2CppMethodInfo;\n\tv32 = v31 + 0x2F0;\n\tv33 = \"il2cpp_codegen_initialize_runtime_metadata\"(v32, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48);\n\tv55 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv56 = v55 + 0x3C8;\n\tv57 = \"il2cpp_codegen_initialize_runtime_metadata\"(v56, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48);\n\tv60 = \"IsCyrillic\";\n\tv61 = v60 + 0xAE8;\n\tv50 = \"il2cpp_codegen_initialize_runtime_metadata\"(v61, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48);\n\tv52 = 1;\n\t*([302A8E6]) = v52;\nL_0023:\n\tv54 = new *([v22 @ X23_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+3C8])();\n\tSystem.Collections.Generic.List`1<System.String>::.ctor(v54);\n\tv63 = this + 0x28;\n\tthis.texts = v54;\n\tv65 = 0xF3F1B4(v63, v54, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48);\n\tv68 = this + 0x30;\n\tthis.DATE_FORMAT = *([v26 @ X21_v1 (System.String)+AE8]);\n\tv69 = 0xF3F1B4(v68, *([v26 @ X21_v1 (System.String)+AE8]), v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48);\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 38 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public LogScroller()
	{
		texts = new global::System.Collections.Generic.List<string>();
		DATE_FORMAT = "HH:mm:ss";
	}
}
