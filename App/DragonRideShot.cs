// Namespace: App
public abstract class DragonRideShot : MonoBehaviour // TypeDefIndex: 10534
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x28F4A0 Offset: 0x28F5A1 VA: 0x28F4A0
	private float <EraseSecond>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x28F4B0 Offset: 0x28F5B1 VA: 0x28F4B0
	private float <ShotSpeed>k__BackingField; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x28F4C0 Offset: 0x28F5C1 VA: 0x28F4C0
	private bool <IsInitialized>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x28F4D0 Offset: 0x28F5D1 VA: 0x28F4D0
	private Vector3 <StraightVector>k__BackingField; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x28F4E0 Offset: 0x28F5E1 VA: 0x28F4E0
	private Vector3 <FirstVector>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x28F4F0 Offset: 0x28F5F1 VA: 0x28F4F0
	private Vector3 <DiffVector>k__BackingField; // 0x3C
	[CompilerGeneratedAttribute] // RVA: 0x28F500 Offset: 0x28F601 VA: 0x28F500
	private float <InterpStraightSecond>k__BackingField; // 0x48
	private Vector3 m_PrePosition; // 0x4C
	private bool m_IsAssist; // 0x58
	private bool m_IsPenetrate; // 0x59
	private bool m_IsSpecialShot; // 0x5A
	private bool m_IsMaximumAssist; // 0x5B
	private bool m_IsDestroy; // 0x5C
	private InterpolatorFloat m_DiffInterp; // 0x60
	private GameObject m_Effect; // 0x68
	private Vector3[] m_CheckRayPoint; // 0x70
	private Ray m_HitCheckRay; // 0x78
	private float m_LifeTimer; // 0x90

	// Properties
	public float EraseSecond { get; set; }
	public float ShotSpeed { get; set; }
	private bool IsInitialized { get; set; }
	public Vector3 StraightVector { get; set; }
	public Vector3 FirstVector { get; set; }
	public Vector3 DiffVector { get; set; }
	public float InterpStraightSecond { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2BF0A0 Offset: 0x2BF1A1 VA: 0x2BF0A0
	// RVA: 0x2DD6F60 Offset: 0x2DD7061 VA: 0x2DD6F60
	public float get_EraseSecond() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF0B0 Offset: 0x2BF1B1 VA: 0x2BF0B0
	// RVA: 0x2DD6F70 Offset: 0x2DD7071 VA: 0x2DD6F70
	public void set_EraseSecond(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF0C0 Offset: 0x2BF1C1 VA: 0x2BF0C0
	// RVA: 0x2DD6F80 Offset: 0x2DD7081 VA: 0x2DD6F80
	public float get_ShotSpeed() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF0D0 Offset: 0x2BF1D1 VA: 0x2BF0D0
	// RVA: 0x2DD6F90 Offset: 0x2DD7091 VA: 0x2DD6F90
	public void set_ShotSpeed(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF0E0 Offset: 0x2BF1E1 VA: 0x2BF0E0
	// RVA: 0x2DD6FA0 Offset: 0x2DD70A1 VA: 0x2DD6FA0
	private bool get_IsInitialized() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF0F0 Offset: 0x2BF1F1 VA: 0x2BF0F0
	// RVA: 0x2DD6FB0 Offset: 0x2DD70B1 VA: 0x2DD6FB0
	private void set_IsInitialized(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF100 Offset: 0x2BF201 VA: 0x2BF100
	// RVA: 0x2DD6FC0 Offset: 0x2DD70C1 VA: 0x2DD6FC0
	public Vector3 get_StraightVector() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF110 Offset: 0x2BF211 VA: 0x2BF110
	// RVA: 0x2DD6FD0 Offset: 0x2DD70D1 VA: 0x2DD6FD0
	public void set_StraightVector(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF120 Offset: 0x2BF221 VA: 0x2BF120
	// RVA: 0x2DD6FE0 Offset: 0x2DD70E1 VA: 0x2DD6FE0
	public Vector3 get_FirstVector() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF130 Offset: 0x2BF231 VA: 0x2BF130
	// RVA: 0x2DD6FF0 Offset: 0x2DD70F1 VA: 0x2DD6FF0
	public void set_FirstVector(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF140 Offset: 0x2BF241 VA: 0x2BF140
	// RVA: 0x2DD7000 Offset: 0x2DD7101 VA: 0x2DD7000
	public Vector3 get_DiffVector() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF150 Offset: 0x2BF251 VA: 0x2BF150
	// RVA: 0x2DD7010 Offset: 0x2DD7111 VA: 0x2DD7010
	public void set_DiffVector(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF160 Offset: 0x2BF261 VA: 0x2BF160
	// RVA: 0x2DD7020 Offset: 0x2DD7121 VA: 0x2DD7020
	public float get_InterpStraightSecond() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF170 Offset: 0x2BF271 VA: 0x2BF170
	// RVA: 0x2DD7030 Offset: 0x2DD7131 VA: 0x2DD7030
	public void set_InterpStraightSecond(float value) { }

	// RVA: 0x2DD7040 Offset: 0x2DD7141 VA: 0x2DD7040
	public void Initialize(bool isAssist, bool isSpecial, bool isPenetrate, bool isMaximum = False) { }

	// RVA: 0x2DD7450 Offset: 0x2DD7551 VA: 0x2DD7450
	public void PostUpdate() { }

	// RVA: 0x2DD7C80 Offset: 0x2DD7D81 VA: 0x2DD7C80
	private void OnTriggerEnter(Collider collision) { }

	// RVA: 0x2DD7C90 Offset: 0x2DD7D91 VA: 0x2DD7C90
	public void CallReset() { }

	// RVA: 0x2DD7D90 Offset: 0x2DD7E91 VA: 0x2DD7D90
	private void Update() { }

	// RVA: 0x2DD7DA0 Offset: 0x2DD7EA1 VA: 0x2DD7DA0
	protected void .ctor() { }
}

