// Namespace: UnityEngine.Rendering
[UsedByNativeCodeAttribute] // RVA: 0x441000 Offset: 0x441101 VA: 0x441000
public struct ShadowDrawingSettings : IEquatable<ShadowDrawingSettings> // TypeDefIndex: 3959
{
	// Fields
	private CullingResults m_CullingResults; // 0x0
	private int m_LightIndex; // 0x10
	private int m_UseRenderingLayerMaskTest; // 0x14
	private ShadowSplitData m_SplitData; // 0x18

	// Properties
	public ShadowSplitData splitData { get; set; }

	// Methods

	// RVA: 0x31EB3C0 Offset: 0x31EB4C1 VA: 0x31EB3C0
	public ShadowSplitData get_splitData() { }

	// RVA: 0x31EB3E0 Offset: 0x31EB4E1 VA: 0x31EB3E0
	public void set_splitData(ShadowSplitData value) { }

	// RVA: 0x31EB400 Offset: 0x31EB501 VA: 0x31EB400
	public void .ctor(CullingResults cullingResults, int lightIndex) { }

	// RVA: 0x31EB580 Offset: 0x31EB681 VA: 0x31EB580 Slot: 4
	public bool Equals(ShadowDrawingSettings other) { }

	// RVA: 0x31EB780 Offset: 0x31EB881 VA: 0x31EB780 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x31EB880 Offset: 0x31EB981 VA: 0x31EB880 Slot: 2
	public override int GetHashCode() { }
}

