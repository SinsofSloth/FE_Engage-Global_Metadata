// Namespace: 
private struct Hashtable.bucket // TypeDefIndex: 1348
{
	// Fields
	public object key; // 0x0
	public object val; // 0x8
	public int hash_coll; // 0x10
}

// Namespace: 
[Serializable]
private class Hashtable.KeyCollection : ICollection, IEnumerable // TypeDefIndex: 1349
{
	// Fields
	private Hashtable _hashtable; // 0x10

	// Properties
	public virtual bool IsSynchronized { get; }
	public virtual object SyncRoot { get; }
	public virtual int Count { get; }

	// Methods

	// RVA: 0x35EC580 Offset: 0x35EC681 VA: 0x35EC580
	internal void .ctor(Hashtable hashtable) { }

	// RVA: 0x35EC5C0 Offset: 0x35EC6C1 VA: 0x35EC5C0 Slot: 9
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x35EC730 Offset: 0x35EC831 VA: 0x35EC730 Slot: 10
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x35EC7D0 Offset: 0x35EC8D1 VA: 0x35EC7D0 Slot: 11
	public virtual bool get_IsSynchronized() { }

	// RVA: 0x35EC7F0 Offset: 0x35EC8F1 VA: 0x35EC7F0 Slot: 12
	public virtual object get_SyncRoot() { }

	// RVA: 0x35EC810 Offset: 0x35EC911 VA: 0x35EC810 Slot: 13
	public virtual int get_Count() { }
}

// Namespace: 
[Serializable]
private class Hashtable.ValueCollection : ICollection, IEnumerable // TypeDefIndex: 1350
{
	// Fields
	private Hashtable _hashtable; // 0x10

	// Properties
	public virtual bool IsSynchronized { get; }
	public virtual object SyncRoot { get; }
	public virtual int Count { get; }

	// Methods

	// RVA: 0x35ED5D0 Offset: 0x35ED6D1 VA: 0x35ED5D0
	internal void .ctor(Hashtable hashtable) { }

	// RVA: 0x35ED610 Offset: 0x35ED711 VA: 0x35ED610 Slot: 9
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x35ED780 Offset: 0x35ED881 VA: 0x35ED780 Slot: 10
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x35ED820 Offset: 0x35ED921 VA: 0x35ED820 Slot: 11
	public virtual bool get_IsSynchronized() { }

	// RVA: 0x35ED840 Offset: 0x35ED941 VA: 0x35ED840 Slot: 12
	public virtual object get_SyncRoot() { }

	// RVA: 0x35ED860 Offset: 0x35ED961 VA: 0x35ED860 Slot: 13
	public virtual int get_Count() { }
}

// Namespace: 
[DefaultMemberAttribute] // RVA: 0x476CC0 Offset: 0x476DC1 VA: 0x476CC0
[Serializable]
private class Hashtable.SyncHashtable : Hashtable, IEnumerable // TypeDefIndex: 1351
{
	// Fields
	protected Hashtable _table; // 0x50

	// Properties
	public override int Count { get; }
	public override bool IsReadOnly { get; }
	public override bool IsFixedSize { get; }
	public override bool IsSynchronized { get; }
	public override object Item { get; set; }
	public override object SyncRoot { get; }
	public override ICollection Keys { get; }
	public override ICollection Values { get; }

	// Methods

	// RVA: 0x35EC820 Offset: 0x35EC921 VA: 0x35EC820
	internal void .ctor(Hashtable table) { }

	// RVA: 0x35EC860 Offset: 0x35EC961 VA: 0x35EC860
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x35ECA00 Offset: 0x35ECB01 VA: 0x35ECA00 Slot: 41
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x35ECBD0 Offset: 0x35ECCD1 VA: 0x35ECBD0 Slot: 40
	public override int get_Count() { }

	// RVA: 0x35ECBF0 Offset: 0x35ECCF1 VA: 0x35ECBF0 Slot: 32
	public override bool get_IsReadOnly() { }

	// RVA: 0x35ECC10 Offset: 0x35ECD11 VA: 0x35ECC10 Slot: 33
	public override bool get_IsFixedSize() { }

	// RVA: 0x35ECC30 Offset: 0x35ECD31 VA: 0x35ECC30 Slot: 34
	public override bool get_IsSynchronized() { }

