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

