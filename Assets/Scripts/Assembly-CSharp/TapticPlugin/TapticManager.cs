namespace TapticPlugin
{
	[global::Cpp2ILInjected.Token(Token = "0x2000102")]
	public static class TapticManager
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000493")]
		[global::Cpp2ILInjected.Address(RVA = "0x1021A9C", Offset = "0x1021A9C", Length = "0x4")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv0 = 0x1E10C(feedback, methodInfo, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16);\n\treturn;\n")]
		public static void Notification(global::TapticPlugin.NotificationFeedback feedback)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1E10C");
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000494")]
		[global::Cpp2ILInjected.Address(RVA = "0x101E108", Offset = "0x101E108", Length = "0x4C")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv13 = ApplicationManager::get_appData();\n\tv15 = v13.playerData;\n\tv37 = ~v15.hapticOn;\n\tif (v37) goto L_001E;\n\tv43 = 0x1E1AC(feedback, methodInfo, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35);\n\treturn;\nL_001E:\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 24 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public static void Impact(global::TapticPlugin.ImpactFeedback feedback)
		{
			ApplicationData appData = ApplicationManager.appData;
			PlayerData playerData = appData.playerData;
			if (playerData.hapticOn)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1E1AC");
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000495")]
		[global::Cpp2ILInjected.Address(RVA = "0x1021AA8", Offset = "0x1021AA8", Length = "0x4")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv0 = 0x1E160(methodInfo, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16);\n\treturn;\n")]
		public static void Selection()
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1E160");
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000496")]
		[global::Cpp2ILInjected.Address(RVA = "0x1021AB0", Offset = "0x1021AB0", Length = "0x1C")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv6 = 0x1E200(methodInfo, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22);\n\tv27 = v6 == 0;\n\tv32 = ~v27;\n\treturn v32;\n// 16 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public static bool IsSupport()
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1E200");
			object obj = default(object);
			bool flag = obj == null;
			return !flag;
		}

		[global::System.Runtime.InteropServices.PreserveSig]
		[global::Cpp2ILInjected.Token(Token = "0x6000497")]
		[global::Cpp2ILInjected.Address(RVA = "0x1021AA0", Offset = "0x1021AA0", Length = "0x4")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv0 = 0x1E10C(type, methodInfo, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16);\n\treturn;\n")]
		private static extern void _unityTapticNotification(int type);

		[global::System.Runtime.InteropServices.PreserveSig]
		[global::Cpp2ILInjected.Token(Token = "0x6000498")]
		[global::Cpp2ILInjected.Address(RVA = "0x1021AAC", Offset = "0x1021AAC", Length = "0x4")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv0 = 0x1E160(methodInfo, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16);\n\treturn;\n")]
		private static extern void _unityTapticSelection();

		[global::System.Runtime.InteropServices.PreserveSig]
		[global::Cpp2ILInjected.Token(Token = "0x6000499")]
		[global::Cpp2ILInjected.Address(RVA = "0x1021AA4", Offset = "0x1021AA4", Length = "0x4")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv0 = 0x1E1AC(style, methodInfo, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16);\n\treturn;\n")]
		private static extern void _unityTapticImpact(int style);

		[global::System.Runtime.InteropServices.PreserveSig]
		[global::Cpp2ILInjected.Token(Token = "0x600049A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1021ACC", Offset = "0x1021ACC", Length = "0x1C")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv6 = 0x1E200(methodInfo, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22);\n\tv27 = v6 == 0;\n\tv32 = ~v27;\n\treturn v32;\n// 16 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		private static extern bool _unityTapticIsSupport();
	}
}
