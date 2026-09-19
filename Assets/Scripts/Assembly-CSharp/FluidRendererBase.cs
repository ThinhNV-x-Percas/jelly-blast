[global::Cpp2ILInjected.Token(Token = "0x200008D")]
public abstract class FluidRendererBase : global::UnityEngine.MonoBehaviour
{
	[global::Cpp2ILInjected.Token(Token = "0x40002A6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public FluidCompute compute;

	[global::Cpp2ILInjected.Token(Token = "0x40002A7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public global::UnityEngine.MeshRenderer mr;

	[global::Cpp2ILInjected.Token(Token = "0x40002A8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public global::UnityEngine.Vector2[] interpPositions;

	[global::Cpp2ILInjected.Token(Token = "0x40002A9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public global::UnityEngine.Vector2[] positions;

	[global::UnityEngine.HideInInspector]
	[global::Cpp2ILInjected.Token(Token = "0x40002AA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public float[] scales;

	[global::Cpp2ILInjected.Token(Token = "0x40002AB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public int activeCount;

	[global::Cpp2ILInjected.Token(Token = "0x40002AC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
	public int maxParticles;

	[global::UnityEngine.HideInInspector]
	[global::Cpp2ILInjected.Token(Token = "0x40002AD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public global::UnityEngine.Vector2 min;

	[global::UnityEngine.HideInInspector]
	[global::Cpp2ILInjected.Token(Token = "0x40002AE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public global::UnityEngine.Vector2 max;

	[global::Cpp2ILInjected.Token(Token = "0x40002AF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public global::UnityEngine.Vector2 position;

	[global::Cpp2ILInjected.Token(Token = "0x40002B0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	internal float particleBoundsRadius;

	[global::Cpp2ILInjected.Token(Token = "0x6000267")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF11CC", Offset = "0xFF11CC", Length = "0x150")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv22 = CollectParticleData[];\n\tv24 = CollectParticleData[];\n\tgoto L_0022;\n\tv29 = CollectParticleData[];\n\tv30 = v29 + 0x990;\n\tv31 = \"il2cpp_codegen_initialize_runtime_metadata\"(v30, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv54 = CollectParticleData[];\n\tv55 = v54 + 0x4B8;\n\tv56 = \"il2cpp_codegen_initialize_runtime_metadata\"(v55, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv61 = CollectParticleData[];\n\tv62 = v61 + 0x648;\n\tv48 = \"il2cpp_codegen_initialize_runtime_metadata\"(v62, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv50 = 1;\n\t*([302A9FC]) = v50;\nL_0022:\n\tv53 = \"SzArrayNew\"(*([v22 @ X21_v1 (Il2CppClass<CollectParticleData[]>)+648]), this.maxParticles, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv59 = this + 0x38;\n\tthis.positions = v53;\n\tv60 = 0xF3F1B4(v59, v53, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv65 = \"SzArrayNew\"(*([v22 @ X21_v1 (Il2CppClass<CollectParticleData[]>)+648]), this.maxParticles, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv68 = this + 0x30;\n\tthis.interpPositions = v65;\n\tv69 = 0xF3F1B4(v68, v65, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv72 = \"SzArrayNew\"(*([v24 @ X20_v1 (Il2CppClass<CollectParticleData[]>)+4B8]), this.maxParticles, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv75 = this + 0x40;\n\tthis.scales = v72;\n\tv77 = 0xF3F1B4(v75, v72, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv78 = this.compute;\n\tv80 = CollectParticleData[];\n\tv82 = this.compute + 0xF8;\n\tv85 = new *([v80 @ X23_v1 (Il2CppClass<CollectParticleData[]>)+990])();\n\tv88 = this->klass;\n\tSystem.Action::.ctor(v85, this, *([v88 @ X8_v3 (Il2CppClass<FluidRendererBase>)+190]));\n\tv95 = System.Delegate::Combine(v78.OnPreUpdate, v85);\n\tv139 = v95 == 0;\n\tif (v139) goto L_006A;\n\tv163 = *([v95 @ X0_v20 (System.Delegate)]) != *([v80 @ X23_v1 (Il2CppClass<CollectParticleData[]>)+990]);\n\tif (v163) goto L_0069;\n\tv78.OnPreUpdate = v95;\n\tv191 = *([v95 @ X0_v20 (System.Delegate)]) == *([v80 @ X23_v1 (Il2CppClass<CollectParticleData[]>)+990]);\n\tif (v191) goto L_0076;\nL_0069:\n\tthrow System.InvalidCastException;\nL_006A:\n\tv78.OnPreUpdate = 0;\nL_0076:\n\tv137 = 0xF3F1B4(v82, v95, 0, 0, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 76 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public virtual void Init()
	{
		positions = new global::UnityEngine.Vector2[maxParticles];
		interpPositions = new global::UnityEngine.Vector2[maxParticles];
		scales = new float[maxParticles];
		compute.OnPreUpdate += OnPreComputeUpdate;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000268")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF1BCC", Offset = "0xFF1BCC", Length = "0x294")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv25 = this.activeCount == 0;\n\tif (v25) goto L_00A6;\n\tthis.min = *([2875970]);\n\tv38 = this.activeCount < 1;\n\tif (v38) goto L_FFFFFFFF;\n\tv187 = this.interpPositions + 0x24;\nL_0036:\n\tv181 = this.scales;\n\tv270 = this.particleBoundsRadius * v181[v242 @ X9_v6 (System.Int32)];\n\tv400 = *([v187 @ X11_v6-4]) - v270;\n\tv410 = v168 >= v400;\n\tif (v410) goto L_FFFFFFFF;\n\tgoto L_005A;\nL_005A:\n\tv269 = *([v187 @ X11_v6]) - v270;\n\tv422 = v177 >= v269;\n\tif (v422) goto L_FFFFFFFF;\n\tgoto L_006A;\nL_006A:\n\tthis.min = v168;\n\tthis.min.y = v177;\n\tv427 = *([v187 @ X11_v6-4]) + v270;\n\tv430 = v171 - v427;\n\tv431 = v430 < 0;\n\tv432 = v430 == 0;\n\tv433 = v171 ^ v427;\n\tv434 = v171 ^ v430;\n\tv435 = v433 & v434;\n\tv436 = v435 < 0;\n\tv437 = v431 == v436;\n\tv438 = ~v432;\n\tv439 = v437 & v438;\n\tv440 = ~v439;\n\tif (v440) goto L_FFFFFFFF;\n\tgoto L_007F;\nL_007F:\n\tv275 = *([v187 @ X11_v6]) + v270;\n\tv450 = v174 - v275;\n\tv451 = v450 < 0;\n\tv452 = v450 == 0;\n\tv453 = v174 ^ v275;\n\tv454 = v174 ^ v450;\n\tv455 = v453 & v454;\n\tv456 = v455 < 0;\n\tv457 = v451 == v456;\n\tv267 = ~v452;\n\tv458 = v457 & v267;\n\tv268 = ~v458;\n\tif (v268) goto L_FFFFFFFF;\n\tgoto L_0092;\nL_0092:\n\tthis.max = v171;\n\tthis.max.y = v174;\n\tv242 = v242 + 1;\n\tv187 = v187 + 8;\n\tv283 = this.activeCount != v242;\n\tif (v283) goto L_0036;\n\tgoto L_00EB;\nL_00A6:\n\tgoto L_00AC;\n\tv51 = System.Xml.ValidateNames;\n\tv52 = v51 + 0x98;\n\tv53 = \"il2cpp_codegen_initialize_runtime_metadata\"(v52, methodInfo, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68);\n\tv71 = 1;\n\t*([2DD4424]) = v71;\nL_00AC:\n\tv72 = System.Xml.ValidateNames;\n\tv74 = *([v72 @ X8_v6 (Il2CppClass<System.Xml.ValidateNames>)+98]);\n\tv75 = *([v74 @ X8_v8+B8]);\n\tthis.position = *([v75 @ X8_v9]);\n\tv297 = UnityEngine.Component::get_transform(this.mr);\n\tv119 = UnityEngine.Component::get_transform(this.mr);\n\tv235 = UnityEngine.Transform::get_position(v119);\n\t// 201 MakeStruct v102 @ AGGFF1D28_1_v3 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), 0, 0, v235.z (System.Single)\n\tUnityEngine.Transform::set_position(v297, v102);\n\tv441 = UnityEngine.Component::get_transform(this.mr);\n\tgoto L_00DD;\n\tv459 = System.Xml.ValidateNames;\n\tv460 = v459 + 0xD0;\n\tv461 = \"il2cpp_codegen_initialize_runtime_metadata\"(v460, v115, v55, v56, v57, v58, v59, v60, v236, v156, v149, v64, v65, v66, v67, v68);\n\tv462 = 1;\n\t*([2DD4419]) = v462;\nL_00DD:\n\tv465 = System.Xml.ValidateNames;\n\tv467 = *([v465 @ X8_v12 (Il2CppClass<System.Xml.ValidateNames>)+D0]);\n\tv468 = *([v467 @ X8_v14+B8]);\n\tv350 = *([v468 @ X8_v15+4]);\n\tv348 = *([v468 @ X8_v15+8]);\n\tv386 = *([v468 @ X8_v15]);\n\tgoto L_012F;\nL_00EB:\n\tv295 = v168 + v171;\n\tv296 = v177 + v174;\n\tv237 = v295 * 0.5f;\n\tv157 = v296 * 0.5f;\n\t*([2DD4060]) = v237;\n\t*([2DD4064]) = v157;\n\tv309 = UnityEngine.Component::get_transform(*([2DD4028]));\n\tv122 = UnityEngine.Component::get_transform(*([2DD4028]));\n\tv238 = UnityEngine.Transform::get_position(v122);\n\t// 267 MakeStruct v95 @ AGGFF1DF8_1_v3 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), [2DD4060], [2DD4064], v238.z (System.Single)\n\tUnityEngine.Transform::set_position(v309, v95);\n\tv444 = UnityEngine.Component::get_transform(*([2DD4028]));\n\tv125 = UnityEngine.Component::get_transform(*([2DD4028]));\n\tv240 = UnityEngine.Transform::get_localScale(v125);\n\tv348 = v240.z;\n\tv386 = v171 - v168;\n\tv350 = v174 - v177;\nL_012F:\n\t// 303 MakeStruct v319 @ AGGFF1E54_1_v1 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), v386 @ V0_v1 (System.Single), v350 @ V1_v1 (System.Single), v348 @ V2_v1 (System.Single)\n\tUnityEngine.Transform::set_localScale(v477, v319);\n\treturn;\n\tv117 = new System.IndexOutOfRangeException();\n\tthrow System.NullReferenceException;\n\treturn;\n// 204 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public virtual void OnPreComputeUpdate()
	{
		if (activeCount > 0)
		{
			float minX = float.PositiveInfinity;
			float maxX = float.NegativeInfinity;
			float maxY = float.NegativeInfinity;
			float minY = float.PositiveInfinity;
			for (int i = 0; i < activeCount; i++)
			{
				float radius = particleBoundsRadius * scales[i];
				float x0 = interpPositions[i].x - radius;
				if (minX > x0)
				{
					minX = x0;
				}
				float y0 = interpPositions[i].y - radius;
				if (minY > y0)
				{
					minY = y0;
				}
				float x1 = interpPositions[i].x + radius;
				if (maxX < x1)
				{
					maxX = x1;
				}
				float y1 = interpPositions[i].y + radius;
				if (maxY < y1)
				{
					maxY = y1;
				}
			}
			min = new global::UnityEngine.Vector2(minX, minY);
			max = new global::UnityEngine.Vector2(maxX, maxY);
			float centerX = (minX + maxX) * 0.5f;
			float centerY = (minY + maxY) * 0.5f;
			global::UnityEngine.Transform transform = mr.transform;
			global::UnityEngine.Vector3 currentPos = transform.position;
			transform.position = new global::UnityEngine.Vector3(centerX, centerY, currentPos.z);
			float z = transform.localScale.z;
			transform.localScale = new global::UnityEngine.Vector3(maxX - minX, maxY - minY, z);
		}
		else
		{
			position = default(global::UnityEngine.Vector2);
			global::UnityEngine.Transform transform2 = mr.transform;
			global::UnityEngine.Vector3 currentPos2 = transform2.position;
			transform2.position = new global::UnityEngine.Vector3(0f, 0f, currentPos2.z);
			transform2.localScale = global::UnityEngine.Vector3.zero;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000269")]
	[global::Cpp2ILInjected.Address(RVA = "0xFFED18", Offset = "0xFFED18", Length = "0x144")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv22 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv77 = Facebook.Unity.Windows.IWindowsFacebook + 0xFD8;\n\tv24 = *([302A9FD]) & 1;\n\tv25 = v24 == 0;\n\tif (v25) goto L_0055;\n\tv27 = *([v22 @ X21_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv29 = *([v27 @ X0_v27+E0]) == 0;\n\tif (v29) goto L_0060;\nL_001A:\n\tv125 = UnityEngine.Object::op_Inequality(v120, 0);\n\tv150 = ~v125;\n\tif (v150) goto L_006D;\nL_001D:\n\tv178 = this.compute;\n\tv81 = this.compute + 0xF8;\n\tv209 = CollectParticleData[];\n\tv211 = new *([v209 @ X23_v6 (Il2CppClass<CollectParticleData[]>)+990])();\n\tv257 = this->klass;\n\tSystem.Action::.ctor(v211, this, *([v257 @ X8_v8 (Il2CppClass<FluidRendererBase>)+190]));\n\tv262 = System.Delegate::Remove(v178.OnPreUpdate, v211);\n\tv76 = v262 == 0;\n\tif (v76) goto L_006E;\n\tv31 = *([v262 @ X0_v19 (System.Delegate)]) != *([v209 @ X23_v6 (Il2CppClass<CollectParticleData[]>)+990]);\n\tif (v31) goto L_004D;\n\tv178.OnPreUpdate = v262;\n\tv278 = *([v262 @ X0_v19 (System.Delegate)]) == *([v209 @ X23_v6 (Il2CppClass<CollectParticleData[]>)+990]);\n\tif (v278) goto L_007A;\nL_004D:\n\tthrow System.InvalidCastException;\nL_0055:\n\t*([v81 @ X20_v5 (System.Int32)+9FD]) = 1;\n\tv114 = *([v77 @ X21_v6 (System.Delegate)]);\n\tv156 = *([v114 @ X0_v13 (Il2CppClass<System.Delegate>)+E0]) == 0;\n\tv116 = ~v156;\n\tif (v116) goto L_001A;\nL_0060:\n\tv154 = UnityEngine.Object::op_Inequality(v145, 0);\n\tv208 = ~v154;\n\tv174 = ~v208;\n\tif (v174) goto L_001D;\nL_006D:\n\treturn;\nL_006E:\n\tv178.OnPreUpdate = 0;\nL_007A:\n\tv246 = 0xF3F1B4(v81, v262, 0, 0, v86, v87, v88, v89, v90, v91, v92, v93, v94, v95, v96, v97);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 85 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void OnDestroy()
	{
		if (compute != null)
		{
			compute.OnPreUpdate -= OnPreComputeUpdate;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x600026A")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF1E80", Offset = "0xFF1E80", Length = "0x14")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tthis.particleBoundsRadius = 0.4f;\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 3 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	protected internal FluidRendererBase()
	{
		particleBoundsRadius = 0.4f;
	}
}
