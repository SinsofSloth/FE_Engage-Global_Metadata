// Namespace: 
public interface SoundSystem.ISoundLoad // TypeDefIndex: 13794
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Load(string name);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void LoadAsync(string name);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool IsLoading();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool IsLoading(string name);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool IsLoaded(string name);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Unload(string name);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void UnloadAll();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void ReloadBySetLanguage(Language.Voices language);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool PrepareEvent(string eventName);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool PrepareEvent(string[] eventNameArray);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool PrepareEventAsync(string eventName, out SoundSystem.ResultSoundLoad resultSoundLoad);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract bool PrepareEventAsync(string[] eventNameArray, out SoundSystem.ResultSoundLoad resultSoundLoad);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void UnprepareEvent(string eventNameArray);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void UnprepareEvent(string[] eventNameArray);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract bool PrepareSwitch(string switchGroupName, string switchName);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract bool PrepareSwitch(string switchGroupName, string[] switchNameArray);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract bool PrepareSwitchAsync(string switchGroupName, string switchName, out SoundSystem.ResultSoundLoad resultSoundLoad);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract bool PrepareSwitchAsync(string switchGroupName, string[] switchNameArray, out SoundSystem.ResultSoundLoad resultSoundLoad);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void UnprepareSwitch(string switchGroupName, string switchNameArray);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void UnprepareSwitch(string switchGroupName, string[] switchNameArray);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void ClearPrepare();
}

// Namespace: 
public interface SoundSystem.ISoundParam // TypeDefIndex: 13795
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract float GetMasterBgmVolume();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract float GetMasterSeVolume();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract float GetMasterEnvVolume();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract float GetMasterVoiceVolume();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void SetMasterBgmVolume(float vol, int fadeMsec);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void SetMasterSeVolume(float vol, int fadeMsec);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void SetMasterEnvVolume(float vol, int fadeMsec);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void SetMasterVoiceVolume(float vol, int fadeMsec);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void ResetMasterBgmVolume(int fadeMsec);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void ResetMasterSeVolume(int fadeMsec);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void ResetMasterEnvVolume(int fadeMsec);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void ResetMasterVoiceVolume(int fadeMsec);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract float GetConfigBgmVolume();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract float GetConfigSeVolume();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract float GetConfigEnvVolume();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract float GetConfigVoiceVolume();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void SetConfigBgmVolume(float vol, int fadeMsec);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void SetConfigSeVolume(float vol, int fadeMsec);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void SetConfigEnvVolume(float vol, int fadeMsec);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void SetConfigVoiceVolume(float vol, int fadeMsec);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void SetVolume(float vol, GameObject gameObject);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract bool GetValue(string valueName, bool isGlobal, out uint value);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract bool GetValue(string valueName, GameObject gameObject, bool isGlobal, out uint value);

	// RVA: -1 Offset: -1 Slot: 23
	public abstract bool GetValue(string valueName, out float value);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract bool GetValue(string valueName, GameObject gameObject, out float value);

	// RVA: -1 Offset: -1 Slot: 25
	public abstract bool SetValue(string valueName, bool isGlobal, string value);

	// RVA: -1 Offset: -1 Slot: 26
	public abstract bool SetValue(string valueName, bool isGlobal, uint value);

	// RVA: -1 Offset: -1 Slot: 27
	public abstract bool SetValue(string valueName, bool isGlobal, string value, GameObject gameObject);

	// RVA: -1 Offset: -1 Slot: 28
	public abstract bool SetValue(string valueName, bool isGlobal, uint value, GameObject gameObject);

	// RVA: -1 Offset: -1 Slot: 29
	public abstract bool SetValue(string valueName, float value);

	// RVA: -1 Offset: -1 Slot: 30
	public abstract bool SetValue(string valueName, float value, GameObject gameObject);

	// RVA: -1 Offset: -1 Slot: 31
	public abstract bool SetPosition(Vector3 pos, Vector3 foward, Vector3 up, GameObject gameObject);

	// RVA: -1 Offset: -1 Slot: 32
	public abstract GameObject GetAudioListenerObject();

	// RVA: -1 Offset: -1 Slot: 33
	public abstract Vector3 GetAudioListenerPosistion();

	// RVA: -1 Offset: -1 Slot: 34
	public abstract Quaternion GetAudioListenerRotation();

	// RVA: -1 Offset: -1 Slot: 35
	public abstract void SetAudioListenerPosition(Vector3 listenerPos);

	// RVA: -1 Offset: -1 Slot: 36
	public abstract void SetAudioListenerRotation(Quaternion listenerRot);
}

