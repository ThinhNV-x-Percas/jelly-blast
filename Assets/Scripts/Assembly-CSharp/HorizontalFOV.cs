[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.Camera))]
[global::UnityEngine.ExecuteAlways]
[global::Cpp2ILInjected.Token(Token = "0x20000AF")]
public class HorizontalFOV : global::UnityEngine.MonoBehaviour
{
	[global::Cpp2ILInjected.Token(Token = "0x40003E1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public float targetWidth;

	[global::Cpp2ILInjected.Token(Token = "0x40003E2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private global::UnityEngine.Camera cam;

	[global::Cpp2ILInjected.Token(Token = "0x6000318")]
	[global::Cpp2ILInjected.Address(RVA = "0x100D910", Offset = "0x100D910", Length = "0xC8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv22 = Il2CppMethodInfo;\n\tgoto L_001A;\n\tv27 = Il2CppMethodInfo;\n\tv28 = v27 + 0x600;\n\tv29 = \"il2cpp_codegen_initialize_runtime_metadata\"(v28, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\tv47 = 1;\n\t*([302AA58]) = v47;\nL_001A:\n\tv50 = UnityEngine.Component::GetComponent /* +1 sharing this address */(this, *([v22 @ X21_v1 (Il2CppMethodInfo)+600]));\n\tv53 = this + 0x28;\n\tthis.cam = v50;\n\tv55 = 0xF3F1B4(v53, v50, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\tv59 = UnityEngine.Camera::get_orthographic(this.cam);\n\tv99 = ~v59;\n\tif (v99) goto L_004C;\n\tv100 = this.targetWidth < 0;\n\tv86 = ~v100;\n\tv77 = this.targetWidth == 0;\n\tv101 = ~v77;\n\tv62 = v86 & v101;\n\tif (v62) goto L_004C;\n\tv89 = UnityEngine.Camera::get_orthographicSize(this.cam);\n\tv148 = UnityEngine.Camera::get_aspect(this.cam);\n\tv149 = v89 * v148;\n\tv114 = v149 + v149;\n\tthis.targetWidth = v114;\nL_004C:\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 51 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void Awake()
	{
		cam = GetComponent<global::UnityEngine.Camera>();
		if (cam.orthographic)
		{
			bool flag = targetWidth < 0f;
			bool flag2 = !flag;
			bool flag3 = targetWidth == 0f;
			bool flag4 = !flag3;
			if (!(flag2 && flag4))
			{
				float orthographicSize = cam.orthographicSize;
				float aspect = cam.aspect;
				float num2 = orthographicSize * aspect;
				float num3 = num2 + num2;
				targetWidth = num3;
			}
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000319")]
	[global::Cpp2ILInjected.Address(RVA = "0x100D9D8", Offset = "0x100D9D8", Length = "0x74")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv19 = UnityEngine.Camera::get_orthographic(this.cam);\n\tv48 = ~v19;\n\tif (v48) goto L_002C;\n\tv22 = UnityEngine.Camera::get_aspect(this.cam);\n\tv73 = v22 + v22;\n\tv62 = this.targetWidth / v73;\n\tUnityEngine.Camera::set_orthographicSize(this.cam, v62);\n\treturn;\nL_002C:\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 36 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void Update()
	{
		if (cam.orthographic)
		{
			float aspect = cam.aspect;
			float num = aspect + aspect;
			float orthographicSize = targetWidth / num;
			cam.orthographicSize = orthographicSize;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x600031A")]
	[global::Cpp2ILInjected.Address(RVA = "0x100DA4C", Offset = "0x100DA4C", Length = "0x8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public HorizontalFOV()
	{
	}
}
