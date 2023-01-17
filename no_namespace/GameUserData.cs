// Namespace: 
[FlagsAttribute] // RVA: 0x2790C0 Offset: 0x2791C1 VA: 0x2790C0
public enum GameUserData.Statuses // TypeDefIndex: 13608
{
	// Fields
	public int value__; // 0x0
	public const GameUserData.Statuses ContentsMounted = 1;
	public const GameUserData.Statuses FinishedSetupMap = 2;
	public const GameUserData.Statuses __Casual = 8;
	public const GameUserData.Statuses __Phoenix = 16;
	public const GameUserData.Statuses EncountMap = 32;
	public const GameUserData.Statuses ContinuedMap = 64;
	public const GameUserData.Statuses FixedGrow = 128;
	public const GameUserData.Statuses Completed = 256;
	public const GameUserData.Statuses TemporarySaved = 512;
	public const GameUserData.Statuses TemporaryLoaded = 1024;
	public const GameUserData.Statuses NetLoginOnce = 2048;
	public const GameUserData.Statuses RestartMap = 4096;
	public const GameUserData.Statuses RecollectionMap = 8192;
	public const GameUserData.Statuses IgnoreKizuna = 16384;
	public const GameUserData.Statuses EvilCompleted = 32768;
	public const GameUserData.Statuses INIT_BEGIN_OF_MAP = 16384;
	public const GameUserData.Statuses INIT_END_OF_MAP = 13826;
	public const GameUserData.Statuses INIT_END_OF_CONTENTS = 1537;
}

// Namespace: 
public class GameUserData.StatusField : BitFieldTemplate32<GameUserData.Statuses> // TypeDefIndex: 13609
{
	// Methods

	// RVA: 0x22E9E50 Offset: 0x22E9F51 VA: 0x22E9E50 Slot: 5
	protected override int ToInt(GameUserData.Statuses value) { }

	// RVA: 0x22E9E60 Offset: 0x22E9F61 VA: 0x22E9E60
	public void .ctor() { }
}

// Namespace: 
public enum GameUserData.Sequences // TypeDefIndex: 13610
{
	// Fields
	public int value__; // 0x0
	public const GameUserData.Sequences None = 0;
	public const GameUserData.Sequences ChapterSave = 1;
	public const GameUserData.Sequences Sortie = 2;
	public const GameUserData.Sequences Map = 3;
	public const GameUserData.Sequences Hub = 4;
	public const GameUserData.Sequences Kizuna = 5;
	public const GameUserData.Sequences Gmap = 6;
	public const GameUserData.Sequences Chapter = 7;
	public const GameUserData.Sequences Num = 8;
}

// Namespace: 
public enum GameUserData.MapModes // TypeDefIndex: 13611
{
	// Fields
	public int value__; // 0x0
	public const GameUserData.MapModes Story = 0;
	public const GameUserData.MapModes Encount = 1;
	public const GameUserData.MapModes Challenge = 2;
	public const GameUserData.MapModes Relay = 3;
	public const GameUserData.MapModes Versus = 4;
	public const GameUserData.MapModes Recollection = 5;
}

// Namespace: 
private class GameUserData.ProcDescSetSequence : ProcDescUser // TypeDefIndex: 13612
{
	// Fields
	private GameUserData.Sequences m_Sequence; // 0x14

	// Methods

	// RVA: 0x22E9D90 Offset: 0x22E9E91 VA: 0x22E9D90
	public void .ctor(GameUserData.Sequences sequence) { }

	// RVA: 0x22E9DC0 Offset: 0x22E9EC1 VA: 0x22E9DC0 Slot: 4
	public override ProcDesc.Result Execute(ProcInst inst) { }
}

