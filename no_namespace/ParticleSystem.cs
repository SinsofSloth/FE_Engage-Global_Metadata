// Namespace: 
public struct ParticleSystem.EmissionModule // TypeDefIndex: 4794
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Properties
	public bool enabled { get; set; }
	public ParticleSystem.MinMaxCurve rateOverTime { set; }
	public float rateOverTimeMultiplier { get; }

	// Methods

	// RVA: 0x1C336A0 Offset: 0x1C337A1 VA: 0x1C336A0
	internal void .ctor(ParticleSystem particleSystem) { }

	// RVA: 0x1C30160 Offset: 0x1C30261 VA: 0x1C30160
	public bool get_enabled() { }

	[NativeThrowsAttribute] // RVA: 0x50570 Offset: 0x50671 VA: 0x50570
	// RVA: 0x1C30220 Offset: 0x1C30321 VA: 0x1C30220
	public void set_enabled(bool value) { }

	[NativeThrowsAttribute] // RVA: 0x50580 Offset: 0x50681 VA: 0x50580
	// RVA: 0x1C30460 Offset: 0x1C30561 VA: 0x1C30460
	public void set_rateOverTime(ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x1C302D0 Offset: 0x1C303D1 VA: 0x1C302D0
	public float get_rateOverTimeMultiplier() { }

	// RVA: 0x1C36B20 Offset: 0x1C36C21 VA: 0x1C36B20
	private static bool get_enabled_Injected(ref ParticleSystem.EmissionModule _unity_self) { }

	// RVA: 0x1C36B70 Offset: 0x1C36C71 VA: 0x1C36B70
	private static void set_enabled_Injected(ref ParticleSystem.EmissionModule _unity_self, bool value) { }

	// RVA: 0x1C36BC0 Offset: 0x1C36CC1 VA: 0x1C36BC0
	private static void set_rateOverTime_Injected(ref ParticleSystem.EmissionModule _unity_self, ref ParticleSystem.MinMaxCurve value) { }

	// RVA: 0x1C36C10 Offset: 0x1C36D11 VA: 0x1C36C10
	private static float get_rateOverTimeMultiplier_Injected(ref ParticleSystem.EmissionModule _unity_self) { }
}

// Namespace: 
public struct ParticleSystem.CollisionModule // TypeDefIndex: 4796
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x1C33A60 Offset: 0x1C33B61 VA: 0x1C33A60
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
public struct ParticleSystem.SubEmittersModule // TypeDefIndex: 4798
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x1C33AE0 Offset: 0x1C33BE1 VA: 0x1C33AE0
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
[RequiredByNativeCodeAttribute] // RVA: 0x4EF90 Offset: 0x4F091 VA: 0x4EF90
public struct ParticleSystem.Particle // TypeDefIndex: 4800
{
	// Fields
	private Vector3 m_Position; // 0x0
	private Vector3 m_Velocity; // 0xC
	private Vector3 m_AnimatedVelocity; // 0x18
	private Vector3 m_InitialVelocity; // 0x24
	private Vector3 m_AxisOfRotation; // 0x30
	private Vector3 m_Rotation; // 0x3C
	private Vector3 m_AngularVelocity; // 0x48
	private Vector3 m_StartSize; // 0x54
	private Color32 m_StartColor; // 0x60
	private uint m_RandomSeed; // 0x64
	private uint m_ParentRandomSeed; // 0x68
	private float m_Lifetime; // 0x6C
	private float m_StartLifetime; // 0x70
	private int m_MeshIndex; // 0x74
	private float m_EmitAccumulator0; // 0x78
	private float m_EmitAccumulator1; // 0x7C
	private uint m_Flags; // 0x80

	// Properties
	[ObsoleteAttribute] // RVA: 0x51470 Offset: 0x51571 VA: 0x51470
	public float lifetime { set; }
	public Vector3 position { set; }
	public Vector3 velocity { set; }
	public float remainingLifetime { set; }
	public float startLifetime { set; }
	public Color32 startColor { set; }
	public uint randomSeed { set; }
	public float startSize { set; }
	public float rotation { set; }
	public Vector3 rotation3D { set; }
	public Vector3 angularVelocity3D { set; }

