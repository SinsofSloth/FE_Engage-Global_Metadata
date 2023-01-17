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

