// Namespace: System
public abstract class Array : ICollection, IEnumerable, IList, IStructuralComparable, IStructuralEquatable, ICloneable // TypeDefIndex: 119
{
	// Properties
	private int System.Collections.ICollection.Count { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private object System.Collections.IList.Item { get; set; }
	public long LongLength { get; }
	public bool IsFixedSize { get; }
	public bool IsReadOnly { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }
	public int Length { get; }
	public int Rank { get; }

	// Methods

	// RVA: 0x355FD40 Offset: 0x355FE41 VA: 0x355FD40
	public static Array CreateInstance(Type elementType, long[] lengths) { }

	// RVA: -1 Offset: -1
	public static ReadOnlyCollection<T> AsReadOnly<T>(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3280BD0 Offset: 0x3280CD1 VA: 0x3280BD0
	|-Array.AsReadOnly<CustomAttributeData>
	|-Array.AsReadOnly<object>
	|-Array.AsReadOnly<AIOrder.Func>
	|
	|-RVA: 0x3280A70 Offset: 0x3280B71 VA: 0x3280A70
	|-Array.AsReadOnly<CustomAttributeNamedArgument>
	|
	|-RVA: 0x3280B20 Offset: 0x3280C21 VA: 0x3280B20
	|-Array.AsReadOnly<CustomAttributeTypedArgument>
	|
	|-RVA: 0x3280C80 Offset: 0x3280D81 VA: 0x3280C80
	|-Array.AsReadOnly<AICrossfire.PositionTable>
	*/

	// RVA: -1 Offset: -1
	public static void Resize<T>(ref T[] array, int newSize) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FB6F70 Offset: 0x2FB7071 VA: 0x2FB6F70
	|-Array.Resize<TimeInterval<object>>
	|
	|-RVA: 0x2FB70A0 Offset: 0x2FB71A1 VA: 0x2FB70A0
	|-Array.Resize<Timestamped<object>>
	|
	|-RVA: 0x2FB71D0 Offset: 0x2FB72D1 VA: 0x2FB71D0
	|-Array.Resize<ValueTuple<object, float>>
	|
	|-RVA: 0x2FB7300 Offset: 0x2FB7401 VA: 0x2FB7300
	|-Array.Resize<AsyncOperationHandle>
	|
	|-RVA: 0x2FB7DB0 Offset: 0x2FB7EB1 VA: 0x2FB7DB0
	|-Array.Resize<BakerTransform>
	|-Array.Resize<Camera>
	|-Array.Resize<Finger>
	|-Array.Resize<IEnumerator>
	|-Array.Resize<IPlayerLoopItem>
	|-Array.Resize<object>
	|-Array.Resize<RTHandle>
	|-Array.Resize<TMP_SubMesh>
	|-Array.Resize<TMP_SubMeshUI>
	|-Array.Resize<Texture2D>
	|-Array.Resize<Transform>
	|-Array.Resize<Type>
	|-Array.Resize<GenericPoser.Map>
	|-Array.Resize<IKSolver.Point>
	|
	|-RVA: 0x2FB7430 Offset: 0x2FB7531 VA: 0x2FB7430
	|-Array.Resize<char>
	|
	|-RVA: 0x2FB7560 Offset: 0x2FB7661 VA: 0x2FB7560
	|-Array.Resize<Color>
	|
	|-RVA: 0x2FB7690 Offset: 0x2FB7791 VA: 0x2FB7690
	|-Array.Resize<Color32>
	|
	|-RVA: 0x2FB77C0 Offset: 0x2FB78C1 VA: 0x2FB77C0
	|-Array.Resize<GlyphPairAdjustmentRecord>
	|
	|-RVA: 0x2FB78F0 Offset: 0x2FB79F1 VA: 0x2FB78F0
	|-Array.Resize<HighlightState>
	|
	|-RVA: 0x2FB7A20 Offset: 0x2FB7B21 VA: 0x2FB7A20
	|-Array.Resize<int>
	|
	|-RVA: 0x2FB7B50 Offset: 0x2FB7C51 VA: 0x2FB7B50
	|-Array.Resize<Int32Enum>
	|
	|-RVA: 0x2FB7C80 Offset: 0x2FB7D81 VA: 0x2FB7C80
	|-Array.Resize<MaterialReference>
	|
	|-RVA: 0x2FB7EE0 Offset: 0x2FB7FE1 VA: 0x2FB7EE0
	|-Array.Resize<RandomSeed>
	|
	|-RVA: 0x2FB8010 Offset: 0x2FB8111 VA: 0x2FB8010
	|-Array.Resize<float>
	|
	|-RVA: 0x2FB8140 Offset: 0x2FB8241 VA: 0x2FB8140
	|-Array.Resize<TMP_CharacterInfo>
	|
	|-RVA: 0x2FB8270 Offset: 0x2FB8371 VA: 0x2FB8270
	|-Array.Resize<TMP_LinkInfo>
	|
	|-RVA: 0x2FB83A0 Offset: 0x2FB84A1 VA: 0x2FB83A0
	|-Array.Resize<TMP_MeshInfo>
	|
	|-RVA: 0x2FB84D0 Offset: 0x2FB85D1 VA: 0x2FB84D0
	|-Array.Resize<TMP_PageInfo>
	|
	|-RVA: 0x2FB8600 Offset: 0x2FB8701 VA: 0x2FB8600
	|-Array.Resize<TMP_WordInfo>
	|
	|-RVA: 0x2FB8730 Offset: 0x2FB8831 VA: 0x2FB8730
	|-Array.Resize<uint>
	|
	|-RVA: 0x2FB8860 Offset: 0x2FB8961 VA: 0x2FB8860
	|-Array.Resize<Vector2>
	|
	|-RVA: 0x2FB8990 Offset: 0x2FB8A91 VA: 0x2FB8990
	|-Array.Resize<Vector3>
	|
	|-RVA: 0x2FB8AC0 Offset: 0x2FB8BC1 VA: 0x2FB8AC0
	|-Array.Resize<Vector4>
	|
	|-RVA: 0x2FB8BF0 Offset: 0x2FB8CF1 VA: 0x2FB8BF0
	|-Array.Resize<WordWrapState>
	|
	|-RVA: 0x2FB8D20 Offset: 0x2FB8E21 VA: 0x2FB8D20
	|-Array.Resize<DynamicMesh.State>
	|
	|-RVA: 0x2FB8E50 Offset: 0x2FB8F51 VA: 0x2FB8E50
	|-Array.Resize<MapMind.Record>
	|
	|-RVA: 0x2FB8F80 Offset: 0x2FB9081 VA: 0x2FB8F80
	|-Array.Resize<QualitySettingsStack.Settings>
	|
	|-RVA: 0x2FB90B0 Offset: 0x2FB91B1 VA: 0x2FB90B0
	|-Array.Resize<SequenceNode.SequenceConstructPosContext>
	|
	|-RVA: 0x2FB91E0 Offset: 0x2FB92E1 VA: 0x2FB91E0
	|-Array.Resize<Stream.Info>
	|
	|-RVA: 0x2FB9310 Offset: 0x2FB9411 VA: 0x2FB9310
	|-Array.Resize<TMP_Text.UnicodeChar>
	*/

	// RVA: 0x3560180 Offset: 0x3560281 VA: 0x3560180 Slot: 5
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x3560260 Offset: 0x3560361 VA: 0x3560260 Slot: 14
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x3560270 Offset: 0x3560371 VA: 0x3560270 Slot: 9
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x35603F0 Offset: 0x35604F1 VA: 0x35603F0 Slot: 10
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x3560580 Offset: 0x3560681 VA: 0x3560580 Slot: 11
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x35605E0 Offset: 0x35606E1 VA: 0x35605E0 Slot: 12
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x35606E0 Offset: 0x35607E1 VA: 0x35606E0 Slot: 13
	private void System.Collections.IList.Clear() { }

	// RVA: 0x3560780 Offset: 0x3560881 VA: 0x3560780 Slot: 15
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x3560790 Offset: 0x3560891 VA: 0x3560790 Slot: 16
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x35607F0 Offset: 0x35608F1 VA: 0x35607F0 Slot: 17
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x3560850 Offset: 0x3560951 VA: 0x3560850 Slot: 18
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x35608B0 Offset: 0x35609B1 VA: 0x35608B0 Slot: 4
	public void CopyTo(Array array, int index) { }

	// RVA: 0x35544D0 Offset: 0x35545D1 VA: 0x35544D0 Slot: 22
	public object Clone() { }

	// RVA: 0x3560F30 Offset: 0x3561031 VA: 0x3560F30 Slot: 19
	private int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }

	// RVA: 0x35611C0 Offset: 0x35612C1 VA: 0x35611C0 Slot: 20
	private bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }

	// RVA: 0x3561410 Offset: 0x3561511 VA: 0x3561410
	internal static int CombineHashCodes(int h1, int h2) { }

	// RVA: 0x3561420 Offset: 0x3561521 VA: 0x3561420 Slot: 21
	private int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }

	// RVA: 0x3561650 Offset: 0x3561751 VA: 0x3561650
	public static int BinarySearch(Array array, object value) { }

	// RVA: -1 Offset: -1
	public static TOutput[] ConvertAll<TInput, TOutput>(TInput[] array, Converter<TInput, TOutput> converter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x328C4F0 Offset: 0x328C5F1 VA: 0x328C4F0
	|-Array.ConvertAll<object, object>
	*/

	// RVA: 0x3561C10 Offset: 0x3561D11 VA: 0x3561C10
	public static void Copy(Array sourceArray, Array destinationArray, long length) { }

	// RVA: 0x3561D50 Offset: 0x3561E51 VA: 0x3561D50
	public static void Copy(Array sourceArray, long sourceIndex, Array destinationArray, long destinationIndex, long length) { }

	// RVA: 0x3561E20 Offset: 0x3561F21 VA: 0x3561E20
	public void CopyTo(Array array, long index) { }

	// RVA: -1 Offset: -1
	public static void ForEach<T>(T[] array, Action<T> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x328E060 Offset: 0x328E161 VA: 0x328E060
	|-Array.ForEach<object>
	*/

	// RVA: 0x3561E90 Offset: 0x3561F91 VA: 0x3561E90
	public long get_LongLength() { }

	// RVA: 0x3561F10 Offset: 0x3562011 VA: 0x3561F10
	public long GetLongLength(int dimension) { }

	// RVA: 0x3561F30 Offset: 0x3562031 VA: 0x3561F30
	public object GetValue(long index) { }

	// RVA: 0x3561FA0 Offset: 0x35620A1 VA: 0x3561FA0
	public object GetValue(long index1, long index2) { }

	// RVA: 0x35620E0 Offset: 0x35621E1 VA: 0x35620E0
	public object GetValue(long index1, long index2, long index3) { }

	// RVA: 0x3562260 Offset: 0x3562361 VA: 0x3562260
	public object GetValue(long[] indices) { }

	// RVA: 0x3562400 Offset: 0x3562501 VA: 0x3562400 Slot: 23
	public bool get_IsFixedSize() { }

	// RVA: 0x3562410 Offset: 0x3562511 VA: 0x3562410 Slot: 24
	public bool get_IsReadOnly() { }

	// RVA: 0x3562420 Offset: 0x3562521 VA: 0x3562420 Slot: 7
	public bool get_IsSynchronized() { }

	// RVA: 0x3562430 Offset: 0x3562531 VA: 0x3562430 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x3562440 Offset: 0x3562541 VA: 0x3562440
	public static int BinarySearch(Array array, int index, int length, object value) { }

	// RVA: 0x3562450 Offset: 0x3562551 VA: 0x3562450
	public static int BinarySearch(Array array, object value, IComparer comparer) { }

	// RVA: 0x3561730 Offset: 0x3561831 VA: 0x3561730
	public static int BinarySearch(Array array, int index, int length, object value, IComparer comparer) { }

	// RVA: 0x3562540 Offset: 0x3562641 VA: 0x3562540
	private static int GetMedian(int low, int hi) { }

	// RVA: -1 Offset: -1
	public static int BinarySearch<T>(T[] array, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3280D30 Offset: 0x3280E31 VA: 0x3280D30
	|-Array.BinarySearch<object>
	|-Array.BinarySearch<string>
	|
	|-RVA: 0x3280DB0 Offset: 0x3280EB1 VA: 0x3280DB0
	|-Array.BinarySearch<ulong>
	*/

	// RVA: -1 Offset: -1
	public static int BinarySearch<T>(T[] array, T value, IComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3280E30 Offset: 0x3280F31 VA: 0x3280E30
	|-Array.BinarySearch<DebugInfo>
	|-Array.BinarySearch<object>
	*/

	// RVA: -1 Offset: -1
	public static int BinarySearch<T>(T[] array, int index, int length, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3280EC0 Offset: 0x3280FC1 VA: 0x3280EC0
	|-Array.BinarySearch<object>
	*/

	// RVA: -1 Offset: -1
	public static int BinarySearch<T>(T[] array, int index, int length, T value, IComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3280EE0 Offset: 0x3280FE1 VA: 0x3280EE0
	|-Array.BinarySearch<IntervalTree.Entry<object>>
	|
	|-RVA: 0x3281030 Offset: 0x3281131 VA: 0x3281030
	|-Array.BinarySearch<KeyValuePair<DateTime, object>>
	|
	|-RVA: 0x3281160 Offset: 0x3281261 VA: 0x3281160
	|-Array.BinarySearch<KeyValuePair<int, object>>
	|
	|-RVA: 0x3281290 Offset: 0x3281391 VA: 0x3281290
	|-Array.BinarySearch<KeyValuePair<object, ValueTuple<int, DateTime, object>>>
	|
	|-RVA: 0x32813F0 Offset: 0x32814F1 VA: 0x32813F0
	|-Array.BinarySearch<KeyValuePair<object, object>>
	|
	|-RVA: 0x3281520 Offset: 0x3281621 VA: 0x3281520
	|-Array.BinarySearch<CommonBattleSequence.Reliance<object>>
	|
	|-RVA: 0x3281670 Offset: 0x3281771 VA: 0x3281670
	|-Array.BinarySearch<RenderGraphResourcePool.ResourceLogInfo<object>>
	|
	|-RVA: 0x32817A0 Offset: 0x32818A1 VA: 0x32817A0
	|-Array.BinarySearch<ValueTuple<int, object>>
	|
	|-RVA: 0x32818D0 Offset: 0x32819D1 VA: 0x32818D0
	|-Array.BinarySearch<ValueTuple<Int32Enum, int>>
	|
	|-RVA: 0x3281A00 Offset: 0x3281B01 VA: 0x3281A00
	|-Array.BinarySearch<ValueTuple<object, ValueTuple<object, int>>>
	|
	|-RVA: 0x3281B50 Offset: 0x3281C51 VA: 0x3281B50
	|-Array.BinarySearch<ValueTuple<object, int>>
	|
	|-RVA: 0x3281C80 Offset: 0x3281D81 VA: 0x3281C80
	|-Array.BinarySearch<ValueTuple<Vector3, float>>
	|
	|-RVA: 0x3281DB0 Offset: 0x3281EB1 VA: 0x3281DB0
	|-Array.BinarySearch<ValueTuple<object, Int32Enum, int>>
	|
	|-RVA: 0x3281EE0 Offset: 0x3281FE1 VA: 0x3281EE0
	|-Array.BinarySearch<ValueTuple<object, int, int, int>>
	|
	|-RVA: 0x3282030 Offset: 0x3282131 VA: 0x3282030
	|-Array.BinarySearch<AnimatorClipInfo>
	|
	|-RVA: 0x3282160 Offset: 0x3282261 VA: 0x3282160
	|-Array.BinarySearch<AsyncOperationHandle>
	|
	|-RVA: 0x32822B0 Offset: 0x32823B1 VA: 0x32822B0
	|-Array.BinarySearch<BoneWeight>
	|
	|-RVA: 0x3282410 Offset: 0x3282511 VA: 0x3282410
	|-Array.BinarySearch<bool>
	|
	|-RVA: 0x3282540 Offset: 0x3282641 VA: 0x3282540
	|-Array.BinarySearch<byte>
	|
	|-RVA: 0x3282670 Offset: 0x3282771 VA: 0x3282670
	|-Array.BinarySearch<CameraInfo>
	|
	|-RVA: 0x32827A0 Offset: 0x32828A1 VA: 0x32827A0
	|-Array.BinarySearch<char>
	|
	|-RVA: 0x32828D0 Offset: 0x32829D1 VA: 0x32828D0
	|-Array.BinarySearch<Color>
	|
	|-RVA: 0x3282A00 Offset: 0x3282B01 VA: 0x3282A00
	|-Array.BinarySearch<Color32>
	|
	|-RVA: 0x3282B30 Offset: 0x3282C31 VA: 0x3282B30
	|-Array.BinarySearch<ConstraintSource>
	|
	|-RVA: 0x3282C60 Offset: 0x3282D61 VA: 0x3282C60
	|-Array.BinarySearch<ContourVertex>
	|
	|-RVA: 0x3282DB0 Offset: 0x3282EB1 VA: 0x3282DB0
	|-Array.BinarySearch<DataStoreRatingInfo>
	|
	|-RVA: 0x3282F00 Offset: 0x3283001 VA: 0x3282F00
	|-Array.BinarySearch<DataStoreResult>
	|
	|-RVA: 0x3283030 Offset: 0x3283131 VA: 0x3283030
	|-Array.BinarySearch<DateTime>
	|
	|-RVA: 0x3283160 Offset: 0x3283261 VA: 0x3283160
	|-Array.BinarySearch<DateTimeOffset>
	|
	|-RVA: 0x3283290 Offset: 0x3283391 VA: 0x3283290
	|-Array.BinarySearch<Decimal>
	|
	|-RVA: 0x32833C0 Offset: 0x32834C1 VA: 0x32833C0
	|-Array.BinarySearch<DiagnosticEvent>
	|
	|-RVA: 0x3283520 Offset: 0x3283621 VA: 0x3283520
	|-Array.BinarySearch<double>
	|
	|-RVA: 0x3283650 Offset: 0x3283751 VA: 0x3283650
	|-Array.BinarySearch<Friend>
	|
	|-RVA: 0x32837F0 Offset: 0x32838F1 VA: 0x32837F0
	|-Array.BinarySearch<GlyphRect>
	|
	|-RVA: 0x3283920 Offset: 0x3283A21 VA: 0x3283920
	|-Array.BinarySearch<short>
	|
	|-RVA: 0x3283A50 Offset: 0x3283B51 VA: 0x3283A50
	|-Array.BinarySearch<int>
	|
	|-RVA: 0x3283B80 Offset: 0x3283C81 VA: 0x3283B80
	|-Array.BinarySearch<Int32Enum>
	|
	|-RVA: 0x3283CB0 Offset: 0x3283DB1 VA: 0x3283CB0
	|-Array.BinarySearch<long>
	|
	|-RVA: 0x3283DE0 Offset: 0x3283EE1 VA: 0x3283DE0
	|-Array.BinarySearch<IntPtr>
	|
	|-RVA: 0x3283F10 Offset: 0x3284011 VA: 0x3283F10
	|-Array.BinarySearch<InterpretedFrameInfo>
	|
	|-RVA: 0x3284040 Offset: 0x3284141 VA: 0x3284040
	|-Array.BinarySearch<IntervalTreeNode>
	|
	|-RVA: 0x3284190 Offset: 0x3284291 VA: 0x3284190
	|-Array.BinarySearch<LengthLimitProperties>
	|
	|-RVA: 0x32842C0 Offset: 0x32843C1 VA: 0x32842C0
	|-Array.BinarySearch<MapPos>
	|
	|-RVA: 0x32843F0 Offset: 0x32844F1 VA: 0x32843F0
	|-Array.BinarySearch<Matrix4x4>
	|
	|-RVA: 0x3284570 Offset: 0x3284671 VA: 0x3284570
	|-Array.BinarySearch<object>
	|
	|-RVA: 0x32846A0 Offset: 0x32847A1 VA: 0x32846A0
	|-Array.BinarySearch<ObjectInitializationData>
	|
	|-RVA: 0x3284800 Offset: 0x3284901 VA: 0x3284800
	|-Array.BinarySearch<PlayableBinding>
	|
	|-RVA: 0x3284960 Offset: 0x3284A61 VA: 0x3284960
	|-Array.BinarySearch<PlayerLoopSystem>
	|
	|-RVA: 0x3284AC0 Offset: 0x3284BC1 VA: 0x3284AC0
	|-Array.BinarySearch<PlayerLoopSystemInternal>
	|
	|-RVA: 0x3284C20 Offset: 0x3284D21 VA: 0x3284C20
	|-Array.BinarySearch<RangePositionInfo>
	|
	|-RVA: 0x3284D50 Offset: 0x3284E51 VA: 0x3284D50
	|-Array.BinarySearch<Ranking2ChartInfoInput>
	|
	|-RVA: 0x3284E80 Offset: 0x3284F81 VA: 0x3284E80
	|-Array.BinarySearch<RaycastHit2D>
	|
	|-RVA: 0x3284FE0 Offset: 0x32850E1 VA: 0x3284FE0
	|-Array.BinarySearch<RaycastResult>
	|
	|-RVA: 0x3285180 Offset: 0x3285281 VA: 0x3285180
	|-Array.BinarySearch<Rect>
	|
	|-RVA: 0x32852B0 Offset: 0x32853B1 VA: 0x32852B0
	|-Array.BinarySearch<RendererListHandle>
	|
	|-RVA: 0x32853E0 Offset: 0x32854E1 VA: 0x32853E0
	|-Array.BinarySearch<ResourceHandle>
	|
	|-RVA: 0x3285510 Offset: 0x3285611 VA: 0x3285510
	|-Array.BinarySearch<sbyte>
	|
	|-RVA: 0x3285640 Offset: 0x3285741 VA: 0x3285640
	|-Array.BinarySearch<ShaderTagId>
	|
	|-RVA: 0x3285770 Offset: 0x3285871 VA: 0x3285770
	|-Array.BinarySearch<float>
	|
	|-RVA: 0x32858A0 Offset: 0x32859A1 VA: 0x32858A0
	|-Array.BinarySearch<SphericalHarmonicsL2>
	|
	|-RVA: 0x3285A60 Offset: 0x3285B61 VA: 0x3285A60
	|-Array.BinarySearch<SubMeshDescriptor>
	|
	|-RVA: 0x3285BC0 Offset: 0x3285CC1 VA: 0x3285BC0
	|-Array.BinarySearch<TablePair>
	|
	|-RVA: 0x3285CF0 Offset: 0x3285DF1 VA: 0x3285CF0
	|-Array.BinarySearch<TimeSpan>
	|
	|-RVA: 0x3285E20 Offset: 0x3285F21 VA: 0x3285E20
	|-Array.BinarySearch<UICharInfo>
	|
	|-RVA: 0x3285F50 Offset: 0x3286051 VA: 0x3285F50
	|-Array.BinarySearch<UILineInfo>
	|
	|-RVA: 0x3286080 Offset: 0x3286181 VA: 0x3286080
	|-Array.BinarySearch<UIVertex>
	|
	|-RVA: 0x3286240 Offset: 0x3286341 VA: 0x3286240
	|-Array.BinarySearch<ushort>
	|
	|-RVA: 0x3286370 Offset: 0x3286471 VA: 0x3286370
	|-Array.BinarySearch<uint>
	|
	|-RVA: 0x32864A0 Offset: 0x32865A1 VA: 0x32864A0
	|-Array.BinarySearch<ulong>
	|
	|-RVA: 0x32865D0 Offset: 0x32866D1 VA: 0x32865D0
	|-Array.BinarySearch<Vector2>
	|
	|-RVA: 0x3286700 Offset: 0x3286801 VA: 0x3286700
	|-Array.BinarySearch<Vector3>
	|
	|-RVA: 0x3286830 Offset: 0x3286931 VA: 0x3286830
	|-Array.BinarySearch<Vector4>
	|
	|-RVA: 0x3286960 Offset: 0x3286A61 VA: 0x3286960
	|-Array.BinarySearch<VertexAttributeDescriptor>
	|
	|-RVA: 0x3286A90 Offset: 0x3286B91 VA: 0x3286A90
	|-Array.BinarySearch<X509ChainStatus>
	|
	|-RVA: 0x3286BC0 Offset: 0x3286CC1 VA: 0x3286BC0
	|-Array.BinarySearch<XRView>
	|
	|-RVA: 0x3286D60 Offset: 0x3286E61 VA: 0x3286D60
	|-Array.BinarySearch<AmiiboSequence.GainItemData>
	|
	|-RVA: 0x3286E90 Offset: 0x3286F91 VA: 0x3286E90
	|-Array.BinarySearch<AnimationOutputWeightProcessor.WeightInfo>
	|
	|-RVA: 0x3286FF0 Offset: 0x32870F1 VA: 0x3286FF0
	|-Array.BinarySearch<ArenaOrderSequence.GodInfo>
	|
	|-RVA: 0x3287120 Offset: 0x3287221 VA: 0x3287120
	|-Array.BinarySearch<BattleInfo.SupportData>
	|
	|-RVA: 0x3287250 Offset: 0x3287351 VA: 0x3287250
	|-Array.BinarySearch<BeforeRenderHelper.OrderBlock>
	|
	|-RVA: 0x3287380 Offset: 0x3287481 VA: 0x3287380
	|-Array.BinarySearch<Camera.RenderRequest>
	|
	|-RVA: 0x32874D0 Offset: 0x32875D1 VA: 0x32874D0
	|-Array.BinarySearch<CameraState.CustomBlendable>
	|
	|-RVA: 0x3287600 Offset: 0x3287701 VA: 0x3287600
	|-Array.BinarySearch<CinemachineClearShot.Pair>
	|
	|-RVA: 0x3287730 Offset: 0x3287831 VA: 0x3287730
	|-Array.BinarySearch<CinemachineStateDrivenCamera.HashPair>
	|
	|-RVA: 0x3287860 Offset: 0x3287961 VA: 0x3287860
	|-Array.BinarySearch<DelayedActionManager.DelegateInfo>
	|
	|-RVA: 0x32879C0 Offset: 0x3287AC1 VA: 0x32879C0
	|-Array.BinarySearch<Detail.AsyncResultInt>
	|
	|-RVA: 0x3287B20 Offset: 0x3287C21 VA: 0x3287B20
	|-Array.BinarySearch<Detail.CppArray>
	|
	|-RVA: 0x3287C50 Offset: 0x3287D51 VA: 0x3287C50
	|-Array.BinarySearch<Detail.NotificationEventInt>
	|
	|-RVA: 0x3287DB0 Offset: 0x3287EB1 VA: 0x3287DB0
	|-Array.BinarySearch<DragonRideTargetGroup.ChainParam>
	|
	|-RVA: 0x3287EE0 Offset: 0x3287FE1 VA: 0x3287EE0
	|-Array.BinarySearch<GmapPathAdjuster.TargetModel>
	|
	|-RVA: 0x3288030 Offset: 0x3288131 VA: 0x3288030
	|-Array.BinarySearch<GmapSpotAdjuster.TargetModel>
	|
	|-RVA: 0x3288180 Offset: 0x3288281 VA: 0x3288180
	|-Array.BinarySearch<HubFastTravel.Location>
	|
	|-RVA: 0x32882D0 Offset: 0x32883D1 VA: 0x32882D0
	|-Array.BinarySearch<HubLensFlare.Flare>
	|
	|-RVA: 0x3288430 Offset: 0x3288531 VA: 0x3288430
	|-Array.BinarySearch<InventoryPoolItemMenuContent.KindBgNameClass>
	|
	|-RVA: 0x3288560 Offset: 0x3288661 VA: 0x3288560
	|-Array.BinarySearch<Map.Pos>
	|
	|-RVA: 0x3288690 Offset: 0x3288791 VA: 0x3288690
	|-Array.BinarySearch<MapImage.BackupTerrain>
	|
	|-RVA: 0x32887C0 Offset: 0x32888C1 VA: 0x32887C0
	|-Array.BinarySearch<MapImageRange.Pos>
	|
	|-RVA: 0x32888F0 Offset: 0x32889F1 VA: 0x32888F0
	|-Array.BinarySearch<MapMind.Target>
	|
	|-RVA: 0x3288A40 Offset: 0x3288B41 VA: 0x3288A40
	|-Array.BinarySearch<MapPanelDebug.Entity>
	|
	|-RVA: 0x3288B90 Offset: 0x3288C91 VA: 0x3288B90
	|-Array.BinarySearch<NexRanking.Data>
	|
	|-RVA: 0x3288CC0 Offset: 0x3288DC1 VA: 0x3288CC0
	|-Array.BinarySearch<NexVersus.RatingData>
	|
	|-RVA: 0x3288DF0 Offset: 0x3288EF1 VA: 0x3288DF0
	|-Array.BinarySearch<PackedPlayModeBuildLogs.RuntimeBuildLog>
	|
	|-RVA: 0x3288F20 Offset: 0x3289021 VA: 0x3288F20
	|-Array.BinarySearch<ParticleSystem.Particle>
	|
	|-RVA: 0x32890C0 Offset: 0x32891C1 VA: 0x32890C0
	|-Array.BinarySearch<RangeData.Offset>
	|
	|-RVA: 0x32891F0 Offset: 0x32892F1 VA: 0x32891F0
	|-Array.BinarySearch<RenderGraphDebugData.PassDebugData>
	|
	|-RVA: 0x3289350 Offset: 0x3289451 VA: 0x3289350
	|-Array.BinarySearch<RenderGraphDebugData.ResourceDebugData>
	|
	|-RVA: 0x32894B0 Offset: 0x32895B1 VA: 0x32894B0
	|-Array.BinarySearch<RingCleaningUnitSelectMenu.GodParam>
	|
	|-RVA: 0x32895E0 Offset: 0x32896E1 VA: 0x32895E0
	|-Array.BinarySearch<ShadowUtility.Edge>
	|
	|-RVA: 0x3289740 Offset: 0x3289841 VA: 0x3289740
	|-Array.BinarySearch<SkillArray.Entity>
	|
	|-RVA: 0x3289870 Offset: 0x3289971 VA: 0x3289870
	|-Array.BinarySearch<TexturePacker_JsonArray.Frame>
	|
	|-RVA: 0x32899F0 Offset: 0x3289AF1 VA: 0x32899F0
	|-Array.BinarySearch<TimeNotificationBehaviour.NotificationEntry>
	|
	|-RVA: 0x3289B40 Offset: 0x3289C41 VA: 0x3289B40
	|-Array.BinarySearch<UnitySynchronizationContext.WorkRequest>
	|
	|-RVA: 0x3289C90 Offset: 0x3289D91 VA: 0x3289C90
	|-Array.BinarySearch<XmlSchemaObjectTable.XmlSchemaObjectEntry>
	|
	|-RVA: 0x3289DC0 Offset: 0x3289EC1 VA: 0x3289DC0
	|-Array.BinarySearch<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>
	|
	|-RVA: 0x3289EF0 Offset: 0x3289FF1 VA: 0x3289EF0
	|-Array.BinarySearch<Detail.DataStore.DataStoreChangeMetaParamInt>
	|
	|-RVA: 0x328A090 Offset: 0x328A191 VA: 0x328A090
	|-Array.BinarySearch<Detail.DataStore.DataStoreDeleteParamInt>
	|
	|-RVA: 0x328A1C0 Offset: 0x328A2C1 VA: 0x328A1C0
	|-Array.BinarySearch<Detail.DataStore.DataStoreGetMetaParamInt>
	|
	|-RVA: 0x328A320 Offset: 0x328A421 VA: 0x328A320
	|-Array.BinarySearch<Detail.DataStore.DataStoreMetaInfoInt>
	|
	|-RVA: 0x328A4C0 Offset: 0x328A5C1 VA: 0x328A4C0
	|-Array.BinarySearch<Detail.DataStore.DataStorePasswordInfoInt>
	|
	|-RVA: 0x328A610 Offset: 0x328A711 VA: 0x328A610
	|-Array.BinarySearch<Detail.DataStore.DataStorePersistenceInfoInt>
	|
	|-RVA: 0x328A760 Offset: 0x328A861 VA: 0x328A760
	|-Array.BinarySearch<Detail.DataStore.DataStorePreparePostParamInt>
	|
	|-RVA: 0x328A900 Offset: 0x328AA01 VA: 0x328A900
	|-Array.BinarySearch<Detail.DataStore.DataStoreRateObjectParamInt>
	|
	|-RVA: 0x328AA30 Offset: 0x328AB31 VA: 0x328AA30
	|-Array.BinarySearch<Detail.DataStore.DataStoreRatingInitParamInt>
	|
	|-RVA: 0x328AB90 Offset: 0x328AC91 VA: 0x328AB90
	|-Array.BinarySearch<Detail.DataStore.DataStoreRatingTargetInt>
	|
	|-RVA: 0x328ACC0 Offset: 0x328ADC1 VA: 0x328ACC0
	|-Array.BinarySearch<Detail.Ranking.RankingCachedResultInt>
	|
	|-RVA: 0x328AE40 Offset: 0x328AF41 VA: 0x328AE40
	|-Array.BinarySearch<Detail.Ranking.RankingOrderParamInt>
	|
	|-RVA: 0x328AF70 Offset: 0x328B071 VA: 0x328AF70
	|-Array.BinarySearch<Detail.Ranking.RankingRankDataInt>
	|
	|-RVA: 0x328B0F0 Offset: 0x328B1F1 VA: 0x328B0F0
	|-Array.BinarySearch<Detail.Ranking2.Ranking2ChartInfoInt>
	|
	|-RVA: 0x328B290 Offset: 0x328B391 VA: 0x328B290
	|-Array.BinarySearch<Detail.Ranking2.Ranking2RankDataInt>
	|
	|-RVA: 0x328B410 Offset: 0x328B511 VA: 0x328B410
	|-Array.BinarySearch<Detail.Ranking2.Ranking2ScoreDataInt>
	|
	|-RVA: 0x328B540 Offset: 0x328B641 VA: 0x328B540
	|-Array.BinarySearch<Detail.Screening.ScreeningContextInfoInt>
	|
	|-RVA: 0x328B6A0 Offset: 0x328B7A1 VA: 0x328B6A0
	|-Array.BinarySearch<Detail.Subscriber.SubscriberContentInt>
	|
	|-RVA: 0x328B840 Offset: 0x328B941 VA: 0x328B840
	|-Array.BinarySearch<Detail.Subscriber.SubscriberGetContentParamInt>
	|
	|-RVA: 0x328B990 Offset: 0x328BA91 VA: 0x328B990
	|-Array.BinarySearch<Detail.Subscriber.SubscriberUserStatusInfoInt>
	|
	|-RVA: 0x328BAF0 Offset: 0x328BBF1 VA: 0x328BAF0
	|-Array.BinarySearch<Detail.Subscriber.SubscriberUserStatusParamInt>
	|
	|-RVA: 0x328BC40 Offset: 0x328BD41 VA: 0x328BC40
	|-Array.BinarySearch<Detail.Utility.IntegerSettings>
	|
	|-RVA: 0x328BD70 Offset: 0x328BE71 VA: 0x328BD70
	|-Array.BinarySearch<Detail.Utility.UniqueIdInfoInt>
	|
	|-RVA: 0x328BEA0 Offset: 0x328BFA1 VA: 0x328BEA0
	|-Array.BinarySearch<MapHistory.Rewind.LatestInspectorData>
	|
	|-RVA: 0x328BFD0 Offset: 0x328C0D1 VA: 0x328BFD0
	|-Array.BinarySearch<MapHistory.Rewind.WorkTerrainData>
	|
	|-RVA: 0x328C100 Offset: 0x328C201 VA: 0x328C100
	|-Array.BinarySearch<MapSkill.AroundCalculator.Result>
	|
	|-RVA: 0x328C230 Offset: 0x328C331 VA: 0x328C230
	|-Array.BinarySearch<TargetPositionCache.CacheCurve.Item>
	|
	|-RVA: 0x328C390 Offset: 0x328C491 VA: 0x328C390
	|-Array.BinarySearch<TargetPositionCache.CacheEntry.RecordingItem>
	*/

	// RVA: 0x3560600 Offset: 0x3560701 VA: 0x3560600
	public static int IndexOf(Array array, object value) { }

	// RVA: 0x35628B0 Offset: 0x35629B1 VA: 0x35628B0
	public static int IndexOf(Array array, object value, int startIndex) { }

	// RVA: 0x3562550 Offset: 0x3562651 VA: 0x3562550
	public static int IndexOf(Array array, object value, int startIndex, int count) { }

	// RVA: -1 Offset: -1
	public static int IndexOf<T>(T[] array, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x328E160 Offset: 0x328E261 VA: 0x328E160
	|-Array.IndexOf<byte>
	|
	|-RVA: 0x328E1E0 Offset: 0x328E2E1 VA: 0x328E1E0
	|-Array.IndexOf<int>
	|
	|-RVA: 0x328E260 Offset: 0x328E361 VA: 0x328E260
	|-Array.IndexOf<Int32Enum>
	|-Array.IndexOf<Force.Type>
	|
	|-RVA: 0x328E2E0 Offset: 0x328E3E1 VA: 0x328E2E0
	|-Array.IndexOf<object>
	|-Array.IndexOf<string>
	*/

	// RVA: -1 Offset: -1
	public static int IndexOf<T>(T[] array, T value, int startIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x328E360 Offset: 0x328E461 VA: 0x328E360
	|-Array.IndexOf<object>
	*/

	// RVA: -1 Offset: -1
	public static int IndexOf<T>(T[] array, T value, int startIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x328E3E0 Offset: 0x328E4E1 VA: 0x328E3E0
	|-Array.IndexOf<IntervalTree.Entry<object>>
	|
	|-RVA: 0x328E510 Offset: 0x328E611 VA: 0x328E510
	|-Array.IndexOf<KeyValuePair<DateTime, object>>
	|
	|-RVA: 0x328E620 Offset: 0x328E721 VA: 0x328E620
	|-Array.IndexOf<KeyValuePair<int, object>>
	|
	|-RVA: 0x328E730 Offset: 0x328E831 VA: 0x328E730
	|-Array.IndexOf<KeyValuePair<object, ValueTuple<int, DateTime, object>>>
	|
	|-RVA: 0x328E860 Offset: 0x328E961 VA: 0x328E860
	|-Array.IndexOf<KeyValuePair<object, object>>
	|
	|-RVA: 0x328E970 Offset: 0x328EA71 VA: 0x328E970
	|-Array.IndexOf<CommonBattleSequence.Reliance<object>>
	|
	|-RVA: 0x328EAA0 Offset: 0x328EBA1 VA: 0x328EAA0
	|-Array.IndexOf<RenderGraphResourcePool.ResourceLogInfo<object>>
	|
	|-RVA: 0x328EBB0 Offset: 0x328ECB1 VA: 0x328EBB0
	|-Array.IndexOf<TimeInterval<object>>
	|
	|-RVA: 0x328ECC0 Offset: 0x328EDC1 VA: 0x328ECC0
	|-Array.IndexOf<Timestamped<object>>
	|
	|-RVA: 0x328EDF0 Offset: 0x328EEF1 VA: 0x328EDF0
	|-Array.IndexOf<ValueTuple<int, object>>
	|
	|-RVA: 0x328EF00 Offset: 0x328F001 VA: 0x328EF00
	|-Array.IndexOf<ValueTuple<Int32Enum, int>>
	|
	|-RVA: 0x328F010 Offset: 0x328F111 VA: 0x328F010
	|-Array.IndexOf<ValueTuple<object, ValueTuple<object, int>>>
	|
	|-RVA: 0x328F140 Offset: 0x328F241 VA: 0x328F140
	|-Array.IndexOf<ValueTuple<object, int>>
	|
	|-RVA: 0x328F250 Offset: 0x328F351 VA: 0x328F250
	|-Array.IndexOf<ValueTuple<object, float>>
	|
	|-RVA: 0x328F360 Offset: 0x328F461 VA: 0x328F360
	|-Array.IndexOf<ValueTuple<Vector3, float>>
	|
	|-RVA: 0x328F470 Offset: 0x328F571 VA: 0x328F470
	|-Array.IndexOf<ValueTuple<object, Int32Enum, int>>
	|
	|-RVA: 0x328F580 Offset: 0x328F681 VA: 0x328F580
	|-Array.IndexOf<ValueTuple<object, int, int, int>>
	|
	|-RVA: 0x328F6B0 Offset: 0x328F7B1 VA: 0x328F6B0
	|-Array.IndexOf<AnimatorClipInfo>
	|
	|-RVA: 0x328F7C0 Offset: 0x328F8C1 VA: 0x328F7C0
	|-Array.IndexOf<AsyncOperationHandle>
	|
	|-RVA: 0x328F8F0 Offset: 0x328F9F1 VA: 0x328F8F0
	|-Array.IndexOf<BoneWeight>
	|
	|-RVA: 0x328FA20 Offset: 0x328FB21 VA: 0x328FA20
	|-Array.IndexOf<bool>
	|
	|-RVA: 0x328FB30 Offset: 0x328FC31 VA: 0x328FB30
	|-Array.IndexOf<byte>
	|
	|-RVA: 0x328FC40 Offset: 0x328FD41 VA: 0x328FC40
	|-Array.IndexOf<CameraInfo>
	|
	|-RVA: 0x328FD50 Offset: 0x328FE51 VA: 0x328FD50
	|-Array.IndexOf<char>
	|
	|-RVA: 0x328FE60 Offset: 0x328FF61 VA: 0x328FE60
	|-Array.IndexOf<Color>
	|
	|-RVA: 0x328FF70 Offset: 0x3290071 VA: 0x328FF70
	|-Array.IndexOf<Color32>
	|
	|-RVA: 0x3290080 Offset: 0x3290181 VA: 0x3290080
	|-Array.IndexOf<ConstraintSource>
	|
	|-RVA: 0x3290190 Offset: 0x3290291 VA: 0x3290190
	|-Array.IndexOf<ContourVertex>
	|
	|-RVA: 0x32902C0 Offset: 0x32903C1 VA: 0x32902C0
	|-Array.IndexOf<DataStoreRatingInfo>
	|
	|-RVA: 0x32903F0 Offset: 0x32904F1 VA: 0x32903F0
	|-Array.IndexOf<DataStoreResult>
	|
	|-RVA: 0x3290500 Offset: 0x3290601 VA: 0x3290500
	|-Array.IndexOf<DateTime>
	|
	|-RVA: 0x3290610 Offset: 0x3290711 VA: 0x3290610
	|-Array.IndexOf<DateTimeOffset>
	|
	|-RVA: 0x3290720 Offset: 0x3290821 VA: 0x3290720
	|-Array.IndexOf<Decimal>
	|
	|-RVA: 0x3290830 Offset: 0x3290931 VA: 0x3290830
	|-Array.IndexOf<DiagnosticEvent>
	|
	|-RVA: 0x3290970 Offset: 0x3290A71 VA: 0x3290970
	|-Array.IndexOf<double>
	|
	|-RVA: 0x3290A80 Offset: 0x3290B81 VA: 0x3290A80
	|-Array.IndexOf<Friend>
	|
	|-RVA: 0x3290BE0 Offset: 0x3290CE1 VA: 0x3290BE0
	|-Array.IndexOf<GlyphRect>
	|
	|-RVA: 0x3290CF0 Offset: 0x3290DF1 VA: 0x3290CF0
	|-Array.IndexOf<short>
	|
	|-RVA: 0x3290E00 Offset: 0x3290F01 VA: 0x3290E00
	|-Array.IndexOf<int>
	|
	|-RVA: 0x3290F10 Offset: 0x3291011 VA: 0x3290F10
	|-Array.IndexOf<Int32Enum>
	|
	|-RVA: 0x3291020 Offset: 0x3291121 VA: 0x3291020
	|-Array.IndexOf<long>
	|
	|-RVA: 0x3291130 Offset: 0x3291231 VA: 0x3291130
	|-Array.IndexOf<IntPtr>
	|
	|-RVA: 0x3291240 Offset: 0x3291341 VA: 0x3291240
	|-Array.IndexOf<InterpretedFrameInfo>
	|
	|-RVA: 0x3291350 Offset: 0x3291451 VA: 0x3291350
	|-Array.IndexOf<IntervalTreeNode>
	|
	|-RVA: 0x3291480 Offset: 0x3291581 VA: 0x3291480
	|-Array.IndexOf<LengthLimitProperties>
	|
	|-RVA: 0x3291590 Offset: 0x3291691 VA: 0x3291590
	|-Array.IndexOf<MapPos>
	|
	|-RVA: 0x32916A0 Offset: 0x32917A1 VA: 0x32916A0
	|-Array.IndexOf<Matrix4x4>
	|
	|-RVA: 0x3291800 Offset: 0x3291901 VA: 0x3291800
	|-Array.IndexOf<object>
	|
	|-RVA: 0x3291910 Offset: 0x3291A11 VA: 0x3291910
	|-Array.IndexOf<ObjectInitializationData>
	|
	|-RVA: 0x3291A50 Offset: 0x3291B51 VA: 0x3291A50
	|-Array.IndexOf<PlayableBinding>
	|
	|-RVA: 0x3291B80 Offset: 0x3291C81 VA: 0x3291B80
	|-Array.IndexOf<PlayerLoopSystem>
	|
	|-RVA: 0x3291CC0 Offset: 0x3291DC1 VA: 0x3291CC0
	|-Array.IndexOf<PlayerLoopSystemInternal>
	|
	|-RVA: 0x3291E00 Offset: 0x3291F01 VA: 0x3291E00
	|-Array.IndexOf<RangePositionInfo>
	|
	|-RVA: 0x3291F10 Offset: 0x3292011 VA: 0x3291F10
	|-Array.IndexOf<Ranking2ChartInfoInput>
	|
	|-RVA: 0x3292020 Offset: 0x3292121 VA: 0x3292020
	|-Array.IndexOf<RaycastHit2D>
	|
	|-RVA: 0x3292160 Offset: 0x3292261 VA: 0x3292160
	|-Array.IndexOf<RaycastResult>
	|
	|-RVA: 0x32922D0 Offset: 0x32923D1 VA: 0x32922D0
	|-Array.IndexOf<Rect>
	|
	|-RVA: 0x32923E0 Offset: 0x32924E1 VA: 0x32923E0
	|-Array.IndexOf<RendererListHandle>
	|
	|-RVA: 0x32924F0 Offset: 0x32925F1 VA: 0x32924F0
	|-Array.IndexOf<ResourceHandle>
	|
	|-RVA: 0x3292600 Offset: 0x3292701 VA: 0x3292600
	|-Array.IndexOf<sbyte>
	|
	|-RVA: 0x3292710 Offset: 0x3292811 VA: 0x3292710
	|-Array.IndexOf<ShaderTagId>
	|
	|-RVA: 0x3292820 Offset: 0x3292921 VA: 0x3292820
	|-Array.IndexOf<float>
	|
	|-RVA: 0x3292930 Offset: 0x3292A31 VA: 0x3292930
	|-Array.IndexOf<SphericalHarmonicsL2>
	|
	|-RVA: 0x3292AD0 Offset: 0x3292BD1 VA: 0x3292AD0
	|-Array.IndexOf<SubMeshDescriptor>
	|
	|-RVA: 0x3292C10 Offset: 0x3292D11 VA: 0x3292C10
	|-Array.IndexOf<TablePair>
	|
	|-RVA: 0x3292D20 Offset: 0x3292E21 VA: 0x3292D20
	|-Array.IndexOf<TimeSpan>
	|
	|-RVA: 0x3292E30 Offset: 0x3292F31 VA: 0x3292E30
	|-Array.IndexOf<UICharInfo>
	|
	|-RVA: 0x3292F40 Offset: 0x3293041 VA: 0x3292F40
	|-Array.IndexOf<UILineInfo>
	|
	|-RVA: 0x3293050 Offset: 0x3293151 VA: 0x3293050
	|-Array.IndexOf<UIVertex>
	|
	|-RVA: 0x32931F0 Offset: 0x32932F1 VA: 0x32931F0
	|-Array.IndexOf<ushort>
	|
	|-RVA: 0x3293300 Offset: 0x3293401 VA: 0x3293300
	|-Array.IndexOf<uint>
	|
	|-RVA: 0x3293410 Offset: 0x3293511 VA: 0x3293410
	|-Array.IndexOf<ulong>
	|
	|-RVA: 0x3293520 Offset: 0x3293621 VA: 0x3293520
	|-Array.IndexOf<Vector2>
	|
	|-RVA: 0x3293630 Offset: 0x3293731 VA: 0x3293630
	|-Array.IndexOf<Vector3>
	|
	|-RVA: 0x3293740 Offset: 0x3293841 VA: 0x3293740
	|-Array.IndexOf<Vector4>
	|
	|-RVA: 0x3293850 Offset: 0x3293951 VA: 0x3293850
	|-Array.IndexOf<VertexAttributeDescriptor>
	|
	|-RVA: 0x3293960 Offset: 0x3293A61 VA: 0x3293960
	|-Array.IndexOf<X509ChainStatus>
	|
	|-RVA: 0x3293A70 Offset: 0x3293B71 VA: 0x3293A70
	|-Array.IndexOf<XRView>
	|
	|-RVA: 0x3293BE0 Offset: 0x3293CE1 VA: 0x3293BE0
	|-Array.IndexOf<AmiiboSequence.GainItemData>
	|
	|-RVA: 0x3293CF0 Offset: 0x3293DF1 VA: 0x3293CF0
	|-Array.IndexOf<AnimationOutputWeightProcessor.WeightInfo>
	|
	|-RVA: 0x3293E30 Offset: 0x3293F31 VA: 0x3293E30
	|-Array.IndexOf<ArenaOrderSequence.GodInfo>
	|
	|-RVA: 0x3293F40 Offset: 0x3294041 VA: 0x3293F40
	|-Array.IndexOf<BattleInfo.SupportData>
	|
	|-RVA: 0x3294050 Offset: 0x3294151 VA: 0x3294050
	|-Array.IndexOf<BeforeRenderHelper.OrderBlock>
	|
	|-RVA: 0x3294160 Offset: 0x3294261 VA: 0x3294160
	|-Array.IndexOf<Camera.RenderRequest>
	|
	|-RVA: 0x3294290 Offset: 0x3294391 VA: 0x3294290
	|-Array.IndexOf<CameraState.CustomBlendable>
	|
	|-RVA: 0x32943A0 Offset: 0x32944A1 VA: 0x32943A0
	|-Array.IndexOf<CinemachineClearShot.Pair>
	|
	|-RVA: 0x32944B0 Offset: 0x32945B1 VA: 0x32944B0
	|-Array.IndexOf<CinemachineStateDrivenCamera.HashPair>
	|
	|-RVA: 0x32945C0 Offset: 0x32946C1 VA: 0x32945C0
	|-Array.IndexOf<DelayedActionManager.DelegateInfo>
	|
	|-RVA: 0x32946F0 Offset: 0x32947F1 VA: 0x32946F0
	|-Array.IndexOf<Detail.AsyncResultInt>
	|
	|-RVA: 0x3294830 Offset: 0x3294931 VA: 0x3294830
	|-Array.IndexOf<Detail.CppArray>
	|
	|-RVA: 0x3294940 Offset: 0x3294A41 VA: 0x3294940
	|-Array.IndexOf<Detail.NotificationEventInt>
	|
	|-RVA: 0x3294A80 Offset: 0x3294B81 VA: 0x3294A80
	|-Array.IndexOf<DragonRideTargetGroup.ChainParam>
	|
	|-RVA: 0x3294B90 Offset: 0x3294C91 VA: 0x3294B90
	|-Array.IndexOf<GmapPathAdjuster.TargetModel>
	|
	|-RVA: 0x3294CC0 Offset: 0x3294DC1 VA: 0x3294CC0
	|-Array.IndexOf<GmapSpotAdjuster.TargetModel>
	|
	|-RVA: 0x3294DF0 Offset: 0x3294EF1 VA: 0x3294DF0
	|-Array.IndexOf<HubFastTravel.Location>
	|
	|-RVA: 0x3294F20 Offset: 0x3295021 VA: 0x3294F20
	|-Array.IndexOf<HubLensFlare.Flare>
	|
	|-RVA: 0x3295060 Offset: 0x3295161 VA: 0x3295060
	|-Array.IndexOf<InventoryPoolItemMenuContent.KindBgNameClass>
	|
	|-RVA: 0x3295170 Offset: 0x3295271 VA: 0x3295170
	|-Array.IndexOf<Map.Pos>
	|
	|-RVA: 0x3295280 Offset: 0x3295381 VA: 0x3295280
	|-Array.IndexOf<MapImage.BackupTerrain>
	|
	|-RVA: 0x3295390 Offset: 0x3295491 VA: 0x3295390
	|-Array.IndexOf<MapImageRange.Pos>
	|
	|-RVA: 0x210E620 Offset: 0x210E721 VA: 0x210E620
	|-Array.IndexOf<MapMind.Target>
	|
	|-RVA: 0x210E750 Offset: 0x210E851 VA: 0x210E750
	|-Array.IndexOf<MapPanelDebug.Entity>
	|
	|-RVA: 0x210E880 Offset: 0x210E981 VA: 0x210E880
	|-Array.IndexOf<NexRanking.Data>
	|
	|-RVA: 0x210E990 Offset: 0x210EA91 VA: 0x210E990
	|-Array.IndexOf<NexVersus.RatingData>
	|
	|-RVA: 0x210EAA0 Offset: 0x210EBA1 VA: 0x210EAA0
	|-Array.IndexOf<PackedPlayModeBuildLogs.RuntimeBuildLog>
	|
	|-RVA: 0x210EBB0 Offset: 0x210ECB1 VA: 0x210EBB0
	|-Array.IndexOf<ParticleSystem.Particle>
	|
	|-RVA: 0x210ED20 Offset: 0x210EE21 VA: 0x210ED20
	|-Array.IndexOf<RangeData.Offset>
	|
	|-RVA: 0x210EE30 Offset: 0x210EF31 VA: 0x210EE30
	|-Array.IndexOf<RenderGraphDebugData.PassDebugData>
	|
	|-RVA: 0x210EF60 Offset: 0x210F061 VA: 0x210EF60
	|-Array.IndexOf<RenderGraphDebugData.ResourceDebugData>
	|
	|-RVA: 0x210F0A0 Offset: 0x210F1A1 VA: 0x210F0A0
	|-Array.IndexOf<RingCleaningUnitSelectMenu.GodParam>
	|
	|-RVA: 0x210F1B0 Offset: 0x210F2B1 VA: 0x210F1B0
	|-Array.IndexOf<ShadowUtility.Edge>
	|
	|-RVA: 0x210F2F0 Offset: 0x210F3F1 VA: 0x210F2F0
	|-Array.IndexOf<SkillArray.Entity>
	|
	|-RVA: 0x210F400 Offset: 0x210F501 VA: 0x210F400
	|-Array.IndexOf<TexturePacker_JsonArray.Frame>
	|
	|-RVA: 0x210F560 Offset: 0x210F661 VA: 0x210F560
	|-Array.IndexOf<TimeNotificationBehaviour.NotificationEntry>
	|
	|-RVA: 0x210F690 Offset: 0x210F791 VA: 0x210F690
	|-Array.IndexOf<UnitySynchronizationContext.WorkRequest>
	|
	|-RVA: 0x210F7C0 Offset: 0x210F8C1 VA: 0x210F7C0
	|-Array.IndexOf<XmlSchemaObjectTable.XmlSchemaObjectEntry>
	|
	|-RVA: 0x210F8D0 Offset: 0x210F9D1 VA: 0x210F8D0
	|-Array.IndexOf<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>
	|
	|-RVA: 0x210F9E0 Offset: 0x210FAE1 VA: 0x210F9E0
	|-Array.IndexOf<Detail.DataStore.DataStoreChangeMetaParamInt>
	|
	|-RVA: 0x210FB40 Offset: 0x210FC41 VA: 0x210FB40
	|-Array.IndexOf<Detail.DataStore.DataStoreDeleteParamInt>
	|
	|-RVA: 0x210FC50 Offset: 0x210FD51 VA: 0x210FC50
	|-Array.IndexOf<Detail.DataStore.DataStoreGetMetaParamInt>
	|
	|-RVA: 0x210FD90 Offset: 0x210FE91 VA: 0x210FD90
	|-Array.IndexOf<Detail.DataStore.DataStoreMetaInfoInt>
	|
	|-RVA: 0x210FF00 Offset: 0x2110001 VA: 0x210FF00
	|-Array.IndexOf<Detail.DataStore.DataStorePasswordInfoInt>
	|
	|-RVA: 0x2110030 Offset: 0x2110131 VA: 0x2110030
	|-Array.IndexOf<Detail.DataStore.DataStorePersistenceInfoInt>
	|
	|-RVA: 0x2110160 Offset: 0x2110261 VA: 0x2110160
	|-Array.IndexOf<Detail.DataStore.DataStorePreparePostParamInt>
	|
	|-RVA: 0x21102D0 Offset: 0x21103D1 VA: 0x21102D0
	|-Array.IndexOf<Detail.DataStore.DataStoreRateObjectParamInt>
	|
	|-RVA: 0x21103E0 Offset: 0x21104E1 VA: 0x21103E0
	|-Array.IndexOf<Detail.DataStore.DataStoreRatingInitParamInt>
	|
	|-RVA: 0x2110510 Offset: 0x2110611 VA: 0x2110510
	|-Array.IndexOf<Detail.DataStore.DataStoreRatingTargetInt>
	|
	|-RVA: 0x2110620 Offset: 0x2110721 VA: 0x2110620
	|-Array.IndexOf<Detail.Ranking.RankingCachedResultInt>
	|
	|-RVA: 0x2110780 Offset: 0x2110881 VA: 0x2110780
	|-Array.IndexOf<Detail.Ranking.RankingOrderParamInt>
	|
	|-RVA: 0x2110890 Offset: 0x2110991 VA: 0x2110890
	|-Array.IndexOf<Detail.Ranking.RankingRankDataInt>
	|
	|-RVA: 0x21109F0 Offset: 0x2110AF1 VA: 0x21109F0
	|-Array.IndexOf<Detail.Ranking2.Ranking2ChartInfoInt>
	|
	|-RVA: 0x2110B70 Offset: 0x2110C71 VA: 0x2110B70
	|-Array.IndexOf<Detail.Ranking2.Ranking2RankDataInt>
	|
	|-RVA: 0x2110CD0 Offset: 0x2110DD1 VA: 0x2110CD0
	|-Array.IndexOf<Detail.Ranking2.Ranking2ScoreDataInt>
	|
	|-RVA: 0x2110DE0 Offset: 0x2110EE1 VA: 0x2110DE0
	|-Array.IndexOf<Detail.Screening.ScreeningContextInfoInt>
	|
	|-RVA: 0x2110F10 Offset: 0x2111011 VA: 0x2110F10
	|-Array.IndexOf<Detail.Subscriber.SubscriberContentInt>
	|
	|-RVA: 0x2111080 Offset: 0x2111181 VA: 0x2111080
	|-Array.IndexOf<Detail.Subscriber.SubscriberGetContentParamInt>
	|
	|-RVA: 0x21111B0 Offset: 0x21112B1 VA: 0x21111B0
	|-Array.IndexOf<Detail.Subscriber.SubscriberUserStatusInfoInt>
	|
	|-RVA: 0x21112F0 Offset: 0x21113F1 VA: 0x21112F0
	|-Array.IndexOf<Detail.Subscriber.SubscriberUserStatusParamInt>
	|
	|-RVA: 0x2111420 Offset: 0x2111521 VA: 0x2111420
	|-Array.IndexOf<Detail.Utility.IntegerSettings>
	|
	|-RVA: 0x2111530 Offset: 0x2111631 VA: 0x2111530
	|-Array.IndexOf<Detail.Utility.UniqueIdInfoInt>
	|
	|-RVA: 0x2111640 Offset: 0x2111741 VA: 0x2111640
	|-Array.IndexOf<MapHistory.Rewind.LatestInspectorData>
	|
	|-RVA: 0x2111750 Offset: 0x2111851 VA: 0x2111750
	|-Array.IndexOf<MapHistory.Rewind.WorkTerrainData>
	|
	|-RVA: 0x2111860 Offset: 0x2111961 VA: 0x2111860
	|-Array.IndexOf<MapSkill.AroundCalculator.Result>
	|
	|-RVA: 0x2111970 Offset: 0x2111A71 VA: 0x2111970
	|-Array.IndexOf<TargetPositionCache.CacheCurve.Item>
	|
	|-RVA: 0x2111AB0 Offset: 0x2111BB1 VA: 0x2111AB0
	|-Array.IndexOf<TargetPositionCache.CacheEntry.RecordingItem>
	*/

	// RVA: 0x35629A0 Offset: 0x3562AA1 VA: 0x35629A0
	public static int LastIndexOf(Array array, object value) { }

	// RVA: 0x3562E30 Offset: 0x3562F31 VA: 0x3562E30
	public static int LastIndexOf(Array array, object value, int startIndex) { }

	// RVA: 0x3562AC0 Offset: 0x3562BC1 VA: 0x3562AC0
	public static int LastIndexOf(Array array, object value, int startIndex, int count) { }

	// RVA: -1 Offset: -1
	public static int LastIndexOf<T>(T[] array, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FB5180 Offset: 0x2FB5281 VA: 0x2FB5180
	|-Array.LastIndexOf<Delegate>
	|-Array.LastIndexOf<object>
	*/

	// RVA: -1 Offset: -1
	public static int LastIndexOf<T>(T[] array, T value, int startIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FB5200 Offset: 0x2FB5301 VA: 0x2FB5200
	|-Array.LastIndexOf<Color>
	|
	|-RVA: 0x2FB5280 Offset: 0x2FB5381 VA: 0x2FB5280
	|-Array.LastIndexOf<int>
	|
	|-RVA: 0x2FB5300 Offset: 0x2FB5401 VA: 0x2FB5300
	|-Array.LastIndexOf<Int32Enum>
	|
	|-RVA: 0x2FB5380 Offset: 0x2FB5481 VA: 0x2FB5380
	|-Array.LastIndexOf<object>
	|
	|-RVA: 0x2FB5400 Offset: 0x2FB5501 VA: 0x2FB5400
	|-Array.LastIndexOf<RandomSeed>
	|
	|-RVA: 0x2FB5480 Offset: 0x2FB5581 VA: 0x2FB5480
	|-Array.LastIndexOf<float>
	|
	|-RVA: 0x2FB5500 Offset: 0x2FB5601 VA: 0x2FB5500
	|-Array.LastIndexOf<uint>
	|
	|-RVA: 0x2FB5580 Offset: 0x2FB5681 VA: 0x2FB5580
	|-Array.LastIndexOf<DynamicMesh.State>
	|
	|-RVA: 0x2FB5600 Offset: 0x2FB5701 VA: 0x2FB5600
	|-Array.LastIndexOf<MapMind.Record>
	|
	|-RVA: 0x2FB57B0 Offset: 0x2FB58B1 VA: 0x2FB57B0
	|-Array.LastIndexOf<QualitySettingsStack.Settings>
	|
	|-RVA: 0x2FB58E0 Offset: 0x2FB59E1 VA: 0x2FB58E0
	|-Array.LastIndexOf<SequenceNode.SequenceConstructPosContext>
	|
	|-RVA: 0x2FB5A10 Offset: 0x2FB5B11 VA: 0x2FB5A10
	|-Array.LastIndexOf<Stream.Info>
	*/

	// RVA: -1 Offset: -1
	public static int LastIndexOf<T>(T[] array, T value, int startIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FB5AA0 Offset: 0x2FB5BA1 VA: 0x2FB5AA0
	|-Array.LastIndexOf<Color>
	|
	|-RVA: 0x2FB5BD0 Offset: 0x2FB5CD1 VA: 0x2FB5BD0
	|-Array.LastIndexOf<int>
	|
	|-RVA: 0x2FB5D00 Offset: 0x2FB5E01 VA: 0x2FB5D00
	|-Array.LastIndexOf<Int32Enum>
	|
	|-RVA: 0x2FB5E30 Offset: 0x2FB5F31 VA: 0x2FB5E30
	|-Array.LastIndexOf<object>
	|
	|-RVA: 0x2FB5F60 Offset: 0x2FB6061 VA: 0x2FB5F60
	|-Array.LastIndexOf<RandomSeed>
	|
	|-RVA: 0x2FB6090 Offset: 0x2FB6191 VA: 0x2FB6090
	|-Array.LastIndexOf<float>
	|
	|-RVA: 0x2FB61C0 Offset: 0x2FB62C1 VA: 0x2FB61C0
	|-Array.LastIndexOf<uint>
	|
	|-RVA: 0x2FB62F0 Offset: 0x2FB63F1 VA: 0x2FB62F0
	|-Array.LastIndexOf<DynamicMesh.State>
	|
	|-RVA: 0x2FB6420 Offset: 0x2FB6521 VA: 0x2FB6420
	|-Array.LastIndexOf<MapMind.Record>
	|
	|-RVA: 0x2FB65C0 Offset: 0x2FB66C1 VA: 0x2FB65C0
	|-Array.LastIndexOf<QualitySettingsStack.Settings>
	|
	|-RVA: 0x2FB6730 Offset: 0x2FB6831 VA: 0x2FB6730
	|-Array.LastIndexOf<SequenceNode.SequenceConstructPosContext>
	|
	|-RVA: 0x2FB68A0 Offset: 0x2FB69A1 VA: 0x2FB68A0
	|-Array.LastIndexOf<Stream.Info>
	*/

	// RVA: 0x3562E90 Offset: 0x3562F91 VA: 0x3562E90
	public static void Reverse(Array array) { }

	// RVA: 0x3562F60 Offset: 0x3563061 VA: 0x3562F60
	public static void Reverse(Array array, int index, int length) { }

	// RVA: -1 Offset: -1
	public static void Reverse<T>(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FB9440 Offset: 0x2FB9541 VA: 0x2FB9440
	|-Array.Reverse<byte>
	|
	|-RVA: 0x2FB94C0 Offset: 0x2FB95C1 VA: 0x2FB94C0
	|-Array.Reverse<object>
	*/

	// RVA: -1 Offset: -1
	public static void Reverse<T>(T[] array, int index, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FB9540 Offset: 0x2FB9641 VA: 0x2FB9540
	|-Array.Reverse<IntervalTree.Entry<object>>
	|
	|-RVA: 0x2FB9780 Offset: 0x2FB9881 VA: 0x2FB9780
	|-Array.Reverse<KeyValuePair<DateTime, object>>
	|
	|-RVA: 0x2FB9970 Offset: 0x2FB9A71 VA: 0x2FB9970
	|-Array.Reverse<KeyValuePair<int, object>>
	|
	|-RVA: 0x2FB9B60 Offset: 0x2FB9C61 VA: 0x2FB9B60
	|-Array.Reverse<KeyValuePair<object, ValueTuple<int, DateTime, object>>>
	|
	|-RVA: 0x2FB9D90 Offset: 0x2FB9E91 VA: 0x2FB9D90
	|-Array.Reverse<KeyValuePair<object, object>>
	|
	|-RVA: 0x2FB9F80 Offset: 0x2FBA081 VA: 0x2FB9F80
	|-Array.Reverse<CommonBattleSequence.Reliance<object>>
	|
	|-RVA: 0x2FBA1B0 Offset: 0x2FBA2B1 VA: 0x2FBA1B0
	|-Array.Reverse<RenderGraphResourcePool.ResourceLogInfo<object>>
	|
	|-RVA: 0x2FBA3A0 Offset: 0x2FBA4A1 VA: 0x2FBA3A0
	|-Array.Reverse<ValueTuple<int, object>>
	|
	|-RVA: 0x2FBA590 Offset: 0x2FBA691 VA: 0x2FBA590
	|-Array.Reverse<ValueTuple<Int32Enum, int>>
	|
	|-RVA: 0x2FBA740 Offset: 0x2FBA841 VA: 0x2FBA740
	|-Array.Reverse<ValueTuple<object, ValueTuple<object, int>>>
	|
	|-RVA: 0x2FBA970 Offset: 0x2FBAA71 VA: 0x2FBA970
	|-Array.Reverse<ValueTuple<object, int>>
	|
	|-RVA: 0x2FBAB60 Offset: 0x2FBAC61 VA: 0x2FBAB60
	|-Array.Reverse<ValueTuple<Vector3, float>>
	|
	|-RVA: 0x2FBAD20 Offset: 0x2FBAE21 VA: 0x2FBAD20
	|-Array.Reverse<ValueTuple<object, Int32Enum, int>>
	|
	|-RVA: 0x2FBAF10 Offset: 0x2FBB011 VA: 0x2FBAF10
	|-Array.Reverse<ValueTuple<object, int, int, int>>
	|
	|-RVA: 0x2FBB140 Offset: 0x2FBB241 VA: 0x2FBB140
	|-Array.Reverse<AnimatorClipInfo>
	|
	|-RVA: 0x2FBB2F0 Offset: 0x2FBB3F1 VA: 0x2FBB2F0
	|-Array.Reverse<AsyncOperationHandle>
	|
	|-RVA: 0x2FBB520 Offset: 0x2FBB621 VA: 0x2FBB520
	|-Array.Reverse<BoneWeight>
	|
	|-RVA: 0x2FBB710 Offset: 0x2FBB811 VA: 0x2FBB710
	|-Array.Reverse<bool>
	|
	|-RVA: 0x2FBB8C0 Offset: 0x2FBB9C1 VA: 0x2FBB8C0
	|-Array.Reverse<byte>
	|
	|-RVA: 0x2FBBA70 Offset: 0x2FBBB71 VA: 0x2FBBA70
	|-Array.Reverse<CameraInfo>
	|
	|-RVA: 0x2FBBC60 Offset: 0x2FBBD61 VA: 0x2FBBC60
	|-Array.Reverse<char>
	|
	|-RVA: 0x2FBBE10 Offset: 0x2FBBF11 VA: 0x2FBBE10
	|-Array.Reverse<Color>
	|
	|-RVA: 0x2FBBFD0 Offset: 0x2FBC0D1 VA: 0x2FBBFD0
	|-Array.Reverse<Color32>
	|
	|-RVA: 0x2FBC180 Offset: 0x2FBC281 VA: 0x2FBC180
	|-Array.Reverse<ConstraintSource>
	|
	|-RVA: 0x2FBC370 Offset: 0x2FBC471 VA: 0x2FBC370
	|-Array.Reverse<ContourVertex>
	|
	|-RVA: 0x2FBC5B0 Offset: 0x2FBC6B1 VA: 0x2FBC5B0
	|-Array.Reverse<DataStoreRatingInfo>
	|
	|-RVA: 0x2FBC7A0 Offset: 0x2FBC8A1 VA: 0x2FBC7A0
	|-Array.Reverse<DataStoreResult>
	|
	|-RVA: 0x2FBC950 Offset: 0x2FBCA51 VA: 0x2FBC950
	|-Array.Reverse<DateTime>
	|
	|-RVA: 0x2FBCB00 Offset: 0x2FBCC01 VA: 0x2FBCB00
	|-Array.Reverse<DateTimeOffset>
	|
	|-RVA: 0x2FBCCB0 Offset: 0x2FBCDB1 VA: 0x2FBCCB0
	|-Array.Reverse<Decimal>
	|
	|-RVA: 0x2FBCE60 Offset: 0x2FBCF61 VA: 0x2FBCE60
	|-Array.Reverse<DiagnosticEvent>
	|
	|-RVA: 0x2FBD0C0 Offset: 0x2FBD1C1 VA: 0x2FBD0C0
	|-Array.Reverse<double>
	|
	|-RVA: 0x2FBD270 Offset: 0x2FBD371 VA: 0x2FBD270
	|-Array.Reverse<Friend>
	|
	|-RVA: 0x2FBD4A0 Offset: 0x2FBD5A1 VA: 0x2FBD4A0
	|-Array.Reverse<GlyphRect>
	|
	|-RVA: 0x2FBD650 Offset: 0x2FBD751 VA: 0x2FBD650
	|-Array.Reverse<short>
	|
	|-RVA: 0x2FBD800 Offset: 0x2FBD901 VA: 0x2FBD800
	|-Array.Reverse<int>
	|
	|-RVA: 0x2FBD9B0 Offset: 0x2FBDAB1 VA: 0x2FBD9B0
	|-Array.Reverse<Int32Enum>
	|
	|-RVA: 0x2FBDB60 Offset: 0x2FBDC61 VA: 0x2FBDB60
	|-Array.Reverse<long>
	|
	|-RVA: 0x2FBDD10 Offset: 0x2FBDE11 VA: 0x2FBDD10
	|-Array.Reverse<IntPtr>
	|
	|-RVA: 0x2FBDEC0 Offset: 0x2FBDFC1 VA: 0x2FBDEC0
	|-Array.Reverse<InterpretedFrameInfo>
	|
	|-RVA: 0x2FBE0B0 Offset: 0x2FBE1B1 VA: 0x2FBE0B0
	|-Array.Reverse<IntervalTreeNode>
	|
	|-RVA: 0x2FBE2A0 Offset: 0x2FBE3A1 VA: 0x2FBE2A0
	|-Array.Reverse<LengthLimitProperties>
	|
	|-RVA: 0x2FBE450 Offset: 0x2FBE551 VA: 0x2FBE450
	|-Array.Reverse<MapPos>
	|
	|-RVA: 0x2FBE600 Offset: 0x2FBE701 VA: 0x2FBE600
	|-Array.Reverse<Matrix4x4>
	|
	|-RVA: 0x2FBE850 Offset: 0x2FBE951 VA: 0x2FBE850
	|-Array.Reverse<object>
	|
	|-RVA: 0x2FBEA30 Offset: 0x2FBEB31 VA: 0x2FBEA30
	|-Array.Reverse<ObjectInitializationData>
	|
	|-RVA: 0x2FBEC90 Offset: 0x2FBED91 VA: 0x2FBEC90
	|-Array.Reverse<PlayableBinding>
	|
	|-RVA: 0x2FBEEC0 Offset: 0x2FBEFC1 VA: 0x2FBEEC0
	|-Array.Reverse<PlayerLoopSystem>
	|
	|-RVA: 0x2FBF120 Offset: 0x2FBF221 VA: 0x2FBF120
	|-Array.Reverse<PlayerLoopSystemInternal>
	|
	|-RVA: 0x2FBF380 Offset: 0x2FBF481 VA: 0x2FBF380
	|-Array.Reverse<RangePositionInfo>
	|
	|-RVA: 0x2FBF570 Offset: 0x2FBF671 VA: 0x2FBF570
	|-Array.Reverse<Ranking2ChartInfoInput>
	|
	|-RVA: 0x2FBF720 Offset: 0x2FBF821 VA: 0x2FBF720
	|-Array.Reverse<RaycastHit2D>
	|
	|-RVA: 0x2FBF960 Offset: 0x2FBFA61 VA: 0x2FBF960
	|-Array.Reverse<RaycastResult>
	|
	|-RVA: 0x2FBFBF0 Offset: 0x2FBFCF1 VA: 0x2FBFBF0
	|-Array.Reverse<Rect>
	|
	|-RVA: 0x2FBFDB0 Offset: 0x2FBFEB1 VA: 0x2FBFDB0
	|-Array.Reverse<RendererListHandle>
	|
	|-RVA: 0x2FBFF60 Offset: 0x2FC0061 VA: 0x2FBFF60
	|-Array.Reverse<ResourceHandle>
	|
	|-RVA: 0x2FC0110 Offset: 0x2FC0211 VA: 0x2FC0110
	|-Array.Reverse<sbyte>
	|
	|-RVA: 0x2FC02C0 Offset: 0x2FC03C1 VA: 0x2FC02C0
	|-Array.Reverse<ShaderTagId>
	|
	|-RVA: 0x2FC0470 Offset: 0x2FC0571 VA: 0x2FC0470
	|-Array.Reverse<float>
	|
	|-RVA: 0x2FC0620 Offset: 0x2FC0721 VA: 0x2FC0620
	|-Array.Reverse<SphericalHarmonicsL2>
	|
	|-RVA: 0x2FC08E0 Offset: 0x2FC09E1 VA: 0x2FC08E0
	|-Array.Reverse<SubMeshDescriptor>
	|
	|-RVA: 0x2FC0B10 Offset: 0x2FC0C11 VA: 0x2FC0B10
	|-Array.Reverse<TablePair>
	|
	|-RVA: 0x2FC0D00 Offset: 0x2FC0E01 VA: 0x2FC0D00
	|-Array.Reverse<TimeSpan>
	|
	|-RVA: 0x2FC0EB0 Offset: 0x2FC0FB1 VA: 0x2FC0EB0
	|-Array.Reverse<UICharInfo>
	|
	|-RVA: 0x2FC1070 Offset: 0x2FC1171 VA: 0x2FC1070
	|-Array.Reverse<UILineInfo>
	|
	|-RVA: 0x2FC1220 Offset: 0x2FC1321 VA: 0x2FC1220
	|-Array.Reverse<UIVertex>
	|
	|-RVA: 0x2FC14E0 Offset: 0x2FC15E1 VA: 0x2FC14E0
	|-Array.Reverse<ushort>
	|
	|-RVA: 0x2FC1690 Offset: 0x2FC1791 VA: 0x2FC1690
	|-Array.Reverse<uint>
	|
	|-RVA: 0x2FC1840 Offset: 0x2FC1941 VA: 0x2FC1840
	|-Array.Reverse<ulong>
	|
	|-RVA: 0x2FC19F0 Offset: 0x2FC1AF1 VA: 0x2FC19F0
	|-Array.Reverse<Vector2>
	|
	|-RVA: 0x2FC1BA0 Offset: 0x2FC1CA1 VA: 0x2FC1BA0
	|-Array.Reverse<Vector3>
	|
	|-RVA: 0x2FC1D60 Offset: 0x2FC1E61 VA: 0x2FC1D60
	|-Array.Reverse<Vector4>
	|
	|-RVA: 0x2FC1F20 Offset: 0x2FC2021 VA: 0x2FC1F20
	|-Array.Reverse<VertexAttributeDescriptor>
	|
	|-RVA: 0x2FC20D0 Offset: 0x2FC21D1 VA: 0x2FC20D0
	|-Array.Reverse<X509ChainStatus>
	|
	|-RVA: 0x2FC22C0 Offset: 0x2FC23C1 VA: 0x2FC22C0
	|-Array.Reverse<XRView>
	|
	|-RVA: 0x2FC2540 Offset: 0x2FC2641 VA: 0x2FC2540
	|-Array.Reverse<AmiiboSequence.GainItemData>
	|
	|-RVA: 0x2FC2730 Offset: 0x2FC2831 VA: 0x2FC2730
	|-Array.Reverse<AnimationOutputWeightProcessor.WeightInfo>
	|
	|-RVA: 0x2FC2960 Offset: 0x2FC2A61 VA: 0x2FC2960
	|-Array.Reverse<ArenaOrderSequence.GodInfo>
	|
	|-RVA: 0x2FC2B50 Offset: 0x2FC2C51 VA: 0x2FC2B50
	|-Array.Reverse<BattleInfo.SupportData>
	|
	|-RVA: 0x2FC2D40 Offset: 0x2FC2E41 VA: 0x2FC2D40
	|-Array.Reverse<BeforeRenderHelper.OrderBlock>
	|
	|-RVA: 0x2FC2F30 Offset: 0x2FC3031 VA: 0x2FC2F30
	|-Array.Reverse<Camera.RenderRequest>
	|
	|-RVA: 0x2FC3170 Offset: 0x2FC3271 VA: 0x2FC3170
	|-Array.Reverse<CameraState.CustomBlendable>
	|
	|-RVA: 0x2FC3360 Offset: 0x2FC3461 VA: 0x2FC3360
	|-Array.Reverse<CinemachineClearShot.Pair>
	|
	|-RVA: 0x2FC3510 Offset: 0x2FC3611 VA: 0x2FC3510
	|-Array.Reverse<CinemachineStateDrivenCamera.HashPair>
	|
	|-RVA: 0x2FC36C0 Offset: 0x2FC37C1 VA: 0x2FC36C0
	|-Array.Reverse<DelayedActionManager.DelegateInfo>
	|
	|-RVA: 0x2FC3900 Offset: 0x2FC3A01 VA: 0x2FC3900
	|-Array.Reverse<Detail.AsyncResultInt>
	|
	|-RVA: 0x2FC3B30 Offset: 0x2FC3C31 VA: 0x2FC3B30
	|-Array.Reverse<Detail.CppArray>
	|
	|-RVA: 0x2FC3CE0 Offset: 0x2FC3DE1 VA: 0x2FC3CE0
	|-Array.Reverse<Detail.NotificationEventInt>
	|
	|-RVA: 0x2FC3F10 Offset: 0x2FC4011 VA: 0x2FC3F10
	|-Array.Reverse<DragonRideTargetGroup.ChainParam>
	|
	|-RVA: 0x2FC4100 Offset: 0x2FC4201 VA: 0x2FC4100
	|-Array.Reverse<GmapPathAdjuster.TargetModel>
	|
	|-RVA: 0x2FC4330 Offset: 0x2FC4431 VA: 0x2FC4330
	|-Array.Reverse<GmapSpotAdjuster.TargetModel>
	|
	|-RVA: 0x2FC4560 Offset: 0x2FC4661 VA: 0x2FC4560
	|-Array.Reverse<HubFastTravel.Location>
	|
	|-RVA: 0x2FC4790 Offset: 0x2FC4891 VA: 0x2FC4790
	|-Array.Reverse<HubLensFlare.Flare>
	|
	|-RVA: 0x2FC49F0 Offset: 0x2FC4AF1 VA: 0x2FC49F0
	|-Array.Reverse<InventoryPoolItemMenuContent.KindBgNameClass>
	|
	|-RVA: 0x2FC4BE0 Offset: 0x2FC4CE1 VA: 0x2FC4BE0
	|-Array.Reverse<Map.Pos>
	|
	|-RVA: 0x2FC4D90 Offset: 0x2FC4E91 VA: 0x2FC4D90
	|-Array.Reverse<MapImage.BackupTerrain>
	|
	|-RVA: 0x2FC4F40 Offset: 0x2FC5041 VA: 0x2FC4F40
	|-Array.Reverse<MapImageRange.Pos>
	|
	|-RVA: 0x2FC5100 Offset: 0x2FC5201 VA: 0x2FC5100
	|-Array.Reverse<MapMind.Target>
	|
	|-RVA: 0x2FC5330 Offset: 0x2FC5431 VA: 0x2FC5330
	|-Array.Reverse<MapPanelDebug.Entity>
	|
	|-RVA: 0x2FC5520 Offset: 0x2FC5621 VA: 0x2FC5520
	|-Array.Reverse<NexRanking.Data>
	|
	|-RVA: 0x2FC56D0 Offset: 0x2FC57D1 VA: 0x2FC56D0
	|-Array.Reverse<NexVersus.RatingData>
	|
	|-RVA: 0x2FC5880 Offset: 0x2FC5981 VA: 0x2FC5880
	|-Array.Reverse<PackedPlayModeBuildLogs.RuntimeBuildLog>
	|
	|-RVA: 0x2FC5A70 Offset: 0x2FC5B71 VA: 0x2FC5A70
	|-Array.Reverse<ParticleSystem.Particle>
	|
	|-RVA: 0x2FC5CB0 Offset: 0x2FC5DB1 VA: 0x2FC5CB0
	|-Array.Reverse<RangeData.Offset>
	|
	|-RVA: 0x2FC5E60 Offset: 0x2FC5F61 VA: 0x2FC5E60
	|-Array.Reverse<RenderGraphDebugData.PassDebugData>
	|
	|-RVA: 0x2FC6090 Offset: 0x2FC6191 VA: 0x2FC6090
	|-Array.Reverse<RenderGraphDebugData.ResourceDebugData>
	|
	|-RVA: 0x2FC62F0 Offset: 0x2FC63F1 VA: 0x2FC62F0
	|-Array.Reverse<RingCleaningUnitSelectMenu.GodParam>
	|
	|-RVA: 0x2FC64E0 Offset: 0x2FC65E1 VA: 0x2FC64E0
	|-Array.Reverse<ShadowUtility.Edge>
	|
	|-RVA: 0x2FC6700 Offset: 0x2FC6801 VA: 0x2FC6700
	|-Array.Reverse<SkillArray.Entity>
	|
	|-RVA: 0x2FC68B0 Offset: 0x2FC69B1 VA: 0x2FC68B0
	|-Array.Reverse<TexturePacker_JsonArray.Frame>
	|
	|-RVA: 0x2FC6B20 Offset: 0x2FC6C21 VA: 0x2FC6B20
	|-Array.Reverse<TimeNotificationBehaviour.NotificationEntry>
	|
	|-RVA: 0x2FC6D60 Offset: 0x2FC6E61 VA: 0x2FC6D60
	|-Array.Reverse<UnitySynchronizationContext.WorkRequest>
	|
	|-RVA: 0x2FC6F90 Offset: 0x2FC7091 VA: 0x2FC6F90
	|-Array.Reverse<XmlSchemaObjectTable.XmlSchemaObjectEntry>
	|
	|-RVA: 0x2FC7180 Offset: 0x2FC7281 VA: 0x2FC7180
	|-Array.Reverse<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>
	|
	|-RVA: 0x2FC7370 Offset: 0x2FC7471 VA: 0x2FC7370
	|-Array.Reverse<Detail.DataStore.DataStoreChangeMetaParamInt>
	|
	|-RVA: 0x2FC75C0 Offset: 0x2FC76C1 VA: 0x2FC75C0
	|-Array.Reverse<Detail.DataStore.DataStoreDeleteParamInt>
	|
	|-RVA: 0x2FC7770 Offset: 0x2FC7871 VA: 0x2FC7770
	|-Array.Reverse<Detail.DataStore.DataStoreGetMetaParamInt>
	|
	|-RVA: 0x2FC79A0 Offset: 0x2FC7AA1 VA: 0x2FC79A0
	|-Array.Reverse<Detail.DataStore.DataStoreMetaInfoInt>
	|
	|-RVA: 0x2FC7BE0 Offset: 0x2FC7CE1 VA: 0x2FC7BE0
	|-Array.Reverse<Detail.DataStore.DataStorePasswordInfoInt>
	|
	|-RVA: 0x2FC7DD0 Offset: 0x2FC7ED1 VA: 0x2FC7DD0
	|-Array.Reverse<Detail.DataStore.DataStorePersistenceInfoInt>
	|
	|-RVA: 0x2FC7FC0 Offset: 0x2FC80C1 VA: 0x2FC7FC0
	|-Array.Reverse<Detail.DataStore.DataStorePreparePostParamInt>
	|
	|-RVA: 0x2FC8200 Offset: 0x2FC8301 VA: 0x2FC8200
	|-Array.Reverse<Detail.DataStore.DataStoreRateObjectParamInt>
	|
	|-RVA: 0x2FC83B0 Offset: 0x2FC84B1 VA: 0x2FC83B0
	|-Array.Reverse<Detail.DataStore.DataStoreRatingInitParamInt>
	|
	|-RVA: 0x2722120 Offset: 0x2722221 VA: 0x2722120
	|-Array.Reverse<Detail.DataStore.DataStoreRatingTargetInt>
	|
	|-RVA: 0x27222D0 Offset: 0x27223D1 VA: 0x27222D0
	|-Array.Reverse<Detail.Ranking.RankingCachedResultInt>
	|
	|-RVA: 0x2722520 Offset: 0x2722621 VA: 0x2722520
	|-Array.Reverse<Detail.Ranking.RankingOrderParamInt>
	|
	|-RVA: 0x27226D0 Offset: 0x27227D1 VA: 0x27226D0
	|-Array.Reverse<Detail.Ranking.RankingRankDataInt>
	|
	|-RVA: 0x2722920 Offset: 0x2722A21 VA: 0x2722920
	|-Array.Reverse<Detail.Ranking2.Ranking2ChartInfoInt>
	|
	|-RVA: 0x2722BA0 Offset: 0x2722CA1 VA: 0x2722BA0
	|-Array.Reverse<Detail.Ranking2.Ranking2RankDataInt>
	|
	|-RVA: 0x2722DF0 Offset: 0x2722EF1 VA: 0x2722DF0
	|-Array.Reverse<Detail.Ranking2.Ranking2ScoreDataInt>
	|
	|-RVA: 0x2722FA0 Offset: 0x27230A1 VA: 0x2722FA0
	|-Array.Reverse<Detail.Screening.ScreeningContextInfoInt>
	|
	|-RVA: 0x2723190 Offset: 0x2723291 VA: 0x2723190
	|-Array.Reverse<Detail.Subscriber.SubscriberContentInt>
	|
	|-RVA: 0x2723400 Offset: 0x2723501 VA: 0x2723400
	|-Array.Reverse<Detail.Subscriber.SubscriberGetContentParamInt>
	|
	|-RVA: 0x27235F0 Offset: 0x27236F1 VA: 0x27235F0
	|-Array.Reverse<Detail.Subscriber.SubscriberUserStatusInfoInt>
	|
	|-RVA: 0x2723820 Offset: 0x2723921 VA: 0x2723820
	|-Array.Reverse<Detail.Subscriber.SubscriberUserStatusParamInt>
	|
	|-RVA: 0x2723A10 Offset: 0x2723B11 VA: 0x2723A10
	|-Array.Reverse<Detail.Utility.IntegerSettings>
	|
	|-RVA: 0x2723BC0 Offset: 0x2723CC1 VA: 0x2723BC0
	|-Array.Reverse<Detail.Utility.UniqueIdInfoInt>
	|
	|-RVA: 0x2723D70 Offset: 0x2723E71 VA: 0x2723D70
	|-Array.Reverse<MapHistory.Rewind.LatestInspectorData>
	|
	|-RVA: 0x2723F40 Offset: 0x2724041 VA: 0x2723F40
	|-Array.Reverse<MapHistory.Rewind.WorkTerrainData>
	|
	|-RVA: 0x2724110 Offset: 0x2724211 VA: 0x2724110
	|-Array.Reverse<MapSkill.AroundCalculator.Result>
	|
	|-RVA: 0x2724300 Offset: 0x2724401 VA: 0x2724300
	|-Array.Reverse<TargetPositionCache.CacheCurve.Item>
	|
	|-RVA: 0x2724520 Offset: 0x2724621 VA: 0x2724520
	|-Array.Reverse<TargetPositionCache.CacheEntry.RecordingItem>
	*/

	// RVA: 0x35632A0 Offset: 0x35633A1 VA: 0x35632A0
	public void SetValue(object value, long index) { }

	// RVA: 0x3563310 Offset: 0x3563411 VA: 0x3563310
	public void SetValue(object value, long index1, long index2) { }

	// RVA: 0x3563450 Offset: 0x3563551 VA: 0x3563450
	public void SetValue(object value, long index1, long index2, long index3) { }

	// RVA: 0x35635E0 Offset: 0x35636E1 VA: 0x35635E0
	public void SetValue(object value, long[] indices) { }

	// RVA: 0x3563790 Offset: 0x3563891 VA: 0x3563790
	public static void Sort(Array array) { }

	// RVA: 0x3563B40 Offset: 0x3563C41 VA: 0x3563B40
	public static void Sort(Array array, int index, int length) { }

	// RVA: 0x3563B60 Offset: 0x3563C61 VA: 0x3563B60
	public static void Sort(Array array, IComparer comparer) { }

	// RVA: 0x3563C40 Offset: 0x3563D41 VA: 0x3563C40
	public static void Sort(Array array, int index, int length, IComparer comparer) { }

	// RVA: 0x3563C60 Offset: 0x3563D61 VA: 0x3563C60
	public static void Sort(Array keys, Array items) { }

	// RVA: 0x3563D40 Offset: 0x3563E41 VA: 0x3563D40
	public static void Sort(Array keys, Array items, IComparer comparer) { }

	// RVA: 0x3563E30 Offset: 0x3563F31 VA: 0x3563E30
	public static void Sort(Array keys, Array items, int index, int length) { }

	// RVA: 0x3563870 Offset: 0x3563971 VA: 0x3563870
	public static void Sort(Array keys, Array items, int index, int length, IComparer comparer) { }

	// RVA: -1 Offset: -1
	public static void Sort<T>(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2724760 Offset: 0x2724861 VA: 0x2724760
	|-Array.Sort<object>
	|
	|-RVA: 0x27247E0 Offset: 0x27248E1 VA: 0x27247E0
	|-Array.Sort<float>
	*/

	// RVA: -1 Offset: -1
	public static void Sort<T>(T[] array, int index, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2724C40 Offset: 0x2724D41 VA: 0x2724C40
	|-Array.Sort<object>
	|-Array.Sort<XmlTextReaderImpl.NodeData>
	|
	|-RVA: 0x2724C60 Offset: 0x2724D61 VA: 0x2724C60
	|-Array.Sort<AIThink.EnchantThink.ItemInfo>
	*/

	// RVA: -1 Offset: -1
	public static void Sort<T>(T[] array, IComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2724860 Offset: 0x2724961 VA: 0x2724860
	|-Array.Sort<int>
	|
	|-RVA: 0x27248E0 Offset: 0x27249E1 VA: 0x27248E0
	|-Array.Sort<object>
	|-Array.Sort<AICrossfire.Fire>
	|
	|-RVA: 0x2724A00 Offset: 0x2724B01 VA: 0x2724A00
	|-Array.Sort<DeferredTiler.PrePunctualLight>
	*/

	// RVA: -1 Offset: -1
	public static void Sort<T>(T[] array, int index, int length, IComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2724D80 Offset: 0x2724E81 VA: 0x2724D80
	|-Array.Sort<IntervalTree.Entry<object>>
	|
	|-RVA: 0x2724EC0 Offset: 0x2724FC1 VA: 0x2724EC0
	|-Array.Sort<KeyValuePair<DateTime, object>>
	|
	|-RVA: 0x2725000 Offset: 0x2725101 VA: 0x2725000
	|-Array.Sort<KeyValuePair<int, object>>
	|
	|-RVA: 0x2725140 Offset: 0x2725241 VA: 0x2725140
	|-Array.Sort<KeyValuePair<object, ValueTuple<int, DateTime, object>>>
	|
	|-RVA: 0x2725280 Offset: 0x2725381 VA: 0x2725280
	|-Array.Sort<KeyValuePair<object, object>>
	|
	|-RVA: 0x27253C0 Offset: 0x27254C1 VA: 0x27253C0
	|-Array.Sort<CommonBattleSequence.Reliance<object>>
	|
	|-RVA: 0x2725500 Offset: 0x2725601 VA: 0x2725500
	|-Array.Sort<RenderGraphResourcePool.ResourceLogInfo<object>>
	|
	|-RVA: 0x2725640 Offset: 0x2725741 VA: 0x2725640
	|-Array.Sort<ValueTuple<int, object>>
	|
	|-RVA: 0x2725780 Offset: 0x2725881 VA: 0x2725780
	|-Array.Sort<ValueTuple<Int32Enum, int>>
	|
	|-RVA: 0x27258C0 Offset: 0x27259C1 VA: 0x27258C0
	|-Array.Sort<ValueTuple<object, ValueTuple<object, int>>>
	|
	|-RVA: 0x2725A00 Offset: 0x2725B01 VA: 0x2725A00
	|-Array.Sort<ValueTuple<object, int>>
	|
	|-RVA: 0x2725B40 Offset: 0x2725C41 VA: 0x2725B40
	|-Array.Sort<ValueTuple<Vector3, float>>
	|
	|-RVA: 0x2725C80 Offset: 0x2725D81 VA: 0x2725C80
	|-Array.Sort<ValueTuple<object, Int32Enum, int>>
	|
	|-RVA: 0x2725DC0 Offset: 0x2725EC1 VA: 0x2725DC0
	|-Array.Sort<ValueTuple<object, int, int, int>>
	|
	|-RVA: 0x2725F00 Offset: 0x2726001 VA: 0x2725F00
	|-Array.Sort<AnimatorClipInfo>
	|
	|-RVA: 0x2726040 Offset: 0x2726141 VA: 0x2726040
	|-Array.Sort<AsyncOperationHandle>
	|
	|-RVA: 0x2726180 Offset: 0x2726281 VA: 0x2726180
	|-Array.Sort<BoneWeight>
	|
	|-RVA: 0x27262C0 Offset: 0x27263C1 VA: 0x27262C0
	|-Array.Sort<bool>
	|
	|-RVA: 0x2726400 Offset: 0x2726501 VA: 0x2726400
	|-Array.Sort<byte>
	|
	|-RVA: 0x2726540 Offset: 0x2726641 VA: 0x2726540
	|-Array.Sort<CameraInfo>
	|
	|-RVA: 0x2726680 Offset: 0x2726781 VA: 0x2726680
	|-Array.Sort<char>
	|
	|-RVA: 0x27267C0 Offset: 0x27268C1 VA: 0x27267C0
	|-Array.Sort<Color>
	|
	|-RVA: 0x2726900 Offset: 0x2726A01 VA: 0x2726900
	|-Array.Sort<Color32>
	|
	|-RVA: 0x2726A40 Offset: 0x2726B41 VA: 0x2726A40
	|-Array.Sort<ConstraintSource>
	|
	|-RVA: 0x2726B80 Offset: 0x2726C81 VA: 0x2726B80
	|-Array.Sort<ContourVertex>
	|
	|-RVA: 0x2726CC0 Offset: 0x2726DC1 VA: 0x2726CC0
	|-Array.Sort<DataStoreRatingInfo>
	|
	|-RVA: 0x2726E00 Offset: 0x2726F01 VA: 0x2726E00
	|-Array.Sort<DataStoreResult>
	|
	|-RVA: 0x2726F40 Offset: 0x2727041 VA: 0x2726F40
	|-Array.Sort<DateTime>
	|
	|-RVA: 0x2727080 Offset: 0x2727181 VA: 0x2727080
	|-Array.Sort<DateTimeOffset>
	|
	|-RVA: 0x27271C0 Offset: 0x27272C1 VA: 0x27271C0
	|-Array.Sort<Decimal>
	|
	|-RVA: 0x2727300 Offset: 0x2727401 VA: 0x2727300
	|-Array.Sort<DiagnosticEvent>
	|
	|-RVA: 0x2727440 Offset: 0x2727541 VA: 0x2727440
	|-Array.Sort<double>
	|
	|-RVA: 0x2727580 Offset: 0x2727681 VA: 0x2727580
	|-Array.Sort<Friend>
	|
	|-RVA: 0x27276C0 Offset: 0x27277C1 VA: 0x27276C0
	|-Array.Sort<GlyphRect>
	|
	|-RVA: 0x2727800 Offset: 0x2727901 VA: 0x2727800
	|-Array.Sort<short>
	|
	|-RVA: 0x2727940 Offset: 0x2727A41 VA: 0x2727940
	|-Array.Sort<int>
	|
	|-RVA: 0x2727A80 Offset: 0x2727B81 VA: 0x2727A80
	|-Array.Sort<Int32Enum>
	|
	|-RVA: 0x2727BC0 Offset: 0x2727CC1 VA: 0x2727BC0
	|-Array.Sort<long>
	|
	|-RVA: 0x2727D00 Offset: 0x2727E01 VA: 0x2727D00
	|-Array.Sort<IntPtr>
	|
	|-RVA: 0x2727E40 Offset: 0x2727F41 VA: 0x2727E40
	|-Array.Sort<InterpretedFrameInfo>
	|
	|-RVA: 0x2727F80 Offset: 0x2728081 VA: 0x2727F80
	|-Array.Sort<IntervalTreeNode>
	|
	|-RVA: 0x27280C0 Offset: 0x27281C1 VA: 0x27280C0
	|-Array.Sort<LengthLimitProperties>
	|
	|-RVA: 0x2728200 Offset: 0x2728301 VA: 0x2728200
	|-Array.Sort<MapPos>
	|
	|-RVA: 0x2728340 Offset: 0x2728441 VA: 0x2728340
	|-Array.Sort<Matrix4x4>
	|
	|-RVA: 0x2728480 Offset: 0x2728581 VA: 0x2728480
	|-Array.Sort<object>
	|
	|-RVA: 0x27285C0 Offset: 0x27286C1 VA: 0x27285C0
	|-Array.Sort<ObjectInitializationData>
	|
	|-RVA: 0x2728700 Offset: 0x2728801 VA: 0x2728700
	|-Array.Sort<PlayableBinding>
	|
	|-RVA: 0x2728840 Offset: 0x2728941 VA: 0x2728840
	|-Array.Sort<PlayerLoopSystem>
	|
	|-RVA: 0x2728980 Offset: 0x2728A81 VA: 0x2728980
	|-Array.Sort<PlayerLoopSystemInternal>
	|
	|-RVA: 0x2728AC0 Offset: 0x2728BC1 VA: 0x2728AC0
	|-Array.Sort<RangePositionInfo>
	|
	|-RVA: 0x2728C00 Offset: 0x2728D01 VA: 0x2728C00
	|-Array.Sort<Ranking2ChartInfoInput>
	|
	|-RVA: 0x2728D40 Offset: 0x2728E41 VA: 0x2728D40
	|-Array.Sort<RaycastHit>
	|
	|-RVA: 0x2728E80 Offset: 0x2728F81 VA: 0x2728E80
	|-Array.Sort<RaycastHit2D>
	|
	|-RVA: 0x2728FC0 Offset: 0x27290C1 VA: 0x2728FC0
	|-Array.Sort<RaycastResult>
	|
	|-RVA: 0x2729100 Offset: 0x2729201 VA: 0x2729100
	|-Array.Sort<Rect>
	|
	|-RVA: 0x2729240 Offset: 0x2729341 VA: 0x2729240
	|-Array.Sort<RendererListHandle>
	|
	|-RVA: 0x2729380 Offset: 0x2729481 VA: 0x2729380
	|-Array.Sort<ResourceHandle>
	|
	|-RVA: 0x27294C0 Offset: 0x27295C1 VA: 0x27294C0
	|-Array.Sort<sbyte>
	|
	|-RVA: 0x2729600 Offset: 0x2729701 VA: 0x2729600
	|-Array.Sort<ShaderTagId>
	|
	|-RVA: 0x2729740 Offset: 0x2729841 VA: 0x2729740
	|-Array.Sort<float>
	|
	|-RVA: 0x2729880 Offset: 0x2729981 VA: 0x2729880
	|-Array.Sort<SphericalHarmonicsL2>
	|
	|-RVA: 0x27299C0 Offset: 0x2729AC1 VA: 0x27299C0
	|-Array.Sort<SubMeshDescriptor>
	|
	|-RVA: 0x2729B00 Offset: 0x2729C01 VA: 0x2729B00
	|-Array.Sort<TablePair>
	|
	|-RVA: 0x2729C40 Offset: 0x2729D41 VA: 0x2729C40
	|-Array.Sort<TimeSpan>
	|
	|-RVA: 0x2729D80 Offset: 0x2729E81 VA: 0x2729D80
	|-Array.Sort<UICharInfo>
	|
	|-RVA: 0x2729EC0 Offset: 0x2729FC1 VA: 0x2729EC0
	|-Array.Sort<UILineInfo>
	|
	|-RVA: 0x272A000 Offset: 0x272A101 VA: 0x272A000
	|-Array.Sort<UIVertex>
	|
	|-RVA: 0x272A140 Offset: 0x272A241 VA: 0x272A140
	|-Array.Sort<ushort>
	|
	|-RVA: 0x272A280 Offset: 0x272A381 VA: 0x272A280
	|-Array.Sort<uint>
	|
	|-RVA: 0x272A3C0 Offset: 0x272A4C1 VA: 0x272A3C0
	|-Array.Sort<ulong>
	|
	|-RVA: 0x272A500 Offset: 0x272A601 VA: 0x272A500
	|-Array.Sort<Vector2>
	|
	|-RVA: 0x272A640 Offset: 0x272A741 VA: 0x272A640
	|-Array.Sort<Vector3>
	|
	|-RVA: 0x272A780 Offset: 0x272A881 VA: 0x272A780
	|-Array.Sort<Vector4>
	|
	|-RVA: 0x272A8C0 Offset: 0x272A9C1 VA: 0x272A8C0
	|-Array.Sort<VertexAttributeDescriptor>
	|
	|-RVA: 0x272AA00 Offset: 0x272AB01 VA: 0x272AA00
	|-Array.Sort<X509ChainStatus>
	|
	|-RVA: 0x272AB40 Offset: 0x272AC41 VA: 0x272AB40
	|-Array.Sort<XRView>
	|
	|-RVA: 0x272AC80 Offset: 0x272AD81 VA: 0x272AC80
	|-Array.Sort<AmiiboSequence.GainItemData>
	|
	|-RVA: 0x272ADC0 Offset: 0x272AEC1 VA: 0x272ADC0
	|-Array.Sort<AnimationOutputWeightProcessor.WeightInfo>
	|
	|-RVA: 0x272AF00 Offset: 0x272B001 VA: 0x272AF00
	|-Array.Sort<ArenaOrderSequence.GodInfo>
	|
	|-RVA: 0x272B040 Offset: 0x272B141 VA: 0x272B040
	|-Array.Sort<BattleInfo.SupportData>
	|
	|-RVA: 0x272B180 Offset: 0x272B281 VA: 0x272B180
	|-Array.Sort<BeforeRenderHelper.OrderBlock>
	|
	|-RVA: 0x272B2C0 Offset: 0x272B3C1 VA: 0x272B2C0
	|-Array.Sort<Camera.RenderRequest>
	|
	|-RVA: 0x272B400 Offset: 0x272B501 VA: 0x272B400
	|-Array.Sort<CameraState.CustomBlendable>
	|
	|-RVA: 0x272B540 Offset: 0x272B641 VA: 0x272B540
	|-Array.Sort<CinemachineClearShot.Pair>
	|
	|-RVA: 0x272B680 Offset: 0x272B781 VA: 0x272B680
	|-Array.Sort<CinemachineStateDrivenCamera.HashPair>
	|
	|-RVA: 0x272B7C0 Offset: 0x272B8C1 VA: 0x272B7C0
	|-Array.Sort<DeferredTiler.PrePunctualLight>
	|
	|-RVA: 0x272B900 Offset: 0x272BA01 VA: 0x272B900
	|-Array.Sort<DelayedActionManager.DelegateInfo>
	|
	|-RVA: 0x272BA40 Offset: 0x272BB41 VA: 0x272BA40
	|-Array.Sort<Detail.AsyncResultInt>
	|
	|-RVA: 0x272BB80 Offset: 0x272BC81 VA: 0x272BB80
	|-Array.Sort<Detail.CppArray>
	|
	|-RVA: 0x272BCC0 Offset: 0x272BDC1 VA: 0x272BCC0
	|-Array.Sort<Detail.NotificationEventInt>
	|
	|-RVA: 0x272BE00 Offset: 0x272BF01 VA: 0x272BE00
	|-Array.Sort<DragonRideTargetGroup.ChainParam>
	|
	|-RVA: 0x272BF40 Offset: 0x272C041 VA: 0x272BF40
	|-Array.Sort<GmapPathAdjuster.TargetModel>
	|
	|-RVA: 0x272C080 Offset: 0x272C181 VA: 0x272C080
	|-Array.Sort<GmapSpotAdjuster.TargetModel>
	|
	|-RVA: 0x272C1C0 Offset: 0x272C2C1 VA: 0x272C1C0
	|-Array.Sort<HubFastTravel.Location>
	|
	|-RVA: 0x272C300 Offset: 0x272C401 VA: 0x272C300
	|-Array.Sort<HubLensFlare.Flare>
	|
	|-RVA: 0x272C440 Offset: 0x272C541 VA: 0x272C440
	|-Array.Sort<InventoryPoolItemMenuContent.KindBgNameClass>
	|
	|-RVA: 0x272C580 Offset: 0x272C681 VA: 0x272C580
	|-Array.Sort<Map.Pos>
	|
	|-RVA: 0x272C6C0 Offset: 0x272C7C1 VA: 0x272C6C0
	|-Array.Sort<MapImage.BackupTerrain>
	|
	|-RVA: 0x272C800 Offset: 0x272C901 VA: 0x272C800
	|-Array.Sort<MapImageRange.Pos>
	|
	|-RVA: 0x272C940 Offset: 0x272CA41 VA: 0x272C940
	|-Array.Sort<MapMind.Target>
	|
	|-RVA: 0x272CA80 Offset: 0x272CB81 VA: 0x272CA80
	|-Array.Sort<MapPanelDebug.Entity>
	|
	|-RVA: 0x272CBC0 Offset: 0x272CCC1 VA: 0x272CBC0
	|-Array.Sort<NexRanking.Data>
	|
	|-RVA: 0x272CD00 Offset: 0x272CE01 VA: 0x272CD00
	|-Array.Sort<NexVersus.RatingData>
	|
	|-RVA: 0x272CE40 Offset: 0x272CF41 VA: 0x272CE40
	|-Array.Sort<PackedPlayModeBuildLogs.RuntimeBuildLog>
	|
	|-RVA: 0x272CF80 Offset: 0x272D081 VA: 0x272CF80
	|-Array.Sort<ParticleSystem.Particle>
	|
	|-RVA: 0x272D0C0 Offset: 0x272D1C1 VA: 0x272D0C0
	|-Array.Sort<RangeData.Offset>
	|
	|-RVA: 0x272D200 Offset: 0x272D301 VA: 0x272D200
	|-Array.Sort<RenderGraphDebugData.PassDebugData>
	|
	|-RVA: 0x272D340 Offset: 0x272D441 VA: 0x272D340
	|-Array.Sort<RenderGraphDebugData.ResourceDebugData>
	|
	|-RVA: 0x272D480 Offset: 0x272D581 VA: 0x272D480
	|-Array.Sort<RingCleaningUnitSelectMenu.GodParam>
	|
	|-RVA: 0x272D5C0 Offset: 0x272D6C1 VA: 0x272D5C0
	|-Array.Sort<ShadowUtility.Edge>
	|
	|-RVA: 0x272D700 Offset: 0x272D801 VA: 0x272D700
	|-Array.Sort<SkillArray.Entity>
	|
	|-RVA: 0x272D840 Offset: 0x272D941 VA: 0x272D840
	|-Array.Sort<TexturePacker_JsonArray.Frame>
	|
	|-RVA: 0x272D980 Offset: 0x272DA81 VA: 0x272D980
	|-Array.Sort<TimeNotificationBehaviour.NotificationEntry>
	|
	|-RVA: 0x272DAC0 Offset: 0x272DBC1 VA: 0x272DAC0
	|-Array.Sort<UnitySynchronizationContext.WorkRequest>
	|
	|-RVA: 0x272DC00 Offset: 0x272DD01 VA: 0x272DC00
	|-Array.Sort<XmlSchemaObjectTable.XmlSchemaObjectEntry>
	|
	|-RVA: 0x272DD40 Offset: 0x272DE41 VA: 0x272DD40
	|-Array.Sort<AIThink.EnchantThink.ItemInfo>
	|
	|-RVA: 0x272DE80 Offset: 0x272DF81 VA: 0x272DE80
	|-Array.Sort<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>
	|
	|-RVA: 0x272DFC0 Offset: 0x272E0C1 VA: 0x272DFC0
	|-Array.Sort<Detail.DataStore.DataStoreChangeMetaParamInt>
	|
	|-RVA: 0x272E100 Offset: 0x272E201 VA: 0x272E100
	|-Array.Sort<Detail.DataStore.DataStoreDeleteParamInt>
	|
	|-RVA: 0x272E240 Offset: 0x272E341 VA: 0x272E240
	|-Array.Sort<Detail.DataStore.DataStoreGetMetaParamInt>
	|
	|-RVA: 0x272E380 Offset: 0x272E481 VA: 0x272E380
	|-Array.Sort<Detail.DataStore.DataStoreMetaInfoInt>
	|
	|-RVA: 0x272E4C0 Offset: 0x272E5C1 VA: 0x272E4C0
	|-Array.Sort<Detail.DataStore.DataStorePasswordInfoInt>
	|
	|-RVA: 0x272E600 Offset: 0x272E701 VA: 0x272E600
	|-Array.Sort<Detail.DataStore.DataStorePersistenceInfoInt>
	|
	|-RVA: 0x272E740 Offset: 0x272E841 VA: 0x272E740
	|-Array.Sort<Detail.DataStore.DataStorePreparePostParamInt>
	|
	|-RVA: 0x272E880 Offset: 0x272E981 VA: 0x272E880
	|-Array.Sort<Detail.DataStore.DataStoreRateObjectParamInt>
	|
	|-RVA: 0x272E9C0 Offset: 0x272EAC1 VA: 0x272E9C0
	|-Array.Sort<Detail.DataStore.DataStoreRatingInitParamInt>
	|
	|-RVA: 0x272EB00 Offset: 0x272EC01 VA: 0x272EB00
	|-Array.Sort<Detail.DataStore.DataStoreRatingTargetInt>
	|
	|-RVA: 0x272EC40 Offset: 0x272ED41 VA: 0x272EC40
	|-Array.Sort<Detail.Ranking.RankingCachedResultInt>
	|
	|-RVA: 0x272ED80 Offset: 0x272EE81 VA: 0x272ED80
	|-Array.Sort<Detail.Ranking.RankingOrderParamInt>
	|
	|-RVA: 0x272EEC0 Offset: 0x272EFC1 VA: 0x272EEC0
	|-Array.Sort<Detail.Ranking.RankingRankDataInt>
	|
	|-RVA: 0x272F000 Offset: 0x272F101 VA: 0x272F000
	|-Array.Sort<Detail.Ranking2.Ranking2ChartInfoInt>
	|
	|-RVA: 0x272F140 Offset: 0x272F241 VA: 0x272F140
	|-Array.Sort<Detail.Ranking2.Ranking2RankDataInt>
	|
	|-RVA: 0x272F280 Offset: 0x272F381 VA: 0x272F280
	|-Array.Sort<Detail.Ranking2.Ranking2ScoreDataInt>
	|
	|-RVA: 0x272F3C0 Offset: 0x272F4C1 VA: 0x272F3C0
	|-Array.Sort<Detail.Screening.ScreeningContextInfoInt>
	|
	|-RVA: 0x272F500 Offset: 0x272F601 VA: 0x272F500
	|-Array.Sort<Detail.Subscriber.SubscriberContentInt>
	|
	|-RVA: 0x272F640 Offset: 0x272F741 VA: 0x272F640
	|-Array.Sort<Detail.Subscriber.SubscriberGetContentParamInt>
	|
	|-RVA: 0x272F780 Offset: 0x272F881 VA: 0x272F780
	|-Array.Sort<Detail.Subscriber.SubscriberUserStatusInfoInt>
	|
	|-RVA: 0x272F8C0 Offset: 0x272F9C1 VA: 0x272F8C0
	|-Array.Sort<Detail.Subscriber.SubscriberUserStatusParamInt>
	|
	|-RVA: 0x272FA00 Offset: 0x272FB01 VA: 0x272FA00
	|-Array.Sort<Detail.Utility.IntegerSettings>
	|
	|-RVA: 0x272FB40 Offset: 0x272FC41 VA: 0x272FB40
	|-Array.Sort<Detail.Utility.UniqueIdInfoInt>
	|
	|-RVA: 0x272FC80 Offset: 0x272FD81 VA: 0x272FC80
	|-Array.Sort<MapHistory.Rewind.LatestInspectorData>
	|
	|-RVA: 0x272FDC0 Offset: 0x272FEC1 VA: 0x272FDC0
	|-Array.Sort<MapHistory.Rewind.WorkTerrainData>
	|
	|-RVA: 0x272FF00 Offset: 0x2730001 VA: 0x272FF00
	|-Array.Sort<MapSkill.AroundCalculator.Result>
	|
	|-RVA: 0x2730040 Offset: 0x2730141 VA: 0x2730040
	|-Array.Sort<TargetPositionCache.CacheCurve.Item>
	|
	|-RVA: 0x2730180 Offset: 0x2730281 VA: 0x2730180
	|-Array.Sort<TargetPositionCache.CacheEntry.RecordingItem>
	*/

	// RVA: -1 Offset: -1
	public static void Sort<T>(T[] array, Comparison<T> comparison) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2724960 Offset: 0x2724A61 VA: 0x2724960
	|-Array.Sort<Camera>
	|-Array.Sort<ItemData>
	|-Array.Sort<object>
	|-Array.Sort<string>
	|-Array.Sort<TimelineClip>
	|
	|-RVA: 0x2724A80 Offset: 0x2724B81 VA: 0x2724A80
	|-Array.Sort<ProfileCard.SortieCount>
	|
	|-RVA: 0x2724B20 Offset: 0x2724C21 VA: 0x2724B20
	|-Array.Sort<MapKillBonus.Work.Pos>
	*/

	// RVA: -1 Offset: -1
	public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2724BC0 Offset: 0x2724CC1 VA: 0x2724BC0
	|-Array.Sort<object, object>
	*/

	// RVA: -1 Offset: -1
	public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items, int index, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27302C0 Offset: 0x27303C1 VA: 0x27302C0
	|-Array.Sort<object, object>
	*/

	// RVA: -1 Offset: -1
	public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2724C80 Offset: 0x2724D81 VA: 0x2724C80
	|-Array.Sort<object, object>
	|
	|-RVA: 0x2724D00 Offset: 0x2724E01 VA: 0x2724D00
	|-Array.Sort<ulong, object>
	|-Array.Sort<ulong, string>
	*/

	// RVA: -1 Offset: -1
	public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items, int index, int length, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27302E0 Offset: 0x27303E1 VA: 0x27302E0
	|-Array.Sort<object, object>
	|
	|-RVA: 0x27304C0 Offset: 0x27305C1 VA: 0x27304C0
	|-Array.Sort<ulong, object>
	*/

	// RVA: -1 Offset: -1
	public static bool Exists<T>(T[] array, Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x328D410 Offset: 0x328D511 VA: 0x328D410
	|-Array.Exists<object>
	|-Array.Exists<string>
	*/

	// RVA: -1 Offset: -1
	public static void Fill<T>(T[] array, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x328D440 Offset: 0x328D541 VA: 0x328D440
	|-Array.Fill<object>
	*/

	// RVA: -1 Offset: -1
	public static void Fill<T>(T[] array, T value, int startIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x328D510 Offset: 0x328D611 VA: 0x328D510
	|-Array.Fill<object>
	*/

	// RVA: -1 Offset: -1
	public static T Find<T>(T[] array, Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x328D690 Offset: 0x328D791 VA: 0x328D690
	|-Array.Find<object>
	*/

	// RVA: -1 Offset: -1
	public static T[] FindAll<T>(T[] array, Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x328D7B0 Offset: 0x328D8B1 VA: 0x328D7B0
	|-Array.FindAll<object>
	*/

	// RVA: -1 Offset: -1
	public static int FindIndex<T>(T[] array, Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x328D9E0 Offset: 0x328DAE1 VA: 0x328D9E0
	|-Array.FindIndex<object>
	|-Array.FindIndex<string>
	*/

	// RVA: -1 Offset: -1
	public static int FindIndex<T>(T[] array, int startIndex, Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x328DA60 Offset: 0x328DB61 VA: 0x328DA60
	|-Array.FindIndex<object>
	*/

	// RVA: -1 Offset: -1
	public static int FindIndex<T>(T[] array, int startIndex, int count, Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x328DAE0 Offset: 0x328DBE1 VA: 0x328DAE0
	|-Array.FindIndex<object>
	*/

	// RVA: -1 Offset: -1
	public static T FindLast<T>(T[] array, Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x328DCA0 Offset: 0x328DDA1 VA: 0x328DCA0
	|-Array.FindLast<object>
	*/

	// RVA: -1 Offset: -1
	public static int FindLastIndex<T>(T[] array, Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x328DDA0 Offset: 0x328DEA1 VA: 0x328DDA0
	|-Array.FindLastIndex<object>
	*/

	// RVA: -1 Offset: -1
	public static int FindLastIndex<T>(T[] array, int startIndex, Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x328DE20 Offset: 0x328DF21 VA: 0x328DE20
	|-Array.FindLastIndex<object>
	*/

	// RVA: -1 Offset: -1
	public static int FindLastIndex<T>(T[] array, int startIndex, int count, Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x328DEA0 Offset: 0x328DFA1 VA: 0x328DEA0
	|-Array.FindLastIndex<object>
	*/

	// RVA: -1 Offset: -1
	public static bool TrueForAll<T>(T[] array, Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27306A0 Offset: 0x27307A1 VA: 0x27306A0
	|-Array.TrueForAll<object>
	*/

	// RVA: 0x3563F50 Offset: 0x3564051 VA: 0x3563F50 Slot: 8
	public IEnumerator GetEnumerator() { }

	// RVA: 0x3563FC0 Offset: 0x35640C1 VA: 0x3563FC0
	private void .ctor() { }

	// RVA: 0x3563FD0 Offset: 0x35640D1 VA: 0x3563FD0
	internal int InternalArray__ICollection_get_Count() { }

	// RVA: 0x3564040 Offset: 0x3564141 VA: 0x3564040
	internal bool InternalArray__ICollection_get_IsReadOnly() { }

	// RVA: -1 Offset: -1
	internal IEnumerator<T> InternalArray__IEnumerable_GetEnumerator<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1C87B00 Offset: 0x1C87C01 VA: 0x1C87B00
	|-Array.InternalArray__IEnumerable_GetEnumerator<ArraySegment<byte>>
	|
	|-RVA: 0x1C87C10 Offset: 0x1C87D11 VA: 0x1C87C10
	|-Array.InternalArray__IEnumerable_GetEnumerator<AsyncOperationHandle<object>>
	|
	|-RVA: 0x1C87D20 Offset: 0x1C87E21 VA: 0x1C87D20
	|-Array.InternalArray__IEnumerable_GetEnumerator<MapDeployTemplate.Queue.Data<object>>
	|
	|-RVA: 0x1C87E30 Offset: 0x1C87F31 VA: 0x1C87E30
	|-Array.InternalArray__IEnumerable_GetEnumerator<Nex.DataStore.ParamPool.Data<object>>
	|
	|-RVA: 0x1C87F40 Offset: 0x1C88041 VA: 0x1C87F40
	|-Array.InternalArray__IEnumerable_GetEnumerator<Nex.Screening.ParamPool.Data<object>>
	|
	|-RVA: 0x1C88050 Offset: 0x1C88151 VA: 0x1C88050
	|-Array.InternalArray__IEnumerable_GetEnumerator<IntervalTree.Entry<object>>
	|
	|-RVA: 0x1C88160 Offset: 0x1C88261 VA: 0x1C88160
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<ValueTuple<object, int>, object>>
	|
	|-RVA: 0x1C88270 Offset: 0x1C88371 VA: 0x1C88270
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<byte, object>>
	|
	|-RVA: 0x1C88380 Offset: 0x1C88481 VA: 0x1C88380
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<CancellationToken, object>>
	|
	|-RVA: 0x1C88490 Offset: 0x1C88591 VA: 0x1C88490
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<char, object>>
	|
	|-RVA: 0x1C885A0 Offset: 0x1C886A1 VA: 0x1C885A0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Guid, object>>
	|
	|-RVA: 0x1C886B0 Offset: 0x1C887B1 VA: 0x1C886B0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<int, bool>>
	|
	|-RVA: 0x1C887C0 Offset: 0x1C888C1 VA: 0x1C887C0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<int, byte>>
	|
	|-RVA: 0x1C888D0 Offset: 0x1C889D1 VA: 0x1C888D0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<int, char>>
	|
	|-RVA: 0x1C889E0 Offset: 0x1C88AE1 VA: 0x1C889E0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<int, DiagnosticEvent>>
	|
	|-RVA: 0x1C88AF0 Offset: 0x1C88BF1 VA: 0x1C88AF0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<int, int>>
	|
	|-RVA: 0x1C88C00 Offset: 0x1C88D01 VA: 0x1C88C00
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<int, Int32Enum>>
	|
	|-RVA: 0x1C88D10 Offset: 0x1C88E11 VA: 0x1C88D10
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<int, long>>
	|
	|-RVA: 0x1C88E20 Offset: 0x1C88F21 VA: 0x1C88E20
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<int, MapPos>>
	|
	|-RVA: 0x1C88F30 Offset: 0x1C89031 VA: 0x1C88F30
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<int, object>>
	|
	|-RVA: 0x1C89040 Offset: 0x1C89141 VA: 0x1C89040
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<int, uint>>
	|
	|-RVA: 0x1C89150 Offset: 0x1C89251 VA: 0x1C89150
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<int, AIThink.EnchantThink.SurroundingInfo>>
	|
	|-RVA: 0x1C89260 Offset: 0x1C89361 VA: 0x1C89260
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Int32Enum, bool>>
	|
	|-RVA: 0x1C89370 Offset: 0x1C89471 VA: 0x1C89370
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Int32Enum, int>>
	|
	|-RVA: 0x1C89480 Offset: 0x1C89581 VA: 0x1C89480
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Int32Enum, Int32Enum>>
	|
	|-RVA: 0x1C89590 Offset: 0x1C89691 VA: 0x1C89590
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Int32Enum, object>>
	|
	|-RVA: 0x1C896A0 Offset: 0x1C897A1 VA: 0x1C896A0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<long, object>>
	|
	|-RVA: 0x1C897B0 Offset: 0x1C898B1 VA: 0x1C897B0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<MapPos, int>>
	|
	|-RVA: 0x1C898C0 Offset: 0x1C899C1 VA: 0x1C898C0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, AsyncOperationHandle<object>>>
	|
	|-RVA: 0x1C899D0 Offset: 0x1C89AD1 VA: 0x1C899D0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, AsyncOperationHandle>>
	|
	|-RVA: 0x1C89AE0 Offset: 0x1C89BE1 VA: 0x1C89AE0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, bool>>
	|
	|-RVA: 0x1C89BF0 Offset: 0x1C89CF1 VA: 0x1C89BF0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, byte>>
	|
	|-RVA: 0x1C89D00 Offset: 0x1C89E01 VA: 0x1C89D00
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, int>>
	|
	|-RVA: 0x1C89E10 Offset: 0x1C89F11 VA: 0x1C89E10
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, Int32Enum>>
	|
	|-RVA: 0x1C89F20 Offset: 0x1C8A021 VA: 0x1C89F20
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, IntPtr>>
	|
	|-RVA: 0x1C8A030 Offset: 0x1C8A131 VA: 0x1C8A030
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, object>>
	|
	|-RVA: 0x1C8A140 Offset: 0x1C8A241 VA: 0x1C8A140
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, Playable>>
	|
	|-RVA: 0x1C8A250 Offset: 0x1C8A351 VA: 0x1C8A250
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, ResourceLocator>>
	|
	|-RVA: 0x1C8A360 Offset: 0x1C8A461 VA: 0x1C8A360
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, float>>
	|
	|-RVA: 0x1C8A470 Offset: 0x1C8A571 VA: 0x1C8A470
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, ushort>>
	|
	|-RVA: 0x1C8A580 Offset: 0x1C8A681 VA: 0x1C8A580
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<object, GameVariable.Value>>
	|
	|-RVA: 0x1C8A690 Offset: 0x1C8A791 VA: 0x1C8A690
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<sbyte, DataStoreRatingInfo>>
	|
	|-RVA: 0x1C8A7A0 Offset: 0x1C8A8A1 VA: 0x1C8A7A0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<sbyte, object>>
	|
	|-RVA: 0x1C8A8B0 Offset: 0x1C8A9B1 VA: 0x1C8A8B0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<ushort, int>>
	|
	|-RVA: 0x1C8A9C0 Offset: 0x1C8AAC1 VA: 0x1C8A9C0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<uint, int>>
	|
	|-RVA: 0x1C8AAD0 Offset: 0x1C8ABD1 VA: 0x1C8AAD0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<uint, object>>
	|
	|-RVA: 0x1C8ABE0 Offset: 0x1C8ACE1 VA: 0x1C8ABE0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<ulong, Friend>>
	|
	|-RVA: 0x1C8ACF0 Offset: 0x1C8ADF1 VA: 0x1C8ACF0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<ulong, Int32Enum>>
	|
	|-RVA: 0x1C8AE00 Offset: 0x1C8AF01 VA: 0x1C8AE00
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<ulong, object>>
	|
	|-RVA: 0x1C8AF10 Offset: 0x1C8B011 VA: 0x1C8AF10
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<Vector3, int>>
	|
	|-RVA: 0x1C8B020 Offset: 0x1C8B121 VA: 0x1C8B020
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<XPathNodeRef, XPathNodeRef>>
	|
	|-RVA: 0x1C8B130 Offset: 0x1C8B231 VA: 0x1C8B130
	|-Array.InternalArray__IEnumerable_GetEnumerator<Dictionary.Entry<TerrainUtility.TerrainMap.TileCoord, object>>
	|
	|-RVA: 0x1C8B240 Offset: 0x1C8B341 VA: 0x1C8B240
	|-Array.InternalArray__IEnumerable_GetEnumerator<PriorityQueue.IndexedItem<object>>
	|
	|-RVA: 0x1C8B350 Offset: 0x1C8B451 VA: 0x1C8B350
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<ValueTuple<object, int>, object>>
	|
	|-RVA: 0x1C8B460 Offset: 0x1C8B561 VA: 0x1C8B460
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<byte, object>>
	|
	|-RVA: 0x1C8B570 Offset: 0x1C8B671 VA: 0x1C8B570
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<CancellationToken, object>>
	|
	|-RVA: 0x1C8B680 Offset: 0x1C8B781 VA: 0x1C8B680
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<char, object>>
	|
	|-RVA: 0x1C8B790 Offset: 0x1C8B891 VA: 0x1C8B790
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<DateTime, object>>
	|
	|-RVA: 0x1C8B8A0 Offset: 0x1C8B9A1 VA: 0x1C8B8A0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Guid, object>>
	|
	|-RVA: 0x1C8B9B0 Offset: 0x1C8BAB1 VA: 0x1C8B9B0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<int, bool>>
	|
	|-RVA: 0x1C8BAC0 Offset: 0x1C8BBC1 VA: 0x1C8BAC0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<int, byte>>
	|
	|-RVA: 0x1C8BBD0 Offset: 0x1C8BCD1 VA: 0x1C8BBD0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<int, char>>
	|
	|-RVA: 0x1C8BCE0 Offset: 0x1C8BDE1 VA: 0x1C8BCE0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<int, DiagnosticEvent>>
	|
	|-RVA: 0x1C8BDF0 Offset: 0x1C8BEF1 VA: 0x1C8BDF0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<int, int>>
	|
	|-RVA: 0x1C8BF00 Offset: 0x1C8C001 VA: 0x1C8BF00
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<int, Int32Enum>>
	|
	|-RVA: 0x1C8C010 Offset: 0x1C8C111 VA: 0x1C8C010
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<int, long>>
	|
	|-RVA: 0x1C8C120 Offset: 0x1C8C221 VA: 0x1C8C120
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<int, MapPos>>
	|
	|-RVA: 0x1C8C230 Offset: 0x1C8C331 VA: 0x1C8C230
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<int, object>>
	|
	|-RVA: 0x1C8C340 Offset: 0x1C8C441 VA: 0x1C8C340
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<int, uint>>
	|
	|-RVA: 0x1C8C450 Offset: 0x1C8C551 VA: 0x1C8C450
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<int, AIThink.EnchantThink.SurroundingInfo>>
	|
	|-RVA: 0x1C8C560 Offset: 0x1C8C661 VA: 0x1C8C560
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Int32Enum, bool>>
	|
	|-RVA: 0x1C8C670 Offset: 0x1C8C771 VA: 0x1C8C670
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Int32Enum, int>>
	|
	|-RVA: 0x1C8C780 Offset: 0x1C8C881 VA: 0x1C8C780
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Int32Enum, Int32Enum>>
	|
	|-RVA: 0x1C8C890 Offset: 0x1C8C991 VA: 0x1C8C890
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Int32Enum, object>>
	|
	|-RVA: 0x1C8C9A0 Offset: 0x1C8CAA1 VA: 0x1C8C9A0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<long, object>>
	|
	|-RVA: 0x1C8CAB0 Offset: 0x1C8CBB1 VA: 0x1C8CAB0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<MapPos, int>>
	|
	|-RVA: 0x1C8CBC0 Offset: 0x1C8CCC1 VA: 0x1C8CBC0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, AsyncOperationHandle<object>>>
	|
	|-RVA: 0x1C8CCD0 Offset: 0x1C8CDD1 VA: 0x1C8CCD0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, ValueTuple<int, DateTime, object>>>
	|
	|-RVA: 0x1C8CDE0 Offset: 0x1C8CEE1 VA: 0x1C8CDE0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, AsyncOperationHandle>>
	|
	|-RVA: 0x1C8CEF0 Offset: 0x1C8CFF1 VA: 0x1C8CEF0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, bool>>
	|
	|-RVA: 0x1C8D000 Offset: 0x1C8D101 VA: 0x1C8D000
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, byte>>
	|
	|-RVA: 0x1C8D110 Offset: 0x1C8D211 VA: 0x1C8D110
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, int>>
	|
	|-RVA: 0x1C8D220 Offset: 0x1C8D321 VA: 0x1C8D220
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, Int32Enum>>
	|
	|-RVA: 0x1C8D330 Offset: 0x1C8D431 VA: 0x1C8D330
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, IntPtr>>
	|
	|-RVA: 0x1C8D440 Offset: 0x1C8D541 VA: 0x1C8D440
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, object>>
	|
	|-RVA: 0x1C8D550 Offset: 0x1C8D651 VA: 0x1C8D550
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, Playable>>
	|
	|-RVA: 0x1C8D660 Offset: 0x1C8D761 VA: 0x1C8D660
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, ResourceLocator>>
	|
	|-RVA: 0x1C8D770 Offset: 0x1C8D871 VA: 0x1C8D770
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, float>>
	|
	|-RVA: 0x1C8D880 Offset: 0x1C8D981 VA: 0x1C8D880
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, ushort>>
	|
	|-RVA: 0x1C8D990 Offset: 0x1C8DA91 VA: 0x1C8D990
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<object, GameVariable.Value>>
	|
	|-RVA: 0x1C8DAA0 Offset: 0x1C8DBA1 VA: 0x1C8DAA0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<sbyte, DataStoreRatingInfo>>
	|
	|-RVA: 0x1C8DBB0 Offset: 0x1C8DCB1 VA: 0x1C8DBB0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<sbyte, object>>
	|
	|-RVA: 0x1C8DCC0 Offset: 0x1C8DDC1 VA: 0x1C8DCC0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<ushort, int>>
	|
	|-RVA: 0x1C8DDD0 Offset: 0x1C8DED1 VA: 0x1C8DDD0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<uint, int>>
	|
	|-RVA: 0x1C8DEE0 Offset: 0x1C8DFE1 VA: 0x1C8DEE0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<uint, object>>
	|
	|-RVA: 0x1C8DFF0 Offset: 0x1C8E0F1 VA: 0x1C8DFF0
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<ulong, Friend>>
	|
	|-RVA: 0x1C8E100 Offset: 0x1C8E201 VA: 0x1C8E100
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<ulong, Int32Enum>>
	|
	|-RVA: 0x1C8E210 Offset: 0x1C8E311 VA: 0x1C8E210
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<ulong, object>>
	|
	|-RVA: 0x1C8E320 Offset: 0x1C8E421 VA: 0x1C8E320
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<Vector3, int>>
	|
	|-RVA: 0x1C8E430 Offset: 0x1C8E531 VA: 0x1C8E430
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<XPathNodeRef, XPathNodeRef>>
	|
	|-RVA: 0x1C8E540 Offset: 0x1C8E641 VA: 0x1C8E540
	|-Array.InternalArray__IEnumerable_GetEnumerator<KeyValuePair<TerrainUtility.TerrainMap.TileCoord, object>>
	|
	|-RVA: 0x1C8E650 Offset: 0x1C8E751 VA: 0x1C8E650
	|-Array.InternalArray__IEnumerable_GetEnumerator<NativeArray<PreTile>>
	|
	|-RVA: 0x1C8E760 Offset: 0x1C8E861 VA: 0x1C8E760
	|-Array.InternalArray__IEnumerable_GetEnumerator<CommonBattleSequence.Reliance<object>>
	|
	|-RVA: 0x1C8E870 Offset: 0x1C8E971 VA: 0x1C8E870
	|-Array.InternalArray__IEnumerable_GetEnumerator<RenderGraphResourcePool.ResourceLogInfo<object>>
	|
	|-RVA: 0x1C8E980 Offset: 0x1C8EA81 VA: 0x1C8E980
	|-Array.InternalArray__IEnumerable_GetEnumerator<HashSet.Slot<ValueTuple<object, int>>>
	|
	|-RVA: 0x1C8EA90 Offset: 0x1C8EB91 VA: 0x1C8EA90
	|-Array.InternalArray__IEnumerable_GetEnumerator<HashSet.Slot<AsyncOperationHandle>>
	|
	|-RVA: 0x1C8EBA0 Offset: 0x1C8ECA1 VA: 0x1C8EBA0
	|-Array.InternalArray__IEnumerable_GetEnumerator<HashSet.Slot<int>>
	|
	|-RVA: 0x1C8ECB0 Offset: 0x1C8EDB1 VA: 0x1C8ECB0
	|-Array.InternalArray__IEnumerable_GetEnumerator<HashSet.Slot<Int32Enum>>
	|
	|-RVA: 0x1C8EDC0 Offset: 0x1C8EEC1 VA: 0x1C8EDC0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Set.Slot<Int32Enum>>
	|
	|-RVA: 0x1C8EED0 Offset: 0x1C8EFD1 VA: 0x1C8EED0
	|-Array.InternalArray__IEnumerable_GetEnumerator<HashSet.Slot<MapPos>>
	|
	|-RVA: 0x1C8EFE0 Offset: 0x1C8F0E1 VA: 0x1C8EFE0
	|-Array.InternalArray__IEnumerable_GetEnumerator<HashSet.Slot<object>>
	|
	|-RVA: 0x1C8F0F0 Offset: 0x1C8F1F1 VA: 0x1C8F0F0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Set.Slot<object>>
	|
	|-RVA: 0x1C8F200 Offset: 0x1C8F301 VA: 0x1C8F200
	|-Array.InternalArray__IEnumerable_GetEnumerator<HashSet.Slot<uint>>
	|
	|-RVA: 0x1C8F310 Offset: 0x1C8F411 VA: 0x1C8F310
	|-Array.InternalArray__IEnumerable_GetEnumerator<HashSet.Slot<ulong>>
	|
	|-RVA: 0x1C8F420 Offset: 0x1C8F521 VA: 0x1C8F420
	|-Array.InternalArray__IEnumerable_GetEnumerator<Set.Slot<Vector3>>
	|
	|-RVA: 0x1C8F530 Offset: 0x1C8F631 VA: 0x1C8F530
	|-Array.InternalArray__IEnumerable_GetEnumerator<TMP_TextProcessingStack<Color32>>
	|
	|-RVA: 0x1C8F640 Offset: 0x1C8F741 VA: 0x1C8F640
	|-Array.InternalArray__IEnumerable_GetEnumerator<TMP_TextProcessingStack<HighlightState>>
	|
	|-RVA: 0x1C8F750 Offset: 0x1C8F851 VA: 0x1C8F750
	|-Array.InternalArray__IEnumerable_GetEnumerator<TMP_TextProcessingStack<int>>
	|
	|-RVA: 0x1C8F860 Offset: 0x1C8F961 VA: 0x1C8F860
	|-Array.InternalArray__IEnumerable_GetEnumerator<TMP_TextProcessingStack<Int32Enum>>
	|
	|-RVA: 0x1C8F970 Offset: 0x1C8FA71 VA: 0x1C8F970
	|-Array.InternalArray__IEnumerable_GetEnumerator<TMP_TextProcessingStack<MaterialReference>>
	|
	|-RVA: 0x1C8FA80 Offset: 0x1C8FB81 VA: 0x1C8FA80
	|-Array.InternalArray__IEnumerable_GetEnumerator<TMP_TextProcessingStack<object>>
	|
	|-RVA: 0x1C8FB90 Offset: 0x1C8FC91 VA: 0x1C8FB90
	|-Array.InternalArray__IEnumerable_GetEnumerator<TMP_TextProcessingStack<float>>
	|
	|-RVA: 0x1C8FCA0 Offset: 0x1C8FDA1 VA: 0x1C8FCA0
	|-Array.InternalArray__IEnumerable_GetEnumerator<TMP_TextProcessingStack<WordWrapState>>
	|
	|-RVA: 0x1C8FDB0 Offset: 0x1C8FEB1 VA: 0x1C8FDB0
	|-Array.InternalArray__IEnumerable_GetEnumerator<TimeInterval<object>>
	|
	|-RVA: 0x1C8FEC0 Offset: 0x1C8FFC1 VA: 0x1C8FEC0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Timestamped<object>>
	|
	|-RVA: 0x1C8FFD0 Offset: 0x1C900D1 VA: 0x1C8FFD0
	|-Array.InternalArray__IEnumerable_GetEnumerator<UniTask<object>>
	|
	|-RVA: 0x1C900E0 Offset: 0x1C901E1 VA: 0x1C900E0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<ValueTuple<bool, object>>>
	|
	|-RVA: 0x1C901F0 Offset: 0x1C902F1 VA: 0x1C901F0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>
	|
	|-RVA: 0x1C90300 Offset: 0x1C90401 VA: 0x1C90300
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, UniTask<object>>>
	|
	|-RVA: 0x1C90410 Offset: 0x1C90511 VA: 0x1C90410
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>
	|
	|-RVA: 0x1C90520 Offset: 0x1C90621 VA: 0x1C90520
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>
	|
	|-RVA: 0x1C90630 Offset: 0x1C90731 VA: 0x1C90630
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>
	|
	|-RVA: 0x1C90740 Offset: 0x1C90841 VA: 0x1C90740
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>
	|
	|-RVA: 0x1C90850 Offset: 0x1C90951 VA: 0x1C90850
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>
	|
	|-RVA: 0x1C90960 Offset: 0x1C90A61 VA: 0x1C90960
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>
	|
	|-RVA: 0x1C90A70 Offset: 0x1C90B71 VA: 0x1C90A70
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>
	|
	|-RVA: 0x1C90B80 Offset: 0x1C90C81 VA: 0x1C90B80
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>
	|
	|-RVA: 0x1C90C90 Offset: 0x1C90D91 VA: 0x1C90C90
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>
	|
	|-RVA: 0x1C90DA0 Offset: 0x1C90EA1 VA: 0x1C90DA0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>
	|
	|-RVA: 0x1C90EB0 Offset: 0x1C90FB1 VA: 0x1C90EB0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>
	|
	|-RVA: 0x1C90FC0 Offset: 0x1C910C1 VA: 0x1C90FC0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x1C910D0 Offset: 0x1C911D1 VA: 0x1C910D0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>
	|
	|-RVA: 0x1C911E0 Offset: 0x1C912E1 VA: 0x1C911E0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>
	|
	|-RVA: 0x1C912F0 Offset: 0x1C913F1 VA: 0x1C912F0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>
	|
	|-RVA: 0x1C91400 Offset: 0x1C91501 VA: 0x1C91400
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>
	|
	|-RVA: 0x1C91510 Offset: 0x1C91611 VA: 0x1C91510
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>
	|
	|-RVA: 0x1C91620 Offset: 0x1C91721 VA: 0x1C91620
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>
	|
	|-RVA: 0x1C91730 Offset: 0x1C91831 VA: 0x1C91730
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>
	|
	|-RVA: 0x1C91840 Offset: 0x1C91941 VA: 0x1C91840
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>
	|
	|-RVA: 0x1C91950 Offset: 0x1C91A51 VA: 0x1C91950
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>
	|
	|-RVA: 0x1C91A60 Offset: 0x1C91B61 VA: 0x1C91A60
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>
	|
	|-RVA: 0x1C91B70 Offset: 0x1C91C71 VA: 0x1C91B70
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>
	|
	|-RVA: 0x1C91C80 Offset: 0x1C91D81 VA: 0x1C91C80
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>
	|
	|-RVA: 0x1C91D90 Offset: 0x1C91E91 VA: 0x1C91D90
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>
	|
	|-RVA: 0x1C91EA0 Offset: 0x1C91FA1 VA: 0x1C91EA0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>
	|
	|-RVA: 0x1C91FB0 Offset: 0x1C920B1 VA: 0x1C91FB0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>
	|
	|-RVA: 0x1C920C0 Offset: 0x1C921C1 VA: 0x1C920C0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>
	|
	|-RVA: 0x1C921D0 Offset: 0x1C922D1 VA: 0x1C921D0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>
	|
	|-RVA: 0x1C922E0 Offset: 0x1C923E1 VA: 0x1C922E0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>
	|
	|-RVA: 0x1C923F0 Offset: 0x1C924F1 VA: 0x1C923F0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>
	|
	|-RVA: 0x1C92500 Offset: 0x1C92601 VA: 0x1C92500
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>
	|
	|-RVA: 0x1C92610 Offset: 0x1C92711 VA: 0x1C92610
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>
	|
	|-RVA: 0x1C92720 Offset: 0x1C92821 VA: 0x1C92720
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>
	|
	|-RVA: 0x1C92830 Offset: 0x1C92931 VA: 0x1C92830
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>
	|
	|-RVA: 0x1C92940 Offset: 0x1C92A41 VA: 0x1C92940
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x1C92A50 Offset: 0x1C92B51 VA: 0x1C92A50
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>
	|
	|-RVA: 0x1C92B60 Offset: 0x1C92C61 VA: 0x1C92B60
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>
	|
	|-RVA: 0x1C92C70 Offset: 0x1C92D71 VA: 0x1C92C70
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>
	|
	|-RVA: 0x1C92D80 Offset: 0x1C92E81 VA: 0x1C92D80
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>
	|
	|-RVA: 0x1C92E90 Offset: 0x1C92F91 VA: 0x1C92E90
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>
	|
	|-RVA: 0x1C92FA0 Offset: 0x1C930A1 VA: 0x1C92FA0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>
	|
	|-RVA: 0x1C930B0 Offset: 0x1C931B1 VA: 0x1C930B0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>
	|
	|-RVA: 0x1C931C0 Offset: 0x1C932C1 VA: 0x1C931C0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>
	|
	|-RVA: 0x1C932D0 Offset: 0x1C933D1 VA: 0x1C932D0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>
	|
	|-RVA: 0x1C933E0 Offset: 0x1C934E1 VA: 0x1C933E0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>
	|
	|-RVA: 0x1C934F0 Offset: 0x1C935F1 VA: 0x1C934F0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x1C93600 Offset: 0x1C93701 VA: 0x1C93600
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>
	|
	|-RVA: 0x1C93710 Offset: 0x1C93811 VA: 0x1C93710
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x1C93820 Offset: 0x1C93921 VA: 0x1C93820
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>
	|
	|-RVA: 0x1C93930 Offset: 0x1C93A31 VA: 0x1C93930
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x1C93A40 Offset: 0x1C93B41 VA: 0x1C93A40
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>
	|
	|-RVA: 0x1C93B50 Offset: 0x1C93C51 VA: 0x1C93B50
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x1C93C60 Offset: 0x1C93D61 VA: 0x1C93C60
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>
	|
	|-RVA: 0x1C93D70 Offset: 0x1C93E71 VA: 0x1C93D70
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x1C93E80 Offset: 0x1C93F81 VA: 0x1C93E80
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>
	|
	|-RVA: 0x1C93F90 Offset: 0x1C94091 VA: 0x1C93F90
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>
	|
	|-RVA: 0x1C940A0 Offset: 0x1C941A1 VA: 0x1C940A0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>
	|
	|-RVA: 0x1C941B0 Offset: 0x1C942B1 VA: 0x1C941B0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>
	|
	|-RVA: 0x1C942C0 Offset: 0x1C943C1 VA: 0x1C942C0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>
	|
	|-RVA: 0x1C943D0 Offset: 0x1C944D1 VA: 0x1C943D0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>
	|
	|-RVA: 0x1C944E0 Offset: 0x1C945E1 VA: 0x1C944E0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>
	|
	|-RVA: 0x1C945F0 Offset: 0x1C946F1 VA: 0x1C945F0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>
	|
	|-RVA: 0x1C94700 Offset: 0x1C94801 VA: 0x1C94700
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>
	|
	|-RVA: 0x1C94810 Offset: 0x1C94911 VA: 0x1C94810
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x1C94920 Offset: 0x1C94A21 VA: 0x1C94920
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>
	|
	|-RVA: 0x1C94A30 Offset: 0x1C94B31 VA: 0x1C94A30
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>
	|
	|-RVA: 0x1C94B40 Offset: 0x1C94C41 VA: 0x1C94B40
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>
	|
	|-RVA: 0x1C94C50 Offset: 0x1C94D51 VA: 0x1C94C50
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>
	|
	|-RVA: 0x1C94D60 Offset: 0x1C94E61 VA: 0x1C94D60
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>
	|
	|-RVA: 0x1C94E70 Offset: 0x1C94F71 VA: 0x1C94E70
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>
	|
	|-RVA: 0x1C94F80 Offset: 0x1C95081 VA: 0x1C94F80
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>
	|
	|-RVA: 0x1C95090 Offset: 0x1C95191 VA: 0x1C95090
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>
	|
	|-RVA: 0x1C951A0 Offset: 0x1C952A1 VA: 0x1C951A0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>
	|
	|-RVA: 0x1C952B0 Offset: 0x1C953B1 VA: 0x1C952B0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>
	|
	|-RVA: 0x1C953C0 Offset: 0x1C954C1 VA: 0x1C953C0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x1C954D0 Offset: 0x1C955D1 VA: 0x1C954D0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>
	|
	|-RVA: 0x1C955E0 Offset: 0x1C956E1 VA: 0x1C955E0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x1C956F0 Offset: 0x1C957F1 VA: 0x1C956F0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>
	|
	|-RVA: 0x1C95800 Offset: 0x1C95901 VA: 0x1C95800
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x1C95910 Offset: 0x1C95A11 VA: 0x1C95910
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>
	|
	|-RVA: 0x1C95A20 Offset: 0x1C95B21 VA: 0x1C95A20
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x1C95B30 Offset: 0x1C95C31 VA: 0x1C95B30
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>
	|
	|-RVA: 0x1C95C40 Offset: 0x1C95D41 VA: 0x1C95C40
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x1C95D50 Offset: 0x1C95E51 VA: 0x1C95D50
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>
	|
	|-RVA: 0x1C95E60 Offset: 0x1C95F61 VA: 0x1C95E60
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x1C95F70 Offset: 0x1C96071 VA: 0x1C95F70
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x1C96080 Offset: 0x1C96181 VA: 0x1C96080
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>
	|
	|-RVA: 0x1C96190 Offset: 0x1C96291 VA: 0x1C96190
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, bool>>>
	|
	|-RVA: 0x1C962A0 Offset: 0x1C963A1 VA: 0x1C962A0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, Bounds>>>
	|
	|-RVA: 0x1C963B0 Offset: 0x1C964B1 VA: 0x1C963B0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, byte>>>
	|
	|-RVA: 0x1C964C0 Offset: 0x1C965C1 VA: 0x1C964C0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, Color>>>
	|
	|-RVA: 0x1C965D0 Offset: 0x1C966D1 VA: 0x1C965D0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, double>>>
	|
	|-RVA: 0x1C966E0 Offset: 0x1C967E1 VA: 0x1C966E0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, int>>>
	|
	|-RVA: 0x1C967F0 Offset: 0x1C968F1 VA: 0x1C967F0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, long>>>
	|
	|-RVA: 0x1C96900 Offset: 0x1C96A01 VA: 0x1C96900
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, object>>>
	|
	|-RVA: 0x1C96A10 Offset: 0x1C96B11 VA: 0x1C96A10
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, Quaternion>>>
	|
	|-RVA: 0x1C96B20 Offset: 0x1C96C21 VA: 0x1C96B20
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, Rect>>>
	|
	|-RVA: 0x1C96C30 Offset: 0x1C96D31 VA: 0x1C96C30
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, float>>>
	|
	|-RVA: 0x1C96D40 Offset: 0x1C96E41 VA: 0x1C96D40
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, UniTask>>>
	|
	|-RVA: 0x1C96E50 Offset: 0x1C96F51 VA: 0x1C96E50
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, Unit>>>
	|
	|-RVA: 0x1C96F60 Offset: 0x1C97061 VA: 0x1C96F60
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, Vector2>>>
	|
	|-RVA: 0x1C97070 Offset: 0x1C97171 VA: 0x1C97070
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, Vector3>>>
	|
	|-RVA: 0x1C97180 Offset: 0x1C97281 VA: 0x1C97180
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<bool, Vector4>>>
	|
	|-RVA: 0x1C97290 Offset: 0x1C97391 VA: 0x1C97290
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<int, object>>>
	|
	|-RVA: 0x1C973A0 Offset: 0x1C974A1 VA: 0x1C973A0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<object, object>>>
	|
	|-RVA: 0x1C974B0 Offset: 0x1C975B1 VA: 0x1C974B0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x1C975C0 Offset: 0x1C976C1 VA: 0x1C975C0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<object, object, object>>>
	|
	|-RVA: 0x1C976D0 Offset: 0x1C977D1 VA: 0x1C976D0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x1C977E0 Offset: 0x1C978E1 VA: 0x1C977E0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<object, object, object, object>>>
	|
	|-RVA: 0x1C978F0 Offset: 0x1C979F1 VA: 0x1C978F0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x1C97A00 Offset: 0x1C97B01 VA: 0x1C97A00
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>
	|
	|-RVA: 0x1C97B10 Offset: 0x1C97C11 VA: 0x1C97B10
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x1C97C20 Offset: 0x1C97D21 VA: 0x1C97C20
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>
	|
	|-RVA: 0x1C97D30 Offset: 0x1C97E31 VA: 0x1C97D30
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x1C97E40 Offset: 0x1C97F41 VA: 0x1C97E40
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>
	|
	|-RVA: 0x1C97F50 Offset: 0x1C98051 VA: 0x1C97F50
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x1C98060 Offset: 0x1C98161 VA: 0x1C98060
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x1C98170 Offset: 0x1C98271 VA: 0x1C98170
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, AsyncUnit>>
	|
	|-RVA: 0x1C98280 Offset: 0x1C98381 VA: 0x1C98280
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, bool>>
	|
	|-RVA: 0x1C98390 Offset: 0x1C98491 VA: 0x1C98390
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, Bounds>>
	|
	|-RVA: 0x1C984A0 Offset: 0x1C985A1 VA: 0x1C984A0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, byte>>
	|
	|-RVA: 0x1C985B0 Offset: 0x1C986B1 VA: 0x1C985B0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, Color>>
	|
	|-RVA: 0x1C986C0 Offset: 0x1C987C1 VA: 0x1C986C0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, double>>
	|
	|-RVA: 0x1C987D0 Offset: 0x1C988D1 VA: 0x1C987D0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, int>>
	|
	|-RVA: 0x1C988E0 Offset: 0x1C989E1 VA: 0x1C988E0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, long>>
	|
	|-RVA: 0x1C989F0 Offset: 0x1C98AF1 VA: 0x1C989F0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, object>>
	|
	|-RVA: 0x1C98B00 Offset: 0x1C98C01 VA: 0x1C98B00
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, Quaternion>>
	|
	|-RVA: 0x1C98C10 Offset: 0x1C98D11 VA: 0x1C98C10
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, Rect>>
	|
	|-RVA: 0x1C98D20 Offset: 0x1C98E21 VA: 0x1C98D20
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, float>>
	|
	|-RVA: 0x1C98E30 Offset: 0x1C98F31 VA: 0x1C98E30
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, UniTask>>
	|
	|-RVA: 0x1C98F40 Offset: 0x1C99041 VA: 0x1C98F40
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, Unit>>
	|
	|-RVA: 0x1C99050 Offset: 0x1C99151 VA: 0x1C99050
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, Vector2>>
	|
	|-RVA: 0x1C99160 Offset: 0x1C99261 VA: 0x1C99160
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, Vector3>>
	|
	|-RVA: 0x1C99270 Offset: 0x1C99371 VA: 0x1C99270
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<bool, Vector4>>
	|
	|-RVA: 0x1C99380 Offset: 0x1C99481 VA: 0x1C99380
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<int, bool>>
	|
	|-RVA: 0x1C99490 Offset: 0x1C99591 VA: 0x1C99490
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<int, Bounds>>
	|
	|-RVA: 0x1C995A0 Offset: 0x1C996A1 VA: 0x1C995A0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<int, byte>>
	|
	|-RVA: 0x1C996B0 Offset: 0x1C997B1 VA: 0x1C996B0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<int, Color>>
	|
	|-RVA: 0x1C997C0 Offset: 0x1C998C1 VA: 0x1C997C0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<int, double>>
	|
	|-RVA: 0x1C998D0 Offset: 0x1C999D1 VA: 0x1C998D0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<int, int>>
	|
	|-RVA: 0x1C999E0 Offset: 0x1C99AE1 VA: 0x1C999E0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<int, long>>
	|
	|-RVA: 0x1C99AF0 Offset: 0x1C99BF1 VA: 0x1C99AF0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<int, object>>
	|
	|-RVA: 0x1C99C00 Offset: 0x1C99D01 VA: 0x1C99C00
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<int, Quaternion>>
	|
	|-RVA: 0x1C99D10 Offset: 0x1C99E11 VA: 0x1C99D10
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<int, Rect>>
	|
	|-RVA: 0x1C99E20 Offset: 0x1C99F21 VA: 0x1C99E20
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<int, float>>
	|
	|-RVA: 0x1C99F30 Offset: 0x1C9A031 VA: 0x1C99F30
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<int, Unit>>
	|
	|-RVA: 0x1C9A040 Offset: 0x1C9A141 VA: 0x1C9A040
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<int, Vector2>>
	|
	|-RVA: 0x1C9A150 Offset: 0x1C9A251 VA: 0x1C9A150
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<int, Vector3>>
	|
	|-RVA: 0x1C9A260 Offset: 0x1C9A361 VA: 0x1C9A260
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<int, Vector4>>
	|
	|-RVA: 0x1C9A370 Offset: 0x1C9A471 VA: 0x1C9A370
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<Int32Enum, int>>
	|
	|-RVA: 0x1C9A480 Offset: 0x1C9A581 VA: 0x1C9A480
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<object, ValueTuple<object, int>>>
	|
	|-RVA: 0x1C9A590 Offset: 0x1C9A691 VA: 0x1C9A590
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<object, int>>
	|
	|-RVA: 0x1C9A6A0 Offset: 0x1C9A7A1 VA: 0x1C9A6A0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<object, object>>
	|
	|-RVA: 0x1C9A7B0 Offset: 0x1C9A8B1 VA: 0x1C9A7B0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<object, float>>
	|
	|-RVA: 0x1C9A8C0 Offset: 0x1C9A9C1 VA: 0x1C9A8C0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<Vector3, float>>
	|
	|-RVA: 0x1C9A9D0 Offset: 0x1C9AAD1 VA: 0x1C9A9D0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>
	|
	|-RVA: 0x1C9AAE0 Offset: 0x1C9ABE1 VA: 0x1C9AAE0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<object, Int32Enum, int>>
	|
	|-RVA: 0x1C9ABF0 Offset: 0x1C9ACF1 VA: 0x1C9ABF0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<object, object, object>>
	|
	|-RVA: 0x1C9AD00 Offset: 0x1C9AE01 VA: 0x1C9AD00
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>
	|
	|-RVA: 0x1C9AE10 Offset: 0x1C9AF11 VA: 0x1C9AE10
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<object, int, int, int>>
	|
	|-RVA: 0x1C9AF20 Offset: 0x1C9B021 VA: 0x1C9AF20
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<object, object, object, object>>
	|
	|-RVA: 0x1C9B030 Offset: 0x1C9B131 VA: 0x1C9B030
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>
	|
	|-RVA: 0x1C9B140 Offset: 0x1C9B241 VA: 0x1C9B140
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<object, object, object, object, object>>
	|
	|-RVA: 0x1C9B250 Offset: 0x1C9B351 VA: 0x1C9B250
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>
	|
	|-RVA: 0x1C9B360 Offset: 0x1C9B461 VA: 0x1C9B360
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<object, object, object, object, object, object>>
	|
	|-RVA: 0x1C9B470 Offset: 0x1C9B571 VA: 0x1C9B470
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>
	|
	|-RVA: 0x1C9B580 Offset: 0x1C9B681 VA: 0x1C9B580
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<object, object, object, object, object, object, object>>
	|
	|-RVA: 0x1C9B690 Offset: 0x1C9B791 VA: 0x1C9B690
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>
	|
	|-RVA: 0x1C9B7A0 Offset: 0x1C9B8A1 VA: 0x1C9B7A0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x1C9B8B0 Offset: 0x1C9B9B1 VA: 0x1C9B8B0
	|-Array.InternalArray__IEnumerable_GetEnumerator<AnimatorClipInfo>
	|
	|-RVA: 0x1C9B9C0 Offset: 0x1C9BAC1 VA: 0x1C9B9C0
	|-Array.InternalArray__IEnumerable_GetEnumerator<AsyncOperationHandle>
	|
	|-RVA: 0x1C9BAD0 Offset: 0x1C9BBD1 VA: 0x1C9BAD0
	|-Array.InternalArray__IEnumerable_GetEnumerator<AsyncUnit>
	|
	|-RVA: 0x1C9BBE0 Offset: 0x1C9BCE1 VA: 0x1C9BBE0
	|-Array.InternalArray__IEnumerable_GetEnumerator<BatchVisibility>
	|
	|-RVA: 0x1C9BCF0 Offset: 0x1C9BDF1 VA: 0x1C9BCF0
	|-Array.InternalArray__IEnumerable_GetEnumerator<BoneWeight>
	|
	|-RVA: 0x1C9BE00 Offset: 0x1C9BF01 VA: 0x1C9BE00
	|-Array.InternalArray__IEnumerable_GetEnumerator<BoneWeight1>
	|
	|-RVA: 0x1C9BF10 Offset: 0x1C9C011 VA: 0x1C9BF10
	|-Array.InternalArray__IEnumerable_GetEnumerator<bool>
	|
	|-RVA: 0x1C9C020 Offset: 0x1C9C121 VA: 0x1C9C020
	|-Array.InternalArray__IEnumerable_GetEnumerator<Bounds>
	|
	|-RVA: 0x1C9C130 Offset: 0x1C9C231 VA: 0x1C9C130
	|-Array.InternalArray__IEnumerable_GetEnumerator<byte>
	|
	|-RVA: 0x1C9C240 Offset: 0x1C9C341 VA: 0x1C9C240
	|-Array.InternalArray__IEnumerable_GetEnumerator<ByteEnum>
	|
	|-RVA: 0x1C9C350 Offset: 0x1C9C451 VA: 0x1C9C350
	|-Array.InternalArray__IEnumerable_GetEnumerator<CameraInfo>
	|
	|-RVA: 0x1C9C460 Offset: 0x1C9C561 VA: 0x1C9C460
	|-Array.InternalArray__IEnumerable_GetEnumerator<CancellationToken>
	|
	|-RVA: 0x1C9C570 Offset: 0x1C9C671 VA: 0x1C9C570
	|-Array.InternalArray__IEnumerable_GetEnumerator<CancellationTokenRegistration>
	|
	|-RVA: 0x1C9C680 Offset: 0x1C9C781 VA: 0x1C9C680
	|-Array.InternalArray__IEnumerable_GetEnumerator<char>
	|
	|-RVA: 0x1C9C790 Offset: 0x1C9C891 VA: 0x1C9C790
	|-Array.InternalArray__IEnumerable_GetEnumerator<ClusteringData>
	|
	|-RVA: 0x1C9C8A0 Offset: 0x1C9C9A1 VA: 0x1C9C8A0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ClusteringProcessorState>
	|
	|-RVA: 0x1C9C9B0 Offset: 0x1C9CAB1 VA: 0x1C9C9B0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Color>
	|
	|-RVA: 0x1C9CAC0 Offset: 0x1C9CBC1 VA: 0x1C9CAC0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Color32>
	|
	|-RVA: 0x1C9CBD0 Offset: 0x1C9CCD1 VA: 0x1C9CBD0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Color4u8>
	|
	|-RVA: 0x1C9CCE0 Offset: 0x1C9CDE1 VA: 0x1C9CCE0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ColorBlock>
	|
	|-RVA: 0x1C9CDF0 Offset: 0x1C9CEF1 VA: 0x1C9CDF0
	|-Array.InternalArray__IEnumerable_GetEnumerator<CombineInstance>
	|
	|-RVA: 0x1C9CF00 Offset: 0x1C9D001 VA: 0x1C9CF00
	|-Array.InternalArray__IEnumerable_GetEnumerator<ConstraintSource>
	|
	|-RVA: 0x1C9D010 Offset: 0x1C9D111 VA: 0x1C9D010
	|-Array.InternalArray__IEnumerable_GetEnumerator<ContactPoint>
	|
	|-RVA: 0x1C9D120 Offset: 0x1C9D221 VA: 0x1C9D120
	|-Array.InternalArray__IEnumerable_GetEnumerator<ContactPoint2D>
	|
	|-RVA: 0x1C9D230 Offset: 0x1C9D331 VA: 0x1C9D230
	|-Array.InternalArray__IEnumerable_GetEnumerator<ContourVertex>
	|
	|-RVA: 0x1C9D340 Offset: 0x1C9D441 VA: 0x1C9D340
	|-Array.InternalArray__IEnumerable_GetEnumerator<CustomAttributeNamedArgument>
	|
	|-RVA: 0x1C9D450 Offset: 0x1C9D551 VA: 0x1C9D450
	|-Array.InternalArray__IEnumerable_GetEnumerator<CustomAttributeTypedArgument>
	|
	|-RVA: 0x1C9D560 Offset: 0x1C9D661 VA: 0x1C9D560
	|-Array.InternalArray__IEnumerable_GetEnumerator<DataStoreRatingInfo>
	|
	|-RVA: 0x1C9D670 Offset: 0x1C9D771 VA: 0x1C9D670
	|-Array.InternalArray__IEnumerable_GetEnumerator<DataStoreResult>
	|
	|-RVA: 0x1C9D780 Offset: 0x1C9D881 VA: 0x1C9D780
	|-Array.InternalArray__IEnumerable_GetEnumerator<DateTime>
	|
	|-RVA: 0x1C9D890 Offset: 0x1C9D991 VA: 0x1C9D890
	|-Array.InternalArray__IEnumerable_GetEnumerator<DateTimeOffset>
	|
	|-RVA: 0x1C9D9A0 Offset: 0x1C9DAA1 VA: 0x1C9D9A0
	|-Array.InternalArray__IEnumerable_GetEnumerator<DebugPadState>
	|
	|-RVA: 0x1C9DAB0 Offset: 0x1C9DBB1 VA: 0x1C9DAB0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Decimal>
	|
	|-RVA: 0x1C9DBC0 Offset: 0x1C9DCC1 VA: 0x1C9DBC0
	|-Array.InternalArray__IEnumerable_GetEnumerator<DeferredTiler>
	|
	|-RVA: 0x1C9DCD0 Offset: 0x1C9DDD1 VA: 0x1C9DCD0
	|-Array.InternalArray__IEnumerable_GetEnumerator<DeviceHandle>
	|
	|-RVA: 0x1C9DDE0 Offset: 0x1C9DEE1 VA: 0x1C9DDE0
	|-Array.InternalArray__IEnumerable_GetEnumerator<DiagnosticEvent>
	|
	|-RVA: 0x1C9DEF0 Offset: 0x1C9DFF1 VA: 0x1C9DEF0
	|-Array.InternalArray__IEnumerable_GetEnumerator<DictionaryEntry>
	|
	|-RVA: 0x1C9E000 Offset: 0x1C9E101 VA: 0x1C9E000
	|-Array.InternalArray__IEnumerable_GetEnumerator<DictionaryInfo>
	|
	|-RVA: 0x1C9E110 Offset: 0x1C9E211 VA: 0x1C9E110
	|-Array.InternalArray__IEnumerable_GetEnumerator<DirectoryEntry>
	|
	|-RVA: 0x1C9E220 Offset: 0x1C9E321 VA: 0x1C9E220
	|-Array.InternalArray__IEnumerable_GetEnumerator<double>
	|
	|-RVA: 0x1C9E330 Offset: 0x1C9E431 VA: 0x1C9E330
	|-Array.InternalArray__IEnumerable_GetEnumerator<Ephemeron>
	|
	|-RVA: 0x1C9E440 Offset: 0x1C9E541 VA: 0x1C9E440
	|-Array.InternalArray__IEnumerable_GetEnumerator<FXZ>
	|
	|-RVA: 0x1C9E550 Offset: 0x1C9E651 VA: 0x1C9E550
	|-Array.InternalArray__IEnumerable_GetEnumerator<Finger>
	|
	|-RVA: 0x1C9E660 Offset: 0x1C9E761 VA: 0x1C9E660
	|-Array.InternalArray__IEnumerable_GetEnumerator<Float2>
	|
	|-RVA: 0x1C9E770 Offset: 0x1C9E871 VA: 0x1C9E770
	|-Array.InternalArray__IEnumerable_GetEnumerator<Friend>
	|
	|-RVA: 0x1E1CDC0 Offset: 0x1E1CEC1 VA: 0x1E1CDC0
	|-Array.InternalArray__IEnumerable_GetEnumerator<GCHandle>
	|
	|-RVA: 0x1E1CED0 Offset: 0x1E1CFD1 VA: 0x1E1CED0
	|-Array.InternalArray__IEnumerable_GetEnumerator<GesturePoint>
	|
	|-RVA: 0x1E1CFE0 Offset: 0x1E1D0E1 VA: 0x1E1CFE0
	|-Array.InternalArray__IEnumerable_GetEnumerator<GestureState>
	|
	|-RVA: 0x1E1D0F0 Offset: 0x1E1D1F1 VA: 0x1E1D0F0
	|-Array.InternalArray__IEnumerable_GetEnumerator<GlyphMarshallingStruct>
	|
	|-RVA: 0x1E1D200 Offset: 0x1E1D301 VA: 0x1E1D200
	|-Array.InternalArray__IEnumerable_GetEnumerator<GlyphPairAdjustmentRecord>
	|
	|-RVA: 0x1E1D310 Offset: 0x1E1D411 VA: 0x1E1D310
	|-Array.InternalArray__IEnumerable_GetEnumerator<GlyphRect>
	|
	|-RVA: 0x1E1D420 Offset: 0x1E1D521 VA: 0x1E1D420
	|-Array.InternalArray__IEnumerable_GetEnumerator<Guid>
	|
	|-RVA: 0x1E1D530 Offset: 0x1E1D631 VA: 0x1E1D530
	|-Array.InternalArray__IEnumerable_GetEnumerator<Hand>
	|
	|-RVA: 0x1E1D640 Offset: 0x1E1D741 VA: 0x1E1D640
	|-Array.InternalArray__IEnumerable_GetEnumerator<HandAnalysisImageState>
	|
	|-RVA: 0x1E1D750 Offset: 0x1E1D851 VA: 0x1E1D750
	|-Array.InternalArray__IEnumerable_GetEnumerator<HandAnalysisSilhouetteState>
	|
	|-RVA: 0x1E1D860 Offset: 0x1E1D961 VA: 0x1E1D860
	|-Array.InternalArray__IEnumerable_GetEnumerator<HeaderVariantInfo>
	|
	|-RVA: 0x1E1D970 Offset: 0x1E1DA71 VA: 0x1E1D970
	|-Array.InternalArray__IEnumerable_GetEnumerator<HighlightState>
	|
	|-RVA: 0x1E1DA80 Offset: 0x1E1DB81 VA: 0x1E1DA80
	|-Array.InternalArray__IEnumerable_GetEnumerator<HumanBone>
	|
	|-RVA: 0x1E1DB90 Offset: 0x1E1DC91 VA: 0x1E1DB90
	|-Array.InternalArray__IEnumerable_GetEnumerator<short>
	|
	|-RVA: 0x1E1DCA0 Offset: 0x1E1DDA1 VA: 0x1E1DCA0
	|-Array.InternalArray__IEnumerable_GetEnumerator<int>
	|
	|-RVA: 0x1E1DDB0 Offset: 0x1E1DEB1 VA: 0x1E1DDB0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Int32Enum>
	|
	|-RVA: 0x1E1DEC0 Offset: 0x1E1DFC1 VA: 0x1E1DEC0
	|-Array.InternalArray__IEnumerable_GetEnumerator<long>
	|
	|-RVA: 0x1E1DFD0 Offset: 0x1E1E0D1 VA: 0x1E1DFD0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Int64Enum>
	|
	|-RVA: 0x1E1E0E0 Offset: 0x1E1E1E1 VA: 0x1E1E0E0
	|-Array.InternalArray__IEnumerable_GetEnumerator<IntPtr>
	|
	|-RVA: 0x1E1E1F0 Offset: 0x1E1E2F1 VA: 0x1E1E1F0
	|-Array.InternalArray__IEnumerable_GetEnumerator<InternalCodePageDataItem>
	|
	|-RVA: 0x1E1E300 Offset: 0x1E1E401 VA: 0x1E1E300
	|-Array.InternalArray__IEnumerable_GetEnumerator<InternalEncodingDataItem>
	|
	|-RVA: 0x1E1E410 Offset: 0x1E1E511 VA: 0x1E1E410
	|-Array.InternalArray__IEnumerable_GetEnumerator<InterpretedFrameInfo>
	|
	|-RVA: 0x1E1E520 Offset: 0x1E1E621 VA: 0x1E1E520
	|-Array.InternalArray__IEnumerable_GetEnumerator<IntervalTreeNode>
	|
	|-RVA: 0x1E1E630 Offset: 0x1E1E731 VA: 0x1E1E630
	|-Array.InternalArray__IEnumerable_GetEnumerator<JobHandle>
	|
	|-RVA: 0x1E1E740 Offset: 0x1E1E841 VA: 0x1E1E740
	|-Array.InternalArray__IEnumerable_GetEnumerator<Keyframe>
	|
	|-RVA: 0x1E1E850 Offset: 0x1E1E951 VA: 0x1E1E850
	|-Array.InternalArray__IEnumerable_GetEnumerator<LOD>
	|
	|-RVA: 0x1E1E960 Offset: 0x1E1EA61 VA: 0x1E1E960
	|-Array.InternalArray__IEnumerable_GetEnumerator<LayerMask>
	|
	|-RVA: 0x1E1EA70 Offset: 0x1E1EB71 VA: 0x1E1EA70
	|-Array.InternalArray__IEnumerable_GetEnumerator<LengthLimitProperties>
	|
	|-RVA: 0x1E1EB80 Offset: 0x1E1EC81 VA: 0x1E1EB80
	|-Array.InternalArray__IEnumerable_GetEnumerator<Light2DBlendStyle>
	|
	|-RVA: 0x1E1EC90 Offset: 0x1E1ED91 VA: 0x1E1EC90
	|-Array.InternalArray__IEnumerable_GetEnumerator<LightDataGI>
	|
	|-RVA: 0x1E1EDA0 Offset: 0x1E1EEA1 VA: 0x1E1EDA0
	|-Array.InternalArray__IEnumerable_GetEnumerator<LocalDefinition>
	|
	|-RVA: 0x1E1EEB0 Offset: 0x1E1EFB1 VA: 0x1E1EEB0
	|-Array.InternalArray__IEnumerable_GetEnumerator<MapPos>
	|
	|-RVA: 0x1E1EFC0 Offset: 0x1E1F0C1 VA: 0x1E1EFC0
	|-Array.InternalArray__IEnumerable_GetEnumerator<MapRange>
	|
	|-RVA: 0x1E1F0D0 Offset: 0x1E1F1D1 VA: 0x1E1F0D0
	|-Array.InternalArray__IEnumerable_GetEnumerator<MaterialReference>
	|
	|-RVA: 0x1E1F1E0 Offset: 0x1E1F2E1 VA: 0x1E1F1E0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Matrix4x4>
	|
	|-RVA: 0x1E1F2F0 Offset: 0x1E1F3F1 VA: 0x1E1F2F0
	|-Array.InternalArray__IEnumerable_GetEnumerator<MomentProcessorState>
	|
	|-RVA: 0x1E1F400 Offset: 0x1E1F501 VA: 0x1E1F400
	|-Array.InternalArray__IEnumerable_GetEnumerator<MomentStatistic>
	|
	|-RVA: 0x1E1F510 Offset: 0x1E1F611 VA: 0x1E1F510
	|-Array.InternalArray__IEnumerable_GetEnumerator<Navigation>
	|
	|-RVA: 0x1E1F620 Offset: 0x1E1F721 VA: 0x1E1F620
	|-Array.InternalArray__IEnumerable_GetEnumerator<NetworkServiceAccountId>
	|
	|-RVA: 0x1E1F730 Offset: 0x1E1F831 VA: 0x1E1F730
	|-Array.InternalArray__IEnumerable_GetEnumerator<NpadFullKeyState>
	|
	|-RVA: 0x1E1F840 Offset: 0x1E1F941 VA: 0x1E1F840
	|-Array.InternalArray__IEnumerable_GetEnumerator<NpadHandheldState>
	|
	|-RVA: 0x1E1F950 Offset: 0x1E1FA51 VA: 0x1E1F950
	|-Array.InternalArray__IEnumerable_GetEnumerator<NpadJoyDualState>
	|
	|-RVA: 0x1E1FA60 Offset: 0x1E1FB61 VA: 0x1E1FA60
	|-Array.InternalArray__IEnumerable_GetEnumerator<NpadJoyLeftState>
	|
	|-RVA: 0x1E1FB70 Offset: 0x1E1FC71 VA: 0x1E1FB70
	|-Array.InternalArray__IEnumerable_GetEnumerator<NpadJoyRightState>
	|
	|-RVA: 0x1E1FC80 Offset: 0x1E1FD81 VA: 0x1E1FC80
	|-Array.InternalArray__IEnumerable_GetEnumerator<NpadStateArrayItem>
	|
	|-RVA: 0x1E1FD90 Offset: 0x1E1FE91 VA: 0x1E1FD90
	|-Array.InternalArray__IEnumerable_GetEnumerator<NsUid>
	|
	|-RVA: 0x1E1FEA0 Offset: 0x1E1FFA1 VA: 0x1E1FEA0
	|-Array.InternalArray__IEnumerable_GetEnumerator<object>
	|
	|-RVA: 0x1E1FFB0 Offset: 0x1E200B1 VA: 0x1E1FFB0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ObjectInitializationData>
	|
	|-RVA: 0x1E200C0 Offset: 0x1E201C1 VA: 0x1E200C0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ParameterModifier>
	|
	|-RVA: 0x1E201D0 Offset: 0x1E202D1 VA: 0x1E201D0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Plane>
	|
	|-RVA: 0x1E202E0 Offset: 0x1E203E1 VA: 0x1E202E0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Playable>
	|
	|-RVA: 0x1E203F0 Offset: 0x1E204F1 VA: 0x1E203F0
	|-Array.InternalArray__IEnumerable_GetEnumerator<PlayableBinding>
	|
	|-RVA: 0x1E20500 Offset: 0x1E20601 VA: 0x1E20500
	|-Array.InternalArray__IEnumerable_GetEnumerator<PlayerLoopSystem>
	|
	|-RVA: 0x1E20610 Offset: 0x1E20711 VA: 0x1E20610
	|-Array.InternalArray__IEnumerable_GetEnumerator<PlayerLoopSystemInternal>
	|
	|-RVA: 0x1E20720 Offset: 0x1E20821 VA: 0x1E20720
	|-Array.InternalArray__IEnumerable_GetEnumerator<PreTile>
	|
	|-RVA: 0x1E20830 Offset: 0x1E20931 VA: 0x1E20830
	|-Array.InternalArray__IEnumerable_GetEnumerator<Profile>
	|
	|-RVA: 0x1E20940 Offset: 0x1E20A41 VA: 0x1E20940
	|-Array.InternalArray__IEnumerable_GetEnumerator<Protrusion>
	|
	|-RVA: 0x1E20A50 Offset: 0x1E20B51 VA: 0x1E20A50
	|-Array.InternalArray__IEnumerable_GetEnumerator<Quaternion>
	|
	|-RVA: 0x1E20B60 Offset: 0x1E20C61 VA: 0x1E20B60
	|-Array.InternalArray__IEnumerable_GetEnumerator<RandomSeed>
	|
	|-RVA: 0x1E20C70 Offset: 0x1E20D71 VA: 0x1E20C70
	|-Array.InternalArray__IEnumerable_GetEnumerator<RangePositionInfo>
	|
	|-RVA: 0x1E20D80 Offset: 0x1E20E81 VA: 0x1E20D80
	|-Array.InternalArray__IEnumerable_GetEnumerator<Ranking2ChartInfoInput>
	|
	|-RVA: 0x1E20E90 Offset: 0x1E20F91 VA: 0x1E20E90
	|-Array.InternalArray__IEnumerable_GetEnumerator<RaycastHit>
	|
	|-RVA: 0x1E20FA0 Offset: 0x1E210A1 VA: 0x1E20FA0
	|-Array.InternalArray__IEnumerable_GetEnumerator<RaycastHit2D>
	|
	|-RVA: 0x1E210B0 Offset: 0x1E211B1 VA: 0x1E210B0
	|-Array.InternalArray__IEnumerable_GetEnumerator<RaycastResult>
	|
	|-RVA: 0x1E211C0 Offset: 0x1E212C1 VA: 0x1E211C0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Rect>
	|
	|-RVA: 0x1E212D0 Offset: 0x1E213D1 VA: 0x1E212D0
	|-Array.InternalArray__IEnumerable_GetEnumerator<RenderBuffer>
	|
	|-RVA: 0x1E213E0 Offset: 0x1E214E1 VA: 0x1E213E0
	|-Array.InternalArray__IEnumerable_GetEnumerator<RenderStateBlock>
	|
	|-RVA: 0x1E214F0 Offset: 0x1E215F1 VA: 0x1E214F0
	|-Array.InternalArray__IEnumerable_GetEnumerator<RenderTargetHandle>
	|
	|-RVA: 0x1E21600 Offset: 0x1E21701 VA: 0x1E21600
	|-Array.InternalArray__IEnumerable_GetEnumerator<RenderTargetIdentifier>
	|
	|-RVA: 0x1E21710 Offset: 0x1E21811 VA: 0x1E21710
	|-Array.InternalArray__IEnumerable_GetEnumerator<RendererListHandle>
	|
	|-RVA: 0x1E21820 Offset: 0x1E21921 VA: 0x1E21820
	|-Array.InternalArray__IEnumerable_GetEnumerator<ResourceHandle>
	|
	|-RVA: 0x1E21930 Offset: 0x1E21A31 VA: 0x1E21930
	|-Array.InternalArray__IEnumerable_GetEnumerator<ResourceLocator>
	|
	|-RVA: 0x1E21A40 Offset: 0x1E21B41 VA: 0x1E21A40
	|-Array.InternalArray__IEnumerable_GetEnumerator<RichTextTagAttribute>
	|
	|-RVA: 0x1E21B50 Offset: 0x1E21C51 VA: 0x1E21B50
	|-Array.InternalArray__IEnumerable_GetEnumerator<RuntimeLabel>
	|
	|-RVA: 0x1E21C60 Offset: 0x1E21D61 VA: 0x1E21C60
	|-Array.InternalArray__IEnumerable_GetEnumerator<sbyte>
	|
	|-RVA: 0x1E21D70 Offset: 0x1E21E71 VA: 0x1E21D70
	|-Array.InternalArray__IEnumerable_GetEnumerator<SerializedType>
	|
	|-RVA: 0x1E21E80 Offset: 0x1E21F81 VA: 0x1E21E80
	|-Array.InternalArray__IEnumerable_GetEnumerator<ShaderKeyword>
	|
	|-RVA: 0x1E21F90 Offset: 0x1E22091 VA: 0x1E21F90
	|-Array.InternalArray__IEnumerable_GetEnumerator<ShaderTagId>
	|
	|-RVA: 0x1E220A0 Offset: 0x1E221A1 VA: 0x1E220A0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ShadowSliceData>
	|
	|-RVA: 0x1E221B0 Offset: 0x1E222B1 VA: 0x1E221B0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Shape>
	|
	|-RVA: 0x1E222C0 Offset: 0x1E223C1 VA: 0x1E222C0
	|-Array.InternalArray__IEnumerable_GetEnumerator<float>
	|
	|-RVA: 0x1E223D0 Offset: 0x1E224D1 VA: 0x1E223D0
	|-Array.InternalArray__IEnumerable_GetEnumerator<SixAxisSensorHandle>
	|
	|-RVA: 0x1E224E0 Offset: 0x1E225E1 VA: 0x1E224E0
	|-Array.InternalArray__IEnumerable_GetEnumerator<SixAxisSensorState>
	|
	|-RVA: 0x1E225F0 Offset: 0x1E226F1 VA: 0x1E225F0
	|-Array.InternalArray__IEnumerable_GetEnumerator<SkeletonBone>
	|
	|-RVA: 0x1E22700 Offset: 0x1E22801 VA: 0x1E22700
	|-Array.InternalArray__IEnumerable_GetEnumerator<SortingLayer>
	|
	|-RVA: 0x1E22810 Offset: 0x1E22911 VA: 0x1E22810
	|-Array.InternalArray__IEnumerable_GetEnumerator<SphericalHarmonicsL2>
	|
	|-RVA: 0x1E22920 Offset: 0x1E22A21 VA: 0x1E22920
	|-Array.InternalArray__IEnumerable_GetEnumerator<SpinLock>
	|
	|-RVA: 0x1E22A30 Offset: 0x1E22B31 VA: 0x1E22A30
	|-Array.InternalArray__IEnumerable_GetEnumerator<SpringBoneComponents>
	|
	|-RVA: 0x1E22B40 Offset: 0x1E22C41 VA: 0x1E22B40
	|-Array.InternalArray__IEnumerable_GetEnumerator<SpringBoneProperties>
	|
	|-RVA: 0x1E22C50 Offset: 0x1E22D51 VA: 0x1E22C50
	|-Array.InternalArray__IEnumerable_GetEnumerator<SpringColliderComponents>
	|
	|-RVA: 0x1E22D60 Offset: 0x1E22E61 VA: 0x1E22D60
	|-Array.InternalArray__IEnumerable_GetEnumerator<SpringColliderProperties>
	|
	|-RVA: 0x1E22E70 Offset: 0x1E22F71 VA: 0x1E22E70
	|-Array.InternalArray__IEnumerable_GetEnumerator<SpringForceComponent>
	|
	|-RVA: 0x1E22F80 Offset: 0x1E23081 VA: 0x1E22F80
	|-Array.InternalArray__IEnumerable_GetEnumerator<SpringJobElement>
	|
	|-RVA: 0x1E23090 Offset: 0x1E23191 VA: 0x1E23090
	|-Array.InternalArray__IEnumerable_GetEnumerator<SpriteState>
	|
	|-RVA: 0x1E231A0 Offset: 0x1E232A1 VA: 0x1E231A0
	|-Array.InternalArray__IEnumerable_GetEnumerator<SubMeshDescriptor>
	|
	|-RVA: 0x1E232B0 Offset: 0x1E233B1 VA: 0x1E232B0
	|-Array.InternalArray__IEnumerable_GetEnumerator<TMP_CharacterInfo>
	|
	|-RVA: 0x1E233C0 Offset: 0x1E234C1 VA: 0x1E233C0
	|-Array.InternalArray__IEnumerable_GetEnumerator<TMP_FontWeightPair>
	|
	|-RVA: 0x1E234D0 Offset: 0x1E235D1 VA: 0x1E234D0
	|-Array.InternalArray__IEnumerable_GetEnumerator<TMP_LineInfo>
	|
	|-RVA: 0x1E235E0 Offset: 0x1E236E1 VA: 0x1E235E0
	|-Array.InternalArray__IEnumerable_GetEnumerator<TMP_LinkInfo>
	|
	|-RVA: 0x1E236F0 Offset: 0x1E237F1 VA: 0x1E236F0
	|-Array.InternalArray__IEnumerable_GetEnumerator<TMP_MeshInfo>
	|
	|-RVA: 0x1E23800 Offset: 0x1E23901 VA: 0x1E23800
	|-Array.InternalArray__IEnumerable_GetEnumerator<TMP_PageInfo>
	|
	|-RVA: 0x1E23910 Offset: 0x1E23A11 VA: 0x1E23910
	|-Array.InternalArray__IEnumerable_GetEnumerator<TMP_WordInfo>
	|
	|-RVA: 0x1E23A20 Offset: 0x1E23B21 VA: 0x1E23A20
	|-Array.InternalArray__IEnumerable_GetEnumerator<TablePair>
	|
	|-RVA: 0x1E23B30 Offset: 0x1E23C31 VA: 0x1E23B30
	|-Array.InternalArray__IEnumerable_GetEnumerator<TextureHandle>
	|
	|-RVA: 0x1E23C40 Offset: 0x1E23D41 VA: 0x1E23C40
	|-Array.InternalArray__IEnumerable_GetEnumerator<TimeSpan>
	|
	|-RVA: 0x1E23D50 Offset: 0x1E23E51 VA: 0x1E23D50
	|-Array.InternalArray__IEnumerable_GetEnumerator<Touch>
	|
	|-RVA: 0x1E23E60 Offset: 0x1E23F61 VA: 0x1E23E60
	|-Array.InternalArray__IEnumerable_GetEnumerator<TouchScreenState1>
	|
	|-RVA: 0x1E23F70 Offset: 0x1E24071 VA: 0x1E23F70
	|-Array.InternalArray__IEnumerable_GetEnumerator<TouchScreenState10>
	|
	|-RVA: 0x1E24080 Offset: 0x1E24181 VA: 0x1E24080
	|-Array.InternalArray__IEnumerable_GetEnumerator<TouchScreenState11>
	|
	|-RVA: 0x1E24190 Offset: 0x1E24291 VA: 0x1E24190
	|-Array.InternalArray__IEnumerable_GetEnumerator<TouchScreenState12>
	|
	|-RVA: 0x1E242A0 Offset: 0x1E243A1 VA: 0x1E242A0
	|-Array.InternalArray__IEnumerable_GetEnumerator<TouchScreenState13>
	|
	|-RVA: 0x1E243B0 Offset: 0x1E244B1 VA: 0x1E243B0
	|-Array.InternalArray__IEnumerable_GetEnumerator<TouchScreenState14>
	|
	|-RVA: 0x1E244C0 Offset: 0x1E245C1 VA: 0x1E244C0
	|-Array.InternalArray__IEnumerable_GetEnumerator<TouchScreenState15>
	|
	|-RVA: 0x1E245D0 Offset: 0x1E246D1 VA: 0x1E245D0
	|-Array.InternalArray__IEnumerable_GetEnumerator<TouchScreenState16>
	|
	|-RVA: 0x1E246E0 Offset: 0x1E247E1 VA: 0x1E246E0
	|-Array.InternalArray__IEnumerable_GetEnumerator<TouchScreenState2>
	|
	|-RVA: 0x1E247F0 Offset: 0x1E248F1 VA: 0x1E247F0
	|-Array.InternalArray__IEnumerable_GetEnumerator<TouchScreenState3>
	|
	|-RVA: 0x1E24900 Offset: 0x1E24A01 VA: 0x1E24900
	|-Array.InternalArray__IEnumerable_GetEnumerator<TouchScreenState4>
	|
	|-RVA: 0x1E24A10 Offset: 0x1E24B11 VA: 0x1E24A10
	|-Array.InternalArray__IEnumerable_GetEnumerator<TouchScreenState5>
	|
	|-RVA: 0x1E24B20 Offset: 0x1E24C21 VA: 0x1E24B20
	|-Array.InternalArray__IEnumerable_GetEnumerator<TouchScreenState6>
	|
	|-RVA: 0x1E24C30 Offset: 0x1E24D31 VA: 0x1E24C30
	|-Array.InternalArray__IEnumerable_GetEnumerator<TouchScreenState7>
	|
	|-RVA: 0x1E24D40 Offset: 0x1E24E41 VA: 0x1E24D40
	|-Array.InternalArray__IEnumerable_GetEnumerator<TouchScreenState8>
	|
	|-RVA: 0x1E24E50 Offset: 0x1E24F51 VA: 0x1E24E50
	|-Array.InternalArray__IEnumerable_GetEnumerator<TouchScreenState9>
	|
	|-RVA: 0x1E24F60 Offset: 0x1E25061 VA: 0x1E24F60
	|-Array.InternalArray__IEnumerable_GetEnumerator<TouchState>
	|
	|-RVA: 0x1E25070 Offset: 0x1E25171 VA: 0x1E25070
	|-Array.InternalArray__IEnumerable_GetEnumerator<TrailHand>
	|
	|-RVA: 0x1E25180 Offset: 0x1E25281 VA: 0x1E25180
	|-Array.InternalArray__IEnumerable_GetEnumerator<TrailVertex>
	|
	|-RVA: 0x1E25290 Offset: 0x1E25391 VA: 0x1E25290
	|-Array.InternalArray__IEnumerable_GetEnumerator<UICharInfo>
	|
	|-RVA: 0x1E253A0 Offset: 0x1E254A1 VA: 0x1E253A0
	|-Array.InternalArray__IEnumerable_GetEnumerator<UILineInfo>
	|
	|-RVA: 0x1E254B0 Offset: 0x1E255B1 VA: 0x1E254B0
	|-Array.InternalArray__IEnumerable_GetEnumerator<UIVertex>
	|
	|-RVA: 0x1E255C0 Offset: 0x1E256C1 VA: 0x1E255C0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ushort>
	|
	|-RVA: 0x1E256D0 Offset: 0x1E257D1 VA: 0x1E256D0
	|-Array.InternalArray__IEnumerable_GetEnumerator<UInt16Enum>
	|
	|-RVA: 0x1E257E0 Offset: 0x1E258E1 VA: 0x1E257E0
	|-Array.InternalArray__IEnumerable_GetEnumerator<uint>
	|
	|-RVA: 0x1E258F0 Offset: 0x1E259F1 VA: 0x1E258F0
	|-Array.InternalArray__IEnumerable_GetEnumerator<UInt32Enum>
	|
	|-RVA: 0x1E25A00 Offset: 0x1E25B01 VA: 0x1E25A00
	|-Array.InternalArray__IEnumerable_GetEnumerator<ulong>
	|
	|-RVA: 0x1E25B10 Offset: 0x1E25C11 VA: 0x1E25B10
	|-Array.InternalArray__IEnumerable_GetEnumerator<Uid>
	|
	|-RVA: 0x1E25C20 Offset: 0x1E25D21 VA: 0x1E25C20
	|-Array.InternalArray__IEnumerable_GetEnumerator<UniTask>
	|
	|-RVA: 0x1E25D30 Offset: 0x1E25E31 VA: 0x1E25D30
	|-Array.InternalArray__IEnumerable_GetEnumerator<Unit>
	|
	|-RVA: 0x1E25E40 Offset: 0x1E25F41 VA: 0x1E25E40
	|-Array.InternalArray__IEnumerable_GetEnumerator<UnitEnum>
	|
	|-RVA: 0x1E25F50 Offset: 0x1E26051 VA: 0x1E25F50
	|-Array.InternalArray__IEnumerable_GetEnumerator<UserWord>
	|
	|-RVA: 0x1E26060 Offset: 0x1E26161 VA: 0x1E26060
	|-Array.InternalArray__IEnumerable_GetEnumerator<Vector2>
	|
	|-RVA: 0x1E26170 Offset: 0x1E26271 VA: 0x1E26170
	|-Array.InternalArray__IEnumerable_GetEnumerator<Vector2Int>
	|
	|-RVA: 0x1E26280 Offset: 0x1E26381 VA: 0x1E26280
	|-Array.InternalArray__IEnumerable_GetEnumerator<Vector3>
	|
	|-RVA: 0x1E26390 Offset: 0x1E26491 VA: 0x1E26390
	|-Array.InternalArray__IEnumerable_GetEnumerator<Vector4>
	|
	|-RVA: 0x1E264A0 Offset: 0x1E265A1 VA: 0x1E264A0
	|-Array.InternalArray__IEnumerable_GetEnumerator<VertexAttributeDescriptor>
	|
	|-RVA: 0x1E265B0 Offset: 0x1E266B1 VA: 0x1E265B0
	|-Array.InternalArray__IEnumerable_GetEnumerator<VibrationDeviceHandle>
	|
	|-RVA: 0x1E266C0 Offset: 0x1E267C1 VA: 0x1E266C0
	|-Array.InternalArray__IEnumerable_GetEnumerator<VibrationDeviceInfo>
	|
	|-RVA: 0x1E267D0 Offset: 0x1E268D1 VA: 0x1E267D0
	|-Array.InternalArray__IEnumerable_GetEnumerator<VibrationValue>
	|
	|-RVA: 0x1E268E0 Offset: 0x1E269E1 VA: 0x1E268E0
	|-Array.InternalArray__IEnumerable_GetEnumerator<VisibleLight>
	|
	|-RVA: 0x1E269F0 Offset: 0x1E26AF1 VA: 0x1E269F0
	|-Array.InternalArray__IEnumerable_GetEnumerator<WordWrapState>
	|
	|-RVA: 0x1E26B00 Offset: 0x1E26C01 VA: 0x1E26B00
	|-Array.InternalArray__IEnumerable_GetEnumerator<X509ChainStatus>
	|
	|-RVA: 0x1E26C10 Offset: 0x1E26D11 VA: 0x1E26C10
	|-Array.InternalArray__IEnumerable_GetEnumerator<XPathNode>
	|
	|-RVA: 0x1E26D20 Offset: 0x1E26E21 VA: 0x1E26D20
	|-Array.InternalArray__IEnumerable_GetEnumerator<XPathNodeRef>
	|
	|-RVA: 0x1E26E30 Offset: 0x1E26F31 VA: 0x1E26E30
	|-Array.InternalArray__IEnumerable_GetEnumerator<XRView>
	|
	|-RVA: 0x1E26F40 Offset: 0x1E27041 VA: 0x1E26F40
	|-Array.InternalArray__IEnumerable_GetEnumerator<float3>
	|
	|-RVA: 0x1E27050 Offset: 0x1E27151 VA: 0x1E27050
	|-Array.InternalArray__IEnumerable_GetEnumerator<float4x4>
	|
	|-RVA: 0x1E27160 Offset: 0x1E27261 VA: 0x1E27160
	|-Array.InternalArray__IEnumerable_GetEnumerator<jvalue>
	|
	|-RVA: 0x1E27270 Offset: 0x1E27371 VA: 0x1E27270
	|-Array.InternalArray__IEnumerable_GetEnumerator<uint4>
	|
	|-RVA: 0x1E27380 Offset: 0x1E27481 VA: 0x1E27380
	|-Array.InternalArray__IEnumerable_GetEnumerator<AICrossfire.PositionTable>
	|
	|-RVA: 0x1E27490 Offset: 0x1E27591 VA: 0x1E27490
	|-Array.InternalArray__IEnumerable_GetEnumerator<AIEnum.SkillRangeEnemyData>
	|
	|-RVA: 0x1E275A0 Offset: 0x1E276A1 VA: 0x1E275A0
	|-Array.InternalArray__IEnumerable_GetEnumerator<AIOrder.UnitPriority>
	|
	|-RVA: 0x1E276B0 Offset: 0x1E277B1 VA: 0x1E276B0
	|-Array.InternalArray__IEnumerable_GetEnumerator<AmiiboSequence.GainItemData>
	|
	|-RVA: 0x1E277C0 Offset: 0x1E278C1 VA: 0x1E277C0
	|-Array.InternalArray__IEnumerable_GetEnumerator<AnimationOutputWeightProcessor.WeightInfo>
	|
	|-RVA: 0x1E278D0 Offset: 0x1E279D1 VA: 0x1E278D0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ArenaOrderSequence.GodInfo>
	|
	|-RVA: 0x1E279E0 Offset: 0x1E27AE1 VA: 0x1E279E0
	|-Array.InternalArray__IEnumerable_GetEnumerator<BattleInfo.SupportData>
	|
	|-RVA: 0x1E27AF0 Offset: 0x1E27BF1 VA: 0x1E27AF0
	|-Array.InternalArray__IEnumerable_GetEnumerator<BeforeRenderHelper.OrderBlock>
	|
	|-RVA: 0x1E27C00 Offset: 0x1E27D01 VA: 0x1E27C00
	|-Array.InternalArray__IEnumerable_GetEnumerator<Camera.RenderRequest>
	|
	|-RVA: 0x1E27D10 Offset: 0x1E27E11 VA: 0x1E27D10
	|-Array.InternalArray__IEnumerable_GetEnumerator<CameraState.CustomBlendable>
	|
	|-RVA: 0x1E27E20 Offset: 0x1E27F21 VA: 0x1E27E20
	|-Array.InternalArray__IEnumerable_GetEnumerator<CinemachineBlendListCamera.Instruction>
	|
	|-RVA: 0x1E27F30 Offset: 0x1E28031 VA: 0x1E27F30
	|-Array.InternalArray__IEnumerable_GetEnumerator<CinemachineBlenderSettings.CustomBlend>
	|
	|-RVA: 0x1E28040 Offset: 0x1E28141 VA: 0x1E28040
	|-Array.InternalArray__IEnumerable_GetEnumerator<CinemachineClearShot.Pair>
	|
	|-RVA: 0x1E28150 Offset: 0x1E28251 VA: 0x1E28150
	|-Array.InternalArray__IEnumerable_GetEnumerator<CinemachineFreeLook.Orbit>
	|
	|-RVA: 0x1E28260 Offset: 0x1E28361 VA: 0x1E28260
	|-Array.InternalArray__IEnumerable_GetEnumerator<CinemachinePath.Waypoint>
	|
	|-RVA: 0x1E28370 Offset: 0x1E28471 VA: 0x1E28370
	|-Array.InternalArray__IEnumerable_GetEnumerator<CinemachineSmoothPath.Waypoint>
	|
	|-RVA: 0x1E28480 Offset: 0x1E28581 VA: 0x1E28480
	|-Array.InternalArray__IEnumerable_GetEnumerator<CinemachineStateDrivenCamera.HashPair>
	|
	|-RVA: 0x1E28590 Offset: 0x1E28691 VA: 0x1E28590
	|-Array.InternalArray__IEnumerable_GetEnumerator<CinemachineStateDrivenCamera.Instruction>
	|
	|-RVA: 0x1E286A0 Offset: 0x1E287A1 VA: 0x1E286A0
	|-Array.InternalArray__IEnumerable_GetEnumerator<CinemachineStateDrivenCamera.ParentHash>
	|
	|-RVA: 0x1E287B0 Offset: 0x1E288B1 VA: 0x1E287B0
	|-Array.InternalArray__IEnumerable_GetEnumerator<CinemachineTargetGroup.Target>
	|
	|-RVA: 0x1E288C0 Offset: 0x1E289C1 VA: 0x1E288C0
	|-Array.InternalArray__IEnumerable_GetEnumerator<CodePointIndexer.TableRange>
	|
	|-RVA: 0x1E289D0 Offset: 0x1E28AD1 VA: 0x1E289D0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ContentCatalogData.Bucket>
	|
	|-RVA: 0x1E28AE0 Offset: 0x1E28BE1 VA: 0x1E28AE0
	|-Array.InternalArray__IEnumerable_GetEnumerator<CookieTokenizer.RecognizedAttribute>
	|
	|-RVA: 0x1E28BF0 Offset: 0x1E28CF1 VA: 0x1E28BF0
	|-Array.InternalArray__IEnumerable_GetEnumerator<DeferredLights.DrawCall>
	|
	|-RVA: 0x1E28D00 Offset: 0x1E28E01 VA: 0x1E28D00
	|-Array.InternalArray__IEnumerable_GetEnumerator<DeferredShaderData.ComputeBufferInfo>
	|
	|-RVA: 0x1E28E10 Offset: 0x1E28F11 VA: 0x1E28E10
	|-Array.InternalArray__IEnumerable_GetEnumerator<DeferredTiler.PrePunctualLight>
	|
	|-RVA: 0x1E28F20 Offset: 0x1E29021 VA: 0x1E28F20
	|-Array.InternalArray__IEnumerable_GetEnumerator<DelayedActionManager.DelegateInfo>
	|
	|-RVA: 0x1E29030 Offset: 0x1E29131 VA: 0x1E29030
	|-Array.InternalArray__IEnumerable_GetEnumerator<Detail.AsyncResultInt>
	|
	|-RVA: 0x1E29140 Offset: 0x1E29241 VA: 0x1E29140
	|-Array.InternalArray__IEnumerable_GetEnumerator<Detail.CppArray>
	|
	|-RVA: 0x1E29250 Offset: 0x1E29351 VA: 0x1E29250
	|-Array.InternalArray__IEnumerable_GetEnumerator<Detail.NotificationEventInt>
	|
	|-RVA: 0x1E29360 Offset: 0x1E29461 VA: 0x1E29360
	|-Array.InternalArray__IEnumerable_GetEnumerator<DisposUnit.Item>
	|
	|-RVA: 0x1E29470 Offset: 0x1E29571 VA: 0x1E29470
	|-Array.InternalArray__IEnumerable_GetEnumerator<DragonRidePresetParamData.CourseData>
	|
	|-RVA: 0x1E29580 Offset: 0x1E29681 VA: 0x1E29580
	|-Array.InternalArray__IEnumerable_GetEnumerator<DragonRideTargetGroup.ChainParam>
	|
	|-RVA: 0x1E29690 Offset: 0x1E29791 VA: 0x1E29690
	|-Array.InternalArray__IEnumerable_GetEnumerator<DynamicMesh.State>
	|
	|-RVA: 0x1E297A0 Offset: 0x1E298A1 VA: 0x1E297A0
	|-Array.InternalArray__IEnumerable_GetEnumerator<FXZEx.HitPoint>
	|
	|-RVA: 0x1E298B0 Offset: 0x1E299B1 VA: 0x1E298B0
	|-Array.InternalArray__IEnumerable_GetEnumerator<FishingRadicalParamData.RadicalParam>
	|
	|-RVA: 0x1E299C0 Offset: 0x1E29AC1 VA: 0x1E299C0
	|-Array.InternalArray__IEnumerable_GetEnumerator<GameVariable.Value>
	|
	|-RVA: 0x1E29AD0 Offset: 0x1E29BD1 VA: 0x1E29AD0
	|-Array.InternalArray__IEnumerable_GetEnumerator<GmapPathAdjuster.TargetModel>
	|
	|-RVA: 0x1E29BE0 Offset: 0x1E29CE1 VA: 0x1E29BE0
	|-Array.InternalArray__IEnumerable_GetEnumerator<GmapSpotAdjuster.TargetModel>
	|
	|-RVA: 0x1E29CF0 Offset: 0x1E29DF1 VA: 0x1E29CF0
	|-Array.InternalArray__IEnumerable_GetEnumerator<GrounderQuadruped.Foot>
	|
	|-RVA: 0x1E29E00 Offset: 0x1E29F01 VA: 0x1E29E00
	|-Array.InternalArray__IEnumerable_GetEnumerator<Hashtable.bucket>
	|
	|-RVA: 0x1E29F10 Offset: 0x1E2A011 VA: 0x1E29F10
	|-Array.InternalArray__IEnumerable_GetEnumerator<HeadingTracker.Item>
	|
	|-RVA: 0x1E2A020 Offset: 0x1E2A121 VA: 0x1E2A020
	|-Array.InternalArray__IEnumerable_GetEnumerator<HubAccessoryRoomCamera.BackgroundSettings>
	|
	|-RVA: 0x1E2A130 Offset: 0x1E2A231 VA: 0x1E2A130
	|-Array.InternalArray__IEnumerable_GetEnumerator<HubFastTravel.Location>
	|
	|-RVA: 0x1E2A240 Offset: 0x1E2A341 VA: 0x1E2A240
	|-Array.InternalArray__IEnumerable_GetEnumerator<HubLensFlare.Flare>
	|
	|-RVA: 0x1E2A350 Offset: 0x1E2A451 VA: 0x1E2A350
	|-Array.InternalArray__IEnumerable_GetEnumerator<HubLookAtController.LookAtIKParam>
	|
	|-RVA: 0x1E2A460 Offset: 0x1E2A561 VA: 0x1E2A460
	|-Array.InternalArray__IEnumerable_GetEnumerator<HubMaterialArray.MaterialInfo>
	|
	|-RVA: 0x1E2A570 Offset: 0x1E2A671 VA: 0x1E2A570
	|-Array.InternalArray__IEnumerable_GetEnumerator<IKSolverLimb.AxisDirection>
	|
	|-RVA: 0x1E2A680 Offset: 0x1E2A781 VA: 0x1E2A680
	|-Array.InternalArray__IEnumerable_GetEnumerator<InventoryPoolItemMenuContent.KindBgNameClass>
	|
	|-RVA: 0x1E2A790 Offset: 0x1E2A891 VA: 0x1E2A790
	|-Array.InternalArray__IEnumerable_GetEnumerator<LightUtility.ParametricLightMeshVertex>
	|
	|-RVA: 0x1E2A8A0 Offset: 0x1E2A9A1 VA: 0x1E2A8A0
	|-Array.InternalArray__IEnumerable_GetEnumerator<LightUtility.SpriteLightMeshVertex>
	|
	|-RVA: 0x1E2A9B0 Offset: 0x1E2AAB1 VA: 0x1E2A9B0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Map.Pos>
	|
	|-RVA: 0x1E2AAC0 Offset: 0x1E2ABC1 VA: 0x1E2AAC0
	|-Array.InternalArray__IEnumerable_GetEnumerator<MapGodExp.KindDesc>
	|
	|-RVA: 0x1E2ABD0 Offset: 0x1E2ACD1 VA: 0x1E2ABD0
	|-Array.InternalArray__IEnumerable_GetEnumerator<MapHistory.Command>
	|
	|-RVA: 0x1E2ACE0 Offset: 0x1E2ADE1 VA: 0x1E2ACE0
	|-Array.InternalArray__IEnumerable_GetEnumerator<MapImage.BackupTerrain>
	|
	|-RVA: 0x1E2ADF0 Offset: 0x1E2AEF1 VA: 0x1E2ADF0
	|-Array.InternalArray__IEnumerable_GetEnumerator<MapImageRange.Pos>
	|
	|-RVA: 0x1E2AF00 Offset: 0x1E2B001 VA: 0x1E2AF00
	|-Array.InternalArray__IEnumerable_GetEnumerator<MapKillBonus.KillBonus>
	|
	|-RVA: 0x1E2B010 Offset: 0x1E2B111 VA: 0x1E2B010
	|-Array.InternalArray__IEnumerable_GetEnumerator<MapKillBonus.KilledBonus>
	|
	|-RVA: 0x1E2B120 Offset: 0x1E2B221 VA: 0x1E2B120
	|-Array.InternalArray__IEnumerable_GetEnumerator<MapMind.Record>
	|
	|-RVA: 0x1E2B230 Offset: 0x1E2B331 VA: 0x1E2B230
	|-Array.InternalArray__IEnumerable_GetEnumerator<MapMind.Target>
	|
	|-RVA: 0x1E2B340 Offset: 0x1E2B441 VA: 0x1E2B340
	|-Array.InternalArray__IEnumerable_GetEnumerator<MapPanelDebug.Entity>
	|
	|-RVA: 0x1E2B450 Offset: 0x1E2B551 VA: 0x1E2B450
	|-Array.InternalArray__IEnumerable_GetEnumerator<NexRanking.Data>
	|
	|-RVA: 0x1E2B560 Offset: 0x1E2B661 VA: 0x1E2B560
	|-Array.InternalArray__IEnumerable_GetEnumerator<NexVersus.RatingData>
	|
	|-RVA: 0x1E2B670 Offset: 0x1E2B771 VA: 0x1E2B670
	|-Array.InternalArray__IEnumerable_GetEnumerator<NoiseSettings.TransformNoiseParams>
	|
	|-RVA: 0x1E2B780 Offset: 0x1E2B881 VA: 0x1E2B780
	|-Array.InternalArray__IEnumerable_GetEnumerator<PackedPlayModeBuildLogs.RuntimeBuildLog>
	|
	|-RVA: 0x1E2B890 Offset: 0x1E2B991 VA: 0x1E2B890
	|-Array.InternalArray__IEnumerable_GetEnumerator<ParameterizedStrings.FormatParam>
	|
	|-RVA: 0x1E2B9A0 Offset: 0x1E2BAA1 VA: 0x1E2B9A0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ParticleSystem.Particle>
	|
	|-RVA: 0x1E2BAB0 Offset: 0x1E2BBB1 VA: 0x1E2BAB0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ProfileCard.Achievement>
	|
	|-RVA: 0x1E2BBC0 Offset: 0x1E2BCC1 VA: 0x1E2BBC0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ProfileCard.SortieCount>
	|
	|-RVA: 0x1E2BCD0 Offset: 0x1E2BDD1 VA: 0x1E2BCD0
	|-Array.InternalArray__IEnumerable_GetEnumerator<QualitySettingsStack.Settings>
	|
	|-RVA: 0x1E2BDE0 Offset: 0x1E2BEE1 VA: 0x1E2BDE0
	|-Array.InternalArray__IEnumerable_GetEnumerator<RangeData.Offset>
	|
	|-RVA: 0x1E2BEF0 Offset: 0x1E2BFF1 VA: 0x1E2BEF0
	|-Array.InternalArray__IEnumerable_GetEnumerator<RegexCharClass.LowerCaseMapping>
	|
	|-RVA: 0x1E2C000 Offset: 0x1E2C101 VA: 0x1E2C000
	|-Array.InternalArray__IEnumerable_GetEnumerator<Relay.ChooseAwardeeData>
	|
	|-RVA: 0x1E2C110 Offset: 0x1E2C211 VA: 0x1E2C110
	|-Array.InternalArray__IEnumerable_GetEnumerator<RelayAwardData.Info>
	|
	|-RVA: 0x1E2C220 Offset: 0x1E2C321 VA: 0x1E2C220
	|-Array.InternalArray__IEnumerable_GetEnumerator<RenderGraph.CompiledPassInfo>
	|
	|-RVA: 0x1E2C330 Offset: 0x1E2C431 VA: 0x1E2C330
	|-Array.InternalArray__IEnumerable_GetEnumerator<RenderGraph.CompiledResourceInfo>
	|
	|-RVA: 0x1E2C440 Offset: 0x1E2C541 VA: 0x1E2C440
	|-Array.InternalArray__IEnumerable_GetEnumerator<RenderGraphDebugData.PassDebugData>
	|
	|-RVA: 0x1E2C550 Offset: 0x1E2C651 VA: 0x1E2C550
	|-Array.InternalArray__IEnumerable_GetEnumerator<RenderGraphDebugData.ResourceDebugData>
	|
	|-RVA: 0x1E2C660 Offset: 0x1E2C761 VA: 0x1E2C660
	|-Array.InternalArray__IEnumerable_GetEnumerator<RenderGraphResourceRegistry.RendererListResource>
	|
	|-RVA: 0x1E2C770 Offset: 0x1E2C871 VA: 0x1E2C770
	|-Array.InternalArray__IEnumerable_GetEnumerator<RingCleaningUnitSelectMenu.GodParam>
	|
	|-RVA: 0x1E2C880 Offset: 0x1E2C981 VA: 0x1E2C880
	|-Array.InternalArray__IEnumerable_GetEnumerator<SampleWave.Data>
	|
	|-RVA: 0x1E2C990 Offset: 0x1E2CA91 VA: 0x1E2C990
	|-Array.InternalArray__IEnumerable_GetEnumerator<SampleWave.Temp>
	|
	|-RVA: 0x1E2CAA0 Offset: 0x1E2CBA1 VA: 0x1E2CAA0
	|-Array.InternalArray__IEnumerable_GetEnumerator<SendMouseEvents.HitInfo>
	|
	|-RVA: 0x1E2CBB0 Offset: 0x1E2CCB1 VA: 0x1E2CBB0
	|-Array.InternalArray__IEnumerable_GetEnumerator<SequenceNode.SequenceConstructPosContext>
	|
	|-RVA: 0x1E2CCC0 Offset: 0x1E2CDC1 VA: 0x1E2CCC0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ShaderInput.LightData>
	|
	|-RVA: 0x1E2CDD0 Offset: 0x1E2CED1 VA: 0x1E2CDD0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ShaderInput.ShadowData>
	|
	|-RVA: 0x1E2CEE0 Offset: 0x1E2CFE1 VA: 0x1E2CEE0
	|-Array.InternalArray__IEnumerable_GetEnumerator<ShadowUtility.Edge>
	|
	|-RVA: 0x1E2CFF0 Offset: 0x1E2D0F1 VA: 0x1E2CFF0
	|-Array.InternalArray__IEnumerable_GetEnumerator<SimpleAnimationPlayable.QueuedState>
	|
	|-RVA: 0x1E2D100 Offset: 0x1E2D201 VA: 0x1E2D100
	|-Array.InternalArray__IEnumerable_GetEnumerator<SkillArray.Entity>
	|
	|-RVA: 0x1E2D210 Offset: 0x1E2D311 VA: 0x1E2D210
	|-Array.InternalArray__IEnumerable_GetEnumerator<Socket.WSABUF>
	|
	|-RVA: 0x1E2D320 Offset: 0x1E2D421 VA: 0x1E2D320
	|-Array.InternalArray__IEnumerable_GetEnumerator<Stream.Info>
	|
	|-RVA: 0x1E2D430 Offset: 0x1E2D531 VA: 0x1E2D430
	|-Array.InternalArray__IEnumerable_GetEnumerator<TMP_Text.UnicodeChar>
	|
	|-RVA: 0x1E2D540 Offset: 0x1E2D641 VA: 0x1E2D540
	|-Array.InternalArray__IEnumerable_GetEnumerator<TexturePacker_JsonArray.Frame>
	|
	|-RVA: 0x1E2D650 Offset: 0x1E2D751 VA: 0x1E2D650
	|-Array.InternalArray__IEnumerable_GetEnumerator<TimeNotificationBehaviour.NotificationEntry>
	|
	|-RVA: 0x1E2D760 Offset: 0x1E2D861 VA: 0x1E2D760
	|-Array.InternalArray__IEnumerable_GetEnumerator<UnitySynchronizationContext.WorkRequest>
	|
	|-RVA: 0x1E2D870 Offset: 0x1E2D971 VA: 0x1E2D870
	|-Array.InternalArray__IEnumerable_GetEnumerator<XmlNamespaceManager.NamespaceDeclaration>
	|
	|-RVA: 0x1E2D980 Offset: 0x1E2DA81 VA: 0x1E2D980
	|-Array.InternalArray__IEnumerable_GetEnumerator<XmlSchemaObjectTable.XmlSchemaObjectEntry>
	|
	|-RVA: 0x1E2DA90 Offset: 0x1E2DB91 VA: 0x1E2DA90
	|-Array.InternalArray__IEnumerable_GetEnumerator<XmlTextReaderImpl.ParsingState>
	|
	|-RVA: 0x1E2DBA0 Offset: 0x1E2DCA1 VA: 0x1E2DBA0
	|-Array.InternalArray__IEnumerable_GetEnumerator<AIThink.EnchantThink.Desc>
	|
	|-RVA: 0x1E2DCB0 Offset: 0x1E2DDB1 VA: 0x1E2DCB0
	|-Array.InternalArray__IEnumerable_GetEnumerator<AIThink.EnchantThink.ItemInfo>
	|
	|-RVA: 0x1E2DDC0 Offset: 0x1E2DEC1 VA: 0x1E2DDC0
	|-Array.InternalArray__IEnumerable_GetEnumerator<AIThink.EnchantThink.SurroundingInfo>
	|
	|-RVA: 0x1E2DED0 Offset: 0x1E2DFD1 VA: 0x1E2DED0
	|-Array.InternalArray__IEnumerable_GetEnumerator<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>
	|
	|-RVA: 0x1E2DFE0 Offset: 0x1E2E0E1 VA: 0x1E2DFE0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Detail.DataStore.DataStoreChangeMetaParamInt>
	|
	|-RVA: 0x1E2E0F0 Offset: 0x1E2E1F1 VA: 0x1E2E0F0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Detail.DataStore.DataStoreDeleteParamInt>
	|
	|-RVA: 0x1E2E200 Offset: 0x1E2E301 VA: 0x1E2E200
	|-Array.InternalArray__IEnumerable_GetEnumerator<Detail.DataStore.DataStoreGetMetaParamInt>
	|
	|-RVA: 0x1E2E310 Offset: 0x1E2E411 VA: 0x1E2E310
	|-Array.InternalArray__IEnumerable_GetEnumerator<Detail.DataStore.DataStoreMetaInfoInt>
	|
	|-RVA: 0x1E2E420 Offset: 0x1E2E521 VA: 0x1E2E420
	|-Array.InternalArray__IEnumerable_GetEnumerator<Detail.DataStore.DataStorePasswordInfoInt>
	|
	|-RVA: 0x1E2E530 Offset: 0x1E2E631 VA: 0x1E2E530
	|-Array.InternalArray__IEnumerable_GetEnumerator<Detail.DataStore.DataStorePersistenceInfoInt>
	|
	|-RVA: 0x1E2E640 Offset: 0x1E2E741 VA: 0x1E2E640
	|-Array.InternalArray__IEnumerable_GetEnumerator<Detail.DataStore.DataStorePreparePostParamInt>
	|
	|-RVA: 0x1E2E750 Offset: 0x1E2E851 VA: 0x1E2E750
	|-Array.InternalArray__IEnumerable_GetEnumerator<Detail.DataStore.DataStoreRateObjectParamInt>
	|
	|-RVA: 0x1E2E860 Offset: 0x1E2E961 VA: 0x1E2E860
	|-Array.InternalArray__IEnumerable_GetEnumerator<Detail.DataStore.DataStoreRatingInitParamInt>
	|
	|-RVA: 0x1E2E970 Offset: 0x1E2EA71 VA: 0x1E2E970
	|-Array.InternalArray__IEnumerable_GetEnumerator<Detail.DataStore.DataStoreRatingTargetInt>
	|
	|-RVA: 0x1E2EA80 Offset: 0x1E2EB81 VA: 0x1E2EA80
	|-Array.InternalArray__IEnumerable_GetEnumerator<Detail.Ranking.RankingCachedResultInt>
	|
	|-RVA: 0x1E2EB90 Offset: 0x1E2EC91 VA: 0x1E2EB90
	|-Array.InternalArray__IEnumerable_GetEnumerator<Detail.Ranking.RankingOrderParamInt>
	|
	|-RVA: 0x1E2ECA0 Offset: 0x1E2EDA1 VA: 0x1E2ECA0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Detail.Ranking.RankingRankDataInt>
	|
	|-RVA: 0x1E2EDB0 Offset: 0x1E2EEB1 VA: 0x1E2EDB0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Detail.Ranking2.Ranking2ChartInfoInt>
	|
	|-RVA: 0x1E2EEC0 Offset: 0x1E2EFC1 VA: 0x1E2EEC0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Detail.Ranking2.Ranking2RankDataInt>
	|
	|-RVA: 0x1E2EFD0 Offset: 0x1E2F0D1 VA: 0x1E2EFD0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Detail.Ranking2.Ranking2ScoreDataInt>
	|
	|-RVA: 0x1E2F0E0 Offset: 0x1E2F1E1 VA: 0x1E2F0E0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Detail.Screening.ScreeningContextInfoInt>
	|
	|-RVA: 0x1E2F1F0 Offset: 0x1E2F2F1 VA: 0x1E2F1F0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Detail.Subscriber.SubscriberContentInt>
	|
	|-RVA: 0x1E2F300 Offset: 0x1E2F401 VA: 0x1E2F300
	|-Array.InternalArray__IEnumerable_GetEnumerator<Detail.Subscriber.SubscriberGetContentParamInt>
	|
	|-RVA: 0x1E2F410 Offset: 0x1E2F511 VA: 0x1E2F410
	|-Array.InternalArray__IEnumerable_GetEnumerator<Detail.Subscriber.SubscriberUserStatusInfoInt>
	|
	|-RVA: 0x1E2F520 Offset: 0x1E2F621 VA: 0x1E2F520
	|-Array.InternalArray__IEnumerable_GetEnumerator<Detail.Subscriber.SubscriberUserStatusParamInt>
	|
	|-RVA: 0x1E2F630 Offset: 0x1E2F731 VA: 0x1E2F630
	|-Array.InternalArray__IEnumerable_GetEnumerator<Detail.Utility.IntegerSettings>
	|
	|-RVA: 0x1E2F740 Offset: 0x1E2F841 VA: 0x1E2F740
	|-Array.InternalArray__IEnumerable_GetEnumerator<Detail.Utility.UniqueIdInfoInt>
	|
	|-RVA: 0x1E2F850 Offset: 0x1E2F951 VA: 0x1E2F850
	|-Array.InternalArray__IEnumerable_GetEnumerator<FacetsChecker.FacetsCompiler.Map>
	|
	|-RVA: 0x1E2F960 Offset: 0x1E2FA61 VA: 0x1E2F960
	|-Array.InternalArray__IEnumerable_GetEnumerator<MapHistory.ReplayAppearanceMap.Appearance>
	|
	|-RVA: 0x1E2FA70 Offset: 0x1E2FB71 VA: 0x1E2FA70
	|-Array.InternalArray__IEnumerable_GetEnumerator<MapHistory.ReplayAppearanceMap.Leaving>
	|
	|-RVA: 0x1E2FB80 Offset: 0x1E2FC81 VA: 0x1E2FB80
	|-Array.InternalArray__IEnumerable_GetEnumerator<MapHistory.ReplayUnitMap.Data>
	|
	|-RVA: 0x1E2FC90 Offset: 0x1E2FD91 VA: 0x1E2FC90
	|-Array.InternalArray__IEnumerable_GetEnumerator<MapHistory.Rewind.LatestInspectorData>
	|
	|-RVA: 0x1E2FDA0 Offset: 0x1E2FEA1 VA: 0x1E2FDA0
	|-Array.InternalArray__IEnumerable_GetEnumerator<MapHistory.Rewind.WorkTerrainData>
	|
	|-RVA: 0x1E2FEB0 Offset: 0x1E2FFB1 VA: 0x1E2FEB0
	|-Array.InternalArray__IEnumerable_GetEnumerator<MapHistory.RewindUnitMap.Data>
	|
	|-RVA: 0x1E2FFC0 Offset: 0x1E300C1 VA: 0x1E2FFC0
	|-Array.InternalArray__IEnumerable_GetEnumerator<MapKillBonus.Work.Pos>
	|
	|-RVA: 0x1E300D0 Offset: 0x1E301D1 VA: 0x1E300D0
	|-Array.InternalArray__IEnumerable_GetEnumerator<MapSkill.AroundCalculator.Result>
	|
	|-RVA: 0x1E301E0 Offset: 0x1E302E1 VA: 0x1E301E0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Nex.ApiCallChecker.Guideline>
	|
	|-RVA: 0x1E302F0 Offset: 0x1E303F1 VA: 0x1E302F0
	|-Array.InternalArray__IEnumerable_GetEnumerator<Ngc.MaskTextSequenceBase.Data>
	|
	|-RVA: 0x1E30400 Offset: 0x1E30501 VA: 0x1E30400
	|-Array.InternalArray__IEnumerable_GetEnumerator<TargetPositionCache.CacheCurve.Item>
	|
	|-RVA: 0x1E30510 Offset: 0x1E30611 VA: 0x1E30510
	|-Array.InternalArray__IEnumerable_GetEnumerator<TargetPositionCache.CacheEntry.RecordingItem>
	|
	|-RVA: 0x1E30620 Offset: 0x1E30721 VA: 0x1E30620
	|-Array.InternalArray__IEnumerable_GetEnumerator<TerrainUtility.TerrainMap.TileCoord>
	*/

	// RVA: 0x3564050 Offset: 0x3564151 VA: 0x3564050
	internal void InternalArray__ICollection_Clear() { }

	// RVA: -1 Offset: -1
	internal void InternalArray__ICollection_Add<T>(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21164B0 Offset: 0x21165B1 VA: 0x21164B0
	|-Array.InternalArray__ICollection_Add<ArraySegment<byte>>
	|
	|-RVA: 0x2116510 Offset: 0x2116611 VA: 0x2116510
	|-Array.InternalArray__ICollection_Add<AsyncOperationHandle<object>>
	|
	|-RVA: 0x2116570 Offset: 0x2116671 VA: 0x2116570
	|-Array.InternalArray__ICollection_Add<MapDeployTemplate.Queue.Data<object>>
	|
	|-RVA: 0x21165D0 Offset: 0x21166D1 VA: 0x21165D0
	|-Array.InternalArray__ICollection_Add<Nex.DataStore.ParamPool.Data<object>>
	|
	|-RVA: 0x2116630 Offset: 0x2116731 VA: 0x2116630
	|-Array.InternalArray__ICollection_Add<Nex.Screening.ParamPool.Data<object>>
	|
	|-RVA: 0x2116690 Offset: 0x2116791 VA: 0x2116690
	|-Array.InternalArray__ICollection_Add<IntervalTree.Entry<object>>
	|
	|-RVA: 0x21166F0 Offset: 0x21167F1 VA: 0x21166F0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<ValueTuple<object, int>, object>>
	|
	|-RVA: 0x2116750 Offset: 0x2116851 VA: 0x2116750
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<byte, object>>
	|
	|-RVA: 0x21167B0 Offset: 0x21168B1 VA: 0x21167B0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<CancellationToken, object>>
	|
	|-RVA: 0x2116810 Offset: 0x2116911 VA: 0x2116810
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<char, object>>
	|
	|-RVA: 0x2116870 Offset: 0x2116971 VA: 0x2116870
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Guid, object>>
	|
	|-RVA: 0x21168D0 Offset: 0x21169D1 VA: 0x21168D0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<int, bool>>
	|
	|-RVA: 0x2116930 Offset: 0x2116A31 VA: 0x2116930
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<int, byte>>
	|
	|-RVA: 0x2116990 Offset: 0x2116A91 VA: 0x2116990
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<int, char>>
	|
	|-RVA: 0x21169F0 Offset: 0x2116AF1 VA: 0x21169F0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<int, DiagnosticEvent>>
	|
	|-RVA: 0x2116A50 Offset: 0x2116B51 VA: 0x2116A50
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<int, int>>
	|
	|-RVA: 0x2116AB0 Offset: 0x2116BB1 VA: 0x2116AB0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<int, Int32Enum>>
	|
	|-RVA: 0x2116B10 Offset: 0x2116C11 VA: 0x2116B10
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<int, long>>
	|
	|-RVA: 0x2116B70 Offset: 0x2116C71 VA: 0x2116B70
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<int, MapPos>>
	|
	|-RVA: 0x2116BD0 Offset: 0x2116CD1 VA: 0x2116BD0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<int, object>>
	|
	|-RVA: 0x2116C30 Offset: 0x2116D31 VA: 0x2116C30
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<int, uint>>
	|
	|-RVA: 0x2116C90 Offset: 0x2116D91 VA: 0x2116C90
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<int, AIThink.EnchantThink.SurroundingInfo>>
	|
	|-RVA: 0x2116CF0 Offset: 0x2116DF1 VA: 0x2116CF0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Int32Enum, bool>>
	|
	|-RVA: 0x2116D50 Offset: 0x2116E51 VA: 0x2116D50
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Int32Enum, int>>
	|
	|-RVA: 0x2116DB0 Offset: 0x2116EB1 VA: 0x2116DB0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Int32Enum, Int32Enum>>
	|
	|-RVA: 0x2116E10 Offset: 0x2116F11 VA: 0x2116E10
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Int32Enum, object>>
	|
	|-RVA: 0x2116E70 Offset: 0x2116F71 VA: 0x2116E70
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<long, object>>
	|
	|-RVA: 0x2116ED0 Offset: 0x2116FD1 VA: 0x2116ED0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<MapPos, int>>
	|
	|-RVA: 0x2116F30 Offset: 0x2117031 VA: 0x2116F30
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, AsyncOperationHandle<object>>>
	|
	|-RVA: 0x2116F90 Offset: 0x2117091 VA: 0x2116F90
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, AsyncOperationHandle>>
	|
	|-RVA: 0x2116FF0 Offset: 0x21170F1 VA: 0x2116FF0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, bool>>
	|
	|-RVA: 0x2117050 Offset: 0x2117151 VA: 0x2117050
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, byte>>
	|
	|-RVA: 0x21170B0 Offset: 0x21171B1 VA: 0x21170B0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, int>>
	|
	|-RVA: 0x2117110 Offset: 0x2117211 VA: 0x2117110
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, Int32Enum>>
	|
	|-RVA: 0x2117170 Offset: 0x2117271 VA: 0x2117170
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, IntPtr>>
	|
	|-RVA: 0x21171D0 Offset: 0x21172D1 VA: 0x21171D0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, object>>
	|
	|-RVA: 0x2117230 Offset: 0x2117331 VA: 0x2117230
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, Playable>>
	|
	|-RVA: 0x2117290 Offset: 0x2117391 VA: 0x2117290
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, ResourceLocator>>
	|
	|-RVA: 0x21172F0 Offset: 0x21173F1 VA: 0x21172F0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, float>>
	|
	|-RVA: 0x2117350 Offset: 0x2117451 VA: 0x2117350
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, ushort>>
	|
	|-RVA: 0x21173B0 Offset: 0x21174B1 VA: 0x21173B0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<object, GameVariable.Value>>
	|
	|-RVA: 0x2117410 Offset: 0x2117511 VA: 0x2117410
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<sbyte, DataStoreRatingInfo>>
	|
	|-RVA: 0x2117470 Offset: 0x2117571 VA: 0x2117470
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<sbyte, object>>
	|
	|-RVA: 0x21174D0 Offset: 0x21175D1 VA: 0x21174D0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<ushort, int>>
	|
	|-RVA: 0x2117530 Offset: 0x2117631 VA: 0x2117530
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<uint, int>>
	|
	|-RVA: 0x2117590 Offset: 0x2117691 VA: 0x2117590
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<uint, object>>
	|
	|-RVA: 0x21175F0 Offset: 0x21176F1 VA: 0x21175F0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<ulong, Friend>>
	|
	|-RVA: 0x2117650 Offset: 0x2117751 VA: 0x2117650
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<ulong, Int32Enum>>
	|
	|-RVA: 0x21176B0 Offset: 0x21177B1 VA: 0x21176B0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<ulong, object>>
	|
	|-RVA: 0x2117710 Offset: 0x2117811 VA: 0x2117710
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<Vector3, int>>
	|
	|-RVA: 0x2117770 Offset: 0x2117871 VA: 0x2117770
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<XPathNodeRef, XPathNodeRef>>
	|
	|-RVA: 0x21177D0 Offset: 0x21178D1 VA: 0x21177D0
	|-Array.InternalArray__ICollection_Add<Dictionary.Entry<TerrainUtility.TerrainMap.TileCoord, object>>
	|
	|-RVA: 0x2117830 Offset: 0x2117931 VA: 0x2117830
	|-Array.InternalArray__ICollection_Add<PriorityQueue.IndexedItem<object>>
	|
	|-RVA: 0x2117890 Offset: 0x2117991 VA: 0x2117890
	|-Array.InternalArray__ICollection_Add<KeyValuePair<ValueTuple<object, int>, object>>
	|
	|-RVA: 0x21178F0 Offset: 0x21179F1 VA: 0x21178F0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<byte, object>>
	|
	|-RVA: 0x2117950 Offset: 0x2117A51 VA: 0x2117950
	|-Array.InternalArray__ICollection_Add<KeyValuePair<CancellationToken, object>>
	|
	|-RVA: 0x21179B0 Offset: 0x2117AB1 VA: 0x21179B0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<char, object>>
	|
	|-RVA: 0x2117A10 Offset: 0x2117B11 VA: 0x2117A10
	|-Array.InternalArray__ICollection_Add<KeyValuePair<DateTime, object>>
	|
	|-RVA: 0x2117A70 Offset: 0x2117B71 VA: 0x2117A70
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Guid, object>>
	|
	|-RVA: 0x2117AD0 Offset: 0x2117BD1 VA: 0x2117AD0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<int, bool>>
	|
	|-RVA: 0x2117B30 Offset: 0x2117C31 VA: 0x2117B30
	|-Array.InternalArray__ICollection_Add<KeyValuePair<int, byte>>
	|
	|-RVA: 0x2117B90 Offset: 0x2117C91 VA: 0x2117B90
	|-Array.InternalArray__ICollection_Add<KeyValuePair<int, char>>
	|
	|-RVA: 0x2117BF0 Offset: 0x2117CF1 VA: 0x2117BF0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<int, DiagnosticEvent>>
	|
	|-RVA: 0x2117C50 Offset: 0x2117D51 VA: 0x2117C50
	|-Array.InternalArray__ICollection_Add<KeyValuePair<int, int>>
	|
	|-RVA: 0x2117CB0 Offset: 0x2117DB1 VA: 0x2117CB0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<int, Int32Enum>>
	|
	|-RVA: 0x2117D10 Offset: 0x2117E11 VA: 0x2117D10
	|-Array.InternalArray__ICollection_Add<KeyValuePair<int, long>>
	|
	|-RVA: 0x2117D70 Offset: 0x2117E71 VA: 0x2117D70
	|-Array.InternalArray__ICollection_Add<KeyValuePair<int, MapPos>>
	|
	|-RVA: 0x2117DD0 Offset: 0x2117ED1 VA: 0x2117DD0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<int, object>>
	|
	|-RVA: 0x2117E30 Offset: 0x2117F31 VA: 0x2117E30
	|-Array.InternalArray__ICollection_Add<KeyValuePair<int, uint>>
	|
	|-RVA: 0x2117E90 Offset: 0x2117F91 VA: 0x2117E90
	|-Array.InternalArray__ICollection_Add<KeyValuePair<int, AIThink.EnchantThink.SurroundingInfo>>
	|
	|-RVA: 0x2117EF0 Offset: 0x2117FF1 VA: 0x2117EF0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Int32Enum, bool>>
	|
	|-RVA: 0x2117F50 Offset: 0x2118051 VA: 0x2117F50
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Int32Enum, int>>
	|
	|-RVA: 0x2117FB0 Offset: 0x21180B1 VA: 0x2117FB0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Int32Enum, Int32Enum>>
	|
	|-RVA: 0x2118010 Offset: 0x2118111 VA: 0x2118010
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Int32Enum, object>>
	|
	|-RVA: 0x2118070 Offset: 0x2118171 VA: 0x2118070
	|-Array.InternalArray__ICollection_Add<KeyValuePair<long, object>>
	|
	|-RVA: 0x21180D0 Offset: 0x21181D1 VA: 0x21180D0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<MapPos, int>>
	|
	|-RVA: 0x2118130 Offset: 0x2118231 VA: 0x2118130
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, AsyncOperationHandle<object>>>
	|
	|-RVA: 0x2118190 Offset: 0x2118291 VA: 0x2118190
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, ValueTuple<int, DateTime, object>>>
	|
	|-RVA: 0x21181F0 Offset: 0x21182F1 VA: 0x21181F0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, AsyncOperationHandle>>
	|
	|-RVA: 0x2118250 Offset: 0x2118351 VA: 0x2118250
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, bool>>
	|
	|-RVA: 0x21182B0 Offset: 0x21183B1 VA: 0x21182B0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, byte>>
	|
	|-RVA: 0x2118310 Offset: 0x2118411 VA: 0x2118310
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, int>>
	|
	|-RVA: 0x2118370 Offset: 0x2118471 VA: 0x2118370
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, Int32Enum>>
	|
	|-RVA: 0x21183D0 Offset: 0x21184D1 VA: 0x21183D0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, IntPtr>>
	|
	|-RVA: 0x2118430 Offset: 0x2118531 VA: 0x2118430
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, object>>
	|
	|-RVA: 0x2118490 Offset: 0x2118591 VA: 0x2118490
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, Playable>>
	|
	|-RVA: 0x21184F0 Offset: 0x21185F1 VA: 0x21184F0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, ResourceLocator>>
	|
	|-RVA: 0x2118550 Offset: 0x2118651 VA: 0x2118550
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, float>>
	|
	|-RVA: 0x21185B0 Offset: 0x21186B1 VA: 0x21185B0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, ushort>>
	|
	|-RVA: 0x2118610 Offset: 0x2118711 VA: 0x2118610
	|-Array.InternalArray__ICollection_Add<KeyValuePair<object, GameVariable.Value>>
	|
	|-RVA: 0x2118670 Offset: 0x2118771 VA: 0x2118670
	|-Array.InternalArray__ICollection_Add<KeyValuePair<sbyte, DataStoreRatingInfo>>
	|
	|-RVA: 0x21186D0 Offset: 0x21187D1 VA: 0x21186D0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<sbyte, object>>
	|
	|-RVA: 0x2118730 Offset: 0x2118831 VA: 0x2118730
	|-Array.InternalArray__ICollection_Add<KeyValuePair<ushort, int>>
	|
	|-RVA: 0x2118790 Offset: 0x2118891 VA: 0x2118790
	|-Array.InternalArray__ICollection_Add<KeyValuePair<uint, int>>
	|
	|-RVA: 0x21187F0 Offset: 0x21188F1 VA: 0x21187F0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<uint, object>>
	|
	|-RVA: 0x2118850 Offset: 0x2118951 VA: 0x2118850
	|-Array.InternalArray__ICollection_Add<KeyValuePair<ulong, Friend>>
	|
	|-RVA: 0x21188B0 Offset: 0x21189B1 VA: 0x21188B0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<ulong, Int32Enum>>
	|
	|-RVA: 0x2118910 Offset: 0x2118A11 VA: 0x2118910
	|-Array.InternalArray__ICollection_Add<KeyValuePair<ulong, object>>
	|
	|-RVA: 0x2118970 Offset: 0x2118A71 VA: 0x2118970
	|-Array.InternalArray__ICollection_Add<KeyValuePair<Vector3, int>>
	|
	|-RVA: 0x21189D0 Offset: 0x2118AD1 VA: 0x21189D0
	|-Array.InternalArray__ICollection_Add<KeyValuePair<XPathNodeRef, XPathNodeRef>>
	|
	|-RVA: 0x2118A30 Offset: 0x2118B31 VA: 0x2118A30
	|-Array.InternalArray__ICollection_Add<KeyValuePair<TerrainUtility.TerrainMap.TileCoord, object>>
	|
	|-RVA: 0x2118A90 Offset: 0x2118B91 VA: 0x2118A90
	|-Array.InternalArray__ICollection_Add<NativeArray<PreTile>>
	|
	|-RVA: 0x2118AF0 Offset: 0x2118BF1 VA: 0x2118AF0
	|-Array.InternalArray__ICollection_Add<CommonBattleSequence.Reliance<object>>
	|
	|-RVA: 0x2118B50 Offset: 0x2118C51 VA: 0x2118B50
	|-Array.InternalArray__ICollection_Add<RenderGraphResourcePool.ResourceLogInfo<object>>
	|
	|-RVA: 0x2118BB0 Offset: 0x2118CB1 VA: 0x2118BB0
	|-Array.InternalArray__ICollection_Add<HashSet.Slot<ValueTuple<object, int>>>
	|
	|-RVA: 0x2118C10 Offset: 0x2118D11 VA: 0x2118C10
	|-Array.InternalArray__ICollection_Add<HashSet.Slot<AsyncOperationHandle>>
	|
	|-RVA: 0x2118C70 Offset: 0x2118D71 VA: 0x2118C70
	|-Array.InternalArray__ICollection_Add<HashSet.Slot<int>>
	|
	|-RVA: 0x2118CD0 Offset: 0x2118DD1 VA: 0x2118CD0
	|-Array.InternalArray__ICollection_Add<HashSet.Slot<Int32Enum>>
	|
	|-RVA: 0x2118D30 Offset: 0x2118E31 VA: 0x2118D30
	|-Array.InternalArray__ICollection_Add<Set.Slot<Int32Enum>>
	|
	|-RVA: 0x2118D90 Offset: 0x2118E91 VA: 0x2118D90
	|-Array.InternalArray__ICollection_Add<HashSet.Slot<MapPos>>
	|
	|-RVA: 0x2118DF0 Offset: 0x2118EF1 VA: 0x2118DF0
	|-Array.InternalArray__ICollection_Add<HashSet.Slot<object>>
	|
	|-RVA: 0x2118E50 Offset: 0x2118F51 VA: 0x2118E50
	|-Array.InternalArray__ICollection_Add<Set.Slot<object>>
	|
	|-RVA: 0x2118EB0 Offset: 0x2118FB1 VA: 0x2118EB0
	|-Array.InternalArray__ICollection_Add<HashSet.Slot<uint>>
	|
	|-RVA: 0x2118F10 Offset: 0x2119011 VA: 0x2118F10
	|-Array.InternalArray__ICollection_Add<HashSet.Slot<ulong>>
	|
	|-RVA: 0x2118F70 Offset: 0x2119071 VA: 0x2118F70
	|-Array.InternalArray__ICollection_Add<Set.Slot<Vector3>>
	|
	|-RVA: 0x2118FD0 Offset: 0x21190D1 VA: 0x2118FD0
	|-Array.InternalArray__ICollection_Add<TMP_TextProcessingStack<Color32>>
	|
	|-RVA: 0x2119030 Offset: 0x2119131 VA: 0x2119030
	|-Array.InternalArray__ICollection_Add<TMP_TextProcessingStack<HighlightState>>
	|
	|-RVA: 0x2119090 Offset: 0x2119191 VA: 0x2119090
	|-Array.InternalArray__ICollection_Add<TMP_TextProcessingStack<int>>
	|
	|-RVA: 0x21190F0 Offset: 0x21191F1 VA: 0x21190F0
	|-Array.InternalArray__ICollection_Add<TMP_TextProcessingStack<Int32Enum>>
	|
	|-RVA: 0x2119150 Offset: 0x2119251 VA: 0x2119150
	|-Array.InternalArray__ICollection_Add<TMP_TextProcessingStack<MaterialReference>>
	|
	|-RVA: 0x21191B0 Offset: 0x21192B1 VA: 0x21191B0
	|-Array.InternalArray__ICollection_Add<TMP_TextProcessingStack<object>>
	|
	|-RVA: 0x2119210 Offset: 0x2119311 VA: 0x2119210
	|-Array.InternalArray__ICollection_Add<TMP_TextProcessingStack<float>>
	|
	|-RVA: 0x2119270 Offset: 0x2119371 VA: 0x2119270
	|-Array.InternalArray__ICollection_Add<TMP_TextProcessingStack<WordWrapState>>
	|
	|-RVA: 0x21192D0 Offset: 0x21193D1 VA: 0x21192D0
	|-Array.InternalArray__ICollection_Add<TimeInterval<object>>
	|
	|-RVA: 0x2119330 Offset: 0x2119431 VA: 0x2119330
	|-Array.InternalArray__ICollection_Add<Timestamped<object>>
	|
	|-RVA: 0x2119390 Offset: 0x2119491 VA: 0x2119390
	|-Array.InternalArray__ICollection_Add<UniTask<object>>
	|
	|-RVA: 0x21193F0 Offset: 0x21194F1 VA: 0x21193F0
	|-Array.InternalArray__ICollection_Add<ValueTuple<ValueTuple<bool, object>>>
	|
	|-RVA: 0x2119450 Offset: 0x2119551 VA: 0x2119450
	|-Array.InternalArray__ICollection_Add<ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>
	|
	|-RVA: 0x21194B0 Offset: 0x21195B1 VA: 0x21194B0
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, UniTask<object>>>
	|
	|-RVA: 0x2119510 Offset: 0x2119611 VA: 0x2119510
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>
	|
	|-RVA: 0x2119570 Offset: 0x2119671 VA: 0x2119570
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>
	|
	|-RVA: 0x21195D0 Offset: 0x21196D1 VA: 0x21195D0
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>
	|
	|-RVA: 0x2119630 Offset: 0x2119731 VA: 0x2119630
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>
	|
	|-RVA: 0x2119690 Offset: 0x2119791 VA: 0x2119690
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>
	|
	|-RVA: 0x21196F0 Offset: 0x21197F1 VA: 0x21196F0
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>
	|
	|-RVA: 0x2119750 Offset: 0x2119851 VA: 0x2119750
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>
	|
	|-RVA: 0x21197B0 Offset: 0x21198B1 VA: 0x21197B0
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>
	|
	|-RVA: 0x2119810 Offset: 0x2119911 VA: 0x2119810
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>
	|
	|-RVA: 0x2119870 Offset: 0x2119971 VA: 0x2119870
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>
	|
	|-RVA: 0x21198D0 Offset: 0x21199D1 VA: 0x21198D0
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>
	|
	|-RVA: 0x2119930 Offset: 0x2119A31 VA: 0x2119930
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x2119990 Offset: 0x2119A91 VA: 0x2119990
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>
	|
	|-RVA: 0x21199F0 Offset: 0x2119AF1 VA: 0x21199F0
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>
	|
	|-RVA: 0x2119A50 Offset: 0x2119B51 VA: 0x2119A50
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>
	|
	|-RVA: 0x2119AB0 Offset: 0x2119BB1 VA: 0x2119AB0
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>
	|
	|-RVA: 0x2119B10 Offset: 0x2119C11 VA: 0x2119B10
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>
	|
	|-RVA: 0x2119B70 Offset: 0x2119C71 VA: 0x2119B70
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>
	|
	|-RVA: 0x2119BD0 Offset: 0x2119CD1 VA: 0x2119BD0
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>
	|
	|-RVA: 0x2119C30 Offset: 0x2119D31 VA: 0x2119C30
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>
	|
	|-RVA: 0x2119C90 Offset: 0x2119D91 VA: 0x2119C90
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>
	|
	|-RVA: 0x2119CF0 Offset: 0x2119DF1 VA: 0x2119CF0
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>
	|
	|-RVA: 0x2119D50 Offset: 0x2119E51 VA: 0x2119D50
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>
	|
	|-RVA: 0x2119DB0 Offset: 0x2119EB1 VA: 0x2119DB0
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>
	|
	|-RVA: 0x2119E10 Offset: 0x2119F11 VA: 0x2119E10
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>
	|
	|-RVA: 0x2119E70 Offset: 0x2119F71 VA: 0x2119E70
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>
	|
	|-RVA: 0x2119ED0 Offset: 0x2119FD1 VA: 0x2119ED0
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>
	|
	|-RVA: 0x2119F30 Offset: 0x211A031 VA: 0x2119F30
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>
	|
	|-RVA: 0x2119F90 Offset: 0x211A091 VA: 0x2119F90
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>
	|
	|-RVA: 0x2119FF0 Offset: 0x211A0F1 VA: 0x2119FF0
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>
	|
	|-RVA: 0x211A050 Offset: 0x211A151 VA: 0x211A050
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>
	|
	|-RVA: 0x211A0B0 Offset: 0x211A1B1 VA: 0x211A0B0
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>
	|
	|-RVA: 0x211A110 Offset: 0x211A211 VA: 0x211A110
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>
	|
	|-RVA: 0x211A170 Offset: 0x211A271 VA: 0x211A170
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>
	|
	|-RVA: 0x211A1D0 Offset: 0x211A2D1 VA: 0x211A1D0
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>
	|
	|-RVA: 0x211A230 Offset: 0x211A331 VA: 0x211A230
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x211A290 Offset: 0x211A391 VA: 0x211A290
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>
	|
	|-RVA: 0x211A2F0 Offset: 0x211A3F1 VA: 0x211A2F0
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>
	|
	|-RVA: 0x211A350 Offset: 0x211A451 VA: 0x211A350
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>
	|
	|-RVA: 0x211A3B0 Offset: 0x211A4B1 VA: 0x211A3B0
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>
	|
	|-RVA: 0x211A410 Offset: 0x211A511 VA: 0x211A410
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>
	|
	|-RVA: 0x211A470 Offset: 0x211A571 VA: 0x211A470
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>
	|
	|-RVA: 0x211A4D0 Offset: 0x211A5D1 VA: 0x211A4D0
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>
	|
	|-RVA: 0x211A530 Offset: 0x211A631 VA: 0x211A530
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>
	|
	|-RVA: 0x211A590 Offset: 0x211A691 VA: 0x211A590
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>
	|
	|-RVA: 0x211A5F0 Offset: 0x211A6F1 VA: 0x211A5F0
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>
	|
	|-RVA: 0x211A650 Offset: 0x211A751 VA: 0x211A650
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x211A6B0 Offset: 0x211A7B1 VA: 0x211A6B0
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>
	|
	|-RVA: 0x211A710 Offset: 0x211A811 VA: 0x211A710
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x211A770 Offset: 0x211A871 VA: 0x211A770
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>
	|
	|-RVA: 0x211A7D0 Offset: 0x211A8D1 VA: 0x211A7D0
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x211A830 Offset: 0x211A931 VA: 0x211A830
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>
	|
	|-RVA: 0x211A890 Offset: 0x211A991 VA: 0x211A890
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x211A8F0 Offset: 0x211A9F1 VA: 0x211A8F0
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>
	|
	|-RVA: 0x211A950 Offset: 0x211AA51 VA: 0x211A950
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x211A9B0 Offset: 0x211AAB1 VA: 0x211A9B0
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>
	|
	|-RVA: 0x211AA10 Offset: 0x211AB11 VA: 0x211AA10
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>
	|
	|-RVA: 0x211AA70 Offset: 0x211AB71 VA: 0x211AA70
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>
	|
	|-RVA: 0x211AAD0 Offset: 0x211ABD1 VA: 0x211AAD0
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>
	|
	|-RVA: 0x211AB30 Offset: 0x211AC31 VA: 0x211AB30
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>
	|
	|-RVA: 0x211AB90 Offset: 0x211AC91 VA: 0x211AB90
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>
	|
	|-RVA: 0x211ABF0 Offset: 0x211ACF1 VA: 0x211ABF0
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>
	|
	|-RVA: 0x211AC50 Offset: 0x211AD51 VA: 0x211AC50
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>
	|
	|-RVA: 0x211ACB0 Offset: 0x211ADB1 VA: 0x211ACB0
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>
	|
	|-RVA: 0x211AD10 Offset: 0x211AE11 VA: 0x211AD10
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x211AD70 Offset: 0x211AE71 VA: 0x211AD70
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>
	|
	|-RVA: 0x211ADD0 Offset: 0x211AED1 VA: 0x211ADD0
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>
	|
	|-RVA: 0x211AE30 Offset: 0x211AF31 VA: 0x211AE30
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>
	|
	|-RVA: 0x211AE90 Offset: 0x211AF91 VA: 0x211AE90
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>
	|
	|-RVA: 0x211AEF0 Offset: 0x211AFF1 VA: 0x211AEF0
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>
	|
	|-RVA: 0x211AF50 Offset: 0x211B051 VA: 0x211AF50
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>
	|
	|-RVA: 0x211AFB0 Offset: 0x211B0B1 VA: 0x211AFB0
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>
	|
	|-RVA: 0x211B010 Offset: 0x211B111 VA: 0x211B010
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>
	|
	|-RVA: 0x211B070 Offset: 0x211B171 VA: 0x211B070
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>
	|
	|-RVA: 0x211B0D0 Offset: 0x211B1D1 VA: 0x211B0D0
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>
	|
	|-RVA: 0x211B130 Offset: 0x211B231 VA: 0x211B130
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x211B190 Offset: 0x211B291 VA: 0x211B190
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>
	|
	|-RVA: 0x211B1F0 Offset: 0x211B2F1 VA: 0x211B1F0
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x211B250 Offset: 0x211B351 VA: 0x211B250
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>
	|
	|-RVA: 0x211B2B0 Offset: 0x211B3B1 VA: 0x211B2B0
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x211B310 Offset: 0x211B411 VA: 0x211B310
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>
	|
	|-RVA: 0x211B370 Offset: 0x211B471 VA: 0x211B370
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x211B3D0 Offset: 0x211B4D1 VA: 0x211B3D0
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>
	|
	|-RVA: 0x211B430 Offset: 0x211B531 VA: 0x211B430
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x211B490 Offset: 0x211B591 VA: 0x211B490
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>
	|
	|-RVA: 0x211B4F0 Offset: 0x211B5F1 VA: 0x211B4F0
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x211B550 Offset: 0x211B651 VA: 0x211B550
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x211B5B0 Offset: 0x211B6B1 VA: 0x211B5B0
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>
	|
	|-RVA: 0x211B610 Offset: 0x211B711 VA: 0x211B610
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, bool>>>
	|
	|-RVA: 0x211B670 Offset: 0x211B771 VA: 0x211B670
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, Bounds>>>
	|
	|-RVA: 0x211B6D0 Offset: 0x211B7D1 VA: 0x211B6D0
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, byte>>>
	|
	|-RVA: 0x211B730 Offset: 0x211B831 VA: 0x211B730
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, Color>>>
	|
	|-RVA: 0x211B790 Offset: 0x211B891 VA: 0x211B790
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, double>>>
	|
	|-RVA: 0x211B7F0 Offset: 0x211B8F1 VA: 0x211B7F0
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, int>>>
	|
	|-RVA: 0x211B850 Offset: 0x211B951 VA: 0x211B850
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, long>>>
	|
	|-RVA: 0x211B8B0 Offset: 0x211B9B1 VA: 0x211B8B0
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, object>>>
	|
	|-RVA: 0x211B910 Offset: 0x211BA11 VA: 0x211B910
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, Quaternion>>>
	|
	|-RVA: 0x211B970 Offset: 0x211BA71 VA: 0x211B970
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, Rect>>>
	|
	|-RVA: 0x211B9D0 Offset: 0x211BAD1 VA: 0x211B9D0
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, float>>>
	|
	|-RVA: 0x211BA30 Offset: 0x211BB31 VA: 0x211BA30
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, UniTask>>>
	|
	|-RVA: 0x211BA90 Offset: 0x211BB91 VA: 0x211BA90
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, Unit>>>
	|
	|-RVA: 0x211BAF0 Offset: 0x211BBF1 VA: 0x211BAF0
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, Vector2>>>
	|
	|-RVA: 0x211BB50 Offset: 0x211BC51 VA: 0x211BB50
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, Vector3>>>
	|
	|-RVA: 0x211BBB0 Offset: 0x211BCB1 VA: 0x211BBB0
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<bool, Vector4>>>
	|
	|-RVA: 0x211BC10 Offset: 0x211BD11 VA: 0x211BC10
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<int, object>>>
	|
	|-RVA: 0x211BC70 Offset: 0x211BD71 VA: 0x211BC70
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<object, object>>>
	|
	|-RVA: 0x211BCD0 Offset: 0x211BDD1 VA: 0x211BCD0
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x211BD30 Offset: 0x211BE31 VA: 0x211BD30
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<object, object, object>>>
	|
	|-RVA: 0x211BD90 Offset: 0x211BE91 VA: 0x211BD90
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x211BDF0 Offset: 0x211BEF1 VA: 0x211BDF0
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<object, object, object, object>>>
	|
	|-RVA: 0x211BE50 Offset: 0x211BF51 VA: 0x211BE50
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x211BEB0 Offset: 0x211BFB1 VA: 0x211BEB0
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>
	|
	|-RVA: 0x211BF10 Offset: 0x211C011 VA: 0x211BF10
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x211BF70 Offset: 0x211C071 VA: 0x211BF70
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>
	|
	|-RVA: 0x211BFD0 Offset: 0x211C0D1 VA: 0x211BFD0
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x211C030 Offset: 0x211C131 VA: 0x211C030
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>
	|
	|-RVA: 0x211C090 Offset: 0x211C191 VA: 0x211C090
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x211C0F0 Offset: 0x211C1F1 VA: 0x211C0F0
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x211C150 Offset: 0x211C251 VA: 0x211C150
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, AsyncUnit>>
	|
	|-RVA: 0x211C1B0 Offset: 0x211C2B1 VA: 0x211C1B0
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, bool>>
	|
	|-RVA: 0x211C210 Offset: 0x211C311 VA: 0x211C210
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, Bounds>>
	|
	|-RVA: 0x211C270 Offset: 0x211C371 VA: 0x211C270
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, byte>>
	|
	|-RVA: 0x211C2D0 Offset: 0x211C3D1 VA: 0x211C2D0
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, Color>>
	|
	|-RVA: 0x211C330 Offset: 0x211C431 VA: 0x211C330
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, double>>
	|
	|-RVA: 0x211C390 Offset: 0x211C491 VA: 0x211C390
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, int>>
	|
	|-RVA: 0x211C3F0 Offset: 0x211C4F1 VA: 0x211C3F0
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, long>>
	|
	|-RVA: 0x211C450 Offset: 0x211C551 VA: 0x211C450
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, object>>
	|
	|-RVA: 0x211C4B0 Offset: 0x211C5B1 VA: 0x211C4B0
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, Quaternion>>
	|
	|-RVA: 0x211C510 Offset: 0x211C611 VA: 0x211C510
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, Rect>>
	|
	|-RVA: 0x211C570 Offset: 0x211C671 VA: 0x211C570
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, float>>
	|
	|-RVA: 0x211C5D0 Offset: 0x211C6D1 VA: 0x211C5D0
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, UniTask>>
	|
	|-RVA: 0x211C630 Offset: 0x211C731 VA: 0x211C630
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, Unit>>
	|
	|-RVA: 0x211C690 Offset: 0x211C791 VA: 0x211C690
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, Vector2>>
	|
	|-RVA: 0x211C6F0 Offset: 0x211C7F1 VA: 0x211C6F0
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, Vector3>>
	|
	|-RVA: 0x211C750 Offset: 0x211C851 VA: 0x211C750
	|-Array.InternalArray__ICollection_Add<ValueTuple<bool, Vector4>>
	|
	|-RVA: 0x211C7B0 Offset: 0x211C8B1 VA: 0x211C7B0
	|-Array.InternalArray__ICollection_Add<ValueTuple<int, bool>>
	|
	|-RVA: 0x211C810 Offset: 0x211C911 VA: 0x211C810
	|-Array.InternalArray__ICollection_Add<ValueTuple<int, Bounds>>
	|
	|-RVA: 0x211C870 Offset: 0x211C971 VA: 0x211C870
	|-Array.InternalArray__ICollection_Add<ValueTuple<int, byte>>
	|
	|-RVA: 0x211C8D0 Offset: 0x211C9D1 VA: 0x211C8D0
	|-Array.InternalArray__ICollection_Add<ValueTuple<int, Color>>
	|
	|-RVA: 0x211C930 Offset: 0x211CA31 VA: 0x211C930
	|-Array.InternalArray__ICollection_Add<ValueTuple<int, double>>
	|
	|-RVA: 0x211C990 Offset: 0x211CA91 VA: 0x211C990
	|-Array.InternalArray__ICollection_Add<ValueTuple<int, int>>
	|
	|-RVA: 0x211C9F0 Offset: 0x211CAF1 VA: 0x211C9F0
	|-Array.InternalArray__ICollection_Add<ValueTuple<int, long>>
	|
	|-RVA: 0x211CA50 Offset: 0x211CB51 VA: 0x211CA50
	|-Array.InternalArray__ICollection_Add<ValueTuple<int, object>>
	|
	|-RVA: 0x211CAB0 Offset: 0x211CBB1 VA: 0x211CAB0
	|-Array.InternalArray__ICollection_Add<ValueTuple<int, Quaternion>>
	|
	|-RVA: 0x211CB10 Offset: 0x211CC11 VA: 0x211CB10
	|-Array.InternalArray__ICollection_Add<ValueTuple<int, Rect>>
	|
	|-RVA: 0x211CB70 Offset: 0x211CC71 VA: 0x211CB70
	|-Array.InternalArray__ICollection_Add<ValueTuple<int, float>>
	|
	|-RVA: 0x211CBD0 Offset: 0x211CCD1 VA: 0x211CBD0
	|-Array.InternalArray__ICollection_Add<ValueTuple<int, Unit>>
	|
	|-RVA: 0x211CC30 Offset: 0x211CD31 VA: 0x211CC30
	|-Array.InternalArray__ICollection_Add<ValueTuple<int, Vector2>>
	|
	|-RVA: 0x211CC90 Offset: 0x211CD91 VA: 0x211CC90
	|-Array.InternalArray__ICollection_Add<ValueTuple<int, Vector3>>
	|
	|-RVA: 0x211CCF0 Offset: 0x211CDF1 VA: 0x211CCF0
	|-Array.InternalArray__ICollection_Add<ValueTuple<int, Vector4>>
	|
	|-RVA: 0x211CD50 Offset: 0x211CE51 VA: 0x211CD50
	|-Array.InternalArray__ICollection_Add<ValueTuple<Int32Enum, int>>
	|
	|-RVA: 0x211CDB0 Offset: 0x211CEB1 VA: 0x211CDB0
	|-Array.InternalArray__ICollection_Add<ValueTuple<object, ValueTuple<object, int>>>
	|
	|-RVA: 0x211CE10 Offset: 0x211CF11 VA: 0x211CE10
	|-Array.InternalArray__ICollection_Add<ValueTuple<object, int>>
	|
	|-RVA: 0x211CE70 Offset: 0x211CF71 VA: 0x211CE70
	|-Array.InternalArray__ICollection_Add<ValueTuple<object, object>>
	|
	|-RVA: 0x211CED0 Offset: 0x211CFD1 VA: 0x211CED0
	|-Array.InternalArray__ICollection_Add<ValueTuple<object, float>>
	|
	|-RVA: 0x211CF30 Offset: 0x211D031 VA: 0x211CF30
	|-Array.InternalArray__ICollection_Add<ValueTuple<Vector3, float>>
	|
	|-RVA: 0x211CF90 Offset: 0x211D091 VA: 0x211CF90
	|-Array.InternalArray__ICollection_Add<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>
	|
	|-RVA: 0x211CFF0 Offset: 0x211D0F1 VA: 0x211CFF0
	|-Array.InternalArray__ICollection_Add<ValueTuple<object, Int32Enum, int>>
	|
	|-RVA: 0x211D050 Offset: 0x211D151 VA: 0x211D050
	|-Array.InternalArray__ICollection_Add<ValueTuple<object, object, object>>
	|
	|-RVA: 0x211D0B0 Offset: 0x211D1B1 VA: 0x211D0B0
	|-Array.InternalArray__ICollection_Add<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>
	|
	|-RVA: 0x211D110 Offset: 0x211D211 VA: 0x211D110
	|-Array.InternalArray__ICollection_Add<ValueTuple<object, int, int, int>>
	|
	|-RVA: 0x211D170 Offset: 0x211D271 VA: 0x211D170
	|-Array.InternalArray__ICollection_Add<ValueTuple<object, object, object, object>>
	|
	|-RVA: 0x211D1D0 Offset: 0x211D2D1 VA: 0x211D1D0
	|-Array.InternalArray__ICollection_Add<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>
	|
	|-RVA: 0x211D230 Offset: 0x211D331 VA: 0x211D230
	|-Array.InternalArray__ICollection_Add<ValueTuple<object, object, object, object, object>>
	|
	|-RVA: 0x211D290 Offset: 0x211D391 VA: 0x211D290
	|-Array.InternalArray__ICollection_Add<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>
	|
	|-RVA: 0x211D2F0 Offset: 0x211D3F1 VA: 0x211D2F0
	|-Array.InternalArray__ICollection_Add<ValueTuple<object, object, object, object, object, object>>
	|
	|-RVA: 0x211D350 Offset: 0x211D451 VA: 0x211D350
	|-Array.InternalArray__ICollection_Add<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>
	|
	|-RVA: 0x211D3B0 Offset: 0x211D4B1 VA: 0x211D3B0
	|-Array.InternalArray__ICollection_Add<ValueTuple<object, object, object, object, object, object, object>>
	|
	|-RVA: 0x211D410 Offset: 0x211D511 VA: 0x211D410
	|-Array.InternalArray__ICollection_Add<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>
	|
	|-RVA: 0x211D470 Offset: 0x211D571 VA: 0x211D470
	|-Array.InternalArray__ICollection_Add<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x211D4D0 Offset: 0x211D5D1 VA: 0x211D4D0
	|-Array.InternalArray__ICollection_Add<AnimatorClipInfo>
	|
	|-RVA: 0x211D530 Offset: 0x211D631 VA: 0x211D530
	|-Array.InternalArray__ICollection_Add<AsyncOperationHandle>
	|
	|-RVA: 0x211D590 Offset: 0x211D691 VA: 0x211D590
	|-Array.InternalArray__ICollection_Add<AsyncUnit>
	|
	|-RVA: 0x211D5F0 Offset: 0x211D6F1 VA: 0x211D5F0
	|-Array.InternalArray__ICollection_Add<BatchVisibility>
	|
	|-RVA: 0x211D650 Offset: 0x211D751 VA: 0x211D650
	|-Array.InternalArray__ICollection_Add<BoneWeight>
	|
	|-RVA: 0x211D6B0 Offset: 0x211D7B1 VA: 0x211D6B0
	|-Array.InternalArray__ICollection_Add<BoneWeight1>
	|
	|-RVA: 0x211D710 Offset: 0x211D811 VA: 0x211D710
	|-Array.InternalArray__ICollection_Add<bool>
	|
	|-RVA: 0x211D770 Offset: 0x211D871 VA: 0x211D770
	|-Array.InternalArray__ICollection_Add<Bounds>
	|
	|-RVA: 0x211D7D0 Offset: 0x211D8D1 VA: 0x211D7D0
	|-Array.InternalArray__ICollection_Add<byte>
	|
	|-RVA: 0x211D830 Offset: 0x211D931 VA: 0x211D830
	|-Array.InternalArray__ICollection_Add<ByteEnum>
	|
	|-RVA: 0x211D890 Offset: 0x211D991 VA: 0x211D890
	|-Array.InternalArray__ICollection_Add<CameraInfo>
	|
	|-RVA: 0x211D8F0 Offset: 0x211D9F1 VA: 0x211D8F0
	|-Array.InternalArray__ICollection_Add<CancellationToken>
	|
	|-RVA: 0x211D950 Offset: 0x211DA51 VA: 0x211D950
	|-Array.InternalArray__ICollection_Add<CancellationTokenRegistration>
	|
	|-RVA: 0x211D9B0 Offset: 0x211DAB1 VA: 0x211D9B0
	|-Array.InternalArray__ICollection_Add<char>
	|
	|-RVA: 0x211DA10 Offset: 0x211DB11 VA: 0x211DA10
	|-Array.InternalArray__ICollection_Add<ClusteringData>
	|
	|-RVA: 0x211DA70 Offset: 0x211DB71 VA: 0x211DA70
	|-Array.InternalArray__ICollection_Add<ClusteringProcessorState>
	|
	|-RVA: 0x211DAD0 Offset: 0x211DBD1 VA: 0x211DAD0
	|-Array.InternalArray__ICollection_Add<Color>
	|
	|-RVA: 0x211DB30 Offset: 0x211DC31 VA: 0x211DB30
	|-Array.InternalArray__ICollection_Add<Color32>
	|
	|-RVA: 0x211DB90 Offset: 0x211DC91 VA: 0x211DB90
	|-Array.InternalArray__ICollection_Add<Color4u8>
	|
	|-RVA: 0x211DBF0 Offset: 0x211DCF1 VA: 0x211DBF0
	|-Array.InternalArray__ICollection_Add<ColorBlock>
	|
	|-RVA: 0x211DC50 Offset: 0x211DD51 VA: 0x211DC50
	|-Array.InternalArray__ICollection_Add<CombineInstance>
	|
	|-RVA: 0x211DCB0 Offset: 0x211DDB1 VA: 0x211DCB0
	|-Array.InternalArray__ICollection_Add<ConstraintSource>
	|
	|-RVA: 0x211DD10 Offset: 0x211DE11 VA: 0x211DD10
	|-Array.InternalArray__ICollection_Add<ContactPoint>
	|
	|-RVA: 0x211DD70 Offset: 0x211DE71 VA: 0x211DD70
	|-Array.InternalArray__ICollection_Add<ContactPoint2D>
	|
	|-RVA: 0x211DDD0 Offset: 0x211DED1 VA: 0x211DDD0
	|-Array.InternalArray__ICollection_Add<ContourVertex>
	|
	|-RVA: 0x211DE30 Offset: 0x211DF31 VA: 0x211DE30
	|-Array.InternalArray__ICollection_Add<CustomAttributeNamedArgument>
	|
	|-RVA: 0x211DE90 Offset: 0x211DF91 VA: 0x211DE90
	|-Array.InternalArray__ICollection_Add<CustomAttributeTypedArgument>
	|
	|-RVA: 0x211DEF0 Offset: 0x211DFF1 VA: 0x211DEF0
	|-Array.InternalArray__ICollection_Add<DataStoreRatingInfo>
	|
	|-RVA: 0x211DF50 Offset: 0x211E051 VA: 0x211DF50
	|-Array.InternalArray__ICollection_Add<DataStoreResult>
	|
	|-RVA: 0x211DFB0 Offset: 0x211E0B1 VA: 0x211DFB0
	|-Array.InternalArray__ICollection_Add<DateTime>
	|
	|-RVA: 0x211E010 Offset: 0x211E111 VA: 0x211E010
	|-Array.InternalArray__ICollection_Add<DateTimeOffset>
	|
	|-RVA: 0x211E070 Offset: 0x211E171 VA: 0x211E070
	|-Array.InternalArray__ICollection_Add<DebugPadState>
	|
	|-RVA: 0x211E0D0 Offset: 0x211E1D1 VA: 0x211E0D0
	|-Array.InternalArray__ICollection_Add<Decimal>
	|
	|-RVA: 0x211E130 Offset: 0x211E231 VA: 0x211E130
	|-Array.InternalArray__ICollection_Add<DeferredTiler>
	|
	|-RVA: 0x211E190 Offset: 0x211E291 VA: 0x211E190
	|-Array.InternalArray__ICollection_Add<DeviceHandle>
	|
	|-RVA: 0x211E1F0 Offset: 0x211E2F1 VA: 0x211E1F0
	|-Array.InternalArray__ICollection_Add<DiagnosticEvent>
	|
	|-RVA: 0x211E250 Offset: 0x211E351 VA: 0x211E250
	|-Array.InternalArray__ICollection_Add<DictionaryEntry>
	|
	|-RVA: 0x211E2B0 Offset: 0x211E3B1 VA: 0x211E2B0
	|-Array.InternalArray__ICollection_Add<DictionaryInfo>
	|
	|-RVA: 0x211E310 Offset: 0x211E411 VA: 0x211E310
	|-Array.InternalArray__ICollection_Add<DirectoryEntry>
	|
	|-RVA: 0x211E370 Offset: 0x211E471 VA: 0x211E370
	|-Array.InternalArray__ICollection_Add<double>
	|
	|-RVA: 0x211E3D0 Offset: 0x211E4D1 VA: 0x211E3D0
	|-Array.InternalArray__ICollection_Add<Ephemeron>
	|
	|-RVA: 0x211E430 Offset: 0x211E531 VA: 0x211E430
	|-Array.InternalArray__ICollection_Add<FXZ>
	|
	|-RVA: 0x211E490 Offset: 0x211E591 VA: 0x211E490
	|-Array.InternalArray__ICollection_Add<Finger>
	|
	|-RVA: 0x211E4F0 Offset: 0x211E5F1 VA: 0x211E4F0
	|-Array.InternalArray__ICollection_Add<Float2>
	|
	|-RVA: 0x211E550 Offset: 0x211E651 VA: 0x211E550
	|-Array.InternalArray__ICollection_Add<Friend>
	|
	|-RVA: 0x211E5B0 Offset: 0x211E6B1 VA: 0x211E5B0
	|-Array.InternalArray__ICollection_Add<GCHandle>
	|
	|-RVA: 0x211E610 Offset: 0x211E711 VA: 0x211E610
	|-Array.InternalArray__ICollection_Add<GesturePoint>
	|
	|-RVA: 0x211E670 Offset: 0x211E771 VA: 0x211E670
	|-Array.InternalArray__ICollection_Add<GestureState>
	|
	|-RVA: 0x211E6D0 Offset: 0x211E7D1 VA: 0x211E6D0
	|-Array.InternalArray__ICollection_Add<GlyphMarshallingStruct>
	|
	|-RVA: 0x211E730 Offset: 0x211E831 VA: 0x211E730
	|-Array.InternalArray__ICollection_Add<GlyphPairAdjustmentRecord>
	|
	|-RVA: 0x211E790 Offset: 0x211E891 VA: 0x211E790
	|-Array.InternalArray__ICollection_Add<GlyphRect>
	|
	|-RVA: 0x211E7F0 Offset: 0x211E8F1 VA: 0x211E7F0
	|-Array.InternalArray__ICollection_Add<Guid>
	|
	|-RVA: 0x211E850 Offset: 0x211E951 VA: 0x211E850
	|-Array.InternalArray__ICollection_Add<Hand>
	|
	|-RVA: 0x211E8B0 Offset: 0x211E9B1 VA: 0x211E8B0
	|-Array.InternalArray__ICollection_Add<HandAnalysisImageState>
	|
	|-RVA: 0x211E910 Offset: 0x211EA11 VA: 0x211E910
	|-Array.InternalArray__ICollection_Add<HandAnalysisSilhouetteState>
	|
	|-RVA: 0x211E970 Offset: 0x211EA71 VA: 0x211E970
	|-Array.InternalArray__ICollection_Add<HeaderVariantInfo>
	|
	|-RVA: 0x211E9D0 Offset: 0x211EAD1 VA: 0x211E9D0
	|-Array.InternalArray__ICollection_Add<HighlightState>
	|
	|-RVA: 0x211EA30 Offset: 0x211EB31 VA: 0x211EA30
	|-Array.InternalArray__ICollection_Add<HumanBone>
	|
	|-RVA: 0x211EA90 Offset: 0x211EB91 VA: 0x211EA90
	|-Array.InternalArray__ICollection_Add<short>
	|
	|-RVA: 0x211EAF0 Offset: 0x211EBF1 VA: 0x211EAF0
	|-Array.InternalArray__ICollection_Add<int>
	|
	|-RVA: 0x211EB50 Offset: 0x211EC51 VA: 0x211EB50
	|-Array.InternalArray__ICollection_Add<Int32Enum>
	|
	|-RVA: 0x211EBB0 Offset: 0x211ECB1 VA: 0x211EBB0
	|-Array.InternalArray__ICollection_Add<long>
	|
	|-RVA: 0x211EC10 Offset: 0x211ED11 VA: 0x211EC10
	|-Array.InternalArray__ICollection_Add<Int64Enum>
	|
	|-RVA: 0x211EC70 Offset: 0x211ED71 VA: 0x211EC70
	|-Array.InternalArray__ICollection_Add<IntPtr>
	|
	|-RVA: 0x211ECD0 Offset: 0x211EDD1 VA: 0x211ECD0
	|-Array.InternalArray__ICollection_Add<InternalCodePageDataItem>
	|
	|-RVA: 0x211ED30 Offset: 0x211EE31 VA: 0x211ED30
	|-Array.InternalArray__ICollection_Add<InternalEncodingDataItem>
	|
	|-RVA: 0x211ED90 Offset: 0x211EE91 VA: 0x211ED90
	|-Array.InternalArray__ICollection_Add<InterpretedFrameInfo>
	|
	|-RVA: 0x211EDF0 Offset: 0x211EEF1 VA: 0x211EDF0
	|-Array.InternalArray__ICollection_Add<IntervalTreeNode>
	|
	|-RVA: 0x211EE50 Offset: 0x211EF51 VA: 0x211EE50
	|-Array.InternalArray__ICollection_Add<JobHandle>
	|
	|-RVA: 0x211EEB0 Offset: 0x211EFB1 VA: 0x211EEB0
	|-Array.InternalArray__ICollection_Add<Keyframe>
	|
	|-RVA: 0x211EF10 Offset: 0x211F011 VA: 0x211EF10
	|-Array.InternalArray__ICollection_Add<LOD>
	|
	|-RVA: 0x211EF70 Offset: 0x211F071 VA: 0x211EF70
	|-Array.InternalArray__ICollection_Add<LayerMask>
	|
	|-RVA: 0x211EFD0 Offset: 0x211F0D1 VA: 0x211EFD0
	|-Array.InternalArray__ICollection_Add<LengthLimitProperties>
	|
	|-RVA: 0x211F030 Offset: 0x211F131 VA: 0x211F030
	|-Array.InternalArray__ICollection_Add<Light2DBlendStyle>
	|
	|-RVA: 0x211F090 Offset: 0x211F191 VA: 0x211F090
	|-Array.InternalArray__ICollection_Add<LightDataGI>
	|
	|-RVA: 0x211F0F0 Offset: 0x211F1F1 VA: 0x211F0F0
	|-Array.InternalArray__ICollection_Add<LocalDefinition>
	|
	|-RVA: 0x211F150 Offset: 0x211F251 VA: 0x211F150
	|-Array.InternalArray__ICollection_Add<MapPos>
	|
	|-RVA: 0x211F1B0 Offset: 0x211F2B1 VA: 0x211F1B0
	|-Array.InternalArray__ICollection_Add<MapRange>
	|
	|-RVA: 0x211F210 Offset: 0x211F311 VA: 0x211F210
	|-Array.InternalArray__ICollection_Add<MaterialReference>
	|
	|-RVA: 0x211F270 Offset: 0x211F371 VA: 0x211F270
	|-Array.InternalArray__ICollection_Add<Matrix4x4>
	|
	|-RVA: 0x211F2D0 Offset: 0x211F3D1 VA: 0x211F2D0
	|-Array.InternalArray__ICollection_Add<MomentProcessorState>
	|
	|-RVA: 0x211F330 Offset: 0x211F431 VA: 0x211F330
	|-Array.InternalArray__ICollection_Add<MomentStatistic>
	|
	|-RVA: 0x211F390 Offset: 0x211F491 VA: 0x211F390
	|-Array.InternalArray__ICollection_Add<Navigation>
	|
	|-RVA: 0x211F3F0 Offset: 0x211F4F1 VA: 0x211F3F0
	|-Array.InternalArray__ICollection_Add<NetworkServiceAccountId>
	|
	|-RVA: 0x211F450 Offset: 0x211F551 VA: 0x211F450
	|-Array.InternalArray__ICollection_Add<NpadFullKeyState>
	|
	|-RVA: 0x211F4B0 Offset: 0x211F5B1 VA: 0x211F4B0
	|-Array.InternalArray__ICollection_Add<NpadHandheldState>
	|
	|-RVA: 0x211F510 Offset: 0x211F611 VA: 0x211F510
	|-Array.InternalArray__ICollection_Add<NpadJoyDualState>
	|
	|-RVA: 0x211F570 Offset: 0x211F671 VA: 0x211F570
	|-Array.InternalArray__ICollection_Add<NpadJoyLeftState>
	|
	|-RVA: 0x211F5D0 Offset: 0x211F6D1 VA: 0x211F5D0
	|-Array.InternalArray__ICollection_Add<NpadJoyRightState>
	|
	|-RVA: 0x211F630 Offset: 0x211F731 VA: 0x211F630
	|-Array.InternalArray__ICollection_Add<NpadStateArrayItem>
	|
	|-RVA: 0x211F690 Offset: 0x211F791 VA: 0x211F690
	|-Array.InternalArray__ICollection_Add<NsUid>
	|
	|-RVA: 0x211F6F0 Offset: 0x211F7F1 VA: 0x211F6F0
	|-Array.InternalArray__ICollection_Add<object>
	|
	|-RVA: 0x211F750 Offset: 0x211F851 VA: 0x211F750
	|-Array.InternalArray__ICollection_Add<ObjectInitializationData>
	|
	|-RVA: 0x211F7B0 Offset: 0x211F8B1 VA: 0x211F7B0
	|-Array.InternalArray__ICollection_Add<ParameterModifier>
	|
	|-RVA: 0x211F810 Offset: 0x211F911 VA: 0x211F810
	|-Array.InternalArray__ICollection_Add<Plane>
	|
	|-RVA: 0x211F870 Offset: 0x211F971 VA: 0x211F870
	|-Array.InternalArray__ICollection_Add<Playable>
	|
	|-RVA: 0x211F8D0 Offset: 0x211F9D1 VA: 0x211F8D0
	|-Array.InternalArray__ICollection_Add<PlayableBinding>
	|
	|-RVA: 0x211F930 Offset: 0x211FA31 VA: 0x211F930
	|-Array.InternalArray__ICollection_Add<PlayerLoopSystem>
	|
	|-RVA: 0x211F990 Offset: 0x211FA91 VA: 0x211F990
	|-Array.InternalArray__ICollection_Add<PlayerLoopSystemInternal>
	|
	|-RVA: 0x211F9F0 Offset: 0x211FAF1 VA: 0x211F9F0
	|-Array.InternalArray__ICollection_Add<PreTile>
	|
	|-RVA: 0x211FA50 Offset: 0x211FB51 VA: 0x211FA50
	|-Array.InternalArray__ICollection_Add<Profile>
	|
	|-RVA: 0x211FAB0 Offset: 0x211FBB1 VA: 0x211FAB0
	|-Array.InternalArray__ICollection_Add<Protrusion>
	|
	|-RVA: 0x211FB10 Offset: 0x211FC11 VA: 0x211FB10
	|-Array.InternalArray__ICollection_Add<Quaternion>
	|
	|-RVA: 0x211FB70 Offset: 0x211FC71 VA: 0x211FB70
	|-Array.InternalArray__ICollection_Add<RandomSeed>
	|
	|-RVA: 0x211FBD0 Offset: 0x211FCD1 VA: 0x211FBD0
	|-Array.InternalArray__ICollection_Add<RangePositionInfo>
	|
	|-RVA: 0x211FC30 Offset: 0x211FD31 VA: 0x211FC30
	|-Array.InternalArray__ICollection_Add<Ranking2ChartInfoInput>
	|
	|-RVA: 0x211FC90 Offset: 0x211FD91 VA: 0x211FC90
	|-Array.InternalArray__ICollection_Add<RaycastHit>
	|
	|-RVA: 0x211FCF0 Offset: 0x211FDF1 VA: 0x211FCF0
	|-Array.InternalArray__ICollection_Add<RaycastHit2D>
	|
	|-RVA: 0x211FD50 Offset: 0x211FE51 VA: 0x211FD50
	|-Array.InternalArray__ICollection_Add<RaycastResult>
	|
	|-RVA: 0x211FDB0 Offset: 0x211FEB1 VA: 0x211FDB0
	|-Array.InternalArray__ICollection_Add<Rect>
	|
	|-RVA: 0x211FE10 Offset: 0x211FF11 VA: 0x211FE10
	|-Array.InternalArray__ICollection_Add<RenderBuffer>
	|
	|-RVA: 0x211FE70 Offset: 0x211FF71 VA: 0x211FE70
	|-Array.InternalArray__ICollection_Add<RenderStateBlock>
	|
	|-RVA: 0x211FED0 Offset: 0x211FFD1 VA: 0x211FED0
	|-Array.InternalArray__ICollection_Add<RenderTargetHandle>
	|
	|-RVA: 0x211FF30 Offset: 0x2120031 VA: 0x211FF30
	|-Array.InternalArray__ICollection_Add<RenderTargetIdentifier>
	|
	|-RVA: 0x211FF90 Offset: 0x2120091 VA: 0x211FF90
	|-Array.InternalArray__ICollection_Add<RendererListHandle>
	|
	|-RVA: 0x211FFF0 Offset: 0x21200F1 VA: 0x211FFF0
	|-Array.InternalArray__ICollection_Add<ResourceHandle>
	|
	|-RVA: 0x2120050 Offset: 0x2120151 VA: 0x2120050
	|-Array.InternalArray__ICollection_Add<ResourceLocator>
	|
	|-RVA: 0x21200B0 Offset: 0x21201B1 VA: 0x21200B0
	|-Array.InternalArray__ICollection_Add<RichTextTagAttribute>
	|
	|-RVA: 0x2120110 Offset: 0x2120211 VA: 0x2120110
	|-Array.InternalArray__ICollection_Add<RuntimeLabel>
	|
	|-RVA: 0x2120170 Offset: 0x2120271 VA: 0x2120170
	|-Array.InternalArray__ICollection_Add<sbyte>
	|
	|-RVA: 0x21201D0 Offset: 0x21202D1 VA: 0x21201D0
	|-Array.InternalArray__ICollection_Add<SerializedType>
	|
	|-RVA: 0x2120230 Offset: 0x2120331 VA: 0x2120230
	|-Array.InternalArray__ICollection_Add<ShaderKeyword>
	|
	|-RVA: 0x2120290 Offset: 0x2120391 VA: 0x2120290
	|-Array.InternalArray__ICollection_Add<ShaderTagId>
	|
	|-RVA: 0x21202F0 Offset: 0x21203F1 VA: 0x21202F0
	|-Array.InternalArray__ICollection_Add<ShadowSliceData>
	|
	|-RVA: 0x2120350 Offset: 0x2120451 VA: 0x2120350
	|-Array.InternalArray__ICollection_Add<Shape>
	|
	|-RVA: 0x21203B0 Offset: 0x21204B1 VA: 0x21203B0
	|-Array.InternalArray__ICollection_Add<float>
	|
	|-RVA: 0x2120410 Offset: 0x2120511 VA: 0x2120410
	|-Array.InternalArray__ICollection_Add<SixAxisSensorHandle>
	|
	|-RVA: 0x2120470 Offset: 0x2120571 VA: 0x2120470
	|-Array.InternalArray__ICollection_Add<SixAxisSensorState>
	|
	|-RVA: 0x21204D0 Offset: 0x21205D1 VA: 0x21204D0
	|-Array.InternalArray__ICollection_Add<SkeletonBone>
	|
	|-RVA: 0x2120530 Offset: 0x2120631 VA: 0x2120530
	|-Array.InternalArray__ICollection_Add<SortingLayer>
	|
	|-RVA: 0x2120590 Offset: 0x2120691 VA: 0x2120590
	|-Array.InternalArray__ICollection_Add<SphericalHarmonicsL2>
	|
	|-RVA: 0x21205F0 Offset: 0x21206F1 VA: 0x21205F0
	|-Array.InternalArray__ICollection_Add<SpinLock>
	|
	|-RVA: 0x2120650 Offset: 0x2120751 VA: 0x2120650
	|-Array.InternalArray__ICollection_Add<SpringBoneComponents>
	|
	|-RVA: 0x21206B0 Offset: 0x21207B1 VA: 0x21206B0
	|-Array.InternalArray__ICollection_Add<SpringBoneProperties>
	|
	|-RVA: 0x2120710 Offset: 0x2120811 VA: 0x2120710
	|-Array.InternalArray__ICollection_Add<SpringColliderComponents>
	|
	|-RVA: 0x2120770 Offset: 0x2120871 VA: 0x2120770
	|-Array.InternalArray__ICollection_Add<SpringColliderProperties>
	|
	|-RVA: 0x21207D0 Offset: 0x21208D1 VA: 0x21207D0
	|-Array.InternalArray__ICollection_Add<SpringForceComponent>
	|
	|-RVA: 0x2120830 Offset: 0x2120931 VA: 0x2120830
	|-Array.InternalArray__ICollection_Add<SpringJobElement>
	|
	|-RVA: 0x2120890 Offset: 0x2120991 VA: 0x2120890
	|-Array.InternalArray__ICollection_Add<SpriteState>
	|
	|-RVA: 0x21208F0 Offset: 0x21209F1 VA: 0x21208F0
	|-Array.InternalArray__ICollection_Add<SubMeshDescriptor>
	|
	|-RVA: 0x2120950 Offset: 0x2120A51 VA: 0x2120950
	|-Array.InternalArray__ICollection_Add<TMP_CharacterInfo>
	|
	|-RVA: 0x21209B0 Offset: 0x2120AB1 VA: 0x21209B0
	|-Array.InternalArray__ICollection_Add<TMP_FontWeightPair>
	|
	|-RVA: 0x2120A10 Offset: 0x2120B11 VA: 0x2120A10
	|-Array.InternalArray__ICollection_Add<TMP_LineInfo>
	|
	|-RVA: 0x2120A70 Offset: 0x2120B71 VA: 0x2120A70
	|-Array.InternalArray__ICollection_Add<TMP_LinkInfo>
	|
	|-RVA: 0x2120AD0 Offset: 0x2120BD1 VA: 0x2120AD0
	|-Array.InternalArray__ICollection_Add<TMP_MeshInfo>
	|
	|-RVA: 0x2120B30 Offset: 0x2120C31 VA: 0x2120B30
	|-Array.InternalArray__ICollection_Add<TMP_PageInfo>
	|
	|-RVA: 0x2120B90 Offset: 0x2120C91 VA: 0x2120B90
	|-Array.InternalArray__ICollection_Add<TMP_WordInfo>
	|
	|-RVA: 0x2120BF0 Offset: 0x2120CF1 VA: 0x2120BF0
	|-Array.InternalArray__ICollection_Add<TablePair>
	|
	|-RVA: 0x2120C50 Offset: 0x2120D51 VA: 0x2120C50
	|-Array.InternalArray__ICollection_Add<TextureHandle>
	|
	|-RVA: 0x2120CB0 Offset: 0x2120DB1 VA: 0x2120CB0
	|-Array.InternalArray__ICollection_Add<TimeSpan>
	|
	|-RVA: 0x2120D10 Offset: 0x2120E11 VA: 0x2120D10
	|-Array.InternalArray__ICollection_Add<Touch>
	|
	|-RVA: 0x2120D70 Offset: 0x2120E71 VA: 0x2120D70
	|-Array.InternalArray__ICollection_Add<TouchScreenState1>
	|
	|-RVA: 0x2120DD0 Offset: 0x2120ED1 VA: 0x2120DD0
	|-Array.InternalArray__ICollection_Add<TouchScreenState10>
	|
	|-RVA: 0x2120E30 Offset: 0x2120F31 VA: 0x2120E30
	|-Array.InternalArray__ICollection_Add<TouchScreenState11>
	|
	|-RVA: 0x2120E90 Offset: 0x2120F91 VA: 0x2120E90
	|-Array.InternalArray__ICollection_Add<TouchScreenState12>
	|
	|-RVA: 0x2120EF0 Offset: 0x2120FF1 VA: 0x2120EF0
	|-Array.InternalArray__ICollection_Add<TouchScreenState13>
	|
	|-RVA: 0x2120F50 Offset: 0x2121051 VA: 0x2120F50
	|-Array.InternalArray__ICollection_Add<TouchScreenState14>
	|
	|-RVA: 0x2120FB0 Offset: 0x21210B1 VA: 0x2120FB0
	|-Array.InternalArray__ICollection_Add<TouchScreenState15>
	|
	|-RVA: 0x2121010 Offset: 0x2121111 VA: 0x2121010
	|-Array.InternalArray__ICollection_Add<TouchScreenState16>
	|
	|-RVA: 0x2121070 Offset: 0x2121171 VA: 0x2121070
	|-Array.InternalArray__ICollection_Add<TouchScreenState2>
	|
	|-RVA: 0x21210D0 Offset: 0x21211D1 VA: 0x21210D0
	|-Array.InternalArray__ICollection_Add<TouchScreenState3>
	|
	|-RVA: 0x2121130 Offset: 0x2121231 VA: 0x2121130
	|-Array.InternalArray__ICollection_Add<TouchScreenState4>
	|
	|-RVA: 0x2121190 Offset: 0x2121291 VA: 0x2121190
	|-Array.InternalArray__ICollection_Add<TouchScreenState5>
	|
	|-RVA: 0x21211F0 Offset: 0x21212F1 VA: 0x21211F0
	|-Array.InternalArray__ICollection_Add<TouchScreenState6>
	|
	|-RVA: 0x2121250 Offset: 0x2121351 VA: 0x2121250
	|-Array.InternalArray__ICollection_Add<TouchScreenState7>
	|
	|-RVA: 0x21212B0 Offset: 0x21213B1 VA: 0x21212B0
	|-Array.InternalArray__ICollection_Add<TouchScreenState8>
	|
	|-RVA: 0x2121310 Offset: 0x2121411 VA: 0x2121310
	|-Array.InternalArray__ICollection_Add<TouchScreenState9>
	|
	|-RVA: 0x2121370 Offset: 0x2121471 VA: 0x2121370
	|-Array.InternalArray__ICollection_Add<TouchState>
	|
	|-RVA: 0x21213D0 Offset: 0x21214D1 VA: 0x21213D0
	|-Array.InternalArray__ICollection_Add<TrailHand>
	|
	|-RVA: 0x2121430 Offset: 0x2121531 VA: 0x2121430
	|-Array.InternalArray__ICollection_Add<TrailVertex>
	|
	|-RVA: 0x2121490 Offset: 0x2121591 VA: 0x2121490
	|-Array.InternalArray__ICollection_Add<UICharInfo>
	|
	|-RVA: 0x21214F0 Offset: 0x21215F1 VA: 0x21214F0
	|-Array.InternalArray__ICollection_Add<UILineInfo>
	|
	|-RVA: 0x2121550 Offset: 0x2121651 VA: 0x2121550
	|-Array.InternalArray__ICollection_Add<UIVertex>
	|
	|-RVA: 0x21215B0 Offset: 0x21216B1 VA: 0x21215B0
	|-Array.InternalArray__ICollection_Add<ushort>
	|
	|-RVA: 0x2121610 Offset: 0x2121711 VA: 0x2121610
	|-Array.InternalArray__ICollection_Add<UInt16Enum>
	|
	|-RVA: 0x2121670 Offset: 0x2121771 VA: 0x2121670
	|-Array.InternalArray__ICollection_Add<uint>
	|
	|-RVA: 0x21216D0 Offset: 0x21217D1 VA: 0x21216D0
	|-Array.InternalArray__ICollection_Add<UInt32Enum>
	|
	|-RVA: 0x2121730 Offset: 0x2121831 VA: 0x2121730
	|-Array.InternalArray__ICollection_Add<ulong>
	|
	|-RVA: 0x2121790 Offset: 0x2121891 VA: 0x2121790
	|-Array.InternalArray__ICollection_Add<Uid>
	|
	|-RVA: 0x21217F0 Offset: 0x21218F1 VA: 0x21217F0
	|-Array.InternalArray__ICollection_Add<UniTask>
	|
	|-RVA: 0x2121850 Offset: 0x2121951 VA: 0x2121850
	|-Array.InternalArray__ICollection_Add<Unit>
	|
	|-RVA: 0x21218B0 Offset: 0x21219B1 VA: 0x21218B0
	|-Array.InternalArray__ICollection_Add<UnitEnum>
	|
	|-RVA: 0x2121910 Offset: 0x2121A11 VA: 0x2121910
	|-Array.InternalArray__ICollection_Add<UserWord>
	|
	|-RVA: 0x2121970 Offset: 0x2121A71 VA: 0x2121970
	|-Array.InternalArray__ICollection_Add<Vector2>
	|
	|-RVA: 0x21219D0 Offset: 0x2121AD1 VA: 0x21219D0
	|-Array.InternalArray__ICollection_Add<Vector2Int>
	|
	|-RVA: 0x2121A30 Offset: 0x2121B31 VA: 0x2121A30
	|-Array.InternalArray__ICollection_Add<Vector3>
	|
	|-RVA: 0x2121A90 Offset: 0x2121B91 VA: 0x2121A90
	|-Array.InternalArray__ICollection_Add<Vector4>
	|
	|-RVA: 0x2121AF0 Offset: 0x2121BF1 VA: 0x2121AF0
	|-Array.InternalArray__ICollection_Add<VertexAttributeDescriptor>
	|
	|-RVA: 0x2121B50 Offset: 0x2121C51 VA: 0x2121B50
	|-Array.InternalArray__ICollection_Add<VibrationDeviceHandle>
	|
	|-RVA: 0x2121BB0 Offset: 0x2121CB1 VA: 0x2121BB0
	|-Array.InternalArray__ICollection_Add<VibrationDeviceInfo>
	|
	|-RVA: 0x2121C10 Offset: 0x2121D11 VA: 0x2121C10
	|-Array.InternalArray__ICollection_Add<VibrationValue>
	|
	|-RVA: 0x2121C70 Offset: 0x2121D71 VA: 0x2121C70
	|-Array.InternalArray__ICollection_Add<VisibleLight>
	|
	|-RVA: 0x2121CD0 Offset: 0x2121DD1 VA: 0x2121CD0
	|-Array.InternalArray__ICollection_Add<WordWrapState>
	|
	|-RVA: 0x2121D30 Offset: 0x2121E31 VA: 0x2121D30
	|-Array.InternalArray__ICollection_Add<X509ChainStatus>
	|
	|-RVA: 0x2121D90 Offset: 0x2121E91 VA: 0x2121D90
	|-Array.InternalArray__ICollection_Add<XPathNode>
	|
	|-RVA: 0x2121DF0 Offset: 0x2121EF1 VA: 0x2121DF0
	|-Array.InternalArray__ICollection_Add<XPathNodeRef>
	|
	|-RVA: 0x2121E50 Offset: 0x2121F51 VA: 0x2121E50
	|-Array.InternalArray__ICollection_Add<XRView>
	|
	|-RVA: 0x2121EB0 Offset: 0x2121FB1 VA: 0x2121EB0
	|-Array.InternalArray__ICollection_Add<float3>
	|
	|-RVA: 0x2121F10 Offset: 0x2122011 VA: 0x2121F10
	|-Array.InternalArray__ICollection_Add<float4x4>
	|
	|-RVA: 0x2121F70 Offset: 0x2122071 VA: 0x2121F70
	|-Array.InternalArray__ICollection_Add<jvalue>
	|
	|-RVA: 0x2121FD0 Offset: 0x21220D1 VA: 0x2121FD0
	|-Array.InternalArray__ICollection_Add<uint4>
	|
	|-RVA: 0x2122030 Offset: 0x2122131 VA: 0x2122030
	|-Array.InternalArray__ICollection_Add<AICrossfire.PositionTable>
	|
	|-RVA: 0x2122090 Offset: 0x2122191 VA: 0x2122090
	|-Array.InternalArray__ICollection_Add<AIEnum.SkillRangeEnemyData>
	|
	|-RVA: 0x21220F0 Offset: 0x21221F1 VA: 0x21220F0
	|-Array.InternalArray__ICollection_Add<AIOrder.UnitPriority>
	|
	|-RVA: 0x2122150 Offset: 0x2122251 VA: 0x2122150
	|-Array.InternalArray__ICollection_Add<AmiiboSequence.GainItemData>
	|
	|-RVA: 0x21221B0 Offset: 0x21222B1 VA: 0x21221B0
	|-Array.InternalArray__ICollection_Add<AnimationOutputWeightProcessor.WeightInfo>
	|
	|-RVA: 0x2122210 Offset: 0x2122311 VA: 0x2122210
	|-Array.InternalArray__ICollection_Add<ArenaOrderSequence.GodInfo>
	|
	|-RVA: 0x2122270 Offset: 0x2122371 VA: 0x2122270
	|-Array.InternalArray__ICollection_Add<BattleInfo.SupportData>
	|
	|-RVA: 0x21222D0 Offset: 0x21223D1 VA: 0x21222D0
	|-Array.InternalArray__ICollection_Add<BeforeRenderHelper.OrderBlock>
	|
	|-RVA: 0x2122330 Offset: 0x2122431 VA: 0x2122330
	|-Array.InternalArray__ICollection_Add<Camera.RenderRequest>
	|
	|-RVA: 0x2122390 Offset: 0x2122491 VA: 0x2122390
	|-Array.InternalArray__ICollection_Add<CameraState.CustomBlendable>
	|
	|-RVA: 0x21223F0 Offset: 0x21224F1 VA: 0x21223F0
	|-Array.InternalArray__ICollection_Add<CinemachineBlendListCamera.Instruction>
	|
	|-RVA: 0x2122450 Offset: 0x2122551 VA: 0x2122450
	|-Array.InternalArray__ICollection_Add<CinemachineBlenderSettings.CustomBlend>
	|
	|-RVA: 0x21224B0 Offset: 0x21225B1 VA: 0x21224B0
	|-Array.InternalArray__ICollection_Add<CinemachineClearShot.Pair>
	|
	|-RVA: 0x2122510 Offset: 0x2122611 VA: 0x2122510
	|-Array.InternalArray__ICollection_Add<CinemachineFreeLook.Orbit>
	|
	|-RVA: 0x2122570 Offset: 0x2122671 VA: 0x2122570
	|-Array.InternalArray__ICollection_Add<CinemachinePath.Waypoint>
	|
	|-RVA: 0x21225D0 Offset: 0x21226D1 VA: 0x21225D0
	|-Array.InternalArray__ICollection_Add<CinemachineSmoothPath.Waypoint>
	|
	|-RVA: 0x2122630 Offset: 0x2122731 VA: 0x2122630
	|-Array.InternalArray__ICollection_Add<CinemachineStateDrivenCamera.HashPair>
	|
	|-RVA: 0x2122690 Offset: 0x2122791 VA: 0x2122690
	|-Array.InternalArray__ICollection_Add<CinemachineStateDrivenCamera.Instruction>
	|
	|-RVA: 0x21226F0 Offset: 0x21227F1 VA: 0x21226F0
	|-Array.InternalArray__ICollection_Add<CinemachineStateDrivenCamera.ParentHash>
	|
	|-RVA: 0x2122750 Offset: 0x2122851 VA: 0x2122750
	|-Array.InternalArray__ICollection_Add<CinemachineTargetGroup.Target>
	|
	|-RVA: 0x21227B0 Offset: 0x21228B1 VA: 0x21227B0
	|-Array.InternalArray__ICollection_Add<CodePointIndexer.TableRange>
	|
	|-RVA: 0x2122810 Offset: 0x2122911 VA: 0x2122810
	|-Array.InternalArray__ICollection_Add<ContentCatalogData.Bucket>
	|
	|-RVA: 0x2122870 Offset: 0x2122971 VA: 0x2122870
	|-Array.InternalArray__ICollection_Add<CookieTokenizer.RecognizedAttribute>
	|
	|-RVA: 0x21228D0 Offset: 0x21229D1 VA: 0x21228D0
	|-Array.InternalArray__ICollection_Add<DeferredLights.DrawCall>
	|
	|-RVA: 0x2122930 Offset: 0x2122A31 VA: 0x2122930
	|-Array.InternalArray__ICollection_Add<DeferredShaderData.ComputeBufferInfo>
	|
	|-RVA: 0x2122990 Offset: 0x2122A91 VA: 0x2122990
	|-Array.InternalArray__ICollection_Add<DeferredTiler.PrePunctualLight>
	|
	|-RVA: 0x21229F0 Offset: 0x2122AF1 VA: 0x21229F0
	|-Array.InternalArray__ICollection_Add<DelayedActionManager.DelegateInfo>
	|
	|-RVA: 0x2122A50 Offset: 0x2122B51 VA: 0x2122A50
	|-Array.InternalArray__ICollection_Add<Detail.AsyncResultInt>
	|
	|-RVA: 0x2122AB0 Offset: 0x2122BB1 VA: 0x2122AB0
	|-Array.InternalArray__ICollection_Add<Detail.CppArray>
	|
	|-RVA: 0x2122B10 Offset: 0x2122C11 VA: 0x2122B10
	|-Array.InternalArray__ICollection_Add<Detail.NotificationEventInt>
	|
	|-RVA: 0x2122B70 Offset: 0x2122C71 VA: 0x2122B70
	|-Array.InternalArray__ICollection_Add<DisposUnit.Item>
	|
	|-RVA: 0x2122BD0 Offset: 0x2122CD1 VA: 0x2122BD0
	|-Array.InternalArray__ICollection_Add<DragonRidePresetParamData.CourseData>
	|
	|-RVA: 0x2122C30 Offset: 0x2122D31 VA: 0x2122C30
	|-Array.InternalArray__ICollection_Add<DragonRideTargetGroup.ChainParam>
	|
	|-RVA: 0x2122C90 Offset: 0x2122D91 VA: 0x2122C90
	|-Array.InternalArray__ICollection_Add<DynamicMesh.State>
	|
	|-RVA: 0x2122CF0 Offset: 0x2122DF1 VA: 0x2122CF0
	|-Array.InternalArray__ICollection_Add<FXZEx.HitPoint>
	|
	|-RVA: 0x2122D50 Offset: 0x2122E51 VA: 0x2122D50
	|-Array.InternalArray__ICollection_Add<FishingRadicalParamData.RadicalParam>
	|
	|-RVA: 0x2122DB0 Offset: 0x2122EB1 VA: 0x2122DB0
	|-Array.InternalArray__ICollection_Add<GameVariable.Value>
	|
	|-RVA: 0x2122E10 Offset: 0x2122F11 VA: 0x2122E10
	|-Array.InternalArray__ICollection_Add<GmapPathAdjuster.TargetModel>
	|
	|-RVA: 0x2122E70 Offset: 0x2122F71 VA: 0x2122E70
	|-Array.InternalArray__ICollection_Add<GmapSpotAdjuster.TargetModel>
	|
	|-RVA: 0x2122ED0 Offset: 0x2122FD1 VA: 0x2122ED0
	|-Array.InternalArray__ICollection_Add<GrounderQuadruped.Foot>
	|
	|-RVA: 0x2122F30 Offset: 0x2123031 VA: 0x2122F30
	|-Array.InternalArray__ICollection_Add<Hashtable.bucket>
	|
	|-RVA: 0x2122F90 Offset: 0x2123091 VA: 0x2122F90
	|-Array.InternalArray__ICollection_Add<HeadingTracker.Item>
	|
	|-RVA: 0x2122FF0 Offset: 0x21230F1 VA: 0x2122FF0
	|-Array.InternalArray__ICollection_Add<HubAccessoryRoomCamera.BackgroundSettings>
	|
	|-RVA: 0x2123050 Offset: 0x2123151 VA: 0x2123050
	|-Array.InternalArray__ICollection_Add<HubFastTravel.Location>
	|
	|-RVA: 0x21230B0 Offset: 0x21231B1 VA: 0x21230B0
	|-Array.InternalArray__ICollection_Add<HubLensFlare.Flare>
	|
	|-RVA: 0x2123110 Offset: 0x2123211 VA: 0x2123110
	|-Array.InternalArray__ICollection_Add<HubLookAtController.LookAtIKParam>
	|
	|-RVA: 0x2123170 Offset: 0x2123271 VA: 0x2123170
	|-Array.InternalArray__ICollection_Add<HubMaterialArray.MaterialInfo>
	|
	|-RVA: 0x21231D0 Offset: 0x21232D1 VA: 0x21231D0
	|-Array.InternalArray__ICollection_Add<IKSolverLimb.AxisDirection>
	|
	|-RVA: 0x2123230 Offset: 0x2123331 VA: 0x2123230
	|-Array.InternalArray__ICollection_Add<InventoryPoolItemMenuContent.KindBgNameClass>
	|
	|-RVA: 0x2123290 Offset: 0x2123391 VA: 0x2123290
	|-Array.InternalArray__ICollection_Add<LightUtility.ParametricLightMeshVertex>
	|
	|-RVA: 0x21232F0 Offset: 0x21233F1 VA: 0x21232F0
	|-Array.InternalArray__ICollection_Add<LightUtility.SpriteLightMeshVertex>
	|
	|-RVA: 0x2123350 Offset: 0x2123451 VA: 0x2123350
	|-Array.InternalArray__ICollection_Add<Map.Pos>
	|
	|-RVA: 0x21233B0 Offset: 0x21234B1 VA: 0x21233B0
	|-Array.InternalArray__ICollection_Add<MapGodExp.KindDesc>
	|
	|-RVA: 0x2123410 Offset: 0x2123511 VA: 0x2123410
	|-Array.InternalArray__ICollection_Add<MapHistory.Command>
	|
	|-RVA: 0x2123470 Offset: 0x2123571 VA: 0x2123470
	|-Array.InternalArray__ICollection_Add<MapImage.BackupTerrain>
	|
	|-RVA: 0x21234D0 Offset: 0x21235D1 VA: 0x21234D0
	|-Array.InternalArray__ICollection_Add<MapImageRange.Pos>
	|
	|-RVA: 0x2123530 Offset: 0x2123631 VA: 0x2123530
	|-Array.InternalArray__ICollection_Add<MapKillBonus.KillBonus>
	|
	|-RVA: 0x2123590 Offset: 0x2123691 VA: 0x2123590
	|-Array.InternalArray__ICollection_Add<MapKillBonus.KilledBonus>
	|
	|-RVA: 0x21235F0 Offset: 0x21236F1 VA: 0x21235F0
	|-Array.InternalArray__ICollection_Add<MapMind.Record>
	|
	|-RVA: 0x2123650 Offset: 0x2123751 VA: 0x2123650
	|-Array.InternalArray__ICollection_Add<MapMind.Target>
	|
	|-RVA: 0x21236B0 Offset: 0x21237B1 VA: 0x21236B0
	|-Array.InternalArray__ICollection_Add<MapPanelDebug.Entity>
	|
	|-RVA: 0x2123710 Offset: 0x2123811 VA: 0x2123710
	|-Array.InternalArray__ICollection_Add<NexRanking.Data>
	|
	|-RVA: 0x2123770 Offset: 0x2123871 VA: 0x2123770
	|-Array.InternalArray__ICollection_Add<NexVersus.RatingData>
	|
	|-RVA: 0x21237D0 Offset: 0x21238D1 VA: 0x21237D0
	|-Array.InternalArray__ICollection_Add<NoiseSettings.TransformNoiseParams>
	|
	|-RVA: 0x2123830 Offset: 0x2123931 VA: 0x2123830
	|-Array.InternalArray__ICollection_Add<PackedPlayModeBuildLogs.RuntimeBuildLog>
	|
	|-RVA: 0x2123890 Offset: 0x2123991 VA: 0x2123890
	|-Array.InternalArray__ICollection_Add<ParameterizedStrings.FormatParam>
	|
	|-RVA: 0x21238F0 Offset: 0x21239F1 VA: 0x21238F0
	|-Array.InternalArray__ICollection_Add<ParticleSystem.Particle>
	|
	|-RVA: 0x2123950 Offset: 0x2123A51 VA: 0x2123950
	|-Array.InternalArray__ICollection_Add<ProfileCard.Achievement>
	|
	|-RVA: 0x21239B0 Offset: 0x2123AB1 VA: 0x21239B0
	|-Array.InternalArray__ICollection_Add<ProfileCard.SortieCount>
	|
	|-RVA: 0x2123A10 Offset: 0x2123B11 VA: 0x2123A10
	|-Array.InternalArray__ICollection_Add<QualitySettingsStack.Settings>
	|
	|-RVA: 0x2123A70 Offset: 0x2123B71 VA: 0x2123A70
	|-Array.InternalArray__ICollection_Add<RangeData.Offset>
	|
	|-RVA: 0x2123AD0 Offset: 0x2123BD1 VA: 0x2123AD0
	|-Array.InternalArray__ICollection_Add<RegexCharClass.LowerCaseMapping>
	|
	|-RVA: 0x2123B30 Offset: 0x2123C31 VA: 0x2123B30
	|-Array.InternalArray__ICollection_Add<Relay.ChooseAwardeeData>
	|
	|-RVA: 0x2123B90 Offset: 0x2123C91 VA: 0x2123B90
	|-Array.InternalArray__ICollection_Add<RelayAwardData.Info>
	|
	|-RVA: 0x2123BF0 Offset: 0x2123CF1 VA: 0x2123BF0
	|-Array.InternalArray__ICollection_Add<RenderGraph.CompiledPassInfo>
	|
	|-RVA: 0x2123C50 Offset: 0x2123D51 VA: 0x2123C50
	|-Array.InternalArray__ICollection_Add<RenderGraph.CompiledResourceInfo>
	|
	|-RVA: 0x2123CB0 Offset: 0x2123DB1 VA: 0x2123CB0
	|-Array.InternalArray__ICollection_Add<RenderGraphDebugData.PassDebugData>
	|
	|-RVA: 0x2123D10 Offset: 0x2123E11 VA: 0x2123D10
	|-Array.InternalArray__ICollection_Add<RenderGraphDebugData.ResourceDebugData>
	|
	|-RVA: 0x2123D70 Offset: 0x2123E71 VA: 0x2123D70
	|-Array.InternalArray__ICollection_Add<RenderGraphResourceRegistry.RendererListResource>
	|
	|-RVA: 0x2123DD0 Offset: 0x2123ED1 VA: 0x2123DD0
	|-Array.InternalArray__ICollection_Add<RingCleaningUnitSelectMenu.GodParam>
	|
	|-RVA: 0x2123E30 Offset: 0x2123F31 VA: 0x2123E30
	|-Array.InternalArray__ICollection_Add<SampleWave.Data>
	|
	|-RVA: 0x2123E90 Offset: 0x2123F91 VA: 0x2123E90
	|-Array.InternalArray__ICollection_Add<SampleWave.Temp>
	|
	|-RVA: 0x2123EF0 Offset: 0x2123FF1 VA: 0x2123EF0
	|-Array.InternalArray__ICollection_Add<SendMouseEvents.HitInfo>
	|
	|-RVA: 0x2123F50 Offset: 0x2124051 VA: 0x2123F50
	|-Array.InternalArray__ICollection_Add<SequenceNode.SequenceConstructPosContext>
	|
	|-RVA: 0x2123FB0 Offset: 0x21240B1 VA: 0x2123FB0
	|-Array.InternalArray__ICollection_Add<ShaderInput.LightData>
	|
	|-RVA: 0x2124010 Offset: 0x2124111 VA: 0x2124010
	|-Array.InternalArray__ICollection_Add<ShaderInput.ShadowData>
	|
	|-RVA: 0x2124070 Offset: 0x2124171 VA: 0x2124070
	|-Array.InternalArray__ICollection_Add<ShadowUtility.Edge>
	|
	|-RVA: 0x21240D0 Offset: 0x21241D1 VA: 0x21240D0
	|-Array.InternalArray__ICollection_Add<SimpleAnimationPlayable.QueuedState>
	|
	|-RVA: 0x2124130 Offset: 0x2124231 VA: 0x2124130
	|-Array.InternalArray__ICollection_Add<SkillArray.Entity>
	|
	|-RVA: 0x2124190 Offset: 0x2124291 VA: 0x2124190
	|-Array.InternalArray__ICollection_Add<Socket.WSABUF>
	|
	|-RVA: 0x21241F0 Offset: 0x21242F1 VA: 0x21241F0
	|-Array.InternalArray__ICollection_Add<Stream.Info>
	|
	|-RVA: 0x2124250 Offset: 0x2124351 VA: 0x2124250
	|-Array.InternalArray__ICollection_Add<TMP_Text.UnicodeChar>
	|
	|-RVA: 0x21242B0 Offset: 0x21243B1 VA: 0x21242B0
	|-Array.InternalArray__ICollection_Add<TexturePacker_JsonArray.Frame>
	|
	|-RVA: 0x2124310 Offset: 0x2124411 VA: 0x2124310
	|-Array.InternalArray__ICollection_Add<TimeNotificationBehaviour.NotificationEntry>
	|
	|-RVA: 0x2124370 Offset: 0x2124471 VA: 0x2124370
	|-Array.InternalArray__ICollection_Add<UnitySynchronizationContext.WorkRequest>
	|
	|-RVA: 0x21243D0 Offset: 0x21244D1 VA: 0x21243D0
	|-Array.InternalArray__ICollection_Add<XmlNamespaceManager.NamespaceDeclaration>
	|
	|-RVA: 0x2124430 Offset: 0x2124531 VA: 0x2124430
	|-Array.InternalArray__ICollection_Add<XmlSchemaObjectTable.XmlSchemaObjectEntry>
	|
	|-RVA: 0x2124490 Offset: 0x2124591 VA: 0x2124490
	|-Array.InternalArray__ICollection_Add<XmlTextReaderImpl.ParsingState>
	|
	|-RVA: 0x21244F0 Offset: 0x21245F1 VA: 0x21244F0
	|-Array.InternalArray__ICollection_Add<AIThink.EnchantThink.Desc>
	|
	|-RVA: 0x2124550 Offset: 0x2124651 VA: 0x2124550
	|-Array.InternalArray__ICollection_Add<AIThink.EnchantThink.ItemInfo>
	|
	|-RVA: 0x21245B0 Offset: 0x21246B1 VA: 0x21245B0
	|-Array.InternalArray__ICollection_Add<AIThink.EnchantThink.SurroundingInfo>
	|
	|-RVA: 0x2124610 Offset: 0x2124711 VA: 0x2124610
	|-Array.InternalArray__ICollection_Add<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>
	|
	|-RVA: 0x2124670 Offset: 0x2124771 VA: 0x2124670
	|-Array.InternalArray__ICollection_Add<Detail.DataStore.DataStoreChangeMetaParamInt>
	|
	|-RVA: 0x21246D0 Offset: 0x21247D1 VA: 0x21246D0
	|-Array.InternalArray__ICollection_Add<Detail.DataStore.DataStoreDeleteParamInt>
	|
	|-RVA: 0x2124730 Offset: 0x2124831 VA: 0x2124730
	|-Array.InternalArray__ICollection_Add<Detail.DataStore.DataStoreGetMetaParamInt>
	|
	|-RVA: 0x2124790 Offset: 0x2124891 VA: 0x2124790
	|-Array.InternalArray__ICollection_Add<Detail.DataStore.DataStoreMetaInfoInt>
	|
	|-RVA: 0x21247F0 Offset: 0x21248F1 VA: 0x21247F0
	|-Array.InternalArray__ICollection_Add<Detail.DataStore.DataStorePasswordInfoInt>
	|
	|-RVA: 0x2124850 Offset: 0x2124951 VA: 0x2124850
	|-Array.InternalArray__ICollection_Add<Detail.DataStore.DataStorePersistenceInfoInt>
	|
	|-RVA: 0x21248B0 Offset: 0x21249B1 VA: 0x21248B0
	|-Array.InternalArray__ICollection_Add<Detail.DataStore.DataStorePreparePostParamInt>
	|
	|-RVA: 0x2124910 Offset: 0x2124A11 VA: 0x2124910
	|-Array.InternalArray__ICollection_Add<Detail.DataStore.DataStoreRateObjectParamInt>
	|
	|-RVA: 0x2124970 Offset: 0x2124A71 VA: 0x2124970
	|-Array.InternalArray__ICollection_Add<Detail.DataStore.DataStoreRatingInitParamInt>
	|
	|-RVA: 0x21249D0 Offset: 0x2124AD1 VA: 0x21249D0
	|-Array.InternalArray__ICollection_Add<Detail.DataStore.DataStoreRatingTargetInt>
	|
	|-RVA: 0x2124A30 Offset: 0x2124B31 VA: 0x2124A30
	|-Array.InternalArray__ICollection_Add<Detail.Ranking.RankingCachedResultInt>
	|
	|-RVA: 0x2124A90 Offset: 0x2124B91 VA: 0x2124A90
	|-Array.InternalArray__ICollection_Add<Detail.Ranking.RankingOrderParamInt>
	|
	|-RVA: 0x2124AF0 Offset: 0x2124BF1 VA: 0x2124AF0
	|-Array.InternalArray__ICollection_Add<Detail.Ranking.RankingRankDataInt>
	|
	|-RVA: 0x2124B50 Offset: 0x2124C51 VA: 0x2124B50
	|-Array.InternalArray__ICollection_Add<Detail.Ranking2.Ranking2ChartInfoInt>
	|
	|-RVA: 0x2124BB0 Offset: 0x2124CB1 VA: 0x2124BB0
	|-Array.InternalArray__ICollection_Add<Detail.Ranking2.Ranking2RankDataInt>
	|
	|-RVA: 0x2124C10 Offset: 0x2124D11 VA: 0x2124C10
	|-Array.InternalArray__ICollection_Add<Detail.Ranking2.Ranking2ScoreDataInt>
	|
	|-RVA: 0x2124C70 Offset: 0x2124D71 VA: 0x2124C70
	|-Array.InternalArray__ICollection_Add<Detail.Screening.ScreeningContextInfoInt>
	|
	|-RVA: 0x2124CD0 Offset: 0x2124DD1 VA: 0x2124CD0
	|-Array.InternalArray__ICollection_Add<Detail.Subscriber.SubscriberContentInt>
	|
	|-RVA: 0x2124D30 Offset: 0x2124E31 VA: 0x2124D30
	|-Array.InternalArray__ICollection_Add<Detail.Subscriber.SubscriberGetContentParamInt>
	|
	|-RVA: 0x2124D90 Offset: 0x2124E91 VA: 0x2124D90
	|-Array.InternalArray__ICollection_Add<Detail.Subscriber.SubscriberUserStatusInfoInt>
	|
	|-RVA: 0x2124DF0 Offset: 0x2124EF1 VA: 0x2124DF0
	|-Array.InternalArray__ICollection_Add<Detail.Subscriber.SubscriberUserStatusParamInt>
	|
	|-RVA: 0x2124E50 Offset: 0x2124F51 VA: 0x2124E50
	|-Array.InternalArray__ICollection_Add<Detail.Utility.IntegerSettings>
	|
	|-RVA: 0x2124EB0 Offset: 0x2124FB1 VA: 0x2124EB0
	|-Array.InternalArray__ICollection_Add<Detail.Utility.UniqueIdInfoInt>
	|
	|-RVA: 0x2124F10 Offset: 0x2125011 VA: 0x2124F10
	|-Array.InternalArray__ICollection_Add<FacetsChecker.FacetsCompiler.Map>
	|
	|-RVA: 0x2124F70 Offset: 0x2125071 VA: 0x2124F70
	|-Array.InternalArray__ICollection_Add<MapHistory.ReplayAppearanceMap.Appearance>
	|
	|-RVA: 0x2124FD0 Offset: 0x21250D1 VA: 0x2124FD0
	|-Array.InternalArray__ICollection_Add<MapHistory.ReplayAppearanceMap.Leaving>
	|
	|-RVA: 0x2125030 Offset: 0x2125131 VA: 0x2125030
	|-Array.InternalArray__ICollection_Add<MapHistory.ReplayUnitMap.Data>
	|
	|-RVA: 0x2125090 Offset: 0x2125191 VA: 0x2125090
	|-Array.InternalArray__ICollection_Add<MapHistory.Rewind.LatestInspectorData>
	|
	|-RVA: 0x21250F0 Offset: 0x21251F1 VA: 0x21250F0
	|-Array.InternalArray__ICollection_Add<MapHistory.Rewind.WorkTerrainData>
	|
	|-RVA: 0x2125150 Offset: 0x2125251 VA: 0x2125150
	|-Array.InternalArray__ICollection_Add<MapHistory.RewindUnitMap.Data>
	|
	|-RVA: 0x21251B0 Offset: 0x21252B1 VA: 0x21251B0
	|-Array.InternalArray__ICollection_Add<MapKillBonus.Work.Pos>
	|
	|-RVA: 0x2125210 Offset: 0x2125311 VA: 0x2125210
	|-Array.InternalArray__ICollection_Add<MapSkill.AroundCalculator.Result>
	|
	|-RVA: 0x2125270 Offset: 0x2125371 VA: 0x2125270
	|-Array.InternalArray__ICollection_Add<Nex.ApiCallChecker.Guideline>
	|
	|-RVA: 0x21252D0 Offset: 0x21253D1 VA: 0x21252D0
	|-Array.InternalArray__ICollection_Add<Ngc.MaskTextSequenceBase.Data>
	|
	|-RVA: 0x2125330 Offset: 0x2125431 VA: 0x2125330
	|-Array.InternalArray__ICollection_Add<TargetPositionCache.CacheCurve.Item>
	|
	|-RVA: 0x2125390 Offset: 0x2125491 VA: 0x2125390
	|-Array.InternalArray__ICollection_Add<TargetPositionCache.CacheEntry.RecordingItem>
	|
	|-RVA: 0x21253F0 Offset: 0x21254F1 VA: 0x21253F0
	|-Array.InternalArray__ICollection_Add<TerrainUtility.TerrainMap.TileCoord>
	*/

	// RVA: -1 Offset: -1
	internal bool InternalArray__ICollection_Remove<T>(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1C78B60 Offset: 0x1C78C61 VA: 0x1C78B60
	|-Array.InternalArray__ICollection_Remove<ArraySegment<byte>>
	|
	|-RVA: 0x1C78BC0 Offset: 0x1C78CC1 VA: 0x1C78BC0
	|-Array.InternalArray__ICollection_Remove<AsyncOperationHandle<object>>
	|
	|-RVA: 0x1C78C20 Offset: 0x1C78D21 VA: 0x1C78C20
	|-Array.InternalArray__ICollection_Remove<MapDeployTemplate.Queue.Data<object>>
	|
	|-RVA: 0x1C78C80 Offset: 0x1C78D81 VA: 0x1C78C80
	|-Array.InternalArray__ICollection_Remove<Nex.DataStore.ParamPool.Data<object>>
	|
	|-RVA: 0x1C78CE0 Offset: 0x1C78DE1 VA: 0x1C78CE0
	|-Array.InternalArray__ICollection_Remove<Nex.Screening.ParamPool.Data<object>>
	|
	|-RVA: 0x1C78D40 Offset: 0x1C78E41 VA: 0x1C78D40
	|-Array.InternalArray__ICollection_Remove<IntervalTree.Entry<object>>
	|
	|-RVA: 0x1C78DA0 Offset: 0x1C78EA1 VA: 0x1C78DA0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<ValueTuple<object, int>, object>>
	|
	|-RVA: 0x1C78E00 Offset: 0x1C78F01 VA: 0x1C78E00
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<byte, object>>
	|
	|-RVA: 0x1C78E60 Offset: 0x1C78F61 VA: 0x1C78E60
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<CancellationToken, object>>
	|
	|-RVA: 0x1C78EC0 Offset: 0x1C78FC1 VA: 0x1C78EC0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<char, object>>
	|
	|-RVA: 0x1C78F20 Offset: 0x1C79021 VA: 0x1C78F20
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Guid, object>>
	|
	|-RVA: 0x1C78F80 Offset: 0x1C79081 VA: 0x1C78F80
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<int, bool>>
	|
	|-RVA: 0x1C78FE0 Offset: 0x1C790E1 VA: 0x1C78FE0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<int, byte>>
	|
	|-RVA: 0x1C79040 Offset: 0x1C79141 VA: 0x1C79040
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<int, char>>
	|
	|-RVA: 0x1C790A0 Offset: 0x1C791A1 VA: 0x1C790A0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<int, DiagnosticEvent>>
	|
	|-RVA: 0x1C79100 Offset: 0x1C79201 VA: 0x1C79100
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<int, int>>
	|
	|-RVA: 0x1C79160 Offset: 0x1C79261 VA: 0x1C79160
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<int, Int32Enum>>
	|
	|-RVA: 0x1C791C0 Offset: 0x1C792C1 VA: 0x1C791C0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<int, long>>
	|
	|-RVA: 0x1C79220 Offset: 0x1C79321 VA: 0x1C79220
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<int, MapPos>>
	|
	|-RVA: 0x1C79280 Offset: 0x1C79381 VA: 0x1C79280
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<int, object>>
	|
	|-RVA: 0x1C792E0 Offset: 0x1C793E1 VA: 0x1C792E0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<int, uint>>
	|
	|-RVA: 0x1C79340 Offset: 0x1C79441 VA: 0x1C79340
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<int, AIThink.EnchantThink.SurroundingInfo>>
	|
	|-RVA: 0x1C793A0 Offset: 0x1C794A1 VA: 0x1C793A0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Int32Enum, bool>>
	|
	|-RVA: 0x1C79400 Offset: 0x1C79501 VA: 0x1C79400
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Int32Enum, int>>
	|
	|-RVA: 0x1C79460 Offset: 0x1C79561 VA: 0x1C79460
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Int32Enum, Int32Enum>>
	|
	|-RVA: 0x1C794C0 Offset: 0x1C795C1 VA: 0x1C794C0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Int32Enum, object>>
	|
	|-RVA: 0x1C79520 Offset: 0x1C79621 VA: 0x1C79520
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<long, object>>
	|
	|-RVA: 0x1C79580 Offset: 0x1C79681 VA: 0x1C79580
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<MapPos, int>>
	|
	|-RVA: 0x1C795E0 Offset: 0x1C796E1 VA: 0x1C795E0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, AsyncOperationHandle<object>>>
	|
	|-RVA: 0x1C79640 Offset: 0x1C79741 VA: 0x1C79640
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, AsyncOperationHandle>>
	|
	|-RVA: 0x1C796A0 Offset: 0x1C797A1 VA: 0x1C796A0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, bool>>
	|
	|-RVA: 0x1C79700 Offset: 0x1C79801 VA: 0x1C79700
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, byte>>
	|
	|-RVA: 0x1C79760 Offset: 0x1C79861 VA: 0x1C79760
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, int>>
	|
	|-RVA: 0x1C797C0 Offset: 0x1C798C1 VA: 0x1C797C0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, Int32Enum>>
	|
	|-RVA: 0x1C79820 Offset: 0x1C79921 VA: 0x1C79820
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, IntPtr>>
	|
	|-RVA: 0x1C79880 Offset: 0x1C79981 VA: 0x1C79880
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, object>>
	|
	|-RVA: 0x1C798E0 Offset: 0x1C799E1 VA: 0x1C798E0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, Playable>>
	|
	|-RVA: 0x1C79940 Offset: 0x1C79A41 VA: 0x1C79940
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, ResourceLocator>>
	|
	|-RVA: 0x1C799A0 Offset: 0x1C79AA1 VA: 0x1C799A0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, float>>
	|
	|-RVA: 0x1C79A00 Offset: 0x1C79B01 VA: 0x1C79A00
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, ushort>>
	|
	|-RVA: 0x1C79A60 Offset: 0x1C79B61 VA: 0x1C79A60
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<object, GameVariable.Value>>
	|
	|-RVA: 0x1C79AC0 Offset: 0x1C79BC1 VA: 0x1C79AC0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<sbyte, DataStoreRatingInfo>>
	|
	|-RVA: 0x1C79B20 Offset: 0x1C79C21 VA: 0x1C79B20
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<sbyte, object>>
	|
	|-RVA: 0x1C79B80 Offset: 0x1C79C81 VA: 0x1C79B80
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<ushort, int>>
	|
	|-RVA: 0x1C79BE0 Offset: 0x1C79CE1 VA: 0x1C79BE0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<uint, int>>
	|
	|-RVA: 0x1C79C40 Offset: 0x1C79D41 VA: 0x1C79C40
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<uint, object>>
	|
	|-RVA: 0x1C79CA0 Offset: 0x1C79DA1 VA: 0x1C79CA0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<ulong, Friend>>
	|
	|-RVA: 0x1C79D00 Offset: 0x1C79E01 VA: 0x1C79D00
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<ulong, Int32Enum>>
	|
	|-RVA: 0x1C79D60 Offset: 0x1C79E61 VA: 0x1C79D60
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<ulong, object>>
	|
	|-RVA: 0x1C79DC0 Offset: 0x1C79EC1 VA: 0x1C79DC0
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<Vector3, int>>
	|
	|-RVA: 0x1C79E20 Offset: 0x1C79F21 VA: 0x1C79E20
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<XPathNodeRef, XPathNodeRef>>
	|
	|-RVA: 0x1C79E80 Offset: 0x1C79F81 VA: 0x1C79E80
	|-Array.InternalArray__ICollection_Remove<Dictionary.Entry<TerrainUtility.TerrainMap.TileCoord, object>>
	|
	|-RVA: 0x1C79EE0 Offset: 0x1C79FE1 VA: 0x1C79EE0
	|-Array.InternalArray__ICollection_Remove<PriorityQueue.IndexedItem<object>>
	|
	|-RVA: 0x1C79F40 Offset: 0x1C7A041 VA: 0x1C79F40
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<ValueTuple<object, int>, object>>
	|
	|-RVA: 0x1C79FA0 Offset: 0x1C7A0A1 VA: 0x1C79FA0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<byte, object>>
	|
	|-RVA: 0x1C7A000 Offset: 0x1C7A101 VA: 0x1C7A000
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<CancellationToken, object>>
	|
	|-RVA: 0x1C7A060 Offset: 0x1C7A161 VA: 0x1C7A060
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<char, object>>
	|
	|-RVA: 0x1C7A0C0 Offset: 0x1C7A1C1 VA: 0x1C7A0C0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<DateTime, object>>
	|
	|-RVA: 0x1C7A120 Offset: 0x1C7A221 VA: 0x1C7A120
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Guid, object>>
	|
	|-RVA: 0x1C7A180 Offset: 0x1C7A281 VA: 0x1C7A180
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<int, bool>>
	|
	|-RVA: 0x1C7A1E0 Offset: 0x1C7A2E1 VA: 0x1C7A1E0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<int, byte>>
	|
	|-RVA: 0x1C7A240 Offset: 0x1C7A341 VA: 0x1C7A240
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<int, char>>
	|
	|-RVA: 0x1C7A2A0 Offset: 0x1C7A3A1 VA: 0x1C7A2A0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<int, DiagnosticEvent>>
	|
	|-RVA: 0x1C7A300 Offset: 0x1C7A401 VA: 0x1C7A300
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<int, int>>
	|
	|-RVA: 0x1C7A360 Offset: 0x1C7A461 VA: 0x1C7A360
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<int, Int32Enum>>
	|
	|-RVA: 0x1C7A3C0 Offset: 0x1C7A4C1 VA: 0x1C7A3C0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<int, long>>
	|
	|-RVA: 0x1C7A420 Offset: 0x1C7A521 VA: 0x1C7A420
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<int, MapPos>>
	|
	|-RVA: 0x1C7A480 Offset: 0x1C7A581 VA: 0x1C7A480
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<int, object>>
	|
	|-RVA: 0x1C7A4E0 Offset: 0x1C7A5E1 VA: 0x1C7A4E0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<int, uint>>
	|
	|-RVA: 0x1C7A540 Offset: 0x1C7A641 VA: 0x1C7A540
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<int, AIThink.EnchantThink.SurroundingInfo>>
	|
	|-RVA: 0x1C7A5A0 Offset: 0x1C7A6A1 VA: 0x1C7A5A0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Int32Enum, bool>>
	|
	|-RVA: 0x1C7A600 Offset: 0x1C7A701 VA: 0x1C7A600
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Int32Enum, int>>
	|
	|-RVA: 0x1C7A660 Offset: 0x1C7A761 VA: 0x1C7A660
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Int32Enum, Int32Enum>>
	|
	|-RVA: 0x1C7A6C0 Offset: 0x1C7A7C1 VA: 0x1C7A6C0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Int32Enum, object>>
	|
	|-RVA: 0x1C7A720 Offset: 0x1C7A821 VA: 0x1C7A720
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<long, object>>
	|
	|-RVA: 0x1C7A780 Offset: 0x1C7A881 VA: 0x1C7A780
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<MapPos, int>>
	|
	|-RVA: 0x1C7A7E0 Offset: 0x1C7A8E1 VA: 0x1C7A7E0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, AsyncOperationHandle<object>>>
	|
	|-RVA: 0x1C7A840 Offset: 0x1C7A941 VA: 0x1C7A840
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, ValueTuple<int, DateTime, object>>>
	|
	|-RVA: 0x1C7A8A0 Offset: 0x1C7A9A1 VA: 0x1C7A8A0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, AsyncOperationHandle>>
	|
	|-RVA: 0x1C7A900 Offset: 0x1C7AA01 VA: 0x1C7A900
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, bool>>
	|
	|-RVA: 0x1C7A960 Offset: 0x1C7AA61 VA: 0x1C7A960
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, byte>>
	|
	|-RVA: 0x1C7A9C0 Offset: 0x1C7AAC1 VA: 0x1C7A9C0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, int>>
	|
	|-RVA: 0x1C7AA20 Offset: 0x1C7AB21 VA: 0x1C7AA20
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, Int32Enum>>
	|
	|-RVA: 0x1C7AA80 Offset: 0x1C7AB81 VA: 0x1C7AA80
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, IntPtr>>
	|
	|-RVA: 0x1C7AAE0 Offset: 0x1C7ABE1 VA: 0x1C7AAE0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, object>>
	|
	|-RVA: 0x1C7AB40 Offset: 0x1C7AC41 VA: 0x1C7AB40
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, Playable>>
	|
	|-RVA: 0x1C7ABA0 Offset: 0x1C7ACA1 VA: 0x1C7ABA0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, ResourceLocator>>
	|
	|-RVA: 0x1C7AC00 Offset: 0x1C7AD01 VA: 0x1C7AC00
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, float>>
	|
	|-RVA: 0x1C7AC60 Offset: 0x1C7AD61 VA: 0x1C7AC60
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, ushort>>
	|
	|-RVA: 0x1C7ACC0 Offset: 0x1C7ADC1 VA: 0x1C7ACC0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<object, GameVariable.Value>>
	|
	|-RVA: 0x1C7AD20 Offset: 0x1C7AE21 VA: 0x1C7AD20
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<sbyte, DataStoreRatingInfo>>
	|
	|-RVA: 0x1C7AD80 Offset: 0x1C7AE81 VA: 0x1C7AD80
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<sbyte, object>>
	|
	|-RVA: 0x1C7ADE0 Offset: 0x1C7AEE1 VA: 0x1C7ADE0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<ushort, int>>
	|
	|-RVA: 0x1C7AE40 Offset: 0x1C7AF41 VA: 0x1C7AE40
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<uint, int>>
	|
	|-RVA: 0x1C7AEA0 Offset: 0x1C7AFA1 VA: 0x1C7AEA0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<uint, object>>
	|
	|-RVA: 0x1C7AF00 Offset: 0x1C7B001 VA: 0x1C7AF00
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<ulong, Friend>>
	|
	|-RVA: 0x1C7AF60 Offset: 0x1C7B061 VA: 0x1C7AF60
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<ulong, Int32Enum>>
	|
	|-RVA: 0x1C7AFC0 Offset: 0x1C7B0C1 VA: 0x1C7AFC0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<ulong, object>>
	|
	|-RVA: 0x1C7B020 Offset: 0x1C7B121 VA: 0x1C7B020
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<Vector3, int>>
	|
	|-RVA: 0x1C7B080 Offset: 0x1C7B181 VA: 0x1C7B080
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<XPathNodeRef, XPathNodeRef>>
	|
	|-RVA: 0x1C7B0E0 Offset: 0x1C7B1E1 VA: 0x1C7B0E0
	|-Array.InternalArray__ICollection_Remove<KeyValuePair<TerrainUtility.TerrainMap.TileCoord, object>>
	|
	|-RVA: 0x1C7B140 Offset: 0x1C7B241 VA: 0x1C7B140
	|-Array.InternalArray__ICollection_Remove<NativeArray<PreTile>>
	|
	|-RVA: 0x1C7B1A0 Offset: 0x1C7B2A1 VA: 0x1C7B1A0
	|-Array.InternalArray__ICollection_Remove<CommonBattleSequence.Reliance<object>>
	|
	|-RVA: 0x1C7B200 Offset: 0x1C7B301 VA: 0x1C7B200
	|-Array.InternalArray__ICollection_Remove<RenderGraphResourcePool.ResourceLogInfo<object>>
	|
	|-RVA: 0x1C7B260 Offset: 0x1C7B361 VA: 0x1C7B260
	|-Array.InternalArray__ICollection_Remove<HashSet.Slot<ValueTuple<object, int>>>
	|
	|-RVA: 0x1C7B2C0 Offset: 0x1C7B3C1 VA: 0x1C7B2C0
	|-Array.InternalArray__ICollection_Remove<HashSet.Slot<AsyncOperationHandle>>
	|
	|-RVA: 0x1C7B320 Offset: 0x1C7B421 VA: 0x1C7B320
	|-Array.InternalArray__ICollection_Remove<HashSet.Slot<int>>
	|
	|-RVA: 0x1C7B380 Offset: 0x1C7B481 VA: 0x1C7B380
	|-Array.InternalArray__ICollection_Remove<HashSet.Slot<Int32Enum>>
	|
	|-RVA: 0x1C7B3E0 Offset: 0x1C7B4E1 VA: 0x1C7B3E0
	|-Array.InternalArray__ICollection_Remove<Set.Slot<Int32Enum>>
	|
	|-RVA: 0x1C7B440 Offset: 0x1C7B541 VA: 0x1C7B440
	|-Array.InternalArray__ICollection_Remove<HashSet.Slot<MapPos>>
	|
	|-RVA: 0x1C7B4A0 Offset: 0x1C7B5A1 VA: 0x1C7B4A0
	|-Array.InternalArray__ICollection_Remove<HashSet.Slot<object>>
	|
	|-RVA: 0x1C7B500 Offset: 0x1C7B601 VA: 0x1C7B500
	|-Array.InternalArray__ICollection_Remove<Set.Slot<object>>
	|
	|-RVA: 0x1C7B560 Offset: 0x1C7B661 VA: 0x1C7B560
	|-Array.InternalArray__ICollection_Remove<HashSet.Slot<uint>>
	|
	|-RVA: 0x1C7B5C0 Offset: 0x1C7B6C1 VA: 0x1C7B5C0
	|-Array.InternalArray__ICollection_Remove<HashSet.Slot<ulong>>
	|
	|-RVA: 0x1C7B620 Offset: 0x1C7B721 VA: 0x1C7B620
	|-Array.InternalArray__ICollection_Remove<Set.Slot<Vector3>>
	|
	|-RVA: 0x1C7B680 Offset: 0x1C7B781 VA: 0x1C7B680
	|-Array.InternalArray__ICollection_Remove<TMP_TextProcessingStack<Color32>>
	|
	|-RVA: 0x1C7B6E0 Offset: 0x1C7B7E1 VA: 0x1C7B6E0
	|-Array.InternalArray__ICollection_Remove<TMP_TextProcessingStack<HighlightState>>
	|
	|-RVA: 0x1C7B740 Offset: 0x1C7B841 VA: 0x1C7B740
	|-Array.InternalArray__ICollection_Remove<TMP_TextProcessingStack<int>>
	|
	|-RVA: 0x1C7B7A0 Offset: 0x1C7B8A1 VA: 0x1C7B7A0
	|-Array.InternalArray__ICollection_Remove<TMP_TextProcessingStack<Int32Enum>>
	|
	|-RVA: 0x1C7B800 Offset: 0x1C7B901 VA: 0x1C7B800
	|-Array.InternalArray__ICollection_Remove<TMP_TextProcessingStack<MaterialReference>>
	|
	|-RVA: 0x1C7B860 Offset: 0x1C7B961 VA: 0x1C7B860
	|-Array.InternalArray__ICollection_Remove<TMP_TextProcessingStack<object>>
	|
	|-RVA: 0x1C7B8C0 Offset: 0x1C7B9C1 VA: 0x1C7B8C0
	|-Array.InternalArray__ICollection_Remove<TMP_TextProcessingStack<float>>
	|
	|-RVA: 0x1C7B920 Offset: 0x1C7BA21 VA: 0x1C7B920
	|-Array.InternalArray__ICollection_Remove<TMP_TextProcessingStack<WordWrapState>>
	|
	|-RVA: 0x1C7B980 Offset: 0x1C7BA81 VA: 0x1C7B980
	|-Array.InternalArray__ICollection_Remove<TimeInterval<object>>
	|
	|-RVA: 0x1C7B9E0 Offset: 0x1C7BAE1 VA: 0x1C7B9E0
	|-Array.InternalArray__ICollection_Remove<Timestamped<object>>
	|
	|-RVA: 0x1C7BA40 Offset: 0x1C7BB41 VA: 0x1C7BA40
	|-Array.InternalArray__ICollection_Remove<UniTask<object>>
	|
	|-RVA: 0x1C7BAA0 Offset: 0x1C7BBA1 VA: 0x1C7BAA0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<ValueTuple<bool, object>>>
	|
	|-RVA: 0x1C7BB00 Offset: 0x1C7BC01 VA: 0x1C7BB00
	|-Array.InternalArray__ICollection_Remove<ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>
	|
	|-RVA: 0x1C7BB60 Offset: 0x1C7BC61 VA: 0x1C7BB60
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, UniTask<object>>>
	|
	|-RVA: 0x1C7BBC0 Offset: 0x1C7BCC1 VA: 0x1C7BBC0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>
	|
	|-RVA: 0x1C7BC20 Offset: 0x1C7BD21 VA: 0x1C7BC20
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>
	|
	|-RVA: 0x1C7BC80 Offset: 0x1C7BD81 VA: 0x1C7BC80
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>
	|
	|-RVA: 0x1C7BCE0 Offset: 0x1C7BDE1 VA: 0x1C7BCE0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>
	|
	|-RVA: 0x1C7BD40 Offset: 0x1C7BE41 VA: 0x1C7BD40
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>
	|
	|-RVA: 0x1C7BDA0 Offset: 0x1C7BEA1 VA: 0x1C7BDA0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>
	|
	|-RVA: 0x1C7BE00 Offset: 0x1C7BF01 VA: 0x1C7BE00
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>
	|
	|-RVA: 0x1C7BE60 Offset: 0x1C7BF61 VA: 0x1C7BE60
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>
	|
	|-RVA: 0x1C7BEC0 Offset: 0x1C7BFC1 VA: 0x1C7BEC0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>
	|
	|-RVA: 0x1C7BF20 Offset: 0x1C7C021 VA: 0x1C7BF20
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>
	|
	|-RVA: 0x1C7BF80 Offset: 0x1C7C081 VA: 0x1C7BF80
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>
	|
	|-RVA: 0x1C7BFE0 Offset: 0x1C7C0E1 VA: 0x1C7BFE0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x1C7C040 Offset: 0x1C7C141 VA: 0x1C7C040
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>
	|
	|-RVA: 0x1C7C0A0 Offset: 0x1C7C1A1 VA: 0x1C7C0A0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>
	|
	|-RVA: 0x1C7C100 Offset: 0x1C7C201 VA: 0x1C7C100
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>
	|
	|-RVA: 0x1C7C160 Offset: 0x1C7C261 VA: 0x1C7C160
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>
	|
	|-RVA: 0x1C7C1C0 Offset: 0x1C7C2C1 VA: 0x1C7C1C0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>
	|
	|-RVA: 0x1C7C220 Offset: 0x1C7C321 VA: 0x1C7C220
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>
	|
	|-RVA: 0x1C7C280 Offset: 0x1C7C381 VA: 0x1C7C280
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>
	|
	|-RVA: 0x1C7C2E0 Offset: 0x1C7C3E1 VA: 0x1C7C2E0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>
	|
	|-RVA: 0x1C7C340 Offset: 0x1C7C441 VA: 0x1C7C340
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>
	|
	|-RVA: 0x1C7C3A0 Offset: 0x1C7C4A1 VA: 0x1C7C3A0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>
	|
	|-RVA: 0x1C7C400 Offset: 0x1C7C501 VA: 0x1C7C400
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>
	|
	|-RVA: 0x1C7C460 Offset: 0x1C7C561 VA: 0x1C7C460
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>
	|
	|-RVA: 0x1C7C4C0 Offset: 0x1C7C5C1 VA: 0x1C7C4C0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>
	|
	|-RVA: 0x1C7C520 Offset: 0x1C7C621 VA: 0x1C7C520
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>
	|
	|-RVA: 0x1C7C580 Offset: 0x1C7C681 VA: 0x1C7C580
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>
	|
	|-RVA: 0x1C7C5E0 Offset: 0x1C7C6E1 VA: 0x1C7C5E0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>
	|
	|-RVA: 0x1C7C640 Offset: 0x1C7C741 VA: 0x1C7C640
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>
	|
	|-RVA: 0x1C7C6A0 Offset: 0x1C7C7A1 VA: 0x1C7C6A0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>
	|
	|-RVA: 0x1C7C700 Offset: 0x1C7C801 VA: 0x1C7C700
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>
	|
	|-RVA: 0x1C7C760 Offset: 0x1C7C861 VA: 0x1C7C760
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>
	|
	|-RVA: 0x1C7C7C0 Offset: 0x1C7C8C1 VA: 0x1C7C7C0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>
	|
	|-RVA: 0x1C7C820 Offset: 0x1C7C921 VA: 0x1C7C820
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>
	|
	|-RVA: 0x1C7C880 Offset: 0x1C7C981 VA: 0x1C7C880
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>
	|
	|-RVA: 0x1C7C8E0 Offset: 0x1C7C9E1 VA: 0x1C7C8E0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x1C7C940 Offset: 0x1C7CA41 VA: 0x1C7C940
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>
	|
	|-RVA: 0x1C7C9A0 Offset: 0x1C7CAA1 VA: 0x1C7C9A0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>
	|
	|-RVA: 0x1C7CA00 Offset: 0x1C7CB01 VA: 0x1C7CA00
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>
	|
	|-RVA: 0x1C7CA60 Offset: 0x1C7CB61 VA: 0x1C7CA60
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>
	|
	|-RVA: 0x1C7CAC0 Offset: 0x1C7CBC1 VA: 0x1C7CAC0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>
	|
	|-RVA: 0x1C7CB20 Offset: 0x1C7CC21 VA: 0x1C7CB20
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>
	|
	|-RVA: 0x1C7CB80 Offset: 0x1C7CC81 VA: 0x1C7CB80
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>
	|
	|-RVA: 0x1C7CBE0 Offset: 0x1C7CCE1 VA: 0x1C7CBE0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>
	|
	|-RVA: 0x1C7CC40 Offset: 0x1C7CD41 VA: 0x1C7CC40
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>
	|
	|-RVA: 0x1C7CCA0 Offset: 0x1C7CDA1 VA: 0x1C7CCA0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>
	|
	|-RVA: 0x1C7CD00 Offset: 0x1C7CE01 VA: 0x1C7CD00
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x1C7CD60 Offset: 0x1C7CE61 VA: 0x1C7CD60
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>
	|
	|-RVA: 0x1C7CDC0 Offset: 0x1C7CEC1 VA: 0x1C7CDC0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x1C7CE20 Offset: 0x1C7CF21 VA: 0x1C7CE20
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>
	|
	|-RVA: 0x1C7CE80 Offset: 0x1C7CF81 VA: 0x1C7CE80
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x1C7CEE0 Offset: 0x1C7CFE1 VA: 0x1C7CEE0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>
	|
	|-RVA: 0x1C7CF40 Offset: 0x1C7D041 VA: 0x1C7CF40
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x1C7CFA0 Offset: 0x1C7D0A1 VA: 0x1C7CFA0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>
	|
	|-RVA: 0x1C7D000 Offset: 0x1C7D101 VA: 0x1C7D000
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x1C7D060 Offset: 0x1C7D161 VA: 0x1C7D060
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>
	|
	|-RVA: 0x1C7D0C0 Offset: 0x1C7D1C1 VA: 0x1C7D0C0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>
	|
	|-RVA: 0x1C7D120 Offset: 0x1C7D221 VA: 0x1C7D120
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>
	|
	|-RVA: 0x1C7D180 Offset: 0x1C7D281 VA: 0x1C7D180
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>
	|
	|-RVA: 0x1C7D1E0 Offset: 0x1C7D2E1 VA: 0x1C7D1E0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>
	|
	|-RVA: 0x1C7D240 Offset: 0x1C7D341 VA: 0x1C7D240
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>
	|
	|-RVA: 0x1C7D2A0 Offset: 0x1C7D3A1 VA: 0x1C7D2A0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>
	|
	|-RVA: 0x1C7D300 Offset: 0x1C7D401 VA: 0x1C7D300
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>
	|
	|-RVA: 0x1C7D360 Offset: 0x1C7D461 VA: 0x1C7D360
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>
	|
	|-RVA: 0x1C7D3C0 Offset: 0x1C7D4C1 VA: 0x1C7D3C0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x1C7D420 Offset: 0x1C7D521 VA: 0x1C7D420
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>
	|
	|-RVA: 0x1C7D480 Offset: 0x1C7D581 VA: 0x1C7D480
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>
	|
	|-RVA: 0x1C7D4E0 Offset: 0x1C7D5E1 VA: 0x1C7D4E0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>
	|
	|-RVA: 0x1C7D540 Offset: 0x1C7D641 VA: 0x1C7D540
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>
	|
	|-RVA: 0x1C7D5A0 Offset: 0x1C7D6A1 VA: 0x1C7D5A0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>
	|
	|-RVA: 0x1C7D600 Offset: 0x1C7D701 VA: 0x1C7D600
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>
	|
	|-RVA: 0x1C7D660 Offset: 0x1C7D761 VA: 0x1C7D660
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>
	|
	|-RVA: 0x1C7D6C0 Offset: 0x1C7D7C1 VA: 0x1C7D6C0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>
	|
	|-RVA: 0x1C7D720 Offset: 0x1C7D821 VA: 0x1C7D720
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>
	|
	|-RVA: 0x1C7D780 Offset: 0x1C7D881 VA: 0x1C7D780
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>
	|
	|-RVA: 0x1C7D7E0 Offset: 0x1C7D8E1 VA: 0x1C7D7E0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x1C7D840 Offset: 0x1C7D941 VA: 0x1C7D840
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>
	|
	|-RVA: 0x1C7D8A0 Offset: 0x1C7D9A1 VA: 0x1C7D8A0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x1C7D900 Offset: 0x1C7DA01 VA: 0x1C7D900
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>
	|
	|-RVA: 0x1C7D960 Offset: 0x1C7DA61 VA: 0x1C7D960
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x1C7D9C0 Offset: 0x1C7DAC1 VA: 0x1C7D9C0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>
	|
	|-RVA: 0x1C7DA20 Offset: 0x1C7DB21 VA: 0x1C7DA20
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x1C7DA80 Offset: 0x1C7DB81 VA: 0x1C7DA80
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>
	|
	|-RVA: 0x1C7DAE0 Offset: 0x1C7DBE1 VA: 0x1C7DAE0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x1C7DB40 Offset: 0x1C7DC41 VA: 0x1C7DB40
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>
	|
	|-RVA: 0x1C7DBA0 Offset: 0x1C7DCA1 VA: 0x1C7DBA0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x1C7DC00 Offset: 0x1C7DD01 VA: 0x1C7DC00
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x1C7DC60 Offset: 0x1C7DD61 VA: 0x1C7DC60
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>
	|
	|-RVA: 0x1C7DCC0 Offset: 0x1C7DDC1 VA: 0x1C7DCC0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, bool>>>
	|
	|-RVA: 0x1C7DD20 Offset: 0x1C7DE21 VA: 0x1C7DD20
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, Bounds>>>
	|
	|-RVA: 0x1C7DD80 Offset: 0x1C7DE81 VA: 0x1C7DD80
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, byte>>>
	|
	|-RVA: 0x1C7DDE0 Offset: 0x1C7DEE1 VA: 0x1C7DDE0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, Color>>>
	|
	|-RVA: 0x1C7DE40 Offset: 0x1C7DF41 VA: 0x1C7DE40
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, double>>>
	|
	|-RVA: 0x1C7DEA0 Offset: 0x1C7DFA1 VA: 0x1C7DEA0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, int>>>
	|
	|-RVA: 0x1C7DF00 Offset: 0x1C7E001 VA: 0x1C7DF00
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, long>>>
	|
	|-RVA: 0x1C7DF60 Offset: 0x1C7E061 VA: 0x1C7DF60
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, object>>>
	|
	|-RVA: 0x1C7DFC0 Offset: 0x1C7E0C1 VA: 0x1C7DFC0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, Quaternion>>>
	|
	|-RVA: 0x1C7E020 Offset: 0x1C7E121 VA: 0x1C7E020
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, Rect>>>
	|
	|-RVA: 0x1C7E080 Offset: 0x1C7E181 VA: 0x1C7E080
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, float>>>
	|
	|-RVA: 0x1C7E0E0 Offset: 0x1C7E1E1 VA: 0x1C7E0E0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, UniTask>>>
	|
	|-RVA: 0x1C7E140 Offset: 0x1C7E241 VA: 0x1C7E140
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, Unit>>>
	|
	|-RVA: 0x1C7E1A0 Offset: 0x1C7E2A1 VA: 0x1C7E1A0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, Vector2>>>
	|
	|-RVA: 0x1C7E200 Offset: 0x1C7E301 VA: 0x1C7E200
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, Vector3>>>
	|
	|-RVA: 0x1C7E260 Offset: 0x1C7E361 VA: 0x1C7E260
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<bool, Vector4>>>
	|
	|-RVA: 0x1C7E2C0 Offset: 0x1C7E3C1 VA: 0x1C7E2C0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<int, object>>>
	|
	|-RVA: 0x1C7E320 Offset: 0x1C7E421 VA: 0x1C7E320
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<object, object>>>
	|
	|-RVA: 0x1C7E380 Offset: 0x1C7E481 VA: 0x1C7E380
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x1C7E3E0 Offset: 0x1C7E4E1 VA: 0x1C7E3E0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<object, object, object>>>
	|
	|-RVA: 0x1C7E440 Offset: 0x1C7E541 VA: 0x1C7E440
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x1C7E4A0 Offset: 0x1C7E5A1 VA: 0x1C7E4A0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<object, object, object, object>>>
	|
	|-RVA: 0x1C7E500 Offset: 0x1C7E601 VA: 0x1C7E500
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x1C7E560 Offset: 0x1C7E661 VA: 0x1C7E560
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>
	|
	|-RVA: 0x1C7E5C0 Offset: 0x1C7E6C1 VA: 0x1C7E5C0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x1C7E620 Offset: 0x1C7E721 VA: 0x1C7E620
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>
	|
	|-RVA: 0x1C7E680 Offset: 0x1C7E781 VA: 0x1C7E680
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x1C7E6E0 Offset: 0x1C7E7E1 VA: 0x1C7E6E0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>
	|
	|-RVA: 0x1C7E740 Offset: 0x1C7E841 VA: 0x1C7E740
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x1C7E7A0 Offset: 0x1C7E8A1 VA: 0x1C7E7A0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x1C7E800 Offset: 0x1C7E901 VA: 0x1C7E800
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, AsyncUnit>>
	|
	|-RVA: 0x1C7E860 Offset: 0x1C7E961 VA: 0x1C7E860
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, bool>>
	|
	|-RVA: 0x1C7E8C0 Offset: 0x1C7E9C1 VA: 0x1C7E8C0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, Bounds>>
	|
	|-RVA: 0x1C7E920 Offset: 0x1C7EA21 VA: 0x1C7E920
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, byte>>
	|
	|-RVA: 0x1C7E980 Offset: 0x1C7EA81 VA: 0x1C7E980
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, Color>>
	|
	|-RVA: 0x1C7E9E0 Offset: 0x1C7EAE1 VA: 0x1C7E9E0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, double>>
	|
	|-RVA: 0x1C7EA40 Offset: 0x1C7EB41 VA: 0x1C7EA40
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, int>>
	|
	|-RVA: 0x1C7EAA0 Offset: 0x1C7EBA1 VA: 0x1C7EAA0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, long>>
	|
	|-RVA: 0x1C7EB00 Offset: 0x1C7EC01 VA: 0x1C7EB00
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, object>>
	|
	|-RVA: 0x1C7EB60 Offset: 0x1C7EC61 VA: 0x1C7EB60
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, Quaternion>>
	|
	|-RVA: 0x1C7EBC0 Offset: 0x1C7ECC1 VA: 0x1C7EBC0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, Rect>>
	|
	|-RVA: 0x1C7EC20 Offset: 0x1C7ED21 VA: 0x1C7EC20
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, float>>
	|
	|-RVA: 0x1C7EC80 Offset: 0x1C7ED81 VA: 0x1C7EC80
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, UniTask>>
	|
	|-RVA: 0x1C7ECE0 Offset: 0x1C7EDE1 VA: 0x1C7ECE0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, Unit>>
	|
	|-RVA: 0x1C7ED40 Offset: 0x1C7EE41 VA: 0x1C7ED40
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, Vector2>>
	|
	|-RVA: 0x1C7EDA0 Offset: 0x1C7EEA1 VA: 0x1C7EDA0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, Vector3>>
	|
	|-RVA: 0x1C7EE00 Offset: 0x1C7EF01 VA: 0x1C7EE00
	|-Array.InternalArray__ICollection_Remove<ValueTuple<bool, Vector4>>
	|
	|-RVA: 0x1C7EE60 Offset: 0x1C7EF61 VA: 0x1C7EE60
	|-Array.InternalArray__ICollection_Remove<ValueTuple<int, bool>>
	|
	|-RVA: 0x1C7EEC0 Offset: 0x1C7EFC1 VA: 0x1C7EEC0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<int, Bounds>>
	|
	|-RVA: 0x1C7EF20 Offset: 0x1C7F021 VA: 0x1C7EF20
	|-Array.InternalArray__ICollection_Remove<ValueTuple<int, byte>>
	|
	|-RVA: 0x1C7EF80 Offset: 0x1C7F081 VA: 0x1C7EF80
	|-Array.InternalArray__ICollection_Remove<ValueTuple<int, Color>>
	|
	|-RVA: 0x1C7EFE0 Offset: 0x1C7F0E1 VA: 0x1C7EFE0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<int, double>>
	|
	|-RVA: 0x1C7F040 Offset: 0x1C7F141 VA: 0x1C7F040
	|-Array.InternalArray__ICollection_Remove<ValueTuple<int, int>>
	|
	|-RVA: 0x1C7F0A0 Offset: 0x1C7F1A1 VA: 0x1C7F0A0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<int, long>>
	|
	|-RVA: 0x1C7F100 Offset: 0x1C7F201 VA: 0x1C7F100
	|-Array.InternalArray__ICollection_Remove<ValueTuple<int, object>>
	|
	|-RVA: 0x1C7F160 Offset: 0x1C7F261 VA: 0x1C7F160
	|-Array.InternalArray__ICollection_Remove<ValueTuple<int, Quaternion>>
	|
	|-RVA: 0x1C7F1C0 Offset: 0x1C7F2C1 VA: 0x1C7F1C0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<int, Rect>>
	|
	|-RVA: 0x1C7F220 Offset: 0x1C7F321 VA: 0x1C7F220
	|-Array.InternalArray__ICollection_Remove<ValueTuple<int, float>>
	|
	|-RVA: 0x1C7F280 Offset: 0x1C7F381 VA: 0x1C7F280
	|-Array.InternalArray__ICollection_Remove<ValueTuple<int, Unit>>
	|
	|-RVA: 0x1C7F2E0 Offset: 0x1C7F3E1 VA: 0x1C7F2E0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<int, Vector2>>
	|
	|-RVA: 0x1C7F340 Offset: 0x1C7F441 VA: 0x1C7F340
	|-Array.InternalArray__ICollection_Remove<ValueTuple<int, Vector3>>
	|
	|-RVA: 0x1C7F3A0 Offset: 0x1C7F4A1 VA: 0x1C7F3A0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<int, Vector4>>
	|
	|-RVA: 0x1C7F400 Offset: 0x1C7F501 VA: 0x1C7F400
	|-Array.InternalArray__ICollection_Remove<ValueTuple<Int32Enum, int>>
	|
	|-RVA: 0x1C7F460 Offset: 0x1C7F561 VA: 0x1C7F460
	|-Array.InternalArray__ICollection_Remove<ValueTuple<object, ValueTuple<object, int>>>
	|
	|-RVA: 0x1C7F4C0 Offset: 0x1C7F5C1 VA: 0x1C7F4C0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<object, int>>
	|
	|-RVA: 0x1C7F520 Offset: 0x1C7F621 VA: 0x1C7F520
	|-Array.InternalArray__ICollection_Remove<ValueTuple<object, object>>
	|
	|-RVA: 0x1C7F580 Offset: 0x1C7F681 VA: 0x1C7F580
	|-Array.InternalArray__ICollection_Remove<ValueTuple<object, float>>
	|
	|-RVA: 0x1C7F5E0 Offset: 0x1C7F6E1 VA: 0x1C7F5E0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<Vector3, float>>
	|
	|-RVA: 0x1C7F640 Offset: 0x1C7F741 VA: 0x1C7F640
	|-Array.InternalArray__ICollection_Remove<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>
	|
	|-RVA: 0x1C7F6A0 Offset: 0x1C7F7A1 VA: 0x1C7F6A0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<object, Int32Enum, int>>
	|
	|-RVA: 0x1C7F700 Offset: 0x1C7F801 VA: 0x1C7F700
	|-Array.InternalArray__ICollection_Remove<ValueTuple<object, object, object>>
	|
	|-RVA: 0x1C7F760 Offset: 0x1C7F861 VA: 0x1C7F760
	|-Array.InternalArray__ICollection_Remove<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>
	|
	|-RVA: 0x1C7F7C0 Offset: 0x1C7F8C1 VA: 0x1C7F7C0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<object, int, int, int>>
	|
	|-RVA: 0x1C7F820 Offset: 0x1C7F921 VA: 0x1C7F820
	|-Array.InternalArray__ICollection_Remove<ValueTuple<object, object, object, object>>
	|
	|-RVA: 0x1C7F880 Offset: 0x1C7F981 VA: 0x1C7F880
	|-Array.InternalArray__ICollection_Remove<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>
	|
	|-RVA: 0x1C7F8E0 Offset: 0x1C7F9E1 VA: 0x1C7F8E0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<object, object, object, object, object>>
	|
	|-RVA: 0x1C7F940 Offset: 0x1C7FA41 VA: 0x1C7F940
	|-Array.InternalArray__ICollection_Remove<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>
	|
	|-RVA: 0x1C7F9A0 Offset: 0x1C7FAA1 VA: 0x1C7F9A0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<object, object, object, object, object, object>>
	|
	|-RVA: 0x1C7FA00 Offset: 0x1C7FB01 VA: 0x1C7FA00
	|-Array.InternalArray__ICollection_Remove<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>
	|
	|-RVA: 0x1C7FA60 Offset: 0x1C7FB61 VA: 0x1C7FA60
	|-Array.InternalArray__ICollection_Remove<ValueTuple<object, object, object, object, object, object, object>>
	|
	|-RVA: 0x1C7FAC0 Offset: 0x1C7FBC1 VA: 0x1C7FAC0
	|-Array.InternalArray__ICollection_Remove<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>
	|
	|-RVA: 0x1C7FB20 Offset: 0x1C7FC21 VA: 0x1C7FB20
	|-Array.InternalArray__ICollection_Remove<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x1C7FB80 Offset: 0x1C7FC81 VA: 0x1C7FB80
	|-Array.InternalArray__ICollection_Remove<AnimatorClipInfo>
	|
	|-RVA: 0x1C7FBE0 Offset: 0x1C7FCE1 VA: 0x1C7FBE0
	|-Array.InternalArray__ICollection_Remove<AsyncOperationHandle>
	|
	|-RVA: 0x1C7FC40 Offset: 0x1C7FD41 VA: 0x1C7FC40
	|-Array.InternalArray__ICollection_Remove<AsyncUnit>
	|
	|-RVA: 0x1C7FCA0 Offset: 0x1C7FDA1 VA: 0x1C7FCA0
	|-Array.InternalArray__ICollection_Remove<BatchVisibility>
	|
	|-RVA: 0x1C7FD00 Offset: 0x1C7FE01 VA: 0x1C7FD00
	|-Array.InternalArray__ICollection_Remove<BoneWeight>
	|
	|-RVA: 0x1C7FD60 Offset: 0x1C7FE61 VA: 0x1C7FD60
	|-Array.InternalArray__ICollection_Remove<BoneWeight1>
	|
	|-RVA: 0x1C7FDC0 Offset: 0x1C7FEC1 VA: 0x1C7FDC0
	|-Array.InternalArray__ICollection_Remove<bool>
	|
	|-RVA: 0x1C7FE20 Offset: 0x1C7FF21 VA: 0x1C7FE20
	|-Array.InternalArray__ICollection_Remove<Bounds>
	|
	|-RVA: 0x1C7FE80 Offset: 0x1C7FF81 VA: 0x1C7FE80
	|-Array.InternalArray__ICollection_Remove<byte>
	|
	|-RVA: 0x1C7FEE0 Offset: 0x1C7FFE1 VA: 0x1C7FEE0
	|-Array.InternalArray__ICollection_Remove<ByteEnum>
	|
	|-RVA: 0x1C7FF40 Offset: 0x1C80041 VA: 0x1C7FF40
	|-Array.InternalArray__ICollection_Remove<CameraInfo>
	|
	|-RVA: 0x1C7FFA0 Offset: 0x1C800A1 VA: 0x1C7FFA0
	|-Array.InternalArray__ICollection_Remove<CancellationToken>
	|
	|-RVA: 0x1C80000 Offset: 0x1C80101 VA: 0x1C80000
	|-Array.InternalArray__ICollection_Remove<CancellationTokenRegistration>
	|
	|-RVA: 0x1C80060 Offset: 0x1C80161 VA: 0x1C80060
	|-Array.InternalArray__ICollection_Remove<char>
	|
	|-RVA: 0x1C800C0 Offset: 0x1C801C1 VA: 0x1C800C0
	|-Array.InternalArray__ICollection_Remove<ClusteringData>
	|
	|-RVA: 0x1C80120 Offset: 0x1C80221 VA: 0x1C80120
	|-Array.InternalArray__ICollection_Remove<ClusteringProcessorState>
	|
	|-RVA: 0x1C80180 Offset: 0x1C80281 VA: 0x1C80180
	|-Array.InternalArray__ICollection_Remove<Color>
	|
	|-RVA: 0x1C801E0 Offset: 0x1C802E1 VA: 0x1C801E0
	|-Array.InternalArray__ICollection_Remove<Color32>
	|
	|-RVA: 0x1C80240 Offset: 0x1C80341 VA: 0x1C80240
	|-Array.InternalArray__ICollection_Remove<Color4u8>
	|
	|-RVA: 0x1C802A0 Offset: 0x1C803A1 VA: 0x1C802A0
	|-Array.InternalArray__ICollection_Remove<ColorBlock>
	|
	|-RVA: 0x1C80300 Offset: 0x1C80401 VA: 0x1C80300
	|-Array.InternalArray__ICollection_Remove<CombineInstance>
	|
	|-RVA: 0x1C80360 Offset: 0x1C80461 VA: 0x1C80360
	|-Array.InternalArray__ICollection_Remove<ConstraintSource>
	|
	|-RVA: 0x1C803C0 Offset: 0x1C804C1 VA: 0x1C803C0
	|-Array.InternalArray__ICollection_Remove<ContactPoint>
	|
	|-RVA: 0x1C80420 Offset: 0x1C80521 VA: 0x1C80420
	|-Array.InternalArray__ICollection_Remove<ContactPoint2D>
	|
	|-RVA: 0x1C80480 Offset: 0x1C80581 VA: 0x1C80480
	|-Array.InternalArray__ICollection_Remove<ContourVertex>
	|
	|-RVA: 0x1C804E0 Offset: 0x1C805E1 VA: 0x1C804E0
	|-Array.InternalArray__ICollection_Remove<CustomAttributeNamedArgument>
	|
	|-RVA: 0x1C80540 Offset: 0x1C80641 VA: 0x1C80540
	|-Array.InternalArray__ICollection_Remove<CustomAttributeTypedArgument>
	|
	|-RVA: 0x1C805A0 Offset: 0x1C806A1 VA: 0x1C805A0
	|-Array.InternalArray__ICollection_Remove<DataStoreRatingInfo>
	|
	|-RVA: 0x1C80600 Offset: 0x1C80701 VA: 0x1C80600
	|-Array.InternalArray__ICollection_Remove<DataStoreResult>
	|
	|-RVA: 0x1C80660 Offset: 0x1C80761 VA: 0x1C80660
	|-Array.InternalArray__ICollection_Remove<DateTime>
	|
	|-RVA: 0x1C806C0 Offset: 0x1C807C1 VA: 0x1C806C0
	|-Array.InternalArray__ICollection_Remove<DateTimeOffset>
	|
	|-RVA: 0x1C80720 Offset: 0x1C80821 VA: 0x1C80720
	|-Array.InternalArray__ICollection_Remove<DebugPadState>
	|
	|-RVA: 0x1C80780 Offset: 0x1C80881 VA: 0x1C80780
	|-Array.InternalArray__ICollection_Remove<Decimal>
	|
	|-RVA: 0x1C807E0 Offset: 0x1C808E1 VA: 0x1C807E0
	|-Array.InternalArray__ICollection_Remove<DeferredTiler>
	|
	|-RVA: 0x1C80840 Offset: 0x1C80941 VA: 0x1C80840
	|-Array.InternalArray__ICollection_Remove<DeviceHandle>
	|
	|-RVA: 0x1C808A0 Offset: 0x1C809A1 VA: 0x1C808A0
	|-Array.InternalArray__ICollection_Remove<DiagnosticEvent>
	|
	|-RVA: 0x1C80900 Offset: 0x1C80A01 VA: 0x1C80900
	|-Array.InternalArray__ICollection_Remove<DictionaryEntry>
	|
	|-RVA: 0x1C80960 Offset: 0x1C80A61 VA: 0x1C80960
	|-Array.InternalArray__ICollection_Remove<DictionaryInfo>
	|
	|-RVA: 0x1C809C0 Offset: 0x1C80AC1 VA: 0x1C809C0
	|-Array.InternalArray__ICollection_Remove<DirectoryEntry>
	|
	|-RVA: 0x1C80A20 Offset: 0x1C80B21 VA: 0x1C80A20
	|-Array.InternalArray__ICollection_Remove<double>
	|
	|-RVA: 0x1C80A80 Offset: 0x1C80B81 VA: 0x1C80A80
	|-Array.InternalArray__ICollection_Remove<Ephemeron>
	|
	|-RVA: 0x1C80AE0 Offset: 0x1C80BE1 VA: 0x1C80AE0
	|-Array.InternalArray__ICollection_Remove<FXZ>
	|
	|-RVA: 0x1C80B40 Offset: 0x1C80C41 VA: 0x1C80B40
	|-Array.InternalArray__ICollection_Remove<Finger>
	|
	|-RVA: 0x1C80BA0 Offset: 0x1C80CA1 VA: 0x1C80BA0
	|-Array.InternalArray__ICollection_Remove<Float2>
	|
	|-RVA: 0x1C80C00 Offset: 0x1C80D01 VA: 0x1C80C00
	|-Array.InternalArray__ICollection_Remove<Friend>
	|
	|-RVA: 0x1C80C60 Offset: 0x1C80D61 VA: 0x1C80C60
	|-Array.InternalArray__ICollection_Remove<GCHandle>
	|
	|-RVA: 0x1C80CC0 Offset: 0x1C80DC1 VA: 0x1C80CC0
	|-Array.InternalArray__ICollection_Remove<GesturePoint>
	|
	|-RVA: 0x1C80D20 Offset: 0x1C80E21 VA: 0x1C80D20
	|-Array.InternalArray__ICollection_Remove<GestureState>
	|
	|-RVA: 0x1C80D80 Offset: 0x1C80E81 VA: 0x1C80D80
	|-Array.InternalArray__ICollection_Remove<GlyphMarshallingStruct>
	|
	|-RVA: 0x1C80DE0 Offset: 0x1C80EE1 VA: 0x1C80DE0
	|-Array.InternalArray__ICollection_Remove<GlyphPairAdjustmentRecord>
	|
	|-RVA: 0x1C80E40 Offset: 0x1C80F41 VA: 0x1C80E40
	|-Array.InternalArray__ICollection_Remove<GlyphRect>
	|
	|-RVA: 0x1C80EA0 Offset: 0x1C80FA1 VA: 0x1C80EA0
	|-Array.InternalArray__ICollection_Remove<Guid>
	|
	|-RVA: 0x1C80F00 Offset: 0x1C81001 VA: 0x1C80F00
	|-Array.InternalArray__ICollection_Remove<Hand>
	|
	|-RVA: 0x1C80F60 Offset: 0x1C81061 VA: 0x1C80F60
	|-Array.InternalArray__ICollection_Remove<HandAnalysisImageState>
	|
	|-RVA: 0x1C80FC0 Offset: 0x1C810C1 VA: 0x1C80FC0
	|-Array.InternalArray__ICollection_Remove<HandAnalysisSilhouetteState>
	|
	|-RVA: 0x1C81020 Offset: 0x1C81121 VA: 0x1C81020
	|-Array.InternalArray__ICollection_Remove<HeaderVariantInfo>
	|
	|-RVA: 0x1C81080 Offset: 0x1C81181 VA: 0x1C81080
	|-Array.InternalArray__ICollection_Remove<HighlightState>
	|
	|-RVA: 0x1C810E0 Offset: 0x1C811E1 VA: 0x1C810E0
	|-Array.InternalArray__ICollection_Remove<HumanBone>
	|
	|-RVA: 0x1C81140 Offset: 0x1C81241 VA: 0x1C81140
	|-Array.InternalArray__ICollection_Remove<short>
	|
	|-RVA: 0x1C811A0 Offset: 0x1C812A1 VA: 0x1C811A0
	|-Array.InternalArray__ICollection_Remove<int>
	|
	|-RVA: 0x1C81200 Offset: 0x1C81301 VA: 0x1C81200
	|-Array.InternalArray__ICollection_Remove<Int32Enum>
	|
	|-RVA: 0x1C81260 Offset: 0x1C81361 VA: 0x1C81260
	|-Array.InternalArray__ICollection_Remove<long>
	|
	|-RVA: 0x1C812C0 Offset: 0x1C813C1 VA: 0x1C812C0
	|-Array.InternalArray__ICollection_Remove<Int64Enum>
	|
	|-RVA: 0x1C81320 Offset: 0x1C81421 VA: 0x1C81320
	|-Array.InternalArray__ICollection_Remove<IntPtr>
	|
	|-RVA: 0x1C81380 Offset: 0x1C81481 VA: 0x1C81380
	|-Array.InternalArray__ICollection_Remove<InternalCodePageDataItem>
	|
	|-RVA: 0x1C813E0 Offset: 0x1C814E1 VA: 0x1C813E0
	|-Array.InternalArray__ICollection_Remove<InternalEncodingDataItem>
	|
	|-RVA: 0x1C81440 Offset: 0x1C81541 VA: 0x1C81440
	|-Array.InternalArray__ICollection_Remove<InterpretedFrameInfo>
	|
	|-RVA: 0x1C814A0 Offset: 0x1C815A1 VA: 0x1C814A0
	|-Array.InternalArray__ICollection_Remove<IntervalTreeNode>
	|
	|-RVA: 0x1C81500 Offset: 0x1C81601 VA: 0x1C81500
	|-Array.InternalArray__ICollection_Remove<JobHandle>
	|
	|-RVA: 0x1C81560 Offset: 0x1C81661 VA: 0x1C81560
	|-Array.InternalArray__ICollection_Remove<Keyframe>
	|
	|-RVA: 0x1C815C0 Offset: 0x1C816C1 VA: 0x1C815C0
	|-Array.InternalArray__ICollection_Remove<LOD>
	|
	|-RVA: 0x1C81620 Offset: 0x1C81721 VA: 0x1C81620
	|-Array.InternalArray__ICollection_Remove<LayerMask>
	|
	|-RVA: 0x1C81680 Offset: 0x1C81781 VA: 0x1C81680
	|-Array.InternalArray__ICollection_Remove<LengthLimitProperties>
	|
	|-RVA: 0x1C816E0 Offset: 0x1C817E1 VA: 0x1C816E0
	|-Array.InternalArray__ICollection_Remove<Light2DBlendStyle>
	|
	|-RVA: 0x1C81740 Offset: 0x1C81841 VA: 0x1C81740
	|-Array.InternalArray__ICollection_Remove<LightDataGI>
	|
	|-RVA: 0x1C817A0 Offset: 0x1C818A1 VA: 0x1C817A0
	|-Array.InternalArray__ICollection_Remove<LocalDefinition>
	|
	|-RVA: 0x1C81800 Offset: 0x1C81901 VA: 0x1C81800
	|-Array.InternalArray__ICollection_Remove<MapPos>
	|
	|-RVA: 0x1C81860 Offset: 0x1C81961 VA: 0x1C81860
	|-Array.InternalArray__ICollection_Remove<MapRange>
	|
	|-RVA: 0x1C818C0 Offset: 0x1C819C1 VA: 0x1C818C0
	|-Array.InternalArray__ICollection_Remove<MaterialReference>
	|
	|-RVA: 0x1C81920 Offset: 0x1C81A21 VA: 0x1C81920
	|-Array.InternalArray__ICollection_Remove<Matrix4x4>
	|
	|-RVA: 0x1C81980 Offset: 0x1C81A81 VA: 0x1C81980
	|-Array.InternalArray__ICollection_Remove<MomentProcessorState>
	|
	|-RVA: 0x1C819E0 Offset: 0x1C81AE1 VA: 0x1C819E0
	|-Array.InternalArray__ICollection_Remove<MomentStatistic>
	|
	|-RVA: 0x1C81A40 Offset: 0x1C81B41 VA: 0x1C81A40
	|-Array.InternalArray__ICollection_Remove<Navigation>
	|
	|-RVA: 0x1C81AA0 Offset: 0x1C81BA1 VA: 0x1C81AA0
	|-Array.InternalArray__ICollection_Remove<NetworkServiceAccountId>
	|
	|-RVA: 0x1C81B00 Offset: 0x1C81C01 VA: 0x1C81B00
	|-Array.InternalArray__ICollection_Remove<NpadFullKeyState>
	|
	|-RVA: 0x1C81B60 Offset: 0x1C81C61 VA: 0x1C81B60
	|-Array.InternalArray__ICollection_Remove<NpadHandheldState>
	|
	|-RVA: 0x1C81BC0 Offset: 0x1C81CC1 VA: 0x1C81BC0
	|-Array.InternalArray__ICollection_Remove<NpadJoyDualState>
	|
	|-RVA: 0x1C81C20 Offset: 0x1C81D21 VA: 0x1C81C20
	|-Array.InternalArray__ICollection_Remove<NpadJoyLeftState>
	|
	|-RVA: 0x1C81C80 Offset: 0x1C81D81 VA: 0x1C81C80
	|-Array.InternalArray__ICollection_Remove<NpadJoyRightState>
	|
	|-RVA: 0x1C81CE0 Offset: 0x1C81DE1 VA: 0x1C81CE0
	|-Array.InternalArray__ICollection_Remove<NpadStateArrayItem>
	|
	|-RVA: 0x1C81D40 Offset: 0x1C81E41 VA: 0x1C81D40
	|-Array.InternalArray__ICollection_Remove<NsUid>
	|
	|-RVA: 0x1C81DA0 Offset: 0x1C81EA1 VA: 0x1C81DA0
	|-Array.InternalArray__ICollection_Remove<object>
	|
	|-RVA: 0x1C81E00 Offset: 0x1C81F01 VA: 0x1C81E00
	|-Array.InternalArray__ICollection_Remove<ObjectInitializationData>
	|
	|-RVA: 0x1C81E60 Offset: 0x1C81F61 VA: 0x1C81E60
	|-Array.InternalArray__ICollection_Remove<ParameterModifier>
	|
	|-RVA: 0x1C81EC0 Offset: 0x1C81FC1 VA: 0x1C81EC0
	|-Array.InternalArray__ICollection_Remove<Plane>
	|
	|-RVA: 0x1C81F20 Offset: 0x1C82021 VA: 0x1C81F20
	|-Array.InternalArray__ICollection_Remove<Playable>
	|
	|-RVA: 0x1C81F80 Offset: 0x1C82081 VA: 0x1C81F80
	|-Array.InternalArray__ICollection_Remove<PlayableBinding>
	|
	|-RVA: 0x1C81FE0 Offset: 0x1C820E1 VA: 0x1C81FE0
	|-Array.InternalArray__ICollection_Remove<PlayerLoopSystem>
	|
	|-RVA: 0x1C82040 Offset: 0x1C82141 VA: 0x1C82040
	|-Array.InternalArray__ICollection_Remove<PlayerLoopSystemInternal>
	|
	|-RVA: 0x1C820A0 Offset: 0x1C821A1 VA: 0x1C820A0
	|-Array.InternalArray__ICollection_Remove<PreTile>
	|
	|-RVA: 0x1C82100 Offset: 0x1C82201 VA: 0x1C82100
	|-Array.InternalArray__ICollection_Remove<Profile>
	|
	|-RVA: 0x1C82160 Offset: 0x1C82261 VA: 0x1C82160
	|-Array.InternalArray__ICollection_Remove<Protrusion>
	|
	|-RVA: 0x1C821C0 Offset: 0x1C822C1 VA: 0x1C821C0
	|-Array.InternalArray__ICollection_Remove<Quaternion>
	|
	|-RVA: 0x1C82220 Offset: 0x1C82321 VA: 0x1C82220
	|-Array.InternalArray__ICollection_Remove<RandomSeed>
	|
	|-RVA: 0x1C82280 Offset: 0x1C82381 VA: 0x1C82280
	|-Array.InternalArray__ICollection_Remove<RangePositionInfo>
	|
	|-RVA: 0x1C822E0 Offset: 0x1C823E1 VA: 0x1C822E0
	|-Array.InternalArray__ICollection_Remove<Ranking2ChartInfoInput>
	|
	|-RVA: 0x1C82340 Offset: 0x1C82441 VA: 0x1C82340
	|-Array.InternalArray__ICollection_Remove<RaycastHit>
	|
	|-RVA: 0x1C823A0 Offset: 0x1C824A1 VA: 0x1C823A0
	|-Array.InternalArray__ICollection_Remove<RaycastHit2D>
	|
	|-RVA: 0x1C82400 Offset: 0x1C82501 VA: 0x1C82400
	|-Array.InternalArray__ICollection_Remove<RaycastResult>
	|
	|-RVA: 0x1C82460 Offset: 0x1C82561 VA: 0x1C82460
	|-Array.InternalArray__ICollection_Remove<Rect>
	|
	|-RVA: 0x1C824C0 Offset: 0x1C825C1 VA: 0x1C824C0
	|-Array.InternalArray__ICollection_Remove<RenderBuffer>
	|
	|-RVA: 0x1C82520 Offset: 0x1C82621 VA: 0x1C82520
	|-Array.InternalArray__ICollection_Remove<RenderStateBlock>
	|
	|-RVA: 0x1C82580 Offset: 0x1C82681 VA: 0x1C82580
	|-Array.InternalArray__ICollection_Remove<RenderTargetHandle>
	|
	|-RVA: 0x1C825E0 Offset: 0x1C826E1 VA: 0x1C825E0
	|-Array.InternalArray__ICollection_Remove<RenderTargetIdentifier>
	|
	|-RVA: 0x1C82640 Offset: 0x1C82741 VA: 0x1C82640
	|-Array.InternalArray__ICollection_Remove<RendererListHandle>
	|
	|-RVA: 0x1C826A0 Offset: 0x1C827A1 VA: 0x1C826A0
	|-Array.InternalArray__ICollection_Remove<ResourceHandle>
	|
	|-RVA: 0x1C82700 Offset: 0x1C82801 VA: 0x1C82700
	|-Array.InternalArray__ICollection_Remove<ResourceLocator>
	|
	|-RVA: 0x1C82760 Offset: 0x1C82861 VA: 0x1C82760
	|-Array.InternalArray__ICollection_Remove<RichTextTagAttribute>
	|
	|-RVA: 0x1C827C0 Offset: 0x1C828C1 VA: 0x1C827C0
	|-Array.InternalArray__ICollection_Remove<RuntimeLabel>
	|
	|-RVA: 0x1C82820 Offset: 0x1C82921 VA: 0x1C82820
	|-Array.InternalArray__ICollection_Remove<sbyte>
	|
	|-RVA: 0x1C82880 Offset: 0x1C82981 VA: 0x1C82880
	|-Array.InternalArray__ICollection_Remove<SerializedType>
	|
	|-RVA: 0x1C828E0 Offset: 0x1C829E1 VA: 0x1C828E0
	|-Array.InternalArray__ICollection_Remove<ShaderKeyword>
	|
	|-RVA: 0x1C82940 Offset: 0x1C82A41 VA: 0x1C82940
	|-Array.InternalArray__ICollection_Remove<ShaderTagId>
	|
	|-RVA: 0x1C829A0 Offset: 0x1C82AA1 VA: 0x1C829A0
	|-Array.InternalArray__ICollection_Remove<ShadowSliceData>
	|
	|-RVA: 0x1C82A00 Offset: 0x1C82B01 VA: 0x1C82A00
	|-Array.InternalArray__ICollection_Remove<Shape>
	|
	|-RVA: 0x1C82A60 Offset: 0x1C82B61 VA: 0x1C82A60
	|-Array.InternalArray__ICollection_Remove<float>
	|
	|-RVA: 0x1C82AC0 Offset: 0x1C82BC1 VA: 0x1C82AC0
	|-Array.InternalArray__ICollection_Remove<SixAxisSensorHandle>
	|
	|-RVA: 0x1C82B20 Offset: 0x1C82C21 VA: 0x1C82B20
	|-Array.InternalArray__ICollection_Remove<SixAxisSensorState>
	|
	|-RVA: 0x1C82B80 Offset: 0x1C82C81 VA: 0x1C82B80
	|-Array.InternalArray__ICollection_Remove<SkeletonBone>
	|
	|-RVA: 0x1C82BE0 Offset: 0x1C82CE1 VA: 0x1C82BE0
	|-Array.InternalArray__ICollection_Remove<SortingLayer>
	|
	|-RVA: 0x1C82C40 Offset: 0x1C82D41 VA: 0x1C82C40
	|-Array.InternalArray__ICollection_Remove<SphericalHarmonicsL2>
	|
	|-RVA: 0x1C82CA0 Offset: 0x1C82DA1 VA: 0x1C82CA0
	|-Array.InternalArray__ICollection_Remove<SpinLock>
	|
	|-RVA: 0x1C82D00 Offset: 0x1C82E01 VA: 0x1C82D00
	|-Array.InternalArray__ICollection_Remove<SpringBoneComponents>
	|
	|-RVA: 0x1C82D60 Offset: 0x1C82E61 VA: 0x1C82D60
	|-Array.InternalArray__ICollection_Remove<SpringBoneProperties>
	|
	|-RVA: 0x1C82DC0 Offset: 0x1C82EC1 VA: 0x1C82DC0
	|-Array.InternalArray__ICollection_Remove<SpringColliderComponents>
	|
	|-RVA: 0x1C82E20 Offset: 0x1C82F21 VA: 0x1C82E20
	|-Array.InternalArray__ICollection_Remove<SpringColliderProperties>
	|
	|-RVA: 0x1C82E80 Offset: 0x1C82F81 VA: 0x1C82E80
	|-Array.InternalArray__ICollection_Remove<SpringForceComponent>
	|
	|-RVA: 0x1C82EE0 Offset: 0x1C82FE1 VA: 0x1C82EE0
	|-Array.InternalArray__ICollection_Remove<SpringJobElement>
	|
	|-RVA: 0x1C82F40 Offset: 0x1C83041 VA: 0x1C82F40
	|-Array.InternalArray__ICollection_Remove<SpriteState>
	|
	|-RVA: 0x1C82FA0 Offset: 0x1C830A1 VA: 0x1C82FA0
	|-Array.InternalArray__ICollection_Remove<SubMeshDescriptor>
	|
	|-RVA: 0x1C83000 Offset: 0x1C83101 VA: 0x1C83000
	|-Array.InternalArray__ICollection_Remove<TMP_CharacterInfo>
	|
	|-RVA: 0x1C83060 Offset: 0x1C83161 VA: 0x1C83060
	|-Array.InternalArray__ICollection_Remove<TMP_FontWeightPair>
	|
	|-RVA: 0x1C830C0 Offset: 0x1C831C1 VA: 0x1C830C0
	|-Array.InternalArray__ICollection_Remove<TMP_LineInfo>
	|
	|-RVA: 0x1C83120 Offset: 0x1C83221 VA: 0x1C83120
	|-Array.InternalArray__ICollection_Remove<TMP_LinkInfo>
	|
	|-RVA: 0x1C83180 Offset: 0x1C83281 VA: 0x1C83180
	|-Array.InternalArray__ICollection_Remove<TMP_MeshInfo>
	|
	|-RVA: 0x1C831E0 Offset: 0x1C832E1 VA: 0x1C831E0
	|-Array.InternalArray__ICollection_Remove<TMP_PageInfo>
	|
	|-RVA: 0x1C83240 Offset: 0x1C83341 VA: 0x1C83240
	|-Array.InternalArray__ICollection_Remove<TMP_WordInfo>
	|
	|-RVA: 0x1C832A0 Offset: 0x1C833A1 VA: 0x1C832A0
	|-Array.InternalArray__ICollection_Remove<TablePair>
	|
	|-RVA: 0x1C83300 Offset: 0x1C83401 VA: 0x1C83300
	|-Array.InternalArray__ICollection_Remove<TextureHandle>
	|
	|-RVA: 0x1C83360 Offset: 0x1C83461 VA: 0x1C83360
	|-Array.InternalArray__ICollection_Remove<TimeSpan>
	|
	|-RVA: 0x1C833C0 Offset: 0x1C834C1 VA: 0x1C833C0
	|-Array.InternalArray__ICollection_Remove<Touch>
	|
	|-RVA: 0x1C83420 Offset: 0x1C83521 VA: 0x1C83420
	|-Array.InternalArray__ICollection_Remove<TouchScreenState1>
	|
	|-RVA: 0x1C83480 Offset: 0x1C83581 VA: 0x1C83480
	|-Array.InternalArray__ICollection_Remove<TouchScreenState10>
	|
	|-RVA: 0x1C834E0 Offset: 0x1C835E1 VA: 0x1C834E0
	|-Array.InternalArray__ICollection_Remove<TouchScreenState11>
	|
	|-RVA: 0x1C83540 Offset: 0x1C83641 VA: 0x1C83540
	|-Array.InternalArray__ICollection_Remove<TouchScreenState12>
	|
	|-RVA: 0x1C835A0 Offset: 0x1C836A1 VA: 0x1C835A0
	|-Array.InternalArray__ICollection_Remove<TouchScreenState13>
	|
	|-RVA: 0x1C83600 Offset: 0x1C83701 VA: 0x1C83600
	|-Array.InternalArray__ICollection_Remove<TouchScreenState14>
	|
	|-RVA: 0x1C83660 Offset: 0x1C83761 VA: 0x1C83660
	|-Array.InternalArray__ICollection_Remove<TouchScreenState15>
	|
	|-RVA: 0x1C836C0 Offset: 0x1C837C1 VA: 0x1C836C0
	|-Array.InternalArray__ICollection_Remove<TouchScreenState16>
	|
	|-RVA: 0x1C83720 Offset: 0x1C83821 VA: 0x1C83720
	|-Array.InternalArray__ICollection_Remove<TouchScreenState2>
	|
	|-RVA: 0x1C83780 Offset: 0x1C83881 VA: 0x1C83780
	|-Array.InternalArray__ICollection_Remove<TouchScreenState3>
	|
	|-RVA: 0x1C837E0 Offset: 0x1C838E1 VA: 0x1C837E0
	|-Array.InternalArray__ICollection_Remove<TouchScreenState4>
	|
	|-RVA: 0x1C83840 Offset: 0x1C83941 VA: 0x1C83840
	|-Array.InternalArray__ICollection_Remove<TouchScreenState5>
	|
	|-RVA: 0x1C838A0 Offset: 0x1C839A1 VA: 0x1C838A0
	|-Array.InternalArray__ICollection_Remove<TouchScreenState6>
	|
	|-RVA: 0x1C83900 Offset: 0x1C83A01 VA: 0x1C83900
	|-Array.InternalArray__ICollection_Remove<TouchScreenState7>
	|
	|-RVA: 0x1C83960 Offset: 0x1C83A61 VA: 0x1C83960
	|-Array.InternalArray__ICollection_Remove<TouchScreenState8>
	|
	|-RVA: 0x1C839C0 Offset: 0x1C83AC1 VA: 0x1C839C0
	|-Array.InternalArray__ICollection_Remove<TouchScreenState9>
	|
	|-RVA: 0x1C83A20 Offset: 0x1C83B21 VA: 0x1C83A20
	|-Array.InternalArray__ICollection_Remove<TouchState>
	|
	|-RVA: 0x1C83A80 Offset: 0x1C83B81 VA: 0x1C83A80
	|-Array.InternalArray__ICollection_Remove<TrailHand>
	|
	|-RVA: 0x1C83AE0 Offset: 0x1C83BE1 VA: 0x1C83AE0
	|-Array.InternalArray__ICollection_Remove<TrailVertex>
	|
	|-RVA: 0x1C83B40 Offset: 0x1C83C41 VA: 0x1C83B40
	|-Array.InternalArray__ICollection_Remove<UICharInfo>
	|
	|-RVA: 0x1C83BA0 Offset: 0x1C83CA1 VA: 0x1C83BA0
	|-Array.InternalArray__ICollection_Remove<UILineInfo>
	|
	|-RVA: 0x1C83C00 Offset: 0x1C83D01 VA: 0x1C83C00
	|-Array.InternalArray__ICollection_Remove<UIVertex>
	|
	|-RVA: 0x1C83C60 Offset: 0x1C83D61 VA: 0x1C83C60
	|-Array.InternalArray__ICollection_Remove<ushort>
	|
	|-RVA: 0x1C83CC0 Offset: 0x1C83DC1 VA: 0x1C83CC0
	|-Array.InternalArray__ICollection_Remove<UInt16Enum>
	|
	|-RVA: 0x1C83D20 Offset: 0x1C83E21 VA: 0x1C83D20
	|-Array.InternalArray__ICollection_Remove<uint>
	|
	|-RVA: 0x1C83D80 Offset: 0x1C83E81 VA: 0x1C83D80
	|-Array.InternalArray__ICollection_Remove<UInt32Enum>
	|
	|-RVA: 0x1C83DE0 Offset: 0x1C83EE1 VA: 0x1C83DE0
	|-Array.InternalArray__ICollection_Remove<ulong>
	|
	|-RVA: 0x1C83E40 Offset: 0x1C83F41 VA: 0x1C83E40
	|-Array.InternalArray__ICollection_Remove<Uid>
	|
	|-RVA: 0x1C83EA0 Offset: 0x1C83FA1 VA: 0x1C83EA0
	|-Array.InternalArray__ICollection_Remove<UniTask>
	|
	|-RVA: 0x1C83F00 Offset: 0x1C84001 VA: 0x1C83F00
	|-Array.InternalArray__ICollection_Remove<Unit>
	|
	|-RVA: 0x1C83F60 Offset: 0x1C84061 VA: 0x1C83F60
	|-Array.InternalArray__ICollection_Remove<UnitEnum>
	|
	|-RVA: 0x1C83FC0 Offset: 0x1C840C1 VA: 0x1C83FC0
	|-Array.InternalArray__ICollection_Remove<UserWord>
	|
	|-RVA: 0x1C84020 Offset: 0x1C84121 VA: 0x1C84020
	|-Array.InternalArray__ICollection_Remove<Vector2>
	|
	|-RVA: 0x1C84080 Offset: 0x1C84181 VA: 0x1C84080
	|-Array.InternalArray__ICollection_Remove<Vector2Int>
	|
	|-RVA: 0x1C840E0 Offset: 0x1C841E1 VA: 0x1C840E0
	|-Array.InternalArray__ICollection_Remove<Vector3>
	|
	|-RVA: 0x1C84140 Offset: 0x1C84241 VA: 0x1C84140
	|-Array.InternalArray__ICollection_Remove<Vector4>
	|
	|-RVA: 0x1C841A0 Offset: 0x1C842A1 VA: 0x1C841A0
	|-Array.InternalArray__ICollection_Remove<VertexAttributeDescriptor>
	|
	|-RVA: 0x1C84200 Offset: 0x1C84301 VA: 0x1C84200
	|-Array.InternalArray__ICollection_Remove<VibrationDeviceHandle>
	|
	|-RVA: 0x1C84260 Offset: 0x1C84361 VA: 0x1C84260
	|-Array.InternalArray__ICollection_Remove<VibrationDeviceInfo>
	|
	|-RVA: 0x1C842C0 Offset: 0x1C843C1 VA: 0x1C842C0
	|-Array.InternalArray__ICollection_Remove<VibrationValue>
	|
	|-RVA: 0x1C84320 Offset: 0x1C84421 VA: 0x1C84320
	|-Array.InternalArray__ICollection_Remove<VisibleLight>
	|
	|-RVA: 0x1C84380 Offset: 0x1C84481 VA: 0x1C84380
	|-Array.InternalArray__ICollection_Remove<WordWrapState>
	|
	|-RVA: 0x1C843E0 Offset: 0x1C844E1 VA: 0x1C843E0
	|-Array.InternalArray__ICollection_Remove<X509ChainStatus>
	|
	|-RVA: 0x1C84440 Offset: 0x1C84541 VA: 0x1C84440
	|-Array.InternalArray__ICollection_Remove<XPathNode>
	|
	|-RVA: 0x1C844A0 Offset: 0x1C845A1 VA: 0x1C844A0
	|-Array.InternalArray__ICollection_Remove<XPathNodeRef>
	|
	|-RVA: 0x1C84500 Offset: 0x1C84601 VA: 0x1C84500
	|-Array.InternalArray__ICollection_Remove<XRView>
	|
	|-RVA: 0x1C84560 Offset: 0x1C84661 VA: 0x1C84560
	|-Array.InternalArray__ICollection_Remove<float3>
	|
	|-RVA: 0x1C845C0 Offset: 0x1C846C1 VA: 0x1C845C0
	|-Array.InternalArray__ICollection_Remove<float4x4>
	|
	|-RVA: 0x1C84620 Offset: 0x1C84721 VA: 0x1C84620
	|-Array.InternalArray__ICollection_Remove<jvalue>
	|
	|-RVA: 0x1C84680 Offset: 0x1C84781 VA: 0x1C84680
	|-Array.InternalArray__ICollection_Remove<uint4>
	|
	|-RVA: 0x1C846E0 Offset: 0x1C847E1 VA: 0x1C846E0
	|-Array.InternalArray__ICollection_Remove<AICrossfire.PositionTable>
	|
	|-RVA: 0x1C84740 Offset: 0x1C84841 VA: 0x1C84740
	|-Array.InternalArray__ICollection_Remove<AIEnum.SkillRangeEnemyData>
	|
	|-RVA: 0x1C847A0 Offset: 0x1C848A1 VA: 0x1C847A0
	|-Array.InternalArray__ICollection_Remove<AIOrder.UnitPriority>
	|
	|-RVA: 0x1C84800 Offset: 0x1C84901 VA: 0x1C84800
	|-Array.InternalArray__ICollection_Remove<AmiiboSequence.GainItemData>
	|
	|-RVA: 0x1C84860 Offset: 0x1C84961 VA: 0x1C84860
	|-Array.InternalArray__ICollection_Remove<AnimationOutputWeightProcessor.WeightInfo>
	|
	|-RVA: 0x1C848C0 Offset: 0x1C849C1 VA: 0x1C848C0
	|-Array.InternalArray__ICollection_Remove<ArenaOrderSequence.GodInfo>
	|
	|-RVA: 0x1C84920 Offset: 0x1C84A21 VA: 0x1C84920
	|-Array.InternalArray__ICollection_Remove<BattleInfo.SupportData>
	|
	|-RVA: 0x1C84980 Offset: 0x1C84A81 VA: 0x1C84980
	|-Array.InternalArray__ICollection_Remove<BeforeRenderHelper.OrderBlock>
	|
	|-RVA: 0x1C849E0 Offset: 0x1C84AE1 VA: 0x1C849E0
	|-Array.InternalArray__ICollection_Remove<Camera.RenderRequest>
	|
	|-RVA: 0x1C84A40 Offset: 0x1C84B41 VA: 0x1C84A40
	|-Array.InternalArray__ICollection_Remove<CameraState.CustomBlendable>
	|
	|-RVA: 0x1C84AA0 Offset: 0x1C84BA1 VA: 0x1C84AA0
	|-Array.InternalArray__ICollection_Remove<CinemachineBlendListCamera.Instruction>
	|
	|-RVA: 0x1C84B00 Offset: 0x1C84C01 VA: 0x1C84B00
	|-Array.InternalArray__ICollection_Remove<CinemachineBlenderSettings.CustomBlend>
	|
	|-RVA: 0x1C84B60 Offset: 0x1C84C61 VA: 0x1C84B60
	|-Array.InternalArray__ICollection_Remove<CinemachineClearShot.Pair>
	|
	|-RVA: 0x1C84BC0 Offset: 0x1C84CC1 VA: 0x1C84BC0
	|-Array.InternalArray__ICollection_Remove<CinemachineFreeLook.Orbit>
	|
	|-RVA: 0x1C84C20 Offset: 0x1C84D21 VA: 0x1C84C20
	|-Array.InternalArray__ICollection_Remove<CinemachinePath.Waypoint>
	|
	|-RVA: 0x1C84C80 Offset: 0x1C84D81 VA: 0x1C84C80
	|-Array.InternalArray__ICollection_Remove<CinemachineSmoothPath.Waypoint>
	|
	|-RVA: 0x1C84CE0 Offset: 0x1C84DE1 VA: 0x1C84CE0
	|-Array.InternalArray__ICollection_Remove<CinemachineStateDrivenCamera.HashPair>
	|
	|-RVA: 0x1C84D40 Offset: 0x1C84E41 VA: 0x1C84D40
	|-Array.InternalArray__ICollection_Remove<CinemachineStateDrivenCamera.Instruction>
	|
	|-RVA: 0x1C84DA0 Offset: 0x1C84EA1 VA: 0x1C84DA0
	|-Array.InternalArray__ICollection_Remove<CinemachineStateDrivenCamera.ParentHash>
	|
	|-RVA: 0x1C84E00 Offset: 0x1C84F01 VA: 0x1C84E00
	|-Array.InternalArray__ICollection_Remove<CinemachineTargetGroup.Target>
	|
	|-RVA: 0x1C84E60 Offset: 0x1C84F61 VA: 0x1C84E60
	|-Array.InternalArray__ICollection_Remove<CodePointIndexer.TableRange>
	|
	|-RVA: 0x1C84EC0 Offset: 0x1C84FC1 VA: 0x1C84EC0
	|-Array.InternalArray__ICollection_Remove<ContentCatalogData.Bucket>
	|
	|-RVA: 0x1C84F20 Offset: 0x1C85021 VA: 0x1C84F20
	|-Array.InternalArray__ICollection_Remove<CookieTokenizer.RecognizedAttribute>
	|
	|-RVA: 0x1C84F80 Offset: 0x1C85081 VA: 0x1C84F80
	|-Array.InternalArray__ICollection_Remove<DeferredLights.DrawCall>
	|
	|-RVA: 0x1C84FE0 Offset: 0x1C850E1 VA: 0x1C84FE0
	|-Array.InternalArray__ICollection_Remove<DeferredShaderData.ComputeBufferInfo>
	|
	|-RVA: 0x1C85040 Offset: 0x1C85141 VA: 0x1C85040
	|-Array.InternalArray__ICollection_Remove<DeferredTiler.PrePunctualLight>
	|
	|-RVA: 0x1C850A0 Offset: 0x1C851A1 VA: 0x1C850A0
	|-Array.InternalArray__ICollection_Remove<DelayedActionManager.DelegateInfo>
	|
	|-RVA: 0x1C85100 Offset: 0x1C85201 VA: 0x1C85100
	|-Array.InternalArray__ICollection_Remove<Detail.AsyncResultInt>
	|
	|-RVA: 0x1C85160 Offset: 0x1C85261 VA: 0x1C85160
	|-Array.InternalArray__ICollection_Remove<Detail.CppArray>
	|
	|-RVA: 0x1C851C0 Offset: 0x1C852C1 VA: 0x1C851C0
	|-Array.InternalArray__ICollection_Remove<Detail.NotificationEventInt>
	|
	|-RVA: 0x1C85220 Offset: 0x1C85321 VA: 0x1C85220
	|-Array.InternalArray__ICollection_Remove<DisposUnit.Item>
	|
	|-RVA: 0x1C85280 Offset: 0x1C85381 VA: 0x1C85280
	|-Array.InternalArray__ICollection_Remove<DragonRidePresetParamData.CourseData>
	|
	|-RVA: 0x1C852E0 Offset: 0x1C853E1 VA: 0x1C852E0
	|-Array.InternalArray__ICollection_Remove<DragonRideTargetGroup.ChainParam>
	|
	|-RVA: 0x1C85340 Offset: 0x1C85441 VA: 0x1C85340
	|-Array.InternalArray__ICollection_Remove<DynamicMesh.State>
	|
	|-RVA: 0x1C853A0 Offset: 0x1C854A1 VA: 0x1C853A0
	|-Array.InternalArray__ICollection_Remove<FXZEx.HitPoint>
	|
	|-RVA: 0x1C85400 Offset: 0x1C85501 VA: 0x1C85400
	|-Array.InternalArray__ICollection_Remove<FishingRadicalParamData.RadicalParam>
	|
	|-RVA: 0x1C85460 Offset: 0x1C85561 VA: 0x1C85460
	|-Array.InternalArray__ICollection_Remove<GameVariable.Value>
	|
	|-RVA: 0x1C854C0 Offset: 0x1C855C1 VA: 0x1C854C0
	|-Array.InternalArray__ICollection_Remove<GmapPathAdjuster.TargetModel>
	|
	|-RVA: 0x1C85520 Offset: 0x1C85621 VA: 0x1C85520
	|-Array.InternalArray__ICollection_Remove<GmapSpotAdjuster.TargetModel>
	|
	|-RVA: 0x1C85580 Offset: 0x1C85681 VA: 0x1C85580
	|-Array.InternalArray__ICollection_Remove<GrounderQuadruped.Foot>
	|
	|-RVA: 0x1C855E0 Offset: 0x1C856E1 VA: 0x1C855E0
	|-Array.InternalArray__ICollection_Remove<Hashtable.bucket>
	|
	|-RVA: 0x1C85640 Offset: 0x1C85741 VA: 0x1C85640
	|-Array.InternalArray__ICollection_Remove<HeadingTracker.Item>
	|
	|-RVA: 0x1C856A0 Offset: 0x1C857A1 VA: 0x1C856A0
	|-Array.InternalArray__ICollection_Remove<HubAccessoryRoomCamera.BackgroundSettings>
	|
	|-RVA: 0x1C85700 Offset: 0x1C85801 VA: 0x1C85700
	|-Array.InternalArray__ICollection_Remove<HubFastTravel.Location>
	|
	|-RVA: 0x1C85760 Offset: 0x1C85861 VA: 0x1C85760
	|-Array.InternalArray__ICollection_Remove<HubLensFlare.Flare>
	|
	|-RVA: 0x1C857C0 Offset: 0x1C858C1 VA: 0x1C857C0
	|-Array.InternalArray__ICollection_Remove<HubLookAtController.LookAtIKParam>
	|
	|-RVA: 0x1C85820 Offset: 0x1C85921 VA: 0x1C85820
	|-Array.InternalArray__ICollection_Remove<HubMaterialArray.MaterialInfo>
	|
	|-RVA: 0x1C85880 Offset: 0x1C85981 VA: 0x1C85880
	|-Array.InternalArray__ICollection_Remove<IKSolverLimb.AxisDirection>
	|
	|-RVA: 0x1C858E0 Offset: 0x1C859E1 VA: 0x1C858E0
	|-Array.InternalArray__ICollection_Remove<InventoryPoolItemMenuContent.KindBgNameClass>
	|
	|-RVA: 0x1C85940 Offset: 0x1C85A41 VA: 0x1C85940
	|-Array.InternalArray__ICollection_Remove<LightUtility.ParametricLightMeshVertex>
	|
	|-RVA: 0x1C859A0 Offset: 0x1C85AA1 VA: 0x1C859A0
	|-Array.InternalArray__ICollection_Remove<LightUtility.SpriteLightMeshVertex>
	|
	|-RVA: 0x1C85A00 Offset: 0x1C85B01 VA: 0x1C85A00
	|-Array.InternalArray__ICollection_Remove<Map.Pos>
	|
	|-RVA: 0x1C85A60 Offset: 0x1C85B61 VA: 0x1C85A60
	|-Array.InternalArray__ICollection_Remove<MapGodExp.KindDesc>
	|
	|-RVA: 0x1C85AC0 Offset: 0x1C85BC1 VA: 0x1C85AC0
	|-Array.InternalArray__ICollection_Remove<MapHistory.Command>
	|
	|-RVA: 0x1C85B20 Offset: 0x1C85C21 VA: 0x1C85B20
	|-Array.InternalArray__ICollection_Remove<MapImage.BackupTerrain>
	|
	|-RVA: 0x1C85B80 Offset: 0x1C85C81 VA: 0x1C85B80
	|-Array.InternalArray__ICollection_Remove<MapImageRange.Pos>
	|
	|-RVA: 0x1C85BE0 Offset: 0x1C85CE1 VA: 0x1C85BE0
	|-Array.InternalArray__ICollection_Remove<MapKillBonus.KillBonus>
	|
	|-RVA: 0x1C85C40 Offset: 0x1C85D41 VA: 0x1C85C40
	|-Array.InternalArray__ICollection_Remove<MapKillBonus.KilledBonus>
	|
	|-RVA: 0x1C85CA0 Offset: 0x1C85DA1 VA: 0x1C85CA0
	|-Array.InternalArray__ICollection_Remove<MapMind.Record>
	|
	|-RVA: 0x1C85D00 Offset: 0x1C85E01 VA: 0x1C85D00
	|-Array.InternalArray__ICollection_Remove<MapMind.Target>
	|
	|-RVA: 0x1C85D60 Offset: 0x1C85E61 VA: 0x1C85D60
	|-Array.InternalArray__ICollection_Remove<MapPanelDebug.Entity>
	|
	|-RVA: 0x1C85DC0 Offset: 0x1C85EC1 VA: 0x1C85DC0
	|-Array.InternalArray__ICollection_Remove<NexRanking.Data>
	|
	|-RVA: 0x1C85E20 Offset: 0x1C85F21 VA: 0x1C85E20
	|-Array.InternalArray__ICollection_Remove<NexVersus.RatingData>
	|
	|-RVA: 0x1C85E80 Offset: 0x1C85F81 VA: 0x1C85E80
	|-Array.InternalArray__ICollection_Remove<NoiseSettings.TransformNoiseParams>
	|
	|-RVA: 0x1C85EE0 Offset: 0x1C85FE1 VA: 0x1C85EE0
	|-Array.InternalArray__ICollection_Remove<PackedPlayModeBuildLogs.RuntimeBuildLog>
	|
	|-RVA: 0x1C85F40 Offset: 0x1C86041 VA: 0x1C85F40
	|-Array.InternalArray__ICollection_Remove<ParameterizedStrings.FormatParam>
	|
	|-RVA: 0x1C85FA0 Offset: 0x1C860A1 VA: 0x1C85FA0
	|-Array.InternalArray__ICollection_Remove<ParticleSystem.Particle>
	|
	|-RVA: 0x1C86000 Offset: 0x1C86101 VA: 0x1C86000
	|-Array.InternalArray__ICollection_Remove<ProfileCard.Achievement>
	|
	|-RVA: 0x1C86060 Offset: 0x1C86161 VA: 0x1C86060
	|-Array.InternalArray__ICollection_Remove<ProfileCard.SortieCount>
	|
	|-RVA: 0x1C860C0 Offset: 0x1C861C1 VA: 0x1C860C0
	|-Array.InternalArray__ICollection_Remove<QualitySettingsStack.Settings>
	|
	|-RVA: 0x1C86120 Offset: 0x1C86221 VA: 0x1C86120
	|-Array.InternalArray__ICollection_Remove<RangeData.Offset>
	|
	|-RVA: 0x1C86180 Offset: 0x1C86281 VA: 0x1C86180
	|-Array.InternalArray__ICollection_Remove<RegexCharClass.LowerCaseMapping>
	|
	|-RVA: 0x1C861E0 Offset: 0x1C862E1 VA: 0x1C861E0
	|-Array.InternalArray__ICollection_Remove<Relay.ChooseAwardeeData>
	|
	|-RVA: 0x1C86240 Offset: 0x1C86341 VA: 0x1C86240
	|-Array.InternalArray__ICollection_Remove<RelayAwardData.Info>
	|
	|-RVA: 0x1C862A0 Offset: 0x1C863A1 VA: 0x1C862A0
	|-Array.InternalArray__ICollection_Remove<RenderGraph.CompiledPassInfo>
	|
	|-RVA: 0x1C86300 Offset: 0x1C86401 VA: 0x1C86300
	|-Array.InternalArray__ICollection_Remove<RenderGraph.CompiledResourceInfo>
	|
	|-RVA: 0x1C86360 Offset: 0x1C86461 VA: 0x1C86360
	|-Array.InternalArray__ICollection_Remove<RenderGraphDebugData.PassDebugData>
	|
	|-RVA: 0x1C863C0 Offset: 0x1C864C1 VA: 0x1C863C0
	|-Array.InternalArray__ICollection_Remove<RenderGraphDebugData.ResourceDebugData>
	|
	|-RVA: 0x1C86420 Offset: 0x1C86521 VA: 0x1C86420
	|-Array.InternalArray__ICollection_Remove<RenderGraphResourceRegistry.RendererListResource>
	|
	|-RVA: 0x1C86480 Offset: 0x1C86581 VA: 0x1C86480
	|-Array.InternalArray__ICollection_Remove<RingCleaningUnitSelectMenu.GodParam>
	|
	|-RVA: 0x1C864E0 Offset: 0x1C865E1 VA: 0x1C864E0
	|-Array.InternalArray__ICollection_Remove<SampleWave.Data>
	|
	|-RVA: 0x1C86540 Offset: 0x1C86641 VA: 0x1C86540
	|-Array.InternalArray__ICollection_Remove<SampleWave.Temp>
	|
	|-RVA: 0x1C865A0 Offset: 0x1C866A1 VA: 0x1C865A0
	|-Array.InternalArray__ICollection_Remove<SendMouseEvents.HitInfo>
	|
	|-RVA: 0x1C86600 Offset: 0x1C86701 VA: 0x1C86600
	|-Array.InternalArray__ICollection_Remove<SequenceNode.SequenceConstructPosContext>
	|
	|-RVA: 0x1C86660 Offset: 0x1C86761 VA: 0x1C86660
	|-Array.InternalArray__ICollection_Remove<ShaderInput.LightData>
	|
	|-RVA: 0x1C866C0 Offset: 0x1C867C1 VA: 0x1C866C0
	|-Array.InternalArray__ICollection_Remove<ShaderInput.ShadowData>
	|
	|-RVA: 0x1C86720 Offset: 0x1C86821 VA: 0x1C86720
	|-Array.InternalArray__ICollection_Remove<ShadowUtility.Edge>
	|
	|-RVA: 0x1C86780 Offset: 0x1C86881 VA: 0x1C86780
	|-Array.InternalArray__ICollection_Remove<SimpleAnimationPlayable.QueuedState>
	|
	|-RVA: 0x1C867E0 Offset: 0x1C868E1 VA: 0x1C867E0
	|-Array.InternalArray__ICollection_Remove<SkillArray.Entity>
	|
	|-RVA: 0x1C86840 Offset: 0x1C86941 VA: 0x1C86840
	|-Array.InternalArray__ICollection_Remove<Socket.WSABUF>
	|
	|-RVA: 0x1C868A0 Offset: 0x1C869A1 VA: 0x1C868A0
	|-Array.InternalArray__ICollection_Remove<Stream.Info>
	|
	|-RVA: 0x1C86900 Offset: 0x1C86A01 VA: 0x1C86900
	|-Array.InternalArray__ICollection_Remove<TMP_Text.UnicodeChar>
	|
	|-RVA: 0x1C86960 Offset: 0x1C86A61 VA: 0x1C86960
	|-Array.InternalArray__ICollection_Remove<TexturePacker_JsonArray.Frame>
	|
	|-RVA: 0x1C869C0 Offset: 0x1C86AC1 VA: 0x1C869C0
	|-Array.InternalArray__ICollection_Remove<TimeNotificationBehaviour.NotificationEntry>
	|
	|-RVA: 0x1C86A20 Offset: 0x1C86B21 VA: 0x1C86A20
	|-Array.InternalArray__ICollection_Remove<UnitySynchronizationContext.WorkRequest>
	|
	|-RVA: 0x1C86A80 Offset: 0x1C86B81 VA: 0x1C86A80
	|-Array.InternalArray__ICollection_Remove<XmlNamespaceManager.NamespaceDeclaration>
	|
	|-RVA: 0x1C86AE0 Offset: 0x1C86BE1 VA: 0x1C86AE0
	|-Array.InternalArray__ICollection_Remove<XmlSchemaObjectTable.XmlSchemaObjectEntry>
	|
	|-RVA: 0x1C86B40 Offset: 0x1C86C41 VA: 0x1C86B40
	|-Array.InternalArray__ICollection_Remove<XmlTextReaderImpl.ParsingState>
	|
	|-RVA: 0x1C86BA0 Offset: 0x1C86CA1 VA: 0x1C86BA0
	|-Array.InternalArray__ICollection_Remove<AIThink.EnchantThink.Desc>
	|
	|-RVA: 0x1C86C00 Offset: 0x1C86D01 VA: 0x1C86C00
	|-Array.InternalArray__ICollection_Remove<AIThink.EnchantThink.ItemInfo>
	|
	|-RVA: 0x1C86C60 Offset: 0x1C86D61 VA: 0x1C86C60
	|-Array.InternalArray__ICollection_Remove<AIThink.EnchantThink.SurroundingInfo>
	|
	|-RVA: 0x1C86CC0 Offset: 0x1C86DC1 VA: 0x1C86CC0
	|-Array.InternalArray__ICollection_Remove<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>
	|
	|-RVA: 0x1C86D20 Offset: 0x1C86E21 VA: 0x1C86D20
	|-Array.InternalArray__ICollection_Remove<Detail.DataStore.DataStoreChangeMetaParamInt>
	|
	|-RVA: 0x1C86D80 Offset: 0x1C86E81 VA: 0x1C86D80
	|-Array.InternalArray__ICollection_Remove<Detail.DataStore.DataStoreDeleteParamInt>
	|
	|-RVA: 0x1C86DE0 Offset: 0x1C86EE1 VA: 0x1C86DE0
	|-Array.InternalArray__ICollection_Remove<Detail.DataStore.DataStoreGetMetaParamInt>
	|
	|-RVA: 0x1C86E40 Offset: 0x1C86F41 VA: 0x1C86E40
	|-Array.InternalArray__ICollection_Remove<Detail.DataStore.DataStoreMetaInfoInt>
	|
	|-RVA: 0x1C86EA0 Offset: 0x1C86FA1 VA: 0x1C86EA0
	|-Array.InternalArray__ICollection_Remove<Detail.DataStore.DataStorePasswordInfoInt>
	|
	|-RVA: 0x1C86F00 Offset: 0x1C87001 VA: 0x1C86F00
	|-Array.InternalArray__ICollection_Remove<Detail.DataStore.DataStorePersistenceInfoInt>
	|
	|-RVA: 0x1C86F60 Offset: 0x1C87061 VA: 0x1C86F60
	|-Array.InternalArray__ICollection_Remove<Detail.DataStore.DataStorePreparePostParamInt>
	|
	|-RVA: 0x1C86FC0 Offset: 0x1C870C1 VA: 0x1C86FC0
	|-Array.InternalArray__ICollection_Remove<Detail.DataStore.DataStoreRateObjectParamInt>
	|
	|-RVA: 0x1C87020 Offset: 0x1C87121 VA: 0x1C87020
	|-Array.InternalArray__ICollection_Remove<Detail.DataStore.DataStoreRatingInitParamInt>
	|
	|-RVA: 0x1C87080 Offset: 0x1C87181 VA: 0x1C87080
	|-Array.InternalArray__ICollection_Remove<Detail.DataStore.DataStoreRatingTargetInt>
	|
	|-RVA: 0x1C870E0 Offset: 0x1C871E1 VA: 0x1C870E0
	|-Array.InternalArray__ICollection_Remove<Detail.Ranking.RankingCachedResultInt>
	|
	|-RVA: 0x1C87140 Offset: 0x1C87241 VA: 0x1C87140
	|-Array.InternalArray__ICollection_Remove<Detail.Ranking.RankingOrderParamInt>
	|
	|-RVA: 0x1C871A0 Offset: 0x1C872A1 VA: 0x1C871A0
	|-Array.InternalArray__ICollection_Remove<Detail.Ranking.RankingRankDataInt>
	|
	|-RVA: 0x1C87200 Offset: 0x1C87301 VA: 0x1C87200
	|-Array.InternalArray__ICollection_Remove<Detail.Ranking2.Ranking2ChartInfoInt>
	|
	|-RVA: 0x1C87260 Offset: 0x1C87361 VA: 0x1C87260
	|-Array.InternalArray__ICollection_Remove<Detail.Ranking2.Ranking2RankDataInt>
	|
	|-RVA: 0x1C872C0 Offset: 0x1C873C1 VA: 0x1C872C0
	|-Array.InternalArray__ICollection_Remove<Detail.Ranking2.Ranking2ScoreDataInt>
	|
	|-RVA: 0x1C87320 Offset: 0x1C87421 VA: 0x1C87320
	|-Array.InternalArray__ICollection_Remove<Detail.Screening.ScreeningContextInfoInt>
	|
	|-RVA: 0x1C87380 Offset: 0x1C87481 VA: 0x1C87380
	|-Array.InternalArray__ICollection_Remove<Detail.Subscriber.SubscriberContentInt>
	|
	|-RVA: 0x1C873E0 Offset: 0x1C874E1 VA: 0x1C873E0
	|-Array.InternalArray__ICollection_Remove<Detail.Subscriber.SubscriberGetContentParamInt>
	|
	|-RVA: 0x1C87440 Offset: 0x1C87541 VA: 0x1C87440
	|-Array.InternalArray__ICollection_Remove<Detail.Subscriber.SubscriberUserStatusInfoInt>
	|
	|-RVA: 0x1C874A0 Offset: 0x1C875A1 VA: 0x1C874A0
	|-Array.InternalArray__ICollection_Remove<Detail.Subscriber.SubscriberUserStatusParamInt>
	|
	|-RVA: 0x1C87500 Offset: 0x1C87601 VA: 0x1C87500
	|-Array.InternalArray__ICollection_Remove<Detail.Utility.IntegerSettings>
	|
	|-RVA: 0x1C87560 Offset: 0x1C87661 VA: 0x1C87560
	|-Array.InternalArray__ICollection_Remove<Detail.Utility.UniqueIdInfoInt>
	|
	|-RVA: 0x1C875C0 Offset: 0x1C876C1 VA: 0x1C875C0
	|-Array.InternalArray__ICollection_Remove<FacetsChecker.FacetsCompiler.Map>
	|
	|-RVA: 0x1C87620 Offset: 0x1C87721 VA: 0x1C87620
	|-Array.InternalArray__ICollection_Remove<MapHistory.ReplayAppearanceMap.Appearance>
	|
	|-RVA: 0x1C87680 Offset: 0x1C87781 VA: 0x1C87680
	|-Array.InternalArray__ICollection_Remove<MapHistory.ReplayAppearanceMap.Leaving>
	|
	|-RVA: 0x1C876E0 Offset: 0x1C877E1 VA: 0x1C876E0
	|-Array.InternalArray__ICollection_Remove<MapHistory.ReplayUnitMap.Data>
	|
	|-RVA: 0x1C87740 Offset: 0x1C87841 VA: 0x1C87740
	|-Array.InternalArray__ICollection_Remove<MapHistory.Rewind.LatestInspectorData>
	|
	|-RVA: 0x1C877A0 Offset: 0x1C878A1 VA: 0x1C877A0
	|-Array.InternalArray__ICollection_Remove<MapHistory.Rewind.WorkTerrainData>
	|
	|-RVA: 0x1C87800 Offset: 0x1C87901 VA: 0x1C87800
	|-Array.InternalArray__ICollection_Remove<MapHistory.RewindUnitMap.Data>
	|
	|-RVA: 0x1C87860 Offset: 0x1C87961 VA: 0x1C87860
	|-Array.InternalArray__ICollection_Remove<MapKillBonus.Work.Pos>
	|
	|-RVA: 0x1C878C0 Offset: 0x1C879C1 VA: 0x1C878C0
	|-Array.InternalArray__ICollection_Remove<MapSkill.AroundCalculator.Result>
	|
	|-RVA: 0x1C87920 Offset: 0x1C87A21 VA: 0x1C87920
	|-Array.InternalArray__ICollection_Remove<Nex.ApiCallChecker.Guideline>
	|
	|-RVA: 0x1C87980 Offset: 0x1C87A81 VA: 0x1C87980
	|-Array.InternalArray__ICollection_Remove<Ngc.MaskTextSequenceBase.Data>
	|
	|-RVA: 0x1C879E0 Offset: 0x1C87AE1 VA: 0x1C879E0
	|-Array.InternalArray__ICollection_Remove<TargetPositionCache.CacheCurve.Item>
	|
	|-RVA: 0x1C87A40 Offset: 0x1C87B41 VA: 0x1C87A40
	|-Array.InternalArray__ICollection_Remove<TargetPositionCache.CacheEntry.RecordingItem>
	|
	|-RVA: 0x1C87AA0 Offset: 0x1C87BA1 VA: 0x1C87AA0
	|-Array.InternalArray__ICollection_Remove<TerrainUtility.TerrainMap.TileCoord>
	*/

	// RVA: -1 Offset: -1
	internal bool InternalArray__ICollection_Contains<T>(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2125450 Offset: 0x2125551 VA: 0x2125450
	|-Array.InternalArray__ICollection_Contains<ArraySegment<byte>>
	|
	|-RVA: 0x21255C0 Offset: 0x21256C1 VA: 0x21255C0
	|-Array.InternalArray__ICollection_Contains<AsyncOperationHandle<object>>
	|
	|-RVA: 0x2125760 Offset: 0x2125861 VA: 0x2125760
	|-Array.InternalArray__ICollection_Contains<MapDeployTemplate.Queue.Data<object>>
	|
	|-RVA: 0x21258E0 Offset: 0x21259E1 VA: 0x21258E0
	|-Array.InternalArray__ICollection_Contains<Nex.DataStore.ParamPool.Data<object>>
	|
	|-RVA: 0x2125A60 Offset: 0x2125B61 VA: 0x2125A60
	|-Array.InternalArray__ICollection_Contains<Nex.Screening.ParamPool.Data<object>>
	|
	|-RVA: 0x2125BE0 Offset: 0x2125CE1 VA: 0x2125BE0
	|-Array.InternalArray__ICollection_Contains<IntervalTree.Entry<object>>
	|
	|-RVA: 0x2125D80 Offset: 0x2125E81 VA: 0x2125D80
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<ValueTuple<object, int>, object>>
	|
	|-RVA: 0x2125F20 Offset: 0x2126021 VA: 0x2125F20
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<byte, object>>
	|
	|-RVA: 0x21260C0 Offset: 0x21261C1 VA: 0x21260C0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<CancellationToken, object>>
	|
	|-RVA: 0x2126260 Offset: 0x2126361 VA: 0x2126260
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<char, object>>
	|
	|-RVA: 0x2126400 Offset: 0x2126501 VA: 0x2126400
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Guid, object>>
	|
	|-RVA: 0x21265A0 Offset: 0x21266A1 VA: 0x21265A0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<int, bool>>
	|
	|-RVA: 0x2126720 Offset: 0x2126821 VA: 0x2126720
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<int, byte>>
	|
	|-RVA: 0x21268A0 Offset: 0x21269A1 VA: 0x21268A0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<int, char>>
	|
	|-RVA: 0x2126A20 Offset: 0x2126B21 VA: 0x2126A20
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<int, DiagnosticEvent>>
	|
	|-RVA: 0x2126BE0 Offset: 0x2126CE1 VA: 0x2126BE0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<int, int>>
	|
	|-RVA: 0x2126D60 Offset: 0x2126E61 VA: 0x2126D60
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<int, Int32Enum>>
	|
	|-RVA: 0x2126EE0 Offset: 0x2126FE1 VA: 0x2126EE0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<int, long>>
	|
	|-RVA: 0x2127080 Offset: 0x2127181 VA: 0x2127080
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<int, MapPos>>
	|
	|-RVA: 0x2127220 Offset: 0x2127321 VA: 0x2127220
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<int, object>>
	|
	|-RVA: 0x21273C0 Offset: 0x21274C1 VA: 0x21273C0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<int, uint>>
	|
	|-RVA: 0x2127540 Offset: 0x2127641 VA: 0x2127540
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<int, AIThink.EnchantThink.SurroundingInfo>>
	|
	|-RVA: 0x21276C0 Offset: 0x21277C1 VA: 0x21276C0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Int32Enum, bool>>
	|
	|-RVA: 0x2127840 Offset: 0x2127941 VA: 0x2127840
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Int32Enum, int>>
	|
	|-RVA: 0x21279C0 Offset: 0x2127AC1 VA: 0x21279C0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Int32Enum, Int32Enum>>
	|
	|-RVA: 0x2127B40 Offset: 0x2127C41 VA: 0x2127B40
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Int32Enum, object>>
	|
	|-RVA: 0x2127CE0 Offset: 0x2127DE1 VA: 0x2127CE0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<long, object>>
	|
	|-RVA: 0x2127E80 Offset: 0x2127F81 VA: 0x2127E80
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<MapPos, int>>
	|
	|-RVA: 0x2128020 Offset: 0x2128121 VA: 0x2128020
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, AsyncOperationHandle<object>>>
	|
	|-RVA: 0x21281D0 Offset: 0x21282D1 VA: 0x21281D0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, AsyncOperationHandle>>
	|
	|-RVA: 0x2128380 Offset: 0x2128481 VA: 0x2128380
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, bool>>
	|
	|-RVA: 0x2128520 Offset: 0x2128621 VA: 0x2128520
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, byte>>
	|
	|-RVA: 0x21286C0 Offset: 0x21287C1 VA: 0x21286C0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, int>>
	|
	|-RVA: 0x2128860 Offset: 0x2128961 VA: 0x2128860
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, Int32Enum>>
	|
	|-RVA: 0x2128A00 Offset: 0x2128B01 VA: 0x2128A00
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, IntPtr>>
	|
	|-RVA: 0x2128BA0 Offset: 0x2128CA1 VA: 0x2128BA0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, object>>
	|
	|-RVA: 0x2128D40 Offset: 0x2128E41 VA: 0x2128D40
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, Playable>>
	|
	|-RVA: 0x2128EE0 Offset: 0x2128FE1 VA: 0x2128EE0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, ResourceLocator>>
	|
	|-RVA: 0x2129080 Offset: 0x2129181 VA: 0x2129080
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, float>>
	|
	|-RVA: 0x2129220 Offset: 0x2129321 VA: 0x2129220
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, ushort>>
	|
	|-RVA: 0x21293C0 Offset: 0x21294C1 VA: 0x21293C0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<object, GameVariable.Value>>
	|
	|-RVA: 0x2129560 Offset: 0x2129661 VA: 0x2129560
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<sbyte, DataStoreRatingInfo>>
	|
	|-RVA: 0x2129710 Offset: 0x2129811 VA: 0x2129710
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<sbyte, object>>
	|
	|-RVA: 0x21298B0 Offset: 0x21299B1 VA: 0x21298B0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<ushort, int>>
	|
	|-RVA: 0x2129A30 Offset: 0x2129B31 VA: 0x2129A30
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<uint, int>>
	|
	|-RVA: 0x2129BB0 Offset: 0x2129CB1 VA: 0x2129BB0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<uint, object>>
	|
	|-RVA: 0x2129D50 Offset: 0x2129E51 VA: 0x2129D50
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<ulong, Friend>>
	|
	|-RVA: 0x2129F00 Offset: 0x212A001 VA: 0x2129F00
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<ulong, Int32Enum>>
	|
	|-RVA: 0x212A0A0 Offset: 0x212A1A1 VA: 0x212A0A0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<ulong, object>>
	|
	|-RVA: 0x212A240 Offset: 0x212A341 VA: 0x212A240
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<Vector3, int>>
	|
	|-RVA: 0x212A3E0 Offset: 0x212A4E1 VA: 0x212A3E0
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<XPathNodeRef, XPathNodeRef>>
	|
	|-RVA: 0x212A590 Offset: 0x212A691 VA: 0x212A590
	|-Array.InternalArray__ICollection_Contains<Dictionary.Entry<TerrainUtility.TerrainMap.TileCoord, object>>
	|
	|-RVA: 0x212A730 Offset: 0x212A831 VA: 0x212A730
	|-Array.InternalArray__ICollection_Contains<PriorityQueue.IndexedItem<object>>
	|
	|-RVA: 0x212A8B0 Offset: 0x212A9B1 VA: 0x212A8B0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<ValueTuple<object, int>, object>>
	|
	|-RVA: 0x212AA50 Offset: 0x212AB51 VA: 0x212AA50
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<byte, object>>
	|
	|-RVA: 0x212ABD0 Offset: 0x212ACD1 VA: 0x212ABD0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<CancellationToken, object>>
	|
	|-RVA: 0x212AD50 Offset: 0x212AE51 VA: 0x212AD50
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<char, object>>
	|
	|-RVA: 0x212AED0 Offset: 0x212AFD1 VA: 0x212AED0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<DateTime, object>>
	|
	|-RVA: 0x212B050 Offset: 0x212B151 VA: 0x212B050
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Guid, object>>
	|
	|-RVA: 0x212B1F0 Offset: 0x212B2F1 VA: 0x212B1F0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<int, bool>>
	|
	|-RVA: 0x212B370 Offset: 0x212B471 VA: 0x212B370
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<int, byte>>
	|
	|-RVA: 0x212B4F0 Offset: 0x212B5F1 VA: 0x212B4F0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<int, char>>
	|
	|-RVA: 0x212B670 Offset: 0x212B771 VA: 0x212B670
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<int, DiagnosticEvent>>
	|
	|-RVA: 0x212B830 Offset: 0x212B931 VA: 0x212B830
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<int, int>>
	|
	|-RVA: 0x212B9B0 Offset: 0x212BAB1 VA: 0x212B9B0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<int, Int32Enum>>
	|
	|-RVA: 0x212BB30 Offset: 0x212BC31 VA: 0x212BB30
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<int, long>>
	|
	|-RVA: 0x212BCB0 Offset: 0x212BDB1 VA: 0x212BCB0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<int, MapPos>>
	|
	|-RVA: 0x212BE50 Offset: 0x212BF51 VA: 0x212BE50
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<int, object>>
	|
	|-RVA: 0x212BFD0 Offset: 0x212C0D1 VA: 0x212BFD0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<int, uint>>
	|
	|-RVA: 0x212C150 Offset: 0x212C251 VA: 0x212C150
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<int, AIThink.EnchantThink.SurroundingInfo>>
	|
	|-RVA: 0x212C2D0 Offset: 0x212C3D1 VA: 0x212C2D0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Int32Enum, bool>>
	|
	|-RVA: 0x212C450 Offset: 0x212C551 VA: 0x212C450
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Int32Enum, int>>
	|
	|-RVA: 0x212C5D0 Offset: 0x212C6D1 VA: 0x212C5D0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Int32Enum, Int32Enum>>
	|
	|-RVA: 0x212C750 Offset: 0x212C851 VA: 0x212C750
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Int32Enum, object>>
	|
	|-RVA: 0x212C8D0 Offset: 0x212C9D1 VA: 0x212C8D0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<long, object>>
	|
	|-RVA: 0x212CA50 Offset: 0x212CB51 VA: 0x212CA50
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<MapPos, int>>
	|
	|-RVA: 0x212CBF0 Offset: 0x212CCF1 VA: 0x212CBF0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, AsyncOperationHandle<object>>>
	|
	|-RVA: 0x212CD90 Offset: 0x212CE91 VA: 0x212CD90
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, ValueTuple<int, DateTime, object>>>
	|
	|-RVA: 0x212CF30 Offset: 0x212D031 VA: 0x212CF30
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, AsyncOperationHandle>>
	|
	|-RVA: 0x212D0D0 Offset: 0x212D1D1 VA: 0x212D0D0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, bool>>
	|
	|-RVA: 0x212D250 Offset: 0x212D351 VA: 0x212D250
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, byte>>
	|
	|-RVA: 0x212D3D0 Offset: 0x212D4D1 VA: 0x212D3D0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, int>>
	|
	|-RVA: 0x212D550 Offset: 0x212D651 VA: 0x212D550
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, Int32Enum>>
	|
	|-RVA: 0x212D6D0 Offset: 0x212D7D1 VA: 0x212D6D0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, IntPtr>>
	|
	|-RVA: 0x212D850 Offset: 0x212D951 VA: 0x212D850
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, object>>
	|
	|-RVA: 0x212D9D0 Offset: 0x212DAD1 VA: 0x212D9D0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, Playable>>
	|
	|-RVA: 0x212DB70 Offset: 0x212DC71 VA: 0x212DB70
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, ResourceLocator>>
	|
	|-RVA: 0x212DD10 Offset: 0x212DE11 VA: 0x212DD10
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, float>>
	|
	|-RVA: 0x212DE90 Offset: 0x212DF91 VA: 0x212DE90
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, ushort>>
	|
	|-RVA: 0x212E010 Offset: 0x212E111 VA: 0x212E010
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<object, GameVariable.Value>>
	|
	|-RVA: 0x212E1B0 Offset: 0x212E2B1 VA: 0x212E1B0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<sbyte, DataStoreRatingInfo>>
	|
	|-RVA: 0x212E350 Offset: 0x212E451 VA: 0x212E350
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<sbyte, object>>
	|
	|-RVA: 0x212E4D0 Offset: 0x212E5D1 VA: 0x212E4D0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<ushort, int>>
	|
	|-RVA: 0x212E650 Offset: 0x212E751 VA: 0x212E650
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<uint, int>>
	|
	|-RVA: 0x212E7D0 Offset: 0x212E8D1 VA: 0x212E7D0
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<uint, object>>
	|
	|-RVA: 0x212E950 Offset: 0x212EA51 VA: 0x212E950
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<ulong, Friend>>
	|
	|-RVA: 0x212EB00 Offset: 0x212EC01 VA: 0x212EB00
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<ulong, Int32Enum>>
	|
	|-RVA: 0x212EC80 Offset: 0x212ED81 VA: 0x212EC80
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<ulong, object>>
	|
	|-RVA: 0x212EE00 Offset: 0x212EF01 VA: 0x212EE00
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<Vector3, int>>
	|
	|-RVA: 0x212EF80 Offset: 0x212F081 VA: 0x212EF80
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<XPathNodeRef, XPathNodeRef>>
	|
	|-RVA: 0x212F120 Offset: 0x212F221 VA: 0x212F120
	|-Array.InternalArray__ICollection_Contains<KeyValuePair<TerrainUtility.TerrainMap.TileCoord, object>>
	|
	|-RVA: 0x212F2A0 Offset: 0x212F3A1 VA: 0x212F2A0
	|-Array.InternalArray__ICollection_Contains<NativeArray<PreTile>>
	|
	|-RVA: 0x212F410 Offset: 0x212F511 VA: 0x212F410
	|-Array.InternalArray__ICollection_Contains<CommonBattleSequence.Reliance<object>>
	|
	|-RVA: 0x212F5B0 Offset: 0x212F6B1 VA: 0x212F5B0
	|-Array.InternalArray__ICollection_Contains<RenderGraphResourcePool.ResourceLogInfo<object>>
	|
	|-RVA: 0x212F730 Offset: 0x212F831 VA: 0x212F730
	|-Array.InternalArray__ICollection_Contains<HashSet.Slot<ValueTuple<object, int>>>
	|
	|-RVA: 0x212F8D0 Offset: 0x212F9D1 VA: 0x212F8D0
	|-Array.InternalArray__ICollection_Contains<HashSet.Slot<AsyncOperationHandle>>
	|
	|-RVA: 0x212FA70 Offset: 0x212FB71 VA: 0x212FA70
	|-Array.InternalArray__ICollection_Contains<HashSet.Slot<int>>
	|
	|-RVA: 0x212FC10 Offset: 0x212FD11 VA: 0x212FC10
	|-Array.InternalArray__ICollection_Contains<HashSet.Slot<Int32Enum>>
	|
	|-RVA: 0x212FDB0 Offset: 0x212FEB1 VA: 0x212FDB0
	|-Array.InternalArray__ICollection_Contains<Set.Slot<Int32Enum>>
	|
	|-RVA: 0x212FF50 Offset: 0x2130051 VA: 0x212FF50
	|-Array.InternalArray__ICollection_Contains<HashSet.Slot<MapPos>>
	|
	|-RVA: 0x21300D0 Offset: 0x21301D1 VA: 0x21300D0
	|-Array.InternalArray__ICollection_Contains<HashSet.Slot<object>>
	|
	|-RVA: 0x2130250 Offset: 0x2130351 VA: 0x2130250
	|-Array.InternalArray__ICollection_Contains<Set.Slot<object>>
	|
	|-RVA: 0x21303F0 Offset: 0x21304F1 VA: 0x21303F0
	|-Array.InternalArray__ICollection_Contains<HashSet.Slot<uint>>
	|
	|-RVA: 0x2130590 Offset: 0x2130691 VA: 0x2130590
	|-Array.InternalArray__ICollection_Contains<HashSet.Slot<ulong>>
	|
	|-RVA: 0x2130710 Offset: 0x2130811 VA: 0x2130710
	|-Array.InternalArray__ICollection_Contains<Set.Slot<Vector3>>
	|
	|-RVA: 0x21308B0 Offset: 0x21309B1 VA: 0x21308B0
	|-Array.InternalArray__ICollection_Contains<TMP_TextProcessingStack<Color32>>
	|
	|-RVA: 0x2130A50 Offset: 0x2130B51 VA: 0x2130A50
	|-Array.InternalArray__ICollection_Contains<TMP_TextProcessingStack<HighlightState>>
	|
	|-RVA: 0x2130C00 Offset: 0x2130D01 VA: 0x2130C00
	|-Array.InternalArray__ICollection_Contains<TMP_TextProcessingStack<int>>
	|
	|-RVA: 0x2130DA0 Offset: 0x2130EA1 VA: 0x2130DA0
	|-Array.InternalArray__ICollection_Contains<TMP_TextProcessingStack<Int32Enum>>
	|
	|-RVA: 0x2130F40 Offset: 0x2131041 VA: 0x2130F40
	|-Array.InternalArray__ICollection_Contains<TMP_TextProcessingStack<MaterialReference>>
	|
	|-RVA: 0x2131130 Offset: 0x2131231 VA: 0x2131130
	|-Array.InternalArray__ICollection_Contains<TMP_TextProcessingStack<object>>
	|
	|-RVA: 0x21312E0 Offset: 0x21313E1 VA: 0x21312E0
	|-Array.InternalArray__ICollection_Contains<TMP_TextProcessingStack<float>>
	|
	|-RVA: 0x2131480 Offset: 0x2131581 VA: 0x2131480
	|-Array.InternalArray__ICollection_Contains<TMP_TextProcessingStack<WordWrapState>>
	|
	|-RVA: 0x2131630 Offset: 0x2131731 VA: 0x2131630
	|-Array.InternalArray__ICollection_Contains<TimeInterval<object>>
	|
	|-RVA: 0x21317A0 Offset: 0x21318A1 VA: 0x21317A0
	|-Array.InternalArray__ICollection_Contains<Timestamped<object>>
	|
	|-RVA: 0x2131940 Offset: 0x2131A41 VA: 0x2131940
	|-Array.InternalArray__ICollection_Contains<UniTask<object>>
	|
	|-RVA: 0x2131AC0 Offset: 0x2131BC1 VA: 0x2131AC0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<ValueTuple<bool, object>>>
	|
	|-RVA: 0x2131C30 Offset: 0x2131D31 VA: 0x2131C30
	|-Array.InternalArray__ICollection_Contains<ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>
	|
	|-RVA: 0x2131DD0 Offset: 0x2131ED1 VA: 0x2131DD0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, UniTask<object>>>
	|
	|-RVA: 0x2131F70 Offset: 0x2132071 VA: 0x2131F70
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>
	|
	|-RVA: 0x2132110 Offset: 0x2132211 VA: 0x2132110
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>
	|
	|-RVA: 0x21322D0 Offset: 0x21323D1 VA: 0x21322D0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>
	|
	|-RVA: 0x2132490 Offset: 0x2132591 VA: 0x2132490
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>
	|
	|-RVA: 0x2132620 Offset: 0x2132721 VA: 0x2132620
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>
	|
	|-RVA: 0x21327B0 Offset: 0x21328B1 VA: 0x21327B0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>
	|
	|-RVA: 0x2132980 Offset: 0x2132A81 VA: 0x2132980
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>
	|
	|-RVA: 0x2132B10 Offset: 0x2132C11 VA: 0x2132B10
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>
	|
	|-RVA: 0x2132CD0 Offset: 0x2132DD1 VA: 0x2132CD0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>
	|
	|-RVA: 0x2132E90 Offset: 0x2132F91 VA: 0x2132E90
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>
	|
	|-RVA: 0x3B9C1A0 Offset: 0x3B9C2A1 VA: 0x3B9C1A0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>
	|
	|-RVA: 0x3B9C360 Offset: 0x3B9C461 VA: 0x3B9C360
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x3B9C520 Offset: 0x3B9C621 VA: 0x3B9C520
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>
	|
	|-RVA: 0x3B9C6E0 Offset: 0x3B9C7E1 VA: 0x3B9C6E0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>
	|
	|-RVA: 0x3B9C8A0 Offset: 0x3B9C9A1 VA: 0x3B9C8A0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>
	|
	|-RVA: 0x3B9CA40 Offset: 0x3B9CB41 VA: 0x3B9CA40
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>
	|
	|-RVA: 0x3B9CC00 Offset: 0x3B9CD01 VA: 0x3B9CC00
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>
	|
	|-RVA: 0x3B9CD90 Offset: 0x3B9CE91 VA: 0x3B9CD90
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>
	|
	|-RVA: 0x3B9CF50 Offset: 0x3B9D051 VA: 0x3B9CF50
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>
	|
	|-RVA: 0x3B9D0F0 Offset: 0x3B9D1F1 VA: 0x3B9D0F0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>
	|
	|-RVA: 0x3B9D2B0 Offset: 0x3B9D3B1 VA: 0x3B9D2B0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>
	|
	|-RVA: 0x3B9D470 Offset: 0x3B9D571 VA: 0x3B9D470
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>
	|
	|-RVA: 0x3B9D630 Offset: 0x3B9D731 VA: 0x3B9D630
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>
	|
	|-RVA: 0x3B9D800 Offset: 0x3B9D901 VA: 0x3B9D800
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>
	|
	|-RVA: 0x3B9D9D0 Offset: 0x3B9DAD1 VA: 0x3B9D9D0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>
	|
	|-RVA: 0x3B9DBC0 Offset: 0x3B9DCC1 VA: 0x3B9DBC0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>
	|
	|-RVA: 0x3B9DDB0 Offset: 0x3B9DEB1 VA: 0x3B9DDB0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>
	|
	|-RVA: 0x3B9DFC0 Offset: 0x3B9E0C1 VA: 0x3B9DFC0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>
	|
	|-RVA: 0x3B9E150 Offset: 0x3B9E251 VA: 0x3B9E150
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>
	|
	|-RVA: 0x3B9E2E0 Offset: 0x3B9E3E1 VA: 0x3B9E2E0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>
	|
	|-RVA: 0x3B9E4A0 Offset: 0x3B9E5A1 VA: 0x3B9E4A0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>
	|
	|-RVA: 0x3B9E630 Offset: 0x3B9E731 VA: 0x3B9E630
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>
	|
	|-RVA: 0x3B9E7D0 Offset: 0x3B9E8D1 VA: 0x3B9E7D0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>
	|
	|-RVA: 0x3B9E990 Offset: 0x3B9EA91 VA: 0x3B9E990
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>
	|
	|-RVA: 0x3B9EB30 Offset: 0x3B9EC31 VA: 0x3B9EB30
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>
	|
	|-RVA: 0x3B9ECF0 Offset: 0x3B9EDF1 VA: 0x3B9ECF0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x3B9EEB0 Offset: 0x3B9EFB1 VA: 0x3B9EEB0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>
	|
	|-RVA: 0x3B9F050 Offset: 0x3B9F151 VA: 0x3B9F050
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>
	|
	|-RVA: 0x3B9F1F0 Offset: 0x3B9F2F1 VA: 0x3B9F1F0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>
	|
	|-RVA: 0x3B9F390 Offset: 0x3B9F491 VA: 0x3B9F390
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>
	|
	|-RVA: 0x3B9F550 Offset: 0x3B9F651 VA: 0x3B9F550
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>
	|
	|-RVA: 0x3B9F6E0 Offset: 0x3B9F7E1 VA: 0x3B9F6E0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>
	|
	|-RVA: 0x3B9F880 Offset: 0x3B9F981 VA: 0x3B9F880
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>
	|
	|-RVA: 0x3B9FA40 Offset: 0x3B9FB41 VA: 0x3B9FA40
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>
	|
	|-RVA: 0x3B9FBE0 Offset: 0x3B9FCE1 VA: 0x3B9FBE0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>
	|
	|-RVA: 0x3B9FDA0 Offset: 0x3B9FEA1 VA: 0x3B9FDA0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>
	|
	|-RVA: 0x3B9FF60 Offset: 0x3BA0061 VA: 0x3B9FF60
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x3BA0130 Offset: 0x3BA0231 VA: 0x3BA0130
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>
	|
	|-RVA: 0x3BA02F0 Offset: 0x3BA03F1 VA: 0x3BA02F0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x3BA04E0 Offset: 0x3BA05E1 VA: 0x3BA04E0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>
	|
	|-RVA: 0x3BA06B0 Offset: 0x3BA07B1 VA: 0x3BA06B0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x3BA08C0 Offset: 0x3BA09C1 VA: 0x3BA08C0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>
	|
	|-RVA: 0x3BA0A90 Offset: 0x3BA0B91 VA: 0x3BA0A90
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x3BA0CC0 Offset: 0x3BA0DC1 VA: 0x3BA0CC0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>
	|
	|-RVA: 0x3BA0EB0 Offset: 0x3BA0FB1 VA: 0x3BA0EB0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x3BA10F0 Offset: 0x3BA11F1 VA: 0x3BA10F0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>
	|
	|-RVA: 0x3BA12E0 Offset: 0x3BA13E1 VA: 0x3BA12E0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>
	|
	|-RVA: 0x3BA1450 Offset: 0x3BA1551 VA: 0x3BA1450
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>
	|
	|-RVA: 0x3BA15C0 Offset: 0x3BA16C1 VA: 0x3BA15C0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>
	|
	|-RVA: 0x3BA1780 Offset: 0x3BA1881 VA: 0x3BA1780
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>
	|
	|-RVA: 0x3BA18F0 Offset: 0x3BA19F1 VA: 0x3BA18F0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>
	|
	|-RVA: 0x3BA1AB0 Offset: 0x3BA1BB1 VA: 0x3BA1AB0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>
	|
	|-RVA: 0x3BA1C50 Offset: 0x3BA1D51 VA: 0x3BA1C50
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>
	|
	|-RVA: 0x3BA1DC0 Offset: 0x3BA1EC1 VA: 0x3BA1DC0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>
	|
	|-RVA: 0x3BA1F60 Offset: 0x3BA2061 VA: 0x3BA1F60
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x3BA2100 Offset: 0x3BA2201 VA: 0x3BA2100
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>
	|
	|-RVA: 0x3BA22C0 Offset: 0x3BA23C1 VA: 0x3BA22C0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>
	|
	|-RVA: 0x3BA2480 Offset: 0x3BA2581 VA: 0x3BA2480
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>
	|
	|-RVA: 0x3BA25F0 Offset: 0x3BA26F1 VA: 0x3BA25F0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>
	|
	|-RVA: 0x3BA2790 Offset: 0x3BA2891 VA: 0x3BA2790
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>
	|
	|-RVA: 0x3BA2900 Offset: 0x3BA2A01 VA: 0x3BA2900
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>
	|
	|-RVA: 0x3BA2AA0 Offset: 0x3BA2BA1 VA: 0x3BA2AA0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>
	|
	|-RVA: 0x3BA2C40 Offset: 0x3BA2D41 VA: 0x3BA2C40
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>
	|
	|-RVA: 0x3BA2E00 Offset: 0x3BA2F01 VA: 0x3BA2E00
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>
	|
	|-RVA: 0x3BA2FA0 Offset: 0x3BA30A1 VA: 0x3BA2FA0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>
	|
	|-RVA: 0x3BA3140 Offset: 0x3BA3241 VA: 0x3BA3140
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x3BA3310 Offset: 0x3BA3411 VA: 0x3BA3310
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>
	|
	|-RVA: 0x3BA34D0 Offset: 0x3BA35D1 VA: 0x3BA34D0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x3BA36C0 Offset: 0x3BA37C1 VA: 0x3BA36C0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>
	|
	|-RVA: 0x3BA3880 Offset: 0x3BA3981 VA: 0x3BA3880
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x3BA3A90 Offset: 0x3BA3B91 VA: 0x3BA3A90
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>
	|
	|-RVA: 0x3BA3C60 Offset: 0x3BA3D61 VA: 0x3BA3C60
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x3BA3E90 Offset: 0x3BA3F91 VA: 0x3BA3E90
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>
	|
	|-RVA: 0x3BA4060 Offset: 0x3BA4161 VA: 0x3BA4060
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x3BA42A0 Offset: 0x3BA43A1 VA: 0x3BA42A0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>
	|
	|-RVA: 0x3BA4490 Offset: 0x3BA4591 VA: 0x3BA4490
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x3BA4650 Offset: 0x3BA4751 VA: 0x3BA4650
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x3BA4810 Offset: 0x3BA4911 VA: 0x3BA4810
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>
	|
	|-RVA: 0x3BA49A0 Offset: 0x3BA4AA1 VA: 0x3BA49A0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, bool>>>
	|
	|-RVA: 0x3BA4B30 Offset: 0x3BA4C31 VA: 0x3BA4B30
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, Bounds>>>
	|
	|-RVA: 0x3BA4CD0 Offset: 0x3BA4DD1 VA: 0x3BA4CD0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, byte>>>
	|
	|-RVA: 0x3BA4E60 Offset: 0x3BA4F61 VA: 0x3BA4E60
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, Color>>>
	|
	|-RVA: 0x3BA5000 Offset: 0x3BA5101 VA: 0x3BA5000
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, double>>>
	|
	|-RVA: 0x3BA51A0 Offset: 0x3BA52A1 VA: 0x3BA51A0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, int>>>
	|
	|-RVA: 0x3BA5330 Offset: 0x3BA5431 VA: 0x3BA5330
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, long>>>
	|
	|-RVA: 0x3BA54D0 Offset: 0x3BA55D1 VA: 0x3BA54D0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, object>>>
	|
	|-RVA: 0x3BA5670 Offset: 0x3BA5771 VA: 0x3BA5670
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, Quaternion>>>
	|
	|-RVA: 0x3BA5810 Offset: 0x3BA5911 VA: 0x3BA5810
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, Rect>>>
	|
	|-RVA: 0x3BA59B0 Offset: 0x3BA5AB1 VA: 0x3BA59B0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, float>>>
	|
	|-RVA: 0x3BA5B40 Offset: 0x3BA5C41 VA: 0x3BA5B40
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, UniTask>>>
	|
	|-RVA: 0x3BA5CE0 Offset: 0x3BA5DE1 VA: 0x3BA5CE0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, Unit>>>
	|
	|-RVA: 0x3BA5E70 Offset: 0x3BA5F71 VA: 0x3BA5E70
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, Vector2>>>
	|
	|-RVA: 0x3BA5FE0 Offset: 0x3BA60E1 VA: 0x3BA5FE0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, Vector3>>>
	|
	|-RVA: 0x3BA6180 Offset: 0x3BA6281 VA: 0x3BA6180
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<bool, Vector4>>>
	|
	|-RVA: 0x3BA6320 Offset: 0x3BA6421 VA: 0x3BA6320
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<int, object>>>
	|
	|-RVA: 0x3BA64C0 Offset: 0x3BA65C1 VA: 0x3BA64C0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<object, object>>>
	|
	|-RVA: 0x3BA6660 Offset: 0x3BA6761 VA: 0x3BA6660
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x3BA6820 Offset: 0x3BA6921 VA: 0x3BA6820
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<object, object, object>>>
	|
	|-RVA: 0x3BA69C0 Offset: 0x3BA6AC1 VA: 0x3BA69C0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x3BA6B90 Offset: 0x3BA6C91 VA: 0x3BA6B90
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<object, object, object, object>>>
	|
	|-RVA: 0x3BA6D50 Offset: 0x3BA6E51 VA: 0x3BA6D50
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x3BA6F40 Offset: 0x3BA7041 VA: 0x3BA6F40
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>
	|
	|-RVA: 0x3BA7100 Offset: 0x3BA7201 VA: 0x3BA7100
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x3BA7310 Offset: 0x3BA7411 VA: 0x3BA7310
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>
	|
	|-RVA: 0x3BA74E0 Offset: 0x3BA75E1 VA: 0x3BA74E0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x3BA7710 Offset: 0x3BA7811 VA: 0x3BA7710
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>
	|
	|-RVA: 0x3BA78E0 Offset: 0x3BA79E1 VA: 0x3BA78E0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x3BA7B20 Offset: 0x3BA7C21 VA: 0x3BA7B20
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x3BA7CE0 Offset: 0x3BA7DE1 VA: 0x3BA7CE0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, AsyncUnit>>
	|
	|-RVA: 0x3BA7E50 Offset: 0x3BA7F51 VA: 0x3BA7E50
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, bool>>
	|
	|-RVA: 0x3BA7FC0 Offset: 0x3BA80C1 VA: 0x3BA7FC0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, Bounds>>
	|
	|-RVA: 0x3BA8180 Offset: 0x3BA8281 VA: 0x3BA8180
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, byte>>
	|
	|-RVA: 0x3BA82F0 Offset: 0x3BA83F1 VA: 0x3BA82F0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, Color>>
	|
	|-RVA: 0x3BA8490 Offset: 0x3BA8591 VA: 0x3BA8490
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, double>>
	|
	|-RVA: 0x3BA8600 Offset: 0x3BA8701 VA: 0x3BA8600
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, int>>
	|
	|-RVA: 0x3BA8770 Offset: 0x3BA8871 VA: 0x3BA8770
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, long>>
	|
	|-RVA: 0x3BA88E0 Offset: 0x3BA89E1 VA: 0x3BA88E0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, object>>
	|
	|-RVA: 0x3BA8A50 Offset: 0x3BA8B51 VA: 0x3BA8A50
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, Quaternion>>
	|
	|-RVA: 0x3BA8BF0 Offset: 0x3BA8CF1 VA: 0x3BA8BF0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, Rect>>
	|
	|-RVA: 0x3BA8D90 Offset: 0x3BA8E91 VA: 0x3BA8D90
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, float>>
	|
	|-RVA: 0x3BA8F00 Offset: 0x3BA9001 VA: 0x3BA8F00
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, UniTask>>
	|
	|-RVA: 0x3BA9070 Offset: 0x3BA9171 VA: 0x3BA9070
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, Unit>>
	|
	|-RVA: 0x3BA91E0 Offset: 0x3BA92E1 VA: 0x3BA91E0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, Vector2>>
	|
	|-RVA: 0x3BA9370 Offset: 0x3BA9471 VA: 0x3BA9370
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, Vector3>>
	|
	|-RVA: 0x3BA94E0 Offset: 0x3BA95E1 VA: 0x3BA94E0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<bool, Vector4>>
	|
	|-RVA: 0x3BA9680 Offset: 0x3BA9781 VA: 0x3BA9680
	|-Array.InternalArray__ICollection_Contains<ValueTuple<int, bool>>
	|
	|-RVA: 0x3BA97F0 Offset: 0x3BA98F1 VA: 0x3BA97F0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<int, Bounds>>
	|
	|-RVA: 0x3BA99B0 Offset: 0x3BA9AB1 VA: 0x3BA99B0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<int, byte>>
	|
	|-RVA: 0x3BA9B20 Offset: 0x3BA9C21 VA: 0x3BA9B20
	|-Array.InternalArray__ICollection_Contains<ValueTuple<int, Color>>
	|
	|-RVA: 0x3BA9CC0 Offset: 0x3BA9DC1 VA: 0x3BA9CC0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<int, double>>
	|
	|-RVA: 0x3BA9E30 Offset: 0x3BA9F31 VA: 0x3BA9E30
	|-Array.InternalArray__ICollection_Contains<ValueTuple<int, int>>
	|
	|-RVA: 0x3BA9FA0 Offset: 0x3BAA0A1 VA: 0x3BA9FA0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<int, long>>
	|
	|-RVA: 0x3BAA110 Offset: 0x3BAA211 VA: 0x3BAA110
	|-Array.InternalArray__ICollection_Contains<ValueTuple<int, object>>
	|
	|-RVA: 0x3BAA280 Offset: 0x3BAA381 VA: 0x3BAA280
	|-Array.InternalArray__ICollection_Contains<ValueTuple<int, Quaternion>>
	|
	|-RVA: 0x3BAA420 Offset: 0x3BAA521 VA: 0x3BAA420
	|-Array.InternalArray__ICollection_Contains<ValueTuple<int, Rect>>
	|
	|-RVA: 0x3BAA5C0 Offset: 0x3BAA6C1 VA: 0x3BAA5C0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<int, float>>
	|
	|-RVA: 0x3BAA730 Offset: 0x3BAA831 VA: 0x3BAA730
	|-Array.InternalArray__ICollection_Contains<ValueTuple<int, Unit>>
	|
	|-RVA: 0x3BAA8A0 Offset: 0x3BAA9A1 VA: 0x3BAA8A0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<int, Vector2>>
	|
	|-RVA: 0x3BAAA30 Offset: 0x3BAAB31 VA: 0x3BAAA30
	|-Array.InternalArray__ICollection_Contains<ValueTuple<int, Vector3>>
	|
	|-RVA: 0x3BAABA0 Offset: 0x3BAACA1 VA: 0x3BAABA0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<int, Vector4>>
	|
	|-RVA: 0x3BAAD40 Offset: 0x3BAAE41 VA: 0x3BAAD40
	|-Array.InternalArray__ICollection_Contains<ValueTuple<Int32Enum, int>>
	|
	|-RVA: 0x3BAAEB0 Offset: 0x3BAAFB1 VA: 0x3BAAEB0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<object, ValueTuple<object, int>>>
	|
	|-RVA: 0x3BAB050 Offset: 0x3BAB151 VA: 0x3BAB050
	|-Array.InternalArray__ICollection_Contains<ValueTuple<object, int>>
	|
	|-RVA: 0x3BAB1C0 Offset: 0x3BAB2C1 VA: 0x3BAB1C0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<object, object>>
	|
	|-RVA: 0x3BAB330 Offset: 0x3BAB431 VA: 0x3BAB330
	|-Array.InternalArray__ICollection_Contains<ValueTuple<object, float>>
	|
	|-RVA: 0x3BAB4A0 Offset: 0x3BAB5A1 VA: 0x3BAB4A0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<Vector3, float>>
	|
	|-RVA: 0x3BAB630 Offset: 0x3BAB731 VA: 0x3BAB630
	|-Array.InternalArray__ICollection_Contains<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>
	|
	|-RVA: 0x3BAB7F0 Offset: 0x3BAB8F1 VA: 0x3BAB7F0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<object, Int32Enum, int>>
	|
	|-RVA: 0x3BAB960 Offset: 0x3BABA61 VA: 0x3BAB960
	|-Array.InternalArray__ICollection_Contains<ValueTuple<object, object, object>>
	|
	|-RVA: 0x3BABB00 Offset: 0x3BABC01 VA: 0x3BABB00
	|-Array.InternalArray__ICollection_Contains<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>
	|
	|-RVA: 0x3BABCD0 Offset: 0x3BABDD1 VA: 0x3BABCD0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<object, int, int, int>>
	|
	|-RVA: 0x3BABE70 Offset: 0x3BABF71 VA: 0x3BABE70
	|-Array.InternalArray__ICollection_Contains<ValueTuple<object, object, object, object>>
	|
	|-RVA: 0x3BAC010 Offset: 0x3BAC111 VA: 0x3BAC010
	|-Array.InternalArray__ICollection_Contains<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>
	|
	|-RVA: 0x3BAC200 Offset: 0x3BAC301 VA: 0x3BAC200
	|-Array.InternalArray__ICollection_Contains<ValueTuple<object, object, object, object, object>>
	|
	|-RVA: 0x3BAC3C0 Offset: 0x3BAC4C1 VA: 0x3BAC3C0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>
	|
	|-RVA: 0x3BAC5D0 Offset: 0x3BAC6D1 VA: 0x3BAC5D0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<object, object, object, object, object, object>>
	|
	|-RVA: 0x3BAC790 Offset: 0x3BAC891 VA: 0x3BAC790
	|-Array.InternalArray__ICollection_Contains<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>
	|
	|-RVA: 0x3BAC9C0 Offset: 0x3BACAC1 VA: 0x3BAC9C0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<object, object, object, object, object, object, object>>
	|
	|-RVA: 0x3BACB90 Offset: 0x3BACC91 VA: 0x3BACB90
	|-Array.InternalArray__ICollection_Contains<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>
	|
	|-RVA: 0x3BACDD0 Offset: 0x3BACED1 VA: 0x3BACDD0
	|-Array.InternalArray__ICollection_Contains<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x3BACF90 Offset: 0x3BAD091 VA: 0x3BACF90
	|-Array.InternalArray__ICollection_Contains<AnimatorClipInfo>
	|
	|-RVA: 0x3BAD110 Offset: 0x3BAD211 VA: 0x3BAD110
	|-Array.InternalArray__ICollection_Contains<AsyncOperationHandle>
	|
	|-RVA: 0x3BAD2B0 Offset: 0x3BAD3B1 VA: 0x3BAD2B0
	|-Array.InternalArray__ICollection_Contains<AsyncUnit>
	|
	|-RVA: 0x3BAD430 Offset: 0x3BAD531 VA: 0x3BAD430
	|-Array.InternalArray__ICollection_Contains<BatchVisibility>
	|
	|-RVA: 0x3BAD5D0 Offset: 0x3BAD6D1 VA: 0x3BAD5D0
	|-Array.InternalArray__ICollection_Contains<BoneWeight>
	|
	|-RVA: 0x3BAD720 Offset: 0x3BAD821 VA: 0x3BAD720
	|-Array.InternalArray__ICollection_Contains<BoneWeight1>
	|
	|-RVA: 0x3BAD850 Offset: 0x3BAD951 VA: 0x3BAD850
	|-Array.InternalArray__ICollection_Contains<bool>
	|
	|-RVA: 0x3BAD990 Offset: 0x3BADA91 VA: 0x3BAD990
	|-Array.InternalArray__ICollection_Contains<Bounds>
	|
	|-RVA: 0x3BADAE0 Offset: 0x3BADBE1 VA: 0x3BADAE0
	|-Array.InternalArray__ICollection_Contains<byte>
	|
	|-RVA: 0x3BADC10 Offset: 0x3BADD11 VA: 0x3BADC10
	|-Array.InternalArray__ICollection_Contains<ByteEnum>
	|
	|-RVA: 0x3BADD80 Offset: 0x3BADE81 VA: 0x3BADD80
	|-Array.InternalArray__ICollection_Contains<CameraInfo>
	|
	|-RVA: 0x3BADF00 Offset: 0x3BAE001 VA: 0x3BADF00
	|-Array.InternalArray__ICollection_Contains<CancellationToken>
	|
	|-RVA: 0x3BAE030 Offset: 0x3BAE131 VA: 0x3BAE030
	|-Array.InternalArray__ICollection_Contains<CancellationTokenRegistration>
	|
	|-RVA: 0x3BAE180 Offset: 0x3BAE281 VA: 0x3BAE180
	|-Array.InternalArray__ICollection_Contains<char>
	|
	|-RVA: 0x3BAE2B0 Offset: 0x3BAE3B1 VA: 0x3BAE2B0
	|-Array.InternalArray__ICollection_Contains<ClusteringData>
	|
	|-RVA: 0x3BAE400 Offset: 0x3BAE501 VA: 0x3BAE400
	|-Array.InternalArray__ICollection_Contains<ClusteringProcessorState>
	|
	|-RVA: 0x3BAE5B0 Offset: 0x3BAE6B1 VA: 0x3BAE5B0
	|-Array.InternalArray__ICollection_Contains<Color>
	|
	|-RVA: 0x3BAE6F0 Offset: 0x3BAE7F1 VA: 0x3BAE6F0
	|-Array.InternalArray__ICollection_Contains<Color32>
	|
	|-RVA: 0x3BAE870 Offset: 0x3BAE971 VA: 0x3BAE870
	|-Array.InternalArray__ICollection_Contains<Color4u8>
	|
	|-RVA: 0x3BAE9A0 Offset: 0x3BAEAA1 VA: 0x3BAE9A0
	|-Array.InternalArray__ICollection_Contains<ColorBlock>
	|
	|-RVA: 0x3BAEB20 Offset: 0x3BAEC21 VA: 0x3BAEB20
	|-Array.InternalArray__ICollection_Contains<CombineInstance>
	|
	|-RVA: 0x3BAED20 Offset: 0x3BAEE21 VA: 0x3BAED20
	|-Array.InternalArray__ICollection_Contains<ConstraintSource>
	|
	|-RVA: 0x3BAEEA0 Offset: 0x3BAEFA1 VA: 0x3BAEEA0
	|-Array.InternalArray__ICollection_Contains<ContactPoint>
	|
	|-RVA: 0x3BAF050 Offset: 0x3BAF151 VA: 0x3BAF050
	|-Array.InternalArray__ICollection_Contains<ContactPoint2D>
	|
	|-RVA: 0x3BAF210 Offset: 0x3BAF311 VA: 0x3BAF210
	|-Array.InternalArray__ICollection_Contains<ContourVertex>
	|
	|-RVA: 0x3BAF3B0 Offset: 0x3BAF4B1 VA: 0x3BAF3B0
	|-Array.InternalArray__ICollection_Contains<CustomAttributeNamedArgument>
	|
	|-RVA: 0x3BAF500 Offset: 0x3BAF601 VA: 0x3BAF500
	|-Array.InternalArray__ICollection_Contains<CustomAttributeTypedArgument>
	|
	|-RVA: 0x3BAF630 Offset: 0x3BAF731 VA: 0x3BAF630
	|-Array.InternalArray__ICollection_Contains<DataStoreRatingInfo>
	|
	|-RVA: 0x3BAF7D0 Offset: 0x3BAF8D1 VA: 0x3BAF7D0
	|-Array.InternalArray__ICollection_Contains<DataStoreResult>
	|
	|-RVA: 0x3BAF950 Offset: 0x3BAFA51 VA: 0x3BAF950
	|-Array.InternalArray__ICollection_Contains<DateTime>
	|
	|-RVA: 0x3BAFA80 Offset: 0x3BAFB81 VA: 0x3BAFA80
	|-Array.InternalArray__ICollection_Contains<DateTimeOffset>
	|
	|-RVA: 0x3BAFBB0 Offset: 0x3BAFCB1 VA: 0x3BAFBB0
	|-Array.InternalArray__ICollection_Contains<DebugPadState>
	|
	|-RVA: 0x3BAFD50 Offset: 0x3BAFE51 VA: 0x3BAFD50
	|-Array.InternalArray__ICollection_Contains<Decimal>
	|
	|-RVA: 0x3BAFE80 Offset: 0x3BAFF81 VA: 0x3BAFE80
	|-Array.InternalArray__ICollection_Contains<DeferredTiler>
	|
	|-RVA: 0x3BB00A0 Offset: 0x3BB01A1 VA: 0x3BB00A0
	|-Array.InternalArray__ICollection_Contains<DeviceHandle>
	|
	|-RVA: 0x3BB0220 Offset: 0x3BB0321 VA: 0x3BB0220
	|-Array.InternalArray__ICollection_Contains<DiagnosticEvent>
	|
	|-RVA: 0x3BB03D0 Offset: 0x3BB04D1 VA: 0x3BB03D0
	|-Array.InternalArray__ICollection_Contains<DictionaryEntry>
	|
	|-RVA: 0x3BB0550 Offset: 0x3BB0651 VA: 0x3BB0550
	|-Array.InternalArray__ICollection_Contains<DictionaryInfo>
	|
	|-RVA: 0x3BB0680 Offset: 0x3BB0781 VA: 0x3BB0680
	|-Array.InternalArray__ICollection_Contains<DirectoryEntry>
	|
	|-RVA: 0x3BB0820 Offset: 0x3BB0921 VA: 0x3BB0820
	|-Array.InternalArray__ICollection_Contains<double>
	|
	|-RVA: 0x3BB0950 Offset: 0x3BB0A51 VA: 0x3BB0950
	|-Array.InternalArray__ICollection_Contains<Ephemeron>
	|
	|-RVA: 0x3BB0AD0 Offset: 0x3BB0BD1 VA: 0x3BB0AD0
	|-Array.InternalArray__ICollection_Contains<FXZ>
	|
	|-RVA: 0x3BB0C00 Offset: 0x3BB0D01 VA: 0x3BB0C00
	|-Array.InternalArray__ICollection_Contains<Finger>
	|
	|-RVA: 0x3BB0D50 Offset: 0x3BB0E51 VA: 0x3BB0D50
	|-Array.InternalArray__ICollection_Contains<Float2>
	|
	|-RVA: 0x3BB0E80 Offset: 0x3BB0F81 VA: 0x3BB0E80
	|-Array.InternalArray__ICollection_Contains<Friend>
	|
	|-RVA: 0x3BB1030 Offset: 0x3BB1131 VA: 0x3BB1030
	|-Array.InternalArray__ICollection_Contains<GCHandle>
	|
	|-RVA: 0x3BB1160 Offset: 0x3BB1261 VA: 0x3BB1160
	|-Array.InternalArray__ICollection_Contains<GesturePoint>
	|
	|-RVA: 0x3BB1290 Offset: 0x3BB1391 VA: 0x3BB1290
	|-Array.InternalArray__ICollection_Contains<GestureState>
	|
	|-RVA: 0x3BB1480 Offset: 0x3BB1581 VA: 0x3BB1480
	|-Array.InternalArray__ICollection_Contains<GlyphMarshallingStruct>
	|
	|-RVA: 0x3BB1630 Offset: 0x3BB1731 VA: 0x3BB1630
	|-Array.InternalArray__ICollection_Contains<GlyphPairAdjustmentRecord>
	|
	|-RVA: 0x3BB17F0 Offset: 0x3BB18F1 VA: 0x3BB17F0
	|-Array.InternalArray__ICollection_Contains<GlyphRect>
	|
	|-RVA: 0x3BB1920 Offset: 0x3BB1A21 VA: 0x3BB1920
	|-Array.InternalArray__ICollection_Contains<Guid>
	|
	|-RVA: 0x3BB1A50 Offset: 0x3BB1B51 VA: 0x3BB1A50
	|-Array.InternalArray__ICollection_Contains<Hand>
	|
	|-RVA: 0x3BB1BB0 Offset: 0x3BB1CB1 VA: 0x3BB1BB0
	|-Array.InternalArray__ICollection_Contains<HandAnalysisImageState>
	|
	|-RVA: 0x3BB1D30 Offset: 0x3BB1E31 VA: 0x3BB1D30
	|-Array.InternalArray__ICollection_Contains<HandAnalysisSilhouetteState>
	|
	|-RVA: 0x3BB1EE0 Offset: 0x3BB1FE1 VA: 0x3BB1EE0
	|-Array.InternalArray__ICollection_Contains<HeaderVariantInfo>
	|
	|-RVA: 0x3BB2060 Offset: 0x3BB2161 VA: 0x3BB2060
	|-Array.InternalArray__ICollection_Contains<HighlightState>
	|
	|-RVA: 0x3BB21B0 Offset: 0x3BB22B1 VA: 0x3BB21B0
	|-Array.InternalArray__ICollection_Contains<HumanBone>
	|
	|-RVA: 0x3BB2370 Offset: 0x3BB2471 VA: 0x3BB2370
	|-Array.InternalArray__ICollection_Contains<short>
	|
	|-RVA: 0x3BB24A0 Offset: 0x3BB25A1 VA: 0x3BB24A0
	|-Array.InternalArray__ICollection_Contains<int>
	|
	|-RVA: 0x3BB25D0 Offset: 0x3BB26D1 VA: 0x3BB25D0
	|-Array.InternalArray__ICollection_Contains<Int32Enum>
	|
	|-RVA: 0x3BB2740 Offset: 0x3BB2841 VA: 0x3BB2740
	|-Array.InternalArray__ICollection_Contains<long>
	|
	|-RVA: 0x3BB2870 Offset: 0x3BB2971 VA: 0x3BB2870
	|-Array.InternalArray__ICollection_Contains<Int64Enum>
	|
	|-RVA: 0x3BB29E0 Offset: 0x3BB2AE1 VA: 0x3BB29E0
	|-Array.InternalArray__ICollection_Contains<IntPtr>
	|
	|-RVA: 0x3BB2B10 Offset: 0x3BB2C11 VA: 0x3BB2B10
	|-Array.InternalArray__ICollection_Contains<InternalCodePageDataItem>
	|
	|-RVA: 0x3BB2C90 Offset: 0x3BB2D91 VA: 0x3BB2C90
	|-Array.InternalArray__ICollection_Contains<InternalEncodingDataItem>
	|
	|-RVA: 0x3BB2E10 Offset: 0x3BB2F11 VA: 0x3BB2E10
	|-Array.InternalArray__ICollection_Contains<InterpretedFrameInfo>
	|
	|-RVA: 0x3BB2F90 Offset: 0x3BB3091 VA: 0x3BB2F90
	|-Array.InternalArray__ICollection_Contains<IntervalTreeNode>
	|
	|-RVA: 0x3BB3130 Offset: 0x3BB3231 VA: 0x3BB3130
	|-Array.InternalArray__ICollection_Contains<JobHandle>
	|
	|-RVA: 0x3BB32B0 Offset: 0x3BB33B1 VA: 0x3BB32B0
	|-Array.InternalArray__ICollection_Contains<Keyframe>
	|
	|-RVA: 0x3BB3460 Offset: 0x3BB3561 VA: 0x3BB3460
	|-Array.InternalArray__ICollection_Contains<LOD>
	|
	|-RVA: 0x3BB35E0 Offset: 0x3BB36E1 VA: 0x3BB35E0
	|-Array.InternalArray__ICollection_Contains<LayerMask>
	|
	|-RVA: 0x3BB3760 Offset: 0x3BB3861 VA: 0x3BB3760
	|-Array.InternalArray__ICollection_Contains<LengthLimitProperties>
	|
	|-RVA: 0x3BB38E0 Offset: 0x3BB39E1 VA: 0x3BB38E0
	|-Array.InternalArray__ICollection_Contains<Light2DBlendStyle>
	|
	|-RVA: 0x3BB3AB0 Offset: 0x3BB3BB1 VA: 0x3BB3AB0
	|-Array.InternalArray__ICollection_Contains<LightDataGI>
	|
	|-RVA: 0x3BB3CA0 Offset: 0x3BB3DA1 VA: 0x3BB3CA0
	|-Array.InternalArray__ICollection_Contains<LocalDefinition>
	|
	|-RVA: 0x3BB3DD0 Offset: 0x3BB3ED1 VA: 0x3BB3DD0
	|-Array.InternalArray__ICollection_Contains<MapPos>
	|
	|-RVA: 0x3BB3F00 Offset: 0x3BB4001 VA: 0x3BB3F00
	|-Array.InternalArray__ICollection_Contains<MapRange>
	|
	|-RVA: 0x3BB40A0 Offset: 0x3BB41A1 VA: 0x3BB40A0
	|-Array.InternalArray__ICollection_Contains<MaterialReference>
	|
	|-RVA: 0x3BB4260 Offset: 0x3BB4361 VA: 0x3BB4260
	|-Array.InternalArray__ICollection_Contains<Matrix4x4>
	|
	|-RVA: 0x3BB43C0 Offset: 0x3BB44C1 VA: 0x3BB43C0
	|-Array.InternalArray__ICollection_Contains<MomentProcessorState>
	|
	|-RVA: 0x3BB4570 Offset: 0x3BB4671 VA: 0x3BB4570
	|-Array.InternalArray__ICollection_Contains<MomentStatistic>
	|
	|-RVA: 0x3BB46B0 Offset: 0x3BB47B1 VA: 0x3BB46B0
	|-Array.InternalArray__ICollection_Contains<Navigation>
	|
	|-RVA: 0x3BB4860 Offset: 0x3BB4961 VA: 0x3BB4860
	|-Array.InternalArray__ICollection_Contains<NetworkServiceAccountId>
	|
	|-RVA: 0x3BB4990 Offset: 0x3BB4A91 VA: 0x3BB4990
	|-Array.InternalArray__ICollection_Contains<NpadFullKeyState>
	|
	|-RVA: 0x3BB4B40 Offset: 0x3BB4C41 VA: 0x3BB4B40
	|-Array.InternalArray__ICollection_Contains<NpadHandheldState>
	|
	|-RVA: 0x3BB4CF0 Offset: 0x3BB4DF1 VA: 0x3BB4CF0
	|-Array.InternalArray__ICollection_Contains<NpadJoyDualState>
	|
	|-RVA: 0x3BB4EA0 Offset: 0x3BB4FA1 VA: 0x3BB4EA0
	|-Array.InternalArray__ICollection_Contains<NpadJoyLeftState>
	|
	|-RVA: 0x3BB5050 Offset: 0x3BB5151 VA: 0x3BB5050
	|-Array.InternalArray__ICollection_Contains<NpadJoyRightState>
	|
	|-RVA: 0x3BB5200 Offset: 0x3BB5301 VA: 0x3BB5200
	|-Array.InternalArray__ICollection_Contains<NpadStateArrayItem>
	|
	|-RVA: 0x3BB53B0 Offset: 0x3BB54B1 VA: 0x3BB53B0
	|-Array.InternalArray__ICollection_Contains<NsUid>
	|
	|-RVA: 0x3BB54E0 Offset: 0x3BB55E1 VA: 0x3BB54E0
	|-Array.InternalArray__ICollection_Contains<object>
	|
	|-RVA: 0x3BB5610 Offset: 0x3BB5711 VA: 0x3BB5610
	|-Array.InternalArray__ICollection_Contains<ObjectInitializationData>
	|
	|-RVA: 0x3BB57C0 Offset: 0x3BB58C1 VA: 0x3BB57C0
	|-Array.InternalArray__ICollection_Contains<ParameterModifier>
	|
	|-RVA: 0x3BB5940 Offset: 0x3BB5A41 VA: 0x3BB5940
	|-Array.InternalArray__ICollection_Contains<Plane>
	|
	|-RVA: 0x3BB5AD0 Offset: 0x3BB5BD1 VA: 0x3BB5AD0
	|-Array.InternalArray__ICollection_Contains<Playable>
	|
	|-RVA: 0x3BB5C50 Offset: 0x3BB5D51 VA: 0x3BB5C50
	|-Array.InternalArray__ICollection_Contains<PlayableBinding>
	|
	|-RVA: 0x3BB5DF0 Offset: 0x3BB5EF1 VA: 0x3BB5DF0
	|-Array.InternalArray__ICollection_Contains<PlayerLoopSystem>
	|
	|-RVA: 0x3BB5FA0 Offset: 0x3BB60A1 VA: 0x3BB5FA0
	|-Array.InternalArray__ICollection_Contains<PlayerLoopSystemInternal>
	|
	|-RVA: 0x3BB6150 Offset: 0x3BB6251 VA: 0x3BB6150
	|-Array.InternalArray__ICollection_Contains<PreTile>
	|
	|-RVA: 0x3BB6310 Offset: 0x3BB6411 VA: 0x3BB6310
	|-Array.InternalArray__ICollection_Contains<Profile>
	|
	|-RVA: 0x3BB64F0 Offset: 0x3BB65F1 VA: 0x3BB64F0
	|-Array.InternalArray__ICollection_Contains<Protrusion>
	|
	|-RVA: 0x3BB6620 Offset: 0x3BB6721 VA: 0x3BB6620
	|-Array.InternalArray__ICollection_Contains<Quaternion>
	|
	|-RVA: 0x3BB6760 Offset: 0x3BB6861 VA: 0x3BB6760
	|-Array.InternalArray__ICollection_Contains<RandomSeed>
	|
	|-RVA: 0x3BB68E0 Offset: 0x3BB69E1 VA: 0x3BB68E0
	|-Array.InternalArray__ICollection_Contains<RangePositionInfo>
	|
	|-RVA: 0x3BB6A60 Offset: 0x3BB6B61 VA: 0x3BB6A60
	|-Array.InternalArray__ICollection_Contains<Ranking2ChartInfoInput>
	|
	|-RVA: 0x3BB6BE0 Offset: 0x3BB6CE1 VA: 0x3BB6BE0
	|-Array.InternalArray__ICollection_Contains<RaycastHit>
	|
	|-RVA: 0x3BB6DA0 Offset: 0x3BB6EA1 VA: 0x3BB6DA0
	|-Array.InternalArray__ICollection_Contains<RaycastHit2D>
	|
	|-RVA: 0x3BB6F50 Offset: 0x3BB7051 VA: 0x3BB6F50
	|-Array.InternalArray__ICollection_Contains<RaycastResult>
	|
	|-RVA: 0x3BB7120 Offset: 0x3BB7221 VA: 0x3BB7120
	|-Array.InternalArray__ICollection_Contains<Rect>
	|
	|-RVA: 0x3BB7260 Offset: 0x3BB7361 VA: 0x3BB7260
	|-Array.InternalArray__ICollection_Contains<RenderBuffer>
	|
	|-RVA: 0x2E2B070 Offset: 0x2E2B171 VA: 0x2E2B070
	|-Array.InternalArray__ICollection_Contains<RenderStateBlock>
	|
	|-RVA: 0x2E2B200 Offset: 0x2E2B301 VA: 0x2E2B200
	|-Array.InternalArray__ICollection_Contains<RenderTargetHandle>
	|
	|-RVA: 0x2E2B350 Offset: 0x2E2B451 VA: 0x2E2B350
	|-Array.InternalArray__ICollection_Contains<RenderTargetIdentifier>
	|
	|-RVA: 0x2E2B4A0 Offset: 0x2E2B5A1 VA: 0x2E2B4A0
	|-Array.InternalArray__ICollection_Contains<RendererListHandle>
	|
	|-RVA: 0x2E2B620 Offset: 0x2E2B721 VA: 0x2E2B620
	|-Array.InternalArray__ICollection_Contains<ResourceHandle>
	|
	|-RVA: 0x2E2B7A0 Offset: 0x2E2B8A1 VA: 0x2E2B7A0
	|-Array.InternalArray__ICollection_Contains<ResourceLocator>
	|
	|-RVA: 0x2E2B920 Offset: 0x2E2BA21 VA: 0x2E2B920
	|-Array.InternalArray__ICollection_Contains<RichTextTagAttribute>
	|
	|-RVA: 0x2E2BAC0 Offset: 0x2E2BBC1 VA: 0x2E2BAC0
	|-Array.InternalArray__ICollection_Contains<RuntimeLabel>
	|
	|-RVA: 0x2E2BC60 Offset: 0x2E2BD61 VA: 0x2E2BC60
	|-Array.InternalArray__ICollection_Contains<sbyte>
	|
	|-RVA: 0x2E2BD90 Offset: 0x2E2BE91 VA: 0x2E2BD90
	|-Array.InternalArray__ICollection_Contains<SerializedType>
	|
	|-RVA: 0x2E2BF30 Offset: 0x2E2C031 VA: 0x2E2BF30
	|-Array.InternalArray__ICollection_Contains<ShaderKeyword>
	|
	|-RVA: 0x2E2C0B0 Offset: 0x2E2C1B1 VA: 0x2E2C0B0
	|-Array.InternalArray__ICollection_Contains<ShaderTagId>
	|
	|-RVA: 0x2E2C1E0 Offset: 0x2E2C2E1 VA: 0x2E2C1E0
	|-Array.InternalArray__ICollection_Contains<ShadowSliceData>
	|
	|-RVA: 0x2E2C3B0 Offset: 0x2E2C4B1 VA: 0x2E2C3B0
	|-Array.InternalArray__ICollection_Contains<Shape>
	|
	|-RVA: 0x2E2C500 Offset: 0x2E2C601 VA: 0x2E2C500
	|-Array.InternalArray__ICollection_Contains<float>
	|
	|-RVA: 0x2E2C630 Offset: 0x2E2C731 VA: 0x2E2C630
	|-Array.InternalArray__ICollection_Contains<SixAxisSensorHandle>
	|
	|-RVA: 0x2E2C7B0 Offset: 0x2E2C8B1 VA: 0x2E2C7B0
	|-Array.InternalArray__ICollection_Contains<SixAxisSensorState>
	|
	|-RVA: 0x2E2C9A0 Offset: 0x2E2CAA1 VA: 0x2E2C9A0
	|-Array.InternalArray__ICollection_Contains<SkeletonBone>
	|
	|-RVA: 0x2E2CB60 Offset: 0x2E2CC61 VA: 0x2E2CB60
	|-Array.InternalArray__ICollection_Contains<SortingLayer>
	|
	|-RVA: 0x2E2CCE0 Offset: 0x2E2CDE1 VA: 0x2E2CCE0
	|-Array.InternalArray__ICollection_Contains<SphericalHarmonicsL2>
	|
	|-RVA: 0x2E2CE70 Offset: 0x2E2CF71 VA: 0x2E2CE70
	|-Array.InternalArray__ICollection_Contains<SpinLock>
	|
	|-RVA: 0x2E2CFF0 Offset: 0x2E2D0F1 VA: 0x2E2CFF0
	|-Array.InternalArray__ICollection_Contains<SpringBoneComponents>
	|
	|-RVA: 0x2E2D1D0 Offset: 0x2E2D2D1 VA: 0x2E2D1D0
	|-Array.InternalArray__ICollection_Contains<SpringBoneProperties>
	|
	|-RVA: 0x2E2D3A0 Offset: 0x2E2D4A1 VA: 0x2E2D3A0
	|-Array.InternalArray__ICollection_Contains<SpringColliderComponents>
	|
	|-RVA: 0x2E2D5C0 Offset: 0x2E2D6C1 VA: 0x2E2D5C0
	|-Array.InternalArray__ICollection_Contains<SpringColliderProperties>
	|
	|-RVA: 0x2E2D740 Offset: 0x2E2D841 VA: 0x2E2D740
	|-Array.InternalArray__ICollection_Contains<SpringForceComponent>
	|
	|-RVA: 0x2E2D900 Offset: 0x2E2DA01 VA: 0x2E2D900
	|-Array.InternalArray__ICollection_Contains<SpringJobElement>
	|
	|-RVA: 0x2E2DAD0 Offset: 0x2E2DBD1 VA: 0x2E2DAD0
	|-Array.InternalArray__ICollection_Contains<SpriteState>
	|
	|-RVA: 0x2E2DC70 Offset: 0x2E2DD71 VA: 0x2E2DC70
	|-Array.InternalArray__ICollection_Contains<SubMeshDescriptor>
	|
	|-RVA: 0x2E2DE20 Offset: 0x2E2DF21 VA: 0x2E2DE20
	|-Array.InternalArray__ICollection_Contains<TMP_CharacterInfo>
	|
	|-RVA: 0x2E2DFD0 Offset: 0x2E2E0D1 VA: 0x2E2DFD0
	|-Array.InternalArray__ICollection_Contains<TMP_FontWeightPair>
	|
	|-RVA: 0x2E2E150 Offset: 0x2E2E251 VA: 0x2E2E150
	|-Array.InternalArray__ICollection_Contains<TMP_LineInfo>
	|
	|-RVA: 0x2E2E350 Offset: 0x2E2E451 VA: 0x2E2E350
	|-Array.InternalArray__ICollection_Contains<TMP_LinkInfo>
	|
	|-RVA: 0x2E2E500 Offset: 0x2E2E601 VA: 0x2E2E500
	|-Array.InternalArray__ICollection_Contains<TMP_MeshInfo>
	|
	|-RVA: 0x2E2E6D0 Offset: 0x2E2E7D1 VA: 0x2E2E6D0
	|-Array.InternalArray__ICollection_Contains<TMP_PageInfo>
	|
	|-RVA: 0x2E2E870 Offset: 0x2E2E971 VA: 0x2E2E870
	|-Array.InternalArray__ICollection_Contains<TMP_WordInfo>
	|
	|-RVA: 0x2E2EA10 Offset: 0x2E2EB11 VA: 0x2E2EA10
	|-Array.InternalArray__ICollection_Contains<TablePair>
	|
	|-RVA: 0x2E2EB90 Offset: 0x2E2EC91 VA: 0x2E2EB90
	|-Array.InternalArray__ICollection_Contains<TextureHandle>
	|
	|-RVA: 0x2E2ED10 Offset: 0x2E2EE11 VA: 0x2E2ED10
	|-Array.InternalArray__ICollection_Contains<TimeSpan>
	|
	|-RVA: 0x2E2EE40 Offset: 0x2E2EF41 VA: 0x2E2EE40
	|-Array.InternalArray__ICollection_Contains<Touch>
	|
	|-RVA: 0x2E2F020 Offset: 0x2E2F121 VA: 0x2E2F020
	|-Array.InternalArray__ICollection_Contains<TouchScreenState1>
	|
	|-RVA: 0x2E2F1E0 Offset: 0x2E2F2E1 VA: 0x2E2F1E0
	|-Array.InternalArray__ICollection_Contains<TouchScreenState10>
	|
	|-RVA: 0x2E2F390 Offset: 0x2E2F491 VA: 0x2E2F390
	|-Array.InternalArray__ICollection_Contains<TouchScreenState11>
	|
	|-RVA: 0x2E2F540 Offset: 0x2E2F641 VA: 0x2E2F540
	|-Array.InternalArray__ICollection_Contains<TouchScreenState12>
	|
	|-RVA: 0x2E2F6F0 Offset: 0x2E2F7F1 VA: 0x2E2F6F0
	|-Array.InternalArray__ICollection_Contains<TouchScreenState13>
	|
	|-RVA: 0x2E2F8A0 Offset: 0x2E2F9A1 VA: 0x2E2F8A0
	|-Array.InternalArray__ICollection_Contains<TouchScreenState14>
	|
	|-RVA: 0x2E2FA50 Offset: 0x2E2FB51 VA: 0x2E2FA50
	|-Array.InternalArray__ICollection_Contains<TouchScreenState15>
	|
	|-RVA: 0x2E2FC00 Offset: 0x2E2FD01 VA: 0x2E2FC00
	|-Array.InternalArray__ICollection_Contains<TouchScreenState16>
	|
	|-RVA: 0x2E2FDB0 Offset: 0x2E2FEB1 VA: 0x2E2FDB0
	|-Array.InternalArray__ICollection_Contains<TouchScreenState2>
	|
	|-RVA: 0x2E2FFA0 Offset: 0x2E300A1 VA: 0x2E2FFA0
	|-Array.InternalArray__ICollection_Contains<TouchScreenState3>
	|
	|-RVA: 0x2E30160 Offset: 0x2E30261 VA: 0x2E30160
	|-Array.InternalArray__ICollection_Contains<TouchScreenState4>
	|
	|-RVA: 0x2E30330 Offset: 0x2E30431 VA: 0x2E30330
	|-Array.InternalArray__ICollection_Contains<TouchScreenState5>
	|
	|-RVA: 0x2E30500 Offset: 0x2E30601 VA: 0x2E30500
	|-Array.InternalArray__ICollection_Contains<TouchScreenState6>
	|
	|-RVA: 0x2E306E0 Offset: 0x2E307E1 VA: 0x2E306E0
	|-Array.InternalArray__ICollection_Contains<TouchScreenState7>
	|
	|-RVA: 0x2E30890 Offset: 0x2E30991 VA: 0x2E30890
	|-Array.InternalArray__ICollection_Contains<TouchScreenState8>
	|
	|-RVA: 0x2E30A40 Offset: 0x2E30B41 VA: 0x2E30A40
	|-Array.InternalArray__ICollection_Contains<TouchScreenState9>
	|
	|-RVA: 0x2E30BF0 Offset: 0x2E30CF1 VA: 0x2E30BF0
	|-Array.InternalArray__ICollection_Contains<TouchState>
	|
	|-RVA: 0x2E30D40 Offset: 0x2E30E41 VA: 0x2E30D40
	|-Array.InternalArray__ICollection_Contains<TrailHand>
	|
	|-RVA: 0x2E30EE0 Offset: 0x2E30FE1 VA: 0x2E30EE0
	|-Array.InternalArray__ICollection_Contains<TrailVertex>
	|
	|-RVA: 0x2E31080 Offset: 0x2E31181 VA: 0x2E31080
	|-Array.InternalArray__ICollection_Contains<UICharInfo>
	|
	|-RVA: 0x2E31220 Offset: 0x2E31321 VA: 0x2E31220
	|-Array.InternalArray__ICollection_Contains<UILineInfo>
	|
	|-RVA: 0x2E313A0 Offset: 0x2E314A1 VA: 0x2E313A0
	|-Array.InternalArray__ICollection_Contains<UIVertex>
	|
	|-RVA: 0x2E315C0 Offset: 0x2E316C1 VA: 0x2E315C0
	|-Array.InternalArray__ICollection_Contains<ushort>
	|
	|-RVA: 0x2E316F0 Offset: 0x2E317F1 VA: 0x2E316F0
	|-Array.InternalArray__ICollection_Contains<UInt16Enum>
	|
	|-RVA: 0x2E31860 Offset: 0x2E31961 VA: 0x2E31860
	|-Array.InternalArray__ICollection_Contains<uint>
	|
	|-RVA: 0x2E31990 Offset: 0x2E31A91 VA: 0x2E31990
	|-Array.InternalArray__ICollection_Contains<UInt32Enum>
	|
	|-RVA: 0x2E31B00 Offset: 0x2E31C01 VA: 0x2E31B00
	|-Array.InternalArray__ICollection_Contains<ulong>
	|
	|-RVA: 0x2E31C30 Offset: 0x2E31D31 VA: 0x2E31C30
	|-Array.InternalArray__ICollection_Contains<Uid>
	|
	|-RVA: 0x2E31D60 Offset: 0x2E31E61 VA: 0x2E31D60
	|-Array.InternalArray__ICollection_Contains<UniTask>
	|
	|-RVA: 0x2E31EE0 Offset: 0x2E31FE1 VA: 0x2E31EE0
	|-Array.InternalArray__ICollection_Contains<Unit>
	|
	|-RVA: 0x2E32010 Offset: 0x2E32111 VA: 0x2E32010
	|-Array.InternalArray__ICollection_Contains<UnitEnum>
	|
	|-RVA: 0x2E32190 Offset: 0x2E32291 VA: 0x2E32190
	|-Array.InternalArray__ICollection_Contains<UserWord>
	|
	|-RVA: 0x2E32310 Offset: 0x2E32411 VA: 0x2E32310
	|-Array.InternalArray__ICollection_Contains<Vector2>
	|
	|-RVA: 0x2E32440 Offset: 0x2E32541 VA: 0x2E32440
	|-Array.InternalArray__ICollection_Contains<Vector2Int>
	|
	|-RVA: 0x2E325F0 Offset: 0x2E326F1 VA: 0x2E325F0
	|-Array.InternalArray__ICollection_Contains<Vector3>
	|
	|-RVA: 0x2E32730 Offset: 0x2E32831 VA: 0x2E32730
	|-Array.InternalArray__ICollection_Contains<Vector4>
	|
	|-RVA: 0x2E32870 Offset: 0x2E32971 VA: 0x2E32870
	|-Array.InternalArray__ICollection_Contains<VertexAttributeDescriptor>
	|
	|-RVA: 0x2E329A0 Offset: 0x2E32AA1 VA: 0x2E329A0
	|-Array.InternalArray__ICollection_Contains<VibrationDeviceHandle>
	|
	|-RVA: 0x2E32B20 Offset: 0x2E32C21 VA: 0x2E32B20
	|-Array.InternalArray__ICollection_Contains<VibrationDeviceInfo>
	|
	|-RVA: 0x2E32CA0 Offset: 0x2E32DA1 VA: 0x2E32CA0
	|-Array.InternalArray__ICollection_Contains<VibrationValue>
	|
	|-RVA: 0x2E32E30 Offset: 0x2E32F31 VA: 0x2E32E30
	|-Array.InternalArray__ICollection_Contains<VisibleLight>
	|
	|-RVA: 0x2E32FC0 Offset: 0x2E330C1 VA: 0x2E32FC0
	|-Array.InternalArray__ICollection_Contains<WordWrapState>
	|
	|-RVA: 0x2E33170 Offset: 0x2E33271 VA: 0x2E33170
	|-Array.InternalArray__ICollection_Contains<X509ChainStatus>
	|
	|-RVA: 0x2E332F0 Offset: 0x2E333F1 VA: 0x2E332F0
	|-Array.InternalArray__ICollection_Contains<XPathNode>
	|
	|-RVA: 0x2E33490 Offset: 0x2E33591 VA: 0x2E33490
	|-Array.InternalArray__ICollection_Contains<XPathNodeRef>
	|
	|-RVA: 0x2E33610 Offset: 0x2E33711 VA: 0x2E33610
	|-Array.InternalArray__ICollection_Contains<XRView>
	|
	|-RVA: 0x2E337D0 Offset: 0x2E338D1 VA: 0x2E337D0
	|-Array.InternalArray__ICollection_Contains<float3>
	|
	|-RVA: 0x2E33910 Offset: 0x2E33A11 VA: 0x2E33910
	|-Array.InternalArray__ICollection_Contains<float4x4>
	|
	|-RVA: 0x2E33A70 Offset: 0x2E33B71 VA: 0x2E33A70
	|-Array.InternalArray__ICollection_Contains<jvalue>
	|
	|-RVA: 0x2E33BF0 Offset: 0x2E33CF1 VA: 0x2E33BF0
	|-Array.InternalArray__ICollection_Contains<uint4>
	|
	|-RVA: 0x2E33D20 Offset: 0x2E33E21 VA: 0x2E33D20
	|-Array.InternalArray__ICollection_Contains<AICrossfire.PositionTable>
	|
	|-RVA: 0x2E33EC0 Offset: 0x2E33FC1 VA: 0x2E33EC0
	|-Array.InternalArray__ICollection_Contains<AIEnum.SkillRangeEnemyData>
	|
	|-RVA: 0x2E34040 Offset: 0x2E34141 VA: 0x2E34040
	|-Array.InternalArray__ICollection_Contains<AIOrder.UnitPriority>
	|
	|-RVA: 0x2E341C0 Offset: 0x2E342C1 VA: 0x2E341C0
	|-Array.InternalArray__ICollection_Contains<AmiiboSequence.GainItemData>
	|
	|-RVA: 0x2E34340 Offset: 0x2E34441 VA: 0x2E34340
	|-Array.InternalArray__ICollection_Contains<AnimationOutputWeightProcessor.WeightInfo>
	|
	|-RVA: 0x2E344F0 Offset: 0x2E345F1 VA: 0x2E344F0
	|-Array.InternalArray__ICollection_Contains<ArenaOrderSequence.GodInfo>
	|
	|-RVA: 0x2E34670 Offset: 0x2E34771 VA: 0x2E34670
	|-Array.InternalArray__ICollection_Contains<BattleInfo.SupportData>
	|
	|-RVA: 0x2E347F0 Offset: 0x2E348F1 VA: 0x2E347F0
	|-Array.InternalArray__ICollection_Contains<BeforeRenderHelper.OrderBlock>
	|
	|-RVA: 0x2E34970 Offset: 0x2E34A71 VA: 0x2E34970
	|-Array.InternalArray__ICollection_Contains<Camera.RenderRequest>
	|
	|-RVA: 0x2E34B10 Offset: 0x2E34C11 VA: 0x2E34B10
	|-Array.InternalArray__ICollection_Contains<CameraState.CustomBlendable>
	|
	|-RVA: 0x2E34C90 Offset: 0x2E34D91 VA: 0x2E34C90
	|-Array.InternalArray__ICollection_Contains<CinemachineBlendListCamera.Instruction>
	|
	|-RVA: 0x2E34E30 Offset: 0x2E34F31 VA: 0x2E34E30
	|-Array.InternalArray__ICollection_Contains<CinemachineBlenderSettings.CustomBlend>
	|
	|-RVA: 0x2E34FD0 Offset: 0x2E350D1 VA: 0x2E34FD0
	|-Array.InternalArray__ICollection_Contains<CinemachineClearShot.Pair>
	|
	|-RVA: 0x2E35150 Offset: 0x2E35251 VA: 0x2E35150
	|-Array.InternalArray__ICollection_Contains<CinemachineFreeLook.Orbit>
	|
	|-RVA: 0x2E352D0 Offset: 0x2E353D1 VA: 0x2E352D0
	|-Array.InternalArray__ICollection_Contains<CinemachinePath.Waypoint>
	|
	|-RVA: 0x2E35480 Offset: 0x2E35581 VA: 0x2E35480
	|-Array.InternalArray__ICollection_Contains<CinemachineSmoothPath.Waypoint>
	|
	|-RVA: 0x2E35610 Offset: 0x2E35711 VA: 0x2E35610
	|-Array.InternalArray__ICollection_Contains<CinemachineStateDrivenCamera.HashPair>
	|
	|-RVA: 0x2E35790 Offset: 0x2E35891 VA: 0x2E35790
	|-Array.InternalArray__ICollection_Contains<CinemachineStateDrivenCamera.Instruction>
	|
	|-RVA: 0x2E35930 Offset: 0x2E35A31 VA: 0x2E35930
	|-Array.InternalArray__ICollection_Contains<CinemachineStateDrivenCamera.ParentHash>
	|
	|-RVA: 0x2E35AB0 Offset: 0x2E35BB1 VA: 0x2E35AB0
	|-Array.InternalArray__ICollection_Contains<CinemachineTargetGroup.Target>
	|
	|-RVA: 0x2E35C30 Offset: 0x2E35D31 VA: 0x2E35C30
	|-Array.InternalArray__ICollection_Contains<CodePointIndexer.TableRange>
	|
	|-RVA: 0x2E35DD0 Offset: 0x2E35ED1 VA: 0x2E35DD0
	|-Array.InternalArray__ICollection_Contains<ContentCatalogData.Bucket>
	|
	|-RVA: 0x2E35F50 Offset: 0x2E36051 VA: 0x2E35F50
	|-Array.InternalArray__ICollection_Contains<CookieTokenizer.RecognizedAttribute>
	|
	|-RVA: 0x2E360D0 Offset: 0x2E361D1 VA: 0x2E360D0
	|-Array.InternalArray__ICollection_Contains<DeferredLights.DrawCall>
	|
	|-RVA: 0x2E36280 Offset: 0x2E36381 VA: 0x2E36280
	|-Array.InternalArray__ICollection_Contains<DeferredShaderData.ComputeBufferInfo>
	|
	|-RVA: 0x2E36400 Offset: 0x2E36501 VA: 0x2E36400
	|-Array.InternalArray__ICollection_Contains<DeferredTiler.PrePunctualLight>
	|
	|-RVA: 0x2E365A0 Offset: 0x2E366A1 VA: 0x2E365A0
	|-Array.InternalArray__ICollection_Contains<DelayedActionManager.DelegateInfo>
	|
	|-RVA: 0x2E36740 Offset: 0x2E36841 VA: 0x2E36740
	|-Array.InternalArray__ICollection_Contains<Detail.AsyncResultInt>
	|
	|-RVA: 0x2E368F0 Offset: 0x2E369F1 VA: 0x2E368F0
	|-Array.InternalArray__ICollection_Contains<Detail.CppArray>
	|
	|-RVA: 0x2E36A70 Offset: 0x2E36B71 VA: 0x2E36A70
	|-Array.InternalArray__ICollection_Contains<Detail.NotificationEventInt>
	|
	|-RVA: 0x2E36C20 Offset: 0x2E36D21 VA: 0x2E36C20
	|-Array.InternalArray__ICollection_Contains<DisposUnit.Item>
	|
	|-RVA: 0x2E36DA0 Offset: 0x2E36EA1 VA: 0x2E36DA0
	|-Array.InternalArray__ICollection_Contains<DragonRidePresetParamData.CourseData>
	|
	|-RVA: 0x2E36F40 Offset: 0x2E37041 VA: 0x2E36F40
	|-Array.InternalArray__ICollection_Contains<DragonRideTargetGroup.ChainParam>
	|
	|-RVA: 0x2E370C0 Offset: 0x2E371C1 VA: 0x2E370C0
	|-Array.InternalArray__ICollection_Contains<DynamicMesh.State>
	|
	|-RVA: 0x2E37240 Offset: 0x2E37341 VA: 0x2E37240
	|-Array.InternalArray__ICollection_Contains<FXZEx.HitPoint>
	|
	|-RVA: 0x2E373F0 Offset: 0x2E374F1 VA: 0x2E373F0
	|-Array.InternalArray__ICollection_Contains<FishingRadicalParamData.RadicalParam>
	|
	|-RVA: 0x2E37590 Offset: 0x2E37691 VA: 0x2E37590
	|-Array.InternalArray__ICollection_Contains<GameVariable.Value>
	|
	|-RVA: 0x2E37710 Offset: 0x2E37811 VA: 0x2E37710
	|-Array.InternalArray__ICollection_Contains<GmapPathAdjuster.TargetModel>
	|
	|-RVA: 0x2E378B0 Offset: 0x2E379B1 VA: 0x2E378B0
	|-Array.InternalArray__ICollection_Contains<GmapSpotAdjuster.TargetModel>
	|
	|-RVA: 0x2E37A50 Offset: 0x2E37B51 VA: 0x2E37A50
	|-Array.InternalArray__ICollection_Contains<GrounderQuadruped.Foot>
	|
	|-RVA: 0x2E37C00 Offset: 0x2E37D01 VA: 0x2E37C00
	|-Array.InternalArray__ICollection_Contains<Hashtable.bucket>
	|
	|-RVA: 0x2E37DA0 Offset: 0x2E37EA1 VA: 0x2E37DA0
	|-Array.InternalArray__ICollection_Contains<HeadingTracker.Item>
	|
	|-RVA: 0x2E37F40 Offset: 0x2E38041 VA: 0x2E37F40
	|-Array.InternalArray__ICollection_Contains<HubAccessoryRoomCamera.BackgroundSettings>
	|
	|-RVA: 0x2E380F0 Offset: 0x2E381F1 VA: 0x2E380F0
	|-Array.InternalArray__ICollection_Contains<HubFastTravel.Location>
	|
	|-RVA: 0x2E38290 Offset: 0x2E38391 VA: 0x2E38290
	|-Array.InternalArray__ICollection_Contains<HubLensFlare.Flare>
	|
	|-RVA: 0x2E38440 Offset: 0x2E38541 VA: 0x2E38440
	|-Array.InternalArray__ICollection_Contains<HubLookAtController.LookAtIKParam>
	|
	|-RVA: 0x2E385E0 Offset: 0x2E386E1 VA: 0x2E385E0
	|-Array.InternalArray__ICollection_Contains<HubMaterialArray.MaterialInfo>
	|
	|-RVA: 0x2E38760 Offset: 0x2E38861 VA: 0x2E38760
	|-Array.InternalArray__ICollection_Contains<IKSolverLimb.AxisDirection>
	|
	|-RVA: 0x2E38910 Offset: 0x2E38A11 VA: 0x2E38910
	|-Array.InternalArray__ICollection_Contains<InventoryPoolItemMenuContent.KindBgNameClass>
	|
	|-RVA: 0x2E38A90 Offset: 0x2E38B91 VA: 0x2E38A90
	|-Array.InternalArray__ICollection_Contains<LightUtility.ParametricLightMeshVertex>
	|
	|-RVA: 0x2E38C40 Offset: 0x2E38D41 VA: 0x2E38C40
	|-Array.InternalArray__ICollection_Contains<LightUtility.SpriteLightMeshVertex>
	|
	|-RVA: 0x2E38DF0 Offset: 0x2E38EF1 VA: 0x2E38DF0
	|-Array.InternalArray__ICollection_Contains<Map.Pos>
	|
	|-RVA: 0x2E38F70 Offset: 0x2E39071 VA: 0x2E38F70
	|-Array.InternalArray__ICollection_Contains<MapGodExp.KindDesc>
	|
	|-RVA: 0x2E390F0 Offset: 0x2E391F1 VA: 0x2E390F0
	|-Array.InternalArray__ICollection_Contains<MapHistory.Command>
	|
	|-RVA: 0x2E39270 Offset: 0x2E39371 VA: 0x2E39270
	|-Array.InternalArray__ICollection_Contains<MapImage.BackupTerrain>
	|
	|-RVA: 0x2E393F0 Offset: 0x2E394F1 VA: 0x2E393F0
	|-Array.InternalArray__ICollection_Contains<MapImageRange.Pos>
	|
	|-RVA: 0x2E39570 Offset: 0x2E39671 VA: 0x2E39570
	|-Array.InternalArray__ICollection_Contains<MapKillBonus.KillBonus>
	|
	|-RVA: 0x2E396F0 Offset: 0x2E397F1 VA: 0x2E396F0
	|-Array.InternalArray__ICollection_Contains<MapKillBonus.KilledBonus>
	|
	|-RVA: 0x2E39870 Offset: 0x2E39971 VA: 0x2E39870
	|-Array.InternalArray__ICollection_Contains<MapMind.Record>
	|
	|-RVA: 0x2E39A40 Offset: 0x2E39B41 VA: 0x2E39A40
	|-Array.InternalArray__ICollection_Contains<MapMind.Target>
	|
	|-RVA: 0x2E39BE0 Offset: 0x2E39CE1 VA: 0x2E39BE0
	|-Array.InternalArray__ICollection_Contains<MapPanelDebug.Entity>
	|
	|-RVA: 0x2E39D80 Offset: 0x2E39E81 VA: 0x2E39D80
	|-Array.InternalArray__ICollection_Contains<NexRanking.Data>
	|
	|-RVA: 0x2E39F00 Offset: 0x2E3A001 VA: 0x2E39F00
	|-Array.InternalArray__ICollection_Contains<NexVersus.RatingData>
	|
	|-RVA: 0x2E3A080 Offset: 0x2E3A181 VA: 0x2E3A080
	|-Array.InternalArray__ICollection_Contains<NoiseSettings.TransformNoiseParams>
	|
	|-RVA: 0x2E3A230 Offset: 0x2E3A331 VA: 0x2E3A230
	|-Array.InternalArray__ICollection_Contains<PackedPlayModeBuildLogs.RuntimeBuildLog>
	|
	|-RVA: 0x2E3A3B0 Offset: 0x2E3A4B1 VA: 0x2E3A3B0
	|-Array.InternalArray__ICollection_Contains<ParameterizedStrings.FormatParam>
	|
	|-RVA: 0x2E3A530 Offset: 0x2E3A631 VA: 0x2E3A530
	|-Array.InternalArray__ICollection_Contains<ParticleSystem.Particle>
	|
	|-RVA: 0x2E3A6F0 Offset: 0x2E3A7F1 VA: 0x2E3A6F0
	|-Array.InternalArray__ICollection_Contains<ProfileCard.Achievement>
	|
	|-RVA: 0x2E3A870 Offset: 0x2E3A971 VA: 0x2E3A870
	|-Array.InternalArray__ICollection_Contains<ProfileCard.SortieCount>
	|
	|-RVA: 0x2E3AA10 Offset: 0x2E3AB11 VA: 0x2E3AA10
	|-Array.InternalArray__ICollection_Contains<QualitySettingsStack.Settings>
	|
	|-RVA: 0x2E3ABC0 Offset: 0x2E3ACC1 VA: 0x2E3ABC0
	|-Array.InternalArray__ICollection_Contains<RangeData.Offset>
	|
	|-RVA: 0x2E3AD40 Offset: 0x2E3AE41 VA: 0x2E3AD40
	|-Array.InternalArray__ICollection_Contains<RegexCharClass.LowerCaseMapping>
	|
	|-RVA: 0x2E3AEE0 Offset: 0x2E3AFE1 VA: 0x2E3AEE0
	|-Array.InternalArray__ICollection_Contains<Relay.ChooseAwardeeData>
	|
	|-RVA: 0x2E3B080 Offset: 0x2E3B181 VA: 0x2E3B080
	|-Array.InternalArray__ICollection_Contains<RelayAwardData.Info>
	|
	|-RVA: 0x2E3B200 Offset: 0x2E3B301 VA: 0x2E3B200
	|-Array.InternalArray__ICollection_Contains<RenderGraph.CompiledPassInfo>
	|
	|-RVA: 0x2E3B3D0 Offset: 0x2E3B4D1 VA: 0x2E3B3D0
	|-Array.InternalArray__ICollection_Contains<RenderGraph.CompiledResourceInfo>
	|
	|-RVA: 0x2E3B570 Offset: 0x2E3B671 VA: 0x2E3B570
	|-Array.InternalArray__ICollection_Contains<RenderGraphDebugData.PassDebugData>
	|
	|-RVA: 0x2E3B710 Offset: 0x2E3B811 VA: 0x2E3B710
	|-Array.InternalArray__ICollection_Contains<RenderGraphDebugData.ResourceDebugData>
	|
	|-RVA: 0x2E3B8C0 Offset: 0x2E3B9C1 VA: 0x2E3B8C0
	|-Array.InternalArray__ICollection_Contains<RenderGraphResourceRegistry.RendererListResource>
	|
	|-RVA: 0x2E3BA70 Offset: 0x2E3BB71 VA: 0x2E3BA70
	|-Array.InternalArray__ICollection_Contains<RingCleaningUnitSelectMenu.GodParam>
	|
	|-RVA: 0x2E3BBF0 Offset: 0x2E3BCF1 VA: 0x2E3BBF0
	|-Array.InternalArray__ICollection_Contains<SampleWave.Data>
	|
	|-RVA: 0x2E3BD80 Offset: 0x2E3BE81 VA: 0x2E3BD80
	|-Array.InternalArray__ICollection_Contains<SampleWave.Temp>
	|
	|-RVA: 0x2E3BF00 Offset: 0x2E3C001 VA: 0x2E3BF00
	|-Array.InternalArray__ICollection_Contains<SendMouseEvents.HitInfo>
	|
	|-RVA: 0x2E3C080 Offset: 0x2E3C181 VA: 0x2E3C080
	|-Array.InternalArray__ICollection_Contains<SequenceNode.SequenceConstructPosContext>
	|
	|-RVA: 0x2E3C230 Offset: 0x2E3C331 VA: 0x2E3C230
	|-Array.InternalArray__ICollection_Contains<ShaderInput.LightData>
	|
	|-RVA: 0x2E3C400 Offset: 0x2E3C501 VA: 0x2E3C400
	|-Array.InternalArray__ICollection_Contains<ShaderInput.ShadowData>
	|
	|-RVA: 0x2E3C5D0 Offset: 0x2E3C6D1 VA: 0x2E3C5D0
	|-Array.InternalArray__ICollection_Contains<ShadowUtility.Edge>
	|
	|-RVA: 0x2E3C780 Offset: 0x2E3C881 VA: 0x2E3C780
	|-Array.InternalArray__ICollection_Contains<SimpleAnimationPlayable.QueuedState>
	|
	|-RVA: 0x2E3C900 Offset: 0x2E3CA01 VA: 0x2E3C900
	|-Array.InternalArray__ICollection_Contains<SkillArray.Entity>
	|
	|-RVA: 0x2E3CA80 Offset: 0x2E3CB81 VA: 0x2E3CA80
	|-Array.InternalArray__ICollection_Contains<Socket.WSABUF>
	|
	|-RVA: 0x2E3CC00 Offset: 0x2E3CD01 VA: 0x2E3CC00
	|-Array.InternalArray__ICollection_Contains<Stream.Info>
	|
	|-RVA: 0x2E3CDA0 Offset: 0x2E3CEA1 VA: 0x2E3CDA0
	|-Array.InternalArray__ICollection_Contains<TMP_Text.UnicodeChar>
	|
	|-RVA: 0x2E3CF40 Offset: 0x2E3D041 VA: 0x2E3CF40
	|-Array.InternalArray__ICollection_Contains<TexturePacker_JsonArray.Frame>
	|
	|-RVA: 0x2E3D100 Offset: 0x2E3D201 VA: 0x2E3D100
	|-Array.InternalArray__ICollection_Contains<TimeNotificationBehaviour.NotificationEntry>
	|
	|-RVA: 0x2E3D2A0 Offset: 0x2E3D3A1 VA: 0x2E3D2A0
	|-Array.InternalArray__ICollection_Contains<UnitySynchronizationContext.WorkRequest>
	|
	|-RVA: 0x2E3D440 Offset: 0x2E3D541 VA: 0x2E3D440
	|-Array.InternalArray__ICollection_Contains<XmlNamespaceManager.NamespaceDeclaration>
	|
	|-RVA: 0x2E3D5E0 Offset: 0x2E3D6E1 VA: 0x2E3D5E0
	|-Array.InternalArray__ICollection_Contains<XmlSchemaObjectTable.XmlSchemaObjectEntry>
	|
	|-RVA: 0x2E3D760 Offset: 0x2E3D861 VA: 0x2E3D760
	|-Array.InternalArray__ICollection_Contains<XmlTextReaderImpl.ParsingState>
	|
	|-RVA: 0x2E3D980 Offset: 0x2E3DA81 VA: 0x2E3D980
	|-Array.InternalArray__ICollection_Contains<AIThink.EnchantThink.Desc>
	|
	|-RVA: 0x2E3DB00 Offset: 0x2E3DC01 VA: 0x2E3DB00
	|-Array.InternalArray__ICollection_Contains<AIThink.EnchantThink.ItemInfo>
	|
	|-RVA: 0x2E3DC80 Offset: 0x2E3DD81 VA: 0x2E3DC80
	|-Array.InternalArray__ICollection_Contains<AIThink.EnchantThink.SurroundingInfo>
	|
	|-RVA: 0x2E3DE00 Offset: 0x2E3DF01 VA: 0x2E3DE00
	|-Array.InternalArray__ICollection_Contains<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>
	|
	|-RVA: 0x2E3DF80 Offset: 0x2E3E081 VA: 0x2E3DF80
	|-Array.InternalArray__ICollection_Contains<Detail.DataStore.DataStoreChangeMetaParamInt>
	|
	|-RVA: 0x2E3E160 Offset: 0x2E3E261 VA: 0x2E3E160
	|-Array.InternalArray__ICollection_Contains<Detail.DataStore.DataStoreDeleteParamInt>
	|
	|-RVA: 0x2E3E2E0 Offset: 0x2E3E3E1 VA: 0x2E3E2E0
	|-Array.InternalArray__ICollection_Contains<Detail.DataStore.DataStoreGetMetaParamInt>
	|
	|-RVA: 0x2E3E490 Offset: 0x2E3E591 VA: 0x2E3E490
	|-Array.InternalArray__ICollection_Contains<Detail.DataStore.DataStoreMetaInfoInt>
	|
	|-RVA: 0x2E3E660 Offset: 0x2E3E761 VA: 0x2E3E660
	|-Array.InternalArray__ICollection_Contains<Detail.DataStore.DataStorePasswordInfoInt>
	|
	|-RVA: 0x2E3E800 Offset: 0x2E3E901 VA: 0x2E3E800
	|-Array.InternalArray__ICollection_Contains<Detail.DataStore.DataStorePersistenceInfoInt>
	|
	|-RVA: 0x2E3E9A0 Offset: 0x2E3EAA1 VA: 0x2E3E9A0
	|-Array.InternalArray__ICollection_Contains<Detail.DataStore.DataStorePreparePostParamInt>
	|
	|-RVA: 0x2E3EB60 Offset: 0x2E3EC61 VA: 0x2E3EB60
	|-Array.InternalArray__ICollection_Contains<Detail.DataStore.DataStoreRateObjectParamInt>
	|
	|-RVA: 0x2E3ECE0 Offset: 0x2E3EDE1 VA: 0x2E3ECE0
	|-Array.InternalArray__ICollection_Contains<Detail.DataStore.DataStoreRatingInitParamInt>
	|
	|-RVA: 0x2E3EE80 Offset: 0x2E3EF81 VA: 0x2E3EE80
	|-Array.InternalArray__ICollection_Contains<Detail.DataStore.DataStoreRatingTargetInt>
	|
	|-RVA: 0x2E3F000 Offset: 0x2E3F101 VA: 0x2E3F000
	|-Array.InternalArray__ICollection_Contains<Detail.Ranking.RankingCachedResultInt>
	|
	|-RVA: 0x2E3F1C0 Offset: 0x2E3F2C1 VA: 0x2E3F1C0
	|-Array.InternalArray__ICollection_Contains<Detail.Ranking.RankingOrderParamInt>
	|
	|-RVA: 0x2E3F340 Offset: 0x2E3F441 VA: 0x2E3F340
	|-Array.InternalArray__ICollection_Contains<Detail.Ranking.RankingRankDataInt>
	|
	|-RVA: 0x2E3F500 Offset: 0x2E3F601 VA: 0x2E3F500
	|-Array.InternalArray__ICollection_Contains<Detail.Ranking2.Ranking2ChartInfoInt>
	|
	|-RVA: 0x2E3F6F0 Offset: 0x2E3F7F1 VA: 0x2E3F6F0
	|-Array.InternalArray__ICollection_Contains<Detail.Ranking2.Ranking2RankDataInt>
	|
	|-RVA: 0x2E3F8B0 Offset: 0x2E3F9B1 VA: 0x2E3F8B0
	|-Array.InternalArray__ICollection_Contains<Detail.Ranking2.Ranking2ScoreDataInt>
	|
	|-RVA: 0x2E3FA30 Offset: 0x2E3FB31 VA: 0x2E3FA30
	|-Array.InternalArray__ICollection_Contains<Detail.Screening.ScreeningContextInfoInt>
	|
	|-RVA: 0x2E3FBD0 Offset: 0x2E3FCD1 VA: 0x2E3FBD0
	|-Array.InternalArray__ICollection_Contains<Detail.Subscriber.SubscriberContentInt>
	|
	|-RVA: 0x2E3FDA0 Offset: 0x2E3FEA1 VA: 0x2E3FDA0
	|-Array.InternalArray__ICollection_Contains<Detail.Subscriber.SubscriberGetContentParamInt>
	|
	|-RVA: 0x2E3FF40 Offset: 0x2E40041 VA: 0x2E3FF40
	|-Array.InternalArray__ICollection_Contains<Detail.Subscriber.SubscriberUserStatusInfoInt>
	|
	|-RVA: 0x2E400F0 Offset: 0x2E401F1 VA: 0x2E400F0
	|-Array.InternalArray__ICollection_Contains<Detail.Subscriber.SubscriberUserStatusParamInt>
	|
	|-RVA: 0x2E40290 Offset: 0x2E40391 VA: 0x2E40290
	|-Array.InternalArray__ICollection_Contains<Detail.Utility.IntegerSettings>
	|
	|-RVA: 0x2E40410 Offset: 0x2E40511 VA: 0x2E40410
	|-Array.InternalArray__ICollection_Contains<Detail.Utility.UniqueIdInfoInt>
	|
	|-RVA: 0x2E40590 Offset: 0x2E40691 VA: 0x2E40590
	|-Array.InternalArray__ICollection_Contains<FacetsChecker.FacetsCompiler.Map>
	|
	|-RVA: 0x2E40710 Offset: 0x2E40811 VA: 0x2E40710
	|-Array.InternalArray__ICollection_Contains<MapHistory.ReplayAppearanceMap.Appearance>
	|
	|-RVA: 0x2E408B0 Offset: 0x2E409B1 VA: 0x2E408B0
	|-Array.InternalArray__ICollection_Contains<MapHistory.ReplayAppearanceMap.Leaving>
	|
	|-RVA: 0x2E40A30 Offset: 0x2E40B31 VA: 0x2E40A30
	|-Array.InternalArray__ICollection_Contains<MapHistory.ReplayUnitMap.Data>
	|
	|-RVA: 0x2E40BB0 Offset: 0x2E40CB1 VA: 0x2E40BB0
	|-Array.InternalArray__ICollection_Contains<MapHistory.Rewind.LatestInspectorData>
	|
	|-RVA: 0x2E40D50 Offset: 0x2E40E51 VA: 0x2E40D50
	|-Array.InternalArray__ICollection_Contains<MapHistory.Rewind.WorkTerrainData>
	|
	|-RVA: 0x2E40EF0 Offset: 0x2E40FF1 VA: 0x2E40EF0
	|-Array.InternalArray__ICollection_Contains<MapHistory.RewindUnitMap.Data>
	|
	|-RVA: 0x2E410A0 Offset: 0x2E411A1 VA: 0x2E410A0
	|-Array.InternalArray__ICollection_Contains<MapKillBonus.Work.Pos>
	|
	|-RVA: 0x2E41220 Offset: 0x2E41321 VA: 0x2E41220
	|-Array.InternalArray__ICollection_Contains<MapSkill.AroundCalculator.Result>
	|
	|-RVA: 0x2E413A0 Offset: 0x2E414A1 VA: 0x2E413A0
	|-Array.InternalArray__ICollection_Contains<Nex.ApiCallChecker.Guideline>
	|
	|-RVA: 0x2E41520 Offset: 0x2E41621 VA: 0x2E41520
	|-Array.InternalArray__ICollection_Contains<Ngc.MaskTextSequenceBase.Data>
	|
	|-RVA: 0x2E416C0 Offset: 0x2E417C1 VA: 0x2E416C0
	|-Array.InternalArray__ICollection_Contains<TargetPositionCache.CacheCurve.Item>
	|
	|-RVA: 0x2E41870 Offset: 0x2E41971 VA: 0x2E41870
	|-Array.InternalArray__ICollection_Contains<TargetPositionCache.CacheEntry.RecordingItem>
	|
	|-RVA: 0x2E41A20 Offset: 0x2E41B21 VA: 0x2E41A20
	|-Array.InternalArray__ICollection_Contains<TerrainUtility.TerrainMap.TileCoord>
	*/

	// RVA: -1 Offset: -1
	internal void InternalArray__ICollection_CopyTo<T>(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E41BA0 Offset: 0x2E41CA1 VA: 0x2E41BA0
	|-Array.InternalArray__ICollection_CopyTo<ArraySegment<byte>>
	|
	|-RVA: 0x2E41C00 Offset: 0x2E41D01 VA: 0x2E41C00
	|-Array.InternalArray__ICollection_CopyTo<AsyncOperationHandle<object>>
	|
	|-RVA: 0x2E41C60 Offset: 0x2E41D61 VA: 0x2E41C60
	|-Array.InternalArray__ICollection_CopyTo<MapDeployTemplate.Queue.Data<object>>
	|
	|-RVA: 0x2E41CC0 Offset: 0x2E41DC1 VA: 0x2E41CC0
	|-Array.InternalArray__ICollection_CopyTo<Nex.DataStore.ParamPool.Data<object>>
	|
	|-RVA: 0x2E41D20 Offset: 0x2E41E21 VA: 0x2E41D20
	|-Array.InternalArray__ICollection_CopyTo<Nex.Screening.ParamPool.Data<object>>
	|
	|-RVA: 0x2E41D80 Offset: 0x2E41E81 VA: 0x2E41D80
	|-Array.InternalArray__ICollection_CopyTo<IntervalTree.Entry<object>>
	|
	|-RVA: 0x2E41DE0 Offset: 0x2E41EE1 VA: 0x2E41DE0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<ValueTuple<object, int>, object>>
	|
	|-RVA: 0x2E41E40 Offset: 0x2E41F41 VA: 0x2E41E40
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<byte, object>>
	|
	|-RVA: 0x2E41EA0 Offset: 0x2E41FA1 VA: 0x2E41EA0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<CancellationToken, object>>
	|
	|-RVA: 0x2E41F00 Offset: 0x2E42001 VA: 0x2E41F00
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<char, object>>
	|
	|-RVA: 0x2E41F60 Offset: 0x2E42061 VA: 0x2E41F60
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Guid, object>>
	|
	|-RVA: 0x2E41FC0 Offset: 0x2E420C1 VA: 0x2E41FC0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<int, bool>>
	|
	|-RVA: 0x2E42020 Offset: 0x2E42121 VA: 0x2E42020
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<int, byte>>
	|
	|-RVA: 0x2E42080 Offset: 0x2E42181 VA: 0x2E42080
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<int, char>>
	|
	|-RVA: 0x2E420E0 Offset: 0x2E421E1 VA: 0x2E420E0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<int, DiagnosticEvent>>
	|
	|-RVA: 0x2E42140 Offset: 0x2E42241 VA: 0x2E42140
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<int, int>>
	|
	|-RVA: 0x2E421A0 Offset: 0x2E422A1 VA: 0x2E421A0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<int, Int32Enum>>
	|
	|-RVA: 0x2E42200 Offset: 0x2E42301 VA: 0x2E42200
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<int, long>>
	|
	|-RVA: 0x2E42260 Offset: 0x2E42361 VA: 0x2E42260
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<int, MapPos>>
	|
	|-RVA: 0x2E422C0 Offset: 0x2E423C1 VA: 0x2E422C0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<int, object>>
	|
	|-RVA: 0x2E42320 Offset: 0x2E42421 VA: 0x2E42320
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<int, uint>>
	|
	|-RVA: 0x2E42380 Offset: 0x2E42481 VA: 0x2E42380
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<int, AIThink.EnchantThink.SurroundingInfo>>
	|
	|-RVA: 0x2E423E0 Offset: 0x2E424E1 VA: 0x2E423E0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Int32Enum, bool>>
	|
	|-RVA: 0x2E42440 Offset: 0x2E42541 VA: 0x2E42440
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Int32Enum, int>>
	|
	|-RVA: 0x2E424A0 Offset: 0x2E425A1 VA: 0x2E424A0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Int32Enum, Int32Enum>>
	|
	|-RVA: 0x2E42500 Offset: 0x2E42601 VA: 0x2E42500
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Int32Enum, object>>
	|
	|-RVA: 0x2E42560 Offset: 0x2E42661 VA: 0x2E42560
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<long, object>>
	|
	|-RVA: 0x2E425C0 Offset: 0x2E426C1 VA: 0x2E425C0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<MapPos, int>>
	|
	|-RVA: 0x2E42620 Offset: 0x2E42721 VA: 0x2E42620
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, AsyncOperationHandle<object>>>
	|
	|-RVA: 0x2E42680 Offset: 0x2E42781 VA: 0x2E42680
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, AsyncOperationHandle>>
	|
	|-RVA: 0x2E426E0 Offset: 0x2E427E1 VA: 0x2E426E0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, bool>>
	|
	|-RVA: 0x2E42740 Offset: 0x2E42841 VA: 0x2E42740
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, byte>>
	|
	|-RVA: 0x2E427A0 Offset: 0x2E428A1 VA: 0x2E427A0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, int>>
	|
	|-RVA: 0x2E42800 Offset: 0x2E42901 VA: 0x2E42800
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, Int32Enum>>
	|
	|-RVA: 0x2E42860 Offset: 0x2E42961 VA: 0x2E42860
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, IntPtr>>
	|
	|-RVA: 0x2E428C0 Offset: 0x2E429C1 VA: 0x2E428C0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, object>>
	|
	|-RVA: 0x2E42920 Offset: 0x2E42A21 VA: 0x2E42920
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, Playable>>
	|
	|-RVA: 0x2E42980 Offset: 0x2E42A81 VA: 0x2E42980
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, ResourceLocator>>
	|
	|-RVA: 0x2E429E0 Offset: 0x2E42AE1 VA: 0x2E429E0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, float>>
	|
	|-RVA: 0x2E42A40 Offset: 0x2E42B41 VA: 0x2E42A40
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, ushort>>
	|
	|-RVA: 0x2E42AA0 Offset: 0x2E42BA1 VA: 0x2E42AA0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<object, GameVariable.Value>>
	|
	|-RVA: 0x2E42B00 Offset: 0x2E42C01 VA: 0x2E42B00
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<sbyte, DataStoreRatingInfo>>
	|
	|-RVA: 0x2E42B60 Offset: 0x2E42C61 VA: 0x2E42B60
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<sbyte, object>>
	|
	|-RVA: 0x2E42BC0 Offset: 0x2E42CC1 VA: 0x2E42BC0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<ushort, int>>
	|
	|-RVA: 0x2E42C20 Offset: 0x2E42D21 VA: 0x2E42C20
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<uint, int>>
	|
	|-RVA: 0x2E42C80 Offset: 0x2E42D81 VA: 0x2E42C80
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<uint, object>>
	|
	|-RVA: 0x2E42CE0 Offset: 0x2E42DE1 VA: 0x2E42CE0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<ulong, Friend>>
	|
	|-RVA: 0x2E42D40 Offset: 0x2E42E41 VA: 0x2E42D40
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<ulong, Int32Enum>>
	|
	|-RVA: 0x2E42DA0 Offset: 0x2E42EA1 VA: 0x2E42DA0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<ulong, object>>
	|
	|-RVA: 0x2E42E00 Offset: 0x2E42F01 VA: 0x2E42E00
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<Vector3, int>>
	|
	|-RVA: 0x2E42E60 Offset: 0x2E42F61 VA: 0x2E42E60
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<XPathNodeRef, XPathNodeRef>>
	|
	|-RVA: 0x2E42EC0 Offset: 0x2E42FC1 VA: 0x2E42EC0
	|-Array.InternalArray__ICollection_CopyTo<Dictionary.Entry<TerrainUtility.TerrainMap.TileCoord, object>>
	|
	|-RVA: 0x2E42F20 Offset: 0x2E43021 VA: 0x2E42F20
	|-Array.InternalArray__ICollection_CopyTo<PriorityQueue.IndexedItem<object>>
	|
	|-RVA: 0x2E42F80 Offset: 0x2E43081 VA: 0x2E42F80
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<ValueTuple<object, int>, object>>
	|
	|-RVA: 0x2E42FE0 Offset: 0x2E430E1 VA: 0x2E42FE0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<byte, object>>
	|
	|-RVA: 0x2E43040 Offset: 0x2E43141 VA: 0x2E43040
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<CancellationToken, object>>
	|
	|-RVA: 0x2E430A0 Offset: 0x2E431A1 VA: 0x2E430A0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<char, object>>
	|
	|-RVA: 0x2E43100 Offset: 0x2E43201 VA: 0x2E43100
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<DateTime, object>>
	|
	|-RVA: 0x2E43160 Offset: 0x2E43261 VA: 0x2E43160
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Guid, object>>
	|
	|-RVA: 0x2E431C0 Offset: 0x2E432C1 VA: 0x2E431C0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<int, bool>>
	|
	|-RVA: 0x2E43220 Offset: 0x2E43321 VA: 0x2E43220
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<int, byte>>
	|
	|-RVA: 0x2E43280 Offset: 0x2E43381 VA: 0x2E43280
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<int, char>>
	|
	|-RVA: 0x2E432E0 Offset: 0x2E433E1 VA: 0x2E432E0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<int, DiagnosticEvent>>
	|
	|-RVA: 0x2E43340 Offset: 0x2E43441 VA: 0x2E43340
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<int, int>>
	|
	|-RVA: 0x2E433A0 Offset: 0x2E434A1 VA: 0x2E433A0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<int, Int32Enum>>
	|
	|-RVA: 0x2E43400 Offset: 0x2E43501 VA: 0x2E43400
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<int, long>>
	|
	|-RVA: 0x2E43460 Offset: 0x2E43561 VA: 0x2E43460
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<int, MapPos>>
	|
	|-RVA: 0x2E434C0 Offset: 0x2E435C1 VA: 0x2E434C0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<int, object>>
	|
	|-RVA: 0x2E43520 Offset: 0x2E43621 VA: 0x2E43520
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<int, uint>>
	|
	|-RVA: 0x2E43580 Offset: 0x2E43681 VA: 0x2E43580
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<int, AIThink.EnchantThink.SurroundingInfo>>
	|
	|-RVA: 0x2E435E0 Offset: 0x2E436E1 VA: 0x2E435E0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Int32Enum, bool>>
	|
	|-RVA: 0x2E43640 Offset: 0x2E43741 VA: 0x2E43640
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Int32Enum, int>>
	|
	|-RVA: 0x2E436A0 Offset: 0x2E437A1 VA: 0x2E436A0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Int32Enum, Int32Enum>>
	|
	|-RVA: 0x2E43700 Offset: 0x2E43801 VA: 0x2E43700
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Int32Enum, object>>
	|
	|-RVA: 0x2E43760 Offset: 0x2E43861 VA: 0x2E43760
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<long, object>>
	|
	|-RVA: 0x2E437C0 Offset: 0x2E438C1 VA: 0x2E437C0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<MapPos, int>>
	|
	|-RVA: 0x2E43820 Offset: 0x2E43921 VA: 0x2E43820
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, AsyncOperationHandle<object>>>
	|
	|-RVA: 0x2E43880 Offset: 0x2E43981 VA: 0x2E43880
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, ValueTuple<int, DateTime, object>>>
	|
	|-RVA: 0x2E438E0 Offset: 0x2E439E1 VA: 0x2E438E0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, AsyncOperationHandle>>
	|
	|-RVA: 0x2E43940 Offset: 0x2E43A41 VA: 0x2E43940
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, bool>>
	|
	|-RVA: 0x2E439A0 Offset: 0x2E43AA1 VA: 0x2E439A0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, byte>>
	|
	|-RVA: 0x2E43A00 Offset: 0x2E43B01 VA: 0x2E43A00
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, int>>
	|
	|-RVA: 0x2E43A60 Offset: 0x2E43B61 VA: 0x2E43A60
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, Int32Enum>>
	|
	|-RVA: 0x2E43AC0 Offset: 0x2E43BC1 VA: 0x2E43AC0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, IntPtr>>
	|
	|-RVA: 0x2E43B20 Offset: 0x2E43C21 VA: 0x2E43B20
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, object>>
	|
	|-RVA: 0x2E43B80 Offset: 0x2E43C81 VA: 0x2E43B80
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, Playable>>
	|
	|-RVA: 0x2E43BE0 Offset: 0x2E43CE1 VA: 0x2E43BE0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, ResourceLocator>>
	|
	|-RVA: 0x2E43C40 Offset: 0x2E43D41 VA: 0x2E43C40
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, float>>
	|
	|-RVA: 0x2E43CA0 Offset: 0x2E43DA1 VA: 0x2E43CA0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, ushort>>
	|
	|-RVA: 0x2E43D00 Offset: 0x2E43E01 VA: 0x2E43D00
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<object, GameVariable.Value>>
	|
	|-RVA: 0x2E43D60 Offset: 0x2E43E61 VA: 0x2E43D60
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<sbyte, DataStoreRatingInfo>>
	|
	|-RVA: 0x2E43DC0 Offset: 0x2E43EC1 VA: 0x2E43DC0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<sbyte, object>>
	|
	|-RVA: 0x2E43E20 Offset: 0x2E43F21 VA: 0x2E43E20
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<ushort, int>>
	|
	|-RVA: 0x2E43E80 Offset: 0x2E43F81 VA: 0x2E43E80
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<uint, int>>
	|
	|-RVA: 0x2E43EE0 Offset: 0x2E43FE1 VA: 0x2E43EE0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<uint, object>>
	|
	|-RVA: 0x2E43F40 Offset: 0x2E44041 VA: 0x2E43F40
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<ulong, Friend>>
	|
	|-RVA: 0x2E43FA0 Offset: 0x2E440A1 VA: 0x2E43FA0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<ulong, Int32Enum>>
	|
	|-RVA: 0x2E44000 Offset: 0x2E44101 VA: 0x2E44000
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<ulong, object>>
	|
	|-RVA: 0x2E44060 Offset: 0x2E44161 VA: 0x2E44060
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<Vector3, int>>
	|
	|-RVA: 0x2E440C0 Offset: 0x2E441C1 VA: 0x2E440C0
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<XPathNodeRef, XPathNodeRef>>
	|
	|-RVA: 0x2E44120 Offset: 0x2E44221 VA: 0x2E44120
	|-Array.InternalArray__ICollection_CopyTo<KeyValuePair<TerrainUtility.TerrainMap.TileCoord, object>>
	|
	|-RVA: 0x2E44180 Offset: 0x2E44281 VA: 0x2E44180
	|-Array.InternalArray__ICollection_CopyTo<NativeArray<PreTile>>
	|
	|-RVA: 0x2E441E0 Offset: 0x2E442E1 VA: 0x2E441E0
	|-Array.InternalArray__ICollection_CopyTo<CommonBattleSequence.Reliance<object>>
	|
	|-RVA: 0x2E44240 Offset: 0x2E44341 VA: 0x2E44240
	|-Array.InternalArray__ICollection_CopyTo<RenderGraphResourcePool.ResourceLogInfo<object>>
	|
	|-RVA: 0x2E442A0 Offset: 0x2E443A1 VA: 0x2E442A0
	|-Array.InternalArray__ICollection_CopyTo<HashSet.Slot<ValueTuple<object, int>>>
	|
	|-RVA: 0x2E44300 Offset: 0x2E44401 VA: 0x2E44300
	|-Array.InternalArray__ICollection_CopyTo<HashSet.Slot<AsyncOperationHandle>>
	|
	|-RVA: 0x2E44360 Offset: 0x2E44461 VA: 0x2E44360
	|-Array.InternalArray__ICollection_CopyTo<HashSet.Slot<int>>
	|
	|-RVA: 0x2E443C0 Offset: 0x2E444C1 VA: 0x2E443C0
	|-Array.InternalArray__ICollection_CopyTo<HashSet.Slot<Int32Enum>>
	|
	|-RVA: 0x2E44420 Offset: 0x2E44521 VA: 0x2E44420
	|-Array.InternalArray__ICollection_CopyTo<Set.Slot<Int32Enum>>
	|
	|-RVA: 0x2E44480 Offset: 0x2E44581 VA: 0x2E44480
	|-Array.InternalArray__ICollection_CopyTo<HashSet.Slot<MapPos>>
	|
	|-RVA: 0x2E444E0 Offset: 0x2E445E1 VA: 0x2E444E0
	|-Array.InternalArray__ICollection_CopyTo<HashSet.Slot<object>>
	|
	|-RVA: 0x2E44540 Offset: 0x2E44641 VA: 0x2E44540
	|-Array.InternalArray__ICollection_CopyTo<Set.Slot<object>>
	|
	|-RVA: 0x2E445A0 Offset: 0x2E446A1 VA: 0x2E445A0
	|-Array.InternalArray__ICollection_CopyTo<HashSet.Slot<uint>>
	|
	|-RVA: 0x2E44600 Offset: 0x2E44701 VA: 0x2E44600
	|-Array.InternalArray__ICollection_CopyTo<HashSet.Slot<ulong>>
	|
	|-RVA: 0x2E44660 Offset: 0x2E44761 VA: 0x2E44660
	|-Array.InternalArray__ICollection_CopyTo<Set.Slot<Vector3>>
	|
	|-RVA: 0x2E446C0 Offset: 0x2E447C1 VA: 0x2E446C0
	|-Array.InternalArray__ICollection_CopyTo<TMP_TextProcessingStack<Color32>>
	|
	|-RVA: 0x2E44720 Offset: 0x2E44821 VA: 0x2E44720
	|-Array.InternalArray__ICollection_CopyTo<TMP_TextProcessingStack<HighlightState>>
	|
	|-RVA: 0x2E44780 Offset: 0x2E44881 VA: 0x2E44780
	|-Array.InternalArray__ICollection_CopyTo<TMP_TextProcessingStack<int>>
	|
	|-RVA: 0x2E447E0 Offset: 0x2E448E1 VA: 0x2E447E0
	|-Array.InternalArray__ICollection_CopyTo<TMP_TextProcessingStack<Int32Enum>>
	|
	|-RVA: 0x2E44840 Offset: 0x2E44941 VA: 0x2E44840
	|-Array.InternalArray__ICollection_CopyTo<TMP_TextProcessingStack<MaterialReference>>
	|
	|-RVA: 0x2E448A0 Offset: 0x2E449A1 VA: 0x2E448A0
	|-Array.InternalArray__ICollection_CopyTo<TMP_TextProcessingStack<object>>
	|
	|-RVA: 0x2E44900 Offset: 0x2E44A01 VA: 0x2E44900
	|-Array.InternalArray__ICollection_CopyTo<TMP_TextProcessingStack<float>>
	|
	|-RVA: 0x2E44960 Offset: 0x2E44A61 VA: 0x2E44960
	|-Array.InternalArray__ICollection_CopyTo<TMP_TextProcessingStack<WordWrapState>>
	|
	|-RVA: 0x2E449C0 Offset: 0x2E44AC1 VA: 0x2E449C0
	|-Array.InternalArray__ICollection_CopyTo<TimeInterval<object>>
	|
	|-RVA: 0x2E44A20 Offset: 0x2E44B21 VA: 0x2E44A20
	|-Array.InternalArray__ICollection_CopyTo<Timestamped<object>>
	|
	|-RVA: 0x2E44A80 Offset: 0x2E44B81 VA: 0x2E44A80
	|-Array.InternalArray__ICollection_CopyTo<UniTask<object>>
	|
	|-RVA: 0x2E44AE0 Offset: 0x2E44BE1 VA: 0x2E44AE0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<ValueTuple<bool, object>>>
	|
	|-RVA: 0x2E44B40 Offset: 0x2E44C41 VA: 0x2E44B40
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>
	|
	|-RVA: 0x2E44BA0 Offset: 0x2E44CA1 VA: 0x2E44BA0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, UniTask<object>>>
	|
	|-RVA: 0x2E44C00 Offset: 0x2E44D01 VA: 0x2E44C00
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>
	|
	|-RVA: 0x2E44C60 Offset: 0x2E44D61 VA: 0x2E44C60
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>
	|
	|-RVA: 0x2E44CC0 Offset: 0x2E44DC1 VA: 0x2E44CC0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>
	|
	|-RVA: 0x2E44D20 Offset: 0x2E44E21 VA: 0x2E44D20
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>
	|
	|-RVA: 0x2E44D80 Offset: 0x2E44E81 VA: 0x2E44D80
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>
	|
	|-RVA: 0x2E44DE0 Offset: 0x2E44EE1 VA: 0x2E44DE0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>
	|
	|-RVA: 0x2E44E40 Offset: 0x2E44F41 VA: 0x2E44E40
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>
	|
	|-RVA: 0x2E44EA0 Offset: 0x2E44FA1 VA: 0x2E44EA0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>
	|
	|-RVA: 0x2E44F00 Offset: 0x2E45001 VA: 0x2E44F00
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>
	|
	|-RVA: 0x2E44F60 Offset: 0x2E45061 VA: 0x2E44F60
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>
	|
	|-RVA: 0x2E44FC0 Offset: 0x2E450C1 VA: 0x2E44FC0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>
	|
	|-RVA: 0x2E45020 Offset: 0x2E45121 VA: 0x2E45020
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x2E45080 Offset: 0x2E45181 VA: 0x2E45080
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>
	|
	|-RVA: 0x2E450E0 Offset: 0x2E451E1 VA: 0x2E450E0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>
	|
	|-RVA: 0x2E45140 Offset: 0x2E45241 VA: 0x2E45140
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>
	|
	|-RVA: 0x2E451A0 Offset: 0x2E452A1 VA: 0x2E451A0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>
	|
	|-RVA: 0x2E45200 Offset: 0x2E45301 VA: 0x2E45200
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>
	|
	|-RVA: 0x2E45260 Offset: 0x2E45361 VA: 0x2E45260
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>
	|
	|-RVA: 0x2E452C0 Offset: 0x2E453C1 VA: 0x2E452C0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>
	|
	|-RVA: 0x2E45320 Offset: 0x2E45421 VA: 0x2E45320
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>
	|
	|-RVA: 0x2E45380 Offset: 0x2E45481 VA: 0x2E45380
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>
	|
	|-RVA: 0x2E453E0 Offset: 0x2E454E1 VA: 0x2E453E0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>
	|
	|-RVA: 0x2E45440 Offset: 0x2E45541 VA: 0x2E45440
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>
	|
	|-RVA: 0x2E454A0 Offset: 0x2E455A1 VA: 0x2E454A0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>
	|
	|-RVA: 0x2E45500 Offset: 0x2E45601 VA: 0x2E45500
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>
	|
	|-RVA: 0x2E45560 Offset: 0x2E45661 VA: 0x2E45560
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>
	|
	|-RVA: 0x2E455C0 Offset: 0x2E456C1 VA: 0x2E455C0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>
	|
	|-RVA: 0x2E45620 Offset: 0x2E45721 VA: 0x2E45620
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>
	|
	|-RVA: 0x2E45680 Offset: 0x2E45781 VA: 0x2E45680
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>
	|
	|-RVA: 0x2E456E0 Offset: 0x2E457E1 VA: 0x2E456E0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>
	|
	|-RVA: 0x2E45740 Offset: 0x2E45841 VA: 0x2E45740
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>
	|
	|-RVA: 0x2E457A0 Offset: 0x2E458A1 VA: 0x2E457A0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>
	|
	|-RVA: 0x2E45800 Offset: 0x2E45901 VA: 0x2E45800
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>
	|
	|-RVA: 0x2E45860 Offset: 0x2E45961 VA: 0x2E45860
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>
	|
	|-RVA: 0x2E458C0 Offset: 0x2E459C1 VA: 0x2E458C0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>
	|
	|-RVA: 0x2E45920 Offset: 0x2E45A21 VA: 0x2E45920
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x2E45980 Offset: 0x2E45A81 VA: 0x2E45980
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>
	|
	|-RVA: 0x2E459E0 Offset: 0x2E45AE1 VA: 0x2E459E0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>
	|
	|-RVA: 0x2E45A40 Offset: 0x2E45B41 VA: 0x2E45A40
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>
	|
	|-RVA: 0x2E45AA0 Offset: 0x2E45BA1 VA: 0x2E45AA0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>
	|
	|-RVA: 0x2E45B00 Offset: 0x2E45C01 VA: 0x2E45B00
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>
	|
	|-RVA: 0x2E45B60 Offset: 0x2E45C61 VA: 0x2E45B60
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>
	|
	|-RVA: 0x2E45BC0 Offset: 0x2E45CC1 VA: 0x2E45BC0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>
	|
	|-RVA: 0x2E45C20 Offset: 0x2E45D21 VA: 0x2E45C20
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>
	|
	|-RVA: 0x2E45C80 Offset: 0x2E45D81 VA: 0x2E45C80
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>
	|
	|-RVA: 0x2E45CE0 Offset: 0x2E45DE1 VA: 0x2E45CE0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>
	|
	|-RVA: 0x2E45D40 Offset: 0x2E45E41 VA: 0x2E45D40
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x2E45DA0 Offset: 0x2E45EA1 VA: 0x2E45DA0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>
	|
	|-RVA: 0x2E45E00 Offset: 0x2E45F01 VA: 0x2E45E00
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x2E45E60 Offset: 0x2E45F61 VA: 0x2E45E60
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>
	|
	|-RVA: 0x2E45EC0 Offset: 0x2E45FC1 VA: 0x2E45EC0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x2E45F20 Offset: 0x2E46021 VA: 0x2E45F20
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>
	|
	|-RVA: 0x2E45F80 Offset: 0x2E46081 VA: 0x2E45F80
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x2E45FE0 Offset: 0x2E460E1 VA: 0x2E45FE0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>
	|
	|-RVA: 0x1C6E060 Offset: 0x1C6E161 VA: 0x1C6E060
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x1C6E0C0 Offset: 0x1C6E1C1 VA: 0x1C6E0C0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>
	|
	|-RVA: 0x1C6E120 Offset: 0x1C6E221 VA: 0x1C6E120
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>
	|
	|-RVA: 0x1C6E180 Offset: 0x1C6E281 VA: 0x1C6E180
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>
	|
	|-RVA: 0x1C6E1E0 Offset: 0x1C6E2E1 VA: 0x1C6E1E0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>
	|
	|-RVA: 0x1C6E240 Offset: 0x1C6E341 VA: 0x1C6E240
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>
	|
	|-RVA: 0x1C6E2A0 Offset: 0x1C6E3A1 VA: 0x1C6E2A0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>
	|
	|-RVA: 0x1C6E300 Offset: 0x1C6E401 VA: 0x1C6E300
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>
	|
	|-RVA: 0x1C6E360 Offset: 0x1C6E461 VA: 0x1C6E360
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>
	|
	|-RVA: 0x1C6E3C0 Offset: 0x1C6E4C1 VA: 0x1C6E3C0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>
	|
	|-RVA: 0x1C6E420 Offset: 0x1C6E521 VA: 0x1C6E420
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x1C6E480 Offset: 0x1C6E581 VA: 0x1C6E480
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>
	|
	|-RVA: 0x1C6E4E0 Offset: 0x1C6E5E1 VA: 0x1C6E4E0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>
	|
	|-RVA: 0x1C6E540 Offset: 0x1C6E641 VA: 0x1C6E540
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>
	|
	|-RVA: 0x1C6E5A0 Offset: 0x1C6E6A1 VA: 0x1C6E5A0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>
	|
	|-RVA: 0x1C6E600 Offset: 0x1C6E701 VA: 0x1C6E600
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>
	|
	|-RVA: 0x1C6E660 Offset: 0x1C6E761 VA: 0x1C6E660
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>
	|
	|-RVA: 0x1C6E6C0 Offset: 0x1C6E7C1 VA: 0x1C6E6C0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>
	|
	|-RVA: 0x1C6E720 Offset: 0x1C6E821 VA: 0x1C6E720
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>
	|
	|-RVA: 0x1C6E780 Offset: 0x1C6E881 VA: 0x1C6E780
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>
	|
	|-RVA: 0x1C6E7E0 Offset: 0x1C6E8E1 VA: 0x1C6E7E0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>
	|
	|-RVA: 0x1C6E840 Offset: 0x1C6E941 VA: 0x1C6E840
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x1C6E8A0 Offset: 0x1C6E9A1 VA: 0x1C6E8A0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>
	|
	|-RVA: 0x1C6E900 Offset: 0x1C6EA01 VA: 0x1C6E900
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x1C6E960 Offset: 0x1C6EA61 VA: 0x1C6E960
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>
	|
	|-RVA: 0x1C6E9C0 Offset: 0x1C6EAC1 VA: 0x1C6E9C0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x1C6EA20 Offset: 0x1C6EB21 VA: 0x1C6EA20
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>
	|
	|-RVA: 0x1C6EA80 Offset: 0x1C6EB81 VA: 0x1C6EA80
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x1C6EAE0 Offset: 0x1C6EBE1 VA: 0x1C6EAE0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>
	|
	|-RVA: 0x1C6EB40 Offset: 0x1C6EC41 VA: 0x1C6EB40
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x1C6EBA0 Offset: 0x1C6ECA1 VA: 0x1C6EBA0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>
	|
	|-RVA: 0x1C6EC00 Offset: 0x1C6ED01 VA: 0x1C6EC00
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x1C6EC60 Offset: 0x1C6ED61 VA: 0x1C6EC60
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x1C6ECC0 Offset: 0x1C6EDC1 VA: 0x1C6ECC0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>
	|
	|-RVA: 0x1C6ED20 Offset: 0x1C6EE21 VA: 0x1C6ED20
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, bool>>>
	|
	|-RVA: 0x1C6ED80 Offset: 0x1C6EE81 VA: 0x1C6ED80
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, Bounds>>>
	|
	|-RVA: 0x1C6EDE0 Offset: 0x1C6EEE1 VA: 0x1C6EDE0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, byte>>>
	|
	|-RVA: 0x1C6EE40 Offset: 0x1C6EF41 VA: 0x1C6EE40
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, Color>>>
	|
	|-RVA: 0x1C6EEA0 Offset: 0x1C6EFA1 VA: 0x1C6EEA0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, double>>>
	|
	|-RVA: 0x1C6EF00 Offset: 0x1C6F001 VA: 0x1C6EF00
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, int>>>
	|
	|-RVA: 0x1C6EF60 Offset: 0x1C6F061 VA: 0x1C6EF60
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, long>>>
	|
	|-RVA: 0x1C6EFC0 Offset: 0x1C6F0C1 VA: 0x1C6EFC0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, object>>>
	|
	|-RVA: 0x1C6F020 Offset: 0x1C6F121 VA: 0x1C6F020
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, Quaternion>>>
	|
	|-RVA: 0x1C6F080 Offset: 0x1C6F181 VA: 0x1C6F080
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, Rect>>>
	|
	|-RVA: 0x1C6F0E0 Offset: 0x1C6F1E1 VA: 0x1C6F0E0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, float>>>
	|
	|-RVA: 0x1C6F140 Offset: 0x1C6F241 VA: 0x1C6F140
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, UniTask>>>
	|
	|-RVA: 0x1C6F1A0 Offset: 0x1C6F2A1 VA: 0x1C6F1A0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, Unit>>>
	|
	|-RVA: 0x1C6F200 Offset: 0x1C6F301 VA: 0x1C6F200
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, Vector2>>>
	|
	|-RVA: 0x1C6F260 Offset: 0x1C6F361 VA: 0x1C6F260
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, Vector3>>>
	|
	|-RVA: 0x1C6F2C0 Offset: 0x1C6F3C1 VA: 0x1C6F2C0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<bool, Vector4>>>
	|
	|-RVA: 0x1C6F320 Offset: 0x1C6F421 VA: 0x1C6F320
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<int, object>>>
	|
	|-RVA: 0x1C6F380 Offset: 0x1C6F481 VA: 0x1C6F380
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<object, object>>>
	|
	|-RVA: 0x1C6F3E0 Offset: 0x1C6F4E1 VA: 0x1C6F3E0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x1C6F440 Offset: 0x1C6F541 VA: 0x1C6F440
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<object, object, object>>>
	|
	|-RVA: 0x1C6F4A0 Offset: 0x1C6F5A1 VA: 0x1C6F4A0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x1C6F500 Offset: 0x1C6F601 VA: 0x1C6F500
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<object, object, object, object>>>
	|
	|-RVA: 0x1C6F560 Offset: 0x1C6F661 VA: 0x1C6F560
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x1C6F5C0 Offset: 0x1C6F6C1 VA: 0x1C6F5C0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>
	|
	|-RVA: 0x1C6F620 Offset: 0x1C6F721 VA: 0x1C6F620
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x1C6F680 Offset: 0x1C6F781 VA: 0x1C6F680
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>
	|
	|-RVA: 0x1C6F6E0 Offset: 0x1C6F7E1 VA: 0x1C6F6E0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x1C6F740 Offset: 0x1C6F841 VA: 0x1C6F740
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>
	|
	|-RVA: 0x1C6F7A0 Offset: 0x1C6F8A1 VA: 0x1C6F7A0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x1C6F800 Offset: 0x1C6F901 VA: 0x1C6F800
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x1C6F860 Offset: 0x1C6F961 VA: 0x1C6F860
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, AsyncUnit>>
	|
	|-RVA: 0x1C6F8C0 Offset: 0x1C6F9C1 VA: 0x1C6F8C0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, bool>>
	|
	|-RVA: 0x1C6F920 Offset: 0x1C6FA21 VA: 0x1C6F920
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, Bounds>>
	|
	|-RVA: 0x1C6F980 Offset: 0x1C6FA81 VA: 0x1C6F980
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, byte>>
	|
	|-RVA: 0x1C6F9E0 Offset: 0x1C6FAE1 VA: 0x1C6F9E0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, Color>>
	|
	|-RVA: 0x1C6FA40 Offset: 0x1C6FB41 VA: 0x1C6FA40
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, double>>
	|
	|-RVA: 0x1C6FAA0 Offset: 0x1C6FBA1 VA: 0x1C6FAA0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, int>>
	|
	|-RVA: 0x1C6FB00 Offset: 0x1C6FC01 VA: 0x1C6FB00
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, long>>
	|
	|-RVA: 0x1C6FB60 Offset: 0x1C6FC61 VA: 0x1C6FB60
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, object>>
	|
	|-RVA: 0x1C6FBC0 Offset: 0x1C6FCC1 VA: 0x1C6FBC0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, Quaternion>>
	|
	|-RVA: 0x1C6FC20 Offset: 0x1C6FD21 VA: 0x1C6FC20
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, Rect>>
	|
	|-RVA: 0x1C6FC80 Offset: 0x1C6FD81 VA: 0x1C6FC80
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, float>>
	|
	|-RVA: 0x1C6FCE0 Offset: 0x1C6FDE1 VA: 0x1C6FCE0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, UniTask>>
	|
	|-RVA: 0x1C6FD40 Offset: 0x1C6FE41 VA: 0x1C6FD40
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, Unit>>
	|
	|-RVA: 0x1C6FDA0 Offset: 0x1C6FEA1 VA: 0x1C6FDA0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, Vector2>>
	|
	|-RVA: 0x1C6FE00 Offset: 0x1C6FF01 VA: 0x1C6FE00
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, Vector3>>
	|
	|-RVA: 0x1C6FE60 Offset: 0x1C6FF61 VA: 0x1C6FE60
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<bool, Vector4>>
	|
	|-RVA: 0x1C6FEC0 Offset: 0x1C6FFC1 VA: 0x1C6FEC0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<int, bool>>
	|
	|-RVA: 0x1C6FF20 Offset: 0x1C70021 VA: 0x1C6FF20
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<int, Bounds>>
	|
	|-RVA: 0x1C6FF80 Offset: 0x1C70081 VA: 0x1C6FF80
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<int, byte>>
	|
	|-RVA: 0x1C6FFE0 Offset: 0x1C700E1 VA: 0x1C6FFE0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<int, Color>>
	|
	|-RVA: 0x1C70040 Offset: 0x1C70141 VA: 0x1C70040
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<int, double>>
	|
	|-RVA: 0x1C700A0 Offset: 0x1C701A1 VA: 0x1C700A0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<int, int>>
	|
	|-RVA: 0x1C70100 Offset: 0x1C70201 VA: 0x1C70100
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<int, long>>
	|
	|-RVA: 0x1C70160 Offset: 0x1C70261 VA: 0x1C70160
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<int, object>>
	|
	|-RVA: 0x1C701C0 Offset: 0x1C702C1 VA: 0x1C701C0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<int, Quaternion>>
	|
	|-RVA: 0x1C70220 Offset: 0x1C70321 VA: 0x1C70220
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<int, Rect>>
	|
	|-RVA: 0x1C70280 Offset: 0x1C70381 VA: 0x1C70280
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<int, float>>
	|
	|-RVA: 0x1C702E0 Offset: 0x1C703E1 VA: 0x1C702E0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<int, Unit>>
	|
	|-RVA: 0x1C70340 Offset: 0x1C70441 VA: 0x1C70340
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<int, Vector2>>
	|
	|-RVA: 0x1C703A0 Offset: 0x1C704A1 VA: 0x1C703A0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<int, Vector3>>
	|
	|-RVA: 0x1C70400 Offset: 0x1C70501 VA: 0x1C70400
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<int, Vector4>>
	|
	|-RVA: 0x1C70460 Offset: 0x1C70561 VA: 0x1C70460
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<Int32Enum, int>>
	|
	|-RVA: 0x1C704C0 Offset: 0x1C705C1 VA: 0x1C704C0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<object, ValueTuple<object, int>>>
	|
	|-RVA: 0x1C70520 Offset: 0x1C70621 VA: 0x1C70520
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<object, int>>
	|
	|-RVA: 0x1C70580 Offset: 0x1C70681 VA: 0x1C70580
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<object, object>>
	|
	|-RVA: 0x1C705E0 Offset: 0x1C706E1 VA: 0x1C705E0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<object, float>>
	|
	|-RVA: 0x1C70640 Offset: 0x1C70741 VA: 0x1C70640
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<Vector3, float>>
	|
	|-RVA: 0x1C706A0 Offset: 0x1C707A1 VA: 0x1C706A0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>
	|
	|-RVA: 0x1C70700 Offset: 0x1C70801 VA: 0x1C70700
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<object, Int32Enum, int>>
	|
	|-RVA: 0x1C70760 Offset: 0x1C70861 VA: 0x1C70760
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<object, object, object>>
	|
	|-RVA: 0x1C707C0 Offset: 0x1C708C1 VA: 0x1C707C0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>
	|
	|-RVA: 0x1C70820 Offset: 0x1C70921 VA: 0x1C70820
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<object, int, int, int>>
	|
	|-RVA: 0x1C70880 Offset: 0x1C70981 VA: 0x1C70880
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<object, object, object, object>>
	|
	|-RVA: 0x1C708E0 Offset: 0x1C709E1 VA: 0x1C708E0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>
	|
	|-RVA: 0x1C70940 Offset: 0x1C70A41 VA: 0x1C70940
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<object, object, object, object, object>>
	|
	|-RVA: 0x1C709A0 Offset: 0x1C70AA1 VA: 0x1C709A0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>
	|
	|-RVA: 0x1C70A00 Offset: 0x1C70B01 VA: 0x1C70A00
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<object, object, object, object, object, object>>
	|
	|-RVA: 0x1C70A60 Offset: 0x1C70B61 VA: 0x1C70A60
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>
	|
	|-RVA: 0x1C70AC0 Offset: 0x1C70BC1 VA: 0x1C70AC0
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<object, object, object, object, object, object, object>>
	|
	|-RVA: 0x1C70B20 Offset: 0x1C70C21 VA: 0x1C70B20
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>
	|
	|-RVA: 0x1C70B80 Offset: 0x1C70C81 VA: 0x1C70B80
	|-Array.InternalArray__ICollection_CopyTo<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x1C70BE0 Offset: 0x1C70CE1 VA: 0x1C70BE0
	|-Array.InternalArray__ICollection_CopyTo<AnimatorClipInfo>
	|
	|-RVA: 0x1C70C40 Offset: 0x1C70D41 VA: 0x1C70C40
	|-Array.InternalArray__ICollection_CopyTo<AsyncOperationHandle>
	|
	|-RVA: 0x1C70CA0 Offset: 0x1C70DA1 VA: 0x1C70CA0
	|-Array.InternalArray__ICollection_CopyTo<AsyncUnit>
	|
	|-RVA: 0x1C70D00 Offset: 0x1C70E01 VA: 0x1C70D00
	|-Array.InternalArray__ICollection_CopyTo<BatchVisibility>
	|
	|-RVA: 0x1C70D60 Offset: 0x1C70E61 VA: 0x1C70D60
	|-Array.InternalArray__ICollection_CopyTo<BoneWeight>
	|
	|-RVA: 0x1C70DC0 Offset: 0x1C70EC1 VA: 0x1C70DC0
	|-Array.InternalArray__ICollection_CopyTo<BoneWeight1>
	|
	|-RVA: 0x1C70E20 Offset: 0x1C70F21 VA: 0x1C70E20
	|-Array.InternalArray__ICollection_CopyTo<bool>
	|
	|-RVA: 0x1C70E80 Offset: 0x1C70F81 VA: 0x1C70E80
	|-Array.InternalArray__ICollection_CopyTo<Bounds>
	|
	|-RVA: 0x1C70EE0 Offset: 0x1C70FE1 VA: 0x1C70EE0
	|-Array.InternalArray__ICollection_CopyTo<byte>
	|
	|-RVA: 0x1C70F40 Offset: 0x1C71041 VA: 0x1C70F40
	|-Array.InternalArray__ICollection_CopyTo<ByteEnum>
	|
	|-RVA: 0x1C70FA0 Offset: 0x1C710A1 VA: 0x1C70FA0
	|-Array.InternalArray__ICollection_CopyTo<CameraInfo>
	|
	|-RVA: 0x1C71000 Offset: 0x1C71101 VA: 0x1C71000
	|-Array.InternalArray__ICollection_CopyTo<CancellationToken>
	|
	|-RVA: 0x1C71060 Offset: 0x1C71161 VA: 0x1C71060
	|-Array.InternalArray__ICollection_CopyTo<CancellationTokenRegistration>
	|
	|-RVA: 0x1C710C0 Offset: 0x1C711C1 VA: 0x1C710C0
	|-Array.InternalArray__ICollection_CopyTo<char>
	|
	|-RVA: 0x1C71120 Offset: 0x1C71221 VA: 0x1C71120
	|-Array.InternalArray__ICollection_CopyTo<ClusteringData>
	|
	|-RVA: 0x1C71180 Offset: 0x1C71281 VA: 0x1C71180
	|-Array.InternalArray__ICollection_CopyTo<ClusteringProcessorState>
	|
	|-RVA: 0x1C711E0 Offset: 0x1C712E1 VA: 0x1C711E0
	|-Array.InternalArray__ICollection_CopyTo<Color>
	|
	|-RVA: 0x1C71240 Offset: 0x1C71341 VA: 0x1C71240
	|-Array.InternalArray__ICollection_CopyTo<Color32>
	|
	|-RVA: 0x1C712A0 Offset: 0x1C713A1 VA: 0x1C712A0
	|-Array.InternalArray__ICollection_CopyTo<Color4u8>
	|
	|-RVA: 0x1C71300 Offset: 0x1C71401 VA: 0x1C71300
	|-Array.InternalArray__ICollection_CopyTo<ColorBlock>
	|
	|-RVA: 0x1C71360 Offset: 0x1C71461 VA: 0x1C71360
	|-Array.InternalArray__ICollection_CopyTo<CombineInstance>
	|
	|-RVA: 0x1C713C0 Offset: 0x1C714C1 VA: 0x1C713C0
	|-Array.InternalArray__ICollection_CopyTo<ConstraintSource>
	|
	|-RVA: 0x1C71420 Offset: 0x1C71521 VA: 0x1C71420
	|-Array.InternalArray__ICollection_CopyTo<ContactPoint>
	|
	|-RVA: 0x1C71480 Offset: 0x1C71581 VA: 0x1C71480
	|-Array.InternalArray__ICollection_CopyTo<ContactPoint2D>
	|
	|-RVA: 0x1C714E0 Offset: 0x1C715E1 VA: 0x1C714E0
	|-Array.InternalArray__ICollection_CopyTo<ContourVertex>
	|
	|-RVA: 0x1C71540 Offset: 0x1C71641 VA: 0x1C71540
	|-Array.InternalArray__ICollection_CopyTo<CustomAttributeNamedArgument>
	|
	|-RVA: 0x1C715A0 Offset: 0x1C716A1 VA: 0x1C715A0
	|-Array.InternalArray__ICollection_CopyTo<CustomAttributeTypedArgument>
	|
	|-RVA: 0x1C71600 Offset: 0x1C71701 VA: 0x1C71600
	|-Array.InternalArray__ICollection_CopyTo<DataStoreRatingInfo>
	|
	|-RVA: 0x1C71660 Offset: 0x1C71761 VA: 0x1C71660
	|-Array.InternalArray__ICollection_CopyTo<DataStoreResult>
	|
	|-RVA: 0x1C716C0 Offset: 0x1C717C1 VA: 0x1C716C0
	|-Array.InternalArray__ICollection_CopyTo<DateTime>
	|
	|-RVA: 0x1C71720 Offset: 0x1C71821 VA: 0x1C71720
	|-Array.InternalArray__ICollection_CopyTo<DateTimeOffset>
	|
	|-RVA: 0x1C71780 Offset: 0x1C71881 VA: 0x1C71780
	|-Array.InternalArray__ICollection_CopyTo<DebugPadState>
	|
	|-RVA: 0x1C717E0 Offset: 0x1C718E1 VA: 0x1C717E0
	|-Array.InternalArray__ICollection_CopyTo<Decimal>
	|
	|-RVA: 0x1C71840 Offset: 0x1C71941 VA: 0x1C71840
	|-Array.InternalArray__ICollection_CopyTo<DeferredTiler>
	|
	|-RVA: 0x1C718A0 Offset: 0x1C719A1 VA: 0x1C718A0
	|-Array.InternalArray__ICollection_CopyTo<DeviceHandle>
	|
	|-RVA: 0x1C71900 Offset: 0x1C71A01 VA: 0x1C71900
	|-Array.InternalArray__ICollection_CopyTo<DiagnosticEvent>
	|
	|-RVA: 0x1C71960 Offset: 0x1C71A61 VA: 0x1C71960
	|-Array.InternalArray__ICollection_CopyTo<DictionaryEntry>
	|
	|-RVA: 0x1C719C0 Offset: 0x1C71AC1 VA: 0x1C719C0
	|-Array.InternalArray__ICollection_CopyTo<DictionaryInfo>
	|
	|-RVA: 0x1C71A20 Offset: 0x1C71B21 VA: 0x1C71A20
	|-Array.InternalArray__ICollection_CopyTo<DirectoryEntry>
	|
	|-RVA: 0x1C71A80 Offset: 0x1C71B81 VA: 0x1C71A80
	|-Array.InternalArray__ICollection_CopyTo<double>
	|
	|-RVA: 0x1C71AE0 Offset: 0x1C71BE1 VA: 0x1C71AE0
	|-Array.InternalArray__ICollection_CopyTo<Ephemeron>
	|
	|-RVA: 0x1C71B40 Offset: 0x1C71C41 VA: 0x1C71B40
	|-Array.InternalArray__ICollection_CopyTo<FXZ>
	|
	|-RVA: 0x1C71BA0 Offset: 0x1C71CA1 VA: 0x1C71BA0
	|-Array.InternalArray__ICollection_CopyTo<Finger>
	|
	|-RVA: 0x1C71C00 Offset: 0x1C71D01 VA: 0x1C71C00
	|-Array.InternalArray__ICollection_CopyTo<Float2>
	|
	|-RVA: 0x1C71C60 Offset: 0x1C71D61 VA: 0x1C71C60
	|-Array.InternalArray__ICollection_CopyTo<Friend>
	|
	|-RVA: 0x1C71CC0 Offset: 0x1C71DC1 VA: 0x1C71CC0
	|-Array.InternalArray__ICollection_CopyTo<GCHandle>
	|
	|-RVA: 0x1C71D20 Offset: 0x1C71E21 VA: 0x1C71D20
	|-Array.InternalArray__ICollection_CopyTo<GesturePoint>
	|
	|-RVA: 0x1C71D80 Offset: 0x1C71E81 VA: 0x1C71D80
	|-Array.InternalArray__ICollection_CopyTo<GestureState>
	|
	|-RVA: 0x1C71DE0 Offset: 0x1C71EE1 VA: 0x1C71DE0
	|-Array.InternalArray__ICollection_CopyTo<GlyphMarshallingStruct>
	|
	|-RVA: 0x1C71E40 Offset: 0x1C71F41 VA: 0x1C71E40
	|-Array.InternalArray__ICollection_CopyTo<GlyphPairAdjustmentRecord>
	|
	|-RVA: 0x1C71EA0 Offset: 0x1C71FA1 VA: 0x1C71EA0
	|-Array.InternalArray__ICollection_CopyTo<GlyphRect>
	|
	|-RVA: 0x1C71F00 Offset: 0x1C72001 VA: 0x1C71F00
	|-Array.InternalArray__ICollection_CopyTo<Guid>
	|
	|-RVA: 0x1C71F60 Offset: 0x1C72061 VA: 0x1C71F60
	|-Array.InternalArray__ICollection_CopyTo<Hand>
	|
	|-RVA: 0x1C71FC0 Offset: 0x1C720C1 VA: 0x1C71FC0
	|-Array.InternalArray__ICollection_CopyTo<HandAnalysisImageState>
	|
	|-RVA: 0x1C72020 Offset: 0x1C72121 VA: 0x1C72020
	|-Array.InternalArray__ICollection_CopyTo<HandAnalysisSilhouetteState>
	|
	|-RVA: 0x1C72080 Offset: 0x1C72181 VA: 0x1C72080
	|-Array.InternalArray__ICollection_CopyTo<HeaderVariantInfo>
	|
	|-RVA: 0x1C720E0 Offset: 0x1C721E1 VA: 0x1C720E0
	|-Array.InternalArray__ICollection_CopyTo<HighlightState>
	|
	|-RVA: 0x1C72140 Offset: 0x1C72241 VA: 0x1C72140
	|-Array.InternalArray__ICollection_CopyTo<HumanBone>
	|
	|-RVA: 0x1C721A0 Offset: 0x1C722A1 VA: 0x1C721A0
	|-Array.InternalArray__ICollection_CopyTo<short>
	|
	|-RVA: 0x1C72200 Offset: 0x1C72301 VA: 0x1C72200
	|-Array.InternalArray__ICollection_CopyTo<int>
	|
	|-RVA: 0x1C72260 Offset: 0x1C72361 VA: 0x1C72260
	|-Array.InternalArray__ICollection_CopyTo<Int32Enum>
	|
	|-RVA: 0x1C722C0 Offset: 0x1C723C1 VA: 0x1C722C0
	|-Array.InternalArray__ICollection_CopyTo<long>
	|
	|-RVA: 0x1C72320 Offset: 0x1C72421 VA: 0x1C72320
	|-Array.InternalArray__ICollection_CopyTo<Int64Enum>
	|
	|-RVA: 0x1C72380 Offset: 0x1C72481 VA: 0x1C72380
	|-Array.InternalArray__ICollection_CopyTo<IntPtr>
	|
	|-RVA: 0x1C723E0 Offset: 0x1C724E1 VA: 0x1C723E0
	|-Array.InternalArray__ICollection_CopyTo<InternalCodePageDataItem>
	|
	|-RVA: 0x1C72440 Offset: 0x1C72541 VA: 0x1C72440
	|-Array.InternalArray__ICollection_CopyTo<InternalEncodingDataItem>
	|
	|-RVA: 0x1C724A0 Offset: 0x1C725A1 VA: 0x1C724A0
	|-Array.InternalArray__ICollection_CopyTo<InterpretedFrameInfo>
	|
	|-RVA: 0x1C72500 Offset: 0x1C72601 VA: 0x1C72500
	|-Array.InternalArray__ICollection_CopyTo<IntervalTreeNode>
	|
	|-RVA: 0x1C72560 Offset: 0x1C72661 VA: 0x1C72560
	|-Array.InternalArray__ICollection_CopyTo<JobHandle>
	|
	|-RVA: 0x1C725C0 Offset: 0x1C726C1 VA: 0x1C725C0
	|-Array.InternalArray__ICollection_CopyTo<Keyframe>
	|
	|-RVA: 0x1C72620 Offset: 0x1C72721 VA: 0x1C72620
	|-Array.InternalArray__ICollection_CopyTo<LOD>
	|
	|-RVA: 0x1C72680 Offset: 0x1C72781 VA: 0x1C72680
	|-Array.InternalArray__ICollection_CopyTo<LayerMask>
	|
	|-RVA: 0x1C726E0 Offset: 0x1C727E1 VA: 0x1C726E0
	|-Array.InternalArray__ICollection_CopyTo<LengthLimitProperties>
	|
	|-RVA: 0x1C72740 Offset: 0x1C72841 VA: 0x1C72740
	|-Array.InternalArray__ICollection_CopyTo<Light2DBlendStyle>
	|
	|-RVA: 0x1C727A0 Offset: 0x1C728A1 VA: 0x1C727A0
	|-Array.InternalArray__ICollection_CopyTo<LightDataGI>
	|
	|-RVA: 0x1C72800 Offset: 0x1C72901 VA: 0x1C72800
	|-Array.InternalArray__ICollection_CopyTo<LocalDefinition>
	|
	|-RVA: 0x1C72860 Offset: 0x1C72961 VA: 0x1C72860
	|-Array.InternalArray__ICollection_CopyTo<MapPos>
	|
	|-RVA: 0x1C728C0 Offset: 0x1C729C1 VA: 0x1C728C0
	|-Array.InternalArray__ICollection_CopyTo<MapRange>
	|
	|-RVA: 0x1C72920 Offset: 0x1C72A21 VA: 0x1C72920
	|-Array.InternalArray__ICollection_CopyTo<MaterialReference>
	|
	|-RVA: 0x1C72980 Offset: 0x1C72A81 VA: 0x1C72980
	|-Array.InternalArray__ICollection_CopyTo<Matrix4x4>
	|
	|-RVA: 0x1C729E0 Offset: 0x1C72AE1 VA: 0x1C729E0
	|-Array.InternalArray__ICollection_CopyTo<MomentProcessorState>
	|
	|-RVA: 0x1C72A40 Offset: 0x1C72B41 VA: 0x1C72A40
	|-Array.InternalArray__ICollection_CopyTo<MomentStatistic>
	|
	|-RVA: 0x1C72AA0 Offset: 0x1C72BA1 VA: 0x1C72AA0
	|-Array.InternalArray__ICollection_CopyTo<Navigation>
	|
	|-RVA: 0x1C72B00 Offset: 0x1C72C01 VA: 0x1C72B00
	|-Array.InternalArray__ICollection_CopyTo<NetworkServiceAccountId>
	|
	|-RVA: 0x1C72B60 Offset: 0x1C72C61 VA: 0x1C72B60
	|-Array.InternalArray__ICollection_CopyTo<NpadFullKeyState>
	|
	|-RVA: 0x1C72BC0 Offset: 0x1C72CC1 VA: 0x1C72BC0
	|-Array.InternalArray__ICollection_CopyTo<NpadHandheldState>
	|
	|-RVA: 0x1C72C20 Offset: 0x1C72D21 VA: 0x1C72C20
	|-Array.InternalArray__ICollection_CopyTo<NpadJoyDualState>
	|
	|-RVA: 0x1C72C80 Offset: 0x1C72D81 VA: 0x1C72C80
	|-Array.InternalArray__ICollection_CopyTo<NpadJoyLeftState>
	|
	|-RVA: 0x1C72CE0 Offset: 0x1C72DE1 VA: 0x1C72CE0
	|-Array.InternalArray__ICollection_CopyTo<NpadJoyRightState>
	|
	|-RVA: 0x1C72D40 Offset: 0x1C72E41 VA: 0x1C72D40
	|-Array.InternalArray__ICollection_CopyTo<NpadStateArrayItem>
	|
	|-RVA: 0x1C72DA0 Offset: 0x1C72EA1 VA: 0x1C72DA0
	|-Array.InternalArray__ICollection_CopyTo<NsUid>
	|
	|-RVA: 0x1C72E00 Offset: 0x1C72F01 VA: 0x1C72E00
	|-Array.InternalArray__ICollection_CopyTo<object>
	|
	|-RVA: 0x1C72E60 Offset: 0x1C72F61 VA: 0x1C72E60
	|-Array.InternalArray__ICollection_CopyTo<ObjectInitializationData>
	|
	|-RVA: 0x1C72EC0 Offset: 0x1C72FC1 VA: 0x1C72EC0
	|-Array.InternalArray__ICollection_CopyTo<ParameterModifier>
	|
	|-RVA: 0x1C72F20 Offset: 0x1C73021 VA: 0x1C72F20
	|-Array.InternalArray__ICollection_CopyTo<Plane>
	|
	|-RVA: 0x1C72F80 Offset: 0x1C73081 VA: 0x1C72F80
	|-Array.InternalArray__ICollection_CopyTo<Playable>
	|
	|-RVA: 0x1C72FE0 Offset: 0x1C730E1 VA: 0x1C72FE0
	|-Array.InternalArray__ICollection_CopyTo<PlayableBinding>
	|
	|-RVA: 0x1C73040 Offset: 0x1C73141 VA: 0x1C73040
	|-Array.InternalArray__ICollection_CopyTo<PlayerLoopSystem>
	|
	|-RVA: 0x1C730A0 Offset: 0x1C731A1 VA: 0x1C730A0
	|-Array.InternalArray__ICollection_CopyTo<PlayerLoopSystemInternal>
	|
	|-RVA: 0x1C73100 Offset: 0x1C73201 VA: 0x1C73100
	|-Array.InternalArray__ICollection_CopyTo<PreTile>
	|
	|-RVA: 0x1C73160 Offset: 0x1C73261 VA: 0x1C73160
	|-Array.InternalArray__ICollection_CopyTo<Profile>
	|
	|-RVA: 0x1C731C0 Offset: 0x1C732C1 VA: 0x1C731C0
	|-Array.InternalArray__ICollection_CopyTo<Protrusion>
	|
	|-RVA: 0x1C73220 Offset: 0x1C73321 VA: 0x1C73220
	|-Array.InternalArray__ICollection_CopyTo<Quaternion>
	|
	|-RVA: 0x1C73280 Offset: 0x1C73381 VA: 0x1C73280
	|-Array.InternalArray__ICollection_CopyTo<RandomSeed>
	|
	|-RVA: 0x1C732E0 Offset: 0x1C733E1 VA: 0x1C732E0
	|-Array.InternalArray__ICollection_CopyTo<RangePositionInfo>
	|
	|-RVA: 0x1C73340 Offset: 0x1C73441 VA: 0x1C73340
	|-Array.InternalArray__ICollection_CopyTo<Ranking2ChartInfoInput>
	|
	|-RVA: 0x1C733A0 Offset: 0x1C734A1 VA: 0x1C733A0
	|-Array.InternalArray__ICollection_CopyTo<RaycastHit>
	|
	|-RVA: 0x1C73400 Offset: 0x1C73501 VA: 0x1C73400
	|-Array.InternalArray__ICollection_CopyTo<RaycastHit2D>
	|
	|-RVA: 0x1C73460 Offset: 0x1C73561 VA: 0x1C73460
	|-Array.InternalArray__ICollection_CopyTo<RaycastResult>
	|
	|-RVA: 0x1C734C0 Offset: 0x1C735C1 VA: 0x1C734C0
	|-Array.InternalArray__ICollection_CopyTo<Rect>
	|
	|-RVA: 0x1C73520 Offset: 0x1C73621 VA: 0x1C73520
	|-Array.InternalArray__ICollection_CopyTo<RenderBuffer>
	|
	|-RVA: 0x1C73580 Offset: 0x1C73681 VA: 0x1C73580
	|-Array.InternalArray__ICollection_CopyTo<RenderStateBlock>
	|
	|-RVA: 0x1C735E0 Offset: 0x1C736E1 VA: 0x1C735E0
	|-Array.InternalArray__ICollection_CopyTo<RenderTargetHandle>
	|
	|-RVA: 0x1C73640 Offset: 0x1C73741 VA: 0x1C73640
	|-Array.InternalArray__ICollection_CopyTo<RenderTargetIdentifier>
	|
	|-RVA: 0x1C736A0 Offset: 0x1C737A1 VA: 0x1C736A0
	|-Array.InternalArray__ICollection_CopyTo<RendererListHandle>
	|
	|-RVA: 0x1C73700 Offset: 0x1C73801 VA: 0x1C73700
	|-Array.InternalArray__ICollection_CopyTo<ResourceHandle>
	|
	|-RVA: 0x1C73760 Offset: 0x1C73861 VA: 0x1C73760
	|-Array.InternalArray__ICollection_CopyTo<ResourceLocator>
	|
	|-RVA: 0x1C737C0 Offset: 0x1C738C1 VA: 0x1C737C0
	|-Array.InternalArray__ICollection_CopyTo<RichTextTagAttribute>
	|
	|-RVA: 0x1C73820 Offset: 0x1C73921 VA: 0x1C73820
	|-Array.InternalArray__ICollection_CopyTo<RuntimeLabel>
	|
	|-RVA: 0x1C73880 Offset: 0x1C73981 VA: 0x1C73880
	|-Array.InternalArray__ICollection_CopyTo<sbyte>
	|
	|-RVA: 0x1C738E0 Offset: 0x1C739E1 VA: 0x1C738E0
	|-Array.InternalArray__ICollection_CopyTo<SerializedType>
	|
	|-RVA: 0x1C73940 Offset: 0x1C73A41 VA: 0x1C73940
	|-Array.InternalArray__ICollection_CopyTo<ShaderKeyword>
	|
	|-RVA: 0x1C739A0 Offset: 0x1C73AA1 VA: 0x1C739A0
	|-Array.InternalArray__ICollection_CopyTo<ShaderTagId>
	|
	|-RVA: 0x1C73A00 Offset: 0x1C73B01 VA: 0x1C73A00
	|-Array.InternalArray__ICollection_CopyTo<ShadowSliceData>
	|
	|-RVA: 0x1C73A60 Offset: 0x1C73B61 VA: 0x1C73A60
	|-Array.InternalArray__ICollection_CopyTo<Shape>
	|
	|-RVA: 0x1C73AC0 Offset: 0x1C73BC1 VA: 0x1C73AC0
	|-Array.InternalArray__ICollection_CopyTo<float>
	|
	|-RVA: 0x1C73B20 Offset: 0x1C73C21 VA: 0x1C73B20
	|-Array.InternalArray__ICollection_CopyTo<SixAxisSensorHandle>
	|
	|-RVA: 0x1C73B80 Offset: 0x1C73C81 VA: 0x1C73B80
	|-Array.InternalArray__ICollection_CopyTo<SixAxisSensorState>
	|
	|-RVA: 0x1C73BE0 Offset: 0x1C73CE1 VA: 0x1C73BE0
	|-Array.InternalArray__ICollection_CopyTo<SkeletonBone>
	|
	|-RVA: 0x1C73C40 Offset: 0x1C73D41 VA: 0x1C73C40
	|-Array.InternalArray__ICollection_CopyTo<SortingLayer>
	|
	|-RVA: 0x1C73CA0 Offset: 0x1C73DA1 VA: 0x1C73CA0
	|-Array.InternalArray__ICollection_CopyTo<SphericalHarmonicsL2>
	|
	|-RVA: 0x1C73D00 Offset: 0x1C73E01 VA: 0x1C73D00
	|-Array.InternalArray__ICollection_CopyTo<SpinLock>
	|
	|-RVA: 0x1C73D60 Offset: 0x1C73E61 VA: 0x1C73D60
	|-Array.InternalArray__ICollection_CopyTo<SpringBoneComponents>
	|
	|-RVA: 0x1C73DC0 Offset: 0x1C73EC1 VA: 0x1C73DC0
	|-Array.InternalArray__ICollection_CopyTo<SpringBoneProperties>
	|
	|-RVA: 0x1C73E20 Offset: 0x1C73F21 VA: 0x1C73E20
	|-Array.InternalArray__ICollection_CopyTo<SpringColliderComponents>
	|
	|-RVA: 0x1C73E80 Offset: 0x1C73F81 VA: 0x1C73E80
	|-Array.InternalArray__ICollection_CopyTo<SpringColliderProperties>
	|
	|-RVA: 0x1C73EE0 Offset: 0x1C73FE1 VA: 0x1C73EE0
	|-Array.InternalArray__ICollection_CopyTo<SpringForceComponent>
	|
	|-RVA: 0x1C73F40 Offset: 0x1C74041 VA: 0x1C73F40
	|-Array.InternalArray__ICollection_CopyTo<SpringJobElement>
	|
	|-RVA: 0x1C73FA0 Offset: 0x1C740A1 VA: 0x1C73FA0
	|-Array.InternalArray__ICollection_CopyTo<SpriteState>
	|
	|-RVA: 0x1C74000 Offset: 0x1C74101 VA: 0x1C74000
	|-Array.InternalArray__ICollection_CopyTo<SubMeshDescriptor>
	|
	|-RVA: 0x1C74060 Offset: 0x1C74161 VA: 0x1C74060
	|-Array.InternalArray__ICollection_CopyTo<TMP_CharacterInfo>
	|
	|-RVA: 0x1C740C0 Offset: 0x1C741C1 VA: 0x1C740C0
	|-Array.InternalArray__ICollection_CopyTo<TMP_FontWeightPair>
	|
	|-RVA: 0x1C74120 Offset: 0x1C74221 VA: 0x1C74120
	|-Array.InternalArray__ICollection_CopyTo<TMP_LineInfo>
	|
	|-RVA: 0x1C74180 Offset: 0x1C74281 VA: 0x1C74180
	|-Array.InternalArray__ICollection_CopyTo<TMP_LinkInfo>
	|
	|-RVA: 0x1C741E0 Offset: 0x1C742E1 VA: 0x1C741E0
	|-Array.InternalArray__ICollection_CopyTo<TMP_MeshInfo>
	|
	|-RVA: 0x1C74240 Offset: 0x1C74341 VA: 0x1C74240
	|-Array.InternalArray__ICollection_CopyTo<TMP_PageInfo>
	|
	|-RVA: 0x1C742A0 Offset: 0x1C743A1 VA: 0x1C742A0
	|-Array.InternalArray__ICollection_CopyTo<TMP_WordInfo>
	|
	|-RVA: 0x1C74300 Offset: 0x1C74401 VA: 0x1C74300
	|-Array.InternalArray__ICollection_CopyTo<TablePair>
	|
	|-RVA: 0x1C74360 Offset: 0x1C74461 VA: 0x1C74360
	|-Array.InternalArray__ICollection_CopyTo<TextureHandle>
	|
	|-RVA: 0x1C743C0 Offset: 0x1C744C1 VA: 0x1C743C0
	|-Array.InternalArray__ICollection_CopyTo<TimeSpan>
	|
	|-RVA: 0x1C74420 Offset: 0x1C74521 VA: 0x1C74420
	|-Array.InternalArray__ICollection_CopyTo<Touch>
	|
	|-RVA: 0x1C74480 Offset: 0x1C74581 VA: 0x1C74480
	|-Array.InternalArray__ICollection_CopyTo<TouchScreenState1>
	|
	|-RVA: 0x1C744E0 Offset: 0x1C745E1 VA: 0x1C744E0
	|-Array.InternalArray__ICollection_CopyTo<TouchScreenState10>
	|
	|-RVA: 0x1C74540 Offset: 0x1C74641 VA: 0x1C74540
	|-Array.InternalArray__ICollection_CopyTo<TouchScreenState11>
	|
	|-RVA: 0x1C745A0 Offset: 0x1C746A1 VA: 0x1C745A0
	|-Array.InternalArray__ICollection_CopyTo<TouchScreenState12>
	|
	|-RVA: 0x1C74600 Offset: 0x1C74701 VA: 0x1C74600
	|-Array.InternalArray__ICollection_CopyTo<TouchScreenState13>
	|
	|-RVA: 0x1C74660 Offset: 0x1C74761 VA: 0x1C74660
	|-Array.InternalArray__ICollection_CopyTo<TouchScreenState14>
	|
	|-RVA: 0x1C746C0 Offset: 0x1C747C1 VA: 0x1C746C0
	|-Array.InternalArray__ICollection_CopyTo<TouchScreenState15>
	|
	|-RVA: 0x1C74720 Offset: 0x1C74821 VA: 0x1C74720
	|-Array.InternalArray__ICollection_CopyTo<TouchScreenState16>
	|
	|-RVA: 0x1C74780 Offset: 0x1C74881 VA: 0x1C74780
	|-Array.InternalArray__ICollection_CopyTo<TouchScreenState2>
	|
	|-RVA: 0x1C747E0 Offset: 0x1C748E1 VA: 0x1C747E0
	|-Array.InternalArray__ICollection_CopyTo<TouchScreenState3>
	|
	|-RVA: 0x1C74840 Offset: 0x1C74941 VA: 0x1C74840
	|-Array.InternalArray__ICollection_CopyTo<TouchScreenState4>
	|
	|-RVA: 0x1C748A0 Offset: 0x1C749A1 VA: 0x1C748A0
	|-Array.InternalArray__ICollection_CopyTo<TouchScreenState5>
	|
	|-RVA: 0x1C74900 Offset: 0x1C74A01 VA: 0x1C74900
	|-Array.InternalArray__ICollection_CopyTo<TouchScreenState6>
	|
	|-RVA: 0x1C74960 Offset: 0x1C74A61 VA: 0x1C74960
	|-Array.InternalArray__ICollection_CopyTo<TouchScreenState7>
	|
	|-RVA: 0x1C749C0 Offset: 0x1C74AC1 VA: 0x1C749C0
	|-Array.InternalArray__ICollection_CopyTo<TouchScreenState8>
	|
	|-RVA: 0x1C74A20 Offset: 0x1C74B21 VA: 0x1C74A20
	|-Array.InternalArray__ICollection_CopyTo<TouchScreenState9>
	|
	|-RVA: 0x1C74A80 Offset: 0x1C74B81 VA: 0x1C74A80
	|-Array.InternalArray__ICollection_CopyTo<TouchState>
	|
	|-RVA: 0x1C74AE0 Offset: 0x1C74BE1 VA: 0x1C74AE0
	|-Array.InternalArray__ICollection_CopyTo<TrailHand>
	|
	|-RVA: 0x1C74B40 Offset: 0x1C74C41 VA: 0x1C74B40
	|-Array.InternalArray__ICollection_CopyTo<TrailVertex>
	|
	|-RVA: 0x1C74BA0 Offset: 0x1C74CA1 VA: 0x1C74BA0
	|-Array.InternalArray__ICollection_CopyTo<UICharInfo>
	|
	|-RVA: 0x1C74C00 Offset: 0x1C74D01 VA: 0x1C74C00
	|-Array.InternalArray__ICollection_CopyTo<UILineInfo>
	|
	|-RVA: 0x1C74C60 Offset: 0x1C74D61 VA: 0x1C74C60
	|-Array.InternalArray__ICollection_CopyTo<UIVertex>
	|
	|-RVA: 0x1C74CC0 Offset: 0x1C74DC1 VA: 0x1C74CC0
	|-Array.InternalArray__ICollection_CopyTo<ushort>
	|
	|-RVA: 0x1C74D20 Offset: 0x1C74E21 VA: 0x1C74D20
	|-Array.InternalArray__ICollection_CopyTo<UInt16Enum>
	|
	|-RVA: 0x1C74D80 Offset: 0x1C74E81 VA: 0x1C74D80
	|-Array.InternalArray__ICollection_CopyTo<uint>
	|
	|-RVA: 0x1C74DE0 Offset: 0x1C74EE1 VA: 0x1C74DE0
	|-Array.InternalArray__ICollection_CopyTo<UInt32Enum>
	|
	|-RVA: 0x1C74E40 Offset: 0x1C74F41 VA: 0x1C74E40
	|-Array.InternalArray__ICollection_CopyTo<ulong>
	|
	|-RVA: 0x1C74EA0 Offset: 0x1C74FA1 VA: 0x1C74EA0
	|-Array.InternalArray__ICollection_CopyTo<Uid>
	|
	|-RVA: 0x1C74F00 Offset: 0x1C75001 VA: 0x1C74F00
	|-Array.InternalArray__ICollection_CopyTo<UniTask>
	|
	|-RVA: 0x1C74F60 Offset: 0x1C75061 VA: 0x1C74F60
	|-Array.InternalArray__ICollection_CopyTo<Unit>
	|
	|-RVA: 0x1C74FC0 Offset: 0x1C750C1 VA: 0x1C74FC0
	|-Array.InternalArray__ICollection_CopyTo<UnitEnum>
	|
	|-RVA: 0x1C75020 Offset: 0x1C75121 VA: 0x1C75020
	|-Array.InternalArray__ICollection_CopyTo<UserWord>
	|
	|-RVA: 0x1C75080 Offset: 0x1C75181 VA: 0x1C75080
	|-Array.InternalArray__ICollection_CopyTo<Vector2>
	|
	|-RVA: 0x1C750E0 Offset: 0x1C751E1 VA: 0x1C750E0
	|-Array.InternalArray__ICollection_CopyTo<Vector2Int>
	|
	|-RVA: 0x1C75140 Offset: 0x1C75241 VA: 0x1C75140
	|-Array.InternalArray__ICollection_CopyTo<Vector3>
	|
	|-RVA: 0x1C751A0 Offset: 0x1C752A1 VA: 0x1C751A0
	|-Array.InternalArray__ICollection_CopyTo<Vector4>
	|
	|-RVA: 0x1C75200 Offset: 0x1C75301 VA: 0x1C75200
	|-Array.InternalArray__ICollection_CopyTo<VertexAttributeDescriptor>
	|
	|-RVA: 0x1C75260 Offset: 0x1C75361 VA: 0x1C75260
	|-Array.InternalArray__ICollection_CopyTo<VibrationDeviceHandle>
	|
	|-RVA: 0x1C752C0 Offset: 0x1C753C1 VA: 0x1C752C0
	|-Array.InternalArray__ICollection_CopyTo<VibrationDeviceInfo>
	|
	|-RVA: 0x1C75320 Offset: 0x1C75421 VA: 0x1C75320
	|-Array.InternalArray__ICollection_CopyTo<VibrationValue>
	|
	|-RVA: 0x1C75380 Offset: 0x1C75481 VA: 0x1C75380
	|-Array.InternalArray__ICollection_CopyTo<VisibleLight>
	|
	|-RVA: 0x1C753E0 Offset: 0x1C754E1 VA: 0x1C753E0
	|-Array.InternalArray__ICollection_CopyTo<WordWrapState>
	|
	|-RVA: 0x1C75440 Offset: 0x1C75541 VA: 0x1C75440
	|-Array.InternalArray__ICollection_CopyTo<X509ChainStatus>
	|
	|-RVA: 0x1C754A0 Offset: 0x1C755A1 VA: 0x1C754A0
	|-Array.InternalArray__ICollection_CopyTo<XPathNode>
	|
	|-RVA: 0x1C75500 Offset: 0x1C75601 VA: 0x1C75500
	|-Array.InternalArray__ICollection_CopyTo<XPathNodeRef>
	|
	|-RVA: 0x1C75560 Offset: 0x1C75661 VA: 0x1C75560
	|-Array.InternalArray__ICollection_CopyTo<XRView>
	|
	|-RVA: 0x1C755C0 Offset: 0x1C756C1 VA: 0x1C755C0
	|-Array.InternalArray__ICollection_CopyTo<float3>
	|
	|-RVA: 0x1C75620 Offset: 0x1C75721 VA: 0x1C75620
	|-Array.InternalArray__ICollection_CopyTo<float4x4>
	|
	|-RVA: 0x1C75680 Offset: 0x1C75781 VA: 0x1C75680
	|-Array.InternalArray__ICollection_CopyTo<jvalue>
	|
	|-RVA: 0x1C756E0 Offset: 0x1C757E1 VA: 0x1C756E0
	|-Array.InternalArray__ICollection_CopyTo<uint4>
	|
	|-RVA: 0x1C75740 Offset: 0x1C75841 VA: 0x1C75740
	|-Array.InternalArray__ICollection_CopyTo<AICrossfire.PositionTable>
	|
	|-RVA: 0x1C757A0 Offset: 0x1C758A1 VA: 0x1C757A0
	|-Array.InternalArray__ICollection_CopyTo<AIEnum.SkillRangeEnemyData>
	|
	|-RVA: 0x1C75800 Offset: 0x1C75901 VA: 0x1C75800
	|-Array.InternalArray__ICollection_CopyTo<AIOrder.UnitPriority>
	|
	|-RVA: 0x1C75860 Offset: 0x1C75961 VA: 0x1C75860
	|-Array.InternalArray__ICollection_CopyTo<AmiiboSequence.GainItemData>
	|
	|-RVA: 0x1C758C0 Offset: 0x1C759C1 VA: 0x1C758C0
	|-Array.InternalArray__ICollection_CopyTo<AnimationOutputWeightProcessor.WeightInfo>
	|
	|-RVA: 0x1C75920 Offset: 0x1C75A21 VA: 0x1C75920
	|-Array.InternalArray__ICollection_CopyTo<ArenaOrderSequence.GodInfo>
	|
	|-RVA: 0x1C75980 Offset: 0x1C75A81 VA: 0x1C75980
	|-Array.InternalArray__ICollection_CopyTo<BattleInfo.SupportData>
	|
	|-RVA: 0x1C759E0 Offset: 0x1C75AE1 VA: 0x1C759E0
	|-Array.InternalArray__ICollection_CopyTo<BeforeRenderHelper.OrderBlock>
	|
	|-RVA: 0x1C75A40 Offset: 0x1C75B41 VA: 0x1C75A40
	|-Array.InternalArray__ICollection_CopyTo<Camera.RenderRequest>
	|
	|-RVA: 0x1C75AA0 Offset: 0x1C75BA1 VA: 0x1C75AA0
	|-Array.InternalArray__ICollection_CopyTo<CameraState.CustomBlendable>
	|
	|-RVA: 0x1C75B00 Offset: 0x1C75C01 VA: 0x1C75B00
	|-Array.InternalArray__ICollection_CopyTo<CinemachineBlendListCamera.Instruction>
	|
	|-RVA: 0x1C75B60 Offset: 0x1C75C61 VA: 0x1C75B60
	|-Array.InternalArray__ICollection_CopyTo<CinemachineBlenderSettings.CustomBlend>
	|
	|-RVA: 0x1C75BC0 Offset: 0x1C75CC1 VA: 0x1C75BC0
	|-Array.InternalArray__ICollection_CopyTo<CinemachineClearShot.Pair>
	|
	|-RVA: 0x1C75C20 Offset: 0x1C75D21 VA: 0x1C75C20
	|-Array.InternalArray__ICollection_CopyTo<CinemachineFreeLook.Orbit>
	|
	|-RVA: 0x1C75C80 Offset: 0x1C75D81 VA: 0x1C75C80
	|-Array.InternalArray__ICollection_CopyTo<CinemachinePath.Waypoint>
	|
	|-RVA: 0x1C75CE0 Offset: 0x1C75DE1 VA: 0x1C75CE0
	|-Array.InternalArray__ICollection_CopyTo<CinemachineSmoothPath.Waypoint>
	|
	|-RVA: 0x1C75D40 Offset: 0x1C75E41 VA: 0x1C75D40
	|-Array.InternalArray__ICollection_CopyTo<CinemachineStateDrivenCamera.HashPair>
	|
	|-RVA: 0x1C75DA0 Offset: 0x1C75EA1 VA: 0x1C75DA0
	|-Array.InternalArray__ICollection_CopyTo<CinemachineStateDrivenCamera.Instruction>
	|
	|-RVA: 0x1C75E00 Offset: 0x1C75F01 VA: 0x1C75E00
	|-Array.InternalArray__ICollection_CopyTo<CinemachineStateDrivenCamera.ParentHash>
	|
	|-RVA: 0x1C75E60 Offset: 0x1C75F61 VA: 0x1C75E60
	|-Array.InternalArray__ICollection_CopyTo<CinemachineTargetGroup.Target>
	|
	|-RVA: 0x1C75EC0 Offset: 0x1C75FC1 VA: 0x1C75EC0
	|-Array.InternalArray__ICollection_CopyTo<CodePointIndexer.TableRange>
	|
	|-RVA: 0x1C75F20 Offset: 0x1C76021 VA: 0x1C75F20
	|-Array.InternalArray__ICollection_CopyTo<ContentCatalogData.Bucket>
	|
	|-RVA: 0x1C75F80 Offset: 0x1C76081 VA: 0x1C75F80
	|-Array.InternalArray__ICollection_CopyTo<CookieTokenizer.RecognizedAttribute>
	|
	|-RVA: 0x1C75FE0 Offset: 0x1C760E1 VA: 0x1C75FE0
	|-Array.InternalArray__ICollection_CopyTo<DeferredLights.DrawCall>
	|
	|-RVA: 0x1C76040 Offset: 0x1C76141 VA: 0x1C76040
	|-Array.InternalArray__ICollection_CopyTo<DeferredShaderData.ComputeBufferInfo>
	|
	|-RVA: 0x1C760A0 Offset: 0x1C761A1 VA: 0x1C760A0
	|-Array.InternalArray__ICollection_CopyTo<DeferredTiler.PrePunctualLight>
	|
	|-RVA: 0x1C76100 Offset: 0x1C76201 VA: 0x1C76100
	|-Array.InternalArray__ICollection_CopyTo<DelayedActionManager.DelegateInfo>
	|
	|-RVA: 0x1C76160 Offset: 0x1C76261 VA: 0x1C76160
	|-Array.InternalArray__ICollection_CopyTo<Detail.AsyncResultInt>
	|
	|-RVA: 0x1C761C0 Offset: 0x1C762C1 VA: 0x1C761C0
	|-Array.InternalArray__ICollection_CopyTo<Detail.CppArray>
	|
	|-RVA: 0x1C76220 Offset: 0x1C76321 VA: 0x1C76220
	|-Array.InternalArray__ICollection_CopyTo<Detail.NotificationEventInt>
	|
	|-RVA: 0x1C76280 Offset: 0x1C76381 VA: 0x1C76280
	|-Array.InternalArray__ICollection_CopyTo<DisposUnit.Item>
	|
	|-RVA: 0x1C762E0 Offset: 0x1C763E1 VA: 0x1C762E0
	|-Array.InternalArray__ICollection_CopyTo<DragonRidePresetParamData.CourseData>
	|
	|-RVA: 0x1C76340 Offset: 0x1C76441 VA: 0x1C76340
	|-Array.InternalArray__ICollection_CopyTo<DragonRideTargetGroup.ChainParam>
	|
	|-RVA: 0x1C763A0 Offset: 0x1C764A1 VA: 0x1C763A0
	|-Array.InternalArray__ICollection_CopyTo<DynamicMesh.State>
	|
	|-RVA: 0x1C76400 Offset: 0x1C76501 VA: 0x1C76400
	|-Array.InternalArray__ICollection_CopyTo<FXZEx.HitPoint>
	|
	|-RVA: 0x1C76460 Offset: 0x1C76561 VA: 0x1C76460
	|-Array.InternalArray__ICollection_CopyTo<FishingRadicalParamData.RadicalParam>
	|
	|-RVA: 0x1C764C0 Offset: 0x1C765C1 VA: 0x1C764C0
	|-Array.InternalArray__ICollection_CopyTo<GameVariable.Value>
	|
	|-RVA: 0x1C76520 Offset: 0x1C76621 VA: 0x1C76520
	|-Array.InternalArray__ICollection_CopyTo<GmapPathAdjuster.TargetModel>
	|
	|-RVA: 0x1C76580 Offset: 0x1C76681 VA: 0x1C76580
	|-Array.InternalArray__ICollection_CopyTo<GmapSpotAdjuster.TargetModel>
	|
	|-RVA: 0x1C765E0 Offset: 0x1C766E1 VA: 0x1C765E0
	|-Array.InternalArray__ICollection_CopyTo<GrounderQuadruped.Foot>
	|
	|-RVA: 0x1C76640 Offset: 0x1C76741 VA: 0x1C76640
	|-Array.InternalArray__ICollection_CopyTo<Hashtable.bucket>
	|
	|-RVA: 0x1C766A0 Offset: 0x1C767A1 VA: 0x1C766A0
	|-Array.InternalArray__ICollection_CopyTo<HeadingTracker.Item>
	|
	|-RVA: 0x1C76700 Offset: 0x1C76801 VA: 0x1C76700
	|-Array.InternalArray__ICollection_CopyTo<HubAccessoryRoomCamera.BackgroundSettings>
	|
	|-RVA: 0x1C76760 Offset: 0x1C76861 VA: 0x1C76760
	|-Array.InternalArray__ICollection_CopyTo<HubFastTravel.Location>
	|
	|-RVA: 0x1C767C0 Offset: 0x1C768C1 VA: 0x1C767C0
	|-Array.InternalArray__ICollection_CopyTo<HubLensFlare.Flare>
	|
	|-RVA: 0x1C76820 Offset: 0x1C76921 VA: 0x1C76820
	|-Array.InternalArray__ICollection_CopyTo<HubLookAtController.LookAtIKParam>
	|
	|-RVA: 0x1C76880 Offset: 0x1C76981 VA: 0x1C76880
	|-Array.InternalArray__ICollection_CopyTo<HubMaterialArray.MaterialInfo>
	|
	|-RVA: 0x1C768E0 Offset: 0x1C769E1 VA: 0x1C768E0
	|-Array.InternalArray__ICollection_CopyTo<IKSolverLimb.AxisDirection>
	|
	|-RVA: 0x1C76940 Offset: 0x1C76A41 VA: 0x1C76940
	|-Array.InternalArray__ICollection_CopyTo<InventoryPoolItemMenuContent.KindBgNameClass>
	|
	|-RVA: 0x1C769A0 Offset: 0x1C76AA1 VA: 0x1C769A0
	|-Array.InternalArray__ICollection_CopyTo<LightUtility.ParametricLightMeshVertex>
	|
	|-RVA: 0x1C76A00 Offset: 0x1C76B01 VA: 0x1C76A00
	|-Array.InternalArray__ICollection_CopyTo<LightUtility.SpriteLightMeshVertex>
	|
	|-RVA: 0x1C76A60 Offset: 0x1C76B61 VA: 0x1C76A60
	|-Array.InternalArray__ICollection_CopyTo<Map.Pos>
	|
	|-RVA: 0x1C76AC0 Offset: 0x1C76BC1 VA: 0x1C76AC0
	|-Array.InternalArray__ICollection_CopyTo<MapGodExp.KindDesc>
	|
	|-RVA: 0x1C76B20 Offset: 0x1C76C21 VA: 0x1C76B20
	|-Array.InternalArray__ICollection_CopyTo<MapHistory.Command>
	|
	|-RVA: 0x1C76B80 Offset: 0x1C76C81 VA: 0x1C76B80
	|-Array.InternalArray__ICollection_CopyTo<MapImage.BackupTerrain>
	|
	|-RVA: 0x1C76BE0 Offset: 0x1C76CE1 VA: 0x1C76BE0
	|-Array.InternalArray__ICollection_CopyTo<MapImageRange.Pos>
	|
	|-RVA: 0x1C76C40 Offset: 0x1C76D41 VA: 0x1C76C40
	|-Array.InternalArray__ICollection_CopyTo<MapKillBonus.KillBonus>
	|
	|-RVA: 0x1C76CA0 Offset: 0x1C76DA1 VA: 0x1C76CA0
	|-Array.InternalArray__ICollection_CopyTo<MapKillBonus.KilledBonus>
	|
	|-RVA: 0x1C76D00 Offset: 0x1C76E01 VA: 0x1C76D00
	|-Array.InternalArray__ICollection_CopyTo<MapMind.Record>
	|
	|-RVA: 0x1C76D60 Offset: 0x1C76E61 VA: 0x1C76D60
	|-Array.InternalArray__ICollection_CopyTo<MapMind.Target>
	|
	|-RVA: 0x1C76DC0 Offset: 0x1C76EC1 VA: 0x1C76DC0
	|-Array.InternalArray__ICollection_CopyTo<MapPanelDebug.Entity>
	|
	|-RVA: 0x1C76E20 Offset: 0x1C76F21 VA: 0x1C76E20
	|-Array.InternalArray__ICollection_CopyTo<NexRanking.Data>
	|
	|-RVA: 0x1C76E80 Offset: 0x1C76F81 VA: 0x1C76E80
	|-Array.InternalArray__ICollection_CopyTo<NexVersus.RatingData>
	|
	|-RVA: 0x1C76EE0 Offset: 0x1C76FE1 VA: 0x1C76EE0
	|-Array.InternalArray__ICollection_CopyTo<NoiseSettings.TransformNoiseParams>
	|
	|-RVA: 0x1C76F40 Offset: 0x1C77041 VA: 0x1C76F40
	|-Array.InternalArray__ICollection_CopyTo<PackedPlayModeBuildLogs.RuntimeBuildLog>
	|
	|-RVA: 0x1C76FA0 Offset: 0x1C770A1 VA: 0x1C76FA0
	|-Array.InternalArray__ICollection_CopyTo<ParameterizedStrings.FormatParam>
	|
	|-RVA: 0x1C77000 Offset: 0x1C77101 VA: 0x1C77000
	|-Array.InternalArray__ICollection_CopyTo<ParticleSystem.Particle>
	|
	|-RVA: 0x1C77060 Offset: 0x1C77161 VA: 0x1C77060
	|-Array.InternalArray__ICollection_CopyTo<ProfileCard.Achievement>
	|
	|-RVA: 0x1C770C0 Offset: 0x1C771C1 VA: 0x1C770C0
	|-Array.InternalArray__ICollection_CopyTo<ProfileCard.SortieCount>
	|
	|-RVA: 0x1C77120 Offset: 0x1C77221 VA: 0x1C77120
	|-Array.InternalArray__ICollection_CopyTo<QualitySettingsStack.Settings>
	|
	|-RVA: 0x1C77180 Offset: 0x1C77281 VA: 0x1C77180
	|-Array.InternalArray__ICollection_CopyTo<RangeData.Offset>
	|
	|-RVA: 0x1C771E0 Offset: 0x1C772E1 VA: 0x1C771E0
	|-Array.InternalArray__ICollection_CopyTo<RegexCharClass.LowerCaseMapping>
	|
	|-RVA: 0x1C77240 Offset: 0x1C77341 VA: 0x1C77240
	|-Array.InternalArray__ICollection_CopyTo<Relay.ChooseAwardeeData>
	|
	|-RVA: 0x1C772A0 Offset: 0x1C773A1 VA: 0x1C772A0
	|-Array.InternalArray__ICollection_CopyTo<RelayAwardData.Info>
	|
	|-RVA: 0x1C77300 Offset: 0x1C77401 VA: 0x1C77300
	|-Array.InternalArray__ICollection_CopyTo<RenderGraph.CompiledPassInfo>
	|
	|-RVA: 0x1C77360 Offset: 0x1C77461 VA: 0x1C77360
	|-Array.InternalArray__ICollection_CopyTo<RenderGraph.CompiledResourceInfo>
	|
	|-RVA: 0x1C773C0 Offset: 0x1C774C1 VA: 0x1C773C0
	|-Array.InternalArray__ICollection_CopyTo<RenderGraphDebugData.PassDebugData>
	|
	|-RVA: 0x1C77420 Offset: 0x1C77521 VA: 0x1C77420
	|-Array.InternalArray__ICollection_CopyTo<RenderGraphDebugData.ResourceDebugData>
	|
	|-RVA: 0x1C77480 Offset: 0x1C77581 VA: 0x1C77480
	|-Array.InternalArray__ICollection_CopyTo<RenderGraphResourceRegistry.RendererListResource>
	|
	|-RVA: 0x1C774E0 Offset: 0x1C775E1 VA: 0x1C774E0
	|-Array.InternalArray__ICollection_CopyTo<RingCleaningUnitSelectMenu.GodParam>
	|
	|-RVA: 0x1C77540 Offset: 0x1C77641 VA: 0x1C77540
	|-Array.InternalArray__ICollection_CopyTo<SampleWave.Data>
	|
	|-RVA: 0x1C775A0 Offset: 0x1C776A1 VA: 0x1C775A0
	|-Array.InternalArray__ICollection_CopyTo<SampleWave.Temp>
	|
	|-RVA: 0x1C77600 Offset: 0x1C77701 VA: 0x1C77600
	|-Array.InternalArray__ICollection_CopyTo<SendMouseEvents.HitInfo>
	|
	|-RVA: 0x1C77660 Offset: 0x1C77761 VA: 0x1C77660
	|-Array.InternalArray__ICollection_CopyTo<SequenceNode.SequenceConstructPosContext>
	|
	|-RVA: 0x1C776C0 Offset: 0x1C777C1 VA: 0x1C776C0
	|-Array.InternalArray__ICollection_CopyTo<ShaderInput.LightData>
	|
	|-RVA: 0x1C77720 Offset: 0x1C77821 VA: 0x1C77720
	|-Array.InternalArray__ICollection_CopyTo<ShaderInput.ShadowData>
	|
	|-RVA: 0x1C77780 Offset: 0x1C77881 VA: 0x1C77780
	|-Array.InternalArray__ICollection_CopyTo<ShadowUtility.Edge>
	|
	|-RVA: 0x1C777E0 Offset: 0x1C778E1 VA: 0x1C777E0
	|-Array.InternalArray__ICollection_CopyTo<SimpleAnimationPlayable.QueuedState>
	|
	|-RVA: 0x1C77840 Offset: 0x1C77941 VA: 0x1C77840
	|-Array.InternalArray__ICollection_CopyTo<SkillArray.Entity>
	|
	|-RVA: 0x1C778A0 Offset: 0x1C779A1 VA: 0x1C778A0
	|-Array.InternalArray__ICollection_CopyTo<Socket.WSABUF>
	|
	|-RVA: 0x1C77900 Offset: 0x1C77A01 VA: 0x1C77900
	|-Array.InternalArray__ICollection_CopyTo<Stream.Info>
	|
	|-RVA: 0x1C77960 Offset: 0x1C77A61 VA: 0x1C77960
	|-Array.InternalArray__ICollection_CopyTo<TMP_Text.UnicodeChar>
	|
	|-RVA: 0x1C779C0 Offset: 0x1C77AC1 VA: 0x1C779C0
	|-Array.InternalArray__ICollection_CopyTo<TexturePacker_JsonArray.Frame>
	|
	|-RVA: 0x1C77A20 Offset: 0x1C77B21 VA: 0x1C77A20
	|-Array.InternalArray__ICollection_CopyTo<TimeNotificationBehaviour.NotificationEntry>
	|
	|-RVA: 0x1C77A80 Offset: 0x1C77B81 VA: 0x1C77A80
	|-Array.InternalArray__ICollection_CopyTo<UnitySynchronizationContext.WorkRequest>
	|
	|-RVA: 0x1C77AE0 Offset: 0x1C77BE1 VA: 0x1C77AE0
	|-Array.InternalArray__ICollection_CopyTo<XmlNamespaceManager.NamespaceDeclaration>
	|
	|-RVA: 0x1C77B40 Offset: 0x1C77C41 VA: 0x1C77B40
	|-Array.InternalArray__ICollection_CopyTo<XmlSchemaObjectTable.XmlSchemaObjectEntry>
	|
	|-RVA: 0x1C77BA0 Offset: 0x1C77CA1 VA: 0x1C77BA0
	|-Array.InternalArray__ICollection_CopyTo<XmlTextReaderImpl.ParsingState>
	|
	|-RVA: 0x1C77C00 Offset: 0x1C77D01 VA: 0x1C77C00
	|-Array.InternalArray__ICollection_CopyTo<AIThink.EnchantThink.Desc>
	|
	|-RVA: 0x1C77C60 Offset: 0x1C77D61 VA: 0x1C77C60
	|-Array.InternalArray__ICollection_CopyTo<AIThink.EnchantThink.ItemInfo>
	|
	|-RVA: 0x1C77CC0 Offset: 0x1C77DC1 VA: 0x1C77CC0
	|-Array.InternalArray__ICollection_CopyTo<AIThink.EnchantThink.SurroundingInfo>
	|
	|-RVA: 0x1C77D20 Offset: 0x1C77E21 VA: 0x1C77D20
	|-Array.InternalArray__ICollection_CopyTo<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>
	|
	|-RVA: 0x1C77D80 Offset: 0x1C77E81 VA: 0x1C77D80
	|-Array.InternalArray__ICollection_CopyTo<Detail.DataStore.DataStoreChangeMetaParamInt>
	|
	|-RVA: 0x1C77DE0 Offset: 0x1C77EE1 VA: 0x1C77DE0
	|-Array.InternalArray__ICollection_CopyTo<Detail.DataStore.DataStoreDeleteParamInt>
	|
	|-RVA: 0x1C77E40 Offset: 0x1C77F41 VA: 0x1C77E40
	|-Array.InternalArray__ICollection_CopyTo<Detail.DataStore.DataStoreGetMetaParamInt>
	|
	|-RVA: 0x1C77EA0 Offset: 0x1C77FA1 VA: 0x1C77EA0
	|-Array.InternalArray__ICollection_CopyTo<Detail.DataStore.DataStoreMetaInfoInt>
	|
	|-RVA: 0x1C77F00 Offset: 0x1C78001 VA: 0x1C77F00
	|-Array.InternalArray__ICollection_CopyTo<Detail.DataStore.DataStorePasswordInfoInt>
	|
	|-RVA: 0x1C77F60 Offset: 0x1C78061 VA: 0x1C77F60
	|-Array.InternalArray__ICollection_CopyTo<Detail.DataStore.DataStorePersistenceInfoInt>
	|
	|-RVA: 0x1C77FC0 Offset: 0x1C780C1 VA: 0x1C77FC0
	|-Array.InternalArray__ICollection_CopyTo<Detail.DataStore.DataStorePreparePostParamInt>
	|
	|-RVA: 0x1C78020 Offset: 0x1C78121 VA: 0x1C78020
	|-Array.InternalArray__ICollection_CopyTo<Detail.DataStore.DataStoreRateObjectParamInt>
	|
	|-RVA: 0x1C78080 Offset: 0x1C78181 VA: 0x1C78080
	|-Array.InternalArray__ICollection_CopyTo<Detail.DataStore.DataStoreRatingInitParamInt>
	|
	|-RVA: 0x1C780E0 Offset: 0x1C781E1 VA: 0x1C780E0
	|-Array.InternalArray__ICollection_CopyTo<Detail.DataStore.DataStoreRatingTargetInt>
	|
	|-RVA: 0x1C78140 Offset: 0x1C78241 VA: 0x1C78140
	|-Array.InternalArray__ICollection_CopyTo<Detail.Ranking.RankingCachedResultInt>
	|
	|-RVA: 0x1C781A0 Offset: 0x1C782A1 VA: 0x1C781A0
	|-Array.InternalArray__ICollection_CopyTo<Detail.Ranking.RankingOrderParamInt>
	|
	|-RVA: 0x1C78200 Offset: 0x1C78301 VA: 0x1C78200
	|-Array.InternalArray__ICollection_CopyTo<Detail.Ranking.RankingRankDataInt>
	|
	|-RVA: 0x1C78260 Offset: 0x1C78361 VA: 0x1C78260
	|-Array.InternalArray__ICollection_CopyTo<Detail.Ranking2.Ranking2ChartInfoInt>
	|
	|-RVA: 0x1C782C0 Offset: 0x1C783C1 VA: 0x1C782C0
	|-Array.InternalArray__ICollection_CopyTo<Detail.Ranking2.Ranking2RankDataInt>
	|
	|-RVA: 0x1C78320 Offset: 0x1C78421 VA: 0x1C78320
	|-Array.InternalArray__ICollection_CopyTo<Detail.Ranking2.Ranking2ScoreDataInt>
	|
	|-RVA: 0x1C78380 Offset: 0x1C78481 VA: 0x1C78380
	|-Array.InternalArray__ICollection_CopyTo<Detail.Screening.ScreeningContextInfoInt>
	|
	|-RVA: 0x1C783E0 Offset: 0x1C784E1 VA: 0x1C783E0
	|-Array.InternalArray__ICollection_CopyTo<Detail.Subscriber.SubscriberContentInt>
	|
	|-RVA: 0x1C78440 Offset: 0x1C78541 VA: 0x1C78440
	|-Array.InternalArray__ICollection_CopyTo<Detail.Subscriber.SubscriberGetContentParamInt>
	|
	|-RVA: 0x1C784A0 Offset: 0x1C785A1 VA: 0x1C784A0
	|-Array.InternalArray__ICollection_CopyTo<Detail.Subscriber.SubscriberUserStatusInfoInt>
	|
	|-RVA: 0x1C78500 Offset: 0x1C78601 VA: 0x1C78500
	|-Array.InternalArray__ICollection_CopyTo<Detail.Subscriber.SubscriberUserStatusParamInt>
	|
	|-RVA: 0x1C78560 Offset: 0x1C78661 VA: 0x1C78560
	|-Array.InternalArray__ICollection_CopyTo<Detail.Utility.IntegerSettings>
	|
	|-RVA: 0x1C785C0 Offset: 0x1C786C1 VA: 0x1C785C0
	|-Array.InternalArray__ICollection_CopyTo<Detail.Utility.UniqueIdInfoInt>
	|
	|-RVA: 0x1C78620 Offset: 0x1C78721 VA: 0x1C78620
	|-Array.InternalArray__ICollection_CopyTo<FacetsChecker.FacetsCompiler.Map>
	|
	|-RVA: 0x1C78680 Offset: 0x1C78781 VA: 0x1C78680
	|-Array.InternalArray__ICollection_CopyTo<MapHistory.ReplayAppearanceMap.Appearance>
	|
	|-RVA: 0x1C786E0 Offset: 0x1C787E1 VA: 0x1C786E0
	|-Array.InternalArray__ICollection_CopyTo<MapHistory.ReplayAppearanceMap.Leaving>
	|
	|-RVA: 0x1C78740 Offset: 0x1C78841 VA: 0x1C78740
	|-Array.InternalArray__ICollection_CopyTo<MapHistory.ReplayUnitMap.Data>
	|
	|-RVA: 0x1C787A0 Offset: 0x1C788A1 VA: 0x1C787A0
	|-Array.InternalArray__ICollection_CopyTo<MapHistory.Rewind.LatestInspectorData>
	|
	|-RVA: 0x1C78800 Offset: 0x1C78901 VA: 0x1C78800
	|-Array.InternalArray__ICollection_CopyTo<MapHistory.Rewind.WorkTerrainData>
	|
	|-RVA: 0x1C78860 Offset: 0x1C78961 VA: 0x1C78860
	|-Array.InternalArray__ICollection_CopyTo<MapHistory.RewindUnitMap.Data>
	|
	|-RVA: 0x1C788C0 Offset: 0x1C789C1 VA: 0x1C788C0
	|-Array.InternalArray__ICollection_CopyTo<MapKillBonus.Work.Pos>
	|
	|-RVA: 0x1C78920 Offset: 0x1C78A21 VA: 0x1C78920
	|-Array.InternalArray__ICollection_CopyTo<MapSkill.AroundCalculator.Result>
	|
	|-RVA: 0x1C78980 Offset: 0x1C78A81 VA: 0x1C78980
	|-Array.InternalArray__ICollection_CopyTo<Nex.ApiCallChecker.Guideline>
	|
	|-RVA: 0x1C789E0 Offset: 0x1C78AE1 VA: 0x1C789E0
	|-Array.InternalArray__ICollection_CopyTo<Ngc.MaskTextSequenceBase.Data>
	|
	|-RVA: 0x1C78A40 Offset: 0x1C78B41 VA: 0x1C78A40
	|-Array.InternalArray__ICollection_CopyTo<TargetPositionCache.CacheCurve.Item>
	|
	|-RVA: 0x1C78AA0 Offset: 0x1C78BA1 VA: 0x1C78AA0
	|-Array.InternalArray__ICollection_CopyTo<TargetPositionCache.CacheEntry.RecordingItem>
	|
	|-RVA: 0x1C78B00 Offset: 0x1C78C01 VA: 0x1C78B00
	|-Array.InternalArray__ICollection_CopyTo<TerrainUtility.TerrainMap.TileCoord>
	*/

	// RVA: -1 Offset: -1
	internal T InternalArray__IReadOnlyList_get_Item<T>(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E30730 Offset: 0x1E30831 VA: 0x1E30730
	|-Array.InternalArray__IReadOnlyList_get_Item<ArraySegment<byte>>
	|
	|-RVA: 0x1E307E0 Offset: 0x1E308E1 VA: 0x1E307E0
	|-Array.InternalArray__IReadOnlyList_get_Item<AsyncOperationHandle<object>>
	|
	|-RVA: 0x1E308A0 Offset: 0x1E309A1 VA: 0x1E308A0
	|-Array.InternalArray__IReadOnlyList_get_Item<MapDeployTemplate.Queue.Data<object>>
	|
	|-RVA: 0x1E30950 Offset: 0x1E30A51 VA: 0x1E30950
	|-Array.InternalArray__IReadOnlyList_get_Item<Nex.DataStore.ParamPool.Data<object>>
	|
	|-RVA: 0x1E30A00 Offset: 0x1E30B01 VA: 0x1E30A00
	|-Array.InternalArray__IReadOnlyList_get_Item<Nex.Screening.ParamPool.Data<object>>
	|
	|-RVA: 0x1E30AB0 Offset: 0x1E30BB1 VA: 0x1E30AB0
	|-Array.InternalArray__IReadOnlyList_get_Item<IntervalTree.Entry<object>>
	|
	|-RVA: 0x1E30B70 Offset: 0x1E30C71 VA: 0x1E30B70
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<ValueTuple<object, int>, object>>
	|
	|-RVA: 0x1E30C30 Offset: 0x1E30D31 VA: 0x1E30C30
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<byte, object>>
	|
	|-RVA: 0x1E30CF0 Offset: 0x1E30DF1 VA: 0x1E30CF0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<CancellationToken, object>>
	|
	|-RVA: 0x1E30DB0 Offset: 0x1E30EB1 VA: 0x1E30DB0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<char, object>>
	|
	|-RVA: 0x1E30E70 Offset: 0x1E30F71 VA: 0x1E30E70
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Guid, object>>
	|
	|-RVA: 0x1E30F30 Offset: 0x1E31031 VA: 0x1E30F30
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<int, bool>>
	|
	|-RVA: 0x1E30FE0 Offset: 0x1E310E1 VA: 0x1E30FE0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<int, byte>>
	|
	|-RVA: 0x1E31090 Offset: 0x1E31191 VA: 0x1E31090
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<int, char>>
	|
	|-RVA: 0x1E31140 Offset: 0x1E31241 VA: 0x1E31140
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<int, DiagnosticEvent>>
	|
	|-RVA: 0x1E31220 Offset: 0x1E31321 VA: 0x1E31220
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<int, int>>
	|
	|-RVA: 0x1E312D0 Offset: 0x1E313D1 VA: 0x1E312D0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<int, Int32Enum>>
	|
	|-RVA: 0x1E31380 Offset: 0x1E31481 VA: 0x1E31380
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<int, long>>
	|
	|-RVA: 0x1E31440 Offset: 0x1E31541 VA: 0x1E31440
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<int, MapPos>>
	|
	|-RVA: 0x1E31500 Offset: 0x1E31601 VA: 0x1E31500
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<int, object>>
	|
	|-RVA: 0x1E315C0 Offset: 0x1E316C1 VA: 0x1E315C0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<int, uint>>
	|
	|-RVA: 0x1E31670 Offset: 0x1E31771 VA: 0x1E31670
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<int, AIThink.EnchantThink.SurroundingInfo>>
	|
	|-RVA: 0x1E31720 Offset: 0x1E31821 VA: 0x1E31720
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Int32Enum, bool>>
	|
	|-RVA: 0x1E317D0 Offset: 0x1E318D1 VA: 0x1E317D0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Int32Enum, int>>
	|
	|-RVA: 0x1E31880 Offset: 0x1E31981 VA: 0x1E31880
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Int32Enum, Int32Enum>>
	|
	|-RVA: 0x1E31930 Offset: 0x1E31A31 VA: 0x1E31930
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Int32Enum, object>>
	|
	|-RVA: 0x1E319F0 Offset: 0x1E31AF1 VA: 0x1E319F0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<long, object>>
	|
	|-RVA: 0x1E31AB0 Offset: 0x1E31BB1 VA: 0x1E31AB0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<MapPos, int>>
	|
	|-RVA: 0x1E31B70 Offset: 0x1E31C71 VA: 0x1E31B70
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, AsyncOperationHandle<object>>>
	|
	|-RVA: 0x1E31C40 Offset: 0x1E31D41 VA: 0x1E31C40
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, AsyncOperationHandle>>
	|
	|-RVA: 0x1E31D10 Offset: 0x1E31E11 VA: 0x1E31D10
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, bool>>
	|
	|-RVA: 0x1E31DD0 Offset: 0x1E31ED1 VA: 0x1E31DD0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, byte>>
	|
	|-RVA: 0x1E31E90 Offset: 0x1E31F91 VA: 0x1E31E90
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, int>>
	|
	|-RVA: 0x1E31F50 Offset: 0x1E32051 VA: 0x1E31F50
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, Int32Enum>>
	|
	|-RVA: 0x1E32010 Offset: 0x1E32111 VA: 0x1E32010
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, IntPtr>>
	|
	|-RVA: 0x1E320D0 Offset: 0x1E321D1 VA: 0x1E320D0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, object>>
	|
	|-RVA: 0x1E32190 Offset: 0x1E32291 VA: 0x1E32190
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, Playable>>
	|
	|-RVA: 0x1E32250 Offset: 0x1E32351 VA: 0x1E32250
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, ResourceLocator>>
	|
	|-RVA: 0x1E32310 Offset: 0x1E32411 VA: 0x1E32310
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, float>>
	|
	|-RVA: 0x1E323D0 Offset: 0x1E324D1 VA: 0x1E323D0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, ushort>>
	|
	|-RVA: 0x1E32490 Offset: 0x1E32591 VA: 0x1E32490
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<object, GameVariable.Value>>
	|
	|-RVA: 0x1E32550 Offset: 0x1E32651 VA: 0x1E32550
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<sbyte, DataStoreRatingInfo>>
	|
	|-RVA: 0x1E32620 Offset: 0x1E32721 VA: 0x1E32620
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<sbyte, object>>
	|
	|-RVA: 0x1E326E0 Offset: 0x1E327E1 VA: 0x1E326E0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<ushort, int>>
	|
	|-RVA: 0x1E32790 Offset: 0x1E32891 VA: 0x1E32790
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<uint, int>>
	|
	|-RVA: 0x1E32840 Offset: 0x1E32941 VA: 0x1E32840
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<uint, object>>
	|
	|-RVA: 0x1E32900 Offset: 0x1E32A01 VA: 0x1E32900
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<ulong, Friend>>
	|
	|-RVA: 0x1E329D0 Offset: 0x1E32AD1 VA: 0x1E329D0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<ulong, Int32Enum>>
	|
	|-RVA: 0x1E32A90 Offset: 0x1E32B91 VA: 0x1E32A90
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<ulong, object>>
	|
	|-RVA: 0x1E32B50 Offset: 0x1E32C51 VA: 0x1E32B50
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<Vector3, int>>
	|
	|-RVA: 0x1E32C10 Offset: 0x1E32D11 VA: 0x1E32C10
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<XPathNodeRef, XPathNodeRef>>
	|
	|-RVA: 0x1E32CE0 Offset: 0x1E32DE1 VA: 0x1E32CE0
	|-Array.InternalArray__IReadOnlyList_get_Item<Dictionary.Entry<TerrainUtility.TerrainMap.TileCoord, object>>
	|
	|-RVA: 0x1E32DA0 Offset: 0x1E32EA1 VA: 0x1E32DA0
	|-Array.InternalArray__IReadOnlyList_get_Item<PriorityQueue.IndexedItem<object>>
	|
	|-RVA: 0x1E32E50 Offset: 0x1E32F51 VA: 0x1E32E50
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<ValueTuple<object, int>, object>>
	|
	|-RVA: 0x1E32F10 Offset: 0x1E33011 VA: 0x1E32F10
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<byte, object>>
	|
	|-RVA: 0x1E32FC0 Offset: 0x1E330C1 VA: 0x1E32FC0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<CancellationToken, object>>
	|
	|-RVA: 0x1E33070 Offset: 0x1E33171 VA: 0x1E33070
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<char, object>>
	|
	|-RVA: 0x1E33120 Offset: 0x1E33221 VA: 0x1E33120
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<DateTime, object>>
	|
	|-RVA: 0x1E331D0 Offset: 0x1E332D1 VA: 0x1E331D0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Guid, object>>
	|
	|-RVA: 0x1E33290 Offset: 0x1E33391 VA: 0x1E33290
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<int, bool>>
	|
	|-RVA: 0x1E33340 Offset: 0x1E33441 VA: 0x1E33340
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<int, byte>>
	|
	|-RVA: 0x1E333F0 Offset: 0x1E334F1 VA: 0x1E333F0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<int, char>>
	|
	|-RVA: 0x1E334A0 Offset: 0x1E335A1 VA: 0x1E334A0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<int, DiagnosticEvent>>
	|
	|-RVA: 0x1E33580 Offset: 0x1E33681 VA: 0x1E33580
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<int, int>>
	|
	|-RVA: 0x1E33630 Offset: 0x1E33731 VA: 0x1E33630
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<int, Int32Enum>>
	|
	|-RVA: 0x1E336E0 Offset: 0x1E337E1 VA: 0x1E336E0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<int, long>>
	|
	|-RVA: 0x1E33790 Offset: 0x1E33891 VA: 0x1E33790
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<int, MapPos>>
	|
	|-RVA: 0x1E33840 Offset: 0x1E33941 VA: 0x1E33840
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<int, object>>
	|
	|-RVA: 0x1E338F0 Offset: 0x1E339F1 VA: 0x1E338F0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<int, uint>>
	|
	|-RVA: 0x1E339A0 Offset: 0x1E33AA1 VA: 0x1E339A0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<int, AIThink.EnchantThink.SurroundingInfo>>
	|
	|-RVA: 0x1E33A50 Offset: 0x1E33B51 VA: 0x1E33A50
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Int32Enum, bool>>
	|
	|-RVA: 0x1E33B00 Offset: 0x1E33C01 VA: 0x1E33B00
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Int32Enum, int>>
	|
	|-RVA: 0x1E33BB0 Offset: 0x1E33CB1 VA: 0x1E33BB0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Int32Enum, Int32Enum>>
	|
	|-RVA: 0x1E33C60 Offset: 0x1E33D61 VA: 0x1E33C60
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Int32Enum, object>>
	|
	|-RVA: 0x1E33D10 Offset: 0x1E33E11 VA: 0x1E33D10
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<long, object>>
	|
	|-RVA: 0x1E33DC0 Offset: 0x1E33EC1 VA: 0x1E33DC0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<MapPos, int>>
	|
	|-RVA: 0x1E33E70 Offset: 0x1E33F71 VA: 0x1E33E70
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, AsyncOperationHandle<object>>>
	|
	|-RVA: 0x1E33F30 Offset: 0x1E34031 VA: 0x1E33F30
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, ValueTuple<int, DateTime, object>>>
	|
	|-RVA: 0x1E33FF0 Offset: 0x1E340F1 VA: 0x1E33FF0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, AsyncOperationHandle>>
	|
	|-RVA: 0x1E340B0 Offset: 0x1E341B1 VA: 0x1E340B0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, bool>>
	|
	|-RVA: 0x1E34160 Offset: 0x1E34261 VA: 0x1E34160
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, byte>>
	|
	|-RVA: 0x1E34210 Offset: 0x1E34311 VA: 0x1E34210
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, int>>
	|
	|-RVA: 0x1E342C0 Offset: 0x1E343C1 VA: 0x1E342C0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, Int32Enum>>
	|
	|-RVA: 0x1E34370 Offset: 0x1E34471 VA: 0x1E34370
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, IntPtr>>
	|
	|-RVA: 0x1E34420 Offset: 0x1E34521 VA: 0x1E34420
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, object>>
	|
	|-RVA: 0x1E344D0 Offset: 0x1E345D1 VA: 0x1E344D0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, Playable>>
	|
	|-RVA: 0x1E34590 Offset: 0x1E34691 VA: 0x1E34590
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, ResourceLocator>>
	|
	|-RVA: 0x1E34650 Offset: 0x1E34751 VA: 0x1E34650
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, float>>
	|
	|-RVA: 0x1E34700 Offset: 0x1E34801 VA: 0x1E34700
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, ushort>>
	|
	|-RVA: 0x1E347B0 Offset: 0x1E348B1 VA: 0x1E347B0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<object, GameVariable.Value>>
	|
	|-RVA: 0x1E34870 Offset: 0x1E34971 VA: 0x1E34870
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<sbyte, DataStoreRatingInfo>>
	|
	|-RVA: 0x1E34930 Offset: 0x1E34A31 VA: 0x1E34930
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<sbyte, object>>
	|
	|-RVA: 0x1E349E0 Offset: 0x1E34AE1 VA: 0x1E349E0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<ushort, int>>
	|
	|-RVA: 0x1E34A90 Offset: 0x1E34B91 VA: 0x1E34A90
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<uint, int>>
	|
	|-RVA: 0x1E34B40 Offset: 0x1E34C41 VA: 0x1E34B40
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<uint, object>>
	|
	|-RVA: 0x1E34BF0 Offset: 0x1E34CF1 VA: 0x1E34BF0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<ulong, Friend>>
	|
	|-RVA: 0x1E34CC0 Offset: 0x1E34DC1 VA: 0x1E34CC0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<ulong, Int32Enum>>
	|
	|-RVA: 0x1E34D70 Offset: 0x1E34E71 VA: 0x1E34D70
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<ulong, object>>
	|
	|-RVA: 0x1E34E20 Offset: 0x1E34F21 VA: 0x1E34E20
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<Vector3, int>>
	|
	|-RVA: 0x1E34ED0 Offset: 0x1E34FD1 VA: 0x1E34ED0
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<XPathNodeRef, XPathNodeRef>>
	|
	|-RVA: 0x1E34F90 Offset: 0x1E35091 VA: 0x1E34F90
	|-Array.InternalArray__IReadOnlyList_get_Item<KeyValuePair<TerrainUtility.TerrainMap.TileCoord, object>>
	|
	|-RVA: 0x1E35040 Offset: 0x1E35141 VA: 0x1E35040
	|-Array.InternalArray__IReadOnlyList_get_Item<NativeArray<PreTile>>
	|
	|-RVA: 0x1E350F0 Offset: 0x1E351F1 VA: 0x1E350F0
	|-Array.InternalArray__IReadOnlyList_get_Item<CommonBattleSequence.Reliance<object>>
	|
	|-RVA: 0x1E351B0 Offset: 0x1E352B1 VA: 0x1E351B0
	|-Array.InternalArray__IReadOnlyList_get_Item<RenderGraphResourcePool.ResourceLogInfo<object>>
	|
	|-RVA: 0x1E35260 Offset: 0x1E35361 VA: 0x1E35260
	|-Array.InternalArray__IReadOnlyList_get_Item<HashSet.Slot<ValueTuple<object, int>>>
	|
	|-RVA: 0x1E35320 Offset: 0x1E35421 VA: 0x1E35320
	|-Array.InternalArray__IReadOnlyList_get_Item<HashSet.Slot<AsyncOperationHandle>>
	|
	|-RVA: 0x1E353E0 Offset: 0x1E354E1 VA: 0x1E353E0
	|-Array.InternalArray__IReadOnlyList_get_Item<HashSet.Slot<int>>
	|
	|-RVA: 0x1E35490 Offset: 0x1E35591 VA: 0x1E35490
	|-Array.InternalArray__IReadOnlyList_get_Item<HashSet.Slot<Int32Enum>>
	|
	|-RVA: 0x1E35540 Offset: 0x1E35641 VA: 0x1E35540
	|-Array.InternalArray__IReadOnlyList_get_Item<Set.Slot<Int32Enum>>
	|
	|-RVA: 0x1E355F0 Offset: 0x1E356F1 VA: 0x1E355F0
	|-Array.InternalArray__IReadOnlyList_get_Item<HashSet.Slot<MapPos>>
	|
	|-RVA: 0x1E356A0 Offset: 0x1E357A1 VA: 0x1E356A0
	|-Array.InternalArray__IReadOnlyList_get_Item<HashSet.Slot<object>>
	|
	|-RVA: 0x1E35750 Offset: 0x1E35851 VA: 0x1E35750
	|-Array.InternalArray__IReadOnlyList_get_Item<Set.Slot<object>>
	|
	|-RVA: 0x1E35810 Offset: 0x1E35911 VA: 0x1E35810
	|-Array.InternalArray__IReadOnlyList_get_Item<HashSet.Slot<uint>>
	|
	|-RVA: 0x1E358C0 Offset: 0x1E359C1 VA: 0x1E358C0
	|-Array.InternalArray__IReadOnlyList_get_Item<HashSet.Slot<ulong>>
	|
	|-RVA: 0x1E35970 Offset: 0x1E35A71 VA: 0x1E35970
	|-Array.InternalArray__IReadOnlyList_get_Item<Set.Slot<Vector3>>
	|
	|-RVA: 0x1E35A30 Offset: 0x1E35B31 VA: 0x1E35A30
	|-Array.InternalArray__IReadOnlyList_get_Item<TMP_TextProcessingStack<Color32>>
	|
	|-RVA: 0x1E35AF0 Offset: 0x1E35BF1 VA: 0x1E35AF0
	|-Array.InternalArray__IReadOnlyList_get_Item<TMP_TextProcessingStack<HighlightState>>
	|
	|-RVA: 0x1E35BC0 Offset: 0x1E35CC1 VA: 0x1E35BC0
	|-Array.InternalArray__IReadOnlyList_get_Item<TMP_TextProcessingStack<int>>
	|
	|-RVA: 0x1E35C80 Offset: 0x1E35D81 VA: 0x1E35C80
	|-Array.InternalArray__IReadOnlyList_get_Item<TMP_TextProcessingStack<Int32Enum>>
	|
	|-RVA: 0x1E35D40 Offset: 0x1E35E41 VA: 0x1E35D40
	|-Array.InternalArray__IReadOnlyList_get_Item<TMP_TextProcessingStack<MaterialReference>>
	|
	|-RVA: 0x1E35E30 Offset: 0x1E35F31 VA: 0x1E35E30
	|-Array.InternalArray__IReadOnlyList_get_Item<TMP_TextProcessingStack<object>>
	|
	|-RVA: 0x1E35F00 Offset: 0x1E36001 VA: 0x1E35F00
	|-Array.InternalArray__IReadOnlyList_get_Item<TMP_TextProcessingStack<float>>
	|
	|-RVA: 0x1E35FC0 Offset: 0x1E360C1 VA: 0x1E35FC0
	|-Array.InternalArray__IReadOnlyList_get_Item<TMP_TextProcessingStack<WordWrapState>>
	|
	|-RVA: 0x1E36090 Offset: 0x1E36191 VA: 0x1E36090
	|-Array.InternalArray__IReadOnlyList_get_Item<TimeInterval<object>>
	|
	|-RVA: 0x1E36140 Offset: 0x1E36241 VA: 0x1E36140
	|-Array.InternalArray__IReadOnlyList_get_Item<Timestamped<object>>
	|
	|-RVA: 0x1E36200 Offset: 0x1E36301 VA: 0x1E36200
	|-Array.InternalArray__IReadOnlyList_get_Item<UniTask<object>>
	|
	|-RVA: 0x1E362B0 Offset: 0x1E363B1 VA: 0x1E362B0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<ValueTuple<bool, object>>>
	|
	|-RVA: 0x1E36360 Offset: 0x1E36461 VA: 0x1E36360
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>
	|
	|-RVA: 0x1E36420 Offset: 0x1E36521 VA: 0x1E36420
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, UniTask<object>>>
	|
	|-RVA: 0x1E364E0 Offset: 0x1E365E1 VA: 0x1E364E0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>
	|
	|-RVA: 0x1E365A0 Offset: 0x1E366A1 VA: 0x1E365A0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>
	|
	|-RVA: 0x1E36670 Offset: 0x1E36771 VA: 0x1E36670
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>
	|
	|-RVA: 0x1E36740 Offset: 0x1E36841 VA: 0x1E36740
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>
	|
	|-RVA: 0x1E367F0 Offset: 0x1E368F1 VA: 0x1E367F0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>
	|
	|-RVA: 0x1E368A0 Offset: 0x1E369A1 VA: 0x1E368A0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>
	|
	|-RVA: 0x1E36980 Offset: 0x1E36A81 VA: 0x1E36980
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>
	|
	|-RVA: 0x1E36A30 Offset: 0x1E36B31 VA: 0x1E36A30
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>
	|
	|-RVA: 0x1E36B00 Offset: 0x1E36C01 VA: 0x1E36B00
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>
	|
	|-RVA: 0x1E36BD0 Offset: 0x1E36CD1 VA: 0x1E36BD0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>
	|
	|-RVA: 0x1E36C90 Offset: 0x1E36D91 VA: 0x1E36C90
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>
	|
	|-RVA: 0x1E36D60 Offset: 0x1E36E61 VA: 0x1E36D60
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x1E36E30 Offset: 0x1E36F31 VA: 0x1E36E30
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>
	|
	|-RVA: 0x1E36F00 Offset: 0x1E37001 VA: 0x1E36F00
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>
	|
	|-RVA: 0x1E36FD0 Offset: 0x1E370D1 VA: 0x1E36FD0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>
	|
	|-RVA: 0x1E37090 Offset: 0x1E37191 VA: 0x1E37090
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>
	|
	|-RVA: 0x1E37160 Offset: 0x1E37261 VA: 0x1E37160
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>
	|
	|-RVA: 0x1E37210 Offset: 0x1E37311 VA: 0x1E37210
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>
	|
	|-RVA: 0x1E372E0 Offset: 0x1E373E1 VA: 0x1E372E0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>
	|
	|-RVA: 0x1E373A0 Offset: 0x1E374A1 VA: 0x1E373A0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>
	|
	|-RVA: 0x1E37470 Offset: 0x1E37571 VA: 0x1E37470
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>
	|
	|-RVA: 0x1E37540 Offset: 0x1E37641 VA: 0x1E37540
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>
	|
	|-RVA: 0x1E37610 Offset: 0x1E37711 VA: 0x1E37610
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>
	|
	|-RVA: 0x1E376F0 Offset: 0x1E377F1 VA: 0x1E376F0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>
	|
	|-RVA: 0x1E377D0 Offset: 0x1E378D1 VA: 0x1E377D0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>
	|
	|-RVA: 0x1E378C0 Offset: 0x1E379C1 VA: 0x1E378C0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>
	|
	|-RVA: 0x1E379B0 Offset: 0x1E37AB1 VA: 0x1E379B0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>
	|
	|-RVA: 0x1E37AA0 Offset: 0x1E37BA1 VA: 0x1E37AA0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>
	|
	|-RVA: 0x1E37B50 Offset: 0x1E37C51 VA: 0x1E37B50
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>
	|
	|-RVA: 0x1E37C00 Offset: 0x1E37D01 VA: 0x1E37C00
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>
	|
	|-RVA: 0x1E37CD0 Offset: 0x1E37DD1 VA: 0x1E37CD0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>
	|
	|-RVA: 0x1E37D80 Offset: 0x1E37E81 VA: 0x1E37D80
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>
	|
	|-RVA: 0x1E37E40 Offset: 0x1E37F41 VA: 0x1E37E40
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>
	|
	|-RVA: 0x1E37F10 Offset: 0x1E38011 VA: 0x1E37F10
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>
	|
	|-RVA: 0x1E37FD0 Offset: 0x1E380D1 VA: 0x1E37FD0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>
	|
	|-RVA: 0x1E380A0 Offset: 0x1E381A1 VA: 0x1E380A0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x1E38170 Offset: 0x1E38271 VA: 0x1E38170
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>
	|
	|-RVA: 0x1E38230 Offset: 0x1E38331 VA: 0x1E38230
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>
	|
	|-RVA: 0x1E382F0 Offset: 0x1E383F1 VA: 0x1E382F0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>
	|
	|-RVA: 0x1E383B0 Offset: 0x1E384B1 VA: 0x1E383B0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>
	|
	|-RVA: 0x1E38480 Offset: 0x1E38581 VA: 0x1E38480
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>
	|
	|-RVA: 0x1E38530 Offset: 0x1E38631 VA: 0x1E38530
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>
	|
	|-RVA: 0x1E385F0 Offset: 0x1E386F1 VA: 0x1E385F0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>
	|
	|-RVA: 0x1E386C0 Offset: 0x1E387C1 VA: 0x1E386C0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>
	|
	|-RVA: 0x1E38780 Offset: 0x1E38881 VA: 0x1E38780
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>
	|
	|-RVA: 0x1E38850 Offset: 0x1E38951 VA: 0x1E38850
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>
	|
	|-RVA: 0x1E38920 Offset: 0x1E38A21 VA: 0x1E38920
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x1E38A00 Offset: 0x1E38B01 VA: 0x1E38A00
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>
	|
	|-RVA: 0x1E38AD0 Offset: 0x1E38BD1 VA: 0x1E38AD0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x1E38BC0 Offset: 0x1E38CC1 VA: 0x1E38BC0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>
	|
	|-RVA: 0x1E38CA0 Offset: 0x1E38DA1 VA: 0x1E38CA0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x1E38D90 Offset: 0x1E38E91 VA: 0x1E38D90
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>
	|
	|-RVA: 0x1E38E70 Offset: 0x1E38F71 VA: 0x1E38E70
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x1E38F70 Offset: 0x1E39071 VA: 0x1E38F70
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>
	|
	|-RVA: 0x1E39060 Offset: 0x1E39161 VA: 0x1E39060
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x1E39170 Offset: 0x1E39271 VA: 0x1E39170
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>
	|
	|-RVA: 0x1E39260 Offset: 0x1E39361 VA: 0x1E39260
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>
	|
	|-RVA: 0x1E39310 Offset: 0x1E39411 VA: 0x1E39310
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>
	|
	|-RVA: 0x1E393C0 Offset: 0x1E394C1 VA: 0x1E393C0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>
	|
	|-RVA: 0x1E39490 Offset: 0x1E39591 VA: 0x1E39490
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>
	|
	|-RVA: 0x1E39540 Offset: 0x1E39641 VA: 0x1E39540
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>
	|
	|-RVA: 0x1E39610 Offset: 0x1E39711 VA: 0x1E39610
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>
	|
	|-RVA: 0x1E396D0 Offset: 0x1E397D1 VA: 0x1E396D0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>
	|
	|-RVA: 0x1E39780 Offset: 0x1E39881 VA: 0x1E39780
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>
	|
	|-RVA: 0x1E39840 Offset: 0x1E39941 VA: 0x1E39840
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x1E39900 Offset: 0x1E39A01 VA: 0x1E39900
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>
	|
	|-RVA: 0x1E399D0 Offset: 0x1E39AD1 VA: 0x1E399D0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>
	|
	|-RVA: 0x1E39AA0 Offset: 0x1E39BA1 VA: 0x1E39AA0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>
	|
	|-RVA: 0x1E39B50 Offset: 0x1E39C51 VA: 0x1E39B50
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>
	|
	|-RVA: 0x1E39C10 Offset: 0x1E39D11 VA: 0x1E39C10
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>
	|
	|-RVA: 0x1E39CC0 Offset: 0x1E39DC1 VA: 0x1E39CC0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>
	|
	|-RVA: 0x1E39D80 Offset: 0x1E39E81 VA: 0x1E39D80
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>
	|
	|-RVA: 0x1E39E40 Offset: 0x1E39F41 VA: 0x1E39E40
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>
	|
	|-RVA: 0x1E39F10 Offset: 0x1E3A011 VA: 0x1E39F10
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>
	|
	|-RVA: 0x1E39FD0 Offset: 0x1E3A0D1 VA: 0x1E39FD0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>
	|
	|-RVA: 0x1E3A090 Offset: 0x1E3A191 VA: 0x1E3A090
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x1E3A170 Offset: 0x1E3A271 VA: 0x1E3A170
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>
	|
	|-RVA: 0x1E3A240 Offset: 0x1E3A341 VA: 0x1E3A240
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x1E3A330 Offset: 0x1E3A431 VA: 0x1E3A330
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>
	|
	|-RVA: 0x1E3A400 Offset: 0x1E3A501 VA: 0x1E3A400
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x1E3A4F0 Offset: 0x1E3A5F1 VA: 0x1E3A4F0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>
	|
	|-RVA: 0x1E3A5D0 Offset: 0x1E3A6D1 VA: 0x1E3A5D0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x1E3A6D0 Offset: 0x1E3A7D1 VA: 0x1E3A6D0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>
	|
	|-RVA: 0x1E3A7B0 Offset: 0x1E3A8B1 VA: 0x1E3A7B0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x1E3A8C0 Offset: 0x1E3A9C1 VA: 0x1E3A8C0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>
	|
	|-RVA: 0x1E3A9B0 Offset: 0x1E3AAB1 VA: 0x1E3A9B0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x1E3AA90 Offset: 0x1E3AB91 VA: 0x1E3AA90
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x1E3AB70 Offset: 0x1E3AC71 VA: 0x1E3AB70
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>
	|
	|-RVA: 0x1E3AC20 Offset: 0x1E3AD21 VA: 0x1E3AC20
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, bool>>>
	|
	|-RVA: 0x1E3ACD0 Offset: 0x1E3ADD1 VA: 0x1E3ACD0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, Bounds>>>
	|
	|-RVA: 0x1E3AD90 Offset: 0x1E3AE91 VA: 0x1E3AD90
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, byte>>>
	|
	|-RVA: 0x1E3AE40 Offset: 0x1E3AF41 VA: 0x1E3AE40
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, Color>>>
	|
	|-RVA: 0x1E3AF00 Offset: 0x1E3B001 VA: 0x1E3AF00
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, double>>>
	|
	|-RVA: 0x1E3AFC0 Offset: 0x1E3B0C1 VA: 0x1E3AFC0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, int>>>
	|
	|-RVA: 0x1E3B070 Offset: 0x1E3B171 VA: 0x1E3B070
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, long>>>
	|
	|-RVA: 0x1E3B130 Offset: 0x1E3B231 VA: 0x1E3B130
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, object>>>
	|
	|-RVA: 0x1E3B1F0 Offset: 0x1E3B2F1 VA: 0x1E3B1F0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, Quaternion>>>
	|
	|-RVA: 0x1E3B2B0 Offset: 0x1E3B3B1 VA: 0x1E3B2B0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, Rect>>>
	|
	|-RVA: 0x1E3B370 Offset: 0x1E3B471 VA: 0x1E3B370
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, float>>>
	|
	|-RVA: 0x1E3B420 Offset: 0x1E3B521 VA: 0x1E3B420
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, UniTask>>>
	|
	|-RVA: 0x1E3B4E0 Offset: 0x1E3B5E1 VA: 0x1E3B4E0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, Unit>>>
	|
	|-RVA: 0x1E3B590 Offset: 0x1E3B691 VA: 0x1E3B590
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, Vector2>>>
	|
	|-RVA: 0x1E3B640 Offset: 0x1E3B741 VA: 0x1E3B640
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, Vector3>>>
	|
	|-RVA: 0x1E3B700 Offset: 0x1E3B801 VA: 0x1E3B700
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<bool, Vector4>>>
	|
	|-RVA: 0x1E3B7C0 Offset: 0x1E3B8C1 VA: 0x1E3B7C0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<int, object>>>
	|
	|-RVA: 0x1E3B880 Offset: 0x1E3B981 VA: 0x1E3B880
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<object, object>>>
	|
	|-RVA: 0x1E3B940 Offset: 0x1E3BA41 VA: 0x1E3B940
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x1E3BA10 Offset: 0x1E3BB11 VA: 0x1E3BA10
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<object, object, object>>>
	|
	|-RVA: 0x1E3BAD0 Offset: 0x1E3BBD1 VA: 0x1E3BAD0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x1E3BBB0 Offset: 0x1E3BCB1 VA: 0x1E3BBB0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<object, object, object, object>>>
	|
	|-RVA: 0x1E3BC80 Offset: 0x1E3BD81 VA: 0x1E3BC80
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x1E3BD70 Offset: 0x1E3BE71 VA: 0x1E3BD70
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>
	|
	|-RVA: 0x1E3BE40 Offset: 0x1E3BF41 VA: 0x1E3BE40
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x1E3BF30 Offset: 0x1E3C031 VA: 0x1E3BF30
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>
	|
	|-RVA: 0x1E3C010 Offset: 0x1E3C111 VA: 0x1E3C010
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x1E3C110 Offset: 0x1E3C211 VA: 0x1E3C110
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>
	|
	|-RVA: 0x1E3C1F0 Offset: 0x1E3C2F1 VA: 0x1E3C1F0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x1E3C300 Offset: 0x1E3C401 VA: 0x1E3C300
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x1E3C3E0 Offset: 0x1E3C4E1 VA: 0x1E3C3E0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, AsyncUnit>>
	|
	|-RVA: 0x1E3C490 Offset: 0x1E3C591 VA: 0x1E3C490
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, bool>>
	|
	|-RVA: 0x1E3C540 Offset: 0x1E3C641 VA: 0x1E3C540
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, Bounds>>
	|
	|-RVA: 0x1E3C610 Offset: 0x1E3C711 VA: 0x1E3C610
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, byte>>
	|
	|-RVA: 0x1E3C6C0 Offset: 0x1E3C7C1 VA: 0x1E3C6C0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, Color>>
	|
	|-RVA: 0x1E3C780 Offset: 0x1E3C881 VA: 0x1E3C780
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, double>>
	|
	|-RVA: 0x1E3C830 Offset: 0x1E3C931 VA: 0x1E3C830
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, int>>
	|
	|-RVA: 0x1E3C8E0 Offset: 0x1E3C9E1 VA: 0x1E3C8E0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, long>>
	|
	|-RVA: 0x1E3C990 Offset: 0x1E3CA91 VA: 0x1E3C990
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, object>>
	|
	|-RVA: 0x1E3CA40 Offset: 0x1E3CB41 VA: 0x1E3CA40
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, Quaternion>>
	|
	|-RVA: 0x1E3CB00 Offset: 0x1E3CC01 VA: 0x1E3CB00
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, Rect>>
	|
	|-RVA: 0x1E3CBC0 Offset: 0x1E3CCC1 VA: 0x1E3CBC0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, float>>
	|
	|-RVA: 0x1E3CC70 Offset: 0x1E3CD71 VA: 0x1E3CC70
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, UniTask>>
	|
	|-RVA: 0x1E3CD20 Offset: 0x1E3CE21 VA: 0x1E3CD20
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, Unit>>
	|
	|-RVA: 0x1E3CDD0 Offset: 0x1E3CED1 VA: 0x1E3CDD0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, Vector2>>
	|
	|-RVA: 0x1E3CE80 Offset: 0x1E3CF81 VA: 0x1E3CE80
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, Vector3>>
	|
	|-RVA: 0x1E3CF30 Offset: 0x1E3D031 VA: 0x1E3CF30
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<bool, Vector4>>
	|
	|-RVA: 0x1E3CFF0 Offset: 0x1E3D0F1 VA: 0x1E3CFF0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<int, bool>>
	|
	|-RVA: 0x1E3D0A0 Offset: 0x1E3D1A1 VA: 0x1E3D0A0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<int, Bounds>>
	|
	|-RVA: 0x1E3D170 Offset: 0x1E3D271 VA: 0x1E3D170
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<int, byte>>
	|
	|-RVA: 0x1E3D220 Offset: 0x1E3D321 VA: 0x1E3D220
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<int, Color>>
	|
	|-RVA: 0x1E3D2E0 Offset: 0x1E3D3E1 VA: 0x1E3D2E0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<int, double>>
	|
	|-RVA: 0x1E3D390 Offset: 0x1E3D491 VA: 0x1E3D390
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<int, int>>
	|
	|-RVA: 0x1E3D440 Offset: 0x1E3D541 VA: 0x1E3D440
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<int, long>>
	|
	|-RVA: 0x1E3D4F0 Offset: 0x1E3D5F1 VA: 0x1E3D4F0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<int, object>>
	|
	|-RVA: 0x1E3D5A0 Offset: 0x1E3D6A1 VA: 0x1E3D5A0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<int, Quaternion>>
	|
	|-RVA: 0x1E3D660 Offset: 0x1E3D761 VA: 0x1E3D660
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<int, Rect>>
	|
	|-RVA: 0x1E3D720 Offset: 0x1E3D821 VA: 0x1E3D720
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<int, float>>
	|
	|-RVA: 0x1E3D7D0 Offset: 0x1E3D8D1 VA: 0x1E3D7D0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<int, Unit>>
	|
	|-RVA: 0x1E3D880 Offset: 0x1E3D981 VA: 0x1E3D880
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<int, Vector2>>
	|
	|-RVA: 0x1E3D930 Offset: 0x1E3DA31 VA: 0x1E3D930
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<int, Vector3>>
	|
	|-RVA: 0x1E3D9E0 Offset: 0x1E3DAE1 VA: 0x1E3D9E0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<int, Vector4>>
	|
	|-RVA: 0x1E3DAA0 Offset: 0x1E3DBA1 VA: 0x1E3DAA0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<Int32Enum, int>>
	|
	|-RVA: 0x1E3DB50 Offset: 0x1E3DC51 VA: 0x1E3DB50
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<object, ValueTuple<object, int>>>
	|
	|-RVA: 0x1E3DC10 Offset: 0x1E3DD11 VA: 0x1E3DC10
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<object, int>>
	|
	|-RVA: 0x1E3DCC0 Offset: 0x1E3DDC1 VA: 0x1E3DCC0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<object, object>>
	|
	|-RVA: 0x1E3DD70 Offset: 0x1E3DE71 VA: 0x1E3DD70
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<object, float>>
	|
	|-RVA: 0x1E3DE20 Offset: 0x1E3DF21 VA: 0x1E3DE20
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<Vector3, float>>
	|
	|-RVA: 0x1E3DED0 Offset: 0x1E3DFD1 VA: 0x1E3DED0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>
	|
	|-RVA: 0x1E3DFA0 Offset: 0x1E3E0A1 VA: 0x1E3DFA0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<object, Int32Enum, int>>
	|
	|-RVA: 0x1E3E050 Offset: 0x1E3E151 VA: 0x1E3E050
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<object, object, object>>
	|
	|-RVA: 0x1E3E110 Offset: 0x1E3E211 VA: 0x1E3E110
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>
	|
	|-RVA: 0x1E3E1F0 Offset: 0x1E3E2F1 VA: 0x1E3E1F0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<object, int, int, int>>
	|
	|-RVA: 0x1E3E2B0 Offset: 0x1E3E3B1 VA: 0x1E3E2B0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<object, object, object, object>>
	|
	|-RVA: 0x1E3E370 Offset: 0x1E3E471 VA: 0x1E3E370
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>
	|
	|-RVA: 0x1E3E460 Offset: 0x1E3E561 VA: 0x1E3E460
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<object, object, object, object, object>>
	|
	|-RVA: 0x1E3E530 Offset: 0x1E3E631 VA: 0x1E3E530
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>
	|
	|-RVA: 0x1E3E620 Offset: 0x1E3E721 VA: 0x1E3E620
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<object, object, object, object, object, object>>
	|
	|-RVA: 0x1E3E6F0 Offset: 0x1E3E7F1 VA: 0x1E3E6F0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>
	|
	|-RVA: 0x1E3E7F0 Offset: 0x1E3E8F1 VA: 0x1E3E7F0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<object, object, object, object, object, object, object>>
	|
	|-RVA: 0x1E3E8D0 Offset: 0x1E3E9D1 VA: 0x1E3E8D0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>
	|
	|-RVA: 0x1E3E9E0 Offset: 0x1E3EAE1 VA: 0x1E3E9E0
	|-Array.InternalArray__IReadOnlyList_get_Item<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x1E3EAC0 Offset: 0x1E3EBC1 VA: 0x1E3EAC0
	|-Array.InternalArray__IReadOnlyList_get_Item<AnimatorClipInfo>
	|
	|-RVA: 0x1E3EB70 Offset: 0x1E3EC71 VA: 0x1E3EB70
	|-Array.InternalArray__IReadOnlyList_get_Item<AsyncOperationHandle>
	|
	|-RVA: 0x1E3EC30 Offset: 0x1E3ED31 VA: 0x1E3EC30
	|-Array.InternalArray__IReadOnlyList_get_Item<AsyncUnit>
	|
	|-RVA: 0x1E3ECE0 Offset: 0x1E3EDE1 VA: 0x1E3ECE0
	|-Array.InternalArray__IReadOnlyList_get_Item<BatchVisibility>
	|
	|-RVA: 0x1E3ED90 Offset: 0x1E3EE91 VA: 0x1E3ED90
	|-Array.InternalArray__IReadOnlyList_get_Item<BoneWeight>
	|
	|-RVA: 0x1E3EE50 Offset: 0x1E3EF51 VA: 0x1E3EE50
	|-Array.InternalArray__IReadOnlyList_get_Item<BoneWeight1>
	|
	|-RVA: 0x1E3EF00 Offset: 0x1E3F001 VA: 0x1E3EF00
	|-Array.InternalArray__IReadOnlyList_get_Item<bool>
	|
	|-RVA: 0x1E3EFB0 Offset: 0x1E3F0B1 VA: 0x1E3EFB0
	|-Array.InternalArray__IReadOnlyList_get_Item<Bounds>
	|
	|-RVA: 0x1E3F070 Offset: 0x1E3F171 VA: 0x1E3F070
	|-Array.InternalArray__IReadOnlyList_get_Item<byte>
	|
	|-RVA: 0x1E3F120 Offset: 0x1E3F221 VA: 0x1E3F120
	|-Array.InternalArray__IReadOnlyList_get_Item<ByteEnum>
	|
	|-RVA: 0x1E3F1D0 Offset: 0x1E3F2D1 VA: 0x1E3F1D0
	|-Array.InternalArray__IReadOnlyList_get_Item<CameraInfo>
	|
	|-RVA: 0x1E3F280 Offset: 0x1E3F381 VA: 0x1E3F280
	|-Array.InternalArray__IReadOnlyList_get_Item<CancellationToken>
	|
	|-RVA: 0x1E3F330 Offset: 0x1E3F431 VA: 0x1E3F330
	|-Array.InternalArray__IReadOnlyList_get_Item<CancellationTokenRegistration>
	|
	|-RVA: 0x1E3F3F0 Offset: 0x1E3F4F1 VA: 0x1E3F3F0
	|-Array.InternalArray__IReadOnlyList_get_Item<char>
	|
	|-RVA: 0x1E3F4A0 Offset: 0x1E3F5A1 VA: 0x1E3F4A0
	|-Array.InternalArray__IReadOnlyList_get_Item<ClusteringData>
	|
	|-RVA: 0x1E3F560 Offset: 0x1E3F661 VA: 0x1E3F560
	|-Array.InternalArray__IReadOnlyList_get_Item<ClusteringProcessorState>
	|
	|-RVA: 0x1E3F630 Offset: 0x1E3F731 VA: 0x1E3F630
	|-Array.InternalArray__IReadOnlyList_get_Item<Color>
	|
	|-RVA: 0x1E3F6E0 Offset: 0x1E3F7E1 VA: 0x1E3F6E0
	|-Array.InternalArray__IReadOnlyList_get_Item<Color32>
	|
	|-RVA: 0x1E3F790 Offset: 0x1E3F891 VA: 0x1E3F790
	|-Array.InternalArray__IReadOnlyList_get_Item<Color4u8>
	|
	|-RVA: 0x1E3F840 Offset: 0x1E3F941 VA: 0x1E3F840
	|-Array.InternalArray__IReadOnlyList_get_Item<ColorBlock>
	|
	|-RVA: 0x1E3F930 Offset: 0x1E3FA31 VA: 0x1E3F930
	|-Array.InternalArray__IReadOnlyList_get_Item<CombineInstance>
	|
	|-RVA: 0x1E3FA30 Offset: 0x1E3FB31 VA: 0x1E3FA30
	|-Array.InternalArray__IReadOnlyList_get_Item<ConstraintSource>
	|
	|-RVA: 0x1E3FAE0 Offset: 0x1E3FBE1 VA: 0x1E3FAE0
	|-Array.InternalArray__IReadOnlyList_get_Item<ContactPoint>
	|
	|-RVA: 0x1E3FBB0 Offset: 0x1E3FCB1 VA: 0x1E3FBB0
	|-Array.InternalArray__IReadOnlyList_get_Item<ContactPoint2D>
	|
	|-RVA: 0x1E3FC90 Offset: 0x1E3FD91 VA: 0x1E3FC90
	|-Array.InternalArray__IReadOnlyList_get_Item<ContourVertex>
	|
	|-RVA: 0x1E3FD50 Offset: 0x1E3FE51 VA: 0x1E3FD50
	|-Array.InternalArray__IReadOnlyList_get_Item<CustomAttributeNamedArgument>
	|
	|-RVA: 0x1E3FE10 Offset: 0x1E3FF11 VA: 0x1E3FE10
	|-Array.InternalArray__IReadOnlyList_get_Item<CustomAttributeTypedArgument>
	|
	|-RVA: 0x1E3FEC0 Offset: 0x1E3FFC1 VA: 0x1E3FEC0
	|-Array.InternalArray__IReadOnlyList_get_Item<DataStoreRatingInfo>
	|
	|-RVA: 0x1E3FF80 Offset: 0x1E40081 VA: 0x1E3FF80
	|-Array.InternalArray__IReadOnlyList_get_Item<DataStoreResult>
	|
	|-RVA: 0x1E40030 Offset: 0x1E40131 VA: 0x1E40030
	|-Array.InternalArray__IReadOnlyList_get_Item<DateTime>
	|
	|-RVA: 0x1E400E0 Offset: 0x1E401E1 VA: 0x1E400E0
	|-Array.InternalArray__IReadOnlyList_get_Item<DateTimeOffset>
	|
	|-RVA: 0x1E40190 Offset: 0x1E40291 VA: 0x1E40190
	|-Array.InternalArray__IReadOnlyList_get_Item<DebugPadState>
	|
	|-RVA: 0x1E40250 Offset: 0x1E40351 VA: 0x1E40250
	|-Array.InternalArray__IReadOnlyList_get_Item<Decimal>
	|
	|-RVA: 0x1E40300 Offset: 0x1E40401 VA: 0x1E40300
	|-Array.InternalArray__IReadOnlyList_get_Item<DeferredTiler>
	|
	|-RVA: 0x1E40410 Offset: 0x1E40511 VA: 0x1E40410
	|-Array.InternalArray__IReadOnlyList_get_Item<DeviceHandle>
	|
	|-RVA: 0x1E404C0 Offset: 0x1E405C1 VA: 0x1E404C0
	|-Array.InternalArray__IReadOnlyList_get_Item<DiagnosticEvent>
	|
	|-RVA: 0x1E40590 Offset: 0x1E40691 VA: 0x1E40590
	|-Array.InternalArray__IReadOnlyList_get_Item<DictionaryEntry>
	|
	|-RVA: 0x1E40640 Offset: 0x1E40741 VA: 0x1E40640
	|-Array.InternalArray__IReadOnlyList_get_Item<DictionaryInfo>
	|
	|-RVA: 0x1E406F0 Offset: 0x1E407F1 VA: 0x1E406F0
	|-Array.InternalArray__IReadOnlyList_get_Item<DirectoryEntry>
	|
	|-RVA: 0x1E407B0 Offset: 0x1E408B1 VA: 0x1E407B0
	|-Array.InternalArray__IReadOnlyList_get_Item<double>
	|
	|-RVA: 0x1E40860 Offset: 0x1E40961 VA: 0x1E40860
	|-Array.InternalArray__IReadOnlyList_get_Item<Ephemeron>
	|
	|-RVA: 0x1E40910 Offset: 0x1E40A11 VA: 0x1E40910
	|-Array.InternalArray__IReadOnlyList_get_Item<FXZ>
	|
	|-RVA: 0x1E409C0 Offset: 0x1E40AC1 VA: 0x1E409C0
	|-Array.InternalArray__IReadOnlyList_get_Item<Finger>
	|
	|-RVA: 0x1E40A90 Offset: 0x1E40B91 VA: 0x1E40A90
	|-Array.InternalArray__IReadOnlyList_get_Item<Float2>
	|
	|-RVA: 0x1E40B40 Offset: 0x1E40C41 VA: 0x1E40B40
	|-Array.InternalArray__IReadOnlyList_get_Item<Friend>
	|
	|-RVA: 0x1E40C10 Offset: 0x1E40D11 VA: 0x1E40C10
	|-Array.InternalArray__IReadOnlyList_get_Item<GCHandle>
	|
	|-RVA: 0x1E40CC0 Offset: 0x1E40DC1 VA: 0x1E40CC0
	|-Array.InternalArray__IReadOnlyList_get_Item<GesturePoint>
	|
	|-RVA: 0x1E40D70 Offset: 0x1E40E71 VA: 0x1E40D70
	|-Array.InternalArray__IReadOnlyList_get_Item<GestureState>
	|
	|-RVA: 0x1E40E60 Offset: 0x1E40F61 VA: 0x1E40E60
	|-Array.InternalArray__IReadOnlyList_get_Item<GlyphMarshallingStruct>
	|
	|-RVA: 0x1E40F30 Offset: 0x1E41031 VA: 0x1E40F30
	|-Array.InternalArray__IReadOnlyList_get_Item<GlyphPairAdjustmentRecord>
	|
	|-RVA: 0x1E41010 Offset: 0x1E41111 VA: 0x1E41010
	|-Array.InternalArray__IReadOnlyList_get_Item<GlyphRect>
	|
	|-RVA: 0x1E410C0 Offset: 0x1E411C1 VA: 0x1E410C0
	|-Array.InternalArray__IReadOnlyList_get_Item<Guid>
	|
	|-RVA: 0x1E41170 Offset: 0x1E41271 VA: 0x1E41170
	|-Array.InternalArray__IReadOnlyList_get_Item<Hand>
	|
	|-RVA: 0x1E41240 Offset: 0x1E41341 VA: 0x1E41240
	|-Array.InternalArray__IReadOnlyList_get_Item<HandAnalysisImageState>
	|
	|-RVA: 0x1E412F0 Offset: 0x1E413F1 VA: 0x1E412F0
	|-Array.InternalArray__IReadOnlyList_get_Item<HandAnalysisSilhouetteState>
	|
	|-RVA: 0x1E413C0 Offset: 0x1E414C1 VA: 0x1E413C0
	|-Array.InternalArray__IReadOnlyList_get_Item<HeaderVariantInfo>
	|
	|-RVA: 0x1E41470 Offset: 0x1E41571 VA: 0x1E41470
	|-Array.InternalArray__IReadOnlyList_get_Item<HighlightState>
	|
	|-RVA: 0x1E41530 Offset: 0x1E41631 VA: 0x1E41530
	|-Array.InternalArray__IReadOnlyList_get_Item<HumanBone>
	|
	|-RVA: 0x1E41610 Offset: 0x1E41711 VA: 0x1E41610
	|-Array.InternalArray__IReadOnlyList_get_Item<short>
	|
	|-RVA: 0x1E416C0 Offset: 0x1E417C1 VA: 0x1E416C0
	|-Array.InternalArray__IReadOnlyList_get_Item<int>
	|
	|-RVA: 0x1E41770 Offset: 0x1E41871 VA: 0x1E41770
	|-Array.InternalArray__IReadOnlyList_get_Item<Int32Enum>
	|
	|-RVA: 0x1E41820 Offset: 0x1E41921 VA: 0x1E41820
	|-Array.InternalArray__IReadOnlyList_get_Item<long>
	|
	|-RVA: 0x1E418D0 Offset: 0x1E419D1 VA: 0x1E418D0
	|-Array.InternalArray__IReadOnlyList_get_Item<Int64Enum>
	|
	|-RVA: 0x1E41980 Offset: 0x1E41A81 VA: 0x1E41980
	|-Array.InternalArray__IReadOnlyList_get_Item<IntPtr>
	|
	|-RVA: 0x1E41A30 Offset: 0x1E41B31 VA: 0x1E41A30
	|-Array.InternalArray__IReadOnlyList_get_Item<InternalCodePageDataItem>
	|
	|-RVA: 0x1E41AE0 Offset: 0x1E41BE1 VA: 0x1E41AE0
	|-Array.InternalArray__IReadOnlyList_get_Item<InternalEncodingDataItem>
	|
	|-RVA: 0x1E41B90 Offset: 0x1E41C91 VA: 0x1E41B90
	|-Array.InternalArray__IReadOnlyList_get_Item<InterpretedFrameInfo>
	|
	|-RVA: 0x1E41C40 Offset: 0x1E41D41 VA: 0x1E41C40
	|-Array.InternalArray__IReadOnlyList_get_Item<IntervalTreeNode>
	|
	|-RVA: 0x1E41D00 Offset: 0x1E41E01 VA: 0x1E41D00
	|-Array.InternalArray__IReadOnlyList_get_Item<JobHandle>
	|
	|-RVA: 0x1E41DB0 Offset: 0x1E41EB1 VA: 0x1E41DB0
	|-Array.InternalArray__IReadOnlyList_get_Item<Keyframe>
	|
	|-RVA: 0x1E41E80 Offset: 0x1E41F81 VA: 0x1E41E80
	|-Array.InternalArray__IReadOnlyList_get_Item<LOD>
	|
	|-RVA: 0x1E41F30 Offset: 0x1E42031 VA: 0x1E41F30
	|-Array.InternalArray__IReadOnlyList_get_Item<LayerMask>
	|
	|-RVA: 0x1E41FE0 Offset: 0x1E420E1 VA: 0x1E41FE0
	|-Array.InternalArray__IReadOnlyList_get_Item<LengthLimitProperties>
	|
	|-RVA: 0x1E42090 Offset: 0x1E42191 VA: 0x1E42090
	|-Array.InternalArray__IReadOnlyList_get_Item<Light2DBlendStyle>
	|
	|-RVA: 0x1E42180 Offset: 0x1E42281 VA: 0x1E42180
	|-Array.InternalArray__IReadOnlyList_get_Item<LightDataGI>
	|
	|-RVA: 0x1E42270 Offset: 0x1E42371 VA: 0x1E42270
	|-Array.InternalArray__IReadOnlyList_get_Item<LocalDefinition>
	|
	|-RVA: 0x1E42320 Offset: 0x1E42421 VA: 0x1E42320
	|-Array.InternalArray__IReadOnlyList_get_Item<MapPos>
	|
	|-RVA: 0x1E423D0 Offset: 0x1E424D1 VA: 0x1E423D0
	|-Array.InternalArray__IReadOnlyList_get_Item<MapRange>
	|
	|-RVA: 0x1E42480 Offset: 0x1E42581 VA: 0x1E42480
	|-Array.InternalArray__IReadOnlyList_get_Item<MaterialReference>
	|
	|-RVA: 0x1E42560 Offset: 0x1E42661 VA: 0x1E42560
	|-Array.InternalArray__IReadOnlyList_get_Item<Matrix4x4>
	|
	|-RVA: 0x1E42640 Offset: 0x1E42741 VA: 0x1E42640
	|-Array.InternalArray__IReadOnlyList_get_Item<MomentProcessorState>
	|
	|-RVA: 0x1E42710 Offset: 0x1E42811 VA: 0x1E42710
	|-Array.InternalArray__IReadOnlyList_get_Item<MomentStatistic>
	|
	|-RVA: 0x1E427C0 Offset: 0x1E428C1 VA: 0x1E427C0
	|-Array.InternalArray__IReadOnlyList_get_Item<Navigation>
	|
	|-RVA: 0x1E42890 Offset: 0x1E42991 VA: 0x1E42890
	|-Array.InternalArray__IReadOnlyList_get_Item<NetworkServiceAccountId>
	|
	|-RVA: 0x1E42940 Offset: 0x1E42A41 VA: 0x1E42940
	|-Array.InternalArray__IReadOnlyList_get_Item<NpadFullKeyState>
	|
	|-RVA: 0x1E42A10 Offset: 0x1E42B11 VA: 0x1E42A10
	|-Array.InternalArray__IReadOnlyList_get_Item<NpadHandheldState>
	|
	|-RVA: 0x1E42AE0 Offset: 0x1E42BE1 VA: 0x1E42AE0
	|-Array.InternalArray__IReadOnlyList_get_Item<NpadJoyDualState>
	|
	|-RVA: 0x1E42BB0 Offset: 0x1E42CB1 VA: 0x1E42BB0
	|-Array.InternalArray__IReadOnlyList_get_Item<NpadJoyLeftState>
	|
	|-RVA: 0x1E42C80 Offset: 0x1E42D81 VA: 0x1E42C80
	|-Array.InternalArray__IReadOnlyList_get_Item<NpadJoyRightState>
	|
	|-RVA: 0x1E42D50 Offset: 0x1E42E51 VA: 0x1E42D50
	|-Array.InternalArray__IReadOnlyList_get_Item<NpadStateArrayItem>
	|
	|-RVA: 0x1E42E20 Offset: 0x1E42F21 VA: 0x1E42E20
	|-Array.InternalArray__IReadOnlyList_get_Item<NsUid>
	|
	|-RVA: 0x1E42ED0 Offset: 0x1E42FD1 VA: 0x1E42ED0
	|-Array.InternalArray__IReadOnlyList_get_Item<object>
	|
	|-RVA: 0x1E42F80 Offset: 0x1E43081 VA: 0x1E42F80
	|-Array.InternalArray__IReadOnlyList_get_Item<ObjectInitializationData>
	|
	|-RVA: 0x1E43050 Offset: 0x1E43151 VA: 0x1E43050
	|-Array.InternalArray__IReadOnlyList_get_Item<ParameterModifier>
	|
	|-RVA: 0x1E43100 Offset: 0x1E43201 VA: 0x1E43100
	|-Array.InternalArray__IReadOnlyList_get_Item<Plane>
	|
	|-RVA: 0x1E431B0 Offset: 0x1E432B1 VA: 0x1E431B0
	|-Array.InternalArray__IReadOnlyList_get_Item<Playable>
	|
	|-RVA: 0x1E43260 Offset: 0x1E43361 VA: 0x1E43260
	|-Array.InternalArray__IReadOnlyList_get_Item<PlayableBinding>
	|
	|-RVA: 0x1E43320 Offset: 0x1E43421 VA: 0x1E43320
	|-Array.InternalArray__IReadOnlyList_get_Item<PlayerLoopSystem>
	|
	|-RVA: 0x1E433F0 Offset: 0x1E434F1 VA: 0x1E433F0
	|-Array.InternalArray__IReadOnlyList_get_Item<PlayerLoopSystemInternal>
	|
	|-RVA: 0x1E434C0 Offset: 0x1E435C1 VA: 0x1E434C0
	|-Array.InternalArray__IReadOnlyList_get_Item<PreTile>
	|
	|-RVA: 0x1E435A0 Offset: 0x1E436A1 VA: 0x1E435A0
	|-Array.InternalArray__IReadOnlyList_get_Item<Profile>
	|
	|-RVA: 0x1E436A0 Offset: 0x1E437A1 VA: 0x1E436A0
	|-Array.InternalArray__IReadOnlyList_get_Item<Protrusion>
	|
	|-RVA: 0x1E43750 Offset: 0x1E43851 VA: 0x1E43750
	|-Array.InternalArray__IReadOnlyList_get_Item<Quaternion>
	|
	|-RVA: 0x1E43800 Offset: 0x1E43901 VA: 0x1E43800
	|-Array.InternalArray__IReadOnlyList_get_Item<RandomSeed>
	|
	|-RVA: 0x1E438B0 Offset: 0x1E439B1 VA: 0x1E438B0
	|-Array.InternalArray__IReadOnlyList_get_Item<RangePositionInfo>
	|
	|-RVA: 0x1E43960 Offset: 0x1E43A61 VA: 0x1E43960
	|-Array.InternalArray__IReadOnlyList_get_Item<Ranking2ChartInfoInput>
	|
	|-RVA: 0x1E43A10 Offset: 0x1E43B11 VA: 0x1E43A10
	|-Array.InternalArray__IReadOnlyList_get_Item<RaycastHit>
	|
	|-RVA: 0x1E43AF0 Offset: 0x1E43BF1 VA: 0x1E43AF0
	|-Array.InternalArray__IReadOnlyList_get_Item<RaycastHit2D>
	|
	|-RVA: 0x1E43BC0 Offset: 0x1E43CC1 VA: 0x1E43BC0
	|-Array.InternalArray__IReadOnlyList_get_Item<RaycastResult>
	|
	|-RVA: 0x1E43CB0 Offset: 0x1E43DB1 VA: 0x1E43CB0
	|-Array.InternalArray__IReadOnlyList_get_Item<Rect>
	|
	|-RVA: 0x1E43D60 Offset: 0x1E43E61 VA: 0x1E43D60
	|-Array.InternalArray__IReadOnlyList_get_Item<RenderBuffer>
	|
	|-RVA: 0x1E43E10 Offset: 0x1E43F11 VA: 0x1E43E10
	|-Array.InternalArray__IReadOnlyList_get_Item<RenderStateBlock>
	|
	|-RVA: 0x1E43F20 Offset: 0x1E44021 VA: 0x1E43F20
	|-Array.InternalArray__IReadOnlyList_get_Item<RenderTargetHandle>
	|
	|-RVA: 0x1E43FF0 Offset: 0x1E440F1 VA: 0x1E43FF0
	|-Array.InternalArray__IReadOnlyList_get_Item<RenderTargetIdentifier>
	|
	|-RVA: 0x1E440C0 Offset: 0x1E441C1 VA: 0x1E440C0
	|-Array.InternalArray__IReadOnlyList_get_Item<RendererListHandle>
	|
	|-RVA: 0x1E44170 Offset: 0x1E44271 VA: 0x1E44170
	|-Array.InternalArray__IReadOnlyList_get_Item<ResourceHandle>
	|
	|-RVA: 0x1E44220 Offset: 0x1E44321 VA: 0x1E44220
	|-Array.InternalArray__IReadOnlyList_get_Item<ResourceLocator>
	|
	|-RVA: 0x1E442D0 Offset: 0x1E443D1 VA: 0x1E442D0
	|-Array.InternalArray__IReadOnlyList_get_Item<RichTextTagAttribute>
	|
	|-RVA: 0x1E44390 Offset: 0x1E44491 VA: 0x1E44390
	|-Array.InternalArray__IReadOnlyList_get_Item<RuntimeLabel>
	|
	|-RVA: 0x1E44440 Offset: 0x1E44541 VA: 0x1E44440
	|-Array.InternalArray__IReadOnlyList_get_Item<sbyte>
	|
	|-RVA: 0x1E444F0 Offset: 0x1E445F1 VA: 0x1E444F0
	|-Array.InternalArray__IReadOnlyList_get_Item<SerializedType>
	|
	|-RVA: 0x1E445B0 Offset: 0x1E446B1 VA: 0x1E445B0
	|-Array.InternalArray__IReadOnlyList_get_Item<ShaderKeyword>
	|
	|-RVA: 0x1E44660 Offset: 0x1E44761 VA: 0x1E44660
	|-Array.InternalArray__IReadOnlyList_get_Item<ShaderTagId>
	|
	|-RVA: 0x1E44710 Offset: 0x1E44811 VA: 0x1E44710
	|-Array.InternalArray__IReadOnlyList_get_Item<ShadowSliceData>
	|
	|-RVA: 0x1E44800 Offset: 0x1E44901 VA: 0x1E44800
	|-Array.InternalArray__IReadOnlyList_get_Item<Shape>
	|
	|-RVA: 0x1E448C0 Offset: 0x1E449C1 VA: 0x1E448C0
	|-Array.InternalArray__IReadOnlyList_get_Item<float>
	|
	|-RVA: 0x1E44970 Offset: 0x1E44A71 VA: 0x1E44970
	|-Array.InternalArray__IReadOnlyList_get_Item<SixAxisSensorHandle>
	|
	|-RVA: 0x1E44A20 Offset: 0x1E44B21 VA: 0x1E44A20
	|-Array.InternalArray__IReadOnlyList_get_Item<SixAxisSensorState>
	|
	|-RVA: 0x1E44B10 Offset: 0x1E44C11 VA: 0x1E44B10
	|-Array.InternalArray__IReadOnlyList_get_Item<SkeletonBone>
	|
	|-RVA: 0x1E44BF0 Offset: 0x1E44CF1 VA: 0x1E44BF0
	|-Array.InternalArray__IReadOnlyList_get_Item<SortingLayer>
	|
	|-RVA: 0x1E44CA0 Offset: 0x1E44DA1 VA: 0x1E44CA0
	|-Array.InternalArray__IReadOnlyList_get_Item<SphericalHarmonicsL2>
	|
	|-RVA: 0x1E44DB0 Offset: 0x1E44EB1 VA: 0x1E44DB0
	|-Array.InternalArray__IReadOnlyList_get_Item<SpinLock>
	|
	|-RVA: 0x1E44E60 Offset: 0x1E44F61 VA: 0x1E44E60
	|-Array.InternalArray__IReadOnlyList_get_Item<SpringBoneComponents>
	|
	|-RVA: 0x1E44F50 Offset: 0x1E45051 VA: 0x1E44F50
	|-Array.InternalArray__IReadOnlyList_get_Item<SpringBoneProperties>
	|
	|-RVA: 0x1E45040 Offset: 0x1E45141 VA: 0x1E45040
	|-Array.InternalArray__IReadOnlyList_get_Item<SpringColliderComponents>
	|
	|-RVA: 0x1E45150 Offset: 0x1E45251 VA: 0x1E45150
	|-Array.InternalArray__IReadOnlyList_get_Item<SpringColliderProperties>
	|
	|-RVA: 0x1E45200 Offset: 0x1E45301 VA: 0x1E45200
	|-Array.InternalArray__IReadOnlyList_get_Item<SpringForceComponent>
	|
	|-RVA: 0x1E452E0 Offset: 0x1E453E1 VA: 0x1E452E0
	|-Array.InternalArray__IReadOnlyList_get_Item<SpringJobElement>
	|
	|-RVA: 0x1E453D0 Offset: 0x1E454D1 VA: 0x1E453D0
	|-Array.InternalArray__IReadOnlyList_get_Item<SpriteState>
	|
	|-RVA: 0x1E45490 Offset: 0x1E45591 VA: 0x1E45490
	|-Array.InternalArray__IReadOnlyList_get_Item<SubMeshDescriptor>
	|
	|-RVA: 0x1E45560 Offset: 0x1E45661 VA: 0x1E45560
	|-Array.InternalArray__IReadOnlyList_get_Item<TMP_CharacterInfo>
	|
	|-RVA: 0x1E45630 Offset: 0x1E45731 VA: 0x1E45630
	|-Array.InternalArray__IReadOnlyList_get_Item<TMP_FontWeightPair>
	|
	|-RVA: 0x1E456E0 Offset: 0x1E457E1 VA: 0x1E456E0
	|-Array.InternalArray__IReadOnlyList_get_Item<TMP_LineInfo>
	|
	|-RVA: 0x1E457E0 Offset: 0x1E458E1 VA: 0x1E457E0
	|-Array.InternalArray__IReadOnlyList_get_Item<TMP_LinkInfo>
	|
	|-RVA: 0x1E458B0 Offset: 0x1E459B1 VA: 0x1E458B0
	|-Array.InternalArray__IReadOnlyList_get_Item<TMP_MeshInfo>
	|
	|-RVA: 0x1E459A0 Offset: 0x1E45AA1 VA: 0x1E459A0
	|-Array.InternalArray__IReadOnlyList_get_Item<TMP_PageInfo>
	|
	|-RVA: 0x1E45A60 Offset: 0x1E45B61 VA: 0x1E45A60
	|-Array.InternalArray__IReadOnlyList_get_Item<TMP_WordInfo>
	|
	|-RVA: 0x1E45B20 Offset: 0x1E45C21 VA: 0x1E45B20
	|-Array.InternalArray__IReadOnlyList_get_Item<TablePair>
	|
	|-RVA: 0x1E45BD0 Offset: 0x1E45CD1 VA: 0x1E45BD0
	|-Array.InternalArray__IReadOnlyList_get_Item<TextureHandle>
	|
	|-RVA: 0x1E45C80 Offset: 0x1E45D81 VA: 0x1E45C80
	|-Array.InternalArray__IReadOnlyList_get_Item<TimeSpan>
	|
	|-RVA: 0x1E45D30 Offset: 0x1E45E31 VA: 0x1E45D30
	|-Array.InternalArray__IReadOnlyList_get_Item<Touch>
	|
	|-RVA: 0x1E45E20 Offset: 0x1E45F21 VA: 0x1E45E20
	|-Array.InternalArray__IReadOnlyList_get_Item<TouchScreenState1>
	|
	|-RVA: 0x1E45F00 Offset: 0x1E46001 VA: 0x1E45F00
	|-Array.InternalArray__IReadOnlyList_get_Item<TouchScreenState10>
	|
	|-RVA: 0x1E45FD0 Offset: 0x1E460D1 VA: 0x1E45FD0
	|-Array.InternalArray__IReadOnlyList_get_Item<TouchScreenState11>
	|
	|-RVA: 0x1E460A0 Offset: 0x1E461A1 VA: 0x1E460A0
	|-Array.InternalArray__IReadOnlyList_get_Item<TouchScreenState12>
	|
	|-RVA: 0x1E46170 Offset: 0x1E46271 VA: 0x1E46170
	|-Array.InternalArray__IReadOnlyList_get_Item<TouchScreenState13>
	|
	|-RVA: 0x1E46240 Offset: 0x1E46341 VA: 0x1E46240
	|-Array.InternalArray__IReadOnlyList_get_Item<TouchScreenState14>
	|
	|-RVA: 0x1E46310 Offset: 0x1E46411 VA: 0x1E46310
	|-Array.InternalArray__IReadOnlyList_get_Item<TouchScreenState15>
	|
	|-RVA: 0x1E463E0 Offset: 0x1E464E1 VA: 0x1E463E0
	|-Array.InternalArray__IReadOnlyList_get_Item<TouchScreenState16>
	|
	|-RVA: 0x1E464B0 Offset: 0x1E465B1 VA: 0x1E464B0
	|-Array.InternalArray__IReadOnlyList_get_Item<TouchScreenState2>
	|
	|-RVA: 0x1E465A0 Offset: 0x1E466A1 VA: 0x1E465A0
	|-Array.InternalArray__IReadOnlyList_get_Item<TouchScreenState3>
	|
	|-RVA: 0x1E46680 Offset: 0x1E46781 VA: 0x1E46680
	|-Array.InternalArray__IReadOnlyList_get_Item<TouchScreenState4>
	|
	|-RVA: 0x1E46770 Offset: 0x1E46871 VA: 0x1E46770
	|-Array.InternalArray__IReadOnlyList_get_Item<TouchScreenState5>
	|
	|-RVA: 0x1E46860 Offset: 0x1E46961 VA: 0x1E46860
	|-Array.InternalArray__IReadOnlyList_get_Item<TouchScreenState6>
	|
	|-RVA: 0x1E46960 Offset: 0x1E46A61 VA: 0x1E46960
	|-Array.InternalArray__IReadOnlyList_get_Item<TouchScreenState7>
	|
	|-RVA: 0x1E46A30 Offset: 0x1E46B31 VA: 0x1E46A30
	|-Array.InternalArray__IReadOnlyList_get_Item<TouchScreenState8>
	|
	|-RVA: 0x1E46B00 Offset: 0x1E46C01 VA: 0x1E46B00
	|-Array.InternalArray__IReadOnlyList_get_Item<TouchScreenState9>
	|
	|-RVA: 0x1E46BD0 Offset: 0x1E46CD1 VA: 0x1E46BD0
	|-Array.InternalArray__IReadOnlyList_get_Item<TouchState>
	|
	|-RVA: 0x1E46CA0 Offset: 0x1E46DA1 VA: 0x1E46CA0
	|-Array.InternalArray__IReadOnlyList_get_Item<TrailHand>
	|
	|-RVA: 0x1E46D60 Offset: 0x1E46E61 VA: 0x1E46D60
	|-Array.InternalArray__IReadOnlyList_get_Item<TrailVertex>
	|
	|-RVA: 0x1E46E20 Offset: 0x1E46F21 VA: 0x1E46E20
	|-Array.InternalArray__IReadOnlyList_get_Item<UICharInfo>
	|
	|-RVA: 0x1E46ED0 Offset: 0x1E46FD1 VA: 0x1E46ED0
	|-Array.InternalArray__IReadOnlyList_get_Item<UILineInfo>
	|
	|-RVA: 0x1E46F80 Offset: 0x1E47081 VA: 0x1E46F80
	|-Array.InternalArray__IReadOnlyList_get_Item<UIVertex>
	|
	|-RVA: 0x1E47090 Offset: 0x1E47191 VA: 0x1E47090
	|-Array.InternalArray__IReadOnlyList_get_Item<ushort>
	|
	|-RVA: 0x1E47140 Offset: 0x1E47241 VA: 0x1E47140
	|-Array.InternalArray__IReadOnlyList_get_Item<UInt16Enum>
	|
	|-RVA: 0x1E471F0 Offset: 0x1E472F1 VA: 0x1E471F0
	|-Array.InternalArray__IReadOnlyList_get_Item<uint>
	|
	|-RVA: 0x1E472A0 Offset: 0x1E473A1 VA: 0x1E472A0
	|-Array.InternalArray__IReadOnlyList_get_Item<UInt32Enum>
	|
	|-RVA: 0x1E47350 Offset: 0x1E47451 VA: 0x1E47350
	|-Array.InternalArray__IReadOnlyList_get_Item<ulong>
	|
	|-RVA: 0x1E47400 Offset: 0x1E47501 VA: 0x1E47400
	|-Array.InternalArray__IReadOnlyList_get_Item<Uid>
	|
	|-RVA: 0x1E474B0 Offset: 0x1E475B1 VA: 0x1E474B0
	|-Array.InternalArray__IReadOnlyList_get_Item<UniTask>
	|
	|-RVA: 0x1E47560 Offset: 0x1E47661 VA: 0x1E47560
	|-Array.InternalArray__IReadOnlyList_get_Item<Unit>
	|
	|-RVA: 0x1E47610 Offset: 0x1E47711 VA: 0x1E47610
	|-Array.InternalArray__IReadOnlyList_get_Item<UnitEnum>
	|
	|-RVA: 0x1E476C0 Offset: 0x1E477C1 VA: 0x1E476C0
	|-Array.InternalArray__IReadOnlyList_get_Item<UserWord>
	|
	|-RVA: 0x1E47770 Offset: 0x1E47871 VA: 0x1E47770
	|-Array.InternalArray__IReadOnlyList_get_Item<Vector2>
	|
	|-RVA: 0x1E47820 Offset: 0x1E47921 VA: 0x1E47820
	|-Array.InternalArray__IReadOnlyList_get_Item<Vector2Int>
	|
	|-RVA: 0x1E478D0 Offset: 0x1E479D1 VA: 0x1E478D0
	|-Array.InternalArray__IReadOnlyList_get_Item<Vector3>
	|
	|-RVA: 0x1E47980 Offset: 0x1E47A81 VA: 0x1E47980
	|-Array.InternalArray__IReadOnlyList_get_Item<Vector4>
	|
	|-RVA: 0x1E47A30 Offset: 0x1E47B31 VA: 0x1E47A30
	|-Array.InternalArray__IReadOnlyList_get_Item<VertexAttributeDescriptor>
	|
	|-RVA: 0x1E47AE0 Offset: 0x1E47BE1 VA: 0x1E47AE0
	|-Array.InternalArray__IReadOnlyList_get_Item<VibrationDeviceHandle>
	|
	|-RVA: 0x1E47B90 Offset: 0x1E47C91 VA: 0x1E47B90
	|-Array.InternalArray__IReadOnlyList_get_Item<VibrationDeviceInfo>
	|
	|-RVA: 0x1E47C40 Offset: 0x1E47D41 VA: 0x1E47C40
	|-Array.InternalArray__IReadOnlyList_get_Item<VibrationValue>
	|
	|-RVA: 0x1E47CF0 Offset: 0x1E47DF1 VA: 0x1E47CF0
	|-Array.InternalArray__IReadOnlyList_get_Item<VisibleLight>
	|
	|-RVA: 0x1E47E00 Offset: 0x1E47F01 VA: 0x1E47E00
	|-Array.InternalArray__IReadOnlyList_get_Item<WordWrapState>
	|
	|-RVA: 0x1E47ED0 Offset: 0x1E47FD1 VA: 0x1E47ED0
	|-Array.InternalArray__IReadOnlyList_get_Item<X509ChainStatus>
	|
	|-RVA: 0x1E47F80 Offset: 0x1E48081 VA: 0x1E47F80
	|-Array.InternalArray__IReadOnlyList_get_Item<XPathNode>
	|
	|-RVA: 0x1E48040 Offset: 0x1E48141 VA: 0x1E48040
	|-Array.InternalArray__IReadOnlyList_get_Item<XPathNodeRef>
	|
	|-RVA: 0x1E480F0 Offset: 0x1E481F1 VA: 0x1E480F0
	|-Array.InternalArray__IReadOnlyList_get_Item<XRView>
	|
	|-RVA: 0x1E481D0 Offset: 0x1E482D1 VA: 0x1E481D0
	|-Array.InternalArray__IReadOnlyList_get_Item<float3>
	|
	|-RVA: 0x1E48280 Offset: 0x1E48381 VA: 0x1E48280
	|-Array.InternalArray__IReadOnlyList_get_Item<float4x4>
	|
	|-RVA: 0x1E48360 Offset: 0x1E48461 VA: 0x1E48360
	|-Array.InternalArray__IReadOnlyList_get_Item<jvalue>
	|
	|-RVA: 0x1E48410 Offset: 0x1E48511 VA: 0x1E48410
	|-Array.InternalArray__IReadOnlyList_get_Item<uint4>
	|
	|-RVA: 0x1E484C0 Offset: 0x1E485C1 VA: 0x1E484C0
	|-Array.InternalArray__IReadOnlyList_get_Item<AICrossfire.PositionTable>
	|
	|-RVA: 0x1E48570 Offset: 0x1E48671 VA: 0x1E48570
	|-Array.InternalArray__IReadOnlyList_get_Item<AIEnum.SkillRangeEnemyData>
	|
	|-RVA: 0x1E48620 Offset: 0x1E48721 VA: 0x1E48620
	|-Array.InternalArray__IReadOnlyList_get_Item<AIOrder.UnitPriority>
	|
	|-RVA: 0x1E486D0 Offset: 0x1E487D1 VA: 0x1E486D0
	|-Array.InternalArray__IReadOnlyList_get_Item<AmiiboSequence.GainItemData>
	|
	|-RVA: 0x1E48780 Offset: 0x1E48881 VA: 0x1E48780
	|-Array.InternalArray__IReadOnlyList_get_Item<AnimationOutputWeightProcessor.WeightInfo>
	|
	|-RVA: 0x1E48850 Offset: 0x1E48951 VA: 0x1E48850
	|-Array.InternalArray__IReadOnlyList_get_Item<ArenaOrderSequence.GodInfo>
	|
	|-RVA: 0x1E48900 Offset: 0x1E48A01 VA: 0x1E48900
	|-Array.InternalArray__IReadOnlyList_get_Item<BattleInfo.SupportData>
	|
	|-RVA: 0x1E489B0 Offset: 0x1E48AB1 VA: 0x1E489B0
	|-Array.InternalArray__IReadOnlyList_get_Item<BeforeRenderHelper.OrderBlock>
	|
	|-RVA: 0x1E48A60 Offset: 0x1E48B61 VA: 0x1E48A60
	|-Array.InternalArray__IReadOnlyList_get_Item<Camera.RenderRequest>
	|
	|-RVA: 0x1E48B20 Offset: 0x1E48C21 VA: 0x1E48B20
	|-Array.InternalArray__IReadOnlyList_get_Item<CameraState.CustomBlendable>
	|
	|-RVA: 0x1E48BD0 Offset: 0x1E48CD1 VA: 0x1E48BD0
	|-Array.InternalArray__IReadOnlyList_get_Item<CinemachineBlendListCamera.Instruction>
	|
	|-RVA: 0x1E48C90 Offset: 0x1E48D91 VA: 0x1E48C90
	|-Array.InternalArray__IReadOnlyList_get_Item<CinemachineBlenderSettings.CustomBlend>
	|
	|-RVA: 0x1E48D50 Offset: 0x1E48E51 VA: 0x1E48D50
	|-Array.InternalArray__IReadOnlyList_get_Item<CinemachineClearShot.Pair>
	|
	|-RVA: 0x1E48E00 Offset: 0x1E48F01 VA: 0x1E48E00
	|-Array.InternalArray__IReadOnlyList_get_Item<CinemachineFreeLook.Orbit>
	|
	|-RVA: 0x1E48EB0 Offset: 0x1E48FB1 VA: 0x1E48EB0
	|-Array.InternalArray__IReadOnlyList_get_Item<CinemachinePath.Waypoint>
	|
	|-RVA: 0x1E48F80 Offset: 0x1E49081 VA: 0x1E48F80
	|-Array.InternalArray__IReadOnlyList_get_Item<CinemachineSmoothPath.Waypoint>
	|
	|-RVA: 0x1E49030 Offset: 0x1E49131 VA: 0x1E49030
	|-Array.InternalArray__IReadOnlyList_get_Item<CinemachineStateDrivenCamera.HashPair>
	|
	|-RVA: 0x1E490E0 Offset: 0x1E491E1 VA: 0x1E490E0
	|-Array.InternalArray__IReadOnlyList_get_Item<CinemachineStateDrivenCamera.Instruction>
	|
	|-RVA: 0x1E491A0 Offset: 0x1E492A1 VA: 0x1E491A0
	|-Array.InternalArray__IReadOnlyList_get_Item<CinemachineStateDrivenCamera.ParentHash>
	|
	|-RVA: 0x1E49250 Offset: 0x1E49351 VA: 0x1E49250
	|-Array.InternalArray__IReadOnlyList_get_Item<CinemachineTargetGroup.Target>
	|
	|-RVA: 0x1E49300 Offset: 0x1E49401 VA: 0x1E49300
	|-Array.InternalArray__IReadOnlyList_get_Item<CodePointIndexer.TableRange>
	|
	|-RVA: 0x1E493C0 Offset: 0x1E494C1 VA: 0x1E493C0
	|-Array.InternalArray__IReadOnlyList_get_Item<ContentCatalogData.Bucket>
	|
	|-RVA: 0x1E49470 Offset: 0x1E49571 VA: 0x1E49470
	|-Array.InternalArray__IReadOnlyList_get_Item<CookieTokenizer.RecognizedAttribute>
	|
	|-RVA: 0x1E49520 Offset: 0x1E49621 VA: 0x1E49520
	|-Array.InternalArray__IReadOnlyList_get_Item<DeferredLights.DrawCall>
	|
	|-RVA: 0x1E495F0 Offset: 0x1E496F1 VA: 0x1E495F0
	|-Array.InternalArray__IReadOnlyList_get_Item<DeferredShaderData.ComputeBufferInfo>
	|
	|-RVA: 0x1E496A0 Offset: 0x1E497A1 VA: 0x1E496A0
	|-Array.InternalArray__IReadOnlyList_get_Item<DeferredTiler.PrePunctualLight>
	|
	|-RVA: 0x1E49760 Offset: 0x1E49861 VA: 0x1E49760
	|-Array.InternalArray__IReadOnlyList_get_Item<DelayedActionManager.DelegateInfo>
	|
	|-RVA: 0x1E49820 Offset: 0x1E49921 VA: 0x1E49820
	|-Array.InternalArray__IReadOnlyList_get_Item<Detail.AsyncResultInt>
	|
	|-RVA: 0x1E498F0 Offset: 0x1E499F1 VA: 0x1E498F0
	|-Array.InternalArray__IReadOnlyList_get_Item<Detail.CppArray>
	|
	|-RVA: 0x1E499A0 Offset: 0x1E49AA1 VA: 0x1E499A0
	|-Array.InternalArray__IReadOnlyList_get_Item<Detail.NotificationEventInt>
	|
	|-RVA: 0x1E49A70 Offset: 0x1E49B71 VA: 0x1E49A70
	|-Array.InternalArray__IReadOnlyList_get_Item<DisposUnit.Item>
	|
	|-RVA: 0x1E49B20 Offset: 0x1E49C21 VA: 0x1E49B20
	|-Array.InternalArray__IReadOnlyList_get_Item<DragonRidePresetParamData.CourseData>
	|
	|-RVA: 0x1E49BD0 Offset: 0x1E49CD1 VA: 0x1E49BD0
	|-Array.InternalArray__IReadOnlyList_get_Item<DragonRideTargetGroup.ChainParam>
	|
	|-RVA: 0x1E49C80 Offset: 0x1E49D81 VA: 0x1E49C80
	|-Array.InternalArray__IReadOnlyList_get_Item<DynamicMesh.State>
	|
	|-RVA: 0x1E49D30 Offset: 0x1E49E31 VA: 0x1E49D30
	|-Array.InternalArray__IReadOnlyList_get_Item<FXZEx.HitPoint>
	|
	|-RVA: 0x1E49E00 Offset: 0x1E49F01 VA: 0x1E49E00
	|-Array.InternalArray__IReadOnlyList_get_Item<FishingRadicalParamData.RadicalParam>
	|
	|-RVA: 0x1E49EB0 Offset: 0x1E49FB1 VA: 0x1E49EB0
	|-Array.InternalArray__IReadOnlyList_get_Item<GameVariable.Value>
	|
	|-RVA: 0x1E49F60 Offset: 0x1E4A061 VA: 0x1E49F60
	|-Array.InternalArray__IReadOnlyList_get_Item<GmapPathAdjuster.TargetModel>
	|
	|-RVA: 0x1E4A020 Offset: 0x1E4A121 VA: 0x1E4A020
	|-Array.InternalArray__IReadOnlyList_get_Item<GmapSpotAdjuster.TargetModel>
	|
	|-RVA: 0x1E4A0E0 Offset: 0x1E4A1E1 VA: 0x1E4A0E0
	|-Array.InternalArray__IReadOnlyList_get_Item<GrounderQuadruped.Foot>
	|
	|-RVA: 0x1E4A1B0 Offset: 0x1E4A2B1 VA: 0x1E4A1B0
	|-Array.InternalArray__IReadOnlyList_get_Item<Hashtable.bucket>
	|
	|-RVA: 0x1E4A270 Offset: 0x1E4A371 VA: 0x1E4A270
	|-Array.InternalArray__IReadOnlyList_get_Item<HeadingTracker.Item>
	|
	|-RVA: 0x1E4A330 Offset: 0x1E4A431 VA: 0x1E4A330
	|-Array.InternalArray__IReadOnlyList_get_Item<HubAccessoryRoomCamera.BackgroundSettings>
	|
	|-RVA: 0x1E4A400 Offset: 0x1E4A501 VA: 0x1E4A400
	|-Array.InternalArray__IReadOnlyList_get_Item<HubFastTravel.Location>
	|
	|-RVA: 0x1E4A4C0 Offset: 0x1E4A5C1 VA: 0x1E4A4C0
	|-Array.InternalArray__IReadOnlyList_get_Item<HubLensFlare.Flare>
	|
	|-RVA: 0x1E4A590 Offset: 0x1E4A691 VA: 0x1E4A590
	|-Array.InternalArray__IReadOnlyList_get_Item<HubLookAtController.LookAtIKParam>
	|
	|-RVA: 0x1E4A640 Offset: 0x1E4A741 VA: 0x1E4A640
	|-Array.InternalArray__IReadOnlyList_get_Item<HubMaterialArray.MaterialInfo>
	|
	|-RVA: 0x1E4A6F0 Offset: 0x1E4A7F1 VA: 0x1E4A6F0
	|-Array.InternalArray__IReadOnlyList_get_Item<IKSolverLimb.AxisDirection>
	|
	|-RVA: 0x1E4A7C0 Offset: 0x1E4A8C1 VA: 0x1E4A7C0
	|-Array.InternalArray__IReadOnlyList_get_Item<InventoryPoolItemMenuContent.KindBgNameClass>
	|
	|-RVA: 0x1E4A870 Offset: 0x1E4A971 VA: 0x1E4A870
	|-Array.InternalArray__IReadOnlyList_get_Item<LightUtility.ParametricLightMeshVertex>
	|
	|-RVA: 0x1E4A940 Offset: 0x1E4AA41 VA: 0x1E4A940
	|-Array.InternalArray__IReadOnlyList_get_Item<LightUtility.SpriteLightMeshVertex>
	|
	|-RVA: 0x1E4AA10 Offset: 0x1E4AB11 VA: 0x1E4AA10
	|-Array.InternalArray__IReadOnlyList_get_Item<Map.Pos>
	|
	|-RVA: 0x1E4AAC0 Offset: 0x1E4ABC1 VA: 0x1E4AAC0
	|-Array.InternalArray__IReadOnlyList_get_Item<MapGodExp.KindDesc>
	|
	|-RVA: 0x1E4AB70 Offset: 0x1E4AC71 VA: 0x1E4AB70
	|-Array.InternalArray__IReadOnlyList_get_Item<MapHistory.Command>
	|
	|-RVA: 0x1E4AC20 Offset: 0x1E4AD21 VA: 0x1E4AC20
	|-Array.InternalArray__IReadOnlyList_get_Item<MapImage.BackupTerrain>
	|
	|-RVA: 0x1E4ACD0 Offset: 0x1E4ADD1 VA: 0x1E4ACD0
	|-Array.InternalArray__IReadOnlyList_get_Item<MapImageRange.Pos>
	|
	|-RVA: 0x1E4AD80 Offset: 0x1E4AE81 VA: 0x1E4AD80
	|-Array.InternalArray__IReadOnlyList_get_Item<MapKillBonus.KillBonus>
	|
	|-RVA: 0x1E4AE30 Offset: 0x1E4AF31 VA: 0x1E4AE30
	|-Array.InternalArray__IReadOnlyList_get_Item<MapKillBonus.KilledBonus>
	|
	|-RVA: 0x1E4AEE0 Offset: 0x1E4AFE1 VA: 0x1E4AEE0
	|-Array.InternalArray__IReadOnlyList_get_Item<MapMind.Record>
	|
	|-RVA: 0x1E4AFD0 Offset: 0x1E4B0D1 VA: 0x1E4AFD0
	|-Array.InternalArray__IReadOnlyList_get_Item<MapMind.Target>
	|
	|-RVA: 0x1E4B090 Offset: 0x1E4B191 VA: 0x1E4B090
	|-Array.InternalArray__IReadOnlyList_get_Item<MapPanelDebug.Entity>
	|
	|-RVA: 0x1E4B150 Offset: 0x1E4B251 VA: 0x1E4B150
	|-Array.InternalArray__IReadOnlyList_get_Item<NexRanking.Data>
	|
	|-RVA: 0x1E4B200 Offset: 0x1E4B301 VA: 0x1E4B200
	|-Array.InternalArray__IReadOnlyList_get_Item<NexVersus.RatingData>
	|
	|-RVA: 0x1E4B2B0 Offset: 0x1E4B3B1 VA: 0x1E4B2B0
	|-Array.InternalArray__IReadOnlyList_get_Item<NoiseSettings.TransformNoiseParams>
	|
	|-RVA: 0x1E4B380 Offset: 0x1E4B481 VA: 0x1E4B380
	|-Array.InternalArray__IReadOnlyList_get_Item<PackedPlayModeBuildLogs.RuntimeBuildLog>
	|
	|-RVA: 0x1E4B430 Offset: 0x1E4B531 VA: 0x1E4B430
	|-Array.InternalArray__IReadOnlyList_get_Item<ParameterizedStrings.FormatParam>
	|
	|-RVA: 0x1E4B4E0 Offset: 0x1E4B5E1 VA: 0x1E4B4E0
	|-Array.InternalArray__IReadOnlyList_get_Item<ParticleSystem.Particle>
	|
	|-RVA: 0x1E4B5C0 Offset: 0x1E4B6C1 VA: 0x1E4B5C0
	|-Array.InternalArray__IReadOnlyList_get_Item<ProfileCard.Achievement>
	|
	|-RVA: 0x1E4B670 Offset: 0x1E4B771 VA: 0x1E4B670
	|-Array.InternalArray__IReadOnlyList_get_Item<ProfileCard.SortieCount>
	|
	|-RVA: 0x1E4B730 Offset: 0x1E4B831 VA: 0x1E4B730
	|-Array.InternalArray__IReadOnlyList_get_Item<QualitySettingsStack.Settings>
	|
	|-RVA: 0x1E4B800 Offset: 0x1E4B901 VA: 0x1E4B800
	|-Array.InternalArray__IReadOnlyList_get_Item<RangeData.Offset>
	|
	|-RVA: 0x1E4B8B0 Offset: 0x1E4B9B1 VA: 0x1E4B8B0
	|-Array.InternalArray__IReadOnlyList_get_Item<RegexCharClass.LowerCaseMapping>
	|
	|-RVA: 0x1E4B960 Offset: 0x1E4BA61 VA: 0x1E4B960
	|-Array.InternalArray__IReadOnlyList_get_Item<Relay.ChooseAwardeeData>
	|
	|-RVA: 0x1E4BA20 Offset: 0x1E4BB21 VA: 0x1E4BA20
	|-Array.InternalArray__IReadOnlyList_get_Item<RelayAwardData.Info>
	|
	|-RVA: 0x1E4BAD0 Offset: 0x1E4BBD1 VA: 0x1E4BAD0
	|-Array.InternalArray__IReadOnlyList_get_Item<RenderGraph.CompiledPassInfo>
	|
	|-RVA: 0x1E4BBC0 Offset: 0x1E4BCC1 VA: 0x1E4BBC0
	|-Array.InternalArray__IReadOnlyList_get_Item<RenderGraph.CompiledResourceInfo>
	|
	|-RVA: 0x1E4BC80 Offset: 0x1E4BD81 VA: 0x1E4BC80
	|-Array.InternalArray__IReadOnlyList_get_Item<RenderGraphDebugData.PassDebugData>
	|
	|-RVA: 0x1E4BD40 Offset: 0x1E4BE41 VA: 0x1E4BD40
	|-Array.InternalArray__IReadOnlyList_get_Item<RenderGraphDebugData.ResourceDebugData>
	|
	|-RVA: 0x1E4BE10 Offset: 0x1E4BF11 VA: 0x1E4BE10
	|-Array.InternalArray__IReadOnlyList_get_Item<RenderGraphResourceRegistry.RendererListResource>
	|
	|-RVA: 0x1E4BEE0 Offset: 0x1E4BFE1 VA: 0x1E4BEE0
	|-Array.InternalArray__IReadOnlyList_get_Item<RingCleaningUnitSelectMenu.GodParam>
	|
	|-RVA: 0x1E4BF90 Offset: 0x1E4C091 VA: 0x1E4BF90
	|-Array.InternalArray__IReadOnlyList_get_Item<SampleWave.Data>
	|
	|-RVA: 0x1E4C040 Offset: 0x1E4C141 VA: 0x1E4C040
	|-Array.InternalArray__IReadOnlyList_get_Item<SampleWave.Temp>
	|
	|-RVA: 0x1E4C0F0 Offset: 0x1E4C1F1 VA: 0x1E4C0F0
	|-Array.InternalArray__IReadOnlyList_get_Item<SendMouseEvents.HitInfo>
	|
	|-RVA: 0x1E4C1A0 Offset: 0x1E4C2A1 VA: 0x1E4C1A0
	|-Array.InternalArray__IReadOnlyList_get_Item<SequenceNode.SequenceConstructPosContext>
	|
	|-RVA: 0x1E4C270 Offset: 0x1E4C371 VA: 0x1E4C270
	|-Array.InternalArray__IReadOnlyList_get_Item<ShaderInput.LightData>
	|
	|-RVA: 0x1E4C360 Offset: 0x1E4C461 VA: 0x1E4C360
	|-Array.InternalArray__IReadOnlyList_get_Item<ShaderInput.ShadowData>
	|
	|-RVA: 0x1E4C450 Offset: 0x1E4C551 VA: 0x1E4C450
	|-Array.InternalArray__IReadOnlyList_get_Item<ShadowUtility.Edge>
	|
	|-RVA: 0x1E4C520 Offset: 0x1E4C621 VA: 0x1E4C520
	|-Array.InternalArray__IReadOnlyList_get_Item<SimpleAnimationPlayable.QueuedState>
	|
	|-RVA: 0x1E4C5D0 Offset: 0x1E4C6D1 VA: 0x1E4C5D0
	|-Array.InternalArray__IReadOnlyList_get_Item<SkillArray.Entity>
	|
	|-RVA: 0x1E4C680 Offset: 0x1E4C781 VA: 0x1E4C680
	|-Array.InternalArray__IReadOnlyList_get_Item<Socket.WSABUF>
	|
	|-RVA: 0x1E4C730 Offset: 0x1E4C831 VA: 0x1E4C730
	|-Array.InternalArray__IReadOnlyList_get_Item<Stream.Info>
	|
	|-RVA: 0x1E4C7E0 Offset: 0x1E4C8E1 VA: 0x1E4C7E0
	|-Array.InternalArray__IReadOnlyList_get_Item<TMP_Text.UnicodeChar>
	|
	|-RVA: 0x39E2440 Offset: 0x39E2541 VA: 0x39E2440
	|-Array.InternalArray__IReadOnlyList_get_Item<TexturePacker_JsonArray.Frame>
	|
	|-RVA: 0x39E2520 Offset: 0x39E2621 VA: 0x39E2520
	|-Array.InternalArray__IReadOnlyList_get_Item<TimeNotificationBehaviour.NotificationEntry>
	|
	|-RVA: 0x39E25E0 Offset: 0x39E26E1 VA: 0x39E25E0
	|-Array.InternalArray__IReadOnlyList_get_Item<UnitySynchronizationContext.WorkRequest>
	|
	|-RVA: 0x39E26A0 Offset: 0x39E27A1 VA: 0x39E26A0
	|-Array.InternalArray__IReadOnlyList_get_Item<XmlNamespaceManager.NamespaceDeclaration>
	|
	|-RVA: 0x39E2760 Offset: 0x39E2861 VA: 0x39E2760
	|-Array.InternalArray__IReadOnlyList_get_Item<XmlSchemaObjectTable.XmlSchemaObjectEntry>
	|
	|-RVA: 0x39E2810 Offset: 0x39E2911 VA: 0x39E2810
	|-Array.InternalArray__IReadOnlyList_get_Item<XmlTextReaderImpl.ParsingState>
	|
	|-RVA: 0x39E2920 Offset: 0x39E2A21 VA: 0x39E2920
	|-Array.InternalArray__IReadOnlyList_get_Item<AIThink.EnchantThink.Desc>
	|
	|-RVA: 0x39E29D0 Offset: 0x39E2AD1 VA: 0x39E29D0
	|-Array.InternalArray__IReadOnlyList_get_Item<AIThink.EnchantThink.ItemInfo>
	|
	|-RVA: 0x39E2A80 Offset: 0x39E2B81 VA: 0x39E2A80
	|-Array.InternalArray__IReadOnlyList_get_Item<AIThink.EnchantThink.SurroundingInfo>
	|
	|-RVA: 0x39E2B30 Offset: 0x39E2C31 VA: 0x39E2B30
	|-Array.InternalArray__IReadOnlyList_get_Item<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>
	|
	|-RVA: 0x39E2BE0 Offset: 0x39E2CE1 VA: 0x39E2BE0
	|-Array.InternalArray__IReadOnlyList_get_Item<Detail.DataStore.DataStoreChangeMetaParamInt>
	|
	|-RVA: 0x39E2CE0 Offset: 0x39E2DE1 VA: 0x39E2CE0
	|-Array.InternalArray__IReadOnlyList_get_Item<Detail.DataStore.DataStoreDeleteParamInt>
	|
	|-RVA: 0x39E2D90 Offset: 0x39E2E91 VA: 0x39E2D90
	|-Array.InternalArray__IReadOnlyList_get_Item<Detail.DataStore.DataStoreGetMetaParamInt>
	|
	|-RVA: 0x39E2E60 Offset: 0x39E2F61 VA: 0x39E2E60
	|-Array.InternalArray__IReadOnlyList_get_Item<Detail.DataStore.DataStoreMetaInfoInt>
	|
	|-RVA: 0x39E2F50 Offset: 0x39E3051 VA: 0x39E2F50
	|-Array.InternalArray__IReadOnlyList_get_Item<Detail.DataStore.DataStorePasswordInfoInt>
	|
	|-RVA: 0x39E3010 Offset: 0x39E3111 VA: 0x39E3010
	|-Array.InternalArray__IReadOnlyList_get_Item<Detail.DataStore.DataStorePersistenceInfoInt>
	|
	|-RVA: 0x39E30D0 Offset: 0x39E31D1 VA: 0x39E30D0
	|-Array.InternalArray__IReadOnlyList_get_Item<Detail.DataStore.DataStorePreparePostParamInt>
	|
	|-RVA: 0x39E31B0 Offset: 0x39E32B1 VA: 0x39E31B0
	|-Array.InternalArray__IReadOnlyList_get_Item<Detail.DataStore.DataStoreRateObjectParamInt>
	|
	|-RVA: 0x39E3260 Offset: 0x39E3361 VA: 0x39E3260
	|-Array.InternalArray__IReadOnlyList_get_Item<Detail.DataStore.DataStoreRatingInitParamInt>
	|
	|-RVA: 0x39E3320 Offset: 0x39E3421 VA: 0x39E3320
	|-Array.InternalArray__IReadOnlyList_get_Item<Detail.DataStore.DataStoreRatingTargetInt>
	|
	|-RVA: 0x39E33D0 Offset: 0x39E34D1 VA: 0x39E33D0
	|-Array.InternalArray__IReadOnlyList_get_Item<Detail.Ranking.RankingCachedResultInt>
	|
	|-RVA: 0x39E34B0 Offset: 0x39E35B1 VA: 0x39E34B0
	|-Array.InternalArray__IReadOnlyList_get_Item<Detail.Ranking.RankingOrderParamInt>
	|
	|-RVA: 0x39E3560 Offset: 0x39E3661 VA: 0x39E3560
	|-Array.InternalArray__IReadOnlyList_get_Item<Detail.Ranking.RankingRankDataInt>
	|
	|-RVA: 0x39E3640 Offset: 0x39E3741 VA: 0x39E3640
	|-Array.InternalArray__IReadOnlyList_get_Item<Detail.Ranking2.Ranking2ChartInfoInt>
	|
	|-RVA: 0x39E3730 Offset: 0x39E3831 VA: 0x39E3730
	|-Array.InternalArray__IReadOnlyList_get_Item<Detail.Ranking2.Ranking2RankDataInt>
	|
	|-RVA: 0x39E3810 Offset: 0x39E3911 VA: 0x39E3810
	|-Array.InternalArray__IReadOnlyList_get_Item<Detail.Ranking2.Ranking2ScoreDataInt>
	|
	|-RVA: 0x39E38C0 Offset: 0x39E39C1 VA: 0x39E38C0
	|-Array.InternalArray__IReadOnlyList_get_Item<Detail.Screening.ScreeningContextInfoInt>
	|
	|-RVA: 0x39E3980 Offset: 0x39E3A81 VA: 0x39E3980
	|-Array.InternalArray__IReadOnlyList_get_Item<Detail.Subscriber.SubscriberContentInt>
	|
	|-RVA: 0x39E3A70 Offset: 0x39E3B71 VA: 0x39E3A70
	|-Array.InternalArray__IReadOnlyList_get_Item<Detail.Subscriber.SubscriberGetContentParamInt>
	|
	|-RVA: 0x39E3B30 Offset: 0x39E3C31 VA: 0x39E3B30
	|-Array.InternalArray__IReadOnlyList_get_Item<Detail.Subscriber.SubscriberUserStatusInfoInt>
	|
	|-RVA: 0x39E3C00 Offset: 0x39E3D01 VA: 0x39E3C00
	|-Array.InternalArray__IReadOnlyList_get_Item<Detail.Subscriber.SubscriberUserStatusParamInt>
	|
	|-RVA: 0x39E3CC0 Offset: 0x39E3DC1 VA: 0x39E3CC0
	|-Array.InternalArray__IReadOnlyList_get_Item<Detail.Utility.IntegerSettings>
	|
	|-RVA: 0x39E3D70 Offset: 0x39E3E71 VA: 0x39E3D70
	|-Array.InternalArray__IReadOnlyList_get_Item<Detail.Utility.UniqueIdInfoInt>
	|
	|-RVA: 0x39E3E20 Offset: 0x39E3F21 VA: 0x39E3E20
	|-Array.InternalArray__IReadOnlyList_get_Item<FacetsChecker.FacetsCompiler.Map>
	|
	|-RVA: 0x39E3ED0 Offset: 0x39E3FD1 VA: 0x39E3ED0
	|-Array.InternalArray__IReadOnlyList_get_Item<MapHistory.ReplayAppearanceMap.Appearance>
	|
	|-RVA: 0x39E3F90 Offset: 0x39E4091 VA: 0x39E3F90
	|-Array.InternalArray__IReadOnlyList_get_Item<MapHistory.ReplayAppearanceMap.Leaving>
	|
	|-RVA: 0x39E4040 Offset: 0x39E4141 VA: 0x39E4040
	|-Array.InternalArray__IReadOnlyList_get_Item<MapHistory.ReplayUnitMap.Data>
	|
	|-RVA: 0x39E40F0 Offset: 0x39E41F1 VA: 0x39E40F0
	|-Array.InternalArray__IReadOnlyList_get_Item<MapHistory.Rewind.LatestInspectorData>
	|
	|-RVA: 0x39E41A0 Offset: 0x39E42A1 VA: 0x39E41A0
	|-Array.InternalArray__IReadOnlyList_get_Item<MapHistory.Rewind.WorkTerrainData>
	|
	|-RVA: 0x39E4250 Offset: 0x39E4351 VA: 0x39E4250
	|-Array.InternalArray__IReadOnlyList_get_Item<MapHistory.RewindUnitMap.Data>
	|
	|-RVA: 0x39E4320 Offset: 0x39E4421 VA: 0x39E4320
	|-Array.InternalArray__IReadOnlyList_get_Item<MapKillBonus.Work.Pos>
	|
	|-RVA: 0x39E43D0 Offset: 0x39E44D1 VA: 0x39E43D0
	|-Array.InternalArray__IReadOnlyList_get_Item<MapSkill.AroundCalculator.Result>
	|
	|-RVA: 0x39E4480 Offset: 0x39E4581 VA: 0x39E4480
	|-Array.InternalArray__IReadOnlyList_get_Item<Nex.ApiCallChecker.Guideline>
	|
	|-RVA: 0x39E4530 Offset: 0x39E4631 VA: 0x39E4530
	|-Array.InternalArray__IReadOnlyList_get_Item<Ngc.MaskTextSequenceBase.Data>
	|
	|-RVA: 0x39E45F0 Offset: 0x39E46F1 VA: 0x39E45F0
	|-Array.InternalArray__IReadOnlyList_get_Item<TargetPositionCache.CacheCurve.Item>
	|
	|-RVA: 0x39E46C0 Offset: 0x39E47C1 VA: 0x39E46C0
	|-Array.InternalArray__IReadOnlyList_get_Item<TargetPositionCache.CacheEntry.RecordingItem>
	|
	|-RVA: 0x39E4790 Offset: 0x39E4891 VA: 0x39E4790
	|-Array.InternalArray__IReadOnlyList_get_Item<TerrainUtility.TerrainMap.TileCoord>
	*/

	// RVA: 0x35640B0 Offset: 0x35641B1 VA: 0x35640B0
	internal int InternalArray__IReadOnlyCollection_get_Count() { }

	// RVA: -1 Offset: -1
	internal void InternalArray__Insert<T>(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x217DAA0 Offset: 0x217DBA1 VA: 0x217DAA0
	|-Array.InternalArray__Insert<ArraySegment<byte>>
	|
	|-RVA: 0x217DB00 Offset: 0x217DC01 VA: 0x217DB00
	|-Array.InternalArray__Insert<AsyncOperationHandle<object>>
	|
	|-RVA: 0x217DB60 Offset: 0x217DC61 VA: 0x217DB60
	|-Array.InternalArray__Insert<MapDeployTemplate.Queue.Data<object>>
	|
	|-RVA: 0x217DBC0 Offset: 0x217DCC1 VA: 0x217DBC0
	|-Array.InternalArray__Insert<Nex.DataStore.ParamPool.Data<object>>
	|
	|-RVA: 0x217DC20 Offset: 0x217DD21 VA: 0x217DC20
	|-Array.InternalArray__Insert<Nex.Screening.ParamPool.Data<object>>
	|
	|-RVA: 0x217DC80 Offset: 0x217DD81 VA: 0x217DC80
	|-Array.InternalArray__Insert<IntervalTree.Entry<object>>
	|
	|-RVA: 0x217DCE0 Offset: 0x217DDE1 VA: 0x217DCE0
	|-Array.InternalArray__Insert<Dictionary.Entry<ValueTuple<object, int>, object>>
	|
	|-RVA: 0x217DD40 Offset: 0x217DE41 VA: 0x217DD40
	|-Array.InternalArray__Insert<Dictionary.Entry<byte, object>>
	|
	|-RVA: 0x217DDA0 Offset: 0x217DEA1 VA: 0x217DDA0
	|-Array.InternalArray__Insert<Dictionary.Entry<CancellationToken, object>>
	|
	|-RVA: 0x217DE00 Offset: 0x217DF01 VA: 0x217DE00
	|-Array.InternalArray__Insert<Dictionary.Entry<char, object>>
	|
	|-RVA: 0x217DE60 Offset: 0x217DF61 VA: 0x217DE60
	|-Array.InternalArray__Insert<Dictionary.Entry<Guid, object>>
	|
	|-RVA: 0x217DEC0 Offset: 0x217DFC1 VA: 0x217DEC0
	|-Array.InternalArray__Insert<Dictionary.Entry<int, bool>>
	|
	|-RVA: 0x217DF20 Offset: 0x217E021 VA: 0x217DF20
	|-Array.InternalArray__Insert<Dictionary.Entry<int, byte>>
	|
	|-RVA: 0x217DF80 Offset: 0x217E081 VA: 0x217DF80
	|-Array.InternalArray__Insert<Dictionary.Entry<int, char>>
	|
	|-RVA: 0x217DFE0 Offset: 0x217E0E1 VA: 0x217DFE0
	|-Array.InternalArray__Insert<Dictionary.Entry<int, DiagnosticEvent>>
	|
	|-RVA: 0x217E040 Offset: 0x217E141 VA: 0x217E040
	|-Array.InternalArray__Insert<Dictionary.Entry<int, int>>
	|
	|-RVA: 0x217E0A0 Offset: 0x217E1A1 VA: 0x217E0A0
	|-Array.InternalArray__Insert<Dictionary.Entry<int, Int32Enum>>
	|
	|-RVA: 0x217E100 Offset: 0x217E201 VA: 0x217E100
	|-Array.InternalArray__Insert<Dictionary.Entry<int, long>>
	|
	|-RVA: 0x217E160 Offset: 0x217E261 VA: 0x217E160
	|-Array.InternalArray__Insert<Dictionary.Entry<int, MapPos>>
	|
	|-RVA: 0x217E1C0 Offset: 0x217E2C1 VA: 0x217E1C0
	|-Array.InternalArray__Insert<Dictionary.Entry<int, object>>
	|
	|-RVA: 0x217E220 Offset: 0x217E321 VA: 0x217E220
	|-Array.InternalArray__Insert<Dictionary.Entry<int, uint>>
	|
	|-RVA: 0x217E280 Offset: 0x217E381 VA: 0x217E280
	|-Array.InternalArray__Insert<Dictionary.Entry<int, AIThink.EnchantThink.SurroundingInfo>>
	|
	|-RVA: 0x217E2E0 Offset: 0x217E3E1 VA: 0x217E2E0
	|-Array.InternalArray__Insert<Dictionary.Entry<Int32Enum, bool>>
	|
	|-RVA: 0x217E340 Offset: 0x217E441 VA: 0x217E340
	|-Array.InternalArray__Insert<Dictionary.Entry<Int32Enum, int>>
	|
	|-RVA: 0x217E3A0 Offset: 0x217E4A1 VA: 0x217E3A0
	|-Array.InternalArray__Insert<Dictionary.Entry<Int32Enum, Int32Enum>>
	|
	|-RVA: 0x217E400 Offset: 0x217E501 VA: 0x217E400
	|-Array.InternalArray__Insert<Dictionary.Entry<Int32Enum, object>>
	|
	|-RVA: 0x217E460 Offset: 0x217E561 VA: 0x217E460
	|-Array.InternalArray__Insert<Dictionary.Entry<long, object>>
	|
	|-RVA: 0x217E4C0 Offset: 0x217E5C1 VA: 0x217E4C0
	|-Array.InternalArray__Insert<Dictionary.Entry<MapPos, int>>
	|
	|-RVA: 0x217E520 Offset: 0x217E621 VA: 0x217E520
	|-Array.InternalArray__Insert<Dictionary.Entry<object, AsyncOperationHandle<object>>>
	|
	|-RVA: 0x217E580 Offset: 0x217E681 VA: 0x217E580
	|-Array.InternalArray__Insert<Dictionary.Entry<object, AsyncOperationHandle>>
	|
	|-RVA: 0x217E5E0 Offset: 0x217E6E1 VA: 0x217E5E0
	|-Array.InternalArray__Insert<Dictionary.Entry<object, bool>>
	|
	|-RVA: 0x217E640 Offset: 0x217E741 VA: 0x217E640
	|-Array.InternalArray__Insert<Dictionary.Entry<object, byte>>
	|
	|-RVA: 0x217E6A0 Offset: 0x217E7A1 VA: 0x217E6A0
	|-Array.InternalArray__Insert<Dictionary.Entry<object, int>>
	|
	|-RVA: 0x217E700 Offset: 0x217E801 VA: 0x217E700
	|-Array.InternalArray__Insert<Dictionary.Entry<object, Int32Enum>>
	|
	|-RVA: 0x217E760 Offset: 0x217E861 VA: 0x217E760
	|-Array.InternalArray__Insert<Dictionary.Entry<object, IntPtr>>
	|
	|-RVA: 0x217E7C0 Offset: 0x217E8C1 VA: 0x217E7C0
	|-Array.InternalArray__Insert<Dictionary.Entry<object, object>>
	|
	|-RVA: 0x217E820 Offset: 0x217E921 VA: 0x217E820
	|-Array.InternalArray__Insert<Dictionary.Entry<object, Playable>>
	|
	|-RVA: 0x217E880 Offset: 0x217E981 VA: 0x217E880
	|-Array.InternalArray__Insert<Dictionary.Entry<object, ResourceLocator>>
	|
	|-RVA: 0x217E8E0 Offset: 0x217E9E1 VA: 0x217E8E0
	|-Array.InternalArray__Insert<Dictionary.Entry<object, float>>
	|
	|-RVA: 0x217E940 Offset: 0x217EA41 VA: 0x217E940
	|-Array.InternalArray__Insert<Dictionary.Entry<object, ushort>>
	|
	|-RVA: 0x217E9A0 Offset: 0x217EAA1 VA: 0x217E9A0
	|-Array.InternalArray__Insert<Dictionary.Entry<object, GameVariable.Value>>
	|
	|-RVA: 0x217EA00 Offset: 0x217EB01 VA: 0x217EA00
	|-Array.InternalArray__Insert<Dictionary.Entry<sbyte, DataStoreRatingInfo>>
	|
	|-RVA: 0x217EA60 Offset: 0x217EB61 VA: 0x217EA60
	|-Array.InternalArray__Insert<Dictionary.Entry<sbyte, object>>
	|
	|-RVA: 0x217EAC0 Offset: 0x217EBC1 VA: 0x217EAC0
	|-Array.InternalArray__Insert<Dictionary.Entry<ushort, int>>
	|
	|-RVA: 0x217EB20 Offset: 0x217EC21 VA: 0x217EB20
	|-Array.InternalArray__Insert<Dictionary.Entry<uint, int>>
	|
	|-RVA: 0x217EB80 Offset: 0x217EC81 VA: 0x217EB80
	|-Array.InternalArray__Insert<Dictionary.Entry<uint, object>>
	|
	|-RVA: 0x217EBE0 Offset: 0x217ECE1 VA: 0x217EBE0
	|-Array.InternalArray__Insert<Dictionary.Entry<ulong, Friend>>
	|
	|-RVA: 0x217EC40 Offset: 0x217ED41 VA: 0x217EC40
	|-Array.InternalArray__Insert<Dictionary.Entry<ulong, Int32Enum>>
	|
	|-RVA: 0x217ECA0 Offset: 0x217EDA1 VA: 0x217ECA0
	|-Array.InternalArray__Insert<Dictionary.Entry<ulong, object>>
	|
	|-RVA: 0x217ED00 Offset: 0x217EE01 VA: 0x217ED00
	|-Array.InternalArray__Insert<Dictionary.Entry<Vector3, int>>
	|
	|-RVA: 0x217ED60 Offset: 0x217EE61 VA: 0x217ED60
	|-Array.InternalArray__Insert<Dictionary.Entry<XPathNodeRef, XPathNodeRef>>
	|
	|-RVA: 0x217EDC0 Offset: 0x217EEC1 VA: 0x217EDC0
	|-Array.InternalArray__Insert<Dictionary.Entry<TerrainUtility.TerrainMap.TileCoord, object>>
	|
	|-RVA: 0x217EE20 Offset: 0x217EF21 VA: 0x217EE20
	|-Array.InternalArray__Insert<PriorityQueue.IndexedItem<object>>
	|
	|-RVA: 0x217EE80 Offset: 0x217EF81 VA: 0x217EE80
	|-Array.InternalArray__Insert<KeyValuePair<ValueTuple<object, int>, object>>
	|
	|-RVA: 0x217EEE0 Offset: 0x217EFE1 VA: 0x217EEE0
	|-Array.InternalArray__Insert<KeyValuePair<byte, object>>
	|
	|-RVA: 0x217EF40 Offset: 0x217F041 VA: 0x217EF40
	|-Array.InternalArray__Insert<KeyValuePair<CancellationToken, object>>
	|
	|-RVA: 0x217EFA0 Offset: 0x217F0A1 VA: 0x217EFA0
	|-Array.InternalArray__Insert<KeyValuePair<char, object>>
	|
	|-RVA: 0x217F000 Offset: 0x217F101 VA: 0x217F000
	|-Array.InternalArray__Insert<KeyValuePair<DateTime, object>>
	|
	|-RVA: 0x217F060 Offset: 0x217F161 VA: 0x217F060
	|-Array.InternalArray__Insert<KeyValuePair<Guid, object>>
	|
	|-RVA: 0x217F0C0 Offset: 0x217F1C1 VA: 0x217F0C0
	|-Array.InternalArray__Insert<KeyValuePair<int, bool>>
	|
	|-RVA: 0x217F120 Offset: 0x217F221 VA: 0x217F120
	|-Array.InternalArray__Insert<KeyValuePair<int, byte>>
	|
	|-RVA: 0x217F180 Offset: 0x217F281 VA: 0x217F180
	|-Array.InternalArray__Insert<KeyValuePair<int, char>>
	|
	|-RVA: 0x217F1E0 Offset: 0x217F2E1 VA: 0x217F1E0
	|-Array.InternalArray__Insert<KeyValuePair<int, DiagnosticEvent>>
	|
	|-RVA: 0x217F240 Offset: 0x217F341 VA: 0x217F240
	|-Array.InternalArray__Insert<KeyValuePair<int, int>>
	|
	|-RVA: 0x217F2A0 Offset: 0x217F3A1 VA: 0x217F2A0
	|-Array.InternalArray__Insert<KeyValuePair<int, Int32Enum>>
	|
	|-RVA: 0x217F300 Offset: 0x217F401 VA: 0x217F300
	|-Array.InternalArray__Insert<KeyValuePair<int, long>>
	|
	|-RVA: 0x217F360 Offset: 0x217F461 VA: 0x217F360
	|-Array.InternalArray__Insert<KeyValuePair<int, MapPos>>
	|
	|-RVA: 0x217F3C0 Offset: 0x217F4C1 VA: 0x217F3C0
	|-Array.InternalArray__Insert<KeyValuePair<int, object>>
	|
	|-RVA: 0x217F420 Offset: 0x217F521 VA: 0x217F420
	|-Array.InternalArray__Insert<KeyValuePair<int, uint>>
	|
	|-RVA: 0x217F480 Offset: 0x217F581 VA: 0x217F480
	|-Array.InternalArray__Insert<KeyValuePair<int, AIThink.EnchantThink.SurroundingInfo>>
	|
	|-RVA: 0x217F4E0 Offset: 0x217F5E1 VA: 0x217F4E0
	|-Array.InternalArray__Insert<KeyValuePair<Int32Enum, bool>>
	|
	|-RVA: 0x217F540 Offset: 0x217F641 VA: 0x217F540
	|-Array.InternalArray__Insert<KeyValuePair<Int32Enum, int>>
	|
	|-RVA: 0x217F5A0 Offset: 0x217F6A1 VA: 0x217F5A0
	|-Array.InternalArray__Insert<KeyValuePair<Int32Enum, Int32Enum>>
	|
	|-RVA: 0x217F600 Offset: 0x217F701 VA: 0x217F600
	|-Array.InternalArray__Insert<KeyValuePair<Int32Enum, object>>
	|
	|-RVA: 0x217F660 Offset: 0x217F761 VA: 0x217F660
	|-Array.InternalArray__Insert<KeyValuePair<long, object>>
	|
	|-RVA: 0x217F6C0 Offset: 0x217F7C1 VA: 0x217F6C0
	|-Array.InternalArray__Insert<KeyValuePair<MapPos, int>>
	|
	|-RVA: 0x217F720 Offset: 0x217F821 VA: 0x217F720
	|-Array.InternalArray__Insert<KeyValuePair<object, AsyncOperationHandle<object>>>
	|
	|-RVA: 0x217F780 Offset: 0x217F881 VA: 0x217F780
	|-Array.InternalArray__Insert<KeyValuePair<object, ValueTuple<int, DateTime, object>>>
	|
	|-RVA: 0x217F7E0 Offset: 0x217F8E1 VA: 0x217F7E0
	|-Array.InternalArray__Insert<KeyValuePair<object, AsyncOperationHandle>>
	|
	|-RVA: 0x217F840 Offset: 0x217F941 VA: 0x217F840
	|-Array.InternalArray__Insert<KeyValuePair<object, bool>>
	|
	|-RVA: 0x217F8A0 Offset: 0x217F9A1 VA: 0x217F8A0
	|-Array.InternalArray__Insert<KeyValuePair<object, byte>>
	|
	|-RVA: 0x217F900 Offset: 0x217FA01 VA: 0x217F900
	|-Array.InternalArray__Insert<KeyValuePair<object, int>>
	|
	|-RVA: 0x217F960 Offset: 0x217FA61 VA: 0x217F960
	|-Array.InternalArray__Insert<KeyValuePair<object, Int32Enum>>
	|
	|-RVA: 0x217F9C0 Offset: 0x217FAC1 VA: 0x217F9C0
	|-Array.InternalArray__Insert<KeyValuePair<object, IntPtr>>
	|
	|-RVA: 0x217FA20 Offset: 0x217FB21 VA: 0x217FA20
	|-Array.InternalArray__Insert<KeyValuePair<object, object>>
	|
	|-RVA: 0x217FA80 Offset: 0x217FB81 VA: 0x217FA80
	|-Array.InternalArray__Insert<KeyValuePair<object, Playable>>
	|
	|-RVA: 0x217FAE0 Offset: 0x217FBE1 VA: 0x217FAE0
	|-Array.InternalArray__Insert<KeyValuePair<object, ResourceLocator>>
	|
	|-RVA: 0x217FB40 Offset: 0x217FC41 VA: 0x217FB40
	|-Array.InternalArray__Insert<KeyValuePair<object, float>>
	|
	|-RVA: 0x217FBA0 Offset: 0x217FCA1 VA: 0x217FBA0
	|-Array.InternalArray__Insert<KeyValuePair<object, ushort>>
	|
	|-RVA: 0x217FC00 Offset: 0x217FD01 VA: 0x217FC00
	|-Array.InternalArray__Insert<KeyValuePair<object, GameVariable.Value>>
	|
	|-RVA: 0x217FC60 Offset: 0x217FD61 VA: 0x217FC60
	|-Array.InternalArray__Insert<KeyValuePair<sbyte, DataStoreRatingInfo>>
	|
	|-RVA: 0x217FCC0 Offset: 0x217FDC1 VA: 0x217FCC0
	|-Array.InternalArray__Insert<KeyValuePair<sbyte, object>>
	|
	|-RVA: 0x217FD20 Offset: 0x217FE21 VA: 0x217FD20
	|-Array.InternalArray__Insert<KeyValuePair<ushort, int>>
	|
	|-RVA: 0x217FD80 Offset: 0x217FE81 VA: 0x217FD80
	|-Array.InternalArray__Insert<KeyValuePair<uint, int>>
	|
	|-RVA: 0x217FDE0 Offset: 0x217FEE1 VA: 0x217FDE0
	|-Array.InternalArray__Insert<KeyValuePair<uint, object>>
	|
	|-RVA: 0x217FE40 Offset: 0x217FF41 VA: 0x217FE40
	|-Array.InternalArray__Insert<KeyValuePair<ulong, Friend>>
	|
	|-RVA: 0x217FEA0 Offset: 0x217FFA1 VA: 0x217FEA0
	|-Array.InternalArray__Insert<KeyValuePair<ulong, Int32Enum>>
	|
	|-RVA: 0x217FF00 Offset: 0x2180001 VA: 0x217FF00
	|-Array.InternalArray__Insert<KeyValuePair<ulong, object>>
	|
	|-RVA: 0x217FF60 Offset: 0x2180061 VA: 0x217FF60
	|-Array.InternalArray__Insert<KeyValuePair<Vector3, int>>
	|
	|-RVA: 0x217FFC0 Offset: 0x21800C1 VA: 0x217FFC0
	|-Array.InternalArray__Insert<KeyValuePair<XPathNodeRef, XPathNodeRef>>
	|
	|-RVA: 0x2180020 Offset: 0x2180121 VA: 0x2180020
	|-Array.InternalArray__Insert<KeyValuePair<TerrainUtility.TerrainMap.TileCoord, object>>
	|
	|-RVA: 0x2180080 Offset: 0x2180181 VA: 0x2180080
	|-Array.InternalArray__Insert<NativeArray<PreTile>>
	|
	|-RVA: 0x21800E0 Offset: 0x21801E1 VA: 0x21800E0
	|-Array.InternalArray__Insert<CommonBattleSequence.Reliance<object>>
	|
	|-RVA: 0x2180140 Offset: 0x2180241 VA: 0x2180140
	|-Array.InternalArray__Insert<RenderGraphResourcePool.ResourceLogInfo<object>>
	|
	|-RVA: 0x21801A0 Offset: 0x21802A1 VA: 0x21801A0
	|-Array.InternalArray__Insert<HashSet.Slot<ValueTuple<object, int>>>
	|
	|-RVA: 0x2180200 Offset: 0x2180301 VA: 0x2180200
	|-Array.InternalArray__Insert<HashSet.Slot<AsyncOperationHandle>>
	|
	|-RVA: 0x2180260 Offset: 0x2180361 VA: 0x2180260
	|-Array.InternalArray__Insert<HashSet.Slot<int>>
	|
	|-RVA: 0x21802C0 Offset: 0x21803C1 VA: 0x21802C0
	|-Array.InternalArray__Insert<HashSet.Slot<Int32Enum>>
	|
	|-RVA: 0x2180320 Offset: 0x2180421 VA: 0x2180320
	|-Array.InternalArray__Insert<Set.Slot<Int32Enum>>
	|
	|-RVA: 0x2180380 Offset: 0x2180481 VA: 0x2180380
	|-Array.InternalArray__Insert<HashSet.Slot<MapPos>>
	|
	|-RVA: 0x21803E0 Offset: 0x21804E1 VA: 0x21803E0
	|-Array.InternalArray__Insert<HashSet.Slot<object>>
	|
	|-RVA: 0x2180440 Offset: 0x2180541 VA: 0x2180440
	|-Array.InternalArray__Insert<Set.Slot<object>>
	|
	|-RVA: 0x21804A0 Offset: 0x21805A1 VA: 0x21804A0
	|-Array.InternalArray__Insert<HashSet.Slot<uint>>
	|
	|-RVA: 0x2180500 Offset: 0x2180601 VA: 0x2180500
	|-Array.InternalArray__Insert<HashSet.Slot<ulong>>
	|
	|-RVA: 0x2180560 Offset: 0x2180661 VA: 0x2180560
	|-Array.InternalArray__Insert<Set.Slot<Vector3>>
	|
	|-RVA: 0x21805C0 Offset: 0x21806C1 VA: 0x21805C0
	|-Array.InternalArray__Insert<TMP_TextProcessingStack<Color32>>
	|
	|-RVA: 0x2180620 Offset: 0x2180721 VA: 0x2180620
	|-Array.InternalArray__Insert<TMP_TextProcessingStack<HighlightState>>
	|
	|-RVA: 0x2180680 Offset: 0x2180781 VA: 0x2180680
	|-Array.InternalArray__Insert<TMP_TextProcessingStack<int>>
	|
	|-RVA: 0x21806E0 Offset: 0x21807E1 VA: 0x21806E0
	|-Array.InternalArray__Insert<TMP_TextProcessingStack<Int32Enum>>
	|
	|-RVA: 0x2180740 Offset: 0x2180841 VA: 0x2180740
	|-Array.InternalArray__Insert<TMP_TextProcessingStack<MaterialReference>>
	|
	|-RVA: 0x21807A0 Offset: 0x21808A1 VA: 0x21807A0
	|-Array.InternalArray__Insert<TMP_TextProcessingStack<object>>
	|
	|-RVA: 0x2180800 Offset: 0x2180901 VA: 0x2180800
	|-Array.InternalArray__Insert<TMP_TextProcessingStack<float>>
	|
	|-RVA: 0x2180860 Offset: 0x2180961 VA: 0x2180860
	|-Array.InternalArray__Insert<TMP_TextProcessingStack<WordWrapState>>
	|
	|-RVA: 0x21808C0 Offset: 0x21809C1 VA: 0x21808C0
	|-Array.InternalArray__Insert<TimeInterval<object>>
	|
	|-RVA: 0x2180920 Offset: 0x2180A21 VA: 0x2180920
	|-Array.InternalArray__Insert<Timestamped<object>>
	|
	|-RVA: 0x2180980 Offset: 0x2180A81 VA: 0x2180980
	|-Array.InternalArray__Insert<UniTask<object>>
	|
	|-RVA: 0x21809E0 Offset: 0x2180AE1 VA: 0x21809E0
	|-Array.InternalArray__Insert<ValueTuple<ValueTuple<bool, object>>>
	|
	|-RVA: 0x2180A40 Offset: 0x2180B41 VA: 0x2180A40
	|-Array.InternalArray__Insert<ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>
	|
	|-RVA: 0x2180AA0 Offset: 0x2180BA1 VA: 0x2180AA0
	|-Array.InternalArray__Insert<ValueTuple<bool, UniTask<object>>>
	|
	|-RVA: 0x2180B00 Offset: 0x2180C01 VA: 0x2180B00
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>
	|
	|-RVA: 0x2180B60 Offset: 0x2180C61 VA: 0x2180B60
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>
	|
	|-RVA: 0x2180BC0 Offset: 0x2180CC1 VA: 0x2180BC0
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>
	|
	|-RVA: 0x2180C20 Offset: 0x2180D21 VA: 0x2180C20
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>
	|
	|-RVA: 0x2180C80 Offset: 0x2180D81 VA: 0x2180C80
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>
	|
	|-RVA: 0x2180CE0 Offset: 0x2180DE1 VA: 0x2180CE0
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>
	|
	|-RVA: 0x2180D40 Offset: 0x2180E41 VA: 0x2180D40
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>
	|
	|-RVA: 0x2180DA0 Offset: 0x2180EA1 VA: 0x2180DA0
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>
	|
	|-RVA: 0x2180E00 Offset: 0x2180F01 VA: 0x2180E00
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>
	|
	|-RVA: 0x2180E60 Offset: 0x2180F61 VA: 0x2180E60
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>
	|
	|-RVA: 0x2180EC0 Offset: 0x2180FC1 VA: 0x2180EC0
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>
	|
	|-RVA: 0x2180F20 Offset: 0x2181021 VA: 0x2180F20
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x2180F80 Offset: 0x2181081 VA: 0x2180F80
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>
	|
	|-RVA: 0x2180FE0 Offset: 0x21810E1 VA: 0x2180FE0
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>
	|
	|-RVA: 0x2181040 Offset: 0x2181141 VA: 0x2181040
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>
	|
	|-RVA: 0x21810A0 Offset: 0x21811A1 VA: 0x21810A0
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>
	|
	|-RVA: 0x2181100 Offset: 0x2181201 VA: 0x2181100
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>
	|
	|-RVA: 0x2181160 Offset: 0x2181261 VA: 0x2181160
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>
	|
	|-RVA: 0x21811C0 Offset: 0x21812C1 VA: 0x21811C0
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>
	|
	|-RVA: 0x2181220 Offset: 0x2181321 VA: 0x2181220
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>
	|
	|-RVA: 0x2181280 Offset: 0x2181381 VA: 0x2181280
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>
	|
	|-RVA: 0x21812E0 Offset: 0x21813E1 VA: 0x21812E0
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>
	|
	|-RVA: 0x2181340 Offset: 0x2181441 VA: 0x2181340
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>
	|
	|-RVA: 0x21813A0 Offset: 0x21814A1 VA: 0x21813A0
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>
	|
	|-RVA: 0x2181400 Offset: 0x2181501 VA: 0x2181400
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>
	|
	|-RVA: 0x2181460 Offset: 0x2181561 VA: 0x2181460
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>
	|
	|-RVA: 0x21814C0 Offset: 0x21815C1 VA: 0x21814C0
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>
	|
	|-RVA: 0x2181520 Offset: 0x2181621 VA: 0x2181520
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>
	|
	|-RVA: 0x2181580 Offset: 0x2181681 VA: 0x2181580
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>
	|
	|-RVA: 0x21815E0 Offset: 0x21816E1 VA: 0x21815E0
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>
	|
	|-RVA: 0x2181640 Offset: 0x2181741 VA: 0x2181640
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>
	|
	|-RVA: 0x21816A0 Offset: 0x21817A1 VA: 0x21816A0
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>
	|
	|-RVA: 0x2181700 Offset: 0x2181801 VA: 0x2181700
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>
	|
	|-RVA: 0x2181760 Offset: 0x2181861 VA: 0x2181760
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>
	|
	|-RVA: 0x21817C0 Offset: 0x21818C1 VA: 0x21817C0
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>
	|
	|-RVA: 0x2181820 Offset: 0x2181921 VA: 0x2181820
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x2181880 Offset: 0x2181981 VA: 0x2181880
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>
	|
	|-RVA: 0x21818E0 Offset: 0x21819E1 VA: 0x21818E0
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>
	|
	|-RVA: 0x2181940 Offset: 0x2181A41 VA: 0x2181940
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>
	|
	|-RVA: 0x21819A0 Offset: 0x2181AA1 VA: 0x21819A0
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>
	|
	|-RVA: 0x2181A00 Offset: 0x2181B01 VA: 0x2181A00
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>
	|
	|-RVA: 0x2181A60 Offset: 0x2181B61 VA: 0x2181A60
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>
	|
	|-RVA: 0x2181AC0 Offset: 0x2181BC1 VA: 0x2181AC0
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>
	|
	|-RVA: 0x2181B20 Offset: 0x2181C21 VA: 0x2181B20
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>
	|
	|-RVA: 0x2181B80 Offset: 0x2181C81 VA: 0x2181B80
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>
	|
	|-RVA: 0x2181BE0 Offset: 0x2181CE1 VA: 0x2181BE0
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>
	|
	|-RVA: 0x2181C40 Offset: 0x2181D41 VA: 0x2181C40
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x2181CA0 Offset: 0x2181DA1 VA: 0x2181CA0
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>
	|
	|-RVA: 0x2181D00 Offset: 0x2181E01 VA: 0x2181D00
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x2181D60 Offset: 0x2181E61 VA: 0x2181D60
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>
	|
	|-RVA: 0x2181DC0 Offset: 0x2181EC1 VA: 0x2181DC0
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x2181E20 Offset: 0x2181F21 VA: 0x2181E20
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>
	|
	|-RVA: 0x2181E80 Offset: 0x2181F81 VA: 0x2181E80
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x2181EE0 Offset: 0x2181FE1 VA: 0x2181EE0
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>
	|
	|-RVA: 0x2181F40 Offset: 0x2182041 VA: 0x2181F40
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x2181FA0 Offset: 0x21820A1 VA: 0x2181FA0
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>
	|
	|-RVA: 0x2182000 Offset: 0x2182101 VA: 0x2182000
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>
	|
	|-RVA: 0x2182060 Offset: 0x2182161 VA: 0x2182060
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>
	|
	|-RVA: 0x21820C0 Offset: 0x21821C1 VA: 0x21820C0
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>
	|
	|-RVA: 0x2182120 Offset: 0x2182221 VA: 0x2182120
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>
	|
	|-RVA: 0x2182180 Offset: 0x2182281 VA: 0x2182180
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>
	|
	|-RVA: 0x21821E0 Offset: 0x21822E1 VA: 0x21821E0
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>
	|
	|-RVA: 0x2182240 Offset: 0x2182341 VA: 0x2182240
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>
	|
	|-RVA: 0x21822A0 Offset: 0x21823A1 VA: 0x21822A0
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>
	|
	|-RVA: 0x2182300 Offset: 0x2182401 VA: 0x2182300
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x2182360 Offset: 0x2182461 VA: 0x2182360
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>
	|
	|-RVA: 0x21823C0 Offset: 0x21824C1 VA: 0x21823C0
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>
	|
	|-RVA: 0x2182420 Offset: 0x2182521 VA: 0x2182420
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>
	|
	|-RVA: 0x2182480 Offset: 0x2182581 VA: 0x2182480
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>
	|
	|-RVA: 0x21824E0 Offset: 0x21825E1 VA: 0x21824E0
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>
	|
	|-RVA: 0x2182540 Offset: 0x2182641 VA: 0x2182540
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>
	|
	|-RVA: 0x21825A0 Offset: 0x21826A1 VA: 0x21825A0
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>
	|
	|-RVA: 0x2182600 Offset: 0x2182701 VA: 0x2182600
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>
	|
	|-RVA: 0x2182660 Offset: 0x2182761 VA: 0x2182660
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>
	|
	|-RVA: 0x21826C0 Offset: 0x21827C1 VA: 0x21826C0
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>
	|
	|-RVA: 0x2182720 Offset: 0x2182821 VA: 0x2182720
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x2182780 Offset: 0x2182881 VA: 0x2182780
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>
	|
	|-RVA: 0x21827E0 Offset: 0x21828E1 VA: 0x21827E0
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x2182840 Offset: 0x2182941 VA: 0x2182840
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>
	|
	|-RVA: 0x21828A0 Offset: 0x21829A1 VA: 0x21828A0
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x2182900 Offset: 0x2182A01 VA: 0x2182900
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>
	|
	|-RVA: 0x2182960 Offset: 0x2182A61 VA: 0x2182960
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x21829C0 Offset: 0x2182AC1 VA: 0x21829C0
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>
	|
	|-RVA: 0x2182A20 Offset: 0x2182B21 VA: 0x2182A20
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x2182A80 Offset: 0x2182B81 VA: 0x2182A80
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>
	|
	|-RVA: 0x2182AE0 Offset: 0x2182BE1 VA: 0x2182AE0
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x2182B40 Offset: 0x2182C41 VA: 0x2182B40
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x2182BA0 Offset: 0x2182CA1 VA: 0x2182BA0
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>
	|
	|-RVA: 0x2182C00 Offset: 0x2182D01 VA: 0x2182C00
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, bool>>>
	|
	|-RVA: 0x2182C60 Offset: 0x2182D61 VA: 0x2182C60
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, Bounds>>>
	|
	|-RVA: 0x2182CC0 Offset: 0x2182DC1 VA: 0x2182CC0
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, byte>>>
	|
	|-RVA: 0x2182D20 Offset: 0x2182E21 VA: 0x2182D20
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, Color>>>
	|
	|-RVA: 0x2182D80 Offset: 0x2182E81 VA: 0x2182D80
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, double>>>
	|
	|-RVA: 0x2182DE0 Offset: 0x2182EE1 VA: 0x2182DE0
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, int>>>
	|
	|-RVA: 0x2182E40 Offset: 0x2182F41 VA: 0x2182E40
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, long>>>
	|
	|-RVA: 0x2182EA0 Offset: 0x2182FA1 VA: 0x2182EA0
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, object>>>
	|
	|-RVA: 0x2182F00 Offset: 0x2183001 VA: 0x2182F00
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, Quaternion>>>
	|
	|-RVA: 0x2182F60 Offset: 0x2183061 VA: 0x2182F60
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, Rect>>>
	|
	|-RVA: 0x2182FC0 Offset: 0x21830C1 VA: 0x2182FC0
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, float>>>
	|
	|-RVA: 0x2183020 Offset: 0x2183121 VA: 0x2183020
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, UniTask>>>
	|
	|-RVA: 0x2183080 Offset: 0x2183181 VA: 0x2183080
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, Unit>>>
	|
	|-RVA: 0x21830E0 Offset: 0x21831E1 VA: 0x21830E0
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, Vector2>>>
	|
	|-RVA: 0x2183140 Offset: 0x2183241 VA: 0x2183140
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, Vector3>>>
	|
	|-RVA: 0x21831A0 Offset: 0x21832A1 VA: 0x21831A0
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<bool, Vector4>>>
	|
	|-RVA: 0x2183200 Offset: 0x2183301 VA: 0x2183200
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<int, object>>>
	|
	|-RVA: 0x2183260 Offset: 0x2183361 VA: 0x2183260
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<object, object>>>
	|
	|-RVA: 0x21832C0 Offset: 0x21833C1 VA: 0x21832C0
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x2183320 Offset: 0x2183421 VA: 0x2183320
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<object, object, object>>>
	|
	|-RVA: 0x2183380 Offset: 0x2183481 VA: 0x2183380
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x21833E0 Offset: 0x21834E1 VA: 0x21833E0
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<object, object, object, object>>>
	|
	|-RVA: 0x2183440 Offset: 0x2183541 VA: 0x2183440
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x21834A0 Offset: 0x21835A1 VA: 0x21834A0
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>
	|
	|-RVA: 0x2183500 Offset: 0x2183601 VA: 0x2183500
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x2183560 Offset: 0x2183661 VA: 0x2183560
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>
	|
	|-RVA: 0x21835C0 Offset: 0x21836C1 VA: 0x21835C0
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x2183620 Offset: 0x2183721 VA: 0x2183620
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>
	|
	|-RVA: 0x2183680 Offset: 0x2183781 VA: 0x2183680
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x21836E0 Offset: 0x21837E1 VA: 0x21836E0
	|-Array.InternalArray__Insert<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x2183740 Offset: 0x2183841 VA: 0x2183740
	|-Array.InternalArray__Insert<ValueTuple<bool, AsyncUnit>>
	|
	|-RVA: 0x21837A0 Offset: 0x21838A1 VA: 0x21837A0
	|-Array.InternalArray__Insert<ValueTuple<bool, bool>>
	|
	|-RVA: 0x2183800 Offset: 0x2183901 VA: 0x2183800
	|-Array.InternalArray__Insert<ValueTuple<bool, Bounds>>
	|
	|-RVA: 0x2183860 Offset: 0x2183961 VA: 0x2183860
	|-Array.InternalArray__Insert<ValueTuple<bool, byte>>
	|
	|-RVA: 0x21838C0 Offset: 0x21839C1 VA: 0x21838C0
	|-Array.InternalArray__Insert<ValueTuple<bool, Color>>
	|
	|-RVA: 0x2183920 Offset: 0x2183A21 VA: 0x2183920
	|-Array.InternalArray__Insert<ValueTuple<bool, double>>
	|
	|-RVA: 0x2183980 Offset: 0x2183A81 VA: 0x2183980
	|-Array.InternalArray__Insert<ValueTuple<bool, int>>
	|
	|-RVA: 0x21839E0 Offset: 0x2183AE1 VA: 0x21839E0
	|-Array.InternalArray__Insert<ValueTuple<bool, long>>
	|
	|-RVA: 0x2183A40 Offset: 0x2183B41 VA: 0x2183A40
	|-Array.InternalArray__Insert<ValueTuple<bool, object>>
	|
	|-RVA: 0x2183AA0 Offset: 0x2183BA1 VA: 0x2183AA0
	|-Array.InternalArray__Insert<ValueTuple<bool, Quaternion>>
	|
	|-RVA: 0x2183B00 Offset: 0x2183C01 VA: 0x2183B00
	|-Array.InternalArray__Insert<ValueTuple<bool, Rect>>
	|
	|-RVA: 0x2183B60 Offset: 0x2183C61 VA: 0x2183B60
	|-Array.InternalArray__Insert<ValueTuple<bool, float>>
	|
	|-RVA: 0x2183BC0 Offset: 0x2183CC1 VA: 0x2183BC0
	|-Array.InternalArray__Insert<ValueTuple<bool, UniTask>>
	|
	|-RVA: 0x2183C20 Offset: 0x2183D21 VA: 0x2183C20
	|-Array.InternalArray__Insert<ValueTuple<bool, Unit>>
	|
	|-RVA: 0x2183C80 Offset: 0x2183D81 VA: 0x2183C80
	|-Array.InternalArray__Insert<ValueTuple<bool, Vector2>>
	|
	|-RVA: 0x2183CE0 Offset: 0x2183DE1 VA: 0x2183CE0
	|-Array.InternalArray__Insert<ValueTuple<bool, Vector3>>
	|
	|-RVA: 0x2183D40 Offset: 0x2183E41 VA: 0x2183D40
	|-Array.InternalArray__Insert<ValueTuple<bool, Vector4>>
	|
	|-RVA: 0x2183DA0 Offset: 0x2183EA1 VA: 0x2183DA0
	|-Array.InternalArray__Insert<ValueTuple<int, bool>>
	|
	|-RVA: 0x2183E00 Offset: 0x2183F01 VA: 0x2183E00
	|-Array.InternalArray__Insert<ValueTuple<int, Bounds>>
	|
	|-RVA: 0x2183E60 Offset: 0x2183F61 VA: 0x2183E60
	|-Array.InternalArray__Insert<ValueTuple<int, byte>>
	|
	|-RVA: 0x2183EC0 Offset: 0x2183FC1 VA: 0x2183EC0
	|-Array.InternalArray__Insert<ValueTuple<int, Color>>
	|
	|-RVA: 0x2183F20 Offset: 0x2184021 VA: 0x2183F20
	|-Array.InternalArray__Insert<ValueTuple<int, double>>
	|
	|-RVA: 0x2183F80 Offset: 0x2184081 VA: 0x2183F80
	|-Array.InternalArray__Insert<ValueTuple<int, int>>
	|
	|-RVA: 0x2183FE0 Offset: 0x21840E1 VA: 0x2183FE0
	|-Array.InternalArray__Insert<ValueTuple<int, long>>
	|
	|-RVA: 0x2184040 Offset: 0x2184141 VA: 0x2184040
	|-Array.InternalArray__Insert<ValueTuple<int, object>>
	|
	|-RVA: 0x21840A0 Offset: 0x21841A1 VA: 0x21840A0
	|-Array.InternalArray__Insert<ValueTuple<int, Quaternion>>
	|
	|-RVA: 0x2184100 Offset: 0x2184201 VA: 0x2184100
	|-Array.InternalArray__Insert<ValueTuple<int, Rect>>
	|
	|-RVA: 0x2184160 Offset: 0x2184261 VA: 0x2184160
	|-Array.InternalArray__Insert<ValueTuple<int, float>>
	|
	|-RVA: 0x21841C0 Offset: 0x21842C1 VA: 0x21841C0
	|-Array.InternalArray__Insert<ValueTuple<int, Unit>>
	|
	|-RVA: 0x2184220 Offset: 0x2184321 VA: 0x2184220
	|-Array.InternalArray__Insert<ValueTuple<int, Vector2>>
	|
	|-RVA: 0x2184280 Offset: 0x2184381 VA: 0x2184280
	|-Array.InternalArray__Insert<ValueTuple<int, Vector3>>
	|
	|-RVA: 0x21842E0 Offset: 0x21843E1 VA: 0x21842E0
	|-Array.InternalArray__Insert<ValueTuple<int, Vector4>>
	|
	|-RVA: 0x2184340 Offset: 0x2184441 VA: 0x2184340
	|-Array.InternalArray__Insert<ValueTuple<Int32Enum, int>>
	|
	|-RVA: 0x21843A0 Offset: 0x21844A1 VA: 0x21843A0
	|-Array.InternalArray__Insert<ValueTuple<object, ValueTuple<object, int>>>
	|
	|-RVA: 0x2184400 Offset: 0x2184501 VA: 0x2184400
	|-Array.InternalArray__Insert<ValueTuple<object, int>>
	|
	|-RVA: 0x2184460 Offset: 0x2184561 VA: 0x2184460
	|-Array.InternalArray__Insert<ValueTuple<object, object>>
	|
	|-RVA: 0x21844C0 Offset: 0x21845C1 VA: 0x21844C0
	|-Array.InternalArray__Insert<ValueTuple<object, float>>
	|
	|-RVA: 0x2184520 Offset: 0x2184621 VA: 0x2184520
	|-Array.InternalArray__Insert<ValueTuple<Vector3, float>>
	|
	|-RVA: 0x2184580 Offset: 0x2184681 VA: 0x2184580
	|-Array.InternalArray__Insert<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>
	|
	|-RVA: 0x21845E0 Offset: 0x21846E1 VA: 0x21845E0
	|-Array.InternalArray__Insert<ValueTuple<object, Int32Enum, int>>
	|
	|-RVA: 0x2184640 Offset: 0x2184741 VA: 0x2184640
	|-Array.InternalArray__Insert<ValueTuple<object, object, object>>
	|
	|-RVA: 0x21846A0 Offset: 0x21847A1 VA: 0x21846A0
	|-Array.InternalArray__Insert<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>
	|
	|-RVA: 0x2184700 Offset: 0x2184801 VA: 0x2184700
	|-Array.InternalArray__Insert<ValueTuple<object, int, int, int>>
	|
	|-RVA: 0x2184760 Offset: 0x2184861 VA: 0x2184760
	|-Array.InternalArray__Insert<ValueTuple<object, object, object, object>>
	|
	|-RVA: 0x21847C0 Offset: 0x21848C1 VA: 0x21847C0
	|-Array.InternalArray__Insert<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>
	|
	|-RVA: 0x2184820 Offset: 0x2184921 VA: 0x2184820
	|-Array.InternalArray__Insert<ValueTuple<object, object, object, object, object>>
	|
	|-RVA: 0x2184880 Offset: 0x2184981 VA: 0x2184880
	|-Array.InternalArray__Insert<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>
	|
	|-RVA: 0x21848E0 Offset: 0x21849E1 VA: 0x21848E0
	|-Array.InternalArray__Insert<ValueTuple<object, object, object, object, object, object>>
	|
	|-RVA: 0x2184940 Offset: 0x2184A41 VA: 0x2184940
	|-Array.InternalArray__Insert<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>
	|
	|-RVA: 0x21849A0 Offset: 0x2184AA1 VA: 0x21849A0
	|-Array.InternalArray__Insert<ValueTuple<object, object, object, object, object, object, object>>
	|
	|-RVA: 0x2184A00 Offset: 0x2184B01 VA: 0x2184A00
	|-Array.InternalArray__Insert<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>
	|
	|-RVA: 0x2184A60 Offset: 0x2184B61 VA: 0x2184A60
	|-Array.InternalArray__Insert<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x2184AC0 Offset: 0x2184BC1 VA: 0x2184AC0
	|-Array.InternalArray__Insert<AnimatorClipInfo>
	|
	|-RVA: 0x2184B20 Offset: 0x2184C21 VA: 0x2184B20
	|-Array.InternalArray__Insert<AsyncOperationHandle>
	|
	|-RVA: 0x2184B80 Offset: 0x2184C81 VA: 0x2184B80
	|-Array.InternalArray__Insert<AsyncUnit>
	|
	|-RVA: 0x2184BE0 Offset: 0x2184CE1 VA: 0x2184BE0
	|-Array.InternalArray__Insert<BatchVisibility>
	|
	|-RVA: 0x2184C40 Offset: 0x2184D41 VA: 0x2184C40
	|-Array.InternalArray__Insert<BoneWeight>
	|
	|-RVA: 0x2184CA0 Offset: 0x2184DA1 VA: 0x2184CA0
	|-Array.InternalArray__Insert<BoneWeight1>
	|
	|-RVA: 0x2184D00 Offset: 0x2184E01 VA: 0x2184D00
	|-Array.InternalArray__Insert<bool>
	|
	|-RVA: 0x2184D60 Offset: 0x2184E61 VA: 0x2184D60
	|-Array.InternalArray__Insert<Bounds>
	|
	|-RVA: 0x2184DC0 Offset: 0x2184EC1 VA: 0x2184DC0
	|-Array.InternalArray__Insert<byte>
	|
	|-RVA: 0x2184E20 Offset: 0x2184F21 VA: 0x2184E20
	|-Array.InternalArray__Insert<ByteEnum>
	|
	|-RVA: 0x2184E80 Offset: 0x2184F81 VA: 0x2184E80
	|-Array.InternalArray__Insert<CameraInfo>
	|
	|-RVA: 0x2184EE0 Offset: 0x2184FE1 VA: 0x2184EE0
	|-Array.InternalArray__Insert<CancellationToken>
	|
	|-RVA: 0x2184F40 Offset: 0x2185041 VA: 0x2184F40
	|-Array.InternalArray__Insert<CancellationTokenRegistration>
	|
	|-RVA: 0x2184FA0 Offset: 0x21850A1 VA: 0x2184FA0
	|-Array.InternalArray__Insert<char>
	|
	|-RVA: 0x2185000 Offset: 0x2185101 VA: 0x2185000
	|-Array.InternalArray__Insert<ClusteringData>
	|
	|-RVA: 0x2185060 Offset: 0x2185161 VA: 0x2185060
	|-Array.InternalArray__Insert<ClusteringProcessorState>
	|
	|-RVA: 0x21850C0 Offset: 0x21851C1 VA: 0x21850C0
	|-Array.InternalArray__Insert<Color>
	|
	|-RVA: 0x2185120 Offset: 0x2185221 VA: 0x2185120
	|-Array.InternalArray__Insert<Color32>
	|
	|-RVA: 0x2185180 Offset: 0x2185281 VA: 0x2185180
	|-Array.InternalArray__Insert<Color4u8>
	|
	|-RVA: 0x21851E0 Offset: 0x21852E1 VA: 0x21851E0
	|-Array.InternalArray__Insert<ColorBlock>
	|
	|-RVA: 0x2185240 Offset: 0x2185341 VA: 0x2185240
	|-Array.InternalArray__Insert<CombineInstance>
	|
	|-RVA: 0x21852A0 Offset: 0x21853A1 VA: 0x21852A0
	|-Array.InternalArray__Insert<ConstraintSource>
	|
	|-RVA: 0x2185300 Offset: 0x2185401 VA: 0x2185300
	|-Array.InternalArray__Insert<ContactPoint>
	|
	|-RVA: 0x2185360 Offset: 0x2185461 VA: 0x2185360
	|-Array.InternalArray__Insert<ContactPoint2D>
	|
	|-RVA: 0x21853C0 Offset: 0x21854C1 VA: 0x21853C0
	|-Array.InternalArray__Insert<ContourVertex>
	|
	|-RVA: 0x2185420 Offset: 0x2185521 VA: 0x2185420
	|-Array.InternalArray__Insert<CustomAttributeNamedArgument>
	|
	|-RVA: 0x2185480 Offset: 0x2185581 VA: 0x2185480
	|-Array.InternalArray__Insert<CustomAttributeTypedArgument>
	|
	|-RVA: 0x21854E0 Offset: 0x21855E1 VA: 0x21854E0
	|-Array.InternalArray__Insert<DataStoreRatingInfo>
	|
	|-RVA: 0x2185540 Offset: 0x2185641 VA: 0x2185540
	|-Array.InternalArray__Insert<DataStoreResult>
	|
	|-RVA: 0x21855A0 Offset: 0x21856A1 VA: 0x21855A0
	|-Array.InternalArray__Insert<DateTime>
	|
	|-RVA: 0x2185600 Offset: 0x2185701 VA: 0x2185600
	|-Array.InternalArray__Insert<DateTimeOffset>
	|
	|-RVA: 0x2185660 Offset: 0x2185761 VA: 0x2185660
	|-Array.InternalArray__Insert<DebugPadState>
	|
	|-RVA: 0x21856C0 Offset: 0x21857C1 VA: 0x21856C0
	|-Array.InternalArray__Insert<Decimal>
	|
	|-RVA: 0x2185720 Offset: 0x2185821 VA: 0x2185720
	|-Array.InternalArray__Insert<DeferredTiler>
	|
	|-RVA: 0x2185780 Offset: 0x2185881 VA: 0x2185780
	|-Array.InternalArray__Insert<DeviceHandle>
	|
	|-RVA: 0x21857E0 Offset: 0x21858E1 VA: 0x21857E0
	|-Array.InternalArray__Insert<DiagnosticEvent>
	|
	|-RVA: 0x2185840 Offset: 0x2185941 VA: 0x2185840
	|-Array.InternalArray__Insert<DictionaryEntry>
	|
	|-RVA: 0x21858A0 Offset: 0x21859A1 VA: 0x21858A0
	|-Array.InternalArray__Insert<DictionaryInfo>
	|
	|-RVA: 0x2185900 Offset: 0x2185A01 VA: 0x2185900
	|-Array.InternalArray__Insert<DirectoryEntry>
	|
	|-RVA: 0x2185960 Offset: 0x2185A61 VA: 0x2185960
	|-Array.InternalArray__Insert<double>
	|
	|-RVA: 0x21859C0 Offset: 0x2185AC1 VA: 0x21859C0
	|-Array.InternalArray__Insert<Ephemeron>
	|
	|-RVA: 0x2185A20 Offset: 0x2185B21 VA: 0x2185A20
	|-Array.InternalArray__Insert<FXZ>
	|
	|-RVA: 0x2185A80 Offset: 0x2185B81 VA: 0x2185A80
	|-Array.InternalArray__Insert<Finger>
	|
	|-RVA: 0x2185AE0 Offset: 0x2185BE1 VA: 0x2185AE0
	|-Array.InternalArray__Insert<Float2>
	|
	|-RVA: 0x2185B40 Offset: 0x2185C41 VA: 0x2185B40
	|-Array.InternalArray__Insert<Friend>
	|
	|-RVA: 0x2185BA0 Offset: 0x2185CA1 VA: 0x2185BA0
	|-Array.InternalArray__Insert<GCHandle>
	|
	|-RVA: 0x2185C00 Offset: 0x2185D01 VA: 0x2185C00
	|-Array.InternalArray__Insert<GesturePoint>
	|
	|-RVA: 0x2185C60 Offset: 0x2185D61 VA: 0x2185C60
	|-Array.InternalArray__Insert<GestureState>
	|
	|-RVA: 0x2185CC0 Offset: 0x2185DC1 VA: 0x2185CC0
	|-Array.InternalArray__Insert<GlyphMarshallingStruct>
	|
	|-RVA: 0x2185D20 Offset: 0x2185E21 VA: 0x2185D20
	|-Array.InternalArray__Insert<GlyphPairAdjustmentRecord>
	|
	|-RVA: 0x2185D80 Offset: 0x2185E81 VA: 0x2185D80
	|-Array.InternalArray__Insert<GlyphRect>
	|
	|-RVA: 0x2185DE0 Offset: 0x2185EE1 VA: 0x2185DE0
	|-Array.InternalArray__Insert<Guid>
	|
	|-RVA: 0x2185E40 Offset: 0x2185F41 VA: 0x2185E40
	|-Array.InternalArray__Insert<Hand>
	|
	|-RVA: 0x2185EA0 Offset: 0x2185FA1 VA: 0x2185EA0
	|-Array.InternalArray__Insert<HandAnalysisImageState>
	|
	|-RVA: 0x2185F00 Offset: 0x2186001 VA: 0x2185F00
	|-Array.InternalArray__Insert<HandAnalysisSilhouetteState>
	|
	|-RVA: 0x2185F60 Offset: 0x2186061 VA: 0x2185F60
	|-Array.InternalArray__Insert<HeaderVariantInfo>
	|
	|-RVA: 0x2185FC0 Offset: 0x21860C1 VA: 0x2185FC0
	|-Array.InternalArray__Insert<HighlightState>
	|
	|-RVA: 0x2186020 Offset: 0x2186121 VA: 0x2186020
	|-Array.InternalArray__Insert<HumanBone>
	|
	|-RVA: 0x2186080 Offset: 0x2186181 VA: 0x2186080
	|-Array.InternalArray__Insert<short>
	|
	|-RVA: 0x21860E0 Offset: 0x21861E1 VA: 0x21860E0
	|-Array.InternalArray__Insert<int>
	|
	|-RVA: 0x2186140 Offset: 0x2186241 VA: 0x2186140
	|-Array.InternalArray__Insert<Int32Enum>
	|
	|-RVA: 0x21861A0 Offset: 0x21862A1 VA: 0x21861A0
	|-Array.InternalArray__Insert<long>
	|
	|-RVA: 0x2186200 Offset: 0x2186301 VA: 0x2186200
	|-Array.InternalArray__Insert<Int64Enum>
	|
	|-RVA: 0x2186260 Offset: 0x2186361 VA: 0x2186260
	|-Array.InternalArray__Insert<IntPtr>
	|
	|-RVA: 0x21862C0 Offset: 0x21863C1 VA: 0x21862C0
	|-Array.InternalArray__Insert<InternalCodePageDataItem>
	|
	|-RVA: 0x2186320 Offset: 0x2186421 VA: 0x2186320
	|-Array.InternalArray__Insert<InternalEncodingDataItem>
	|
	|-RVA: 0x2186380 Offset: 0x2186481 VA: 0x2186380
	|-Array.InternalArray__Insert<InterpretedFrameInfo>
	|
	|-RVA: 0x21863E0 Offset: 0x21864E1 VA: 0x21863E0
	|-Array.InternalArray__Insert<IntervalTreeNode>
	|
	|-RVA: 0x2186440 Offset: 0x2186541 VA: 0x2186440
	|-Array.InternalArray__Insert<JobHandle>
	|
	|-RVA: 0x21864A0 Offset: 0x21865A1 VA: 0x21864A0
	|-Array.InternalArray__Insert<Keyframe>
	|
	|-RVA: 0x2186500 Offset: 0x2186601 VA: 0x2186500
	|-Array.InternalArray__Insert<LOD>
	|
	|-RVA: 0x2186560 Offset: 0x2186661 VA: 0x2186560
	|-Array.InternalArray__Insert<LayerMask>
	|
	|-RVA: 0x21865C0 Offset: 0x21866C1 VA: 0x21865C0
	|-Array.InternalArray__Insert<LengthLimitProperties>
	|
	|-RVA: 0x2186620 Offset: 0x2186721 VA: 0x2186620
	|-Array.InternalArray__Insert<Light2DBlendStyle>
	|
	|-RVA: 0x2186680 Offset: 0x2186781 VA: 0x2186680
	|-Array.InternalArray__Insert<LightDataGI>
	|
	|-RVA: 0x21866E0 Offset: 0x21867E1 VA: 0x21866E0
	|-Array.InternalArray__Insert<LocalDefinition>
	|
	|-RVA: 0x2186740 Offset: 0x2186841 VA: 0x2186740
	|-Array.InternalArray__Insert<MapPos>
	|
	|-RVA: 0x21867A0 Offset: 0x21868A1 VA: 0x21867A0
	|-Array.InternalArray__Insert<MapRange>
	|
	|-RVA: 0x2186800 Offset: 0x2186901 VA: 0x2186800
	|-Array.InternalArray__Insert<MaterialReference>
	|
	|-RVA: 0x2186860 Offset: 0x2186961 VA: 0x2186860
	|-Array.InternalArray__Insert<Matrix4x4>
	|
	|-RVA: 0x21868C0 Offset: 0x21869C1 VA: 0x21868C0
	|-Array.InternalArray__Insert<MomentProcessorState>
	|
	|-RVA: 0x2186920 Offset: 0x2186A21 VA: 0x2186920
	|-Array.InternalArray__Insert<MomentStatistic>
	|
	|-RVA: 0x2186980 Offset: 0x2186A81 VA: 0x2186980
	|-Array.InternalArray__Insert<Navigation>
	|
	|-RVA: 0x21869E0 Offset: 0x2186AE1 VA: 0x21869E0
	|-Array.InternalArray__Insert<NetworkServiceAccountId>
	|
	|-RVA: 0x2186A40 Offset: 0x2186B41 VA: 0x2186A40
	|-Array.InternalArray__Insert<NpadFullKeyState>
	|
	|-RVA: 0x2186AA0 Offset: 0x2186BA1 VA: 0x2186AA0
	|-Array.InternalArray__Insert<NpadHandheldState>
	|
	|-RVA: 0x2186B00 Offset: 0x2186C01 VA: 0x2186B00
	|-Array.InternalArray__Insert<NpadJoyDualState>
	|
	|-RVA: 0x2186B60 Offset: 0x2186C61 VA: 0x2186B60
	|-Array.InternalArray__Insert<NpadJoyLeftState>
	|
	|-RVA: 0x2186BC0 Offset: 0x2186CC1 VA: 0x2186BC0
	|-Array.InternalArray__Insert<NpadJoyRightState>
	|
	|-RVA: 0x2186C20 Offset: 0x2186D21 VA: 0x2186C20
	|-Array.InternalArray__Insert<NpadStateArrayItem>
	|
	|-RVA: 0x2186C80 Offset: 0x2186D81 VA: 0x2186C80
	|-Array.InternalArray__Insert<NsUid>
	|
	|-RVA: 0x2186CE0 Offset: 0x2186DE1 VA: 0x2186CE0
	|-Array.InternalArray__Insert<object>
	|
	|-RVA: 0x2186D40 Offset: 0x2186E41 VA: 0x2186D40
	|-Array.InternalArray__Insert<ObjectInitializationData>
	|
	|-RVA: 0x2186DA0 Offset: 0x2186EA1 VA: 0x2186DA0
	|-Array.InternalArray__Insert<ParameterModifier>
	|
	|-RVA: 0x2186E00 Offset: 0x2186F01 VA: 0x2186E00
	|-Array.InternalArray__Insert<Plane>
	|
	|-RVA: 0x2186E60 Offset: 0x2186F61 VA: 0x2186E60
	|-Array.InternalArray__Insert<Playable>
	|
	|-RVA: 0x2186EC0 Offset: 0x2186FC1 VA: 0x2186EC0
	|-Array.InternalArray__Insert<PlayableBinding>
	|
	|-RVA: 0x2186F20 Offset: 0x2187021 VA: 0x2186F20
	|-Array.InternalArray__Insert<PlayerLoopSystem>
	|
	|-RVA: 0x2186F80 Offset: 0x2187081 VA: 0x2186F80
	|-Array.InternalArray__Insert<PlayerLoopSystemInternal>
	|
	|-RVA: 0x2186FE0 Offset: 0x21870E1 VA: 0x2186FE0
	|-Array.InternalArray__Insert<PreTile>
	|
	|-RVA: 0x2187040 Offset: 0x2187141 VA: 0x2187040
	|-Array.InternalArray__Insert<Profile>
	|
	|-RVA: 0x21870A0 Offset: 0x21871A1 VA: 0x21870A0
	|-Array.InternalArray__Insert<Protrusion>
	|
	|-RVA: 0x2187100 Offset: 0x2187201 VA: 0x2187100
	|-Array.InternalArray__Insert<Quaternion>
	|
	|-RVA: 0x2187160 Offset: 0x2187261 VA: 0x2187160
	|-Array.InternalArray__Insert<RandomSeed>
	|
	|-RVA: 0x21871C0 Offset: 0x21872C1 VA: 0x21871C0
	|-Array.InternalArray__Insert<RangePositionInfo>
	|
	|-RVA: 0x2187220 Offset: 0x2187321 VA: 0x2187220
	|-Array.InternalArray__Insert<Ranking2ChartInfoInput>
	|
	|-RVA: 0x2187280 Offset: 0x2187381 VA: 0x2187280
	|-Array.InternalArray__Insert<RaycastHit>
	|
	|-RVA: 0x21872E0 Offset: 0x21873E1 VA: 0x21872E0
	|-Array.InternalArray__Insert<RaycastHit2D>
	|
	|-RVA: 0x2187340 Offset: 0x2187441 VA: 0x2187340
	|-Array.InternalArray__Insert<RaycastResult>
	|
	|-RVA: 0x21873A0 Offset: 0x21874A1 VA: 0x21873A0
	|-Array.InternalArray__Insert<Rect>
	|
	|-RVA: 0x2187400 Offset: 0x2187501 VA: 0x2187400
	|-Array.InternalArray__Insert<RenderBuffer>
	|
	|-RVA: 0x2187460 Offset: 0x2187561 VA: 0x2187460
	|-Array.InternalArray__Insert<RenderStateBlock>
	|
	|-RVA: 0x21874C0 Offset: 0x21875C1 VA: 0x21874C0
	|-Array.InternalArray__Insert<RenderTargetHandle>
	|
	|-RVA: 0x2187520 Offset: 0x2187621 VA: 0x2187520
	|-Array.InternalArray__Insert<RenderTargetIdentifier>
	|
	|-RVA: 0x2187580 Offset: 0x2187681 VA: 0x2187580
	|-Array.InternalArray__Insert<RendererListHandle>
	|
	|-RVA: 0x21875E0 Offset: 0x21876E1 VA: 0x21875E0
	|-Array.InternalArray__Insert<ResourceHandle>
	|
	|-RVA: 0x2187640 Offset: 0x2187741 VA: 0x2187640
	|-Array.InternalArray__Insert<ResourceLocator>
	|
	|-RVA: 0x21876A0 Offset: 0x21877A1 VA: 0x21876A0
	|-Array.InternalArray__Insert<RichTextTagAttribute>
	|
	|-RVA: 0x2187700 Offset: 0x2187801 VA: 0x2187700
	|-Array.InternalArray__Insert<RuntimeLabel>
	|
	|-RVA: 0x2187760 Offset: 0x2187861 VA: 0x2187760
	|-Array.InternalArray__Insert<sbyte>
	|
	|-RVA: 0x21877C0 Offset: 0x21878C1 VA: 0x21877C0
	|-Array.InternalArray__Insert<SerializedType>
	|
	|-RVA: 0x2187820 Offset: 0x2187921 VA: 0x2187820
	|-Array.InternalArray__Insert<ShaderKeyword>
	|
	|-RVA: 0x2187880 Offset: 0x2187981 VA: 0x2187880
	|-Array.InternalArray__Insert<ShaderTagId>
	|
	|-RVA: 0x21878E0 Offset: 0x21879E1 VA: 0x21878E0
	|-Array.InternalArray__Insert<ShadowSliceData>
	|
	|-RVA: 0x2187940 Offset: 0x2187A41 VA: 0x2187940
	|-Array.InternalArray__Insert<Shape>
	|
	|-RVA: 0x21879A0 Offset: 0x2187AA1 VA: 0x21879A0
	|-Array.InternalArray__Insert<float>
	|
	|-RVA: 0x2187A00 Offset: 0x2187B01 VA: 0x2187A00
	|-Array.InternalArray__Insert<SixAxisSensorHandle>
	|
	|-RVA: 0x2187A60 Offset: 0x2187B61 VA: 0x2187A60
	|-Array.InternalArray__Insert<SixAxisSensorState>
	|
	|-RVA: 0x2187AC0 Offset: 0x2187BC1 VA: 0x2187AC0
	|-Array.InternalArray__Insert<SkeletonBone>
	|
	|-RVA: 0x2187B20 Offset: 0x2187C21 VA: 0x2187B20
	|-Array.InternalArray__Insert<SortingLayer>
	|
	|-RVA: 0x2187B80 Offset: 0x2187C81 VA: 0x2187B80
	|-Array.InternalArray__Insert<SphericalHarmonicsL2>
	|
	|-RVA: 0x2187BE0 Offset: 0x2187CE1 VA: 0x2187BE0
	|-Array.InternalArray__Insert<SpinLock>
	|
	|-RVA: 0x2187C40 Offset: 0x2187D41 VA: 0x2187C40
	|-Array.InternalArray__Insert<SpringBoneComponents>
	|
	|-RVA: 0x2187CA0 Offset: 0x2187DA1 VA: 0x2187CA0
	|-Array.InternalArray__Insert<SpringBoneProperties>
	|
	|-RVA: 0x2187D00 Offset: 0x2187E01 VA: 0x2187D00
	|-Array.InternalArray__Insert<SpringColliderComponents>
	|
	|-RVA: 0x2187D60 Offset: 0x2187E61 VA: 0x2187D60
	|-Array.InternalArray__Insert<SpringColliderProperties>
	|
	|-RVA: 0x2187DC0 Offset: 0x2187EC1 VA: 0x2187DC0
	|-Array.InternalArray__Insert<SpringForceComponent>
	|
	|-RVA: 0x2187E20 Offset: 0x2187F21 VA: 0x2187E20
	|-Array.InternalArray__Insert<SpringJobElement>
	|
	|-RVA: 0x2187E80 Offset: 0x2187F81 VA: 0x2187E80
	|-Array.InternalArray__Insert<SpriteState>
	|
	|-RVA: 0x2187EE0 Offset: 0x2187FE1 VA: 0x2187EE0
	|-Array.InternalArray__Insert<SubMeshDescriptor>
	|
	|-RVA: 0x2187F40 Offset: 0x2188041 VA: 0x2187F40
	|-Array.InternalArray__Insert<TMP_CharacterInfo>
	|
	|-RVA: 0x2187FA0 Offset: 0x21880A1 VA: 0x2187FA0
	|-Array.InternalArray__Insert<TMP_FontWeightPair>
	|
	|-RVA: 0x2188000 Offset: 0x2188101 VA: 0x2188000
	|-Array.InternalArray__Insert<TMP_LineInfo>
	|
	|-RVA: 0x2188060 Offset: 0x2188161 VA: 0x2188060
	|-Array.InternalArray__Insert<TMP_LinkInfo>
	|
	|-RVA: 0x21880C0 Offset: 0x21881C1 VA: 0x21880C0
	|-Array.InternalArray__Insert<TMP_MeshInfo>
	|
	|-RVA: 0x2188120 Offset: 0x2188221 VA: 0x2188120
	|-Array.InternalArray__Insert<TMP_PageInfo>
	|
	|-RVA: 0x2188180 Offset: 0x2188281 VA: 0x2188180
	|-Array.InternalArray__Insert<TMP_WordInfo>
	|
	|-RVA: 0x21881E0 Offset: 0x21882E1 VA: 0x21881E0
	|-Array.InternalArray__Insert<TablePair>
	|
	|-RVA: 0x2188240 Offset: 0x2188341 VA: 0x2188240
	|-Array.InternalArray__Insert<TextureHandle>
	|
	|-RVA: 0x21882A0 Offset: 0x21883A1 VA: 0x21882A0
	|-Array.InternalArray__Insert<TimeSpan>
	|
	|-RVA: 0x2188300 Offset: 0x2188401 VA: 0x2188300
	|-Array.InternalArray__Insert<Touch>
	|
	|-RVA: 0x2188360 Offset: 0x2188461 VA: 0x2188360
	|-Array.InternalArray__Insert<TouchScreenState1>
	|
	|-RVA: 0x21883C0 Offset: 0x21884C1 VA: 0x21883C0
	|-Array.InternalArray__Insert<TouchScreenState10>
	|
	|-RVA: 0x2188420 Offset: 0x2188521 VA: 0x2188420
	|-Array.InternalArray__Insert<TouchScreenState11>
	|
	|-RVA: 0x2188480 Offset: 0x2188581 VA: 0x2188480
	|-Array.InternalArray__Insert<TouchScreenState12>
	|
	|-RVA: 0x21884E0 Offset: 0x21885E1 VA: 0x21884E0
	|-Array.InternalArray__Insert<TouchScreenState13>
	|
	|-RVA: 0x2188540 Offset: 0x2188641 VA: 0x2188540
	|-Array.InternalArray__Insert<TouchScreenState14>
	|
	|-RVA: 0x21885A0 Offset: 0x21886A1 VA: 0x21885A0
	|-Array.InternalArray__Insert<TouchScreenState15>
	|
	|-RVA: 0x2188600 Offset: 0x2188701 VA: 0x2188600
	|-Array.InternalArray__Insert<TouchScreenState16>
	|
	|-RVA: 0x2188660 Offset: 0x2188761 VA: 0x2188660
	|-Array.InternalArray__Insert<TouchScreenState2>
	|
	|-RVA: 0x21886C0 Offset: 0x21887C1 VA: 0x21886C0
	|-Array.InternalArray__Insert<TouchScreenState3>
	|
	|-RVA: 0x2188720 Offset: 0x2188821 VA: 0x2188720
	|-Array.InternalArray__Insert<TouchScreenState4>
	|
	|-RVA: 0x2188780 Offset: 0x2188881 VA: 0x2188780
	|-Array.InternalArray__Insert<TouchScreenState5>
	|
	|-RVA: 0x21887E0 Offset: 0x21888E1 VA: 0x21887E0
	|-Array.InternalArray__Insert<TouchScreenState6>
	|
	|-RVA: 0x2188840 Offset: 0x2188941 VA: 0x2188840
	|-Array.InternalArray__Insert<TouchScreenState7>
	|
	|-RVA: 0x21888A0 Offset: 0x21889A1 VA: 0x21888A0
	|-Array.InternalArray__Insert<TouchScreenState8>
	|
	|-RVA: 0x2188900 Offset: 0x2188A01 VA: 0x2188900
	|-Array.InternalArray__Insert<TouchScreenState9>
	|
	|-RVA: 0x2188960 Offset: 0x2188A61 VA: 0x2188960
	|-Array.InternalArray__Insert<TouchState>
	|
	|-RVA: 0x21889C0 Offset: 0x2188AC1 VA: 0x21889C0
	|-Array.InternalArray__Insert<TrailHand>
	|
	|-RVA: 0x2188A20 Offset: 0x2188B21 VA: 0x2188A20
	|-Array.InternalArray__Insert<TrailVertex>
	|
	|-RVA: 0x2188A80 Offset: 0x2188B81 VA: 0x2188A80
	|-Array.InternalArray__Insert<UICharInfo>
	|
	|-RVA: 0x2188AE0 Offset: 0x2188BE1 VA: 0x2188AE0
	|-Array.InternalArray__Insert<UILineInfo>
	|
	|-RVA: 0x2188B40 Offset: 0x2188C41 VA: 0x2188B40
	|-Array.InternalArray__Insert<UIVertex>
	|
	|-RVA: 0x2188BA0 Offset: 0x2188CA1 VA: 0x2188BA0
	|-Array.InternalArray__Insert<ushort>
	|
	|-RVA: 0x2188C00 Offset: 0x2188D01 VA: 0x2188C00
	|-Array.InternalArray__Insert<UInt16Enum>
	|
	|-RVA: 0x2188C60 Offset: 0x2188D61 VA: 0x2188C60
	|-Array.InternalArray__Insert<uint>
	|
	|-RVA: 0x2188CC0 Offset: 0x2188DC1 VA: 0x2188CC0
	|-Array.InternalArray__Insert<UInt32Enum>
	|
	|-RVA: 0x2188D20 Offset: 0x2188E21 VA: 0x2188D20
	|-Array.InternalArray__Insert<ulong>
	|
	|-RVA: 0x2188D80 Offset: 0x2188E81 VA: 0x2188D80
	|-Array.InternalArray__Insert<Uid>
	|
	|-RVA: 0x2188DE0 Offset: 0x2188EE1 VA: 0x2188DE0
	|-Array.InternalArray__Insert<UniTask>
	|
	|-RVA: 0x2188E40 Offset: 0x2188F41 VA: 0x2188E40
	|-Array.InternalArray__Insert<Unit>
	|
	|-RVA: 0x2188EA0 Offset: 0x2188FA1 VA: 0x2188EA0
	|-Array.InternalArray__Insert<UnitEnum>
	|
	|-RVA: 0x2188F00 Offset: 0x2189001 VA: 0x2188F00
	|-Array.InternalArray__Insert<UserWord>
	|
	|-RVA: 0x2188F60 Offset: 0x2189061 VA: 0x2188F60
	|-Array.InternalArray__Insert<Vector2>
	|
	|-RVA: 0x2188FC0 Offset: 0x21890C1 VA: 0x2188FC0
	|-Array.InternalArray__Insert<Vector2Int>
	|
	|-RVA: 0x2189020 Offset: 0x2189121 VA: 0x2189020
	|-Array.InternalArray__Insert<Vector3>
	|
	|-RVA: 0x2189080 Offset: 0x2189181 VA: 0x2189080
	|-Array.InternalArray__Insert<Vector4>
	|
	|-RVA: 0x21890E0 Offset: 0x21891E1 VA: 0x21890E0
	|-Array.InternalArray__Insert<VertexAttributeDescriptor>
	|
	|-RVA: 0x2189140 Offset: 0x2189241 VA: 0x2189140
	|-Array.InternalArray__Insert<VibrationDeviceHandle>
	|
	|-RVA: 0x21891A0 Offset: 0x21892A1 VA: 0x21891A0
	|-Array.InternalArray__Insert<VibrationDeviceInfo>
	|
	|-RVA: 0x2189200 Offset: 0x2189301 VA: 0x2189200
	|-Array.InternalArray__Insert<VibrationValue>
	|
	|-RVA: 0x2189260 Offset: 0x2189361 VA: 0x2189260
	|-Array.InternalArray__Insert<VisibleLight>
	|
	|-RVA: 0x21892C0 Offset: 0x21893C1 VA: 0x21892C0
	|-Array.InternalArray__Insert<WordWrapState>
	|
	|-RVA: 0x2189320 Offset: 0x2189421 VA: 0x2189320
	|-Array.InternalArray__Insert<X509ChainStatus>
	|
	|-RVA: 0x2189380 Offset: 0x2189481 VA: 0x2189380
	|-Array.InternalArray__Insert<XPathNode>
	|
	|-RVA: 0x21893E0 Offset: 0x21894E1 VA: 0x21893E0
	|-Array.InternalArray__Insert<XPathNodeRef>
	|
	|-RVA: 0x2189440 Offset: 0x2189541 VA: 0x2189440
	|-Array.InternalArray__Insert<XRView>
	|
	|-RVA: 0x21894A0 Offset: 0x21895A1 VA: 0x21894A0
	|-Array.InternalArray__Insert<float3>
	|
	|-RVA: 0x2189500 Offset: 0x2189601 VA: 0x2189500
	|-Array.InternalArray__Insert<float4x4>
	|
	|-RVA: 0x2189560 Offset: 0x2189661 VA: 0x2189560
	|-Array.InternalArray__Insert<jvalue>
	|
	|-RVA: 0x21895C0 Offset: 0x21896C1 VA: 0x21895C0
	|-Array.InternalArray__Insert<uint4>
	|
	|-RVA: 0x2189620 Offset: 0x2189721 VA: 0x2189620
	|-Array.InternalArray__Insert<AICrossfire.PositionTable>
	|
	|-RVA: 0x2189680 Offset: 0x2189781 VA: 0x2189680
	|-Array.InternalArray__Insert<AIEnum.SkillRangeEnemyData>
	|
	|-RVA: 0x21896E0 Offset: 0x21897E1 VA: 0x21896E0
	|-Array.InternalArray__Insert<AIOrder.UnitPriority>
	|
	|-RVA: 0x2189740 Offset: 0x2189841 VA: 0x2189740
	|-Array.InternalArray__Insert<AmiiboSequence.GainItemData>
	|
	|-RVA: 0x21897A0 Offset: 0x21898A1 VA: 0x21897A0
	|-Array.InternalArray__Insert<AnimationOutputWeightProcessor.WeightInfo>
	|
	|-RVA: 0x2189800 Offset: 0x2189901 VA: 0x2189800
	|-Array.InternalArray__Insert<ArenaOrderSequence.GodInfo>
	|
	|-RVA: 0x2189860 Offset: 0x2189961 VA: 0x2189860
	|-Array.InternalArray__Insert<BattleInfo.SupportData>
	|
	|-RVA: 0x21898C0 Offset: 0x21899C1 VA: 0x21898C0
	|-Array.InternalArray__Insert<BeforeRenderHelper.OrderBlock>
	|
	|-RVA: 0x2189920 Offset: 0x2189A21 VA: 0x2189920
	|-Array.InternalArray__Insert<Camera.RenderRequest>
	|
	|-RVA: 0x2189980 Offset: 0x2189A81 VA: 0x2189980
	|-Array.InternalArray__Insert<CameraState.CustomBlendable>
	|
	|-RVA: 0x21899E0 Offset: 0x2189AE1 VA: 0x21899E0
	|-Array.InternalArray__Insert<CinemachineBlendListCamera.Instruction>
	|
	|-RVA: 0x2189A40 Offset: 0x2189B41 VA: 0x2189A40
	|-Array.InternalArray__Insert<CinemachineBlenderSettings.CustomBlend>
	|
	|-RVA: 0x2189AA0 Offset: 0x2189BA1 VA: 0x2189AA0
	|-Array.InternalArray__Insert<CinemachineClearShot.Pair>
	|
	|-RVA: 0x2189B00 Offset: 0x2189C01 VA: 0x2189B00
	|-Array.InternalArray__Insert<CinemachineFreeLook.Orbit>
	|
	|-RVA: 0x2189B60 Offset: 0x2189C61 VA: 0x2189B60
	|-Array.InternalArray__Insert<CinemachinePath.Waypoint>
	|
	|-RVA: 0x2189BC0 Offset: 0x2189CC1 VA: 0x2189BC0
	|-Array.InternalArray__Insert<CinemachineSmoothPath.Waypoint>
	|
	|-RVA: 0x2189C20 Offset: 0x2189D21 VA: 0x2189C20
	|-Array.InternalArray__Insert<CinemachineStateDrivenCamera.HashPair>
	|
	|-RVA: 0x2189C80 Offset: 0x2189D81 VA: 0x2189C80
	|-Array.InternalArray__Insert<CinemachineStateDrivenCamera.Instruction>
	|
	|-RVA: 0x2189CE0 Offset: 0x2189DE1 VA: 0x2189CE0
	|-Array.InternalArray__Insert<CinemachineStateDrivenCamera.ParentHash>
	|
	|-RVA: 0x2189D40 Offset: 0x2189E41 VA: 0x2189D40
	|-Array.InternalArray__Insert<CinemachineTargetGroup.Target>
	|
	|-RVA: 0x2189DA0 Offset: 0x2189EA1 VA: 0x2189DA0
	|-Array.InternalArray__Insert<CodePointIndexer.TableRange>
	|
	|-RVA: 0x2189E00 Offset: 0x2189F01 VA: 0x2189E00
	|-Array.InternalArray__Insert<ContentCatalogData.Bucket>
	|
	|-RVA: 0x2189E60 Offset: 0x2189F61 VA: 0x2189E60
	|-Array.InternalArray__Insert<CookieTokenizer.RecognizedAttribute>
	|
	|-RVA: 0x2189EC0 Offset: 0x2189FC1 VA: 0x2189EC0
	|-Array.InternalArray__Insert<DeferredLights.DrawCall>
	|
	|-RVA: 0x2189F20 Offset: 0x218A021 VA: 0x2189F20
	|-Array.InternalArray__Insert<DeferredShaderData.ComputeBufferInfo>
	|
	|-RVA: 0x2189F80 Offset: 0x218A081 VA: 0x2189F80
	|-Array.InternalArray__Insert<DeferredTiler.PrePunctualLight>
	|
	|-RVA: 0x2189FE0 Offset: 0x218A0E1 VA: 0x2189FE0
	|-Array.InternalArray__Insert<DelayedActionManager.DelegateInfo>
	|
	|-RVA: 0x218A040 Offset: 0x218A141 VA: 0x218A040
	|-Array.InternalArray__Insert<Detail.AsyncResultInt>
	|
	|-RVA: 0x218A0A0 Offset: 0x218A1A1 VA: 0x218A0A0
	|-Array.InternalArray__Insert<Detail.CppArray>
	|
	|-RVA: 0x218A100 Offset: 0x218A201 VA: 0x218A100
	|-Array.InternalArray__Insert<Detail.NotificationEventInt>
	|
	|-RVA: 0x218A160 Offset: 0x218A261 VA: 0x218A160
	|-Array.InternalArray__Insert<DisposUnit.Item>
	|
	|-RVA: 0x218A1C0 Offset: 0x218A2C1 VA: 0x218A1C0
	|-Array.InternalArray__Insert<DragonRidePresetParamData.CourseData>
	|
	|-RVA: 0x218A220 Offset: 0x218A321 VA: 0x218A220
	|-Array.InternalArray__Insert<DragonRideTargetGroup.ChainParam>
	|
	|-RVA: 0x218A280 Offset: 0x218A381 VA: 0x218A280
	|-Array.InternalArray__Insert<DynamicMesh.State>
	|
	|-RVA: 0x218A2E0 Offset: 0x218A3E1 VA: 0x218A2E0
	|-Array.InternalArray__Insert<FXZEx.HitPoint>
	|
	|-RVA: 0x218A340 Offset: 0x218A441 VA: 0x218A340
	|-Array.InternalArray__Insert<FishingRadicalParamData.RadicalParam>
	|
	|-RVA: 0x218A3A0 Offset: 0x218A4A1 VA: 0x218A3A0
	|-Array.InternalArray__Insert<GameVariable.Value>
	|
	|-RVA: 0x218A400 Offset: 0x218A501 VA: 0x218A400
	|-Array.InternalArray__Insert<GmapPathAdjuster.TargetModel>
	|
	|-RVA: 0x218A460 Offset: 0x218A561 VA: 0x218A460
	|-Array.InternalArray__Insert<GmapSpotAdjuster.TargetModel>
	|
	|-RVA: 0x218A4C0 Offset: 0x218A5C1 VA: 0x218A4C0
	|-Array.InternalArray__Insert<GrounderQuadruped.Foot>
	|
	|-RVA: 0x218A520 Offset: 0x218A621 VA: 0x218A520
	|-Array.InternalArray__Insert<Hashtable.bucket>
	|
	|-RVA: 0x218A580 Offset: 0x218A681 VA: 0x218A580
	|-Array.InternalArray__Insert<HeadingTracker.Item>
	|
	|-RVA: 0x218A5E0 Offset: 0x218A6E1 VA: 0x218A5E0
	|-Array.InternalArray__Insert<HubAccessoryRoomCamera.BackgroundSettings>
	|
	|-RVA: 0x218A640 Offset: 0x218A741 VA: 0x218A640
	|-Array.InternalArray__Insert<HubFastTravel.Location>
	|
	|-RVA: 0x218A6A0 Offset: 0x218A7A1 VA: 0x218A6A0
	|-Array.InternalArray__Insert<HubLensFlare.Flare>
	|
	|-RVA: 0x218A700 Offset: 0x218A801 VA: 0x218A700
	|-Array.InternalArray__Insert<HubLookAtController.LookAtIKParam>
	|
	|-RVA: 0x218A760 Offset: 0x218A861 VA: 0x218A760
	|-Array.InternalArray__Insert<HubMaterialArray.MaterialInfo>
	|
	|-RVA: 0x218A7C0 Offset: 0x218A8C1 VA: 0x218A7C0
	|-Array.InternalArray__Insert<IKSolverLimb.AxisDirection>
	|
	|-RVA: 0x218A820 Offset: 0x218A921 VA: 0x218A820
	|-Array.InternalArray__Insert<InventoryPoolItemMenuContent.KindBgNameClass>
	|
	|-RVA: 0x218A880 Offset: 0x218A981 VA: 0x218A880
	|-Array.InternalArray__Insert<LightUtility.ParametricLightMeshVertex>
	|
	|-RVA: 0x218A8E0 Offset: 0x218A9E1 VA: 0x218A8E0
	|-Array.InternalArray__Insert<LightUtility.SpriteLightMeshVertex>
	|
	|-RVA: 0x218A940 Offset: 0x218AA41 VA: 0x218A940
	|-Array.InternalArray__Insert<Map.Pos>
	|
	|-RVA: 0x218A9A0 Offset: 0x218AAA1 VA: 0x218A9A0
	|-Array.InternalArray__Insert<MapGodExp.KindDesc>
	|
	|-RVA: 0x218AA00 Offset: 0x218AB01 VA: 0x218AA00
	|-Array.InternalArray__Insert<MapHistory.Command>
	|
	|-RVA: 0x218AA60 Offset: 0x218AB61 VA: 0x218AA60
	|-Array.InternalArray__Insert<MapImage.BackupTerrain>
	|
	|-RVA: 0x218AAC0 Offset: 0x218ABC1 VA: 0x218AAC0
	|-Array.InternalArray__Insert<MapImageRange.Pos>
	|
	|-RVA: 0x218AB20 Offset: 0x218AC21 VA: 0x218AB20
	|-Array.InternalArray__Insert<MapKillBonus.KillBonus>
	|
	|-RVA: 0x218AB80 Offset: 0x218AC81 VA: 0x218AB80
	|-Array.InternalArray__Insert<MapKillBonus.KilledBonus>
	|
	|-RVA: 0x218ABE0 Offset: 0x218ACE1 VA: 0x218ABE0
	|-Array.InternalArray__Insert<MapMind.Record>
	|
	|-RVA: 0x218AC40 Offset: 0x218AD41 VA: 0x218AC40
	|-Array.InternalArray__Insert<MapMind.Target>
	|
	|-RVA: 0x218ACA0 Offset: 0x218ADA1 VA: 0x218ACA0
	|-Array.InternalArray__Insert<MapPanelDebug.Entity>
	|
	|-RVA: 0x218AD00 Offset: 0x218AE01 VA: 0x218AD00
	|-Array.InternalArray__Insert<NexRanking.Data>
	|
	|-RVA: 0x218AD60 Offset: 0x218AE61 VA: 0x218AD60
	|-Array.InternalArray__Insert<NexVersus.RatingData>
	|
	|-RVA: 0x218ADC0 Offset: 0x218AEC1 VA: 0x218ADC0
	|-Array.InternalArray__Insert<NoiseSettings.TransformNoiseParams>
	|
	|-RVA: 0x218AE20 Offset: 0x218AF21 VA: 0x218AE20
	|-Array.InternalArray__Insert<PackedPlayModeBuildLogs.RuntimeBuildLog>
	|
	|-RVA: 0x218AE80 Offset: 0x218AF81 VA: 0x218AE80
	|-Array.InternalArray__Insert<ParameterizedStrings.FormatParam>
	|
	|-RVA: 0x218AEE0 Offset: 0x218AFE1 VA: 0x218AEE0
	|-Array.InternalArray__Insert<ParticleSystem.Particle>
	|
	|-RVA: 0x218AF40 Offset: 0x218B041 VA: 0x218AF40
	|-Array.InternalArray__Insert<ProfileCard.Achievement>
	|
	|-RVA: 0x218AFA0 Offset: 0x218B0A1 VA: 0x218AFA0
	|-Array.InternalArray__Insert<ProfileCard.SortieCount>
	|
	|-RVA: 0x218B000 Offset: 0x218B101 VA: 0x218B000
	|-Array.InternalArray__Insert<QualitySettingsStack.Settings>
	|
	|-RVA: 0x218B060 Offset: 0x218B161 VA: 0x218B060
	|-Array.InternalArray__Insert<RangeData.Offset>
	|
	|-RVA: 0x218B0C0 Offset: 0x218B1C1 VA: 0x218B0C0
	|-Array.InternalArray__Insert<RegexCharClass.LowerCaseMapping>
	|
	|-RVA: 0x218B120 Offset: 0x218B221 VA: 0x218B120
	|-Array.InternalArray__Insert<Relay.ChooseAwardeeData>
	|
	|-RVA: 0x218B180 Offset: 0x218B281 VA: 0x218B180
	|-Array.InternalArray__Insert<RelayAwardData.Info>
	|
	|-RVA: 0x218B1E0 Offset: 0x218B2E1 VA: 0x218B1E0
	|-Array.InternalArray__Insert<RenderGraph.CompiledPassInfo>
	|
	|-RVA: 0x218B240 Offset: 0x218B341 VA: 0x218B240
	|-Array.InternalArray__Insert<RenderGraph.CompiledResourceInfo>
	|
	|-RVA: 0x218B2A0 Offset: 0x218B3A1 VA: 0x218B2A0
	|-Array.InternalArray__Insert<RenderGraphDebugData.PassDebugData>
	|
	|-RVA: 0x218B300 Offset: 0x218B401 VA: 0x218B300
	|-Array.InternalArray__Insert<RenderGraphDebugData.ResourceDebugData>
	|
	|-RVA: 0x218B360 Offset: 0x218B461 VA: 0x218B360
	|-Array.InternalArray__Insert<RenderGraphResourceRegistry.RendererListResource>
	|
	|-RVA: 0x218B3C0 Offset: 0x218B4C1 VA: 0x218B3C0
	|-Array.InternalArray__Insert<RingCleaningUnitSelectMenu.GodParam>
	|
	|-RVA: 0x218B420 Offset: 0x218B521 VA: 0x218B420
	|-Array.InternalArray__Insert<SampleWave.Data>
	|
	|-RVA: 0x218B480 Offset: 0x218B581 VA: 0x218B480
	|-Array.InternalArray__Insert<SampleWave.Temp>
	|
	|-RVA: 0x218B4E0 Offset: 0x218B5E1 VA: 0x218B4E0
	|-Array.InternalArray__Insert<SendMouseEvents.HitInfo>
	|
	|-RVA: 0x218B540 Offset: 0x218B641 VA: 0x218B540
	|-Array.InternalArray__Insert<SequenceNode.SequenceConstructPosContext>
	|
	|-RVA: 0x218B5A0 Offset: 0x218B6A1 VA: 0x218B5A0
	|-Array.InternalArray__Insert<ShaderInput.LightData>
	|
	|-RVA: 0x218B600 Offset: 0x218B701 VA: 0x218B600
	|-Array.InternalArray__Insert<ShaderInput.ShadowData>
	|
	|-RVA: 0x218B660 Offset: 0x218B761 VA: 0x218B660
	|-Array.InternalArray__Insert<ShadowUtility.Edge>
	|
	|-RVA: 0x218B6C0 Offset: 0x218B7C1 VA: 0x218B6C0
	|-Array.InternalArray__Insert<SimpleAnimationPlayable.QueuedState>
	|
	|-RVA: 0x218B720 Offset: 0x218B821 VA: 0x218B720
	|-Array.InternalArray__Insert<SkillArray.Entity>
	|
	|-RVA: 0x218B780 Offset: 0x218B881 VA: 0x218B780
	|-Array.InternalArray__Insert<Socket.WSABUF>
	|
	|-RVA: 0x218B7E0 Offset: 0x218B8E1 VA: 0x218B7E0
	|-Array.InternalArray__Insert<Stream.Info>
	|
	|-RVA: 0x218B840 Offset: 0x218B941 VA: 0x218B840
	|-Array.InternalArray__Insert<TMP_Text.UnicodeChar>
	|
	|-RVA: 0x218B8A0 Offset: 0x218B9A1 VA: 0x218B8A0
	|-Array.InternalArray__Insert<TexturePacker_JsonArray.Frame>
	|
	|-RVA: 0x218B900 Offset: 0x218BA01 VA: 0x218B900
	|-Array.InternalArray__Insert<TimeNotificationBehaviour.NotificationEntry>
	|
	|-RVA: 0x218B960 Offset: 0x218BA61 VA: 0x218B960
	|-Array.InternalArray__Insert<UnitySynchronizationContext.WorkRequest>
	|
	|-RVA: 0x218B9C0 Offset: 0x218BAC1 VA: 0x218B9C0
	|-Array.InternalArray__Insert<XmlNamespaceManager.NamespaceDeclaration>
	|
	|-RVA: 0x218BA20 Offset: 0x218BB21 VA: 0x218BA20
	|-Array.InternalArray__Insert<XmlSchemaObjectTable.XmlSchemaObjectEntry>
	|
	|-RVA: 0x218BA80 Offset: 0x218BB81 VA: 0x218BA80
	|-Array.InternalArray__Insert<XmlTextReaderImpl.ParsingState>
	|
	|-RVA: 0x218BAE0 Offset: 0x218BBE1 VA: 0x218BAE0
	|-Array.InternalArray__Insert<AIThink.EnchantThink.Desc>
	|
	|-RVA: 0x218BB40 Offset: 0x218BC41 VA: 0x218BB40
	|-Array.InternalArray__Insert<AIThink.EnchantThink.ItemInfo>
	|
	|-RVA: 0x218BBA0 Offset: 0x218BCA1 VA: 0x218BBA0
	|-Array.InternalArray__Insert<AIThink.EnchantThink.SurroundingInfo>
	|
	|-RVA: 0x218BC00 Offset: 0x218BD01 VA: 0x218BC00
	|-Array.InternalArray__Insert<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>
	|
	|-RVA: 0x218BC60 Offset: 0x218BD61 VA: 0x218BC60
	|-Array.InternalArray__Insert<Detail.DataStore.DataStoreChangeMetaParamInt>
	|
	|-RVA: 0x218BCC0 Offset: 0x218BDC1 VA: 0x218BCC0
	|-Array.InternalArray__Insert<Detail.DataStore.DataStoreDeleteParamInt>
	|
	|-RVA: 0x218BD20 Offset: 0x218BE21 VA: 0x218BD20
	|-Array.InternalArray__Insert<Detail.DataStore.DataStoreGetMetaParamInt>
	|
	|-RVA: 0x218BD80 Offset: 0x218BE81 VA: 0x218BD80
	|-Array.InternalArray__Insert<Detail.DataStore.DataStoreMetaInfoInt>
	|
	|-RVA: 0x218BDE0 Offset: 0x218BEE1 VA: 0x218BDE0
	|-Array.InternalArray__Insert<Detail.DataStore.DataStorePasswordInfoInt>
	|
	|-RVA: 0x218BE40 Offset: 0x218BF41 VA: 0x218BE40
	|-Array.InternalArray__Insert<Detail.DataStore.DataStorePersistenceInfoInt>
	|
	|-RVA: 0x218BEA0 Offset: 0x218BFA1 VA: 0x218BEA0
	|-Array.InternalArray__Insert<Detail.DataStore.DataStorePreparePostParamInt>
	|
	|-RVA: 0x218BF00 Offset: 0x218C001 VA: 0x218BF00
	|-Array.InternalArray__Insert<Detail.DataStore.DataStoreRateObjectParamInt>
	|
	|-RVA: 0x218BF60 Offset: 0x218C061 VA: 0x218BF60
	|-Array.InternalArray__Insert<Detail.DataStore.DataStoreRatingInitParamInt>
	|
	|-RVA: 0x218BFC0 Offset: 0x218C0C1 VA: 0x218BFC0
	|-Array.InternalArray__Insert<Detail.DataStore.DataStoreRatingTargetInt>
	|
	|-RVA: 0x218C020 Offset: 0x218C121 VA: 0x218C020
	|-Array.InternalArray__Insert<Detail.Ranking.RankingCachedResultInt>
	|
	|-RVA: 0x218C080 Offset: 0x218C181 VA: 0x218C080
	|-Array.InternalArray__Insert<Detail.Ranking.RankingOrderParamInt>
	|
	|-RVA: 0x218C0E0 Offset: 0x218C1E1 VA: 0x218C0E0
	|-Array.InternalArray__Insert<Detail.Ranking.RankingRankDataInt>
	|
	|-RVA: 0x218C140 Offset: 0x218C241 VA: 0x218C140
	|-Array.InternalArray__Insert<Detail.Ranking2.Ranking2ChartInfoInt>
	|
	|-RVA: 0x218C1A0 Offset: 0x218C2A1 VA: 0x218C1A0
	|-Array.InternalArray__Insert<Detail.Ranking2.Ranking2RankDataInt>
	|
	|-RVA: 0x218C200 Offset: 0x218C301 VA: 0x218C200
	|-Array.InternalArray__Insert<Detail.Ranking2.Ranking2ScoreDataInt>
	|
	|-RVA: 0x218C260 Offset: 0x218C361 VA: 0x218C260
	|-Array.InternalArray__Insert<Detail.Screening.ScreeningContextInfoInt>
	|
	|-RVA: 0x218C2C0 Offset: 0x218C3C1 VA: 0x218C2C0
	|-Array.InternalArray__Insert<Detail.Subscriber.SubscriberContentInt>
	|
	|-RVA: 0x218C320 Offset: 0x218C421 VA: 0x218C320
	|-Array.InternalArray__Insert<Detail.Subscriber.SubscriberGetContentParamInt>
	|
	|-RVA: 0x218C380 Offset: 0x218C481 VA: 0x218C380
	|-Array.InternalArray__Insert<Detail.Subscriber.SubscriberUserStatusInfoInt>
	|
	|-RVA: 0x218C3E0 Offset: 0x218C4E1 VA: 0x218C3E0
	|-Array.InternalArray__Insert<Detail.Subscriber.SubscriberUserStatusParamInt>
	|
	|-RVA: 0x218C440 Offset: 0x218C541 VA: 0x218C440
	|-Array.InternalArray__Insert<Detail.Utility.IntegerSettings>
	|
	|-RVA: 0x218C4A0 Offset: 0x218C5A1 VA: 0x218C4A0
	|-Array.InternalArray__Insert<Detail.Utility.UniqueIdInfoInt>
	|
	|-RVA: 0x218C500 Offset: 0x218C601 VA: 0x218C500
	|-Array.InternalArray__Insert<FacetsChecker.FacetsCompiler.Map>
	|
	|-RVA: 0x218C560 Offset: 0x218C661 VA: 0x218C560
	|-Array.InternalArray__Insert<MapHistory.ReplayAppearanceMap.Appearance>
	|
	|-RVA: 0x218C5C0 Offset: 0x218C6C1 VA: 0x218C5C0
	|-Array.InternalArray__Insert<MapHistory.ReplayAppearanceMap.Leaving>
	|
	|-RVA: 0x218C620 Offset: 0x218C721 VA: 0x218C620
	|-Array.InternalArray__Insert<MapHistory.ReplayUnitMap.Data>
	|
	|-RVA: 0x218C680 Offset: 0x218C781 VA: 0x218C680
	|-Array.InternalArray__Insert<MapHistory.Rewind.LatestInspectorData>
	|
	|-RVA: 0x218C6E0 Offset: 0x218C7E1 VA: 0x218C6E0
	|-Array.InternalArray__Insert<MapHistory.Rewind.WorkTerrainData>
	|
	|-RVA: 0x218C740 Offset: 0x218C841 VA: 0x218C740
	|-Array.InternalArray__Insert<MapHistory.RewindUnitMap.Data>
	|
	|-RVA: 0x218C7A0 Offset: 0x218C8A1 VA: 0x218C7A0
	|-Array.InternalArray__Insert<MapKillBonus.Work.Pos>
	|
	|-RVA: 0x218C800 Offset: 0x218C901 VA: 0x218C800
	|-Array.InternalArray__Insert<MapSkill.AroundCalculator.Result>
	|
	|-RVA: 0x218C860 Offset: 0x218C961 VA: 0x218C860
	|-Array.InternalArray__Insert<Nex.ApiCallChecker.Guideline>
	|
	|-RVA: 0x218C8C0 Offset: 0x218C9C1 VA: 0x218C8C0
	|-Array.InternalArray__Insert<Ngc.MaskTextSequenceBase.Data>
	|
	|-RVA: 0x218C920 Offset: 0x218CA21 VA: 0x218C920
	|-Array.InternalArray__Insert<TargetPositionCache.CacheCurve.Item>
	|
	|-RVA: 0x218C980 Offset: 0x218CA81 VA: 0x218C980
	|-Array.InternalArray__Insert<TargetPositionCache.CacheEntry.RecordingItem>
	|
	|-RVA: 0x218C9E0 Offset: 0x218CAE1 VA: 0x218C9E0
	|-Array.InternalArray__Insert<TerrainUtility.TerrainMap.TileCoord>
	*/

	// RVA: 0x3564120 Offset: 0x3564221 VA: 0x3564120
	internal void InternalArray__RemoveAt(int index) { }

	// RVA: -1 Offset: -1
	internal int InternalArray__IndexOf<T>(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x39E4840 Offset: 0x39E4941 VA: 0x39E4840
	|-Array.InternalArray__IndexOf<ArraySegment<byte>>
	|
	|-RVA: 0x39E49E0 Offset: 0x39E4AE1 VA: 0x39E49E0
	|-Array.InternalArray__IndexOf<AsyncOperationHandle<object>>
	|
	|-RVA: 0x39E4BA0 Offset: 0x39E4CA1 VA: 0x39E4BA0
	|-Array.InternalArray__IndexOf<MapDeployTemplate.Queue.Data<object>>
	|
	|-RVA: 0x39E4D40 Offset: 0x39E4E41 VA: 0x39E4D40
	|-Array.InternalArray__IndexOf<Nex.DataStore.ParamPool.Data<object>>
	|
	|-RVA: 0x39E4EF0 Offset: 0x39E4FF1 VA: 0x39E4EF0
	|-Array.InternalArray__IndexOf<Nex.Screening.ParamPool.Data<object>>
	|
	|-RVA: 0x39E50A0 Offset: 0x39E51A1 VA: 0x39E50A0
	|-Array.InternalArray__IndexOf<IntervalTree.Entry<object>>
	|
	|-RVA: 0x39E5260 Offset: 0x39E5361 VA: 0x39E5260
	|-Array.InternalArray__IndexOf<Dictionary.Entry<ValueTuple<object, int>, object>>
	|
	|-RVA: 0x39E5420 Offset: 0x39E5521 VA: 0x39E5420
	|-Array.InternalArray__IndexOf<Dictionary.Entry<byte, object>>
	|
	|-RVA: 0x39E55E0 Offset: 0x39E56E1 VA: 0x39E55E0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<CancellationToken, object>>
	|
	|-RVA: 0x39E57A0 Offset: 0x39E58A1 VA: 0x39E57A0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<char, object>>
	|
	|-RVA: 0x39E5960 Offset: 0x39E5A61 VA: 0x39E5960
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Guid, object>>
	|
	|-RVA: 0x39E5B20 Offset: 0x39E5C21 VA: 0x39E5B20
	|-Array.InternalArray__IndexOf<Dictionary.Entry<int, bool>>
	|
	|-RVA: 0x39E5CD0 Offset: 0x39E5DD1 VA: 0x39E5CD0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<int, byte>>
	|
	|-RVA: 0x39E5E80 Offset: 0x39E5F81 VA: 0x39E5E80
	|-Array.InternalArray__IndexOf<Dictionary.Entry<int, char>>
	|
	|-RVA: 0x39E6030 Offset: 0x39E6131 VA: 0x39E6030
	|-Array.InternalArray__IndexOf<Dictionary.Entry<int, DiagnosticEvent>>
	|
	|-RVA: 0x39E6210 Offset: 0x39E6311 VA: 0x39E6210
	|-Array.InternalArray__IndexOf<Dictionary.Entry<int, int>>
	|
	|-RVA: 0x39E63C0 Offset: 0x39E64C1 VA: 0x39E63C0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<int, Int32Enum>>
	|
	|-RVA: 0x39E6570 Offset: 0x39E6671 VA: 0x39E6570
	|-Array.InternalArray__IndexOf<Dictionary.Entry<int, long>>
	|
	|-RVA: 0x39E6730 Offset: 0x39E6831 VA: 0x39E6730
	|-Array.InternalArray__IndexOf<Dictionary.Entry<int, MapPos>>
	|
	|-RVA: 0x39E68F0 Offset: 0x39E69F1 VA: 0x39E68F0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<int, object>>
	|
	|-RVA: 0x39E6AB0 Offset: 0x39E6BB1 VA: 0x39E6AB0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<int, uint>>
	|
	|-RVA: 0x39E6C60 Offset: 0x39E6D61 VA: 0x39E6C60
	|-Array.InternalArray__IndexOf<Dictionary.Entry<int, AIThink.EnchantThink.SurroundingInfo>>
	|
	|-RVA: 0x39E6E10 Offset: 0x39E6F11 VA: 0x39E6E10
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Int32Enum, bool>>
	|
	|-RVA: 0x39E6FC0 Offset: 0x39E70C1 VA: 0x39E6FC0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Int32Enum, int>>
	|
	|-RVA: 0x39E7170 Offset: 0x39E7271 VA: 0x39E7170
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Int32Enum, Int32Enum>>
	|
	|-RVA: 0x39E7320 Offset: 0x39E7421 VA: 0x39E7320
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Int32Enum, object>>
	|
	|-RVA: 0x39E74E0 Offset: 0x39E75E1 VA: 0x39E74E0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<long, object>>
	|
	|-RVA: 0x39E76A0 Offset: 0x39E77A1 VA: 0x39E76A0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<MapPos, int>>
	|
	|-RVA: 0x39E7860 Offset: 0x39E7961 VA: 0x39E7860
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, AsyncOperationHandle<object>>>
	|
	|-RVA: 0x39E7A30 Offset: 0x39E7B31 VA: 0x39E7A30
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, AsyncOperationHandle>>
	|
	|-RVA: 0x39E7C00 Offset: 0x39E7D01 VA: 0x39E7C00
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, bool>>
	|
	|-RVA: 0x39E7DC0 Offset: 0x39E7EC1 VA: 0x39E7DC0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, byte>>
	|
	|-RVA: 0x39E7F80 Offset: 0x39E8081 VA: 0x39E7F80
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, int>>
	|
	|-RVA: 0x39E8140 Offset: 0x39E8241 VA: 0x39E8140
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, Int32Enum>>
	|
	|-RVA: 0x39E8300 Offset: 0x39E8401 VA: 0x39E8300
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, IntPtr>>
	|
	|-RVA: 0x39E84C0 Offset: 0x39E85C1 VA: 0x39E84C0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, object>>
	|
	|-RVA: 0x39E8680 Offset: 0x39E8781 VA: 0x39E8680
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, Playable>>
	|
	|-RVA: 0x39E8840 Offset: 0x39E8941 VA: 0x39E8840
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, ResourceLocator>>
	|
	|-RVA: 0x39E8A00 Offset: 0x39E8B01 VA: 0x39E8A00
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, float>>
	|
	|-RVA: 0x39E8BC0 Offset: 0x39E8CC1 VA: 0x39E8BC0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, ushort>>
	|
	|-RVA: 0x39E8D80 Offset: 0x39E8E81 VA: 0x39E8D80
	|-Array.InternalArray__IndexOf<Dictionary.Entry<object, GameVariable.Value>>
	|
	|-RVA: 0x39E8F40 Offset: 0x39E9041 VA: 0x39E8F40
	|-Array.InternalArray__IndexOf<Dictionary.Entry<sbyte, DataStoreRatingInfo>>
	|
	|-RVA: 0x39E9110 Offset: 0x39E9211 VA: 0x39E9110
	|-Array.InternalArray__IndexOf<Dictionary.Entry<sbyte, object>>
	|
	|-RVA: 0x39E92D0 Offset: 0x39E93D1 VA: 0x39E92D0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<ushort, int>>
	|
	|-RVA: 0x39E9480 Offset: 0x39E9581 VA: 0x39E9480
	|-Array.InternalArray__IndexOf<Dictionary.Entry<uint, int>>
	|
	|-RVA: 0x39E9630 Offset: 0x39E9731 VA: 0x39E9630
	|-Array.InternalArray__IndexOf<Dictionary.Entry<uint, object>>
	|
	|-RVA: 0x39E97F0 Offset: 0x39E98F1 VA: 0x39E97F0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<ulong, Friend>>
	|
	|-RVA: 0x39E99C0 Offset: 0x39E9AC1 VA: 0x39E99C0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<ulong, Int32Enum>>
	|
	|-RVA: 0x39E9B80 Offset: 0x39E9C81 VA: 0x39E9B80
	|-Array.InternalArray__IndexOf<Dictionary.Entry<ulong, object>>
	|
	|-RVA: 0x39E9D40 Offset: 0x39E9E41 VA: 0x39E9D40
	|-Array.InternalArray__IndexOf<Dictionary.Entry<Vector3, int>>
	|
	|-RVA: 0x39E9F00 Offset: 0x39EA001 VA: 0x39E9F00
	|-Array.InternalArray__IndexOf<Dictionary.Entry<XPathNodeRef, XPathNodeRef>>
	|
	|-RVA: 0x39EA0D0 Offset: 0x39EA1D1 VA: 0x39EA0D0
	|-Array.InternalArray__IndexOf<Dictionary.Entry<TerrainUtility.TerrainMap.TileCoord, object>>
	|
	|-RVA: 0x39EA290 Offset: 0x39EA391 VA: 0x39EA290
	|-Array.InternalArray__IndexOf<PriorityQueue.IndexedItem<object>>
	|
	|-RVA: 0x39EA440 Offset: 0x39EA541 VA: 0x39EA440
	|-Array.InternalArray__IndexOf<KeyValuePair<ValueTuple<object, int>, object>>
	|
	|-RVA: 0x39EA600 Offset: 0x39EA701 VA: 0x39EA600
	|-Array.InternalArray__IndexOf<KeyValuePair<byte, object>>
	|
	|-RVA: 0x39EA7B0 Offset: 0x39EA8B1 VA: 0x39EA7B0
	|-Array.InternalArray__IndexOf<KeyValuePair<CancellationToken, object>>
	|
	|-RVA: 0x39EA960 Offset: 0x39EAA61 VA: 0x39EA960
	|-Array.InternalArray__IndexOf<KeyValuePair<char, object>>
	|
	|-RVA: 0x39EAB10 Offset: 0x39EAC11 VA: 0x39EAB10
	|-Array.InternalArray__IndexOf<KeyValuePair<DateTime, object>>
	|
	|-RVA: 0x39EACC0 Offset: 0x39EADC1 VA: 0x39EACC0
	|-Array.InternalArray__IndexOf<KeyValuePair<Guid, object>>
	|
	|-RVA: 0x39EAE80 Offset: 0x39EAF81 VA: 0x39EAE80
	|-Array.InternalArray__IndexOf<KeyValuePair<int, bool>>
	|
	|-RVA: 0x39EB020 Offset: 0x39EB121 VA: 0x39EB020
	|-Array.InternalArray__IndexOf<KeyValuePair<int, byte>>
	|
	|-RVA: 0x39EB1C0 Offset: 0x39EB2C1 VA: 0x39EB1C0
	|-Array.InternalArray__IndexOf<KeyValuePair<int, char>>
	|
	|-RVA: 0x39EB360 Offset: 0x39EB461 VA: 0x39EB360
	|-Array.InternalArray__IndexOf<KeyValuePair<int, DiagnosticEvent>>
	|
	|-RVA: 0x39EB540 Offset: 0x39EB641 VA: 0x39EB540
	|-Array.InternalArray__IndexOf<KeyValuePair<int, int>>
	|
	|-RVA: 0x39EB6E0 Offset: 0x39EB7E1 VA: 0x39EB6E0
	|-Array.InternalArray__IndexOf<KeyValuePair<int, Int32Enum>>
	|
	|-RVA: 0x39EB880 Offset: 0x39EB981 VA: 0x39EB880
	|-Array.InternalArray__IndexOf<KeyValuePair<int, long>>
	|
	|-RVA: 0x39EBA30 Offset: 0x39EBB31 VA: 0x39EBA30
	|-Array.InternalArray__IndexOf<KeyValuePair<int, MapPos>>
	|
	|-RVA: 0x39EBBF0 Offset: 0x39EBCF1 VA: 0x39EBBF0
	|-Array.InternalArray__IndexOf<KeyValuePair<int, object>>
	|
	|-RVA: 0x39EBDA0 Offset: 0x39EBEA1 VA: 0x39EBDA0
	|-Array.InternalArray__IndexOf<KeyValuePair<int, uint>>
	|
	|-RVA: 0x39EBF40 Offset: 0x39EC041 VA: 0x39EBF40
	|-Array.InternalArray__IndexOf<KeyValuePair<int, AIThink.EnchantThink.SurroundingInfo>>
	|
	|-RVA: 0x39EC0E0 Offset: 0x39EC1E1 VA: 0x39EC0E0
	|-Array.InternalArray__IndexOf<KeyValuePair<Int32Enum, bool>>
	|
	|-RVA: 0x39EC280 Offset: 0x39EC381 VA: 0x39EC280
	|-Array.InternalArray__IndexOf<KeyValuePair<Int32Enum, int>>
	|
	|-RVA: 0x39EC420 Offset: 0x39EC521 VA: 0x39EC420
	|-Array.InternalArray__IndexOf<KeyValuePair<Int32Enum, Int32Enum>>
	|
	|-RVA: 0x39EC5C0 Offset: 0x39EC6C1 VA: 0x39EC5C0
	|-Array.InternalArray__IndexOf<KeyValuePair<Int32Enum, object>>
	|
	|-RVA: 0x39EC770 Offset: 0x39EC871 VA: 0x39EC770
	|-Array.InternalArray__IndexOf<KeyValuePair<long, object>>
	|
	|-RVA: 0x39EC920 Offset: 0x39ECA21 VA: 0x39EC920
	|-Array.InternalArray__IndexOf<KeyValuePair<MapPos, int>>
	|
	|-RVA: 0x39ECAE0 Offset: 0x39ECBE1 VA: 0x39ECAE0
	|-Array.InternalArray__IndexOf<KeyValuePair<object, AsyncOperationHandle<object>>>
	|
	|-RVA: 0x39ECCA0 Offset: 0x39ECDA1 VA: 0x39ECCA0
	|-Array.InternalArray__IndexOf<KeyValuePair<object, ValueTuple<int, DateTime, object>>>
	|
	|-RVA: 0x39ECE60 Offset: 0x39ECF61 VA: 0x39ECE60
	|-Array.InternalArray__IndexOf<KeyValuePair<object, AsyncOperationHandle>>
	|
	|-RVA: 0x39ED020 Offset: 0x39ED121 VA: 0x39ED020
	|-Array.InternalArray__IndexOf<KeyValuePair<object, bool>>
	|
	|-RVA: 0x39ED1D0 Offset: 0x39ED2D1 VA: 0x39ED1D0
	|-Array.InternalArray__IndexOf<KeyValuePair<object, byte>>
	|
	|-RVA: 0x39ED380 Offset: 0x39ED481 VA: 0x39ED380
	|-Array.InternalArray__IndexOf<KeyValuePair<object, int>>
	|
	|-RVA: 0x39ED530 Offset: 0x39ED631 VA: 0x39ED530
	|-Array.InternalArray__IndexOf<KeyValuePair<object, Int32Enum>>
	|
	|-RVA: 0x39ED6E0 Offset: 0x39ED7E1 VA: 0x39ED6E0
	|-Array.InternalArray__IndexOf<KeyValuePair<object, IntPtr>>
	|
	|-RVA: 0x39ED890 Offset: 0x39ED991 VA: 0x39ED890
	|-Array.InternalArray__IndexOf<KeyValuePair<object, object>>
	|
	|-RVA: 0x39EDA40 Offset: 0x39EDB41 VA: 0x39EDA40
	|-Array.InternalArray__IndexOf<KeyValuePair<object, Playable>>
	|
	|-RVA: 0x39EDC00 Offset: 0x39EDD01 VA: 0x39EDC00
	|-Array.InternalArray__IndexOf<KeyValuePair<object, ResourceLocator>>
	|
	|-RVA: 0x39EDDC0 Offset: 0x39EDEC1 VA: 0x39EDDC0
	|-Array.InternalArray__IndexOf<KeyValuePair<object, float>>
	|
	|-RVA: 0x39EDF70 Offset: 0x39EE071 VA: 0x39EDF70
	|-Array.InternalArray__IndexOf<KeyValuePair<object, ushort>>
	|
	|-RVA: 0x39EE120 Offset: 0x39EE221 VA: 0x39EE120
	|-Array.InternalArray__IndexOf<KeyValuePair<object, GameVariable.Value>>
	|
	|-RVA: 0x39EE2E0 Offset: 0x39EE3E1 VA: 0x39EE2E0
	|-Array.InternalArray__IndexOf<KeyValuePair<sbyte, DataStoreRatingInfo>>
	|
	|-RVA: 0x39EE4A0 Offset: 0x39EE5A1 VA: 0x39EE4A0
	|-Array.InternalArray__IndexOf<KeyValuePair<sbyte, object>>
	|
	|-RVA: 0x39EE650 Offset: 0x39EE751 VA: 0x39EE650
	|-Array.InternalArray__IndexOf<KeyValuePair<ushort, int>>
	|
	|-RVA: 0x39EE7F0 Offset: 0x39EE8F1 VA: 0x39EE7F0
	|-Array.InternalArray__IndexOf<KeyValuePair<uint, int>>
	|
	|-RVA: 0x39EE990 Offset: 0x39EEA91 VA: 0x39EE990
	|-Array.InternalArray__IndexOf<KeyValuePair<uint, object>>
	|
	|-RVA: 0x39EEB40 Offset: 0x39EEC41 VA: 0x39EEB40
	|-Array.InternalArray__IndexOf<KeyValuePair<ulong, Friend>>
	|
	|-RVA: 0x39EED10 Offset: 0x39EEE11 VA: 0x39EED10
	|-Array.InternalArray__IndexOf<KeyValuePair<ulong, Int32Enum>>
	|
	|-RVA: 0x39EEEC0 Offset: 0x39EEFC1 VA: 0x39EEEC0
	|-Array.InternalArray__IndexOf<KeyValuePair<ulong, object>>
	|
	|-RVA: 0x39EF070 Offset: 0x39EF171 VA: 0x39EF070
	|-Array.InternalArray__IndexOf<KeyValuePair<Vector3, int>>
	|
	|-RVA: 0x39EF220 Offset: 0x39EF321 VA: 0x39EF220
	|-Array.InternalArray__IndexOf<KeyValuePair<XPathNodeRef, XPathNodeRef>>
	|
	|-RVA: 0x39EF3E0 Offset: 0x39EF4E1 VA: 0x39EF3E0
	|-Array.InternalArray__IndexOf<KeyValuePair<TerrainUtility.TerrainMap.TileCoord, object>>
	|
	|-RVA: 0x39EF590 Offset: 0x39EF691 VA: 0x39EF590
	|-Array.InternalArray__IndexOf<NativeArray<PreTile>>
	|
	|-RVA: 0x39EF730 Offset: 0x39EF831 VA: 0x39EF730
	|-Array.InternalArray__IndexOf<CommonBattleSequence.Reliance<object>>
	|
	|-RVA: 0x39EF8F0 Offset: 0x39EF9F1 VA: 0x39EF8F0
	|-Array.InternalArray__IndexOf<RenderGraphResourcePool.ResourceLogInfo<object>>
	|
	|-RVA: 0x39EFAA0 Offset: 0x39EFBA1 VA: 0x39EFAA0
	|-Array.InternalArray__IndexOf<HashSet.Slot<ValueTuple<object, int>>>
	|
	|-RVA: 0x39EFC60 Offset: 0x39EFD61 VA: 0x39EFC60
	|-Array.InternalArray__IndexOf<HashSet.Slot<AsyncOperationHandle>>
	|
	|-RVA: 0x39EFE20 Offset: 0x39EFF21 VA: 0x39EFE20
	|-Array.InternalArray__IndexOf<HashSet.Slot<int>>
	|
	|-RVA: 0x39EFFE0 Offset: 0x39F00E1 VA: 0x39EFFE0
	|-Array.InternalArray__IndexOf<HashSet.Slot<Int32Enum>>
	|
	|-RVA: 0x39F01A0 Offset: 0x39F02A1 VA: 0x39F01A0
	|-Array.InternalArray__IndexOf<Set.Slot<Int32Enum>>
	|
	|-RVA: 0x39F0360 Offset: 0x39F0461 VA: 0x39F0360
	|-Array.InternalArray__IndexOf<HashSet.Slot<MapPos>>
	|
	|-RVA: 0x39F0510 Offset: 0x39F0611 VA: 0x39F0510
	|-Array.InternalArray__IndexOf<HashSet.Slot<object>>
	|
	|-RVA: 0x39F06C0 Offset: 0x39F07C1 VA: 0x39F06C0
	|-Array.InternalArray__IndexOf<Set.Slot<object>>
	|
	|-RVA: 0x39F0880 Offset: 0x39F0981 VA: 0x39F0880
	|-Array.InternalArray__IndexOf<HashSet.Slot<uint>>
	|
	|-RVA: 0x39F0A40 Offset: 0x39F0B41 VA: 0x39F0A40
	|-Array.InternalArray__IndexOf<HashSet.Slot<ulong>>
	|
	|-RVA: 0x39F0BF0 Offset: 0x39F0CF1 VA: 0x39F0BF0
	|-Array.InternalArray__IndexOf<Set.Slot<Vector3>>
	|
	|-RVA: 0x39F0DB0 Offset: 0x39F0EB1 VA: 0x39F0DB0
	|-Array.InternalArray__IndexOf<TMP_TextProcessingStack<Color32>>
	|
	|-RVA: 0x39F0F70 Offset: 0x39F1071 VA: 0x39F0F70
	|-Array.InternalArray__IndexOf<TMP_TextProcessingStack<HighlightState>>
	|
	|-RVA: 0x39F1140 Offset: 0x39F1241 VA: 0x39F1140
	|-Array.InternalArray__IndexOf<TMP_TextProcessingStack<int>>
	|
	|-RVA: 0x39F1300 Offset: 0x39F1401 VA: 0x39F1300
	|-Array.InternalArray__IndexOf<TMP_TextProcessingStack<Int32Enum>>
	|
	|-RVA: 0x39F14C0 Offset: 0x39F15C1 VA: 0x39F14C0
	|-Array.InternalArray__IndexOf<TMP_TextProcessingStack<MaterialReference>>
	|
	|-RVA: 0x39F16D0 Offset: 0x39F17D1 VA: 0x39F16D0
	|-Array.InternalArray__IndexOf<TMP_TextProcessingStack<object>>
	|
	|-RVA: 0x39F18A0 Offset: 0x39F19A1 VA: 0x39F18A0
	|-Array.InternalArray__IndexOf<TMP_TextProcessingStack<float>>
	|
	|-RVA: 0x39F1A60 Offset: 0x39F1B61 VA: 0x39F1A60
	|-Array.InternalArray__IndexOf<TMP_TextProcessingStack<WordWrapState>>
	|
	|-RVA: 0x39F1C30 Offset: 0x39F1D31 VA: 0x39F1C30
	|-Array.InternalArray__IndexOf<TimeInterval<object>>
	|
	|-RVA: 0x39F1DD0 Offset: 0x39F1ED1 VA: 0x39F1DD0
	|-Array.InternalArray__IndexOf<Timestamped<object>>
	|
	|-RVA: 0x39F1F90 Offset: 0x39F2091 VA: 0x39F1F90
	|-Array.InternalArray__IndexOf<UniTask<object>>
	|
	|-RVA: 0x39F2140 Offset: 0x39F2241 VA: 0x39F2140
	|-Array.InternalArray__IndexOf<ValueTuple<ValueTuple<bool, object>>>
	|
	|-RVA: 0x39F22E0 Offset: 0x39F23E1 VA: 0x39F22E0
	|-Array.InternalArray__IndexOf<ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>
	|
	|-RVA: 0x39F24A0 Offset: 0x39F25A1 VA: 0x39F24A0
	|-Array.InternalArray__IndexOf<ValueTuple<bool, UniTask<object>>>
	|
	|-RVA: 0x39F2660 Offset: 0x39F2761 VA: 0x39F2660
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>
	|
	|-RVA: 0x39F2820 Offset: 0x39F2921 VA: 0x39F2820
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>
	|
	|-RVA: 0x39F2A00 Offset: 0x39F2B01 VA: 0x39F2A00
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>
	|
	|-RVA: 0x39F2BE0 Offset: 0x39F2CE1 VA: 0x39F2BE0
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>
	|
	|-RVA: 0x39F2DA0 Offset: 0x39F2EA1 VA: 0x39F2DA0
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>
	|
	|-RVA: 0x39F2F60 Offset: 0x39F3061 VA: 0x39F2F60
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>
	|
	|-RVA: 0x39F3150 Offset: 0x39F3251 VA: 0x39F3150
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>
	|
	|-RVA: 0x39F3310 Offset: 0x39F3411 VA: 0x39F3310
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>
	|
	|-RVA: 0x39F34F0 Offset: 0x39F35F1 VA: 0x39F34F0
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>
	|
	|-RVA: 0x39F36D0 Offset: 0x39F37D1 VA: 0x39F36D0
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>
	|
	|-RVA: 0x39F3890 Offset: 0x39F3991 VA: 0x39F3890
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>
	|
	|-RVA: 0x39F3A70 Offset: 0x39F3B71 VA: 0x39F3A70
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x39F3C50 Offset: 0x39F3D51 VA: 0x39F3C50
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>
	|
	|-RVA: 0x39F3E30 Offset: 0x39F3F31 VA: 0x39F3E30
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>
	|
	|-RVA: 0x39F4010 Offset: 0x39F4111 VA: 0x39F4010
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>
	|
	|-RVA: 0x39F41D0 Offset: 0x39F42D1 VA: 0x39F41D0
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>
	|
	|-RVA: 0x39F43B0 Offset: 0x39F44B1 VA: 0x39F43B0
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>
	|
	|-RVA: 0x39F4570 Offset: 0x39F4671 VA: 0x39F4570
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>
	|
	|-RVA: 0x39F4750 Offset: 0x39F4851 VA: 0x39F4750
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>
	|
	|-RVA: 0x39F4910 Offset: 0x39F4A11 VA: 0x39F4910
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>
	|
	|-RVA: 0x39F4AF0 Offset: 0x39F4BF1 VA: 0x39F4AF0
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>
	|
	|-RVA: 0x39F4CD0 Offset: 0x39F4DD1 VA: 0x39F4CD0
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>
	|
	|-RVA: 0x39F4EB0 Offset: 0x39F4FB1 VA: 0x39F4EB0
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>
	|
	|-RVA: 0x39F50A0 Offset: 0x39F51A1 VA: 0x39F50A0
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>
	|
	|-RVA: 0x39F5290 Offset: 0x39F5391 VA: 0x39F5290
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>
	|
	|-RVA: 0x39F54A0 Offset: 0x39F55A1 VA: 0x39F54A0
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>
	|
	|-RVA: 0x39F56B0 Offset: 0x39F57B1 VA: 0x39F56B0
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>
	|
	|-RVA: 0x39F58E0 Offset: 0x39F59E1 VA: 0x39F58E0
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>
	|
	|-RVA: 0x39F5AA0 Offset: 0x39F5BA1 VA: 0x39F5AA0
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>
	|
	|-RVA: 0x39F5C60 Offset: 0x39F5D61 VA: 0x39F5C60
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>
	|
	|-RVA: 0x39F5E40 Offset: 0x39F5F41 VA: 0x39F5E40
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>
	|
	|-RVA: 0x39F6000 Offset: 0x39F6101 VA: 0x39F6000
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>
	|
	|-RVA: 0x39F61C0 Offset: 0x39F62C1 VA: 0x39F61C0
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>
	|
	|-RVA: 0x39F63A0 Offset: 0x39F64A1 VA: 0x39F63A0
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>
	|
	|-RVA: 0x39F6560 Offset: 0x39F6661 VA: 0x39F6560
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>
	|
	|-RVA: 0x39F6740 Offset: 0x39F6841 VA: 0x39F6740
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x39F6920 Offset: 0x39F6A21 VA: 0x39F6920
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>
	|
	|-RVA: 0x39F6AE0 Offset: 0x39F6BE1 VA: 0x39F6AE0
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>
	|
	|-RVA: 0x39F6CA0 Offset: 0x39F6DA1 VA: 0x39F6CA0
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>
	|
	|-RVA: 0x39F6E60 Offset: 0x39F6F61 VA: 0x39F6E60
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>
	|
	|-RVA: 0x39F7040 Offset: 0x39F7141 VA: 0x39F7040
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>
	|
	|-RVA: 0x39F7200 Offset: 0x39F7301 VA: 0x39F7200
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>
	|
	|-RVA: 0x39F73C0 Offset: 0x39F74C1 VA: 0x39F73C0
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>
	|
	|-RVA: 0x39F75A0 Offset: 0x39F76A1 VA: 0x39F75A0
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>
	|
	|-RVA: 0x39F7760 Offset: 0x39F7861 VA: 0x39F7760
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>
	|
	|-RVA: 0x39F7940 Offset: 0x39F7A41 VA: 0x39F7940
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>
	|
	|-RVA: 0x39F7B20 Offset: 0x39F7C21 VA: 0x39F7B20
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x39F7D10 Offset: 0x39F7E11 VA: 0x39F7D10
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>
	|
	|-RVA: 0x39F7EF0 Offset: 0x39F7FF1 VA: 0x39F7EF0
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x39F8100 Offset: 0x39F8201 VA: 0x39F8100
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>
	|
	|-RVA: 0x39F82F0 Offset: 0x39F83F1 VA: 0x39F82F0
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x39F8520 Offset: 0x39F8621 VA: 0x39F8520
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>
	|
	|-RVA: 0x39F8710 Offset: 0x39F8811 VA: 0x39F8710
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x39F8960 Offset: 0x39F8A61 VA: 0x39F8960
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>
	|
	|-RVA: 0x39F8B70 Offset: 0x39F8C71 VA: 0x39F8B70
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x39F8DD0 Offset: 0x39F8ED1 VA: 0x39F8DD0
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>
	|
	|-RVA: 0x39F8FE0 Offset: 0x39F90E1 VA: 0x39F8FE0
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>
	|
	|-RVA: 0x39F9170 Offset: 0x39F9271 VA: 0x39F9170
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>
	|
	|-RVA: 0x39F9300 Offset: 0x39F9401 VA: 0x39F9300
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>
	|
	|-RVA: 0x39F94E0 Offset: 0x39F95E1 VA: 0x39F94E0
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>
	|
	|-RVA: 0x39F9670 Offset: 0x39F9771 VA: 0x39F9670
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>
	|
	|-RVA: 0x39F9850 Offset: 0x39F9951 VA: 0x39F9850
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>
	|
	|-RVA: 0x39F9A10 Offset: 0x39F9B11 VA: 0x39F9A10
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>
	|
	|-RVA: 0x39F9BB0 Offset: 0x39F9CB1 VA: 0x39F9BB0
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>
	|
	|-RVA: 0x39F9D70 Offset: 0x39F9E71 VA: 0x39F9D70
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x39F9F30 Offset: 0x39FA031 VA: 0x39F9F30
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>
	|
	|-RVA: 0x39FA110 Offset: 0x39FA211 VA: 0x39FA110
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>
	|
	|-RVA: 0x39FA2F0 Offset: 0x39FA3F1 VA: 0x39FA2F0
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>
	|
	|-RVA: 0x39FA490 Offset: 0x39FA591 VA: 0x39FA490
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>
	|
	|-RVA: 0x39FA650 Offset: 0x39FA751 VA: 0x39FA650
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>
	|
	|-RVA: 0x39FA7E0 Offset: 0x39FA8E1 VA: 0x39FA7E0
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>
	|
	|-RVA: 0x39FA9A0 Offset: 0x39FAAA1 VA: 0x39FA9A0
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>
	|
	|-RVA: 0x39FAB60 Offset: 0x39FAC61 VA: 0x39FAB60
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>
	|
	|-RVA: 0x39FAD40 Offset: 0x39FAE41 VA: 0x39FAD40
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>
	|
	|-RVA: 0x39FAF00 Offset: 0x39FB001 VA: 0x39FAF00
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>
	|
	|-RVA: 0x39FB0C0 Offset: 0x39FB1C1 VA: 0x39FB0C0
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x3C17E90 Offset: 0x3C17F91 VA: 0x3C17E90
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>
	|
	|-RVA: 0x3C18070 Offset: 0x3C18171 VA: 0x3C18070
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x3C18280 Offset: 0x3C18381 VA: 0x3C18280
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>
	|
	|-RVA: 0x3C18460 Offset: 0x3C18561 VA: 0x3C18460
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x3C18690 Offset: 0x3C18791 VA: 0x3C18690
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>
	|
	|-RVA: 0x3C18880 Offset: 0x3C18981 VA: 0x3C18880
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x3C18AD0 Offset: 0x3C18BD1 VA: 0x3C18AD0
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>
	|
	|-RVA: 0x3C18CC0 Offset: 0x3C18DC1 VA: 0x3C18CC0
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x3C18F20 Offset: 0x3C19021 VA: 0x3C18F20
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>
	|
	|-RVA: 0x3C19130 Offset: 0x3C19231 VA: 0x3C19130
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x3C19310 Offset: 0x3C19411 VA: 0x3C19310
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x3C194F0 Offset: 0x3C195F1 VA: 0x3C194F0
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>
	|
	|-RVA: 0x3C196B0 Offset: 0x3C197B1 VA: 0x3C196B0
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, bool>>>
	|
	|-RVA: 0x3C19870 Offset: 0x3C19971 VA: 0x3C19870
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, Bounds>>>
	|
	|-RVA: 0x3C19A30 Offset: 0x3C19B31 VA: 0x3C19A30
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, byte>>>
	|
	|-RVA: 0x3C19BF0 Offset: 0x3C19CF1 VA: 0x3C19BF0
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, Color>>>
	|
	|-RVA: 0x3C19DB0 Offset: 0x3C19EB1 VA: 0x3C19DB0
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, double>>>
	|
	|-RVA: 0x3C19F70 Offset: 0x3C1A071 VA: 0x3C19F70
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, int>>>
	|
	|-RVA: 0x3C1A130 Offset: 0x3C1A231 VA: 0x3C1A130
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, long>>>
	|
	|-RVA: 0x3C1A2F0 Offset: 0x3C1A3F1 VA: 0x3C1A2F0
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, object>>>
	|
	|-RVA: 0x3C1A4B0 Offset: 0x3C1A5B1 VA: 0x3C1A4B0
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, Quaternion>>>
	|
	|-RVA: 0x3C1A670 Offset: 0x3C1A771 VA: 0x3C1A670
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, Rect>>>
	|
	|-RVA: 0x3C1A830 Offset: 0x3C1A931 VA: 0x3C1A830
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, float>>>
	|
	|-RVA: 0x3C1A9F0 Offset: 0x3C1AAF1 VA: 0x3C1A9F0
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, UniTask>>>
	|
	|-RVA: 0x3C1ABB0 Offset: 0x3C1ACB1 VA: 0x3C1ABB0
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, Unit>>>
	|
	|-RVA: 0x3C1AD70 Offset: 0x3C1AE71 VA: 0x3C1AD70
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, Vector2>>>
	|
	|-RVA: 0x3C1AF10 Offset: 0x3C1B011 VA: 0x3C1AF10
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, Vector3>>>
	|
	|-RVA: 0x3C1B0D0 Offset: 0x3C1B1D1 VA: 0x3C1B0D0
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<bool, Vector4>>>
	|
	|-RVA: 0x3C1B290 Offset: 0x3C1B391 VA: 0x3C1B290
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<int, object>>>
	|
	|-RVA: 0x3C1B450 Offset: 0x3C1B551 VA: 0x3C1B450
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<object, object>>>
	|
	|-RVA: 0x3C1B610 Offset: 0x3C1B711 VA: 0x3C1B610
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x3C1B7F0 Offset: 0x3C1B8F1 VA: 0x3C1B7F0
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<object, object, object>>>
	|
	|-RVA: 0x3C1B9B0 Offset: 0x3C1BAB1 VA: 0x3C1B9B0
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x3C1BBA0 Offset: 0x3C1BCA1 VA: 0x3C1BBA0
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<object, object, object, object>>>
	|
	|-RVA: 0x3C1BD80 Offset: 0x3C1BE81 VA: 0x3C1BD80
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x3C1BF90 Offset: 0x3C1C091 VA: 0x3C1BF90
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>
	|
	|-RVA: 0x3C1C170 Offset: 0x3C1C271 VA: 0x3C1C170
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x3C1C3A0 Offset: 0x3C1C4A1 VA: 0x3C1C3A0
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>
	|
	|-RVA: 0x3C1C590 Offset: 0x3C1C691 VA: 0x3C1C590
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x3C1C7E0 Offset: 0x3C1C8E1 VA: 0x3C1C7E0
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>
	|
	|-RVA: 0x3C1C9D0 Offset: 0x3C1CAD1 VA: 0x3C1C9D0
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x3C1CC30 Offset: 0x3C1CD31 VA: 0x3C1CC30
	|-Array.InternalArray__IndexOf<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x3C1CE10 Offset: 0x3C1CF11 VA: 0x3C1CE10
	|-Array.InternalArray__IndexOf<ValueTuple<bool, AsyncUnit>>
	|
	|-RVA: 0x3C1CFA0 Offset: 0x3C1D0A1 VA: 0x3C1CFA0
	|-Array.InternalArray__IndexOf<ValueTuple<bool, bool>>
	|
	|-RVA: 0x3C1D130 Offset: 0x3C1D231 VA: 0x3C1D130
	|-Array.InternalArray__IndexOf<ValueTuple<bool, Bounds>>
	|
	|-RVA: 0x3C1D310 Offset: 0x3C1D411 VA: 0x3C1D310
	|-Array.InternalArray__IndexOf<ValueTuple<bool, byte>>
	|
	|-RVA: 0x3C1D4A0 Offset: 0x3C1D5A1 VA: 0x3C1D4A0
	|-Array.InternalArray__IndexOf<ValueTuple<bool, Color>>
	|
	|-RVA: 0x3C1D660 Offset: 0x3C1D761 VA: 0x3C1D660
	|-Array.InternalArray__IndexOf<ValueTuple<bool, double>>
	|
	|-RVA: 0x3C1D800 Offset: 0x3C1D901 VA: 0x3C1D800
	|-Array.InternalArray__IndexOf<ValueTuple<bool, int>>
	|
	|-RVA: 0x3C1D990 Offset: 0x3C1DA91 VA: 0x3C1D990
	|-Array.InternalArray__IndexOf<ValueTuple<bool, long>>
	|
	|-RVA: 0x3C1DB30 Offset: 0x3C1DC31 VA: 0x3C1DB30
	|-Array.InternalArray__IndexOf<ValueTuple<bool, object>>
	|
	|-RVA: 0x3C1DCD0 Offset: 0x3C1DDD1 VA: 0x3C1DCD0
	|-Array.InternalArray__IndexOf<ValueTuple<bool, Quaternion>>
	|
	|-RVA: 0x3C1DE90 Offset: 0x3C1DF91 VA: 0x3C1DE90
	|-Array.InternalArray__IndexOf<ValueTuple<bool, Rect>>
	|
	|-RVA: 0x3C1E050 Offset: 0x3C1E151 VA: 0x3C1E050
	|-Array.InternalArray__IndexOf<ValueTuple<bool, float>>
	|
	|-RVA: 0x3C1E1E0 Offset: 0x3C1E2E1 VA: 0x3C1E1E0
	|-Array.InternalArray__IndexOf<ValueTuple<bool, UniTask>>
	|
	|-RVA: 0x3C1E380 Offset: 0x3C1E481 VA: 0x3C1E380
	|-Array.InternalArray__IndexOf<ValueTuple<bool, Unit>>
	|
	|-RVA: 0x3C1E510 Offset: 0x3C1E611 VA: 0x3C1E510
	|-Array.InternalArray__IndexOf<ValueTuple<bool, Vector2>>
	|
	|-RVA: 0x3C1E6D0 Offset: 0x3C1E7D1 VA: 0x3C1E6D0
	|-Array.InternalArray__IndexOf<ValueTuple<bool, Vector3>>
	|
	|-RVA: 0x3C1E870 Offset: 0x3C1E971 VA: 0x3C1E870
	|-Array.InternalArray__IndexOf<ValueTuple<bool, Vector4>>
	|
	|-RVA: 0x3C1EA30 Offset: 0x3C1EB31 VA: 0x3C1EA30
	|-Array.InternalArray__IndexOf<ValueTuple<int, bool>>
	|
	|-RVA: 0x3C1EBC0 Offset: 0x3C1ECC1 VA: 0x3C1EBC0
	|-Array.InternalArray__IndexOf<ValueTuple<int, Bounds>>
	|
	|-RVA: 0x3C1EDA0 Offset: 0x3C1EEA1 VA: 0x3C1EDA0
	|-Array.InternalArray__IndexOf<ValueTuple<int, byte>>
	|
	|-RVA: 0x3C1EF30 Offset: 0x3C1F031 VA: 0x3C1EF30
	|-Array.InternalArray__IndexOf<ValueTuple<int, Color>>
	|
	|-RVA: 0x3C1F0F0 Offset: 0x3C1F1F1 VA: 0x3C1F0F0
	|-Array.InternalArray__IndexOf<ValueTuple<int, double>>
	|
	|-RVA: 0x3C1F290 Offset: 0x3C1F391 VA: 0x3C1F290
	|-Array.InternalArray__IndexOf<ValueTuple<int, int>>
	|
	|-RVA: 0x3C1F420 Offset: 0x3C1F521 VA: 0x3C1F420
	|-Array.InternalArray__IndexOf<ValueTuple<int, long>>
	|
	|-RVA: 0x3C1F5C0 Offset: 0x3C1F6C1 VA: 0x3C1F5C0
	|-Array.InternalArray__IndexOf<ValueTuple<int, object>>
	|
	|-RVA: 0x3C1F760 Offset: 0x3C1F861 VA: 0x3C1F760
	|-Array.InternalArray__IndexOf<ValueTuple<int, Quaternion>>
	|
	|-RVA: 0x3C1F920 Offset: 0x3C1FA21 VA: 0x3C1F920
	|-Array.InternalArray__IndexOf<ValueTuple<int, Rect>>
	|
	|-RVA: 0x3C1FAE0 Offset: 0x3C1FBE1 VA: 0x3C1FAE0
	|-Array.InternalArray__IndexOf<ValueTuple<int, float>>
	|
	|-RVA: 0x3C1FC70 Offset: 0x3C1FD71 VA: 0x3C1FC70
	|-Array.InternalArray__IndexOf<ValueTuple<int, Unit>>
	|
	|-RVA: 0x3C1FE00 Offset: 0x3C1FF01 VA: 0x3C1FE00
	|-Array.InternalArray__IndexOf<ValueTuple<int, Vector2>>
	|
	|-RVA: 0x3C1FFC0 Offset: 0x3C200C1 VA: 0x3C1FFC0
	|-Array.InternalArray__IndexOf<ValueTuple<int, Vector3>>
	|
	|-RVA: 0x3C20160 Offset: 0x3C20261 VA: 0x3C20160
	|-Array.InternalArray__IndexOf<ValueTuple<int, Vector4>>
	|
	|-RVA: 0x3C20320 Offset: 0x3C20421 VA: 0x3C20320
	|-Array.InternalArray__IndexOf<ValueTuple<Int32Enum, int>>
	|
	|-RVA: 0x3C204B0 Offset: 0x3C205B1 VA: 0x3C204B0
	|-Array.InternalArray__IndexOf<ValueTuple<object, ValueTuple<object, int>>>
	|
	|-RVA: 0x3C20670 Offset: 0x3C20771 VA: 0x3C20670
	|-Array.InternalArray__IndexOf<ValueTuple<object, int>>
	|
	|-RVA: 0x3C20810 Offset: 0x3C20911 VA: 0x3C20810
	|-Array.InternalArray__IndexOf<ValueTuple<object, object>>
	|
	|-RVA: 0x3C209B0 Offset: 0x3C20AB1 VA: 0x3C209B0
	|-Array.InternalArray__IndexOf<ValueTuple<object, float>>
	|
	|-RVA: 0x3C20B50 Offset: 0x3C20C51 VA: 0x3C20B50
	|-Array.InternalArray__IndexOf<ValueTuple<Vector3, float>>
	|
	|-RVA: 0x3C20D10 Offset: 0x3C20E11 VA: 0x3C20D10
	|-Array.InternalArray__IndexOf<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>
	|
	|-RVA: 0x3C20EF0 Offset: 0x3C20FF1 VA: 0x3C20EF0
	|-Array.InternalArray__IndexOf<ValueTuple<object, Int32Enum, int>>
	|
	|-RVA: 0x3C21090 Offset: 0x3C21191 VA: 0x3C21090
	|-Array.InternalArray__IndexOf<ValueTuple<object, object, object>>
	|
	|-RVA: 0x3C21250 Offset: 0x3C21351 VA: 0x3C21250
	|-Array.InternalArray__IndexOf<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>
	|
	|-RVA: 0x3C21440 Offset: 0x3C21541 VA: 0x3C21440
	|-Array.InternalArray__IndexOf<ValueTuple<object, int, int, int>>
	|
	|-RVA: 0x3C21600 Offset: 0x3C21701 VA: 0x3C21600
	|-Array.InternalArray__IndexOf<ValueTuple<object, object, object, object>>
	|
	|-RVA: 0x3C217C0 Offset: 0x3C218C1 VA: 0x3C217C0
	|-Array.InternalArray__IndexOf<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>
	|
	|-RVA: 0x3C219D0 Offset: 0x3C21AD1 VA: 0x3C219D0
	|-Array.InternalArray__IndexOf<ValueTuple<object, object, object, object, object>>
	|
	|-RVA: 0x3C21BB0 Offset: 0x3C21CB1 VA: 0x3C21BB0
	|-Array.InternalArray__IndexOf<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>
	|
	|-RVA: 0x3C21DE0 Offset: 0x3C21EE1 VA: 0x3C21DE0
	|-Array.InternalArray__IndexOf<ValueTuple<object, object, object, object, object, object>>
	|
	|-RVA: 0x3C21FC0 Offset: 0x3C220C1 VA: 0x3C21FC0
	|-Array.InternalArray__IndexOf<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>
	|
	|-RVA: 0x3C22210 Offset: 0x3C22311 VA: 0x3C22210
	|-Array.InternalArray__IndexOf<ValueTuple<object, object, object, object, object, object, object>>
	|
	|-RVA: 0x3C22400 Offset: 0x3C22501 VA: 0x3C22400
	|-Array.InternalArray__IndexOf<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>
	|
	|-RVA: 0x3C22660 Offset: 0x3C22761 VA: 0x3C22660
	|-Array.InternalArray__IndexOf<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x3C22840 Offset: 0x3C22941 VA: 0x3C22840
	|-Array.InternalArray__IndexOf<AnimatorClipInfo>
	|
	|-RVA: 0x3C229E0 Offset: 0x3C22AE1 VA: 0x3C229E0
	|-Array.InternalArray__IndexOf<AsyncOperationHandle>
	|
	|-RVA: 0x3C22BA0 Offset: 0x3C22CA1 VA: 0x3C22BA0
	|-Array.InternalArray__IndexOf<AsyncUnit>
	|
	|-RVA: 0x3C22D40 Offset: 0x3C22E41 VA: 0x3C22D40
	|-Array.InternalArray__IndexOf<BatchVisibility>
	|
	|-RVA: 0x3C22F00 Offset: 0x3C23001 VA: 0x3C22F00
	|-Array.InternalArray__IndexOf<BoneWeight>
	|
	|-RVA: 0x3C23070 Offset: 0x3C23171 VA: 0x3C23070
	|-Array.InternalArray__IndexOf<BoneWeight1>
	|
	|-RVA: 0x3C231D0 Offset: 0x3C232D1 VA: 0x3C231D0
	|-Array.InternalArray__IndexOf<bool>
	|
	|-RVA: 0x3C23320 Offset: 0x3C23421 VA: 0x3C23320
	|-Array.InternalArray__IndexOf<Bounds>
	|
	|-RVA: 0x3C23490 Offset: 0x3C23591 VA: 0x3C23490
	|-Array.InternalArray__IndexOf<byte>
	|
	|-RVA: 0x3C235E0 Offset: 0x3C236E1 VA: 0x3C235E0
	|-Array.InternalArray__IndexOf<ByteEnum>
	|
	|-RVA: 0x3C23770 Offset: 0x3C23871 VA: 0x3C23770
	|-Array.InternalArray__IndexOf<CameraInfo>
	|
	|-RVA: 0x3C23920 Offset: 0x3C23A21 VA: 0x3C23920
	|-Array.InternalArray__IndexOf<CancellationToken>
	|
	|-RVA: 0x3C23A80 Offset: 0x3C23B81 VA: 0x3C23A80
	|-Array.InternalArray__IndexOf<CancellationTokenRegistration>
	|
	|-RVA: 0x3C23BF0 Offset: 0x3C23CF1 VA: 0x3C23BF0
	|-Array.InternalArray__IndexOf<char>
	|
	|-RVA: 0x3C23D40 Offset: 0x3C23E41 VA: 0x3C23D40
	|-Array.InternalArray__IndexOf<ClusteringData>
	|
	|-RVA: 0x3C23EB0 Offset: 0x3C23FB1 VA: 0x3C23EB0
	|-Array.InternalArray__IndexOf<ClusteringProcessorState>
	|
	|-RVA: 0x3C24080 Offset: 0x3C24181 VA: 0x3C24080
	|-Array.InternalArray__IndexOf<Color>
	|
	|-RVA: 0x3C241F0 Offset: 0x3C242F1 VA: 0x3C241F0
	|-Array.InternalArray__IndexOf<Color32>
	|
	|-RVA: 0x3C24390 Offset: 0x3C24491 VA: 0x3C24390
	|-Array.InternalArray__IndexOf<Color4u8>
	|
	|-RVA: 0x3C244E0 Offset: 0x3C245E1 VA: 0x3C244E0
	|-Array.InternalArray__IndexOf<ColorBlock>
	|
	|-RVA: 0x3C24680 Offset: 0x3C24781 VA: 0x3C24680
	|-Array.InternalArray__IndexOf<CombineInstance>
	|
	|-RVA: 0x3C248A0 Offset: 0x3C249A1 VA: 0x3C248A0
	|-Array.InternalArray__IndexOf<ConstraintSource>
	|
	|-RVA: 0x3C24A50 Offset: 0x3C24B51 VA: 0x3C24A50
	|-Array.InternalArray__IndexOf<ContactPoint>
	|
	|-RVA: 0x3C24C30 Offset: 0x3C24D31 VA: 0x3C24C30
	|-Array.InternalArray__IndexOf<ContactPoint2D>
	|
	|-RVA: 0x3C24E10 Offset: 0x3C24F11 VA: 0x3C24E10
	|-Array.InternalArray__IndexOf<ContourVertex>
	|
	|-RVA: 0x3C24FD0 Offset: 0x3C250D1 VA: 0x3C24FD0
	|-Array.InternalArray__IndexOf<CustomAttributeNamedArgument>
	|
	|-RVA: 0x3C25140 Offset: 0x3C25241 VA: 0x3C25140
	|-Array.InternalArray__IndexOf<CustomAttributeTypedArgument>
	|
	|-RVA: 0x3C252A0 Offset: 0x3C253A1 VA: 0x3C252A0
	|-Array.InternalArray__IndexOf<DataStoreRatingInfo>
	|
	|-RVA: 0x3C25460 Offset: 0x3C25561 VA: 0x3C25460
	|-Array.InternalArray__IndexOf<DataStoreResult>
	|
	|-RVA: 0x3C25600 Offset: 0x3C25701 VA: 0x3C25600
	|-Array.InternalArray__IndexOf<DateTime>
	|
	|-RVA: 0x3C25760 Offset: 0x3C25861 VA: 0x3C25760
	|-Array.InternalArray__IndexOf<DateTimeOffset>
	|
	|-RVA: 0x3C258C0 Offset: 0x3C259C1 VA: 0x3C258C0
	|-Array.InternalArray__IndexOf<DebugPadState>
	|
	|-RVA: 0x3C25A80 Offset: 0x3C25B81 VA: 0x3C25A80
	|-Array.InternalArray__IndexOf<Decimal>
	|
	|-RVA: 0x3C25BE0 Offset: 0x3C25CE1 VA: 0x3C25BE0
	|-Array.InternalArray__IndexOf<DeferredTiler>
	|
	|-RVA: 0x3C25E20 Offset: 0x3C25F21 VA: 0x3C25E20
	|-Array.InternalArray__IndexOf<DeviceHandle>
	|
	|-RVA: 0x3C25FD0 Offset: 0x3C260D1 VA: 0x3C25FD0
	|-Array.InternalArray__IndexOf<DiagnosticEvent>
	|
	|-RVA: 0x3C261A0 Offset: 0x3C262A1 VA: 0x3C261A0
	|-Array.InternalArray__IndexOf<DictionaryEntry>
	|
	|-RVA: 0x3C26350 Offset: 0x3C26451 VA: 0x3C26350
	|-Array.InternalArray__IndexOf<DictionaryInfo>
	|
	|-RVA: 0x3C264B0 Offset: 0x3C265B1 VA: 0x3C264B0
	|-Array.InternalArray__IndexOf<DirectoryEntry>
	|
	|-RVA: 0x3C26670 Offset: 0x3C26771 VA: 0x3C26670
	|-Array.InternalArray__IndexOf<double>
	|
	|-RVA: 0x3C267D0 Offset: 0x3C268D1 VA: 0x3C267D0
	|-Array.InternalArray__IndexOf<Ephemeron>
	|
	|-RVA: 0x3C26980 Offset: 0x3C26A81 VA: 0x3C26980
	|-Array.InternalArray__IndexOf<FXZ>
	|
	|-RVA: 0x3C26AE0 Offset: 0x3C26BE1 VA: 0x3C26AE0
	|-Array.InternalArray__IndexOf<Finger>
	|
	|-RVA: 0x3C26C50 Offset: 0x3C26D51 VA: 0x3C26C50
	|-Array.InternalArray__IndexOf<Float2>
	|
	|-RVA: 0x3C26DB0 Offset: 0x3C26EB1 VA: 0x3C26DB0
	|-Array.InternalArray__IndexOf<Friend>
	|
	|-RVA: 0x3C26F80 Offset: 0x3C27081 VA: 0x3C26F80
	|-Array.InternalArray__IndexOf<GCHandle>
	|
	|-RVA: 0x3C270E0 Offset: 0x3C271E1 VA: 0x3C270E0
	|-Array.InternalArray__IndexOf<GesturePoint>
	|
	|-RVA: 0x3C27240 Offset: 0x3C27341 VA: 0x3C27240
	|-Array.InternalArray__IndexOf<GestureState>
	|
	|-RVA: 0x3C27450 Offset: 0x3C27551 VA: 0x3C27450
	|-Array.InternalArray__IndexOf<GlyphMarshallingStruct>
	|
	|-RVA: 0x3C27620 Offset: 0x3C27721 VA: 0x3C27620
	|-Array.InternalArray__IndexOf<GlyphPairAdjustmentRecord>
	|
	|-RVA: 0x3C27800 Offset: 0x3C27901 VA: 0x3C27800
	|-Array.InternalArray__IndexOf<GlyphRect>
	|
	|-RVA: 0x3C27960 Offset: 0x3C27A61 VA: 0x3C27960
	|-Array.InternalArray__IndexOf<Guid>
	|
	|-RVA: 0x3C27AC0 Offset: 0x3C27BC1 VA: 0x3C27AC0
	|-Array.InternalArray__IndexOf<Hand>
	|
	|-RVA: 0x3C27C40 Offset: 0x3C27D41 VA: 0x3C27C40
	|-Array.InternalArray__IndexOf<HandAnalysisImageState>
	|
	|-RVA: 0x3C27DF0 Offset: 0x3C27EF1 VA: 0x3C27DF0
	|-Array.InternalArray__IndexOf<HandAnalysisSilhouetteState>
	|
	|-RVA: 0x3C27FC0 Offset: 0x3C280C1 VA: 0x3C27FC0
	|-Array.InternalArray__IndexOf<HeaderVariantInfo>
	|
	|-RVA: 0x3C28170 Offset: 0x3C28271 VA: 0x3C28170
	|-Array.InternalArray__IndexOf<HighlightState>
	|
	|-RVA: 0x3C282E0 Offset: 0x3C283E1 VA: 0x3C282E0
	|-Array.InternalArray__IndexOf<HumanBone>
	|
	|-RVA: 0x3C284C0 Offset: 0x3C285C1 VA: 0x3C284C0
	|-Array.InternalArray__IndexOf<short>
	|
	|-RVA: 0x3C28610 Offset: 0x3C28711 VA: 0x3C28610
	|-Array.InternalArray__IndexOf<int>
	|
	|-RVA: 0x3C28760 Offset: 0x3C28861 VA: 0x3C28760
	|-Array.InternalArray__IndexOf<Int32Enum>
	|
	|-RVA: 0x3C288F0 Offset: 0x3C289F1 VA: 0x3C288F0
	|-Array.InternalArray__IndexOf<long>
	|
	|-RVA: 0x3C28A50 Offset: 0x3C28B51 VA: 0x3C28A50
	|-Array.InternalArray__IndexOf<Int64Enum>
	|
	|-RVA: 0x3C28BE0 Offset: 0x3C28CE1 VA: 0x3C28BE0
	|-Array.InternalArray__IndexOf<IntPtr>
	|
	|-RVA: 0x3C28D40 Offset: 0x3C28E41 VA: 0x3C28D40
	|-Array.InternalArray__IndexOf<InternalCodePageDataItem>
	|
	|-RVA: 0x3C28EF0 Offset: 0x3C28FF1 VA: 0x3C28EF0
	|-Array.InternalArray__IndexOf<InternalEncodingDataItem>
	|
	|-RVA: 0x3C290A0 Offset: 0x3C291A1 VA: 0x3C290A0
	|-Array.InternalArray__IndexOf<InterpretedFrameInfo>
	|
	|-RVA: 0x3C29250 Offset: 0x3C29351 VA: 0x3C29250
	|-Array.InternalArray__IndexOf<IntervalTreeNode>
	|
	|-RVA: 0x3C29410 Offset: 0x3C29511 VA: 0x3C29410
	|-Array.InternalArray__IndexOf<JobHandle>
	|
	|-RVA: 0x3C295C0 Offset: 0x3C296C1 VA: 0x3C295C0
	|-Array.InternalArray__IndexOf<Keyframe>
	|
	|-RVA: 0x3C29790 Offset: 0x3C29891 VA: 0x3C29790
	|-Array.InternalArray__IndexOf<LOD>
	|
	|-RVA: 0x3C29940 Offset: 0x3C29A41 VA: 0x3C29940
	|-Array.InternalArray__IndexOf<LayerMask>
	|
	|-RVA: 0x3C29AE0 Offset: 0x3C29BE1 VA: 0x3C29AE0
	|-Array.InternalArray__IndexOf<LengthLimitProperties>
	|
	|-RVA: 0x3C29C80 Offset: 0x3C29D81 VA: 0x3C29C80
	|-Array.InternalArray__IndexOf<Light2DBlendStyle>
	|
	|-RVA: 0x3C29E70 Offset: 0x3C29F71 VA: 0x3C29E70
	|-Array.InternalArray__IndexOf<LightDataGI>
	|
	|-RVA: 0x3C2A080 Offset: 0x3C2A181 VA: 0x3C2A080
	|-Array.InternalArray__IndexOf<LocalDefinition>
	|
	|-RVA: 0x3C2A1E0 Offset: 0x3C2A2E1 VA: 0x3C2A1E0
	|-Array.InternalArray__IndexOf<MapPos>
	|
	|-RVA: 0x3C2A340 Offset: 0x3C2A441 VA: 0x3C2A340
	|-Array.InternalArray__IndexOf<MapRange>
	|
	|-RVA: 0x3C2A500 Offset: 0x3C2A601 VA: 0x3C2A500
	|-Array.InternalArray__IndexOf<MaterialReference>
	|
	|-RVA: 0x3C2A6E0 Offset: 0x3C2A7E1 VA: 0x3C2A6E0
	|-Array.InternalArray__IndexOf<Matrix4x4>
	|
	|-RVA: 0x3C2A860 Offset: 0x3C2A961 VA: 0x3C2A860
	|-Array.InternalArray__IndexOf<MomentProcessorState>
	|
	|-RVA: 0x3C2AA30 Offset: 0x3C2AB31 VA: 0x3C2AA30
	|-Array.InternalArray__IndexOf<MomentStatistic>
	|
	|-RVA: 0x3C2ABA0 Offset: 0x3C2ACA1 VA: 0x3C2ABA0
	|-Array.InternalArray__IndexOf<Navigation>
	|
	|-RVA: 0x3C2AD70 Offset: 0x3C2AE71 VA: 0x3C2AD70
	|-Array.InternalArray__IndexOf<NetworkServiceAccountId>
	|
	|-RVA: 0x3C2AED0 Offset: 0x3C2AFD1 VA: 0x3C2AED0
	|-Array.InternalArray__IndexOf<NpadFullKeyState>
	|
	|-RVA: 0x3C2B0A0 Offset: 0x3C2B1A1 VA: 0x3C2B0A0
	|-Array.InternalArray__IndexOf<NpadHandheldState>
	|
	|-RVA: 0x3C2B270 Offset: 0x3C2B371 VA: 0x3C2B270
	|-Array.InternalArray__IndexOf<NpadJoyDualState>
	|
	|-RVA: 0x3C2B440 Offset: 0x3C2B541 VA: 0x3C2B440
	|-Array.InternalArray__IndexOf<NpadJoyLeftState>
	|
	|-RVA: 0x3C2B610 Offset: 0x3C2B711 VA: 0x3C2B610
	|-Array.InternalArray__IndexOf<NpadJoyRightState>
	|
	|-RVA: 0x3C2B7E0 Offset: 0x3C2B8E1 VA: 0x3C2B7E0
	|-Array.InternalArray__IndexOf<NpadStateArrayItem>
	|
	|-RVA: 0x3C2B9B0 Offset: 0x3C2BAB1 VA: 0x3C2B9B0
	|-Array.InternalArray__IndexOf<NsUid>
	|
	|-RVA: 0x3C2BB10 Offset: 0x3C2BC11 VA: 0x3C2BB10
	|-Array.InternalArray__IndexOf<object>
	|
	|-RVA: 0x3C2BC90 Offset: 0x3C2BD91 VA: 0x3C2BC90
	|-Array.InternalArray__IndexOf<ObjectInitializationData>
	|
	|-RVA: 0x3C2BE60 Offset: 0x3C2BF61 VA: 0x3C2BE60
	|-Array.InternalArray__IndexOf<ParameterModifier>
	|
	|-RVA: 0x3C2C000 Offset: 0x3C2C101 VA: 0x3C2C000
	|-Array.InternalArray__IndexOf<Plane>
	|
	|-RVA: 0x3C2C1C0 Offset: 0x3C2C2C1 VA: 0x3C2C1C0
	|-Array.InternalArray__IndexOf<Playable>
	|
	|-RVA: 0x3C2C370 Offset: 0x3C2C471 VA: 0x3C2C370
	|-Array.InternalArray__IndexOf<PlayableBinding>
	|
	|-RVA: 0x3C2C530 Offset: 0x3C2C631 VA: 0x3C2C530
	|-Array.InternalArray__IndexOf<PlayerLoopSystem>
	|
	|-RVA: 0x3C2C700 Offset: 0x3C2C801 VA: 0x3C2C700
	|-Array.InternalArray__IndexOf<PlayerLoopSystemInternal>
	|
	|-RVA: 0x3C2C8D0 Offset: 0x3C2C9D1 VA: 0x3C2C8D0
	|-Array.InternalArray__IndexOf<PreTile>
	|
	|-RVA: 0x3C2CAB0 Offset: 0x3C2CBB1 VA: 0x3C2CAB0
	|-Array.InternalArray__IndexOf<Profile>
	|
	|-RVA: 0x3C2CCB0 Offset: 0x3C2CDB1 VA: 0x3C2CCB0
	|-Array.InternalArray__IndexOf<Protrusion>
	|
	|-RVA: 0x3C2CE10 Offset: 0x3C2CF11 VA: 0x3C2CE10
	|-Array.InternalArray__IndexOf<Quaternion>
	|
	|-RVA: 0x3C2CF80 Offset: 0x3C2D081 VA: 0x3C2CF80
	|-Array.InternalArray__IndexOf<RandomSeed>
	|
	|-RVA: 0x3C2D130 Offset: 0x3C2D231 VA: 0x3C2D130
	|-Array.InternalArray__IndexOf<RangePositionInfo>
	|
	|-RVA: 0x3C2D2E0 Offset: 0x3C2D3E1 VA: 0x3C2D2E0
	|-Array.InternalArray__IndexOf<Ranking2ChartInfoInput>
	|
	|-RVA: 0x3C2D480 Offset: 0x3C2D581 VA: 0x3C2D480
	|-Array.InternalArray__IndexOf<RaycastHit>
	|
	|-RVA: 0x3C2D660 Offset: 0x3C2D761 VA: 0x3C2D660
	|-Array.InternalArray__IndexOf<RaycastHit2D>
	|
	|-RVA: 0x3C2D840 Offset: 0x3C2D941 VA: 0x3C2D840
	|-Array.InternalArray__IndexOf<RaycastResult>
	|
	|-RVA: 0x3C2DA30 Offset: 0x3C2DB31 VA: 0x3C2DA30
	|-Array.InternalArray__IndexOf<Rect>
	|
	|-RVA: 0x3C2DBA0 Offset: 0x3C2DCA1 VA: 0x3C2DBA0
	|-Array.InternalArray__IndexOf<RenderBuffer>
	|
	|-RVA: 0x3C2DD50 Offset: 0x3C2DE51 VA: 0x3C2DD50
	|-Array.InternalArray__IndexOf<RenderStateBlock>
	|
	|-RVA: 0x3C2DF00 Offset: 0x3C2E001 VA: 0x3C2DF00
	|-Array.InternalArray__IndexOf<RenderTargetHandle>
	|
	|-RVA: 0x3C2E070 Offset: 0x3C2E171 VA: 0x3C2E070
	|-Array.InternalArray__IndexOf<RenderTargetIdentifier>
	|
	|-RVA: 0x3C2E1E0 Offset: 0x3C2E2E1 VA: 0x3C2E1E0
	|-Array.InternalArray__IndexOf<RendererListHandle>
	|
	|-RVA: 0x3C2E380 Offset: 0x3C2E481 VA: 0x3C2E380
	|-Array.InternalArray__IndexOf<ResourceHandle>
	|
	|-RVA: 0x3C2E520 Offset: 0x3C2E621 VA: 0x3C2E520
	|-Array.InternalArray__IndexOf<ResourceLocator>
	|
	|-RVA: 0x3C2E6D0 Offset: 0x3C2E7D1 VA: 0x3C2E6D0
	|-Array.InternalArray__IndexOf<RichTextTagAttribute>
	|
	|-RVA: 0x3C2E890 Offset: 0x3C2E991 VA: 0x3C2E890
	|-Array.InternalArray__IndexOf<RuntimeLabel>
	|
	|-RVA: 0x3C2EA50 Offset: 0x3C2EB51 VA: 0x3C2EA50
	|-Array.InternalArray__IndexOf<sbyte>
	|
	|-RVA: 0x3C2EBA0 Offset: 0x3C2ECA1 VA: 0x3C2EBA0
	|-Array.InternalArray__IndexOf<SerializedType>
	|
	|-RVA: 0x3C2ED60 Offset: 0x3C2EE61 VA: 0x3C2ED60
	|-Array.InternalArray__IndexOf<ShaderKeyword>
	|
	|-RVA: 0x3C2EF00 Offset: 0x3C2F001 VA: 0x3C2EF00
	|-Array.InternalArray__IndexOf<ShaderTagId>
	|
	|-RVA: 0x36E5530 Offset: 0x36E5631 VA: 0x36E5530
	|-Array.InternalArray__IndexOf<ShadowSliceData>
	|
	|-RVA: 0x36E5720 Offset: 0x36E5821 VA: 0x36E5720
	|-Array.InternalArray__IndexOf<Shape>
	|
	|-RVA: 0x36E5890 Offset: 0x36E5991 VA: 0x36E5890
	|-Array.InternalArray__IndexOf<float>
	|
	|-RVA: 0x36E59E0 Offset: 0x36E5AE1 VA: 0x36E59E0
	|-Array.InternalArray__IndexOf<SixAxisSensorHandle>
	|
	|-RVA: 0x36E5B80 Offset: 0x36E5C81 VA: 0x36E5B80
	|-Array.InternalArray__IndexOf<SixAxisSensorState>
	|
	|-RVA: 0x36E5D90 Offset: 0x36E5E91 VA: 0x36E5D90
	|-Array.InternalArray__IndexOf<SkeletonBone>
	|
	|-RVA: 0x36E5F70 Offset: 0x36E6071 VA: 0x36E5F70
	|-Array.InternalArray__IndexOf<SortingLayer>
	|
	|-RVA: 0x36E6110 Offset: 0x36E6211 VA: 0x36E6110
	|-Array.InternalArray__IndexOf<SphericalHarmonicsL2>
	|
	|-RVA: 0x36E62C0 Offset: 0x36E63C1 VA: 0x36E62C0
	|-Array.InternalArray__IndexOf<SpinLock>
	|
	|-RVA: 0x36E6460 Offset: 0x36E6561 VA: 0x36E6460
	|-Array.InternalArray__IndexOf<SpringBoneComponents>
	|
	|-RVA: 0x36E6660 Offset: 0x36E6761 VA: 0x36E6660
	|-Array.InternalArray__IndexOf<SpringBoneProperties>
	|
	|-RVA: 0x36E6850 Offset: 0x36E6951 VA: 0x36E6850
	|-Array.InternalArray__IndexOf<SpringColliderComponents>
	|
	|-RVA: 0x36E6A90 Offset: 0x36E6B91 VA: 0x36E6A90
	|-Array.InternalArray__IndexOf<SpringColliderProperties>
	|
	|-RVA: 0x36E6C40 Offset: 0x36E6D41 VA: 0x36E6C40
	|-Array.InternalArray__IndexOf<SpringForceComponent>
	|
	|-RVA: 0x36E6E20 Offset: 0x36E6F21 VA: 0x36E6E20
	|-Array.InternalArray__IndexOf<SpringJobElement>
	|
	|-RVA: 0x36E7010 Offset: 0x36E7111 VA: 0x36E7010
	|-Array.InternalArray__IndexOf<SpriteState>
	|
	|-RVA: 0x36E71D0 Offset: 0x36E72D1 VA: 0x36E71D0
	|-Array.InternalArray__IndexOf<SubMeshDescriptor>
	|
	|-RVA: 0x36E73A0 Offset: 0x36E74A1 VA: 0x36E73A0
	|-Array.InternalArray__IndexOf<TMP_CharacterInfo>
	|
	|-RVA: 0x36E7570 Offset: 0x36E7671 VA: 0x36E7570
	|-Array.InternalArray__IndexOf<TMP_FontWeightPair>
	|
	|-RVA: 0x36E7720 Offset: 0x36E7821 VA: 0x36E7720
	|-Array.InternalArray__IndexOf<TMP_LineInfo>
	|
	|-RVA: 0x36E7940 Offset: 0x36E7A41 VA: 0x36E7940
	|-Array.InternalArray__IndexOf<TMP_LinkInfo>
	|
	|-RVA: 0x36E7B10 Offset: 0x36E7C11 VA: 0x36E7B10
	|-Array.InternalArray__IndexOf<TMP_MeshInfo>
	|
	|-RVA: 0x36E7D00 Offset: 0x36E7E01 VA: 0x36E7D00
	|-Array.InternalArray__IndexOf<TMP_PageInfo>
	|
	|-RVA: 0x36E7EC0 Offset: 0x36E7FC1 VA: 0x36E7EC0
	|-Array.InternalArray__IndexOf<TMP_WordInfo>
	|
	|-RVA: 0x36E8080 Offset: 0x36E8181 VA: 0x36E8080
	|-Array.InternalArray__IndexOf<TablePair>
	|
	|-RVA: 0x36E8230 Offset: 0x36E8331 VA: 0x36E8230
	|-Array.InternalArray__IndexOf<TextureHandle>
	|
	|-RVA: 0x36E83D0 Offset: 0x36E84D1 VA: 0x36E83D0
	|-Array.InternalArray__IndexOf<TimeSpan>
	|
	|-RVA: 0x36E8530 Offset: 0x36E8631 VA: 0x36E8530
	|-Array.InternalArray__IndexOf<Touch>
	|
	|-RVA: 0x36E8730 Offset: 0x36E8831 VA: 0x36E8730
	|-Array.InternalArray__IndexOf<TouchScreenState1>
	|
	|-RVA: 0x36E8910 Offset: 0x36E8A11 VA: 0x36E8910
	|-Array.InternalArray__IndexOf<TouchScreenState10>
	|
	|-RVA: 0x36E8AE0 Offset: 0x36E8BE1 VA: 0x36E8AE0
	|-Array.InternalArray__IndexOf<TouchScreenState11>
	|
	|-RVA: 0x36E8CB0 Offset: 0x36E8DB1 VA: 0x36E8CB0
	|-Array.InternalArray__IndexOf<TouchScreenState12>
	|
	|-RVA: 0x36E8E80 Offset: 0x36E8F81 VA: 0x36E8E80
	|-Array.InternalArray__IndexOf<TouchScreenState13>
	|
	|-RVA: 0x36E9050 Offset: 0x36E9151 VA: 0x36E9050
	|-Array.InternalArray__IndexOf<TouchScreenState14>
	|
	|-RVA: 0x36E9220 Offset: 0x36E9321 VA: 0x36E9220
	|-Array.InternalArray__IndexOf<TouchScreenState15>
	|
	|-RVA: 0x36E93F0 Offset: 0x36E94F1 VA: 0x36E93F0
	|-Array.InternalArray__IndexOf<TouchScreenState16>
	|
	|-RVA: 0x36E95C0 Offset: 0x36E96C1 VA: 0x36E95C0
	|-Array.InternalArray__IndexOf<TouchScreenState2>
	|
	|-RVA: 0x36E97D0 Offset: 0x36E98D1 VA: 0x36E97D0
	|-Array.InternalArray__IndexOf<TouchScreenState3>
	|
	|-RVA: 0x36E99B0 Offset: 0x36E9AB1 VA: 0x36E99B0
	|-Array.InternalArray__IndexOf<TouchScreenState4>
	|
	|-RVA: 0x36E9BA0 Offset: 0x36E9CA1 VA: 0x36E9BA0
	|-Array.InternalArray__IndexOf<TouchScreenState5>
	|
	|-RVA: 0x36E9D90 Offset: 0x36E9E91 VA: 0x36E9D90
	|-Array.InternalArray__IndexOf<TouchScreenState6>
	|
	|-RVA: 0x36E9F90 Offset: 0x36EA091 VA: 0x36E9F90
	|-Array.InternalArray__IndexOf<TouchScreenState7>
	|
	|-RVA: 0x36EA160 Offset: 0x36EA261 VA: 0x36EA160
	|-Array.InternalArray__IndexOf<TouchScreenState8>
	|
	|-RVA: 0x36EA330 Offset: 0x36EA431 VA: 0x36EA330
	|-Array.InternalArray__IndexOf<TouchScreenState9>
	|
	|-RVA: 0x36EA500 Offset: 0x36EA601 VA: 0x36EA500
	|-Array.InternalArray__IndexOf<TouchState>
	|
	|-RVA: 0x36EA670 Offset: 0x36EA771 VA: 0x36EA670
	|-Array.InternalArray__IndexOf<TrailHand>
	|
	|-RVA: 0x36EA830 Offset: 0x36EA931 VA: 0x36EA830
	|-Array.InternalArray__IndexOf<TrailVertex>
	|
	|-RVA: 0x36EA9F0 Offset: 0x36EAAF1 VA: 0x36EA9F0
	|-Array.InternalArray__IndexOf<UICharInfo>
	|
	|-RVA: 0x36EABC0 Offset: 0x36EACC1 VA: 0x36EABC0
	|-Array.InternalArray__IndexOf<UILineInfo>
	|
	|-RVA: 0x36EAD70 Offset: 0x36EAE71 VA: 0x36EAD70
	|-Array.InternalArray__IndexOf<UIVertex>
	|
	|-RVA: 0x36EAFB0 Offset: 0x36EB0B1 VA: 0x36EAFB0
	|-Array.InternalArray__IndexOf<ushort>
	|
	|-RVA: 0x36EB100 Offset: 0x36EB201 VA: 0x36EB100
	|-Array.InternalArray__IndexOf<UInt16Enum>
	|
	|-RVA: 0x36EB290 Offset: 0x36EB391 VA: 0x36EB290
	|-Array.InternalArray__IndexOf<uint>
	|
	|-RVA: 0x36EB3E0 Offset: 0x36EB4E1 VA: 0x36EB3E0
	|-Array.InternalArray__IndexOf<UInt32Enum>
	|
	|-RVA: 0x36EB570 Offset: 0x36EB671 VA: 0x36EB570
	|-Array.InternalArray__IndexOf<ulong>
	|
	|-RVA: 0x36EB6D0 Offset: 0x36EB7D1 VA: 0x36EB6D0
	|-Array.InternalArray__IndexOf<Uid>
	|
	|-RVA: 0x36EB830 Offset: 0x36EB931 VA: 0x36EB830
	|-Array.InternalArray__IndexOf<UniTask>
	|
	|-RVA: 0x36EB9D0 Offset: 0x36EBAD1 VA: 0x36EB9D0
	|-Array.InternalArray__IndexOf<Unit>
	|
	|-RVA: 0x36EBB30 Offset: 0x36EBC31 VA: 0x36EBB30
	|-Array.InternalArray__IndexOf<UnitEnum>
	|
	|-RVA: 0x36EBCD0 Offset: 0x36EBDD1 VA: 0x36EBCD0
	|-Array.InternalArray__IndexOf<UserWord>
	|
	|-RVA: 0x36EBE80 Offset: 0x36EBF81 VA: 0x36EBE80
	|-Array.InternalArray__IndexOf<Vector2>
	|
	|-RVA: 0x36EBFE0 Offset: 0x36EC0E1 VA: 0x36EBFE0
	|-Array.InternalArray__IndexOf<Vector2Int>
	|
	|-RVA: 0x36EC1A0 Offset: 0x36EC2A1 VA: 0x36EC1A0
	|-Array.InternalArray__IndexOf<Vector3>
	|
	|-RVA: 0x36EC310 Offset: 0x36EC411 VA: 0x36EC310
	|-Array.InternalArray__IndexOf<Vector4>
	|
	|-RVA: 0x36EC480 Offset: 0x36EC581 VA: 0x36EC480
	|-Array.InternalArray__IndexOf<VertexAttributeDescriptor>
	|
	|-RVA: 0x36EC5E0 Offset: 0x36EC6E1 VA: 0x36EC5E0
	|-Array.InternalArray__IndexOf<VibrationDeviceHandle>
	|
	|-RVA: 0x36EC780 Offset: 0x36EC881 VA: 0x36EC780
	|-Array.InternalArray__IndexOf<VibrationDeviceInfo>
	|
	|-RVA: 0x36EC920 Offset: 0x36ECA21 VA: 0x36EC920
	|-Array.InternalArray__IndexOf<VibrationValue>
	|
	|-RVA: 0x36ECAE0 Offset: 0x36ECBE1 VA: 0x36ECAE0
	|-Array.InternalArray__IndexOf<VisibleLight>
	|
	|-RVA: 0x36ECCA0 Offset: 0x36ECDA1 VA: 0x36ECCA0
	|-Array.InternalArray__IndexOf<WordWrapState>
	|
	|-RVA: 0x36ECE70 Offset: 0x36ECF71 VA: 0x36ECE70
	|-Array.InternalArray__IndexOf<X509ChainStatus>
	|
	|-RVA: 0x36ED020 Offset: 0x36ED121 VA: 0x36ED020
	|-Array.InternalArray__IndexOf<XPathNode>
	|
	|-RVA: 0x36ED1E0 Offset: 0x36ED2E1 VA: 0x36ED1E0
	|-Array.InternalArray__IndexOf<XPathNodeRef>
	|
	|-RVA: 0x36ED390 Offset: 0x36ED491 VA: 0x36ED390
	|-Array.InternalArray__IndexOf<XRView>
	|
	|-RVA: 0x36ED570 Offset: 0x36ED671 VA: 0x36ED570
	|-Array.InternalArray__IndexOf<float3>
	|
	|-RVA: 0x36ED6E0 Offset: 0x36ED7E1 VA: 0x36ED6E0
	|-Array.InternalArray__IndexOf<float4x4>
	|
	|-RVA: 0x36ED860 Offset: 0x36ED961 VA: 0x36ED860
	|-Array.InternalArray__IndexOf<jvalue>
	|
	|-RVA: 0x36EDA00 Offset: 0x36EDB01 VA: 0x36EDA00
	|-Array.InternalArray__IndexOf<uint4>
	|
	|-RVA: 0x36EDB60 Offset: 0x36EDC61 VA: 0x36EDB60
	|-Array.InternalArray__IndexOf<AICrossfire.PositionTable>
	|
	|-RVA: 0x36EDD10 Offset: 0x36EDE11 VA: 0x36EDD10
	|-Array.InternalArray__IndexOf<AIEnum.SkillRangeEnemyData>
	|
	|-RVA: 0x36EDEC0 Offset: 0x36EDFC1 VA: 0x36EDEC0
	|-Array.InternalArray__IndexOf<AIOrder.UnitPriority>
	|
	|-RVA: 0x36EE060 Offset: 0x36EE161 VA: 0x36EE060
	|-Array.InternalArray__IndexOf<AmiiboSequence.GainItemData>
	|
	|-RVA: 0x36EE210 Offset: 0x36EE311 VA: 0x36EE210
	|-Array.InternalArray__IndexOf<AnimationOutputWeightProcessor.WeightInfo>
	|
	|-RVA: 0x36EE3E0 Offset: 0x36EE4E1 VA: 0x36EE3E0
	|-Array.InternalArray__IndexOf<ArenaOrderSequence.GodInfo>
	|
	|-RVA: 0x36EE590 Offset: 0x36EE691 VA: 0x36EE590
	|-Array.InternalArray__IndexOf<BattleInfo.SupportData>
	|
	|-RVA: 0x36EE740 Offset: 0x36EE841 VA: 0x36EE740
	|-Array.InternalArray__IndexOf<BeforeRenderHelper.OrderBlock>
	|
	|-RVA: 0x36EE8F0 Offset: 0x36EE9F1 VA: 0x36EE8F0
	|-Array.InternalArray__IndexOf<Camera.RenderRequest>
	|
	|-RVA: 0x36EEAB0 Offset: 0x36EEBB1 VA: 0x36EEAB0
	|-Array.InternalArray__IndexOf<CameraState.CustomBlendable>
	|
	|-RVA: 0x36EEC60 Offset: 0x36EED61 VA: 0x36EEC60
	|-Array.InternalArray__IndexOf<CinemachineBlendListCamera.Instruction>
	|
	|-RVA: 0x36EEE20 Offset: 0x36EEF21 VA: 0x36EEE20
	|-Array.InternalArray__IndexOf<CinemachineBlenderSettings.CustomBlend>
	|
	|-RVA: 0x36EEFE0 Offset: 0x36EF0E1 VA: 0x36EEFE0
	|-Array.InternalArray__IndexOf<CinemachineClearShot.Pair>
	|
	|-RVA: 0x36EF180 Offset: 0x36EF281 VA: 0x36EF180
	|-Array.InternalArray__IndexOf<CinemachineFreeLook.Orbit>
	|
	|-RVA: 0x36EF330 Offset: 0x36EF431 VA: 0x36EF330
	|-Array.InternalArray__IndexOf<CinemachinePath.Waypoint>
	|
	|-RVA: 0x36EF500 Offset: 0x36EF601 VA: 0x36EF500
	|-Array.InternalArray__IndexOf<CinemachineSmoothPath.Waypoint>
	|
	|-RVA: 0x36EF6C0 Offset: 0x36EF7C1 VA: 0x36EF6C0
	|-Array.InternalArray__IndexOf<CinemachineStateDrivenCamera.HashPair>
	|
	|-RVA: 0x36EF860 Offset: 0x36EF961 VA: 0x36EF860
	|-Array.InternalArray__IndexOf<CinemachineStateDrivenCamera.Instruction>
	|
	|-RVA: 0x36EFA20 Offset: 0x36EFB21 VA: 0x36EFA20
	|-Array.InternalArray__IndexOf<CinemachineStateDrivenCamera.ParentHash>
	|
	|-RVA: 0x36EFBC0 Offset: 0x36EFCC1 VA: 0x36EFBC0
	|-Array.InternalArray__IndexOf<CinemachineTargetGroup.Target>
	|
	|-RVA: 0x36EFD70 Offset: 0x36EFE71 VA: 0x36EFD70
	|-Array.InternalArray__IndexOf<CodePointIndexer.TableRange>
	|
	|-RVA: 0x36EFF30 Offset: 0x36F0031 VA: 0x36EFF30
	|-Array.InternalArray__IndexOf<ContentCatalogData.Bucket>
	|
	|-RVA: 0x36F00E0 Offset: 0x36F01E1 VA: 0x36F00E0
	|-Array.InternalArray__IndexOf<CookieTokenizer.RecognizedAttribute>
	|
	|-RVA: 0x36F0290 Offset: 0x36F0391 VA: 0x36F0290
	|-Array.InternalArray__IndexOf<DeferredLights.DrawCall>
	|
	|-RVA: 0x36F0460 Offset: 0x36F0561 VA: 0x36F0460
	|-Array.InternalArray__IndexOf<DeferredShaderData.ComputeBufferInfo>
	|
	|-RVA: 0x36F0600 Offset: 0x36F0701 VA: 0x36F0600
	|-Array.InternalArray__IndexOf<DeferredTiler.PrePunctualLight>
	|
	|-RVA: 0x36F07C0 Offset: 0x36F08C1 VA: 0x36F07C0
	|-Array.InternalArray__IndexOf<DelayedActionManager.DelegateInfo>
	|
	|-RVA: 0x36F0980 Offset: 0x36F0A81 VA: 0x36F0980
	|-Array.InternalArray__IndexOf<Detail.AsyncResultInt>
	|
	|-RVA: 0x36F0B50 Offset: 0x36F0C51 VA: 0x36F0B50
	|-Array.InternalArray__IndexOf<Detail.CppArray>
	|
	|-RVA: 0x36F0D00 Offset: 0x36F0E01 VA: 0x36F0D00
	|-Array.InternalArray__IndexOf<Detail.NotificationEventInt>
	|
	|-RVA: 0x36F0ED0 Offset: 0x36F0FD1 VA: 0x36F0ED0
	|-Array.InternalArray__IndexOf<DisposUnit.Item>
	|
	|-RVA: 0x36F1080 Offset: 0x36F1181 VA: 0x36F1080
	|-Array.InternalArray__IndexOf<DragonRidePresetParamData.CourseData>
	|
	|-RVA: 0x36F1240 Offset: 0x36F1341 VA: 0x36F1240
	|-Array.InternalArray__IndexOf<DragonRideTargetGroup.ChainParam>
	|
	|-RVA: 0x36F13F0 Offset: 0x36F14F1 VA: 0x36F13F0
	|-Array.InternalArray__IndexOf<DynamicMesh.State>
	|
	|-RVA: 0x36F1590 Offset: 0x36F1691 VA: 0x36F1590
	|-Array.InternalArray__IndexOf<FXZEx.HitPoint>
	|
	|-RVA: 0x36F1760 Offset: 0x36F1861 VA: 0x36F1760
	|-Array.InternalArray__IndexOf<FishingRadicalParamData.RadicalParam>
	|
	|-RVA: 0x36F1930 Offset: 0x36F1A31 VA: 0x36F1930
	|-Array.InternalArray__IndexOf<GameVariable.Value>
	|
	|-RVA: 0x36F1AE0 Offset: 0x36F1BE1 VA: 0x36F1AE0
	|-Array.InternalArray__IndexOf<GmapPathAdjuster.TargetModel>
	|
	|-RVA: 0x36F1CA0 Offset: 0x36F1DA1 VA: 0x36F1CA0
	|-Array.InternalArray__IndexOf<GmapSpotAdjuster.TargetModel>
	|
	|-RVA: 0x36F1E60 Offset: 0x36F1F61 VA: 0x36F1E60
	|-Array.InternalArray__IndexOf<GrounderQuadruped.Foot>
	|
	|-RVA: 0x36F2030 Offset: 0x36F2131 VA: 0x36F2030
	|-Array.InternalArray__IndexOf<Hashtable.bucket>
	|
	|-RVA: 0x36F21F0 Offset: 0x36F22F1 VA: 0x36F21F0
	|-Array.InternalArray__IndexOf<HeadingTracker.Item>
	|
	|-RVA: 0x36F23B0 Offset: 0x36F24B1 VA: 0x36F23B0
	|-Array.InternalArray__IndexOf<HubAccessoryRoomCamera.BackgroundSettings>
	|
	|-RVA: 0x36F2580 Offset: 0x36F2681 VA: 0x36F2580
	|-Array.InternalArray__IndexOf<HubFastTravel.Location>
	|
	|-RVA: 0x36F2740 Offset: 0x36F2841 VA: 0x36F2740
	|-Array.InternalArray__IndexOf<HubLensFlare.Flare>
	|
	|-RVA: 0x36F2910 Offset: 0x36F2A11 VA: 0x36F2910
	|-Array.InternalArray__IndexOf<HubLookAtController.LookAtIKParam>
	|
	|-RVA: 0x36F2AE0 Offset: 0x36F2BE1 VA: 0x36F2AE0
	|-Array.InternalArray__IndexOf<HubMaterialArray.MaterialInfo>
	|
	|-RVA: 0x36F2C90 Offset: 0x36F2D91 VA: 0x36F2C90
	|-Array.InternalArray__IndexOf<IKSolverLimb.AxisDirection>
	|
	|-RVA: 0x36F2E60 Offset: 0x36F2F61 VA: 0x36F2E60
	|-Array.InternalArray__IndexOf<InventoryPoolItemMenuContent.KindBgNameClass>
	|
	|-RVA: 0x36F3010 Offset: 0x36F3111 VA: 0x36F3010
	|-Array.InternalArray__IndexOf<LightUtility.ParametricLightMeshVertex>
	|
	|-RVA: 0x36F31E0 Offset: 0x36F32E1 VA: 0x36F31E0
	|-Array.InternalArray__IndexOf<LightUtility.SpriteLightMeshVertex>
	|
	|-RVA: 0x36F33C0 Offset: 0x36F34C1 VA: 0x36F33C0
	|-Array.InternalArray__IndexOf<Map.Pos>
	|
	|-RVA: 0x36F3560 Offset: 0x36F3661 VA: 0x36F3560
	|-Array.InternalArray__IndexOf<MapGodExp.KindDesc>
	|
	|-RVA: 0x36F3710 Offset: 0x36F3811 VA: 0x36F3710
	|-Array.InternalArray__IndexOf<MapHistory.Command>
	|
	|-RVA: 0x36F38B0 Offset: 0x36F39B1 VA: 0x36F38B0
	|-Array.InternalArray__IndexOf<MapImage.BackupTerrain>
	|
	|-RVA: 0x36F3A60 Offset: 0x36F3B61 VA: 0x36F3A60
	|-Array.InternalArray__IndexOf<MapImageRange.Pos>
	|
	|-RVA: 0x36F3C00 Offset: 0x36F3D01 VA: 0x36F3C00
	|-Array.InternalArray__IndexOf<MapKillBonus.KillBonus>
	|
	|-RVA: 0x36F3DA0 Offset: 0x36F3EA1 VA: 0x36F3DA0
	|-Array.InternalArray__IndexOf<MapKillBonus.KilledBonus>
	|
	|-RVA: 0x36F3F40 Offset: 0x36F4041 VA: 0x36F3F40
	|-Array.InternalArray__IndexOf<MapMind.Record>
	|
	|-RVA: 0x36F4130 Offset: 0x36F4231 VA: 0x36F4130
	|-Array.InternalArray__IndexOf<MapMind.Target>
	|
	|-RVA: 0x36F42F0 Offset: 0x36F43F1 VA: 0x36F42F0
	|-Array.InternalArray__IndexOf<MapPanelDebug.Entity>
	|
	|-RVA: 0x36F44B0 Offset: 0x36F45B1 VA: 0x36F44B0
	|-Array.InternalArray__IndexOf<NexRanking.Data>
	|
	|-RVA: 0x36F4650 Offset: 0x36F4751 VA: 0x36F4650
	|-Array.InternalArray__IndexOf<NexVersus.RatingData>
	|
	|-RVA: 0x36F4800 Offset: 0x36F4901 VA: 0x36F4800
	|-Array.InternalArray__IndexOf<NoiseSettings.TransformNoiseParams>
	|
	|-RVA: 0x36F49E0 Offset: 0x36F4AE1 VA: 0x36F49E0
	|-Array.InternalArray__IndexOf<PackedPlayModeBuildLogs.RuntimeBuildLog>
	|
	|-RVA: 0x36F4B90 Offset: 0x36F4C91 VA: 0x36F4B90
	|-Array.InternalArray__IndexOf<ParameterizedStrings.FormatParam>
	|
	|-RVA: 0x36F4D40 Offset: 0x36F4E41 VA: 0x36F4D40
	|-Array.InternalArray__IndexOf<ParticleSystem.Particle>
	|
	|-RVA: 0x36F4F20 Offset: 0x36F5021 VA: 0x36F4F20
	|-Array.InternalArray__IndexOf<ProfileCard.Achievement>
	|
	|-RVA: 0x36F50C0 Offset: 0x36F51C1 VA: 0x36F50C0
	|-Array.InternalArray__IndexOf<ProfileCard.SortieCount>
	|
	|-RVA: 0x36F5280 Offset: 0x36F5381 VA: 0x36F5280
	|-Array.InternalArray__IndexOf<QualitySettingsStack.Settings>
	|
	|-RVA: 0x36F5450 Offset: 0x36F5551 VA: 0x36F5450
	|-Array.InternalArray__IndexOf<RangeData.Offset>
	|
	|-RVA: 0x36F55F0 Offset: 0x36F56F1 VA: 0x36F55F0
	|-Array.InternalArray__IndexOf<RegexCharClass.LowerCaseMapping>
	|
	|-RVA: 0x36F57B0 Offset: 0x36F58B1 VA: 0x36F57B0
	|-Array.InternalArray__IndexOf<Relay.ChooseAwardeeData>
	|
	|-RVA: 0x36F5970 Offset: 0x36F5A71 VA: 0x36F5970
	|-Array.InternalArray__IndexOf<RelayAwardData.Info>
	|
	|-RVA: 0x36F5B20 Offset: 0x36F5C21 VA: 0x36F5B20
	|-Array.InternalArray__IndexOf<RenderGraph.CompiledPassInfo>
	|
	|-RVA: 0x36F5D10 Offset: 0x36F5E11 VA: 0x36F5D10
	|-Array.InternalArray__IndexOf<RenderGraph.CompiledResourceInfo>
	|
	|-RVA: 0x36F5ED0 Offset: 0x36F5FD1 VA: 0x36F5ED0
	|-Array.InternalArray__IndexOf<RenderGraphDebugData.PassDebugData>
	|
	|-RVA: 0x36F6090 Offset: 0x36F6191 VA: 0x36F6090
	|-Array.InternalArray__IndexOf<RenderGraphDebugData.ResourceDebugData>
	|
	|-RVA: 0x36F6260 Offset: 0x36F6361 VA: 0x36F6260
	|-Array.InternalArray__IndexOf<RenderGraphResourceRegistry.RendererListResource>
	|
	|-RVA: 0x36F6430 Offset: 0x36F6531 VA: 0x36F6430
	|-Array.InternalArray__IndexOf<RingCleaningUnitSelectMenu.GodParam>
	|
	|-RVA: 0x36F65E0 Offset: 0x36F66E1 VA: 0x36F65E0
	|-Array.InternalArray__IndexOf<SampleWave.Data>
	|
	|-RVA: 0x36F67A0 Offset: 0x36F68A1 VA: 0x36F67A0
	|-Array.InternalArray__IndexOf<SampleWave.Temp>
	|
	|-RVA: 0x36F6950 Offset: 0x36F6A51 VA: 0x36F6950
	|-Array.InternalArray__IndexOf<SendMouseEvents.HitInfo>
	|
	|-RVA: 0x36F6B00 Offset: 0x36F6C01 VA: 0x36F6B00
	|-Array.InternalArray__IndexOf<SequenceNode.SequenceConstructPosContext>
	|
	|-RVA: 0x36F6CD0 Offset: 0x36F6DD1 VA: 0x36F6CD0
	|-Array.InternalArray__IndexOf<ShaderInput.LightData>
	|
	|-RVA: 0x36F6EC0 Offset: 0x36F6FC1 VA: 0x36F6EC0
	|-Array.InternalArray__IndexOf<ShaderInput.ShadowData>
	|
	|-RVA: 0x36F70B0 Offset: 0x36F71B1 VA: 0x36F70B0
	|-Array.InternalArray__IndexOf<ShadowUtility.Edge>
	|
	|-RVA: 0x36F7280 Offset: 0x36F7381 VA: 0x36F7280
	|-Array.InternalArray__IndexOf<SimpleAnimationPlayable.QueuedState>
	|
	|-RVA: 0x36F7430 Offset: 0x36F7531 VA: 0x36F7430
	|-Array.InternalArray__IndexOf<SkillArray.Entity>
	|
	|-RVA: 0x36F75D0 Offset: 0x36F76D1 VA: 0x36F75D0
	|-Array.InternalArray__IndexOf<Socket.WSABUF>
	|
	|-RVA: 0x36F7780 Offset: 0x36F7881 VA: 0x36F7780
	|-Array.InternalArray__IndexOf<Stream.Info>
	|
	|-RVA: 0x36F7940 Offset: 0x36F7A41 VA: 0x36F7940
	|-Array.InternalArray__IndexOf<TMP_Text.UnicodeChar>
	|
	|-RVA: 0x36F7B00 Offset: 0x36F7C01 VA: 0x36F7B00
	|-Array.InternalArray__IndexOf<TexturePacker_JsonArray.Frame>
	|
	|-RVA: 0x36F7CE0 Offset: 0x36F7DE1 VA: 0x36F7CE0
	|-Array.InternalArray__IndexOf<TimeNotificationBehaviour.NotificationEntry>
	|
	|-RVA: 0x36F7EA0 Offset: 0x36F7FA1 VA: 0x36F7EA0
	|-Array.InternalArray__IndexOf<UnitySynchronizationContext.WorkRequest>
	|
	|-RVA: 0x36F8060 Offset: 0x36F8161 VA: 0x36F8060
	|-Array.InternalArray__IndexOf<XmlNamespaceManager.NamespaceDeclaration>
	|
	|-RVA: 0x36F8220 Offset: 0x36F8321 VA: 0x36F8220
	|-Array.InternalArray__IndexOf<XmlSchemaObjectTable.XmlSchemaObjectEntry>
	|
	|-RVA: 0x36F83D0 Offset: 0x36F84D1 VA: 0x36F83D0
	|-Array.InternalArray__IndexOf<XmlTextReaderImpl.ParsingState>
	|
	|-RVA: 0x36F8610 Offset: 0x36F8711 VA: 0x36F8610
	|-Array.InternalArray__IndexOf<AIThink.EnchantThink.Desc>
	|
	|-RVA: 0x36F87C0 Offset: 0x36F88C1 VA: 0x36F87C0
	|-Array.InternalArray__IndexOf<AIThink.EnchantThink.ItemInfo>
	|
	|-RVA: 0x36F8960 Offset: 0x36F8A61 VA: 0x36F8960
	|-Array.InternalArray__IndexOf<AIThink.EnchantThink.SurroundingInfo>
	|
	|-RVA: 0x36F8B00 Offset: 0x36F8C01 VA: 0x36F8B00
	|-Array.InternalArray__IndexOf<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>
	|
	|-RVA: 0x36F8CB0 Offset: 0x36F8DB1 VA: 0x36F8CB0
	|-Array.InternalArray__IndexOf<Detail.DataStore.DataStoreChangeMetaParamInt>
	|
	|-RVA: 0x36F8EB0 Offset: 0x36F8FB1 VA: 0x36F8EB0
	|-Array.InternalArray__IndexOf<Detail.DataStore.DataStoreDeleteParamInt>
	|
	|-RVA: 0x36F9060 Offset: 0x36F9161 VA: 0x36F9060
	|-Array.InternalArray__IndexOf<Detail.DataStore.DataStoreGetMetaParamInt>
	|
	|-RVA: 0x36F9230 Offset: 0x36F9331 VA: 0x36F9230
	|-Array.InternalArray__IndexOf<Detail.DataStore.DataStoreMetaInfoInt>
	|
	|-RVA: 0x36F9420 Offset: 0x36F9521 VA: 0x36F9420
	|-Array.InternalArray__IndexOf<Detail.DataStore.DataStorePasswordInfoInt>
	|
	|-RVA: 0x36F95E0 Offset: 0x36F96E1 VA: 0x36F95E0
	|-Array.InternalArray__IndexOf<Detail.DataStore.DataStorePersistenceInfoInt>
	|
	|-RVA: 0x36F97A0 Offset: 0x36F98A1 VA: 0x36F97A0
	|-Array.InternalArray__IndexOf<Detail.DataStore.DataStorePreparePostParamInt>
	|
	|-RVA: 0x36F9980 Offset: 0x36F9A81 VA: 0x36F9980
	|-Array.InternalArray__IndexOf<Detail.DataStore.DataStoreRateObjectParamInt>
	|
	|-RVA: 0x36F9B30 Offset: 0x36F9C31 VA: 0x36F9B30
	|-Array.InternalArray__IndexOf<Detail.DataStore.DataStoreRatingInitParamInt>
	|
	|-RVA: 0x36F9CF0 Offset: 0x36F9DF1 VA: 0x36F9CF0
	|-Array.InternalArray__IndexOf<Detail.DataStore.DataStoreRatingTargetInt>
	|
	|-RVA: 0x36F9EA0 Offset: 0x36F9FA1 VA: 0x36F9EA0
	|-Array.InternalArray__IndexOf<Detail.Ranking.RankingCachedResultInt>
	|
	|-RVA: 0x36FA080 Offset: 0x36FA181 VA: 0x36FA080
	|-Array.InternalArray__IndexOf<Detail.Ranking.RankingOrderParamInt>
	|
	|-RVA: 0x36FA230 Offset: 0x36FA331 VA: 0x36FA230
	|-Array.InternalArray__IndexOf<Detail.Ranking.RankingRankDataInt>
	|
	|-RVA: 0x36FA410 Offset: 0x36FA511 VA: 0x36FA410
	|-Array.InternalArray__IndexOf<Detail.Ranking2.Ranking2ChartInfoInt>
	|
	|-RVA: 0x36FA620 Offset: 0x36FA721 VA: 0x36FA620
	|-Array.InternalArray__IndexOf<Detail.Ranking2.Ranking2RankDataInt>
	|
	|-RVA: 0x36FA800 Offset: 0x36FA901 VA: 0x36FA800
	|-Array.InternalArray__IndexOf<Detail.Ranking2.Ranking2ScoreDataInt>
	|
	|-RVA: 0x36FA9B0 Offset: 0x36FAAB1 VA: 0x36FA9B0
	|-Array.InternalArray__IndexOf<Detail.Screening.ScreeningContextInfoInt>
	|
	|-RVA: 0x36FAB70 Offset: 0x36FAC71 VA: 0x36FAB70
	|-Array.InternalArray__IndexOf<Detail.Subscriber.SubscriberContentInt>
	|
	|-RVA: 0x36FAD60 Offset: 0x36FAE61 VA: 0x36FAD60
	|-Array.InternalArray__IndexOf<Detail.Subscriber.SubscriberGetContentParamInt>
	|
	|-RVA: 0x36FAF20 Offset: 0x36FB021 VA: 0x36FAF20
	|-Array.InternalArray__IndexOf<Detail.Subscriber.SubscriberUserStatusInfoInt>
	|
	|-RVA: 0x36FB0F0 Offset: 0x36FB1F1 VA: 0x36FB0F0
	|-Array.InternalArray__IndexOf<Detail.Subscriber.SubscriberUserStatusParamInt>
	|
	|-RVA: 0x36FB2B0 Offset: 0x36FB3B1 VA: 0x36FB2B0
	|-Array.InternalArray__IndexOf<Detail.Utility.IntegerSettings>
	|
	|-RVA: 0x36FB450 Offset: 0x36FB551 VA: 0x36FB450
	|-Array.InternalArray__IndexOf<Detail.Utility.UniqueIdInfoInt>
	|
	|-RVA: 0x36FB600 Offset: 0x36FB701 VA: 0x36FB600
	|-Array.InternalArray__IndexOf<FacetsChecker.FacetsCompiler.Map>
	|
	|-RVA: 0x36FB7B0 Offset: 0x36FB8B1 VA: 0x36FB7B0
	|-Array.InternalArray__IndexOf<MapHistory.ReplayAppearanceMap.Appearance>
	|
	|-RVA: 0x36FB970 Offset: 0x36FBA71 VA: 0x36FB970
	|-Array.InternalArray__IndexOf<MapHistory.ReplayAppearanceMap.Leaving>
	|
	|-RVA: 0x36FBB10 Offset: 0x36FBC11 VA: 0x36FBB10
	|-Array.InternalArray__IndexOf<MapHistory.ReplayUnitMap.Data>
	|
	|-RVA: 0x36FBCB0 Offset: 0x36FBDB1 VA: 0x36FBCB0
	|-Array.InternalArray__IndexOf<MapHistory.Rewind.LatestInspectorData>
	|
	|-RVA: 0x36FBE60 Offset: 0x36FBF61 VA: 0x36FBE60
	|-Array.InternalArray__IndexOf<MapHistory.Rewind.WorkTerrainData>
	|
	|-RVA: 0x36FC010 Offset: 0x36FC111 VA: 0x36FC010
	|-Array.InternalArray__IndexOf<MapHistory.RewindUnitMap.Data>
	|
	|-RVA: 0x36FC1E0 Offset: 0x36FC2E1 VA: 0x36FC1E0
	|-Array.InternalArray__IndexOf<MapKillBonus.Work.Pos>
	|
	|-RVA: 0x36FC380 Offset: 0x36FC481 VA: 0x36FC380
	|-Array.InternalArray__IndexOf<MapSkill.AroundCalculator.Result>
	|
	|-RVA: 0x36FC530 Offset: 0x36FC631 VA: 0x36FC530
	|-Array.InternalArray__IndexOf<Nex.ApiCallChecker.Guideline>
	|
	|-RVA: 0x36FC6D0 Offset: 0x36FC7D1 VA: 0x36FC6D0
	|-Array.InternalArray__IndexOf<Ngc.MaskTextSequenceBase.Data>
	|
	|-RVA: 0x36FC890 Offset: 0x36FC991 VA: 0x36FC890
	|-Array.InternalArray__IndexOf<TargetPositionCache.CacheCurve.Item>
	|
	|-RVA: 0x36FCA60 Offset: 0x36FCB61 VA: 0x36FCA60
	|-Array.InternalArray__IndexOf<TargetPositionCache.CacheEntry.RecordingItem>
	|
	|-RVA: 0x36FCC40 Offset: 0x36FCD41 VA: 0x36FCC40
	|-Array.InternalArray__IndexOf<TerrainUtility.TerrainMap.TileCoord>
	*/

	// RVA: -1 Offset: -1
	internal T InternalArray__get_Item<T>(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x218CA40 Offset: 0x218CB41 VA: 0x218CA40
	|-Array.InternalArray__get_Item<ArraySegment<byte>>
	|
	|-RVA: 0x218CAF0 Offset: 0x218CBF1 VA: 0x218CAF0
	|-Array.InternalArray__get_Item<AsyncOperationHandle<object>>
	|
	|-RVA: 0x218CBB0 Offset: 0x218CCB1 VA: 0x218CBB0
	|-Array.InternalArray__get_Item<MapDeployTemplate.Queue.Data<object>>
	|
	|-RVA: 0x218CC60 Offset: 0x218CD61 VA: 0x218CC60
	|-Array.InternalArray__get_Item<Nex.DataStore.ParamPool.Data<object>>
	|
	|-RVA: 0x218CD10 Offset: 0x218CE11 VA: 0x218CD10
	|-Array.InternalArray__get_Item<Nex.Screening.ParamPool.Data<object>>
	|
	|-RVA: 0x218CDC0 Offset: 0x218CEC1 VA: 0x218CDC0
	|-Array.InternalArray__get_Item<IntervalTree.Entry<object>>
	|
	|-RVA: 0x218CE80 Offset: 0x218CF81 VA: 0x218CE80
	|-Array.InternalArray__get_Item<Dictionary.Entry<ValueTuple<object, int>, object>>
	|
	|-RVA: 0x218CF40 Offset: 0x218D041 VA: 0x218CF40
	|-Array.InternalArray__get_Item<Dictionary.Entry<byte, object>>
	|
	|-RVA: 0x218D000 Offset: 0x218D101 VA: 0x218D000
	|-Array.InternalArray__get_Item<Dictionary.Entry<CancellationToken, object>>
	|
	|-RVA: 0x218D0C0 Offset: 0x218D1C1 VA: 0x218D0C0
	|-Array.InternalArray__get_Item<Dictionary.Entry<char, object>>
	|
	|-RVA: 0x218D180 Offset: 0x218D281 VA: 0x218D180
	|-Array.InternalArray__get_Item<Dictionary.Entry<Guid, object>>
	|
	|-RVA: 0x218D240 Offset: 0x218D341 VA: 0x218D240
	|-Array.InternalArray__get_Item<Dictionary.Entry<int, bool>>
	|
	|-RVA: 0x218D2F0 Offset: 0x218D3F1 VA: 0x218D2F0
	|-Array.InternalArray__get_Item<Dictionary.Entry<int, byte>>
	|
	|-RVA: 0x218D3A0 Offset: 0x218D4A1 VA: 0x218D3A0
	|-Array.InternalArray__get_Item<Dictionary.Entry<int, char>>
	|
	|-RVA: 0x218D450 Offset: 0x218D551 VA: 0x218D450
	|-Array.InternalArray__get_Item<Dictionary.Entry<int, DiagnosticEvent>>
	|
	|-RVA: 0x218D530 Offset: 0x218D631 VA: 0x218D530
	|-Array.InternalArray__get_Item<Dictionary.Entry<int, int>>
	|
	|-RVA: 0x218D5E0 Offset: 0x218D6E1 VA: 0x218D5E0
	|-Array.InternalArray__get_Item<Dictionary.Entry<int, Int32Enum>>
	|
	|-RVA: 0x218D690 Offset: 0x218D791 VA: 0x218D690
	|-Array.InternalArray__get_Item<Dictionary.Entry<int, long>>
	|
	|-RVA: 0x218D750 Offset: 0x218D851 VA: 0x218D750
	|-Array.InternalArray__get_Item<Dictionary.Entry<int, MapPos>>
	|
	|-RVA: 0x218D810 Offset: 0x218D911 VA: 0x218D810
	|-Array.InternalArray__get_Item<Dictionary.Entry<int, object>>
	|
	|-RVA: 0x218D8D0 Offset: 0x218D9D1 VA: 0x218D8D0
	|-Array.InternalArray__get_Item<Dictionary.Entry<int, uint>>
	|
	|-RVA: 0x218D980 Offset: 0x218DA81 VA: 0x218D980
	|-Array.InternalArray__get_Item<Dictionary.Entry<int, AIThink.EnchantThink.SurroundingInfo>>
	|
	|-RVA: 0x218DA30 Offset: 0x218DB31 VA: 0x218DA30
	|-Array.InternalArray__get_Item<Dictionary.Entry<Int32Enum, bool>>
	|
	|-RVA: 0x218DAE0 Offset: 0x218DBE1 VA: 0x218DAE0
	|-Array.InternalArray__get_Item<Dictionary.Entry<Int32Enum, int>>
	|
	|-RVA: 0x218DB90 Offset: 0x218DC91 VA: 0x218DB90
	|-Array.InternalArray__get_Item<Dictionary.Entry<Int32Enum, Int32Enum>>
	|
	|-RVA: 0x218DC40 Offset: 0x218DD41 VA: 0x218DC40
	|-Array.InternalArray__get_Item<Dictionary.Entry<Int32Enum, object>>
	|
	|-RVA: 0x218DD00 Offset: 0x218DE01 VA: 0x218DD00
	|-Array.InternalArray__get_Item<Dictionary.Entry<long, object>>
	|
	|-RVA: 0x218DDC0 Offset: 0x218DEC1 VA: 0x218DDC0
	|-Array.InternalArray__get_Item<Dictionary.Entry<MapPos, int>>
	|
	|-RVA: 0x218DE80 Offset: 0x218DF81 VA: 0x218DE80
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, AsyncOperationHandle<object>>>
	|
	|-RVA: 0x218DF50 Offset: 0x218E051 VA: 0x218DF50
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, AsyncOperationHandle>>
	|
	|-RVA: 0x218E020 Offset: 0x218E121 VA: 0x218E020
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, bool>>
	|
	|-RVA: 0x218E0E0 Offset: 0x218E1E1 VA: 0x218E0E0
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, byte>>
	|
	|-RVA: 0x218E1A0 Offset: 0x218E2A1 VA: 0x218E1A0
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, int>>
	|
	|-RVA: 0x218E260 Offset: 0x218E361 VA: 0x218E260
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, Int32Enum>>
	|
	|-RVA: 0x218E320 Offset: 0x218E421 VA: 0x218E320
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, IntPtr>>
	|
	|-RVA: 0x218E3E0 Offset: 0x218E4E1 VA: 0x218E3E0
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, object>>
	|
	|-RVA: 0x218E4A0 Offset: 0x218E5A1 VA: 0x218E4A0
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, Playable>>
	|
	|-RVA: 0x218E560 Offset: 0x218E661 VA: 0x218E560
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, ResourceLocator>>
	|
	|-RVA: 0x218E620 Offset: 0x218E721 VA: 0x218E620
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, float>>
	|
	|-RVA: 0x218E6E0 Offset: 0x218E7E1 VA: 0x218E6E0
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, ushort>>
	|
	|-RVA: 0x218E7A0 Offset: 0x218E8A1 VA: 0x218E7A0
	|-Array.InternalArray__get_Item<Dictionary.Entry<object, GameVariable.Value>>
	|
	|-RVA: 0x218E860 Offset: 0x218E961 VA: 0x218E860
	|-Array.InternalArray__get_Item<Dictionary.Entry<sbyte, DataStoreRatingInfo>>
	|
	|-RVA: 0x218E930 Offset: 0x218EA31 VA: 0x218E930
	|-Array.InternalArray__get_Item<Dictionary.Entry<sbyte, object>>
	|
	|-RVA: 0x218E9F0 Offset: 0x218EAF1 VA: 0x218E9F0
	|-Array.InternalArray__get_Item<Dictionary.Entry<ushort, int>>
	|
	|-RVA: 0x218EAA0 Offset: 0x218EBA1 VA: 0x218EAA0
	|-Array.InternalArray__get_Item<Dictionary.Entry<uint, int>>
	|
	|-RVA: 0x218EB50 Offset: 0x218EC51 VA: 0x218EB50
	|-Array.InternalArray__get_Item<Dictionary.Entry<uint, object>>
	|
	|-RVA: 0x218EC10 Offset: 0x218ED11 VA: 0x218EC10
	|-Array.InternalArray__get_Item<Dictionary.Entry<ulong, Friend>>
	|
	|-RVA: 0x218ECE0 Offset: 0x218EDE1 VA: 0x218ECE0
	|-Array.InternalArray__get_Item<Dictionary.Entry<ulong, Int32Enum>>
	|
	|-RVA: 0x218EDA0 Offset: 0x218EEA1 VA: 0x218EDA0
	|-Array.InternalArray__get_Item<Dictionary.Entry<ulong, object>>
	|
	|-RVA: 0x218EE60 Offset: 0x218EF61 VA: 0x218EE60
	|-Array.InternalArray__get_Item<Dictionary.Entry<Vector3, int>>
	|
	|-RVA: 0x218EF20 Offset: 0x218F021 VA: 0x218EF20
	|-Array.InternalArray__get_Item<Dictionary.Entry<XPathNodeRef, XPathNodeRef>>
	|
	|-RVA: 0x218EFF0 Offset: 0x218F0F1 VA: 0x218EFF0
	|-Array.InternalArray__get_Item<Dictionary.Entry<TerrainUtility.TerrainMap.TileCoord, object>>
	|
	|-RVA: 0x218F0B0 Offset: 0x218F1B1 VA: 0x218F0B0
	|-Array.InternalArray__get_Item<PriorityQueue.IndexedItem<object>>
	|
	|-RVA: 0x218F160 Offset: 0x218F261 VA: 0x218F160
	|-Array.InternalArray__get_Item<KeyValuePair<ValueTuple<object, int>, object>>
	|
	|-RVA: 0x218F220 Offset: 0x218F321 VA: 0x218F220
	|-Array.InternalArray__get_Item<KeyValuePair<byte, object>>
	|
	|-RVA: 0x218F2D0 Offset: 0x218F3D1 VA: 0x218F2D0
	|-Array.InternalArray__get_Item<KeyValuePair<CancellationToken, object>>
	|
	|-RVA: 0x218F380 Offset: 0x218F481 VA: 0x218F380
	|-Array.InternalArray__get_Item<KeyValuePair<char, object>>
	|
	|-RVA: 0x218F430 Offset: 0x218F531 VA: 0x218F430
	|-Array.InternalArray__get_Item<KeyValuePair<DateTime, object>>
	|
	|-RVA: 0x218F4E0 Offset: 0x218F5E1 VA: 0x218F4E0
	|-Array.InternalArray__get_Item<KeyValuePair<Guid, object>>
	|
	|-RVA: 0x218F5A0 Offset: 0x218F6A1 VA: 0x218F5A0
	|-Array.InternalArray__get_Item<KeyValuePair<int, bool>>
	|
	|-RVA: 0x218F650 Offset: 0x218F751 VA: 0x218F650
	|-Array.InternalArray__get_Item<KeyValuePair<int, byte>>
	|
	|-RVA: 0x218F700 Offset: 0x218F801 VA: 0x218F700
	|-Array.InternalArray__get_Item<KeyValuePair<int, char>>
	|
	|-RVA: 0x218F7B0 Offset: 0x218F8B1 VA: 0x218F7B0
	|-Array.InternalArray__get_Item<KeyValuePair<int, DiagnosticEvent>>
	|
	|-RVA: 0x218F890 Offset: 0x218F991 VA: 0x218F890
	|-Array.InternalArray__get_Item<KeyValuePair<int, int>>
	|
	|-RVA: 0x218F940 Offset: 0x218FA41 VA: 0x218F940
	|-Array.InternalArray__get_Item<KeyValuePair<int, Int32Enum>>
	|
	|-RVA: 0x218F9F0 Offset: 0x218FAF1 VA: 0x218F9F0
	|-Array.InternalArray__get_Item<KeyValuePair<int, long>>
	|
	|-RVA: 0x218FAA0 Offset: 0x218FBA1 VA: 0x218FAA0
	|-Array.InternalArray__get_Item<KeyValuePair<int, MapPos>>
	|
	|-RVA: 0x218FB50 Offset: 0x218FC51 VA: 0x218FB50
	|-Array.InternalArray__get_Item<KeyValuePair<int, object>>
	|
	|-RVA: 0x218FC00 Offset: 0x218FD01 VA: 0x218FC00
	|-Array.InternalArray__get_Item<KeyValuePair<int, uint>>
	|
	|-RVA: 0x218FCB0 Offset: 0x218FDB1 VA: 0x218FCB0
	|-Array.InternalArray__get_Item<KeyValuePair<int, AIThink.EnchantThink.SurroundingInfo>>
	|
	|-RVA: 0x218FD60 Offset: 0x218FE61 VA: 0x218FD60
	|-Array.InternalArray__get_Item<KeyValuePair<Int32Enum, bool>>
	|
	|-RVA: 0x218FE10 Offset: 0x218FF11 VA: 0x218FE10
	|-Array.InternalArray__get_Item<KeyValuePair<Int32Enum, int>>
	|
	|-RVA: 0x218FEC0 Offset: 0x218FFC1 VA: 0x218FEC0
	|-Array.InternalArray__get_Item<KeyValuePair<Int32Enum, Int32Enum>>
	|
	|-RVA: 0x218FF70 Offset: 0x2190071 VA: 0x218FF70
	|-Array.InternalArray__get_Item<KeyValuePair<Int32Enum, object>>
	|
	|-RVA: 0x2190020 Offset: 0x2190121 VA: 0x2190020
	|-Array.InternalArray__get_Item<KeyValuePair<long, object>>
	|
	|-RVA: 0x21900D0 Offset: 0x21901D1 VA: 0x21900D0
	|-Array.InternalArray__get_Item<KeyValuePair<MapPos, int>>
	|
	|-RVA: 0x2190180 Offset: 0x2190281 VA: 0x2190180
	|-Array.InternalArray__get_Item<KeyValuePair<object, AsyncOperationHandle<object>>>
	|
	|-RVA: 0x2190240 Offset: 0x2190341 VA: 0x2190240
	|-Array.InternalArray__get_Item<KeyValuePair<object, ValueTuple<int, DateTime, object>>>
	|
	|-RVA: 0x2190300 Offset: 0x2190401 VA: 0x2190300
	|-Array.InternalArray__get_Item<KeyValuePair<object, AsyncOperationHandle>>
	|
	|-RVA: 0x21903C0 Offset: 0x21904C1 VA: 0x21903C0
	|-Array.InternalArray__get_Item<KeyValuePair<object, bool>>
	|
	|-RVA: 0x2190470 Offset: 0x2190571 VA: 0x2190470
	|-Array.InternalArray__get_Item<KeyValuePair<object, byte>>
	|
	|-RVA: 0x2190520 Offset: 0x2190621 VA: 0x2190520
	|-Array.InternalArray__get_Item<KeyValuePair<object, int>>
	|
	|-RVA: 0x21905D0 Offset: 0x21906D1 VA: 0x21905D0
	|-Array.InternalArray__get_Item<KeyValuePair<object, Int32Enum>>
	|
	|-RVA: 0x2190680 Offset: 0x2190781 VA: 0x2190680
	|-Array.InternalArray__get_Item<KeyValuePair<object, IntPtr>>
	|
	|-RVA: 0x2190730 Offset: 0x2190831 VA: 0x2190730
	|-Array.InternalArray__get_Item<KeyValuePair<object, object>>
	|
	|-RVA: 0x21907E0 Offset: 0x21908E1 VA: 0x21907E0
	|-Array.InternalArray__get_Item<KeyValuePair<object, Playable>>
	|
	|-RVA: 0x21908A0 Offset: 0x21909A1 VA: 0x21908A0
	|-Array.InternalArray__get_Item<KeyValuePair<object, ResourceLocator>>
	|
	|-RVA: 0x2190960 Offset: 0x2190A61 VA: 0x2190960
	|-Array.InternalArray__get_Item<KeyValuePair<object, float>>
	|
	|-RVA: 0x2190A10 Offset: 0x2190B11 VA: 0x2190A10
	|-Array.InternalArray__get_Item<KeyValuePair<object, ushort>>
	|
	|-RVA: 0x2190AC0 Offset: 0x2190BC1 VA: 0x2190AC0
	|-Array.InternalArray__get_Item<KeyValuePair<object, GameVariable.Value>>
	|
	|-RVA: 0x2190B80 Offset: 0x2190C81 VA: 0x2190B80
	|-Array.InternalArray__get_Item<KeyValuePair<sbyte, DataStoreRatingInfo>>
	|
	|-RVA: 0x2190C40 Offset: 0x2190D41 VA: 0x2190C40
	|-Array.InternalArray__get_Item<KeyValuePair<sbyte, object>>
	|
	|-RVA: 0x2190CF0 Offset: 0x2190DF1 VA: 0x2190CF0
	|-Array.InternalArray__get_Item<KeyValuePair<ushort, int>>
	|
	|-RVA: 0x2190DA0 Offset: 0x2190EA1 VA: 0x2190DA0
	|-Array.InternalArray__get_Item<KeyValuePair<uint, int>>
	|
	|-RVA: 0x2190E50 Offset: 0x2190F51 VA: 0x2190E50
	|-Array.InternalArray__get_Item<KeyValuePair<uint, object>>
	|
	|-RVA: 0x2190F00 Offset: 0x2191001 VA: 0x2190F00
	|-Array.InternalArray__get_Item<KeyValuePair<ulong, Friend>>
	|
	|-RVA: 0x2190FD0 Offset: 0x21910D1 VA: 0x2190FD0
	|-Array.InternalArray__get_Item<KeyValuePair<ulong, Int32Enum>>
	|
	|-RVA: 0x2191080 Offset: 0x2191181 VA: 0x2191080
	|-Array.InternalArray__get_Item<KeyValuePair<ulong, object>>
	|
	|-RVA: 0x2191130 Offset: 0x2191231 VA: 0x2191130
	|-Array.InternalArray__get_Item<KeyValuePair<Vector3, int>>
	|
	|-RVA: 0x21911E0 Offset: 0x21912E1 VA: 0x21911E0
	|-Array.InternalArray__get_Item<KeyValuePair<XPathNodeRef, XPathNodeRef>>
	|
	|-RVA: 0x21912A0 Offset: 0x21913A1 VA: 0x21912A0
	|-Array.InternalArray__get_Item<KeyValuePair<TerrainUtility.TerrainMap.TileCoord, object>>
	|
	|-RVA: 0x2191350 Offset: 0x2191451 VA: 0x2191350
	|-Array.InternalArray__get_Item<NativeArray<PreTile>>
	|
	|-RVA: 0x2191400 Offset: 0x2191501 VA: 0x2191400
	|-Array.InternalArray__get_Item<CommonBattleSequence.Reliance<object>>
	|
	|-RVA: 0x21914C0 Offset: 0x21915C1 VA: 0x21914C0
	|-Array.InternalArray__get_Item<RenderGraphResourcePool.ResourceLogInfo<object>>
	|
	|-RVA: 0x2191570 Offset: 0x2191671 VA: 0x2191570
	|-Array.InternalArray__get_Item<HashSet.Slot<ValueTuple<object, int>>>
	|
	|-RVA: 0x2191630 Offset: 0x2191731 VA: 0x2191630
	|-Array.InternalArray__get_Item<HashSet.Slot<AsyncOperationHandle>>
	|
	|-RVA: 0x21916F0 Offset: 0x21917F1 VA: 0x21916F0
	|-Array.InternalArray__get_Item<HashSet.Slot<int>>
	|
	|-RVA: 0x21917A0 Offset: 0x21918A1 VA: 0x21917A0
	|-Array.InternalArray__get_Item<HashSet.Slot<Int32Enum>>
	|
	|-RVA: 0x2191850 Offset: 0x2191951 VA: 0x2191850
	|-Array.InternalArray__get_Item<Set.Slot<Int32Enum>>
	|
	|-RVA: 0x2191900 Offset: 0x2191A01 VA: 0x2191900
	|-Array.InternalArray__get_Item<HashSet.Slot<MapPos>>
	|
	|-RVA: 0x21919B0 Offset: 0x2191AB1 VA: 0x21919B0
	|-Array.InternalArray__get_Item<HashSet.Slot<object>>
	|
	|-RVA: 0x2191A60 Offset: 0x2191B61 VA: 0x2191A60
	|-Array.InternalArray__get_Item<Set.Slot<object>>
	|
	|-RVA: 0x2191B20 Offset: 0x2191C21 VA: 0x2191B20
	|-Array.InternalArray__get_Item<HashSet.Slot<uint>>
	|
	|-RVA: 0x2191BD0 Offset: 0x2191CD1 VA: 0x2191BD0
	|-Array.InternalArray__get_Item<HashSet.Slot<ulong>>
	|
	|-RVA: 0x2191C80 Offset: 0x2191D81 VA: 0x2191C80
	|-Array.InternalArray__get_Item<Set.Slot<Vector3>>
	|
	|-RVA: 0x2191D40 Offset: 0x2191E41 VA: 0x2191D40
	|-Array.InternalArray__get_Item<TMP_TextProcessingStack<Color32>>
	|
	|-RVA: 0x2191E00 Offset: 0x2191F01 VA: 0x2191E00
	|-Array.InternalArray__get_Item<TMP_TextProcessingStack<HighlightState>>
	|
	|-RVA: 0x2191ED0 Offset: 0x2191FD1 VA: 0x2191ED0
	|-Array.InternalArray__get_Item<TMP_TextProcessingStack<int>>
	|
	|-RVA: 0x2191F90 Offset: 0x2192091 VA: 0x2191F90
	|-Array.InternalArray__get_Item<TMP_TextProcessingStack<Int32Enum>>
	|
	|-RVA: 0x2192050 Offset: 0x2192151 VA: 0x2192050
	|-Array.InternalArray__get_Item<TMP_TextProcessingStack<MaterialReference>>
	|
	|-RVA: 0x2192140 Offset: 0x2192241 VA: 0x2192140
	|-Array.InternalArray__get_Item<TMP_TextProcessingStack<object>>
	|
	|-RVA: 0x2192210 Offset: 0x2192311 VA: 0x2192210
	|-Array.InternalArray__get_Item<TMP_TextProcessingStack<float>>
	|
	|-RVA: 0x21922D0 Offset: 0x21923D1 VA: 0x21922D0
	|-Array.InternalArray__get_Item<TMP_TextProcessingStack<WordWrapState>>
	|
	|-RVA: 0x21923A0 Offset: 0x21924A1 VA: 0x21923A0
	|-Array.InternalArray__get_Item<TimeInterval<object>>
	|
	|-RVA: 0x2192450 Offset: 0x2192551 VA: 0x2192450
	|-Array.InternalArray__get_Item<Timestamped<object>>
	|
	|-RVA: 0x2192510 Offset: 0x2192611 VA: 0x2192510
	|-Array.InternalArray__get_Item<UniTask<object>>
	|
	|-RVA: 0x21925C0 Offset: 0x21926C1 VA: 0x21925C0
	|-Array.InternalArray__get_Item<ValueTuple<ValueTuple<bool, object>>>
	|
	|-RVA: 0x2192670 Offset: 0x2192771 VA: 0x2192670
	|-Array.InternalArray__get_Item<ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>
	|
	|-RVA: 0x2192730 Offset: 0x2192831 VA: 0x2192730
	|-Array.InternalArray__get_Item<ValueTuple<bool, UniTask<object>>>
	|
	|-RVA: 0x21927F0 Offset: 0x21928F1 VA: 0x21927F0
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>
	|
	|-RVA: 0x21928B0 Offset: 0x21929B1 VA: 0x21928B0
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>
	|
	|-RVA: 0x2192980 Offset: 0x2192A81 VA: 0x2192980
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>
	|
	|-RVA: 0x2192A50 Offset: 0x2192B51 VA: 0x2192A50
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>
	|
	|-RVA: 0x2192B00 Offset: 0x2192C01 VA: 0x2192B00
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>
	|
	|-RVA: 0x2192BB0 Offset: 0x2192CB1 VA: 0x2192BB0
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>
	|
	|-RVA: 0x2192C90 Offset: 0x2192D91 VA: 0x2192C90
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>
	|
	|-RVA: 0x2192D40 Offset: 0x2192E41 VA: 0x2192D40
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>
	|
	|-RVA: 0x2192E10 Offset: 0x2192F11 VA: 0x2192E10
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>
	|
	|-RVA: 0x2192EE0 Offset: 0x2192FE1 VA: 0x2192EE0
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>
	|
	|-RVA: 0x2192FA0 Offset: 0x21930A1 VA: 0x2192FA0
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>
	|
	|-RVA: 0x2193070 Offset: 0x2193171 VA: 0x2193070
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x2193140 Offset: 0x2193241 VA: 0x2193140
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>
	|
	|-RVA: 0x2193210 Offset: 0x2193311 VA: 0x2193210
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>
	|
	|-RVA: 0x21932E0 Offset: 0x21933E1 VA: 0x21932E0
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>
	|
	|-RVA: 0x21933A0 Offset: 0x21934A1 VA: 0x21933A0
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>
	|
	|-RVA: 0x2193470 Offset: 0x2193571 VA: 0x2193470
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>
	|
	|-RVA: 0x2193520 Offset: 0x2193621 VA: 0x2193520
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>
	|
	|-RVA: 0x21935F0 Offset: 0x21936F1 VA: 0x21935F0
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>
	|
	|-RVA: 0x21936B0 Offset: 0x21937B1 VA: 0x21936B0
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>
	|
	|-RVA: 0x2193780 Offset: 0x2193881 VA: 0x2193780
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>
	|
	|-RVA: 0x2193850 Offset: 0x2193951 VA: 0x2193850
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>
	|
	|-RVA: 0x2193920 Offset: 0x2193A21 VA: 0x2193920
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>
	|
	|-RVA: 0x2193A00 Offset: 0x2193B01 VA: 0x2193A00
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>
	|
	|-RVA: 0x2193AE0 Offset: 0x2193BE1 VA: 0x2193AE0
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>
	|
	|-RVA: 0x2193BD0 Offset: 0x2193CD1 VA: 0x2193BD0
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>
	|
	|-RVA: 0x2193CC0 Offset: 0x2193DC1 VA: 0x2193CC0
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>
	|
	|-RVA: 0x2193DB0 Offset: 0x2193EB1 VA: 0x2193DB0
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>
	|
	|-RVA: 0x2193E60 Offset: 0x2193F61 VA: 0x2193E60
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>
	|
	|-RVA: 0x2193F10 Offset: 0x2194011 VA: 0x2193F10
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>
	|
	|-RVA: 0x2193FE0 Offset: 0x21940E1 VA: 0x2193FE0
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>
	|
	|-RVA: 0x2194090 Offset: 0x2194191 VA: 0x2194090
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>
	|
	|-RVA: 0x2194150 Offset: 0x2194251 VA: 0x2194150
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>
	|
	|-RVA: 0x2194220 Offset: 0x2194321 VA: 0x2194220
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>
	|
	|-RVA: 0x21942E0 Offset: 0x21943E1 VA: 0x21942E0
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>
	|
	|-RVA: 0x21943B0 Offset: 0x21944B1 VA: 0x21943B0
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x2194480 Offset: 0x2194581 VA: 0x2194480
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>
	|
	|-RVA: 0x2194540 Offset: 0x2194641 VA: 0x2194540
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>
	|
	|-RVA: 0x2194600 Offset: 0x2194701 VA: 0x2194600
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>
	|
	|-RVA: 0x21946C0 Offset: 0x21947C1 VA: 0x21946C0
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>
	|
	|-RVA: 0x2194790 Offset: 0x2194891 VA: 0x2194790
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>
	|
	|-RVA: 0x2194840 Offset: 0x2194941 VA: 0x2194840
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>
	|
	|-RVA: 0x2194900 Offset: 0x2194A01 VA: 0x2194900
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>
	|
	|-RVA: 0x21949D0 Offset: 0x2194AD1 VA: 0x21949D0
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>
	|
	|-RVA: 0x2194A90 Offset: 0x2194B91 VA: 0x2194A90
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>
	|
	|-RVA: 0x2194B60 Offset: 0x2194C61 VA: 0x2194B60
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>
	|
	|-RVA: 0x2194C30 Offset: 0x2194D31 VA: 0x2194C30
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x2194D10 Offset: 0x2194E11 VA: 0x2194D10
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>
	|
	|-RVA: 0x2194DE0 Offset: 0x2194EE1 VA: 0x2194DE0
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x2194ED0 Offset: 0x2194FD1 VA: 0x2194ED0
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>
	|
	|-RVA: 0x2194FB0 Offset: 0x21950B1 VA: 0x2194FB0
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x21950A0 Offset: 0x21951A1 VA: 0x21950A0
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>
	|
	|-RVA: 0x2195180 Offset: 0x2195281 VA: 0x2195180
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x2195280 Offset: 0x2195381 VA: 0x2195280
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>
	|
	|-RVA: 0x2195370 Offset: 0x2195471 VA: 0x2195370
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x2195480 Offset: 0x2195581 VA: 0x2195480
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>
	|
	|-RVA: 0x2195570 Offset: 0x2195671 VA: 0x2195570
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>
	|
	|-RVA: 0x2195620 Offset: 0x2195721 VA: 0x2195620
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>
	|
	|-RVA: 0x21956D0 Offset: 0x21957D1 VA: 0x21956D0
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>
	|
	|-RVA: 0x21957A0 Offset: 0x21958A1 VA: 0x21957A0
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>
	|
	|-RVA: 0x2195850 Offset: 0x2195951 VA: 0x2195850
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>
	|
	|-RVA: 0x2195920 Offset: 0x2195A21 VA: 0x2195920
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>
	|
	|-RVA: 0x21959E0 Offset: 0x2195AE1 VA: 0x21959E0
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>
	|
	|-RVA: 0x2195A90 Offset: 0x2195B91 VA: 0x2195A90
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>
	|
	|-RVA: 0x2195B50 Offset: 0x2195C51 VA: 0x2195B50
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x2195C10 Offset: 0x2195D11 VA: 0x2195C10
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>
	|
	|-RVA: 0x2195CE0 Offset: 0x2195DE1 VA: 0x2195CE0
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>
	|
	|-RVA: 0x2195DB0 Offset: 0x2195EB1 VA: 0x2195DB0
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>
	|
	|-RVA: 0x2195E60 Offset: 0x2195F61 VA: 0x2195E60
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>
	|
	|-RVA: 0x2195F20 Offset: 0x2196021 VA: 0x2195F20
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>
	|
	|-RVA: 0x2195FD0 Offset: 0x21960D1 VA: 0x2195FD0
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>
	|
	|-RVA: 0x2196090 Offset: 0x2196191 VA: 0x2196090
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>
	|
	|-RVA: 0x2196150 Offset: 0x2196251 VA: 0x2196150
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>
	|
	|-RVA: 0x2196220 Offset: 0x2196321 VA: 0x2196220
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>
	|
	|-RVA: 0x21962E0 Offset: 0x21963E1 VA: 0x21962E0
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>
	|
	|-RVA: 0x21963A0 Offset: 0x21964A1 VA: 0x21963A0
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x2196480 Offset: 0x2196581 VA: 0x2196480
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>
	|
	|-RVA: 0x2196550 Offset: 0x2196651 VA: 0x2196550
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x2196640 Offset: 0x2196741 VA: 0x2196640
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>
	|
	|-RVA: 0x2196710 Offset: 0x2196811 VA: 0x2196710
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x2196800 Offset: 0x2196901 VA: 0x2196800
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>
	|
	|-RVA: 0x21968E0 Offset: 0x21969E1 VA: 0x21968E0
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x21969E0 Offset: 0x2196AE1 VA: 0x21969E0
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>
	|
	|-RVA: 0x2196AC0 Offset: 0x2196BC1 VA: 0x2196AC0
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x2196BD0 Offset: 0x2196CD1 VA: 0x2196BD0
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>
	|
	|-RVA: 0x2196CC0 Offset: 0x2196DC1 VA: 0x2196CC0
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x2196DA0 Offset: 0x2196EA1 VA: 0x2196DA0
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x2196E80 Offset: 0x2196F81 VA: 0x2196E80
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>
	|
	|-RVA: 0x2196F30 Offset: 0x2197031 VA: 0x2196F30
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, bool>>>
	|
	|-RVA: 0x2196FE0 Offset: 0x21970E1 VA: 0x2196FE0
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, Bounds>>>
	|
	|-RVA: 0x21970A0 Offset: 0x21971A1 VA: 0x21970A0
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, byte>>>
	|
	|-RVA: 0x2197150 Offset: 0x2197251 VA: 0x2197150
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, Color>>>
	|
	|-RVA: 0x2197210 Offset: 0x2197311 VA: 0x2197210
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, double>>>
	|
	|-RVA: 0x21972D0 Offset: 0x21973D1 VA: 0x21972D0
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, int>>>
	|
	|-RVA: 0x2197380 Offset: 0x2197481 VA: 0x2197380
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, long>>>
	|
	|-RVA: 0x2197440 Offset: 0x2197541 VA: 0x2197440
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, object>>>
	|
	|-RVA: 0x2197500 Offset: 0x2197601 VA: 0x2197500
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, Quaternion>>>
	|
	|-RVA: 0x21975C0 Offset: 0x21976C1 VA: 0x21975C0
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, Rect>>>
	|
	|-RVA: 0x2197680 Offset: 0x2197781 VA: 0x2197680
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, float>>>
	|
	|-RVA: 0x2197730 Offset: 0x2197831 VA: 0x2197730
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, UniTask>>>
	|
	|-RVA: 0x21977F0 Offset: 0x21978F1 VA: 0x21977F0
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, Unit>>>
	|
	|-RVA: 0x21978A0 Offset: 0x21979A1 VA: 0x21978A0
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, Vector2>>>
	|
	|-RVA: 0x2197950 Offset: 0x2197A51 VA: 0x2197950
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, Vector3>>>
	|
	|-RVA: 0x2197A10 Offset: 0x2197B11 VA: 0x2197A10
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<bool, Vector4>>>
	|
	|-RVA: 0x2197AD0 Offset: 0x2197BD1 VA: 0x2197AD0
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<int, object>>>
	|
	|-RVA: 0x2197B90 Offset: 0x2197C91 VA: 0x2197B90
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<object, object>>>
	|
	|-RVA: 0x2197C50 Offset: 0x2197D51 VA: 0x2197C50
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x2197D20 Offset: 0x2197E21 VA: 0x2197D20
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<object, object, object>>>
	|
	|-RVA: 0x2197DE0 Offset: 0x2197EE1 VA: 0x2197DE0
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x2197EC0 Offset: 0x2197FC1 VA: 0x2197EC0
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<object, object, object, object>>>
	|
	|-RVA: 0x2197F90 Offset: 0x2198091 VA: 0x2197F90
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x2198080 Offset: 0x2198181 VA: 0x2198080
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>
	|
	|-RVA: 0x2198150 Offset: 0x2198251 VA: 0x2198150
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x2198240 Offset: 0x2198341 VA: 0x2198240
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>
	|
	|-RVA: 0x2198320 Offset: 0x2198421 VA: 0x2198320
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x2198420 Offset: 0x2198521 VA: 0x2198420
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>
	|
	|-RVA: 0x2198500 Offset: 0x2198601 VA: 0x2198500
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x2198610 Offset: 0x2198711 VA: 0x2198610
	|-Array.InternalArray__get_Item<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x21986F0 Offset: 0x21987F1 VA: 0x21986F0
	|-Array.InternalArray__get_Item<ValueTuple<bool, AsyncUnit>>
	|
	|-RVA: 0x21987A0 Offset: 0x21988A1 VA: 0x21987A0
	|-Array.InternalArray__get_Item<ValueTuple<bool, bool>>
	|
	|-RVA: 0x2198850 Offset: 0x2198951 VA: 0x2198850
	|-Array.InternalArray__get_Item<ValueTuple<bool, Bounds>>
	|
	|-RVA: 0x2198920 Offset: 0x2198A21 VA: 0x2198920
	|-Array.InternalArray__get_Item<ValueTuple<bool, byte>>
	|
	|-RVA: 0x21989D0 Offset: 0x2198AD1 VA: 0x21989D0
	|-Array.InternalArray__get_Item<ValueTuple<bool, Color>>
	|
	|-RVA: 0x2198A90 Offset: 0x2198B91 VA: 0x2198A90
	|-Array.InternalArray__get_Item<ValueTuple<bool, double>>
	|
	|-RVA: 0x2198B40 Offset: 0x2198C41 VA: 0x2198B40
	|-Array.InternalArray__get_Item<ValueTuple<bool, int>>
	|
	|-RVA: 0x2198BF0 Offset: 0x2198CF1 VA: 0x2198BF0
	|-Array.InternalArray__get_Item<ValueTuple<bool, long>>
	|
	|-RVA: 0x2198CA0 Offset: 0x2198DA1 VA: 0x2198CA0
	|-Array.InternalArray__get_Item<ValueTuple<bool, object>>
	|
	|-RVA: 0x2198D50 Offset: 0x2198E51 VA: 0x2198D50
	|-Array.InternalArray__get_Item<ValueTuple<bool, Quaternion>>
	|
	|-RVA: 0x2198E10 Offset: 0x2198F11 VA: 0x2198E10
	|-Array.InternalArray__get_Item<ValueTuple<bool, Rect>>
	|
	|-RVA: 0x2198ED0 Offset: 0x2198FD1 VA: 0x2198ED0
	|-Array.InternalArray__get_Item<ValueTuple<bool, float>>
	|
	|-RVA: 0x2198F80 Offset: 0x2199081 VA: 0x2198F80
	|-Array.InternalArray__get_Item<ValueTuple<bool, UniTask>>
	|
	|-RVA: 0x2199030 Offset: 0x2199131 VA: 0x2199030
	|-Array.InternalArray__get_Item<ValueTuple<bool, Unit>>
	|
	|-RVA: 0x21990E0 Offset: 0x21991E1 VA: 0x21990E0
	|-Array.InternalArray__get_Item<ValueTuple<bool, Vector2>>
	|
	|-RVA: 0x2199190 Offset: 0x2199291 VA: 0x2199190
	|-Array.InternalArray__get_Item<ValueTuple<bool, Vector3>>
	|
	|-RVA: 0x2199240 Offset: 0x2199341 VA: 0x2199240
	|-Array.InternalArray__get_Item<ValueTuple<bool, Vector4>>
	|
	|-RVA: 0x2199300 Offset: 0x2199401 VA: 0x2199300
	|-Array.InternalArray__get_Item<ValueTuple<int, bool>>
	|
	|-RVA: 0x21993B0 Offset: 0x21994B1 VA: 0x21993B0
	|-Array.InternalArray__get_Item<ValueTuple<int, Bounds>>
	|
	|-RVA: 0x2199480 Offset: 0x2199581 VA: 0x2199480
	|-Array.InternalArray__get_Item<ValueTuple<int, byte>>
	|
	|-RVA: 0x2199530 Offset: 0x2199631 VA: 0x2199530
	|-Array.InternalArray__get_Item<ValueTuple<int, Color>>
	|
	|-RVA: 0x21995F0 Offset: 0x21996F1 VA: 0x21995F0
	|-Array.InternalArray__get_Item<ValueTuple<int, double>>
	|
	|-RVA: 0x21996A0 Offset: 0x21997A1 VA: 0x21996A0
	|-Array.InternalArray__get_Item<ValueTuple<int, int>>
	|
	|-RVA: 0x2199750 Offset: 0x2199851 VA: 0x2199750
	|-Array.InternalArray__get_Item<ValueTuple<int, long>>
	|
	|-RVA: 0x2199800 Offset: 0x2199901 VA: 0x2199800
	|-Array.InternalArray__get_Item<ValueTuple<int, object>>
	|
	|-RVA: 0x21998B0 Offset: 0x21999B1 VA: 0x21998B0
	|-Array.InternalArray__get_Item<ValueTuple<int, Quaternion>>
	|
	|-RVA: 0x2199970 Offset: 0x2199A71 VA: 0x2199970
	|-Array.InternalArray__get_Item<ValueTuple<int, Rect>>
	|
	|-RVA: 0x2199A30 Offset: 0x2199B31 VA: 0x2199A30
	|-Array.InternalArray__get_Item<ValueTuple<int, float>>
	|
	|-RVA: 0x2199AE0 Offset: 0x2199BE1 VA: 0x2199AE0
	|-Array.InternalArray__get_Item<ValueTuple<int, Unit>>
	|
	|-RVA: 0x2199B90 Offset: 0x2199C91 VA: 0x2199B90
	|-Array.InternalArray__get_Item<ValueTuple<int, Vector2>>
	|
	|-RVA: 0x2199C40 Offset: 0x2199D41 VA: 0x2199C40
	|-Array.InternalArray__get_Item<ValueTuple<int, Vector3>>
	|
	|-RVA: 0x2199CF0 Offset: 0x2199DF1 VA: 0x2199CF0
	|-Array.InternalArray__get_Item<ValueTuple<int, Vector4>>
	|
	|-RVA: 0x2199DB0 Offset: 0x2199EB1 VA: 0x2199DB0
	|-Array.InternalArray__get_Item<ValueTuple<Int32Enum, int>>
	|
	|-RVA: 0x2199E60 Offset: 0x2199F61 VA: 0x2199E60
	|-Array.InternalArray__get_Item<ValueTuple<object, ValueTuple<object, int>>>
	|
	|-RVA: 0x2199F20 Offset: 0x219A021 VA: 0x2199F20
	|-Array.InternalArray__get_Item<ValueTuple<object, int>>
	|
	|-RVA: 0x2199FD0 Offset: 0x219A0D1 VA: 0x2199FD0
	|-Array.InternalArray__get_Item<ValueTuple<object, object>>
	|
	|-RVA: 0x219A080 Offset: 0x219A181 VA: 0x219A080
	|-Array.InternalArray__get_Item<ValueTuple<object, float>>
	|
	|-RVA: 0x219A130 Offset: 0x219A231 VA: 0x219A130
	|-Array.InternalArray__get_Item<ValueTuple<Vector3, float>>
	|
	|-RVA: 0x219A1E0 Offset: 0x219A2E1 VA: 0x219A1E0
	|-Array.InternalArray__get_Item<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>
	|
	|-RVA: 0x219A2B0 Offset: 0x219A3B1 VA: 0x219A2B0
	|-Array.InternalArray__get_Item<ValueTuple<object, Int32Enum, int>>
	|
	|-RVA: 0x219A360 Offset: 0x219A461 VA: 0x219A360
	|-Array.InternalArray__get_Item<ValueTuple<object, object, object>>
	|
	|-RVA: 0x219A420 Offset: 0x219A521 VA: 0x219A420
	|-Array.InternalArray__get_Item<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>
	|
	|-RVA: 0x219A500 Offset: 0x219A601 VA: 0x219A500
	|-Array.InternalArray__get_Item<ValueTuple<object, int, int, int>>
	|
	|-RVA: 0x219A5C0 Offset: 0x219A6C1 VA: 0x219A5C0
	|-Array.InternalArray__get_Item<ValueTuple<object, object, object, object>>
	|
	|-RVA: 0x219A680 Offset: 0x219A781 VA: 0x219A680
	|-Array.InternalArray__get_Item<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>
	|
	|-RVA: 0x219A770 Offset: 0x219A871 VA: 0x219A770
	|-Array.InternalArray__get_Item<ValueTuple<object, object, object, object, object>>
	|
	|-RVA: 0x219A840 Offset: 0x219A941 VA: 0x219A840
	|-Array.InternalArray__get_Item<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>
	|
	|-RVA: 0x219A930 Offset: 0x219AA31 VA: 0x219A930
	|-Array.InternalArray__get_Item<ValueTuple<object, object, object, object, object, object>>
	|
	|-RVA: 0x219AA00 Offset: 0x219AB01 VA: 0x219AA00
	|-Array.InternalArray__get_Item<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>
	|
	|-RVA: 0x219AB00 Offset: 0x219AC01 VA: 0x219AB00
	|-Array.InternalArray__get_Item<ValueTuple<object, object, object, object, object, object, object>>
	|
	|-RVA: 0x219ABE0 Offset: 0x219ACE1 VA: 0x219ABE0
	|-Array.InternalArray__get_Item<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>
	|
	|-RVA: 0x219ACF0 Offset: 0x219ADF1 VA: 0x219ACF0
	|-Array.InternalArray__get_Item<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x219ADD0 Offset: 0x219AED1 VA: 0x219ADD0
	|-Array.InternalArray__get_Item<AnimatorClipInfo>
	|
	|-RVA: 0x219AE80 Offset: 0x219AF81 VA: 0x219AE80
	|-Array.InternalArray__get_Item<AsyncOperationHandle>
	|
	|-RVA: 0x219AF40 Offset: 0x219B041 VA: 0x219AF40
	|-Array.InternalArray__get_Item<AsyncUnit>
	|
	|-RVA: 0x219AFF0 Offset: 0x219B0F1 VA: 0x219AFF0
	|-Array.InternalArray__get_Item<BatchVisibility>
	|
	|-RVA: 0x219B0A0 Offset: 0x219B1A1 VA: 0x219B0A0
	|-Array.InternalArray__get_Item<BoneWeight>
	|
	|-RVA: 0x219B160 Offset: 0x219B261 VA: 0x219B160
	|-Array.InternalArray__get_Item<BoneWeight1>
	|
	|-RVA: 0x219B210 Offset: 0x219B311 VA: 0x219B210
	|-Array.InternalArray__get_Item<bool>
	|
	|-RVA: 0x219B2C0 Offset: 0x219B3C1 VA: 0x219B2C0
	|-Array.InternalArray__get_Item<Bounds>
	|
	|-RVA: 0x219B380 Offset: 0x219B481 VA: 0x219B380
	|-Array.InternalArray__get_Item<byte>
	|
	|-RVA: 0x219B430 Offset: 0x219B531 VA: 0x219B430
	|-Array.InternalArray__get_Item<ByteEnum>
	|
	|-RVA: 0x219B4E0 Offset: 0x219B5E1 VA: 0x219B4E0
	|-Array.InternalArray__get_Item<CameraInfo>
	|
	|-RVA: 0x219B590 Offset: 0x219B691 VA: 0x219B590
	|-Array.InternalArray__get_Item<CancellationToken>
	|
	|-RVA: 0x219B640 Offset: 0x219B741 VA: 0x219B640
	|-Array.InternalArray__get_Item<CancellationTokenRegistration>
	|
	|-RVA: 0x219B700 Offset: 0x219B801 VA: 0x219B700
	|-Array.InternalArray__get_Item<char>
	|
	|-RVA: 0x219B7B0 Offset: 0x219B8B1 VA: 0x219B7B0
	|-Array.InternalArray__get_Item<ClusteringData>
	|
	|-RVA: 0x219B870 Offset: 0x219B971 VA: 0x219B870
	|-Array.InternalArray__get_Item<ClusteringProcessorState>
	|
	|-RVA: 0x219B940 Offset: 0x219BA41 VA: 0x219B940
	|-Array.InternalArray__get_Item<Color>
	|
	|-RVA: 0x219B9F0 Offset: 0x219BAF1 VA: 0x219B9F0
	|-Array.InternalArray__get_Item<Color32>
	|
	|-RVA: 0x219BAA0 Offset: 0x219BBA1 VA: 0x219BAA0
	|-Array.InternalArray__get_Item<Color4u8>
	|
	|-RVA: 0x219BB50 Offset: 0x219BC51 VA: 0x219BB50
	|-Array.InternalArray__get_Item<ColorBlock>
	|
	|-RVA: 0x219BC40 Offset: 0x219BD41 VA: 0x219BC40
	|-Array.InternalArray__get_Item<CombineInstance>
	|
	|-RVA: 0x219BD40 Offset: 0x219BE41 VA: 0x219BD40
	|-Array.InternalArray__get_Item<ConstraintSource>
	|
	|-RVA: 0x219BDF0 Offset: 0x219BEF1 VA: 0x219BDF0
	|-Array.InternalArray__get_Item<ContactPoint>
	|
	|-RVA: 0x219BEC0 Offset: 0x219BFC1 VA: 0x219BEC0
	|-Array.InternalArray__get_Item<ContactPoint2D>
	|
	|-RVA: 0x219BFA0 Offset: 0x219C0A1 VA: 0x219BFA0
	|-Array.InternalArray__get_Item<ContourVertex>
	|
	|-RVA: 0x219C060 Offset: 0x219C161 VA: 0x219C060
	|-Array.InternalArray__get_Item<CustomAttributeNamedArgument>
	|
	|-RVA: 0x219C120 Offset: 0x219C221 VA: 0x219C120
	|-Array.InternalArray__get_Item<CustomAttributeTypedArgument>
	|
	|-RVA: 0x219C1D0 Offset: 0x219C2D1 VA: 0x219C1D0
	|-Array.InternalArray__get_Item<DataStoreRatingInfo>
	|
	|-RVA: 0x219C290 Offset: 0x219C391 VA: 0x219C290
	|-Array.InternalArray__get_Item<DataStoreResult>
	|
	|-RVA: 0x219C340 Offset: 0x219C441 VA: 0x219C340
	|-Array.InternalArray__get_Item<DateTime>
	|
	|-RVA: 0x219C3F0 Offset: 0x219C4F1 VA: 0x219C3F0
	|-Array.InternalArray__get_Item<DateTimeOffset>
	|
	|-RVA: 0x219C4A0 Offset: 0x219C5A1 VA: 0x219C4A0
	|-Array.InternalArray__get_Item<DebugPadState>
	|
	|-RVA: 0x219C560 Offset: 0x219C661 VA: 0x219C560
	|-Array.InternalArray__get_Item<Decimal>
	|
	|-RVA: 0x219C610 Offset: 0x219C711 VA: 0x219C610
	|-Array.InternalArray__get_Item<DeferredTiler>
	|
	|-RVA: 0x219C720 Offset: 0x219C821 VA: 0x219C720
	|-Array.InternalArray__get_Item<DeviceHandle>
	|
	|-RVA: 0x219C7D0 Offset: 0x219C8D1 VA: 0x219C7D0
	|-Array.InternalArray__get_Item<DiagnosticEvent>
	|
	|-RVA: 0x219C8A0 Offset: 0x219C9A1 VA: 0x219C8A0
	|-Array.InternalArray__get_Item<DictionaryEntry>
	|
	|-RVA: 0x219C950 Offset: 0x219CA51 VA: 0x219C950
	|-Array.InternalArray__get_Item<DictionaryInfo>
	|
	|-RVA: 0x219CA00 Offset: 0x219CB01 VA: 0x219CA00
	|-Array.InternalArray__get_Item<DirectoryEntry>
	|
	|-RVA: 0x219CAC0 Offset: 0x219CBC1 VA: 0x219CAC0
	|-Array.InternalArray__get_Item<double>
	|
	|-RVA: 0x219CB70 Offset: 0x219CC71 VA: 0x219CB70
	|-Array.InternalArray__get_Item<Ephemeron>
	|
	|-RVA: 0x219CC20 Offset: 0x219CD21 VA: 0x219CC20
	|-Array.InternalArray__get_Item<FXZ>
	|
	|-RVA: 0x219CCD0 Offset: 0x219CDD1 VA: 0x219CCD0
	|-Array.InternalArray__get_Item<Finger>
	|
	|-RVA: 0x219CDA0 Offset: 0x219CEA1 VA: 0x219CDA0
	|-Array.InternalArray__get_Item<Float2>
	|
	|-RVA: 0x219CE50 Offset: 0x219CF51 VA: 0x219CE50
	|-Array.InternalArray__get_Item<Friend>
	|
	|-RVA: 0x219CF20 Offset: 0x219D021 VA: 0x219CF20
	|-Array.InternalArray__get_Item<GCHandle>
	|
	|-RVA: 0x219CFD0 Offset: 0x219D0D1 VA: 0x219CFD0
	|-Array.InternalArray__get_Item<GesturePoint>
	|
	|-RVA: 0x219D080 Offset: 0x219D181 VA: 0x219D080
	|-Array.InternalArray__get_Item<GestureState>
	|
	|-RVA: 0x219D170 Offset: 0x219D271 VA: 0x219D170
	|-Array.InternalArray__get_Item<GlyphMarshallingStruct>
	|
	|-RVA: 0x219D240 Offset: 0x219D341 VA: 0x219D240
	|-Array.InternalArray__get_Item<GlyphPairAdjustmentRecord>
	|
	|-RVA: 0x219D320 Offset: 0x219D421 VA: 0x219D320
	|-Array.InternalArray__get_Item<GlyphRect>
	|
	|-RVA: 0x219D3D0 Offset: 0x219D4D1 VA: 0x219D3D0
	|-Array.InternalArray__get_Item<Guid>
	|
	|-RVA: 0x219D480 Offset: 0x219D581 VA: 0x219D480
	|-Array.InternalArray__get_Item<Hand>
	|
	|-RVA: 0x219D550 Offset: 0x219D651 VA: 0x219D550
	|-Array.InternalArray__get_Item<HandAnalysisImageState>
	|
	|-RVA: 0x219D600 Offset: 0x219D701 VA: 0x219D600
	|-Array.InternalArray__get_Item<HandAnalysisSilhouetteState>
	|
	|-RVA: 0x219D6D0 Offset: 0x219D7D1 VA: 0x219D6D0
	|-Array.InternalArray__get_Item<HeaderVariantInfo>
	|
	|-RVA: 0x219D780 Offset: 0x219D881 VA: 0x219D780
	|-Array.InternalArray__get_Item<HighlightState>
	|
	|-RVA: 0x219D840 Offset: 0x219D941 VA: 0x219D840
	|-Array.InternalArray__get_Item<HumanBone>
	|
	|-RVA: 0x219D920 Offset: 0x219DA21 VA: 0x219D920
	|-Array.InternalArray__get_Item<short>
	|
	|-RVA: 0x219D9D0 Offset: 0x219DAD1 VA: 0x219D9D0
	|-Array.InternalArray__get_Item<int>
	|
	|-RVA: 0x219DA80 Offset: 0x219DB81 VA: 0x219DA80
	|-Array.InternalArray__get_Item<Int32Enum>
	|
	|-RVA: 0x219DB30 Offset: 0x219DC31 VA: 0x219DB30
	|-Array.InternalArray__get_Item<long>
	|
	|-RVA: 0x219DBE0 Offset: 0x219DCE1 VA: 0x219DBE0
	|-Array.InternalArray__get_Item<Int64Enum>
	|
	|-RVA: 0x219DC90 Offset: 0x219DD91 VA: 0x219DC90
	|-Array.InternalArray__get_Item<IntPtr>
	|
	|-RVA: 0x219DD40 Offset: 0x219DE41 VA: 0x219DD40
	|-Array.InternalArray__get_Item<InternalCodePageDataItem>
	|
	|-RVA: 0x219DDF0 Offset: 0x219DEF1 VA: 0x219DDF0
	|-Array.InternalArray__get_Item<InternalEncodingDataItem>
	|
	|-RVA: 0x219DEA0 Offset: 0x219DFA1 VA: 0x219DEA0
	|-Array.InternalArray__get_Item<InterpretedFrameInfo>
	|
	|-RVA: 0x219DF50 Offset: 0x219E051 VA: 0x219DF50
	|-Array.InternalArray__get_Item<IntervalTreeNode>
	|
	|-RVA: 0x219E010 Offset: 0x219E111 VA: 0x219E010
	|-Array.InternalArray__get_Item<JobHandle>
	|
	|-RVA: 0x219E0C0 Offset: 0x219E1C1 VA: 0x219E0C0
	|-Array.InternalArray__get_Item<Keyframe>
	|
	|-RVA: 0x219E190 Offset: 0x219E291 VA: 0x219E190
	|-Array.InternalArray__get_Item<LOD>
	|
	|-RVA: 0x219E240 Offset: 0x219E341 VA: 0x219E240
	|-Array.InternalArray__get_Item<LayerMask>
	|
	|-RVA: 0x219E2F0 Offset: 0x219E3F1 VA: 0x219E2F0
	|-Array.InternalArray__get_Item<LengthLimitProperties>
	|
	|-RVA: 0x219E3A0 Offset: 0x219E4A1 VA: 0x219E3A0
	|-Array.InternalArray__get_Item<Light2DBlendStyle>
	|
	|-RVA: 0x219E490 Offset: 0x219E591 VA: 0x219E490
	|-Array.InternalArray__get_Item<LightDataGI>
	|
	|-RVA: 0x219E580 Offset: 0x219E681 VA: 0x219E580
	|-Array.InternalArray__get_Item<LocalDefinition>
	|
	|-RVA: 0x219E630 Offset: 0x219E731 VA: 0x219E630
	|-Array.InternalArray__get_Item<MapPos>
	|
	|-RVA: 0x219E6E0 Offset: 0x219E7E1 VA: 0x219E6E0
	|-Array.InternalArray__get_Item<MapRange>
	|
	|-RVA: 0x219E790 Offset: 0x219E891 VA: 0x219E790
	|-Array.InternalArray__get_Item<MaterialReference>
	|
	|-RVA: 0x219E870 Offset: 0x219E971 VA: 0x219E870
	|-Array.InternalArray__get_Item<Matrix4x4>
	|
	|-RVA: 0x219E950 Offset: 0x219EA51 VA: 0x219E950
	|-Array.InternalArray__get_Item<MomentProcessorState>
	|
	|-RVA: 0x219EA20 Offset: 0x219EB21 VA: 0x219EA20
	|-Array.InternalArray__get_Item<MomentStatistic>
	|
	|-RVA: 0x219EAD0 Offset: 0x219EBD1 VA: 0x219EAD0
	|-Array.InternalArray__get_Item<Navigation>
	|
	|-RVA: 0x219EBA0 Offset: 0x219ECA1 VA: 0x219EBA0
	|-Array.InternalArray__get_Item<NetworkServiceAccountId>
	|
	|-RVA: 0x219EC50 Offset: 0x219ED51 VA: 0x219EC50
	|-Array.InternalArray__get_Item<NpadFullKeyState>
	|
	|-RVA: 0x219ED20 Offset: 0x219EE21 VA: 0x219ED20
	|-Array.InternalArray__get_Item<NpadHandheldState>
	|
	|-RVA: 0x219EDF0 Offset: 0x219EEF1 VA: 0x219EDF0
	|-Array.InternalArray__get_Item<NpadJoyDualState>
	|
	|-RVA: 0x219EEC0 Offset: 0x219EFC1 VA: 0x219EEC0
	|-Array.InternalArray__get_Item<NpadJoyLeftState>
	|
	|-RVA: 0x219EF90 Offset: 0x219F091 VA: 0x219EF90
	|-Array.InternalArray__get_Item<NpadJoyRightState>
	|
	|-RVA: 0x219F060 Offset: 0x219F161 VA: 0x219F060
	|-Array.InternalArray__get_Item<NpadStateArrayItem>
	|
	|-RVA: 0x219F130 Offset: 0x219F231 VA: 0x219F130
	|-Array.InternalArray__get_Item<NsUid>
	|
	|-RVA: 0x219F1E0 Offset: 0x219F2E1 VA: 0x219F1E0
	|-Array.InternalArray__get_Item<object>
	|
	|-RVA: 0x219F290 Offset: 0x219F391 VA: 0x219F290
	|-Array.InternalArray__get_Item<ObjectInitializationData>
	|
	|-RVA: 0x219F360 Offset: 0x219F461 VA: 0x219F360
	|-Array.InternalArray__get_Item<ParameterModifier>
	|
	|-RVA: 0x219F410 Offset: 0x219F511 VA: 0x219F410
	|-Array.InternalArray__get_Item<Plane>
	|
	|-RVA: 0x219F4C0 Offset: 0x219F5C1 VA: 0x219F4C0
	|-Array.InternalArray__get_Item<Playable>
	|
	|-RVA: 0x219F570 Offset: 0x219F671 VA: 0x219F570
	|-Array.InternalArray__get_Item<PlayableBinding>
	|
	|-RVA: 0x219F630 Offset: 0x219F731 VA: 0x219F630
	|-Array.InternalArray__get_Item<PlayerLoopSystem>
	|
	|-RVA: 0x219F700 Offset: 0x219F801 VA: 0x219F700
	|-Array.InternalArray__get_Item<PlayerLoopSystemInternal>
	|
	|-RVA: 0x219F7D0 Offset: 0x219F8D1 VA: 0x219F7D0
	|-Array.InternalArray__get_Item<PreTile>
	|
	|-RVA: 0x219F8B0 Offset: 0x219F9B1 VA: 0x219F8B0
	|-Array.InternalArray__get_Item<Profile>
	|
	|-RVA: 0x219F9B0 Offset: 0x219FAB1 VA: 0x219F9B0
	|-Array.InternalArray__get_Item<Protrusion>
	|
	|-RVA: 0x219FA60 Offset: 0x219FB61 VA: 0x219FA60
	|-Array.InternalArray__get_Item<Quaternion>
	|
	|-RVA: 0x219FB10 Offset: 0x219FC11 VA: 0x219FB10
	|-Array.InternalArray__get_Item<RandomSeed>
	|
	|-RVA: 0x219FBC0 Offset: 0x219FCC1 VA: 0x219FBC0
	|-Array.InternalArray__get_Item<RangePositionInfo>
	|
	|-RVA: 0x219FC70 Offset: 0x219FD71 VA: 0x219FC70
	|-Array.InternalArray__get_Item<Ranking2ChartInfoInput>
	|
	|-RVA: 0x219FD20 Offset: 0x219FE21 VA: 0x219FD20
	|-Array.InternalArray__get_Item<RaycastHit>
	|
	|-RVA: 0x219FE00 Offset: 0x219FF01 VA: 0x219FE00
	|-Array.InternalArray__get_Item<RaycastHit2D>
	|
	|-RVA: 0x219FED0 Offset: 0x219FFD1 VA: 0x219FED0
	|-Array.InternalArray__get_Item<RaycastResult>
	|
	|-RVA: 0x219FFC0 Offset: 0x21A00C1 VA: 0x219FFC0
	|-Array.InternalArray__get_Item<Rect>
	|
	|-RVA: 0x21A0070 Offset: 0x21A0171 VA: 0x21A0070
	|-Array.InternalArray__get_Item<RenderBuffer>
	|
	|-RVA: 0x21A0120 Offset: 0x21A0221 VA: 0x21A0120
	|-Array.InternalArray__get_Item<RenderStateBlock>
	|
	|-RVA: 0x21A0230 Offset: 0x21A0331 VA: 0x21A0230
	|-Array.InternalArray__get_Item<RenderTargetHandle>
	|
	|-RVA: 0x21A0300 Offset: 0x21A0401 VA: 0x21A0300
	|-Array.InternalArray__get_Item<RenderTargetIdentifier>
	|
	|-RVA: 0x21A03D0 Offset: 0x21A04D1 VA: 0x21A03D0
	|-Array.InternalArray__get_Item<RendererListHandle>
	|
	|-RVA: 0x21A0480 Offset: 0x21A0581 VA: 0x21A0480
	|-Array.InternalArray__get_Item<ResourceHandle>
	|
	|-RVA: 0x21A0530 Offset: 0x21A0631 VA: 0x21A0530
	|-Array.InternalArray__get_Item<ResourceLocator>
	|
	|-RVA: 0x21A05E0 Offset: 0x21A06E1 VA: 0x21A05E0
	|-Array.InternalArray__get_Item<RichTextTagAttribute>
	|
	|-RVA: 0x21A06A0 Offset: 0x21A07A1 VA: 0x21A06A0
	|-Array.InternalArray__get_Item<RuntimeLabel>
	|
	|-RVA: 0x21A0750 Offset: 0x21A0851 VA: 0x21A0750
	|-Array.InternalArray__get_Item<sbyte>
	|
	|-RVA: 0x21A0800 Offset: 0x21A0901 VA: 0x21A0800
	|-Array.InternalArray__get_Item<SerializedType>
	|
	|-RVA: 0x21A08C0 Offset: 0x21A09C1 VA: 0x21A08C0
	|-Array.InternalArray__get_Item<ShaderKeyword>
	|
	|-RVA: 0x21A0970 Offset: 0x21A0A71 VA: 0x21A0970
	|-Array.InternalArray__get_Item<ShaderTagId>
	|
	|-RVA: 0x21A0A20 Offset: 0x21A0B21 VA: 0x21A0A20
	|-Array.InternalArray__get_Item<ShadowSliceData>
	|
	|-RVA: 0x21A0B10 Offset: 0x21A0C11 VA: 0x21A0B10
	|-Array.InternalArray__get_Item<Shape>
	|
	|-RVA: 0x21A0BD0 Offset: 0x21A0CD1 VA: 0x21A0BD0
	|-Array.InternalArray__get_Item<float>
	|
	|-RVA: 0x21A0C80 Offset: 0x21A0D81 VA: 0x21A0C80
	|-Array.InternalArray__get_Item<SixAxisSensorHandle>
	|
	|-RVA: 0x21A0D30 Offset: 0x21A0E31 VA: 0x21A0D30
	|-Array.InternalArray__get_Item<SixAxisSensorState>
	|
	|-RVA: 0x21A0E20 Offset: 0x21A0F21 VA: 0x21A0E20
	|-Array.InternalArray__get_Item<SkeletonBone>
	|
	|-RVA: 0x21A0F00 Offset: 0x21A1001 VA: 0x21A0F00
	|-Array.InternalArray__get_Item<SortingLayer>
	|
	|-RVA: 0x21A0FB0 Offset: 0x21A10B1 VA: 0x21A0FB0
	|-Array.InternalArray__get_Item<SphericalHarmonicsL2>
	|
	|-RVA: 0x21A10C0 Offset: 0x21A11C1 VA: 0x21A10C0
	|-Array.InternalArray__get_Item<SpinLock>
	|
	|-RVA: 0x21A1170 Offset: 0x21A1271 VA: 0x21A1170
	|-Array.InternalArray__get_Item<SpringBoneComponents>
	|
	|-RVA: 0x21A1260 Offset: 0x21A1361 VA: 0x21A1260
	|-Array.InternalArray__get_Item<SpringBoneProperties>
	|
	|-RVA: 0x21A1350 Offset: 0x21A1451 VA: 0x21A1350
	|-Array.InternalArray__get_Item<SpringColliderComponents>
	|
	|-RVA: 0x21A1460 Offset: 0x21A1561 VA: 0x21A1460
	|-Array.InternalArray__get_Item<SpringColliderProperties>
	|
	|-RVA: 0x21A1510 Offset: 0x21A1611 VA: 0x21A1510
	|-Array.InternalArray__get_Item<SpringForceComponent>
	|
	|-RVA: 0x21A15F0 Offset: 0x21A16F1 VA: 0x21A15F0
	|-Array.InternalArray__get_Item<SpringJobElement>
	|
	|-RVA: 0x21A16E0 Offset: 0x21A17E1 VA: 0x21A16E0
	|-Array.InternalArray__get_Item<SpriteState>
	|
	|-RVA: 0x21A17A0 Offset: 0x21A18A1 VA: 0x21A17A0
	|-Array.InternalArray__get_Item<SubMeshDescriptor>
	|
	|-RVA: 0x21A1870 Offset: 0x21A1971 VA: 0x21A1870
	|-Array.InternalArray__get_Item<TMP_CharacterInfo>
	|
	|-RVA: 0x21A1940 Offset: 0x21A1A41 VA: 0x21A1940
	|-Array.InternalArray__get_Item<TMP_FontWeightPair>
	|
	|-RVA: 0x21A19F0 Offset: 0x21A1AF1 VA: 0x21A19F0
	|-Array.InternalArray__get_Item<TMP_LineInfo>
	|
	|-RVA: 0x21A1AF0 Offset: 0x21A1BF1 VA: 0x21A1AF0
	|-Array.InternalArray__get_Item<TMP_LinkInfo>
	|
	|-RVA: 0x21A1BC0 Offset: 0x21A1CC1 VA: 0x21A1BC0
	|-Array.InternalArray__get_Item<TMP_MeshInfo>
	|
	|-RVA: 0x21A1CB0 Offset: 0x21A1DB1 VA: 0x21A1CB0
	|-Array.InternalArray__get_Item<TMP_PageInfo>
	|
	|-RVA: 0x21A1D70 Offset: 0x21A1E71 VA: 0x21A1D70
	|-Array.InternalArray__get_Item<TMP_WordInfo>
	|
	|-RVA: 0x21A1E30 Offset: 0x21A1F31 VA: 0x21A1E30
	|-Array.InternalArray__get_Item<TablePair>
	|
	|-RVA: 0x21A1EE0 Offset: 0x21A1FE1 VA: 0x21A1EE0
	|-Array.InternalArray__get_Item<TextureHandle>
	|
	|-RVA: 0x21A1F90 Offset: 0x21A2091 VA: 0x21A1F90
	|-Array.InternalArray__get_Item<TimeSpan>
	|
	|-RVA: 0x21A2040 Offset: 0x21A2141 VA: 0x21A2040
	|-Array.InternalArray__get_Item<Touch>
	|
	|-RVA: 0x21A2130 Offset: 0x21A2231 VA: 0x21A2130
	|-Array.InternalArray__get_Item<TouchScreenState1>
	|
	|-RVA: 0x21A2210 Offset: 0x21A2311 VA: 0x21A2210
	|-Array.InternalArray__get_Item<TouchScreenState10>
	|
	|-RVA: 0x21A22E0 Offset: 0x21A23E1 VA: 0x21A22E0
	|-Array.InternalArray__get_Item<TouchScreenState11>
	|
	|-RVA: 0x21A23B0 Offset: 0x21A24B1 VA: 0x21A23B0
	|-Array.InternalArray__get_Item<TouchScreenState12>
	|
	|-RVA: 0x21A2480 Offset: 0x21A2581 VA: 0x21A2480
	|-Array.InternalArray__get_Item<TouchScreenState13>
	|
	|-RVA: 0x21A2550 Offset: 0x21A2651 VA: 0x21A2550
	|-Array.InternalArray__get_Item<TouchScreenState14>
	|
	|-RVA: 0x21A2620 Offset: 0x21A2721 VA: 0x21A2620
	|-Array.InternalArray__get_Item<TouchScreenState15>
	|
	|-RVA: 0x21A26F0 Offset: 0x21A27F1 VA: 0x21A26F0
	|-Array.InternalArray__get_Item<TouchScreenState16>
	|
	|-RVA: 0x21A27C0 Offset: 0x21A28C1 VA: 0x21A27C0
	|-Array.InternalArray__get_Item<TouchScreenState2>
	|
	|-RVA: 0x21A28B0 Offset: 0x21A29B1 VA: 0x21A28B0
	|-Array.InternalArray__get_Item<TouchScreenState3>
	|
	|-RVA: 0x21A2990 Offset: 0x21A2A91 VA: 0x21A2990
	|-Array.InternalArray__get_Item<TouchScreenState4>
	|
	|-RVA: 0x21A2A80 Offset: 0x21A2B81 VA: 0x21A2A80
	|-Array.InternalArray__get_Item<TouchScreenState5>
	|
	|-RVA: 0x21A2B70 Offset: 0x21A2C71 VA: 0x21A2B70
	|-Array.InternalArray__get_Item<TouchScreenState6>
	|
	|-RVA: 0x21A2C70 Offset: 0x21A2D71 VA: 0x21A2C70
	|-Array.InternalArray__get_Item<TouchScreenState7>
	|
	|-RVA: 0x21A2D40 Offset: 0x21A2E41 VA: 0x21A2D40
	|-Array.InternalArray__get_Item<TouchScreenState8>
	|
	|-RVA: 0x21A2E10 Offset: 0x21A2F11 VA: 0x21A2E10
	|-Array.InternalArray__get_Item<TouchScreenState9>
	|
	|-RVA: 0x21A2EE0 Offset: 0x21A2FE1 VA: 0x21A2EE0
	|-Array.InternalArray__get_Item<TouchState>
	|
	|-RVA: 0x21A2FB0 Offset: 0x21A30B1 VA: 0x21A2FB0
	|-Array.InternalArray__get_Item<TrailHand>
	|
	|-RVA: 0x21A3070 Offset: 0x21A3171 VA: 0x21A3070
	|-Array.InternalArray__get_Item<TrailVertex>
	|
	|-RVA: 0x21A3130 Offset: 0x21A3231 VA: 0x21A3130
	|-Array.InternalArray__get_Item<UICharInfo>
	|
	|-RVA: 0x21A31E0 Offset: 0x21A32E1 VA: 0x21A31E0
	|-Array.InternalArray__get_Item<UILineInfo>
	|
	|-RVA: 0x21A3290 Offset: 0x21A3391 VA: 0x21A3290
	|-Array.InternalArray__get_Item<UIVertex>
	|
	|-RVA: 0x21A33A0 Offset: 0x21A34A1 VA: 0x21A33A0
	|-Array.InternalArray__get_Item<ushort>
	|
	|-RVA: 0x21A3450 Offset: 0x21A3551 VA: 0x21A3450
	|-Array.InternalArray__get_Item<UInt16Enum>
	|
	|-RVA: 0x21A3500 Offset: 0x21A3601 VA: 0x21A3500
	|-Array.InternalArray__get_Item<uint>
	|
	|-RVA: 0x21A35B0 Offset: 0x21A36B1 VA: 0x21A35B0
	|-Array.InternalArray__get_Item<UInt32Enum>
	|
	|-RVA: 0x21A3660 Offset: 0x21A3761 VA: 0x21A3660
	|-Array.InternalArray__get_Item<ulong>
	|
	|-RVA: 0x21A3710 Offset: 0x21A3811 VA: 0x21A3710
	|-Array.InternalArray__get_Item<Uid>
	|
	|-RVA: 0x21A37C0 Offset: 0x21A38C1 VA: 0x21A37C0
	|-Array.InternalArray__get_Item<UniTask>
	|
	|-RVA: 0x21A3870 Offset: 0x21A3971 VA: 0x21A3870
	|-Array.InternalArray__get_Item<Unit>
	|
	|-RVA: 0x21A3920 Offset: 0x21A3A21 VA: 0x21A3920
	|-Array.InternalArray__get_Item<UnitEnum>
	|
	|-RVA: 0x21A39D0 Offset: 0x21A3AD1 VA: 0x21A39D0
	|-Array.InternalArray__get_Item<UserWord>
	|
	|-RVA: 0x21A3A80 Offset: 0x21A3B81 VA: 0x21A3A80
	|-Array.InternalArray__get_Item<Vector2>
	|
	|-RVA: 0x21A3B30 Offset: 0x21A3C31 VA: 0x21A3B30
	|-Array.InternalArray__get_Item<Vector2Int>
	|
	|-RVA: 0x21A3BE0 Offset: 0x21A3CE1 VA: 0x21A3BE0
	|-Array.InternalArray__get_Item<Vector3>
	|
	|-RVA: 0x21A3C90 Offset: 0x21A3D91 VA: 0x21A3C90
	|-Array.InternalArray__get_Item<Vector4>
	|
	|-RVA: 0x21A3D40 Offset: 0x21A3E41 VA: 0x21A3D40
	|-Array.InternalArray__get_Item<VertexAttributeDescriptor>
	|
	|-RVA: 0x21A3DF0 Offset: 0x21A3EF1 VA: 0x21A3DF0
	|-Array.InternalArray__get_Item<VibrationDeviceHandle>
	|
	|-RVA: 0x21A3EA0 Offset: 0x21A3FA1 VA: 0x21A3EA0
	|-Array.InternalArray__get_Item<VibrationDeviceInfo>
	|
	|-RVA: 0x21A3F50 Offset: 0x21A4051 VA: 0x21A3F50
	|-Array.InternalArray__get_Item<VibrationValue>
	|
	|-RVA: 0x21A4000 Offset: 0x21A4101 VA: 0x21A4000
	|-Array.InternalArray__get_Item<VisibleLight>
	|
	|-RVA: 0x21A4110 Offset: 0x21A4211 VA: 0x21A4110
	|-Array.InternalArray__get_Item<WordWrapState>
	|
	|-RVA: 0x21A41E0 Offset: 0x21A42E1 VA: 0x21A41E0
	|-Array.InternalArray__get_Item<X509ChainStatus>
	|
	|-RVA: 0x21A4290 Offset: 0x21A4391 VA: 0x21A4290
	|-Array.InternalArray__get_Item<XPathNode>
	|
	|-RVA: 0x21A4350 Offset: 0x21A4451 VA: 0x21A4350
	|-Array.InternalArray__get_Item<XPathNodeRef>
	|
	|-RVA: 0x21A4400 Offset: 0x21A4501 VA: 0x21A4400
	|-Array.InternalArray__get_Item<XRView>
	|
	|-RVA: 0x21A44E0 Offset: 0x21A45E1 VA: 0x21A44E0
	|-Array.InternalArray__get_Item<float3>
	|
	|-RVA: 0x21A4590 Offset: 0x21A4691 VA: 0x21A4590
	|-Array.InternalArray__get_Item<float4x4>
	|
	|-RVA: 0x21A4670 Offset: 0x21A4771 VA: 0x21A4670
	|-Array.InternalArray__get_Item<jvalue>
	|
	|-RVA: 0x21A4720 Offset: 0x21A4821 VA: 0x21A4720
	|-Array.InternalArray__get_Item<uint4>
	|
	|-RVA: 0x21A47D0 Offset: 0x21A48D1 VA: 0x21A47D0
	|-Array.InternalArray__get_Item<AICrossfire.PositionTable>
	|
	|-RVA: 0x21A4880 Offset: 0x21A4981 VA: 0x21A4880
	|-Array.InternalArray__get_Item<AIEnum.SkillRangeEnemyData>
	|
	|-RVA: 0x21A4930 Offset: 0x21A4A31 VA: 0x21A4930
	|-Array.InternalArray__get_Item<AIOrder.UnitPriority>
	|
	|-RVA: 0x21A49E0 Offset: 0x21A4AE1 VA: 0x21A49E0
	|-Array.InternalArray__get_Item<AmiiboSequence.GainItemData>
	|
	|-RVA: 0x21A4A90 Offset: 0x21A4B91 VA: 0x21A4A90
	|-Array.InternalArray__get_Item<AnimationOutputWeightProcessor.WeightInfo>
	|
	|-RVA: 0x21A4B60 Offset: 0x21A4C61 VA: 0x21A4B60
	|-Array.InternalArray__get_Item<ArenaOrderSequence.GodInfo>
	|
	|-RVA: 0x21A4C10 Offset: 0x21A4D11 VA: 0x21A4C10
	|-Array.InternalArray__get_Item<BattleInfo.SupportData>
	|
	|-RVA: 0x21A4CC0 Offset: 0x21A4DC1 VA: 0x21A4CC0
	|-Array.InternalArray__get_Item<BeforeRenderHelper.OrderBlock>
	|
	|-RVA: 0x21A4D70 Offset: 0x21A4E71 VA: 0x21A4D70
	|-Array.InternalArray__get_Item<Camera.RenderRequest>
	|
	|-RVA: 0x21A4E30 Offset: 0x21A4F31 VA: 0x21A4E30
	|-Array.InternalArray__get_Item<CameraState.CustomBlendable>
	|
	|-RVA: 0x21A4EE0 Offset: 0x21A4FE1 VA: 0x21A4EE0
	|-Array.InternalArray__get_Item<CinemachineBlendListCamera.Instruction>
	|
	|-RVA: 0x21A4FA0 Offset: 0x21A50A1 VA: 0x21A4FA0
	|-Array.InternalArray__get_Item<CinemachineBlenderSettings.CustomBlend>
	|
	|-RVA: 0x21A5060 Offset: 0x21A5161 VA: 0x21A5060
	|-Array.InternalArray__get_Item<CinemachineClearShot.Pair>
	|
	|-RVA: 0x21A5110 Offset: 0x21A5211 VA: 0x21A5110
	|-Array.InternalArray__get_Item<CinemachineFreeLook.Orbit>
	|
	|-RVA: 0x21A51C0 Offset: 0x21A52C1 VA: 0x21A51C0
	|-Array.InternalArray__get_Item<CinemachinePath.Waypoint>
	|
	|-RVA: 0x21A5290 Offset: 0x21A5391 VA: 0x21A5290
	|-Array.InternalArray__get_Item<CinemachineSmoothPath.Waypoint>
	|
	|-RVA: 0x21A5340 Offset: 0x21A5441 VA: 0x21A5340
	|-Array.InternalArray__get_Item<CinemachineStateDrivenCamera.HashPair>
	|
	|-RVA: 0x21A53F0 Offset: 0x21A54F1 VA: 0x21A53F0
	|-Array.InternalArray__get_Item<CinemachineStateDrivenCamera.Instruction>
	|
	|-RVA: 0x21A54B0 Offset: 0x21A55B1 VA: 0x21A54B0
	|-Array.InternalArray__get_Item<CinemachineStateDrivenCamera.ParentHash>
	|
	|-RVA: 0x21A5560 Offset: 0x21A5661 VA: 0x21A5560
	|-Array.InternalArray__get_Item<CinemachineTargetGroup.Target>
	|
	|-RVA: 0x21A5610 Offset: 0x21A5711 VA: 0x21A5610
	|-Array.InternalArray__get_Item<CodePointIndexer.TableRange>
	|
	|-RVA: 0x21A56D0 Offset: 0x21A57D1 VA: 0x21A56D0
	|-Array.InternalArray__get_Item<ContentCatalogData.Bucket>
	|
	|-RVA: 0x21A5780 Offset: 0x21A5881 VA: 0x21A5780
	|-Array.InternalArray__get_Item<CookieTokenizer.RecognizedAttribute>
	|
	|-RVA: 0x21A5830 Offset: 0x21A5931 VA: 0x21A5830
	|-Array.InternalArray__get_Item<DeferredLights.DrawCall>
	|
	|-RVA: 0x21A5900 Offset: 0x21A5A01 VA: 0x21A5900
	|-Array.InternalArray__get_Item<DeferredShaderData.ComputeBufferInfo>
	|
	|-RVA: 0x21A59B0 Offset: 0x21A5AB1 VA: 0x21A59B0
	|-Array.InternalArray__get_Item<DeferredTiler.PrePunctualLight>
	|
	|-RVA: 0x21A5A70 Offset: 0x21A5B71 VA: 0x21A5A70
	|-Array.InternalArray__get_Item<DelayedActionManager.DelegateInfo>
	|
	|-RVA: 0x21A5B30 Offset: 0x21A5C31 VA: 0x21A5B30
	|-Array.InternalArray__get_Item<Detail.AsyncResultInt>
	|
	|-RVA: 0x21A5C00 Offset: 0x21A5D01 VA: 0x21A5C00
	|-Array.InternalArray__get_Item<Detail.CppArray>
	|
	|-RVA: 0x21A5CB0 Offset: 0x21A5DB1 VA: 0x21A5CB0
	|-Array.InternalArray__get_Item<Detail.NotificationEventInt>
	|
	|-RVA: 0x21A5D80 Offset: 0x21A5E81 VA: 0x21A5D80
	|-Array.InternalArray__get_Item<DisposUnit.Item>
	|
	|-RVA: 0x21A5E30 Offset: 0x21A5F31 VA: 0x21A5E30
	|-Array.InternalArray__get_Item<DragonRidePresetParamData.CourseData>
	|
	|-RVA: 0x21A5EE0 Offset: 0x21A5FE1 VA: 0x21A5EE0
	|-Array.InternalArray__get_Item<DragonRideTargetGroup.ChainParam>
	|
	|-RVA: 0x21A5F90 Offset: 0x21A6091 VA: 0x21A5F90
	|-Array.InternalArray__get_Item<DynamicMesh.State>
	|
	|-RVA: 0x21A6040 Offset: 0x21A6141 VA: 0x21A6040
	|-Array.InternalArray__get_Item<FXZEx.HitPoint>
	|
	|-RVA: 0x21A6110 Offset: 0x21A6211 VA: 0x21A6110
	|-Array.InternalArray__get_Item<FishingRadicalParamData.RadicalParam>
	|
	|-RVA: 0x21A61C0 Offset: 0x21A62C1 VA: 0x21A61C0
	|-Array.InternalArray__get_Item<GameVariable.Value>
	|
	|-RVA: 0x21A6270 Offset: 0x21A6371 VA: 0x21A6270
	|-Array.InternalArray__get_Item<GmapPathAdjuster.TargetModel>
	|
	|-RVA: 0x21A6330 Offset: 0x21A6431 VA: 0x21A6330
	|-Array.InternalArray__get_Item<GmapSpotAdjuster.TargetModel>
	|
	|-RVA: 0x21A63F0 Offset: 0x21A64F1 VA: 0x21A63F0
	|-Array.InternalArray__get_Item<GrounderQuadruped.Foot>
	|
	|-RVA: 0x21A64C0 Offset: 0x21A65C1 VA: 0x21A64C0
	|-Array.InternalArray__get_Item<Hashtable.bucket>
	|
	|-RVA: 0x21A6580 Offset: 0x21A6681 VA: 0x21A6580
	|-Array.InternalArray__get_Item<HeadingTracker.Item>
	|
	|-RVA: 0x21A6640 Offset: 0x21A6741 VA: 0x21A6640
	|-Array.InternalArray__get_Item<HubAccessoryRoomCamera.BackgroundSettings>
	|
	|-RVA: 0x21A6710 Offset: 0x21A6811 VA: 0x21A6710
	|-Array.InternalArray__get_Item<HubFastTravel.Location>
	|
	|-RVA: 0x21A67D0 Offset: 0x21A68D1 VA: 0x21A67D0
	|-Array.InternalArray__get_Item<HubLensFlare.Flare>
	|
	|-RVA: 0x21A68A0 Offset: 0x21A69A1 VA: 0x21A68A0
	|-Array.InternalArray__get_Item<HubLookAtController.LookAtIKParam>
	|
	|-RVA: 0x21A6950 Offset: 0x21A6A51 VA: 0x21A6950
	|-Array.InternalArray__get_Item<HubMaterialArray.MaterialInfo>
	|
	|-RVA: 0x21A6A00 Offset: 0x21A6B01 VA: 0x21A6A00
	|-Array.InternalArray__get_Item<IKSolverLimb.AxisDirection>
	|
	|-RVA: 0x21A6AD0 Offset: 0x21A6BD1 VA: 0x21A6AD0
	|-Array.InternalArray__get_Item<InventoryPoolItemMenuContent.KindBgNameClass>
	|
	|-RVA: 0x21A6B80 Offset: 0x21A6C81 VA: 0x21A6B80
	|-Array.InternalArray__get_Item<LightUtility.ParametricLightMeshVertex>
	|
	|-RVA: 0x21A6C50 Offset: 0x21A6D51 VA: 0x21A6C50
	|-Array.InternalArray__get_Item<LightUtility.SpriteLightMeshVertex>
	|
	|-RVA: 0x21A6D20 Offset: 0x21A6E21 VA: 0x21A6D20
	|-Array.InternalArray__get_Item<Map.Pos>
	|
	|-RVA: 0x21A6DD0 Offset: 0x21A6ED1 VA: 0x21A6DD0
	|-Array.InternalArray__get_Item<MapGodExp.KindDesc>
	|
	|-RVA: 0x21A6E80 Offset: 0x21A6F81 VA: 0x21A6E80
	|-Array.InternalArray__get_Item<MapHistory.Command>
	|
	|-RVA: 0x21A6F30 Offset: 0x21A7031 VA: 0x21A6F30
	|-Array.InternalArray__get_Item<MapImage.BackupTerrain>
	|
	|-RVA: 0x21A6FE0 Offset: 0x21A70E1 VA: 0x21A6FE0
	|-Array.InternalArray__get_Item<MapImageRange.Pos>
	|
	|-RVA: 0x21A7090 Offset: 0x21A7191 VA: 0x21A7090
	|-Array.InternalArray__get_Item<MapKillBonus.KillBonus>
	|
	|-RVA: 0x21A7140 Offset: 0x21A7241 VA: 0x21A7140
	|-Array.InternalArray__get_Item<MapKillBonus.KilledBonus>
	|
	|-RVA: 0x21A71F0 Offset: 0x21A72F1 VA: 0x21A71F0
	|-Array.InternalArray__get_Item<MapMind.Record>
	|
	|-RVA: 0x21A72E0 Offset: 0x21A73E1 VA: 0x21A72E0
	|-Array.InternalArray__get_Item<MapMind.Target>
	|
	|-RVA: 0x21A73A0 Offset: 0x21A74A1 VA: 0x21A73A0
	|-Array.InternalArray__get_Item<MapPanelDebug.Entity>
	|
	|-RVA: 0x21A7460 Offset: 0x21A7561 VA: 0x21A7460
	|-Array.InternalArray__get_Item<NexRanking.Data>
	|
	|-RVA: 0x21A7510 Offset: 0x21A7611 VA: 0x21A7510
	|-Array.InternalArray__get_Item<NexVersus.RatingData>
	|
	|-RVA: 0x21A75C0 Offset: 0x21A76C1 VA: 0x21A75C0
	|-Array.InternalArray__get_Item<NoiseSettings.TransformNoiseParams>
	|
	|-RVA: 0x21A7690 Offset: 0x21A7791 VA: 0x21A7690
	|-Array.InternalArray__get_Item<PackedPlayModeBuildLogs.RuntimeBuildLog>
	|
	|-RVA: 0x21A7740 Offset: 0x21A7841 VA: 0x21A7740
	|-Array.InternalArray__get_Item<ParameterizedStrings.FormatParam>
	|
	|-RVA: 0x21A77F0 Offset: 0x21A78F1 VA: 0x21A77F0
	|-Array.InternalArray__get_Item<ParticleSystem.Particle>
	|
	|-RVA: 0x21A78D0 Offset: 0x21A79D1 VA: 0x21A78D0
	|-Array.InternalArray__get_Item<ProfileCard.Achievement>
	|
	|-RVA: 0x21A7980 Offset: 0x21A7A81 VA: 0x21A7980
	|-Array.InternalArray__get_Item<ProfileCard.SortieCount>
	|
	|-RVA: 0x21A7A40 Offset: 0x21A7B41 VA: 0x21A7A40
	|-Array.InternalArray__get_Item<QualitySettingsStack.Settings>
	|
	|-RVA: 0x21A7B10 Offset: 0x21A7C11 VA: 0x21A7B10
	|-Array.InternalArray__get_Item<RangeData.Offset>
	|
	|-RVA: 0x21A7BC0 Offset: 0x21A7CC1 VA: 0x21A7BC0
	|-Array.InternalArray__get_Item<RegexCharClass.LowerCaseMapping>
	|
	|-RVA: 0x21A7C70 Offset: 0x21A7D71 VA: 0x21A7C70
	|-Array.InternalArray__get_Item<Relay.ChooseAwardeeData>
	|
	|-RVA: 0x21A7D30 Offset: 0x21A7E31 VA: 0x21A7D30
	|-Array.InternalArray__get_Item<RelayAwardData.Info>
	|
	|-RVA: 0x21A7DE0 Offset: 0x21A7EE1 VA: 0x21A7DE0
	|-Array.InternalArray__get_Item<RenderGraph.CompiledPassInfo>
	|
	|-RVA: 0x21A7ED0 Offset: 0x21A7FD1 VA: 0x21A7ED0
	|-Array.InternalArray__get_Item<RenderGraph.CompiledResourceInfo>
	|
	|-RVA: 0x21A7F90 Offset: 0x21A8091 VA: 0x21A7F90
	|-Array.InternalArray__get_Item<RenderGraphDebugData.PassDebugData>
	|
	|-RVA: 0x21A8050 Offset: 0x21A8151 VA: 0x21A8050
	|-Array.InternalArray__get_Item<RenderGraphDebugData.ResourceDebugData>
	|
	|-RVA: 0x21A8120 Offset: 0x21A8221 VA: 0x21A8120
	|-Array.InternalArray__get_Item<RenderGraphResourceRegistry.RendererListResource>
	|
	|-RVA: 0x21A81F0 Offset: 0x21A82F1 VA: 0x21A81F0
	|-Array.InternalArray__get_Item<RingCleaningUnitSelectMenu.GodParam>
	|
	|-RVA: 0x21A82A0 Offset: 0x21A83A1 VA: 0x21A82A0
	|-Array.InternalArray__get_Item<SampleWave.Data>
	|
	|-RVA: 0x21A8350 Offset: 0x21A8451 VA: 0x21A8350
	|-Array.InternalArray__get_Item<SampleWave.Temp>
	|
	|-RVA: 0x21A8400 Offset: 0x21A8501 VA: 0x21A8400
	|-Array.InternalArray__get_Item<SendMouseEvents.HitInfo>
	|
	|-RVA: 0x21A84B0 Offset: 0x21A85B1 VA: 0x21A84B0
	|-Array.InternalArray__get_Item<SequenceNode.SequenceConstructPosContext>
	|
	|-RVA: 0x21A8580 Offset: 0x21A8681 VA: 0x21A8580
	|-Array.InternalArray__get_Item<ShaderInput.LightData>
	|
	|-RVA: 0x21A8670 Offset: 0x21A8771 VA: 0x21A8670
	|-Array.InternalArray__get_Item<ShaderInput.ShadowData>
	|
	|-RVA: 0x21A8760 Offset: 0x21A8861 VA: 0x21A8760
	|-Array.InternalArray__get_Item<ShadowUtility.Edge>
	|
	|-RVA: 0x21A8830 Offset: 0x21A8931 VA: 0x21A8830
	|-Array.InternalArray__get_Item<SimpleAnimationPlayable.QueuedState>
	|
	|-RVA: 0x21A88E0 Offset: 0x21A89E1 VA: 0x21A88E0
	|-Array.InternalArray__get_Item<SkillArray.Entity>
	|
	|-RVA: 0x21A8990 Offset: 0x21A8A91 VA: 0x21A8990
	|-Array.InternalArray__get_Item<Socket.WSABUF>
	|
	|-RVA: 0x21A8A40 Offset: 0x21A8B41 VA: 0x21A8A40
	|-Array.InternalArray__get_Item<Stream.Info>
	|
	|-RVA: 0x21A8AF0 Offset: 0x21A8BF1 VA: 0x21A8AF0
	|-Array.InternalArray__get_Item<TMP_Text.UnicodeChar>
	|
	|-RVA: 0x21A8BA0 Offset: 0x21A8CA1 VA: 0x21A8BA0
	|-Array.InternalArray__get_Item<TexturePacker_JsonArray.Frame>
	|
	|-RVA: 0x21A8C80 Offset: 0x21A8D81 VA: 0x21A8C80
	|-Array.InternalArray__get_Item<TimeNotificationBehaviour.NotificationEntry>
	|
	|-RVA: 0x21A8D40 Offset: 0x21A8E41 VA: 0x21A8D40
	|-Array.InternalArray__get_Item<UnitySynchronizationContext.WorkRequest>
	|
	|-RVA: 0x21A8E00 Offset: 0x21A8F01 VA: 0x21A8E00
	|-Array.InternalArray__get_Item<XmlNamespaceManager.NamespaceDeclaration>
	|
	|-RVA: 0x21A8EC0 Offset: 0x21A8FC1 VA: 0x21A8EC0
	|-Array.InternalArray__get_Item<XmlSchemaObjectTable.XmlSchemaObjectEntry>
	|
	|-RVA: 0x21A8F70 Offset: 0x21A9071 VA: 0x21A8F70
	|-Array.InternalArray__get_Item<XmlTextReaderImpl.ParsingState>
	|
	|-RVA: 0x21A9080 Offset: 0x21A9181 VA: 0x21A9080
	|-Array.InternalArray__get_Item<AIThink.EnchantThink.Desc>
	|
	|-RVA: 0x21A9130 Offset: 0x21A9231 VA: 0x21A9130
	|-Array.InternalArray__get_Item<AIThink.EnchantThink.ItemInfo>
	|
	|-RVA: 0x21A91E0 Offset: 0x21A92E1 VA: 0x21A91E0
	|-Array.InternalArray__get_Item<AIThink.EnchantThink.SurroundingInfo>
	|
	|-RVA: 0x21A9290 Offset: 0x21A9391 VA: 0x21A9290
	|-Array.InternalArray__get_Item<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>
	|
	|-RVA: 0x21A9340 Offset: 0x21A9441 VA: 0x21A9340
	|-Array.InternalArray__get_Item<Detail.DataStore.DataStoreChangeMetaParamInt>
	|
	|-RVA: 0x21A9440 Offset: 0x21A9541 VA: 0x21A9440
	|-Array.InternalArray__get_Item<Detail.DataStore.DataStoreDeleteParamInt>
	|
	|-RVA: 0x21A94F0 Offset: 0x21A95F1 VA: 0x21A94F0
	|-Array.InternalArray__get_Item<Detail.DataStore.DataStoreGetMetaParamInt>
	|
	|-RVA: 0x21A95C0 Offset: 0x21A96C1 VA: 0x21A95C0
	|-Array.InternalArray__get_Item<Detail.DataStore.DataStoreMetaInfoInt>
	|
	|-RVA: 0x21A96B0 Offset: 0x21A97B1 VA: 0x21A96B0
	|-Array.InternalArray__get_Item<Detail.DataStore.DataStorePasswordInfoInt>
	|
	|-RVA: 0x21A9770 Offset: 0x21A9871 VA: 0x21A9770
	|-Array.InternalArray__get_Item<Detail.DataStore.DataStorePersistenceInfoInt>
	|
	|-RVA: 0x21A9830 Offset: 0x21A9931 VA: 0x21A9830
	|-Array.InternalArray__get_Item<Detail.DataStore.DataStorePreparePostParamInt>
	|
	|-RVA: 0x21A9910 Offset: 0x21A9A11 VA: 0x21A9910
	|-Array.InternalArray__get_Item<Detail.DataStore.DataStoreRateObjectParamInt>
	|
	|-RVA: 0x21A99C0 Offset: 0x21A9AC1 VA: 0x21A99C0
	|-Array.InternalArray__get_Item<Detail.DataStore.DataStoreRatingInitParamInt>
	|
	|-RVA: 0x21A9A80 Offset: 0x21A9B81 VA: 0x21A9A80
	|-Array.InternalArray__get_Item<Detail.DataStore.DataStoreRatingTargetInt>
	|
	|-RVA: 0x2BF0120 Offset: 0x2BF0221 VA: 0x2BF0120
	|-Array.InternalArray__get_Item<Detail.Ranking.RankingCachedResultInt>
	|
	|-RVA: 0x2BF0200 Offset: 0x2BF0301 VA: 0x2BF0200
	|-Array.InternalArray__get_Item<Detail.Ranking.RankingOrderParamInt>
	|
	|-RVA: 0x2BF02B0 Offset: 0x2BF03B1 VA: 0x2BF02B0
	|-Array.InternalArray__get_Item<Detail.Ranking.RankingRankDataInt>
	|
	|-RVA: 0x2BF0390 Offset: 0x2BF0491 VA: 0x2BF0390
	|-Array.InternalArray__get_Item<Detail.Ranking2.Ranking2ChartInfoInt>
	|
	|-RVA: 0x2BF0480 Offset: 0x2BF0581 VA: 0x2BF0480
	|-Array.InternalArray__get_Item<Detail.Ranking2.Ranking2RankDataInt>
	|
	|-RVA: 0x2BF0560 Offset: 0x2BF0661 VA: 0x2BF0560
	|-Array.InternalArray__get_Item<Detail.Ranking2.Ranking2ScoreDataInt>
	|
	|-RVA: 0x2BF0610 Offset: 0x2BF0711 VA: 0x2BF0610
	|-Array.InternalArray__get_Item<Detail.Screening.ScreeningContextInfoInt>
	|
	|-RVA: 0x2BF06D0 Offset: 0x2BF07D1 VA: 0x2BF06D0
	|-Array.InternalArray__get_Item<Detail.Subscriber.SubscriberContentInt>
	|
	|-RVA: 0x2BF07C0 Offset: 0x2BF08C1 VA: 0x2BF07C0
	|-Array.InternalArray__get_Item<Detail.Subscriber.SubscriberGetContentParamInt>
	|
	|-RVA: 0x2BF0880 Offset: 0x2BF0981 VA: 0x2BF0880
	|-Array.InternalArray__get_Item<Detail.Subscriber.SubscriberUserStatusInfoInt>
	|
	|-RVA: 0x2BF0950 Offset: 0x2BF0A51 VA: 0x2BF0950
	|-Array.InternalArray__get_Item<Detail.Subscriber.SubscriberUserStatusParamInt>
	|
	|-RVA: 0x2BF0A10 Offset: 0x2BF0B11 VA: 0x2BF0A10
	|-Array.InternalArray__get_Item<Detail.Utility.IntegerSettings>
	|
	|-RVA: 0x2BF0AC0 Offset: 0x2BF0BC1 VA: 0x2BF0AC0
	|-Array.InternalArray__get_Item<Detail.Utility.UniqueIdInfoInt>
	|
	|-RVA: 0x2BF0B70 Offset: 0x2BF0C71 VA: 0x2BF0B70
	|-Array.InternalArray__get_Item<FacetsChecker.FacetsCompiler.Map>
	|
	|-RVA: 0x2BF0C20 Offset: 0x2BF0D21 VA: 0x2BF0C20
	|-Array.InternalArray__get_Item<MapHistory.ReplayAppearanceMap.Appearance>
	|
	|-RVA: 0x2BF0CE0 Offset: 0x2BF0DE1 VA: 0x2BF0CE0
	|-Array.InternalArray__get_Item<MapHistory.ReplayAppearanceMap.Leaving>
	|
	|-RVA: 0x2BF0D90 Offset: 0x2BF0E91 VA: 0x2BF0D90
	|-Array.InternalArray__get_Item<MapHistory.ReplayUnitMap.Data>
	|
	|-RVA: 0x2BF0E40 Offset: 0x2BF0F41 VA: 0x2BF0E40
	|-Array.InternalArray__get_Item<MapHistory.Rewind.LatestInspectorData>
	|
	|-RVA: 0x2BF0EF0 Offset: 0x2BF0FF1 VA: 0x2BF0EF0
	|-Array.InternalArray__get_Item<MapHistory.Rewind.WorkTerrainData>
	|
	|-RVA: 0x2BF0FA0 Offset: 0x2BF10A1 VA: 0x2BF0FA0
	|-Array.InternalArray__get_Item<MapHistory.RewindUnitMap.Data>
	|
	|-RVA: 0x2BF1070 Offset: 0x2BF1171 VA: 0x2BF1070
	|-Array.InternalArray__get_Item<MapKillBonus.Work.Pos>
	|
	|-RVA: 0x2BF1120 Offset: 0x2BF1221 VA: 0x2BF1120
	|-Array.InternalArray__get_Item<MapSkill.AroundCalculator.Result>
	|
	|-RVA: 0x2BF11D0 Offset: 0x2BF12D1 VA: 0x2BF11D0
	|-Array.InternalArray__get_Item<Nex.ApiCallChecker.Guideline>
	|
	|-RVA: 0x2BF1280 Offset: 0x2BF1381 VA: 0x2BF1280
	|-Array.InternalArray__get_Item<Ngc.MaskTextSequenceBase.Data>
	|
	|-RVA: 0x2BF1340 Offset: 0x2BF1441 VA: 0x2BF1340
	|-Array.InternalArray__get_Item<TargetPositionCache.CacheCurve.Item>
	|
	|-RVA: 0x2BF1410 Offset: 0x2BF1511 VA: 0x2BF1410
	|-Array.InternalArray__get_Item<TargetPositionCache.CacheEntry.RecordingItem>
	|
	|-RVA: 0x2BF14E0 Offset: 0x2BF15E1 VA: 0x2BF14E0
	|-Array.InternalArray__get_Item<TerrainUtility.TerrainMap.TileCoord>
	*/

	// RVA: -1 Offset: -1
	internal void InternalArray__set_Item<T>(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BF1590 Offset: 0x2BF1691 VA: 0x2BF1590
	|-Array.InternalArray__set_Item<ArraySegment<byte>>
	|
	|-RVA: 0x2BF1710 Offset: 0x2BF1811 VA: 0x2BF1710
	|-Array.InternalArray__set_Item<AsyncOperationHandle<object>>
	|
	|-RVA: 0x2BF18B0 Offset: 0x2BF19B1 VA: 0x2BF18B0
	|-Array.InternalArray__set_Item<MapDeployTemplate.Queue.Data<object>>
	|
	|-RVA: 0x2BF1A30 Offset: 0x2BF1B31 VA: 0x2BF1A30
	|-Array.InternalArray__set_Item<Nex.DataStore.ParamPool.Data<object>>
	|
	|-RVA: 0x2BF1BB0 Offset: 0x2BF1CB1 VA: 0x2BF1BB0
	|-Array.InternalArray__set_Item<Nex.Screening.ParamPool.Data<object>>
	|
	|-RVA: 0x2BF1D30 Offset: 0x2BF1E31 VA: 0x2BF1D30
	|-Array.InternalArray__set_Item<IntervalTree.Entry<object>>
	|
	|-RVA: 0x2BF1ED0 Offset: 0x2BF1FD1 VA: 0x2BF1ED0
	|-Array.InternalArray__set_Item<Dictionary.Entry<ValueTuple<object, int>, object>>
	|
	|-RVA: 0x2BF2070 Offset: 0x2BF2171 VA: 0x2BF2070
	|-Array.InternalArray__set_Item<Dictionary.Entry<byte, object>>
	|
	|-RVA: 0x2BF2210 Offset: 0x2BF2311 VA: 0x2BF2210
	|-Array.InternalArray__set_Item<Dictionary.Entry<CancellationToken, object>>
	|
	|-RVA: 0x2BF23B0 Offset: 0x2BF24B1 VA: 0x2BF23B0
	|-Array.InternalArray__set_Item<Dictionary.Entry<char, object>>
	|
	|-RVA: 0x2BF2550 Offset: 0x2BF2651 VA: 0x2BF2550
	|-Array.InternalArray__set_Item<Dictionary.Entry<Guid, object>>
	|
	|-RVA: 0x2BF26F0 Offset: 0x2BF27F1 VA: 0x2BF26F0
	|-Array.InternalArray__set_Item<Dictionary.Entry<int, bool>>
	|
	|-RVA: 0x2BF2870 Offset: 0x2BF2971 VA: 0x2BF2870
	|-Array.InternalArray__set_Item<Dictionary.Entry<int, byte>>
	|
	|-RVA: 0x2BF29F0 Offset: 0x2BF2AF1 VA: 0x2BF29F0
	|-Array.InternalArray__set_Item<Dictionary.Entry<int, char>>
	|
	|-RVA: 0x2BF2B70 Offset: 0x2BF2C71 VA: 0x2BF2B70
	|-Array.InternalArray__set_Item<Dictionary.Entry<int, DiagnosticEvent>>
	|
	|-RVA: 0x2BF2D20 Offset: 0x2BF2E21 VA: 0x2BF2D20
	|-Array.InternalArray__set_Item<Dictionary.Entry<int, int>>
	|
	|-RVA: 0x2BF2EA0 Offset: 0x2BF2FA1 VA: 0x2BF2EA0
	|-Array.InternalArray__set_Item<Dictionary.Entry<int, Int32Enum>>
	|
	|-RVA: 0x2BF3020 Offset: 0x2BF3121 VA: 0x2BF3020
	|-Array.InternalArray__set_Item<Dictionary.Entry<int, long>>
	|
	|-RVA: 0x2BF31C0 Offset: 0x2BF32C1 VA: 0x2BF31C0
	|-Array.InternalArray__set_Item<Dictionary.Entry<int, MapPos>>
	|
	|-RVA: 0x2BF3360 Offset: 0x2BF3461 VA: 0x2BF3360
	|-Array.InternalArray__set_Item<Dictionary.Entry<int, object>>
	|
	|-RVA: 0x2BF3500 Offset: 0x2BF3601 VA: 0x2BF3500
	|-Array.InternalArray__set_Item<Dictionary.Entry<int, uint>>
	|
	|-RVA: 0x2BF3680 Offset: 0x2BF3781 VA: 0x2BF3680
	|-Array.InternalArray__set_Item<Dictionary.Entry<int, AIThink.EnchantThink.SurroundingInfo>>
	|
	|-RVA: 0x2BF3800 Offset: 0x2BF3901 VA: 0x2BF3800
	|-Array.InternalArray__set_Item<Dictionary.Entry<Int32Enum, bool>>
	|
	|-RVA: 0x2BF3980 Offset: 0x2BF3A81 VA: 0x2BF3980
	|-Array.InternalArray__set_Item<Dictionary.Entry<Int32Enum, int>>
	|
	|-RVA: 0x2BF3B00 Offset: 0x2BF3C01 VA: 0x2BF3B00
	|-Array.InternalArray__set_Item<Dictionary.Entry<Int32Enum, Int32Enum>>
	|
	|-RVA: 0x2BF3C80 Offset: 0x2BF3D81 VA: 0x2BF3C80
	|-Array.InternalArray__set_Item<Dictionary.Entry<Int32Enum, object>>
	|
	|-RVA: 0x2BF3E20 Offset: 0x2BF3F21 VA: 0x2BF3E20
	|-Array.InternalArray__set_Item<Dictionary.Entry<long, object>>
	|
	|-RVA: 0x2BF3FC0 Offset: 0x2BF40C1 VA: 0x2BF3FC0
	|-Array.InternalArray__set_Item<Dictionary.Entry<MapPos, int>>
	|
	|-RVA: 0x2BF4160 Offset: 0x2BF4261 VA: 0x2BF4160
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, AsyncOperationHandle<object>>>
	|
	|-RVA: 0x2BF4310 Offset: 0x2BF4411 VA: 0x2BF4310
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, AsyncOperationHandle>>
	|
	|-RVA: 0x2BF44C0 Offset: 0x2BF45C1 VA: 0x2BF44C0
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, bool>>
	|
	|-RVA: 0x2BF4660 Offset: 0x2BF4761 VA: 0x2BF4660
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, byte>>
	|
	|-RVA: 0x2BF4800 Offset: 0x2BF4901 VA: 0x2BF4800
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, int>>
	|
	|-RVA: 0x2BF49A0 Offset: 0x2BF4AA1 VA: 0x2BF49A0
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, Int32Enum>>
	|
	|-RVA: 0x2BF4B40 Offset: 0x2BF4C41 VA: 0x2BF4B40
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, IntPtr>>
	|
	|-RVA: 0x2BF4CE0 Offset: 0x2BF4DE1 VA: 0x2BF4CE0
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, object>>
	|
	|-RVA: 0x2BF4E80 Offset: 0x2BF4F81 VA: 0x2BF4E80
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, Playable>>
	|
	|-RVA: 0x2BF5020 Offset: 0x2BF5121 VA: 0x2BF5020
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, ResourceLocator>>
	|
	|-RVA: 0x2BF51C0 Offset: 0x2BF52C1 VA: 0x2BF51C0
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, float>>
	|
	|-RVA: 0x2BF5360 Offset: 0x2BF5461 VA: 0x2BF5360
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, ushort>>
	|
	|-RVA: 0x2BF5500 Offset: 0x2BF5601 VA: 0x2BF5500
	|-Array.InternalArray__set_Item<Dictionary.Entry<object, GameVariable.Value>>
	|
	|-RVA: 0x2BF56A0 Offset: 0x2BF57A1 VA: 0x2BF56A0
	|-Array.InternalArray__set_Item<Dictionary.Entry<sbyte, DataStoreRatingInfo>>
	|
	|-RVA: 0x2BF5850 Offset: 0x2BF5951 VA: 0x2BF5850
	|-Array.InternalArray__set_Item<Dictionary.Entry<sbyte, object>>
	|
	|-RVA: 0x2BF59F0 Offset: 0x2BF5AF1 VA: 0x2BF59F0
	|-Array.InternalArray__set_Item<Dictionary.Entry<ushort, int>>
	|
	|-RVA: 0x2BF5B70 Offset: 0x2BF5C71 VA: 0x2BF5B70
	|-Array.InternalArray__set_Item<Dictionary.Entry<uint, int>>
	|
	|-RVA: 0x2BF5CF0 Offset: 0x2BF5DF1 VA: 0x2BF5CF0
	|-Array.InternalArray__set_Item<Dictionary.Entry<uint, object>>
	|
	|-RVA: 0x2BF5E90 Offset: 0x2BF5F91 VA: 0x2BF5E90
	|-Array.InternalArray__set_Item<Dictionary.Entry<ulong, Friend>>
	|
	|-RVA: 0x2BF6030 Offset: 0x2BF6131 VA: 0x2BF6030
	|-Array.InternalArray__set_Item<Dictionary.Entry<ulong, Int32Enum>>
	|
	|-RVA: 0x2BF61D0 Offset: 0x2BF62D1 VA: 0x2BF61D0
	|-Array.InternalArray__set_Item<Dictionary.Entry<ulong, object>>
	|
	|-RVA: 0x2BF6370 Offset: 0x2BF6471 VA: 0x2BF6370
	|-Array.InternalArray__set_Item<Dictionary.Entry<Vector3, int>>
	|
	|-RVA: 0x2BF6510 Offset: 0x2BF6611 VA: 0x2BF6510
	|-Array.InternalArray__set_Item<Dictionary.Entry<XPathNodeRef, XPathNodeRef>>
	|
	|-RVA: 0x2BF66C0 Offset: 0x2BF67C1 VA: 0x2BF66C0
	|-Array.InternalArray__set_Item<Dictionary.Entry<TerrainUtility.TerrainMap.TileCoord, object>>
	|
	|-RVA: 0x2BF6860 Offset: 0x2BF6961 VA: 0x2BF6860
	|-Array.InternalArray__set_Item<PriorityQueue.IndexedItem<object>>
	|
	|-RVA: 0x2BF69E0 Offset: 0x2BF6AE1 VA: 0x2BF69E0
	|-Array.InternalArray__set_Item<KeyValuePair<ValueTuple<object, int>, object>>
	|
	|-RVA: 0x2BF6B80 Offset: 0x2BF6C81 VA: 0x2BF6B80
	|-Array.InternalArray__set_Item<KeyValuePair<byte, object>>
	|
	|-RVA: 0x2BF6D00 Offset: 0x2BF6E01 VA: 0x2BF6D00
	|-Array.InternalArray__set_Item<KeyValuePair<CancellationToken, object>>
	|
	|-RVA: 0x2BF6E80 Offset: 0x2BF6F81 VA: 0x2BF6E80
	|-Array.InternalArray__set_Item<KeyValuePair<char, object>>
	|
	|-RVA: 0x2BF7000 Offset: 0x2BF7101 VA: 0x2BF7000
	|-Array.InternalArray__set_Item<KeyValuePair<DateTime, object>>
	|
	|-RVA: 0x2BF7180 Offset: 0x2BF7281 VA: 0x2BF7180
	|-Array.InternalArray__set_Item<KeyValuePair<Guid, object>>
	|
	|-RVA: 0x2BF7320 Offset: 0x2BF7421 VA: 0x2BF7320
	|-Array.InternalArray__set_Item<KeyValuePair<int, bool>>
	|
	|-RVA: 0x2BF74A0 Offset: 0x2BF75A1 VA: 0x2BF74A0
	|-Array.InternalArray__set_Item<KeyValuePair<int, byte>>
	|
	|-RVA: 0x2BF7620 Offset: 0x2BF7721 VA: 0x2BF7620
	|-Array.InternalArray__set_Item<KeyValuePair<int, char>>
	|
	|-RVA: 0x2BF77A0 Offset: 0x2BF78A1 VA: 0x2BF77A0
	|-Array.InternalArray__set_Item<KeyValuePair<int, DiagnosticEvent>>
	|
	|-RVA: 0x2BF7950 Offset: 0x2BF7A51 VA: 0x2BF7950
	|-Array.InternalArray__set_Item<KeyValuePair<int, int>>
	|
	|-RVA: 0x2BF7AD0 Offset: 0x2BF7BD1 VA: 0x2BF7AD0
	|-Array.InternalArray__set_Item<KeyValuePair<int, Int32Enum>>
	|
	|-RVA: 0x2BF7C50 Offset: 0x2BF7D51 VA: 0x2BF7C50
	|-Array.InternalArray__set_Item<KeyValuePair<int, long>>
	|
	|-RVA: 0x2BF7DD0 Offset: 0x2BF7ED1 VA: 0x2BF7DD0
	|-Array.InternalArray__set_Item<KeyValuePair<int, MapPos>>
	|
	|-RVA: 0x2BF7F60 Offset: 0x2BF8061 VA: 0x2BF7F60
	|-Array.InternalArray__set_Item<KeyValuePair<int, object>>
	|
	|-RVA: 0x2BF80E0 Offset: 0x2BF81E1 VA: 0x2BF80E0
	|-Array.InternalArray__set_Item<KeyValuePair<int, uint>>
	|
	|-RVA: 0x2BF8260 Offset: 0x2BF8361 VA: 0x2BF8260
	|-Array.InternalArray__set_Item<KeyValuePair<int, AIThink.EnchantThink.SurroundingInfo>>
	|
	|-RVA: 0x2BF83E0 Offset: 0x2BF84E1 VA: 0x2BF83E0
	|-Array.InternalArray__set_Item<KeyValuePair<Int32Enum, bool>>
	|
	|-RVA: 0x2BF8560 Offset: 0x2BF8661 VA: 0x2BF8560
	|-Array.InternalArray__set_Item<KeyValuePair<Int32Enum, int>>
	|
	|-RVA: 0x2BF86E0 Offset: 0x2BF87E1 VA: 0x2BF86E0
	|-Array.InternalArray__set_Item<KeyValuePair<Int32Enum, Int32Enum>>
	|
	|-RVA: 0x2BF8860 Offset: 0x2BF8961 VA: 0x2BF8860
	|-Array.InternalArray__set_Item<KeyValuePair<Int32Enum, object>>
	|
	|-RVA: 0x2BF89E0 Offset: 0x2BF8AE1 VA: 0x2BF89E0
	|-Array.InternalArray__set_Item<KeyValuePair<long, object>>
	|
	|-RVA: 0x2BF8B60 Offset: 0x2BF8C61 VA: 0x2BF8B60
	|-Array.InternalArray__set_Item<KeyValuePair<MapPos, int>>
	|
	|-RVA: 0x2BF8CF0 Offset: 0x2BF8DF1 VA: 0x2BF8CF0
	|-Array.InternalArray__set_Item<KeyValuePair<object, AsyncOperationHandle<object>>>
	|
	|-RVA: 0x2BF8E90 Offset: 0x2BF8F91 VA: 0x2BF8E90
	|-Array.InternalArray__set_Item<KeyValuePair<object, ValueTuple<int, DateTime, object>>>
	|
	|-RVA: 0x2BF9030 Offset: 0x2BF9131 VA: 0x2BF9030
	|-Array.InternalArray__set_Item<KeyValuePair<object, AsyncOperationHandle>>
	|
	|-RVA: 0x2BF91D0 Offset: 0x2BF92D1 VA: 0x2BF91D0
	|-Array.InternalArray__set_Item<KeyValuePair<object, bool>>
	|
	|-RVA: 0x2BF9350 Offset: 0x2BF9451 VA: 0x2BF9350
	|-Array.InternalArray__set_Item<KeyValuePair<object, byte>>
	|
	|-RVA: 0x2BF94D0 Offset: 0x2BF95D1 VA: 0x2BF94D0
	|-Array.InternalArray__set_Item<KeyValuePair<object, int>>
	|
	|-RVA: 0x2BF9650 Offset: 0x2BF9751 VA: 0x2BF9650
	|-Array.InternalArray__set_Item<KeyValuePair<object, Int32Enum>>
	|
	|-RVA: 0x2BF97D0 Offset: 0x2BF98D1 VA: 0x2BF97D0
	|-Array.InternalArray__set_Item<KeyValuePair<object, IntPtr>>
	|
	|-RVA: 0x2BF9950 Offset: 0x2BF9A51 VA: 0x2BF9950
	|-Array.InternalArray__set_Item<KeyValuePair<object, object>>
	|
	|-RVA: 0x2BF9AD0 Offset: 0x2BF9BD1 VA: 0x2BF9AD0
	|-Array.InternalArray__set_Item<KeyValuePair<object, Playable>>
	|
	|-RVA: 0x2BF9C70 Offset: 0x2BF9D71 VA: 0x2BF9C70
	|-Array.InternalArray__set_Item<KeyValuePair<object, ResourceLocator>>
	|
	|-RVA: 0x2BF9E10 Offset: 0x2BF9F11 VA: 0x2BF9E10
	|-Array.InternalArray__set_Item<KeyValuePair<object, float>>
	|
	|-RVA: 0x2BF9F90 Offset: 0x2BFA091 VA: 0x2BF9F90
	|-Array.InternalArray__set_Item<KeyValuePair<object, ushort>>
	|
	|-RVA: 0x2BFA110 Offset: 0x2BFA211 VA: 0x2BFA110
	|-Array.InternalArray__set_Item<KeyValuePair<object, GameVariable.Value>>
	|
	|-RVA: 0x2BFA2B0 Offset: 0x2BFA3B1 VA: 0x2BFA2B0
	|-Array.InternalArray__set_Item<KeyValuePair<sbyte, DataStoreRatingInfo>>
	|
	|-RVA: 0x2BFA450 Offset: 0x2BFA551 VA: 0x2BFA450
	|-Array.InternalArray__set_Item<KeyValuePair<sbyte, object>>
	|
	|-RVA: 0x2BFA5D0 Offset: 0x2BFA6D1 VA: 0x2BFA5D0
	|-Array.InternalArray__set_Item<KeyValuePair<ushort, int>>
	|
	|-RVA: 0x2BFA750 Offset: 0x2BFA851 VA: 0x2BFA750
	|-Array.InternalArray__set_Item<KeyValuePair<uint, int>>
	|
	|-RVA: 0x2BFA8D0 Offset: 0x2BFA9D1 VA: 0x2BFA8D0
	|-Array.InternalArray__set_Item<KeyValuePair<uint, object>>
	|
	|-RVA: 0x2BFAA50 Offset: 0x2BFAB51 VA: 0x2BFAA50
	|-Array.InternalArray__set_Item<KeyValuePair<ulong, Friend>>
	|
	|-RVA: 0x2BFABF0 Offset: 0x2BFACF1 VA: 0x2BFABF0
	|-Array.InternalArray__set_Item<KeyValuePair<ulong, Int32Enum>>
	|
	|-RVA: 0x2BFAD70 Offset: 0x2BFAE71 VA: 0x2BFAD70
	|-Array.InternalArray__set_Item<KeyValuePair<ulong, object>>
	|
	|-RVA: 0x2BFAEF0 Offset: 0x2BFAFF1 VA: 0x2BFAEF0
	|-Array.InternalArray__set_Item<KeyValuePair<Vector3, int>>
	|
	|-RVA: 0x2BFB070 Offset: 0x2BFB171 VA: 0x2BFB070
	|-Array.InternalArray__set_Item<KeyValuePair<XPathNodeRef, XPathNodeRef>>
	|
	|-RVA: 0x2BFB210 Offset: 0x2BFB311 VA: 0x2BFB210
	|-Array.InternalArray__set_Item<KeyValuePair<TerrainUtility.TerrainMap.TileCoord, object>>
	|
	|-RVA: 0x2BFB390 Offset: 0x2BFB491 VA: 0x2BFB390
	|-Array.InternalArray__set_Item<NativeArray<PreTile>>
	|
	|-RVA: 0x2BFB510 Offset: 0x2BFB611 VA: 0x2BFB510
	|-Array.InternalArray__set_Item<CommonBattleSequence.Reliance<object>>
	|
	|-RVA: 0x2BFB6B0 Offset: 0x2BFB7B1 VA: 0x2BFB6B0
	|-Array.InternalArray__set_Item<RenderGraphResourcePool.ResourceLogInfo<object>>
	|
	|-RVA: 0x2BFB830 Offset: 0x2BFB931 VA: 0x2BFB830
	|-Array.InternalArray__set_Item<HashSet.Slot<ValueTuple<object, int>>>
	|
	|-RVA: 0x2BFB9D0 Offset: 0x2BFBAD1 VA: 0x2BFB9D0
	|-Array.InternalArray__set_Item<HashSet.Slot<AsyncOperationHandle>>
	|
	|-RVA: 0x2BFBB70 Offset: 0x2BFBC71 VA: 0x2BFBB70
	|-Array.InternalArray__set_Item<HashSet.Slot<int>>
	|
	|-RVA: 0x2BFBD00 Offset: 0x2BFBE01 VA: 0x2BFBD00
	|-Array.InternalArray__set_Item<HashSet.Slot<Int32Enum>>
	|
	|-RVA: 0x2BFBE90 Offset: 0x2BFBF91 VA: 0x2BFBE90
	|-Array.InternalArray__set_Item<Set.Slot<Int32Enum>>
	|
	|-RVA: 0x2BFC020 Offset: 0x2BFC121 VA: 0x2BFC020
	|-Array.InternalArray__set_Item<HashSet.Slot<MapPos>>
	|
	|-RVA: 0x2BFC1A0 Offset: 0x2BFC2A1 VA: 0x2BFC1A0
	|-Array.InternalArray__set_Item<HashSet.Slot<object>>
	|
	|-RVA: 0x2BFC320 Offset: 0x2BFC421 VA: 0x2BFC320
	|-Array.InternalArray__set_Item<Set.Slot<object>>
	|
	|-RVA: 0x2BFC4C0 Offset: 0x2BFC5C1 VA: 0x2BFC4C0
	|-Array.InternalArray__set_Item<HashSet.Slot<uint>>
	|
	|-RVA: 0x2BFC650 Offset: 0x2BFC751 VA: 0x2BFC650
	|-Array.InternalArray__set_Item<HashSet.Slot<ulong>>
	|
	|-RVA: 0x2BFC7D0 Offset: 0x2BFC8D1 VA: 0x2BFC7D0
	|-Array.InternalArray__set_Item<Set.Slot<Vector3>>
	|
	|-RVA: 0x2BFC970 Offset: 0x2BFCA71 VA: 0x2BFC970
	|-Array.InternalArray__set_Item<TMP_TextProcessingStack<Color32>>
	|
	|-RVA: 0x2BFCB10 Offset: 0x2BFCC11 VA: 0x2BFCB10
	|-Array.InternalArray__set_Item<TMP_TextProcessingStack<HighlightState>>
	|
	|-RVA: 0x2BFCCC0 Offset: 0x2BFCDC1 VA: 0x2BFCCC0
	|-Array.InternalArray__set_Item<TMP_TextProcessingStack<int>>
	|
	|-RVA: 0x2BFCE60 Offset: 0x2BFCF61 VA: 0x2BFCE60
	|-Array.InternalArray__set_Item<TMP_TextProcessingStack<Int32Enum>>
	|
	|-RVA: 0x2BFD000 Offset: 0x2BFD101 VA: 0x2BFD000
	|-Array.InternalArray__set_Item<TMP_TextProcessingStack<MaterialReference>>
	|
	|-RVA: 0x2BFD1C0 Offset: 0x2BFD2C1 VA: 0x2BFD1C0
	|-Array.InternalArray__set_Item<TMP_TextProcessingStack<object>>
	|
	|-RVA: 0x2BFD370 Offset: 0x2BFD471 VA: 0x2BFD370
	|-Array.InternalArray__set_Item<TMP_TextProcessingStack<float>>
	|
	|-RVA: 0x2BFD510 Offset: 0x2BFD611 VA: 0x2BFD510
	|-Array.InternalArray__set_Item<TMP_TextProcessingStack<WordWrapState>>
	|
	|-RVA: 0x2BFD6B0 Offset: 0x2BFD7B1 VA: 0x2BFD6B0
	|-Array.InternalArray__set_Item<TimeInterval<object>>
	|
	|-RVA: 0x2BFD830 Offset: 0x2BFD931 VA: 0x2BFD830
	|-Array.InternalArray__set_Item<Timestamped<object>>
	|
	|-RVA: 0x2BFD9D0 Offset: 0x2BFDAD1 VA: 0x2BFD9D0
	|-Array.InternalArray__set_Item<UniTask<object>>
	|
	|-RVA: 0x2BFDB50 Offset: 0x2BFDC51 VA: 0x2BFDB50
	|-Array.InternalArray__set_Item<ValueTuple<ValueTuple<bool, object>>>
	|
	|-RVA: 0x2BFDCD0 Offset: 0x2BFDDD1 VA: 0x2BFDCD0
	|-Array.InternalArray__set_Item<ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>
	|
	|-RVA: 0x2BFDE70 Offset: 0x2BFDF71 VA: 0x2BFDE70
	|-Array.InternalArray__set_Item<ValueTuple<bool, UniTask<object>>>
	|
	|-RVA: 0x2BFE010 Offset: 0x2BFE111 VA: 0x2BFE010
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>
	|
	|-RVA: 0x2BFE1B0 Offset: 0x2BFE2B1 VA: 0x2BFE1B0
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>
	|
	|-RVA: 0x2BFE360 Offset: 0x2BFE461 VA: 0x2BFE360
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask<object>>>>>>
	|
	|-RVA: 0x2BFE510 Offset: 0x2BFE611 VA: 0x2BFE510
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>>
	|
	|-RVA: 0x2BFE6A0 Offset: 0x2BFE7A1 VA: 0x2BFE6A0
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>>
	|
	|-RVA: 0x2BFE830 Offset: 0x2BFE931 VA: 0x2BFE830
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>>
	|
	|-RVA: 0x2BFE9E0 Offset: 0x2BFEAE1 VA: 0x2BFE9E0
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>>
	|
	|-RVA: 0x2BFEB70 Offset: 0x2BFEC71 VA: 0x2BFEB70
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>>
	|
	|-RVA: 0x2BFED20 Offset: 0x2BFEE21 VA: 0x2BFED20
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>>
	|
	|-RVA: 0x2BFEED0 Offset: 0x2BFEFD1 VA: 0x2BFEED0
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>>
	|
	|-RVA: 0x2BFF070 Offset: 0x2BFF171 VA: 0x2BFF070
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>>
	|
	|-RVA: 0x2BFF220 Offset: 0x2BFF321 VA: 0x2BFF220
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x2BFF3D0 Offset: 0x2BFF4D1 VA: 0x2BFF3D0
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>>
	|
	|-RVA: 0x2BFF580 Offset: 0x2BFF681 VA: 0x2BFF580
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>>
	|
	|-RVA: 0x2BFF730 Offset: 0x2BFF831 VA: 0x2BFF730
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>>
	|
	|-RVA: 0x2BFF8D0 Offset: 0x2BFF9D1 VA: 0x2BFF8D0
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>>
	|
	|-RVA: 0x2BFFA80 Offset: 0x2BFFB81 VA: 0x2BFFA80
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>>
	|
	|-RVA: 0x2BFFC10 Offset: 0x2BFFD11 VA: 0x2BFFC10
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>>
	|
	|-RVA: 0x2BFFDC0 Offset: 0x2BFFEC1 VA: 0x2BFFDC0
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>>
	|
	|-RVA: 0x2BFFF60 Offset: 0x2C00061 VA: 0x2BFFF60
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>>
	|
	|-RVA: 0x2C00110 Offset: 0x2C00211 VA: 0x2C00110
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>>
	|
	|-RVA: 0x2C002C0 Offset: 0x2C003C1 VA: 0x2C002C0
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>>
	|
	|-RVA: 0x2C00470 Offset: 0x2C00571 VA: 0x2C00470
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>>
	|
	|-RVA: 0x2C00620 Offset: 0x2C00721 VA: 0x2C00620
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>>
	|
	|-RVA: 0x2C007D0 Offset: 0x2C008D1 VA: 0x2C007D0
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>>
	|
	|-RVA: 0x2C00990 Offset: 0x2C00A91 VA: 0x2C00990
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>>
	|
	|-RVA: 0x2C00B50 Offset: 0x2C00C51 VA: 0x2C00B50
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>>
	|
	|-RVA: 0x2C00D10 Offset: 0x2C00E11 VA: 0x2C00D10
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>>
	|
	|-RVA: 0x2C00EA0 Offset: 0x2C00FA1 VA: 0x2C00EA0
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>>
	|
	|-RVA: 0x2C01030 Offset: 0x2C01131 VA: 0x2C01030
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>>
	|
	|-RVA: 0x2C011E0 Offset: 0x2C012E1 VA: 0x2C011E0
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>>
	|
	|-RVA: 0x2C01370 Offset: 0x2C01471 VA: 0x2C01370
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>>
	|
	|-RVA: 0x2C01510 Offset: 0x2C01611 VA: 0x2C01510
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>>
	|
	|-RVA: 0x2C016C0 Offset: 0x2C017C1 VA: 0x2C016C0
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>>
	|
	|-RVA: 0x2C01860 Offset: 0x2C01961 VA: 0x2C01860
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>>
	|
	|-RVA: 0x2C01A10 Offset: 0x2C01B11 VA: 0x2C01A10
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x2C01BC0 Offset: 0x2C01CC1 VA: 0x2C01BC0
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>>
	|
	|-RVA: 0x2C01D60 Offset: 0x2C01E61 VA: 0x2C01D60
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>>
	|
	|-RVA: 0x2C01F00 Offset: 0x2C02001 VA: 0x2C01F00
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>>
	|
	|-RVA: 0x2C020A0 Offset: 0x2C021A1 VA: 0x2C020A0
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>>
	|
	|-RVA: 0x2C02250 Offset: 0x2C02351 VA: 0x2C02250
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>>
	|
	|-RVA: 0x2C023E0 Offset: 0x2C024E1 VA: 0x2C023E0
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>>
	|
	|-RVA: 0x2C02580 Offset: 0x2C02681 VA: 0x2C02580
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>>
	|
	|-RVA: 0x2C02730 Offset: 0x2C02831 VA: 0x2C02730
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>>
	|
	|-RVA: 0x2C028D0 Offset: 0x2C029D1 VA: 0x2C028D0
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>>
	|
	|-RVA: 0x2C02A80 Offset: 0x2C02B81 VA: 0x2C02A80
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>>
	|
	|-RVA: 0x2C02C30 Offset: 0x2C02D31 VA: 0x2C02C30
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x2C02DE0 Offset: 0x2C02EE1 VA: 0x2C02DE0
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>>
	|
	|-RVA: 0x2C02F90 Offset: 0x2C03091 VA: 0x2C02F90
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x2C03150 Offset: 0x2C03251 VA: 0x2C03150
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>>
	|
	|-RVA: 0x2C03300 Offset: 0x2C03401 VA: 0x2C03300
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x2C034C0 Offset: 0x2C035C1 VA: 0x2C034C0
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>>
	|
	|-RVA: 0x2C03670 Offset: 0x2C03771 VA: 0x2C03670
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x2C03840 Offset: 0x2C03941 VA: 0x2C03840
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>>
	|
	|-RVA: 0x2C03A00 Offset: 0x2C03B01 VA: 0x2C03A00
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x2C03BD0 Offset: 0x2C03CD1 VA: 0x2C03BD0
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>>
	|
	|-RVA: 0x2C03D90 Offset: 0x2C03E91 VA: 0x2C03D90
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>>
	|
	|-RVA: 0x2C03F10 Offset: 0x2C04011 VA: 0x2C03F10
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, bool>>>>
	|
	|-RVA: 0x2C04090 Offset: 0x2C04191 VA: 0x2C04090
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Bounds>>>>
	|
	|-RVA: 0x2C04240 Offset: 0x2C04341 VA: 0x2C04240
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, byte>>>>
	|
	|-RVA: 0x2C043C0 Offset: 0x2C044C1 VA: 0x2C043C0
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Color>>>>
	|
	|-RVA: 0x2C04570 Offset: 0x2C04671 VA: 0x2C04570
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, double>>>>
	|
	|-RVA: 0x2C04710 Offset: 0x2C04811 VA: 0x2C04710
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, int>>>>
	|
	|-RVA: 0x2C04890 Offset: 0x2C04991 VA: 0x2C04890
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, long>>>>
	|
	|-RVA: 0x2C04A30 Offset: 0x2C04B31 VA: 0x2C04A30
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x2C04BD0 Offset: 0x2C04CD1 VA: 0x2C04BD0
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Quaternion>>>>
	|
	|-RVA: 0x2C04D80 Offset: 0x2C04E81 VA: 0x2C04D80
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Rect>>>>
	|
	|-RVA: 0x2C04F30 Offset: 0x2C05031 VA: 0x2C04F30
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, float>>>>
	|
	|-RVA: 0x2C050B0 Offset: 0x2C051B1 VA: 0x2C050B0
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, UniTask>>>>
	|
	|-RVA: 0x2C05250 Offset: 0x2C05351 VA: 0x2C05250
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Unit>>>>
	|
	|-RVA: 0x2C053D0 Offset: 0x2C054D1 VA: 0x2C053D0
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector2>>>>
	|
	|-RVA: 0x2C05570 Offset: 0x2C05671 VA: 0x2C05570
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector3>>>>
	|
	|-RVA: 0x2C05710 Offset: 0x2C05811 VA: 0x2C05710
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<bool, Vector4>>>>
	|
	|-RVA: 0x2C058C0 Offset: 0x2C059C1 VA: 0x2C058C0
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, object>>>>
	|
	|-RVA: 0x2C05A60 Offset: 0x2C05B61 VA: 0x2C05A60
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object>>>>
	|
	|-RVA: 0x2C05C00 Offset: 0x2C05D01 VA: 0x2C05C00
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x2C05DB0 Offset: 0x2C05EB1 VA: 0x2C05DB0
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object>>>>
	|
	|-RVA: 0x2C05F60 Offset: 0x2C06061 VA: 0x2C05F60
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x2C06120 Offset: 0x2C06221 VA: 0x2C06120
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object>>>>
	|
	|-RVA: 0x2C062D0 Offset: 0x2C063D1 VA: 0x2C062D0
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x2C06490 Offset: 0x2C06591 VA: 0x2C06490
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object>>>>
	|
	|-RVA: 0x2C06640 Offset: 0x2C06741 VA: 0x2C06640
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x2C06810 Offset: 0x2C06911 VA: 0x2C06810
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>>
	|
	|-RVA: 0x2C069C0 Offset: 0x2C06AC1 VA: 0x2C069C0
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x2C06B90 Offset: 0x2C06C91 VA: 0x2C06B90
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>>
	|
	|-RVA: 0x2C06D50 Offset: 0x2C06E51 VA: 0x2C06D50
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x2C06EF0 Offset: 0x2C06FF1 VA: 0x2C06EF0
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>>
	|
	|-RVA: 0x2C07090 Offset: 0x2C07191 VA: 0x2C07090
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, AsyncUnit>>>
	|
	|-RVA: 0x2C07220 Offset: 0x2C07321 VA: 0x2C07220
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, bool>>>
	|
	|-RVA: 0x2C073B0 Offset: 0x2C074B1 VA: 0x2C073B0
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, Bounds>>>
	|
	|-RVA: 0x2C07550 Offset: 0x2C07651 VA: 0x2C07550
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, byte>>>
	|
	|-RVA: 0x2C076E0 Offset: 0x2C077E1 VA: 0x2C076E0
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, Color>>>
	|
	|-RVA: 0x2C07880 Offset: 0x2C07981 VA: 0x2C07880
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, double>>>
	|
	|-RVA: 0x2C07A20 Offset: 0x2C07B21 VA: 0x2C07A20
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, int>>>
	|
	|-RVA: 0x2C07BB0 Offset: 0x2C07CB1 VA: 0x2C07BB0
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, long>>>
	|
	|-RVA: 0x2C07D50 Offset: 0x2C07E51 VA: 0x2C07D50
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, object>>>
	|
	|-RVA: 0x2C07EF0 Offset: 0x2C07FF1 VA: 0x2C07EF0
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, Quaternion>>>
	|
	|-RVA: 0x2C08090 Offset: 0x2C08191 VA: 0x2C08090
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, Rect>>>
	|
	|-RVA: 0x2C08230 Offset: 0x2C08331 VA: 0x2C08230
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, float>>>
	|
	|-RVA: 0x2C083C0 Offset: 0x2C084C1 VA: 0x2C083C0
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, UniTask>>>
	|
	|-RVA: 0x2C08560 Offset: 0x2C08661 VA: 0x2C08560
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, Unit>>>
	|
	|-RVA: 0x2C086F0 Offset: 0x2C087F1 VA: 0x2C086F0
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, Vector2>>>
	|
	|-RVA: 0x2C08870 Offset: 0x2C08971 VA: 0x2C08870
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, Vector3>>>
	|
	|-RVA: 0x2C08A10 Offset: 0x2C08B11 VA: 0x2C08A10
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<bool, Vector4>>>
	|
	|-RVA: 0x2C08BB0 Offset: 0x2C08CB1 VA: 0x2C08BB0
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<int, object>>>
	|
	|-RVA: 0x2C08D50 Offset: 0x2C08E51 VA: 0x2C08D50
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<object, object>>>
	|
	|-RVA: 0x2C08EF0 Offset: 0x2C08FF1 VA: 0x2C08EF0
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x2C090A0 Offset: 0x2C091A1 VA: 0x2C090A0
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<object, object, object>>>
	|
	|-RVA: 0x2C09240 Offset: 0x2C09341 VA: 0x2C09240
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x2C093F0 Offset: 0x2C094F1 VA: 0x2C093F0
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<object, object, object, object>>>
	|
	|-RVA: 0x2C095A0 Offset: 0x2C096A1 VA: 0x2C095A0
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x2C09760 Offset: 0x2C09861 VA: 0x2C09760
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<object, object, object, object, object>>>
	|
	|-RVA: 0x2C09910 Offset: 0x2C09A11 VA: 0x2C09910
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x2C09AD0 Offset: 0x2C09BD1 VA: 0x2C09AD0
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<object, object, object, object, object, object>>>
	|
	|-RVA: 0x2C09C80 Offset: 0x2C09D81 VA: 0x2C09C80
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x2C09E50 Offset: 0x2C09F51 VA: 0x2C09E50
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<object, object, object, object, object, object, object>>>
	|
	|-RVA: 0x2C0A000 Offset: 0x2C0A101 VA: 0x2C0A000
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x2C0A1D0 Offset: 0x2C0A2D1 VA: 0x2C0A1D0
	|-Array.InternalArray__set_Item<ValueTuple<bool, ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>>
	|
	|-RVA: 0x2C0A370 Offset: 0x2C0A471 VA: 0x2C0A370
	|-Array.InternalArray__set_Item<ValueTuple<bool, AsyncUnit>>
	|
	|-RVA: 0x2C0A4F0 Offset: 0x2C0A5F1 VA: 0x2C0A4F0
	|-Array.InternalArray__set_Item<ValueTuple<bool, bool>>
	|
	|-RVA: 0x2C0A670 Offset: 0x2C0A771 VA: 0x2C0A670
	|-Array.InternalArray__set_Item<ValueTuple<bool, Bounds>>
	|
	|-RVA: 0x2C0A820 Offset: 0x2C0A921 VA: 0x2C0A820
	|-Array.InternalArray__set_Item<ValueTuple<bool, byte>>
	|
	|-RVA: 0x2C0A9A0 Offset: 0x2C0AAA1 VA: 0x2C0A9A0
	|-Array.InternalArray__set_Item<ValueTuple<bool, Color>>
	|
	|-RVA: 0x2C0AB40 Offset: 0x2C0AC41 VA: 0x2C0AB40
	|-Array.InternalArray__set_Item<ValueTuple<bool, double>>
	|
	|-RVA: 0x2C0ACC0 Offset: 0x2C0ADC1 VA: 0x2C0ACC0
	|-Array.InternalArray__set_Item<ValueTuple<bool, int>>
	|
	|-RVA: 0x2C0AE40 Offset: 0x2C0AF41 VA: 0x2C0AE40
	|-Array.InternalArray__set_Item<ValueTuple<bool, long>>
	|
	|-RVA: 0x2C0AFC0 Offset: 0x2C0B0C1 VA: 0x2C0AFC0
	|-Array.InternalArray__set_Item<ValueTuple<bool, object>>
	|
	|-RVA: 0x2C0B140 Offset: 0x2C0B241 VA: 0x2C0B140
	|-Array.InternalArray__set_Item<ValueTuple<bool, Quaternion>>
	|
	|-RVA: 0x2C0B2E0 Offset: 0x2C0B3E1 VA: 0x2C0B2E0
	|-Array.InternalArray__set_Item<ValueTuple<bool, Rect>>
	|
	|-RVA: 0x2C0B480 Offset: 0x2C0B581 VA: 0x2C0B480
	|-Array.InternalArray__set_Item<ValueTuple<bool, float>>
	|
	|-RVA: 0x2C0B600 Offset: 0x2C0B701 VA: 0x2C0B600
	|-Array.InternalArray__set_Item<ValueTuple<bool, UniTask>>
	|
	|-RVA: 0x2C0B780 Offset: 0x2C0B881 VA: 0x2C0B780
	|-Array.InternalArray__set_Item<ValueTuple<bool, Unit>>
	|
	|-RVA: 0x2C0B900 Offset: 0x2C0BA01 VA: 0x2C0B900
	|-Array.InternalArray__set_Item<ValueTuple<bool, Vector2>>
	|
	|-RVA: 0x2C0BA90 Offset: 0x2C0BB91 VA: 0x2C0BA90
	|-Array.InternalArray__set_Item<ValueTuple<bool, Vector3>>
	|
	|-RVA: 0x2C0BC10 Offset: 0x2C0BD11 VA: 0x2C0BC10
	|-Array.InternalArray__set_Item<ValueTuple<bool, Vector4>>
	|
	|-RVA: 0x2C0BDB0 Offset: 0x2C0BEB1 VA: 0x2C0BDB0
	|-Array.InternalArray__set_Item<ValueTuple<int, bool>>
	|
	|-RVA: 0x2C0BF30 Offset: 0x2C0C031 VA: 0x2C0BF30
	|-Array.InternalArray__set_Item<ValueTuple<int, Bounds>>
	|
	|-RVA: 0x2C0C0E0 Offset: 0x2C0C1E1 VA: 0x2C0C0E0
	|-Array.InternalArray__set_Item<ValueTuple<int, byte>>
	|
	|-RVA: 0x2C0C260 Offset: 0x2C0C361 VA: 0x2C0C260
	|-Array.InternalArray__set_Item<ValueTuple<int, Color>>
	|
	|-RVA: 0x2C0C400 Offset: 0x2C0C501 VA: 0x2C0C400
	|-Array.InternalArray__set_Item<ValueTuple<int, double>>
	|
	|-RVA: 0x2C0C580 Offset: 0x2C0C681 VA: 0x2C0C580
	|-Array.InternalArray__set_Item<ValueTuple<int, int>>
	|
	|-RVA: 0x2C0C700 Offset: 0x2C0C801 VA: 0x2C0C700
	|-Array.InternalArray__set_Item<ValueTuple<int, long>>
	|
	|-RVA: 0x2C0C880 Offset: 0x2C0C981 VA: 0x2C0C880
	|-Array.InternalArray__set_Item<ValueTuple<int, object>>
	|
	|-RVA: 0x2C0CA00 Offset: 0x2C0CB01 VA: 0x2C0CA00
	|-Array.InternalArray__set_Item<ValueTuple<int, Quaternion>>
	|
	|-RVA: 0x2C0CBA0 Offset: 0x2C0CCA1 VA: 0x2C0CBA0
	|-Array.InternalArray__set_Item<ValueTuple<int, Rect>>
	|
	|-RVA: 0x2C0CD40 Offset: 0x2C0CE41 VA: 0x2C0CD40
	|-Array.InternalArray__set_Item<ValueTuple<int, float>>
	|
	|-RVA: 0x2C0CEC0 Offset: 0x2C0CFC1 VA: 0x2C0CEC0
	|-Array.InternalArray__set_Item<ValueTuple<int, Unit>>
	|
	|-RVA: 0x2C0D040 Offset: 0x2C0D141 VA: 0x2C0D040
	|-Array.InternalArray__set_Item<ValueTuple<int, Vector2>>
	|
	|-RVA: 0x2C0D1D0 Offset: 0x2C0D2D1 VA: 0x2C0D1D0
	|-Array.InternalArray__set_Item<ValueTuple<int, Vector3>>
	|
	|-RVA: 0x2C0D350 Offset: 0x2C0D451 VA: 0x2C0D350
	|-Array.InternalArray__set_Item<ValueTuple<int, Vector4>>
	|
	|-RVA: 0x2C0D4F0 Offset: 0x2C0D5F1 VA: 0x2C0D4F0
	|-Array.InternalArray__set_Item<ValueTuple<Int32Enum, int>>
	|
	|-RVA: 0x2C0D670 Offset: 0x2C0D771 VA: 0x2C0D670
	|-Array.InternalArray__set_Item<ValueTuple<object, ValueTuple<object, int>>>
	|
	|-RVA: 0x2C0D810 Offset: 0x2C0D911 VA: 0x2C0D810
	|-Array.InternalArray__set_Item<ValueTuple<object, int>>
	|
	|-RVA: 0x2C0D990 Offset: 0x2C0DA91 VA: 0x2C0D990
	|-Array.InternalArray__set_Item<ValueTuple<object, object>>
	|
	|-RVA: 0x2C0DB10 Offset: 0x2C0DC11 VA: 0x2C0DB10
	|-Array.InternalArray__set_Item<ValueTuple<object, float>>
	|
	|-RVA: 0x2C0DC90 Offset: 0x2C0DD91 VA: 0x2C0DC90
	|-Array.InternalArray__set_Item<ValueTuple<Vector3, float>>
	|
	|-RVA: 0x2C0DE10 Offset: 0x2C0DF11 VA: 0x2C0DE10
	|-Array.InternalArray__set_Item<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>>>
	|
	|-RVA: 0x2C0DFC0 Offset: 0x2C0E0C1 VA: 0x2C0DFC0
	|-Array.InternalArray__set_Item<ValueTuple<object, Int32Enum, int>>
	|
	|-RVA: 0x2C0E140 Offset: 0x2C0E241 VA: 0x2C0E140
	|-Array.InternalArray__set_Item<ValueTuple<object, object, object>>
	|
	|-RVA: 0x2C0E2E0 Offset: 0x2C0E3E1 VA: 0x2C0E2E0
	|-Array.InternalArray__set_Item<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>
	|
	|-RVA: 0x2C0E490 Offset: 0x2C0E591 VA: 0x2C0E490
	|-Array.InternalArray__set_Item<ValueTuple<object, int, int, int>>
	|
	|-RVA: 0x2C0E630 Offset: 0x2C0E731 VA: 0x2C0E630
	|-Array.InternalArray__set_Item<ValueTuple<object, object, object, object>>
	|
	|-RVA: 0x2C0E7D0 Offset: 0x2C0E8D1 VA: 0x2C0E7D0
	|-Array.InternalArray__set_Item<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>
	|
	|-RVA: 0x2C0E990 Offset: 0x2C0EA91 VA: 0x2C0E990
	|-Array.InternalArray__set_Item<ValueTuple<object, object, object, object, object>>
	|
	|-RVA: 0x2C0EB40 Offset: 0x2C0EC41 VA: 0x2C0EB40
	|-Array.InternalArray__set_Item<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>
	|
	|-RVA: 0x2C0ED00 Offset: 0x2C0EE01 VA: 0x2C0ED00
	|-Array.InternalArray__set_Item<ValueTuple<object, object, object, object, object, object>>
	|
	|-RVA: 0x2C0EEB0 Offset: 0x2C0EFB1 VA: 0x2C0EEB0
	|-Array.InternalArray__set_Item<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>>>
	|
	|-RVA: 0x2C0F080 Offset: 0x2C0F181 VA: 0x2C0F080
	|-Array.InternalArray__set_Item<ValueTuple<object, object, object, object, object, object, object>>
	|
	|-RVA: 0x2C0F230 Offset: 0x2C0F331 VA: 0x2C0F230
	|-Array.InternalArray__set_Item<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>>>>
	|
	|-RVA: 0x2C0F400 Offset: 0x2C0F501 VA: 0x2C0F400
	|-Array.InternalArray__set_Item<ValueTuple<int, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<bool, object>, ValueTuple<ValueTuple<bool, object>, ValueTuple<bool, object>>>>
	|
	|-RVA: 0x2C0F5A0 Offset: 0x2C0F6A1 VA: 0x2C0F5A0
	|-Array.InternalArray__set_Item<AnimatorClipInfo>
	|
	|-RVA: 0x2C0F720 Offset: 0x2C0F821 VA: 0x2C0F720
	|-Array.InternalArray__set_Item<AsyncOperationHandle>
	|
	|-RVA: 0x2C0F8C0 Offset: 0x2C0F9C1 VA: 0x2C0F8C0
	|-Array.InternalArray__set_Item<AsyncUnit>
	|
	|-RVA: 0x2C0FA40 Offset: 0x2C0FB41 VA: 0x2C0FA40
	|-Array.InternalArray__set_Item<BatchVisibility>
	|
	|-RVA: 0x2C0FBD0 Offset: 0x2C0FCD1 VA: 0x2C0FBD0
	|-Array.InternalArray__set_Item<BoneWeight>
	|
	|-RVA: 0x2C0FD70 Offset: 0x2C0FE71 VA: 0x2C0FD70
	|-Array.InternalArray__set_Item<BoneWeight1>
	|
	|-RVA: 0x2C0FEF0 Offset: 0x2C0FFF1 VA: 0x2C0FEF0
	|-Array.InternalArray__set_Item<bool>
	|
	|-RVA: 0x2C10070 Offset: 0x2C10171 VA: 0x2C10070
	|-Array.InternalArray__set_Item<Bounds>
	|
	|-RVA: 0x2C10210 Offset: 0x2C10311 VA: 0x2C10210
	|-Array.InternalArray__set_Item<byte>
	|
	|-RVA: 0x2C10390 Offset: 0x2C10491 VA: 0x2C10390
	|-Array.InternalArray__set_Item<ByteEnum>
	|
	|-RVA: 0x2C10510 Offset: 0x2C10611 VA: 0x2C10510
	|-Array.InternalArray__set_Item<CameraInfo>
	|
	|-RVA: 0x2C10690 Offset: 0x2C10791 VA: 0x2C10690
	|-Array.InternalArray__set_Item<CancellationToken>
	|
	|-RVA: 0x2C10810 Offset: 0x2C10911 VA: 0x2C10810
	|-Array.InternalArray__set_Item<CancellationTokenRegistration>
	|
	|-RVA: 0x2C109B0 Offset: 0x2C10AB1 VA: 0x2C109B0
	|-Array.InternalArray__set_Item<char>
	|
	|-RVA: 0x2C10B30 Offset: 0x2C10C31 VA: 0x2C10B30
	|-Array.InternalArray__set_Item<ClusteringData>
	|
	|-RVA: 0x2C10CD0 Offset: 0x2C10DD1 VA: 0x2C10CD0
	|-Array.InternalArray__set_Item<ClusteringProcessorState>
	|
	|-RVA: 0x2C10E70 Offset: 0x2C10F71 VA: 0x2C10E70
	|-Array.InternalArray__set_Item<Color>
	|
	|-RVA: 0x2C10FF0 Offset: 0x2C110F1 VA: 0x2C10FF0
	|-Array.InternalArray__set_Item<Color32>
	|
	|-RVA: 0x2C11170 Offset: 0x2C11271 VA: 0x2C11170
	|-Array.InternalArray__set_Item<Color4u8>
	|
	|-RVA: 0x2C112F0 Offset: 0x2C113F1 VA: 0x2C112F0
	|-Array.InternalArray__set_Item<ColorBlock>
	|
	|-RVA: 0x2C114B0 Offset: 0x2C115B1 VA: 0x2C114B0
	|-Array.InternalArray__set_Item<CombineInstance>
	|
	|-RVA: 0x2C11680 Offset: 0x2C11781 VA: 0x2C11680
	|-Array.InternalArray__set_Item<ConstraintSource>
	|
	|-RVA: 0x2C11800 Offset: 0x2C11901 VA: 0x2C11800
	|-Array.InternalArray__set_Item<ContactPoint>
	|
	|-RVA: 0x2C119B0 Offset: 0x2C11AB1 VA: 0x2C119B0
	|-Array.InternalArray__set_Item<ContactPoint2D>
	|
	|-RVA: 0x2C11B60 Offset: 0x2C11C61 VA: 0x2C11B60
	|-Array.InternalArray__set_Item<ContourVertex>
	|
	|-RVA: 0x2C11D00 Offset: 0x2C11E01 VA: 0x2C11D00
	|-Array.InternalArray__set_Item<CustomAttributeNamedArgument>
	|
	|-RVA: 0x2C11EA0 Offset: 0x2C11FA1 VA: 0x2C11EA0
	|-Array.InternalArray__set_Item<CustomAttributeTypedArgument>
	|
	|-RVA: 0x2C12020 Offset: 0x2C12121 VA: 0x2C12020
	|-Array.InternalArray__set_Item<DataStoreRatingInfo>
	|
	|-RVA: 0x2C121C0 Offset: 0x2C122C1 VA: 0x2C121C0
	|-Array.InternalArray__set_Item<DataStoreResult>
	|
	|-RVA: 0x2C12340 Offset: 0x2C12441 VA: 0x2C12340
	|-Array.InternalArray__set_Item<DateTime>
	|
	|-RVA: 0x2C124C0 Offset: 0x2C125C1 VA: 0x2C124C0
	|-Array.InternalArray__set_Item<DateTimeOffset>
	|
	|-RVA: 0x2C12640 Offset: 0x2C12741 VA: 0x2C12640
	|-Array.InternalArray__set_Item<DebugPadState>
	|
	|-RVA: 0x2C127E0 Offset: 0x2C128E1 VA: 0x2C127E0
	|-Array.InternalArray__set_Item<Decimal>
	|
	|-RVA: 0x2C12960 Offset: 0x2C12A61 VA: 0x2C12960
	|-Array.InternalArray__set_Item<DeferredTiler>
	|
	|-RVA: 0x2C12B30 Offset: 0x2C12C31 VA: 0x2C12B30
	|-Array.InternalArray__set_Item<DeviceHandle>
	|
	|-RVA: 0x2C12CB0 Offset: 0x2C12DB1 VA: 0x2C12CB0
	|-Array.InternalArray__set_Item<DiagnosticEvent>
	|
	|-RVA: 0x2C12E60 Offset: 0x2C12F61 VA: 0x2C12E60
	|-Array.InternalArray__set_Item<DictionaryEntry>
	|
	|-RVA: 0x2C12FE0 Offset: 0x2C130E1 VA: 0x2C12FE0
	|-Array.InternalArray__set_Item<DictionaryInfo>
	|
	|-RVA: 0x2C13160 Offset: 0x2C13261 VA: 0x2C13160
	|-Array.InternalArray__set_Item<DirectoryEntry>
	|
	|-RVA: 0x2C13300 Offset: 0x2C13401 VA: 0x2C13300
	|-Array.InternalArray__set_Item<double>
	|
	|-RVA: 0x2C13480 Offset: 0x2C13581 VA: 0x2C13480
	|-Array.InternalArray__set_Item<Ephemeron>
	|
	|-RVA: 0x2C13600 Offset: 0x2C13701 VA: 0x2C13600
	|-Array.InternalArray__set_Item<FXZ>
	|
	|-RVA: 0x2C13780 Offset: 0x2C13881 VA: 0x2C13780
	|-Array.InternalArray__set_Item<Finger>
	|
	|-RVA: 0x2C13930 Offset: 0x2C13A31 VA: 0x2C13930
	|-Array.InternalArray__set_Item<Float2>
	|
	|-RVA: 0x2C13AB0 Offset: 0x2C13BB1 VA: 0x2C13AB0
	|-Array.InternalArray__set_Item<Friend>
	|
	|-RVA: 0x2C13C50 Offset: 0x2C13D51 VA: 0x2C13C50
	|-Array.InternalArray__set_Item<GCHandle>
	|
	|-RVA: 0x2C13DD0 Offset: 0x2C13ED1 VA: 0x2C13DD0
	|-Array.InternalArray__set_Item<GesturePoint>
	|
	|-RVA: 0x2C13F50 Offset: 0x2C14051 VA: 0x2C13F50
	|-Array.InternalArray__set_Item<GestureState>
	|
	|-RVA: 0x2C14110 Offset: 0x2C14211 VA: 0x2C14110
	|-Array.InternalArray__set_Item<GlyphMarshallingStruct>
	|
	|-RVA: 0x2C142C0 Offset: 0x2C143C1 VA: 0x2C142C0
	|-Array.InternalArray__set_Item<GlyphPairAdjustmentRecord>
	|
	|-RVA: 0x2C14470 Offset: 0x2C14571 VA: 0x2C14470
	|-Array.InternalArray__set_Item<GlyphRect>
	|
	|-RVA: 0x2C145F0 Offset: 0x2C146F1 VA: 0x2C145F0
	|-Array.InternalArray__set_Item<Guid>
	|
	|-RVA: 0x2C14770 Offset: 0x2C14871 VA: 0x2C14770
	|-Array.InternalArray__set_Item<Hand>
	|
	|-RVA: 0x2C14910 Offset: 0x2C14A11 VA: 0x2C14910
	|-Array.InternalArray__set_Item<HandAnalysisImageState>
	|
	|-RVA: 0x2C14A90 Offset: 0x2C14B91 VA: 0x2C14A90
	|-Array.InternalArray__set_Item<HandAnalysisSilhouetteState>
	|
	|-RVA: 0x2C14C30 Offset: 0x2C14D31 VA: 0x2C14C30
	|-Array.InternalArray__set_Item<HeaderVariantInfo>
	|
	|-RVA: 0x2C14DB0 Offset: 0x2C14EB1 VA: 0x2C14DB0
	|-Array.InternalArray__set_Item<HighlightState>
	|
	|-RVA: 0x2C14F50 Offset: 0x2C15051 VA: 0x2C14F50
	|-Array.InternalArray__set_Item<HumanBone>
	|
	|-RVA: 0x2C15100 Offset: 0x2C15201 VA: 0x2C15100
	|-Array.InternalArray__set_Item<short>
	|
	|-RVA: 0x2C15280 Offset: 0x2C15381 VA: 0x2C15280
	|-Array.InternalArray__set_Item<int>
	|
	|-RVA: 0x2C15400 Offset: 0x2C15501 VA: 0x2C15400
	|-Array.InternalArray__set_Item<Int32Enum>
	|
	|-RVA: 0x2C15580 Offset: 0x2C15681 VA: 0x2C15580
	|-Array.InternalArray__set_Item<long>
	|
	|-RVA: 0x2C15700 Offset: 0x2C15801 VA: 0x2C15700
	|-Array.InternalArray__set_Item<Int64Enum>
	|
	|-RVA: 0x2C15880 Offset: 0x2C15981 VA: 0x2C15880
	|-Array.InternalArray__set_Item<IntPtr>
	|
	|-RVA: 0x2C15A00 Offset: 0x2C15B01 VA: 0x2C15A00
	|-Array.InternalArray__set_Item<InternalCodePageDataItem>
	|
	|-RVA: 0x2C15B80 Offset: 0x2C15C81 VA: 0x2C15B80
	|-Array.InternalArray__set_Item<InternalEncodingDataItem>
	|
	|-RVA: 0x2C15D00 Offset: 0x2C15E01 VA: 0x2C15D00
	|-Array.InternalArray__set_Item<InterpretedFrameInfo>
	|
	|-RVA: 0x2C15E80 Offset: 0x2C15F81 VA: 0x2C15E80
	|-Array.InternalArray__set_Item<IntervalTreeNode>
	|
	|-RVA: 0x2C16020 Offset: 0x2C16121 VA: 0x2C16020
	|-Array.InternalArray__set_Item<JobHandle>
	|
	|-RVA: 0x2C161A0 Offset: 0x2C162A1 VA: 0x2C161A0
	|-Array.InternalArray__set_Item<Keyframe>
	|
	|-RVA: 0x2C16350 Offset: 0x2C16451 VA: 0x2C16350
	|-Array.InternalArray__set_Item<LOD>
	|
	|-RVA: 0x2C164D0 Offset: 0x2C165D1 VA: 0x2C164D0
	|-Array.InternalArray__set_Item<LayerMask>
	|
	|-RVA: 0x2C16650 Offset: 0x2C16751 VA: 0x2C16650
	|-Array.InternalArray__set_Item<LengthLimitProperties>
	|
	|-RVA: 0x2C167D0 Offset: 0x2C168D1 VA: 0x2C167D0
	|-Array.InternalArray__set_Item<Light2DBlendStyle>
	|
	|-RVA: 0x2C16990 Offset: 0x2C16A91 VA: 0x2C16990
	|-Array.InternalArray__set_Item<LightDataGI>
	|
	|-RVA: 0x2C16B50 Offset: 0x2C16C51 VA: 0x2C16B50
	|-Array.InternalArray__set_Item<LocalDefinition>
	|
	|-RVA: 0x2C16CD0 Offset: 0x2C16DD1 VA: 0x2C16CD0
	|-Array.InternalArray__set_Item<MapPos>
	|
	|-RVA: 0x2C16E50 Offset: 0x2C16F51 VA: 0x2C16E50
	|-Array.InternalArray__set_Item<MapRange>
	|
	|-RVA: 0x2C16FE0 Offset: 0x2C170E1 VA: 0x2C16FE0
	|-Array.InternalArray__set_Item<MaterialReference>
	|
	|-RVA: 0x2C17190 Offset: 0x2C17291 VA: 0x2C17190
	|-Array.InternalArray__set_Item<Matrix4x4>
	|
	|-RVA: 0x2C17340 Offset: 0x2C17441 VA: 0x2C17340
	|-Array.InternalArray__set_Item<MomentProcessorState>
	|
	|-RVA: 0x2C174E0 Offset: 0x2C175E1 VA: 0x2C174E0
	|-Array.InternalArray__set_Item<MomentStatistic>
	|
	|-RVA: 0x2C17670 Offset: 0x2C17771 VA: 0x2C17670
	|-Array.InternalArray__set_Item<Navigation>
	|
	|-RVA: 0x2C17820 Offset: 0x2C17921 VA: 0x2C17820
	|-Array.InternalArray__set_Item<NetworkServiceAccountId>
	|
	|-RVA: 0x2C179A0 Offset: 0x2C17AA1 VA: 0x2C179A0
	|-Array.InternalArray__set_Item<NpadFullKeyState>
	|
	|-RVA: 0x2C17B50 Offset: 0x2C17C51 VA: 0x2C17B50
	|-Array.InternalArray__set_Item<NpadHandheldState>
	|
	|-RVA: 0x2C17D00 Offset: 0x2C17E01 VA: 0x2C17D00
	|-Array.InternalArray__set_Item<NpadJoyDualState>
	|
	|-RVA: 0x2C17EB0 Offset: 0x2C17FB1 VA: 0x2C17EB0
	|-Array.InternalArray__set_Item<NpadJoyLeftState>
	|
	|-RVA: 0x2C18060 Offset: 0x2C18161 VA: 0x2C18060
	|-Array.InternalArray__set_Item<NpadJoyRightState>
	|
	|-RVA: 0x2C18210 Offset: 0x2C18311 VA: 0x2C18210
	|-Array.InternalArray__set_Item<NpadStateArrayItem>
	|
	|-RVA: 0x2C183C0 Offset: 0x2C184C1 VA: 0x2C183C0
	|-Array.InternalArray__set_Item<NsUid>
	|
	|-RVA: 0x2C18540 Offset: 0x2C18641 VA: 0x2C18540
	|-Array.InternalArray__set_Item<object>
	|
	|-RVA: 0x2C186A0 Offset: 0x2C187A1 VA: 0x2C186A0
	|-Array.InternalArray__set_Item<ObjectInitializationData>
	|
	|-RVA: 0x2C18850 Offset: 0x2C18951 VA: 0x2C18850
	|-Array.InternalArray__set_Item<ParameterModifier>
	|
	|-RVA: 0x2C189D0 Offset: 0x2C18AD1 VA: 0x2C189D0
	|-Array.InternalArray__set_Item<Plane>
	|
	|-RVA: 0x2C18B50 Offset: 0x2C18C51 VA: 0x2C18B50
	|-Array.InternalArray__set_Item<Playable>
	|
	|-RVA: 0x2C18CD0 Offset: 0x2C18DD1 VA: 0x2C18CD0
	|-Array.InternalArray__set_Item<PlayableBinding>
	|
	|-RVA: 0x2C18E70 Offset: 0x2C18F71 VA: 0x2C18E70
	|-Array.InternalArray__set_Item<PlayerLoopSystem>
	|
	|-RVA: 0x2C19020 Offset: 0x2C19121 VA: 0x2C19020
	|-Array.InternalArray__set_Item<PlayerLoopSystemInternal>
	|
	|-RVA: 0x2C191D0 Offset: 0x2C192D1 VA: 0x2C191D0
	|-Array.InternalArray__set_Item<PreTile>
	|
	|-RVA: 0x2C19380 Offset: 0x2C19481 VA: 0x2C19380
	|-Array.InternalArray__set_Item<Profile>
	|
	|-RVA: 0x2C19520 Offset: 0x2C19621 VA: 0x2C19520
	|-Array.InternalArray__set_Item<Protrusion>
	|
	|-RVA: 0x2C196A0 Offset: 0x2C197A1 VA: 0x2C196A0
	|-Array.InternalArray__set_Item<Quaternion>
	|
	|-RVA: 0x2C19820 Offset: 0x2C19921 VA: 0x2C19820
	|-Array.InternalArray__set_Item<RandomSeed>
	|
	|-RVA: 0x2C199A0 Offset: 0x2C19AA1 VA: 0x2C199A0
	|-Array.InternalArray__set_Item<RangePositionInfo>
	|
	|-RVA: 0x2C19B20 Offset: 0x2C19C21 VA: 0x2C19B20
	|-Array.InternalArray__set_Item<Ranking2ChartInfoInput>
	|
	|-RVA: 0x2C19CA0 Offset: 0x2C19DA1 VA: 0x2C19CA0
	|-Array.InternalArray__set_Item<RaycastHit>
	|
	|-RVA: 0x2C19E50 Offset: 0x2C19F51 VA: 0x2C19E50
	|-Array.InternalArray__set_Item<RaycastHit2D>
	|
	|-RVA: 0x2C1A000 Offset: 0x2C1A101 VA: 0x2C1A000
	|-Array.InternalArray__set_Item<RaycastResult>
	|
	|-RVA: 0x2C1A1C0 Offset: 0x2C1A2C1 VA: 0x2C1A1C0
	|-Array.InternalArray__set_Item<Rect>
	|
	|-RVA: 0x2C1A340 Offset: 0x2C1A441 VA: 0x2C1A340
	|-Array.InternalArray__set_Item<RenderBuffer>
	|
	|-RVA: 0x2C1A4C0 Offset: 0x2C1A5C1 VA: 0x2C1A4C0
	|-Array.InternalArray__set_Item<RenderStateBlock>
	|
	|-RVA: 0x2C1A690 Offset: 0x2C1A791 VA: 0x2C1A690
	|-Array.InternalArray__set_Item<RenderTargetHandle>
	|
	|-RVA: 0x2C1A840 Offset: 0x2C1A941 VA: 0x2C1A840
	|-Array.InternalArray__set_Item<RenderTargetIdentifier>
	|
	|-RVA: 0x2C1A9F0 Offset: 0x2C1AAF1 VA: 0x2C1A9F0
	|-Array.InternalArray__set_Item<RendererListHandle>
	|
	|-RVA: 0x2C1AB70 Offset: 0x2C1AC71 VA: 0x2C1AB70
	|-Array.InternalArray__set_Item<ResourceHandle>
	|
	|-RVA: 0x2C1ACF0 Offset: 0x2C1ADF1 VA: 0x2C1ACF0
	|-Array.InternalArray__set_Item<ResourceLocator>
	|
	|-RVA: 0x2C1AE70 Offset: 0x2C1AF71 VA: 0x2C1AE70
	|-Array.InternalArray__set_Item<RichTextTagAttribute>
	|
	|-RVA: 0x2C1B010 Offset: 0x2C1B111 VA: 0x2C1B010
	|-Array.InternalArray__set_Item<RuntimeLabel>
	|
	|-RVA: 0x2C1B1A0 Offset: 0x2C1B2A1 VA: 0x2C1B1A0
	|-Array.InternalArray__set_Item<sbyte>
	|
	|-RVA: 0x2C1B320 Offset: 0x2C1B421 VA: 0x2C1B320
	|-Array.InternalArray__set_Item<SerializedType>
	|
	|-RVA: 0x2C1B4C0 Offset: 0x2C1B5C1 VA: 0x2C1B4C0
	|-Array.InternalArray__set_Item<ShaderKeyword>
	|
	|-RVA: 0x2C1B640 Offset: 0x2C1B741 VA: 0x2C1B640
	|-Array.InternalArray__set_Item<ShaderTagId>
	|
	|-RVA: 0x2C1B7C0 Offset: 0x2C1B8C1 VA: 0x2C1B7C0
	|-Array.InternalArray__set_Item<ShadowSliceData>
	|
	|-RVA: 0x2C1B960 Offset: 0x2C1BA61 VA: 0x2C1B960
	|-Array.InternalArray__set_Item<Shape>
	|
	|-RVA: 0x2C1BB00 Offset: 0x2C1BC01 VA: 0x2C1BB00
	|-Array.InternalArray__set_Item<float>
	|
	|-RVA: 0x2C1BC80 Offset: 0x2C1BD81 VA: 0x2C1BC80
	|-Array.InternalArray__set_Item<SixAxisSensorHandle>
	|
	|-RVA: 0x2C1BE00 Offset: 0x2C1BF01 VA: 0x2C1BE00
	|-Array.InternalArray__set_Item<SixAxisSensorState>
	|
	|-RVA: 0x2C1BFC0 Offset: 0x2C1C0C1 VA: 0x2C1BFC0
	|-Array.InternalArray__set_Item<SkeletonBone>
	|
	|-RVA: 0x2C1C170 Offset: 0x2C1C271 VA: 0x2C1C170
	|-Array.InternalArray__set_Item<SortingLayer>
	|
	|-RVA: 0x2C1C2F0 Offset: 0x2C1C3F1 VA: 0x2C1C2F0
	|-Array.InternalArray__set_Item<SphericalHarmonicsL2>
	|
	|-RVA: 0x2C1C4C0 Offset: 0x2C1C5C1 VA: 0x2C1C4C0
	|-Array.InternalArray__set_Item<SpinLock>
	|
	|-RVA: 0x2C1C640 Offset: 0x2C1C741 VA: 0x2C1C640
	|-Array.InternalArray__set_Item<SpringBoneComponents>
	|
	|-RVA: 0x2C1C800 Offset: 0x2C1C901 VA: 0x2C1C800
	|-Array.InternalArray__set_Item<SpringBoneProperties>
	|
	|-RVA: 0x2C1C9A0 Offset: 0x2C1CAA1 VA: 0x2C1C9A0
	|-Array.InternalArray__set_Item<SpringColliderComponents>
	|
	|-RVA: 0x2C1CB70 Offset: 0x2C1CC71 VA: 0x2C1CB70
	|-Array.InternalArray__set_Item<SpringColliderProperties>
	|
	|-RVA: 0x2C1CCF0 Offset: 0x2C1CDF1 VA: 0x2C1CCF0
	|-Array.InternalArray__set_Item<SpringForceComponent>
	|
	|-RVA: 0x2C1CEA0 Offset: 0x2C1CFA1 VA: 0x2C1CEA0
	|-Array.InternalArray__set_Item<SpringJobElement>
	|
	|-RVA: 0x2C1D040 Offset: 0x2C1D141 VA: 0x2C1D040
	|-Array.InternalArray__set_Item<SpriteState>
	|
	|-RVA: 0x2C1D1E0 Offset: 0x2C1D2E1 VA: 0x2C1D1E0
	|-Array.InternalArray__set_Item<SubMeshDescriptor>
	|
	|-RVA: 0x2C1D390 Offset: 0x2C1D491 VA: 0x2C1D390
	|-Array.InternalArray__set_Item<TMP_CharacterInfo>
	|
	|-RVA: 0x2C1D530 Offset: 0x2C1D631 VA: 0x2C1D530
	|-Array.InternalArray__set_Item<TMP_FontWeightPair>
	|
	|-RVA: 0x2C1D6B0 Offset: 0x2C1D7B1 VA: 0x2C1D6B0
	|-Array.InternalArray__set_Item<TMP_LineInfo>
	|
	|-RVA: 0x2C1D880 Offset: 0x2C1D981 VA: 0x2C1D880
	|-Array.InternalArray__set_Item<TMP_LinkInfo>
	|
	|-RVA: 0x2C1DA30 Offset: 0x2C1DB31 VA: 0x2C1DA30
	|-Array.InternalArray__set_Item<TMP_MeshInfo>
	|
	|-RVA: 0x2C1DBF0 Offset: 0x2C1DCF1 VA: 0x2C1DBF0
	|-Array.InternalArray__set_Item<TMP_PageInfo>
	|
	|-RVA: 0x2C1DD90 Offset: 0x2C1DE91 VA: 0x2C1DD90
	|-Array.InternalArray__set_Item<TMP_WordInfo>
	|
	|-RVA: 0x2C1DF30 Offset: 0x2C1E031 VA: 0x2C1DF30
	|-Array.InternalArray__set_Item<TablePair>
	|
	|-RVA: 0x2C1E0B0 Offset: 0x2C1E1B1 VA: 0x2C1E0B0
	|-Array.InternalArray__set_Item<TextureHandle>
	|
	|-RVA: 0x2C1E230 Offset: 0x2C1E331 VA: 0x2C1E230
	|-Array.InternalArray__set_Item<TimeSpan>
	|
	|-RVA: 0x2C1E3B0 Offset: 0x2C1E4B1 VA: 0x2C1E3B0
	|-Array.InternalArray__set_Item<Touch>
	|
	|-RVA: 0x2C1E570 Offset: 0x2C1E671 VA: 0x2C1E570
	|-Array.InternalArray__set_Item<TouchScreenState1>
	|
	|-RVA: 0x2C1E720 Offset: 0x2C1E821 VA: 0x2C1E720
	|-Array.InternalArray__set_Item<TouchScreenState10>
	|
	|-RVA: 0x2C1E8C0 Offset: 0x2C1E9C1 VA: 0x2C1E8C0
	|-Array.InternalArray__set_Item<TouchScreenState11>
	|
	|-RVA: 0x2C1EA60 Offset: 0x2C1EB61 VA: 0x2C1EA60
	|-Array.InternalArray__set_Item<TouchScreenState12>
	|
	|-RVA: 0x2C1EC00 Offset: 0x2C1ED01 VA: 0x2C1EC00
	|-Array.InternalArray__set_Item<TouchScreenState13>
	|
	|-RVA: 0x2C1EDA0 Offset: 0x2C1EEA1 VA: 0x2C1EDA0
	|-Array.InternalArray__set_Item<TouchScreenState14>
	|
	|-RVA: 0x2C1EF40 Offset: 0x2C1F041 VA: 0x2C1EF40
	|-Array.InternalArray__set_Item<TouchScreenState15>
	|
	|-RVA: 0x2C1F0E0 Offset: 0x2C1F1E1 VA: 0x2C1F0E0
	|-Array.InternalArray__set_Item<TouchScreenState16>
	|
	|-RVA: 0x2C1F280 Offset: 0x2C1F381 VA: 0x2C1F280
	|-Array.InternalArray__set_Item<TouchScreenState2>
	|
	|-RVA: 0x2C1F440 Offset: 0x2C1F541 VA: 0x2C1F440
	|-Array.InternalArray__set_Item<TouchScreenState3>
	|
	|-RVA: 0x2C1F5E0 Offset: 0x2C1F6E1 VA: 0x2C1F5E0
	|-Array.InternalArray__set_Item<TouchScreenState4>
	|
	|-RVA: 0x2C1F780 Offset: 0x2C1F881 VA: 0x2C1F780
	|-Array.InternalArray__set_Item<TouchScreenState5>
	|
	|-RVA: 0x2C1F920 Offset: 0x2C1FA21 VA: 0x2C1F920
	|-Array.InternalArray__set_Item<TouchScreenState6>
	|
	|-RVA: 0x2C1FAC0 Offset: 0x2C1FBC1 VA: 0x2C1FAC0
	|-Array.InternalArray__set_Item<TouchScreenState7>
	|
	|-RVA: 0x2C1FC60 Offset: 0x2C1FD61 VA: 0x2C1FC60
	|-Array.InternalArray__set_Item<TouchScreenState8>
	|
	|-RVA: 0x2C1FE00 Offset: 0x2C1FF01 VA: 0x2C1FE00
	|-Array.InternalArray__set_Item<TouchScreenState9>
	|
	|-RVA: 0x2C1FFA0 Offset: 0x2C200A1 VA: 0x2C1FFA0
	|-Array.InternalArray__set_Item<TouchState>
	|
	|-RVA: 0x2C20150 Offset: 0x2C20251 VA: 0x2C20150
	|-Array.InternalArray__set_Item<TrailHand>
	|
	|-RVA: 0x2C202F0 Offset: 0x2C203F1 VA: 0x2C202F0
	|-Array.InternalArray__set_Item<TrailVertex>
	|
	|-RVA: 0x2C20490 Offset: 0x2C20591 VA: 0x2C20490
	|-Array.InternalArray__set_Item<UICharInfo>
	|
	|-RVA: 0x2C20620 Offset: 0x2C20721 VA: 0x2C20620
	|-Array.InternalArray__set_Item<UILineInfo>
	|
	|-RVA: 0x2C207A0 Offset: 0x2C208A1 VA: 0x2C207A0
	|-Array.InternalArray__set_Item<UIVertex>
	|
	|-RVA: 0x2C20970 Offset: 0x2C20A71 VA: 0x2C20970
	|-Array.InternalArray__set_Item<ushort>
	|
	|-RVA: 0x2C20AF0 Offset: 0x2C20BF1 VA: 0x2C20AF0
	|-Array.InternalArray__set_Item<UInt16Enum>
	|
	|-RVA: 0x2C20C70 Offset: 0x2C20D71 VA: 0x2C20C70
	|-Array.InternalArray__set_Item<uint>
	|
	|-RVA: 0x2C20DF0 Offset: 0x2C20EF1 VA: 0x2C20DF0
	|-Array.InternalArray__set_Item<UInt32Enum>
	|
	|-RVA: 0x2C20F70 Offset: 0x2C21071 VA: 0x2C20F70
	|-Array.InternalArray__set_Item<ulong>
	|
	|-RVA: 0x2C210F0 Offset: 0x2C211F1 VA: 0x2C210F0
	|-Array.InternalArray__set_Item<Uid>
	|
	|-RVA: 0x2C21270 Offset: 0x2C21371 VA: 0x2C21270
	|-Array.InternalArray__set_Item<UniTask>
	|
	|-RVA: 0x2C213F0 Offset: 0x2C214F1 VA: 0x2C213F0
	|-Array.InternalArray__set_Item<Unit>
	|
	|-RVA: 0x2C21570 Offset: 0x2C21671 VA: 0x2C21570
	|-Array.InternalArray__set_Item<UnitEnum>
	|
	|-RVA: 0x2C216F0 Offset: 0x2C217F1 VA: 0x2C216F0
	|-Array.InternalArray__set_Item<UserWord>
	|
	|-RVA: 0x2C21870 Offset: 0x2C21971 VA: 0x2C21870
	|-Array.InternalArray__set_Item<Vector2>
	|
	|-RVA: 0x2C219F0 Offset: 0x2C21AF1 VA: 0x2C219F0
	|-Array.InternalArray__set_Item<Vector2Int>
	|
	|-RVA: 0x2C21B70 Offset: 0x2C21C71 VA: 0x2C21B70
	|-Array.InternalArray__set_Item<Vector3>
	|
	|-RVA: 0x2C21D00 Offset: 0x2C21E01 VA: 0x2C21D00
	|-Array.InternalArray__set_Item<Vector4>
	|
	|-RVA: 0x2C21E80 Offset: 0x2C21F81 VA: 0x2C21E80
	|-Array.InternalArray__set_Item<VertexAttributeDescriptor>
	|
	|-RVA: 0x2C22000 Offset: 0x2C22101 VA: 0x2C22000
	|-Array.InternalArray__set_Item<VibrationDeviceHandle>
	|
	|-RVA: 0x2C22180 Offset: 0x2C22281 VA: 0x2C22180
	|-Array.InternalArray__set_Item<VibrationDeviceInfo>
	|
	|-RVA: 0x2C22300 Offset: 0x2C22401 VA: 0x2C22300
	|-Array.InternalArray__set_Item<VibrationValue>
	|
	|-RVA: 0x2C22480 Offset: 0x2C22581 VA: 0x2C22480
	|-Array.InternalArray__set_Item<VisibleLight>
	|
	|-RVA: 0x2C22660 Offset: 0x2C22761 VA: 0x2C22660
	|-Array.InternalArray__set_Item<WordWrapState>
	|
	|-RVA: 0x2C22800 Offset: 0x2C22901 VA: 0x2C22800
	|-Array.InternalArray__set_Item<X509ChainStatus>
	|
	|-RVA: 0x2C22980 Offset: 0x2C22A81 VA: 0x2C22980
	|-Array.InternalArray__set_Item<XPathNode>
	|
	|-RVA: 0x2C22B20 Offset: 0x2C22C21 VA: 0x2C22B20
	|-Array.InternalArray__set_Item<XPathNodeRef>
	|
	|-RVA: 0x2C22CA0 Offset: 0x2C22DA1 VA: 0x2C22CA0
	|-Array.InternalArray__set_Item<XRView>
	|
	|-RVA: 0x2C22E40 Offset: 0x2C22F41 VA: 0x2C22E40
	|-Array.InternalArray__set_Item<float3>
	|
	|-RVA: 0x2C22FD0 Offset: 0x2C230D1 VA: 0x2C22FD0
	|-Array.InternalArray__set_Item<float4x4>
	|
	|-RVA: 0x2C23180 Offset: 0x2C23281 VA: 0x2C23180
	|-Array.InternalArray__set_Item<jvalue>
	|
	|-RVA: 0x2C23300 Offset: 0x2C23401 VA: 0x2C23300
	|-Array.InternalArray__set_Item<uint4>
	|
	|-RVA: 0x2C23480 Offset: 0x2C23581 VA: 0x2C23480
	|-Array.InternalArray__set_Item<AICrossfire.PositionTable>
	|
	|-RVA: 0x2C23610 Offset: 0x2C23711 VA: 0x2C23610
	|-Array.InternalArray__set_Item<AIEnum.SkillRangeEnemyData>
	|
	|-RVA: 0x2C23790 Offset: 0x2C23891 VA: 0x2C23790
	|-Array.InternalArray__set_Item<AIOrder.UnitPriority>
	|
	|-RVA: 0x2C23910 Offset: 0x2C23A11 VA: 0x2C23910
	|-Array.InternalArray__set_Item<AmiiboSequence.GainItemData>
	|
	|-RVA: 0x2FA7B90 Offset: 0x2FA7C91 VA: 0x2FA7B90
	|-Array.InternalArray__set_Item<AnimationOutputWeightProcessor.WeightInfo>
	|
	|-RVA: 0x2FA7D40 Offset: 0x2FA7E41 VA: 0x2FA7D40
	|-Array.InternalArray__set_Item<ArenaOrderSequence.GodInfo>
	|
	|-RVA: 0x2FA7EC0 Offset: 0x2FA7FC1 VA: 0x2FA7EC0
	|-Array.InternalArray__set_Item<BattleInfo.SupportData>
	|
	|-RVA: 0x2FA8040 Offset: 0x2FA8141 VA: 0x2FA8040
	|-Array.InternalArray__set_Item<BeforeRenderHelper.OrderBlock>
	|
	|-RVA: 0x2FA81C0 Offset: 0x2FA82C1 VA: 0x2FA81C0
	|-Array.InternalArray__set_Item<Camera.RenderRequest>
	|
	|-RVA: 0x2FA8360 Offset: 0x2FA8461 VA: 0x2FA8360
	|-Array.InternalArray__set_Item<CameraState.CustomBlendable>
	|
	|-RVA: 0x2FA84E0 Offset: 0x2FA85E1 VA: 0x2FA84E0
	|-Array.InternalArray__set_Item<CinemachineBlendListCamera.Instruction>
	|
	|-RVA: 0x2FA8680 Offset: 0x2FA8781 VA: 0x2FA8680
	|-Array.InternalArray__set_Item<CinemachineBlenderSettings.CustomBlend>
	|
	|-RVA: 0x2FA8820 Offset: 0x2FA8921 VA: 0x2FA8820
	|-Array.InternalArray__set_Item<CinemachineClearShot.Pair>
	|
	|-RVA: 0x2FA89A0 Offset: 0x2FA8AA1 VA: 0x2FA89A0
	|-Array.InternalArray__set_Item<CinemachineFreeLook.Orbit>
	|
	|-RVA: 0x2FA8B20 Offset: 0x2FA8C21 VA: 0x2FA8B20
	|-Array.InternalArray__set_Item<CinemachinePath.Waypoint>
	|
	|-RVA: 0x2FA8CD0 Offset: 0x2FA8DD1 VA: 0x2FA8CD0
	|-Array.InternalArray__set_Item<CinemachineSmoothPath.Waypoint>
	|
	|-RVA: 0x2FA8E50 Offset: 0x2FA8F51 VA: 0x2FA8E50
	|-Array.InternalArray__set_Item<CinemachineStateDrivenCamera.HashPair>
	|
	|-RVA: 0x2FA8FD0 Offset: 0x2FA90D1 VA: 0x2FA8FD0
	|-Array.InternalArray__set_Item<CinemachineStateDrivenCamera.Instruction>
	|
	|-RVA: 0x2FA9170 Offset: 0x2FA9271 VA: 0x2FA9170
	|-Array.InternalArray__set_Item<CinemachineStateDrivenCamera.ParentHash>
	|
	|-RVA: 0x2FA92F0 Offset: 0x2FA93F1 VA: 0x2FA92F0
	|-Array.InternalArray__set_Item<CinemachineTargetGroup.Target>
	|
	|-RVA: 0x2FA9470 Offset: 0x2FA9571 VA: 0x2FA9470
	|-Array.InternalArray__set_Item<CodePointIndexer.TableRange>
	|
	|-RVA: 0x2FA9610 Offset: 0x2FA9711 VA: 0x2FA9610
	|-Array.InternalArray__set_Item<ContentCatalogData.Bucket>
	|
	|-RVA: 0x2FA9790 Offset: 0x2FA9891 VA: 0x2FA9790
	|-Array.InternalArray__set_Item<CookieTokenizer.RecognizedAttribute>
	|
	|-RVA: 0x2FA9910 Offset: 0x2FA9A11 VA: 0x2FA9910
	|-Array.InternalArray__set_Item<DeferredLights.DrawCall>
	|
	|-RVA: 0x2FA9AC0 Offset: 0x2FA9BC1 VA: 0x2FA9AC0
	|-Array.InternalArray__set_Item<DeferredShaderData.ComputeBufferInfo>
	|
	|-RVA: 0x2FA9C40 Offset: 0x2FA9D41 VA: 0x2FA9C40
	|-Array.InternalArray__set_Item<DeferredTiler.PrePunctualLight>
	|
	|-RVA: 0x2FA9DE0 Offset: 0x2FA9EE1 VA: 0x2FA9DE0
	|-Array.InternalArray__set_Item<DelayedActionManager.DelegateInfo>
	|
	|-RVA: 0x2FA9F80 Offset: 0x2FAA081 VA: 0x2FA9F80
	|-Array.InternalArray__set_Item<Detail.AsyncResultInt>
	|
	|-RVA: 0x2FAA130 Offset: 0x2FAA231 VA: 0x2FAA130
	|-Array.InternalArray__set_Item<Detail.CppArray>
	|
	|-RVA: 0x2FAA2B0 Offset: 0x2FAA3B1 VA: 0x2FAA2B0
	|-Array.InternalArray__set_Item<Detail.NotificationEventInt>
	|
	|-RVA: 0x2FAA460 Offset: 0x2FAA561 VA: 0x2FAA460
	|-Array.InternalArray__set_Item<DisposUnit.Item>
	|
	|-RVA: 0x2FAA5E0 Offset: 0x2FAA6E1 VA: 0x2FAA5E0
	|-Array.InternalArray__set_Item<DragonRidePresetParamData.CourseData>
	|
	|-RVA: 0x2FAA770 Offset: 0x2FAA871 VA: 0x2FAA770
	|-Array.InternalArray__set_Item<DragonRideTargetGroup.ChainParam>
	|
	|-RVA: 0x2FAA8F0 Offset: 0x2FAA9F1 VA: 0x2FAA8F0
	|-Array.InternalArray__set_Item<DynamicMesh.State>
	|
	|-RVA: 0x2FAAA70 Offset: 0x2FAAB71 VA: 0x2FAAA70
	|-Array.InternalArray__set_Item<FXZEx.HitPoint>
	|
	|-RVA: 0x2FAAC20 Offset: 0x2FAAD21 VA: 0x2FAAC20
	|-Array.InternalArray__set_Item<FishingRadicalParamData.RadicalParam>
	|
	|-RVA: 0x2FAADB0 Offset: 0x2FAAEB1 VA: 0x2FAADB0
	|-Array.InternalArray__set_Item<GameVariable.Value>
	|
	|-RVA: 0x2FAAF30 Offset: 0x2FAB031 VA: 0x2FAAF30
	|-Array.InternalArray__set_Item<GmapPathAdjuster.TargetModel>
	|
	|-RVA: 0x2FAB0D0 Offset: 0x2FAB1D1 VA: 0x2FAB0D0
	|-Array.InternalArray__set_Item<GmapSpotAdjuster.TargetModel>
	|
	|-RVA: 0x2FAB270 Offset: 0x2FAB371 VA: 0x2FAB270
	|-Array.InternalArray__set_Item<GrounderQuadruped.Foot>
	|
	|-RVA: 0x2FAB420 Offset: 0x2FAB521 VA: 0x2FAB420
	|-Array.InternalArray__set_Item<Hashtable.bucket>
	|
	|-RVA: 0x2FAB5C0 Offset: 0x2FAB6C1 VA: 0x2FAB5C0
	|-Array.InternalArray__set_Item<HeadingTracker.Item>
	|
	|-RVA: 0x2FAB760 Offset: 0x2FAB861 VA: 0x2FAB760
	|-Array.InternalArray__set_Item<HubAccessoryRoomCamera.BackgroundSettings>
	|
	|-RVA: 0x2FAB910 Offset: 0x2FABA11 VA: 0x2FAB910
	|-Array.InternalArray__set_Item<HubFastTravel.Location>
	|
	|-RVA: 0x2FABAB0 Offset: 0x2FABBB1 VA: 0x2FABAB0
	|-Array.InternalArray__set_Item<HubLensFlare.Flare>
	|
	|-RVA: 0x2FABC60 Offset: 0x2FABD61 VA: 0x2FABC60
	|-Array.InternalArray__set_Item<HubLookAtController.LookAtIKParam>
	|
	|-RVA: 0x2FABDF0 Offset: 0x2FABEF1 VA: 0x2FABDF0
	|-Array.InternalArray__set_Item<HubMaterialArray.MaterialInfo>
	|
	|-RVA: 0x2FABF70 Offset: 0x2FAC071 VA: 0x2FABF70
	|-Array.InternalArray__set_Item<IKSolverLimb.AxisDirection>
	|
	|-RVA: 0x2FAC120 Offset: 0x2FAC221 VA: 0x2FAC120
	|-Array.InternalArray__set_Item<InventoryPoolItemMenuContent.KindBgNameClass>
	|
	|-RVA: 0x2FAC2A0 Offset: 0x2FAC3A1 VA: 0x2FAC2A0
	|-Array.InternalArray__set_Item<LightUtility.ParametricLightMeshVertex>
	|
	|-RVA: 0x2FAC450 Offset: 0x2FAC551 VA: 0x2FAC450
	|-Array.InternalArray__set_Item<LightUtility.SpriteLightMeshVertex>
	|
	|-RVA: 0x2FAC600 Offset: 0x2FAC701 VA: 0x2FAC600
	|-Array.InternalArray__set_Item<Map.Pos>
	|
	|-RVA: 0x2FAC780 Offset: 0x2FAC881 VA: 0x2FAC780
	|-Array.InternalArray__set_Item<MapGodExp.KindDesc>
	|
	|-RVA: 0x2FAC900 Offset: 0x2FACA01 VA: 0x2FAC900
	|-Array.InternalArray__set_Item<MapHistory.Command>
	|
	|-RVA: 0x2FACA80 Offset: 0x2FACB81 VA: 0x2FACA80
	|-Array.InternalArray__set_Item<MapImage.BackupTerrain>
	|
	|-RVA: 0x2FACC00 Offset: 0x2FACD01 VA: 0x2FACC00
	|-Array.InternalArray__set_Item<MapImageRange.Pos>
	|
	|-RVA: 0x2FACD80 Offset: 0x2FACE81 VA: 0x2FACD80
	|-Array.InternalArray__set_Item<MapKillBonus.KillBonus>
	|
	|-RVA: 0x2FACF00 Offset: 0x2FAD001 VA: 0x2FACF00
	|-Array.InternalArray__set_Item<MapKillBonus.KilledBonus>
	|
	|-RVA: 0x2FAD080 Offset: 0x2FAD181 VA: 0x2FAD080
	|-Array.InternalArray__set_Item<MapMind.Record>
	|
	|-RVA: 0x2FAD240 Offset: 0x2FAD341 VA: 0x2FAD240
	|-Array.InternalArray__set_Item<MapMind.Target>
	|
	|-RVA: 0x2FAD3E0 Offset: 0x2FAD4E1 VA: 0x2FAD3E0
	|-Array.InternalArray__set_Item<MapPanelDebug.Entity>
	|
	|-RVA: 0x2FAD580 Offset: 0x2FAD681 VA: 0x2FAD580
	|-Array.InternalArray__set_Item<NexRanking.Data>
	|
	|-RVA: 0x2FAD700 Offset: 0x2FAD801 VA: 0x2FAD700
	|-Array.InternalArray__set_Item<NexVersus.RatingData>
	|
	|-RVA: 0x2FAD880 Offset: 0x2FAD981 VA: 0x2FAD880
	|-Array.InternalArray__set_Item<NoiseSettings.TransformNoiseParams>
	|
	|-RVA: 0x2FADA30 Offset: 0x2FADB31 VA: 0x2FADA30
	|-Array.InternalArray__set_Item<PackedPlayModeBuildLogs.RuntimeBuildLog>
	|
	|-RVA: 0x2FADBB0 Offset: 0x2FADCB1 VA: 0x2FADBB0
	|-Array.InternalArray__set_Item<ParameterizedStrings.FormatParam>
	|
	|-RVA: 0x2FADD30 Offset: 0x2FADE31 VA: 0x2FADD30
	|-Array.InternalArray__set_Item<ParticleSystem.Particle>
	|
	|-RVA: 0x2FADED0 Offset: 0x2FADFD1 VA: 0x2FADED0
	|-Array.InternalArray__set_Item<ProfileCard.Achievement>
	|
	|-RVA: 0x2FAE050 Offset: 0x2FAE151 VA: 0x2FAE050
	|-Array.InternalArray__set_Item<ProfileCard.SortieCount>
	|
	|-RVA: 0x2FAE1F0 Offset: 0x2FAE2F1 VA: 0x2FAE1F0
	|-Array.InternalArray__set_Item<QualitySettingsStack.Settings>
	|
	|-RVA: 0x2FAE3A0 Offset: 0x2FAE4A1 VA: 0x2FAE3A0
	|-Array.InternalArray__set_Item<RangeData.Offset>
	|
	|-RVA: 0x2FAE520 Offset: 0x2FAE621 VA: 0x2FAE520
	|-Array.InternalArray__set_Item<RegexCharClass.LowerCaseMapping>
	|
	|-RVA: 0x2FAE6B0 Offset: 0x2FAE7B1 VA: 0x2FAE6B0
	|-Array.InternalArray__set_Item<Relay.ChooseAwardeeData>
	|
	|-RVA: 0x2FAE850 Offset: 0x2FAE951 VA: 0x2FAE850
	|-Array.InternalArray__set_Item<RelayAwardData.Info>
	|
	|-RVA: 0x2FAE9D0 Offset: 0x2FAEAD1 VA: 0x2FAE9D0
	|-Array.InternalArray__set_Item<RenderGraph.CompiledPassInfo>
	|
	|-RVA: 0x2FAEB90 Offset: 0x2FAEC91 VA: 0x2FAEB90
	|-Array.InternalArray__set_Item<RenderGraph.CompiledResourceInfo>
	|
	|-RVA: 0x2FAED30 Offset: 0x2FAEE31 VA: 0x2FAED30
	|-Array.InternalArray__set_Item<RenderGraphDebugData.PassDebugData>
	|
	|-RVA: 0x2FAEED0 Offset: 0x2FAEFD1 VA: 0x2FAEED0
	|-Array.InternalArray__set_Item<RenderGraphDebugData.ResourceDebugData>
	|
	|-RVA: 0x2FAF080 Offset: 0x2FAF181 VA: 0x2FAF080
	|-Array.InternalArray__set_Item<RenderGraphResourceRegistry.RendererListResource>
	|
	|-RVA: 0x2FAF220 Offset: 0x2FAF321 VA: 0x2FAF220
	|-Array.InternalArray__set_Item<RingCleaningUnitSelectMenu.GodParam>
	|
	|-RVA: 0x2FAF3A0 Offset: 0x2FAF4A1 VA: 0x2FAF3A0
	|-Array.InternalArray__set_Item<SampleWave.Data>
	|
	|-RVA: 0x2FAF520 Offset: 0x2FAF621 VA: 0x2FAF520
	|-Array.InternalArray__set_Item<SampleWave.Temp>
	|
	|-RVA: 0x2FAF6A0 Offset: 0x2FAF7A1 VA: 0x2FAF6A0
	|-Array.InternalArray__set_Item<SendMouseEvents.HitInfo>
	|
	|-RVA: 0x2FAF820 Offset: 0x2FAF921 VA: 0x2FAF820
	|-Array.InternalArray__set_Item<SequenceNode.SequenceConstructPosContext>
	|
	|-RVA: 0x2FAF9D0 Offset: 0x2FAFAD1 VA: 0x2FAF9D0
	|-Array.InternalArray__set_Item<ShaderInput.LightData>
	|
	|-RVA: 0x2FAFB90 Offset: 0x2FAFC91 VA: 0x2FAFB90
	|-Array.InternalArray__set_Item<ShaderInput.ShadowData>
	|
	|-RVA: 0x2FAFD50 Offset: 0x2FAFE51 VA: 0x2FAFD50
	|-Array.InternalArray__set_Item<ShadowUtility.Edge>
	|
	|-RVA: 0x2FAFF00 Offset: 0x2FB0001 VA: 0x2FAFF00
	|-Array.InternalArray__set_Item<SimpleAnimationPlayable.QueuedState>
	|
	|-RVA: 0x2FB0080 Offset: 0x2FB0181 VA: 0x2FB0080
	|-Array.InternalArray__set_Item<SkillArray.Entity>
	|
	|-RVA: 0x2FB0200 Offset: 0x2FB0301 VA: 0x2FB0200
	|-Array.InternalArray__set_Item<Socket.WSABUF>
	|
	|-RVA: 0x2FB0380 Offset: 0x2FB0481 VA: 0x2FB0380
	|-Array.InternalArray__set_Item<Stream.Info>
	|
	|-RVA: 0x2FB0510 Offset: 0x2FB0611 VA: 0x2FB0510
	|-Array.InternalArray__set_Item<TMP_Text.UnicodeChar>
	|
	|-RVA: 0x2FB06A0 Offset: 0x2FB07A1 VA: 0x2FB06A0
	|-Array.InternalArray__set_Item<TexturePacker_JsonArray.Frame>
	|
	|-RVA: 0x2FB0850 Offset: 0x2FB0951 VA: 0x2FB0850
	|-Array.InternalArray__set_Item<TimeNotificationBehaviour.NotificationEntry>
	|
	|-RVA: 0x2FB09F0 Offset: 0x2FB0AF1 VA: 0x2FB09F0
	|-Array.InternalArray__set_Item<UnitySynchronizationContext.WorkRequest>
	|
	|-RVA: 0x2FB0B90 Offset: 0x2FB0C91 VA: 0x2FB0B90
	|-Array.InternalArray__set_Item<XmlNamespaceManager.NamespaceDeclaration>
	|
	|-RVA: 0x2FB0D30 Offset: 0x2FB0E31 VA: 0x2FB0D30
	|-Array.InternalArray__set_Item<XmlSchemaObjectTable.XmlSchemaObjectEntry>
	|
	|-RVA: 0x2FB0EB0 Offset: 0x2FB0FB1 VA: 0x2FB0EB0
	|-Array.InternalArray__set_Item<XmlTextReaderImpl.ParsingState>
	|
	|-RVA: 0x2FB1080 Offset: 0x2FB1181 VA: 0x2FB1080
	|-Array.InternalArray__set_Item<AIThink.EnchantThink.Desc>
	|
	|-RVA: 0x2FB1200 Offset: 0x2FB1301 VA: 0x2FB1200
	|-Array.InternalArray__set_Item<AIThink.EnchantThink.ItemInfo>
	|
	|-RVA: 0x2FB1380 Offset: 0x2FB1481 VA: 0x2FB1380
	|-Array.InternalArray__set_Item<AIThink.EnchantThink.SurroundingInfo>
	|
	|-RVA: 0x2FB1500 Offset: 0x2FB1601 VA: 0x2FB1500
	|-Array.InternalArray__set_Item<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>
	|
	|-RVA: 0x2FB1680 Offset: 0x2FB1781 VA: 0x2FB1680
	|-Array.InternalArray__set_Item<Detail.DataStore.DataStoreChangeMetaParamInt>
	|
	|-RVA: 0x2FB1820 Offset: 0x2FB1921 VA: 0x2FB1820
	|-Array.InternalArray__set_Item<Detail.DataStore.DataStoreDeleteParamInt>
	|
	|-RVA: 0x2FB19A0 Offset: 0x2FB1AA1 VA: 0x2FB19A0
	|-Array.InternalArray__set_Item<Detail.DataStore.DataStoreGetMetaParamInt>
	|
	|-RVA: 0x2FB1B50 Offset: 0x2FB1C51 VA: 0x2FB1B50
	|-Array.InternalArray__set_Item<Detail.DataStore.DataStoreMetaInfoInt>
	|
	|-RVA: 0x2FB1CF0 Offset: 0x2FB1DF1 VA: 0x2FB1CF0
	|-Array.InternalArray__set_Item<Detail.DataStore.DataStorePasswordInfoInt>
	|
	|-RVA: 0x2FB1E90 Offset: 0x2FB1F91 VA: 0x2FB1E90
	|-Array.InternalArray__set_Item<Detail.DataStore.DataStorePersistenceInfoInt>
	|
	|-RVA: 0x2FB2030 Offset: 0x2FB2131 VA: 0x2FB2030
	|-Array.InternalArray__set_Item<Detail.DataStore.DataStorePreparePostParamInt>
	|
	|-RVA: 0x2FB21D0 Offset: 0x2FB22D1 VA: 0x2FB21D0
	|-Array.InternalArray__set_Item<Detail.DataStore.DataStoreRateObjectParamInt>
	|
	|-RVA: 0x2FB2350 Offset: 0x2FB2451 VA: 0x2FB2350
	|-Array.InternalArray__set_Item<Detail.DataStore.DataStoreRatingInitParamInt>
	|
	|-RVA: 0x2FB24F0 Offset: 0x2FB25F1 VA: 0x2FB24F0
	|-Array.InternalArray__set_Item<Detail.DataStore.DataStoreRatingTargetInt>
	|
	|-RVA: 0x2FB2670 Offset: 0x2FB2771 VA: 0x2FB2670
	|-Array.InternalArray__set_Item<Detail.Ranking.RankingCachedResultInt>
	|
	|-RVA: 0x2FB2820 Offset: 0x2FB2921 VA: 0x2FB2820
	|-Array.InternalArray__set_Item<Detail.Ranking.RankingOrderParamInt>
	|
	|-RVA: 0x2FB29A0 Offset: 0x2FB2AA1 VA: 0x2FB29A0
	|-Array.InternalArray__set_Item<Detail.Ranking.RankingRankDataInt>
	|
	|-RVA: 0x2FB2B50 Offset: 0x2FB2C51 VA: 0x2FB2B50
	|-Array.InternalArray__set_Item<Detail.Ranking2.Ranking2ChartInfoInt>
	|
	|-RVA: 0x2FB2D10 Offset: 0x2FB2E11 VA: 0x2FB2D10
	|-Array.InternalArray__set_Item<Detail.Ranking2.Ranking2RankDataInt>
	|
	|-RVA: 0x2FB2EC0 Offset: 0x2FB2FC1 VA: 0x2FB2EC0
	|-Array.InternalArray__set_Item<Detail.Ranking2.Ranking2ScoreDataInt>
	|
	|-RVA: 0x2FB3040 Offset: 0x2FB3141 VA: 0x2FB3040
	|-Array.InternalArray__set_Item<Detail.Screening.ScreeningContextInfoInt>
	|
	|-RVA: 0x2FB31E0 Offset: 0x2FB32E1 VA: 0x2FB31E0
	|-Array.InternalArray__set_Item<Detail.Subscriber.SubscriberContentInt>
	|
	|-RVA: 0x2FB33A0 Offset: 0x2FB34A1 VA: 0x2FB33A0
	|-Array.InternalArray__set_Item<Detail.Subscriber.SubscriberGetContentParamInt>
	|
	|-RVA: 0x2FB3540 Offset: 0x2FB3641 VA: 0x2FB3540
	|-Array.InternalArray__set_Item<Detail.Subscriber.SubscriberUserStatusInfoInt>
	|
	|-RVA: 0x2FB36F0 Offset: 0x2FB37F1 VA: 0x2FB36F0
	|-Array.InternalArray__set_Item<Detail.Subscriber.SubscriberUserStatusParamInt>
	|
	|-RVA: 0x2FB3890 Offset: 0x2FB3991 VA: 0x2FB3890
	|-Array.InternalArray__set_Item<Detail.Utility.IntegerSettings>
	|
	|-RVA: 0x2FB3A10 Offset: 0x2FB3B11 VA: 0x2FB3A10
	|-Array.InternalArray__set_Item<Detail.Utility.UniqueIdInfoInt>
	|
	|-RVA: 0x2FB3B90 Offset: 0x2FB3C91 VA: 0x2FB3B90
	|-Array.InternalArray__set_Item<FacetsChecker.FacetsCompiler.Map>
	|
	|-RVA: 0x2FB3D10 Offset: 0x2FB3E11 VA: 0x2FB3D10
	|-Array.InternalArray__set_Item<MapHistory.ReplayAppearanceMap.Appearance>
	|
	|-RVA: 0x2FB3EB0 Offset: 0x2FB3FB1 VA: 0x2FB3EB0
	|-Array.InternalArray__set_Item<MapHistory.ReplayAppearanceMap.Leaving>
	|
	|-RVA: 0x2FB4030 Offset: 0x2FB4131 VA: 0x2FB4030
	|-Array.InternalArray__set_Item<MapHistory.ReplayUnitMap.Data>
	|
	|-RVA: 0x2FB41B0 Offset: 0x2FB42B1 VA: 0x2FB41B0
	|-Array.InternalArray__set_Item<MapHistory.Rewind.LatestInspectorData>
	|
	|-RVA: 0x2FB4340 Offset: 0x2FB4441 VA: 0x2FB4340
	|-Array.InternalArray__set_Item<MapHistory.Rewind.WorkTerrainData>
	|
	|-RVA: 0x2FB44D0 Offset: 0x2FB45D1 VA: 0x2FB44D0
	|-Array.InternalArray__set_Item<MapHistory.RewindUnitMap.Data>
	|
	|-RVA: 0x2FB4680 Offset: 0x2FB4781 VA: 0x2FB4680
	|-Array.InternalArray__set_Item<MapKillBonus.Work.Pos>
	|
	|-RVA: 0x2FB4800 Offset: 0x2FB4901 VA: 0x2FB4800
	|-Array.InternalArray__set_Item<MapSkill.AroundCalculator.Result>
	|
	|-RVA: 0x2FB4980 Offset: 0x2FB4A81 VA: 0x2FB4980
	|-Array.InternalArray__set_Item<Nex.ApiCallChecker.Guideline>
	|
	|-RVA: 0x2FB4B00 Offset: 0x2FB4C01 VA: 0x2FB4B00
	|-Array.InternalArray__set_Item<Ngc.MaskTextSequenceBase.Data>
	|
	|-RVA: 0x2FB4CA0 Offset: 0x2FB4DA1 VA: 0x2FB4CA0
	|-Array.InternalArray__set_Item<TargetPositionCache.CacheCurve.Item>
	|
	|-RVA: 0x2FB4E50 Offset: 0x2FB4F51 VA: 0x2FB4E50
	|-Array.InternalArray__set_Item<TargetPositionCache.CacheEntry.RecordingItem>
	|
	|-RVA: 0x2FB5000 Offset: 0x2FB5101 VA: 0x2FB5000
	|-Array.InternalArray__set_Item<TerrainUtility.TerrainMap.TileCoord>
	*/

	// RVA: -1 Offset: -1
	internal void GetGenericValueImpl<T>(int pos, out T value) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Array.GetGenericValueImpl<object>
	*/

	// RVA: -1 Offset: -1
	internal void SetGenericValueImpl<T>(int pos, ref T value) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Array.SetGenericValueImpl<object>
	*/

	[ReliabilityContractAttribute] // RVA: 0x4794E0 Offset: 0x4795E1 VA: 0x4794E0
	// RVA: 0x35601F0 Offset: 0x35602F1 VA: 0x35601F0
	public int get_Length() { }

	[ReliabilityContractAttribute] // RVA: 0x479500 Offset: 0x479601 VA: 0x479500
	// RVA: 0x35609B0 Offset: 0x3560AB1 VA: 0x35609B0
	public int get_Rank() { }

	// RVA: 0x3564180 Offset: 0x3564281 VA: 0x3564180
	private int GetRank() { }

	// RVA: 0x3561F00 Offset: 0x3562001 VA: 0x3561F00
	public int GetLength(int dimension) { }

	[ReliabilityContractAttribute] // RVA: 0x479520 Offset: 0x479621 VA: 0x479520
	// RVA: 0x3560770 Offset: 0x3560871 VA: 0x3560770
	public int GetLowerBound(int dimension) { }

	// RVA: 0x35623F0 Offset: 0x35624F1 VA: 0x35623F0
	public object GetValue(int[] indices) { }

	// RVA: 0x3563780 Offset: 0x3563881 VA: 0x3563780
	public void SetValue(object value, int[] indices) { }

	// RVA: 0x3564190 Offset: 0x3564291 VA: 0x3564190
	internal object GetValueImpl(int pos) { }

	// RVA: 0x35641A0 Offset: 0x35642A1 VA: 0x35641A0
	internal void SetValueImpl(object value, int pos) { }

	// RVA: 0x35641B0 Offset: 0x35642B1 VA: 0x35641B0
	internal static bool FastCopy(Array source, int source_idx, Array dest, int dest_idx, int length) { }

	// RVA: 0x35641C0 Offset: 0x35642C1 VA: 0x35641C0
	internal static Array CreateInstanceImpl(Type elementType, int[] lengths, int[] bounds) { }

	[ReliabilityContractAttribute] // RVA: 0x479540 Offset: 0x479641 VA: 0x479540
	// RVA: 0x35641D0 Offset: 0x35642D1 VA: 0x35641D0
	public int GetUpperBound(int dimension) { }

	// RVA: 0x3560280 Offset: 0x3560381 VA: 0x3560280
	public object GetValue(int index) { }

	// RVA: 0x3562040 Offset: 0x3562141 VA: 0x3562040
	public object GetValue(int index1, int index2) { }

	// RVA: 0x35621B0 Offset: 0x35622B1 VA: 0x35621B0
	public object GetValue(int index1, int index2, int index3) { }

	// RVA: 0x3560400 Offset: 0x3560501 VA: 0x3560400
	public void SetValue(object value, int index) { }

	// RVA: 0x35633B0 Offset: 0x35634B1 VA: 0x35633B0
	public void SetValue(object value, int index1, int index2) { }

	// RVA: 0x3563520 Offset: 0x3563621 VA: 0x3563520
	public void SetValue(object value, int index1, int index2, int index3) { }

	// RVA: 0x3564220 Offset: 0x3564321 VA: 0x3564220
	internal static Array UnsafeCreateInstance(Type elementType, int[] lengths, int[] lowerBounds) { }

	// RVA: 0x3564630 Offset: 0x3564731 VA: 0x3564630
	internal static Array UnsafeCreateInstance(Type elementType, int length1, int length2) { }

	// RVA: 0x35646E0 Offset: 0x35647E1 VA: 0x35646E0
	internal static Array UnsafeCreateInstance(Type elementType, int[] lengths) { }

	// RVA: 0x35646F0 Offset: 0x35647F1 VA: 0x35646F0
	public static Array CreateInstance(Type elementType, int length) { }

	// RVA: 0x3564640 Offset: 0x3564741 VA: 0x3564640
	public static Array CreateInstance(Type elementType, int length1, int length2) { }

	// RVA: 0x3564770 Offset: 0x3564871 VA: 0x3564770
	public static Array CreateInstance(Type elementType, int length1, int length2, int length3) { }

	// RVA: 0x355FEC0 Offset: 0x355FFC1 VA: 0x355FEC0
	public static Array CreateInstance(Type elementType, int[] lengths) { }

	// RVA: 0x3564230 Offset: 0x3564331 VA: 0x3564230
	public static Array CreateInstance(Type elementType, int[] lengths, int[] lowerBounds) { }

	[ReliabilityContractAttribute] // RVA: 0x479560 Offset: 0x479661 VA: 0x479560
	// RVA: 0x35542B0 Offset: 0x35543B1 VA: 0x35542B0
	public static void Clear(Array array, int index, int length) { }

	// RVA: 0x3564820 Offset: 0x3564921 VA: 0x3564820
	private static void ClearInternal(Array a, int index, int count) { }

	[ReliabilityContractAttribute] // RVA: 0x479580 Offset: 0x479681 VA: 0x479580
	// RVA: 0x3561C80 Offset: 0x3561D81 VA: 0x3561C80
	public static void Copy(Array sourceArray, Array destinationArray, int length) { }

	[ReliabilityContractAttribute] // RVA: 0x4795A0 Offset: 0x4796A1 VA: 0x4795A0
	// RVA: 0x35609C0 Offset: 0x3560AC1 VA: 0x35609C0
	public static void Copy(Array sourceArray, int sourceIndex, Array destinationArray, int destinationIndex, int length) { }

	// RVA: 0x3564830 Offset: 0x3564931 VA: 0x3564830
	private static Exception CreateArrayTypeMismatchException() { }

	// RVA: 0x35648E0 Offset: 0x35649E1 VA: 0x35648E0
	private static bool CanAssignArrayElement(Type source, Type target) { }

	[ReliabilityContractAttribute] // RVA: 0x4795C0 Offset: 0x4796C1 VA: 0x4795C0
	// RVA: 0x3564A30 Offset: 0x3564B31 VA: 0x3564A30
	public static void ConstrainedCopy(Array sourceArray, int sourceIndex, Array destinationArray, int destinationIndex, int length) { }

	// RVA: -1 Offset: -1
	public static T[] Empty<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x328C650 Offset: 0x328C751 VA: 0x328C650
	|-Array.Empty<TimeInterval<object>>
	|
	|-RVA: 0x328C700 Offset: 0x328C801 VA: 0x328C700
	|-Array.Empty<Timestamped<object>>
	|
	|-RVA: 0x328C7B0 Offset: 0x328C8B1 VA: 0x328C7B0
	|-Array.Empty<UniTask<object>>
	|
	|-RVA: 0x328C860 Offset: 0x328C961 VA: 0x328C860
	|-Array.Empty<ValueTuple<object, float>>
	|
	|-RVA: 0x328CD30 Offset: 0x328CE31 VA: 0x328CD30
	|-Array.Empty<string[]>
	|-Array.Empty<DynValue>
	|-Array.Empty<Expression>
	|-Array.Empty<GUILayoutOption>
	|-Array.Empty<IResourceLocation>
	|-Array.Empty<object>
	|-Array.Empty<ParameterExpression>
	|-Array.Empty<ParameterInfo>
	|-Array.Empty<string>
	|-Array.Empty<Type>
	|
	|-RVA: 0x328C910 Offset: 0x328CA11 VA: 0x328C910
	|-Array.Empty<AsyncOperationHandle>
	|
	|-RVA: 0x328C9C0 Offset: 0x328CAC1 VA: 0x328C9C0
	|-Array.Empty<char>
	|
	|-RVA: 0x328CA70 Offset: 0x328CB71 VA: 0x328CA70
	|-Array.Empty<Color>
	|
	|-RVA: 0x328CB20 Offset: 0x328CC21 VA: 0x328CB20
	|-Array.Empty<int>
	|
	|-RVA: 0x328CBD0 Offset: 0x328CCD1 VA: 0x328CBD0
	|-Array.Empty<Int32Enum>
	|
	|-RVA: 0x328CC80 Offset: 0x328CD81 VA: 0x328CC80
	|-Array.Empty<LocalDefinition>
	|
	|-RVA: 0x328CDE0 Offset: 0x328CEE1 VA: 0x328CDE0
	|-Array.Empty<RandomSeed>
	|
	|-RVA: 0x328CE90 Offset: 0x328CF91 VA: 0x328CE90
	|-Array.Empty<float>
	|
	|-RVA: 0x328CF40 Offset: 0x328D041 VA: 0x328CF40
	|-Array.Empty<uint>
	|
	|-RVA: 0x328CFF0 Offset: 0x328D0F1 VA: 0x328CFF0
	|-Array.Empty<UniTask>
	|
	|-RVA: 0x328D0A0 Offset: 0x328D1A1 VA: 0x328D0A0
	|-Array.Empty<DynamicMesh.State>
	|
	|-RVA: 0x328D150 Offset: 0x328D251 VA: 0x328D150
	|-Array.Empty<MapMind.Record>
	|
	|-RVA: 0x328D200 Offset: 0x328D301 VA: 0x328D200
	|-Array.Empty<QualitySettingsStack.Settings>
	|
	|-RVA: 0x328D2B0 Offset: 0x328D3B1 VA: 0x328D2B0
	|-Array.Empty<SequenceNode.SequenceConstructPosContext>
	|
	|-RVA: 0x328D360 Offset: 0x328D461 VA: 0x328D360
	|-Array.Empty<Stream.Info>
	*/

	// RVA: 0x3564A40 Offset: 0x3564B41 VA: 0x3564A40
	public void Initialize() { }

	// RVA: -1 Offset: -1
	private static int IndexOfImpl<T>(T[] array, T value, int startIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2111BF0 Offset: 0x2111CF1 VA: 0x2111BF0
	|-Array.IndexOfImpl<IntervalTree.Entry<object>>
	|
	|-RVA: 0x2111C80 Offset: 0x2111D81 VA: 0x2111C80
	|-Array.IndexOfImpl<KeyValuePair<DateTime, object>>
	|
	|-RVA: 0x2111CF0 Offset: 0x2111DF1 VA: 0x2111CF0
	|-Array.IndexOfImpl<KeyValuePair<int, object>>
	|
	|-RVA: 0x2111D60 Offset: 0x2111E61 VA: 0x2111D60
	|-Array.IndexOfImpl<KeyValuePair<object, ValueTuple<int, DateTime, object>>>
	|
	|-RVA: 0x2111DF0 Offset: 0x2111EF1 VA: 0x2111DF0
	|-Array.IndexOfImpl<KeyValuePair<object, object>>
	|
	|-RVA: 0x2111E60 Offset: 0x2111F61 VA: 0x2111E60
	|-Array.IndexOfImpl<CommonBattleSequence.Reliance<object>>
	|
	|-RVA: 0x2111EF0 Offset: 0x2111FF1 VA: 0x2111EF0
	|-Array.IndexOfImpl<RenderGraphResourcePool.ResourceLogInfo<object>>
	|
	|-RVA: 0x2111F60 Offset: 0x2112061 VA: 0x2111F60
	|-Array.IndexOfImpl<TimeInterval<object>>
	|
	|-RVA: 0x2111FD0 Offset: 0x21120D1 VA: 0x2111FD0
	|-Array.IndexOfImpl<Timestamped<object>>
	|
	|-RVA: 0x2112060 Offset: 0x2112161 VA: 0x2112060
	|-Array.IndexOfImpl<ValueTuple<int, object>>
	|
	|-RVA: 0x21120D0 Offset: 0x21121D1 VA: 0x21120D0
	|-Array.IndexOfImpl<ValueTuple<Int32Enum, int>>
	|
	|-RVA: 0x2112130 Offset: 0x2112231 VA: 0x2112130
	|-Array.IndexOfImpl<ValueTuple<object, ValueTuple<object, int>>>
	|
	|-RVA: 0x21121C0 Offset: 0x21122C1 VA: 0x21121C0
	|-Array.IndexOfImpl<ValueTuple<object, int>>
	|
	|-RVA: 0x2112230 Offset: 0x2112331 VA: 0x2112230
	|-Array.IndexOfImpl<ValueTuple<object, float>>
	|
	|-RVA: 0x21122A0 Offset: 0x21123A1 VA: 0x21122A0
	|-Array.IndexOfImpl<ValueTuple<Vector3, float>>
	|
	|-RVA: 0x2112320 Offset: 0x2112421 VA: 0x2112320
	|-Array.IndexOfImpl<ValueTuple<object, Int32Enum, int>>
	|
	|-RVA: 0x2112390 Offset: 0x2112491 VA: 0x2112390
	|-Array.IndexOfImpl<ValueTuple<object, int, int, int>>
	|
	|-RVA: 0x2112420 Offset: 0x2112521 VA: 0x2112420
	|-Array.IndexOfImpl<AnimatorClipInfo>
	|
	|-RVA: 0x2112480 Offset: 0x2112581 VA: 0x2112480
	|-Array.IndexOfImpl<AsyncOperationHandle>
	|
	|-RVA: 0x2112510 Offset: 0x2112611 VA: 0x2112510
	|-Array.IndexOfImpl<BoneWeight>
	|
	|-RVA: 0x21125A0 Offset: 0x21126A1 VA: 0x21125A0
	|-Array.IndexOfImpl<bool>
	|
	|-RVA: 0x2112600 Offset: 0x2112701 VA: 0x2112600
	|-Array.IndexOfImpl<byte>
	|
	|-RVA: 0x2112660 Offset: 0x2112761 VA: 0x2112660
	|-Array.IndexOfImpl<CameraInfo>
	|
	|-RVA: 0x21126D0 Offset: 0x21127D1 VA: 0x21126D0
	|-Array.IndexOfImpl<char>
	|
	|-RVA: 0x2112730 Offset: 0x2112831 VA: 0x2112730
	|-Array.IndexOfImpl<Color>
	|
	|-RVA: 0x21127B0 Offset: 0x21128B1 VA: 0x21127B0
	|-Array.IndexOfImpl<Color32>
	|
	|-RVA: 0x2112810 Offset: 0x2112911 VA: 0x2112810
	|-Array.IndexOfImpl<ConstraintSource>
	|
	|-RVA: 0x2112880 Offset: 0x2112981 VA: 0x2112880
	|-Array.IndexOfImpl<ContourVertex>
	|
	|-RVA: 0x2112910 Offset: 0x2112A11 VA: 0x2112910
	|-Array.IndexOfImpl<DataStoreRatingInfo>
	|
	|-RVA: 0x21129A0 Offset: 0x2112AA1 VA: 0x21129A0
	|-Array.IndexOfImpl<DataStoreResult>
	|
	|-RVA: 0x2112A00 Offset: 0x2112B01 VA: 0x2112A00
	|-Array.IndexOfImpl<DateTime>
	|
	|-RVA: 0x2112A60 Offset: 0x2112B61 VA: 0x2112A60
	|-Array.IndexOfImpl<DateTimeOffset>
	|
	|-RVA: 0x2112AD0 Offset: 0x2112BD1 VA: 0x2112AD0
	|-Array.IndexOfImpl<Decimal>
	|
	|-RVA: 0x2112B40 Offset: 0x2112C41 VA: 0x2112B40
	|-Array.IndexOfImpl<DiagnosticEvent>
	|
	|-RVA: 0x2112BE0 Offset: 0x2112CE1 VA: 0x2112BE0
	|-Array.IndexOfImpl<double>
	|
	|-RVA: 0x2112C40 Offset: 0x2112D41 VA: 0x2112C40
	|-Array.IndexOfImpl<Friend>
	|
	|-RVA: 0x2112CE0 Offset: 0x2112DE1 VA: 0x2112CE0
	|-Array.IndexOfImpl<GlyphRect>
	|
	|-RVA: 0x2112D50 Offset: 0x2112E51 VA: 0x2112D50
	|-Array.IndexOfImpl<short>
	|
	|-RVA: 0x2112DB0 Offset: 0x2112EB1 VA: 0x2112DB0
	|-Array.IndexOfImpl<int>
	|
	|-RVA: 0x2112E10 Offset: 0x2112F11 VA: 0x2112E10
	|-Array.IndexOfImpl<Int32Enum>
	|
	|-RVA: 0x2112E70 Offset: 0x2112F71 VA: 0x2112E70
	|-Array.IndexOfImpl<long>
	|
	|-RVA: 0x2112ED0 Offset: 0x2112FD1 VA: 0x2112ED0
	|-Array.IndexOfImpl<IntPtr>
	|
	|-RVA: 0x2112F30 Offset: 0x2113031 VA: 0x2112F30
	|-Array.IndexOfImpl<InterpretedFrameInfo>
	|
	|-RVA: 0x2112FA0 Offset: 0x21130A1 VA: 0x2112FA0
	|-Array.IndexOfImpl<IntervalTreeNode>
	|
	|-RVA: 0x2113030 Offset: 0x2113131 VA: 0x2113030
	|-Array.IndexOfImpl<LengthLimitProperties>
	|
	|-RVA: 0x2113090 Offset: 0x2113191 VA: 0x2113090
	|-Array.IndexOfImpl<MapPos>
	|
	|-RVA: 0x21130F0 Offset: 0x21131F1 VA: 0x21130F0
	|-Array.IndexOfImpl<Matrix4x4>
	|
	|-RVA: 0x21131A0 Offset: 0x21132A1 VA: 0x21131A0
	|-Array.IndexOfImpl<object>
	|
	|-RVA: 0x2113200 Offset: 0x2113301 VA: 0x2113200
	|-Array.IndexOfImpl<ObjectInitializationData>
	|
	|-RVA: 0x21132A0 Offset: 0x21133A1 VA: 0x21132A0
	|-Array.IndexOfImpl<PlayableBinding>
	|
	|-RVA: 0x2113330 Offset: 0x2113431 VA: 0x2113330
	|-Array.IndexOfImpl<PlayerLoopSystem>
	|
	|-RVA: 0x21133D0 Offset: 0x21134D1 VA: 0x21133D0
	|-Array.IndexOfImpl<PlayerLoopSystemInternal>
	|
	|-RVA: 0x2113470 Offset: 0x2113571 VA: 0x2113470
	|-Array.IndexOfImpl<RangePositionInfo>
	|
	|-RVA: 0x21134E0 Offset: 0x21135E1 VA: 0x21134E0
	|-Array.IndexOfImpl<Ranking2ChartInfoInput>
	|
	|-RVA: 0x2113540 Offset: 0x2113641 VA: 0x2113540
	|-Array.IndexOfImpl<RaycastHit2D>
	|
	|-RVA: 0x21135F0 Offset: 0x21136F1 VA: 0x21135F0
	|-Array.IndexOfImpl<RaycastResult>
	|
	|-RVA: 0x21136B0 Offset: 0x21137B1 VA: 0x21136B0
	|-Array.IndexOfImpl<Rect>
	|
	|-RVA: 0x2113730 Offset: 0x2113831 VA: 0x2113730
	|-Array.IndexOfImpl<RendererListHandle>
	|
	|-RVA: 0x2113790 Offset: 0x2113891 VA: 0x2113790
	|-Array.IndexOfImpl<ResourceHandle>
	|
	|-RVA: 0x21137F0 Offset: 0x21138F1 VA: 0x21137F0
	|-Array.IndexOfImpl<sbyte>
	|
	|-RVA: 0x2113850 Offset: 0x2113951 VA: 0x2113850
	|-Array.IndexOfImpl<ShaderTagId>
	|
	|-RVA: 0x21138B0 Offset: 0x21139B1 VA: 0x21138B0
	|-Array.IndexOfImpl<float>
	|
	|-RVA: 0x2113910 Offset: 0x2113A11 VA: 0x2113910
	|-Array.IndexOfImpl<SphericalHarmonicsL2>
	|
	|-RVA: 0x2113A00 Offset: 0x2113B01 VA: 0x2113A00
	|-Array.IndexOfImpl<SubMeshDescriptor>
	|
	|-RVA: 0x2113AA0 Offset: 0x2113BA1 VA: 0x2113AA0
	|-Array.IndexOfImpl<TablePair>
	|
	|-RVA: 0x2113B10 Offset: 0x2113C11 VA: 0x2113B10
	|-Array.IndexOfImpl<TimeSpan>
	|
	|-RVA: 0x2113B70 Offset: 0x2113C71 VA: 0x2113B70
	|-Array.IndexOfImpl<UICharInfo>
	|
	|-RVA: 0x2113BF0 Offset: 0x2113CF1 VA: 0x2113BF0
	|-Array.IndexOfImpl<UILineInfo>
	|
	|-RVA: 0x2113C60 Offset: 0x2113D61 VA: 0x2113C60
	|-Array.IndexOfImpl<UIVertex>
	|
	|-RVA: 0x2113D50 Offset: 0x2113E51 VA: 0x2113D50
	|-Array.IndexOfImpl<ushort>
	|
	|-RVA: 0x2113DB0 Offset: 0x2113EB1 VA: 0x2113DB0
	|-Array.IndexOfImpl<uint>
	|
	|-RVA: 0x2113E10 Offset: 0x2113F11 VA: 0x2113E10
	|-Array.IndexOfImpl<ulong>
	|
	|-RVA: 0x2113E70 Offset: 0x2113F71 VA: 0x2113E70
	|-Array.IndexOfImpl<Vector2>
	|
	|-RVA: 0x2113EE0 Offset: 0x2113FE1 VA: 0x2113EE0
	|-Array.IndexOfImpl<Vector3>
	|
	|-RVA: 0x2113F60 Offset: 0x2114061 VA: 0x2113F60
	|-Array.IndexOfImpl<Vector4>
	|
	|-RVA: 0x2113FE0 Offset: 0x21140E1 VA: 0x2113FE0
	|-Array.IndexOfImpl<VertexAttributeDescriptor>
	|
	|-RVA: 0x2114050 Offset: 0x2114151 VA: 0x2114050
	|-Array.IndexOfImpl<X509ChainStatus>
	|
	|-RVA: 0x21140C0 Offset: 0x21141C1 VA: 0x21140C0
	|-Array.IndexOfImpl<XRView>
	|
	|-RVA: 0x2114170 Offset: 0x2114271 VA: 0x2114170
	|-Array.IndexOfImpl<AmiiboSequence.GainItemData>
	|
	|-RVA: 0x21141E0 Offset: 0x21142E1 VA: 0x21141E0
	|-Array.IndexOfImpl<AnimationOutputWeightProcessor.WeightInfo>
	|
	|-RVA: 0x2114280 Offset: 0x2114381 VA: 0x2114280
	|-Array.IndexOfImpl<ArenaOrderSequence.GodInfo>
	|
	|-RVA: 0x21142F0 Offset: 0x21143F1 VA: 0x21142F0
	|-Array.IndexOfImpl<BattleInfo.SupportData>
	|
	|-RVA: 0x2114360 Offset: 0x2114461 VA: 0x2114360
	|-Array.IndexOfImpl<BeforeRenderHelper.OrderBlock>
	|
	|-RVA: 0x21143D0 Offset: 0x21144D1 VA: 0x21143D0
	|-Array.IndexOfImpl<Camera.RenderRequest>
	|
	|-RVA: 0x2114460 Offset: 0x2114561 VA: 0x2114460
	|-Array.IndexOfImpl<CameraState.CustomBlendable>
	|
	|-RVA: 0x21144D0 Offset: 0x21145D1 VA: 0x21144D0
	|-Array.IndexOfImpl<CinemachineClearShot.Pair>
	|
	|-RVA: 0x2114530 Offset: 0x2114631 VA: 0x2114530
	|-Array.IndexOfImpl<CinemachineStateDrivenCamera.HashPair>
	|
	|-RVA: 0x2114590 Offset: 0x2114691 VA: 0x2114590
	|-Array.IndexOfImpl<DelayedActionManager.DelegateInfo>
	|
	|-RVA: 0x2114620 Offset: 0x2114721 VA: 0x2114620
	|-Array.IndexOfImpl<Detail.AsyncResultInt>
	|
	|-RVA: 0x21146C0 Offset: 0x21147C1 VA: 0x21146C0
	|-Array.IndexOfImpl<Detail.CppArray>
	|
	|-RVA: 0x2114730 Offset: 0x2114831 VA: 0x2114730
	|-Array.IndexOfImpl<Detail.NotificationEventInt>
	|
	|-RVA: 0x21147D0 Offset: 0x21148D1 VA: 0x21147D0
	|-Array.IndexOfImpl<DragonRideTargetGroup.ChainParam>
	|
	|-RVA: 0x2114840 Offset: 0x2114941 VA: 0x2114840
	|-Array.IndexOfImpl<GmapPathAdjuster.TargetModel>
	|
	|-RVA: 0x21148D0 Offset: 0x21149D1 VA: 0x21148D0
	|-Array.IndexOfImpl<GmapSpotAdjuster.TargetModel>
	|
	|-RVA: 0x2114960 Offset: 0x2114A61 VA: 0x2114960
	|-Array.IndexOfImpl<HubFastTravel.Location>
	|
	|-RVA: 0x21149F0 Offset: 0x2114AF1 VA: 0x21149F0
	|-Array.IndexOfImpl<HubLensFlare.Flare>
	|
	|-RVA: 0x2114A90 Offset: 0x2114B91 VA: 0x2114A90
	|-Array.IndexOfImpl<InventoryPoolItemMenuContent.KindBgNameClass>
	|
	|-RVA: 0x2114B00 Offset: 0x2114C01 VA: 0x2114B00
	|-Array.IndexOfImpl<Map.Pos>
	|
	|-RVA: 0x2114B60 Offset: 0x2114C61 VA: 0x2114B60
	|-Array.IndexOfImpl<MapImage.BackupTerrain>
	|
	|-RVA: 0x2114BD0 Offset: 0x2114CD1 VA: 0x2114BD0
	|-Array.IndexOfImpl<MapImageRange.Pos>
	|
	|-RVA: 0x2114C30 Offset: 0x2114D31 VA: 0x2114C30
	|-Array.IndexOfImpl<MapMind.Target>
	|
	|-RVA: 0x2114CC0 Offset: 0x2114DC1 VA: 0x2114CC0
	|-Array.IndexOfImpl<MapPanelDebug.Entity>
	|
	|-RVA: 0x2114D50 Offset: 0x2114E51 VA: 0x2114D50
	|-Array.IndexOfImpl<NexRanking.Data>
	|
	|-RVA: 0x2114DB0 Offset: 0x2114EB1 VA: 0x2114DB0
	|-Array.IndexOfImpl<NexVersus.RatingData>
	|
	|-RVA: 0x2114E20 Offset: 0x2114F21 VA: 0x2114E20
	|-Array.IndexOfImpl<PackedPlayModeBuildLogs.RuntimeBuildLog>
	|
	|-RVA: 0x2114E90 Offset: 0x2114F91 VA: 0x2114E90
	|-Array.IndexOfImpl<ParticleSystem.Particle>
	|
	|-RVA: 0x2114F40 Offset: 0x2115041 VA: 0x2114F40
	|-Array.IndexOfImpl<RangeData.Offset>
	|
	|-RVA: 0x2114FA0 Offset: 0x21150A1 VA: 0x2114FA0
	|-Array.IndexOfImpl<RenderGraphDebugData.PassDebugData>
	|
	|-RVA: 0x2115030 Offset: 0x2115131 VA: 0x2115030
	|-Array.IndexOfImpl<RenderGraphDebugData.ResourceDebugData>
	|
	|-RVA: 0x21150D0 Offset: 0x21151D1 VA: 0x21150D0
	|-Array.IndexOfImpl<RingCleaningUnitSelectMenu.GodParam>
	|
	|-RVA: 0x2115140 Offset: 0x2115241 VA: 0x2115140
	|-Array.IndexOfImpl<ShadowUtility.Edge>
	|
	|-RVA: 0x21151E0 Offset: 0x21152E1 VA: 0x21151E0
	|-Array.IndexOfImpl<SkillArray.Entity>
	|
	|-RVA: 0x2115240 Offset: 0x2115341 VA: 0x2115240
	|-Array.IndexOfImpl<TexturePacker_JsonArray.Frame>
	|
	|-RVA: 0x21152F0 Offset: 0x21153F1 VA: 0x21152F0
	|-Array.IndexOfImpl<TimeNotificationBehaviour.NotificationEntry>
	|
	|-RVA: 0x2115380 Offset: 0x2115481 VA: 0x2115380
	|-Array.IndexOfImpl<UnitySynchronizationContext.WorkRequest>
	|
	|-RVA: 0x2115410 Offset: 0x2115511 VA: 0x2115410
	|-Array.IndexOfImpl<XmlSchemaObjectTable.XmlSchemaObjectEntry>
	|
	|-RVA: 0x2115480 Offset: 0x2115581 VA: 0x2115480
	|-Array.IndexOfImpl<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>
	|
	|-RVA: 0x21154F0 Offset: 0x21155F1 VA: 0x21154F0
	|-Array.IndexOfImpl<Detail.DataStore.DataStoreChangeMetaParamInt>
	|
	|-RVA: 0x2115590 Offset: 0x2115691 VA: 0x2115590
	|-Array.IndexOfImpl<Detail.DataStore.DataStoreDeleteParamInt>
	|
	|-RVA: 0x2115600 Offset: 0x2115701 VA: 0x2115600
	|-Array.IndexOfImpl<Detail.DataStore.DataStoreGetMetaParamInt>
	|
	|-RVA: 0x21156A0 Offset: 0x21157A1 VA: 0x21156A0
	|-Array.IndexOfImpl<Detail.DataStore.DataStoreMetaInfoInt>
	|
	|-RVA: 0x2115750 Offset: 0x2115851 VA: 0x2115750
	|-Array.IndexOfImpl<Detail.DataStore.DataStorePasswordInfoInt>
	|
	|-RVA: 0x21157E0 Offset: 0x21158E1 VA: 0x21157E0
	|-Array.IndexOfImpl<Detail.DataStore.DataStorePersistenceInfoInt>
	|
	|-RVA: 0x2115870 Offset: 0x2115971 VA: 0x2115870
	|-Array.IndexOfImpl<Detail.DataStore.DataStorePreparePostParamInt>
	|
	|-RVA: 0x2115920 Offset: 0x2115A21 VA: 0x2115920
	|-Array.IndexOfImpl<Detail.DataStore.DataStoreRateObjectParamInt>
	|
	|-RVA: 0x2115990 Offset: 0x2115A91 VA: 0x2115990
	|-Array.IndexOfImpl<Detail.DataStore.DataStoreRatingInitParamInt>
	|
	|-RVA: 0x2115A20 Offset: 0x2115B21 VA: 0x2115A20
	|-Array.IndexOfImpl<Detail.DataStore.DataStoreRatingTargetInt>
	|
	|-RVA: 0x2115A90 Offset: 0x2115B91 VA: 0x2115A90
	|-Array.IndexOfImpl<Detail.Ranking.RankingCachedResultInt>
	|
	|-RVA: 0x2115B40 Offset: 0x2115C41 VA: 0x2115B40
	|-Array.IndexOfImpl<Detail.Ranking.RankingOrderParamInt>
	|
	|-RVA: 0x2115BB0 Offset: 0x2115CB1 VA: 0x2115BB0
	|-Array.IndexOfImpl<Detail.Ranking.RankingRankDataInt>
	|
	|-RVA: 0x2115C60 Offset: 0x2115D61 VA: 0x2115C60
	|-Array.IndexOfImpl<Detail.Ranking2.Ranking2ChartInfoInt>
	|
	|-RVA: 0x2115D30 Offset: 0x2115E31 VA: 0x2115D30
	|-Array.IndexOfImpl<Detail.Ranking2.Ranking2RankDataInt>
	|
	|-RVA: 0x2115DE0 Offset: 0x2115EE1 VA: 0x2115DE0
	|-Array.IndexOfImpl<Detail.Ranking2.Ranking2ScoreDataInt>
	|
	|-RVA: 0x2115E50 Offset: 0x2115F51 VA: 0x2115E50
	|-Array.IndexOfImpl<Detail.Screening.ScreeningContextInfoInt>
	|
	|-RVA: 0x2115EE0 Offset: 0x2115FE1 VA: 0x2115EE0
	|-Array.IndexOfImpl<Detail.Subscriber.SubscriberContentInt>
	|
	|-RVA: 0x2115FA0 Offset: 0x21160A1 VA: 0x2115FA0
	|-Array.IndexOfImpl<Detail.Subscriber.SubscriberGetContentParamInt>
	|
	|-RVA: 0x2116030 Offset: 0x2116131 VA: 0x2116030
	|-Array.IndexOfImpl<Detail.Subscriber.SubscriberUserStatusInfoInt>
	|
	|-RVA: 0x21160D0 Offset: 0x21161D1 VA: 0x21160D0
	|-Array.IndexOfImpl<Detail.Subscriber.SubscriberUserStatusParamInt>
	|
	|-RVA: 0x2116160 Offset: 0x2116261 VA: 0x2116160
	|-Array.IndexOfImpl<Detail.Utility.IntegerSettings>
	|
	|-RVA: 0x21161C0 Offset: 0x21162C1 VA: 0x21161C0
	|-Array.IndexOfImpl<Detail.Utility.UniqueIdInfoInt>
	|
	|-RVA: 0x2116230 Offset: 0x2116331 VA: 0x2116230
	|-Array.IndexOfImpl<MapHistory.Rewind.LatestInspectorData>
	|
	|-RVA: 0x2116290 Offset: 0x2116391 VA: 0x2116290
	|-Array.IndexOfImpl<MapHistory.Rewind.WorkTerrainData>
	|
	|-RVA: 0x21162F0 Offset: 0x21163F1 VA: 0x21162F0
	|-Array.IndexOfImpl<MapSkill.AroundCalculator.Result>
	|
	|-RVA: 0x2116360 Offset: 0x2116461 VA: 0x2116360
	|-Array.IndexOfImpl<TargetPositionCache.CacheCurve.Item>
	|
	|-RVA: 0x2116400 Offset: 0x2116501 VA: 0x2116400
	|-Array.IndexOfImpl<TargetPositionCache.CacheEntry.RecordingItem>
	*/

	// RVA: -1 Offset: -1
	private static int LastIndexOfImpl<T>(T[] array, T value, int startIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FB69D0 Offset: 0x2FB6AD1 VA: 0x2FB69D0
	|-Array.LastIndexOfImpl<Color>
	|
	|-RVA: 0x2FB6A50 Offset: 0x2FB6B51 VA: 0x2FB6A50
	|-Array.LastIndexOfImpl<int>
	|
	|-RVA: 0x2FB6AB0 Offset: 0x2FB6BB1 VA: 0x2FB6AB0
	|-Array.LastIndexOfImpl<Int32Enum>
	|
	|-RVA: 0x2FB6B10 Offset: 0x2FB6C11 VA: 0x2FB6B10
	|-Array.LastIndexOfImpl<object>
	|
	|-RVA: 0x2FB6B70 Offset: 0x2FB6C71 VA: 0x2FB6B70
	|-Array.LastIndexOfImpl<RandomSeed>
	|
	|-RVA: 0x2FB6BE0 Offset: 0x2FB6CE1 VA: 0x2FB6BE0
	|-Array.LastIndexOfImpl<float>
	|
	|-RVA: 0x2FB6C40 Offset: 0x2FB6D41 VA: 0x2FB6C40
	|-Array.LastIndexOfImpl<uint>
	|
	|-RVA: 0x2FB6CA0 Offset: 0x2FB6DA1 VA: 0x2FB6CA0
	|-Array.LastIndexOfImpl<DynamicMesh.State>
	|
	|-RVA: 0x2FB6D00 Offset: 0x2FB6E01 VA: 0x2FB6D00
	|-Array.LastIndexOfImpl<MapMind.Record>
	|
	|-RVA: 0x2FB6DC0 Offset: 0x2FB6EC1 VA: 0x2FB6DC0
	|-Array.LastIndexOfImpl<QualitySettingsStack.Settings>
	|
	|-RVA: 0x2FB6E60 Offset: 0x2FB6F61 VA: 0x2FB6E60
	|-Array.LastIndexOfImpl<SequenceNode.SequenceConstructPosContext>
	|
	|-RVA: 0x2FB6F00 Offset: 0x2FB7001 VA: 0x2FB6F00
	|-Array.LastIndexOfImpl<Stream.Info>
	*/

	// RVA: 0x3563E40 Offset: 0x3563F41 VA: 0x3563E40
	private static void SortImpl(Array keys, Array items, int index, int length, IComparer comparer) { }

	// RVA: -1 Offset: -1
	internal static T UnsafeLoad<T>(T[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27307B0 Offset: 0x27308B1 VA: 0x27307B0
	|-Array.UnsafeLoad<IntervalTree.Entry<object>>
	|
	|-RVA: 0x27307F0 Offset: 0x27308F1 VA: 0x27307F0
	|-Array.UnsafeLoad<KeyValuePair<DateTime, object>>
	|
	|-RVA: 0x2730830 Offset: 0x2730931 VA: 0x2730830
	|-Array.UnsafeLoad<KeyValuePair<int, object>>
	|
	|-RVA: 0x2730870 Offset: 0x2730971 VA: 0x2730870
	|-Array.UnsafeLoad<KeyValuePair<object, ValueTuple<int, DateTime, object>>>
	|
	|-RVA: 0x27308B0 Offset: 0x27309B1 VA: 0x27308B0
	|-Array.UnsafeLoad<KeyValuePair<object, object>>
	|
	|-RVA: 0x27308F0 Offset: 0x27309F1 VA: 0x27308F0
	|-Array.UnsafeLoad<CommonBattleSequence.Reliance<object>>
	|
	|-RVA: 0x2730930 Offset: 0x2730A31 VA: 0x2730930
	|-Array.UnsafeLoad<RenderGraphResourcePool.ResourceLogInfo<object>>
	|
	|-RVA: 0x2730970 Offset: 0x2730A71 VA: 0x2730970
	|-Array.UnsafeLoad<ValueTuple<int, object>>
	|
	|-RVA: 0x27309B0 Offset: 0x2730AB1 VA: 0x27309B0
	|-Array.UnsafeLoad<ValueTuple<Int32Enum, int>>
	|
	|-RVA: 0x27309E0 Offset: 0x2730AE1 VA: 0x27309E0
	|-Array.UnsafeLoad<ValueTuple<object, ValueTuple<object, int>>>
	|
	|-RVA: 0x2730A20 Offset: 0x2730B21 VA: 0x2730A20
	|-Array.UnsafeLoad<ValueTuple<object, int>>
	|
	|-RVA: 0x2730A60 Offset: 0x2730B61 VA: 0x2730A60
	|-Array.UnsafeLoad<ValueTuple<Vector3, float>>
	|
	|-RVA: 0x2730AA0 Offset: 0x2730BA1 VA: 0x2730AA0
	|-Array.UnsafeLoad<ValueTuple<object, Int32Enum, int>>
	|
	|-RVA: 0x2730AE0 Offset: 0x2730BE1 VA: 0x2730AE0
	|-Array.UnsafeLoad<ValueTuple<object, int, int, int>>
	|
	|-RVA: 0x2730B20 Offset: 0x2730C21 VA: 0x2730B20
	|-Array.UnsafeLoad<AnimatorClipInfo>
	|
	|-RVA: 0x2730B50 Offset: 0x2730C51 VA: 0x2730B50
	|-Array.UnsafeLoad<AsyncOperationHandle>
	|
	|-RVA: 0x2730B90 Offset: 0x2730C91 VA: 0x2730B90
	|-Array.UnsafeLoad<BoneWeight>
	|
	|-RVA: 0x2730BD0 Offset: 0x2730CD1 VA: 0x2730BD0
	|-Array.UnsafeLoad<bool>
	|
	|-RVA: 0x2730C00 Offset: 0x2730D01 VA: 0x2730C00
	|-Array.UnsafeLoad<byte>
	|
	|-RVA: 0x2730C30 Offset: 0x2730D31 VA: 0x2730C30
	|-Array.UnsafeLoad<CameraInfo>
	|
	|-RVA: 0x2730C70 Offset: 0x2730D71 VA: 0x2730C70
	|-Array.UnsafeLoad<char>
	|
	|-RVA: 0x2730CA0 Offset: 0x2730DA1 VA: 0x2730CA0
	|-Array.UnsafeLoad<Color>
	|
	|-RVA: 0x2730CE0 Offset: 0x2730DE1 VA: 0x2730CE0
	|-Array.UnsafeLoad<Color32>
	|
	|-RVA: 0x2730D10 Offset: 0x2730E11 VA: 0x2730D10
	|-Array.UnsafeLoad<ConstraintSource>
	|
	|-RVA: 0x2730D50 Offset: 0x2730E51 VA: 0x2730D50
	|-Array.UnsafeLoad<ContourVertex>
	|
	|-RVA: 0x2730D90 Offset: 0x2730E91 VA: 0x2730D90
	|-Array.UnsafeLoad<DataStoreRatingInfo>
	|
	|-RVA: 0x2730DD0 Offset: 0x2730ED1 VA: 0x2730DD0
	|-Array.UnsafeLoad<DataStoreResult>
	|
	|-RVA: 0x2730E00 Offset: 0x2730F01 VA: 0x2730E00
	|-Array.UnsafeLoad<DateTime>
	|
	|-RVA: 0x2730E30 Offset: 0x2730F31 VA: 0x2730E30
	|-Array.UnsafeLoad<DateTimeOffset>
	|
	|-RVA: 0x2730E70 Offset: 0x2730F71 VA: 0x2730E70
	|-Array.UnsafeLoad<Decimal>
	|
	|-RVA: 0x2730EB0 Offset: 0x2730FB1 VA: 0x2730EB0
	|-Array.UnsafeLoad<DiagnosticEvent>
	|
	|-RVA: 0x2730F00 Offset: 0x2731001 VA: 0x2730F00
	|-Array.UnsafeLoad<double>
	|
	|-RVA: 0x2730F30 Offset: 0x2731031 VA: 0x2730F30
	|-Array.UnsafeLoad<Friend>
	|
	|-RVA: 0x2730F80 Offset: 0x2731081 VA: 0x2730F80
	|-Array.UnsafeLoad<GlyphRect>
	|
	|-RVA: 0x2730FC0 Offset: 0x27310C1 VA: 0x2730FC0
	|-Array.UnsafeLoad<short>
	|
	|-RVA: 0x2730FF0 Offset: 0x27310F1 VA: 0x2730FF0
	|-Array.UnsafeLoad<int>
	|
	|-RVA: 0x2731020 Offset: 0x2731121 VA: 0x2731020
	|-Array.UnsafeLoad<Int32Enum>
	|
	|-RVA: 0x2731050 Offset: 0x2731151 VA: 0x2731050
	|-Array.UnsafeLoad<long>
	|
	|-RVA: 0x2731080 Offset: 0x2731181 VA: 0x2731080
	|-Array.UnsafeLoad<IntPtr>
	|
	|-RVA: 0x27310B0 Offset: 0x27311B1 VA: 0x27310B0
	|-Array.UnsafeLoad<InterpretedFrameInfo>
	|
	|-RVA: 0x27310F0 Offset: 0x27311F1 VA: 0x27310F0
	|-Array.UnsafeLoad<IntervalTreeNode>
	|
	|-RVA: 0x2731130 Offset: 0x2731231 VA: 0x2731130
	|-Array.UnsafeLoad<LengthLimitProperties>
	|
	|-RVA: 0x2731160 Offset: 0x2731261 VA: 0x2731160
	|-Array.UnsafeLoad<MapPos>
	|
	|-RVA: 0x2731190 Offset: 0x2731291 VA: 0x2731190
	|-Array.UnsafeLoad<Matrix4x4>
	|
	|-RVA: 0x27311E0 Offset: 0x27312E1 VA: 0x27311E0
	|-Array.UnsafeLoad<object>
	|
	|-RVA: 0x2731210 Offset: 0x2731311 VA: 0x2731210
	|-Array.UnsafeLoad<ObjectInitializationData>
	|
	|-RVA: 0x2731260 Offset: 0x2731361 VA: 0x2731260
	|-Array.UnsafeLoad<PlayableBinding>
	|
	|-RVA: 0x27312A0 Offset: 0x27313A1 VA: 0x27312A0
	|-Array.UnsafeLoad<PlayerLoopSystem>
	|
	|-RVA: 0x27312F0 Offset: 0x27313F1 VA: 0x27312F0
	|-Array.UnsafeLoad<PlayerLoopSystemInternal>
	|
	|-RVA: 0x2731340 Offset: 0x2731441 VA: 0x2731340
	|-Array.UnsafeLoad<RangePositionInfo>
	|
	|-RVA: 0x2731380 Offset: 0x2731481 VA: 0x2731380
	|-Array.UnsafeLoad<Ranking2ChartInfoInput>
	|
	|-RVA: 0x27313B0 Offset: 0x27314B1 VA: 0x27313B0
	|-Array.UnsafeLoad<RaycastHit2D>
	|
	|-RVA: 0x2731400 Offset: 0x2731501 VA: 0x2731400
	|-Array.UnsafeLoad<RaycastResult>
	|
	|-RVA: 0x2731460 Offset: 0x2731561 VA: 0x2731460
	|-Array.UnsafeLoad<Rect>
	|
	|-RVA: 0x27314A0 Offset: 0x27315A1 VA: 0x27314A0
	|-Array.UnsafeLoad<RendererListHandle>
	|
	|-RVA: 0x27314D0 Offset: 0x27315D1 VA: 0x27314D0
	|-Array.UnsafeLoad<ResourceHandle>
	|
	|-RVA: 0x2731500 Offset: 0x2731601 VA: 0x2731500
	|-Array.UnsafeLoad<sbyte>
	|
	|-RVA: 0x2731530 Offset: 0x2731631 VA: 0x2731530
	|-Array.UnsafeLoad<ShaderTagId>
	|
	|-RVA: 0x2731560 Offset: 0x2731661 VA: 0x2731560
	|-Array.UnsafeLoad<float>
	|
	|-RVA: 0x2731590 Offset: 0x2731691 VA: 0x2731590
	|-Array.UnsafeLoad<SphericalHarmonicsL2>
	|
	|-RVA: 0x2731600 Offset: 0x2731701 VA: 0x2731600
	|-Array.UnsafeLoad<SubMeshDescriptor>
	|
	|-RVA: 0x2731650 Offset: 0x2731751 VA: 0x2731650
	|-Array.UnsafeLoad<TablePair>
	|
	|-RVA: 0x2731690 Offset: 0x2731791 VA: 0x2731690
	|-Array.UnsafeLoad<TimeSpan>
	|
	|-RVA: 0x27316C0 Offset: 0x27317C1 VA: 0x27316C0
	|-Array.UnsafeLoad<UICharInfo>
	|
	|-RVA: 0x2731700 Offset: 0x2731801 VA: 0x2731700
	|-Array.UnsafeLoad<UILineInfo>
	|
	|-RVA: 0x2731740 Offset: 0x2731841 VA: 0x2731740
	|-Array.UnsafeLoad<UIVertex>
	|
	|-RVA: 0x27317B0 Offset: 0x27318B1 VA: 0x27317B0
	|-Array.UnsafeLoad<ushort>
	|
	|-RVA: 0x27317E0 Offset: 0x27318E1 VA: 0x27317E0
	|-Array.UnsafeLoad<uint>
	|
	|-RVA: 0x2731810 Offset: 0x2731911 VA: 0x2731810
	|-Array.UnsafeLoad<ulong>
	|
	|-RVA: 0x2731840 Offset: 0x2731941 VA: 0x2731840
	|-Array.UnsafeLoad<Vector2>
	|
	|-RVA: 0x2731880 Offset: 0x2731981 VA: 0x2731880
	|-Array.UnsafeLoad<Vector3>
	|
	|-RVA: 0x27318C0 Offset: 0x27319C1 VA: 0x27318C0
	|-Array.UnsafeLoad<Vector4>
	|
	|-RVA: 0x2731900 Offset: 0x2731A01 VA: 0x2731900
	|-Array.UnsafeLoad<VertexAttributeDescriptor>
	|
	|-RVA: 0x2731940 Offset: 0x2731A41 VA: 0x2731940
	|-Array.UnsafeLoad<X509ChainStatus>
	|
	|-RVA: 0x2731980 Offset: 0x2731A81 VA: 0x2731980
	|-Array.UnsafeLoad<XRView>
	|
	|-RVA: 0x27319C0 Offset: 0x2731AC1 VA: 0x27319C0
	|-Array.UnsafeLoad<AmiiboSequence.GainItemData>
	|
	|-RVA: 0x2731A00 Offset: 0x2731B01 VA: 0x2731A00
	|-Array.UnsafeLoad<AnimationOutputWeightProcessor.WeightInfo>
	|
	|-RVA: 0x2731A50 Offset: 0x2731B51 VA: 0x2731A50
	|-Array.UnsafeLoad<ArenaOrderSequence.GodInfo>
	|
	|-RVA: 0x2731A90 Offset: 0x2731B91 VA: 0x2731A90
	|-Array.UnsafeLoad<BattleInfo.SupportData>
	|
	|-RVA: 0x2731AD0 Offset: 0x2731BD1 VA: 0x2731AD0
	|-Array.UnsafeLoad<BeforeRenderHelper.OrderBlock>
	|
	|-RVA: 0x2731B10 Offset: 0x2731C11 VA: 0x2731B10
	|-Array.UnsafeLoad<Camera.RenderRequest>
	|
	|-RVA: 0x2731B50 Offset: 0x2731C51 VA: 0x2731B50
	|-Array.UnsafeLoad<CameraState.CustomBlendable>
	|
	|-RVA: 0x2731B90 Offset: 0x2731C91 VA: 0x2731B90
	|-Array.UnsafeLoad<CinemachineClearShot.Pair>
	|
	|-RVA: 0x2731BC0 Offset: 0x2731CC1 VA: 0x2731BC0
	|-Array.UnsafeLoad<CinemachineStateDrivenCamera.HashPair>
	|
	|-RVA: 0x2731BF0 Offset: 0x2731CF1 VA: 0x2731BF0
	|-Array.UnsafeLoad<DelayedActionManager.DelegateInfo>
	|
	|-RVA: 0x2731C30 Offset: 0x2731D31 VA: 0x2731C30
	|-Array.UnsafeLoad<Detail.AsyncResultInt>
	|
	|-RVA: 0x2731C80 Offset: 0x2731D81 VA: 0x2731C80
	|-Array.UnsafeLoad<Detail.CppArray>
	|
	|-RVA: 0x2731CC0 Offset: 0x2731DC1 VA: 0x2731CC0
	|-Array.UnsafeLoad<Detail.NotificationEventInt>
	|
	|-RVA: 0x2731D10 Offset: 0x2731E11 VA: 0x2731D10
	|-Array.UnsafeLoad<DragonRideTargetGroup.ChainParam>
	|
	|-RVA: 0x2731D50 Offset: 0x2731E51 VA: 0x2731D50
	|-Array.UnsafeLoad<GmapPathAdjuster.TargetModel>
	|
	|-RVA: 0x2731D90 Offset: 0x2731E91 VA: 0x2731D90
	|-Array.UnsafeLoad<GmapSpotAdjuster.TargetModel>
	|
	|-RVA: 0x2731DD0 Offset: 0x2731ED1 VA: 0x2731DD0
	|-Array.UnsafeLoad<HubFastTravel.Location>
	|
	|-RVA: 0x2731E10 Offset: 0x2731F11 VA: 0x2731E10
	|-Array.UnsafeLoad<HubLensFlare.Flare>
	|
	|-RVA: 0x2731E60 Offset: 0x2731F61 VA: 0x2731E60
	|-Array.UnsafeLoad<InventoryPoolItemMenuContent.KindBgNameClass>
	|
	|-RVA: 0x2731EA0 Offset: 0x2731FA1 VA: 0x2731EA0
	|-Array.UnsafeLoad<Map.Pos>
	|
	|-RVA: 0x2731ED0 Offset: 0x2731FD1 VA: 0x2731ED0
	|-Array.UnsafeLoad<MapImage.BackupTerrain>
	|
	|-RVA: 0x2731F10 Offset: 0x2732011 VA: 0x2731F10
	|-Array.UnsafeLoad<MapImageRange.Pos>
	|
	|-RVA: 0x2731F40 Offset: 0x2732041 VA: 0x2731F40
	|-Array.UnsafeLoad<MapMind.Target>
	|
	|-RVA: 0x2731F80 Offset: 0x2732081 VA: 0x2731F80
	|-Array.UnsafeLoad<MapPanelDebug.Entity>
	|
	|-RVA: 0x2731FC0 Offset: 0x27320C1 VA: 0x2731FC0
	|-Array.UnsafeLoad<NexRanking.Data>
	|
	|-RVA: 0x2731FF0 Offset: 0x27320F1 VA: 0x2731FF0
	|-Array.UnsafeLoad<NexVersus.RatingData>
	|
	|-RVA: 0x2732030 Offset: 0x2732131 VA: 0x2732030
	|-Array.UnsafeLoad<PackedPlayModeBuildLogs.RuntimeBuildLog>
	|
	|-RVA: 0x2732070 Offset: 0x2732171 VA: 0x2732070
	|-Array.UnsafeLoad<ParticleSystem.Particle>
	|
	|-RVA: 0x27320B0 Offset: 0x27321B1 VA: 0x27320B0
	|-Array.UnsafeLoad<RangeData.Offset>
	|
	|-RVA: 0x27320E0 Offset: 0x27321E1 VA: 0x27320E0
	|-Array.UnsafeLoad<RenderGraphDebugData.PassDebugData>
	|
	|-RVA: 0x2732120 Offset: 0x2732221 VA: 0x2732120
	|-Array.UnsafeLoad<RenderGraphDebugData.ResourceDebugData>
	|
	|-RVA: 0x2732170 Offset: 0x2732271 VA: 0x2732170
	|-Array.UnsafeLoad<RingCleaningUnitSelectMenu.GodParam>
	|
	|-RVA: 0x27321B0 Offset: 0x27322B1 VA: 0x27321B0
	|-Array.UnsafeLoad<ShadowUtility.Edge>
	|
	|-RVA: 0x2732200 Offset: 0x2732301 VA: 0x2732200
	|-Array.UnsafeLoad<SkillArray.Entity>
	|
	|-RVA: 0x2732230 Offset: 0x2732331 VA: 0x2732230
	|-Array.UnsafeLoad<TexturePacker_JsonArray.Frame>
	|
	|-RVA: 0x2732280 Offset: 0x2732381 VA: 0x2732280
	|-Array.UnsafeLoad<TimeNotificationBehaviour.NotificationEntry>
	|
	|-RVA: 0x27322C0 Offset: 0x27323C1 VA: 0x27322C0
	|-Array.UnsafeLoad<UnitySynchronizationContext.WorkRequest>
	|
	|-RVA: 0x2732300 Offset: 0x2732401 VA: 0x2732300
	|-Array.UnsafeLoad<XmlSchemaObjectTable.XmlSchemaObjectEntry>
	|
	|-RVA: 0x2732340 Offset: 0x2732441 VA: 0x2732340
	|-Array.UnsafeLoad<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>
	|
	|-RVA: 0x2732380 Offset: 0x2732481 VA: 0x2732380
	|-Array.UnsafeLoad<Detail.DataStore.DataStoreChangeMetaParamInt>
	|
	|-RVA: 0x27323D0 Offset: 0x27324D1 VA: 0x27323D0
	|-Array.UnsafeLoad<Detail.DataStore.DataStoreDeleteParamInt>
	|
	|-RVA: 0x2732410 Offset: 0x2732511 VA: 0x2732410
	|-Array.UnsafeLoad<Detail.DataStore.DataStoreGetMetaParamInt>
	|
	|-RVA: 0x2732460 Offset: 0x2732561 VA: 0x2732460
	|-Array.UnsafeLoad<Detail.DataStore.DataStoreMetaInfoInt>
	|
	|-RVA: 0x27324A0 Offset: 0x27325A1 VA: 0x27324A0
	|-Array.UnsafeLoad<Detail.DataStore.DataStorePasswordInfoInt>
	|
	|-RVA: 0x27324E0 Offset: 0x27325E1 VA: 0x27324E0
	|-Array.UnsafeLoad<Detail.DataStore.DataStorePersistenceInfoInt>
	|
	|-RVA: 0x2732520 Offset: 0x2732621 VA: 0x2732520
	|-Array.UnsafeLoad<Detail.DataStore.DataStorePreparePostParamInt>
	|
	|-RVA: 0x2732560 Offset: 0x2732661 VA: 0x2732560
	|-Array.UnsafeLoad<Detail.DataStore.DataStoreRateObjectParamInt>
	|
	|-RVA: 0x27325A0 Offset: 0x27326A1 VA: 0x27325A0
	|-Array.UnsafeLoad<Detail.DataStore.DataStoreRatingInitParamInt>
	|
	|-RVA: 0x27325E0 Offset: 0x27326E1 VA: 0x27325E0
	|-Array.UnsafeLoad<Detail.DataStore.DataStoreRatingTargetInt>
	|
	|-RVA: 0x2732620 Offset: 0x2732721 VA: 0x2732620
	|-Array.UnsafeLoad<Detail.Ranking.RankingCachedResultInt>
	|
	|-RVA: 0x2732670 Offset: 0x2732771 VA: 0x2732670
	|-Array.UnsafeLoad<Detail.Ranking.RankingOrderParamInt>
	|
	|-RVA: 0x27326B0 Offset: 0x27327B1 VA: 0x27326B0
	|-Array.UnsafeLoad<Detail.Ranking.RankingRankDataInt>
	|
	|-RVA: 0x2732700 Offset: 0x2732801 VA: 0x2732700
	|-Array.UnsafeLoad<Detail.Ranking2.Ranking2ChartInfoInt>
	|
	|-RVA: 0x2732760 Offset: 0x2732861 VA: 0x2732760
	|-Array.UnsafeLoad<Detail.Ranking2.Ranking2RankDataInt>
	|
	|-RVA: 0x27327B0 Offset: 0x27328B1 VA: 0x27327B0
	|-Array.UnsafeLoad<Detail.Ranking2.Ranking2ScoreDataInt>
	|
	|-RVA: 0x27327F0 Offset: 0x27328F1 VA: 0x27327F0
	|-Array.UnsafeLoad<Detail.Screening.ScreeningContextInfoInt>
	|
	|-RVA: 0x2732830 Offset: 0x2732931 VA: 0x2732830
	|-Array.UnsafeLoad<Detail.Subscriber.SubscriberContentInt>
	|
	|-RVA: 0x2732890 Offset: 0x2732991 VA: 0x2732890
	|-Array.UnsafeLoad<Detail.Subscriber.SubscriberGetContentParamInt>
	|
	|-RVA: 0x27328D0 Offset: 0x27329D1 VA: 0x27328D0
	|-Array.UnsafeLoad<Detail.Subscriber.SubscriberUserStatusInfoInt>
	|
	|-RVA: 0x2732920 Offset: 0x2732A21 VA: 0x2732920
	|-Array.UnsafeLoad<Detail.Subscriber.SubscriberUserStatusParamInt>
	|
	|-RVA: 0x2732960 Offset: 0x2732A61 VA: 0x2732960
	|-Array.UnsafeLoad<Detail.Utility.IntegerSettings>
	|
	|-RVA: 0x2732990 Offset: 0x2732A91 VA: 0x2732990
	|-Array.UnsafeLoad<Detail.Utility.UniqueIdInfoInt>
	|
	|-RVA: 0x27329D0 Offset: 0x2732AD1 VA: 0x27329D0
	|-Array.UnsafeLoad<MapHistory.Rewind.LatestInspectorData>
	|
	|-RVA: 0x2732A10 Offset: 0x2732B11 VA: 0x2732A10
	|-Array.UnsafeLoad<MapHistory.Rewind.WorkTerrainData>
	|
	|-RVA: 0x2732A50 Offset: 0x2732B51 VA: 0x2732A50
	|-Array.UnsafeLoad<MapSkill.AroundCalculator.Result>
	|
	|-RVA: 0x2732A90 Offset: 0x2732B91 VA: 0x2732A90
	|-Array.UnsafeLoad<TargetPositionCache.CacheCurve.Item>
	|
	|-RVA: 0x2732AE0 Offset: 0x2732BE1 VA: 0x2732AE0
	|-Array.UnsafeLoad<TargetPositionCache.CacheEntry.RecordingItem>
	*/

	// RVA: -1 Offset: -1
	internal static void UnsafeStore<T>(T[] array, int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2732B60 Offset: 0x2732C61 VA: 0x2732B60
	|-Array.UnsafeStore<object>
	*/

	// RVA: -1 Offset: -1
	internal static R UnsafeMov<S, R>(S instance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2732B30 Offset: 0x2732C31 VA: 0x2732B30
	|-Array.UnsafeMov<Int32Enum, int>
	|
	|-RVA: 0x2732B40 Offset: 0x2732C41 VA: 0x2732B40
	|-Array.UnsafeMov<Int64Enum, long>
	|
	|-RVA: 0x2732B50 Offset: 0x2732C51 VA: 0x2732B50
	|-Array.UnsafeMov<object, object>
	*/
}

