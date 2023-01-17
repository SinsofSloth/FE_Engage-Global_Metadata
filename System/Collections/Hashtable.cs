// Namespace: System.Collections
[DefaultMemberAttribute] // RVA: 0x476BF0 Offset: 0x476CF1 VA: 0x476BF0
[DebuggerDisplayAttribute] // RVA: 0x476BF0 Offset: 0x476CF1 VA: 0x476BF0
[ComVisibleAttribute] // RVA: 0x476BF0 Offset: 0x476CF1 VA: 0x476BF0
[DebuggerTypeProxyAttribute] // RVA: 0x476BF0 Offset: 0x476CF1 VA: 0x476BF0
[Serializable]
public class Hashtable : IDictionary, ICollection, IEnumerable, ISerializable, IDeserializationCallback, ICloneable // TypeDefIndex: 1354
{
	// Fields
	internal const int HashPrime = 101;
	private const int InitialSize = 3;
	private const string LoadFactorName = "LoadFactor";
	private const string VersionName = "Version";
	private const string ComparerName = "Comparer";
	private const string HashCodeProviderName = "HashCodeProvider";
	private const string HashSizeName = "HashSize";
	private const string KeysName = "Keys";
	private const string ValuesName = "Values";
	private const string KeyComparerName = "KeyComparer";
	private Hashtable.bucket[] buckets; // 0x10
	private int count; // 0x18
	private int occupancy; // 0x1C
	private int loadsize; // 0x20
	private float loadFactor; // 0x24
	private int version; // 0x28
	private bool isWriterInProgress; // 0x2C
	private ICollection keys; // 0x30
	private ICollection values; // 0x38
	private IEqualityComparer _keycomparer; // 0x40
	private object _syncRoot; // 0x48

	// Properties
	public virtual object Item { get; set; }
	public virtual bool IsReadOnly { get; }
	public virtual bool IsFixedSize { get; }
	public virtual bool IsSynchronized { get; }
	public virtual ICollection Keys { get; }
	public virtual ICollection Values { get; }
	public virtual object SyncRoot { get; }
	public virtual int Count { get; }

	// Methods

	// RVA: 0x38BFA70 Offset: 0x38BFB71 VA: 0x38BFA70
	internal void .ctor(bool trash) { }

	// RVA: 0x38BFA80 Offset: 0x38BFB81 VA: 0x38BFA80
	public void .ctor() { }

	// RVA: 0x38BFD80 Offset: 0x38BFE81 VA: 0x38BFD80
	public void .ctor(int capacity) { }

	// RVA: 0x38BFA90 Offset: 0x38BFB91 VA: 0x38BFA90
	public void .ctor(int capacity, float loadFactor) { }

	[ObsoleteAttribute] // RVA: 0x47D7A0 Offset: 0x47D8A1 VA: 0x47D7A0
	// RVA: 0x38BFD90 Offset: 0x38BFE91 VA: 0x38BFD90
	public void .ctor(int capacity, float loadFactor, IHashCodeProvider hcp, IComparer comparer) { }

	// RVA: 0x38BFE50 Offset: 0x38BFF51 VA: 0x38BFE50
	public void .ctor(int capacity, float loadFactor, IEqualityComparer equalityComparer) { }

	[ObsoleteAttribute] // RVA: 0x47D7E0 Offset: 0x47D8E1 VA: 0x47D7E0
	// RVA: 0x38BFE80 Offset: 0x38BFF81 VA: 0x38BFE80
	public void .ctor(IHashCodeProvider hcp, IComparer comparer) { }

	// RVA: 0x38BFF30 Offset: 0x38C0031 VA: 0x38BFF30
	public void .ctor(IEqualityComparer equalityComparer) { }

	// RVA: 0x38BFF70 Offset: 0x38C0071 VA: 0x38BFF70
	public void .ctor(int capacity, IEqualityComparer equalityComparer) { }

	// RVA: 0x38BFFB0 Offset: 0x38C00B1 VA: 0x38BFFB0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x38C0050 Offset: 0x38C0151 VA: 0x38C0050
	private uint InitHash(object key, int hashsize, out uint seed, out uint incr) { }

	// RVA: 0x38C00B0 Offset: 0x38C01B1 VA: 0x38C00B0 Slot: 22
	public virtual void Add(object key, object value) { }

	[ReliabilityContractAttribute] // RVA: 0x47D820 Offset: 0x47D921 VA: 0x47D820
	// RVA: 0x38C0580 Offset: 0x38C0681 VA: 0x38C0580 Slot: 23
	public virtual void Clear() { }

	// RVA: 0x38C06C0 Offset: 0x38C07C1 VA: 0x38C06C0 Slot: 24
	public virtual object Clone() { }

