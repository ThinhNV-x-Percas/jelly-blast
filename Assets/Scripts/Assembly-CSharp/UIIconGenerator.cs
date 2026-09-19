[global::Cpp2ILInjected.Token(Token = "0x20000E2")]
public class UIIconGenerator : Singleton<UIIconGenerator>
{
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x20000E4")]
	private sealed class _003C_003Ec__DisplayClass12_0
	{
		[global::Cpp2ILInjected.Token(Token = "0x40004B3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public global::UnityEngine.Color color;

		[global::Cpp2ILInjected.Token(Token = "0x600041B")]
		[global::Cpp2ILInjected.Address(RVA = "0x101C478", Offset = "0x101C478", Length = "0x8")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tSystem.Object::.ctor(this);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public _003C_003Ec__DisplayClass12_0()
		{
		}

		internal void _003CRenderColorIcon_003Eb__0(global::UnityEngine.MaterialPropertyBlock pb)
		{
			//IL_0080: Expected O, but got I
			//IL_009a: Expected O, but got I
			string text = "Writing object reference to Id '{0}' for {1}.";
			string text2 = "Writing object reference to Id '{0}' for {1}.";
			global::UnityEngine.Color value = default(global::UnityEngine.Color);
			value.r = color.r;
			value.g = color.g;
			value.b = color.b;
			value.a = color.a;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3 (System.String)+900]");
			pb.SetColor((string)0, value);
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X21_v2 (System.String)+898]");
			pb.SetFloat((string)0, 0.3f);
		}
	}

