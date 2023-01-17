// Namespace: UnityEngine.Rendering
public struct FilteringSettings : IEquatable<FilteringSettings> // TypeDefIndex: 3944
{
	// Fields
	private RenderQueueRange m_RenderQueueRange; // 0x0
	private int m_LayerMask; // 0x8
	private uint m_RenderingLayerMask; // 0xC
	private int m_ExcludeMotionVectorObjects; // 0x10
	private SortingLayerRange m_SortingLayerRange; // 0x14

	// Properties
	public RenderQueueRange renderQueueRange { set; }
	public int layerMask { set; }
	public uint renderingLayerMask { set; }
	public bool excludeMotionVectorObjects { set; }
	public SortingLayerRange sortingLayerRange { set; }

	// Methods

	// RVA: 0x2F21AB0 Offset: 0x2F21BB1 VA: 0x2F21AB0
	public void .ctor(Nullable<RenderQueueRange> renderQueueRange, int layerMask = -1, uint renderingLayerMask = 4294967295, int excludeMotionVectorObjects = 0) { }

	// RVA: 0x2F21B90 Offset: 0x2F21C91 VA: 0x2F21B90
	public void set_renderQueueRange(RenderQueueRange value) { }

	// RVA: 0x2F21BA0 Offset: 0x2F21CA1 VA: 0x2F21BA0
	public void set_layerMask(int value) { }

	// RVA: 0x2F21BB0 Offset: 0x2F21CB1 VA: 0x2F21BB0
	public void set_renderingLayerMask(uint value) { }

	// RVA: 0x2F21BC0 Offset: 0x2F21CC1 VA: 0x2F21BC0
	public void set_excludeMotionVectorObjects(bool value) { }

	// RVA: 0x2F21BD0 Offset: 0x2F21CD1 VA: 0x2F21BD0
	public void set_sortingLayerRange(SortingLayerRange value) { }

	// RVA: 0x2F21BE0 Offset: 0x2F21CE1 VA: 0x2F21BE0 Slot: 4
	public bool Equals(FilteringSettings other) { }

	// RVA: 0x2F21C50 Offset: 0x2F21D51 VA: 0x2F21C50 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2F21D10 Offset: 0x2F21E11 VA: 0x2F21D10 Slot: 2
	public override int GetHashCode() { }
}

