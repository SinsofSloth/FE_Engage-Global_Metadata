// Namespace: 
private abstract class Enumerable.Iterator<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator // TypeDefIndex: 2723
{
	// Fields
	private int threadId; // 0x0
	internal int state; // 0x0
	internal TSource current; // 0x0

	// Properties
	public TSource Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F7D290 Offset: 0x2F7D391 VA: 0x2F7D290
	|-Enumerable.Iterator<KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x2F7D420 Offset: 0x2F7D521 VA: 0x2F7D420
	|-Enumerable.Iterator<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x2F7D5B0 Offset: 0x2F7D6B1 VA: 0x2F7D5B0
	|-Enumerable.Iterator<UniTask<object>>..ctor
	|
	|-RVA: 0x2F7D740 Offset: 0x2F7D841 VA: 0x2F7D740
	|-Enumerable.Iterator<Color>..ctor
	|
	|-RVA: 0x2F7D8D0 Offset: 0x2F7D9D1 VA: 0x2F7D8D0
	|-Enumerable.Iterator<ContourVertex>..ctor
	|
	|-RVA: 0x2F7DA90 Offset: 0x2F7DB91 VA: 0x2F7DA90
	|-Enumerable.Iterator<int>..ctor
	|
	|-RVA: 0x2F7DC10 Offset: 0x2F7DD11 VA: 0x2F7DC10
	|-Enumerable.Iterator<object>..ctor
	|
	|-RVA: 0x2F7DD50 Offset: 0x2F7DE51 VA: 0x2F7DD50
	|-Enumerable.Iterator<TablePair>..ctor
	|
	|-RVA: 0x2F7DEE0 Offset: 0x2F7DFE1 VA: 0x2F7DEE0
	|-Enumerable.Iterator<UniTask>..ctor
	|
	|-RVA: 0x2F7E060 Offset: 0x2F7E161 VA: 0x2F7E060
	|-Enumerable.Iterator<Vector3>..ctor
	|
	|-RVA: 0x2F7E200 Offset: 0x2F7E301 VA: 0x2F7E200
	|-Enumerable.Iterator<float3>..ctor
	|
	|-RVA: 0x2F7E3A0 Offset: 0x2F7E4A1 VA: 0x2F7E3A0
	|-Enumerable.Iterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public TSource get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F7D2D0 Offset: 0x2F7D3D1 VA: 0x2F7D2D0
	|-Enumerable.Iterator<KeyValuePair<int, object>>.get_Current
	|
	|-RVA: 0x2F7D460 Offset: 0x2F7D561 VA: 0x2F7D460
	|-Enumerable.Iterator<KeyValuePair<object, object>>.get_Current
	|
	|-RVA: 0x2F7D5F0 Offset: 0x2F7D6F1 VA: 0x2F7D5F0
	|-Enumerable.Iterator<UniTask<object>>.get_Current
	|
	|-RVA: 0x2F7D780 Offset: 0x2F7D881 VA: 0x2F7D780
	|-Enumerable.Iterator<Color>.get_Current
	|
	|-RVA: 0x2F7D910 Offset: 0x2F7DA11 VA: 0x2F7D910
	|-Enumerable.Iterator<ContourVertex>.get_Current
	|
	|-RVA: 0x2F7DAD0 Offset: 0x2F7DBD1 VA: 0x2F7DAD0
	|-Enumerable.Iterator<int>.get_Current
	|
	|-RVA: 0x2F7DC50 Offset: 0x2F7DD51 VA: 0x2F7DC50
	|-Enumerable.Iterator<object>.get_Current
	|
	|-RVA: 0x2F7DD90 Offset: 0x2F7DE91 VA: 0x2F7DD90
	|-Enumerable.Iterator<TablePair>.get_Current
	|
	|-RVA: 0x2F7DF20 Offset: 0x2F7E021 VA: 0x2F7DF20
	|-Enumerable.Iterator<UniTask>.get_Current
	|
	|-RVA: 0x2F7E0A0 Offset: 0x2F7E1A1 VA: 0x2F7E0A0
	|-Enumerable.Iterator<Vector3>.get_Current
	|
	|-RVA: 0x2F7E240 Offset: 0x2F7E341 VA: 0x2F7E240
	|-Enumerable.Iterator<float3>.get_Current
	|
	|-RVA: 0x2F7E3E0 Offset: 0x2F7E4E1 VA: 0x2F7E3E0
	|-Enumerable.Iterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public abstract Enumerable.Iterator<TSource> Clone();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Enumerable.Iterator<object>.Clone
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F7D2E0 Offset: 0x2F7D3E1 VA: 0x2F7D2E0
	|-Enumerable.Iterator<KeyValuePair<int, object>>.Dispose
	|
	|-RVA: 0x2F7D470 Offset: 0x2F7D571 VA: 0x2F7D470
	|-Enumerable.Iterator<KeyValuePair<object, object>>.Dispose
	|
	|-RVA: 0x2F7D600 Offset: 0x2F7D701 VA: 0x2F7D600
	|-Enumerable.Iterator<UniTask<object>>.Dispose
	|
	|-RVA: 0x2F7D790 Offset: 0x2F7D891 VA: 0x2F7D790
	|-Enumerable.Iterator<Color>.Dispose
	|
	|-RVA: 0x2F7D930 Offset: 0x2F7DA31 VA: 0x2F7D930
	|-Enumerable.Iterator<ContourVertex>.Dispose
	|
	|-RVA: 0x2F7DAE0 Offset: 0x2F7DBE1 VA: 0x2F7DAE0
	|-Enumerable.Iterator<int>.Dispose
	|
	|-RVA: 0x2F7DC60 Offset: 0x2F7DD61 VA: 0x2F7DC60
	|-Enumerable.Iterator<object>.Dispose
	|
	|-RVA: 0x2F7DDA0 Offset: 0x2F7DEA1 VA: 0x2F7DDA0
	|-Enumerable.Iterator<TablePair>.Dispose
	|
	|-RVA: 0x2F7DF30 Offset: 0x2F7E031 VA: 0x2F7DF30
	|-Enumerable.Iterator<UniTask>.Dispose
	|
	|-RVA: 0x2F7E0B0 Offset: 0x2F7E1B1 VA: 0x2F7E0B0
	|-Enumerable.Iterator<Vector3>.Dispose
	|
	|-RVA: 0x2F7E250 Offset: 0x2F7E351 VA: 0x2F7E250
	|-Enumerable.Iterator<float3>.Dispose
	|
	|-RVA: 0x2F7E3F0 Offset: 0x2F7E4F1 VA: 0x2F7E3F0
	|-Enumerable.Iterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator<TSource> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F7D2F0 Offset: 0x2F7D3F1 VA: 0x2F7D2F0
	|-Enumerable.Iterator<KeyValuePair<int, object>>.GetEnumerator
	|
	|-RVA: 0x2F7D480 Offset: 0x2F7D581 VA: 0x2F7D480
	|-Enumerable.Iterator<KeyValuePair<object, object>>.GetEnumerator
	|
	|-RVA: 0x2F7D610 Offset: 0x2F7D711 VA: 0x2F7D610
	|-Enumerable.Iterator<UniTask<object>>.GetEnumerator
	|
	|-RVA: 0x2F7D7A0 Offset: 0x2F7D8A1 VA: 0x2F7D7A0
	|-Enumerable.Iterator<Color>.GetEnumerator
	|
	|-RVA: 0x2F7D950 Offset: 0x2F7DA51 VA: 0x2F7D950
	|-Enumerable.Iterator<ContourVertex>.GetEnumerator
	|
	|-RVA: 0x2F7DAF0 Offset: 0x2F7DBF1 VA: 0x2F7DAF0
	|-Enumerable.Iterator<int>.GetEnumerator
	|
	|-RVA: 0x2F7DC70 Offset: 0x2F7DD71 VA: 0x2F7DC70
	|-Enumerable.Iterator<object>.GetEnumerator
	|
	|-RVA: 0x2F7DDB0 Offset: 0x2F7DEB1 VA: 0x2F7DDB0
	|-Enumerable.Iterator<TablePair>.GetEnumerator
	|
	|-RVA: 0x2F7DF40 Offset: 0x2F7E041 VA: 0x2F7DF40
	|-Enumerable.Iterator<UniTask>.GetEnumerator
	|
	|-RVA: 0x2F7E0D0 Offset: 0x2F7E1D1 VA: 0x2F7E0D0
	|-Enumerable.Iterator<Vector3>.GetEnumerator
	|
	|-RVA: 0x2F7E270 Offset: 0x2F7E371 VA: 0x2F7E270
	|-Enumerable.Iterator<float3>.GetEnumerator
	|
	|-RVA: 0x2F7E400 Offset: 0x2F7E501 VA: 0x2F7E400
	|-Enumerable.Iterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public abstract bool MoveNext();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Enumerable.Iterator<object>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public abstract IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Enumerable.Iterator<object>.Select<object>
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public abstract IEnumerable<TSource> Where(Func<TSource, bool> predicate);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Enumerable.Iterator<object>.Where
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F7D350 Offset: 0x2F7D451 VA: 0x2F7D350
	|-Enumerable.Iterator<KeyValuePair<int, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F7D4E0 Offset: 0x2F7D5E1 VA: 0x2F7D4E0
	|-Enumerable.Iterator<KeyValuePair<object, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F7D670 Offset: 0x2F7D771 VA: 0x2F7D670
	|-Enumerable.Iterator<UniTask<object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F7D800 Offset: 0x2F7D901 VA: 0x2F7D800
	|-Enumerable.Iterator<Color>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F7D9B0 Offset: 0x2F7DAB1 VA: 0x2F7D9B0
	|-Enumerable.Iterator<ContourVertex>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F7DB50 Offset: 0x2F7DC51 VA: 0x2F7DB50
	|-Enumerable.Iterator<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F7DCD0 Offset: 0x2F7DDD1 VA: 0x2F7DCD0
	|-Enumerable.Iterator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F7DE10 Offset: 0x2F7DF11 VA: 0x2F7DE10
	|-Enumerable.Iterator<TablePair>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F7DFA0 Offset: 0x2F7E0A1 VA: 0x2F7DFA0
	|-Enumerable.Iterator<UniTask>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F7E130 Offset: 0x2F7E231 VA: 0x2F7E130
	|-Enumerable.Iterator<Vector3>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F7E2D0 Offset: 0x2F7E3D1 VA: 0x2F7E2D0
	|-Enumerable.Iterator<float3>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2F7E460 Offset: 0x2F7E561 VA: 0x2F7E460
	|-Enumerable.Iterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F7D3C0 Offset: 0x2F7D4C1 VA: 0x2F7D3C0
	|-Enumerable.Iterator<KeyValuePair<int, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F7D550 Offset: 0x2F7D651 VA: 0x2F7D550
	|-Enumerable.Iterator<KeyValuePair<object, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F7D6E0 Offset: 0x2F7D7E1 VA: 0x2F7D6E0
	|-Enumerable.Iterator<UniTask<object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F7D870 Offset: 0x2F7D971 VA: 0x2F7D870
	|-Enumerable.Iterator<Color>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F7DA30 Offset: 0x2F7DB31 VA: 0x2F7DA30
	|-Enumerable.Iterator<ContourVertex>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F7DBB0 Offset: 0x2F7DCB1 VA: 0x2F7DBB0
	|-Enumerable.Iterator<int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F7DCF0 Offset: 0x2F7DDF1 VA: 0x2F7DCF0
	|-Enumerable.Iterator<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F7DE80 Offset: 0x2F7DF81 VA: 0x2F7DE80
	|-Enumerable.Iterator<TablePair>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F7E000 Offset: 0x2F7E101 VA: 0x2F7E000
	|-Enumerable.Iterator<UniTask>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F7E1A0 Offset: 0x2F7E2A1 VA: 0x2F7E1A0
	|-Enumerable.Iterator<Vector3>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F7E340 Offset: 0x2F7E441 VA: 0x2F7E340
	|-Enumerable.Iterator<float3>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2F7E4D0 Offset: 0x2F7E5D1 VA: 0x2F7E4D0
	|-Enumerable.Iterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F7D3E0 Offset: 0x2F7D4E1 VA: 0x2F7D3E0
	|-Enumerable.Iterator<KeyValuePair<int, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F7D570 Offset: 0x2F7D671 VA: 0x2F7D570
	|-Enumerable.Iterator<KeyValuePair<object, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F7D700 Offset: 0x2F7D801 VA: 0x2F7D700
	|-Enumerable.Iterator<UniTask<object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F7D890 Offset: 0x2F7D991 VA: 0x2F7D890
	|-Enumerable.Iterator<Color>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F7DA50 Offset: 0x2F7DB51 VA: 0x2F7DA50
	|-Enumerable.Iterator<ContourVertex>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F7DBD0 Offset: 0x2F7DCD1 VA: 0x2F7DBD0
	|-Enumerable.Iterator<int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F7DD10 Offset: 0x2F7DE11 VA: 0x2F7DD10
	|-Enumerable.Iterator<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F7DEA0 Offset: 0x2F7DFA1 VA: 0x2F7DEA0
	|-Enumerable.Iterator<TablePair>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F7E020 Offset: 0x2F7E121 VA: 0x2F7E020
	|-Enumerable.Iterator<UniTask>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F7E1C0 Offset: 0x2F7E2C1 VA: 0x2F7E1C0
	|-Enumerable.Iterator<Vector3>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F7E360 Offset: 0x2F7E461 VA: 0x2F7E360
	|-Enumerable.Iterator<float3>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2F7E4F0 Offset: 0x2F7E5F1 VA: 0x2F7E4F0
	|-Enumerable.Iterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.System.Collections.IEnumerator.Reset
	*/
}

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
private class Enumerable.WhereArrayIterator<TSource> : Enumerable.Iterator<TSource> // TypeDefIndex: 2725
{
	// Fields
	private TSource[] source; // 0x0
	private Func<TSource, bool> predicate; // 0x0
	private int index; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(TSource[] source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39C58C0 Offset: 0x39C59C1 VA: 0x39C58C0
	|-Enumerable.WhereArrayIterator<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x39C5AF0 Offset: 0x39C5BF1 VA: 0x39C5AF0
	|-Enumerable.WhereArrayIterator<object>..ctor
	|
	|-RVA: 0x39C5D20 Offset: 0x39C5E21 VA: 0x39C5D20
	|-Enumerable.WhereArrayIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public override Enumerable.Iterator<TSource> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39C5920 Offset: 0x39C5A21 VA: 0x39C5920
	|-Enumerable.WhereArrayIterator<KeyValuePair<object, object>>.Clone
	|
	|-RVA: 0x39C5B50 Offset: 0x39C5C51 VA: 0x39C5B50
	|-Enumerable.WhereArrayIterator<object>.Clone
	|
	|-RVA: 0x39C5D80 Offset: 0x39C5E81 VA: 0x39C5D80
	|-Enumerable.WhereArrayIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.Clone
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39C5990 Offset: 0x39C5A91 VA: 0x39C5990
	|-Enumerable.WhereArrayIterator<KeyValuePair<object, object>>.MoveNext
	|
	|-RVA: 0x39C5BC0 Offset: 0x39C5CC1 VA: 0x39C5BC0
	|-Enumerable.WhereArrayIterator<object>.MoveNext
	|
	|-RVA: 0x39C5DF0 Offset: 0x39C5EF1 VA: 0x39C5DF0
	|-Enumerable.WhereArrayIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override IEnumerable<TResult> Select<TResult>(Func<TSource, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2556C90 Offset: 0x2556D91 VA: 0x2556C90
	|-Enumerable.WhereArrayIterator<KeyValuePair<object, object>>.Select<object>
	|
	|-RVA: 0x2556D10 Offset: 0x2556E11 VA: 0x2556D10
	|-Enumerable.WhereArrayIterator<object>.Select<KeyValuePair<int, object>>
	|
	|-RVA: 0x2556D90 Offset: 0x2556E91 VA: 0x2556D90
	|-Enumerable.WhereArrayIterator<object>.Select<UniTask<object>>
	|
	|-RVA: 0x2556E10 Offset: 0x2556F11 VA: 0x2556E10
	|-Enumerable.WhereArrayIterator<object>.Select<int>
	|
	|-RVA: 0x2556E90 Offset: 0x2556F91 VA: 0x2556E90
	|-Enumerable.WhereArrayIterator<object>.Select<object>
	|
	|-RVA: 0x2556F10 Offset: 0x2557011 VA: 0x2556F10
	|-Enumerable.WhereArrayIterator<object>.Select<UniTask>
	|
	|-RVA: 0x2556F90 Offset: 0x2557091 VA: 0x2556F90
	|-Enumerable.WhereArrayIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.Select<object>
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public override IEnumerable<TSource> Where(Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39C5A60 Offset: 0x39C5B61 VA: 0x39C5A60
	|-Enumerable.WhereArrayIterator<KeyValuePair<object, object>>.Where
	|
	|-RVA: 0x39C5C90 Offset: 0x39C5D91 VA: 0x39C5C90
	|-Enumerable.WhereArrayIterator<object>.Where
	|
	|-RVA: 0x39C5EC0 Offset: 0x39C5FC1 VA: 0x39C5EC0
	|-Enumerable.WhereArrayIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.Where
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
private class Enumerable.WhereSelectEnumerableIterator<TSource, TResult> : Enumerable.Iterator<TResult> // TypeDefIndex: 2727
{
	// Fields
	private IEnumerable<TSource> source; // 0x0
	private Func<TSource, bool> predicate; // 0x0
	private Func<TSource, TResult> selector; // 0x0
	private IEnumerator<TSource> enumerator; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<TSource> source, Func<TSource, bool> predicate, Func<TSource, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39CF970 Offset: 0x39CFA71 VA: 0x39CF970
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x39CFE30 Offset: 0x39CFF31 VA: 0x39CFE30
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, UniTask<object>>..ctor
	|
	|-RVA: 0x39D02F0 Offset: 0x39D03F1 VA: 0x39D02F0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, int>..ctor
	|
	|-RVA: 0x39D07A0 Offset: 0x39D08A1 VA: 0x39D07A0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>..ctor
	|
	|-RVA: 0x39D0C60 Offset: 0x39D0D61 VA: 0x39D0C60
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, UniTask>..ctor
	|
	|-RVA: 0x39D1120 Offset: 0x39D1221 VA: 0x39D1120
	|-Enumerable.WhereSelectEnumerableIterator<ContourVertex, Color>..ctor
	|
	|-RVA: 0x39D1610 Offset: 0x39D1711 VA: 0x39D1610
	|-Enumerable.WhereSelectEnumerableIterator<ContourVertex, Vector3>..ctor
	|
	|-RVA: 0x39D1B00 Offset: 0x39D1C01 VA: 0x39D1B00
	|-Enumerable.WhereSelectEnumerableIterator<ContourVertex, float3>..ctor
	|
	|-RVA: 0x39D1FF0 Offset: 0x39D20F1 VA: 0x39D1FF0
	|-Enumerable.WhereSelectEnumerableIterator<int, KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x39D24A0 Offset: 0x39D25A1 VA: 0x39D24A0
	|-Enumerable.WhereSelectEnumerableIterator<int, UniTask<object>>..ctor
	|
	|-RVA: 0x39D2950 Offset: 0x39D2A51 VA: 0x39D2950
	|-Enumerable.WhereSelectEnumerableIterator<int, int>..ctor
	|
	|-RVA: 0x39D2DF0 Offset: 0x39D2EF1 VA: 0x39D2DF0
	|-Enumerable.WhereSelectEnumerableIterator<int, object>..ctor
	|
	|-RVA: 0x39D32A0 Offset: 0x39D33A1 VA: 0x39D32A0
	|-Enumerable.WhereSelectEnumerableIterator<int, UniTask>..ctor
	|
	|-RVA: 0x39D3750 Offset: 0x39D3851 VA: 0x39D3750
	|-Enumerable.WhereSelectEnumerableIterator<object, KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x39D3C00 Offset: 0x39D3D01 VA: 0x39D3C00
	|-Enumerable.WhereSelectEnumerableIterator<object, UniTask<object>>..ctor
	|
	|-RVA: 0x39D40B0 Offset: 0x39D41B1 VA: 0x39D40B0
	|-Enumerable.WhereSelectEnumerableIterator<object, int>..ctor
	|
	|-RVA: 0x39D4550 Offset: 0x39D4651 VA: 0x39D4550
	|-Enumerable.WhereSelectEnumerableIterator<object, object>..ctor
	|
	|-RVA: 0x39D4A00 Offset: 0x39D4B01 VA: 0x39D4A00
	|-Enumerable.WhereSelectEnumerableIterator<object, UniTask>..ctor
	|
	|-RVA: 0x39D4EB0 Offset: 0x39D4FB1 VA: 0x39D4EB0
	|-Enumerable.WhereSelectEnumerableIterator<TablePair, KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x39D5370 Offset: 0x39D5471 VA: 0x39D5370
	|-Enumerable.WhereSelectEnumerableIterator<TablePair, UniTask<object>>..ctor
	|
	|-RVA: 0x39D5830 Offset: 0x39D5931 VA: 0x39D5830
	|-Enumerable.WhereSelectEnumerableIterator<TablePair, int>..ctor
	|
	|-RVA: 0x39D5CE0 Offset: 0x39D5DE1 VA: 0x39D5CE0
	|-Enumerable.WhereSelectEnumerableIterator<TablePair, object>..ctor
	|
	|-RVA: 0x39D61A0 Offset: 0x39D62A1 VA: 0x39D61A0
	|-Enumerable.WhereSelectEnumerableIterator<TablePair, TablePair>..ctor
	|
	|-RVA: 0x39D6660 Offset: 0x39D6761 VA: 0x39D6660
	|-Enumerable.WhereSelectEnumerableIterator<TablePair, UniTask>..ctor
	|
	|-RVA: 0x39D6B20 Offset: 0x39D6C21 VA: 0x39D6B20
	|-Enumerable.WhereSelectEnumerableIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x39D6FE0 Offset: 0x39D70E1 VA: 0x39D6FE0
	|-Enumerable.WhereSelectEnumerableIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, UniTask<object>>..ctor
	|
	|-RVA: 0x39D74A0 Offset: 0x39D75A1 VA: 0x39D74A0
	|-Enumerable.WhereSelectEnumerableIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, int>..ctor
	|
	|-RVA: 0x39D7950 Offset: 0x39D7A51 VA: 0x39D7950
	|-Enumerable.WhereSelectEnumerableIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, object>..ctor
	|
	|-RVA: 0x39D7E10 Offset: 0x39D7F11 VA: 0x39D7E10
	|-Enumerable.WhereSelectEnumerableIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, UniTask>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public override Enumerable.Iterator<TResult> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39CF9E0 Offset: 0x39CFAE1 VA: 0x39CF9E0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, KeyValuePair<int, object>>.Clone
	|
	|-RVA: 0x39CFEA0 Offset: 0x39CFFA1 VA: 0x39CFEA0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, UniTask<object>>.Clone
	|
	|-RVA: 0x39D0360 Offset: 0x39D0461 VA: 0x39D0360
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, int>.Clone
	|
	|-RVA: 0x39D0810 Offset: 0x39D0911 VA: 0x39D0810
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Clone
	|
	|-RVA: 0x39D0CD0 Offset: 0x39D0DD1 VA: 0x39D0CD0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, UniTask>.Clone
	|
	|-RVA: 0x39D1190 Offset: 0x39D1291 VA: 0x39D1190
	|-Enumerable.WhereSelectEnumerableIterator<ContourVertex, Color>.Clone
	|
	|-RVA: 0x39D1680 Offset: 0x39D1781 VA: 0x39D1680
	|-Enumerable.WhereSelectEnumerableIterator<ContourVertex, Vector3>.Clone
	|
	|-RVA: 0x39D1B70 Offset: 0x39D1C71 VA: 0x39D1B70
	|-Enumerable.WhereSelectEnumerableIterator<ContourVertex, float3>.Clone
	|
	|-RVA: 0x39D2060 Offset: 0x39D2161 VA: 0x39D2060
	|-Enumerable.WhereSelectEnumerableIterator<int, KeyValuePair<int, object>>.Clone
	|
	|-RVA: 0x39D2510 Offset: 0x39D2611 VA: 0x39D2510
	|-Enumerable.WhereSelectEnumerableIterator<int, UniTask<object>>.Clone
	|
	|-RVA: 0x39D29C0 Offset: 0x39D2AC1 VA: 0x39D29C0
	|-Enumerable.WhereSelectEnumerableIterator<int, int>.Clone
	|
	|-RVA: 0x39D2E60 Offset: 0x39D2F61 VA: 0x39D2E60
	|-Enumerable.WhereSelectEnumerableIterator<int, object>.Clone
	|
	|-RVA: 0x39D3310 Offset: 0x39D3411 VA: 0x39D3310
	|-Enumerable.WhereSelectEnumerableIterator<int, UniTask>.Clone
	|
	|-RVA: 0x39D37C0 Offset: 0x39D38C1 VA: 0x39D37C0
	|-Enumerable.WhereSelectEnumerableIterator<object, KeyValuePair<int, object>>.Clone
	|
	|-RVA: 0x39D3C70 Offset: 0x39D3D71 VA: 0x39D3C70
	|-Enumerable.WhereSelectEnumerableIterator<object, UniTask<object>>.Clone
	|
	|-RVA: 0x39D4120 Offset: 0x39D4221 VA: 0x39D4120
	|-Enumerable.WhereSelectEnumerableIterator<object, int>.Clone
	|
	|-RVA: 0x39D45C0 Offset: 0x39D46C1 VA: 0x39D45C0
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Clone
	|
	|-RVA: 0x39D4A70 Offset: 0x39D4B71 VA: 0x39D4A70
	|-Enumerable.WhereSelectEnumerableIterator<object, UniTask>.Clone
	|
	|-RVA: 0x39D4F20 Offset: 0x39D5021 VA: 0x39D4F20
	|-Enumerable.WhereSelectEnumerableIterator<TablePair, KeyValuePair<int, object>>.Clone
	|
	|-RVA: 0x39D53E0 Offset: 0x39D54E1 VA: 0x39D53E0
	|-Enumerable.WhereSelectEnumerableIterator<TablePair, UniTask<object>>.Clone
	|
	|-RVA: 0x39D58A0 Offset: 0x39D59A1 VA: 0x39D58A0
	|-Enumerable.WhereSelectEnumerableIterator<TablePair, int>.Clone
	|
	|-RVA: 0x39D5D50 Offset: 0x39D5E51 VA: 0x39D5D50
	|-Enumerable.WhereSelectEnumerableIterator<TablePair, object>.Clone
	|
	|-RVA: 0x39D6210 Offset: 0x39D6311 VA: 0x39D6210
	|-Enumerable.WhereSelectEnumerableIterator<TablePair, TablePair>.Clone
	|
	|-RVA: 0x39D66D0 Offset: 0x39D67D1 VA: 0x39D66D0
	|-Enumerable.WhereSelectEnumerableIterator<TablePair, UniTask>.Clone
	|
	|-RVA: 0x39D6B90 Offset: 0x39D6C91 VA: 0x39D6B90
	|-Enumerable.WhereSelectEnumerableIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, KeyValuePair<int, object>>.Clone
	|
	|-RVA: 0x39D7050 Offset: 0x39D7151 VA: 0x39D7050
	|-Enumerable.WhereSelectEnumerableIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, UniTask<object>>.Clone
	|
	|-RVA: 0x39D7510 Offset: 0x39D7611 VA: 0x39D7510
	|-Enumerable.WhereSelectEnumerableIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, int>.Clone
	|
	|-RVA: 0x39D79C0 Offset: 0x39D7AC1 VA: 0x39D79C0
	|-Enumerable.WhereSelectEnumerableIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, object>.Clone
	|
	|-RVA: 0x39D7E80 Offset: 0x39D7F81 VA: 0x39D7E80
	|-Enumerable.WhereSelectEnumerableIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, UniTask>.Clone
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public override void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39CFA60 Offset: 0x39CFB61 VA: 0x39CFA60
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, KeyValuePair<int, object>>.Dispose
	|
	|-RVA: 0x39CFF20 Offset: 0x39D0021 VA: 0x39CFF20
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, UniTask<object>>.Dispose
	|
	|-RVA: 0x39D03E0 Offset: 0x39D04E1 VA: 0x39D03E0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, int>.Dispose
	|
	|-RVA: 0x39D0890 Offset: 0x39D0991 VA: 0x39D0890
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Dispose
	|
	|-RVA: 0x39D0D50 Offset: 0x39D0E51 VA: 0x39D0D50
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, UniTask>.Dispose
	|
	|-RVA: 0x39D1210 Offset: 0x39D1311 VA: 0x39D1210
	|-Enumerable.WhereSelectEnumerableIterator<ContourVertex, Color>.Dispose
	|
	|-RVA: 0x39D1700 Offset: 0x39D1801 VA: 0x39D1700
	|-Enumerable.WhereSelectEnumerableIterator<ContourVertex, Vector3>.Dispose
	|
	|-RVA: 0x39D1BF0 Offset: 0x39D1CF1 VA: 0x39D1BF0
	|-Enumerable.WhereSelectEnumerableIterator<ContourVertex, float3>.Dispose
	|
	|-RVA: 0x39D20E0 Offset: 0x39D21E1 VA: 0x39D20E0
	|-Enumerable.WhereSelectEnumerableIterator<int, KeyValuePair<int, object>>.Dispose
	|
	|-RVA: 0x39D2590 Offset: 0x39D2691 VA: 0x39D2590
	|-Enumerable.WhereSelectEnumerableIterator<int, UniTask<object>>.Dispose
	|
	|-RVA: 0x39D2A40 Offset: 0x39D2B41 VA: 0x39D2A40
	|-Enumerable.WhereSelectEnumerableIterator<int, int>.Dispose
	|
	|-RVA: 0x39D2EE0 Offset: 0x39D2FE1 VA: 0x39D2EE0
	|-Enumerable.WhereSelectEnumerableIterator<int, object>.Dispose
	|
	|-RVA: 0x39D3390 Offset: 0x39D3491 VA: 0x39D3390
	|-Enumerable.WhereSelectEnumerableIterator<int, UniTask>.Dispose
	|
	|-RVA: 0x39D3840 Offset: 0x39D3941 VA: 0x39D3840
	|-Enumerable.WhereSelectEnumerableIterator<object, KeyValuePair<int, object>>.Dispose
	|
	|-RVA: 0x39D3CF0 Offset: 0x39D3DF1 VA: 0x39D3CF0
	|-Enumerable.WhereSelectEnumerableIterator<object, UniTask<object>>.Dispose
	|
	|-RVA: 0x39D41A0 Offset: 0x39D42A1 VA: 0x39D41A0
	|-Enumerable.WhereSelectEnumerableIterator<object, int>.Dispose
	|
	|-RVA: 0x39D4640 Offset: 0x39D4741 VA: 0x39D4640
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Dispose
	|
	|-RVA: 0x39D4AF0 Offset: 0x39D4BF1 VA: 0x39D4AF0
	|-Enumerable.WhereSelectEnumerableIterator<object, UniTask>.Dispose
	|
	|-RVA: 0x39D4FA0 Offset: 0x39D50A1 VA: 0x39D4FA0
	|-Enumerable.WhereSelectEnumerableIterator<TablePair, KeyValuePair<int, object>>.Dispose
	|
	|-RVA: 0x39D5460 Offset: 0x39D5561 VA: 0x39D5460
	|-Enumerable.WhereSelectEnumerableIterator<TablePair, UniTask<object>>.Dispose
	|
	|-RVA: 0x39D5920 Offset: 0x39D5A21 VA: 0x39D5920
	|-Enumerable.WhereSelectEnumerableIterator<TablePair, int>.Dispose
	|
	|-RVA: 0x39D5DD0 Offset: 0x39D5ED1 VA: 0x39D5DD0
	|-Enumerable.WhereSelectEnumerableIterator<TablePair, object>.Dispose
	|
	|-RVA: 0x39D6290 Offset: 0x39D6391 VA: 0x39D6290
	|-Enumerable.WhereSelectEnumerableIterator<TablePair, TablePair>.Dispose
	|
	|-RVA: 0x39D6750 Offset: 0x39D6851 VA: 0x39D6750
	|-Enumerable.WhereSelectEnumerableIterator<TablePair, UniTask>.Dispose
	|
	|-RVA: 0x39D6C10 Offset: 0x39D6D11 VA: 0x39D6C10
	|-Enumerable.WhereSelectEnumerableIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, KeyValuePair<int, object>>.Dispose
	|
	|-RVA: 0x39D70D0 Offset: 0x39D71D1 VA: 0x39D70D0
	|-Enumerable.WhereSelectEnumerableIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, UniTask<object>>.Dispose
	|
	|-RVA: 0x39D7590 Offset: 0x39D7691 VA: 0x39D7590
	|-Enumerable.WhereSelectEnumerableIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, int>.Dispose
	|
	|-RVA: 0x39D7A40 Offset: 0x39D7B41 VA: 0x39D7A40
	|-Enumerable.WhereSelectEnumerableIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, object>.Dispose
	|
	|-RVA: 0x39D7F00 Offset: 0x39D8001 VA: 0x39D7F00
	|-Enumerable.WhereSelectEnumerableIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, UniTask>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39CFB40 Offset: 0x39CFC41 VA: 0x39CFB40
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, KeyValuePair<int, object>>.MoveNext
	|
	|-RVA: 0x39D0000 Offset: 0x39D0101 VA: 0x39D0000
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, UniTask<object>>.MoveNext
	|
	|-RVA: 0x39D04C0 Offset: 0x39D05C1 VA: 0x39D04C0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, int>.MoveNext
	|
	|-RVA: 0x39D0970 Offset: 0x39D0A71 VA: 0x39D0970
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.MoveNext
	|
	|-RVA: 0x39D0E30 Offset: 0x39D0F31 VA: 0x39D0E30
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, UniTask>.MoveNext
	|
	|-RVA: 0x39D12F0 Offset: 0x39D13F1 VA: 0x39D12F0
	|-Enumerable.WhereSelectEnumerableIterator<ContourVertex, Color>.MoveNext
	|
	|-RVA: 0x39D17E0 Offset: 0x39D18E1 VA: 0x39D17E0
	|-Enumerable.WhereSelectEnumerableIterator<ContourVertex, Vector3>.MoveNext
	|
	|-RVA: 0x39D1CD0 Offset: 0x39D1DD1 VA: 0x39D1CD0
	|-Enumerable.WhereSelectEnumerableIterator<ContourVertex, float3>.MoveNext
	|
	|-RVA: 0x39D21C0 Offset: 0x39D22C1 VA: 0x39D21C0
	|-Enumerable.WhereSelectEnumerableIterator<int, KeyValuePair<int, object>>.MoveNext
	|
	|-RVA: 0x39D2670 Offset: 0x39D2771 VA: 0x39D2670
	|-Enumerable.WhereSelectEnumerableIterator<int, UniTask<object>>.MoveNext
	|
	|-RVA: 0x39D2B20 Offset: 0x39D2C21 VA: 0x39D2B20
	|-Enumerable.WhereSelectEnumerableIterator<int, int>.MoveNext
	|
	|-RVA: 0x39D2FC0 Offset: 0x39D30C1 VA: 0x39D2FC0
	|-Enumerable.WhereSelectEnumerableIterator<int, object>.MoveNext
	|
	|-RVA: 0x39D3470 Offset: 0x39D3571 VA: 0x39D3470
	|-Enumerable.WhereSelectEnumerableIterator<int, UniTask>.MoveNext
	|
	|-RVA: 0x39D3920 Offset: 0x39D3A21 VA: 0x39D3920
	|-Enumerable.WhereSelectEnumerableIterator<object, KeyValuePair<int, object>>.MoveNext
	|
	|-RVA: 0x39D3DD0 Offset: 0x39D3ED1 VA: 0x39D3DD0
	|-Enumerable.WhereSelectEnumerableIterator<object, UniTask<object>>.MoveNext
	|
	|-RVA: 0x39D4280 Offset: 0x39D4381 VA: 0x39D4280
	|-Enumerable.WhereSelectEnumerableIterator<object, int>.MoveNext
	|
	|-RVA: 0x39D4720 Offset: 0x39D4821 VA: 0x39D4720
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.MoveNext
	|
	|-RVA: 0x39D4BD0 Offset: 0x39D4CD1 VA: 0x39D4BD0
	|-Enumerable.WhereSelectEnumerableIterator<object, UniTask>.MoveNext
	|
	|-RVA: 0x39D5080 Offset: 0x39D5181 VA: 0x39D5080
	|-Enumerable.WhereSelectEnumerableIterator<TablePair, KeyValuePair<int, object>>.MoveNext
	|
	|-RVA: 0x39D5540 Offset: 0x39D5641 VA: 0x39D5540
	|-Enumerable.WhereSelectEnumerableIterator<TablePair, UniTask<object>>.MoveNext
	|
	|-RVA: 0x39D5A00 Offset: 0x39D5B01 VA: 0x39D5A00
	|-Enumerable.WhereSelectEnumerableIterator<TablePair, int>.MoveNext
	|
	|-RVA: 0x39D5EB0 Offset: 0x39D5FB1 VA: 0x39D5EB0
	|-Enumerable.WhereSelectEnumerableIterator<TablePair, object>.MoveNext
	|
	|-RVA: 0x39D6370 Offset: 0x39D6471 VA: 0x39D6370
	|-Enumerable.WhereSelectEnumerableIterator<TablePair, TablePair>.MoveNext
	|
	|-RVA: 0x39D6830 Offset: 0x39D6931 VA: 0x39D6830
	|-Enumerable.WhereSelectEnumerableIterator<TablePair, UniTask>.MoveNext
	|
	|-RVA: 0x39D6CF0 Offset: 0x39D6DF1 VA: 0x39D6CF0
	|-Enumerable.WhereSelectEnumerableIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, KeyValuePair<int, object>>.MoveNext
	|
	|-RVA: 0x39D71B0 Offset: 0x39D72B1 VA: 0x39D71B0
	|-Enumerable.WhereSelectEnumerableIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, UniTask<object>>.MoveNext
	|
	|-RVA: 0x39D7670 Offset: 0x39D7771 VA: 0x39D7670
	|-Enumerable.WhereSelectEnumerableIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, int>.MoveNext
	|
	|-RVA: 0x39D7B20 Offset: 0x39D7C21 VA: 0x39D7B20
	|-Enumerable.WhereSelectEnumerableIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, object>.MoveNext
	|
	|-RVA: 0x39D7FE0 Offset: 0x39D80E1 VA: 0x39D7FE0
	|-Enumerable.WhereSelectEnumerableIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, UniTask>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2558C20 Offset: 0x2558D21 VA: 0x2558C20
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Select<KeyValuePair<int, object>>
	|
	|-RVA: 0x2558CB0 Offset: 0x2558DB1 VA: 0x2558CB0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Select<UniTask<object>>
	|
	|-RVA: 0x2558D40 Offset: 0x2558E41 VA: 0x2558D40
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Select<int>
	|
	|-RVA: 0x2558DD0 Offset: 0x2558ED1 VA: 0x2558DD0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Select<object>
	|
	|-RVA: 0x2558E60 Offset: 0x2558F61 VA: 0x2558E60
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Select<UniTask>
	|
	|-RVA: 0x2558EF0 Offset: 0x2558FF1 VA: 0x2558EF0
	|-Enumerable.WhereSelectEnumerableIterator<int, int>.Select<int>
	|
	|-RVA: 0x2558F80 Offset: 0x2559081 VA: 0x2558F80
	|-Enumerable.WhereSelectEnumerableIterator<int, int>.Select<object>
	|
	|-RVA: 0x2559010 Offset: 0x2559111 VA: 0x2559010
	|-Enumerable.WhereSelectEnumerableIterator<int, object>.Select<KeyValuePair<int, object>>
	|
	|-RVA: 0x25590A0 Offset: 0x25591A1 VA: 0x25590A0
	|-Enumerable.WhereSelectEnumerableIterator<int, object>.Select<UniTask<object>>
	|
	|-RVA: 0x2559130 Offset: 0x2559231 VA: 0x2559130
	|-Enumerable.WhereSelectEnumerableIterator<int, object>.Select<int>
	|
	|-RVA: 0x25591C0 Offset: 0x25592C1 VA: 0x25591C0
	|-Enumerable.WhereSelectEnumerableIterator<int, object>.Select<object>
	|
	|-RVA: 0x2559250 Offset: 0x2559351 VA: 0x2559250
	|-Enumerable.WhereSelectEnumerableIterator<int, object>.Select<UniTask>
	|
	|-RVA: 0x25592E0 Offset: 0x25593E1 VA: 0x25592E0
	|-Enumerable.WhereSelectEnumerableIterator<object, int>.Select<int>
	|
	|-RVA: 0x2559370 Offset: 0x2559471 VA: 0x2559370
	|-Enumerable.WhereSelectEnumerableIterator<object, int>.Select<object>
	|
	|-RVA: 0x2559400 Offset: 0x2559501 VA: 0x2559400
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Select<KeyValuePair<int, object>>
	|
	|-RVA: 0x2559490 Offset: 0x2559591 VA: 0x2559490
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Select<UniTask<object>>
	|
	|-RVA: 0x2559520 Offset: 0x2559621 VA: 0x2559520
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Select<int>
	|
	|-RVA: 0x25595B0 Offset: 0x25596B1 VA: 0x25595B0
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Select<object>
	|
	|-RVA: 0x2559640 Offset: 0x2559741 VA: 0x2559640
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Select<UniTask>
	|
	|-RVA: 0x25596D0 Offset: 0x25597D1 VA: 0x25596D0
	|-Enumerable.WhereSelectEnumerableIterator<TablePair, object>.Select<KeyValuePair<int, object>>
	|
	|-RVA: 0x2559760 Offset: 0x2559861 VA: 0x2559760
	|-Enumerable.WhereSelectEnumerableIterator<TablePair, object>.Select<UniTask<object>>
	|
	|-RVA: 0x25597F0 Offset: 0x25598F1 VA: 0x25597F0
	|-Enumerable.WhereSelectEnumerableIterator<TablePair, object>.Select<int>
	|
	|-RVA: 0x2559880 Offset: 0x2559981 VA: 0x2559880
	|-Enumerable.WhereSelectEnumerableIterator<TablePair, object>.Select<object>
	|
	|-RVA: 0x2559910 Offset: 0x2559A11 VA: 0x2559910
	|-Enumerable.WhereSelectEnumerableIterator<TablePair, object>.Select<UniTask>
	|
	|-RVA: 0x25599A0 Offset: 0x2559AA1 VA: 0x25599A0
	|-Enumerable.WhereSelectEnumerableIterator<TablePair, TablePair>.Select<object>
	|
	|-RVA: 0x2559A30 Offset: 0x2559B31 VA: 0x2559A30
	|-Enumerable.WhereSelectEnumerableIterator<TablePair, TablePair>.Select<TablePair>
	|
	|-RVA: 0x2559AC0 Offset: 0x2559BC1 VA: 0x2559AC0
	|-Enumerable.WhereSelectEnumerableIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, object>.Select<KeyValuePair<int, object>>
	|
	|-RVA: 0x2559B50 Offset: 0x2559C51 VA: 0x2559B50
	|-Enumerable.WhereSelectEnumerableIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, object>.Select<UniTask<object>>
	|
	|-RVA: 0x2559BE0 Offset: 0x2559CE1 VA: 0x2559BE0
	|-Enumerable.WhereSelectEnumerableIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, object>.Select<int>
	|
	|-RVA: 0x2559C70 Offset: 0x2559D71 VA: 0x2559C70
	|-Enumerable.WhereSelectEnumerableIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, object>.Select<object>
	|
	|-RVA: 0x2559D00 Offset: 0x2559E01 VA: 0x2559D00
	|-Enumerable.WhereSelectEnumerableIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, object>.Select<UniTask>
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public override IEnumerable<TResult> Where(Func<TResult, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39CFDB0 Offset: 0x39CFEB1 VA: 0x39CFDB0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, KeyValuePair<int, object>>.Where
	|
	|-RVA: 0x39D0270 Offset: 0x39D0371 VA: 0x39D0270
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, UniTask<object>>.Where
	|
	|-RVA: 0x39D0720 Offset: 0x39D0821 VA: 0x39D0720
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, int>.Where
	|
	|-RVA: 0x39D0BE0 Offset: 0x39D0CE1 VA: 0x39D0BE0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, object>.Where
	|
	|-RVA: 0x39D10A0 Offset: 0x39D11A1 VA: 0x39D10A0
	|-Enumerable.WhereSelectEnumerableIterator<KeyValuePair<object, object>, UniTask>.Where
	|
	|-RVA: 0x39D1590 Offset: 0x39D1691 VA: 0x39D1590
	|-Enumerable.WhereSelectEnumerableIterator<ContourVertex, Color>.Where
	|
	|-RVA: 0x39D1A80 Offset: 0x39D1B81 VA: 0x39D1A80
	|-Enumerable.WhereSelectEnumerableIterator<ContourVertex, Vector3>.Where
	|
	|-RVA: 0x39D1F70 Offset: 0x39D2071 VA: 0x39D1F70
	|-Enumerable.WhereSelectEnumerableIterator<ContourVertex, float3>.Where
	|
	|-RVA: 0x39D2420 Offset: 0x39D2521 VA: 0x39D2420
	|-Enumerable.WhereSelectEnumerableIterator<int, KeyValuePair<int, object>>.Where
	|
	|-RVA: 0x39D28D0 Offset: 0x39D29D1 VA: 0x39D28D0
	|-Enumerable.WhereSelectEnumerableIterator<int, UniTask<object>>.Where
	|
	|-RVA: 0x39D2D70 Offset: 0x39D2E71 VA: 0x39D2D70
	|-Enumerable.WhereSelectEnumerableIterator<int, int>.Where
	|
	|-RVA: 0x39D3220 Offset: 0x39D3321 VA: 0x39D3220
	|-Enumerable.WhereSelectEnumerableIterator<int, object>.Where
	|
	|-RVA: 0x39D36D0 Offset: 0x39D37D1 VA: 0x39D36D0
	|-Enumerable.WhereSelectEnumerableIterator<int, UniTask>.Where
	|
	|-RVA: 0x39D3B80 Offset: 0x39D3C81 VA: 0x39D3B80
	|-Enumerable.WhereSelectEnumerableIterator<object, KeyValuePair<int, object>>.Where
	|
	|-RVA: 0x39D4030 Offset: 0x39D4131 VA: 0x39D4030
	|-Enumerable.WhereSelectEnumerableIterator<object, UniTask<object>>.Where
	|
	|-RVA: 0x39D44D0 Offset: 0x39D45D1 VA: 0x39D44D0
	|-Enumerable.WhereSelectEnumerableIterator<object, int>.Where
	|
	|-RVA: 0x39D4980 Offset: 0x39D4A81 VA: 0x39D4980
	|-Enumerable.WhereSelectEnumerableIterator<object, object>.Where
	|
	|-RVA: 0x39D4E30 Offset: 0x39D4F31 VA: 0x39D4E30
	|-Enumerable.WhereSelectEnumerableIterator<object, UniTask>.Where
	|
	|-RVA: 0x39D52F0 Offset: 0x39D53F1 VA: 0x39D52F0
	|-Enumerable.WhereSelectEnumerableIterator<TablePair, KeyValuePair<int, object>>.Where
	|
	|-RVA: 0x39D57B0 Offset: 0x39D58B1 VA: 0x39D57B0
	|-Enumerable.WhereSelectEnumerableIterator<TablePair, UniTask<object>>.Where
	|
	|-RVA: 0x39D5C60 Offset: 0x39D5D61 VA: 0x39D5C60
	|-Enumerable.WhereSelectEnumerableIterator<TablePair, int>.Where
	|
	|-RVA: 0x39D6120 Offset: 0x39D6221 VA: 0x39D6120
	|-Enumerable.WhereSelectEnumerableIterator<TablePair, object>.Where
	|
	|-RVA: 0x39D65E0 Offset: 0x39D66E1 VA: 0x39D65E0
	|-Enumerable.WhereSelectEnumerableIterator<TablePair, TablePair>.Where
	|
	|-RVA: 0x39D6AA0 Offset: 0x39D6BA1 VA: 0x39D6AA0
	|-Enumerable.WhereSelectEnumerableIterator<TablePair, UniTask>.Where
	|
	|-RVA: 0x39D6F60 Offset: 0x39D7061 VA: 0x39D6F60
	|-Enumerable.WhereSelectEnumerableIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, KeyValuePair<int, object>>.Where
	|
	|-RVA: 0x39D7420 Offset: 0x39D7521 VA: 0x39D7420
	|-Enumerable.WhereSelectEnumerableIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, UniTask<object>>.Where
	|
	|-RVA: 0x39D78D0 Offset: 0x39D79D1 VA: 0x39D78D0
	|-Enumerable.WhereSelectEnumerableIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, int>.Where
	|
	|-RVA: 0x39D7D90 Offset: 0x39D7E91 VA: 0x39D7D90
	|-Enumerable.WhereSelectEnumerableIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, object>.Where
	|
	|-RVA: 0x39D8250 Offset: 0x39D8351 VA: 0x39D8250
	|-Enumerable.WhereSelectEnumerableIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, UniTask>.Where
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
private class Enumerable.WhereSelectListIterator<TSource, TResult> : Enumerable.Iterator<TResult> // TypeDefIndex: 2729
{
	// Fields
	private List<TSource> source; // 0x0
	private Func<TSource, bool> predicate; // 0x0
	private Func<TSource, TResult> selector; // 0x0
	private List.Enumerator<TSource> enumerator; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(List<TSource> source, Func<TSource, bool> predicate, Func<TSource, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39D82D0 Offset: 0x39D83D1 VA: 0x39D82D0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x39D8580 Offset: 0x39D8681 VA: 0x39D8580
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, UniTask<object>>..ctor
	|
	|-RVA: 0x39D8830 Offset: 0x39D8931 VA: 0x39D8830
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, int>..ctor
	|
	|-RVA: 0x39D8AD0 Offset: 0x39D8BD1 VA: 0x39D8AD0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>..ctor
	|
	|-RVA: 0x39D8D70 Offset: 0x39D8E71 VA: 0x39D8D70
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, UniTask>..ctor
	|
	|-RVA: 0x39D9010 Offset: 0x39D9111 VA: 0x39D9010
	|-Enumerable.WhereSelectListIterator<ContourVertex, Color>..ctor
	|
	|-RVA: 0x39D92E0 Offset: 0x39D93E1 VA: 0x39D92E0
	|-Enumerable.WhereSelectListIterator<ContourVertex, Vector3>..ctor
	|
	|-RVA: 0x39D95B0 Offset: 0x39D96B1 VA: 0x39D95B0
	|-Enumerable.WhereSelectListIterator<ContourVertex, float3>..ctor
	|
	|-RVA: 0x39D9880 Offset: 0x39D9981 VA: 0x39D9880
	|-Enumerable.WhereSelectListIterator<int, KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x39D9B10 Offset: 0x39D9C11 VA: 0x39D9B10
	|-Enumerable.WhereSelectListIterator<int, UniTask<object>>..ctor
	|
	|-RVA: 0x39D9DA0 Offset: 0x39D9EA1 VA: 0x39D9DA0
	|-Enumerable.WhereSelectListIterator<int, int>..ctor
	|
	|-RVA: 0x39DA020 Offset: 0x39DA121 VA: 0x39DA020
	|-Enumerable.WhereSelectListIterator<int, object>..ctor
	|
	|-RVA: 0x39DA2B0 Offset: 0x39DA3B1 VA: 0x39DA2B0
	|-Enumerable.WhereSelectListIterator<int, UniTask>..ctor
	|
	|-RVA: 0x39DA540 Offset: 0x39DA641 VA: 0x39DA540
	|-Enumerable.WhereSelectListIterator<object, KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x39DA7D0 Offset: 0x39DA8D1 VA: 0x39DA7D0
	|-Enumerable.WhereSelectListIterator<object, UniTask<object>>..ctor
	|
	|-RVA: 0x39DAA60 Offset: 0x39DAB61 VA: 0x39DAA60
	|-Enumerable.WhereSelectListIterator<object, int>..ctor
	|
	|-RVA: 0x39DACE0 Offset: 0x39DADE1 VA: 0x39DACE0
	|-Enumerable.WhereSelectListIterator<object, object>..ctor
	|
	|-RVA: 0x39DAF70 Offset: 0x39DB071 VA: 0x39DAF70
	|-Enumerable.WhereSelectListIterator<object, UniTask>..ctor
	|
	|-RVA: 0x39DB200 Offset: 0x39DB301 VA: 0x39DB200
	|-Enumerable.WhereSelectListIterator<TablePair, KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x39DB4B0 Offset: 0x39DB5B1 VA: 0x39DB4B0
	|-Enumerable.WhereSelectListIterator<TablePair, UniTask<object>>..ctor
	|
	|-RVA: 0x39DB760 Offset: 0x39DB861 VA: 0x39DB760
	|-Enumerable.WhereSelectListIterator<TablePair, int>..ctor
	|
	|-RVA: 0x39DBA00 Offset: 0x39DBB01 VA: 0x39DBA00
	|-Enumerable.WhereSelectListIterator<TablePair, object>..ctor
	|
	|-RVA: 0x39DBCA0 Offset: 0x39DBDA1 VA: 0x39DBCA0
	|-Enumerable.WhereSelectListIterator<TablePair, TablePair>..ctor
	|
	|-RVA: 0x39DBF50 Offset: 0x39DC051 VA: 0x39DBF50
	|-Enumerable.WhereSelectListIterator<TablePair, UniTask>..ctor
	|
	|-RVA: 0x39DC1F0 Offset: 0x39DC2F1 VA: 0x39DC1F0
	|-Enumerable.WhereSelectListIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x39DC4A0 Offset: 0x39DC5A1 VA: 0x39DC4A0
	|-Enumerable.WhereSelectListIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, UniTask<object>>..ctor
	|
	|-RVA: 0x39DC750 Offset: 0x39DC851 VA: 0x39DC750
	|-Enumerable.WhereSelectListIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, int>..ctor
	|
	|-RVA: 0x39DC9F0 Offset: 0x39DCAF1 VA: 0x39DC9F0
	|-Enumerable.WhereSelectListIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, object>..ctor
	|
	|-RVA: 0x39DCC90 Offset: 0x39DCD91 VA: 0x39DCC90
	|-Enumerable.WhereSelectListIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, UniTask>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public override Enumerable.Iterator<TResult> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39D8340 Offset: 0x39D8441 VA: 0x39D8340
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, KeyValuePair<int, object>>.Clone
	|
	|-RVA: 0x39D85F0 Offset: 0x39D86F1 VA: 0x39D85F0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, UniTask<object>>.Clone
	|
	|-RVA: 0x39D88A0 Offset: 0x39D89A1 VA: 0x39D88A0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, int>.Clone
	|
	|-RVA: 0x39D8B40 Offset: 0x39D8C41 VA: 0x39D8B40
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.Clone
	|
	|-RVA: 0x39D8DE0 Offset: 0x39D8EE1 VA: 0x39D8DE0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, UniTask>.Clone
	|
	|-RVA: 0x39D9080 Offset: 0x39D9181 VA: 0x39D9080
	|-Enumerable.WhereSelectListIterator<ContourVertex, Color>.Clone
	|
	|-RVA: 0x39D9350 Offset: 0x39D9451 VA: 0x39D9350
	|-Enumerable.WhereSelectListIterator<ContourVertex, Vector3>.Clone
	|
	|-RVA: 0x39D9620 Offset: 0x39D9721 VA: 0x39D9620
	|-Enumerable.WhereSelectListIterator<ContourVertex, float3>.Clone
	|
	|-RVA: 0x39D98F0 Offset: 0x39D99F1 VA: 0x39D98F0
	|-Enumerable.WhereSelectListIterator<int, KeyValuePair<int, object>>.Clone
	|
	|-RVA: 0x39D9B80 Offset: 0x39D9C81 VA: 0x39D9B80
	|-Enumerable.WhereSelectListIterator<int, UniTask<object>>.Clone
	|
	|-RVA: 0x39D9E10 Offset: 0x39D9F11 VA: 0x39D9E10
	|-Enumerable.WhereSelectListIterator<int, int>.Clone
	|
	|-RVA: 0x39DA090 Offset: 0x39DA191 VA: 0x39DA090
	|-Enumerable.WhereSelectListIterator<int, object>.Clone
	|
	|-RVA: 0x39DA320 Offset: 0x39DA421 VA: 0x39DA320
	|-Enumerable.WhereSelectListIterator<int, UniTask>.Clone
	|
	|-RVA: 0x39DA5B0 Offset: 0x39DA6B1 VA: 0x39DA5B0
	|-Enumerable.WhereSelectListIterator<object, KeyValuePair<int, object>>.Clone
	|
	|-RVA: 0x39DA840 Offset: 0x39DA941 VA: 0x39DA840
	|-Enumerable.WhereSelectListIterator<object, UniTask<object>>.Clone
	|
	|-RVA: 0x39DAAD0 Offset: 0x39DABD1 VA: 0x39DAAD0
	|-Enumerable.WhereSelectListIterator<object, int>.Clone
	|
	|-RVA: 0x39DAD50 Offset: 0x39DAE51 VA: 0x39DAD50
	|-Enumerable.WhereSelectListIterator<object, object>.Clone
	|
	|-RVA: 0x39DAFE0 Offset: 0x39DB0E1 VA: 0x39DAFE0
	|-Enumerable.WhereSelectListIterator<object, UniTask>.Clone
	|
	|-RVA: 0x39DB270 Offset: 0x39DB371 VA: 0x39DB270
	|-Enumerable.WhereSelectListIterator<TablePair, KeyValuePair<int, object>>.Clone
	|
	|-RVA: 0x39DB520 Offset: 0x39DB621 VA: 0x39DB520
	|-Enumerable.WhereSelectListIterator<TablePair, UniTask<object>>.Clone
	|
	|-RVA: 0x39DB7D0 Offset: 0x39DB8D1 VA: 0x39DB7D0
	|-Enumerable.WhereSelectListIterator<TablePair, int>.Clone
	|
	|-RVA: 0x39DBA70 Offset: 0x39DBB71 VA: 0x39DBA70
	|-Enumerable.WhereSelectListIterator<TablePair, object>.Clone
	|
	|-RVA: 0x39DBD10 Offset: 0x39DBE11 VA: 0x39DBD10
	|-Enumerable.WhereSelectListIterator<TablePair, TablePair>.Clone
	|
	|-RVA: 0x39DBFC0 Offset: 0x39DC0C1 VA: 0x39DBFC0
	|-Enumerable.WhereSelectListIterator<TablePair, UniTask>.Clone
	|
	|-RVA: 0x39DC260 Offset: 0x39DC361 VA: 0x39DC260
	|-Enumerable.WhereSelectListIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, KeyValuePair<int, object>>.Clone
	|
	|-RVA: 0x39DC510 Offset: 0x39DC611 VA: 0x39DC510
	|-Enumerable.WhereSelectListIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, UniTask<object>>.Clone
	|
	|-RVA: 0x39DC7C0 Offset: 0x39DC8C1 VA: 0x39DC7C0
	|-Enumerable.WhereSelectListIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, int>.Clone
	|
	|-RVA: 0x39DCA60 Offset: 0x39DCB61 VA: 0x39DCA60
	|-Enumerable.WhereSelectListIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, object>.Clone
	|
	|-RVA: 0x39DCD00 Offset: 0x39DCE01 VA: 0x39DCD00
	|-Enumerable.WhereSelectListIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, UniTask>.Clone
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39D83C0 Offset: 0x39D84C1 VA: 0x39D83C0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, KeyValuePair<int, object>>.MoveNext
	|
	|-RVA: 0x39D8670 Offset: 0x39D8771 VA: 0x39D8670
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, UniTask<object>>.MoveNext
	|
	|-RVA: 0x39D8920 Offset: 0x39D8A21 VA: 0x39D8920
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, int>.MoveNext
	|
	|-RVA: 0x39D8BC0 Offset: 0x39D8CC1 VA: 0x39D8BC0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.MoveNext
	|
	|-RVA: 0x39D8E60 Offset: 0x39D8F61 VA: 0x39D8E60
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, UniTask>.MoveNext
	|
	|-RVA: 0x39D9100 Offset: 0x39D9201 VA: 0x39D9100
	|-Enumerable.WhereSelectListIterator<ContourVertex, Color>.MoveNext
	|
	|-RVA: 0x39D93D0 Offset: 0x39D94D1 VA: 0x39D93D0
	|-Enumerable.WhereSelectListIterator<ContourVertex, Vector3>.MoveNext
	|
	|-RVA: 0x39D96A0 Offset: 0x39D97A1 VA: 0x39D96A0
	|-Enumerable.WhereSelectListIterator<ContourVertex, float3>.MoveNext
	|
	|-RVA: 0x39D9970 Offset: 0x39D9A71 VA: 0x39D9970
	|-Enumerable.WhereSelectListIterator<int, KeyValuePair<int, object>>.MoveNext
	|
	|-RVA: 0x39D9C00 Offset: 0x39D9D01 VA: 0x39D9C00
	|-Enumerable.WhereSelectListIterator<int, UniTask<object>>.MoveNext
	|
	|-RVA: 0x39D9E90 Offset: 0x39D9F91 VA: 0x39D9E90
	|-Enumerable.WhereSelectListIterator<int, int>.MoveNext
	|
	|-RVA: 0x39DA110 Offset: 0x39DA211 VA: 0x39DA110
	|-Enumerable.WhereSelectListIterator<int, object>.MoveNext
	|
	|-RVA: 0x39DA3A0 Offset: 0x39DA4A1 VA: 0x39DA3A0
	|-Enumerable.WhereSelectListIterator<int, UniTask>.MoveNext
	|
	|-RVA: 0x39DA630 Offset: 0x39DA731 VA: 0x39DA630
	|-Enumerable.WhereSelectListIterator<object, KeyValuePair<int, object>>.MoveNext
	|
	|-RVA: 0x39DA8C0 Offset: 0x39DA9C1 VA: 0x39DA8C0
	|-Enumerable.WhereSelectListIterator<object, UniTask<object>>.MoveNext
	|
	|-RVA: 0x39DAB50 Offset: 0x39DAC51 VA: 0x39DAB50
	|-Enumerable.WhereSelectListIterator<object, int>.MoveNext
	|
	|-RVA: 0x39DADD0 Offset: 0x39DAED1 VA: 0x39DADD0
	|-Enumerable.WhereSelectListIterator<object, object>.MoveNext
	|
	|-RVA: 0x39DB060 Offset: 0x39DB161 VA: 0x39DB060
	|-Enumerable.WhereSelectListIterator<object, UniTask>.MoveNext
	|
	|-RVA: 0x39DB2F0 Offset: 0x39DB3F1 VA: 0x39DB2F0
	|-Enumerable.WhereSelectListIterator<TablePair, KeyValuePair<int, object>>.MoveNext
	|
	|-RVA: 0x39DB5A0 Offset: 0x39DB6A1 VA: 0x39DB5A0
	|-Enumerable.WhereSelectListIterator<TablePair, UniTask<object>>.MoveNext
	|
	|-RVA: 0x39DB850 Offset: 0x39DB951 VA: 0x39DB850
	|-Enumerable.WhereSelectListIterator<TablePair, int>.MoveNext
	|
	|-RVA: 0x39DBAF0 Offset: 0x39DBBF1 VA: 0x39DBAF0
	|-Enumerable.WhereSelectListIterator<TablePair, object>.MoveNext
	|
	|-RVA: 0x39DBD90 Offset: 0x39DBE91 VA: 0x39DBD90
	|-Enumerable.WhereSelectListIterator<TablePair, TablePair>.MoveNext
	|
	|-RVA: 0x39DC040 Offset: 0x39DC141 VA: 0x39DC040
	|-Enumerable.WhereSelectListIterator<TablePair, UniTask>.MoveNext
	|
	|-RVA: 0x39DC2E0 Offset: 0x39DC3E1 VA: 0x39DC2E0
	|-Enumerable.WhereSelectListIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, KeyValuePair<int, object>>.MoveNext
	|
	|-RVA: 0x39DC590 Offset: 0x39DC691 VA: 0x39DC590
	|-Enumerable.WhereSelectListIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, UniTask<object>>.MoveNext
	|
	|-RVA: 0x39DC840 Offset: 0x39DC941 VA: 0x39DC840
	|-Enumerable.WhereSelectListIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, int>.MoveNext
	|
	|-RVA: 0x39DCAE0 Offset: 0x39DCBE1 VA: 0x39DCAE0
	|-Enumerable.WhereSelectListIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, object>.MoveNext
	|
	|-RVA: 0x39DCD80 Offset: 0x39DCE81 VA: 0x39DCD80
	|-Enumerable.WhereSelectListIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, UniTask>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override IEnumerable<TResult2> Select<TResult2>(Func<TResult, TResult2> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2559D90 Offset: 0x2559E91 VA: 0x2559D90
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.Select<KeyValuePair<int, object>>
	|
	|-RVA: 0x2559E20 Offset: 0x2559F21 VA: 0x2559E20
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.Select<UniTask<object>>
	|
	|-RVA: 0x2559EB0 Offset: 0x2559FB1 VA: 0x2559EB0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.Select<int>
	|
	|-RVA: 0x2559F40 Offset: 0x255A041 VA: 0x2559F40
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.Select<object>
	|
	|-RVA: 0x2559FD0 Offset: 0x255A0D1 VA: 0x2559FD0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.Select<UniTask>
	|
	|-RVA: 0x255A060 Offset: 0x255A161 VA: 0x255A060
	|-Enumerable.WhereSelectListIterator<int, int>.Select<int>
	|
	|-RVA: 0x255A0F0 Offset: 0x255A1F1 VA: 0x255A0F0
	|-Enumerable.WhereSelectListIterator<int, int>.Select<object>
	|
	|-RVA: 0x255A180 Offset: 0x255A281 VA: 0x255A180
	|-Enumerable.WhereSelectListIterator<int, object>.Select<KeyValuePair<int, object>>
	|
	|-RVA: 0x255A210 Offset: 0x255A311 VA: 0x255A210
	|-Enumerable.WhereSelectListIterator<int, object>.Select<UniTask<object>>
	|
	|-RVA: 0x255A2A0 Offset: 0x255A3A1 VA: 0x255A2A0
	|-Enumerable.WhereSelectListIterator<int, object>.Select<int>
	|
	|-RVA: 0x255A330 Offset: 0x255A431 VA: 0x255A330
	|-Enumerable.WhereSelectListIterator<int, object>.Select<object>
	|
	|-RVA: 0x255A3C0 Offset: 0x255A4C1 VA: 0x255A3C0
	|-Enumerable.WhereSelectListIterator<int, object>.Select<UniTask>
	|
	|-RVA: 0x255A450 Offset: 0x255A551 VA: 0x255A450
	|-Enumerable.WhereSelectListIterator<object, int>.Select<int>
	|
	|-RVA: 0x255A4E0 Offset: 0x255A5E1 VA: 0x255A4E0
	|-Enumerable.WhereSelectListIterator<object, int>.Select<object>
	|
	|-RVA: 0x255A570 Offset: 0x255A671 VA: 0x255A570
	|-Enumerable.WhereSelectListIterator<object, object>.Select<KeyValuePair<int, object>>
	|
	|-RVA: 0x255A600 Offset: 0x255A701 VA: 0x255A600
	|-Enumerable.WhereSelectListIterator<object, object>.Select<UniTask<object>>
	|
	|-RVA: 0x255A690 Offset: 0x255A791 VA: 0x255A690
	|-Enumerable.WhereSelectListIterator<object, object>.Select<int>
	|
	|-RVA: 0x255A720 Offset: 0x255A821 VA: 0x255A720
	|-Enumerable.WhereSelectListIterator<object, object>.Select<object>
	|
	|-RVA: 0x255A7B0 Offset: 0x255A8B1 VA: 0x255A7B0
	|-Enumerable.WhereSelectListIterator<object, object>.Select<UniTask>
	|
	|-RVA: 0x255A840 Offset: 0x255A941 VA: 0x255A840
	|-Enumerable.WhereSelectListIterator<TablePair, object>.Select<KeyValuePair<int, object>>
	|
	|-RVA: 0x255A8D0 Offset: 0x255A9D1 VA: 0x255A8D0
	|-Enumerable.WhereSelectListIterator<TablePair, object>.Select<UniTask<object>>
	|
	|-RVA: 0x255A960 Offset: 0x255AA61 VA: 0x255A960
	|-Enumerable.WhereSelectListIterator<TablePair, object>.Select<int>
	|
	|-RVA: 0x255A9F0 Offset: 0x255AAF1 VA: 0x255A9F0
	|-Enumerable.WhereSelectListIterator<TablePair, object>.Select<object>
	|
	|-RVA: 0x255AA80 Offset: 0x255AB81 VA: 0x255AA80
	|-Enumerable.WhereSelectListIterator<TablePair, object>.Select<UniTask>
	|
	|-RVA: 0x255AB10 Offset: 0x255AC11 VA: 0x255AB10
	|-Enumerable.WhereSelectListIterator<TablePair, TablePair>.Select<object>
	|
	|-RVA: 0x255ABA0 Offset: 0x255ACA1 VA: 0x255ABA0
	|-Enumerable.WhereSelectListIterator<TablePair, TablePair>.Select<TablePair>
	|
	|-RVA: 0x255AC30 Offset: 0x255AD31 VA: 0x255AC30
	|-Enumerable.WhereSelectListIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, object>.Select<KeyValuePair<int, object>>
	|
	|-RVA: 0x255ACC0 Offset: 0x255ADC1 VA: 0x255ACC0
	|-Enumerable.WhereSelectListIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, object>.Select<UniTask<object>>
	|
	|-RVA: 0x255AD50 Offset: 0x255AE51 VA: 0x255AD50
	|-Enumerable.WhereSelectListIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, object>.Select<int>
	|
	|-RVA: 0x255ADE0 Offset: 0x255AEE1 VA: 0x255ADE0
	|-Enumerable.WhereSelectListIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, object>.Select<object>
	|
	|-RVA: 0x255AE70 Offset: 0x255AF71 VA: 0x255AE70
	|-Enumerable.WhereSelectListIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, object>.Select<UniTask>
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public override IEnumerable<TResult> Where(Func<TResult, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39D8500 Offset: 0x39D8601 VA: 0x39D8500
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, KeyValuePair<int, object>>.Where
	|
	|-RVA: 0x39D87B0 Offset: 0x39D88B1 VA: 0x39D87B0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, UniTask<object>>.Where
	|
	|-RVA: 0x39D8A50 Offset: 0x39D8B51 VA: 0x39D8A50
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, int>.Where
	|
	|-RVA: 0x39D8CF0 Offset: 0x39D8DF1 VA: 0x39D8CF0
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, object>.Where
	|
	|-RVA: 0x39D8F90 Offset: 0x39D9091 VA: 0x39D8F90
	|-Enumerable.WhereSelectListIterator<KeyValuePair<object, object>, UniTask>.Where
	|
	|-RVA: 0x39D9260 Offset: 0x39D9361 VA: 0x39D9260
	|-Enumerable.WhereSelectListIterator<ContourVertex, Color>.Where
	|
	|-RVA: 0x39D9530 Offset: 0x39D9631 VA: 0x39D9530
	|-Enumerable.WhereSelectListIterator<ContourVertex, Vector3>.Where
	|
	|-RVA: 0x39D9800 Offset: 0x39D9901 VA: 0x39D9800
	|-Enumerable.WhereSelectListIterator<ContourVertex, float3>.Where
	|
	|-RVA: 0x39D9A90 Offset: 0x39D9B91 VA: 0x39D9A90
	|-Enumerable.WhereSelectListIterator<int, KeyValuePair<int, object>>.Where
	|
	|-RVA: 0x39D9D20 Offset: 0x39D9E21 VA: 0x39D9D20
	|-Enumerable.WhereSelectListIterator<int, UniTask<object>>.Where
	|
	|-RVA: 0x39D9FA0 Offset: 0x39DA0A1 VA: 0x39D9FA0
	|-Enumerable.WhereSelectListIterator<int, int>.Where
	|
	|-RVA: 0x39DA230 Offset: 0x39DA331 VA: 0x39DA230
	|-Enumerable.WhereSelectListIterator<int, object>.Where
	|
	|-RVA: 0x39DA4C0 Offset: 0x39DA5C1 VA: 0x39DA4C0
	|-Enumerable.WhereSelectListIterator<int, UniTask>.Where
	|
	|-RVA: 0x39DA750 Offset: 0x39DA851 VA: 0x39DA750
	|-Enumerable.WhereSelectListIterator<object, KeyValuePair<int, object>>.Where
	|
	|-RVA: 0x39DA9E0 Offset: 0x39DAAE1 VA: 0x39DA9E0
	|-Enumerable.WhereSelectListIterator<object, UniTask<object>>.Where
	|
	|-RVA: 0x39DAC60 Offset: 0x39DAD61 VA: 0x39DAC60
	|-Enumerable.WhereSelectListIterator<object, int>.Where
	|
	|-RVA: 0x39DAEF0 Offset: 0x39DAFF1 VA: 0x39DAEF0
	|-Enumerable.WhereSelectListIterator<object, object>.Where
	|
	|-RVA: 0x39DB180 Offset: 0x39DB281 VA: 0x39DB180
	|-Enumerable.WhereSelectListIterator<object, UniTask>.Where
	|
	|-RVA: 0x39DB430 Offset: 0x39DB531 VA: 0x39DB430
	|-Enumerable.WhereSelectListIterator<TablePair, KeyValuePair<int, object>>.Where
	|
	|-RVA: 0x39DB6E0 Offset: 0x39DB7E1 VA: 0x39DB6E0
	|-Enumerable.WhereSelectListIterator<TablePair, UniTask<object>>.Where
	|
	|-RVA: 0x39DB980 Offset: 0x39DBA81 VA: 0x39DB980
	|-Enumerable.WhereSelectListIterator<TablePair, int>.Where
	|
	|-RVA: 0x39DBC20 Offset: 0x39DBD21 VA: 0x39DBC20
	|-Enumerable.WhereSelectListIterator<TablePair, object>.Where
	|
	|-RVA: 0x39DBED0 Offset: 0x39DBFD1 VA: 0x39DBED0
	|-Enumerable.WhereSelectListIterator<TablePair, TablePair>.Where
	|
	|-RVA: 0x39DC170 Offset: 0x39DC271 VA: 0x39DC170
	|-Enumerable.WhereSelectListIterator<TablePair, UniTask>.Where
	|
	|-RVA: 0x39DC420 Offset: 0x39DC521 VA: 0x39DC420
	|-Enumerable.WhereSelectListIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, KeyValuePair<int, object>>.Where
	|
	|-RVA: 0x39DC6D0 Offset: 0x39DC7D1 VA: 0x39DC6D0
	|-Enumerable.WhereSelectListIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, UniTask<object>>.Where
	|
	|-RVA: 0x39DC970 Offset: 0x39DCA71 VA: 0x39DC970
	|-Enumerable.WhereSelectListIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, int>.Where
	|
	|-RVA: 0x39DCC10 Offset: 0x39DCD11 VA: 0x39DCC10
	|-Enumerable.WhereSelectListIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, object>.Where
	|
	|-RVA: 0x39DCEB0 Offset: 0x39DCFB1 VA: 0x39DCEB0
	|-Enumerable.WhereSelectListIterator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, UniTask>.Where
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
[CompilerGeneratedAttribute] // RVA: 0x3F7C0 Offset: 0x3F8C1 VA: 0x3F7C0
private sealed class Enumerable.<>c__DisplayClass6_0<TSource> // TypeDefIndex: 2731
{
	// Fields
	public Func<TSource, bool> predicate1; // 0x0
	public Func<TSource, bool> predicate2; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3F110 Offset: 0x2B3F211 VA: 0x2B3F110
	|-Enumerable.<>c__DisplayClass6_0<KeyValuePair<int, object>>..ctor
	|
	|-RVA: 0x2B3F1A0 Offset: 0x2B3F2A1 VA: 0x2B3F1A0
	|-Enumerable.<>c__DisplayClass6_0<KeyValuePair<object, object>>..ctor
	|
	|-RVA: 0x2B3F230 Offset: 0x2B3F331 VA: 0x2B3F230
	|-Enumerable.<>c__DisplayClass6_0<UniTask<object>>..ctor
	|
	|-RVA: 0x2B3F2C0 Offset: 0x2B3F3C1 VA: 0x2B3F2C0
	|-Enumerable.<>c__DisplayClass6_0<Color>..ctor
	|
	|-RVA: 0x2B3F370 Offset: 0x2B3F471 VA: 0x2B3F370
	|-Enumerable.<>c__DisplayClass6_0<int>..ctor
	|
	|-RVA: 0x2B3F4B0 Offset: 0x2B3F5B1 VA: 0x2B3F4B0
	|-Enumerable.<>c__DisplayClass6_0<object>..ctor
	|
	|-RVA: 0x2B3F540 Offset: 0x2B3F641 VA: 0x2B3F540
	|-Enumerable.<>c__DisplayClass6_0<TablePair>..ctor
	|
	|-RVA: 0x2B3F5D0 Offset: 0x2B3F6D1 VA: 0x2B3F5D0
	|-Enumerable.<>c__DisplayClass6_0<UniTask>..ctor
	|
	|-RVA: 0x2B3F660 Offset: 0x2B3F761 VA: 0x2B3F660
	|-Enumerable.<>c__DisplayClass6_0<Vector3>..ctor
	|
	|-RVA: 0x2B3F700 Offset: 0x2B3F801 VA: 0x2B3F700
	|-Enumerable.<>c__DisplayClass6_0<float3>..ctor
	|
	|-RVA: 0x2B3F7A0 Offset: 0x2B3F8A1 VA: 0x2B3F7A0
	|-Enumerable.<>c__DisplayClass6_0<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool <CombinePredicates>b__0(TSource x) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3F120 Offset: 0x2B3F221 VA: 0x2B3F120
	|-Enumerable.<>c__DisplayClass6_0<KeyValuePair<int, object>>.<CombinePredicates>b__0
	|
	|-RVA: 0x2B3F1B0 Offset: 0x2B3F2B1 VA: 0x2B3F1B0
	|-Enumerable.<>c__DisplayClass6_0<KeyValuePair<object, object>>.<CombinePredicates>b__0
	|
	|-RVA: 0x2B3F240 Offset: 0x2B3F341 VA: 0x2B3F240
	|-Enumerable.<>c__DisplayClass6_0<UniTask<object>>.<CombinePredicates>b__0
	|
	|-RVA: 0x2B3F2D0 Offset: 0x2B3F3D1 VA: 0x2B3F2D0
	|-Enumerable.<>c__DisplayClass6_0<Color>.<CombinePredicates>b__0
	|
	|-RVA: 0x2B3F380 Offset: 0x2B3F481 VA: 0x2B3F380
	|-Enumerable.<>c__DisplayClass6_0<int>.<CombinePredicates>b__0
	|
	|-RVA: 0x2B3F4C0 Offset: 0x2B3F5C1 VA: 0x2B3F4C0
	|-Enumerable.<>c__DisplayClass6_0<object>.<CombinePredicates>b__0
	|
	|-RVA: 0x2B3F550 Offset: 0x2B3F651 VA: 0x2B3F550
	|-Enumerable.<>c__DisplayClass6_0<TablePair>.<CombinePredicates>b__0
	|
	|-RVA: 0x2B3F5E0 Offset: 0x2B3F6E1 VA: 0x2B3F5E0
	|-Enumerable.<>c__DisplayClass6_0<UniTask>.<CombinePredicates>b__0
	|
	|-RVA: 0x2B3F670 Offset: 0x2B3F771 VA: 0x2B3F670
	|-Enumerable.<>c__DisplayClass6_0<Vector3>.<CombinePredicates>b__0
	|
	|-RVA: 0x2B3F710 Offset: 0x2B3F811 VA: 0x2B3F710
	|-Enumerable.<>c__DisplayClass6_0<float3>.<CombinePredicates>b__0
	|
	|-RVA: 0x2B3F7B0 Offset: 0x2B3F8B1 VA: 0x2B3F7B0
	|-Enumerable.<>c__DisplayClass6_0<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.<CombinePredicates>b__0
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
[CompilerGeneratedAttribute] // RVA: 0x3F7E0 Offset: 0x3F8E1 VA: 0x3F7E0
private sealed class Enumerable.<SelectManyIterator>d__17<TSource, TResult> : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator // TypeDefIndex: 2733
{
	// Fields
	private int <>1__state; // 0x0
	private TResult <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEnumerable<TSource> source; // 0x0
	public IEnumerable<TSource> <>3__source; // 0x0
	private Func<TSource, IEnumerable<TResult>> selector; // 0x0
	public Func<TSource, IEnumerable<TResult>> <>3__selector; // 0x0
	private IEnumerator<TSource> <>7__wrap1; // 0x0
	private IEnumerator<TResult> <>7__wrap2; // 0x0

	// Properties
	private TResult System.Collections.Generic.IEnumerator<TResult>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x41490 Offset: 0x41591 VA: 0x41490
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3166790 Offset: 0x3166891 VA: 0x3166790
	|-Enumerable.<SelectManyIterator>d__17<object, object>..ctor
	|
	|-RVA: 0x3166F90 Offset: 0x3167091 VA: 0x3166F90
	|-Enumerable.<SelectManyIterator>d__17<object, AssetBundleBuildMap.AssetBundleEntry.AssetPathString>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x414A0 Offset: 0x415A1 VA: 0x414A0
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31667D0 Offset: 0x31668D1 VA: 0x31667D0
	|-Enumerable.<SelectManyIterator>d__17<object, object>.System.IDisposable.Dispose
	|
	|-RVA: 0x3166FD0 Offset: 0x31670D1 VA: 0x3166FD0
	|-Enumerable.<SelectManyIterator>d__17<object, AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3166890 Offset: 0x3166991 VA: 0x3166890
	|-Enumerable.<SelectManyIterator>d__17<object, object>.MoveNext
	|
	|-RVA: 0x3167090 Offset: 0x3167191 VA: 0x3167090
	|-Enumerable.<SelectManyIterator>d__17<object, AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3166CD0 Offset: 0x3166DD1 VA: 0x3166CD0
	|-Enumerable.<SelectManyIterator>d__17<object, object>.<>m__Finally1
	|
	|-RVA: 0x31674D0 Offset: 0x31675D1 VA: 0x31674D0
	|-Enumerable.<SelectManyIterator>d__17<object, AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.<>m__Finally1
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3166D90 Offset: 0x3166E91 VA: 0x3166D90
	|-Enumerable.<SelectManyIterator>d__17<object, object>.<>m__Finally2
	|
	|-RVA: 0x3167590 Offset: 0x3167691 VA: 0x3167590
	|-Enumerable.<SelectManyIterator>d__17<object, AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.<>m__Finally2
	*/

	[DebuggerHiddenAttribute] // RVA: 0x414B0 Offset: 0x415B1 VA: 0x414B0
	// RVA: -1 Offset: -1 Slot: 6
	private TResult System.Collections.Generic.IEnumerator<TResult>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3166E50 Offset: 0x3166F51 VA: 0x3166E50
	|-Enumerable.<SelectManyIterator>d__17<object, object>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	|
	|-RVA: 0x3167650 Offset: 0x3167751 VA: 0x3167650
	|-Enumerable.<SelectManyIterator>d__17<object, AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x414C0 Offset: 0x415C1 VA: 0x414C0
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3166E60 Offset: 0x3166F61 VA: 0x3166E60
	|-Enumerable.<SelectManyIterator>d__17<object, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3167660 Offset: 0x3167761 VA: 0x3167660
	|-Enumerable.<SelectManyIterator>d__17<object, AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x414D0 Offset: 0x415D1 VA: 0x414D0
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3166EA0 Offset: 0x3166FA1 VA: 0x3166EA0
	|-Enumerable.<SelectManyIterator>d__17<object, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x31676A0 Offset: 0x31677A1 VA: 0x31676A0
	|-Enumerable.<SelectManyIterator>d__17<object, AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x414E0 Offset: 0x415E1 VA: 0x414E0
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<TResult> System.Collections.Generic.IEnumerable<TResult>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3166EB0 Offset: 0x3166FB1 VA: 0x3166EB0
	|-Enumerable.<SelectManyIterator>d__17<object, object>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	|
	|-RVA: 0x31676F0 Offset: 0x31677F1 VA: 0x31676F0
	|-Enumerable.<SelectManyIterator>d__17<object, AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x414F0 Offset: 0x415F1 VA: 0x414F0
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3166F70 Offset: 0x3167071 VA: 0x3166F70
	|-Enumerable.<SelectManyIterator>d__17<object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x31677B0 Offset: 0x31678B1 VA: 0x31677B0
	|-Enumerable.<SelectManyIterator>d__17<object, AssetBundleBuildMap.AssetBundleEntry.AssetPathString>.System.Collections.IEnumerable.GetEnumerator
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
[CompilerGeneratedAttribute] // RVA: 0x3F800 Offset: 0x3F901 VA: 0x3F800
private sealed class Enumerable.<SkipIterator>d__31<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator // TypeDefIndex: 2735
{
	// Fields
	private int <>1__state; // 0x0
	private TSource <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEnumerable<TSource> source; // 0x0
	public IEnumerable<TSource> <>3__source; // 0x0
	private int count; // 0x0
	public int <>3__count; // 0x0
	private IEnumerator<TSource> <e>5__1; // 0x0

	// Properties
	private TSource System.Collections.Generic.IEnumerator<TSource>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x41570 Offset: 0x41671 VA: 0x41570
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FBAD60 Offset: 0x1FBAE61 VA: 0x1FBAD60
	|-Enumerable.<SkipIterator>d__31<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x41580 Offset: 0x41681 VA: 0x41580
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FBADA0 Offset: 0x1FBAEA1 VA: 0x1FBADA0
	|-Enumerable.<SkipIterator>d__31<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FBADD0 Offset: 0x1FBAED1 VA: 0x1FBADD0
	|-Enumerable.<SkipIterator>d__31<object>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FBB0E0 Offset: 0x1FBB1E1 VA: 0x1FBB0E0
	|-Enumerable.<SkipIterator>d__31<object>.<>m__Finally1
	*/

	[DebuggerHiddenAttribute] // RVA: 0x41590 Offset: 0x41691 VA: 0x41590
	// RVA: -1 Offset: -1 Slot: 6
	private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FBB1A0 Offset: 0x1FBB2A1 VA: 0x1FBB1A0
	|-Enumerable.<SkipIterator>d__31<object>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x415A0 Offset: 0x416A1 VA: 0x415A0
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FBB1B0 Offset: 0x1FBB2B1 VA: 0x1FBB1B0
	|-Enumerable.<SkipIterator>d__31<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x415B0 Offset: 0x416B1 VA: 0x415B0
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FBB1F0 Offset: 0x1FBB2F1 VA: 0x1FBB1F0
	|-Enumerable.<SkipIterator>d__31<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x415C0 Offset: 0x416C1 VA: 0x415C0
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FBB200 Offset: 0x1FBB301 VA: 0x1FBB200
	|-Enumerable.<SkipIterator>d__31<object>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x415D0 Offset: 0x416D1 VA: 0x415D0
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FBB2B0 Offset: 0x1FBB3B1 VA: 0x1FBB2B0
	|-Enumerable.<SkipIterator>d__31<object>.System.Collections.IEnumerable.GetEnumerator
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
[CompilerGeneratedAttribute] // RVA: 0x3F820 Offset: 0x3F921 VA: 0x3F820
private sealed class Enumerable.<DistinctIterator>d__68<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator // TypeDefIndex: 2737
{
	// Fields
	private int <>1__state; // 0x0
	private TSource <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEqualityComparer<TSource> comparer; // 0x0
	public IEqualityComparer<TSource> <>3__comparer; // 0x0
	private IEnumerable<TSource> source; // 0x0
	public IEnumerable<TSource> <>3__source; // 0x0
	private Set<TSource> <set>5__1; // 0x0
	private IEnumerator<TSource> <>7__wrap1; // 0x0

	// Properties
	private TSource System.Collections.Generic.IEnumerator<TSource>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x41650 Offset: 0x41751 VA: 0x41650
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B4A690 Offset: 0x2B4A791 VA: 0x2B4A690
	|-Enumerable.<DistinctIterator>d__68<object>..ctor
	|
	|-RVA: 0x2B4AC00 Offset: 0x2B4AD01 VA: 0x2B4AC00
	|-Enumerable.<DistinctIterator>d__68<Vector3>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x41660 Offset: 0x41761 VA: 0x41660
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B4A6D0 Offset: 0x2B4A7D1 VA: 0x2B4A6D0
	|-Enumerable.<DistinctIterator>d__68<object>.System.IDisposable.Dispose
	|
	|-RVA: 0x2B4AC40 Offset: 0x2B4AD41 VA: 0x2B4AC40
	|-Enumerable.<DistinctIterator>d__68<Vector3>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B4A700 Offset: 0x2B4A801 VA: 0x2B4A700
	|-Enumerable.<DistinctIterator>d__68<object>.MoveNext
	|
	|-RVA: 0x2B4AC70 Offset: 0x2B4AD71 VA: 0x2B4AC70
	|-Enumerable.<DistinctIterator>d__68<Vector3>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B4AA00 Offset: 0x2B4AB01 VA: 0x2B4AA00
	|-Enumerable.<DistinctIterator>d__68<object>.<>m__Finally1
	|
	|-RVA: 0x2B4AF70 Offset: 0x2B4B071 VA: 0x2B4AF70
	|-Enumerable.<DistinctIterator>d__68<Vector3>.<>m__Finally1
	*/

	[DebuggerHiddenAttribute] // RVA: 0x41670 Offset: 0x41771 VA: 0x41670
	// RVA: -1 Offset: -1 Slot: 6
	private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B4AAC0 Offset: 0x2B4ABC1 VA: 0x2B4AAC0
	|-Enumerable.<DistinctIterator>d__68<object>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0x2B4B030 Offset: 0x2B4B131 VA: 0x2B4B030
	|-Enumerable.<DistinctIterator>d__68<Vector3>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x41680 Offset: 0x41781 VA: 0x41680
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B4AAD0 Offset: 0x2B4ABD1 VA: 0x2B4AAD0
	|-Enumerable.<DistinctIterator>d__68<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2B4B040 Offset: 0x2B4B141 VA: 0x2B4B040
	|-Enumerable.<DistinctIterator>d__68<Vector3>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x41690 Offset: 0x41791 VA: 0x41690
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B4AB10 Offset: 0x2B4AC11 VA: 0x2B4AB10
	|-Enumerable.<DistinctIterator>d__68<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2B4B080 Offset: 0x2B4B181 VA: 0x2B4B080
	|-Enumerable.<DistinctIterator>d__68<Vector3>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x416A0 Offset: 0x417A1 VA: 0x416A0
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B4AB20 Offset: 0x2B4AC21 VA: 0x2B4AB20
	|-Enumerable.<DistinctIterator>d__68<object>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0x2B4B0E0 Offset: 0x2B4B1E1 VA: 0x2B4B0E0
	|-Enumerable.<DistinctIterator>d__68<Vector3>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x416B0 Offset: 0x417B1 VA: 0x416B0
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B4ABE0 Offset: 0x2B4ACE1 VA: 0x2B4ABE0
	|-Enumerable.<DistinctIterator>d__68<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2B4B1A0 Offset: 0x2B4B2A1 VA: 0x2B4B1A0
	|-Enumerable.<DistinctIterator>d__68<Vector3>.System.Collections.IEnumerable.GetEnumerator
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
[CompilerGeneratedAttribute] // RVA: 0x3F840 Offset: 0x3F941 VA: 0x3F840
private sealed class Enumerable.<ReverseIterator>d__79<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator // TypeDefIndex: 2739
{
	// Fields
	private int <>1__state; // 0x0
	private TSource <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private IEnumerable<TSource> source; // 0x0
	public IEnumerable<TSource> <>3__source; // 0x0
	private Buffer<TSource> <buffer>5__1; // 0x0
	private int <i>5__2; // 0x0

	// Properties
	private TSource System.Collections.Generic.IEnumerator<TSource>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x41730 Offset: 0x41831 VA: 0x41730
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3153930 Offset: 0x3153A31 VA: 0x3153930
	|-Enumerable.<ReverseIterator>d__79<int>..ctor
	|
	|-RVA: 0x3153BD0 Offset: 0x3153CD1 VA: 0x3153BD0
	|-Enumerable.<ReverseIterator>d__79<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x41740 Offset: 0x41841 VA: 0x41740
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3153970 Offset: 0x3153A71 VA: 0x3153970
	|-Enumerable.<ReverseIterator>d__79<int>.System.IDisposable.Dispose
	|
	|-RVA: 0x3153C10 Offset: 0x3153D11 VA: 0x3153C10
	|-Enumerable.<ReverseIterator>d__79<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3153980 Offset: 0x3153A81 VA: 0x3153980
	|-Enumerable.<ReverseIterator>d__79<int>.MoveNext
	|
	|-RVA: 0x3153C20 Offset: 0x3153D21 VA: 0x3153C20
	|-Enumerable.<ReverseIterator>d__79<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x41750 Offset: 0x41851 VA: 0x41750
	// RVA: -1 Offset: -1 Slot: 6
	private TSource System.Collections.Generic.IEnumerator<TSource>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3153A60 Offset: 0x3153B61 VA: 0x3153A60
	|-Enumerable.<ReverseIterator>d__79<int>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	|
	|-RVA: 0x3153D10 Offset: 0x3153E11 VA: 0x3153D10
	|-Enumerable.<ReverseIterator>d__79<object>.System.Collections.Generic.IEnumerator<TSource>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x41760 Offset: 0x41861 VA: 0x41760
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3153A70 Offset: 0x3153B71 VA: 0x3153A70
	|-Enumerable.<ReverseIterator>d__79<int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x3153D20 Offset: 0x3153E21 VA: 0x3153D20
	|-Enumerable.<ReverseIterator>d__79<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x41770 Offset: 0x41871 VA: 0x41770
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3153AB0 Offset: 0x3153BB1 VA: 0x3153AB0
	|-Enumerable.<ReverseIterator>d__79<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x3153D60 Offset: 0x3153E61 VA: 0x3153D60
	|-Enumerable.<ReverseIterator>d__79<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x41780 Offset: 0x41881 VA: 0x41780
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<TSource> System.Collections.Generic.IEnumerable<TSource>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3153B00 Offset: 0x3153C01 VA: 0x3153B00
	|-Enumerable.<ReverseIterator>d__79<int>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	|
	|-RVA: 0x3153D70 Offset: 0x3153E71 VA: 0x3153D70
	|-Enumerable.<ReverseIterator>d__79<object>.System.Collections.Generic.IEnumerable<TSource>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x41790 Offset: 0x41891 VA: 0x41790
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3153BB0 Offset: 0x3153CB1 VA: 0x3153BB0
	|-Enumerable.<ReverseIterator>d__79<int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3153E20 Offset: 0x3153F21 VA: 0x3153E20
	|-Enumerable.<ReverseIterator>d__79<object>.System.Collections.IEnumerable.GetEnumerator
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
[CompilerGeneratedAttribute] // RVA: 0x3F860 Offset: 0x3F961 VA: 0x3F860
private sealed class Enumerable.<CastIterator>d__99<TResult> : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator // TypeDefIndex: 2741
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

	[DebuggerHiddenAttribute] // RVA: 0x41810 Offset: 0x41911 VA: 0x41810
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B45DA0 Offset: 0x2B45EA1 VA: 0x2B45DA0
	|-Enumerable.<CastIterator>d__99<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x41820 Offset: 0x41921 VA: 0x41820
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B45DE0 Offset: 0x2B45EE1 VA: 0x2B45DE0
	|-Enumerable.<CastIterator>d__99<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B45E10 Offset: 0x2B45F11 VA: 0x2B45E10
	|-Enumerable.<CastIterator>d__99<object>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B460B0 Offset: 0x2B461B1 VA: 0x2B460B0
	|-Enumerable.<CastIterator>d__99<object>.<>m__Finally1
	*/

	[DebuggerHiddenAttribute] // RVA: 0x41830 Offset: 0x41931 VA: 0x41830
	// RVA: -1 Offset: -1 Slot: 6
	private TResult System.Collections.Generic.IEnumerator<TResult>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B46180 Offset: 0x2B46281 VA: 0x2B46180
	|-Enumerable.<CastIterator>d__99<object>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x41840 Offset: 0x41941 VA: 0x41840
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B46190 Offset: 0x2B46291 VA: 0x2B46190
	|-Enumerable.<CastIterator>d__99<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x41850 Offset: 0x41951 VA: 0x41850
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B461D0 Offset: 0x2B462D1 VA: 0x2B461D0
	|-Enumerable.<CastIterator>d__99<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x41860 Offset: 0x41961 VA: 0x41860
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<TResult> System.Collections.Generic.IEnumerable<TResult>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B461E0 Offset: 0x2B462E1 VA: 0x2B461E0
	|-Enumerable.<CastIterator>d__99<object>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x41870 Offset: 0x41971 VA: 0x41870
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B46290 Offset: 0x2B46391 VA: 0x2B46290
	|-Enumerable.<CastIterator>d__99<object>.System.Collections.IEnumerable.GetEnumerator
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

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x3F880 Offset: 0x3F981 VA: 0x3F880
private sealed class Enumerable.<RepeatIterator>d__117<TResult> : IEnumerable<TResult>, IEnumerable, IEnumerator<TResult>, IDisposable, IEnumerator // TypeDefIndex: 2743
{
	// Fields
	private int <>1__state; // 0x0
	private TResult <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private TResult element; // 0x0
	public TResult <>3__element; // 0x0
	private int <i>5__1; // 0x0
	private int count; // 0x0
	public int <>3__count; // 0x0

	// Properties
	private TResult System.Collections.Generic.IEnumerator<TResult>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x418F0 Offset: 0x419F1 VA: 0x418F0
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3153720 Offset: 0x3153821 VA: 0x3153720
	|-Enumerable.<RepeatIterator>d__117<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x41900 Offset: 0x41A01 VA: 0x41900
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3153760 Offset: 0x3153861 VA: 0x3153760
	|-Enumerable.<RepeatIterator>d__117<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3153770 Offset: 0x3153871 VA: 0x3153770
	|-Enumerable.<RepeatIterator>d__117<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x41910 Offset: 0x41A11 VA: 0x41910
	// RVA: -1 Offset: -1 Slot: 6
	private TResult System.Collections.Generic.IEnumerator<TResult>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3153800 Offset: 0x3153901 VA: 0x3153800
	|-Enumerable.<RepeatIterator>d__117<object>.System.Collections.Generic.IEnumerator<TResult>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x41920 Offset: 0x41A21 VA: 0x41920
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3153810 Offset: 0x3153911 VA: 0x3153810
	|-Enumerable.<RepeatIterator>d__117<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x41930 Offset: 0x41A31 VA: 0x41930
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3153850 Offset: 0x3153951 VA: 0x3153850
	|-Enumerable.<RepeatIterator>d__117<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x41940 Offset: 0x41A41 VA: 0x41940
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<TResult> System.Collections.Generic.IEnumerable<TResult>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3153860 Offset: 0x3153961 VA: 0x3153860
	|-Enumerable.<RepeatIterator>d__117<object>.System.Collections.Generic.IEnumerable<TResult>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x41950 Offset: 0x41A51 VA: 0x41950
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3153910 Offset: 0x3153A11 VA: 0x3153910
	|-Enumerable.<RepeatIterator>d__117<object>.System.Collections.IEnumerable.GetEnumerator
	*/
}

