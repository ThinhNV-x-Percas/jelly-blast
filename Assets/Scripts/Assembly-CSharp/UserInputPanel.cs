[global::Cpp2ILInjected.Token(Token = "0x20000FA")]
public class UserInputPanel : global::UnityEngine.MonoBehaviour, global::UnityEngine.EventSystems.IPointerDownHandler, global::UnityEngine.EventSystems.IEventSystemHandler, global::UnityEngine.EventSystems.IPointerUpHandler
{
	[global::Cpp2ILInjected.Token(Token = "0x6000483")]
	[global::Cpp2ILInjected.Address(RVA = "0x1021468", Offset = "0x1021468", Length = "0x4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn;\n")]
	public void OnPointerDown(global::UnityEngine.EventSystems.PointerEventData eventData)
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000484")]
	[global::Cpp2ILInjected.Address(RVA = "0x102146C", Offset = "0x102146C", Length = "0xB4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv16 = 0x302A000;\n\tv18 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv20 = *([302AAFB]) & 1;\n\tv21 = v20 == 0;\n\tif (v21) goto L_0023;\n\tv50 = Il2CppMethodInfo + 0xC90;\n\tv24 = *([v18 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A48]);\n\tv26 = *([v24 @ X0_v18+E0]) == 0;\n\tif (v26) goto L_002D;\nL_0017:\n\tv69 = Singleton`1::get_Instance /* +1 sharing this address */(*([v50 @ X21_v8]));\n\tv62 = eventData == 0;\n\tv63 = ~v62;\n\tif (v63) goto L_003C;\n\tgoto L_003F;\nL_0023:\n\t*([v16 @ X21_v1+AFB]) = 1;\n\tv50 = Il2CppMethodInfo + 0xC90;\n\tv45 = *([v18 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A48]);\n\tv68 = *([v45 @ X0_v14+E0]) == 0;\n\tv47 = ~v68;\n\tif (v47) goto L_0017;\nL_002D:\n\tv69 = Singleton`1::get_Instance /* +1 sharing this address */(*([v57 @ X21_v5]));\nL_003C:\n\t// 60 MakeStruct v89 @ AGG1021518_1_v1 (UnityEngine.Vector2), typeof(UnityEngine.Vector2), eventData.<position>k__BackingField (UnityEngine.Vector2), eventData.<position>k__BackingField.y (System.Single)\n\tGameManager::OnClickUserInputPanel(v69, v89);\n\treturn;\nL_003F:\n\tthrow System.NullReferenceException;\n// 40 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void OnPointerUp(global::UnityEngine.EventSystems.PointerEventData eventData)
{
		Singleton<GameManager>.Instance.OnClickUserInputPanel(eventData.position);
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000485")]
	[global::Cpp2ILInjected.Address(RVA = "0x1021520", Offset = "0x1021520", Length = "0x8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
public UserInputPanel()
{
}
}
