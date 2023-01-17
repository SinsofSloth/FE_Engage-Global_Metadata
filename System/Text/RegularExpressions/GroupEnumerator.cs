// Namespace: System.Text.RegularExpressions
internal class GroupEnumerator : IEnumerator // TypeDefIndex: 2262
{
	// Fields
	internal GroupCollection _rgc; // 0x10
	internal int _curindex; // 0x18

	// Properties
	public object Current { get; }
	public Capture Capture { get; }

	// Methods

	// RVA: 0x1AE8B60 Offset: 0x1AE8C61 VA: 0x1AE8B60
	internal void .ctor(GroupCollection rgc) { }

	// RVA: 0x1AE8BE0 Offset: 0x1AE8CE1 VA: 0x1AE8BE0 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x1AE8C20 Offset: 0x1AE8D21 VA: 0x1AE8C20 Slot: 5
	public object get_Current() { }

	// RVA: 0x1AE8C30 Offset: 0x1AE8D31 VA: 0x1AE8C30
	public Capture get_Capture() { }

	// RVA: 0x1AE8CC0 Offset: 0x1AE8DC1 VA: 0x1AE8CC0 Slot: 6
	public void Reset() { }
}

