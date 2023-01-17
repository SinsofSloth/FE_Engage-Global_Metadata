// Namespace: 
public class SoundWwise.SoundHandle : SoundSystem.SoundHandle // TypeDefIndex: 13805
{
	// Fields
	private string m_eventName; // 0x10
	private uint m_eventId; // 0x18
	private string m_lipSyncDataFileName; // 0x20
	private GameObject m_gameObject; // 0x28
	private uint m_playingId; // 0x30
	private bool m_isPlaying; // 0x34
	private bool m_isTemporaryGameObject; // 0x35
	private Character m_character; // 0x38
	private EventCharacterMouthController m_eventCharacterMouthController; // 0x40

	// Methods

	// RVA: 0x204CB90 Offset: 0x204CC91 VA: 0x204CB90
	public void .ctor() { }

	// RVA: 0x204CC20 Offset: 0x204CD21 VA: 0x204CC20
	public void Init(string eventName, GameObject gameObject, uint playingId, bool isTemporaryGameObject) { }

	// RVA: 0x204CD80 Offset: 0x204CE81 VA: 0x204CD80 Slot: 5
	public override string GetEventName() { }

	// RVA: 0x204CD90 Offset: 0x204CE91 VA: 0x204CD90 Slot: 6
	public override uint GetEventId() { }

	// RVA: 0x204CDA0 Offset: 0x204CEA1 VA: 0x204CDA0 Slot: 9
	public override bool IsPlaying() { }

	// RVA: 0x204CDB0 Offset: 0x204CEB1 VA: 0x204CDB0 Slot: 4
	public override GameObject GetGameObject() { }

	// RVA: 0x204CDC0 Offset: 0x204CEC1 VA: 0x204CDC0 Slot: 7
	public override uint GetPlayingId() { }

	// RVA: 0x204CDD0 Offset: 0x204CED1 VA: 0x204CDD0 Slot: 10
	public override Character GetCharacter() { }

	// RVA: 0x204CDE0 Offset: 0x204CEE1 VA: 0x204CDE0 Slot: 11
	public override EventCharacterMouthController GetEventCharacterMouthController() { }

	// RVA: 0x204CDF0 Offset: 0x204CEF1 VA: 0x204CDF0 Slot: 13
	public override void SetCharacter(Character character) { }

	// RVA: 0x204CE00 Offset: 0x204CF01 VA: 0x204CE00 Slot: 14
	public override void SetEventCharacterMouthController(EventCharacterMouthController eventCharacterMouthController) { }

	// RVA: 0x204CE10 Offset: 0x204CF11 VA: 0x204CE10 Slot: 12
	public override string GetLipSyncDataFileName() { }

	// RVA: 0x204CE20 Offset: 0x204CF21 VA: 0x204CE20
	public bool IsTemporaryObject() { }

	// RVA: 0x204CE30 Offset: 0x204CF31 VA: 0x204CE30
	public void SetIsPlaying(bool isPlaying) { }

	// RVA: 0x204CE40 Offset: 0x204CF41 VA: 0x204CE40
	public void SetLipSyncDataFileName(string lipSyncDataFileName) { }

	// RVA: 0x204CE50 Offset: 0x204CF51 VA: 0x204CE50 Slot: 8
	public override bool IsEnable() { }

	// RVA: 0x204CEF0 Offset: 0x204CFF1 VA: 0x204CEF0 Slot: 15
	public override void Stop(int fadeMsec) { }

	// RVA: 0x204CF80 Offset: 0x204D081 VA: 0x204CF80 Slot: 16
	public override void Pause(int fadeMsec) { }

	// RVA: 0x204D010 Offset: 0x204D111 VA: 0x204D010 Slot: 17
	public override void Resume(int fadeMsec) { }
}

// Namespace: 
public class SoundWwise.SoundParam : SoundSystem.ISoundParam // TypeDefIndex: 13806
{
	// Fields
	private static int MasterVolumeMin; // 0x0
	private static int MasterVolumeMax; // 0x4
	private static int ConfigVolumeMin; // 0x8
	private static int ConfigVolumeMax; // 0xC
	private static string MasterBgmVolumeName; // 0x10
	private static string MasterEnvVolumeName; // 0x18
	private static string MasterSeVolumeName; // 0x20
	private static string MasterVoiceVolumeName; // 0x28
	private static string ConfigBgmVolumeName; // 0x30
	private static string ConfigEnvVolumeName; // 0x38
	private static string ConfigSeVolumeName; // 0x40
	private static string ConfigVoiceVolumeName; // 0x48
	private GameObject m_rootGameObject; // 0x10

