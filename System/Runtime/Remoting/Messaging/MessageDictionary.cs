// Namespace: System.Runtime.Remoting.Messaging
[DefaultMemberAttribute] // RVA: 0x4752C0 Offset: 0x4753C1 VA: 0x4752C0
[Serializable]
internal class MessageDictionary : IDictionary, ICollection, IEnumerable // TypeDefIndex: 1211
{
	// Fields
	private IDictionary _internalProperties; // 0x10
	protected IMethodMessage _message; // 0x18
	private string[] _methodKeys; // 0x20
	private bool _ownProperties; // 0x28

	// Properties
	internal IDictionary InternalDictionary { get; }
	public string[] MethodKeys { set; }
	public bool IsFixedSize { get; }
	public bool IsReadOnly { get; }
	public object Item { get; set; }
	public ICollection Keys { get; }
	public ICollection Values { get; }
	public int Count { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }

	// Methods

	// RVA: 0x34EADA0 Offset: 0x34EAEA1 VA: 0x34EADA0
	public void .ctor(IMethodMessage message) { }

	// RVA: 0x34EADE0 Offset: 0x34EAEE1 VA: 0x34EADE0
	internal bool HasUserData() { }

	// RVA: 0x34EAEF0 Offset: 0x34EAFF1 VA: 0x34EAEF0
	internal IDictionary get_InternalDictionary() { }

	// RVA: 0x34EAF80 Offset: 0x34EB081 VA: 0x34EAF80
	public void set_MethodKeys(string[] value) { }

	// RVA: 0x34EAF90 Offset: 0x34EB091 VA: 0x34EAF90 Slot: 19
	protected virtual IDictionary AllocInternalProperties() { }

	// RVA: 0x34EB000 Offset: 0x34EB101 VA: 0x34EB000
	public IDictionary GetInternalProperties() { }

	// RVA: 0x34EB060 Offset: 0x34EB161 VA: 0x34EB060
	private bool IsOverridenKey(string key) { }

	// RVA: 0x34EB100 Offset: 0x34EB201 VA: 0x34EB100 Slot: 11
	public bool get_IsFixedSize() { }

	// RVA: 0x34EB110 Offset: 0x34EB211 VA: 0x34EB110 Slot: 10
	public bool get_IsReadOnly() { }

	// RVA: 0x34EB120 Offset: 0x34EB221 VA: 0x34EB120 Slot: 4
	public object get_Item(object key) { }

	// RVA: 0x34EB280 Offset: 0x34EB381 VA: 0x34EB280 Slot: 5
	public void set_Item(object key, object value) { }

	// RVA: 0x34EB430 Offset: 0x34EB531 VA: 0x34EB430 Slot: 20
	protected virtual object GetMethodProperty(string key) { }

	// RVA: 0x34EB970 Offset: 0x34EBA71 VA: 0x34EB970 Slot: 21
	protected virtual void SetMethodProperty(string key, object value) { }

	// RVA: 0x34EBC30 Offset: 0x34EBD31 VA: 0x34EBC30 Slot: 6
	public ICollection get_Keys() { }

	// RVA: 0x34EC080 Offset: 0x34EC181 VA: 0x34EC080 Slot: 7
	public ICollection get_Values() { }

	// RVA: 0x34EB290 Offset: 0x34EB391 VA: 0x34EB290 Slot: 9
	public void Add(object key, object value) { }

	// RVA: 0x34EC4C0 Offset: 0x34EC5C1 VA: 0x34EC4C0 Slot: 8
	public bool Contains(object key) { }

	// RVA: 0x34EC630 Offset: 0x34EC731 VA: 0x34EC630 Slot: 13
	public void Remove(object key) { }

	// RVA: 0x34EC7D0 Offset: 0x34EC8D1 VA: 0x34EC7D0 Slot: 15
	public int get_Count() { }

	// RVA: 0x34EC8A0 Offset: 0x34EC9A1 VA: 0x34EC8A0 Slot: 17
	public bool get_IsSynchronized() { }

	// RVA: 0x34EC8B0 Offset: 0x34EC9B1 VA: 0x34EC8B0 Slot: 16
	public object get_SyncRoot() { }

	// RVA: 0x34EC8C0 Offset: 0x34EC9C1 VA: 0x34EC8C0 Slot: 14
	public void CopyTo(Array array, int index) { }

	// RVA: 0x34EC990 Offset: 0x34ECA91 VA: 0x34EC990 Slot: 18
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x34ECA00 Offset: 0x34ECB01 VA: 0x34ECA00 Slot: 12
	public IDictionaryEnumerator GetEnumerator() { }
}

