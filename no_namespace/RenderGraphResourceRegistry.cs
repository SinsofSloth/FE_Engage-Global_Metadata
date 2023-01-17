// Namespace: 
[DebuggerDisplayAttribute] // RVA: 0x3B280 Offset: 0x3B381 VA: 0x3B280
private class RenderGraphResourceRegistry.RenderGraphResource<DescType, ResType> : RenderGraphResourceRegistry.IRenderGraphResource // TypeDefIndex: 4492
{
	// Fields
	public DescType desc; // 0x0
	public ResType resource; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF36E0 Offset: 0x2FF37E1 VA: 0x2FF36E0
	|-RenderGraphResourceRegistry.RenderGraphResource<ComputeBufferDesc, ComputeBuffer>..ctor
	|-RenderGraphResourceRegistry.RenderGraphResource<ComputeBufferDesc, object>..ctor
	|
	|-RVA: 0x2FF3730 Offset: 0x2FF3831 VA: 0x2FF3730
	|-RenderGraphResourceRegistry.RenderGraphResource<TextureDesc, object>..ctor
	|-RenderGraphResourceRegistry.RenderGraphResource<TextureDesc, RTHandle>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF36F0 Offset: 0x2FF37F1 VA: 0x2FF36F0
	|-RenderGraphResourceRegistry.RenderGraphResource<ComputeBufferDesc, ComputeBuffer>.Reset
	|-RenderGraphResourceRegistry.RenderGraphResource<ComputeBufferDesc, object>.Reset
	|
	|-RVA: 0x2FF3740 Offset: 0x2FF3841 VA: 0x2FF3740
	|-RenderGraphResourceRegistry.RenderGraphResource<TextureDesc, object>.Reset
	|-RenderGraphResourceRegistry.RenderGraphResource<TextureDesc, RTHandle>.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override bool IsCreated() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF3720 Offset: 0x2FF3821 VA: 0x2FF3720
	|-RenderGraphResourceRegistry.RenderGraphResource<ComputeBufferDesc, ComputeBuffer>.IsCreated
	|-RenderGraphResourceRegistry.RenderGraphResource<ComputeBufferDesc, object>.IsCreated
	|
	|-RVA: 0x2FF3770 Offset: 0x2FF3871 VA: 0x2FF3770
	|-RenderGraphResourceRegistry.RenderGraphResource<TextureDesc, object>.IsCreated
	|-RenderGraphResourceRegistry.RenderGraphResource<TextureDesc, RTHandle>.IsCreated
	*/
}

// Namespace: 
[DebuggerDisplayAttribute] // RVA: 0x3B300 Offset: 0x3B401 VA: 0x3B300
private class RenderGraphResourceRegistry.ComputeBufferResource : RenderGraphResourceRegistry.RenderGraphResource<ComputeBufferDesc, ComputeBuffer> // TypeDefIndex: 4494
{
	// Methods

	// RVA: 0x3553500 Offset: 0x3553601 VA: 0x3553500 Slot: 5
	public override string GetName() { }

	// RVA: 0x3553560 Offset: 0x3553661 VA: 0x3553560
	public void .ctor() { }
}

