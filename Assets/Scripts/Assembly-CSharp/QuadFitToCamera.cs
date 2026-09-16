[global::UnityEngine.ExecuteAlways]
[global::Cpp2ILInjected.Token(Token = "0x20000C8")]
public class QuadFitToCamera : global::UnityEngine.MonoBehaviour
{
	[global::UnityEngine.Tooltip("If null, will use Camera.main")]
	[global::Cpp2ILInjected.Token(Token = "0x4000453")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public global::UnityEngine.Camera targetCamera;

	[global::Cpp2ILInjected.Token(Token = "0x4000454")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private float _originalZScale;

	[global::Cpp2ILInjected.Token(Token = "0x6000395")]
	[global::Cpp2ILInjected.Address(RVA = "0x101458C", Offset = "0x101458C", Length = "0xE8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv16 = 0x302A000;\n\tv18 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv20 = *([302AA7F]) & 1;\n\tv21 = v20 == 0;\n\tif (v21) goto L_0034;\n\tv92 = this + 0x20;\n\tv25 = *([v18 @ X22_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv27 = *([v25 @ X0_v25+E0]) == 0;\n\tif (v27) goto L_0041;\nL_001A:\n\tv59 = UnityEngine.Object::op_Equality(v48, 0);\n\tv69 = ~v59;\n\tv70 = ~v69;\n\tif (v70) goto L_0045;\nL_0020:\n\tv102 = UnityEngine.Component::get_transform(this);\nL_0024:\n\tv110 = UnityEngine.Transform::get_localScale(v102);\n\tthis._originalZScale = v110.z;\n\treturn;\nL_0034:\n\t*([v16 @ X20_v1+A7F]) = 1;\n\tv92 = this + 0x20;\n\tv47 = *([v18 @ X22_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv68 = *([v47 @ X0_v17+E0]) == 0;\n\tv51 = ~v68;\n\tif (v51) goto L_001A;\nL_0041:\n\tv74 = UnityEngine.Object::op_Equality(v61, 0);\n\tv80 = ~v74;\n\tif (v80) goto L_0020;\nL_0045:\n\tv94 = UnityEngine.Camera::get_main();\n\t*([v92 @ X20_v3]) = v94;\n\tv98 = 0xF3F1B4(v92, v94, v86, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tv102 = UnityEngine.Component::get_transform(this);\n\tv128 = v102 == 0;\n\tv106 = ~v128;\n\tif (v106) goto L_0024;\n\tthrow System.NullReferenceException;\n// 48 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void Awake()
	{
		//IL_0009: Expected O, but got I4
		//IL_0017: Expected I, but got O
		//IL_0120: Expected O, but got I
		//IL_0130: Expected O, but got I
		//IL_00d4: Expected O, but got I4
		//IL_0056: Expected O, but got I
		//IL_0066: Expected O, but got I
		//IL_01a3: Expected O, but got I4
		object obj = 50503680;
		nint num = (nint)typeof(global::Facebook.Unity.Windows.IWindowsFacebook);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302AA7F]");
		global::UnityEngine.Object obj4;
		global::UnityEngine.Object obj5;
		object obj6;
		object obj2;
		if ((uint)((nuint)0u & (nuint)1u) != 0)
		{
			obj2 = (nint)this + 32;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X22_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]");
			object obj3 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X0_v25+E0]");
			bool flag = (nint)0 == 0;
			obj4 = targetCamera;
			obj5 = targetCamera;
			obj6 = obj2;
			if (!flag)
			{
				goto IL_00a7;
			}
		}
		else
		{
			_ = 1;
			obj2 = (nint)this + 32;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X22_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]");
			object obj7 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v17+E0]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			obj4 = targetCamera;
			obj5 = targetCamera;
			obj6 = obj2;
			if (flag3)
			{
				goto IL_00a7;
			}
		}
		bool flag4 = obj5 == null;
		bool flag5 = !flag4;
		object obj8 = 0;
		obj2 = obj6;
		if (flag5)
		{
			goto IL_00e2;
		}
		goto IL_01b9;
		IL_00e2:
		global::UnityEngine.Transform transform = base.transform;
		goto IL_00f1;
		IL_00f1:
		_originalZScale = transform.localScale.z;
		return;
		IL_01b9:
		global::UnityEngine.Camera main = global::UnityEngine.Camera.main;
		obj2 = main;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		transform = base.transform;
		if ((object)transform == null)
		{
			throw new global::System.NullReferenceException();
		}
		goto IL_00f1;
		IL_00a7:
		bool flag6 = obj4 == null;
		bool flag7 = !flag6;
		bool flag8 = !flag7;
		obj8 = 0;
		if (!flag8)
		{
			goto IL_00e2;
		}
		goto IL_01b9;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000396")]
	[global::Cpp2ILInjected.Address(RVA = "0x1014674", Offset = "0x1014674", Length = "0x1CC")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv20 = 0x302A000;\n\tv22 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv24 = *([302AA80]) & 1;\n\tv25 = v24 == 0;\n\tif (v25) goto L_0032;\n\tv27 = *([v22 @ X21_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv29 = *([v27 @ X0_v39+E0]) == 0;\n\tif (v29) goto L_003D;\nL_001A:\n\tv59 = UnityEngine.Object::op_Equality(v54, 0);\n\tv69 = v59 == 0;\n\tif (v69) goto L_0046;\nL_0027:\n\treturn;\nL_0032:\n\t*([v20 @ X20_v1+A80]) = 1;\n\tv49 = *([v22 @ X21_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv103 = *([v49 @ X0_v34+E0]) == 0;\n\tv51 = ~v103;\n\tif (v51) goto L_001A;\nL_003D:\n\tv73 = UnityEngine.Object::op_Equality(v63, 0);\n\tv101 = v73 == 0;\n\tv81 = ~v101;\n\tif (v81) goto L_0027;\nL_0046:\n\tv163 = UnityEngine.Camera::get_orthographic(this.targetCamera);\n\tv199 = v163 == 0;\n\tif (v199) goto L_0093;\n\tv169 = UnityEngine.Camera::get_orthographicSize(this.targetCamera);\n\tv170 = UnityEngine.Camera::get_aspect(this.targetCamera);\n\tv187 = UnityEngine.Component::get_transform(this);\n\tv166 = v169 + v169;\n\tv171 = v166 * v170;\n\t// 95 MakeStruct v109 @ AGG1014788_1_v2 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), v171 @ V0_v4 (System.Single), v166 @ V1_v2 (System.Single), this._originalZScale (System.Single)\n\tUnityEngine.Transform::set_localScale(v187, v109);\n\tv189 = UnityEngine.Component::get_transform(this.targetCamera);\n\tv172 = UnityEngine.Transform::get_position(v189);\n\tv213 = UnityEngine.Component::get_transform(this);\n\tv190 = UnityEngine.Component::get_transform(this);\n\tv173 = UnityEngine.Transform::get_position(v190);\n\t// 138 MakeStruct v106 @ AGG10147FC_1_v1 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), v172 @ V0_v5 (UnityEngine.Vector3), v172.y (System.Single), v173.z (System.Single)\n\tUnityEngine.Transform::set_position(v213, v106);\n\treturn;\nL_0093:\n\tgoto L_0095;\n\tv205 = \"il2cpp_codegen_runtime_class_init\"(v202, v162, v92, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47);\nL_0095:\n\tv207 = \"Parent table name is missing in relation '{0}'.\";\n\tUnityEngine.Debug::LogWarning(*([v207 @ X8_v6 (System.String)+5D8]));\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 120 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void LateUpdate()
	{
		//IL_0009: Expected O, but got I4
		//IL_0017: Expected I, but got O
		//IL_00d5: Expected O, but got I
		//IL_005a: Expected O, but got I
		//IL_02bf: Expected O, but got I
		object obj = 50503680;
		nint num = (nint)typeof(global::Facebook.Unity.Windows.IWindowsFacebook);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302AA80]");
		global::UnityEngine.Object obj3;
		global::UnityEngine.Object obj4;
		if ((uint)((nuint)0u & (nuint)1u) != 0)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X21_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]");
			object obj2 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X0_v39+E0]");
			bool flag = (nint)0 == 0;
			obj3 = targetCamera;
			obj4 = targetCamera;
			if (!flag)
			{
				goto IL_0093;
			}
		}
		else
		{
			_ = 1;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X21_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]");
			object obj5 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v34+E0]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			obj3 = targetCamera;
			obj4 = targetCamera;
			if (flag3)
			{
				goto IL_0093;
			}
		}
		if (obj4 == null)
		{
			return;
		}
		goto IL_0154;
		IL_0154:
		if (targetCamera.orthographic)
		{
			float orthographicSize = targetCamera.orthographicSize;
			float aspect = targetCamera.aspect;
			global::UnityEngine.Transform transform = base.transform;
			float num2 = orthographicSize + orthographicSize;
			float x = num2 * aspect;
			global::UnityEngine.Vector3 localScale = default(global::UnityEngine.Vector3);
			localScale.x = x;
			localScale.y = num2;
			localScale.z = _originalZScale;
			transform.localScale = localScale;
			global::UnityEngine.Transform transform2 = targetCamera.transform;
			global::UnityEngine.Vector3 position = transform2.position;
			global::UnityEngine.Transform transform3 = base.transform;
			global::UnityEngine.Transform transform4 = base.transform;
			global::UnityEngine.Vector3 position2 = transform4.position;
			global::UnityEngine.Vector3 position3 = default(global::UnityEngine.Vector3);
			position3.x = position.x;
			position3.y = position.y;
			position3.z = position2.z;
			transform3.position = position3;
		}
		else
		{
			string text = "Parent table name is missing in relation '{0}'.";
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v6 (System.String)+5D8]");
			global::UnityEngine.Debug.LogWarning(0);
		}
		return;
		IL_0093:
		if (obj3 == null)
		{
			return;
		}
		goto IL_0154;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000397")]
	[global::Cpp2ILInjected.Address(RVA = "0x1014840", Offset = "0x1014840", Length = "0x8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public QuadFitToCamera()
	{
	}
}
