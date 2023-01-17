// Namespace: 
private class RenderGraphResourceRegistry.IRenderGraphResource // TypeDefIndex: 4491
{
	// Fields
	public bool imported; // 0x10
	public int cachedHash; // 0x14
	public int transientPassIndex; // 0x18
	public bool wasReleased; // 0x1C

	// Methods

	// RVA: 0x35535C0 Offset: 0x35536C1 VA: 0x35535C0 Slot: 4
	public virtual void Reset() { }

	// RVA: 0x35535E0 Offset: 0x35536E1 VA: 0x35535E0 Slot: 5
	public virtual string GetName() { }

	// RVA: 0x3553630 Offset: 0x3553731 VA: 0x3553630 Slot: 6
	public virtual bool IsCreated() { }

	// RVA: 0x3553640 Offset: 0x3553741 VA: 0x3553640
	public void .ctor() { }
}

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
[DebuggerDisplayAttribute] // RVA: 0x3B2C0 Offset: 0x3B3C1 VA: 0x3B2C0
private class RenderGraphResourceRegistry.TextureResource : RenderGraphResourceRegistry.RenderGraphResource<TextureDesc, RTHandle> // TypeDefIndex: 4493
{
	// Methods

	// RVA: 0x3553650 Offset: 0x3553751 VA: 0x3553650 Slot: 5
	public override string GetName() { }

	// RVA: 0x35536D0 Offset: 0x35537D1 VA: 0x35536D0
	public void .ctor() { }
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

// Namespace: 
internal struct RenderGraphResourceRegistry.RendererListResource // TypeDefIndex: 4495
{
	// Fields
	public RendererListDesc desc; // 0x0
	public RendererList rendererList; // 0xC0

	// Methods

	// RVA: 0x35432D0 Offset: 0x35433D1 VA: 0x35432D0
	internal void .ctor(in RendererListDesc desc) { }
}

