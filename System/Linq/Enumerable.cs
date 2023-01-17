// Namespace: System.Linq
[ExtensionAttribute] // RVA: 0x3F7A0 Offset: 0x3F8A1 VA: 0x3F7A0
public static class Enumerable // TypeDefIndex: 2744
{
	// Methods

	[ExtensionAttribute] // RVA: 0x40CA0 Offset: 0x40DA1 VA: 0x40CA0
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> Where<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22AF5F0 Offset: 0x22AF6F1 VA: 0x22AF5F0
	|-Enumerable.Where<<>f__AnonymousType8<Type, Attribute[]>>
	|-Enumerable.Where<Component>
	|-Enumerable.Where<DynValue>
	|-Enumerable.Where<FieldInfo>
	|-Enumerable.Where<IOverloadableMemberDescriptor>
	|-Enumerable.Where<Mesh>
	|-Enumerable.Where<MethodInfo>
	|-Enumerable.Where<object>
	|-Enumerable.Where<SkinnedMeshRenderer>
	|-Enumerable.Where<SpringBone>
	|-Enumerable.Where<SpringCapsuleCollider>
	|-Enumerable.Where<SpringPanelCollider>
	|-Enumerable.Where<SpringSphereCollider>
	|-Enumerable.Where<string>
	|-Enumerable.Where<TasteData>
	|-Enumerable.Where<Toggle>
	|-Enumerable.Where<Transform>
	|-Enumerable.Where<Type>
	|-Enumerable.Where<TypedStringToValueMap>
	|-Enumerable.Where<AddressablesImpl.ResourceLocatorInfo>
	|-Enumerable.Where<AssetBundleBuildMap.AssetBundleEntry>
	|-Enumerable.Where<PlayerEditorConnectionEvents.MessageTypeSubscribers>
	|-Enumerable.Where<SpringBoneSerialization.LengthLimitSerializer>
	|-Enumerable.Where<SpringBoneSerialization.SpringBoneSerializer>
	|-Enumerable.Where<TextRecordParsing.Record>
	|
	|-RVA: 0x22AF390 Offset: 0x22AF491 VA: 0x22AF390
	|-Enumerable.Where<KeyValuePair<object, object>>
	|-Enumerable.Where<KeyValuePair<string, object>>
	|
	|-RVA: 0x22AF850 Offset: 0x22AF951 VA: 0x22AF850
	|-Enumerable.Where<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>
	*/

	[ExtensionAttribute] // RVA: 0x40CB0 Offset: 0x40DB1 VA: 0x40CB0
	// RVA: -1 Offset: -1
	public static IEnumerable<TResult> Select<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22AC300 Offset: 0x22AC401 VA: 0x22AC300
	|-Enumerable.Select<<>f__AnonymousType0<SpringBone, int>, SpringBone>
	|-Enumerable.Select<<>f__AnonymousType8<Type, Attribute[]>, <>f__AnonymousType9<Attribute[], Type>>
	|-Enumerable.Select<AnimationClip, string>
	|-Enumerable.Select<Component, string>
	|-Enumerable.Select<DynValue, DynValue>
	|-Enumerable.Select<DynValue, object>
	|-Enumerable.Select<DynValue, string>
	|-Enumerable.Select<DynamicExpression, WatchItem>
	|-Enumerable.Select<DynamicsNull, SpringColliderSerialization.TransformSerializer>
	|-Enumerable.Select<FieldInfo, VolumeParameter>
	|-Enumerable.Select<GUIContent, string>
	|-Enumerable.Select<Instruction, string>
	|-Enumerable.Select<MoonSharpHideMemberAttribute, string>
	|-Enumerable.Select<MoonSharpUserDataMetamethodAttribute, string>
	|-Enumerable.Select<object, object>
	|-Enumerable.Select<Object, Component>
	|-Enumerable.Select<ParameterDescriptor, string>
	|-Enumerable.Select<ParameterInfo, ParameterDescriptor>
	|-Enumerable.Select<ParameterInfo, string>
	|-Enumerable.Select<Processor, WatchItem>
	|-Enumerable.Select<SkinnedMeshRenderer, Mesh>
	|-Enumerable.Select<SpringBone, <>f__AnonymousType0<SpringBone, int>>
	|-Enumerable.Select<SpringBone, Transform>
	|-Enumerable.Select<SpringCapsuleCollider, string>
	|-Enumerable.Select<SpringCapsuleCollider, SpringColliderSerialization.CapsuleColliderSerializer>
	|-Enumerable.Select<SpringPanelCollider, string>
	|-Enumerable.Select<SpringPanelCollider, SpringColliderSerialization.PanelColliderSerializer>
	|-Enumerable.Select<SpringSphereCollider, string>
	|-Enumerable.Select<SpringSphereCollider, SpringColliderSerialization.SphereColliderSerializer>
	|-Enumerable.Select<string, GUIContent>
	|-Enumerable.Select<string, SpringCapsuleCollider>
	|-Enumerable.Select<string, SpringPanelCollider>
	|-Enumerable.Select<string, SpringSphereCollider>
	|-Enumerable.Select<string, string>
	|-Enumerable.Select<string, SymbolRef>
	|-Enumerable.Select<string, Transform>
	|-Enumerable.Select<SymbolRef, DynValue>
	|-Enumerable.Select<SymbolRef, string>
	|-Enumerable.Select<SymbolRef, SymbolRefExpression>
	|-Enumerable.Select<Transform, GameObject>
	|-Enumerable.Select<Transform, string>
	|-Enumerable.Select<Transform, SpringBoneSerialization.LengthLimitSerializer>
	|-Enumerable.Select<Transform, SpringBoneSerialization.PivotSerializer>
	|-Enumerable.Select<Type, <>f__AnonymousType8<Type, Attribute[]>>
	|-Enumerable.Select<Type, string>
	|-Enumerable.Select<AddressablesImpl.ResourceLocatorInfo, IResourceLocator>
	|-Enumerable.Select<AddressablesImpl.ResourceLocatorInfo, string>
	|-Enumerable.Select<AssetBundleBuildMap.AssetBundleEntry, string>
	|-Enumerable.Select<SpringBoneSerialization.LengthLimitSerializer, Transform>
	|-Enumerable.Select<SpringBoneSerialization.PivotSerializer, string>
	|-Enumerable.Select<SpringBoneSerialization.SpringBoneSerializer, string>
	|-Enumerable.Select<SpringColliderSerialization.IColliderSerializer, string>
	|-Enumerable.Select<SpringColliderSerialization.TransformSerializer, string>
	|
	|-RVA: 0x22AAC10 Offset: 0x22AAD11 VA: 0x22AAC10
	|-Enumerable.Select<KeyValuePair<object, object>, object>
	|-Enumerable.Select<KeyValuePair<string, object>, string>
	|-Enumerable.Select<KeyValuePair<Type, IUserDataDescriptor>, Type>
	|
	|-RVA: 0x22ABB10 Offset: 0x22ABC11 VA: 0x22ABB10
	|-Enumerable.Select<AsyncDebugger, KeyValuePair<int, string>>
	|-Enumerable.Select<object, KeyValuePair<int, object>>
	|
	|-RVA: 0x22AAE90 Offset: 0x22AAF91 VA: 0x22AAE90
	|-Enumerable.Select<ContourVertex, Color>
	|
	|-RVA: 0x22AB110 Offset: 0x22AB211 VA: 0x22AB110
	|-Enumerable.Select<ContourVertex, Vector3>
	|
	|-RVA: 0x22AB390 Offset: 0x22AB491 VA: 0x22AB390
	|-Enumerable.Select<ContourVertex, float3>
	|
	|-RVA: 0x22AC080 Offset: 0x22AC181 VA: 0x22AC080
	|-Enumerable.Select<DynValue, int>
	|-Enumerable.Select<object, int>
	|
	|-RVA: 0x22AB610 Offset: 0x22AB711 VA: 0x22AB610
	|-Enumerable.Select<int, int>
	|
	|-RVA: 0x22AB890 Offset: 0x22AB991 VA: 0x22AB890
	|-Enumerable.Select<int, object>
	|-Enumerable.Select<int, Transform>
	|
	|-RVA: 0x22ABD90 Offset: 0x22ABE91 VA: 0x22ABD90
	|-Enumerable.Select<object, UniTask<object>>
	|
	|-RVA: 0x22AC5F0 Offset: 0x22AC6F1 VA: 0x22AC5F0
	|-Enumerable.Select<object, UniTask>
	|
	|-RVA: 0x22AC8E0 Offset: 0x22AC9E1 VA: 0x22AC8E0
	|-Enumerable.Select<TablePair, DynValue>
	|-Enumerable.Select<TablePair, object>
	|
	|-RVA: 0x22ACB60 Offset: 0x22ACC61 VA: 0x22ACB60
	|-Enumerable.Select<TablePair, TablePair>
	|
	|-RVA: 0x22ACDE0 Offset: 0x22ACEE1 VA: 0x22ACDE0
	|-Enumerable.Select<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, object>
	|-Enumerable.Select<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, string>
	*/

