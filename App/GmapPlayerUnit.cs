// Namespace: App
public class GmapPlayerUnit : SingletonClass<GmapPlayerUnit> // TypeDefIndex: 10311
{
	// Fields
	private Unit m_Unit; // 0x20
	private readonly string ShipPrefabPath; // 0x28
	private GameObject m_Ship; // 0x30
	private readonly string ColliderPrefabPath; // 0x38
	private readonly string TeleportInEffect; // 0x40
	private readonly string TeleportOutEffect; // 0x48
	private InterpolatorRotation m_Rotation; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x28DDA0 Offset: 0x28DEA1 VA: 0x28DDA0
	private GmapPlayerUnit.ModelType <PlayerModelType>k__BackingField; // 0x58
	private readonly string[] m_GroundObjectNames; // 0x60
	private readonly string[] SeaObjectNames; // 0x68
	private readonly string[] IgnoreObjectNames; // 0x70
	private readonly Vector3 PositionDelta; // 0x78

	// Properties
	public UnitActor Actor { get; }
	private GmapPlayerUnit.ModelType PlayerModelType { get; set; }
	public Vector3 Position { get; set; }
	public Vector3 Up { get; set; }
	private Quaternion Rotation { set; }

	// Methods

	// RVA: 0x2CE3DC0 Offset: 0x2CE3EC1 VA: 0x2CE3DC0
	public UnitActor get_Actor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD960 Offset: 0x2BDA61 VA: 0x2BD960
	// RVA: 0x2CE3DD0 Offset: 0x2CE3ED1 VA: 0x2CE3DD0
	private GmapPlayerUnit.ModelType get_PlayerModelType() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD970 Offset: 0x2BDA71 VA: 0x2BD970
	// RVA: 0x2CE3DE0 Offset: 0x2CE3EE1 VA: 0x2CE3DE0
	private void set_PlayerModelType(GmapPlayerUnit.ModelType value) { }

	// RVA: 0x2CE3DF0 Offset: 0x2CE3EF1 VA: 0x2CE3DF0 Slot: 5
	protected override void OnCreate() { }

	// RVA: 0x2CE3EE0 Offset: 0x2CE3FE1 VA: 0x2CE3EE0 Slot: 7
	protected override void OnTick() { }

	// RVA: 0x2CE4360 Offset: 0x2CE4461 VA: 0x2CE4360
	private void UpdateRotation() { }

	// RVA: 0x2CE47A0 Offset: 0x2CE48A1 VA: 0x2CE47A0
	private void CommitRotation() { }

	// RVA: 0x2CE4910 Offset: 0x2CE4A11 VA: 0x2CE4910
	public Vector3 get_Position() { }

	// RVA: 0x2CE4940 Offset: 0x2CE4A41 VA: 0x2CE4940
	public void set_Position(Vector3 value) { }

	// RVA: 0x2CE49C0 Offset: 0x2CE4AC1 VA: 0x2CE49C0
	public Vector3 get_Up() { }

	// RVA: 0x2CE49F0 Offset: 0x2CE4AF1 VA: 0x2CE49F0
	public void set_Up(Vector3 value) { }

	// RVA: 0x2CE4880 Offset: 0x2CE4981 VA: 0x2CE4880
	private void set_Rotation(Quaternion value) { }

	// RVA: 0x2CE4A70 Offset: 0x2CE4B71 VA: 0x2CE4A70
	public void SetDirection(Vector3 dir, Vector3 up) { }

	// RVA: 0x2CE4D60 Offset: 0x2CE4E61 VA: 0x2CE4D60
	public void SetRotate(float angle) { }

	// RVA: 0x2CE4E20 Offset: 0x2CE4F21 VA: 0x2CE4E20
	public void SetRotateImmidiate(float angle) { }

	// RVA: 0x2CE4E00 Offset: 0x2CE4F01 VA: 0x2CE4E00
	private static float GetAngleLength(float current, float target) { }

	// RVA: 0x2CE3E00 Offset: 0x2CE3F01 VA: 0x2CE3E00
	private void SetUnitFromUnitPool() { }

	// RVA: 0x2CE4E60 Offset: 0x2CE4F61 VA: 0x2CE4E60
	public void LoadActor() { }

	// RVA: 0x2CE5040 Offset: 0x2CE5141 VA: 0x2CE5040
	public bool IsLoading() { }

	// RVA: 0x2CE5180 Offset: 0x2CE5281 VA: 0x2CE5180
	public void UnloadUnit() { }

	// RVA: 0x2CE5270 Offset: 0x2CE5371 VA: 0x2CE5270
	public void Setup() { }

	// RVA: 0x2CE54F0 Offset: 0x2CE55F1 VA: 0x2CE54F0
	public void SetupModelType() { }

	// RVA: 0x2CE4240 Offset: 0x2CE4341 VA: 0x2CE4240
	private void ChangeModelType(GmapPlayerUnit.ModelType modelType) { }

	// RVA: 0x2CE4CB0 Offset: 0x2CE4DB1 VA: 0x2CE4CB0
	public void StopRun() { }

	// RVA: 0x2CE5520 Offset: 0x2CE5621 VA: 0x2CE5520
	private void Hide() { }

	// RVA: 0x2CE55B0 Offset: 0x2CE56B1 VA: 0x2CE55B0
	private void Show() { }

	// RVA: 0x2CE5330 Offset: 0x2CE5431 VA: 0x2CE5330
	private void SetMapTransparent(bool active) { }

	// RVA: 0x2CE3F80 Offset: 0x2CE4081 VA: 0x2CE3F80
	public bool IsOnGround() { }

	// RVA: 0x2CE55E0 Offset: 0x2CE56E1 VA: 0x2CE55E0
	public void PlayTeleportOut() { }

	// RVA: 0x2CE5700 Offset: 0x2CE5801 VA: 0x2CE5700
	public void PlayTeleportIn() { }

	// RVA: 0x2CE57C0 Offset: 0x2CE58C1 VA: 0x2CE57C0
	public void .ctor() { }
}

