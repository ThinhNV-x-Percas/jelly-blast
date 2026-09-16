[global::Cpp2ILInjected.Token(Token = "0x2000030")]
public class CameraFacingBillboard : global::UnityEngine.MonoBehaviour
{
	[global::Cpp2ILInjected.Token(Token = "0x2000031")]
	public enum BillboardMode
	{
		[global::Cpp2ILInjected.Token(Token = "0x40000CA")]
		Rotation = 0,
		[global::Cpp2ILInjected.Token(Token = "0x40000CB")]
		LookAt = 1
	}

	[global::Cpp2ILInjected.Token(Token = "0x40000C8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public CameraFacingBillboard.BillboardMode mode;

	[global::Cpp2ILInjected.Token(Token = "0x600012B")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE5714", Offset = "0xFE5714", Length = "0x2C8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv37 = this.mode == 1;\n\tif (v37) goto L_00AD;\n\tv42 = this.mode == 0;\n\tv43 = ~v42;\n\tif (v43) goto L_0104;\n\tv49 = UnityEngine.Component::get_transform(this);\n\tv70 = UnityEngine.Component::get_transform(this);\n\tv256 = UnityEngine.Transform::get_position(v70);\n\tv269 = UnityEngine.Camera::get_main();\n\tv270 = UnityEngine.Component::get_transform(v269);\n\tv305 = UnityEngine.Transform::get_rotation(v270);\n\tgoto L_004A;\n\tv317 = System.Xml.ValidateNames;\n\tv318 = v317 + 0xD0;\n\tv319 = \"il2cpp_codegen_initialize_runtime_metadata\"(v318, v263, v285, v286, v287, v288, v289, v290, v305, v307, v308, v309, v122, v117, v112, v291);\n\tv322 = 1;\n\t*([2DD4413]) = v322;\nL_004A:\n\tv323 = System.Xml.ValidateNames;\n\tv324 = *([v323 @ X20_v6 (Il2CppClass<System.Xml.ValidateNames>)+D0]);\n\tv281 = *([v324 @ X8_v13+B8]);\n\t// 87 MakeStruct v80 @ AGGFE57FC_1_v2 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), [v281 @ X8_v14+48], [v281 @ X8_v14+4C], [v281 @ X8_v14+50]\n\tv257 = UnityEngine.Quaternion::op_Multiply(v305, v80);\n\tv271 = UnityEngine.Camera::get_main();\n\tv272 = UnityEngine.Component::get_transform(v271);\n\tv330 = UnityEngine.Transform::get_rotation(v272);\n\tgoto L_007D;\n\tv337 = System.Xml.ValidateNames;\n\tv338 = v337 + 0xD0;\n\tv339 = \"il2cpp_codegen_initialize_runtime_metadata\"(v338, v265, v285, v286, v287, v288, v289, v290, v330, v331, v332, v333, v224, v222, v220, v291);\n\tv342 = 1;\n\t*([2DD441B]) = v342;\nL_007D:\n\tv343 = *([v323 @ X20_v6 (Il2CppClass<System.Xml.ValidateNames>)+D0]);\n\tv206 = *([v343 @ X8_v17+B8]);\n\t// 136 MakeStruct v72 @ AGGFE588C_1_v2 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), [v206 @ X8_v18+18], [v206 @ X8_v18+1C], [v206 @ X8_v18+20]\n\tv258 = UnityEngine.Quaternion::op_Multiply(v330, v72);\n\tv184 = v256 + v257;\n\tv179 = v256.y + v257.y;\n\tv174 = v256.z + v257.z;\n\t// 167 MakeStruct v102 @ AGGFE58D8_1_v1 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), v184 @ V0_v12 (System.Single), v179 @ V1_v12 (System.Single), v174 @ V2_v13 (System.Single)\n\tUnityEngine.Transform::LookAt(v49, v102, v258);\n\treturn;\nL_00AD:\n\tv46 = UnityEngine.Component::get_transform(this);\n\tv66 = UnityEngine.Camera::get_main();\n\tv219 = UnityEngine.Component::get_transform(v66);\n\tv260 = UnityEngine.Transform::get_position(v219);\n\tgoto L_00CA;\n\tv296 = System.Xml.ValidateNames;\n\tv297 = v296 + 0xD0;\n\tv298 = \"il2cpp_codegen_initialize_runtime_metadata\"(v297, v267, v285, v286, v287, v288, v289, v290, v260, v255, v250, v159, v122, v117, v112, v291);\n\tv299 = 1;\n\t*([2DD441B]) = v299;\nL_00CA:\n\tv300 = System.Xml.ValidateNames;\n\tv302 = *([v300 @ X8_v5 (Il2CppClass<System.Xml.ValidateNames>)+D0]);\n\tv282 = *([v302 @ X8_v7+B8]);\n\t// 215 MakeStruct v92 @ AGGFE5968_2_v2 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), [v282 @ X8_v8+18], [v282 @ X8_v8+1C], [v282 @ X8_v8+20]\n\tUnityEngine.Transform::LookAt(v46, v260, v92);\n\tv199 = UnityEngine.Component::get_transform(this);\n\t// 242 MakeStruct v89 @ AGGFE59B0_1_v1 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), 0, 1127481344, 0\n\tUnityEngine.Transform::Rotate(v199, v89);\n\treturn;\nL_0104:\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 200 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void LateUpdate()
	{
		//IL_0193: Expected I, but got O
		//IL_01a3: Expected O, but got I
		//IL_01b3: Expected O, but got I
		//IL_01c8: Expected F4, but got I
		//IL_01dd: Expected F4, but got I
		//IL_01f2: Expected F4, but got I
		//IL_0259: Expected I, but got O
		//IL_0269: Expected O, but got I
		//IL_0279: Expected O, but got I
		//IL_028e: Expected F4, but got I
		//IL_02a3: Expected F4, but got I
		//IL_02b8: Expected F4, but got I
		//IL_02e7: Expected O, but got I
		//IL_02f7: Expected O, but got I
		//IL_030c: Expected F4, but got I
		//IL_0321: Expected F4, but got I
		//IL_0336: Expected F4, but got I
		if (mode != CameraFacingBillboard.BillboardMode.LookAt)
		{
			if (mode == CameraFacingBillboard.BillboardMode.Rotation)
			{
				global::UnityEngine.Transform transform = base.transform;
				global::UnityEngine.Transform transform2 = base.transform;
				global::UnityEngine.Vector3 position = transform2.position;
				global::UnityEngine.Camera main = global::UnityEngine.Camera.main;
				global::UnityEngine.Transform transform3 = main.transform;
				global::UnityEngine.Quaternion rotation = transform3.rotation;
				nint num = (nint)typeof(global::System.Xml.ValidateNames);
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X20_v6 (Il2CppClass<System.Xml.ValidateNames>)+D0]");
				object obj = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v13+B8]");
				object obj2 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v14+48]");
				global::UnityEngine.Vector3 vector = default(global::UnityEngine.Vector3);
				vector.x = 0f;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v14+4C]");
				vector.y = 0f;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v14+50]");
				vector.z = 0f;
				global::UnityEngine.Vector3 vector2 = rotation * vector;
				global::UnityEngine.Camera main2 = global::UnityEngine.Camera.main;
				global::UnityEngine.Transform transform4 = main2.transform;
				global::UnityEngine.Quaternion rotation2 = transform4.rotation;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X20_v6 (Il2CppClass<System.Xml.ValidateNames>)+D0]");
				object obj3 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X8_v17+B8]");
				object obj4 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v18+18]");
				global::UnityEngine.Vector3 vector3 = default(global::UnityEngine.Vector3);
				vector3.x = 0f;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v18+1C]");
				vector3.y = 0f;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v18+20]");
				vector3.z = 0f;
				global::UnityEngine.Vector3 worldUp = rotation2 * vector3;
				float x = position.x + vector2.x;
				float y = position.y + vector2.y;
				float z = position.z + vector2.z;
				global::UnityEngine.Vector3 worldPosition = default(global::UnityEngine.Vector3);
				worldPosition.x = x;
				worldPosition.y = y;
				worldPosition.z = z;
				transform.LookAt(worldPosition, worldUp);
			}
		}
		else
		{
			global::UnityEngine.Transform transform5 = base.transform;
			global::UnityEngine.Camera main3 = global::UnityEngine.Camera.main;
			global::UnityEngine.Transform transform6 = main3.transform;
			global::UnityEngine.Vector3 position2 = transform6.position;
			nint num2 = (nint)typeof(global::System.Xml.ValidateNames);
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X8_v5 (Il2CppClass<System.Xml.ValidateNames>)+D0]");
			object obj5 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X8_v7+B8]");
			object obj6 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X8_v8+18]");
			global::UnityEngine.Vector3 worldUp2 = default(global::UnityEngine.Vector3);
			worldUp2.x = 0f;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X8_v8+1C]");
			worldUp2.y = 0f;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X8_v8+20]");
			worldUp2.z = 0f;
			transform5.LookAt(position2, worldUp2);
			global::UnityEngine.Transform transform7 = base.transform;
			global::UnityEngine.Vector3 eulers = default(global::UnityEngine.Vector3);
			eulers.x = 0f;
			eulers.y = 180f;
			eulers.z = 0f;
			transform7.Rotate(eulers);
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x600012C")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE59DC", Offset = "0xFE59DC", Length = "0x8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public CameraFacingBillboard()
	{
	}
}
