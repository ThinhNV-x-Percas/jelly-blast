[global::Cpp2ILInjected.Token(Token = "0x2000059")]
public class FluidCompute : global::UnityEngine.MonoBehaviour
{
	[global::Cpp2ILInjected.Token(Token = "0x400015B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public int layerCount;

	[global::Cpp2ILInjected.Token(Token = "0x400015C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public int maxParticles;

	[global::Cpp2ILInjected.Token(Token = "0x400015D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public int activeCount;

	[global::Cpp2ILInjected.Token(Token = "0x400015E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	protected global::UnityEngine.Rendering.CommandBuffer cmd;

	[global::Cpp2ILInjected.Token(Token = "0x400015F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public global::UnityEngine.Vector2[] positions;

	[global::Cpp2ILInjected.Token(Token = "0x4000160")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public float[] particleTypes;

	[global::Cpp2ILInjected.Token(Token = "0x4000161")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public float[] isRounded;

	[global::Cpp2ILInjected.Token(Token = "0x4000162")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public global::UnityEngine.Vector4[] emissionColors;

	[global::Cpp2ILInjected.Token(Token = "0x4000163")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public float[] scales;

	[global::Cpp2ILInjected.Token(Token = "0x4000164")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public float[] innerRadii;

	[global::UnityEngine.HideInInspector]
	[global::Cpp2ILInjected.Token(Token = "0x4000165")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public int[] particleIds;

	[global::Cpp2ILInjected.Token(Token = "0x4000166")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public global::System.Collections.Generic.Dictionary<int, int> idToIndex;

	[global::Cpp2ILInjected.Token(Token = "0x4000167")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	private int nextId;

	[global::UnityEngine.Header("Particle Rendering")]
	[global::Cpp2ILInjected.Token(Token = "0x4000168")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public global::UnityEngine.Mesh quadMesh;

	[global::Cpp2ILInjected.Token(Token = "0x4000169")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	protected global::UnityEngine.Matrix4x4[] particleMatrices;

	[global::Cpp2ILInjected.Token(Token = "0x400016A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public global::UnityEngine.Material particlesMaterial;

	[global::Cpp2ILInjected.Token(Token = "0x400016B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public global::UnityEngine.Material emissionMaterial;

	[global::Cpp2ILInjected.Token(Token = "0x400016C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public global::UnityEngine.RenderTexture emissionRT;

	[global::Cpp2ILInjected.Token(Token = "0x400016D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public global::UnityEngine.RenderTexture rawFieldRT;

	[global::Cpp2ILInjected.Token(Token = "0x400016E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	protected global::UnityEngine.MaterialPropertyBlock props;

	[global::UnityEngine.Header("Compute Shader Pass")]
	[global::Cpp2ILInjected.Token(Token = "0x400016F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public global::UnityEngine.ComputeShader fluidCS;

	[global::Cpp2ILInjected.Token(Token = "0x4000170")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public global::UnityEngine.RenderTexture fluidRT;

	[global::Cpp2ILInjected.Token(Token = "0x4000171")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public float rawFieldDownscale;

	[global::Cpp2ILInjected.Token(Token = "0x4000172")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xCC")]
	public float fieldDownscale;

	[global::Cpp2ILInjected.Token(Token = "0x4000173")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	protected int W;

	[global::Cpp2ILInjected.Token(Token = "0x4000174")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD4")]
	protected int H;

	[global::Cpp2ILInjected.Token(Token = "0x4000175")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	protected int rawW;

	[global::Cpp2ILInjected.Token(Token = "0x4000176")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xDC")]
	protected int rawH;

	[global::Cpp2ILInjected.Token(Token = "0x4000177")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	private int kMerge;

	[global::Cpp2ILInjected.Token(Token = "0x4000178")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE4")]
	private int tx;

	[global::Cpp2ILInjected.Token(Token = "0x4000179")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	private int ty;

	[global::Cpp2ILInjected.Token(Token = "0x400017A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	private global::UnityEngine.Vector4[] colorsVec;

	[global::Cpp2ILInjected.Token(Token = "0x400017B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
	public global::System.Action OnPreUpdate;

	[global::Cpp2ILInjected.Token(Token = "0x60001D4")]
	[global::Cpp2ILInjected.Address(RVA = "0xFEF384", Offset = "0xFEF384", Length = "0x138")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv20 = 0x302A000;\n\tv22 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv24 = *([302A9B5]) & 1;\n\tv25 = v24 == 0;\n\tif (v25) goto L_0028;\n\tv55 = Il2CppMethodInfo + 0xC90;\n\tv28 = *([v22 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A48]);\n\tv30 = *([v28 @ X0_v31+E0]) == 0;\n\tif (v30) goto L_0032;\nL_0019:\n\tv74 = Singleton`1::get_Instance /* +1 sharing this address */(*([v55 @ X21_v9]));\n\tv67 = v74 == 0;\n\tv68 = ~v67;\n\tif (v68) goto L_0036;\n\tgoto L_0074;\nL_0028:\n\t*([v20 @ X21_v1+9B5]) = 1;\n\tv55 = Il2CppMethodInfo + 0xC90;\n\tv50 = *([v22 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A48]);\n\tv88 = *([v50 @ X0_v27+E0]) == 0;\n\tv52 = ~v88;\n\tif (v52) goto L_0019;\nL_0032:\n\tv74 = Singleton`1::get_Instance /* +1 sharing this address */(*([v62 @ X21_v6]));\nL_0036:\n\tv80 = CollectParticleData[];\n\tv82 = v74 + 0x90;\n\tv85 = new *([v80 @ X23_v2 (Il2CppClass<CollectParticleData[]>)+990])();\n\tv98 = this->klass;\n\tSystem.Action::.ctor(v85, this, *([v98 @ X8_v4 (Il2CppClass<FluidCompute>)+180]));\n\tv161 = System.Delegate::Combine(*([v82 @ X20_v5]), v85);\n\tv148 = v161 == 0;\n\tif (v148) goto L_0066;\n\tv173 = *([v161 @ X0_v7 (System.Delegate)]) != *([v80 @ X23_v2 (Il2CppClass<CollectParticleData[]>)+990]);\n\tif (v173) goto L_0065;\n\t*([v82 @ X20_v5]) = v161;\n\tv201 = *([v161 @ X0_v7 (System.Delegate)]) == *([v80 @ X23_v2 (Il2CppClass<CollectParticleData[]>)+990]);\n\tif (v201) goto L_0072;\nL_0065:\n\tthrow System.InvalidCastException;\nL_0066:\n\t*([v82 @ X20_v5]) = 0;\nL_0072:\n\tv146 = 0xF3F1B4(v82, v161, 0, 0, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48);\n\treturn;\nL_0074:\n\tthrow System.NullReferenceException;\n// 79 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void Awake()
	{
		global::Singleton<GameManager>.Instance.OnInit += OnInit;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001D5")]
	[global::Cpp2ILInjected.Address(RVA = "0xFEF4BC", Offset = "0xFEF4BC", Length = "0x9AC")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv30 = Facebook.Unity.Windows.IWindowsFacebook;\n\tgoto L_0041;\n\tv35 = System.ComponentModel.BooleanConverter;\n\tv36 = v35 + 0x4D0;\n\tv37 = \"il2cpp_codegen_initialize_runtime_metadata\"(v36, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\tv59 = CollectParticleData[];\n\tv60 = v59 + 0x2D0;\n\tv61 = \"il2cpp_codegen_initialize_runtime_metadata\"(v60, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\tv79 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv80 = v79 + 0x900;\n\tv81 = \"il2cpp_codegen_initialize_runtime_metadata\"(v80, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\tv84 = CollectParticleData[];\n\tv85 = v84 + 0x368;\n\tv86 = \"il2cpp_codegen_initialize_runtime_metadata\"(v85, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\tv90 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv91 = v90 + 0xFD8;\n\tv92 = \"il2cpp_codegen_initialize_runtime_metadata\"(v91, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\tv107 = System.Runtime.Serialization.ObjectHolderList;\n\tv108 = v107 + 0xB00;\n\tv109 = \"il2cpp_codegen_initialize_runtime_metadata\"(v108, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\tv112 = CollectParticleData[];\n\tv113 = v112 + 0x4B8;\n\tv114 = \"il2cpp_codegen_initialize_runtime_metadata\"(v113, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\tv118 = Il2CppMethodInfo;\n\tv119 = v118 + 0xC90;\n\tv120 = \"il2cpp_codegen_initialize_runtime_metadata\"(v119, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\tv135 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv136 = v135 + 0xA48;\n\tv137 = \"il2cpp_codegen_initialize_runtime_metadata\"(v136, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\tv140 = CollectParticleData[];\n\tv141 = v140 + 0x648;\n\tv142 = \"il2cpp_codegen_initialize_runtime_metadata\"(v141, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\tv146 = CollectParticleData[];\n\tv147 = v146 + 0x658;\n\tv148 = \"il2cpp_codegen_initialize_runtime_metadata\"(v147, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\tv163 = \"IsCyrillic\";\n\tv164 = v163 + 0xE80;\n\tv165 = \"il2cpp_codegen_initialize_runtime_metadata\"(v164, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\tv168 = \"Parent table name is missing in relation '{0}'.\";\n\tv169 = v168 + 0xAE0;\n\tv54 = \"il2cpp_codegen_initialize_runtime_metadata\"(v169, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\tv56 = 1;\n\t*([302A9B6]) = v56;\nL_0041:\n\tv58 = UnityEngine.Screen::get_width();\n\tv64 = this.rawFieldDownscale * v58;\n\tv78 = v64 != 0x7F800000;\n\tif (v78) goto L_FFFFFFFF;\n\tgoto L_0058;\nL_0058:\n\tthis.rawW = v87;\n\tv89 = UnityEngine.Screen::get_height();\n\tv95 = this.rawFieldDownscale * v89;\n\tv106 = v95 != 0x7F800000;\n\tif (v106) goto L_FFFFFFFF;\n\tgoto L_006E;\nL_006E:\n\tthis.rawH = v115;\n\tv117 = UnityEngine.Screen::get_width();\n\tv123 = this.fieldDownscale * v117;\n\tv134 = v123 != 0x7F800000;\n\tif (v134) goto L_FFFFFFFF;\n\tgoto L_0084;\nL_0084:\n\tthis.W = v143;\n\tv145 = UnityEngine.Screen::get_height();\n\tv151 = this.fieldDownscale * v145;\n\tv162 = v151 != 0x7F800000;\n\tif (v162) goto L_FFFFFFFF;\n\tgoto L_009B;\nL_009B:\n\tv172 = this + 0xA8;\n\tthis.H = v170;\n\tv174 = *([v30 @ X24_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv176 = *([v174 @ X0_v10+E0]) == 0;\n\tif (v176) goto L_00AE;\n\tv180 = UnityEngine.Object::op_Equality(this.rawFieldRT, 0);\n\tv183 = v180 == 0;\n\tif (v183) goto L_00B9;\n\tgoto L_00FC;\nL_00AE:\n\tv187 = UnityEngine.Object::op_Equality(this.rawFieldRT, 0);\n\tv196 = v187 == 0;\n\tv192 = ~v196;\n\tif (v192) goto L_00FC;\nL_00B9:\n\tv254 = UnityEngine.RenderTexture::get_width(this.rawFieldRT);\n\tv200 = v254 != this.rawW;\n\tif (v200) goto L_00FC;\n\tv255 = UnityEngine.RenderTexture::get_height(this.rawFieldRT);\n\tv201 = v255 != this.rawH;\n\tif (v201) goto L_00FC;\n\tv256 = UnityEngine.RenderTexture::get_volumeDepth(this.rawFieldRT);\n\tv198 = v256 != this.layerCount;\n\tif (v198) goto L_00FC;\n\tv253 = UnityEngine.RenderTexture::get_dimension(this.rawFieldRT);\n\tv229 = v253 == 5;\n\tif (v229) goto L_015C;\nL_00FC:\n\tv267 = *([v30 @ X24_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv269 = *([v267 @ X0_v172+E0]) == 0;\n\tif (v269) goto L_0110;\n\tv635 = UnityEngine.Object::op_Equality(this.rawFieldRT, 0);\n\tv637 = ~v635;\n\tv638 = ~v637;\n\tif (v638) goto L_0115;\nL_0107:\n\tv705 = this.rawFieldRT;\n\tv696 = this.rawFieldRT == 0;\n\tv559 = ~v696;\n\tif (v559) goto L_0128;\n\tgoto L_0388;\nL_0110:\n\tv642 = UnityEngine.Object::op_Equality(this.rawFieldRT, 0);\n\tv695 = ~v642;\n\tif (v695) goto L_0107;\nL_0115:\n\tv701 = System.Runtime.Serialization.ObjectHolderList;\n\tv703 = new *([v701 @ X8_v70 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+B00])();\n\tUnityEngine.RenderTexture::.ctor(v703, this.rawW, this.rawH, 0, 0);\n\tthis.rawFieldRT = v703;\n\tv709 = 0xF3F1B4(v172, v703, this.rawH, 0, 0, 0, v43, v44, v151, this.fieldDownscale, v47, v48, v49, v50, v51, v52);\n\tv705 = this.rawFieldRT;\nL_0128:\n\tUnityEngine.RenderTexture::Release(v705);\n\tv711 = UnityEngine.RenderTexture::set_width(this.rawFieldRT, this.rawW);\n\tv712 = UnityEngine.RenderTexture::set_height(this.rawFieldRT, this.rawH);\n\tv714 = UnityEngine.RenderTexture::set_dimension(this.rawFieldRT, 5);\n\tUnityEngine.RenderTexture::set_volumeDepth(this.rawFieldRT, this.layerCount);\n\tUnityEngine.RenderTexture::set_enableRandomWrite(this.rawFieldRT, 1);\n\tUnityEngine.Texture::set_filterMode(this.rawFieldRT, 2);\n\tv717 = UnityEngine.RenderTexture::Create(this.rawFieldRT);\nL_015C:\n\tv720 = UnityEngine.RenderTexture::Create(this.rawFieldRT);\n\tv626 = this + 0xC0;\n\tv722 = *([v30 @ X24_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv723 = *([v722 @ X0_v16+E0]) == 0;\n\tif (v723) goto L_0170;\n\tv727 = UnityEngine.Object::op_Equality(this.fluidRT, 0);\n\tv730 = v727 == 0;\n\tif (v730) goto L_017B;\n\tgoto L_019B;\nL_0170:\n\tv734 = UnityEngine.Object::op_Equality(this.fluidRT, 0);\n\tv739 = v734 == 0;\n\tv737 = ~v739;\n\tif (v737) goto L_019B;\nL_017B:\n\tv754 = UnityEngine.RenderTexture::get_width(this.fluidRT);\n\tv351 = v754 != this.W;\n\tif (v351) goto L_019B;\n\tv753 = UnityEngine.RenderTexture::get_height(this.fluidRT);\n\tv747 = v753 == this.H;\n\tif (v747) goto L_01ED;\nL_019B:\n\tv758 = *([v30 @ X24_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv759 = *([v758 @ X0_v138+E0]) == 0;\n\tif (v759) goto L_01AF;\n\tv765 = UnityEngine.Object::op_Equality(this.fluidRT, 0);\n\tv767 = ~v765;\n\tv768 = ~v767;\n\tif (v768) goto L_01B4;\nL_01A6:\n\tv791 = this.fluidRT;\n\tv778 = this.fluidRT == 0;\n\tv571 = ~v778;\n\tif (v571) goto L_01C7;\n\tgoto L_0388;\nL_01AF:\n\tv772 = UnityEngine.Object::op_Equality(this.fluidRT, 0);\n\tv777 = ~v772;\n\tif (v777) goto L_01A6;\nL_01B4:\n\tv783 = System.Runtime.Serialization.ObjectHolderList;\n\tv785 = new *([v783 @ X8_v58 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+B00])();\n\tUnityEngine.RenderTexture::.ctor(v785, this.W, this.H, 0, 0);\n\tthis.fluidRT = v785;\n\tv797 = 0xF3F1B4(v626, v785, this.H, 0, 0, 0, v43, v44, v151, this.fieldDownscale, v47, v48, v49, v50, v51, v52);\n\tv791 = this.fluidRT;\nL_01C7:\n\tUnityEngine.RenderTexture::Release(v791);\n\tv801 = UnityEngine.RenderTexture::set_width(this.fluidRT, this.W);\n\tv807 = UnityEngine.RenderTexture::set_height(this.fluidRT, this.H);\n\tUnityEngine.RenderTexture::set_enableRandomWrite(this.fluidRT, 1);\n\tUnityEngine.Texture::set_filterMode(this.fluidRT, 2);\n\tv788 = UnityEngine.RenderTexture::Create(this.fluidRT);\nL_01ED:\n\tv795 = UnityEngine.RenderTexture::Create(this.fluidRT);\n\tv627 = this + 0xA0;\n\tv799 = *([v30 @ X24_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv800 = *([v799 @ X0_v20+E0]) == 0;\n\tif (v800) goto L_0201;\n\tv805 = UnityEngine.Object::op_Equality(this.emissionRT, 0);\n\tv809 = v805 == 0;\n\tif (v809) goto L_020C;\n\tgoto L_022C;\nL_0201:\n\tv813 = UnityEngine.Object::op_Equality(this.emissionR\n// ... truncated")]
	public virtual void OnInit()
	{
		rawW = (int)(rawFieldDownscale * global::UnityEngine.Screen.width);
		rawH = (int)(rawFieldDownscale * global::UnityEngine.Screen.height);
		W = (int)(fieldDownscale * global::UnityEngine.Screen.width);
		H = (int)(fieldDownscale * global::UnityEngine.Screen.height);
		if (rawFieldRT == null || rawFieldRT.width != rawW || rawFieldRT.height != rawH || rawFieldRT.volumeDepth != layerCount || rawFieldRT.dimension != global::UnityEngine.Rendering.TextureDimension.Tex2DArray)
		{
			if (rawFieldRT == null)
			{
				rawFieldRT = new global::UnityEngine.RenderTexture(rawW, rawH, 0, default(global::UnityEngine.RenderTextureFormat));
			}
			rawFieldRT.Release();
			rawFieldRT.width = rawW;
			rawFieldRT.height = rawH;
			rawFieldRT.dimension = global::UnityEngine.Rendering.TextureDimension.Tex2DArray;
			rawFieldRT.volumeDepth = layerCount;
			rawFieldRT.enableRandomWrite = true;
			rawFieldRT.filterMode = global::UnityEngine.FilterMode.Trilinear;
			rawFieldRT.Create();
		}
		if (fluidRT == null || fluidRT.width != W || fluidRT.height != H)
		{
			if (fluidRT == null)
			{
				fluidRT = new global::UnityEngine.RenderTexture(W, H, 0, default(global::UnityEngine.RenderTextureFormat));
			}
			fluidRT.Release();
			fluidRT.width = W;
			fluidRT.height = H;
			fluidRT.enableRandomWrite = true;
			fluidRT.filterMode = global::UnityEngine.FilterMode.Trilinear;
			fluidRT.Create();
		}
		if (emissionRT == null || emissionRT.width != rawW || emissionRT.height != rawH)
		{
			if (emissionRT == null)
			{
				emissionRT = new global::UnityEngine.RenderTexture(rawW, rawH, 0, default(global::UnityEngine.RenderTextureFormat));
			}
			emissionRT.Release();
			emissionRT.width = rawW;
			emissionRT.height = rawH;
			emissionRT.enableRandomWrite = true;
			emissionRT.filterMode = global::UnityEngine.FilterMode.Trilinear;
			emissionRT.Create();
		}
		cmd = new global::UnityEngine.Rendering.CommandBuffer();
		cmd.name = "FluidCompute";
		kMerge = fluidCS.FindKernel("Merge");
		tx = (int)global::UnityEngine.Mathf.Ceil((float)W * 0.125f);
		ty = (int)global::UnityEngine.Mathf.Ceil((float)H * 0.125f);
		global::UnityEngine.Camera.main.AddCommandBuffer(global::UnityEngine.Rendering.CameraEvent.BeforeImageEffectsOpaque, cmd);
		particleIds = new int[maxParticles];
		positions = new global::UnityEngine.Vector2[maxParticles];
		particleTypes = new float[maxParticles];
		isRounded = new float[maxParticles];
		emissionColors = new global::UnityEngine.Vector4[maxParticles];
		scales = new float[maxParticles];
		innerRadii = new float[maxParticles];
		colorsVec = new global::UnityEngine.Vector4[global::Singleton<GameManager>.Instance.solver.colorFluidTypes];
		particleMatrices = new global::UnityEngine.Matrix4x4[maxParticles];
		props = new global::UnityEngine.MaterialPropertyBlock();
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001D6")]
	[global::Cpp2ILInjected.Address(RVA = "0xFEFE68", Offset = "0xFEFE68", Length = "0x700")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv36 = &v37 @ stack_-10_v2;\n\tgoto L_0047;\n\tv45 = Il2CppMethodInfo;\n\tv46 = v45 + 0xC90;\n\tv47 = \"il2cpp_codegen_initialize_runtime_metadata\"(v46, methodInfo, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62);\n\tv70 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv71 = v70 + 0xA48;\n\tv72 = \"il2cpp_codegen_initialize_runtime_metadata\"(v71, methodInfo, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62);\n\tv83 = \"Writing object reference to Id '{0}' for {1}.\";\n\tv84 = v83 + 0x9C8;\n\tv85 = \"il2cpp_codegen_initialize_runtime_metadata\"(v84, methodInfo, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62);\n\tv714 = \"Writing object reference to Id '{0}' for {1}.\";\n\tv715 = v714 + 0xA58;\n\tv716 = \"il2cpp_codegen_initialize_runtime_metadata\"(v715, methodInfo, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62);\n\tv841 = \"Writing object reference to Id '{0}' for {1}.\";\n\tv842 = v841 + 0x8A0;\n\tv843 = \"il2cpp_codegen_initialize_runtime_metadata\"(v842, methodInfo, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62);\n\tv867 = \"Writing object reference to Id '{0}' for {1}.\";\n\tv868 = v867 + 0x9D0;\n\tv869 = \"il2cpp_codegen_initialize_runtime_metadata\"(v868, methodInfo, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62);\n\tv992 = \"Writing object reference to Id '{0}' for {1}.\";\n\tv993 = v992 + 0xA88;\n\tv994 = \"il2cpp_codegen_initialize_runtime_metadata\"(v993, methodInfo, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62);\n\tv997 = \"Writing object reference to Id '{0}' for {1}.\";\n\tv998 = v997 + 0xC38;\n\tv999 = \"il2cpp_codegen_initialize_runtime_metadata\"(v998, methodInfo, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62);\n\tv1003 = \"Writing object reference to Id '{0}' for {1}.\";\n\tv1004 = v1003 + 0xBF8;\n\tv1005 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1004, methodInfo, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62);\n\tv1017 = \"Writing object reference to Id '{0}' for {1}.\";\n\tv1018 = v1017 + 0xA80;\n\tv1019 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1018, methodInfo, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62);\n\tv1036 = \"Writing object reference to Id '{0}' for {1}.\";\n\tv1037 = v1036 + 0xA68;\n\tv1038 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1037, methodInfo, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62);\n\tv1040 = \"Writing object reference to Id '{0}' for {1}.\";\n\tv1041 = v1040 + 0x950;\n\tv1042 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1041, methodInfo, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62);\n\tv1053 = \"Writing object reference to Id '{0}' for {1}.\";\n\tv1054 = v1053 + 0xB40;\n\tv1055 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1054, methodInfo, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62);\n\tv1056 = \"Writing object reference to Id '{0}' for {1}.\";\n\tv1057 = v1056 + 0xA70;\n\tv64 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1057, methodInfo, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62);\n\tv66 = 1;\n\t*([302A9B7]) = v66;\nL_0047:\n\t*([v36 @ X29_v1-90]) = 0;\n\t*([v36 @ X29_v1-B0]) = 0;\n\t*([v36 @ X29_v1-A0]) = 0;\n\tv68 = this.OnPreUpdate;\n\tv69 = this.OnPreUpdate == 0;\n\tif (v69) goto L_0056;\n\tv68.invoke_impl(v76, v68.method_code, v68.method, v49, v50, v51, v52, v53, v54, 0, v56, v57, v58, v59, v60, v61, v62);\nL_0056:\n\tUnityEngine.Rendering.CommandBuffer::Clear(this.cmd);\n\tv728 = this.activeCount < 1;\n\tif (v728) goto L_0101;\n\tv846 = System.Runtime.Serialization.ObjectHolderList;\n\tv847 = System.Xml.ValidateNames;\nL_007C:\n\tv1000 = this.positions + v496;\n\tv1002 = *([2DD4418]) == 0;\n\tif (v1002) goto L_0092;\n\tv1006 = *([v846 @ X20_v15 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+538]);\n\tv1007 = *([v1006 @ X8_v66+B8]);\n\tv457 = *([v1007 @ X8_v67]);\n\tv451 = *([v1007 @ X8_v67+4]);\n\tv445 = *([v1007 @ X8_v67+8]);\n\tv439 = *([v1007 @ X8_v67+C]);\n\tv1013 = *([2DD441A]) == 0;\n\tif (v1013) goto L_009F;\nL_008B:\n\tv837 = this.scales;\n\tv1028 = this.scales == 0;\n\tv651 = ~v1028;\n\tif (v651) goto L_00AE;\n\tgoto L_02A6;\nL_0092:\n\t*([2DD4418]) = 1;\n\tv1033 = *([v846 @ X20_v15 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+538]);\n\tv1034 = *([v1033 @ X8_v61+B8]);\n\tv457 = *([v1034 @ X8_v62]);\n\tv451 = *([v1034 @ X8_v62+4]);\n\tv445 = *([v1034 @ X8_v62+8]);\n\tv439 = *([v1034 @ X8_v62+C]);\n\tv1035 = *([2DD441A]) == 0;\n\tv1025 = ~v1035;\n\tif (v1025) goto L_008B;\nL_009F:\n\t*([2DD441A]) = 1;\n\tv837 = this.scales;\nL_00AE:\n\tv1043 = *([v847 @ X21_v12 (Il2CppClass<System.Xml.ValidateNames>)+D0]);\n\tv619 = *([v1043 @ X9_v12+B8]);\n\tv1049 = *([v619 @ X9_v13+C]);\n\tv1049 = v1049 * v837[v492 @ X23_v10 (System.Int32)];\n\t// 197 MakeStruct v347 @ AGGFF0098_0_v5 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), [v1000 @ X8_v51+20], [v1000 @ X8_v51+24], 0\n\t// 198 MakeStruct v342 @ AGGFF0098_1_v5 (UnityEngine.Quaternion), typeof(UnityEngine.Quaternion), v457 @ V10_v6, v451 @ V11_v6, v445 @ V12_v6, v439 @ V13_v6\n\tv627 = UnityEngine.Matrix4x4::TRS(v347, v342, v1049);\n\tv333 = v627.m00;\n\tv849 = v496 << 3;\n\tv1059 = this.particleMatrices + v849;\n\t*([v1059 @ X8_v57+40]) = v627.m02;\n\t*([v1059 @ X8_v57+50]) = v627.m03;\n\t*([v1059 @ X8_v57+20]) = v627.m00;\n\t*([v1059 @ X8_v57+30]) = v627.m01;\n\tv492 = v492 + 1;\n\tv496 = v496 + 8;\n\tv855 = v492 < this.activeCount;\n\tif (v855) goto L_007C;\nL_0101:\n\tv872 = \"Writing object reference to Id '{0}' for {1}.\";\n\tUnityEngine.MaterialPropertyBlock::SetVectorArray(this.props, *([v872 @ X8_v8 (System.String)+950]), this.emissionColors);\n\tv686 = &v333 @ stack_-100 (System.Single);\n\tv629 = UnityEngine.Rendering.RenderTargetIdentifier::op_Implicit(this.emissionRT);\n\tv333 = *([v686 @ X8_v10]);\n\tUnityEngine.Rendering.CommandBuffer::SetRenderTarget(this.cmd, &v333 @ stack_-100 (System.Single), 2, 0, 2, 0);\n\t// 304 MakeStruct v167 @ AGGFF0160_3_v3 (UnityEngine.Color), typeof(UnityEngine.Color), 0, 0, 0, 0\n\tUnityEngine.Rendering.CommandBuffer::ClearRenderTarget(this.cmd, 1, 1, v167);\n\tUnityEngine.Rendering.CommandBuffer::DrawMeshInstanced(this.cmd, this.quadMesh, 0, this.emissionMaterial, 0, this.particleMatrices, this.activeCount, this.props);\n\tv1062 = \"Writing object reference to Id '{0}' for {1}.\";\n\tUnityEngine.MaterialPropertyBlock::SetFloatArray(this.props, *([v1062 @ X8_v12 (System.String)+C38]), this.particleTypes);\n\tv1063 = \"Writing object reference to Id '{0}' for {1}.\";\n\tUnityEngine.MaterialPropertyBlock::SetFloatArray(this.props, *([v1063 @ X8_v14 (System.String)+A70]), this.isRounded);\n\tv1064 = \"Writing object reference to Id '{0}' for {1}.\";\n\tUnityEngine.MaterialPropertyBlock::SetFloatArray(this.props, *([v1064 @ X8_v16 (System.String)+A58]), this.innerRadii);\n\tv1080 = this.layerCount < 1;\n\tif (v1080) goto L_01B1;\n\tv1082 = \"Writing object reference to Id '{0}' for {1}.\";\nL_016A:\n\tv1116 = &v37 @ stack_-10_v2 - 0xB0;\n\tUnityEngine.Rendering.RenderTargetIdentifier::.ctor(v1116, this.rawFieldRT, 0, 0xFFFFFFFF, v709);\n\tv1049 = *([v36 @ X29_v1-B0]);\n\tUnityEngine.Rendering.CommandBuffer::SetRenderTarget(this.cmd, &v1049 @ V0_v25 (UnityEngine.Vector3), 2, 0, 2, 0);\n\t// 394 MakeStruct v144 @ AGGFF0278_3_v5 (UnityEngine.Color), typeof(UnityEngine.Color), 0, 0, 0, 0\n\tUnityEngine.Rendering.CommandBuffer::ClearRenderTarget(this.cmd, 1, 1, v144);\n\tUnityEngine.Rendering.CommandBuffer::SetGlobalInt(this.cmd, *([v1082 @ X21_v10 (System.String)+A88]), v709);\n\tUnityEngine.Rendering.CommandBuffer::DrawMeshInstanced(this.cmd, this.quadMesh, 0, this.particlesMaterial, 0, this.particleMatrices, this.activeCount, this.props);\n\tv709 = v709 + 1;\n\tv1091 = v709 < this.layerCount;\n\tif (v1091) goto L_016A;\nL_01B1:\n\tv692 = &v333 @ stack_-100 (System.Single);\n\tv639 = UnityEngine.Rendering.RenderTargetIdentifier::op_Implicit(this.rawFieldRT);\n\tv333 = *([v692 @ X8_v20]);\n\tv1117 = \"Writing object reference to Id '{0}' for {1}.\";\n\tUnityEngine.Rendering.CommandBuffer::SetComputeTextureParam(this.cmd, this.fluidCS, this.kMerge, *([v1117 @ X8_v21 (System.String)+B40]), &v333 @ stack_-100 (System.Single)\n// ... truncated")]
	public unsafe void LateUpdate()
	{
		OnPreUpdate?.Invoke();
		cmd.Clear();
		if (activeCount >= 1)
		{
			for (int i = 0; i < activeCount; i++)
			{
				global::UnityEngine.Vector3 pos = new global::UnityEngine.Vector3(positions[i].x, positions[i].y, 0f);
				global::UnityEngine.Quaternion q = global::UnityEngine.Quaternion.identity;
				float scale = scales[i];
				global::UnityEngine.Vector3 s = new global::UnityEngine.Vector3(scale, scale, scale);
				particleMatrices[i] = global::UnityEngine.Matrix4x4.TRS(pos, q, s);
			}
		}
		props.SetVectorArray("_EmissionColors", emissionColors);
		cmd.SetRenderTarget(emissionRT, global::UnityEngine.Rendering.RenderBufferLoadAction.DontCare, global::UnityEngine.Rendering.RenderBufferStoreAction.Store, global::UnityEngine.Rendering.RenderBufferLoadAction.DontCare, global::UnityEngine.Rendering.RenderBufferStoreAction.DontCare);
		cmd.ClearRenderTarget(clearDepth: true, clearColor: true, global::UnityEngine.Color.clear);
		cmd.DrawMeshInstanced(quadMesh, 0, emissionMaterial, 0, particleMatrices, activeCount, props);
		props.SetFloatArray("_ParticleTypes", particleTypes);
		props.SetFloatArray("_IsRounded", isRounded);
		props.SetFloatArray("_InnerRadii", innerRadii);
		for (int layer = 0; layer < layerCount; layer++)
		{
			global::UnityEngine.Rendering.RenderTargetIdentifier renderTargetIdentifier = new global::UnityEngine.Rendering.RenderTargetIdentifier(rawFieldRT, 0, global::UnityEngine.CubemapFace.Unknown, layer);
			cmd.SetRenderTarget(renderTargetIdentifier, global::UnityEngine.Rendering.RenderBufferLoadAction.DontCare, global::UnityEngine.Rendering.RenderBufferStoreAction.Store, global::UnityEngine.Rendering.RenderBufferLoadAction.DontCare, global::UnityEngine.Rendering.RenderBufferStoreAction.DontCare);
			cmd.ClearRenderTarget(clearDepth: true, clearColor: true, global::UnityEngine.Color.clear);
			cmd.SetGlobalInt("_Layer", layer);
			cmd.DrawMeshInstanced(quadMesh, 0, particlesMaterial, 0, particleMatrices, activeCount, props);
		}
		cmd.SetComputeTextureParam(fluidCS, kMerge, "_RawFieldTex", rawFieldRT);
		cmd.SetComputeTextureParam(fluidCS, kMerge, "_FluidTex", fluidRT);
		cmd.SetComputeVectorParam(fluidCS, "_FieldSize", new global::UnityEngine.Vector4(W, H, 0f, 0f));
		cmd.SetComputeVectorParam(fluidCS, "_RawFieldSize", new global::UnityEngine.Vector4(rawW, rawH, 0f, 0f));
		cmd.SetComputeFloatParam(fluidCS, "_AspectRatio", (float)W / H);
		cmd.SetComputeIntParam(fluidCS, "_Passes", 2);
		for (int j = 0; j < colorsVec.Length; j++)
		{
			colorsVec[j] = global::Singleton<GameManager>.Instance.level.colors[j];
		}
		cmd.SetComputeVectorArrayParam(fluidCS, "_Colors", colorsVec);
		cmd.DispatchCompute(fluidCS, kMerge, tx, ty, 1);
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001D7")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF0568", Offset = "0xFF0568", Length = "0x78")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tUnityEngine.RenderTexture::Release(this.rawFieldRT);\n\tUnityEngine.RenderTexture::Release(this.fluidRT);\n\tUnityEngine.RenderTexture::Release(this.emissionRT);\n\tv59 = this + 0x30;\n\tv49 = this.cmd == 0;\n\tif (v49) goto L_002B;\n\tUnityEngine.Rendering.CommandBuffer::Release(this.cmd);\n\tthis.cmd = 0;\n\tv51 = 0xF3F1B4(v59, 0, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\treturn;\nL_002B:\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 33 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public virtual void OnDestroy()
	{
		//IL_0037: Expected O, but got I
		rawFieldRT.Release();
		fluidRT.Release();
		emissionRT.Release();
		if (cmd != null)
		{
			cmd.Release();
			cmd = null;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001D8")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF05E0", Offset = "0xFF05E0", Length = "0x1F4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0028;\n\tv37 = Il2CppMethodInfo;\n\tv38 = v37 + 0x968;\n\tv39 = \"il2cpp_codegen_initialize_runtime_metadata\"(v38, ids, onInit, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\tv61 = Il2CppMethodInfo;\n\tv62 = v61 + 0x970;\n\tv63 = \"il2cpp_codegen_initialize_runtime_metadata\"(v62, ids, onInit, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\tv77 = Il2CppMethodInfo;\n\tv78 = v77 + 0x978;\n\tv79 = \"il2cpp_codegen_initialize_runtime_metadata\"(v78, ids, onInit, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\tv83 = Il2CppMethodInfo;\n\tv84 = v83 + 0x998;\n\tv85 = \"il2cpp_codegen_initialize_runtime_metadata\"(v84, ids, onInit, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\tv111 = Il2CppMethodInfo;\n\tv112 = v111 + 0x9B0;\n\tv54 = \"il2cpp_codegen_initialize_runtime_metadata\"(v112, ids, onInit, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\tv56 = 1;\n\t*([302A9B8]) = v56;\nL_0028:\n\tv57 = 0;\n\tv60 = v147 == 0;\n\tif (v60) goto L_007A;\n\tv66 = Il2CppMethodInfo;\n\tv68 = Il2CppMethodInfo;\n\tv95 = this.activeCount;\n\tv75 = System.Collections.Generic.HashSet`1<System.Int32>::GetEnumerator(v147);\n\tv82 = onInit == 0;\n\tif (v82) goto L_005D;\nL_003E:\n\t;\n\tv141 = System.Collections.Generic.HashSet`1+Enumerator::MoveNext /* +1 sharing this address */(&v57 @ stack_-78_v1, *([v66 @ X27_v3 (Il2CppMethodInfo)+970]));\n\tv157 = v141 & 1;\n\tv136 = v157 == 0;\n\tif (v136) goto L_0067;\n\tv126 = v95 + v129;\n\tFluidCompute::InitParticle(this, 0, v126);\n\tParticleInitData::.ctor(&v119 @ stack_-98_v5 (ParticleInitData), v126, 0, v129);\n\tonInit.invoke_impl(v134, onInit.method_code, v119, 0, onInit.method, 0, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\tv129 = v129 + 1;\n\tgoto L_003E;\nL_005A:\n\tv95 = v95 + 1;\nL_005D:\n\tv99 = System.Collections.Generic.HashSet`1+Enumerator::MoveNext /* +1 sharing this address */(&v57 @ stack_-78_v1, *([v66 @ X27_v3 (Il2CppMethodInfo)+970]));\n\tv94 = v99 == 0;\n\tif (v94) goto L_0067;\n\tFluidCompute::InitParticle(this, 0, v95);\n\tgoto L_005A;\nL_0067:\n\tSystem.Collections.Generic.HashSet`1+Enumerator::Dispose /* +1 sharing this address */(&v57 @ stack_-78_v1, *([v68 @ X26_v3 (Il2CppMethodInfo)+968]));\nL_006A:\n\tv220 = v147._count + this.activeCount;\n\tthis.activeCount = v220;\n\treturn;\nL_007A:\n\tv76 = new System.NullReferenceException();\n\tgoto L_0089;\n\tgoto L_0089;\n\tgoto L_0089;\n\tgoto L_0089;\nL_0089:\n\tv110 = v147 != 1;\n\tif (v110) goto L_0099;\n\tv143 = 0x274A080(v76, v147, onInit, v115, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\tv174 = 0x274A098(v143, v147, onInit, v115, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\tSystem.Collections.Generic.HashSet`1+Enumerator::Dispose /* +1 sharing this address */(v206, *([v5 @ X26]));\n\tv152 = *([v143 @ X0_v10]) == 0;\n\tif (v152) goto L_006A;\n\tv150 = new System.OutOfMemoryException();\nL_0099:\n\tv156 = 0xBF092C(&v146 @ stack_-88, *([v5 @ X26]), onInit, v115, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\tv176 = 0x27498DC(v153, *([v5 @ X26]), onInit, v115, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\tv233 = 0xD6F8(v176, *([v5 @ X26]), onInit, v115, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\treturn;\n// 93 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void AddParticles(global::System.Collections.Generic.HashSet<int> ids, global::System.Action<ParticleInitData> onInit = null)
	{
		int slot = activeCount;
		int index = 0;
		foreach (int id in ids)
		{
			InitParticle(id, slot);
			if (onInit != null)
			{
				onInit(new ParticleInitData(slot, id, index));
			}
			slot++;
			index++;
		}
		activeCount += ids.Count;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001D9")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF09FC", Offset = "0xFF09FC", Length = "0x84")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tFluidCompute::InitParticle(this, id, this.activeCount);\n\tv22 = onInit == 0;\n\tif (v22) goto L_001E;\n\tParticleInitData::.ctor(&v27 @ stack_-40_v3 (ParticleInitData), this.activeCount, id, 0);\n\tonInit.invoke_impl(v39, onInit.method_code, v27, 0, onInit.method, 0, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67);\nL_001E:\n\tv49 = this.activeCount + 1;\n\tthis.activeCount = v49;\n\treturn;\n// 32 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void AddParticle(int id, global::System.Action<ParticleInitData> onInit = null)
	{
		InitParticle(id, activeCount);
		if (onInit != null)
		{
			onInit(new ParticleInitData(activeCount, id, 0));
		}
		activeCount++;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001DA")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF07D4", Offset = "0xFF07D4", Length = "0x228")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_001E;\n\tv29 = System.ComponentModel.BooleanConverter;\n\tv30 = v29 + 0xB98;\n\tv31 = \"il2cpp_codegen_initialize_runtime_metadata\"(v30, id, slot, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\tv51 = Il2CppMethodInfo;\n\tv52 = v51 + 0x260;\n\tv53 = \"il2cpp_codegen_initialize_runtime_metadata\"(v52, id, slot, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\tv211 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv212 = v211 + 0x1A8;\n\tv46 = \"il2cpp_codegen_initialize_runtime_metadata\"(v212, id, slot, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\tv48 = 1;\n\t*([302A9B9]) = v48;\nL_001E:\n\tv254 = this.particleIds;\n\tv54 = slot & 0x80000000;\n\tv55 = v54 == 0;\n\tv56 = ~v55;\n\tif (v56) goto L_0034;\n\tv225 = v254.Length > slot;\n\tif (v225) goto L_0058;\nL_0034:\n\tv226 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv230 = \"il2cpp_vm_object_box\"(*([v226 @ X8_v36 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+1A8]), &slot @ X2 (System.Int32), slot, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\tgoto L_0044;\n\tv282 = \"il2cpp_codegen_runtime_class_init\"(v274, v229, slot, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\nL_0044:\n\tUnityEngine.Debug::Log(v230);\n\tv254 = this.particleIds;\nL_0058:\n\tv254[slot @ X2 (System.Int32)] = id;\n\tgoto L_0073;\n\tv325 = System.Xml.ValidateNames;\n\tv326 = v325 + 0x98;\n\tv327 = \"il2cpp_codegen_initialize_runtime_metadata\"(v326, v77, slot, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\tv328 = 1;\n\t*([2DD4424]) = v328;\nL_0073:\n\tv331 = System.Xml.ValidateNames;\n\tv333 = *([v331 @ X8_v11 (Il2CppClass<System.Xml.ValidateNames>)+98]);\n\tv334 = *([v333 @ X8_v13+B8]);\n\tv68 = slot << 3;\n\tv335 = this.positions + v68;\n\t*([v335 @ X8_v15+20]) = *([v334 @ X8_v14]);\n\tv200 = this.particleTypes;\n\tv200[slot @ X2 (System.Int32)] = 0;\n\tv201 = this.isRounded;\n\tv201[slot @ X2 (System.Int32)] = 0;\n\tgoto L_00BB;\n\tv345 = System.Xml.ValidateNames;\n\tv346 = v345 + 0x110;\n\tv347 = \"il2cpp_codegen_initialize_runtime_metadata\"(v346, v77, slot, methodInfo, v33, v34, v35, v36, v58, v38, v39, v40, v41, v42, v43, v44);\n\tv348 = 1;\n\t*([2DD4427]) = v348;\nL_00BB:\n\tv351 = System.Xml.ValidateNames;\n\tv353 = *([v351 @ X8_v23 (Il2CppClass<System.Xml.ValidateNames>)+110]);\n\tv354 = *([v353 @ X8_v25+B8]);\n\tv70 = slot << 4;\n\tv355 = this.emissionColors + v70;\n\t*([v355 @ X8_v27+20]) = *([v354 @ X8_v26]);\n\tv202 = this.scales;\n\tv202[slot @ X2 (System.Int32)] = 0x3F800000;\n\tv203 = this.innerRadii;\n\tv203[slot @ X2 (System.Int32)] = 0;\n\tv311 = System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>::TryAdd(this.idToIndex, id, slot);\n\treturn;\n\tv210 = new System.NullReferenceException();\n\tthrow System.IndexOutOfRangeException;\n\treturn;\n// 193 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void InitParticle(int id, int slot)
	{
		if (slot < 0 || particleIds.Length <= slot)
		{
			global::UnityEngine.Debug.Log("InitParticle slot out of range: " + slot);
		}
		particleIds[slot] = id;
		positions[slot] = default(global::UnityEngine.Vector2);
		particleTypes[slot] = 0f;
		isRounded[slot] = 0f;
		emissionColors[slot] = default(global::UnityEngine.Vector4);
		scales[slot] = 1f;
		innerRadii[slot] = 0f;
		idToIndex.TryAdd(id, slot);
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001DB")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF0A80", Offset = "0xFF0A80", Length = "0x388")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0031;\n\tv27 = Il2CppMethodInfo;\n\tv28 = v27 + 0x258;\n\tv29 = \"il2cpp_codegen_initialize_runtime_metadata\"(v28, ids, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv52 = Il2CppMethodInfo;\n\tv53 = v52 + 0x290;\n\tv54 = \"il2cpp_codegen_initialize_runtime_metadata\"(v53, ids, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv269 = Il2CppMethodInfo;\n\tv270 = v269 + 0x968;\n\tv271 = \"il2cpp_codegen_initialize_runtime_metadata\"(v270, ids, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv313 = Il2CppMethodInfo;\n\tv314 = v313 + 0x970;\n\tv315 = \"il2cpp_codegen_initialize_runtime_metadata\"(v314, ids, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv324 = Il2CppMethodInfo;\n\tv325 = v324 + 0x978;\n\tv326 = \"il2cpp_codegen_initialize_runtime_metadata\"(v325, ids, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv340 = Il2CppMethodInfo;\n\tv341 = v340 + 0x990;\n\tv342 = \"il2cpp_codegen_initialize_runtime_metadata\"(v341, ids, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv359 = Il2CppMethodInfo;\n\tv360 = v359 + 0x998;\n\tv361 = \"il2cpp_codegen_initialize_runtime_metadata\"(v360, ids, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv393 = Il2CppMethodInfo;\n\tv394 = v393 + 0x9B0;\n\tv45 = \"il2cpp_codegen_initialize_runtime_metadata\"(v394, ids, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv47 = 1;\n\t*([302A9BA]) = v47;\nL_0031:\n\t;\n\tv57 = Il2CppMethodInfo;\n\tv59 = Il2CppMethodInfo;\n\tv61 = Il2CppMethodInfo;\n\tv304 = Il2CppMethodInfo + 0x968;\n\tv67 = System.Collections.Generic.HashSet`1<System.Int32>::GetEnumerator(ids);\nL_0044:\n\tv349 = *([v57 @ X21_v17 (Il2CppMethodInfo)+970]);\n\tv323 = System.Collections.Generic.HashSet`1+Enumerator::MoveNext /* +1 sharing this address */(&v65 @ stack_-78_v6 (System.Single), *([v57 @ X21_v17 (Il2CppMethodInfo)+970]));\n\tv327 = v323 & 1;\n\tv328 = v327 == 0;\n\tif (v328) goto L_0051;\n\tv309 = this.idToIndex == 0;\n\tif (v309) goto L_0196;\n\tv216 = *([v59 @ X23_v9 (Il2CppMethodInfo)+258]);\n\tv320 = System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>::Remove(this.idToIndex, v275);\n\tgoto L_0044;\nL_0051:\n\t;\n\tSystem.Collections.Generic.HashSet`1+Enumerator::Dispose /* +1 sharing this address */(&v65 @ stack_-78_v6 (System.Single), *([v61 @ X22_v10 (Il2CppMethodInfo)+968]));\nL_0055:\n\tv389 = ids._count == 0;\n\tif (v389) goto L_0193;\n\tv406 = this.activeCount < 1;\n\tif (v406) goto L_FFFFFFFF;\n\tv466 = Il2CppMethodInfo;\n\tv467 = Il2CppMethodInfo;\n\tgoto L_0078;\nL_006B:\n\tv304 = v304 + 1;\n\tv506 = v304 >= this.activeCount;\n\tif (v506) goto L_0189;\nL_0078:\n\tv264 = this.particleIds;\n\tv515 = *([v466 @ X23_v7 (Il2CppMethodInfo)+990]);\n\tv248 = System.Collections.Generic.HashSet`1<System.Int32>::Contains(ids, v264[v304 @ X22_v1 (System.Int32)]);\n\tv611 = v248 == 0;\n\tv612 = ~v611;\n\tif (v612) goto L_006B;\n\tv265 = this.particleIds;\n\tv116 = v304 != v524;\n\tif (v116) goto L_00BD;\n\tv631 = v265 == 0;\n\tv253 = ~v631;\n\tif (v253) goto L_0185;\n\tgoto L_0195;\nL_00BD:\n\tv265[v524 @ X21_v16 (System.Int32)] = v265[v304 @ X22_v1 (System.Int32)];\n\tv653 = v304 << 3;\n\tv74 = this.positions + v653;\n\tv97 = v524 << 3;\n\tv654 = this.positions + v97;\n\t*([v654 @ X10_v12+20]) = *([v74 @ X11_v11+20]);\n\tv85 = this.particleTypes;\n\tv85[v524 @ X21_v16 (System.Int32)] = v85[v304 @ X22_v1 (System.Int32)];\n\tv86 = this.isRounded;\n\tv86[v524 @ X21_v16 (System.Int32)] = v86[v304 @ X22_v1 (System.Int32)];\n\tv665 = v304 << 4;\n\tv77 = this.emissionColors + v665;\n\tv100 = v524 << 4;\n\tv666 = this.emissionColors + v100;\n\t*([v666 @ X10_v18+20]) = *([v77 @ X11_v17+20]);\n\tv88 = this.scales;\n\tv88[v524 @ X21_v16 (System.Int32)] = v88[v304 @ X22_v1 (System.Int32)];\n\tv89 = this.innerRadii;\n\tv89[v524 @ X21_v16 (System.Int32)] = v89[v304 @ X22_v1 (System.Int32)];\nL_0185:\n\tSystem.Collections.Generic.Dictionary`2<System.Int32, System.Int32>::set_Item(this.idToIndex, v265[v524 @ X21_v16 (System.Int32)], v524);\n\tv629 = v524 + 1;\n\tgoto L_006B;\nL_0189:\n\tthis.activeCount = v454;\nL_0193:\n\treturn;\n\tv246 = new System.IndexOutOfRangeException();\nL_0195:\n\tv268 = new System.NullReferenceException();\nL_0196:\n\tv312 = new System.NullReferenceException();\n\tgoto L_01A4;\n\tgoto L_01A4;\nL_01A4:\n\tv339 = v349 != 1;\n\tif (v339) goto L_01B4;\n\tv346 = 0x274A080(v312, v349, v216, *([v467 @ X24_v7 (Il2CppMethodInfo)+290]), v32, v33, v34, v35, v233, v37, v38, v39, v40, v41, v42, v43);\n\tv390 = 0x274A098(v346, v349, v216, *([v467 @ X24_v7 (Il2CppMethodInfo)+290]), v32, v33, v34, v35, v233, v37, v38, v39, v40, v41, v42, v43);\n\tSystem.Collections.Generic.HashSet`1+Enumerator::Dispose /* +1 sharing this address */(v218, v304.m_value);\n\tv354 = *([v346 @ X0_v11]) == 0;\n\tif (v354) goto L_0055;\n\tv352 = new System.OutOfMemoryException();\nL_01B4:\n\tv358 = 0xBF092C(&v347 @ stack_-78_v2 (System.Int32), v349, v216, *([v467 @ X24_v7 (Il2CppMethodInfo)+290]), v32, v33, v34, v35, v233, v37, v38, v39, v40, v41, v42, v43);\n\tv392 = 0x27498DC(v355, v349, v216, *([v467 @ X24_v7 (Il2CppMethodInfo)+290]), v32, v33, v34, v35, v233, v37, v38, v39, v40, v41, v42, v43);\n\tv463 = 0xD6F8(v392, v349, v216, *([v467 @ X24_v7 (Il2CppMethodInfo)+290]), v32, v33, v34, v35, v233, v37, v38, v39, v40, v41, v42, v43);\n\treturn;\n// 332 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public unsafe void RemoveParticles(global::System.Collections.Generic.HashSet<int> ids)
	{
		foreach (int id in ids)
		{
			idToIndex.Remove(id);
		}
		if (ids.Count == 0)
		{
			return;
		}
		int writeIndex = 0;
		if (activeCount >= 1)
		{
			for (int i = 0; i < activeCount; i++)
			{
				if (ids.Contains(particleIds[i]))
				{
					continue;
				}
				if (i != writeIndex)
				{
					particleIds[writeIndex] = particleIds[i];
					positions[writeIndex] = positions[i];
					particleTypes[writeIndex] = particleTypes[i];
					isRounded[writeIndex] = isRounded[i];
					emissionColors[writeIndex] = emissionColors[i];
					scales[writeIndex] = scales[i];
					innerRadii[writeIndex] = innerRadii[i];
				}
				idToIndex[particleIds[writeIndex]] = writeIndex;
				writeIndex++;
			}
		}
		activeCount = writeIndex;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001DC")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF0E08", Offset = "0xFF0E08", Length = "0xB4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv24 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tgoto L_0022;\n\tv31 = Il2CppMethodInfo;\n\tv32 = v31 + 0x980;\n\tv33 = \"il2cpp_codegen_initialize_runtime_metadata\"(v32, id, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47);\n\tv54 = Il2CppMethodInfo;\n\tv55 = v54 + 0x968;\n\tv56 = \"il2cpp_codegen_initialize_runtime_metadata\"(v55, id, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47);\n\tv59 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv60 = v59 + 0x5D8;\n\tv49 = \"il2cpp_codegen_initialize_runtime_metadata\"(v60, id, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47);\n\tv51 = 1;\n\t*([302A9BB]) = v51;\nL_0022:\n\tv53 = new *([v24 @ X23_v1 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+5D8])();\n\tSystem.Collections.Generic.HashSet`1<System.Int32>::.ctor(v53);\n\tv67 = System.Collections.Generic.HashSet`1<System.Int32>::Add(v53, id);\n\tFluidCompute::RemoveParticles(this, v53);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 41 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void RemoveParticle(int id)
	{
		//IL_000e: Expected I, but got O
		nint num = 0;
		global::System.Collections.Generic.HashSet<int> hashSet = new global::System.Collections.Generic.HashSet<int>();
		bool flag = hashSet.Add(id);
		RemoveParticles(hashSet);
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001DD")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF0EBC", Offset = "0xFF0EBC", Length = "0xA4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tgoto L_001D;\n\tv25 = Il2CppMethodInfo;\n\tv26 = v25 + 0x230;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv51 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv52 = v51 + 0x450;\n\tv44 = \"il2cpp_codegen_initialize_runtime_metadata\"(v52, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv46 = 1;\n\t*([302A9BC]) = v46;\nL_001D:\n\tthis.layerCount = 1.086461844978E-311d;\n\tv50 = new *([v18 @ X20_v1 (Il2CppClass<System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>>)+450])();\n\tSystem.Collections.Generic.Dictionary`2<System.Int32, System.Int32>::.ctor(v50);\n\tv56 = this + 0x70;\n\tthis.idToIndex = v50;\n\tv58 = 0xF3F1B4(v56, v50, v29, v30, v31, v32, v33, v34, 1.086461844978E-311d, v36, v37, v38, v39, v40, v41, v42);\n\tthis.rawFieldDownscale = 1.1920931708431226E-07d;\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 35 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public FluidCompute()
	{
		layerCount = 8;
		maxParticles = 512;
		idToIndex = new global::System.Collections.Generic.Dictionary<int, int>();
		rawFieldDownscale = 0.125f;
		fieldDownscale = 0.25f;
	}
}
