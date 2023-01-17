// Namespace: UnityEngine.Rendering.Universal
internal class DeferredShaderData : IDisposable // TypeDefIndex: 5266
{
	// Fields
	private static DeferredShaderData m_Instance; // 0x0
	private NativeArray<PreTile>[] m_PreTiles; // 0x10
	private ComputeBuffer[] m_Buffers; // 0x18
	private DeferredShaderData.ComputeBufferInfo[] m_BufferInfos; // 0x20
	private int m_BufferCount; // 0x28
	private int m_CachedBufferIndex; // 0x2C
	private uint m_FrameIndex; // 0x30

	// Properties
	internal static DeferredShaderData instance { get; }

	// Methods

	// RVA: 0x313BBD0 Offset: 0x313BCD1 VA: 0x313BBD0
	private void .ctor() { }

	// RVA: 0x313BCB0 Offset: 0x313BDB1 VA: 0x313BCB0
	internal static DeferredShaderData get_instance() { }

	// RVA: 0x313BD90 Offset: 0x313BE91 VA: 0x313BD90 Slot: 4
	public void Dispose() { }

	// RVA: 0x313BE70 Offset: 0x313BF71 VA: 0x313BE70
	internal void ResetBuffers() { }

	// RVA: 0x313BE80 Offset: 0x313BF81 VA: 0x313BE80
	internal NativeArray<PreTile> GetPreTiles(int level, int count) { }

	// RVA: -1 Offset: -1
	internal ComputeBuffer ReserveBuffer<T>(int count, bool asCBuffer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229EEF0 Offset: 0x229EFF1 VA: 0x229EEF0
	|-DeferredShaderData.ReserveBuffer<PunctualLightData>
	|
	|-RVA: 0x229EFE0 Offset: 0x229F0E1 VA: 0x229EFE0
	|-DeferredShaderData.ReserveBuffer<TileData>
	|
	|-RVA: 0x229F0D0 Offset: 0x229F1D1 VA: 0x229F0D0
	|-DeferredShaderData.ReserveBuffer<uint>
	*/

	// RVA: -1 Offset: -1
	private NativeArray<T> GetOrUpdateNativeArray<T>(ref NativeArray<T>[] nativeArrays, int level, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229EDF0 Offset: 0x229EEF1 VA: 0x229EDF0
	|-DeferredShaderData.GetOrUpdateNativeArray<PreTile>
	*/

	// RVA: -1 Offset: -1
	private void DisposeNativeArrays<T>(ref NativeArray<T>[] nativeArrays) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229ED40 Offset: 0x229EE41 VA: 0x229ED40
	|-DeferredShaderData.DisposeNativeArrays<PreTile>
	*/

	// RVA: 0x313BEF0 Offset: 0x313BFF1 VA: 0x313BEF0
	private ComputeBuffer GetOrUpdateBuffer(int count, int stride, bool isConstantBuffer) { }

	// RVA: 0x313C2F0 Offset: 0x313C3F1 VA: 0x313C2F0
	private void DisposeBuffers(ComputeBuffer[,] buffers) { }

	// RVA: 0x313C2D0 Offset: 0x313C3D1 VA: 0x313C2D0
	private static bool IsLessCircular(uint a, uint b) { }

	// RVA: 0x313C400 Offset: 0x313C501 VA: 0x313C400
	private static int Align(int s, int alignment) { }

	// RVA: 0x313C420 Offset: 0x313C521 VA: 0x313C420
	private static void .cctor() { }
}

