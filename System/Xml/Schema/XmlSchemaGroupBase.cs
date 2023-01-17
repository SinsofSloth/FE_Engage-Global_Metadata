// Namespace: System.Xml.Schema
public abstract class XmlSchemaGroupBase : XmlSchemaParticle // TypeDefIndex: 2006
{
	// Properties
	[XmlIgnoreAttribute] // RVA: 0x4A4E0 Offset: 0x4A5E1 VA: 0x4A4E0
	public abstract XmlSchemaObjectCollection Items { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 16
	public abstract XmlSchemaObjectCollection get_Items();

	// RVA: -1 Offset: -1 Slot: 17
	internal abstract void SetItems(XmlSchemaObjectCollection newItems);

	// RVA: 0x195DF40 Offset: 0x195E041 VA: 0x195DF40
	protected void .ctor() { }
}

