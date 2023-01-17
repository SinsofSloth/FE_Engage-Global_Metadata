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

