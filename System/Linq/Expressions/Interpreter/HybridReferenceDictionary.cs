// Namespace: System.Linq.Expressions.Interpreter
[DefaultMemberAttribute] // RVA: 0x405A0 Offset: 0x406A1 VA: 0x405A0
internal class HybridReferenceDictionary<TKey, TValue> // TypeDefIndex: 3265
{
	// Fields
	private KeyValuePair<TKey, TValue>[] _keysAndValues; // 0x0
	private Dictionary<TKey, TValue> _dict; // 0x0

	// Properties
	public TValue Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EAED00 Offset: 0x1EAEE01 VA: 0x1EAED00
	|-HybridReferenceDictionary<LabelTarget, LabelInfo>.TryGetValue
	|-HybridReferenceDictionary<object, object>.TryGetValue
	|-HybridReferenceDictionary<ParameterExpression, LocalVariables.VariableScope>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	public void Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EAEDB0 Offset: 0x1EAEEB1 VA: 0x1EAEDB0
	|-HybridReferenceDictionary<object, object>.Remove
	|-HybridReferenceDictionary<ParameterExpression, LocalVariables.VariableScope>.Remove
	*/

	// RVA: -1 Offset: -1
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EAEE40 Offset: 0x1EAEF41 VA: 0x1EAEE40
	|-HybridReferenceDictionary<LabelTarget, LabelInfo>.ContainsKey
	|-HybridReferenceDictionary<object, object>.ContainsKey
	*/

	// RVA: -1 Offset: -1
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EAEED0 Offset: 0x1EAEFD1 VA: 0x1EAEED0
	|-HybridReferenceDictionary<LabelTarget, LabelInfo>.GetEnumerator
	|-HybridReferenceDictionary<object, object>.GetEnumerator
	*/

	[IteratorStateMachineAttribute] // RVA: 0x421F0 Offset: 0x422F1 VA: 0x421F0
	// RVA: -1 Offset: -1
	private IEnumerator<KeyValuePair<TKey, TValue>> GetEnumeratorWorker() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EAEF90 Offset: 0x1EAF091 VA: 0x1EAEF90
	|-HybridReferenceDictionary<object, object>.GetEnumeratorWorker
	*/

	// RVA: -1 Offset: -1
	public TValue get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EAF010 Offset: 0x1EAF111 VA: 0x1EAF010
	|-HybridReferenceDictionary<object, object>.get_Item
	|-HybridReferenceDictionary<ParameterExpression, LocalVariables.VariableScope>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EAF080 Offset: 0x1EAF181 VA: 0x1EAF080
	|-HybridReferenceDictionary<LabelTarget, LabelInfo>.set_Item
	|-HybridReferenceDictionary<object, object>.set_Item
	|-HybridReferenceDictionary<ParameterExpression, LocalVariables.VariableScope>.set_Item
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EAF300 Offset: 0x1EAF401 VA: 0x1EAF300
	|-HybridReferenceDictionary<LabelTarget, LabelInfo>..ctor
	|-HybridReferenceDictionary<object, object>..ctor
	|-HybridReferenceDictionary<ParameterExpression, LocalVariables.VariableScope>..ctor
	*/
}