	// Methods

	// RVA: 0x204DAA0 Offset: 0x204DBA1 VA: 0x204DAA0
	public void .ctor() { }

	// RVA: 0x204DB30 Offset: 0x204DC31 VA: 0x204DB30
	private float GetVolumeCommon(string paramName, float min, float max) { }

	// RVA: 0x204DC30 Offset: 0x204DD31 VA: 0x204DC30
	private void SetVolumeCommon(string paramName, float vol, float min, float max, int fadeMsec) { }

	// RVA: 0x204DD20 Offset: 0x204DE21 VA: 0x204DD20
	private void ResetVolumeCommon(string paramName, int fadeMsec) { }

	// RVA: 0x204DDA0 Offset: 0x204DEA1 VA: 0x204DDA0
	private float GetMasterVolumeCommon(string paramName) { }

	// RVA: 0x204DE20 Offset: 0x204DF21 VA: 0x204DE20
	private void SetMasterVolumeCommon(string paramName, float vol, int fadeMsec) { }

	// RVA: 0x204DEC0 Offset: 0x204DFC1 VA: 0x204DEC0
	private void ResetMasterVolumeCommon(string paramName, int fadeMsec) { }

	// RVA: 0x204DF40 Offset: 0x204E041 VA: 0x204DF40
	private float GetConfigVolumeCommon(string paramName) { }

	// RVA: 0x204DFC0 Offset: 0x204E0C1 VA: 0x204DFC0
	private void SetConfigVolumeCommon(string paramName, float vol, int fadeMsec) { }

	// RVA: 0x204E060 Offset: 0x204E161 VA: 0x204E060 Slot: 4
	public float GetMasterBgmVolume() { }

	// RVA: 0x204E120 Offset: 0x204E221 VA: 0x204E120 Slot: 5
	public float GetMasterSeVolume() { }

	// RVA: 0x204E1E0 Offset: 0x204E2E1 VA: 0x204E1E0 Slot: 6
	public float GetMasterEnvVolume() { }

	// RVA: 0x204E2A0 Offset: 0x204E3A1 VA: 0x204E2A0 Slot: 7
	public float GetMasterVoiceVolume() { }

	// RVA: 0x204E360 Offset: 0x204E461 VA: 0x204E360 Slot: 8
	public void SetMasterBgmVolume(float vol, int fadeMsec) { }

	// RVA: 0x204E430 Offset: 0x204E531 VA: 0x204E430 Slot: 9
	public void SetMasterSeVolume(float vol, int fadeMsec) { }

	// RVA: 0x204E500 Offset: 0x204E601 VA: 0x204E500 Slot: 10
	public void SetMasterEnvVolume(float vol, int fadeMsec) { }

	// RVA: 0x204E5D0 Offset: 0x204E6D1 VA: 0x204E5D0 Slot: 11
	public void SetMasterVoiceVolume(float vol, int fadeMsec) { }

	// RVA: 0x204E6A0 Offset: 0x204E7A1 VA: 0x204E6A0 Slot: 12
	public void ResetMasterBgmVolume(int fadeMsec) { }

	// RVA: 0x204E760 Offset: 0x204E861 VA: 0x204E760 Slot: 13
	public void ResetMasterSeVolume(int fadeMsec) { }

	// RVA: 0x204E820 Offset: 0x204E921 VA: 0x204E820 Slot: 14
	public void ResetMasterEnvVolume(int fadeMsec) { }

	// RVA: 0x204E8E0 Offset: 0x204E9E1 VA: 0x204E8E0 Slot: 15
	public void ResetMasterVoiceVolume(int fadeMsec) { }

	// RVA: 0x204E9A0 Offset: 0x204EAA1 VA: 0x204E9A0 Slot: 16
	public float GetConfigBgmVolume() { }

	// RVA: 0x204EA60 Offset: 0x204EB61 VA: 0x204EA60 Slot: 17
	public float GetConfigSeVolume() { }

	// RVA: 0x204EB20 Offset: 0x204EC21 VA: 0x204EB20 Slot: 18
	public float GetConfigEnvVolume() { }

