// Namespace: 
public enum MapSituation.Player // TypeDefIndex: 12216
{
	// Fields
	public int value__; // 0x0
	public const MapSituation.Player None = 0;
	public const MapSituation.Player Human = 1;
	public const MapSituation.Player Ai = 2;
	public const MapSituation.Player Link = 3;
	public const MapSituation.Player Replay = 4;
	public const MapSituation.Player Num = 5;
}

// Namespace: 
[FlagsAttribute] // RVA: 0x278030 Offset: 0x278131 VA: 0x278030
public enum MapSituation.Status // TypeDefIndex: 12218
{
	// Fields
	public int value__; // 0x0
	public const MapSituation.Status WinRuleBreakdown = 1;
	public const MapSituation.Status WinRuleDestroyBoss = 2;
	public const MapSituation.Status SequenceReplayCancel = 134217728;
	public const MapSituation.Status SequenceOpening = 268435456;
	public const MapSituation.Status SequenceAiEntrustCancel = 536870912;
	public const MapSituation.Status SequenceAi = 1073741824;
	public const MapSituation.Status SequenceMind = -2147483648;
	public const MapSituation.Status WinRuleMask = 3;
}

// Namespace: 
public class MapSituation.ForceCursor // TypeDefIndex: 12220
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x299CF0 Offset: 0x299DF1 VA: 0x299CF0
	private int <X>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x299D00 Offset: 0x299E01 VA: 0x299D00
	private int <Z>k__BackingField; // 0x14

	// Properties
	public int X { get; set; }
	public int Z { get; set; }

	// Methods

	// RVA: 0x2139A70 Offset: 0x2139B71 VA: 0x2139A70
	public void Set(int x, int z) { }

	// RVA: 0x2139A80 Offset: 0x2139B81 VA: 0x2139A80
	public void Clear() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C80E0 Offset: 0x2C81E1 VA: 0x2C80E0
	// RVA: 0x2139A90 Offset: 0x2139B91 VA: 0x2139A90
	public int get_X() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C80F0 Offset: 0x2C81F1 VA: 0x2C80F0
	// RVA: 0x2139AA0 Offset: 0x2139BA1 VA: 0x2139AA0
	public void set_X(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C8100 Offset: 0x2C8201 VA: 0x2C8100
	// RVA: 0x2139AB0 Offset: 0x2139BB1 VA: 0x2139AB0
	public int get_Z() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C8110 Offset: 0x2C8211 VA: 0x2C8110
	// RVA: 0x2139AC0 Offset: 0x2139BC1 VA: 0x2139AC0
	public void set_Z(int value) { }

	// RVA: 0x2139AD0 Offset: 0x2139BD1 VA: 0x2139AD0
	public void .ctor() { }
}

