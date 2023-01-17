// Namespace: System.Collections.Generic
[DebuggerDisplayAttribute] // RVA: 0x30D80 Offset: 0x30E81 VA: 0x30D80
[DebuggerTypeProxyAttribute] // RVA: 0x30D80 Offset: 0x30E81 VA: 0x30D80
[Serializable]
public class Stack<T> : IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T> // TypeDefIndex: 2444
{
	// Fields
	private T[] _array; // 0x0
	private int _size; // 0x0
	private int _version; // 0x0
	private object _syncRoot; // 0x0
	private const int DefaultCapacity = 4;

	// Properties
	public int Count { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36BCF10 Offset: 0x36BD011 VA: 0x36BCF10
	|-Stack<Dictionary<string, int>>..ctor
	|-Stack<HashSet<ParameterExpression>>..ctor
	|-Stack<BattleCalculator>..ctor
	|-Stack<EventScript>..ctor
	|-Stack<GameObject>..ctor
	|-Stack<HubManualCulling>..ctor
	|-Stack<InteriorNode>..ctor
	|-Stack<MapInspector>..ctor
	|-Stack<object>..ctor
	|-Stack<ParameterExpression>..ctor
	|-Stack<CalculatorManager.CommandStack>..ctor
	|-Stack<DebugManager.LogArg>..ctor
	|-Stack<DtdParser.ParseElementOnlyContent_LocalFrame>..ctor
	|-Stack<MapDispos.Pos>..ctor
	|
	|-RVA: 0x36BB5F0 Offset: 0x36BB6F1 VA: 0x36BB5F0
	|-Stack<Color>..ctor
	|
	|-RVA: 0x36BBE70 Offset: 0x36BBF71 VA: 0x36BBE70
	|-Stack<int>..ctor
	|
	|-RVA: 0x36BC6C0 Offset: 0x36BC7C1 VA: 0x36BC6C0
	|-Stack<Int32Enum>..ctor
	|
	|-RVA: 0x36BD7A0 Offset: 0x36BD8A1 VA: 0x36BD7A0
	|-Stack<RandomSeed>..ctor
	|
	|-RVA: 0x36BE000 Offset: 0x36BE101 VA: 0x36BE000
	|-Stack<float>..ctor
	|
	|-RVA: 0x36BE850 Offset: 0x36BE951 VA: 0x36BE850
	|-Stack<uint>..ctor
	|
	|-RVA: 0x36BF0A0 Offset: 0x36BF1A1 VA: 0x36BF0A0
	|-Stack<DynamicMesh.State>..ctor
	|
	|-RVA: 0x36BF8F0 Offset: 0x36BF9F1 VA: 0x36BF8F0
	|-Stack<MapMind.Record>..ctor
	|
	|-RVA: 0x36C0390 Offset: 0x36C0491 VA: 0x36C0390
	|-Stack<QualitySettingsStack.Settings>..ctor
	|
	|-RVA: 0x36C0CB0 Offset: 0x36C0DB1 VA: 0x36C0CB0
	|-Stack<SequenceNode.SequenceConstructPosContext>..ctor
	|
	|-RVA: 0x36C1670 Offset: 0x36C1771 VA: 0x36C1670
	|-Stack<Stream.Info>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36BCF60 Offset: 0x36BD061 VA: 0x36BCF60
	|-Stack<LinkedListNode<DelayedActionManager.DelegateInfo>>..ctor
	|-Stack<LinkedList<AsyncOperationHandle>>..ctor
	|-Stack<Stack<ResourceHandle>>..ctor
	|-Stack<string[]>..ctor
	|-Stack<AssetBundleLocalResource>..ctor
	|-Stack<MapInspector>..ctor
	|-Stack<object>..ctor
	|-Stack<ResourceHandle>..ctor
	|-Stack<string>..ctor
	|-Stack<MapTarget.Data>..ctor
	|
	|-RVA: 0x36BB640 Offset: 0x36BB741 VA: 0x36BB640
	|-Stack<Color>..ctor
	|
	|-RVA: 0x36BBEC0 Offset: 0x36BBFC1 VA: 0x36BBEC0
	|-Stack<int>..ctor
	|
	|-RVA: 0x36BC710 Offset: 0x36BC811 VA: 0x36BC710
	|-Stack<Int32Enum>..ctor
	|-Stack<Fade.Layer>..ctor
	|-Stack<GameSkip.Status>..ctor
	|-Stack<MiniMapController.Mode>..ctor
	|-Stack<UnitInfo.Mode>..ctor
	|-Stack<ViewMode.Mode>..ctor
	|
	|-RVA: 0x36BD7F0 Offset: 0x36BD8F1 VA: 0x36BD7F0
	|-Stack<RandomSeed>..ctor
	|
	|-RVA: 0x36BE050 Offset: 0x36BE151 VA: 0x36BE050
	|-Stack<float>..ctor
	|
	|-RVA: 0x36BE8A0 Offset: 0x36BE9A1 VA: 0x36BE8A0
	|-Stack<uint>..ctor
	|
	|-RVA: 0x36BF0F0 Offset: 0x36BF1F1 VA: 0x36BF0F0
	|-Stack<DynamicMesh.State>..ctor
	|
	|-RVA: 0x36BF940 Offset: 0x36BFA41 VA: 0x36BF940
	|-Stack<MapMind.Record>..ctor
	|
	|-RVA: 0x36C03E0 Offset: 0x36C04E1 VA: 0x36C03E0
	|-Stack<QualitySettingsStack.Settings>..ctor
	|
	|-RVA: 0x36C0D00 Offset: 0x36C0E01 VA: 0x36C0D00
	|-Stack<SequenceNode.SequenceConstructPosContext>..ctor
	|
	|-RVA: 0x36C16C0 Offset: 0x36C17C1 VA: 0x36C16C0
	|-Stack<Stream.Info>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36BD050 Offset: 0x36BD151 VA: 0x36BD050
	|-Stack<LinkedListNode<DelayedActionManager.DelegateInfo>>.get_Count
	|-Stack<BattleCalculator>.get_Count
	|-Stack<EventScript>.get_Count
	|-Stack<GameObject>.get_Count
	|-Stack<HubManualCulling>.get_Count
	|-Stack<InteriorNode>.get_Count
	|-Stack<MapInspector>.get_Count
	|-Stack<object>.get_Count
	|-Stack<ResourceHandle>.get_Count
	|-Stack<CalculatorManager.CommandStack>.get_Count
	|-Stack<DtdParser.ParseElementOnlyContent_LocalFrame>.get_Count
	|-Stack<MapDispos.Pos>.get_Count
	|-Stack<MapTarget.Data>.get_Count
	|
	|-RVA: 0x36BB730 Offset: 0x36BB831 VA: 0x36BB730
	|-Stack<Color>.get_Count
	|
	|-RVA: 0x36BBFB0 Offset: 0x36BC0B1 VA: 0x36BBFB0
	|-Stack<int>.get_Count
	|
	|-RVA: 0x36BC800 Offset: 0x36BC901 VA: 0x36BC800
	|-Stack<Int32Enum>.get_Count
	|-Stack<UnitInfo.Mode>.get_Count
	|
	|-RVA: 0x36BD8E0 Offset: 0x36BD9E1 VA: 0x36BD8E0
	|-Stack<RandomSeed>.get_Count
	|
	|-RVA: 0x36BE140 Offset: 0x36BE241 VA: 0x36BE140
	|-Stack<float>.get_Count
	|
	|-RVA: 0x36BE990 Offset: 0x36BEA91 VA: 0x36BE990
	|-Stack<uint>.get_Count
	|
	|-RVA: 0x36BF1E0 Offset: 0x36BF2E1 VA: 0x36BF1E0
	|-Stack<DynamicMesh.State>.get_Count
	|
	|-RVA: 0x36BFA30 Offset: 0x36BFB31 VA: 0x36BFA30
	|-Stack<MapMind.Record>.get_Count
	|
	|-RVA: 0x36C04D0 Offset: 0x36C05D1 VA: 0x36C04D0
	|-Stack<QualitySettingsStack.Settings>.get_Count
	|
	|-RVA: 0x36C0DF0 Offset: 0x36C0EF1 VA: 0x36C0DF0
	|-Stack<SequenceNode.SequenceConstructPosContext>.get_Count
	|
	|-RVA: 0x36C17B0 Offset: 0x36C18B1 VA: 0x36C17B0
	|-Stack<Stream.Info>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36BB740 Offset: 0x36BB841 VA: 0x36BB740
	|-Stack<Color>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x36BBFC0 Offset: 0x36BC0C1 VA: 0x36BBFC0
	|-Stack<int>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x36BC810 Offset: 0x36BC911 VA: 0x36BC810
	|-Stack<Int32Enum>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x36BD060 Offset: 0x36BD161 VA: 0x36BD060
	|-Stack<object>.System.Collections.ICollection.get_IsSynchronized
	|-Stack<CalculatorManager.CommandStack>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x36BD8F0 Offset: 0x36BD9F1 VA: 0x36BD8F0
	|-Stack<RandomSeed>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x36BE150 Offset: 0x36BE251 VA: 0x36BE150
	|-Stack<float>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x36BE9A0 Offset: 0x36BEAA1 VA: 0x36BE9A0
	|-Stack<uint>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x36BF1F0 Offset: 0x36BF2F1 VA: 0x36BF1F0
	|-Stack<DynamicMesh.State>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x36BFA40 Offset: 0x36BFB41 VA: 0x36BFA40
	|-Stack<MapMind.Record>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x36C04E0 Offset: 0x36C05E1 VA: 0x36C04E0
	|-Stack<QualitySettingsStack.Settings>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x36C0E00 Offset: 0x36C0F01 VA: 0x36C0E00
	|-Stack<SequenceNode.SequenceConstructPosContext>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x36C17C0 Offset: 0x36C18C1 VA: 0x36C17C0
	|-Stack<Stream.Info>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36BB750 Offset: 0x36BB851 VA: 0x36BB750
	|-Stack<Color>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x36BBFD0 Offset: 0x36BC0D1 VA: 0x36BBFD0
	|-Stack<int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x36BC820 Offset: 0x36BC921 VA: 0x36BC820
	|-Stack<Int32Enum>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x36BD070 Offset: 0x36BD171 VA: 0x36BD070
	|-Stack<object>.System.Collections.ICollection.get_SyncRoot
	|-Stack<CalculatorManager.CommandStack>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x36BD900 Offset: 0x36BDA01 VA: 0x36BD900
	|-Stack<RandomSeed>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x36BE160 Offset: 0x36BE261 VA: 0x36BE160
	|-Stack<float>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x36BE9B0 Offset: 0x36BEAB1 VA: 0x36BE9B0
	|-Stack<uint>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x36BF200 Offset: 0x36BF301 VA: 0x36BF200
	|-Stack<DynamicMesh.State>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x36BFA50 Offset: 0x36BFB51 VA: 0x36BFA50
	|-Stack<MapMind.Record>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x36C04F0 Offset: 0x36C05F1 VA: 0x36C04F0
	|-Stack<QualitySettingsStack.Settings>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x36C0E10 Offset: 0x36C0F11 VA: 0x36C0E10
	|-Stack<SequenceNode.SequenceConstructPosContext>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x36C17D0 Offset: 0x36C18D1 VA: 0x36C17D0
	|-Stack<Stream.Info>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36BD100 Offset: 0x36BD201 VA: 0x36BD100
	|-Stack<Dictionary<string, int>>.Clear
	|-Stack<string[]>.Clear
	|-Stack<object>.Clear
	|-Stack<string>.Clear
	|
	|-RVA: 0x36BB7E0 Offset: 0x36BB8E1 VA: 0x36BB7E0
	|-Stack<Color>.Clear
	|
	|-RVA: 0x36BC060 Offset: 0x36BC161 VA: 0x36BC060
	|-Stack<int>.Clear
	|
	|-RVA: 0x36BC8B0 Offset: 0x36BC9B1 VA: 0x36BC8B0
	|-Stack<Int32Enum>.Clear
	|
	|-RVA: 0x36BD990 Offset: 0x36BDA91 VA: 0x36BD990
	|-Stack<RandomSeed>.Clear
	|
	|-RVA: 0x36BE1F0 Offset: 0x36BE2F1 VA: 0x36BE1F0
	|-Stack<float>.Clear
	|
	|-RVA: 0x36BEA40 Offset: 0x36BEB41 VA: 0x36BEA40
	|-Stack<uint>.Clear
	|
	|-RVA: 0x36BF290 Offset: 0x36BF391 VA: 0x36BF290
	|-Stack<DynamicMesh.State>.Clear
	|
	|-RVA: 0x36BFAE0 Offset: 0x36BFBE1 VA: 0x36BFAE0
	|-Stack<MapMind.Record>.Clear
	|
	|-RVA: 0x36C0580 Offset: 0x36C0681 VA: 0x36C0580
	|-Stack<QualitySettingsStack.Settings>.Clear
	|
	|-RVA: 0x36C0EA0 Offset: 0x36C0FA1 VA: 0x36C0EA0
	|-Stack<SequenceNode.SequenceConstructPosContext>.Clear
	|
	|-RVA: 0x36C1860 Offset: 0x36C1961 VA: 0x36C1860
	|-Stack<Stream.Info>.Clear
	*/

	// RVA: -1 Offset: -1
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36BB7F0 Offset: 0x36BB8F1 VA: 0x36BB7F0
	|-Stack<Color>.Contains
	|
	|-RVA: 0x36BC070 Offset: 0x36BC171 VA: 0x36BC070
	|-Stack<int>.Contains
	|
	|-RVA: 0x36BC8C0 Offset: 0x36BC9C1 VA: 0x36BC8C0
	|-Stack<Int32Enum>.Contains
	|
	|-RVA: 0x36BD140 Offset: 0x36BD241 VA: 0x36BD140
	|-Stack<object>.Contains
	|-Stack<string>.Contains
	|
	|-RVA: 0x36BD9A0 Offset: 0x36BDAA1 VA: 0x36BD9A0
	|-Stack<RandomSeed>.Contains
	|
	|-RVA: 0x36BE200 Offset: 0x36BE301 VA: 0x36BE200
	|-Stack<float>.Contains
	|
	|-RVA: 0x36BEA50 Offset: 0x36BEB51 VA: 0x36BEA50
	|-Stack<uint>.Contains
	|
	|-RVA: 0x36BF2A0 Offset: 0x36BF3A1 VA: 0x36BF2A0
	|-Stack<DynamicMesh.State>.Contains
	|
	|-RVA: 0x36BFB20 Offset: 0x36BFC21 VA: 0x36BFB20
	|-Stack<MapMind.Record>.Contains
	|
	|-RVA: 0x36C0590 Offset: 0x36C0691 VA: 0x36C0590
	|-Stack<QualitySettingsStack.Settings>.Contains
	|
	|-RVA: 0x36C0EE0 Offset: 0x36C0FE1 VA: 0x36C0EE0
	|-Stack<SequenceNode.SequenceConstructPosContext>.Contains
	|
	|-RVA: 0x36C1870 Offset: 0x36C1971 VA: 0x36C1870
	|-Stack<Stream.Info>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36BB840 Offset: 0x36BB941 VA: 0x36BB840
	|-Stack<Color>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x36BC0C0 Offset: 0x36BC1C1 VA: 0x36BC0C0
	|-Stack<int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x36BC910 Offset: 0x36BCA11 VA: 0x36BC910
	|-Stack<Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x36BD190 Offset: 0x36BD291 VA: 0x36BD190
	|-Stack<object>.System.Collections.ICollection.CopyTo
	|-Stack<CalculatorManager.CommandStack>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x36BD9F0 Offset: 0x36BDAF1 VA: 0x36BD9F0
	|-Stack<RandomSeed>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x36BE250 Offset: 0x36BE351 VA: 0x36BE250
	|-Stack<float>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x36BEAA0 Offset: 0x36BEBA1 VA: 0x36BEAA0
	|-Stack<uint>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x36BF2F0 Offset: 0x36BF3F1 VA: 0x36BF2F0
	|-Stack<DynamicMesh.State>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x36BFBE0 Offset: 0x36BFCE1 VA: 0x36BFBE0
	|-Stack<MapMind.Record>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x36C0610 Offset: 0x36C0711 VA: 0x36C0610
	|-Stack<QualitySettingsStack.Settings>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x36C0F60 Offset: 0x36C1061 VA: 0x36C0F60
	|-Stack<SequenceNode.SequenceConstructPosContext>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x36C18C0 Offset: 0x36C19C1 VA: 0x36C18C0
	|-Stack<Stream.Info>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1
	public Stack.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36BBAF0 Offset: 0x36BBBF1 VA: 0x36BBAF0
	|-Stack<Color>.GetEnumerator
	|
	|-RVA: 0x36BD440 Offset: 0x36BD541 VA: 0x36BD440
	|-Stack<GameObject>.GetEnumerator
	|-Stack<MapInspector>.GetEnumerator
	|-Stack<object>.GetEnumerator
	|
	|-RVA: 0x36BC370 Offset: 0x36BC471 VA: 0x36BC370
	|-Stack<int>.GetEnumerator
	|
	|-RVA: 0x36BCBC0 Offset: 0x36BCCC1 VA: 0x36BCBC0
	|-Stack<Int32Enum>.GetEnumerator
	|-Stack<UnitInfo.Mode>.GetEnumerator
	|
	|-RVA: 0x36BDCA0 Offset: 0x36BDDA1 VA: 0x36BDCA0
	|-Stack<RandomSeed>.GetEnumerator
	|
	|-RVA: 0x36BE500 Offset: 0x36BE601 VA: 0x36BE500
	|-Stack<float>.GetEnumerator
	|
	|-RVA: 0x36BED50 Offset: 0x36BEE51 VA: 0x36BED50
	|-Stack<uint>.GetEnumerator
	|
	|-RVA: 0x36BF5A0 Offset: 0x36BF6A1 VA: 0x36BF5A0
	|-Stack<DynamicMesh.State>.GetEnumerator
	|
	|-RVA: 0x36BFE90 Offset: 0x36BFF91 VA: 0x36BFE90
	|-Stack<MapMind.Record>.GetEnumerator
	|
	|-RVA: 0x36C08C0 Offset: 0x36C09C1 VA: 0x36C08C0
	|-Stack<QualitySettingsStack.Settings>.GetEnumerator
	|
	|-RVA: 0x36C1210 Offset: 0x36C1311 VA: 0x36C1210
	|-Stack<SequenceNode.SequenceConstructPosContext>.GetEnumerator
	|
	|-RVA: 0x36C1B70 Offset: 0x36C1C71 VA: 0x36C1B70
	|-Stack<Stream.Info>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36BBB50 Offset: 0x36BBC51 VA: 0x36BBB50
	|-Stack<Color>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x36BC3D0 Offset: 0x36BC4D1 VA: 0x36BC3D0
	|-Stack<int>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x36BCC20 Offset: 0x36BCD21 VA: 0x36BCC20
	|-Stack<Int32Enum>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x36BD4A0 Offset: 0x36BD5A1 VA: 0x36BD4A0
	|-Stack<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|-Stack<CalculatorManager.CommandStack>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x36BDD00 Offset: 0x36BDE01 VA: 0x36BDD00
	|-Stack<RandomSeed>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x36BE560 Offset: 0x36BE661 VA: 0x36BE560
	|-Stack<float>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x36BEDB0 Offset: 0x36BEEB1 VA: 0x36BEDB0
	|-Stack<uint>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x36BF600 Offset: 0x36BF701 VA: 0x36BF600
	|-Stack<DynamicMesh.State>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x36BFF20 Offset: 0x36C0021 VA: 0x36BFF20
	|-Stack<MapMind.Record>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x36C0930 Offset: 0x36C0A31 VA: 0x36C0930
	|-Stack<QualitySettingsStack.Settings>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x36C1280 Offset: 0x36C1381 VA: 0x36C1280
	|-Stack<SequenceNode.SequenceConstructPosContext>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x36C1BD0 Offset: 0x36C1CD1 VA: 0x36C1BD0
	|-Stack<Stream.Info>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36BBBD0 Offset: 0x36BBCD1 VA: 0x36BBBD0
	|-Stack<Color>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x36BC450 Offset: 0x36BC551 VA: 0x36BC450
	|-Stack<int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x36BCCA0 Offset: 0x36BCDA1 VA: 0x36BCCA0
	|-Stack<Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x36BD520 Offset: 0x36BD621 VA: 0x36BD520
	|-Stack<object>.System.Collections.IEnumerable.GetEnumerator
	|-Stack<CalculatorManager.CommandStack>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x36BDD80 Offset: 0x36BDE81 VA: 0x36BDD80
	|-Stack<RandomSeed>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x36BE5E0 Offset: 0x36BE6E1 VA: 0x36BE5E0
	|-Stack<float>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x36BEE30 Offset: 0x36BEF31 VA: 0x36BEE30
	|-Stack<uint>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x36BF680 Offset: 0x36BF781 VA: 0x36BF680
	|-Stack<DynamicMesh.State>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x36BFFD0 Offset: 0x36C00D1 VA: 0x36BFFD0
	|-Stack<MapMind.Record>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x36C09C0 Offset: 0x36C0AC1 VA: 0x36C09C0
	|-Stack<QualitySettingsStack.Settings>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x36C1320 Offset: 0x36C1421 VA: 0x36C1320
	|-Stack<SequenceNode.SequenceConstructPosContext>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x36C1C50 Offset: 0x36C1D51 VA: 0x36C1C50
	|-Stack<Stream.Info>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public T Peek() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36BBC50 Offset: 0x36BBD51 VA: 0x36BBC50
	|-Stack<Color>.Peek
	|
	|-RVA: 0x36BD5A0 Offset: 0x36BD6A1 VA: 0x36BD5A0
	|-Stack<EventScript>.Peek
	|-Stack<HubManualCulling>.Peek
	|-Stack<object>.Peek
	|-Stack<ParameterExpression>.Peek
	|-Stack<DtdParser.ParseElementOnlyContent_LocalFrame>.Peek
	|
	|-RVA: 0x36BC4D0 Offset: 0x36BC5D1 VA: 0x36BC4D0
	|-Stack<int>.Peek
	|
	|-RVA: 0x36BCD20 Offset: 0x36BCE21 VA: 0x36BCD20
	|-Stack<Int32Enum>.Peek
	|-Stack<UnitInfo.Mode>.Peek
	|
	|-RVA: 0x36BDE00 Offset: 0x36BDF01 VA: 0x36BDE00
	|-Stack<RandomSeed>.Peek
	|
	|-RVA: 0x36BE660 Offset: 0x36BE761 VA: 0x36BE660
	|-Stack<float>.Peek
	|
	|-RVA: 0x36BEEB0 Offset: 0x36BEFB1 VA: 0x36BEEB0
	|-Stack<uint>.Peek
	|
	|-RVA: 0x36BF700 Offset: 0x36BF801 VA: 0x36BF700
	|-Stack<DynamicMesh.State>.Peek
	|
	|-RVA: 0x36C0080 Offset: 0x36C0181 VA: 0x36C0080
	|-Stack<MapMind.Record>.Peek
	|
	|-RVA: 0x36C0A50 Offset: 0x36C0B51 VA: 0x36C0A50
	|-Stack<QualitySettingsStack.Settings>.Peek
	|
	|-RVA: 0x36C13C0 Offset: 0x36C14C1 VA: 0x36C13C0
	|-Stack<SequenceNode.SequenceConstructPosContext>.Peek
	|
	|-RVA: 0x36C1CD0 Offset: 0x36C1DD1 VA: 0x36C1CD0
	|-Stack<Stream.Info>.Peek
	*/

	// RVA: -1 Offset: -1
	public T Pop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36BD610 Offset: 0x36BD711 VA: 0x36BD610
	|-Stack<Dictionary<string, int>>.Pop
	|-Stack<HashSet<ParameterExpression>>.Pop
	|-Stack<LinkedListNode<DelayedActionManager.DelegateInfo>>.Pop
	|-Stack<Stack<ResourceHandle>>.Pop
	|-Stack<string[]>.Pop
	|-Stack<AssetBundleLocalResource>.Pop
	|-Stack<BattleCalculator>.Pop
	|-Stack<EventScript>.Pop
	|-Stack<GameObject>.Pop
	|-Stack<HubManualCulling>.Pop
	|-Stack<InteriorNode>.Pop
	|-Stack<MapInspector>.Pop
	|-Stack<object>.Pop
	|-Stack<ParameterExpression>.Pop
	|-Stack<ResourceHandle>.Pop
	|-Stack<string>.Pop
	|-Stack<CalculatorManager.CommandStack>.Pop
	|-Stack<DtdParser.ParseElementOnlyContent_LocalFrame>.Pop
	|-Stack<MapDispos.Pos>.Pop
	|-Stack<MapTarget.Data>.Pop
	|
	|-RVA: 0x36BBCC0 Offset: 0x36BBDC1 VA: 0x36BBCC0
	|-Stack<Color>.Pop
	|
	|-RVA: 0x36BC540 Offset: 0x36BC641 VA: 0x36BC540
	|-Stack<int>.Pop
	|
	|-RVA: 0x36BCD90 Offset: 0x36BCE91 VA: 0x36BCD90
	|-Stack<Int32Enum>.Pop
	|-Stack<Fade.Layer>.Pop
	|-Stack<GameSkip.Status>.Pop
	|-Stack<MiniMapController.Mode>.Pop
	|-Stack<UnitInfo.Mode>.Pop
	|-Stack<ViewMode.Mode>.Pop
	|
	|-RVA: 0x36BDE70 Offset: 0x36BDF71 VA: 0x36BDE70
	|-Stack<RandomSeed>.Pop
	|
	|-RVA: 0x36BE6D0 Offset: 0x36BE7D1 VA: 0x36BE6D0
	|-Stack<float>.Pop
	|
	|-RVA: 0x36BEF20 Offset: 0x36BF021 VA: 0x36BEF20
	|-Stack<uint>.Pop
	|
	|-RVA: 0x36BF770 Offset: 0x36BF871 VA: 0x36BF770
	|-Stack<DynamicMesh.State>.Pop
	|
	|-RVA: 0x36C0120 Offset: 0x36C0221 VA: 0x36C0120
	|-Stack<MapMind.Record>.Pop
	|
	|-RVA: 0x36C0AE0 Offset: 0x36C0BE1 VA: 0x36C0AE0
	|-Stack<QualitySettingsStack.Settings>.Pop
	|
	|-RVA: 0x36C1450 Offset: 0x36C1551 VA: 0x36C1450
	|-Stack<SequenceNode.SequenceConstructPosContext>.Pop
	|
	|-RVA: 0x36C1D50 Offset: 0x36C1E51 VA: 0x36C1D50
	|-Stack<Stream.Info>.Pop
	*/

	// RVA: -1 Offset: -1
	public void Push(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36BD6A0 Offset: 0x36BD7A1 VA: 0x36BD6A0
	|-Stack<Dictionary<string, int>>.Push
	|-Stack<HashSet<ParameterExpression>>.Push
	|-Stack<LinkedListNode<DelayedActionManager.DelegateInfo>>.Push
	|-Stack<Stack<ResourceHandle>>.Push
	|-Stack<string[]>.Push
	|-Stack<AssetBundleLocalResource>.Push
	|-Stack<BattleCalculator>.Push
	|-Stack<EventScript>.Push
	|-Stack<GameObject>.Push
	|-Stack<HubManualCulling>.Push
	|-Stack<InteriorNode>.Push
	|-Stack<MapInspector>.Push
	|-Stack<object>.Push
	|-Stack<ParameterExpression>.Push
	|-Stack<ResourceHandle>.Push
	|-Stack<string>.Push
	|-Stack<CalculatorManager.CommandStack>.Push
	|-Stack<DtdParser.ParseElementOnlyContent_LocalFrame>.Push
	|-Stack<MapDispos.Pos>.Push
	|-Stack<MapTarget.Data>.Push
	|
	|-RVA: 0x36BBD40 Offset: 0x36BBE41 VA: 0x36BBD40
	|-Stack<Color>.Push
	|
	|-RVA: 0x36BC5C0 Offset: 0x36BC6C1 VA: 0x36BC5C0
	|-Stack<int>.Push
	|
	|-RVA: 0x36BCE10 Offset: 0x36BCF11 VA: 0x36BCE10
	|-Stack<Int32Enum>.Push
	|-Stack<Fade.Layer>.Push
	|-Stack<GameSkip.Status>.Push
	|-Stack<MiniMapController.Mode>.Push
	|-Stack<UnitInfo.Mode>.Push
	|-Stack<ViewMode.Mode>.Push
	|
	|-RVA: 0x36BDEF0 Offset: 0x36BDFF1 VA: 0x36BDEF0
	|-Stack<RandomSeed>.Push
	|
	|-RVA: 0x36BE750 Offset: 0x36BE851 VA: 0x36BE750
	|-Stack<float>.Push
	|
	|-RVA: 0x36BEFA0 Offset: 0x36BF0A1 VA: 0x36BEFA0
	|-Stack<uint>.Push
	|
	|-RVA: 0x36BF7F0 Offset: 0x36BF8F1 VA: 0x36BF7F0
	|-Stack<DynamicMesh.State>.Push
	|
	|-RVA: 0x36C0230 Offset: 0x36C0331 VA: 0x36C0230
	|-Stack<MapMind.Record>.Push
	|
	|-RVA: 0x36C0B80 Offset: 0x36C0C81 VA: 0x36C0B80
	|-Stack<QualitySettingsStack.Settings>.Push
	|
	|-RVA: 0x36C1530 Offset: 0x36C1631 VA: 0x36C1530
	|-Stack<SequenceNode.SequenceConstructPosContext>.Push
	|
	|-RVA: 0x36C1DE0 Offset: 0x36C1EE1 VA: 0x36C1DE0
	|-Stack<Stream.Info>.Push
	*/

	// RVA: -1 Offset: -1
	private void ThrowForEmptyStack() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x36BBE10 Offset: 0x36BBF11 VA: 0x36BBE10
	|-Stack<Color>.ThrowForEmptyStack
	|
	|-RVA: 0x36BC660 Offset: 0x36BC761 VA: 0x36BC660
	|-Stack<int>.ThrowForEmptyStack
	|
	|-RVA: 0x36BCEB0 Offset: 0x36BCFB1 VA: 0x36BCEB0
	|-Stack<Int32Enum>.ThrowForEmptyStack
	|
	|-RVA: 0x36BD740 Offset: 0x36BD841 VA: 0x36BD740
	|-Stack<object>.ThrowForEmptyStack
	|
	|-RVA: 0x36BDFA0 Offset: 0x36BE0A1 VA: 0x36BDFA0
	|-Stack<RandomSeed>.ThrowForEmptyStack
	|
	|-RVA: 0x36BE7F0 Offset: 0x36BE8F1 VA: 0x36BE7F0
	|-Stack<float>.ThrowForEmptyStack
	|
	|-RVA: 0x36BF040 Offset: 0x36BF141 VA: 0x36BF040
	|-Stack<uint>.ThrowForEmptyStack
	|
	|-RVA: 0x36BF890 Offset: 0x36BF991 VA: 0x36BF890
	|-Stack<DynamicMesh.State>.ThrowForEmptyStack
	|
	|-RVA: 0x36C0330 Offset: 0x36C0431 VA: 0x36C0330
	|-Stack<MapMind.Record>.ThrowForEmptyStack
	|
	|-RVA: 0x36C0C50 Offset: 0x36C0D51 VA: 0x36C0C50
	|-Stack<QualitySettingsStack.Settings>.ThrowForEmptyStack
	|
	|-RVA: 0x36C1610 Offset: 0x36C1711 VA: 0x36C1610
	|-Stack<SequenceNode.SequenceConstructPosContext>.ThrowForEmptyStack
	|
	|-RVA: 0x36C1E90 Offset: 0x36C1F91 VA: 0x36C1E90
	|-Stack<Stream.Info>.ThrowForEmptyStack
	*/
}

