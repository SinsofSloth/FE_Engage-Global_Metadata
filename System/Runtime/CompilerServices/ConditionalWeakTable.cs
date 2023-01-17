// Namespace: System.Runtime.CompilerServices
public sealed class ConditionalWeakTable<TKey, TValue> // TypeDefIndex: 1281
{
	// Fields
	private Ephemeron[] data; // 0x0
	private object _lock; // 0x0
	private int size; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25087E0 Offset: 0x25088E1 VA: 0x25087E0
	|-ConditionalWeakTable<HttpWebRequest, NtlmSession>..ctor
	|-ConditionalWeakTable<object, OSSpecificSynchronizationContext>..ctor
	|-ConditionalWeakTable<object, object>..ctor
	|-ConditionalWeakTable<object, SerializationInfo>..ctor
	|-ConditionalWeakTable<TaskScheduler, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 1
	protected override void Finalize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25088D0 Offset: 0x25089D1 VA: 0x25088D0
	|-ConditionalWeakTable<object, object>.Finalize
	*/

	// RVA: -1 Offset: -1
	private void RehashWithoutResize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25088E0 Offset: 0x25089E1 VA: 0x25088E0
	|-ConditionalWeakTable<object, object>.RehashWithoutResize
	*/

	// RVA: -1 Offset: -1
	private void RecomputeSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2508B00 Offset: 0x2508C01 VA: 0x2508B00
	|-ConditionalWeakTable<object, object>.RecomputeSize
	*/

	// RVA: -1 Offset: -1
	private void Rehash() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2508B80 Offset: 0x2508C81 VA: 0x2508B80
	|-ConditionalWeakTable<object, object>.Rehash
	*/

	// RVA: -1 Offset: -1
	public void Add(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2508EB0 Offset: 0x2508FB1 VA: 0x2508EB0
	|-ConditionalWeakTable<object, object>.Add
	|-ConditionalWeakTable<object, SerializationInfo>.Add
	|-ConditionalWeakTable<TaskScheduler, object>.Add
	*/

	// RVA: -1 Offset: -1
	public bool Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2509210 Offset: 0x2509311 VA: 0x2509210
	|-ConditionalWeakTable<object, object>.Remove
	|-ConditionalWeakTable<object, SerializationInfo>.Remove
	*/

	// RVA: -1 Offset: -1
	public bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25094C0 Offset: 0x25095C1 VA: 0x25094C0
	|-ConditionalWeakTable<Expression, Expression.ExtensionInfo>.TryGetValue
	|-ConditionalWeakTable<object, object>.TryGetValue
	|-ConditionalWeakTable<object, SerializationInfo>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	public TValue GetValue(TKey key, ConditionalWeakTable.CreateValueCallback<TKey, TValue> createValueCallback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2509760 Offset: 0x2509861 VA: 0x2509760
	|-ConditionalWeakTable<HttpWebRequest, NtlmSession>.GetValue
	|-ConditionalWeakTable<object, OSSpecificSynchronizationContext>.GetValue
	|-ConditionalWeakTable<object, object>.GetValue
	*/
}