	// RVA: 0x204EBE0 Offset: 0x204ECE1 VA: 0x204EBE0 Slot: 19
	public float GetConfigVoiceVolume() { }

	// RVA: 0x204ECA0 Offset: 0x204EDA1 VA: 0x204ECA0 Slot: 20
	public void SetConfigBgmVolume(float vol, int fadeMsec) { }

	// RVA: 0x204ED70 Offset: 0x204EE71 VA: 0x204ED70 Slot: 21
	public void SetConfigSeVolume(float vol, int fadeMsec) { }

	// RVA: 0x204EE40 Offset: 0x204EF41 VA: 0x204EE40 Slot: 22
	public void SetConfigEnvVolume(float vol, int fadeMsec) { }

	// RVA: 0x204EF10 Offset: 0x204F011 VA: 0x204EF10 Slot: 23
	public void SetConfigVoiceVolume(float vol, int fadeMsec) { }

	// RVA: 0x204EFE0 Offset: 0x204F0E1 VA: 0x204EFE0 Slot: 24
	public void SetVolume(float vol, GameObject gameObject) { }

	// RVA: 0x204F060 Offset: 0x204F161 VA: 0x204F060 Slot: 25
	public bool GetValue(string valueName, bool isGlobal, out uint value) { }

	// RVA: 0x204F120 Offset: 0x204F221 VA: 0x204F120 Slot: 26
	public bool GetValue(string valueName, GameObject gameObject, bool isGlobal, out uint value) { }

	// RVA: 0x204F1E0 Offset: 0x204F2E1 VA: 0x204F1E0 Slot: 27
	public bool GetValue(string valueName, out float value) { }

	// RVA: 0x204F260 Offset: 0x204F361 VA: 0x204F260 Slot: 28
	public bool GetValue(string valueName, GameObject gameObject, out float value) { }

	// RVA: 0x204F2F0 Offset: 0x204F3F1 VA: 0x204F2F0 Slot: 29
	public bool SetValue(string valueName, bool isGlobal, string value) { }

	// RVA: 0x204F3F0 Offset: 0x204F4F1 VA: 0x204F3F0 Slot: 30
	public bool SetValue(string valueName, bool isGlobal, uint value) { }

	// RVA: 0x204F300 Offset: 0x204F401 VA: 0x204F300 Slot: 31
	public bool SetValue(string valueName, bool isGlobal, string value, GameObject gameObject) { }

	// RVA: 0x204F400 Offset: 0x204F501 VA: 0x204F400 Slot: 32
	public bool SetValue(string valueName, bool isGlobal, uint value, GameObject gameObject) { }

	// RVA: 0x204F4F0 Offset: 0x204F5F1 VA: 0x204F4F0 Slot: 33
	public bool SetValue(string valueName, float value) { }

	// RVA: 0x204F570 Offset: 0x204F671 VA: 0x204F570 Slot: 34
	public bool SetValue(string valueName, float value, GameObject gameObject) { }

	// RVA: 0x204F600 Offset: 0x204F701 VA: 0x204F600 Slot: 35
	public bool SetPosition(Vector3 pos, Vector3 foward, Vector3 up, GameObject gameObject) { }

	// RVA: 0x204F710 Offset: 0x204F811 VA: 0x204F710 Slot: 36
	public GameObject GetAudioListenerObject() { }

	// RVA: 0x204F780 Offset: 0x204F881 VA: 0x204F780 Slot: 37
	public Vector3 GetAudioListenerPosistion() { }

	// RVA: 0x204F7F0 Offset: 0x204F8F1 VA: 0x204F7F0 Slot: 38
	public Quaternion GetAudioListenerRotation() { }

	// RVA: 0x204F860 Offset: 0x204F961 VA: 0x204F860 Slot: 39
	public void SetAudioListenerPosition(Vector3 listenerPos) { }

	// RVA: 0x204F8F0 Offset: 0x204F9F1 VA: 0x204F8F0 Slot: 40
	public void SetAudioListenerRotation(Quaternion listenerRot) { }

	// RVA: 0x204F980 Offset: 0x204FA81 VA: 0x204F980
	private static void .cctor() { }
}

// Namespace: 
public class SoundWwise.SoundLoad : SoundSystem.ISoundLoad // TypeDefIndex: 13807
{
	// Methods

