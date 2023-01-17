// Namespace: Mono.Xml
internal class SecurityParser : SmallXmlParser, SmallXmlParser.IContentHandler // TypeDefIndex: 22
{
	// Fields
	private SecurityElement root; // 0x68
	private SecurityElement current; // 0x70
	private Stack stack; // 0x78

	// Methods

	// RVA: 0x36144A0 Offset: 0x36145A1 VA: 0x36144A0
	public void .ctor() { }

	// RVA: 0x3614520 Offset: 0x3614621 VA: 0x3614520
	public void LoadXml(string xml) { }

	// RVA: 0x36158B0 Offset: 0x36159B1 VA: 0x36158B0
	public SecurityElement ToXml() { }

	// RVA: 0x36158C0 Offset: 0x36159C1 VA: 0x36158C0 Slot: 4
	public void OnStartParsing(SmallXmlParser parser) { }

	// RVA: 0x36158D0 Offset: 0x36159D1 VA: 0x36158D0 Slot: 8
	public void OnProcessingInstruction(string name, string text) { }

	// RVA: 0x36158E0 Offset: 0x36159E1 VA: 0x36158E0 Slot: 10
	public void OnIgnorableWhitespace(string s) { }

	// RVA: 0x36158F0 Offset: 0x36159F1 VA: 0x36158F0 Slot: 6
	public void OnStartElement(string name, SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x3615B90 Offset: 0x3615C91 VA: 0x3615B90 Slot: 7
	public void OnEndElement(string name) { }

	// RVA: 0x3615C20 Offset: 0x3615D21 VA: 0x3615C20 Slot: 9
	public void OnChars(string ch) { }

	// RVA: 0x3615CA0 Offset: 0x3615DA1 VA: 0x3615CA0 Slot: 5
	public void OnEndParsing(SmallXmlParser parser) { }
}

