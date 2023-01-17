// Namespace: Combat
internal sealed class ActionAttack : ActionObservable // TypeDefIndex: 8405
{
	// Fields
	private float m_ChainAttackTimeout; // 0x30
	private float m_ChainSpeedRate; // 0x34
	private ActionAttack.Stage m_Stage; // 0x38
	private float m_WorldArrivalTime; // 0x3C
	private float m_FarAttackRangeSq; // 0x40
	private Character m_ChainGuard; // 0x48
	private bool m_bHitPassed; // 0x50
	private float m_TimeToNext; // 0x54
	private bool m_IsNotRepelled; // 0x58
	private bool m_再生ジャンプPassed; // 0x59

	// Properties
	public override string Name { get; }
	public override bool AbortByInterrupt { get; }

	// Methods

	// RVA: 0x2EBF360 Offset: 0x2EBF461 VA: 0x2EBF360 Slot: 5
	public override string get_Name() { }

	// RVA: 0x2EBF3B0 Offset: 0x2EBF4B1 VA: 0x2EBF3B0
	public void .ctor(Character chr, Phase phase, float timeToChainAttack = 999) { }

	// RVA: 0x2EBF400 Offset: 0x2EBF501 VA: 0x2EBF400
	private void NextStage() { }

	// RVA: 0x2EC0CC0 Offset: 0x2EC0DC1 VA: 0x2EC0CC0 Slot: 6
	public override void OnEnter() { }

	// RVA: 0x2EC0EA0 Offset: 0x2EC0FA1 VA: 0x2EC0EA0 Slot: 7
	public override void OnUpdate() { }

	// RVA: 0x2EC1310 Offset: 0x2EC1411 VA: 0x2EC1310 Slot: 9
	public override void OnExit() { }

	// RVA: 0x2EBF440 Offset: 0x2EBF541 VA: 0x2EBF440
	private void EnterApproach() { }

	// RVA: 0x2EC14B0 Offset: 0x2EC15B1 VA: 0x2EC14B0
	private void ChainGuardPresentation() { }

	// RVA: 0x2EC1070 Offset: 0x2EC1171 VA: 0x2EC1070
	private void UpdateApproach() { }

	// RVA: 0x2EC1BE0 Offset: 0x2EC1CE1 VA: 0x2EC1BE0 Slot: 11
	public override bool get_AbortByInterrupt() { }

	// RVA: 0x2EBFE30 Offset: 0x2EBFF31 VA: 0x2EBFE30
	private void EnterAttack() { }

	// RVA: 0x2EC11E0 Offset: 0x2EC12E1 VA: 0x2EC11E0
	private void UpdateAttack() { }

	// RVA: 0x2EC1D00 Offset: 0x2EC1E01 VA: 0x2EC1D00
	private void Miss(AnimationEvent ev) { }

	// RVA: 0x2EC24C0 Offset: 0x2EC25C1 VA: 0x2EC24C0
	private void Hit(AnimationEvent ev) { }

	// RVA: 0x2EC3480 Offset: 0x2EC3581 VA: 0x2EC3480
	private void SelfHit(AnimationEvent ev) { }

	// RVA: 0x2EC3670 Offset: 0x2EC3771 VA: 0x2EC3670
	private void Guard(AnimationEvent ev) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A8460 Offset: 0x2A8561 VA: 0x2A8460
	// RVA: 0x2EC3910 Offset: 0x2EC3A11 VA: 0x2EC3910
	private void <EnterAttack>b__23_0(Character chr) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A8470 Offset: 0x2A8571 VA: 0x2A8470
	// RVA: 0x2EC3A20 Offset: 0x2EC3B21 VA: 0x2EC3A20
	private void <EnterAttack>b__23_1(Character chr) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A8480 Offset: 0x2A8581 VA: 0x2A8480
	// RVA: 0x2EC3B70 Offset: 0x2EC3C71 VA: 0x2EC3B70
	private void <EnterAttack>b__23_2(Character chr) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A8490 Offset: 0x2A8591 VA: 0x2A8490
	// RVA: 0x2EC3CB0 Offset: 0x2EC3DB1 VA: 0x2EC3CB0
	private void <EnterAttack>g__マルスエンゲージ技_連撃Phase進行|23_3(Character chr) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A84A0 Offset: 0x2A85A1 VA: 0x2A84A0
	// RVA: 0x2EC3ED0 Offset: 0x2EC3FD1 VA: 0x2EC3ED0
	private void <EnterAttack>b__23_4(Character chr) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A84B0 Offset: 0x2A85B1 VA: 0x2A84B0
	// RVA: 0x2EC4090 Offset: 0x2EC4191 VA: 0x2EC4090
	private void <EnterAttack>b__23_6(int hash) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A84C0 Offset: 0x2A85C1 VA: 0x2A84C0
	// RVA: 0x2EC40D0 Offset: 0x2EC41D1 VA: 0x2EC40D0
	private void <EnterAttack>b__23_9(Character chr) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A84D0 Offset: 0x2A85D1 VA: 0x2A84D0
	// RVA: 0x2EC2EA0 Offset: 0x2EC2FA1 VA: 0x2EC2EA0
	private Vector3 <Hit>g__ForecastDropOffset|26_0(CombatWorld world, ref ActionAttack.<>c__DisplayClass26_0 ) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A84E0 Offset: 0x2A85E1 VA: 0x2A84E0
	// RVA: 0x2EC3150 Offset: 0x2EC3251 VA: 0x2EC3150
	private void <Hit>g__MoveAllCharacters|26_1(ref Vector3 offset, ref ActionAttack.<>c__DisplayClass26_0 ) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A84F0 Offset: 0x2A85F1 VA: 0x2A84F0
	// RVA: 0x2EC4200 Offset: 0x2EC4301 VA: 0x2EC4200
	private void <Guard>b__28_0(Unit _) { }
}

