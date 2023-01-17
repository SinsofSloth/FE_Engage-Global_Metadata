// Namespace: 
public static class ScriptableRenderer.Profiling.RenderBlock // TypeDefIndex: 5269
{
	// Fields
	private const string k_Name = "RenderPassBlock";
	public static readonly ProfilingSampler beforeRendering; // 0x0
	public static readonly ProfilingSampler mainRenderingOpaque; // 0x8
	public static readonly ProfilingSampler mainRenderingTransparent; // 0x10
	public static readonly ProfilingSampler afterRendering; // 0x18

	// Methods

	// RVA: 0x2FA7360 Offset: 0x2FA7461 VA: 0x2FA7360
	private static void .cctor() { }
}

// Namespace: 
public static class ScriptableRenderer.Profiling.RenderPass // TypeDefIndex: 5270
{
	// Fields
	private const string k_Name = "ScriptableRenderPass";
	public static readonly ProfilingSampler configure; // 0x0

	// Methods

	// RVA: 0x2FA74D0 Offset: 0x2FA75D1 VA: 0x2FA74D0
	private static void .cctor() { }
}

// Namespace: 
private static class ScriptableRenderer.Profiling // TypeDefIndex: 5271
{
	// Fields
	private const string k_Name = "ScriptableRenderer";
	public static readonly ProfilingSampler setPerCameraShaderVariables; // 0x0
	public static readonly ProfilingSampler sortRenderPasses; // 0x8
	public static readonly ProfilingSampler setupLights; // 0x10
	public static readonly ProfilingSampler setupCamera; // 0x18
	public static readonly ProfilingSampler addRenderPasses; // 0x20
	public static readonly ProfilingSampler clearRenderingState; // 0x28
	public static readonly ProfilingSampler internalStartRendering; // 0x30
	public static readonly ProfilingSampler internalFinishRendering; // 0x38

	// Methods

	// RVA: 0x2FA6280 Offset: 0x2FA6381 VA: 0x2FA6280
	private static void .cctor() { }
}

// Namespace: 
public class ScriptableRenderer.RenderingFeatures // TypeDefIndex: 5272
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x4812E0 Offset: 0x4813E1 VA: 0x4812E0
	private bool <cameraStacking>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x4812F0 Offset: 0x4813F1 VA: 0x4812F0
	private bool <msaa>k__BackingField; // 0x11

	// Properties
	public bool cameraStacking { get; set; }
	public bool msaa { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x4845B0 Offset: 0x4846B1 VA: 0x4845B0
	// RVA: 0x2FA6930 Offset: 0x2FA6A31 VA: 0x2FA6930
	public bool get_cameraStacking() { }

	[CompilerGeneratedAttribute] // RVA: 0x4845C0 Offset: 0x4846C1 VA: 0x4845C0
	// RVA: 0x2FA6940 Offset: 0x2FA6A41 VA: 0x2FA6940
	public void set_cameraStacking(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x4845D0 Offset: 0x4846D1 VA: 0x4845D0
	// RVA: 0x2FA6950 Offset: 0x2FA6A51 VA: 0x2FA6950
	public bool get_msaa() { }

	[CompilerGeneratedAttribute] // RVA: 0x4845E0 Offset: 0x4846E1 VA: 0x4845E0
	// RVA: 0x2FA6960 Offset: 0x2FA6A61 VA: 0x2FA6960
	public void set_msaa(bool value) { }

	// RVA: 0x2FA6970 Offset: 0x2FA6A71 VA: 0x2FA6970
	public void .ctor() { }
}

// Namespace: 
private static class ScriptableRenderer.RenderPassBlock // TypeDefIndex: 5273
{
	// Fields
	public static readonly int BeforeRendering; // 0x0
	public static readonly int MainRenderingOpaque; // 0x4
	public static readonly int MainRenderingTransparent; // 0x8
	public static readonly int AfterRendering; // 0xC

	// Methods

	// RVA: 0x2FA68B0 Offset: 0x2FA69B1 VA: 0x2FA68B0
	private static void .cctor() { }
}

// Namespace: 
public struct ScriptableRenderer.RenderBlocks.BlockRange : IDisposable // TypeDefIndex: 5274
{
	// Fields
	private int m_Current; // 0x0
	private int m_End; // 0x4

	// Properties
	public int Current { get; }

	// Methods

	// RVA: 0x2FA6890 Offset: 0x2FA6991 VA: 0x2FA6890
	public void .ctor(int begin, int end) { }

	// RVA: 0x2FA7570 Offset: 0x2FA7671 VA: 0x2FA7570
	public ScriptableRenderer.RenderBlocks.BlockRange GetEnumerator() { }

	// RVA: 0x2FA7580 Offset: 0x2FA7681 VA: 0x2FA7580
	public bool MoveNext() { }

	// RVA: 0x2FA75A0 Offset: 0x2FA76A1 VA: 0x2FA75A0
	public int get_Current() { }

	// RVA: 0x2FA75B0 Offset: 0x2FA76B1 VA: 0x2FA75B0 Slot: 4
	public void Dispose() { }
}

// Namespace: 
internal struct ScriptableRenderer.RenderBlocks : IDisposable // TypeDefIndex: 5275
{
	// Fields
	private NativeArray<RenderPassEvent> m_BlockEventLimits; // 0x0
	private NativeArray<int> m_BlockRanges; // 0x10
	private NativeArray<int> m_BlockRangeLengths; // 0x20

	// Methods

	// RVA: 0x2FA64F0 Offset: 0x2FA65F1 VA: 0x2FA64F0
	public void .ctor(List<ScriptableRenderPass> activeRenderPassQueue) { }

	// RVA: 0x2FA67F0 Offset: 0x2FA68F1 VA: 0x2FA67F0 Slot: 4
	public void Dispose() { }

	// RVA: 0x2FA66D0 Offset: 0x2FA67D1 VA: 0x2FA66D0
	private void FillBlockRanges(List<ScriptableRenderPass> activeRenderPassQueue) { }

	// RVA: 0x2FA6850 Offset: 0x2FA6951 VA: 0x2FA6850
	public int GetLength(int index) { }

	// RVA: 0x2FA6860 Offset: 0x2FA6961 VA: 0x2FA6860
	public ScriptableRenderer.RenderBlocks.BlockRange GetRange(int index) { }
}

