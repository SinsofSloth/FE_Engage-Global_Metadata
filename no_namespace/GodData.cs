// Namespace: 
public enum GodData.RelianceLevel // TypeDefIndex: 9904
{
	// Fields
	public int value__; // 0x0
	public const GodData.RelianceLevel D = 0;
	public const GodData.RelianceLevel C = 1;
	public const GodData.RelianceLevel B = 2;
	public const GodData.RelianceLevel A = 3;
	public const GodData.RelianceLevel S = 4;
}

// Namespace: 
public sealed class GodData.FlagField : BitFieldTemplate32<GodData.Flags> // TypeDefIndex: 9906
{
	// Methods

	// RVA: 0x1FA00F0 Offset: 0x1FA01F1 VA: 0x1FA00F0
	public void .ctor(int f) { }

	// RVA: 0x1FA0150 Offset: 0x1FA0251 VA: 0x1FA0150
	public void .ctor(GodData.Flags f) { }

	// RVA: 0x1FA01B0 Offset: 0x1FA02B1 VA: 0x1FA01B0 Slot: 5
	protected override int ToInt(GodData.Flags value) { }
}

