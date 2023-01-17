// Namespace: Combat
[DebuggerDisplayAttribute] // RVA: 0x274A80 Offset: 0x274B81 VA: 0x274A80
public sealed class PrefetchedSignal // TypeDefIndex: 8839
{
	// Fields
	private static PrefetchedSignal s_null; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x284890 Offset: 0x284991 VA: 0x284890
	private string <StateName>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x2848A0 Offset: 0x2849A1 VA: 0x2848A0
	private int <StateHash>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x2848B0 Offset: 0x2849B1 VA: 0x2848B0
	private bool <isInternalNull>k__BackingField; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x2848C0 Offset: 0x2849C1 VA: 0x2848C0
	private AnimationClip <Clip>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x2848D0 Offset: 0x2849D1 VA: 0x2848D0
	private PrefetchedCurve <Curves>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x2848E0 Offset: 0x2849E1 VA: 0x2848E0
	private float <ClipLength>k__BackingField; // 0x30
	private AnimationEvent[] m_ClipEvents; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x2848F0 Offset: 0x2849F1 VA: 0x2848F0
	private float <FT2NT>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x284900 Offset: 0x284A01 VA: 0x284900
	private float <AttackFarRange>k__BackingField; // 0x44
	[CompilerGeneratedAttribute] // RVA: 0x284910 Offset: 0x284A11 VA: 0x284910
	private float <AttackNearRange>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x284920 Offset: 0x284A21 VA: 0x284920
	private float <ForwardCancel>k__BackingField; // 0x4C
	[CompilerGeneratedAttribute] // RVA: 0x284930 Offset: 0x284A31 VA: 0x284930
	private float <RushForwardCancel>k__BackingField; // 0x50
	private float backwardCancelA; // 0x54
	private float backwardCancelB; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x284940 Offset: 0x284A41 VA: 0x284940
	private float <TransitionDuration>k__BackingField; // 0x5C
	[CompilerGeneratedAttribute] // RVA: 0x284950 Offset: 0x284A51 VA: 0x284950
	private Vector3 <LocalRootMoved>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x284960 Offset: 0x284A61 VA: 0x284960
	private WeaponStyle <WeaponStyle>k__BackingField; // 0x6C
	[CompilerGeneratedAttribute] // RVA: 0x284970 Offset: 0x284A71 VA: 0x284970
	private AnimationEvent <HitSignal>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x284980 Offset: 0x284A81 VA: 0x284980
	private int <HitCount>k__BackingField; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x284990 Offset: 0x284A91 VA: 0x284990
	private float <HitTime>k__BackingField; // 0x7C
	[CompilerGeneratedAttribute] // RVA: 0x2849A0 Offset: 0x284AA1 VA: 0x2849A0
	private Vector3 <LocalHitPos>k__BackingField; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x2849B0 Offset: 0x284AB1 VA: 0x2849B0
	private Vector3 <LocalHitDir>k__BackingField; // 0x8C
	public List<float> HitTimesNT; // 0x98
	public List<AnimationEvent> HitSignals; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x2849C0 Offset: 0x284AC1 VA: 0x2849C0
	private float <ShootTime>k__BackingField; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x2849D0 Offset: 0x284AD1 VA: 0x2849D0
	private Vector3 <LocalShootPos>k__BackingField; // 0xAC
	[CompilerGeneratedAttribute] // RVA: 0x2849E0 Offset: 0x284AE1 VA: 0x2849E0
	private Vector3 <LocalShootDir>k__BackingField; // 0xB8
	[CompilerGeneratedAttribute] // RVA: 0x2849F0 Offset: 0x284AF1 VA: 0x2849F0
	private float <HumanDieFallTime>k__BackingField; // 0xC4
	private Vector3[] localDieFallPos; // 0xC8
	[CompilerGeneratedAttribute] // RVA: 0x284A00 Offset: 0x284B01 VA: 0x284A00
	private Vector3 <MotionMatchingVelocity>k__BackingField; // 0xD0
	[CompilerGeneratedAttribute] // RVA: 0x284A10 Offset: 0x284B11 VA: 0x284A10
	private Quaternion <MotionMatchingTorque>k__BackingField; // 0xDC
	private float score; // 0xEC