// Namespace: 
public interface SoundSystem.ISoundPlay // TypeDefIndex: 13796
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract GameObject PopTemporaryGameObject();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool IsEventLoaded(string eventName);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract SoundSystem.SoundHandle PostEvent(string name, bool isGetPosition);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract SoundSystem.SoundHandle PostEvent(string name, GameObject gameObject, bool isGetPosition);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract SoundSystem.SoundHandle PostEventWithTemporaryGameObject(string name, GameObject temporaryGameObject, bool isGetPosition);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void PostEventCallback(object cookie, AkCallbackType type, AkCallbackInfo callbackInfo);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void StopSoundOnEvent(string eventName, int fadeMsec);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void StopSoundOnEvent(string eventName, int fadeMsec, GameObject gameObject);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void PauseSoundOnEvent(string eventName, int fadeMsec);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void PauseSoundOnEvent(string eventName, int fadeMsec, GameObject gameObject);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void ResumeSoundOnEvent(string eventName, int fadeMsec);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void ResumeSoundOnEvent(string eventName, int fadeMsec, GameObject gameObject);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void StopByPlayingId(uint playingId, int fadeMsec);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract int GetPlayPosition(uint playingId, int positionOffset);
}

// Namespace: 
public class SoundSystem.SoundHandle // TypeDefIndex: 13797
{
	// Methods

	// RVA: 0x204B620 Offset: 0x204B721 VA: 0x204B620
	public void .ctor() { }

	// RVA: 0x204B6B0 Offset: 0x204B7B1 VA: 0x204B6B0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x204B780 Offset: 0x204B881 VA: 0x204B780 Slot: 4
	public virtual GameObject GetGameObject() { }

	// RVA: 0x204B790 Offset: 0x204B891 VA: 0x204B790 Slot: 5
	public virtual string GetEventName() { }

	// RVA: 0x204B7A0 Offset: 0x204B8A1 VA: 0x204B7A0 Slot: 6
	public virtual uint GetEventId() { }

	// RVA: 0x204B7B0 Offset: 0x204B8B1 VA: 0x204B7B0 Slot: 7
	public virtual uint GetPlayingId() { }

	// RVA: 0x204B7C0 Offset: 0x204B8C1 VA: 0x204B7C0 Slot: 8
	public virtual bool IsEnable() { }

	// RVA: 0x204B7D0 Offset: 0x204B8D1 VA: 0x204B7D0 Slot: 9
	public virtual bool IsPlaying() { }

	// RVA: 0x204B7E0 Offset: 0x204B8E1 VA: 0x204B7E0 Slot: 10
	public virtual Character GetCharacter() { }

	// RVA: 0x204B7F0 Offset: 0x204B8F1 VA: 0x204B7F0 Slot: 11
	public virtual EventCharacterMouthController GetEventCharacterMouthController() { }

	// RVA: 0x204B800 Offset: 0x204B901 VA: 0x204B800 Slot: 12
	public virtual string GetLipSyncDataFileName() { }

	// RVA: 0x204B810 Offset: 0x204B911 VA: 0x204B810 Slot: 13
	public virtual void SetCharacter(Character character) { }

	// RVA: 0x204B820 Offset: 0x204B921 VA: 0x204B820 Slot: 14
	public virtual void SetEventCharacterMouthController(EventCharacterMouthController eventCharacterMouthController) { }

