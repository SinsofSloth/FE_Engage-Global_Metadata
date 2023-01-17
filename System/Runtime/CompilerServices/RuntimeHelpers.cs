// Namespace: System.Runtime.CompilerServices
public static class RuntimeHelpers // TypeDefIndex: 1282
{
	// Properties
	public static int OffsetToStringData { get; }

	// Methods

	// RVA: 0x322CF40 Offset: 0x322D041 VA: 0x322CF40
	private static void InitializeArray(Array array, IntPtr fldHandle) { }

	// RVA: 0x322B0D0 Offset: 0x322B1D1 VA: 0x322B0D0
	public static void InitializeArray(Array array, RuntimeFieldHandle fldHandle) { }

	// RVA: 0x322CF50 Offset: 0x322D051 VA: 0x322CF50
	public static int get_OffsetToStringData() { }

	// RVA: 0x322CF60 Offset: 0x322D061 VA: 0x322CF60
	public static int GetHashCode(object o) { }

	// RVA: 0x322CF70 Offset: 0x322D071 VA: 0x322CF70
	public static object GetObjectValue(object obj) { }

	// RVA: 0x322CF80 Offset: 0x322D081 VA: 0x322CF80
	private static bool SufficientExecutionStack() { }

	// RVA: 0x322CF90 Offset: 0x322D091 VA: 0x322CF90
	public static bool TryEnsureSufficientExecutionStack() { }

	[ReliabilityContractAttribute] // RVA: 0x47D380 Offset: 0x47D481 VA: 0x47D380
	[MonoTODOAttribute] // RVA: 0x47D380 Offset: 0x47D481 VA: 0x47D380
	// RVA: 0x322CFA0 Offset: 0x322D0A1 VA: 0x322CFA0
	public static void PrepareConstrainedRegions() { }

	// RVA: -1 Offset: -1
	public static bool IsReferenceOrContainsReferences<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x201A3B0 Offset: 0x201A4B1 VA: 0x201A3B0
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TimeInterval<object>>
	|
	|-RVA: 0x201A4A0 Offset: 0x201A5A1 VA: 0x201A4A0
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Timestamped<object>>
	|
	|-RVA: 0x201A590 Offset: 0x201A691 VA: 0x201A590
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ValueTuple<object, int>>
	|
	|-RVA: 0x201A680 Offset: 0x201A781 VA: 0x201A680
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ValueTuple<object, float>>
	|
	|-RVA: 0x201A770 Offset: 0x201A871 VA: 0x201A770
	|-RuntimeHelpers.IsReferenceOrContainsReferences<AsyncOperationHandle>
	|
	|-RVA: 0x201A860 Offset: 0x201A961 VA: 0x201A860
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Color>
	|
	|-RVA: 0x201A950 Offset: 0x201AA51 VA: 0x201A950
	|-RuntimeHelpers.IsReferenceOrContainsReferences<int>
	|
	|-RVA: 0x201AA40 Offset: 0x201AB41 VA: 0x201AA40
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Int32Enum>
	|
	|-RVA: 0x201AB30 Offset: 0x201AC31 VA: 0x201AB30
	|-RuntimeHelpers.IsReferenceOrContainsReferences<MapPos>
	|
	|-RVA: 0x201AC20 Offset: 0x201AD21 VA: 0x201AC20
	|-RuntimeHelpers.IsReferenceOrContainsReferences<object>
	|
	|-RVA: 0x201AD10 Offset: 0x201AE11 VA: 0x201AD10
	|-RuntimeHelpers.IsReferenceOrContainsReferences<RandomSeed>
	|
	|-RVA: 0x201AE00 Offset: 0x201AF01 VA: 0x201AE00
	|-RuntimeHelpers.IsReferenceOrContainsReferences<float>
	|
	|-RVA: 0x201AEF0 Offset: 0x201AFF1 VA: 0x201AEF0
	|-RuntimeHelpers.IsReferenceOrContainsReferences<uint>
	|
	|-RVA: 0x201AFE0 Offset: 0x201B0E1 VA: 0x201AFE0
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ulong>
	|
	|-RVA: 0x201B0D0 Offset: 0x201B1D1 VA: 0x201B0D0
	|-RuntimeHelpers.IsReferenceOrContainsReferences<DynamicMesh.State>
	|
	|-RVA: 0x201B1C0 Offset: 0x201B2C1 VA: 0x201B1C0
	|-RuntimeHelpers.IsReferenceOrContainsReferences<MapMind.Record>
	|
	|-RVA: 0x201B2B0 Offset: 0x201B3B1 VA: 0x201B2B0
	|-RuntimeHelpers.IsReferenceOrContainsReferences<QualitySettingsStack.Settings>
	|
	|-RVA: 0x201B3A0 Offset: 0x201B4A1 VA: 0x201B3A0
	|-RuntimeHelpers.IsReferenceOrContainsReferences<SequenceNode.SequenceConstructPosContext>
	|
	|-RVA: 0x201B490 Offset: 0x201B591 VA: 0x201B490
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Stream.Info>
	*/
}

