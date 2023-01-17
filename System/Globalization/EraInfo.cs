// Namespace: System.Globalization
[Serializable]
internal class EraInfo // TypeDefIndex: 696
{
	// Fields
	internal int era; // 0x10
	internal long ticks; // 0x18
	internal int yearOffset; // 0x20
	internal int minEraYear; // 0x24
	internal int maxEraYear; // 0x28
	[OptionalFieldAttribute] // RVA: 0x478B00 Offset: 0x478C01 VA: 0x478B00
	internal string eraName; // 0x30
	[OptionalFieldAttribute] // RVA: 0x478B40 Offset: 0x478C41 VA: 0x478B40
	internal string abbrevEraName; // 0x38
	[OptionalFieldAttribute] // RVA: 0x478B80 Offset: 0x478C81 VA: 0x478B80
	internal string englishEraName; // 0x40

	// Methods

	// RVA: 0x3B5FB00 Offset: 0x3B5FC01 VA: 0x3B5FB00
	internal void .ctor(int era, int startYear, int startMonth, int startDay, int yearOffset, int minEraYear, int maxEraYear) { }

	// RVA: 0x3B5FBA0 Offset: 0x3B5FCA1 VA: 0x3B5FBA0
	internal void .ctor(int era, int startYear, int startMonth, int startDay, int yearOffset, int minEraYear, int maxEraYear, string eraName, string abbrevEraName, string englishEraName) { }
}

