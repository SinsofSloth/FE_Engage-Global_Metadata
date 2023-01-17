// Namespace: Combat
[DisallowMultipleComponent] // RVA: 0x2747E0 Offset: 0x2748E1 VA: 0x2747E0
public abstract class Throwing : LaunchBehaviour // TypeDefIndex: 8791
{
	// Fields
	[SerializeField] // RVA: 0x2845D0 Offset: 0x2846D1 VA: 0x2845D0
	[HeaderAttribute] // RVA: 0x2845D0 Offset: 0x2846D1 VA: 0x2845D0
	private float Mass; // 0x38
	[HeaderAttribute] // RVA: 0x284620 Offset: 0x284721 VA: 0x284620
	[SerializeField] // RVA: 0x284620 Offset: 0x284721 VA: 0x284620
	private float FlySpeed; // 0x3C
	[SerializeField] // RVA: 0x284670 Offset: 0x284771 VA: 0x284670
	[HeaderAttribute] // RVA: 0x284670 Offset: 0x284771 VA: 0x284670
	private float LocalAngularVelocity; // 0x40
	[SerializeField] // RVA: 0x2846C0 Offset: 0x2847C1 VA: 0x2846C0
	[HeaderAttribute] // RVA: 0x2846C0 Offset: 0x2847C1 VA: 0x2846C0
	private GameObject TrailPrefab; // 0x48
	[HeaderAttribute] // RVA: 0x284710 Offset: 0x284811 VA: 0x284710
	[SerializeField] // RVA: 0x284710 Offset: 0x284811 VA: 0x284710
	private string TrailParentNode; // 0x50
	[SerializeField] // RVA: 0x284760 Offset: 0x284861 VA: 0x284760
	[HeaderAttribute] // RVA: 0x284760 Offset: 0x284861 VA: 0x284760
	private GameObject HitEffectPrefab; // 0x58
	private bool m_ShootPassed; // 0x60
	private bool m_bReached; // 0x61
	private GameObject m_WeaponPrefab; // 0x68
	private float m_WeaponLength; // 0x70
	private Parabola m_Parabola; // 0x78
	private int m_KnockoffAttack; // 0x80

	// Methods

	// RVA: 0x25DC410 Offset: 0x25DC511 VA: 0x25DC410 Slot: 4
	public override void OnCharacterSetup(Character owner) { }

	// RVA: 0x25DC640 Offset: 0x25DC741 VA: 0x25DC640 Slot: 5
	public override void OnEnterAttack() { }

	// RVA: 0x25DC650 Offset: 0x25DC751 VA: 0x25DC650 Slot: 6
	public override void OnHitTimePredicted(float worldHitTime) { }

	// RVA: 0x25DCCA0 Offset: 0x25DCDA1 VA: 0x25DCCA0
	private void OnReached() { }

	// RVA: 0x25DD160 Offset: 0x25DD261 VA: 0x25DD160
	public void FlyingHitReaction(Phase phase) { }

	// RVA: 0x25DD200 Offset: 0x25DD301 VA: 0x25DD200
	private void OnHit() { }

	// RVA: 0x25DD440 Offset: 0x25DD541 VA: 0x25DD440
	private void OnMiss() { }

	// RVA: 0x25DD450 Offset: 0x25DD551 VA: 0x25DD450
	private void OnGuard() { }

	// RVA: 0x25DD540 Offset: 0x25DD641 VA: 0x25DD540
	private void OnKnockoff() { }

	// RVA: 0x25DCDE0 Offset: 0x25DCEE1 VA: 0x25DCDE0
	private void 発射() { }

	// RVA: 0x25DCB40 Offset: 0x25DCC41 VA: 0x25DCB40
	private Vector3 CalcAimPosition(Character enemy, int knockoffAttack) { }

	// RVA: 0x25DD700 Offset: 0x25DD801 VA: 0x25DD700 Slot: 7
	public override void RecalcFlyingTime() { }

	// RVA: 0x25DD960 Offset: 0x25DDA61 VA: 0x25DD960
	protected void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2ACC80 Offset: 0x2ACD81 VA: 0x2ACC80
	// RVA: 0x25DD980 Offset: 0x25DDA81 VA: 0x25DD980
	private void <OnCharacterSetup>b__12_0(Character _) { }

	[CompilerGeneratedAttribute] // RVA: 0x2ACC90 Offset: 0x2ACD91 VA: 0x2ACC90
	// RVA: 0x25DD990 Offset: 0x25DDA91 VA: 0x25DD990
	private void <OnHitTimePredicted>b__14_0(Character _) { }

	[CompilerGeneratedAttribute] // RVA: 0x2ACCA0 Offset: 0x2ACDA1 VA: 0x2ACCA0
	// RVA: 0x25DD9A0 Offset: 0x25DDAA1 VA: 0x25DD9A0
	private void <OnHitTimePredicted>b__14_1() { }
}

