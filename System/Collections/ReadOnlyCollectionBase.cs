// Namespace: System.Collections
[ComVisibleAttribute] // RVA: 0x477000 Offset: 0x477101 VA: 0x477000
[Serializable]
public abstract class ReadOnlyCollectionBase : ICollection, IEnumerable // TypeDefIndex: 1375
{
	// Fields
	private ArrayList list; // 0x10

	// Properties
	protected ArrayList InnerList { get; }
	public virtual int Count { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: 0x3B71830 Offset: 0x3B71931 VA: 0x3B71830
	protected ArrayList get_InnerList() { }

	// RVA: 0x3B718C0 Offset: 0x3B719C1 VA: 0x3B718C0 Slot: 9
	public virtual int get_Count() { }

	// RVA: 0x3B71940 Offset: 0x3B71A41 VA: 0x3B71940 Slot: 7
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x3B719C0 Offset: 0x3B71AC1 VA: 0x3B719C0 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x3B71A40 Offset: 0x3B71B41 VA: 0x3B71A40 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x3B71AE0 Offset: 0x3B71BE1 VA: 0x3B71AE0 Slot: 10
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x3B71B60 Offset: 0x3B71C61 VA: 0x3B71B60
	protected void .ctor() { }
}

