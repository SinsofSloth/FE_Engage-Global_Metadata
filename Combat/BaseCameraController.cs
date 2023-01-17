// Namespace: Combat
[DisallowMultipleComponent] // RVA: 0x273860 Offset: 0x273961 VA: 0x273860
[Serializable]
public abstract class BaseCameraController : MonoBehaviour // TypeDefIndex: 8525
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x280190 Offset: 0x280291 VA: 0x280190
	private CinemachineVirtualCamera <VCam>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x2801A0 Offset: 0x2802A1 VA: 0x2801A0
	private Transform <Follow>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x2801B0 Offset: 0x2802B1 VA: 0x2801B0
	private Transform <LookAt>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x2801C0 Offset: 0x2802C1 VA: 0x2801C0
	private Vector3 <BaseFollow>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x2801D0 Offset: 0x2802D1 VA: 0x2801D0
	private Vector3 <BaseLookAt>k__BackingField; // 0x3C
	[HeaderAttribute] // RVA: 0x2801E0 Offset: 0x2802E1 VA: 0x2801E0
	public float LookupDegree; // 0x48
	[HeaderAttribute] // RVA: 0x280220 Offset: 0x280321 VA: 0x280220
	public float TripodHeight; // 0x4C
	[HeaderAttribute] // RVA: 0x280260 Offset: 0x280361 VA: 0x280260
	[TooltipAttribute] // RVA: 0x280260 Offset: 0x280361 VA: 0x280260
	public AnimationCurve MoveSpeedCurve; // 0x50
	[HeaderAttribute] // RVA: 0x2802C0 Offset: 0x2803C1 VA: 0x2802C0
	[TooltipAttribute] // RVA: 0x2802C0 Offset: 0x2803C1 VA: 0x2802C0
	public AnimationCurve ChaseSpeedCurve; // 0x58
	[HeaderAttribute] // RVA: 0x280320 Offset: 0x280421 VA: 0x280320
	public bool IsShakable; // 0x60
	[HeaderAttribute] // RVA: 0x280360 Offset: 0x280461 VA: 0x280360
	public bool Controlable; // 0x61
	[HeaderAttribute] // RVA: 0x2803A0 Offset: 0x2804A1 VA: 0x2803A0
	public float CameraBackByEmblem; // 0x64
	[HeaderAttribute] // RVA: 0x2803E0 Offset: 0x2804E1 VA: 0x2803E0
	public bool ImmobileCamera; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x280420 Offset: 0x280521 VA: 0x280420
	private bool <IsUsable>k__BackingField; // 0x69
	[CompilerGeneratedAttribute] // RVA: 0x280430 Offset: 0x280531 VA: 0x280430
	private List<CameraPosition> <Positions>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x280440 Offset: 0x280541 VA: 0x280440
	private float <SSS>k__BackingField; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x280450 Offset: 0x280551 VA: 0x280450
	private bool <MoveQuick>k__BackingField; // 0x7C
	[CompilerGeneratedAttribute] // RVA: 0x280460 Offset: 0x280561 VA: 0x280460
	private CameraPositionData <PosData>k__BackingField; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x280470 Offset: 0x280571 VA: 0x280470
	private bool <IsUpdated>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x280480 Offset: 0x280581 VA: 0x280480
	private float <RotateByTransition>k__BackingField; // 0x8C
	[CompilerGeneratedAttribute] // RVA: 0x280490 Offset: 0x280591 VA: 0x280490
	private CameraSwitch <Switch>k__BackingField; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x2804A0 Offset: 0x2805A1 VA: 0x2804A0
	private CinemachineBrain <VCamBrain>k__BackingField; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x2804B0 Offset: 0x2805B1 VA: 0x2804B0
	private CinemachineCollider <Collider>k__BackingField; // 0xA0

	// Properties
	public CinemachineVirtualCamera VCam { get; set; }
	public Transform Follow { get; set; }
	public Transform LookAt { get; set; }
	internal Vector3 BaseFollow { get; set; }
	internal Vector3 BaseLookAt { get; set; }
	public bool IsUsable { get; set; }
	public List<CameraPosition> Positions { get; set; }
	public float SSS { get; set; }
	public bool MoveQuick { get; set; }
	public CameraPositionData PosData { get; set; }
	public bool IsUpdated { get; set; }
	public float RotateByTransition { get; set; }
	protected CameraSwitch Switch { get; set; }
	protected CinemachineBrain VCamBrain { get; set; }
	internal CinemachineCollider Collider { get; set; }
	public virtual bool IsActiveVCam { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2A9430 Offset: 0x2A9531 VA: 0x2A9430
	// RVA: 0x26182E0 Offset: 0x26183E1 VA: 0x26182E0
	public CinemachineVirtualCamera get_VCam() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9440 Offset: 0x2A9541 VA: 0x2A9440
	// RVA: 0x26182F0 Offset: 0x26183F1 VA: 0x26182F0
	public void set_VCam(CinemachineVirtualCamera value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9450 Offset: 0x2A9551 VA: 0x2A9450
	// RVA: 0x2618300 Offset: 0x2618401 VA: 0x2618300
	public Transform get_Follow() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9460 Offset: 0x2A9561 VA: 0x2A9460
	// RVA: 0x2618310 Offset: 0x2618411 VA: 0x2618310
	public void set_Follow(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9470 Offset: 0x2A9571 VA: 0x2A9470
	// RVA: 0x2618320 Offset: 0x2618421 VA: 0x2618320
	public Transform get_LookAt() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9480 Offset: 0x2A9581 VA: 0x2A9480
	// RVA: 0x2618330 Offset: 0x2618431 VA: 0x2618330
	public void set_LookAt(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9490 Offset: 0x2A9591 VA: 0x2A9490
	// RVA: 0x2618340 Offset: 0x2618441 VA: 0x2618340
	internal Vector3 get_BaseFollow() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A94A0 Offset: 0x2A95A1 VA: 0x2A94A0
	// RVA: 0x2618350 Offset: 0x2618451 VA: 0x2618350
	internal void set_BaseFollow(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A94B0 Offset: 0x2A95B1 VA: 0x2A94B0
	// RVA: 0x2618360 Offset: 0x2618461 VA: 0x2618360
	internal Vector3 get_BaseLookAt() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A94C0 Offset: 0x2A95C1 VA: 0x2A94C0
	// RVA: 0x2618370 Offset: 0x2618471 VA: 0x2618370
	internal void set_BaseLookAt(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A94D0 Offset: 0x2A95D1 VA: 0x2A94D0
	// RVA: 0x2618380 Offset: 0x2618481 VA: 0x2618380
	public bool get_IsUsable() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A94E0 Offset: 0x2A95E1 VA: 0x2A94E0
	// RVA: 0x2618390 Offset: 0x2618491 VA: 0x2618390
	protected void set_IsUsable(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A94F0 Offset: 0x2A95F1 VA: 0x2A94F0
	// RVA: 0x26183A0 Offset: 0x26184A1 VA: 0x26183A0
	public List<CameraPosition> get_Positions() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9500 Offset: 0x2A9601 VA: 0x2A9500
	// RVA: 0x26183B0 Offset: 0x26184B1 VA: 0x26183B0
	public void set_Positions(List<CameraPosition> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9510 Offset: 0x2A9611 VA: 0x2A9510
	// RVA: 0x26183C0 Offset: 0x26184C1 VA: 0x26183C0
	public float get_SSS() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9520 Offset: 0x2A9621 VA: 0x2A9520
	// RVA: 0x26183D0 Offset: 0x26184D1 VA: 0x26183D0
	public void set_SSS(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9530 Offset: 0x2A9631 VA: 0x2A9530
	// RVA: 0x26183E0 Offset: 0x26184E1 VA: 0x26183E0
	public bool get_MoveQuick() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9540 Offset: 0x2A9641 VA: 0x2A9540
	// RVA: 0x26183F0 Offset: 0x26184F1 VA: 0x26183F0
	public void set_MoveQuick(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9550 Offset: 0x2A9651 VA: 0x2A9550
	// RVA: 0x2618400 Offset: 0x2618501 VA: 0x2618400
	public CameraPositionData get_PosData() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9560 Offset: 0x2A9661 VA: 0x2A9560
	// RVA: 0x2618410 Offset: 0x2618511 VA: 0x2618410
	public void set_PosData(CameraPositionData value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9570 Offset: 0x2A9671 VA: 0x2A9570
	// RVA: 0x2618420 Offset: 0x2618521 VA: 0x2618420
	public bool get_IsUpdated() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9580 Offset: 0x2A9681 VA: 0x2A9580
	// RVA: 0x2618430 Offset: 0x2618531 VA: 0x2618430
	public void set_IsUpdated(bool value) { }

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract ValueTuple<Vector3, Vector3> GetPositionInfo();

	[CompilerGeneratedAttribute] // RVA: 0x2A9590 Offset: 0x2A9691 VA: 0x2A9590
	// RVA: 0x2618440 Offset: 0x2618541 VA: 0x2618440
	public float get_RotateByTransition() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A95A0 Offset: 0x2A96A1 VA: 0x2A95A0
	// RVA: 0x2618450 Offset: 0x2618551 VA: 0x2618450
	public void set_RotateByTransition(float value) { }

	// RVA: 0x2618460 Offset: 0x2618561 VA: 0x2618460 Slot: 5
	public virtual ValueTuple<bool, bool> GetInverse() { }

	// RVA: 0x26184D0 Offset: 0x26185D1 VA: 0x26184D0 Slot: 6
	public virtual void SetInverse(bool invSide, bool invCamera) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A95B0 Offset: 0x2A96B1 VA: 0x2A95B0
	// RVA: 0x26184E0 Offset: 0x26185E1 VA: 0x26184E0
	protected CameraSwitch get_Switch() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A95C0 Offset: 0x2A96C1 VA: 0x2A95C0
	// RVA: 0x26184F0 Offset: 0x26185F1 VA: 0x26184F0
	protected void set_Switch(CameraSwitch value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A95D0 Offset: 0x2A96D1 VA: 0x2A95D0
	// RVA: 0x2618500 Offset: 0x2618601 VA: 0x2618500
	protected CinemachineBrain get_VCamBrain() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A95E0 Offset: 0x2A96E1 VA: 0x2A95E0
	// RVA: 0x2618510 Offset: 0x2618611 VA: 0x2618510
	protected void set_VCamBrain(CinemachineBrain value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A95F0 Offset: 0x2A96F1 VA: 0x2A95F0
	// RVA: 0x2618520 Offset: 0x2618621 VA: 0x2618520
	internal CinemachineCollider get_Collider() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9600 Offset: 0x2A9701 VA: 0x2A9600
	// RVA: 0x2618530 Offset: 0x2618631 VA: 0x2618530
	private void set_Collider(CinemachineCollider value) { }

	// RVA: 0x2618540 Offset: 0x2618641 VA: 0x2618540 Slot: 7
	public virtual bool get_IsActiveVCam() { }

	// RVA: 0x2618660 Offset: 0x2618761 VA: 0x2618660
	private void Awake() { }

	// RVA: 0x26187C0 Offset: 0x26188C1 VA: 0x26187C0
	public void Setup(CameraSwitch swt, CinemachineBrain brain) { }

	// RVA: 0x2618800 Offset: 0x2618901 VA: 0x2618800
	private void LateUpdate() { }

	// RVA: 0x2611130 Offset: 0x2611231 VA: 0x2611130
	public void UpdatePosition(bool force = False) { }

	// RVA: 0x2619480 Offset: 0x2619581 VA: 0x2619480 Slot: 8
	public virtual void Stabilize() { }

	// RVA: 0x2619490 Offset: 0x2619591 VA: 0x2619490 Slot: 9
	public virtual void CheckUsable(bool isRoutine) { }

	// RVA: 0x26194A0 Offset: 0x26195A1 VA: 0x26194A0 Slot: 10
	public virtual void Activate() { }

	// RVA: 0x26194B0 Offset: 0x26195B1 VA: 0x26194B0 Slot: 11
	public virtual void Deactivate() { }

	// RVA: 0x2618A20 Offset: 0x2618B21 VA: 0x2618A20
	private void SetFollowLookupPos(Vector3 followPos, Vector3 lookatPos) { }

	// RVA: 0x26195B0 Offset: 0x26196B1 VA: 0x26195B0
	private float FixHeight(Vector3 current, Vector3 nextPos, float delta) { }

	// RVA: 0x2610870 Offset: 0x2610971 VA: 0x2610870
	protected bool CheckCollision() { }

	// RVA: 0x2610980 Offset: 0x2610A81 VA: 0x2610980
	protected bool CheckObstacle(int side = 0, bool checkEnemy = True, float noCheckRange = 0, bool isDebug = False) { }

	// RVA: 0x26195D0 Offset: 0x26196D1 VA: 0x26195D0
	private bool CheckObstacleImpl(int side, float noCheckRange, bool isDebug) { }

	// RVA: 0x2619CB0 Offset: 0x2619DB1 VA: 0x2619CB0
	public float DistanceToCamera(Vector3 pos) { }

	// RVA: 0x26194C0 Offset: 0x26195C1 VA: 0x26194C0
	private float GetCameraSpeed(AnimationCurve curve, Vector3 currentPos, Vector3 bestPos) { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract int[] GetCameraTargets();

	// RVA: 0x2611BB0 Offset: 0x2611CB1 VA: 0x2611BB0
	protected void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9610 Offset: 0x2A9711 VA: 0x2A9610
	// RVA: 0x2619BA0 Offset: 0x2619CA1 VA: 0x2619BA0
	internal static bool <CheckObstacleImpl>g__LineCast|85_0(Vector3 pos1, Vector3 pos2, float noCheckRange) { }
}

