// Namespace: App
public class RingCleaningCloth : MonoBehaviour // TypeDefIndex: 11750
{
	// Fields
	[SerializeField] // RVA: 0x298F80 Offset: 0x299081 VA: 0x298F80
	private GameObject m_HelpObject; // 0x18
	private RectTransform m_Rect; // 0x20
	private const float WidthRatio = 0.4;
	private const float HeightRatio = 0.6;
	public const float MoveSpeed = 16;
	private const float MoveSpeedAccelRate = 1.8;
	private Vector2 m_LocalPosition; // 0x28
	private Vector2 m_HoldGapPosition; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x298F90 Offset: 0x299091 VA: 0x298F90
	private bool <IsHitRing>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x298FA0 Offset: 0x2990A1 VA: 0x298FA0
	private Collider <HitCollider>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x298FB0 Offset: 0x2990B1 VA: 0x298FB0
	private Vector3 <HitVector>k__BackingField; // 0x48
	private Animator m_Animator; // 0x58
	private bool m_IsStartAnim; // 0x60
	private float m_OldAnimSpeed; // 0x64

	// Properties
	public RectTransform Rect { get; }
	public bool IsHitRing { get; set; }
	public Collider HitCollider { get; set; }
	public Vector3 HitVector { get; set; }
	public bool IsPossibleCleaning { get; set; }

	// Methods

	// RVA: 0x2677850 Offset: 0x2677951 VA: 0x2677850
	public RectTransform get_Rect() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C64E0 Offset: 0x2C65E1 VA: 0x2C64E0
	// RVA: 0x26778B0 Offset: 0x26779B1 VA: 0x26778B0
	public bool get_IsHitRing() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C64F0 Offset: 0x2C65F1 VA: 0x2C64F0
	// RVA: 0x26778C0 Offset: 0x26779C1 VA: 0x26778C0
	private void set_IsHitRing(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6500 Offset: 0x2C6601 VA: 0x2C6500
	// RVA: 0x26778D0 Offset: 0x26779D1 VA: 0x26778D0
	public Collider get_HitCollider() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6510 Offset: 0x2C6611 VA: 0x2C6510
	// RVA: 0x26778E0 Offset: 0x26779E1 VA: 0x26778E0
	private void set_HitCollider(Collider value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6520 Offset: 0x2C6621 VA: 0x2C6520
	// RVA: 0x26778F0 Offset: 0x26779F1 VA: 0x26778F0
	public Vector3 get_HitVector() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6530 Offset: 0x2C6631 VA: 0x2C6530
	// RVA: 0x2677900 Offset: 0x2677A01 VA: 0x2677900
	private void set_HitVector(Vector3 value) { }

	// RVA: 0x2677910 Offset: 0x2677A11 VA: 0x2677910
	public bool get_IsPossibleCleaning() { }

	// RVA: 0x26779E0 Offset: 0x2677AE1 VA: 0x26779E0
	private void set_IsPossibleCleaning(bool value) { }

	// RVA: 0x2677A40 Offset: 0x2677B41 VA: 0x2677A40
	private void Start() { }

	// RVA: 0x2677C00 Offset: 0x2677D01 VA: 0x2677C00
	private void Update() { }

	// RVA: 0x2677DD0 Offset: 0x2677ED1 VA: 0x2677DD0
	public void UpdateMove(float lsx, float lsy, bool isSpeedUp, Camera camera) { }

	// RVA: 0x26781D0 Offset: 0x26782D1 VA: 0x26781D0
	public void UpdateMoveWithGap() { }

	// RVA: 0x2677F40 Offset: 0x2678041 VA: 0x2677F40
	private void Commit() { }

	// RVA: 0x26781E0 Offset: 0x26782E1 VA: 0x26781E0
	public void ShowHelp() { }

	// RVA: 0x26782C0 Offset: 0x26783C1 VA: 0x26782C0
	public void HideHelp() { }

	// RVA: 0x2678170 Offset: 0x2678271 VA: 0x2678170
	private bool IsHitRay(Camera camera) { }

	// RVA: 0x2678340 Offset: 0x2678441 VA: 0x2678340
	private bool IsHitRayImpl(Camera camera, out Vector3 colliderHitPos, out Collider collider) { }

	// RVA: 0x2678440 Offset: 0x2678541 VA: 0x2678440
	public void PlayCleaningAnim(RingCleaningSequence.Strength strength) { }

	// RVA: 0x26784D0 Offset: 0x26785D1 VA: 0x26784D0
	public void StartCleaningAnim(string animName) { }

	// RVA: 0x2678580 Offset: 0x2678681 VA: 0x2678580
	public void StopCleaningAnim() { }

	// RVA: 0x2678610 Offset: 0x2678711 VA: 0x2678610
	public bool IsPlayCleaningAnim() { }

	// RVA: 0x2677CE0 Offset: 0x2677DE1 VA: 0x2677CE0
	public bool IsPlayingCleaningAnim(bool useCorrect = True) { }

	// RVA: 0x26786F0 Offset: 0x26787F1 VA: 0x26786F0
	public float GetAnimatorNormalizeTime() { }

	// RVA: 0x2678750 Offset: 0x2678851 VA: 0x2678750
	public RingColliderPart GetHitPart() { }

	// RVA: 0x2678810 Offset: 0x2678911 VA: 0x2678810
	public void PauseAnim() { }

	// RVA: 0x2678870 Offset: 0x2678971 VA: 0x2678870
	public void SetGap(float x, float y) { }

	// RVA: 0x2678880 Offset: 0x2678981 VA: 0x2678880
	public void .ctor() { }
}

