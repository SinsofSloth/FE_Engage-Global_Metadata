// Namespace: UnityEngine.Experimental.Rendering.RenderGraphModule
[DebuggerDisplayAttribute] // RVA: 0x3B1D0 Offset: 0x3B2D1 VA: 0x3B1D0
internal abstract class RenderGraphPass // TypeDefIndex: 4481
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x3C720 Offset: 0x3C821 VA: 0x3C720
	private string <name>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x3C730 Offset: 0x3C831 VA: 0x3C730
	private int <index>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x3C740 Offset: 0x3C841 VA: 0x3C740
	private ProfilingSampler <customSampler>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x3C750 Offset: 0x3C851 VA: 0x3C750
	private bool <enableAsyncCompute>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x3C760 Offset: 0x3C861 VA: 0x3C760
	private bool <allowPassCulling>k__BackingField; // 0x29
	[CompilerGeneratedAttribute] // RVA: 0x3C770 Offset: 0x3C871 VA: 0x3C770
	private TextureHandle <depthBuffer>k__BackingField; // 0x2C
	[CompilerGeneratedAttribute] // RVA: 0x3C780 Offset: 0x3C881 VA: 0x3C780
	private TextureHandle[] <colorBuffers>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x3C790 Offset: 0x3C891 VA: 0x3C790
	private int <colorBufferMaxIndex>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x3C7A0 Offset: 0x3C8A1 VA: 0x3C7A0
	private int <refCount>k__BackingField; // 0x44
	[CompilerGeneratedAttribute] // RVA: 0x3C7B0 Offset: 0x3C8B1 VA: 0x3C7B0
	private bool <generateDebugData>k__BackingField; // 0x48
	public List<ResourceHandle>[] resourceReadLists; // 0x50
	public List<ResourceHandle>[] resourceWriteLists; // 0x58
	public List<ResourceHandle>[] transientResourceList; // 0x60
	public List<RendererListHandle> usedRendererListList; // 0x68

	// Properties
	public string name { get; set; }
	public int index { get; set; }
	public ProfilingSampler customSampler { get; set; }
	public bool enableAsyncCompute { get; set; }
	public bool allowPassCulling { get; set; }
	public TextureHandle depthBuffer { get; set; }
	public TextureHandle[] colorBuffers { get; set; }
	public int colorBufferMaxIndex { get; set; }
	public int refCount { get; set; }
	public bool generateDebugData { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public RenderFunc<PassData> GetExecuteDelegate<PassData>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2016670 Offset: 0x2016771 VA: 0x2016670
	|-RenderGraphPass.GetExecuteDelegate<object>
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Execute(RenderGraphContext renderGraphContext);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Release(RenderGraphObjectPool pool);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool HasRenderFunc();

	[CompilerGeneratedAttribute] // RVA: 0x3D390 Offset: 0x3D491 VA: 0x3D390
	// RVA: 0x3540BD0 Offset: 0x3540CD1 VA: 0x3540BD0
	public string get_name() { }

	[CompilerGeneratedAttribute] // RVA: 0x3D3A0 Offset: 0x3D4A1 VA: 0x3D3A0
	// RVA: 0x3540BE0 Offset: 0x3540CE1 VA: 0x3540BE0
	protected void set_name(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x3D3B0 Offset: 0x3D4B1 VA: 0x3D3B0
	// RVA: 0x3540BF0 Offset: 0x3540CF1 VA: 0x3540BF0
	public int get_index() { }

	[CompilerGeneratedAttribute] // RVA: 0x3D3C0 Offset: 0x3D4C1 VA: 0x3D3C0
	// RVA: 0x3540C00 Offset: 0x3540D01 VA: 0x3540C00
	protected void set_index(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x3D3D0 Offset: 0x3D4D1 VA: 0x3D3D0
	// RVA: 0x3540C10 Offset: 0x3540D11 VA: 0x3540C10
	public ProfilingSampler get_customSampler() { }

	[CompilerGeneratedAttribute] // RVA: 0x3D3E0 Offset: 0x3D4E1 VA: 0x3D3E0
	// RVA: 0x3540C20 Offset: 0x3540D21 VA: 0x3540C20
	protected void set_customSampler(ProfilingSampler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x3D3F0 Offset: 0x3D4F1 VA: 0x3D3F0
	// RVA: 0x3540C30 Offset: 0x3540D31 VA: 0x3540C30
	public bool get_enableAsyncCompute() { }

	[CompilerGeneratedAttribute] // RVA: 0x3D400 Offset: 0x3D501 VA: 0x3D400
	// RVA: 0x3540C40 Offset: 0x3540D41 VA: 0x3540C40
	protected void set_enableAsyncCompute(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x3D410 Offset: 0x3D511 VA: 0x3D410
	// RVA: 0x3540C50 Offset: 0x3540D51 VA: 0x3540C50
	public bool get_allowPassCulling() { }

	[CompilerGeneratedAttribute] // RVA: 0x3D420 Offset: 0x3D521 VA: 0x3D420
	// RVA: 0x3540C60 Offset: 0x3540D61 VA: 0x3540C60
	protected void set_allowPassCulling(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x3D430 Offset: 0x3D531 VA: 0x3D430
	// RVA: 0x3540C70 Offset: 0x3540D71 VA: 0x3540C70
	public TextureHandle get_depthBuffer() { }

	[CompilerGeneratedAttribute] // RVA: 0x3D440 Offset: 0x3D541 VA: 0x3D440
	// RVA: 0x3540C80 Offset: 0x3540D81 VA: 0x3540C80
	protected void set_depthBuffer(TextureHandle value) { }

	[CompilerGeneratedAttribute] // RVA: 0x3D450 Offset: 0x3D551 VA: 0x3D450
	// RVA: 0x3540C90 Offset: 0x3540D91 VA: 0x3540C90
	public TextureHandle[] get_colorBuffers() { }

	[CompilerGeneratedAttribute] // RVA: 0x3D460 Offset: 0x3D561 VA: 0x3D460
	// RVA: 0x3540CA0 Offset: 0x3540DA1 VA: 0x3540CA0
	protected void set_colorBuffers(TextureHandle[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x3D470 Offset: 0x3D571 VA: 0x3D470
	// RVA: 0x3540CB0 Offset: 0x3540DB1 VA: 0x3540CB0
	public int get_colorBufferMaxIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x3D480 Offset: 0x3D581 VA: 0x3D480
	// RVA: 0x3540CC0 Offset: 0x3540DC1 VA: 0x3540CC0
	protected void set_colorBufferMaxIndex(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x3D490 Offset: 0x3D591 VA: 0x3D490
	// RVA: 0x3540CD0 Offset: 0x3540DD1 VA: 0x3540CD0
	public int get_refCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x3D4A0 Offset: 0x3D5A1 VA: 0x3D4A0
	// RVA: 0x3540CE0 Offset: 0x3540DE1 VA: 0x3540CE0
	protected void set_refCount(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x3D4B0 Offset: 0x3D5B1 VA: 0x3D4B0
	// RVA: 0x3540CF0 Offset: 0x3540DF1 VA: 0x3540CF0
	public bool get_generateDebugData() { }

	[CompilerGeneratedAttribute] // RVA: 0x3D4C0 Offset: 0x3D5C1 VA: 0x3D4C0
	// RVA: 0x3540D00 Offset: 0x3540E01 VA: 0x3540D00
	protected void set_generateDebugData(bool value) { }

	// RVA: 0x3540D10 Offset: 0x3540E11 VA: 0x3540D10
	public void .ctor() { }

	// RVA: 0x3541090 Offset: 0x3541191 VA: 0x3541090
	public void Clear() { }

	// RVA: 0x3541380 Offset: 0x3541481 VA: 0x3541380
	public void AddResourceWrite(in ResourceHandle res) { }

	// RVA: 0x3541420 Offset: 0x3541521 VA: 0x3541420
	public void AddResourceRead(in ResourceHandle res) { }

	// RVA: 0x35414B0 Offset: 0x35415B1 VA: 0x35414B0
	public void AddTransientResource(in ResourceHandle res) { }

	// RVA: 0x3541540 Offset: 0x3541641 VA: 0x3541540
	public void UseRendererList(RendererListHandle rendererList) { }

	// RVA: 0x35415A0 Offset: 0x35416A1 VA: 0x35415A0
	public void EnableAsyncCompute(bool value) { }

	// RVA: 0x35415B0 Offset: 0x35416B1 VA: 0x35415B0
	public void AllowPassCulling(bool value) { }

	// RVA: 0x35415C0 Offset: 0x35416C1 VA: 0x35415C0
	public void GenerateDebugData(bool value) { }

	// RVA: 0x35415D0 Offset: 0x35416D1 VA: 0x35415D0
	public void SetColorBuffer(TextureHandle resource, int index) { }

	// RVA: 0x35416D0 Offset: 0x35417D1 VA: 0x35416D0
	public void SetDepthBuffer(TextureHandle resource, DepthAccess flags) { }
}

