// Namespace: 
[FlagsAttribute] // RVA: 0x276000 Offset: 0x276101 VA: 0x276000
public enum ChartGodData.Flags // TypeDefIndex: 9840
{
	// Fields
	public int value__; // 0x0
	public const ChartGodData.Flags AddGodLueur = 1;
}

// Namespace: 
public sealed class ChartGodData.FlagField : BitFieldTemplate32<ChartGodData.Flags> // TypeDefIndex: 9841
{
	// Methods

	// RVA: 0x1E05160 Offset: 0x1E05261 VA: 0x1E05160
	public void .ctor(int f) { }

	// RVA: 0x1E051C0 Offset: 0x1E052C1 VA: 0x1E051C0
	public void .ctor(ChartGodData.Flags f) { }

	// RVA: 0x1E05220 Offset: 0x1E05321 VA: 0x1E05220 Slot: 5
	protected override int ToInt(ChartGodData.Flags value) { }
}

