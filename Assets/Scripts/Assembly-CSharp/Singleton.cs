[global::Cpp2ILInjected.Token(Token = "0x20000CC")]
public abstract class Singleton<T> : Singleton where T : global::UnityEngine.MonoBehaviour
{
	[global::Cpp2ILInjected.Token(Token = "0x4000465")]
	private static T _instance;

	[global::Cpp2ILInjected.Token(Token = "0x4000466")]
	private static readonly object Lock = new object();

	[global::UnityEngine.SerializeField]
	[global::Cpp2ILInjected.Token(Token = "0x4000467")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
	private bool _persistent;

	[global::Cpp2ILInjected.Token(Token = "0x1700003D")]
	public static T Instance
	{
		[global::Cpp2ILInjected.Token(Token = "0x60003A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x18AB640", Offset = "0x18AB640", Length = "0x630")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv20 = 0x302B000;\n\tv22 = *([302BA80]) & 1;\n\tv23 = v22 == 0;\n\tif (v23) goto L_0023;\n\tv28 = *([2DD447A]) == 0;\n\tif (v28) goto L_002F;\nL_0016:\n\tv58 = System.Net.Configuration.SettingsSectionInternal;\n\tv60 = *([v58 @ X8_v144 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+A8]);\n\tv61 = *([v60 @ X8_v146+B8]);\n\tv63 = *([v61 @ X8_v147]) == 0;\n\tif (v63) goto L_0038;\n\tgoto L_0211;\nL_0023:\n\t*([v20 @ X20_v1+A80]) = 1;\n\tv74 = *([2DD447A]) == 0;\n\tv53 = ~v74;\n\tif (v53) goto L_0016;\nL_002F:\n\t*([2DD447A]) = 1;\n\tv96 = System.Net.Configuration.SettingsSectionInternal;\n\tv98 = *([v96 @ X8_v135 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+A8]);\n\tv99 = *([v98 @ X8_v137+B8]);\n\tv100 = *([v99 @ X8_v138]) == 0;\n\tv79 = ~v100;\n\tif (v79) goto L_FFFFFFFF;\nL_0038:\n\tv90 = Il2CppClass<Singleton`1>;\n\tv93 = *([v90 @ X0_v4 (Il2CppClass<Singleton`1>)+135]) & 1;\n\tv94 = v93 == 0;\n\tif (v94) goto L_00CB;\n\tv174 = Il2CppClass<Singleton`1<T>>;\n\tv177 = *([v174 @ X0_v158 (Il2CppClass<Singleton`1<T>>)+135]) & 1;\n\tv178 = v177 == 0;\n\tif (v178) goto L_00D4;\nL_0046:\n\tv234 = *([v227 @ X0_v157 (Il2CppClass<Singleton`1<T>>)+E0]) == 0;\n\tif (v234) goto L_00DA;\nL_0048:\n\tv90 = Il2CppClass<Singleton`1>;\n\tv251 = *([v90 @ X0_v4 (Il2CppClass<Singleton`1>)+135]) & 1;\n\tv252 = v251 == 0;\n\tif (v252) goto L_00E1;\n\tgoto L_0057;\nL_0056:\n\tv285 = 0xF7055C(Il2CppClass<Singleton`1<T>>, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\nL_0057:\n\tv288 = *([v285 @ X0_v15 (Il2CppClass<Singleton`1<T>>)+B8]);\n\tv289 = *([v288 @ X8_v19 (Il2CppStaticFields<Singleton`1<T>>)+8]);\n\tv153 = 0;\n\tSystem.Threading.Monitor::Enter(*([v288 @ X8_v19 (Il2CppStaticFields<Singleton`1<T>>)+8]), &v153 @ stack_-49_v3 (System.Boolean));\n\tgoto L_0072;\n\tv304 = 0xF7055C(v298, v293, v294, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\nL_0072:\n\tgoto L_0077;\n\tv313 = 0xF7055C(v307, v293, v294, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\nL_0077:\n\tgoto L_007F;\n\tv318 = \"il2cpp_codegen_runtime_class_init\"(v314, v293, v294, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\nL_007F:\n\tgoto L_0088;\n\tv326 = 0xF7055C(v320, v293, v294, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\nL_0088:\n\tgoto L_0092;\n\tv335 = 0xF7055C(v329, v293, v294, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\nL_0092:\n\tgoto L_0097;\n\tv344 = \"il2cpp_codegen_runtime_class_init\"(v340, v293, v294, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\nL_0097:\n\tv348 = UnityEngine.Object::op_Inequality(v337._instance, 0);\n\tv350 = v348 == 0;\n\tif (v350) goto L_00EE;\n\tgoto L_00AA;\n\tv361 = 0xF7055C(v351, v347, v138, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\nL_00AA:\n\tgoto L_00AF;\n\tv378 = 0xF7055C(v364, v347, v138, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\nL_00AF:\n\tgoto L_00B7;\n\tv388 = \"il2cpp_codegen_runtime_class_init\"(v379, v347, v138, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\nL_00B7:\n\tgoto L_00C0;\n\tv398 = 0xF7055C(v390, v347, v138, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\nL_00C0:\n\tgoto L_00C4;\n\tv440 = 0xF7055C(v401, v347, v138, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\nL_00C4:\n\tv497 = v443._instance;\n\tv445 = &v153 @ stack_-49_v3 (System.Boolean);\n\tv447 = *([v445 @ X8_v118]) == 0;\n\tv448 = ~v447;\n\tif (v448) goto L_0200;\n\tgoto L_0204;\nL_00CB:\n\tv90 = 0xF7055C(Il2CppClass<Singleton`1>, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv239 = *([v90 @ X0_v4 (Il2CppClass<Singleton`1>)+C0]);\n\tv227 = *([v239 @ X8_v15+10]);\n\tv241 = *([v227 @ X0_v157 (Il2CppClass<Singleton`1<T>>)+135]) & 1;\n\tv242 = v241 == 0;\n\tv230 = ~v242;\n\tif (v230) goto L_0046;\nL_00D4:\n\tv90 = 0xF7055C(v235, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv257 = *([v90 @ X0_v4 (Il2CppClass<Singleton`1>)+E0]) == 0;\n\tv245 = ~v257;\n\tif (v245) goto L_0048;\nL_00DA:\n\tv90 = Il2CppClass<Singleton`1>;\n\tv276 = *([v90 @ X0_v4 (Il2CppClass<Singleton`1>)+135]) & 1;\n\tv277 = v276 == 0;\n\tv261 = ~v277;\n\tif (v261) goto L_FFFFFFFF;\nL_00E1:\n\tv90 = 0xF7055C(v90, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv295 = *([v90 @ X0_v4 (Il2CppClass<Singleton`1>)+C0]);\n\tv285 = *([v295 @ X8_v7+10]);\n\tv297 = *([v285 @ X0_v15 (Il2CppClass<Singleton`1<T>>)+135]) & 1;\n\tv281 = v297 == 0;\n\tif (v281) goto L_0056;\n\tgoto L_0057;\nL_00EE:\n\tgoto L_00F6;\n\tv370 = \"il2cpp_codegen_runtime_class_init\"(v357, v347, v138, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\nL_00F6:\n\tgoto L_00FA;\n\tv383 = 0xF7055C(v372, v347, v138, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\nL_00FA:\n\tv387 = UnityEngine.Object::FindObjectsOfType();\n\tv397 = v387 == 0;\n\tif (v397) goto L_0218;\n\tv568 = v387.Length;\n\tv418 = v387.Length < 1;\n\tif (v418) goto L_0152;\n\tv449 = v387.Length != 1;\n\tif (v449) goto L_FFFFFFFF;\n\tv497 = v387[0];\n\tgoto L_011D;\n\tv572 = 0xF7055C(v509, v347, v138, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\nL_011D:\n\tgoto L_0122;\n\tv601 = 0xF7055C(v575, v347, v138, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\nL_0122:\n\tgoto L_012A;\n\tv619 = \"il2cpp_codegen_runtime_class_init\"(v602, v347, v138, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\nL_012A:\n\tgoto L_0133;\n\tv640 = 0xF7055C(v621, v347, v138, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\nL_0133:\n\tgoto L_0136;\n\tv663 = 0xF7055C(v643, v347, v138, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\nL_0136:\n\tv665._instance = v387[0];\n\tgoto L_FFFFFFFF;\n\tv683 = 0xF7055C(v666, v347, v138, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tgoto L_014A;\n\tv697 = 0xF7055C(v686, v347, v138, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\nL_014A:\n\tv90 = 0xF3F1B4(*([v698 @ X0_v119 (Il2CppClass<Singleton`1<T>>)+B8]), v387[0], 0, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tgoto L_01FC;\nL_0152:\n\tgoto L_015B;\n\tv516 = 0xF7055C(v450, v347, v138, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\nL_015B:\n\tgoto L_0160;\n\tv594 = 0xF7055C(v519, v347, v138, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\nL_0160:\n\tgoto L_0168;\n\tv607 = \"il2cpp_codegen_runtime_class_init\"(v595, v347, v138, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\nL_0168:\n\tgoto L_0171;\n\tv629 = 0xF7055C(v609, v347, v138, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\nL_0171:\n\tgoto L_0174;\n\tv652 = 0xF7055C(v632, v347, v138, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\nL_0174:\n\tv654._instance = 0;\n\tgoto L_FFFFFFFF;\n\tv674 = 0xF7055C(v655, v347, v138, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tgoto L_0188;\n\tv694 = 0xF7055C(v677, v347, v138, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\nL_0188:\n\tv90 = 0xF3F1B4(*([v695 @ X0_v64 (Il2CppClass<Singleton`1<T>>)+B8]), 0, 0, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv702 = &v153 @ stack_-49_v3 (System.Boolean);\n\tv703 = *([v702 @ X8_v64]) == 0;\n\tv491 = ~v703;\n\tif (v491) goto L_0200;\n\tgoto L_0204;\nL_0192:\n\tv526 = v530 - 4;\n\tv593 = v526 < v568;\n\tv557 = ~v593;\n\tif (v557) goto L_0212;\n\tv566 = *([v387 @ X0_v51 (T[])+v530 @ X23_v9 (System.Int32)*8]) == 0;\n\tif (v566) goto L_0214;\n\tv628 = UnityEngine.Component::get_gameObject(*([v387 @ X0_v51 (T[])+v530 @ X23_v9 (System.Int32)*8]));\n\tgoto L_01AB;\n\tv672 = \"il2cpp_codegen_runtime_class_init\"(v649, v627, v138, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\nL_01AB:\n\tUnityEngine.Object::Destroy(v628);\n\tv568 = v387.Length;\n\tv530 = v530 + 1;\n\tv525 = v530 - 4;\n\tv532 = v525 < v387.Length;\n\tif (v532) goto L_0192;\n\tv497 = v387[0];\n\tgoto L_01CD;\n\tv718 = 0xF7055C(v705, v558, v138, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\nL_01CD:\n\tgoto L_01D2;\n\tv727 = 0xF7055C(v721, v558, v138, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\nL_01D2:\n\tgoto L_01DA;\n\tv732 = \"il2cpp_codegen_runtime_class_i\n// ... truncated")]
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_006f: Expected I, but got O
			//IL_007f: Expected O, but got I
			//IL_008f: Expected O, but got I
			//IL_0100: Expected I, but got O
			//IL_0110: Expected O, but got I
			//IL_0120: Expected O, but got I
			//IL_036f: Expected O, but got I
			//IL_0264: Expected O, but got I
			//IL_0282: Expected O, but got I
			//IL_0463: Expected O, but got I
			//IL_087b: Expected I, but got O
			//IL_02f6: Expected O, but got I4
			//IL_08cf: Expected O, but got I4
			//IL_0846: Expected I, but got O
			//IL_05e4: Expected O, but got I4
			//IL_068d: Expected O, but got I
			//IL_075f: Expected O, but got I4
			if (_instance != null)
			{
				return _instance;
			}
			bool lockTaken = false;
			try
			{
				global::System.Threading.Monitor.Enter(Lock, ref lockTaken);
				if (_instance != null)
				{
					return _instance;
				}
				T[] array = global::UnityEngine.Object.FindObjectsOfType<T>();
				if (array == null)
				{
					return default(T);
				}
				if (array.Length >= 1)
				{
					if (array.Length == 1)
					{
						_instance = array[0];
						return _instance;
					}
					for (int i = 1; i < array.Length; i++)
					{
						if (array[i] != null)
						{
							global::UnityEngine.Object.Destroy(array[i].gameObject);
						}
					}
					_instance = array[0];
					return _instance;
				}
				_instance = null;
				return null;
			}
			finally
			{
				if (lockTaken)
				{
					global::System.Threading.Monitor.Exit(Lock);
				}
			}
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003A3")]
	[global::Cpp2ILInjected.Address(RVA = "0x18ABC70", Offset = "0x18ABC70", Length = "0x1CC")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0016;\n\tv23 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv24 = v23 + 0xFD8;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, methodInfo, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv42 = 1;\n\t*([302BA81]) = v42;\nL_0016:\n\tv44 = ~this._persistent;\n\tif (v44) goto L_0087;\n\tgoto L_0022;\n\tv79 = 0xF7055C(v47, methodInfo, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\nL_0022:\n\tv81 = Facebook.Unity.Windows.IWindowsFacebook;\n\tgoto L_002C;\n\tv115 = \"il2cpp_codegen_runtime_class_init\"(v80, methodInfo, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\nL_002C:\n\tv120 = Singleton`1<T>::get_Instance();\n\tv121 = *([v81 @ X22_v3 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv123 = *([v121 @ X0_v9+E0]) == 0;\n\tif (v123) goto L_003E;\n\tv127 = UnityEngine.Object::op_Inequality(v120, 0);\n\tv129 = ~v127;\n\tv130 = ~v129;\n\tif (v130) goto L_0049;\n\tgoto L_007C;\nL_003E:\n\tv134 = UnityEngine.Object::op_Inequality(v120, 0);\n\tv139 = ~v134;\n\tif (v139) goto L_007C;\nL_0049:\n\tgoto L_004E;\n\tv166 = 0xF7055C(v142, v136, v135, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\nL_004E:\n\tgoto L_0053;\n\tv173 = \"il2cpp_codegen_runtime_class_init\"(v167, v136, v135, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\nL_0053:\n\tv178 = Singleton`1<T>::get_Instance();\n\tv181 = *([v81 @ X22_v3 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv182 = *([v181 @ X0_v23+E0]) == 0;\n\tif (v182) goto L_0076;\n\tv155 = UnityEngine.Object::op_Inequality(v178, this);\n\tv158 = ~v155;\n\tif (v158) goto L_007C;\nL_0061:\n\tv191 = UnityEngine.Component::get_gameObject(this);\n\tv194 = *([v81 @ X22_v3 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv100 = *([v194 @ X0_v30+E0]) == 0;\n\tif (v100) goto L_009D;\n\tUnityEngine.Object::Destroy(v191);\n\treturn;\nL_0076:\n\tv154 = UnityEngine.Object::op_Inequality(v178, this);\n\tv192 = ~v154;\n\tv157 = ~v192;\n\tif (v157) goto L_0061;\nL_007C:\n\tv165 = UnityEngine.Component::get_gameObject(this);\n\tgoto L_0086;\n\tv179 = \"il2cpp_codegen_runtime_class_init\"(v171, v164, v54, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\nL_0086:\n\tUnityEngine.Object::DontDestroyOnLoad(v165);\nL_0087:\n\tv69 = this->klass;\n\tv70 = this->klass->vtable[4];\n\tv71 = this->klass->vtable[4];\n\t// 146 IndirectJump v70 @ X2_v2, this @ X0 (Singleton`1<T>), this @ X0 (Singleton`1<T>), v71 @ X1_v2, v70 @ X2_v2, v27 @ X3, v28 @ X4, v29 @ X5, v30 @ X6, v31 @ X7, v32 @ V0, v33 @ V1, v34 @ V2, v35 @ V3, v36 @ V4, v37 @ V5, v38 @ V6, v39 @ V7\nL_009D:\n\tUnityEngine.Object::Destroy(v191);\n\treturn;\n// 103 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void Awake()
	{
		//IL_01cf: Expected I, but got O
		//IL_01df: Expected O, but got I
		//IL_01ef: Expected O, but got I
		//IL_0018: Expected I, but got O
		//IL_0036: Expected O, but got I
		//IL_00e1: Expected O, but got I
		//IL_0147: Expected O, but got I
		if (_persistent)
		{
			global::UnityEngine.Object instance = Instance;
			if (instance != null)
			{
				global::UnityEngine.Object instance2 = Instance;
				if (instance2 != this)
				{
					global::UnityEngine.Object.Destroy(base.gameObject);
					return;
				}
			}
			global::UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		}
		OnAwake();
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003A4")]
	[global::Cpp2ILInjected.Address(RVA = "0x18ABE3C", Offset = "0x18ABE3C", Length = "0x4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn;\n")]
	protected virtual void OnAwake()
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003A5")]
	[global::Cpp2ILInjected.Address(RVA = "0x18ABE40", Offset = "0x18ABE40", Length = "0x8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tSingleton::.ctor(this);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	protected Singleton()
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003A6")]
	[global::Cpp2ILInjected.Address(RVA = "0x18ABE48", Offset = "0x18ABE48", Length = "0x110")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = Facebook.Unity.Windows.IWindowsFacebook;\n\tgoto L_0017;\n\tv23 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv24 = v23 + 0xFD0;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv43 = 1;\n\t*([302BA82]) = v43;\nL_0017:\n\tv45 = new *([v18 @ X21_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD0])();\n\tSystem.Object::.ctor(v45);\n\tv48 = Il2CppClass<Singleton`1>;\n\tv51 = *([v48 @ X0_v4 (Il2CppClass<Singleton`1>)+135]) & 1;\n\tv52 = v51 == 0;\n\tif (v52) goto L_0045;\n\tv54 = Il2CppClass<Singleton`1<T>>;\n\tv57 = *([v54 @ X0_v22 (Il2CppClass<Singleton`1<T>>)+135]) & 1;\n\tv58 = v57 == 0;\n\tif (v58) goto L_004E;\nL_0028:\n\tv66 = *([v60 @ X0_v20 (Il2CppClass<Singleton`1<T>>)+B8]);\n\t*([v66 @ X8_v24 (Il2CppStaticFields<Singleton`1<T>>)+8]) = v45;\n\tv67 = Il2CppClass<Singleton`1>;\n\tv70 = *([v67 @ X0_v21 (Il2CppClass<Singleton`1>)+135]) & 1;\n\tv71 = v70 == 0;\n\tif (v71) goto L_0058;\n\tgoto L_003A;\nL_0038:\n\tv108 = 0xF7055C(Il2CppClass<Singleton`1<T>>, 0, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\nL_003A:\n\tv112 = *([v108 @ X0_v13 (Il2CppClass<Singleton`1<T>>)+B8]) + 8;\n\tv120 = 0xF3F1B4(v112, v45, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\treturn;\nL_0045:\n\tv59 = 0xF7055C(Il2CppClass<Singleton`1>, 0, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv76 = *([v59 @ X0_v11+C0]);\n\tv60 = *([v76 @ X8_v13+10]);\n\tv78 = *([v60 @ X0_v20 (Il2CppClass<Singleton`1<T>>)+135]) & 1;\n\tv79 = v78 == 0;\n\tv63 = ~v79;\n\tif (v63) goto L_0028;\nL_004E:\n\tv75 = 0xF7055C(v72, 0, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv97 = *([v75 @ X0_v9+B8]);\n\t*([v97 @ X8_v10+8]) = v45;\n\tv81 = Il2CppClass<Singleton`1>;\n\tv99 = *([v81 @ X0_v10 (Il2CppClass<Singleton`1>)+135]) & 1;\n\tv100 = v99 == 0;\n\tv83 = ~v100;\n\tif (v83) goto L_FFFFFFFF;\nL_0058:\n\tv96 = 0xF7055C(v93, 0, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv121 = *([v96 @ X0_v6+C0]);\n\tv108 = *([v121 @ X8_v6+10]);\n\tv123 = *([v108 @ X0_v13 (Il2CppClass<Singleton`1<T>>)+135]) & 1;\n\tv104 = v123 == 0;\n\tif (v104) goto L_0038;\n\tgoto L_003A;\n\treturn;\n// 47 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	static Singleton()
	{
		//IL_000e: Expected I, but got O
		//IL_0101: Expected O, but got I
		//IL_01da: Expected O, but got I
		//IL_0171: Expected O, but got I
		//IL_00dc: Expected O, but got I
		Lock = new object();
	}
}
[global::Cpp2ILInjected.Token(Token = "0x20000CD")]
public abstract class Singleton : global::UnityEngine.MonoBehaviour
{
	private static bool _quitting;

	[global::Cpp2ILInjected.Token(Token = "0x1700003E")]
	public static bool Quitting
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x60003A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1015DA0", Offset = "0x1015DA0", Length = "0x4C")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv12 = System.Net.Configuration.SettingsSectionInternal;\n\tgoto L_0013;\n\tv17 = System.Net.Configuration.SettingsSectionInternal;\n\tv18 = v17 + 0xA8;\n\tv19 = \"il2cpp_codegen_initialize_runtime_metadata\"(v18, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34);\n\tv38 = 1;\n\t*([302AA88]) = v38;\nL_0013:\n\tv39 = *([v12 @ X20_v1 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+A8]);\n\tv40 = *([v39 @ X8_v3+B8]);\n\treturn *([v40 @ X8_v4]);\n// 18 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		get
		{
			//IL_000e: Expected I, but got O
			//IL_0023: Expected O, but got I
			//IL_0033: Expected O, but got I
			//IL_0038: Expected I4, but got O
			return _quitting;
		}
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x60003A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1015DEC", Offset = "0x1015DEC", Length = "0x58")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = System.Net.Configuration.SettingsSectionInternal;\n\tgoto L_0016;\n\tv23 = System.Net.Configuration.SettingsSectionInternal;\n\tv24 = v23 + 0xA8;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv43 = 1;\n\t*([302AA89]) = v43;\nL_0016:\n\tv44 = *([v18 @ X21_v1 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+A8]);\n\tv45 = *([v44 @ X8_v3+B8]);\n\t*([v45 @ X8_v4]) = value;\n\treturn;\n// 22 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		private set
		{
			//IL_000e: Expected I, but got O
			//IL_0023: Expected O, but got I
			//IL_0033: Expected O, but got I
			//IL_003b: Expected O, but got I4
			_quitting = value;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003A9")]
	[global::Cpp2ILInjected.Address(RVA = "0x1015E44", Offset = "0x1015E44", Length = "0x50")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0010;\n\tv14 = System.Net.Configuration.SettingsSectionInternal;\n\tv15 = v14 + 0xA8;\n\tv16 = \"il2cpp_codegen_initialize_runtime_metadata\"(v15, methodInfo, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31);\n\tv35 = 1;\n\t*([2DD4434]) = v35;\nL_0010:\n\tv36 = System.Net.Configuration.SettingsSectionInternal;\n\tv38 = *([v36 @ X8_v3 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+A8]);\n\tv39 = *([v38 @ X8_v5+B8]);\n\t*([v39 @ X8_v6]) = 1;\n\treturn;\n// 17 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void OnApplicationQuit()
	{
		//IL_0013: Expected I, but got O
		//IL_0023: Expected O, but got I
		//IL_0033: Expected O, but got I
		//IL_003c: Expected O, but got I4
		Quitting = true;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003AA")]
	[global::Cpp2ILInjected.Address(RVA = "0x1015E94", Offset = "0x1015E94", Length = "0x4C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0010;\n\tv14 = System.Net.Configuration.SettingsSectionInternal;\n\tv15 = v14 + 0xA8;\n\tv16 = \"il2cpp_codegen_initialize_runtime_metadata\"(v15, methodInfo, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31);\n\tv35 = 1;\n\t*([2DD4434]) = v35;\nL_0010:\n\tv36 = System.Net.Configuration.SettingsSectionInternal;\n\tv38 = *([v36 @ X8_v3 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+A8]);\n\tv39 = *([v38 @ X8_v5+B8]);\n\t*([v39 @ X8_v6]) = 0;\n\treturn;\n// 16 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void OnEnable()
	{
		//IL_0013: Expected I, but got O
		//IL_0023: Expected O, but got I
		//IL_0033: Expected O, but got I
		//IL_003c: Expected O, but got I4
		Quitting = false;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003AB")]
	[global::Cpp2ILInjected.Address(RVA = "0x1015EE0", Offset = "0x1015EE0", Length = "0x8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	protected internal Singleton()
	{
	}
}
