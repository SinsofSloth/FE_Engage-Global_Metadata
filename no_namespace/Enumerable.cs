// Namespace: 
private class Enumerable.WhereEnumerableIterator<TSource> : Enumerable.Iterator<TSource> // TypeDefIndex: 2724
{
	// Fields
	private IEnumerable<TSource> source; // 0x0
	private Func<TSource, bool> predicate; // 0x0
	private IEnumerator<TSource> enumerator; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39C5F50 Offset: 0x39C6051 VA: 0x39C5F50
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x39C63E0 Offset: 0x39C64E1 VA: 0x39C63E0
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x39C6870 Offset: 0x39C6971 VA: 0x39C6870
	|-Enumerable.WhereEnumerableIterator<UniTask<object>>..ctor
	|
	|-RVA: 0x39C6D00 Offset: 0x39C6E01 VA: 0x39C6D00
	|-Enumerable.WhereEnumerableIterator<Color>..ctor
	|
	|-RVA: 0x39C71A0 Offset: 0x39C72A1 VA: 0x39C71A0
	|-Enumerable.WhereEnumerableIterator<int>..ctor
	|
	|-RVA: 0x39C7620 Offset: 0x39C7721 VA: 0x39C7620
	|-Enumerable.WhereEnumerableIterator<object>..ctor
	|
	|-RVA: 0x39C7AA0 Offset: 0x39C7BA1 VA: 0x39C7AA0
	|-Enumerable.WhereEnumerableIterator<TablePair>..ctor
	|
	|-RVA: 0x39C7F30 Offset: 0x39C8031 VA: 0x39C7F30
	|-Enumerable.WhereEnumerableIterator<UniTask>..ctor
	|
	|-RVA: 0x39C83B0 Offset: 0x39C84B1 VA: 0x39C83B0
	|-Enumerable.WhereEnumerableIterator<Vector3>..ctor
	|
	|-RVA: 0x39C8840 Offset: 0x39C8941 VA: 0x39C8840
	|-Enumerable.WhereEnumerableIterator<float3>..ctor
	|
	|-RVA: 0x39C8CD0 Offset: 0x39C8DD1 VA: 0x39C8CD0
	|-Enumerable.WhereEnumerableIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public override Enumerable.Iterator<TSource> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39C5FB0 Offset: 0x39C60B1 VA: 0x39C5FB0
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<int, object>>.Clone
	|
	|-RVA: 0x39C6440 Offset: 0x39C6541 VA: 0x39C6440
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, object>>.Clone
	|
	|-RVA: 0x39C68D0 Offset: 0x39C69D1 VA: 0x39C68D0
	|-Enumerable.WhereEnumerableIterator<UniTask<object>>.Clone
	|
	|-RVA: 0x39C6D60 Offset: 0x39C6E61 VA: 0x39C6D60
	|-Enumerable.WhereEnumerableIterator<Color>.Clone
	|
	|-RVA: 0x39C7200 Offset: 0x39C7301 VA: 0x39C7200
	|-Enumerable.WhereEnumerableIterator<int>.Clone
	|
	|-RVA: 0x39C7680 Offset: 0x39C7781 VA: 0x39C7680
	|-Enumerable.WhereEnumerableIterator<object>.Clone
	|
	|-RVA: 0x39C7B00 Offset: 0x39C7C01 VA: 0x39C7B00
	|-Enumerable.WhereEnumerableIterator<TablePair>.Clone
	|
	|-RVA: 0x39C7F90 Offset: 0x39C8091 VA: 0x39C7F90
	|-Enumerable.WhereEnumerableIterator<UniTask>.Clone
	|
	|-RVA: 0x39C8410 Offset: 0x39C8511 VA: 0x39C8410
	|-Enumerable.WhereEnumerableIterator<Vector3>.Clone
	|
	|-RVA: 0x39C88A0 Offset: 0x39C89A1 VA: 0x39C88A0
	|-Enumerable.WhereEnumerableIterator<float3>.Clone
	|
	|-RVA: 0x39C8D30 Offset: 0x39C8E31 VA: 0x39C8D30
	|-Enumerable.WhereEnumerableIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.Clone
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public override void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39C6020 Offset: 0x39C6121 VA: 0x39C6020
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<int, object>>.Dispose
	|
	|-RVA: 0x39C64B0 Offset: 0x39C65B1 VA: 0x39C64B0
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, object>>.Dispose
	|
	|-RVA: 0x39C6940 Offset: 0x39C6A41 VA: 0x39C6940
	|-Enumerable.WhereEnumerableIterator<UniTask<object>>.Dispose
	|
	|-RVA: 0x39C6DD0 Offset: 0x39C6ED1 VA: 0x39C6DD0
	|-Enumerable.WhereEnumerableIterator<Color>.Dispose
	|
	|-RVA: 0x39C7270 Offset: 0x39C7371 VA: 0x39C7270
	|-Enumerable.WhereEnumerableIterator<int>.Dispose
	|
	|-RVA: 0x39C76F0 Offset: 0x39C77F1 VA: 0x39C76F0
	|-Enumerable.WhereEnumerableIterator<object>.Dispose
	|
	|-RVA: 0x39C7B70 Offset: 0x39C7C71 VA: 0x39C7B70
	|-Enumerable.WhereEnumerableIterator<TablePair>.Dispose
	|
	|-RVA: 0x39C8000 Offset: 0x39C8101 VA: 0x39C8000
	|-Enumerable.WhereEnumerableIterator<UniTask>.Dispose
	|
	|-RVA: 0x39C8480 Offset: 0x39C8581 VA: 0x39C8480
	|-Enumerable.WhereEnumerableIterator<Vector3>.Dispose
	|
	|-RVA: 0x39C8910 Offset: 0x39C8A11 VA: 0x39C8910
	|-Enumerable.WhereEnumerableIterator<float3>.Dispose
	|
	|-RVA: 0x39C8DA0 Offset: 0x39C8EA1 VA: 0x39C8DA0
	|-Enumerable.WhereEnumerableIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39C6100 Offset: 0x39C6201 VA: 0x39C6100
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<int, object>>.MoveNext
	|
	|-RVA: 0x39C6590 Offset: 0x39C6691 VA: 0x39C6590
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, object>>.MoveNext
	|
	|-RVA: 0x39C6A20 Offset: 0x39C6B21 VA: 0x39C6A20
	|-Enumerable.WhereEnumerableIterator<UniTask<object>>.MoveNext
	|
	|-RVA: 0x39C6EB0 Offset: 0x39C6FB1 VA: 0x39C6EB0
	|-Enumerable.WhereEnumerableIterator<Color>.MoveNext
	|
	|-RVA: 0x39C7350 Offset: 0x39C7451 VA: 0x39C7350
	|-Enumerable.WhereEnumerableIterator<int>.MoveNext
	|
	|-RVA: 0x39C77D0 Offset: 0x39C78D1 VA: 0x39C77D0
	|-Enumerable.WhereEnumerableIterator<object>.MoveNext
	|
	|-RVA: 0x39C7C50 Offset: 0x39C7D51 VA: 0x39C7C50
	|-Enumerable.WhereEnumerableIterator<TablePair>.MoveNext
	|
	|-RVA: 0x39C80E0 Offset: 0x39C81E1 VA: 0x39C80E0
	|-Enumerable.WhereEnumerableIterator<UniTask>.MoveNext
	|
	|-RVA: 0x39C8560 Offset: 0x39C8661 VA: 0x39C8560
	|-Enumerable.WhereEnumerableIterator<Vector3>.MoveNext
	|
	|-RVA: 0x39C89F0 Offset: 0x39C8AF1 VA: 0x39C89F0
	|-Enumerable.WhereEnumerableIterator<float3>.MoveNext
	|
	|-RVA: 0x39C8E80 Offset: 0x39C8F81 VA: 0x39C8E80
	|-Enumerable.WhereEnumerableIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2557010 Offset: 0x2557111 VA: 0x2557010
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, object>>.Select<object>
	|
	|-RVA: 0x2557090 Offset: 0x2557191 VA: 0x2557090
	|-Enumerable.WhereEnumerableIterator<int>.Select<int>
	|
	|-RVA: 0x2557110 Offset: 0x2557211 VA: 0x2557110
	|-Enumerable.WhereEnumerableIterator<int>.Select<object>
	|
	|-RVA: 0x2557190 Offset: 0x2557291 VA: 0x2557190
	|-Enumerable.WhereEnumerableIterator<object>.Select<KeyValuePair<int, object>>
	|
	|-RVA: 0x2557210 Offset: 0x2557311 VA: 0x2557210
	|-Enumerable.WhereEnumerableIterator<object>.Select<UniTask<object>>
	|
	|-RVA: 0x2557290 Offset: 0x2557391 VA: 0x2557290
	|-Enumerable.WhereEnumerableIterator<object>.Select<int>
	|
	|-RVA: 0x2557310 Offset: 0x2557411 VA: 0x2557310
	|-Enumerable.WhereEnumerableIterator<object>.Select<object>
	|
	|-RVA: 0x2557390 Offset: 0x2557491 VA: 0x2557390
	|-Enumerable.WhereEnumerableIterator<object>.Select<UniTask>
	|
	|-RVA: 0x2557410 Offset: 0x2557511 VA: 0x2557410
	|-Enumerable.WhereEnumerableIterator<TablePair>.Select<object>
	|
	|-RVA: 0x2557490 Offset: 0x2557591 VA: 0x2557490
	|-Enumerable.WhereEnumerableIterator<TablePair>.Select<TablePair>
	|
	|-RVA: 0x2557510 Offset: 0x2557611 VA: 0x2557510
	|-Enumerable.WhereEnumerableIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.Select<object>
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public override IEnumerable<TSource> Where(Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39C6350 Offset: 0x39C6451 VA: 0x39C6350
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<int, object>>.Where
	|
	|-RVA: 0x39C67E0 Offset: 0x39C68E1 VA: 0x39C67E0
	|-Enumerable.WhereEnumerableIterator<KeyValuePair<object, object>>.Where
	|
	|-RVA: 0x39C6C70 Offset: 0x39C6D71 VA: 0x39C6C70
	|-Enumerable.WhereEnumerableIterator<UniTask<object>>.Where
	|
	|-RVA: 0x39C7110 Offset: 0x39C7211 VA: 0x39C7110
	|-Enumerable.WhereEnumerableIterator<Color>.Where
	|
	|-RVA: 0x39C7590 Offset: 0x39C7691 VA: 0x39C7590
	|-Enumerable.WhereEnumerableIterator<int>.Where
	|
	|-RVA: 0x39C7A10 Offset: 0x39C7B11 VA: 0x39C7A10
	|-Enumerable.WhereEnumerableIterator<object>.Where
	|
	|-RVA: 0x39C7EA0 Offset: 0x39C7FA1 VA: 0x39C7EA0
	|-Enumerable.WhereEnumerableIterator<TablePair>.Where
	|
	|-RVA: 0x39C8320 Offset: 0x39C8421 VA: 0x39C8320
	|-Enumerable.WhereEnumerableIterator<UniTask>.Where
	|
	|-RVA: 0x39C87B0 Offset: 0x39C88B1 VA: 0x39C87B0
	|-Enumerable.WhereEnumerableIterator<Vector3>.Where
	|
	|-RVA: 0x39C8C40 Offset: 0x39C8D41 VA: 0x39C8C40
	|-Enumerable.WhereEnumerableIterator<float3>.Where
	|
	|-RVA: 0x39C90D0 Offset: 0x39C91D1 VA: 0x39C90D0
	|-Enumerable.WhereEnumerableIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.Where
	*/
}

// Namespace: 
private class Enumerable.WhereListIterator<TSource> : Enumerable.Iterator<TSource> // TypeDefIndex: 2726
{
	// Fields
	private List<TSource> source; // 0x0
	private Func<TSource, bool> predicate; // 0x0
	private List.Enumerator<TSource> enumerator; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(List<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39C9160 Offset: 0x39C9261 VA: 0x39C9160
	|-Enumerable.WhereListIterator<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x39C93D0 Offset: 0x39C94D1 VA: 0x39C93D0
	|-Enumerable.WhereListIterator<object>..ctor
	|
	|-RVA: 0x39C9630 Offset: 0x39C9731 VA: 0x39C9630
	|-Enumerable.WhereListIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public override Enumerable.Iterator<TSource> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39C91C0 Offset: 0x39C92C1 VA: 0x39C91C0
	|-Enumerable.WhereListIterator<KeyValuePair<object, object>>.Clone
	|
	|-RVA: 0x39C9430 Offset: 0x39C9531 VA: 0x39C9430
	|-Enumerable.WhereListIterator<object>.Clone
	|
	|-RVA: 0x39C9690 Offset: 0x39C9791 VA: 0x39C9690
	|-Enumerable.WhereListIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.Clone
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39C9230 Offset: 0x39C9331 VA: 0x39C9230
	|-Enumerable.WhereListIterator<KeyValuePair<object, object>>.MoveNext
	|
	|-RVA: 0x39C94A0 Offset: 0x39C95A1 VA: 0x39C94A0
	|-Enumerable.WhereListIterator<object>.MoveNext
	|
	|-RVA: 0x39C9700 Offset: 0x39C9801 VA: 0x39C9700
	|-Enumerable.WhereListIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2557590 Offset: 0x2557691 VA: 0x2557590
	|-Enumerable.WhereListIterator<KeyValuePair<object, object>>.Select<object>
	|
	|-RVA: 0x2557610 Offset: 0x2557711 VA: 0x2557610
	|-Enumerable.WhereListIterator<object>.Select<KeyValuePair<int, object>>
	|
	|-RVA: 0x2557690 Offset: 0x2557791 VA: 0x2557690
	|-Enumerable.WhereListIterator<object>.Select<UniTask<object>>
	|
	|-RVA: 0x2557710 Offset: 0x2557811 VA: 0x2557710
	|-Enumerable.WhereListIterator<object>.Select<int>
	|
	|-RVA: 0x2557790 Offset: 0x2557891 VA: 0x2557790
	|-Enumerable.WhereListIterator<object>.Select<object>
	|
	|-RVA: 0x2557810 Offset: 0x2557911 VA: 0x2557810
	|-Enumerable.WhereListIterator<object>.Select<UniTask>
	|
	|-RVA: 0x2557890 Offset: 0x2557991 VA: 0x2557890
	|-Enumerable.WhereListIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.Select<object>
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public override IEnumerable<TSource> Where(Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39C9340 Offset: 0x39C9441 VA: 0x39C9340
	|-Enumerable.WhereListIterator<KeyValuePair<object, object>>.Where
	|
	|-RVA: 0x39C95A0 Offset: 0x39C96A1 VA: 0x39C95A0
	|-Enumerable.WhereListIterator<object>.Where
	|
	|-RVA: 0x39C9810 Offset: 0x39C9911 VA: 0x39C9810
	|-Enumerable.WhereListIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.Where
	*/
}

// Namespace: 
private class Enumerable.WhereSelectArrayIterator<TSource, TResult> : Enumerable.Iterator<TResult> // TypeDefIndex: 2728
{
	// Fields
	private TSource[] source; // 0x0
	private Func<TSource, bool> predicate; // 0x0
	private Func<TSource, TResult> selector; // 0x0
	private int index; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(TSource[] source, Func<TSource, bool> predicate, Func<TSource, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39CB450 Offset: 0x39CB551 VA: 0x39CB450
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x39CB6B0 Offset: 0x39CB7B1 VA: 0x39CB6B0
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, UniTask<object>>..ctor
	|
	|-RVA: 0x39CB910 Offset: 0x39CBA11 VA: 0x39CB910
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, int>..ctor
	|
	|-RVA: 0x39CBB60 Offset: 0x39CBC61 VA: 0x39CBB60
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>..ctor
	|
	|-RVA: 0x39CBDC0 Offset: 0x39CBEC1 VA: 0x39CBDC0
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, UniTask>..ctor
	|
	|-RVA: 0x39CC020 Offset: 0x39CC121 VA: 0x39CC020
	|-Enumerable.WhereSelectArrayIterator<ContourVertex, Color>..ctor
	|
	|-RVA: 0x39CC2B0 Offset: 0x39CC3B1 VA: 0x39CC2B0
	|-Enumerable.WhereSelectArrayIterator<ContourVertex, Vector3>..ctor
	|
	|-RVA: 0x39CC540 Offset: 0x39CC641 VA: 0x39CC540
	|-Enumerable.WhereSelectArrayIterator<ContourVertex, float3>..ctor
	|
	|-RVA: 0x39CC7D0 Offset: 0x39CC8D1 VA: 0x39CC7D0
	|-Enumerable.WhereSelectArrayIterator<int, KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x39CCA30 Offset: 0x39CCB31 VA: 0x39CCA30
	|-Enumerable.WhereSelectArrayIterator<int, UniTask<object>>..ctor
	|
	|-RVA: 0x39CCC90 Offset: 0x39CCD91 VA: 0x39CCC90
	|-Enumerable.WhereSelectArrayIterator<int, int>..ctor
	|
	|-RVA: 0x39CCEE0 Offset: 0x39CCFE1 VA: 0x39CCEE0
	|-Enumerable.WhereSelectArrayIterator<int, object>..ctor
	|
	|-RVA: 0x39CD140 Offset: 0x39CD241 VA: 0x39CD140
	|-Enumerable.WhereSelectArrayIterator<int, UniTask>..ctor
	|
	|-RVA: 0x39CD3A0 Offset: 0x39CD4A1 VA: 0x39CD3A0
	|-Enumerable.WhereSelectArrayIterator<object, KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x39CD600 Offset: 0x39CD701 VA: 0x39CD600
	|-Enumerable.WhereSelectArrayIterator<object, UniTask<object>>..ctor
	|
	|-RVA: 0x39CD860 Offset: 0x39CD961 VA: 0x39CD860
	|-Enumerable.WhereSelectArrayIterator<object, int>..ctor
	|
	|-RVA: 0x39CDAB0 Offset: 0x39CDBB1 VA: 0x39CDAB0
	|-Enumerable.WhereSelectArrayIterator<object, object>..ctor
	|
	|-RVA: 0x39CDD10 Offset: 0x39CDE11 VA: 0x39CDD10
	|-Enumerable.WhereSelectArrayIterator<object, UniTask>..ctor
	|
	|-RVA: 0x39CDF70 Offset: 0x39CE071 VA: 0x39CDF70
	|-Enumerable.WhereSelectArrayIterator<TablePair, KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x39CE1D0 Offset: 0x39CE2D1 VA: 0x39CE1D0
	|-Enumerable.WhereSelectArrayIterator<TablePair, UniTask<object>>..ctor
	|
	|-RVA: 0x39CE430 Offset: 0x39CE531 VA: 0x39CE430
	|-Enumerable.WhereSelectArrayIterator<TablePair, int>..ctor
	|
	|-RVA: 0x39CE680 Offset: 0x39CE781 VA: 0x39CE680
	|-Enumerable.WhereSelectArrayIterator<TablePair, object>..ctor
	|
	|-RVA: 0x39CE8E0 Offset: 0x39CE9E1 VA: 0x39CE8E0
	|-Enumerable.WhereSelectArrayIterator<TablePair, TablePair>..ctor
	|
	|-RVA: 0x39CEB40 Offset: 0x39CEC41 VA: 0x39CEB40
	|-Enumerable.WhereSelectArrayIterator<TablePair, UniTask>..ctor
	|
	|-RVA: 0x39CEDA0 Offset: 0x39CEEA1 VA: 0x39CEDA0
	|-Enumerable.WhereSelectArrayIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x39CF000 Offset: 0x39CF101 VA: 0x39CF000
	|-Enumerable.WhereSelectArrayIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, UniTask<object>>..ctor
	|
	|-RVA: 0x39CF260 Offset: 0x39CF361 VA: 0x39CF260
	|-Enumerable.WhereSelectArrayIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, int>..ctor
	|
	|-RVA: 0x39CF4B0 Offset: 0x39CF5B1 VA: 0x39CF4B0
	|-Enumerable.WhereSelectArrayIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, object>..ctor
	|
	|-RVA: 0x39CF710 Offset: 0x39CF811 VA: 0x39CF710
	|-Enumerable.WhereSelectArrayIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, UniTask>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public override Enumerable.Iterator<TResult> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39CB4C0 Offset: 0x39CB5C1 VA: 0x39CB4C0
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, KeyValuePair<int, object>>.Clone
	|
	|-RVA: 0x39CB720 Offset: 0x39CB821 VA: 0x39CB720
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, UniTask<object>>.Clone
	|
	|-RVA: 0x39CB980 Offset: 0x39CBA81 VA: 0x39CB980
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, int>.Clone
	|
	|-RVA: 0x39CBBD0 Offset: 0x39CBCD1 VA: 0x39CBBD0
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.Clone
	|
	|-RVA: 0x39CBE30 Offset: 0x39CBF31 VA: 0x39CBE30
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, UniTask>.Clone
	|
	|-RVA: 0x39CC090 Offset: 0x39CC191 VA: 0x39CC090
	|-Enumerable.WhereSelectArrayIterator<ContourVertex, Color>.Clone
	|
	|-RVA: 0x39CC320 Offset: 0x39CC421 VA: 0x39CC320
	|-Enumerable.WhereSelectArrayIterator<ContourVertex, Vector3>.Clone
	|
	|-RVA: 0x39CC5B0 Offset: 0x39CC6B1 VA: 0x39CC5B0
	|-Enumerable.WhereSelectArrayIterator<ContourVertex, float3>.Clone
	|
	|-RVA: 0x39CC840 Offset: 0x39CC941 VA: 0x39CC840
	|-Enumerable.WhereSelectArrayIterator<int, KeyValuePair<int, object>>.Clone
	|
	|-RVA: 0x39CCAA0 Offset: 0x39CCBA1 VA: 0x39CCAA0
	|-Enumerable.WhereSelectArrayIterator<int, UniTask<object>>.Clone
	|
	|-RVA: 0x39CCD00 Offset: 0x39CCE01 VA: 0x39CCD00
	|-Enumerable.WhereSelectArrayIterator<int, int>.Clone
	|
	|-RVA: 0x39CCF50 Offset: 0x39CD051 VA: 0x39CCF50
	|-Enumerable.WhereSelectArrayIterator<int, object>.Clone
	|
	|-RVA: 0x39CD1B0 Offset: 0x39CD2B1 VA: 0x39CD1B0
	|-Enumerable.WhereSelectArrayIterator<int, UniTask>.Clone
	|
	|-RVA: 0x39CD410 Offset: 0x39CD511 VA: 0x39CD410
	|-Enumerable.WhereSelectArrayIterator<object, KeyValuePair<int, object>>.Clone
	|
	|-RVA: 0x39CD670 Offset: 0x39CD771 VA: 0x39CD670
	|-Enumerable.WhereSelectArrayIterator<object, UniTask<object>>.Clone
	|
	|-RVA: 0x39CD8D0 Offset: 0x39CD9D1 VA: 0x39CD8D0
	|-Enumerable.WhereSelectArrayIterator<object, int>.Clone
	|
	|-RVA: 0x39CDB20 Offset: 0x39CDC21 VA: 0x39CDB20
	|-Enumerable.WhereSelectArrayIterator<object, object>.Clone
	|
	|-RVA: 0x39CDD80 Offset: 0x39CDE81 VA: 0x39CDD80
	|-Enumerable.WhereSelectArrayIterator<object, UniTask>.Clone
	|
	|-RVA: 0x39CDFE0 Offset: 0x39CE0E1 VA: 0x39CDFE0
	|-Enumerable.WhereSelectArrayIterator<TablePair, KeyValuePair<int, object>>.Clone
	|
	|-RVA: 0x39CE240 Offset: 0x39CE341 VA: 0x39CE240
	|-Enumerable.WhereSelectArrayIterator<TablePair, UniTask<object>>.Clone
	|
	|-RVA: 0x39CE4A0 Offset: 0x39CE5A1 VA: 0x39CE4A0
	|-Enumerable.WhereSelectArrayIterator<TablePair, int>.Clone
	|
	|-RVA: 0x39CE6F0 Offset: 0x39CE7F1 VA: 0x39CE6F0
	|-Enumerable.WhereSelectArrayIterator<TablePair, object>.Clone
	|
	|-RVA: 0x39CE950 Offset: 0x39CEA51 VA: 0x39CE950
	|-Enumerable.WhereSelectArrayIterator<TablePair, TablePair>.Clone
	|
	|-RVA: 0x39CEBB0 Offset: 0x39CECB1 VA: 0x39CEBB0
	|-Enumerable.WhereSelectArrayIterator<TablePair, UniTask>.Clone
	|
	|-RVA: 0x39CEE10 Offset: 0x39CEF11 VA: 0x39CEE10
	|-Enumerable.WhereSelectArrayIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, KeyValuePair<int, object>>.Clone
	|
	|-RVA: 0x39CF070 Offset: 0x39CF171 VA: 0x39CF070
	|-Enumerable.WhereSelectArrayIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, UniTask<object>>.Clone
	|
	|-RVA: 0x39CF2D0 Offset: 0x39CF3D1 VA: 0x39CF2D0
	|-Enumerable.WhereSelectArrayIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, int>.Clone
	|
	|-RVA: 0x39CF520 Offset: 0x39CF621 VA: 0x39CF520
	|-Enumerable.WhereSelectArrayIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, object>.Clone
	|
	|-RVA: 0x39CF780 Offset: 0x39CF881 VA: 0x39CF780
	|-Enumerable.WhereSelectArrayIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, UniTask>.Clone
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39CB540 Offset: 0x39CB641 VA: 0x39CB540
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, KeyValuePair<int, object>>.MoveNext
	|
	|-RVA: 0x39CB7A0 Offset: 0x39CB8A1 VA: 0x39CB7A0
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, UniTask<object>>.MoveNext
	|
	|-RVA: 0x39CBA00 Offset: 0x39CBB01 VA: 0x39CBA00
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, int>.MoveNext
	|
	|-RVA: 0x39CBC50 Offset: 0x39CBD51 VA: 0x39CBC50
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.MoveNext
	|
	|-RVA: 0x39CBEB0 Offset: 0x39CBFB1 VA: 0x39CBEB0
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, UniTask>.MoveNext
	|
	|-RVA: 0x39CC110 Offset: 0x39CC211 VA: 0x39CC110
	|-Enumerable.WhereSelectArrayIterator<ContourVertex, Color>.MoveNext
	|
	|-RVA: 0x39CC3A0 Offset: 0x39CC4A1 VA: 0x39CC3A0
	|-Enumerable.WhereSelectArrayIterator<ContourVertex, Vector3>.MoveNext
	|
	|-RVA: 0x39CC630 Offset: 0x39CC731 VA: 0x39CC630
	|-Enumerable.WhereSelectArrayIterator<ContourVertex, float3>.MoveNext
	|
	|-RVA: 0x39CC8C0 Offset: 0x39CC9C1 VA: 0x39CC8C0
	|-Enumerable.WhereSelectArrayIterator<int, KeyValuePair<int, object>>.MoveNext
	|
	|-RVA: 0x39CCB20 Offset: 0x39CCC21 VA: 0x39CCB20
	|-Enumerable.WhereSelectArrayIterator<int, UniTask<object>>.MoveNext
	|
	|-RVA: 0x39CCD80 Offset: 0x39CCE81 VA: 0x39CCD80
	|-Enumerable.WhereSelectArrayIterator<int, int>.MoveNext
	|
	|-RVA: 0x39CCFD0 Offset: 0x39CD0D1 VA: 0x39CCFD0
	|-Enumerable.WhereSelectArrayIterator<int, object>.MoveNext
	|
	|-RVA: 0x39CD230 Offset: 0x39CD331 VA: 0x39CD230
	|-Enumerable.WhereSelectArrayIterator<int, UniTask>.MoveNext
	|
	|-RVA: 0x39CD490 Offset: 0x39CD591 VA: 0x39CD490
	|-Enumerable.WhereSelectArrayIterator<object, KeyValuePair<int, object>>.MoveNext
	|
	|-RVA: 0x39CD6F0 Offset: 0x39CD7F1 VA: 0x39CD6F0
	|-Enumerable.WhereSelectArrayIterator<object, UniTask<object>>.MoveNext
	|
	|-RVA: 0x39CD950 Offset: 0x39CDA51 VA: 0x39CD950
	|-Enumerable.WhereSelectArrayIterator<object, int>.MoveNext
	|
	|-RVA: 0x39CDBA0 Offset: 0x39CDCA1 VA: 0x39CDBA0
	|-Enumerable.WhereSelectArrayIterator<object, object>.MoveNext
	|
	|-RVA: 0x39CDE00 Offset: 0x39CDF01 VA: 0x39CDE00
	|-Enumerable.WhereSelectArrayIterator<object, UniTask>.MoveNext
	|
	|-RVA: 0x39CE060 Offset: 0x39CE161 VA: 0x39CE060
	|-Enumerable.WhereSelectArrayIterator<TablePair, KeyValuePair<int, object>>.MoveNext
	|
	|-RVA: 0x39CE2C0 Offset: 0x39CE3C1 VA: 0x39CE2C0
	|-Enumerable.WhereSelectArrayIterator<TablePair, UniTask<object>>.MoveNext
	|
	|-RVA: 0x39CE520 Offset: 0x39CE621 VA: 0x39CE520
	|-Enumerable.WhereSelectArrayIterator<TablePair, int>.MoveNext
	|
	|-RVA: 0x39CE770 Offset: 0x39CE871 VA: 0x39CE770
	|-Enumerable.WhereSelectArrayIterator<TablePair, object>.MoveNext
	|
	|-RVA: 0x39CE9D0 Offset: 0x39CEAD1 VA: 0x39CE9D0
	|-Enumerable.WhereSelectArrayIterator<TablePair, TablePair>.MoveNext
	|
	|-RVA: 0x39CEC30 Offset: 0x39CED31 VA: 0x39CEC30
	|-Enumerable.WhereSelectArrayIterator<TablePair, UniTask>.MoveNext
	|
	|-RVA: 0x39CEE90 Offset: 0x39CEF91 VA: 0x39CEE90
	|-Enumerable.WhereSelectArrayIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, KeyValuePair<int, object>>.MoveNext
	|
	|-RVA: 0x39CF0F0 Offset: 0x39CF1F1 VA: 0x39CF0F0
	|-Enumerable.WhereSelectArrayIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, UniTask<object>>.MoveNext
	|
	|-RVA: 0x39CF350 Offset: 0x39CF451 VA: 0x39CF350
	|-Enumerable.WhereSelectArrayIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, int>.MoveNext
	|
	|-RVA: 0x39CF5A0 Offset: 0x39CF6A1 VA: 0x39CF5A0
	|-Enumerable.WhereSelectArrayIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, object>.MoveNext
	|
	|-RVA: 0x39CF800 Offset: 0x39CF901 VA: 0x39CF800
	|-Enumerable.WhereSelectArrayIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, UniTask>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2557AB0 Offset: 0x2557BB1 VA: 0x2557AB0
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.Select<KeyValuePair<int, object>>
	|
	|-RVA: 0x2557B40 Offset: 0x2557C41 VA: 0x2557B40
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.Select<UniTask<object>>
	|
	|-RVA: 0x2557BD0 Offset: 0x2557CD1 VA: 0x2557BD0
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.Select<int>
	|
	|-RVA: 0x2557C60 Offset: 0x2557D61 VA: 0x2557C60
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.Select<object>
	|
	|-RVA: 0x2557CF0 Offset: 0x2557DF1 VA: 0x2557CF0
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.Select<UniTask>
	|
	|-RVA: 0x2557D80 Offset: 0x2557E81 VA: 0x2557D80
	|-Enumerable.WhereSelectArrayIterator<int, int>.Select<int>
	|
	|-RVA: 0x2557E10 Offset: 0x2557F11 VA: 0x2557E10
	|-Enumerable.WhereSelectArrayIterator<int, int>.Select<object>
	|
	|-RVA: 0x2557EA0 Offset: 0x2557FA1 VA: 0x2557EA0
	|-Enumerable.WhereSelectArrayIterator<int, object>.Select<KeyValuePair<int, object>>
	|
	|-RVA: 0x2557F30 Offset: 0x2558031 VA: 0x2557F30
	|-Enumerable.WhereSelectArrayIterator<int, object>.Select<UniTask<object>>
	|
	|-RVA: 0x2557FC0 Offset: 0x25580C1 VA: 0x2557FC0
	|-Enumerable.WhereSelectArrayIterator<int, object>.Select<int>
	|
	|-RVA: 0x2558050 Offset: 0x2558151 VA: 0x2558050
	|-Enumerable.WhereSelectArrayIterator<int, object>.Select<object>
	|
	|-RVA: 0x25580E0 Offset: 0x25581E1 VA: 0x25580E0
	|-Enumerable.WhereSelectArrayIterator<int, object>.Select<UniTask>
	|
	|-RVA: 0x2558170 Offset: 0x2558271 VA: 0x2558170
	|-Enumerable.WhereSelectArrayIterator<object, int>.Select<int>
	|
	|-RVA: 0x2558200 Offset: 0x2558301 VA: 0x2558200
	|-Enumerable.WhereSelectArrayIterator<object, int>.Select<object>
	|
	|-RVA: 0x2558290 Offset: 0x2558391 VA: 0x2558290
	|-Enumerable.WhereSelectArrayIterator<object, object>.Select<KeyValuePair<int, object>>
	|
	|-RVA: 0x2558320 Offset: 0x2558421 VA: 0x2558320
	|-Enumerable.WhereSelectArrayIterator<object, object>.Select<UniTask<object>>
	|
	|-RVA: 0x25583B0 Offset: 0x25584B1 VA: 0x25583B0
	|-Enumerable.WhereSelectArrayIterator<object, object>.Select<int>
	|
	|-RVA: 0x2558440 Offset: 0x2558541 VA: 0x2558440
	|-Enumerable.WhereSelectArrayIterator<object, object>.Select<object>
	|
	|-RVA: 0x25584D0 Offset: 0x25585D1 VA: 0x25584D0
	|-Enumerable.WhereSelectArrayIterator<object, object>.Select<UniTask>
	|
	|-RVA: 0x2558560 Offset: 0x2558661 VA: 0x2558560
	|-Enumerable.WhereSelectArrayIterator<TablePair, object>.Select<KeyValuePair<int, object>>
	|
	|-RVA: 0x25585F0 Offset: 0x25586F1 VA: 0x25585F0
	|-Enumerable.WhereSelectArrayIterator<TablePair, object>.Select<UniTask<object>>
	|
	|-RVA: 0x2558680 Offset: 0x2558781 VA: 0x2558680
	|-Enumerable.WhereSelectArrayIterator<TablePair, object>.Select<int>
	|
	|-RVA: 0x2558710 Offset: 0x2558811 VA: 0x2558710
	|-Enumerable.WhereSelectArrayIterator<TablePair, object>.Select<object>
	|
	|-RVA: 0x25587A0 Offset: 0x25588A1 VA: 0x25587A0
	|-Enumerable.WhereSelectArrayIterator<TablePair, object>.Select<UniTask>
	|
	|-RVA: 0x2558830 Offset: 0x2558931 VA: 0x2558830
	|-Enumerable.WhereSelectArrayIterator<TablePair, TablePair>.Select<object>
	|
	|-RVA: 0x25588C0 Offset: 0x25589C1 VA: 0x25588C0
	|-Enumerable.WhereSelectArrayIterator<TablePair, TablePair>.Select<TablePair>
	|
	|-RVA: 0x2558950 Offset: 0x2558A51 VA: 0x2558950
	|-Enumerable.WhereSelectArrayIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, object>.Select<KeyValuePair<int, object>>
	|
	|-RVA: 0x25589E0 Offset: 0x2558AE1 VA: 0x25589E0
	|-Enumerable.WhereSelectArrayIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, object>.Select<UniTask<object>>
	|
	|-RVA: 0x2558A70 Offset: 0x2558B71 VA: 0x2558A70
	|-Enumerable.WhereSelectArrayIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, object>.Select<int>
	|
	|-RVA: 0x2558B00 Offset: 0x2558C01 VA: 0x2558B00
	|-Enumerable.WhereSelectArrayIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, object>.Select<object>
	|
	|-RVA: 0x2558B90 Offset: 0x2558C91 VA: 0x2558B90
	|-Enumerable.WhereSelectArrayIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, object>.Select<UniTask>
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public override IEnumerable<TResult> Where(Func<TResult, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39CB630 Offset: 0x39CB731 VA: 0x39CB630
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, KeyValuePair<int, object>>.Where
	|
	|-RVA: 0x39CB890 Offset: 0x39CB991 VA: 0x39CB890
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, UniTask<object>>.Where
	|
	|-RVA: 0x39CBAE0 Offset: 0x39CBBE1 VA: 0x39CBAE0
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, int>.Where
	|
	|-RVA: 0x39CBD40 Offset: 0x39CBE41 VA: 0x39CBD40
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, object>.Where
	|
	|-RVA: 0x39CBFA0 Offset: 0x39CC0A1 VA: 0x39CBFA0
	|-Enumerable.WhereSelectArrayIterator<KeyValuePair<object, object>, UniTask>.Where
	|
	|-RVA: 0x39CC230 Offset: 0x39CC331 VA: 0x39CC230
	|-Enumerable.WhereSelectArrayIterator<ContourVertex, Color>.Where
	|
	|-RVA: 0x39CC4C0 Offset: 0x39CC5C1 VA: 0x39CC4C0
	|-Enumerable.WhereSelectArrayIterator<ContourVertex, Vector3>.Where
	|
	|-RVA: 0x39CC750 Offset: 0x39CC851 VA: 0x39CC750
	|-Enumerable.WhereSelectArrayIterator<ContourVertex, float3>.Where
	|
	|-RVA: 0x39CC9B0 Offset: 0x39CCAB1 VA: 0x39CC9B0
	|-Enumerable.WhereSelectArrayIterator<int, KeyValuePair<int, object>>.Where
	|
	|-RVA: 0x39CCC10 Offset: 0x39CCD11 VA: 0x39CCC10
	|-Enumerable.WhereSelectArrayIterator<int, UniTask<object>>.Where
	|
	|-RVA: 0x39CCE60 Offset: 0x39CCF61 VA: 0x39CCE60
	|-Enumerable.WhereSelectArrayIterator<int, int>.Where
	|
	|-RVA: 0x39CD0C0 Offset: 0x39CD1C1 VA: 0x39CD0C0
	|-Enumerable.WhereSelectArrayIterator<int, object>.Where
	|
	|-RVA: 0x39CD320 Offset: 0x39CD421 VA: 0x39CD320
	|-Enumerable.WhereSelectArrayIterator<int, UniTask>.Where
	|
	|-RVA: 0x39CD580 Offset: 0x39CD681 VA: 0x39CD580
	|-Enumerable.WhereSelectArrayIterator<object, KeyValuePair<int, object>>.Where
	|
	|-RVA: 0x39CD7E0 Offset: 0x39CD8E1 VA: 0x39CD7E0
	|-Enumerable.WhereSelectArrayIterator<object, UniTask<object>>.Where
	|
	|-RVA: 0x39CDA30 Offset: 0x39CDB31 VA: 0x39CDA30
	|-Enumerable.WhereSelectArrayIterator<object, int>.Where
	|
	|-RVA: 0x39CDC90 Offset: 0x39CDD91 VA: 0x39CDC90
	|-Enumerable.WhereSelectArrayIterator<object, object>.Where
	|
	|-RVA: 0x39CDEF0 Offset: 0x39CDFF1 VA: 0x39CDEF0
	|-Enumerable.WhereSelectArrayIterator<object, UniTask>.Where
	|
	|-RVA: 0x39CE150 Offset: 0x39CE251 VA: 0x39CE150
	|-Enumerable.WhereSelectArrayIterator<TablePair, KeyValuePair<int, object>>.Where
	|
	|-RVA: 0x39CE3B0 Offset: 0x39CE4B1 VA: 0x39CE3B0
	|-Enumerable.WhereSelectArrayIterator<TablePair, UniTask<object>>.Where
	|
	|-RVA: 0x39CE600 Offset: 0x39CE701 VA: 0x39CE600
	|-Enumerable.WhereSelectArrayIterator<TablePair, int>.Where
	|
	|-RVA: 0x39CE860 Offset: 0x39CE961 VA: 0x39CE860
	|-Enumerable.WhereSelectArrayIterator<TablePair, object>.Where
	|
	|-RVA: 0x39CEAC0 Offset: 0x39CEBC1 VA: 0x39CEAC0
	|-Enumerable.WhereSelectArrayIterator<TablePair, TablePair>.Where
	|
	|-RVA: 0x39CED20 Offset: 0x39CEE21 VA: 0x39CED20
	|-Enumerable.WhereSelectArrayIterator<TablePair, UniTask>.Where
	|
	|-RVA: 0x39CEF80 Offset: 0x39CF081 VA: 0x39CEF80
	|-Enumerable.WhereSelectArrayIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, KeyValuePair<int, object>>.Where
	|
	|-RVA: 0x39CF1E0 Offset: 0x39CF2E1 VA: 0x39CF1E0
	|-Enumerable.WhereSelectArrayIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, UniTask<object>>.Where
	|
	|-RVA: 0x39CF430 Offset: 0x39CF531 VA: 0x39CF430
	|-Enumerable.WhereSelectArrayIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, int>.Where
	|
	|-RVA: 0x39CF690 Offset: 0x39CF791 VA: 0x39CF690
	|-Enumerable.WhereSelectArrayIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, object>.Where
	|
	|-RVA: 0x39CF8F0 Offset: 0x39CF9F1 VA: 0x39CF8F0
	|-Enumerable.WhereSelectArrayIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, UniTask>.Where
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x3F7B0 Offset: 0x3F8B1 VA: 0x3F7B0
private sealed class Enumerable.<SelectIterator>d__5<TSource, TResult> : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator // TypeDefIndex: 2730
{
	// Fields
	private int <>1__state; // 0x0
	private TResult <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEnumerable<TSource> source; // 0x0
	public IEnumerable<TSource> <>3__source; // 0x0
	private int <index>5__1; // 0x0
	private Func<TSource, int, TResult> selector; // 0x0
	public Func<TSource, int, TResult> <>3__selector; // 0x0
	private IEnumerator<TSource> <>7__wrap1; // 0x0

	// Properties
	private TResult System.Collections.Generic.IEnumerator<TResult>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x41420 Offset: 0x41521 VA: 0x41420
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3165720 Offset: 0x3165821 VA: 0x3165720
	|-Enumerable.<SelectIterator>d__5<object, UniTask<object>>..ctor
	|
	|-RVA: 0x3165CB0 Offset: 0x3165DB1 VA: 0x3165CB0
	|-Enumerable.<SelectIterator>d__5<object, object>..ctor
	|
	|-RVA: 0x3166200 Offset: 0x3166301 VA: 0x3166200
	|-Enumerable.<SelectIterator>d__5<object, UniTask>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x41430 Offset: 0x41531 VA: 0x41430
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3165760 Offset: 0x3165861 VA: 0x3165760
	|-Enumerable.<SelectIterator>d__5<object, UniTask<object>>.System.IDisposable.Dispose
	|
	|-RVA: 0x3165CF0 Offset: 0x3165DF1 VA: 0x3165CF0
	|-Enumerable.<SelectIterator>d__5<object, object>.System.IDisposable.Dispose
	|
	|-RVA: 0x3166240 Offset: 0x3166341 VA: 0x3166240
	|-Enumerable.<SelectIterator>d__5<object, UniTask>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3165790 Offset: 0x3165891 VA: 0x3165790
	|-Enumerable.<SelectIterator>d__5<object, UniTask<object>>.MoveNext
	|
	|-RVA: 0x3165D20 Offset: 0x3165E21 VA: 0x3165D20
	|-Enumerable.<SelectIterator>d__5<object, object>.MoveNext
	|
	|-RVA: 0x3166270 Offset: 0x3166371 VA: 0x3166270
	|-Enumerable.<SelectIterator>d__5<object, UniTask>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3165A70 Offset: 0x3165B71 VA: 0x3165A70
	|-Enumerable.<SelectIterator>d__5<object, UniTask<object>>.<>m__Finally1
	|
	|-RVA: 0x3166000 Offset: 0x3166101 VA: 0x3166000
	|-Enumerable.<SelectIterator>d__5<object, object>.<>m__Finally1
	|
	|-RVA: 0x3166550 Offset: 0x3166651 VA: 0x3166550
	|-Enumerable.<SelectIterator>d__5<object, UniTask>.<>m__Finally1
	*/

	[DebuggerHiddenAttribute] // RVA: 0x41440 Offset: 0x41541 VA: 0x41440
	// RVA: -1 Offset: -1 Slot: 6
	private TResult System.Collections.Generic.IEnumerator<TResult>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3165B30 Offset: 0x3165C31 VA: 0x3165B30
	|-Enumerable.<SelectIterator>d__5<object, UniTask<object>>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|
	|-RVA: 0x31660C0 Offset: 0x31661C1 VA: 0x31660C0
	|-Enumerable.<SelectIterator>d__5<object, object>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|
	|-RVA: 0x3166610 Offset: 0x3166711 VA: 0x3166610
	|-Enumerable.<SelectIterator>d__5<object, UniTask>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x41450 Offset: 0x41551 VA: 0x41450
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3165B40 Offset: 0x3165C41 VA: 0x3165B40
	|-Enumerable.<SelectIterator>d__5<object, UniTask<object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x31660D0 Offset: 0x31661D1 VA: 0x31660D0
	|-Enumerable.<SelectIterator>d__5<object, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3166620 Offset: 0x3166721 VA: 0x3166620
	|-Enumerable.<SelectIterator>d__5<object, UniTask>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x41460 Offset: 0x41561 VA: 0x41460
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3165B80 Offset: 0x3165C81 VA: 0x3165B80
	|-Enumerable.<SelectIterator>d__5<object, UniTask<object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3166110 Offset: 0x3166211 VA: 0x3166110
	|-Enumerable.<SelectIterator>d__5<object, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3166660 Offset: 0x3166761 VA: 0x3166660
	|-Enumerable.<SelectIterator>d__5<object, UniTask>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x41470 Offset: 0x41571 VA: 0x41470
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<TResult> System.Collections.Generic.IEnumerable<TResult>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3165BD0 Offset: 0x3165CD1 VA: 0x3165BD0
	|-Enumerable.<SelectIterator>d__5<object, UniTask<object>>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|
	|-RVA: 0x3166120 Offset: 0x3166221 VA: 0x3166120
	|-Enumerable.<SelectIterator>d__5<object, object>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|
	|-RVA: 0x31666B0 Offset: 0x31667B1 VA: 0x31666B0
	|-Enumerable.<SelectIterator>d__5<object, UniTask>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x41480 Offset: 0x41581 VA: 0x41480
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3165C90 Offset: 0x3165D91 VA: 0x3165C90
	|-Enumerable.<SelectIterator>d__5<object, UniTask<object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x31661E0 Offset: 0x31662E1 VA: 0x31661E0
	|-Enumerable.<SelectIterator>d__5<object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3166770 Offset: 0x3166871 VA: 0x3166770
	|-Enumerable.<SelectIterator>d__5<object, UniTask>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x3F7D0 Offset: 0x3F8D1 VA: 0x3F7D0
private sealed class Enumerable.<>c__DisplayClass7_0<TSource, TMiddle, TResult> // TypeDefIndex: 2732
{
	// Fields
	public Func<TMiddle, TResult> selector2; // 0x0
	public Func<TSource, TMiddle> selector1; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B40270 Offset: 0x2B40371 VA: 0x2B40270
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, KeyValuePair<int, object>, KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x2B402E0 Offset: 0x2B403E1 VA: 0x2B402E0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, UniTask<object>, UniTask<object>>..ctor
	|
	|-RVA: 0x2B40350 Offset: 0x2B40451 VA: 0x2B40350
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, int, int>..ctor
	|
	|-RVA: 0x2B403B0 Offset: 0x2B404B1 VA: 0x2B403B0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x2B40410 Offset: 0x2B40511 VA: 0x2B40410
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, UniTask<object>>..ctor
	|
	|-RVA: 0x2B40470 Offset: 0x2B40571 VA: 0x2B40470
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, int>..ctor
	|
	|-RVA: 0x2B404D0 Offset: 0x2B405D1 VA: 0x2B404D0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, object>..ctor
	|
	|-RVA: 0x2B40530 Offset: 0x2B40631 VA: 0x2B40530
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, UniTask>..ctor
	|
	|-RVA: 0x2B40590 Offset: 0x2B40691 VA: 0x2B40590
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, UniTask, UniTask>..ctor
	|
	|-RVA: 0x2B405F0 Offset: 0x2B406F1 VA: 0x2B405F0
	|-Enumerable.<>c__DisplayClass7_0<int, KeyValuePair<int, object>, KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x2B40660 Offset: 0x2B40761 VA: 0x2B40660
	|-Enumerable.<>c__DisplayClass7_0<int, UniTask<object>, UniTask<object>>..ctor
	|
	|-RVA: 0x2B406D0 Offset: 0x2B407D1 VA: 0x2B406D0
	|-Enumerable.<>c__DisplayClass7_0<int, int, int>..ctor
	|
	|-RVA: 0x2B40730 Offset: 0x2B40831 VA: 0x2B40730
	|-Enumerable.<>c__DisplayClass7_0<int, int, object>..ctor
	|
	|-RVA: 0x2B40790 Offset: 0x2B40891 VA: 0x2B40790
	|-Enumerable.<>c__DisplayClass7_0<int, object, KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x2B407F0 Offset: 0x2B408F1 VA: 0x2B407F0
	|-Enumerable.<>c__DisplayClass7_0<int, object, UniTask<object>>..ctor
	|
	|-RVA: 0x2B40850 Offset: 0x2B40951 VA: 0x2B40850
	|-Enumerable.<>c__DisplayClass7_0<int, object, int>..ctor
	|
	|-RVA: 0x2B408B0 Offset: 0x2B409B1 VA: 0x2B408B0
	|-Enumerable.<>c__DisplayClass7_0<int, object, object>..ctor
	|
	|-RVA: 0x2B40910 Offset: 0x2B40A11 VA: 0x2B40910
	|-Enumerable.<>c__DisplayClass7_0<int, object, UniTask>..ctor
	|
	|-RVA: 0x2B40970 Offset: 0x2B40A71 VA: 0x2B40970
	|-Enumerable.<>c__DisplayClass7_0<int, UniTask, UniTask>..ctor
	|
	|-RVA: 0x2B409D0 Offset: 0x2B40AD1 VA: 0x2B409D0
	|-Enumerable.<>c__DisplayClass7_0<object, int, int>..ctor
	|
	|-RVA: 0x2B40A30 Offset: 0x2B40B31 VA: 0x2B40A30
	|-Enumerable.<>c__DisplayClass7_0<object, int, object>..ctor
	|
	|-RVA: 0x2B40A90 Offset: 0x2B40B91 VA: 0x2B40A90
	|-Enumerable.<>c__DisplayClass7_0<object, object, KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x2B40AF0 Offset: 0x2B40BF1 VA: 0x2B40AF0
	|-Enumerable.<>c__DisplayClass7_0<object, object, UniTask<object>>..ctor
	|
	|-RVA: 0x2B40B50 Offset: 0x2B40C51 VA: 0x2B40B50
	|-Enumerable.<>c__DisplayClass7_0<object, object, int>..ctor
	|
	|-RVA: 0x2B40BB0 Offset: 0x2B40CB1 VA: 0x2B40BB0
	|-Enumerable.<>c__DisplayClass7_0<object, object, object>..ctor
	|
	|-RVA: 0x2B40C10 Offset: 0x2B40D11 VA: 0x2B40C10
	|-Enumerable.<>c__DisplayClass7_0<object, object, UniTask>..ctor
	|
	|-RVA: 0x2B40C70 Offset: 0x2B40D71 VA: 0x2B40C70
	|-Enumerable.<>c__DisplayClass7_0<TablePair, KeyValuePair<int, object>, KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x2B40CE0 Offset: 0x2B40DE1 VA: 0x2B40CE0
	|-Enumerable.<>c__DisplayClass7_0<TablePair, UniTask<object>, UniTask<object>>..ctor
	|
	|-RVA: 0x2B40D50 Offset: 0x2B40E51 VA: 0x2B40D50
	|-Enumerable.<>c__DisplayClass7_0<TablePair, int, int>..ctor
	|
	|-RVA: 0x2B40DB0 Offset: 0x2B40EB1 VA: 0x2B40DB0
	|-Enumerable.<>c__DisplayClass7_0<TablePair, object, KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x2B40E10 Offset: 0x2B40F11 VA: 0x2B40E10
	|-Enumerable.<>c__DisplayClass7_0<TablePair, object, UniTask<object>>..ctor
	|
	|-RVA: 0x2B40E70 Offset: 0x2B40F71 VA: 0x2B40E70
	|-Enumerable.<>c__DisplayClass7_0<TablePair, object, int>..ctor
	|
	|-RVA: 0x2B40ED0 Offset: 0x2B40FD1 VA: 0x2B40ED0
	|-Enumerable.<>c__DisplayClass7_0<TablePair, object, object>..ctor
	|
	|-RVA: 0x2B40F30 Offset: 0x2B41031 VA: 0x2B40F30
	|-Enumerable.<>c__DisplayClass7_0<TablePair, object, UniTask>..ctor
	|
	|-RVA: 0x2B40F90 Offset: 0x2B41091 VA: 0x2B40F90
	|-Enumerable.<>c__DisplayClass7_0<TablePair, TablePair, object>..ctor
	|
	|-RVA: 0x2B41000 Offset: 0x2B41101 VA: 0x2B41000
	|-Enumerable.<>c__DisplayClass7_0<TablePair, TablePair, TablePair>..ctor
	|
	|-RVA: 0x2B41070 Offset: 0x2B41171 VA: 0x2B41070
	|-Enumerable.<>c__DisplayClass7_0<TablePair, UniTask, UniTask>..ctor
	|
	|-RVA: 0x2B410D0 Offset: 0x2B411D1 VA: 0x2B410D0
	|-Enumerable.<>c__DisplayClass7_0<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, KeyValuePair<int, object>, KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x2B41140 Offset: 0x2B41241 VA: 0x2B41140
	|-Enumerable.<>c__DisplayClass7_0<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, UniTask<object>, UniTask<object>>..ctor
	|
	|-RVA: 0x2B411B0 Offset: 0x2B412B1 VA: 0x2B411B0
	|-Enumerable.<>c__DisplayClass7_0<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, int, int>..ctor
	|
	|-RVA: 0x2B41210 Offset: 0x2B41311 VA: 0x2B41210
	|-Enumerable.<>c__DisplayClass7_0<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, object, KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x2B41270 Offset: 0x2B41371 VA: 0x2B41270
	|-Enumerable.<>c__DisplayClass7_0<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, object, UniTask<object>>..ctor
	|
	|-RVA: 0x2B412D0 Offset: 0x2B413D1 VA: 0x2B412D0
	|-Enumerable.<>c__DisplayClass7_0<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, object, int>..ctor
	|
	|-RVA: 0x2B41330 Offset: 0x2B41431 VA: 0x2B41330
	|-Enumerable.<>c__DisplayClass7_0<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, object, object>..ctor
	|
	|-RVA: 0x2B41390 Offset: 0x2B41491 VA: 0x2B41390
	|-Enumerable.<>c__DisplayClass7_0<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, object, UniTask>..ctor
	|
	|-RVA: 0x2B413F0 Offset: 0x2B414F1 VA: 0x2B413F0
	|-Enumerable.<>c__DisplayClass7_0<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, UniTask, UniTask>..ctor
	*/

	// RVA: -1 Offset: -1
	internal TResult <CombineSelectors>b__0(TSource x) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B40280 Offset: 0x2B40381 VA: 0x2B40280
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, KeyValuePair<int, object>, KeyValuePair<int, object>>.<CombineSelectors>b__0
	|
	|-RVA: 0x2B402F0 Offset: 0x2B403F1 VA: 0x2B402F0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, UniTask<object>, UniTask<object>>.<CombineSelectors>b__0
	|
	|-RVA: 0x2B40360 Offset: 0x2B40461 VA: 0x2B40360
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, int, int>.<CombineSelectors>b__0
	|
	|-RVA: 0x2B403C0 Offset: 0x2B404C1 VA: 0x2B403C0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, KeyValuePair<int, object>>.<CombineSelectors>b__0
	|
	|-RVA: 0x2B40420 Offset: 0x2B40521 VA: 0x2B40420
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, UniTask<object>>.<CombineSelectors>b__0
	|
	|-RVA: 0x2B40480 Offset: 0x2B40581 VA: 0x2B40480
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, int>.<CombineSelectors>b__0
	|
	|-RVA: 0x2B404E0 Offset: 0x2B405E1 VA: 0x2B404E0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, object>.<CombineSelectors>b__0
	|
	|-RVA: 0x2B40540 Offset: 0x2B40641 VA: 0x2B40540
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, object, UniTask>.<CombineSelectors>b__0
	|
	|-RVA: 0x2B405A0 Offset: 0x2B406A1 VA: 0x2B405A0
	|-Enumerable.<>c__DisplayClass7_0<KeyValuePair<object, object>, UniTask, UniTask>.<CombineSelectors>b__0
	|
	|-RVA: 0x2B40600 Offset: 0x2B40701 VA: 0x2B40600
	|-Enumerable.<>c__DisplayClass7_0<int, KeyValuePair<int, object>, KeyValuePair<int, object>>.<CombineSelectors>b__0
	|
	|-RVA: 0x2B40670 Offset: 0x2B40771 VA: 0x2B40670
	|-Enumerable.<>c__DisplayClass7_0<int, UniTask<object>, UniTask<object>>.<CombineSelectors>b__0
	|
	|-RVA: 0x2B406E0 Offset: 0x2B407E1 VA: 0x2B406E0
	|-Enumerable.<>c__DisplayClass7_0<int, int, int>.<CombineSelectors>b__0
	|
	|-RVA: 0x2B40740 Offset: 0x2B40841 VA: 0x2B40740
	|-Enumerable.<>c__DisplayClass7_0<int, int, object>.<CombineSelectors>b__0
	|
	|-RVA: 0x2B407A0 Offset: 0x2B408A1 VA: 0x2B407A0
	|-Enumerable.<>c__DisplayClass7_0<int, object, KeyValuePair<int, object>>.<CombineSelectors>b__0
	|
	|-RVA: 0x2B40800 Offset: 0x2B40901 VA: 0x2B40800
	|-Enumerable.<>c__DisplayClass7_0<int, object, UniTask<object>>.<CombineSelectors>b__0
	|
	|-RVA: 0x2B40860 Offset: 0x2B40961 VA: 0x2B40860
	|-Enumerable.<>c__DisplayClass7_0<int, object, int>.<CombineSelectors>b__0
	|
	|-RVA: 0x2B408C0 Offset: 0x2B409C1 VA: 0x2B408C0
	|-Enumerable.<>c__DisplayClass7_0<int, object, object>.<CombineSelectors>b__0
	|
	|-RVA: 0x2B40920 Offset: 0x2B40A21 VA: 0x2B40920
	|-Enumerable.<>c__DisplayClass7_0<int, object, UniTask>.<CombineSelectors>b__0
	|
	|-RVA: 0x2B40980 Offset: 0x2B40A81 VA: 0x2B40980
	|-Enumerable.<>c__DisplayClass7_0<int, UniTask, UniTask>.<CombineSelectors>b__0
	|
	|-RVA: 0x2B409E0 Offset: 0x2B40AE1 VA: 0x2B409E0
	|-Enumerable.<>c__DisplayClass7_0<object, int, int>.<CombineSelectors>b__0
	|
	|-RVA: 0x2B40A40 Offset: 0x2B40B41 VA: 0x2B40A40
	|-Enumerable.<>c__DisplayClass7_0<object, int, object>.<CombineSelectors>b__0
	|
	|-RVA: 0x2B40AA0 Offset: 0x2B40BA1 VA: 0x2B40AA0
	|-Enumerable.<>c__DisplayClass7_0<object, object, KeyValuePair<int, object>>.<CombineSelectors>b__0
	|
	|-RVA: 0x2B40B00 Offset: 0x2B40C01 VA: 0x2B40B00
	|-Enumerable.<>c__DisplayClass7_0<object, object, UniTask<object>>.<CombineSelectors>b__0
	|
	|-RVA: 0x2B40B60 Offset: 0x2B40C61 VA: 0x2B40B60
	|-Enumerable.<>c__DisplayClass7_0<object, object, int>.<CombineSelectors>b__0
	|
	|-RVA: 0x2B40BC0 Offset: 0x2B40CC1 VA: 0x2B40BC0
	|-Enumerable.<>c__DisplayClass7_0<object, object, object>.<CombineSelectors>b__0
	|
	|-RVA: 0x2B40C20 Offset: 0x2B40D21 VA: 0x2B40C20
	|-Enumerable.<>c__DisplayClass7_0<object, object, UniTask>.<CombineSelectors>b__0
	|
	|-RVA: 0x2B40C80 Offset: 0x2B40D81 VA: 0x2B40C80
	|-Enumerable.<>c__DisplayClass7_0<TablePair, KeyValuePair<int, object>, KeyValuePair<int, object>>.<CombineSelectors>b__0
	|
	|-RVA: 0x2B40CF0 Offset: 0x2B40DF1 VA: 0x2B40CF0
	|-Enumerable.<>c__DisplayClass7_0<TablePair, UniTask<object>, UniTask<object>>.<CombineSelectors>b__0
	|
	|-RVA: 0x2B40D60 Offset: 0x2B40E61 VA: 0x2B40D60
	|-Enumerable.<>c__DisplayClass7_0<TablePair, int, int>.<CombineSelectors>b__0
	|
	|-RVA: 0x2B40DC0 Offset: 0x2B40EC1 VA: 0x2B40DC0
	|-Enumerable.<>c__DisplayClass7_0<TablePair, object, KeyValuePair<int, object>>.<CombineSelectors>b__0
	|
	|-RVA: 0x2B40E20 Offset: 0x2B40F21 VA: 0x2B40E20
	|-Enumerable.<>c__DisplayClass7_0<TablePair, object, UniTask<object>>.<CombineSelectors>b__0
	|
	|-RVA: 0x2B40E80 Offset: 0x2B40F81 VA: 0x2B40E80
	|-Enumerable.<>c__DisplayClass7_0<TablePair, object, int>.<CombineSelectors>b__0
	|
	|-RVA: 0x2B40EE0 Offset: 0x2B40FE1 VA: 0x2B40EE0
	|-Enumerable.<>c__DisplayClass7_0<TablePair, object, object>.<CombineSelectors>b__0
	|
	|-RVA: 0x2B40F40 Offset: 0x2B41041 VA: 0x2B40F40
	|-Enumerable.<>c__DisplayClass7_0<TablePair, object, UniTask>.<CombineSelectors>b__0
	|
	|-RVA: 0x2B40FA0 Offset: 0x2B410A1 VA: 0x2B40FA0
	|-Enumerable.<>c__DisplayClass7_0<TablePair, TablePair, object>.<CombineSelectors>b__0
	|
	|-RVA: 0x2B41010 Offset: 0x2B41111 VA: 0x2B41010
	|-Enumerable.<>c__DisplayClass7_0<TablePair, TablePair, TablePair>.<CombineSelectors>b__0
	|
	|-RVA: 0x2B41080 Offset: 0x2B41181 VA: 0x2B41080
	|-Enumerable.<>c__DisplayClass7_0<TablePair, UniTask, UniTask>.<CombineSelectors>b__0
	|
	|-RVA: 0x2B410E0 Offset: 0x2B411E1 VA: 0x2B410E0
	|-Enumerable.<>c__DisplayClass7_0<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, KeyValuePair<int, object>, KeyValuePair<int, object>>.<CombineSelectors>b__0
	|
	|-RVA: 0x2B41150 Offset: 0x2B41251 VA: 0x2B41150
	|-Enumerable.<>c__DisplayClass7_0<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, UniTask<object>, UniTask<object>>.<CombineSelectors>b__0
	|
	|-RVA: 0x2B411C0 Offset: 0x2B412C1 VA: 0x2B411C0
	|-Enumerable.<>c__DisplayClass7_0<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, int, int>.<CombineSelectors>b__0
	|
	|-RVA: 0x2B41220 Offset: 0x2B41321 VA: 0x2B41220
	|-Enumerable.<>c__DisplayClass7_0<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, object, KeyValuePair<int, object>>.<CombineSelectors>b__0
	|
	|-RVA: 0x2B41280 Offset: 0x2B41381 VA: 0x2B41280
	|-Enumerable.<>c__DisplayClass7_0<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, object, UniTask<object>>.<CombineSelectors>b__0
	|
	|-RVA: 0x2B412E0 Offset: 0x2B413E1 VA: 0x2B412E0
	|-Enumerable.<>c__DisplayClass7_0<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, object, int>.<CombineSelectors>b__0
	|
	|-RVA: 0x2B41340 Offset: 0x2B41441 VA: 0x2B41340
	|-Enumerable.<>c__DisplayClass7_0<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, object, object>.<CombineSelectors>b__0
	|
	|-RVA: 0x2B413A0 Offset: 0x2B414A1 VA: 0x2B413A0
	|-Enumerable.<>c__DisplayClass7_0<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, object, UniTask>.<CombineSelectors>b__0
	|
	|-RVA: 0x2B41400 Offset: 0x2B41501 VA: 0x2B41400
	|-Enumerable.<>c__DisplayClass7_0<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, UniTask, UniTask>.<CombineSelectors>b__0
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x3F7F0 Offset: 0x3F8F1 VA: 0x3F7F0
private sealed class Enumerable.<TakeWhileIterator>d__27<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator // TypeDefIndex: 2734
{
	// Fields
	private int <>1__state; // 0x0
	private TSource <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEnumerable<TSource> source; // 0x0
	public IEnumerable<TSource> <>3__source; // 0x0
	private Func<TSource, bool> predicate; // 0x0
	public Func<TSource, bool> <>3__predicate; // 0x0
	private IEnumerator<TSource> <>7__wrap1; // 0x0

	// Properties
	private TSource System.Collections.Generic.IEnumerator<TSource>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x41500 Offset: 0x41601 VA: 0x41500
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FBBBD0 Offset: 0x1FBBCD1 VA: 0x1FBBBD0
	|-Enumerable.<TakeWhileIterator>d__27<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x41510 Offset: 0x41611 VA: 0x41510
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FBBC10 Offset: 0x1FBBD11 VA: 0x1FBBC10
	|-Enumerable.<TakeWhileIterator>d__27<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FBBC40 Offset: 0x1FBBD41 VA: 0x1FBBC40
	|-Enumerable.<TakeWhileIterator>d__27<object>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FBBEE0 Offset: 0x1FBBFE1 VA: 0x1FBBEE0
	|-Enumerable.<TakeWhileIterator>d__27<object>.<>m__Finally1
	*/

	[DebuggerHiddenAttribute] // RVA: 0x41520 Offset: 0x41621 VA: 0x41520
	// RVA: -1 Offset: -1 Slot: 6
	private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FBBFA0 Offset: 0x1FBC0A1 VA: 0x1FBBFA0
	|-Enumerable.<TakeWhileIterator>d__27<object>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x41530 Offset: 0x41631 VA: 0x41530
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FBBFB0 Offset: 0x1FBC0B1 VA: 0x1FBBFB0
	|-Enumerable.<TakeWhileIterator>d__27<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x41540 Offset: 0x41641 VA: 0x41540
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FBBFF0 Offset: 0x1FBC0F1 VA: 0x1FBBFF0
	|-Enumerable.<TakeWhileIterator>d__27<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x41550 Offset: 0x41651 VA: 0x41550
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FBC000 Offset: 0x1FBC101 VA: 0x1FBC000
	|-Enumerable.<TakeWhileIterator>d__27<object>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x41560 Offset: 0x41661 VA: 0x41560
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FBC0C0 Offset: 0x1FBC1C1 VA: 0x1FBC0C0
	|-Enumerable.<TakeWhileIterator>d__27<object>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x3F810 Offset: 0x3F911 VA: 0x3F810
private sealed class Enumerable.<ConcatIterator>d__59<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator // TypeDefIndex: 2736
{
	// Fields
	private int <>1__state; // 0x0
	private TSource <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEnumerable<TSource> first; // 0x0
	public IEnumerable<TSource> <>3__first; // 0x0
	private IEnumerable<TSource> second; // 0x0
	public IEnumerable<TSource> <>3__second; // 0x0
	private IEnumerator<TSource> <>7__wrap1; // 0x0

	// Properties
	private TSource System.Collections.Generic.IEnumerator<TSource>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x415E0 Offset: 0x416E1 VA: 0x415E0
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B479D0 Offset: 0x2B47AD1 VA: 0x2B479D0
	|-Enumerable.<ConcatIterator>d__59<DiagnosticEvent>..ctor
	|
	|-RVA: 0x2B482C0 Offset: 0x2B483C1 VA: 0x2B482C0
	|-Enumerable.<ConcatIterator>d__59<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x415F0 Offset: 0x416F1 VA: 0x415F0
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B47A10 Offset: 0x2B47B11 VA: 0x2B47A10
	|-Enumerable.<ConcatIterator>d__59<DiagnosticEvent>.System.IDisposable.Dispose
	|
	|-RVA: 0x2B48300 Offset: 0x2B48401 VA: 0x2B48300
	|-Enumerable.<ConcatIterator>d__59<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B47AE0 Offset: 0x2B47BE1 VA: 0x2B47AE0
	|-Enumerable.<ConcatIterator>d__59<DiagnosticEvent>.MoveNext
	|
	|-RVA: 0x2B483D0 Offset: 0x2B484D1 VA: 0x2B483D0
	|-Enumerable.<ConcatIterator>d__59<object>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B47FA0 Offset: 0x2B480A1 VA: 0x2B47FA0
	|-Enumerable.<ConcatIterator>d__59<DiagnosticEvent>.<>m__Finally1
	|
	|-RVA: 0x2B48820 Offset: 0x2B48921 VA: 0x2B48820
	|-Enumerable.<ConcatIterator>d__59<object>.<>m__Finally1
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B48060 Offset: 0x2B48161 VA: 0x2B48060
	|-Enumerable.<ConcatIterator>d__59<DiagnosticEvent>.<>m__Finally2
	|
	|-RVA: 0x2B488E0 Offset: 0x2B489E1 VA: 0x2B488E0
	|-Enumerable.<ConcatIterator>d__59<object>.<>m__Finally2
	*/

	[DebuggerHiddenAttribute] // RVA: 0x41600 Offset: 0x41701 VA: 0x41600
	// RVA: -1 Offset: -1 Slot: 6
	private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B48120 Offset: 0x2B48221 VA: 0x2B48120
	|-Enumerable.<ConcatIterator>d__59<DiagnosticEvent>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0x2B489A0 Offset: 0x2B48AA1 VA: 0x2B489A0
	|-Enumerable.<ConcatIterator>d__59<object>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x41610 Offset: 0x41711 VA: 0x41610
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B48140 Offset: 0x2B48241 VA: 0x2B48140
	|-Enumerable.<ConcatIterator>d__59<DiagnosticEvent>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2B489B0 Offset: 0x2B48AB1 VA: 0x2B489B0
	|-Enumerable.<ConcatIterator>d__59<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x41620 Offset: 0x41721 VA: 0x41620
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B48180 Offset: 0x2B48281 VA: 0x2B48180
	|-Enumerable.<ConcatIterator>d__59<DiagnosticEvent>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2B489F0 Offset: 0x2B48AF1 VA: 0x2B489F0
	|-Enumerable.<ConcatIterator>d__59<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x41630 Offset: 0x41731 VA: 0x41630
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B481E0 Offset: 0x2B482E1 VA: 0x2B481E0
	|-Enumerable.<ConcatIterator>d__59<DiagnosticEvent>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0x2B48A00 Offset: 0x2B48B01 VA: 0x2B48A00
	|-Enumerable.<ConcatIterator>d__59<object>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x41640 Offset: 0x41741 VA: 0x41640
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B482A0 Offset: 0x2B483A1 VA: 0x2B482A0
	|-Enumerable.<ConcatIterator>d__59<DiagnosticEvent>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2B48AC0 Offset: 0x2B48BC1 VA: 0x2B48AC0
	|-Enumerable.<ConcatIterator>d__59<object>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x3F830 Offset: 0x3F931 VA: 0x3F830
private sealed class Enumerable.<ExceptIterator>d__77<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator // TypeDefIndex: 2738
{
	// Fields
	private int <>1__state; // 0x0
	private TSource <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEqualityComparer<TSource> comparer; // 0x0
	public IEqualityComparer<TSource> <>3__comparer; // 0x0
	private IEnumerable<TSource> second; // 0x0
	public IEnumerable<TSource> <>3__second; // 0x0
	private IEnumerable<TSource> first; // 0x0
	public IEnumerable<TSource> <>3__first; // 0x0
	private Set<TSource> <set>5__1; // 0x0
	private IEnumerator<TSource> <>7__wrap1; // 0x0

	// Properties
	private TSource System.Collections.Generic.IEnumerator<TSource>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x416C0 Offset: 0x417C1 VA: 0x416C0
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B4C1F0 Offset: 0x2B4C2F1 VA: 0x2B4C1F0
	|-Enumerable.<ExceptIterator>d__77<Int32Enum>..ctor
	|
	|-RVA: 0x2B4CA00 Offset: 0x2B4CB01 VA: 0x2B4CA00
	|-Enumerable.<ExceptIterator>d__77<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x416D0 Offset: 0x417D1 VA: 0x416D0
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B4C230 Offset: 0x2B4C331 VA: 0x2B4C230
	|-Enumerable.<ExceptIterator>d__77<Int32Enum>.System.IDisposable.Dispose
	|
	|-RVA: 0x2B4CA40 Offset: 0x2B4CB41 VA: 0x2B4CA40
	|-Enumerable.<ExceptIterator>d__77<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B4C260 Offset: 0x2B4C361 VA: 0x2B4C260
	|-Enumerable.<ExceptIterator>d__77<Int32Enum>.MoveNext
	|
	|-RVA: 0x2B4CA70 Offset: 0x2B4CB71 VA: 0x2B4CA70
	|-Enumerable.<ExceptIterator>d__77<object>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B4C7B0 Offset: 0x2B4C8B1 VA: 0x2B4C7B0
	|-Enumerable.<ExceptIterator>d__77<Int32Enum>.<>m__Finally1
	|
	|-RVA: 0x2B4CFD0 Offset: 0x2B4D0D1 VA: 0x2B4CFD0
	|-Enumerable.<ExceptIterator>d__77<object>.<>m__Finally1
	*/

	[DebuggerHiddenAttribute] // RVA: 0x416E0 Offset: 0x417E1 VA: 0x416E0
	// RVA: -1 Offset: -1 Slot: 6
	private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B4C870 Offset: 0x2B4C971 VA: 0x2B4C870
	|-Enumerable.<ExceptIterator>d__77<Int32Enum>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0x2B4D090 Offset: 0x2B4D191 VA: 0x2B4D090
	|-Enumerable.<ExceptIterator>d__77<object>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x416F0 Offset: 0x417F1 VA: 0x416F0
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B4C880 Offset: 0x2B4C981 VA: 0x2B4C880
	|-Enumerable.<ExceptIterator>d__77<Int32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2B4D0A0 Offset: 0x2B4D1A1 VA: 0x2B4D0A0
	|-Enumerable.<ExceptIterator>d__77<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x41700 Offset: 0x41801 VA: 0x41700
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B4C8C0 Offset: 0x2B4C9C1 VA: 0x2B4C8C0
	|-Enumerable.<ExceptIterator>d__77<Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2B4D0E0 Offset: 0x2B4D1E1 VA: 0x2B4D0E0
	|-Enumerable.<ExceptIterator>d__77<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x41710 Offset: 0x41811 VA: 0x41710
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B4C910 Offset: 0x2B4CA11 VA: 0x2B4C910
	|-Enumerable.<ExceptIterator>d__77<Int32Enum>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0x2B4D0F0 Offset: 0x2B4D1F1 VA: 0x2B4D0F0
	|-Enumerable.<ExceptIterator>d__77<object>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x41720 Offset: 0x41821 VA: 0x41720
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B4C9E0 Offset: 0x2B4CAE1 VA: 0x2B4C9E0
	|-Enumerable.<ExceptIterator>d__77<Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2B4D1C0 Offset: 0x2B4D2C1 VA: 0x2B4D1C0
	|-Enumerable.<ExceptIterator>d__77<object>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x3F850 Offset: 0x3F951 VA: 0x3F850
private sealed class Enumerable.<OfTypeIterator>d__97<TResult> : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator // TypeDefIndex: 2740
{
	// Fields
	private int <>1__state; // 0x0
	private TResult <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEnumerable source; // 0x0
	public IEnumerable <>3__source; // 0x0
	private IEnumerator <>7__wrap1; // 0x0

	// Properties
	private TResult System.Collections.Generic.IEnumerator<TResult>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x417A0 Offset: 0x418A1 VA: 0x417A0
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3151670 Offset: 0x3151771 VA: 0x3151670
	|-Enumerable.<OfTypeIterator>d__97<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x417B0 Offset: 0x418B1 VA: 0x417B0
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31516B0 Offset: 0x31517B1 VA: 0x31516B0
	|-Enumerable.<OfTypeIterator>d__97<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31516E0 Offset: 0x31517E1 VA: 0x31516E0
	|-Enumerable.<OfTypeIterator>d__97<object>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31519B0 Offset: 0x3151AB1 VA: 0x31519B0
	|-Enumerable.<OfTypeIterator>d__97<object>.<>m__Finally1
	*/

	[DebuggerHiddenAttribute] // RVA: 0x417C0 Offset: 0x418C1 VA: 0x417C0
	// RVA: -1 Offset: -1 Slot: 6
	private TResult System.Collections.Generic.IEnumerator<TResult>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3151A80 Offset: 0x3151B81 VA: 0x3151A80
	|-Enumerable.<OfTypeIterator>d__97<object>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x417D0 Offset: 0x418D1 VA: 0x417D0
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3151A90 Offset: 0x3151B91 VA: 0x3151A90
	|-Enumerable.<OfTypeIterator>d__97<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x417E0 Offset: 0x418E1 VA: 0x417E0
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3151AD0 Offset: 0x3151BD1 VA: 0x3151AD0
	|-Enumerable.<OfTypeIterator>d__97<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x417F0 Offset: 0x418F1 VA: 0x417F0
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<TResult> System.Collections.Generic.IEnumerable<TResult>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3151AE0 Offset: 0x3151BE1 VA: 0x3151AE0
	|-Enumerable.<OfTypeIterator>d__97<object>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x41800 Offset: 0x41901 VA: 0x41800
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3151B90 Offset: 0x3151C91 VA: 0x3151B90
	|-Enumerable.<OfTypeIterator>d__97<object>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x3F870 Offset: 0x3F971 VA: 0x3F870
private sealed class Enumerable.<RangeIterator>d__115 : IEnumerable<int>, IEnumerable, IEnumerator<int>, IDisposable, IEnumerator // TypeDefIndex: 2742
{
	// Fields
	private int <>1__state; // 0x10
	private int <>2__current; // 0x14
	private int <>l__initialThreadId; // 0x18
	private int start; // 0x1C
	public int <>3__start; // 0x20
	private int <i>5__1; // 0x24
	private int count; // 0x28
	public int <>3__count; // 0x2C

	// Properties
	private int System.Collections.Generic.IEnumerator<System.Int32>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x41880 Offset: 0x41981 VA: 0x41880
	// RVA: 0x333D610 Offset: 0x333D711 VA: 0x333D610
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x41890 Offset: 0x41991 VA: 0x41890
	// RVA: 0x333D650 Offset: 0x333D751 VA: 0x333D650 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x333D660 Offset: 0x333D761 VA: 0x333D660 Slot: 8
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x418A0 Offset: 0x419A1 VA: 0x418A0
	// RVA: 0x333D6D0 Offset: 0x333D7D1 VA: 0x333D6D0 Slot: 6
	private int System.Collections.Generic.IEnumerator<System.Int32>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x418B0 Offset: 0x419B1 VA: 0x418B0
	// RVA: 0x333D6E0 Offset: 0x333D7E1 VA: 0x333D6E0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x418C0 Offset: 0x419C1 VA: 0x418C0
	// RVA: 0x333D720 Offset: 0x333D821 VA: 0x333D720 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x418D0 Offset: 0x419D1 VA: 0x418D0
	// RVA: 0x333D780 Offset: 0x333D881 VA: 0x333D780 Slot: 4
	private IEnumerator<int> System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x418E0 Offset: 0x419E1 VA: 0x418E0
	// RVA: 0x333D830 Offset: 0x333D931 VA: 0x333D830 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

