[global::Cpp2ILInjected.Token(Token = "0x20000EB")]
public class GameplayScreen : Viewport
{
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x20000ED")]
	private sealed class _003CPulseForever_003Ed__15 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
	{
		[global::Cpp2ILInjected.Token(Token = "0x40004EA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[global::Cpp2ILInjected.Token(Token = "0x40004EB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[global::Cpp2ILInjected.Token(Token = "0x40004EC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public GameplayScreen _003C_003E4__this;

		[global::Cpp2ILInjected.Token(Token = "0x40004ED")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private float _003Ctimer_003E5__2;

		[global::Cpp2ILInjected.Token(Token = "0x1700004E")]
		object global::System.Collections.Generic.IEnumerator<object>.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600044A")]
			[global::Cpp2ILInjected.Address(RVA = "0x101EF14", Offset = "0x101EF14", Length = "0x8")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn this.<>2__current;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
			get
			{
				return _003C_003E2__current;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700004F")]
		object global::System.Collections.IEnumerator.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600044C")]
			[global::Cpp2ILInjected.Address(RVA = "0x101EF5C", Offset = "0x101EF5C", Length = "0x8")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn this.<>2__current;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
			get
			{
				return _003C_003E2__current;
			}
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x6000447")]
		[global::Cpp2ILInjected.Address(RVA = "0x101EBE8", Offset = "0x101EBE8", Length = "0x2C")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tSystem.Object::.ctor(this);\n\tthis.<>1__state = <>1__state;\n\treturn;\n// 14 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public _003CPulseForever_003Ed__15(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x6000448")]
		[global::Cpp2ILInjected.Address(RVA = "0x101EDE4", Offset = "0x101EDE4", Length = "0x4")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn;\n")]
		void global::System.IDisposable.Dispose()
		{
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000449")]
		[global::Cpp2ILInjected.Address(RVA = "0x101EDE8", Offset = "0x101EDE8", Length = "0x12C")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv17 = this.<>4__this;\n\tv22 = this.<>1__state == 1;\n\tif (v22) goto L_0022;\n\tv27 = this.<>1__state == 0;\n\tv28 = ~v27;\n\tif (v28) goto L_009F;\n\tthis.<>1__state = 0xFFFFFFFF;\n\tv17.isPulsing = 1;\n\tthis.<timer>5__2 = 0f;\n\tgoto L_0025;\nL_0022:\n\tthis.<>1__state = 0xFFFFFFFF;\n\tv40 = this.<timer>5__2;\nL_0025:\n\tv47 = UnityEngine.Time::get_deltaTime();\n\tv148 = v40 + v47;\n\tthis.<timer>5__2 = v148;\n\tv150 = v148 * 0.5f;\n\tv151 = UnityEngine.Mathf::Floor(v150);\n\tv152 = v151 + v151;\n\tv153 = v148 - v152;\n\tv172 = v153 + -1f;\n\tv159 = v153 - 2f;\n\tv160 = v159 < 0;\n\tv161 = v159 == 0;\n\tv162 = v153 ^ 2f;\n\tv163 = v153 ^ v159;\n\tv164 = v162 & v163;\n\tv165 = v164 < 0;\n\tv166 = v160 == v165;\n\tv167 = ~v161;\n\tv168 = v166 & v167;\n\tv169 = ~v168;\n\tif (v169) goto L_004C;\n\tgoto L_004C;\nL_004C:\n\tv182 = v153 >= 0;\n\tif (v182) goto L_FFFFFFFF;\n\tgoto L_0052;\nL_0052:\n\tv186 = UnityEngine.Mathf::Abs(v185);\n\tv74 = 1f - v186;\n\tv188 = v74 * 0.25f;\n\tv71 = v188 + 1f;\n\tv192 = v74 - 1f;\n\tv193 = v192 < 0;\n\tv194 = v192 == 0;\n\tv195 = v74 ^ 1f;\n\tv196 = v74 ^ v192;\n\tv197 = v195 & v196;\n\tv198 = v197 < 0;\n\tv199 = v193 == v198;\n\tv59 = ~v194;\n\tv62 = v199 & v59;\n\tv200 = ~v62;\n\tif (v200) goto L_0073;\n\tgoto L_0073;\nL_0073:\n\tv56 = v74 >= 0;\n\tif (v56) goto L_FFFFFFFF;\n\tgoto L_007F;\nL_007F:\n\tv53 = TMPro.TMP_Text::get_transform(v17.moveCounter);\n\t// 134 MakeStruct v114 @ AGG101EED0_1_v1 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), v76 @ V8_v2 (System.Single), v76 @ V8_v2 (System.Single), 1f\n\tUnityEngine.Transform::set_localScale(v53, v114);\n\tv207 = this + 0x18;\n\tthis.<>2__current = 0;\n\tv209 = 0xF3F1B4(v207, 0, v99, v100, v101, v102, v103, v104, v76, v76, 1f, 1f, v105, v106, v107, v108);\n\tthis.<>1__state = 1;\n\treturn 1;\nL_009F:\n\treturn 0;\n\treturnVal2 = new System.NullReferenceException();\n\treturn returnVal2;\n// 95 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		private bool MoveNext()
		{
			//IL_0228: Expected O, but got F4
			//IL_0235: Expected O, but got F4
			//IL_0331: Expected O, but got F4
			//IL_033e: Expected O, but got F4
			//IL_014e: Expected O, but got I
			GameplayScreen gameplayScreen = _003C_003E4__this;
			float num;
			if (_003C_003E1__state != 1)
			{
				if (_003C_003E1__state != 0)
				{
					return false;
				}
				_003C_003E1__state = -1;
				gameplayScreen.isPulsing = true;
				_003Ctimer_003E5__2 = 0f;
				num = 0f;
			}
			else
			{
				_003C_003E1__state = -1;
				num = _003Ctimer_003E5__2;
			}
			float deltaTime = global::UnityEngine.Time.deltaTime;
			float num2 = (_003Ctimer_003E5__2 = num + deltaTime);
			float f = num2 * 0.5f;
			float num3 = global::UnityEngine.Mathf.Floor(f);
			float num4 = num3 + num3;
			float num5 = num2 - num4;
			float num6 = num5 + -1f;
			float num7 = num5 - 2f;
			bool flag = num7 < 0f;
			bool flag2 = num7 == 0f;
			object obj = num5 ^ 2f;
			object obj2 = num5 ^ num7;
			int num8 = (int)((nint)obj & (nint)obj2);
			bool flag3 = num8 < 0;
			bool flag4 = flag == flag3;
			bool flag5 = !flag2;
			if (flag4 && flag5)
			{
				num6 = 1f;
			}
			float f2 = ((!(num5 < 0f)) ? num6 : (-1f));
			float num9 = global::UnityEngine.Mathf.Abs(f2);
			float num10 = 1f - num9;
			float num11 = num10 * 0.25f;
			float num12 = num11 + 1f;
			float num13 = num10 - 1f;
			bool flag6 = num13 < 0f;
			bool flag7 = num13 == 0f;
			object obj3 = num10 ^ 1f;
			object obj4 = num10 ^ num13;
			int num14 = (int)((nint)obj3 & (nint)obj4);
			bool flag8 = num14 < 0;
			bool flag9 = flag6 == flag8;
			bool flag10 = !flag7;
			if (flag9 && flag10)
			{
				num12 = 1.25f;
			}
			float num15 = ((!(num10 < 0f)) ? num12 : 1f);
			global::UnityEngine.Transform transform = gameplayScreen.moveCounter.transform;
			global::UnityEngine.Vector3 localScale = default(global::UnityEngine.Vector3);
			localScale.x = num15;
			localScale.y = num15;
			localScale.z = 1f;
			transform.localScale = localScale;
			_003C_003E2__current = null;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
			_003C_003E1__state = 1;
			return true;
		}

		bool global::System.Collections.IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x600044B")]
		[global::Cpp2ILInjected.Address(RVA = "0x101EF1C", Offset = "0x101EF1C", Length = "0x40")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv10 = Facebook.Unity.Windows.IWindowsFacebook + 0xF30;\n\tv11 = 0xF3F22C(v10, methodInfo, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26);\n\tv27 = new v11();\n\tSystem.NotSupportedException::.ctor(v27);\n\tv31 = Il2CppMethodInfo + 0xE88;\n\tv32 = 0xF3F22C(v31, 0, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26);\n\tthrow v27;\n// 13 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		void global::System.Collections.IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0039: Expected O, but got I
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F22C");
			global::System.NotSupportedException ex = new global::System.NotSupportedException();
			object obj2 = (nint)0 + (nint)3720;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F22C");
			throw ex;
		}
	}

	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x20000EE")]
	private sealed class _003CShowMovePopup_003Ed__16 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
	{
		[global::Cpp2ILInjected.Token(Token = "0x40004EE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[global::Cpp2ILInjected.Token(Token = "0x40004EF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[global::Cpp2ILInjected.Token(Token = "0x40004F0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public GameplayScreen _003C_003E4__this;

		[global::Cpp2ILInjected.Token(Token = "0x40004F1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private global::UnityEngine.GameObject _003Ceffect_003E5__2;

		[global::Cpp2ILInjected.Token(Token = "0x17000050")]
		object global::System.Collections.Generic.IEnumerator<object>.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000450")]
			[global::Cpp2ILInjected.Address(RVA = "0x101F1F8", Offset = "0x101F1F8", Length = "0x8")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn this.<>2__current;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
			get
			{
				return _003C_003E2__current;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000051")]
		object global::System.Collections.IEnumerator.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000452")]
			[global::Cpp2ILInjected.Address(RVA = "0x101F240", Offset = "0x101F240", Length = "0x8")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn this.<>2__current;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
			get
			{
				return _003C_003E2__current;
			}
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x600044D")]
		[global::Cpp2ILInjected.Address(RVA = "0x101EC14", Offset = "0x101EC14", Length = "0x2C")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tSystem.Object::.ctor(this);\n\tthis.<>1__state = <>1__state;\n\treturn;\n// 14 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public _003CShowMovePopup_003Ed__16(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x600044E")]
		[global::Cpp2ILInjected.Address(RVA = "0x101EF64", Offset = "0x101EF64", Length = "0x4")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn;\n")]
		void global::System.IDisposable.Dispose()
		{
		}

		[global::Cpp2ILInjected.Token(Token = "0x600044F")]
		[global::Cpp2ILInjected.Address(RVA = "0x101EF68", Offset = "0x101EF68", Length = "0x290")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_002A;\n\tv33 = Il2CppMethodInfo;\n\tv34 = v33 + 0xA30;\n\tv35 = \"il2cpp_codegen_initialize_runtime_metadata\"(v34, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv57 = Il2CppMethodInfo;\n\tv58 = v57 + 0xA48;\n\tv59 = \"il2cpp_codegen_initialize_runtime_metadata\"(v58, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv73 = Il2CppMethodInfo;\n\tv74 = v73 + 0xAB8;\n\tv75 = \"il2cpp_codegen_initialize_runtime_metadata\"(v74, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv222 = Il2CppMethodInfo;\n\tv223 = v222 + 0xA8;\n\tv224 = \"il2cpp_codegen_initialize_runtime_metadata\"(v223, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv266 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv267 = v266 + 0xFD8;\n\tv268 = \"il2cpp_codegen_initialize_runtime_metadata\"(v267, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv272 = System.Xml.ValidateNames;\n\tv273 = v272 + 0x258;\n\tv52 = \"il2cpp_codegen_initialize_runtime_metadata\"(v273, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv54 = 1;\n\t*([302AAE3]) = v54;\nL_002A:\n\tv56 = this.<>1__state == 0;\n\tif (v56) goto L_0045;\n\tv69 = this.<>1__state != 1;\n\tif (v69) goto L_00C9;\n\tthis.<>1__state = 0xFFFFFFFF;\n\tv225 = Il2CppMethodInfo;\n\tv227 = UnityEngine.GameObject::GetComponent /* +1 sharing this address */(this.<effect>5__2, *([v225 @ X8_v27 (Il2CppMethodInfo)+A30]));\n\tv130 = DG.Tweening.DOTweenModuleUI::DOFade(v227, 0f, 1f);\n\tgoto L_00C9;\nL_0045:\n\tv70 = this.<>4__this;\n\tthis.<>1__state = 0xFFFFFFFF;\n\tgoto L_0054;\n\tv260 = \"il2cpp_codegen_runtime_class_init\"(v166, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\nL_0054:\n\tv262 = Il2CppMethodInfo;\n\tv265 = UnityEngine.Object::Instantiate /* +1 sharing this address */(v70.moveEffectPrefab, v70.moveEffectParent, *([v262 @ X8_v9 (Il2CppMethodInfo)+A8]));\n\tv220 = this + 0x28;\n\tthis.<effect>5__2 = v265;\n\tv271 = 0xF3F1B4(v220, v265, *([v262 @ X8_v9 (Il2CppMethodInfo)+A8]), v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv274 = Il2CppMethodInfo;\n\tv275 = UnityEngine.GameObject::GetComponent /* +1 sharing this address */(this.<effect>5__2, *([v274 @ X8_v11 (Il2CppMethodInfo)+AB8]));\n\tv203 = UnityEngine.Component::get_transform(v70.moveEffectParent);\n\tv181 = UnityEngine.Transform::get_position(v203);\n\tUnityEngine.Transform::set_position(v275, v181);\n\tv277 = Il2CppMethodInfo;\n\tv205 = UnityEngine.GameObject::GetComponent /* +1 sharing this address */(this.<effect>5__2, *([v277 @ X8_v13 (Il2CppMethodInfo)+A48]));\n\tElasticScale::SetScale(v205, 0f);\n\tElasticScale::Pop(v205);\n\tv281 = UnityEngine.GameObject::get_transform(this.<effect>5__2);\n\tv285 = UnityEngine.Transform::get_position(v275);\n\tgoto L_00A1;\n\tv290 = System.Xml.ValidateNames;\n\tv291 = v290 + 0xD0;\n\tv292 = \"il2cpp_codegen_initialize_runtime_metadata\"(v291, v284, v174, v38, v39, v40, v41, v42, v285, v286, v287, v46, v47, v48, v49, v50);\n\tv295 = 1;\n\t*([2DD441B]) = v295;\nL_00A1:\n\tv296 = System.Xml.ValidateNames;\n\tv298 = *([v296 @ X8_v17 (Il2CppClass<System.Xml.ValidateNames>)+D0]);\n\tv299 = *([v298 @ X8_v19+B8]);\n\tv305 = *([v299 @ X8_v20+18]) * 0x43FA0000;\n\tv306 = *([v299 @ X8_v20+1C]) * 0x43FA0000;\n\tv307 = *([v299 @ X8_v20+20]) * 0x43FA0000;\n\tv308 = v285 + v305;\n\tv102 = v285.y + v306;\n\tv94 = v285.z + v307;\n\t// 180 MakeStruct v80 @ AGG101F194_1_v2 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), v308 @ V0_v8 (System.Single), v102 @ V1_v7 (System.Single), v94 @ V2_v7 (System.Single)\n\tv311 = DG.Tweening.ShortcutExtensions::DOMove(v281, v80, 2f, 0);\n\tv312 = System.Xml.ValidateNames;\n\tv315 = new *([v312 @ X8_v22 (Il2CppClass<System.Xml.ValidateNames>)+258])();\n\tUnityEngine.WaitForSeconds::.ctor(v315, 1f);\n\tv139 = this + 0x18;\n\tthis.<>2__current = v315;\n\tv129 = 0xF3F1B4(v139, v315, 0, v38, v39, v40, v41, v42, 1f, v102, v94, 2f, v47, v48, v49, v50);\n\tthis.<>1__state = 1;\nL_00C9:\n\tv144 = this.<>1__state == 0;\n\treturn v144;\n\treturnVal2 = new System.NullReferenceException();\n\treturn returnVal2;\n// 145 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		private bool MoveNext()
		{
			//IL_00a3: Expected O, but got I
			//IL_01d6: Expected I, but got O
			//IL_01e6: Expected O, but got I
			//IL_01f6: Expected O, but got I
			//IL_020c: Expected O, but got I
			//IL_0222: Expected O, but got I
			//IL_0238: Expected O, but got I
			//IL_02c4: Expected I, but got O
			//IL_016f: Expected O, but got I
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					nint num = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @114831C (UnityEngine.GameObject::GetComponent, and 1 more at this address)");
					global::UnityEngine.CanvasGroup target = default(global::UnityEngine.CanvasGroup);
					global::DG.Tweening.Core.TweenerCore<float, float, global::DG.Tweening.Plugins.Options.FloatOptions> tweenerCore = global::DG.Tweening.DOTweenModuleUI.DOFade(target, 0f, 1f);
				}
			}
			else
			{
				GameplayScreen gameplayScreen = _003C_003E4__this;
				_003C_003E1__state = -1;
				nint num2 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11711B8 (UnityEngine.Object::Instantiate, and 1 more at this address)");
				global::UnityEngine.GameObject gameObject = default(global::UnityEngine.GameObject);
				_003Ceffect_003E5__2 = gameObject;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
				nint num3 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @114831C (UnityEngine.GameObject::GetComponent, and 1 more at this address)");
				global::UnityEngine.Transform transform = gameplayScreen.moveEffectParent.transform;
				global::UnityEngine.Vector3 position = transform.position;
				global::UnityEngine.Transform transform2 = default(global::UnityEngine.Transform);
				transform2.position = position;
				nint num4 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @114831C (UnityEngine.GameObject::GetComponent, and 1 more at this address)");
				ElasticScale elasticScale = default(ElasticScale);
				elasticScale.SetScale(0f);
				elasticScale.Pop();
				global::UnityEngine.Transform transform3 = _003Ceffect_003E5__2.transform;
				global::UnityEngine.Vector3 position2 = transform2.position;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v17 (Il2CppClass<System.Xml.ValidateNames>)+D0]");
				object obj2 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v19+B8]");
				object obj3 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v20+18]");
				object obj4 = (nint)0 * (nint)1140457472;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v20+1C]");
				object obj5 = (nint)0 * (nint)1140457472;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v20+20]");
				object obj6 = (nint)0 * (nint)1140457472;
				float x = position2.x + (float)obj4;
				float y = position2.y + (float)obj5;
				float z = position2.z + (float)obj6;
				global::UnityEngine.Vector3 endValue = default(global::UnityEngine.Vector3);
				endValue.x = x;
				endValue.y = y;
				endValue.z = z;
				global::DG.Tweening.Core.TweenerCore<global::UnityEngine.Vector3, global::UnityEngine.Vector3, global::DG.Tweening.Plugins.Options.VectorOptions> tweenerCore2 = global::DG.Tweening.ShortcutExtensions.DOMove(transform3, endValue, 2f);
				global::UnityEngine.WaitForSeconds waitForSeconds = new global::UnityEngine.WaitForSeconds(1f);
				_003C_003E2__current = waitForSeconds;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
				_003C_003E1__state = 1;
			}
			return _003C_003E1__state == 0;
		}

		bool global::System.Collections.IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x6000451")]
		[global::Cpp2ILInjected.Address(RVA = "0x101F200", Offset = "0x101F200", Length = "0x40")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv10 = Facebook.Unity.Windows.IWindowsFacebook + 0xF30;\n\tv11 = 0xF3F22C(v10, methodInfo, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26);\n\tv27 = new v11();\n\tSystem.NotSupportedException::.ctor(v27);\n\tv31 = Il2CppMethodInfo + 0xE90;\n\tv32 = 0xF3F22C(v31, 0, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26);\n\tthrow v27;\n// 13 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		void global::System.Collections.IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0039: Expected O, but got I
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F22C");
			global::System.NotSupportedException ex = new global::System.NotSupportedException();
			object obj2 = (nint)0 + (nint)3728;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F22C");
			throw ex;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x40004DD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public GoalUI goalPrefab;

	[global::Cpp2ILInjected.Token(Token = "0x40004DE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public global::UnityEngine.RectTransform goalParent;

	[global::Cpp2ILInjected.Token(Token = "0x40004DF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public GoalUI[] goals;

	[global::Cpp2ILInjected.Token(Token = "0x40004E0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public global::TMPro.TextMeshProUGUI moveCounter;

	[global::Cpp2ILInjected.Token(Token = "0x40004E1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public UIButton settingsButton;

	[global::Cpp2ILInjected.Token(Token = "0x40004E2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public global::UnityEngine.GameObject moveEffectPrefab;

	[global::Cpp2ILInjected.Token(Token = "0x40004E3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public global::UnityEngine.RectTransform moveEffectParent;

	[global::Cpp2ILInjected.Token(Token = "0x40004E4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	private global::UnityEngine.Coroutine pulseCoroutine;

	[global::Cpp2ILInjected.Token(Token = "0x40004E5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public UIIconGenerator iconGenerator;

	[global::Cpp2ILInjected.Token(Token = "0x40004E6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public ElasticScale moveCountElasticScale;

	[global::Cpp2ILInjected.Token(Token = "0x40004E7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	private bool isPulsing;

	[global::Cpp2ILInjected.Token(Token = "0x600043C")]
	[global::Cpp2ILInjected.Address(RVA = "0x101E1A4", Offset = "0x101E1A4", Length = "0x12C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0021;\n\tv27 = CollectParticleData[];\n\tv28 = v27 + 0x990;\n\tv29 = \"il2cpp_codegen_initialize_runtime_metadata\"(v28, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\tv53 = Il2CppMethodInfo;\n\tv54 = v53 + 0xBB8;\n\tv55 = \"il2cpp_codegen_initialize_runtime_metadata\"(v54, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\tv60 = Il2CppMethodInfo;\n\tv61 = v60 + 0xC90;\n\tv62 = \"il2cpp_codegen_initialize_runtime_metadata\"(v61, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\tv67 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv68 = v67 + 0xA48;\n\tv46 = \"il2cpp_codegen_initialize_runtime_metadata\"(v68, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\tv48 = 1;\n\t*([302AADC]) = v48;\nL_0021:\n\tv49 = Il2CppMethodInfo;\n\tViewport::Awake(this);\n\tgoto L_002D;\n\tv63 = \"il2cpp_codegen_runtime_class_init\"(v56, v52, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\nL_002D:\n\tv66 = Singleton`1::get_Instance /* +1 sharing this address */(*([v49 @ X21_v2 (Il2CppMethodInfo)+C90]));\n\tv71 = CollectParticleData[];\n\tv73 = Il2CppMethodInfo;\n\tv75 = v66 + 0x90;\n\tv78 = new *([v71 @ X23_v1 (Il2CppClass<CollectParticleData[]>)+990])();\n\tSystem.Action::.ctor(v78, this, *([v73 @ X24_v1 (Il2CppMethodInfo)+BB8]));\n\tv87 = System.Delegate::Combine(*([v75 @ X20_v4]), v78);\n\tv133 = v87 == 0;\n\tif (v133) goto L_0060;\n\tv155 = *([v87 @ X0_v11 (System.Delegate)]) != *([v71 @ X23_v1 (Il2CppClass<CollectParticleData[]>)+990]);\n\tif (v155) goto L_005F;\n\t*([v75 @ X20_v4]) = v87;\n\tv183 = *([v87 @ X0_v11 (System.Delegate)]) == *([v71 @ X23_v1 (Il2CppClass<CollectParticleData[]>)+990]);\n\tif (v183) goto L_006C;\nL_005F:\n\tthrow System.InvalidCastException;\nL_0060:\n\t*([v75 @ X20_v4]) = 0;\nL_006C:\n\tv131 = 0xF3F1B4(v75, v87, 0, 0, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 73 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	protected internal override void Awake()
	{
		//IL_0022: Expected I, but got O
		//IL_0037: Expected O, but got I
		//IL_00e3: Expected O, but got I4
		nint num = 0;
		base.Awake();
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
		nint num2 = (nint)typeof(CollectParticleData[]);
		nint num3 = 0;
		object obj = default(object);
		object a = (nint)obj + 144;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X24_v1 (Il2CppMethodInfo)+BB8]");
		global::System.Action b = new global::System.Action(this, (global::System.IntPtr)0);
		global::System.Delegate obj2 = global::System.Delegate.Combine((global::System.Delegate)a, b);
		if ((object)obj2 != null)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X23_v1 (Il2CppClass<CollectParticleData[]>)+990]");
			if ((object)obj2 == null)
			{
				a = obj2;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X23_v1 (Il2CppClass<CollectParticleData[]>)+990]");
				if ((object)obj2 == null)
				{
					goto IL_00f9;
				}
			}
			throw new global::System.InvalidCastException();
		}
		a = 0;
		goto IL_00f9;
		IL_00f9:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
	}

	[global::Cpp2ILInjected.Token(Token = "0x600043D")]
	[global::Cpp2ILInjected.Address(RVA = "0x101E2D0", Offset = "0x101E2D0", Length = "0x3D8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv30 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv32 = *([302AADD]) & 1;\n\tv33 = v32 == 0;\n\tif (v33) goto L_0044;\n\tv83 = Il2CppMethodInfo + 0xC90;\n\tv36 = *([v30 @ X24_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A48]);\n\tv38 = *([v36 @ X0_v105+E0]) == 0;\n\tif (v38) goto L_004E;\nL_001D:\n\tv82 = Singleton`1::get_Instance /* +1 sharing this address */(*([v83 @ X26_v4]));\n\tv75 = v82 == 0;\n\tv76 = ~v75;\n\tif (v76) goto L_0051;\n\tgoto L_014C;\nL_0044:\n\t*([302AADD]) = 1;\n\tv83 = Il2CppMethodInfo + 0xC90;\n\tv58 = *([v30 @ X24_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A48]);\n\tv407 = *([v58 @ X0_v101+E0]) == 0;\n\tv62 = ~v407;\n\tif (v62) goto L_001D;\nL_004E:\n\tv82 = Singleton`1::get_Instance /* +1 sharing this address */(*([v68 @ X26_v6]));\nL_0051:\n\tv87 = *([v82 @ X0_v8+78]);\n\tv200 = *([v87 @ X8_v6+50]);\n\tv246 = CollectParticleData[];\n\tv248 = Il2CppMethodInfo;\n\tv251 = \"SzArrayNew\"(*([v246 @ X9_v4 (Il2CppClass<CollectParticleData[]>)+1E0]), *([v200 @ X8_v7+18]), v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56);\n\tv210 = this + 0x68;\n\tthis.goals = v251;\n\tv260 = 0xF3F1B4(v210, v251, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56);\n\tgoto L_006F;\n\tv335 = \"il2cpp_codegen_runtime_class_init\"(v329, v327, v311, v310, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56);\nL_006F:\n\tv177 = Singleton`1::get_Instance /* +1 sharing this address */(*([v83 @ X26_v4]));\n\tv202 = *([v177 @ X0_v16+78]);\n\tv203 = *([v202 @ X8_v10+50]);\n\tv119 = v155 >= *([v203 @ X8_v11+18]);\n\tif (v119) goto L_00C6;\n\tgoto L_008D;\n\tv413 = \"il2cpp_codegen_runtime_class_init\"(v410, v160, v101, v96, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56);\nL_008D:\n\tv178 = UnityEngine.Object::Instantiate /* +1 sharing this address */(this.goalPrefab, *([v248 @ X25_v4 (Il2CppMethodInfo)+60]));\n\tv424 = UnityEngine.Component::get_transform(v178);\n\tv180 = UnityEngine.Component::get_transform(this.goalParent);\n\tUnityEngine.Transform::SetParent(v424, v180, 0);\n\tGoalUI::Init(v178, v155);\n\tv108 = this.goals;\n\tv238 = 0xF3F36C(v178, GoalUI, 0, 0, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56);\n\tv241 = v238 == 0;\n\tif (v241) goto L_014D;\n\tv108[v155 @ X21_v5 (System.Int32)] = v178;\n\tv519 = v108 + v153;\n\tv520 = 0xF3F1B4(v519, v178, 0, 0, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56);\n\tv155 = v155 + 1;\n\tv153 = v153 + 8;\n\tgoto L_006F;\n\tgoto L_FFFFFFFF;\nL_00C6:\n\tv205 = this.settingsButton;\n\tv416 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv417 = *([v416 @ X23_v5 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+CE0]);\n\tv419 = *([v417 @ X0_v17+E0]) == 0;\n\tif (v419) goto L_00D9;\n\tv446 = *([v417 @ X0_v17+B8]);\n\tv158 = *([v446 @ X8_v21+8]);\n\tv422 = *([v446 @ X8_v21+8]) == 0;\n\tif (v422) goto L_00E2;\nL_00D4:\n\tv430 = v205.m_OnClick == 0;\n\tv196 = ~v430;\n\tif (v196) goto L_00FD;\n\tgoto L_014C;\nL_00D9:\n\tv426 = *([v416 @ X23_v5 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+CE0]);\n\tv446 = *([v426 @ X0_v45+B8]);\n\tv158 = *([v446 @ X8_v21+8]);\n\tv437 = *([v446 @ X8_v21+8]) == 0;\n\tv428 = ~v437;\n\tif (v428) goto L_00D4;\nL_00E2:\n\tgoto L_00E7;\n\tv444 = \"il2cpp_codegen_runtime_class_init\"(v432, v160, v101, v96, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56);\n\tv455 = *([v109 @ X23_v6]);\n\tv447 = *([v455 @ X8_v27+B8]);\nL_00E7:\n\tv448 = System.Net.Configuration.SettingsSectionInternal;\n\tv451 = new *([v448 @ X8_v22 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+E60])();\n\tv456 = Il2CppMethodInfo;\n\tUnityEngine.Events.UnityAction::.ctor(v451, *([v446 @ X8_v21]), *([v456 @ X8_v24 (Il2CppMethodInfo)+E80]));\n\tv207 = *([v416 @ X23_v5 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+CE0]);\n\tv463 = *([v207 @ X8_v26+B8]) + 8;\n\t*([v463 @ X0_v41]) = v451;\n\tv183 = 0xF3F1B4(v463, v451, *([v456 @ X8_v24 (Il2CppMethodInfo)+E80]), 0, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56);\nL_00FD:\n\tUnityEngine.Events.UnityEvent::AddListener(v205.m_OnClick, v158);\n\tgoto L_0105;\n\tv459 = \"il2cpp_codegen_runtime_class_init\"(v452, v166, v104, v99, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56);\nL_0105:\n\tv184 = Singleton`1::get_Instance /* +1 sharing this address */(*([v83 @ X26_v4]));\n\tv468 = v184 + 0x80;\n\tv470 = CollectParticleData[];\n\tv473 = new *([v470 @ X23_v7 (Il2CppClass<CollectParticleData[]>)+990])();\n\tv475 = Il2CppMethodInfo;\n\tSystem.Action::.ctor(v473, this, *([v475 @ X8_v17 (Il2CppMethodInfo)+BC0]));\n\tv482 = System.Delegate::Combine(*([v468 @ X20_v9]), v473);\n\tv388 = v482 == 0;\n\tif (v388) goto L_0138;\n\tv495 = *([v482 @ X0_v27 (System.Delegate)]) != *([v470 @ X23_v7 (Il2CppClass<CollectParticleData[]>)+990]);\n\tif (v495) goto L_0137;\n\t*([v468 @ X20_v9]) = v482;\n\tv526 = *([v482 @ X0_v27 (System.Delegate)]) == *([v470 @ X23_v7 (Il2CppClass<CollectParticleData[]>)+990]);\n\tif (v526) goto L_013B;\nL_0137:\n\tthrow System.InvalidCastException;\nL_0138:\n\t*([v468 @ X20_v9]) = 0;\nL_013B:\n\tv535 = 0xF3F1B4(v468, v482, 0, 0, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56);\n\tGameplayScreen::UpdateMoveCounter(this);\n\treturn;\nL_014C:\n\tv212 = new System.NullReferenceException();\nL_014D:\n\tv245 = new System.ArrayTypeMismatchException();\n\tthrow v245;\n\tthrow System.IndexOutOfRangeException;\n// 228 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void OnInit()
	{
		//IL_000e: Expected I, but got O
		//IL_00d3: Expected O, but got I
		//IL_00e3: Expected O, but got I
		//IL_004d: Expected O, but got I
		//IL_005d: Expected O, but got I
		//IL_0147: Expected O, but got I
		//IL_015c: Expected O, but got I
		//IL_016f: Expected I, but got O
		//IL_018b: Expected O, but got I
		//IL_01da: Expected O, but got I
		//IL_01ef: Expected O, but got I
		//IL_0316: Expected I, but got O
		//IL_0326: Expected O, but got I
		//IL_03d2: Expected O, but got I
		//IL_03e2: Expected O, but got I
		//IL_03f2: Expected O, but got I
		//IL_035b: Expected O, but got I
		//IL_036b: Expected O, but got I
		//IL_0558: Expected I, but got O
		//IL_0588: Expected O, but got I
		//IL_059e: Expected O, but got I
		//IL_0469: Expected O, but got I
		//IL_0477: Expected I, but got O
		//IL_0529: Expected O, but got I4
		//IL_02ce: Expected O, but got I
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302AADD]");
		object obj3;
		object obj;
		if ((uint)((nuint)0u & (nuint)1u) != 0)
		{
			obj = (nint)0 + (nint)3216;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ X24_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A48]");
			object obj2 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X0_v105+E0]");
			bool flag = (nint)0 == 0;
			obj3 = obj;
			if (!flag)
			{
				goto IL_008a;
			}
		}
		else
		{
			_ = 1;
			obj = (nint)0 + (nint)3216;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ X24_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A48]");
			object obj4 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v101+E0]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			obj3 = obj;
			if (flag3)
			{
				goto IL_008a;
			}
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
		obj = obj3;
		goto IL_0137;
		IL_053c:
		global::System.ArrayTypeMismatchException ex = new global::System.ArrayTypeMismatchException();
		throw ex;
		IL_05b5:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		UpdateMoveCounter();
		return;
		IL_052e:
		global::System.NullReferenceException ex2 = new global::System.NullReferenceException();
		goto IL_053c;
		IL_008a:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
		object obj5 = default(object);
		if (obj5 != null)
		{
			goto IL_0137;
		}
		goto IL_052e;
		IL_0137:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v8+78]");
		object obj6 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v6+50]");
		object obj7 = 0;
		nint num2 = (nint)typeof(CollectParticleData[]);
		nint num3 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"SzArrayNew\"");
		GoalUI[] array = default(GoalUI[]);
		goals = array;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		int num4 = 32;
		int num5 = 0;
		global::UnityEngine.Component component = default(global::UnityEngine.Component);
		object obj11 = default(object);
		while (true)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v16+78]");
			object obj9 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v10+50]");
			object obj10 = 0;
			int num6 = num5;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X8_v11+18]");
			if ((nint)num6 >= (nint)0)
			{
				break;
			}
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1171058 (UnityEngine.Object::Instantiate, and 1 more at this address)");
			global::UnityEngine.Transform transform = component.transform;
			global::UnityEngine.Transform parent = goalParent.transform;
			transform.SetParent(parent, worldPositionStays: false);
			((GoalUI)component).Init(num5);
			GoalUI[] array2 = goals;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F36C");
			if (obj11 != null)
			{
				array2[num5] = (GoalUI)component;
				object obj12 = (nint)array2 + num4;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
				num5++;
				num4 += 8;
				continue;
			}
			goto IL_053c;
		}
		UIButton uIButton = settingsButton;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X23_v5 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+CE0]");
		object obj13 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X0_v17+E0]");
		object obj14;
		global::UnityEngine.Events.UnityAction call;
		if ((nint)0 != 0)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X0_v17+B8]");
			obj14 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X8_v21+8]");
			call = (global::UnityEngine.Events.UnityAction)0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X8_v21+8]");
			if ((nint)0 != 0)
			{
				goto IL_0390;
			}
		}
		else
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X23_v5 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+CE0]");
			object obj15 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X0_v45+B8]");
			obj14 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X8_v21+8]");
			call = (global::UnityEngine.Events.UnityAction)0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ X8_v21+8]");
			if ((nint)0 != 0)
			{
				goto IL_0390;
			}
		}
		object obj16 = obj14;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X8_v24 (Il2CppMethodInfo)+E80]");
		global::UnityEngine.Events.UnityAction unityAction = new global::UnityEngine.Events.UnityAction(obj16, (global::System.IntPtr)0);
		nint num9 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X23_v5 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+CE0]");
		object obj17 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v26+B8]");
		object obj18 = (nint)0 + (nint)8;
		obj18 = unityAction;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		call = unityAction;
		goto IL_0434;
		IL_0390:
		if (uIButton.m_OnClick != null)
		{
			goto IL_0434;
		}
		goto IL_052e;
		IL_0434:
		uIButton.m_OnClick.AddListener(call);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
		object obj19 = default(object);
		object a = (nint)obj19 + 128;
		nint num10 = (nint)typeof(CollectParticleData[]);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X8_v17 (Il2CppMethodInfo)+BC0]");
		global::System.Action b = new global::System.Action(this, (global::System.IntPtr)0);
		nint num11 = 0;
		global::System.Delegate obj20 = global::System.Delegate.Combine((global::System.Delegate)a, b);
		if ((object)obj20 != null)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X23_v7 (Il2CppClass<CollectParticleData[]>)+990]");
			if ((object)obj20 == null)
			{
				a = obj20;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X23_v7 (Il2CppClass<CollectParticleData[]>)+990]");
				if ((object)obj20 == null)
				{
					goto IL_05b5;
				}
			}
			throw new global::System.InvalidCastException();
		}
		a = 0;
		goto IL_05b5;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600043E")]
	[global::Cpp2ILInjected.Address(RVA = "0x101E780", Offset = "0x101E780", Length = "0xAC")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0015;\n\tv23 = Il2CppMethodInfo;\n\tv24 = v23 + 0x708;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, index, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv42 = 1;\n\t*([302AADE]) = v42;\nL_0015:\n\tv43 = this.goals;\n\tv126 = Il2CppMethodInfo;\n\tv127 = UnityEngine.Component::GetComponent /* +1 sharing this address */(v43[index @ X1 (System.Int32)], *([v126 @ X8_v7 (Il2CppMethodInfo)+708]));\n\tv91 = UnityEngine.Camera::get_main();\n\tv62 = UnityEngine.Transform::get_position(v127);\n\treturnVal2 = UnityEngine.Camera::ScreenToWorldPoint(v91, v62);\n\treturn returnVal2;\n\tv104 = new System.NullReferenceException();\n\tthrow System.IndexOutOfRangeException;\n\treturn returnVal1;\n// 60 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public global::UnityEngine.Vector2 GetWorldGoalPosition(int index)
	{
		GoalUI[] array = goals;
		nint num = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @111C708 (UnityEngine.Component::GetComponent, and 1 more at this address)");
		global::UnityEngine.Camera camera = global::UnityEngine.Camera.main;
		global::UnityEngine.Transform transform = default(global::UnityEngine.Transform);
		global::UnityEngine.Vector3 position = transform.position;
		return camera.ScreenToWorldPoint(position);
	}

	[global::Cpp2ILInjected.Token(Token = "0x600043F")]
	[global::Cpp2ILInjected.Address(RVA = "0x101E82C", Offset = "0x101E82C", Length = "0x2CC")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv16 = 0x302A000;\n\tv18 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv20 = *([302AB38]) & 1;\n\tv21 = v20 == 0;\n\tif (v21) goto L_0023;\n\tv51 = Il2CppMethodInfo + 0xC90;\n\tv24 = *([v18 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A48]);\n\tv26 = *([v24 @ X0_v61+E0]) == 0;\n\tif (v26) goto L_002D;\nL_0017:\n\tv54 = Singleton`1::get_Instance /* +1 sharing this address */(*([v51 @ X21_v15]));\n\tv63 = v54 == 0;\n\tv64 = ~v63;\n\tif (v64) goto L_0035;\n\tgoto L_00E6;\nL_0023:\n\t*([v16 @ X21_v1+B38]) = 1;\n\tv51 = Il2CppMethodInfo + 0xC90;\n\tv46 = *([v18 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A48]);\n\tv69 = *([v46 @ X0_v57+E0]) == 0;\n\tv48 = ~v69;\n\tif (v48) goto L_0017;\nL_002D:\n\tv66 = Singleton`1::get_Instance /* +1 sharing this address */(*([v58 @ X21_v12]));\nL_0035:\n\tv146 = this.moveCounter;\n\tv132 = System.Int32::ToString(&v130 @ stack_-34_v3 (System.Int32));\n\tv151 = *([v146 @ X20_v4 (TMPro.TextMeshProUGUI)]);\n\tv116 = *([v151 @ X8_v6 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]);\n\tv226 = TMPro.TMP_Text::set_text(v146, v132);\n\tElasticScale::Pop(this.moveCountElasticScale);\n\tv87 = v130 <= 5;\n\tif (v87) goto L_008C;\n\tv232 = TMPro.TMP_Text::set_color(this.moveCounter, Color_arg);\n\tv233 = ~this.isPulsing;\n\tif (v233) goto L_008B;\n\tUnityEngine.MonoBehaviour::StopCoroutine(this, this.pulseCoroutine);\n\tthis.isPulsing = 0;\n\tv283 = TMPro.TMP_Text::get_transform(this.moveCounter);\n\tgoto L_0079;\n\tv301 = System.Xml.ValidateNames;\n\tv302 = v301 + 0xD0;\n\tv303 = \"il2cpp_codegen_initialize_runtime_metadata\"(v302, v127, v115, v32, v33, v34, v35, v36, v84, v82, v80, v78, v41, v42, v43, v44);\n\tv304 = 1;\n\t*([2DD441A]) = v304;\nL_0079:\n\tv309 = System.Xml.ValidateNames;\n\tv311 = *([v309 @ X8_v26 (Il2CppClass<System.Xml.ValidateNames>)+D0]);\n\tv259 = *([v311 @ X8_v28+B8]);\n\t// 130 MakeStruct v249 @ AGG101E9B4_1_v2 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), [v259 @ X8_v29+C], [v259 @ X8_v29+10], [v259 @ X8_v29+14]\n\tUnityEngine.Transform::set_localScale(v283, v249);\nL_008B:\n\treturn;\nL_008C:\n\tv88 = v130 != 5;\n\tif (v88) goto L_FFFFFFFF;\n\tv236 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tgoto L_009C;\n\tv263 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv264 = v263 + 0xCF0;\n\tv265 = \"il2cpp_codegen_initialize_runtime_metadata\"(v264, v124, v114, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\tv267 = 1;\n\t*([302AB3A]) = v267;\nL_009C:\n\tv269 = new *([v236 @ X21_v8 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+CF0])();\n\tSystem.Object::.ctor(v269);\n\t*([v269 @ X0_v27 (System.Object)+10]) = 0;\n\tv285 = v269 + 0x20;\n\t*([v269 @ X0_v27 (System.Object)+20]) = this;\n\tv287 = 0xF3F1B4(v285, this, *([v151 @ X8_v6 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]), v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\tv244 = UnityEngine.MonoBehaviour::StartCoroutine(this, v269);\n\tv256 = TMPro.TMP_Text::set_color(this.moveCounter, Color_arg);\n\tv275 = ~this.isPulsing;\n\tv257 = ~v275;\n\tif (v257) goto L_008B;\n\tv279 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tgoto L_00CB;\n\tv288 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv289 = v288 + 0xCE8;\n\tv290 = \"il2cpp_codegen_initialize_runtime_metadata\"(v289, v254, v116, v32, v33, v34, v35, v36, v183, v180, v177, v174, v41, v42, v43, v44);\n\tv292 = 1;\n\t*([302AB39]) = v292;\nL_00CB:\n\tv294 = new *([v279 @ X21_v5 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+CE8])();\n\tSystem.Object::.ctor(v294);\n\t*([v294 @ X0_v14 (System.Object)+10]) = 0;\n\tv306 = v294 + 0x20;\n\t*([v294 @ X0_v14 (System.Object)+20]) = this;\n\tv308 = 0xF3F1B4(v306, this, v116, v32, v33, v34, v35, v36, 1f, 0x3F3D70A4, 0x3EBD70A4, 1f, v41, v42, v43, v44);\n\tv314 = UnityEngine.MonoBehaviour::StartCoroutine(this, v294);\n\tv315 = this + 0x90;\n\tthis.pulseCoroutine = v314;\n\tv206 = 0xF3F1B4(v315, v314, 0, v32, v33, v34, v35, v36, 1f, 0x3F3D70A4, 0x3EBD70A4, 1f, v41, v42, v43, v44);\n\treturn;\nL_00E6:\n\tthrow System.NullReferenceException;\n// 146 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void OnUserMove()
	{
		//IL_0009: Expected O, but got I4
		//IL_0017: Expected I, but got O
		//IL_00dc: Expected O, but got I
		//IL_00ec: Expected O, but got I
		//IL_0056: Expected O, but got I
		//IL_0066: Expected O, but got I
		//IL_0157: Expected I, but got O
		//IL_0167: Expected O, but got I
		//IL_02e4: Expected I, but got O
		//IL_0380: Expected I, but got O
		//IL_03de: Expected O, but got I
		//IL_040e: Expected O, but got I
		//IL_0300: Expected O, but got I4
		//IL_039f: Expected O, but got I
		//IL_0244: Expected I, but got O
		//IL_0254: Expected O, but got I
		//IL_0264: Expected O, but got I
		//IL_0279: Expected F4, but got I
		//IL_028e: Expected F4, but got I
		//IL_02a3: Expected F4, but got I
		object obj = 50503680;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302AB38]");
		if ((uint)((nuint)0u & (nuint)1u) != 0)
		{
			object obj2 = (nint)0 + (nint)3216;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A48]");
			object obj3 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X0_v61+E0]");
			bool flag = (nint)0 == 0;
			object obj4 = obj2;
			if (!flag)
			{
				goto IL_0093;
			}
		}
		else
		{
			_ = 1;
			object obj2 = (nint)0 + (nint)3216;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A48]");
			object obj5 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v57+E0]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			object obj4 = obj2;
			if (flag3)
			{
				goto IL_0093;
			}
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
		goto IL_0133;
		IL_0133:
		global::TMPro.TextMeshProUGUI textMeshProUGUI = moveCounter;
		int num2 = default(int);
		string text = num2.ToString();
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v6 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
		object obj6 = 0;
		textMeshProUGUI.text = text;
		moveCountElasticScale.Pop();
		if (num2 > 5)
		{
			global::UnityEngine.Color color = default(global::UnityEngine.Color);
			color.r = 1f;
			color.g = 1f;
			color.b = 1f;
			color.a = 1f;
			moveCounter.color = color;
			if (isPulsing)
			{
				StopCoroutine(pulseCoroutine);
				isPulsing = false;
				global::UnityEngine.Transform transform = moveCounter.transform;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X8_v26 (Il2CppClass<System.Xml.ValidateNames>)+D0]");
				object obj7 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v28+B8]");
				object obj8 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v29+C]");
				global::UnityEngine.Vector3 localScale = default(global::UnityEngine.Vector3);
				localScale.x = 0f;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v29+10]");
				localScale.y = 0f;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v29+14]");
				localScale.z = 0f;
				transform.localScale = localScale;
			}
			return;
		}
		if (num2 == 5)
		{
			object obj9 = new object();
			_ = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
			global::UnityEngine.Coroutine coroutine = StartCoroutine((global::System.Collections.IEnumerator)obj9);
			obj6 = 0;
		}
		global::UnityEngine.Color color2 = default(global::UnityEngine.Color);
		color2.r = 1f;
		color2.g = 0.74f;
		color2.b = 0.37f;
		color2.a = 1f;
		moveCounter.color = color2;
		if (!isPulsing)
		{
			object obj11 = new object();
			_ = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
			global::UnityEngine.Coroutine coroutine2 = StartCoroutine((global::System.Collections.IEnumerator)obj11);
			pulseCoroutine = coroutine2;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		}
		return;
		IL_0093:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
		object obj14 = default(object);
		if (obj14 == null)
		{
			throw new global::System.NullReferenceException();
		}
		goto IL_0133;
	}

	[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(GameplayScreen._003CPulseForever_003Ed__15))]
	[global::Cpp2ILInjected.Token(Token = "0x6000440")]
	[global::Cpp2ILInjected.Address(RVA = "0x101EB70", Offset = "0x101EB70", Length = "0x78")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tgoto L_0017;\n\tv23 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv24 = v23 + 0xCE8;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv43 = 1;\n\t*([302AB39]) = v43;\nL_0017:\n\tv45 = new *([v18 @ X21_v1 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+CE8])();\n\tSystem.Object::.ctor(v45);\n\t*([v45 @ X0_v3 (System.Object)+10]) = 0;\n\tv49 = v45 + 0x20;\n\t*([v45 @ X0_v3 (System.Object)+20]) = this;\n\tv51 = 0xF3F1B4(v49, this, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\treturn v45;\n// 28 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private global::System.Collections.IEnumerator PulseForever()
	{
		//IL_000e: Expected I, but got O
		//IL_0037: Expected O, but got I
		object obj = new object();
		_ = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		return (global::System.Collections.IEnumerator)obj;
	}

	[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(GameplayScreen._003CShowMovePopup_003Ed__16))]
	[global::Cpp2ILInjected.Token(Token = "0x6000441")]
	[global::Cpp2ILInjected.Address(RVA = "0x101EAF8", Offset = "0x101EAF8", Length = "0x78")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tgoto L_0017;\n\tv23 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv24 = v23 + 0xCF0;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, moves, methodInfo, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv43 = 1;\n\t*([302AB3A]) = v43;\nL_0017:\n\tv45 = new *([v18 @ X21_v1 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+CF0])();\n\tSystem.Object::.ctor(v45);\n\t*([v45 @ X0_v3 (System.Object)+10]) = 0;\n\tv49 = v45 + 0x20;\n\t*([v45 @ X0_v3 (System.Object)+20]) = this;\n\tv51 = 0xF3F1B4(v49, this, methodInfo, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\treturn v45;\n// 28 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private global::System.Collections.IEnumerator ShowMovePopup(int moves)
	{
		//IL_000e: Expected I, but got O
		//IL_0037: Expected O, but got I
		object obj = new object();
		_ = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		return (global::System.Collections.IEnumerator)obj;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000442")]
	[global::Cpp2ILInjected.Address(RVA = "0x101E6A8", Offset = "0x101E6A8", Length = "0xD8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv16 = 0x302A000;\n\tv18 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv20 = *([302AADF]) & 1;\n\tv21 = v20 == 0;\n\tif (v21) goto L_0024;\n\tv52 = Il2CppMethodInfo + 0xC90;\n\tv79 = this.moveCounter;\n\tv25 = *([v18 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A48]);\n\tv27 = *([v25 @ X0_v21+E0]) == 0;\n\tif (v27) goto L_002F;\nL_0018:\n\tv74 = Singleton`1::get_Instance /* +1 sharing this address */(*([v52 @ X21_v8]));\n\tv67 = v74 == 0;\n\tv68 = ~v67;\n\tif (v68) goto L_0035;\n\tgoto L_0047;\nL_0024:\n\t*([v16 @ X21_v1+ADF]) = 1;\n\tv52 = Il2CppMethodInfo + 0xC90;\n\tv79 = this.moveCounter;\n\tv47 = *([v18 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A48]);\n\tv73 = *([v47 @ X0_v17+E0]) == 0;\n\tv49 = ~v73;\n\tif (v49) goto L_0018;\nL_002F:\n\tv74 = Singleton`1::get_Instance /* +1 sharing this address */(*([v61 @ X21_v5]));\nL_0035:\n\tv92 = *([v74 @ X0_v3+78]) + 0x20;\n\tv85 = System.Int32::ToString(v92);\n\tv109 = *([v79 @ X19_v3 (TMPro.TextMeshProUGUI)]);\n\tv100 = *([v109 @ X8_v5 (Il2CppClass<TMPro.TextMeshProUGUI>)+558]);\n\tv98 = *([v109 @ X8_v5 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]);\n\t// 70 IndirectJump v100 @ X3_v1, v79 @ X19_v3 (TMPro.TextMeshProUGUI), v79 @ X19_v3 (TMPro.TextMeshProUGUI), v85 @ X0_v5 (System.String), v98 @ X2_v1, v100 @ X3_v1, v34 @ X4, v35 @ X5, v36 @ X6, v37 @ X7, v38 @ V0, v39 @ V1, v40 @ V2, v41 @ V3, v42 @ V4, v43 @ V5, v44 @ V6, v45 @ V7\nL_0047:\n\tthrow System.NullReferenceException;\n// 43 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private unsafe void UpdateMoveCounter()
	{
		//IL_0009: Expected O, but got I4
		//IL_0017: Expected I, but got O
		//IL_00f0: Expected O, but got I
		//IL_010a: Expected O, but got I
		//IL_0056: Expected O, but got I
		//IL_0070: Expected O, but got I
		//IL_0198: Expected I, but got O
		//IL_01a8: Expected O, but got I
		//IL_01b8: Expected O, but got I
		object obj = 50503680;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302AADF]");
		global::TMPro.TextMeshProUGUI textMeshProUGUI;
		global::TMPro.TextMeshProUGUI textMeshProUGUI2;
		if ((uint)((nuint)0u & (nuint)1u) != 0)
		{
			object obj2 = (nint)0 + (nint)3216;
			textMeshProUGUI = moveCounter;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A48]");
			object obj3 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X0_v21+E0]");
			bool flag = (nint)0 == 0;
			object obj4 = obj2;
			textMeshProUGUI2 = moveCounter;
			if (!flag)
			{
				goto IL_00a7;
			}
		}
		else
		{
			_ = 1;
			object obj2 = (nint)0 + (nint)3216;
			textMeshProUGUI = moveCounter;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A48]");
			object obj5 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v17+E0]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			object obj4 = obj2;
			textMeshProUGUI2 = moveCounter;
			if (flag3)
			{
				goto IL_00a7;
			}
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
		textMeshProUGUI = textMeshProUGUI2;
		goto IL_0168;
		IL_01c2:
		throw new global::System.NullReferenceException();
		IL_0168:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3+78]");
		int num2 = (int)((nint)0 + (nint)32);
		string text = num2.ToString();
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v5 (Il2CppClass<TMPro.TextMeshProUGUI>)+558]");
		object obj6 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v5 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
		object obj7 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v100 @ X3_v1 (should have been resolved before IL gen)");
		goto IL_01c2;
		IL_00a7:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
		object obj8 = default(object);
		if (obj8 != null)
		{
			goto IL_0168;
		}
		goto IL_01c2;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000443")]
	[global::Cpp2ILInjected.Address(RVA = "0x101EC40", Offset = "0x101EC40", Length = "0x88")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv16 = 0x302A000;\n\tv18 = System.Xml.ValidateNames;\n\tv20 = *([302AAE0]) & 1;\n\tv21 = v20 == 0;\n\tif (v21) goto L_0023;\n\tv22 = *([v18 @ X21_v1 (Il2CppClass<System.Xml.ValidateNames>)+198]);\n\tv24 = *([v22 @ X0_v10+E0]) == 0;\n\tif (v24) goto L_0033;\nL_001D:\n\tViewport::.ctor(this);\n\treturn;\nL_0023:\n\t*([v16 @ X20_v1+AE0]) = 1;\n\tv44 = *([v18 @ X21_v1 (Il2CppClass<System.Xml.ValidateNames>)+198]);\n\tv62 = *([v44 @ X0_v7+E0]) == 0;\n\tv46 = ~v62;\n\tif (v46) goto L_001D;\nL_0033:\n\tViewport::.ctor(this);\n\treturn;\n// 36 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public GameplayScreen()
	{
		//IL_0009: Expected O, but got I4
		//IL_0017: Expected I, but got O
		//IL_009c: Expected O, but got I
		//IL_005a: Expected O, but got I
		object obj = 50503680;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302AAE0]");
		if ((uint)((nuint)0u & (nuint)1u) != 0)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X21_v1 (Il2CppClass<System.Xml.ValidateNames>)+198]");
			object obj2 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X0_v10+E0]");
			if ((nint)0 != 0)
			{
				goto IL_007f;
			}
		}
		else
		{
			_ = 1;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X21_v1 (Il2CppClass<System.Xml.ValidateNames>)+198]");
			object obj3 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v7+E0]");
			if ((nint)0 != 0)
			{
				goto IL_007f;
			}
		}
		base._002Ector();
		return;
		IL_007f:
		base._002Ector();
	}
}
