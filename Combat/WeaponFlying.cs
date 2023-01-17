// Namespace: Combat
[DisallowMultipleComponent] // RVA: 0x2747F0 Offset: 0x2748F1 VA: 0x2747F0
internal sealed class WeaponFlying : MonoBehaviour // TypeDefIndex: 8792
{
	// Fields
	private Character CP; // 0x18
	private Rigidbody m_Rigidbody; // 0x20
	private Vector3 m_PrevPos; // 0x28
	private const float InitialLife = 10;
	private float m_TimeToHit; // 0x34
	private float m_Life; // 0x38
	private float m_AngularVelocity; // 0x3C
	private GameObject m_TrailGO; // 0x40
	private bool collided; // 0x48
	private bool inWater; // 0x49

	// Methods

	// RVA: 0x26CA780 Offset: 0x26CA881 VA: 0x26CA780
	public void Initialize(Character owner, Parabola para, float angularVelocity) { }

	// RVA: 0x26CAEC0 Offset: 0x26CAFC1 VA: 0x26CAEC0
	public void AttachTrailEffect(GameObject effectPrefab, string nodeName) { }

	// RVA: 0x26CB000 Offset: 0x26CB101 VA: 0x26CB000
	public void HitAndDelete() { }

	// RVA: 0x26CB1E0 Offset: 0x26CB2E1 VA: 0x26CB1E0
	public void Drop() { }

	// RVA: 0x26CB250 Offset: 0x26CB351 VA: 0x26CB250
	public void Knockoff(in Vector3 worldHitDir) { }

	// RVA: 0x26CB090 Offset: 0x26CB191 VA: 0x26CB090
	private void FadeoutTrailEffect(bool stopAndClear = False) { }

	// RVA: 0x26CB340 Offset: 0x26CB441 VA: 0x26CB340
	private void Update() { }

	// RVA: 0x26CB4C0 Offset: 0x26CB5C1 VA: 0x26CB4C0
	private void OnCollisionEnter(Collision collision) { }

	// RVA: 0x26CB790 Offset: 0x26CB891 VA: 0x26CB790
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2ACCB0 Offset: 0x2ACDB1 VA: 0x2ACCB0
	// RVA: 0x26CACC0 Offset: 0x26CADC1 VA: 0x26CACC0
	internal static void <Initialize>g__SetupLayer|8_0(Transform t) { }
}

