// Namespace: System.Security.Cryptography
[DefaultMemberAttribute] // RVA: 0x30540 Offset: 0x30641 VA: 0x30540
public sealed class OidCollection : ICollection, IEnumerable // TypeDefIndex: 2342
{
	// Fields
	private ArrayList m_list; // 0x10

	// Properties
	public Oid Item { get; }
	public int Count { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }

	// Methods

	// RVA: 0x1AD2220 Offset: 0x1AD2321 VA: 0x1AD2220
	public void .ctor() { }

	// RVA: 0x1AD22A0 Offset: 0x1AD23A1 VA: 0x1AD22A0
	public int Add(Oid oid) { }

	// RVA: 0x1AD22C0 Offset: 0x1AD23C1 VA: 0x1AD22C0
	public Oid get_Item(int index) { }

	// RVA: 0x1AD2340 Offset: 0x1AD2441 VA: 0x1AD2340 Slot: 5
	public int get_Count() { }

	// RVA: 0x1AD2360 Offset: 0x1AD2461 VA: 0x1AD2360 Slot: 8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1AD2420 Offset: 0x1AD2521 VA: 0x1AD2420 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x1AD2670 Offset: 0x1AD2771 VA: 0x1AD2670 Slot: 7
	public bool get_IsSynchronized() { }

	// RVA: 0x1AD2680 Offset: 0x1AD2781 VA: 0x1AD2680 Slot: 6
	public object get_SyncRoot() { }
}