	// RVA: 0x204D0A0 Offset: 0x204D1A1 VA: 0x204D0A0 Slot: 4
	public void Load(string name) { }

	// RVA: 0x204D130 Offset: 0x204D231 VA: 0x204D130 Slot: 5
	public void LoadAsync(string name) { }

	// RVA: 0x204D1C0 Offset: 0x204D2C1 VA: 0x204D1C0 Slot: 6
	public bool IsLoading() { }

	// RVA: 0x204D240 Offset: 0x204D341 VA: 0x204D240 Slot: 7
	public bool IsLoading(string name) { }

	// RVA: 0x204D260 Offset: 0x204D361 VA: 0x204D260 Slot: 8
	public bool IsLoaded(string name) { }

	// RVA: 0x204D280 Offset: 0x204D381 VA: 0x204D280 Slot: 9
	public void Unload(string name) { }

	// RVA: 0x204D290 Offset: 0x204D391 VA: 0x204D290 Slot: 10
	public void UnloadAll() { }

	// RVA: 0x204D310 Offset: 0x204D411 VA: 0x204D310 Slot: 11
	public void ReloadBySetLanguage(Language.Voices language) { }

	// RVA: 0x204D3A0 Offset: 0x204D4A1 VA: 0x204D3A0 Slot: 12
	public bool PrepareEvent(string eventName) { }

	// RVA: 0x204D430 Offset: 0x204D531 VA: 0x204D430 Slot: 13
	public bool PrepareEvent(string[] eventNameArray) { }

	// RVA: 0x204D4C0 Offset: 0x204D5C1 VA: 0x204D4C0 Slot: 14
	public bool PrepareEventAsync(string eventName, out SoundSystem.ResultSoundLoad resultSoundLoad) { }

	// RVA: 0x204D550 Offset: 0x204D651 VA: 0x204D550 Slot: 15
	public bool PrepareEventAsync(string[] eventNameArray, out SoundSystem.ResultSoundLoad resultSoundLoad) { }

	// RVA: 0x204D5E0 Offset: 0x204D6E1 VA: 0x204D5E0 Slot: 16
	public void UnprepareEvent(string eventName) { }

	// RVA: 0x204D650 Offset: 0x204D751 VA: 0x204D650 Slot: 17
	public void UnprepareEvent(string[] eventNameArray) { }

	// RVA: 0x204D6C0 Offset: 0x204D7C1 VA: 0x204D6C0 Slot: 18
	public bool PrepareSwitch(string switchGroupName, string switchName) { }

	// RVA: 0x204D750 Offset: 0x204D851 VA: 0x204D750 Slot: 19
	public bool PrepareSwitch(string switchGroupName, string[] switchNameArray) { }

	// RVA: 0x204D7E0 Offset: 0x204D8E1 VA: 0x204D7E0 Slot: 20
	public bool PrepareSwitchAsync(string switchGroupName, string switchName, out SoundSystem.ResultSoundLoad resultSoundLoad) { }

	// RVA: 0x204D880 Offset: 0x204D981 VA: 0x204D880 Slot: 21
	public bool PrepareSwitchAsync(string switchGroupName, string[] switchNameArray, out SoundSystem.ResultSoundLoad resultSoundLoad) { }

	// RVA: 0x204D920 Offset: 0x204DA21 VA: 0x204D920 Slot: 22
	public void UnprepareSwitch(string switchGroupName, string switchName) { }

	// RVA: 0x204D9A0 Offset: 0x204DAA1 VA: 0x204D9A0 Slot: 23
	public void UnprepareSwitch(string switchGroupName, string[] switchNameArray) { }

	// RVA: 0x204DA20 Offset: 0x204DB21 VA: 0x204DA20 Slot: 24
	public void ClearPrepare() { }

	// RVA: 0x204DA90 Offset: 0x204DB91 VA: 0x204DA90
	public void .ctor() { }
}

// Namespace: 
private class SoundWwise.SoundPlay.GameObjectPool // TypeDefIndex: 13808
{
	// Fields
	private const int GameObjectDefaultNum = 128;
	private List<GameObject> m_objList; // 0x10

	// Methods

	// RVA: 0x21FB110 Offset: 0x21FB211 VA: 0x21FB110
	public void .ctor(GameObject parent) { }

	// RVA: 0x21FB260 Offset: 0x21FB361 VA: 0x21FB260
	public GameObject Pop() { }

