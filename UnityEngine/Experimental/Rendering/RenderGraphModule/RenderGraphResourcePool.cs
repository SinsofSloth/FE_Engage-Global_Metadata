// Namespace: UnityEngine.Experimental.Rendering.RenderGraphModule
internal abstract class RenderGraphResourcePool<Type> // TypeDefIndex: 4486
{
	// Fields
	[TupleElementNamesAttribute] // RVA: 0x3C7C0 Offset: 0x3C8C1 VA: 0x3C7C0
	protected Dictionary<int, List<ValueTuple<Type, int>>> m_ResourcePool; // 0x0
	private List<ValueTuple<int, Type>> m_FrameAllocatedResources; // 0x0
	protected static int s_CurrentFrameIndex; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void ReleaseInternalResource(Type res);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-RenderGraphResourcePool<object>.ReleaseInternalResource
	*/

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract string GetResourceName(Type res);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-RenderGraphResourcePool<object>.GetResourceName
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract long GetResourceSize(Type res);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-RenderGraphResourcePool<object>.GetResourceSize
	*/

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract string GetResourceTypeName();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-RenderGraphResourcePool<object>.GetResourceTypeName
	*/

	// RVA: -1 Offset: -1
	public void ReleaseResource(int hash, Type resource, int currentFrameIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF21F0 Offset: 0x2FF22F1 VA: 0x2FF21F0
	|-RenderGraphResourcePool<ComputeBuffer>.ReleaseResource
	|-RenderGraphResourcePool<object>.ReleaseResource
	|-RenderGraphResourcePool<RTHandle>.ReleaseResource
	*/

	// RVA: -1 Offset: -1
	public bool TryGetResource(int hashCode, out Type resource) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF2300 Offset: 0x2FF2401 VA: 0x2FF2300
	|-RenderGraphResourcePool<ComputeBuffer>.TryGetResource
	|-RenderGraphResourcePool<object>.TryGetResource
	|-RenderGraphResourcePool<RTHandle>.TryGetResource
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void PurgeUnusedResources(int currentFrameIndex);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-RenderGraphResourcePool<object>.PurgeUnusedResources
	*/

	// RVA: -1 Offset: -1
	public void Cleanup() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF2410 Offset: 0x2FF2511 VA: 0x2FF2410
	|-RenderGraphResourcePool<ComputeBuffer>.Cleanup
	|-RenderGraphResourcePool<object>.Cleanup
	|-RenderGraphResourcePool<RTHandle>.Cleanup
	*/

	// RVA: -1 Offset: -1
	public void RegisterFrameAllocation(int hash, Type value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF2780 Offset: 0x2FF2881 VA: 0x2FF2780
	|-RenderGraphResourcePool<ComputeBuffer>.RegisterFrameAllocation
	|-RenderGraphResourcePool<object>.RegisterFrameAllocation
	|-RenderGraphResourcePool<RTHandle>.RegisterFrameAllocation
	*/

	// RVA: -1 Offset: -1
	public void UnregisterFrameAllocation(int hash, Type value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF27F0 Offset: 0x2FF28F1 VA: 0x2FF27F0
	|-RenderGraphResourcePool<ComputeBuffer>.UnregisterFrameAllocation
	|-RenderGraphResourcePool<object>.UnregisterFrameAllocation
	|-RenderGraphResourcePool<RTHandle>.UnregisterFrameAllocation
	*/

	// RVA: -1 Offset: -1
	public void CheckFrameAllocation(bool onException, int frameIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF2860 Offset: 0x2FF2961 VA: 0x2FF2860
	|-RenderGraphResourcePool<ComputeBuffer>.CheckFrameAllocation
	|-RenderGraphResourcePool<object>.CheckFrameAllocation
	|-RenderGraphResourcePool<RTHandle>.CheckFrameAllocation
	*/

	// RVA: -1 Offset: -1
	public void LogResources(RenderGraphLogger logger) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF2BD0 Offset: 0x2FF2CD1 VA: 0x2FF2BD0
	|-RenderGraphResourcePool<ComputeBuffer>.LogResources
	|-RenderGraphResourcePool<object>.LogResources
	|-RenderGraphResourcePool<RTHandle>.LogResources
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF3610 Offset: 0x2FF3711 VA: 0x2FF3610
	|-RenderGraphResourcePool<ComputeBuffer>..ctor
	|-RenderGraphResourcePool<object>..ctor
	|-RenderGraphResourcePool<RTHandle>..ctor
	*/
}

