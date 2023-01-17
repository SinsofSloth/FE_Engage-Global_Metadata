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
private class RenderGraph.ProfilingScopePassData // TypeDefIndex: 4470
{
	// Fields
	public ProfilingSampler sampler; // 0x10

	// Methods

	// RVA: 0x35534F0 Offset: 0x35535F1 VA: 0x35534F0
	public void .ctor() { }
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

