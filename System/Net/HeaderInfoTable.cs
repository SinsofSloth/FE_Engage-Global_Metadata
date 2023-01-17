// Namespace: System.Net
[DefaultMemberAttribute] // RVA: 0x30F00 Offset: 0x31001 VA: 0x30F00
internal class HeaderInfoTable // TypeDefIndex: 2491
{
	// Fields
	private static Hashtable HeaderHashTable; // 0x0
	private static HeaderInfo UnknownHeaderInfo; // 0x8
	private static HeaderParser SingleParser; // 0x10
	private static HeaderParser MultiParser; // 0x18

	// Properties
	internal HeaderInfo Item { get; }

	// Methods

	// RVA: 0x1AE8D50 Offset: 0x1AE8E51 VA: 0x1AE8D50
	private static string[] ParseSingleValue(string value) { }

	// RVA: 0x1AE8E00 Offset: 0x1AE8F01 VA: 0x1AE8E00
	private static string[] ParseMultiValue(string value) { }

	// RVA: 0x1AE9000 Offset: 0x1AE9101 VA: 0x1AE9000
	private static void .cctor() { }

	// RVA: 0x1AEB180 Offset: 0x1AEB281 VA: 0x1AEB180
	internal HeaderInfo get_Item(string name) { }

	// RVA: 0x1AEB280 Offset: 0x1AEB381 VA: 0x1AEB280
	public void .ctor() { }
}