	// RVA: 0x21FB300 Offset: 0x21FB401 VA: 0x21FB300
	public void Push(GameObject obj) { }
}

// Namespace: 
public class SoundWwise.SoundPlay : SoundSystem.ISoundPlay // TypeDefIndex: 13809
{
	// Fields
	private const uint DefaultCallbackFlag = 5;
	private const uint GetPositionFlag = 3145728;
	private GameObject m_rootGameObject; // 0x10
	private SoundWwise.SoundPlay.GameObjectPool m_soundObjects; // 0x18

	// Methods

	// RVA: 0x204FB50 Offset: 0x204FC51 VA: 0x204FB50
	public void .ctor() { }

	// RVA: 0x204FC20 Offset: 0x204FD21 VA: 0x204FC20 Slot: 4
	public GameObject PopTemporaryGameObject() { }

	// RVA: 0x204FC30 Offset: 0x204FD31 VA: 0x204FC30
	public void PushTemporaryGameObject(GameObject gameObject) { }

	// RVA: 0x204FC40 Offset: 0x204FD41 VA: 0x204FC40 Slot: 9
	public void PostEventCallback(object cookie, AkCallbackType type, AkCallbackInfo callbackInfo) { }

	// RVA: 0x2050480 Offset: 0x2050581 VA: 0x2050480
	private string[] GetMarkerCmdArgs(string markerName, string cmdName) { }

	// RVA: 0x2050670 Offset: 0x2050771 VA: 0x2050670 Slot: 5
	public bool IsEventLoaded(string eventName) { }

	// RVA: 0x20506E0 Offset: 0x20507E1 VA: 0x20506E0
	private bool IsEventLoaded_Common(string eventName) { }

	// RVA: 0x2050750 Offset: 0x2050851 VA: 0x2050750 Slot: 6
	public SoundSystem.SoundHandle PostEvent(string eventName, bool isGetPosition) { }

	// RVA: 0x2050940 Offset: 0x2050A41 VA: 0x2050940 Slot: 7
	public SoundSystem.SoundHandle PostEvent(string eventName, GameObject gameObject, bool isGetPosition) { }

	// RVA: 0x2050B30 Offset: 0x2050C31 VA: 0x2050B30 Slot: 8
	public SoundSystem.SoundHandle PostEventWithTemporaryGameObject(string eventName, GameObject temporaryGameObject, bool isGetPosition) { }

	// RVA: 0x2050D70 Offset: 0x2050E71 VA: 0x2050D70 Slot: 10
	public void StopSoundOnEvent(string eventName, int fadeMsec) { }

	// RVA: 0x2050E70 Offset: 0x2050F71 VA: 0x2050E70 Slot: 11
	public void StopSoundOnEvent(string eventName, int fadeMsec, GameObject gameObject) { }

	// RVA: 0x2050F70 Offset: 0x2051071 VA: 0x2050F70 Slot: 12
	public void PauseSoundOnEvent(string eventName, int fadeMsec) { }

	// RVA: 0x2051070 Offset: 0x2051171 VA: 0x2051070 Slot: 13
	public void PauseSoundOnEvent(string eventName, int fadeMsec, GameObject gameObject) { }

	// RVA: 0x2051170 Offset: 0x2051271 VA: 0x2051170 Slot: 14
	public void ResumeSoundOnEvent(string eventName, int fadeMsec) { }

	// RVA: 0x2051270 Offset: 0x2051371 VA: 0x2051270 Slot: 15
	public void ResumeSoundOnEvent(string eventName, int fadeMsec, GameObject gameObject) { }

	// RVA: 0x2051370 Offset: 0x2051471 VA: 0x2051370 Slot: 16
	public void StopByPlayingId(uint playingId, int fadeMsec) { }

	// RVA: 0x20513F0 Offset: 0x20514F1 VA: 0x20513F0 Slot: 17
	public int GetPlayPosition(uint playingId, int positionOffset) { }
}

// Namespace: 
public enum SoundWwise.SoundBankManager.States // TypeDefIndex: 13810
{
	// Fields
	public int value__; // 0x0
	public const SoundWwise.SoundBankManager.States Loading = 0;
	public const SoundWwise.SoundBankManager.States Loaded = 1;
	public const SoundWwise.SoundBankManager.States Unexist = 2;
}

