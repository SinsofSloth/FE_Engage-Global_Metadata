// Namespace: System.Xml
public class NameTable : XmlNameTable // TypeDefIndex: 1727
{
	// Fields
	private NameTable.Entry[] entries; // 0x10
	private int count; // 0x18
	private int mask; // 0x1C
	private int hashCodeRandomizer; // 0x20

	// Methods

	// RVA: 0x3240040 Offset: 0x3240141 VA: 0x3240040
	public void .ctor() { }

	// RVA: 0x32400D0 Offset: 0x32401D1 VA: 0x32400D0 Slot: 6
	public override string Add(string key) { }

	// RVA: 0x3240370 Offset: 0x3240471 VA: 0x3240370 Slot: 5
	public override string Add(char[] key, int start, int len) { }

	// RVA: 0x3240650 Offset: 0x3240751 VA: 0x3240650 Slot: 4
	public override string Get(string value) { }

	// RVA: 0x3240260 Offset: 0x3240361 VA: 0x3240260
	private string AddEntry(string str, int hashCode) { }

	// RVA: 0x32407D0 Offset: 0x32408D1 VA: 0x32407D0
	private void Grow() { }

	// RVA: 0x32405A0 Offset: 0x32406A1 VA: 0x32405A0
	private static bool TextEquals(string str1, char[] str2, int str2Start, int str2Length) { }
}

