// Namespace: System.Resources
internal sealed class FastResourceComparer : IComparer, IEqualityComparer, IComparer<string>, IEqualityComparer<string> // TypeDefIndex: 483
{
	// Fields
	internal static readonly FastResourceComparer Default; // 0x0

	// Methods

	// RVA: 0x3B65A50 Offset: 0x3B65B51 VA: 0x3B65A50 Slot: 6
	public int GetHashCode(object key) { }

	// RVA: 0x3B65BB0 Offset: 0x3B65CB1 VA: 0x3B65BB0 Slot: 9
	public int GetHashCode(string key) { }

	// RVA: 0x3B65B40 Offset: 0x3B65C41 VA: 0x3B65B40
	internal static int HashFunction(string key) { }

	// RVA: 0x3B65C70 Offset: 0x3B65D71 VA: 0x3B65C70 Slot: 4
	public int Compare(object a, object b) { }

	// RVA: 0x3B65D20 Offset: 0x3B65E21 VA: 0x3B65D20 Slot: 7
	public int Compare(string a, string b) { }

	// RVA: 0x3B65D30 Offset: 0x3B65E31 VA: 0x3B65D30 Slot: 8
	public bool Equals(string a, string b) { }

	// RVA: 0x3B65D40 Offset: 0x3B65E41 VA: 0x3B65D40 Slot: 5
	public bool Equals(object a, object b) { }

	// RVA: 0x3B65DF0 Offset: 0x3B65EF1 VA: 0x3B65DF0
	public static int CompareOrdinal(string a, byte[] bytes, int bCharLength) { }

	// RVA: 0x3B65EB0 Offset: 0x3B65FB1 VA: 0x3B65EB0
	public static int CompareOrdinal(byte[] bytes, int aCharLength, string b) { }

	// RVA: 0x3B65FB0 Offset: 0x3B660B1 VA: 0x3B65FB0
	internal static int CompareOrdinal(byte* a, int byteLen, string b) { }

	// RVA: 0x3B66040 Offset: 0x3B66141 VA: 0x3B66040
	public void .ctor() { }

	// RVA: 0x3B66050 Offset: 0x3B66151 VA: 0x3B66050
	private static void .cctor() { }
}

