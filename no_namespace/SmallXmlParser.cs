// Namespace: 
public interface SmallXmlParser.IContentHandler // TypeDefIndex: 23
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnStartParsing(SmallXmlParser parser);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnEndParsing(SmallXmlParser parser);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnStartElement(string name, SmallXmlParser.IAttrList attrs);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnEndElement(string name);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnProcessingInstruction(string name, string text);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void OnChars(string text);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void OnIgnorableWhitespace(string text);
}

// Namespace: 
public interface SmallXmlParser.IAttrList // TypeDefIndex: 24
{
	// Properties
	public abstract int Length { get; }
	public abstract string[] Names { get; }
	public abstract string[] Values { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_Length();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string GetName(int i);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string GetValue(int i);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract string GetValue(string name);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string[] get_Names();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string[] get_Values();
}

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