	// Properties
	public static PrefetchedSignal Null { get; }
	public string StateName { get; set; }
	public int StateHash { get; set; }
	public bool isInternalNull { get; set; }
	public AnimationClip Clip { get; set; }
	public PrefetchedCurve Curves { get; set; }
	public float ClipLength { get; set; }
	public float FT2NT { get; set; }
	public float AttackFarRange { get; set; }
	public float AttackNearRange { get; set; }
	public float ForwardCancel { get; set; }
	public float RushForwardCancel { get; set; }
	public float TransitionDuration { get; set; }
	public Vector3 LocalRootMoved { get; set; }
	public WeaponStyle WeaponStyle { get; set; }
	public AnimationEvent HitSignal { get; set; }
	public int HitCount { get; set; }
	public float HitTime { get; set; }
	public Vector3 LocalHitPos { get; set; }
	public Vector3 LocalHitDir { get; set; }
	public bool IsKnockable { get; }
	public float ShootTime { get; set; }
	public Vector3 LocalShootPos { get; set; }
	public Vector3 LocalShootDir { get; set; }
	public float HitOrShootTime { get; }
	public float HumanDieFallTime { get; set; }
	public Vector3 MotionMatchingVelocity { get; set; }
	public Quaternion MotionMatchingTorque { get; set; }
	public float Score { get; set; }
	public bool IsAttackRangeValid { get; }
	public float ForwardCancelNT { get; }
	public float RushForwardCancelNT { get; }

	// Methods

	// RVA: 0x29DB400 Offset: 0x29DB501 VA: 0x29DB400
	public static bool op_Implicit(PrefetchedSignal a) { }

	// RVA: 0x29DB410 Offset: 0x29DB511 VA: 0x29DB410
	public static PrefetchedSignal get_Null() { }

