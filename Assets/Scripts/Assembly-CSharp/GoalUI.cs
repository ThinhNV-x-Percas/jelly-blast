[global::Cpp2ILInjected.Token(Token = "0x20000DB")]
public class GoalUI : global::UnityEngine.MonoBehaviour
{
	[global::Cpp2ILInjected.Token(Token = "0x400048B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private int goalIndex;

	[global::Cpp2ILInjected.Token(Token = "0x400048C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public global::TMPro.TextMeshProUGUI goalText;

	[global::Cpp2ILInjected.Token(Token = "0x400048D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public global::UnityEngine.UI.Image goalImage;

	[global::Cpp2ILInjected.Token(Token = "0x400048E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public global::UnityEngine.GameObject tick;

	[global::Cpp2ILInjected.Token(Token = "0x400048F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	private GoalData goal;

	[global::Cpp2ILInjected.Token(Token = "0x4000490")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	private ElasticScale elasticScale;

	[global::Cpp2ILInjected.Token(Token = "0x60003E7")]
	[global::Cpp2ILInjected.Address(RVA = "0x1019168", Offset = "0x1019168", Length = "0xAC")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = Il2CppMethodInfo;\n\tgoto L_0018;\n\tv23 = Il2CppMethodInfo;\n\tv24 = v23 + 0x630;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv43 = 1;\n\t*([302AA9C]) = v43;\nL_0018:\n\tv46 = UnityEngine.Component::GetComponent /* +1 sharing this address */(this, *([v18 @ X21_v1 (Il2CppMethodInfo)+630]));\n\tv49 = this + 0x48;\n\tthis.elasticScale = v46;\n\tv51 = 0xF3F1B4(v49, v46, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv55 = UnityEngine.GameObject::get_gameObject(this.tick);\n\tUnityEngine.GameObject::SetActive(v55, 0);\n\tv63 = UnityEngine.Component::get_gameObject(this.goalText);\n\tUnityEngine.GameObject::SetActive(v63, 1);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 43 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void Awake()
	{
		//IL_006b: Expected O, but got I
		nint num = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @111C708 (UnityEngine.Component::GetComponent, and 1 more at this address)");
		ElasticScale elasticScale = default(ElasticScale);
		this.elasticScale = elasticScale;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		global::UnityEngine.GameObject gameObject = tick.gameObject;
		gameObject.SetActive(value: false);
		global::UnityEngine.GameObject gameObject2 = goalText.gameObject;
		gameObject2.SetActive(value: true);
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003E8")]
	[global::Cpp2ILInjected.Address(RVA = "0x1019214", Offset = "0x1019214", Length = "0x1A0")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = 0x302A000;\n\tv20 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv22 = *([302AA9D]) & 1;\n\tv23 = v22 == 0;\n\tif (v23) goto L_0028;\n\tv52 = Il2CppMethodInfo + 0xC90;\n\tthis.goalIndex = _goalIndex;\n\tv26 = *([v20 @ X21_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A48]);\n\tv28 = *([v26 @ X0_v34+E0]) == 0;\n\tif (v28) goto L_0033;\nL_0019:\n\tv71 = Singleton`1::get_Instance /* +1 sharing this address */(*([v52 @ X22_v9]));\n\tv64 = v71 == 0;\n\tv65 = ~v64;\n\tif (v65) goto L_0036;\n\tgoto L_0092;\nL_0028:\n\t*([v18 @ X22_v1+A9D]) = 1;\n\tv52 = Il2CppMethodInfo + 0xC90;\n\tthis.goalIndex = _goalIndex;\n\tv47 = *([v20 @ X21_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A48]);\n\tv80 = *([v47 @ X0_v30+E0]) == 0;\n\tv49 = ~v80;\n\tif (v49) goto L_0019;\nL_0033:\n\tv71 = Singleton`1::get_Instance /* +1 sharing this address */(*([v59 @ X22_v6]));\nL_0036:\n\tv76 = *([v71 @ X0_v3+78]);\n\tv150 = Il2CppMethodInfo;\n\tv152 = System.Collections.Generic.List`1<System.Object>::get_Item(*([v76 @ X8_v4+50]), this.goalIndex);\n\tv148 = this + 0x40;\n\tthis.goal = v152;\n\tv199 = 0xF3F1B4(v148, v152, *([v150 @ X8_v5 (Il2CppMethodInfo)+D0]), v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tv200 = this.goal + 0x18;\n\t*([v200 @ X0_v9 (System.Int32)+4]) = v200.m_value;\n\tv124 = System.Int32::ToString(v200);\n\tv125 = TMPro.TMP_Text::set_text(this.goalText, v124);\n\tv143 = this.goal;\n\tUnityEngine.UI.Image::set_sprite(this.goalImage, v143.sprite);\n\tv144 = this.goal;\n\tv83 = v144.goalType != 8;\n\tif (v83) goto L_0091;\n\tv128 = UnityEngine.UI.Graphic::get_rectTransform(this.goalImage);\n\tv206 = UnityEngine.RectTransform::get_sizeDelta(v128);\n\tv164 = v206 * 0.75f;\n\tv162 = v206.y * 0.75f;\n\t// 135 MakeStruct v154 @ AGG101939C_1_v1 (UnityEngine.Vector2), typeof(UnityEngine.Vector2), v164 @ V0_v2 (System.Single), v162 @ V1_v2 (System.Single)\n\tUnityEngine.RectTransform::set_sizeDelta(v128, v154);\n\treturn;\nL_0091:\n\treturn;\nL_0092:\n\tthrow System.NullReferenceException;\n// 101 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public unsafe void Init(int _goalIndex)
	{
		//IL_0009: Expected O, but got I4
		//IL_0017: Expected I, but got O
		//IL_00e6: Expected O, but got I
		//IL_0100: Expected O, but got I
		//IL_0056: Expected O, but got I
		//IL_0070: Expected O, but got I
		//IL_0157: Expected O, but got I
		//IL_0179: Expected O, but got I
		//IL_0189: Expected O, but got I
		object obj = 50503680;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302AA9D]");
		if ((uint)((nuint)0u & (nuint)1u) != 0)
		{
			object obj2 = (nint)0 + (nint)3216;
			goalIndex = _goalIndex;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X21_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A48]");
			object obj3 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ X0_v34+E0]");
			bool flag = (nint)0 == 0;
			object obj4 = obj2;
			if (!flag)
			{
				goto IL_009d;
			}
		}
		else
		{
			_ = 1;
			object obj2 = (nint)0 + (nint)3216;
			goalIndex = _goalIndex;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X21_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A48]");
			object obj5 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v30+E0]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			object obj4 = obj2;
			if (flag3)
			{
				goto IL_009d;
			}
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
		goto IL_0147;
		IL_0147:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3+78]");
		object obj6 = 0;
		nint num2 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v4+50]");
		GoalData goalData = (GoalData)default(global::System.Collections.Generic.List<object>)[goalIndex];
		goal = goalData;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		goal.displayedCount = goal.count;
		string text = goal.count.ToString();
		goalText.text = text;
		GoalData goalData2 = goal;
		goalImage.sprite = goalData2.sprite;
		GoalData goalData3 = goal;
		if (goalData3.goalType == GoalType.Bee)
		{
			global::UnityEngine.RectTransform rectTransform = goalImage.rectTransform;
			global::UnityEngine.Vector2 sizeDelta = rectTransform.sizeDelta;
			float x = sizeDelta.x * 0.75f;
			float y = sizeDelta.y * 0.75f;
			global::UnityEngine.Vector2 sizeDelta2 = default(global::UnityEngine.Vector2);
			sizeDelta2.x = x;
			sizeDelta2.y = y;
			rectTransform.sizeDelta = sizeDelta2;
		}
		return;
		IL_009d:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
		object obj8 = default(object);
		if (obj8 == null)
		{
			throw new global::System.NullReferenceException();
		}
		goto IL_0147;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003E9")]
	[global::Cpp2ILInjected.Address(RVA = "0x100CA64", Offset = "0x100CA64", Length = "0xBC")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv14 = this.goal + 0x1C;\n\tv16 = v14.m_value - 1;\n\tv14.m_value = v16;\n\tv28 = v16 <= 0;\n\tif (v28) goto L_002F;\n\tv77 = System.Int32::ToString(v14);\n\tv128 = TMPro.TMP_Text::set_text(this.goalText, v77);\n\tv122 = this.elasticScale;\n\tv129 = this.elasticScale == 0;\n\tv70 = ~v129;\n\tif (v70) goto L_0048;\n\tgoto L_004A;\nL_002F:\n\tv80 = UnityEngine.GameObject::get_gameObject(this.tick);\n\tUnityEngine.GameObject::SetActive(v80, 1);\n\tv82 = UnityEngine.Component::get_gameObject(this.goalText);\n\tUnityEngine.GameObject::SetActive(v82, 0);\n\tv122 = this.elasticScale;\nL_0048:\n\tElasticScale::Pop(v122);\n\treturn;\nL_004A:\n\tthrow System.NullReferenceException;\n// 56 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public unsafe void RecieveParticle()
	{
		ElasticScale elasticScale;
		if (--goal.displayedCount > 0)
		{
			string text = goal.displayedCount.ToString();
			goalText.text = text;
			elasticScale = this.elasticScale;
			if ((object)this.elasticScale == null)
			{
				throw new global::System.NullReferenceException();
			}
		}
		else
		{
			global::UnityEngine.GameObject gameObject = tick.gameObject;
			gameObject.SetActive(value: true);
			global::UnityEngine.GameObject gameObject2 = goalText.gameObject;
			gameObject2.SetActive(value: false);
			elasticScale = this.elasticScale;
		}
		elasticScale.Pop();
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003EA")]
	[global::Cpp2ILInjected.Address(RVA = "0x10193B4", Offset = "0x10193B4", Length = "0x8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public GoalUI()
	{
	}
}