	// RVA: 0x204B830 Offset: 0x204B931 VA: 0x204B830 Slot: 15
	public virtual void Stop(int fadeMsec) { }

	// RVA: 0x204B840 Offset: 0x204B941 VA: 0x204B840 Slot: 16
	public virtual void Pause(int fadeMsec) { }

	// RVA: 0x204B850 Offset: 0x204B951 VA: 0x204B850 Slot: 17
	public virtual void Resume(int fadeMsec) { }
}

// Namespace: 
public struct SoundSystem.LipSyncStructData // TypeDefIndex: 13798
{
	// Fields
	public int m_msec; // 0x0
	public float m_width; // 0x4
	public float m_height; // 0x8
	public float m_tongue; // 0xC
	public float m_a; // 0x10
	public float m_i; // 0x14
	public float m_u; // 0x18
	public float m_e; // 0x1C
	public float m_o; // 0x20
	public float m_vol; // 0x24
}

// Namespace: 
public class SoundSystem.LipSyncData // TypeDefIndex: 13799
{
	// Fields
	private SoundSystem.LipSyncStructData m_data; // 0x10

	// Properties
	public int Msec { get; set; }
	public float Width { get; set; }
	public float Height { get; set; }
	public float Tongue { get; set; }
	public float A { get; set; }
	public float I { get; set; }
	public float U { get; set; }
	public float E { get; set; }
	public float O { get; set; }
	public float Vol { get; set; }

	// Methods

	// RVA: 0x204A3A0 Offset: 0x204A4A1 VA: 0x204A3A0
	public int get_Msec() { }

	// RVA: 0x204A3B0 Offset: 0x204A4B1 VA: 0x204A3B0
	public void set_Msec(int value) { }

	// RVA: 0x204A3C0 Offset: 0x204A4C1 VA: 0x204A3C0
	public float get_Width() { }

	// RVA: 0x204A3D0 Offset: 0x204A4D1 VA: 0x204A3D0
	public void set_Width(float value) { }

	// RVA: 0x204A3E0 Offset: 0x204A4E1 VA: 0x204A3E0
	public float get_Height() { }

	// RVA: 0x204A3F0 Offset: 0x204A4F1 VA: 0x204A3F0
	public void set_Height(float value) { }

	// RVA: 0x204A400 Offset: 0x204A501 VA: 0x204A400
	public float get_Tongue() { }

	// RVA: 0x204A410 Offset: 0x204A511 VA: 0x204A410
	public void set_Tongue(float value) { }

	// RVA: 0x204A420 Offset: 0x204A521 VA: 0x204A420
	public float get_A() { }

	// RVA: 0x204A430 Offset: 0x204A531 VA: 0x204A430
	public void set_A(float value) { }

	// RVA: 0x204A440 Offset: 0x204A541 VA: 0x204A440
	public float get_I() { }

	// RVA: 0x204A450 Offset: 0x204A551 VA: 0x204A450
	public void set_I(float value) { }

	// RVA: 0x204A460 Offset: 0x204A561 VA: 0x204A460
	public float get_U() { }

	// RVA: 0x204A470 Offset: 0x204A571 VA: 0x204A470
	public void set_U(float value) { }

	// RVA: 0x204A480 Offset: 0x204A581 VA: 0x204A480
	public float get_E() { }

	// RVA: 0x204A490 Offset: 0x204A591 VA: 0x204A490
	public void set_E(float value) { }

	// RVA: 0x204A4A0 Offset: 0x204A5A1 VA: 0x204A4A0
	public float get_O() { }

	// RVA: 0x204A4B0 Offset: 0x204A5B1 VA: 0x204A4B0
	public void set_O(float value) { }

	// RVA: 0x204A4C0 Offset: 0x204A5C1 VA: 0x204A4C0
	public float get_Vol() { }

	// RVA: 0x204A4D0 Offset: 0x204A5D1 VA: 0x204A4D0
	public void set_Vol(float value) { }

	// RVA: 0x204A4E0 Offset: 0x204A5E1 VA: 0x204A4E0
	public void SetData(SoundSystem.LipSyncStructData data) { }

