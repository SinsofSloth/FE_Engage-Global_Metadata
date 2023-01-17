// Namespace: 
public enum RelayStampData.Kinds // TypeDefIndex: 10038
{
	// Fields
	public int value__; // 0x0
	public const RelayStampData.Kinds Lithos = 0;
	public const RelayStampData.Kinds Filene = 1;
	public const RelayStampData.Kinds Brodia = 2;
	public const RelayStampData.Kinds Ircion = 3;
	public const RelayStampData.Kinds Solum = 4;
	public const RelayStampData.Kinds Other = 5;
	public const RelayStampData.Kinds God = 6;
	public const RelayStampData.Kinds Count = 7;
	public const RelayStampData.Kinds CountryCount = 6;
}

// Namespace: 
[FlagsAttribute] // RVA: 0x276480 Offset: 0x276581 VA: 0x276480
public enum RelayStampData.Flags // TypeDefIndex: 10039
{
	// Fields
	public int value__; // 0x0
	public const RelayStampData.Flags NoFilter = 1;
}

// Namespace: 
public sealed class RelayStampData.FlagField : BitFieldTemplate32<RelayStampData.Flags> // TypeDefIndex: 10040
{
	// Methods

	// RVA: 0x1F44FE0 Offset: 0x1F450E1 VA: 0x1F44FE0
	public void .ctor(int f) { }

	// RVA: 0x1F45040 Offset: 0x1F45141 VA: 0x1F45040
	public void .ctor(RelayStampData.Flags f) { }

	// RVA: 0x1F450A0 Offset: 0x1F451A1 VA: 0x1F450A0 Slot: 5
	protected override int ToInt(RelayStampData.Flags value) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x276490 Offset: 0x276591 VA: 0x276490
private sealed class RelayStampData.<>c__DisplayClass38_0 // TypeDefIndex: 10041
{
	// Fields
	public byte serialNo; // 0x10

	// Methods

	// RVA: 0x1F44FB0 Offset: 0x1F450B1 VA: 0x1F44FB0
	public void .ctor() { }

	// RVA: 0x1F44FC0 Offset: 0x1F450C1 VA: 0x1F44FC0
	internal bool <TryGetFromSerialNo>b__0(RelayStampData data) { }
}

