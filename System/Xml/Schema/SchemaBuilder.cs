// Namespace: System.Xml.Schema
internal abstract class SchemaBuilder // TypeDefIndex: 1925
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract bool ProcessElement(string prefix, string name, string ns);

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract void ProcessAttribute(string prefix, string name, string ns, string value);

	// RVA: -1 Offset: -1 Slot: 6
	internal abstract bool IsContentParsed();

	// RVA: -1 Offset: -1 Slot: 7
	internal abstract void ProcessMarkup(XmlNode[] markup);

	// RVA: -1 Offset: -1 Slot: 8
	internal abstract void ProcessCData(string value);

	// RVA: -1 Offset: -1 Slot: 9
	internal abstract void StartChildren();

	// RVA: -1 Offset: -1 Slot: 10
	internal abstract void EndChildren();

	// RVA: 0x1A599F0 Offset: 0x1A59AF1 VA: 0x1A599F0
	protected void .ctor() { }
}

