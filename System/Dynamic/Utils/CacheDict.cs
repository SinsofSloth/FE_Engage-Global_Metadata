// Namespace: System.Dynamic.Utils
[DefaultMemberAttribute] // RVA: 0x40670 Offset: 0x40771 VA: 0x40670
internal sealed class CacheDict<TKey, TValue> // TypeDefIndex: 3273
{
	// Fields
	private readonly int _mask; // 0x0
	private readonly CacheDict.Entry<TKey, TValue>[] _entries; // 0x0

	// Properties
	internal TKey Item { set; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C5E60 Offset: 0x30C5F61 VA: 0x30C5E60
	|-CacheDict<MethodBase, ParameterInfo[]>..ctor
	|-CacheDict<object, object>..ctor
	|-CacheDict<Type, Func<LightLambda, Delegate>>..ctor
	|-CacheDict<Type, Func<Expression, string, bool, ReadOnlyCollection<ParameterExpression>, LambdaExpression>>..ctor
	|-CacheDict<Type, MethodInfo>..ctor
	*/

	// RVA: -1 Offset: -1
	private static int AlignSize(int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C5EF0 Offset: 0x30C5FF1 VA: 0x30C5EF0
	|-CacheDict<object, object>.AlignSize
	*/

	// RVA: -1 Offset: -1
	internal bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C5F10 Offset: 0x30C6011 VA: 0x30C5F10
	|-CacheDict<MethodBase, ParameterInfo[]>.TryGetValue
	|-CacheDict<object, object>.TryGetValue
	|-CacheDict<Type, Func<LightLambda, Delegate>>.TryGetValue
	|-CacheDict<Type, Func<Expression, string, bool, ReadOnlyCollection<ParameterExpression>, LambdaExpression>>.TryGetValue
	|-CacheDict<Type, MethodInfo>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	internal void Add(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C5FE0 Offset: 0x30C60E1 VA: 0x30C5FE0
	|-CacheDict<object, object>.Add
	*/

	// RVA: -1 Offset: -1
	internal void set_Item(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30C6120 Offset: 0x30C6221 VA: 0x30C6120
	|-CacheDict<MethodBase, ParameterInfo[]>.set_Item
	|-CacheDict<object, object>.set_Item
	|-CacheDict<Type, Func<LightLambda, Delegate>>.set_Item
	|-CacheDict<Type, Func<Expression, string, bool, ReadOnlyCollection<ParameterExpression>, LambdaExpression>>.set_Item
	|-CacheDict<Type, MethodInfo>.set_Item
	*/
}