	[ExtensionAttribute] // RVA: 0x40CC0 Offset: 0x40DC1 VA: 0x40CC0
	// RVA: -1 Offset: -1
	public static IEnumerable<TResult> Select<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, int, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22AC010 Offset: 0x22AC111 VA: 0x22AC010
	|-Enumerable.Select<object, UniTask<object>>
	|
	|-RVA: 0x22AC580 Offset: 0x22AC681 VA: 0x22AC580
	|-Enumerable.Select<object, object>
	|
	|-RVA: 0x22AC870 Offset: 0x22AC971 VA: 0x22AC870
	|-Enumerable.Select<object, UniTask>
	*/

	[IteratorStateMachineAttribute] // RVA: 0x40CD0 Offset: 0x40DD1 VA: 0x40CD0
	// RVA: -1 Offset: -1
	private static IEnumerable<TResult> SelectIterator<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, int, TResult> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22AD060 Offset: 0x22AD161 VA: 0x22AD060
	|-Enumerable.SelectIterator<object, UniTask<object>>
	|
	|-RVA: 0x22AD0F0 Offset: 0x22AD1F1 VA: 0x22AD0F0
	|-Enumerable.SelectIterator<object, object>
	|
	|-RVA: 0x22AD180 Offset: 0x22AD281 VA: 0x22AD180
	|-Enumerable.SelectIterator<object, UniTask>
	*/

