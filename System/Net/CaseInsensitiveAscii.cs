// Namespace: System.Net
internal class CaseInsensitiveAscii : IEqualityComparer, IComparer // TypeDefIndex: 2481
{
	// Fields
	internal static readonly CaseInsensitiveAscii StaticInstance; // 0x0
	internal static readonly byte[] AsciiToLower; // 0x8

	// Methods

	// RVA: 0x1B48450 Offset: 0x1B48551 VA: 0x1B48450 Slot: 5
	public int GetHashCode(object myObject) { }

	// RVA: 0x1B48580 Offset: 0x1B48681 VA: 0x1B48580 Slot: 6
	public int Compare(object firstObject, object secondObject) { }

	// RVA: 0x1B48700 Offset: 0x1B48801 VA: 0x1B48700
	private int FastGetHashCode(string myString) { }

	// RVA: 0x1B48800 Offset: 0x1B48901 VA: 0x1B48800 Slot: 4
	public bool Equals(object firstObject, object secondObject) { }

	// RVA: 0x1B48980 Offset: 0x1B48A81 VA: 0x1B48980
	public void .ctor() { }

	// RVA: 0x1B48990 Offset: 0x1B48A91 VA: 0x1B48990
	private static void .cctor() { }
}

