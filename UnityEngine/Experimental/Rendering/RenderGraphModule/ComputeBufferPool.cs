// Namespace: UnityEngine.Experimental.Rendering.RenderGraphModule
internal class ComputeBufferPool : RenderGraphResourcePool<ComputeBuffer> // TypeDefIndex: 4490
{
	// Methods

	// RVA: 0x1B2CFA0 Offset: 0x1B2D0A1 VA: 0x1B2CFA0 Slot: 4
	protected override void ReleaseInternalResource(ComputeBuffer res) { }

	// RVA: 0x1B2CFB0 Offset: 0x1B2D0B1 VA: 0x1B2CFB0 Slot: 5
	protected override string GetResourceName(ComputeBuffer res) { }

	// RVA: 0x1B2D000 Offset: 0x1B2D101 VA: 0x1B2D000 Slot: 6
	protected override long GetResourceSize(ComputeBuffer res) { }

	// RVA: 0x1B2D040 Offset: 0x1B2D141 VA: 0x1B2D040 Slot: 7
	protected override string GetResourceTypeName() { }

	// RVA: 0x1B2D090 Offset: 0x1B2D191 VA: 0x1B2D090 Slot: 8
	public override void PurgeUnusedResources(int currentFrameIndex) { }

	// RVA: 0x1B2D2F0 Offset: 0x1B2D3F1 VA: 0x1B2D2F0
	public void .ctor() { }
}