// Namespace: 
private enum SoundWwise.SoundBankManager.InternalStates // TypeDefIndex: 13811
{
	// Fields
	public int value__; // 0x0
	public const SoundWwise.SoundBankManager.InternalStates Loading = 0;
	public const SoundWwise.SoundBankManager.InternalStates LoadSucceeded = 1;
	public const SoundWwise.SoundBankManager.InternalStates LoadFailed = 2;
}

// Namespace: 
private class SoundWwise.SoundBankManager.BankHandle // TypeDefIndex: 13812
{
	// Fields
	protected bool m_isPrepareLoad; // 0x10
	protected string m_bankName; // 0x18
	protected uint m_bankID; // 0x20
	protected int m_refCount; // 0x24
	protected SoundWwise.SoundBankManager.States m_state; // 0x28
	protected SoundWwise.SoundBankManager.InternalStates m_internalState; // 0x2C

	// Properties
	public string BankName { get; }
	public int RefCount { get; }
	public SoundWwise.SoundBankManager.States State { get; set; }
	public SoundWwise.SoundBankManager.InternalStates InternalState { get; }

	// Methods

	// RVA: 0x21FAB60 Offset: 0x21FAC61 VA: 0x21FAB60
	public void .ctor(string bankName, bool isPrepareLoad) { }

	// RVA: 0x21FAE50 Offset: 0x21FAF51 VA: 0x21FAE50
	public bool LoadBank() { }

	// RVA: 0x21FAF10 Offset: 0x21FB011 VA: 0x21FAF10
	public void UnloadBank() { }

	// RVA: 0x21FAF00 Offset: 0x21FB001 VA: 0x21FAF00
	public void IncRef() { }

	// RVA: 0x21FAF20 Offset: 0x21FB021 VA: 0x21FAF20
	public void DecRef() { }

	// RVA: 0x21FAF30 Offset: 0x21FB031 VA: 0x21FAF30
	public string get_BankName() { }

	// RVA: 0x21FAF40 Offset: 0x21FB041 VA: 0x21FAF40
	public int get_RefCount() { }

	// RVA: 0x21FAF50 Offset: 0x21FB051 VA: 0x21FAF50
	public SoundWwise.SoundBankManager.States get_State() { }

	// RVA: 0x21FAF60 Offset: 0x21FB061 VA: 0x21FAF60
	public void set_State(SoundWwise.SoundBankManager.States value) { }

	// RVA: 0x21FAF70 Offset: 0x21FB071 VA: 0x21FAF70
	public SoundWwise.SoundBankManager.InternalStates get_InternalState() { }

	// RVA: 0x21FAF80 Offset: 0x21FB081 VA: 0x21FAF80 Slot: 4
	protected virtual AKRESULT DoLoadBank() { }

	// RVA: 0x21FB050 Offset: 0x21FB151 VA: 0x21FB050 Slot: 5
	protected virtual void DoUnloadBank() { }

	// RVA: 0x21FADC0 Offset: 0x21FAEC1 VA: 0x21FADC0
	protected void LogLoadResult(AKRESULT result) { }
}

// Namespace: 
private class SoundWwise.SoundBankManager.AsyncBankHandle : SoundWwise.SoundBankManager.BankHandle // TypeDefIndex: 13813
{
	// Methods

	// RVA: 0x21FAB10 Offset: 0x21FAC11 VA: 0x21FAB10
	public void .ctor(string name, bool isPrepareLoad) { }

	// RVA: 0x21FABB0 Offset: 0x21FACB1 VA: 0x21FABB0 Slot: 4
	protected override AKRESULT DoLoadBank() { }

	// RVA: 0x21FACD0 Offset: 0x21FADD1 VA: 0x21FACD0
	private static void GlobalBankCallback(uint bankID, IntPtr pInMemoryBankPtr, AKRESULT loadResult, object cookie) { }
}

// Namespace: 
public class SoundWwise.SoundBankManager : SingletonProcInst<SoundWwise.SoundBankManager> // TypeDefIndex: 13814
{
	// Fields
	private Dictionary<string, SoundWwise.SoundBankManager.BankHandle> m_bankHandles; // 0x78
	private List<SoundWwise.SoundBankManager.BankHandle> m_workRemovingHandles; // 0x80

	// Methods

	// RVA: 0x204B860 Offset: 0x204B961 VA: 0x204B860
	public static void Create() { }

