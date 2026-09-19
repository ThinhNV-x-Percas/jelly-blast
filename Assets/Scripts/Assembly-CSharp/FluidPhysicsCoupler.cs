[global::UnityEngine.RequireComponent(typeof(FluidSolver))]
[global::Cpp2ILInjected.Token(Token = "0x2000086")]
public class FluidPhysicsCoupler : global::UnityEngine.MonoBehaviour
{
	[global::Cpp2ILInjected.Token(Token = "0x2000087")]
	private enum Shape : byte
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000278")]
		Circle = 0,
		[global::Cpp2ILInjected.Token(Token = "0x4000279")]
		Box = 1
	}

	[global::Cpp2ILInjected.Token(Token = "0x2000088")]
	private struct BodyInfo
	{
		[global::Cpp2ILInjected.Token(Token = "0x400027A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public FluidPhysicsCoupler.Shape shape;

		[global::Cpp2ILInjected.Token(Token = "0x400027B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public global::UnityEngine.Rigidbody2D body;

		[global::Cpp2ILInjected.Token(Token = "0x400027C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public float radiusWS;

		[global::Cpp2ILInjected.Token(Token = "0x400027D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public global::Unity.Mathematics.float2 halfExtentsLS;

		[global::Cpp2ILInjected.Token(Token = "0x400027E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public global::UnityEngine.Vector2 localOffset;
	}

	[global::Cpp2ILInjected.Token(Token = "0x2000089")]
	private struct BodyData
	{
		[global::Cpp2ILInjected.Token(Token = "0x400027F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public FluidPhysicsCoupler.Shape shape;

		[global::Cpp2ILInjected.Token(Token = "0x4000280")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public global::Unity.Mathematics.float2 com;

		[global::Cpp2ILInjected.Token(Token = "0x4000281")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		public global::Unity.Mathematics.float2x2 R;

		[global::Cpp2ILInjected.Token(Token = "0x4000282")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public global::Unity.Mathematics.float2 halfExtents;

		[global::Cpp2ILInjected.Token(Token = "0x4000283")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public float radius;

		[global::Cpp2ILInjected.Token(Token = "0x4000284")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public float invMass;

		[global::Cpp2ILInjected.Token(Token = "0x4000285")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		public float invInertia;

		[global::Cpp2ILInjected.Token(Token = "0x4000286")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public global::Unity.Mathematics.float2 vel;

		[global::Cpp2ILInjected.Token(Token = "0x4000287")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public float angVel;

		[global::Cpp2ILInjected.Token(Token = "0x4000288")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		public global::Unity.Mathematics.float2 offsetWS;

		[global::Cpp2ILInjected.Token(Token = "0x4000289")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		public bool isKinematic;
	}

	[global::Cpp2ILInjected.Token(Token = "0x200008A")]
	private struct ForceBundle
	{
		[global::Cpp2ILInjected.Token(Token = "0x400028A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public int bodyIndex;

		[global::Cpp2ILInjected.Token(Token = "0x400028B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public global::Unity.Mathematics.float2 force;

		[global::Cpp2ILInjected.Token(Token = "0x400028C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		public float torque;
	}

	[global::Unity.Burst.BurstCompile(global::Unity.Burst.FloatPrecision.Low, global::Unity.Burst.FloatMode.Fast, CompileSynchronously = true)]
	[global::Cpp2ILInjected.Token(Token = "0x200008B")]
	internal struct CouplerJob : global::Unity.Jobs.IJobParallelFor
	{
		[global::Unity.Collections.NativeDisableParallelForRestriction]
		[global::Cpp2ILInjected.Token(Token = "0x400028D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> positions;

		[global::Unity.Collections.NativeDisableParallelForRestriction]
		[global::Cpp2ILInjected.Token(Token = "0x400028E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> velocities;

		[global::Unity.Collections.ReadOnly]
		[global::Cpp2ILInjected.Token(Token = "0x400028F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public global::Unity.Collections.NativeArray<FluidPhysicsCoupler.BodyData> bodies;

		[global::Unity.Collections.NativeDisableParallelForRestriction]
		[global::Cpp2ILInjected.Token(Token = "0x4000290")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public global::Unity.Collections.NativeArray<FluidPhysicsCoupler.ForceBundle> result;

		[global::Unity.Collections.ReadOnly]
		[global::Cpp2ILInjected.Token(Token = "0x4000291")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public global::Unity.Collections.NativeArray<bool> isStatic;

		[global::Cpp2ILInjected.Token(Token = "0x4000292")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		public float invFluidMass;

		[global::Cpp2ILInjected.Token(Token = "0x4000293")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		public float restitution;

		[global::Cpp2ILInjected.Token(Token = "0x4000294")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		public float dt;

		[global::Cpp2ILInjected.Token(Token = "0x4000295")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		public float particleRadius;

		[global::Cpp2ILInjected.Token(Token = "0x4000296")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		public float mu;

		[global::Cpp2ILInjected.Token(Token = "0x4000297")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
		public global::Unity.Mathematics.float2 halfBounds;

		[global::Unity.Collections.ReadOnly]
		[global::Cpp2ILInjected.Token(Token = "0x4000298")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		public global::Unity.Collections.NativeArray<global::Unity.Mathematics.float4> sdf;

		[global::Cpp2ILInjected.Token(Token = "0x4000299")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		public global::Unity.Mathematics.int2 sdfRes;

		[global::Cpp2ILInjected.Token(Token = "0x400029A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		public global::Unity.Mathematics.float2 invWorldPerTexel;

		[global::Cpp2ILInjected.Token(Token = "0x400029B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		public global::Unity.Mathematics.float2 sdfCenter;

		[global::Cpp2ILInjected.Token(Token = "0x6000263")]
		[global::Cpp2ILInjected.Address(RVA = "0xFFDC20", Offset = "0xFFDC20", Length = "0xAA4")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv48 = System.Xml.ValidateNames;\n\tgoto L_002D;\n\tv53 = System.Xml.ValidateNames;\n\tv54 = v53 + 0xD40;\n\tv55 = \"il2cpp_codegen_initialize_runtime_metadata\"(v54, p, methodInfo, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69);\n\tv72 = 1;\n\t*([302A9FA]) = v72;\nL_002D:\n\tv81 = v822.isStatic;\n\tv85 = p & 0xFFFFFFFF;\n\tv86 = v85 << 3;\n\tv81 = v822.positions + v86;\n\tv90 = v822.velocities;\n\tv81 = *([v90 @ X8_v6 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v86 @ X9_v1 (System.Int32)]);\n\tv81 = *([v48 @ X22_v1 (Il2CppClass<System.Xml.ValidateNames>)+D40]);\n\tv81 = *([v81 @ X8_v3 (Unity.Collections.NativeArray`1<System.Boolean>)+B8]);\n\tv81 = *([v81 @ X8_v3 (Unity.Collections.NativeArray`1<System.Boolean>)]);\n\tv81 = *([v822 @ X0_v39 (FluidPhysicsCoupler+CouplerJob)+28]);\n\tv109 = *([v822 @ X0_v39 (FluidPhysicsCoupler+CouplerJob)+28]) < 1;\n\tif (v109) goto L_FFFFFFFF;\n\tgoto L_0067;\nL_0056:\n\tv633 = 0xFFE114(v822, v631, v629, v150, v148, v144, 0, v61, v197, v195, v161, v160, v171, v572, v561, v570);\nL_0058:\n\tv213 = v213 + 1;\n\tv215 = v215 + 0x48;\n\tv178 = v213 >= *([v822 @ X0_v39 (FluidPhysicsCoupler+CouplerJob)+28]);\n\tif (v178) goto L_01F0;\nL_0067:\n\tv226 = v822.bodies + v215;\n\tv230 = 0x274AA04(&v228 @ stack_-110_v4, v226, 0x48, v150, v148, v144, 0, v61, v197, v195, v161, v160, v171, v572, v561, v570);\n\tv81 = *([2DD4420]);\n\tv292 = *([2DD4420]) == 0;\n\tif (v292) goto L_017F;\n\tgoto L_0075;\nL_0075:\n\tv437 = v290 * v290;\n\tv438 = 0 * 0;\n\tv439 = v437 + v438;\n\tv519 = UnityEngine.Mathf::Sqrt(v439);\n\tv453 = v519 & 0x7FFFFFFF;\n\tv454 = v453 < 0x7F800000;\n\tv455 = ~v454;\n\tv456 = v453 - 0x7F800000;\n\tv458 = v456 == 0;\n\tv463 = ~v455;\n\tv464 = v463 | v458;\n\tv465 = ~v464;\n\tif (v465) goto L_FFFFFFFF;\n\tv489 = v288 - v519;\n\tv508 = v489 < 0;\n\tv507 = v489 == 0;\n\tv492 = v288 ^ v519;\n\tv493 = v288 ^ v489;\n\tv494 = v492 & v493;\n\tv503 = v494 < 0;\n\tgoto L_0097;\nL_0097:\n\tv511 = v508 == v503;\n\tv512 = ~v507;\n\tv513 = v511 & v512;\n\tv514 = ~v513;\n\tif (v514) goto L_00A1;\n\tgoto L_00A1;\nL_00A1:\n\tv520 = v519 + v822.particleRadius;\n\tv523 = *([v81 @ X8_v3 (Unity.Collections.NativeArray`1<System.Boolean>)]) - v521;\n\tv524 = v576 - v522;\n\tv195 = v523 * v523;\n\tv161 = v524 * v524;\n\tv527 = v195 + v161;\n\tv197 = v520 * v520;\n\tv540 = v527 > v197;\n\tif (v540) goto L_0058;\n\tv542 = v228 == 0;\n\tif (v542) goto L_0187;\n\tv81 = *([2DD4420]);\n\tv655 = *([2DD4420]) == 0;\n\tif (v655) goto L_01D5;\n\tgoto L_00C9;\nL_00C9:\n\tv695 = v521 + v645;\n\tv161 = *([v81 @ X8_v3 (Unity.Collections.NativeArray`1<System.Boolean>)]) - v695;\n\tv160 = *([v81 @ X8_v3 (Unity.Collections.NativeArray`1<System.Boolean>)+4]) - v522;\n\tv697 = v647 * v161;\n\tv698 = v161 * v649;\n\tv699 = v685 * v160;\n\tv700 = v160 * v682;\n\tv561 = v697 + v699;\n\tv197 = v698 + v700;\n\tv701 = v822.particleRadius + v679;\n\tv702 = v822.particleRadius + v676;\n\tv703 = UnityEngine.Mathf::Abs(v561);\n\tv723 = UnityEngine.Mathf::Abs(v197);\n\tv195 = v703 - v701;\n\tv572 = v723 - v702;\n\tv738 = UnityEngine.Mathf::Max(v195, 0f);\n\tv752 = UnityEngine.Mathf::Max(v572, 0f);\n\tv754 = v738 * v738;\n\tv755 = v752 * v752;\n\tv756 = v754 + v755;\n\tv757 = UnityEngine.Mathf::Sqrt(v756);\n\tv642 = v572 & 0x7FFFFFFF;\n\tv783 = v642 < 0x7F800000;\n\tv784 = ~v783;\n\tv785 = v642 - 0x7F800000;\n\tv787 = v785 == 0;\n\tv792 = ~v784;\n\tv793 = v792 | v787;\n\tv794 = ~v793;\n\tif (v794) goto L_FFFFFFFF;\n\tv826 = v195 - v572;\n\tv842 = v826 < 0;\n\tv841 = v826 == 0;\n\tv829 = v195 ^ v572;\n\tv830 = v195 ^ v826;\n\tv831 = v829 & v830;\n\tv837 = v831 < 0;\n\tgoto L_00FF;\nL_00FF:\n\tv845 = v842 == v837;\n\tv558 = ~v841;\n\tv846 = v845 & v558;\n\tv579 = ~v846;\n\tif (v579) goto L_FFFFFFFF;\n\tgoto L_0108;\nL_0108:\n\tv570 = UnityEngine.Mathf::Min(v849, 0f);\n\tv171 = v757 + v570;\n\tv850 = v171 < 0;\n\tv615 = ~v850;\n\tv603 = v171 == 0;\n\tv851 = ~v603;\n\tv583 = v615 & v851;\n\tif (v583) goto L_0058;\n\tv171 = -v171;\n\tv855 = v561 < 0;\n\tv856 = v561 == 0;\n\tv858 = v561 ^ v561;\n\tv859 = v561 & v858;\n\tv860 = v859 < 0;\n\tv861 = v855 == v860;\n\tv862 = ~v856;\n\tv863 = v861 & v862;\n\tv864 = ~v863;\n\tif (v864) goto L_012C;\n\tgoto L_012C;\nL_012C:\n\tv869 = v561 >= 0;\n\tif (v869) goto L_0135;\n\tgoto L_0135;\nL_0135:\n\tv876 = v197 < 0;\n\tv877 = v197 == 0;\n\tv879 = v197 ^ v197;\n\tv880 = v197 & v879;\n\tv881 = v880 < 0;\n\tv882 = v876 == v881;\n\tv883 = ~v877;\n\tv884 = v882 & v883;\n\tv885 = ~v884;\n\tif (v885) goto L_FFFFFFFF;\n\tgoto L_0144;\nL_0144:\n\tv570 = v888 + -1f;\n\tv889 = v197 >= 0;\n\tif (v889) goto L_014D;\n\tgoto L_014D;\nL_014D:\n\tv895 = v195 - v572;\n\tv896 = v895 < 0;\n\tv897 = v895 == 0;\n\tv898 = v195 ^ v572;\n\tv899 = v195 ^ v895;\n\tv900 = v898 & v899;\n\tv901 = v900 < 0;\n\tv902 = v896 == v901;\n\tv903 = ~v897;\n\tv904 = v902 & v903;\n\tv905 = ~v904;\n\tif (v905) goto L_015D;\n\tgoto L_015D;\nL_015D:\n\tv909 = v896 == v901;\n\tv801 = ~v897;\n\tv910 = v909 & v801;\n\tv807 = ~v910;\n\tif (v807) goto L_016A;\n\tgoto L_016A;\nL_016A:\n\tv813 = *([v81 @ X8_v3 (Unity.Collections.NativeArray`1<System.Boolean>)+p @ X1 (System.Int32)]) == 0;\n\tv808 = ~v813;\n\tv915 = v647 * v916;\n\tv917 = v649 * v918;\n\tv197 = v915 + v917;\n\tgoto L_0056;\nL_017F:\n\t*([2DD4420]) = 1;\n\tgoto L_0075;\n\tv430 = \"il2cpp_codegen_runtime_class_init\"(v441, v226, v229, v149, v147, v143, v211, v61, v197, v195, v161, v159, v170, v168, v157, v166);\n\tgoto L_0075;\nL_0187:\n\tv81 = *([2DD4420]);\n\tv657 = *([2DD4420]) == 0;\n\tif (v657) goto L_01E7;\n\tgoto L_018E;\nL_018E:\n\tv195 = UnityEngine.Mathf::Sqrt(v527);\n\tv161 = v288 + v822.particleRadius;\n\tv729 = v195 - 0x358637BD;\n\tv730 = v729 < 0;\n\tv731 = v729 == 0;\n\tv732 = v195 ^ 0x358637BD;\n\tv733 = v195 ^ v729;\n\tv734 = v732 & v733;\n\tv735 = v734 < 0;\n\tv736 = v730 == v735;\n\tv559 = ~v731;\n\tv737 = v736 & v559;\n\tv580 = ~v737;\n\tif (v580) goto L_FFFFFFFF;\n\tv739 = v195 < v161;\n\tv616 = ~v739;\n\tv741 = v195 - v161;\n\tv604 = v741 == 0;\n\tgoto L_01B2;\nL_01B2:\n\tv753 = ~v604;\n\tv584 = v616 & v753;\n\tif (v584) goto L_0058;\n\tv762 = *([v81 @ X8_v3 (Unity.Collections.NativeArray`1<System.Boolean>)+p @ X1 (System.Int32)]) == 0;\n\tv767 = ~v762;\n\tv197 = v523 / v195;\n\tv171 = v161 - v195;\n\tv195 = v524 / v195;\n\tgoto L_0056;\nL_01D5:\n\t*([2DD4420]) = 1;\n\tgoto L_00C9;\n\tv675 = v708;\n\tv674 = v709;\n\tv673 = v710;\n\tv672 = v711;\n\tv689 = \"il2cpp_codegen_runtime_class_init\"(v712, v226, v229, v149, v147, v143, v211, v61, v528, v525, v526, v159, v711, v710, v157, v709);\n\tv684 = v673;\n\tv687 = v672;\n\tv678 = v675;\n\tv681 = v674;\n\tgoto L_00C9;\nL_01E7:\n\t*([2DD4420]) = 1;\n\tgoto L_018E;\n\tv715 = \"il2cpp_codegen_runtime_class_init\"(v721, v226, v229, v149, v147, v143, v211, v61, v528, v525, v526, v159, v170, v168, v157, v166);\n\tgoto L_018E;\nL_01F0:\n\tv285 = *([v81 @ X8_v3 (Unity.Collections.NativeArray`1<System.Boolean>)+p @ X1 (System.Int32)]) == 0;\n\tif (v285) goto L_01FA;\n\tv293 = System.Xml.ValidateNames;\n\tv81 = *([v293 @ X8_v18 (Il2CppClass<System.Xml.ValidateNames>)+D40]);\n\tv375 = *([v81 @ X8_v3 (Unity.Collections.NativeArray`1<System.Boolean>)+B8]);\n\tgoto L_0251;\nL_01FA:\n\tv300 = v822.halfBounds - v822.particleRadius;\n\tv363 = -v300;\n\tv311 = *([v81 @ X8_v3 (Unity.Collections.NativeArray`1<System.Boolean>)]) >= v363;\n\tif (v311) goto L_021B;\n\tv408 = v363 - *([v81 @ X8_v3 (Unity.Collections.NativeArray`1<System.Boolean>)]);\n\tv415 = 0xFFE2E4(v822, 0, &v81 @ X8_v3 (Unity.Collections.NativeArray`1<System.Boolean>), 0, v242, v240, v272, v61, 1f, 0, v408, v247, v252, v251, v246, v250);\n\tgoto L_0228;\nL_021B:\n\tv427 = *([v81 @ X8_v3 (Unity.Collections.NativeArray`1<System.Boolean>)]) <= v300;\n\tif (v427) goto L_FFFFFFFF;\n\tv443 = *([v81 @ X8_v3 (Unity.Collections.NativeArray`1<System.Boolean>)]) - v300;\n\tv450 = 0xFFE2E4(v822, 0, &v81 @ X8_v3 (Unity.Collections.NativeArray`1<System.Boolean>), 0, v242, v240, v272, v61, -1f, 0, v443, v247, v252, v251, v246, v250);\n\tgoto L_0228;\nL_0228:\n\tv483 = v822 + 0x70;\n\tv372 = 0xFFE368(v483, v822.sdfRes, &v320 @ stack_-114_v3, &v318 @ stack_-120_v3, 0, v240, v272, v61, v363, v253, v822.halfBounds, *([v822 @ X0_v39 (FluidPhysicsCoupler+CouplerJob)+68]), v822.invWorldPerTexel, *([v822 @ X0_v39 (FluidPhysicsCoupler+CouplerJob)+8C]), v822.sdfCenter, *([v822 @ X0_v39 (FluidPhysicsCoupler+CouplerJob)+94]));\n\tv331 = v822.particleRadius - v320;\n\tv339 = v331 <= 0;\n\tif (v339) goto L_FFFFFFFF;\n\tv373 = 0xFFE2E4(v822, 0, &v81 @ X8_v3 (Unity.Collections.NativeArray`1<System.Boolean>), 0, 0, v240, v272, v61, v318, v515, \n// ... truncated")]
		public unsafe void Execute(int p)
		{
			global::Unity.Mathematics.float2 pos = positions[p];
			global::Unity.Mathematics.float2 vP = velocities[p];
			bool frozen = isStatic[p];
			for (int i = 0; i < bodies.Length; i++)
			{
				FluidPhysicsCoupler.BodyData bodyData = bodies[i];
				global::Unity.Mathematics.float2 shapeCenter = bodyData.com + bodyData.offsetWS;
				global::Unity.Mathematics.float2 delta = pos - shapeCenter;
				if (bodyData.shape == FluidPhysicsCoupler.Shape.Circle)
				{
					float minDist = bodyData.radius + particleRadius;
					float distSq = delta.x * delta.x + delta.y * delta.y;
					if (distSq >= minDist * minDist)
					{
						continue;
					}
					float dist = global::UnityEngine.Mathf.Sqrt(distSq);
					global::Unity.Mathematics.float2 normal = (dist > 1E-06f) ? (delta / dist) : new global::Unity.Mathematics.float2(0f, 1f);
					global::Unity.Mathematics.float2 leverArm = normal * bodyData.radius + bodyData.offsetWS;
					global::Unity.Mathematics.float2 netForce = default(global::Unity.Mathematics.float2);
					float netTorque = 0f;
					ResolveBody(frozen, ref vP, normal, leverArm, minDist - dist, in bodyData, ref netForce, ref netTorque);
					AccumulateForce(i, netForce, netTorque);
				}
				else
				{
					global::Unity.Mathematics.float2x2 rot = bodyData.R;
					global::Unity.Mathematics.float2x2 rotT = global::Unity.Mathematics.math.transpose(rot);
					global::Unity.Mathematics.float2 local = global::Unity.Mathematics.math.mul(rotT, delta);
					global::Unity.Mathematics.float2 closest = global::Unity.Mathematics.math.clamp(local, -bodyData.halfExtents, bodyData.halfExtents);
					global::Unity.Mathematics.float2 diff = local - closest;
					float distSq2 = diff.x * diff.x + diff.y * diff.y;
					if (distSq2 >= particleRadius * particleRadius)
					{
						continue;
					}
					global::Unity.Mathematics.float2 normalLocal;
					float penetration2;
					float dist2 = global::UnityEngine.Mathf.Sqrt(distSq2);
					if (dist2 > 1E-06f)
					{
						normalLocal = diff / dist2;
						penetration2 = particleRadius - dist2;
					}
					else
					{
						float px = bodyData.halfExtents.x - global::UnityEngine.Mathf.Abs(local.x);
						float py = bodyData.halfExtents.y - global::UnityEngine.Mathf.Abs(local.y);
						if (px < py)
						{
							normalLocal = new global::Unity.Mathematics.float2(global::Unity.Mathematics.math.sign(local.x), 0f);
							penetration2 = px + particleRadius;
						}
						else
						{
							normalLocal = new global::Unity.Mathematics.float2(0f, global::Unity.Mathematics.math.sign(local.y));
							penetration2 = py + particleRadius;
						}
					}
					global::Unity.Mathematics.float2 normal2 = global::Unity.Mathematics.math.mul(rot, normalLocal);
					global::Unity.Mathematics.float2 leverArm2 = global::Unity.Mathematics.math.mul(rot, closest) + bodyData.offsetWS;
					global::Unity.Mathematics.float2 netForce2 = default(global::Unity.Mathematics.float2);
					float netTorque2 = 0f;
					ResolveBody(frozen, ref vP, normal2, leverArm2, penetration2, in bodyData, ref netForce2, ref netTorque2);
					AccumulateForce(i, netForce2, netTorque2);
				}
			}
			if (!frozen)
			{
				float phi;
				global::Unity.Mathematics.float2 n2;
				FluidPhysicsCoupler.SampleSDF(pos, in sdf, sdfRes, halfBounds, invWorldPerTexel, sdfCenter, out phi, out n2);
				if (phi < particleRadius)
				{
					ResolveWall(frozen, ref vP, n2, particleRadius - phi);
				}
				global::Unity.Mathematics.float2 limit = halfBounds - particleRadius;
				if (pos.x < 0f - limit.x)
				{
					ResolveWall(frozen, ref vP, new global::Unity.Mathematics.float2(1f, 0f), 0f - limit.x - pos.x);
				}
				else if (pos.x > limit.x)
				{
					ResolveWall(frozen, ref vP, new global::Unity.Mathematics.float2(-1f, 0f), pos.x - limit.x);
				}
				if (pos.y < 0f - limit.y)
				{
					ResolveWall(frozen, ref vP, new global::Unity.Mathematics.float2(0f, 1f), 0f - limit.y - pos.y);
				}
				else if (pos.y > limit.y)
				{
					ResolveWall(frozen, ref vP, new global::Unity.Mathematics.float2(0f, -1f), pos.y - limit.y);
				}
			}
			velocities[p] = vP;
		}

		private void AccumulateForce(int bodyIndex, global::Unity.Mathematics.float2 force, float torque)
		{
			FluidPhysicsCoupler.ForceBundle forceBundle = result[bodyIndex];
			forceBundle.bodyIndex = bodyIndex;
			forceBundle.force += force;
			forceBundle.torque += torque;
			result[bodyIndex] = forceBundle;
		}

		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		[global::Cpp2ILInjected.Token(Token = "0x6000264")]
		[global::Cpp2ILInjected.Address(RVA = "0xFFE6C4", Offset = "0xFFE6C4", Length = "0x1D0")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv8 = leverArm * *([bd @ X3 (System.Single)+38]);\n\tv9 = leverArm.y * *([bd @ X3 (System.Single)+38]);\n\tv10 = *([bd @ X3 (System.Single)+30]) - v9;\n\tv11 = *([bd @ X3 (System.Single)+34]) + v8;\n\tv109 = *([vP @ X2 (Unity.Mathematics.float2&)+4]);\n\tv15 = *([vP @ X2 (Unity.Mathematics.float2&)]) - v10;\n\tv16 = *([vP @ X2 (Unity.Mathematics.float2&)+4]) - v11;\n\tv17 = n * v15;\n\tv18 = n.y * v16;\n\tv19 = v17 + v18;\n\tv20 = n.y * leverArm;\n\tv21 = n * leverArm.y;\n\tv22 = v20 - v21;\n\tv25 = v22 * v22;\n\tv26 = v25 * *([bd @ X3 (System.Single)+2C]);\n\tv29 = frozen == 0;\n\tif (v29) goto L_002A;\n\tv71 = *([bd @ X3 (System.Single)+28]) + v26;\n\tv38 = v19 < 0;\n\tif (v38) goto L_003A;\n\tgoto L_005E;\nL_002A:\n\tv44 = this.invFluidMass;\n\tv71 = *([bd @ X3 (System.Single)+28]) + v26;\n\tv57 = v19 >= 0;\n\tif (v57) goto L_005E;\nL_003A:\n\tv75 = this.restitution + 1f;\n\tv76 = v19 * v75;\n\tv77 = -v76;\n\tv78 = v71 + v44;\n\tv79 = v77 / v78;\n\tv80 = n * v79;\n\tv81 = n.y * v79;\n\tv83 = frozen == 0;\n\tv84 = ~v83;\n\tif (v84) goto L_004C;\n\tv118 = v44 * v80;\n\tv119 = v44 * v81;\n\tv120 = *([vP @ X2 (Unity.Mathematics.float2&)]) + v118;\n\tv121 = v109 + v119;\n\t*([vP @ X2 (Unity.Mathematics.float2&)]) = v120;\n\t*([vP @ X2 (Unity.Mathematics.float2&)+4]) = v121;\nL_004C:\n\tv125 = -v80;\n\tv126 = v125 / this.dt;\n\tv127 = -v81;\n\tv128 = v127 / this.dt;\n\tv132 = *([netForce @ X4 (BodyData&)]) + v126;\n\tv92 = v128 + *([netForce @ X4 (BodyData&)+4]);\n\t*([netForce @ X4 (BodyData&)]) = v132;\n\t*([netForce @ X4 (BodyData&)+4]) = v92;\n\tv134 = leverArm * v128;\n\tv110 = leverArm.y * v126;\n\tv135 = v134 - v110;\n\tv112 = v135 + *([netTorque @ X5 (Unity.Mathematics.float2&)]);\n\t*([netTorque @ X5 (Unity.Mathematics.float2&)]) = v112;\n\tv105 = UnityEngine.Mathf::Abs(v79);\nL_005E:\n\tv116 = frozen == 0;\n\tv117 = ~v116;\n\tif (v117) goto L_00F2;\n\tv148 = this.mu <= 0;\n\tif (v148) goto L_00F2;\n\tv199 = n * v16;\n\tv202 = n.y * v15;\n\t// 113 NotImplemented \"Instruction FABD not yet implemented.\"\n\tv161 = v109 <= 0x358637BD;\n\tif (v161) goto L_00F2;\n\tv211 = v199 - v202;\n\tv198 = -n.y;\n\tv212 = v105 * this.mu;\n\tv213 = -v211;\n\tv214 = v113 + v114;\n\tv285 = v213 / v214;\n\tv216 = v105 * this.mu;\n\tv217 = -v216;\n\tv219 = v285 & 0x7FFFFFFF;\n\tv222 = v212 - v285;\n\tv223 = v222 < 0;\n\tv229 = ~v223;\n\tv230 = ~v229;\n\tif (v230) goto L_FFFFFFFF;\n\tv231 = v219 < 0x7F800000;\n\tv251 = ~v231;\n\tv233 = v219 - 0x7F800000;\n\tv248 = v233 == 0;\n\tgoto L_00A8;\nL_00A8:\n\tv252 = ~v248;\n\tv253 = v251 & v252;\n\tv254 = ~v253;\n\tif (v254) goto L_00B1;\n\tgoto L_00B1;\nL_00B1:\n\tv187 = v285 & 0x7FFFFFFF;\n\tv259 = v187 < 0x7F800000;\n\tv260 = ~v259;\n\tv261 = v187 - 0x7F800000;\n\tv263 = v261 == 0;\n\tv268 = ~v260;\n\tv160 = v268 | v263;\n\tv269 = ~v160;\n\tif (v269) goto L_FFFFFFFF;\n\tv272 = v285 - v217;\n\tv178 = v272 < 0;\n\tgoto L_00CE;\nL_00CE:\n\tv154 = ~v178;\n\tif (v154) goto L_00D4;\n\tgoto L_00D4;\nL_00D4:\n\tv286 = n.y * v285;\n\tv287 = -v286;\n\tv196 = n * v285;\n\tv288 = v114 * v287;\n\tv289 = v114 * v196;\n\tv290 = v288 + *([vP @ X2 (Unity.Mathematics.float2&)]);\n\tv291 = v289 + *([vP @ X2 (Unity.Mathematics.float2&)+4]);\n\t*([vP @ X2 (Unity.Mathematics.float2&)]) = v290;\n\t*([vP @ X2 (Unity.Mathematics.float2&)+4]) = v291;\n\tv293 = v285 * v198;\n\tv294 = -v293;\n\tv204 = v294 / this.dt;\n\tv295 = n * v285;\n\tv296 = -v295;\n\tv297 = v296 / this.dt;\n\tv300 = *([netForce @ X4 (BodyData&)]) + v204;\n\tv201 = v297 + *([netForce @ X4 (BodyData&)+4]);\n\t*([netForce @ X4 (BodyData&)]) = v300;\n\t*([netForce @ X4 (BodyData&)+4]) = v201;\n\tv301 = leverArm * v297;\n\tv150 = leverArm.y * v204;\n\tv302 = v301 - v150;\n\tv152 = v302 + *([netTorque @ X5 (Unity.Mathematics.float2&)]);\n\t*([netTorque @ X5 (Unity.Mathematics.float2&)]) = v152;\nL_00F2:\n\treturn;\n// 114 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		private unsafe void ResolveBody(bool frozen, ref global::Unity.Mathematics.float2 vP, global::Unity.Mathematics.float2 n, global::Unity.Mathematics.float2 leverArm, float penetration, in FluidPhysicsCoupler.BodyData bd, ref global::Unity.Mathematics.float2 netForce, ref float netTorque)
		{
			global::Unity.Mathematics.float2 contactVel = new global::Unity.Mathematics.float2(bd.vel.x - leverArm.y * bd.angVel, bd.vel.y + leverArm.x * bd.angVel);
			global::Unity.Mathematics.float2 relVel = vP - contactVel;
			float vn = n.x * relVel.x + n.y * relVel.y;
			float rn = n.y * leverArm.x - n.x * leverArm.y;
			float invMassTotal = bd.invMass + rn * rn * bd.invInertia + (frozen ? 0f : invFluidMass);
			float normalImpulseMag = 0f;
			if (vn < 0f)
			{
				float j = -(vn * (restitution + 1f)) / invMassTotal;
				global::Unity.Mathematics.float2 deltaV = n * j;
				if (!frozen)
				{
					vP += invFluidMass * deltaV;
				}
				global::Unity.Mathematics.float2 force = (0f - deltaV) / dt;
				netForce += force;
				netTorque += leverArm.x * force.y - leverArm.y * force.x;
				normalImpulseMag = global::UnityEngine.Mathf.Abs(j);
			}
			if (!frozen && mu > 0f)
			{
				float vt = n.x * relVel.y - n.y * relVel.x;
				float maxFriction = normalImpulseMag * mu;
				float frictionJ = global::Unity.Mathematics.math.clamp((0f - vt) / invMassTotal, 0f - maxFriction, maxFriction);
				global::Unity.Mathematics.float2 tangent = new global::Unity.Mathematics.float2(0f - n.y, n.x);
				global::Unity.Mathematics.float2 frictionDeltaV = tangent * frictionJ;
				vP += invFluidMass * frictionDeltaV;
				global::Unity.Mathematics.float2 frictionForce = (0f - frictionDeltaV) / dt;
				netForce += frictionForce;
				netTorque += leverArm.x * frictionForce.y - leverArm.y * frictionForce.x;
			}
		}

		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		[global::Cpp2ILInjected.Token(Token = "0x6000265")]
		[global::Cpp2ILInjected.Address(RVA = "0xFFE894", Offset = "0xFFE894", Length = "0x84")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv4 = frozen == 0;\n\tv5 = ~v4;\n\tif (v5) goto L_003D;\n\tv69 = vP->klass;\n\tv66 = *([vP @ X2 (Unity.Mathematics.float2&)+4]);\n\tv9 = n * *([vP @ X2 (Unity.Mathematics.float2&)]);\n\tv10 = n.y * *([vP @ X2 (Unity.Mathematics.float2&)+4]);\n\tv11 = v9 + v10;\n\tv21 = v11 >= 0;\n\tif (v21) goto L_0030;\n\tv77 = this.restitution + 1f;\n\tv78 = v11 * v77;\n\tv79 = -v78;\n\tv80 = v79 / this.invFluidMass;\n\tv81 = n * v80;\n\tv82 = n.y * v80;\n\tv83 = this.invFluidMass * v81;\n\tv84 = this.invFluidMass * v82;\n\tv69 = v69 + v83;\n\tv66 = v66 + v84;\n\t*([vP @ X2 (Unity.Mathematics.float2&)]) = v69;\n\t*([vP @ X2 (Unity.Mathematics.float2&)+4]) = v66;\nL_0030:\n\tv32 = this.mu <= 0;\n\tif (v32) goto L_003D;\n\tv91 = n * v66;\n\tv28 = n.y * v69;\n\tv59 = v91 - v28;\n\tv92 = v59 * n.y;\n\tv93 = n * v59;\n\tv94 = this.mu * v92;\n\tv95 = this.mu * v93;\n\tv72 = v69 + v94;\n\tv23 = v66 - v95;\n\t*([vP @ X2 (Unity.Mathematics.float2&)]) = v72;\n\t*([vP @ X2 (Unity.Mathematics.float2&)+4]) = v23;\nL_003D:\n\treturn;\n// 26 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		private unsafe void ResolveWall(bool frozen, ref global::Unity.Mathematics.float2 vP, global::Unity.Mathematics.float2 n, float penetration)
		{
			if (frozen)
			{
				return;
			}
			float vn = n.x * vP.x + n.y * vP.y;
			if (vn < 0f)
			{
				float j = -(restitution + 1f) * vn;
				vP.x += n.x * j;
				vP.y += n.y * j;
			}
			if (mu > 0f)
			{
				float cross = n.x * vP.y - n.y * vP.x;
				vP.x += mu * cross * n.y;
				vP.y -= mu * cross * n.x;
			}
		}
	}

	[global::Unity.Burst.BurstCompile(global::Unity.Burst.FloatPrecision.Low, global::Unity.Burst.FloatMode.Fast, CompileSynchronously = true)]
	[global::Cpp2ILInjected.Token(Token = "0x200008C")]
	internal struct PositionProjectJob : global::Unity.Jobs.IJobParallelFor
	{
		[global::Unity.Collections.NativeDisableParallelForRestriction]
		[global::Cpp2ILInjected.Token(Token = "0x400029C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> positions;

		[global::Unity.Collections.ReadOnly]
		[global::Cpp2ILInjected.Token(Token = "0x400029D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public global::Unity.Collections.NativeArray<FluidPhysicsCoupler.BodyData> bodies;

		[global::Cpp2ILInjected.Token(Token = "0x400029E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public float particleRadius;

		[global::Cpp2ILInjected.Token(Token = "0x400029F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public global::Unity.Mathematics.float2 halfBounds;

		[global::Cpp2ILInjected.Token(Token = "0x40002A0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		public float percent;

		[global::Unity.Collections.ReadOnly]
		[global::Cpp2ILInjected.Token(Token = "0x40002A1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public global::Unity.Collections.NativeArray<global::Unity.Mathematics.float4> sdf;

		[global::Cpp2ILInjected.Token(Token = "0x40002A2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public global::Unity.Mathematics.int2 sdfRes;

		[global::Cpp2ILInjected.Token(Token = "0x40002A3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public global::Unity.Mathematics.float2 invWorldPerTexel;

		[global::Cpp2ILInjected.Token(Token = "0x40002A4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		public global::Unity.Mathematics.float2 sdfCenter;

		[global::Unity.Collections.ReadOnly]
		[global::Cpp2ILInjected.Token(Token = "0x40002A5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		public global::Unity.Collections.NativeArray<bool> isStatic;

		[global::Cpp2ILInjected.Token(Token = "0x6000266")]
		[global::Cpp2ILInjected.Address(RVA = "0xFFE918", Offset = "0xFFE918", Length = "0x400")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0025;\n\tv51 = System.Xml.ValidateNames;\n\tv52 = v51 + 0xD40;\n\tv53 = \"il2cpp_codegen_initialize_runtime_metadata\"(v52, p, methodInfo, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67);\n\tv70 = 1;\n\t*([302A9FB]) = v70;\nL_0025:\n\tv73 = this.isStatic;\n\tv76 = *([v73 @ X8_v3 (Unity.Collections.NativeArray`1<System.Boolean>)+p @ X1 (System.Int32)]) == 0;\n\tv77 = ~v76;\n\tif (v77) goto L_0222;\n\tv78 = this.positions;\n\tv199 = *([v78 @ X8_v6 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+p @ X1 (System.Int32)*8]);\n\tv91 = *([this @ X0 (FluidPhysicsCoupler+PositionProjectJob)+18]) < 1;\n\tif (v91) goto L_01B2;\n\tv236 = System.Xml.ValidateNames;\n\tgoto L_005C;\nL_0044:\n\tv702 = UnityEngine.Mathf::Sqrt(v650);\n\t// 69 NotImplemented \"Instruction DUP not yet implemented.\"\n\tv657 = v555 - v702;\n\tv711 = v239 / 0x3089705F;\n\tv655 = v711 * v713;\n\t// 74 NotImplemented \"Instruction UNIMPLEMENTED not yet implemented.\"\nL_004B:\n\tv524 = v655 * v657;\nL_004C:\n\tv199 = v676 + v524;\nL_004D:\n\tv328 = v328 + 1;\n\tv329 = v329 + 0x48;\n\tv275 = v328 >= *([this @ X0 (FluidPhysicsCoupler+PositionProjectJob)+18]);\n\tif (v275) goto L_01B2;\nL_005C:\n\tv344 = this.bodies + v329;\n\tv349 = *([2DD4420]) == 0;\n\tif (v349) goto L_0161;\n\tgoto L_006F;\nL_006F:\n\tv418 = *([v344 @ X8_v13+1C]) * *([v344 @ X8_v13+1C]);\n\tv419 = *([v344 @ X8_v13+20]) * *([v344 @ X8_v13+20]);\n\tv420 = v418 + v419;\n\tv496 = UnityEngine.Mathf::Sqrt(v420);\n\tv456 = v496 & 0x7FFFFFFF;\n\tv457 = v456 < 0x7F800000;\n\tv458 = ~v457;\n\tv459 = v456 - 0x7F800000;\n\tv461 = v459 == 0;\n\tv466 = ~v458;\n\tv467 = v466 | v461;\n\tv468 = ~v467;\n\tif (v468) goto L_FFFFFFFF;\n\tv471 = *([v344 @ X8_v13+24]) - v496;\n\tv487 = v471 < 0;\n\tv486 = v471 == 0;\n\tv474 = *([v344 @ X8_v13+24]) ^ v496;\n\tv475 = *([v344 @ X8_v13+24]) ^ v471;\n\tv476 = v474 & v475;\n\tv482 = v476 < 0;\n\tgoto L_0091;\nL_0091:\n\tv490 = v487 == v482;\n\tv491 = ~v486;\n\tv492 = v490 & v491;\n\tv493 = ~v492;\n\tif (v493) goto L_009B;\n\tgoto L_009B;\nL_009B:\n\tv497 = v496 + this.particleRadius;\n\tv239 = v677 - *([v344 @ X8_v13+4]);\n\t// 158 NotImplemented \"Instruction FADDP not yet implemented.\"\n\tv499 = v497 * v497;\n\tv511 = v650 > v499;\n\tif (v511) goto L_004D;\n\tv512 = *([v236 @ X27_v4 (Il2CppClass<System.Xml.ValidateNames>)+D40]);\n\tv513 = *([v512 @ X8_v22+B8]);\n\tv524 = *([v513 @ X8_v23]);\n\tv515 = *([v344 @ X8_v13]) == 0;\n\tif (v515) goto L_016A;\n\tv554 = *([2DD4420]) == 0;\n\tif (v554) goto L_019C;\n\tgoto L_00C0;\n\tv606 = v594;\n\tv607 = \"il2cpp_codegen_runtime_class_init\"(v600, p, methodInfo, v55, v56, v57, v58, v59, v499, v498, v308, v312, v310, v313, v311, v594);\n\tv610 = v606;\n\tv613 = v258;\nL_00C0:\n\tv618 = *([v344 @ X8_v13+4]) + *([v344 @ X8_v13+3C]);\n\tv619 = v677 - v618;\n\tv621 = *([v344 @ X8_v13+14]) * v619;\n\t// 196 NotImplemented \"Instruction FADDP not yet implemented.\"\n\t// 197 NotImplemented \"Instruction FADDP not yet implemented.\"\n\tv622 = *([v344 @ X8_v13+1C]) + this.particleRadius;\n\tv623 = *([v344 @ X8_v13+20]) + this.particleRadius;\n\tv624 = UnityEngine.Mathf::Abs(v729);\n\tv635 = UnityEngine.Mathf::Abs(v621);\n\tv656 = v624 - v622;\n\tv647 = v635 - v623;\n\tv682 = UnityEngine.Mathf::Max(v656, 0f);\n\tv689 = UnityEngine.Mathf::Max(v647, 0f);\n\tv704 = v682 * v682;\n\tv705 = v689 * v689;\n\tv706 = v704 + v705;\n\tv707 = UnityEngine.Mathf::Sqrt(v706);\n\tv681 = v647 & 0x7FFFFFFF;\n\tv716 = v681 < 0x7F800000;\n\tv717 = ~v716;\n\tv718 = v681 - 0x7F800000;\n\tv720 = v718 == 0;\n\tv725 = ~v717;\n\tv726 = v725 | v720;\n\tv727 = ~v726;\n\tif (v727) goto L_FFFFFFFF;\n\tv749 = v656 - v647;\n\tv765 = v749 < 0;\n\tv764 = v749 == 0;\n\tv752 = v656 ^ v647;\n\tv753 = v656 ^ v749;\n\tv754 = v752 & v753;\n\tv760 = v754 < 0;\n\tgoto L_00F1;\nL_00F1:\n\tv768 = v765 == v760;\n\tv641 = ~v764;\n\tv769 = v768 & v641;\n\tv653 = ~v769;\n\tif (v653) goto L_FFFFFFFF;\n\tgoto L_00FA;\nL_00FA:\n\tv649 = UnityEngine.Mathf::Min(v772, 0f);\n\tv643 = v707 + v649;\n\tv659 = v643 >= 0;\n\tif (v659) goto L_004C;\n\tv777 = v729 < 0;\n\tv778 = v729 == 0;\n\tv780 = v729 ^ v729;\n\tv781 = v729 & v780;\n\tv782 = v781 < 0;\n\tv783 = v777 == v782;\n\tv784 = ~v778;\n\tv785 = v783 & v784;\n\tv786 = ~v785;\n\tif (v786) goto L_FFFFFFFF;\n\tgoto L_011B;\nL_011B:\n\tv790 = v729 + -1f;\n\tv791 = v729 >= 0;\n\tif (v791) goto L_0125;\n\tgoto L_0125;\nL_0125:\n\tv797 = v621 < 0;\n\tv798 = v621 == 0;\n\tv800 = v621 ^ v621;\n\tv801 = v621 & v800;\n\tv802 = v801 < 0;\n\tv803 = v797 == v802;\n\tv804 = ~v798;\n\tv805 = v803 & v804;\n\tv806 = ~v805;\n\tif (v806) goto L_0135;\n\tgoto L_0135;\nL_0135:\n\tv810 = v621 >= 0;\n\tif (v810) goto L_013D;\n\tgoto L_013D;\nL_013D:\n\tv744 = v656 - v647;\n\tv743 = v744 < 0;\n\tv742 = v744 == 0;\n\tv741 = v656 ^ v647;\n\tv740 = v656 ^ v744;\n\tv739 = v741 & v740;\n\tv738 = v739 < 0;\n\tv815 = v743 == v738;\n\tv816 = ~v742;\n\tv817 = v815 & v816;\n\tv818 = ~v817;\n\tif (v818) goto L_014D;\n\tgoto L_014D;\nL_014D:\n\tv822 = v743 == v738;\n\tv730 = ~v742;\n\tv737 = v822 & v730;\n\tv734 = ~v737;\n\tif (v734) goto L_0156;\n\tgoto L_0156;\nL_0156:\n\tv655 = v611 * v826;\n\tv827 = *([v344 @ X8_v13+14]) * v713;\n\tv828 = v827 + v655;\n\t// 345 NotImplemented \"Instruction UNIMPLEMENTED not yet implemented.\"\n\tv657 = v828 * v829;\n\t// 348 NotImplemented \"Instruction UNIMPLEMENTED not yet implemented.\"\n\tgoto L_004B;\nL_0161:\n\t*([2DD4420]) = 1;\n\tgoto L_006F;\n\tv411 = \"il2cpp_codegen_runtime_class_init\"(v423, p, methodInfo, v55, v56, v57, v58, v59, v347, v346, v308, v312, v310, v313, v311, v315);\n\tv408 = v258;\n\tgoto L_006F;\nL_016A:\n\tv555 = *([v344 @ X8_v13+24]) + this.particleRadius;\n\tv556 = v555 * v555;\n\tv562 = v650 - 0x3089705F;\n\tv563 = v562 < 0;\n\tv564 = v562 == 0;\n\tv565 = v650 ^ 0x3089705F;\n\tv566 = v650 ^ v562;\n\tv567 = v565 & v566;\n\tv568 = v567 < 0;\n\tv569 = v563 == v568;\n\tv570 = ~v564;\n\tv571 = v569 & v570;\n\tv572 = ~v571;\n\tif (v572) goto L_FFFFFFFF;\n\tv583 = v650 - v556;\n\tv631 = v583 < 0;\n\tgoto L_018C;\nL_018C:\n\tv634 = ~v631;\n\tif (v634) goto L_004C;\n\tv637 = *([2DD4420]) == 0;\n\tif (v637) goto L_01A7;\n\tgoto L_0044;\n\tgoto L_01AF;\nL_019C:\n\t*([2DD4420]) = 1;\n\tgoto L_00C0;\n\tgoto L_FFFFFFFF;\nL_01A7:\n\t*([2DD4420]) = 1;\n\tgoto L_0044;\nL_01AF:\n\tgoto L_0044;\nL_01B2:\n\tv300 = this + 0x30;\n\tv202 = 0xFFE368(v300, this.sdfRes, &v109 @ stack_-A4_v3, &v105 @ stack_-B0_v3, 0, v57, v58, v59, v199, v299, this.halfBounds, *([this @ X0 (FluidPhysicsCoupler+PositionProjectJob)+28]), this.invWorldPerTexel, *([this @ X0 (FluidPhysicsCoupler+PositionProjectJob)+4C]), this.sdfCenter, *([this @ X0 (FluidPhysicsCoupler+PositionProjectJob)+54]));\n\tv361 = v109 >= this.particleRadius;\n\tif (v361) goto L_01EA;\n\tv370 = this.particleRadius - v109;\n\tv371 = v370 * v105;\n\tv372 = v370 * v369;\n\tv374 = v371 * this.percent;\n\tv375 = v372 * this.percent;\n\tv377 = v199 + v374;\n\tv427 = v299 + v375;\n\tv428 = this.halfBounds - this.particleRadius;\n\tv158 = -v428;\n\tv392 = v377 >= v158;\n\tif (v392) goto L_01F8;\n\tgoto L_0209;\nL_01EA:\n\tv428 = this.halfBounds - this.particleRadius;\n\tv158 = -v428;\n\tv400 = v199 < v158;\n\tif (v400) goto L_0209;\nL_01F8:\n\tv441 = v425 - v428;\n\tv442 = v441 < 0;\n\tv443 = v441 == 0;\n\tv444 = v425 ^ v428;\n\tv445 = v425 ^ v441;\n\tv446 = v444 & v445;\n\tv447 = v446 < 0;\n\tv448 = v442 == v447;\n\tv449 = ~v448;\n\tv450 = v449 | v443;\n\tv451 = ~v450;\n\tif (v451) goto L_FFFFFFFF;\n\tgoto L_0209;\nL_0209:\n\tv93 = p << 3;\n\tv206 = this.positions + v93;\n\t*([v206 @ X8_v10]) = v158;\n\t*([v206 @ X8_v10+4]) = v148;\nL_0222:\n\treturn;\n// 299 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public unsafe void Execute(int p)
		{
			if (isStatic[p])
			{
				return;
			}
			global::Unity.Mathematics.float2 pos = positions[p];
			for (int i = 0; i < bodies.Length; i++)
			{
				FluidPhysicsCoupler.BodyData bodyData = bodies[i];
				global::Unity.Mathematics.float2 delta = pos - (bodyData.com + bodyData.offsetWS);
				if (bodyData.shape == FluidPhysicsCoupler.Shape.Circle)
				{
					float minDist = bodyData.radius + particleRadius;
					float distSq = delta.x * delta.x + delta.y * delta.y;
					if (distSq >= minDist * minDist)
					{
						continue;
					}
					float dist = global::UnityEngine.Mathf.Sqrt(distSq);
					global::Unity.Mathematics.float2 normal = (dist > 1E-06f) ? (delta / dist) : new global::Unity.Mathematics.float2(0f, 1f);
					pos += normal * ((minDist - dist) * percent);
				}
				else
				{
					global::Unity.Mathematics.float2x2 rot = bodyData.R;
					global::Unity.Mathematics.float2 local = global::Unity.Mathematics.math.mul(global::Unity.Mathematics.math.transpose(rot), delta);
					global::Unity.Mathematics.float2 closest = global::Unity.Mathematics.math.clamp(local, -bodyData.halfExtents, bodyData.halfExtents);
					global::Unity.Mathematics.float2 diff = local - closest;
					float distSq2 = diff.x * diff.x + diff.y * diff.y;
					if (distSq2 >= particleRadius * particleRadius)
					{
						continue;
					}
					global::Unity.Mathematics.float2 normalLocal;
					float penetration;
					float dist2 = global::UnityEngine.Mathf.Sqrt(distSq2);
					if (dist2 > 1E-06f)
					{
						normalLocal = diff / dist2;
						penetration = particleRadius - dist2;
					}
					else
					{
						float px = bodyData.halfExtents.x - global::UnityEngine.Mathf.Abs(local.x);
						float py = bodyData.halfExtents.y - global::UnityEngine.Mathf.Abs(local.y);
						if (px < py)
						{
							normalLocal = new global::Unity.Mathematics.float2(global::Unity.Mathematics.math.sign(local.x), 0f);
							penetration = px + particleRadius;
						}
						else
						{
							normalLocal = new global::Unity.Mathematics.float2(0f, global::Unity.Mathematics.math.sign(local.y));
							penetration = py + particleRadius;
						}
					}
					global::Unity.Mathematics.float2 normal2 = global::Unity.Mathematics.math.mul(rot, normalLocal);
					pos += normal2 * (penetration * percent);
				}
			}
			float phi;
			global::Unity.Mathematics.float2 n;
			FluidPhysicsCoupler.SampleSDF(pos, in sdf, sdfRes, halfBounds, invWorldPerTexel, sdfCenter, out phi, out n);
			if (phi < particleRadius)
			{
				pos += n * ((particleRadius - phi) * percent);
			}
			global::Unity.Mathematics.float2 limit = halfBounds - particleRadius;
			pos.x = global::Unity.Mathematics.math.clamp(pos.x, 0f - limit.x, limit.x);
			pos.y = global::Unity.Mathematics.math.clamp(pos.y, 0f - limit.y, limit.y);
			positions[p] = pos;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x4000268")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private FluidSolver solver;

	[global::Cpp2ILInjected.Token(Token = "0x4000269")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public float fixedDeltaTime;

	[global::UnityEngine.Range(0f, 1f)]
	[global::Cpp2ILInjected.Token(Token = "0x400026A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public float surfaceFriction;

	[global::Cpp2ILInjected.Token(Token = "0x400026B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public int positionIterations;

	[global::Cpp2ILInjected.Token(Token = "0x400026C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	public float slop;

	[global::Cpp2ILInjected.Token(Token = "0x400026D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public global::UnityEngine.Vector2 halfBounds;

	[global::Cpp2ILInjected.Token(Token = "0x400026E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	private readonly global::System.Collections.Generic.List<FluidPhysicsCoupler.BodyInfo> bodies;

	[global::Cpp2ILInjected.Token(Token = "0x400026F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	private float accumulator;

	[global::Cpp2ILInjected.Token(Token = "0x4000270")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public SDFCollider SDFCollider;

	[global::Cpp2ILInjected.Token(Token = "0x4000271")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	private global::Unity.Collections.NativeArray<global::Unity.Mathematics.float4> _sdfField;

	[global::Cpp2ILInjected.Token(Token = "0x4000272")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	private global::Unity.Mathematics.int2 _sdfRes;

	[global::Cpp2ILInjected.Token(Token = "0x4000273")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	private global::Unity.Mathematics.float2 _invWorldPerTexel;

	[global::Cpp2ILInjected.Token(Token = "0x4000274")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	private global::Unity.Mathematics.float2 _sdfCenter;

	[global::Cpp2ILInjected.Token(Token = "0x4000275")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	private global::Unity.Mathematics.Random _rng;

	[global::Cpp2ILInjected.Token(Token = "0x4000276")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x84")]
	public float particleCollisionRadius;

	[global::Cpp2ILInjected.Token(Token = "0x6000259")]
	[global::Cpp2ILInjected.Address(RVA = "0xFFB7E8", Offset = "0xFFB7E8", Length = "0x38")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv13 = UnityEngine.Time::get_frameCount();\n\tv14 = v13 + 1;\n\tv15 = v14 ^ v14;\n\tv16 = v15 ^ v15;\n\tv17 = v16 ^ v16;\n\tthis._rng = v17;\n\treturn;\n// 13 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void Awake()
	{
		_rng = new global::Unity.Mathematics.Random((uint)(global::UnityEngine.Time.frameCount + 1));
	}

	[global::Cpp2ILInjected.Token(Token = "0x600025A")]
	[global::Cpp2ILInjected.Address(RVA = "0xFFB820", Offset = "0xFFB820", Length = "0x2A8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv26 = Il2CppMethodInfo;\n\tgoto L_0034;\n\tv33 = Il2CppMethodInfo;\n\tv34 = v33 + 0x648;\n\tv35 = \"il2cpp_codegen_initialize_runtime_metadata\"(v34, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv60 = 0x2E14000;\n\tv61 = v60 + 0x9C0;\n\tv62 = \"il2cpp_codegen_initialize_runtime_metadata\"(v61, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv68 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv69 = v68 + 0xFD8;\n\tv70 = \"il2cpp_codegen_initialize_runtime_metadata\"(v69, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv75 = System.Runtime.Serialization.ObjectHolderList;\n\tv76 = v75 + 0x258;\n\tv77 = \"il2cpp_codegen_initialize_runtime_metadata\"(v76, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv82 = Il2CppMethodInfo;\n\tv83 = v82 + 0xC90;\n\tv84 = \"il2cpp_codegen_initialize_runtime_metadata\"(v83, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv86 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv87 = v86 + 0xA48;\n\tv88 = \"il2cpp_codegen_initialize_runtime_metadata\"(v87, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv183 = System.Net.Configuration.SettingsSectionInternal;\n\tv184 = v183 + 0xB78;\n\tv185 = \"il2cpp_codegen_initialize_runtime_metadata\"(v184, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv225 = System.Xml.ValidateNames;\n\tv226 = v225 + 0x98;\n\tv227 = \"il2cpp_codegen_initialize_runtime_metadata\"(v226, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv233 = \"focus\";\n\tv234 = v233 + 0x3C8;\n\tv52 = \"il2cpp_codegen_initialize_runtime_metadata\"(v234, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv54 = 1;\n\t*([302A9F2]) = v54;\nL_0034:\n\tv55 = Il2CppMethodInfo;\n\tv59 = UnityEngine.Component::GetComponent /* +1 sharing this address */(this, *([v26 @ X20_v1 (Il2CppMethodInfo)+648]));\n\tv65 = this + 0x20;\n\tthis.solver = v59;\n\tv67 = 0xF3F1B4(v65, v59, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tgoto L_0046;\n\tv78 = \"il2cpp_codegen_runtime_class_init\"(v71, v63, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\nL_0046:\n\tv81 = Singleton`1::get_Instance /* +1 sharing this address */(*([v55 @ X23_v1 (Il2CppMethodInfo)+C90]));\n\tv89 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv92 = *([v89 @ X8_v6 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv94 = *([v92 @ X0_v14+E0]) == 0;\n\tif (v94) goto L_0070;\n\tv189 = UnityEngine.Object::op_Inequality(*([v81 @ X0_v9+78]), 0);\n\tv228 = ~v189;\n\tif (v228) goto L_0075;\nL_005A:\n\tgoto L_005D;\n\tv295 = \"il2cpp_codegen_runtime_class_init\"(v238, v147, v140, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\nL_005D:\n\tv154 = Singleton`1::get_Instance /* +1 sharing this address */(*([v55 @ X23_v1 (Il2CppMethodInfo)+C90]));\n\tv155 = *([v154 @ X0_v42+78]);\n\tv307 = Level::get_TotalLevelHeight(*([v154 @ X0_v42+78]));\n\tv309 = v155.levelWidth * 0.5f;\n\tv310 = v307 * 0.5f;\n\tthis.halfBounds = v309;\n\tthis.halfBounds.y = v310;\n\tgoto L_00AE;\nL_0070:\n\tv232 = UnityEngine.Object::op_Inequality(*([v81 @ X0_v9+78]), 0);\n\tv251 = ~v232;\n\tv237 = ~v251;\n\tif (v237) goto L_005A;\nL_0075:\n\tv245 = 0x2E14000 + 0x9C0;\n\tgoto L_0081;\n\tv298 = \"il2cpp_codegen_runtime_class_init\"(v248, v241, v141, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\nL_0081:\n\tv156 = System.Type::GetTypeFromHandle(*([v245 @ X8_v14 (System.Int32)]));\n\tv301 = \"focus\";\n\tv304 = System.Type::GetField(v156, *([v301 @ X8_v18 (System.String)+3C8]));\n\tv157 = System.Reflection.FieldInfo::op_Inequality(v304, 0);\n\tv311 = ~v157;\n\tif (v311) goto L_00AE;\n\tv174 = *([v304 @ X0_v29 (System.Reflection.FieldInfo)]);\n\tv158 = System.Reflection.FieldInfo::GetValue(v304, this.solver);\n\tv318 = System.Xml.ValidateNames;\n\tv151 = *([v318 @ X8_v21 (Il2CppClass<System.Xml.ValidateNames>)+98]);\n\tv320 = *([v158 @ X0_v32 (System.Object)]);\n\tv193 = *([v320 @ X8_v23 (Il2CppClass<System.Object>)+40]) != *([v151 @ X1_v5 (System.Reflection.FieldInfo)+40]);\n\tif (v193) goto L_00DE;\n\tv313 = \"il2cpp_vm_object_unbox\"(v158, v151, *([v174 @ X8_v20 (Il2CppClass<System.Reflection.FieldInfo>)+2D0]), v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tthis.halfBounds = *([v313 @ X0_v33]);\nL_00AE:\n\tFluidPhysicsCoupler::RefreshBodies(this);\n\tSDFCollider::Init(this.SDFCollider, this);\n\tv176 = this.SDFCollider;\n\t// 187 MakeStruct v97 @ AGGFFBA6C_0_v3 (UnityEngine.Vector2), typeof(UnityEngine.Vector2), v176.sdfCenter (UnityEngine.Vector2), v176.sdfCenter.y (System.Single)\n\tv136 = Unity.Mathematics.float2::op_Implicit(v97);\n\tthis._sdfCenter = v136;\n\tthis._sdfCenter.y = v136.y;\n\tv177 = this.SDFCollider;\n\tFluidPhysicsCoupler::RegisterSDF(this, v177.outputSDF);\n\tgoto L_00DB;\n\tv330 = \"il2cpp_codegen_runtime_class_init\"(v328, v326, v145, v38, v39, v40, v41, v42, v136, v133, v130, v46, v47, v48, v49, v50);\nL_00DB:\n\tUnityEngine.Physics2D::set_simulationMode(2);\n\treturn;\n\tv182 = new System.NullReferenceException();\nL_00DE:\n\tthrow System.InvalidCastException;\n// 131 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void Init()
	{
		solver = GetComponent<FluidSolver>();
		global::GameManager instance = global::Singleton<global::GameManager>.Instance;
		if (instance != null && instance.level != null)
		{
			Level level = instance.level;
			halfBounds = new global::UnityEngine.Vector2(level.levelWidth * 0.5f, level.TotalLevelHeight * 0.5f);
		}
		RefreshBodies();
		SDFCollider.Init(this);
		global::UnityEngine.Vector2 vector = default(global::UnityEngine.Vector2);
		vector.x = SDFCollider.sdfCenter.x;
		vector.y = SDFCollider.sdfCenter.y;
		_sdfCenter = vector;
		RegisterSDF(SDFCollider.outputSDF);
		global::UnityEngine.Physics2D.simulationMode = global::UnityEngine.SimulationMode2D.Script;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600025B")]
	[global::Cpp2ILInjected.Address(RVA = "0x11472D0", Offset = "0x11472D0", Length = "0x484")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv21 = &v21 @ X29;\n\t*([v21 @ X29-88]) = this;\n\tv31 = *([2C38708]);\n\t*([v21 @ X29-58]) = *([v31 @ X8_v2]);\n\tgoto L_001D;\n\tv37 = 0xF705D0(v118, list, v118, v111, v109, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\nL_001D:\n\tv54 = Il2CppClass<T>;\n\tv58 = *([v54 @ X8_v4 (Il2CppClass<T>)+FC]) + 0xF;\n\tv59 = v58 & 0x1FFFFFFF0;\n\tv60 = &v57 @ stack_-A0_v1 - v59;\n\tv64 = &v57 @ stack_-A0_v1 - v59;\n\tv68 = &v57 @ stack_-A0_v1 - v59;\n\t*([v21 @ X29-90]) = v68;\n\tv72 = &v57 @ stack_-A0_v1 - v59;\n\tv76 = &v57 @ stack_-A0_v1 - v59;\n\t*([v21 @ X29-78]) = v76;\n\tv79 = 0x274A2FC(v76, *([v54 @ X8_v4 (Il2CppClass<T>)+FC]), v118, v111, v109, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv82 = &v57 @ stack_-A0_v1 - v59;\n\t*([v21 @ X29-80]) = v82;\n\tv85 = 0x274A2FC(v82, *([v54 @ X8_v4 (Il2CppClass<T>)+FC]), v118, v111, v109, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tgoto L_0046;\n\tv94 = v87;\n\tv95 = 0xF7055C(v94, v87, methodInfo, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv97 = v95;\nL_0046:\n\tv99 = list->klass;\n\tv194 = list->klass->rank;\n\tv101 = *([v99 @ X8_v15 (Il2CppClass<System.Collections.Generic.IList`1<T>>)+12E]) == 0;\n\tif (v101) goto L_0066;\n\tv203 = *([v99 @ X8_v15 (Il2CppClass<System.Collections.Generic.IList`1<T>>)+B0]) + 8;\nL_0051:\n\tv208 = *([v203 @ X10_v32-8]) == Il2CppClass<System.Collections.Generic.ICollection`1<T>>;\n\tif (v208) goto L_0079;\n\tv203 = v203 + 0x10;\n\tv170 = v194 - 1;\n\tv168 = v194 != 1;\n\tif (v168) goto L_0051;\nL_0066:\n\tv191 = 0xF7087C(list, Il2CppClass<System.Collections.Generic.ICollection`1<T>>, 0, v111, v109, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv153 = *([v191 @ X0_v58+8]);\n\t*([v191 @ X0_v58])(v309, list, *([v191 @ X0_v58+8]), 0, v111, v109, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv373 = v309 - 1;\n\tv227 = v373 >= 1;\n\tif (v227) goto L_FFFFFFFF;\n\tgoto L_01BF;\nL_0079:\n\tv275 = *([v203 @ X10_v32]) << 4;\n\tv276 = v99 + v275;\n\tv277 = v276 + 0x138;\n\tv153 = *([v277 @ X0_v61+8]);\n\t*([v277 @ X0_v61])(v309, list, *([v277 @ X0_v61+8]), v118, v111, v109, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv373 = v309 - 1;\n\tv293 = v373 < 1;\n\tif (v293) goto L_01BF;\n\tgoto L_00AA;\nL_0091:\n\tv785 = 0xF7087C(list, Il2CppClass<System.Collections.Generic.IList`1<T>>, 1, v692, *([v21 @ X29-90]), v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\nL_0092:\n\tv789 = &v21 @ X29 - 0x6C;\n\t*([v21 @ X29-68]) = v789;\n\t*([v21 @ X29-60]) = v72;\n\tv153 = *([v785 @ X0_v35+8]);\n\tv355 = &v21 @ X29 - 0x68;\n\t*([v153 @ X1_v6+10])(v155, *([v153 @ X1_v6+8]), v153, list, v355, v72, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv345 = v373 - 1;\n\tv322 = v373 <= 1;\n\tif (v322) goto L_01BF;\nL_00AA:\n\tv375 = *([v21 @ X29-88]);\n\tv377 = *([v375 @ X9_v10+80]) ^ *([v375 @ X9_v10+80]);\n\tv378 = v377 ^ v377;\n\tv379 = v378 ^ v378;\n\t*([v375 @ X9_v10+80]) = v379;\n\tgoto L_00BC;\n\tv394 = v381;\n\tv395 = 0xF7055C(v394, v381, v358, v355, v354, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv397 = v395;\nL_00BC:\n\tv400 = *([v375 @ X9_v10+80]) * v356;\n\tv314 = v400 >> 0x20;\n\t*([v21 @ X29-6C]) = v314;\n\tv401 = list->klass;\n\tv436 = list->klass->rank;\n\tv404 = *([v401 @ X8_v28 (Il2CppClass<System.Collections.Generic.IList`1<T>>)+12E]) == 0;\n\tif (v404) goto L_00E0;\n\tv445 = *([v401 @ X8_v28 (Il2CppClass<System.Collections.Generic.IList`1<T>>)+B0]) + 8;\nL_00C6:\n\t;\n\tv450 = *([v445 @ X10_v27-8]) == Il2CppClass<System.Collections.Generic.IList`1<T>>;\n\tif (v450) goto L_00E2;\n\tv445 = v445 + 0x10;\n\tv412 = v436 - 1;\n\tv410 = v436 != 1;\n\tif (v410) goto L_00C6;\nL_00E0:\n\tv474 = 0xF7087C(list, Il2CppClass<System.Collections.Generic.IList`1<T>>, 0, v355, v354, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tgoto L_00E6;\nL_00E2:\n\t;\n\tv457 = *([v445 @ X10_v27]) << 4;\n\tv458 = v401 + v457;\n\tv474 = v458 + 0x138;\nL_00E6:\n\tv476 = &v21 @ X29 - 0x6C;\n\t*([v21 @ X29-68]) = v476;\n\t*([v21 @ X29-60]) = v60;\n\tv477 = *([v474 @ X0_v14+8]);\n\tv480 = &v21 @ X29 - 0x68;\n\t*([v477 @ X1_v11+10])(v483, *([v477 @ X1_v11+8]), v477, list, v480, v60, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv487 = 0x274A9F8(*([v21 @ X29-78]), v60, *([v54 @ X8_v4 (Il2CppClass<T>)+FC]), v480, v60, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tgoto L_0100;\n\tv495 = v489;\n\tv496 = 0xF7055C(v495, v489, v486, v480, v482, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv498 = v496;\nL_0100:\n\t*([v21 @ X29-6C]) = v373;\n\tv500 = list->klass;\n\tv534 = list->klass->rank;\n\tv502 = *([v500 @ X8_v35 (Il2CppClass<System.Collections.Generic.IList`1<T>>)+12E]) == 0;\n\tif (v502) goto L_0121;\n\tv543 = *([v500 @ X8_v35 (Il2CppClass<System.Collections.Generic.IList`1<T>>)+B0]) + 8;\nL_0107:\n\t;\n\tv548 = *([v543 @ X10_v22-8]) == Il2CppClass<System.Collections.Generic.IList`1<T>>;\n\tif (v548) goto L_0123;\n\tv543 = v543 + 0x10;\n\tv510 = v534 - 1;\n\tv508 = v534 != 1;\n\tif (v508) goto L_0107;\nL_0121:\n\tv572 = 0xF7087C(list, Il2CppClass<System.Collections.Generic.IList`1<T>>, 0, v480, v60, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tgoto L_0127;\nL_0123:\n\t;\n\tv555 = *([v543 @ X10_v22]) << 4;\n\tv556 = v500 + v555;\n\tv572 = v556 + 0x138;\nL_0127:\n\tv574 = &v21 @ X29 - 0x6C;\n\t*([v21 @ X29-68]) = v574;\n\t*([v21 @ X29-60]) = v64;\n\tv575 = *([v572 @ X0_v20+8]);\n\tv578 = &v21 @ X29 - 0x68;\n\t*([v575 @ X1_v15+10])(v581, *([v575 @ X1_v15+8]), v575, list, v578, v64, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv585 = 0x274A9F8(*([v21 @ X29-80]), v64, *([v54 @ X8_v4 (Il2CppClass<T>)+FC]), v578, v64, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv589 = 0x274A9F8(*([v21 @ X29-90]), *([v21 @ X29-78]), *([v54 @ X8_v4 (Il2CppClass<T>)+FC]), v578, v64, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tgoto L_014A;\n\tv597 = v591;\n\tv598 = 0xF7055C(v597, v591, v588, v578, v580, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv600 = v598;\n\tv603 = Il2CppMethodRgctx<FluidPhysicsCoupler::Shuffle>;\nL_014A:\n\tgoto L_014D;\n\tv610 = *([v403 @ X25_v7]);\nL_014D:\n\t*([v21 @ X29-6C]) = v373;\n\tv613 = list->klass;\n\tv647 = list->klass->rank;\n\tv615 = *([v613 @ X8_v43 (Il2CppClass<System.Collections.Generic.IList`1<T>>)+12E]) == 0;\n\tif (v615) goto L_016E;\n\tv656 = *([v613 @ X8_v43 (Il2CppClass<System.Collections.Generic.IList`1<T>>)+B0]) + 8;\nL_0154:\n\t;\n\tv661 = *([v656 @ X10_v17-8]) == Il2CppClass<System.Collections.Generic.IList`1<T>>;\n\tif (v661) goto L_0170;\n\tv656 = v656 + 0x10;\n\tv623 = v647 - 1;\n\tv621 = v647 != 1;\n\tif (v621) goto L_0154;\nL_016E:\n\tv686 = 0xF7087C(list, Il2CppClass<System.Collections.Generic.IList`1<T>>, 1, v578, v64, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tgoto L_0175;\nL_0170:\n\t;\n\tv668 = *([v656 @ X10_v17]) + 1;\n\tv669 = v668 << 4;\n\tv670 = v613 + v669;\n\tv686 = v670 + 0x138;\nL_0175:\n\tv688 = &v21 @ X29 - 0x6C;\n\t*([v21 @ X29-68]) = v688;\n\t*([v21 @ X29-60]) = *([v21 @ X29-90]);\n\tv689 = *([v686 @ X0_v28+8]);\n\tv692 = &v21 @ X29 - 0x68;\n\t*([v689 @ X1_v20+10])(v695, *([v689 @ X1_v20+8]), v689, list, v692, *([v21 @ X29-90]), v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv699 = 0x274A9F8(v72, *([v21 @ X29-80]), *([v54 @ X8_v4 (Il2CppClass<T>)+FC]), v692, *([v21 @ X29-90]), v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tgoto L_0195;\n\tv707 = v701;\n\tv708 = 0xF7055C(v707, v701, v698, v692, v694, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv710 = v708;\n\tv713 = Il2CppMethodRgctx<FluidPhysicsCoupler::Shuffle>;\nL_0195:\n\tgoto L_0197;\n\tv720 = *([v72 @ X26_v1]);\nL_0197:\n\t*([v21 @ X29-6C]) = v314;\n\tv721 = list->klass;\n\tv754 = list->klass->rank;\n\tv344 = *([v721 @ X8_v51 (Il2CppClass<System.Collections.Generic.IList`1<T>>)+12E]) == 0;\n\tif (v344) goto L_0091;\n\tv763 = *([v721 @ X8_v51 (Il2CppClass<System.Collections.Generic.IList`1<T>>)+B0]) + 8;\nL_019E:\n\t;\n\tv768 = *([v763 @ X10_v10-8]) == Il2CppClass<System.Collections.Generic.IList`1<T>>;\n\tif (v768) goto L_01B7;\n\tv763 = v763 + 0x10;\n\tv730 = v754 - 1;\n\tv728 = v754 != 1;\n\tif (v728) goto L_019E;\n\tgoto L_0091;\nL_01B7:\n\t;\n\tv776 = *([v763 @ X10_v10]) + 1;\n\tv773 = v776 << 4;\n\tv788 = v721 + v773;\n\tv785 = v788 + 0x138;\n\tgoto L_0092;\nL_01BF:\n\tv349 = *([2C38708]);\n\tv122 = *([v349 @ X9_v6]) != *([v21 @ X\n// ... truncated")]
	private void Shuffle<T>(global::System.Collections.Generic.IList<T> list)
	{
		int num = list.Count;
		while (num > 1)
		{
			num--;
			int index = global::UnityEngine.Random.Range(0, num + 1);
			T value = list[index];
			list[index] = list[num];
			list[num] = value;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x600025C")]
	[global::Cpp2ILInjected.Address(RVA = "0xFFC028", Offset = "0xFFC028", Length = "0x138")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_001C;\n\tv27 = Il2CppMethodInfo;\n\tv28 = v27 + 0xF0;\n\tv29 = \"il2cpp_codegen_initialize_runtime_metadata\"(v28, rt, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv49 = Il2CppMethodInfo;\n\tv50 = v49 + 0xB58;\n\tv45 = \"il2cpp_codegen_initialize_runtime_metadata\"(v50, rt, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv47 = 1;\n\t*([302A9F3]) = v47;\nL_001C:\n\t;\n\tv59 = UnityEngine.RenderTexture::get_width(rt);\n\tv59 = UnityEngine.RenderTexture::get_height(rt);\n\tv66 = v59 * v59;\n\tUnity.Collections.NativeArray`1<Unity.Mathematics.float4>::.ctor(&v71 @ stack_-60_v2 (Unity.Collections.NativeArray`1<Unity.Mathematics.float4>), v66, 4, 0);\n\tv75 = this + 0x58;\n\tthis._sdfField = v71;\n\tv81 = UnityEngine.Rendering.AsyncGPUReadback::RequestIntoNativeArray(v75, rt, 0, 0);\n\tUnityEngine.Rendering.AsyncGPUReadbackRequest::WaitForCompletion(&v81 @ X0_v9 (UnityEngine.Rendering.AsyncGPUReadbackRequest));\n\tv59 = UnityEngine.RenderTexture::get_width(rt);\n\tv59 = UnityEngine.RenderTexture::get_height(rt);\n\tv120 = v59 | v59;\n\tthis._sdfRes = v120;\n\t// 81 NotImplemented \"Instruction UNIMPLEMENTED not yet implemented.\"\n\tv139 = this.halfBounds + this.halfBounds;\n\tv100 = v59 / v139;\n\tthis._invWorldPerTexel = v100;\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 68 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public unsafe void RegisterSDF(global::UnityEngine.RenderTexture rt)
	{
		//IL_00ba: Expected O, but got I4
		//IL_00fb: Expected O, but got F4
		int width = rt.width;
		width = rt.height;
		int length = width * width;
		_sdfField = new global::Unity.Collections.NativeArray<global::Unity.Mathematics.float4>(length, global::Unity.Collections.Allocator.Persistent, default(global::Unity.Collections.NativeArrayOptions));
		global::UnityEngine.Rendering.AsyncGPUReadback.RequestIntoNativeArray(ref _sdfField, rt).WaitForCompletion();
		width = rt.width;
		width = rt.height;
		int num = width | width;
		_sdfRes = (global::Unity.Mathematics.int2)num;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		float num2 = halfBounds.x + halfBounds.x;
		float num3 = (float)width / num2;
		_invWorldPerTexel = (global::Unity.Mathematics.float2)num3;
	}

	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
	[global::Cpp2ILInjected.Token(Token = "0x600025D")]
	[global::Cpp2ILInjected.Address(RVA = "0xFFC160", Offset = "0xFFC160", Length = "0x35C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv54 = worldPos - sdfCenter;\n\tv55 = worldPos.y - sdfCenter.y;\n\tgoto L_002A;\n\tv60 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv61 = v60 + 0x918;\n\tv62 = \"il2cpp_codegen_initialize_runtime_metadata\"(v61, res, phi, n, methodInfo, v64, v65, v66, worldPos, v0, halfBounds, v2, invWorldPerTexel, v4, sdfCenter, v6);\n\tv69 = 1;\n\t*([2DD4429]) = v69;\nL_002A:\n\tv70 = res >> 0x20;\n\tv71 = halfBounds + v54;\n\tv72 = halfBounds.y + v55;\n\tv73 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv75 = *([v73 @ X23_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]);\n\tv77 = *([v75 @ X0_v2+E0]) == 0;\n\tv78 = ~v77;\n\tif (v78) goto L_0038;\n\tv82 = *([2DD4429]) == 0;\n\tif (v82) goto L_012C;\nL_0038:\n\tv105 = invWorldPerTexel * v71;\n\tv106 = invWorldPerTexel.y * v72;\n\tgoto L_0040;\n\tv101 = \"il2cpp_codegen_runtime_class_init\"(v91, res, phi, n, methodInfo, v64, v65, v66, worldPos, v0, halfBounds, v2, invWorldPerTexel, v4, sdfCenter, v6);\nL_0040:\n\tv107 = UnityEngine.Mathf::Floor(v105);\n\tv112 = UnityEngine.Mathf::Floor(v106);\n\tv128 = v107 != 0x7F800000;\n\tif (v128) goto L_FFFFFFFF;\n\tgoto L_005F;\nL_005F:\n\tv141 = v112 != 0x7F800000;\n\tif (v141) goto L_FFFFFFFF;\n\tgoto L_0065;\nL_0065:\n\tv145 = v144 >> 0x17;\n\tv146 = v145 & 0x100;\n\t// 103 NotImplemented \"Instruction BFXIL not yet implemented.\"\n\tv147 = res - 1;\n\tv148 = v70 - 1;\n\tv151 = v148 - v144;\n\tv152 = v151 < 0;\n\tv153 = v151 == 0;\n\tv154 = v148 ^ v144;\n\tv155 = v148 ^ v151;\n\tv156 = v154 & v155;\n\tv157 = v156 < 0;\n\tv158 = v152 == v157;\n\tv159 = ~v153;\n\tv160 = v158 & v159;\n\tv161 = ~v160;\n\tif (v161) goto L_FFFFFFFF;\n\tv164 = v147 - v131;\n\tv180 = v164 < 0;\n\tv179 = v164 == 0;\n\tv167 = v147 ^ v131;\n\tv168 = v147 ^ v164;\n\tv169 = v167 & v168;\n\tv175 = v169 < 0;\n\tgoto L_0087;\nL_0087:\n\tv183 = v180 == v175;\n\tv184 = ~v179;\n\tv185 = v183 & v184;\n\tv186 = ~v185;\n\tif (v186) goto L_FFFFFFFF;\n\tv204 = v146 == 0;\n\tgoto L_009B;\nL_009B:\n\tif (v204) goto L_00A3;\n\t*([phi @ X2 (System.Single&)]) = 0x49742400;\n\t*([n @ X3 (Unity.Mathematics.float2&)]) = 0.0078125d;\n\tgoto L_017F;\nL_00A3:\n\tv212 = v144 * res;\n\tv213 = v131 + v212;\n\tv215 = v213 << 4;\n\tv216 = *([field @ X0 (Unity.Collections.NativeArray`1<Unity.Mathematics.float4>&)]) + v215;\n\tv218 = v213 + 1;\n\tv219 = v218 << 4;\n\tv220 = *([field @ X0 (Unity.Collections.NativeArray`1<Unity.Mathematics.float4>&)]) + v219;\n\tv222 = v213 + res;\n\tv223 = v222 << 4;\n\tv224 = *([field @ X0 (Unity.Collections.NativeArray`1<Unity.Mathematics.float4>&)]) + v223;\n\tv226 = v222 + 1;\n\tv227 = v226 << 4;\n\tv228 = *([field @ X0 (Unity.Collections.NativeArray`1<Unity.Mathematics.float4>&)]) + v227;\n\tv232 = v105 - v131;\n\tv233 = v106 - v144;\n\tv234 = *([v220 @ X13_v3]) - *([v216 @ X12_v3]);\n\tv235 = v232 * v234;\n\tv236 = *([v216 @ X12_v3]) + v235;\n\tv237 = *([v228 @ X10_v9]) - *([v224 @ X14_v2]);\n\tv238 = v232 * v237;\n\tv239 = *([v224 @ X14_v2]) + v238;\n\tv240 = v239 - v236;\n\tv241 = v233 * v240;\n\tv242 = v236 + v241;\n\tv243 = halfBounds.y * v242;\n\tv244 = v243 + v243;\n\tv249 = *([v220 @ X13_v3+4]) - *([v216 @ X12_v3+4]);\n\tv250 = v249 * v251;\n\tv252 = *([v216 @ X12_v3+4]) + v250;\n\tv253 = *([v228 @ X10_v9+4]) - *([v224 @ X14_v2+4]);\n\tv254 = v253 * v251;\n\tv255 = *([v224 @ X14_v2+4]) + v254;\n\tv256 = v255 - v252;\n\tv257 = v256 * v258;\n\tv259 = v252 + v257;\n\t*([phi @ X2 (System.Single&)]) = v244;\n\tv260 = v259 + v259;\n\t// 214 NotImplemented \"Instruction FADDP not yet implemented.\"\n\tv269 = v105 - 0x322BCC77;\n\tv270 = v269 < 0;\n\tv271 = v269 == 0;\n\tv272 = v105 ^ 0x322BCC77;\n\tv273 = v105 ^ v269;\n\tv274 = v272 & v273;\n\tv275 = v274 < 0;\n\tv276 = UnityEngine.Mathf::Abs(v105);\n\tv377 = v270 == v275;\n\tv279 = ~v271;\n\tv378 = v377 & v279;\n\tv305 = ~v378;\n\tif (v305) goto L_FFFFFFFF;\n\tv381 = v276 - 0x7F800000;\n\tv397 = v381 < 0;\n\tgoto L_00FA;\nL_00FA:\n\tif (v397) goto L_013A;\n\tv400 = v234 + *([v228 @ X10_v9]);\n\tv294 = v400 - *([v224 @ X14_v2]);\n\tv350 = halfBounds.y * v294;\n\tv401 = *([v224 @ X14_v2]) - *([v216 @ X12_v3]);\n\tv402 = v401 + *([v228 @ X10_v9]);\n\tv403 = v402 - *([v220 @ X13_v3]);\n\tv345 = halfBounds.y * v403;\n\tv404 = v350 * v350;\n\tv405 = v345 * v345;\n\tv347 = v404 + v405;\n\tv282 = v347 <= 0x2B8CBCCC;\n\tif (v282) goto L_FFFFFFFF;\n\tv428 = 0x2DD4000;\n\tv430 = *([2DD4420]) == 0;\n\tif (v430) goto L_0184;\n\tgoto L_011D;\nL_011D:\n\tv463 = UnityEngine.Mathf::Sqrt(v347);\n\tv478 = 1f / v463;\n\tv334 = v350 * v478;\n\tv359 = v345 * v478;\n\tgoto L_0125;\nL_0125:\n\t*([n @ X3 (Unity.Mathematics.float2&)]) = v334;\n\t*([n @ X3 (Unity.Mathematics.float2&)+4]) = v359;\n\tgoto L_017F;\nL_012C:\n\t*([2DD4429]) = 1;\n\tv105 = invWorldPerTexel * v71;\n\tv106 = invWorldPerTexel.y * v72;\n\tgoto L_0040;\n\tgoto L_FFFFFFFF;\nL_013A:\n\tv417 = v105 - 0x3F7FBE77;\n\tv418 = v417 < 0;\n\tv419 = v417 == 0;\n\tv420 = v105 ^ 0x3F7FBE77;\n\tv421 = v105 ^ v417;\n\tv422 = v420 & v421;\n\tv423 = v422 < 0;\n\tv427 = v418 == v423;\n\tv278 = ~v419;\n\tv281 = v427 & v278;\n\tv304 = ~v281;\n\tif (v304) goto L_FFFFFFFF;\n\tv435 = v105 - 0x3F8020C5;\n\tv322 = v435 < 0;\n\tgoto L_FFFFFFFF;\n\tif (v322) goto L_016D;\n\tgoto L_0167;\n\tv479 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv480 = v479 + 0x918;\n\tv481 = \"il2cpp_codegen_initialize_runtime_metadata\"(v480, res, phi, n, methodInfo, v64, v65, v66, v426, v221, v225, v230, v234, v276, v292, v244);\n\tv484 = 1;\n\t*([2DD4420]) = v484;\nL_0167:\n\tgoto L_0169;\n\tv487 = \"il2cpp_codegen_runtime_class_init\"(v485, res, phi, n, methodInfo, v64, v65, v66, v426, v221, v225, v230, v234, v276, v292, v244);\nL_0169:\n\tv488 = UnityEngine.Mathf::Sqrt(v105);\n\tv349 = v260 * v489;\nL_016D:\n\t*([n @ X3 (Unity.Mathematics.float2&)]) = v349;\nL_017F:\n\treturn;\nL_0184:\n\t*([v428 @ X20_v7+420]) = 1;\n\tgoto L_011D;\n\tv458 = \"il2cpp_codegen_runtime_class_init\"(v464, res, phi, n, methodInfo, v64, v65, v66, v408, v405, v225, v230, v294, v276, v292, v244);\n\tgoto L_011D;\n\treturn;\n// 214 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private unsafe static void SampleSDF(global::Unity.Mathematics.float2 worldPos, in global::Unity.Collections.NativeArray<global::Unity.Mathematics.float4> field, global::Unity.Mathematics.int2 res, global::Unity.Mathematics.float2 halfBounds, global::Unity.Mathematics.float2 invWorldPerTexel, global::Unity.Mathematics.float2 sdfCenter, out float phi, out global::Unity.Mathematics.float2 n)
	{
		global::Unity.Mathematics.float2 texCoord = (worldPos - sdfCenter + halfBounds) * invWorldPerTexel;
		int x0 = (int)global::Unity.Mathematics.math.floor(texCoord.x);
		int y0 = (int)global::Unity.Mathematics.math.floor(texCoord.y);
		if (x0 < 0 || y0 < 0 || x0 >= res.x - 1 || y0 >= res.y - 1)
		{
			phi = 1000000f;
			n = new global::Unity.Mathematics.float2(0f, 1f);
			return;
		}
		float fx = texCoord.x - x0;
		float fy = texCoord.y - y0;
		float scale = halfBounds.y + halfBounds.y;
		float c00 = field[y0 * res.x + x0].x;
		float c10 = field[y0 * res.x + x0 + 1].x;
		float c01 = field[(y0 + 1) * res.x + x0].x;
		float c11 = field[(y0 + 1) * res.x + x0 + 1].x;
		float top = c00 + fx * (c10 - c00);
		float bottom = c01 + fx * (c11 - c01);
		phi = scale * (top + fy * (bottom - top));
		float gx = scale * (c10 - c00 + c11 - c01);
		float gy = scale * (c01 - c00 + c11 - c10);
		float lenSq = gx * gx + gy * gy;
		if (lenSq <= 1E-06f)
		{
			n = new global::Unity.Mathematics.float2(0f, 1f);
			return;
		}
		float invLen = 1f / global::Unity.Mathematics.math.sqrt(lenSq);
		n = new global::Unity.Mathematics.float2(gx * invLen, gy * invLen);
	}

	[global::Cpp2ILInjected.Token(Token = "0x600025E")]
	[global::Cpp2ILInjected.Address(RVA = "0xFFBAC8", Offset = "0xFFBAC8", Length = "0x560")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv80 = *([2C38708]);\n\tv80 = *([v80 @ X8_v7 (System.Collections.Generic.List`1<FluidPhysicsCoupler+BodyInfo>)]);\n\tgoto L_0040;\n\tv53 = Il2CppMethodInfo;\n\tv54 = v53 + 0x5F0;\n\tv55 = \"il2cpp_codegen_initialize_runtime_metadata\"(v54, methodInfo, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70);\n\tv82 = Il2CppMethodInfo;\n\tv83 = v82 + 0x5F8;\n\tv84 = \"il2cpp_codegen_initialize_runtime_metadata\"(v83, methodInfo, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70);\n\tv324 = Il2CppMethodInfo;\n\tv325 = v324 + 0x620;\n\tv326 = \"il2cpp_codegen_initialize_runtime_metadata\"(v325, methodInfo, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70);\n\tv444 = Il2CppMethodInfo;\n\tv445 = v444 + 0x898;\n\tv446 = \"il2cpp_codegen_initialize_runtime_metadata\"(v445, methodInfo, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70);\n\tv450 = Il2CppMethodInfo;\n\tv451 = v450 + 0x88;\n\tv452 = \"il2cpp_codegen_initialize_runtime_metadata\"(v451, methodInfo, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70);\n\tv531 = Il2CppMethodInfo;\n\tv532 = v531 + 0x90;\n\tv533 = \"il2cpp_codegen_initialize_runtime_metadata\"(v532, methodInfo, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70);\n\tv534 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv535 = v534 + 0xFD8;\n\tv536 = \"il2cpp_codegen_initialize_runtime_metadata\"(v535, methodInfo, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70);\n\tv538 = Il2CppMethodInfo;\n\tv539 = v538 + 0xC90;\n\tv540 = \"il2cpp_codegen_initialize_runtime_metadata\"(v539, methodInfo, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70);\n\tv541 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv542 = v541 + 0xA48;\n\tv72 = \"il2cpp_codegen_initialize_runtime_metadata\"(v542, methodInfo, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70);\n\tv74 = 1;\n\t*([302A9F4]) = v74;\nL_0040:\n\tv77 = 0;\n\tv80 = this.bodies;\n\tv89 = v80._version + 1;\n\tv80._size = 0;\n\tv80._version = v89;\n\tv100 = v80._size < 1;\n\tif (v100) goto L_005D;\n\tSystem.Array::Clear(v80._items, 0, v80._size);\nL_005D:\n\tv331 = Il2CppMethodInfo;\n\tgoto L_0066;\n\tv447 = \"il2cpp_codegen_runtime_class_init\"(v332, v231, v87, v229, v59, v60, v61, v62, v76, v64, v65, v66, v67, v68, v69, v70);\nL_0066:\n\tv290 = Singleton`1::get_Instance /* +1 sharing this address */(*([v331 @ X20_v3 (Il2CppMethodInfo)+C90]));\n\tv537 = Il2CppMethodInfo;\n\tv434 = *([v537 @ X8_v11 (Il2CppMethodInfo)+898]);\n\tv292 = UnityEngine.Component::GetComponentsInChildren /* +1 sharing this address */(*([v290 @ X0_v10+78]), 0, *([v537 @ X8_v11 (Il2CppMethodInfo)+898]));\n\tv80 = *([v292 @ X0_v12+18]);\n\tv554 = *([v292 @ X0_v12+18]) < 1;\n\tif (v554) goto L_01D6;\n\tv556 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv558 = &v77 @ stack_-110_v1 (System.Single) | 8;\n\tv220 = &v77 @ stack_-110_v1 (System.Single) | 1;\n\tv560 = &v205 @ stack_-E8 | 1;\n\tv315 = v292 + 0x20;\n\tgoto L_00AB;\nL_008E:\n\tv886 = *([v210 @ X10_v5+20]);\n\tv887 = *([v886 @ X10_v9+C0]);\n\tv434 = *([v887 @ X10_v10+70]);\n\tv560.m_value = v220.m_value;\n\t*([v560 @ X8_v18 (System.Int32)+7]) = v80;\n\tSystem.Collections.Generic.List`1<FluidPhysicsCoupler+BodyInfo>::AddWithResize(v300, &v322 @ X8_v31 (System.Int32));\nL_009F:\n\tv224 = v224 + 1;\n\tv593 = v224 >= *([v292 @ X0_v12+18]);\n\tif (v593) goto L_01D6;\nL_00AB:\n\t;\n\tv622 = Il2CppMethodInfo;\n\tv626 = UnityEngine.Component::GetComponent /* +1 sharing this address */(*([v315 @ X19_v8+v224 @ X26_v6 (System.Int32)*8]), *([v622 @ X8_v20 (Il2CppMethodInfo)+620]));\n\tv627 = Il2CppMethodInfo;\n\tv631 = UnityEngine.Component::GetComponent /* +1 sharing this address */(*([v315 @ X19_v8+v224 @ X26_v6 (System.Int32)*8]), *([v627 @ X8_v22 (Il2CppMethodInfo)+5F8]));\n\tv632 = *([v556 @ X27_v5 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv80 = *([v632 @ X0_v19+E0]);\n\tv634 = *([v632 @ X0_v19+E0]) == 0;\n\tif (v634) goto L_00CA;\n\tv638 = UnityEngine.Object::op_Equality(v626, 0);\n\tv640 = ~v638;\n\tv641 = ~v640;\n\tif (v641) goto L_00CD;\n\tgoto L_00E3;\nL_00CA:\n\tv645 = UnityEngine.Object::op_Equality(v626, 0);\n\tv650 = ~v645;\n\tif (v650) goto L_00E3;\nL_00CD:\n\tv651 = *([v556 @ X27_v5 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv80 = *([v651 @ X0_v66+E0]);\n\tv653 = *([v651 @ X0_v66+E0]) == 0;\n\tif (v653) goto L_00DE;\n\tv662 = UnityEngine.Object::op_Equality(v631, 0);\n\tv677 = v662 == 0;\n\tv665 = ~v677;\n\tif (v665) goto L_009F;\n\tgoto L_00E3;\nL_00DE:\n\tv662 = UnityEngine.Object::op_Equality(v631, 0);\n\tv724 = v662 == 0;\n\tv664 = ~v724;\n\tif (v664) goto L_009F;\nL_00E3:\n\tv667 = *([v556 @ X27_v5 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv80 = *([v667 @ X0_v21+E0]);\n\tv669 = *([v667 @ X0_v21+E0]) == 0;\n\tif (v669) goto L_00F1;\n\tv674 = UnityEngine.Object::op_Implicit(v631);\n\tv679 = ~v674;\n\tv680 = ~v679;\n\tif (v680) goto L_00F4;\n\tgoto L_011F;\nL_00F1:\n\tv683 = UnityEngine.Object::op_Implicit(v631);\n\tv728 = ~v683;\n\tif (v728) goto L_011F;\nL_00F4:\n\tv729 = Il2CppMethodInfo;\n\tv733 = UnityEngine.Component::GetComponent /* +1 sharing this address */(*([v315 @ X19_v8+v224 @ X26_v6 (System.Int32)*8]), *([v729 @ X8_v39 (Il2CppMethodInfo)+5F0]));\n\tv752 = *([v556 @ X27_v5 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv80 = *([v752 @ X0_v51+E0]);\n\tv753 = *([v752 @ X0_v51+E0]) == 0;\n\tif (v753) goto L_010A;\n\tv742 = UnityEngine.Object::op_Inequality(v733, 0);\n\tv769 = ~v742;\n\tv745 = ~v769;\n\tif (v745) goto L_010D;\n\tgoto L_011F;\nL_010A:\n\tv743 = UnityEngine.Object::op_Inequality(v733, 0);\n\tv746 = ~v743;\n\tif (v746) goto L_011F;\nL_010D:\n\tv779 = Il2CppMethodInfo;\n\tv662 = UnityEngine.Component::GetComponent /* +1 sharing this address */(*([v315 @ X19_v8+v224 @ X26_v6 (System.Int32)*8]), *([v779 @ X8_v42 (Il2CppMethodInfo)+5F0]));\n\tv80 = *([v662 @ X0_v71 (System.Boolean)+30]);\n\tv787 = *([v662 @ X0_v71 (System.Boolean)+30]) == 0;\n\tv716 = ~v787;\n\tif (v716) goto L_009F;\nL_011F:\n\tv751 = 0xF3F1B4(v558, *([v315 @ X19_v8+v224 @ X26_v6 (System.Int32)*8]), v738, 0, v59, v60, v61, v62, 0, v569, v568, v66, v67, v68, v69, v70);\n\tv80 = *([v220 @ X28_v5 (System.Int32)+7]);\n\tv760 = *([v556 @ X27_v5 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv80 = *([v760 @ X0_v25+E0]);\n\tv761 = *([v760 @ X0_v25+E0]) == 0;\n\tif (v761) goto L_017D;\n\tv767 = UnityEngine.Object::op_Inequality(v626, 0);\n\tv771 = ~v767;\n\tif (v771) goto L_0185;\nL_0138:\n\tv296 = UnityEngine.Component::get_transform(v626);\n\tv173 = UnityEngine.Transform::get_lossyScale(v296);\n\tv297 = UnityEngine.Component::get_transform(v626);\n\tv856 = UnityEngine.Mathf::Abs(v173);\n\tv810 = UnityEngine.Transform::get_lossyScale(v297);\n\tv569 = v810.y;\n\tv568 = v810.z;\n\tv816 = UnityEngine.Mathf::Abs(v810.y);\n\tv820 = v810.y & 0x7FFFFFFF;\n\tv823 = v856 - v816;\n\tv824 = v823 < 0;\n\tv825 = v823 == 0;\n\tv826 = v856 ^ v816;\n\tv827 = v856 ^ v823;\n\tv828 = v826 & v827;\n\tv829 = v828 < 0;\n\tv831 = v824 == v829;\n\tv832 = ~v831;\n\tv833 = v832 | v825;\n\tv834 = ~v833;\n\tif (v834) goto L_FFFFFFFF;\n\tv842 = v820 < 0x7F800000;\n\tv868 = ~v842;\n\tv844 = v820 - 0x7F800000;\n\tv865 = v844 == 0;\n\tgoto L_016B;\nL_016B:\n\tv874 = ~v865;\n\tv860 = v868 & v874;\n\tv855 = ~v860;\n\tif (v855) goto L_FFFFFFFF;\n\tgoto L_0175;\nL_0175:\n\tv580 = UnityEngine.CircleCollider2D::get_radius(v626);\n\tv148 = v580 * v856;\n\tgoto L_01A7;\nL_017D:\n\tv775 = UnityEngine.Object::op_Inequality(v626, 0);\n\tv784 = ~v775;\n\tv782 = ~v784;\n\tif (v782) goto L_0138;\nL_0185:\n\tv299 = UnityEngine.Component::get_transform(v631);\n\tv790 = UnityEngine.Transform::get_lossyScale(v299);\n\tv798 = UnityEngine.Collider2D::get_offset(v631);\n\tv804 = UnityEngine.BoxCollider2D::get_size(v631);\n\tv808 = UnityEngine.Mathf::Abs(v790);\n\tv813 = UnityEngine.BoxCollider2D::get_size(v631);\n\tv818 = UnityEngine.Mathf::Abs(v790.y);\n\tv835 = v804 * 0.5f;\n\tv568 = v835 * v808;\n\tv569 = v813.y * 0.5f;\n\tv580 = v569 * v818;\nL_01A7:\n\tv300 = this.bodies;\n\tv875 = Il2CppMethodInfo;\n\tv210 = *([v875 @ X9_v13 (Il2CppMethodInfo)+88]);\n\tv279 = v300._version + 1;\n\tv300._version = v279;\n\tv110 = v300._items;\n\tv713 = v179 | v144;\n\tv881 = v300._size < v110.Length;\n\tv712 = ~v881;\n\tif (v712) goto L_008E;\n\tv882 = v300._size + 1;\n\tv300._s\n// ... truncated")]
	public unsafe void RefreshBodies()
	{
		bodies.Clear();
		global::GameManager instance = global::Singleton<global::GameManager>.Instance;
		if (instance == null || instance.level == null)
		{
			return;
		}
		global::UnityEngine.Rigidbody2D[] array = instance.level.GetComponentsInChildren<global::UnityEngine.Rigidbody2D>(false);
		for (int i = 0; i < array.Length; i++)
		{
			global::UnityEngine.Rigidbody2D rigidbody2D = array[i];
			if (rigidbody2D == null || !rigidbody2D.simulated)
			{
				continue;
			}
			global::UnityEngine.CircleCollider2D circleCollider2D = rigidbody2D.GetComponent<global::UnityEngine.CircleCollider2D>();
			global::UnityEngine.BoxCollider2D boxCollider2D = rigidbody2D.GetComponent<global::UnityEngine.BoxCollider2D>();
			FluidPhysicsCoupler.BodyInfo bodyInfo = default(FluidPhysicsCoupler.BodyInfo);
			bodyInfo.body = rigidbody2D;
			if (circleCollider2D != null)
			{
				float scale = global::UnityEngine.Mathf.Abs(circleCollider2D.transform.lossyScale.y);
				bodyInfo.shape = FluidPhysicsCoupler.Shape.Circle;
				bodyInfo.radiusWS = circleCollider2D.radius * scale;
				bodyInfo.localOffset = circleCollider2D.offset;
			}
			else
			{
				if (boxCollider2D == null)
				{
					continue;
				}
				global::UnityEngine.Vector3 lossyScale = boxCollider2D.transform.lossyScale;
				global::UnityEngine.Vector2 size = boxCollider2D.size;
				bodyInfo.shape = FluidPhysicsCoupler.Shape.Box;
				bodyInfo.halfExtentsLS = new global::Unity.Mathematics.float2(size.x * 0.5f * global::UnityEngine.Mathf.Abs(lossyScale.x), size.y * 0.5f * global::UnityEngine.Mathf.Abs(lossyScale.y));
				bodyInfo.localOffset = boxCollider2D.offset;
			}
			bodies.Add(bodyInfo);
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x600025F")]
	[global::Cpp2ILInjected.Address(RVA = "0xFFC4BC", Offset = "0xFFC4BC", Length = "0x64")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = UnityEngine.Time::get_deltaTime();\n\tv19 = this.accumulator + v18;\n\tthis.accumulator = v19;\n\tv31 = v19 < this.fixedDeltaTime;\n\tif (v31) goto L_0033;\nL_001D:\n\tFluidPhysicsCoupler::Step(this, this.fixedDeltaTime);\n\tv51 = this.accumulator - this.fixedDeltaTime;\n\tthis.accumulator = v51;\n\tv33 = v51 >= this.fixedDeltaTime;\n\tif (v33) goto L_001D;\nL_0033:\n\treturn;\n// 41 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void Update()
	{
		float deltaTime = global::UnityEngine.Time.deltaTime;
		if (!((accumulator += deltaTime) < fixedDeltaTime))
		{
			do
			{
				Step(fixedDeltaTime);
			}
			while (!((accumulator -= fixedDeltaTime) < fixedDeltaTime));
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000260")]
	[global::Cpp2ILInjected.Address(RVA = "0xFFC520", Offset = "0xFFC520", Length = "0x8E4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv40 = &v41 @ stack_-10_v2;\n\tv47 = *([2C38708]);\n\t*([v40 @ X29_v1-A0]) = *([v47 @ X8_v2]);\n\tgoto L_005C;\n\tv54 = Il2CppMethodInfo;\n\tv55 = v54 + 0x558;\n\tv56 = \"il2cpp_codegen_initialize_runtime_metadata\"(v55, methodInfo, v58, v59, v60, v61, v62, v63, dt, v64, v65, v66, v67, v68, v69, v70);\n\tv97 = Il2CppMethodInfo;\n\tv98 = v97 + 0x300;\n\tv99 = \"il2cpp_codegen_initialize_runtime_metadata\"(v98, methodInfo, v58, v59, v60, v61, v62, v63, dt, v64, v65, v66, v67, v68, v69, v70);\n\tv645 = Il2CppMethodInfo;\n\tv646 = v645 + 0x308;\n\tv647 = \"il2cpp_codegen_initialize_runtime_metadata\"(v646, methodInfo, v58, v59, v60, v61, v62, v63, dt, v64, v65, v66, v67, v68, v69, v70);\n\tv798 = Il2CppMethodInfo;\n\tv799 = v798 + 0x98;\n\tv800 = \"il2cpp_codegen_initialize_runtime_metadata\"(v799, methodInfo, v58, v59, v60, v61, v62, v63, dt, v64, v65, v66, v67, v68, v69, v70);\n\tv801 = Il2CppMethodInfo;\n\tv802 = v801 + 0xA0;\n\tv803 = \"il2cpp_codegen_initialize_runtime_metadata\"(v802, methodInfo, v58, v59, v60, v61, v62, v63, dt, v64, v65, v66, v67, v68, v69, v70);\n\tv923 = Il2CppMethodInfo;\n\tv924 = v923 + 0xB78;\n\tv925 = \"il2cpp_codegen_initialize_runtime_metadata\"(v924, methodInfo, v58, v59, v60, v61, v62, v63, dt, v64, v65, v66, v67, v68, v69, v70);\n\tv932 = Il2CppMethodInfo;\n\tv933 = v932 + 0xB88;\n\tv934 = \"il2cpp_codegen_initialize_runtime_metadata\"(v933, methodInfo, v58, v59, v60, v61, v62, v63, dt, v64, v65, v66, v67, v68, v69, v70);\n\tv946 = Il2CppMethodInfo;\n\tv947 = v946 + 0xB70;\n\tv948 = \"il2cpp_codegen_initialize_runtime_metadata\"(v947, methodInfo, v58, v59, v60, v61, v62, v63, dt, v64, v65, v66, v67, v68, v69, v70);\n\tv992 = Il2CppMethodInfo;\n\tv993 = v992 + 0xB80;\n\tv994 = \"il2cpp_codegen_initialize_runtime_metadata\"(v993, methodInfo, v58, v59, v60, v61, v62, v63, dt, v64, v65, v66, v67, v68, v69, v70);\n\tv998 = System.Runtime.Serialization.ObjectHolderList;\n\tv999 = v998 + 0x258;\n\tv1000 = \"il2cpp_codegen_initialize_runtime_metadata\"(v999, methodInfo, v58, v59, v60, v61, v62, v63, dt, v64, v65, v66, v67, v68, v69, v70);\n\tv1005 = CollectParticleData[];\n\tv1006 = v1005 + 0x4B8;\n\tv1007 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1006, methodInfo, v58, v59, v60, v61, v62, v63, dt, v64, v65, v66, v67, v68, v69, v70);\n\tv1023 = CollectParticleData[];\n\tv1024 = v1023 + 0x648;\n\tv1025 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1024, methodInfo, v58, v59, v60, v61, v62, v63, dt, v64, v65, v66, v67, v68, v69, v70);\n\tv1038 = System.Xml.ValidateNames;\n\tv1039 = v1038 + 0xD40;\n\tv72 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1039, methodInfo, v58, v59, v60, v61, v62, v63, dt, v64, v65, v66, v67, v68, v69, v70);\n\tv74 = 1;\n\t*([302A9F5]) = v74;\nL_005C:\n\t*([v40 @ X29_v1-B0]) = 0;\n\t*([v40 @ X29_v1-A8]) = 0;\n\tv93 = 0;\n\tFluidSolver::Step(this.solver, dt);\n\tFluidPhysicsCoupler::Shuffle(this, this.bodies);\n\tv630 = this.solver;\n\tv540 = v630.positions;\n\tv631 = this.bodies;\n\tv926 = Il2CppMethodInfo;\n\tUnity.Collections.NativeArray`1<FluidPhysicsCoupler+BodyData>::.ctor(&v520 @ stack_-1A0_v4 (Unity.Collections.NativeArray`1<FluidPhysicsCoupler+BodyData>), v631._size, 3, 1);\n\tv945 = v631._size < 1;\n\tif (v945) goto L_0184;\n\tv414 = v631._size << 3;\n\tv952 = v631._size + v414;\n\tv406 = v952 << 3;\n\tv953 = Facebook.Unity.Windows.IWindowsFacebook;\n\tgoto L_00E6;\nL_009B:\n\tv971 = -v1082;\n\tv1671 = UnityEngine.Rigidbody2D::get_velocity(v591.body);\n\tv1682 = Unity.Mathematics.float2::op_Implicit(v1671);\n\tv1689 = UnityEngine.Rigidbody2D::get_angularVelocity(v591.body);\n\tv967 = v1689 * 0x3C8EFA35;\n\tv987 = UnityEngine.Rigidbody2D::get_bodyType(v591.body);\n\tv1700 = v987 == 0;\n\tv991 = v520 + v420;\n\t*([v991 @ X8_v78]) = v354;\n\tv974 = ~v1700;\n\t*([v991 @ X8_v78+3]) = 0;\n\t*([v991 @ X8_v78+1]) = 0;\n\t*([v991 @ X8_v78+4]) = v1591;\n\t*([v991 @ X8_v78+8]) = v1591.y;\n\t*([v991 @ X8_v78+C]) = v1082;\n\t*([v991 @ X8_v78+10]) = v971;\n\t*([v991 @ X8_v78+14]) = v1082;\n\t*([v991 @ X8_v78+18]) = v1082;\n\t*([v991 @ X8_v78+1C]) = *([v634 @ X8_v61+FF]);\n\t*([v991 @ X8_v78+24]) = v591.radiusWS;\n\t*([v991 @ X8_v78+28]) = v955;\n\t*([v991 @ X8_v78+2C]) = v966;\n\t*([v991 @ X8_v78+30]) = v1682;\n\t*([v991 @ X8_v78+34]) = v1682.y;\n\t*([v991 @ X8_v78+38]) = v967;\n\t*([v991 @ X8_v78+3C]) = v959;\n\t*([v991 @ X8_v78+40]) = v1576;\n\t*([v991 @ X8_v78+44]) = v974;\n\t*([v991 @ X8_v78+47]) = 0;\n\tv420 = v420 + 0x48;\n\tv428 = v428 + 1;\n\t*([v991 @ X8_v78+45]) = 0;\n\tv979 = v406 == v420;\n\tif (v979) goto L_0184;\nL_00E6:\n\tv1001 = Il2CppMethodInfo;\n\tv591 = System.Collections.Generic.List`1<FluidPhysicsCoupler+BodyInfo>::get_Item(this.bodies, v428);\n\tv354 = v591.shape;\n\tv634 = &v1026 @ stack_-24B;\n\tv592 = UnityEngine.Component::get_transform(v591.body);\n\tv1043 = UnityEngine.Transform::get_eulerAngles(v592);\n\tv1051 = *([2DD442F]) == 0;\n\tif (v1051) goto L_0160;\n\tthis = *([v953 @ X22_v13 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]);\n\tgoto L_0113;\nL_0113:\n\tv1082 = v1043.z * 0xBC8EFA35;\n\tthis = 0x274B04C(this, 0, *([v1001 @ X8_v58 (Il2CppMethodInfo)+A0]), 1, *([v926 @ X9_v3 (Il2CppMethodInfo)+B70]), v61, v62, v63, v1082, v1043.y, v1043.z, v960, v67, v68, v69, v70);\n\tv1159 = *([2DD4430]) == 0;\n\tif (v1159) goto L_016B;\n\tthis = *([v953 @ X22_v13 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]);\n\tgoto L_0121;\nL_0121:\n\tthis = 0x274A374(this, 0, *([v1001 @ X8_v58 (Il2CppMethodInfo)+A0]), 1, *([v926 @ X9_v3 (Il2CppMethodInfo)+B70]), v61, v62, v63, v1082, v1043.y, v1043.z, v960, v67, v68, v69, v70);\n\tv1487 = v354 != 1;\n\tif (v1487) goto L_013D;\n\tv1555 = Unity.Mathematics.float2::op_Implicit(v591.localOffset);\n\tv1568 = v1555 * v1082;\n\tv960 = v1555.y * v1082;\n\tv1570 = v1568 - v960;\n\tv1572 = v1555 * v1082;\n\tv1573 = v1555.y * v1082;\n\tv1576 = v1572 + v1573;\n\tgoto L_0147;\nL_013D:\n\tv1556 = System.Xml.ValidateNames;\n\tv1558 = *([v1556 @ X8_v79 (Il2CppClass<System.Xml.ValidateNames>)+D40]);\n\tv1559 = *([v1558 @ X8_v81+B8]);\n\tv1576 = *([v1559 @ X8_v82+4]);\nL_0147:\n\tv1581 = UnityEngine.Rigidbody2D::get_worldCenterOfMass(v591.body);\n\tv1591 = Unity.Mathematics.float2::op_Implicit(v1581);\n\tv1598 = UnityEngine.Rigidbody2D::get_bodyType(v591.body);\n\tv1639 = v1598 == 0;\n\tif (v1639) goto L_0175;\n\tv1645 = UnityEngine.Rigidbody2D::get_bodyType(v591.body);\n\tv1649 = v1645 == 0;\n\tv1650 = ~v1649;\n\tif (v1650) goto L_009B;\n\tgoto L_0180;\nL_0160:\n\t*([2DD442F]) = 1;\n\tthis = *([v953 @ X22_v13 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]);\n\tgoto L_0113;\n\tv1072 = \"il2cpp_codegen_runtime_class_init\"(v1086, v1042, v552, v516, v522, v61, v62, v63, v1043, v1047, v1048, v209, v67, v68, v69, v70);\n\tgoto L_0113;\nL_016B:\n\t*([2DD4430]) = 1;\n\tthis = *([v953 @ X22_v13 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]);\n\tgoto L_0121;\n\tv1396 = \"il2cpp_codegen_runtime_class_init\"(v1405, v1042, v552, v516, v522, v61, v62, v63, v1084, v1047, v1048, v209, v67, v68, v69, v70);\n\tgoto L_0121;\nL_0175:\n\tv1648 = UnityEngine.Rigidbody2D::get_mass(v591.body);\n\tv955 = 1f / v1648;\n\tv1655 = UnityEngine.Rigidbody2D::get_bodyType(v591.body);\n\tv1672 = v1655 == 0;\n\tv1667 = ~v1672;\n\tif (v1667) goto L_009B;\nL_0180:\n\tv1664 = UnityEngine.Rigidbody2D::get_inertia(v591.body);\n\tv966 = 1f / v1664;\n\tgoto L_009B;\nL_0184:\n\tv635 = this.solver;\n\tUnity.Collections.NativeArray`1<FluidPhysicsCoupler+ForceBundle>::.ctor(&v188 @ stack_-1B0_v4 (Unity.Collections.NativeArray`1<FluidPhysicsCoupler+ForceBundle>), v635.<ActiveCount>k__BackingField, 3, 1);\n\tv1008 = Il2CppMethodInfo;\n\tv1010 = CollectParticleData[];\n\tv1012 = CollectParticleData[];\n\t// 428 MakeStruct v176 @ AGGFFC9F8_0_v3 (UnityEngine.Vector2), typeof(UnityEngine.Vector2), this.halfBounds (UnityEngine.Vector2), this.halfBounds.y (System.Single)\n\tv1022 = Unity.Mathematics.float2::op_Implicit(v176);\n\tv782 = v1022.y;\n\t*([v40 @ X29_v1-B0]) = this._sdfField;\n\tv1037 = Unity.Jobs.IJobParallelForExtensions::Schedule(&v540 @ V1_v3 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>), v635.<ActiveCount>k__BackingField, 0x40, 0);\n\tUnity.Jobs.JobHandle::Complete(&v1037 @ X0_v13 (Unity.Jobs.JobHandle));\n\tthis = *([v1010 @ X22_v4 (Il2CppClass<CollectParticleData[]>)+648]);\n\tv1046 = \"SzArrayNew\"(*([v1010 @ X22_v4 (Il2CppClass<CollectParticleData[]>)+648]), v631._size, 0x40, 0, 0, *([v1008 @ X23_v4\n// ... truncated")]
	private unsafe void Step(float dt)
	{
		solver.Step(dt);
		Shuffle(bodies);
		FluidSolver fluidSolver = solver;
		global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> positionsArray = fluidSolver.positions;
		global::System.Collections.Generic.List<FluidPhysicsCoupler.BodyInfo> list = bodies;
		global::Unity.Collections.NativeArray<FluidPhysicsCoupler.BodyData> bodyDataArray = new global::Unity.Collections.NativeArray<FluidPhysicsCoupler.BodyData>(list.Count, global::Unity.Collections.Allocator.TempJob);
		for (int i = 0; i < list.Count; i++)
		{
			FluidPhysicsCoupler.BodyInfo bodyInfo = list[i];
			global::UnityEngine.Rigidbody2D body = bodyInfo.body;
			float angle = (0f - body.transform.eulerAngles.z) * ((float)global::System.Math.PI / 180f);
			float cosA = global::UnityEngine.Mathf.Cos(angle);
			float sinA = global::UnityEngine.Mathf.Sin(angle);
			global::Unity.Mathematics.float2x2 rotation = new global::Unity.Mathematics.float2x2(cosA, 0f - sinA, sinA, cosA);
			global::Unity.Mathematics.float2 offsetWS = global::Unity.Mathematics.math.mul(rotation, bodyInfo.localOffset);
			bool isDynamic = body.bodyType == global::UnityEngine.RigidbodyType2D.Dynamic;
			FluidPhysicsCoupler.BodyData bodyData = default(FluidPhysicsCoupler.BodyData);
			bodyData.shape = bodyInfo.shape;
			bodyData.com = body.worldCenterOfMass;
			bodyData.R = rotation;
			bodyData.halfExtents = bodyInfo.halfExtentsLS;
			bodyData.radius = bodyInfo.radiusWS;
			bodyData.invMass = isDynamic ? (1f / body.mass) : 0f;
			bodyData.invInertia = isDynamic ? (1f / body.inertia) : 0f;
			bodyData.vel = body.velocity;
			bodyData.angVel = body.angularVelocity * ((float)global::System.Math.PI / 180f);
			bodyData.offsetWS = offsetWS;
			bodyData.isKinematic = !isDynamic;
			bodyDataArray[i] = bodyData;
		}
		global::Unity.Collections.NativeArray<FluidPhysicsCoupler.ForceBundle> resultArray = new global::Unity.Collections.NativeArray<FluidPhysicsCoupler.ForceBundle>(fluidSolver.ActiveCount, global::Unity.Collections.Allocator.TempJob);
		FluidPhysicsCoupler.CouplerJob couplerJob = default(FluidPhysicsCoupler.CouplerJob);
		couplerJob.positions = positionsArray;
		couplerJob.velocities = fluidSolver.velocities;
		couplerJob.bodies = bodyDataArray;
		couplerJob.result = resultArray;
		couplerJob.isStatic = fluidSolver.isStatic;
		couplerJob.invFluidMass = (fluidSolver.particleMass > 0f) ? (1f / fluidSolver.particleMass) : 0f;
		couplerJob.restitution = surfaceFriction;
		couplerJob.dt = dt;
		couplerJob.particleRadius = particleCollisionRadius;
		couplerJob.mu = surfaceFriction;
		couplerJob.halfBounds = halfBounds;
		couplerJob.sdf = _sdfField;
		couplerJob.sdfRes = _sdfRes;
		couplerJob.invWorldPerTexel = _invWorldPerTexel;
		couplerJob.sdfCenter = _sdfCenter;
		global::Unity.Jobs.IJobParallelForExtensions.Schedule(couplerJob, fluidSolver.ActiveCount, 64).Complete();
		for (int j = 0; j < list.Count; j++)
		{
			FluidPhysicsCoupler.BodyInfo bodyInfo2 = list[j];
			if (bodyInfo2.body.bodyType == global::UnityEngine.RigidbodyType2D.Dynamic)
			{
				FluidPhysicsCoupler.ForceBundle forceBundle = resultArray[j];
				bodyInfo2.body.AddForce((global::UnityEngine.Vector2)forceBundle.force, global::UnityEngine.ForceMode2D.Force);
				bodyInfo2.body.AddTorque(forceBundle.torque, global::UnityEngine.ForceMode2D.Force);
			}
		}
		resultArray.Dispose();
		if (positionIterations >= 1)
		{
			FluidPhysicsCoupler.PositionProjectJob positionProjectJob = default(FluidPhysicsCoupler.PositionProjectJob);
			positionProjectJob.positions = positionsArray;
			positionProjectJob.bodies = bodyDataArray;
			positionProjectJob.particleRadius = particleCollisionRadius;
			positionProjectJob.halfBounds = halfBounds;
			positionProjectJob.percent = 0.2f;
			positionProjectJob.sdf = _sdfField;
			positionProjectJob.sdfRes = _sdfRes;
			positionProjectJob.invWorldPerTexel = _invWorldPerTexel;
			positionProjectJob.sdfCenter = _sdfCenter;
			positionProjectJob.isStatic = fluidSolver.isStatic;
			for (int k = 0; k < positionIterations; k++)
			{
				global::Unity.Jobs.IJobParallelForExtensions.Schedule(positionProjectJob, fluidSolver.ActiveCount, 64).Complete();
			}
		}
		bodyDataArray.Dispose();
		global::UnityEngine.Physics2D.Simulate(dt);
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000261")]
	[global::Cpp2ILInjected.Address(RVA = "0xFFDB00", Offset = "0xFFDB00", Length = "0x6C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0015;\n\tv17 = Il2CppMethodInfo;\n\tv18 = v17 + 0xB60;\n\tv19 = \"il2cpp_codegen_initialize_runtime_metadata\"(v18, methodInfo, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34);\n\tv42 = Il2CppMethodInfo;\n\tv43 = v42 + 0xB68;\n\tv36 = \"il2cpp_codegen_initialize_runtime_metadata\"(v43, methodInfo, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34);\n\tv38 = 1;\n\t*([302A9F6]) = v38;\nL_0015:\n\tv39 = this + 0x58;\n\tv41 = *([v39 @ X19_v2 (Unity.Collections.NativeArray`1<Unity.Mathematics.float4>)]) == 0;\n\tif (v41) goto L_0029;\n\tUnity.Collections.NativeArray`1<Unity.Mathematics.float4>::Dispose(v39);\n\treturn;\nL_0029:\n\treturn;\n// 27 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private unsafe void OnDestroy()
	{
		//IL_001d: Expected O, but got I
		if (_sdfField.IsCreated)
		{
			_sdfField.Dispose();
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000262")]
	[global::Cpp2ILInjected.Address(RVA = "0xFFDB6C", Offset = "0xFFDB6C", Length = "0xB4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tgoto L_001D;\n\tv25 = Il2CppMethodInfo;\n\tv26 = v25 + 0x80;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv54 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv55 = v54 + 0x628;\n\tv44 = \"il2cpp_codegen_initialize_runtime_metadata\"(v55, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv46 = 1;\n\t*([302A9F7]) = v46;\nL_001D:\n\tthis.fixedDeltaTime = 0.007812501735752448d;\n\tthis.slop = 0.05f;\n\tthis.halfBounds = 0;\n\tv53 = new *([v18 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+628])();\n\tSystem.Collections.Generic.List`1<FluidPhysicsCoupler+BodyInfo>::.ctor(v53);\n\tv59 = this + 0x40;\n\tthis.bodies = v53;\n\tv61 = 0xF3F1B4(v59, v53, v29, v30, v31, v32, v33, v34, 0, v36, v37, v38, v39, v40, v41, v42);\n\tthis.particleCollisionRadius = 1f;\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 37 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public FluidPhysicsCoupler()
	{
		fixedDeltaTime = 0.005f;
		surfaceFriction = 1f;
		slop = 0.05f;
		halfBounds = default(global::UnityEngine.Vector2);
		global::System.Collections.Generic.List<FluidPhysicsCoupler.BodyInfo> list = new global::System.Collections.Generic.List<FluidPhysicsCoupler.BodyInfo>();
		bodies = list;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		particleCollisionRadius = 1f;
	}
}
