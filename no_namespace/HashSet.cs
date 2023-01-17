// Namespace: 
internal struct HashSet.ElementCount<T> // TypeDefIndex: 3285
{
	// Fields
	internal int uniqueCount; // 0x0
	internal int unfoundCount; // 0x0
}

// Namespace: 
internal struct HashSet.Slot<T> // TypeDefIndex: 3286
{
	// Fields
	internal int hashCode; // 0x0
	internal int next; // 0x0
	internal T value; // 0x0
}

// Namespace: 
[Serializable]
public struct HashSet.Enumerator<T> : IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 3287
{
	// Fields
	private HashSet<T> _set; // 0x0
	private int _index; // 0x0
	private int _version; // 0x0
	private T _current; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(HashSet<T> set) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EAFA20 Offset: 0x2EAFB21 VA: 0x2EAFA20
	|-HashSet.Enumerator<ValueTuple<object, int>>..ctor
	|
	|-RVA: 0x2EB16E0 Offset: 0x2EB17E1 VA: 0x2EB16E0
	|-HashSet.Enumerator<AsyncOperationHandle>..ctor
	|
	|-RVA: 0x2EB5EF0 Offset: 0x2EB5FF1 VA: 0x2EB5EF0
	|-HashSet.Enumerator<int>..ctor
	|
	|-RVA: 0x2EB6BE0 Offset: 0x2EB6CE1 VA: 0x2EB6BE0
	|-HashSet.Enumerator<Int32Enum>..ctor
	|
	|-RVA: 0x2EB86A0 Offset: 0x2EB87A1 VA: 0x2EB86A0
	|-HashSet.Enumerator<MapPos>..ctor
	|
	|-RVA: 0x2EB8F20 Offset: 0x2EB9021 VA: 0x2EB8F20
	|-HashSet.Enumerator<object>..ctor
	|
	|-RVA: 0x2E039B0 Offset: 0x2E03AB1 VA: 0x2E039B0
	|-HashSet.Enumerator<uint>..ctor
	|
	|-RVA: 0x2E04370 Offset: 0x2E04471 VA: 0x2E04370
	|-HashSet.Enumerator<ulong>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EAFA60 Offset: 0x2EAFB61 VA: 0x2EAFA60
	|-HashSet.Enumerator<ValueTuple<object, int>>.Dispose
	|-HashSet.Enumerator<ValueTuple<string, int>>.Dispose
	|
	|-RVA: 0x2EB8F60 Offset: 0x2EB9061 VA: 0x2EB8F60
	|-HashSet.Enumerator<AkRoomAwareObject>.Dispose
	|-HashSet.Enumerator<IClippable>.Dispose
	|-HashSet.Enumerator<LabelScopeInfo>.Dispose
	|-HashSet.Enumerator<MaskableGraphic>.Dispose
	|-HashSet.Enumerator<object>.Dispose
	|-HashSet.Enumerator<Object>.Dispose
	|-HashSet.Enumerator<ParameterExpression>.Dispose
	|-HashSet.Enumerator<RTHandle>.Dispose
	|-HashSet.Enumerator<string>.Dispose
	|-HashSet.Enumerator<Text>.Dispose
	|-HashSet.Enumerator<ResourceManager.InstanceOperation>.Dispose
	|
	|-RVA: 0x2EB1720 Offset: 0x2EB1821 VA: 0x2EB1720
	|-HashSet.Enumerator<AsyncOperationHandle>.Dispose
	|
	|-RVA: 0x2EB5F30 Offset: 0x2EB6031 VA: 0x2EB5F30
	|-HashSet.Enumerator<int>.Dispose
	|
	|-RVA: 0x2EB6C20 Offset: 0x2EB6D21 VA: 0x2EB6C20
	|-HashSet.Enumerator<Int32Enum>.Dispose
	|-HashSet.Enumerator<ItemData.Kinds>.Dispose
	|
	|-RVA: 0x2EB86E0 Offset: 0x2EB87E1 VA: 0x2EB86E0
	|-HashSet.Enumerator<MapPos>.Dispose
	|
	|-RVA: 0x2E039F0 Offset: 0x2E03AF1 VA: 0x2E039F0
	|-HashSet.Enumerator<uint>.Dispose
	|
	|-RVA: 0x2E043B0 Offset: 0x2E044B1 VA: 0x2E043B0
	|-HashSet.Enumerator<ulong>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EAFA70 Offset: 0x2EAFB71 VA: 0x2EAFA70
	|-HashSet.Enumerator<ValueTuple<object, int>>.MoveNext
	|-HashSet.Enumerator<ValueTuple<string, int>>.MoveNext
	|
	|-RVA: 0x2EB8F70 Offset: 0x2EB9071 VA: 0x2EB8F70
	|-HashSet.Enumerator<AkRoomAwareObject>.MoveNext
	|-HashSet.Enumerator<IClippable>.MoveNext
	|-HashSet.Enumerator<LabelScopeInfo>.MoveNext
	|-HashSet.Enumerator<MaskableGraphic>.MoveNext
	|-HashSet.Enumerator<object>.MoveNext
	|-HashSet.Enumerator<Object>.MoveNext
	|-HashSet.Enumerator<ParameterExpression>.MoveNext
	|-HashSet.Enumerator<RTHandle>.MoveNext
	|-HashSet.Enumerator<string>.MoveNext
	|-HashSet.Enumerator<Text>.MoveNext
	|-HashSet.Enumerator<ResourceManager.InstanceOperation>.MoveNext
	|
	|-RVA: 0x2EB1730 Offset: 0x2EB1831 VA: 0x2EB1730
	|-HashSet.Enumerator<AsyncOperationHandle>.MoveNext
	|
	|-RVA: 0x2EB5F40 Offset: 0x2EB6041 VA: 0x2EB5F40
	|-HashSet.Enumerator<int>.MoveNext
	|
	|-RVA: 0x2EB6C30 Offset: 0x2EB6D31 VA: 0x2EB6C30
	|-HashSet.Enumerator<Int32Enum>.MoveNext
	|-HashSet.Enumerator<ItemData.Kinds>.MoveNext
	|
	|-RVA: 0x2EB86F0 Offset: 0x2EB87F1 VA: 0x2EB86F0
	|-HashSet.Enumerator<MapPos>.MoveNext
	|
	|-RVA: 0x2E03A00 Offset: 0x2E03B01 VA: 0x2E03A00
	|-HashSet.Enumerator<uint>.MoveNext
	|
	|-RVA: 0x2E043C0 Offset: 0x2E044C1 VA: 0x2E043C0
	|-HashSet.Enumerator<ulong>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EAFB90 Offset: 0x2EAFC91 VA: 0x2EAFB90
	|-HashSet.Enumerator<ValueTuple<object, int>>.get_Current
	|-HashSet.Enumerator<ValueTuple<string, int>>.get_Current
	|
	|-RVA: 0x2EB9080 Offset: 0x2EB9181 VA: 0x2EB9080
	|-HashSet.Enumerator<AkRoomAwareObject>.get_Current
	|-HashSet.Enumerator<IClippable>.get_Current
	|-HashSet.Enumerator<LabelScopeInfo>.get_Current
	|-HashSet.Enumerator<MaskableGraphic>.get_Current
	|-HashSet.Enumerator<object>.get_Current
	|-HashSet.Enumerator<Object>.get_Current
	|-HashSet.Enumerator<ParameterExpression>.get_Current
	|-HashSet.Enumerator<RTHandle>.get_Current
	|-HashSet.Enumerator<string>.get_Current
	|-HashSet.Enumerator<Text>.get_Current
	|-HashSet.Enumerator<ResourceManager.InstanceOperation>.get_Current
	|
	|-RVA: 0x2EB1850 Offset: 0x2EB1951 VA: 0x2EB1850
	|-HashSet.Enumerator<AsyncOperationHandle>.get_Current
	|
	|-RVA: 0x2EB6050 Offset: 0x2EB6151 VA: 0x2EB6050
	|-HashSet.Enumerator<int>.get_Current
	|
	|-RVA: 0x2EB6D40 Offset: 0x2EB6E41 VA: 0x2EB6D40
	|-HashSet.Enumerator<Int32Enum>.get_Current
	|-HashSet.Enumerator<ItemData.Kinds>.get_Current
	|
	|-RVA: 0x2EB87F0 Offset: 0x2EB88F1 VA: 0x2EB87F0
	|-HashSet.Enumerator<MapPos>.get_Current
	|
	|-RVA: 0x2E03B10 Offset: 0x2E03C11 VA: 0x2E03B10
	|-HashSet.Enumerator<uint>.get_Current
	|
	|-RVA: 0x2E044C0 Offset: 0x2E045C1 VA: 0x2E044C0
	|-HashSet.Enumerator<ulong>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EAFBA0 Offset: 0x2EAFCA1 VA: 0x2EAFBA0
	|-HashSet.Enumerator<ValueTuple<object, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB1870 Offset: 0x2EB1971 VA: 0x2EB1870
	|-HashSet.Enumerator<AsyncOperationHandle>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB6060 Offset: 0x2EB6161 VA: 0x2EB6060
	|-HashSet.Enumerator<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB6D50 Offset: 0x2EB6E51 VA: 0x2EB6D50
	|-HashSet.Enumerator<Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB8800 Offset: 0x2EB8901 VA: 0x2EB8800
	|-HashSet.Enumerator<MapPos>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB9090 Offset: 0x2EB9191 VA: 0x2EB9090
	|-HashSet.Enumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E03B20 Offset: 0x2E03C21 VA: 0x2E03B20
	|-HashSet.Enumerator<uint>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E044D0 Offset: 0x2E045D1 VA: 0x2E044D0
	|-HashSet.Enumerator<ulong>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EAFCB0 Offset: 0x2EAFDB1 VA: 0x2EAFCB0
	|-HashSet.Enumerator<ValueTuple<object, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EB1960 Offset: 0x2EB1A61 VA: 0x2EB1960
	|-HashSet.Enumerator<AsyncOperationHandle>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EB6160 Offset: 0x2EB6261 VA: 0x2EB6160
	|-HashSet.Enumerator<int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EB6E50 Offset: 0x2EB6F51 VA: 0x2EB6E50
	|-HashSet.Enumerator<Int32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EB8900 Offset: 0x2EB8A01 VA: 0x2EB8900
	|-HashSet.Enumerator<MapPos>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2EB9130 Offset: 0x2EB9231 VA: 0x2EB9130
	|-HashSet.Enumerator<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E03C20 Offset: 0x2E03D21 VA: 0x2E03C20
	|-HashSet.Enumerator<uint>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2E045D0 Offset: 0x2E046D1 VA: 0x2E045D0
	|-HashSet.Enumerator<ulong>.System.Collections.IEnumerator.Reset
	*/
}

