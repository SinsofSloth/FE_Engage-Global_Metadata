// Namespace: System.Collections
[ComVisibleAttribute] // RVA: 0x476B00 Offset: 0x476C01 VA: 0x476B00
[Serializable]
public class CaseInsensitiveComparer : IComparer // TypeDefIndex: 1341
{
	// Fields
	private CompareInfo m_compareInfo; // 0x10

	// Properties
	public static CaseInsensitiveComparer Default { get; }

	// Methods

	// RVA: 0x3519010 Offset: 0x3519111 VA: 0x3519010
	public void .ctor() { }

	// RVA: 0x35190A0 Offset: 0x35191A1 VA: 0x35190A0
	public void .ctor(CultureInfo culture) { }

	// RVA: 0x3519130 Offset: 0x3519231 VA: 0x3519130
	public static CaseInsensitiveComparer get_Default() { }

	// RVA: 0x35191C0 Offset: 0x35192C1 VA: 0x35191C0 Slot: 4
	public int Compare(object a, object b) { }
}

