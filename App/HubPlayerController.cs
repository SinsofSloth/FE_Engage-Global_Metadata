// Namespace: App
public class HubPlayerController // TypeDefIndex: 10778
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x2950D0 Offset: 0x2951D1 VA: 0x2950D0
	private float <Dir>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x2950E0 Offset: 0x2951E1 VA: 0x2950E0
	private float <PrevDir>k__BackingField; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x2950F0 Offset: 0x2951F1 VA: 0x2950F0
	private float <ZRotate>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x295100 Offset: 0x295201 VA: 0x295100
	private bool <IsStop>k__BackingField; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x295110 Offset: 0x295211 VA: 0x295110
	private Character <Character>k__BackingField; // 0x20
	private GameObject m_PlayerRoot; // 0x28
	private GameObject m_PlayerCollider; // 0x30
	private GameObject m_GroupRoot; // 0x38
	private GameObject m_Camera; // 0x40
	private GameObject m_ButtonNavi; // 0x48
	private HubLookAtController m_LookAt; // 0x50
	private HubUnitController m_UnitController; // 0x58
	private List<Collider> m_Colliders; // 0x60
	private HubCamera m_HubCamera; // 0x68
	private HubAccess m_LastAccess; // 0x70
	private Animator m_Animator; // 0x78
	private CharacterJoint[] m_CharacterJoints; // 0x80
	private LookAtIK[] m_LookAtIKs; // 0x88
	private float m_Speed; // 0x90
	private Vector3 m_MoveTarget; // 0x94
	private Vector3 m_MoveDirection; // 0xA0
	private bool m_DashStop; // 0xAC
	private float m_DashStopTime; // 0xB0
	private float m_DashStopDelay; // 0xB4
	private float m_DashTime; // 0xB8
	private float m_TimeWithNoTarget; // 0xBC
	private string m_QuickTurnAnimName; // 0xC0
	private float m_AccessDelay; // 0xC8
	private HubCullingPlayerCollider m_CullingCollider; // 0xD0
	private GrassManager[] m_GrassManagers; // 0xD8
	private int ObjectCollisionLayerMask; // 0xE0
	private int GroundCollisionLayerMask; // 0xE4
	private int SlopeCollisionLayerMask; // 0xE8
	[CompilerGeneratedAttribute] // RVA: 0x295120 Offset: 0x295221 VA: 0x295120
	private readonly float <DefaultRadius>k__BackingField; // 0xEC
	private int m_hash; // 0xF0
	[CompilerGeneratedAttribute] // RVA: 0x295130 Offset: 0x295231 VA: 0x295130
	private bool <IsCharacterLoading>k__BackingField; // 0xF4
	private RaycastHit[] results; // 0xF8
	private Collider[] overlapColliders; // 0x100
	private Collider[] accessColliders; // 0x108
	private Collider accessCollider; // 0x110
	private float distanceSpeed; // 0x118
	private Coroutine m_procIdleCoroutin; // 0x120
	private bool m_enableProc; // 0x128
	private float m_WallInterval; // 0x12C

	// Properties
	public float Dir { get; set; }
	public float PrevDir { get; set; }
	public float ZRotate { get; set; }
	public bool IsStop { get; set; }
	public float Speed { get; set; }
	public Character Character { get; set; }
	public HubUnitController UnitController { get; }
	public HubCullingPlayerCollider CullingCollider { get; }
	public int ControlType { get; }
	public float RotateAngle { get; }
	private float DefaultRadius { get; }
	public bool IsCharacterLoading { get; set; }
	public bool CanAccess { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C0FE0 Offset: 0x2C10E1 VA: 0x2C0FE0
	// RVA: 0x28BAE00 Offset: 0x28BAF01 VA: 0x28BAE00
	public float get_Dir() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0FF0 Offset: 0x2C10F1 VA: 0x2C0FF0
	// RVA: 0x28BAE10 Offset: 0x28BAF11 VA: 0x28BAE10
	public void set_Dir(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1000 Offset: 0x2C1101 VA: 0x2C1000
	// RVA: 0x28BAE20 Offset: 0x28BAF21 VA: 0x28BAE20
	public float get_PrevDir() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1010 Offset: 0x2C1111 VA: 0x2C1010
	// RVA: 0x28BAE30 Offset: 0x28BAF31 VA: 0x28BAE30
	private void set_PrevDir(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1020 Offset: 0x2C1121 VA: 0x2C1020
	// RVA: 0x28BAE40 Offset: 0x28BAF41 VA: 0x28BAE40
	public float get_ZRotate() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1030 Offset: 0x2C1131 VA: 0x2C1030
	// RVA: 0x28BAE50 Offset: 0x28BAF51 VA: 0x28BAE50
	public void set_ZRotate(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1040 Offset: 0x2C1141 VA: 0x2C1040
	// RVA: 0x28BAE60 Offset: 0x28BAF61 VA: 0x28BAE60
	public bool get_IsStop() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1050 Offset: 0x2C1151 VA: 0x2C1050
	// RVA: 0x28BAE70 Offset: 0x28BAF71 VA: 0x28BAE70
	public void set_IsStop(bool value) { }

	// RVA: 0x28BAE80 Offset: 0x28BAF81 VA: 0x28BAE80
	public float get_Speed() { }

	// RVA: 0x28BAE90 Offset: 0x28BAF91 VA: 0x28BAE90
	public void set_Speed(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1060 Offset: 0x2C1161 VA: 0x2C1060
	// RVA: 0x28BAEA0 Offset: 0x28BAFA1 VA: 0x28BAEA0
	public Character get_Character() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1070 Offset: 0x2C1171 VA: 0x2C1070
	// RVA: 0x28BAEB0 Offset: 0x28BAFB1 VA: 0x28BAEB0
	public void set_Character(Character value) { }

	// RVA: 0x28BAEC0 Offset: 0x28BAFC1 VA: 0x28BAEC0
	public HubUnitController get_UnitController() { }

	// RVA: 0x28BAED0 Offset: 0x28BAFD1 VA: 0x28BAED0
	public HubCullingPlayerCollider get_CullingCollider() { }

	// RVA: 0x28BAEE0 Offset: 0x28BAFE1 VA: 0x28BAEE0
	public int get_ControlType() { }

	// RVA: 0x28BAF30 Offset: 0x28BB031 VA: 0x28BAF30
	public float get_RotateAngle() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1080 Offset: 0x2C1181 VA: 0x2C1080
	// RVA: 0x28BAF80 Offset: 0x28BB081 VA: 0x28BAF80
	private float get_DefaultRadius() { }

	// RVA: 0x28BAF90 Offset: 0x28BB091 VA: 0x28BAF90
	public void Setup(GameObject playerRoot, GameObject groupRoot, GameObject buttonNavi) { }

	// RVA: 0x28BB0D0 Offset: 0x28BB1D1 VA: 0x28BB0D0
	public void SetCollider(HubPlayerCollider collider) { }

	// RVA: 0x28BB120 Offset: 0x28BB221 VA: 0x28BB120
	public void SetCullingCollider(HubCullingPlayerCollider collider) { }

	// RVA: 0x28BB130 Offset: 0x28BB231 VA: 0x28BB130
	public void Hide() { }

	// RVA: 0x28BB1D0 Offset: 0x28BB2D1 VA: 0x28BB1D0
	public void Show() { }

	// RVA: 0x28BB270 Offset: 0x28BB371 VA: 0x28BB270
	public void Start() { }

	// RVA: 0x28BB570 Offset: 0x28BB671 VA: 0x28BB570
	public void LoadCharacter() { }

	// RVA: 0x28BB740 Offset: 0x28BB841 VA: 0x28BB740
	public void SaveAccessory() { }

	// RVA: 0x28BB780 Offset: 0x28BB881 VA: 0x28BB780
	public void RestoreAccessory() { }

	// RVA: 0x28BB7E0 Offset: 0x28BB8E1 VA: 0x28BB7E0
	public void Reload() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1090 Offset: 0x2C1191 VA: 0x2C1090
	// RVA: 0x28BBA50 Offset: 0x28BBB51 VA: 0x28BBA50
	public bool get_IsCharacterLoading() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C10A0 Offset: 0x2C11A1 VA: 0x2C10A0
	// RVA: 0x28BBA60 Offset: 0x28BBB61 VA: 0x28BBA60
	public void set_IsCharacterLoading(bool value) { }

	// RVA: 0x28BBA70 Offset: 0x28BBB71 VA: 0x28BBA70
	public void InitLookAtTarget() { }

	// RVA: 0x28BBBF0 Offset: 0x28BBCF1 VA: 0x28BBBF0
	public void UpdateCharacterLookAt() { }

	// RVA: 0x28BBE10 Offset: 0x28BBF11 VA: 0x28BBE10
	public void Tick(float lx, float ly) { }

	// RVA: 0x28BCB90 Offset: 0x28BCC91 VA: 0x28BCB90
	private void StartProcIdle() { }

	// RVA: 0x28BCCD0 Offset: 0x28BCDD1 VA: 0x28BCCD0
	private void StopProcIdle(bool soon = False) { }

	// RVA: 0x28BCD80 Offset: 0x28BCE81 VA: 0x28BCD80
	public void Persistent() { }

	[IteratorStateMachineAttribute] // RVA: 0x2C10B0 Offset: 0x2C11B1 VA: 0x2C10B0
	// RVA: 0x28BCC50 Offset: 0x28BCD51 VA: 0x28BCC50
	private IEnumerator ProcIdle() { }

	// RVA: 0x28BE7F0 Offset: 0x28BE8F1 VA: 0x28BE7F0
	public void LatePersistent() { }

	// RVA: 0x28BDFC0 Offset: 0x28BE0C1 VA: 0x28BDFC0
	public void UpdateAccess(bool force = False) { }

	// RVA: 0x28BBC60 Offset: 0x28BBD61 VA: 0x28BBC60
	private void UpdateLookAt() { }

	// RVA: 0x28BECD0 Offset: 0x28BEDD1 VA: 0x28BECD0
	private Vector3 FindNearestLookAtPoint() { }

	// RVA: 0x28B06D0 Offset: 0x28B07D1 VA: 0x28B06D0
	public Transform GetTransform() { }

	// RVA: 0x28BF3C0 Offset: 0x28BF4C1 VA: 0x28BF3C0
	public bool get_CanAccess() { }

	// RVA: 0x28AEF50 Offset: 0x28AF051 VA: 0x28AEF50
	public void BeginAccess() { }

	// RVA: 0x28AF740 Offset: 0x28AF841 VA: 0x28AF740
	public void EndAccess(bool withResetAnim = True, float delay = 0.2) { }

	// RVA: 0x28BF3D0 Offset: 0x28BF4D1 VA: 0x28BF3D0
	public void ResetLook() { }

	// RVA: 0x28BF4B0 Offset: 0x28BF5B1 VA: 0x28BF4B0
	public HubAccess TryGetLastAccess() { }

	// RVA: 0x28BE930 Offset: 0x28BEA31 VA: 0x28BE930
	public HubAccess TryGetNowAccess() { }

	// RVA: 0x28BA720 Offset: 0x28BA821 VA: 0x28BA720
	public void AddCollider(Collider c) { }

	// RVA: 0x28BAAE0 Offset: 0x28BABE1 VA: 0x28BAAE0
	public void RemoveCollider(Collider c) { }

	// RVA: 0x28B0D40 Offset: 0x28B0E41 VA: 0x28B0D40
	public bool IsMoving() { }

	// RVA: 0x28BF4C0 Offset: 0x28BF5C1 VA: 0x28BF4C0
	public void .ctor() { }
}