	// RVA: 0x204A500 Offset: 0x204A601 VA: 0x204A500
	public void .ctor() { }
}

// Namespace: 
public class SoundSystem.LipSyncDataFile // TypeDefIndex: 13800
{
	// Fields
	private const int LoadDirectoryMax = 1;
	private bool m_isExpandFileData; // 0x10
	private List<SoundSystem.LipSyncData> m_lipSyncDataList; // 0x18
	private RawFileHandle[] m_rawFileHandle; // 0x20

	// Methods

	// RVA: 0x204A510 Offset: 0x204A611 VA: 0x204A510
	private static string GetLipSyncFilePath(string fileName, int patchIndex = -1) { }

	// RVA: 0x204A9E0 Offset: 0x204AAE1 VA: 0x204A9E0
	private static string GetLipSyncFileRelativePath(string fileName) { }

	// RVA: 0x204ABF0 Offset: 0x204ACF1 VA: 0x204ABF0
	public void .ctor() { }

	// RVA: 0x204AD30 Offset: 0x204AE31 VA: 0x204AD30
	public int GetLipSyncDataCount() { }

	// RVA: 0x204AD80 Offset: 0x204AE81 VA: 0x204AD80
	public SoundSystem.LipSyncData GetLipSyncData(int index) { }

	// RVA: 0x204ADF0 Offset: 0x204AEF1 VA: 0x204ADF0
	public void LoadAsync(string fileName) { }

	// RVA: 0x204AE70 Offset: 0x204AF71 VA: 0x204AE70
	public bool ExpandFileData() { }

	// RVA: 0x204B130 Offset: 0x204B231 VA: 0x204B130
	public void Unload() { }
}

// Namespace: 
public enum SoundSystem.ResultSoundLoad.Status // TypeDefIndex: 13801
{
	// Fields
	public int value__; // 0x0
	public const SoundSystem.ResultSoundLoad.Status Load = 0;
	public const SoundSystem.ResultSoundLoad.Status Success = 1;
	public const SoundSystem.ResultSoundLoad.Status Fault = 2;
}

// Namespace: 
public class SoundSystem.ResultSoundLoad // TypeDefIndex: 13802
{
	// Fields
	private SoundSystem.ResultSoundLoad.Status m_status; // 0x10

	// Methods

	// RVA: 0x204B190 Offset: 0x204B291 VA: 0x204B190
	public void .ctor() { }

	// RVA: 0x204B1A0 Offset: 0x204B2A1 VA: 0x204B1A0
	public void SetStatus(SoundSystem.ResultSoundLoad.Status status) { }

	// RVA: 0x204B1B0 Offset: 0x204B2B1 VA: 0x204B1B0
	public bool IsLoading() { }

	// RVA: 0x204B1C0 Offset: 0x204B2C1 VA: 0x204B1C0
	public bool IsLoadSuccess() { }

	// RVA: 0x204B1D0 Offset: 0x204B2D1 VA: 0x204B1D0
	public bool IsLoadFault() { }

	// RVA: 0x204B1E0 Offset: 0x204B2E1 VA: 0x204B1E0
	public static void LoadAsyncCallback(uint bankID, IntPtr pInMemoryBankPtr, AKRESULT loadResult, object cookie) { }
}

// Namespace: 
public class SoundSystem.ResultSoundLoadList // TypeDefIndex: 13803
{
	// Fields
	private List<SoundSystem.ResultSoundLoad> m_resultList; // 0x10

	// Methods

	// RVA: 0x204B280 Offset: 0x204B381 VA: 0x204B280
	public void .ctor() { }

	// RVA: 0x204B310 Offset: 0x204B411 VA: 0x204B310
	public void Add(SoundSystem.ResultSoundLoad result) { }

	// RVA: 0x204B370 Offset: 0x204B471 VA: 0x204B370
	public bool IsLoading() { }

	// RVA: 0x204B4C0 Offset: 0x204B5C1 VA: 0x204B4C0
	public bool IsLoadSuccess() { }
}

