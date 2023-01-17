// Namespace: System.Net
[DefaultMemberAttribute] // RVA: 0x30F90 Offset: 0x31091 VA: 0x30F90
[Serializable]
internal class PathList // TypeDefIndex: 2519
{
	// Fields
	private SortedList m_list; // 0x10

	// Properties
	public int Count { get; }
	public ICollection Values { get; }
	public object Item { get; set; }
	public object SyncRoot { get; }

	// Methods

	// RVA: 0x1AD4230 Offset: 0x1AD4331 VA: 0x1AD4230
	public void .ctor() { }

	// RVA: 0x1AD4310 Offset: 0x1AD4411 VA: 0x1AD4310
	public int get_Count() { }

	// RVA: 0x1AD4330 Offset: 0x1AD4431 VA: 0x1AD4330
	public int GetCookiesCount() { }

	// RVA: 0x1AD4710 Offset: 0x1AD4811 VA: 0x1AD4710
	public ICollection get_Values() { }

	// RVA: 0x1AD4730 Offset: 0x1AD4831 VA: 0x1AD4730
	public object get_Item(string s) { }

	// RVA: 0x1AD4750 Offset: 0x1AD4851 VA: 0x1AD4750
	public void set_Item(string s, object value) { }

	// RVA: 0x1AD4850 Offset: 0x1AD4951 VA: 0x1AD4850
	public IEnumerator GetEnumerator() { }

	// RVA: 0x1AD46F0 Offset: 0x1AD47F1 VA: 0x1AD46F0
	public object get_SyncRoot() { }
}

