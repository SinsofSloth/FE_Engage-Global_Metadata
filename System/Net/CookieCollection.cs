// Namespace: System.Net
[DefaultMemberAttribute] // RVA: 0x30F50 Offset: 0x31051 VA: 0x30F50
[Serializable]
public class CookieCollection : ICollection, IEnumerable // TypeDefIndex: 2515
{
	// Fields
	internal int m_version; // 0x10
	private ArrayList m_list; // 0x18
	private DateTime m_TimeStamp; // 0x20
	private bool m_has_other_versions; // 0x28
	[OptionalFieldAttribute] // RVA: 0x31670 Offset: 0x31771 VA: 0x31670
	private bool m_IsReadOnly; // 0x29

	// Properties
	public Cookie Item { get; }
	public int Count { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }
	internal bool IsOtherVersionSeen { get; }

	// Methods

	// RVA: 0x1B4D380 Offset: 0x1B4D481 VA: 0x1B4D380
	public void .ctor() { }

	// RVA: 0x1B4D440 Offset: 0x1B4D541 VA: 0x1B4D440
	public Cookie get_Item(int index) { }

	// RVA: 0x1B4D530 Offset: 0x1B4D631 VA: 0x1B4D530
	public void Add(Cookie cookie) { }

	// RVA: 0x1B4D9B0 Offset: 0x1B4DAB1 VA: 0x1B4D9B0
	public void Add(CookieCollection cookies) { }

	// RVA: 0x1B4DD10 Offset: 0x1B4DE11 VA: 0x1B4DD10 Slot: 5
	public int get_Count() { }

	// RVA: 0x1B4DD30 Offset: 0x1B4DE31 VA: 0x1B4DD30 Slot: 7
	public bool get_IsSynchronized() { }

	// RVA: 0x1B4DD40 Offset: 0x1B4DE41 VA: 0x1B4DD40 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x1B4DD50 Offset: 0x1B4DE51 VA: 0x1B4DD50 Slot: 4
	public void CopyTo(Array array, int index) { }

	// RVA: 0x1B4DD70 Offset: 0x1B4DE71 VA: 0x1B4DD70
	internal DateTime TimeStamp(CookieCollection.Stamp how) { }

	// RVA: 0x1B4DE70 Offset: 0x1B4DF71 VA: 0x1B4DE70
	internal bool get_IsOtherVersionSeen() { }

	// RVA: 0x1B4DE80 Offset: 0x1B4DF81 VA: 0x1B4DE80
	internal int InternalAdd(Cookie cookie, bool isStrict) { }

	// RVA: 0x1B4D5F0 Offset: 0x1B4D6F1 VA: 0x1B4D5F0
	internal int IndexOf(Cookie cookie) { }

	// RVA: 0x1B4E2D0 Offset: 0x1B4E3D1 VA: 0x1B4E2D0
	internal void RemoveAt(int idx) { }

	// RVA: 0x1B4DCA0 Offset: 0x1B4DDA1 VA: 0x1B4DCA0 Slot: 8
	public IEnumerator GetEnumerator() { }
}

