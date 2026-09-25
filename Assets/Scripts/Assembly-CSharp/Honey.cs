[global::Cpp2ILInjected.Token(Token = "0x20000AD")]
public class Honey : FluidRendererBase
{
	[global::Cpp2ILInjected.Token(Token = "0x40003D9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	private FluidSolver solver;

	[global::Cpp2ILInjected.Token(Token = "0x40003DA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	private float fixedDeltaTime;

	[global::Cpp2ILInjected.Token(Token = "0x40003DB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public int[] solverIds;

	[global::Cpp2ILInjected.Token(Token = "0x40003DC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public int[] computeIds;

	[global::Cpp2ILInjected.Token(Token = "0x40003DD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public float particleSize;

	[global::Cpp2ILInjected.Token(Token = "0x40003DE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	protected global::UnityEngine.MaterialPropertyBlock _propBlock;

	[global::Cpp2ILInjected.Token(Token = "0x6000311")]
	[global::Cpp2ILInjected.Address(RVA = "0x100CDC8", Offset = "0x100CDC8", Length = "0x320")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv24 = 0x302A000;\n\tv26 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv204 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression> + 0xA48;\n\tv28 = *([302AA55]) & 1;\n\tv29 = v28 == 0;\n\tif (v29) goto L_0036;\n\tv82 = Il2CppMethodInfo + 0xC90;\n\tv32 = *([v26 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A48]);\n\tv34 = *([v32 @ X0_v85+E0]) == 0;\n\tif (v34) goto L_0040;\nL_001B:\n\tv78 = Singleton`1::get_Instance /* +1 sharing this address */(*([v82 @ X21_v6]));\n\tv71 = v78 == 0;\n\tv72 = ~v71;\n\tif (v72) goto L_0045;\n\tgoto L_00DE;\nL_0036:\n\t*([v24 @ X21_v1+A55]) = 1;\n\tv82 = Il2CppMethodInfo + 0xC90;\n\tv54 = *([v26 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A48]);\n\tv233 = *([v54 @ X0_v81+E0]) == 0;\n\tv56 = ~v233;\n\tif (v56) goto L_001B;\nL_0040:\n\tv78 = Singleton`1::get_Instance /* +1 sharing this address */(*([v66 @ X21_v18]));\nL_0045:\n\tv204 = this + 0x70;\n\tthis.solver = *([v78 @ X0_v7+30]);\n\tv87 = 0xF3F1B4(v204, *([v78 @ X0_v7+30]), v195, v193, v41, v42, v43, v44, v196, v46, v47, v48, v49, v50, v51, v52);\n\tv126 = Singleton`1::get_Instance /* +1 sharing this address */(*([v82 @ X21_v6]));\n\tv145 = *([v126 @ X0_v11+38]);\n\tv225 = CollectParticleData[];\n\tv227 = Facebook.Unity.Windows.IWindowsFacebook;\n\tthis.fixedDeltaTime = *([v145 @ X8_v6+28]);\n\tFluidRendererBase::Init(this);\n\tv258 = \"SzArrayNew\"(*([v225 @ X21_v7 (Il2CppClass<CollectParticleData[]>)+2D0]), this.maxParticles, v195, v193, v41, v42, v43, v44, *([v145 @ X8_v6+28]), v46, v47, v48, v49, v50, v51, v52);\n\tv261 = this + 0x80;\n\tthis.solverIds = v258;\n\tv262 = 0xF3F1B4(v261, v258, v195, v193, v41, v42, v43, v44, *([v145 @ X8_v6+28]), v46, v47, v48, v49, v50, v51, v52);\n\tv265 = \"SzArrayNew\"(*([v225 @ X21_v7 (Il2CppClass<CollectParticleData[]>)+2D0]), this.maxParticles, v195, v193, v41, v42, v43, v44, *([v145 @ X8_v6+28]), v46, v47, v48, v49, v50, v51, v52);\n\tv268 = this + 0x88;\n\tthis.computeIds = v265;\n\tv269 = 0xF3F1B4(v268, v265, v195, v193, v41, v42, v43, v44, *([v145 @ X8_v6+28]), v46, v47, v48, v49, v50, v51, v52);\n\tv271 = new *([v227 @ X22_v5 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+900])();\n\tUnityEngine.MaterialPropertyBlock::.ctor(v271);\n\tv151 = this + 0x98;\n\tthis._propBlock = v271;\n\tv275 = 0xF3F1B4(v151, v271, v195, v193, v41, v42, v43, v44, *([v145 @ X8_v6+28]), v46, v47, v48, v49, v50, v51, v52);\n\tUnityEngine.Renderer::GetPropertyBlock(this.mr, this._propBlock);\n\tv146 = this.solver;\n\tv276 = \"Writing object reference to Id '{0}' for {1}.\";\n\tUnityEngine.MaterialPropertyBlock::SetInt(this._propBlock, *([v276 @ X9_v4 (System.String)+9E0]), v146.honeyFluidType);\n\tUnityEngine.Renderer::SetPropertyBlock(this.mr, this._propBlock);\n\tv147 = this.solver;\n\tv277 = System.Collections.Generic.NullableComparer`1;\n\tv278 = Il2CppMethodInfo;\n\tv150 = this.solver + 0x260;\n\tv281 = new *([v277 @ X24_v5 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+DB8])();\n\tSystem.Action`2<System.Object, System.Boolean>::.ctor(v281, this, *([v278 @ X25_v5 (Il2CppMethodInfo)+40]));\n\tv287 = System.Delegate::Combine(v147.OnStartRemoveParticles, v281);\n\tv288 = v287 == 0;\n\tif (v288) goto L_00D7;\n\tv291 = 0xF3F36C(v287, *([v277 @ X24_v5 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+DB8]), 0, 0, v41, v42, v43, v44, *([v145 @ X8_v6+28]), v46, v47, v48, v49, v50, v51, v52);\n\tv301 = v291 == 0;\n\tif (v301) goto L_00F1;\n\tv147.OnStartRemoveParticles = v291;\n\tv305 = 0xF3F36C(v287, *([v277 @ X24_v5 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+DB8]), 0, 0, v41, v42, v43, v44, *([v145 @ X8_v6+28]), v46, v47, v48, v49, v50, v51, v52);\n\tv308 = v305 == 0;\n\tif (v308) goto L_00F1;\n\tv130 = 0xF3F1B4(v150, v305, 0, 0, v41, v42, v43, v44, *([v145 @ X8_v6+28]), v46, v47, v48, v49, v50, v51, v52);\n\tv181 = this.solver;\nL_00B5:\n\tv204 = v181 + 0x250;\n\tv319 = new *([v277 @ X24_v5 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+DB8])();\n\tSystem.Action`2<System.Object, System.Boolean>::.ctor(v319, v185, *([v278 @ X25_v5 (Il2CppMethodInfo)+40]));\n\tv175 = System.Delegate::Combine(v181.OnRemoveHoneyCoating, v319);\n\tv177 = v175 == 0;\n\tif (v177) goto L_00E0;\n\tv150 = *([v277 @ X24_v5 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+DB8]);\n\tv326 = 0xF3F36C(v175, *([v277 @ X24_v5 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+DB8]), 0, 0, v41, v42, v43, v44, *([v145 @ X8_v6+28]), v46, v47, v48, v49, v50, v51, v52);\n\tv327 = v326 == 0;\n\tif (v327) goto L_FFFFFFFF;\n\tv181.OnRemoveHoneyCoating = v326;\n\tv201 = 0xF3F36C(v175, *([v277 @ X24_v5 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+DB8]), 0, 0, v41, v42, v43, v44, *([v145 @ X8_v6+28]), v46, v47, v48, v49, v50, v51, v52);\n\tv333 = v201 == 0;\n\tv203 = ~v333;\n\tif (v203) goto L_00ED;\n\tthrow System.InvalidCastException;\nL_00D7:\n\t*([v150 @ X21_v12]) = 0;\n\tv125 = 0xF3F1B4(v150, 0, 0, 0, v41, v42, v43, v44, *([v145 @ X8_v6+28]), v46, v47, v48, v49, v50, v51, v52);\n\tv181 = *([v204 @ X20_v3]);\n\tv302 = *([v204 @ X20_v3]) == 0;\n\tv132 = ~v302;\n\tif (v132) goto L_00B5;\nL_00DE:\n\tthrow System.NullReferenceException;\nL_00E0:\n\t*([v204 @ X20_v3]) = 0;\nL_00ED:\n\tv221 = 0xF3F1B4(v204, v198, v195, v193, v41, v42, v43, v44, *([v145 @ X8_v6+28]), v46, v47, v48, v49, v50, v51, v52);\n\treturn;\nL_00F1:\n\tthrow System.InvalidCastException;\n// 149 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public override void Init()
	{
		solver = Singleton<GameManager>.Instance.solver;
		fixedDeltaTime = global::UnityEngine.Time.fixedDeltaTime;
		base.Init();
		solverIds = new int[maxParticles];
		computeIds = new int[maxParticles];
		_propBlock = new global::UnityEngine.MaterialPropertyBlock();
		mr.GetPropertyBlock(_propBlock);
		_propBlock.SetInt("_HoneyFluidType", solver.honeyFluidType);
		mr.SetPropertyBlock(_propBlock);
		solver.OnStartRemoveParticles += OnSolverRemoveParticlesStart;
		solver.OnRemoveHoneyCoating += OnSolverRemoveParticlesStart;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000312")]
	[global::Cpp2ILInjected.Address(RVA = "0x1007774", Offset = "0x1007774", Length = "0x198")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv26 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tgoto L_0021;\n\tv31 = System.Collections.Generic.NullableComparer`1;\n\tv32 = v31 + 0xD10;\n\tv33 = \"il2cpp_codegen_initialize_runtime_metadata\"(v32, solverContext, methodInfo, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv53 = Il2CppMethodInfo;\n\tv54 = v53 + 0xF20;\n\tv55 = \"il2cpp_codegen_initialize_runtime_metadata\"(v54, solverContext, methodInfo, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv58 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv59 = v58 + 0xE10;\n\tv48 = \"il2cpp_codegen_initialize_runtime_metadata\"(v59, solverContext, methodInfo, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv50 = 1;\n\t*([302AAB7]) = v50;\nL_0021:\n\tv52 = new *([v26 @ X23_v1 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+E10])();\n\tSystem.Object::.ctor(v52);\n\tv62 = v52 + 0x10;\n\t*([v52 @ X0_v3 (System.Object)+10]) = this;\n\tv65 = 0xF3F1B4(v62, this, methodInfo, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\t*([v52 @ X0_v3 (System.Object)+18]) = solverContext;\n\t*([v52 @ X0_v3 (System.Object)+20]) = methodInfo;\n\tv130 = this.solver;\n\tv165 = v130.isHoneyCoated;\n\tv167 = *([v165 @ X8_v6 (Unity.Collections.NativeArray`1<System.Boolean>)+solverContext @ X1 (ParticleInitData)]) == 0;\n\tif (v167) goto L_008C;\n\tv131 = this.solverIds;\n\tv114 = this.activeCount;\n\tv110 = solverContext >> 0x20;\n\tv131[v114 @ X9_v4 (System.Int32)] = v110;\n\tv230 = Facebook.Unity.Windows.IWindowsFacebook;\n\tgoto L_0056;\n\tv234 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv235 = v234 + 0x78;\n\tv236 = \"il2cpp_codegen_initialize_runtime_metadata\"(v235, v64, methodInfo, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv239 = 1;\n\t*([302AAB8]) = v239;\nL_0056:\n\tv240 = *([v230 @ X22_v6 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+78]);\n\tv120 = System.Threading.Interlocked::Increment(*([v240 @ X8_v13+B8]));\n\tv132 = this.computeIds;\n\tv115 = this.activeCount;\n\tv243 = System.Collections.Generic.NullableComparer`1;\n\tv244 = Il2CppMethodInfo;\n\tv132[v115 @ X9_v5 (System.Int32)] = v120;\n\tv121 = new *([v243 @ X10_v7 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+D10])();\n\tSystem.Action`1<ParticleInitData>::.ctor(v121, v52, *([v244 @ X24_v5 (Il2CppMethodInfo)+F20]));\n\tFluidCompute::AddParticle(this.compute, v120, v121);\n\tv191 = this.activeCount + 1;\n\tthis.activeCount = v191;\nL_008C:\n\treturn;\n\tv140 = new System.NullReferenceException();\n\tthrow System.IndexOutOfRangeException;\n\treturn;\n// 93 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void AddSolverParticle(ParticleInitData solverContext)
	{
		if (!solver.isHoneyCoated[solverContext.Index] || activeCount >= solverIds.Length)
		{
			return;
		}
		solverIds[activeCount] = solverContext.Id;
		int computeId = IdGenerator.Next();
		computeIds[activeCount] = computeId;
		compute.AddParticle(computeId, ctx =>
		{
			compute.particleTypes[ctx.Index] = solver.honeyFluidType;
			compute.positions[ctx.Index] = solver.positions[solverContext.Index];
		});
		activeCount++;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000313")]
	[global::Cpp2ILInjected.Address(RVA = "0x100D13C", Offset = "0x100D13C", Length = "0x2F4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_002B;\n\tv27 = Il2CppMethodInfo;\n\tv28 = v27 + 0xC88;\n\tv29 = \"il2cpp_codegen_initialize_runtime_metadata\"(v28, ids, explode, methodInfo, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv52 = Il2CppMethodInfo;\n\tv53 = v52 + 0x968;\n\tv54 = \"il2cpp_codegen_initialize_runtime_metadata\"(v53, ids, explode, methodInfo, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv190 = Il2CppMethodInfo;\n\tv191 = v190 + 0x970;\n\tv192 = \"il2cpp_codegen_initialize_runtime_metadata\"(v191, ids, explode, methodInfo, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv243 = Il2CppMethodInfo;\n\tv244 = v243 + 0x978;\n\tv245 = \"il2cpp_codegen_initialize_runtime_metadata\"(v244, ids, explode, methodInfo, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv275 = Il2CppMethodInfo;\n\tv276 = v275 + 0x990;\n\tv277 = \"il2cpp_codegen_initialize_runtime_metadata\"(v276, ids, explode, methodInfo, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv308 = Il2CppMethodInfo;\n\tv309 = v308 + 0x998;\n\tv45 = \"il2cpp_codegen_initialize_runtime_metadata\"(v309, ids, explode, methodInfo, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv47 = 1;\n\t*([302AA56]) = v47;\nL_002B:\n\t;\n\tv57 = Il2CppMethodInfo;\n\tv59 = Il2CppMethodInfo;\n\tv63 = Il2CppMethodInfo;\n\tv64 = Il2CppMethodInfo + 0x968;\n\tv69 = System.Collections.Generic.HashSet`1<System.Int32>::GetEnumerator(ids);\nL_0042:\n\tv274 = System.Collections.Generic.HashSet`1+Enumerator::MoveNext /* +1 sharing this address */(&v162 @ stack_-78_v5 (System.Int32), *([v57 @ X23_v13 (Il2CppMethodInfo)+970]));\n\tv278 = v274 & 1;\n\tv279 = v278 == 0;\n\tif (v279) goto L_006A;\n\tv236 = System.Array::IndexOf(this.solverIds, v196);\n\tv268 = v236 + 1;\n\tv258 = v268 == 0;\n\tif (v258) goto L_0042;\n\tv214 = this.computeIds;\n\tv238 = this.computeIds == 0;\n\tif (v238) goto L_0135;\n\tv416 = v236 < v214.Length;\n\tv218 = ~v416;\n\tif (v218) goto L_0133;\n\tFluidCompute::RemoveParticle(this.compute, v214[v236 @ X0_v33 (System.Int32)]);\n\tgoto L_0042;\nL_006A:\n\tSystem.Collections.Generic.HashSet`1+Enumerator::Dispose /* +1 sharing this address */(&v162 @ stack_-78_v5 (System.Int32), *([v63 @ X22_v13 (Il2CppMethodInfo)+968]));\nL_0076:\n\tv360 = this.activeCount < 1;\n\tif (v360) goto L_FFFFFFFF;\n\tgoto L_008F;\nL_0080:\n\tv119[v430 @ X22_v11 (System.Int32)] = v119[v173 @ X23_v11 (System.Int32)];\nL_0081:\n\tv430 = v430 + 1;\nL_0082:\n\tv173 = v173 + 1;\n\tv418 = v173 >= this.activeCount;\n\tif (v418) goto L_0127;\nL_008F:\n\tv184 = this.solverIds;\n\tv176 = System.Collections.Generic.HashSet`1<System.Int32>::Contains(ids, v184[v173 @ X23_v11 (System.Int32)]);\n\tv554 = v176 == 0;\n\tv555 = ~v554;\n\tif (v555) goto L_0082;\n\tv137 = v173 == v430;\n\tif (v137) goto L_0081;\n\tv116 = this.solverIds;\n\tv116[v430 @ X22_v11 (System.Int32)] = v116[v173 @ X23_v11 (System.Int32)];\n\tv117 = this.computeIds;\n\tv117[v430 @ X22_v11 (System.Int32)] = v117[v173 @ X23_v11 (System.Int32)];\n\tv600 = v173 << 3;\n\tv74 = this.positions + v600;\n\tv84 = v430 << 3;\n\tv601 = this.positions + v84;\n\t*([v601 @ X9_v17+20]) = *([v74 @ X10_v17+20]);\n\tv119 = this.scales;\n\tv603 = v430 < v119.Length;\n\tv535 = ~v603;\n\tv509 = ~v535;\n\tif (v509) goto L_0080;\n\tthrow System.IndexOutOfRangeException;\nL_0127:\n\tthis.activeCount = v451;\n\treturn;\n\tv189 = new System.NullReferenceException();\nL_0133:\n\tv242 = new System.IndexOutOfRangeException();\n\tgoto L_0138;\nL_0135:\n\tv304 = new System.NullReferenceException();\n\tgoto L_0138;\n\tv303 = new System.NullReferenceException();\nL_0138:\n\t// 312 Interrupt\n\tgoto L_0147;\n\tgoto L_0147;\n\tgoto L_0147;\n\tgoto L_0147;\n\tgoto L_0147;\nL_0147:\n\tv322 = v363 != 1;\n\tif (v322) goto L_0157;\n\tv361 = 0x274A080(v365, v363, *([v59 @ X24_v6 (Il2CppMethodInfo)+C88]), methodInfo, v32, v33, v34, v35, v162, v37, v38, v39, v40, v41, v42, v43);\n\tv413 = 0x274A098(v361, v363, *([v59 @ X24_v6 (Il2CppMethodInfo)+C88]), methodInfo, v32, v33, v34, v35, v162, v37, v38, v39, v40, v41, v42, v43);\n\tv363 = *([v64 @ X22_v14]);\n\tSystem.Collections.Generic.HashSet`1+Enumerator::Dispose /* +1 sharing this address */(&v162 @ stack_-78_v5 (System.Int32), *([v64 @ X22_v14]));\n\tv346 = *([v361 @ X0_v9]) == 0;\n\tif (v346) goto L_0076;\n\tv365 = new System.OutOfMemoryException();\nL_0157:\n\tv371 = 0xBF092C(&v162 @ stack_-78_v5 (System.Int32), v363, *([v59 @ X24_v6 (Il2CppMethodInfo)+C88]), methodInfo, v32, v33, v34, v35, v162, v37, v38, v39, v40, v41, v42, v43);\n\tv415 = 0x27498DC(v365, v363, *([v59 @ X24_v6 (Il2CppMethodInfo)+C88]), methodInfo, v32, v33, v34, v35, v162, v37, v38, v39, v40, v41, v42, v43);\n\tv464 = 0xD6F8(v415, v363, *([v59 @ X24_v6 (Il2CppMethodInfo)+C88]), methodInfo, v32, v33, v34, v35, v162, v37, v38, v39, v40, v41, v42, v43);\n\treturn;\n// 247 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void OnSolverRemoveParticlesStart(global::System.Collections.Generic.HashSet<int> ids, bool explode)
	{
		foreach (int particleId in ids)
		{
			int index = global::System.Array.IndexOf(solverIds, particleId);
			if (index == -1)
			{
				continue;
			}
			compute.RemoveParticle(computeIds[index]);
		}
		int writeIndex = 0;
		for (int readIndex = 0; readIndex < activeCount; readIndex++)
		{
			if (ids.Contains(solverIds[readIndex]))
			{
				continue;
			}
			if (writeIndex != readIndex)
			{
				solverIds[writeIndex] = solverIds[readIndex];
				computeIds[writeIndex] = computeIds[readIndex];
				positions[writeIndex] = positions[readIndex];
				scales[writeIndex] = scales[readIndex];
			}
			writeIndex++;
		}
		activeCount = writeIndex;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000314")]
	[global::Cpp2ILInjected.Address(RVA = "0x100D430", Offset = "0x100D430", Length = "0x3C8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_002A;\n\tv45 = Il2CppMethodInfo;\n\tv46 = v45 + 0x278;\n\tv47 = \"il2cpp_codegen_initialize_runtime_metadata\"(v46, methodInfo, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62);\n\tv69 = Il2CppMethodInfo;\n\tv70 = v69 + 0xC30;\n\tv71 = \"il2cpp_codegen_initialize_runtime_metadata\"(v70, methodInfo, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62);\n\tv74 = \"Writing object reference to Id '{0}' for {1}.\";\n\tv75 = v74 + 0x8B0;\n\tv76 = \"il2cpp_codegen_initialize_runtime_metadata\"(v75, methodInfo, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62);\n\tv414 = \"Writing object reference to Id '{0}' for {1}.\";\n\tv415 = v414 + 0x8B8;\n\tv64 = \"il2cpp_codegen_initialize_runtime_metadata\"(v415, methodInfo, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62);\n\tv66 = 1;\n\t*([302AA57]) = v66;\nL_002A:\n\tv68 = UnityEngine.Time::get_time();\n\tv72 = this.solver;\n\tv88 = this.activeCount < 1;\n\tif (v88) goto L_0159;\n\tv418 = Il2CppMethodInfo;\n\tv421 = v68 - v72.<lastStepWallTime>k__BackingField;\n\tv423 = v421 / this.fixedDeltaTime;\n\tv427 = v423 - 1f;\n\tv428 = v427 < 0;\n\tv429 = v427 == 0;\n\tv430 = v423 ^ 1f;\n\tv431 = v423 ^ v427;\n\tv432 = v430 & v431;\n\tv433 = v432 < 0;\n\tv434 = v428 == v433;\n\tv203 = ~v429;\n\tv435 = v434 & v203;\n\tv436 = ~v435;\n\tif (v436) goto L_0062;\n\tgoto L_0062;\nL_0062:\n\tv199 = v423 >= 0;\n\tif (v199) goto L_FFFFFFFF;\n\tgoto L_FFFFFFFF;\nL_006C:\n\tv348 = this.solverIds;\n\tv615 = this.solver + 0x1F8;\n\tv360 = Unity.Collections.NativeHashMap`2::get_Item /* +1 sharing this address */(v615, v348[v233 @ X22_v6 (System.Int32)], *([v418 @ X23_v5 (Il2CppMethodInfo)+C30]));\n\tv398 = this.solver;\n\tv183 = v360 << 3;\n\tv399 = v398.positions + v183;\n\t// 139 MakeStruct v154 @ AGG100D554_0_v5 (Unity.Mathematics.float2), typeof(Unity.Mathematics.float2), [v399 @ X8_v16], [v399 @ X8_v16+4]\n\tv207 = Unity.Mathematics.float2::op_Implicit(v154);\n\tv624 = this.positions + v236;\n\t*([v624 @ X8_v18+20]) = v207;\n\t*([v624 @ X8_v18+24]) = v207.y;\n\tv400 = this.solver;\n\tv349 = this.scales;\n\tv147 = v400.scales;\n\tv630 = this.particleSize * *([v147 @ X11_v5 (Unity.Collections.NativeArray`1<System.Single>)+v360 @ X0_v21*4]);\n\tv349[v233 @ X22_v6 (System.Int32)] = v630;\n\tv184 = v360 << 3;\n\tv633 = v400.positionsPrev + v184;\n\t// 190 MakeStruct v142 @ AGG100D5BC_0_v5 (Unity.Mathematics.float2), typeof(Unity.Mathematics.float2), [v633 @ X8_v21], [v633 @ X8_v21+4]\n\tv208 = Unity.Mathematics.float2::op_Implicit(v142);\n\tv638 = v233 << 3;\n\tv639 = this.positions + v638;\n\tv642 = *([v639 @ X8_v23+20]) - v208;\n\tv220 = v642 * v643;\n\tv209 = v208 + v220;\n\tv185 = v233 << 3;\n\tv644 = this.interpPositions + v185;\n\t*([v644 @ X8_v24+20]) = v209;\n\tv402 = this.computeIds;\n\tv353 = this.compute;\n\tv364 = System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>::get_Item(v353.idToIndex, v402[v233 @ X22_v6 (System.Int32)]);\n\tv403 = this.compute;\n\tv649 = v233 << 3;\n\tv650 = this.interpPositions + v649;\n\tv187 = v364 << 3;\n\tv651 = v403.positions + v187;\n\t*([v651 @ X10_v10+20]) = *([v650 @ X9_v14+20]);\n\tv195 = this.scales;\n\tv404 = v403.scales;\n\tv404[v364 @ X0_v25 (System.Int32)] = v195[v233 @ X22_v6 (System.Int32)];\n\tv233 = v233 + 1;\n\tv236 = v236 + 8;\n\tv444 = v233 < this.activeCount;\n\tif (v444) goto L_006C;\nL_0159:\n\tFluidRendererBase::OnPreComputeUpdate(this);\n\tv365 = UnityEngine.Camera::get_main();\n\t// 354 MakeStruct v124 @ AGG100D6F0_1_v3 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), this.position (UnityEngine.Vector2), this.position.y (System.Single), 0\n\tv212 = UnityEngine.Camera::WorldToViewportPoint(v365, v124);\n\tv366 = UnityEngine.Camera::get_main();\n\t// 369 MakeStruct v115 @ AGG100D718_1_v3 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), this.min (UnityEngine.Vector2), this.min.y (System.Single), 0\n\tv213 = UnityEngine.Camera::WorldToViewportPoint(v366, v115);\n\tv367 = UnityEngine.Camera::get_main();\n\t// 383 MakeStruct v108 @ AGG100D73C_1_v3 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), this.max (UnityEngine.Vector2), this.max.y (System.Single), 0\n\tv214 = UnityEngine.Camera::WorldToViewportPoint(v367, v108);\n\tUnityEngine.Renderer::GetPropertyBlock(this.mr, this._propBlock);\n\tv625 = \"Writing object reference to Id '{0}' for {1}.\";\n\t// 406 MakeStruct v98 @ AGG100D784_2_v3 (UnityEngine.Vector4), typeof(UnityEngine.Vector4), v212 @ V0_v6 (UnityEngine.Vector3), v212.y (System.Single), v212.z (System.Single), 0\n\tUnityEngine.MaterialPropertyBlock::SetVector(this._propBlock, *([v625 @ X8_v7 (System.String)+8B8]), v98);\n\tv627 = \"Writing object reference to Id '{0}' for {1}.\";\n\t// 413 NotImplemented \"Instruction FABD not yet implemented.\"\n\t// 414 NotImplemented \"Instruction FABD not yet implemented.\"\n\t// 419 MakeStruct v95 @ AGG100D7B0_2_v3 (UnityEngine.Vector4), typeof(UnityEngine.Vector4), v212 @ V0_v6 (UnityEngine.Vector3), v212.y (System.Single), 0, 0\n\tUnityEngine.MaterialPropertyBlock::SetVector(this._propBlock, *([v627 @ X8_v9 (System.String)+8B0]), v95);\n\tUnityEngine.Renderer::SetPropertyBlock(this.mr, this._propBlock);\n\treturn;\n\tv413 = new System.NullReferenceException();\n\tthrow System.IndexOutOfRangeException;\n\treturn;\n// 344 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public override void OnPreComputeUpdate()
	{
		float time = global::UnityEngine.Time.time;
		FluidSolver fluidSolver = solver;
		if (activeCount >= 1)
		{
			float t = global::UnityEngine.Mathf.Clamp01((time - fluidSolver.lastStepWallTime) / fixedDeltaTime);
			for (int i = 0; i < activeCount; i++)
			{
				if (!fluidSolver.idToIndex.TryGetValue(solverIds[i], out int solverIndex))
				{
					continue;
				}
				global::Unity.Mathematics.float2 currentPos = fluidSolver.positions[solverIndex];
				positions[i] = currentPos;
				scales[i] = particleSize * fluidSolver.scales[solverIndex];
				global::Unity.Mathematics.float2 prevPos = fluidSolver.positionsPrev[solverIndex];
				global::Unity.Mathematics.float2 delta = currentPos - prevPos;
				interpPositions[i] = prevPos + delta * t;
				if (!compute.idToIndex.TryGetValue(computeIds[i], out int computeIndex))
				{
					continue;
				}
				compute.positions[computeIndex] = interpPositions[i];
				compute.scales[computeIndex] = scales[i];
			}
		}
		base.OnPreComputeUpdate();
		global::UnityEngine.Camera main = global::UnityEngine.Camera.main;
		global::UnityEngine.Vector3 vector3 = default(global::UnityEngine.Vector3);
		vector3.x = position.x;
		vector3.y = position.y;
		vector3.z = 0f;
		global::UnityEngine.Vector3 vector4 = main.WorldToViewportPoint(vector3);
		global::UnityEngine.Camera main2 = global::UnityEngine.Camera.main;
		global::UnityEngine.Vector3 vector5 = default(global::UnityEngine.Vector3);
		vector5.x = min.x;
		vector5.y = min.y;
		vector5.z = 0f;
		global::UnityEngine.Vector3 vector6 = main2.WorldToViewportPoint(vector5);
		global::UnityEngine.Camera main3 = global::UnityEngine.Camera.main;
		global::UnityEngine.Vector3 vector7 = default(global::UnityEngine.Vector3);
		vector7.x = max.x;
		vector7.y = max.y;
		vector7.z = 0f;
		global::UnityEngine.Vector3 vector8 = main3.WorldToViewportPoint(vector7);
		mr.GetPropertyBlock(_propBlock);
		global::UnityEngine.Vector4 value = default(global::UnityEngine.Vector4);
		value.x = vector4.x;
		value.y = vector4.y;
		value.z = vector4.z;
		value.w = 0f;
		_propBlock.SetVector("_ViewportPos", value);
		global::UnityEngine.Vector4 value2 = default(global::UnityEngine.Vector4);
		value2.x = global::UnityEngine.Mathf.Abs(vector8.x - vector6.x);
		value2.y = global::UnityEngine.Mathf.Abs(vector8.y - vector6.y);
		value2.z = 0f;
		value2.w = 0f;
		_propBlock.SetVector("_ViewportSize", value2);
		mr.SetPropertyBlock(_propBlock);
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000315")]
	[global::Cpp2ILInjected.Address(RVA = "0x100D7F8", Offset = "0x100D7F8", Length = "0x14")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tthis.particleSize = 0.8f;\n\tFluidRendererBase::.ctor(this);\n\treturn;\n// 3 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public Honey()
	{
		particleSize = 0.8f;
	}
}
