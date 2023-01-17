// Namespace: 
public enum GameSound.FadeSpeedType // TypeDefIndex: 13377
{
	// Fields
	public int value__; // 0x0
	public const GameSound.FadeSpeedType Immediate = 0;
	public const GameSound.FadeSpeedType VeryFast = 1;
	public const GameSound.FadeSpeedType Fast = 2;
	public const GameSound.FadeSpeedType Normal = 3;
	public const GameSound.FadeSpeedType Slow = 4;
	public const GameSound.FadeSpeedType VerySlow = 5;
}

// Namespace: 
private enum GameSound.UnitHP // TypeDefIndex: 13378
{
	// Fields
	public int value__; // 0x0
	public const GameSound.UnitHP High = 0;
	public const GameSound.UnitHP High_Serious = 1;
	public const GameSound.UnitHP Middle = 2;
	public const GameSound.UnitHP Low = 3;
}

// Namespace: 
public class GameSound.Handle // TypeDefIndex: 13379
{
	// Fields
	private SoundSystem.SoundHandle m_soundHandle; // 0x10

	// Methods

	// RVA: 0x22E9780 Offset: 0x22E9881 VA: 0x22E9780
	public void .ctor() { }

	// RVA: 0x22E9800 Offset: 0x22E9901 VA: 0x22E9800
	public void .ctor(SoundSystem.SoundHandle soundHandle) { }

	// RVA: 0x22E9840 Offset: 0x22E9941 VA: 0x22E9840
	public string GetEventName() { }

	// RVA: 0x22E9860 Offset: 0x22E9961 VA: 0x22E9860
	public GameObject GetGameObject() { }

	// RVA: 0x22E9880 Offset: 0x22E9981 VA: 0x22E9880
	public uint GetPlayingId() { }

	// RVA: 0x22E98A0 Offset: 0x22E99A1 VA: 0x22E98A0
	public string GetLipSyncDataFileName() { }

	// RVA: 0x22E98C0 Offset: 0x22E99C1 VA: 0x22E98C0
	public bool IsEnable() { }

	// RVA: 0x22E98E0 Offset: 0x22E99E1 VA: 0x22E98E0
	public bool IsPlaying() { }

	// RVA: 0x22E9900 Offset: 0x22E9A01 VA: 0x22E9900
	public void Stop(GameSound.FadeSpeedType fadeSpeedType = 0) { }

	// RVA: 0x22E99A0 Offset: 0x22E9AA1 VA: 0x22E99A0
	public void Stop(int fadeMsec) { }

	// RVA: 0x22E99C0 Offset: 0x22E9AC1 VA: 0x22E99C0
	public void Pause(GameSound.FadeSpeedType fadeSpeedType = 0) { }

	// RVA: 0x22E9A60 Offset: 0x22E9B61 VA: 0x22E9A60
	public void Pause(int fadeMsec) { }

	// RVA: 0x22E9A80 Offset: 0x22E9B81 VA: 0x22E9A80
	public void Resume(GameSound.FadeSpeedType fadeSpeedType = 0) { }

	// RVA: 0x22E9B20 Offset: 0x22E9C21 VA: 0x22E9B20
	public void Resume(int fadeMsec) { }
}

// Namespace: 
public class GameSound.ResultLoad // TypeDefIndex: 13380
{
	// Fields
	private SoundSystem.ResultSoundLoadList m_resultList; // 0x10

	// Methods

	// RVA: 0x22E9CE0 Offset: 0x22E9DE1 VA: 0x22E9CE0
	public void .ctor() { }

	// RVA: 0x22E9D60 Offset: 0x22E9E61 VA: 0x22E9D60
	public void Add(SoundSystem.ResultSoundLoad result) { }

	// RVA: 0x22E9D70 Offset: 0x22E9E71 VA: 0x22E9D70
	public bool IsLoading() { }

	// RVA: 0x22E9D80 Offset: 0x22E9E81 VA: 0x22E9D80
	public bool IsLoadSuccess() { }
}

// Namespace: 
public enum GameSound.WakeupVoicePattern // TypeDefIndex: 13381
{
	// Fields
	public int value__; // 0x0
	public const GameSound.WakeupVoicePattern Pattern1 = 0;
	public const GameSound.WakeupVoicePattern Pattern2 = 1;
	public const GameSound.WakeupVoicePattern Max = 2;
}

// Namespace: 
public enum GameSound.WakeupVoiceSituation // TypeDefIndex: 13382
{
	// Fields
	public int value__; // 0x0
	public const GameSound.WakeupVoiceSituation Enter = 0;
	public const GameSound.WakeupVoiceSituation GreetBefore = 1;
	public const GameSound.WakeupVoiceSituation Wakeup = 2;
	public const GameSound.WakeupVoiceSituation GreetAfter = 3;
	public const GameSound.WakeupVoiceSituation Max = 4;
}

// Namespace: 
public enum GameSound.RingCleaningVoicePattern // TypeDefIndex: 13383
{
	// Fields
	public int value__; // 0x0
	public const GameSound.RingCleaningVoicePattern Touch = 0;
	public const GameSound.RingCleaningVoicePattern Dirt = 1;
	public const GameSound.RingCleaningVoicePattern Thanks = 2;
	public const GameSound.RingCleaningVoicePattern Num = 3;
}

// Namespace: 
public class GameSound.LipSyncData // TypeDefIndex: 13384
{
	// Fields
	private SoundSystem.LipSyncData m_data; // 0x10

	// Properties
	public float Msec { get; }
	public float A { get; }
	public float I { get; }
	public float U { get; }
	public float E { get; }
	public float O { get; }
	public float Vol { get; }
	public float Width { get; }
	public float Height { get; }

	// Methods

	// RVA: 0x22E9B40 Offset: 0x22E9C41 VA: 0x22E9B40
	public void .ctor(SoundSystem.LipSyncData data) { }

	// RVA: 0x22E9B80 Offset: 0x22E9C81 VA: 0x22E9B80
	public float get_Msec() { }

	// RVA: 0x22E9BA0 Offset: 0x22E9CA1 VA: 0x22E9BA0
	public float get_A() { }

	// RVA: 0x22E9BB0 Offset: 0x22E9CB1 VA: 0x22E9BB0
	public float get_I() { }

	// RVA: 0x22E9BC0 Offset: 0x22E9CC1 VA: 0x22E9BC0
	public float get_U() { }

	// RVA: 0x22E9BD0 Offset: 0x22E9CD1 VA: 0x22E9BD0
	public float get_E() { }

	// RVA: 0x22E9BE0 Offset: 0x22E9CE1 VA: 0x22E9BE0
	public float get_O() { }

	// RVA: 0x22E9BF0 Offset: 0x22E9CF1 VA: 0x22E9BF0
	public float get_Vol() { }

	// RVA: 0x22E9C00 Offset: 0x22E9D01 VA: 0x22E9C00
	public float get_Width() { }

	// RVA: 0x22E9C10 Offset: 0x22E9D11 VA: 0x22E9C10
	public float get_Height() { }
}

// Namespace: 
private class GameSound.ProcDescPostEvent : ProcDescUser // TypeDefIndex: 13385
{
	// Fields
	private string m_eventName; // 0x18

	// Methods

	// RVA: 0x22E9C20 Offset: 0x22E9D21 VA: 0x22E9C20
	public void .ctor(string eventName) { }

	// RVA: 0x22E9C60 Offset: 0x22E9D61 VA: 0x22E9C60 Slot: 4
	public override ProcDesc.Result Execute(ProcInst inst) { }
}

