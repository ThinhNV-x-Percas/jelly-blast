[global::Cpp2ILInjected.Token(Token = "0x200003E")]
public class AudioManager : Singleton<AudioManager>
{
	[global::Cpp2ILInjected.Token(Token = "0x40000EC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public global::UnityEngine.Audio.AudioMixer masterMixer;

	[global::Cpp2ILInjected.Token(Token = "0x40000ED")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public global::UnityEngine.AudioSource sourcePrefab;

	[global::Cpp2ILInjected.Token(Token = "0x40000EE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public bool enableSounds;

	[global::Cpp2ILInjected.Token(Token = "0x6000165")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE79BC", Offset = "0xFE79BC", Length = "0x84")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0013;\n\tv17 = \"l1\";\n\tv18 = v17 + 0x450;\n\tv19 = \"il2cpp_codegen_initialize_runtime_metadata\"(v18, methodInfo, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34);\n\tv37 = 1;\n\t*([302A9B0]) = v37;\nL_0013:\n\tv39 = ApplicationManager::get_appData();\n\tv41 = v39.playerData;\n\tv47 = \"l1\";\n\tif (v41.soundsOn) goto L_FFFFFFFF;\n\tgoto L_0038;\nL_0038:\n\tv93 = UnityEngine.Audio.AudioMixer::SetFloat(v35.masterMixer, *([v47 @ X9_v1 (System.String)+450]), v73);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 45 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void Start()
	{
		PlayerData playerData = ApplicationManager.appData.playerData;
		float value = playerData.soundsOn ? 0f : (-80f);
		masterMixer.SetFloat("masterVolume", value);
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000166")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE7A40", Offset = "0xFE7A40", Length = "0x1A0")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_001C;\n\tv29 = Il2CppMethodInfo;\n\tv30 = v29 + 0x30;\n\tv31 = \"il2cpp_codegen_initialize_runtime_metadata\"(v30, clip, settings, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\tv51 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv52 = v51 + 0xFD8;\n\tv46 = \"il2cpp_codegen_initialize_runtime_metadata\"(v52, clip, settings, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\tv48 = 1;\n\t*([302A96A]) = v48;\nL_001C:\n\tv50 = ~this.enableSounds;\n\tif (v50) goto L_0087;\n\tv53 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv55 = *([v53 @ X22_v4 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv57 = *([v55 @ X0_v3+E0]) == 0;\n\tif (v57) goto L_002E;\n\tv128 = UnityEngine.Object::op_Implicit(clip);\n\tv126 = ~v128;\n\tv67 = ~v126;\n\tif (v67) goto L_0031;\n\tgoto L_0087;\nL_002E:\n\tv128 = UnityEngine.Object::op_Implicit(clip);\n\tv68 = ~v128;\n\tif (v68) goto L_0087;\nL_0031:\n\tv65 = ApplicationManager::get_appData();\n\tv131 = v65.playerData;\n\tv69 = ~v131.soundsOn;\n\tif (v69) goto L_0087;\n\tgoto L_0041;\n\tv153 = \"il2cpp_codegen_runtime_class_init\"(v149, v61, settings, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\nL_0041:\n\tv155 = Il2CppMethodInfo;\n\tv157 = UnityEngine.Object::Instantiate /* +1 sharing this address */(this.sourcePrefab, *([v155 @ X8_v10 (Il2CppMethodInfo)+30]));\n\tv136 = UnityEngine.Time::get_timeScale();\n\tv160 = settings.pitchVariance * -0.5f;\n\tv133 = settings.pitchVariance * 0.5f;\n\tv137 = UnityEngine.Random::Range(v160, v133);\n\tv161 = settings.pitch + v137;\n\tv162 = v136 * v161;\n\tUnityEngine.AudioSource::set_pitch(v157, v162);\n\tUnityEngine.AudioSource::set_volume(v157, settings.volume);\n\tUnityEngine.AudioSource::set_clip(v157, clip);\n\tUnityEngine.AudioSource::Play(v157);\n\tv144 = UnityEngine.Component::get_gameObject(v157);\n\tv175 = UnityEngine.AudioClip::get_length(clip);\n\tv101 = v175 * 3f;\n\tUnityEngine.Object::Destroy(v144, v101);\n\treturn;\nL_0087:\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 89 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void PlayClip(global::UnityEngine.AudioClip clip, AudioClipSettings settings)
	{
		if (!enableSounds)
		{
			return;
		}
		if (!clip)
		{
			return;
		}
		ApplicationData appData = ApplicationManager.appData;
		PlayerData playerData = appData.playerData;
		if (playerData.soundsOn)
		{
			float timeScale = global::UnityEngine.Time.timeScale;
			float minInclusive = settings.pitchVariance * -0.5f;
			float maxInclusive = settings.pitchVariance * 0.5f;
			float num3 = global::UnityEngine.Random.Range(minInclusive, maxInclusive);
			float num4 = settings.pitch + num3;
			float pitch = timeScale * num4;
			global::UnityEngine.AudioSource audioSource = global::UnityEngine.Object.Instantiate(sourcePrefab);
			audioSource.pitch = pitch;
			audioSource.volume = settings.volume;
			audioSource.clip = clip;
			audioSource.Play();
			global::UnityEngine.GameObject obj2 = audioSource.gameObject;
			float length = clip.length;
			float t = length * 3f;
			global::UnityEngine.Object.Destroy(obj2, t);
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000167")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE7BE0", Offset = "0xFE7BE0", Length = "0x7C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv20 = CollectParticleData[];\n\tgoto L_0018;\n\tv25 = CollectParticleData[];\n\tv26 = v25 + 0xCF8;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, clip, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41);\n\tv44 = 1;\n\t*([302A96B]) = v44;\nL_0018:\n\tv46 = new *([v20 @ X22_v1 (Il2CppClass<CollectParticleData[]>)+CF8])();\n\t*([v46 @ X0_v3 (System.Object)+10]) = 0x3F800000;\n\t*([v46 @ X0_v3 (System.Object)+18]) = 0x3F800000;\n\tSystem.Object::.ctor(v46);\n\tAudioManager::PlayClip(this, clip, v46);\n\treturn;\n// 30 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void PlayClip(global::UnityEngine.AudioClip clip)
	{
		PlayClip(clip, new AudioClipSettings());
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000168")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE7C70", Offset = "0xFE7C70", Length = "0xA8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv20 = CollectParticleData[];\n\tgoto L_0018;\n\tv25 = CollectParticleData[];\n\tv26 = v25 + 0xCF8;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, clipName, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41);\n\tv44 = 1;\n\t*([302A96C]) = v44;\nL_0018:\n\tv46 = new *([v20 @ X22_v1 (Il2CppClass<CollectParticleData[]>)+CF8])();\n\t*([v46 @ X0_v3 (System.Object)+10]) = 0x3F800000;\n\t*([v46 @ X0_v3 (System.Object)+18]) = 0x3F800000;\n\tSystem.Object::.ctor(v46);\n\tv51 = AudioClipManager::get_Instance();\n\tv56 = AudioClipManager::GetAudioClip(v51, clipName, &v54 @ stack_-38_v2 (UnityEngine.AudioClip));\n\tv58 = ~v56;\n\tif (v58) goto L_0033;\n\tAudioManager::PlayClip(this, v54, v46);\nL_0033:\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 35 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void PlayClip(string clipName)
	{
		AudioClipManager instance = AudioClipManager.Instance;
		if (instance != null && instance.GetAudioClip(clipName, out var result))
		{
			PlayClip(result, new AudioClipSettings());
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000169")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE7D18", Offset = "0xFE7D18", Length = "0x64")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv21 = AudioClipManager::get_Instance();\n\tv26 = AudioClipManager::GetAudioClip(v21, clipName, &v24 @ stack_-38_v2 (UnityEngine.AudioClip));\n\tv41 = ~v26;\n\tif (v41) goto L_001F;\n\tAudioManager::PlayClip(this, v24, settings);\nL_001F:\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 26 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void PlayClip(string clipName, AudioClipSettings settings)
	{
		AudioClipManager instance = AudioClipManager.Instance;
		if (instance != null && instance.GetAudioClip(clipName, out var result))
		{
			PlayClip(result, settings);
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x600016A")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE7268", Offset = "0xFE7268", Length = "0x84")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0013;\n\tv17 = \"l1\";\n\tv18 = v17 + 0x450;\n\tv19 = \"il2cpp_codegen_initialize_runtime_metadata\"(v18, methodInfo, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34);\n\tv37 = 1;\n\t*([302A9B0]) = v37;\nL_0013:\n\tv39 = ApplicationManager::get_appData();\n\tv41 = v39.playerData;\n\tv47 = \"l1\";\n\tif (v41.soundsOn) goto L_FFFFFFFF;\n\tgoto L_0038;\nL_0038:\n\tv93 = UnityEngine.Audio.AudioMixer::SetFloat(v35.masterMixer, *([v47 @ X9_v1 (System.String)+450]), v73);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 45 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void UpdateVolume()
	{
		PlayerData playerData = ApplicationManager.appData.playerData;
		float value = playerData.soundsOn ? 0f : (-80f);
		masterMixer.SetFloat("masterVolume", value);
	}

	[global::Cpp2ILInjected.Token(Token = "0x600016B")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE7D7C", Offset = "0xFE7D7C", Length = "0xA4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv16 = 0x302A000;\n\tv18 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv20 = *([302A96D]) & 1;\n\tv21 = v20 == 0;\n\tif (v21) goto L_0028;\n\tv51 = Il2CppMethodInfo + 0xC68;\n\tv24 = *([v18 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A38]);\n\tv26 = *([v24 @ X0_v13+E0]) == 0;\n\tif (v26) goto L_003A;\nL_001F:\n\tSingleton`1::.ctor /* +1 sharing this address */(this, *([v51 @ X21_v6]));\n\treturn;\nL_0028:\n\t*([v16 @ X21_v1+96D]) = 1;\n\tv51 = Il2CppMethodInfo + 0xC68;\n\tv46 = *([v18 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A38]);\n\tv79 = *([v46 @ X0_v10+E0]) == 0;\n\tv48 = ~v79;\n\tif (v48) goto L_001F;\nL_003A:\n\tSingleton`1::.ctor /* +1 sharing this address */(this, *([v64 @ X21_v2]));\n\treturn;\n// 41 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public AudioManager()
	{
	}
}
