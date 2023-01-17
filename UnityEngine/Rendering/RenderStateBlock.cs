// Namespace: UnityEngine.Rendering
public struct RenderStateBlock : IEquatable<RenderStateBlock> // TypeDefIndex: 3954
{
	// Fields
	private BlendState m_BlendState; // 0x0
	private RasterState m_RasterState; // 0x44
	private DepthState m_DepthState; // 0x54
	private StencilState m_StencilState; // 0x56
	private int m_StencilReference; // 0x64
	private RenderStateMask m_Mask; // 0x68

	// Properties
	public DepthState depthState { set; }
	public StencilState stencilState { get; set; }
	public int stencilReference { get; set; }
	public RenderStateMask mask { get; set; }

	// Methods

	// RVA: 0x31DB340 Offset: 0x31DB441 VA: 0x31DB340
	public void .ctor(RenderStateMask mask) { }

	// RVA: 0x31DB520 Offset: 0x31DB621 VA: 0x31DB520
	public void set_depthState(DepthState value) { }

	// RVA: 0x31DB530 Offset: 0x31DB631 VA: 0x31DB530
	public StencilState get_stencilState() { }

	// RVA: 0x31DB540 Offset: 0x31DB641 VA: 0x31DB540
	public void set_stencilState(StencilState value) { }

	// RVA: 0x31DB550 Offset: 0x31DB651 VA: 0x31DB550
	public int get_stencilReference() { }

	// RVA: 0x31DB560 Offset: 0x31DB661 VA: 0x31DB560
	public void set_stencilReference(int value) { }

	// RVA: 0x31DB570 Offset: 0x31DB671 VA: 0x31DB570
	public RenderStateMask get_mask() { }

	// RVA: 0x31DB580 Offset: 0x31DB681 VA: 0x31DB580
	public void set_mask(RenderStateMask value) { }

	// RVA: 0x31DB590 Offset: 0x31DB691 VA: 0x31DB590 Slot: 4
	public bool Equals(RenderStateBlock other) { }

	// RVA: 0x31DB7F0 Offset: 0x31DB8F1 VA: 0x31DB7F0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x31DB8C0 Offset: 0x31DB9C1 VA: 0x31DB8C0 Slot: 2
	public override int GetHashCode() { }
}

