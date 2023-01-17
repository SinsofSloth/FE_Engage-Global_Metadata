// Namespace: UnityEngine.Rendering
[NativeHeaderAttribute] // RVA: 0x440E10 Offset: 0x440F11 VA: 0x440E10
[NativeHeaderAttribute] // RVA: 0x440E10 Offset: 0x440F11 VA: 0x440E10
[NativeHeaderAttribute] // RVA: 0x440E10 Offset: 0x440F11 VA: 0x440E10
public struct CullingResults : IEquatable<CullingResults> // TypeDefIndex: 3938
{
	// Fields
	internal IntPtr ptr; // 0x0
	private CullingAllocationInfo* m_AllocationInfo; // 0x8

	// Properties
	public NativeArray<VisibleLight> visibleLights { get; }
	public int lightAndReflectionProbeIndexCount { get; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0x454050 Offset: 0x454151 VA: 0x454050
	// RVA: 0x2F1DA50 Offset: 0x2F1DB51 VA: 0x2F1DA50
	private static int GetLightIndexCount(IntPtr cullingResultsPtr) { }

	[FreeFunctionAttribute] // RVA: 0x454090 Offset: 0x454191 VA: 0x454090
	// RVA: 0x2F1DAA0 Offset: 0x2F1DBA1 VA: 0x2F1DAA0
	private static int GetReflectionProbeIndexCount(IntPtr cullingResultsPtr) { }

	[FreeFunctionAttribute] // RVA: 0x4540D0 Offset: 0x4541D1 VA: 0x4540D0
	// RVA: 0x2F1DAF0 Offset: 0x2F1DBF1 VA: 0x2F1DAF0
	private static void FillLightAndReflectionProbeIndices(IntPtr cullingResultsPtr, ComputeBuffer computeBuffer) { }

	[FreeFunctionAttribute] // RVA: 0x454110 Offset: 0x454211 VA: 0x454110
	// RVA: 0x2F1DB40 Offset: 0x2F1DC41 VA: 0x2F1DB40
	private static int GetLightIndexMapSize(IntPtr cullingResultsPtr) { }

	[FreeFunctionAttribute] // RVA: 0x454150 Offset: 0x454251 VA: 0x454150
	// RVA: 0x2F1DB90 Offset: 0x2F1DC91 VA: 0x2F1DB90
	private static void FillLightIndexMap(IntPtr cullingResultsPtr, IntPtr indexMapPtr, int indexMapSize) { }

	[FreeFunctionAttribute] // RVA: 0x454190 Offset: 0x454291 VA: 0x454190
	// RVA: 0x2F1DBF0 Offset: 0x2F1DCF1 VA: 0x2F1DBF0
	private static void SetLightIndexMap(IntPtr cullingResultsPtr, IntPtr indexMapPtr, int indexMapSize) { }

	[FreeFunctionAttribute] // RVA: 0x4541D0 Offset: 0x4542D1 VA: 0x4541D0
	// RVA: 0x2F1DC50 Offset: 0x2F1DD51 VA: 0x2F1DC50
	private static bool GetShadowCasterBounds(IntPtr cullingResultsPtr, int lightIndex, out Bounds bounds) { }

	[FreeFunctionAttribute] // RVA: 0x454210 Offset: 0x454311 VA: 0x454210
	// RVA: 0x2F1DCB0 Offset: 0x2F1DDB1 VA: 0x2F1DCB0
	private static bool ComputeSpotShadowMatricesAndCullingPrimitives(IntPtr cullingResultsPtr, int activeLightIndex, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData) { }

	[FreeFunctionAttribute] // RVA: 0x454250 Offset: 0x454351 VA: 0x454250
	// RVA: 0x2F1DD20 Offset: 0x2F1DE21 VA: 0x2F1DD20
	private static bool ComputeDirectionalShadowMatricesAndCullingPrimitives(IntPtr cullingResultsPtr, int activeLightIndex, int splitIndex, int splitCount, Vector3 splitRatio, int shadowResolution, float shadowNearPlaneOffset, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData) { }

	// RVA: 0x2F1DEA0 Offset: 0x2F1DFA1 VA: 0x2F1DEA0
	public NativeArray<VisibleLight> get_visibleLights() { }

	// RVA: -1 Offset: -1
	private NativeArray<T> GetNativeArray<T>(void* dataPointer, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229D830 Offset: 0x229D931 VA: 0x229D830
	|-CullingResults.GetNativeArray<VisibleLight>
	*/

	// RVA: 0x2F1DF00 Offset: 0x2F1E001 VA: 0x2F1DF00
	public int get_lightAndReflectionProbeIndexCount() { }

	// RVA: 0x2F1DF90 Offset: 0x2F1E091 VA: 0x2F1DF90
	public void FillLightAndReflectionProbeIndices(ComputeBuffer computeBuffer) { }

	// RVA: 0x2F1DFE0 Offset: 0x2F1E0E1 VA: 0x2F1DFE0
	public NativeArray<int> GetLightIndexMap(Allocator allocator) { }

	// RVA: 0x2F1E0F0 Offset: 0x2F1E1F1 VA: 0x2F1E0F0
	public void SetLightIndexMap(NativeArray<int> lightIndexMap) { }

	// RVA: 0x2F1E1A0 Offset: 0x2F1E2A1 VA: 0x2F1E1A0
	public bool GetShadowCasterBounds(int lightIndex, out Bounds outBounds) { }

	// RVA: 0x2F1E200 Offset: 0x2F1E301 VA: 0x2F1E200
	public bool ComputeSpotShadowMatricesAndCullingPrimitives(int activeLightIndex, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData) { }

	// RVA: 0x2F1E270 Offset: 0x2F1E371 VA: 0x2F1E270
	public bool ComputeDirectionalShadowMatricesAndCullingPrimitives(int activeLightIndex, int splitIndex, int splitCount, Vector3 splitRatio, int shadowResolution, float shadowNearPlaneOffset, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData) { }

	// RVA: 0x2F1E340 Offset: 0x2F1E441 VA: 0x2F1E340 Slot: 4
	public bool Equals(CullingResults other) { }

	// RVA: 0x2F1E3E0 Offset: 0x2F1E4E1 VA: 0x2F1E3E0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2F1E4C0 Offset: 0x2F1E5C1 VA: 0x2F1E4C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2F1DDF0 Offset: 0x2F1DEF1 VA: 0x2F1DDF0
	private static bool ComputeDirectionalShadowMatricesAndCullingPrimitives_Injected(IntPtr cullingResultsPtr, int activeLightIndex, int splitIndex, int splitCount, ref Vector3 splitRatio, int shadowResolution, float shadowNearPlaneOffset, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData) { }
}

