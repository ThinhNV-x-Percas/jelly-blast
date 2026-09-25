[global::Cpp2ILInjected.Token(Token = "0x2000055")]
public class FluidCollectDisplay : FluidRendererBase
{
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x2000056")]
	private sealed class _003C_003Ec__DisplayClass21_0
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000149")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public FluidCollectDisplay _003C_003E4__this;

		[global::Cpp2ILInjected.Token(Token = "0x400014A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public int type;

		[global::Cpp2ILInjected.Token(Token = "0x60001D2")]
		[global::Cpp2ILInjected.Address(RVA = "0xFEF310", Offset = "0xFEF310", Length = "0x8")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tSystem.Object::.ctor(this);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public _003C_003Ec__DisplayClass21_0()
		{
		}

		internal void _003CAddParticle_003Eb__0(ParticleInitData ctx)
		{
			FluidCollectDisplay fluidCollectDisplay = _003C_003E4__this;
			FluidCompute compute = fluidCollectDisplay.compute;
			float[] particleTypes = compute.particleTypes;
			particleTypes[ctx.Index] = type;
			float[] isRounded = compute.isRounded;
			isRounded[ctx.Index] = 0f;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x400013B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
	public float particleSize;

	[global::Cpp2ILInjected.Token(Token = "0x400013C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	private CollectParticleData[] particles;

	[global::Cpp2ILInjected.Token(Token = "0x400013D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public float damping;

	[global::Cpp2ILInjected.Token(Token = "0x400013E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
	public float maxStartSpeed;

	[global::Cpp2ILInjected.Token(Token = "0x400013F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public float collectForce;

	[global::Cpp2ILInjected.Token(Token = "0x4000140")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x84")]
	public float minApplyForceDuration;

	[global::Cpp2ILInjected.Token(Token = "0x4000141")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public float maxApplyForceDuration;

	[global::Cpp2ILInjected.Token(Token = "0x4000142")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x8C")]
	public float explodeDuration;

	[global::Cpp2ILInjected.Token(Token = "0x4000143")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public global::UnityEngine.AnimationCurve scaleAnimationCurve;

	[global::Cpp2ILInjected.Token(Token = "0x4000144")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public global::UnityEngine.AnimationCurve innerRadiusAnimationCurve;

	[global::Cpp2ILInjected.Token(Token = "0x4000145")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public float minExplodeDuration;

	[global::Cpp2ILInjected.Token(Token = "0x4000146")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA4")]
	public float maxExplodeDuration;

	[global::Cpp2ILInjected.Token(Token = "0x4000147")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public int fluidType;

	[global::Cpp2ILInjected.Token(Token = "0x4000148")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	protected global::UnityEngine.MaterialPropertyBlock _propBlock;

	[global::Cpp2ILInjected.Token(Token = "0x60001C8")]
	[global::Cpp2ILInjected.Address(RVA = "0xFEE510", Offset = "0xFEE510", Length = "0x7C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = CollectParticleData[];\n\tgoto L_0018;\n\tv23 = CollectParticleData[];\n\tv24 = v23 + 0;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv43 = 1;\n\t*([302A9A1]) = v43;\nL_0018:\n\tv46 = \"SzArrayNew\"(*([v18 @ X20_v1 (Il2CppClass<CollectParticleData[]>)]), this.maxParticles, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv49 = this + 0x70;\n\tthis.particles = v46;\n\tv50 = 0xF3F1B4(v49, v46, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tFluidCollectDisplay::SetFluidType(this, this.fluidType);\n\tFluidRendererBase::Init(this);\n\treturn;\n// 30 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public override void Init()
	{
		particles = new CollectParticleData[maxParticles];
		SetFluidType(fluidType);
		base.Init();
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001C9")]
	[global::Cpp2ILInjected.Address(RVA = "0xFEE58C", Offset = "0xFEE58C", Length = "0xE8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0018;\n\tv23 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv24 = v23 + 0x900;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, value, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv49 = \"Writing object reference to Id '{0}' for {1}.\";\n\tv50 = v49 + 0x9E0;\n\tv41 = \"il2cpp_codegen_initialize_runtime_metadata\"(v50, value, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv43 = 1;\n\t*([302A9A2]) = v43;\nL_0018:\n\tthis.fluidType = value;\n\tv44 = value + 1;\n\tv46 = v44 == 0;\n\tif (v46) goto L_0050;\n\tv51 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv54 = new *([v51 @ X8_v3 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+900])();\n\tUnityEngine.MaterialPropertyBlock::.ctor(v54);\n\tv91 = this + 0xB0;\n\tthis._propBlock = v54;\n\tv97 = 0xF3F1B4(v91, v54, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tUnityEngine.Renderer::GetPropertyBlock(this.mr, this._propBlock);\n\tv107 = \"Writing object reference to Id '{0}' for {1}.\";\n\tUnityEngine.MaterialPropertyBlock::SetInt(this._propBlock, *([v107 @ X8_v6 (System.String)+9E0]), this.fluidType);\n\tUnityEngine.Renderer::SetPropertyBlock(this.mr, this._propBlock);\n\treturn;\nL_0050:\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 56 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void SetFluidType(int value)
	{
		fluidType = value;
		if (value != -1)
		{
			_propBlock = new global::UnityEngine.MaterialPropertyBlock();
			mr.GetPropertyBlock(_propBlock);
			_propBlock.SetInt("_FluidType", fluidType);
			mr.SetPropertyBlock(_propBlock);
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001CA")]
	[global::Cpp2ILInjected.Address(RVA = "0xFEE674", Offset = "0xFEE674", Length = "0x37C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv184 = this.activeCount;\n\tv43 = this.activeCount < 1;\n\tv49 = this.activeCount - 1;\n\tif (v43) goto L_01C2;\n\tv174 = v49 + 4;\n\tv53 = v49 * 0x48;\n\tv172 = v53 + 0x34;\n\tv56 = System.Xml.ValidateNames;\n\tgoto L_003E;\nL_002E:\n\tv184 = v184 - 1;\n\tv174 = v174 - 1;\n\tv172 = v172 - 0x48;\n\tv103 = v184 <= 0;\n\tif (v103) goto L_01C2;\nL_003E:\n\tv564 = this.particles;\n\tv95 = v174 - 4;\n\tv462 = this.particles + v172;\n\tv404 = *([v462 @ X8_v8-14]) == 2;\n\tif (v404) goto L_002E;\n\tv346 = this.positions;\n\tv337 = this.particles + v172;\n\t*([v337 @ X9_v7-10]) = *([v346 @ X8_v10 (UnityEngine.Vector2[])+v174 @ X24_v4 (System.Int32)*8]);\n\tgoto L_007F;\n\tv554 = v57;\n\tv299 = \"il2cpp_codegen_initialize_runtime_metadata\"(v554, v164, v451, v452, v453, v454, v455, v456, v307, v163, v162, v457, v458, v459, v460, v461);\n\t*([2DD4424]) = v58;\n\tv327 = v50.particles;\nL_007F:\n\tv556 = this.particles + v172;\n\tv472 = *([v556 @ X8_v13-14]) == 0;\n\tif (v472) goto L_0093;\n\tv557 = *([v56 @ X20_v3 (Il2CppClass<System.Xml.ValidateNames>)+98]);\n\tv558 = *([v557 @ X8_v40+B8]);\n\tv293 = *([v558 @ X8_v41]);\n\tv559 = v95 < v564.Length;\n\tv517 = ~v559;\n\tv473 = ~v517;\n\tif (v473) goto L_0128;\n\tgoto L_01C3;\nL_0093:\n\tv348 = *([v556 @ X8_v13+2C]);\n\t*([v348 @ X8_v21+18])(v470, *([v348 @ X8_v21+40]), *([v348 @ X8_v21+28]), v451, v452, v453, v454, v455, v456, *([v346 @ X8_v10 (UnityEngine.Vector2[])+v174 @ X24_v4 (System.Int32)*8]), v286, v282, v457, v458, v459, v460, v461);\n\tv571 = this.particles + v172;\n\t*([v571 @ X8_v23+8]) = *([v346 @ X8_v10 (UnityEngine.Vector2[])+v174 @ X24_v4 (System.Int32)*8]);\n\t*([v571 @ X8_v23+C]) = v286;\n\tv308 = UnityEngine.Time::get_time();\n\tv353 = this.particles + v172;\n\tv579 = v308 - *([v353 @ X8_v25]);\n\tv312 = v579 / *([v353 @ X8_v25+4]);\n\tv582 = v312 - 1f;\n\tv583 = v582 < 0;\n\tv584 = v582 == 0;\n\tv585 = v312 ^ 1f;\n\tv586 = v312 ^ v582;\n\tv587 = v585 & v586;\n\tv588 = v587 < 0;\n\tv589 = v583 == v588;\n\tv280 = ~v584;\n\tv334 = v589 & v280;\n\tv590 = ~v334;\n\tif (v590) goto L_FFFFFFFF;\n\tgoto L_00D8;\nL_00D8:\n\tv277 = v312 >= 0;\n\tif (v277) goto L_FFFFFFFF;\n\tgoto L_00DE;\nL_00DE:\n\tv344 = this.positions;\n\tv605 = *([2DD4421]) == 0;\n\tif (v605) goto L_01A7;\n\tgoto L_00F7;\nL_00F7:\n\tv622 = *([v353 @ X8_v25+8]) - *([v344 @ X9_v18 (UnityEngine.Vector2[])+v174 @ X24_v4 (System.Int32)*8]);\n\tv623 = v622 * v622;\n\t// 249 NotImplemented \"Instruction FADDP not yet implemented.\"\n\tv288 = UnityEngine.Mathf::Sqrt(v623);\n\tv335 = v288 <= 0x3727C5AC;\n\tif (v335) goto L_0111;\n\t// 267 NotImplemented \"Instruction DUP not yet implemented.\"\n\tv313 = v622 / v288;\n\tgoto L_0118;\nL_0111:\n\tgoto L_0115;\n\tv647 = v57;\n\tv648 = \"il2cpp_codegen_initialize_runtime_metadata\"(v647, v290, v451, v452, v453, v454, v455, v456, v622, v288, v284, v457, v458, v459, v460, v461);\n\t*([2DD4424]) = v58;\nL_0115:\n\tv649 = *([v56 @ X20_v3 (Il2CppClass<System.Xml.ValidateNames>)+98]);\n\tv646 = *([v649 @ X8_v37+B8]);\n\tv313 = *([v646 @ X8_v38]);\nL_0118:\n\tv564 = this.particles;\n\tv286 = this.collectForce * v296;\n\tv293 = v313 * v650;\nL_0128:\n\tv329 = v564 + v172;\n\tv566 = UnityEngine.Time::get_fixedDeltaTime();\n\tv569 = v293 * v570;\n\tv309 = *([v329 @ X28_v9-8]) + v569;\n\t*([v329 @ X28_v9-8]) = v309;\n\tv573 = this.particles + v172;\n\tv269 = *([v573 @ X28_v10-8]) * v570;\n\tv575 = UnityEngine.Time::get_fixedDeltaTime();\n\tv577 = v269 * v570;\n\tv310 = *([v573 @ X28_v10-8]) - v577;\n\t*([v573 @ X28_v10-8]) = v310;\n\tv330 = this.positions;\n\tv598 = this.particles + v172;\n\tv599 = UnityEngine.Time::get_fixedDeltaTime();\n\tv600 = *([v598 @ X8_v18-8]) * v570;\n\tv311 = *([v330 @ X28_v11 (UnityEngine.Vector2[])+v174 @ X24_v4 (System.Int32)*8]) + v600;\n\t*([v330 @ X28_v11 (UnityEngine.Vector2[])+v174 @ X24_v4 (System.Int32)*8]) = v311;\n\tv606 = this.particles + v172;\n\tv607 = *([v606 @ X9_v13-14]) == 0;\n\tv527 = ~v607;\n\tif (v527) goto L_002E;\n\tv343 = this.positions;\n\tv531 = this.particles + v172;\n\tv282 = *([v531 @ X8_v20+10]);\n\tv635 = *([v343 @ X9_v15 (UnityEngine.Vector2[])+v174 @ X24_v4 (System.Int32)*8]) - *([v531 @ X8_v20+8]);\n\tv286 = *([v531 @ X8_v20+8]) - *([v531 @ X8_v20+10]);\n\tv526 = v635 * v286;\n\t// 402 NotImplemented \"Instruction FADDP not yet implemented.\"\n\tv529 = v526 <= 0;\n\tif (v529) goto L_002E;\n\tFluidCollectDisplay::RemoveParticle(this, v95);\n\tgoto L_002E;\nL_01A7:\n\t*([2DD4421]) = 1;\n\tgoto L_00F7;\n\tv615 = \"il2cpp_codegen_runtime_class_init\"(v624, v290, v451, v452, v453, v454, v455, v456, v312, v287, v283, v457, v458, v459, v460, v461);\n\tgoto L_00F7;\nL_01C2:\n\treturn;\nL_01C3:\n\tv298 = new System.IndexOutOfRangeException();\n\tthrow System.NullReferenceException;\n// 329 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void FixedUpdate()
	{
		float fixedDeltaTime = global::UnityEngine.Time.fixedDeltaTime;
		for (int i = activeCount - 1; i >= 0; i--)
		{
			if (particles[i].mode == global::CollectParticleMode.Shrink)
			{
				continue;
			}
			particles[i].prevPos = positions[i];
			float force = 0f;
			global::UnityEngine.Vector2 dir = global::UnityEngine.Vector2.zero;
			if (particles[i].mode == global::CollectParticleMode.Collect)
			{
				if (particles[i].getTargetPos != null)
				{
					particles[i].targetPos = particles[i].getTargetPos();
				}
				float t = global::UnityEngine.Mathf.Clamp01((global::UnityEngine.Time.time - particles[i].startTime) / particles[i].applyForceDuration);
				global::UnityEngine.Vector2 toTarget = particles[i].targetPos - positions[i];
				float dist = toTarget.magnitude;
				dir = (dist > 1E-05f) ? (toTarget / dist) : global::UnityEngine.Vector2.zero;
				force = collectForce * t;
			}
			particles[i].vel += dir * force * fixedDeltaTime;
			particles[i].vel -= particles[i].vel * damping * fixedDeltaTime;
			positions[i] += particles[i].vel * fixedDeltaTime;
			if (particles[i].mode != global::CollectParticleMode.Collect)
			{
				continue;
			}
			global::UnityEngine.Vector2 toStart = particles[i].targetPos - particles[i].startPos;
			global::UnityEngine.Vector2 fromTarget = positions[i] - particles[i].targetPos;
			if (global::UnityEngine.Vector2.Dot(fromTarget, toStart) > 0f)
			{
				RemoveParticle(i);
			}
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001CB")]
	[global::Cpp2ILInjected.Address(RVA = "0xFEEB54", Offset = "0xFEEB54", Length = "0x50C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0021;\n\tv45 = Il2CppMethodInfo;\n\tv46 = v45 + 0x278;\n\tv47 = \"il2cpp_codegen_initialize_runtime_metadata\"(v46, methodInfo, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62);\n\tv65 = 1;\n\t*([302A9A3]) = v65;\nL_0021:\n\tv67 = UnityEngine.Time::get_time();\n\tv70 = UnityEngine.Time::get_fixedTime();\n\tv73 = UnityEngine.Time::get_fixedDeltaTime();\n\tv315 = this.activeCount;\n\tv78 = this.activeCount < 1;\n\tv328 = this.activeCount - 1;\n\tif (v78) goto L_02CB;\n\tv85 = Il2CppMethodInfo;\n\tv87 = v67 - v70;\n\tv88 = v87 / v73;\n\tv92 = v88 - 1f;\n\tv93 = v92 < 0;\n\tv94 = v92 == 0;\n\tv95 = v88 ^ 1f;\n\tv96 = v88 ^ v92;\n\tv97 = v95 & v96;\n\tv98 = v97 < 0;\n\tv99 = v93 == v98;\n\tv100 = ~v94;\n\tv101 = v99 & v100;\n\tv102 = ~v101;\n\tif (v102) goto L_0055;\n\tgoto L_0055;\nL_0055:\n\tv254 = v88 >= 0;\n\tif (v254) goto L_005D;\n\tgoto L_005D;\nL_005D:\n\tv335 = v328 * 0x48;\n\tv286 = v335 + 0x34;\n\tgoto L_007A;\nL_0069:\n\tFluidCollectDisplay::RemoveParticle(this, v328);\n\tv315 = v315 - 1;\n\tv328 = v328 - 1;\n\tv286 = v286 - 0x48;\n\tv171 = v315 <= 0;\n\tif (v171) goto L_02CB;\nL_007A:\n\tv697 = this.particles;\n\tv704 = this.particles + v286;\n\tv550 = *([v704 @ X9_v6-14]) == 2;\n\tif (v550) goto L_0145;\n\tv438 = *([v704 @ X9_v6-14]) != 1;\n\tif (v438) goto L_012C;\n\tv631 = UnityEngine.Time::get_time();\n\tv818 = this.particles + v286;\n\tv446 = *([v818 @ X8_v28]) + *([v818 @ X8_v28+1C]);\n\tv439 = v631 >= v446;\n\tif (v439) goto L_0069;\n\tv632 = UnityEngine.Time::get_time();\n\tv690 = this.particles + v286;\n\tv848 = v632 - *([v690 @ X8_v30]);\n\tv645 = v848 / *([v690 @ X8_v30+1C]);\n\tv398 = this.scales;\n\tv633 = UnityEngine.AnimationCurve::Evaluate(this.scaleAnimationCurve, v645);\n\tv634 = v633 * this.particleSize;\n\tv398[v328 @ X20_v5 (System.Int32)] = v634;\n\tv635 = UnityEngine.AnimationCurve::Evaluate(this.innerRadiusAnimationCurve, v645);\n\tv873 = this.particles + v286;\n\t*([v873 @ X8_v34+18]) = v635;\n\tv697 = this.particles;\nL_012C:\n\tv707 = v697 + v286;\n\tv836 = v328 << 3;\n\tv837 = this.positions + v836;\n\tv839 = *([v837 @ X10_v17+20]) - *([v707 @ X12_v7-10]);\n\tv720 = v839 * v840;\n\tv794 = *([v707 @ X12_v7-10]) + v720;\n\tv715 = v328 << 3;\n\tv711 = this.interpPositions + v715;\n\t*([v711 @ X10_v18+20]) = v794;\n\tv841 = v328 < v697.Length;\n\tv787 = ~v841;\n\tv719 = ~v787;\n\tif (v719) goto L_01E5;\n\tgoto L_02CE;\nL_0145:\n\tv637 = UnityEngine.Time::get_time();\n\tv694 = this.particles;\n\tv450 = *([v694 @ X8_v20 (CollectParticleData[])+v286 @ X24_v4 (System.Int32)]) + 0x3E4CCCCD;\n\tv441 = v637 >= v450;\n\tif (v441) goto L_0069;\n\tv638 = UnityEngine.Time::get_time();\n\tv415 = this.particles + v286;\n\tv695 = *([v415 @ X9_v21+2C]);\n\t*([v695 @ X8_v22+18])(v656, *([v695 @ X8_v22+40]), *([v695 @ X8_v22+28]), *([v85 @ X23_v3 (Il2CppMethodInfo)+278]), v50, v51, v52, v53, v54, v638, v450, 0x3E4CCCCD, v123, v59, v60, v61, v62);\n\tv851 = this.particles + v286;\n\t*([v851 @ X8_v24+8]) = v638;\n\t*([v851 @ X8_v24+C]) = v450;\n\tv697 = this.particles;\n\tv854 = v638 - *([v415 @ X9_v21]);\n\tv856 = v854 / 0x3E4CCCCD;\n\tv639 = v856 * v856;\n\tv607 = v639 - 1f;\n\tv585 = v607 < 0;\n\tv563 = v607 == 0;\n\tv541 = v639 ^ 1f;\n\tv519 = v639 ^ v607;\n\tv497 = v541 & v519;\n\tv475 = v497 < 0;\n\tv858 = v585 == v475;\n\tv434 = ~v563;\n\tv442 = v858 & v434;\n\tv431 = ~v442;\n\tif (v431) goto L_01BC;\n\tgoto L_01BC;\nL_01BC:\n\tv378 = v697 + v286;\n\tv123 = *([v378 @ X11_v9+8]) - *([v378 @ X11_v9+10]);\n\tv870 = v123 * v871;\n\tv451 = *([v378 @ X11_v9+10]) + v870;\n\tv392 = v328 << 3;\n\tv872 = this.interpPositions + v392;\n\t*([v872 @ X10_v13+20]) = v451;\n\tv383 = this.scales;\n\tv876 = v639 * 0xBDCCCCCD;\n\tv877 = v876 + 1f;\n\tv795 = v877 * this.particleSize;\n\tv383[v328 @ X20_v5 (System.Int32)] = v795;\nL_01E5:\n\tv418 = this.compute;\n\tv850 = v697 + v286;\n\tv659 = System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>::get_Item(v418.idToIndex, *([v850 @ X8_v12+20]));\n\tv698 = this.compute;\n\tv866 = v328 << 3;\n\tv867 = this.interpPositions + v866;\n\tv394 = v659 << 3;\n\tv868 = v698.positions + v394;\n\t*([v868 @ X9_v12+20]) = *([v867 @ X9_v11+20]);\n\tv386 = v698.innerRadii;\n\tv880 = this.particles + v286;\n\tv386[v659 @ X0_v14 (System.Int32)] = *([v880 @ X9_v14+18]);\n\tv421 = this.scales;\n\tv699 = v698.scales;\n\tv699[v659 @ X0_v14 (System.Int32)] = v421[v328 @ X20_v5 (System.Int32)];\n\tv643 = UnityEngine.Time::get_time();\n\tv700 = this.particles;\n\tv889 = v643 - *([v700 @ X8_v16 (CollectParticleData[])+v286 @ X24_v4 (System.Int32)]);\n\tv891 = v889 / 0xBDCCCCCD;\n\tv892 = v891 + 1f;\n\tv173 = v892 + v892;\n\tv896 = v892 - 1f;\n\tv897 = v896 < 0;\n\tv898 = v896 == 0;\n\tv899 = v892 ^ 1f;\n\tv900 = v892 ^ v896;\n\tv901 = v899 & v900;\n\tv902 = v901 < 0;\n\tv903 = v897 == v902;\n\tv436 = ~v898;\n\tv444 = v903 & v436;\n\tv904 = ~v444;\n\tif (v904) goto L_028A;\n\tgoto L_028A;\nL_028A:\n\tv161 = v892 >= 0;\n\tif (v161) goto L_FFFFFFFF;\n\tgoto L_0290;\nL_0290:\n\tv702 = this.compute;\n\tv701 = v702.emissionColors;\n\tv141 = v659 << 4;\n\tv217 = v702.emissionColors + v141;\n\t*([v217 @ X8_v19+20]) = 5.263544247E-315d;\n\tv701[v659 @ X0_v14 (System.Int32)].z = 0f;\n\tv701[v659 @ X0_v14 (System.Int32)].w = v205;\n\tv315 = v315 - 1;\n\tv328 = v328 - 1;\n\tv286 = v286 - 0x48;\n\tv169 = v315 > 0;\n\tif (v169) goto L_007A;\nL_02CB:\n\tFluidRendererBase::OnPreComputeUpdate(this);\n\treturn;\n\tv703 = new System.NullReferenceException();\nL_02CE:\n\tthrow System.IndexOutOfRangeException;\n// 548 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public override void OnPreComputeUpdate()
	{
		float time = global::UnityEngine.Time.time;
		float t = global::UnityEngine.Mathf.Clamp01((time - global::UnityEngine.Time.fixedTime) / global::UnityEngine.Time.fixedDeltaTime);
		for (int i = activeCount - 1; i >= 0; i--)
		{
			if (particles[i].mode == global::CollectParticleMode.Shrink)
			{
				float deadline = particles[i].startTime + 0.2f;
				if (time >= deadline)
				{
					RemoveParticle(i);
					continue;
				}
				if (particles[i].getTargetPos != null)
				{
					particles[i].targetPos = particles[i].getTargetPos();
				}
				float shrinkT = (time - particles[i].startTime) / 0.2f;
				float shrinkT2 = shrinkT * shrinkT;
				interpPositions[i] = global::UnityEngine.Vector2.Lerp(particles[i].startPos, particles[i].targetPos, shrinkT2);
				scales[i] = (1f - shrinkT2 * 0.1f) * particleSize;
			}
			else if (particles[i].mode == global::CollectParticleMode.Explode)
			{
				float deadline2 = particles[i].startTime + particles[i].explodeDuration;
				if (time >= deadline2)
				{
					RemoveParticle(i);
					continue;
				}
				float explodeT = (time - particles[i].startTime) / particles[i].explodeDuration;
				scales[i] = scaleAnimationCurve.Evaluate(explodeT) * particleSize;
				particles[i].innerRadius = innerRadiusAnimationCurve.Evaluate(explodeT);
				interpPositions[i] = particles[i].prevPos + (positions[i] - particles[i].prevPos) * t;
			}
			else
			{
				interpPositions[i] = particles[i].prevPos + (positions[i] - particles[i].prevPos) * t;
			}
			if (!compute.idToIndex.TryGetValue(particles[i].particleId, out int computeIndex))
			{
				continue;
			}
			compute.positions[computeIndex] = interpPositions[i];
			compute.innerRadii[computeIndex] = particles[i].innerRadius;
			compute.scales[computeIndex] = scales[i];
			float flashAlpha = global::UnityEngine.Mathf.Clamp01(1f - (time - particles[i].startTime) / 0.1f);
			compute.emissionColors[computeIndex].z = 0f;
			compute.emissionColors[computeIndex].w = flashAlpha;
		}
		base.OnPreComputeUpdate();
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001CC")]
	[global::Cpp2ILInjected.Address(RVA = "0xFEC1F4", Offset = "0xFEC1F4", Length = "0x3C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv22 = this.activeCount >= this.maxParticles;\n\tif (v22) goto L_0030;\n\tv33 = FluidCollectDisplay::AddParticle(this, position, vel, type, 0, 0f, getTargetPos, onComplete);\nL_0030:\n\treturn;\n// 45 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void AddCollectParticle(global::UnityEngine.Vector2 position, global::UnityEngine.Vector2 vel, int type, global::System.Func<global::UnityEngine.Vector2> getTargetPos, global::System.Action onComplete = null)
	{
		if (activeCount < maxParticles)
		{
			CollectParticleData collectParticleData = AddParticle(position, vel, type, default(CollectParticleMode), 0f, getTargetPos, onComplete);
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001CD")]
	[global::Cpp2ILInjected.Address(RVA = "0xFEC230", Offset = "0xFEC230", Length = "0x90")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv34 = this.activeCount >= this.maxParticles;\n\tif (v34) goto L_004C;\n\tv45 = UnityEngine.Random::Range(this.minExplodeDuration, this.maxExplodeDuration);\n\tv123 = FluidCollectDisplay::AddParticle(this, position, vel, type, 1, v45, 0, 0);\nL_004C:\n\treturn;\n// 72 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void AddExplodeParticle(global::UnityEngine.Vector2 position, global::UnityEngine.Vector2 vel, int type)
	{
		if (activeCount < maxParticles)
		{
			float num = global::UnityEngine.Random.Range(minExplodeDuration, maxExplodeDuration);
			CollectParticleData collectParticleData = AddParticle(position, vel, type, CollectParticleMode.Explode, num);
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001CE")]
	[global::Cpp2ILInjected.Address(RVA = "0xFEB948", Offset = "0xFEB948", Length = "0x3C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv22 = this.activeCount >= this.maxParticles;\n\tif (v22) goto L_0030;\n\tv32 = FluidCollectDisplay::AddParticle(this, position, vel, type, 2, 0f, getTargetPos, 0);\nL_0030:\n\treturn;\n// 45 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void AddShrinkParticle(global::UnityEngine.Vector2 position, global::UnityEngine.Vector2 vel, int type, global::System.Func<global::UnityEngine.Vector2> getTargetPos)
	{
		if (activeCount < maxParticles)
		{
			CollectParticleData collectParticleData = AddParticle(position, vel, type, CollectParticleMode.Shrink, 0f, getTargetPos);
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001CF")]
	[global::Cpp2ILInjected.Address(RVA = "0xFEF060", Offset = "0xFEF060", Length = "0x270")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv58 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tgoto L_0033;\n\tv63 = System.Collections.Generic.NullableComparer`1;\n\tv64 = v63 + 0xD10;\n\tv65 = \"il2cpp_codegen_initialize_runtime_metadata\"(v64, type, mode, getTargetPos, onComplete, methodInfo, v67, v68, position, v0, vel, v2, explodeDuration, v69, v70, v71);\n\tv78 = Il2CppMethodInfo;\n\tv79 = v78 + 0xD28;\n\tv80 = \"il2cpp_codegen_initialize_runtime_metadata\"(v79, type, mode, getTargetPos, onComplete, methodInfo, v67, v68, position, v0, vel, v2, explodeDuration, v69, v70, v71);\n\tv83 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv84 = v83 + 0xB60;\n\tv73 = \"il2cpp_codegen_initialize_runtime_metadata\"(v84, type, mode, getTargetPos, onComplete, methodInfo, v67, v68, position, v0, vel, v2, explodeDuration, v69, v70, v71);\n\tv75 = 1;\n\t*([302A9A4]) = v75;\nL_0033:\n\tv77 = new *([v58 @ X26_v1 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+B60])();\n\tFluidCollectDisplay+<>c__DisplayClass21_0::.ctor(v77);\n\tv87 = v77 + 0x10;\n\tv77.<>4__this = this;\n\tv90 = 0xF3F1B4(v87, this, mode, getTargetPos, onComplete, methodInfo, v67, v68, position, position.y, vel, vel.y, explodeDuration, v69, v70, v71);\n\tv77.type = type;\n\tv173 = this.positions;\n\tv212 = this.activeCount;\n\tv123 = this.activeCount << 3;\n\tv275 = this.positions + v123;\n\t*([v275 @ X9_v4+20]) = position;\n\tv173[v212 @ X8_v5 (System.Int32)].y = position.y;\n\tv174 = this.interpPositions;\n\tv124 = this.activeCount << 3;\n\tv350 = this.interpPositions + v124;\n\t*([v350 @ X9_v6+20]) = position;\n\tv174[v212 @ X8_v5 (System.Int32)].y = position.y;\n\tv175 = this.scales;\n\tv352 = System.Collections.Generic.NullableComparer`1;\n\tv353 = Il2CppMethodInfo;\n\tv175[v212 @ X8_v5 (System.Int32)] = this.particleSize;\n\tv357 = UnityEngine.Random::Range(this.minApplyForceDuration, this.maxApplyForceDuration);\n\tv196 = UnityEngine.Time::get_time();\n\tv361 = &v288 @ stack_-C8_v5 (CollectParticleMode) + 0x38;\n\tv363 = 0xF3F1B4(v361, onComplete, mode, getTargetPos, onComplete, methodInfo, v67, v68, v196, this.maxApplyForceDuration, vel, vel.y, explodeDuration, v69, v70, v71);\n\tv364 = &v288 @ stack_-C8_v5 (CollectParticleMode) + 0x40;\n\tv366 = 0xF3F1B4(v364, getTargetPos, mode, getTargetPos, onComplete, methodInfo, v67, v68, v196, this.maxApplyForceDuration, vel, vel.y, explodeDuration, v69, v70, v71);\n\tv368 = IdGenerator::Next();\n\tv201 = new *([v352 @ X25_v4 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+D10])();\n\tSystem.Action`1<ParticleInitData>::.ctor(v201, v77, *([v353 @ X26_v7 (Il2CppMethodInfo)+D28]));\n\tFluidCompute::AddParticle(this.compute, v368, v201);\n\tv316 = this.activeCount * 0x48;\n\tv371 = this.particles + v316;\n\tv372 = v371 + 0x20;\n\tv374 = 0x274AA04(v372, &v288 @ stack_-C8_v5 (CollectParticleMode), 0x48, 0, onComplete, methodInfo, v67, v68, v196, this.maxApplyForceDuration, vel, vel.y, explodeDuration, v69, v70, v71);\n\tv375 = v371 + 0x58;\n\treturnVal2 = 0xF3F1B4(v375, 0, 0x48, 0, onComplete, methodInfo, v67, v68, v196, this.maxApplyForceDuration, vel, vel.y, explodeDuration, v69, v70, v71);\n\tv377 = this.activeCount + 1;\n\tthis.activeCount = v377;\n\t*([returnBuffer @ X8 (CollectParticleData)+20]) = v379;\n\treturnBuffer.explodeDuration = explodeDuration;\n\treturnBuffer.getTargetPos = getTargetPos;\n\treturnBuffer.mode = v288;\n\t*([returnBuffer @ X8 (CollectParticleData)+10]) = vel.y;\n\treturn returnVal2;\n\tv225 = new System.NullReferenceException();\n\treturnVal1 = new System.IndexOutOfRangeException();\n\treturn returnVal1;\n// 169 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public unsafe CollectParticleData AddParticle(global::UnityEngine.Vector2 position, global::UnityEngine.Vector2 vel, int type, CollectParticleMode mode, float explodeDuration = 1f, global::System.Func<global::UnityEngine.Vector2> getTargetPos = null, global::System.Action onComplete = null)
	{
		FluidCollectDisplay._003C_003Ec__DisplayClass21_0 displayClass = new FluidCollectDisplay._003C_003Ec__DisplayClass21_0();
		displayClass._003C_003E4__this = this;
		displayClass.type = type;
		positions[activeCount] = position;
		interpPositions[activeCount] = position;
		scales[activeCount] = particleSize;
		float applyForceDuration = global::UnityEngine.Random.Range(minApplyForceDuration, maxApplyForceDuration);
		float time = global::UnityEngine.Time.time;
		int id = IdGenerator.Next();
		global::System.Action<ParticleInitData> onInit = new global::System.Action<ParticleInitData>(displayClass._003CAddParticle_003Eb__0);
		compute.AddParticle(id, onInit);
		CollectParticleData collectParticleData = default(CollectParticleData);
		collectParticleData.mode = mode;
		collectParticleData.prevPos = position;
		collectParticleData.vel = vel;
		collectParticleData.startTime = time;
		collectParticleData.applyForceDuration = applyForceDuration;
		collectParticleData.targetPos = position;
		collectParticleData.startPos = position;
		collectParticleData.innerRadius = 0f;
		collectParticleData.explodeDuration = explodeDuration;
		collectParticleData.particleId = id;
		collectParticleData.onComplete = onComplete;
		collectParticleData.getTargetPos = getTargetPos;
		particles[activeCount] = collectParticleData;
		activeCount++;
		return collectParticleData;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001D0")]
	[global::Cpp2ILInjected.Address(RVA = "0xFEE9F0", Offset = "0xFEE9F0", Length = "0x164")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = index & 0x80000000;\n\tv20 = v18 == 0;\n\tv21 = ~v20;\n\tif (v21) goto L_00CB;\n\tv37 = this.activeCount <= index;\n\tif (v37) goto L_00CB;\n\tv233 = this.particles;\n\tv256 = index * 0x48;\n\tv257 = this.particles + v256;\n\tv182 = *([v257 @ X9_v6+58]);\n\tv258 = *([v257 @ X9_v6+58]) == 0;\n\tif (v258) goto L_004D;\n\t*([v182 @ X9_v7+18])(v177, *([v182 @ X9_v7+40]), *([v182 @ X9_v7+28]), methodInfo, v243, v244, v245, v246, v247, v40, v248, v249, v250, v251, v252, v253, v254);\n\tv233 = this.particles;\nL_004D:\n\t;\n\tFluidCompute::RemoveParticle(this.compute, v233[index @ X1 (System.Int32)].particleId);\n\tv46 = this.activeCount - 1;\n\tv213 = v46 == index;\n\tif (v213) goto L_00C1;\n\tv311 = this.particles + 0x20;\n\tv312 = v46 * 0x48;\n\tv313 = v311 + v312;\n\tv314 = index * 0x48;\n\tv162 = v311 + v314;\n\tv316 = 0x274AA04(v162, v313, 0x48, v243, v244, v245, v246, v247, v40, v248, v249, v250, v251, v252, v253, v254);\n\tv317 = v162 + 0x38;\n\tv179 = 0xF3F1B4(v317, 0, 0x48, v243, v244, v245, v246, v247, v40, v248, v249, v250, v251, v252, v253, v254);\n\tv321 = this.positions + 0x20;\n\t*([v321 @ X8_v13+index @ X1 (System.Int32)*8]) = *([v321 @ X8_v13+v46 @ X23_v6 (System.Int32)*8]);\n\tv236 = this.scales;\n\tv236[index @ X1 (System.Int32)] = v236[v46 @ X23_v6 (System.Int32)];\n\tv46 = this.activeCount - 1;\nL_00C1:\n\tthis.activeCount = v46;\nL_00CB:\n\treturn;\n\tv176 = new System.IndexOutOfRangeException();\n\tthrow System.NullReferenceException;\n\treturn;\n// 170 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void RemoveParticle(int index)
	{
		if (index >= 0 && activeCount > index)
		{
			if (particles[index].onComplete != null)
			{
				particles[index].onComplete();
			}
			compute.RemoveParticle(particles[index].particleId);
			int lastIndex = activeCount - 1;
			if (lastIndex != index)
			{
				particles[index] = particles[lastIndex];
				positions[index] = positions[lastIndex];
				scales[index] = scales[lastIndex];
			}
			activeCount = lastIndex;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001D1")]
	[global::Cpp2ILInjected.Address(RVA = "0xFEF2D0", Offset = "0xFEF2D0", Length = "0x40")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tthis.particleSize = 0.2f;\n\tthis.damping = *([2875910]);\n\tthis.maxApplyForceDuration = 3.433228354055018E-06d;\n\tthis.minExplodeDuration = 2.000000473111868d;\n\tthis.fluidType = 0xFFFFFFFF;\n\tFluidRendererBase::.ctor(this);\n\treturn;\n// 10 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public FluidCollectDisplay()
	{
		particleSize = 0.2f;
		damping = 2f;
		maxApplyForceDuration = 1f;
		explodeDuration = 0.4f;
		minExplodeDuration = 1f;
		maxExplodeDuration = 2f;
		fluidType = -1;
	}
}
