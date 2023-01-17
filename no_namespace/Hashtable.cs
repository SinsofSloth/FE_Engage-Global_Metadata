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