	// RVA: -1 Offset: -1
	private static Func<TSource, bool> CombinePredicates<TSource>(Func<TSource, bool> predicate1, Func<TSource, bool> predicate2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22A2C80 Offset: 0x22A2D81 VA: 0x22A2C80
	|-Enumerable.CombinePredicates<KeyValuePair<int, object>>
	|
	|-RVA: 0x22A2D40 Offset: 0x22A2E41 VA: 0x22A2D40
	|-Enumerable.CombinePredicates<KeyValuePair<object, object>>
	|
	|-RVA: 0x22A2E00 Offset: 0x22A2F01 VA: 0x22A2E00
	|-Enumerable.CombinePredicates<UniTask<object>>
	|
	|-RVA: 0x22A2EC0 Offset: 0x22A2FC1 VA: 0x22A2EC0
	|-Enumerable.CombinePredicates<Color>
	|
	|-RVA: 0x22A2F80 Offset: 0x22A3081 VA: 0x22A2F80
	|-Enumerable.CombinePredicates<int>
	|
	|-RVA: 0x22A3040 Offset: 0x22A3141 VA: 0x22A3040
	|-Enumerable.CombinePredicates<object>
	|
	|-RVA: 0x22A3100 Offset: 0x22A3201 VA: 0x22A3100
	|-Enumerable.CombinePredicates<TablePair>
	|
	|-RVA: 0x22A31C0 Offset: 0x22A32C1 VA: 0x22A31C0
	|-Enumerable.CombinePredicates<UniTask>
	|
	|-RVA: 0x22A3280 Offset: 0x22A3381 VA: 0x22A3280
	|-Enumerable.CombinePredicates<Vector3>
	|
	|-RVA: 0x22A3340 Offset: 0x22A3441 VA: 0x22A3340
	|-Enumerable.CombinePredicates<float3>
	|
	|-RVA: 0x22A3400 Offset: 0x22A3501 VA: 0x22A3400
	|-Enumerable.CombinePredicates<AssetBundleBuildMap.AssetBundleEntry.AssetPathString>
	*/

	// RVA: -1 Offset: -1
	private static Func<TSource, TResult> CombineSelectors<TSource, TMiddle, TResult>(Func<TSource, TMiddle> selector1, Func<TMiddle, TResult> selector2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22A34C0 Offset: 0x22A35C1 VA: 0x22A34C0
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, KeyValuePair<int, object>, KeyValuePair<int, object>>
	|
	|-RVA: 0x22A3580 Offset: 0x22A3681 VA: 0x22A3580
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, UniTask<object>, UniTask<object>>
	|
	|-RVA: 0x22A3640 Offset: 0x22A3741 VA: 0x22A3640
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, int, int>
	|
	|-RVA: 0x22A3700 Offset: 0x22A3801 VA: 0x22A3700
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, object, KeyValuePair<int, object>>
	|
	|-RVA: 0x22A37C0 Offset: 0x22A38C1 VA: 0x22A37C0
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, object, UniTask<object>>
	|
	|-RVA: 0x22A3880 Offset: 0x22A3981 VA: 0x22A3880
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, object, int>
	|
	|-RVA: 0x22A3940 Offset: 0x22A3A41 VA: 0x22A3940
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, object, object>
	|
	|-RVA: 0x22A3A00 Offset: 0x22A3B01 VA: 0x22A3A00
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, object, UniTask>
	|
	|-RVA: 0x22A3AC0 Offset: 0x22A3BC1 VA: 0x22A3AC0
	|-Enumerable.CombineSelectors<KeyValuePair<object, object>, UniTask, UniTask>
	|
	|-RVA: 0x22A3B80 Offset: 0x22A3C81 VA: 0x22A3B80
	|-Enumerable.CombineSelectors<int, KeyValuePair<int, object>, KeyValuePair<int, object>>
	|
	|-RVA: 0x22A3C40 Offset: 0x22A3D41 VA: 0x22A3C40
	|-Enumerable.CombineSelectors<int, UniTask<object>, UniTask<object>>
	|
	|-RVA: 0x22A3D00 Offset: 0x22A3E01 VA: 0x22A3D00
	|-Enumerable.CombineSelectors<int, int, int>
	|
	|-RVA: 0x22A3DC0 Offset: 0x22A3EC1 VA: 0x22A3DC0
	|-Enumerable.CombineSelectors<int, int, object>
	|
	|-RVA: 0x22A3E80 Offset: 0x22A3F81 VA: 0x22A3E80
	|-Enumerable.CombineSelectors<int, object, KeyValuePair<int, object>>
	|
	|-RVA: 0x22A3F40 Offset: 0x22A4041 VA: 0x22A3F40
	|-Enumerable.CombineSelectors<int, object, UniTask<object>>
	|
	|-RVA: 0x22A4000 Offset: 0x22A4101 VA: 0x22A4000
	|-Enumerable.CombineSelectors<int, object, int>
	|
	|-RVA: 0x22A40C0 Offset: 0x22A41C1 VA: 0x22A40C0
	|-Enumerable.CombineSelectors<int, object, object>
	|
	|-RVA: 0x22A4180 Offset: 0x22A4281 VA: 0x22A4180
	|-Enumerable.CombineSelectors<int, object, UniTask>
	|
	|-RVA: 0x22A4240 Offset: 0x22A4341 VA: 0x22A4240
	|-Enumerable.CombineSelectors<int, UniTask, UniTask>
	|
	|-RVA: 0x22A4300 Offset: 0x22A4401 VA: 0x22A4300
	|-Enumerable.CombineSelectors<object, int, int>
	|
	|-RVA: 0x22A43C0 Offset: 0x22A44C1 VA: 0x22A43C0
	|-Enumerable.CombineSelectors<object, int, object>
	|
	|-RVA: 0x22A4480 Offset: 0x22A4581 VA: 0x22A4480
	|-Enumerable.CombineSelectors<object, object, KeyValuePair<int, object>>
	|
	|-RVA: 0x22A4540 Offset: 0x22A4641 VA: 0x22A4540
	|-Enumerable.CombineSelectors<object, object, UniTask<object>>
	|
	|-RVA: 0x22A4600 Offset: 0x22A4701 VA: 0x22A4600
	|-Enumerable.CombineSelectors<object, object, int>
	|
	|-RVA: 0x22A46C0 Offset: 0x22A47C1 VA: 0x22A46C0
	|-Enumerable.CombineSelectors<object, object, object>
	|
	|-RVA: 0x22A4780 Offset: 0x22A4881 VA: 0x22A4780
	|-Enumerable.CombineSelectors<object, object, UniTask>
	|
	|-RVA: 0x22A4840 Offset: 0x22A4941 VA: 0x22A4840
	|-Enumerable.CombineSelectors<TablePair, KeyValuePair<int, object>, KeyValuePair<int, object>>
	|
	|-RVA: 0x22A4900 Offset: 0x22A4A01 VA: 0x22A4900
	|-Enumerable.CombineSelectors<TablePair, UniTask<object>, UniTask<object>>
	|
	|-RVA: 0x22A49C0 Offset: 0x22A4AC1 VA: 0x22A49C0
	|-Enumerable.CombineSelectors<TablePair, int, int>
	|
	|-RVA: 0x22A4A80 Offset: 0x22A4B81 VA: 0x22A4A80
	|-Enumerable.CombineSelectors<TablePair, object, KeyValuePair<int, object>>
	|
	|-RVA: 0x22A4B40 Offset: 0x22A4C41 VA: 0x22A4B40
	|-Enumerable.CombineSelectors<TablePair, object, UniTask<object>>
	|
	|-RVA: 0x22A4C00 Offset: 0x22A4D01 VA: 0x22A4C00
	|-Enumerable.CombineSelectors<TablePair, object, int>
	|
	|-RVA: 0x22A4CC0 Offset: 0x22A4DC1 VA: 0x22A4CC0
	|-Enumerable.CombineSelectors<TablePair, object, object>
	|
	|-RVA: 0x22A4D80 Offset: 0x22A4E81 VA: 0x22A4D80
	|-Enumerable.CombineSelectors<TablePair, object, UniTask>
	|
	|-RVA: 0x22A4E40 Offset: 0x22A4F41 VA: 0x22A4E40
	|-Enumerable.CombineSelectors<TablePair, TablePair, object>
	|
	|-RVA: 0x22A4F00 Offset: 0x22A5001 VA: 0x22A4F00
	|-Enumerable.CombineSelectors<TablePair, TablePair, TablePair>
	|
	|-RVA: 0x22A4FC0 Offset: 0x22A50C1 VA: 0x22A4FC0
	|-Enumerable.CombineSelectors<TablePair, UniTask, UniTask>
	|
	|-RVA: 0x22A5080 Offset: 0x22A5181 VA: 0x22A5080
	|-Enumerable.CombineSelectors<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, KeyValuePair<int, object>, KeyValuePair<int, object>>
	|
	|-RVA: 0x22A5140 Offset: 0x22A5241 VA: 0x22A5140
	|-Enumerable.CombineSelectors<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, UniTask<object>, UniTask<object>>
	|
	|-RVA: 0x22A5200 Offset: 0x22A5301 VA: 0x22A5200
	|-Enumerable.CombineSelectors<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, int, int>
	|
	|-RVA: 0x22A52C0 Offset: 0x22A53C1 VA: 0x22A52C0
	|-Enumerable.CombineSelectors<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, object, KeyValuePair<int, object>>
	|
	|-RVA: 0x22A5380 Offset: 0x22A5481 VA: 0x22A5380
	|-Enumerable.CombineSelectors<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, object, UniTask<object>>
	|
	|-RVA: 0x22A5440 Offset: 0x22A5541 VA: 0x22A5440
	|-Enumerable.CombineSelectors<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, object, int>
	|
	|-RVA: 0x22A5500 Offset: 0x22A5601 VA: 0x22A5500
	|-Enumerable.CombineSelectors<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, object, object>
	|
	|-RVA: 0x22A55C0 Offset: 0x22A56C1 VA: 0x22A55C0
	|-Enumerable.CombineSelectors<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, object, UniTask>
	|
	|-RVA: 0x22A5680 Offset: 0x22A5781 VA: 0x22A5680
	|-Enumerable.CombineSelectors<AssetBundleBuildMap.AssetBundleEntry.AssetPathString, UniTask, UniTask>
	*/

	[ExtensionAttribute] // RVA: 0x40D40 Offset: 0x40E41 VA: 0x40D40
	// RVA: -1 Offset: -1
	public static IEnumerable<TResult> SelectMany<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22AD210 Offset: 0x22AD311 VA: 0x22AD210
	|-Enumerable.SelectMany<Assembly, Type>
	|-Enumerable.SelectMany<object, object>
	|-Enumerable.SelectMany<Type, Component>
	|-Enumerable.SelectMany<AssetBundleBuildMap.AssetBundleEntry, string>
	|
	|-RVA: 0x22AD280 Offset: 0x22AD381 VA: 0x22AD280
	|-Enumerable.SelectMany<object, AssetBundleBuildMap.AssetBundleEntry.AssetPathString>
	|-Enumerable.SelectMany<AssetBundleBuildMap.AssetBundleEntry, AssetBundleBuildMap.AssetBundleEntry.AssetPathString>
	*/

	[IteratorStateMachineAttribute] // RVA: 0x40D50 Offset: 0x40E51 VA: 0x40D50
	// RVA: -1 Offset: -1
	private static IEnumerable<TResult> SelectManyIterator<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, IEnumerable<TResult>> selector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22AD2F0 Offset: 0x22AD3F1 VA: 0x22AD2F0
	|-Enumerable.SelectManyIterator<object, object>
	|
	|-RVA: 0x22AD380 Offset: 0x22AD481 VA: 0x22AD380
	|-Enumerable.SelectManyIterator<object, AssetBundleBuildMap.AssetBundleEntry.AssetPathString>
	*/

	[ExtensionAttribute] // RVA: 0x40DC0 Offset: 0x40EC1 VA: 0x40DC0
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> TakeWhile<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22ADCE0 Offset: 0x22ADDE1 VA: 0x22ADCE0
	|-Enumerable.TakeWhile<object>
	|-Enumerable.TakeWhile<TextRecordParsing.Record>
	*/

	[IteratorStateMachineAttribute] // RVA: 0x40DD0 Offset: 0x40ED1 VA: 0x40DD0
	// RVA: -1 Offset: -1
	private static IEnumerable<TSource> TakeWhileIterator<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22ADD50 Offset: 0x22ADE51 VA: 0x22ADD50
	|-Enumerable.TakeWhileIterator<object>
	*/

	[ExtensionAttribute] // RVA: 0x40E40 Offset: 0x40F41 VA: 0x40E40
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> Skip<TSource>(IEnumerable<TSource> source, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22ADC00 Offset: 0x22ADD01 VA: 0x22ADC00
	|-Enumerable.Skip<object>
	|-Enumerable.Skip<string>
	|-Enumerable.Skip<WatchItem>
	|-Enumerable.Skip<TextRecordParsing.Record>
	*/

	[IteratorStateMachineAttribute] // RVA: 0x40E50 Offset: 0x40F51 VA: 0x40E50
	// RVA: -1 Offset: -1
	private static IEnumerable<TSource> SkipIterator<TSource>(IEnumerable<TSource> source, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22ADC60 Offset: 0x22ADD61 VA: 0x22ADC60
	|-Enumerable.SkipIterator<object>
	*/

	[ExtensionAttribute] // RVA: 0x40EC0 Offset: 0x40FC1 VA: 0x40EC0
	// RVA: -1 Offset: -1
	public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22AA670 Offset: 0x22AA771 VA: 0x22AA670
	|-Enumerable.OrderBy<AsyncDebugger, int>
	|-Enumerable.OrderBy<FieldInfo, int>
	|-Enumerable.OrderBy<object, int>
	|
	|-RVA: 0x22AA5F0 Offset: 0x22AA6F1 VA: 0x22AA5F0
	|-Enumerable.OrderBy<DiagnosticEvent, int>
	|
	|-RVA: 0x22AA770 Offset: 0x22AA871 VA: 0x22AA770
	|-Enumerable.OrderBy<Glyph, uint>
	|-Enumerable.OrderBy<KerningPair, uint>
	|-Enumerable.OrderBy<object, uint>
	|-Enumerable.OrderBy<TMP_Character, uint>
	|-Enumerable.OrderBy<TMP_GlyphPairAdjustmentRecord, uint>
	|-Enumerable.OrderBy<TMP_SpriteCharacter, uint>
	|-Enumerable.OrderBy<TMP_SpriteGlyph, uint>
	|
	|-RVA: 0x22AA6F0 Offset: 0x22AA7F1 VA: 0x22AA6F0
	|-Enumerable.OrderBy<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x40ED0 Offset: 0x40FD1 VA: 0x40ED0
	// RVA: -1 Offset: -1
	public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22AA7F0 Offset: 0x22AA8F1 VA: 0x22AA7F0
	|-Enumerable.OrderByDescending<KeyValuePair<object, int>, int>
	|-Enumerable.OrderByDescending<KeyValuePair<Unit, int>, int>
	|
	|-RVA: 0x22AA870 Offset: 0x22AA971 VA: 0x22AA870
	|-Enumerable.OrderByDescending<int, int>
	|
	|-RVA: 0x22AA8F0 Offset: 0x22AA9F1 VA: 0x22AA8F0
	|-Enumerable.OrderByDescending<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x40EE0 Offset: 0x40FE1 VA: 0x40EE0
	// RVA: -1 Offset: -1
	public static IOrderedEnumerable<TSource> ThenBy<TSource, TKey>(IOrderedEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22ADEC0 Offset: 0x22ADFC1 VA: 0x22ADEC0
	|-Enumerable.ThenBy<KerningPair, uint>
	|-Enumerable.ThenBy<object, uint>
	|-Enumerable.ThenBy<TMP_GlyphPairAdjustmentRecord, uint>
	|
	|-RVA: 0x22ADDE0 Offset: 0x22ADEE1 VA: 0x22ADDE0
	|-Enumerable.ThenBy<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x40EF0 Offset: 0x40FF1 VA: 0x40EF0
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> Concat<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22A5740 Offset: 0x22A5841 VA: 0x22A5740
	|-Enumerable.Concat<DiagnosticEvent>
	|
	|-RVA: 0x22A57B0 Offset: 0x22A58B1 VA: 0x22A57B0
	|-Enumerable.Concat<object>
	*/

	[IteratorStateMachineAttribute] // RVA: 0x40F00 Offset: 0x41001 VA: 0x40F00
	// RVA: -1 Offset: -1
	private static IEnumerable<TSource> ConcatIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22A5820 Offset: 0x22A5921 VA: 0x22A5820
	|-Enumerable.ConcatIterator<DiagnosticEvent>
	|
	|-RVA: 0x22A58B0 Offset: 0x22A59B1 VA: 0x22A58B0
	|-Enumerable.ConcatIterator<object>
	*/

	[ExtensionAttribute] // RVA: 0x40F70 Offset: 0x41071 VA: 0x40F70
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> Distinct<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22A7CA0 Offset: 0x22A7DA1 VA: 0x22A7CA0
	|-Enumerable.Distinct<FoodstuffData>
	|-Enumerable.Distinct<IResourceLocation>
	|-Enumerable.Distinct<object>
	|-Enumerable.Distinct<string>
	|-Enumerable.Distinct<Transform>
	|
	|-RVA: 0x22A7D00 Offset: 0x22A7E01 VA: 0x22A7D00
	|-Enumerable.Distinct<Vector3>
	*/

	[IteratorStateMachineAttribute] // RVA: 0x40F80 Offset: 0x41081 VA: 0x40F80
	// RVA: -1 Offset: -1
	private static IEnumerable<TSource> DistinctIterator<TSource>(IEnumerable<TSource> source, IEqualityComparer<TSource> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22A7D60 Offset: 0x22A7E61 VA: 0x22A7D60
	|-Enumerable.DistinctIterator<object>
	|
	|-RVA: 0x22A7DF0 Offset: 0x22A7EF1 VA: 0x22A7DF0
	|-Enumerable.DistinctIterator<Vector3>
	*/

	[ExtensionAttribute] // RVA: 0x40FF0 Offset: 0x410F1 VA: 0x40FF0
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> Except<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22A8600 Offset: 0x22A8701 VA: 0x22A8600
	|-Enumerable.Except<Int32Enum>
	|-Enumerable.Except<ItemData.Kinds>
	|
	|-RVA: 0x22A8670 Offset: 0x22A8771 VA: 0x22A8670
	|-Enumerable.Except<object>
	|-Enumerable.Except<string>
	|-Enumerable.Except<SpringBoneSerialization.SpringBoneSerializer>
	*/

	[IteratorStateMachineAttribute] // RVA: 0x41000 Offset: 0x41101 VA: 0x41000
	// RVA: -1 Offset: -1
	private static IEnumerable<TSource> ExceptIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22A86E0 Offset: 0x22A87E1 VA: 0x22A86E0
	|-Enumerable.ExceptIterator<Int32Enum>
	|
	|-RVA: 0x22A8790 Offset: 0x22A8891 VA: 0x22A8790
	|-Enumerable.ExceptIterator<object>
	*/

	[ExtensionAttribute] // RVA: 0x41070 Offset: 0x41171 VA: 0x41070
	// RVA: -1 Offset: -1
	public static IEnumerable<TSource> Reverse<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22AAA50 Offset: 0x22AAB51 VA: 0x22AAA50
	|-Enumerable.Reverse<int>
	|
	|-RVA: 0x22AAAB0 Offset: 0x22AABB1 VA: 0x22AAAB0
	|-Enumerable.Reverse<object>
	*/

	[IteratorStateMachineAttribute] // RVA: 0x41080 Offset: 0x41181 VA: 0x41080
	// RVA: -1 Offset: -1
	private static IEnumerable<TSource> ReverseIterator<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22AAB10 Offset: 0x22AAC11 VA: 0x22AAB10
	|-Enumerable.ReverseIterator<int>
	|
	|-RVA: 0x22AAB90 Offset: 0x22AAC91 VA: 0x22AAB90
	|-Enumerable.ReverseIterator<object>
	*/

	[ExtensionAttribute] // RVA: 0x410F0 Offset: 0x411F1 VA: 0x410F0
	// RVA: -1 Offset: -1
	public static TSource[] ToArray<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22ADFA0 Offset: 0x22AE0A1 VA: 0x22ADFA0
	|-Enumerable.ToArray<KeyValuePair<int, object>>
	|-Enumerable.ToArray<KeyValuePair<int, string>>
	|
	|-RVA: 0x22AE030 Offset: 0x22AE131 VA: 0x22AE030
	|-Enumerable.ToArray<KeyValuePair<object, object>>
	|-Enumerable.ToArray<KeyValuePair<Type, IUserDataDescriptor>>
	|
	|-RVA: 0x22AE270 Offset: 0x22AE371 VA: 0x22AE270
	|-Enumerable.ToArray<Attribute>
	|-Enumerable.ToArray<Breakpoint>
	|-Enumerable.ToArray<Closure>
	|-Enumerable.ToArray<Expression>
	|-Enumerable.ToArray<GUIContent>
	|-Enumerable.ToArray<IResourceLocation>
	|-Enumerable.ToArray<IVariable>
	|-Enumerable.ToArray<ItemData>
	|-Enumerable.ToArray<object>
	|-Enumerable.ToArray<ParameterDescriptor>
	|-Enumerable.ToArray<Scope>
	|-Enumerable.ToArray<SkinnedMeshRenderer>
	|-Enumerable.ToArray<SpringBone>
	|-Enumerable.ToArray<SpringCapsuleCollider>
	|-Enumerable.ToArray<SpringPanelCollider>
	|-Enumerable.ToArray<SpringSphereCollider>
	|-Enumerable.ToArray<StackFrame>
	|-Enumerable.ToArray<string>
	|-Enumerable.ToArray<SymbolRef>
	|-Enumerable.ToArray<Thread>
	|-Enumerable.ToArray<Transform>
	|-Enumerable.ToArray<Variable>
	|-Enumerable.ToArray<WatchItem>
	|-Enumerable.ToArray<SpringBoneSerialization.LengthLimitSerializer>
	|
	|-RVA: 0x22AE0C0 Offset: 0x22AE1C1 VA: 0x22AE0C0
	|-Enumerable.ToArray<Color>
	|
	|-RVA: 0x22AE150 Offset: 0x22AE251 VA: 0x22AE150
	|-Enumerable.ToArray<int>
	|
	|-RVA: 0x22AE1E0 Offset: 0x22AE2E1 VA: 0x22AE1E0
	|-Enumerable.ToArray<Int32Enum>
	|-Enumerable.ToArray<ItemData.Kinds>
	|
	|-RVA: 0x22AE300 Offset: 0x22AE401 VA: 0x22AE300
	|-Enumerable.ToArray<PlayerLoopSystem>
	|
	|-RVA: 0x22AE390 Offset: 0x22AE491 VA: 0x22AE390
	|-Enumerable.ToArray<uint>
	|
	|-RVA: 0x22AE420 Offset: 0x22AE521 VA: 0x22AE420
	|-Enumerable.ToArray<Vector3>
	*/

	[ExtensionAttribute] // RVA: 0x41100 Offset: 0x41201 VA: 0x41100
	// RVA: -1 Offset: -1
	public static List<TSource> ToList<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22AF110 Offset: 0x22AF211 VA: 0x22AF110
	|-Enumerable.ToList<<>f__AnonymousType0<SpringBone, int>>
	|-Enumerable.ToList<DynValue>
	|-Enumerable.ToList<GameObject>
	|-Enumerable.ToList<Glyph>
	|-Enumerable.ToList<IOverloadableMemberDescriptor>
	|-Enumerable.ToList<Image>
	|-Enumerable.ToList<KerningPair>
	|-Enumerable.ToList<object>
	|-Enumerable.ToList<SpringBone>
	|-Enumerable.ToList<string>
	|-Enumerable.ToList<TMP_Character>
	|-Enumerable.ToList<TMP_GlyphPairAdjustmentRecord>
	|-Enumerable.ToList<TMP_SpriteCharacter>
	|-Enumerable.ToList<TMP_SpriteGlyph>
	|-Enumerable.ToList<TasteData>
	|-Enumerable.ToList<Unit>
	|-Enumerable.ToList<VolumeParameter>
	|-Enumerable.ToList<WatchItem>
	|-Enumerable.ToList<DynamicsSetup.ParseMessage>
	|-Enumerable.ToList<ExtensionMethodsRegistry.UnresolvedGenericMethod>
	|-Enumerable.ToList<TextRecordParsing.Record>
	|
	|-RVA: 0x22AEFD0 Offset: 0x22AF0D1 VA: 0x22AEFD0
	|-Enumerable.ToList<int>
	|
	|-RVA: 0x22AF070 Offset: 0x22AF171 VA: 0x22AF070
	|-Enumerable.ToList<Int32Enum>
	|-Enumerable.ToList<ItemData.Kinds>
	|
	|-RVA: 0x22AF1B0 Offset: 0x22AF2B1 VA: 0x22AF1B0
	|-Enumerable.ToList<float>
	|
	|-RVA: 0x22AF250 Offset: 0x22AF351 VA: 0x22AF250
	|-Enumerable.ToList<ulong>
	|
	|-RVA: 0x22AF2F0 Offset: 0x22AF3F1 VA: 0x22AF2F0
	|-Enumerable.ToList<Vector3>
	*/

	[ExtensionAttribute] // RVA: 0x41110 Offset: 0x41211 VA: 0x41110
	// RVA: -1 Offset: -1
	public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22AE4B0 Offset: 0x22AE5B1 VA: 0x22AE4B0
	|-Enumerable.ToDictionary<KeyValuePair<object, int>, object, int>
	|-Enumerable.ToDictionary<KeyValuePair<Unit, int>, Unit, int>
	|
	|-RVA: 0x22AE4D0 Offset: 0x22AE5D1 VA: 0x22AE4D0
	|-Enumerable.ToDictionary<KeyValuePair<object, object>, object, object>
	|
	|-RVA: 0x22AE4F0 Offset: 0x22AE5F1 VA: 0x22AE4F0
	|-Enumerable.ToDictionary<object, object, object>
	*/

	[ExtensionAttribute] // RVA: 0x41120 Offset: 0x41221 VA: 0x41120
	// RVA: -1 Offset: -1
	public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22AE510 Offset: 0x22AE611 VA: 0x22AE510
	|-Enumerable.ToDictionary<KeyValuePair<object, int>, object, int>
	|
	|-RVA: 0x22AE8B0 Offset: 0x22AE9B1 VA: 0x22AE8B0
	|-Enumerable.ToDictionary<KeyValuePair<object, object>, object, object>
	|
	|-RVA: 0x22AEC50 Offset: 0x22AED51 VA: 0x22AEC50
	|-Enumerable.ToDictionary<object, object, object>
	*/

	[ExtensionAttribute] // RVA: 0x41130 Offset: 0x41231 VA: 0x41130
	// RVA: -1 Offset: -1
	public static IEnumerable<TResult> OfType<TResult>(IEnumerable source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22AA510 Offset: 0x22AA611 VA: 0x22AA510
	|-Enumerable.OfType<Attribute>
	|-Enumerable.OfType<IOptimizableDescriptor>
	|-Enumerable.OfType<MoonSharpHiddenAttribute>
	|-Enumerable.OfType<MoonSharpHideMemberAttribute>
	|-Enumerable.OfType<MoonSharpPropertyAttribute>
	|-Enumerable.OfType<MoonSharpUserDataAttribute>
	|-Enumerable.OfType<MoonSharpUserDataMetamethodAttribute>
	|-Enumerable.OfType<MoonSharpVisibleAttribute>
	|-Enumerable.OfType<object>
	*/

	[IteratorStateMachineAttribute] // RVA: 0x41140 Offset: 0x41241 VA: 0x41140
	// RVA: -1 Offset: -1
	private static IEnumerable<TResult> OfTypeIterator<TResult>(IEnumerable source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22AA570 Offset: 0x22AA671 VA: 0x22AA570
	|-Enumerable.OfTypeIterator<object>
	*/

	[ExtensionAttribute] // RVA: 0x411B0 Offset: 0x412B1 VA: 0x411B0
	// RVA: -1 Offset: -1
	public static IEnumerable<TResult> Cast<TResult>(IEnumerable source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22A2B50 Offset: 0x22A2C51 VA: 0x22A2B50
	|-Enumerable.Cast<IVariable>
	|-Enumerable.Cast<object>
	*/

	[IteratorStateMachineAttribute] // RVA: 0x411C0 Offset: 0x412C1 VA: 0x411C0
	// RVA: -1 Offset: -1
	private static IEnumerable<TResult> CastIterator<TResult>(IEnumerable source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22A2C00 Offset: 0x22A2D01 VA: 0x22A2C00
	|-Enumerable.CastIterator<object>
	*/

	[ExtensionAttribute] // RVA: 0x41230 Offset: 0x41331 VA: 0x41230
	// RVA: -1 Offset: -1
	public static TSource First<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22A8840 Offset: 0x22A8941 VA: 0x22A8840
	|-Enumerable.First<AsyncOperationHandle>
	|
	|-RVA: 0x22A8C70 Offset: 0x22A8D71 VA: 0x22A8C70
	|-Enumerable.First<Attribute>
	|-Enumerable.First<MethodInfo>
	|-Enumerable.First<MoonSharpUserDataAttribute>
	|-Enumerable.First<object>
	|-Enumerable.First<string>
	|-Enumerable.First<Toggle>
	*/

	[ExtensionAttribute] // RVA: 0x41240 Offset: 0x41341 VA: 0x41240
	// RVA: -1 Offset: -1
	public static TSource FirstOrDefault<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22A9080 Offset: 0x22A9181 VA: 0x22A9080
	|-Enumerable.FirstOrDefault<MethodInfo>
	|-Enumerable.FirstOrDefault<object>
	|-Enumerable.FirstOrDefault<string>
	|-Enumerable.FirstOrDefault<Transform>
	|-Enumerable.FirstOrDefault<TypedStringToValueMap>
	*/

	[ExtensionAttribute] // RVA: 0x41250 Offset: 0x41351 VA: 0x41250
	// RVA: -1 Offset: -1
	public static TSource FirstOrDefault<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22A9490 Offset: 0x22A9591 VA: 0x22A9490
	|-Enumerable.FirstOrDefault<AsyncDebugger>
	|-Enumerable.FirstOrDefault<Component>
	|-Enumerable.FirstOrDefault<DebugUIHandlerWidget>
	|-Enumerable.FirstOrDefault<IResourceProvider>
	|-Enumerable.FirstOrDefault<object>
	|-Enumerable.FirstOrDefault<SourceCode>
	|-Enumerable.FirstOrDefault<TextRecordParsing.Record>
	*/

	[ExtensionAttribute] // RVA: 0x41260 Offset: 0x41361 VA: 0x41260
	// RVA: -1 Offset: -1
	public static TSource Last<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22A9C30 Offset: 0x22A9D31 VA: 0x22A9C30
	|-Enumerable.Last<BuildTimeScopeFrame>
	|-Enumerable.Last<Expression>
	|-Enumerable.Last<KerningPair>
	|-Enumerable.Last<object>
	|
	|-RVA: 0x22A97C0 Offset: 0x22A98C1 VA: 0x22A97C0
	|-Enumerable.Last<int>
	*/

	[ExtensionAttribute] // RVA: 0x41270 Offset: 0x41371 VA: 0x41270
	// RVA: -1 Offset: -1
	public static TSource LastOrDefault<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22AA0A0 Offset: 0x22AA1A1 VA: 0x22AA0A0
	|-Enumerable.LastOrDefault<object>
	|-Enumerable.LastOrDefault<WatchItem>
	*/

	[ExtensionAttribute] // RVA: 0x41280 Offset: 0x41381 VA: 0x41280
	// RVA: -1 Offset: -1
	public static TSource SingleOrDefault<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22AD410 Offset: 0x22AD511 VA: 0x22AD410
	|-Enumerable.SingleOrDefault<MoonSharpHiddenAttribute>
	|-Enumerable.SingleOrDefault<MoonSharpUserDataAttribute>
	|-Enumerable.SingleOrDefault<MoonSharpVisibleAttribute>
	|-Enumerable.SingleOrDefault<object>
	*/

	[ExtensionAttribute] // RVA: 0x41290 Offset: 0x41391 VA: 0x41290
	// RVA: -1 Offset: -1
	public static TSource SingleOrDefault<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22AD8A0 Offset: 0x22AD9A1 VA: 0x22AD8A0
	|-Enumerable.SingleOrDefault<object>
	|-Enumerable.SingleOrDefault<PlayerEditorConnectionEvents.MessageTypeSubscribers>
	*/

	[ExtensionAttribute] // RVA: 0x412A0 Offset: 0x413A1 VA: 0x412A0
	// RVA: -1 Offset: -1
	public static TSource ElementAt<TSource>(IEnumerable<TSource> source, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22A7E80 Offset: 0x22A7F81 VA: 0x22A7E80
	|-Enumerable.ElementAt<object>
	|-Enumerable.ElementAt<string>
	|
	|-RVA: 0x22A8240 Offset: 0x22A8341 VA: 0x22A8240
	|-Enumerable.ElementAt<uint>
	*/

	// RVA: 0x2E58EB0 Offset: 0x2E58FB1 VA: 0x2E58EB0
	public static IEnumerable<int> Range(int start, int count) { }

	[IteratorStateMachineAttribute] // RVA: 0x412B0 Offset: 0x413B1 VA: 0x412B0
	// RVA: 0x2E58FE0 Offset: 0x2E590E1 VA: 0x2E58FE0
	private static IEnumerable<int> RangeIterator(int start, int count) { }

	// RVA: -1 Offset: -1
	public static IEnumerable<TResult> Repeat<TResult>(TResult element, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22AA970 Offset: 0x22AAA71 VA: 0x22AA970
	|-Enumerable.Repeat<object>
	*/

	[IteratorStateMachineAttribute] // RVA: 0x41320 Offset: 0x41421 VA: 0x41320
	// RVA: -1 Offset: -1
	private static IEnumerable<TResult> RepeatIterator<TResult>(TResult element, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22AA9D0 Offset: 0x22AAAD1 VA: 0x22AA9D0
	|-Enumerable.RepeatIterator<object>
	*/

	[ExtensionAttribute] // RVA: 0x41390 Offset: 0x41491 VA: 0x41390
	// RVA: -1 Offset: -1
	public static bool Any<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22A2280 Offset: 0x22A2381 VA: 0x22A2280
	|-Enumerable.Any<DynValue>
	|-Enumerable.Any<object>
	|-Enumerable.Any<ParameterInfo>
	|-Enumerable.Any<SpringBone>
	|-Enumerable.Any<string>
	|-Enumerable.Any<PlayerEditorConnectionEvents.MessageTypeSubscribers>
	|-Enumerable.Any<SpringBoneSerialization.PivotSerializer>
	|-Enumerable.Any<SpringColliderSerialization.CapsuleColliderSerializer>
	|-Enumerable.Any<SpringColliderSerialization.PanelColliderSerializer>
	|-Enumerable.Any<SpringColliderSerialization.SphereColliderSerializer>
	|-Enumerable.Any<SpringColliderSerialization.TransformSerializer>
	*/

	[ExtensionAttribute] // RVA: 0x413A0 Offset: 0x414A1 VA: 0x413A0
	// RVA: -1 Offset: -1
	public static bool Any<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22A2820 Offset: 0x22A2921 VA: 0x22A2820
	|-Enumerable.Any<AsyncDebugger>
	|-Enumerable.Any<DynValue>
	|-Enumerable.Any<IOverloadableMemberDescriptor>
	|-Enumerable.Any<object>
	|-Enumerable.Any<ParameterDescriptor>
	|-Enumerable.Any<ParameterInfo>
	|-Enumerable.Any<string>
	|-Enumerable.Any<Type>
	|-Enumerable.Any<PlayerEditorConnectionEvents.MessageTypeSubscribers>
	|-Enumerable.Any<SpringColliderSerialization.IColliderSerializer>
	|-Enumerable.Any<SpringColliderSerialization.TransformSerializer>
	|
	|-RVA: 0x22A24F0 Offset: 0x22A25F1 VA: 0x22A24F0
	|-Enumerable.Any<char>
	*/

	[ExtensionAttribute] // RVA: 0x413B0 Offset: 0x414B1 VA: 0x413B0
	// RVA: -1 Offset: -1
	public static bool All<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22A1F60 Offset: 0x22A2061 VA: 0x22A1F60
	|-Enumerable.All<Expression>
	|-Enumerable.All<object>
	|-Enumerable.All<SwitchCase>
	*/

	[ExtensionAttribute] // RVA: 0x413C0 Offset: 0x414C1 VA: 0x413C0
	// RVA: -1 Offset: -1
	public static int Count<TSource>(IEnumerable<TSource> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22A6AF0 Offset: 0x22A6BF1 VA: 0x22A6AF0
	|-Enumerable.Count<FoodstuffData>
	|-Enumerable.Count<object>
	|-Enumerable.Count<ParameterInfo>
	|-Enumerable.Count<string>
	|-Enumerable.Count<TasteData>
	|-Enumerable.Count<Toggle>
	|-Enumerable.Count<SpringBoneSerialization.PivotSerializer>
	|-Enumerable.Count<SpringBoneSerialization.SpringBoneSerializer>
	|-Enumerable.Count<SpringColliderSerialization.IColliderSerializer>
	|-Enumerable.Count<SpringColliderSerialization.TransformSerializer>
	|-Enumerable.Count<TextRecordParsing.Record>
	|
	|-RVA: 0x22A6750 Offset: 0x22A6851 VA: 0x22A6750
	|-Enumerable.Count<int>
	|
	|-RVA: 0x22A6E90 Offset: 0x22A6F91 VA: 0x22A6E90
	|-Enumerable.Count<float>
	|
	|-RVA: 0x22A7230 Offset: 0x22A7331 VA: 0x22A7230
	|-Enumerable.Count<uint>
	|
	|-RVA: 0x22A75D0 Offset: 0x22A76D1 VA: 0x22A75D0
	|-Enumerable.Count<float3>
	*/

	[ExtensionAttribute] // RVA: 0x413D0 Offset: 0x414D1 VA: 0x413D0
	// RVA: -1 Offset: -1
	public static int Count<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22A7970 Offset: 0x22A7A71 VA: 0x22A7970
	|-Enumerable.Count<DebugUIHandlerWidget>
	|-Enumerable.Count<FoodstuffData>
	|-Enumerable.Count<object>
	|-Enumerable.Count<DebugUI.Widget>
	*/

	[ExtensionAttribute] // RVA: 0x413E0 Offset: 0x414E1 VA: 0x413E0
	// RVA: -1 Offset: -1
	public static bool Contains<TSource>(IEnumerable<TSource> source, TSource value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22A5940 Offset: 0x22A5A41 VA: 0x22A5940
	|-Enumerable.Contains<char>
	|
	|-RVA: 0x22A5B40 Offset: 0x22A5C41 VA: 0x22A5B40
	|-Enumerable.Contains<Collider>
	|-Enumerable.Contains<object>
	|-Enumerable.Contains<string>
	|-Enumerable.Contains<Transform>
	|-Enumerable.Contains<Type>
	|
	|-RVA: 0x22A5A40 Offset: 0x22A5B41 VA: 0x22A5A40
	|-Enumerable.Contains<Int32Enum>
	|-Enumerable.Contains<ItemData.Kinds>
	*/

	[ExtensionAttribute] // RVA: 0x413F0 Offset: 0x414F1 VA: 0x413F0
	// RVA: -1 Offset: -1
	public static bool Contains<TSource>(IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22A5C40 Offset: 0x22A5D41 VA: 0x22A5C40
	|-Enumerable.Contains<char>
	|
	|-RVA: 0x22A5FF0 Offset: 0x22A60F1 VA: 0x22A5FF0
	|-Enumerable.Contains<Int32Enum>
	|
	|-RVA: 0x22A63A0 Offset: 0x22A64A1 VA: 0x22A63A0
	|-Enumerable.Contains<object>
	*/

	[ExtensionAttribute] // RVA: 0x41400 Offset: 0x41501 VA: 0x41400
	// RVA: 0x2E59060 Offset: 0x2E59161 VA: 0x2E59060
	public static int Sum(IEnumerable<int> source) { }

	[ExtensionAttribute] // RVA: 0x41410 Offset: 0x41511 VA: 0x41410
	// RVA: 0x2E593B0 Offset: 0x2E594B1 VA: 0x2E593B0
	public static int Max(IEnumerable<int> source) { }
}