	// Methods

	// RVA: 0x1C2F8C0 Offset: 0x1C2F9C1 VA: 0x1C2F8C0
	public void set_lifetime(float value) { }

	// RVA: 0x1C2F8A0 Offset: 0x1C2F9A1 VA: 0x1C2F8A0
	public void set_position(Vector3 value) { }

	// RVA: 0x1C2F8B0 Offset: 0x1C2F9B1 VA: 0x1C2F8B0
	public void set_velocity(Vector3 value) { }

	// RVA: 0x1C37AB0 Offset: 0x1C37BB1 VA: 0x1C37AB0
	public void set_remainingLifetime(float value) { }

	// RVA: 0x1C2F8D0 Offset: 0x1C2F9D1 VA: 0x1C2F8D0
	public void set_startLifetime(float value) { }

	// RVA: 0x1C2F970 Offset: 0x1C2FA71 VA: 0x1C2F970
	public void set_startColor(Color32 value) { }

	// RVA: 0x1C2F980 Offset: 0x1C2FA81 VA: 0x1C2F980
	public void set_randomSeed(uint value) { }

	// RVA: 0x1C2F8E0 Offset: 0x1C2F9E1 VA: 0x1C2F8E0
	public void set_startSize(float value) { }

	// RVA: 0x1C37AC0 Offset: 0x1C37BC1 VA: 0x1C37AC0
	public void set_rotation(float value) { }

	// RVA: 0x1C2F8F0 Offset: 0x1C2F9F1 VA: 0x1C2F8F0
	public void set_rotation3D(Vector3 value) { }

	// RVA: 0x1C2F930 Offset: 0x1C2FA31 VA: 0x1C2F930
	public void set_angularVelocity3D(Vector3 value) { }
}

// Namespace: 
[NativeTypeAttribute] // RVA: 0x4F040 Offset: 0x4F141 VA: 0x4F040
[Serializable]
public struct ParticleSystem.MinMaxGradient // TypeDefIndex: 4802
{
	// Fields
	[SerializeField] // RVA: 0x4F3A0 Offset: 0x4F4A1 VA: 0x4F3A0
	private ParticleSystemGradientMode m_Mode; // 0x0
	[SerializeField] // RVA: 0x4F3B0 Offset: 0x4F4B1 VA: 0x4F3B0
	private Gradient m_GradientMin; // 0x8
	[SerializeField] // RVA: 0x4F3C0 Offset: 0x4F4C1 VA: 0x4F3C0
	private Gradient m_GradientMax; // 0x10
	[SerializeField] // RVA: 0x4F3D0 Offset: 0x4F4D1 VA: 0x4F3D0
	private Color m_ColorMin; // 0x18
	[SerializeField] // RVA: 0x4F3E0 Offset: 0x4F4E1 VA: 0x4F3E0
	private Color m_ColorMax; // 0x28

	// Properties
	public Color color { get; }

	// Methods

	// RVA: 0x1C37A20 Offset: 0x1C37B21 VA: 0x1C37A20
	public void .ctor(Color color) { }

	// RVA: 0x1C308A0 Offset: 0x1C309A1 VA: 0x1C308A0
	public Color get_color() { }

	// RVA: 0x1C309A0 Offset: 0x1C30AA1 VA: 0x1C309A0
	public static ParticleSystem.MinMaxGradient op_Implicit(Color color) { }
}

// Namespace: 
internal struct ParticleSystem.PlaybackState.Seed // TypeDefIndex: 4804
{
	// Fields
	public uint x; // 0x0
	public uint y; // 0x4
	public uint z; // 0x8
	public uint w; // 0xC
}