	// RVA: 0x35ECC40 Offset: 0x35ECD41 VA: 0x35ECC40 Slot: 28
	public override object get_Item(object key) { }

	// RVA: 0x35ECC60 Offset: 0x35ECD61 VA: 0x35ECC60 Slot: 29
	public override void set_Item(object key, object value) { }

	// RVA: 0x35ECD60 Offset: 0x35ECE61 VA: 0x35ECD60 Slot: 39
	public override object get_SyncRoot() { }

	// RVA: 0x35ECD80 Offset: 0x35ECE81 VA: 0x35ECD80 Slot: 22
	public override void Add(object key, object value) { }

	// RVA: 0x35ECE80 Offset: 0x35ECF81 VA: 0x35ECE80 Slot: 23
	public override void Clear() { }

	// RVA: 0x35ECF70 Offset: 0x35ED071 VA: 0x35ECF70 Slot: 25
	public override bool Contains(object key) { }

	// RVA: 0x35ECF90 Offset: 0x35ED091 VA: 0x35ECF90 Slot: 26
	public override bool ContainsKey(object key) { }

	// RVA: 0x35ED020 Offset: 0x35ED121 VA: 0x35ED020 Slot: 27
	public override void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x35ED120 Offset: 0x35ED221 VA: 0x35ED120 Slot: 24
	public override object Clone() { }

	// RVA: 0x35ED280 Offset: 0x35ED381 VA: 0x35ED280 Slot: 18
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x35ED2A0 Offset: 0x35ED3A1 VA: 0x35ED2A0 Slot: 30
	public override IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x35ED2C0 Offset: 0x35ED3C1 VA: 0x35ED2C0 Slot: 36
	public override ICollection get_Keys() { }

	// RVA: 0x35ED3C0 Offset: 0x35ED4C1 VA: 0x35ED3C0 Slot: 37
	public override ICollection get_Values() { }

	// RVA: 0x35ED4C0 Offset: 0x35ED5C1 VA: 0x35ED4C0 Slot: 38
	public override void Remove(object key) { }

	// RVA: 0x35ED5C0 Offset: 0x35ED6C1 VA: 0x35ED5C0 Slot: 42
	public override void OnDeserialization(object sender) { }
}

// Namespace: 
[Serializable]
private class Hashtable.HashtableEnumerator : IDictionaryEnumerator, IEnumerator, ICloneable // TypeDefIndex: 1352
{
	// Fields
	private Hashtable hashtable; // 0x10
	private int bucket; // 0x18
	private int version; // 0x1C
	private bool current; // 0x20
	private int getObjectRetType; // 0x24
	private object currentKey; // 0x28
	private object currentValue; // 0x30

	// Properties
	public virtual object Key { get; }
	public virtual DictionaryEntry Entry { get; }
	public virtual object Current { get; }
	public virtual object Value { get; }

	// Methods

	// RVA: 0x35EC070 Offset: 0x35EC171 VA: 0x35EC070
	internal void .ctor(Hashtable hashtable, int getObjRetType) { }

	// RVA: 0x35EC0E0 Offset: 0x35EC1E1 VA: 0x35EC0E0 Slot: 10
	public object Clone() { }

	// RVA: 0x35EC0F0 Offset: 0x35EC1F1 VA: 0x35EC0F0 Slot: 11
	public virtual object get_Key() { }

	// RVA: 0x35EC170 Offset: 0x35EC271 VA: 0x35EC170 Slot: 12
	public virtual bool MoveNext() { }

	// RVA: 0x35EC2A0 Offset: 0x35EC3A1 VA: 0x35EC2A0 Slot: 13
	public virtual DictionaryEntry get_Entry() { }

	// RVA: 0x35EC330 Offset: 0x35EC431 VA: 0x35EC330 Slot: 14
	public virtual object get_Current() { }

	// RVA: 0x35EC440 Offset: 0x35EC541 VA: 0x35EC440 Slot: 15
	public virtual object get_Value() { }

	// RVA: 0x35EC4C0 Offset: 0x35EC5C1 VA: 0x35EC4C0 Slot: 16
	public virtual void Reset() { }
}

// Namespace: 
internal class Hashtable.HashtableDebugView // TypeDefIndex: 1353
{}

