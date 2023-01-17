// Namespace: System.Text.RegularExpressions
[DefaultMemberAttribute] // RVA: 0x2FC80 Offset: 0x2FD81 VA: 0x2FC80
[Serializable]
public class GroupCollection : ICollection, IEnumerable // TypeDefIndex: 2261
{
	// Fields
	internal Match _match; // 0x10
	internal Hashtable _captureMap; // 0x18
	internal Group[] _groups; // 0x20

	// Properties
	public object SyncRoot { get; }
	public bool IsSynchronized { get; }
	public int Count { get; }
	public Group Item { get; }
	public Group Item { get; }

	// Methods

	// RVA: 0x1AE85A0 Offset: 0x1AE86A1 VA: 0x1AE85A0
	internal void .ctor(Match match, Hashtable caps) { }

	// RVA: 0x1AE85F0 Offset: 0x1AE86F1 VA: 0x1AE85F0 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x1AE8600 Offset: 0x1AE8701 VA: 0x1AE8600 Slot: 7
	public bool get_IsSynchronized() { }

	// RVA: 0x1AE8610 Offset: 0x1AE8711 VA: 0x1AE8610 Slot: 5
	public int get_Count() { }

	// RVA: 0x1AE8620 Offset: 0x1AE8721 VA: 0x1AE8620
	public Group get_Item(int groupnum) { }

	// RVA: 0x1AE8760 Offset: 0x1AE8861 VA: 0x1AE8760
	public Group get_Item(string groupname) { }

	// RVA: 0x1AE8630 Offset: 0x1AE8731 VA: 0x1AE8630
	internal Group GetGroup(int groupnum) { }

	// RVA: 0x1AE8810 Offset: 0x1AE8911 VA: 0x1AE8810
	internal Group GetGroupImpl(int groupnum) { }

	// RVA: 0x1AE8A00 Offset: 0x1AE8B01 VA: 0x1AE8A00 Slot: 4
	public void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x1AE8AE0 Offset: 0x1AE8BE1 VA: 0x1AE8AE0 Slot: 8
	public IEnumerator GetEnumerator() { }

	// RVA: 0x1AE8BA0 Offset: 0x1AE8CA1 VA: 0x1AE8BA0
	internal void .ctor() { }
}

