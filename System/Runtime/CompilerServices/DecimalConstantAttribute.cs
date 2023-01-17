// Namespace: System.Runtime.CompilerServices
[AttributeUsageAttribute] // RVA: 0x4758C0 Offset: 0x4759C1 VA: 0x4758C0
[ComVisibleAttribute] // RVA: 0x4758C0 Offset: 0x4759C1 VA: 0x4758C0
[Serializable]
public sealed class DecimalConstantAttribute : Attribute // TypeDefIndex: 1269
{
	// Fields
	private Decimal dec; // 0x10

	// Properties
	public Decimal Value { get; }

	// Methods

	[CLSCompliantAttribute] // RVA: 0x47D360 Offset: 0x47D461 VA: 0x47D360
	// RVA: 0x371D0A0 Offset: 0x371D1A1 VA: 0x371D0A0
	public void .ctor(byte scale, byte sign, uint hi, uint mid, uint low) { }

	// RVA: 0x371D120 Offset: 0x371D221 VA: 0x371D120
	public Decimal get_Value() { }
}

