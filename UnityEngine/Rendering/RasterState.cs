// Namespace: UnityEngine.Rendering
public struct RasterState : IEquatable<RasterState> // TypeDefIndex: 3948
{
	// Fields
	public static readonly RasterState defaultValue; // 0x0
	private CullMode m_CullingMode; // 0x0
	private int m_OffsetUnits; // 0x4
	private float m_OffsetFactor; // 0x8
	private byte m_DepthClip; // 0xC
	private byte m_Conservative; // 0xD
	private byte m_Padding1; // 0xE
	private byte m_Padding2; // 0xF

	// Methods

	// RVA: 0x31D1D20 Offset: 0x31D1E21 VA: 0x31D1D20
	public void .ctor(CullMode cullingMode = 2, int offsetUnits = 0, float offsetFactor = 0, bool depthClip = True) { }

	// RVA: 0x31D1DD0 Offset: 0x31D1ED1 VA: 0x31D1DD0 Slot: 4
	public bool Equals(RasterState other) { }

	// RVA: 0x31D1E50 Offset: 0x31D1F51 VA: 0x31D1E50 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x31D1F30 Offset: 0x31D2031 VA: 0x31D1F30 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x31D1FA0 Offset: 0x31D20A1 VA: 0x31D1FA0
	private static void .cctor() { }
}

