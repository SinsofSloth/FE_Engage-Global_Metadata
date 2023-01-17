// Namespace: UniRx
[DefaultMemberAttribute] // RVA: 0x13470 Offset: 0x13571 VA: 0x13470
[Serializable]
public class ReactiveDictionary<TKey, TValue> : IReactiveDictionary<TKey, TValue>, IReadOnlyReactiveDictionary<TKey, TValue>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IDictionary, ICollection, IDisposable, ISerializable, IDeserializationCallback // TypeDefIndex: 6762
{
	// Fields
	private bool isDisposed; // 0x0
	[SerializeField] // RVA: 0x13D70 Offset: 0x13E71 VA: 0x13D70
	private readonly Dictionary<TKey, TValue> inner; // 0x0
	private bool disposedValue; // 0x0
	private Subject<int> countChanged; // 0x0
	private Subject<Unit> collectionReset; // 0x0
	private Subject<DictionaryAddEvent<TKey, TValue>> dictionaryAdd; // 0x0
	private Subject<DictionaryRemoveEvent<TKey, TValue>> dictionaryRemove; // 0x0
	private Subject<DictionaryReplaceEvent<TKey, TValue>> dictionaryReplace; // 0x0

	// Properties
	public TValue Item { get; set; }
	public int Count { get; }
	public Dictionary.KeyCollection<TKey, TValue> Keys { get; }
	public Dictionary.ValueCollection<TKey, TValue> Values { get; }
	private object System.Collections.IDictionary.Item { get; set; }
	private bool System.Collections.IDictionary.IsFixedSize { get; }
	private bool System.Collections.IDictionary.IsReadOnly { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private ICollection System.Collections.IDictionary.Keys { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private ICollection System.Collections.IDictionary.Values { get; }
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly { get; }
	private ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.Keys { get; }
	private ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.Values { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A91470 Offset: 0x2A91571 VA: 0x2A91470
	|-ReactiveDictionary<object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A914F0 Offset: 0x2A915F1 VA: 0x2A914F0
	|-ReactiveDictionary<object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(Dictionary<TKey, TValue> innerDictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A91570 Offset: 0x2A91671 VA: 0x2A91570
	|-ReactiveDictionary<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public TValue get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A915B0 Offset: 0x2A916B1 VA: 0x2A915B0
	|-ReactiveDictionary<object, object>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 42
	public void set_Item(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A915D0 Offset: 0x2A916D1 VA: 0x2A915D0
	|-ReactiveDictionary<object, object>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 36
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A91760 Offset: 0x2A91861 VA: 0x2A91760
	|-ReactiveDictionary<object, object>.get_Count
	*/

	// RVA: -1 Offset: -1
	public Dictionary.KeyCollection<TKey, TValue> get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A91780 Offset: 0x2A91881 VA: 0x2A91780
	|-ReactiveDictionary<object, object>.get_Keys
	*/

	// RVA: -1 Offset: -1
	public Dictionary.ValueCollection<TKey, TValue> get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A917A0 Offset: 0x2A918A1 VA: 0x2A917A0
	|-ReactiveDictionary<object, object>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public void Add(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A917C0 Offset: 0x2A918C1 VA: 0x2A917C0
	|-ReactiveDictionary<object, object>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 21
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A918C0 Offset: 0x2A919C1 VA: 0x2A918C0
	|-ReactiveDictionary<object, object>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 43
	public bool Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A91A50 Offset: 0x2A91B51 VA: 0x2A91A50
	|-ReactiveDictionary<object, object>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A91B80 Offset: 0x2A91C81 VA: 0x2A91B80
	|-ReactiveDictionary<object, object>.ContainsKey
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A91BA0 Offset: 0x2A91CA1 VA: 0x2A91BA0
	|-ReactiveDictionary<object, object>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	public Dictionary.Enumerator<TKey, TValue> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A91BC0 Offset: 0x2A91CC1 VA: 0x2A91BC0
	|-ReactiveDictionary<object, object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	private void DisposeSubject<TSubject>(ref Subject<TSubject> subject) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2554A30 Offset: 0x2554B31 VA: 0x2554A30
	|-ReactiveDictionary<object, object>.DisposeSubject<DictionaryAddEvent<object, object>>
	|
	|-RVA: 0x2554B00 Offset: 0x2554C01 VA: 0x2554B00
	|-ReactiveDictionary<object, object>.DisposeSubject<DictionaryRemoveEvent<object, object>>
	|
	|-RVA: 0x2554BD0 Offset: 0x2554CD1 VA: 0x2554BD0
	|-ReactiveDictionary<object, object>.DisposeSubject<DictionaryReplaceEvent<object, object>>
	|
	|-RVA: 0x2554CA0 Offset: 0x2554DA1 VA: 0x2554CA0
	|-ReactiveDictionary<object, object>.DisposeSubject<int>
	|
	|-RVA: 0x2554D70 Offset: 0x2554E71 VA: 0x2554D70
	|-ReactiveDictionary<object, object>.DisposeSubject<object>
	|
	|-RVA: 0x2554E40 Offset: 0x2554F41 VA: 0x2554E40
	|-ReactiveDictionary<object, object>.DisposeSubject<Unit>
	*/

	// RVA: -1 Offset: -1 Slot: 44
	protected virtual void Dispose(bool disposing) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A91C20 Offset: 0x2A91D21 VA: 0x2A91C20
	|-ReactiveDictionary<object, object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 39
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A91CF0 Offset: 0x2A91DF1 VA: 0x2A91CF0
	|-ReactiveDictionary<object, object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public IObservable<int> ObserveCountChanged(bool notifyCurrentCount = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A91D10 Offset: 0x2A91E11 VA: 0x2A91D10
	|-ReactiveDictionary<object, object>.ObserveCountChanged
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public IObservable<Unit> ObserveReset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A91EC0 Offset: 0x2A91FC1 VA: 0x2A91EC0
	|-ReactiveDictionary<object, object>.ObserveReset
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public IObservable<DictionaryAddEvent<TKey, TValue>> ObserveAdd() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A91FC0 Offset: 0x2A920C1 VA: 0x2A91FC0
	|-ReactiveDictionary<object, object>.ObserveAdd
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public IObservable<DictionaryRemoveEvent<TKey, TValue>> ObserveRemove() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A920B0 Offset: 0x2A921B1 VA: 0x2A920B0
	|-ReactiveDictionary<object, object>.ObserveRemove
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public IObservable<DictionaryReplaceEvent<TKey, TValue>> ObserveReplace() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A921A0 Offset: 0x2A922A1 VA: 0x2A921A0
	|-ReactiveDictionary<object, object>.ObserveReplace
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private object System.Collections.IDictionary.get_Item(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A92290 Offset: 0x2A92391 VA: 0x2A92290
	|-ReactiveDictionary<object, object>.System.Collections.IDictionary.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private void System.Collections.IDictionary.set_Item(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A92330 Offset: 0x2A92431 VA: 0x2A92330
	|-ReactiveDictionary<object, object>.System.Collections.IDictionary.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 32
	private bool System.Collections.IDictionary.get_IsFixedSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A92420 Offset: 0x2A92521 VA: 0x2A92420
	|-ReactiveDictionary<object, object>.System.Collections.IDictionary.get_IsFixedSize
	*/

	// RVA: -1 Offset: -1 Slot: 31
	private bool System.Collections.IDictionary.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A924D0 Offset: 0x2A925D1 VA: 0x2A924D0
	|-ReactiveDictionary<object, object>.System.Collections.IDictionary.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 38
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A92580 Offset: 0x2A92681 VA: 0x2A92580
	|-ReactiveDictionary<object, object>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 27
	private ICollection System.Collections.IDictionary.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A92630 Offset: 0x2A92731 VA: 0x2A92630
	|-ReactiveDictionary<object, object>.System.Collections.IDictionary.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 37
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A926E0 Offset: 0x2A927E1 VA: 0x2A926E0
	|-ReactiveDictionary<object, object>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 28
	private ICollection System.Collections.IDictionary.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A92790 Offset: 0x2A92891 VA: 0x2A92790
	|-ReactiveDictionary<object, object>.System.Collections.IDictionary.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A92840 Offset: 0x2A92941 VA: 0x2A92840
	|-ReactiveDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A928D0 Offset: 0x2A929D1 VA: 0x2A928D0
	|-ReactiveDictionary<object, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A928F0 Offset: 0x2A929F1 VA: 0x2A928F0
	|-ReactiveDictionary<object, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 30
	private void System.Collections.IDictionary.Add(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A92910 Offset: 0x2A92A11 VA: 0x2A92910
	|-ReactiveDictionary<object, object>.System.Collections.IDictionary.Add
	*/

	// RVA: -1 Offset: -1 Slot: 29
	private bool System.Collections.IDictionary.Contains(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A92A00 Offset: 0x2A92B01 VA: 0x2A92A00
	|-ReactiveDictionary<object, object>.System.Collections.IDictionary.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 35
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A92AB0 Offset: 0x2A92BB1 VA: 0x2A92AB0
	|-ReactiveDictionary<object, object>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 40
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A92B70 Offset: 0x2A92C71 VA: 0x2A92B70
	|-ReactiveDictionary<object, object>.GetObjectData
	*/

	// RVA: -1 Offset: -1 Slot: 41
	public void OnDeserialization(object sender) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A92C40 Offset: 0x2A92D41 VA: 0x2A92C40
	|-ReactiveDictionary<object, object>.OnDeserialization
	*/

	// RVA: -1 Offset: -1 Slot: 34
	private void System.Collections.IDictionary.Remove(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A92CF0 Offset: 0x2A92DF1 VA: 0x2A92CF0
	|-ReactiveDictionary<object, object>.System.Collections.IDictionary.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A92D90 Offset: 0x2A92E91 VA: 0x2A92D90
	|-ReactiveDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 22
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair<TKey, TValue> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A92DB0 Offset: 0x2A92EB1 VA: 0x2A92DB0
	|-ReactiveDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A92E60 Offset: 0x2A92F61 VA: 0x2A92E60
	|-ReactiveDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private IEnumerator<KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A92F10 Offset: 0x2A93011 VA: 0x2A92F10
	|-ReactiveDictionary<object, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A92FA0 Offset: 0x2A930A1 VA: 0x2A92FA0
	|-ReactiveDictionary<object, object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A93030 Offset: 0x2A93131 VA: 0x2A93030
	|-ReactiveDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 33
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A930E0 Offset: 0x2A931E1 VA: 0x2A930E0
	|-ReactiveDictionary<object, object>.System.Collections.IDictionary.GetEnumerator
	*/

	[CompilerGeneratedAttribute] // RVA: 0x17560 Offset: 0x17661 VA: 0x17560
	// RVA: -1 Offset: -1
	private int <ObserveCountChanged>b__25_0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A93190 Offset: 0x2A93291 VA: 0x2A93190
	|-ReactiveDictionary<object, object>.<ObserveCountChanged>b__25_0
	*/
}

