// Namespace: 
private class SmallXmlParser.AttrListImpl : SmallXmlParser.IAttrList // TypeDefIndex: 25
{
	// Fields
	private List<string> attrNames; // 0x10
	private List<string> attrValues; // 0x18

	// Properties
	public int Length { get; }
	public string[] Names { get; }
	public string[] Values { get; }

	// Methods

	// RVA: 0x1C021D0 Offset: 0x1C022D1 VA: 0x1C021D0 Slot: 4
	public int get_Length() { }

	// RVA: 0x1C02220 Offset: 0x1C02321 VA: 0x1C02220 Slot: 5
	public string GetName(int i) { }

	// RVA: 0x1C02290 Offset: 0x1C02391 VA: 0x1C02290 Slot: 6
	public string GetValue(int i) { }

	// RVA: 0x1C02300 Offset: 0x1C02401 VA: 0x1C02300 Slot: 7
	public string GetValue(string name) { }

	// RVA: 0x1C023E0 Offset: 0x1C024E1 VA: 0x1C023E0 Slot: 8
	public string[] get_Names() { }

	// RVA: 0x1C02440 Offset: 0x1C02541 VA: 0x1C02440 Slot: 9
	public string[] get_Values() { }

	// RVA: 0x1C024A0 Offset: 0x1C025A1 VA: 0x1C024A0
	internal void Clear() { }

	// RVA: 0x1C02500 Offset: 0x1C02601 VA: 0x1C02500
	internal void Add(string name, string value) { }

	// RVA: 0x1C02580 Offset: 0x1C02681 VA: 0x1C02580
	public void .ctor() { }
}