	// RVA: 0x204BA30 Offset: 0x204BB31 VA: 0x204BA30
	public static bool LoadBank(string name) { }

	// RVA: 0x204BBC0 Offset: 0x204BCC1 VA: 0x204BBC0
	public static bool LoadBankAsync(string name) { }

	// RVA: 0x204BD50 Offset: 0x204BE51 VA: 0x204BD50
	public static bool IsLoading() { }

	// RVA: 0x204BF30 Offset: 0x204C031 VA: 0x204BF30
	public static void UnloadBank(string name) { }

	// RVA: 0x204C090 Offset: 0x204C191 VA: 0x204C090
	public static void UnloadAllBanks() { }

	// RVA: 0x204C230 Offset: 0x204C331 VA: 0x204C230
	public static void Cleanup() { }

	// RVA: 0x204C3F0 Offset: 0x204C4F1 VA: 0x204C3F0
	public static void ReloadBankBySetLanguage(Language.Voices language) { }

	// RVA: 0x204C790 Offset: 0x204C891 VA: 0x204C790
	public static SoundWwise.SoundBankManager.States GetState(string name) { }

	// RVA: 0x204C900 Offset: 0x204CA01 VA: 0x204C900 Slot: 6
	protected override void OnTick() { }

	// RVA: 0x204CB50 Offset: 0x204CC51 VA: 0x204CB50 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x204BAC0 Offset: 0x204BBC1 VA: 0x204BAC0
	private bool LoadBankImpl(string bankName) { }

	// RVA: 0x204BC50 Offset: 0x204BD51 VA: 0x204BC50
	private bool LoadBankAsyncImpl(string bankName) { }

	// RVA: 0x204BDD0 Offset: 0x204BED1 VA: 0x204BDD0
	private bool IsLoadingImpl() { }

	// RVA: 0x204C010 Offset: 0x204C111 VA: 0x204C010
	private void UnloadBankImpl(string bankName) { }

	// RVA: 0x204CB80 Offset: 0x204CC81 VA: 0x204CB80
	private void UnloadBankImpl(SoundWwise.SoundBankManager.BankHandle handle) { }

	// RVA: 0x204C110 Offset: 0x204C211 VA: 0x204C110
	private void UnloadAllBanksImpl() { }

	// RVA: 0x204C2B0 Offset: 0x204C3B1 VA: 0x204C2B0
	private void CleanupImpl() { }

	// RVA: 0x204C480 Offset: 0x204C581 VA: 0x204C480
	private void ReloadImpl(Language.Voices language) { }

	// RVA: 0x204C870 Offset: 0x204C971 VA: 0x204C870
	private SoundWwise.SoundBankManager.States GetStateImpl(string bankName) { }

	// RVA: 0x204B900 Offset: 0x204BA01 VA: 0x204B900
	public void .ctor() { }
}

// Namespace: 
private class SoundWwise.SoundPrepareManager.Param // TypeDefIndex: 13815
{
	// Fields
	private int m_reference; // 0x10

	// Methods

	// RVA: 0x21FB4E0 Offset: 0x21FB5E1 VA: 0x21FB4E0
	public bool IncRef() { }

	// RVA: 0x21FB5C0 Offset: 0x21FB6C1 VA: 0x21FB5C0
	public bool DecRef() { }

	// RVA: 0x21FB3D0 Offset: 0x21FB4D1 VA: 0x21FB3D0
	public void .ctor() { }
}

// Namespace: 
private class SoundWwise.SoundPrepareManager.EventParam : SoundWwise.SoundPrepareManager.Param // TypeDefIndex: 13816
{
	// Fields
	private string m_eventName; // 0x18

	// Methods

	// RVA: 0x21FB390 Offset: 0x21FB491 VA: 0x21FB390
	public void .ctor(string eventName) { }

	// RVA: 0x21FB3E0 Offset: 0x21FB4E1 VA: 0x21FB3E0
	public string GetEventName() { }
}

// Namespace: 
private class SoundWwise.SoundPrepareManager.SwitchParam : SoundWwise.SoundPrepareManager.Param // TypeDefIndex: 13817
{
	// Fields
	private string m_switchGroupName; // 0x18
	private string m_switchName; // 0x20

	// Methods

	// RVA: 0x21FC100 Offset: 0x21FC201 VA: 0x21FC100
	public void .ctor(string switchGroupName, string switchName) { }