	// RVA: 0x38C07F0 Offset: 0x38C08F1 VA: 0x38C07F0 Slot: 25
	public virtual bool Contains(object key) { }

	// RVA: 0x38C0800 Offset: 0x38C0901 VA: 0x38C0800 Slot: 26
	public virtual bool ContainsKey(object key) { }

	// RVA: 0x38C0980 Offset: 0x38C0A81 VA: 0x38C0980
	private void CopyKeys(Array array, int arrayIndex) { }

	// RVA: 0x38C0A30 Offset: 0x38C0B31 VA: 0x38C0A30
	private void CopyEntries(Array array, int arrayIndex) { }

	// RVA: 0x38C0B50 Offset: 0x38C0C51 VA: 0x38C0B50 Slot: 27
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x38C0CD0 Offset: 0x38C0DD1 VA: 0x38C0CD0
	private void CopyValues(Array array, int arrayIndex) { }

	// RVA: 0x38C0D90 Offset: 0x38C0E91 VA: 0x38C0D90 Slot: 28
	public virtual object get_Item(object key) { }

	// RVA: 0x38C0FB0 Offset: 0x38C10B1 VA: 0x38C0FB0 Slot: 29
	public virtual void set_Item(object key, object value) { }

	// RVA: 0x38C0FC0 Offset: 0x38C10C1 VA: 0x38C0FC0
	private void expand() { }

	// RVA: 0x38C12B0 Offset: 0x38C13B1 VA: 0x38C12B0
	private void rehash() { }

	// RVA: 0x38C0690 Offset: 0x38C0791 VA: 0x38C0690
	private void UpdateVersion() { }

	[ReliabilityContractAttribute] // RVA: 0x47D840 Offset: 0x47D941 VA: 0x47D840
	// RVA: 0x38C10C0 Offset: 0x38C11C1 VA: 0x38C10C0
	private void rehash(int newsize, bool forceNewHashCode) { }

	// RVA: 0x38C13E0 Offset: 0x38C14E1 VA: 0x38C13E0 Slot: 18
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x38C1450 Offset: 0x38C1551 VA: 0x38C1450 Slot: 30
	public virtual IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x38C14C0 Offset: 0x38C15C1 VA: 0x38C14C0 Slot: 31
	protected virtual int GetHash(object key) { }

	// RVA: 0x38C1590 Offset: 0x38C1691 VA: 0x38C1590 Slot: 32
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x38C15A0 Offset: 0x38C16A1 VA: 0x38C15A0 Slot: 33
	public virtual bool get_IsFixedSize() { }

	// RVA: 0x38C15B0 Offset: 0x38C16B1 VA: 0x38C15B0 Slot: 34
	public virtual bool get_IsSynchronized() { }

	// RVA: 0x38C15C0 Offset: 0x38C16C1 VA: 0x38C15C0 Slot: 35
	protected virtual bool KeyEquals(object item, object key) { }

	// RVA: 0x38C16E0 Offset: 0x38C17E1 VA: 0x38C16E0 Slot: 36
	public virtual ICollection get_Keys() { }

	// RVA: 0x38C1780 Offset: 0x38C1881 VA: 0x38C1780 Slot: 37
	public virtual ICollection get_Values() { }

	[ReliabilityContractAttribute] // RVA: 0x47D860 Offset: 0x47D961 VA: 0x47D860
	// RVA: 0x38C00C0 Offset: 0x38C01C1 VA: 0x38C00C0
	private void Insert(object key, object nvalue, bool add) { }

	// RVA: 0x38C12C0 Offset: 0x38C13C1 VA: 0x38C12C0
	private void putEntry(Hashtable.bucket[] newBuckets, object key, object nvalue, int hashcode) { }

	[ReliabilityContractAttribute] // RVA: 0x47D880 Offset: 0x47D981 VA: 0x47D880
	// RVA: 0x38C1820 Offset: 0x38C1921 VA: 0x38C1820 Slot: 38
	public virtual void Remove(object key) { }

	// RVA: 0x38C1A60 Offset: 0x38C1B61 VA: 0x38C1A60 Slot: 39
	public virtual object get_SyncRoot() { }

	// RVA: 0x38C1AF0 Offset: 0x38C1BF1 VA: 0x38C1AF0 Slot: 40
	public virtual int get_Count() { }

	// RVA: 0x38C1B00 Offset: 0x38C1C01 VA: 0x38C1B00
	public static Hashtable Synchronized(Hashtable table) { }

	// RVA: 0x38C1BB0 Offset: 0x38C1CB1 VA: 0x38C1BB0 Slot: 41
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x38C2240 Offset: 0x38C2341 VA: 0x38C2240 Slot: 42
	public virtual void OnDeserialization(object sender) { }
}

