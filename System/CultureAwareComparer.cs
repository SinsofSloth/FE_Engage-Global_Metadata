// Namespace: System
[Serializable]
internal sealed class CultureAwareComparer : StringComparer // TypeDefIndex: 307
{
	// Fields
	private CompareInfo _compareInfo; // 0x10
	private bool _ignoreCase; // 0x18
	[OptionalFieldAttribute] // RVA: 0x4780A0 Offset: 0x4781A1 VA: 0x4780A0
	private CompareOptions _options; // 0x1C

	// Methods

	// RVA: 0x37DC450 Offset: 0x37DC551 VA: 0x37DC450
	internal void .ctor(CultureInfo culture, bool ignoreCase) { }

	// RVA: 0x37DC500 Offset: 0x37DC601 VA: 0x37DC500 Slot: 10
	public override int Compare(string x, string y) { }

	// RVA: 0x37DC540 Offset: 0x37DC641 VA: 0x37DC540 Slot: 11
	public override bool Equals(string x, string y) { }

	// RVA: 0x37DC590 Offset: 0x37DC691 VA: 0x37DC590 Slot: 12
	public override int GetHashCode(string obj) { }

	// RVA: 0x37DC610 Offset: 0x37DC711 VA: 0x37DC610 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x37DC6E0 Offset: 0x37DC7E1 VA: 0x37DC6E0 Slot: 2
	public override int GetHashCode() { }
}

