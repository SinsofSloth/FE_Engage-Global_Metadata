// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x43ED20 Offset: 0x43EE21 VA: 0x43ED20
[UsedByNativeCodeAttribute] // RVA: 0x43ED20 Offset: 0x43EE21 VA: 0x43ED20
[NativeHeaderAttribute] // RVA: 0x43ED20 Offset: 0x43EE21 VA: 0x43ED20
public sealed class ComputeBuffer : IDisposable // TypeDefIndex: 3627
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public int count { get; }
	public int stride { get; }
	public string name { set; }

	// Methods

	// RVA: 0x2F1B040 Offset: 0x2F1B141 VA: 0x2F1B040 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2F1B190 Offset: 0x2F1B291 VA: 0x2F1B190 Slot: 4
	public void Dispose() { }

	// RVA: 0x2F1B0B0 Offset: 0x2F1B1B1 VA: 0x2F1B0B0
	private void Dispose(bool disposing) { }

	[FreeFunctionAttribute] // RVA: 0x450990 Offset: 0x450A91 VA: 0x450990
	// RVA: 0x2F1B2B0 Offset: 0x2F1B3B1 VA: 0x2F1B2B0
	private static IntPtr InitBuffer(int count, int stride, ComputeBufferType type, ComputeBufferMode usage) { }

	[FreeFunctionAttribute] // RVA: 0x4509D0 Offset: 0x450AD1 VA: 0x4509D0
	// RVA: 0x2F1B260 Offset: 0x2F1B361 VA: 0x2F1B260
	private static void DestroyBuffer(ComputeBuffer buf) { }

	// RVA: 0x2F1B320 Offset: 0x2F1B421 VA: 0x2F1B320
	public void .ctor(int count, int stride) { }

	// RVA: 0x2F1B450 Offset: 0x2F1B551 VA: 0x2F1B450
	public void .ctor(int count, int stride, ComputeBufferType type) { }

	// RVA: 0x2F1B460 Offset: 0x2F1B561 VA: 0x2F1B460
	public void .ctor(int count, int stride, ComputeBufferType type, ComputeBufferMode usage) { }

	// RVA: 0x2F1B330 Offset: 0x2F1B431 VA: 0x2F1B330
	internal void .ctor(int count, int stride, ComputeBufferType type, ComputeBufferMode usage, int stackDepth) { }

	// RVA: 0x2F1B470 Offset: 0x2F1B571 VA: 0x2F1B470
	public void Release() { }

	// RVA: 0x2F1B480 Offset: 0x2F1B581 VA: 0x2F1B480
	public int get_count() { }

	// RVA: 0x2F1B4D0 Offset: 0x2F1B5D1 VA: 0x2F1B4D0
	public int get_stride() { }

	// RVA: -1 Offset: -1
	public void SetData<T>(NativeArray<T> data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229B720 Offset: 0x229B821 VA: 0x229B720
	|-ComputeBuffer.SetData<ShaderInput.LightData>
	|
	|-RVA: 0x229B7A0 Offset: 0x229B8A1 VA: 0x229B7A0
	|-ComputeBuffer.SetData<ShaderInput.ShadowData>
	*/

	// RVA: -1 Offset: -1
	public void SetData<T>(List<T> data, int managedBufferStartIndex, int computeBufferStartIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229B820 Offset: 0x229B921 VA: 0x229B820
	|-ComputeBuffer.SetData<int>
	*/

	// RVA: -1 Offset: -1
	public void SetData<T>(NativeArray<T> data, int nativeBufferStartIndex, int computeBufferStartIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229BB10 Offset: 0x229BC11 VA: 0x229BB10
	|-ComputeBuffer.SetData<uint>
	|
	|-RVA: 0x229BC70 Offset: 0x229BD71 VA: 0x229BC70
	|-ComputeBuffer.SetData<uint4>
	*/

	[FreeFunctionAttribute] // RVA: 0x450A10 Offset: 0x450B11 VA: 0x450A10
	// RVA: 0x2F1B520 Offset: 0x2F1B621 VA: 0x2F1B520
	private void InternalSetNativeData(IntPtr data, int nativeBufferStartIndex, int computeBufferStartIndex, int count, int elemSize) { }

	[FreeFunctionAttribute] // RVA: 0x450A60 Offset: 0x450B61 VA: 0x450A60
	// RVA: 0x2F1B5A0 Offset: 0x2F1B6A1 VA: 0x2F1B5A0
	private void InternalSetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize) { }

	// RVA: 0x2F1B620 Offset: 0x2F1B721 VA: 0x2F1B620
	public void set_name(string value) { }

	[FreeFunctionAttribute] // RVA: 0x450AB0 Offset: 0x450BB1 VA: 0x450AB0
	// RVA: 0x2F1B670 Offset: 0x2F1B771 VA: 0x2F1B670
	private void SetName(string name) { }
}

