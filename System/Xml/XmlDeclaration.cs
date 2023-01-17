// Namespace: System.Xml
public class XmlDeclaration : XmlLinkedNode // TypeDefIndex: 1693
{
	// Fields
	private string version; // 0x20
	private string encoding; // 0x28
	private string standalone; // 0x30

	// Properties
	public string Version { get; set; }
	public string Encoding { get; set; }
	public string Standalone { get; set; }
	public override string Value { get; set; }
	public override string InnerText { get; set; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }

	// Methods

	// RVA: 0x1AA7FF0 Offset: 0x1AA80F1 VA: 0x1AA7FF0
	protected internal void .ctor(string version, string encoding, string standalone, XmlDocument doc) { }

	// RVA: 0x1AA84D0 Offset: 0x1AA85D1 VA: 0x1AA84D0
	public string get_Version() { }

	// RVA: 0x1AA84E0 Offset: 0x1AA85E1 VA: 0x1AA84E0
	internal void set_Version(string value) { }

	// RVA: 0x1AA84F0 Offset: 0x1AA85F1 VA: 0x1AA84F0
	public string get_Encoding() { }

	// RVA: 0x1AA8300 Offset: 0x1AA8401 VA: 0x1AA8300
	public void set_Encoding(string value) { }

	// RVA: 0x1AA8500 Offset: 0x1AA8601 VA: 0x1AA8500
	public string get_Standalone() { }

	// RVA: 0x1AA8370 Offset: 0x1AA8471 VA: 0x1AA8370
	public void set_Standalone(string value) { }

	// RVA: 0x1AA8510 Offset: 0x1AA8611 VA: 0x1AA8510 Slot: 7
	public override string get_Value() { }

	// RVA: 0x1AA8520 Offset: 0x1AA8621 VA: 0x1AA8520 Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0x1AA8530 Offset: 0x1AA8631 VA: 0x1AA8530 Slot: 33
	public override string get_InnerText() { }

	// RVA: 0x1AA8690 Offset: 0x1AA8791 VA: 0x1AA8690 Slot: 34
	public override void set_InnerText(string value) { }

	// RVA: 0x1AA8910 Offset: 0x1AA8A11 VA: 0x1AA8910 Slot: 6
	public override string get_Name() { }

	// RVA: 0x1AA8960 Offset: 0x1AA8A61 VA: 0x1AA8960 Slot: 31
	public override string get_LocalName() { }

	// RVA: 0x1AA8970 Offset: 0x1AA8A71 VA: 0x1AA8970 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1AA8980 Offset: 0x1AA8A81 VA: 0x1AA8980 Slot: 27
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x1AA8230 Offset: 0x1AA8331 VA: 0x1AA8230
	private bool IsValidXmlVersion(string ver) { }
}

