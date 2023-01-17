// Namespace: UnityEngine.Rendering
public struct RenderTargetBlendState : IEquatable<RenderTargetBlendState> // TypeDefIndex: 3956
{
	// Fields
	private byte m_WriteMask; // 0x0
	private byte m_SourceColorBlendMode; // 0x1
	private byte m_DestinationColorBlendMode; // 0x2
	private byte m_SourceAlphaBlendMode; // 0x3
	private byte m_DestinationAlphaBlendMode; // 0x4
	private byte m_ColorBlendOperation; // 0x5
	private byte m_AlphaBlendOperation; // 0x6
	private byte m_Padding; // 0x7

	// Properties
	public static RenderTargetBlendState defaultValue { get; }

	// Methods

	// RVA: 0x31DBA80 Offset: 0x31DBB81 VA: 0x31DBA80
	public static RenderTargetBlendState get_defaultValue() { }

	// RVA: 0x31DBA90 Offset: 0x31DBB91 VA: 0x31DBA90
	public void .ctor(ColorWriteMask writeMask = 15, BlendMode sourceColorBlendMode = 1, BlendMode destinationColorBlendMode = 0, BlendMode sourceAlphaBlendMode = 1, BlendMode destinationAlphaBlendMode = 0, BlendOp colorBlendOperation = 0, BlendOp alphaBlendOperation = 0) { }

	// RVA: 0x31DBAC0 Offset: 0x31DBBC1 VA: 0x31DBAC0 Slot: 4
	public bool Equals(RenderTargetBlendState other) { }

	// RVA: 0x31DBB40 Offset: 0x31DBC41 VA: 0x31DBB40 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x31DBC30 Offset: 0x31DBD31 VA: 0x31DBC30 Slot: 2
	public override int GetHashCode() { }
}