// Namespace: 
internal struct ParticleSystem.PlaybackState.Emission // TypeDefIndex: 4806
{
	// Fields
	public float m_ParticleSpacing; // 0x0
	public float m_ToEmitAccumulator; // 0x4
	public ParticleSystem.PlaybackState.Seed m_Random; // 0x8
}

// Namespace: 
internal struct ParticleSystem.PlaybackState.Shape // TypeDefIndex: 4808
{
	// Fields
	public ParticleSystem.PlaybackState.Seed4 m_Random; // 0x0
	public float m_RadiusTimer; // 0x40
	public float m_RadiusTimerPrev; // 0x44
	public float m_ArcTimer; // 0x48
	public float m_ArcTimerPrev; // 0x4C
	public float m_MeshSpawnTimer; // 0x50
	public float m_MeshSpawnTimerPrev; // 0x54
	public int m_OrderedMeshVertexIndex; // 0x58
}

// Namespace: 
internal struct ParticleSystem.PlaybackState.Collision // TypeDefIndex: 4810
{
	// Fields
	public ParticleSystem.PlaybackState.Seed4 m_Random; // 0x0
}

// Namespace: 
internal struct ParticleSystem.PlaybackState.Lights // TypeDefIndex: 4812
{
	// Fields
	public ParticleSystem.PlaybackState.Seed m_Random; // 0x0
	public float m_ParticleEmissionCounter; // 0x10
}

// Namespace: 
public struct ParticleSystem.PlaybackState // TypeDefIndex: 4814
{
	// Fields
	internal float m_AccumulatedDt; // 0x0
	internal float m_StartDelay; // 0x4
	internal float m_PlaybackTime; // 0x8
	internal int m_RingBufferIndex; // 0xC
	internal ParticleSystem.PlaybackState.Emission m_Emission; // 0x10
	internal ParticleSystem.PlaybackState.Initial m_Initial; // 0x28
	internal ParticleSystem.PlaybackState.Shape m_Shape; // 0x68
	internal ParticleSystem.PlaybackState.Force m_Force; // 0xC4
	internal ParticleSystem.PlaybackState.Collision m_Collision; // 0x104
	internal ParticleSystem.PlaybackState.Noise m_Noise; // 0x144
	internal ParticleSystem.PlaybackState.Lights m_Lights; // 0x148
	internal ParticleSystem.PlaybackState.Trail m_Trail; // 0x15C
}

// Namespace: 
public struct ParticleSystem.VelocityOverLifetimeModule // TypeDefIndex: 4816
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x1C33720 Offset: 0x1C33821 VA: 0x1C33720
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
public struct ParticleSystem.InheritVelocityModule // TypeDefIndex: 4818
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x1C337A0 Offset: 0x1C338A1 VA: 0x1C337A0
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
public struct ParticleSystem.ForceOverLifetimeModule // TypeDefIndex: 4820
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x1C33820 Offset: 0x1C33921 VA: 0x1C33820
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
public struct ParticleSystem.ColorBySpeedModule // TypeDefIndex: 4822
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x1C338A0 Offset: 0x1C339A1 VA: 0x1C338A0
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
public struct ParticleSystem.SizeBySpeedModule // TypeDefIndex: 4824
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x1C33920 Offset: 0x1C33A21 VA: 0x1C33920
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
public struct ParticleSystem.RotationBySpeedModule // TypeDefIndex: 4826
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x1C339A0 Offset: 0x1C33AA1 VA: 0x1C339A0
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
public struct ParticleSystem.NoiseModule // TypeDefIndex: 4828
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x1C33A20 Offset: 0x1C33B21 VA: 0x1C33A20
	internal void .ctor(ParticleSystem particleSystem) { }
}

// Namespace: 
public struct ParticleSystem.TrailModule // TypeDefIndex: 4830
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x0

	// Methods

	// RVA: 0x1C33BA0 Offset: 0x1C33CA1 VA: 0x1C33BA0
	internal void .ctor(ParticleSystem particleSystem) { }
}

