[global::Cpp2ILInjected.Token(Token = "0x2000045")]
public class Caterpillar : RotatingSpecialFluid
{
	[global::Cpp2ILInjected.Token(Token = "0x4000106")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public global::UnityEngine.ParticleSystem dust;

	[global::Cpp2ILInjected.Token(Token = "0x4000107")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public global::UnityEngine.Transform levelBottomTransform;

	[global::Cpp2ILInjected.Token(Token = "0x6000181")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE9368", Offset = "0xFE9368", Length = "0x100")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv34 = 0x302A000;\n\tv36 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv38 = T & 1;\n\tv39 = v38 == 0;\n\tif (v39) goto L_002D;\n\tv64 = Il2CppMethodInfo + 0xC90;\n\tthis.id = _id;\n\tv42 = *([v36 @ X25_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A48]);\n\tv44 = *([v42 @ X0_v22+E0]) == 0;\n\tif (v44) goto L_0038;\nL_0021:\n\tv83 = Singleton`1::get_Instance /* +1 sharing this address */(*([v64 @ X26_v8]));\n\tv76 = v83 == 0;\n\tv77 = ~v76;\n\tif (v77) goto L_003B;\n\tgoto L_0056;\nL_002D:\n\t*([v34 @ X26_v1+977]) = 1;\n\tv64 = Il2CppMethodInfo + 0xC90;\n\tthis.id = _id;\n\tv59 = *([v36 @ X25_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A48]);\n\tv82 = *([v59 @ X0_v18+E0]) == 0;\n\tv61 = ~v82;\n\tif (v61) goto L_0021;\nL_0038:\n\tv83 = Singleton`1::get_Instance /* +1 sharing this address */(*([v71 @ X26_v5]));\nL_003B:\n\tv88 = *([v83 @ X0_v3+78]);\n\tv97 = this + 0xD0;\n\tthis.levelBottomTransform = *([v88 @ X8_v4+108]);\n\tv98 = 0xF3F1B4(v97, *([v88 @ X8_v4+108]), _particleIds, _fluidType, _compute, _id, methodInfo, v49, v50, v51, v52, v53, v54, v55, v56, v57);\n\tSpecialFluid::Init(this, _solver, _particleIds, _fluidType, _compute);\n\treturn;\nL_0056:\n\tthrow System.NullReferenceException;\n// 58 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void Init(FluidSolver _solver, global::System.Collections.Generic.HashSet<int> _particleIds, int _fluidType, FluidCompute _compute, int _id)
	{
		//IL_0009: Expected O, but got I4
		//IL_0017: Expected I, but got O
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected I4, but got Unknown
		//IL_00e4: Expected O, but got I
		//IL_00fe: Expected O, but got I
		//IL_0054: Expected O, but got I
		//IL_006e: Expected O, but got I
		//IL_0155: Expected O, but got I
		//IL_0166: Expected O, but got I
		//IL_0178: Expected O, but got I
		object obj = 50503680;
		nint num = (nint)typeof(global::System.Collections.Generic.List<global::UnityEngine.UIElements.StyleSheets.Syntax.Expression>);
		if ((typeof(_00210) & 1) != 0)
		{
			object obj2 = (nint)0 + (nint)3216;
			id = _id;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X25_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A48]");
			object obj3 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v22+E0]");
			bool flag = (nint)0 == 0;
			object obj4 = obj2;
			if (!flag)
			{
				goto IL_009b;
			}
		}
		else
		{
			_ = 1;
			object obj2 = (nint)0 + (nint)3216;
			id = _id;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X25_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A48]");
			object obj5 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v18+E0]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			object obj4 = obj2;
			if (flag3)
			{
				goto IL_009b;
			}
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
		goto IL_0145;
		IL_0145:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v3+78]");
		object obj6 = 0;
		object obj7 = (nint)this + 208;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v4+108]");
		levelBottomTransform = (global::UnityEngine.Transform)0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		base.Init(_solver, _particleIds, _fluidType, _compute);
		return;
		IL_009b:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
		object obj8 = default(object);
		if (obj8 == null)
		{
			throw new global::System.NullReferenceException();
		}
		goto IL_0145;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000182")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE9468", Offset = "0xFE9468", Length = "0x2B4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0027;\n\tv37 = Il2CppMethodInfo;\n\tv38 = v37 + 0xF8;\n\tv39 = \"il2cpp_codegen_initialize_runtime_metadata\"(v38, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);\n\tv61 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv62 = v61 + 0xFD8;\n\tv63 = \"il2cpp_codegen_initialize_runtime_metadata\"(v62, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);\n\tv67 = Il2CppMethodInfo;\n\tv68 = v67 + 0xC80;\n\tv69 = \"il2cpp_codegen_initialize_runtime_metadata\"(v68, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);\n\tv71 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv72 = v71 + 0xA40;\n\tv56 = \"il2cpp_codegen_initialize_runtime_metadata\"(v72, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);\n\tv58 = 1;\n\t*([302A978]) = v58;\nL_0027:\n\tRotatingSpecialFluid::OnPreComputeUpdate(this);\n\tv66 = UnityEngine.Component::get_transform(this);\n\tv74 = UnityEngine.Transform::get_position(v66);\n\tv168 = UnityEngine.Component::get_transform(this);\n\tv274 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv279 = this.id * 0x36A7C5AC;\n\tv147 = v279 + -6f;\n\t// 69 MakeStruct v135 @ AGGFE9540_1_v2 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), v74 @ V0_v2 (UnityEngine.Vector3), v74.y (System.Single), v147 @ V2_v3 (System.Single)\n\tUnityEngine.Transform::set_position(v168, v135);\n\tv282 = *([v274 @ X21_v2 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv283 = *([v282 @ X0_v9+E0]) == 0;\n\tif (v283) goto L_0058;\n\tv287 = UnityEngine.Object::op_Inequality(this.levelBottomTransform, 0);\n\tv289 = ~v287;\n\tv290 = ~v289;\n\tif (v290) goto L_0060;\n\tgoto L_00F0;\nL_0058:\n\tv294 = UnityEngine.Object::op_Inequality(this.levelBottomTransform, 0);\n\tv297 = ~v294;\n\tif (v297) goto L_00F0;\nL_0060:\n\tv158 = UnityEngine.Transform::get_position(this.levelBottomTransform);\n\tv106 = this.min.y >= v158.y;\n\tif (v106) goto L_00F0;\n\tgoto L_0076;\n\tv306 = \"il2cpp_codegen_runtime_class_init\"(v302, v164, v132, v42, v43, v44, v45, v46, v158, v153, v148, v50, v51, v52, v53, v54);\nL_0076:\n\tv308 = Il2CppMethodInfo;\n\tv170 = Singleton`1::get_Instance /* +1 sharing this address */(*([v308 @ X8_v10 (Il2CppMethodInfo)+C80]));\n\t// 126 MakeStruct v103 @ AGGFE95D0_1_v2 (UnityEngine.Vector2), typeof(UnityEngine.Vector2), this.position (UnityEngine.Vector2), this.position.y (System.Single)\n\tCollectionManager::OnCollectCaterpillar(v170, v103);\n\tv171 = UnityEngine.Component::get_transform(this);\n\tv312 = UnityEngine.Transform::get_position(v171);\n\tgoto L_0097;\n\tv322 = System.Xml.ValidateNames;\n\tv323 = v322 + 0xD0;\n\tv324 = \"il2cpp_codegen_initialize_runtime_metadata\"(v323, v311, v132, v42, v43, v44, v45, v46, v312, v313, v314, v50, v51, v52, v53, v54);\n\tv327 = 1;\n\t*([2DD4422]) = v327;\nL_0097:\n\tv328 = System.Xml.ValidateNames;\n\tv330 = *([v328 @ X8_v14 (Il2CppClass<System.Xml.ValidateNames>)+D0]);\n\tv331 = *([v330 @ X8_v16+B8]);\n\tv336 = *([v331 @ X8_v17+54]) * 3f;\n\tv337 = *([v331 @ X8_v17+58]) * 3f;\n\tv338 = *([v331 @ X8_v17+5C]) * 3f;\n\tgoto L_00AC;\n\tv342 = System.Runtime.Serialization.ObjectHolderList;\n\tv343 = v342 + 0x538;\n\tv344 = \"il2cpp_codegen_initialize_runtime_metadata\"(v343, v311, v132, v42, v43, v44, v45, v46, v332, v333, v334, v335, v51, v52, v53, v54);\n\tv347 = 1;\n\t*([2DD4418]) = v347;\nL_00AC:\n\tv144 = v312 + v336;\n\tv140 = v312.y + v337;\n\tv100 = v312.z + v338;\n\tv348 = System.Runtime.Serialization.ObjectHolderList;\n\tv350 = *([v348 @ X8_v20 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+538]);\n\tv351 = *([v350 @ X8_v22+B8]);\n\tgoto L_00BD;\n\tv356 = \"il2cpp_codegen_runtime_class_init\"(v352, v311, v132, v42, v43, v44, v45, v46, v332, v333, v334, v335, v51, v52, v53, v54);\nL_00BD:\n\tv358 = Il2CppMethodInfo;\n\t// 200 MakeStruct v88 @ AGGFE96C4_1_v2 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), v144 @ V8_v7 (System.Single), v140 @ V9_v5 (System.Single), v100 @ V10_v4 (System.Single)\n\t// 201 MakeStruct v85 @ AGGFE96C4_2_v2 (UnityEngine.Quaternion), typeof(UnityEngine.Quaternion), [v351 @ X8_v23], [v351 @ X8_v23+4], [v351 @ X8_v23+8], [v351 @ X8_v23+C]\n\tv360 = UnityEngine.Object::Instantiate /* +1 sharing this address */(this.dust, v88, v85, *([v358 @ X8_v25 (Il2CppMethodInfo)+F8]));\n\tFluidSolver::RemoveCaterpillar(this.solver, this);\n\treturn;\nL_00F0:\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 162 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public override void OnPreComputeUpdate()
	{
		//IL_002f: Expected I, but got O
		//IL_009e: Expected O, but got I
		//IL_028f: Expected I, but got O
		//IL_029f: Expected O, but got I
		//IL_02af: Expected O, but got I
		//IL_0346: Expected I, but got O
		//IL_0356: Expected O, but got I
		//IL_0366: Expected O, but got I
		//IL_0210: Expected F4, but got O
		//IL_0225: Expected F4, but got I
		//IL_023a: Expected F4, but got I
		//IL_024f: Expected F4, but got I
		base.OnPreComputeUpdate();
		global::UnityEngine.Transform transform = base.transform;
		global::UnityEngine.Vector3 vector = transform.position;
		global::UnityEngine.Transform transform2 = base.transform;
		nint num = (nint)typeof(global::Facebook.Unity.Windows.IWindowsFacebook);
		int num2 = id * 916964780;
		float z = (float)num2 + -6f;
		global::UnityEngine.Vector3 vector2 = default(global::UnityEngine.Vector3);
		vector2.x = vector.x;
		vector2.y = vector.y;
		vector2.z = z;
		transform2.position = vector2;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X21_v2 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]");
		object obj = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X0_v9+E0]");
		if ((nint)0 != 0)
		{
			if (!(levelBottomTransform != null))
			{
				return;
			}
		}
		else if (!(levelBottomTransform != null))
		{
			return;
		}
		global::UnityEngine.Vector3 vector3 = levelBottomTransform.position;
		if (min.y < vector3.y)
		{
			nint num3 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
			global::UnityEngine.Vector2 pos = default(global::UnityEngine.Vector2);
			pos.x = position.x;
			pos.y = position.y;
			CollectionManager collectionManager = default(CollectionManager);
			collectionManager.OnCollectCaterpillar(pos);
			global::UnityEngine.Transform transform3 = base.transform;
			global::UnityEngine.Vector3 vector4 = transform3.position;
			nint num4 = (nint)typeof(global::System.Xml.ValidateNames);
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v14 (Il2CppClass<System.Xml.ValidateNames>)+D0]");
			object obj2 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v16+B8]");
			object obj3 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X8_v17+54]");
			float num5 = 0f * 3f;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X8_v17+58]");
			float num6 = 0f * 3f;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X8_v17+5C]");
			float num7 = 0f * 3f;
			float x = vector4.x + num5;
			float y = vector4.y + num6;
			float z2 = vector4.z + num7;
			nint num8 = (nint)typeof(global::System.Runtime.Serialization.ObjectHolderList);
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X8_v20 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+538]");
			object obj4 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X8_v22+B8]");
			object obj5 = 0;
			nint num9 = 0;
			global::UnityEngine.Vector3 vector5 = default(global::UnityEngine.Vector3);
			vector5.x = x;
			vector5.y = y;
			vector5.z = z2;
			global::UnityEngine.Quaternion quaternion = default(global::UnityEngine.Quaternion);
			quaternion.x = (float)obj5;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v23+4]");
			quaternion.y = 0f;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v23+8]");
			quaternion.z = 0f;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v23+C]");
			quaternion.w = 0f;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117133C (UnityEngine.Object::Instantiate, and 1 more at this address)");
			solver.RemoveCaterpillar(this);
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000183")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE99F8", Offset = "0xFE99F8", Length = "0x8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tRotatingSpecialFluid::.ctor(this);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public Caterpillar()
	{
	}
}
