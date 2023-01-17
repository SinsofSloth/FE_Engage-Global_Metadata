// Namespace: 
[DefaultMemberAttribute] // RVA: 0x271DD0 Offset: 0x271ED1 VA: 0x271DD0
public abstract class AkBaseArray<T> : IDisposable // TypeDefIndex: 7963
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x27E510 Offset: 0x27E611 VA: 0x27E510
	private int <Capacity>k__BackingField; // 0x0
	private IntPtr m_Buffer; // 0x0

	// Properties
	public int Capacity { get; set; }
	protected abstract int StructureSize { get; }
	public T Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF6A20 Offset: 0x1FF6B21 VA: 0x1FF6A20
	|-AkBaseArray<AkAcousticSurface>..ctor
	|-AkBaseArray<AkDeviceDescription>..ctor
	|-AkBaseArray<AkDiffractionPathInfo>..ctor
	|-AkBaseArray<AkExternalSourceInfo>..ctor
	|-AkBaseArray<AkObjectInfo>..ctor
	|-AkBaseArray<AkObstructionOcclusionValues>..ctor
	|-AkBaseArray<AkReflectionPathInfo>..ctor
	|-AkBaseArray<AkSourceSettings>..ctor
	|-AkBaseArray<AkTriangle>..ctor
	|-AkBaseArray<AkVertex>..ctor
	|-AkBaseArray<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF6B50 Offset: 0x1FF6C51 VA: 0x1FF6B50
	|-AkBaseArray<AkAcousticSurface>.Dispose
	|-AkBaseArray<AkDeviceDescription>.Dispose
	|-AkBaseArray<AkDiffractionPathInfo>.Dispose
	|-AkBaseArray<AkExternalSourceInfo>.Dispose
	|-AkBaseArray<AkObjectInfo>.Dispose
	|-AkBaseArray<AkObstructionOcclusionValues>.Dispose
	|-AkBaseArray<AkReflectionPathInfo>.Dispose
	|-AkBaseArray<AkSourceSettings>.Dispose
	|-AkBaseArray<AkTriangle>.Dispose
	|-AkBaseArray<AkVertex>.Dispose
	|-AkBaseArray<object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 1
	protected override void Finalize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF6C90 Offset: 0x1FF6D91 VA: 0x1FF6C90
	|-AkBaseArray<AkAcousticSurface>.Finalize
	|-AkBaseArray<AkDeviceDescription>.Finalize
	|-AkBaseArray<AkDiffractionPathInfo>.Finalize
	|-AkBaseArray<AkExternalSourceInfo>.Finalize
	|-AkBaseArray<AkObjectInfo>.Finalize
	|-AkBaseArray<AkObstructionOcclusionValues>.Finalize
	|-AkBaseArray<AkReflectionPathInfo>.Finalize
	|-AkBaseArray<AkSourceSettings>.Finalize
	|-AkBaseArray<AkTriangle>.Finalize
	|-AkBaseArray<AkVertex>.Finalize
	|-AkBaseArray<object>.Finalize
	*/

	[CompilerGeneratedAttribute] // RVA: 0x2A70A0 Offset: 0x2A71A1 VA: 0x2A70A0
	// RVA: -1 Offset: -1
	public int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF6D10 Offset: 0x1FF6E11 VA: 0x1FF6D10
	|-AkBaseArray<object>.get_Capacity
	*/

	[CompilerGeneratedAttribute] // RVA: 0x2A70B0 Offset: 0x2A71B1 VA: 0x2A70B0
	// RVA: -1 Offset: -1
	private void set_Capacity(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF6D20 Offset: 0x1FF6E21 VA: 0x1FF6D20
	|-AkBaseArray<object>.set_Capacity
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public virtual int Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF6D30 Offset: 0x1FF6E31 VA: 0x1FF6D30
	|-AkBaseArray<AkAcousticSurface>.Count
	|-AkBaseArray<AkDeviceDescription>.Count
	|-AkBaseArray<AkDiffractionPathInfo>.Count
	|-AkBaseArray<AkExternalSourceInfo>.Count
	|-AkBaseArray<AkObjectInfo>.Count
	|-AkBaseArray<AkObstructionOcclusionValues>.Count
	|-AkBaseArray<AkReflectionPathInfo>.Count
	|-AkBaseArray<AkSourceSettings>.Count
	|-AkBaseArray<AkTriangle>.Count
	|-AkBaseArray<AkVertex>.Count
	|-AkBaseArray<object>.Count
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract int get_StructureSize();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-AkBaseArray<object>.get_StructureSize
	*/

	// RVA: -1 Offset: -1 Slot: 7
	protected virtual void DefaultConstructAtIntPtr(IntPtr address) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF6D50 Offset: 0x1FF6E51 VA: 0x1FF6D50
	|-AkBaseArray<AkDiffractionPathInfo>.DefaultConstructAtIntPtr
	|-AkBaseArray<AkReflectionPathInfo>.DefaultConstructAtIntPtr
	|-AkBaseArray<AkVertex>.DefaultConstructAtIntPtr
	|-AkBaseArray<object>.DefaultConstructAtIntPtr
	*/

	// RVA: -1 Offset: -1 Slot: 8
	protected virtual void ReleaseAllocatedMemoryFromReferenceAtIntPtr(IntPtr address) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF6D60 Offset: 0x1FF6E61 VA: 0x1FF6D60
	|-AkBaseArray<AkAcousticSurface>.ReleaseAllocatedMemoryFromReferenceAtIntPtr
	|-AkBaseArray<AkDeviceDescription>.ReleaseAllocatedMemoryFromReferenceAtIntPtr
	|-AkBaseArray<AkDiffractionPathInfo>.ReleaseAllocatedMemoryFromReferenceAtIntPtr
	|-AkBaseArray<AkObjectInfo>.ReleaseAllocatedMemoryFromReferenceAtIntPtr
	|-AkBaseArray<AkObstructionOcclusionValues>.ReleaseAllocatedMemoryFromReferenceAtIntPtr
	|-AkBaseArray<AkReflectionPathInfo>.ReleaseAllocatedMemoryFromReferenceAtIntPtr
	|-AkBaseArray<AkSourceSettings>.ReleaseAllocatedMemoryFromReferenceAtIntPtr
	|-AkBaseArray<AkTriangle>.ReleaseAllocatedMemoryFromReferenceAtIntPtr
	|-AkBaseArray<AkVertex>.ReleaseAllocatedMemoryFromReferenceAtIntPtr
	|-AkBaseArray<object>.ReleaseAllocatedMemoryFromReferenceAtIntPtr
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract T CreateNewReferenceFromIntPtr(IntPtr address);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-AkBaseArray<object>.CreateNewReferenceFromIntPtr
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void CloneIntoReferenceFromIntPtr(IntPtr address, T other);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-AkBaseArray<object>.CloneIntoReferenceFromIntPtr
	*/

	// RVA: -1 Offset: -1
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF6D70 Offset: 0x1FF6E71 VA: 0x1FF6D70
	|-AkBaseArray<AkAcousticSurface>.get_Item
	|-AkBaseArray<AkTriangle>.get_Item
	|-AkBaseArray<object>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF6DB0 Offset: 0x1FF6EB1 VA: 0x1FF6DB0
	|-AkBaseArray<object>.set_Item
	*/

	// RVA: -1 Offset: -1
	public IntPtr GetBuffer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF6E00 Offset: 0x1FF6F01 VA: 0x1FF6E00
	|-AkBaseArray<AkAcousticSurface>.GetBuffer
	|-AkBaseArray<AkDeviceDescription>.GetBuffer
	|-AkBaseArray<AkDiffractionPathInfo>.GetBuffer
	|-AkBaseArray<AkExternalSourceInfo>.GetBuffer
	|-AkBaseArray<AkObjectInfo>.GetBuffer
	|-AkBaseArray<AkObstructionOcclusionValues>.GetBuffer
	|-AkBaseArray<AkReflectionPathInfo>.GetBuffer
	|-AkBaseArray<AkSourceSettings>.GetBuffer
	|-AkBaseArray<AkTriangle>.GetBuffer
	|-AkBaseArray<object>.GetBuffer
	*/

	// RVA: -1 Offset: -1
	protected IntPtr GetObjectPtr(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF6E10 Offset: 0x1FF6F11 VA: 0x1FF6E10
	|-AkBaseArray<object>.GetObjectPtr
	*/
}

