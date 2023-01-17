// Namespace: UnityEngine.Rendering
public struct RenderTargetIdentifier : IEquatable<RenderTargetIdentifier> // TypeDefIndex: 3899
{
	// Fields
	public const int AllDepthSlices = -1;
	private BuiltinRenderTextureType m_Type; // 0x0
	private int m_NameID; // 0x4
	private int m_InstanceID; // 0x8
	private IntPtr m_BufferPointer; // 0x10
	private int m_MipLevel; // 0x18
	private CubemapFace m_CubeFace; // 0x1C
	private int m_DepthSlice; // 0x20

	// Methods

	// RVA: 0x31DBCE0 Offset: 0x31DBDE1 VA: 0x31DBCE0
	public void .ctor(BuiltinRenderTextureType type) { }

	// RVA: 0x31DBD40 Offset: 0x31DBE41 VA: 0x31DBD40
	public void .ctor(int nameID) { }

	// RVA: 0x31DBDA0 Offset: 0x31DBEA1 VA: 0x31DBDA0
	public void .ctor(int nameID, int mipLevel = 0, CubemapFace cubeFace = -1, int depthSlice = 0) { }

	// RVA: 0x31DBE20 Offset: 0x31DBF21 VA: 0x31DBE20
	public void .ctor(RenderTargetIdentifier renderTargetIdentifier, int mipLevel, CubemapFace cubeFace = -1, int depthSlice = 0) { }

	// RVA: 0x31DBE50 Offset: 0x31DBF51 VA: 0x31DBE50
	public void .ctor(Texture tex) { }

	// RVA: 0x31DBFA0 Offset: 0x31DC0A1 VA: 0x31DBFA0
	public void .ctor(Texture tex, int mipLevel = 0, CubemapFace cubeFace = -1, int depthSlice = 0) { }

	// RVA: 0x31DC100 Offset: 0x31DC201 VA: 0x31DC100
	public static RenderTargetIdentifier op_Implicit(BuiltinRenderTextureType type) { }

	// RVA: 0x31DC170 Offset: 0x31DC271 VA: 0x31DC170
	public static RenderTargetIdentifier op_Implicit(int nameID) { }

	// RVA: 0x31DC1D0 Offset: 0x31DC2D1 VA: 0x31DC1D0
	public static RenderTargetIdentifier op_Implicit(Texture tex) { }

	// RVA: 0x31DC240 Offset: 0x31DC341 VA: 0x31DC240 Slot: 3
	public override string ToString() { }

	// RVA: 0x31DC550 Offset: 0x31DC651 VA: 0x31DC550 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x31DC5B0 Offset: 0x31DC6B1 VA: 0x31DC5B0 Slot: 4
	public bool Equals(RenderTargetIdentifier rhs) { }

	// RVA: 0x31DC660 Offset: 0x31DC761 VA: 0x31DC660 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x31DC750 Offset: 0x31DC851 VA: 0x31DC750
	public static bool op_Equality(RenderTargetIdentifier lhs, RenderTargetIdentifier rhs) { }

	// RVA: 0x31DC800 Offset: 0x31DC901 VA: 0x31DC800
	public static bool op_Inequality(RenderTargetIdentifier lhs, RenderTargetIdentifier rhs) { }
}

