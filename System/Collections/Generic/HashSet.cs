// Namespace: System.Collections.Generic
[DebuggerTypeProxyAttribute] // RVA: 0x40720 Offset: 0x40821 VA: 0x40720
[DebuggerDisplayAttribute] // RVA: 0x40720 Offset: 0x40821 VA: 0x40720
[Serializable]
public class HashSet<T> : ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyCollection<T>, ISerializable, IDeserializationCallback // TypeDefIndex: 3288
{
	// Fields
	private const int Lower31BitMask = 2147483647;
	private const int StackAllocThreshold = 100;
	private const int ShrinkThreshold = 3;
	private const string CapacityName = "Capacity";
	private const string ElementsName = "Elements";
	private const string ComparerName = "Comparer";
	private const string VersionName = "Version";
	private int[] _buckets; // 0x0
	private HashSet.Slot<T>[] _slots; // 0x0
	private int _count; // 0x0
	private int _lastIndex; // 0x0
	private int _freeList; // 0x0
	private IEqualityComparer<T> _comparer; // 0x0
	private int _version; // 0x0
	private SerializationInfo _siInfo; // 0x0

	// Properties
	public int Count { get; }
	private bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }
	public IEqualityComparer<T> Comparer { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EC5700 Offset: 0x3EC5801 VA: 0x3EC5700
	|-HashSet<Action<RenderTargetIdentifier, CommandBuffer>>..ctor
	|-HashSet<AkRoomAwareObject>..ctor
	|-HashSet<GameObject>..ctor
	|-HashSet<IClippable>..ctor
	|-HashSet<IResourceLocation>..ctor
	|-HashSet<LabelScopeInfo>..ctor
	|-HashSet<MaskableGraphic>..ctor
	|-HashSet<object>..ctor
	|-HashSet<Object>..ctor
	|-HashSet<ParameterExpression>..ctor
	|-HashSet<RTHandle>..ctor
	|-HashSet<string>..ctor
	|-HashSet<Text>..ctor
	|-HashSet<Timer>..ctor
	|-HashSet<Transform>..ctor
	|-HashSet<Type>..ctor
	|-HashSet<ResourceManager.InstanceOperation>..ctor
	|
	|-RVA: 0x3EB4410 Offset: 0x3EB4511 VA: 0x3EB4410
	|-HashSet<ValueTuple<object, int>>..ctor
	|-HashSet<ValueTuple<string, int>>..ctor
	|
	|-RVA: 0x3EB7BA0 Offset: 0x3EB7CA1 VA: 0x3EB7BA0
	|-HashSet<AsyncOperationHandle>..ctor
	|
	|-RVA: 0x3EBB530 Offset: 0x3EBB631 VA: 0x3EBB530
	|-HashSet<int>..ctor
	|
	|-RVA: 0x3EBEB40 Offset: 0x3EBEC41 VA: 0x3EBEB40
	|-HashSet<Int32Enum>..ctor
	|-HashSet<ItemData.Kinds>..ctor
	|
	|-RVA: 0x3EC2150 Offset: 0x3EC2251 VA: 0x3EC2150
	|-HashSet<MapPos>..ctor
	|
	|-RVA: 0x3EC8D40 Offset: 0x3EC8E41 VA: 0x3EC8D40
	|-HashSet<uint>..ctor
	|
	|-RVA: 0x3ECC350 Offset: 0x3ECC451 VA: 0x3ECC350
	|-HashSet<ulong>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEqualityComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EB4460 Offset: 0x3EB4561 VA: 0x3EB4460
	|-HashSet<ValueTuple<object, int>>..ctor
	|
	|-RVA: 0x3EB7BF0 Offset: 0x3EB7CF1 VA: 0x3EB7BF0
	|-HashSet<AsyncOperationHandle>..ctor
	|
	|-RVA: 0x3EBB580 Offset: 0x3EBB681 VA: 0x3EBB580
	|-HashSet<int>..ctor
	|
	|-RVA: 0x3EBEB90 Offset: 0x3EBEC91 VA: 0x3EBEB90
	|-HashSet<Int32Enum>..ctor
	|
	|-RVA: 0x3EC21A0 Offset: 0x3EC22A1 VA: 0x3EC21A0
	|-HashSet<MapPos>..ctor
	|
	|-RVA: 0x3EC5750 Offset: 0x3EC5851 VA: 0x3EC5750
	|-HashSet<object>..ctor
	|
	|-RVA: 0x3EC8D90 Offset: 0x3EC8E91 VA: 0x3EC8D90
	|-HashSet<uint>..ctor
	|
	|-RVA: 0x3ECC3A0 Offset: 0x3ECC4A1 VA: 0x3ECC3A0
	|-HashSet<ulong>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EB44D0 Offset: 0x3EB45D1 VA: 0x3EB44D0
	|-HashSet<ValueTuple<object, int>>..ctor
	|
	|-RVA: 0x3EB7C60 Offset: 0x3EB7D61 VA: 0x3EB7C60
	|-HashSet<AsyncOperationHandle>..ctor
	|
	|-RVA: 0x3EBB5F0 Offset: 0x3EBB6F1 VA: 0x3EBB5F0
	|-HashSet<int>..ctor
	|
	|-RVA: 0x3EBEC00 Offset: 0x3EBED01 VA: 0x3EBEC00
	|-HashSet<Int32Enum>..ctor
	|
	|-RVA: 0x3EC2210 Offset: 0x3EC2311 VA: 0x3EC2210
	|-HashSet<MapPos>..ctor
	|
	|-RVA: 0x3EC57C0 Offset: 0x3EC58C1 VA: 0x3EC57C0
	|-HashSet<object>..ctor
	|-HashSet<ParameterExpression>..ctor
	|-HashSet<string>..ctor
	|-HashSet<Type>..ctor
	|
	|-RVA: 0x3EC8E00 Offset: 0x3EC8F01 VA: 0x3EC8E00
	|-HashSet<uint>..ctor
	|
	|-RVA: 0x3ECC410 Offset: 0x3ECC511 VA: 0x3ECC410
	|-HashSet<ulong>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<T> collection, IEqualityComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EB4530 Offset: 0x3EB4631 VA: 0x3EB4530
	|-HashSet<ValueTuple<object, int>>..ctor
	|
	|-RVA: 0x3EB7CC0 Offset: 0x3EB7DC1 VA: 0x3EB7CC0
	|-HashSet<AsyncOperationHandle>..ctor
	|
	|-RVA: 0x3EC5820 Offset: 0x3EC5921 VA: 0x3EC5820
	|-HashSet<IResourceLocation>..ctor
	|-HashSet<object>..ctor
	|
	|-RVA: 0x3EBB650 Offset: 0x3EBB751 VA: 0x3EBB650
	|-HashSet<int>..ctor
	|
	|-RVA: 0x3EBEC60 Offset: 0x3EBED61 VA: 0x3EBEC60
	|-HashSet<Int32Enum>..ctor
	|
	|-RVA: 0x3EC2270 Offset: 0x3EC2371 VA: 0x3EC2270
	|-HashSet<MapPos>..ctor
	|
	|-RVA: 0x3EC8E60 Offset: 0x3EC8F61 VA: 0x3EC8E60
	|-HashSet<uint>..ctor
	|
	|-RVA: 0x3ECC470 Offset: 0x3ECC571 VA: 0x3ECC470
	|-HashSet<ulong>..ctor
	*/

	// RVA: -1 Offset: -1
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EB4780 Offset: 0x3EB4881 VA: 0x3EB4780
	|-HashSet<ValueTuple<object, int>>..ctor
	|
	|-RVA: 0x3EB7F10 Offset: 0x3EB8011 VA: 0x3EB7F10
	|-HashSet<AsyncOperationHandle>..ctor
	|
	|-RVA: 0x3EBB8A0 Offset: 0x3EBB9A1 VA: 0x3EBB8A0
	|-HashSet<int>..ctor
	|
	|-RVA: 0x3EBEEB0 Offset: 0x3EBEFB1 VA: 0x3EBEEB0
	|-HashSet<Int32Enum>..ctor
	|
	|-RVA: 0x3EC24C0 Offset: 0x3EC25C1 VA: 0x3EC24C0
	|-HashSet<MapPos>..ctor
	|
	|-RVA: 0x3EC5A70 Offset: 0x3EC5B71 VA: 0x3EC5A70
	|-HashSet<object>..ctor
	|
	|-RVA: 0x3EC90B0 Offset: 0x3EC91B1 VA: 0x3EC90B0
	|-HashSet<uint>..ctor
	|
	|-RVA: 0x3ECC6C0 Offset: 0x3ECC7C1 VA: 0x3ECC6C0
	|-HashSet<ulong>..ctor
	*/

	// RVA: -1 Offset: -1
	private void CopyFrom(HashSet<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EB47C0 Offset: 0x3EB48C1 VA: 0x3EB47C0
	|-HashSet<ValueTuple<object, int>>.CopyFrom
	|
	|-RVA: 0x3EB7F50 Offset: 0x3EB8051 VA: 0x3EB7F50
	|-HashSet<AsyncOperationHandle>.CopyFrom
	|
	|-RVA: 0x3EBB8E0 Offset: 0x3EBB9E1 VA: 0x3EBB8E0
	|-HashSet<int>.CopyFrom
	|
	|-RVA: 0x3EBEEF0 Offset: 0x3EBEFF1 VA: 0x3EBEEF0
	|-HashSet<Int32Enum>.CopyFrom
	|
	|-RVA: 0x3EC2500 Offset: 0x3EC2601 VA: 0x3EC2500
	|-HashSet<MapPos>.CopyFrom
	|
	|-RVA: 0x3EC5AB0 Offset: 0x3EC5BB1 VA: 0x3EC5AB0
	|-HashSet<object>.CopyFrom
	|
	|-RVA: 0x3EC90F0 Offset: 0x3EC91F1 VA: 0x3EC90F0
	|-HashSet<uint>.CopyFrom
	|
	|-RVA: 0x3ECC700 Offset: 0x3ECC801 VA: 0x3ECC700
	|-HashSet<ulong>.CopyFrom
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.Generic.ICollection<T>.Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EB49D0 Offset: 0x3EB4AD1 VA: 0x3EB49D0
	|-HashSet<ValueTuple<object, int>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3EB8180 Offset: 0x3EB8281 VA: 0x3EB8180
	|-HashSet<AsyncOperationHandle>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3EBBAF0 Offset: 0x3EBBBF1 VA: 0x3EBBAF0
	|-HashSet<int>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3EBF100 Offset: 0x3EBF201 VA: 0x3EBF100
	|-HashSet<Int32Enum>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3EC2710 Offset: 0x3EC2811 VA: 0x3EC2710
	|-HashSet<MapPos>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3EC5CC0 Offset: 0x3EC5DC1 VA: 0x3EC5CC0
	|-HashSet<object>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3EC9300 Offset: 0x3EC9401 VA: 0x3EC9300
	|-HashSet<uint>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x3ECC910 Offset: 0x3ECCA11 VA: 0x3ECC910
	|-HashSet<ulong>.System.Collections.Generic.ICollection<T>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EB49F0 Offset: 0x3EB4AF1 VA: 0x3EB49F0
	|-HashSet<ValueTuple<object, int>>.Clear
	|
	|-RVA: 0x3EC5CE0 Offset: 0x3EC5DE1 VA: 0x3EC5CE0
	|-HashSet<AkRoomAwareObject>.Clear
	|-HashSet<IClippable>.Clear
	|-HashSet<MaskableGraphic>.Clear
	|-HashSet<object>.Clear
	|-HashSet<RTHandle>.Clear
	|-HashSet<string>.Clear
	|
	|-RVA: 0x3EB81D0 Offset: 0x3EB82D1 VA: 0x3EB81D0
	|-HashSet<AsyncOperationHandle>.Clear
	|
	|-RVA: 0x3EBBB10 Offset: 0x3EBBC11 VA: 0x3EBBB10
	|-HashSet<int>.Clear
	|
	|-RVA: 0x3EBF120 Offset: 0x3EBF221 VA: 0x3EBF120
	|-HashSet<Int32Enum>.Clear
	|
	|-RVA: 0x3EC2730 Offset: 0x3EC2831 VA: 0x3EC2730
	|-HashSet<MapPos>.Clear
	|
	|-RVA: 0x3EC9320 Offset: 0x3EC9421 VA: 0x3EC9320
	|-HashSet<uint>.Clear
	|
	|-RVA: 0x3ECC930 Offset: 0x3ECCA31 VA: 0x3ECC930
	|-HashSet<ulong>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EB4A60 Offset: 0x3EB4B61 VA: 0x3EB4A60
	|-HashSet<ValueTuple<object, int>>.Contains
	|
	|-RVA: 0x3EC5D50 Offset: 0x3EC5E51 VA: 0x3EC5D50
	|-HashSet<AkRoomAwareObject>.Contains
	|-HashSet<GameObject>.Contains
	|-HashSet<LabelScopeInfo>.Contains
	|-HashSet<object>.Contains
	|-HashSet<Object>.Contains
	|-HashSet<RTHandle>.Contains
	|-HashSet<string>.Contains
	|-HashSet<Type>.Contains
	|
	|-RVA: 0x3EB8240 Offset: 0x3EB8341 VA: 0x3EB8240
	|-HashSet<AsyncOperationHandle>.Contains
	|
	|-RVA: 0x3EBBB80 Offset: 0x3EBBC81 VA: 0x3EBBB80
	|-HashSet<int>.Contains
	|
	|-RVA: 0x3EBF190 Offset: 0x3EBF291 VA: 0x3EBF190
	|-HashSet<Int32Enum>.Contains
	|
	|-RVA: 0x3EC27A0 Offset: 0x3EC28A1 VA: 0x3EC27A0
	|-HashSet<MapPos>.Contains
	|
	|-RVA: 0x3EC9390 Offset: 0x3EC9491 VA: 0x3EC9390
	|-HashSet<uint>.Contains
	|
	|-RVA: 0x3ECC9A0 Offset: 0x3ECCAA1 VA: 0x3ECC9A0
	|-HashSet<ulong>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EB4C00 Offset: 0x3EB4D01 VA: 0x3EB4C00
	|-HashSet<ValueTuple<object, int>>.CopyTo
	|
	|-RVA: 0x3EB8430 Offset: 0x3EB8531 VA: 0x3EB8430
	|-HashSet<AsyncOperationHandle>.CopyTo
	|
	|-RVA: 0x3EBBD00 Offset: 0x3EBBE01 VA: 0x3EBBD00
	|-HashSet<int>.CopyTo
	|
	|-RVA: 0x3EBF310 Offset: 0x3EBF411 VA: 0x3EBF310
	|-HashSet<Int32Enum>.CopyTo
	|
	|-RVA: 0x3EC2910 Offset: 0x3EC2A11 VA: 0x3EC2910
	|-HashSet<MapPos>.CopyTo
	|
	|-RVA: 0x3EC5EC0 Offset: 0x3EC5FC1 VA: 0x3EC5EC0
	|-HashSet<object>.CopyTo
	|
	|-RVA: 0x3EC9510 Offset: 0x3EC9611 VA: 0x3EC9510
	|-HashSet<uint>.CopyTo
	|
	|-RVA: 0x3ECCB10 Offset: 0x3ECCC11 VA: 0x3ECCB10
	|-HashSet<ulong>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EC5EE0 Offset: 0x3EC5FE1 VA: 0x3EC5EE0
	|-HashSet<Action<RenderTargetIdentifier, CommandBuffer>>.Remove
	|-HashSet<AkRoomAwareObject>.Remove
	|-HashSet<GameObject>.Remove
	|-HashSet<IClippable>.Remove
	|-HashSet<MaskableGraphic>.Remove
	|-HashSet<object>.Remove
	|-HashSet<Object>.Remove
	|-HashSet<RTHandle>.Remove
	|-HashSet<string>.Remove
	|-HashSet<Text>.Remove
	|-HashSet<Timer>.Remove
	|-HashSet<ResourceManager.InstanceOperation>.Remove
	|
	|-RVA: 0x3EB4C20 Offset: 0x3EB4D21 VA: 0x3EB4C20
	|-HashSet<ValueTuple<object, int>>.Remove
	|
	|-RVA: 0x3EB8450 Offset: 0x3EB8551 VA: 0x3EB8450
	|-HashSet<AsyncOperationHandle>.Remove
	|
	|-RVA: 0x3EBBD20 Offset: 0x3EBBE21 VA: 0x3EBBD20
	|-HashSet<int>.Remove
	|
	|-RVA: 0x3EBF330 Offset: 0x3EBF431 VA: 0x3EBF330
	|-HashSet<Int32Enum>.Remove
	|
	|-RVA: 0x3EC2930 Offset: 0x3EC2A31 VA: 0x3EC2930
	|-HashSet<MapPos>.Remove
	|
	|-RVA: 0x3EC9530 Offset: 0x3EC9631 VA: 0x3EC9530
	|-HashSet<uint>.Remove
	|
	|-RVA: 0x3ECCB30 Offset: 0x3ECCC31 VA: 0x3ECCB30
	|-HashSet<ulong>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EB4EF0 Offset: 0x3EB4FF1 VA: 0x3EB4EF0
	|-HashSet<ValueTuple<object, int>>.get_Count
	|-HashSet<ValueTuple<string, int>>.get_Count
	|
	|-RVA: 0x3EB8750 Offset: 0x3EB8851 VA: 0x3EB8750
	|-HashSet<AsyncOperationHandle>.get_Count
	|
	|-RVA: 0x3EC6170 Offset: 0x3EC6271 VA: 0x3EC6170
	|-HashSet<IResourceLocation>.get_Count
	|-HashSet<object>.get_Count
	|-HashSet<RTHandle>.get_Count
	|-HashSet<string>.get_Count
	|-HashSet<Text>.get_Count
	|-HashSet<ResourceManager.InstanceOperation>.get_Count
	|
	|-RVA: 0x3EBBFC0 Offset: 0x3EBC0C1 VA: 0x3EBBFC0
	|-HashSet<int>.get_Count
	|
	|-RVA: 0x3EBF5D0 Offset: 0x3EBF6D1 VA: 0x3EBF5D0
	|-HashSet<Int32Enum>.get_Count
	|
	|-RVA: 0x3EC2BA0 Offset: 0x3EC2CA1 VA: 0x3EC2BA0
	|-HashSet<MapPos>.get_Count
	|
	|-RVA: 0x3EC97D0 Offset: 0x3EC98D1 VA: 0x3EC97D0
	|-HashSet<uint>.get_Count
	|
	|-RVA: 0x3ECCDA0 Offset: 0x3ECCEA1 VA: 0x3ECCDA0
	|-HashSet<ulong>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EB4F00 Offset: 0x3EB5001 VA: 0x3EB4F00
	|-HashSet<ValueTuple<object, int>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3EB8760 Offset: 0x3EB8861 VA: 0x3EB8760
	|-HashSet<AsyncOperationHandle>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3EBBFD0 Offset: 0x3EBC0D1 VA: 0x3EBBFD0
	|-HashSet<int>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3EBF5E0 Offset: 0x3EBF6E1 VA: 0x3EBF5E0
	|-HashSet<Int32Enum>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3EC2BB0 Offset: 0x3EC2CB1 VA: 0x3EC2BB0
	|-HashSet<MapPos>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3EC6180 Offset: 0x3EC6281 VA: 0x3EC6180
	|-HashSet<object>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3EC97E0 Offset: 0x3EC98E1 VA: 0x3EC97E0
	|-HashSet<uint>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x3ECCDB0 Offset: 0x3ECCEB1 VA: 0x3ECCDB0
	|-HashSet<ulong>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1
	public HashSet.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EC6190 Offset: 0x3EC6291 VA: 0x3EC6190
	|-HashSet<Action<RenderTargetIdentifier, CommandBuffer>>.GetEnumerator
	|-HashSet<AkRoomAwareObject>.GetEnumerator
	|-HashSet<IClippable>.GetEnumerator
	|-HashSet<LabelScopeInfo>.GetEnumerator
	|-HashSet<MaskableGraphic>.GetEnumerator
	|-HashSet<object>.GetEnumerator
	|-HashSet<Object>.GetEnumerator
	|-HashSet<ParameterExpression>.GetEnumerator
	|-HashSet<RTHandle>.GetEnumerator
	|-HashSet<string>.GetEnumerator
	|-HashSet<Text>.GetEnumerator
	|-HashSet<ResourceManager.InstanceOperation>.GetEnumerator
	|
	|-RVA: 0x3EB4F10 Offset: 0x3EB5011 VA: 0x3EB4F10
	|-HashSet<ValueTuple<object, int>>.GetEnumerator
	|-HashSet<ValueTuple<string, int>>.GetEnumerator
	|
	|-RVA: 0x3EB8770 Offset: 0x3EB8871 VA: 0x3EB8770
	|-HashSet<AsyncOperationHandle>.GetEnumerator
	|
	|-RVA: 0x3EBBFE0 Offset: 0x3EBC0E1 VA: 0x3EBBFE0
	|-HashSet<int>.GetEnumerator
	|
	|-RVA: 0x3EBF5F0 Offset: 0x3EBF6F1 VA: 0x3EBF5F0
	|-HashSet<Int32Enum>.GetEnumerator
	|-HashSet<ItemData.Kinds>.GetEnumerator
	|
	|-RVA: 0x3EC2BC0 Offset: 0x3EC2CC1 VA: 0x3EC2BC0
	|-HashSet<MapPos>.GetEnumerator
	|
	|-RVA: 0x3EC97F0 Offset: 0x3EC98F1 VA: 0x3EC97F0
	|-HashSet<uint>.GetEnumerator
	|
	|-RVA: 0x3ECCDC0 Offset: 0x3ECCEC1 VA: 0x3ECCDC0
	|-HashSet<ulong>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EB4F70 Offset: 0x3EB5071 VA: 0x3EB4F70
	|-HashSet<ValueTuple<object, int>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3EB87E0 Offset: 0x3EB88E1 VA: 0x3EB87E0
	|-HashSet<AsyncOperationHandle>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3EBC040 Offset: 0x3EBC141 VA: 0x3EBC040
	|-HashSet<int>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3EBF650 Offset: 0x3EBF751 VA: 0x3EBF650
	|-HashSet<Int32Enum>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3EC2C20 Offset: 0x3EC2D21 VA: 0x3EC2C20
	|-HashSet<MapPos>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3EC61F0 Offset: 0x3EC62F1 VA: 0x3EC61F0
	|-HashSet<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3EC9850 Offset: 0x3EC9951 VA: 0x3EC9850
	|-HashSet<uint>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3ECCE20 Offset: 0x3ECCF21 VA: 0x3ECCE20
	|-HashSet<ulong>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EB4FF0 Offset: 0x3EB50F1 VA: 0x3EB4FF0
	|-HashSet<ValueTuple<object, int>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3EB8870 Offset: 0x3EB8971 VA: 0x3EB8870
	|-HashSet<AsyncOperationHandle>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3EBC0C0 Offset: 0x3EBC1C1 VA: 0x3EBC0C0
	|-HashSet<int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3EBF6D0 Offset: 0x3EBF7D1 VA: 0x3EBF6D0
	|-HashSet<Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3EC2CA0 Offset: 0x3EC2DA1 VA: 0x3EC2CA0
	|-HashSet<MapPos>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3EC6270 Offset: 0x3EC6371 VA: 0x3EC6270
	|-HashSet<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3EC98D0 Offset: 0x3EC99D1 VA: 0x3EC98D0
	|-HashSet<uint>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3ECCEA0 Offset: 0x3ECCFA1 VA: 0x3ECCEA0
	|-HashSet<ulong>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EB5070 Offset: 0x3EB5171 VA: 0x3EB5070
	|-HashSet<ValueTuple<object, int>>.GetObjectData
	|
	|-RVA: 0x3EB8900 Offset: 0x3EB8A01 VA: 0x3EB8900
	|-HashSet<AsyncOperationHandle>.GetObjectData
	|
	|-RVA: 0x3EBC140 Offset: 0x3EBC241 VA: 0x3EBC140
	|-HashSet<int>.GetObjectData
	|
	|-RVA: 0x3EBF750 Offset: 0x3EBF851 VA: 0x3EBF750
	|-HashSet<Int32Enum>.GetObjectData
	|
	|-RVA: 0x3EC2D20 Offset: 0x3EC2E21 VA: 0x3EC2D20
	|-HashSet<MapPos>.GetObjectData
	|
	|-RVA: 0x3EC62F0 Offset: 0x3EC63F1 VA: 0x3EC62F0
	|-HashSet<object>.GetObjectData
	|
	|-RVA: 0x3EC9950 Offset: 0x3EC9A51 VA: 0x3EC9950
	|-HashSet<uint>.GetObjectData
	|
	|-RVA: 0x3ECCF20 Offset: 0x3ECD021 VA: 0x3ECCF20
	|-HashSet<ulong>.GetObjectData
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public virtual void OnDeserialization(object sender) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EB52B0 Offset: 0x3EB53B1 VA: 0x3EB52B0
	|-HashSet<ValueTuple<object, int>>.OnDeserialization
	|
	|-RVA: 0x3EB8B40 Offset: 0x3EB8C41 VA: 0x3EB8B40
	|-HashSet<AsyncOperationHandle>.OnDeserialization
	|
	|-RVA: 0x3EBC380 Offset: 0x3EBC481 VA: 0x3EBC380
	|-HashSet<int>.OnDeserialization
	|
	|-RVA: 0x3EBF990 Offset: 0x3EBFA91 VA: 0x3EBF990
	|-HashSet<Int32Enum>.OnDeserialization
	|
	|-RVA: 0x3EC2F60 Offset: 0x3EC3061 VA: 0x3EC2F60
	|-HashSet<MapPos>.OnDeserialization
	|
	|-RVA: 0x3EC6530 Offset: 0x3EC6631 VA: 0x3EC6530
	|-HashSet<object>.OnDeserialization
	|
	|-RVA: 0x3EC9B90 Offset: 0x3EC9C91 VA: 0x3EC9B90
	|-HashSet<uint>.OnDeserialization
	|
	|-RVA: 0x3ECD160 Offset: 0x3ECD261 VA: 0x3ECD160
	|-HashSet<ulong>.OnDeserialization
	*/

	// RVA: -1 Offset: -1 Slot: 18
	public bool Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EC6890 Offset: 0x3EC6991 VA: 0x3EC6890
	|-HashSet<Action<RenderTargetIdentifier, CommandBuffer>>.Add
	|-HashSet<AkRoomAwareObject>.Add
	|-HashSet<GameObject>.Add
	|-HashSet<IClippable>.Add
	|-HashSet<IResourceLocation>.Add
	|-HashSet<LabelScopeInfo>.Add
	|-HashSet<MaskableGraphic>.Add
	|-HashSet<object>.Add
	|-HashSet<Object>.Add
	|-HashSet<ParameterExpression>.Add
	|-HashSet<RTHandle>.Add
	|-HashSet<string>.Add
	|-HashSet<Text>.Add
	|-HashSet<Timer>.Add
	|-HashSet<Transform>.Add
	|-HashSet<Type>.Add
	|-HashSet<ResourceManager.InstanceOperation>.Add
	|
	|-RVA: 0x3EB5610 Offset: 0x3EB5711 VA: 0x3EB5610
	|-HashSet<ValueTuple<object, int>>.Add
	|-HashSet<ValueTuple<string, int>>.Add
	|
	|-RVA: 0x3EB8EB0 Offset: 0x3EB8FB1 VA: 0x3EB8EB0
	|-HashSet<AsyncOperationHandle>.Add
	|
	|-RVA: 0x3EBC6E0 Offset: 0x3EBC7E1 VA: 0x3EBC6E0
	|-HashSet<int>.Add
	|
	|-RVA: 0x3EBFCF0 Offset: 0x3EBFDF1 VA: 0x3EBFCF0
	|-HashSet<Int32Enum>.Add
	|-HashSet<ItemData.Kinds>.Add
	|
	|-RVA: 0x3EC32C0 Offset: 0x3EC33C1 VA: 0x3EC32C0
	|-HashSet<MapPos>.Add
	|
	|-RVA: 0x3EC9EF0 Offset: 0x3EC9FF1 VA: 0x3EC9EF0
	|-HashSet<uint>.Add
	|
	|-RVA: 0x3ECD4C0 Offset: 0x3ECD5C1 VA: 0x3ECD4C0
	|-HashSet<ulong>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public void UnionWith(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EB5630 Offset: 0x3EB5731 VA: 0x3EB5630
	|-HashSet<ValueTuple<object, int>>.UnionWith
	|
	|-RVA: 0x3EB8F00 Offset: 0x3EB9001 VA: 0x3EB8F00
	|-HashSet<AsyncOperationHandle>.UnionWith
	|
	|-RVA: 0x3EC68B0 Offset: 0x3EC69B1 VA: 0x3EC68B0
	|-HashSet<IResourceLocation>.UnionWith
	|-HashSet<object>.UnionWith
	|
	|-RVA: 0x3EBC700 Offset: 0x3EBC801 VA: 0x3EBC700
	|-HashSet<int>.UnionWith
	|
	|-RVA: 0x3EBFD10 Offset: 0x3EBFE11 VA: 0x3EBFD10
	|-HashSet<Int32Enum>.UnionWith
	|
	|-RVA: 0x3EC32E0 Offset: 0x3EC33E1 VA: 0x3EC32E0
	|-HashSet<MapPos>.UnionWith
	|
	|-RVA: 0x3EC9F10 Offset: 0x3ECA011 VA: 0x3EC9F10
	|-HashSet<uint>.UnionWith
	|
	|-RVA: 0x3ECD4E0 Offset: 0x3ECD5E1 VA: 0x3ECD4E0
	|-HashSet<ulong>.UnionWith
	*/

	// RVA: -1 Offset: -1 Slot: 20
	public void IntersectWith(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EB5940 Offset: 0x3EB5A41 VA: 0x3EB5940
	|-HashSet<ValueTuple<object, int>>.IntersectWith
	|
	|-RVA: 0x3EB9220 Offset: 0x3EB9321 VA: 0x3EB9220
	|-HashSet<AsyncOperationHandle>.IntersectWith
	|
	|-RVA: 0x3EC6BB0 Offset: 0x3EC6CB1 VA: 0x3EC6BB0
	|-HashSet<IResourceLocation>.IntersectWith
	|-HashSet<object>.IntersectWith
	|
	|-RVA: 0x3EBCA00 Offset: 0x3EBCB01 VA: 0x3EBCA00
	|-HashSet<int>.IntersectWith
	|
	|-RVA: 0x3EC0010 Offset: 0x3EC0111 VA: 0x3EC0010
	|-HashSet<Int32Enum>.IntersectWith
	|
	|-RVA: 0x3EC35E0 Offset: 0x3EC36E1 VA: 0x3EC35E0
	|-HashSet<MapPos>.IntersectWith
	|
	|-RVA: 0x3ECA210 Offset: 0x3ECA311 VA: 0x3ECA210
	|-HashSet<uint>.IntersectWith
	|
	|-RVA: 0x3ECD7E0 Offset: 0x3ECD8E1 VA: 0x3ECD7E0
	|-HashSet<ulong>.IntersectWith
	*/

	// RVA: -1 Offset: -1 Slot: 21
	public bool SetEquals(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EB5B30 Offset: 0x3EB5C31 VA: 0x3EB5B30
	|-HashSet<ValueTuple<object, int>>.SetEquals
	|
	|-RVA: 0x3EB9410 Offset: 0x3EB9511 VA: 0x3EB9410
	|-HashSet<AsyncOperationHandle>.SetEquals
	|
	|-RVA: 0x3EBCBF0 Offset: 0x3EBCCF1 VA: 0x3EBCBF0
	|-HashSet<int>.SetEquals
	|
	|-RVA: 0x3EC0200 Offset: 0x3EC0301 VA: 0x3EC0200
	|-HashSet<Int32Enum>.SetEquals
	|
	|-RVA: 0x3EC37D0 Offset: 0x3EC38D1 VA: 0x3EC37D0
	|-HashSet<MapPos>.SetEquals
	|
	|-RVA: 0x3EC6DA0 Offset: 0x3EC6EA1 VA: 0x3EC6DA0
	|-HashSet<object>.SetEquals
	|
	|-RVA: 0x3ECA400 Offset: 0x3ECA501 VA: 0x3ECA400
	|-HashSet<uint>.SetEquals
	|
	|-RVA: 0x3ECD9D0 Offset: 0x3ECDAD1 VA: 0x3ECD9D0
	|-HashSet<ulong>.SetEquals
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EB5D60 Offset: 0x3EB5E61 VA: 0x3EB5D60
	|-HashSet<ValueTuple<object, int>>.CopyTo
	|
	|-RVA: 0x3EB9640 Offset: 0x3EB9741 VA: 0x3EB9640
	|-HashSet<AsyncOperationHandle>.CopyTo
	|
	|-RVA: 0x3EBCE20 Offset: 0x3EBCF21 VA: 0x3EBCE20
	|-HashSet<int>.CopyTo
	|
	|-RVA: 0x3EC0430 Offset: 0x3EC0531 VA: 0x3EC0430
	|-HashSet<Int32Enum>.CopyTo
	|
	|-RVA: 0x3EC3A00 Offset: 0x3EC3B01 VA: 0x3EC3A00
	|-HashSet<MapPos>.CopyTo
	|
	|-RVA: 0x3EC6FD0 Offset: 0x3EC70D1 VA: 0x3EC6FD0
	|-HashSet<object>.CopyTo
	|-HashSet<RTHandle>.CopyTo
	|
	|-RVA: 0x3ECA630 Offset: 0x3ECA731 VA: 0x3ECA630
	|-HashSet<uint>.CopyTo
	|
	|-RVA: 0x3ECDC00 Offset: 0x3ECDD01 VA: 0x3ECDC00
	|-HashSet<ulong>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(T[] array, int arrayIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EB5D80 Offset: 0x3EB5E81 VA: 0x3EB5D80
	|-HashSet<ValueTuple<object, int>>.CopyTo
	|
	|-RVA: 0x3EB9660 Offset: 0x3EB9761 VA: 0x3EB9660
	|-HashSet<AsyncOperationHandle>.CopyTo
	|
	|-RVA: 0x3EBCE40 Offset: 0x3EBCF41 VA: 0x3EBCE40
	|-HashSet<int>.CopyTo
	|
	|-RVA: 0x3EC0450 Offset: 0x3EC0551 VA: 0x3EC0450
	|-HashSet<Int32Enum>.CopyTo
	|
	|-RVA: 0x3EC3A20 Offset: 0x3EC3B21 VA: 0x3EC3A20
	|-HashSet<MapPos>.CopyTo
	|
	|-RVA: 0x3EC6FF0 Offset: 0x3EC70F1 VA: 0x3EC6FF0
	|-HashSet<object>.CopyTo
	|
	|-RVA: 0x3ECA650 Offset: 0x3ECA751 VA: 0x3ECA650
	|-HashSet<uint>.CopyTo
	|
	|-RVA: 0x3ECDC20 Offset: 0x3ECDD21 VA: 0x3ECDC20
	|-HashSet<ulong>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public IEqualityComparer<T> get_Comparer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EB5FB0 Offset: 0x3EB60B1 VA: 0x3EB5FB0
	|-HashSet<ValueTuple<object, int>>.get_Comparer
	|
	|-RVA: 0x3EB98B0 Offset: 0x3EB99B1 VA: 0x3EB98B0
	|-HashSet<AsyncOperationHandle>.get_Comparer
	|
	|-RVA: 0x3EBD040 Offset: 0x3EBD141 VA: 0x3EBD040
	|-HashSet<int>.get_Comparer
	|
	|-RVA: 0x3EC0650 Offset: 0x3EC0751 VA: 0x3EC0650
	|-HashSet<Int32Enum>.get_Comparer
	|
	|-RVA: 0x3EC3C20 Offset: 0x3EC3D21 VA: 0x3EC3C20
	|-HashSet<MapPos>.get_Comparer
	|
	|-RVA: 0x3EC7210 Offset: 0x3EC7311 VA: 0x3EC7210
	|-HashSet<object>.get_Comparer
	|
	|-RVA: 0x3ECA850 Offset: 0x3ECA951 VA: 0x3ECA850
	|-HashSet<uint>.get_Comparer
	|
	|-RVA: 0x3ECDE20 Offset: 0x3ECDF21 VA: 0x3ECDE20
	|-HashSet<ulong>.get_Comparer
	*/

	// RVA: -1 Offset: -1
	public void TrimExcess() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EB5FC0 Offset: 0x3EB60C1 VA: 0x3EB5FC0
	|-HashSet<ValueTuple<object, int>>.TrimExcess
	|
	|-RVA: 0x3EB98C0 Offset: 0x3EB99C1 VA: 0x3EB98C0
	|-HashSet<AsyncOperationHandle>.TrimExcess
	|
	|-RVA: 0x3EBD050 Offset: 0x3EBD151 VA: 0x3EBD050
	|-HashSet<int>.TrimExcess
	|
	|-RVA: 0x3EC0660 Offset: 0x3EC0761 VA: 0x3EC0660
	|-HashSet<Int32Enum>.TrimExcess
	|
	|-RVA: 0x3EC3C30 Offset: 0x3EC3D31 VA: 0x3EC3C30
	|-HashSet<MapPos>.TrimExcess
	|
	|-RVA: 0x3EC7220 Offset: 0x3EC7321 VA: 0x3EC7220
	|-HashSet<object>.TrimExcess
	|
	|-RVA: 0x3ECA860 Offset: 0x3ECA961 VA: 0x3ECA860
	|-HashSet<uint>.TrimExcess
	|
	|-RVA: 0x3ECDE30 Offset: 0x3ECDF31 VA: 0x3ECDE30
	|-HashSet<ulong>.TrimExcess
	*/

	// RVA: -1 Offset: -1
	private void Initialize(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EB6200 Offset: 0x3EB6301 VA: 0x3EB6200
	|-HashSet<ValueTuple<object, int>>.Initialize
	|
	|-RVA: 0x3EB9B00 Offset: 0x3EB9C01 VA: 0x3EB9B00
	|-HashSet<AsyncOperationHandle>.Initialize
	|
	|-RVA: 0x3EBD260 Offset: 0x3EBD361 VA: 0x3EBD260
	|-HashSet<int>.Initialize
	|
	|-RVA: 0x3EC0870 Offset: 0x3EC0971 VA: 0x3EC0870
	|-HashSet<Int32Enum>.Initialize
	|
	|-RVA: 0x3EC3E30 Offset: 0x3EC3F31 VA: 0x3EC3E30
	|-HashSet<MapPos>.Initialize
	|
	|-RVA: 0x3EC7440 Offset: 0x3EC7541 VA: 0x3EC7440
	|-HashSet<object>.Initialize
	|
	|-RVA: 0x3ECAA70 Offset: 0x3ECAB71 VA: 0x3ECAA70
	|-HashSet<uint>.Initialize
	|
	|-RVA: 0x3ECE030 Offset: 0x3ECE131 VA: 0x3ECE030
	|-HashSet<ulong>.Initialize
	*/

	// RVA: -1 Offset: -1
	private void IncreaseCapacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EB62F0 Offset: 0x3EB63F1 VA: 0x3EB62F0
	|-HashSet<ValueTuple<object, int>>.IncreaseCapacity
	|
	|-RVA: 0x3EB9BF0 Offset: 0x3EB9CF1 VA: 0x3EB9BF0
	|-HashSet<AsyncOperationHandle>.IncreaseCapacity
	|
	|-RVA: 0x3EBD350 Offset: 0x3EBD451 VA: 0x3EBD350
	|-HashSet<int>.IncreaseCapacity
	|
	|-RVA: 0x3EC0960 Offset: 0x3EC0A61 VA: 0x3EC0960
	|-HashSet<Int32Enum>.IncreaseCapacity
	|
	|-RVA: 0x3EC3F20 Offset: 0x3EC4021 VA: 0x3EC3F20
	|-HashSet<MapPos>.IncreaseCapacity
	|
	|-RVA: 0x3EC7530 Offset: 0x3EC7631 VA: 0x3EC7530
	|-HashSet<object>.IncreaseCapacity
	|
	|-RVA: 0x3ECAB60 Offset: 0x3ECAC61 VA: 0x3ECAB60
	|-HashSet<uint>.IncreaseCapacity
	|
	|-RVA: 0x3ECE120 Offset: 0x3ECE221 VA: 0x3ECE120
	|-HashSet<ulong>.IncreaseCapacity
	*/

	// RVA: -1 Offset: -1
	private void SetCapacity(int newSize) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EB63E0 Offset: 0x3EB64E1 VA: 0x3EB63E0
	|-HashSet<ValueTuple<object, int>>.SetCapacity
	|
	|-RVA: 0x3EB9CE0 Offset: 0x3EB9DE1 VA: 0x3EB9CE0
	|-HashSet<AsyncOperationHandle>.SetCapacity
	|
	|-RVA: 0x3EBD440 Offset: 0x3EBD541 VA: 0x3EBD440
	|-HashSet<int>.SetCapacity
	|
	|-RVA: 0x3EC0A50 Offset: 0x3EC0B51 VA: 0x3EC0A50
	|-HashSet<Int32Enum>.SetCapacity
	|
	|-RVA: 0x3EC4010 Offset: 0x3EC4111 VA: 0x3EC4010
	|-HashSet<MapPos>.SetCapacity
	|
	|-RVA: 0x3EC7620 Offset: 0x3EC7721 VA: 0x3EC7620
	|-HashSet<object>.SetCapacity
	|
	|-RVA: 0x3ECAC50 Offset: 0x3ECAD51 VA: 0x3ECAC50
	|-HashSet<uint>.SetCapacity
	|
	|-RVA: 0x3ECE210 Offset: 0x3ECE311 VA: 0x3ECE210
	|-HashSet<ulong>.SetCapacity
	*/

	// RVA: -1 Offset: -1
	private bool AddIfNotPresent(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EB6530 Offset: 0x3EB6631 VA: 0x3EB6530
	|-HashSet<ValueTuple<object, int>>.AddIfNotPresent
	|
	|-RVA: 0x3EB9E30 Offset: 0x3EB9F31 VA: 0x3EB9E30
	|-HashSet<AsyncOperationHandle>.AddIfNotPresent
	|
	|-RVA: 0x3EBD590 Offset: 0x3EBD691 VA: 0x3EBD590
	|-HashSet<int>.AddIfNotPresent
	|
	|-RVA: 0x3EC0BA0 Offset: 0x3EC0CA1 VA: 0x3EC0BA0
	|-HashSet<Int32Enum>.AddIfNotPresent
	|
	|-RVA: 0x3EC4160 Offset: 0x3EC4261 VA: 0x3EC4160
	|-HashSet<MapPos>.AddIfNotPresent
	|
	|-RVA: 0x3EC7770 Offset: 0x3EC7871 VA: 0x3EC7770
	|-HashSet<object>.AddIfNotPresent
	|
	|-RVA: 0x3ECADA0 Offset: 0x3ECAEA1 VA: 0x3ECADA0
	|-HashSet<uint>.AddIfNotPresent
	|
	|-RVA: 0x3ECE360 Offset: 0x3ECE461 VA: 0x3ECE360
	|-HashSet<ulong>.AddIfNotPresent
	*/

	// RVA: -1 Offset: -1
	private void AddValue(int index, int hashCode, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EB6840 Offset: 0x3EB6941 VA: 0x3EB6840
	|-HashSet<ValueTuple<object, int>>.AddValue
	|
	|-RVA: 0x3EBA180 Offset: 0x3EBA281 VA: 0x3EBA180
	|-HashSet<AsyncOperationHandle>.AddValue
	|
	|-RVA: 0x3EBD850 Offset: 0x3EBD951 VA: 0x3EBD850
	|-HashSet<int>.AddValue
	|
	|-RVA: 0x3EC0E60 Offset: 0x3EC0F61 VA: 0x3EC0E60
	|-HashSet<Int32Enum>.AddValue
	|
	|-RVA: 0x3EC4410 Offset: 0x3EC4511 VA: 0x3EC4410
	|-HashSet<MapPos>.AddValue
	|
	|-RVA: 0x3EC7A20 Offset: 0x3EC7B21 VA: 0x3EC7A20
	|-HashSet<object>.AddValue
	|
	|-RVA: 0x3ECB060 Offset: 0x3ECB161 VA: 0x3ECB060
	|-HashSet<uint>.AddValue
	|
	|-RVA: 0x3ECE610 Offset: 0x3ECE711 VA: 0x3ECE610
	|-HashSet<ulong>.AddValue
	*/

	// RVA: -1 Offset: -1
	private bool ContainsAllElements(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EB6930 Offset: 0x3EB6A31 VA: 0x3EB6930
	|-HashSet<ValueTuple<object, int>>.ContainsAllElements
	|
	|-RVA: 0x3EBA280 Offset: 0x3EBA381 VA: 0x3EBA280
	|-HashSet<AsyncOperationHandle>.ContainsAllElements
	|
	|-RVA: 0x3EBD910 Offset: 0x3EBDA11 VA: 0x3EBD910
	|-HashSet<int>.ContainsAllElements
	|
	|-RVA: 0x3EC0F20 Offset: 0x3EC1021 VA: 0x3EC0F20
	|-HashSet<Int32Enum>.ContainsAllElements
	|
	|-RVA: 0x3EC44D0 Offset: 0x3EC45D1 VA: 0x3EC44D0
	|-HashSet<MapPos>.ContainsAllElements
	|
	|-RVA: 0x3EC7B00 Offset: 0x3EC7C01 VA: 0x3EC7B00
	|-HashSet<object>.ContainsAllElements
	|
	|-RVA: 0x3ECB120 Offset: 0x3ECB221 VA: 0x3ECB120
	|-HashSet<uint>.ContainsAllElements
	|
	|-RVA: 0x3ECE6D0 Offset: 0x3ECE7D1 VA: 0x3ECE6D0
	|-HashSet<ulong>.ContainsAllElements
	*/

	// RVA: -1 Offset: -1
	private void IntersectWithHashSetWithSameEC(HashSet<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EB6C20 Offset: 0x3EB6D21 VA: 0x3EB6C20
	|-HashSet<ValueTuple<object, int>>.IntersectWithHashSetWithSameEC
	|
	|-RVA: 0x3EBA590 Offset: 0x3EBA691 VA: 0x3EBA590
	|-HashSet<AsyncOperationHandle>.IntersectWithHashSetWithSameEC
	|
	|-RVA: 0x3EBDBF0 Offset: 0x3EBDCF1 VA: 0x3EBDBF0
	|-HashSet<int>.IntersectWithHashSetWithSameEC
	|
	|-RVA: 0x3EC1200 Offset: 0x3EC1301 VA: 0x3EC1200
	|-HashSet<Int32Enum>.IntersectWithHashSetWithSameEC
	|
	|-RVA: 0x3EC47B0 Offset: 0x3EC48B1 VA: 0x3EC47B0
	|-HashSet<MapPos>.IntersectWithHashSetWithSameEC
	|
	|-RVA: 0x3EC7DE0 Offset: 0x3EC7EE1 VA: 0x3EC7DE0
	|-HashSet<object>.IntersectWithHashSetWithSameEC
	|
	|-RVA: 0x3ECB400 Offset: 0x3ECB501 VA: 0x3ECB400
	|-HashSet<uint>.IntersectWithHashSetWithSameEC
	|
	|-RVA: 0x3ECE9B0 Offset: 0x3ECEAB1 VA: 0x3ECE9B0
	|-HashSet<ulong>.IntersectWithHashSetWithSameEC
	*/

	// RVA: -1 Offset: -1
	private void IntersectWithEnumerable(IEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EB6D00 Offset: 0x3EB6E01 VA: 0x3EB6D00
	|-HashSet<ValueTuple<object, int>>.IntersectWithEnumerable
	|
	|-RVA: 0x3EBA6B0 Offset: 0x3EBA7B1 VA: 0x3EBA6B0
	|-HashSet<AsyncOperationHandle>.IntersectWithEnumerable
	|
	|-RVA: 0x3EBDCC0 Offset: 0x3EBDDC1 VA: 0x3EBDCC0
	|-HashSet<int>.IntersectWithEnumerable
	|
	|-RVA: 0x3EC12D0 Offset: 0x3EC13D1 VA: 0x3EC12D0
	|-HashSet<Int32Enum>.IntersectWithEnumerable
	|
	|-RVA: 0x3EC4880 Offset: 0x3EC4981 VA: 0x3EC4880
	|-HashSet<MapPos>.IntersectWithEnumerable
	|
	|-RVA: 0x3EC7EB0 Offset: 0x3EC7FB1 VA: 0x3EC7EB0
	|-HashSet<object>.IntersectWithEnumerable
	|
	|-RVA: 0x3ECB4D0 Offset: 0x3ECB5D1 VA: 0x3ECB4D0
	|-HashSet<uint>.IntersectWithEnumerable
	|
	|-RVA: 0x3ECEA80 Offset: 0x3ECEB81 VA: 0x3ECEA80
	|-HashSet<ulong>.IntersectWithEnumerable
	*/

	// RVA: -1 Offset: -1
	private int InternalIndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EB7130 Offset: 0x3EB7231 VA: 0x3EB7130
	|-HashSet<ValueTuple<object, int>>.InternalIndexOf
	|
	|-RVA: 0x3EBAB20 Offset: 0x3EBAC21 VA: 0x3EBAB20
	|-HashSet<AsyncOperationHandle>.InternalIndexOf
	|
	|-RVA: 0x3EBE0F0 Offset: 0x3EBE1F1 VA: 0x3EBE0F0
	|-HashSet<int>.InternalIndexOf
	|
	|-RVA: 0x3EC1700 Offset: 0x3EC1801 VA: 0x3EC1700
	|-HashSet<Int32Enum>.InternalIndexOf
	|
	|-RVA: 0x3EC4CB0 Offset: 0x3EC4DB1 VA: 0x3EC4CB0
	|-HashSet<MapPos>.InternalIndexOf
	|
	|-RVA: 0x3EC82E0 Offset: 0x3EC83E1 VA: 0x3EC82E0
	|-HashSet<object>.InternalIndexOf
	|
	|-RVA: 0x3ECB900 Offset: 0x3ECBA01 VA: 0x3ECB900
	|-HashSet<uint>.InternalIndexOf
	|
	|-RVA: 0x3ECEEB0 Offset: 0x3ECEFB1 VA: 0x3ECEEB0
	|-HashSet<ulong>.InternalIndexOf
	*/

	// RVA: -1 Offset: -1
	private HashSet.ElementCount<T> CheckUniqueAndUnfoundElements(IEnumerable<T> other, bool returnIfUnfound) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EB72B0 Offset: 0x3EB73B1 VA: 0x3EB72B0
	|-HashSet<ValueTuple<object, int>>.CheckUniqueAndUnfoundElements
	|
	|-RVA: 0x3EBAD20 Offset: 0x3EBAE21 VA: 0x3EBAD20
	|-HashSet<AsyncOperationHandle>.CheckUniqueAndUnfoundElements
	|
	|-RVA: 0x3EBE260 Offset: 0x3EBE361 VA: 0x3EBE260
	|-HashSet<int>.CheckUniqueAndUnfoundElements
	|
	|-RVA: 0x3EC1870 Offset: 0x3EC1971 VA: 0x3EC1870
	|-HashSet<Int32Enum>.CheckUniqueAndUnfoundElements
	|
	|-RVA: 0x3EC4E20 Offset: 0x3EC4F21 VA: 0x3EC4E20
	|-HashSet<MapPos>.CheckUniqueAndUnfoundElements
	|
	|-RVA: 0x3EC8450 Offset: 0x3EC8551 VA: 0x3EC8450
	|-HashSet<object>.CheckUniqueAndUnfoundElements
	|
	|-RVA: 0x3ECBA70 Offset: 0x3ECBB71 VA: 0x3ECBA70
	|-HashSet<uint>.CheckUniqueAndUnfoundElements
	|
	|-RVA: 0x3ECF020 Offset: 0x3ECF121 VA: 0x3ECF020
	|-HashSet<ulong>.CheckUniqueAndUnfoundElements
	*/

	// RVA: -1 Offset: -1
	private static bool AreEqualityComparersEqual(HashSet<T> set1, HashSet<T> set2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EB7A10 Offset: 0x3EB7B11 VA: 0x3EB7A10
	|-HashSet<ValueTuple<object, int>>.AreEqualityComparersEqual
	|
	|-RVA: 0x3EBB370 Offset: 0x3EBB471 VA: 0x3EBB370
	|-HashSet<AsyncOperationHandle>.AreEqualityComparersEqual
	|
	|-RVA: 0x3EBE9B0 Offset: 0x3EBEAB1 VA: 0x3EBE9B0
	|-HashSet<int>.AreEqualityComparersEqual
	|
	|-RVA: 0x3EC1FC0 Offset: 0x3EC20C1 VA: 0x3EC1FC0
	|-HashSet<Int32Enum>.AreEqualityComparersEqual
	|
	|-RVA: 0x3EC5570 Offset: 0x3EC5671 VA: 0x3EC5570
	|-HashSet<MapPos>.AreEqualityComparersEqual
	|
	|-RVA: 0x3EC8BA0 Offset: 0x3EC8CA1 VA: 0x3EC8BA0
	|-HashSet<object>.AreEqualityComparersEqual
	|
	|-RVA: 0x3ECC1C0 Offset: 0x3ECC2C1 VA: 0x3ECC1C0
	|-HashSet<uint>.AreEqualityComparersEqual
	|
	|-RVA: 0x3ECF770 Offset: 0x3ECF871 VA: 0x3ECF770
	|-HashSet<ulong>.AreEqualityComparersEqual
	*/

	// RVA: -1 Offset: -1
	private int InternalGetHashCode(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EB7AF0 Offset: 0x3EB7BF1 VA: 0x3EB7AF0
	|-HashSet<ValueTuple<object, int>>.InternalGetHashCode
	|
	|-RVA: 0x3EBB450 Offset: 0x3EBB551 VA: 0x3EBB450
	|-HashSet<AsyncOperationHandle>.InternalGetHashCode
	|
	|-RVA: 0x3EBEA90 Offset: 0x3EBEB91 VA: 0x3EBEA90
	|-HashSet<int>.InternalGetHashCode
	|
	|-RVA: 0x3EC20A0 Offset: 0x3EC21A1 VA: 0x3EC20A0
	|-HashSet<Int32Enum>.InternalGetHashCode
	|
	|-RVA: 0x3EC5650 Offset: 0x3EC5751 VA: 0x3EC5650
	|-HashSet<MapPos>.InternalGetHashCode
	|
	|-RVA: 0x3EC8C80 Offset: 0x3EC8D81 VA: 0x3EC8C80
	|-HashSet<object>.InternalGetHashCode
	|
	|-RVA: 0x3ECC2A0 Offset: 0x3ECC3A1 VA: 0x3ECC2A0
	|-HashSet<uint>.InternalGetHashCode
	|
	|-RVA: 0x3ECF850 Offset: 0x3ECF951 VA: 0x3ECF850
	|-HashSet<ulong>.InternalGetHashCode
	*/
}