	// RVA: 0x29DB4A0 Offset: 0x29DB5A1 VA: 0x29DB4A0
	private static PrefetchedSignal CreateNull() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD2D0 Offset: 0x2AD3D1 VA: 0x2AD2D0
	// RVA: 0x29DB790 Offset: 0x29DB891 VA: 0x29DB790
	public string get_StateName() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD2E0 Offset: 0x2AD3E1 VA: 0x2AD2E0
	// RVA: 0x29DB7A0 Offset: 0x29DB8A1 VA: 0x29DB7A0
	private void set_StateName(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD2F0 Offset: 0x2AD3F1 VA: 0x2AD2F0
	// RVA: 0x29DB7B0 Offset: 0x29DB8B1 VA: 0x29DB7B0
	public int get_StateHash() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD300 Offset: 0x2AD401 VA: 0x2AD300
	// RVA: 0x29DB7C0 Offset: 0x29DB8C1 VA: 0x29DB7C0
	private void set_StateHash(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD310 Offset: 0x2AD411 VA: 0x2AD310
	// RVA: 0x29DB7D0 Offset: 0x29DB8D1 VA: 0x29DB7D0
	public bool get_isInternalNull() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD320 Offset: 0x2AD421 VA: 0x2AD320
	// RVA: 0x29DB7E0 Offset: 0x29DB8E1 VA: 0x29DB7E0
	private void set_isInternalNull(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD330 Offset: 0x2AD431 VA: 0x2AD330
	// RVA: 0x29DB7F0 Offset: 0x29DB8F1 VA: 0x29DB7F0
	public AnimationClip get_Clip() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD340 Offset: 0x2AD441 VA: 0x2AD340
	// RVA: 0x29DB800 Offset: 0x29DB901 VA: 0x29DB800
	private void set_Clip(AnimationClip value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD350 Offset: 0x2AD451 VA: 0x2AD350
	// RVA: 0x29DB810 Offset: 0x29DB911 VA: 0x29DB810
	public PrefetchedCurve get_Curves() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD360 Offset: 0x2AD461 VA: 0x2AD360
	// RVA: 0x29DB820 Offset: 0x29DB921 VA: 0x29DB820
	private void set_Curves(PrefetchedCurve value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD370 Offset: 0x2AD471 VA: 0x2AD370
	// RVA: 0x29DB830 Offset: 0x29DB931 VA: 0x29DB830
	public float get_ClipLength() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD380 Offset: 0x2AD481 VA: 0x2AD380
	// RVA: 0x29DB840 Offset: 0x29DB941 VA: 0x29DB840
	private void set_ClipLength(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD390 Offset: 0x2AD491 VA: 0x2AD390
	// RVA: 0x29DB850 Offset: 0x29DB951 VA: 0x29DB850
	public float get_FT2NT() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD3A0 Offset: 0x2AD4A1 VA: 0x2AD3A0
	// RVA: 0x29DB860 Offset: 0x29DB961 VA: 0x29DB860
	private void set_FT2NT(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD3B0 Offset: 0x2AD4B1 VA: 0x2AD3B0
	// RVA: 0x29DB870 Offset: 0x29DB971 VA: 0x29DB870
	public float get_AttackFarRange() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD3C0 Offset: 0x2AD4C1 VA: 0x2AD3C0
	// RVA: 0x29DB880 Offset: 0x29DB981 VA: 0x29DB880
	private void set_AttackFarRange(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD3D0 Offset: 0x2AD4D1 VA: 0x2AD3D0
	// RVA: 0x29DB890 Offset: 0x29DB991 VA: 0x29DB890
	public float get_AttackNearRange() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD3E0 Offset: 0x2AD4E1 VA: 0x2AD3E0
	// RVA: 0x29DB8A0 Offset: 0x29DB9A1 VA: 0x29DB8A0
	private void set_AttackNearRange(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD3F0 Offset: 0x2AD4F1 VA: 0x2AD3F0
	// RVA: 0x29DB8B0 Offset: 0x29DB9B1 VA: 0x29DB8B0
	public float get_ForwardCancel() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD400 Offset: 0x2AD501 VA: 0x2AD400
	// RVA: 0x29DB8C0 Offset: 0x29DB9C1 VA: 0x29DB8C0
	private void set_ForwardCancel(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD410 Offset: 0x2AD511 VA: 0x2AD410
	// RVA: 0x29DB8D0 Offset: 0x29DB9D1 VA: 0x29DB8D0
	public float get_RushForwardCancel() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD420 Offset: 0x2AD521 VA: 0x2AD420
	// RVA: 0x29DB8E0 Offset: 0x29DB9E1 VA: 0x29DB8E0
	private void set_RushForwardCancel(float value) { }

	// RVA: 0x29DB8F0 Offset: 0x29DB9F1 VA: 0x29DB8F0
	public float BackwardCancel(float ratio) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD430 Offset: 0x2AD531 VA: 0x2AD430
	// RVA: 0x29DB910 Offset: 0x29DBA11 VA: 0x29DB910
	public float get_TransitionDuration() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD440 Offset: 0x2AD541 VA: 0x2AD440
	// RVA: 0x29DB920 Offset: 0x29DBA21 VA: 0x29DB920
	private void set_TransitionDuration(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD450 Offset: 0x2AD551 VA: 0x2AD450
	// RVA: 0x29DB930 Offset: 0x29DBA31 VA: 0x29DB930
	public Vector3 get_LocalRootMoved() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD460 Offset: 0x2AD561 VA: 0x2AD460
	// RVA: 0x29DB940 Offset: 0x29DBA41 VA: 0x29DB940
	private void set_LocalRootMoved(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD470 Offset: 0x2AD571 VA: 0x2AD470
	// RVA: 0x29DB950 Offset: 0x29DBA51 VA: 0x29DB950
	public WeaponStyle get_WeaponStyle() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD480 Offset: 0x2AD581 VA: 0x2AD480
	// RVA: 0x29DB960 Offset: 0x29DBA61 VA: 0x29DB960
	private void set_WeaponStyle(WeaponStyle value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD490 Offset: 0x2AD591 VA: 0x2AD490
	// RVA: 0x29DB970 Offset: 0x29DBA71 VA: 0x29DB970
	public AnimationEvent get_HitSignal() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD4A0 Offset: 0x2AD5A1 VA: 0x2AD4A0
	// RVA: 0x29DB980 Offset: 0x29DBA81 VA: 0x29DB980
	private void set_HitSignal(AnimationEvent value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD4B0 Offset: 0x2AD5B1 VA: 0x2AD4B0
	// RVA: 0x29DB990 Offset: 0x29DBA91 VA: 0x29DB990
	public int get_HitCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD4C0 Offset: 0x2AD5C1 VA: 0x2AD4C0
	// RVA: 0x29DB9A0 Offset: 0x29DBAA1 VA: 0x29DB9A0
	private void set_HitCount(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD4D0 Offset: 0x2AD5D1 VA: 0x2AD4D0
	// RVA: 0x29DB9B0 Offset: 0x29DBAB1 VA: 0x29DB9B0
	public float get_HitTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD4E0 Offset: 0x2AD5E1 VA: 0x2AD4E0
	// RVA: 0x29DB9C0 Offset: 0x29DBAC1 VA: 0x29DB9C0
	private void set_HitTime(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD4F0 Offset: 0x2AD5F1 VA: 0x2AD4F0
	// RVA: 0x29DB9D0 Offset: 0x29DBAD1 VA: 0x29DB9D0
	public Vector3 get_LocalHitPos() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD500 Offset: 0x2AD601 VA: 0x2AD500
	// RVA: 0x29DB9E0 Offset: 0x29DBAE1 VA: 0x29DB9E0
	private void set_LocalHitPos(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD510 Offset: 0x2AD611 VA: 0x2AD510
	// RVA: 0x29DB9F0 Offset: 0x29DBAF1 VA: 0x29DB9F0
	public Vector3 get_LocalHitDir() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD520 Offset: 0x2AD621 VA: 0x2AD520
	// RVA: 0x29DBA00 Offset: 0x29DBB01 VA: 0x29DBA00
	private void set_LocalHitDir(Vector3 value) { }

	// RVA: 0x29DBA10 Offset: 0x29DBB11 VA: 0x29DBA10
	public bool get_IsKnockable() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD530 Offset: 0x2AD631 VA: 0x2AD530
	// RVA: 0x29DBA50 Offset: 0x29DBB51 VA: 0x29DBA50
	public float get_ShootTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD540 Offset: 0x2AD641 VA: 0x2AD540
	// RVA: 0x29DBA60 Offset: 0x29DBB61 VA: 0x29DBA60
	private void set_ShootTime(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD550 Offset: 0x2AD651 VA: 0x2AD550
	// RVA: 0x29DBA70 Offset: 0x29DBB71 VA: 0x29DBA70
	public Vector3 get_LocalShootPos() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD560 Offset: 0x2AD661 VA: 0x2AD560
	// RVA: 0x29DBA80 Offset: 0x29DBB81 VA: 0x29DBA80
	private void set_LocalShootPos(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD570 Offset: 0x2AD671 VA: 0x2AD570
	// RVA: 0x29DBA90 Offset: 0x29DBB91 VA: 0x29DBA90
	public Vector3 get_LocalShootDir() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD580 Offset: 0x2AD681 VA: 0x2AD580
	// RVA: 0x29DBAA0 Offset: 0x29DBBA1 VA: 0x29DBAA0
	private void set_LocalShootDir(Vector3 value) { }

	// RVA: 0x29DBAB0 Offset: 0x29DBBB1 VA: 0x29DBAB0
	public float get_HitOrShootTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD590 Offset: 0x2AD691 VA: 0x2AD590
	// RVA: 0x29DBAD0 Offset: 0x29DBBD1 VA: 0x29DBAD0
	public float get_HumanDieFallTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD5A0 Offset: 0x2AD6A1 VA: 0x2AD5A0
	// RVA: 0x29DBAE0 Offset: 0x29DBBE1 VA: 0x29DBAE0
	private void set_HumanDieFallTime(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD5B0 Offset: 0x2AD6B1 VA: 0x2AD5B0
	// RVA: 0x29DBAF0 Offset: 0x29DBBF1 VA: 0x29DBAF0
	public Vector3 get_MotionMatchingVelocity() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD5C0 Offset: 0x2AD6C1 VA: 0x2AD5C0
	// RVA: 0x29DBB00 Offset: 0x29DBC01 VA: 0x29DBB00
	private void set_MotionMatchingVelocity(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD5D0 Offset: 0x2AD6D1 VA: 0x2AD5D0
	// RVA: 0x29DBB10 Offset: 0x29DBC11 VA: 0x29DBB10
	public Quaternion get_MotionMatchingTorque() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD5E0 Offset: 0x2AD6E1 VA: 0x2AD5E0
	// RVA: 0x29DBB20 Offset: 0x29DBC21 VA: 0x29DBB20
	private void set_MotionMatchingTorque(Quaternion value) { }

	// RVA: 0x29DBB40 Offset: 0x29DBC41 VA: 0x29DBB40
	public float get_Score() { }

	// RVA: 0x29DBB50 Offset: 0x29DBC51 VA: 0x29DBB50
	public void set_Score(float value) { }

	// RVA: 0x29DBB80 Offset: 0x29DBC81 VA: 0x29DBB80
	public bool get_IsAttackRangeValid() { }

	// RVA: 0x29DBB90 Offset: 0x29DBC91 VA: 0x29DBB90
	public float get_ForwardCancelNT() { }

	// RVA: 0x29DBBA0 Offset: 0x29DBCA1 VA: 0x29DBBA0
	public float get_RushForwardCancelNT() { }

	// RVA: 0x29DBBB0 Offset: 0x29DBCB1 VA: 0x29DBBB0
	public float BackwardCancelNT(float ratio) { }

	// RVA: 0x29DBBE0 Offset: 0x29DBCE1 VA: 0x29DBBE0
	public void GetBackwardCancelABNTForDebug(out float a, out float b) { }

	// RVA: 0x29DBC10 Offset: 0x29DBD11 VA: 0x29DBC10
	public Vector3 WorldRootMoved(Transform t) { }

	// RVA: 0x29DBC30 Offset: 0x29DBD31 VA: 0x29DBC30
	public Vector3 WorldDieFallPos(Transform t, int index) { }

	// RVA: 0x29DBEB0 Offset: 0x29DBFB1 VA: 0x29DBEB0
	public bool WillCollide(Character CP) { }

	// RVA: 0x29DBFD0 Offset: 0x29DC0D1 VA: 0x29DBFD0
	public float CalcDistanceToColliderAtRootMoved(Character CP) { }

	// RVA: 0x29DC120 Offset: 0x29DC221 VA: 0x29DC120
	public bool IsObstractedBetweenRootMovedAndEnemy(Character CP) { }

	// RVA: 0x29DB560 Offset: 0x29DB661 VA: 0x29DB560
	public void .ctor(string stateName, int stateHash, GameObject bodyGO, AnimationClip bodyAnim, GameObject rideGO, AnimationClip rideAnim) { }

	// RVA: 0x29DC2C0 Offset: 0x29DC3C1 VA: 0x29DC2C0
	private PrefetchedCurve GetPrefetchedCurve(AnimationClip clip) { }

	// RVA: 0x29DC400 Offset: 0x29DC501 VA: 0x29DC400
	private void ImportFromSignals(AnimationEvent[] events) { }
}

