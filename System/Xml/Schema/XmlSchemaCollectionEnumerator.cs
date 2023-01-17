// Namespace: System.Xml.Schema
public sealed class XmlSchemaCollectionEnumerator : IEnumerator // TypeDefIndex: 1973
{
	// Fields
	private IDictionaryEnumerator enumerator; // 0x10

	// Properties
	private object System.Collections.IEnumerator.Current { get; }
	public XmlSchema Current { get; }
	internal XmlSchemaCollectionNode CurrentNode { get; }

	// Methods

	// RVA: 0x195FF40 Offset: 0x1960041 VA: 0x195FF40
	internal void .ctor(Hashtable collection) { }

	// RVA: 0x1960860 Offset: 0x1960961 VA: 0x1960860 Slot: 6
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1960910 Offset: 0x1960A11 VA: 0x1960910 Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x1960330 Offset: 0x1960431 VA: 0x1960330
	public bool MoveNext() { }

	// RVA: 0x19609C0 Offset: 0x1960AC1 VA: 0x19609C0 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1960230 Offset: 0x1960331 VA: 0x1960230
	public XmlSchema get_Current() { }

	// RVA: 0x19609D0 Offset: 0x1960AD1 VA: 0x19609D0
	internal XmlSchemaCollectionNode get_CurrentNode() { }
}