	// RVA: 0x21FC150 Offset: 0x21FC251 VA: 0x21FC150
	public string GetSwitchGroupName() { }

	// RVA: 0x21FC160 Offset: 0x21FC261 VA: 0x21FC160
	public string GetSwitchName() { }
}

// Namespace: 
private class SoundWwise.SoundPrepareManager.EventParamList // TypeDefIndex: 13818
{
	// Fields
	private Dictionary<string, SoundWwise.SoundPrepareManager.EventParam> m_paramList; // 0x10

	// Methods

	// RVA: 0x21FB3F0 Offset: 0x21FB4F1 VA: 0x21FB3F0
	public bool IncRef(string eventName) { }

	// RVA: 0x21FB500 Offset: 0x21FB601 VA: 0x21FB500
	public bool DecRef(string eventName) { }

	// RVA: 0x21FB5E0 Offset: 0x21FB6E1 VA: 0x21FB5E0
	public void Clear() { }

	// RVA: 0x21FB7F0 Offset: 0x21FB8F1 VA: 0x21FB7F0
	public void .ctor() { }
}

// Namespace: 
private class SoundWwise.SoundPrepareManager.SwitchParamList // TypeDefIndex: 13819
{
	// Fields
	private string m_switchGroupName; // 0x10
	private Dictionary<string, SoundWwise.SoundPrepareManager.SwitchParam> m_paramList; // 0x18

	// Methods

	// RVA: 0x21FBA70 Offset: 0x21FBB71 VA: 0x21FBA70
	public void .ctor(string switchGroupName) { }

	// RVA: 0x21FB960 Offset: 0x21FBA61 VA: 0x21FB960
	public bool IncRef(string switchName) { }

	// RVA: 0x21FBC50 Offset: 0x21FBD51 VA: 0x21FBC50
	public bool DecRef(string switchName) { }

	// RVA: 0x21FC170 Offset: 0x21FC271 VA: 0x21FC170
	public bool IsEmpty() { }

	// RVA: 0x21FBE50 Offset: 0x21FBF51 VA: 0x21FBE50
	public void Clear() { }
}

// Namespace: 
private class SoundWwise.SoundPrepareManager.SwitchGroupParamList // TypeDefIndex: 13820
{
	// Fields
	private Dictionary<string, SoundWwise.SoundPrepareManager.SwitchParamList> m_paramListList; // 0x10

	// Methods

	// RVA: 0x21FB880 Offset: 0x21FB981 VA: 0x21FB880
	public bool IncRef(string switchGroupName, string switchName) { }

	// RVA: 0x21FBB40 Offset: 0x21FBC41 VA: 0x21FBB40
	public bool DecRef(string switchGroupName, string switchName) { }

	// RVA: 0x21FBD10 Offset: 0x21FBE11 VA: 0x21FBD10
	public void Clear() { }

	// RVA: 0x21FC070 Offset: 0x21FC171 VA: 0x21FC070
	public void .ctor() { }
}

// Namespace: 
public class SoundWwise.SoundPrepareManager // TypeDefIndex: 13821
{
	// Fields
	private static SoundWwise.SoundPrepareManager.EventParamList m_eventParamList; // 0x0
	private static SoundWwise.SoundPrepareManager.SwitchGroupParamList m_switchGroupParamList; // 0x8

	// Methods

	// RVA: 0x2051470 Offset: 0x2051571 VA: 0x2051470
	public static bool IncRef_Event(string eventName) { }

	// RVA: 0x20514F0 Offset: 0x20515F1 VA: 0x20514F0
	public static bool DecRef_Event(string eventName) { }

	// RVA: 0x2051570 Offset: 0x2051671 VA: 0x2051570
	public static bool IncRef_Switch(string switchGroupName, string eventName) { }

	// RVA: 0x20515F0 Offset: 0x20516F1 VA: 0x20515F0
	public static bool DecRef_Switch(string switchGroupName, string eventName) { }

	// RVA: 0x2051670 Offset: 0x2051771 VA: 0x2051670
	public static void Clear() { }

	// RVA: 0x20516F0 Offset: 0x20517F1 VA: 0x20516F0
	public void .ctor() { }

	// RVA: 0x2051700 Offset: 0x2051801 VA: 0x2051700
	private static void .cctor() { }
}

