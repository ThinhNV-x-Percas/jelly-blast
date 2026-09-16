[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.UI.Image))]
[global::Cpp2ILInjected.Token(Token = "0x20000DC")]
public class SecondaryImageColor : global::UnityEngine.UI.BaseMeshEffect
{
	[global::UnityEngine.SerializeField]
	[global::Cpp2ILInjected.Token(Token = "0x4000491")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private global::UnityEngine.Color secondaryColor;

	[global::Cpp2ILInjected.Token(Token = "0x17000045")]
	public global::UnityEngine.Color SecondaryColor
	{
		[global::Cpp2ILInjected.Token(Token = "0x60003EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x10193BC", Offset = "0x10193BC", Length = "0xC")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn this.secondaryColor;\n// 4 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		get
		{
			return secondaryColor;
		}
		[global::Cpp2ILInjected.Token(Token = "0x60003EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x10193C8", Offset = "0x10193C8", Length = "0xF4")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv34 = Facebook.Unity.Windows.IWindowsFacebook;\n\tgoto L_0021;\n\tv39 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv40 = v39 + 0xFD8;\n\tv41 = \"il2cpp_codegen_initialize_runtime_metadata\"(v40, methodInfo, v43, v44, v45, v46, v47, v48, value, v0, v2, v3, v49, v50, v51, v52);\n\tv55 = 1;\n\t*([302AA9E]) = v55;\nL_0021:\n\tthis.secondaryColor = value;\n\tthis.secondaryColor.g = value.g;\n\tthis.secondaryColor.b = value.b;\n\tthis.secondaryColor.a = value.a;\n\tv58 = UnityEngine.UI.BaseMeshEffect::get_graphic(this);\n\tv60 = *([v34 @ X21_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv62 = *([v60 @ X0_v4+E0]) == 0;\n\tif (v62) goto L_004B;\n\tv66 = UnityEngine.Object::op_Inequality(v58, 0);\n\tv68 = ~v66;\n\tif (v68) goto L_005A;\nL_0035:\n\tv80 = UnityEngine.UI.BaseMeshEffect::get_graphic(this);\n\tv111 = *([v80 @ X0_v11 (UnityEngine.UI.Graphic)]);\n\t// 70 IndirectJump [v111 @ X8_v4 (Il2CppClass<UnityEngine.UI.Graphic>)+2F8], v80 @ X0_v11 (UnityEngine.UI.Graphic), v80 @ X0_v11 (UnityEngine.UI.Graphic), [v111 @ X8_v4 (Il2CppClass<UnityEngine.UI.Graphic>)+300], [v111 @ X8_v4 (Il2CppClass<UnityEngine.UI.Graphic>)+2F8], v44 @ X3, v45 @ X4, v46 @ X5, v47 @ X6, v48 @ X7, value @ V0 (UnityEngine.Color), value.g (System.Single), value.b (System.Single), value.a (System.Single), v49 @ V4, v50 @ V5, v51 @ V6, v52 @ V7\nL_004B:\n\tv72 = UnityEngine.Object::op_Inequality(v58, 0);\n\tv95 = ~v72;\n\tv77 = ~v95;\n\tif (v77) goto L_0035;\nL_005A:\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 65 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		set
		{
			//IL_000e: Expected I, but got O
			//IL_00f3: Expected O, but got I
			//IL_0051: Expected I, but got O
			nint num = (nint)typeof(global::Facebook.Unity.Windows.IWindowsFacebook);
			secondaryColor = value;
			secondaryColor.g = value.g;
			secondaryColor.b = value.b;
			secondaryColor.a = value.a;
			global::UnityEngine.UI.Graphic graphic = base.graphic;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X21_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]");
			object obj = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v4+E0]");
			if ((nint)0 != 0)
			{
				if (graphic != null)
				{
					goto IL_003a;
				}
				return;
			}
			goto IL_005b;
			IL_005b:
			if (!(graphic != null))
			{
				return;
			}
			goto IL_003a;
			IL_003a:
			global::UnityEngine.UI.Graphic graphic2 = base.graphic;
			nint num2 = (nint)graphic2;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v111 @ X8_v4 (Il2CppClass<UnityEngine.UI.Graphic>)+2F8] (should have been resolved before IL gen)");
			goto IL_005b;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003ED")]
	[global::Cpp2ILInjected.Address(RVA = "0x10194BC", Offset = "0x10194BC", Length = "0x1B0")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_002B;\n\tv35 = Il2CppMethodInfo;\n\tv36 = v35 + 0xAB0;\n\tv37 = \"il2cpp_codegen_initialize_runtime_metadata\"(v36, vh, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv62 = Il2CppMethodInfo;\n\tv63 = v62 + 0xAD0;\n\tv64 = \"il2cpp_codegen_initialize_runtime_metadata\"(v63, vh, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv241 = Il2CppMethodInfo;\n\tv242 = v241 + 0xAD8;\n\tv243 = \"il2cpp_codegen_initialize_runtime_metadata\"(v242, vh, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv313 = Il2CppMethodInfo;\n\tv314 = v313 + 0xAE8;\n\tv315 = \"il2cpp_codegen_initialize_runtime_metadata\"(v314, vh, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv317 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv318 = v317 + 0x510;\n\tv53 = \"il2cpp_codegen_initialize_runtime_metadata\"(v318, vh, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv55 = 1;\n\t*([302AA9F]) = v55;\nL_002B:\n\tv60 = UnityEngine.EventSystems.UIBehaviour::IsActive(this);\n\tv61 = ~v60;\n\tif (v61) goto L_00B2;\n\tv65 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv70 = new *([v65 @ X8_v5 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+510])();\n\tSystem.Collections.Generic.List`1<UnityEngine.UIVertex>::.ctor(v70);\n\tUnityEngine.UI.VertexHelper::GetUIVertexStream(vh, v70);\n\tv334 = v70._size < 1;\n\tif (v334) goto L_00A0;\n\tv336 = &v179 @ stack_-D0 (UnityEngine.Vector3);\n\tv338 = &v179 @ stack_-D0 (UnityEngine.Vector3) + 0x5C;\nL_0058:\n\tv456 = System.Collections.Generic.List`1<UnityEngine.UIVertex>::get_Item(v70, v449);\n\tv179 = v456.position;\n\t*([v336 @ X23_v4+3C]) = *([v336 @ X23_v4+3C]);\n\t*([v336 @ X23_v4+4C]) = this.secondaryColor;\n\t*([v338 @ X24_v4]) = *([v338 @ X24_v4]);\n\tSystem.Collections.Generic.List`1<UnityEngine.UIVertex>::set_Item(v70, v449, &v179 @ stack_-D0 (UnityEngine.Vector3));\n\tv449 = v449 + 1;\n\tv381 = v449 < v70._size;\n\tif (v381) goto L_0058;\nL_00A0:\n\tUnityEngine.UI.VertexHelper::Clear(vh);\n\tUnityEngine.UI.VertexHelper::AddUIVertexTriangleStream(vh, v70);\nL_00B2:\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 138 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public unsafe override void ModifyMesh(global::UnityEngine.UI.VertexHelper vh)
	{
		//IL_0013: Expected I, but got O
		//IL_006e: Expected O, but got I
		//IL_0108: Expected O, but got Ref
		if (!base.IsActive())
		{
			return;
		}
		nint num = (nint)typeof(global::System.Collections.Generic.List<global::UnityEngine.UIElements.StyleSheets.Syntax.Expression>);
		global::System.Collections.Generic.List<global::UnityEngine.UIVertex> list = new global::System.Collections.Generic.List<global::UnityEngine.UIVertex>();
		vh.GetUIVertexStream(list);
		if (list.Count >= 1)
		{
			global::UnityEngine.Vector3 position = default(global::UnityEngine.Vector3);
			object obj = position;
			object obj2 = (nint)position + 92;
			int num2 = 0;
			do
			{
				position = list[num2].position;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X23_v4+3C]");
				_ = 0;
				_ = secondaryColor;
				obj2 = obj2;
				list[num2] = (global::UnityEngine.UIVertex)(&position);
				num2++;
			}
			while (num2 < list.Count);
		}
		vh.Clear();
		vh.AddUIVertexTriangleStream(list);
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003EE")]
	[global::Cpp2ILInjected.Address(RVA = "0x101966C", Offset = "0x101966C", Length = "0x10")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tthis.secondaryColor = 0;\n\tUnityEngine.UI.BaseMeshEffect::.ctor(this);\n\treturn;\n// 2 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public SecondaryImageColor()
	{
		secondaryColor = default(global::UnityEngine.Color);
	}
}
