// Namespace: Combat
public sealed class TrailVertexSupplier // TypeDefIndex: 8868
{
	// Fields
	private const int NumElements = 256;
	private const float MaxBufferingDuration = 0.33333334;
	private const float DecayRate = -6;
	private Character CP; // 0x10
	private TrailTrack m_Track; // 0x18
	private float m_ClipLength; // 0x20
	private TrailVertex[] m_Vertices; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x284AC0 Offset: 0x284BC1 VA: 0x284AC0
	private float <Alpha>k__BackingField; // 0x30
	private float m_DeltaAlpha; // 0x34
	public Vector3 m_WeaponRootOffset; // 0x38
	public Vector3 m_WeaponTipOffset; // 0x44
	private int m_HandIndex; // 0x50
	private Transform m_HandTransform; // 0x58
	private float m_ElapsedTime; // 0x60

	// Properties
	public float Alpha { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2AD860 Offset: 0x2AD961 VA: 0x2AD860
	// RVA: 0x286FC50 Offset: 0x286FD51 VA: 0x286FC50
	public float get_Alpha() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD870 Offset: 0x2AD971 VA: 0x2AD870
	// RVA: 0x286FC60 Offset: 0x286FD61 VA: 0x286FC60
	private void set_Alpha(float value) { }

	// RVA: 0x286FC70 Offset: 0x286FD71 VA: 0x286FC70
	public void Clear() { }

	// RVA: 0x286FD00 Offset: 0x286FE01 VA: 0x286FD00
	public void .ctor(Character chr, int hand) { }

	// RVA: 0x286FFA0 Offset: 0x28700A1 VA: 0x286FFA0
	private void SetupWeaponLengthOffset() { }

	// RVA: 0x2870200 Offset: 0x2870301 VA: 0x2870200
	public void Update(float dt, in Vector3 in_rootPos, in Vector3 in_tipPos) { }

	// RVA: 0x28705F0 Offset: 0x28706F1 VA: 0x28705F0
	public void SendToMesh(Vector3[] PosR, Vector3[] PosT) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD880 Offset: 0x2AD981 VA: 0x2AD880
	// RVA: 0x2870730 Offset: 0x2870831 VA: 0x2870730
	private void <.ctor>b__18_0(Character chr_) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD890 Offset: 0x2AD991 VA: 0x2AD890
	// RVA: 0x2870750 Offset: 0x2870851 VA: 0x2870750
	private void <.ctor>b__18_1(Character _) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD8A0 Offset: 0x2AD9A1 VA: 0x2AD8A0
	// RVA: 0x2870760 Offset: 0x2870861 VA: 0x2870760
	private void <.ctor>b__18_2(int _) { }
}

