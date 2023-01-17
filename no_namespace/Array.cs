// Namespace: 
private sealed class Array.ArrayEnumerator : IEnumerator, ICloneable // TypeDefIndex: 114
{
	// Fields
	private Array _array; // 0x10
	private int _index; // 0x18
	private int _endIndex; // 0x1C

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x35DFEB0 Offset: 0x35DFFB1 VA: 0x35DFEB0
	internal void .ctor(Array array) { }

	// RVA: 0x35DFF00 Offset: 0x35E0001 VA: 0x35DFF00 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x35DFF30 Offset: 0x35E0031 VA: 0x35DFF30 Slot: 6
	public void Reset() { }

	// RVA: 0x35DFF40 Offset: 0x35E0041 VA: 0x35DFF40 Slot: 7
	public object Clone() { }

	// RVA: 0x35DFF50 Offset: 0x35E0051 VA: 0x35DFF50 Slot: 5
	public object get_Current() { }
}

// Namespace: 
internal class Array.EmptyInternalEnumerator<T> : IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 116
{
	// Fields
	public static readonly Array.EmptyInternalEnumerator<T> Value; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x263E4F0 Offset: 0x263E5F1 VA: 0x263E4F0
	|-Array.EmptyInternalEnumerator<ArraySegment<byte>>.Dispose
	|
	|-RVA: 0x263E6E0 Offset: 0x263E7E1 VA: 0x263E6E0
	|-Array.EmptyInternalEnumerator<AsyncOperationHandle<object>>.Dispose
	|
	|-RVA: 0x263E8E0 Offset: 0x263E9E1 VA: 0x263E8E0
	|-Array.EmptyInternalEnumerator<MapDeployTemplate.Queue.Data<object>>.Dispose
	|
	|-RVA: 0x263EAC0 Offset: 0x263EBC1 VA: 0x263EAC0
	|-Array.EmptyInternalEnumerator<Nex.DataStore.ParamPool.Data<object>>.Dispose
	|
	|-RVA: 0x263ECB0 Offset: 0x263EDB1 VA: 0x263ECB0
	|-Array.EmptyInternalEnumerator<Nex.Screening.ParamPool.Data<object>>.Dispose
	|
	|-RVA: 0x263EEA0 Offset: 0x263EFA1 VA: 0x263EEA0
	|-Array.EmptyInternalEnumerator<IntervalTree.Entry<object>>.Dispose
	|
	|-RVA: 0x263F0A0 Offset: 0x263F1A1 VA: 0x263F0A0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<ValueTuple<object, int>, object>>.Dispose
	|
	|-RVA: 0x263F2A0 Offset: 0x263F3A1 VA: 0x263F2A0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<byte, object>>.Dispose
	|
	|-RVA: 0x263F4A0 Offset: 0x263F5A1 VA: 0x263F4A0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<CancellationToken, object>>.Dispose
	|
	|-RVA: 0x263F6A0 Offset: 0x263F7A1 VA: 0x263F6A0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<char, object>>.Dispose
	|
	|-RVA: 0x263F8A0 Offset: 0x263F9A1 VA: 0x263F8A0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Guid, object>>.Dispose
	|
	|-RVA: 0x263FAA0 Offset: 0x263FBA1 VA: 0x263FAA0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, bool>>.Dispose
	|
	|-RVA: 0x263FC90 Offset: 0x263FD91 VA: 0x263FC90
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, byte>>.Dispose
	|
	|-RVA: 0x263FE80 Offset: 0x263FF81 VA: 0x263FE80
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, char>>.Dispose
	|
	|-RVA: 0x2640070 Offset: 0x2640171 VA: 0x2640070
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, DiagnosticEvent>>.Dispose
	|
	|-RVA: 0x2640290 Offset: 0x2640391 VA: 0x2640290
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, int>>.Dispose
	|
	|-RVA: 0x2640480 Offset: 0x2640581 VA: 0x2640480
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, Int32Enum>>.Dispose
	|
	|-RVA: 0x2640670 Offset: 0x2640771 VA: 0x2640670
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, long>>.Dispose
	|
	|-RVA: 0x2640870 Offset: 0x2640971 VA: 0x2640870
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, MapPos>>.Dispose
	|
	|-RVA: 0x2640A70 Offset: 0x2640B71 VA: 0x2640A70
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, object>>.Dispose
	|
	|-RVA: 0x2640C70 Offset: 0x2640D71 VA: 0x2640C70
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, uint>>.Dispose
	|
	|-RVA: 0x2640E60 Offset: 0x2640F61 VA: 0x2640E60
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, AIThink.EnchantThink.SurroundingInfo>>.Dispose
	|
	|-RVA: 0x2641050 Offset: 0x2641151 VA: 0x2641050
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, bool>>.Dispose
	|
	|-RVA: 0x2641240 Offset: 0x2641341 VA: 0x2641240
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, int>>.Dispose
	|
	|-RVA: 0x2641430 Offset: 0x2641531 VA: 0x2641430
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, Int32Enum>>.Dispose
	|
	|-RVA: 0x2641620 Offset: 0x2641721 VA: 0x2641620
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, object>>.Dispose
	|
	|-RVA: 0x2641820 Offset: 0x2641921 VA: 0x2641820
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<long, object>>.Dispose
	|
	|-RVA: 0x2641A20 Offset: 0x2641B21 VA: 0x2641A20
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<MapPos, int>>.Dispose
	|
	|-RVA: 0x2641C20 Offset: 0x2641D21 VA: 0x2641C20
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, AsyncOperationHandle<object>>>.Dispose
	|
	|-RVA: 0x2641E30 Offset: 0x2641F31 VA: 0x2641E30
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, AsyncOperationHandle>>.Dispose
	|
	|-RVA: 0x2642040 Offset: 0x2642141 VA: 0x2642040
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, bool>>.Dispose
	|
	|-RVA: 0x2642240 Offset: 0x2642341 VA: 0x2642240
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, byte>>.Dispose
	|
	|-RVA: 0x2642440 Offset: 0x2642541 VA: 0x2642440
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, int>>.Dispose
	|
	|-RVA: 0x2642640 Offset: 0x2642741 VA: 0x2642640
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Int32Enum>>.Dispose
	|
	|-RVA: 0x2642840 Offset: 0x2642941 VA: 0x2642840
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, IntPtr>>.Dispose
	|
	|-RVA: 0x2642A40 Offset: 0x2642B41 VA: 0x2642A40
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, object>>.Dispose
	|
	|-RVA: 0x2642C40 Offset: 0x2642D41 VA: 0x2642C40
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Playable>>.Dispose
	|
	|-RVA: 0x2642E40 Offset: 0x2642F41 VA: 0x2642E40
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, ResourceLocator>>.Dispose
	|
	|-RVA: 0x2643040 Offset: 0x2643141 VA: 0x2643040
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, float>>.Dispose
	|
	|-RVA: 0x2643240 Offset: 0x2643341 VA: 0x2643240
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, ushort>>.Dispose
	|
	|-RVA: 0x2643440 Offset: 0x2643541 VA: 0x2643440
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, GameVariable.Value>>.Dispose
	|
	|-RVA: 0x2643640 Offset: 0x2643741 VA: 0x2643640
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<sbyte, DataStoreRatingInfo>>.Dispose
	|
	|-RVA: 0x2643850 Offset: 0x2643951 VA: 0x2643850
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<sbyte, object>>.Dispose
	|
	|-RVA: 0x2643A50 Offset: 0x2643B51 VA: 0x2643A50
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<ushort, int>>.Dispose
	|
	|-RVA: 0x2643C40 Offset: 0x2643D41 VA: 0x2643C40
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<uint, int>>.Dispose
	|
	|-RVA: 0x2643E30 Offset: 0x2643F31 VA: 0x2643E30
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<uint, object>>.Dispose
	|
	|-RVA: 0x2644030 Offset: 0x2644131 VA: 0x2644030
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<ulong, Friend>>.Dispose
	|
	|-RVA: 0x2644240 Offset: 0x2644341 VA: 0x2644240
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<ulong, Int32Enum>>.Dispose
	|
	|-RVA: 0x2644440 Offset: 0x2644541 VA: 0x2644440
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<ulong, object>>.Dispose
	|
	|-RVA: 0x2644640 Offset: 0x2644741 VA: 0x2644640
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Vector3, int>>.Dispose
	|
	|-RVA: 0x2644840 Offset: 0x2644941 VA: 0x2644840
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<XPathNodeRef, XPathNodeRef>>.Dispose
	|
	|-RVA: 0x2644A50 Offset: 0x2644B51 VA: 0x2644A50
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<TerrainUtility.TerrainMap.TileCoord, object>>.Dispose
	|
	|-RVA: 0x2644C50 Offset: 0x2644D51 VA: 0x2644C50
	|-Array.EmptyInternalEnumerator<PriorityQueue.IndexedItem<object>>.Dispose
	|
	|-RVA: 0x2644E40 Offset: 0x2644F41 VA: 0x2644E40
	|-Array.EmptyInternalEnumerator<KeyValuePair<ValueTuple<object, int>, object>>.Dispose
	|
	|-RVA: 0x2645040 Offset: 0x2645141 VA: 0x2645040
	|-Array.EmptyInternalEnumerator<KeyValuePair<byte, object>>.Dispose
	|
	|-RVA: 0x2645230 Offset: 0x2645331 VA: 0x2645230
	|-Array.EmptyInternalEnumerator<KeyValuePair<CancellationToken, object>>.Dispose
	|
	|-RVA: 0x2645420 Offset: 0x2645521 VA: 0x2645420
	|-Array.EmptyInternalEnumerator<KeyValuePair<char, object>>.Dispose
	|
	|-RVA: 0x2645610 Offset: 0x2645711 VA: 0x2645610
	|-Array.EmptyInternalEnumerator<KeyValuePair<DateTime, object>>.Dispose
	|
	|-RVA: 0x2645800 Offset: 0x2645901 VA: 0x2645800
	|-Array.EmptyInternalEnumerator<KeyValuePair<Guid, object>>.Dispose
	|
	|-RVA: 0x2645A00 Offset: 0x2645B01 VA: 0x2645A00
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, bool>>.Dispose
	|
	|-RVA: 0x2645BE0 Offset: 0x2645CE1 VA: 0x2645BE0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, byte>>.Dispose
	|
	|-RVA: 0x2645DC0 Offset: 0x2645EC1 VA: 0x2645DC0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, char>>.Dispose
	|
	|-RVA: 0x2645FA0 Offset: 0x26460A1 VA: 0x2645FA0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, DiagnosticEvent>>.Dispose
	|
	|-RVA: 0x26461B0 Offset: 0x26462B1 VA: 0x26461B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, int>>.Dispose
	|
	|-RVA: 0x2646390 Offset: 0x2646491 VA: 0x2646390
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, Int32Enum>>.Dispose
	|
	|-RVA: 0x2646570 Offset: 0x2646671 VA: 0x2646570
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, long>>.Dispose
	|
	|-RVA: 0x2646760 Offset: 0x2646861 VA: 0x2646760
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, MapPos>>.Dispose
	|
	|-RVA: 0x2646950 Offset: 0x2646A51 VA: 0x2646950
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, object>>.Dispose
	|
	|-RVA: 0x2646B40 Offset: 0x2646C41 VA: 0x2646B40
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, uint>>.Dispose
	|
	|-RVA: 0x2646D20 Offset: 0x2646E21 VA: 0x2646D20
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, AIThink.EnchantThink.SurroundingInfo>>.Dispose
	|
	|-RVA: 0x2646F00 Offset: 0x2647001 VA: 0x2646F00
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, bool>>.Dispose
	|
	|-RVA: 0x26470E0 Offset: 0x26471E1 VA: 0x26470E0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, int>>.Dispose
	|
	|-RVA: 0x26472C0 Offset: 0x26473C1 VA: 0x26472C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, Int32Enum>>.Dispose
	|
	|-RVA: 0x26474A0 Offset: 0x26475A1 VA: 0x26474A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, object>>.Dispose
	|
	|-RVA: 0x2647690 Offset: 0x2647791 VA: 0x2647690
	|-Array.EmptyInternalEnumerator<KeyValuePair<long, object>>.Dispose
	|
	|-RVA: 0x2647880 Offset: 0x2647981 VA: 0x2647880
	|-Array.EmptyInternalEnumerator<KeyValuePair<MapPos, int>>.Dispose
	|
	|-RVA: 0x2647A70 Offset: 0x2647B71 VA: 0x2647A70
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, AsyncOperationHandle<object>>>.Dispose
	|
	|-RVA: 0x2647C70 Offset: 0x2647D71 VA: 0x2647C70
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.Dispose
	|
	|-RVA: 0x2647E70 Offset: 0x2647F71 VA: 0x2647E70
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, AsyncOperationHandle>>.Dispose
	|
	|-RVA: 0x2648070 Offset: 0x2648171 VA: 0x2648070
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, bool>>.Dispose
	|
	|-RVA: 0x2648260 Offset: 0x2648361 VA: 0x2648260
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, byte>>.Dispose
	|
	|-RVA: 0x2648450 Offset: 0x2648551 VA: 0x2648450
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, int>>.Dispose
	|
	|-RVA: 0x2648640 Offset: 0x2648741 VA: 0x2648640
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Int32Enum>>.Dispose
	|
	|-RVA: 0x2648830 Offset: 0x2648931 VA: 0x2648830
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, IntPtr>>.Dispose
	|
	|-RVA: 0x2648A20 Offset: 0x2648B21 VA: 0x2648A20
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, object>>.Dispose
	|
	|-RVA: 0x2648C10 Offset: 0x2648D11 VA: 0x2648C10
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Playable>>.Dispose
	|
	|-RVA: 0x2648E10 Offset: 0x2648F11 VA: 0x2648E10
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, ResourceLocator>>.Dispose
	|
	|-RVA: 0x2649010 Offset: 0x2649111 VA: 0x2649010
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, float>>.Dispose
	|
	|-RVA: 0x2649200 Offset: 0x2649301 VA: 0x2649200
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, ushort>>.Dispose
	|
	|-RVA: 0x26493F0 Offset: 0x26494F1 VA: 0x26493F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, GameVariable.Value>>.Dispose
	|
	|-RVA: 0x26495F0 Offset: 0x26496F1 VA: 0x26495F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<sbyte, DataStoreRatingInfo>>.Dispose
	|
	|-RVA: 0x26497F0 Offset: 0x26498F1 VA: 0x26497F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<sbyte, object>>.Dispose
	|
	|-RVA: 0x26499E0 Offset: 0x2649AE1 VA: 0x26499E0
	|-Array.EmptyInternalEnumerator<KeyValuePair<ushort, int>>.Dispose
	|
	|-RVA: 0x2649BC0 Offset: 0x2649CC1 VA: 0x2649BC0
	|-Array.EmptyInternalEnumerator<KeyValuePair<uint, int>>.Dispose
	|
	|-RVA: 0x2649DA0 Offset: 0x2649EA1 VA: 0x2649DA0
	|-Array.EmptyInternalEnumerator<KeyValuePair<uint, object>>.Dispose
	|
	|-RVA: 0x2649F90 Offset: 0x264A091 VA: 0x2649F90
	|-Array.EmptyInternalEnumerator<KeyValuePair<ulong, Friend>>.Dispose
	|
	|-RVA: 0x264A1A0 Offset: 0x264A2A1 VA: 0x264A1A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<ulong, Int32Enum>>.Dispose
	|
	|-RVA: 0x264A390 Offset: 0x264A491 VA: 0x264A390
	|-Array.EmptyInternalEnumerator<KeyValuePair<ulong, object>>.Dispose
	|
	|-RVA: 0x264A580 Offset: 0x264A681 VA: 0x264A580
	|-Array.EmptyInternalEnumerator<KeyValuePair<Vector3, int>>.Dispose
	|
	|-RVA: 0x264A770 Offset: 0x264A871 VA: 0x264A770
	|-Array.EmptyInternalEnumerator<KeyValuePair<XPathNodeRef, XPathNodeRef>>.Dispose
	|
	|-RVA: 0x264A970 Offset: 0x264AA71 VA: 0x264A970
	|-Array.EmptyInternalEnumerator<KeyValuePair<TerrainUtility.TerrainMap.TileCoord, object>>.Dispose
	|
	|-RVA: 0x264AB60 Offset: 0x264AC61 VA: 0x264AB60
	|-Array.EmptyInternalEnumerator<NativeArray<PreTile>>.Dispose
	|
	|-RVA: 0x264AD50 Offset: 0x264AE51 VA: 0x264AD50
	|-Array.EmptyInternalEnumerator<CommonBattleSequence.Reliance<object>>.Dispose
	|
	|-RVA: 0x264AF50 Offset: 0x264B051 VA: 0x264AF50
	|-Array.EmptyInternalEnumerator<RenderGraphResourcePool.ResourceLogInfo<object>>.Dispose
	|
	|-RVA: 0x264B140 Offset: 0x264B241 VA: 0x264B140
	|-Array.EmptyInternalEnumerator<HashSet.Slot<ValueTuple<object, int>>>.Dispose
	|
	|-RVA: 0x264B340 Offset: 0x264B441 VA: 0x264B340
	|-Array.EmptyInternalEnumerator<HashSet.Slot<AsyncOperationHandle>>.Dispose
	|
	|-RVA: 0x264B540 Offset: 0x264B641 VA: 0x264B540
	|-Array.EmptyInternalEnumerator<HashSet.Slot<int>>.Dispose
	|
	|-RVA: 0x264B730 Offset: 0x264B831 VA: 0x264B730
	|-Array.EmptyInternalEnumerator<HashSet.Slot<Int32Enum>>.Dispose
	|
	|-RVA: 0x264B920 Offset: 0x264BA21 VA: 0x264B920
	|-Array.EmptyInternalEnumerator<Set.Slot<Int32Enum>>.Dispose
	|
	|-RVA: 0x264BB10 Offset: 0x264BC11 VA: 0x264BB10
	|-Array.EmptyInternalEnumerator<HashSet.Slot<MapPos>>.Dispose
	|
	|-RVA: 0x264BD00 Offset: 0x264BE01 VA: 0x264BD00
	|-Array.EmptyInternalEnumerator<HashSet.Slot<object>>.Dispose
	|
	|-RVA: 0x264BEF0 Offset: 0x264BFF1 VA: 0x264BEF0
	|-Array.EmptyInternalEnumerator<Set.Slot<object>>.Dispose
	|
	|-RVA: 0x264C0F0 Offset: 0x264C1F1 VA: 0x264C0F0
	|-Array.EmptyInternalEnumerator<HashSet.Slot<uint>>.Dispose
	|
	|-RVA: 0x264C2E0 Offset: 0x264C3E1 VA: 0x264C2E0
	|-Array.EmptyInternalEnumerator<HashSet.Slot<ulong>>.Dispose
	|
	|-RVA: 0x264C4D0 Offset: 0x264C5D1 VA: 0x264C4D0
	|-Array.EmptyInternalEnumerator<Set.Slot<Vector3>>.Dispose
	|
	|-RVA: 0x264C6D0 Offset: 0x264C7D1 VA: 0x264C6D0
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<Color32>>.Dispose
	|
	|-RVA: 0x264C8D0 Offset: 0x264C9D1 VA: 0x264C8D0
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<HighlightState>>.Dispose
	|
	|-RVA: 0x264CAE0 Offset: 0x264CBE1 VA: 0x264CAE0
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<int>>.Dispose
	|
	|-RVA: 0x264CCE0 Offset: 0x264CDE1 VA: 0x264CCE0
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<Int32Enum>>.Dispose
	|
	|-RVA: 0x264CEE0 Offset: 0x264CFE1 VA: 0x264CEE0
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<MaterialReference>>.Dispose
	|
	|-RVA: 0x264D140 Offset: 0x264D241 VA: 0x264D140
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<object>>.Dispose
	|
	|-RVA: 0x264D350 Offset: 0x264D451 VA: 0x264D350
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<float>>.Dispose
	|
	|-RVA: 0x264D550 Offset: 0x264D651 VA: 0x264D550
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<WordWrapState>>.Dispose
	|
	|-RVA: 0x264D760 Offset: 0x264D861 VA: 0x264D760
	|-Array.EmptyInternalEnumerator<TimeInterval<object>>.Dispose
	|
	|-RVA: 0x264D950 Offset: 0x264DA51 VA: 0x264D950
	|-Array.EmptyInternalEnumerator<Timestamped<object>>.Dispose
	|
	|-RVA: 0x264DB50 Offset: 0x264DC51 VA: 0x264DB50
	|-Array.EmptyInternalEnumerator<UniTask<object>>.Dispose
	|
	|-RVA: 0x264DD40 Offset: 0x264DE41 VA: 0x264DD40
	|-Array.EmptyInternalEnumerator<ValueTuple<ValueTuple<bool, object>>>.Dispose
	|
	|-RVA: 0x264DF30 Offset: 0x264E031 VA: 0x264DF30
	|-Array.EmptyInternalEnumerator<ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>.Dispose
	|
	|-RVA: 0x264E130 Offset: 0x264E231 VA: 0x264E130
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, UniTask<object>>>.Dispose
	|
	|-RVA: 0x264E330 Offset: 0x264E431 VA: 0x264E330
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.Dispose
	|
	|-RVA: 0x264E530 Offset: 0x264E631 VA: 0x264E530
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.Dispose
	|
	|-RVA: 0x264E740 Offset: 0x264E841 VA: 0x264E740
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.Dispose
	|
	|-RVA: 0x264E950 Offset: 0x264EA51 VA: 0x264E950
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.Dispose
	|
	|-RVA: 0x264EB40 Offset: 0x264EC41 VA: 0x264EB40
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.Dispose
	|
	|-RVA: 0x264ED30 Offset: 0x264EE31 VA: 0x264ED30
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.Dispose
	|
	|-RVA: 0x264EF50 Offset: 0x264F051 VA: 0x264EF50
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.Dispose
	|
	|-RVA: 0x264F140 Offset: 0x264F241 VA: 0x264F140
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.Dispose
	|
	|-RVA: 0x264F350 Offset: 0x264F451 VA: 0x264F350
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.Dispose
	|
	|-RVA: 0x264F560 Offset: 0x264F661 VA: 0x264F560
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.Dispose
	|
	|-RVA: 0x264F760 Offset: 0x264F861 VA: 0x264F760
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.Dispose
	|
	|-RVA: 0x264F970 Offset: 0x264FA71 VA: 0x264F970
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.Dispose
	|
	|-RVA: 0x264FB80 Offset: 0x264FC81 VA: 0x264FB80
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.Dispose
	|
	|-RVA: 0x264FD90 Offset: 0x264FE91 VA: 0x264FD90
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.Dispose
	|
	|-RVA: 0x264FFA0 Offset: 0x26500A1 VA: 0x264FFA0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.Dispose
	|
	|-RVA: 0x26501A0 Offset: 0x26502A1 VA: 0x26501A0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.Dispose
	|
	|-RVA: 0x26503B0 Offset: 0x26504B1 VA: 0x26503B0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.Dispose
	|
	|-RVA: 0x26505A0 Offset: 0x26506A1 VA: 0x26505A0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.Dispose
	|
	|-RVA: 0x26507B0 Offset: 0x26508B1 VA: 0x26507B0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.Dispose
	|
	|-RVA: 0x26509B0 Offset: 0x2650AB1 VA: 0x26509B0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.Dispose
	|
	|-RVA: 0x2650BC0 Offset: 0x2650CC1 VA: 0x2650BC0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.Dispose
	|
	|-RVA: 0x2650DD0 Offset: 0x2650ED1 VA: 0x2650DD0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.Dispose
	|
	|-RVA: 0x2650FE0 Offset: 0x26510E1 VA: 0x2650FE0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.Dispose
	|
	|-RVA: 0x26511F0 Offset: 0x26512F1 VA: 0x26511F0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.Dispose
	|
	|-RVA: 0x2651410 Offset: 0x2651511 VA: 0x2651410
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.Dispose
	|
	|-RVA: 0x2651660 Offset: 0x2651761 VA: 0x2651660
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.Dispose
	|
	|-RVA: 0x26518B0 Offset: 0x26519B1 VA: 0x26518B0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.Dispose
	|
	|-RVA: 0x2651B10 Offset: 0x2651C11 VA: 0x2651B10
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.Dispose
	|
	|-RVA: 0x2651D00 Offset: 0x2651E01 VA: 0x2651D00
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.Dispose
	|
	|-RVA: 0x2651EF0 Offset: 0x2651FF1 VA: 0x2651EF0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.Dispose
	|
	|-RVA: 0x2652100 Offset: 0x2652201 VA: 0x2652100
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.Dispose
	|
	|-RVA: 0x26522F0 Offset: 0x26523F1 VA: 0x26522F0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.Dispose
	|
	|-RVA: 0x26524F0 Offset: 0x26525F1 VA: 0x26524F0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.Dispose
	|
	|-RVA: 0x2652700 Offset: 0x2652801 VA: 0x2652700
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.Dispose
	|
	|-RVA: 0x2652900 Offset: 0x2652A01 VA: 0x2652900
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.Dispose
	|
	|-RVA: 0x2652B10 Offset: 0x2652C11 VA: 0x2652B10
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.Dispose
	|
	|-RVA: 0x2652D20 Offset: 0x2652E21 VA: 0x2652D20
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.Dispose
	|
	|-RVA: 0x2652F20 Offset: 0x2653021 VA: 0x2652F20
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.Dispose
	|
	|-RVA: 0x2653120 Offset: 0x2653221 VA: 0x2653120
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.Dispose
	|
	|-RVA: 0x2653320 Offset: 0x2653421 VA: 0x2653320
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.Dispose
	|
	|-RVA: 0x2653530 Offset: 0x2653631 VA: 0x2653530
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.Dispose
	|
	|-RVA: 0x2653720 Offset: 0x2653821 VA: 0x2653720
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.Dispose
	|
	|-RVA: 0x2653920 Offset: 0x2653A21 VA: 0x2653920
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.Dispose
	|
	|-RVA: 0x2653B30 Offset: 0x2653C31 VA: 0x2653B30
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.Dispose
	|
	|-RVA: 0x2653D30 Offset: 0x2653E31 VA: 0x2653D30
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.Dispose
	|
	|-RVA: 0x2653F40 Offset: 0x2654041 VA: 0x2653F40
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.Dispose
	|
	|-RVA: 0x2654150 Offset: 0x2654251 VA: 0x2654150
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Dispose
	|
	|-RVA: 0x2654370 Offset: 0x2654471 VA: 0x2654370
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.Dispose
	|
	|-RVA: 0x2654580 Offset: 0x2654681 VA: 0x2654580
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Dispose
	|
	|-RVA: 0x26547D0 Offset: 0x26548D1 VA: 0x26547D0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.Dispose
	|
	|-RVA: 0x26549E0 Offset: 0x2654AE1 VA: 0x26549E0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Dispose
	|
	|-RVA: 0x2654C60 Offset: 0x2654D61 VA: 0x2654C60
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.Dispose
	|
	|-RVA: 0x2654E80 Offset: 0x2654F81 VA: 0x2654E80
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Dispose
	|
	|-RVA: 0x2655110 Offset: 0x2655211 VA: 0x2655110
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.Dispose
	|
	|-RVA: 0x2655360 Offset: 0x2655461 VA: 0x2655360
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Dispose
	|
	|-RVA: 0x2655610 Offset: 0x2655711 VA: 0x2655610
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.Dispose
	|
	|-RVA: 0x2655860 Offset: 0x2655961 VA: 0x2655860
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.Dispose
	|
	|-RVA: 0x2655A40 Offset: 0x2655B41 VA: 0x2655A40
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.Dispose
	|
	|-RVA: 0x2655C20 Offset: 0x2655D21 VA: 0x2655C20
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.Dispose
	|
	|-RVA: 0x2655E30 Offset: 0x2655F31 VA: 0x2655E30
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.Dispose
	|
	|-RVA: 0x2656010 Offset: 0x2656111 VA: 0x2656010
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.Dispose
	|
	|-RVA: 0x2656220 Offset: 0x2656321 VA: 0x2656220
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.Dispose
	|
	|-RVA: 0x2656420 Offset: 0x2656521 VA: 0x2656420
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.Dispose
	|
	|-RVA: 0x2656610 Offset: 0x2656711 VA: 0x2656610
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.Dispose
	|
	|-RVA: 0x2656810 Offset: 0x2656911 VA: 0x2656810
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.Dispose
	|
	|-RVA: 0x2656A10 Offset: 0x2656B11 VA: 0x2656A10
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.Dispose
	|
	|-RVA: 0x2656C20 Offset: 0x2656D21 VA: 0x2656C20
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.Dispose
	|
	|-RVA: 0x2656E30 Offset: 0x2656F31 VA: 0x2656E30
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.Dispose
	|
	|-RVA: 0x2657020 Offset: 0x2657121 VA: 0x2657020
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.Dispose
	|
	|-RVA: 0x2657220 Offset: 0x2657321 VA: 0x2657220
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.Dispose
	|
	|-RVA: 0x2657400 Offset: 0x2657501 VA: 0x2657400
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.Dispose
	|
	|-RVA: 0x2657600 Offset: 0x2657701 VA: 0x2657600
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.Dispose
	|
	|-RVA: 0x2657800 Offset: 0x2657901 VA: 0x2657800
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.Dispose
	|
	|-RVA: 0x2657A10 Offset: 0x2657B11 VA: 0x2657A10
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.Dispose
	|
	|-RVA: 0x2657C10 Offset: 0x2657D11 VA: 0x2657C10
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.Dispose
	|
	|-RVA: 0x2657E10 Offset: 0x2657F11 VA: 0x2657E10
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Dispose
	|
	|-RVA: 0x2658020 Offset: 0x2658121 VA: 0x2658020
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.Dispose
	|
	|-RVA: 0x2658230 Offset: 0x2658331 VA: 0x2658230
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Dispose
	|
	|-RVA: 0x2658480 Offset: 0x2658581 VA: 0x2658480
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.Dispose
	|
	|-RVA: 0x2658690 Offset: 0x2658791 VA: 0x2658690
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Dispose
	|
	|-RVA: 0x26588F0 Offset: 0x26589F1 VA: 0x26588F0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.Dispose
	|
	|-RVA: 0x2658B00 Offset: 0x2658C01 VA: 0x2658B00
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Dispose
	|
	|-RVA: 0x2658D90 Offset: 0x2658E91 VA: 0x2658D90
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.Dispose
	|
	|-RVA: 0x2658FB0 Offset: 0x26590B1 VA: 0x2658FB0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Dispose
	|
	|-RVA: 0x2659250 Offset: 0x2659351 VA: 0x2659250
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.Dispose
	|
	|-RVA: 0x26594A0 Offset: 0x26595A1 VA: 0x26594A0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.Dispose
	|
	|-RVA: 0x26596B0 Offset: 0x26597B1 VA: 0x26596B0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.Dispose
	|
	|-RVA: 0x26598C0 Offset: 0x26599C1 VA: 0x26598C0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.Dispose
	|
	|-RVA: 0x2659AB0 Offset: 0x2659BB1 VA: 0x2659AB0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, bool>>>.Dispose
	|
	|-RVA: 0x2659CA0 Offset: 0x2659DA1 VA: 0x2659CA0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, Bounds>>>.Dispose
	|
	|-RVA: 0x2659EA0 Offset: 0x2659FA1 VA: 0x2659EA0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, byte>>>.Dispose
	|
	|-RVA: 0x265A090 Offset: 0x265A191 VA: 0x265A090
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, Color>>>.Dispose
	|
	|-RVA: 0x265A290 Offset: 0x265A391 VA: 0x265A290
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, double>>>.Dispose
	|
	|-RVA: 0x265A490 Offset: 0x265A591 VA: 0x265A490
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, int>>>.Dispose
	|
	|-RVA: 0x1CF0D40 Offset: 0x1CF0E41 VA: 0x1CF0D40
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, long>>>.Dispose
	|
	|-RVA: 0x1CF0F40 Offset: 0x1CF1041 VA: 0x1CF0F40
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, object>>>.Dispose
	|
	|-RVA: 0x1CF1140 Offset: 0x1CF1241 VA: 0x1CF1140
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, Quaternion>>>.Dispose
	|
	|-RVA: 0x1CF1340 Offset: 0x1CF1441 VA: 0x1CF1340
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, Rect>>>.Dispose
	|
	|-RVA: 0x1CF1540 Offset: 0x1CF1641 VA: 0x1CF1540
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, float>>>.Dispose
	|
	|-RVA: 0x1CF1730 Offset: 0x1CF1831 VA: 0x1CF1730
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, UniTask>>>.Dispose
	|
	|-RVA: 0x1CF1930 Offset: 0x1CF1A31 VA: 0x1CF1930
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, Unit>>>.Dispose
	|
	|-RVA: 0x1CF1B20 Offset: 0x1CF1C21 VA: 0x1CF1B20
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, Vector2>>>.Dispose
	|
	|-RVA: 0x1CF1D10 Offset: 0x1CF1E11 VA: 0x1CF1D10
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, Vector3>>>.Dispose
	|
	|-RVA: 0x1CF1F10 Offset: 0x1CF2011 VA: 0x1CF1F10
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, Vector4>>>.Dispose
	|
	|-RVA: 0x1CF2110 Offset: 0x1CF2211 VA: 0x1CF2110
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<int, object>>>.Dispose
	|
	|-RVA: 0x1CF2310 Offset: 0x1CF2411 VA: 0x1CF2310
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<object, object>>>.Dispose
	|
	|-RVA: 0x1CF2510 Offset: 0x1CF2611 VA: 0x1CF2510
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Dispose
	|
	|-RVA: 0x1CF2720 Offset: 0x1CF2821 VA: 0x1CF2720
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<object, object, object>>>.Dispose
	|
	|-RVA: 0x1CF2920 Offset: 0x1CF2A21 VA: 0x1CF2920
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Dispose
	|
	|-RVA: 0x1CF2B40 Offset: 0x1CF2C41 VA: 0x1CF2B40
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<object, object, object, object>>>.Dispose
	|
	|-RVA: 0x1CF2D50 Offset: 0x1CF2E51 VA: 0x1CF2D50
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Dispose
	|
	|-RVA: 0x1CF2FA0 Offset: 0x1CF30A1 VA: 0x1CF2FA0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.Dispose
	|
	|-RVA: 0x1CF31B0 Offset: 0x1CF32B1 VA: 0x1CF31B0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Dispose
	|
	|-RVA: 0x1CF3430 Offset: 0x1CF3531 VA: 0x1CF3430
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.Dispose
	|
	|-RVA: 0x1CF3640 Offset: 0x1CF3741 VA: 0x1CF3640
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Dispose
	|
	|-RVA: 0x1CF38D0 Offset: 0x1CF39D1 VA: 0x1CF38D0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.Dispose
	|
	|-RVA: 0x1CF3AF0 Offset: 0x1CF3BF1 VA: 0x1CF3AF0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.Dispose
	|
	|-RVA: 0x1CF3DA0 Offset: 0x1CF3EA1 VA: 0x1CF3DA0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.Dispose
	|
	|-RVA: 0x1CF3FB0 Offset: 0x1CF40B1 VA: 0x1CF3FB0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, AsyncUnit>>.Dispose
	|
	|-RVA: 0x1CF4190 Offset: 0x1CF4291 VA: 0x1CF4190
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, bool>>.Dispose
	|
	|-RVA: 0x1CF4370 Offset: 0x1CF4471 VA: 0x1CF4370
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Bounds>>.Dispose
	|
	|-RVA: 0x1CF4580 Offset: 0x1CF4681 VA: 0x1CF4580
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, byte>>.Dispose
	|
	|-RVA: 0x1CF4760 Offset: 0x1CF4861 VA: 0x1CF4760
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Color>>.Dispose
	|
	|-RVA: 0x1CF4960 Offset: 0x1CF4A61 VA: 0x1CF4960
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, double>>.Dispose
	|
	|-RVA: 0x1CF4B50 Offset: 0x1CF4C51 VA: 0x1CF4B50
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, int>>.Dispose
	|
	|-RVA: 0x1CF4D30 Offset: 0x1CF4E31 VA: 0x1CF4D30
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, long>>.Dispose
	|
	|-RVA: 0x1CF4F20 Offset: 0x1CF5021 VA: 0x1CF4F20
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, object>>.Dispose
	|
	|-RVA: 0x1CF5110 Offset: 0x1CF5211 VA: 0x1CF5110
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Quaternion>>.Dispose
	|
	|-RVA: 0x1CF5310 Offset: 0x1CF5411 VA: 0x1CF5310
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Rect>>.Dispose
	|
	|-RVA: 0x1CF5510 Offset: 0x1CF5611 VA: 0x1CF5510
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, float>>.Dispose
	|
	|-RVA: 0x1CF56F0 Offset: 0x1CF57F1 VA: 0x1CF56F0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, UniTask>>.Dispose
	|
	|-RVA: 0x1CF58E0 Offset: 0x1CF59E1 VA: 0x1CF58E0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Unit>>.Dispose
	|
	|-RVA: 0x1CF5AC0 Offset: 0x1CF5BC1 VA: 0x1CF5AC0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Vector2>>.Dispose
	|
	|-RVA: 0x1CF5CB0 Offset: 0x1CF5DB1 VA: 0x1CF5CB0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Vector3>>.Dispose
	|
	|-RVA: 0x1CF5EA0 Offset: 0x1CF5FA1 VA: 0x1CF5EA0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Vector4>>.Dispose
	|
	|-RVA: 0x1CF60A0 Offset: 0x1CF61A1 VA: 0x1CF60A0
	|-Array.EmptyInternalEnumerator<ValueTuple<int, bool>>.Dispose
	|
	|-RVA: 0x1CF6280 Offset: 0x1CF6381 VA: 0x1CF6280
	|-Array.EmptyInternalEnumerator<ValueTuple<int, Bounds>>.Dispose
	|
	|-RVA: 0x1CF6490 Offset: 0x1CF6591 VA: 0x1CF6490
	|-Array.EmptyInternalEnumerator<ValueTuple<int, byte>>.Dispose
	|
	|-RVA: 0x1CF6670 Offset: 0x1CF6771 VA: 0x1CF6670
	|-Array.EmptyInternalEnumerator<ValueTuple<int, Color>>.Dispose
	|
	|-RVA: 0x1CF6870 Offset: 0x1CF6971 VA: 0x1CF6870
	|-Array.EmptyInternalEnumerator<ValueTuple<int, double>>.Dispose
	|
	|-RVA: 0x1CF6A60 Offset: 0x1CF6B61 VA: 0x1CF6A60
	|-Array.EmptyInternalEnumerator<ValueTuple<int, int>>.Dispose
	|
	|-RVA: 0x1CF6C40 Offset: 0x1CF6D41 VA: 0x1CF6C40
	|-Array.EmptyInternalEnumerator<ValueTuple<int, long>>.Dispose
	|
	|-RVA: 0x1CF6E30 Offset: 0x1CF6F31 VA: 0x1CF6E30
	|-Array.EmptyInternalEnumerator<ValueTuple<int, object>>.Dispose
	|
	|-RVA: 0x1CF7020 Offset: 0x1CF7121 VA: 0x1CF7020
	|-Array.EmptyInternalEnumerator<ValueTuple<int, Quaternion>>.Dispose
	|
	|-RVA: 0x1CF7220 Offset: 0x1CF7321 VA: 0x1CF7220
	|-Array.EmptyInternalEnumerator<ValueTuple<int, Rect>>.Dispose
	|
	|-RVA: 0x1CF7420 Offset: 0x1CF7521 VA: 0x1CF7420
	|-Array.EmptyInternalEnumerator<ValueTuple<int, float>>.Dispose
	|
	|-RVA: 0x1CF7600 Offset: 0x1CF7701 VA: 0x1CF7600
	|-Array.EmptyInternalEnumerator<ValueTuple<int, Unit>>.Dispose
	|
	|-RVA: 0x1CF77E0 Offset: 0x1CF78E1 VA: 0x1CF77E0
	|-Array.EmptyInternalEnumerator<ValueTuple<int, Vector2>>.Dispose
	|
	|-RVA: 0x1CF79D0 Offset: 0x1CF7AD1 VA: 0x1CF79D0
	|-Array.EmptyInternalEnumerator<ValueTuple<int, Vector3>>.Dispose
	|
	|-RVA: 0x1CF7BC0 Offset: 0x1CF7CC1 VA: 0x1CF7BC0
	|-Array.EmptyInternalEnumerator<ValueTuple<int, Vector4>>.Dispose
	|
	|-RVA: 0x1CF7DC0 Offset: 0x1CF7EC1 VA: 0x1CF7DC0
	|-Array.EmptyInternalEnumerator<ValueTuple<Int32Enum, int>>.Dispose
	|
	|-RVA: 0x1CF7FA0 Offset: 0x1CF80A1 VA: 0x1CF7FA0
	|-Array.EmptyInternalEnumerator<ValueTuple<object, ValueTuple<object, int>>>.Dispose
	|
	|-RVA: 0x1CF81A0 Offset: 0x1CF82A1 VA: 0x1CF81A0
	|-Array.EmptyInternalEnumerator<ValueTuple<object, int>>.Dispose
	|
	|-RVA: 0x1CF8390 Offset: 0x1CF8491 VA: 0x1CF8390
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object>>.Dispose
	|
	|-RVA: 0x1CF8580 Offset: 0x1CF8681 VA: 0x1CF8580
	|-Array.EmptyInternalEnumerator<ValueTuple<object, float>>.Dispose
	|
	|-RVA: 0x1CF8770 Offset: 0x1CF8871 VA: 0x1CF8770
	|-Array.EmptyInternalEnumerator<ValueTuple<Vector3, float>>.Dispose
	|
	|-RVA: 0x1CF8960 Offset: 0x1CF8A61 VA: 0x1CF8960
	|-Array.EmptyInternalEnumerator<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Dispose
	|
	|-RVA: 0x1CF8B70 Offset: 0x1CF8C71 VA: 0x1CF8B70
	|-Array.EmptyInternalEnumerator<ValueTuple<object, Int32Enum, int>>.Dispose
	|
	|-RVA: 0x1CF8D60 Offset: 0x1CF8E61 VA: 0x1CF8D60
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object, object>>.Dispose
	|
	|-RVA: 0x1CF8F60 Offset: 0x1CF9061 VA: 0x1CF8F60
	|-Array.EmptyInternalEnumerator<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Dispose
	|
	|-RVA: 0x1CF9170 Offset: 0x1CF9271 VA: 0x1CF9170
	|-Array.EmptyInternalEnumerator<ValueTuple<object, int, int, int>>.Dispose
	|
	|-RVA: 0x1CF9370 Offset: 0x1CF9471 VA: 0x1CF9370
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object, object, object>>.Dispose
	|
	|-RVA: 0x1CF9570 Offset: 0x1CF9671 VA: 0x1CF9570
	|-Array.EmptyInternalEnumerator<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Dispose
	|
	|-RVA: 0x1CF97C0 Offset: 0x1CF98C1 VA: 0x1CF97C0
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object, object, object, object>>.Dispose
	|
	|-RVA: 0x1CF99D0 Offset: 0x1CF9AD1 VA: 0x1CF99D0
	|-Array.EmptyInternalEnumerator<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Dispose
	|
	|-RVA: 0x1CF9C30 Offset: 0x1CF9D31 VA: 0x1CF9C30
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object, object, object, object, object>>.Dispose
	|
	|-RVA: 0x1CF9E40 Offset: 0x1CF9F41 VA: 0x1CF9E40
	|-Array.EmptyInternalEnumerator<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.Dispose
	|
	|-RVA: 0x1CFA0D0 Offset: 0x1CFA1D1 VA: 0x1CFA0D0
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object, object, object, object, object, object>>.Dispose
	|
	|-RVA: 0x1CFA2E0 Offset: 0x1CFA3E1 VA: 0x1CFA2E0
	|-Array.EmptyInternalEnumerator<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.Dispose
	|
	|-RVA: 0x1CFA580 Offset: 0x1CFA681 VA: 0x1CFA580
	|-Array.EmptyInternalEnumerator<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.Dispose
	|
	|-RVA: 0x1CFA790 Offset: 0x1CFA891 VA: 0x1CFA790
	|-Array.EmptyInternalEnumerator<AnimatorClipInfo>.Dispose
	|
	|-RVA: 0x1CFA970 Offset: 0x1CFAA71 VA: 0x1CFA970
	|-Array.EmptyInternalEnumerator<AsyncOperationHandle>.Dispose
	|
	|-RVA: 0x1CFAB70 Offset: 0x1CFAC71 VA: 0x1CFAB70
	|-Array.EmptyInternalEnumerator<AsyncUnit>.Dispose
	|
	|-RVA: 0x1CFAD50 Offset: 0x1CFAE51 VA: 0x1CFAD50
	|-Array.EmptyInternalEnumerator<BatchVisibility>.Dispose
	|
	|-RVA: 0x1CFAF40 Offset: 0x1CFB041 VA: 0x1CFAF40
	|-Array.EmptyInternalEnumerator<BoneWeight>.Dispose
	|
	|-RVA: 0x1CFB140 Offset: 0x1CFB241 VA: 0x1CFB140
	|-Array.EmptyInternalEnumerator<BoneWeight1>.Dispose
	|
	|-RVA: 0x1CFB320 Offset: 0x1CFB421 VA: 0x1CFB320
	|-Array.EmptyInternalEnumerator<bool>.Dispose
	|
	|-RVA: 0x1CFB500 Offset: 0x1CFB601 VA: 0x1CFB500
	|-Array.EmptyInternalEnumerator<Bounds>.Dispose
	|
	|-RVA: 0x1CFB700 Offset: 0x1CFB801 VA: 0x1CFB700
	|-Array.EmptyInternalEnumerator<byte>.Dispose
	|
	|-RVA: 0x1CFB8E0 Offset: 0x1CFB9E1 VA: 0x1CFB8E0
	|-Array.EmptyInternalEnumerator<ByteEnum>.Dispose
	|
	|-RVA: 0x1CFBAC0 Offset: 0x1CFBBC1 VA: 0x1CFBAC0
	|-Array.EmptyInternalEnumerator<CameraInfo>.Dispose
	|
	|-RVA: 0x1CFBCB0 Offset: 0x1CFBDB1 VA: 0x1CFBCB0
	|-Array.EmptyInternalEnumerator<CancellationToken>.Dispose
	|
	|-RVA: 0x1CFBE90 Offset: 0x1CFBF91 VA: 0x1CFBE90
	|-Array.EmptyInternalEnumerator<CancellationTokenRegistration>.Dispose
	|
	|-RVA: 0x1CFC090 Offset: 0x1CFC191 VA: 0x1CFC090
	|-Array.EmptyInternalEnumerator<char>.Dispose
	|
	|-RVA: 0x1CFC270 Offset: 0x1CFC371 VA: 0x1CFC270
	|-Array.EmptyInternalEnumerator<ClusteringData>.Dispose
	|
	|-RVA: 0x1CFC470 Offset: 0x1CFC571 VA: 0x1CFC470
	|-Array.EmptyInternalEnumerator<ClusteringProcessorState>.Dispose
	|
	|-RVA: 0x1CFC680 Offset: 0x1CFC781 VA: 0x1CFC680
	|-Array.EmptyInternalEnumerator<Color>.Dispose
	|
	|-RVA: 0x1CFC870 Offset: 0x1CFC971 VA: 0x1CFC870
	|-Array.EmptyInternalEnumerator<Color32>.Dispose
	|
	|-RVA: 0x1CFCA50 Offset: 0x1CFCB51 VA: 0x1CFCA50
	|-Array.EmptyInternalEnumerator<Color4u8>.Dispose
	|
	|-RVA: 0x1CFCC30 Offset: 0x1CFCD31 VA: 0x1CFCC30
	|-Array.EmptyInternalEnumerator<ColorBlock>.Dispose
	|
	|-RVA: 0x1CFCE90 Offset: 0x1CFCF91 VA: 0x1CFCE90
	|-Array.EmptyInternalEnumerator<CombineInstance>.Dispose
	|
	|-RVA: 0x1CFD120 Offset: 0x1CFD221 VA: 0x1CFD120
	|-Array.EmptyInternalEnumerator<ConstraintSource>.Dispose
	|
	|-RVA: 0x1CFD310 Offset: 0x1CFD411 VA: 0x1CFD310
	|-Array.EmptyInternalEnumerator<ContactPoint>.Dispose
	|
	|-RVA: 0x1CFD520 Offset: 0x1CFD621 VA: 0x1CFD520
	|-Array.EmptyInternalEnumerator<ContactPoint2D>.Dispose
	|
	|-RVA: 0x1CFD730 Offset: 0x1CFD831 VA: 0x1CFD730
	|-Array.EmptyInternalEnumerator<ContourVertex>.Dispose
	|
	|-RVA: 0x1CFD930 Offset: 0x1CFDA31 VA: 0x1CFD930
	|-Array.EmptyInternalEnumerator<CustomAttributeNamedArgument>.Dispose
	|
	|-RVA: 0x1CFDB30 Offset: 0x1CFDC31 VA: 0x1CFDB30
	|-Array.EmptyInternalEnumerator<CustomAttributeTypedArgument>.Dispose
	|
	|-RVA: 0x1CFDD20 Offset: 0x1CFDE21 VA: 0x1CFDD20
	|-Array.EmptyInternalEnumerator<DataStoreRatingInfo>.Dispose
	|
	|-RVA: 0x1CFDF20 Offset: 0x1CFE021 VA: 0x1CFDF20
	|-Array.EmptyInternalEnumerator<DataStoreResult>.Dispose
	|
	|-RVA: 0x1CFE100 Offset: 0x1CFE201 VA: 0x1CFE100
	|-Array.EmptyInternalEnumerator<DateTime>.Dispose
	|
	|-RVA: 0x1CFE2E0 Offset: 0x1CFE3E1 VA: 0x1CFE2E0
	|-Array.EmptyInternalEnumerator<DateTimeOffset>.Dispose
	|
	|-RVA: 0x1CFE4D0 Offset: 0x1CFE5D1 VA: 0x1CFE4D0
	|-Array.EmptyInternalEnumerator<DebugPadState>.Dispose
	|
	|-RVA: 0x1CFE6D0 Offset: 0x1CFE7D1 VA: 0x1CFE6D0
	|-Array.EmptyInternalEnumerator<Decimal>.Dispose
	|
	|-RVA: 0x1CFE8C0 Offset: 0x1CFE9C1 VA: 0x1CFE8C0
	|-Array.EmptyInternalEnumerator<DeferredTiler>.Dispose
	|
	|-RVA: 0x1CFEB60 Offset: 0x1CFEC61 VA: 0x1CFEB60
	|-Array.EmptyInternalEnumerator<DeviceHandle>.Dispose
	|
	|-RVA: 0x1CFED50 Offset: 0x1CFEE51 VA: 0x1CFED50
	|-Array.EmptyInternalEnumerator<DiagnosticEvent>.Dispose
	|
	|-RVA: 0x1CFEF60 Offset: 0x1CFF061 VA: 0x1CFEF60
	|-Array.EmptyInternalEnumerator<DictionaryEntry>.Dispose
	|
	|-RVA: 0x1CFF150 Offset: 0x1CFF251 VA: 0x1CFF150
	|-Array.EmptyInternalEnumerator<DictionaryInfo>.Dispose
	|
	|-RVA: 0x1CFF330 Offset: 0x1CFF431 VA: 0x1CFF330
	|-Array.EmptyInternalEnumerator<DirectoryEntry>.Dispose
	|
	|-RVA: 0x1CFF530 Offset: 0x1CFF631 VA: 0x1CFF530
	|-Array.EmptyInternalEnumerator<double>.Dispose
	|
	|-RVA: 0x1CFF710 Offset: 0x1CFF811 VA: 0x1CFF710
	|-Array.EmptyInternalEnumerator<Ephemeron>.Dispose
	|
	|-RVA: 0x1CFF900 Offset: 0x1CFFA01 VA: 0x1CFF900
	|-Array.EmptyInternalEnumerator<FXZ>.Dispose
	|
	|-RVA: 0x1CFFAE0 Offset: 0x1CFFBE1 VA: 0x1CFFAE0
	|-Array.EmptyInternalEnumerator<Finger>.Dispose
	|
	|-RVA: 0x1CFFCF0 Offset: 0x1CFFDF1 VA: 0x1CFFCF0
	|-Array.EmptyInternalEnumerator<Float2>.Dispose
	|
	|-RVA: 0x1CFFED0 Offset: 0x1CFFFD1 VA: 0x1CFFED0
	|-Array.EmptyInternalEnumerator<Friend>.Dispose
	|
	|-RVA: 0x1D000E0 Offset: 0x1D001E1 VA: 0x1D000E0
	|-Array.EmptyInternalEnumerator<GCHandle>.Dispose
	|
	|-RVA: 0x1D002C0 Offset: 0x1D003C1 VA: 0x1D002C0
	|-Array.EmptyInternalEnumerator<GesturePoint>.Dispose
	|
	|-RVA: 0x1D004A0 Offset: 0x1D005A1 VA: 0x1D004A0
	|-Array.EmptyInternalEnumerator<GestureState>.Dispose
	|
	|-RVA: 0x1D00720 Offset: 0x1D00821 VA: 0x1D00720
	|-Array.EmptyInternalEnumerator<GlyphMarshallingStruct>.Dispose
	|
	|-RVA: 0x1D00930 Offset: 0x1D00A31 VA: 0x1D00930
	|-Array.EmptyInternalEnumerator<GlyphPairAdjustmentRecord>.Dispose
	|
	|-RVA: 0x1D00B50 Offset: 0x1D00C51 VA: 0x1D00B50
	|-Array.EmptyInternalEnumerator<GlyphRect>.Dispose
	|
	|-RVA: 0x1D00D40 Offset: 0x1D00E41 VA: 0x1D00D40
	|-Array.EmptyInternalEnumerator<Guid>.Dispose
	|
	|-RVA: 0x1D00F30 Offset: 0x1D01031 VA: 0x1D00F30
	|-Array.EmptyInternalEnumerator<Hand>.Dispose
	|
	|-RVA: 0x1D01140 Offset: 0x1D01241 VA: 0x1D01140
	|-Array.EmptyInternalEnumerator<HandAnalysisImageState>.Dispose
	|
	|-RVA: 0x1D01330 Offset: 0x1D01431 VA: 0x1D01330
	|-Array.EmptyInternalEnumerator<HandAnalysisSilhouetteState>.Dispose
	|
	|-RVA: 0x1D01540 Offset: 0x1D01641 VA: 0x1D01540
	|-Array.EmptyInternalEnumerator<HeaderVariantInfo>.Dispose
	|
	|-RVA: 0x1D01730 Offset: 0x1D01831 VA: 0x1D01730
	|-Array.EmptyInternalEnumerator<HighlightState>.Dispose
	|
	|-RVA: 0x1D01930 Offset: 0x1D01A31 VA: 0x1D01930
	|-Array.EmptyInternalEnumerator<HumanBone>.Dispose
	|
	|-RVA: 0x1D01B50 Offset: 0x1D01C51 VA: 0x1D01B50
	|-Array.EmptyInternalEnumerator<short>.Dispose
	|
	|-RVA: 0x1D01D30 Offset: 0x1D01E31 VA: 0x1D01D30
	|-Array.EmptyInternalEnumerator<int>.Dispose
	|
	|-RVA: 0x1D01F10 Offset: 0x1D02011 VA: 0x1D01F10
	|-Array.EmptyInternalEnumerator<Int32Enum>.Dispose
	|
	|-RVA: 0x1D020F0 Offset: 0x1D021F1 VA: 0x1D020F0
	|-Array.EmptyInternalEnumerator<long>.Dispose
	|
	|-RVA: 0x1D022D0 Offset: 0x1D023D1 VA: 0x1D022D0
	|-Array.EmptyInternalEnumerator<Int64Enum>.Dispose
	|
	|-RVA: 0x1D024B0 Offset: 0x1D025B1 VA: 0x1D024B0
	|-Array.EmptyInternalEnumerator<IntPtr>.Dispose
	|
	|-RVA: 0x1D02690 Offset: 0x1D02791 VA: 0x1D02690
	|-Array.EmptyInternalEnumerator<InternalCodePageDataItem>.Dispose
	|
	|-RVA: 0x1D02880 Offset: 0x1D02981 VA: 0x1D02880
	|-Array.EmptyInternalEnumerator<InternalEncodingDataItem>.Dispose
	|
	|-RVA: 0x1D02A70 Offset: 0x1D02B71 VA: 0x1D02A70
	|-Array.EmptyInternalEnumerator<InterpretedFrameInfo>.Dispose
	|
	|-RVA: 0x1D02C60 Offset: 0x1D02D61 VA: 0x1D02C60
	|-Array.EmptyInternalEnumerator<IntervalTreeNode>.Dispose
	|
	|-RVA: 0x1D02E60 Offset: 0x1D02F61 VA: 0x1D02E60
	|-Array.EmptyInternalEnumerator<JobHandle>.Dispose
	|
	|-RVA: 0x1D03050 Offset: 0x1D03151 VA: 0x1D03050
	|-Array.EmptyInternalEnumerator<Keyframe>.Dispose
	|
	|-RVA: 0x1D03260 Offset: 0x1D03361 VA: 0x1D03260
	|-Array.EmptyInternalEnumerator<LOD>.Dispose
	|
	|-RVA: 0x1D03450 Offset: 0x1D03551 VA: 0x1D03450
	|-Array.EmptyInternalEnumerator<LayerMask>.Dispose
	|
	|-RVA: 0x1D03630 Offset: 0x1D03731 VA: 0x1D03630
	|-Array.EmptyInternalEnumerator<LengthLimitProperties>.Dispose
	|
	|-RVA: 0x1D03810 Offset: 0x1D03911 VA: 0x1D03810
	|-Array.EmptyInternalEnumerator<Light2DBlendStyle>.Dispose
	|
	|-RVA: 0x1D03A60 Offset: 0x1D03B61 VA: 0x1D03A60
	|-Array.EmptyInternalEnumerator<LightDataGI>.Dispose
	|
	|-RVA: 0x1D03CE0 Offset: 0x1D03DE1 VA: 0x1D03CE0
	|-Array.EmptyInternalEnumerator<LocalDefinition>.Dispose
	|
	|-RVA: 0x1D03ED0 Offset: 0x1D03FD1 VA: 0x1D03ED0
	|-Array.EmptyInternalEnumerator<MapPos>.Dispose
	|
	|-RVA: 0x1D040B0 Offset: 0x1D041B1 VA: 0x1D040B0
	|-Array.EmptyInternalEnumerator<MapRange>.Dispose
	|
	|-RVA: 0x1D042A0 Offset: 0x1D043A1 VA: 0x1D042A0
	|-Array.EmptyInternalEnumerator<MaterialReference>.Dispose
	|
	|-RVA: 0x1D044B0 Offset: 0x1D045B1 VA: 0x1D044B0
	|-Array.EmptyInternalEnumerator<Matrix4x4>.Dispose
	|
	|-RVA: 0x1D046D0 Offset: 0x1D047D1 VA: 0x1D046D0
	|-Array.EmptyInternalEnumerator<MomentProcessorState>.Dispose
	|
	|-RVA: 0x1D048E0 Offset: 0x1D049E1 VA: 0x1D048E0
	|-Array.EmptyInternalEnumerator<MomentStatistic>.Dispose
	|
	|-RVA: 0x1D04AD0 Offset: 0x1D04BD1 VA: 0x1D04AD0
	|-Array.EmptyInternalEnumerator<Navigation>.Dispose
	|
	|-RVA: 0x1D04CE0 Offset: 0x1D04DE1 VA: 0x1D04CE0
	|-Array.EmptyInternalEnumerator<NetworkServiceAccountId>.Dispose
	|
	|-RVA: 0x1D04EC0 Offset: 0x1D04FC1 VA: 0x1D04EC0
	|-Array.EmptyInternalEnumerator<NpadFullKeyState>.Dispose
	|
	|-RVA: 0x1D050D0 Offset: 0x1D051D1 VA: 0x1D050D0
	|-Array.EmptyInternalEnumerator<NpadHandheldState>.Dispose
	|
	|-RVA: 0x1D052E0 Offset: 0x1D053E1 VA: 0x1D052E0
	|-Array.EmptyInternalEnumerator<NpadJoyDualState>.Dispose
	|
	|-RVA: 0x1D054F0 Offset: 0x1D055F1 VA: 0x1D054F0
	|-Array.EmptyInternalEnumerator<NpadJoyLeftState>.Dispose
	|
	|-RVA: 0x1D05700 Offset: 0x1D05801 VA: 0x1D05700
	|-Array.EmptyInternalEnumerator<NpadJoyRightState>.Dispose
	|
	|-RVA: 0x1D05910 Offset: 0x1D05A11 VA: 0x1D05910
	|-Array.EmptyInternalEnumerator<NpadStateArrayItem>.Dispose
	|
	|-RVA: 0x1D05B20 Offset: 0x1D05C21 VA: 0x1D05B20
	|-Array.EmptyInternalEnumerator<NsUid>.Dispose
	|
	|-RVA: 0x1D05D00 Offset: 0x1D05E01 VA: 0x1D05D00
	|-Array.EmptyInternalEnumerator<object>.Dispose
	|
	|-RVA: 0x1D05EA0 Offset: 0x1D05FA1 VA: 0x1D05EA0
	|-Array.EmptyInternalEnumerator<ObjectInitializationData>.Dispose
	|
	|-RVA: 0x1D060B0 Offset: 0x1D061B1 VA: 0x1D060B0
	|-Array.EmptyInternalEnumerator<ParameterModifier>.Dispose
	|
	|-RVA: 0x1D06290 Offset: 0x1D06391 VA: 0x1D06290
	|-Array.EmptyInternalEnumerator<Plane>.Dispose
	|
	|-RVA: 0x1D06480 Offset: 0x1D06581 VA: 0x1D06480
	|-Array.EmptyInternalEnumerator<Playable>.Dispose
	|
	|-RVA: 0x1D06670 Offset: 0x1D06771 VA: 0x1D06670
	|-Array.EmptyInternalEnumerator<PlayableBinding>.Dispose
	|
	|-RVA: 0x1D06870 Offset: 0x1D06971 VA: 0x1D06870
	|-Array.EmptyInternalEnumerator<PlayerLoopSystem>.Dispose
	|
	|-RVA: 0x1D06A80 Offset: 0x1D06B81 VA: 0x1D06A80
	|-Array.EmptyInternalEnumerator<PlayerLoopSystemInternal>.Dispose
	|
	|-RVA: 0x1D06C90 Offset: 0x1D06D91 VA: 0x1D06C90
	|-Array.EmptyInternalEnumerator<PreTile>.Dispose
	|
	|-RVA: 0x1D06EB0 Offset: 0x1D06FB1 VA: 0x1D06EB0
	|-Array.EmptyInternalEnumerator<Profile>.Dispose
	|
	|-RVA: 0x1D070C0 Offset: 0x1D071C1 VA: 0x1D070C0
	|-Array.EmptyInternalEnumerator<Protrusion>.Dispose
	|
	|-RVA: 0x1D072A0 Offset: 0x1D073A1 VA: 0x1D072A0
	|-Array.EmptyInternalEnumerator<Quaternion>.Dispose
	|
	|-RVA: 0x1D07490 Offset: 0x1D07591 VA: 0x1D07490
	|-Array.EmptyInternalEnumerator<RandomSeed>.Dispose
	|
	|-RVA: 0x1D07680 Offset: 0x1D07781 VA: 0x1D07680
	|-Array.EmptyInternalEnumerator<RangePositionInfo>.Dispose
	|
	|-RVA: 0x1D07870 Offset: 0x1D07971 VA: 0x1D07870
	|-Array.EmptyInternalEnumerator<Ranking2ChartInfoInput>.Dispose
	|
	|-RVA: 0x1D07A50 Offset: 0x1D07B51 VA: 0x1D07A50
	|-Array.EmptyInternalEnumerator<RaycastHit>.Dispose
	|
	|-RVA: 0x1D07C70 Offset: 0x1D07D71 VA: 0x1D07C70
	|-Array.EmptyInternalEnumerator<RaycastHit2D>.Dispose
	|
	|-RVA: 0x1D07E80 Offset: 0x1D07F81 VA: 0x1D07E80
	|-Array.EmptyInternalEnumerator<RaycastResult>.Dispose
	|
	|-RVA: 0x1D080D0 Offset: 0x1D081D1 VA: 0x1D080D0
	|-Array.EmptyInternalEnumerator<Rect>.Dispose
	|
	|-RVA: 0x1D082C0 Offset: 0x1D083C1 VA: 0x1D082C0
	|-Array.EmptyInternalEnumerator<RenderBuffer>.Dispose
	|
	|-RVA: 0x1D084B0 Offset: 0x1D085B1 VA: 0x1D084B0
	|-Array.EmptyInternalEnumerator<RenderStateBlock>.Dispose
	|
	|-RVA: 0x1D08750 Offset: 0x1D08851 VA: 0x1D08750
	|-Array.EmptyInternalEnumerator<RenderTargetHandle>.Dispose
	|
	|-RVA: 0x1D08960 Offset: 0x1D08A61 VA: 0x1D08960
	|-Array.EmptyInternalEnumerator<RenderTargetIdentifier>.Dispose
	|
	|-RVA: 0x1D08B70 Offset: 0x1D08C71 VA: 0x1D08B70
	|-Array.EmptyInternalEnumerator<RendererListHandle>.Dispose
	|
	|-RVA: 0x1D08D50 Offset: 0x1D08E51 VA: 0x1D08D50
	|-Array.EmptyInternalEnumerator<ResourceHandle>.Dispose
	|
	|-RVA: 0x1D08F30 Offset: 0x1D09031 VA: 0x1D08F30
	|-Array.EmptyInternalEnumerator<ResourceLocator>.Dispose
	|
	|-RVA: 0x1D09120 Offset: 0x1D09221 VA: 0x1D09120
	|-Array.EmptyInternalEnumerator<RichTextTagAttribute>.Dispose
	|
	|-RVA: 0x1D09320 Offset: 0x1D09421 VA: 0x1D09320
	|-Array.EmptyInternalEnumerator<RuntimeLabel>.Dispose
	|
	|-RVA: 0x1D09510 Offset: 0x1D09611 VA: 0x1D09510
	|-Array.EmptyInternalEnumerator<sbyte>.Dispose
	|
	|-RVA: 0x1D096F0 Offset: 0x1D097F1 VA: 0x1D096F0
	|-Array.EmptyInternalEnumerator<SerializedType>.Dispose
	|
	|-RVA: 0x1D098F0 Offset: 0x1D099F1 VA: 0x1D098F0
	|-Array.EmptyInternalEnumerator<ShaderKeyword>.Dispose
	|
	|-RVA: 0x1D09AD0 Offset: 0x1D09BD1 VA: 0x1D09AD0
	|-Array.EmptyInternalEnumerator<ShaderTagId>.Dispose
	|
	|-RVA: 0x1D09CB0 Offset: 0x1D09DB1 VA: 0x1D09CB0
	|-Array.EmptyInternalEnumerator<ShadowSliceData>.Dispose
	|
	|-RVA: 0x1D09EC0 Offset: 0x1D09FC1 VA: 0x1D09EC0
	|-Array.EmptyInternalEnumerator<Shape>.Dispose
	|
	|-RVA: 0x1D0A0C0 Offset: 0x1D0A1C1 VA: 0x1D0A0C0
	|-Array.EmptyInternalEnumerator<float>.Dispose
	|
	|-RVA: 0x1D0A2A0 Offset: 0x1D0A3A1 VA: 0x1D0A2A0
	|-Array.EmptyInternalEnumerator<SixAxisSensorHandle>.Dispose
	|
	|-RVA: 0x1D0A480 Offset: 0x1D0A581 VA: 0x1D0A480
	|-Array.EmptyInternalEnumerator<SixAxisSensorState>.Dispose
	|
	|-RVA: 0x1D0A700 Offset: 0x1D0A801 VA: 0x1D0A700
	|-Array.EmptyInternalEnumerator<SkeletonBone>.Dispose
	|
	|-RVA: 0x1D0A910 Offset: 0x1D0AA11 VA: 0x1D0A910
	|-Array.EmptyInternalEnumerator<SortingLayer>.Dispose
	|
	|-RVA: 0x1D0AAF0 Offset: 0x1D0ABF1 VA: 0x1D0AAF0
	|-Array.EmptyInternalEnumerator<SphericalHarmonicsL2>.Dispose
	|
	|-RVA: 0x1D0AD90 Offset: 0x1D0AE91 VA: 0x1D0AD90
	|-Array.EmptyInternalEnumerator<SpinLock>.Dispose
	|
	|-RVA: 0x1D0AF70 Offset: 0x1D0B071 VA: 0x1D0AF70
	|-Array.EmptyInternalEnumerator<SpringBoneComponents>.Dispose
	|
	|-RVA: 0x1D0B1C0 Offset: 0x1D0B2C1 VA: 0x1D0B1C0
	|-Array.EmptyInternalEnumerator<SpringBoneProperties>.Dispose
	|
	|-RVA: 0x1D0B3D0 Offset: 0x1D0B4D1 VA: 0x1D0B3D0
	|-Array.EmptyInternalEnumerator<SpringColliderComponents>.Dispose
	|
	|-RVA: 0x1D0B680 Offset: 0x1D0B781 VA: 0x1D0B680
	|-Array.EmptyInternalEnumerator<SpringColliderProperties>.Dispose
	|
	|-RVA: 0x1D0B870 Offset: 0x1D0B971 VA: 0x1D0B870
	|-Array.EmptyInternalEnumerator<SpringForceComponent>.Dispose
	|
	|-RVA: 0x1D0BA90 Offset: 0x1D0BB91 VA: 0x1D0BA90
	|-Array.EmptyInternalEnumerator<SpringJobElement>.Dispose
	|
	|-RVA: 0x1D0BCA0 Offset: 0x1D0BDA1 VA: 0x1D0BCA0
	|-Array.EmptyInternalEnumerator<SpriteState>.Dispose
	|
	|-RVA: 0x1D0BEA0 Offset: 0x1D0BFA1 VA: 0x1D0BEA0
	|-Array.EmptyInternalEnumerator<SubMeshDescriptor>.Dispose
	|
	|-RVA: 0x1D0C0B0 Offset: 0x1D0C1B1 VA: 0x1D0C0B0
	|-Array.EmptyInternalEnumerator<TMP_CharacterInfo>.Dispose
	|
	|-RVA: 0x1D0C2C0 Offset: 0x1D0C3C1 VA: 0x1D0C2C0
	|-Array.EmptyInternalEnumerator<TMP_FontWeightPair>.Dispose
	|
	|-RVA: 0x1D0C4B0 Offset: 0x1D0C5B1 VA: 0x1D0C4B0
	|-Array.EmptyInternalEnumerator<TMP_LineInfo>.Dispose
	|
	|-RVA: 0x1D0C730 Offset: 0x1D0C831 VA: 0x1D0C730
	|-Array.EmptyInternalEnumerator<TMP_LinkInfo>.Dispose
	|
	|-RVA: 0x1D0C940 Offset: 0x1D0CA41 VA: 0x1D0C940
	|-Array.EmptyInternalEnumerator<TMP_MeshInfo>.Dispose
	|
	|-RVA: 0x1D0CB90 Offset: 0x1D0CC91 VA: 0x1D0CB90
	|-Array.EmptyInternalEnumerator<TMP_PageInfo>.Dispose
	|
	|-RVA: 0x1D0CD90 Offset: 0x1D0CE91 VA: 0x1D0CD90
	|-Array.EmptyInternalEnumerator<TMP_WordInfo>.Dispose
	|
	|-RVA: 0x1D0CF90 Offset: 0x1D0D091 VA: 0x1D0CF90
	|-Array.EmptyInternalEnumerator<TablePair>.Dispose
	|
	|-RVA: 0x1D0D180 Offset: 0x1D0D281 VA: 0x1D0D180
	|-Array.EmptyInternalEnumerator<TextureHandle>.Dispose
	|
	|-RVA: 0x1D0D360 Offset: 0x1D0D461 VA: 0x1D0D360
	|-Array.EmptyInternalEnumerator<TimeSpan>.Dispose
	|
	|-RVA: 0x1D0D540 Offset: 0x1D0D641 VA: 0x1D0D540
	|-Array.EmptyInternalEnumerator<Touch>.Dispose
	|
	|-RVA: 0x1D0D790 Offset: 0x1D0D891 VA: 0x1D0D790
	|-Array.EmptyInternalEnumerator<TouchScreenState1>.Dispose
	|
	|-RVA: 0x1D0D9A0 Offset: 0x1D0DAA1 VA: 0x1D0D9A0
	|-Array.EmptyInternalEnumerator<TouchScreenState10>.Dispose
	|
	|-RVA: 0x1D0DBB0 Offset: 0x1D0DCB1 VA: 0x1D0DBB0
	|-Array.EmptyInternalEnumerator<TouchScreenState11>.Dispose
	|
	|-RVA: 0x1D0DDC0 Offset: 0x1D0DEC1 VA: 0x1D0DDC0
	|-Array.EmptyInternalEnumerator<TouchScreenState12>.Dispose
	|
	|-RVA: 0x1D0DFD0 Offset: 0x1D0E0D1 VA: 0x1D0DFD0
	|-Array.EmptyInternalEnumerator<TouchScreenState13>.Dispose
	|
	|-RVA: 0x1D0E1E0 Offset: 0x1D0E2E1 VA: 0x1D0E1E0
	|-Array.EmptyInternalEnumerator<TouchScreenState14>.Dispose
	|
	|-RVA: 0x1D0E3F0 Offset: 0x1D0E4F1 VA: 0x1D0E3F0
	|-Array.EmptyInternalEnumerator<TouchScreenState15>.Dispose
	|
	|-RVA: 0x1D0E600 Offset: 0x1D0E701 VA: 0x1D0E600
	|-Array.EmptyInternalEnumerator<TouchScreenState16>.Dispose
	|
	|-RVA: 0x1D0E810 Offset: 0x1D0E911 VA: 0x1D0E810
	|-Array.EmptyInternalEnumerator<TouchScreenState2>.Dispose
	|
	|-RVA: 0x1D0EA90 Offset: 0x1D0EB91 VA: 0x1D0EA90
	|-Array.EmptyInternalEnumerator<TouchScreenState3>.Dispose
	|
	|-RVA: 0x1D0ECA0 Offset: 0x1D0EDA1 VA: 0x1D0ECA0
	|-Array.EmptyInternalEnumerator<TouchScreenState4>.Dispose
	|
	|-RVA: 0x1D0EEB0 Offset: 0x1D0EFB1 VA: 0x1D0EEB0
	|-Array.EmptyInternalEnumerator<TouchScreenState5>.Dispose
	|
	|-RVA: 0x1D0F0C0 Offset: 0x1D0F1C1 VA: 0x1D0F0C0
	|-Array.EmptyInternalEnumerator<TouchScreenState6>.Dispose
	|
	|-RVA: 0x1D0F2D0 Offset: 0x1D0F3D1 VA: 0x1D0F2D0
	|-Array.EmptyInternalEnumerator<TouchScreenState7>.Dispose
	|
	|-RVA: 0x1D0F4E0 Offset: 0x1D0F5E1 VA: 0x1D0F4E0
	|-Array.EmptyInternalEnumerator<TouchScreenState8>.Dispose
	|
	|-RVA: 0x1D0F6F0 Offset: 0x1D0F7F1 VA: 0x1D0F6F0
	|-Array.EmptyInternalEnumerator<TouchScreenState9>.Dispose
	|
	|-RVA: 0x1D0F900 Offset: 0x1D0FA01 VA: 0x1D0F900
	|-Array.EmptyInternalEnumerator<TouchState>.Dispose
	|
	|-RVA: 0x1D0FB10 Offset: 0x1D0FC11 VA: 0x1D0FB10
	|-Array.EmptyInternalEnumerator<TrailHand>.Dispose
	|
	|-RVA: 0x1D0FD10 Offset: 0x1D0FE11 VA: 0x1D0FD10
	|-Array.EmptyInternalEnumerator<TrailVertex>.Dispose
	|
	|-RVA: 0x1D0FF10 Offset: 0x1D10011 VA: 0x1D0FF10
	|-Array.EmptyInternalEnumerator<UICharInfo>.Dispose
	|
	|-RVA: 0x1D10100 Offset: 0x1D10201 VA: 0x1D10100
	|-Array.EmptyInternalEnumerator<UILineInfo>.Dispose
	|
	|-RVA: 0x1D102F0 Offset: 0x1D103F1 VA: 0x1D102F0
	|-Array.EmptyInternalEnumerator<UIVertex>.Dispose
	|
	|-RVA: 0x1D10590 Offset: 0x1D10691 VA: 0x1D10590
	|-Array.EmptyInternalEnumerator<ushort>.Dispose
	|
	|-RVA: 0x1D10770 Offset: 0x1D10871 VA: 0x1D10770
	|-Array.EmptyInternalEnumerator<UInt16Enum>.Dispose
	|
	|-RVA: 0x1D10950 Offset: 0x1D10A51 VA: 0x1D10950
	|-Array.EmptyInternalEnumerator<uint>.Dispose
	|
	|-RVA: 0x1D10B30 Offset: 0x1D10C31 VA: 0x1D10B30
	|-Array.EmptyInternalEnumerator<UInt32Enum>.Dispose
	|
	|-RVA: 0x1D10D10 Offset: 0x1D10E11 VA: 0x1D10D10
	|-Array.EmptyInternalEnumerator<ulong>.Dispose
	|
	|-RVA: 0x1D10EF0 Offset: 0x1D10FF1 VA: 0x1D10EF0
	|-Array.EmptyInternalEnumerator<Uid>.Dispose
	|
	|-RVA: 0x1D110E0 Offset: 0x1D111E1 VA: 0x1D110E0
	|-Array.EmptyInternalEnumerator<UniTask>.Dispose
	|
	|-RVA: 0x1D112C0 Offset: 0x1D113C1 VA: 0x1D112C0
	|-Array.EmptyInternalEnumerator<Unit>.Dispose
	|
	|-RVA: 0x1D114A0 Offset: 0x1D115A1 VA: 0x1D114A0
	|-Array.EmptyInternalEnumerator<UnitEnum>.Dispose
	|
	|-RVA: 0x1D11680 Offset: 0x1D11781 VA: 0x1D11680
	|-Array.EmptyInternalEnumerator<UserWord>.Dispose
	|
	|-RVA: 0x1D11870 Offset: 0x1D11971 VA: 0x1D11870
	|-Array.EmptyInternalEnumerator<Vector2>.Dispose
	|
	|-RVA: 0x1D11A50 Offset: 0x1D11B51 VA: 0x1D11A50
	|-Array.EmptyInternalEnumerator<Vector2Int>.Dispose
	|
	|-RVA: 0x1D11C30 Offset: 0x1D11D31 VA: 0x1D11C30
	|-Array.EmptyInternalEnumerator<Vector3>.Dispose
	|
	|-RVA: 0x1D11E20 Offset: 0x1D11F21 VA: 0x1D11E20
	|-Array.EmptyInternalEnumerator<Vector4>.Dispose
	|
	|-RVA: 0x1D12010 Offset: 0x1D12111 VA: 0x1D12010
	|-Array.EmptyInternalEnumerator<VertexAttributeDescriptor>.Dispose
	|
	|-RVA: 0x1D12200 Offset: 0x1D12301 VA: 0x1D12200
	|-Array.EmptyInternalEnumerator<VibrationDeviceHandle>.Dispose
	|
	|-RVA: 0x1D123E0 Offset: 0x1D124E1 VA: 0x1D123E0
	|-Array.EmptyInternalEnumerator<VibrationDeviceInfo>.Dispose
	|
	|-RVA: 0x1D125C0 Offset: 0x1D126C1 VA: 0x1D125C0
	|-Array.EmptyInternalEnumerator<VibrationValue>.Dispose
	|
	|-RVA: 0x1D127B0 Offset: 0x1D128B1 VA: 0x1D127B0
	|-Array.EmptyInternalEnumerator<VisibleLight>.Dispose
	|
	|-RVA: 0x1D12A50 Offset: 0x1D12B51 VA: 0x1D12A50
	|-Array.EmptyInternalEnumerator<WordWrapState>.Dispose
	|
	|-RVA: 0x1D12C60 Offset: 0x1D12D61 VA: 0x1D12C60
	|-Array.EmptyInternalEnumerator<X509ChainStatus>.Dispose
	|
	|-RVA: 0x1D12E50 Offset: 0x1D12F51 VA: 0x1D12E50
	|-Array.EmptyInternalEnumerator<XPathNode>.Dispose
	|
	|-RVA: 0x1D13050 Offset: 0x1D13151 VA: 0x1D13050
	|-Array.EmptyInternalEnumerator<XPathNodeRef>.Dispose
	|
	|-RVA: 0x1D13240 Offset: 0x1D13341 VA: 0x1D13240
	|-Array.EmptyInternalEnumerator<XRView>.Dispose
	|
	|-RVA: 0x1D13450 Offset: 0x1D13551 VA: 0x1D13450
	|-Array.EmptyInternalEnumerator<float3>.Dispose
	|
	|-RVA: 0x1D13640 Offset: 0x1D13741 VA: 0x1D13640
	|-Array.EmptyInternalEnumerator<float4x4>.Dispose
	|
	|-RVA: 0x1D13860 Offset: 0x1D13961 VA: 0x1D13860
	|-Array.EmptyInternalEnumerator<jvalue>.Dispose
	|
	|-RVA: 0x1D13A40 Offset: 0x1D13B41 VA: 0x1D13A40
	|-Array.EmptyInternalEnumerator<uint4>.Dispose
	|
	|-RVA: 0x1D13C30 Offset: 0x1D13D31 VA: 0x1D13C30
	|-Array.EmptyInternalEnumerator<AICrossfire.PositionTable>.Dispose
	|
	|-RVA: 0x1D13E20 Offset: 0x1D13F21 VA: 0x1D13E20
	|-Array.EmptyInternalEnumerator<AIEnum.SkillRangeEnemyData>.Dispose
	|
	|-RVA: 0x1D14010 Offset: 0x1D14111 VA: 0x1D14010
	|-Array.EmptyInternalEnumerator<AIOrder.UnitPriority>.Dispose
	|
	|-RVA: 0x1D141F0 Offset: 0x1D142F1 VA: 0x1D141F0
	|-Array.EmptyInternalEnumerator<AmiiboSequence.GainItemData>.Dispose
	|
	|-RVA: 0x1D143E0 Offset: 0x1D144E1 VA: 0x1D143E0
	|-Array.EmptyInternalEnumerator<AnimationOutputWeightProcessor.WeightInfo>.Dispose
	|
	|-RVA: 0x1D145F0 Offset: 0x1D146F1 VA: 0x1D145F0
	|-Array.EmptyInternalEnumerator<ArenaOrderSequence.GodInfo>.Dispose
	|
	|-RVA: 0x1D147E0 Offset: 0x1D148E1 VA: 0x1D147E0
	|-Array.EmptyInternalEnumerator<BattleInfo.SupportData>.Dispose
	|
	|-RVA: 0x1D149D0 Offset: 0x1D14AD1 VA: 0x1D149D0
	|-Array.EmptyInternalEnumerator<BeforeRenderHelper.OrderBlock>.Dispose
	|
	|-RVA: 0x1D14BC0 Offset: 0x1D14CC1 VA: 0x1D14BC0
	|-Array.EmptyInternalEnumerator<Camera.RenderRequest>.Dispose
	|
	|-RVA: 0x1D14DC0 Offset: 0x1D14EC1 VA: 0x1D14DC0
	|-Array.EmptyInternalEnumerator<CameraState.CustomBlendable>.Dispose
	|
	|-RVA: 0x1D14FB0 Offset: 0x1D150B1 VA: 0x1D14FB0
	|-Array.EmptyInternalEnumerator<CinemachineBlendListCamera.Instruction>.Dispose
	|
	|-RVA: 0x1D151B0 Offset: 0x1D152B1 VA: 0x1D151B0
	|-Array.EmptyInternalEnumerator<CinemachineBlenderSettings.CustomBlend>.Dispose
	|
	|-RVA: 0x1D153B0 Offset: 0x1D154B1 VA: 0x1D153B0
	|-Array.EmptyInternalEnumerator<CinemachineClearShot.Pair>.Dispose
	|
	|-RVA: 0x1D15590 Offset: 0x1D15691 VA: 0x1D15590
	|-Array.EmptyInternalEnumerator<CinemachineFreeLook.Orbit>.Dispose
	|
	|-RVA: 0x1D15770 Offset: 0x1D15871 VA: 0x1D15770
	|-Array.EmptyInternalEnumerator<CinemachinePath.Waypoint>.Dispose
	|
	|-RVA: 0x1D15980 Offset: 0x1D15A81 VA: 0x1D15980
	|-Array.EmptyInternalEnumerator<CinemachineSmoothPath.Waypoint>.Dispose
	|
	|-RVA: 0x1D15B70 Offset: 0x1D15C71 VA: 0x1D15B70
	|-Array.EmptyInternalEnumerator<CinemachineStateDrivenCamera.HashPair>.Dispose
	|
	|-RVA: 0x1D15D50 Offset: 0x1D15E51 VA: 0x1D15D50
	|-Array.EmptyInternalEnumerator<CinemachineStateDrivenCamera.Instruction>.Dispose
	|
	|-RVA: 0x1D15F50 Offset: 0x1D16051 VA: 0x1D15F50
	|-Array.EmptyInternalEnumerator<CinemachineStateDrivenCamera.ParentHash>.Dispose
	|
	|-RVA: 0x1D16130 Offset: 0x1D16231 VA: 0x1D16130
	|-Array.EmptyInternalEnumerator<CinemachineTargetGroup.Target>.Dispose
	|
	|-RVA: 0x1D16320 Offset: 0x1D16421 VA: 0x1D16320
	|-Array.EmptyInternalEnumerator<CodePointIndexer.TableRange>.Dispose
	|
	|-RVA: 0x1D16520 Offset: 0x1D16621 VA: 0x1D16520
	|-Array.EmptyInternalEnumerator<ContentCatalogData.Bucket>.Dispose
	|
	|-RVA: 0x1D16710 Offset: 0x1D16811 VA: 0x1D16710
	|-Array.EmptyInternalEnumerator<CookieTokenizer.RecognizedAttribute>.Dispose
	|
	|-RVA: 0x1D16900 Offset: 0x1D16A01 VA: 0x1D16900
	|-Array.EmptyInternalEnumerator<DeferredLights.DrawCall>.Dispose
	|
	|-RVA: 0x1D16B10 Offset: 0x1D16C11 VA: 0x1D16B10
	|-Array.EmptyInternalEnumerator<DeferredShaderData.ComputeBufferInfo>.Dispose
	|
	|-RVA: 0x1D16CF0 Offset: 0x1D16DF1 VA: 0x1D16CF0
	|-Array.EmptyInternalEnumerator<DeferredTiler.PrePunctualLight>.Dispose
	|
	|-RVA: 0x1D16EF0 Offset: 0x1D16FF1 VA: 0x1D16EF0
	|-Array.EmptyInternalEnumerator<DelayedActionManager.DelegateInfo>.Dispose
	|
	|-RVA: 0x1D170F0 Offset: 0x1D171F1 VA: 0x1D170F0
	|-Array.EmptyInternalEnumerator<Detail.AsyncResultInt>.Dispose
	|
	|-RVA: 0x1D17300 Offset: 0x1D17401 VA: 0x1D17300
	|-Array.EmptyInternalEnumerator<Detail.CppArray>.Dispose
	|
	|-RVA: 0x1D174F0 Offset: 0x1D175F1 VA: 0x1D174F0
	|-Array.EmptyInternalEnumerator<Detail.NotificationEventInt>.Dispose
	|
	|-RVA: 0x1D17700 Offset: 0x1D17801 VA: 0x1D17700
	|-Array.EmptyInternalEnumerator<DisposUnit.Item>.Dispose
	|
	|-RVA: 0x1D178F0 Offset: 0x1D179F1 VA: 0x1D178F0
	|-Array.EmptyInternalEnumerator<DragonRidePresetParamData.CourseData>.Dispose
	|
	|-RVA: 0x1D17AE0 Offset: 0x1D17BE1 VA: 0x1D17AE0
	|-Array.EmptyInternalEnumerator<DragonRideTargetGroup.ChainParam>.Dispose
	|
	|-RVA: 0x1D17CD0 Offset: 0x1D17DD1 VA: 0x1D17CD0
	|-Array.EmptyInternalEnumerator<DynamicMesh.State>.Dispose
	|
	|-RVA: 0x1D17EB0 Offset: 0x1D17FB1 VA: 0x1D17EB0
	|-Array.EmptyInternalEnumerator<FXZEx.HitPoint>.Dispose
	|
	|-RVA: 0x1D180C0 Offset: 0x1D181C1 VA: 0x1D180C0
	|-Array.EmptyInternalEnumerator<FishingRadicalParamData.RadicalParam>.Dispose
	|
	|-RVA: 0x1D182B0 Offset: 0x1D183B1 VA: 0x1D182B0
	|-Array.EmptyInternalEnumerator<GameVariable.Value>.Dispose
	|
	|-RVA: 0x1D184A0 Offset: 0x1D185A1 VA: 0x1D184A0
	|-Array.EmptyInternalEnumerator<GmapPathAdjuster.TargetModel>.Dispose
	|
	|-RVA: 0x1D186A0 Offset: 0x1D187A1 VA: 0x1D186A0
	|-Array.EmptyInternalEnumerator<GmapSpotAdjuster.TargetModel>.Dispose
	|
	|-RVA: 0x1D188A0 Offset: 0x1D189A1 VA: 0x1D188A0
	|-Array.EmptyInternalEnumerator<GrounderQuadruped.Foot>.Dispose
	|
	|-RVA: 0x1D18AB0 Offset: 0x1D18BB1 VA: 0x1D18AB0
	|-Array.EmptyInternalEnumerator<Hashtable.bucket>.Dispose
	|
	|-RVA: 0x1D18CB0 Offset: 0x1D18DB1 VA: 0x1D18CB0
	|-Array.EmptyInternalEnumerator<HeadingTracker.Item>.Dispose
	|
	|-RVA: 0x1D18EB0 Offset: 0x1D18FB1 VA: 0x1D18EB0
	|-Array.EmptyInternalEnumerator<HubAccessoryRoomCamera.BackgroundSettings>.Dispose
	|
	|-RVA: 0x1D190C0 Offset: 0x1D191C1 VA: 0x1D190C0
	|-Array.EmptyInternalEnumerator<HubFastTravel.Location>.Dispose
	|
	|-RVA: 0x1D192C0 Offset: 0x1D193C1 VA: 0x1D192C0
	|-Array.EmptyInternalEnumerator<HubLensFlare.Flare>.Dispose
	|
	|-RVA: 0x1D194D0 Offset: 0x1D195D1 VA: 0x1D194D0
	|-Array.EmptyInternalEnumerator<HubLookAtController.LookAtIKParam>.Dispose
	|
	|-RVA: 0x1D196C0 Offset: 0x1D197C1 VA: 0x1D196C0
	|-Array.EmptyInternalEnumerator<HubMaterialArray.MaterialInfo>.Dispose
	|
	|-RVA: 0x1D198B0 Offset: 0x1D199B1 VA: 0x1D198B0
	|-Array.EmptyInternalEnumerator<IKSolverLimb.AxisDirection>.Dispose
	|
	|-RVA: 0x1D19AC0 Offset: 0x1D19BC1 VA: 0x1D19AC0
	|-Array.EmptyInternalEnumerator<InventoryPoolItemMenuContent.KindBgNameClass>.Dispose
	|
	|-RVA: 0x1D19CB0 Offset: 0x1D19DB1 VA: 0x1D19CB0
	|-Array.EmptyInternalEnumerator<LightUtility.ParametricLightMeshVertex>.Dispose
	|
	|-RVA: 0x1D19EC0 Offset: 0x1D19FC1 VA: 0x1D19EC0
	|-Array.EmptyInternalEnumerator<LightUtility.SpriteLightMeshVertex>.Dispose
	|
	|-RVA: 0x1D1A0D0 Offset: 0x1D1A1D1 VA: 0x1D1A0D0
	|-Array.EmptyInternalEnumerator<Map.Pos>.Dispose
	|
	|-RVA: 0x1D1A2B0 Offset: 0x1D1A3B1 VA: 0x1D1A2B0
	|-Array.EmptyInternalEnumerator<MapGodExp.KindDesc>.Dispose
	|
	|-RVA: 0x1D1A4A0 Offset: 0x1D1A5A1 VA: 0x1D1A4A0
	|-Array.EmptyInternalEnumerator<MapHistory.Command>.Dispose
	|
	|-RVA: 0x1D1A680 Offset: 0x1D1A781 VA: 0x1D1A680
	|-Array.EmptyInternalEnumerator<MapImage.BackupTerrain>.Dispose
	|
	|-RVA: 0x1D1A870 Offset: 0x1D1A971 VA: 0x1D1A870
	|-Array.EmptyInternalEnumerator<MapImageRange.Pos>.Dispose
	|
	|-RVA: 0x1D1AA50 Offset: 0x1D1AB51 VA: 0x1D1AA50
	|-Array.EmptyInternalEnumerator<MapKillBonus.KillBonus>.Dispose
	|
	|-RVA: 0x1D1AC30 Offset: 0x1D1AD31 VA: 0x1D1AC30
	|-Array.EmptyInternalEnumerator<MapKillBonus.KilledBonus>.Dispose
	|
	|-RVA: 0x1D1AE10 Offset: 0x1D1AF11 VA: 0x1D1AE10
	|-Array.EmptyInternalEnumerator<MapMind.Record>.Dispose
	|
	|-RVA: 0x1D1B060 Offset: 0x1D1B161 VA: 0x1D1B060
	|-Array.EmptyInternalEnumerator<MapMind.Target>.Dispose
	|
	|-RVA: 0x1D1B260 Offset: 0x1D1B361 VA: 0x1D1B260
	|-Array.EmptyInternalEnumerator<MapPanelDebug.Entity>.Dispose
	|
	|-RVA: 0x1D1B460 Offset: 0x1D1B561 VA: 0x1D1B460
	|-Array.EmptyInternalEnumerator<NexRanking.Data>.Dispose
	|
	|-RVA: 0x1D1B640 Offset: 0x1D1B741 VA: 0x1D1B640
	|-Array.EmptyInternalEnumerator<NexVersus.RatingData>.Dispose
	|
	|-RVA: 0x1D1B830 Offset: 0x1D1B931 VA: 0x1D1B830
	|-Array.EmptyInternalEnumerator<NoiseSettings.TransformNoiseParams>.Dispose
	|
	|-RVA: 0x1D1BA40 Offset: 0x1D1BB41 VA: 0x1D1BA40
	|-Array.EmptyInternalEnumerator<PackedPlayModeBuildLogs.RuntimeBuildLog>.Dispose
	|
	|-RVA: 0x1D1BC30 Offset: 0x1D1BD31 VA: 0x1D1BC30
	|-Array.EmptyInternalEnumerator<ParameterizedStrings.FormatParam>.Dispose
	|
	|-RVA: 0x1D1BE20 Offset: 0x1D1BF21 VA: 0x1D1BE20
	|-Array.EmptyInternalEnumerator<ParticleSystem.Particle>.Dispose
	|
	|-RVA: 0x1D1C030 Offset: 0x1D1C131 VA: 0x1D1C030
	|-Array.EmptyInternalEnumerator<ProfileCard.Achievement>.Dispose
	|
	|-RVA: 0x1D1C210 Offset: 0x1D1C311 VA: 0x1D1C210
	|-Array.EmptyInternalEnumerator<ProfileCard.SortieCount>.Dispose
	|
	|-RVA: 0x1D1C410 Offset: 0x1D1C511 VA: 0x1D1C410
	|-Array.EmptyInternalEnumerator<QualitySettingsStack.Settings>.Dispose
	|
	|-RVA: 0x1D1C620 Offset: 0x1D1C721 VA: 0x1D1C620
	|-Array.EmptyInternalEnumerator<RangeData.Offset>.Dispose
	|
	|-RVA: 0x1D1C800 Offset: 0x1D1C901 VA: 0x1D1C800
	|-Array.EmptyInternalEnumerator<RegexCharClass.LowerCaseMapping>.Dispose
	|
	|-RVA: 0x1D1C9F0 Offset: 0x1D1CAF1 VA: 0x1D1C9F0
	|-Array.EmptyInternalEnumerator<Relay.ChooseAwardeeData>.Dispose
	|
	|-RVA: 0x1D1CBF0 Offset: 0x1D1CCF1 VA: 0x1D1CBF0
	|-Array.EmptyInternalEnumerator<RelayAwardData.Info>.Dispose
	|
	|-RVA: 0x1D1CDE0 Offset: 0x1D1CEE1 VA: 0x1D1CDE0
	|-Array.EmptyInternalEnumerator<RenderGraph.CompiledPassInfo>.Dispose
	|
	|-RVA: 0x1D1D030 Offset: 0x1D1D131 VA: 0x1D1D030
	|-Array.EmptyInternalEnumerator<RenderGraph.CompiledResourceInfo>.Dispose
	|
	|-RVA: 0x1D1D230 Offset: 0x1D1D331 VA: 0x1D1D230
	|-Array.EmptyInternalEnumerator<RenderGraphDebugData.PassDebugData>.Dispose
	|
	|-RVA: 0x1D1D430 Offset: 0x1D1D531 VA: 0x1D1D430
	|-Array.EmptyInternalEnumerator<RenderGraphDebugData.ResourceDebugData>.Dispose
	|
	|-RVA: 0x1D1D640 Offset: 0x1D1D741 VA: 0x1D1D640
	|-Array.EmptyInternalEnumerator<RenderGraphResourceRegistry.RendererListResource>.Dispose
	|
	|-RVA: 0x1D1D850 Offset: 0x1D1D951 VA: 0x1D1D850
	|-Array.EmptyInternalEnumerator<RingCleaningUnitSelectMenu.GodParam>.Dispose
	|
	|-RVA: 0x1D1DA40 Offset: 0x1D1DB41 VA: 0x1D1DA40
	|-Array.EmptyInternalEnumerator<SampleWave.Data>.Dispose
	|
	|-RVA: 0x1D1DC30 Offset: 0x1D1DD31 VA: 0x1D1DC30
	|-Array.EmptyInternalEnumerator<SampleWave.Temp>.Dispose
	|
	|-RVA: 0x1D1DE10 Offset: 0x1D1DF11 VA: 0x1D1DE10
	|-Array.EmptyInternalEnumerator<SendMouseEvents.HitInfo>.Dispose
	|
	|-RVA: 0x1D1E000 Offset: 0x1D1E101 VA: 0x1D1E000
	|-Array.EmptyInternalEnumerator<SequenceNode.SequenceConstructPosContext>.Dispose
	|
	|-RVA: 0x1D1E210 Offset: 0x1D1E311 VA: 0x1D1E210
	|-Array.EmptyInternalEnumerator<ShaderInput.LightData>.Dispose
	|
	|-RVA: 0x1D1E460 Offset: 0x1D1E561 VA: 0x1D1E460
	|-Array.EmptyInternalEnumerator<ShaderInput.ShadowData>.Dispose
	|
	|-RVA: 0x1D1E6B0 Offset: 0x1D1E7B1 VA: 0x1D1E6B0
	|-Array.EmptyInternalEnumerator<ShadowUtility.Edge>.Dispose
	|
	|-RVA: 0x1D1E8C0 Offset: 0x1D1E9C1 VA: 0x1D1E8C0
	|-Array.EmptyInternalEnumerator<SimpleAnimationPlayable.QueuedState>.Dispose
	|
	|-RVA: 0x1D1EAB0 Offset: 0x1D1EBB1 VA: 0x1D1EAB0
	|-Array.EmptyInternalEnumerator<SkillArray.Entity>.Dispose
	|
	|-RVA: 0x1D1EC90 Offset: 0x1D1ED91 VA: 0x1D1EC90
	|-Array.EmptyInternalEnumerator<Socket.WSABUF>.Dispose
	|
	|-RVA: 0x1D1EE80 Offset: 0x1D1EF81 VA: 0x1D1EE80
	|-Array.EmptyInternalEnumerator<Stream.Info>.Dispose
	|
	|-RVA: 0x1D1F070 Offset: 0x1D1F171 VA: 0x1D1F070
	|-Array.EmptyInternalEnumerator<TMP_Text.UnicodeChar>.Dispose
	|
	|-RVA: 0x1D1F260 Offset: 0x1D1F361 VA: 0x1D1F260
	|-Array.EmptyInternalEnumerator<TexturePacker_JsonArray.Frame>.Dispose
	|
	|-RVA: 0x1D1F480 Offset: 0x1D1F581 VA: 0x1D1F480
	|-Array.EmptyInternalEnumerator<TimeNotificationBehaviour.NotificationEntry>.Dispose
	|
	|-RVA: 0x1D1F680 Offset: 0x1D1F781 VA: 0x1D1F680
	|-Array.EmptyInternalEnumerator<UnitySynchronizationContext.WorkRequest>.Dispose
	|
	|-RVA: 0x1D1F880 Offset: 0x1D1F981 VA: 0x1D1F880
	|-Array.EmptyInternalEnumerator<XmlNamespaceManager.NamespaceDeclaration>.Dispose
	|
	|-RVA: 0x1D1FA80 Offset: 0x1D1FB81 VA: 0x1D1FA80
	|-Array.EmptyInternalEnumerator<XmlSchemaObjectTable.XmlSchemaObjectEntry>.Dispose
	|
	|-RVA: 0x1D1FC70 Offset: 0x1D1FD71 VA: 0x1D1FC70
	|-Array.EmptyInternalEnumerator<XmlTextReaderImpl.ParsingState>.Dispose
	|
	|-RVA: 0x1D1FF10 Offset: 0x1D20011 VA: 0x1D1FF10
	|-Array.EmptyInternalEnumerator<AIThink.EnchantThink.Desc>.Dispose
	|
	|-RVA: 0x1D20100 Offset: 0x1D20201 VA: 0x1D20100
	|-Array.EmptyInternalEnumerator<AIThink.EnchantThink.ItemInfo>.Dispose
	|
	|-RVA: 0x1D202E0 Offset: 0x1D203E1 VA: 0x1D202E0
	|-Array.EmptyInternalEnumerator<AIThink.EnchantThink.SurroundingInfo>.Dispose
	|
	|-RVA: 0x1D204C0 Offset: 0x1D205C1 VA: 0x1D204C0
	|-Array.EmptyInternalEnumerator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.Dispose
	|
	|-RVA: 0x1D206B0 Offset: 0x1D207B1 VA: 0x1D206B0
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStoreChangeMetaParamInt>.Dispose
	|
	|-RVA: 0x1D208C0 Offset: 0x1D209C1 VA: 0x1D208C0
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStoreDeleteParamInt>.Dispose
	|
	|-RVA: 0x1D20AB0 Offset: 0x1D20BB1 VA: 0x1D20AB0
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStoreGetMetaParamInt>.Dispose
	|
	|-RVA: 0x1D20CC0 Offset: 0x1D20DC1 VA: 0x1D20CC0
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStoreMetaInfoInt>.Dispose
	|
	|-RVA: 0x1D20ED0 Offset: 0x1D20FD1 VA: 0x1D20ED0
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStorePasswordInfoInt>.Dispose
	|
	|-RVA: 0x1D210D0 Offset: 0x1D211D1 VA: 0x1D210D0
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStorePersistenceInfoInt>.Dispose
	|
	|-RVA: 0x1D212D0 Offset: 0x1D213D1 VA: 0x1D212D0
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStorePreparePostParamInt>.Dispose
	|
	|-RVA: 0x1D214E0 Offset: 0x1D215E1 VA: 0x1D214E0
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStoreRateObjectParamInt>.Dispose
	|
	|-RVA: 0x1D216D0 Offset: 0x1D217D1 VA: 0x1D216D0
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStoreRatingInitParamInt>.Dispose
	|
	|-RVA: 0x1D218D0 Offset: 0x1D219D1 VA: 0x1D218D0
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStoreRatingTargetInt>.Dispose
	|
	|-RVA: 0x1D21AC0 Offset: 0x1D21BC1 VA: 0x1D21AC0
	|-Array.EmptyInternalEnumerator<Detail.Ranking.RankingCachedResultInt>.Dispose
	|
	|-RVA: 0x1D21CD0 Offset: 0x1D21DD1 VA: 0x1D21CD0
	|-Array.EmptyInternalEnumerator<Detail.Ranking.RankingOrderParamInt>.Dispose
	|
	|-RVA: 0x1D21EC0 Offset: 0x1D21FC1 VA: 0x1D21EC0
	|-Array.EmptyInternalEnumerator<Detail.Ranking.RankingRankDataInt>.Dispose
	|
	|-RVA: 0x1D220E0 Offset: 0x1D221E1 VA: 0x1D220E0
	|-Array.EmptyInternalEnumerator<Detail.Ranking2.Ranking2ChartInfoInt>.Dispose
	|
	|-RVA: 0x1D22360 Offset: 0x1D22461 VA: 0x1D22360
	|-Array.EmptyInternalEnumerator<Detail.Ranking2.Ranking2RankDataInt>.Dispose
	|
	|-RVA: 0x1D22580 Offset: 0x1D22681 VA: 0x1D22580
	|-Array.EmptyInternalEnumerator<Detail.Ranking2.Ranking2ScoreDataInt>.Dispose
	|
	|-RVA: 0x1D22770 Offset: 0x1D22871 VA: 0x1D22770
	|-Array.EmptyInternalEnumerator<Detail.Screening.ScreeningContextInfoInt>.Dispose
	|
	|-RVA: 0x1D22970 Offset: 0x1D22A71 VA: 0x1D22970
	|-Array.EmptyInternalEnumerator<Detail.Subscriber.SubscriberContentInt>.Dispose
	|
	|-RVA: 0x1D22BC0 Offset: 0x1D22CC1 VA: 0x1D22BC0
	|-Array.EmptyInternalEnumerator<Detail.Subscriber.SubscriberGetContentParamInt>.Dispose
	|
	|-RVA: 0x1D22DC0 Offset: 0x1D22EC1 VA: 0x1D22DC0
	|-Array.EmptyInternalEnumerator<Detail.Subscriber.SubscriberUserStatusInfoInt>.Dispose
	|
	|-RVA: 0x1D22FD0 Offset: 0x1D230D1 VA: 0x1D22FD0
	|-Array.EmptyInternalEnumerator<Detail.Subscriber.SubscriberUserStatusParamInt>.Dispose
	|
	|-RVA: 0x1D231D0 Offset: 0x1D232D1 VA: 0x1D231D0
	|-Array.EmptyInternalEnumerator<Detail.Utility.IntegerSettings>.Dispose
	|
	|-RVA: 0x1D233B0 Offset: 0x1D234B1 VA: 0x1D233B0
	|-Array.EmptyInternalEnumerator<Detail.Utility.UniqueIdInfoInt>.Dispose
	|
	|-RVA: 0x1D235A0 Offset: 0x1D236A1 VA: 0x1D235A0
	|-Array.EmptyInternalEnumerator<FacetsChecker.FacetsCompiler.Map>.Dispose
	|
	|-RVA: 0x1D23790 Offset: 0x1D23891 VA: 0x1D23790
	|-Array.EmptyInternalEnumerator<MapHistory.ReplayAppearanceMap.Appearance>.Dispose
	|
	|-RVA: 0x1D23990 Offset: 0x1D23A91 VA: 0x1D23990
	|-Array.EmptyInternalEnumerator<MapHistory.ReplayAppearanceMap.Leaving>.Dispose
	|
	|-RVA: 0x1D23B70 Offset: 0x1D23C71 VA: 0x1D23B70
	|-Array.EmptyInternalEnumerator<MapHistory.ReplayUnitMap.Data>.Dispose
	|
	|-RVA: 0x1D23D50 Offset: 0x1D23E51 VA: 0x1D23D50
	|-Array.EmptyInternalEnumerator<MapHistory.Rewind.LatestInspectorData>.Dispose
	|
	|-RVA: 0x1D23F40 Offset: 0x1D24041 VA: 0x1D23F40
	|-Array.EmptyInternalEnumerator<MapHistory.Rewind.WorkTerrainData>.Dispose
	|
	|-RVA: 0x1D24130 Offset: 0x1D24231 VA: 0x1D24130
	|-Array.EmptyInternalEnumerator<MapHistory.RewindUnitMap.Data>.Dispose
	|
	|-RVA: 0x1D24340 Offset: 0x1D24441 VA: 0x1D24340
	|-Array.EmptyInternalEnumerator<MapKillBonus.Work.Pos>.Dispose
	|
	|-RVA: 0x1D24520 Offset: 0x1D24621 VA: 0x1D24520
	|-Array.EmptyInternalEnumerator<MapSkill.AroundCalculator.Result>.Dispose
	|
	|-RVA: 0x1D24710 Offset: 0x1D24811 VA: 0x1D24710
	|-Array.EmptyInternalEnumerator<Nex.ApiCallChecker.Guideline>.Dispose
	|
	|-RVA: 0x1D248F0 Offset: 0x1D249F1 VA: 0x1D248F0
	|-Array.EmptyInternalEnumerator<Ngc.MaskTextSequenceBase.Data>.Dispose
	|
	|-RVA: 0x1D24AF0 Offset: 0x1D24BF1 VA: 0x1D24AF0
	|-Array.EmptyInternalEnumerator<TargetPositionCache.CacheCurve.Item>.Dispose
	|
	|-RVA: 0x1D24D00 Offset: 0x1D24E01 VA: 0x1D24D00
	|-Array.EmptyInternalEnumerator<TargetPositionCache.CacheEntry.RecordingItem>.Dispose
	|
	|-RVA: 0x1D24F10 Offset: 0x1D25011 VA: 0x1D24F10
	|-Array.EmptyInternalEnumerator<TerrainUtility.TerrainMap.TileCoord>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x263E500 Offset: 0x263E601 VA: 0x263E500
	|-Array.EmptyInternalEnumerator<ArraySegment<byte>>.MoveNext
	|
	|-RVA: 0x263E6F0 Offset: 0x263E7F1 VA: 0x263E6F0
	|-Array.EmptyInternalEnumerator<AsyncOperationHandle<object>>.MoveNext
	|
	|-RVA: 0x263E8F0 Offset: 0x263E9F1 VA: 0x263E8F0
	|-Array.EmptyInternalEnumerator<MapDeployTemplate.Queue.Data<object>>.MoveNext
	|
	|-RVA: 0x263EAD0 Offset: 0x263EBD1 VA: 0x263EAD0
	|-Array.EmptyInternalEnumerator<Nex.DataStore.ParamPool.Data<object>>.MoveNext
	|
	|-RVA: 0x263ECC0 Offset: 0x263EDC1 VA: 0x263ECC0
	|-Array.EmptyInternalEnumerator<Nex.Screening.ParamPool.Data<object>>.MoveNext
	|
	|-RVA: 0x263EEB0 Offset: 0x263EFB1 VA: 0x263EEB0
	|-Array.EmptyInternalEnumerator<IntervalTree.Entry<object>>.MoveNext
	|
	|-RVA: 0x263F0B0 Offset: 0x263F1B1 VA: 0x263F0B0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<ValueTuple<object, int>, object>>.MoveNext
	|
	|-RVA: 0x263F2B0 Offset: 0x263F3B1 VA: 0x263F2B0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<byte, object>>.MoveNext
	|
	|-RVA: 0x263F4B0 Offset: 0x263F5B1 VA: 0x263F4B0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<CancellationToken, object>>.MoveNext
	|
	|-RVA: 0x263F6B0 Offset: 0x263F7B1 VA: 0x263F6B0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<char, object>>.MoveNext
	|
	|-RVA: 0x263F8B0 Offset: 0x263F9B1 VA: 0x263F8B0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Guid, object>>.MoveNext
	|
	|-RVA: 0x263FAB0 Offset: 0x263FBB1 VA: 0x263FAB0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, bool>>.MoveNext
	|
	|-RVA: 0x263FCA0 Offset: 0x263FDA1 VA: 0x263FCA0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, byte>>.MoveNext
	|
	|-RVA: 0x263FE90 Offset: 0x263FF91 VA: 0x263FE90
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, char>>.MoveNext
	|
	|-RVA: 0x2640080 Offset: 0x2640181 VA: 0x2640080
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, DiagnosticEvent>>.MoveNext
	|
	|-RVA: 0x26402A0 Offset: 0x26403A1 VA: 0x26402A0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, int>>.MoveNext
	|
	|-RVA: 0x2640490 Offset: 0x2640591 VA: 0x2640490
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, Int32Enum>>.MoveNext
	|
	|-RVA: 0x2640680 Offset: 0x2640781 VA: 0x2640680
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, long>>.MoveNext
	|
	|-RVA: 0x2640880 Offset: 0x2640981 VA: 0x2640880
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, MapPos>>.MoveNext
	|
	|-RVA: 0x2640A80 Offset: 0x2640B81 VA: 0x2640A80
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, object>>.MoveNext
	|
	|-RVA: 0x2640C80 Offset: 0x2640D81 VA: 0x2640C80
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, uint>>.MoveNext
	|
	|-RVA: 0x2640E70 Offset: 0x2640F71 VA: 0x2640E70
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, AIThink.EnchantThink.SurroundingInfo>>.MoveNext
	|
	|-RVA: 0x2641060 Offset: 0x2641161 VA: 0x2641060
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, bool>>.MoveNext
	|
	|-RVA: 0x2641250 Offset: 0x2641351 VA: 0x2641250
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, int>>.MoveNext
	|
	|-RVA: 0x2641440 Offset: 0x2641541 VA: 0x2641440
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, Int32Enum>>.MoveNext
	|
	|-RVA: 0x2641630 Offset: 0x2641731 VA: 0x2641630
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, object>>.MoveNext
	|
	|-RVA: 0x2641830 Offset: 0x2641931 VA: 0x2641830
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<long, object>>.MoveNext
	|
	|-RVA: 0x2641A30 Offset: 0x2641B31 VA: 0x2641A30
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<MapPos, int>>.MoveNext
	|
	|-RVA: 0x2641C30 Offset: 0x2641D31 VA: 0x2641C30
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, AsyncOperationHandle<object>>>.MoveNext
	|
	|-RVA: 0x2641E40 Offset: 0x2641F41 VA: 0x2641E40
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, AsyncOperationHandle>>.MoveNext
	|
	|-RVA: 0x2642050 Offset: 0x2642151 VA: 0x2642050
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, bool>>.MoveNext
	|
	|-RVA: 0x2642250 Offset: 0x2642351 VA: 0x2642250
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, byte>>.MoveNext
	|
	|-RVA: 0x2642450 Offset: 0x2642551 VA: 0x2642450
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, int>>.MoveNext
	|
	|-RVA: 0x2642650 Offset: 0x2642751 VA: 0x2642650
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Int32Enum>>.MoveNext
	|
	|-RVA: 0x2642850 Offset: 0x2642951 VA: 0x2642850
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, IntPtr>>.MoveNext
	|
	|-RVA: 0x2642A50 Offset: 0x2642B51 VA: 0x2642A50
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, object>>.MoveNext
	|
	|-RVA: 0x2642C50 Offset: 0x2642D51 VA: 0x2642C50
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Playable>>.MoveNext
	|
	|-RVA: 0x2642E50 Offset: 0x2642F51 VA: 0x2642E50
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, ResourceLocator>>.MoveNext
	|
	|-RVA: 0x2643050 Offset: 0x2643151 VA: 0x2643050
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, float>>.MoveNext
	|
	|-RVA: 0x2643250 Offset: 0x2643351 VA: 0x2643250
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, ushort>>.MoveNext
	|
	|-RVA: 0x2643450 Offset: 0x2643551 VA: 0x2643450
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, GameVariable.Value>>.MoveNext
	|
	|-RVA: 0x2643650 Offset: 0x2643751 VA: 0x2643650
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<sbyte, DataStoreRatingInfo>>.MoveNext
	|
	|-RVA: 0x2643860 Offset: 0x2643961 VA: 0x2643860
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<sbyte, object>>.MoveNext
	|
	|-RVA: 0x2643A60 Offset: 0x2643B61 VA: 0x2643A60
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<ushort, int>>.MoveNext
	|
	|-RVA: 0x2643C50 Offset: 0x2643D51 VA: 0x2643C50
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<uint, int>>.MoveNext
	|
	|-RVA: 0x2643E40 Offset: 0x2643F41 VA: 0x2643E40
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<uint, object>>.MoveNext
	|
	|-RVA: 0x2644040 Offset: 0x2644141 VA: 0x2644040
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<ulong, Friend>>.MoveNext
	|
	|-RVA: 0x2644250 Offset: 0x2644351 VA: 0x2644250
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<ulong, Int32Enum>>.MoveNext
	|
	|-RVA: 0x2644450 Offset: 0x2644551 VA: 0x2644450
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<ulong, object>>.MoveNext
	|
	|-RVA: 0x2644650 Offset: 0x2644751 VA: 0x2644650
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Vector3, int>>.MoveNext
	|
	|-RVA: 0x2644850 Offset: 0x2644951 VA: 0x2644850
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<XPathNodeRef, XPathNodeRef>>.MoveNext
	|
	|-RVA: 0x2644A60 Offset: 0x2644B61 VA: 0x2644A60
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<TerrainUtility.TerrainMap.TileCoord, object>>.MoveNext
	|
	|-RVA: 0x2644C60 Offset: 0x2644D61 VA: 0x2644C60
	|-Array.EmptyInternalEnumerator<PriorityQueue.IndexedItem<object>>.MoveNext
	|
	|-RVA: 0x2644E50 Offset: 0x2644F51 VA: 0x2644E50
	|-Array.EmptyInternalEnumerator<KeyValuePair<ValueTuple<object, int>, object>>.MoveNext
	|
	|-RVA: 0x2645050 Offset: 0x2645151 VA: 0x2645050
	|-Array.EmptyInternalEnumerator<KeyValuePair<byte, object>>.MoveNext
	|
	|-RVA: 0x2645240 Offset: 0x2645341 VA: 0x2645240
	|-Array.EmptyInternalEnumerator<KeyValuePair<CancellationToken, object>>.MoveNext
	|
	|-RVA: 0x2645430 Offset: 0x2645531 VA: 0x2645430
	|-Array.EmptyInternalEnumerator<KeyValuePair<char, object>>.MoveNext
	|
	|-RVA: 0x2645620 Offset: 0x2645721 VA: 0x2645620
	|-Array.EmptyInternalEnumerator<KeyValuePair<DateTime, object>>.MoveNext
	|
	|-RVA: 0x2645810 Offset: 0x2645911 VA: 0x2645810
	|-Array.EmptyInternalEnumerator<KeyValuePair<Guid, object>>.MoveNext
	|
	|-RVA: 0x2645A10 Offset: 0x2645B11 VA: 0x2645A10
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, bool>>.MoveNext
	|
	|-RVA: 0x2645BF0 Offset: 0x2645CF1 VA: 0x2645BF0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, byte>>.MoveNext
	|
	|-RVA: 0x2645DD0 Offset: 0x2645ED1 VA: 0x2645DD0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, char>>.MoveNext
	|
	|-RVA: 0x2645FB0 Offset: 0x26460B1 VA: 0x2645FB0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, DiagnosticEvent>>.MoveNext
	|
	|-RVA: 0x26461C0 Offset: 0x26462C1 VA: 0x26461C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, int>>.MoveNext
	|
	|-RVA: 0x26463A0 Offset: 0x26464A1 VA: 0x26463A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, Int32Enum>>.MoveNext
	|
	|-RVA: 0x2646580 Offset: 0x2646681 VA: 0x2646580
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, long>>.MoveNext
	|
	|-RVA: 0x2646770 Offset: 0x2646871 VA: 0x2646770
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, MapPos>>.MoveNext
	|
	|-RVA: 0x2646960 Offset: 0x2646A61 VA: 0x2646960
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, object>>.MoveNext
	|
	|-RVA: 0x2646B50 Offset: 0x2646C51 VA: 0x2646B50
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, uint>>.MoveNext
	|
	|-RVA: 0x2646D30 Offset: 0x2646E31 VA: 0x2646D30
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, AIThink.EnchantThink.SurroundingInfo>>.MoveNext
	|
	|-RVA: 0x2646F10 Offset: 0x2647011 VA: 0x2646F10
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, bool>>.MoveNext
	|
	|-RVA: 0x26470F0 Offset: 0x26471F1 VA: 0x26470F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, int>>.MoveNext
	|
	|-RVA: 0x26472D0 Offset: 0x26473D1 VA: 0x26472D0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, Int32Enum>>.MoveNext
	|
	|-RVA: 0x26474B0 Offset: 0x26475B1 VA: 0x26474B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, object>>.MoveNext
	|
	|-RVA: 0x26476A0 Offset: 0x26477A1 VA: 0x26476A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<long, object>>.MoveNext
	|
	|-RVA: 0x2647890 Offset: 0x2647991 VA: 0x2647890
	|-Array.EmptyInternalEnumerator<KeyValuePair<MapPos, int>>.MoveNext
	|
	|-RVA: 0x2647A80 Offset: 0x2647B81 VA: 0x2647A80
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, AsyncOperationHandle<object>>>.MoveNext
	|
	|-RVA: 0x2647C80 Offset: 0x2647D81 VA: 0x2647C80
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.MoveNext
	|
	|-RVA: 0x2647E80 Offset: 0x2647F81 VA: 0x2647E80
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, AsyncOperationHandle>>.MoveNext
	|
	|-RVA: 0x2648080 Offset: 0x2648181 VA: 0x2648080
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, bool>>.MoveNext
	|
	|-RVA: 0x2648270 Offset: 0x2648371 VA: 0x2648270
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, byte>>.MoveNext
	|
	|-RVA: 0x2648460 Offset: 0x2648561 VA: 0x2648460
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, int>>.MoveNext
	|
	|-RVA: 0x2648650 Offset: 0x2648751 VA: 0x2648650
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Int32Enum>>.MoveNext
	|
	|-RVA: 0x2648840 Offset: 0x2648941 VA: 0x2648840
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, IntPtr>>.MoveNext
	|
	|-RVA: 0x2648A30 Offset: 0x2648B31 VA: 0x2648A30
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, object>>.MoveNext
	|
	|-RVA: 0x2648C20 Offset: 0x2648D21 VA: 0x2648C20
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Playable>>.MoveNext
	|
	|-RVA: 0x2648E20 Offset: 0x2648F21 VA: 0x2648E20
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, ResourceLocator>>.MoveNext
	|
	|-RVA: 0x2649020 Offset: 0x2649121 VA: 0x2649020
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, float>>.MoveNext
	|
	|-RVA: 0x2649210 Offset: 0x2649311 VA: 0x2649210
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, ushort>>.MoveNext
	|
	|-RVA: 0x2649400 Offset: 0x2649501 VA: 0x2649400
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, GameVariable.Value>>.MoveNext
	|
	|-RVA: 0x2649600 Offset: 0x2649701 VA: 0x2649600
	|-Array.EmptyInternalEnumerator<KeyValuePair<sbyte, DataStoreRatingInfo>>.MoveNext
	|
	|-RVA: 0x2649800 Offset: 0x2649901 VA: 0x2649800
	|-Array.EmptyInternalEnumerator<KeyValuePair<sbyte, object>>.MoveNext
	|
	|-RVA: 0x26499F0 Offset: 0x2649AF1 VA: 0x26499F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<ushort, int>>.MoveNext
	|
	|-RVA: 0x2649BD0 Offset: 0x2649CD1 VA: 0x2649BD0
	|-Array.EmptyInternalEnumerator<KeyValuePair<uint, int>>.MoveNext
	|
	|-RVA: 0x2649DB0 Offset: 0x2649EB1 VA: 0x2649DB0
	|-Array.EmptyInternalEnumerator<KeyValuePair<uint, object>>.MoveNext
	|
	|-RVA: 0x2649FA0 Offset: 0x264A0A1 VA: 0x2649FA0
	|-Array.EmptyInternalEnumerator<KeyValuePair<ulong, Friend>>.MoveNext
	|
	|-RVA: 0x264A1B0 Offset: 0x264A2B1 VA: 0x264A1B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<ulong, Int32Enum>>.MoveNext
	|
	|-RVA: 0x264A3A0 Offset: 0x264A4A1 VA: 0x264A3A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<ulong, object>>.MoveNext
	|
	|-RVA: 0x264A590 Offset: 0x264A691 VA: 0x264A590
	|-Array.EmptyInternalEnumerator<KeyValuePair<Vector3, int>>.MoveNext
	|
	|-RVA: 0x264A780 Offset: 0x264A881 VA: 0x264A780
	|-Array.EmptyInternalEnumerator<KeyValuePair<XPathNodeRef, XPathNodeRef>>.MoveNext
	|
	|-RVA: 0x264A980 Offset: 0x264AA81 VA: 0x264A980
	|-Array.EmptyInternalEnumerator<KeyValuePair<TerrainUtility.TerrainMap.TileCoord, object>>.MoveNext
	|
	|-RVA: 0x264AB70 Offset: 0x264AC71 VA: 0x264AB70
	|-Array.EmptyInternalEnumerator<NativeArray<PreTile>>.MoveNext
	|
	|-RVA: 0x264AD60 Offset: 0x264AE61 VA: 0x264AD60
	|-Array.EmptyInternalEnumerator<CommonBattleSequence.Reliance<object>>.MoveNext
	|
	|-RVA: 0x264AF60 Offset: 0x264B061 VA: 0x264AF60
	|-Array.EmptyInternalEnumerator<RenderGraphResourcePool.ResourceLogInfo<object>>.MoveNext
	|
	|-RVA: 0x264B150 Offset: 0x264B251 VA: 0x264B150
	|-Array.EmptyInternalEnumerator<HashSet.Slot<ValueTuple<object, int>>>.MoveNext
	|
	|-RVA: 0x264B350 Offset: 0x264B451 VA: 0x264B350
	|-Array.EmptyInternalEnumerator<HashSet.Slot<AsyncOperationHandle>>.MoveNext
	|
	|-RVA: 0x264B550 Offset: 0x264B651 VA: 0x264B550
	|-Array.EmptyInternalEnumerator<HashSet.Slot<int>>.MoveNext
	|
	|-RVA: 0x264B740 Offset: 0x264B841 VA: 0x264B740
	|-Array.EmptyInternalEnumerator<HashSet.Slot<Int32Enum>>.MoveNext
	|
	|-RVA: 0x264B930 Offset: 0x264BA31 VA: 0x264B930
	|-Array.EmptyInternalEnumerator<Set.Slot<Int32Enum>>.MoveNext
	|
	|-RVA: 0x264BB20 Offset: 0x264BC21 VA: 0x264BB20
	|-Array.EmptyInternalEnumerator<HashSet.Slot<MapPos>>.MoveNext
	|
	|-RVA: 0x264BD10 Offset: 0x264BE11 VA: 0x264BD10
	|-Array.EmptyInternalEnumerator<HashSet.Slot<object>>.MoveNext
	|
	|-RVA: 0x264BF00 Offset: 0x264C001 VA: 0x264BF00
	|-Array.EmptyInternalEnumerator<Set.Slot<object>>.MoveNext
	|
	|-RVA: 0x264C100 Offset: 0x264C201 VA: 0x264C100
	|-Array.EmptyInternalEnumerator<HashSet.Slot<uint>>.MoveNext
	|
	|-RVA: 0x264C2F0 Offset: 0x264C3F1 VA: 0x264C2F0
	|-Array.EmptyInternalEnumerator<HashSet.Slot<ulong>>.MoveNext
	|
	|-RVA: 0x264C4E0 Offset: 0x264C5E1 VA: 0x264C4E0
	|-Array.EmptyInternalEnumerator<Set.Slot<Vector3>>.MoveNext
	|
	|-RVA: 0x264C6E0 Offset: 0x264C7E1 VA: 0x264C6E0
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<Color32>>.MoveNext
	|
	|-RVA: 0x264C8E0 Offset: 0x264C9E1 VA: 0x264C8E0
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<HighlightState>>.MoveNext
	|
	|-RVA: 0x264CAF0 Offset: 0x264CBF1 VA: 0x264CAF0
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<int>>.MoveNext
	|
	|-RVA: 0x264CCF0 Offset: 0x264CDF1 VA: 0x264CCF0
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<Int32Enum>>.MoveNext
	|
	|-RVA: 0x264CEF0 Offset: 0x264CFF1 VA: 0x264CEF0
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<MaterialReference>>.MoveNext
	|
	|-RVA: 0x264D150 Offset: 0x264D251 VA: 0x264D150
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<object>>.MoveNext
	|
	|-RVA: 0x264D360 Offset: 0x264D461 VA: 0x264D360
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<float>>.MoveNext
	|
	|-RVA: 0x264D560 Offset: 0x264D661 VA: 0x264D560
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<WordWrapState>>.MoveNext
	|
	|-RVA: 0x264D770 Offset: 0x264D871 VA: 0x264D770
	|-Array.EmptyInternalEnumerator<TimeInterval<object>>.MoveNext
	|
	|-RVA: 0x264D960 Offset: 0x264DA61 VA: 0x264D960
	|-Array.EmptyInternalEnumerator<Timestamped<object>>.MoveNext
	|
	|-RVA: 0x264DB60 Offset: 0x264DC61 VA: 0x264DB60
	|-Array.EmptyInternalEnumerator<UniTask<object>>.MoveNext
	|
	|-RVA: 0x264DD50 Offset: 0x264DE51 VA: 0x264DD50
	|-Array.EmptyInternalEnumerator<ValueTuple<ValueTuple<bool, object>>>.MoveNext
	|
	|-RVA: 0x264DF40 Offset: 0x264E041 VA: 0x264DF40
	|-Array.EmptyInternalEnumerator<ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>.MoveNext
	|
	|-RVA: 0x264E140 Offset: 0x264E241 VA: 0x264E140
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, UniTask<object>>>.MoveNext
	|
	|-RVA: 0x264E340 Offset: 0x264E441 VA: 0x264E340
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.MoveNext
	|
	|-RVA: 0x264E540 Offset: 0x264E641 VA: 0x264E540
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.MoveNext
	|
	|-RVA: 0x264E750 Offset: 0x264E851 VA: 0x264E750
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.MoveNext
	|
	|-RVA: 0x264E960 Offset: 0x264EA61 VA: 0x264E960
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.MoveNext
	|
	|-RVA: 0x264EB50 Offset: 0x264EC51 VA: 0x264EB50
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.MoveNext
	|
	|-RVA: 0x264ED40 Offset: 0x264EE41 VA: 0x264ED40
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.MoveNext
	|
	|-RVA: 0x264EF60 Offset: 0x264F061 VA: 0x264EF60
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.MoveNext
	|
	|-RVA: 0x264F150 Offset: 0x264F251 VA: 0x264F150
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.MoveNext
	|
	|-RVA: 0x264F360 Offset: 0x264F461 VA: 0x264F360
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.MoveNext
	|
	|-RVA: 0x264F570 Offset: 0x264F671 VA: 0x264F570
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.MoveNext
	|
	|-RVA: 0x264F770 Offset: 0x264F871 VA: 0x264F770
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.MoveNext
	|
	|-RVA: 0x264F980 Offset: 0x264FA81 VA: 0x264F980
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.MoveNext
	|
	|-RVA: 0x264FB90 Offset: 0x264FC91 VA: 0x264FB90
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.MoveNext
	|
	|-RVA: 0x264FDA0 Offset: 0x264FEA1 VA: 0x264FDA0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.MoveNext
	|
	|-RVA: 0x264FFB0 Offset: 0x26500B1 VA: 0x264FFB0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.MoveNext
	|
	|-RVA: 0x26501B0 Offset: 0x26502B1 VA: 0x26501B0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.MoveNext
	|
	|-RVA: 0x26503C0 Offset: 0x26504C1 VA: 0x26503C0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.MoveNext
	|
	|-RVA: 0x26505B0 Offset: 0x26506B1 VA: 0x26505B0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.MoveNext
	|
	|-RVA: 0x26507C0 Offset: 0x26508C1 VA: 0x26507C0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.MoveNext
	|
	|-RVA: 0x26509C0 Offset: 0x2650AC1 VA: 0x26509C0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.MoveNext
	|
	|-RVA: 0x2650BD0 Offset: 0x2650CD1 VA: 0x2650BD0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.MoveNext
	|
	|-RVA: 0x2650DE0 Offset: 0x2650EE1 VA: 0x2650DE0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.MoveNext
	|
	|-RVA: 0x2650FF0 Offset: 0x26510F1 VA: 0x2650FF0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.MoveNext
	|
	|-RVA: 0x2651200 Offset: 0x2651301 VA: 0x2651200
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.MoveNext
	|
	|-RVA: 0x2651420 Offset: 0x2651521 VA: 0x2651420
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.MoveNext
	|
	|-RVA: 0x2651670 Offset: 0x2651771 VA: 0x2651670
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.MoveNext
	|
	|-RVA: 0x26518C0 Offset: 0x26519C1 VA: 0x26518C0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.MoveNext
	|
	|-RVA: 0x2651B20 Offset: 0x2651C21 VA: 0x2651B20
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.MoveNext
	|
	|-RVA: 0x2651D10 Offset: 0x2651E11 VA: 0x2651D10
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.MoveNext
	|
	|-RVA: 0x2651F00 Offset: 0x2652001 VA: 0x2651F00
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.MoveNext
	|
	|-RVA: 0x2652110 Offset: 0x2652211 VA: 0x2652110
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.MoveNext
	|
	|-RVA: 0x2652300 Offset: 0x2652401 VA: 0x2652300
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.MoveNext
	|
	|-RVA: 0x2652500 Offset: 0x2652601 VA: 0x2652500
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.MoveNext
	|
	|-RVA: 0x2652710 Offset: 0x2652811 VA: 0x2652710
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.MoveNext
	|
	|-RVA: 0x2652910 Offset: 0x2652A11 VA: 0x2652910
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.MoveNext
	|
	|-RVA: 0x2652B20 Offset: 0x2652C21 VA: 0x2652B20
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.MoveNext
	|
	|-RVA: 0x2652D30 Offset: 0x2652E31 VA: 0x2652D30
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.MoveNext
	|
	|-RVA: 0x2652F30 Offset: 0x2653031 VA: 0x2652F30
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.MoveNext
	|
	|-RVA: 0x2653130 Offset: 0x2653231 VA: 0x2653130
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.MoveNext
	|
	|-RVA: 0x2653330 Offset: 0x2653431 VA: 0x2653330
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.MoveNext
	|
	|-RVA: 0x2653540 Offset: 0x2653641 VA: 0x2653540
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.MoveNext
	|
	|-RVA: 0x2653730 Offset: 0x2653831 VA: 0x2653730
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.MoveNext
	|
	|-RVA: 0x2653930 Offset: 0x2653A31 VA: 0x2653930
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.MoveNext
	|
	|-RVA: 0x2653B40 Offset: 0x2653C41 VA: 0x2653B40
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.MoveNext
	|
	|-RVA: 0x2653D40 Offset: 0x2653E41 VA: 0x2653D40
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.MoveNext
	|
	|-RVA: 0x2653F50 Offset: 0x2654051 VA: 0x2653F50
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.MoveNext
	|
	|-RVA: 0x2654160 Offset: 0x2654261 VA: 0x2654160
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.MoveNext
	|
	|-RVA: 0x2654380 Offset: 0x2654481 VA: 0x2654380
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.MoveNext
	|
	|-RVA: 0x2654590 Offset: 0x2654691 VA: 0x2654590
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.MoveNext
	|
	|-RVA: 0x26547E0 Offset: 0x26548E1 VA: 0x26547E0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.MoveNext
	|
	|-RVA: 0x26549F0 Offset: 0x2654AF1 VA: 0x26549F0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.MoveNext
	|
	|-RVA: 0x2654C70 Offset: 0x2654D71 VA: 0x2654C70
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.MoveNext
	|
	|-RVA: 0x2654E90 Offset: 0x2654F91 VA: 0x2654E90
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.MoveNext
	|
	|-RVA: 0x2655120 Offset: 0x2655221 VA: 0x2655120
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.MoveNext
	|
	|-RVA: 0x2655370 Offset: 0x2655471 VA: 0x2655370
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.MoveNext
	|
	|-RVA: 0x2655620 Offset: 0x2655721 VA: 0x2655620
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.MoveNext
	|
	|-RVA: 0x2655870 Offset: 0x2655971 VA: 0x2655870
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.MoveNext
	|
	|-RVA: 0x2655A50 Offset: 0x2655B51 VA: 0x2655A50
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.MoveNext
	|
	|-RVA: 0x2655C30 Offset: 0x2655D31 VA: 0x2655C30
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.MoveNext
	|
	|-RVA: 0x2655E40 Offset: 0x2655F41 VA: 0x2655E40
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.MoveNext
	|
	|-RVA: 0x2656020 Offset: 0x2656121 VA: 0x2656020
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.MoveNext
	|
	|-RVA: 0x2656230 Offset: 0x2656331 VA: 0x2656230
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.MoveNext
	|
	|-RVA: 0x2656430 Offset: 0x2656531 VA: 0x2656430
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.MoveNext
	|
	|-RVA: 0x2656620 Offset: 0x2656721 VA: 0x2656620
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.MoveNext
	|
	|-RVA: 0x2656820 Offset: 0x2656921 VA: 0x2656820
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.MoveNext
	|
	|-RVA: 0x2656A20 Offset: 0x2656B21 VA: 0x2656A20
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.MoveNext
	|
	|-RVA: 0x2656C30 Offset: 0x2656D31 VA: 0x2656C30
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.MoveNext
	|
	|-RVA: 0x2656E40 Offset: 0x2656F41 VA: 0x2656E40
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.MoveNext
	|
	|-RVA: 0x2657030 Offset: 0x2657131 VA: 0x2657030
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.MoveNext
	|
	|-RVA: 0x2657230 Offset: 0x2657331 VA: 0x2657230
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.MoveNext
	|
	|-RVA: 0x2657410 Offset: 0x2657511 VA: 0x2657410
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.MoveNext
	|
	|-RVA: 0x2657610 Offset: 0x2657711 VA: 0x2657610
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.MoveNext
	|
	|-RVA: 0x2657810 Offset: 0x2657911 VA: 0x2657810
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.MoveNext
	|
	|-RVA: 0x2657A20 Offset: 0x2657B21 VA: 0x2657A20
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.MoveNext
	|
	|-RVA: 0x2657C20 Offset: 0x2657D21 VA: 0x2657C20
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.MoveNext
	|
	|-RVA: 0x2657E20 Offset: 0x2657F21 VA: 0x2657E20
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.MoveNext
	|
	|-RVA: 0x2658030 Offset: 0x2658131 VA: 0x2658030
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.MoveNext
	|
	|-RVA: 0x2658240 Offset: 0x2658341 VA: 0x2658240
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.MoveNext
	|
	|-RVA: 0x2658490 Offset: 0x2658591 VA: 0x2658490
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.MoveNext
	|
	|-RVA: 0x26586A0 Offset: 0x26587A1 VA: 0x26586A0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.MoveNext
	|
	|-RVA: 0x2658900 Offset: 0x2658A01 VA: 0x2658900
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.MoveNext
	|
	|-RVA: 0x2658B10 Offset: 0x2658C11 VA: 0x2658B10
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.MoveNext
	|
	|-RVA: 0x2658DA0 Offset: 0x2658EA1 VA: 0x2658DA0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.MoveNext
	|
	|-RVA: 0x2658FC0 Offset: 0x26590C1 VA: 0x2658FC0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.MoveNext
	|
	|-RVA: 0x2659260 Offset: 0x2659361 VA: 0x2659260
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.MoveNext
	|
	|-RVA: 0x26594B0 Offset: 0x26595B1 VA: 0x26594B0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.MoveNext
	|
	|-RVA: 0x26596C0 Offset: 0x26597C1 VA: 0x26596C0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.MoveNext
	|
	|-RVA: 0x26598D0 Offset: 0x26599D1 VA: 0x26598D0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.MoveNext
	|
	|-RVA: 0x2659AC0 Offset: 0x2659BC1 VA: 0x2659AC0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, bool>>>.MoveNext
	|
	|-RVA: 0x2659CB0 Offset: 0x2659DB1 VA: 0x2659CB0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, Bounds>>>.MoveNext
	|
	|-RVA: 0x2659EB0 Offset: 0x2659FB1 VA: 0x2659EB0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, byte>>>.MoveNext
	|
	|-RVA: 0x265A0A0 Offset: 0x265A1A1 VA: 0x265A0A0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, Color>>>.MoveNext
	|
	|-RVA: 0x265A2A0 Offset: 0x265A3A1 VA: 0x265A2A0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, double>>>.MoveNext
	|
	|-RVA: 0x265A4A0 Offset: 0x265A5A1 VA: 0x265A4A0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, int>>>.MoveNext
	|
	|-RVA: 0x1CF0D50 Offset: 0x1CF0E51 VA: 0x1CF0D50
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, long>>>.MoveNext
	|
	|-RVA: 0x1CF0F50 Offset: 0x1CF1051 VA: 0x1CF0F50
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, object>>>.MoveNext
	|
	|-RVA: 0x1CF1150 Offset: 0x1CF1251 VA: 0x1CF1150
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, Quaternion>>>.MoveNext
	|
	|-RVA: 0x1CF1350 Offset: 0x1CF1451 VA: 0x1CF1350
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, Rect>>>.MoveNext
	|
	|-RVA: 0x1CF1550 Offset: 0x1CF1651 VA: 0x1CF1550
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, float>>>.MoveNext
	|
	|-RVA: 0x1CF1740 Offset: 0x1CF1841 VA: 0x1CF1740
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, UniTask>>>.MoveNext
	|
	|-RVA: 0x1CF1940 Offset: 0x1CF1A41 VA: 0x1CF1940
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, Unit>>>.MoveNext
	|
	|-RVA: 0x1CF1B30 Offset: 0x1CF1C31 VA: 0x1CF1B30
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, Vector2>>>.MoveNext
	|
	|-RVA: 0x1CF1D20 Offset: 0x1CF1E21 VA: 0x1CF1D20
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, Vector3>>>.MoveNext
	|
	|-RVA: 0x1CF1F20 Offset: 0x1CF2021 VA: 0x1CF1F20
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, Vector4>>>.MoveNext
	|
	|-RVA: 0x1CF2120 Offset: 0x1CF2221 VA: 0x1CF2120
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<int, object>>>.MoveNext
	|
	|-RVA: 0x1CF2320 Offset: 0x1CF2421 VA: 0x1CF2320
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<object, object>>>.MoveNext
	|
	|-RVA: 0x1CF2520 Offset: 0x1CF2621 VA: 0x1CF2520
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.MoveNext
	|
	|-RVA: 0x1CF2730 Offset: 0x1CF2831 VA: 0x1CF2730
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<object, object, object>>>.MoveNext
	|
	|-RVA: 0x1CF2930 Offset: 0x1CF2A31 VA: 0x1CF2930
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.MoveNext
	|
	|-RVA: 0x1CF2B50 Offset: 0x1CF2C51 VA: 0x1CF2B50
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<object, object, object, object>>>.MoveNext
	|
	|-RVA: 0x1CF2D60 Offset: 0x1CF2E61 VA: 0x1CF2D60
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.MoveNext
	|
	|-RVA: 0x1CF2FB0 Offset: 0x1CF30B1 VA: 0x1CF2FB0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.MoveNext
	|
	|-RVA: 0x1CF31C0 Offset: 0x1CF32C1 VA: 0x1CF31C0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.MoveNext
	|
	|-RVA: 0x1CF3440 Offset: 0x1CF3541 VA: 0x1CF3440
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.MoveNext
	|
	|-RVA: 0x1CF3650 Offset: 0x1CF3751 VA: 0x1CF3650
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.MoveNext
	|
	|-RVA: 0x1CF38E0 Offset: 0x1CF39E1 VA: 0x1CF38E0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.MoveNext
	|
	|-RVA: 0x1CF3B00 Offset: 0x1CF3C01 VA: 0x1CF3B00
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.MoveNext
	|
	|-RVA: 0x1CF3DB0 Offset: 0x1CF3EB1 VA: 0x1CF3DB0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.MoveNext
	|
	|-RVA: 0x1CF3FC0 Offset: 0x1CF40C1 VA: 0x1CF3FC0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, AsyncUnit>>.MoveNext
	|
	|-RVA: 0x1CF41A0 Offset: 0x1CF42A1 VA: 0x1CF41A0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, bool>>.MoveNext
	|
	|-RVA: 0x1CF4380 Offset: 0x1CF4481 VA: 0x1CF4380
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Bounds>>.MoveNext
	|
	|-RVA: 0x1CF4590 Offset: 0x1CF4691 VA: 0x1CF4590
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, byte>>.MoveNext
	|
	|-RVA: 0x1CF4770 Offset: 0x1CF4871 VA: 0x1CF4770
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Color>>.MoveNext
	|
	|-RVA: 0x1CF4970 Offset: 0x1CF4A71 VA: 0x1CF4970
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, double>>.MoveNext
	|
	|-RVA: 0x1CF4B60 Offset: 0x1CF4C61 VA: 0x1CF4B60
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, int>>.MoveNext
	|
	|-RVA: 0x1CF4D40 Offset: 0x1CF4E41 VA: 0x1CF4D40
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, long>>.MoveNext
	|
	|-RVA: 0x1CF4F30 Offset: 0x1CF5031 VA: 0x1CF4F30
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, object>>.MoveNext
	|
	|-RVA: 0x1CF5120 Offset: 0x1CF5221 VA: 0x1CF5120
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Quaternion>>.MoveNext
	|
	|-RVA: 0x1CF5320 Offset: 0x1CF5421 VA: 0x1CF5320
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Rect>>.MoveNext
	|
	|-RVA: 0x1CF5520 Offset: 0x1CF5621 VA: 0x1CF5520
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, float>>.MoveNext
	|
	|-RVA: 0x1CF5700 Offset: 0x1CF5801 VA: 0x1CF5700
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, UniTask>>.MoveNext
	|
	|-RVA: 0x1CF58F0 Offset: 0x1CF59F1 VA: 0x1CF58F0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Unit>>.MoveNext
	|
	|-RVA: 0x1CF5AD0 Offset: 0x1CF5BD1 VA: 0x1CF5AD0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Vector2>>.MoveNext
	|
	|-RVA: 0x1CF5CC0 Offset: 0x1CF5DC1 VA: 0x1CF5CC0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Vector3>>.MoveNext
	|
	|-RVA: 0x1CF5EB0 Offset: 0x1CF5FB1 VA: 0x1CF5EB0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Vector4>>.MoveNext
	|
	|-RVA: 0x1CF60B0 Offset: 0x1CF61B1 VA: 0x1CF60B0
	|-Array.EmptyInternalEnumerator<ValueTuple<int, bool>>.MoveNext
	|
	|-RVA: 0x1CF6290 Offset: 0x1CF6391 VA: 0x1CF6290
	|-Array.EmptyInternalEnumerator<ValueTuple<int, Bounds>>.MoveNext
	|
	|-RVA: 0x1CF64A0 Offset: 0x1CF65A1 VA: 0x1CF64A0
	|-Array.EmptyInternalEnumerator<ValueTuple<int, byte>>.MoveNext
	|
	|-RVA: 0x1CF6680 Offset: 0x1CF6781 VA: 0x1CF6680
	|-Array.EmptyInternalEnumerator<ValueTuple<int, Color>>.MoveNext
	|
	|-RVA: 0x1CF6880 Offset: 0x1CF6981 VA: 0x1CF6880
	|-Array.EmptyInternalEnumerator<ValueTuple<int, double>>.MoveNext
	|
	|-RVA: 0x1CF6A70 Offset: 0x1CF6B71 VA: 0x1CF6A70
	|-Array.EmptyInternalEnumerator<ValueTuple<int, int>>.MoveNext
	|
	|-RVA: 0x1CF6C50 Offset: 0x1CF6D51 VA: 0x1CF6C50
	|-Array.EmptyInternalEnumerator<ValueTuple<int, long>>.MoveNext
	|
	|-RVA: 0x1CF6E40 Offset: 0x1CF6F41 VA: 0x1CF6E40
	|-Array.EmptyInternalEnumerator<ValueTuple<int, object>>.MoveNext
	|
	|-RVA: 0x1CF7030 Offset: 0x1CF7131 VA: 0x1CF7030
	|-Array.EmptyInternalEnumerator<ValueTuple<int, Quaternion>>.MoveNext
	|
	|-RVA: 0x1CF7230 Offset: 0x1CF7331 VA: 0x1CF7230
	|-Array.EmptyInternalEnumerator<ValueTuple<int, Rect>>.MoveNext
	|
	|-RVA: 0x1CF7430 Offset: 0x1CF7531 VA: 0x1CF7430
	|-Array.EmptyInternalEnumerator<ValueTuple<int, float>>.MoveNext
	|
	|-RVA: 0x1CF7610 Offset: 0x1CF7711 VA: 0x1CF7610
	|-Array.EmptyInternalEnumerator<ValueTuple<int, Unit>>.MoveNext
	|
	|-RVA: 0x1CF77F0 Offset: 0x1CF78F1 VA: 0x1CF77F0
	|-Array.EmptyInternalEnumerator<ValueTuple<int, Vector2>>.MoveNext
	|
	|-RVA: 0x1CF79E0 Offset: 0x1CF7AE1 VA: 0x1CF79E0
	|-Array.EmptyInternalEnumerator<ValueTuple<int, Vector3>>.MoveNext
	|
	|-RVA: 0x1CF7BD0 Offset: 0x1CF7CD1 VA: 0x1CF7BD0
	|-Array.EmptyInternalEnumerator<ValueTuple<int, Vector4>>.MoveNext
	|
	|-RVA: 0x1CF7DD0 Offset: 0x1CF7ED1 VA: 0x1CF7DD0
	|-Array.EmptyInternalEnumerator<ValueTuple<Int32Enum, int>>.MoveNext
	|
	|-RVA: 0x1CF7FB0 Offset: 0x1CF80B1 VA: 0x1CF7FB0
	|-Array.EmptyInternalEnumerator<ValueTuple<object, ValueTuple<object, int>>>.MoveNext
	|
	|-RVA: 0x1CF81B0 Offset: 0x1CF82B1 VA: 0x1CF81B0
	|-Array.EmptyInternalEnumerator<ValueTuple<object, int>>.MoveNext
	|
	|-RVA: 0x1CF83A0 Offset: 0x1CF84A1 VA: 0x1CF83A0
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object>>.MoveNext
	|
	|-RVA: 0x1CF8590 Offset: 0x1CF8691 VA: 0x1CF8590
	|-Array.EmptyInternalEnumerator<ValueTuple<object, float>>.MoveNext
	|
	|-RVA: 0x1CF8780 Offset: 0x1CF8881 VA: 0x1CF8780
	|-Array.EmptyInternalEnumerator<ValueTuple<Vector3, float>>.MoveNext
	|
	|-RVA: 0x1CF8970 Offset: 0x1CF8A71 VA: 0x1CF8970
	|-Array.EmptyInternalEnumerator<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.MoveNext
	|
	|-RVA: 0x1CF8B80 Offset: 0x1CF8C81 VA: 0x1CF8B80
	|-Array.EmptyInternalEnumerator<ValueTuple<object, Int32Enum, int>>.MoveNext
	|
	|-RVA: 0x1CF8D70 Offset: 0x1CF8E71 VA: 0x1CF8D70
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object, object>>.MoveNext
	|
	|-RVA: 0x1CF8F70 Offset: 0x1CF9071 VA: 0x1CF8F70
	|-Array.EmptyInternalEnumerator<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.MoveNext
	|
	|-RVA: 0x1CF9180 Offset: 0x1CF9281 VA: 0x1CF9180
	|-Array.EmptyInternalEnumerator<ValueTuple<object, int, int, int>>.MoveNext
	|
	|-RVA: 0x1CF9380 Offset: 0x1CF9481 VA: 0x1CF9380
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object, object, object>>.MoveNext
	|
	|-RVA: 0x1CF9580 Offset: 0x1CF9681 VA: 0x1CF9580
	|-Array.EmptyInternalEnumerator<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.MoveNext
	|
	|-RVA: 0x1CF97D0 Offset: 0x1CF98D1 VA: 0x1CF97D0
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object, object, object, object>>.MoveNext
	|
	|-RVA: 0x1CF99E0 Offset: 0x1CF9AE1 VA: 0x1CF99E0
	|-Array.EmptyInternalEnumerator<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.MoveNext
	|
	|-RVA: 0x1CF9C40 Offset: 0x1CF9D41 VA: 0x1CF9C40
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object, object, object, object, object>>.MoveNext
	|
	|-RVA: 0x1CF9E50 Offset: 0x1CF9F51 VA: 0x1CF9E50
	|-Array.EmptyInternalEnumerator<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.MoveNext
	|
	|-RVA: 0x1CFA0E0 Offset: 0x1CFA1E1 VA: 0x1CFA0E0
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object, object, object, object, object, object>>.MoveNext
	|
	|-RVA: 0x1CFA2F0 Offset: 0x1CFA3F1 VA: 0x1CFA2F0
	|-Array.EmptyInternalEnumerator<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.MoveNext
	|
	|-RVA: 0x1CFA590 Offset: 0x1CFA691 VA: 0x1CFA590
	|-Array.EmptyInternalEnumerator<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.MoveNext
	|
	|-RVA: 0x1CFA7A0 Offset: 0x1CFA8A1 VA: 0x1CFA7A0
	|-Array.EmptyInternalEnumerator<AnimatorClipInfo>.MoveNext
	|
	|-RVA: 0x1CFA980 Offset: 0x1CFAA81 VA: 0x1CFA980
	|-Array.EmptyInternalEnumerator<AsyncOperationHandle>.MoveNext
	|
	|-RVA: 0x1CFAB80 Offset: 0x1CFAC81 VA: 0x1CFAB80
	|-Array.EmptyInternalEnumerator<AsyncUnit>.MoveNext
	|
	|-RVA: 0x1CFAD60 Offset: 0x1CFAE61 VA: 0x1CFAD60
	|-Array.EmptyInternalEnumerator<BatchVisibility>.MoveNext
	|
	|-RVA: 0x1CFAF50 Offset: 0x1CFB051 VA: 0x1CFAF50
	|-Array.EmptyInternalEnumerator<BoneWeight>.MoveNext
	|
	|-RVA: 0x1CFB150 Offset: 0x1CFB251 VA: 0x1CFB150
	|-Array.EmptyInternalEnumerator<BoneWeight1>.MoveNext
	|
	|-RVA: 0x1CFB330 Offset: 0x1CFB431 VA: 0x1CFB330
	|-Array.EmptyInternalEnumerator<bool>.MoveNext
	|
	|-RVA: 0x1CFB510 Offset: 0x1CFB611 VA: 0x1CFB510
	|-Array.EmptyInternalEnumerator<Bounds>.MoveNext
	|
	|-RVA: 0x1CFB710 Offset: 0x1CFB811 VA: 0x1CFB710
	|-Array.EmptyInternalEnumerator<byte>.MoveNext
	|
	|-RVA: 0x1CFB8F0 Offset: 0x1CFB9F1 VA: 0x1CFB8F0
	|-Array.EmptyInternalEnumerator<ByteEnum>.MoveNext
	|
	|-RVA: 0x1CFBAD0 Offset: 0x1CFBBD1 VA: 0x1CFBAD0
	|-Array.EmptyInternalEnumerator<CameraInfo>.MoveNext
	|
	|-RVA: 0x1CFBCC0 Offset: 0x1CFBDC1 VA: 0x1CFBCC0
	|-Array.EmptyInternalEnumerator<CancellationToken>.MoveNext
	|
	|-RVA: 0x1CFBEA0 Offset: 0x1CFBFA1 VA: 0x1CFBEA0
	|-Array.EmptyInternalEnumerator<CancellationTokenRegistration>.MoveNext
	|
	|-RVA: 0x1CFC0A0 Offset: 0x1CFC1A1 VA: 0x1CFC0A0
	|-Array.EmptyInternalEnumerator<char>.MoveNext
	|
	|-RVA: 0x1CFC280 Offset: 0x1CFC381 VA: 0x1CFC280
	|-Array.EmptyInternalEnumerator<ClusteringData>.MoveNext
	|
	|-RVA: 0x1CFC480 Offset: 0x1CFC581 VA: 0x1CFC480
	|-Array.EmptyInternalEnumerator<ClusteringProcessorState>.MoveNext
	|
	|-RVA: 0x1CFC690 Offset: 0x1CFC791 VA: 0x1CFC690
	|-Array.EmptyInternalEnumerator<Color>.MoveNext
	|
	|-RVA: 0x1CFC880 Offset: 0x1CFC981 VA: 0x1CFC880
	|-Array.EmptyInternalEnumerator<Color32>.MoveNext
	|
	|-RVA: 0x1CFCA60 Offset: 0x1CFCB61 VA: 0x1CFCA60
	|-Array.EmptyInternalEnumerator<Color4u8>.MoveNext
	|
	|-RVA: 0x1CFCC40 Offset: 0x1CFCD41 VA: 0x1CFCC40
	|-Array.EmptyInternalEnumerator<ColorBlock>.MoveNext
	|
	|-RVA: 0x1CFCEA0 Offset: 0x1CFCFA1 VA: 0x1CFCEA0
	|-Array.EmptyInternalEnumerator<CombineInstance>.MoveNext
	|
	|-RVA: 0x1CFD130 Offset: 0x1CFD231 VA: 0x1CFD130
	|-Array.EmptyInternalEnumerator<ConstraintSource>.MoveNext
	|
	|-RVA: 0x1CFD320 Offset: 0x1CFD421 VA: 0x1CFD320
	|-Array.EmptyInternalEnumerator<ContactPoint>.MoveNext
	|
	|-RVA: 0x1CFD530 Offset: 0x1CFD631 VA: 0x1CFD530
	|-Array.EmptyInternalEnumerator<ContactPoint2D>.MoveNext
	|
	|-RVA: 0x1CFD740 Offset: 0x1CFD841 VA: 0x1CFD740
	|-Array.EmptyInternalEnumerator<ContourVertex>.MoveNext
	|
	|-RVA: 0x1CFD940 Offset: 0x1CFDA41 VA: 0x1CFD940
	|-Array.EmptyInternalEnumerator<CustomAttributeNamedArgument>.MoveNext
	|
	|-RVA: 0x1CFDB40 Offset: 0x1CFDC41 VA: 0x1CFDB40
	|-Array.EmptyInternalEnumerator<CustomAttributeTypedArgument>.MoveNext
	|
	|-RVA: 0x1CFDD30 Offset: 0x1CFDE31 VA: 0x1CFDD30
	|-Array.EmptyInternalEnumerator<DataStoreRatingInfo>.MoveNext
	|
	|-RVA: 0x1CFDF30 Offset: 0x1CFE031 VA: 0x1CFDF30
	|-Array.EmptyInternalEnumerator<DataStoreResult>.MoveNext
	|
	|-RVA: 0x1CFE110 Offset: 0x1CFE211 VA: 0x1CFE110
	|-Array.EmptyInternalEnumerator<DateTime>.MoveNext
	|
	|-RVA: 0x1CFE2F0 Offset: 0x1CFE3F1 VA: 0x1CFE2F0
	|-Array.EmptyInternalEnumerator<DateTimeOffset>.MoveNext
	|
	|-RVA: 0x1CFE4E0 Offset: 0x1CFE5E1 VA: 0x1CFE4E0
	|-Array.EmptyInternalEnumerator<DebugPadState>.MoveNext
	|
	|-RVA: 0x1CFE6E0 Offset: 0x1CFE7E1 VA: 0x1CFE6E0
	|-Array.EmptyInternalEnumerator<Decimal>.MoveNext
	|
	|-RVA: 0x1CFE8D0 Offset: 0x1CFE9D1 VA: 0x1CFE8D0
	|-Array.EmptyInternalEnumerator<DeferredTiler>.MoveNext
	|
	|-RVA: 0x1CFEB70 Offset: 0x1CFEC71 VA: 0x1CFEB70
	|-Array.EmptyInternalEnumerator<DeviceHandle>.MoveNext
	|
	|-RVA: 0x1CFED60 Offset: 0x1CFEE61 VA: 0x1CFED60
	|-Array.EmptyInternalEnumerator<DiagnosticEvent>.MoveNext
	|
	|-RVA: 0x1CFEF70 Offset: 0x1CFF071 VA: 0x1CFEF70
	|-Array.EmptyInternalEnumerator<DictionaryEntry>.MoveNext
	|
	|-RVA: 0x1CFF160 Offset: 0x1CFF261 VA: 0x1CFF160
	|-Array.EmptyInternalEnumerator<DictionaryInfo>.MoveNext
	|
	|-RVA: 0x1CFF340 Offset: 0x1CFF441 VA: 0x1CFF340
	|-Array.EmptyInternalEnumerator<DirectoryEntry>.MoveNext
	|
	|-RVA: 0x1CFF540 Offset: 0x1CFF641 VA: 0x1CFF540
	|-Array.EmptyInternalEnumerator<double>.MoveNext
	|
	|-RVA: 0x1CFF720 Offset: 0x1CFF821 VA: 0x1CFF720
	|-Array.EmptyInternalEnumerator<Ephemeron>.MoveNext
	|
	|-RVA: 0x1CFF910 Offset: 0x1CFFA11 VA: 0x1CFF910
	|-Array.EmptyInternalEnumerator<FXZ>.MoveNext
	|
	|-RVA: 0x1CFFAF0 Offset: 0x1CFFBF1 VA: 0x1CFFAF0
	|-Array.EmptyInternalEnumerator<Finger>.MoveNext
	|
	|-RVA: 0x1CFFD00 Offset: 0x1CFFE01 VA: 0x1CFFD00
	|-Array.EmptyInternalEnumerator<Float2>.MoveNext
	|
	|-RVA: 0x1CFFEE0 Offset: 0x1CFFFE1 VA: 0x1CFFEE0
	|-Array.EmptyInternalEnumerator<Friend>.MoveNext
	|
	|-RVA: 0x1D000F0 Offset: 0x1D001F1 VA: 0x1D000F0
	|-Array.EmptyInternalEnumerator<GCHandle>.MoveNext
	|
	|-RVA: 0x1D002D0 Offset: 0x1D003D1 VA: 0x1D002D0
	|-Array.EmptyInternalEnumerator<GesturePoint>.MoveNext
	|
	|-RVA: 0x1D004B0 Offset: 0x1D005B1 VA: 0x1D004B0
	|-Array.EmptyInternalEnumerator<GestureState>.MoveNext
	|
	|-RVA: 0x1D00730 Offset: 0x1D00831 VA: 0x1D00730
	|-Array.EmptyInternalEnumerator<GlyphMarshallingStruct>.MoveNext
	|
	|-RVA: 0x1D00940 Offset: 0x1D00A41 VA: 0x1D00940
	|-Array.EmptyInternalEnumerator<GlyphPairAdjustmentRecord>.MoveNext
	|
	|-RVA: 0x1D00B60 Offset: 0x1D00C61 VA: 0x1D00B60
	|-Array.EmptyInternalEnumerator<GlyphRect>.MoveNext
	|
	|-RVA: 0x1D00D50 Offset: 0x1D00E51 VA: 0x1D00D50
	|-Array.EmptyInternalEnumerator<Guid>.MoveNext
	|
	|-RVA: 0x1D00F40 Offset: 0x1D01041 VA: 0x1D00F40
	|-Array.EmptyInternalEnumerator<Hand>.MoveNext
	|
	|-RVA: 0x1D01150 Offset: 0x1D01251 VA: 0x1D01150
	|-Array.EmptyInternalEnumerator<HandAnalysisImageState>.MoveNext
	|
	|-RVA: 0x1D01340 Offset: 0x1D01441 VA: 0x1D01340
	|-Array.EmptyInternalEnumerator<HandAnalysisSilhouetteState>.MoveNext
	|
	|-RVA: 0x1D01550 Offset: 0x1D01651 VA: 0x1D01550
	|-Array.EmptyInternalEnumerator<HeaderVariantInfo>.MoveNext
	|
	|-RVA: 0x1D01740 Offset: 0x1D01841 VA: 0x1D01740
	|-Array.EmptyInternalEnumerator<HighlightState>.MoveNext
	|
	|-RVA: 0x1D01940 Offset: 0x1D01A41 VA: 0x1D01940
	|-Array.EmptyInternalEnumerator<HumanBone>.MoveNext
	|
	|-RVA: 0x1D01B60 Offset: 0x1D01C61 VA: 0x1D01B60
	|-Array.EmptyInternalEnumerator<short>.MoveNext
	|
	|-RVA: 0x1D01D40 Offset: 0x1D01E41 VA: 0x1D01D40
	|-Array.EmptyInternalEnumerator<int>.MoveNext
	|
	|-RVA: 0x1D01F20 Offset: 0x1D02021 VA: 0x1D01F20
	|-Array.EmptyInternalEnumerator<Int32Enum>.MoveNext
	|
	|-RVA: 0x1D02100 Offset: 0x1D02201 VA: 0x1D02100
	|-Array.EmptyInternalEnumerator<long>.MoveNext
	|
	|-RVA: 0x1D022E0 Offset: 0x1D023E1 VA: 0x1D022E0
	|-Array.EmptyInternalEnumerator<Int64Enum>.MoveNext
	|
	|-RVA: 0x1D024C0 Offset: 0x1D025C1 VA: 0x1D024C0
	|-Array.EmptyInternalEnumerator<IntPtr>.MoveNext
	|
	|-RVA: 0x1D026A0 Offset: 0x1D027A1 VA: 0x1D026A0
	|-Array.EmptyInternalEnumerator<InternalCodePageDataItem>.MoveNext
	|
	|-RVA: 0x1D02890 Offset: 0x1D02991 VA: 0x1D02890
	|-Array.EmptyInternalEnumerator<InternalEncodingDataItem>.MoveNext
	|
	|-RVA: 0x1D02A80 Offset: 0x1D02B81 VA: 0x1D02A80
	|-Array.EmptyInternalEnumerator<InterpretedFrameInfo>.MoveNext
	|
	|-RVA: 0x1D02C70 Offset: 0x1D02D71 VA: 0x1D02C70
	|-Array.EmptyInternalEnumerator<IntervalTreeNode>.MoveNext
	|
	|-RVA: 0x1D02E70 Offset: 0x1D02F71 VA: 0x1D02E70
	|-Array.EmptyInternalEnumerator<JobHandle>.MoveNext
	|
	|-RVA: 0x1D03060 Offset: 0x1D03161 VA: 0x1D03060
	|-Array.EmptyInternalEnumerator<Keyframe>.MoveNext
	|
	|-RVA: 0x1D03270 Offset: 0x1D03371 VA: 0x1D03270
	|-Array.EmptyInternalEnumerator<LOD>.MoveNext
	|
	|-RVA: 0x1D03460 Offset: 0x1D03561 VA: 0x1D03460
	|-Array.EmptyInternalEnumerator<LayerMask>.MoveNext
	|
	|-RVA: 0x1D03640 Offset: 0x1D03741 VA: 0x1D03640
	|-Array.EmptyInternalEnumerator<LengthLimitProperties>.MoveNext
	|
	|-RVA: 0x1D03820 Offset: 0x1D03921 VA: 0x1D03820
	|-Array.EmptyInternalEnumerator<Light2DBlendStyle>.MoveNext
	|
	|-RVA: 0x1D03A70 Offset: 0x1D03B71 VA: 0x1D03A70
	|-Array.EmptyInternalEnumerator<LightDataGI>.MoveNext
	|
	|-RVA: 0x1D03CF0 Offset: 0x1D03DF1 VA: 0x1D03CF0
	|-Array.EmptyInternalEnumerator<LocalDefinition>.MoveNext
	|
	|-RVA: 0x1D03EE0 Offset: 0x1D03FE1 VA: 0x1D03EE0
	|-Array.EmptyInternalEnumerator<MapPos>.MoveNext
	|
	|-RVA: 0x1D040C0 Offset: 0x1D041C1 VA: 0x1D040C0
	|-Array.EmptyInternalEnumerator<MapRange>.MoveNext
	|
	|-RVA: 0x1D042B0 Offset: 0x1D043B1 VA: 0x1D042B0
	|-Array.EmptyInternalEnumerator<MaterialReference>.MoveNext
	|
	|-RVA: 0x1D044C0 Offset: 0x1D045C1 VA: 0x1D044C0
	|-Array.EmptyInternalEnumerator<Matrix4x4>.MoveNext
	|
	|-RVA: 0x1D046E0 Offset: 0x1D047E1 VA: 0x1D046E0
	|-Array.EmptyInternalEnumerator<MomentProcessorState>.MoveNext
	|
	|-RVA: 0x1D048F0 Offset: 0x1D049F1 VA: 0x1D048F0
	|-Array.EmptyInternalEnumerator<MomentStatistic>.MoveNext
	|
	|-RVA: 0x1D04AE0 Offset: 0x1D04BE1 VA: 0x1D04AE0
	|-Array.EmptyInternalEnumerator<Navigation>.MoveNext
	|
	|-RVA: 0x1D04CF0 Offset: 0x1D04DF1 VA: 0x1D04CF0
	|-Array.EmptyInternalEnumerator<NetworkServiceAccountId>.MoveNext
	|
	|-RVA: 0x1D04ED0 Offset: 0x1D04FD1 VA: 0x1D04ED0
	|-Array.EmptyInternalEnumerator<NpadFullKeyState>.MoveNext
	|
	|-RVA: 0x1D050E0 Offset: 0x1D051E1 VA: 0x1D050E0
	|-Array.EmptyInternalEnumerator<NpadHandheldState>.MoveNext
	|
	|-RVA: 0x1D052F0 Offset: 0x1D053F1 VA: 0x1D052F0
	|-Array.EmptyInternalEnumerator<NpadJoyDualState>.MoveNext
	|
	|-RVA: 0x1D05500 Offset: 0x1D05601 VA: 0x1D05500
	|-Array.EmptyInternalEnumerator<NpadJoyLeftState>.MoveNext
	|
	|-RVA: 0x1D05710 Offset: 0x1D05811 VA: 0x1D05710
	|-Array.EmptyInternalEnumerator<NpadJoyRightState>.MoveNext
	|
	|-RVA: 0x1D05920 Offset: 0x1D05A21 VA: 0x1D05920
	|-Array.EmptyInternalEnumerator<NpadStateArrayItem>.MoveNext
	|
	|-RVA: 0x1D05B30 Offset: 0x1D05C31 VA: 0x1D05B30
	|-Array.EmptyInternalEnumerator<NsUid>.MoveNext
	|
	|-RVA: 0x1D05D10 Offset: 0x1D05E11 VA: 0x1D05D10
	|-Array.EmptyInternalEnumerator<object>.MoveNext
	|
	|-RVA: 0x1D05EB0 Offset: 0x1D05FB1 VA: 0x1D05EB0
	|-Array.EmptyInternalEnumerator<ObjectInitializationData>.MoveNext
	|
	|-RVA: 0x1D060C0 Offset: 0x1D061C1 VA: 0x1D060C0
	|-Array.EmptyInternalEnumerator<ParameterModifier>.MoveNext
	|
	|-RVA: 0x1D062A0 Offset: 0x1D063A1 VA: 0x1D062A0
	|-Array.EmptyInternalEnumerator<Plane>.MoveNext
	|
	|-RVA: 0x1D06490 Offset: 0x1D06591 VA: 0x1D06490
	|-Array.EmptyInternalEnumerator<Playable>.MoveNext
	|
	|-RVA: 0x1D06680 Offset: 0x1D06781 VA: 0x1D06680
	|-Array.EmptyInternalEnumerator<PlayableBinding>.MoveNext
	|
	|-RVA: 0x1D06880 Offset: 0x1D06981 VA: 0x1D06880
	|-Array.EmptyInternalEnumerator<PlayerLoopSystem>.MoveNext
	|
	|-RVA: 0x1D06A90 Offset: 0x1D06B91 VA: 0x1D06A90
	|-Array.EmptyInternalEnumerator<PlayerLoopSystemInternal>.MoveNext
	|
	|-RVA: 0x1D06CA0 Offset: 0x1D06DA1 VA: 0x1D06CA0
	|-Array.EmptyInternalEnumerator<PreTile>.MoveNext
	|
	|-RVA: 0x1D06EC0 Offset: 0x1D06FC1 VA: 0x1D06EC0
	|-Array.EmptyInternalEnumerator<Profile>.MoveNext
	|
	|-RVA: 0x1D070D0 Offset: 0x1D071D1 VA: 0x1D070D0
	|-Array.EmptyInternalEnumerator<Protrusion>.MoveNext
	|
	|-RVA: 0x1D072B0 Offset: 0x1D073B1 VA: 0x1D072B0
	|-Array.EmptyInternalEnumerator<Quaternion>.MoveNext
	|
	|-RVA: 0x1D074A0 Offset: 0x1D075A1 VA: 0x1D074A0
	|-Array.EmptyInternalEnumerator<RandomSeed>.MoveNext
	|
	|-RVA: 0x1D07690 Offset: 0x1D07791 VA: 0x1D07690
	|-Array.EmptyInternalEnumerator<RangePositionInfo>.MoveNext
	|
	|-RVA: 0x1D07880 Offset: 0x1D07981 VA: 0x1D07880
	|-Array.EmptyInternalEnumerator<Ranking2ChartInfoInput>.MoveNext
	|
	|-RVA: 0x1D07A60 Offset: 0x1D07B61 VA: 0x1D07A60
	|-Array.EmptyInternalEnumerator<RaycastHit>.MoveNext
	|
	|-RVA: 0x1D07C80 Offset: 0x1D07D81 VA: 0x1D07C80
	|-Array.EmptyInternalEnumerator<RaycastHit2D>.MoveNext
	|
	|-RVA: 0x1D07E90 Offset: 0x1D07F91 VA: 0x1D07E90
	|-Array.EmptyInternalEnumerator<RaycastResult>.MoveNext
	|
	|-RVA: 0x1D080E0 Offset: 0x1D081E1 VA: 0x1D080E0
	|-Array.EmptyInternalEnumerator<Rect>.MoveNext
	|
	|-RVA: 0x1D082D0 Offset: 0x1D083D1 VA: 0x1D082D0
	|-Array.EmptyInternalEnumerator<RenderBuffer>.MoveNext
	|
	|-RVA: 0x1D084C0 Offset: 0x1D085C1 VA: 0x1D084C0
	|-Array.EmptyInternalEnumerator<RenderStateBlock>.MoveNext
	|
	|-RVA: 0x1D08760 Offset: 0x1D08861 VA: 0x1D08760
	|-Array.EmptyInternalEnumerator<RenderTargetHandle>.MoveNext
	|
	|-RVA: 0x1D08970 Offset: 0x1D08A71 VA: 0x1D08970
	|-Array.EmptyInternalEnumerator<RenderTargetIdentifier>.MoveNext
	|
	|-RVA: 0x1D08B80 Offset: 0x1D08C81 VA: 0x1D08B80
	|-Array.EmptyInternalEnumerator<RendererListHandle>.MoveNext
	|
	|-RVA: 0x1D08D60 Offset: 0x1D08E61 VA: 0x1D08D60
	|-Array.EmptyInternalEnumerator<ResourceHandle>.MoveNext
	|
	|-RVA: 0x1D08F40 Offset: 0x1D09041 VA: 0x1D08F40
	|-Array.EmptyInternalEnumerator<ResourceLocator>.MoveNext
	|
	|-RVA: 0x1D09130 Offset: 0x1D09231 VA: 0x1D09130
	|-Array.EmptyInternalEnumerator<RichTextTagAttribute>.MoveNext
	|
	|-RVA: 0x1D09330 Offset: 0x1D09431 VA: 0x1D09330
	|-Array.EmptyInternalEnumerator<RuntimeLabel>.MoveNext
	|
	|-RVA: 0x1D09520 Offset: 0x1D09621 VA: 0x1D09520
	|-Array.EmptyInternalEnumerator<sbyte>.MoveNext
	|
	|-RVA: 0x1D09700 Offset: 0x1D09801 VA: 0x1D09700
	|-Array.EmptyInternalEnumerator<SerializedType>.MoveNext
	|
	|-RVA: 0x1D09900 Offset: 0x1D09A01 VA: 0x1D09900
	|-Array.EmptyInternalEnumerator<ShaderKeyword>.MoveNext
	|
	|-RVA: 0x1D09AE0 Offset: 0x1D09BE1 VA: 0x1D09AE0
	|-Array.EmptyInternalEnumerator<ShaderTagId>.MoveNext
	|
	|-RVA: 0x1D09CC0 Offset: 0x1D09DC1 VA: 0x1D09CC0
	|-Array.EmptyInternalEnumerator<ShadowSliceData>.MoveNext
	|
	|-RVA: 0x1D09ED0 Offset: 0x1D09FD1 VA: 0x1D09ED0
	|-Array.EmptyInternalEnumerator<Shape>.MoveNext
	|
	|-RVA: 0x1D0A0D0 Offset: 0x1D0A1D1 VA: 0x1D0A0D0
	|-Array.EmptyInternalEnumerator<float>.MoveNext
	|
	|-RVA: 0x1D0A2B0 Offset: 0x1D0A3B1 VA: 0x1D0A2B0
	|-Array.EmptyInternalEnumerator<SixAxisSensorHandle>.MoveNext
	|
	|-RVA: 0x1D0A490 Offset: 0x1D0A591 VA: 0x1D0A490
	|-Array.EmptyInternalEnumerator<SixAxisSensorState>.MoveNext
	|
	|-RVA: 0x1D0A710 Offset: 0x1D0A811 VA: 0x1D0A710
	|-Array.EmptyInternalEnumerator<SkeletonBone>.MoveNext
	|
	|-RVA: 0x1D0A920 Offset: 0x1D0AA21 VA: 0x1D0A920
	|-Array.EmptyInternalEnumerator<SortingLayer>.MoveNext
	|
	|-RVA: 0x1D0AB00 Offset: 0x1D0AC01 VA: 0x1D0AB00
	|-Array.EmptyInternalEnumerator<SphericalHarmonicsL2>.MoveNext
	|
	|-RVA: 0x1D0ADA0 Offset: 0x1D0AEA1 VA: 0x1D0ADA0
	|-Array.EmptyInternalEnumerator<SpinLock>.MoveNext
	|
	|-RVA: 0x1D0AF80 Offset: 0x1D0B081 VA: 0x1D0AF80
	|-Array.EmptyInternalEnumerator<SpringBoneComponents>.MoveNext
	|
	|-RVA: 0x1D0B1D0 Offset: 0x1D0B2D1 VA: 0x1D0B1D0
	|-Array.EmptyInternalEnumerator<SpringBoneProperties>.MoveNext
	|
	|-RVA: 0x1D0B3E0 Offset: 0x1D0B4E1 VA: 0x1D0B3E0
	|-Array.EmptyInternalEnumerator<SpringColliderComponents>.MoveNext
	|
	|-RVA: 0x1D0B690 Offset: 0x1D0B791 VA: 0x1D0B690
	|-Array.EmptyInternalEnumerator<SpringColliderProperties>.MoveNext
	|
	|-RVA: 0x1D0B880 Offset: 0x1D0B981 VA: 0x1D0B880
	|-Array.EmptyInternalEnumerator<SpringForceComponent>.MoveNext
	|
	|-RVA: 0x1D0BAA0 Offset: 0x1D0BBA1 VA: 0x1D0BAA0
	|-Array.EmptyInternalEnumerator<SpringJobElement>.MoveNext
	|
	|-RVA: 0x1D0BCB0 Offset: 0x1D0BDB1 VA: 0x1D0BCB0
	|-Array.EmptyInternalEnumerator<SpriteState>.MoveNext
	|
	|-RVA: 0x1D0BEB0 Offset: 0x1D0BFB1 VA: 0x1D0BEB0
	|-Array.EmptyInternalEnumerator<SubMeshDescriptor>.MoveNext
	|
	|-RVA: 0x1D0C0C0 Offset: 0x1D0C1C1 VA: 0x1D0C0C0
	|-Array.EmptyInternalEnumerator<TMP_CharacterInfo>.MoveNext
	|
	|-RVA: 0x1D0C2D0 Offset: 0x1D0C3D1 VA: 0x1D0C2D0
	|-Array.EmptyInternalEnumerator<TMP_FontWeightPair>.MoveNext
	|
	|-RVA: 0x1D0C4C0 Offset: 0x1D0C5C1 VA: 0x1D0C4C0
	|-Array.EmptyInternalEnumerator<TMP_LineInfo>.MoveNext
	|
	|-RVA: 0x1D0C740 Offset: 0x1D0C841 VA: 0x1D0C740
	|-Array.EmptyInternalEnumerator<TMP_LinkInfo>.MoveNext
	|
	|-RVA: 0x1D0C950 Offset: 0x1D0CA51 VA: 0x1D0C950
	|-Array.EmptyInternalEnumerator<TMP_MeshInfo>.MoveNext
	|
	|-RVA: 0x1D0CBA0 Offset: 0x1D0CCA1 VA: 0x1D0CBA0
	|-Array.EmptyInternalEnumerator<TMP_PageInfo>.MoveNext
	|
	|-RVA: 0x1D0CDA0 Offset: 0x1D0CEA1 VA: 0x1D0CDA0
	|-Array.EmptyInternalEnumerator<TMP_WordInfo>.MoveNext
	|
	|-RVA: 0x1D0CFA0 Offset: 0x1D0D0A1 VA: 0x1D0CFA0
	|-Array.EmptyInternalEnumerator<TablePair>.MoveNext
	|
	|-RVA: 0x1D0D190 Offset: 0x1D0D291 VA: 0x1D0D190
	|-Array.EmptyInternalEnumerator<TextureHandle>.MoveNext
	|
	|-RVA: 0x1D0D370 Offset: 0x1D0D471 VA: 0x1D0D370
	|-Array.EmptyInternalEnumerator<TimeSpan>.MoveNext
	|
	|-RVA: 0x1D0D550 Offset: 0x1D0D651 VA: 0x1D0D550
	|-Array.EmptyInternalEnumerator<Touch>.MoveNext
	|
	|-RVA: 0x1D0D7A0 Offset: 0x1D0D8A1 VA: 0x1D0D7A0
	|-Array.EmptyInternalEnumerator<TouchScreenState1>.MoveNext
	|
	|-RVA: 0x1D0D9B0 Offset: 0x1D0DAB1 VA: 0x1D0D9B0
	|-Array.EmptyInternalEnumerator<TouchScreenState10>.MoveNext
	|
	|-RVA: 0x1D0DBC0 Offset: 0x1D0DCC1 VA: 0x1D0DBC0
	|-Array.EmptyInternalEnumerator<TouchScreenState11>.MoveNext
	|
	|-RVA: 0x1D0DDD0 Offset: 0x1D0DED1 VA: 0x1D0DDD0
	|-Array.EmptyInternalEnumerator<TouchScreenState12>.MoveNext
	|
	|-RVA: 0x1D0DFE0 Offset: 0x1D0E0E1 VA: 0x1D0DFE0
	|-Array.EmptyInternalEnumerator<TouchScreenState13>.MoveNext
	|
	|-RVA: 0x1D0E1F0 Offset: 0x1D0E2F1 VA: 0x1D0E1F0
	|-Array.EmptyInternalEnumerator<TouchScreenState14>.MoveNext
	|
	|-RVA: 0x1D0E400 Offset: 0x1D0E501 VA: 0x1D0E400
	|-Array.EmptyInternalEnumerator<TouchScreenState15>.MoveNext
	|
	|-RVA: 0x1D0E610 Offset: 0x1D0E711 VA: 0x1D0E610
	|-Array.EmptyInternalEnumerator<TouchScreenState16>.MoveNext
	|
	|-RVA: 0x1D0E820 Offset: 0x1D0E921 VA: 0x1D0E820
	|-Array.EmptyInternalEnumerator<TouchScreenState2>.MoveNext
	|
	|-RVA: 0x1D0EAA0 Offset: 0x1D0EBA1 VA: 0x1D0EAA0
	|-Array.EmptyInternalEnumerator<TouchScreenState3>.MoveNext
	|
	|-RVA: 0x1D0ECB0 Offset: 0x1D0EDB1 VA: 0x1D0ECB0
	|-Array.EmptyInternalEnumerator<TouchScreenState4>.MoveNext
	|
	|-RVA: 0x1D0EEC0 Offset: 0x1D0EFC1 VA: 0x1D0EEC0
	|-Array.EmptyInternalEnumerator<TouchScreenState5>.MoveNext
	|
	|-RVA: 0x1D0F0D0 Offset: 0x1D0F1D1 VA: 0x1D0F0D0
	|-Array.EmptyInternalEnumerator<TouchScreenState6>.MoveNext
	|
	|-RVA: 0x1D0F2E0 Offset: 0x1D0F3E1 VA: 0x1D0F2E0
	|-Array.EmptyInternalEnumerator<TouchScreenState7>.MoveNext
	|
	|-RVA: 0x1D0F4F0 Offset: 0x1D0F5F1 VA: 0x1D0F4F0
	|-Array.EmptyInternalEnumerator<TouchScreenState8>.MoveNext
	|
	|-RVA: 0x1D0F700 Offset: 0x1D0F801 VA: 0x1D0F700
	|-Array.EmptyInternalEnumerator<TouchScreenState9>.MoveNext
	|
	|-RVA: 0x1D0F910 Offset: 0x1D0FA11 VA: 0x1D0F910
	|-Array.EmptyInternalEnumerator<TouchState>.MoveNext
	|
	|-RVA: 0x1D0FB20 Offset: 0x1D0FC21 VA: 0x1D0FB20
	|-Array.EmptyInternalEnumerator<TrailHand>.MoveNext
	|
	|-RVA: 0x1D0FD20 Offset: 0x1D0FE21 VA: 0x1D0FD20
	|-Array.EmptyInternalEnumerator<TrailVertex>.MoveNext
	|
	|-RVA: 0x1D0FF20 Offset: 0x1D10021 VA: 0x1D0FF20
	|-Array.EmptyInternalEnumerator<UICharInfo>.MoveNext
	|
	|-RVA: 0x1D10110 Offset: 0x1D10211 VA: 0x1D10110
	|-Array.EmptyInternalEnumerator<UILineInfo>.MoveNext
	|
	|-RVA: 0x1D10300 Offset: 0x1D10401 VA: 0x1D10300
	|-Array.EmptyInternalEnumerator<UIVertex>.MoveNext
	|
	|-RVA: 0x1D105A0 Offset: 0x1D106A1 VA: 0x1D105A0
	|-Array.EmptyInternalEnumerator<ushort>.MoveNext
	|
	|-RVA: 0x1D10780 Offset: 0x1D10881 VA: 0x1D10780
	|-Array.EmptyInternalEnumerator<UInt16Enum>.MoveNext
	|
	|-RVA: 0x1D10960 Offset: 0x1D10A61 VA: 0x1D10960
	|-Array.EmptyInternalEnumerator<uint>.MoveNext
	|
	|-RVA: 0x1D10B40 Offset: 0x1D10C41 VA: 0x1D10B40
	|-Array.EmptyInternalEnumerator<UInt32Enum>.MoveNext
	|
	|-RVA: 0x1D10D20 Offset: 0x1D10E21 VA: 0x1D10D20
	|-Array.EmptyInternalEnumerator<ulong>.MoveNext
	|
	|-RVA: 0x1D10F00 Offset: 0x1D11001 VA: 0x1D10F00
	|-Array.EmptyInternalEnumerator<Uid>.MoveNext
	|
	|-RVA: 0x1D110F0 Offset: 0x1D111F1 VA: 0x1D110F0
	|-Array.EmptyInternalEnumerator<UniTask>.MoveNext
	|
	|-RVA: 0x1D112D0 Offset: 0x1D113D1 VA: 0x1D112D0
	|-Array.EmptyInternalEnumerator<Unit>.MoveNext
	|
	|-RVA: 0x1D114B0 Offset: 0x1D115B1 VA: 0x1D114B0
	|-Array.EmptyInternalEnumerator<UnitEnum>.MoveNext
	|
	|-RVA: 0x1D11690 Offset: 0x1D11791 VA: 0x1D11690
	|-Array.EmptyInternalEnumerator<UserWord>.MoveNext
	|
	|-RVA: 0x1D11880 Offset: 0x1D11981 VA: 0x1D11880
	|-Array.EmptyInternalEnumerator<Vector2>.MoveNext
	|
	|-RVA: 0x1D11A60 Offset: 0x1D11B61 VA: 0x1D11A60
	|-Array.EmptyInternalEnumerator<Vector2Int>.MoveNext
	|
	|-RVA: 0x1D11C40 Offset: 0x1D11D41 VA: 0x1D11C40
	|-Array.EmptyInternalEnumerator<Vector3>.MoveNext
	|
	|-RVA: 0x1D11E30 Offset: 0x1D11F31 VA: 0x1D11E30
	|-Array.EmptyInternalEnumerator<Vector4>.MoveNext
	|
	|-RVA: 0x1D12020 Offset: 0x1D12121 VA: 0x1D12020
	|-Array.EmptyInternalEnumerator<VertexAttributeDescriptor>.MoveNext
	|
	|-RVA: 0x1D12210 Offset: 0x1D12311 VA: 0x1D12210
	|-Array.EmptyInternalEnumerator<VibrationDeviceHandle>.MoveNext
	|
	|-RVA: 0x1D123F0 Offset: 0x1D124F1 VA: 0x1D123F0
	|-Array.EmptyInternalEnumerator<VibrationDeviceInfo>.MoveNext
	|
	|-RVA: 0x1D125D0 Offset: 0x1D126D1 VA: 0x1D125D0
	|-Array.EmptyInternalEnumerator<VibrationValue>.MoveNext
	|
	|-RVA: 0x1D127C0 Offset: 0x1D128C1 VA: 0x1D127C0
	|-Array.EmptyInternalEnumerator<VisibleLight>.MoveNext
	|
	|-RVA: 0x1D12A60 Offset: 0x1D12B61 VA: 0x1D12A60
	|-Array.EmptyInternalEnumerator<WordWrapState>.MoveNext
	|
	|-RVA: 0x1D12C70 Offset: 0x1D12D71 VA: 0x1D12C70
	|-Array.EmptyInternalEnumerator<X509ChainStatus>.MoveNext
	|
	|-RVA: 0x1D12E60 Offset: 0x1D12F61 VA: 0x1D12E60
	|-Array.EmptyInternalEnumerator<XPathNode>.MoveNext
	|
	|-RVA: 0x1D13060 Offset: 0x1D13161 VA: 0x1D13060
	|-Array.EmptyInternalEnumerator<XPathNodeRef>.MoveNext
	|
	|-RVA: 0x1D13250 Offset: 0x1D13351 VA: 0x1D13250
	|-Array.EmptyInternalEnumerator<XRView>.MoveNext
	|
	|-RVA: 0x1D13460 Offset: 0x1D13561 VA: 0x1D13460
	|-Array.EmptyInternalEnumerator<float3>.MoveNext
	|
	|-RVA: 0x1D13650 Offset: 0x1D13751 VA: 0x1D13650
	|-Array.EmptyInternalEnumerator<float4x4>.MoveNext
	|
	|-RVA: 0x1D13870 Offset: 0x1D13971 VA: 0x1D13870
	|-Array.EmptyInternalEnumerator<jvalue>.MoveNext
	|
	|-RVA: 0x1D13A50 Offset: 0x1D13B51 VA: 0x1D13A50
	|-Array.EmptyInternalEnumerator<uint4>.MoveNext
	|
	|-RVA: 0x1D13C40 Offset: 0x1D13D41 VA: 0x1D13C40
	|-Array.EmptyInternalEnumerator<AICrossfire.PositionTable>.MoveNext
	|
	|-RVA: 0x1D13E30 Offset: 0x1D13F31 VA: 0x1D13E30
	|-Array.EmptyInternalEnumerator<AIEnum.SkillRangeEnemyData>.MoveNext
	|
	|-RVA: 0x1D14020 Offset: 0x1D14121 VA: 0x1D14020
	|-Array.EmptyInternalEnumerator<AIOrder.UnitPriority>.MoveNext
	|
	|-RVA: 0x1D14200 Offset: 0x1D14301 VA: 0x1D14200
	|-Array.EmptyInternalEnumerator<AmiiboSequence.GainItemData>.MoveNext
	|
	|-RVA: 0x1D143F0 Offset: 0x1D144F1 VA: 0x1D143F0
	|-Array.EmptyInternalEnumerator<AnimationOutputWeightProcessor.WeightInfo>.MoveNext
	|
	|-RVA: 0x1D14600 Offset: 0x1D14701 VA: 0x1D14600
	|-Array.EmptyInternalEnumerator<ArenaOrderSequence.GodInfo>.MoveNext
	|
	|-RVA: 0x1D147F0 Offset: 0x1D148F1 VA: 0x1D147F0
	|-Array.EmptyInternalEnumerator<BattleInfo.SupportData>.MoveNext
	|
	|-RVA: 0x1D149E0 Offset: 0x1D14AE1 VA: 0x1D149E0
	|-Array.EmptyInternalEnumerator<BeforeRenderHelper.OrderBlock>.MoveNext
	|
	|-RVA: 0x1D14BD0 Offset: 0x1D14CD1 VA: 0x1D14BD0
	|-Array.EmptyInternalEnumerator<Camera.RenderRequest>.MoveNext
	|
	|-RVA: 0x1D14DD0 Offset: 0x1D14ED1 VA: 0x1D14DD0
	|-Array.EmptyInternalEnumerator<CameraState.CustomBlendable>.MoveNext
	|
	|-RVA: 0x1D14FC0 Offset: 0x1D150C1 VA: 0x1D14FC0
	|-Array.EmptyInternalEnumerator<CinemachineBlendListCamera.Instruction>.MoveNext
	|
	|-RVA: 0x1D151C0 Offset: 0x1D152C1 VA: 0x1D151C0
	|-Array.EmptyInternalEnumerator<CinemachineBlenderSettings.CustomBlend>.MoveNext
	|
	|-RVA: 0x1D153C0 Offset: 0x1D154C1 VA: 0x1D153C0
	|-Array.EmptyInternalEnumerator<CinemachineClearShot.Pair>.MoveNext
	|
	|-RVA: 0x1D155A0 Offset: 0x1D156A1 VA: 0x1D155A0
	|-Array.EmptyInternalEnumerator<CinemachineFreeLook.Orbit>.MoveNext
	|
	|-RVA: 0x1D15780 Offset: 0x1D15881 VA: 0x1D15780
	|-Array.EmptyInternalEnumerator<CinemachinePath.Waypoint>.MoveNext
	|
	|-RVA: 0x1D15990 Offset: 0x1D15A91 VA: 0x1D15990
	|-Array.EmptyInternalEnumerator<CinemachineSmoothPath.Waypoint>.MoveNext
	|
	|-RVA: 0x1D15B80 Offset: 0x1D15C81 VA: 0x1D15B80
	|-Array.EmptyInternalEnumerator<CinemachineStateDrivenCamera.HashPair>.MoveNext
	|
	|-RVA: 0x1D15D60 Offset: 0x1D15E61 VA: 0x1D15D60
	|-Array.EmptyInternalEnumerator<CinemachineStateDrivenCamera.Instruction>.MoveNext
	|
	|-RVA: 0x1D15F60 Offset: 0x1D16061 VA: 0x1D15F60
	|-Array.EmptyInternalEnumerator<CinemachineStateDrivenCamera.ParentHash>.MoveNext
	|
	|-RVA: 0x1D16140 Offset: 0x1D16241 VA: 0x1D16140
	|-Array.EmptyInternalEnumerator<CinemachineTargetGroup.Target>.MoveNext
	|
	|-RVA: 0x1D16330 Offset: 0x1D16431 VA: 0x1D16330
	|-Array.EmptyInternalEnumerator<CodePointIndexer.TableRange>.MoveNext
	|
	|-RVA: 0x1D16530 Offset: 0x1D16631 VA: 0x1D16530
	|-Array.EmptyInternalEnumerator<ContentCatalogData.Bucket>.MoveNext
	|
	|-RVA: 0x1D16720 Offset: 0x1D16821 VA: 0x1D16720
	|-Array.EmptyInternalEnumerator<CookieTokenizer.RecognizedAttribute>.MoveNext
	|
	|-RVA: 0x1D16910 Offset: 0x1D16A11 VA: 0x1D16910
	|-Array.EmptyInternalEnumerator<DeferredLights.DrawCall>.MoveNext
	|
	|-RVA: 0x1D16B20 Offset: 0x1D16C21 VA: 0x1D16B20
	|-Array.EmptyInternalEnumerator<DeferredShaderData.ComputeBufferInfo>.MoveNext
	|
	|-RVA: 0x1D16D00 Offset: 0x1D16E01 VA: 0x1D16D00
	|-Array.EmptyInternalEnumerator<DeferredTiler.PrePunctualLight>.MoveNext
	|
	|-RVA: 0x1D16F00 Offset: 0x1D17001 VA: 0x1D16F00
	|-Array.EmptyInternalEnumerator<DelayedActionManager.DelegateInfo>.MoveNext
	|
	|-RVA: 0x1D17100 Offset: 0x1D17201 VA: 0x1D17100
	|-Array.EmptyInternalEnumerator<Detail.AsyncResultInt>.MoveNext
	|
	|-RVA: 0x1D17310 Offset: 0x1D17411 VA: 0x1D17310
	|-Array.EmptyInternalEnumerator<Detail.CppArray>.MoveNext
	|
	|-RVA: 0x1D17500 Offset: 0x1D17601 VA: 0x1D17500
	|-Array.EmptyInternalEnumerator<Detail.NotificationEventInt>.MoveNext
	|
	|-RVA: 0x1D17710 Offset: 0x1D17811 VA: 0x1D17710
	|-Array.EmptyInternalEnumerator<DisposUnit.Item>.MoveNext
	|
	|-RVA: 0x1D17900 Offset: 0x1D17A01 VA: 0x1D17900
	|-Array.EmptyInternalEnumerator<DragonRidePresetParamData.CourseData>.MoveNext
	|
	|-RVA: 0x1D17AF0 Offset: 0x1D17BF1 VA: 0x1D17AF0
	|-Array.EmptyInternalEnumerator<DragonRideTargetGroup.ChainParam>.MoveNext
	|
	|-RVA: 0x1D17CE0 Offset: 0x1D17DE1 VA: 0x1D17CE0
	|-Array.EmptyInternalEnumerator<DynamicMesh.State>.MoveNext
	|
	|-RVA: 0x1D17EC0 Offset: 0x1D17FC1 VA: 0x1D17EC0
	|-Array.EmptyInternalEnumerator<FXZEx.HitPoint>.MoveNext
	|
	|-RVA: 0x1D180D0 Offset: 0x1D181D1 VA: 0x1D180D0
	|-Array.EmptyInternalEnumerator<FishingRadicalParamData.RadicalParam>.MoveNext
	|
	|-RVA: 0x1D182C0 Offset: 0x1D183C1 VA: 0x1D182C0
	|-Array.EmptyInternalEnumerator<GameVariable.Value>.MoveNext
	|
	|-RVA: 0x1D184B0 Offset: 0x1D185B1 VA: 0x1D184B0
	|-Array.EmptyInternalEnumerator<GmapPathAdjuster.TargetModel>.MoveNext
	|
	|-RVA: 0x1D186B0 Offset: 0x1D187B1 VA: 0x1D186B0
	|-Array.EmptyInternalEnumerator<GmapSpotAdjuster.TargetModel>.MoveNext
	|
	|-RVA: 0x1D188B0 Offset: 0x1D189B1 VA: 0x1D188B0
	|-Array.EmptyInternalEnumerator<GrounderQuadruped.Foot>.MoveNext
	|
	|-RVA: 0x1D18AC0 Offset: 0x1D18BC1 VA: 0x1D18AC0
	|-Array.EmptyInternalEnumerator<Hashtable.bucket>.MoveNext
	|
	|-RVA: 0x1D18CC0 Offset: 0x1D18DC1 VA: 0x1D18CC0
	|-Array.EmptyInternalEnumerator<HeadingTracker.Item>.MoveNext
	|
	|-RVA: 0x1D18EC0 Offset: 0x1D18FC1 VA: 0x1D18EC0
	|-Array.EmptyInternalEnumerator<HubAccessoryRoomCamera.BackgroundSettings>.MoveNext
	|
	|-RVA: 0x1D190D0 Offset: 0x1D191D1 VA: 0x1D190D0
	|-Array.EmptyInternalEnumerator<HubFastTravel.Location>.MoveNext
	|
	|-RVA: 0x1D192D0 Offset: 0x1D193D1 VA: 0x1D192D0
	|-Array.EmptyInternalEnumerator<HubLensFlare.Flare>.MoveNext
	|
	|-RVA: 0x1D194E0 Offset: 0x1D195E1 VA: 0x1D194E0
	|-Array.EmptyInternalEnumerator<HubLookAtController.LookAtIKParam>.MoveNext
	|
	|-RVA: 0x1D196D0 Offset: 0x1D197D1 VA: 0x1D196D0
	|-Array.EmptyInternalEnumerator<HubMaterialArray.MaterialInfo>.MoveNext
	|
	|-RVA: 0x1D198C0 Offset: 0x1D199C1 VA: 0x1D198C0
	|-Array.EmptyInternalEnumerator<IKSolverLimb.AxisDirection>.MoveNext
	|
	|-RVA: 0x1D19AD0 Offset: 0x1D19BD1 VA: 0x1D19AD0
	|-Array.EmptyInternalEnumerator<InventoryPoolItemMenuContent.KindBgNameClass>.MoveNext
	|
	|-RVA: 0x1D19CC0 Offset: 0x1D19DC1 VA: 0x1D19CC0
	|-Array.EmptyInternalEnumerator<LightUtility.ParametricLightMeshVertex>.MoveNext
	|
	|-RVA: 0x1D19ED0 Offset: 0x1D19FD1 VA: 0x1D19ED0
	|-Array.EmptyInternalEnumerator<LightUtility.SpriteLightMeshVertex>.MoveNext
	|
	|-RVA: 0x1D1A0E0 Offset: 0x1D1A1E1 VA: 0x1D1A0E0
	|-Array.EmptyInternalEnumerator<Map.Pos>.MoveNext
	|
	|-RVA: 0x1D1A2C0 Offset: 0x1D1A3C1 VA: 0x1D1A2C0
	|-Array.EmptyInternalEnumerator<MapGodExp.KindDesc>.MoveNext
	|
	|-RVA: 0x1D1A4B0 Offset: 0x1D1A5B1 VA: 0x1D1A4B0
	|-Array.EmptyInternalEnumerator<MapHistory.Command>.MoveNext
	|
	|-RVA: 0x1D1A690 Offset: 0x1D1A791 VA: 0x1D1A690
	|-Array.EmptyInternalEnumerator<MapImage.BackupTerrain>.MoveNext
	|
	|-RVA: 0x1D1A880 Offset: 0x1D1A981 VA: 0x1D1A880
	|-Array.EmptyInternalEnumerator<MapImageRange.Pos>.MoveNext
	|
	|-RVA: 0x1D1AA60 Offset: 0x1D1AB61 VA: 0x1D1AA60
	|-Array.EmptyInternalEnumerator<MapKillBonus.KillBonus>.MoveNext
	|
	|-RVA: 0x1D1AC40 Offset: 0x1D1AD41 VA: 0x1D1AC40
	|-Array.EmptyInternalEnumerator<MapKillBonus.KilledBonus>.MoveNext
	|
	|-RVA: 0x1D1AE20 Offset: 0x1D1AF21 VA: 0x1D1AE20
	|-Array.EmptyInternalEnumerator<MapMind.Record>.MoveNext
	|
	|-RVA: 0x1D1B070 Offset: 0x1D1B171 VA: 0x1D1B070
	|-Array.EmptyInternalEnumerator<MapMind.Target>.MoveNext
	|
	|-RVA: 0x1D1B270 Offset: 0x1D1B371 VA: 0x1D1B270
	|-Array.EmptyInternalEnumerator<MapPanelDebug.Entity>.MoveNext
	|
	|-RVA: 0x1D1B470 Offset: 0x1D1B571 VA: 0x1D1B470
	|-Array.EmptyInternalEnumerator<NexRanking.Data>.MoveNext
	|
	|-RVA: 0x1D1B650 Offset: 0x1D1B751 VA: 0x1D1B650
	|-Array.EmptyInternalEnumerator<NexVersus.RatingData>.MoveNext
	|
	|-RVA: 0x1D1B840 Offset: 0x1D1B941 VA: 0x1D1B840
	|-Array.EmptyInternalEnumerator<NoiseSettings.TransformNoiseParams>.MoveNext
	|
	|-RVA: 0x1D1BA50 Offset: 0x1D1BB51 VA: 0x1D1BA50
	|-Array.EmptyInternalEnumerator<PackedPlayModeBuildLogs.RuntimeBuildLog>.MoveNext
	|
	|-RVA: 0x1D1BC40 Offset: 0x1D1BD41 VA: 0x1D1BC40
	|-Array.EmptyInternalEnumerator<ParameterizedStrings.FormatParam>.MoveNext
	|
	|-RVA: 0x1D1BE30 Offset: 0x1D1BF31 VA: 0x1D1BE30
	|-Array.EmptyInternalEnumerator<ParticleSystem.Particle>.MoveNext
	|
	|-RVA: 0x1D1C040 Offset: 0x1D1C141 VA: 0x1D1C040
	|-Array.EmptyInternalEnumerator<ProfileCard.Achievement>.MoveNext
	|
	|-RVA: 0x1D1C220 Offset: 0x1D1C321 VA: 0x1D1C220
	|-Array.EmptyInternalEnumerator<ProfileCard.SortieCount>.MoveNext
	|
	|-RVA: 0x1D1C420 Offset: 0x1D1C521 VA: 0x1D1C420
	|-Array.EmptyInternalEnumerator<QualitySettingsStack.Settings>.MoveNext
	|
	|-RVA: 0x1D1C630 Offset: 0x1D1C731 VA: 0x1D1C630
	|-Array.EmptyInternalEnumerator<RangeData.Offset>.MoveNext
	|
	|-RVA: 0x1D1C810 Offset: 0x1D1C911 VA: 0x1D1C810
	|-Array.EmptyInternalEnumerator<RegexCharClass.LowerCaseMapping>.MoveNext
	|
	|-RVA: 0x1D1CA00 Offset: 0x1D1CB01 VA: 0x1D1CA00
	|-Array.EmptyInternalEnumerator<Relay.ChooseAwardeeData>.MoveNext
	|
	|-RVA: 0x1D1CC00 Offset: 0x1D1CD01 VA: 0x1D1CC00
	|-Array.EmptyInternalEnumerator<RelayAwardData.Info>.MoveNext
	|
	|-RVA: 0x1D1CDF0 Offset: 0x1D1CEF1 VA: 0x1D1CDF0
	|-Array.EmptyInternalEnumerator<RenderGraph.CompiledPassInfo>.MoveNext
	|
	|-RVA: 0x1D1D040 Offset: 0x1D1D141 VA: 0x1D1D040
	|-Array.EmptyInternalEnumerator<RenderGraph.CompiledResourceInfo>.MoveNext
	|
	|-RVA: 0x1D1D240 Offset: 0x1D1D341 VA: 0x1D1D240
	|-Array.EmptyInternalEnumerator<RenderGraphDebugData.PassDebugData>.MoveNext
	|
	|-RVA: 0x1D1D440 Offset: 0x1D1D541 VA: 0x1D1D440
	|-Array.EmptyInternalEnumerator<RenderGraphDebugData.ResourceDebugData>.MoveNext
	|
	|-RVA: 0x1D1D650 Offset: 0x1D1D751 VA: 0x1D1D650
	|-Array.EmptyInternalEnumerator<RenderGraphResourceRegistry.RendererListResource>.MoveNext
	|
	|-RVA: 0x1D1D860 Offset: 0x1D1D961 VA: 0x1D1D860
	|-Array.EmptyInternalEnumerator<RingCleaningUnitSelectMenu.GodParam>.MoveNext
	|
	|-RVA: 0x1D1DA50 Offset: 0x1D1DB51 VA: 0x1D1DA50
	|-Array.EmptyInternalEnumerator<SampleWave.Data>.MoveNext
	|
	|-RVA: 0x1D1DC40 Offset: 0x1D1DD41 VA: 0x1D1DC40
	|-Array.EmptyInternalEnumerator<SampleWave.Temp>.MoveNext
	|
	|-RVA: 0x1D1DE20 Offset: 0x1D1DF21 VA: 0x1D1DE20
	|-Array.EmptyInternalEnumerator<SendMouseEvents.HitInfo>.MoveNext
	|
	|-RVA: 0x1D1E010 Offset: 0x1D1E111 VA: 0x1D1E010
	|-Array.EmptyInternalEnumerator<SequenceNode.SequenceConstructPosContext>.MoveNext
	|
	|-RVA: 0x1D1E220 Offset: 0x1D1E321 VA: 0x1D1E220
	|-Array.EmptyInternalEnumerator<ShaderInput.LightData>.MoveNext
	|
	|-RVA: 0x1D1E470 Offset: 0x1D1E571 VA: 0x1D1E470
	|-Array.EmptyInternalEnumerator<ShaderInput.ShadowData>.MoveNext
	|
	|-RVA: 0x1D1E6C0 Offset: 0x1D1E7C1 VA: 0x1D1E6C0
	|-Array.EmptyInternalEnumerator<ShadowUtility.Edge>.MoveNext
	|
	|-RVA: 0x1D1E8D0 Offset: 0x1D1E9D1 VA: 0x1D1E8D0
	|-Array.EmptyInternalEnumerator<SimpleAnimationPlayable.QueuedState>.MoveNext
	|
	|-RVA: 0x1D1EAC0 Offset: 0x1D1EBC1 VA: 0x1D1EAC0
	|-Array.EmptyInternalEnumerator<SkillArray.Entity>.MoveNext
	|
	|-RVA: 0x1D1ECA0 Offset: 0x1D1EDA1 VA: 0x1D1ECA0
	|-Array.EmptyInternalEnumerator<Socket.WSABUF>.MoveNext
	|
	|-RVA: 0x1D1EE90 Offset: 0x1D1EF91 VA: 0x1D1EE90
	|-Array.EmptyInternalEnumerator<Stream.Info>.MoveNext
	|
	|-RVA: 0x1D1F080 Offset: 0x1D1F181 VA: 0x1D1F080
	|-Array.EmptyInternalEnumerator<TMP_Text.UnicodeChar>.MoveNext
	|
	|-RVA: 0x1D1F270 Offset: 0x1D1F371 VA: 0x1D1F270
	|-Array.EmptyInternalEnumerator<TexturePacker_JsonArray.Frame>.MoveNext
	|
	|-RVA: 0x1D1F490 Offset: 0x1D1F591 VA: 0x1D1F490
	|-Array.EmptyInternalEnumerator<TimeNotificationBehaviour.NotificationEntry>.MoveNext
	|
	|-RVA: 0x1D1F690 Offset: 0x1D1F791 VA: 0x1D1F690
	|-Array.EmptyInternalEnumerator<UnitySynchronizationContext.WorkRequest>.MoveNext
	|
	|-RVA: 0x1D1F890 Offset: 0x1D1F991 VA: 0x1D1F890
	|-Array.EmptyInternalEnumerator<XmlNamespaceManager.NamespaceDeclaration>.MoveNext
	|
	|-RVA: 0x1D1FA90 Offset: 0x1D1FB91 VA: 0x1D1FA90
	|-Array.EmptyInternalEnumerator<XmlSchemaObjectTable.XmlSchemaObjectEntry>.MoveNext
	|
	|-RVA: 0x1D1FC80 Offset: 0x1D1FD81 VA: 0x1D1FC80
	|-Array.EmptyInternalEnumerator<XmlTextReaderImpl.ParsingState>.MoveNext
	|
	|-RVA: 0x1D1FF20 Offset: 0x1D20021 VA: 0x1D1FF20
	|-Array.EmptyInternalEnumerator<AIThink.EnchantThink.Desc>.MoveNext
	|
	|-RVA: 0x1D20110 Offset: 0x1D20211 VA: 0x1D20110
	|-Array.EmptyInternalEnumerator<AIThink.EnchantThink.ItemInfo>.MoveNext
	|
	|-RVA: 0x1D202F0 Offset: 0x1D203F1 VA: 0x1D202F0
	|-Array.EmptyInternalEnumerator<AIThink.EnchantThink.SurroundingInfo>.MoveNext
	|
	|-RVA: 0x1D204D0 Offset: 0x1D205D1 VA: 0x1D204D0
	|-Array.EmptyInternalEnumerator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.MoveNext
	|
	|-RVA: 0x1D206C0 Offset: 0x1D207C1 VA: 0x1D206C0
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStoreChangeMetaParamInt>.MoveNext
	|
	|-RVA: 0x1D208D0 Offset: 0x1D209D1 VA: 0x1D208D0
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStoreDeleteParamInt>.MoveNext
	|
	|-RVA: 0x1D20AC0 Offset: 0x1D20BC1 VA: 0x1D20AC0
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStoreGetMetaParamInt>.MoveNext
	|
	|-RVA: 0x1D20CD0 Offset: 0x1D20DD1 VA: 0x1D20CD0
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStoreMetaInfoInt>.MoveNext
	|
	|-RVA: 0x1D20EE0 Offset: 0x1D20FE1 VA: 0x1D20EE0
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStorePasswordInfoInt>.MoveNext
	|
	|-RVA: 0x1D210E0 Offset: 0x1D211E1 VA: 0x1D210E0
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStorePersistenceInfoInt>.MoveNext
	|
	|-RVA: 0x1D212E0 Offset: 0x1D213E1 VA: 0x1D212E0
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStorePreparePostParamInt>.MoveNext
	|
	|-RVA: 0x1D214F0 Offset: 0x1D215F1 VA: 0x1D214F0
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStoreRateObjectParamInt>.MoveNext
	|
	|-RVA: 0x1D216E0 Offset: 0x1D217E1 VA: 0x1D216E0
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStoreRatingInitParamInt>.MoveNext
	|
	|-RVA: 0x1D218E0 Offset: 0x1D219E1 VA: 0x1D218E0
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStoreRatingTargetInt>.MoveNext
	|
	|-RVA: 0x1D21AD0 Offset: 0x1D21BD1 VA: 0x1D21AD0
	|-Array.EmptyInternalEnumerator<Detail.Ranking.RankingCachedResultInt>.MoveNext
	|
	|-RVA: 0x1D21CE0 Offset: 0x1D21DE1 VA: 0x1D21CE0
	|-Array.EmptyInternalEnumerator<Detail.Ranking.RankingOrderParamInt>.MoveNext
	|
	|-RVA: 0x1D21ED0 Offset: 0x1D21FD1 VA: 0x1D21ED0
	|-Array.EmptyInternalEnumerator<Detail.Ranking.RankingRankDataInt>.MoveNext
	|
	|-RVA: 0x1D220F0 Offset: 0x1D221F1 VA: 0x1D220F0
	|-Array.EmptyInternalEnumerator<Detail.Ranking2.Ranking2ChartInfoInt>.MoveNext
	|
	|-RVA: 0x1D22370 Offset: 0x1D22471 VA: 0x1D22370
	|-Array.EmptyInternalEnumerator<Detail.Ranking2.Ranking2RankDataInt>.MoveNext
	|
	|-RVA: 0x1D22590 Offset: 0x1D22691 VA: 0x1D22590
	|-Array.EmptyInternalEnumerator<Detail.Ranking2.Ranking2ScoreDataInt>.MoveNext
	|
	|-RVA: 0x1D22780 Offset: 0x1D22881 VA: 0x1D22780
	|-Array.EmptyInternalEnumerator<Detail.Screening.ScreeningContextInfoInt>.MoveNext
	|
	|-RVA: 0x1D22980 Offset: 0x1D22A81 VA: 0x1D22980
	|-Array.EmptyInternalEnumerator<Detail.Subscriber.SubscriberContentInt>.MoveNext
	|
	|-RVA: 0x1D22BD0 Offset: 0x1D22CD1 VA: 0x1D22BD0
	|-Array.EmptyInternalEnumerator<Detail.Subscriber.SubscriberGetContentParamInt>.MoveNext
	|
	|-RVA: 0x1D22DD0 Offset: 0x1D22ED1 VA: 0x1D22DD0
	|-Array.EmptyInternalEnumerator<Detail.Subscriber.SubscriberUserStatusInfoInt>.MoveNext
	|
	|-RVA: 0x1D22FE0 Offset: 0x1D230E1 VA: 0x1D22FE0
	|-Array.EmptyInternalEnumerator<Detail.Subscriber.SubscriberUserStatusParamInt>.MoveNext
	|
	|-RVA: 0x1D231E0 Offset: 0x1D232E1 VA: 0x1D231E0
	|-Array.EmptyInternalEnumerator<Detail.Utility.IntegerSettings>.MoveNext
	|
	|-RVA: 0x1D233C0 Offset: 0x1D234C1 VA: 0x1D233C0
	|-Array.EmptyInternalEnumerator<Detail.Utility.UniqueIdInfoInt>.MoveNext
	|
	|-RVA: 0x1D235B0 Offset: 0x1D236B1 VA: 0x1D235B0
	|-Array.EmptyInternalEnumerator<FacetsChecker.FacetsCompiler.Map>.MoveNext
	|
	|-RVA: 0x1D237A0 Offset: 0x1D238A1 VA: 0x1D237A0
	|-Array.EmptyInternalEnumerator<MapHistory.ReplayAppearanceMap.Appearance>.MoveNext
	|
	|-RVA: 0x1D239A0 Offset: 0x1D23AA1 VA: 0x1D239A0
	|-Array.EmptyInternalEnumerator<MapHistory.ReplayAppearanceMap.Leaving>.MoveNext
	|
	|-RVA: 0x1D23B80 Offset: 0x1D23C81 VA: 0x1D23B80
	|-Array.EmptyInternalEnumerator<MapHistory.ReplayUnitMap.Data>.MoveNext
	|
	|-RVA: 0x1D23D60 Offset: 0x1D23E61 VA: 0x1D23D60
	|-Array.EmptyInternalEnumerator<MapHistory.Rewind.LatestInspectorData>.MoveNext
	|
	|-RVA: 0x1D23F50 Offset: 0x1D24051 VA: 0x1D23F50
	|-Array.EmptyInternalEnumerator<MapHistory.Rewind.WorkTerrainData>.MoveNext
	|
	|-RVA: 0x1D24140 Offset: 0x1D24241 VA: 0x1D24140
	|-Array.EmptyInternalEnumerator<MapHistory.RewindUnitMap.Data>.MoveNext
	|
	|-RVA: 0x1D24350 Offset: 0x1D24451 VA: 0x1D24350
	|-Array.EmptyInternalEnumerator<MapKillBonus.Work.Pos>.MoveNext
	|
	|-RVA: 0x1D24530 Offset: 0x1D24631 VA: 0x1D24530
	|-Array.EmptyInternalEnumerator<MapSkill.AroundCalculator.Result>.MoveNext
	|
	|-RVA: 0x1D24720 Offset: 0x1D24821 VA: 0x1D24720
	|-Array.EmptyInternalEnumerator<Nex.ApiCallChecker.Guideline>.MoveNext
	|
	|-RVA: 0x1D24900 Offset: 0x1D24A01 VA: 0x1D24900
	|-Array.EmptyInternalEnumerator<Ngc.MaskTextSequenceBase.Data>.MoveNext
	|
	|-RVA: 0x1D24B00 Offset: 0x1D24C01 VA: 0x1D24B00
	|-Array.EmptyInternalEnumerator<TargetPositionCache.CacheCurve.Item>.MoveNext
	|
	|-RVA: 0x1D24D10 Offset: 0x1D24E11 VA: 0x1D24D10
	|-Array.EmptyInternalEnumerator<TargetPositionCache.CacheEntry.RecordingItem>.MoveNext
	|
	|-RVA: 0x1D24F20 Offset: 0x1D25021 VA: 0x1D24F20
	|-Array.EmptyInternalEnumerator<TerrainUtility.TerrainMap.TileCoord>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x263E510 Offset: 0x263E611 VA: 0x263E510
	|-Array.EmptyInternalEnumerator<ArraySegment<byte>>.get_Current
	|
	|-RVA: 0x263E700 Offset: 0x263E801 VA: 0x263E700
	|-Array.EmptyInternalEnumerator<AsyncOperationHandle<object>>.get_Current
	|
	|-RVA: 0x263E900 Offset: 0x263EA01 VA: 0x263E900
	|-Array.EmptyInternalEnumerator<MapDeployTemplate.Queue.Data<object>>.get_Current
	|
	|-RVA: 0x263EAE0 Offset: 0x263EBE1 VA: 0x263EAE0
	|-Array.EmptyInternalEnumerator<Nex.DataStore.ParamPool.Data<object>>.get_Current
	|
	|-RVA: 0x263ECD0 Offset: 0x263EDD1 VA: 0x263ECD0
	|-Array.EmptyInternalEnumerator<Nex.Screening.ParamPool.Data<object>>.get_Current
	|
	|-RVA: 0x263EEC0 Offset: 0x263EFC1 VA: 0x263EEC0
	|-Array.EmptyInternalEnumerator<IntervalTree.Entry<object>>.get_Current
	|
	|-RVA: 0x263F0C0 Offset: 0x263F1C1 VA: 0x263F0C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<ValueTuple<object, int>, object>>.get_Current
	|
	|-RVA: 0x263F2C0 Offset: 0x263F3C1 VA: 0x263F2C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<byte, object>>.get_Current
	|
	|-RVA: 0x263F4C0 Offset: 0x263F5C1 VA: 0x263F4C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<CancellationToken, object>>.get_Current
	|
	|-RVA: 0x263F6C0 Offset: 0x263F7C1 VA: 0x263F6C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<char, object>>.get_Current
	|
	|-RVA: 0x263F8C0 Offset: 0x263F9C1 VA: 0x263F8C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Guid, object>>.get_Current
	|
	|-RVA: 0x263FAC0 Offset: 0x263FBC1 VA: 0x263FAC0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, bool>>.get_Current
	|
	|-RVA: 0x263FCB0 Offset: 0x263FDB1 VA: 0x263FCB0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, byte>>.get_Current
	|
	|-RVA: 0x263FEA0 Offset: 0x263FFA1 VA: 0x263FEA0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, char>>.get_Current
	|
	|-RVA: 0x2640090 Offset: 0x2640191 VA: 0x2640090
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, DiagnosticEvent>>.get_Current
	|
	|-RVA: 0x26402B0 Offset: 0x26403B1 VA: 0x26402B0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, int>>.get_Current
	|
	|-RVA: 0x26404A0 Offset: 0x26405A1 VA: 0x26404A0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, Int32Enum>>.get_Current
	|
	|-RVA: 0x2640690 Offset: 0x2640791 VA: 0x2640690
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, long>>.get_Current
	|
	|-RVA: 0x2640890 Offset: 0x2640991 VA: 0x2640890
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, MapPos>>.get_Current
	|
	|-RVA: 0x2640A90 Offset: 0x2640B91 VA: 0x2640A90
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, object>>.get_Current
	|
	|-RVA: 0x2640C90 Offset: 0x2640D91 VA: 0x2640C90
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, uint>>.get_Current
	|
	|-RVA: 0x2640E80 Offset: 0x2640F81 VA: 0x2640E80
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, AIThink.EnchantThink.SurroundingInfo>>.get_Current
	|
	|-RVA: 0x2641070 Offset: 0x2641171 VA: 0x2641070
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, bool>>.get_Current
	|
	|-RVA: 0x2641260 Offset: 0x2641361 VA: 0x2641260
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, int>>.get_Current
	|
	|-RVA: 0x2641450 Offset: 0x2641551 VA: 0x2641450
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, Int32Enum>>.get_Current
	|
	|-RVA: 0x2641640 Offset: 0x2641741 VA: 0x2641640
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, object>>.get_Current
	|
	|-RVA: 0x2641840 Offset: 0x2641941 VA: 0x2641840
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<long, object>>.get_Current
	|
	|-RVA: 0x2641A40 Offset: 0x2641B41 VA: 0x2641A40
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<MapPos, int>>.get_Current
	|
	|-RVA: 0x2641C40 Offset: 0x2641D41 VA: 0x2641C40
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, AsyncOperationHandle<object>>>.get_Current
	|
	|-RVA: 0x2641E50 Offset: 0x2641F51 VA: 0x2641E50
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, AsyncOperationHandle>>.get_Current
	|
	|-RVA: 0x2642060 Offset: 0x2642161 VA: 0x2642060
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, bool>>.get_Current
	|
	|-RVA: 0x2642260 Offset: 0x2642361 VA: 0x2642260
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, byte>>.get_Current
	|
	|-RVA: 0x2642460 Offset: 0x2642561 VA: 0x2642460
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, int>>.get_Current
	|
	|-RVA: 0x2642660 Offset: 0x2642761 VA: 0x2642660
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Int32Enum>>.get_Current
	|
	|-RVA: 0x2642860 Offset: 0x2642961 VA: 0x2642860
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, IntPtr>>.get_Current
	|
	|-RVA: 0x2642A60 Offset: 0x2642B61 VA: 0x2642A60
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, object>>.get_Current
	|
	|-RVA: 0x2642C60 Offset: 0x2642D61 VA: 0x2642C60
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Playable>>.get_Current
	|
	|-RVA: 0x2642E60 Offset: 0x2642F61 VA: 0x2642E60
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, ResourceLocator>>.get_Current
	|
	|-RVA: 0x2643060 Offset: 0x2643161 VA: 0x2643060
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, float>>.get_Current
	|
	|-RVA: 0x2643260 Offset: 0x2643361 VA: 0x2643260
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, ushort>>.get_Current
	|
	|-RVA: 0x2643460 Offset: 0x2643561 VA: 0x2643460
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, GameVariable.Value>>.get_Current
	|
	|-RVA: 0x2643660 Offset: 0x2643761 VA: 0x2643660
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<sbyte, DataStoreRatingInfo>>.get_Current
	|
	|-RVA: 0x2643870 Offset: 0x2643971 VA: 0x2643870
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<sbyte, object>>.get_Current
	|
	|-RVA: 0x2643A70 Offset: 0x2643B71 VA: 0x2643A70
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<ushort, int>>.get_Current
	|
	|-RVA: 0x2643C60 Offset: 0x2643D61 VA: 0x2643C60
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<uint, int>>.get_Current
	|
	|-RVA: 0x2643E50 Offset: 0x2643F51 VA: 0x2643E50
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<uint, object>>.get_Current
	|
	|-RVA: 0x2644050 Offset: 0x2644151 VA: 0x2644050
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<ulong, Friend>>.get_Current
	|
	|-RVA: 0x2644260 Offset: 0x2644361 VA: 0x2644260
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<ulong, Int32Enum>>.get_Current
	|
	|-RVA: 0x2644460 Offset: 0x2644561 VA: 0x2644460
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<ulong, object>>.get_Current
	|
	|-RVA: 0x2644660 Offset: 0x2644761 VA: 0x2644660
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Vector3, int>>.get_Current
	|
	|-RVA: 0x2644860 Offset: 0x2644961 VA: 0x2644860
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<XPathNodeRef, XPathNodeRef>>.get_Current
	|
	|-RVA: 0x2644A70 Offset: 0x2644B71 VA: 0x2644A70
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<TerrainUtility.TerrainMap.TileCoord, object>>.get_Current
	|
	|-RVA: 0x2644C70 Offset: 0x2644D71 VA: 0x2644C70
	|-Array.EmptyInternalEnumerator<PriorityQueue.IndexedItem<object>>.get_Current
	|
	|-RVA: 0x2644E60 Offset: 0x2644F61 VA: 0x2644E60
	|-Array.EmptyInternalEnumerator<KeyValuePair<ValueTuple<object, int>, object>>.get_Current
	|
	|-RVA: 0x2645060 Offset: 0x2645161 VA: 0x2645060
	|-Array.EmptyInternalEnumerator<KeyValuePair<byte, object>>.get_Current
	|
	|-RVA: 0x2645250 Offset: 0x2645351 VA: 0x2645250
	|-Array.EmptyInternalEnumerator<KeyValuePair<CancellationToken, object>>.get_Current
	|
	|-RVA: 0x2645440 Offset: 0x2645541 VA: 0x2645440
	|-Array.EmptyInternalEnumerator<KeyValuePair<char, object>>.get_Current
	|
	|-RVA: 0x2645630 Offset: 0x2645731 VA: 0x2645630
	|-Array.EmptyInternalEnumerator<KeyValuePair<DateTime, object>>.get_Current
	|
	|-RVA: 0x2645820 Offset: 0x2645921 VA: 0x2645820
	|-Array.EmptyInternalEnumerator<KeyValuePair<Guid, object>>.get_Current
	|
	|-RVA: 0x2645A20 Offset: 0x2645B21 VA: 0x2645A20
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, bool>>.get_Current
	|
	|-RVA: 0x2645C00 Offset: 0x2645D01 VA: 0x2645C00
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, byte>>.get_Current
	|
	|-RVA: 0x2645DE0 Offset: 0x2645EE1 VA: 0x2645DE0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, char>>.get_Current
	|
	|-RVA: 0x2645FC0 Offset: 0x26460C1 VA: 0x2645FC0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, DiagnosticEvent>>.get_Current
	|
	|-RVA: 0x26461D0 Offset: 0x26462D1 VA: 0x26461D0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, int>>.get_Current
	|
	|-RVA: 0x26463B0 Offset: 0x26464B1 VA: 0x26463B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, Int32Enum>>.get_Current
	|
	|-RVA: 0x2646590 Offset: 0x2646691 VA: 0x2646590
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, long>>.get_Current
	|
	|-RVA: 0x2646780 Offset: 0x2646881 VA: 0x2646780
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, MapPos>>.get_Current
	|
	|-RVA: 0x2646970 Offset: 0x2646A71 VA: 0x2646970
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, object>>.get_Current
	|
	|-RVA: 0x2646B60 Offset: 0x2646C61 VA: 0x2646B60
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, uint>>.get_Current
	|
	|-RVA: 0x2646D40 Offset: 0x2646E41 VA: 0x2646D40
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, AIThink.EnchantThink.SurroundingInfo>>.get_Current
	|
	|-RVA: 0x2646F20 Offset: 0x2647021 VA: 0x2646F20
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, bool>>.get_Current
	|
	|-RVA: 0x2647100 Offset: 0x2647201 VA: 0x2647100
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, int>>.get_Current
	|
	|-RVA: 0x26472E0 Offset: 0x26473E1 VA: 0x26472E0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, Int32Enum>>.get_Current
	|
	|-RVA: 0x26474C0 Offset: 0x26475C1 VA: 0x26474C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, object>>.get_Current
	|
	|-RVA: 0x26476B0 Offset: 0x26477B1 VA: 0x26476B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<long, object>>.get_Current
	|
	|-RVA: 0x26478A0 Offset: 0x26479A1 VA: 0x26478A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<MapPos, int>>.get_Current
	|
	|-RVA: 0x2647A90 Offset: 0x2647B91 VA: 0x2647A90
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, AsyncOperationHandle<object>>>.get_Current
	|
	|-RVA: 0x2647C90 Offset: 0x2647D91 VA: 0x2647C90
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.get_Current
	|
	|-RVA: 0x2647E90 Offset: 0x2647F91 VA: 0x2647E90
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, AsyncOperationHandle>>.get_Current
	|
	|-RVA: 0x2648090 Offset: 0x2648191 VA: 0x2648090
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, bool>>.get_Current
	|
	|-RVA: 0x2648280 Offset: 0x2648381 VA: 0x2648280
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, byte>>.get_Current
	|
	|-RVA: 0x2648470 Offset: 0x2648571 VA: 0x2648470
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, int>>.get_Current
	|
	|-RVA: 0x2648660 Offset: 0x2648761 VA: 0x2648660
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Int32Enum>>.get_Current
	|
	|-RVA: 0x2648850 Offset: 0x2648951 VA: 0x2648850
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, IntPtr>>.get_Current
	|
	|-RVA: 0x2648A40 Offset: 0x2648B41 VA: 0x2648A40
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, object>>.get_Current
	|
	|-RVA: 0x2648C30 Offset: 0x2648D31 VA: 0x2648C30
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Playable>>.get_Current
	|
	|-RVA: 0x2648E30 Offset: 0x2648F31 VA: 0x2648E30
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, ResourceLocator>>.get_Current
	|
	|-RVA: 0x2649030 Offset: 0x2649131 VA: 0x2649030
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, float>>.get_Current
	|
	|-RVA: 0x2649220 Offset: 0x2649321 VA: 0x2649220
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, ushort>>.get_Current
	|
	|-RVA: 0x2649410 Offset: 0x2649511 VA: 0x2649410
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, GameVariable.Value>>.get_Current
	|
	|-RVA: 0x2649610 Offset: 0x2649711 VA: 0x2649610
	|-Array.EmptyInternalEnumerator<KeyValuePair<sbyte, DataStoreRatingInfo>>.get_Current
	|
	|-RVA: 0x2649810 Offset: 0x2649911 VA: 0x2649810
	|-Array.EmptyInternalEnumerator<KeyValuePair<sbyte, object>>.get_Current
	|
	|-RVA: 0x2649A00 Offset: 0x2649B01 VA: 0x2649A00
	|-Array.EmptyInternalEnumerator<KeyValuePair<ushort, int>>.get_Current
	|
	|-RVA: 0x2649BE0 Offset: 0x2649CE1 VA: 0x2649BE0
	|-Array.EmptyInternalEnumerator<KeyValuePair<uint, int>>.get_Current
	|
	|-RVA: 0x2649DC0 Offset: 0x2649EC1 VA: 0x2649DC0
	|-Array.EmptyInternalEnumerator<KeyValuePair<uint, object>>.get_Current
	|
	|-RVA: 0x2649FB0 Offset: 0x264A0B1 VA: 0x2649FB0
	|-Array.EmptyInternalEnumerator<KeyValuePair<ulong, Friend>>.get_Current
	|
	|-RVA: 0x264A1C0 Offset: 0x264A2C1 VA: 0x264A1C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<ulong, Int32Enum>>.get_Current
	|
	|-RVA: 0x264A3B0 Offset: 0x264A4B1 VA: 0x264A3B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<ulong, object>>.get_Current
	|
	|-RVA: 0x264A5A0 Offset: 0x264A6A1 VA: 0x264A5A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Vector3, int>>.get_Current
	|
	|-RVA: 0x264A790 Offset: 0x264A891 VA: 0x264A790
	|-Array.EmptyInternalEnumerator<KeyValuePair<XPathNodeRef, XPathNodeRef>>.get_Current
	|
	|-RVA: 0x264A990 Offset: 0x264AA91 VA: 0x264A990
	|-Array.EmptyInternalEnumerator<KeyValuePair<TerrainUtility.TerrainMap.TileCoord, object>>.get_Current
	|
	|-RVA: 0x264AB80 Offset: 0x264AC81 VA: 0x264AB80
	|-Array.EmptyInternalEnumerator<NativeArray<PreTile>>.get_Current
	|
	|-RVA: 0x264AD70 Offset: 0x264AE71 VA: 0x264AD70
	|-Array.EmptyInternalEnumerator<CommonBattleSequence.Reliance<object>>.get_Current
	|
	|-RVA: 0x264AF70 Offset: 0x264B071 VA: 0x264AF70
	|-Array.EmptyInternalEnumerator<RenderGraphResourcePool.ResourceLogInfo<object>>.get_Current
	|
	|-RVA: 0x264B160 Offset: 0x264B261 VA: 0x264B160
	|-Array.EmptyInternalEnumerator<HashSet.Slot<ValueTuple<object, int>>>.get_Current
	|
	|-RVA: 0x264B360 Offset: 0x264B461 VA: 0x264B360
	|-Array.EmptyInternalEnumerator<HashSet.Slot<AsyncOperationHandle>>.get_Current
	|
	|-RVA: 0x264B560 Offset: 0x264B661 VA: 0x264B560
	|-Array.EmptyInternalEnumerator<HashSet.Slot<int>>.get_Current
	|
	|-RVA: 0x264B750 Offset: 0x264B851 VA: 0x264B750
	|-Array.EmptyInternalEnumerator<HashSet.Slot<Int32Enum>>.get_Current
	|
	|-RVA: 0x264B940 Offset: 0x264BA41 VA: 0x264B940
	|-Array.EmptyInternalEnumerator<Set.Slot<Int32Enum>>.get_Current
	|
	|-RVA: 0x264BB30 Offset: 0x264BC31 VA: 0x264BB30
	|-Array.EmptyInternalEnumerator<HashSet.Slot<MapPos>>.get_Current
	|
	|-RVA: 0x264BD20 Offset: 0x264BE21 VA: 0x264BD20
	|-Array.EmptyInternalEnumerator<HashSet.Slot<object>>.get_Current
	|
	|-RVA: 0x264BF10 Offset: 0x264C011 VA: 0x264BF10
	|-Array.EmptyInternalEnumerator<Set.Slot<object>>.get_Current
	|
	|-RVA: 0x264C110 Offset: 0x264C211 VA: 0x264C110
	|-Array.EmptyInternalEnumerator<HashSet.Slot<uint>>.get_Current
	|
	|-RVA: 0x264C300 Offset: 0x264C401 VA: 0x264C300
	|-Array.EmptyInternalEnumerator<HashSet.Slot<ulong>>.get_Current
	|
	|-RVA: 0x264C4F0 Offset: 0x264C5F1 VA: 0x264C4F0
	|-Array.EmptyInternalEnumerator<Set.Slot<Vector3>>.get_Current
	|
	|-RVA: 0x264C6F0 Offset: 0x264C7F1 VA: 0x264C6F0
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<Color32>>.get_Current
	|
	|-RVA: 0x264C8F0 Offset: 0x264C9F1 VA: 0x264C8F0
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<HighlightState>>.get_Current
	|
	|-RVA: 0x264CB00 Offset: 0x264CC01 VA: 0x264CB00
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<int>>.get_Current
	|
	|-RVA: 0x264CD00 Offset: 0x264CE01 VA: 0x264CD00
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<Int32Enum>>.get_Current
	|
	|-RVA: 0x264CF00 Offset: 0x264D001 VA: 0x264CF00
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<MaterialReference>>.get_Current
	|
	|-RVA: 0x264D160 Offset: 0x264D261 VA: 0x264D160
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<object>>.get_Current
	|
	|-RVA: 0x264D370 Offset: 0x264D471 VA: 0x264D370
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<float>>.get_Current
	|
	|-RVA: 0x264D570 Offset: 0x264D671 VA: 0x264D570
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<WordWrapState>>.get_Current
	|
	|-RVA: 0x264D780 Offset: 0x264D881 VA: 0x264D780
	|-Array.EmptyInternalEnumerator<TimeInterval<object>>.get_Current
	|
	|-RVA: 0x264D970 Offset: 0x264DA71 VA: 0x264D970
	|-Array.EmptyInternalEnumerator<Timestamped<object>>.get_Current
	|
	|-RVA: 0x264DB70 Offset: 0x264DC71 VA: 0x264DB70
	|-Array.EmptyInternalEnumerator<UniTask<object>>.get_Current
	|
	|-RVA: 0x264DD60 Offset: 0x264DE61 VA: 0x264DD60
	|-Array.EmptyInternalEnumerator<ValueTuple<ValueTuple<bool, object>>>.get_Current
	|
	|-RVA: 0x264DF50 Offset: 0x264E051 VA: 0x264DF50
	|-Array.EmptyInternalEnumerator<ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_Current
	|
	|-RVA: 0x264E150 Offset: 0x264E251 VA: 0x264E150
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, UniTask<object>>>.get_Current
	|
	|-RVA: 0x264E350 Offset: 0x264E451 VA: 0x264E350
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.get_Current
	|
	|-RVA: 0x264E550 Offset: 0x264E651 VA: 0x264E550
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.get_Current
	|
	|-RVA: 0x264E760 Offset: 0x264E861 VA: 0x264E760
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.get_Current
	|
	|-RVA: 0x264E970 Offset: 0x264EA71 VA: 0x264E970
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.get_Current
	|
	|-RVA: 0x264EB60 Offset: 0x264EC61 VA: 0x264EB60
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.get_Current
	|
	|-RVA: 0x264ED50 Offset: 0x264EE51 VA: 0x264ED50
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.get_Current
	|
	|-RVA: 0x264EF70 Offset: 0x264F071 VA: 0x264EF70
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.get_Current
	|
	|-RVA: 0x264F160 Offset: 0x264F261 VA: 0x264F160
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.get_Current
	|
	|-RVA: 0x264F370 Offset: 0x264F471 VA: 0x264F370
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.get_Current
	|
	|-RVA: 0x264F580 Offset: 0x264F681 VA: 0x264F580
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.get_Current
	|
	|-RVA: 0x264F780 Offset: 0x264F881 VA: 0x264F780
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.get_Current
	|
	|-RVA: 0x264F990 Offset: 0x264FA91 VA: 0x264F990
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.get_Current
	|
	|-RVA: 0x264FBA0 Offset: 0x264FCA1 VA: 0x264FBA0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.get_Current
	|
	|-RVA: 0x264FDB0 Offset: 0x264FEB1 VA: 0x264FDB0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.get_Current
	|
	|-RVA: 0x264FFC0 Offset: 0x26500C1 VA: 0x264FFC0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.get_Current
	|
	|-RVA: 0x26501C0 Offset: 0x26502C1 VA: 0x26501C0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.get_Current
	|
	|-RVA: 0x26503D0 Offset: 0x26504D1 VA: 0x26503D0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.get_Current
	|
	|-RVA: 0x26505C0 Offset: 0x26506C1 VA: 0x26505C0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.get_Current
	|
	|-RVA: 0x26507D0 Offset: 0x26508D1 VA: 0x26507D0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.get_Current
	|
	|-RVA: 0x26509D0 Offset: 0x2650AD1 VA: 0x26509D0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.get_Current
	|
	|-RVA: 0x2650BE0 Offset: 0x2650CE1 VA: 0x2650BE0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.get_Current
	|
	|-RVA: 0x2650DF0 Offset: 0x2650EF1 VA: 0x2650DF0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.get_Current
	|
	|-RVA: 0x2651000 Offset: 0x2651101 VA: 0x2651000
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.get_Current
	|
	|-RVA: 0x2651210 Offset: 0x2651311 VA: 0x2651210
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.get_Current
	|
	|-RVA: 0x2651430 Offset: 0x2651531 VA: 0x2651430
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.get_Current
	|
	|-RVA: 0x2651680 Offset: 0x2651781 VA: 0x2651680
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.get_Current
	|
	|-RVA: 0x26518D0 Offset: 0x26519D1 VA: 0x26518D0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.get_Current
	|
	|-RVA: 0x2651B30 Offset: 0x2651C31 VA: 0x2651B30
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.get_Current
	|
	|-RVA: 0x2651D20 Offset: 0x2651E21 VA: 0x2651D20
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.get_Current
	|
	|-RVA: 0x2651F10 Offset: 0x2652011 VA: 0x2651F10
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.get_Current
	|
	|-RVA: 0x2652120 Offset: 0x2652221 VA: 0x2652120
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.get_Current
	|
	|-RVA: 0x2652310 Offset: 0x2652411 VA: 0x2652310
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.get_Current
	|
	|-RVA: 0x2652510 Offset: 0x2652611 VA: 0x2652510
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.get_Current
	|
	|-RVA: 0x2652720 Offset: 0x2652821 VA: 0x2652720
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.get_Current
	|
	|-RVA: 0x2652920 Offset: 0x2652A21 VA: 0x2652920
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.get_Current
	|
	|-RVA: 0x2652B30 Offset: 0x2652C31 VA: 0x2652B30
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.get_Current
	|
	|-RVA: 0x2652D40 Offset: 0x2652E41 VA: 0x2652D40
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.get_Current
	|
	|-RVA: 0x2652F40 Offset: 0x2653041 VA: 0x2652F40
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.get_Current
	|
	|-RVA: 0x2653140 Offset: 0x2653241 VA: 0x2653140
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.get_Current
	|
	|-RVA: 0x2653340 Offset: 0x2653441 VA: 0x2653340
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.get_Current
	|
	|-RVA: 0x2653550 Offset: 0x2653651 VA: 0x2653550
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.get_Current
	|
	|-RVA: 0x2653740 Offset: 0x2653841 VA: 0x2653740
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.get_Current
	|
	|-RVA: 0x2653940 Offset: 0x2653A41 VA: 0x2653940
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.get_Current
	|
	|-RVA: 0x2653B50 Offset: 0x2653C51 VA: 0x2653B50
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.get_Current
	|
	|-RVA: 0x2653D50 Offset: 0x2653E51 VA: 0x2653D50
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.get_Current
	|
	|-RVA: 0x2653F60 Offset: 0x2654061 VA: 0x2653F60
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.get_Current
	|
	|-RVA: 0x2654170 Offset: 0x2654271 VA: 0x2654170
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_Current
	|
	|-RVA: 0x2654390 Offset: 0x2654491 VA: 0x2654390
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.get_Current
	|
	|-RVA: 0x26545A0 Offset: 0x26546A1 VA: 0x26545A0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_Current
	|
	|-RVA: 0x26547F0 Offset: 0x26548F1 VA: 0x26547F0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.get_Current
	|
	|-RVA: 0x2654A00 Offset: 0x2654B01 VA: 0x2654A00
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_Current
	|
	|-RVA: 0x2654C80 Offset: 0x2654D81 VA: 0x2654C80
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.get_Current
	|
	|-RVA: 0x2654EA0 Offset: 0x2654FA1 VA: 0x2654EA0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_Current
	|
	|-RVA: 0x2655130 Offset: 0x2655231 VA: 0x2655130
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.get_Current
	|
	|-RVA: 0x2655380 Offset: 0x2655481 VA: 0x2655380
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_Current
	|
	|-RVA: 0x2655630 Offset: 0x2655731 VA: 0x2655630
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.get_Current
	|
	|-RVA: 0x2655880 Offset: 0x2655981 VA: 0x2655880
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.get_Current
	|
	|-RVA: 0x2655A60 Offset: 0x2655B61 VA: 0x2655A60
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.get_Current
	|
	|-RVA: 0x2655C40 Offset: 0x2655D41 VA: 0x2655C40
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.get_Current
	|
	|-RVA: 0x2655E50 Offset: 0x2655F51 VA: 0x2655E50
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.get_Current
	|
	|-RVA: 0x2656030 Offset: 0x2656131 VA: 0x2656030
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.get_Current
	|
	|-RVA: 0x2656240 Offset: 0x2656341 VA: 0x2656240
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.get_Current
	|
	|-RVA: 0x2656440 Offset: 0x2656541 VA: 0x2656440
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.get_Current
	|
	|-RVA: 0x2656630 Offset: 0x2656731 VA: 0x2656630
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.get_Current
	|
	|-RVA: 0x2656830 Offset: 0x2656931 VA: 0x2656830
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.get_Current
	|
	|-RVA: 0x2656A30 Offset: 0x2656B31 VA: 0x2656A30
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.get_Current
	|
	|-RVA: 0x2656C40 Offset: 0x2656D41 VA: 0x2656C40
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.get_Current
	|
	|-RVA: 0x2656E50 Offset: 0x2656F51 VA: 0x2656E50
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.get_Current
	|
	|-RVA: 0x2657040 Offset: 0x2657141 VA: 0x2657040
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.get_Current
	|
	|-RVA: 0x2657240 Offset: 0x2657341 VA: 0x2657240
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.get_Current
	|
	|-RVA: 0x2657420 Offset: 0x2657521 VA: 0x2657420
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.get_Current
	|
	|-RVA: 0x2657620 Offset: 0x2657721 VA: 0x2657620
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.get_Current
	|
	|-RVA: 0x2657820 Offset: 0x2657921 VA: 0x2657820
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.get_Current
	|
	|-RVA: 0x2657A30 Offset: 0x2657B31 VA: 0x2657A30
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.get_Current
	|
	|-RVA: 0x2657C30 Offset: 0x2657D31 VA: 0x2657C30
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.get_Current
	|
	|-RVA: 0x2657E30 Offset: 0x2657F31 VA: 0x2657E30
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_Current
	|
	|-RVA: 0x2658040 Offset: 0x2658141 VA: 0x2658040
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.get_Current
	|
	|-RVA: 0x2658250 Offset: 0x2658351 VA: 0x2658250
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_Current
	|
	|-RVA: 0x26584A0 Offset: 0x26585A1 VA: 0x26584A0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.get_Current
	|
	|-RVA: 0x26586B0 Offset: 0x26587B1 VA: 0x26586B0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_Current
	|
	|-RVA: 0x2658910 Offset: 0x2658A11 VA: 0x2658910
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.get_Current
	|
	|-RVA: 0x2658B20 Offset: 0x2658C21 VA: 0x2658B20
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_Current
	|
	|-RVA: 0x2658DB0 Offset: 0x2658EB1 VA: 0x2658DB0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.get_Current
	|
	|-RVA: 0x2658FD0 Offset: 0x26590D1 VA: 0x2658FD0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_Current
	|
	|-RVA: 0x2659270 Offset: 0x2659371 VA: 0x2659270
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.get_Current
	|
	|-RVA: 0x26594C0 Offset: 0x26595C1 VA: 0x26594C0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.get_Current
	|
	|-RVA: 0x26596D0 Offset: 0x26597D1 VA: 0x26596D0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.get_Current
	|
	|-RVA: 0x26598E0 Offset: 0x26599E1 VA: 0x26598E0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.get_Current
	|
	|-RVA: 0x2659AD0 Offset: 0x2659BD1 VA: 0x2659AD0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, bool>>>.get_Current
	|
	|-RVA: 0x2659CC0 Offset: 0x2659DC1 VA: 0x2659CC0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, Bounds>>>.get_Current
	|
	|-RVA: 0x2659EC0 Offset: 0x2659FC1 VA: 0x2659EC0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, byte>>>.get_Current
	|
	|-RVA: 0x265A0B0 Offset: 0x265A1B1 VA: 0x265A0B0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, Color>>>.get_Current
	|
	|-RVA: 0x265A2B0 Offset: 0x265A3B1 VA: 0x265A2B0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, double>>>.get_Current
	|
	|-RVA: 0x265A4B0 Offset: 0x265A5B1 VA: 0x265A4B0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, int>>>.get_Current
	|
	|-RVA: 0x1CF0D60 Offset: 0x1CF0E61 VA: 0x1CF0D60
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, long>>>.get_Current
	|
	|-RVA: 0x1CF0F60 Offset: 0x1CF1061 VA: 0x1CF0F60
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, object>>>.get_Current
	|
	|-RVA: 0x1CF1160 Offset: 0x1CF1261 VA: 0x1CF1160
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, Quaternion>>>.get_Current
	|
	|-RVA: 0x1CF1360 Offset: 0x1CF1461 VA: 0x1CF1360
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, Rect>>>.get_Current
	|
	|-RVA: 0x1CF1560 Offset: 0x1CF1661 VA: 0x1CF1560
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, float>>>.get_Current
	|
	|-RVA: 0x1CF1750 Offset: 0x1CF1851 VA: 0x1CF1750
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, UniTask>>>.get_Current
	|
	|-RVA: 0x1CF1950 Offset: 0x1CF1A51 VA: 0x1CF1950
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, Unit>>>.get_Current
	|
	|-RVA: 0x1CF1B40 Offset: 0x1CF1C41 VA: 0x1CF1B40
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, Vector2>>>.get_Current
	|
	|-RVA: 0x1CF1D30 Offset: 0x1CF1E31 VA: 0x1CF1D30
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, Vector3>>>.get_Current
	|
	|-RVA: 0x1CF1F30 Offset: 0x1CF2031 VA: 0x1CF1F30
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, Vector4>>>.get_Current
	|
	|-RVA: 0x1CF2130 Offset: 0x1CF2231 VA: 0x1CF2130
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<int, object>>>.get_Current
	|
	|-RVA: 0x1CF2330 Offset: 0x1CF2431 VA: 0x1CF2330
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<object, object>>>.get_Current
	|
	|-RVA: 0x1CF2530 Offset: 0x1CF2631 VA: 0x1CF2530
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_Current
	|
	|-RVA: 0x1CF2740 Offset: 0x1CF2841 VA: 0x1CF2740
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<object, object, object>>>.get_Current
	|
	|-RVA: 0x1CF2940 Offset: 0x1CF2A41 VA: 0x1CF2940
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_Current
	|
	|-RVA: 0x1CF2B60 Offset: 0x1CF2C61 VA: 0x1CF2B60
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<object, object, object, object>>>.get_Current
	|
	|-RVA: 0x1CF2D70 Offset: 0x1CF2E71 VA: 0x1CF2D70
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_Current
	|
	|-RVA: 0x1CF2FC0 Offset: 0x1CF30C1 VA: 0x1CF2FC0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.get_Current
	|
	|-RVA: 0x1CF31D0 Offset: 0x1CF32D1 VA: 0x1CF31D0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_Current
	|
	|-RVA: 0x1CF3450 Offset: 0x1CF3551 VA: 0x1CF3450
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.get_Current
	|
	|-RVA: 0x1CF3660 Offset: 0x1CF3761 VA: 0x1CF3660
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_Current
	|
	|-RVA: 0x1CF38F0 Offset: 0x1CF39F1 VA: 0x1CF38F0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.get_Current
	|
	|-RVA: 0x1CF3B10 Offset: 0x1CF3C11 VA: 0x1CF3B10
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.get_Current
	|
	|-RVA: 0x1CF3DC0 Offset: 0x1CF3EC1 VA: 0x1CF3DC0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.get_Current
	|
	|-RVA: 0x1CF3FD0 Offset: 0x1CF40D1 VA: 0x1CF3FD0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, AsyncUnit>>.get_Current
	|
	|-RVA: 0x1CF41B0 Offset: 0x1CF42B1 VA: 0x1CF41B0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, bool>>.get_Current
	|
	|-RVA: 0x1CF4390 Offset: 0x1CF4491 VA: 0x1CF4390
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Bounds>>.get_Current
	|
	|-RVA: 0x1CF45A0 Offset: 0x1CF46A1 VA: 0x1CF45A0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, byte>>.get_Current
	|
	|-RVA: 0x1CF4780 Offset: 0x1CF4881 VA: 0x1CF4780
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Color>>.get_Current
	|
	|-RVA: 0x1CF4980 Offset: 0x1CF4A81 VA: 0x1CF4980
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, double>>.get_Current
	|
	|-RVA: 0x1CF4B70 Offset: 0x1CF4C71 VA: 0x1CF4B70
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, int>>.get_Current
	|
	|-RVA: 0x1CF4D50 Offset: 0x1CF4E51 VA: 0x1CF4D50
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, long>>.get_Current
	|
	|-RVA: 0x1CF4F40 Offset: 0x1CF5041 VA: 0x1CF4F40
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, object>>.get_Current
	|
	|-RVA: 0x1CF5130 Offset: 0x1CF5231 VA: 0x1CF5130
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Quaternion>>.get_Current
	|
	|-RVA: 0x1CF5330 Offset: 0x1CF5431 VA: 0x1CF5330
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Rect>>.get_Current
	|
	|-RVA: 0x1CF5530 Offset: 0x1CF5631 VA: 0x1CF5530
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, float>>.get_Current
	|
	|-RVA: 0x1CF5710 Offset: 0x1CF5811 VA: 0x1CF5710
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, UniTask>>.get_Current
	|
	|-RVA: 0x1CF5900 Offset: 0x1CF5A01 VA: 0x1CF5900
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Unit>>.get_Current
	|
	|-RVA: 0x1CF5AE0 Offset: 0x1CF5BE1 VA: 0x1CF5AE0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Vector2>>.get_Current
	|
	|-RVA: 0x1CF5CD0 Offset: 0x1CF5DD1 VA: 0x1CF5CD0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Vector3>>.get_Current
	|
	|-RVA: 0x1CF5EC0 Offset: 0x1CF5FC1 VA: 0x1CF5EC0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Vector4>>.get_Current
	|
	|-RVA: 0x1CF60C0 Offset: 0x1CF61C1 VA: 0x1CF60C0
	|-Array.EmptyInternalEnumerator<ValueTuple<int, bool>>.get_Current
	|
	|-RVA: 0x1CF62A0 Offset: 0x1CF63A1 VA: 0x1CF62A0
	|-Array.EmptyInternalEnumerator<ValueTuple<int, Bounds>>.get_Current
	|
	|-RVA: 0x1CF64B0 Offset: 0x1CF65B1 VA: 0x1CF64B0
	|-Array.EmptyInternalEnumerator<ValueTuple<int, byte>>.get_Current
	|
	|-RVA: 0x1CF6690 Offset: 0x1CF6791 VA: 0x1CF6690
	|-Array.EmptyInternalEnumerator<ValueTuple<int, Color>>.get_Current
	|
	|-RVA: 0x1CF6890 Offset: 0x1CF6991 VA: 0x1CF6890
	|-Array.EmptyInternalEnumerator<ValueTuple<int, double>>.get_Current
	|
	|-RVA: 0x1CF6A80 Offset: 0x1CF6B81 VA: 0x1CF6A80
	|-Array.EmptyInternalEnumerator<ValueTuple<int, int>>.get_Current
	|
	|-RVA: 0x1CF6C60 Offset: 0x1CF6D61 VA: 0x1CF6C60
	|-Array.EmptyInternalEnumerator<ValueTuple<int, long>>.get_Current
	|
	|-RVA: 0x1CF6E50 Offset: 0x1CF6F51 VA: 0x1CF6E50
	|-Array.EmptyInternalEnumerator<ValueTuple<int, object>>.get_Current
	|
	|-RVA: 0x1CF7040 Offset: 0x1CF7141 VA: 0x1CF7040
	|-Array.EmptyInternalEnumerator<ValueTuple<int, Quaternion>>.get_Current
	|
	|-RVA: 0x1CF7240 Offset: 0x1CF7341 VA: 0x1CF7240
	|-Array.EmptyInternalEnumerator<ValueTuple<int, Rect>>.get_Current
	|
	|-RVA: 0x1CF7440 Offset: 0x1CF7541 VA: 0x1CF7440
	|-Array.EmptyInternalEnumerator<ValueTuple<int, float>>.get_Current
	|
	|-RVA: 0x1CF7620 Offset: 0x1CF7721 VA: 0x1CF7620
	|-Array.EmptyInternalEnumerator<ValueTuple<int, Unit>>.get_Current
	|
	|-RVA: 0x1CF7800 Offset: 0x1CF7901 VA: 0x1CF7800
	|-Array.EmptyInternalEnumerator<ValueTuple<int, Vector2>>.get_Current
	|
	|-RVA: 0x1CF79F0 Offset: 0x1CF7AF1 VA: 0x1CF79F0
	|-Array.EmptyInternalEnumerator<ValueTuple<int, Vector3>>.get_Current
	|
	|-RVA: 0x1CF7BE0 Offset: 0x1CF7CE1 VA: 0x1CF7BE0
	|-Array.EmptyInternalEnumerator<ValueTuple<int, Vector4>>.get_Current
	|
	|-RVA: 0x1CF7DE0 Offset: 0x1CF7EE1 VA: 0x1CF7DE0
	|-Array.EmptyInternalEnumerator<ValueTuple<Int32Enum, int>>.get_Current
	|
	|-RVA: 0x1CF7FC0 Offset: 0x1CF80C1 VA: 0x1CF7FC0
	|-Array.EmptyInternalEnumerator<ValueTuple<object, ValueTuple<object, int>>>.get_Current
	|
	|-RVA: 0x1CF81C0 Offset: 0x1CF82C1 VA: 0x1CF81C0
	|-Array.EmptyInternalEnumerator<ValueTuple<object, int>>.get_Current
	|
	|-RVA: 0x1CF83B0 Offset: 0x1CF84B1 VA: 0x1CF83B0
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object>>.get_Current
	|
	|-RVA: 0x1CF85A0 Offset: 0x1CF86A1 VA: 0x1CF85A0
	|-Array.EmptyInternalEnumerator<ValueTuple<object, float>>.get_Current
	|
	|-RVA: 0x1CF8790 Offset: 0x1CF8891 VA: 0x1CF8790
	|-Array.EmptyInternalEnumerator<ValueTuple<Vector3, float>>.get_Current
	|
	|-RVA: 0x1CF8980 Offset: 0x1CF8A81 VA: 0x1CF8980
	|-Array.EmptyInternalEnumerator<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_Current
	|
	|-RVA: 0x1CF8B90 Offset: 0x1CF8C91 VA: 0x1CF8B90
	|-Array.EmptyInternalEnumerator<ValueTuple<object, Int32Enum, int>>.get_Current
	|
	|-RVA: 0x1CF8D80 Offset: 0x1CF8E81 VA: 0x1CF8D80
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object, object>>.get_Current
	|
	|-RVA: 0x1CF8F80 Offset: 0x1CF9081 VA: 0x1CF8F80
	|-Array.EmptyInternalEnumerator<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_Current
	|
	|-RVA: 0x1CF9190 Offset: 0x1CF9291 VA: 0x1CF9190
	|-Array.EmptyInternalEnumerator<ValueTuple<object, int, int, int>>.get_Current
	|
	|-RVA: 0x1CF9390 Offset: 0x1CF9491 VA: 0x1CF9390
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object, object, object>>.get_Current
	|
	|-RVA: 0x1CF9590 Offset: 0x1CF9691 VA: 0x1CF9590
	|-Array.EmptyInternalEnumerator<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_Current
	|
	|-RVA: 0x1CF97E0 Offset: 0x1CF98E1 VA: 0x1CF97E0
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object, object, object, object>>.get_Current
	|
	|-RVA: 0x1CF99F0 Offset: 0x1CF9AF1 VA: 0x1CF99F0
	|-Array.EmptyInternalEnumerator<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_Current
	|
	|-RVA: 0x1CF9C50 Offset: 0x1CF9D51 VA: 0x1CF9C50
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object, object, object, object, object>>.get_Current
	|
	|-RVA: 0x1CF9E60 Offset: 0x1CF9F61 VA: 0x1CF9E60
	|-Array.EmptyInternalEnumerator<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.get_Current
	|
	|-RVA: 0x1CFA0F0 Offset: 0x1CFA1F1 VA: 0x1CFA0F0
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object, object, object, object, object, object>>.get_Current
	|
	|-RVA: 0x1CFA300 Offset: 0x1CFA401 VA: 0x1CFA300
	|-Array.EmptyInternalEnumerator<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.get_Current
	|
	|-RVA: 0x1CFA5A0 Offset: 0x1CFA6A1 VA: 0x1CFA5A0
	|-Array.EmptyInternalEnumerator<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.get_Current
	|
	|-RVA: 0x1CFA7B0 Offset: 0x1CFA8B1 VA: 0x1CFA7B0
	|-Array.EmptyInternalEnumerator<AnimatorClipInfo>.get_Current
	|
	|-RVA: 0x1CFA990 Offset: 0x1CFAA91 VA: 0x1CFA990
	|-Array.EmptyInternalEnumerator<AsyncOperationHandle>.get_Current
	|
	|-RVA: 0x1CFAB90 Offset: 0x1CFAC91 VA: 0x1CFAB90
	|-Array.EmptyInternalEnumerator<AsyncUnit>.get_Current
	|
	|-RVA: 0x1CFAD70 Offset: 0x1CFAE71 VA: 0x1CFAD70
	|-Array.EmptyInternalEnumerator<BatchVisibility>.get_Current
	|
	|-RVA: 0x1CFAF60 Offset: 0x1CFB061 VA: 0x1CFAF60
	|-Array.EmptyInternalEnumerator<BoneWeight>.get_Current
	|
	|-RVA: 0x1CFB160 Offset: 0x1CFB261 VA: 0x1CFB160
	|-Array.EmptyInternalEnumerator<BoneWeight1>.get_Current
	|
	|-RVA: 0x1CFB340 Offset: 0x1CFB441 VA: 0x1CFB340
	|-Array.EmptyInternalEnumerator<bool>.get_Current
	|
	|-RVA: 0x1CFB520 Offset: 0x1CFB621 VA: 0x1CFB520
	|-Array.EmptyInternalEnumerator<Bounds>.get_Current
	|
	|-RVA: 0x1CFB720 Offset: 0x1CFB821 VA: 0x1CFB720
	|-Array.EmptyInternalEnumerator<byte>.get_Current
	|
	|-RVA: 0x1CFB900 Offset: 0x1CFBA01 VA: 0x1CFB900
	|-Array.EmptyInternalEnumerator<ByteEnum>.get_Current
	|
	|-RVA: 0x1CFBAE0 Offset: 0x1CFBBE1 VA: 0x1CFBAE0
	|-Array.EmptyInternalEnumerator<CameraInfo>.get_Current
	|
	|-RVA: 0x1CFBCD0 Offset: 0x1CFBDD1 VA: 0x1CFBCD0
	|-Array.EmptyInternalEnumerator<CancellationToken>.get_Current
	|
	|-RVA: 0x1CFBEB0 Offset: 0x1CFBFB1 VA: 0x1CFBEB0
	|-Array.EmptyInternalEnumerator<CancellationTokenRegistration>.get_Current
	|
	|-RVA: 0x1CFC0B0 Offset: 0x1CFC1B1 VA: 0x1CFC0B0
	|-Array.EmptyInternalEnumerator<char>.get_Current
	|
	|-RVA: 0x1CFC290 Offset: 0x1CFC391 VA: 0x1CFC290
	|-Array.EmptyInternalEnumerator<ClusteringData>.get_Current
	|
	|-RVA: 0x1CFC490 Offset: 0x1CFC591 VA: 0x1CFC490
	|-Array.EmptyInternalEnumerator<ClusteringProcessorState>.get_Current
	|
	|-RVA: 0x1CFC6A0 Offset: 0x1CFC7A1 VA: 0x1CFC6A0
	|-Array.EmptyInternalEnumerator<Color>.get_Current
	|
	|-RVA: 0x1CFC890 Offset: 0x1CFC991 VA: 0x1CFC890
	|-Array.EmptyInternalEnumerator<Color32>.get_Current
	|
	|-RVA: 0x1CFCA70 Offset: 0x1CFCB71 VA: 0x1CFCA70
	|-Array.EmptyInternalEnumerator<Color4u8>.get_Current
	|
	|-RVA: 0x1CFCC50 Offset: 0x1CFCD51 VA: 0x1CFCC50
	|-Array.EmptyInternalEnumerator<ColorBlock>.get_Current
	|
	|-RVA: 0x1CFCEB0 Offset: 0x1CFCFB1 VA: 0x1CFCEB0
	|-Array.EmptyInternalEnumerator<CombineInstance>.get_Current
	|
	|-RVA: 0x1CFD140 Offset: 0x1CFD241 VA: 0x1CFD140
	|-Array.EmptyInternalEnumerator<ConstraintSource>.get_Current
	|
	|-RVA: 0x1CFD330 Offset: 0x1CFD431 VA: 0x1CFD330
	|-Array.EmptyInternalEnumerator<ContactPoint>.get_Current
	|
	|-RVA: 0x1CFD540 Offset: 0x1CFD641 VA: 0x1CFD540
	|-Array.EmptyInternalEnumerator<ContactPoint2D>.get_Current
	|
	|-RVA: 0x1CFD750 Offset: 0x1CFD851 VA: 0x1CFD750
	|-Array.EmptyInternalEnumerator<ContourVertex>.get_Current
	|
	|-RVA: 0x1CFD950 Offset: 0x1CFDA51 VA: 0x1CFD950
	|-Array.EmptyInternalEnumerator<CustomAttributeNamedArgument>.get_Current
	|
	|-RVA: 0x1CFDB50 Offset: 0x1CFDC51 VA: 0x1CFDB50
	|-Array.EmptyInternalEnumerator<CustomAttributeTypedArgument>.get_Current
	|
	|-RVA: 0x1CFDD40 Offset: 0x1CFDE41 VA: 0x1CFDD40
	|-Array.EmptyInternalEnumerator<DataStoreRatingInfo>.get_Current
	|
	|-RVA: 0x1CFDF40 Offset: 0x1CFE041 VA: 0x1CFDF40
	|-Array.EmptyInternalEnumerator<DataStoreResult>.get_Current
	|
	|-RVA: 0x1CFE120 Offset: 0x1CFE221 VA: 0x1CFE120
	|-Array.EmptyInternalEnumerator<DateTime>.get_Current
	|
	|-RVA: 0x1CFE300 Offset: 0x1CFE401 VA: 0x1CFE300
	|-Array.EmptyInternalEnumerator<DateTimeOffset>.get_Current
	|
	|-RVA: 0x1CFE4F0 Offset: 0x1CFE5F1 VA: 0x1CFE4F0
	|-Array.EmptyInternalEnumerator<DebugPadState>.get_Current
	|
	|-RVA: 0x1CFE6F0 Offset: 0x1CFE7F1 VA: 0x1CFE6F0
	|-Array.EmptyInternalEnumerator<Decimal>.get_Current
	|
	|-RVA: 0x1CFE8E0 Offset: 0x1CFE9E1 VA: 0x1CFE8E0
	|-Array.EmptyInternalEnumerator<DeferredTiler>.get_Current
	|
	|-RVA: 0x1CFEB80 Offset: 0x1CFEC81 VA: 0x1CFEB80
	|-Array.EmptyInternalEnumerator<DeviceHandle>.get_Current
	|
	|-RVA: 0x1CFED70 Offset: 0x1CFEE71 VA: 0x1CFED70
	|-Array.EmptyInternalEnumerator<DiagnosticEvent>.get_Current
	|
	|-RVA: 0x1CFEF80 Offset: 0x1CFF081 VA: 0x1CFEF80
	|-Array.EmptyInternalEnumerator<DictionaryEntry>.get_Current
	|
	|-RVA: 0x1CFF170 Offset: 0x1CFF271 VA: 0x1CFF170
	|-Array.EmptyInternalEnumerator<DictionaryInfo>.get_Current
	|
	|-RVA: 0x1CFF350 Offset: 0x1CFF451 VA: 0x1CFF350
	|-Array.EmptyInternalEnumerator<DirectoryEntry>.get_Current
	|
	|-RVA: 0x1CFF550 Offset: 0x1CFF651 VA: 0x1CFF550
	|-Array.EmptyInternalEnumerator<double>.get_Current
	|
	|-RVA: 0x1CFF730 Offset: 0x1CFF831 VA: 0x1CFF730
	|-Array.EmptyInternalEnumerator<Ephemeron>.get_Current
	|
	|-RVA: 0x1CFF920 Offset: 0x1CFFA21 VA: 0x1CFF920
	|-Array.EmptyInternalEnumerator<FXZ>.get_Current
	|
	|-RVA: 0x1CFFB00 Offset: 0x1CFFC01 VA: 0x1CFFB00
	|-Array.EmptyInternalEnumerator<Finger>.get_Current
	|
	|-RVA: 0x1CFFD10 Offset: 0x1CFFE11 VA: 0x1CFFD10
	|-Array.EmptyInternalEnumerator<Float2>.get_Current
	|
	|-RVA: 0x1CFFEF0 Offset: 0x1CFFFF1 VA: 0x1CFFEF0
	|-Array.EmptyInternalEnumerator<Friend>.get_Current
	|
	|-RVA: 0x1D00100 Offset: 0x1D00201 VA: 0x1D00100
	|-Array.EmptyInternalEnumerator<GCHandle>.get_Current
	|
	|-RVA: 0x1D002E0 Offset: 0x1D003E1 VA: 0x1D002E0
	|-Array.EmptyInternalEnumerator<GesturePoint>.get_Current
	|
	|-RVA: 0x1D004C0 Offset: 0x1D005C1 VA: 0x1D004C0
	|-Array.EmptyInternalEnumerator<GestureState>.get_Current
	|
	|-RVA: 0x1D00740 Offset: 0x1D00841 VA: 0x1D00740
	|-Array.EmptyInternalEnumerator<GlyphMarshallingStruct>.get_Current
	|
	|-RVA: 0x1D00950 Offset: 0x1D00A51 VA: 0x1D00950
	|-Array.EmptyInternalEnumerator<GlyphPairAdjustmentRecord>.get_Current
	|
	|-RVA: 0x1D00B70 Offset: 0x1D00C71 VA: 0x1D00B70
	|-Array.EmptyInternalEnumerator<GlyphRect>.get_Current
	|
	|-RVA: 0x1D00D60 Offset: 0x1D00E61 VA: 0x1D00D60
	|-Array.EmptyInternalEnumerator<Guid>.get_Current
	|
	|-RVA: 0x1D00F50 Offset: 0x1D01051 VA: 0x1D00F50
	|-Array.EmptyInternalEnumerator<Hand>.get_Current
	|
	|-RVA: 0x1D01160 Offset: 0x1D01261 VA: 0x1D01160
	|-Array.EmptyInternalEnumerator<HandAnalysisImageState>.get_Current
	|
	|-RVA: 0x1D01350 Offset: 0x1D01451 VA: 0x1D01350
	|-Array.EmptyInternalEnumerator<HandAnalysisSilhouetteState>.get_Current
	|
	|-RVA: 0x1D01560 Offset: 0x1D01661 VA: 0x1D01560
	|-Array.EmptyInternalEnumerator<HeaderVariantInfo>.get_Current
	|
	|-RVA: 0x1D01750 Offset: 0x1D01851 VA: 0x1D01750
	|-Array.EmptyInternalEnumerator<HighlightState>.get_Current
	|
	|-RVA: 0x1D01950 Offset: 0x1D01A51 VA: 0x1D01950
	|-Array.EmptyInternalEnumerator<HumanBone>.get_Current
	|
	|-RVA: 0x1D01B70 Offset: 0x1D01C71 VA: 0x1D01B70
	|-Array.EmptyInternalEnumerator<short>.get_Current
	|
	|-RVA: 0x1D01D50 Offset: 0x1D01E51 VA: 0x1D01D50
	|-Array.EmptyInternalEnumerator<int>.get_Current
	|
	|-RVA: 0x1D01F30 Offset: 0x1D02031 VA: 0x1D01F30
	|-Array.EmptyInternalEnumerator<Int32Enum>.get_Current
	|
	|-RVA: 0x1D02110 Offset: 0x1D02211 VA: 0x1D02110
	|-Array.EmptyInternalEnumerator<long>.get_Current
	|
	|-RVA: 0x1D022F0 Offset: 0x1D023F1 VA: 0x1D022F0
	|-Array.EmptyInternalEnumerator<Int64Enum>.get_Current
	|
	|-RVA: 0x1D024D0 Offset: 0x1D025D1 VA: 0x1D024D0
	|-Array.EmptyInternalEnumerator<IntPtr>.get_Current
	|
	|-RVA: 0x1D026B0 Offset: 0x1D027B1 VA: 0x1D026B0
	|-Array.EmptyInternalEnumerator<InternalCodePageDataItem>.get_Current
	|
	|-RVA: 0x1D028A0 Offset: 0x1D029A1 VA: 0x1D028A0
	|-Array.EmptyInternalEnumerator<InternalEncodingDataItem>.get_Current
	|
	|-RVA: 0x1D02A90 Offset: 0x1D02B91 VA: 0x1D02A90
	|-Array.EmptyInternalEnumerator<InterpretedFrameInfo>.get_Current
	|
	|-RVA: 0x1D02C80 Offset: 0x1D02D81 VA: 0x1D02C80
	|-Array.EmptyInternalEnumerator<IntervalTreeNode>.get_Current
	|
	|-RVA: 0x1D02E80 Offset: 0x1D02F81 VA: 0x1D02E80
	|-Array.EmptyInternalEnumerator<JobHandle>.get_Current
	|
	|-RVA: 0x1D03070 Offset: 0x1D03171 VA: 0x1D03070
	|-Array.EmptyInternalEnumerator<Keyframe>.get_Current
	|
	|-RVA: 0x1D03280 Offset: 0x1D03381 VA: 0x1D03280
	|-Array.EmptyInternalEnumerator<LOD>.get_Current
	|
	|-RVA: 0x1D03470 Offset: 0x1D03571 VA: 0x1D03470
	|-Array.EmptyInternalEnumerator<LayerMask>.get_Current
	|
	|-RVA: 0x1D03650 Offset: 0x1D03751 VA: 0x1D03650
	|-Array.EmptyInternalEnumerator<LengthLimitProperties>.get_Current
	|
	|-RVA: 0x1D03830 Offset: 0x1D03931 VA: 0x1D03830
	|-Array.EmptyInternalEnumerator<Light2DBlendStyle>.get_Current
	|
	|-RVA: 0x1D03A80 Offset: 0x1D03B81 VA: 0x1D03A80
	|-Array.EmptyInternalEnumerator<LightDataGI>.get_Current
	|
	|-RVA: 0x1D03D00 Offset: 0x1D03E01 VA: 0x1D03D00
	|-Array.EmptyInternalEnumerator<LocalDefinition>.get_Current
	|
	|-RVA: 0x1D03EF0 Offset: 0x1D03FF1 VA: 0x1D03EF0
	|-Array.EmptyInternalEnumerator<MapPos>.get_Current
	|
	|-RVA: 0x1D040D0 Offset: 0x1D041D1 VA: 0x1D040D0
	|-Array.EmptyInternalEnumerator<MapRange>.get_Current
	|
	|-RVA: 0x1D042C0 Offset: 0x1D043C1 VA: 0x1D042C0
	|-Array.EmptyInternalEnumerator<MaterialReference>.get_Current
	|
	|-RVA: 0x1D044D0 Offset: 0x1D045D1 VA: 0x1D044D0
	|-Array.EmptyInternalEnumerator<Matrix4x4>.get_Current
	|
	|-RVA: 0x1D046F0 Offset: 0x1D047F1 VA: 0x1D046F0
	|-Array.EmptyInternalEnumerator<MomentProcessorState>.get_Current
	|
	|-RVA: 0x1D04900 Offset: 0x1D04A01 VA: 0x1D04900
	|-Array.EmptyInternalEnumerator<MomentStatistic>.get_Current
	|
	|-RVA: 0x1D04AF0 Offset: 0x1D04BF1 VA: 0x1D04AF0
	|-Array.EmptyInternalEnumerator<Navigation>.get_Current
	|
	|-RVA: 0x1D04D00 Offset: 0x1D04E01 VA: 0x1D04D00
	|-Array.EmptyInternalEnumerator<NetworkServiceAccountId>.get_Current
	|
	|-RVA: 0x1D04EE0 Offset: 0x1D04FE1 VA: 0x1D04EE0
	|-Array.EmptyInternalEnumerator<NpadFullKeyState>.get_Current
	|
	|-RVA: 0x1D050F0 Offset: 0x1D051F1 VA: 0x1D050F0
	|-Array.EmptyInternalEnumerator<NpadHandheldState>.get_Current
	|
	|-RVA: 0x1D05300 Offset: 0x1D05401 VA: 0x1D05300
	|-Array.EmptyInternalEnumerator<NpadJoyDualState>.get_Current
	|
	|-RVA: 0x1D05510 Offset: 0x1D05611 VA: 0x1D05510
	|-Array.EmptyInternalEnumerator<NpadJoyLeftState>.get_Current
	|
	|-RVA: 0x1D05720 Offset: 0x1D05821 VA: 0x1D05720
	|-Array.EmptyInternalEnumerator<NpadJoyRightState>.get_Current
	|
	|-RVA: 0x1D05930 Offset: 0x1D05A31 VA: 0x1D05930
	|-Array.EmptyInternalEnumerator<NpadStateArrayItem>.get_Current
	|
	|-RVA: 0x1D05B40 Offset: 0x1D05C41 VA: 0x1D05B40
	|-Array.EmptyInternalEnumerator<NsUid>.get_Current
	|
	|-RVA: 0x1D05D20 Offset: 0x1D05E21 VA: 0x1D05D20
	|-Array.EmptyInternalEnumerator<object>.get_Current
	|
	|-RVA: 0x1D05EC0 Offset: 0x1D05FC1 VA: 0x1D05EC0
	|-Array.EmptyInternalEnumerator<ObjectInitializationData>.get_Current
	|
	|-RVA: 0x1D060D0 Offset: 0x1D061D1 VA: 0x1D060D0
	|-Array.EmptyInternalEnumerator<ParameterModifier>.get_Current
	|
	|-RVA: 0x1D062B0 Offset: 0x1D063B1 VA: 0x1D062B0
	|-Array.EmptyInternalEnumerator<Plane>.get_Current
	|
	|-RVA: 0x1D064A0 Offset: 0x1D065A1 VA: 0x1D064A0
	|-Array.EmptyInternalEnumerator<Playable>.get_Current
	|
	|-RVA: 0x1D06690 Offset: 0x1D06791 VA: 0x1D06690
	|-Array.EmptyInternalEnumerator<PlayableBinding>.get_Current
	|
	|-RVA: 0x1D06890 Offset: 0x1D06991 VA: 0x1D06890
	|-Array.EmptyInternalEnumerator<PlayerLoopSystem>.get_Current
	|
	|-RVA: 0x1D06AA0 Offset: 0x1D06BA1 VA: 0x1D06AA0
	|-Array.EmptyInternalEnumerator<PlayerLoopSystemInternal>.get_Current
	|
	|-RVA: 0x1D06CB0 Offset: 0x1D06DB1 VA: 0x1D06CB0
	|-Array.EmptyInternalEnumerator<PreTile>.get_Current
	|
	|-RVA: 0x1D06ED0 Offset: 0x1D06FD1 VA: 0x1D06ED0
	|-Array.EmptyInternalEnumerator<Profile>.get_Current
	|
	|-RVA: 0x1D070E0 Offset: 0x1D071E1 VA: 0x1D070E0
	|-Array.EmptyInternalEnumerator<Protrusion>.get_Current
	|
	|-RVA: 0x1D072C0 Offset: 0x1D073C1 VA: 0x1D072C0
	|-Array.EmptyInternalEnumerator<Quaternion>.get_Current
	|
	|-RVA: 0x1D074B0 Offset: 0x1D075B1 VA: 0x1D074B0
	|-Array.EmptyInternalEnumerator<RandomSeed>.get_Current
	|
	|-RVA: 0x1D076A0 Offset: 0x1D077A1 VA: 0x1D076A0
	|-Array.EmptyInternalEnumerator<RangePositionInfo>.get_Current
	|
	|-RVA: 0x1D07890 Offset: 0x1D07991 VA: 0x1D07890
	|-Array.EmptyInternalEnumerator<Ranking2ChartInfoInput>.get_Current
	|
	|-RVA: 0x1D07A70 Offset: 0x1D07B71 VA: 0x1D07A70
	|-Array.EmptyInternalEnumerator<RaycastHit>.get_Current
	|
	|-RVA: 0x1D07C90 Offset: 0x1D07D91 VA: 0x1D07C90
	|-Array.EmptyInternalEnumerator<RaycastHit2D>.get_Current
	|
	|-RVA: 0x1D07EA0 Offset: 0x1D07FA1 VA: 0x1D07EA0
	|-Array.EmptyInternalEnumerator<RaycastResult>.get_Current
	|
	|-RVA: 0x1D080F0 Offset: 0x1D081F1 VA: 0x1D080F0
	|-Array.EmptyInternalEnumerator<Rect>.get_Current
	|
	|-RVA: 0x1D082E0 Offset: 0x1D083E1 VA: 0x1D082E0
	|-Array.EmptyInternalEnumerator<RenderBuffer>.get_Current
	|
	|-RVA: 0x1D084D0 Offset: 0x1D085D1 VA: 0x1D084D0
	|-Array.EmptyInternalEnumerator<RenderStateBlock>.get_Current
	|
	|-RVA: 0x1D08770 Offset: 0x1D08871 VA: 0x1D08770
	|-Array.EmptyInternalEnumerator<RenderTargetHandle>.get_Current
	|
	|-RVA: 0x1D08980 Offset: 0x1D08A81 VA: 0x1D08980
	|-Array.EmptyInternalEnumerator<RenderTargetIdentifier>.get_Current
	|
	|-RVA: 0x1D08B90 Offset: 0x1D08C91 VA: 0x1D08B90
	|-Array.EmptyInternalEnumerator<RendererListHandle>.get_Current
	|
	|-RVA: 0x1D08D70 Offset: 0x1D08E71 VA: 0x1D08D70
	|-Array.EmptyInternalEnumerator<ResourceHandle>.get_Current
	|
	|-RVA: 0x1D08F50 Offset: 0x1D09051 VA: 0x1D08F50
	|-Array.EmptyInternalEnumerator<ResourceLocator>.get_Current
	|
	|-RVA: 0x1D09140 Offset: 0x1D09241 VA: 0x1D09140
	|-Array.EmptyInternalEnumerator<RichTextTagAttribute>.get_Current
	|
	|-RVA: 0x1D09340 Offset: 0x1D09441 VA: 0x1D09340
	|-Array.EmptyInternalEnumerator<RuntimeLabel>.get_Current
	|
	|-RVA: 0x1D09530 Offset: 0x1D09631 VA: 0x1D09530
	|-Array.EmptyInternalEnumerator<sbyte>.get_Current
	|
	|-RVA: 0x1D09710 Offset: 0x1D09811 VA: 0x1D09710
	|-Array.EmptyInternalEnumerator<SerializedType>.get_Current
	|
	|-RVA: 0x1D09910 Offset: 0x1D09A11 VA: 0x1D09910
	|-Array.EmptyInternalEnumerator<ShaderKeyword>.get_Current
	|
	|-RVA: 0x1D09AF0 Offset: 0x1D09BF1 VA: 0x1D09AF0
	|-Array.EmptyInternalEnumerator<ShaderTagId>.get_Current
	|
	|-RVA: 0x1D09CD0 Offset: 0x1D09DD1 VA: 0x1D09CD0
	|-Array.EmptyInternalEnumerator<ShadowSliceData>.get_Current
	|
	|-RVA: 0x1D09EE0 Offset: 0x1D09FE1 VA: 0x1D09EE0
	|-Array.EmptyInternalEnumerator<Shape>.get_Current
	|
	|-RVA: 0x1D0A0E0 Offset: 0x1D0A1E1 VA: 0x1D0A0E0
	|-Array.EmptyInternalEnumerator<float>.get_Current
	|
	|-RVA: 0x1D0A2C0 Offset: 0x1D0A3C1 VA: 0x1D0A2C0
	|-Array.EmptyInternalEnumerator<SixAxisSensorHandle>.get_Current
	|
	|-RVA: 0x1D0A4A0 Offset: 0x1D0A5A1 VA: 0x1D0A4A0
	|-Array.EmptyInternalEnumerator<SixAxisSensorState>.get_Current
	|
	|-RVA: 0x1D0A720 Offset: 0x1D0A821 VA: 0x1D0A720
	|-Array.EmptyInternalEnumerator<SkeletonBone>.get_Current
	|
	|-RVA: 0x1D0A930 Offset: 0x1D0AA31 VA: 0x1D0A930
	|-Array.EmptyInternalEnumerator<SortingLayer>.get_Current
	|
	|-RVA: 0x1D0AB10 Offset: 0x1D0AC11 VA: 0x1D0AB10
	|-Array.EmptyInternalEnumerator<SphericalHarmonicsL2>.get_Current
	|
	|-RVA: 0x1D0ADB0 Offset: 0x1D0AEB1 VA: 0x1D0ADB0
	|-Array.EmptyInternalEnumerator<SpinLock>.get_Current
	|
	|-RVA: 0x1D0AF90 Offset: 0x1D0B091 VA: 0x1D0AF90
	|-Array.EmptyInternalEnumerator<SpringBoneComponents>.get_Current
	|
	|-RVA: 0x1D0B1E0 Offset: 0x1D0B2E1 VA: 0x1D0B1E0
	|-Array.EmptyInternalEnumerator<SpringBoneProperties>.get_Current
	|
	|-RVA: 0x1D0B3F0 Offset: 0x1D0B4F1 VA: 0x1D0B3F0
	|-Array.EmptyInternalEnumerator<SpringColliderComponents>.get_Current
	|
	|-RVA: 0x1D0B6A0 Offset: 0x1D0B7A1 VA: 0x1D0B6A0
	|-Array.EmptyInternalEnumerator<SpringColliderProperties>.get_Current
	|
	|-RVA: 0x1D0B890 Offset: 0x1D0B991 VA: 0x1D0B890
	|-Array.EmptyInternalEnumerator<SpringForceComponent>.get_Current
	|
	|-RVA: 0x1D0BAB0 Offset: 0x1D0BBB1 VA: 0x1D0BAB0
	|-Array.EmptyInternalEnumerator<SpringJobElement>.get_Current
	|
	|-RVA: 0x1D0BCC0 Offset: 0x1D0BDC1 VA: 0x1D0BCC0
	|-Array.EmptyInternalEnumerator<SpriteState>.get_Current
	|
	|-RVA: 0x1D0BEC0 Offset: 0x1D0BFC1 VA: 0x1D0BEC0
	|-Array.EmptyInternalEnumerator<SubMeshDescriptor>.get_Current
	|
	|-RVA: 0x1D0C0D0 Offset: 0x1D0C1D1 VA: 0x1D0C0D0
	|-Array.EmptyInternalEnumerator<TMP_CharacterInfo>.get_Current
	|
	|-RVA: 0x1D0C2E0 Offset: 0x1D0C3E1 VA: 0x1D0C2E0
	|-Array.EmptyInternalEnumerator<TMP_FontWeightPair>.get_Current
	|
	|-RVA: 0x1D0C4D0 Offset: 0x1D0C5D1 VA: 0x1D0C4D0
	|-Array.EmptyInternalEnumerator<TMP_LineInfo>.get_Current
	|
	|-RVA: 0x1D0C750 Offset: 0x1D0C851 VA: 0x1D0C750
	|-Array.EmptyInternalEnumerator<TMP_LinkInfo>.get_Current
	|
	|-RVA: 0x1D0C960 Offset: 0x1D0CA61 VA: 0x1D0C960
	|-Array.EmptyInternalEnumerator<TMP_MeshInfo>.get_Current
	|
	|-RVA: 0x1D0CBB0 Offset: 0x1D0CCB1 VA: 0x1D0CBB0
	|-Array.EmptyInternalEnumerator<TMP_PageInfo>.get_Current
	|
	|-RVA: 0x1D0CDB0 Offset: 0x1D0CEB1 VA: 0x1D0CDB0
	|-Array.EmptyInternalEnumerator<TMP_WordInfo>.get_Current
	|
	|-RVA: 0x1D0CFB0 Offset: 0x1D0D0B1 VA: 0x1D0CFB0
	|-Array.EmptyInternalEnumerator<TablePair>.get_Current
	|
	|-RVA: 0x1D0D1A0 Offset: 0x1D0D2A1 VA: 0x1D0D1A0
	|-Array.EmptyInternalEnumerator<TextureHandle>.get_Current
	|
	|-RVA: 0x1D0D380 Offset: 0x1D0D481 VA: 0x1D0D380
	|-Array.EmptyInternalEnumerator<TimeSpan>.get_Current
	|
	|-RVA: 0x1D0D560 Offset: 0x1D0D661 VA: 0x1D0D560
	|-Array.EmptyInternalEnumerator<Touch>.get_Current
	|
	|-RVA: 0x1D0D7B0 Offset: 0x1D0D8B1 VA: 0x1D0D7B0
	|-Array.EmptyInternalEnumerator<TouchScreenState1>.get_Current
	|
	|-RVA: 0x1D0D9C0 Offset: 0x1D0DAC1 VA: 0x1D0D9C0
	|-Array.EmptyInternalEnumerator<TouchScreenState10>.get_Current
	|
	|-RVA: 0x1D0DBD0 Offset: 0x1D0DCD1 VA: 0x1D0DBD0
	|-Array.EmptyInternalEnumerator<TouchScreenState11>.get_Current
	|
	|-RVA: 0x1D0DDE0 Offset: 0x1D0DEE1 VA: 0x1D0DDE0
	|-Array.EmptyInternalEnumerator<TouchScreenState12>.get_Current
	|
	|-RVA: 0x1D0DFF0 Offset: 0x1D0E0F1 VA: 0x1D0DFF0
	|-Array.EmptyInternalEnumerator<TouchScreenState13>.get_Current
	|
	|-RVA: 0x1D0E200 Offset: 0x1D0E301 VA: 0x1D0E200
	|-Array.EmptyInternalEnumerator<TouchScreenState14>.get_Current
	|
	|-RVA: 0x1D0E410 Offset: 0x1D0E511 VA: 0x1D0E410
	|-Array.EmptyInternalEnumerator<TouchScreenState15>.get_Current
	|
	|-RVA: 0x1D0E620 Offset: 0x1D0E721 VA: 0x1D0E620
	|-Array.EmptyInternalEnumerator<TouchScreenState16>.get_Current
	|
	|-RVA: 0x1D0E830 Offset: 0x1D0E931 VA: 0x1D0E830
	|-Array.EmptyInternalEnumerator<TouchScreenState2>.get_Current
	|
	|-RVA: 0x1D0EAB0 Offset: 0x1D0EBB1 VA: 0x1D0EAB0
	|-Array.EmptyInternalEnumerator<TouchScreenState3>.get_Current
	|
	|-RVA: 0x1D0ECC0 Offset: 0x1D0EDC1 VA: 0x1D0ECC0
	|-Array.EmptyInternalEnumerator<TouchScreenState4>.get_Current
	|
	|-RVA: 0x1D0EED0 Offset: 0x1D0EFD1 VA: 0x1D0EED0
	|-Array.EmptyInternalEnumerator<TouchScreenState5>.get_Current
	|
	|-RVA: 0x1D0F0E0 Offset: 0x1D0F1E1 VA: 0x1D0F0E0
	|-Array.EmptyInternalEnumerator<TouchScreenState6>.get_Current
	|
	|-RVA: 0x1D0F2F0 Offset: 0x1D0F3F1 VA: 0x1D0F2F0
	|-Array.EmptyInternalEnumerator<TouchScreenState7>.get_Current
	|
	|-RVA: 0x1D0F500 Offset: 0x1D0F601 VA: 0x1D0F500
	|-Array.EmptyInternalEnumerator<TouchScreenState8>.get_Current
	|
	|-RVA: 0x1D0F710 Offset: 0x1D0F811 VA: 0x1D0F710
	|-Array.EmptyInternalEnumerator<TouchScreenState9>.get_Current
	|
	|-RVA: 0x1D0F920 Offset: 0x1D0FA21 VA: 0x1D0F920
	|-Array.EmptyInternalEnumerator<TouchState>.get_Current
	|
	|-RVA: 0x1D0FB30 Offset: 0x1D0FC31 VA: 0x1D0FB30
	|-Array.EmptyInternalEnumerator<TrailHand>.get_Current
	|
	|-RVA: 0x1D0FD30 Offset: 0x1D0FE31 VA: 0x1D0FD30
	|-Array.EmptyInternalEnumerator<TrailVertex>.get_Current
	|
	|-RVA: 0x1D0FF30 Offset: 0x1D10031 VA: 0x1D0FF30
	|-Array.EmptyInternalEnumerator<UICharInfo>.get_Current
	|
	|-RVA: 0x1D10120 Offset: 0x1D10221 VA: 0x1D10120
	|-Array.EmptyInternalEnumerator<UILineInfo>.get_Current
	|
	|-RVA: 0x1D10310 Offset: 0x1D10411 VA: 0x1D10310
	|-Array.EmptyInternalEnumerator<UIVertex>.get_Current
	|
	|-RVA: 0x1D105B0 Offset: 0x1D106B1 VA: 0x1D105B0
	|-Array.EmptyInternalEnumerator<ushort>.get_Current
	|
	|-RVA: 0x1D10790 Offset: 0x1D10891 VA: 0x1D10790
	|-Array.EmptyInternalEnumerator<UInt16Enum>.get_Current
	|
	|-RVA: 0x1D10970 Offset: 0x1D10A71 VA: 0x1D10970
	|-Array.EmptyInternalEnumerator<uint>.get_Current
	|
	|-RVA: 0x1D10B50 Offset: 0x1D10C51 VA: 0x1D10B50
	|-Array.EmptyInternalEnumerator<UInt32Enum>.get_Current
	|
	|-RVA: 0x1D10D30 Offset: 0x1D10E31 VA: 0x1D10D30
	|-Array.EmptyInternalEnumerator<ulong>.get_Current
	|
	|-RVA: 0x1D10F10 Offset: 0x1D11011 VA: 0x1D10F10
	|-Array.EmptyInternalEnumerator<Uid>.get_Current
	|
	|-RVA: 0x1D11100 Offset: 0x1D11201 VA: 0x1D11100
	|-Array.EmptyInternalEnumerator<UniTask>.get_Current
	|
	|-RVA: 0x1D112E0 Offset: 0x1D113E1 VA: 0x1D112E0
	|-Array.EmptyInternalEnumerator<Unit>.get_Current
	|
	|-RVA: 0x1D114C0 Offset: 0x1D115C1 VA: 0x1D114C0
	|-Array.EmptyInternalEnumerator<UnitEnum>.get_Current
	|
	|-RVA: 0x1D116A0 Offset: 0x1D117A1 VA: 0x1D116A0
	|-Array.EmptyInternalEnumerator<UserWord>.get_Current
	|
	|-RVA: 0x1D11890 Offset: 0x1D11991 VA: 0x1D11890
	|-Array.EmptyInternalEnumerator<Vector2>.get_Current
	|
	|-RVA: 0x1D11A70 Offset: 0x1D11B71 VA: 0x1D11A70
	|-Array.EmptyInternalEnumerator<Vector2Int>.get_Current
	|
	|-RVA: 0x1D11C50 Offset: 0x1D11D51 VA: 0x1D11C50
	|-Array.EmptyInternalEnumerator<Vector3>.get_Current
	|
	|-RVA: 0x1D11E40 Offset: 0x1D11F41 VA: 0x1D11E40
	|-Array.EmptyInternalEnumerator<Vector4>.get_Current
	|
	|-RVA: 0x1D12030 Offset: 0x1D12131 VA: 0x1D12030
	|-Array.EmptyInternalEnumerator<VertexAttributeDescriptor>.get_Current
	|
	|-RVA: 0x1D12220 Offset: 0x1D12321 VA: 0x1D12220
	|-Array.EmptyInternalEnumerator<VibrationDeviceHandle>.get_Current
	|
	|-RVA: 0x1D12400 Offset: 0x1D12501 VA: 0x1D12400
	|-Array.EmptyInternalEnumerator<VibrationDeviceInfo>.get_Current
	|
	|-RVA: 0x1D125E0 Offset: 0x1D126E1 VA: 0x1D125E0
	|-Array.EmptyInternalEnumerator<VibrationValue>.get_Current
	|
	|-RVA: 0x1D127D0 Offset: 0x1D128D1 VA: 0x1D127D0
	|-Array.EmptyInternalEnumerator<VisibleLight>.get_Current
	|
	|-RVA: 0x1D12A70 Offset: 0x1D12B71 VA: 0x1D12A70
	|-Array.EmptyInternalEnumerator<WordWrapState>.get_Current
	|
	|-RVA: 0x1D12C80 Offset: 0x1D12D81 VA: 0x1D12C80
	|-Array.EmptyInternalEnumerator<X509ChainStatus>.get_Current
	|
	|-RVA: 0x1D12E70 Offset: 0x1D12F71 VA: 0x1D12E70
	|-Array.EmptyInternalEnumerator<XPathNode>.get_Current
	|
	|-RVA: 0x1D13070 Offset: 0x1D13171 VA: 0x1D13070
	|-Array.EmptyInternalEnumerator<XPathNodeRef>.get_Current
	|
	|-RVA: 0x1D13260 Offset: 0x1D13361 VA: 0x1D13260
	|-Array.EmptyInternalEnumerator<XRView>.get_Current
	|
	|-RVA: 0x1D13470 Offset: 0x1D13571 VA: 0x1D13470
	|-Array.EmptyInternalEnumerator<float3>.get_Current
	|
	|-RVA: 0x1D13660 Offset: 0x1D13761 VA: 0x1D13660
	|-Array.EmptyInternalEnumerator<float4x4>.get_Current
	|
	|-RVA: 0x1D13880 Offset: 0x1D13981 VA: 0x1D13880
	|-Array.EmptyInternalEnumerator<jvalue>.get_Current
	|
	|-RVA: 0x1D13A60 Offset: 0x1D13B61 VA: 0x1D13A60
	|-Array.EmptyInternalEnumerator<uint4>.get_Current
	|
	|-RVA: 0x1D13C50 Offset: 0x1D13D51 VA: 0x1D13C50
	|-Array.EmptyInternalEnumerator<AICrossfire.PositionTable>.get_Current
	|
	|-RVA: 0x1D13E40 Offset: 0x1D13F41 VA: 0x1D13E40
	|-Array.EmptyInternalEnumerator<AIEnum.SkillRangeEnemyData>.get_Current
	|
	|-RVA: 0x1D14030 Offset: 0x1D14131 VA: 0x1D14030
	|-Array.EmptyInternalEnumerator<AIOrder.UnitPriority>.get_Current
	|
	|-RVA: 0x1D14210 Offset: 0x1D14311 VA: 0x1D14210
	|-Array.EmptyInternalEnumerator<AmiiboSequence.GainItemData>.get_Current
	|
	|-RVA: 0x1D14400 Offset: 0x1D14501 VA: 0x1D14400
	|-Array.EmptyInternalEnumerator<AnimationOutputWeightProcessor.WeightInfo>.get_Current
	|
	|-RVA: 0x1D14610 Offset: 0x1D14711 VA: 0x1D14610
	|-Array.EmptyInternalEnumerator<ArenaOrderSequence.GodInfo>.get_Current
	|
	|-RVA: 0x1D14800 Offset: 0x1D14901 VA: 0x1D14800
	|-Array.EmptyInternalEnumerator<BattleInfo.SupportData>.get_Current
	|
	|-RVA: 0x1D149F0 Offset: 0x1D14AF1 VA: 0x1D149F0
	|-Array.EmptyInternalEnumerator<BeforeRenderHelper.OrderBlock>.get_Current
	|
	|-RVA: 0x1D14BE0 Offset: 0x1D14CE1 VA: 0x1D14BE0
	|-Array.EmptyInternalEnumerator<Camera.RenderRequest>.get_Current
	|
	|-RVA: 0x1D14DE0 Offset: 0x1D14EE1 VA: 0x1D14DE0
	|-Array.EmptyInternalEnumerator<CameraState.CustomBlendable>.get_Current
	|
	|-RVA: 0x1D14FD0 Offset: 0x1D150D1 VA: 0x1D14FD0
	|-Array.EmptyInternalEnumerator<CinemachineBlendListCamera.Instruction>.get_Current
	|
	|-RVA: 0x1D151D0 Offset: 0x1D152D1 VA: 0x1D151D0
	|-Array.EmptyInternalEnumerator<CinemachineBlenderSettings.CustomBlend>.get_Current
	|
	|-RVA: 0x1D153D0 Offset: 0x1D154D1 VA: 0x1D153D0
	|-Array.EmptyInternalEnumerator<CinemachineClearShot.Pair>.get_Current
	|
	|-RVA: 0x1D155B0 Offset: 0x1D156B1 VA: 0x1D155B0
	|-Array.EmptyInternalEnumerator<CinemachineFreeLook.Orbit>.get_Current
	|
	|-RVA: 0x1D15790 Offset: 0x1D15891 VA: 0x1D15790
	|-Array.EmptyInternalEnumerator<CinemachinePath.Waypoint>.get_Current
	|
	|-RVA: 0x1D159A0 Offset: 0x1D15AA1 VA: 0x1D159A0
	|-Array.EmptyInternalEnumerator<CinemachineSmoothPath.Waypoint>.get_Current
	|
	|-RVA: 0x1D15B90 Offset: 0x1D15C91 VA: 0x1D15B90
	|-Array.EmptyInternalEnumerator<CinemachineStateDrivenCamera.HashPair>.get_Current
	|
	|-RVA: 0x1D15D70 Offset: 0x1D15E71 VA: 0x1D15D70
	|-Array.EmptyInternalEnumerator<CinemachineStateDrivenCamera.Instruction>.get_Current
	|
	|-RVA: 0x1D15F70 Offset: 0x1D16071 VA: 0x1D15F70
	|-Array.EmptyInternalEnumerator<CinemachineStateDrivenCamera.ParentHash>.get_Current
	|
	|-RVA: 0x1D16150 Offset: 0x1D16251 VA: 0x1D16150
	|-Array.EmptyInternalEnumerator<CinemachineTargetGroup.Target>.get_Current
	|
	|-RVA: 0x1D16340 Offset: 0x1D16441 VA: 0x1D16340
	|-Array.EmptyInternalEnumerator<CodePointIndexer.TableRange>.get_Current
	|
	|-RVA: 0x1D16540 Offset: 0x1D16641 VA: 0x1D16540
	|-Array.EmptyInternalEnumerator<ContentCatalogData.Bucket>.get_Current
	|
	|-RVA: 0x1D16730 Offset: 0x1D16831 VA: 0x1D16730
	|-Array.EmptyInternalEnumerator<CookieTokenizer.RecognizedAttribute>.get_Current
	|
	|-RVA: 0x1D16920 Offset: 0x1D16A21 VA: 0x1D16920
	|-Array.EmptyInternalEnumerator<DeferredLights.DrawCall>.get_Current
	|
	|-RVA: 0x1D16B30 Offset: 0x1D16C31 VA: 0x1D16B30
	|-Array.EmptyInternalEnumerator<DeferredShaderData.ComputeBufferInfo>.get_Current
	|
	|-RVA: 0x1D16D10 Offset: 0x1D16E11 VA: 0x1D16D10
	|-Array.EmptyInternalEnumerator<DeferredTiler.PrePunctualLight>.get_Current
	|
	|-RVA: 0x1D16F10 Offset: 0x1D17011 VA: 0x1D16F10
	|-Array.EmptyInternalEnumerator<DelayedActionManager.DelegateInfo>.get_Current
	|
	|-RVA: 0x1D17110 Offset: 0x1D17211 VA: 0x1D17110
	|-Array.EmptyInternalEnumerator<Detail.AsyncResultInt>.get_Current
	|
	|-RVA: 0x1D17320 Offset: 0x1D17421 VA: 0x1D17320
	|-Array.EmptyInternalEnumerator<Detail.CppArray>.get_Current
	|
	|-RVA: 0x1D17510 Offset: 0x1D17611 VA: 0x1D17510
	|-Array.EmptyInternalEnumerator<Detail.NotificationEventInt>.get_Current
	|
	|-RVA: 0x1D17720 Offset: 0x1D17821 VA: 0x1D17720
	|-Array.EmptyInternalEnumerator<DisposUnit.Item>.get_Current
	|
	|-RVA: 0x1D17910 Offset: 0x1D17A11 VA: 0x1D17910
	|-Array.EmptyInternalEnumerator<DragonRidePresetParamData.CourseData>.get_Current
	|
	|-RVA: 0x1D17B00 Offset: 0x1D17C01 VA: 0x1D17B00
	|-Array.EmptyInternalEnumerator<DragonRideTargetGroup.ChainParam>.get_Current
	|
	|-RVA: 0x1D17CF0 Offset: 0x1D17DF1 VA: 0x1D17CF0
	|-Array.EmptyInternalEnumerator<DynamicMesh.State>.get_Current
	|
	|-RVA: 0x1D17ED0 Offset: 0x1D17FD1 VA: 0x1D17ED0
	|-Array.EmptyInternalEnumerator<FXZEx.HitPoint>.get_Current
	|
	|-RVA: 0x1D180E0 Offset: 0x1D181E1 VA: 0x1D180E0
	|-Array.EmptyInternalEnumerator<FishingRadicalParamData.RadicalParam>.get_Current
	|
	|-RVA: 0x1D182D0 Offset: 0x1D183D1 VA: 0x1D182D0
	|-Array.EmptyInternalEnumerator<GameVariable.Value>.get_Current
	|
	|-RVA: 0x1D184C0 Offset: 0x1D185C1 VA: 0x1D184C0
	|-Array.EmptyInternalEnumerator<GmapPathAdjuster.TargetModel>.get_Current
	|
	|-RVA: 0x1D186C0 Offset: 0x1D187C1 VA: 0x1D186C0
	|-Array.EmptyInternalEnumerator<GmapSpotAdjuster.TargetModel>.get_Current
	|
	|-RVA: 0x1D188C0 Offset: 0x1D189C1 VA: 0x1D188C0
	|-Array.EmptyInternalEnumerator<GrounderQuadruped.Foot>.get_Current
	|
	|-RVA: 0x1D18AD0 Offset: 0x1D18BD1 VA: 0x1D18AD0
	|-Array.EmptyInternalEnumerator<Hashtable.bucket>.get_Current
	|
	|-RVA: 0x1D18CD0 Offset: 0x1D18DD1 VA: 0x1D18CD0
	|-Array.EmptyInternalEnumerator<HeadingTracker.Item>.get_Current
	|
	|-RVA: 0x1D18ED0 Offset: 0x1D18FD1 VA: 0x1D18ED0
	|-Array.EmptyInternalEnumerator<HubAccessoryRoomCamera.BackgroundSettings>.get_Current
	|
	|-RVA: 0x1D190E0 Offset: 0x1D191E1 VA: 0x1D190E0
	|-Array.EmptyInternalEnumerator<HubFastTravel.Location>.get_Current
	|
	|-RVA: 0x1D192E0 Offset: 0x1D193E1 VA: 0x1D192E0
	|-Array.EmptyInternalEnumerator<HubLensFlare.Flare>.get_Current
	|
	|-RVA: 0x1D194F0 Offset: 0x1D195F1 VA: 0x1D194F0
	|-Array.EmptyInternalEnumerator<HubLookAtController.LookAtIKParam>.get_Current
	|
	|-RVA: 0x1D196E0 Offset: 0x1D197E1 VA: 0x1D196E0
	|-Array.EmptyInternalEnumerator<HubMaterialArray.MaterialInfo>.get_Current
	|
	|-RVA: 0x1D198D0 Offset: 0x1D199D1 VA: 0x1D198D0
	|-Array.EmptyInternalEnumerator<IKSolverLimb.AxisDirection>.get_Current
	|
	|-RVA: 0x1D19AE0 Offset: 0x1D19BE1 VA: 0x1D19AE0
	|-Array.EmptyInternalEnumerator<InventoryPoolItemMenuContent.KindBgNameClass>.get_Current
	|
	|-RVA: 0x1D19CD0 Offset: 0x1D19DD1 VA: 0x1D19CD0
	|-Array.EmptyInternalEnumerator<LightUtility.ParametricLightMeshVertex>.get_Current
	|
	|-RVA: 0x1D19EE0 Offset: 0x1D19FE1 VA: 0x1D19EE0
	|-Array.EmptyInternalEnumerator<LightUtility.SpriteLightMeshVertex>.get_Current
	|
	|-RVA: 0x1D1A0F0 Offset: 0x1D1A1F1 VA: 0x1D1A0F0
	|-Array.EmptyInternalEnumerator<Map.Pos>.get_Current
	|
	|-RVA: 0x1D1A2D0 Offset: 0x1D1A3D1 VA: 0x1D1A2D0
	|-Array.EmptyInternalEnumerator<MapGodExp.KindDesc>.get_Current
	|
	|-RVA: 0x1D1A4C0 Offset: 0x1D1A5C1 VA: 0x1D1A4C0
	|-Array.EmptyInternalEnumerator<MapHistory.Command>.get_Current
	|
	|-RVA: 0x1D1A6A0 Offset: 0x1D1A7A1 VA: 0x1D1A6A0
	|-Array.EmptyInternalEnumerator<MapImage.BackupTerrain>.get_Current
	|
	|-RVA: 0x1D1A890 Offset: 0x1D1A991 VA: 0x1D1A890
	|-Array.EmptyInternalEnumerator<MapImageRange.Pos>.get_Current
	|
	|-RVA: 0x1D1AA70 Offset: 0x1D1AB71 VA: 0x1D1AA70
	|-Array.EmptyInternalEnumerator<MapKillBonus.KillBonus>.get_Current
	|
	|-RVA: 0x1D1AC50 Offset: 0x1D1AD51 VA: 0x1D1AC50
	|-Array.EmptyInternalEnumerator<MapKillBonus.KilledBonus>.get_Current
	|
	|-RVA: 0x1D1AE30 Offset: 0x1D1AF31 VA: 0x1D1AE30
	|-Array.EmptyInternalEnumerator<MapMind.Record>.get_Current
	|
	|-RVA: 0x1D1B080 Offset: 0x1D1B181 VA: 0x1D1B080
	|-Array.EmptyInternalEnumerator<MapMind.Target>.get_Current
	|
	|-RVA: 0x1D1B280 Offset: 0x1D1B381 VA: 0x1D1B280
	|-Array.EmptyInternalEnumerator<MapPanelDebug.Entity>.get_Current
	|
	|-RVA: 0x1D1B480 Offset: 0x1D1B581 VA: 0x1D1B480
	|-Array.EmptyInternalEnumerator<NexRanking.Data>.get_Current
	|
	|-RVA: 0x1D1B660 Offset: 0x1D1B761 VA: 0x1D1B660
	|-Array.EmptyInternalEnumerator<NexVersus.RatingData>.get_Current
	|
	|-RVA: 0x1D1B850 Offset: 0x1D1B951 VA: 0x1D1B850
	|-Array.EmptyInternalEnumerator<NoiseSettings.TransformNoiseParams>.get_Current
	|
	|-RVA: 0x1D1BA60 Offset: 0x1D1BB61 VA: 0x1D1BA60
	|-Array.EmptyInternalEnumerator<PackedPlayModeBuildLogs.RuntimeBuildLog>.get_Current
	|
	|-RVA: 0x1D1BC50 Offset: 0x1D1BD51 VA: 0x1D1BC50
	|-Array.EmptyInternalEnumerator<ParameterizedStrings.FormatParam>.get_Current
	|
	|-RVA: 0x1D1BE40 Offset: 0x1D1BF41 VA: 0x1D1BE40
	|-Array.EmptyInternalEnumerator<ParticleSystem.Particle>.get_Current
	|
	|-RVA: 0x1D1C050 Offset: 0x1D1C151 VA: 0x1D1C050
	|-Array.EmptyInternalEnumerator<ProfileCard.Achievement>.get_Current
	|
	|-RVA: 0x1D1C230 Offset: 0x1D1C331 VA: 0x1D1C230
	|-Array.EmptyInternalEnumerator<ProfileCard.SortieCount>.get_Current
	|
	|-RVA: 0x1D1C430 Offset: 0x1D1C531 VA: 0x1D1C430
	|-Array.EmptyInternalEnumerator<QualitySettingsStack.Settings>.get_Current
	|
	|-RVA: 0x1D1C640 Offset: 0x1D1C741 VA: 0x1D1C640
	|-Array.EmptyInternalEnumerator<RangeData.Offset>.get_Current
	|
	|-RVA: 0x1D1C820 Offset: 0x1D1C921 VA: 0x1D1C820
	|-Array.EmptyInternalEnumerator<RegexCharClass.LowerCaseMapping>.get_Current
	|
	|-RVA: 0x1D1CA10 Offset: 0x1D1CB11 VA: 0x1D1CA10
	|-Array.EmptyInternalEnumerator<Relay.ChooseAwardeeData>.get_Current
	|
	|-RVA: 0x1D1CC10 Offset: 0x1D1CD11 VA: 0x1D1CC10
	|-Array.EmptyInternalEnumerator<RelayAwardData.Info>.get_Current
	|
	|-RVA: 0x1D1CE00 Offset: 0x1D1CF01 VA: 0x1D1CE00
	|-Array.EmptyInternalEnumerator<RenderGraph.CompiledPassInfo>.get_Current
	|
	|-RVA: 0x1D1D050 Offset: 0x1D1D151 VA: 0x1D1D050
	|-Array.EmptyInternalEnumerator<RenderGraph.CompiledResourceInfo>.get_Current
	|
	|-RVA: 0x1D1D250 Offset: 0x1D1D351 VA: 0x1D1D250
	|-Array.EmptyInternalEnumerator<RenderGraphDebugData.PassDebugData>.get_Current
	|
	|-RVA: 0x1D1D450 Offset: 0x1D1D551 VA: 0x1D1D450
	|-Array.EmptyInternalEnumerator<RenderGraphDebugData.ResourceDebugData>.get_Current
	|
	|-RVA: 0x1D1D660 Offset: 0x1D1D761 VA: 0x1D1D660
	|-Array.EmptyInternalEnumerator<RenderGraphResourceRegistry.RendererListResource>.get_Current
	|
	|-RVA: 0x1D1D870 Offset: 0x1D1D971 VA: 0x1D1D870
	|-Array.EmptyInternalEnumerator<RingCleaningUnitSelectMenu.GodParam>.get_Current
	|
	|-RVA: 0x1D1DA60 Offset: 0x1D1DB61 VA: 0x1D1DA60
	|-Array.EmptyInternalEnumerator<SampleWave.Data>.get_Current
	|
	|-RVA: 0x1D1DC50 Offset: 0x1D1DD51 VA: 0x1D1DC50
	|-Array.EmptyInternalEnumerator<SampleWave.Temp>.get_Current
	|
	|-RVA: 0x1D1DE30 Offset: 0x1D1DF31 VA: 0x1D1DE30
	|-Array.EmptyInternalEnumerator<SendMouseEvents.HitInfo>.get_Current
	|
	|-RVA: 0x1D1E020 Offset: 0x1D1E121 VA: 0x1D1E020
	|-Array.EmptyInternalEnumerator<SequenceNode.SequenceConstructPosContext>.get_Current
	|
	|-RVA: 0x1D1E230 Offset: 0x1D1E331 VA: 0x1D1E230
	|-Array.EmptyInternalEnumerator<ShaderInput.LightData>.get_Current
	|
	|-RVA: 0x1D1E480 Offset: 0x1D1E581 VA: 0x1D1E480
	|-Array.EmptyInternalEnumerator<ShaderInput.ShadowData>.get_Current
	|
	|-RVA: 0x1D1E6D0 Offset: 0x1D1E7D1 VA: 0x1D1E6D0
	|-Array.EmptyInternalEnumerator<ShadowUtility.Edge>.get_Current
	|
	|-RVA: 0x1D1E8E0 Offset: 0x1D1E9E1 VA: 0x1D1E8E0
	|-Array.EmptyInternalEnumerator<SimpleAnimationPlayable.QueuedState>.get_Current
	|
	|-RVA: 0x1D1EAD0 Offset: 0x1D1EBD1 VA: 0x1D1EAD0
	|-Array.EmptyInternalEnumerator<SkillArray.Entity>.get_Current
	|
	|-RVA: 0x1D1ECB0 Offset: 0x1D1EDB1 VA: 0x1D1ECB0
	|-Array.EmptyInternalEnumerator<Socket.WSABUF>.get_Current
	|
	|-RVA: 0x1D1EEA0 Offset: 0x1D1EFA1 VA: 0x1D1EEA0
	|-Array.EmptyInternalEnumerator<Stream.Info>.get_Current
	|
	|-RVA: 0x1D1F090 Offset: 0x1D1F191 VA: 0x1D1F090
	|-Array.EmptyInternalEnumerator<TMP_Text.UnicodeChar>.get_Current
	|
	|-RVA: 0x1D1F280 Offset: 0x1D1F381 VA: 0x1D1F280
	|-Array.EmptyInternalEnumerator<TexturePacker_JsonArray.Frame>.get_Current
	|
	|-RVA: 0x1D1F4A0 Offset: 0x1D1F5A1 VA: 0x1D1F4A0
	|-Array.EmptyInternalEnumerator<TimeNotificationBehaviour.NotificationEntry>.get_Current
	|
	|-RVA: 0x1D1F6A0 Offset: 0x1D1F7A1 VA: 0x1D1F6A0
	|-Array.EmptyInternalEnumerator<UnitySynchronizationContext.WorkRequest>.get_Current
	|
	|-RVA: 0x1D1F8A0 Offset: 0x1D1F9A1 VA: 0x1D1F8A0
	|-Array.EmptyInternalEnumerator<XmlNamespaceManager.NamespaceDeclaration>.get_Current
	|
	|-RVA: 0x1D1FAA0 Offset: 0x1D1FBA1 VA: 0x1D1FAA0
	|-Array.EmptyInternalEnumerator<XmlSchemaObjectTable.XmlSchemaObjectEntry>.get_Current
	|
	|-RVA: 0x1D1FC90 Offset: 0x1D1FD91 VA: 0x1D1FC90
	|-Array.EmptyInternalEnumerator<XmlTextReaderImpl.ParsingState>.get_Current
	|
	|-RVA: 0x1D1FF30 Offset: 0x1D20031 VA: 0x1D1FF30
	|-Array.EmptyInternalEnumerator<AIThink.EnchantThink.Desc>.get_Current
	|
	|-RVA: 0x1D20120 Offset: 0x1D20221 VA: 0x1D20120
	|-Array.EmptyInternalEnumerator<AIThink.EnchantThink.ItemInfo>.get_Current
	|
	|-RVA: 0x1D20300 Offset: 0x1D20401 VA: 0x1D20300
	|-Array.EmptyInternalEnumerator<AIThink.EnchantThink.SurroundingInfo>.get_Current
	|
	|-RVA: 0x1D204E0 Offset: 0x1D205E1 VA: 0x1D204E0
	|-Array.EmptyInternalEnumerator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.get_Current
	|
	|-RVA: 0x1D206D0 Offset: 0x1D207D1 VA: 0x1D206D0
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStoreChangeMetaParamInt>.get_Current
	|
	|-RVA: 0x1D208E0 Offset: 0x1D209E1 VA: 0x1D208E0
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStoreDeleteParamInt>.get_Current
	|
	|-RVA: 0x1D20AD0 Offset: 0x1D20BD1 VA: 0x1D20AD0
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStoreGetMetaParamInt>.get_Current
	|
	|-RVA: 0x1D20CE0 Offset: 0x1D20DE1 VA: 0x1D20CE0
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStoreMetaInfoInt>.get_Current
	|
	|-RVA: 0x1D20EF0 Offset: 0x1D20FF1 VA: 0x1D20EF0
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStorePasswordInfoInt>.get_Current
	|
	|-RVA: 0x1D210F0 Offset: 0x1D211F1 VA: 0x1D210F0
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStorePersistenceInfoInt>.get_Current
	|
	|-RVA: 0x1D212F0 Offset: 0x1D213F1 VA: 0x1D212F0
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStorePreparePostParamInt>.get_Current
	|
	|-RVA: 0x1D21500 Offset: 0x1D21601 VA: 0x1D21500
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStoreRateObjectParamInt>.get_Current
	|
	|-RVA: 0x1D216F0 Offset: 0x1D217F1 VA: 0x1D216F0
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStoreRatingInitParamInt>.get_Current
	|
	|-RVA: 0x1D218F0 Offset: 0x1D219F1 VA: 0x1D218F0
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStoreRatingTargetInt>.get_Current
	|
	|-RVA: 0x1D21AE0 Offset: 0x1D21BE1 VA: 0x1D21AE0
	|-Array.EmptyInternalEnumerator<Detail.Ranking.RankingCachedResultInt>.get_Current
	|
	|-RVA: 0x1D21CF0 Offset: 0x1D21DF1 VA: 0x1D21CF0
	|-Array.EmptyInternalEnumerator<Detail.Ranking.RankingOrderParamInt>.get_Current
	|
	|-RVA: 0x1D21EE0 Offset: 0x1D21FE1 VA: 0x1D21EE0
	|-Array.EmptyInternalEnumerator<Detail.Ranking.RankingRankDataInt>.get_Current
	|
	|-RVA: 0x1D22100 Offset: 0x1D22201 VA: 0x1D22100
	|-Array.EmptyInternalEnumerator<Detail.Ranking2.Ranking2ChartInfoInt>.get_Current
	|
	|-RVA: 0x1D22380 Offset: 0x1D22481 VA: 0x1D22380
	|-Array.EmptyInternalEnumerator<Detail.Ranking2.Ranking2RankDataInt>.get_Current
	|
	|-RVA: 0x1D225A0 Offset: 0x1D226A1 VA: 0x1D225A0
	|-Array.EmptyInternalEnumerator<Detail.Ranking2.Ranking2ScoreDataInt>.get_Current
	|
	|-RVA: 0x1D22790 Offset: 0x1D22891 VA: 0x1D22790
	|-Array.EmptyInternalEnumerator<Detail.Screening.ScreeningContextInfoInt>.get_Current
	|
	|-RVA: 0x1D22990 Offset: 0x1D22A91 VA: 0x1D22990
	|-Array.EmptyInternalEnumerator<Detail.Subscriber.SubscriberContentInt>.get_Current
	|
	|-RVA: 0x1D22BE0 Offset: 0x1D22CE1 VA: 0x1D22BE0
	|-Array.EmptyInternalEnumerator<Detail.Subscriber.SubscriberGetContentParamInt>.get_Current
	|
	|-RVA: 0x1D22DE0 Offset: 0x1D22EE1 VA: 0x1D22DE0
	|-Array.EmptyInternalEnumerator<Detail.Subscriber.SubscriberUserStatusInfoInt>.get_Current
	|
	|-RVA: 0x1D22FF0 Offset: 0x1D230F1 VA: 0x1D22FF0
	|-Array.EmptyInternalEnumerator<Detail.Subscriber.SubscriberUserStatusParamInt>.get_Current
	|
	|-RVA: 0x1D231F0 Offset: 0x1D232F1 VA: 0x1D231F0
	|-Array.EmptyInternalEnumerator<Detail.Utility.IntegerSettings>.get_Current
	|
	|-RVA: 0x1D233D0 Offset: 0x1D234D1 VA: 0x1D233D0
	|-Array.EmptyInternalEnumerator<Detail.Utility.UniqueIdInfoInt>.get_Current
	|
	|-RVA: 0x1D235C0 Offset: 0x1D236C1 VA: 0x1D235C0
	|-Array.EmptyInternalEnumerator<FacetsChecker.FacetsCompiler.Map>.get_Current
	|
	|-RVA: 0x1D237B0 Offset: 0x1D238B1 VA: 0x1D237B0
	|-Array.EmptyInternalEnumerator<MapHistory.ReplayAppearanceMap.Appearance>.get_Current
	|
	|-RVA: 0x1D239B0 Offset: 0x1D23AB1 VA: 0x1D239B0
	|-Array.EmptyInternalEnumerator<MapHistory.ReplayAppearanceMap.Leaving>.get_Current
	|
	|-RVA: 0x1D23B90 Offset: 0x1D23C91 VA: 0x1D23B90
	|-Array.EmptyInternalEnumerator<MapHistory.ReplayUnitMap.Data>.get_Current
	|
	|-RVA: 0x1D23D70 Offset: 0x1D23E71 VA: 0x1D23D70
	|-Array.EmptyInternalEnumerator<MapHistory.Rewind.LatestInspectorData>.get_Current
	|
	|-RVA: 0x1D23F60 Offset: 0x1D24061 VA: 0x1D23F60
	|-Array.EmptyInternalEnumerator<MapHistory.Rewind.WorkTerrainData>.get_Current
	|
	|-RVA: 0x1D24150 Offset: 0x1D24251 VA: 0x1D24150
	|-Array.EmptyInternalEnumerator<MapHistory.RewindUnitMap.Data>.get_Current
	|
	|-RVA: 0x1D24360 Offset: 0x1D24461 VA: 0x1D24360
	|-Array.EmptyInternalEnumerator<MapKillBonus.Work.Pos>.get_Current
	|
	|-RVA: 0x1D24540 Offset: 0x1D24641 VA: 0x1D24540
	|-Array.EmptyInternalEnumerator<MapSkill.AroundCalculator.Result>.get_Current
	|
	|-RVA: 0x1D24730 Offset: 0x1D24831 VA: 0x1D24730
	|-Array.EmptyInternalEnumerator<Nex.ApiCallChecker.Guideline>.get_Current
	|
	|-RVA: 0x1D24910 Offset: 0x1D24A11 VA: 0x1D24910
	|-Array.EmptyInternalEnumerator<Ngc.MaskTextSequenceBase.Data>.get_Current
	|
	|-RVA: 0x1D24B10 Offset: 0x1D24C11 VA: 0x1D24B10
	|-Array.EmptyInternalEnumerator<TargetPositionCache.CacheCurve.Item>.get_Current
	|
	|-RVA: 0x1D24D20 Offset: 0x1D24E21 VA: 0x1D24D20
	|-Array.EmptyInternalEnumerator<TargetPositionCache.CacheEntry.RecordingItem>.get_Current
	|
	|-RVA: 0x1D24F30 Offset: 0x1D25031 VA: 0x1D24F30
	|-Array.EmptyInternalEnumerator<TerrainUtility.TerrainMap.TileCoord>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x263E570 Offset: 0x263E671 VA: 0x263E570
	|-Array.EmptyInternalEnumerator<ArraySegment<byte>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x263E760 Offset: 0x263E861 VA: 0x263E760
	|-Array.EmptyInternalEnumerator<AsyncOperationHandle<object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x263E960 Offset: 0x263EA61 VA: 0x263E960
	|-Array.EmptyInternalEnumerator<MapDeployTemplate.Queue.Data<object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x263EB40 Offset: 0x263EC41 VA: 0x263EB40
	|-Array.EmptyInternalEnumerator<Nex.DataStore.ParamPool.Data<object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x263ED30 Offset: 0x263EE31 VA: 0x263ED30
	|-Array.EmptyInternalEnumerator<Nex.Screening.ParamPool.Data<object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x263EF20 Offset: 0x263F021 VA: 0x263EF20
	|-Array.EmptyInternalEnumerator<IntervalTree.Entry<object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x263F120 Offset: 0x263F221 VA: 0x263F120
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<ValueTuple<object, int>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x263F320 Offset: 0x263F421 VA: 0x263F320
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<byte, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x263F520 Offset: 0x263F621 VA: 0x263F520
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<CancellationToken, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x263F720 Offset: 0x263F821 VA: 0x263F720
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<char, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x263F920 Offset: 0x263FA21 VA: 0x263F920
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Guid, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x263FB20 Offset: 0x263FC21 VA: 0x263FB20
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, bool>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x263FD10 Offset: 0x263FE11 VA: 0x263FD10
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, byte>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x263FF00 Offset: 0x2640001 VA: 0x263FF00
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, char>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26400F0 Offset: 0x26401F1 VA: 0x26400F0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, DiagnosticEvent>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2640310 Offset: 0x2640411 VA: 0x2640310
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2640500 Offset: 0x2640601 VA: 0x2640500
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, Int32Enum>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26406F0 Offset: 0x26407F1 VA: 0x26406F0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, long>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26408F0 Offset: 0x26409F1 VA: 0x26408F0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, MapPos>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2640AF0 Offset: 0x2640BF1 VA: 0x2640AF0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2640CF0 Offset: 0x2640DF1 VA: 0x2640CF0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, uint>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2640EE0 Offset: 0x2640FE1 VA: 0x2640EE0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, AIThink.EnchantThink.SurroundingInfo>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26410D0 Offset: 0x26411D1 VA: 0x26410D0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, bool>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26412C0 Offset: 0x26413C1 VA: 0x26412C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26414B0 Offset: 0x26415B1 VA: 0x26414B0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, Int32Enum>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26416A0 Offset: 0x26417A1 VA: 0x26416A0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26418A0 Offset: 0x26419A1 VA: 0x26418A0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<long, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2641AA0 Offset: 0x2641BA1 VA: 0x2641AA0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<MapPos, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2641CA0 Offset: 0x2641DA1 VA: 0x2641CA0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, AsyncOperationHandle<object>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2641EB0 Offset: 0x2641FB1 VA: 0x2641EB0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, AsyncOperationHandle>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26420C0 Offset: 0x26421C1 VA: 0x26420C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, bool>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26422C0 Offset: 0x26423C1 VA: 0x26422C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, byte>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26424C0 Offset: 0x26425C1 VA: 0x26424C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26426C0 Offset: 0x26427C1 VA: 0x26426C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Int32Enum>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26428C0 Offset: 0x26429C1 VA: 0x26428C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, IntPtr>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2642AC0 Offset: 0x2642BC1 VA: 0x2642AC0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2642CC0 Offset: 0x2642DC1 VA: 0x2642CC0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Playable>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2642EC0 Offset: 0x2642FC1 VA: 0x2642EC0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, ResourceLocator>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26430C0 Offset: 0x26431C1 VA: 0x26430C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, float>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26432C0 Offset: 0x26433C1 VA: 0x26432C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, ushort>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26434C0 Offset: 0x26435C1 VA: 0x26434C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, GameVariable.Value>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26436C0 Offset: 0x26437C1 VA: 0x26436C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<sbyte, DataStoreRatingInfo>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26438D0 Offset: 0x26439D1 VA: 0x26438D0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<sbyte, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2643AD0 Offset: 0x2643BD1 VA: 0x2643AD0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<ushort, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2643CC0 Offset: 0x2643DC1 VA: 0x2643CC0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<uint, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2643EB0 Offset: 0x2643FB1 VA: 0x2643EB0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<uint, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26440B0 Offset: 0x26441B1 VA: 0x26440B0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<ulong, Friend>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26442C0 Offset: 0x26443C1 VA: 0x26442C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<ulong, Int32Enum>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26444C0 Offset: 0x26445C1 VA: 0x26444C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<ulong, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26446C0 Offset: 0x26447C1 VA: 0x26446C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Vector3, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26448C0 Offset: 0x26449C1 VA: 0x26448C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<XPathNodeRef, XPathNodeRef>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2644AD0 Offset: 0x2644BD1 VA: 0x2644AD0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<TerrainUtility.TerrainMap.TileCoord, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2644CD0 Offset: 0x2644DD1 VA: 0x2644CD0
	|-Array.EmptyInternalEnumerator<PriorityQueue.IndexedItem<object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2644EC0 Offset: 0x2644FC1 VA: 0x2644EC0
	|-Array.EmptyInternalEnumerator<KeyValuePair<ValueTuple<object, int>, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26450C0 Offset: 0x26451C1 VA: 0x26450C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<byte, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26452B0 Offset: 0x26453B1 VA: 0x26452B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<CancellationToken, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26454A0 Offset: 0x26455A1 VA: 0x26454A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<char, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2645690 Offset: 0x2645791 VA: 0x2645690
	|-Array.EmptyInternalEnumerator<KeyValuePair<DateTime, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2645880 Offset: 0x2645981 VA: 0x2645880
	|-Array.EmptyInternalEnumerator<KeyValuePair<Guid, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2645A80 Offset: 0x2645B81 VA: 0x2645A80
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, bool>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2645C60 Offset: 0x2645D61 VA: 0x2645C60
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, byte>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2645E40 Offset: 0x2645F41 VA: 0x2645E40
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, char>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2646020 Offset: 0x2646121 VA: 0x2646020
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, DiagnosticEvent>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2646230 Offset: 0x2646331 VA: 0x2646230
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2646410 Offset: 0x2646511 VA: 0x2646410
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, Int32Enum>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26465F0 Offset: 0x26466F1 VA: 0x26465F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, long>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26467E0 Offset: 0x26468E1 VA: 0x26467E0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, MapPos>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26469D0 Offset: 0x2646AD1 VA: 0x26469D0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2646BC0 Offset: 0x2646CC1 VA: 0x2646BC0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, uint>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2646DA0 Offset: 0x2646EA1 VA: 0x2646DA0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, AIThink.EnchantThink.SurroundingInfo>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2646F80 Offset: 0x2647081 VA: 0x2646F80
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, bool>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2647160 Offset: 0x2647261 VA: 0x2647160
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2647340 Offset: 0x2647441 VA: 0x2647340
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, Int32Enum>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2647520 Offset: 0x2647621 VA: 0x2647520
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2647710 Offset: 0x2647811 VA: 0x2647710
	|-Array.EmptyInternalEnumerator<KeyValuePair<long, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2647900 Offset: 0x2647A01 VA: 0x2647900
	|-Array.EmptyInternalEnumerator<KeyValuePair<MapPos, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2647AF0 Offset: 0x2647BF1 VA: 0x2647AF0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, AsyncOperationHandle<object>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2647CF0 Offset: 0x2647DF1 VA: 0x2647CF0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2647EF0 Offset: 0x2647FF1 VA: 0x2647EF0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, AsyncOperationHandle>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26480F0 Offset: 0x26481F1 VA: 0x26480F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, bool>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26482E0 Offset: 0x26483E1 VA: 0x26482E0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, byte>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26484D0 Offset: 0x26485D1 VA: 0x26484D0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26486C0 Offset: 0x26487C1 VA: 0x26486C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Int32Enum>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26488B0 Offset: 0x26489B1 VA: 0x26488B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, IntPtr>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2648AA0 Offset: 0x2648BA1 VA: 0x2648AA0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2648C90 Offset: 0x2648D91 VA: 0x2648C90
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Playable>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2648E90 Offset: 0x2648F91 VA: 0x2648E90
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, ResourceLocator>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2649090 Offset: 0x2649191 VA: 0x2649090
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, float>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2649280 Offset: 0x2649381 VA: 0x2649280
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, ushort>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2649470 Offset: 0x2649571 VA: 0x2649470
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, GameVariable.Value>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2649670 Offset: 0x2649771 VA: 0x2649670
	|-Array.EmptyInternalEnumerator<KeyValuePair<sbyte, DataStoreRatingInfo>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2649870 Offset: 0x2649971 VA: 0x2649870
	|-Array.EmptyInternalEnumerator<KeyValuePair<sbyte, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2649A60 Offset: 0x2649B61 VA: 0x2649A60
	|-Array.EmptyInternalEnumerator<KeyValuePair<ushort, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2649C40 Offset: 0x2649D41 VA: 0x2649C40
	|-Array.EmptyInternalEnumerator<KeyValuePair<uint, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2649E20 Offset: 0x2649F21 VA: 0x2649E20
	|-Array.EmptyInternalEnumerator<KeyValuePair<uint, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x264A010 Offset: 0x264A111 VA: 0x264A010
	|-Array.EmptyInternalEnumerator<KeyValuePair<ulong, Friend>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x264A220 Offset: 0x264A321 VA: 0x264A220
	|-Array.EmptyInternalEnumerator<KeyValuePair<ulong, Int32Enum>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x264A410 Offset: 0x264A511 VA: 0x264A410
	|-Array.EmptyInternalEnumerator<KeyValuePair<ulong, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x264A600 Offset: 0x264A701 VA: 0x264A600
	|-Array.EmptyInternalEnumerator<KeyValuePair<Vector3, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x264A7F0 Offset: 0x264A8F1 VA: 0x264A7F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<XPathNodeRef, XPathNodeRef>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x264A9F0 Offset: 0x264AAF1 VA: 0x264A9F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<TerrainUtility.TerrainMap.TileCoord, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x264ABE0 Offset: 0x264ACE1 VA: 0x264ABE0
	|-Array.EmptyInternalEnumerator<NativeArray<PreTile>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x264ADD0 Offset: 0x264AED1 VA: 0x264ADD0
	|-Array.EmptyInternalEnumerator<CommonBattleSequence.Reliance<object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x264AFD0 Offset: 0x264B0D1 VA: 0x264AFD0
	|-Array.EmptyInternalEnumerator<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x264B1C0 Offset: 0x264B2C1 VA: 0x264B1C0
	|-Array.EmptyInternalEnumerator<HashSet.Slot<ValueTuple<object, int>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x264B3C0 Offset: 0x264B4C1 VA: 0x264B3C0
	|-Array.EmptyInternalEnumerator<HashSet.Slot<AsyncOperationHandle>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x264B5C0 Offset: 0x264B6C1 VA: 0x264B5C0
	|-Array.EmptyInternalEnumerator<HashSet.Slot<int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x264B7B0 Offset: 0x264B8B1 VA: 0x264B7B0
	|-Array.EmptyInternalEnumerator<HashSet.Slot<Int32Enum>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x264B9A0 Offset: 0x264BAA1 VA: 0x264B9A0
	|-Array.EmptyInternalEnumerator<Set.Slot<Int32Enum>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x264BB90 Offset: 0x264BC91 VA: 0x264BB90
	|-Array.EmptyInternalEnumerator<HashSet.Slot<MapPos>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x264BD80 Offset: 0x264BE81 VA: 0x264BD80
	|-Array.EmptyInternalEnumerator<HashSet.Slot<object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x264BF70 Offset: 0x264C071 VA: 0x264BF70
	|-Array.EmptyInternalEnumerator<Set.Slot<object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x264C170 Offset: 0x264C271 VA: 0x264C170
	|-Array.EmptyInternalEnumerator<HashSet.Slot<uint>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x264C360 Offset: 0x264C461 VA: 0x264C360
	|-Array.EmptyInternalEnumerator<HashSet.Slot<ulong>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x264C550 Offset: 0x264C651 VA: 0x264C550
	|-Array.EmptyInternalEnumerator<Set.Slot<Vector3>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x264C750 Offset: 0x264C851 VA: 0x264C750
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<Color32>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x264C950 Offset: 0x264CA51 VA: 0x264C950
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<HighlightState>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x264CB60 Offset: 0x264CC61 VA: 0x264CB60
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x264CD60 Offset: 0x264CE61 VA: 0x264CD60
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<Int32Enum>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x264CF60 Offset: 0x264D061 VA: 0x264CF60
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<MaterialReference>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x264D1C0 Offset: 0x264D2C1 VA: 0x264D1C0
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x264D3D0 Offset: 0x264D4D1 VA: 0x264D3D0
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<float>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x264D5D0 Offset: 0x264D6D1 VA: 0x264D5D0
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<WordWrapState>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x264D7E0 Offset: 0x264D8E1 VA: 0x264D7E0
	|-Array.EmptyInternalEnumerator<TimeInterval<object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x264D9D0 Offset: 0x264DAD1 VA: 0x264D9D0
	|-Array.EmptyInternalEnumerator<Timestamped<object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x264DBD0 Offset: 0x264DCD1 VA: 0x264DBD0
	|-Array.EmptyInternalEnumerator<UniTask<object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x264DDC0 Offset: 0x264DEC1 VA: 0x264DDC0
	|-Array.EmptyInternalEnumerator<ValueTuple<ValueTuple<bool, object>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x264DFB0 Offset: 0x264E0B1 VA: 0x264DFB0
	|-Array.EmptyInternalEnumerator<ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x264E1B0 Offset: 0x264E2B1 VA: 0x264E1B0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, UniTask<object>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x264E3B0 Offset: 0x264E4B1 VA: 0x264E3B0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x264E5B0 Offset: 0x264E6B1 VA: 0x264E5B0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x264E7C0 Offset: 0x264E8C1 VA: 0x264E7C0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x264E9D0 Offset: 0x264EAD1 VA: 0x264E9D0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x264EBC0 Offset: 0x264ECC1 VA: 0x264EBC0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x264EDB0 Offset: 0x264EEB1 VA: 0x264EDB0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x264EFD0 Offset: 0x264F0D1 VA: 0x264EFD0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x264F1C0 Offset: 0x264F2C1 VA: 0x264F1C0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x264F3D0 Offset: 0x264F4D1 VA: 0x264F3D0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x264F5E0 Offset: 0x264F6E1 VA: 0x264F5E0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x264F7E0 Offset: 0x264F8E1 VA: 0x264F7E0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x264F9F0 Offset: 0x264FAF1 VA: 0x264F9F0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x264FC00 Offset: 0x264FD01 VA: 0x264FC00
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x264FE10 Offset: 0x264FF11 VA: 0x264FE10
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2650020 Offset: 0x2650121 VA: 0x2650020
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2650220 Offset: 0x2650321 VA: 0x2650220
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2650430 Offset: 0x2650531 VA: 0x2650430
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2650620 Offset: 0x2650721 VA: 0x2650620
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2650830 Offset: 0x2650931 VA: 0x2650830
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2650A30 Offset: 0x2650B31 VA: 0x2650A30
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2650C40 Offset: 0x2650D41 VA: 0x2650C40
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2650E50 Offset: 0x2650F51 VA: 0x2650E50
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2651060 Offset: 0x2651161 VA: 0x2651060
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2651270 Offset: 0x2651371 VA: 0x2651270
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2651490 Offset: 0x2651591 VA: 0x2651490
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26516E0 Offset: 0x26517E1 VA: 0x26516E0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2651930 Offset: 0x2651A31 VA: 0x2651930
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2651B90 Offset: 0x2651C91 VA: 0x2651B90
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2651D80 Offset: 0x2651E81 VA: 0x2651D80
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2651F70 Offset: 0x2652071 VA: 0x2651F70
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2652180 Offset: 0x2652281 VA: 0x2652180
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2652370 Offset: 0x2652471 VA: 0x2652370
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2652570 Offset: 0x2652671 VA: 0x2652570
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2652780 Offset: 0x2652881 VA: 0x2652780
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2652980 Offset: 0x2652A81 VA: 0x2652980
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2652B90 Offset: 0x2652C91 VA: 0x2652B90
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2652DA0 Offset: 0x2652EA1 VA: 0x2652DA0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2652FA0 Offset: 0x26530A1 VA: 0x2652FA0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26531A0 Offset: 0x26532A1 VA: 0x26531A0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26533A0 Offset: 0x26534A1 VA: 0x26533A0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26535B0 Offset: 0x26536B1 VA: 0x26535B0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26537A0 Offset: 0x26538A1 VA: 0x26537A0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26539A0 Offset: 0x2653AA1 VA: 0x26539A0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2653BB0 Offset: 0x2653CB1 VA: 0x2653BB0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2653DB0 Offset: 0x2653EB1 VA: 0x2653DB0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2653FC0 Offset: 0x26540C1 VA: 0x2653FC0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26541D0 Offset: 0x26542D1 VA: 0x26541D0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26543F0 Offset: 0x26544F1 VA: 0x26543F0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2654600 Offset: 0x2654701 VA: 0x2654600
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2654850 Offset: 0x2654951 VA: 0x2654850
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2654A60 Offset: 0x2654B61 VA: 0x2654A60
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2654CE0 Offset: 0x2654DE1 VA: 0x2654CE0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2654F00 Offset: 0x2655001 VA: 0x2654F00
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2655190 Offset: 0x2655291 VA: 0x2655190
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26553E0 Offset: 0x26554E1 VA: 0x26553E0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2655690 Offset: 0x2655791 VA: 0x2655690
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26558E0 Offset: 0x26559E1 VA: 0x26558E0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2655AC0 Offset: 0x2655BC1 VA: 0x2655AC0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2655CA0 Offset: 0x2655DA1 VA: 0x2655CA0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2655EB0 Offset: 0x2655FB1 VA: 0x2655EB0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2656090 Offset: 0x2656191 VA: 0x2656090
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26562A0 Offset: 0x26563A1 VA: 0x26562A0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26564A0 Offset: 0x26565A1 VA: 0x26564A0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2656690 Offset: 0x2656791 VA: 0x2656690
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2656890 Offset: 0x2656991 VA: 0x2656890
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2656A90 Offset: 0x2656B91 VA: 0x2656A90
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2656CA0 Offset: 0x2656DA1 VA: 0x2656CA0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2656EB0 Offset: 0x2656FB1 VA: 0x2656EB0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26570A0 Offset: 0x26571A1 VA: 0x26570A0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26572A0 Offset: 0x26573A1 VA: 0x26572A0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2657480 Offset: 0x2657581 VA: 0x2657480
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2657680 Offset: 0x2657781 VA: 0x2657680
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2657880 Offset: 0x2657981 VA: 0x2657880
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2657A90 Offset: 0x2657B91 VA: 0x2657A90
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2657C90 Offset: 0x2657D91 VA: 0x2657C90
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2657E90 Offset: 0x2657F91 VA: 0x2657E90
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26580A0 Offset: 0x26581A1 VA: 0x26580A0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26582B0 Offset: 0x26583B1 VA: 0x26582B0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2658500 Offset: 0x2658601 VA: 0x2658500
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2658710 Offset: 0x2658811 VA: 0x2658710
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2658970 Offset: 0x2658A71 VA: 0x2658970
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2658B80 Offset: 0x2658C81 VA: 0x2658B80
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2658E10 Offset: 0x2658F11 VA: 0x2658E10
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2659030 Offset: 0x2659131 VA: 0x2659030
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x26592D0 Offset: 0x26593D1 VA: 0x26592D0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2659520 Offset: 0x2659621 VA: 0x2659520
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2659730 Offset: 0x2659831 VA: 0x2659730
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2659940 Offset: 0x2659A41 VA: 0x2659940
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2659B30 Offset: 0x2659C31 VA: 0x2659B30
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, bool>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2659D20 Offset: 0x2659E21 VA: 0x2659D20
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, Bounds>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2659F20 Offset: 0x265A021 VA: 0x2659F20
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, byte>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x265A110 Offset: 0x265A211 VA: 0x265A110
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, Color>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x265A310 Offset: 0x265A411 VA: 0x265A310
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, double>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x265A510 Offset: 0x265A611 VA: 0x265A510
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, int>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF0DC0 Offset: 0x1CF0EC1 VA: 0x1CF0DC0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, long>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF0FC0 Offset: 0x1CF10C1 VA: 0x1CF0FC0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, object>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF11C0 Offset: 0x1CF12C1 VA: 0x1CF11C0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, Quaternion>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF13C0 Offset: 0x1CF14C1 VA: 0x1CF13C0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, Rect>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF15C0 Offset: 0x1CF16C1 VA: 0x1CF15C0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, float>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF17B0 Offset: 0x1CF18B1 VA: 0x1CF17B0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, UniTask>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF19B0 Offset: 0x1CF1AB1 VA: 0x1CF19B0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, Unit>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF1BA0 Offset: 0x1CF1CA1 VA: 0x1CF1BA0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, Vector2>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF1D90 Offset: 0x1CF1E91 VA: 0x1CF1D90
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, Vector3>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF1F90 Offset: 0x1CF2091 VA: 0x1CF1F90
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, Vector4>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF2190 Offset: 0x1CF2291 VA: 0x1CF2190
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<int, object>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF2390 Offset: 0x1CF2491 VA: 0x1CF2390
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<object, object>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF2590 Offset: 0x1CF2691 VA: 0x1CF2590
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF27A0 Offset: 0x1CF28A1 VA: 0x1CF27A0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<object, object, object>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF29A0 Offset: 0x1CF2AA1 VA: 0x1CF29A0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF2BC0 Offset: 0x1CF2CC1 VA: 0x1CF2BC0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<object, object, object, object>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF2DD0 Offset: 0x1CF2ED1 VA: 0x1CF2DD0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF3020 Offset: 0x1CF3121 VA: 0x1CF3020
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF3230 Offset: 0x1CF3331 VA: 0x1CF3230
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF34B0 Offset: 0x1CF35B1 VA: 0x1CF34B0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF36C0 Offset: 0x1CF37C1 VA: 0x1CF36C0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF3950 Offset: 0x1CF3A51 VA: 0x1CF3950
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF3B70 Offset: 0x1CF3C71 VA: 0x1CF3B70
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF3E20 Offset: 0x1CF3F21 VA: 0x1CF3E20
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF4030 Offset: 0x1CF4131 VA: 0x1CF4030
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, AsyncUnit>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF4210 Offset: 0x1CF4311 VA: 0x1CF4210
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, bool>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF43F0 Offset: 0x1CF44F1 VA: 0x1CF43F0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Bounds>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF4600 Offset: 0x1CF4701 VA: 0x1CF4600
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, byte>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF47E0 Offset: 0x1CF48E1 VA: 0x1CF47E0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Color>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF49E0 Offset: 0x1CF4AE1 VA: 0x1CF49E0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, double>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF4BD0 Offset: 0x1CF4CD1 VA: 0x1CF4BD0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF4DB0 Offset: 0x1CF4EB1 VA: 0x1CF4DB0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, long>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF4FA0 Offset: 0x1CF50A1 VA: 0x1CF4FA0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF5190 Offset: 0x1CF5291 VA: 0x1CF5190
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Quaternion>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF5390 Offset: 0x1CF5491 VA: 0x1CF5390
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Rect>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF5590 Offset: 0x1CF5691 VA: 0x1CF5590
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, float>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF5770 Offset: 0x1CF5871 VA: 0x1CF5770
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, UniTask>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF5960 Offset: 0x1CF5A61 VA: 0x1CF5960
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Unit>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF5B40 Offset: 0x1CF5C41 VA: 0x1CF5B40
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Vector2>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF5D30 Offset: 0x1CF5E31 VA: 0x1CF5D30
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Vector3>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF5F20 Offset: 0x1CF6021 VA: 0x1CF5F20
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Vector4>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF6120 Offset: 0x1CF6221 VA: 0x1CF6120
	|-Array.EmptyInternalEnumerator<ValueTuple<int, bool>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF6300 Offset: 0x1CF6401 VA: 0x1CF6300
	|-Array.EmptyInternalEnumerator<ValueTuple<int, Bounds>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF6510 Offset: 0x1CF6611 VA: 0x1CF6510
	|-Array.EmptyInternalEnumerator<ValueTuple<int, byte>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF66F0 Offset: 0x1CF67F1 VA: 0x1CF66F0
	|-Array.EmptyInternalEnumerator<ValueTuple<int, Color>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF68F0 Offset: 0x1CF69F1 VA: 0x1CF68F0
	|-Array.EmptyInternalEnumerator<ValueTuple<int, double>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF6AE0 Offset: 0x1CF6BE1 VA: 0x1CF6AE0
	|-Array.EmptyInternalEnumerator<ValueTuple<int, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF6CC0 Offset: 0x1CF6DC1 VA: 0x1CF6CC0
	|-Array.EmptyInternalEnumerator<ValueTuple<int, long>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF6EB0 Offset: 0x1CF6FB1 VA: 0x1CF6EB0
	|-Array.EmptyInternalEnumerator<ValueTuple<int, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF70A0 Offset: 0x1CF71A1 VA: 0x1CF70A0
	|-Array.EmptyInternalEnumerator<ValueTuple<int, Quaternion>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF72A0 Offset: 0x1CF73A1 VA: 0x1CF72A0
	|-Array.EmptyInternalEnumerator<ValueTuple<int, Rect>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF74A0 Offset: 0x1CF75A1 VA: 0x1CF74A0
	|-Array.EmptyInternalEnumerator<ValueTuple<int, float>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF7680 Offset: 0x1CF7781 VA: 0x1CF7680
	|-Array.EmptyInternalEnumerator<ValueTuple<int, Unit>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF7860 Offset: 0x1CF7961 VA: 0x1CF7860
	|-Array.EmptyInternalEnumerator<ValueTuple<int, Vector2>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF7A50 Offset: 0x1CF7B51 VA: 0x1CF7A50
	|-Array.EmptyInternalEnumerator<ValueTuple<int, Vector3>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF7C40 Offset: 0x1CF7D41 VA: 0x1CF7C40
	|-Array.EmptyInternalEnumerator<ValueTuple<int, Vector4>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF7E40 Offset: 0x1CF7F41 VA: 0x1CF7E40
	|-Array.EmptyInternalEnumerator<ValueTuple<Int32Enum, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF8020 Offset: 0x1CF8121 VA: 0x1CF8020
	|-Array.EmptyInternalEnumerator<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF8220 Offset: 0x1CF8321 VA: 0x1CF8220
	|-Array.EmptyInternalEnumerator<ValueTuple<object, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF8410 Offset: 0x1CF8511 VA: 0x1CF8410
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF8600 Offset: 0x1CF8701 VA: 0x1CF8600
	|-Array.EmptyInternalEnumerator<ValueTuple<object, float>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF87F0 Offset: 0x1CF88F1 VA: 0x1CF87F0
	|-Array.EmptyInternalEnumerator<ValueTuple<Vector3, float>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF89E0 Offset: 0x1CF8AE1 VA: 0x1CF89E0
	|-Array.EmptyInternalEnumerator<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF8BF0 Offset: 0x1CF8CF1 VA: 0x1CF8BF0
	|-Array.EmptyInternalEnumerator<ValueTuple<object, Int32Enum, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF8DE0 Offset: 0x1CF8EE1 VA: 0x1CF8DE0
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF8FE0 Offset: 0x1CF90E1 VA: 0x1CF8FE0
	|-Array.EmptyInternalEnumerator<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF91F0 Offset: 0x1CF92F1 VA: 0x1CF91F0
	|-Array.EmptyInternalEnumerator<ValueTuple<object, int, int, int>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF93F0 Offset: 0x1CF94F1 VA: 0x1CF93F0
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object, object, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF95F0 Offset: 0x1CF96F1 VA: 0x1CF95F0
	|-Array.EmptyInternalEnumerator<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF9840 Offset: 0x1CF9941 VA: 0x1CF9840
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object, object, object, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF9A50 Offset: 0x1CF9B51 VA: 0x1CF9A50
	|-Array.EmptyInternalEnumerator<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF9CB0 Offset: 0x1CF9DB1 VA: 0x1CF9CB0
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object, object, object, object, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CF9EC0 Offset: 0x1CF9FC1 VA: 0x1CF9EC0
	|-Array.EmptyInternalEnumerator<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CFA150 Offset: 0x1CFA251 VA: 0x1CFA150
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object, object, object, object, object, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CFA360 Offset: 0x1CFA461 VA: 0x1CFA360
	|-Array.EmptyInternalEnumerator<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CFA600 Offset: 0x1CFA701 VA: 0x1CFA600
	|-Array.EmptyInternalEnumerator<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CFA810 Offset: 0x1CFA911 VA: 0x1CFA810
	|-Array.EmptyInternalEnumerator<AnimatorClipInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CFA9F0 Offset: 0x1CFAAF1 VA: 0x1CFA9F0
	|-Array.EmptyInternalEnumerator<AsyncOperationHandle>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CFABF0 Offset: 0x1CFACF1 VA: 0x1CFABF0
	|-Array.EmptyInternalEnumerator<AsyncUnit>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CFADD0 Offset: 0x1CFAED1 VA: 0x1CFADD0
	|-Array.EmptyInternalEnumerator<BatchVisibility>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CFAFC0 Offset: 0x1CFB0C1 VA: 0x1CFAFC0
	|-Array.EmptyInternalEnumerator<BoneWeight>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CFB1C0 Offset: 0x1CFB2C1 VA: 0x1CFB1C0
	|-Array.EmptyInternalEnumerator<BoneWeight1>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CFB3A0 Offset: 0x1CFB4A1 VA: 0x1CFB3A0
	|-Array.EmptyInternalEnumerator<bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CFB580 Offset: 0x1CFB681 VA: 0x1CFB580
	|-Array.EmptyInternalEnumerator<Bounds>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CFB780 Offset: 0x1CFB881 VA: 0x1CFB780
	|-Array.EmptyInternalEnumerator<byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CFB960 Offset: 0x1CFBA61 VA: 0x1CFB960
	|-Array.EmptyInternalEnumerator<ByteEnum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CFBB40 Offset: 0x1CFBC41 VA: 0x1CFBB40
	|-Array.EmptyInternalEnumerator<CameraInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CFBD30 Offset: 0x1CFBE31 VA: 0x1CFBD30
	|-Array.EmptyInternalEnumerator<CancellationToken>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CFBF10 Offset: 0x1CFC011 VA: 0x1CFBF10
	|-Array.EmptyInternalEnumerator<CancellationTokenRegistration>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CFC110 Offset: 0x1CFC211 VA: 0x1CFC110
	|-Array.EmptyInternalEnumerator<char>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CFC2F0 Offset: 0x1CFC3F1 VA: 0x1CFC2F0
	|-Array.EmptyInternalEnumerator<ClusteringData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CFC4F0 Offset: 0x1CFC5F1 VA: 0x1CFC4F0
	|-Array.EmptyInternalEnumerator<ClusteringProcessorState>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CFC700 Offset: 0x1CFC801 VA: 0x1CFC700
	|-Array.EmptyInternalEnumerator<Color>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CFC8F0 Offset: 0x1CFC9F1 VA: 0x1CFC8F0
	|-Array.EmptyInternalEnumerator<Color32>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CFCAD0 Offset: 0x1CFCBD1 VA: 0x1CFCAD0
	|-Array.EmptyInternalEnumerator<Color4u8>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CFCCB0 Offset: 0x1CFCDB1 VA: 0x1CFCCB0
	|-Array.EmptyInternalEnumerator<ColorBlock>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CFCF10 Offset: 0x1CFD011 VA: 0x1CFCF10
	|-Array.EmptyInternalEnumerator<CombineInstance>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CFD1A0 Offset: 0x1CFD2A1 VA: 0x1CFD1A0
	|-Array.EmptyInternalEnumerator<ConstraintSource>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CFD390 Offset: 0x1CFD491 VA: 0x1CFD390
	|-Array.EmptyInternalEnumerator<ContactPoint>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CFD5A0 Offset: 0x1CFD6A1 VA: 0x1CFD5A0
	|-Array.EmptyInternalEnumerator<ContactPoint2D>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CFD7B0 Offset: 0x1CFD8B1 VA: 0x1CFD7B0
	|-Array.EmptyInternalEnumerator<ContourVertex>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CFD9B0 Offset: 0x1CFDAB1 VA: 0x1CFD9B0
	|-Array.EmptyInternalEnumerator<CustomAttributeNamedArgument>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CFDBB0 Offset: 0x1CFDCB1 VA: 0x1CFDBB0
	|-Array.EmptyInternalEnumerator<CustomAttributeTypedArgument>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CFDDA0 Offset: 0x1CFDEA1 VA: 0x1CFDDA0
	|-Array.EmptyInternalEnumerator<DataStoreRatingInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CFDFA0 Offset: 0x1CFE0A1 VA: 0x1CFDFA0
	|-Array.EmptyInternalEnumerator<DataStoreResult>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CFE180 Offset: 0x1CFE281 VA: 0x1CFE180
	|-Array.EmptyInternalEnumerator<DateTime>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CFE360 Offset: 0x1CFE461 VA: 0x1CFE360
	|-Array.EmptyInternalEnumerator<DateTimeOffset>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CFE550 Offset: 0x1CFE651 VA: 0x1CFE550
	|-Array.EmptyInternalEnumerator<DebugPadState>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CFE750 Offset: 0x1CFE851 VA: 0x1CFE750
	|-Array.EmptyInternalEnumerator<Decimal>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CFE940 Offset: 0x1CFEA41 VA: 0x1CFE940
	|-Array.EmptyInternalEnumerator<DeferredTiler>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CFEBE0 Offset: 0x1CFECE1 VA: 0x1CFEBE0
	|-Array.EmptyInternalEnumerator<DeviceHandle>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CFEDD0 Offset: 0x1CFEED1 VA: 0x1CFEDD0
	|-Array.EmptyInternalEnumerator<DiagnosticEvent>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CFEFE0 Offset: 0x1CFF0E1 VA: 0x1CFEFE0
	|-Array.EmptyInternalEnumerator<DictionaryEntry>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CFF1D0 Offset: 0x1CFF2D1 VA: 0x1CFF1D0
	|-Array.EmptyInternalEnumerator<DictionaryInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CFF3B0 Offset: 0x1CFF4B1 VA: 0x1CFF3B0
	|-Array.EmptyInternalEnumerator<DirectoryEntry>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CFF5B0 Offset: 0x1CFF6B1 VA: 0x1CFF5B0
	|-Array.EmptyInternalEnumerator<double>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CFF790 Offset: 0x1CFF891 VA: 0x1CFF790
	|-Array.EmptyInternalEnumerator<Ephemeron>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CFF980 Offset: 0x1CFFA81 VA: 0x1CFF980
	|-Array.EmptyInternalEnumerator<FXZ>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CFFB60 Offset: 0x1CFFC61 VA: 0x1CFFB60
	|-Array.EmptyInternalEnumerator<Finger>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CFFD70 Offset: 0x1CFFE71 VA: 0x1CFFD70
	|-Array.EmptyInternalEnumerator<Float2>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1CFFF50 Offset: 0x1D00051 VA: 0x1CFFF50
	|-Array.EmptyInternalEnumerator<Friend>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D00160 Offset: 0x1D00261 VA: 0x1D00160
	|-Array.EmptyInternalEnumerator<GCHandle>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D00340 Offset: 0x1D00441 VA: 0x1D00340
	|-Array.EmptyInternalEnumerator<GesturePoint>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D00520 Offset: 0x1D00621 VA: 0x1D00520
	|-Array.EmptyInternalEnumerator<GestureState>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D007A0 Offset: 0x1D008A1 VA: 0x1D007A0
	|-Array.EmptyInternalEnumerator<GlyphMarshallingStruct>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D009B0 Offset: 0x1D00AB1 VA: 0x1D009B0
	|-Array.EmptyInternalEnumerator<GlyphPairAdjustmentRecord>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D00BD0 Offset: 0x1D00CD1 VA: 0x1D00BD0
	|-Array.EmptyInternalEnumerator<GlyphRect>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D00DC0 Offset: 0x1D00EC1 VA: 0x1D00DC0
	|-Array.EmptyInternalEnumerator<Guid>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D00FB0 Offset: 0x1D010B1 VA: 0x1D00FB0
	|-Array.EmptyInternalEnumerator<Hand>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D011C0 Offset: 0x1D012C1 VA: 0x1D011C0
	|-Array.EmptyInternalEnumerator<HandAnalysisImageState>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D013B0 Offset: 0x1D014B1 VA: 0x1D013B0
	|-Array.EmptyInternalEnumerator<HandAnalysisSilhouetteState>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D015C0 Offset: 0x1D016C1 VA: 0x1D015C0
	|-Array.EmptyInternalEnumerator<HeaderVariantInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D017B0 Offset: 0x1D018B1 VA: 0x1D017B0
	|-Array.EmptyInternalEnumerator<HighlightState>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D019B0 Offset: 0x1D01AB1 VA: 0x1D019B0
	|-Array.EmptyInternalEnumerator<HumanBone>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D01BD0 Offset: 0x1D01CD1 VA: 0x1D01BD0
	|-Array.EmptyInternalEnumerator<short>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D01DB0 Offset: 0x1D01EB1 VA: 0x1D01DB0
	|-Array.EmptyInternalEnumerator<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D01F90 Offset: 0x1D02091 VA: 0x1D01F90
	|-Array.EmptyInternalEnumerator<Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D02170 Offset: 0x1D02271 VA: 0x1D02170
	|-Array.EmptyInternalEnumerator<long>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D02350 Offset: 0x1D02451 VA: 0x1D02350
	|-Array.EmptyInternalEnumerator<Int64Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D02530 Offset: 0x1D02631 VA: 0x1D02530
	|-Array.EmptyInternalEnumerator<IntPtr>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D02710 Offset: 0x1D02811 VA: 0x1D02710
	|-Array.EmptyInternalEnumerator<InternalCodePageDataItem>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D02900 Offset: 0x1D02A01 VA: 0x1D02900
	|-Array.EmptyInternalEnumerator<InternalEncodingDataItem>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D02AF0 Offset: 0x1D02BF1 VA: 0x1D02AF0
	|-Array.EmptyInternalEnumerator<InterpretedFrameInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D02CE0 Offset: 0x1D02DE1 VA: 0x1D02CE0
	|-Array.EmptyInternalEnumerator<IntervalTreeNode>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D02EE0 Offset: 0x1D02FE1 VA: 0x1D02EE0
	|-Array.EmptyInternalEnumerator<JobHandle>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D030D0 Offset: 0x1D031D1 VA: 0x1D030D0
	|-Array.EmptyInternalEnumerator<Keyframe>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D032E0 Offset: 0x1D033E1 VA: 0x1D032E0
	|-Array.EmptyInternalEnumerator<LOD>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D034D0 Offset: 0x1D035D1 VA: 0x1D034D0
	|-Array.EmptyInternalEnumerator<LayerMask>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D036B0 Offset: 0x1D037B1 VA: 0x1D036B0
	|-Array.EmptyInternalEnumerator<LengthLimitProperties>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D03890 Offset: 0x1D03991 VA: 0x1D03890
	|-Array.EmptyInternalEnumerator<Light2DBlendStyle>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D03AE0 Offset: 0x1D03BE1 VA: 0x1D03AE0
	|-Array.EmptyInternalEnumerator<LightDataGI>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D03D60 Offset: 0x1D03E61 VA: 0x1D03D60
	|-Array.EmptyInternalEnumerator<LocalDefinition>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D03F50 Offset: 0x1D04051 VA: 0x1D03F50
	|-Array.EmptyInternalEnumerator<MapPos>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D04130 Offset: 0x1D04231 VA: 0x1D04130
	|-Array.EmptyInternalEnumerator<MapRange>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D04320 Offset: 0x1D04421 VA: 0x1D04320
	|-Array.EmptyInternalEnumerator<MaterialReference>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D04530 Offset: 0x1D04631 VA: 0x1D04530
	|-Array.EmptyInternalEnumerator<Matrix4x4>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D04750 Offset: 0x1D04851 VA: 0x1D04750
	|-Array.EmptyInternalEnumerator<MomentProcessorState>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D04960 Offset: 0x1D04A61 VA: 0x1D04960
	|-Array.EmptyInternalEnumerator<MomentStatistic>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D04B50 Offset: 0x1D04C51 VA: 0x1D04B50
	|-Array.EmptyInternalEnumerator<Navigation>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D04D60 Offset: 0x1D04E61 VA: 0x1D04D60
	|-Array.EmptyInternalEnumerator<NetworkServiceAccountId>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D04F40 Offset: 0x1D05041 VA: 0x1D04F40
	|-Array.EmptyInternalEnumerator<NpadFullKeyState>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D05150 Offset: 0x1D05251 VA: 0x1D05150
	|-Array.EmptyInternalEnumerator<NpadHandheldState>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D05360 Offset: 0x1D05461 VA: 0x1D05360
	|-Array.EmptyInternalEnumerator<NpadJoyDualState>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D05570 Offset: 0x1D05671 VA: 0x1D05570
	|-Array.EmptyInternalEnumerator<NpadJoyLeftState>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D05780 Offset: 0x1D05881 VA: 0x1D05780
	|-Array.EmptyInternalEnumerator<NpadJoyRightState>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D05990 Offset: 0x1D05A91 VA: 0x1D05990
	|-Array.EmptyInternalEnumerator<NpadStateArrayItem>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D05BA0 Offset: 0x1D05CA1 VA: 0x1D05BA0
	|-Array.EmptyInternalEnumerator<NsUid>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D05D80 Offset: 0x1D05E81 VA: 0x1D05D80
	|-Array.EmptyInternalEnumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D05F20 Offset: 0x1D06021 VA: 0x1D05F20
	|-Array.EmptyInternalEnumerator<ObjectInitializationData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D06130 Offset: 0x1D06231 VA: 0x1D06130
	|-Array.EmptyInternalEnumerator<ParameterModifier>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D06310 Offset: 0x1D06411 VA: 0x1D06310
	|-Array.EmptyInternalEnumerator<Plane>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D06500 Offset: 0x1D06601 VA: 0x1D06500
	|-Array.EmptyInternalEnumerator<Playable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D066F0 Offset: 0x1D067F1 VA: 0x1D066F0
	|-Array.EmptyInternalEnumerator<PlayableBinding>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D068F0 Offset: 0x1D069F1 VA: 0x1D068F0
	|-Array.EmptyInternalEnumerator<PlayerLoopSystem>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D06B00 Offset: 0x1D06C01 VA: 0x1D06B00
	|-Array.EmptyInternalEnumerator<PlayerLoopSystemInternal>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D06D10 Offset: 0x1D06E11 VA: 0x1D06D10
	|-Array.EmptyInternalEnumerator<PreTile>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D06F30 Offset: 0x1D07031 VA: 0x1D06F30
	|-Array.EmptyInternalEnumerator<Profile>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D07140 Offset: 0x1D07241 VA: 0x1D07140
	|-Array.EmptyInternalEnumerator<Protrusion>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D07320 Offset: 0x1D07421 VA: 0x1D07320
	|-Array.EmptyInternalEnumerator<Quaternion>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D07510 Offset: 0x1D07611 VA: 0x1D07510
	|-Array.EmptyInternalEnumerator<RandomSeed>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D07700 Offset: 0x1D07801 VA: 0x1D07700
	|-Array.EmptyInternalEnumerator<RangePositionInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D078F0 Offset: 0x1D079F1 VA: 0x1D078F0
	|-Array.EmptyInternalEnumerator<Ranking2ChartInfoInput>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D07AD0 Offset: 0x1D07BD1 VA: 0x1D07AD0
	|-Array.EmptyInternalEnumerator<RaycastHit>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D07CF0 Offset: 0x1D07DF1 VA: 0x1D07CF0
	|-Array.EmptyInternalEnumerator<RaycastHit2D>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D07F00 Offset: 0x1D08001 VA: 0x1D07F00
	|-Array.EmptyInternalEnumerator<RaycastResult>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D08150 Offset: 0x1D08251 VA: 0x1D08150
	|-Array.EmptyInternalEnumerator<Rect>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D08340 Offset: 0x1D08441 VA: 0x1D08340
	|-Array.EmptyInternalEnumerator<RenderBuffer>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D08530 Offset: 0x1D08631 VA: 0x1D08530
	|-Array.EmptyInternalEnumerator<RenderStateBlock>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D087D0 Offset: 0x1D088D1 VA: 0x1D087D0
	|-Array.EmptyInternalEnumerator<RenderTargetHandle>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D089E0 Offset: 0x1D08AE1 VA: 0x1D089E0
	|-Array.EmptyInternalEnumerator<RenderTargetIdentifier>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D08BF0 Offset: 0x1D08CF1 VA: 0x1D08BF0
	|-Array.EmptyInternalEnumerator<RendererListHandle>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D08DD0 Offset: 0x1D08ED1 VA: 0x1D08DD0
	|-Array.EmptyInternalEnumerator<ResourceHandle>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D08FB0 Offset: 0x1D090B1 VA: 0x1D08FB0
	|-Array.EmptyInternalEnumerator<ResourceLocator>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D091A0 Offset: 0x1D092A1 VA: 0x1D091A0
	|-Array.EmptyInternalEnumerator<RichTextTagAttribute>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D093A0 Offset: 0x1D094A1 VA: 0x1D093A0
	|-Array.EmptyInternalEnumerator<RuntimeLabel>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D09590 Offset: 0x1D09691 VA: 0x1D09590
	|-Array.EmptyInternalEnumerator<sbyte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D09770 Offset: 0x1D09871 VA: 0x1D09770
	|-Array.EmptyInternalEnumerator<SerializedType>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D09970 Offset: 0x1D09A71 VA: 0x1D09970
	|-Array.EmptyInternalEnumerator<ShaderKeyword>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D09B50 Offset: 0x1D09C51 VA: 0x1D09B50
	|-Array.EmptyInternalEnumerator<ShaderTagId>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D09D30 Offset: 0x1D09E31 VA: 0x1D09D30
	|-Array.EmptyInternalEnumerator<ShadowSliceData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D09F40 Offset: 0x1D0A041 VA: 0x1D09F40
	|-Array.EmptyInternalEnumerator<Shape>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D0A140 Offset: 0x1D0A241 VA: 0x1D0A140
	|-Array.EmptyInternalEnumerator<float>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D0A320 Offset: 0x1D0A421 VA: 0x1D0A320
	|-Array.EmptyInternalEnumerator<SixAxisSensorHandle>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D0A500 Offset: 0x1D0A601 VA: 0x1D0A500
	|-Array.EmptyInternalEnumerator<SixAxisSensorState>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D0A780 Offset: 0x1D0A881 VA: 0x1D0A780
	|-Array.EmptyInternalEnumerator<SkeletonBone>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D0A990 Offset: 0x1D0AA91 VA: 0x1D0A990
	|-Array.EmptyInternalEnumerator<SortingLayer>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D0AB70 Offset: 0x1D0AC71 VA: 0x1D0AB70
	|-Array.EmptyInternalEnumerator<SphericalHarmonicsL2>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D0AE10 Offset: 0x1D0AF11 VA: 0x1D0AE10
	|-Array.EmptyInternalEnumerator<SpinLock>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D0AFF0 Offset: 0x1D0B0F1 VA: 0x1D0AFF0
	|-Array.EmptyInternalEnumerator<SpringBoneComponents>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D0B240 Offset: 0x1D0B341 VA: 0x1D0B240
	|-Array.EmptyInternalEnumerator<SpringBoneProperties>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D0B450 Offset: 0x1D0B551 VA: 0x1D0B450
	|-Array.EmptyInternalEnumerator<SpringColliderComponents>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D0B700 Offset: 0x1D0B801 VA: 0x1D0B700
	|-Array.EmptyInternalEnumerator<SpringColliderProperties>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D0B8F0 Offset: 0x1D0B9F1 VA: 0x1D0B8F0
	|-Array.EmptyInternalEnumerator<SpringForceComponent>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D0BB10 Offset: 0x1D0BC11 VA: 0x1D0BB10
	|-Array.EmptyInternalEnumerator<SpringJobElement>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D0BD20 Offset: 0x1D0BE21 VA: 0x1D0BD20
	|-Array.EmptyInternalEnumerator<SpriteState>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D0BF20 Offset: 0x1D0C021 VA: 0x1D0BF20
	|-Array.EmptyInternalEnumerator<SubMeshDescriptor>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D0C130 Offset: 0x1D0C231 VA: 0x1D0C130
	|-Array.EmptyInternalEnumerator<TMP_CharacterInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D0C340 Offset: 0x1D0C441 VA: 0x1D0C340
	|-Array.EmptyInternalEnumerator<TMP_FontWeightPair>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D0C530 Offset: 0x1D0C631 VA: 0x1D0C530
	|-Array.EmptyInternalEnumerator<TMP_LineInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D0C7B0 Offset: 0x1D0C8B1 VA: 0x1D0C7B0
	|-Array.EmptyInternalEnumerator<TMP_LinkInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D0C9C0 Offset: 0x1D0CAC1 VA: 0x1D0C9C0
	|-Array.EmptyInternalEnumerator<TMP_MeshInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D0CC10 Offset: 0x1D0CD11 VA: 0x1D0CC10
	|-Array.EmptyInternalEnumerator<TMP_PageInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D0CE10 Offset: 0x1D0CF11 VA: 0x1D0CE10
	|-Array.EmptyInternalEnumerator<TMP_WordInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D0D010 Offset: 0x1D0D111 VA: 0x1D0D010
	|-Array.EmptyInternalEnumerator<TablePair>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D0D200 Offset: 0x1D0D301 VA: 0x1D0D200
	|-Array.EmptyInternalEnumerator<TextureHandle>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D0D3E0 Offset: 0x1D0D4E1 VA: 0x1D0D3E0
	|-Array.EmptyInternalEnumerator<TimeSpan>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D0D5C0 Offset: 0x1D0D6C1 VA: 0x1D0D5C0
	|-Array.EmptyInternalEnumerator<Touch>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D0D810 Offset: 0x1D0D911 VA: 0x1D0D810
	|-Array.EmptyInternalEnumerator<TouchScreenState1>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D0DA20 Offset: 0x1D0DB21 VA: 0x1D0DA20
	|-Array.EmptyInternalEnumerator<TouchScreenState10>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D0DC30 Offset: 0x1D0DD31 VA: 0x1D0DC30
	|-Array.EmptyInternalEnumerator<TouchScreenState11>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D0DE40 Offset: 0x1D0DF41 VA: 0x1D0DE40
	|-Array.EmptyInternalEnumerator<TouchScreenState12>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D0E050 Offset: 0x1D0E151 VA: 0x1D0E050
	|-Array.EmptyInternalEnumerator<TouchScreenState13>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D0E260 Offset: 0x1D0E361 VA: 0x1D0E260
	|-Array.EmptyInternalEnumerator<TouchScreenState14>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D0E470 Offset: 0x1D0E571 VA: 0x1D0E470
	|-Array.EmptyInternalEnumerator<TouchScreenState15>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D0E680 Offset: 0x1D0E781 VA: 0x1D0E680
	|-Array.EmptyInternalEnumerator<TouchScreenState16>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D0E890 Offset: 0x1D0E991 VA: 0x1D0E890
	|-Array.EmptyInternalEnumerator<TouchScreenState2>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D0EB10 Offset: 0x1D0EC11 VA: 0x1D0EB10
	|-Array.EmptyInternalEnumerator<TouchScreenState3>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D0ED20 Offset: 0x1D0EE21 VA: 0x1D0ED20
	|-Array.EmptyInternalEnumerator<TouchScreenState4>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D0EF30 Offset: 0x1D0F031 VA: 0x1D0EF30
	|-Array.EmptyInternalEnumerator<TouchScreenState5>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D0F140 Offset: 0x1D0F241 VA: 0x1D0F140
	|-Array.EmptyInternalEnumerator<TouchScreenState6>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D0F350 Offset: 0x1D0F451 VA: 0x1D0F350
	|-Array.EmptyInternalEnumerator<TouchScreenState7>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D0F560 Offset: 0x1D0F661 VA: 0x1D0F560
	|-Array.EmptyInternalEnumerator<TouchScreenState8>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D0F770 Offset: 0x1D0F871 VA: 0x1D0F770
	|-Array.EmptyInternalEnumerator<TouchScreenState9>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D0F980 Offset: 0x1D0FA81 VA: 0x1D0F980
	|-Array.EmptyInternalEnumerator<TouchState>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D0FB90 Offset: 0x1D0FC91 VA: 0x1D0FB90
	|-Array.EmptyInternalEnumerator<TrailHand>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D0FD90 Offset: 0x1D0FE91 VA: 0x1D0FD90
	|-Array.EmptyInternalEnumerator<TrailVertex>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D0FF90 Offset: 0x1D10091 VA: 0x1D0FF90
	|-Array.EmptyInternalEnumerator<UICharInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D10180 Offset: 0x1D10281 VA: 0x1D10180
	|-Array.EmptyInternalEnumerator<UILineInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D10370 Offset: 0x1D10471 VA: 0x1D10370
	|-Array.EmptyInternalEnumerator<UIVertex>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D10610 Offset: 0x1D10711 VA: 0x1D10610
	|-Array.EmptyInternalEnumerator<ushort>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D107F0 Offset: 0x1D108F1 VA: 0x1D107F0
	|-Array.EmptyInternalEnumerator<UInt16Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D109D0 Offset: 0x1D10AD1 VA: 0x1D109D0
	|-Array.EmptyInternalEnumerator<uint>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D10BB0 Offset: 0x1D10CB1 VA: 0x1D10BB0
	|-Array.EmptyInternalEnumerator<UInt32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D10D90 Offset: 0x1D10E91 VA: 0x1D10D90
	|-Array.EmptyInternalEnumerator<ulong>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D10F70 Offset: 0x1D11071 VA: 0x1D10F70
	|-Array.EmptyInternalEnumerator<Uid>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D11160 Offset: 0x1D11261 VA: 0x1D11160
	|-Array.EmptyInternalEnumerator<UniTask>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D11340 Offset: 0x1D11441 VA: 0x1D11340
	|-Array.EmptyInternalEnumerator<Unit>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D11520 Offset: 0x1D11621 VA: 0x1D11520
	|-Array.EmptyInternalEnumerator<UnitEnum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D11700 Offset: 0x1D11801 VA: 0x1D11700
	|-Array.EmptyInternalEnumerator<UserWord>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D118F0 Offset: 0x1D119F1 VA: 0x1D118F0
	|-Array.EmptyInternalEnumerator<Vector2>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D11AD0 Offset: 0x1D11BD1 VA: 0x1D11AD0
	|-Array.EmptyInternalEnumerator<Vector2Int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D11CB0 Offset: 0x1D11DB1 VA: 0x1D11CB0
	|-Array.EmptyInternalEnumerator<Vector3>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D11EA0 Offset: 0x1D11FA1 VA: 0x1D11EA0
	|-Array.EmptyInternalEnumerator<Vector4>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D12090 Offset: 0x1D12191 VA: 0x1D12090
	|-Array.EmptyInternalEnumerator<VertexAttributeDescriptor>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D12280 Offset: 0x1D12381 VA: 0x1D12280
	|-Array.EmptyInternalEnumerator<VibrationDeviceHandle>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D12460 Offset: 0x1D12561 VA: 0x1D12460
	|-Array.EmptyInternalEnumerator<VibrationDeviceInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D12640 Offset: 0x1D12741 VA: 0x1D12640
	|-Array.EmptyInternalEnumerator<VibrationValue>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D12830 Offset: 0x1D12931 VA: 0x1D12830
	|-Array.EmptyInternalEnumerator<VisibleLight>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D12AD0 Offset: 0x1D12BD1 VA: 0x1D12AD0
	|-Array.EmptyInternalEnumerator<WordWrapState>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D12CE0 Offset: 0x1D12DE1 VA: 0x1D12CE0
	|-Array.EmptyInternalEnumerator<X509ChainStatus>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D12ED0 Offset: 0x1D12FD1 VA: 0x1D12ED0
	|-Array.EmptyInternalEnumerator<XPathNode>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D130D0 Offset: 0x1D131D1 VA: 0x1D130D0
	|-Array.EmptyInternalEnumerator<XPathNodeRef>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D132C0 Offset: 0x1D133C1 VA: 0x1D132C0
	|-Array.EmptyInternalEnumerator<XRView>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D134D0 Offset: 0x1D135D1 VA: 0x1D134D0
	|-Array.EmptyInternalEnumerator<float3>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D136C0 Offset: 0x1D137C1 VA: 0x1D136C0
	|-Array.EmptyInternalEnumerator<float4x4>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D138E0 Offset: 0x1D139E1 VA: 0x1D138E0
	|-Array.EmptyInternalEnumerator<jvalue>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D13AC0 Offset: 0x1D13BC1 VA: 0x1D13AC0
	|-Array.EmptyInternalEnumerator<uint4>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D13CB0 Offset: 0x1D13DB1 VA: 0x1D13CB0
	|-Array.EmptyInternalEnumerator<AICrossfire.PositionTable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D13EA0 Offset: 0x1D13FA1 VA: 0x1D13EA0
	|-Array.EmptyInternalEnumerator<AIEnum.SkillRangeEnemyData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D14090 Offset: 0x1D14191 VA: 0x1D14090
	|-Array.EmptyInternalEnumerator<AIOrder.UnitPriority>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D14270 Offset: 0x1D14371 VA: 0x1D14270
	|-Array.EmptyInternalEnumerator<AmiiboSequence.GainItemData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D14460 Offset: 0x1D14561 VA: 0x1D14460
	|-Array.EmptyInternalEnumerator<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D14670 Offset: 0x1D14771 VA: 0x1D14670
	|-Array.EmptyInternalEnumerator<ArenaOrderSequence.GodInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D14860 Offset: 0x1D14961 VA: 0x1D14860
	|-Array.EmptyInternalEnumerator<BattleInfo.SupportData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D14A50 Offset: 0x1D14B51 VA: 0x1D14A50
	|-Array.EmptyInternalEnumerator<BeforeRenderHelper.OrderBlock>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D14C40 Offset: 0x1D14D41 VA: 0x1D14C40
	|-Array.EmptyInternalEnumerator<Camera.RenderRequest>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D14E40 Offset: 0x1D14F41 VA: 0x1D14E40
	|-Array.EmptyInternalEnumerator<CameraState.CustomBlendable>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D15030 Offset: 0x1D15131 VA: 0x1D15030
	|-Array.EmptyInternalEnumerator<CinemachineBlendListCamera.Instruction>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D15230 Offset: 0x1D15331 VA: 0x1D15230
	|-Array.EmptyInternalEnumerator<CinemachineBlenderSettings.CustomBlend>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D15430 Offset: 0x1D15531 VA: 0x1D15430
	|-Array.EmptyInternalEnumerator<CinemachineClearShot.Pair>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D15610 Offset: 0x1D15711 VA: 0x1D15610
	|-Array.EmptyInternalEnumerator<CinemachineFreeLook.Orbit>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D157F0 Offset: 0x1D158F1 VA: 0x1D157F0
	|-Array.EmptyInternalEnumerator<CinemachinePath.Waypoint>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D15A00 Offset: 0x1D15B01 VA: 0x1D15A00
	|-Array.EmptyInternalEnumerator<CinemachineSmoothPath.Waypoint>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D15BF0 Offset: 0x1D15CF1 VA: 0x1D15BF0
	|-Array.EmptyInternalEnumerator<CinemachineStateDrivenCamera.HashPair>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D15DD0 Offset: 0x1D15ED1 VA: 0x1D15DD0
	|-Array.EmptyInternalEnumerator<CinemachineStateDrivenCamera.Instruction>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D15FD0 Offset: 0x1D160D1 VA: 0x1D15FD0
	|-Array.EmptyInternalEnumerator<CinemachineStateDrivenCamera.ParentHash>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D161B0 Offset: 0x1D162B1 VA: 0x1D161B0
	|-Array.EmptyInternalEnumerator<CinemachineTargetGroup.Target>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D163A0 Offset: 0x1D164A1 VA: 0x1D163A0
	|-Array.EmptyInternalEnumerator<CodePointIndexer.TableRange>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D165A0 Offset: 0x1D166A1 VA: 0x1D165A0
	|-Array.EmptyInternalEnumerator<ContentCatalogData.Bucket>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D16790 Offset: 0x1D16891 VA: 0x1D16790
	|-Array.EmptyInternalEnumerator<CookieTokenizer.RecognizedAttribute>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D16980 Offset: 0x1D16A81 VA: 0x1D16980
	|-Array.EmptyInternalEnumerator<DeferredLights.DrawCall>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D16B90 Offset: 0x1D16C91 VA: 0x1D16B90
	|-Array.EmptyInternalEnumerator<DeferredShaderData.ComputeBufferInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D16D70 Offset: 0x1D16E71 VA: 0x1D16D70
	|-Array.EmptyInternalEnumerator<DeferredTiler.PrePunctualLight>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D16F70 Offset: 0x1D17071 VA: 0x1D16F70
	|-Array.EmptyInternalEnumerator<DelayedActionManager.DelegateInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D17170 Offset: 0x1D17271 VA: 0x1D17170
	|-Array.EmptyInternalEnumerator<Detail.AsyncResultInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D17380 Offset: 0x1D17481 VA: 0x1D17380
	|-Array.EmptyInternalEnumerator<Detail.CppArray>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D17570 Offset: 0x1D17671 VA: 0x1D17570
	|-Array.EmptyInternalEnumerator<Detail.NotificationEventInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D17780 Offset: 0x1D17881 VA: 0x1D17780
	|-Array.EmptyInternalEnumerator<DisposUnit.Item>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D17970 Offset: 0x1D17A71 VA: 0x1D17970
	|-Array.EmptyInternalEnumerator<DragonRidePresetParamData.CourseData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D17B60 Offset: 0x1D17C61 VA: 0x1D17B60
	|-Array.EmptyInternalEnumerator<DragonRideTargetGroup.ChainParam>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D17D50 Offset: 0x1D17E51 VA: 0x1D17D50
	|-Array.EmptyInternalEnumerator<DynamicMesh.State>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D17F30 Offset: 0x1D18031 VA: 0x1D17F30
	|-Array.EmptyInternalEnumerator<FXZEx.HitPoint>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D18140 Offset: 0x1D18241 VA: 0x1D18140
	|-Array.EmptyInternalEnumerator<FishingRadicalParamData.RadicalParam>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D18330 Offset: 0x1D18431 VA: 0x1D18330
	|-Array.EmptyInternalEnumerator<GameVariable.Value>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D18520 Offset: 0x1D18621 VA: 0x1D18520
	|-Array.EmptyInternalEnumerator<GmapPathAdjuster.TargetModel>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D18720 Offset: 0x1D18821 VA: 0x1D18720
	|-Array.EmptyInternalEnumerator<GmapSpotAdjuster.TargetModel>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D18920 Offset: 0x1D18A21 VA: 0x1D18920
	|-Array.EmptyInternalEnumerator<GrounderQuadruped.Foot>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D18B30 Offset: 0x1D18C31 VA: 0x1D18B30
	|-Array.EmptyInternalEnumerator<Hashtable.bucket>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D18D30 Offset: 0x1D18E31 VA: 0x1D18D30
	|-Array.EmptyInternalEnumerator<HeadingTracker.Item>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D18F30 Offset: 0x1D19031 VA: 0x1D18F30
	|-Array.EmptyInternalEnumerator<HubAccessoryRoomCamera.BackgroundSettings>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D19140 Offset: 0x1D19241 VA: 0x1D19140
	|-Array.EmptyInternalEnumerator<HubFastTravel.Location>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D19340 Offset: 0x1D19441 VA: 0x1D19340
	|-Array.EmptyInternalEnumerator<HubLensFlare.Flare>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D19550 Offset: 0x1D19651 VA: 0x1D19550
	|-Array.EmptyInternalEnumerator<HubLookAtController.LookAtIKParam>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D19740 Offset: 0x1D19841 VA: 0x1D19740
	|-Array.EmptyInternalEnumerator<HubMaterialArray.MaterialInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D19930 Offset: 0x1D19A31 VA: 0x1D19930
	|-Array.EmptyInternalEnumerator<IKSolverLimb.AxisDirection>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D19B40 Offset: 0x1D19C41 VA: 0x1D19B40
	|-Array.EmptyInternalEnumerator<InventoryPoolItemMenuContent.KindBgNameClass>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D19D30 Offset: 0x1D19E31 VA: 0x1D19D30
	|-Array.EmptyInternalEnumerator<LightUtility.ParametricLightMeshVertex>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D19F40 Offset: 0x1D1A041 VA: 0x1D19F40
	|-Array.EmptyInternalEnumerator<LightUtility.SpriteLightMeshVertex>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D1A150 Offset: 0x1D1A251 VA: 0x1D1A150
	|-Array.EmptyInternalEnumerator<Map.Pos>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D1A330 Offset: 0x1D1A431 VA: 0x1D1A330
	|-Array.EmptyInternalEnumerator<MapGodExp.KindDesc>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D1A520 Offset: 0x1D1A621 VA: 0x1D1A520
	|-Array.EmptyInternalEnumerator<MapHistory.Command>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D1A700 Offset: 0x1D1A801 VA: 0x1D1A700
	|-Array.EmptyInternalEnumerator<MapImage.BackupTerrain>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D1A8F0 Offset: 0x1D1A9F1 VA: 0x1D1A8F0
	|-Array.EmptyInternalEnumerator<MapImageRange.Pos>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D1AAD0 Offset: 0x1D1ABD1 VA: 0x1D1AAD0
	|-Array.EmptyInternalEnumerator<MapKillBonus.KillBonus>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D1ACB0 Offset: 0x1D1ADB1 VA: 0x1D1ACB0
	|-Array.EmptyInternalEnumerator<MapKillBonus.KilledBonus>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D1AE90 Offset: 0x1D1AF91 VA: 0x1D1AE90
	|-Array.EmptyInternalEnumerator<MapMind.Record>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D1B0E0 Offset: 0x1D1B1E1 VA: 0x1D1B0E0
	|-Array.EmptyInternalEnumerator<MapMind.Target>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D1B2E0 Offset: 0x1D1B3E1 VA: 0x1D1B2E0
	|-Array.EmptyInternalEnumerator<MapPanelDebug.Entity>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D1B4E0 Offset: 0x1D1B5E1 VA: 0x1D1B4E0
	|-Array.EmptyInternalEnumerator<NexRanking.Data>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D1B6C0 Offset: 0x1D1B7C1 VA: 0x1D1B6C0
	|-Array.EmptyInternalEnumerator<NexVersus.RatingData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D1B8B0 Offset: 0x1D1B9B1 VA: 0x1D1B8B0
	|-Array.EmptyInternalEnumerator<NoiseSettings.TransformNoiseParams>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D1BAC0 Offset: 0x1D1BBC1 VA: 0x1D1BAC0
	|-Array.EmptyInternalEnumerator<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D1BCB0 Offset: 0x1D1BDB1 VA: 0x1D1BCB0
	|-Array.EmptyInternalEnumerator<ParameterizedStrings.FormatParam>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D1BEA0 Offset: 0x1D1BFA1 VA: 0x1D1BEA0
	|-Array.EmptyInternalEnumerator<ParticleSystem.Particle>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D1C0B0 Offset: 0x1D1C1B1 VA: 0x1D1C0B0
	|-Array.EmptyInternalEnumerator<ProfileCard.Achievement>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D1C290 Offset: 0x1D1C391 VA: 0x1D1C290
	|-Array.EmptyInternalEnumerator<ProfileCard.SortieCount>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D1C490 Offset: 0x1D1C591 VA: 0x1D1C490
	|-Array.EmptyInternalEnumerator<QualitySettingsStack.Settings>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D1C6A0 Offset: 0x1D1C7A1 VA: 0x1D1C6A0
	|-Array.EmptyInternalEnumerator<RangeData.Offset>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D1C880 Offset: 0x1D1C981 VA: 0x1D1C880
	|-Array.EmptyInternalEnumerator<RegexCharClass.LowerCaseMapping>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D1CA70 Offset: 0x1D1CB71 VA: 0x1D1CA70
	|-Array.EmptyInternalEnumerator<Relay.ChooseAwardeeData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D1CC70 Offset: 0x1D1CD71 VA: 0x1D1CC70
	|-Array.EmptyInternalEnumerator<RelayAwardData.Info>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D1CE60 Offset: 0x1D1CF61 VA: 0x1D1CE60
	|-Array.EmptyInternalEnumerator<RenderGraph.CompiledPassInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D1D0B0 Offset: 0x1D1D1B1 VA: 0x1D1D0B0
	|-Array.EmptyInternalEnumerator<RenderGraph.CompiledResourceInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D1D2B0 Offset: 0x1D1D3B1 VA: 0x1D1D2B0
	|-Array.EmptyInternalEnumerator<RenderGraphDebugData.PassDebugData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D1D4B0 Offset: 0x1D1D5B1 VA: 0x1D1D4B0
	|-Array.EmptyInternalEnumerator<RenderGraphDebugData.ResourceDebugData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D1D6C0 Offset: 0x1D1D7C1 VA: 0x1D1D6C0
	|-Array.EmptyInternalEnumerator<RenderGraphResourceRegistry.RendererListResource>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D1D8D0 Offset: 0x1D1D9D1 VA: 0x1D1D8D0
	|-Array.EmptyInternalEnumerator<RingCleaningUnitSelectMenu.GodParam>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D1DAC0 Offset: 0x1D1DBC1 VA: 0x1D1DAC0
	|-Array.EmptyInternalEnumerator<SampleWave.Data>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D1DCB0 Offset: 0x1D1DDB1 VA: 0x1D1DCB0
	|-Array.EmptyInternalEnumerator<SampleWave.Temp>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D1DE90 Offset: 0x1D1DF91 VA: 0x1D1DE90
	|-Array.EmptyInternalEnumerator<SendMouseEvents.HitInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D1E080 Offset: 0x1D1E181 VA: 0x1D1E080
	|-Array.EmptyInternalEnumerator<SequenceNode.SequenceConstructPosContext>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D1E290 Offset: 0x1D1E391 VA: 0x1D1E290
	|-Array.EmptyInternalEnumerator<ShaderInput.LightData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D1E4E0 Offset: 0x1D1E5E1 VA: 0x1D1E4E0
	|-Array.EmptyInternalEnumerator<ShaderInput.ShadowData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D1E730 Offset: 0x1D1E831 VA: 0x1D1E730
	|-Array.EmptyInternalEnumerator<ShadowUtility.Edge>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D1E940 Offset: 0x1D1EA41 VA: 0x1D1E940
	|-Array.EmptyInternalEnumerator<SimpleAnimationPlayable.QueuedState>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D1EB30 Offset: 0x1D1EC31 VA: 0x1D1EB30
	|-Array.EmptyInternalEnumerator<SkillArray.Entity>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D1ED10 Offset: 0x1D1EE11 VA: 0x1D1ED10
	|-Array.EmptyInternalEnumerator<Socket.WSABUF>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D1EF00 Offset: 0x1D1F001 VA: 0x1D1EF00
	|-Array.EmptyInternalEnumerator<Stream.Info>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D1F0F0 Offset: 0x1D1F1F1 VA: 0x1D1F0F0
	|-Array.EmptyInternalEnumerator<TMP_Text.UnicodeChar>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D1F2E0 Offset: 0x1D1F3E1 VA: 0x1D1F2E0
	|-Array.EmptyInternalEnumerator<TexturePacker_JsonArray.Frame>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D1F500 Offset: 0x1D1F601 VA: 0x1D1F500
	|-Array.EmptyInternalEnumerator<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D1F700 Offset: 0x1D1F801 VA: 0x1D1F700
	|-Array.EmptyInternalEnumerator<UnitySynchronizationContext.WorkRequest>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D1F900 Offset: 0x1D1FA01 VA: 0x1D1F900
	|-Array.EmptyInternalEnumerator<XmlNamespaceManager.NamespaceDeclaration>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D1FB00 Offset: 0x1D1FC01 VA: 0x1D1FB00
	|-Array.EmptyInternalEnumerator<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D1FCF0 Offset: 0x1D1FDF1 VA: 0x1D1FCF0
	|-Array.EmptyInternalEnumerator<XmlTextReaderImpl.ParsingState>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D1FF90 Offset: 0x1D20091 VA: 0x1D1FF90
	|-Array.EmptyInternalEnumerator<AIThink.EnchantThink.Desc>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D20180 Offset: 0x1D20281 VA: 0x1D20180
	|-Array.EmptyInternalEnumerator<AIThink.EnchantThink.ItemInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D20360 Offset: 0x1D20461 VA: 0x1D20360
	|-Array.EmptyInternalEnumerator<AIThink.EnchantThink.SurroundingInfo>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D20540 Offset: 0x1D20641 VA: 0x1D20540
	|-Array.EmptyInternalEnumerator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D20730 Offset: 0x1D20831 VA: 0x1D20730
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStoreChangeMetaParamInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D20940 Offset: 0x1D20A41 VA: 0x1D20940
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStoreDeleteParamInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D20B30 Offset: 0x1D20C31 VA: 0x1D20B30
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStoreGetMetaParamInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D20D40 Offset: 0x1D20E41 VA: 0x1D20D40
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStoreMetaInfoInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D20F50 Offset: 0x1D21051 VA: 0x1D20F50
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStorePasswordInfoInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D21150 Offset: 0x1D21251 VA: 0x1D21150
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStorePersistenceInfoInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D21350 Offset: 0x1D21451 VA: 0x1D21350
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStorePreparePostParamInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D21560 Offset: 0x1D21661 VA: 0x1D21560
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStoreRateObjectParamInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D21750 Offset: 0x1D21851 VA: 0x1D21750
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStoreRatingInitParamInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D21950 Offset: 0x1D21A51 VA: 0x1D21950
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStoreRatingTargetInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D21B40 Offset: 0x1D21C41 VA: 0x1D21B40
	|-Array.EmptyInternalEnumerator<Detail.Ranking.RankingCachedResultInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D21D50 Offset: 0x1D21E51 VA: 0x1D21D50
	|-Array.EmptyInternalEnumerator<Detail.Ranking.RankingOrderParamInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D21F40 Offset: 0x1D22041 VA: 0x1D21F40
	|-Array.EmptyInternalEnumerator<Detail.Ranking.RankingRankDataInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D22160 Offset: 0x1D22261 VA: 0x1D22160
	|-Array.EmptyInternalEnumerator<Detail.Ranking2.Ranking2ChartInfoInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D223E0 Offset: 0x1D224E1 VA: 0x1D223E0
	|-Array.EmptyInternalEnumerator<Detail.Ranking2.Ranking2RankDataInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D22600 Offset: 0x1D22701 VA: 0x1D22600
	|-Array.EmptyInternalEnumerator<Detail.Ranking2.Ranking2ScoreDataInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D227F0 Offset: 0x1D228F1 VA: 0x1D227F0
	|-Array.EmptyInternalEnumerator<Detail.Screening.ScreeningContextInfoInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D229F0 Offset: 0x1D22AF1 VA: 0x1D229F0
	|-Array.EmptyInternalEnumerator<Detail.Subscriber.SubscriberContentInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D22C40 Offset: 0x1D22D41 VA: 0x1D22C40
	|-Array.EmptyInternalEnumerator<Detail.Subscriber.SubscriberGetContentParamInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D22E40 Offset: 0x1D22F41 VA: 0x1D22E40
	|-Array.EmptyInternalEnumerator<Detail.Subscriber.SubscriberUserStatusInfoInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D23050 Offset: 0x1D23151 VA: 0x1D23050
	|-Array.EmptyInternalEnumerator<Detail.Subscriber.SubscriberUserStatusParamInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D23250 Offset: 0x1D23351 VA: 0x1D23250
	|-Array.EmptyInternalEnumerator<Detail.Utility.IntegerSettings>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D23430 Offset: 0x1D23531 VA: 0x1D23430
	|-Array.EmptyInternalEnumerator<Detail.Utility.UniqueIdInfoInt>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D23620 Offset: 0x1D23721 VA: 0x1D23620
	|-Array.EmptyInternalEnumerator<FacetsChecker.FacetsCompiler.Map>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D23810 Offset: 0x1D23911 VA: 0x1D23810
	|-Array.EmptyInternalEnumerator<MapHistory.ReplayAppearanceMap.Appearance>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D23A10 Offset: 0x1D23B11 VA: 0x1D23A10
	|-Array.EmptyInternalEnumerator<MapHistory.ReplayAppearanceMap.Leaving>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D23BF0 Offset: 0x1D23CF1 VA: 0x1D23BF0
	|-Array.EmptyInternalEnumerator<MapHistory.ReplayUnitMap.Data>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D23DD0 Offset: 0x1D23ED1 VA: 0x1D23DD0
	|-Array.EmptyInternalEnumerator<MapHistory.Rewind.LatestInspectorData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D23FC0 Offset: 0x1D240C1 VA: 0x1D23FC0
	|-Array.EmptyInternalEnumerator<MapHistory.Rewind.WorkTerrainData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D241B0 Offset: 0x1D242B1 VA: 0x1D241B0
	|-Array.EmptyInternalEnumerator<MapHistory.RewindUnitMap.Data>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D243C0 Offset: 0x1D244C1 VA: 0x1D243C0
	|-Array.EmptyInternalEnumerator<MapKillBonus.Work.Pos>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D245A0 Offset: 0x1D246A1 VA: 0x1D245A0
	|-Array.EmptyInternalEnumerator<MapSkill.AroundCalculator.Result>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D24790 Offset: 0x1D24891 VA: 0x1D24790
	|-Array.EmptyInternalEnumerator<Nex.ApiCallChecker.Guideline>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D24970 Offset: 0x1D24A71 VA: 0x1D24970
	|-Array.EmptyInternalEnumerator<Ngc.MaskTextSequenceBase.Data>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D24B70 Offset: 0x1D24C71 VA: 0x1D24B70
	|-Array.EmptyInternalEnumerator<TargetPositionCache.CacheCurve.Item>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D24D80 Offset: 0x1D24E81 VA: 0x1D24D80
	|-Array.EmptyInternalEnumerator<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1D24F90 Offset: 0x1D25091 VA: 0x1D24F90
	|-Array.EmptyInternalEnumerator<TerrainUtility.TerrainMap.TileCoord>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x263E5E0 Offset: 0x263E6E1 VA: 0x263E5E0
	|-Array.EmptyInternalEnumerator<ArraySegment<byte>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x263E7E0 Offset: 0x263E8E1 VA: 0x263E7E0
	|-Array.EmptyInternalEnumerator<AsyncOperationHandle<object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x263E9C0 Offset: 0x263EAC1 VA: 0x263E9C0
	|-Array.EmptyInternalEnumerator<MapDeployTemplate.Queue.Data<object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x263EBB0 Offset: 0x263ECB1 VA: 0x263EBB0
	|-Array.EmptyInternalEnumerator<Nex.DataStore.ParamPool.Data<object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x263EDA0 Offset: 0x263EEA1 VA: 0x263EDA0
	|-Array.EmptyInternalEnumerator<Nex.Screening.ParamPool.Data<object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x263EFA0 Offset: 0x263F0A1 VA: 0x263EFA0
	|-Array.EmptyInternalEnumerator<IntervalTree.Entry<object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x263F1A0 Offset: 0x263F2A1 VA: 0x263F1A0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<ValueTuple<object, int>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x263F3A0 Offset: 0x263F4A1 VA: 0x263F3A0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<byte, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x263F5A0 Offset: 0x263F6A1 VA: 0x263F5A0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<CancellationToken, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x263F7A0 Offset: 0x263F8A1 VA: 0x263F7A0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<char, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x263F9A0 Offset: 0x263FAA1 VA: 0x263F9A0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Guid, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x263FB90 Offset: 0x263FC91 VA: 0x263FB90
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, bool>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x263FD80 Offset: 0x263FE81 VA: 0x263FD80
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, byte>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x263FF70 Offset: 0x2640071 VA: 0x263FF70
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, char>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2640190 Offset: 0x2640291 VA: 0x2640190
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, DiagnosticEvent>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2640380 Offset: 0x2640481 VA: 0x2640380
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2640570 Offset: 0x2640671 VA: 0x2640570
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, Int32Enum>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2640770 Offset: 0x2640871 VA: 0x2640770
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, long>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2640970 Offset: 0x2640A71 VA: 0x2640970
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, MapPos>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2640B70 Offset: 0x2640C71 VA: 0x2640B70
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2640D60 Offset: 0x2640E61 VA: 0x2640D60
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, uint>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2640F50 Offset: 0x2641051 VA: 0x2640F50
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, AIThink.EnchantThink.SurroundingInfo>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2641140 Offset: 0x2641241 VA: 0x2641140
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, bool>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2641330 Offset: 0x2641431 VA: 0x2641330
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2641520 Offset: 0x2641621 VA: 0x2641520
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, Int32Enum>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2641720 Offset: 0x2641821 VA: 0x2641720
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2641920 Offset: 0x2641A21 VA: 0x2641920
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<long, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2641B20 Offset: 0x2641C21 VA: 0x2641B20
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<MapPos, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2641D30 Offset: 0x2641E31 VA: 0x2641D30
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, AsyncOperationHandle<object>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2641F40 Offset: 0x2642041 VA: 0x2641F40
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, AsyncOperationHandle>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2642140 Offset: 0x2642241 VA: 0x2642140
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, bool>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2642340 Offset: 0x2642441 VA: 0x2642340
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, byte>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2642540 Offset: 0x2642641 VA: 0x2642540
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2642740 Offset: 0x2642841 VA: 0x2642740
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Int32Enum>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2642940 Offset: 0x2642A41 VA: 0x2642940
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, IntPtr>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2642B40 Offset: 0x2642C41 VA: 0x2642B40
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2642D40 Offset: 0x2642E41 VA: 0x2642D40
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Playable>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2642F40 Offset: 0x2643041 VA: 0x2642F40
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, ResourceLocator>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2643140 Offset: 0x2643241 VA: 0x2643140
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, float>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2643340 Offset: 0x2643441 VA: 0x2643340
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, ushort>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2643540 Offset: 0x2643641 VA: 0x2643540
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, GameVariable.Value>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2643750 Offset: 0x2643851 VA: 0x2643750
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<sbyte, DataStoreRatingInfo>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2643950 Offset: 0x2643A51 VA: 0x2643950
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<sbyte, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2643B40 Offset: 0x2643C41 VA: 0x2643B40
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<ushort, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2643D30 Offset: 0x2643E31 VA: 0x2643D30
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<uint, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2643F30 Offset: 0x2644031 VA: 0x2643F30
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<uint, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2644140 Offset: 0x2644241 VA: 0x2644140
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<ulong, Friend>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2644340 Offset: 0x2644441 VA: 0x2644340
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<ulong, Int32Enum>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2644540 Offset: 0x2644641 VA: 0x2644540
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<ulong, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2644740 Offset: 0x2644841 VA: 0x2644740
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Vector3, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2644950 Offset: 0x2644A51 VA: 0x2644950
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<XPathNodeRef, XPathNodeRef>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2644B50 Offset: 0x2644C51 VA: 0x2644B50
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<TerrainUtility.TerrainMap.TileCoord, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2644D40 Offset: 0x2644E41 VA: 0x2644D40
	|-Array.EmptyInternalEnumerator<PriorityQueue.IndexedItem<object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2644F40 Offset: 0x2645041 VA: 0x2644F40
	|-Array.EmptyInternalEnumerator<KeyValuePair<ValueTuple<object, int>, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2645130 Offset: 0x2645231 VA: 0x2645130
	|-Array.EmptyInternalEnumerator<KeyValuePair<byte, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2645320 Offset: 0x2645421 VA: 0x2645320
	|-Array.EmptyInternalEnumerator<KeyValuePair<CancellationToken, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2645510 Offset: 0x2645611 VA: 0x2645510
	|-Array.EmptyInternalEnumerator<KeyValuePair<char, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2645700 Offset: 0x2645801 VA: 0x2645700
	|-Array.EmptyInternalEnumerator<KeyValuePair<DateTime, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2645900 Offset: 0x2645A01 VA: 0x2645900
	|-Array.EmptyInternalEnumerator<KeyValuePair<Guid, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2645AE0 Offset: 0x2645BE1 VA: 0x2645AE0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, bool>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2645CC0 Offset: 0x2645DC1 VA: 0x2645CC0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, byte>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2645EA0 Offset: 0x2645FA1 VA: 0x2645EA0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, char>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26460B0 Offset: 0x26461B1 VA: 0x26460B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, DiagnosticEvent>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2646290 Offset: 0x2646391 VA: 0x2646290
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2646470 Offset: 0x2646571 VA: 0x2646470
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, Int32Enum>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2646660 Offset: 0x2646761 VA: 0x2646660
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, long>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2646850 Offset: 0x2646951 VA: 0x2646850
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, MapPos>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2646A40 Offset: 0x2646B41 VA: 0x2646A40
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2646C20 Offset: 0x2646D21 VA: 0x2646C20
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, uint>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2646E00 Offset: 0x2646F01 VA: 0x2646E00
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, AIThink.EnchantThink.SurroundingInfo>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2646FE0 Offset: 0x26470E1 VA: 0x2646FE0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, bool>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26471C0 Offset: 0x26472C1 VA: 0x26471C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26473A0 Offset: 0x26474A1 VA: 0x26473A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, Int32Enum>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2647590 Offset: 0x2647691 VA: 0x2647590
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2647780 Offset: 0x2647881 VA: 0x2647780
	|-Array.EmptyInternalEnumerator<KeyValuePair<long, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2647970 Offset: 0x2647A71 VA: 0x2647970
	|-Array.EmptyInternalEnumerator<KeyValuePair<MapPos, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2647B70 Offset: 0x2647C71 VA: 0x2647B70
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, AsyncOperationHandle<object>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2647D70 Offset: 0x2647E71 VA: 0x2647D70
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, ValueTuple<int, DateTime, object>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2647F70 Offset: 0x2648071 VA: 0x2647F70
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, AsyncOperationHandle>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2648160 Offset: 0x2648261 VA: 0x2648160
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, bool>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2648350 Offset: 0x2648451 VA: 0x2648350
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, byte>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2648540 Offset: 0x2648641 VA: 0x2648540
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2648730 Offset: 0x2648831 VA: 0x2648730
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Int32Enum>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2648920 Offset: 0x2648A21 VA: 0x2648920
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, IntPtr>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2648B10 Offset: 0x2648C11 VA: 0x2648B10
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2648D10 Offset: 0x2648E11 VA: 0x2648D10
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Playable>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2648F10 Offset: 0x2649011 VA: 0x2648F10
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, ResourceLocator>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2649100 Offset: 0x2649201 VA: 0x2649100
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, float>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26492F0 Offset: 0x26493F1 VA: 0x26492F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, ushort>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26494F0 Offset: 0x26495F1 VA: 0x26494F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, GameVariable.Value>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26496F0 Offset: 0x26497F1 VA: 0x26496F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<sbyte, DataStoreRatingInfo>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26498E0 Offset: 0x26499E1 VA: 0x26498E0
	|-Array.EmptyInternalEnumerator<KeyValuePair<sbyte, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2649AC0 Offset: 0x2649BC1 VA: 0x2649AC0
	|-Array.EmptyInternalEnumerator<KeyValuePair<ushort, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2649CA0 Offset: 0x2649DA1 VA: 0x2649CA0
	|-Array.EmptyInternalEnumerator<KeyValuePair<uint, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2649E90 Offset: 0x2649F91 VA: 0x2649E90
	|-Array.EmptyInternalEnumerator<KeyValuePair<uint, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x264A0A0 Offset: 0x264A1A1 VA: 0x264A0A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<ulong, Friend>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x264A290 Offset: 0x264A391 VA: 0x264A290
	|-Array.EmptyInternalEnumerator<KeyValuePair<ulong, Int32Enum>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x264A480 Offset: 0x264A581 VA: 0x264A480
	|-Array.EmptyInternalEnumerator<KeyValuePair<ulong, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x264A670 Offset: 0x264A771 VA: 0x264A670
	|-Array.EmptyInternalEnumerator<KeyValuePair<Vector3, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x264A870 Offset: 0x264A971 VA: 0x264A870
	|-Array.EmptyInternalEnumerator<KeyValuePair<XPathNodeRef, XPathNodeRef>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x264AA60 Offset: 0x264AB61 VA: 0x264AA60
	|-Array.EmptyInternalEnumerator<KeyValuePair<TerrainUtility.TerrainMap.TileCoord, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x264AC50 Offset: 0x264AD51 VA: 0x264AC50
	|-Array.EmptyInternalEnumerator<NativeArray<PreTile>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x264AE50 Offset: 0x264AF51 VA: 0x264AE50
	|-Array.EmptyInternalEnumerator<CommonBattleSequence.Reliance<object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x264B040 Offset: 0x264B141 VA: 0x264B040
	|-Array.EmptyInternalEnumerator<RenderGraphResourcePool.ResourceLogInfo<object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x264B240 Offset: 0x264B341 VA: 0x264B240
	|-Array.EmptyInternalEnumerator<HashSet.Slot<ValueTuple<object, int>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x264B440 Offset: 0x264B541 VA: 0x264B440
	|-Array.EmptyInternalEnumerator<HashSet.Slot<AsyncOperationHandle>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x264B630 Offset: 0x264B731 VA: 0x264B630
	|-Array.EmptyInternalEnumerator<HashSet.Slot<int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x264B820 Offset: 0x264B921 VA: 0x264B820
	|-Array.EmptyInternalEnumerator<HashSet.Slot<Int32Enum>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x264BA10 Offset: 0x264BB11 VA: 0x264BA10
	|-Array.EmptyInternalEnumerator<Set.Slot<Int32Enum>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x264BC00 Offset: 0x264BD01 VA: 0x264BC00
	|-Array.EmptyInternalEnumerator<HashSet.Slot<MapPos>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x264BDF0 Offset: 0x264BEF1 VA: 0x264BDF0
	|-Array.EmptyInternalEnumerator<HashSet.Slot<object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x264BFF0 Offset: 0x264C0F1 VA: 0x264BFF0
	|-Array.EmptyInternalEnumerator<Set.Slot<object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x264C1E0 Offset: 0x264C2E1 VA: 0x264C1E0
	|-Array.EmptyInternalEnumerator<HashSet.Slot<uint>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x264C3D0 Offset: 0x264C4D1 VA: 0x264C3D0
	|-Array.EmptyInternalEnumerator<HashSet.Slot<ulong>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x264C5D0 Offset: 0x264C6D1 VA: 0x264C5D0
	|-Array.EmptyInternalEnumerator<Set.Slot<Vector3>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x264C7D0 Offset: 0x264C8D1 VA: 0x264C7D0
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<Color32>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x264C9E0 Offset: 0x264CAE1 VA: 0x264C9E0
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<HighlightState>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x264CBE0 Offset: 0x264CCE1 VA: 0x264CBE0
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x264CDE0 Offset: 0x264CEE1 VA: 0x264CDE0
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<Int32Enum>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x264D040 Offset: 0x264D141 VA: 0x264D040
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<MaterialReference>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x264D250 Offset: 0x264D351 VA: 0x264D250
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x264D450 Offset: 0x264D551 VA: 0x264D450
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<float>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x264D660 Offset: 0x264D761 VA: 0x264D660
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<WordWrapState>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x264D850 Offset: 0x264D951 VA: 0x264D850
	|-Array.EmptyInternalEnumerator<TimeInterval<object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x264DA50 Offset: 0x264DB51 VA: 0x264DA50
	|-Array.EmptyInternalEnumerator<Timestamped<object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x264DC40 Offset: 0x264DD41 VA: 0x264DC40
	|-Array.EmptyInternalEnumerator<UniTask<object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x264DE30 Offset: 0x264DF31 VA: 0x264DE30
	|-Array.EmptyInternalEnumerator<ValueTuple<ValueTuple<bool, object>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x264E030 Offset: 0x264E131 VA: 0x264E030
	|-Array.EmptyInternalEnumerator<ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x264E230 Offset: 0x264E331 VA: 0x264E230
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, UniTask<object>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x264E430 Offset: 0x264E531 VA: 0x264E430
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x264E640 Offset: 0x264E741 VA: 0x264E640
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x264E850 Offset: 0x264E951 VA: 0x264E850
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x264EA40 Offset: 0x264EB41 VA: 0x264EA40
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x264EC30 Offset: 0x264ED31 VA: 0x264EC30
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x264EE50 Offset: 0x264EF51 VA: 0x264EE50
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x264F040 Offset: 0x264F141 VA: 0x264F040
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x264F250 Offset: 0x264F351 VA: 0x264F250
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x264F460 Offset: 0x264F561 VA: 0x264F460
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x264F660 Offset: 0x264F761 VA: 0x264F660
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x264F870 Offset: 0x264F971 VA: 0x264F870
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x264FA80 Offset: 0x264FB81 VA: 0x264FA80
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x264FC90 Offset: 0x264FD91 VA: 0x264FC90
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x264FEA0 Offset: 0x264FFA1 VA: 0x264FEA0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26500A0 Offset: 0x26501A1 VA: 0x26500A0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26502B0 Offset: 0x26503B1 VA: 0x26502B0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26504A0 Offset: 0x26505A1 VA: 0x26504A0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26506B0 Offset: 0x26507B1 VA: 0x26506B0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26508B0 Offset: 0x26509B1 VA: 0x26508B0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2650AC0 Offset: 0x2650BC1 VA: 0x2650AC0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2650CD0 Offset: 0x2650DD1 VA: 0x2650CD0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2650EE0 Offset: 0x2650FE1 VA: 0x2650EE0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26510F0 Offset: 0x26511F1 VA: 0x26510F0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2651310 Offset: 0x2651411 VA: 0x2651310
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2651560 Offset: 0x2651661 VA: 0x2651560
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26517B0 Offset: 0x26518B1 VA: 0x26517B0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2651A10 Offset: 0x2651B11 VA: 0x2651A10
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2651C00 Offset: 0x2651D01 VA: 0x2651C00
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2651DF0 Offset: 0x2651EF1 VA: 0x2651DF0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2652000 Offset: 0x2652101 VA: 0x2652000
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26521F0 Offset: 0x26522F1 VA: 0x26521F0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26523F0 Offset: 0x26524F1 VA: 0x26523F0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2652600 Offset: 0x2652701 VA: 0x2652600
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2652800 Offset: 0x2652901 VA: 0x2652800
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2652A10 Offset: 0x2652B11 VA: 0x2652A10
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2652C20 Offset: 0x2652D21 VA: 0x2652C20
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2652E20 Offset: 0x2652F21 VA: 0x2652E20
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2653020 Offset: 0x2653121 VA: 0x2653020
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2653220 Offset: 0x2653321 VA: 0x2653220
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2653430 Offset: 0x2653531 VA: 0x2653430
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2653620 Offset: 0x2653721 VA: 0x2653620
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2653820 Offset: 0x2653921 VA: 0x2653820
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2653A30 Offset: 0x2653B31 VA: 0x2653A30
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2653C30 Offset: 0x2653D31 VA: 0x2653C30
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2653E40 Offset: 0x2653F41 VA: 0x2653E40
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2654050 Offset: 0x2654151 VA: 0x2654050
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2654270 Offset: 0x2654371 VA: 0x2654270
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2654480 Offset: 0x2654581 VA: 0x2654480
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26546D0 Offset: 0x26547D1 VA: 0x26546D0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26548E0 Offset: 0x26549E1 VA: 0x26548E0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2654B60 Offset: 0x2654C61 VA: 0x2654B60
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2654D80 Offset: 0x2654E81 VA: 0x2654D80
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2655010 Offset: 0x2655111 VA: 0x2655010
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2655260 Offset: 0x2655361 VA: 0x2655260
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2655510 Offset: 0x2655611 VA: 0x2655510
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2655760 Offset: 0x2655861 VA: 0x2655760
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2655940 Offset: 0x2655A41 VA: 0x2655940
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2655B20 Offset: 0x2655C21 VA: 0x2655B20
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2655D30 Offset: 0x2655E31 VA: 0x2655D30
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2655F10 Offset: 0x2656011 VA: 0x2655F10
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2656120 Offset: 0x2656221 VA: 0x2656120
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2656320 Offset: 0x2656421 VA: 0x2656320
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2656510 Offset: 0x2656611 VA: 0x2656510
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2656710 Offset: 0x2656811 VA: 0x2656710
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2656910 Offset: 0x2656A11 VA: 0x2656910
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2656B20 Offset: 0x2656C21 VA: 0x2656B20
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2656D30 Offset: 0x2656E31 VA: 0x2656D30
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2656F20 Offset: 0x2657021 VA: 0x2656F20
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2657120 Offset: 0x2657221 VA: 0x2657120
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2657300 Offset: 0x2657401 VA: 0x2657300
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2657500 Offset: 0x2657601 VA: 0x2657500
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2657700 Offset: 0x2657801 VA: 0x2657700
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2657910 Offset: 0x2657A11 VA: 0x2657910
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2657B10 Offset: 0x2657C11 VA: 0x2657B10
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2657D10 Offset: 0x2657E11 VA: 0x2657D10
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2657F20 Offset: 0x2658021 VA: 0x2657F20
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2658130 Offset: 0x2658231 VA: 0x2658130
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2658380 Offset: 0x2658481 VA: 0x2658380
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2658590 Offset: 0x2658691 VA: 0x2658590
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26587F0 Offset: 0x26588F1 VA: 0x26587F0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2658A00 Offset: 0x2658B01 VA: 0x2658A00
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2658C90 Offset: 0x2658D91 VA: 0x2658C90
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2658EB0 Offset: 0x2658FB1 VA: 0x2658EB0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2659150 Offset: 0x2659251 VA: 0x2659150
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26593A0 Offset: 0x26594A1 VA: 0x26593A0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26595B0 Offset: 0x26596B1 VA: 0x26595B0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26597C0 Offset: 0x26598C1 VA: 0x26597C0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x26599B0 Offset: 0x2659AB1 VA: 0x26599B0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2659BA0 Offset: 0x2659CA1 VA: 0x2659BA0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, bool>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2659DA0 Offset: 0x2659EA1 VA: 0x2659DA0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, Bounds>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2659F90 Offset: 0x265A091 VA: 0x2659F90
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, byte>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x265A190 Offset: 0x265A291 VA: 0x265A190
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, Color>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x265A390 Offset: 0x265A491 VA: 0x265A390
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, double>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x265A580 Offset: 0x265A681 VA: 0x265A580
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, int>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF0E40 Offset: 0x1CF0F41 VA: 0x1CF0E40
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, long>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF1040 Offset: 0x1CF1141 VA: 0x1CF1040
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, object>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF1240 Offset: 0x1CF1341 VA: 0x1CF1240
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, Quaternion>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF1440 Offset: 0x1CF1541 VA: 0x1CF1440
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, Rect>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF1630 Offset: 0x1CF1731 VA: 0x1CF1630
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, float>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF1830 Offset: 0x1CF1931 VA: 0x1CF1830
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, UniTask>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF1A20 Offset: 0x1CF1B21 VA: 0x1CF1A20
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, Unit>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF1C10 Offset: 0x1CF1D11 VA: 0x1CF1C10
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, Vector2>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF1E10 Offset: 0x1CF1F11 VA: 0x1CF1E10
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, Vector3>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF2010 Offset: 0x1CF2111 VA: 0x1CF2010
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, Vector4>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF2210 Offset: 0x1CF2311 VA: 0x1CF2210
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<int, object>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF2410 Offset: 0x1CF2511 VA: 0x1CF2410
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<object, object>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF2620 Offset: 0x1CF2721 VA: 0x1CF2620
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF2820 Offset: 0x1CF2921 VA: 0x1CF2820
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<object, object, object>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF2A40 Offset: 0x1CF2B41 VA: 0x1CF2A40
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF2C50 Offset: 0x1CF2D51 VA: 0x1CF2C50
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<object, object, object, object>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF2EA0 Offset: 0x1CF2FA1 VA: 0x1CF2EA0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF30B0 Offset: 0x1CF31B1 VA: 0x1CF30B0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF3330 Offset: 0x1CF3431 VA: 0x1CF3330
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF3540 Offset: 0x1CF3641 VA: 0x1CF3540
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF37D0 Offset: 0x1CF38D1 VA: 0x1CF37D0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF39F0 Offset: 0x1CF3AF1 VA: 0x1CF39F0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF3CA0 Offset: 0x1CF3DA1 VA: 0x1CF3CA0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF3EB0 Offset: 0x1CF3FB1 VA: 0x1CF3EB0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF4090 Offset: 0x1CF4191 VA: 0x1CF4090
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, AsyncUnit>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF4270 Offset: 0x1CF4371 VA: 0x1CF4270
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, bool>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF4480 Offset: 0x1CF4581 VA: 0x1CF4480
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Bounds>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF4660 Offset: 0x1CF4761 VA: 0x1CF4660
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, byte>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF4860 Offset: 0x1CF4961 VA: 0x1CF4860
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Color>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF4A50 Offset: 0x1CF4B51 VA: 0x1CF4A50
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, double>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF4C30 Offset: 0x1CF4D31 VA: 0x1CF4C30
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF4E20 Offset: 0x1CF4F21 VA: 0x1CF4E20
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, long>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF5010 Offset: 0x1CF5111 VA: 0x1CF5010
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF5210 Offset: 0x1CF5311 VA: 0x1CF5210
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Quaternion>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF5410 Offset: 0x1CF5511 VA: 0x1CF5410
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Rect>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF55F0 Offset: 0x1CF56F1 VA: 0x1CF55F0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, float>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF57E0 Offset: 0x1CF58E1 VA: 0x1CF57E0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, UniTask>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF59C0 Offset: 0x1CF5AC1 VA: 0x1CF59C0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Unit>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF5BB0 Offset: 0x1CF5CB1 VA: 0x1CF5BB0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Vector2>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF5DA0 Offset: 0x1CF5EA1 VA: 0x1CF5DA0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Vector3>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF5FA0 Offset: 0x1CF60A1 VA: 0x1CF5FA0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Vector4>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF6180 Offset: 0x1CF6281 VA: 0x1CF6180
	|-Array.EmptyInternalEnumerator<ValueTuple<int, bool>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF6390 Offset: 0x1CF6491 VA: 0x1CF6390
	|-Array.EmptyInternalEnumerator<ValueTuple<int, Bounds>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF6570 Offset: 0x1CF6671 VA: 0x1CF6570
	|-Array.EmptyInternalEnumerator<ValueTuple<int, byte>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF6770 Offset: 0x1CF6871 VA: 0x1CF6770
	|-Array.EmptyInternalEnumerator<ValueTuple<int, Color>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF6960 Offset: 0x1CF6A61 VA: 0x1CF6960
	|-Array.EmptyInternalEnumerator<ValueTuple<int, double>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF6B40 Offset: 0x1CF6C41 VA: 0x1CF6B40
	|-Array.EmptyInternalEnumerator<ValueTuple<int, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF6D30 Offset: 0x1CF6E31 VA: 0x1CF6D30
	|-Array.EmptyInternalEnumerator<ValueTuple<int, long>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF6F20 Offset: 0x1CF7021 VA: 0x1CF6F20
	|-Array.EmptyInternalEnumerator<ValueTuple<int, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF7120 Offset: 0x1CF7221 VA: 0x1CF7120
	|-Array.EmptyInternalEnumerator<ValueTuple<int, Quaternion>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF7320 Offset: 0x1CF7421 VA: 0x1CF7320
	|-Array.EmptyInternalEnumerator<ValueTuple<int, Rect>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF7500 Offset: 0x1CF7601 VA: 0x1CF7500
	|-Array.EmptyInternalEnumerator<ValueTuple<int, float>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF76E0 Offset: 0x1CF77E1 VA: 0x1CF76E0
	|-Array.EmptyInternalEnumerator<ValueTuple<int, Unit>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF78D0 Offset: 0x1CF79D1 VA: 0x1CF78D0
	|-Array.EmptyInternalEnumerator<ValueTuple<int, Vector2>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF7AC0 Offset: 0x1CF7BC1 VA: 0x1CF7AC0
	|-Array.EmptyInternalEnumerator<ValueTuple<int, Vector3>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF7CC0 Offset: 0x1CF7DC1 VA: 0x1CF7CC0
	|-Array.EmptyInternalEnumerator<ValueTuple<int, Vector4>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF7EA0 Offset: 0x1CF7FA1 VA: 0x1CF7EA0
	|-Array.EmptyInternalEnumerator<ValueTuple<Int32Enum, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF80A0 Offset: 0x1CF81A1 VA: 0x1CF80A0
	|-Array.EmptyInternalEnumerator<ValueTuple<object, ValueTuple<object, int>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF8290 Offset: 0x1CF8391 VA: 0x1CF8290
	|-Array.EmptyInternalEnumerator<ValueTuple<object, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF8480 Offset: 0x1CF8581 VA: 0x1CF8480
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF8670 Offset: 0x1CF8771 VA: 0x1CF8670
	|-Array.EmptyInternalEnumerator<ValueTuple<object, float>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF8860 Offset: 0x1CF8961 VA: 0x1CF8860
	|-Array.EmptyInternalEnumerator<ValueTuple<Vector3, float>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF8A70 Offset: 0x1CF8B71 VA: 0x1CF8A70
	|-Array.EmptyInternalEnumerator<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF8C60 Offset: 0x1CF8D61 VA: 0x1CF8C60
	|-Array.EmptyInternalEnumerator<ValueTuple<object, Int32Enum, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF8E60 Offset: 0x1CF8F61 VA: 0x1CF8E60
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF9070 Offset: 0x1CF9171 VA: 0x1CF9070
	|-Array.EmptyInternalEnumerator<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF9270 Offset: 0x1CF9371 VA: 0x1CF9270
	|-Array.EmptyInternalEnumerator<ValueTuple<object, int, int, int>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF9470 Offset: 0x1CF9571 VA: 0x1CF9470
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object, object, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF96C0 Offset: 0x1CF97C1 VA: 0x1CF96C0
	|-Array.EmptyInternalEnumerator<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF98D0 Offset: 0x1CF99D1 VA: 0x1CF98D0
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object, object, object, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF9B30 Offset: 0x1CF9C31 VA: 0x1CF9B30
	|-Array.EmptyInternalEnumerator<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF9D40 Offset: 0x1CF9E41 VA: 0x1CF9D40
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object, object, object, object, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CF9FD0 Offset: 0x1CFA0D1 VA: 0x1CF9FD0
	|-Array.EmptyInternalEnumerator<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CFA1E0 Offset: 0x1CFA2E1 VA: 0x1CFA1E0
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object, object, object, object, object, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CFA480 Offset: 0x1CFA581 VA: 0x1CFA480
	|-Array.EmptyInternalEnumerator<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CFA690 Offset: 0x1CFA791 VA: 0x1CFA690
	|-Array.EmptyInternalEnumerator<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CFA870 Offset: 0x1CFA971 VA: 0x1CFA870
	|-Array.EmptyInternalEnumerator<AnimatorClipInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CFAA70 Offset: 0x1CFAB71 VA: 0x1CFAA70
	|-Array.EmptyInternalEnumerator<AsyncOperationHandle>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CFAC50 Offset: 0x1CFAD51 VA: 0x1CFAC50
	|-Array.EmptyInternalEnumerator<AsyncUnit>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CFAE40 Offset: 0x1CFAF41 VA: 0x1CFAE40
	|-Array.EmptyInternalEnumerator<BatchVisibility>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CFB040 Offset: 0x1CFB141 VA: 0x1CFB040
	|-Array.EmptyInternalEnumerator<BoneWeight>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CFB220 Offset: 0x1CFB321 VA: 0x1CFB220
	|-Array.EmptyInternalEnumerator<BoneWeight1>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CFB400 Offset: 0x1CFB501 VA: 0x1CFB400
	|-Array.EmptyInternalEnumerator<bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CFB600 Offset: 0x1CFB701 VA: 0x1CFB600
	|-Array.EmptyInternalEnumerator<Bounds>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CFB7E0 Offset: 0x1CFB8E1 VA: 0x1CFB7E0
	|-Array.EmptyInternalEnumerator<byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CFB9C0 Offset: 0x1CFBAC1 VA: 0x1CFB9C0
	|-Array.EmptyInternalEnumerator<ByteEnum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CFBBB0 Offset: 0x1CFBCB1 VA: 0x1CFBBB0
	|-Array.EmptyInternalEnumerator<CameraInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CFBD90 Offset: 0x1CFBE91 VA: 0x1CFBD90
	|-Array.EmptyInternalEnumerator<CancellationToken>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CFBF90 Offset: 0x1CFC091 VA: 0x1CFBF90
	|-Array.EmptyInternalEnumerator<CancellationTokenRegistration>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CFC170 Offset: 0x1CFC271 VA: 0x1CFC170
	|-Array.EmptyInternalEnumerator<char>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CFC370 Offset: 0x1CFC471 VA: 0x1CFC370
	|-Array.EmptyInternalEnumerator<ClusteringData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CFC580 Offset: 0x1CFC681 VA: 0x1CFC580
	|-Array.EmptyInternalEnumerator<ClusteringProcessorState>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CFC770 Offset: 0x1CFC871 VA: 0x1CFC770
	|-Array.EmptyInternalEnumerator<Color>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CFC950 Offset: 0x1CFCA51 VA: 0x1CFC950
	|-Array.EmptyInternalEnumerator<Color32>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CFCB30 Offset: 0x1CFCC31 VA: 0x1CFCB30
	|-Array.EmptyInternalEnumerator<Color4u8>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CFCD90 Offset: 0x1CFCE91 VA: 0x1CFCD90
	|-Array.EmptyInternalEnumerator<ColorBlock>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CFD020 Offset: 0x1CFD121 VA: 0x1CFD020
	|-Array.EmptyInternalEnumerator<CombineInstance>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CFD210 Offset: 0x1CFD311 VA: 0x1CFD210
	|-Array.EmptyInternalEnumerator<ConstraintSource>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CFD420 Offset: 0x1CFD521 VA: 0x1CFD420
	|-Array.EmptyInternalEnumerator<ContactPoint>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CFD630 Offset: 0x1CFD731 VA: 0x1CFD630
	|-Array.EmptyInternalEnumerator<ContactPoint2D>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CFD830 Offset: 0x1CFD931 VA: 0x1CFD830
	|-Array.EmptyInternalEnumerator<ContourVertex>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CFDA30 Offset: 0x1CFDB31 VA: 0x1CFDA30
	|-Array.EmptyInternalEnumerator<CustomAttributeNamedArgument>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CFDC20 Offset: 0x1CFDD21 VA: 0x1CFDC20
	|-Array.EmptyInternalEnumerator<CustomAttributeTypedArgument>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CFDE20 Offset: 0x1CFDF21 VA: 0x1CFDE20
	|-Array.EmptyInternalEnumerator<DataStoreRatingInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CFE000 Offset: 0x1CFE101 VA: 0x1CFE000
	|-Array.EmptyInternalEnumerator<DataStoreResult>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CFE1E0 Offset: 0x1CFE2E1 VA: 0x1CFE1E0
	|-Array.EmptyInternalEnumerator<DateTime>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CFE3D0 Offset: 0x1CFE4D1 VA: 0x1CFE3D0
	|-Array.EmptyInternalEnumerator<DateTimeOffset>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CFE5D0 Offset: 0x1CFE6D1 VA: 0x1CFE5D0
	|-Array.EmptyInternalEnumerator<DebugPadState>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CFE7C0 Offset: 0x1CFE8C1 VA: 0x1CFE7C0
	|-Array.EmptyInternalEnumerator<Decimal>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CFEA60 Offset: 0x1CFEB61 VA: 0x1CFEA60
	|-Array.EmptyInternalEnumerator<DeferredTiler>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CFEC50 Offset: 0x1CFED51 VA: 0x1CFEC50
	|-Array.EmptyInternalEnumerator<DeviceHandle>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CFEE60 Offset: 0x1CFEF61 VA: 0x1CFEE60
	|-Array.EmptyInternalEnumerator<DiagnosticEvent>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CFF050 Offset: 0x1CFF151 VA: 0x1CFF050
	|-Array.EmptyInternalEnumerator<DictionaryEntry>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CFF230 Offset: 0x1CFF331 VA: 0x1CFF230
	|-Array.EmptyInternalEnumerator<DictionaryInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CFF430 Offset: 0x1CFF531 VA: 0x1CFF430
	|-Array.EmptyInternalEnumerator<DirectoryEntry>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CFF610 Offset: 0x1CFF711 VA: 0x1CFF610
	|-Array.EmptyInternalEnumerator<double>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CFF800 Offset: 0x1CFF901 VA: 0x1CFF800
	|-Array.EmptyInternalEnumerator<Ephemeron>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CFF9E0 Offset: 0x1CFFAE1 VA: 0x1CFF9E0
	|-Array.EmptyInternalEnumerator<FXZ>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CFFBF0 Offset: 0x1CFFCF1 VA: 0x1CFFBF0
	|-Array.EmptyInternalEnumerator<Finger>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CFFDD0 Offset: 0x1CFFED1 VA: 0x1CFFDD0
	|-Array.EmptyInternalEnumerator<Float2>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1CFFFE0 Offset: 0x1D000E1 VA: 0x1CFFFE0
	|-Array.EmptyInternalEnumerator<Friend>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D001C0 Offset: 0x1D002C1 VA: 0x1D001C0
	|-Array.EmptyInternalEnumerator<GCHandle>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D003A0 Offset: 0x1D004A1 VA: 0x1D003A0
	|-Array.EmptyInternalEnumerator<GesturePoint>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D00620 Offset: 0x1D00721 VA: 0x1D00620
	|-Array.EmptyInternalEnumerator<GestureState>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D00830 Offset: 0x1D00931 VA: 0x1D00830
	|-Array.EmptyInternalEnumerator<GlyphMarshallingStruct>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D00A50 Offset: 0x1D00B51 VA: 0x1D00A50
	|-Array.EmptyInternalEnumerator<GlyphPairAdjustmentRecord>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D00C40 Offset: 0x1D00D41 VA: 0x1D00C40
	|-Array.EmptyInternalEnumerator<GlyphRect>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D00E30 Offset: 0x1D00F31 VA: 0x1D00E30
	|-Array.EmptyInternalEnumerator<Guid>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D01040 Offset: 0x1D01141 VA: 0x1D01040
	|-Array.EmptyInternalEnumerator<Hand>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D01230 Offset: 0x1D01331 VA: 0x1D01230
	|-Array.EmptyInternalEnumerator<HandAnalysisImageState>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D01440 Offset: 0x1D01541 VA: 0x1D01440
	|-Array.EmptyInternalEnumerator<HandAnalysisSilhouetteState>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D01630 Offset: 0x1D01731 VA: 0x1D01630
	|-Array.EmptyInternalEnumerator<HeaderVariantInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D01830 Offset: 0x1D01931 VA: 0x1D01830
	|-Array.EmptyInternalEnumerator<HighlightState>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D01A50 Offset: 0x1D01B51 VA: 0x1D01A50
	|-Array.EmptyInternalEnumerator<HumanBone>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D01C30 Offset: 0x1D01D31 VA: 0x1D01C30
	|-Array.EmptyInternalEnumerator<short>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D01E10 Offset: 0x1D01F11 VA: 0x1D01E10
	|-Array.EmptyInternalEnumerator<int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D01FF0 Offset: 0x1D020F1 VA: 0x1D01FF0
	|-Array.EmptyInternalEnumerator<Int32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D021D0 Offset: 0x1D022D1 VA: 0x1D021D0
	|-Array.EmptyInternalEnumerator<long>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D023B0 Offset: 0x1D024B1 VA: 0x1D023B0
	|-Array.EmptyInternalEnumerator<Int64Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D02590 Offset: 0x1D02691 VA: 0x1D02590
	|-Array.EmptyInternalEnumerator<IntPtr>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D02780 Offset: 0x1D02881 VA: 0x1D02780
	|-Array.EmptyInternalEnumerator<InternalCodePageDataItem>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D02970 Offset: 0x1D02A71 VA: 0x1D02970
	|-Array.EmptyInternalEnumerator<InternalEncodingDataItem>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D02B60 Offset: 0x1D02C61 VA: 0x1D02B60
	|-Array.EmptyInternalEnumerator<InterpretedFrameInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D02D60 Offset: 0x1D02E61 VA: 0x1D02D60
	|-Array.EmptyInternalEnumerator<IntervalTreeNode>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D02F50 Offset: 0x1D03051 VA: 0x1D02F50
	|-Array.EmptyInternalEnumerator<JobHandle>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D03160 Offset: 0x1D03261 VA: 0x1D03160
	|-Array.EmptyInternalEnumerator<Keyframe>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D03350 Offset: 0x1D03451 VA: 0x1D03350
	|-Array.EmptyInternalEnumerator<LOD>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D03530 Offset: 0x1D03631 VA: 0x1D03530
	|-Array.EmptyInternalEnumerator<LayerMask>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D03710 Offset: 0x1D03811 VA: 0x1D03710
	|-Array.EmptyInternalEnumerator<LengthLimitProperties>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D03960 Offset: 0x1D03A61 VA: 0x1D03960
	|-Array.EmptyInternalEnumerator<Light2DBlendStyle>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D03BE0 Offset: 0x1D03CE1 VA: 0x1D03BE0
	|-Array.EmptyInternalEnumerator<LightDataGI>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D03DD0 Offset: 0x1D03ED1 VA: 0x1D03DD0
	|-Array.EmptyInternalEnumerator<LocalDefinition>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D03FB0 Offset: 0x1D040B1 VA: 0x1D03FB0
	|-Array.EmptyInternalEnumerator<MapPos>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D041A0 Offset: 0x1D042A1 VA: 0x1D041A0
	|-Array.EmptyInternalEnumerator<MapRange>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D043B0 Offset: 0x1D044B1 VA: 0x1D043B0
	|-Array.EmptyInternalEnumerator<MaterialReference>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D045D0 Offset: 0x1D046D1 VA: 0x1D045D0
	|-Array.EmptyInternalEnumerator<Matrix4x4>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D047E0 Offset: 0x1D048E1 VA: 0x1D047E0
	|-Array.EmptyInternalEnumerator<MomentProcessorState>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D049D0 Offset: 0x1D04AD1 VA: 0x1D049D0
	|-Array.EmptyInternalEnumerator<MomentStatistic>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D04BE0 Offset: 0x1D04CE1 VA: 0x1D04BE0
	|-Array.EmptyInternalEnumerator<Navigation>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D04DC0 Offset: 0x1D04EC1 VA: 0x1D04DC0
	|-Array.EmptyInternalEnumerator<NetworkServiceAccountId>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D04FD0 Offset: 0x1D050D1 VA: 0x1D04FD0
	|-Array.EmptyInternalEnumerator<NpadFullKeyState>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D051E0 Offset: 0x1D052E1 VA: 0x1D051E0
	|-Array.EmptyInternalEnumerator<NpadHandheldState>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D053F0 Offset: 0x1D054F1 VA: 0x1D053F0
	|-Array.EmptyInternalEnumerator<NpadJoyDualState>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D05600 Offset: 0x1D05701 VA: 0x1D05600
	|-Array.EmptyInternalEnumerator<NpadJoyLeftState>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D05810 Offset: 0x1D05911 VA: 0x1D05810
	|-Array.EmptyInternalEnumerator<NpadJoyRightState>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D05A20 Offset: 0x1D05B21 VA: 0x1D05A20
	|-Array.EmptyInternalEnumerator<NpadStateArrayItem>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D05C00 Offset: 0x1D05D01 VA: 0x1D05C00
	|-Array.EmptyInternalEnumerator<NsUid>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D05DA0 Offset: 0x1D05EA1 VA: 0x1D05DA0
	|-Array.EmptyInternalEnumerator<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D05FB0 Offset: 0x1D060B1 VA: 0x1D05FB0
	|-Array.EmptyInternalEnumerator<ObjectInitializationData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D06190 Offset: 0x1D06291 VA: 0x1D06190
	|-Array.EmptyInternalEnumerator<ParameterModifier>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D06380 Offset: 0x1D06481 VA: 0x1D06380
	|-Array.EmptyInternalEnumerator<Plane>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D06570 Offset: 0x1D06671 VA: 0x1D06570
	|-Array.EmptyInternalEnumerator<Playable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D06770 Offset: 0x1D06871 VA: 0x1D06770
	|-Array.EmptyInternalEnumerator<PlayableBinding>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D06980 Offset: 0x1D06A81 VA: 0x1D06980
	|-Array.EmptyInternalEnumerator<PlayerLoopSystem>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D06B90 Offset: 0x1D06C91 VA: 0x1D06B90
	|-Array.EmptyInternalEnumerator<PlayerLoopSystemInternal>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D06DB0 Offset: 0x1D06EB1 VA: 0x1D06DB0
	|-Array.EmptyInternalEnumerator<PreTile>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D06FC0 Offset: 0x1D070C1 VA: 0x1D06FC0
	|-Array.EmptyInternalEnumerator<Profile>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D071A0 Offset: 0x1D072A1 VA: 0x1D071A0
	|-Array.EmptyInternalEnumerator<Protrusion>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D07390 Offset: 0x1D07491 VA: 0x1D07390
	|-Array.EmptyInternalEnumerator<Quaternion>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D07580 Offset: 0x1D07681 VA: 0x1D07580
	|-Array.EmptyInternalEnumerator<RandomSeed>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D07770 Offset: 0x1D07871 VA: 0x1D07770
	|-Array.EmptyInternalEnumerator<RangePositionInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D07950 Offset: 0x1D07A51 VA: 0x1D07950
	|-Array.EmptyInternalEnumerator<Ranking2ChartInfoInput>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D07B70 Offset: 0x1D07C71 VA: 0x1D07B70
	|-Array.EmptyInternalEnumerator<RaycastHit>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D07D80 Offset: 0x1D07E81 VA: 0x1D07D80
	|-Array.EmptyInternalEnumerator<RaycastHit2D>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D07FD0 Offset: 0x1D080D1 VA: 0x1D07FD0
	|-Array.EmptyInternalEnumerator<RaycastResult>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D081C0 Offset: 0x1D082C1 VA: 0x1D081C0
	|-Array.EmptyInternalEnumerator<Rect>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D083B0 Offset: 0x1D084B1 VA: 0x1D083B0
	|-Array.EmptyInternalEnumerator<RenderBuffer>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D08650 Offset: 0x1D08751 VA: 0x1D08650
	|-Array.EmptyInternalEnumerator<RenderStateBlock>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D08860 Offset: 0x1D08961 VA: 0x1D08860
	|-Array.EmptyInternalEnumerator<RenderTargetHandle>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D08A70 Offset: 0x1D08B71 VA: 0x1D08A70
	|-Array.EmptyInternalEnumerator<RenderTargetIdentifier>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D08C50 Offset: 0x1D08D51 VA: 0x1D08C50
	|-Array.EmptyInternalEnumerator<RendererListHandle>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D08E30 Offset: 0x1D08F31 VA: 0x1D08E30
	|-Array.EmptyInternalEnumerator<ResourceHandle>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D09020 Offset: 0x1D09121 VA: 0x1D09020
	|-Array.EmptyInternalEnumerator<ResourceLocator>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D09220 Offset: 0x1D09321 VA: 0x1D09220
	|-Array.EmptyInternalEnumerator<RichTextTagAttribute>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D09410 Offset: 0x1D09511 VA: 0x1D09410
	|-Array.EmptyInternalEnumerator<RuntimeLabel>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D095F0 Offset: 0x1D096F1 VA: 0x1D095F0
	|-Array.EmptyInternalEnumerator<sbyte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D097F0 Offset: 0x1D098F1 VA: 0x1D097F0
	|-Array.EmptyInternalEnumerator<SerializedType>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D099D0 Offset: 0x1D09AD1 VA: 0x1D099D0
	|-Array.EmptyInternalEnumerator<ShaderKeyword>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D09BB0 Offset: 0x1D09CB1 VA: 0x1D09BB0
	|-Array.EmptyInternalEnumerator<ShaderTagId>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D09DC0 Offset: 0x1D09EC1 VA: 0x1D09DC0
	|-Array.EmptyInternalEnumerator<ShadowSliceData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D09FC0 Offset: 0x1D0A0C1 VA: 0x1D09FC0
	|-Array.EmptyInternalEnumerator<Shape>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D0A1A0 Offset: 0x1D0A2A1 VA: 0x1D0A1A0
	|-Array.EmptyInternalEnumerator<float>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D0A380 Offset: 0x1D0A481 VA: 0x1D0A380
	|-Array.EmptyInternalEnumerator<SixAxisSensorHandle>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D0A600 Offset: 0x1D0A701 VA: 0x1D0A600
	|-Array.EmptyInternalEnumerator<SixAxisSensorState>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D0A810 Offset: 0x1D0A911 VA: 0x1D0A810
	|-Array.EmptyInternalEnumerator<SkeletonBone>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D0A9F0 Offset: 0x1D0AAF1 VA: 0x1D0A9F0
	|-Array.EmptyInternalEnumerator<SortingLayer>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D0AC90 Offset: 0x1D0AD91 VA: 0x1D0AC90
	|-Array.EmptyInternalEnumerator<SphericalHarmonicsL2>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D0AE70 Offset: 0x1D0AF71 VA: 0x1D0AE70
	|-Array.EmptyInternalEnumerator<SpinLock>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D0B0C0 Offset: 0x1D0B1C1 VA: 0x1D0B0C0
	|-Array.EmptyInternalEnumerator<SpringBoneComponents>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D0B2D0 Offset: 0x1D0B3D1 VA: 0x1D0B2D0
	|-Array.EmptyInternalEnumerator<SpringBoneProperties>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D0B580 Offset: 0x1D0B681 VA: 0x1D0B580
	|-Array.EmptyInternalEnumerator<SpringColliderComponents>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D0B770 Offset: 0x1D0B871 VA: 0x1D0B770
	|-Array.EmptyInternalEnumerator<SpringColliderProperties>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D0B990 Offset: 0x1D0BA91 VA: 0x1D0B990
	|-Array.EmptyInternalEnumerator<SpringForceComponent>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D0BBA0 Offset: 0x1D0BCA1 VA: 0x1D0BBA0
	|-Array.EmptyInternalEnumerator<SpringJobElement>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D0BDA0 Offset: 0x1D0BEA1 VA: 0x1D0BDA0
	|-Array.EmptyInternalEnumerator<SpriteState>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D0BFB0 Offset: 0x1D0C0B1 VA: 0x1D0BFB0
	|-Array.EmptyInternalEnumerator<SubMeshDescriptor>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D0C1C0 Offset: 0x1D0C2C1 VA: 0x1D0C1C0
	|-Array.EmptyInternalEnumerator<TMP_CharacterInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D0C3B0 Offset: 0x1D0C4B1 VA: 0x1D0C3B0
	|-Array.EmptyInternalEnumerator<TMP_FontWeightPair>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D0C630 Offset: 0x1D0C731 VA: 0x1D0C630
	|-Array.EmptyInternalEnumerator<TMP_LineInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D0C840 Offset: 0x1D0C941 VA: 0x1D0C840
	|-Array.EmptyInternalEnumerator<TMP_LinkInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D0CA90 Offset: 0x1D0CB91 VA: 0x1D0CA90
	|-Array.EmptyInternalEnumerator<TMP_MeshInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D0CC90 Offset: 0x1D0CD91 VA: 0x1D0CC90
	|-Array.EmptyInternalEnumerator<TMP_PageInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D0CE90 Offset: 0x1D0CF91 VA: 0x1D0CE90
	|-Array.EmptyInternalEnumerator<TMP_WordInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D0D080 Offset: 0x1D0D181 VA: 0x1D0D080
	|-Array.EmptyInternalEnumerator<TablePair>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D0D260 Offset: 0x1D0D361 VA: 0x1D0D260
	|-Array.EmptyInternalEnumerator<TextureHandle>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D0D440 Offset: 0x1D0D541 VA: 0x1D0D440
	|-Array.EmptyInternalEnumerator<TimeSpan>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D0D690 Offset: 0x1D0D791 VA: 0x1D0D690
	|-Array.EmptyInternalEnumerator<Touch>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D0D8A0 Offset: 0x1D0D9A1 VA: 0x1D0D8A0
	|-Array.EmptyInternalEnumerator<TouchScreenState1>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D0DAB0 Offset: 0x1D0DBB1 VA: 0x1D0DAB0
	|-Array.EmptyInternalEnumerator<TouchScreenState10>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D0DCC0 Offset: 0x1D0DDC1 VA: 0x1D0DCC0
	|-Array.EmptyInternalEnumerator<TouchScreenState11>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D0DED0 Offset: 0x1D0DFD1 VA: 0x1D0DED0
	|-Array.EmptyInternalEnumerator<TouchScreenState12>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D0E0E0 Offset: 0x1D0E1E1 VA: 0x1D0E0E0
	|-Array.EmptyInternalEnumerator<TouchScreenState13>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D0E2F0 Offset: 0x1D0E3F1 VA: 0x1D0E2F0
	|-Array.EmptyInternalEnumerator<TouchScreenState14>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D0E500 Offset: 0x1D0E601 VA: 0x1D0E500
	|-Array.EmptyInternalEnumerator<TouchScreenState15>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D0E710 Offset: 0x1D0E811 VA: 0x1D0E710
	|-Array.EmptyInternalEnumerator<TouchScreenState16>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D0E990 Offset: 0x1D0EA91 VA: 0x1D0E990
	|-Array.EmptyInternalEnumerator<TouchScreenState2>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D0EBA0 Offset: 0x1D0ECA1 VA: 0x1D0EBA0
	|-Array.EmptyInternalEnumerator<TouchScreenState3>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D0EDB0 Offset: 0x1D0EEB1 VA: 0x1D0EDB0
	|-Array.EmptyInternalEnumerator<TouchScreenState4>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D0EFC0 Offset: 0x1D0F0C1 VA: 0x1D0EFC0
	|-Array.EmptyInternalEnumerator<TouchScreenState5>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D0F1D0 Offset: 0x1D0F2D1 VA: 0x1D0F1D0
	|-Array.EmptyInternalEnumerator<TouchScreenState6>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D0F3E0 Offset: 0x1D0F4E1 VA: 0x1D0F3E0
	|-Array.EmptyInternalEnumerator<TouchScreenState7>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D0F5F0 Offset: 0x1D0F6F1 VA: 0x1D0F5F0
	|-Array.EmptyInternalEnumerator<TouchScreenState8>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D0F800 Offset: 0x1D0F901 VA: 0x1D0F800
	|-Array.EmptyInternalEnumerator<TouchScreenState9>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D0FA10 Offset: 0x1D0FB11 VA: 0x1D0FA10
	|-Array.EmptyInternalEnumerator<TouchState>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D0FC10 Offset: 0x1D0FD11 VA: 0x1D0FC10
	|-Array.EmptyInternalEnumerator<TrailHand>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D0FE10 Offset: 0x1D0FF11 VA: 0x1D0FE10
	|-Array.EmptyInternalEnumerator<TrailVertex>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D10000 Offset: 0x1D10101 VA: 0x1D10000
	|-Array.EmptyInternalEnumerator<UICharInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D101F0 Offset: 0x1D102F1 VA: 0x1D101F0
	|-Array.EmptyInternalEnumerator<UILineInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D10490 Offset: 0x1D10591 VA: 0x1D10490
	|-Array.EmptyInternalEnumerator<UIVertex>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D10670 Offset: 0x1D10771 VA: 0x1D10670
	|-Array.EmptyInternalEnumerator<ushort>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D10850 Offset: 0x1D10951 VA: 0x1D10850
	|-Array.EmptyInternalEnumerator<UInt16Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D10A30 Offset: 0x1D10B31 VA: 0x1D10A30
	|-Array.EmptyInternalEnumerator<uint>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D10C10 Offset: 0x1D10D11 VA: 0x1D10C10
	|-Array.EmptyInternalEnumerator<UInt32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D10DF0 Offset: 0x1D10EF1 VA: 0x1D10DF0
	|-Array.EmptyInternalEnumerator<ulong>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D10FE0 Offset: 0x1D110E1 VA: 0x1D10FE0
	|-Array.EmptyInternalEnumerator<Uid>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D111C0 Offset: 0x1D112C1 VA: 0x1D111C0
	|-Array.EmptyInternalEnumerator<UniTask>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D113A0 Offset: 0x1D114A1 VA: 0x1D113A0
	|-Array.EmptyInternalEnumerator<Unit>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D11580 Offset: 0x1D11681 VA: 0x1D11580
	|-Array.EmptyInternalEnumerator<UnitEnum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D11770 Offset: 0x1D11871 VA: 0x1D11770
	|-Array.EmptyInternalEnumerator<UserWord>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D11950 Offset: 0x1D11A51 VA: 0x1D11950
	|-Array.EmptyInternalEnumerator<Vector2>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D11B30 Offset: 0x1D11C31 VA: 0x1D11B30
	|-Array.EmptyInternalEnumerator<Vector2Int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D11D20 Offset: 0x1D11E21 VA: 0x1D11D20
	|-Array.EmptyInternalEnumerator<Vector3>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D11F10 Offset: 0x1D12011 VA: 0x1D11F10
	|-Array.EmptyInternalEnumerator<Vector4>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D12100 Offset: 0x1D12201 VA: 0x1D12100
	|-Array.EmptyInternalEnumerator<VertexAttributeDescriptor>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D122E0 Offset: 0x1D123E1 VA: 0x1D122E0
	|-Array.EmptyInternalEnumerator<VibrationDeviceHandle>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D124C0 Offset: 0x1D125C1 VA: 0x1D124C0
	|-Array.EmptyInternalEnumerator<VibrationDeviceInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D126B0 Offset: 0x1D127B1 VA: 0x1D126B0
	|-Array.EmptyInternalEnumerator<VibrationValue>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D12950 Offset: 0x1D12A51 VA: 0x1D12950
	|-Array.EmptyInternalEnumerator<VisibleLight>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D12B60 Offset: 0x1D12C61 VA: 0x1D12B60
	|-Array.EmptyInternalEnumerator<WordWrapState>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D12D50 Offset: 0x1D12E51 VA: 0x1D12D50
	|-Array.EmptyInternalEnumerator<X509ChainStatus>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D12F50 Offset: 0x1D13051 VA: 0x1D12F50
	|-Array.EmptyInternalEnumerator<XPathNode>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D13140 Offset: 0x1D13241 VA: 0x1D13140
	|-Array.EmptyInternalEnumerator<XPathNodeRef>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D13350 Offset: 0x1D13451 VA: 0x1D13350
	|-Array.EmptyInternalEnumerator<XRView>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D13540 Offset: 0x1D13641 VA: 0x1D13540
	|-Array.EmptyInternalEnumerator<float3>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D13760 Offset: 0x1D13861 VA: 0x1D13760
	|-Array.EmptyInternalEnumerator<float4x4>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D13940 Offset: 0x1D13A41 VA: 0x1D13940
	|-Array.EmptyInternalEnumerator<jvalue>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D13B30 Offset: 0x1D13C31 VA: 0x1D13B30
	|-Array.EmptyInternalEnumerator<uint4>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D13D20 Offset: 0x1D13E21 VA: 0x1D13D20
	|-Array.EmptyInternalEnumerator<AICrossfire.PositionTable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D13F10 Offset: 0x1D14011 VA: 0x1D13F10
	|-Array.EmptyInternalEnumerator<AIEnum.SkillRangeEnemyData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D140F0 Offset: 0x1D141F1 VA: 0x1D140F0
	|-Array.EmptyInternalEnumerator<AIOrder.UnitPriority>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D142E0 Offset: 0x1D143E1 VA: 0x1D142E0
	|-Array.EmptyInternalEnumerator<AmiiboSequence.GainItemData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D144F0 Offset: 0x1D145F1 VA: 0x1D144F0
	|-Array.EmptyInternalEnumerator<AnimationOutputWeightProcessor.WeightInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D146E0 Offset: 0x1D147E1 VA: 0x1D146E0
	|-Array.EmptyInternalEnumerator<ArenaOrderSequence.GodInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D148D0 Offset: 0x1D149D1 VA: 0x1D148D0
	|-Array.EmptyInternalEnumerator<BattleInfo.SupportData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D14AC0 Offset: 0x1D14BC1 VA: 0x1D14AC0
	|-Array.EmptyInternalEnumerator<BeforeRenderHelper.OrderBlock>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D14CC0 Offset: 0x1D14DC1 VA: 0x1D14CC0
	|-Array.EmptyInternalEnumerator<Camera.RenderRequest>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D14EB0 Offset: 0x1D14FB1 VA: 0x1D14EB0
	|-Array.EmptyInternalEnumerator<CameraState.CustomBlendable>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D150B0 Offset: 0x1D151B1 VA: 0x1D150B0
	|-Array.EmptyInternalEnumerator<CinemachineBlendListCamera.Instruction>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D152B0 Offset: 0x1D153B1 VA: 0x1D152B0
	|-Array.EmptyInternalEnumerator<CinemachineBlenderSettings.CustomBlend>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D15490 Offset: 0x1D15591 VA: 0x1D15490
	|-Array.EmptyInternalEnumerator<CinemachineClearShot.Pair>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D15670 Offset: 0x1D15771 VA: 0x1D15670
	|-Array.EmptyInternalEnumerator<CinemachineFreeLook.Orbit>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D15880 Offset: 0x1D15981 VA: 0x1D15880
	|-Array.EmptyInternalEnumerator<CinemachinePath.Waypoint>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D15A70 Offset: 0x1D15B71 VA: 0x1D15A70
	|-Array.EmptyInternalEnumerator<CinemachineSmoothPath.Waypoint>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D15C50 Offset: 0x1D15D51 VA: 0x1D15C50
	|-Array.EmptyInternalEnumerator<CinemachineStateDrivenCamera.HashPair>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D15E50 Offset: 0x1D15F51 VA: 0x1D15E50
	|-Array.EmptyInternalEnumerator<CinemachineStateDrivenCamera.Instruction>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D16030 Offset: 0x1D16131 VA: 0x1D16030
	|-Array.EmptyInternalEnumerator<CinemachineStateDrivenCamera.ParentHash>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D16220 Offset: 0x1D16321 VA: 0x1D16220
	|-Array.EmptyInternalEnumerator<CinemachineTargetGroup.Target>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D16420 Offset: 0x1D16521 VA: 0x1D16420
	|-Array.EmptyInternalEnumerator<CodePointIndexer.TableRange>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D16610 Offset: 0x1D16711 VA: 0x1D16610
	|-Array.EmptyInternalEnumerator<ContentCatalogData.Bucket>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D16800 Offset: 0x1D16901 VA: 0x1D16800
	|-Array.EmptyInternalEnumerator<CookieTokenizer.RecognizedAttribute>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D16A10 Offset: 0x1D16B11 VA: 0x1D16A10
	|-Array.EmptyInternalEnumerator<DeferredLights.DrawCall>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D16BF0 Offset: 0x1D16CF1 VA: 0x1D16BF0
	|-Array.EmptyInternalEnumerator<DeferredShaderData.ComputeBufferInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D16DF0 Offset: 0x1D16EF1 VA: 0x1D16DF0
	|-Array.EmptyInternalEnumerator<DeferredTiler.PrePunctualLight>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D16FF0 Offset: 0x1D170F1 VA: 0x1D16FF0
	|-Array.EmptyInternalEnumerator<DelayedActionManager.DelegateInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D17200 Offset: 0x1D17301 VA: 0x1D17200
	|-Array.EmptyInternalEnumerator<Detail.AsyncResultInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D173F0 Offset: 0x1D174F1 VA: 0x1D173F0
	|-Array.EmptyInternalEnumerator<Detail.CppArray>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D17600 Offset: 0x1D17701 VA: 0x1D17600
	|-Array.EmptyInternalEnumerator<Detail.NotificationEventInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D177F0 Offset: 0x1D178F1 VA: 0x1D177F0
	|-Array.EmptyInternalEnumerator<DisposUnit.Item>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D179E0 Offset: 0x1D17AE1 VA: 0x1D179E0
	|-Array.EmptyInternalEnumerator<DragonRidePresetParamData.CourseData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D17BD0 Offset: 0x1D17CD1 VA: 0x1D17BD0
	|-Array.EmptyInternalEnumerator<DragonRideTargetGroup.ChainParam>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D17DB0 Offset: 0x1D17EB1 VA: 0x1D17DB0
	|-Array.EmptyInternalEnumerator<DynamicMesh.State>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D17FC0 Offset: 0x1D180C1 VA: 0x1D17FC0
	|-Array.EmptyInternalEnumerator<FXZEx.HitPoint>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D181B0 Offset: 0x1D182B1 VA: 0x1D181B0
	|-Array.EmptyInternalEnumerator<FishingRadicalParamData.RadicalParam>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D183A0 Offset: 0x1D184A1 VA: 0x1D183A0
	|-Array.EmptyInternalEnumerator<GameVariable.Value>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D185A0 Offset: 0x1D186A1 VA: 0x1D185A0
	|-Array.EmptyInternalEnumerator<GmapPathAdjuster.TargetModel>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D187A0 Offset: 0x1D188A1 VA: 0x1D187A0
	|-Array.EmptyInternalEnumerator<GmapSpotAdjuster.TargetModel>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D189B0 Offset: 0x1D18AB1 VA: 0x1D189B0
	|-Array.EmptyInternalEnumerator<GrounderQuadruped.Foot>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D18BB0 Offset: 0x1D18CB1 VA: 0x1D18BB0
	|-Array.EmptyInternalEnumerator<Hashtable.bucket>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D18DB0 Offset: 0x1D18EB1 VA: 0x1D18DB0
	|-Array.EmptyInternalEnumerator<HeadingTracker.Item>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D18FC0 Offset: 0x1D190C1 VA: 0x1D18FC0
	|-Array.EmptyInternalEnumerator<HubAccessoryRoomCamera.BackgroundSettings>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D191C0 Offset: 0x1D192C1 VA: 0x1D191C0
	|-Array.EmptyInternalEnumerator<HubFastTravel.Location>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D193D0 Offset: 0x1D194D1 VA: 0x1D193D0
	|-Array.EmptyInternalEnumerator<HubLensFlare.Flare>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D195C0 Offset: 0x1D196C1 VA: 0x1D195C0
	|-Array.EmptyInternalEnumerator<HubLookAtController.LookAtIKParam>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D197B0 Offset: 0x1D198B1 VA: 0x1D197B0
	|-Array.EmptyInternalEnumerator<HubMaterialArray.MaterialInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D199C0 Offset: 0x1D19AC1 VA: 0x1D199C0
	|-Array.EmptyInternalEnumerator<IKSolverLimb.AxisDirection>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D19BB0 Offset: 0x1D19CB1 VA: 0x1D19BB0
	|-Array.EmptyInternalEnumerator<InventoryPoolItemMenuContent.KindBgNameClass>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D19DC0 Offset: 0x1D19EC1 VA: 0x1D19DC0
	|-Array.EmptyInternalEnumerator<LightUtility.ParametricLightMeshVertex>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D19FD0 Offset: 0x1D1A0D1 VA: 0x1D19FD0
	|-Array.EmptyInternalEnumerator<LightUtility.SpriteLightMeshVertex>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D1A1B0 Offset: 0x1D1A2B1 VA: 0x1D1A1B0
	|-Array.EmptyInternalEnumerator<Map.Pos>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D1A3A0 Offset: 0x1D1A4A1 VA: 0x1D1A3A0
	|-Array.EmptyInternalEnumerator<MapGodExp.KindDesc>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D1A580 Offset: 0x1D1A681 VA: 0x1D1A580
	|-Array.EmptyInternalEnumerator<MapHistory.Command>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D1A770 Offset: 0x1D1A871 VA: 0x1D1A770
	|-Array.EmptyInternalEnumerator<MapImage.BackupTerrain>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D1A950 Offset: 0x1D1AA51 VA: 0x1D1A950
	|-Array.EmptyInternalEnumerator<MapImageRange.Pos>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D1AB30 Offset: 0x1D1AC31 VA: 0x1D1AB30
	|-Array.EmptyInternalEnumerator<MapKillBonus.KillBonus>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D1AD10 Offset: 0x1D1AE11 VA: 0x1D1AD10
	|-Array.EmptyInternalEnumerator<MapKillBonus.KilledBonus>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D1AF60 Offset: 0x1D1B061 VA: 0x1D1AF60
	|-Array.EmptyInternalEnumerator<MapMind.Record>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D1B160 Offset: 0x1D1B261 VA: 0x1D1B160
	|-Array.EmptyInternalEnumerator<MapMind.Target>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D1B360 Offset: 0x1D1B461 VA: 0x1D1B360
	|-Array.EmptyInternalEnumerator<MapPanelDebug.Entity>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D1B540 Offset: 0x1D1B641 VA: 0x1D1B540
	|-Array.EmptyInternalEnumerator<NexRanking.Data>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D1B730 Offset: 0x1D1B831 VA: 0x1D1B730
	|-Array.EmptyInternalEnumerator<NexVersus.RatingData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D1B940 Offset: 0x1D1BA41 VA: 0x1D1B940
	|-Array.EmptyInternalEnumerator<NoiseSettings.TransformNoiseParams>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D1BB30 Offset: 0x1D1BC31 VA: 0x1D1BB30
	|-Array.EmptyInternalEnumerator<PackedPlayModeBuildLogs.RuntimeBuildLog>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D1BD20 Offset: 0x1D1BE21 VA: 0x1D1BD20
	|-Array.EmptyInternalEnumerator<ParameterizedStrings.FormatParam>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D1BF30 Offset: 0x1D1C031 VA: 0x1D1BF30
	|-Array.EmptyInternalEnumerator<ParticleSystem.Particle>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D1C110 Offset: 0x1D1C211 VA: 0x1D1C110
	|-Array.EmptyInternalEnumerator<ProfileCard.Achievement>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D1C310 Offset: 0x1D1C411 VA: 0x1D1C310
	|-Array.EmptyInternalEnumerator<ProfileCard.SortieCount>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D1C520 Offset: 0x1D1C621 VA: 0x1D1C520
	|-Array.EmptyInternalEnumerator<QualitySettingsStack.Settings>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D1C700 Offset: 0x1D1C801 VA: 0x1D1C700
	|-Array.EmptyInternalEnumerator<RangeData.Offset>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D1C8F0 Offset: 0x1D1C9F1 VA: 0x1D1C8F0
	|-Array.EmptyInternalEnumerator<RegexCharClass.LowerCaseMapping>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D1CAF0 Offset: 0x1D1CBF1 VA: 0x1D1CAF0
	|-Array.EmptyInternalEnumerator<Relay.ChooseAwardeeData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D1CCE0 Offset: 0x1D1CDE1 VA: 0x1D1CCE0
	|-Array.EmptyInternalEnumerator<RelayAwardData.Info>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D1CF30 Offset: 0x1D1D031 VA: 0x1D1CF30
	|-Array.EmptyInternalEnumerator<RenderGraph.CompiledPassInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D1D130 Offset: 0x1D1D231 VA: 0x1D1D130
	|-Array.EmptyInternalEnumerator<RenderGraph.CompiledResourceInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D1D330 Offset: 0x1D1D431 VA: 0x1D1D330
	|-Array.EmptyInternalEnumerator<RenderGraphDebugData.PassDebugData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D1D540 Offset: 0x1D1D641 VA: 0x1D1D540
	|-Array.EmptyInternalEnumerator<RenderGraphDebugData.ResourceDebugData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D1D750 Offset: 0x1D1D851 VA: 0x1D1D750
	|-Array.EmptyInternalEnumerator<RenderGraphResourceRegistry.RendererListResource>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D1D940 Offset: 0x1D1DA41 VA: 0x1D1D940
	|-Array.EmptyInternalEnumerator<RingCleaningUnitSelectMenu.GodParam>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D1DB30 Offset: 0x1D1DC31 VA: 0x1D1DB30
	|-Array.EmptyInternalEnumerator<SampleWave.Data>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D1DD10 Offset: 0x1D1DE11 VA: 0x1D1DD10
	|-Array.EmptyInternalEnumerator<SampleWave.Temp>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D1DF00 Offset: 0x1D1E001 VA: 0x1D1DF00
	|-Array.EmptyInternalEnumerator<SendMouseEvents.HitInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D1E110 Offset: 0x1D1E211 VA: 0x1D1E110
	|-Array.EmptyInternalEnumerator<SequenceNode.SequenceConstructPosContext>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D1E360 Offset: 0x1D1E461 VA: 0x1D1E360
	|-Array.EmptyInternalEnumerator<ShaderInput.LightData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D1E5B0 Offset: 0x1D1E6B1 VA: 0x1D1E5B0
	|-Array.EmptyInternalEnumerator<ShaderInput.ShadowData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D1E7C0 Offset: 0x1D1E8C1 VA: 0x1D1E7C0
	|-Array.EmptyInternalEnumerator<ShadowUtility.Edge>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D1E9B0 Offset: 0x1D1EAB1 VA: 0x1D1E9B0
	|-Array.EmptyInternalEnumerator<SimpleAnimationPlayable.QueuedState>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D1EB90 Offset: 0x1D1EC91 VA: 0x1D1EB90
	|-Array.EmptyInternalEnumerator<SkillArray.Entity>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D1ED80 Offset: 0x1D1EE81 VA: 0x1D1ED80
	|-Array.EmptyInternalEnumerator<Socket.WSABUF>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D1EF70 Offset: 0x1D1F071 VA: 0x1D1EF70
	|-Array.EmptyInternalEnumerator<Stream.Info>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D1F160 Offset: 0x1D1F261 VA: 0x1D1F160
	|-Array.EmptyInternalEnumerator<TMP_Text.UnicodeChar>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D1F380 Offset: 0x1D1F481 VA: 0x1D1F380
	|-Array.EmptyInternalEnumerator<TexturePacker_JsonArray.Frame>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D1F580 Offset: 0x1D1F681 VA: 0x1D1F580
	|-Array.EmptyInternalEnumerator<TimeNotificationBehaviour.NotificationEntry>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D1F780 Offset: 0x1D1F881 VA: 0x1D1F780
	|-Array.EmptyInternalEnumerator<UnitySynchronizationContext.WorkRequest>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D1F980 Offset: 0x1D1FA81 VA: 0x1D1F980
	|-Array.EmptyInternalEnumerator<XmlNamespaceManager.NamespaceDeclaration>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D1FB70 Offset: 0x1D1FC71 VA: 0x1D1FB70
	|-Array.EmptyInternalEnumerator<XmlSchemaObjectTable.XmlSchemaObjectEntry>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D1FE10 Offset: 0x1D1FF11 VA: 0x1D1FE10
	|-Array.EmptyInternalEnumerator<XmlTextReaderImpl.ParsingState>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D20000 Offset: 0x1D20101 VA: 0x1D20000
	|-Array.EmptyInternalEnumerator<AIThink.EnchantThink.Desc>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D201E0 Offset: 0x1D202E1 VA: 0x1D201E0
	|-Array.EmptyInternalEnumerator<AIThink.EnchantThink.ItemInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D203C0 Offset: 0x1D204C1 VA: 0x1D203C0
	|-Array.EmptyInternalEnumerator<AIThink.EnchantThink.SurroundingInfo>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D205B0 Offset: 0x1D206B1 VA: 0x1D205B0
	|-Array.EmptyInternalEnumerator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D207C0 Offset: 0x1D208C1 VA: 0x1D207C0
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStoreChangeMetaParamInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D209B0 Offset: 0x1D20AB1 VA: 0x1D209B0
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStoreDeleteParamInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D20BC0 Offset: 0x1D20CC1 VA: 0x1D20BC0
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStoreGetMetaParamInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D20DD0 Offset: 0x1D20ED1 VA: 0x1D20DD0
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStoreMetaInfoInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D20FD0 Offset: 0x1D210D1 VA: 0x1D20FD0
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStorePasswordInfoInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D211D0 Offset: 0x1D212D1 VA: 0x1D211D0
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStorePersistenceInfoInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D213E0 Offset: 0x1D214E1 VA: 0x1D213E0
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStorePreparePostParamInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D215D0 Offset: 0x1D216D1 VA: 0x1D215D0
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStoreRateObjectParamInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D217D0 Offset: 0x1D218D1 VA: 0x1D217D0
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStoreRatingInitParamInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D219C0 Offset: 0x1D21AC1 VA: 0x1D219C0
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStoreRatingTargetInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D21BD0 Offset: 0x1D21CD1 VA: 0x1D21BD0
	|-Array.EmptyInternalEnumerator<Detail.Ranking.RankingCachedResultInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D21DC0 Offset: 0x1D21EC1 VA: 0x1D21DC0
	|-Array.EmptyInternalEnumerator<Detail.Ranking.RankingOrderParamInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D21FE0 Offset: 0x1D220E1 VA: 0x1D21FE0
	|-Array.EmptyInternalEnumerator<Detail.Ranking.RankingRankDataInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D22260 Offset: 0x1D22361 VA: 0x1D22260
	|-Array.EmptyInternalEnumerator<Detail.Ranking2.Ranking2ChartInfoInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D22480 Offset: 0x1D22581 VA: 0x1D22480
	|-Array.EmptyInternalEnumerator<Detail.Ranking2.Ranking2RankDataInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D22670 Offset: 0x1D22771 VA: 0x1D22670
	|-Array.EmptyInternalEnumerator<Detail.Ranking2.Ranking2ScoreDataInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D22870 Offset: 0x1D22971 VA: 0x1D22870
	|-Array.EmptyInternalEnumerator<Detail.Screening.ScreeningContextInfoInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D22AC0 Offset: 0x1D22BC1 VA: 0x1D22AC0
	|-Array.EmptyInternalEnumerator<Detail.Subscriber.SubscriberContentInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D22CC0 Offset: 0x1D22DC1 VA: 0x1D22CC0
	|-Array.EmptyInternalEnumerator<Detail.Subscriber.SubscriberGetContentParamInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D22ED0 Offset: 0x1D22FD1 VA: 0x1D22ED0
	|-Array.EmptyInternalEnumerator<Detail.Subscriber.SubscriberUserStatusInfoInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D230D0 Offset: 0x1D231D1 VA: 0x1D230D0
	|-Array.EmptyInternalEnumerator<Detail.Subscriber.SubscriberUserStatusParamInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D232B0 Offset: 0x1D233B1 VA: 0x1D232B0
	|-Array.EmptyInternalEnumerator<Detail.Utility.IntegerSettings>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D234A0 Offset: 0x1D235A1 VA: 0x1D234A0
	|-Array.EmptyInternalEnumerator<Detail.Utility.UniqueIdInfoInt>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D23690 Offset: 0x1D23791 VA: 0x1D23690
	|-Array.EmptyInternalEnumerator<FacetsChecker.FacetsCompiler.Map>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D23890 Offset: 0x1D23991 VA: 0x1D23890
	|-Array.EmptyInternalEnumerator<MapHistory.ReplayAppearanceMap.Appearance>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D23A70 Offset: 0x1D23B71 VA: 0x1D23A70
	|-Array.EmptyInternalEnumerator<MapHistory.ReplayAppearanceMap.Leaving>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D23C50 Offset: 0x1D23D51 VA: 0x1D23C50
	|-Array.EmptyInternalEnumerator<MapHistory.ReplayUnitMap.Data>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D23E40 Offset: 0x1D23F41 VA: 0x1D23E40
	|-Array.EmptyInternalEnumerator<MapHistory.Rewind.LatestInspectorData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D24030 Offset: 0x1D24131 VA: 0x1D24030
	|-Array.EmptyInternalEnumerator<MapHistory.Rewind.WorkTerrainData>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D24240 Offset: 0x1D24341 VA: 0x1D24240
	|-Array.EmptyInternalEnumerator<MapHistory.RewindUnitMap.Data>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D24420 Offset: 0x1D24521 VA: 0x1D24420
	|-Array.EmptyInternalEnumerator<MapKillBonus.Work.Pos>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D24610 Offset: 0x1D24711 VA: 0x1D24610
	|-Array.EmptyInternalEnumerator<MapSkill.AroundCalculator.Result>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D247F0 Offset: 0x1D248F1 VA: 0x1D247F0
	|-Array.EmptyInternalEnumerator<Nex.ApiCallChecker.Guideline>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D249F0 Offset: 0x1D24AF1 VA: 0x1D249F0
	|-Array.EmptyInternalEnumerator<Ngc.MaskTextSequenceBase.Data>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D24C00 Offset: 0x1D24D01 VA: 0x1D24C00
	|-Array.EmptyInternalEnumerator<TargetPositionCache.CacheCurve.Item>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D24E10 Offset: 0x1D24F11 VA: 0x1D24E10
	|-Array.EmptyInternalEnumerator<TargetPositionCache.CacheEntry.RecordingItem>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1D24FF0 Offset: 0x1D250F1 VA: 0x1D24FF0
	|-Array.EmptyInternalEnumerator<TerrainUtility.TerrainMap.TileCoord>.System.Collections.IEnumerator.Reset
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x263E5F0 Offset: 0x263E6F1 VA: 0x263E5F0
	|-Array.EmptyInternalEnumerator<ArraySegment<byte>>..ctor
	|
	|-RVA: 0x263E7F0 Offset: 0x263E8F1 VA: 0x263E7F0
	|-Array.EmptyInternalEnumerator<AsyncOperationHandle<object>>..ctor
	|
	|-RVA: 0x263E9D0 Offset: 0x263EAD1 VA: 0x263E9D0
	|-Array.EmptyInternalEnumerator<MapDeployTemplate.Queue.Data<object>>..ctor
	|
	|-RVA: 0x263EBC0 Offset: 0x263ECC1 VA: 0x263EBC0
	|-Array.EmptyInternalEnumerator<Nex.DataStore.ParamPool.Data<object>>..ctor
	|
	|-RVA: 0x263EDB0 Offset: 0x263EEB1 VA: 0x263EDB0
	|-Array.EmptyInternalEnumerator<Nex.Screening.ParamPool.Data<object>>..ctor
	|
	|-RVA: 0x263EFB0 Offset: 0x263F0B1 VA: 0x263EFB0
	|-Array.EmptyInternalEnumerator<IntervalTree.Entry<object>>..ctor
	|
	|-RVA: 0x263F1B0 Offset: 0x263F2B1 VA: 0x263F1B0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<ValueTuple<object, int>, object>>..ctor
	|
	|-RVA: 0x263F3B0 Offset: 0x263F4B1 VA: 0x263F3B0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<byte, object>>..ctor
	|
	|-RVA: 0x263F5B0 Offset: 0x263F6B1 VA: 0x263F5B0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<CancellationToken, object>>..ctor
	|
	|-RVA: 0x263F7B0 Offset: 0x263F8B1 VA: 0x263F7B0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<char, object>>..ctor
	|
	|-RVA: 0x263F9B0 Offset: 0x263FAB1 VA: 0x263F9B0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Guid, object>>..ctor
	|
	|-RVA: 0x263FBA0 Offset: 0x263FCA1 VA: 0x263FBA0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, bool>>..ctor
	|
	|-RVA: 0x263FD90 Offset: 0x263FE91 VA: 0x263FD90
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, byte>>..ctor
	|
	|-RVA: 0x263FF80 Offset: 0x2640081 VA: 0x263FF80
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, char>>..ctor
	|
	|-RVA: 0x26401A0 Offset: 0x26402A1 VA: 0x26401A0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, DiagnosticEvent>>..ctor
	|
	|-RVA: 0x2640390 Offset: 0x2640491 VA: 0x2640390
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, int>>..ctor
	|
	|-RVA: 0x2640580 Offset: 0x2640681 VA: 0x2640580
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, Int32Enum>>..ctor
	|
	|-RVA: 0x2640780 Offset: 0x2640881 VA: 0x2640780
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, long>>..ctor
	|
	|-RVA: 0x2640980 Offset: 0x2640A81 VA: 0x2640980
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, MapPos>>..ctor
	|
	|-RVA: 0x2640B80 Offset: 0x2640C81 VA: 0x2640B80
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, object>>..ctor
	|
	|-RVA: 0x2640D70 Offset: 0x2640E71 VA: 0x2640D70
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, uint>>..ctor
	|
	|-RVA: 0x2640F60 Offset: 0x2641061 VA: 0x2640F60
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, AIThink.EnchantThink.SurroundingInfo>>..ctor
	|
	|-RVA: 0x2641150 Offset: 0x2641251 VA: 0x2641150
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, bool>>..ctor
	|
	|-RVA: 0x2641340 Offset: 0x2641441 VA: 0x2641340
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, int>>..ctor
	|
	|-RVA: 0x2641530 Offset: 0x2641631 VA: 0x2641530
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, Int32Enum>>..ctor
	|
	|-RVA: 0x2641730 Offset: 0x2641831 VA: 0x2641730
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, object>>..ctor
	|
	|-RVA: 0x2641930 Offset: 0x2641A31 VA: 0x2641930
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<long, object>>..ctor
	|
	|-RVA: 0x2641B30 Offset: 0x2641C31 VA: 0x2641B30
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<MapPos, int>>..ctor
	|
	|-RVA: 0x2641D40 Offset: 0x2641E41 VA: 0x2641D40
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, AsyncOperationHandle<object>>>..ctor
	|
	|-RVA: 0x2641F50 Offset: 0x2642051 VA: 0x2641F50
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, AsyncOperationHandle>>..ctor
	|
	|-RVA: 0x2642150 Offset: 0x2642251 VA: 0x2642150
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, bool>>..ctor
	|
	|-RVA: 0x2642350 Offset: 0x2642451 VA: 0x2642350
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, byte>>..ctor
	|
	|-RVA: 0x2642550 Offset: 0x2642651 VA: 0x2642550
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, int>>..ctor
	|
	|-RVA: 0x2642750 Offset: 0x2642851 VA: 0x2642750
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Int32Enum>>..ctor
	|
	|-RVA: 0x2642950 Offset: 0x2642A51 VA: 0x2642950
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, IntPtr>>..ctor
	|
	|-RVA: 0x2642B50 Offset: 0x2642C51 VA: 0x2642B50
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, object>>..ctor
	|
	|-RVA: 0x2642D50 Offset: 0x2642E51 VA: 0x2642D50
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Playable>>..ctor
	|
	|-RVA: 0x2642F50 Offset: 0x2643051 VA: 0x2642F50
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, ResourceLocator>>..ctor
	|
	|-RVA: 0x2643150 Offset: 0x2643251 VA: 0x2643150
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, float>>..ctor
	|
	|-RVA: 0x2643350 Offset: 0x2643451 VA: 0x2643350
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, ushort>>..ctor
	|
	|-RVA: 0x2643550 Offset: 0x2643651 VA: 0x2643550
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, GameVariable.Value>>..ctor
	|
	|-RVA: 0x2643760 Offset: 0x2643861 VA: 0x2643760
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<sbyte, DataStoreRatingInfo>>..ctor
	|
	|-RVA: 0x2643960 Offset: 0x2643A61 VA: 0x2643960
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<sbyte, object>>..ctor
	|
	|-RVA: 0x2643B50 Offset: 0x2643C51 VA: 0x2643B50
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<ushort, int>>..ctor
	|
	|-RVA: 0x2643D40 Offset: 0x2643E41 VA: 0x2643D40
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<uint, int>>..ctor
	|
	|-RVA: 0x2643F40 Offset: 0x2644041 VA: 0x2643F40
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<uint, object>>..ctor
	|
	|-RVA: 0x2644150 Offset: 0x2644251 VA: 0x2644150
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<ulong, Friend>>..ctor
	|
	|-RVA: 0x2644350 Offset: 0x2644451 VA: 0x2644350
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<ulong, Int32Enum>>..ctor
	|
	|-RVA: 0x2644550 Offset: 0x2644651 VA: 0x2644550
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<ulong, object>>..ctor
	|
	|-RVA: 0x2644750 Offset: 0x2644851 VA: 0x2644750
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Vector3, int>>..ctor
	|
	|-RVA: 0x2644960 Offset: 0x2644A61 VA: 0x2644960
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<XPathNodeRef, XPathNodeRef>>..ctor
	|
	|-RVA: 0x2644B60 Offset: 0x2644C61 VA: 0x2644B60
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<TerrainUtility.TerrainMap.TileCoord, object>>..ctor
	|
	|-RVA: 0x2644D50 Offset: 0x2644E51 VA: 0x2644D50
	|-Array.EmptyInternalEnumerator<PriorityQueue.IndexedItem<object>>..ctor
	|
	|-RVA: 0x2644F50 Offset: 0x2645051 VA: 0x2644F50
	|-Array.EmptyInternalEnumerator<KeyValuePair<ValueTuple<object, int>, object>>..ctor
	|
	|-RVA: 0x2645140 Offset: 0x2645241 VA: 0x2645140
	|-Array.EmptyInternalEnumerator<KeyValuePair<byte, object>>..ctor
	|
	|-RVA: 0x2645330 Offset: 0x2645431 VA: 0x2645330
	|-Array.EmptyInternalEnumerator<KeyValuePair<CancellationToken, object>>..ctor
	|
	|-RVA: 0x2645520 Offset: 0x2645621 VA: 0x2645520
	|-Array.EmptyInternalEnumerator<KeyValuePair<char, object>>..ctor
	|
	|-RVA: 0x2645710 Offset: 0x2645811 VA: 0x2645710
	|-Array.EmptyInternalEnumerator<KeyValuePair<DateTime, object>>..ctor
	|
	|-RVA: 0x2645910 Offset: 0x2645A11 VA: 0x2645910
	|-Array.EmptyInternalEnumerator<KeyValuePair<Guid, object>>..ctor
	|
	|-RVA: 0x2645AF0 Offset: 0x2645BF1 VA: 0x2645AF0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, bool>>..ctor
	|
	|-RVA: 0x2645CD0 Offset: 0x2645DD1 VA: 0x2645CD0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, byte>>..ctor
	|
	|-RVA: 0x2645EB0 Offset: 0x2645FB1 VA: 0x2645EB0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, char>>..ctor
	|
	|-RVA: 0x26460C0 Offset: 0x26461C1 VA: 0x26460C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, DiagnosticEvent>>..ctor
	|
	|-RVA: 0x26462A0 Offset: 0x26463A1 VA: 0x26462A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, int>>..ctor
	|
	|-RVA: 0x2646480 Offset: 0x2646581 VA: 0x2646480
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, Int32Enum>>..ctor
	|
	|-RVA: 0x2646670 Offset: 0x2646771 VA: 0x2646670
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, long>>..ctor
	|
	|-RVA: 0x2646860 Offset: 0x2646961 VA: 0x2646860
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, MapPos>>..ctor
	|
	|-RVA: 0x2646A50 Offset: 0x2646B51 VA: 0x2646A50
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x2646C30 Offset: 0x2646D31 VA: 0x2646C30
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, uint>>..ctor
	|
	|-RVA: 0x2646E10 Offset: 0x2646F11 VA: 0x2646E10
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, AIThink.EnchantThink.SurroundingInfo>>..ctor
	|
	|-RVA: 0x2646FF0 Offset: 0x26470F1 VA: 0x2646FF0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, bool>>..ctor
	|
	|-RVA: 0x26471D0 Offset: 0x26472D1 VA: 0x26471D0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, int>>..ctor
	|
	|-RVA: 0x26473B0 Offset: 0x26474B1 VA: 0x26473B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, Int32Enum>>..ctor
	|
	|-RVA: 0x26475A0 Offset: 0x26476A1 VA: 0x26475A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, object>>..ctor
	|
	|-RVA: 0x2647790 Offset: 0x2647891 VA: 0x2647790
	|-Array.EmptyInternalEnumerator<KeyValuePair<long, object>>..ctor
	|
	|-RVA: 0x2647980 Offset: 0x2647A81 VA: 0x2647980
	|-Array.EmptyInternalEnumerator<KeyValuePair<MapPos, int>>..ctor
	|
	|-RVA: 0x2647B80 Offset: 0x2647C81 VA: 0x2647B80
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, AsyncOperationHandle<object>>>..ctor
	|
	|-RVA: 0x2647D80 Offset: 0x2647E81 VA: 0x2647D80
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, ValueTuple<int, DateTime, object>>>..ctor
	|
	|-RVA: 0x2647F80 Offset: 0x2648081 VA: 0x2647F80
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, AsyncOperationHandle>>..ctor
	|
	|-RVA: 0x2648170 Offset: 0x2648271 VA: 0x2648170
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, bool>>..ctor
	|
	|-RVA: 0x2648360 Offset: 0x2648461 VA: 0x2648360
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, byte>>..ctor
	|
	|-RVA: 0x2648550 Offset: 0x2648651 VA: 0x2648550
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, int>>..ctor
	|
	|-RVA: 0x2648740 Offset: 0x2648841 VA: 0x2648740
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Int32Enum>>..ctor
	|
	|-RVA: 0x2648930 Offset: 0x2648A31 VA: 0x2648930
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, IntPtr>>..ctor
	|
	|-RVA: 0x2648B20 Offset: 0x2648C21 VA: 0x2648B20
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x2648D20 Offset: 0x2648E21 VA: 0x2648D20
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Playable>>..ctor
	|
	|-RVA: 0x2648F20 Offset: 0x2649021 VA: 0x2648F20
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, ResourceLocator>>..ctor
	|
	|-RVA: 0x2649110 Offset: 0x2649211 VA: 0x2649110
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, float>>..ctor
	|
	|-RVA: 0x2649300 Offset: 0x2649401 VA: 0x2649300
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, ushort>>..ctor
	|
	|-RVA: 0x2649500 Offset: 0x2649601 VA: 0x2649500
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, GameVariable.Value>>..ctor
	|
	|-RVA: 0x2649700 Offset: 0x2649801 VA: 0x2649700
	|-Array.EmptyInternalEnumerator<KeyValuePair<sbyte, DataStoreRatingInfo>>..ctor
	|
	|-RVA: 0x26498F0 Offset: 0x26499F1 VA: 0x26498F0
	|-Array.EmptyInternalEnumerator<KeyValuePair<sbyte, object>>..ctor
	|
	|-RVA: 0x2649AD0 Offset: 0x2649BD1 VA: 0x2649AD0
	|-Array.EmptyInternalEnumerator<KeyValuePair<ushort, int>>..ctor
	|
	|-RVA: 0x2649CB0 Offset: 0x2649DB1 VA: 0x2649CB0
	|-Array.EmptyInternalEnumerator<KeyValuePair<uint, int>>..ctor
	|
	|-RVA: 0x2649EA0 Offset: 0x2649FA1 VA: 0x2649EA0
	|-Array.EmptyInternalEnumerator<KeyValuePair<uint, object>>..ctor
	|
	|-RVA: 0x264A0B0 Offset: 0x264A1B1 VA: 0x264A0B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<ulong, Friend>>..ctor
	|
	|-RVA: 0x264A2A0 Offset: 0x264A3A1 VA: 0x264A2A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<ulong, Int32Enum>>..ctor
	|
	|-RVA: 0x264A490 Offset: 0x264A591 VA: 0x264A490
	|-Array.EmptyInternalEnumerator<KeyValuePair<ulong, object>>..ctor
	|
	|-RVA: 0x264A680 Offset: 0x264A781 VA: 0x264A680
	|-Array.EmptyInternalEnumerator<KeyValuePair<Vector3, int>>..ctor
	|
	|-RVA: 0x264A880 Offset: 0x264A981 VA: 0x264A880
	|-Array.EmptyInternalEnumerator<KeyValuePair<XPathNodeRef, XPathNodeRef>>..ctor
	|
	|-RVA: 0x264AA70 Offset: 0x264AB71 VA: 0x264AA70
	|-Array.EmptyInternalEnumerator<KeyValuePair<TerrainUtility.TerrainMap.TileCoord, object>>..ctor
	|
	|-RVA: 0x264AC60 Offset: 0x264AD61 VA: 0x264AC60
	|-Array.EmptyInternalEnumerator<NativeArray<PreTile>>..ctor
	|
	|-RVA: 0x264AE60 Offset: 0x264AF61 VA: 0x264AE60
	|-Array.EmptyInternalEnumerator<CommonBattleSequence.Reliance<object>>..ctor
	|
	|-RVA: 0x264B050 Offset: 0x264B151 VA: 0x264B050
	|-Array.EmptyInternalEnumerator<RenderGraphResourcePool.ResourceLogInfo<object>>..ctor
	|
	|-RVA: 0x264B250 Offset: 0x264B351 VA: 0x264B250
	|-Array.EmptyInternalEnumerator<HashSet.Slot<ValueTuple<object, int>>>..ctor
	|
	|-RVA: 0x264B450 Offset: 0x264B551 VA: 0x264B450
	|-Array.EmptyInternalEnumerator<HashSet.Slot<AsyncOperationHandle>>..ctor
	|
	|-RVA: 0x264B640 Offset: 0x264B741 VA: 0x264B640
	|-Array.EmptyInternalEnumerator<HashSet.Slot<int>>..ctor
	|
	|-RVA: 0x264B830 Offset: 0x264B931 VA: 0x264B830
	|-Array.EmptyInternalEnumerator<HashSet.Slot<Int32Enum>>..ctor
	|
	|-RVA: 0x264BA20 Offset: 0x264BB21 VA: 0x264BA20
	|-Array.EmptyInternalEnumerator<Set.Slot<Int32Enum>>..ctor
	|
	|-RVA: 0x264BC10 Offset: 0x264BD11 VA: 0x264BC10
	|-Array.EmptyInternalEnumerator<HashSet.Slot<MapPos>>..ctor
	|
	|-RVA: 0x264BE00 Offset: 0x264BF01 VA: 0x264BE00
	|-Array.EmptyInternalEnumerator<HashSet.Slot<object>>..ctor
	|
	|-RVA: 0x264C000 Offset: 0x264C101 VA: 0x264C000
	|-Array.EmptyInternalEnumerator<Set.Slot<object>>..ctor
	|
	|-RVA: 0x264C1F0 Offset: 0x264C2F1 VA: 0x264C1F0
	|-Array.EmptyInternalEnumerator<HashSet.Slot<uint>>..ctor
	|
	|-RVA: 0x264C3E0 Offset: 0x264C4E1 VA: 0x264C3E0
	|-Array.EmptyInternalEnumerator<HashSet.Slot<ulong>>..ctor
	|
	|-RVA: 0x264C5E0 Offset: 0x264C6E1 VA: 0x264C5E0
	|-Array.EmptyInternalEnumerator<Set.Slot<Vector3>>..ctor
	|
	|-RVA: 0x264C7E0 Offset: 0x264C8E1 VA: 0x264C7E0
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<Color32>>..ctor
	|
	|-RVA: 0x264C9F0 Offset: 0x264CAF1 VA: 0x264C9F0
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<HighlightState>>..ctor
	|
	|-RVA: 0x264CBF0 Offset: 0x264CCF1 VA: 0x264CBF0
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<int>>..ctor
	|
	|-RVA: 0x264CDF0 Offset: 0x264CEF1 VA: 0x264CDF0
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<Int32Enum>>..ctor
	|
	|-RVA: 0x264D050 Offset: 0x264D151 VA: 0x264D050
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<MaterialReference>>..ctor
	|
	|-RVA: 0x264D260 Offset: 0x264D361 VA: 0x264D260
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<object>>..ctor
	|
	|-RVA: 0x264D460 Offset: 0x264D561 VA: 0x264D460
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<float>>..ctor
	|
	|-RVA: 0x264D670 Offset: 0x264D771 VA: 0x264D670
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<WordWrapState>>..ctor
	|
	|-RVA: 0x264D860 Offset: 0x264D961 VA: 0x264D860
	|-Array.EmptyInternalEnumerator<TimeInterval<object>>..ctor
	|
	|-RVA: 0x264DA60 Offset: 0x264DB61 VA: 0x264DA60
	|-Array.EmptyInternalEnumerator<Timestamped<object>>..ctor
	|
	|-RVA: 0x264DC50 Offset: 0x264DD51 VA: 0x264DC50
	|-Array.EmptyInternalEnumerator<UniTask<object>>..ctor
	|
	|-RVA: 0x264DE40 Offset: 0x264DF41 VA: 0x264DE40
	|-Array.EmptyInternalEnumerator<ValueTuple<ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x264E040 Offset: 0x264E141 VA: 0x264E040
	|-Array.EmptyInternalEnumerator<ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x264E240 Offset: 0x264E341 VA: 0x264E240
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, UniTask<object>>>..ctor
	|
	|-RVA: 0x264E440 Offset: 0x264E541 VA: 0x264E440
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>..ctor
	|
	|-RVA: 0x264E650 Offset: 0x264E751 VA: 0x264E650
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>..ctor
	|
	|-RVA: 0x264E860 Offset: 0x264E961 VA: 0x264E860
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>..ctor
	|
	|-RVA: 0x264EA50 Offset: 0x264EB51 VA: 0x264EA50
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>..ctor
	|
	|-RVA: 0x264EC40 Offset: 0x264ED41 VA: 0x264EC40
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>..ctor
	|
	|-RVA: 0x264EE60 Offset: 0x264EF61 VA: 0x264EE60
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>..ctor
	|
	|-RVA: 0x264F050 Offset: 0x264F151 VA: 0x264F050
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>..ctor
	|
	|-RVA: 0x264F260 Offset: 0x264F361 VA: 0x264F260
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>..ctor
	|
	|-RVA: 0x264F470 Offset: 0x264F571 VA: 0x264F470
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>..ctor
	|
	|-RVA: 0x264F670 Offset: 0x264F771 VA: 0x264F670
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>..ctor
	|
	|-RVA: 0x264F880 Offset: 0x264F981 VA: 0x264F880
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>..ctor
	|
	|-RVA: 0x264FA90 Offset: 0x264FB91 VA: 0x264FA90
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x264FCA0 Offset: 0x264FDA1 VA: 0x264FCA0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>..ctor
	|
	|-RVA: 0x264FEB0 Offset: 0x264FFB1 VA: 0x264FEB0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>..ctor
	|
	|-RVA: 0x26500B0 Offset: 0x26501B1 VA: 0x26500B0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>..ctor
	|
	|-RVA: 0x26502C0 Offset: 0x26503C1 VA: 0x26502C0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>..ctor
	|
	|-RVA: 0x26504B0 Offset: 0x26505B1 VA: 0x26504B0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>..ctor
	|
	|-RVA: 0x26506C0 Offset: 0x26507C1 VA: 0x26506C0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>..ctor
	|
	|-RVA: 0x26508C0 Offset: 0x26509C1 VA: 0x26508C0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>..ctor
	|
	|-RVA: 0x2650AD0 Offset: 0x2650BD1 VA: 0x2650AD0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>..ctor
	|
	|-RVA: 0x2650CE0 Offset: 0x2650DE1 VA: 0x2650CE0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>..ctor
	|
	|-RVA: 0x2650EF0 Offset: 0x2650FF1 VA: 0x2650EF0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>..ctor
	|
	|-RVA: 0x2651100 Offset: 0x2651201 VA: 0x2651100
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>..ctor
	|
	|-RVA: 0x2651320 Offset: 0x2651421 VA: 0x2651320
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>..ctor
	|
	|-RVA: 0x2651570 Offset: 0x2651671 VA: 0x2651570
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>..ctor
	|
	|-RVA: 0x26517C0 Offset: 0x26518C1 VA: 0x26517C0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>..ctor
	|
	|-RVA: 0x2651A20 Offset: 0x2651B21 VA: 0x2651A20
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>..ctor
	|
	|-RVA: 0x2651C10 Offset: 0x2651D11 VA: 0x2651C10
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>..ctor
	|
	|-RVA: 0x2651E00 Offset: 0x2651F01 VA: 0x2651E00
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>..ctor
	|
	|-RVA: 0x2652010 Offset: 0x2652111 VA: 0x2652010
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>..ctor
	|
	|-RVA: 0x2652200 Offset: 0x2652301 VA: 0x2652200
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>..ctor
	|
	|-RVA: 0x2652400 Offset: 0x2652501 VA: 0x2652400
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>..ctor
	|
	|-RVA: 0x2652610 Offset: 0x2652711 VA: 0x2652610
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>..ctor
	|
	|-RVA: 0x2652810 Offset: 0x2652911 VA: 0x2652810
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>..ctor
	|
	|-RVA: 0x2652A20 Offset: 0x2652B21 VA: 0x2652A20
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>..ctor
	|
	|-RVA: 0x2652C30 Offset: 0x2652D31 VA: 0x2652C30
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x2652E30 Offset: 0x2652F31 VA: 0x2652E30
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>..ctor
	|
	|-RVA: 0x2653030 Offset: 0x2653131 VA: 0x2653030
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>..ctor
	|
	|-RVA: 0x2653230 Offset: 0x2653331 VA: 0x2653230
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>..ctor
	|
	|-RVA: 0x2653440 Offset: 0x2653541 VA: 0x2653440
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>..ctor
	|
	|-RVA: 0x2653630 Offset: 0x2653731 VA: 0x2653630
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>..ctor
	|
	|-RVA: 0x2653830 Offset: 0x2653931 VA: 0x2653830
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>..ctor
	|
	|-RVA: 0x2653A40 Offset: 0x2653B41 VA: 0x2653A40
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>..ctor
	|
	|-RVA: 0x2653C40 Offset: 0x2653D41 VA: 0x2653C40
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>..ctor
	|
	|-RVA: 0x2653E50 Offset: 0x2653F51 VA: 0x2653E50
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>..ctor
	|
	|-RVA: 0x2654060 Offset: 0x2654161 VA: 0x2654060
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>..ctor
	|
	|-RVA: 0x2654280 Offset: 0x2654381 VA: 0x2654280
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x2654490 Offset: 0x2654591 VA: 0x2654490
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>..ctor
	|
	|-RVA: 0x26546E0 Offset: 0x26547E1 VA: 0x26546E0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x26548F0 Offset: 0x26549F1 VA: 0x26548F0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>..ctor
	|
	|-RVA: 0x2654B70 Offset: 0x2654C71 VA: 0x2654B70
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x2654D90 Offset: 0x2654E91 VA: 0x2654D90
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>..ctor
	|
	|-RVA: 0x2655020 Offset: 0x2655121 VA: 0x2655020
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x2655270 Offset: 0x2655371 VA: 0x2655270
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>..ctor
	|
	|-RVA: 0x2655520 Offset: 0x2655621 VA: 0x2655520
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x2655770 Offset: 0x2655871 VA: 0x2655770
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>..ctor
	|
	|-RVA: 0x2655950 Offset: 0x2655A51 VA: 0x2655950
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>..ctor
	|
	|-RVA: 0x2655B30 Offset: 0x2655C31 VA: 0x2655B30
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>..ctor
	|
	|-RVA: 0x2655D40 Offset: 0x2655E41 VA: 0x2655D40
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>..ctor
	|
	|-RVA: 0x2655F20 Offset: 0x2656021 VA: 0x2655F20
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>..ctor
	|
	|-RVA: 0x2656130 Offset: 0x2656231 VA: 0x2656130
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>..ctor
	|
	|-RVA: 0x2656330 Offset: 0x2656431 VA: 0x2656330
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>..ctor
	|
	|-RVA: 0x2656520 Offset: 0x2656621 VA: 0x2656520
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>..ctor
	|
	|-RVA: 0x2656720 Offset: 0x2656821 VA: 0x2656720
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>..ctor
	|
	|-RVA: 0x2656920 Offset: 0x2656A21 VA: 0x2656920
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x2656B30 Offset: 0x2656C31 VA: 0x2656B30
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>..ctor
	|
	|-RVA: 0x2656D40 Offset: 0x2656E41 VA: 0x2656D40
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>..ctor
	|
	|-RVA: 0x2656F30 Offset: 0x2657031 VA: 0x2656F30
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>..ctor
	|
	|-RVA: 0x2657130 Offset: 0x2657231 VA: 0x2657130
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>..ctor
	|
	|-RVA: 0x2657310 Offset: 0x2657411 VA: 0x2657310
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>..ctor
	|
	|-RVA: 0x2657510 Offset: 0x2657611 VA: 0x2657510
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>..ctor
	|
	|-RVA: 0x2657710 Offset: 0x2657811 VA: 0x2657710
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>..ctor
	|
	|-RVA: 0x2657920 Offset: 0x2657A21 VA: 0x2657920
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>..ctor
	|
	|-RVA: 0x2657B20 Offset: 0x2657C21 VA: 0x2657B20
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>..ctor
	|
	|-RVA: 0x2657D20 Offset: 0x2657E21 VA: 0x2657D20
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>..ctor
	|
	|-RVA: 0x2657F30 Offset: 0x2658031 VA: 0x2657F30
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x2658140 Offset: 0x2658241 VA: 0x2658140
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>..ctor
	|
	|-RVA: 0x2658390 Offset: 0x2658491 VA: 0x2658390
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x26585A0 Offset: 0x26586A1 VA: 0x26585A0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>..ctor
	|
	|-RVA: 0x2658800 Offset: 0x2658901 VA: 0x2658800
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x2658A10 Offset: 0x2658B11 VA: 0x2658A10
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>..ctor
	|
	|-RVA: 0x2658CA0 Offset: 0x2658DA1 VA: 0x2658CA0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x2658EC0 Offset: 0x2658FC1 VA: 0x2658EC0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>..ctor
	|
	|-RVA: 0x2659160 Offset: 0x2659261 VA: 0x2659160
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x26593B0 Offset: 0x26594B1 VA: 0x26593B0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>..ctor
	|
	|-RVA: 0x26595C0 Offset: 0x26596C1 VA: 0x26595C0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x26597D0 Offset: 0x26598D1 VA: 0x26597D0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..ctor
	|
	|-RVA: 0x26599C0 Offset: 0x2659AC1 VA: 0x26599C0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>..ctor
	|
	|-RVA: 0x2659BB0 Offset: 0x2659CB1 VA: 0x2659BB0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, bool>>>..ctor
	|
	|-RVA: 0x2659DB0 Offset: 0x2659EB1 VA: 0x2659DB0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, Bounds>>>..ctor
	|
	|-RVA: 0x2659FA0 Offset: 0x265A0A1 VA: 0x2659FA0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, byte>>>..ctor
	|
	|-RVA: 0x265A1A0 Offset: 0x265A2A1 VA: 0x265A1A0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, Color>>>..ctor
	|
	|-RVA: 0x265A3A0 Offset: 0x265A4A1 VA: 0x265A3A0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, double>>>..ctor
	|
	|-RVA: 0x265A590 Offset: 0x265A691 VA: 0x265A590
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, int>>>..ctor
	|
	|-RVA: 0x1CF0E50 Offset: 0x1CF0F51 VA: 0x1CF0E50
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, long>>>..ctor
	|
	|-RVA: 0x1CF1050 Offset: 0x1CF1151 VA: 0x1CF1050
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x1CF1250 Offset: 0x1CF1351 VA: 0x1CF1250
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, Quaternion>>>..ctor
	|
	|-RVA: 0x1CF1450 Offset: 0x1CF1551 VA: 0x1CF1450
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, Rect>>>..ctor
	|
	|-RVA: 0x1CF1640 Offset: 0x1CF1741 VA: 0x1CF1640
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, float>>>..ctor
	|
	|-RVA: 0x1CF1840 Offset: 0x1CF1941 VA: 0x1CF1840
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, UniTask>>>..ctor
	|
	|-RVA: 0x1CF1A30 Offset: 0x1CF1B31 VA: 0x1CF1A30
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, Unit>>>..ctor
	|
	|-RVA: 0x1CF1C20 Offset: 0x1CF1D21 VA: 0x1CF1C20
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, Vector2>>>..ctor
	|
	|-RVA: 0x1CF1E20 Offset: 0x1CF1F21 VA: 0x1CF1E20
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, Vector3>>>..ctor
	|
	|-RVA: 0x1CF2020 Offset: 0x1CF2121 VA: 0x1CF2020
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, Vector4>>>..ctor
	|
	|-RVA: 0x1CF2220 Offset: 0x1CF2321 VA: 0x1CF2220
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<int, object>>>..ctor
	|
	|-RVA: 0x1CF2420 Offset: 0x1CF2521 VA: 0x1CF2420
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<object, object>>>..ctor
	|
	|-RVA: 0x1CF2630 Offset: 0x1CF2731 VA: 0x1CF2630
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x1CF2830 Offset: 0x1CF2931 VA: 0x1CF2830
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<object, object, object>>>..ctor
	|
	|-RVA: 0x1CF2A50 Offset: 0x1CF2B51 VA: 0x1CF2A50
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x1CF2C60 Offset: 0x1CF2D61 VA: 0x1CF2C60
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<object, object, object, object>>>..ctor
	|
	|-RVA: 0x1CF2EB0 Offset: 0x1CF2FB1 VA: 0x1CF2EB0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x1CF30C0 Offset: 0x1CF31C1 VA: 0x1CF30C0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>..ctor
	|
	|-RVA: 0x1CF3340 Offset: 0x1CF3441 VA: 0x1CF3340
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x1CF3550 Offset: 0x1CF3651 VA: 0x1CF3550
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>..ctor
	|
	|-RVA: 0x1CF37E0 Offset: 0x1CF38E1 VA: 0x1CF37E0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x1CF3A00 Offset: 0x1CF3B01 VA: 0x1CF3A00
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>..ctor
	|
	|-RVA: 0x1CF3CB0 Offset: 0x1CF3DB1 VA: 0x1CF3CB0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x1CF3EC0 Offset: 0x1CF3FC1 VA: 0x1CF3EC0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..ctor
	|
	|-RVA: 0x1CF40A0 Offset: 0x1CF41A1 VA: 0x1CF40A0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, AsyncUnit>>..ctor
	|
	|-RVA: 0x1CF4280 Offset: 0x1CF4381 VA: 0x1CF4280
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, bool>>..ctor
	|
	|-RVA: 0x1CF4490 Offset: 0x1CF4591 VA: 0x1CF4490
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Bounds>>..ctor
	|
	|-RVA: 0x1CF4670 Offset: 0x1CF4771 VA: 0x1CF4670
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, byte>>..ctor
	|
	|-RVA: 0x1CF4870 Offset: 0x1CF4971 VA: 0x1CF4870
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Color>>..ctor
	|
	|-RVA: 0x1CF4A60 Offset: 0x1CF4B61 VA: 0x1CF4A60
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, double>>..ctor
	|
	|-RVA: 0x1CF4C40 Offset: 0x1CF4D41 VA: 0x1CF4C40
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, int>>..ctor
	|
	|-RVA: 0x1CF4E30 Offset: 0x1CF4F31 VA: 0x1CF4E30
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, long>>..ctor
	|
	|-RVA: 0x1CF5020 Offset: 0x1CF5121 VA: 0x1CF5020
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x1CF5220 Offset: 0x1CF5321 VA: 0x1CF5220
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Quaternion>>..ctor
	|
	|-RVA: 0x1CF5420 Offset: 0x1CF5521 VA: 0x1CF5420
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Rect>>..ctor
	|
	|-RVA: 0x1CF5600 Offset: 0x1CF5701 VA: 0x1CF5600
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, float>>..ctor
	|
	|-RVA: 0x1CF57F0 Offset: 0x1CF58F1 VA: 0x1CF57F0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, UniTask>>..ctor
	|
	|-RVA: 0x1CF59D0 Offset: 0x1CF5AD1 VA: 0x1CF59D0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Unit>>..ctor
	|
	|-RVA: 0x1CF5BC0 Offset: 0x1CF5CC1 VA: 0x1CF5BC0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Vector2>>..ctor
	|
	|-RVA: 0x1CF5DB0 Offset: 0x1CF5EB1 VA: 0x1CF5DB0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Vector3>>..ctor
	|
	|-RVA: 0x1CF5FB0 Offset: 0x1CF60B1 VA: 0x1CF5FB0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Vector4>>..ctor
	|
	|-RVA: 0x1CF6190 Offset: 0x1CF6291 VA: 0x1CF6190
	|-Array.EmptyInternalEnumerator<ValueTuple<int, bool>>..ctor
	|
	|-RVA: 0x1CF63A0 Offset: 0x1CF64A1 VA: 0x1CF63A0
	|-Array.EmptyInternalEnumerator<ValueTuple<int, Bounds>>..ctor
	|
	|-RVA: 0x1CF6580 Offset: 0x1CF6681 VA: 0x1CF6580
	|-Array.EmptyInternalEnumerator<ValueTuple<int, byte>>..ctor
	|
	|-RVA: 0x1CF6780 Offset: 0x1CF6881 VA: 0x1CF6780
	|-Array.EmptyInternalEnumerator<ValueTuple<int, Color>>..ctor
	|
	|-RVA: 0x1CF6970 Offset: 0x1CF6A71 VA: 0x1CF6970
	|-Array.EmptyInternalEnumerator<ValueTuple<int, double>>..ctor
	|
	|-RVA: 0x1CF6B50 Offset: 0x1CF6C51 VA: 0x1CF6B50
	|-Array.EmptyInternalEnumerator<ValueTuple<int, int>>..ctor
	|
	|-RVA: 0x1CF6D40 Offset: 0x1CF6E41 VA: 0x1CF6D40
	|-Array.EmptyInternalEnumerator<ValueTuple<int, long>>..ctor
	|
	|-RVA: 0x1CF6F30 Offset: 0x1CF7031 VA: 0x1CF6F30
	|-Array.EmptyInternalEnumerator<ValueTuple<int, object>>..ctor
	|
	|-RVA: 0x1CF7130 Offset: 0x1CF7231 VA: 0x1CF7130
	|-Array.EmptyInternalEnumerator<ValueTuple<int, Quaternion>>..ctor
	|
	|-RVA: 0x1CF7330 Offset: 0x1CF7431 VA: 0x1CF7330
	|-Array.EmptyInternalEnumerator<ValueTuple<int, Rect>>..ctor
	|
	|-RVA: 0x1CF7510 Offset: 0x1CF7611 VA: 0x1CF7510
	|-Array.EmptyInternalEnumerator<ValueTuple<int, float>>..ctor
	|
	|-RVA: 0x1CF76F0 Offset: 0x1CF77F1 VA: 0x1CF76F0
	|-Array.EmptyInternalEnumerator<ValueTuple<int, Unit>>..ctor
	|
	|-RVA: 0x1CF78E0 Offset: 0x1CF79E1 VA: 0x1CF78E0
	|-Array.EmptyInternalEnumerator<ValueTuple<int, Vector2>>..ctor
	|
	|-RVA: 0x1CF7AD0 Offset: 0x1CF7BD1 VA: 0x1CF7AD0
	|-Array.EmptyInternalEnumerator<ValueTuple<int, Vector3>>..ctor
	|
	|-RVA: 0x1CF7CD0 Offset: 0x1CF7DD1 VA: 0x1CF7CD0
	|-Array.EmptyInternalEnumerator<ValueTuple<int, Vector4>>..ctor
	|
	|-RVA: 0x1CF7EB0 Offset: 0x1CF7FB1 VA: 0x1CF7EB0
	|-Array.EmptyInternalEnumerator<ValueTuple<Int32Enum, int>>..ctor
	|
	|-RVA: 0x1CF80B0 Offset: 0x1CF81B1 VA: 0x1CF80B0
	|-Array.EmptyInternalEnumerator<ValueTuple<object, ValueTuple<object, int>>>..ctor
	|
	|-RVA: 0x1CF82A0 Offset: 0x1CF83A1 VA: 0x1CF82A0
	|-Array.EmptyInternalEnumerator<ValueTuple<object, int>>..ctor
	|
	|-RVA: 0x1CF8490 Offset: 0x1CF8591 VA: 0x1CF8490
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x1CF8680 Offset: 0x1CF8781 VA: 0x1CF8680
	|-Array.EmptyInternalEnumerator<ValueTuple<object, float>>..ctor
	|
	|-RVA: 0x1CF8870 Offset: 0x1CF8971 VA: 0x1CF8870
	|-Array.EmptyInternalEnumerator<ValueTuple<Vector3, float>>..ctor
	|
	|-RVA: 0x1CF8A80 Offset: 0x1CF8B81 VA: 0x1CF8A80
	|-Array.EmptyInternalEnumerator<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x1CF8C70 Offset: 0x1CF8D71 VA: 0x1CF8C70
	|-Array.EmptyInternalEnumerator<ValueTuple<object, Int32Enum, int>>..ctor
	|
	|-RVA: 0x1CF8E70 Offset: 0x1CF8F71 VA: 0x1CF8E70
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object, object>>..ctor
	|
	|-RVA: 0x1CF9080 Offset: 0x1CF9181 VA: 0x1CF9080
	|-Array.EmptyInternalEnumerator<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x1CF9280 Offset: 0x1CF9381 VA: 0x1CF9280
	|-Array.EmptyInternalEnumerator<ValueTuple<object, int, int, int>>..ctor
	|
	|-RVA: 0x1CF9480 Offset: 0x1CF9581 VA: 0x1CF9480
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object, object, object>>..ctor
	|
	|-RVA: 0x1CF96D0 Offset: 0x1CF97D1 VA: 0x1CF96D0
	|-Array.EmptyInternalEnumerator<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x1CF98E0 Offset: 0x1CF99E1 VA: 0x1CF98E0
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object, object, object, object>>..ctor
	|
	|-RVA: 0x1CF9B40 Offset: 0x1CF9C41 VA: 0x1CF9B40
	|-Array.EmptyInternalEnumerator<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x1CF9D50 Offset: 0x1CF9E51 VA: 0x1CF9D50
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object, object, object, object, object>>..ctor
	|
	|-RVA: 0x1CF9FE0 Offset: 0x1CFA0E1 VA: 0x1CF9FE0
	|-Array.EmptyInternalEnumerator<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>..ctor
	|
	|-RVA: 0x1CFA1F0 Offset: 0x1CFA2F1 VA: 0x1CFA1F0
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object, object, object, object, object, object>>..ctor
	|
	|-RVA: 0x1CFA490 Offset: 0x1CFA591 VA: 0x1CFA490
	|-Array.EmptyInternalEnumerator<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x1CFA6A0 Offset: 0x1CFA7A1 VA: 0x1CFA6A0
	|-Array.EmptyInternalEnumerator<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>..ctor
	|
	|-RVA: 0x1CFA880 Offset: 0x1CFA981 VA: 0x1CFA880
	|-Array.EmptyInternalEnumerator<AnimatorClipInfo>..ctor
	|
	|-RVA: 0x1CFAA80 Offset: 0x1CFAB81 VA: 0x1CFAA80
	|-Array.EmptyInternalEnumerator<AsyncOperationHandle>..ctor
	|
	|-RVA: 0x1CFAC60 Offset: 0x1CFAD61 VA: 0x1CFAC60
	|-Array.EmptyInternalEnumerator<AsyncUnit>..ctor
	|
	|-RVA: 0x1CFAE50 Offset: 0x1CFAF51 VA: 0x1CFAE50
	|-Array.EmptyInternalEnumerator<BatchVisibility>..ctor
	|
	|-RVA: 0x1CFB050 Offset: 0x1CFB151 VA: 0x1CFB050
	|-Array.EmptyInternalEnumerator<BoneWeight>..ctor
	|
	|-RVA: 0x1CFB230 Offset: 0x1CFB331 VA: 0x1CFB230
	|-Array.EmptyInternalEnumerator<BoneWeight1>..ctor
	|
	|-RVA: 0x1CFB410 Offset: 0x1CFB511 VA: 0x1CFB410
	|-Array.EmptyInternalEnumerator<bool>..ctor
	|
	|-RVA: 0x1CFB610 Offset: 0x1CFB711 VA: 0x1CFB610
	|-Array.EmptyInternalEnumerator<Bounds>..ctor
	|
	|-RVA: 0x1CFB7F0 Offset: 0x1CFB8F1 VA: 0x1CFB7F0
	|-Array.EmptyInternalEnumerator<byte>..ctor
	|
	|-RVA: 0x1CFB9D0 Offset: 0x1CFBAD1 VA: 0x1CFB9D0
	|-Array.EmptyInternalEnumerator<ByteEnum>..ctor
	|
	|-RVA: 0x1CFBBC0 Offset: 0x1CFBCC1 VA: 0x1CFBBC0
	|-Array.EmptyInternalEnumerator<CameraInfo>..ctor
	|
	|-RVA: 0x1CFBDA0 Offset: 0x1CFBEA1 VA: 0x1CFBDA0
	|-Array.EmptyInternalEnumerator<CancellationToken>..ctor
	|
	|-RVA: 0x1CFBFA0 Offset: 0x1CFC0A1 VA: 0x1CFBFA0
	|-Array.EmptyInternalEnumerator<CancellationTokenRegistration>..ctor
	|
	|-RVA: 0x1CFC180 Offset: 0x1CFC281 VA: 0x1CFC180
	|-Array.EmptyInternalEnumerator<char>..ctor
	|
	|-RVA: 0x1CFC380 Offset: 0x1CFC481 VA: 0x1CFC380
	|-Array.EmptyInternalEnumerator<ClusteringData>..ctor
	|
	|-RVA: 0x1CFC590 Offset: 0x1CFC691 VA: 0x1CFC590
	|-Array.EmptyInternalEnumerator<ClusteringProcessorState>..ctor
	|
	|-RVA: 0x1CFC780 Offset: 0x1CFC881 VA: 0x1CFC780
	|-Array.EmptyInternalEnumerator<Color>..ctor
	|
	|-RVA: 0x1CFC960 Offset: 0x1CFCA61 VA: 0x1CFC960
	|-Array.EmptyInternalEnumerator<Color32>..ctor
	|
	|-RVA: 0x1CFCB40 Offset: 0x1CFCC41 VA: 0x1CFCB40
	|-Array.EmptyInternalEnumerator<Color4u8>..ctor
	|
	|-RVA: 0x1CFCDA0 Offset: 0x1CFCEA1 VA: 0x1CFCDA0
	|-Array.EmptyInternalEnumerator<ColorBlock>..ctor
	|
	|-RVA: 0x1CFD030 Offset: 0x1CFD131 VA: 0x1CFD030
	|-Array.EmptyInternalEnumerator<CombineInstance>..ctor
	|
	|-RVA: 0x1CFD220 Offset: 0x1CFD321 VA: 0x1CFD220
	|-Array.EmptyInternalEnumerator<ConstraintSource>..ctor
	|
	|-RVA: 0x1CFD430 Offset: 0x1CFD531 VA: 0x1CFD430
	|-Array.EmptyInternalEnumerator<ContactPoint>..ctor
	|
	|-RVA: 0x1CFD640 Offset: 0x1CFD741 VA: 0x1CFD640
	|-Array.EmptyInternalEnumerator<ContactPoint2D>..ctor
	|
	|-RVA: 0x1CFD840 Offset: 0x1CFD941 VA: 0x1CFD840
	|-Array.EmptyInternalEnumerator<ContourVertex>..ctor
	|
	|-RVA: 0x1CFDA40 Offset: 0x1CFDB41 VA: 0x1CFDA40
	|-Array.EmptyInternalEnumerator<CustomAttributeNamedArgument>..ctor
	|
	|-RVA: 0x1CFDC30 Offset: 0x1CFDD31 VA: 0x1CFDC30
	|-Array.EmptyInternalEnumerator<CustomAttributeTypedArgument>..ctor
	|
	|-RVA: 0x1CFDE30 Offset: 0x1CFDF31 VA: 0x1CFDE30
	|-Array.EmptyInternalEnumerator<DataStoreRatingInfo>..ctor
	|
	|-RVA: 0x1CFE010 Offset: 0x1CFE111 VA: 0x1CFE010
	|-Array.EmptyInternalEnumerator<DataStoreResult>..ctor
	|
	|-RVA: 0x1CFE1F0 Offset: 0x1CFE2F1 VA: 0x1CFE1F0
	|-Array.EmptyInternalEnumerator<DateTime>..ctor
	|
	|-RVA: 0x1CFE3E0 Offset: 0x1CFE4E1 VA: 0x1CFE3E0
	|-Array.EmptyInternalEnumerator<DateTimeOffset>..ctor
	|
	|-RVA: 0x1CFE5E0 Offset: 0x1CFE6E1 VA: 0x1CFE5E0
	|-Array.EmptyInternalEnumerator<DebugPadState>..ctor
	|
	|-RVA: 0x1CFE7D0 Offset: 0x1CFE8D1 VA: 0x1CFE7D0
	|-Array.EmptyInternalEnumerator<Decimal>..ctor
	|
	|-RVA: 0x1CFEA70 Offset: 0x1CFEB71 VA: 0x1CFEA70
	|-Array.EmptyInternalEnumerator<DeferredTiler>..ctor
	|
	|-RVA: 0x1CFEC60 Offset: 0x1CFED61 VA: 0x1CFEC60
	|-Array.EmptyInternalEnumerator<DeviceHandle>..ctor
	|
	|-RVA: 0x1CFEE70 Offset: 0x1CFEF71 VA: 0x1CFEE70
	|-Array.EmptyInternalEnumerator<DiagnosticEvent>..ctor
	|
	|-RVA: 0x1CFF060 Offset: 0x1CFF161 VA: 0x1CFF060
	|-Array.EmptyInternalEnumerator<DictionaryEntry>..ctor
	|
	|-RVA: 0x1CFF240 Offset: 0x1CFF341 VA: 0x1CFF240
	|-Array.EmptyInternalEnumerator<DictionaryInfo>..ctor
	|
	|-RVA: 0x1CFF440 Offset: 0x1CFF541 VA: 0x1CFF440
	|-Array.EmptyInternalEnumerator<DirectoryEntry>..ctor
	|
	|-RVA: 0x1CFF620 Offset: 0x1CFF721 VA: 0x1CFF620
	|-Array.EmptyInternalEnumerator<double>..ctor
	|
	|-RVA: 0x1CFF810 Offset: 0x1CFF911 VA: 0x1CFF810
	|-Array.EmptyInternalEnumerator<Ephemeron>..ctor
	|
	|-RVA: 0x1CFF9F0 Offset: 0x1CFFAF1 VA: 0x1CFF9F0
	|-Array.EmptyInternalEnumerator<FXZ>..ctor
	|
	|-RVA: 0x1CFFC00 Offset: 0x1CFFD01 VA: 0x1CFFC00
	|-Array.EmptyInternalEnumerator<Finger>..ctor
	|
	|-RVA: 0x1CFFDE0 Offset: 0x1CFFEE1 VA: 0x1CFFDE0
	|-Array.EmptyInternalEnumerator<Float2>..ctor
	|
	|-RVA: 0x1CFFFF0 Offset: 0x1D000F1 VA: 0x1CFFFF0
	|-Array.EmptyInternalEnumerator<Friend>..ctor
	|
	|-RVA: 0x1D001D0 Offset: 0x1D002D1 VA: 0x1D001D0
	|-Array.EmptyInternalEnumerator<GCHandle>..ctor
	|
	|-RVA: 0x1D003B0 Offset: 0x1D004B1 VA: 0x1D003B0
	|-Array.EmptyInternalEnumerator<GesturePoint>..ctor
	|
	|-RVA: 0x1D00630 Offset: 0x1D00731 VA: 0x1D00630
	|-Array.EmptyInternalEnumerator<GestureState>..ctor
	|
	|-RVA: 0x1D00840 Offset: 0x1D00941 VA: 0x1D00840
	|-Array.EmptyInternalEnumerator<GlyphMarshallingStruct>..ctor
	|
	|-RVA: 0x1D00A60 Offset: 0x1D00B61 VA: 0x1D00A60
	|-Array.EmptyInternalEnumerator<GlyphPairAdjustmentRecord>..ctor
	|
	|-RVA: 0x1D00C50 Offset: 0x1D00D51 VA: 0x1D00C50
	|-Array.EmptyInternalEnumerator<GlyphRect>..ctor
	|
	|-RVA: 0x1D00E40 Offset: 0x1D00F41 VA: 0x1D00E40
	|-Array.EmptyInternalEnumerator<Guid>..ctor
	|
	|-RVA: 0x1D01050 Offset: 0x1D01151 VA: 0x1D01050
	|-Array.EmptyInternalEnumerator<Hand>..ctor
	|
	|-RVA: 0x1D01240 Offset: 0x1D01341 VA: 0x1D01240
	|-Array.EmptyInternalEnumerator<HandAnalysisImageState>..ctor
	|
	|-RVA: 0x1D01450 Offset: 0x1D01551 VA: 0x1D01450
	|-Array.EmptyInternalEnumerator<HandAnalysisSilhouetteState>..ctor
	|
	|-RVA: 0x1D01640 Offset: 0x1D01741 VA: 0x1D01640
	|-Array.EmptyInternalEnumerator<HeaderVariantInfo>..ctor
	|
	|-RVA: 0x1D01840 Offset: 0x1D01941 VA: 0x1D01840
	|-Array.EmptyInternalEnumerator<HighlightState>..ctor
	|
	|-RVA: 0x1D01A60 Offset: 0x1D01B61 VA: 0x1D01A60
	|-Array.EmptyInternalEnumerator<HumanBone>..ctor
	|
	|-RVA: 0x1D01C40 Offset: 0x1D01D41 VA: 0x1D01C40
	|-Array.EmptyInternalEnumerator<short>..ctor
	|
	|-RVA: 0x1D01E20 Offset: 0x1D01F21 VA: 0x1D01E20
	|-Array.EmptyInternalEnumerator<int>..ctor
	|
	|-RVA: 0x1D02000 Offset: 0x1D02101 VA: 0x1D02000
	|-Array.EmptyInternalEnumerator<Int32Enum>..ctor
	|
	|-RVA: 0x1D021E0 Offset: 0x1D022E1 VA: 0x1D021E0
	|-Array.EmptyInternalEnumerator<long>..ctor
	|
	|-RVA: 0x1D023C0 Offset: 0x1D024C1 VA: 0x1D023C0
	|-Array.EmptyInternalEnumerator<Int64Enum>..ctor
	|
	|-RVA: 0x1D025A0 Offset: 0x1D026A1 VA: 0x1D025A0
	|-Array.EmptyInternalEnumerator<IntPtr>..ctor
	|
	|-RVA: 0x1D02790 Offset: 0x1D02891 VA: 0x1D02790
	|-Array.EmptyInternalEnumerator<InternalCodePageDataItem>..ctor
	|
	|-RVA: 0x1D02980 Offset: 0x1D02A81 VA: 0x1D02980
	|-Array.EmptyInternalEnumerator<InternalEncodingDataItem>..ctor
	|
	|-RVA: 0x1D02B70 Offset: 0x1D02C71 VA: 0x1D02B70
	|-Array.EmptyInternalEnumerator<InterpretedFrameInfo>..ctor
	|
	|-RVA: 0x1D02D70 Offset: 0x1D02E71 VA: 0x1D02D70
	|-Array.EmptyInternalEnumerator<IntervalTreeNode>..ctor
	|
	|-RVA: 0x1D02F60 Offset: 0x1D03061 VA: 0x1D02F60
	|-Array.EmptyInternalEnumerator<JobHandle>..ctor
	|
	|-RVA: 0x1D03170 Offset: 0x1D03271 VA: 0x1D03170
	|-Array.EmptyInternalEnumerator<Keyframe>..ctor
	|
	|-RVA: 0x1D03360 Offset: 0x1D03461 VA: 0x1D03360
	|-Array.EmptyInternalEnumerator<LOD>..ctor
	|
	|-RVA: 0x1D03540 Offset: 0x1D03641 VA: 0x1D03540
	|-Array.EmptyInternalEnumerator<LayerMask>..ctor
	|
	|-RVA: 0x1D03720 Offset: 0x1D03821 VA: 0x1D03720
	|-Array.EmptyInternalEnumerator<LengthLimitProperties>..ctor
	|
	|-RVA: 0x1D03970 Offset: 0x1D03A71 VA: 0x1D03970
	|-Array.EmptyInternalEnumerator<Light2DBlendStyle>..ctor
	|
	|-RVA: 0x1D03BF0 Offset: 0x1D03CF1 VA: 0x1D03BF0
	|-Array.EmptyInternalEnumerator<LightDataGI>..ctor
	|
	|-RVA: 0x1D03DE0 Offset: 0x1D03EE1 VA: 0x1D03DE0
	|-Array.EmptyInternalEnumerator<LocalDefinition>..ctor
	|
	|-RVA: 0x1D03FC0 Offset: 0x1D040C1 VA: 0x1D03FC0
	|-Array.EmptyInternalEnumerator<MapPos>..ctor
	|
	|-RVA: 0x1D041B0 Offset: 0x1D042B1 VA: 0x1D041B0
	|-Array.EmptyInternalEnumerator<MapRange>..ctor
	|
	|-RVA: 0x1D043C0 Offset: 0x1D044C1 VA: 0x1D043C0
	|-Array.EmptyInternalEnumerator<MaterialReference>..ctor
	|
	|-RVA: 0x1D045E0 Offset: 0x1D046E1 VA: 0x1D045E0
	|-Array.EmptyInternalEnumerator<Matrix4x4>..ctor
	|
	|-RVA: 0x1D047F0 Offset: 0x1D048F1 VA: 0x1D047F0
	|-Array.EmptyInternalEnumerator<MomentProcessorState>..ctor
	|
	|-RVA: 0x1D049E0 Offset: 0x1D04AE1 VA: 0x1D049E0
	|-Array.EmptyInternalEnumerator<MomentStatistic>..ctor
	|
	|-RVA: 0x1D04BF0 Offset: 0x1D04CF1 VA: 0x1D04BF0
	|-Array.EmptyInternalEnumerator<Navigation>..ctor
	|
	|-RVA: 0x1D04DD0 Offset: 0x1D04ED1 VA: 0x1D04DD0
	|-Array.EmptyInternalEnumerator<NetworkServiceAccountId>..ctor
	|
	|-RVA: 0x1D04FE0 Offset: 0x1D050E1 VA: 0x1D04FE0
	|-Array.EmptyInternalEnumerator<NpadFullKeyState>..ctor
	|
	|-RVA: 0x1D051F0 Offset: 0x1D052F1 VA: 0x1D051F0
	|-Array.EmptyInternalEnumerator<NpadHandheldState>..ctor
	|
	|-RVA: 0x1D05400 Offset: 0x1D05501 VA: 0x1D05400
	|-Array.EmptyInternalEnumerator<NpadJoyDualState>..ctor
	|
	|-RVA: 0x1D05610 Offset: 0x1D05711 VA: 0x1D05610
	|-Array.EmptyInternalEnumerator<NpadJoyLeftState>..ctor
	|
	|-RVA: 0x1D05820 Offset: 0x1D05921 VA: 0x1D05820
	|-Array.EmptyInternalEnumerator<NpadJoyRightState>..ctor
	|
	|-RVA: 0x1D05A30 Offset: 0x1D05B31 VA: 0x1D05A30
	|-Array.EmptyInternalEnumerator<NpadStateArrayItem>..ctor
	|
	|-RVA: 0x1D05C10 Offset: 0x1D05D11 VA: 0x1D05C10
	|-Array.EmptyInternalEnumerator<NsUid>..ctor
	|
	|-RVA: 0x1D05DB0 Offset: 0x1D05EB1 VA: 0x1D05DB0
	|-Array.EmptyInternalEnumerator<object>..ctor
	|
	|-RVA: 0x1D05FC0 Offset: 0x1D060C1 VA: 0x1D05FC0
	|-Array.EmptyInternalEnumerator<ObjectInitializationData>..ctor
	|
	|-RVA: 0x1D061A0 Offset: 0x1D062A1 VA: 0x1D061A0
	|-Array.EmptyInternalEnumerator<ParameterModifier>..ctor
	|
	|-RVA: 0x1D06390 Offset: 0x1D06491 VA: 0x1D06390
	|-Array.EmptyInternalEnumerator<Plane>..ctor
	|
	|-RVA: 0x1D06580 Offset: 0x1D06681 VA: 0x1D06580
	|-Array.EmptyInternalEnumerator<Playable>..ctor
	|
	|-RVA: 0x1D06780 Offset: 0x1D06881 VA: 0x1D06780
	|-Array.EmptyInternalEnumerator<PlayableBinding>..ctor
	|
	|-RVA: 0x1D06990 Offset: 0x1D06A91 VA: 0x1D06990
	|-Array.EmptyInternalEnumerator<PlayerLoopSystem>..ctor
	|
	|-RVA: 0x1D06BA0 Offset: 0x1D06CA1 VA: 0x1D06BA0
	|-Array.EmptyInternalEnumerator<PlayerLoopSystemInternal>..ctor
	|
	|-RVA: 0x1D06DC0 Offset: 0x1D06EC1 VA: 0x1D06DC0
	|-Array.EmptyInternalEnumerator<PreTile>..ctor
	|
	|-RVA: 0x1D06FD0 Offset: 0x1D070D1 VA: 0x1D06FD0
	|-Array.EmptyInternalEnumerator<Profile>..ctor
	|
	|-RVA: 0x1D071B0 Offset: 0x1D072B1 VA: 0x1D071B0
	|-Array.EmptyInternalEnumerator<Protrusion>..ctor
	|
	|-RVA: 0x1D073A0 Offset: 0x1D074A1 VA: 0x1D073A0
	|-Array.EmptyInternalEnumerator<Quaternion>..ctor
	|
	|-RVA: 0x1D07590 Offset: 0x1D07691 VA: 0x1D07590
	|-Array.EmptyInternalEnumerator<RandomSeed>..ctor
	|
	|-RVA: 0x1D07780 Offset: 0x1D07881 VA: 0x1D07780
	|-Array.EmptyInternalEnumerator<RangePositionInfo>..ctor
	|
	|-RVA: 0x1D07960 Offset: 0x1D07A61 VA: 0x1D07960
	|-Array.EmptyInternalEnumerator<Ranking2ChartInfoInput>..ctor
	|
	|-RVA: 0x1D07B80 Offset: 0x1D07C81 VA: 0x1D07B80
	|-Array.EmptyInternalEnumerator<RaycastHit>..ctor
	|
	|-RVA: 0x1D07D90 Offset: 0x1D07E91 VA: 0x1D07D90
	|-Array.EmptyInternalEnumerator<RaycastHit2D>..ctor
	|
	|-RVA: 0x1D07FE0 Offset: 0x1D080E1 VA: 0x1D07FE0
	|-Array.EmptyInternalEnumerator<RaycastResult>..ctor
	|
	|-RVA: 0x1D081D0 Offset: 0x1D082D1 VA: 0x1D081D0
	|-Array.EmptyInternalEnumerator<Rect>..ctor
	|
	|-RVA: 0x1D083C0 Offset: 0x1D084C1 VA: 0x1D083C0
	|-Array.EmptyInternalEnumerator<RenderBuffer>..ctor
	|
	|-RVA: 0x1D08660 Offset: 0x1D08761 VA: 0x1D08660
	|-Array.EmptyInternalEnumerator<RenderStateBlock>..ctor
	|
	|-RVA: 0x1D08870 Offset: 0x1D08971 VA: 0x1D08870
	|-Array.EmptyInternalEnumerator<RenderTargetHandle>..ctor
	|
	|-RVA: 0x1D08A80 Offset: 0x1D08B81 VA: 0x1D08A80
	|-Array.EmptyInternalEnumerator<RenderTargetIdentifier>..ctor
	|
	|-RVA: 0x1D08C60 Offset: 0x1D08D61 VA: 0x1D08C60
	|-Array.EmptyInternalEnumerator<RendererListHandle>..ctor
	|
	|-RVA: 0x1D08E40 Offset: 0x1D08F41 VA: 0x1D08E40
	|-Array.EmptyInternalEnumerator<ResourceHandle>..ctor
	|
	|-RVA: 0x1D09030 Offset: 0x1D09131 VA: 0x1D09030
	|-Array.EmptyInternalEnumerator<ResourceLocator>..ctor
	|
	|-RVA: 0x1D09230 Offset: 0x1D09331 VA: 0x1D09230
	|-Array.EmptyInternalEnumerator<RichTextTagAttribute>..ctor
	|
	|-RVA: 0x1D09420 Offset: 0x1D09521 VA: 0x1D09420
	|-Array.EmptyInternalEnumerator<RuntimeLabel>..ctor
	|
	|-RVA: 0x1D09600 Offset: 0x1D09701 VA: 0x1D09600
	|-Array.EmptyInternalEnumerator<sbyte>..ctor
	|
	|-RVA: 0x1D09800 Offset: 0x1D09901 VA: 0x1D09800
	|-Array.EmptyInternalEnumerator<SerializedType>..ctor
	|
	|-RVA: 0x1D099E0 Offset: 0x1D09AE1 VA: 0x1D099E0
	|-Array.EmptyInternalEnumerator<ShaderKeyword>..ctor
	|
	|-RVA: 0x1D09BC0 Offset: 0x1D09CC1 VA: 0x1D09BC0
	|-Array.EmptyInternalEnumerator<ShaderTagId>..ctor
	|
	|-RVA: 0x1D09DD0 Offset: 0x1D09ED1 VA: 0x1D09DD0
	|-Array.EmptyInternalEnumerator<ShadowSliceData>..ctor
	|
	|-RVA: 0x1D09FD0 Offset: 0x1D0A0D1 VA: 0x1D09FD0
	|-Array.EmptyInternalEnumerator<Shape>..ctor
	|
	|-RVA: 0x1D0A1B0 Offset: 0x1D0A2B1 VA: 0x1D0A1B0
	|-Array.EmptyInternalEnumerator<float>..ctor
	|
	|-RVA: 0x1D0A390 Offset: 0x1D0A491 VA: 0x1D0A390
	|-Array.EmptyInternalEnumerator<SixAxisSensorHandle>..ctor
	|
	|-RVA: 0x1D0A610 Offset: 0x1D0A711 VA: 0x1D0A610
	|-Array.EmptyInternalEnumerator<SixAxisSensorState>..ctor
	|
	|-RVA: 0x1D0A820 Offset: 0x1D0A921 VA: 0x1D0A820
	|-Array.EmptyInternalEnumerator<SkeletonBone>..ctor
	|
	|-RVA: 0x1D0AA00 Offset: 0x1D0AB01 VA: 0x1D0AA00
	|-Array.EmptyInternalEnumerator<SortingLayer>..ctor
	|
	|-RVA: 0x1D0ACA0 Offset: 0x1D0ADA1 VA: 0x1D0ACA0
	|-Array.EmptyInternalEnumerator<SphericalHarmonicsL2>..ctor
	|
	|-RVA: 0x1D0AE80 Offset: 0x1D0AF81 VA: 0x1D0AE80
	|-Array.EmptyInternalEnumerator<SpinLock>..ctor
	|
	|-RVA: 0x1D0B0D0 Offset: 0x1D0B1D1 VA: 0x1D0B0D0
	|-Array.EmptyInternalEnumerator<SpringBoneComponents>..ctor
	|
	|-RVA: 0x1D0B2E0 Offset: 0x1D0B3E1 VA: 0x1D0B2E0
	|-Array.EmptyInternalEnumerator<SpringBoneProperties>..ctor
	|
	|-RVA: 0x1D0B590 Offset: 0x1D0B691 VA: 0x1D0B590
	|-Array.EmptyInternalEnumerator<SpringColliderComponents>..ctor
	|
	|-RVA: 0x1D0B780 Offset: 0x1D0B881 VA: 0x1D0B780
	|-Array.EmptyInternalEnumerator<SpringColliderProperties>..ctor
	|
	|-RVA: 0x1D0B9A0 Offset: 0x1D0BAA1 VA: 0x1D0B9A0
	|-Array.EmptyInternalEnumerator<SpringForceComponent>..ctor
	|
	|-RVA: 0x1D0BBB0 Offset: 0x1D0BCB1 VA: 0x1D0BBB0
	|-Array.EmptyInternalEnumerator<SpringJobElement>..ctor
	|
	|-RVA: 0x1D0BDB0 Offset: 0x1D0BEB1 VA: 0x1D0BDB0
	|-Array.EmptyInternalEnumerator<SpriteState>..ctor
	|
	|-RVA: 0x1D0BFC0 Offset: 0x1D0C0C1 VA: 0x1D0BFC0
	|-Array.EmptyInternalEnumerator<SubMeshDescriptor>..ctor
	|
	|-RVA: 0x1D0C1D0 Offset: 0x1D0C2D1 VA: 0x1D0C1D0
	|-Array.EmptyInternalEnumerator<TMP_CharacterInfo>..ctor
	|
	|-RVA: 0x1D0C3C0 Offset: 0x1D0C4C1 VA: 0x1D0C3C0
	|-Array.EmptyInternalEnumerator<TMP_FontWeightPair>..ctor
	|
	|-RVA: 0x1D0C640 Offset: 0x1D0C741 VA: 0x1D0C640
	|-Array.EmptyInternalEnumerator<TMP_LineInfo>..ctor
	|
	|-RVA: 0x1D0C850 Offset: 0x1D0C951 VA: 0x1D0C850
	|-Array.EmptyInternalEnumerator<TMP_LinkInfo>..ctor
	|
	|-RVA: 0x1D0CAA0 Offset: 0x1D0CBA1 VA: 0x1D0CAA0
	|-Array.EmptyInternalEnumerator<TMP_MeshInfo>..ctor
	|
	|-RVA: 0x1D0CCA0 Offset: 0x1D0CDA1 VA: 0x1D0CCA0
	|-Array.EmptyInternalEnumerator<TMP_PageInfo>..ctor
	|
	|-RVA: 0x1D0CEA0 Offset: 0x1D0CFA1 VA: 0x1D0CEA0
	|-Array.EmptyInternalEnumerator<TMP_WordInfo>..ctor
	|
	|-RVA: 0x1D0D090 Offset: 0x1D0D191 VA: 0x1D0D090
	|-Array.EmptyInternalEnumerator<TablePair>..ctor
	|
	|-RVA: 0x1D0D270 Offset: 0x1D0D371 VA: 0x1D0D270
	|-Array.EmptyInternalEnumerator<TextureHandle>..ctor
	|
	|-RVA: 0x1D0D450 Offset: 0x1D0D551 VA: 0x1D0D450
	|-Array.EmptyInternalEnumerator<TimeSpan>..ctor
	|
	|-RVA: 0x1D0D6A0 Offset: 0x1D0D7A1 VA: 0x1D0D6A0
	|-Array.EmptyInternalEnumerator<Touch>..ctor
	|
	|-RVA: 0x1D0D8B0 Offset: 0x1D0D9B1 VA: 0x1D0D8B0
	|-Array.EmptyInternalEnumerator<TouchScreenState1>..ctor
	|
	|-RVA: 0x1D0DAC0 Offset: 0x1D0DBC1 VA: 0x1D0DAC0
	|-Array.EmptyInternalEnumerator<TouchScreenState10>..ctor
	|
	|-RVA: 0x1D0DCD0 Offset: 0x1D0DDD1 VA: 0x1D0DCD0
	|-Array.EmptyInternalEnumerator<TouchScreenState11>..ctor
	|
	|-RVA: 0x1D0DEE0 Offset: 0x1D0DFE1 VA: 0x1D0DEE0
	|-Array.EmptyInternalEnumerator<TouchScreenState12>..ctor
	|
	|-RVA: 0x1D0E0F0 Offset: 0x1D0E1F1 VA: 0x1D0E0F0
	|-Array.EmptyInternalEnumerator<TouchScreenState13>..ctor
	|
	|-RVA: 0x1D0E300 Offset: 0x1D0E401 VA: 0x1D0E300
	|-Array.EmptyInternalEnumerator<TouchScreenState14>..ctor
	|
	|-RVA: 0x1D0E510 Offset: 0x1D0E611 VA: 0x1D0E510
	|-Array.EmptyInternalEnumerator<TouchScreenState15>..ctor
	|
	|-RVA: 0x1D0E720 Offset: 0x1D0E821 VA: 0x1D0E720
	|-Array.EmptyInternalEnumerator<TouchScreenState16>..ctor
	|
	|-RVA: 0x1D0E9A0 Offset: 0x1D0EAA1 VA: 0x1D0E9A0
	|-Array.EmptyInternalEnumerator<TouchScreenState2>..ctor
	|
	|-RVA: 0x1D0EBB0 Offset: 0x1D0ECB1 VA: 0x1D0EBB0
	|-Array.EmptyInternalEnumerator<TouchScreenState3>..ctor
	|
	|-RVA: 0x1D0EDC0 Offset: 0x1D0EEC1 VA: 0x1D0EDC0
	|-Array.EmptyInternalEnumerator<TouchScreenState4>..ctor
	|
	|-RVA: 0x1D0EFD0 Offset: 0x1D0F0D1 VA: 0x1D0EFD0
	|-Array.EmptyInternalEnumerator<TouchScreenState5>..ctor
	|
	|-RVA: 0x1D0F1E0 Offset: 0x1D0F2E1 VA: 0x1D0F1E0
	|-Array.EmptyInternalEnumerator<TouchScreenState6>..ctor
	|
	|-RVA: 0x1D0F3F0 Offset: 0x1D0F4F1 VA: 0x1D0F3F0
	|-Array.EmptyInternalEnumerator<TouchScreenState7>..ctor
	|
	|-RVA: 0x1D0F600 Offset: 0x1D0F701 VA: 0x1D0F600
	|-Array.EmptyInternalEnumerator<TouchScreenState8>..ctor
	|
	|-RVA: 0x1D0F810 Offset: 0x1D0F911 VA: 0x1D0F810
	|-Array.EmptyInternalEnumerator<TouchScreenState9>..ctor
	|
	|-RVA: 0x1D0FA20 Offset: 0x1D0FB21 VA: 0x1D0FA20
	|-Array.EmptyInternalEnumerator<TouchState>..ctor
	|
	|-RVA: 0x1D0FC20 Offset: 0x1D0FD21 VA: 0x1D0FC20
	|-Array.EmptyInternalEnumerator<TrailHand>..ctor
	|
	|-RVA: 0x1D0FE20 Offset: 0x1D0FF21 VA: 0x1D0FE20
	|-Array.EmptyInternalEnumerator<TrailVertex>..ctor
	|
	|-RVA: 0x1D10010 Offset: 0x1D10111 VA: 0x1D10010
	|-Array.EmptyInternalEnumerator<UICharInfo>..ctor
	|
	|-RVA: 0x1D10200 Offset: 0x1D10301 VA: 0x1D10200
	|-Array.EmptyInternalEnumerator<UILineInfo>..ctor
	|
	|-RVA: 0x1D104A0 Offset: 0x1D105A1 VA: 0x1D104A0
	|-Array.EmptyInternalEnumerator<UIVertex>..ctor
	|
	|-RVA: 0x1D10680 Offset: 0x1D10781 VA: 0x1D10680
	|-Array.EmptyInternalEnumerator<ushort>..ctor
	|
	|-RVA: 0x1D10860 Offset: 0x1D10961 VA: 0x1D10860
	|-Array.EmptyInternalEnumerator<UInt16Enum>..ctor
	|
	|-RVA: 0x1D10A40 Offset: 0x1D10B41 VA: 0x1D10A40
	|-Array.EmptyInternalEnumerator<uint>..ctor
	|
	|-RVA: 0x1D10C20 Offset: 0x1D10D21 VA: 0x1D10C20
	|-Array.EmptyInternalEnumerator<UInt32Enum>..ctor
	|
	|-RVA: 0x1D10E00 Offset: 0x1D10F01 VA: 0x1D10E00
	|-Array.EmptyInternalEnumerator<ulong>..ctor
	|
	|-RVA: 0x1D10FF0 Offset: 0x1D110F1 VA: 0x1D10FF0
	|-Array.EmptyInternalEnumerator<Uid>..ctor
	|
	|-RVA: 0x1D111D0 Offset: 0x1D112D1 VA: 0x1D111D0
	|-Array.EmptyInternalEnumerator<UniTask>..ctor
	|
	|-RVA: 0x1D113B0 Offset: 0x1D114B1 VA: 0x1D113B0
	|-Array.EmptyInternalEnumerator<Unit>..ctor
	|
	|-RVA: 0x1D11590 Offset: 0x1D11691 VA: 0x1D11590
	|-Array.EmptyInternalEnumerator<UnitEnum>..ctor
	|
	|-RVA: 0x1D11780 Offset: 0x1D11881 VA: 0x1D11780
	|-Array.EmptyInternalEnumerator<UserWord>..ctor
	|
	|-RVA: 0x1D11960 Offset: 0x1D11A61 VA: 0x1D11960
	|-Array.EmptyInternalEnumerator<Vector2>..ctor
	|
	|-RVA: 0x1D11B40 Offset: 0x1D11C41 VA: 0x1D11B40
	|-Array.EmptyInternalEnumerator<Vector2Int>..ctor
	|
	|-RVA: 0x1D11D30 Offset: 0x1D11E31 VA: 0x1D11D30
	|-Array.EmptyInternalEnumerator<Vector3>..ctor
	|
	|-RVA: 0x1D11F20 Offset: 0x1D12021 VA: 0x1D11F20
	|-Array.EmptyInternalEnumerator<Vector4>..ctor
	|
	|-RVA: 0x1D12110 Offset: 0x1D12211 VA: 0x1D12110
	|-Array.EmptyInternalEnumerator<VertexAttributeDescriptor>..ctor
	|
	|-RVA: 0x1D122F0 Offset: 0x1D123F1 VA: 0x1D122F0
	|-Array.EmptyInternalEnumerator<VibrationDeviceHandle>..ctor
	|
	|-RVA: 0x1D124D0 Offset: 0x1D125D1 VA: 0x1D124D0
	|-Array.EmptyInternalEnumerator<VibrationDeviceInfo>..ctor
	|
	|-RVA: 0x1D126C0 Offset: 0x1D127C1 VA: 0x1D126C0
	|-Array.EmptyInternalEnumerator<VibrationValue>..ctor
	|
	|-RVA: 0x1D12960 Offset: 0x1D12A61 VA: 0x1D12960
	|-Array.EmptyInternalEnumerator<VisibleLight>..ctor
	|
	|-RVA: 0x1D12B70 Offset: 0x1D12C71 VA: 0x1D12B70
	|-Array.EmptyInternalEnumerator<WordWrapState>..ctor
	|
	|-RVA: 0x1D12D60 Offset: 0x1D12E61 VA: 0x1D12D60
	|-Array.EmptyInternalEnumerator<X509ChainStatus>..ctor
	|
	|-RVA: 0x1D12F60 Offset: 0x1D13061 VA: 0x1D12F60
	|-Array.EmptyInternalEnumerator<XPathNode>..ctor
	|
	|-RVA: 0x1D13150 Offset: 0x1D13251 VA: 0x1D13150
	|-Array.EmptyInternalEnumerator<XPathNodeRef>..ctor
	|
	|-RVA: 0x1D13360 Offset: 0x1D13461 VA: 0x1D13360
	|-Array.EmptyInternalEnumerator<XRView>..ctor
	|
	|-RVA: 0x1D13550 Offset: 0x1D13651 VA: 0x1D13550
	|-Array.EmptyInternalEnumerator<float3>..ctor
	|
	|-RVA: 0x1D13770 Offset: 0x1D13871 VA: 0x1D13770
	|-Array.EmptyInternalEnumerator<float4x4>..ctor
	|
	|-RVA: 0x1D13950 Offset: 0x1D13A51 VA: 0x1D13950
	|-Array.EmptyInternalEnumerator<jvalue>..ctor
	|
	|-RVA: 0x1D13B40 Offset: 0x1D13C41 VA: 0x1D13B40
	|-Array.EmptyInternalEnumerator<uint4>..ctor
	|
	|-RVA: 0x1D13D30 Offset: 0x1D13E31 VA: 0x1D13D30
	|-Array.EmptyInternalEnumerator<AICrossfire.PositionTable>..ctor
	|
	|-RVA: 0x1D13F20 Offset: 0x1D14021 VA: 0x1D13F20
	|-Array.EmptyInternalEnumerator<AIEnum.SkillRangeEnemyData>..ctor
	|
	|-RVA: 0x1D14100 Offset: 0x1D14201 VA: 0x1D14100
	|-Array.EmptyInternalEnumerator<AIOrder.UnitPriority>..ctor
	|
	|-RVA: 0x1D142F0 Offset: 0x1D143F1 VA: 0x1D142F0
	|-Array.EmptyInternalEnumerator<AmiiboSequence.GainItemData>..ctor
	|
	|-RVA: 0x1D14500 Offset: 0x1D14601 VA: 0x1D14500
	|-Array.EmptyInternalEnumerator<AnimationOutputWeightProcessor.WeightInfo>..ctor
	|
	|-RVA: 0x1D146F0 Offset: 0x1D147F1 VA: 0x1D146F0
	|-Array.EmptyInternalEnumerator<ArenaOrderSequence.GodInfo>..ctor
	|
	|-RVA: 0x1D148E0 Offset: 0x1D149E1 VA: 0x1D148E0
	|-Array.EmptyInternalEnumerator<BattleInfo.SupportData>..ctor
	|
	|-RVA: 0x1D14AD0 Offset: 0x1D14BD1 VA: 0x1D14AD0
	|-Array.EmptyInternalEnumerator<BeforeRenderHelper.OrderBlock>..ctor
	|
	|-RVA: 0x1D14CD0 Offset: 0x1D14DD1 VA: 0x1D14CD0
	|-Array.EmptyInternalEnumerator<Camera.RenderRequest>..ctor
	|
	|-RVA: 0x1D14EC0 Offset: 0x1D14FC1 VA: 0x1D14EC0
	|-Array.EmptyInternalEnumerator<CameraState.CustomBlendable>..ctor
	|
	|-RVA: 0x1D150C0 Offset: 0x1D151C1 VA: 0x1D150C0
	|-Array.EmptyInternalEnumerator<CinemachineBlendListCamera.Instruction>..ctor
	|
	|-RVA: 0x1D152C0 Offset: 0x1D153C1 VA: 0x1D152C0
	|-Array.EmptyInternalEnumerator<CinemachineBlenderSettings.CustomBlend>..ctor
	|
	|-RVA: 0x1D154A0 Offset: 0x1D155A1 VA: 0x1D154A0
	|-Array.EmptyInternalEnumerator<CinemachineClearShot.Pair>..ctor
	|
	|-RVA: 0x1D15680 Offset: 0x1D15781 VA: 0x1D15680
	|-Array.EmptyInternalEnumerator<CinemachineFreeLook.Orbit>..ctor
	|
	|-RVA: 0x1D15890 Offset: 0x1D15991 VA: 0x1D15890
	|-Array.EmptyInternalEnumerator<CinemachinePath.Waypoint>..ctor
	|
	|-RVA: 0x1D15A80 Offset: 0x1D15B81 VA: 0x1D15A80
	|-Array.EmptyInternalEnumerator<CinemachineSmoothPath.Waypoint>..ctor
	|
	|-RVA: 0x1D15C60 Offset: 0x1D15D61 VA: 0x1D15C60
	|-Array.EmptyInternalEnumerator<CinemachineStateDrivenCamera.HashPair>..ctor
	|
	|-RVA: 0x1D15E60 Offset: 0x1D15F61 VA: 0x1D15E60
	|-Array.EmptyInternalEnumerator<CinemachineStateDrivenCamera.Instruction>..ctor
	|
	|-RVA: 0x1D16040 Offset: 0x1D16141 VA: 0x1D16040
	|-Array.EmptyInternalEnumerator<CinemachineStateDrivenCamera.ParentHash>..ctor
	|
	|-RVA: 0x1D16230 Offset: 0x1D16331 VA: 0x1D16230
	|-Array.EmptyInternalEnumerator<CinemachineTargetGroup.Target>..ctor
	|
	|-RVA: 0x1D16430 Offset: 0x1D16531 VA: 0x1D16430
	|-Array.EmptyInternalEnumerator<CodePointIndexer.TableRange>..ctor
	|
	|-RVA: 0x1D16620 Offset: 0x1D16721 VA: 0x1D16620
	|-Array.EmptyInternalEnumerator<ContentCatalogData.Bucket>..ctor
	|
	|-RVA: 0x1D16810 Offset: 0x1D16911 VA: 0x1D16810
	|-Array.EmptyInternalEnumerator<CookieTokenizer.RecognizedAttribute>..ctor
	|
	|-RVA: 0x1D16A20 Offset: 0x1D16B21 VA: 0x1D16A20
	|-Array.EmptyInternalEnumerator<DeferredLights.DrawCall>..ctor
	|
	|-RVA: 0x1D16C00 Offset: 0x1D16D01 VA: 0x1D16C00
	|-Array.EmptyInternalEnumerator<DeferredShaderData.ComputeBufferInfo>..ctor
	|
	|-RVA: 0x1D16E00 Offset: 0x1D16F01 VA: 0x1D16E00
	|-Array.EmptyInternalEnumerator<DeferredTiler.PrePunctualLight>..ctor
	|
	|-RVA: 0x1D17000 Offset: 0x1D17101 VA: 0x1D17000
	|-Array.EmptyInternalEnumerator<DelayedActionManager.DelegateInfo>..ctor
	|
	|-RVA: 0x1D17210 Offset: 0x1D17311 VA: 0x1D17210
	|-Array.EmptyInternalEnumerator<Detail.AsyncResultInt>..ctor
	|
	|-RVA: 0x1D17400 Offset: 0x1D17501 VA: 0x1D17400
	|-Array.EmptyInternalEnumerator<Detail.CppArray>..ctor
	|
	|-RVA: 0x1D17610 Offset: 0x1D17711 VA: 0x1D17610
	|-Array.EmptyInternalEnumerator<Detail.NotificationEventInt>..ctor
	|
	|-RVA: 0x1D17800 Offset: 0x1D17901 VA: 0x1D17800
	|-Array.EmptyInternalEnumerator<DisposUnit.Item>..ctor
	|
	|-RVA: 0x1D179F0 Offset: 0x1D17AF1 VA: 0x1D179F0
	|-Array.EmptyInternalEnumerator<DragonRidePresetParamData.CourseData>..ctor
	|
	|-RVA: 0x1D17BE0 Offset: 0x1D17CE1 VA: 0x1D17BE0
	|-Array.EmptyInternalEnumerator<DragonRideTargetGroup.ChainParam>..ctor
	|
	|-RVA: 0x1D17DC0 Offset: 0x1D17EC1 VA: 0x1D17DC0
	|-Array.EmptyInternalEnumerator<DynamicMesh.State>..ctor
	|
	|-RVA: 0x1D17FD0 Offset: 0x1D180D1 VA: 0x1D17FD0
	|-Array.EmptyInternalEnumerator<FXZEx.HitPoint>..ctor
	|
	|-RVA: 0x1D181C0 Offset: 0x1D182C1 VA: 0x1D181C0
	|-Array.EmptyInternalEnumerator<FishingRadicalParamData.RadicalParam>..ctor
	|
	|-RVA: 0x1D183B0 Offset: 0x1D184B1 VA: 0x1D183B0
	|-Array.EmptyInternalEnumerator<GameVariable.Value>..ctor
	|
	|-RVA: 0x1D185B0 Offset: 0x1D186B1 VA: 0x1D185B0
	|-Array.EmptyInternalEnumerator<GmapPathAdjuster.TargetModel>..ctor
	|
	|-RVA: 0x1D187B0 Offset: 0x1D188B1 VA: 0x1D187B0
	|-Array.EmptyInternalEnumerator<GmapSpotAdjuster.TargetModel>..ctor
	|
	|-RVA: 0x1D189C0 Offset: 0x1D18AC1 VA: 0x1D189C0
	|-Array.EmptyInternalEnumerator<GrounderQuadruped.Foot>..ctor
	|
	|-RVA: 0x1D18BC0 Offset: 0x1D18CC1 VA: 0x1D18BC0
	|-Array.EmptyInternalEnumerator<Hashtable.bucket>..ctor
	|
	|-RVA: 0x1D18DC0 Offset: 0x1D18EC1 VA: 0x1D18DC0
	|-Array.EmptyInternalEnumerator<HeadingTracker.Item>..ctor
	|
	|-RVA: 0x1D18FD0 Offset: 0x1D190D1 VA: 0x1D18FD0
	|-Array.EmptyInternalEnumerator<HubAccessoryRoomCamera.BackgroundSettings>..ctor
	|
	|-RVA: 0x1D191D0 Offset: 0x1D192D1 VA: 0x1D191D0
	|-Array.EmptyInternalEnumerator<HubFastTravel.Location>..ctor
	|
	|-RVA: 0x1D193E0 Offset: 0x1D194E1 VA: 0x1D193E0
	|-Array.EmptyInternalEnumerator<HubLensFlare.Flare>..ctor
	|
	|-RVA: 0x1D195D0 Offset: 0x1D196D1 VA: 0x1D195D0
	|-Array.EmptyInternalEnumerator<HubLookAtController.LookAtIKParam>..ctor
	|
	|-RVA: 0x1D197C0 Offset: 0x1D198C1 VA: 0x1D197C0
	|-Array.EmptyInternalEnumerator<HubMaterialArray.MaterialInfo>..ctor
	|
	|-RVA: 0x1D199D0 Offset: 0x1D19AD1 VA: 0x1D199D0
	|-Array.EmptyInternalEnumerator<IKSolverLimb.AxisDirection>..ctor
	|
	|-RVA: 0x1D19BC0 Offset: 0x1D19CC1 VA: 0x1D19BC0
	|-Array.EmptyInternalEnumerator<InventoryPoolItemMenuContent.KindBgNameClass>..ctor
	|
	|-RVA: 0x1D19DD0 Offset: 0x1D19ED1 VA: 0x1D19DD0
	|-Array.EmptyInternalEnumerator<LightUtility.ParametricLightMeshVertex>..ctor
	|
	|-RVA: 0x1D19FE0 Offset: 0x1D1A0E1 VA: 0x1D19FE0
	|-Array.EmptyInternalEnumerator<LightUtility.SpriteLightMeshVertex>..ctor
	|
	|-RVA: 0x1D1A1C0 Offset: 0x1D1A2C1 VA: 0x1D1A1C0
	|-Array.EmptyInternalEnumerator<Map.Pos>..ctor
	|
	|-RVA: 0x1D1A3B0 Offset: 0x1D1A4B1 VA: 0x1D1A3B0
	|-Array.EmptyInternalEnumerator<MapGodExp.KindDesc>..ctor
	|
	|-RVA: 0x1D1A590 Offset: 0x1D1A691 VA: 0x1D1A590
	|-Array.EmptyInternalEnumerator<MapHistory.Command>..ctor
	|
	|-RVA: 0x1D1A780 Offset: 0x1D1A881 VA: 0x1D1A780
	|-Array.EmptyInternalEnumerator<MapImage.BackupTerrain>..ctor
	|
	|-RVA: 0x1D1A960 Offset: 0x1D1AA61 VA: 0x1D1A960
	|-Array.EmptyInternalEnumerator<MapImageRange.Pos>..ctor
	|
	|-RVA: 0x1D1AB40 Offset: 0x1D1AC41 VA: 0x1D1AB40
	|-Array.EmptyInternalEnumerator<MapKillBonus.KillBonus>..ctor
	|
	|-RVA: 0x1D1AD20 Offset: 0x1D1AE21 VA: 0x1D1AD20
	|-Array.EmptyInternalEnumerator<MapKillBonus.KilledBonus>..ctor
	|
	|-RVA: 0x1D1AF70 Offset: 0x1D1B071 VA: 0x1D1AF70
	|-Array.EmptyInternalEnumerator<MapMind.Record>..ctor
	|
	|-RVA: 0x1D1B170 Offset: 0x1D1B271 VA: 0x1D1B170
	|-Array.EmptyInternalEnumerator<MapMind.Target>..ctor
	|
	|-RVA: 0x1D1B370 Offset: 0x1D1B471 VA: 0x1D1B370
	|-Array.EmptyInternalEnumerator<MapPanelDebug.Entity>..ctor
	|
	|-RVA: 0x1D1B550 Offset: 0x1D1B651 VA: 0x1D1B550
	|-Array.EmptyInternalEnumerator<NexRanking.Data>..ctor
	|
	|-RVA: 0x1D1B740 Offset: 0x1D1B841 VA: 0x1D1B740
	|-Array.EmptyInternalEnumerator<NexVersus.RatingData>..ctor
	|
	|-RVA: 0x1D1B950 Offset: 0x1D1BA51 VA: 0x1D1B950
	|-Array.EmptyInternalEnumerator<NoiseSettings.TransformNoiseParams>..ctor
	|
	|-RVA: 0x1D1BB40 Offset: 0x1D1BC41 VA: 0x1D1BB40
	|-Array.EmptyInternalEnumerator<PackedPlayModeBuildLogs.RuntimeBuildLog>..ctor
	|
	|-RVA: 0x1D1BD30 Offset: 0x1D1BE31 VA: 0x1D1BD30
	|-Array.EmptyInternalEnumerator<ParameterizedStrings.FormatParam>..ctor
	|
	|-RVA: 0x1D1BF40 Offset: 0x1D1C041 VA: 0x1D1BF40
	|-Array.EmptyInternalEnumerator<ParticleSystem.Particle>..ctor
	|
	|-RVA: 0x1D1C120 Offset: 0x1D1C221 VA: 0x1D1C120
	|-Array.EmptyInternalEnumerator<ProfileCard.Achievement>..ctor
	|
	|-RVA: 0x1D1C320 Offset: 0x1D1C421 VA: 0x1D1C320
	|-Array.EmptyInternalEnumerator<ProfileCard.SortieCount>..ctor
	|
	|-RVA: 0x1D1C530 Offset: 0x1D1C631 VA: 0x1D1C530
	|-Array.EmptyInternalEnumerator<QualitySettingsStack.Settings>..ctor
	|
	|-RVA: 0x1D1C710 Offset: 0x1D1C811 VA: 0x1D1C710
	|-Array.EmptyInternalEnumerator<RangeData.Offset>..ctor
	|
	|-RVA: 0x1D1C900 Offset: 0x1D1CA01 VA: 0x1D1C900
	|-Array.EmptyInternalEnumerator<RegexCharClass.LowerCaseMapping>..ctor
	|
	|-RVA: 0x1D1CB00 Offset: 0x1D1CC01 VA: 0x1D1CB00
	|-Array.EmptyInternalEnumerator<Relay.ChooseAwardeeData>..ctor
	|
	|-RVA: 0x1D1CCF0 Offset: 0x1D1CDF1 VA: 0x1D1CCF0
	|-Array.EmptyInternalEnumerator<RelayAwardData.Info>..ctor
	|
	|-RVA: 0x1D1CF40 Offset: 0x1D1D041 VA: 0x1D1CF40
	|-Array.EmptyInternalEnumerator<RenderGraph.CompiledPassInfo>..ctor
	|
	|-RVA: 0x1D1D140 Offset: 0x1D1D241 VA: 0x1D1D140
	|-Array.EmptyInternalEnumerator<RenderGraph.CompiledResourceInfo>..ctor
	|
	|-RVA: 0x1D1D340 Offset: 0x1D1D441 VA: 0x1D1D340
	|-Array.EmptyInternalEnumerator<RenderGraphDebugData.PassDebugData>..ctor
	|
	|-RVA: 0x1D1D550 Offset: 0x1D1D651 VA: 0x1D1D550
	|-Array.EmptyInternalEnumerator<RenderGraphDebugData.ResourceDebugData>..ctor
	|
	|-RVA: 0x1D1D760 Offset: 0x1D1D861 VA: 0x1D1D760
	|-Array.EmptyInternalEnumerator<RenderGraphResourceRegistry.RendererListResource>..ctor
	|
	|-RVA: 0x1D1D950 Offset: 0x1D1DA51 VA: 0x1D1D950
	|-Array.EmptyInternalEnumerator<RingCleaningUnitSelectMenu.GodParam>..ctor
	|
	|-RVA: 0x1D1DB40 Offset: 0x1D1DC41 VA: 0x1D1DB40
	|-Array.EmptyInternalEnumerator<SampleWave.Data>..ctor
	|
	|-RVA: 0x1D1DD20 Offset: 0x1D1DE21 VA: 0x1D1DD20
	|-Array.EmptyInternalEnumerator<SampleWave.Temp>..ctor
	|
	|-RVA: 0x1D1DF10 Offset: 0x1D1E011 VA: 0x1D1DF10
	|-Array.EmptyInternalEnumerator<SendMouseEvents.HitInfo>..ctor
	|
	|-RVA: 0x1D1E120 Offset: 0x1D1E221 VA: 0x1D1E120
	|-Array.EmptyInternalEnumerator<SequenceNode.SequenceConstructPosContext>..ctor
	|
	|-RVA: 0x1D1E370 Offset: 0x1D1E471 VA: 0x1D1E370
	|-Array.EmptyInternalEnumerator<ShaderInput.LightData>..ctor
	|
	|-RVA: 0x1D1E5C0 Offset: 0x1D1E6C1 VA: 0x1D1E5C0
	|-Array.EmptyInternalEnumerator<ShaderInput.ShadowData>..ctor
	|
	|-RVA: 0x1D1E7D0 Offset: 0x1D1E8D1 VA: 0x1D1E7D0
	|-Array.EmptyInternalEnumerator<ShadowUtility.Edge>..ctor
	|
	|-RVA: 0x1D1E9C0 Offset: 0x1D1EAC1 VA: 0x1D1E9C0
	|-Array.EmptyInternalEnumerator<SimpleAnimationPlayable.QueuedState>..ctor
	|
	|-RVA: 0x1D1EBA0 Offset: 0x1D1ECA1 VA: 0x1D1EBA0
	|-Array.EmptyInternalEnumerator<SkillArray.Entity>..ctor
	|
	|-RVA: 0x1D1ED90 Offset: 0x1D1EE91 VA: 0x1D1ED90
	|-Array.EmptyInternalEnumerator<Socket.WSABUF>..ctor
	|
	|-RVA: 0x1D1EF80 Offset: 0x1D1F081 VA: 0x1D1EF80
	|-Array.EmptyInternalEnumerator<Stream.Info>..ctor
	|
	|-RVA: 0x1D1F170 Offset: 0x1D1F271 VA: 0x1D1F170
	|-Array.EmptyInternalEnumerator<TMP_Text.UnicodeChar>..ctor
	|
	|-RVA: 0x1D1F390 Offset: 0x1D1F491 VA: 0x1D1F390
	|-Array.EmptyInternalEnumerator<TexturePacker_JsonArray.Frame>..ctor
	|
	|-RVA: 0x1D1F590 Offset: 0x1D1F691 VA: 0x1D1F590
	|-Array.EmptyInternalEnumerator<TimeNotificationBehaviour.NotificationEntry>..ctor
	|
	|-RVA: 0x1D1F790 Offset: 0x1D1F891 VA: 0x1D1F790
	|-Array.EmptyInternalEnumerator<UnitySynchronizationContext.WorkRequest>..ctor
	|
	|-RVA: 0x1D1F990 Offset: 0x1D1FA91 VA: 0x1D1F990
	|-Array.EmptyInternalEnumerator<XmlNamespaceManager.NamespaceDeclaration>..ctor
	|
	|-RVA: 0x1D1FB80 Offset: 0x1D1FC81 VA: 0x1D1FB80
	|-Array.EmptyInternalEnumerator<XmlSchemaObjectTable.XmlSchemaObjectEntry>..ctor
	|
	|-RVA: 0x1D1FE20 Offset: 0x1D1FF21 VA: 0x1D1FE20
	|-Array.EmptyInternalEnumerator<XmlTextReaderImpl.ParsingState>..ctor
	|
	|-RVA: 0x1D20010 Offset: 0x1D20111 VA: 0x1D20010
	|-Array.EmptyInternalEnumerator<AIThink.EnchantThink.Desc>..ctor
	|
	|-RVA: 0x1D201F0 Offset: 0x1D202F1 VA: 0x1D201F0
	|-Array.EmptyInternalEnumerator<AIThink.EnchantThink.ItemInfo>..ctor
	|
	|-RVA: 0x1D203D0 Offset: 0x1D204D1 VA: 0x1D203D0
	|-Array.EmptyInternalEnumerator<AIThink.EnchantThink.SurroundingInfo>..ctor
	|
	|-RVA: 0x1D205C0 Offset: 0x1D206C1 VA: 0x1D205C0
	|-Array.EmptyInternalEnumerator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>..ctor
	|
	|-RVA: 0x1D207D0 Offset: 0x1D208D1 VA: 0x1D207D0
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStoreChangeMetaParamInt>..ctor
	|
	|-RVA: 0x1D209C0 Offset: 0x1D20AC1 VA: 0x1D209C0
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStoreDeleteParamInt>..ctor
	|
	|-RVA: 0x1D20BD0 Offset: 0x1D20CD1 VA: 0x1D20BD0
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStoreGetMetaParamInt>..ctor
	|
	|-RVA: 0x1D20DE0 Offset: 0x1D20EE1 VA: 0x1D20DE0
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStoreMetaInfoInt>..ctor
	|
	|-RVA: 0x1D20FE0 Offset: 0x1D210E1 VA: 0x1D20FE0
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStorePasswordInfoInt>..ctor
	|
	|-RVA: 0x1D211E0 Offset: 0x1D212E1 VA: 0x1D211E0
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStorePersistenceInfoInt>..ctor
	|
	|-RVA: 0x1D213F0 Offset: 0x1D214F1 VA: 0x1D213F0
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStorePreparePostParamInt>..ctor
	|
	|-RVA: 0x1D215E0 Offset: 0x1D216E1 VA: 0x1D215E0
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStoreRateObjectParamInt>..ctor
	|
	|-RVA: 0x1D217E0 Offset: 0x1D218E1 VA: 0x1D217E0
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStoreRatingInitParamInt>..ctor
	|
	|-RVA: 0x1D219D0 Offset: 0x1D21AD1 VA: 0x1D219D0
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStoreRatingTargetInt>..ctor
	|
	|-RVA: 0x1D21BE0 Offset: 0x1D21CE1 VA: 0x1D21BE0
	|-Array.EmptyInternalEnumerator<Detail.Ranking.RankingCachedResultInt>..ctor
	|
	|-RVA: 0x1D21DD0 Offset: 0x1D21ED1 VA: 0x1D21DD0
	|-Array.EmptyInternalEnumerator<Detail.Ranking.RankingOrderParamInt>..ctor
	|
	|-RVA: 0x1D21FF0 Offset: 0x1D220F1 VA: 0x1D21FF0
	|-Array.EmptyInternalEnumerator<Detail.Ranking.RankingRankDataInt>..ctor
	|
	|-RVA: 0x1D22270 Offset: 0x1D22371 VA: 0x1D22270
	|-Array.EmptyInternalEnumerator<Detail.Ranking2.Ranking2ChartInfoInt>..ctor
	|
	|-RVA: 0x1D22490 Offset: 0x1D22591 VA: 0x1D22490
	|-Array.EmptyInternalEnumerator<Detail.Ranking2.Ranking2RankDataInt>..ctor
	|
	|-RVA: 0x1D22680 Offset: 0x1D22781 VA: 0x1D22680
	|-Array.EmptyInternalEnumerator<Detail.Ranking2.Ranking2ScoreDataInt>..ctor
	|
	|-RVA: 0x1D22880 Offset: 0x1D22981 VA: 0x1D22880
	|-Array.EmptyInternalEnumerator<Detail.Screening.ScreeningContextInfoInt>..ctor
	|
	|-RVA: 0x1D22AD0 Offset: 0x1D22BD1 VA: 0x1D22AD0
	|-Array.EmptyInternalEnumerator<Detail.Subscriber.SubscriberContentInt>..ctor
	|
	|-RVA: 0x1D22CD0 Offset: 0x1D22DD1 VA: 0x1D22CD0
	|-Array.EmptyInternalEnumerator<Detail.Subscriber.SubscriberGetContentParamInt>..ctor
	|
	|-RVA: 0x1D22EE0 Offset: 0x1D22FE1 VA: 0x1D22EE0
	|-Array.EmptyInternalEnumerator<Detail.Subscriber.SubscriberUserStatusInfoInt>..ctor
	|
	|-RVA: 0x1D230E0 Offset: 0x1D231E1 VA: 0x1D230E0
	|-Array.EmptyInternalEnumerator<Detail.Subscriber.SubscriberUserStatusParamInt>..ctor
	|
	|-RVA: 0x1D232C0 Offset: 0x1D233C1 VA: 0x1D232C0
	|-Array.EmptyInternalEnumerator<Detail.Utility.IntegerSettings>..ctor
	|
	|-RVA: 0x1D234B0 Offset: 0x1D235B1 VA: 0x1D234B0
	|-Array.EmptyInternalEnumerator<Detail.Utility.UniqueIdInfoInt>..ctor
	|
	|-RVA: 0x1D236A0 Offset: 0x1D237A1 VA: 0x1D236A0
	|-Array.EmptyInternalEnumerator<FacetsChecker.FacetsCompiler.Map>..ctor
	|
	|-RVA: 0x1D238A0 Offset: 0x1D239A1 VA: 0x1D238A0
	|-Array.EmptyInternalEnumerator<MapHistory.ReplayAppearanceMap.Appearance>..ctor
	|
	|-RVA: 0x1D23A80 Offset: 0x1D23B81 VA: 0x1D23A80
	|-Array.EmptyInternalEnumerator<MapHistory.ReplayAppearanceMap.Leaving>..ctor
	|
	|-RVA: 0x1D23C60 Offset: 0x1D23D61 VA: 0x1D23C60
	|-Array.EmptyInternalEnumerator<MapHistory.ReplayUnitMap.Data>..ctor
	|
	|-RVA: 0x1D23E50 Offset: 0x1D23F51 VA: 0x1D23E50
	|-Array.EmptyInternalEnumerator<MapHistory.Rewind.LatestInspectorData>..ctor
	|
	|-RVA: 0x1D24040 Offset: 0x1D24141 VA: 0x1D24040
	|-Array.EmptyInternalEnumerator<MapHistory.Rewind.WorkTerrainData>..ctor
	|
	|-RVA: 0x1D24250 Offset: 0x1D24351 VA: 0x1D24250
	|-Array.EmptyInternalEnumerator<MapHistory.RewindUnitMap.Data>..ctor
	|
	|-RVA: 0x1D24430 Offset: 0x1D24531 VA: 0x1D24430
	|-Array.EmptyInternalEnumerator<MapKillBonus.Work.Pos>..ctor
	|
	|-RVA: 0x1D24620 Offset: 0x1D24721 VA: 0x1D24620
	|-Array.EmptyInternalEnumerator<MapSkill.AroundCalculator.Result>..ctor
	|
	|-RVA: 0x1D24800 Offset: 0x1D24901 VA: 0x1D24800
	|-Array.EmptyInternalEnumerator<Nex.ApiCallChecker.Guideline>..ctor
	|
	|-RVA: 0x1D24A00 Offset: 0x1D24B01 VA: 0x1D24A00
	|-Array.EmptyInternalEnumerator<Ngc.MaskTextSequenceBase.Data>..ctor
	|
	|-RVA: 0x1D24C10 Offset: 0x1D24D11 VA: 0x1D24C10
	|-Array.EmptyInternalEnumerator<TargetPositionCache.CacheCurve.Item>..ctor
	|
	|-RVA: 0x1D24E20 Offset: 0x1D24F21 VA: 0x1D24E20
	|-Array.EmptyInternalEnumerator<TargetPositionCache.CacheEntry.RecordingItem>..ctor
	|
	|-RVA: 0x1D25000 Offset: 0x1D25101 VA: 0x1D25000
	|-Array.EmptyInternalEnumerator<TerrainUtility.TerrainMap.TileCoord>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x263E600 Offset: 0x263E701 VA: 0x263E600
	|-Array.EmptyInternalEnumerator<ArraySegment<byte>>..cctor
	|
	|-RVA: 0x263E800 Offset: 0x263E901 VA: 0x263E800
	|-Array.EmptyInternalEnumerator<AsyncOperationHandle<object>>..cctor
	|
	|-RVA: 0x263E9E0 Offset: 0x263EAE1 VA: 0x263E9E0
	|-Array.EmptyInternalEnumerator<MapDeployTemplate.Queue.Data<object>>..cctor
	|
	|-RVA: 0x263EBD0 Offset: 0x263ECD1 VA: 0x263EBD0
	|-Array.EmptyInternalEnumerator<Nex.DataStore.ParamPool.Data<object>>..cctor
	|
	|-RVA: 0x263EDC0 Offset: 0x263EEC1 VA: 0x263EDC0
	|-Array.EmptyInternalEnumerator<Nex.Screening.ParamPool.Data<object>>..cctor
	|
	|-RVA: 0x263EFC0 Offset: 0x263F0C1 VA: 0x263EFC0
	|-Array.EmptyInternalEnumerator<IntervalTree.Entry<object>>..cctor
	|
	|-RVA: 0x263F1C0 Offset: 0x263F2C1 VA: 0x263F1C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<ValueTuple<object, int>, object>>..cctor
	|
	|-RVA: 0x263F3C0 Offset: 0x263F4C1 VA: 0x263F3C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<byte, object>>..cctor
	|
	|-RVA: 0x263F5C0 Offset: 0x263F6C1 VA: 0x263F5C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<CancellationToken, object>>..cctor
	|
	|-RVA: 0x263F7C0 Offset: 0x263F8C1 VA: 0x263F7C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<char, object>>..cctor
	|
	|-RVA: 0x263F9C0 Offset: 0x263FAC1 VA: 0x263F9C0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Guid, object>>..cctor
	|
	|-RVA: 0x263FBB0 Offset: 0x263FCB1 VA: 0x263FBB0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, bool>>..cctor
	|
	|-RVA: 0x263FDA0 Offset: 0x263FEA1 VA: 0x263FDA0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, byte>>..cctor
	|
	|-RVA: 0x263FF90 Offset: 0x2640091 VA: 0x263FF90
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, char>>..cctor
	|
	|-RVA: 0x26401B0 Offset: 0x26402B1 VA: 0x26401B0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, DiagnosticEvent>>..cctor
	|
	|-RVA: 0x26403A0 Offset: 0x26404A1 VA: 0x26403A0
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, int>>..cctor
	|
	|-RVA: 0x2640590 Offset: 0x2640691 VA: 0x2640590
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, Int32Enum>>..cctor
	|
	|-RVA: 0x2640790 Offset: 0x2640891 VA: 0x2640790
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, long>>..cctor
	|
	|-RVA: 0x2640990 Offset: 0x2640A91 VA: 0x2640990
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, MapPos>>..cctor
	|
	|-RVA: 0x2640B90 Offset: 0x2640C91 VA: 0x2640B90
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, object>>..cctor
	|
	|-RVA: 0x2640D80 Offset: 0x2640E81 VA: 0x2640D80
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, uint>>..cctor
	|
	|-RVA: 0x2640F70 Offset: 0x2641071 VA: 0x2640F70
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<int, AIThink.EnchantThink.SurroundingInfo>>..cctor
	|
	|-RVA: 0x2641160 Offset: 0x2641261 VA: 0x2641160
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, bool>>..cctor
	|
	|-RVA: 0x2641350 Offset: 0x2641451 VA: 0x2641350
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, int>>..cctor
	|
	|-RVA: 0x2641540 Offset: 0x2641641 VA: 0x2641540
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, Int32Enum>>..cctor
	|
	|-RVA: 0x2641740 Offset: 0x2641841 VA: 0x2641740
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Int32Enum, object>>..cctor
	|
	|-RVA: 0x2641940 Offset: 0x2641A41 VA: 0x2641940
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<long, object>>..cctor
	|
	|-RVA: 0x2641B40 Offset: 0x2641C41 VA: 0x2641B40
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<MapPos, int>>..cctor
	|
	|-RVA: 0x2641D50 Offset: 0x2641E51 VA: 0x2641D50
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, AsyncOperationHandle<object>>>..cctor
	|
	|-RVA: 0x2641F60 Offset: 0x2642061 VA: 0x2641F60
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, AsyncOperationHandle>>..cctor
	|
	|-RVA: 0x2642160 Offset: 0x2642261 VA: 0x2642160
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, bool>>..cctor
	|
	|-RVA: 0x2642360 Offset: 0x2642461 VA: 0x2642360
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, byte>>..cctor
	|
	|-RVA: 0x2642560 Offset: 0x2642661 VA: 0x2642560
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, int>>..cctor
	|
	|-RVA: 0x2642760 Offset: 0x2642861 VA: 0x2642760
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Int32Enum>>..cctor
	|
	|-RVA: 0x2642960 Offset: 0x2642A61 VA: 0x2642960
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, IntPtr>>..cctor
	|
	|-RVA: 0x2642B60 Offset: 0x2642C61 VA: 0x2642B60
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, object>>..cctor
	|
	|-RVA: 0x2642D60 Offset: 0x2642E61 VA: 0x2642D60
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, Playable>>..cctor
	|
	|-RVA: 0x2642F60 Offset: 0x2643061 VA: 0x2642F60
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, ResourceLocator>>..cctor
	|
	|-RVA: 0x2643160 Offset: 0x2643261 VA: 0x2643160
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, float>>..cctor
	|
	|-RVA: 0x2643360 Offset: 0x2643461 VA: 0x2643360
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, ushort>>..cctor
	|
	|-RVA: 0x2643560 Offset: 0x2643661 VA: 0x2643560
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<object, GameVariable.Value>>..cctor
	|
	|-RVA: 0x2643770 Offset: 0x2643871 VA: 0x2643770
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<sbyte, DataStoreRatingInfo>>..cctor
	|
	|-RVA: 0x2643970 Offset: 0x2643A71 VA: 0x2643970
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<sbyte, object>>..cctor
	|
	|-RVA: 0x2643B60 Offset: 0x2643C61 VA: 0x2643B60
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<ushort, int>>..cctor
	|
	|-RVA: 0x2643D50 Offset: 0x2643E51 VA: 0x2643D50
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<uint, int>>..cctor
	|
	|-RVA: 0x2643F50 Offset: 0x2644051 VA: 0x2643F50
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<uint, object>>..cctor
	|
	|-RVA: 0x2644160 Offset: 0x2644261 VA: 0x2644160
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<ulong, Friend>>..cctor
	|
	|-RVA: 0x2644360 Offset: 0x2644461 VA: 0x2644360
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<ulong, Int32Enum>>..cctor
	|
	|-RVA: 0x2644560 Offset: 0x2644661 VA: 0x2644560
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<ulong, object>>..cctor
	|
	|-RVA: 0x2644760 Offset: 0x2644861 VA: 0x2644760
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<Vector3, int>>..cctor
	|
	|-RVA: 0x2644970 Offset: 0x2644A71 VA: 0x2644970
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<XPathNodeRef, XPathNodeRef>>..cctor
	|
	|-RVA: 0x2644B70 Offset: 0x2644C71 VA: 0x2644B70
	|-Array.EmptyInternalEnumerator<Dictionary.Entry<TerrainUtility.TerrainMap.TileCoord, object>>..cctor
	|
	|-RVA: 0x2644D60 Offset: 0x2644E61 VA: 0x2644D60
	|-Array.EmptyInternalEnumerator<PriorityQueue.IndexedItem<object>>..cctor
	|
	|-RVA: 0x2644F60 Offset: 0x2645061 VA: 0x2644F60
	|-Array.EmptyInternalEnumerator<KeyValuePair<ValueTuple<object, int>, object>>..cctor
	|
	|-RVA: 0x2645150 Offset: 0x2645251 VA: 0x2645150
	|-Array.EmptyInternalEnumerator<KeyValuePair<byte, object>>..cctor
	|
	|-RVA: 0x2645340 Offset: 0x2645441 VA: 0x2645340
	|-Array.EmptyInternalEnumerator<KeyValuePair<CancellationToken, object>>..cctor
	|
	|-RVA: 0x2645530 Offset: 0x2645631 VA: 0x2645530
	|-Array.EmptyInternalEnumerator<KeyValuePair<char, object>>..cctor
	|
	|-RVA: 0x2645720 Offset: 0x2645821 VA: 0x2645720
	|-Array.EmptyInternalEnumerator<KeyValuePair<DateTime, object>>..cctor
	|
	|-RVA: 0x2645920 Offset: 0x2645A21 VA: 0x2645920
	|-Array.EmptyInternalEnumerator<KeyValuePair<Guid, object>>..cctor
	|
	|-RVA: 0x2645B00 Offset: 0x2645C01 VA: 0x2645B00
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, bool>>..cctor
	|
	|-RVA: 0x2645CE0 Offset: 0x2645DE1 VA: 0x2645CE0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, byte>>..cctor
	|
	|-RVA: 0x2645EC0 Offset: 0x2645FC1 VA: 0x2645EC0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, char>>..cctor
	|
	|-RVA: 0x26460D0 Offset: 0x26461D1 VA: 0x26460D0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, DiagnosticEvent>>..cctor
	|
	|-RVA: 0x26462B0 Offset: 0x26463B1 VA: 0x26462B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, int>>..cctor
	|
	|-RVA: 0x2646490 Offset: 0x2646591 VA: 0x2646490
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, Int32Enum>>..cctor
	|
	|-RVA: 0x2646680 Offset: 0x2646781 VA: 0x2646680
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, long>>..cctor
	|
	|-RVA: 0x2646870 Offset: 0x2646971 VA: 0x2646870
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, MapPos>>..cctor
	|
	|-RVA: 0x2646A60 Offset: 0x2646B61 VA: 0x2646A60
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, object>>..cctor
	|
	|-RVA: 0x2646C40 Offset: 0x2646D41 VA: 0x2646C40
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, uint>>..cctor
	|
	|-RVA: 0x2646E20 Offset: 0x2646F21 VA: 0x2646E20
	|-Array.EmptyInternalEnumerator<KeyValuePair<int, AIThink.EnchantThink.SurroundingInfo>>..cctor
	|
	|-RVA: 0x2647000 Offset: 0x2647101 VA: 0x2647000
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, bool>>..cctor
	|
	|-RVA: 0x26471E0 Offset: 0x26472E1 VA: 0x26471E0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, int>>..cctor
	|
	|-RVA: 0x26473C0 Offset: 0x26474C1 VA: 0x26473C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, Int32Enum>>..cctor
	|
	|-RVA: 0x26475B0 Offset: 0x26476B1 VA: 0x26475B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<Int32Enum, object>>..cctor
	|
	|-RVA: 0x26477A0 Offset: 0x26478A1 VA: 0x26477A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<long, object>>..cctor
	|
	|-RVA: 0x2647990 Offset: 0x2647A91 VA: 0x2647990
	|-Array.EmptyInternalEnumerator<KeyValuePair<MapPos, int>>..cctor
	|
	|-RVA: 0x2647B90 Offset: 0x2647C91 VA: 0x2647B90
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, AsyncOperationHandle<object>>>..cctor
	|
	|-RVA: 0x2647D90 Offset: 0x2647E91 VA: 0x2647D90
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, ValueTuple<int, DateTime, object>>>..cctor
	|
	|-RVA: 0x2647F90 Offset: 0x2648091 VA: 0x2647F90
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, AsyncOperationHandle>>..cctor
	|
	|-RVA: 0x2648180 Offset: 0x2648281 VA: 0x2648180
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, bool>>..cctor
	|
	|-RVA: 0x2648370 Offset: 0x2648471 VA: 0x2648370
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, byte>>..cctor
	|
	|-RVA: 0x2648560 Offset: 0x2648661 VA: 0x2648560
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, int>>..cctor
	|
	|-RVA: 0x2648750 Offset: 0x2648851 VA: 0x2648750
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Int32Enum>>..cctor
	|
	|-RVA: 0x2648940 Offset: 0x2648A41 VA: 0x2648940
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, IntPtr>>..cctor
	|
	|-RVA: 0x2648B30 Offset: 0x2648C31 VA: 0x2648B30
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, object>>..cctor
	|
	|-RVA: 0x2648D30 Offset: 0x2648E31 VA: 0x2648D30
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, Playable>>..cctor
	|
	|-RVA: 0x2648F30 Offset: 0x2649031 VA: 0x2648F30
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, ResourceLocator>>..cctor
	|
	|-RVA: 0x2649120 Offset: 0x2649221 VA: 0x2649120
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, float>>..cctor
	|
	|-RVA: 0x2649310 Offset: 0x2649411 VA: 0x2649310
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, ushort>>..cctor
	|
	|-RVA: 0x2649510 Offset: 0x2649611 VA: 0x2649510
	|-Array.EmptyInternalEnumerator<KeyValuePair<object, GameVariable.Value>>..cctor
	|
	|-RVA: 0x2649710 Offset: 0x2649811 VA: 0x2649710
	|-Array.EmptyInternalEnumerator<KeyValuePair<sbyte, DataStoreRatingInfo>>..cctor
	|
	|-RVA: 0x2649900 Offset: 0x2649A01 VA: 0x2649900
	|-Array.EmptyInternalEnumerator<KeyValuePair<sbyte, object>>..cctor
	|
	|-RVA: 0x2649AE0 Offset: 0x2649BE1 VA: 0x2649AE0
	|-Array.EmptyInternalEnumerator<KeyValuePair<ushort, int>>..cctor
	|
	|-RVA: 0x2649CC0 Offset: 0x2649DC1 VA: 0x2649CC0
	|-Array.EmptyInternalEnumerator<KeyValuePair<uint, int>>..cctor
	|
	|-RVA: 0x2649EB0 Offset: 0x2649FB1 VA: 0x2649EB0
	|-Array.EmptyInternalEnumerator<KeyValuePair<uint, object>>..cctor
	|
	|-RVA: 0x264A0C0 Offset: 0x264A1C1 VA: 0x264A0C0
	|-Array.EmptyInternalEnumerator<KeyValuePair<ulong, Friend>>..cctor
	|
	|-RVA: 0x264A2B0 Offset: 0x264A3B1 VA: 0x264A2B0
	|-Array.EmptyInternalEnumerator<KeyValuePair<ulong, Int32Enum>>..cctor
	|
	|-RVA: 0x264A4A0 Offset: 0x264A5A1 VA: 0x264A4A0
	|-Array.EmptyInternalEnumerator<KeyValuePair<ulong, object>>..cctor
	|
	|-RVA: 0x264A690 Offset: 0x264A791 VA: 0x264A690
	|-Array.EmptyInternalEnumerator<KeyValuePair<Vector3, int>>..cctor
	|
	|-RVA: 0x264A890 Offset: 0x264A991 VA: 0x264A890
	|-Array.EmptyInternalEnumerator<KeyValuePair<XPathNodeRef, XPathNodeRef>>..cctor
	|
	|-RVA: 0x264AA80 Offset: 0x264AB81 VA: 0x264AA80
	|-Array.EmptyInternalEnumerator<KeyValuePair<TerrainUtility.TerrainMap.TileCoord, object>>..cctor
	|
	|-RVA: 0x264AC70 Offset: 0x264AD71 VA: 0x264AC70
	|-Array.EmptyInternalEnumerator<NativeArray<PreTile>>..cctor
	|
	|-RVA: 0x264AE70 Offset: 0x264AF71 VA: 0x264AE70
	|-Array.EmptyInternalEnumerator<CommonBattleSequence.Reliance<object>>..cctor
	|
	|-RVA: 0x264B060 Offset: 0x264B161 VA: 0x264B060
	|-Array.EmptyInternalEnumerator<RenderGraphResourcePool.ResourceLogInfo<object>>..cctor
	|
	|-RVA: 0x264B260 Offset: 0x264B361 VA: 0x264B260
	|-Array.EmptyInternalEnumerator<HashSet.Slot<ValueTuple<object, int>>>..cctor
	|
	|-RVA: 0x264B460 Offset: 0x264B561 VA: 0x264B460
	|-Array.EmptyInternalEnumerator<HashSet.Slot<AsyncOperationHandle>>..cctor
	|
	|-RVA: 0x264B650 Offset: 0x264B751 VA: 0x264B650
	|-Array.EmptyInternalEnumerator<HashSet.Slot<int>>..cctor
	|
	|-RVA: 0x264B840 Offset: 0x264B941 VA: 0x264B840
	|-Array.EmptyInternalEnumerator<HashSet.Slot<Int32Enum>>..cctor
	|
	|-RVA: 0x264BA30 Offset: 0x264BB31 VA: 0x264BA30
	|-Array.EmptyInternalEnumerator<Set.Slot<Int32Enum>>..cctor
	|
	|-RVA: 0x264BC20 Offset: 0x264BD21 VA: 0x264BC20
	|-Array.EmptyInternalEnumerator<HashSet.Slot<MapPos>>..cctor
	|
	|-RVA: 0x264BE10 Offset: 0x264BF11 VA: 0x264BE10
	|-Array.EmptyInternalEnumerator<HashSet.Slot<object>>..cctor
	|
	|-RVA: 0x264C010 Offset: 0x264C111 VA: 0x264C010
	|-Array.EmptyInternalEnumerator<Set.Slot<object>>..cctor
	|
	|-RVA: 0x264C200 Offset: 0x264C301 VA: 0x264C200
	|-Array.EmptyInternalEnumerator<HashSet.Slot<uint>>..cctor
	|
	|-RVA: 0x264C3F0 Offset: 0x264C4F1 VA: 0x264C3F0
	|-Array.EmptyInternalEnumerator<HashSet.Slot<ulong>>..cctor
	|
	|-RVA: 0x264C5F0 Offset: 0x264C6F1 VA: 0x264C5F0
	|-Array.EmptyInternalEnumerator<Set.Slot<Vector3>>..cctor
	|
	|-RVA: 0x264C7F0 Offset: 0x264C8F1 VA: 0x264C7F0
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<Color32>>..cctor
	|
	|-RVA: 0x264CA00 Offset: 0x264CB01 VA: 0x264CA00
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<HighlightState>>..cctor
	|
	|-RVA: 0x264CC00 Offset: 0x264CD01 VA: 0x264CC00
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<int>>..cctor
	|
	|-RVA: 0x264CE00 Offset: 0x264CF01 VA: 0x264CE00
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<Int32Enum>>..cctor
	|
	|-RVA: 0x264D060 Offset: 0x264D161 VA: 0x264D060
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<MaterialReference>>..cctor
	|
	|-RVA: 0x264D270 Offset: 0x264D371 VA: 0x264D270
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<object>>..cctor
	|
	|-RVA: 0x264D470 Offset: 0x264D571 VA: 0x264D470
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<float>>..cctor
	|
	|-RVA: 0x264D680 Offset: 0x264D781 VA: 0x264D680
	|-Array.EmptyInternalEnumerator<TMP_TextProcessingStack<WordWrapState>>..cctor
	|
	|-RVA: 0x264D870 Offset: 0x264D971 VA: 0x264D870
	|-Array.EmptyInternalEnumerator<TimeInterval<object>>..cctor
	|
	|-RVA: 0x264DA70 Offset: 0x264DB71 VA: 0x264DA70
	|-Array.EmptyInternalEnumerator<Timestamped<object>>..cctor
	|
	|-RVA: 0x264DC60 Offset: 0x264DD61 VA: 0x264DC60
	|-Array.EmptyInternalEnumerator<UniTask<object>>..cctor
	|
	|-RVA: 0x264DE50 Offset: 0x264DF51 VA: 0x264DE50
	|-Array.EmptyInternalEnumerator<ValueTuple<ValueTuple<bool, object>>>..cctor
	|
	|-RVA: 0x264E050 Offset: 0x264E151 VA: 0x264E050
	|-Array.EmptyInternalEnumerator<ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>..cctor
	|
	|-RVA: 0x264E250 Offset: 0x264E351 VA: 0x264E250
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, UniTask<object>>>..cctor
	|
	|-RVA: 0x264E450 Offset: 0x264E551 VA: 0x264E450
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>..cctor
	|
	|-RVA: 0x264E660 Offset: 0x264E761 VA: 0x264E660
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>..cctor
	|
	|-RVA: 0x264E870 Offset: 0x264E971 VA: 0x264E870
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>..cctor
	|
	|-RVA: 0x264EA60 Offset: 0x264EB61 VA: 0x264EA60
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>..cctor
	|
	|-RVA: 0x264EC50 Offset: 0x264ED51 VA: 0x264EC50
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>..cctor
	|
	|-RVA: 0x264EE70 Offset: 0x264EF71 VA: 0x264EE70
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>..cctor
	|
	|-RVA: 0x264F060 Offset: 0x264F161 VA: 0x264F060
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>..cctor
	|
	|-RVA: 0x264F270 Offset: 0x264F371 VA: 0x264F270
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>..cctor
	|
	|-RVA: 0x264F480 Offset: 0x264F581 VA: 0x264F480
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>..cctor
	|
	|-RVA: 0x264F680 Offset: 0x264F781 VA: 0x264F680
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>..cctor
	|
	|-RVA: 0x264F890 Offset: 0x264F991 VA: 0x264F890
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>..cctor
	|
	|-RVA: 0x264FAA0 Offset: 0x264FBA1 VA: 0x264FAA0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>..cctor
	|
	|-RVA: 0x264FCB0 Offset: 0x264FDB1 VA: 0x264FCB0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>..cctor
	|
	|-RVA: 0x264FEC0 Offset: 0x264FFC1 VA: 0x264FEC0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>..cctor
	|
	|-RVA: 0x26500C0 Offset: 0x26501C1 VA: 0x26500C0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>..cctor
	|
	|-RVA: 0x26502D0 Offset: 0x26503D1 VA: 0x26502D0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>..cctor
	|
	|-RVA: 0x26504C0 Offset: 0x26505C1 VA: 0x26504C0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>..cctor
	|
	|-RVA: 0x26506D0 Offset: 0x26507D1 VA: 0x26506D0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>..cctor
	|
	|-RVA: 0x26508D0 Offset: 0x26509D1 VA: 0x26508D0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>..cctor
	|
	|-RVA: 0x2650AE0 Offset: 0x2650BE1 VA: 0x2650AE0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>..cctor
	|
	|-RVA: 0x2650CF0 Offset: 0x2650DF1 VA: 0x2650CF0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>..cctor
	|
	|-RVA: 0x2650F00 Offset: 0x2651001 VA: 0x2650F00
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>..cctor
	|
	|-RVA: 0x2651110 Offset: 0x2651211 VA: 0x2651110
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>..cctor
	|
	|-RVA: 0x2651330 Offset: 0x2651431 VA: 0x2651330
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>..cctor
	|
	|-RVA: 0x2651580 Offset: 0x2651681 VA: 0x2651580
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>..cctor
	|
	|-RVA: 0x26517D0 Offset: 0x26518D1 VA: 0x26517D0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>..cctor
	|
	|-RVA: 0x2651A30 Offset: 0x2651B31 VA: 0x2651A30
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>..cctor
	|
	|-RVA: 0x2651C20 Offset: 0x2651D21 VA: 0x2651C20
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>..cctor
	|
	|-RVA: 0x2651E10 Offset: 0x2651F11 VA: 0x2651E10
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>..cctor
	|
	|-RVA: 0x2652020 Offset: 0x2652121 VA: 0x2652020
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>..cctor
	|
	|-RVA: 0x2652210 Offset: 0x2652311 VA: 0x2652210
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>..cctor
	|
	|-RVA: 0x2652410 Offset: 0x2652511 VA: 0x2652410
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>..cctor
	|
	|-RVA: 0x2652620 Offset: 0x2652721 VA: 0x2652620
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>..cctor
	|
	|-RVA: 0x2652820 Offset: 0x2652921 VA: 0x2652820
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>..cctor
	|
	|-RVA: 0x2652A30 Offset: 0x2652B31 VA: 0x2652A30
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>..cctor
	|
	|-RVA: 0x2652C40 Offset: 0x2652D41 VA: 0x2652C40
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>..cctor
	|
	|-RVA: 0x2652E40 Offset: 0x2652F41 VA: 0x2652E40
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>..cctor
	|
	|-RVA: 0x2653040 Offset: 0x2653141 VA: 0x2653040
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>..cctor
	|
	|-RVA: 0x2653240 Offset: 0x2653341 VA: 0x2653240
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>..cctor
	|
	|-RVA: 0x2653450 Offset: 0x2653551 VA: 0x2653450
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>..cctor
	|
	|-RVA: 0x2653640 Offset: 0x2653741 VA: 0x2653640
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>..cctor
	|
	|-RVA: 0x2653840 Offset: 0x2653941 VA: 0x2653840
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>..cctor
	|
	|-RVA: 0x2653A50 Offset: 0x2653B51 VA: 0x2653A50
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>..cctor
	|
	|-RVA: 0x2653C50 Offset: 0x2653D51 VA: 0x2653C50
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>..cctor
	|
	|-RVA: 0x2653E60 Offset: 0x2653F61 VA: 0x2653E60
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>..cctor
	|
	|-RVA: 0x2654070 Offset: 0x2654171 VA: 0x2654070
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>..cctor
	|
	|-RVA: 0x2654290 Offset: 0x2654391 VA: 0x2654290
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..cctor
	|
	|-RVA: 0x26544A0 Offset: 0x26545A1 VA: 0x26544A0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>..cctor
	|
	|-RVA: 0x26546F0 Offset: 0x26547F1 VA: 0x26546F0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..cctor
	|
	|-RVA: 0x2654900 Offset: 0x2654A01 VA: 0x2654900
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>..cctor
	|
	|-RVA: 0x2654B80 Offset: 0x2654C81 VA: 0x2654B80
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..cctor
	|
	|-RVA: 0x2654DA0 Offset: 0x2654EA1 VA: 0x2654DA0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>..cctor
	|
	|-RVA: 0x2655030 Offset: 0x2655131 VA: 0x2655030
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..cctor
	|
	|-RVA: 0x2655280 Offset: 0x2655381 VA: 0x2655280
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>..cctor
	|
	|-RVA: 0x2655530 Offset: 0x2655631 VA: 0x2655530
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..cctor
	|
	|-RVA: 0x2655780 Offset: 0x2655881 VA: 0x2655780
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>..cctor
	|
	|-RVA: 0x2655960 Offset: 0x2655A61 VA: 0x2655960
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>..cctor
	|
	|-RVA: 0x2655B40 Offset: 0x2655C41 VA: 0x2655B40
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>..cctor
	|
	|-RVA: 0x2655D50 Offset: 0x2655E51 VA: 0x2655D50
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>..cctor
	|
	|-RVA: 0x2655F30 Offset: 0x2656031 VA: 0x2655F30
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>..cctor
	|
	|-RVA: 0x2656140 Offset: 0x2656241 VA: 0x2656140
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>..cctor
	|
	|-RVA: 0x2656340 Offset: 0x2656441 VA: 0x2656340
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>..cctor
	|
	|-RVA: 0x2656530 Offset: 0x2656631 VA: 0x2656530
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>..cctor
	|
	|-RVA: 0x2656730 Offset: 0x2656831 VA: 0x2656730
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>..cctor
	|
	|-RVA: 0x2656930 Offset: 0x2656A31 VA: 0x2656930
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>..cctor
	|
	|-RVA: 0x2656B40 Offset: 0x2656C41 VA: 0x2656B40
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>..cctor
	|
	|-RVA: 0x2656D50 Offset: 0x2656E51 VA: 0x2656D50
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>..cctor
	|
	|-RVA: 0x2656F40 Offset: 0x2657041 VA: 0x2656F40
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>..cctor
	|
	|-RVA: 0x2657140 Offset: 0x2657241 VA: 0x2657140
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>..cctor
	|
	|-RVA: 0x2657320 Offset: 0x2657421 VA: 0x2657320
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>..cctor
	|
	|-RVA: 0x2657520 Offset: 0x2657621 VA: 0x2657520
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>..cctor
	|
	|-RVA: 0x2657720 Offset: 0x2657821 VA: 0x2657720
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>..cctor
	|
	|-RVA: 0x2657930 Offset: 0x2657A31 VA: 0x2657930
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>..cctor
	|
	|-RVA: 0x2657B30 Offset: 0x2657C31 VA: 0x2657B30
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>..cctor
	|
	|-RVA: 0x2657D30 Offset: 0x2657E31 VA: 0x2657D30
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>..cctor
	|
	|-RVA: 0x2657F40 Offset: 0x2658041 VA: 0x2657F40
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..cctor
	|
	|-RVA: 0x2658150 Offset: 0x2658251 VA: 0x2658150
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>..cctor
	|
	|-RVA: 0x26583A0 Offset: 0x26584A1 VA: 0x26583A0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..cctor
	|
	|-RVA: 0x26585B0 Offset: 0x26586B1 VA: 0x26585B0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>..cctor
	|
	|-RVA: 0x2658810 Offset: 0x2658911 VA: 0x2658810
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..cctor
	|
	|-RVA: 0x2658A20 Offset: 0x2658B21 VA: 0x2658A20
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>..cctor
	|
	|-RVA: 0x2658CB0 Offset: 0x2658DB1 VA: 0x2658CB0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..cctor
	|
	|-RVA: 0x2658ED0 Offset: 0x2658FD1 VA: 0x2658ED0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>..cctor
	|
	|-RVA: 0x2659170 Offset: 0x2659271 VA: 0x2659170
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..cctor
	|
	|-RVA: 0x26593C0 Offset: 0x26594C1 VA: 0x26593C0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>..cctor
	|
	|-RVA: 0x26595D0 Offset: 0x26596D1 VA: 0x26595D0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>..cctor
	|
	|-RVA: 0x26597E0 Offset: 0x26598E1 VA: 0x26597E0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>..cctor
	|
	|-RVA: 0x26599D0 Offset: 0x2659AD1 VA: 0x26599D0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>..cctor
	|
	|-RVA: 0x2659BC0 Offset: 0x2659CC1 VA: 0x2659BC0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, bool>>>..cctor
	|
	|-RVA: 0x2659DC0 Offset: 0x2659EC1 VA: 0x2659DC0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, Bounds>>>..cctor
	|
	|-RVA: 0x2659FB0 Offset: 0x265A0B1 VA: 0x2659FB0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, byte>>>..cctor
	|
	|-RVA: 0x265A1B0 Offset: 0x265A2B1 VA: 0x265A1B0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, Color>>>..cctor
	|
	|-RVA: 0x265A3B0 Offset: 0x265A4B1 VA: 0x265A3B0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, double>>>..cctor
	|
	|-RVA: 0x265A5A0 Offset: 0x265A6A1 VA: 0x265A5A0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, int>>>..cctor
	|
	|-RVA: 0x1CF0E60 Offset: 0x1CF0F61 VA: 0x1CF0E60
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, long>>>..cctor
	|
	|-RVA: 0x1CF1060 Offset: 0x1CF1161 VA: 0x1CF1060
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, object>>>..cctor
	|
	|-RVA: 0x1CF1260 Offset: 0x1CF1361 VA: 0x1CF1260
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, Quaternion>>>..cctor
	|
	|-RVA: 0x1CF1460 Offset: 0x1CF1561 VA: 0x1CF1460
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, Rect>>>..cctor
	|
	|-RVA: 0x1CF1650 Offset: 0x1CF1751 VA: 0x1CF1650
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, float>>>..cctor
	|
	|-RVA: 0x1CF1850 Offset: 0x1CF1951 VA: 0x1CF1850
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, UniTask>>>..cctor
	|
	|-RVA: 0x1CF1A40 Offset: 0x1CF1B41 VA: 0x1CF1A40
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, Unit>>>..cctor
	|
	|-RVA: 0x1CF1C30 Offset: 0x1CF1D31 VA: 0x1CF1C30
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, Vector2>>>..cctor
	|
	|-RVA: 0x1CF1E30 Offset: 0x1CF1F31 VA: 0x1CF1E30
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, Vector3>>>..cctor
	|
	|-RVA: 0x1CF2030 Offset: 0x1CF2131 VA: 0x1CF2030
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<bool, Vector4>>>..cctor
	|
	|-RVA: 0x1CF2230 Offset: 0x1CF2331 VA: 0x1CF2230
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<int, object>>>..cctor
	|
	|-RVA: 0x1CF2430 Offset: 0x1CF2531 VA: 0x1CF2430
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<object, object>>>..cctor
	|
	|-RVA: 0x1CF2640 Offset: 0x1CF2741 VA: 0x1CF2640
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..cctor
	|
	|-RVA: 0x1CF2840 Offset: 0x1CF2941 VA: 0x1CF2840
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<object, object, object>>>..cctor
	|
	|-RVA: 0x1CF2A60 Offset: 0x1CF2B61 VA: 0x1CF2A60
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..cctor
	|
	|-RVA: 0x1CF2C70 Offset: 0x1CF2D71 VA: 0x1CF2C70
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<object, object, object, object>>>..cctor
	|
	|-RVA: 0x1CF2EC0 Offset: 0x1CF2FC1 VA: 0x1CF2EC0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..cctor
	|
	|-RVA: 0x1CF30D0 Offset: 0x1CF31D1 VA: 0x1CF30D0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>..cctor
	|
	|-RVA: 0x1CF3350 Offset: 0x1CF3451 VA: 0x1CF3350
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..cctor
	|
	|-RVA: 0x1CF3560 Offset: 0x1CF3661 VA: 0x1CF3560
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>..cctor
	|
	|-RVA: 0x1CF37F0 Offset: 0x1CF38F1 VA: 0x1CF37F0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>..cctor
	|
	|-RVA: 0x1CF3A10 Offset: 0x1CF3B11 VA: 0x1CF3A10
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>..cctor
	|
	|-RVA: 0x1CF3CC0 Offset: 0x1CF3DC1 VA: 0x1CF3CC0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>..cctor
	|
	|-RVA: 0x1CF3ED0 Offset: 0x1CF3FD1 VA: 0x1CF3ED0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>..cctor
	|
	|-RVA: 0x1CF40B0 Offset: 0x1CF41B1 VA: 0x1CF40B0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, AsyncUnit>>..cctor
	|
	|-RVA: 0x1CF4290 Offset: 0x1CF4391 VA: 0x1CF4290
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, bool>>..cctor
	|
	|-RVA: 0x1CF44A0 Offset: 0x1CF45A1 VA: 0x1CF44A0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Bounds>>..cctor
	|
	|-RVA: 0x1CF4680 Offset: 0x1CF4781 VA: 0x1CF4680
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, byte>>..cctor
	|
	|-RVA: 0x1CF4880 Offset: 0x1CF4981 VA: 0x1CF4880
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Color>>..cctor
	|
	|-RVA: 0x1CF4A70 Offset: 0x1CF4B71 VA: 0x1CF4A70
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, double>>..cctor
	|
	|-RVA: 0x1CF4C50 Offset: 0x1CF4D51 VA: 0x1CF4C50
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, int>>..cctor
	|
	|-RVA: 0x1CF4E40 Offset: 0x1CF4F41 VA: 0x1CF4E40
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, long>>..cctor
	|
	|-RVA: 0x1CF5030 Offset: 0x1CF5131 VA: 0x1CF5030
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, object>>..cctor
	|
	|-RVA: 0x1CF5230 Offset: 0x1CF5331 VA: 0x1CF5230
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Quaternion>>..cctor
	|
	|-RVA: 0x1CF5430 Offset: 0x1CF5531 VA: 0x1CF5430
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Rect>>..cctor
	|
	|-RVA: 0x1CF5610 Offset: 0x1CF5711 VA: 0x1CF5610
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, float>>..cctor
	|
	|-RVA: 0x1CF5800 Offset: 0x1CF5901 VA: 0x1CF5800
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, UniTask>>..cctor
	|
	|-RVA: 0x1CF59E0 Offset: 0x1CF5AE1 VA: 0x1CF59E0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Unit>>..cctor
	|
	|-RVA: 0x1CF5BD0 Offset: 0x1CF5CD1 VA: 0x1CF5BD0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Vector2>>..cctor
	|
	|-RVA: 0x1CF5DC0 Offset: 0x1CF5EC1 VA: 0x1CF5DC0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Vector3>>..cctor
	|
	|-RVA: 0x1CF5FC0 Offset: 0x1CF60C1 VA: 0x1CF5FC0
	|-Array.EmptyInternalEnumerator<ValueTuple<bool, Vector4>>..cctor
	|
	|-RVA: 0x1CF61A0 Offset: 0x1CF62A1 VA: 0x1CF61A0
	|-Array.EmptyInternalEnumerator<ValueTuple<int, bool>>..cctor
	|
	|-RVA: 0x1CF63B0 Offset: 0x1CF64B1 VA: 0x1CF63B0
	|-Array.EmptyInternalEnumerator<ValueTuple<int, Bounds>>..cctor
	|
	|-RVA: 0x1CF6590 Offset: 0x1CF6691 VA: 0x1CF6590
	|-Array.EmptyInternalEnumerator<ValueTuple<int, byte>>..cctor
	|
	|-RVA: 0x1CF6790 Offset: 0x1CF6891 VA: 0x1CF6790
	|-Array.EmptyInternalEnumerator<ValueTuple<int, Color>>..cctor
	|
	|-RVA: 0x1CF6980 Offset: 0x1CF6A81 VA: 0x1CF6980
	|-Array.EmptyInternalEnumerator<ValueTuple<int, double>>..cctor
	|
	|-RVA: 0x1CF6B60 Offset: 0x1CF6C61 VA: 0x1CF6B60
	|-Array.EmptyInternalEnumerator<ValueTuple<int, int>>..cctor
	|
	|-RVA: 0x1CF6D50 Offset: 0x1CF6E51 VA: 0x1CF6D50
	|-Array.EmptyInternalEnumerator<ValueTuple<int, long>>..cctor
	|
	|-RVA: 0x1CF6F40 Offset: 0x1CF7041 VA: 0x1CF6F40
	|-Array.EmptyInternalEnumerator<ValueTuple<int, object>>..cctor
	|
	|-RVA: 0x1CF7140 Offset: 0x1CF7241 VA: 0x1CF7140
	|-Array.EmptyInternalEnumerator<ValueTuple<int, Quaternion>>..cctor
	|
	|-RVA: 0x1CF7340 Offset: 0x1CF7441 VA: 0x1CF7340
	|-Array.EmptyInternalEnumerator<ValueTuple<int, Rect>>..cctor
	|
	|-RVA: 0x1CF7520 Offset: 0x1CF7621 VA: 0x1CF7520
	|-Array.EmptyInternalEnumerator<ValueTuple<int, float>>..cctor
	|
	|-RVA: 0x1CF7700 Offset: 0x1CF7801 VA: 0x1CF7700
	|-Array.EmptyInternalEnumerator<ValueTuple<int, Unit>>..cctor
	|
	|-RVA: 0x1CF78F0 Offset: 0x1CF79F1 VA: 0x1CF78F0
	|-Array.EmptyInternalEnumerator<ValueTuple<int, Vector2>>..cctor
	|
	|-RVA: 0x1CF7AE0 Offset: 0x1CF7BE1 VA: 0x1CF7AE0
	|-Array.EmptyInternalEnumerator<ValueTuple<int, Vector3>>..cctor
	|
	|-RVA: 0x1CF7CE0 Offset: 0x1CF7DE1 VA: 0x1CF7CE0
	|-Array.EmptyInternalEnumerator<ValueTuple<int, Vector4>>..cctor
	|
	|-RVA: 0x1CF7EC0 Offset: 0x1CF7FC1 VA: 0x1CF7EC0
	|-Array.EmptyInternalEnumerator<ValueTuple<Int32Enum, int>>..cctor
	|
	|-RVA: 0x1CF80C0 Offset: 0x1CF81C1 VA: 0x1CF80C0
	|-Array.EmptyInternalEnumerator<ValueTuple<object, ValueTuple<object, int>>>..cctor
	|
	|-RVA: 0x1CF82B0 Offset: 0x1CF83B1 VA: 0x1CF82B0
	|-Array.EmptyInternalEnumerator<ValueTuple<object, int>>..cctor
	|
	|-RVA: 0x1CF84A0 Offset: 0x1CF85A1 VA: 0x1CF84A0
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object>>..cctor
	|
	|-RVA: 0x1CF8690 Offset: 0x1CF8791 VA: 0x1CF8690
	|-Array.EmptyInternalEnumerator<ValueTuple<object, float>>..cctor
	|
	|-RVA: 0x1CF8880 Offset: 0x1CF8981 VA: 0x1CF8880
	|-Array.EmptyInternalEnumerator<ValueTuple<Vector3, float>>..cctor
	|
	|-RVA: 0x1CF8A90 Offset: 0x1CF8B91 VA: 0x1CF8A90
	|-Array.EmptyInternalEnumerator<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>..cctor
	|
	|-RVA: 0x1CF8C80 Offset: 0x1CF8D81 VA: 0x1CF8C80
	|-Array.EmptyInternalEnumerator<ValueTuple<object, Int32Enum, int>>..cctor
	|
	|-RVA: 0x1CF8E80 Offset: 0x1CF8F81 VA: 0x1CF8E80
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object, object>>..cctor
	|
	|-RVA: 0x1CF9090 Offset: 0x1CF9191 VA: 0x1CF9090
	|-Array.EmptyInternalEnumerator<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>..cctor
	|
	|-RVA: 0x1CF9290 Offset: 0x1CF9391 VA: 0x1CF9290
	|-Array.EmptyInternalEnumerator<ValueTuple<object, int, int, int>>..cctor
	|
	|-RVA: 0x1CF9490 Offset: 0x1CF9591 VA: 0x1CF9490
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object, object, object>>..cctor
	|
	|-RVA: 0x1CF96E0 Offset: 0x1CF97E1 VA: 0x1CF96E0
	|-Array.EmptyInternalEnumerator<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>..cctor
	|
	|-RVA: 0x1CF98F0 Offset: 0x1CF99F1 VA: 0x1CF98F0
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object, object, object, object>>..cctor
	|
	|-RVA: 0x1CF9B50 Offset: 0x1CF9C51 VA: 0x1CF9B50
	|-Array.EmptyInternalEnumerator<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>..cctor
	|
	|-RVA: 0x1CF9D60 Offset: 0x1CF9E61 VA: 0x1CF9D60
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object, object, object, object, object>>..cctor
	|
	|-RVA: 0x1CF9FF0 Offset: 0x1CFA0F1 VA: 0x1CF9FF0
	|-Array.EmptyInternalEnumerator<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>..cctor
	|
	|-RVA: 0x1CFA200 Offset: 0x1CFA301 VA: 0x1CFA200
	|-Array.EmptyInternalEnumerator<ValueTuple<object, object, object, object, object, object, object>>..cctor
	|
	|-RVA: 0x1CFA4A0 Offset: 0x1CFA5A1 VA: 0x1CFA4A0
	|-Array.EmptyInternalEnumerator<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>..cctor
	|
	|-RVA: 0x1CFA6B0 Offset: 0x1CFA7B1 VA: 0x1CFA6B0
	|-Array.EmptyInternalEnumerator<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>..cctor
	|
	|-RVA: 0x1CFA890 Offset: 0x1CFA991 VA: 0x1CFA890
	|-Array.EmptyInternalEnumerator<AnimatorClipInfo>..cctor
	|
	|-RVA: 0x1CFAA90 Offset: 0x1CFAB91 VA: 0x1CFAA90
	|-Array.EmptyInternalEnumerator<AsyncOperationHandle>..cctor
	|
	|-RVA: 0x1CFAC70 Offset: 0x1CFAD71 VA: 0x1CFAC70
	|-Array.EmptyInternalEnumerator<AsyncUnit>..cctor
	|
	|-RVA: 0x1CFAE60 Offset: 0x1CFAF61 VA: 0x1CFAE60
	|-Array.EmptyInternalEnumerator<BatchVisibility>..cctor
	|
	|-RVA: 0x1CFB060 Offset: 0x1CFB161 VA: 0x1CFB060
	|-Array.EmptyInternalEnumerator<BoneWeight>..cctor
	|
	|-RVA: 0x1CFB240 Offset: 0x1CFB341 VA: 0x1CFB240
	|-Array.EmptyInternalEnumerator<BoneWeight1>..cctor
	|
	|-RVA: 0x1CFB420 Offset: 0x1CFB521 VA: 0x1CFB420
	|-Array.EmptyInternalEnumerator<bool>..cctor
	|
	|-RVA: 0x1CFB620 Offset: 0x1CFB721 VA: 0x1CFB620
	|-Array.EmptyInternalEnumerator<Bounds>..cctor
	|
	|-RVA: 0x1CFB800 Offset: 0x1CFB901 VA: 0x1CFB800
	|-Array.EmptyInternalEnumerator<byte>..cctor
	|
	|-RVA: 0x1CFB9E0 Offset: 0x1CFBAE1 VA: 0x1CFB9E0
	|-Array.EmptyInternalEnumerator<ByteEnum>..cctor
	|
	|-RVA: 0x1CFBBD0 Offset: 0x1CFBCD1 VA: 0x1CFBBD0
	|-Array.EmptyInternalEnumerator<CameraInfo>..cctor
	|
	|-RVA: 0x1CFBDB0 Offset: 0x1CFBEB1 VA: 0x1CFBDB0
	|-Array.EmptyInternalEnumerator<CancellationToken>..cctor
	|
	|-RVA: 0x1CFBFB0 Offset: 0x1CFC0B1 VA: 0x1CFBFB0
	|-Array.EmptyInternalEnumerator<CancellationTokenRegistration>..cctor
	|
	|-RVA: 0x1CFC190 Offset: 0x1CFC291 VA: 0x1CFC190
	|-Array.EmptyInternalEnumerator<char>..cctor
	|
	|-RVA: 0x1CFC390 Offset: 0x1CFC491 VA: 0x1CFC390
	|-Array.EmptyInternalEnumerator<ClusteringData>..cctor
	|
	|-RVA: 0x1CFC5A0 Offset: 0x1CFC6A1 VA: 0x1CFC5A0
	|-Array.EmptyInternalEnumerator<ClusteringProcessorState>..cctor
	|
	|-RVA: 0x1CFC790 Offset: 0x1CFC891 VA: 0x1CFC790
	|-Array.EmptyInternalEnumerator<Color>..cctor
	|
	|-RVA: 0x1CFC970 Offset: 0x1CFCA71 VA: 0x1CFC970
	|-Array.EmptyInternalEnumerator<Color32>..cctor
	|
	|-RVA: 0x1CFCB50 Offset: 0x1CFCC51 VA: 0x1CFCB50
	|-Array.EmptyInternalEnumerator<Color4u8>..cctor
	|
	|-RVA: 0x1CFCDB0 Offset: 0x1CFCEB1 VA: 0x1CFCDB0
	|-Array.EmptyInternalEnumerator<ColorBlock>..cctor
	|
	|-RVA: 0x1CFD040 Offset: 0x1CFD141 VA: 0x1CFD040
	|-Array.EmptyInternalEnumerator<CombineInstance>..cctor
	|
	|-RVA: 0x1CFD230 Offset: 0x1CFD331 VA: 0x1CFD230
	|-Array.EmptyInternalEnumerator<ConstraintSource>..cctor
	|
	|-RVA: 0x1CFD440 Offset: 0x1CFD541 VA: 0x1CFD440
	|-Array.EmptyInternalEnumerator<ContactPoint>..cctor
	|
	|-RVA: 0x1CFD650 Offset: 0x1CFD751 VA: 0x1CFD650
	|-Array.EmptyInternalEnumerator<ContactPoint2D>..cctor
	|
	|-RVA: 0x1CFD850 Offset: 0x1CFD951 VA: 0x1CFD850
	|-Array.EmptyInternalEnumerator<ContourVertex>..cctor
	|
	|-RVA: 0x1CFDA50 Offset: 0x1CFDB51 VA: 0x1CFDA50
	|-Array.EmptyInternalEnumerator<CustomAttributeNamedArgument>..cctor
	|
	|-RVA: 0x1CFDC40 Offset: 0x1CFDD41 VA: 0x1CFDC40
	|-Array.EmptyInternalEnumerator<CustomAttributeTypedArgument>..cctor
	|
	|-RVA: 0x1CFDE40 Offset: 0x1CFDF41 VA: 0x1CFDE40
	|-Array.EmptyInternalEnumerator<DataStoreRatingInfo>..cctor
	|
	|-RVA: 0x1CFE020 Offset: 0x1CFE121 VA: 0x1CFE020
	|-Array.EmptyInternalEnumerator<DataStoreResult>..cctor
	|
	|-RVA: 0x1CFE200 Offset: 0x1CFE301 VA: 0x1CFE200
	|-Array.EmptyInternalEnumerator<DateTime>..cctor
	|
	|-RVA: 0x1CFE3F0 Offset: 0x1CFE4F1 VA: 0x1CFE3F0
	|-Array.EmptyInternalEnumerator<DateTimeOffset>..cctor
	|
	|-RVA: 0x1CFE5F0 Offset: 0x1CFE6F1 VA: 0x1CFE5F0
	|-Array.EmptyInternalEnumerator<DebugPadState>..cctor
	|
	|-RVA: 0x1CFE7E0 Offset: 0x1CFE8E1 VA: 0x1CFE7E0
	|-Array.EmptyInternalEnumerator<Decimal>..cctor
	|
	|-RVA: 0x1CFEA80 Offset: 0x1CFEB81 VA: 0x1CFEA80
	|-Array.EmptyInternalEnumerator<DeferredTiler>..cctor
	|
	|-RVA: 0x1CFEC70 Offset: 0x1CFED71 VA: 0x1CFEC70
	|-Array.EmptyInternalEnumerator<DeviceHandle>..cctor
	|
	|-RVA: 0x1CFEE80 Offset: 0x1CFEF81 VA: 0x1CFEE80
	|-Array.EmptyInternalEnumerator<DiagnosticEvent>..cctor
	|
	|-RVA: 0x1CFF070 Offset: 0x1CFF171 VA: 0x1CFF070
	|-Array.EmptyInternalEnumerator<DictionaryEntry>..cctor
	|
	|-RVA: 0x1CFF250 Offset: 0x1CFF351 VA: 0x1CFF250
	|-Array.EmptyInternalEnumerator<DictionaryInfo>..cctor
	|
	|-RVA: 0x1CFF450 Offset: 0x1CFF551 VA: 0x1CFF450
	|-Array.EmptyInternalEnumerator<DirectoryEntry>..cctor
	|
	|-RVA: 0x1CFF630 Offset: 0x1CFF731 VA: 0x1CFF630
	|-Array.EmptyInternalEnumerator<double>..cctor
	|
	|-RVA: 0x1CFF820 Offset: 0x1CFF921 VA: 0x1CFF820
	|-Array.EmptyInternalEnumerator<Ephemeron>..cctor
	|
	|-RVA: 0x1CFFA00 Offset: 0x1CFFB01 VA: 0x1CFFA00
	|-Array.EmptyInternalEnumerator<FXZ>..cctor
	|
	|-RVA: 0x1CFFC10 Offset: 0x1CFFD11 VA: 0x1CFFC10
	|-Array.EmptyInternalEnumerator<Finger>..cctor
	|
	|-RVA: 0x1CFFDF0 Offset: 0x1CFFEF1 VA: 0x1CFFDF0
	|-Array.EmptyInternalEnumerator<Float2>..cctor
	|
	|-RVA: 0x1D00000 Offset: 0x1D00101 VA: 0x1D00000
	|-Array.EmptyInternalEnumerator<Friend>..cctor
	|
	|-RVA: 0x1D001E0 Offset: 0x1D002E1 VA: 0x1D001E0
	|-Array.EmptyInternalEnumerator<GCHandle>..cctor
	|
	|-RVA: 0x1D003C0 Offset: 0x1D004C1 VA: 0x1D003C0
	|-Array.EmptyInternalEnumerator<GesturePoint>..cctor
	|
	|-RVA: 0x1D00640 Offset: 0x1D00741 VA: 0x1D00640
	|-Array.EmptyInternalEnumerator<GestureState>..cctor
	|
	|-RVA: 0x1D00850 Offset: 0x1D00951 VA: 0x1D00850
	|-Array.EmptyInternalEnumerator<GlyphMarshallingStruct>..cctor
	|
	|-RVA: 0x1D00A70 Offset: 0x1D00B71 VA: 0x1D00A70
	|-Array.EmptyInternalEnumerator<GlyphPairAdjustmentRecord>..cctor
	|
	|-RVA: 0x1D00C60 Offset: 0x1D00D61 VA: 0x1D00C60
	|-Array.EmptyInternalEnumerator<GlyphRect>..cctor
	|
	|-RVA: 0x1D00E50 Offset: 0x1D00F51 VA: 0x1D00E50
	|-Array.EmptyInternalEnumerator<Guid>..cctor
	|
	|-RVA: 0x1D01060 Offset: 0x1D01161 VA: 0x1D01060
	|-Array.EmptyInternalEnumerator<Hand>..cctor
	|
	|-RVA: 0x1D01250 Offset: 0x1D01351 VA: 0x1D01250
	|-Array.EmptyInternalEnumerator<HandAnalysisImageState>..cctor
	|
	|-RVA: 0x1D01460 Offset: 0x1D01561 VA: 0x1D01460
	|-Array.EmptyInternalEnumerator<HandAnalysisSilhouetteState>..cctor
	|
	|-RVA: 0x1D01650 Offset: 0x1D01751 VA: 0x1D01650
	|-Array.EmptyInternalEnumerator<HeaderVariantInfo>..cctor
	|
	|-RVA: 0x1D01850 Offset: 0x1D01951 VA: 0x1D01850
	|-Array.EmptyInternalEnumerator<HighlightState>..cctor
	|
	|-RVA: 0x1D01A70 Offset: 0x1D01B71 VA: 0x1D01A70
	|-Array.EmptyInternalEnumerator<HumanBone>..cctor
	|
	|-RVA: 0x1D01C50 Offset: 0x1D01D51 VA: 0x1D01C50
	|-Array.EmptyInternalEnumerator<short>..cctor
	|
	|-RVA: 0x1D01E30 Offset: 0x1D01F31 VA: 0x1D01E30
	|-Array.EmptyInternalEnumerator<int>..cctor
	|
	|-RVA: 0x1D02010 Offset: 0x1D02111 VA: 0x1D02010
	|-Array.EmptyInternalEnumerator<Int32Enum>..cctor
	|
	|-RVA: 0x1D021F0 Offset: 0x1D022F1 VA: 0x1D021F0
	|-Array.EmptyInternalEnumerator<long>..cctor
	|
	|-RVA: 0x1D023D0 Offset: 0x1D024D1 VA: 0x1D023D0
	|-Array.EmptyInternalEnumerator<Int64Enum>..cctor
	|
	|-RVA: 0x1D025B0 Offset: 0x1D026B1 VA: 0x1D025B0
	|-Array.EmptyInternalEnumerator<IntPtr>..cctor
	|
	|-RVA: 0x1D027A0 Offset: 0x1D028A1 VA: 0x1D027A0
	|-Array.EmptyInternalEnumerator<InternalCodePageDataItem>..cctor
	|
	|-RVA: 0x1D02990 Offset: 0x1D02A91 VA: 0x1D02990
	|-Array.EmptyInternalEnumerator<InternalEncodingDataItem>..cctor
	|
	|-RVA: 0x1D02B80 Offset: 0x1D02C81 VA: 0x1D02B80
	|-Array.EmptyInternalEnumerator<InterpretedFrameInfo>..cctor
	|
	|-RVA: 0x1D02D80 Offset: 0x1D02E81 VA: 0x1D02D80
	|-Array.EmptyInternalEnumerator<IntervalTreeNode>..cctor
	|
	|-RVA: 0x1D02F70 Offset: 0x1D03071 VA: 0x1D02F70
	|-Array.EmptyInternalEnumerator<JobHandle>..cctor
	|
	|-RVA: 0x1D03180 Offset: 0x1D03281 VA: 0x1D03180
	|-Array.EmptyInternalEnumerator<Keyframe>..cctor
	|
	|-RVA: 0x1D03370 Offset: 0x1D03471 VA: 0x1D03370
	|-Array.EmptyInternalEnumerator<LOD>..cctor
	|
	|-RVA: 0x1D03550 Offset: 0x1D03651 VA: 0x1D03550
	|-Array.EmptyInternalEnumerator<LayerMask>..cctor
	|
	|-RVA: 0x1D03730 Offset: 0x1D03831 VA: 0x1D03730
	|-Array.EmptyInternalEnumerator<LengthLimitProperties>..cctor
	|
	|-RVA: 0x1D03980 Offset: 0x1D03A81 VA: 0x1D03980
	|-Array.EmptyInternalEnumerator<Light2DBlendStyle>..cctor
	|
	|-RVA: 0x1D03C00 Offset: 0x1D03D01 VA: 0x1D03C00
	|-Array.EmptyInternalEnumerator<LightDataGI>..cctor
	|
	|-RVA: 0x1D03DF0 Offset: 0x1D03EF1 VA: 0x1D03DF0
	|-Array.EmptyInternalEnumerator<LocalDefinition>..cctor
	|
	|-RVA: 0x1D03FD0 Offset: 0x1D040D1 VA: 0x1D03FD0
	|-Array.EmptyInternalEnumerator<MapPos>..cctor
	|
	|-RVA: 0x1D041C0 Offset: 0x1D042C1 VA: 0x1D041C0
	|-Array.EmptyInternalEnumerator<MapRange>..cctor
	|
	|-RVA: 0x1D043D0 Offset: 0x1D044D1 VA: 0x1D043D0
	|-Array.EmptyInternalEnumerator<MaterialReference>..cctor
	|
	|-RVA: 0x1D045F0 Offset: 0x1D046F1 VA: 0x1D045F0
	|-Array.EmptyInternalEnumerator<Matrix4x4>..cctor
	|
	|-RVA: 0x1D04800 Offset: 0x1D04901 VA: 0x1D04800
	|-Array.EmptyInternalEnumerator<MomentProcessorState>..cctor
	|
	|-RVA: 0x1D049F0 Offset: 0x1D04AF1 VA: 0x1D049F0
	|-Array.EmptyInternalEnumerator<MomentStatistic>..cctor
	|
	|-RVA: 0x1D04C00 Offset: 0x1D04D01 VA: 0x1D04C00
	|-Array.EmptyInternalEnumerator<Navigation>..cctor
	|
	|-RVA: 0x1D04DE0 Offset: 0x1D04EE1 VA: 0x1D04DE0
	|-Array.EmptyInternalEnumerator<NetworkServiceAccountId>..cctor
	|
	|-RVA: 0x1D04FF0 Offset: 0x1D050F1 VA: 0x1D04FF0
	|-Array.EmptyInternalEnumerator<NpadFullKeyState>..cctor
	|
	|-RVA: 0x1D05200 Offset: 0x1D05301 VA: 0x1D05200
	|-Array.EmptyInternalEnumerator<NpadHandheldState>..cctor
	|
	|-RVA: 0x1D05410 Offset: 0x1D05511 VA: 0x1D05410
	|-Array.EmptyInternalEnumerator<NpadJoyDualState>..cctor
	|
	|-RVA: 0x1D05620 Offset: 0x1D05721 VA: 0x1D05620
	|-Array.EmptyInternalEnumerator<NpadJoyLeftState>..cctor
	|
	|-RVA: 0x1D05830 Offset: 0x1D05931 VA: 0x1D05830
	|-Array.EmptyInternalEnumerator<NpadJoyRightState>..cctor
	|
	|-RVA: 0x1D05A40 Offset: 0x1D05B41 VA: 0x1D05A40
	|-Array.EmptyInternalEnumerator<NpadStateArrayItem>..cctor
	|
	|-RVA: 0x1D05C20 Offset: 0x1D05D21 VA: 0x1D05C20
	|-Array.EmptyInternalEnumerator<NsUid>..cctor
	|
	|-RVA: 0x1D05DC0 Offset: 0x1D05EC1 VA: 0x1D05DC0
	|-Array.EmptyInternalEnumerator<object>..cctor
	|
	|-RVA: 0x1D05FD0 Offset: 0x1D060D1 VA: 0x1D05FD0
	|-Array.EmptyInternalEnumerator<ObjectInitializationData>..cctor
	|
	|-RVA: 0x1D061B0 Offset: 0x1D062B1 VA: 0x1D061B0
	|-Array.EmptyInternalEnumerator<ParameterModifier>..cctor
	|
	|-RVA: 0x1D063A0 Offset: 0x1D064A1 VA: 0x1D063A0
	|-Array.EmptyInternalEnumerator<Plane>..cctor
	|
	|-RVA: 0x1D06590 Offset: 0x1D06691 VA: 0x1D06590
	|-Array.EmptyInternalEnumerator<Playable>..cctor
	|
	|-RVA: 0x1D06790 Offset: 0x1D06891 VA: 0x1D06790
	|-Array.EmptyInternalEnumerator<PlayableBinding>..cctor
	|
	|-RVA: 0x1D069A0 Offset: 0x1D06AA1 VA: 0x1D069A0
	|-Array.EmptyInternalEnumerator<PlayerLoopSystem>..cctor
	|
	|-RVA: 0x1D06BB0 Offset: 0x1D06CB1 VA: 0x1D06BB0
	|-Array.EmptyInternalEnumerator<PlayerLoopSystemInternal>..cctor
	|
	|-RVA: 0x1D06DD0 Offset: 0x1D06ED1 VA: 0x1D06DD0
	|-Array.EmptyInternalEnumerator<PreTile>..cctor
	|
	|-RVA: 0x1D06FE0 Offset: 0x1D070E1 VA: 0x1D06FE0
	|-Array.EmptyInternalEnumerator<Profile>..cctor
	|
	|-RVA: 0x1D071C0 Offset: 0x1D072C1 VA: 0x1D071C0
	|-Array.EmptyInternalEnumerator<Protrusion>..cctor
	|
	|-RVA: 0x1D073B0 Offset: 0x1D074B1 VA: 0x1D073B0
	|-Array.EmptyInternalEnumerator<Quaternion>..cctor
	|
	|-RVA: 0x1D075A0 Offset: 0x1D076A1 VA: 0x1D075A0
	|-Array.EmptyInternalEnumerator<RandomSeed>..cctor
	|
	|-RVA: 0x1D07790 Offset: 0x1D07891 VA: 0x1D07790
	|-Array.EmptyInternalEnumerator<RangePositionInfo>..cctor
	|
	|-RVA: 0x1D07970 Offset: 0x1D07A71 VA: 0x1D07970
	|-Array.EmptyInternalEnumerator<Ranking2ChartInfoInput>..cctor
	|
	|-RVA: 0x1D07B90 Offset: 0x1D07C91 VA: 0x1D07B90
	|-Array.EmptyInternalEnumerator<RaycastHit>..cctor
	|
	|-RVA: 0x1D07DA0 Offset: 0x1D07EA1 VA: 0x1D07DA0
	|-Array.EmptyInternalEnumerator<RaycastHit2D>..cctor
	|
	|-RVA: 0x1D07FF0 Offset: 0x1D080F1 VA: 0x1D07FF0
	|-Array.EmptyInternalEnumerator<RaycastResult>..cctor
	|
	|-RVA: 0x1D081E0 Offset: 0x1D082E1 VA: 0x1D081E0
	|-Array.EmptyInternalEnumerator<Rect>..cctor
	|
	|-RVA: 0x1D083D0 Offset: 0x1D084D1 VA: 0x1D083D0
	|-Array.EmptyInternalEnumerator<RenderBuffer>..cctor
	|
	|-RVA: 0x1D08670 Offset: 0x1D08771 VA: 0x1D08670
	|-Array.EmptyInternalEnumerator<RenderStateBlock>..cctor
	|
	|-RVA: 0x1D08880 Offset: 0x1D08981 VA: 0x1D08880
	|-Array.EmptyInternalEnumerator<RenderTargetHandle>..cctor
	|
	|-RVA: 0x1D08A90 Offset: 0x1D08B91 VA: 0x1D08A90
	|-Array.EmptyInternalEnumerator<RenderTargetIdentifier>..cctor
	|
	|-RVA: 0x1D08C70 Offset: 0x1D08D71 VA: 0x1D08C70
	|-Array.EmptyInternalEnumerator<RendererListHandle>..cctor
	|
	|-RVA: 0x1D08E50 Offset: 0x1D08F51 VA: 0x1D08E50
	|-Array.EmptyInternalEnumerator<ResourceHandle>..cctor
	|
	|-RVA: 0x1D09040 Offset: 0x1D09141 VA: 0x1D09040
	|-Array.EmptyInternalEnumerator<ResourceLocator>..cctor
	|
	|-RVA: 0x1D09240 Offset: 0x1D09341 VA: 0x1D09240
	|-Array.EmptyInternalEnumerator<RichTextTagAttribute>..cctor
	|
	|-RVA: 0x1D09430 Offset: 0x1D09531 VA: 0x1D09430
	|-Array.EmptyInternalEnumerator<RuntimeLabel>..cctor
	|
	|-RVA: 0x1D09610 Offset: 0x1D09711 VA: 0x1D09610
	|-Array.EmptyInternalEnumerator<sbyte>..cctor
	|
	|-RVA: 0x1D09810 Offset: 0x1D09911 VA: 0x1D09810
	|-Array.EmptyInternalEnumerator<SerializedType>..cctor
	|
	|-RVA: 0x1D099F0 Offset: 0x1D09AF1 VA: 0x1D099F0
	|-Array.EmptyInternalEnumerator<ShaderKeyword>..cctor
	|
	|-RVA: 0x1D09BD0 Offset: 0x1D09CD1 VA: 0x1D09BD0
	|-Array.EmptyInternalEnumerator<ShaderTagId>..cctor
	|
	|-RVA: 0x1D09DE0 Offset: 0x1D09EE1 VA: 0x1D09DE0
	|-Array.EmptyInternalEnumerator<ShadowSliceData>..cctor
	|
	|-RVA: 0x1D09FE0 Offset: 0x1D0A0E1 VA: 0x1D09FE0
	|-Array.EmptyInternalEnumerator<Shape>..cctor
	|
	|-RVA: 0x1D0A1C0 Offset: 0x1D0A2C1 VA: 0x1D0A1C0
	|-Array.EmptyInternalEnumerator<float>..cctor
	|
	|-RVA: 0x1D0A3A0 Offset: 0x1D0A4A1 VA: 0x1D0A3A0
	|-Array.EmptyInternalEnumerator<SixAxisSensorHandle>..cctor
	|
	|-RVA: 0x1D0A620 Offset: 0x1D0A721 VA: 0x1D0A620
	|-Array.EmptyInternalEnumerator<SixAxisSensorState>..cctor
	|
	|-RVA: 0x1D0A830 Offset: 0x1D0A931 VA: 0x1D0A830
	|-Array.EmptyInternalEnumerator<SkeletonBone>..cctor
	|
	|-RVA: 0x1D0AA10 Offset: 0x1D0AB11 VA: 0x1D0AA10
	|-Array.EmptyInternalEnumerator<SortingLayer>..cctor
	|
	|-RVA: 0x1D0ACB0 Offset: 0x1D0ADB1 VA: 0x1D0ACB0
	|-Array.EmptyInternalEnumerator<SphericalHarmonicsL2>..cctor
	|
	|-RVA: 0x1D0AE90 Offset: 0x1D0AF91 VA: 0x1D0AE90
	|-Array.EmptyInternalEnumerator<SpinLock>..cctor
	|
	|-RVA: 0x1D0B0E0 Offset: 0x1D0B1E1 VA: 0x1D0B0E0
	|-Array.EmptyInternalEnumerator<SpringBoneComponents>..cctor
	|
	|-RVA: 0x1D0B2F0 Offset: 0x1D0B3F1 VA: 0x1D0B2F0
	|-Array.EmptyInternalEnumerator<SpringBoneProperties>..cctor
	|
	|-RVA: 0x1D0B5A0 Offset: 0x1D0B6A1 VA: 0x1D0B5A0
	|-Array.EmptyInternalEnumerator<SpringColliderComponents>..cctor
	|
	|-RVA: 0x1D0B790 Offset: 0x1D0B891 VA: 0x1D0B790
	|-Array.EmptyInternalEnumerator<SpringColliderProperties>..cctor
	|
	|-RVA: 0x1D0B9B0 Offset: 0x1D0BAB1 VA: 0x1D0B9B0
	|-Array.EmptyInternalEnumerator<SpringForceComponent>..cctor
	|
	|-RVA: 0x1D0BBC0 Offset: 0x1D0BCC1 VA: 0x1D0BBC0
	|-Array.EmptyInternalEnumerator<SpringJobElement>..cctor
	|
	|-RVA: 0x1D0BDC0 Offset: 0x1D0BEC1 VA: 0x1D0BDC0
	|-Array.EmptyInternalEnumerator<SpriteState>..cctor
	|
	|-RVA: 0x1D0BFD0 Offset: 0x1D0C0D1 VA: 0x1D0BFD0
	|-Array.EmptyInternalEnumerator<SubMeshDescriptor>..cctor
	|
	|-RVA: 0x1D0C1E0 Offset: 0x1D0C2E1 VA: 0x1D0C1E0
	|-Array.EmptyInternalEnumerator<TMP_CharacterInfo>..cctor
	|
	|-RVA: 0x1D0C3D0 Offset: 0x1D0C4D1 VA: 0x1D0C3D0
	|-Array.EmptyInternalEnumerator<TMP_FontWeightPair>..cctor
	|
	|-RVA: 0x1D0C650 Offset: 0x1D0C751 VA: 0x1D0C650
	|-Array.EmptyInternalEnumerator<TMP_LineInfo>..cctor
	|
	|-RVA: 0x1D0C860 Offset: 0x1D0C961 VA: 0x1D0C860
	|-Array.EmptyInternalEnumerator<TMP_LinkInfo>..cctor
	|
	|-RVA: 0x1D0CAB0 Offset: 0x1D0CBB1 VA: 0x1D0CAB0
	|-Array.EmptyInternalEnumerator<TMP_MeshInfo>..cctor
	|
	|-RVA: 0x1D0CCB0 Offset: 0x1D0CDB1 VA: 0x1D0CCB0
	|-Array.EmptyInternalEnumerator<TMP_PageInfo>..cctor
	|
	|-RVA: 0x1D0CEB0 Offset: 0x1D0CFB1 VA: 0x1D0CEB0
	|-Array.EmptyInternalEnumerator<TMP_WordInfo>..cctor
	|
	|-RVA: 0x1D0D0A0 Offset: 0x1D0D1A1 VA: 0x1D0D0A0
	|-Array.EmptyInternalEnumerator<TablePair>..cctor
	|
	|-RVA: 0x1D0D280 Offset: 0x1D0D381 VA: 0x1D0D280
	|-Array.EmptyInternalEnumerator<TextureHandle>..cctor
	|
	|-RVA: 0x1D0D460 Offset: 0x1D0D561 VA: 0x1D0D460
	|-Array.EmptyInternalEnumerator<TimeSpan>..cctor
	|
	|-RVA: 0x1D0D6B0 Offset: 0x1D0D7B1 VA: 0x1D0D6B0
	|-Array.EmptyInternalEnumerator<Touch>..cctor
	|
	|-RVA: 0x1D0D8C0 Offset: 0x1D0D9C1 VA: 0x1D0D8C0
	|-Array.EmptyInternalEnumerator<TouchScreenState1>..cctor
	|
	|-RVA: 0x1D0DAD0 Offset: 0x1D0DBD1 VA: 0x1D0DAD0
	|-Array.EmptyInternalEnumerator<TouchScreenState10>..cctor
	|
	|-RVA: 0x1D0DCE0 Offset: 0x1D0DDE1 VA: 0x1D0DCE0
	|-Array.EmptyInternalEnumerator<TouchScreenState11>..cctor
	|
	|-RVA: 0x1D0DEF0 Offset: 0x1D0DFF1 VA: 0x1D0DEF0
	|-Array.EmptyInternalEnumerator<TouchScreenState12>..cctor
	|
	|-RVA: 0x1D0E100 Offset: 0x1D0E201 VA: 0x1D0E100
	|-Array.EmptyInternalEnumerator<TouchScreenState13>..cctor
	|
	|-RVA: 0x1D0E310 Offset: 0x1D0E411 VA: 0x1D0E310
	|-Array.EmptyInternalEnumerator<TouchScreenState14>..cctor
	|
	|-RVA: 0x1D0E520 Offset: 0x1D0E621 VA: 0x1D0E520
	|-Array.EmptyInternalEnumerator<TouchScreenState15>..cctor
	|
	|-RVA: 0x1D0E730 Offset: 0x1D0E831 VA: 0x1D0E730
	|-Array.EmptyInternalEnumerator<TouchScreenState16>..cctor
	|
	|-RVA: 0x1D0E9B0 Offset: 0x1D0EAB1 VA: 0x1D0E9B0
	|-Array.EmptyInternalEnumerator<TouchScreenState2>..cctor
	|
	|-RVA: 0x1D0EBC0 Offset: 0x1D0ECC1 VA: 0x1D0EBC0
	|-Array.EmptyInternalEnumerator<TouchScreenState3>..cctor
	|
	|-RVA: 0x1D0EDD0 Offset: 0x1D0EED1 VA: 0x1D0EDD0
	|-Array.EmptyInternalEnumerator<TouchScreenState4>..cctor
	|
	|-RVA: 0x1D0EFE0 Offset: 0x1D0F0E1 VA: 0x1D0EFE0
	|-Array.EmptyInternalEnumerator<TouchScreenState5>..cctor
	|
	|-RVA: 0x1D0F1F0 Offset: 0x1D0F2F1 VA: 0x1D0F1F0
	|-Array.EmptyInternalEnumerator<TouchScreenState6>..cctor
	|
	|-RVA: 0x1D0F400 Offset: 0x1D0F501 VA: 0x1D0F400
	|-Array.EmptyInternalEnumerator<TouchScreenState7>..cctor
	|
	|-RVA: 0x1D0F610 Offset: 0x1D0F711 VA: 0x1D0F610
	|-Array.EmptyInternalEnumerator<TouchScreenState8>..cctor
	|
	|-RVA: 0x1D0F820 Offset: 0x1D0F921 VA: 0x1D0F820
	|-Array.EmptyInternalEnumerator<TouchScreenState9>..cctor
	|
	|-RVA: 0x1D0FA30 Offset: 0x1D0FB31 VA: 0x1D0FA30
	|-Array.EmptyInternalEnumerator<TouchState>..cctor
	|
	|-RVA: 0x1D0FC30 Offset: 0x1D0FD31 VA: 0x1D0FC30
	|-Array.EmptyInternalEnumerator<TrailHand>..cctor
	|
	|-RVA: 0x1D0FE30 Offset: 0x1D0FF31 VA: 0x1D0FE30
	|-Array.EmptyInternalEnumerator<TrailVertex>..cctor
	|
	|-RVA: 0x1D10020 Offset: 0x1D10121 VA: 0x1D10020
	|-Array.EmptyInternalEnumerator<UICharInfo>..cctor
	|
	|-RVA: 0x1D10210 Offset: 0x1D10311 VA: 0x1D10210
	|-Array.EmptyInternalEnumerator<UILineInfo>..cctor
	|
	|-RVA: 0x1D104B0 Offset: 0x1D105B1 VA: 0x1D104B0
	|-Array.EmptyInternalEnumerator<UIVertex>..cctor
	|
	|-RVA: 0x1D10690 Offset: 0x1D10791 VA: 0x1D10690
	|-Array.EmptyInternalEnumerator<ushort>..cctor
	|
	|-RVA: 0x1D10870 Offset: 0x1D10971 VA: 0x1D10870
	|-Array.EmptyInternalEnumerator<UInt16Enum>..cctor
	|
	|-RVA: 0x1D10A50 Offset: 0x1D10B51 VA: 0x1D10A50
	|-Array.EmptyInternalEnumerator<uint>..cctor
	|
	|-RVA: 0x1D10C30 Offset: 0x1D10D31 VA: 0x1D10C30
	|-Array.EmptyInternalEnumerator<UInt32Enum>..cctor
	|
	|-RVA: 0x1D10E10 Offset: 0x1D10F11 VA: 0x1D10E10
	|-Array.EmptyInternalEnumerator<ulong>..cctor
	|
	|-RVA: 0x1D11000 Offset: 0x1D11101 VA: 0x1D11000
	|-Array.EmptyInternalEnumerator<Uid>..cctor
	|
	|-RVA: 0x1D111E0 Offset: 0x1D112E1 VA: 0x1D111E0
	|-Array.EmptyInternalEnumerator<UniTask>..cctor
	|
	|-RVA: 0x1D113C0 Offset: 0x1D114C1 VA: 0x1D113C0
	|-Array.EmptyInternalEnumerator<Unit>..cctor
	|
	|-RVA: 0x1D115A0 Offset: 0x1D116A1 VA: 0x1D115A0
	|-Array.EmptyInternalEnumerator<UnitEnum>..cctor
	|
	|-RVA: 0x1D11790 Offset: 0x1D11891 VA: 0x1D11790
	|-Array.EmptyInternalEnumerator<UserWord>..cctor
	|
	|-RVA: 0x1D11970 Offset: 0x1D11A71 VA: 0x1D11970
	|-Array.EmptyInternalEnumerator<Vector2>..cctor
	|
	|-RVA: 0x1D11B50 Offset: 0x1D11C51 VA: 0x1D11B50
	|-Array.EmptyInternalEnumerator<Vector2Int>..cctor
	|
	|-RVA: 0x1D11D40 Offset: 0x1D11E41 VA: 0x1D11D40
	|-Array.EmptyInternalEnumerator<Vector3>..cctor
	|
	|-RVA: 0x1D11F30 Offset: 0x1D12031 VA: 0x1D11F30
	|-Array.EmptyInternalEnumerator<Vector4>..cctor
	|
	|-RVA: 0x1D12120 Offset: 0x1D12221 VA: 0x1D12120
	|-Array.EmptyInternalEnumerator<VertexAttributeDescriptor>..cctor
	|
	|-RVA: 0x1D12300 Offset: 0x1D12401 VA: 0x1D12300
	|-Array.EmptyInternalEnumerator<VibrationDeviceHandle>..cctor
	|
	|-RVA: 0x1D124E0 Offset: 0x1D125E1 VA: 0x1D124E0
	|-Array.EmptyInternalEnumerator<VibrationDeviceInfo>..cctor
	|
	|-RVA: 0x1D126D0 Offset: 0x1D127D1 VA: 0x1D126D0
	|-Array.EmptyInternalEnumerator<VibrationValue>..cctor
	|
	|-RVA: 0x1D12970 Offset: 0x1D12A71 VA: 0x1D12970
	|-Array.EmptyInternalEnumerator<VisibleLight>..cctor
	|
	|-RVA: 0x1D12B80 Offset: 0x1D12C81 VA: 0x1D12B80
	|-Array.EmptyInternalEnumerator<WordWrapState>..cctor
	|
	|-RVA: 0x1D12D70 Offset: 0x1D12E71 VA: 0x1D12D70
	|-Array.EmptyInternalEnumerator<X509ChainStatus>..cctor
	|
	|-RVA: 0x1D12F70 Offset: 0x1D13071 VA: 0x1D12F70
	|-Array.EmptyInternalEnumerator<XPathNode>..cctor
	|
	|-RVA: 0x1D13160 Offset: 0x1D13261 VA: 0x1D13160
	|-Array.EmptyInternalEnumerator<XPathNodeRef>..cctor
	|
	|-RVA: 0x1D13370 Offset: 0x1D13471 VA: 0x1D13370
	|-Array.EmptyInternalEnumerator<XRView>..cctor
	|
	|-RVA: 0x1D13560 Offset: 0x1D13661 VA: 0x1D13560
	|-Array.EmptyInternalEnumerator<float3>..cctor
	|
	|-RVA: 0x1D13780 Offset: 0x1D13881 VA: 0x1D13780
	|-Array.EmptyInternalEnumerator<float4x4>..cctor
	|
	|-RVA: 0x1D13960 Offset: 0x1D13A61 VA: 0x1D13960
	|-Array.EmptyInternalEnumerator<jvalue>..cctor
	|
	|-RVA: 0x1D13B50 Offset: 0x1D13C51 VA: 0x1D13B50
	|-Array.EmptyInternalEnumerator<uint4>..cctor
	|
	|-RVA: 0x1D13D40 Offset: 0x1D13E41 VA: 0x1D13D40
	|-Array.EmptyInternalEnumerator<AICrossfire.PositionTable>..cctor
	|
	|-RVA: 0x1D13F30 Offset: 0x1D14031 VA: 0x1D13F30
	|-Array.EmptyInternalEnumerator<AIEnum.SkillRangeEnemyData>..cctor
	|
	|-RVA: 0x1D14110 Offset: 0x1D14211 VA: 0x1D14110
	|-Array.EmptyInternalEnumerator<AIOrder.UnitPriority>..cctor
	|
	|-RVA: 0x1D14300 Offset: 0x1D14401 VA: 0x1D14300
	|-Array.EmptyInternalEnumerator<AmiiboSequence.GainItemData>..cctor
	|
	|-RVA: 0x1D14510 Offset: 0x1D14611 VA: 0x1D14510
	|-Array.EmptyInternalEnumerator<AnimationOutputWeightProcessor.WeightInfo>..cctor
	|
	|-RVA: 0x1D14700 Offset: 0x1D14801 VA: 0x1D14700
	|-Array.EmptyInternalEnumerator<ArenaOrderSequence.GodInfo>..cctor
	|
	|-RVA: 0x1D148F0 Offset: 0x1D149F1 VA: 0x1D148F0
	|-Array.EmptyInternalEnumerator<BattleInfo.SupportData>..cctor
	|
	|-RVA: 0x1D14AE0 Offset: 0x1D14BE1 VA: 0x1D14AE0
	|-Array.EmptyInternalEnumerator<BeforeRenderHelper.OrderBlock>..cctor
	|
	|-RVA: 0x1D14CE0 Offset: 0x1D14DE1 VA: 0x1D14CE0
	|-Array.EmptyInternalEnumerator<Camera.RenderRequest>..cctor
	|
	|-RVA: 0x1D14ED0 Offset: 0x1D14FD1 VA: 0x1D14ED0
	|-Array.EmptyInternalEnumerator<CameraState.CustomBlendable>..cctor
	|
	|-RVA: 0x1D150D0 Offset: 0x1D151D1 VA: 0x1D150D0
	|-Array.EmptyInternalEnumerator<CinemachineBlendListCamera.Instruction>..cctor
	|
	|-RVA: 0x1D152D0 Offset: 0x1D153D1 VA: 0x1D152D0
	|-Array.EmptyInternalEnumerator<CinemachineBlenderSettings.CustomBlend>..cctor
	|
	|-RVA: 0x1D154B0 Offset: 0x1D155B1 VA: 0x1D154B0
	|-Array.EmptyInternalEnumerator<CinemachineClearShot.Pair>..cctor
	|
	|-RVA: 0x1D15690 Offset: 0x1D15791 VA: 0x1D15690
	|-Array.EmptyInternalEnumerator<CinemachineFreeLook.Orbit>..cctor
	|
	|-RVA: 0x1D158A0 Offset: 0x1D159A1 VA: 0x1D158A0
	|-Array.EmptyInternalEnumerator<CinemachinePath.Waypoint>..cctor
	|
	|-RVA: 0x1D15A90 Offset: 0x1D15B91 VA: 0x1D15A90
	|-Array.EmptyInternalEnumerator<CinemachineSmoothPath.Waypoint>..cctor
	|
	|-RVA: 0x1D15C70 Offset: 0x1D15D71 VA: 0x1D15C70
	|-Array.EmptyInternalEnumerator<CinemachineStateDrivenCamera.HashPair>..cctor
	|
	|-RVA: 0x1D15E70 Offset: 0x1D15F71 VA: 0x1D15E70
	|-Array.EmptyInternalEnumerator<CinemachineStateDrivenCamera.Instruction>..cctor
	|
	|-RVA: 0x1D16050 Offset: 0x1D16151 VA: 0x1D16050
	|-Array.EmptyInternalEnumerator<CinemachineStateDrivenCamera.ParentHash>..cctor
	|
	|-RVA: 0x1D16240 Offset: 0x1D16341 VA: 0x1D16240
	|-Array.EmptyInternalEnumerator<CinemachineTargetGroup.Target>..cctor
	|
	|-RVA: 0x1D16440 Offset: 0x1D16541 VA: 0x1D16440
	|-Array.EmptyInternalEnumerator<CodePointIndexer.TableRange>..cctor
	|
	|-RVA: 0x1D16630 Offset: 0x1D16731 VA: 0x1D16630
	|-Array.EmptyInternalEnumerator<ContentCatalogData.Bucket>..cctor
	|
	|-RVA: 0x1D16820 Offset: 0x1D16921 VA: 0x1D16820
	|-Array.EmptyInternalEnumerator<CookieTokenizer.RecognizedAttribute>..cctor
	|
	|-RVA: 0x1D16A30 Offset: 0x1D16B31 VA: 0x1D16A30
	|-Array.EmptyInternalEnumerator<DeferredLights.DrawCall>..cctor
	|
	|-RVA: 0x1D16C10 Offset: 0x1D16D11 VA: 0x1D16C10
	|-Array.EmptyInternalEnumerator<DeferredShaderData.ComputeBufferInfo>..cctor
	|
	|-RVA: 0x1D16E10 Offset: 0x1D16F11 VA: 0x1D16E10
	|-Array.EmptyInternalEnumerator<DeferredTiler.PrePunctualLight>..cctor
	|
	|-RVA: 0x1D17010 Offset: 0x1D17111 VA: 0x1D17010
	|-Array.EmptyInternalEnumerator<DelayedActionManager.DelegateInfo>..cctor
	|
	|-RVA: 0x1D17220 Offset: 0x1D17321 VA: 0x1D17220
	|-Array.EmptyInternalEnumerator<Detail.AsyncResultInt>..cctor
	|
	|-RVA: 0x1D17410 Offset: 0x1D17511 VA: 0x1D17410
	|-Array.EmptyInternalEnumerator<Detail.CppArray>..cctor
	|
	|-RVA: 0x1D17620 Offset: 0x1D17721 VA: 0x1D17620
	|-Array.EmptyInternalEnumerator<Detail.NotificationEventInt>..cctor
	|
	|-RVA: 0x1D17810 Offset: 0x1D17911 VA: 0x1D17810
	|-Array.EmptyInternalEnumerator<DisposUnit.Item>..cctor
	|
	|-RVA: 0x1D17A00 Offset: 0x1D17B01 VA: 0x1D17A00
	|-Array.EmptyInternalEnumerator<DragonRidePresetParamData.CourseData>..cctor
	|
	|-RVA: 0x1D17BF0 Offset: 0x1D17CF1 VA: 0x1D17BF0
	|-Array.EmptyInternalEnumerator<DragonRideTargetGroup.ChainParam>..cctor
	|
	|-RVA: 0x1D17DD0 Offset: 0x1D17ED1 VA: 0x1D17DD0
	|-Array.EmptyInternalEnumerator<DynamicMesh.State>..cctor
	|
	|-RVA: 0x1D17FE0 Offset: 0x1D180E1 VA: 0x1D17FE0
	|-Array.EmptyInternalEnumerator<FXZEx.HitPoint>..cctor
	|
	|-RVA: 0x1D181D0 Offset: 0x1D182D1 VA: 0x1D181D0
	|-Array.EmptyInternalEnumerator<FishingRadicalParamData.RadicalParam>..cctor
	|
	|-RVA: 0x1D183C0 Offset: 0x1D184C1 VA: 0x1D183C0
	|-Array.EmptyInternalEnumerator<GameVariable.Value>..cctor
	|
	|-RVA: 0x1D185C0 Offset: 0x1D186C1 VA: 0x1D185C0
	|-Array.EmptyInternalEnumerator<GmapPathAdjuster.TargetModel>..cctor
	|
	|-RVA: 0x1D187C0 Offset: 0x1D188C1 VA: 0x1D187C0
	|-Array.EmptyInternalEnumerator<GmapSpotAdjuster.TargetModel>..cctor
	|
	|-RVA: 0x1D189D0 Offset: 0x1D18AD1 VA: 0x1D189D0
	|-Array.EmptyInternalEnumerator<GrounderQuadruped.Foot>..cctor
	|
	|-RVA: 0x1D18BD0 Offset: 0x1D18CD1 VA: 0x1D18BD0
	|-Array.EmptyInternalEnumerator<Hashtable.bucket>..cctor
	|
	|-RVA: 0x1D18DD0 Offset: 0x1D18ED1 VA: 0x1D18DD0
	|-Array.EmptyInternalEnumerator<HeadingTracker.Item>..cctor
	|
	|-RVA: 0x1D18FE0 Offset: 0x1D190E1 VA: 0x1D18FE0
	|-Array.EmptyInternalEnumerator<HubAccessoryRoomCamera.BackgroundSettings>..cctor
	|
	|-RVA: 0x1D191E0 Offset: 0x1D192E1 VA: 0x1D191E0
	|-Array.EmptyInternalEnumerator<HubFastTravel.Location>..cctor
	|
	|-RVA: 0x1D193F0 Offset: 0x1D194F1 VA: 0x1D193F0
	|-Array.EmptyInternalEnumerator<HubLensFlare.Flare>..cctor
	|
	|-RVA: 0x1D195E0 Offset: 0x1D196E1 VA: 0x1D195E0
	|-Array.EmptyInternalEnumerator<HubLookAtController.LookAtIKParam>..cctor
	|
	|-RVA: 0x1D197D0 Offset: 0x1D198D1 VA: 0x1D197D0
	|-Array.EmptyInternalEnumerator<HubMaterialArray.MaterialInfo>..cctor
	|
	|-RVA: 0x1D199E0 Offset: 0x1D19AE1 VA: 0x1D199E0
	|-Array.EmptyInternalEnumerator<IKSolverLimb.AxisDirection>..cctor
	|
	|-RVA: 0x1D19BD0 Offset: 0x1D19CD1 VA: 0x1D19BD0
	|-Array.EmptyInternalEnumerator<InventoryPoolItemMenuContent.KindBgNameClass>..cctor
	|
	|-RVA: 0x1D19DE0 Offset: 0x1D19EE1 VA: 0x1D19DE0
	|-Array.EmptyInternalEnumerator<LightUtility.ParametricLightMeshVertex>..cctor
	|
	|-RVA: 0x1D19FF0 Offset: 0x1D1A0F1 VA: 0x1D19FF0
	|-Array.EmptyInternalEnumerator<LightUtility.SpriteLightMeshVertex>..cctor
	|
	|-RVA: 0x1D1A1D0 Offset: 0x1D1A2D1 VA: 0x1D1A1D0
	|-Array.EmptyInternalEnumerator<Map.Pos>..cctor
	|
	|-RVA: 0x1D1A3C0 Offset: 0x1D1A4C1 VA: 0x1D1A3C0
	|-Array.EmptyInternalEnumerator<MapGodExp.KindDesc>..cctor
	|
	|-RVA: 0x1D1A5A0 Offset: 0x1D1A6A1 VA: 0x1D1A5A0
	|-Array.EmptyInternalEnumerator<MapHistory.Command>..cctor
	|
	|-RVA: 0x1D1A790 Offset: 0x1D1A891 VA: 0x1D1A790
	|-Array.EmptyInternalEnumerator<MapImage.BackupTerrain>..cctor
	|
	|-RVA: 0x1D1A970 Offset: 0x1D1AA71 VA: 0x1D1A970
	|-Array.EmptyInternalEnumerator<MapImageRange.Pos>..cctor
	|
	|-RVA: 0x1D1AB50 Offset: 0x1D1AC51 VA: 0x1D1AB50
	|-Array.EmptyInternalEnumerator<MapKillBonus.KillBonus>..cctor
	|
	|-RVA: 0x1D1AD30 Offset: 0x1D1AE31 VA: 0x1D1AD30
	|-Array.EmptyInternalEnumerator<MapKillBonus.KilledBonus>..cctor
	|
	|-RVA: 0x1D1AF80 Offset: 0x1D1B081 VA: 0x1D1AF80
	|-Array.EmptyInternalEnumerator<MapMind.Record>..cctor
	|
	|-RVA: 0x1D1B180 Offset: 0x1D1B281 VA: 0x1D1B180
	|-Array.EmptyInternalEnumerator<MapMind.Target>..cctor
	|
	|-RVA: 0x1D1B380 Offset: 0x1D1B481 VA: 0x1D1B380
	|-Array.EmptyInternalEnumerator<MapPanelDebug.Entity>..cctor
	|
	|-RVA: 0x1D1B560 Offset: 0x1D1B661 VA: 0x1D1B560
	|-Array.EmptyInternalEnumerator<NexRanking.Data>..cctor
	|
	|-RVA: 0x1D1B750 Offset: 0x1D1B851 VA: 0x1D1B750
	|-Array.EmptyInternalEnumerator<NexVersus.RatingData>..cctor
	|
	|-RVA: 0x1D1B960 Offset: 0x1D1BA61 VA: 0x1D1B960
	|-Array.EmptyInternalEnumerator<NoiseSettings.TransformNoiseParams>..cctor
	|
	|-RVA: 0x1D1BB50 Offset: 0x1D1BC51 VA: 0x1D1BB50
	|-Array.EmptyInternalEnumerator<PackedPlayModeBuildLogs.RuntimeBuildLog>..cctor
	|
	|-RVA: 0x1D1BD40 Offset: 0x1D1BE41 VA: 0x1D1BD40
	|-Array.EmptyInternalEnumerator<ParameterizedStrings.FormatParam>..cctor
	|
	|-RVA: 0x1D1BF50 Offset: 0x1D1C051 VA: 0x1D1BF50
	|-Array.EmptyInternalEnumerator<ParticleSystem.Particle>..cctor
	|
	|-RVA: 0x1D1C130 Offset: 0x1D1C231 VA: 0x1D1C130
	|-Array.EmptyInternalEnumerator<ProfileCard.Achievement>..cctor
	|
	|-RVA: 0x1D1C330 Offset: 0x1D1C431 VA: 0x1D1C330
	|-Array.EmptyInternalEnumerator<ProfileCard.SortieCount>..cctor
	|
	|-RVA: 0x1D1C540 Offset: 0x1D1C641 VA: 0x1D1C540
	|-Array.EmptyInternalEnumerator<QualitySettingsStack.Settings>..cctor
	|
	|-RVA: 0x1D1C720 Offset: 0x1D1C821 VA: 0x1D1C720
	|-Array.EmptyInternalEnumerator<RangeData.Offset>..cctor
	|
	|-RVA: 0x1D1C910 Offset: 0x1D1CA11 VA: 0x1D1C910
	|-Array.EmptyInternalEnumerator<RegexCharClass.LowerCaseMapping>..cctor
	|
	|-RVA: 0x1D1CB10 Offset: 0x1D1CC11 VA: 0x1D1CB10
	|-Array.EmptyInternalEnumerator<Relay.ChooseAwardeeData>..cctor
	|
	|-RVA: 0x1D1CD00 Offset: 0x1D1CE01 VA: 0x1D1CD00
	|-Array.EmptyInternalEnumerator<RelayAwardData.Info>..cctor
	|
	|-RVA: 0x1D1CF50 Offset: 0x1D1D051 VA: 0x1D1CF50
	|-Array.EmptyInternalEnumerator<RenderGraph.CompiledPassInfo>..cctor
	|
	|-RVA: 0x1D1D150 Offset: 0x1D1D251 VA: 0x1D1D150
	|-Array.EmptyInternalEnumerator<RenderGraph.CompiledResourceInfo>..cctor
	|
	|-RVA: 0x1D1D350 Offset: 0x1D1D451 VA: 0x1D1D350
	|-Array.EmptyInternalEnumerator<RenderGraphDebugData.PassDebugData>..cctor
	|
	|-RVA: 0x1D1D560 Offset: 0x1D1D661 VA: 0x1D1D560
	|-Array.EmptyInternalEnumerator<RenderGraphDebugData.ResourceDebugData>..cctor
	|
	|-RVA: 0x1D1D770 Offset: 0x1D1D871 VA: 0x1D1D770
	|-Array.EmptyInternalEnumerator<RenderGraphResourceRegistry.RendererListResource>..cctor
	|
	|-RVA: 0x1D1D960 Offset: 0x1D1DA61 VA: 0x1D1D960
	|-Array.EmptyInternalEnumerator<RingCleaningUnitSelectMenu.GodParam>..cctor
	|
	|-RVA: 0x1D1DB50 Offset: 0x1D1DC51 VA: 0x1D1DB50
	|-Array.EmptyInternalEnumerator<SampleWave.Data>..cctor
	|
	|-RVA: 0x1D1DD30 Offset: 0x1D1DE31 VA: 0x1D1DD30
	|-Array.EmptyInternalEnumerator<SampleWave.Temp>..cctor
	|
	|-RVA: 0x1D1DF20 Offset: 0x1D1E021 VA: 0x1D1DF20
	|-Array.EmptyInternalEnumerator<SendMouseEvents.HitInfo>..cctor
	|
	|-RVA: 0x1D1E130 Offset: 0x1D1E231 VA: 0x1D1E130
	|-Array.EmptyInternalEnumerator<SequenceNode.SequenceConstructPosContext>..cctor
	|
	|-RVA: 0x1D1E380 Offset: 0x1D1E481 VA: 0x1D1E380
	|-Array.EmptyInternalEnumerator<ShaderInput.LightData>..cctor
	|
	|-RVA: 0x1D1E5D0 Offset: 0x1D1E6D1 VA: 0x1D1E5D0
	|-Array.EmptyInternalEnumerator<ShaderInput.ShadowData>..cctor
	|
	|-RVA: 0x1D1E7E0 Offset: 0x1D1E8E1 VA: 0x1D1E7E0
	|-Array.EmptyInternalEnumerator<ShadowUtility.Edge>..cctor
	|
	|-RVA: 0x1D1E9D0 Offset: 0x1D1EAD1 VA: 0x1D1E9D0
	|-Array.EmptyInternalEnumerator<SimpleAnimationPlayable.QueuedState>..cctor
	|
	|-RVA: 0x1D1EBB0 Offset: 0x1D1ECB1 VA: 0x1D1EBB0
	|-Array.EmptyInternalEnumerator<SkillArray.Entity>..cctor
	|
	|-RVA: 0x1D1EDA0 Offset: 0x1D1EEA1 VA: 0x1D1EDA0
	|-Array.EmptyInternalEnumerator<Socket.WSABUF>..cctor
	|
	|-RVA: 0x1D1EF90 Offset: 0x1D1F091 VA: 0x1D1EF90
	|-Array.EmptyInternalEnumerator<Stream.Info>..cctor
	|
	|-RVA: 0x1D1F180 Offset: 0x1D1F281 VA: 0x1D1F180
	|-Array.EmptyInternalEnumerator<TMP_Text.UnicodeChar>..cctor
	|
	|-RVA: 0x1D1F3A0 Offset: 0x1D1F4A1 VA: 0x1D1F3A0
	|-Array.EmptyInternalEnumerator<TexturePacker_JsonArray.Frame>..cctor
	|
	|-RVA: 0x1D1F5A0 Offset: 0x1D1F6A1 VA: 0x1D1F5A0
	|-Array.EmptyInternalEnumerator<TimeNotificationBehaviour.NotificationEntry>..cctor
	|
	|-RVA: 0x1D1F7A0 Offset: 0x1D1F8A1 VA: 0x1D1F7A0
	|-Array.EmptyInternalEnumerator<UnitySynchronizationContext.WorkRequest>..cctor
	|
	|-RVA: 0x1D1F9A0 Offset: 0x1D1FAA1 VA: 0x1D1F9A0
	|-Array.EmptyInternalEnumerator<XmlNamespaceManager.NamespaceDeclaration>..cctor
	|
	|-RVA: 0x1D1FB90 Offset: 0x1D1FC91 VA: 0x1D1FB90
	|-Array.EmptyInternalEnumerator<XmlSchemaObjectTable.XmlSchemaObjectEntry>..cctor
	|
	|-RVA: 0x1D1FE30 Offset: 0x1D1FF31 VA: 0x1D1FE30
	|-Array.EmptyInternalEnumerator<XmlTextReaderImpl.ParsingState>..cctor
	|
	|-RVA: 0x1D20020 Offset: 0x1D20121 VA: 0x1D20020
	|-Array.EmptyInternalEnumerator<AIThink.EnchantThink.Desc>..cctor
	|
	|-RVA: 0x1D20200 Offset: 0x1D20301 VA: 0x1D20200
	|-Array.EmptyInternalEnumerator<AIThink.EnchantThink.ItemInfo>..cctor
	|
	|-RVA: 0x1D203E0 Offset: 0x1D204E1 VA: 0x1D203E0
	|-Array.EmptyInternalEnumerator<AIThink.EnchantThink.SurroundingInfo>..cctor
	|
	|-RVA: 0x1D205D0 Offset: 0x1D206D1 VA: 0x1D205D0
	|-Array.EmptyInternalEnumerator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>..cctor
	|
	|-RVA: 0x1D207E0 Offset: 0x1D208E1 VA: 0x1D207E0
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStoreChangeMetaParamInt>..cctor
	|
	|-RVA: 0x1D209D0 Offset: 0x1D20AD1 VA: 0x1D209D0
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStoreDeleteParamInt>..cctor
	|
	|-RVA: 0x1D20BE0 Offset: 0x1D20CE1 VA: 0x1D20BE0
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStoreGetMetaParamInt>..cctor
	|
	|-RVA: 0x1D20DF0 Offset: 0x1D20EF1 VA: 0x1D20DF0
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStoreMetaInfoInt>..cctor
	|
	|-RVA: 0x1D20FF0 Offset: 0x1D210F1 VA: 0x1D20FF0
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStorePasswordInfoInt>..cctor
	|
	|-RVA: 0x1D211F0 Offset: 0x1D212F1 VA: 0x1D211F0
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStorePersistenceInfoInt>..cctor
	|
	|-RVA: 0x1D21400 Offset: 0x1D21501 VA: 0x1D21400
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStorePreparePostParamInt>..cctor
	|
	|-RVA: 0x1D215F0 Offset: 0x1D216F1 VA: 0x1D215F0
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStoreRateObjectParamInt>..cctor
	|
	|-RVA: 0x1D217F0 Offset: 0x1D218F1 VA: 0x1D217F0
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStoreRatingInitParamInt>..cctor
	|
	|-RVA: 0x1D219E0 Offset: 0x1D21AE1 VA: 0x1D219E0
	|-Array.EmptyInternalEnumerator<Detail.DataStore.DataStoreRatingTargetInt>..cctor
	|
	|-RVA: 0x1D21BF0 Offset: 0x1D21CF1 VA: 0x1D21BF0
	|-Array.EmptyInternalEnumerator<Detail.Ranking.RankingCachedResultInt>..cctor
	|
	|-RVA: 0x1D21DE0 Offset: 0x1D21EE1 VA: 0x1D21DE0
	|-Array.EmptyInternalEnumerator<Detail.Ranking.RankingOrderParamInt>..cctor
	|
	|-RVA: 0x1D22000 Offset: 0x1D22101 VA: 0x1D22000
	|-Array.EmptyInternalEnumerator<Detail.Ranking.RankingRankDataInt>..cctor
	|
	|-RVA: 0x1D22280 Offset: 0x1D22381 VA: 0x1D22280
	|-Array.EmptyInternalEnumerator<Detail.Ranking2.Ranking2ChartInfoInt>..cctor
	|
	|-RVA: 0x1D224A0 Offset: 0x1D225A1 VA: 0x1D224A0
	|-Array.EmptyInternalEnumerator<Detail.Ranking2.Ranking2RankDataInt>..cctor
	|
	|-RVA: 0x1D22690 Offset: 0x1D22791 VA: 0x1D22690
	|-Array.EmptyInternalEnumerator<Detail.Ranking2.Ranking2ScoreDataInt>..cctor
	|
	|-RVA: 0x1D22890 Offset: 0x1D22991 VA: 0x1D22890
	|-Array.EmptyInternalEnumerator<Detail.Screening.ScreeningContextInfoInt>..cctor
	|
	|-RVA: 0x1D22AE0 Offset: 0x1D22BE1 VA: 0x1D22AE0
	|-Array.EmptyInternalEnumerator<Detail.Subscriber.SubscriberContentInt>..cctor
	|
	|-RVA: 0x1D22CE0 Offset: 0x1D22DE1 VA: 0x1D22CE0
	|-Array.EmptyInternalEnumerator<Detail.Subscriber.SubscriberGetContentParamInt>..cctor
	|
	|-RVA: 0x1D22EF0 Offset: 0x1D22FF1 VA: 0x1D22EF0
	|-Array.EmptyInternalEnumerator<Detail.Subscriber.SubscriberUserStatusInfoInt>..cctor
	|
	|-RVA: 0x1D230F0 Offset: 0x1D231F1 VA: 0x1D230F0
	|-Array.EmptyInternalEnumerator<Detail.Subscriber.SubscriberUserStatusParamInt>..cctor
	|
	|-RVA: 0x1D232D0 Offset: 0x1D233D1 VA: 0x1D232D0
	|-Array.EmptyInternalEnumerator<Detail.Utility.IntegerSettings>..cctor
	|
	|-RVA: 0x1D234C0 Offset: 0x1D235C1 VA: 0x1D234C0
	|-Array.EmptyInternalEnumerator<Detail.Utility.UniqueIdInfoInt>..cctor
	|
	|-RVA: 0x1D236B0 Offset: 0x1D237B1 VA: 0x1D236B0
	|-Array.EmptyInternalEnumerator<FacetsChecker.FacetsCompiler.Map>..cctor
	|
	|-RVA: 0x1D238B0 Offset: 0x1D239B1 VA: 0x1D238B0
	|-Array.EmptyInternalEnumerator<MapHistory.ReplayAppearanceMap.Appearance>..cctor
	|
	|-RVA: 0x1D23A90 Offset: 0x1D23B91 VA: 0x1D23A90
	|-Array.EmptyInternalEnumerator<MapHistory.ReplayAppearanceMap.Leaving>..cctor
	|
	|-RVA: 0x1D23C70 Offset: 0x1D23D71 VA: 0x1D23C70
	|-Array.EmptyInternalEnumerator<MapHistory.ReplayUnitMap.Data>..cctor
	|
	|-RVA: 0x1D23E60 Offset: 0x1D23F61 VA: 0x1D23E60
	|-Array.EmptyInternalEnumerator<MapHistory.Rewind.LatestInspectorData>..cctor
	|
	|-RVA: 0x1D24050 Offset: 0x1D24151 VA: 0x1D24050
	|-Array.EmptyInternalEnumerator<MapHistory.Rewind.WorkTerrainData>..cctor
	|
	|-RVA: 0x1D24260 Offset: 0x1D24361 VA: 0x1D24260
	|-Array.EmptyInternalEnumerator<MapHistory.RewindUnitMap.Data>..cctor
	|
	|-RVA: 0x1D24440 Offset: 0x1D24541 VA: 0x1D24440
	|-Array.EmptyInternalEnumerator<MapKillBonus.Work.Pos>..cctor
	|
	|-RVA: 0x1D24630 Offset: 0x1D24731 VA: 0x1D24630
	|-Array.EmptyInternalEnumerator<MapSkill.AroundCalculator.Result>..cctor
	|
	|-RVA: 0x1D24810 Offset: 0x1D24911 VA: 0x1D24810
	|-Array.EmptyInternalEnumerator<Nex.ApiCallChecker.Guideline>..cctor
	|
	|-RVA: 0x1D24A10 Offset: 0x1D24B11 VA: 0x1D24A10
	|-Array.EmptyInternalEnumerator<Ngc.MaskTextSequenceBase.Data>..cctor
	|
	|-RVA: 0x1D24C20 Offset: 0x1D24D21 VA: 0x1D24C20
	|-Array.EmptyInternalEnumerator<TargetPositionCache.CacheCurve.Item>..cctor
	|
	|-RVA: 0x1D24E30 Offset: 0x1D24F31 VA: 0x1D24E30
	|-Array.EmptyInternalEnumerator<TargetPositionCache.CacheEntry.RecordingItem>..cctor
	|
	|-RVA: 0x1D25010 Offset: 0x1D25111 VA: 0x1D25010
	|-Array.EmptyInternalEnumerator<TerrainUtility.TerrainMap.TileCoord>..cctor
	*/
}

// Namespace: 
private struct Array.SorterGenericArray // TypeDefIndex: 118
{
	// Fields
	private Array keys; // 0x0
	private Array items; // 0x8
	private IComparer comparer; // 0x10

	// Methods

	// RVA: 0x35E0060 Offset: 0x35E0161 VA: 0x35E0060
	internal void .ctor(Array keys, Array items, IComparer comparer) { }

	// RVA: 0x35E0120 Offset: 0x35E0221 VA: 0x35E0120
	internal void SwapIfGreaterWithItems(int a, int b) { }

	// RVA: 0x35E02E0 Offset: 0x35E03E1 VA: 0x35E02E0
	private void Swap(int i, int j) { }

	// RVA: 0x35E03D0 Offset: 0x35E04D1 VA: 0x35E03D0
	internal void Sort(int left, int length) { }

	// RVA: 0x35E03E0 Offset: 0x35E04E1 VA: 0x35E03E0
	private void IntrospectiveSort(int left, int length) { }

	// RVA: 0x35E0540 Offset: 0x35E0641 VA: 0x35E0540
	private void IntroSort(int lo, int hi, int depthLimit) { }

	// RVA: 0x35E0960 Offset: 0x35E0A61 VA: 0x35E0960
	private int PickPivotAndPartition(int lo, int hi) { }

	// RVA: 0x35E08B0 Offset: 0x35E09B1 VA: 0x35E08B0
	private void Heapsort(int lo, int hi) { }

	// RVA: 0x35E0B80 Offset: 0x35E0C81 VA: 0x35E0B80
	private void DownHeap(int i, int n, int lo) { }

	// RVA: 0x35E06B0 Offset: 0x35E07B1 VA: 0x35E06B0
	private void InsertionSort(int lo, int hi) { }
}

