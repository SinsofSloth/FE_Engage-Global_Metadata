// Namespace: Combat
internal sealed class BoxCaster // TypeDefIndex: 8804
{
	// Fields
	public float BoxHalfXZ; // 0x10
	public float BoxHalfY; // 0x14
	public float BoxFlotingHeight; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x2847E0 Offset: 0x2848E1 VA: 0x2847E0
	private Vector3 <HalfBoxSize>k__BackingField; // 0x1C
	public bool IsFlying; // 0x28
	public Vector3 in_Pos0; // 0x2C
	public Vector3 in_Pos1; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x2847F0 Offset: 0x2848F1 VA: 0x2847F0
	private int <TryCount>k__BackingField; // 0x44
	public FXZ Dir2D; // 0x48
	public Vector3 WorldPos0; // 0x50
	public Vector3 WorldPos1; // 0x5C
	public Vector3 Dir3D; // 0x68
	public BoxCaster.CastResult Result0; // 0x78
	public BoxCaster.CastResult Result1; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x284800 Offset: 0x284901 VA: 0x284800
	private Color <DebugColor>k__BackingField; // 0x88

	// Properties
	public Vector3 HalfBoxSize { get; set; }
	public int TryCount { get; set; }
	public FXZ Center2D { get; }
	public Vector3 Center3D { get; }
	public Color DebugColor { get; set; }
	public FXZ Right { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2ACD90 Offset: 0x2ACE91 VA: 0x2ACD90
	// RVA: 0x2C7A6F0 Offset: 0x2C7A7F1 VA: 0x2C7A6F0
	public Vector3 get_HalfBoxSize() { }

	[CompilerGeneratedAttribute] // RVA: 0x2ACDA0 Offset: 0x2ACEA1 VA: 0x2ACDA0
	// RVA: 0x2C7A700 Offset: 0x2C7A801 VA: 0x2C7A700
	private void set_HalfBoxSize(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2ACDB0 Offset: 0x2ACEB1 VA: 0x2ACDB0
	// RVA: 0x2C7A710 Offset: 0x2C7A811 VA: 0x2C7A710
	public int get_TryCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x2ACDC0 Offset: 0x2ACEC1 VA: 0x2ACDC0
	// RVA: 0x2C7A720 Offset: 0x2C7A821 VA: 0x2C7A720
	private void set_TryCount(int value) { }

	// RVA: 0x2C7A730 Offset: 0x2C7A831 VA: 0x2C7A730
	public FXZ get_Center2D() { }

	// RVA: 0x2C7A7E0 Offset: 0x2C7A8E1 VA: 0x2C7A7E0
	public Vector3 get_Center3D() { }

	[CompilerGeneratedAttribute] // RVA: 0x2ACDD0 Offset: 0x2ACED1 VA: 0x2ACDD0
	// RVA: 0x2C7A810 Offset: 0x2C7A911 VA: 0x2C7A810
	public Color get_DebugColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2ACDE0 Offset: 0x2ACEE1 VA: 0x2ACDE0
	// RVA: 0x2C7A820 Offset: 0x2C7A921 VA: 0x2C7A820
	public void set_DebugColor(Color value) { }

	// RVA: 0x2C7A840 Offset: 0x2C7A941 VA: 0x2C7A840
	public FXZ get_Right() { }

	// RVA: 0x2C7A8A0 Offset: 0x2C7A9A1 VA: 0x2C7A8A0
	public void .ctor() { }

	// RVA: 0x2C7A910 Offset: 0x2C7AA11 VA: 0x2C7A910
	public void .ctor(Vector3 pos0) { }

	// RVA: 0x2C7A990 Offset: 0x2C7AA91 VA: 0x2C7A990
	public void .ctor(Vector3 pos0, Vector3 pos1) { }

	// RVA: 0x2C7AA20 Offset: 0x2C7AB21 VA: 0x2C7AA20
	private void MakeParams() { }

	// RVA: 0x2C7AD00 Offset: 0x2C7AE01 VA: 0x2C7AD00
	public void Cast() { }

	// RVA: 0x2C7AEF0 Offset: 0x2C7AFF1 VA: 0x2C7AEF0
	public bool CastOne(int mask, out RaycastHit hit0, out RaycastHit hit1) { }

	// RVA: 0x2C7B110 Offset: 0x2C7B211 VA: 0x2C7B110
	public bool RayCast(out RaycastHit hitInfo, int mask, float maxLength = 0) { }

	// RVA: 0x2C7B180 Offset: 0x2C7B281 VA: 0x2C7B180
	public bool WillCollide(Quaternion rotation, int mask) { }

	// RVA: 0x2C7B100 Offset: 0x2C7B201 VA: 0x2C7B100
	private void DebugCastTrajectory(Vector3 worldPos, Vector3 direction, Quaternion forward, float distance) { }

	// RVA: 0x2C7B1D0 Offset: 0x2C7B2D1 VA: 0x2C7B1D0
	public void DrawGizmos() { }

	// RVA: 0x2C7B200 Offset: 0x2C7B301 VA: 0x2C7B200
	public bool IsDividedBy(int mask) { }

	// RVA: 0x2C7ACC0 Offset: 0x2C7ADC1 VA: 0x2C7ACC0
	private void Pullup() { }

	// RVA: 0x2C7B250 Offset: 0x2C7B351 VA: 0x2C7B250 Slot: 3
	public override string ToString() { }
}

