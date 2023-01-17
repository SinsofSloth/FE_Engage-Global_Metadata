// Namespace: Combat
[DisallowMultipleComponent] // RVA: 0x274720 Offset: 0x274821 VA: 0x274720
public sealed class MagicSignalProcessor : MonoBehaviour // TypeDefIndex: 8785
{
	// Fields
	private Character CP; // 0x18
	private MagicFlying m_FlyingObject; // 0x20
	private CharacterNodeConstraint m_CachedNodeConstraint; // 0x28
	private Phase m_Phase; // 0x30
	private float m_DecayTime; // 0x38
	private bool m_IsFocusEnemyPassed; // 0x3C
	private bool m_bReached; // 0x3D
	[CompilerGeneratedAttribute] // RVA: 0x284500 Offset: 0x284601 VA: 0x284500
	private Magic <Magic>k__BackingField; // 0x40
	private MagicSignalTimeline TL開始時処理; // 0x48
	private MagicSignalTimeline TL魔法動作1処理; // 0x50
	private MagicSignalTimeline TL魔法動作2処理; // 0x58
	private MagicSignalTimeline TL魔法動作3処理; // 0x60
	private MagicSignalTimeline TLヒット時処理; // 0x68
	private MagicSignalTimeline TLミス時処理; // 0x70
	private MagicSignalTimeline TLガード時処理; // 0x78
	private MagicSignalTimeline TLパリィ時処理; // 0x80
	private MagicSignalTimeline TL衝突時処理; // 0x88
	private MagicSignalTimeline TL自然消滅処理; // 0x90
	private MagicSignalTimeline TL打撃命中処理; // 0x98
	private List<GameObject> m_ManagedObjects; // 0xA0
	private List<GameObject> m_DeletedObjects; // 0xA8
	private int m_KnockoffAttackHash; // 0xB0

	// Properties
	public Magic Magic { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2ACB90 Offset: 0x2ACC91 VA: 0x2ACB90
	// RVA: 0x1F94A70 Offset: 0x1F94B71 VA: 0x1F94A70
	public Magic get_Magic() { }

	[CompilerGeneratedAttribute] // RVA: 0x2ACBA0 Offset: 0x2ACCA1 VA: 0x2ACBA0
	// RVA: 0x1F94A80 Offset: 0x1F94B81 VA: 0x1F94A80
	private void set_Magic(Magic value) { }

	// RVA: 0x1F93870 Offset: 0x1F93971 VA: 0x1F93870
	public void OnEnterAttack(Character owner, Magic catalog, float worldHitTime) { }

	// RVA: 0x1F94C10 Offset: 0x1F94D11 VA: 0x1F94C10
	private void RegisterObservers(float worldHitTime) { }

	// RVA: 0x1F94F10 Offset: 0x1F95011 VA: 0x1F94F10
	public void HitProcess() { }

	// RVA: 0x1F951B0 Offset: 0x1F952B1 VA: 0x1F951B0
	private void LateUpdate() { }

	// RVA: 0x1F95AE0 Offset: 0x1F95BE1 VA: 0x1F95AE0
	private void OnDestroy() { }

	// RVA: 0x1F94A90 Offset: 0x1F94B91 VA: 0x1F94A90
	public void OnEnterMagicSwordHit(Character owner, Magic catalog) { }

	// RVA: 0x1F93EB0 Offset: 0x1F93FB1 VA: 0x1F93EB0
	public void OnHitMagicSwordHit() { }

	// RVA: 0x1F93EE0 Offset: 0x1F93FE1 VA: 0x1F93EE0
	public GameObject GetIceRockSkippedPrefab仕方なく() { }

	// RVA: 0x1F95440 Offset: 0x1F95541 VA: 0x1F95440
	private void UpdateTimeline(MagicSignalTimeline timeline) { }

	// RVA: 0x1F95C20 Offset: 0x1F95D21 VA: 0x1F95C20
	private void CmdCreate(MagicSignal ev, bool uncached = False) { }

	// RVA: 0x1F96A60 Offset: 0x1F96B61 VA: 0x1F96A60
	private void CmdCreateImpl(MagicSignal ev, bool uncached) { }

	// RVA: 0x1F96BA0 Offset: 0x1F96CA1 VA: 0x1F96BA0
	private GameObject CmdCreateGO(MagicSignal ev, bool uncached) { }

	// RVA: 0x1F95E00 Offset: 0x1F95F01 VA: 0x1F95E00
	private void CmdDelete(MagicSignal ev) { }

	// RVA: 0x1F96130 Offset: 0x1F96231 VA: 0x1F96130
	private void CmdShoot(MagicSignal ev) { }

	// RVA: 0x1F96410 Offset: 0x1F96511 VA: 0x1F96410
	private void CmdCollideFlying(MagicSignal ev) { }

	// RVA: 0x1F964C0 Offset: 0x1F965C1 VA: 0x1F964C0
	private void CmdStopFlying(MagicSignal ev) { }

	// RVA: 0x1F964D0 Offset: 0x1F965D1 VA: 0x1F964D0
	private void CmdChangeTarget(MagicSignal ev) { }

	// RVA: 0x1F96610 Offset: 0x1F96711 VA: 0x1F96610
	private void CmdSound(MagicSignal ev) { }

	// RVA: 0x1F96790 Offset: 0x1F96891 VA: 0x1F96790
	private void CmdCutChange(MagicSignal ev) { }

	// RVA: 0x1F95060 Offset: 0x1F95161 VA: 0x1F95060
	private void CallOnFocusEnemy() { }

	// RVA: 0x1F967A0 Offset: 0x1F968A1 VA: 0x1F967A0
	private void CmdCamera(MagicSignal ev) { }

	// RVA: 0x1F96870 Offset: 0x1F96971 VA: 0x1F96870
	private void CmdCameraResume(MagicSignal ev) { }

	// RVA: 0x1F968E0 Offset: 0x1F969E1 VA: 0x1F968E0
	private void CmdRadialBlur(MagicSignal ev) { }

	// RVA: 0x1F969A0 Offset: 0x1F96AA1 VA: 0x1F969A0
	private void CmdBGBrightness(MagicSignal ev) { }

	// RVA: 0x1F97130 Offset: 0x1F97231 VA: 0x1F97130
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2ACBB0 Offset: 0x2ACCB1 VA: 0x2ACBB0
	// RVA: 0x1F971F0 Offset: 0x1F972F1 VA: 0x1F971F0
	private void <OnEnterAttack>b__25_0(Character _) { }

	[CompilerGeneratedAttribute] // RVA: 0x2ACBC0 Offset: 0x2ACCC1 VA: 0x2ACBC0
	// RVA: 0x1F97240 Offset: 0x1F97341 VA: 0x1F97240
	private void <OnEnterAttack>b__25_1(Character _) { }

	[CompilerGeneratedAttribute] // RVA: 0x2ACBD0 Offset: 0x2ACCD1 VA: 0x2ACBD0
	// RVA: 0x1F97290 Offset: 0x1F97391 VA: 0x1F97290
	private void <OnEnterAttack>b__25_2(Character _) { }

	[CompilerGeneratedAttribute] // RVA: 0x2ACBE0 Offset: 0x2ACCE1 VA: 0x2ACBE0
	// RVA: 0x1F972E0 Offset: 0x1F973E1 VA: 0x1F972E0
	private void <RegisterObservers>b__26_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x2ACBF0 Offset: 0x2ACCF1 VA: 0x2ACBF0
	// RVA: 0x1F972F0 Offset: 0x1F973F1 VA: 0x1F972F0
	private void <RegisterObservers>b__26_1(Character _) { }
}

