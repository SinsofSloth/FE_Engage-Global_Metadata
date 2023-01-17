// Namespace: Combat
public abstract class Magic : LaunchBehaviour // TypeDefIndex: 8776
{
	// Fields
	[HideInInspector] // RVA: 0x284360 Offset: 0x284461 VA: 0x284360
	public MagicBulletSettings BulletSettings; // 0x38
	private MagicSignalProcessor m_SignalProcessor; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x284370 Offset: 0x284471 VA: 0x284370
	private Vector3 <InitialStartPos>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x284380 Offset: 0x284481 VA: 0x284380
	private Vector3 <InitialEndPos>k__BackingField; // 0x54
	[HideInInspector] // RVA: 0x284390 Offset: 0x284491 VA: 0x284390
	public MagicSignalTrack Track開始時処理; // 0x60
	[HideInInspector] // RVA: 0x2843A0 Offset: 0x2844A1 VA: 0x2843A0
	public MagicSignalTrack Track魔法動作1処理; // 0x68
	[HideInInspector] // RVA: 0x2843B0 Offset: 0x2844B1 VA: 0x2843B0
	public MagicSignalTrack Track魔法動作2処理; // 0x70
	[HideInInspector] // RVA: 0x2843C0 Offset: 0x2844C1 VA: 0x2843C0
	public MagicSignalTrack Track魔法動作3処理; // 0x78
	[HideInInspector] // RVA: 0x2843D0 Offset: 0x2844D1 VA: 0x2843D0
	public MagicSignalTrack Trackヒット時処理; // 0x80
	[HideInInspector] // RVA: 0x2843E0 Offset: 0x2844E1 VA: 0x2843E0
	public MagicSignalTrack Trackミス時処理; // 0x88
	[HideInInspector] // RVA: 0x2843F0 Offset: 0x2844F1 VA: 0x2843F0
	public MagicSignalTrack Trackガード時処理; // 0x90
	[HideInInspector] // RVA: 0x284400 Offset: 0x284501 VA: 0x284400
	public MagicSignalTrack Trackパリィ時処理; // 0x98
	[HideInInspector] // RVA: 0x284410 Offset: 0x284511 VA: 0x284410
	public MagicSignalTrack Track衝突時処理; // 0xA0
	[HideInInspector] // RVA: 0x284420 Offset: 0x284521 VA: 0x284420
	public MagicSignalTrack Track自然消滅処理; // 0xA8
	[HideInInspector] // RVA: 0x284430 Offset: 0x284531 VA: 0x284430
	public MagicSignalTrack Track打撃命中処理; // 0xB0
	private Transform _homeNode; // 0xB8
	private Transform _targetNode; // 0xC0

	// Properties
	public Vector3 InitialStartPos { get; set; }
	public Vector3 InitialEndPos { get; set; }
	public Transform HomeNode { get; }
	public Transform TargetNode { get; }
	public Vector3 TargetPosition { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2ACB50 Offset: 0x2ACC51 VA: 0x2ACB50
	// RVA: 0x1F930A0 Offset: 0x1F931A1 VA: 0x1F930A0
	public Vector3 get_InitialStartPos() { }

	[CompilerGeneratedAttribute] // RVA: 0x2ACB60 Offset: 0x2ACC61 VA: 0x2ACB60
	// RVA: 0x1F930B0 Offset: 0x1F931B1 VA: 0x1F930B0
	private void set_InitialStartPos(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2ACB70 Offset: 0x2ACC71 VA: 0x2ACB70
	// RVA: 0x1F930C0 Offset: 0x1F931C1 VA: 0x1F930C0
	public Vector3 get_InitialEndPos() { }

	[CompilerGeneratedAttribute] // RVA: 0x2ACB80 Offset: 0x2ACC81 VA: 0x2ACB80
	// RVA: 0x1F930D0 Offset: 0x1F931D1 VA: 0x1F930D0
	private void set_InitialEndPos(Vector3 value) { }

	// RVA: 0x1F930E0 Offset: 0x1F931E1 VA: 0x1F930E0
	public MagicSignalTrack Track(int i) { }

	// RVA: 0x1F93190 Offset: 0x1F93291 VA: 0x1F93190
	public Transform get_HomeNode() { }

	// RVA: 0x1F93250 Offset: 0x1F93351 VA: 0x1F93250
	public Transform get_TargetNode() { }

	// RVA: 0x1F93310 Offset: 0x1F93411 VA: 0x1F93310
	public Vector3 get_TargetPosition() { }

	// RVA: 0x1F93460 Offset: 0x1F93561 VA: 0x1F93460 Slot: 7
	public override void RecalcFlyingTime() { }

	// RVA: 0x1F93660 Offset: 0x1F93761 VA: 0x1F93660 Slot: 4
	public override void OnCharacterSetup(Character owner) { }

	// RVA: 0x1F93670 Offset: 0x1F93771 VA: 0x1F93670 Slot: 5
	public override void OnEnterAttack() { }

	// RVA: 0x1F93820 Offset: 0x1F93921 VA: 0x1F93820 Slot: 6
	public override void OnHitTimePredicted(float worldHitTime) { }

	// RVA: 0x1F93E80 Offset: 0x1F93F81 VA: 0x1F93E80
	public void OnHitMagicSwordHit() { }

	// RVA: 0x1F93ED0 Offset: 0x1F93FD1 VA: 0x1F93ED0
	public GameObject GetIceRockSkippedPrefab仕方なく() { }

	// RVA: 0x1F940E0 Offset: 0x1F941E1 VA: 0x1F940E0
	protected void .ctor() { }
}