	[global::UnityEngine.Header("Render settings")]
	[global::Cpp2ILInjected.Token(Token = "0x40004A3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public int renderLayer;

	[global::Cpp2ILInjected.Token(Token = "0x40004A4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public global::UnityEngine.Camera renderCamera;

	[global::Cpp2ILInjected.Token(Token = "0x40004A5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public int resolution;

	[global::UnityEngine.Header("Prefabs & Materials")]
	[global::Cpp2ILInjected.Token(Token = "0x40004A6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public global::UnityEngine.MeshRenderer quadPrefab;

	[global::Cpp2ILInjected.Token(Token = "0x40004A7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	private global::UnityEngine.MaterialPropertyBlock _propBlock;

	[global::Cpp2ILInjected.Token(Token = "0x40004A8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public global::UnityEngine.Texture2D fluidTex;

	[global::Cpp2ILInjected.Token(Token = "0x40004A9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	private global::UnityEngine.Texture2DArray fluidTexArray;

	[global::Cpp2ILInjected.Token(Token = "0x40004AA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public global::UnityEngine.Texture2D reflectionTex;

	[global::Cpp2ILInjected.Token(Token = "0x40004AB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public global::UnityEngine.Material colorMaterial;

	[global::UnityEngine.Header("Custom PNG Icons")]
	[global::Cpp2ILInjected.Token(Token = "0x40004AC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public global::UnityEngine.Sprite fishIconSprite;

	[global::Cpp2ILInjected.Token(Token = "0x6000404")]
	[global::Cpp2ILInjected.Address(RVA = "0x101A750", Offset = "0x101A750", Length = "0x84")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = Facebook.Unity.Windows.IWindowsFacebook;\n\tgoto L_0017;\n\tv23 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv24 = v23 + 0x900;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv43 = 1;\n\t*([302AAA6]) = v43;\nL_0017:\n\tv45 = new *([v18 @ X21_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+900])();\n\tUnityEngine.MaterialPropertyBlock::.ctor(v45);\n\tv49 = this + 0x40;\n\tthis._propBlock = v45;\n\tv51 = 0xF3F1B4(v49, v45, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv53 = UIIconGenerator::CreateArrayFromTexture(v51, this.fluidTex);\n\tv55 = this + 0x50;\n\tthis.fluidTexArray = v53;\n\tv63 = 0xF3F1B4(v55, v53, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\treturn;\n// 30 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void Awake()
	{
		//IL_000e: Expected I, but got O
		//IL_0062: Expected O, but got I
		//IL_0032: Expected O, but got I
		nint num = 0;
		global::UnityEngine.MaterialPropertyBlock propBlock = new global::UnityEngine.MaterialPropertyBlock();
		_propBlock = propBlock;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		UIIconGenerator uIIconGenerator = default(UIIconGenerator);
		global::UnityEngine.Texture2DArray texture2DArray = uIIconGenerator.CreateArrayFromTexture(fluidTex);
		fluidTexArray = texture2DArray;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000405")]
	[global::Cpp2ILInjected.Address(RVA = "0x100A6B8", Offset = "0x100A6B8", Length = "0x8D0")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0044;\n\tv37 = System.Collections.Generic.NullableComparer`1;\n\tv38 = v37 + 0xCE8;\n\tv39 = \"il2cpp_codegen_initialize_runtime_metadata\"(v38, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);\n\tv64 = Il2CppMethodInfo;\n\tv65 = v64 + 0x7E8;\n\tv66 = \"il2cpp_codegen_initialize_runtime_metadata\"(v65, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);\n\tv178 = Il2CppMethodInfo;\n\tv179 = v178 + 0x7F0;\n\tv180 = \"il2cpp_codegen_initialize_runtime_metadata\"(v179, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);\n\tv184 = Il2CppMethodInfo;\n\tv185 = v184 + 0x7F8;\n\tv186 = \"il2cpp_codegen_initialize_runtime_metadata\"(v185, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);\n\tv190 = Il2CppMethodInfo;\n\tv191 = v190 + 0xC0;\n\tv192 = \"il2cpp_codegen_initialize_runtime_metadata\"(v191, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);\n\tv292 = Il2CppMethodInfo;\n\tv293 = v292 + 0xC90;\n\tv294 = \"il2cpp_codegen_initialize_runtime_metadata\"(v293, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);\n\tv306 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv307 = v306 + 0xA48;\n\tv308 = \"il2cpp_codegen_initialize_runtime_metadata\"(v307, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);\n\tv325 = Il2CppMethodInfo;\n\tv326 = v325 + 0x3F8;\n\tv327 = \"il2cpp_codegen_initialize_runtime_metadata\"(v326, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);\n\tv332 = Il2CppMethodInfo;\n\tv333 = v332 + 0x400;\n\tv334 = \"il2cpp_codegen_initialize_runtime_metadata\"(v333, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);\n\tv345 = Il2CppMethodInfo;\n\tv346 = v345 + 0x408;\n\tv347 = \"il2cpp_codegen_initialize_runtime_metadata\"(v346, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);\n\tv353 = Sponge+<>c__DisplayClass7_0;\n\tv354 = v353 + 0x450;\n\tv355 = \"il2cpp_codegen_initialize_runtime_metadata\"(v354, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);\n\tv456 = Il2CppMethodInfo;\n\tv457 = v456 + 0x408;\n\tv458 = \"il2cpp_codegen_initialize_runtime_metadata\"(v457, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);\n\tv460 = Il2CppMethodInfo;\n\tv461 = v460 + 0x410;\n\tv56 = \"il2cpp_codegen_initialize_runtime_metadata\"(v461, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);\n\tv58 = 1;\n\t*([302AAA7]) = v58;\nL_0044:\n\tv63 = this.renderCamera == 0;\n\tif (v63) goto L_0242;\n\tv69 = Il2CppMethodInfo;\n\tUnityEngine.Behaviour::set_enabled(this.renderCamera, 1);\n\tv182 = UnityEngine.RenderTexture::GetTemporary(this.resolution, this.resolution, 0, 0);\n\tgoto L_005B;\n\tv193 = \"il2cpp_codegen_runtime_class_init\"(v187, v155, v152, v149, v146, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);\nL_005B:\n\tv162 = Singleton`1::get_Instance /* +1 sharing this address */(*([v69 @ X27_v5 (Il2CppMethodInfo)+C90]));\n\tv166 = v162 == 0;\n\tif (v166) goto L_0242;\n\tv172 = *([v162 @ X0_v27+78]);\n\tv167 = *([v162 @ X0_v27+78]) == 0;\n\tif (v167) goto L_0242;\n\tv168 = *([v172 @ X8_v10+50]) == 0;\n\tif (v168) goto L_0242;\n\tv337 = Il2CppMethodInfo;\n\tv341 = System.Collections.Generic.List`1<System.Object>::GetEnumerator(*([v172 @ X8_v10+50]));\n\tv249 = 0x2875000 + 0xAA0;\n\tgoto L_007B;\n\tX1 = *([X19+68]);\n\tX21 = X21 + 0x28;\n\t*([X21]) = X1;\n\tX0 = X21;\n\tX0 = 0xF3F1B4(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\nL_007B:\n\tv315 = *([v337 @ X28_v5 (Il2CppMethodInfo)+7F0]);\n\tv378 = System.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>::MoveNext(&v340 @ stack_-A8_v6 (System.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>));\n\tv385 = v378 == 0;\n\tif (v385) goto L_021E;\n\tv284 = v350 == 0;\n\tif (v284) goto L_023C;\n\tv449 = *([v350 @ stack_-98+10]);\n\tv463 = *([v350 @ stack_-98+10]) < 8;\n\tv245 = ~v463;\n\tv242 = *([v350 @ stack_-98+10]) - 8;\n\tv236 = v242 == 0;\n\tv464 = ~v236;\n\tv221 = v245 & v464;\n\tif (v221) goto L_015B;\n\tv407 = *([v249 @ X26_v6 (System.Int32)+v449 @ X8_v19]) << 2;\n\tv413 = 0x100A848 + v407;\n\t// 149 IndirectJump v413 @ X9_v8 (System.Int32), v378 @ X0_v32 (System.Boolean), v378 @ X0_v32 (System.Boolean), v315 @ X1_v2 (UnityEngine.RenderTexture), v272 @ X2_v8 (System.Int32), v267 @ X3_v1 (UnityEngine.RenderTextureFormat), 0, v44 @ X5, v45 @ X6, v46 @ X7, v259 @ V0_v5 (System.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>), 0, v482 @ X0_v43 (System.Int32), v485 @ X0_v45 (System.Int32), 0.5f, 0.5f, 1120403456, v54 @ V7\n\tX22 = *([X21+14]);\n\tX0 = *([X24]);\n\tX8 = *([X0+E0]);\n\tTEMP = ~TEMP;\n\tif (TEMP) goto L_009D;\n\tX0 = 0xF3F368(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\nL_009D:\n\tX0 = *([X27]);\n\tX0 = Singleton`1::get_Instance /* +1 sharing this address */(X0);\n\tif (TEMP) goto L_0251;\n\tX8 = *([X0+78]);\n\tif (TEMP) goto L_024B;\n\tX8 = *([X8+28]);\n\tif (TEMP) goto L_0243;\n\tX9 = *([X8+18]);\n\tC = X22 < X9;\n\tC = ~C;\n\tTEMP1 = X22 - X9;\n\tN = TEMP1 < 0;\n\tTEMP2 = X22 ^ X9;\n\tTEMP3 = X22 ^ TEMP1;\n\tTEMP4 = TEMP2 & TEMP3;\n\tV = TEMP4 < 0;\n\tif (C) goto L_0253;\n\tTEMPSHIFT = X22 << 4;\n\tX8 = X8 + TEMPSHIFT;\n\tV0 = *([X8+20]);\n\tV1 = *([X8+24]);\n\tV2 = *([X8+28]);\n\tV3 = *([X8+2C]);\n\tX0 = X19;\n\tX1 = X20;\n\t// 186 MakeStruct AGG100A8DC_2, typeof(UnityEngine.Color), V0, V1, V2, V3\n\tUIIconGenerator::RenderColorIcon(X0, X1, AGG100A8DC_2, X2);\n\tgoto L_01FB;\n\tX0 = X19;\n\tX1 = X20;\n\tUIIconGenerator::RenderSnowIcon(X0, X1, X2);\n\tgoto L_01FB;\n\tX0 = *([X24]);\n\tX8 = *([X0+E0]);\n\tTEMP = ~TEMP;\n\tif (TEMP) goto L_00C7;\n\tX0 = 0xF3F368(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\nL_00C7:\n\tX0 = *([X27]);\n\tX0 = Singleton`1::get_Instance /* +1 sharing this address */(X0);\n\tif (TEMP) goto L_024F;\n\tX0 = *([X0+F0]);\n\tif (TEMP) goto L_024D;\n\tX1 = 0;\n\tX0 = UnityEngine.Component::get_gameObject(X0, X1);\n\tX22 = X0;\n\tX8 = X8 + 0xCE8;\n\tX0 = *([X8]);\n\tX0 = 0xF3F48C(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX23 = X0;\n\tX8 = X8 + 0x410;\n\tX2 = *([X8]);\n\tX1 = X19;\n\tX3 = 0;\n\tSystem.Action`1<System.Object>::.ctor(X0, X1, X2, X3);\n\tX8 = 0x999A;\n\tX8 = X8 | 0x3E990000;\n\tV0 = X8;\n\tX0 = X19;\n\tX1 = X20;\n\tX2 = X22;\n\tX3 = X23;\n\tUIIconGenerator::RenderObjectIcon(X0, X1, X2, V0, X3, X4);\n\tgoto L_01FB;\n\tX0 = X19;\n\tX1 = X20;\n\tUIIconGenerator::RenderMudIcon(X0, X1, X2);\n\tgoto L_01FB;\n\tX0 = *([X24]);\n\tX8 = *([X0+E0]);\n\tTEMP = ~TEMP;\n\tif (TEMP) goto L_00EF;\n\tX0 = 0xF3F368(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\nL_00EF:\n\tX0 = *([X27]);\n\tX0 = Singleton`1::get_Instance /* +1 sharing this address */(X0);\n\tif (TEMP) goto L_0255;\n\tX0 = *([X0+100]);\n\tif (TEMP) goto L_0247;\n\tX1 = 0;\n\tX0 = UnityEngine.Component::get_gameObject(X0, X1);\n\tX22 = X0;\n\tX8 = X8 + 0x450;\n\tX0 = *([X8]);\n\tX8 = *([X0+E0]);\n\tif (TEMP) goto L_01CA;\n\tX8 = *([X0+B8]);\n\tX23 = *([X8+18]);\n\tTEMP = ~TEMP;\n\tif (TEMP) goto L_01F2;\n\tgoto L_01D3;\n\tX0 = *([X24]);\n\tX8 = *([X0+E0]);\n\tTEMP = ~TEMP;\n\tif (TEMP) goto L_010B;\n\tX0 = 0xF3F368(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\nL_010B:\n\tX0 = *([X27]);\n\tX0 = Singleton`1::get_Instance /* +1 sharing this address */(X0);\n\tif (TEMP) goto L_0245;\n\tX0 = *([X0+E8]);\n\tif (TEMP) goto L_0259;\n\tX1 = 0;\n\tX0 = UnityEngine.Component::get_gameObject(X0, X1);\n\tX22 = X0;\n\tX8 = X8 + 0xCE8;\n\tX0 = *([X8]);\n\tX0 = 0xF3F48C(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX23 = X0;\n\tX8 = X8 + 0x408;\n\tX2 = *([X8]);\n\tX1 = X19;\n\tX3 = 0;\n\tSystem.Action`1<System.Object>::.ctor(X0, X1, X2, X3);\n\tX8 = 0x999A;\n\tX8 = X8 | 0x3E990000;\n\tV0 = X8;\n\tX0 = X19;\n\tX1 = X20;\n\tX2 = X22;\n\tX3 = X23;\n\tUIIconGenerator::RenderObjectIcon(X0, X1, X2, V0, X3, X4);\n\tgoto L_01FB;\n\tX0 = *([X24]);\n\tX8 = *([X0+E0]);\n\tTEMP = ~TEMP;\n\tif (TEMP) goto L_012F;\n\tX0 = 0xF3F368(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\nL_012F:\n\tX0 = *([X27]);\n\tX0 = Singleton`1::get_Instance /* +1 sharing this address */(X0);\n\tif (TEMP) goto L_0257;\n\tX22 = *([X0+148]);\n\tX8 = X8 + 0x450;\n\n// ... truncated")]
	public unsafe void UpdateIcons()
	{
		//IL_0084: Expected O, but got I
		//IL_00e6: Expected O, but got I
		//IL_0129: Expected O, but got I
		//IL_0453: Expected F4, but got O
		//IL_0465: Expected O, but got I4
		//IL_0180: Expected O, but got I
		//IL_01b8: Expected O, but got I
		//IL_0234: Expected F4, but got O
		//IL_04df: Expected O, but got I4
		//IL_0557: Expected O, but got I
		//IL_0596: Expected I4, but got O
		//IL_049e: Expected O, but got I4
		//IL_03b1: Expected O, but got I
		if ((object)renderCamera != null)
		{
			nint num = 0;
			renderCamera.enabled = true;
			global::UnityEngine.RenderTexture temporary = global::UnityEngine.RenderTexture.GetTemporary(resolution, resolution, 0, default(global::UnityEngine.RenderTextureFormat));
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
			object obj = default(object);
			if (obj != null)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v27+78]");
				object obj2 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v27+78]");
				if ((nint)0 != 0)
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v10+50]");
					if ((nint)0 != 0)
					{
						nint num2 = 0;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v10+50]");
						object enumerator = ((global::System.Collections.Generic.List<object>)0).GetEnumerator();
						int num3 = 42422272 + 2720;
						global::System.Collections.Generic.List<object>.Enumerator enumerator3 = default(global::System.Collections.Generic.List<object>.Enumerator);
						global::System.Collections.Generic.List<object>.Enumerator enumerator2 = enumerator3;
						global::UnityEngine.RenderTextureFormat renderTextureFormat = default(global::UnityEngine.RenderTextureFormat);
						int num4 = 0;
						object obj3 = default(object);
						global::UnityEngine.Rect rect = default(global::UnityEngine.Rect);
						global::UnityEngine.Vector2 pivot = default(global::UnityEngine.Vector2);
						global::UnityEngine.RenderTexture temp;
						object obj9 = default(object);
						while (true)
						{
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X28_v5 (Il2CppMethodInfo)+7F0]");
							global::UnityEngine.RenderTexture renderTexture = (global::UnityEngine.RenderTexture)0;
							global::System.NullReferenceException ex;
							object obj7;
							if (enumerator3.MoveNext())
							{
								if (obj3 != null)
								{
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ stack_-98+10]");
									object obj4 = 0;
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ stack_-98+10]");
									bool flag = (nint)0 < (nint)8;
									bool flag2 = !flag;
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ stack_-98+10]");
									object obj5 = -8;
									bool flag3 = obj5 == null;
									bool flag4 = !flag3;
									if (!(flag2 && flag4))
									{
										global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X26_v6 (System.Int32)+v449 @ X8_v19]");
										int num5 = (int)((nint)0 << 2);
										int num6 = 16820296 + num5;
										global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v413 @ X9_v8 (System.Int32) (should have been resolved before IL gen)");
									}
									bool flag5 = (object)renderCamera == null;
									float num7 = (float)enumerator2;
									int num8;
									object obj8;
									if (!flag5)
									{
										renderCamera.orthographicSize = 0.3f;
										bool flag6 = (object)renderCamera == null;
										num7 = 0.3f;
										renderTexture = null;
										if (!flag6)
										{
											renderCamera.targetTexture = temporary;
											bool flag7 = (object)renderCamera == null;
											num7 = 0.3f;
											num4 = 0;
											renderTexture = temporary;
											if (!flag7)
											{
												renderCamera.Render();
												global::UnityEngine.Texture2D texture2D = ((UIIconGenerator)(object)renderCamera).ConvertRenderTextureToTexture2D(temporary);
												if ((object)texture2D != null)
												{
													int width = texture2D.width;
													int height = texture2D.height;
													rect.m_XMin = 0f;
													rect.m_YMin = 0f;
													rect.m_Width = width;
													rect.m_Height = height;
													pivot.x = 0.5f;
													pivot.y = 0.5f;
													global::UnityEngine.Sprite sprite = global::UnityEngine.Sprite.Create(texture2D, rect, pivot, 100f, 0u, default(global::UnityEngine.SpriteMeshType));
													object obj6 = (nint)obj3 + 40;
													obj6 = sprite;
													global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
													enumerator2 = default(global::System.Collections.Generic.List<object>.Enumerator);
													renderTextureFormat = default(global::UnityEngine.RenderTextureFormat);
													num4 = 0;
													continue;
												}
												ex = new global::System.NullReferenceException();
												obj7 = enumerator3;
												num7 = 0.3f;
												num8 = 0;
												obj8 = 0;
												num4 = 0;
												renderTexture = temporary;
												temp = temporary;
												goto IL_0500;
											}
										}
									}
									ex = new global::System.NullReferenceException();
									obj7 = enumerator3;
									num8 = 0;
									obj8 = 0;
									temp = temporary;
								}
								else
								{
									ex = new global::System.NullReferenceException();
									obj7 = enumerator3;
									float num7 = (float)enumerator2;
									int num8 = 0;
									object obj8 = 0;
									temp = temporary;
								}
								goto IL_0500;
							}
							enumerator3.Dispose();
							temp = temporary;
							break;
							IL_0500:
							bool flag8 = (nint)renderTexture != 1;
							global::System.NullReferenceException ex2 = ex;
							if (!flag8)
							{
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A080 (inside System.__Il2CppComDelegate::Finalize +0xF54)");
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A098 (inside System.__Il2CppComDelegate::Finalize +0xF6C)");
								nint num9 = 0;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X8_v5 (Il2CppMethodInfo)+7E8]");
								renderTexture = (global::UnityEngine.RenderTexture)0;
								obj7.Dispose();
								if (obj9 == null)
								{
									break;
								}
								global::System.OutOfMemoryException ex3 = new global::System.OutOfMemoryException();
								ex2 = (global::System.NullReferenceException)(object)ex3;
								int num8 = (int)obj9;
							}
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BF138C");
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27498DC (inside System.__Il2CppComDelegate::Finalize +0x7B0)");
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D6F8");
							return;
						}
						global::UnityEngine.RenderTexture.ReleaseTemporary(temp);
						if ((object)renderCamera != null)
						{
							renderCamera.enabled = false;
							return;
						}
					}
				}
			}
		}
		global::System.NullReferenceException ex4 = new global::System.NullReferenceException();
		throw ex4;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000406")]
	[global::Cpp2ILInjected.Address(RVA = "0x101A90C", Offset = "0x101A90C", Length = "0x100")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv40 = Sponge+<>c__DisplayClass7_0;\n\tgoto L_002B;\n\tv45 = System.Collections.Generic.NullableComparer`1;\n\tv46 = v45 + 0xCE8;\n\tv47 = \"il2cpp_codegen_initialize_runtime_metadata\"(v46, targetRT, methodInfo, v49, v50, v51, v52, v53, color, v0, v2, v3, v54, v55, v56, v57);\n\tv64 = Il2CppMethodInfo;\n\tv65 = v64 + 0x410;\n\tv66 = \"il2cpp_codegen_initialize_runtime_metadata\"(v65, targetRT, methodInfo, v49, v50, v51, v52, v53, color, v0, v2, v3, v54, v55, v56, v57);\n\tv69 = Sponge+<>c__DisplayClass7_0;\n\tv70 = v69 + 0x458;\n\tv59 = \"il2cpp_codegen_initialize_runtime_metadata\"(v70, targetRT, methodInfo, v49, v50, v51, v52, v53, color, v0, v2, v3, v54, v55, v56, v57);\n\tv61 = 1;\n\t*([302AAA8]) = v61;\nL_002B:\n\tv63 = new *([v40 @ X22_v1 (Il2CppClass<Sponge+<>c__DisplayClass7_0>)+458])();\n\tUIIconGenerator+<>c__DisplayClass12_0::.ctor(v63);\n\tv72 = System.Collections.Generic.NullableComparer`1;\n\tv74 = Il2CppMethodInfo;\n\tv63.color = color;\n\tv63.color.g = color.g;\n\tv63.color.b = color.b;\n\tv63.color.a = color.a;\n\tv78 = new *([v72 @ X8_v3 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+CE8])();\n\tSystem.Action`1<UnityEngine.MaterialPropertyBlock>::.ctor(v78, v63, *([v74 @ X24_v1 (Il2CppMethodInfo)+410]));\n\tUIIconGenerator::RenderFluidIcon(this, targetRT, this.colorMaterial, 0.3f, v78);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 62 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void RenderColorIcon(global::UnityEngine.RenderTexture targetRT, global::UnityEngine.Color color)
	{
		//IL_000e: Expected I, but got O
		//IL_0021: Expected I, but got O
		nint num = 0;
		UIIconGenerator._003C_003Ec__DisplayClass12_0 _003C_003Ec__DisplayClass12_1 = new UIIconGenerator._003C_003Ec__DisplayClass12_0();
		nint num2 = 0;
		nint num3 = 0;
		_003C_003Ec__DisplayClass12_1.color = color;
		_003C_003Ec__DisplayClass12_1.color.g = color.g;
		_003C_003Ec__DisplayClass12_1.color.b = color.b;
		_003C_003Ec__DisplayClass12_1.color.a = color.a;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X24_v1 (Il2CppMethodInfo)+410]");
		global::System.Action<global::UnityEngine.MaterialPropertyBlock> pb = null;
		RenderFluidIcon(targetRT, colorMaterial, 0.3f, pb);
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000407")]
	[global::Cpp2ILInjected.Address(RVA = "0x101AA0C", Offset = "0x101AA0C", Length = "0x188")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv22 = 0x302A000;\n\tv24 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv26 = *([302AAA9]) & 1;\n\tv27 = v26 == 0;\n\tif (v27) goto L_002F;\n\tv56 = Il2CppMethodInfo + 0xC90;\n\tv30 = *([v24 @ X21_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A48]);\n\tv32 = *([v30 @ X0_v41+E0]) == 0;\n\tif (v32) goto L_0039;\nL_001A:\n\tv75 = Singleton`1::get_Instance /* +1 sharing this address */(*([v56 @ X22_v14]));\n\tv68 = v75 == 0;\n\tv69 = ~v68;\n\tif (v69) goto L_003C;\n\tgoto L_007E;\nL_002F:\n\t*([v22 @ X22_v1+AA9]) = 1;\n\tv56 = Il2CppMethodInfo + 0xC90;\n\tv51 = *([v24 @ X21_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A48]);\n\tv136 = *([v51 @ X0_v37+E0]) == 0;\n\tv53 = ~v136;\n\tif (v53) goto L_001A;\nL_0039:\n\tv75 = Singleton`1::get_Instance /* +1 sharing this address */(*([v63 @ X22_v11]));\nL_003C:\n\tv80 = Sponge+<>c__DisplayClass7_0;\n\tv83 = *([v80 @ X24_v2 (Il2CppClass<Sponge+<>c__DisplayClass7_0>)+450]);\n\tv85 = *([v83 @ X0_v4+E0]) == 0;\n\tif (v85) goto L_005C;\n\tv179 = *([v83 @ X0_v4+B8]);\n\tv175 = *([v179 @ X8_v6+20]);\n\tv117 = *([v179 @ X8_v6+20]) == 0;\n\tif (v117) goto L_0065;\nL_0059:\n\tUIIconGenerator::RenderFluidIcon(this, targetRT, *([v75 @ X0_v3+128]), 0.3f, v175);\n\treturn;\nL_005C:\n\tv122 = *([v80 @ X24_v2 (Il2CppClass<Sponge+<>c__DisplayClass7_0>)+450]);\n\tv179 = *([v122 @ X0_v14+B8]);\n\tv175 = *([v179 @ X8_v6+20]);\n\tv133 = *([v179 @ X8_v6+20]) == 0;\n\tv124 = ~v133;\n\tif (v124) goto L_0059;\nL_0065:\n\tgoto L_006A;\n\tv177 = \"il2cpp_codegen_runtime_class_init\"(v127, targetRT, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49);\n\tv185 = *([v81 @ X24_v3]);\n\tv180 = *([v185 @ X8_v12+B8]);\nL_006A:\n\tv181 = System.Collections.Generic.NullableComparer`1;\n\tv184 = new *([v181 @ X8_v7 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+CE8])();\n\tv186 = Il2CppMethodInfo;\n\tSystem.Action`1<UnityEngine.MaterialPropertyBlock>::.ctor(v184, *([v179 @ X8_v6]), *([v186 @ X8_v9 (Il2CppMethodInfo)+3E8]));\n\tv109 = *([v80 @ X24_v2 (Il2CppClass<Sponge+<>c__DisplayClass7_0>)+450]);\n\tv190 = *([v109 @ X8_v11+B8]) + 0x20;\n\t*([v190 @ X0_v10]) = v184;\n\tv102 = 0xF3F1B4(v190, v184, *([v186 @ X8_v9 (Il2CppMethodInfo)+3E8]), 0, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49);\n\tv191 = this == 0;\n\tv105 = ~v191;\n\tif (v105) goto L_0059;\nL_007E:\n\tthrow System.NullReferenceException;\n// 75 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void RenderMudIcon(global::UnityEngine.RenderTexture targetRT)
	{
		RenderFluidIcon(targetRT, global::Singleton<GameManager>.Instance.mudMaterial, 0.3f, null);
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000408")]
	[global::Cpp2ILInjected.Address(RVA = "0x101AB94", Offset = "0x101AB94", Length = "0x188")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv22 = 0x302A000;\n\tv24 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv26 = *([302AAAA]) & 1;\n\tv27 = v26 == 0;\n\tif (v27) goto L_002F;\n\tv56 = Il2CppMethodInfo + 0xC90;\n\tv30 = *([v24 @ X21_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A48]);\n\tv32 = *([v30 @ X0_v41+E0]) == 0;\n\tif (v32) goto L_0039;\nL_001A:\n\tv75 = Singleton`1::get_Instance /* +1 sharing this address */(*([v56 @ X22_v14]));\n\tv68 = v75 == 0;\n\tv69 = ~v68;\n\tif (v69) goto L_003C;\n\tgoto L_007E;\nL_002F:\n\t*([v22 @ X22_v1+AAA]) = 1;\n\tv56 = Il2CppMethodInfo + 0xC90;\n\tv51 = *([v24 @ X21_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A48]);\n\tv136 = *([v51 @ X0_v37+E0]) == 0;\n\tv53 = ~v136;\n\tif (v53) goto L_001A;\nL_0039:\n\tv75 = Singleton`1::get_Instance /* +1 sharing this address */(*([v63 @ X22_v11]));\nL_003C:\n\tv80 = Sponge+<>c__DisplayClass7_0;\n\tv83 = *([v80 @ X24_v2 (Il2CppClass<Sponge+<>c__DisplayClass7_0>)+450]);\n\tv85 = *([v83 @ X0_v4+E0]) == 0;\n\tif (v85) goto L_005C;\n\tv179 = *([v83 @ X0_v4+B8]);\n\tv175 = *([v179 @ X8_v6+28]);\n\tv117 = *([v179 @ X8_v6+28]) == 0;\n\tif (v117) goto L_0065;\nL_0059:\n\tUIIconGenerator::RenderFluidIcon(this, targetRT, *([v75 @ X0_v3+138]), 0.3f, v175);\n\treturn;\nL_005C:\n\tv122 = *([v80 @ X24_v2 (Il2CppClass<Sponge+<>c__DisplayClass7_0>)+450]);\n\tv179 = *([v122 @ X0_v14+B8]);\n\tv175 = *([v179 @ X8_v6+28]);\n\tv133 = *([v179 @ X8_v6+28]) == 0;\n\tv124 = ~v133;\n\tif (v124) goto L_0059;\nL_0065:\n\tgoto L_006A;\n\tv177 = \"il2cpp_codegen_runtime_class_init\"(v127, targetRT, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49);\n\tv185 = *([v81 @ X24_v3]);\n\tv180 = *([v185 @ X8_v12+B8]);\nL_006A:\n\tv181 = System.Collections.Generic.NullableComparer`1;\n\tv184 = new *([v181 @ X8_v7 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+CE8])();\n\tv186 = Il2CppMethodInfo;\n\tSystem.Action`1<UnityEngine.MaterialPropertyBlock>::.ctor(v184, *([v179 @ X8_v6]), *([v186 @ X8_v9 (Il2CppMethodInfo)+3F0]));\n\tv109 = *([v80 @ X24_v2 (Il2CppClass<Sponge+<>c__DisplayClass7_0>)+450]);\n\tv190 = *([v109 @ X8_v11+B8]) + 0x28;\n\t*([v190 @ X0_v10]) = v184;\n\tv102 = 0xF3F1B4(v190, v184, *([v186 @ X8_v9 (Il2CppMethodInfo)+3F0]), 0, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49);\n\tv191 = this == 0;\n\tv105 = ~v191;\n\tif (v105) goto L_0059;\nL_007E:\n\tthrow System.NullReferenceException;\n// 75 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void RenderSnowIcon(global::UnityEngine.RenderTexture targetRT)
	{
		RenderFluidIcon(targetRT, global::Singleton<GameManager>.Instance.snowMaterial, 0.3f, null);
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000409")]
	[global::Cpp2ILInjected.Address(RVA = "0x101B060", Offset = "0x101B060", Length = "0x3E8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_003B;\n\tv43 = Il2CppMethodInfo;\n\tv44 = v43 + 0xB0;\n\tv45 = \"il2cpp_codegen_initialize_runtime_metadata\"(v44, targetRT, mat, pb, methodInfo, v47, v48, v49, orthoScale, v50, v51, v52, v53, v54, v55, v56);\n\tv67 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv68 = v67 + 0xFD8;\n\tv69 = \"il2cpp_codegen_initialize_runtime_metadata\"(v68, targetRT, mat, pb, methodInfo, v47, v48, v49, orthoScale, v50, v51, v52, v53, v54, v55, v56);\n\tv75 = Il2CppMethodInfo;\n\tv76 = v75 + 0xC90;\n\tv77 = \"il2cpp_codegen_initialize_runtime_metadata\"(v76, targetRT, mat, pb, methodInfo, v47, v48, v49, orthoScale, v50, v51, v52, v53, v54, v55, v56);\n\tv84 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv85 = v84 + 0xA48;\n\tv86 = \"il2cpp_codegen_initialize_runtime_metadata\"(v85, targetRT, mat, pb, methodInfo, v47, v48, v49, orthoScale, v50, v51, v52, v53, v54, v55, v56);\n\tv88 = \"Writing object reference to Id '{0}' for {1}.\";\n\tv89 = v88 + 0x9D8;\n\tv90 = \"il2cpp_codegen_initialize_runtime_metadata\"(v89, targetRT, mat, pb, methodInfo, v47, v48, v49, orthoScale, v50, v51, v52, v53, v54, v55, v56);\n\tv205 = \"Writing object reference to Id '{0}' for {1}.\";\n\tv206 = v205 + 0x9B0;\n\tv207 = \"il2cpp_codegen_initialize_runtime_metadata\"(v206, targetRT, mat, pb, methodInfo, v47, v48, v49, orthoScale, v50, v51, v52, v53, v54, v55, v56);\n\tv211 = \"Writing object reference to Id '{0}' for {1}.\";\n\tv212 = v211 + 0x9E0;\n\tv213 = \"il2cpp_codegen_initialize_runtime_metadata\"(v212, targetRT, mat, pb, methodInfo, v47, v48, v49, orthoScale, v50, v51, v52, v53, v54, v55, v56);\n\tv259 = \"Writing object reference to Id '{0}' for {1}.\";\n\tv260 = v259 + 0x958;\n\tv261 = \"il2cpp_codegen_initialize_runtime_metadata\"(v260, targetRT, mat, pb, methodInfo, v47, v48, v49, orthoScale, v50, v51, v52, v53, v54, v55, v56);\n\tv267 = \"Writing object reference to Id '{0}' for {1}.\";\n\tv268 = v267 + 0xA98;\n\tv269 = \"il2cpp_codegen_initialize_runtime_metadata\"(v268, targetRT, mat, pb, methodInfo, v47, v48, v49, orthoScale, v50, v51, v52, v53, v54, v55, v56);\n\tv272 = \"Writing object reference to Id '{0}' for {1}.\";\n\tv273 = v272 + 0xB40;\n\tv58 = \"il2cpp_codegen_initialize_runtime_metadata\"(v273, targetRT, mat, pb, methodInfo, v47, v48, v49, orthoScale, v50, v51, v52, v53, v54, v55, v56);\n\tv60 = 1;\n\t*([302AAAB]) = v60;\nL_003B:\n\tv61 = Il2CppMethodInfo;\n\tv66 = UnityEngine.Component::get_transform(this);\n\tgoto L_004B;\n\tv78 = \"il2cpp_codegen_runtime_class_init\"(v71, v65, mat, pb, methodInfo, v47, v48, v49, orthoScale, v50, v51, v52, v53, v54, v55, v56);\nL_004B:\n\tv83 = UnityEngine.Object::Instantiate /* +1 sharing this address */(this.quadPrefab, v66, *([v61 @ X26_v1 (Il2CppMethodInfo)+B0]));\n\tv93 = UnityEngine.Component::get_transform(v83);\n\tgoto L_005E;\n\tv214 = System.Xml.ValidateNames;\n\tv215 = v214 + 0xD0;\n\tv216 = \"il2cpp_codegen_initialize_runtime_metadata\"(v215, v92, v80, pb, methodInfo, v47, v48, v49, orthoScale, v50, v51, v52, v53, v54, v55, v56);\n\tv217 = 1;\n\t*([2DD4419]) = v217;\nL_005E:\n\tv262 = System.Xml.ValidateNames;\n\tv263 = *([v262 @ X27_v2 (Il2CppClass<System.Xml.ValidateNames>)+D0]);\n\tv264 = *([v263 @ X8_v7+B8]);\n\t// 103 MakeStruct v112 @ AGG101B1BC_1_v2 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), [v264 @ X8_v8], [v264 @ X8_v8+4], [v264 @ X8_v8+8]\n\tUnityEngine.Transform::set_localPosition(v93, v112);\n\tv271 = UnityEngine.Component::get_transform(v83);\n\tgoto L_007B;\n\tv277 = System.Xml.ValidateNames;\n\tv278 = v277 + 0xD0;\n\tv279 = \"il2cpp_codegen_initialize_runtime_metadata\"(v278, v148, v80, pb, methodInfo, v47, v48, v49, v119, v129, v124, v52, v53, v54, v55, v56);\n\tv280 = 1;\n\t*([2DD441A]) = v280;\nL_007B:\n\tv282 = Il2CppMethodInfo;\n\tv283 = *([v262 @ X27_v2 (Il2CppClass<System.Xml.ValidateNames>)+D0]);\n\tv284 = *([v283 @ X8_v11+B8]);\n\tv287 = *([v284 @ X8_v12+14]) * orthoScale;\n\tv121 = v287 + v287;\n\tv289 = *([v284 @ X8_v12+C]) * v290;\n\tv114 = v289 + v289;\n\t// 137 MakeStruct v107 @ AGG101B234_1_v2 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), v114 @ V0_v7, v291 @ V0.S1, v121 @ V2_v3 (System.Single)\n\tUnityEngine.Transform::set_localScale(v271, v107);\n\tUnityEngine.Renderer::set_material(v83, mat);\n\tUnityEngine.Renderer::GetPropertyBlock(v83, this._propBlock);\n\tgoto L_009B;\n\tv301 = \"il2cpp_codegen_runtime_class_init\"(v298, v137, v150, pb, methodInfo, v47, v48, v49, v114, v126, v121, v52, v53, v54, v55, v56);\nL_009B:\n\tv162 = Singleton`1::get_Instance /* +1 sharing this address */(*([v282 @ X26_v6 (Il2CppMethodInfo)+C90]));\n\tv164 = UnityEngine.Component::get_transform(*([v162 @ X0_v22+158]));\n\tv115 = UnityEngine.Transform::get_forward(v164);\n\tv304 = \"Writing object reference to Id '{0}' for {1}.\";\n\t// 177 MakeStruct v101 @ AGG101B2B0_2_v2 (UnityEngine.Vector4), typeof(UnityEngine.Vector4), v115 @ V0_v8 (UnityEngine.Vector3), v115.y (System.Single), v115.z (System.Single), 0\n\tUnityEngine.MaterialPropertyBlock::SetVector(this._propBlock, *([v304 @ X8_v14 (System.String)+A98]), v101);\n\tv306 = \"Writing object reference to Id '{0}' for {1}.\";\n\tUnityEngine.MaterialPropertyBlock::SetTexture(this._propBlock, *([v306 @ X8_v16 (System.String)+B40]), this.fluidTexArray);\n\tv311 = 0x101B51C(0, *([v306 @ X8_v16 (System.String)+B40]), this.fluidTexArray, 0, methodInfo, v47, v48, v49, 0, 0, 0, 0, v53, v54, v55, v56);\n\tv166 = UIIconGenerator::SolidColor(v311, v311, 1, 0);\n\tv312 = \"Writing object reference to Id '{0}' for {1}.\";\n\tUnityEngine.MaterialPropertyBlock::SetTexture(this._propBlock, *([v312 @ X8_v18 (System.String)+958]), v166);\n\tv314 = \"Writing object reference to Id '{0}' for {1}.\";\n\tUnityEngine.MaterialPropertyBlock::SetTexture(this._propBlock, *([v314 @ X8_v20 (System.String)+9D8]), this.reflectionTex);\n\tv315 = \"Writing object reference to Id '{0}' for {1}.\";\n\tUnityEngine.MaterialPropertyBlock::SetInt(this._propBlock, *([v315 @ X8_v22 (System.String)+9E0]), 0);\n\tv316 = \"Writing object reference to Id '{0}' for {1}.\";\n\tUnityEngine.MaterialPropertyBlock::SetFloat(this._propBlock, *([v316 @ X8_v24 (System.String)+9B0]), -1f);\n\tv320 = pb == 0;\n\tif (v320) goto L_00F5;\n\tpb.invoke_impl(v325, pb.method_code, this._propBlock, pb.method, 0, methodInfo, v47, v48, v49, -1f, 0, 0, 0, v53, v54, v55, v56);\nL_00F5:\n\tUnityEngine.Renderer::SetPropertyBlock(v83, this._propBlock);\n\tv334 = UnityEngine.Component::get_gameObject(v83);\n\tUIIconGenerator::SetLayerRecursive(this, v334, this.renderLayer);\n\tUnityEngine.Camera::set_orthographicSize(this.renderCamera, orthoScale);\n\tUnityEngine.Camera::set_targetTexture(this.renderCamera, targetRT);\n\tUnityEngine.Camera::Render(this.renderCamera);\n\tv339 = UnityEngine.Component::get_gameObject(v83);\n\tgoto L_0127;\n\tv343 = \"il2cpp_codegen_runtime_class_init\"(v341, v338, v157, v98, methodInfo, v47, v48, v49, v118, v128, v123, v104, v53, v54, v55, v56);\nL_0127:\n\tUnityEngine.Object::DestroyImmediate(v339);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 195 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void RenderFluidIcon(global::UnityEngine.RenderTexture targetRT, global::UnityEngine.Material mat, float orthoScale = 0.3f, global::System.Action<global::UnityEngine.MaterialPropertyBlock> pb = null)
	{
		global::UnityEngine.Transform transform = base.transform;
		global::UnityEngine.MeshRenderer component = global::UnityEngine.Object.Instantiate(quadPrefab, transform);
		global::UnityEngine.Transform transform2 = component.transform;
		global::UnityEngine.Vector3 localPosition = default(global::UnityEngine.Vector3);
		localPosition.x = 0f;
		localPosition.y = 0f;
		localPosition.z = 0f;
		transform2.localPosition = localPosition;
		global::UnityEngine.Transform transform3 = component.transform;
		global::UnityEngine.Vector3 localScale = default(global::UnityEngine.Vector3);
		localScale.x = orthoScale * 2f;
		localScale.y = orthoScale * 2f;
		localScale.z = 1f;
		transform3.localScale = localScale;
		((global::UnityEngine.Renderer)component).material = mat;
		((global::UnityEngine.Renderer)component).GetPropertyBlock(_propBlock);
		global::UnityEngine.Transform transform4 = global::Singleton<GameManager>.Instance.light.transform;
		global::UnityEngine.Vector3 forward = transform4.forward;
		global::UnityEngine.Vector4 value = default(global::UnityEngine.Vector4);
		value.x = forward.x;
		value.y = forward.y;
		value.z = forward.z;
		value.w = 0f;
		global::UnityEngine.MaterialPropertyBlock propBlock = _propBlock;
		propBlock.SetVector("_LightDirection", value);
		global::UnityEngine.MaterialPropertyBlock propBlock2 = _propBlock;
		propBlock2.SetTexture("_FluidTexArray", fluidTexArray);
		global::UnityEngine.Texture2D value2 = SolidColor(global::UnityEngine.Color.white);
		global::UnityEngine.MaterialPropertyBlock propBlock3 = _propBlock;
		propBlock3.SetTexture("_ReflectionTex", value2);
		global::UnityEngine.MaterialPropertyBlock propBlock4 = _propBlock;
		propBlock4.SetTexture("_ReflectionTexOverride", reflectionTex);
		global::UnityEngine.MaterialPropertyBlock propBlock5 = _propBlock;
		propBlock5.SetInt("_Layer", 0);
		global::UnityEngine.MaterialPropertyBlock propBlock6 = _propBlock;
		propBlock6.SetFloat("_HighlightAlpha", -1f);
		if (pb != null)
		{
			pb(_propBlock);
		}
		((global::UnityEngine.Renderer)component).SetPropertyBlock(_propBlock);
		global::UnityEngine.GameObject obj9 = component.gameObject;
		SetLayerRecursive(obj9, renderLayer);
		renderCamera.orthographicSize = orthoScale;
		renderCamera.targetTexture = targetRT;
		renderCamera.Render();
		global::UnityEngine.GameObject obj10 = component.gameObject;
		global::UnityEngine.Object.DestroyImmediate(obj10);
	}

	[global::Cpp2ILInjected.Token(Token = "0x600040A")]
	[global::Cpp2ILInjected.Address(RVA = "0x101AD1C", Offset = "0x101AD1C", Length = "0x344")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0034;\n\tv47 = Il2CppMethodInfo;\n\tv48 = v47 + 0xB18;\n\tv49 = \"il2cpp_codegen_initialize_runtime_metadata\"(v48, targetRT, prefab, pb, methodInfo, v51, v52, v53, orthoScale, v54, v55, v56, v57, v58, v59, v60);\n\tv70 = Il2CppMethodInfo;\n\tv71 = v70 + 0xB70;\n\tv72 = \"il2cpp_codegen_initialize_runtime_metadata\"(v71, targetRT, prefab, pb, methodInfo, v51, v52, v53, orthoScale, v54, v55, v56, v57, v58, v59, v60);\n\tv78 = Il2CppMethodInfo;\n\tv79 = v78 + 0xA8;\n\tv80 = \"il2cpp_codegen_initialize_runtime_metadata\"(v79, targetRT, prefab, pb, methodInfo, v51, v52, v53, orthoScale, v54, v55, v56, v57, v58, v59, v60);\n\tv87 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv88 = v87 + 0xFD8;\n\tv89 = \"il2cpp_codegen_initialize_runtime_metadata\"(v88, targetRT, prefab, pb, methodInfo, v51, v52, v53, orthoScale, v54, v55, v56, v57, v58, v59, v60);\n\tv91 = Il2CppMethodInfo;\n\tv92 = v91 + 0xC90;\n\tv93 = \"il2cpp_codegen_initialize_runtime_metadata\"(v92, targetRT, prefab, pb, methodInfo, v51, v52, v53, orthoScale, v54, v55, v56, v57, v58, v59, v60);\n\tv250 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv251 = v250 + 0xA48;\n\tv252 = \"il2cpp_codegen_initialize_runtime_metadata\"(v251, targetRT, prefab, pb, methodInfo, v51, v52, v53, orthoScale, v54, v55, v56, v57, v58, v59, v60);\n\tv256 = \"Writing object reference to Id '{0}' for {1}.\";\n\tv257 = v256 + 0xA98;\n\tv62 = \"il2cpp_codegen_initialize_runtime_metadata\"(v257, targetRT, prefab, pb, methodInfo, v51, v52, v53, orthoScale, v54, v55, v56, v57, v58, v59, v60);\n\tv64 = 1;\n\t*([302AAAC]) = v64;\nL_0034:\n\tv65 = Il2CppMethodInfo;\n\tv69 = UnityEngine.Component::get_transform(this);\n\tgoto L_0043;\n\tv81 = \"il2cpp_codegen_runtime_class_init\"(v74, v68, prefab, pb, methodInfo, v51, v52, v53, orthoScale, v54, v55, v56, v57, v58, v59, v60);\nL_0043:\n\tv86 = UnityEngine.Object::Instantiate /* +1 sharing this address */(prefab, v69, *([v65 @ X20_v2 (Il2CppMethodInfo)+A8]));\n\tv96 = UnityEngine.GameObject::get_transform(v86);\n\tgoto L_0056;\n\tv258 = System.Xml.ValidateNames;\n\tv259 = v258 + 0xD0;\n\tv260 = \"il2cpp_codegen_initialize_runtime_metadata\"(v259, v95, v83, pb, methodInfo, v51, v52, v53, orthoScale, v54, v55, v56, v57, v58, v59, v60);\n\tv261 = 1;\n\t*([2DD4419]) = v261;\nL_0056:\n\tv317 = System.Xml.ValidateNames;\n\tv318 = *([v317 @ X20_v6 (Il2CppClass<System.Xml.ValidateNames>)+D0]);\n\tv319 = *([v318 @ X8_v7+B8]);\n\t// 95 MakeStruct v157 @ AGG101AE54_1_v2 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), [v319 @ X8_v8], [v319 @ X8_v8+4], [v319 @ X8_v8+8]\n\tUnityEngine.Transform::set_localPosition(v96, v157);\n\tv323 = UnityEngine.GameObject::get_transform(v86);\n\tgoto L_0072;\n\tv327 = System.Xml.ValidateNames;\n\tv328 = v327 + 0xD0;\n\tv329 = \"il2cpp_codegen_initialize_runtime_metadata\"(v328, v188, v83, pb, methodInfo, v51, v52, v53, v164, v176, v170, v56, v57, v58, v59, v60);\n\tv330 = 1;\n\t*([2DD441A]) = v330;\nL_0072:\n\tv331 = Il2CppMethodInfo;\n\tv332 = Il2CppMethodInfo;\n\tv333 = *([v317 @ X20_v6 (Il2CppClass<System.Xml.ValidateNames>)+D0]);\n\tv226 = *([v333 @ X8_v11+B8]);\n\tv159 = *([v226 @ X8_v12+C]) * orthoScale;\n\tv172 = *([v226 @ X8_v12+10]) * orthoScale;\n\tv166 = *([v226 @ X8_v12+14]) * orthoScale;\n\t// 128 MakeStruct v154 @ AGG101AEC4_1_v2 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), v159 @ V0_v4 (System.Single), v172 @ V1_v4 (System.Single), v166 @ V2_v4 (System.Single)\n\tUnityEngine.Transform::set_localScale(v323, v154);\n\tv341 = UnityEngine.GameObject::GetComponentInChildren /* +1 sharing this address */(v86, *([v331 @ X22_v4 (Il2CppMethodInfo)+B18]));\n\tUnityEngine.Object::Destroy(v341);\n\tv199 = UnityEngine.GameObject::GetComponentsInChildren /* +1 sharing this address */(v86, *([v332 @ X24_v4 (Il2CppMethodInfo)+B70]));\n\tv355 = *([v199 @ X0_v20+18]) < 1;\n\tif (v355) goto L_00E6;\n\tv358 = Il2CppMethodInfo;\n\tv234 = v199 + 0x20;\n\tv359 = \"Writing object reference to Id '{0}' for {1}.\";\n\tgoto L_00BB;\nL_00A7:\n\tUnityEngine.Renderer::SetPropertyBlock(*([v234 @ X20_v12+v111 @ X27_v5 (System.Int32)*8]), this._propBlock);\n\tv111 = v111 + 1;\n\tv363 = v111 >= *([v199 @ X0_v20+18]);\n\tif (v363) goto L_00E6;\nL_00BB:\n\tUnityEngine.Renderer::GetPropertyBlock(*([v234 @ X20_v12+v111 @ X27_v5 (System.Int32)*8]), this._propBlock);\n\tgoto L_00C4;\n\tv390 = \"il2cpp_codegen_runtime_class_init\"(v386, v183, v191, pb, methodInfo, v51, v52, v53, v160, v173, v167, v105, v57, v58, v59, v60);\nL_00C4:\n\tv201 = Singleton`1::get_Instance /* +1 sharing this address */(*([v358 @ X26_v5 (Il2CppMethodInfo)+C90]));\n\tv203 = UnityEngine.Component::get_transform(*([v201 @ X0_v35+158]));\n\tv161 = UnityEngine.Transform::get_forward(v203);\n\t// 216 MakeStruct v360 @ AGG101AFAC_2_v4 (UnityEngine.Vector4), typeof(UnityEngine.Vector4), v161 @ V0_v8 (UnityEngine.Vector3), v161.y (System.Single), v161.z (System.Single), 0\n\tUnityEngine.MaterialPropertyBlock::SetVector(this._propBlock, *([v359 @ X22_v8 (System.String)+A98]), v360);\n\tv379 = pb == 0;\n\tif (v379) goto L_00A7;\n\tpb.invoke_impl(v405, pb.method_code, this._propBlock, pb.method, pb, methodInfo, v51, v52, v53, v161, v161.y, v161.z, 0, v57, v58, v59, v60);\n\tgoto L_00A7;\nL_00E6:\n\tUIIconGenerator::SetLayerRecursive(this, v86, this.renderLayer);\n\tUnityEngine.Camera::set_orthographicSize(this.renderCamera, orthoScale);\n\tUnityEngine.Camera::set_targetTexture(this.renderCamera, targetRT);\n\tUnityEngine.Camera::Render(this.renderCamera);\n\tgoto L_0111;\n\tv396 = \"il2cpp_codegen_runtime_class_init\"(v394, v393, v193, pb, methodInfo, v51, v52, v53, v163, v175, v169, v106, v57, v58, v59, v60);\nL_0111:\n\tUnityEngine.Object::DestroyImmediate(v86);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 185 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void RenderObjectIcon(global::UnityEngine.RenderTexture targetRT, global::UnityEngine.GameObject prefab, float orthoScale = 0.3f, global::System.Action<global::UnityEngine.MaterialPropertyBlock> pb = null)
	{
		global::UnityEngine.Transform transform = base.transform;
		global::UnityEngine.GameObject gameObject = global::UnityEngine.Object.Instantiate(prefab, transform);
		global::UnityEngine.Transform transform2 = gameObject.transform;
		global::UnityEngine.Vector3 localPosition = default(global::UnityEngine.Vector3);
		localPosition.x = 0f;
		localPosition.y = 0f;
		localPosition.z = 0f;
		transform2.localPosition = localPosition;
		global::UnityEngine.Transform transform3 = gameObject.transform;
		global::UnityEngine.Vector3 prefabScale = prefab.transform.localScale;
		global::UnityEngine.Vector3 localScale = default(global::UnityEngine.Vector3);
		localScale.x = prefabScale.x * orthoScale;
		localScale.y = prefabScale.y * orthoScale;
		localScale.z = prefabScale.z * orthoScale;
		transform3.localScale = localScale;
		global::UnityEngine.Light componentInChildren = gameObject.GetComponentInChildren<global::UnityEngine.Light>();
		global::UnityEngine.Object.Destroy(componentInChildren);
		global::UnityEngine.Renderer[] componentsInChildren = gameObject.GetComponentsInChildren<global::UnityEngine.Renderer>();
		if (componentsInChildren.Length >= 1)
		{
			global::UnityEngine.Vector4 value = default(global::UnityEngine.Vector4);
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				global::UnityEngine.Renderer renderer = componentsInChildren[i];
				renderer.GetPropertyBlock(_propBlock);
				global::UnityEngine.Transform transform4 = global::Singleton<GameManager>.Instance.light.transform;
				global::UnityEngine.Vector3 forward = transform4.forward;
				value.x = forward.x;
				value.y = forward.y;
				value.z = forward.z;
				value.w = 0f;
				global::UnityEngine.MaterialPropertyBlock propBlock = _propBlock;
				propBlock.SetVector("_LightDirection", value);
				if (pb != null)
				{
					pb(_propBlock);
				}
				renderer.SetPropertyBlock(_propBlock);
			}
		}
		SetLayerRecursive(gameObject, renderLayer);
		renderCamera.orthographicSize = orthoScale;
		renderCamera.targetTexture = targetRT;
		renderCamera.Render();
		global::UnityEngine.Object.DestroyImmediate(gameObject);
	}

	[global::Cpp2ILInjected.Token(Token = "0x600040B")]
	[global::Cpp2ILInjected.Address(RVA = "0x101B448", Offset = "0x101B448", Length = "0x54")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tUnityEngine.Camera::set_orthographicSize(this.renderCamera, orthoScale);\n\tUnityEngine.Camera::set_targetTexture(this.renderCamera, targetRT);\n\tUnityEngine.Camera::Render(this.renderCamera);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 26 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void RenderIcon(global::UnityEngine.RenderTexture targetRT, float orthoScale)
	{
		renderCamera.orthographicSize = orthoScale;
		renderCamera.targetTexture = targetRT;
		renderCamera.Render();
	}

	[global::Cpp2ILInjected.Token(Token = "0x600040C")]
	[global::Cpp2ILInjected.Address(RVA = "0x101B49C", Offset = "0x101B49C", Length = "0x378")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv16 = UIIconGenerator::ConvertRenderTextureToTexture2D(this, rt);\n\tv20 = v16 == 0;\n\tif (v20) goto L_002D;\n\tv25 = UnityEngine.Texture::get_width(v16);\n\tv43 = UnityEngine.Texture::get_height(v16);\n\t// 41 MakeStruct v61 @ AGG101B514_1_v1 (UnityEngine.Rect), typeof(UnityEngine.Rect), 0, 0, v25 @ X0_v12 (System.Int32), v43 @ X0_v14 (System.Int32)\n\t// 42 MakeStruct v62 @ AGG101B514_2_v1 (UnityEngine.Vector2), typeof(UnityEngine.Vector2), 0.5f, 0.5f\n\treturnVal1 = UnityEngine.Sprite::Create(v16, v61, v62, pixelsPerUnit, 0, 0);\n\treturn returnVal1;\nL_002D:\n\tthrow System.NullReferenceException;\n\tgoto L_0059;\nL_0059:\n\tv201 = pixelsPerUnit >= 0;\n\tif (v201) goto L_FFFFFFFF;\n\tgoto L_0061;\nL_0061:\n\tv208 = 0x274AA58(&v207 @ stack_-68_v1 (System.Single), rt, methodInfo, v26, v27, v28, v29, v30, v204, v190, v80, 1f, v34, v35, v36, v37);\n\tv218 = v204 >= 0;\n\tif (v218) goto L_0088;\n\tv229 = v204 != -0.5d;\n\tif (v229) goto L_009C;\n\tgoto L_008E;\nL_0088:\n\tv240 = v204 != 0.5d;\n\tif (v240) goto L_00A0;\nL_008E:\n\tv267 = v265 + v264;\n\tv268 = v266 & 1;\n\tv270 = v268 == 0;\n\tv273 = ~v270;\n\tif (v273) goto L_FFFFFFFF;\n\tgoto L_FFFFFFFF;\n\tgoto L_00A4;\nL_009C:\n\tv246 = v204 + -0.5f;\n\tv247 = UnityEngine.Mathf::Ceil(v246);\n\tgoto L_00A4;\nL_00A0:\n\tv253 = v204 + 0.5f;\n\tv254 = UnityEngine.Mathf::Floor(v253);\nL_00A4:\n\tv292 = v31 * 0x437F0000;\n\tv296 = v31 - 1f;\n\tv297 = v296 < 0;\n\tv298 = v296 == 0;\n\tv299 = v31 ^ 1f;\n\tv300 = v31 ^ v296;\n\tv301 = v299 & v300;\n\tv302 = v301 < 0;\n\tv303 = v297 == v302;\n\tv304 = ~v298;\n\tv305 = v303 & v304;\n\tv306 = ~v305;\n\tif (v306) goto L_FFFFFFFF;\n\tgoto L_00C2;\nL_00C2:\n\tv322 = v31 >= 0;\n\tif (v322) goto L_FFFFFFFF;\n\tgoto L_00CA;\nL_00CA:\n\tv329 = 0x274AA58(&v328 @ stack_-68_v2 (System.Single), rt, methodInfo, v26, v27, v28, v29, v30, v325, 0, 1f, 1f, v34, v35, v36, v37);\n\tv339 = v325 >= 0;\n\tif (v339) goto L_00F1;\n\tv350 = v325 != -0.5d;\n\tif (v350) goto L_0105;\n\tgoto L_00F7;\nL_00F1:\n\tv361 = v325 != 0.5d;\n\tif (v361) goto L_0109;\nL_00F7:\n\tv388 = v386 + v385;\n\tv389 = v387 & 1;\n\tv391 = v389 == 0;\n\tv394 = ~v391;\n\tif (v394) goto L_FFFFFFFF;\n\tgoto L_FFFFFFFF;\n\tgoto L_010D;\nL_0105:\n\tv367 = v325 + -0.5f;\n\tv368 = UnityEngine.Mathf::Ceil(v367);\n\tgoto L_010D;\nL_0109:\n\tv374 = v325 + 0.5f;\n\tv375 = UnityEngine.Mathf::Floor(v374);\nL_010D:\n\tv413 = v32 * 0x437F0000;\n\tv417 = v32 - 1f;\n\tv418 = v417 < 0;\n\tv419 = v417 == 0;\n\tv420 = v32 ^ 1f;\n\tv421 = v32 ^ v417;\n\tv422 = v420 & v421;\n\tv423 = v422 < 0;\n\tv424 = v418 == v423;\n\tv425 = ~v419;\n\tv426 = v424 & v425;\n\tv427 = ~v426;\n\tif (v427) goto L_FFFFFFFF;\n\tgoto L_012B;\nL_012B:\n\tv443 = v32 >= 0;\n\tif (v443) goto L_FFFFFFFF;\n\tgoto L_0133;\nL_0133:\n\tv450 = 0x274AA58(&v449 @ stack_-68_v3 (System.Single), rt, methodInfo, v26, v27, v28, v29, v30, v446, 0, 1f, 1f, v34, v35, v36, v37);\n\tv460 = v446 >= 0;\n\tif (v460) goto L_015A;\n\tv471 = v446 != -0.5d;\n\tif (v471) goto L_016E;\n\tgoto L_0160;\nL_015A:\n\tv482 = v446 != 0.5d;\n\tif (v482) goto L_0172;\nL_0160:\n\tv509 = v507 + v506;\n\tv510 = v508 & 1;\n\tv512 = v510 == 0;\n\tv515 = ~v512;\n\tif (v515) goto L_FFFFFFFF;\n\tgoto L_FFFFFFFF;\n\tgoto L_0176;\nL_016E:\n\tv488 = v446 + -0.5f;\n\tv489 = UnityEngine.Mathf::Ceil(v488);\n\tgoto L_0176;\nL_0172:\n\tv495 = v446 + 0.5f;\n\tv496 = UnityEngine.Mathf::Floor(v495);\nL_0176:\n\tv534 = v33 * 0x437F0000;\n\tv537 = v33 - 1f;\n\tv538 = v537 < 0;\n\tv539 = v537 == 0;\n\tv540 = v33 ^ 1f;\n\tv541 = v33 ^ v537;\n\tv542 = v540 & v541;\n\tv543 = v542 < 0;\n\tv544 = v538 == v543;\n\tv111 = ~v539;\n\tv545 = v544 & v111;\n\tv546 = ~v545;\n\tif (v546) goto L_FFFFFFFF;\n\tgoto L_0194;\nL_0194:\n\tv562 = v33 >= 0;\n\tif (v562) goto L_FFFFFFFF;\n\tgoto L_019C;\nL_019C:\n\tv568 = 0x274AA58(&v97 @ stack_-68_v4 (System.Single), rt, methodInfo, v26, v27, v28, v29, v30, v565, 0, 1f, 1f, v34, v35, v36, v37);\n\tv578 = v565 >= 0;\n\tif (v578) goto L_01C3;\n\tv589 = v565 != -0.5d;\n\tif (v589) goto L_01D7;\n\tgoto L_01C9;\nL_01C3:\n\tv600 = v565 != 0.5d;\n\tif (v600) goto L_01DB;\nL_01C9:\n\tv627 = v625 + v624;\n\tv628 = v626 & 1;\n\tv630 = v628 == 0;\n\tv633 = ~v630;\n\tif (v633) goto L_FFFFFFFF;\n\tgoto L_FFFFFFFF;\n\tgoto L_01E7;\nL_01D7:\n\tv606 = v565 + -0.5f;\n\tv607 = UnityEngine.Mathf::Ceil(v606);\n\tgoto L_01E7;\nL_01DB:\n\tv613 = v565 + 0.5f;\n\tv614 = UnityEngine.Mathf::Floor(v613);\nL_01E7:\n\tv655 = v274 >= 0;\n\tif (v655) goto L_01F7;\n\tgoto L_01F7;\nL_01F7:\n\tv670 = v405 >= 0;\n\tif (v670) goto L_0207;\n\tgoto L_0207;\nL_0207:\n\tv683 = v526 >= 0;\n\tif (v683) goto L_FFFFFFFF;\n\tgoto L_020D;\nL_020D:\n\tv687 = v686 & 0xFF;\n\tv108 = v169 >= 0;\n\tif (v108) goto L_FFFFFFFF;\n\tgoto L_021E;\nL_021E:\n\tv103 = v687 << 0x10;\n\treturnVal2 = v103 | v100;\n\t// 544 NotImplemented \"Instruction BFI not yet implemented.\"\n\t// 545 NotImplemented \"Instruction BFXIL not yet implemented.\"\n\treturn returnVal2;\n// 391 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private global::UnityEngine.Sprite ConvertRenderTextureToSprite(global::UnityEngine.RenderTexture rt, float pixelsPerUnit = 100f)
	{
		global::UnityEngine.Texture2D texture2D = ConvertRenderTextureToTexture2D(rt);
		if ((object)texture2D != null)
		{
			int width = texture2D.width;
			int height = texture2D.height;
			global::UnityEngine.Rect rect = default(global::UnityEngine.Rect);
			rect.m_XMin = 0f;
			rect.m_YMin = 0f;
			rect.m_Width = width;
			rect.m_Height = height;
			global::UnityEngine.Vector2 pivot = default(global::UnityEngine.Vector2);
			pivot.x = 0.5f;
			pivot.y = 0.5f;
			return global::UnityEngine.Sprite.Create(texture2D, rect, pivot, pixelsPerUnit, 0u, default(global::UnityEngine.SpriteMeshType));
		}
		throw new global::System.NullReferenceException();
	}

	[global::Cpp2ILInjected.Token(Token = "0x600040D")]
	[global::Cpp2ILInjected.Address(RVA = "0x101BCA8", Offset = "0x101BCA8", Length = "0x128")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0017;\n\tv25 = System.Net.Configuration.SettingsSectionInternal;\n\tv26 = v25 + 0x900;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, rt, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41);\n\tv45 = 1;\n\t*([302AAAD]) = v45;\nL_0017:\n\tv47 = UnityEngine.RenderTexture::get_active();\n\tUnityEngine.RenderTexture::set_active(rt);\n\tv52 = System.Net.Configuration.SettingsSectionInternal;\n\tv58 = UnityEngine.RenderTexture::get_width(rt);\n\tv64 = UnityEngine.RenderTexture::get_height(rt);\n\tv67 = new *([v52 @ X21_v2 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+900])();\n\tUnityEngine.Texture2D::.ctor(v67, v58, v64, 4, 0);\n\tv98 = UnityEngine.RenderTexture::get_width(rt);\n\tv87 = UnityEngine.RenderTexture::get_height(rt);\n\t// 74 MakeStruct v105 @ AGG101BD98_1_v1 (UnityEngine.Rect), typeof(UnityEngine.Rect), 0, 0, v98 @ X0_v14 (System.Int32), v87 @ X0_v16 (System.Int32)\n\tUnityEngine.Texture2D::ReadPixels(v67, v105, 0, 0);\n\tUnityEngine.Texture2D::Apply(v67);\n\tUnityEngine.RenderTexture::set_active(v47);\n\treturn v67;\n\treturnVal1 = new System.NullReferenceException();\n\treturn returnVal1;\n// 73 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private global::UnityEngine.Texture2D ConvertRenderTextureToTexture2D(global::UnityEngine.RenderTexture rt)
	{
		//IL_0013: Expected I, but got O
		global::UnityEngine.RenderTexture active = global::UnityEngine.RenderTexture.active;
		global::UnityEngine.RenderTexture.active = rt;
		nint num = 0;
		int width = rt.width;
		int height = rt.height;
		global::UnityEngine.Texture2D texture2D = new global::UnityEngine.Texture2D(width, height, global::UnityEngine.TextureFormat.RGBA32, mipChain: false);
		int width2 = rt.width;
		int height2 = rt.height;
		global::UnityEngine.Rect source = default(global::UnityEngine.Rect);
		source.m_XMin = 0f;
		source.m_YMin = 0f;
		source.m_Width = width2;
		source.m_Height = height2;
		texture2D.ReadPixels(source, 0, 0);
		texture2D.Apply();
		global::UnityEngine.RenderTexture.active = active;
		return texture2D;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600040E")]
	[global::Cpp2ILInjected.Address(RVA = "0x101B9A8", Offset = "0x101B9A8", Length = "0x300")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_001E;\n\tv29 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv30 = v29 + 0x9F0;\n\tv31 = \"il2cpp_codegen_initialize_runtime_metadata\"(v30, obj, layer, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\tv51 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv52 = v51 + 0xA90;\n\tv53 = \"il2cpp_codegen_initialize_runtime_metadata\"(v52, obj, layer, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\tv130 = System.Net.Configuration.SettingsSectionInternal;\n\tv131 = v130 + 0xAA8;\n\tv46 = \"il2cpp_codegen_initialize_runtime_metadata\"(v131, obj, layer, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\tv48 = 1;\n\t*([302AAAE]) = v48;\nL_001E:\n\tv49 = 0;\n\tUnityEngine.GameObject::set_layer(obj, layer);\n\tv119 = UnityEngine.GameObject::get_transform(obj);\n\tv191 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv192 = System.Net.Configuration.SettingsSectionInternal;\n\tv193 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv397 = UnityEngine.UIElements.EnumFieldHelpers + 0x9F0;\n\tv195 = UnityEngine.Transform::GetEnumerator(v119);\nL_0039:\n\tv253 = v106 == 0;\n\tif (v253) goto L_0103;\n\tv260 = *([v106 @ stack_-48_v6]);\n\tv312 = *([v260 @ X8_v16+12E]);\n\tv262 = *([v260 @ X8_v16+12E]) == 0;\n\tif (v262) goto L_005C;\n\tv311 = *([v260 @ X8_v16+B0]) + 8;\nL_0047:\n\tv317 = *([v311 @ X10_v24-8]) == *([v191 @ X23_v6 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]);\n\tif (v317) goto L_005F;\n\tv311 = v311 + 0x10;\n\tv295 = v312 - 1;\n\tv275 = v312 != 1;\n\tif (v275) goto L_0047;\nL_005C:\n\tv451 = 0xF7087C(v106, *([v191 @ X23_v6 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]), 0, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\tgoto L_0065;\nL_005F:\n\tv448 = *([v311 @ X10_v24]) << 4;\n\tv449 = v260 + v448;\n\tv451 = v449 + 0x138;\nL_0065:\n\t*([v451 @ X0_v32])(v454, v106, *([v451 @ X0_v32+8]), v388, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\tv455 = v454 & 1;\n\tv456 = v455 == 0;\n\tif (v456) goto L_00C0;\n\tv365 = v106 == 0;\n\tif (v365) goto L_0105;\n\tv528 = *([v106 @ stack_-48_v6]);\n\tv579 = *([v528 @ X8_v20+12E]);\n\tv530 = *([v528 @ X8_v20+12E]) == 0;\n\tif (v530) goto L_008D;\n\tv578 = *([v528 @ X8_v20+B0]) + 8;\nL_0078:\n\tv584 = *([v578 @ X10_v19-8]) == *([v191 @ X23_v6 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]);\n\tif (v584) goto L_0090;\n\tv578 = v578 + 0x10;\n\tv564 = v579 - 1;\n\tv544 = v579 != 1;\n\tif (v544) goto L_0078;\nL_008D:\n\tv595 = 0xF7087C(v106, *([v191 @ X23_v6 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]), 1, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\tgoto L_0097;\nL_0090:\n\tv591 = *([v578 @ X10_v19]) + 1;\n\tv592 = v591 << 4;\n\tv593 = v528 + v592;\n\tv595 = v593 + 0x138;\nL_0097:\n\t*([v595 @ X0_v38])(v598, v106, *([v595 @ X0_v38+8]), v171, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\tv173 = *([v192 @ X24_v6 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+AA8]);\n\tv599 = *([v598 @ X0_v40 (UnityEngine.Component)]);\n\tv600 = *([v599 @ X8_v23 (Il2CppClass<UnityEngine.Component>)+130]) < *([v173 @ X1_v3 (UnityEngine.GameObject)+130]);\n\tv601 = ~v600;\n\tv609 = ~v601;\n\tif (v609) goto L_0101;\n\tv217 = *([v173 @ X1_v3 (UnityEngine.GameObject)+130]) << 3;\n\tv611 = *([v599 @ X8_v23 (Il2CppClass<UnityEngine.Component>)+C8]) + v217;\n\tv219 = *([v611 @ X8_v26-8]) != v173;\n\tif (v219) goto L_0101;\n\tv614 = UnityEngine.Component::get_gameObject(v598);\n\tUIIconGenerator::SetLayerRecursive(this, v614, layer);\n\tgoto L_0039;\nL_00C0:\n\tv396 = &v106 @ stack_-48_v6;\n\tv400 = &v49 @ stack_-50_v1;\n\tv173 = *([v193 @ X22_v7 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+9F0]);\n\tv391 = 0xF3F36C(*([v396 @ X8_v19]), *([v193 @ X22_v7 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+9F0]), v388, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\t*([v400 @ X21_v11]) = v391;\n\tv394 = v391 == 0;\n\tif (v394) goto L_00F4;\nL_00CA:\n\tv405 = *([v391 @ X0_v18]);\n\tv517 = *([v405 @ X8_v8+12E]);\n\tv407 = *([v405 @ X8_v8+12E]) == 0;\n\tif (v407) goto L_00EA;\n\tv516 = *([v405 @ X8_v8+B0]) + 8;\nL_00D5:\n\tv522 = *([v516 @ X10_v9-8]) == *([v397 @ X22_v6 (System.Int32)]);\n\tif (v522) goto L_00ED;\n\tv516 = v516 + 0x10;\n\tv501 = v517 - 1;\n\tv481 = v517 != 1;\n\tif (v481) goto L_00D5;\nL_00EA:\n\tv536 = 0xF7087C(v391, *([v397 @ X22_v6 (System.Int32)]), 0, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\tgoto L_00F1;\nL_00ED:\n\tv533 = *([v516 @ X10_v9]) << 4;\n\tv534 = v405 + v533;\n\tv536 = v534 + 0x138;\nL_00F1:\n\tv173 = *([v536 @ X0_v19+8]);\n\t*([v536 @ X0_v19])(v472, v391, *([v536 @ X0_v19+8]), v171, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\nL_00F4:\n\tv475 = v188 == 0;\n\tv178 = ~v475;\n\tif (v178) goto L_010B;\n\treturn;\nL_0101:\n\tv363 = new System.InvalidCastException();\n\tgoto L_0108;\nL_0103:\n\tv263 = new System.NullReferenceException();\n\tgoto L_0108;\nL_0105:\n\tv364 = new System.NullReferenceException();\n\tgoto L_0108;\n\tv362 = new System.NullReferenceException();\nL_0108:\n\t// 264 Interrupt\n\tthrow System.NullReferenceException;\nL_010B:\n\tv190 = new System.OutOfMemoryException();\n\tgoto L_011D;\n\tgoto L_011D;\n\tgoto L_011D;\n\tgoto L_011D;\n\tgoto L_011D;\n\tgoto L_011D;\n\tgoto L_011D;\nL_011D:\n\tv206 = v173 != 1;\n\tif (v206) goto L_0130;\n\tv211 = 0x274A080(v190, v173, v171, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\tv401 = *([v211 @ X0_v14]);\n\tv256 = 0x274A098(v211, v173, v171, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\tv173 = *([v182 @ X22_v2 (System.Int32)]);\n\tv391 = 0xF3F36C(*([v161 @ stack_-60_v3]), *([v182 @ X22_v2 (System.Int32)]), v171, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\t*([v159 @ stack_-58_v3]) = v391;\n\tv299 = v391 == 0;\n\tv300 = ~v299;\n\tif (v300) goto L_00CA;\n\tgoto L_00F4;\n\tX19 = X0;\nL_0130:\n\tv213 = 0xBF079C(&v102 @ stack_-68_v2 (System.Int32), v173, v171, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\tv258 = 0x27498DC(v190, v173, v171, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\tv269 = 0xD6F8(v258, v173, v171, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\treturn;\n// 171 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void SetLayerRecursive(global::UnityEngine.GameObject obj, int layer)
	{
		//IL_0613: Expected O, but got I4
		//IL_0032: Expected I, but got O
		//IL_0040: Expected I, but got O
		//IL_004e: Expected I, but got O
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected I4, but got Unknown
		//IL_0096: Expected O, but got I
		//IL_00d1: Expected O, but got I
		//IL_037f: Expected O, but got I
		//IL_0142: Expected I4, but got O
		//IL_0150: Expected O, but got I
		//IL_015f: Expected O, but got I
		//IL_041a: Expected O, but got I
		//IL_00e5: Expected O, but got I
		//IL_00f4: Expected O, but got I
		//IL_01a1: Expected O, but got I
		//IL_073c: Expected O, but got I
		//IL_0455: Expected O, but got I
		//IL_057a: Expected I4, but got O
		//IL_01dc: Expected O, but got I
		//IL_0592: Expected O, but got I4
		//IL_05d6: Expected I4, but got O
		//IL_04c6: Expected I4, but got O
		//IL_04d4: Expected O, but got I
		//IL_04e3: Expected O, but got I
		//IL_0296: Expected O, but got I
		//IL_029e: Expected I, but got O
		//IL_0469: Expected O, but got I
		//IL_0478: Expected O, but got I
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected O, but got Unknown
		//IL_026a: Expected O, but got I
		//IL_0279: Expected O, but got I
		//IL_05f4: Expected I4, but got O
		//IL_0604: Expected I4, but got O
		//IL_030b: Expected O, but got I
		//IL_01f0: Expected O, but got I
		//IL_01ff: Expected O, but got I
		object obj2 = 0;
		obj.layer = layer;
		global::UnityEngine.Transform transform = obj.transform;
		nint num = 0;
		nint num2 = 0;
		nint num3 = 0;
		int num4 = typeof(global::UnityEngine.UIElements.EnumFieldHelpers) + 2544;
		global::System.Collections.IEnumerator enumerator = transform.GetEnumerator();
		int num5 = 0;
		object obj3 = default(object);
		object obj10 = default(object);
		object obj12 = default(object);
		global::UnityEngine.Component component = default(global::UnityEngine.Component);
		object obj24 = default(object);
		object obj11;
		object obj15;
		int num12;
		while (true)
		{
			int num8;
			if (obj3 != null)
			{
				object obj4 = obj3;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X8_v16+12E]");
				object obj5 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X8_v16+12E]");
				if ((nint)0 == 0)
				{
					goto IL_011c;
				}
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X8_v16+B0]");
				object obj6 = (nint)0 + (nint)8;
				while (true)
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X10_v24-8]");
					nint num6 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X23_v6 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]");
					if (num6 == 0)
					{
						break;
					}
					obj6 = (nint)obj6 + 16;
					object obj7 = (nint)obj5 - 1;
					bool flag = (nint)obj5 != 1;
					obj5 = obj7;
					if (flag)
					{
						continue;
					}
					goto IL_011c;
				}
				int num7 = obj6 << 4;
				object obj8 = (nint)obj4 + num7;
				num8 = num5;
				goto IL_064a;
			}
			global::System.NullReferenceException ex = new global::System.NullReferenceException();
			break;
			IL_06d8:
			int num9;
			int num10;
			int num11;
			object obj13;
			object obj14;
			global::UnityEngine.GameObject gameObject;
			int num13;
			while (true)
			{
				bool flag2 = num9 == 0;
				bool flag3 = !flag2;
				num4 = num10;
				if (!flag3)
				{
					return;
				}
				global::System.OutOfMemoryException ex2 = new global::System.OutOfMemoryException();
				if ((nint)gameObject == 1)
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A080 (inside System.__Il2CppComDelegate::Finalize +0xF54)");
					num11 = (int)obj10;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A098 (inside System.__Il2CppComDelegate::Finalize +0xF6C)");
					gameObject = (global::UnityEngine.GameObject)num10;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F36C");
					obj11 = obj12;
					bool flag4 = obj12 == null;
					bool flag5 = !flag4;
					obj13 = obj11;
					obj14 = obj15;
					num12 = (int)obj10;
					num8 = num13;
					if (flag5)
					{
						break;
					}
					num12 = (int)obj10;
					num10 = num10;
					num9 = (int)obj10;
					continue;
				}
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BF079C");
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27498DC (inside System.__Il2CppComDelegate::Finalize +0x7B0)");
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D6F8");
				return;
			}
			goto IL_0402;
			IL_0402:
			object obj16 = obj12;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X8_v8+12E]");
			object obj17 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X8_v8+12E]");
			if ((nint)0 == 0)
			{
				goto IL_04a0;
			}
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X8_v8+B0]");
			object obj18 = (nint)0 + (nint)8;
			while (true)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X10_v9-8]");
				if ((nint)0 == num4)
				{
					break;
				}
				obj18 = (nint)obj18 + 16;
				object obj19 = (nint)obj17 - 1;
				bool flag6 = (nint)obj17 != 1;
				obj17 = obj19;
				if (flag6)
				{
					continue;
				}
				goto IL_04a0;
			}
			int num14 = obj18 << 4;
			object obj20 = (nint)obj16 + num14;
			num13 = num8;
			goto IL_072c;
			IL_0227:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
			num13 = 1;
			goto IL_06ac;
			IL_06ac:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v595 @ X0_v38] (should have been resolved before IL gen)");
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X24_v6 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+AA8]");
			gameObject = (global::UnityEngine.GameObject)0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v599 @ X8_v23 (Il2CppClass<UnityEngine.Component>)+130]");
			nint num16 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X1_v3 (UnityEngine.GameObject)+130]");
			if (num16 >= 0)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X1_v3 (UnityEngine.GameObject)+130]");
				int num17 = (int)((nint)0 << 3);
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v599 @ X8_v23 (Il2CppClass<UnityEngine.Component>)+C8]");
				object obj22 = (nint)0 + (nint)num17;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v611 @ X8_v26-8]");
				if (0 == (nint)gameObject)
				{
					global::UnityEngine.GameObject obj23 = component.gameObject;
					SetLayerRecursive(obj23, layer);
					num5 = layer;
					continue;
				}
			}
			global::System.InvalidCastException ex3 = new global::System.InvalidCastException();
			break;
			IL_011c:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
			num8 = 0;
			goto IL_064a;
			IL_064a:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v451 @ X0_v32] (should have been resolved before IL gen)");
			if ((int)((nint)obj24 & 1) != 0)
			{
				if (obj3 != null)
				{
					object obj25 = obj3;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v528 @ X8_v20+12E]");
					object obj26 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v528 @ X8_v20+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0227;
					}
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v528 @ X8_v20+B0]");
					object obj27 = (nint)0 + (nint)8;
					while (true)
					{
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v578 @ X10_v19-8]");
						nint num18 = 0;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X23_v6 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]");
						if (num18 == 0)
						{
							break;
						}
						obj27 = (nint)obj27 + 16;
						object obj28 = (nint)obj26 - 1;
						bool flag7 = (nint)obj26 != 1;
						obj26 = obj28;
						if (flag7)
						{
							continue;
						}
						goto IL_0227;
					}
					object obj29 = obj27 + 1;
					int num19 = (int)((nint)obj29 << 4);
					object obj30 = (nint)obj25 + num19;
					num13 = num8;
					goto IL_06ac;
				}
				global::System.NullReferenceException ex4 = new global::System.NullReferenceException();
				break;
			}
			object obj32 = obj3;
			object obj33 = obj2;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X22_v7 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+9F0]");
			gameObject = (global::UnityEngine.GameObject)0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F36C");
			obj33 = obj12;
			bool flag8 = obj12 == null;
			obj13 = obj2;
			obj14 = obj3;
			num12 = 0;
			num11 = 0;
			obj11 = obj2;
			obj15 = obj3;
			num12 = 0;
			num13 = num8;
			num10 = num4;
			num9 = 0;
			if (!flag8)
			{
				goto IL_0402;
			}
			goto IL_06d8;
			IL_072c:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X0_v19+8]");
			gameObject = (global::UnityEngine.GameObject)0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v536 @ X0_v19] (should have been resolved before IL gen)");
			obj11 = obj13;
			obj15 = obj14;
			num10 = num4;
			num9 = num11;
			goto IL_06d8;
			IL_04a0:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
			num13 = 0;
			goto IL_072c;
		}
		obj11 = obj2;
		obj15 = obj3;
		num12 = 0;
		throw new global::System.NullReferenceException();
	}

	[global::Cpp2ILInjected.Token(Token = "0x600040F")]
	[global::Cpp2ILInjected.Address(RVA = "0x101A7D4", Offset = "0x101A7D4", Length = "0x138")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0018;\n\tv25 = System.Net.Configuration.SettingsSectionInternal;\n\tv26 = v25 + 0x908;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, src, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41);\n\tv45 = 1;\n\t*([302AAAF]) = v45;\nL_0018:\n\tv47 = System.Net.Configuration.SettingsSectionInternal;\n\tv51 = UnityEngine.Texture::get_mipmapCount(src);\n\tv118 = UnityEngine.Texture::get_width(src);\n\tv122 = UnityEngine.Texture::get_height(src);\n\tv124 = new *([v47 @ X21_v3 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+908])();\n\tv170 = v51 - 1;\n\tv171 = v170 < 0;\n\tv172 = v170 == 0;\n\tv173 = v51 ^ 1;\n\tv174 = v51 ^ v170;\n\tv175 = v173 & v174;\n\tv176 = v175 < 0;\n\tv177 = v171 == v176;\n\tv65 = ~v172;\n\tv178 = v177 & v65;\n\tUnityEngine.Texture2DArray::.ctor(v124, v118, v122, 1, 4, v178, 0);\n\tv136 = v51 < 1;\n\tif (v136) goto L_006C;\n\tv161 = v124 == 0;\n\tif (v161) goto L_007C;\nL_0053:\n\tv259 = UnityEngine.Texture2D::GetPixels32(src, v253);\n\tUnityEngine.Texture2DArray::SetPixels32(v124, v259, 0, v253);\n\tv253 = v253 + 1;\n\tv185 = v51 != v253;\n\tif (v185) goto L_0053;\nL_006C:\n\tUnityEngine.Texture2DArray::Apply(v124, 0, 1);\n\treturn v124;\n\tthrow System.NullReferenceException;\nL_007C:\n\tv167 = UnityEngine.Texture2D::GetPixels32(src, 0);\n\treturnVal1 = new System.NullReferenceException();\n\treturn returnVal1;\n// 90 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private global::UnityEngine.Texture2DArray CreateArrayFromTexture(global::UnityEngine.Texture2D src)
	{
		//IL_0013: Expected I, but got O
		nint num = 0;
		int mipmapCount = src.mipmapCount;
		int width = src.width;
		int height = src.height;
		bool mipChain = default(bool);
		global::UnityEngine.Texture2DArray texture2DArray = new global::UnityEngine.Texture2DArray(width, height, 1, global::UnityEngine.TextureFormat.RGBA32, mipChain, linear: false);
		int num2 = mipmapCount - 1;
		bool flag = num2 < 0;
		bool flag2 = num2 == 0;
		int num3 = mipmapCount ^ 1;
		int num4 = mipmapCount ^ num2;
		int num5 = num3 & num4;
		bool flag3 = num5 < 0;
		bool flag4 = flag == flag3;
		bool flag5 = !flag2;
		mipChain = flag4 && flag5;
		if (mipmapCount >= 1)
		{
			if ((object)texture2DArray == null)
			{
				global::UnityEngine.Color32[] pixels = src.GetPixels32(0);
				return (global::UnityEngine.Texture2DArray)(object)new global::System.NullReferenceException();
			}
			int num6 = 0;
			do
			{
				global::UnityEngine.Color32[] pixels2 = src.GetPixels32(num6);
				texture2DArray.SetPixels32(pixels2, 0, num6);
				num6++;
			}
			while (mipmapCount != num6);
		}
		texture2DArray.Apply(updateMipmaps: false, makeNoLongerReadable: true);
		return texture2DArray;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000410")]
	[global::Cpp2ILInjected.Address(RVA = "0x101B814", Offset = "0x101B814", Length = "0x194")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv30 = System.Net.Configuration.SettingsSectionInternal;\n\tgoto L_0026;\n\tv35 = CollectParticleData[];\n\tv36 = v35 + 0x18;\n\tv37 = \"il2cpp_codegen_initialize_runtime_metadata\"(v36, color, size, mipChain, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49);\n\tv57 = System.ComponentModel.BooleanConverter;\n\tv58 = v57 + 0x460;\n\tv59 = \"il2cpp_codegen_initialize_runtime_metadata\"(v58, color, size, mipChain, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49);\n\tv66 = System.Net.Configuration.SettingsSectionInternal;\n\tv67 = v66 + 0x900;\n\tv68 = \"il2cpp_codegen_initialize_runtime_metadata\"(v67, color, size, mipChain, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49);\n\tv70 = \"Scrollbar Horizontal\";\n\tv71 = v70 + 0x4A0;\n\tv51 = \"il2cpp_codegen_initialize_runtime_metadata\"(v71, color, size, mipChain, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49);\n\tv54 = 1;\n\t*([302AAB0]) = v54;\nL_0026:\n\tv56 = new *([v30 @ X23_v1 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+900])();\n\tUnityEngine.Texture2D::.ctor(v56, size, size, 4, mipChain);\n\tv72 = System.ComponentModel.BooleanConverter;\n\tv74 = \"Scrollbar Horizontal\";\n\tv76 = CollectParticleData[];\n\tUnityEngine.Texture::set_wrapMode(v56, 0);\n\tUnityEngine.Texture::set_filterMode(v56, 1);\n\tv101 = \"il2cpp_vm_object_box\"(*([v72 @ X23_v4 (Il2CppClass<System.ComponentModel.BooleanConverter>)+460]), &color @ X1 (UnityEngine.Color32), 0, 4, mipChain, 0, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49);\n\tv170 = System.String::Format(*([v74 @ X24_v2 (System.String)+4A0]), v101);\n\tUnityEngine.Object::set_name(v56, v170);\n\tv89 = size * size;\n\tv91 = \"SzArrayNew\"(*([v76 @ X25_v2 (Il2CppClass<CollectParticleData[]>)+18]), v89, 0, 4, mipChain, 0, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49);\n\tv186 = v91.Length < 1;\n\tif (v186) goto L_0070;\n\tv188 = v91 + 0x20;\nL_005F:\n\t*([v188 @ X9_v2+v212 @ X8_v6 (System.Int32)*4]) = color;\n\tv212 = v212 + 1;\n\tv190 = v212 < v91.Length;\n\tif (v190) goto L_005F;\nL_0070:\n\tUnityEngine.Texture2D::SetPixels32(v56, v91);\n\tUnityEngine.Texture2D::Apply(v56, mipChain, 1);\n\tUnityEngine.Object::set_hideFlags(v56, 0x34);\n\treturn v56;\n\treturnVal1 = new System.NullReferenceException();\n\treturn returnVal1;\n// 96 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public global::UnityEngine.Texture2D SolidColor(global::UnityEngine.Color32 color, int size = 1, bool mipChain = false)
	{
		//IL_000e: Expected I, but got O
		//IL_0021: Expected I, but got O
		//IL_0038: Expected I, but got O
		//IL_0081: Expected O, but got I
		//IL_00e1: Expected O, but got I
		nint num = 0;
		global::UnityEngine.Texture2D texture2D = new global::UnityEngine.Texture2D(size, size, global::UnityEngine.TextureFormat.RGBA32, mipChain);
		nint num2 = 0;
		string text = "Scrollbar Horizontal";
		nint num3 = 0;
		texture2D.wrapMode = default(global::UnityEngine.TextureWrapMode);
		texture2D.filterMode = global::UnityEngine.FilterMode.Bilinear;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_box\"");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X24_v2 (System.String)+4A0]");
		object arg = default(object);
		string text2 = string.Format((string)0, arg);
		texture2D.name = text2;
		int num4 = size * size;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"SzArrayNew\"");
		global::UnityEngine.Color32[] array = default(global::UnityEngine.Color32[]);
		if (array.Length >= 1)
		{
			int num5 = 0;
			int num6 = default(int);
			num5 = num6;
			do
			{
				num5++;
			}
			while (num5 < array.Length);
		}
		texture2D.SetPixels32(array);
		texture2D.Apply(mipChain, makeNoLongerReadable: true);
		texture2D.hideFlags = global::UnityEngine.HideFlags.DontSave;
		return texture2D;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000411")]
	[global::Cpp2ILInjected.Address(RVA = "0x101BDD0", Offset = "0x101BDD0", Length = "0xA0")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tgoto L_0019;\n\tv23 = Il2CppMethodInfo;\n\tv24 = v23 + 0xCB0;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv52 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv53 = v52 + 0xA60;\n\tv42 = \"il2cpp_codegen_initialize_runtime_metadata\"(v53, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv44 = 1;\n\t*([302AAB1]) = v44;\nL_0019:\n\tv45 = Il2CppMethodInfo;\n\tthis.renderLayer = 9;\n\tthis.resolution = 0x100;\n\tv49 = *([v18 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A60]);\n\tv51 = *([v49 @ X0_v2+E0]) == 0;\n\tif (v51) goto L_0038;\n\tSingleton`1::.ctor /* +1 sharing this address */(this, *([v45 @ X21_v2 (Il2CppMethodInfo)+CB0]));\n\treturn;\nL_0038:\n\tSingleton`1::.ctor /* +1 sharing this address */(this, *([v45 @ X21_v2 (Il2CppMethodInfo)+CB0]));\n\treturn;\n// 38 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public UIIconGenerator()
	{
		//IL_000e: Expected I, but got O
		//IL_005a: Expected O, but got I
		nint num = 0;
		nint num2 = 0;
		renderLayer = 9;
		resolution = 256;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A60]");
		object obj = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+E0]");
		if ((nint)0 != 0)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18ABE40 (Singleton`1::.ctor, and 1 more at this address)");
		}
		else
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18ABE40 (Singleton`1::.ctor, and 1 more at this address)");
		}
	}
}
