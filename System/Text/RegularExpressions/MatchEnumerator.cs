// Namespace: System.Text.RegularExpressions
[Serializable]
internal class MatchEnumerator : IEnumerator // TypeDefIndex: 2267
{
	// Fields
	internal MatchCollection _matchcoll; // 0x10
	internal Match _match; // 0x18
	internal int _curindex; // 0x20
	internal bool _done; // 0x24

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x1AC5D20 Offset: 0x1AC5E21 VA: 0x1AC5D20
	internal void .ctor(MatchCollection matchcoll) { }

	// RVA: 0x1AC5DF0 Offset: 0x1AC5EF1 VA: 0x1AC5DF0 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x1AC5E60 Offset: 0x1AC5F61 VA: 0x1AC5E60 Slot: 5
	public object get_Current() { }

	// RVA: 0x1AC5ED0 Offset: 0x1AC5FD1 VA: 0x1AC5ED0 Slot: 6
	public void Reset() { }
}

