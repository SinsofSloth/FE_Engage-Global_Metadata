// Namespace: 
internal struct RenderGraph.CompiledResourceInfo // TypeDefIndex: 4468
{
	// Fields
	public List<int> producers; // 0x0
	public List<int> consumers; // 0x8
	public bool resourceCreated; // 0x10
	public int refCount; // 0x14

	// Methods

	// RVA: 0x3553030 Offset: 0x3553131 VA: 0x3553030
	public void Reset() { }
}

// Namespace: 
[DebuggerDisplayAttribute] // RVA: 0x3B180 Offset: 0x3B281 VA: 0x3B180
internal struct RenderGraph.CompiledPassInfo // TypeDefIndex: 4469
{
	// Fields
	public RenderGraphPass pass; // 0x0
	public List<int>[] resourceCreateList; // 0x8
	public List<int>[] resourceReleaseList; // 0x10
	public int refCount; // 0x18
	public bool culled; // 0x1C
	public bool hasSideEffect; // 0x1D
	public int syncToPassIndex; // 0x20
	public int syncFromPassIndex; // 0x24
	public bool needGraphicsFence; // 0x28
	public GraphicsFence fence; // 0x30
	public bool enableAsyncCompute; // 0x40

	// Properties
	public bool allowPassCulling { get; }

	// Methods

	// RVA: 0x3552D60 Offset: 0x3552E61 VA: 0x3552D60
	public bool get_allowPassCulling() { }

	// RVA: 0x3552D70 Offset: 0x3552E71 VA: 0x3552D70
	public void Reset(RenderGraphPass pass) { }
}

// Namespace: 
private class RenderGraph.ProfilingScopePassData // TypeDefIndex: 4470
{
	// Fields
	public ProfilingSampler sampler; // 0x10

	// Methods

	// RVA: 0x35534F0 Offset: 0x35535F1 VA: 0x35534F0
	public void .ctor() { }
}

// Namespace: 
internal sealed class RenderGraph.OnGraphRegisteredDelegate : MulticastDelegate // TypeDefIndex: 4471
{
	// Methods

	// RVA: 0x3553130 Offset: 0x3553231 VA: 0x3553130
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3553150 Offset: 0x3553251 VA: 0x3553150 Slot: 13
	public virtual void Invoke(RenderGraph graph) { }

	// RVA: 0x35534B0 Offset: 0x35535B1 VA: 0x35534B0 Slot: 14
	public virtual IAsyncResult BeginInvoke(RenderGraph graph, AsyncCallback callback, object object) { }

	// RVA: 0x35534E0 Offset: 0x35535E1 VA: 0x35534E0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x3B1C0 Offset: 0x3B2C1 VA: 0x3B1C0
[Serializable]
private sealed class RenderGraph.<>c // TypeDefIndex: 4472
{
	// Fields
	public static readonly RenderGraph.<>c <>9; // 0x0
	public static RenderFunc<RenderGraph.ProfilingScopePassData> <>9__52_0; // 0x8
	public static RenderFunc<RenderGraph.ProfilingScopePassData> <>9__53_0; // 0x10

	// Methods

	// RVA: 0x3552CC0 Offset: 0x3552DC1 VA: 0x3552CC0
	private static void .cctor() { }

	// RVA: 0x3552D30 Offset: 0x3552E31 VA: 0x3552D30
	public void .ctor() { }

	// RVA: 0x3552D40 Offset: 0x3552E41 VA: 0x3552D40
	internal void <BeginProfilingSampler>b__52_0(RenderGraph.ProfilingScopePassData data, RenderGraphContext ctx) { }

	// RVA: 0x3552D50 Offset: 0x3552E51 VA: 0x3552D50
	internal void <EndProfilingSampler>b__53_0(RenderGraph.ProfilingScopePassData data, RenderGraphContext ctx) { }
}

