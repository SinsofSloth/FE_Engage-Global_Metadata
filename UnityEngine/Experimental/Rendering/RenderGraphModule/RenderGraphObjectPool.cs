// Namespace: UnityEngine.Experimental.Rendering.RenderGraphModule
public sealed class RenderGraphObjectPool // TypeDefIndex: 4480
{
	// Fields
	private Dictionary<ValueTuple<Type, int>, Stack<object>> m_ArrayPool; // 0x10
	private List<ValueTuple<object, ValueTuple<Type, int>>> m_AllocatedArrays; // 0x18
	private List<MaterialPropertyBlock> m_AllocatedMaterialPropertyBlocks; // 0x20

	// Methods

	// RVA: 0x1A178B0 Offset: 0x1A179B1 VA: 0x1A178B0
	internal void .ctor() { }

	// RVA: -1 Offset: -1
	public T[] GetTempArray<T>(int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2015FC0 Offset: 0x20160C1 VA: 0x2015FC0
	|-RenderGraphObjectPool.GetTempArray<object>
	|
	|-RVA: 0x20162C0 Offset: 0x20163C1 VA: 0x20162C0
	|-RenderGraphObjectPool.GetTempArray<RenderTargetIdentifier>
	*/

	// RVA: 0x1A20290 Offset: 0x1A20391 VA: 0x1A20290
	public MaterialPropertyBlock GetTempMaterialPropertyBlock() { }

	// RVA: 0x1A1F2D0 Offset: 0x1A1F3D1 VA: 0x1A1F2D0
	internal void ReleaseAllTempAlloc() { }

	// RVA: -1 Offset: -1
	internal T Get<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2015F20 Offset: 0x2016021 VA: 0x2015F20
	|-RenderGraphObjectPool.Get<object>
	*/

	// RVA: -1 Offset: -1
	internal void Release<T>(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20165C0 Offset: 0x20166C1 VA: 0x20165C0
	|-RenderGraphObjectPool.Release<object>
	*/
}

