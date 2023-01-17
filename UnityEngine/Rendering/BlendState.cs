// Namespace: UnityEngine.Rendering
public struct BlendState : IEquatable<BlendState> // TypeDefIndex: 3928
{
	// Fields
	private RenderTargetBlendState m_BlendState0; // 0x0
	private RenderTargetBlendState m_BlendState1; // 0x8
	private RenderTargetBlendState m_BlendState2; // 0x10
	private RenderTargetBlendState m_BlendState3; // 0x18
	private RenderTargetBlendState m_BlendState4; // 0x20
	private RenderTargetBlendState m_BlendState5; // 0x28
	private RenderTargetBlendState m_BlendState6; // 0x30
	private RenderTargetBlendState m_BlendState7; // 0x38
	private byte m_SeparateMRTBlendStates; // 0x40
	private byte m_AlphaToMask; // 0x41
	private short m_Padding; // 0x42

	// Properties
	public static BlendState defaultValue { get; }

	// Methods

	// RVA: 0x2F0BD00 Offset: 0x2F0BE01 VA: 0x2F0BD00
	public static BlendState get_defaultValue() { }

	// RVA: 0x2F0BDB0 Offset: 0x2F0BEB1 VA: 0x2F0BDB0
	public void .ctor(bool separateMRTBlend = False, bool alphaToMask = False) { }

	// RVA: 0x2F0BEB0 Offset: 0x2F0BFB1 VA: 0x2F0BEB0 Slot: 4
	public bool Equals(BlendState other) { }

	// RVA: 0x2F0BFA0 Offset: 0x2F0C0A1 VA: 0x2F0BFA0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2F0C060 Offset: 0x2F0C161 VA: 0x2F0C060 Slot: 2
	public override int GetHashCode() { }
}

