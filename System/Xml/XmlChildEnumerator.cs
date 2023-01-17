// Namespace: System.Xml
internal sealed class XmlChildEnumerator : IEnumerator // TypeDefIndex: 1690
{
	// Fields
	internal XmlNode container; // 0x10
	internal XmlNode child; // 0x18
	internal bool isFirst; // 0x20

	// Properties
	private object System.Collections.IEnumerator.Current { get; }
	internal XmlNode Current { get; }

	// Methods

	// RVA: 0x1AA0DD0 Offset: 0x1AA0ED1 VA: 0x1AA0DD0
	internal void .ctor(XmlNode container) { }

	// RVA: 0x1AA0E40 Offset: 0x1AA0F41 VA: 0x1AA0E40 Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x1AA0ED0 Offset: 0x1AA0FD1 VA: 0x1AA0ED0
	internal bool MoveNext() { }

	// RVA: 0x1AA0F60 Offset: 0x1AA1061 VA: 0x1AA0F60 Slot: 6
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1AA0FB0 Offset: 0x1AA10B1 VA: 0x1AA0FB0 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1AA0FC0 Offset: 0x1AA10C1 VA: 0x1AA0FC0
	internal XmlNode get_Current() { }
}

