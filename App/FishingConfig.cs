// Namespace: App
[Serializable]
public abstract class FishingConfig : MonoBehaviour // TypeDefIndex: 10579
{
	// Fields
	[SerializeField] // RVA: 0x2911E0 Offset: 0x2912E1 VA: 0x2911E0
	public bool OpenBase; // 0x18
	[SerializeField] // RVA: 0x2911F0 Offset: 0x2912F1 VA: 0x2911F0
	public bool OpenCamera; // 0x19
	[SerializeField] // RVA: 0x291200 Offset: 0x291301 VA: 0x291200
	public bool OpenBattle; // 0x1A
	[SerializeField] // RVA: 0x291210 Offset: 0x291311 VA: 0x291210
	[HeaderAttribute] // RVA: 0x291210 Offset: 0x291311 VA: 0x291210
	[TooltipAttribute] // RVA: 0x291210 Offset: 0x291311 VA: 0x291210
	public Vector3 m_PlayerBasePos; // 0x1C
	[SerializeField] // RVA: 0x291280 Offset: 0x291381 VA: 0x291280
	[TooltipAttribute] // RVA: 0x291280 Offset: 0x291381 VA: 0x291280
	public Vector3 m_PlayerBaseRot; // 0x28
	[SerializeField] // RVA: 0x2912D0 Offset: 0x2913D1 VA: 0x2912D0
	[HeaderAttribute] // RVA: 0x2912D0 Offset: 0x2913D1 VA: 0x2912D0
	[TooltipAttribute] // RVA: 0x2912D0 Offset: 0x2913D1 VA: 0x2912D0
	public Vector3 m_SolaBasePos; // 0x34
	[TooltipAttribute] // RVA: 0x291340 Offset: 0x291441 VA: 0x291340
	[SerializeField] // RVA: 0x291340 Offset: 0x291441 VA: 0x291340
	public Vector3 m_SolaBaseRot; // 0x40
	[TooltipAttribute] // RVA: 0x291390 Offset: 0x291491 VA: 0x291390
	[SerializeField] // RVA: 0x291390 Offset: 0x291491 VA: 0x291390
	public Vector3 m_SolaDefeatRot; // 0x4C
	[TooltipAttribute] // RVA: 0x2913E0 Offset: 0x2914E1 VA: 0x2913E0
	[SerializeField] // RVA: 0x2913E0 Offset: 0x2914E1 VA: 0x2913E0
	public float m_CameraRotateSpeed; // 0x58
	[TooltipAttribute] // RVA: 0x291430 Offset: 0x291531 VA: 0x291430
	[SerializeField] // RVA: 0x291430 Offset: 0x291531 VA: 0x291430
	public float m_DistanceMoveSpeed; // 0x5C
	[SerializeField] // RVA: 0x291480 Offset: 0x291581 VA: 0x291480
	[TooltipAttribute] // RVA: 0x291480 Offset: 0x291581 VA: 0x291480
	public float m_LureHeightDiff; // 0x60
	[SerializeField] // RVA: 0x2914D0 Offset: 0x2915D1 VA: 0x2914D0
	[TooltipAttribute] // RVA: 0x2914D0 Offset: 0x2915D1 VA: 0x2914D0
	public float m_RotateMinimum; // 0x64
	[TooltipAttribute] // RVA: 0x291520 Offset: 0x291621 VA: 0x291520
	[SerializeField] // RVA: 0x291520 Offset: 0x291621 VA: 0x291520
	public float m_RotateMax; // 0x68
	[SerializeField] // RVA: 0x291570 Offset: 0x291671 VA: 0x291570
	[TooltipAttribute] // RVA: 0x291570 Offset: 0x291671 VA: 0x291570
	public float m_DistanceMinimum; // 0x6C
	[SerializeField] // RVA: 0x2915C0 Offset: 0x2916C1 VA: 0x2915C0
	[TooltipAttribute] // RVA: 0x2915C0 Offset: 0x2916C1 VA: 0x2915C0
	public float m_DistanceMax; // 0x70
	[SerializeField] // RVA: 0x291610 Offset: 0x291711 VA: 0x291610
	[TooltipAttribute] // RVA: 0x291610 Offset: 0x291711 VA: 0x291610
	public float m_WaterSurfaceHeight; // 0x74
	[TooltipAttribute] // RVA: 0x291660 Offset: 0x291761 VA: 0x291660
	[SerializeField] // RVA: 0x291660 Offset: 0x291761 VA: 0x291660
	public float m_ThrowInShowLureTime; // 0x78
	[SerializeField] // RVA: 0x2916B0 Offset: 0x2917B1 VA: 0x2916B0
	[TooltipAttribute] // RVA: 0x2916B0 Offset: 0x2917B1 VA: 0x2916B0
	public float m_ThrowInTime; // 0x7C
	[TooltipAttribute] // RVA: 0x291700 Offset: 0x291801 VA: 0x291700
	[SerializeField] // RVA: 0x291700 Offset: 0x291801 VA: 0x291700
	public float m_ThrowSEPlaySec; // 0x80
	[SerializeField] // RVA: 0x291750 Offset: 0x291851 VA: 0x291750
	[TooltipAttribute] // RVA: 0x291750 Offset: 0x291851 VA: 0x291750
	public float m_ThrowCameraChangeSec; // 0x84
	[TooltipAttribute] // RVA: 0x2917A0 Offset: 0x2918A1 VA: 0x2917A0
	[SerializeField] // RVA: 0x2917A0 Offset: 0x2918A1 VA: 0x2917A0
	public float m_ThrowInSinkSec; // 0x88
	[TooltipAttribute] // RVA: 0x2917F0 Offset: 0x2918F1 VA: 0x2917F0
	[SerializeField] // RVA: 0x2917F0 Offset: 0x2918F1 VA: 0x2917F0
	public float m_ResultTime; // 0x8C
	[SerializeField] // RVA: 0x291840 Offset: 0x291941 VA: 0x291840
	[TooltipAttribute] // RVA: 0x291840 Offset: 0x291941 VA: 0x291840
	public float m_FishChangeAppearTime; // 0x90
	[SerializeField] // RVA: 0x291890 Offset: 0x291991 VA: 0x291890
	[TooltipAttribute] // RVA: 0x291890 Offset: 0x291991 VA: 0x291890
	public float m_FishChangePercentage; // 0x94
	[TooltipAttribute] // RVA: 0x2918E0 Offset: 0x2919E1 VA: 0x2918E0
	[SerializeField] // RVA: 0x2918E0 Offset: 0x2919E1 VA: 0x2918E0
	public float m_FishFaintPercentage; // 0x98
	[SerializeField] // RVA: 0x291930 Offset: 0x291A31 VA: 0x291930
	[TooltipAttribute] // RVA: 0x291930 Offset: 0x291A31 VA: 0x291930
	public int m_FishFaintMaxCount; // 0x9C
	[TooltipAttribute] // RVA: 0x291980 Offset: 0x291A81 VA: 0x291980
	[SerializeField] // RVA: 0x291980 Offset: 0x291A81 VA: 0x291980
	public float m_FishCatchingTimeMax; // 0xA0
	[TooltipAttribute] // RVA: 0x2919D0 Offset: 0x291AD1 VA: 0x2919D0
	[SerializeField] // RVA: 0x2919D0 Offset: 0x291AD1 VA: 0x2919D0
	public float ripplesInterval; // 0xA4
	[TooltipAttribute] // RVA: 0x291A20 Offset: 0x291B21 VA: 0x291A20
	[SerializeField] // RVA: 0x291A20 Offset: 0x291B21 VA: 0x291A20
	public Vector3[] ripplesPosList; // 0xA8
	[SerializeField] // RVA: 0x291A70 Offset: 0x291B71 VA: 0x291A70
	[TooltipAttribute] // RVA: 0x291A70 Offset: 0x291B71 VA: 0x291A70
	public float ripplesRandomRange; // 0xB0
	[TooltipAttribute] // RVA: 0x291AC0 Offset: 0x291BC1 VA: 0x291AC0
	[SerializeField] // RVA: 0x291AC0 Offset: 0x291BC1 VA: 0x291AC0
	public float m_NormalFOV; // 0xB4
	[SerializeField] // RVA: 0x291B10 Offset: 0x291C11 VA: 0x291B10
	[TooltipAttribute] // RVA: 0x291B10 Offset: 0x291C11 VA: 0x291B10
	public float m_WaitFOV; // 0xB8
	[TooltipAttribute] // RVA: 0x291B60 Offset: 0x291C61 VA: 0x291B60
	[SerializeField] // RVA: 0x291B60 Offset: 0x291C61 VA: 0x291B60
	public float m_CameraDistance; // 0xBC
	[TooltipAttribute] // RVA: 0x291BB0 Offset: 0x291CB1 VA: 0x291BB0
	[SerializeField] // RVA: 0x291BB0 Offset: 0x291CB1 VA: 0x291BB0
	public float m_CameraHeight; // 0xC0
	[SerializeField] // RVA: 0x291C00 Offset: 0x291D01 VA: 0x291C00
	[TooltipAttribute] // RVA: 0x291C00 Offset: 0x291D01 VA: 0x291C00
	public Vector3 m_CameraOffset; // 0xC4
	[SerializeField] // RVA: 0x291C50 Offset: 0x291D51 VA: 0x291C50
	[TooltipAttribute] // RVA: 0x291C50 Offset: 0x291D51 VA: 0x291C50
	public FishingConfig.FixCameraConfig m_RodSelectCamera; // 0xD0
	[SerializeField] // RVA: 0x291CA0 Offset: 0x291DA1 VA: 0x291CA0
	[TooltipAttribute] // RVA: 0x291CA0 Offset: 0x291DA1 VA: 0x291CA0
	public Vector3 m_LureCameraDiff; // 0xD8
	[TooltipAttribute] // RVA: 0x291CF0 Offset: 0x291DF1 VA: 0x291CF0
	[SerializeField] // RVA: 0x291CF0 Offset: 0x291DF1 VA: 0x291CF0
	public Vector3 m_LureCameraRot; // 0xE4
	[TooltipAttribute] // RVA: 0x291D40 Offset: 0x291E41 VA: 0x291D40
	[SerializeField] // RVA: 0x291D40 Offset: 0x291E41 VA: 0x291D40
	public float m_LureSetFallHeight; // 0xF0
	[TooltipAttribute] // RVA: 0x291D90 Offset: 0x291E91 VA: 0x291D90
	[SerializeField] // RVA: 0x291D90 Offset: 0x291E91 VA: 0x291D90
	public float m_LureFallFirstSpeed; // 0xF4
	[TooltipAttribute] // RVA: 0x291DE0 Offset: 0x291EE1 VA: 0x291DE0
	[SerializeField] // RVA: 0x291DE0 Offset: 0x291EE1 VA: 0x291DE0
	public float m_LureDumpDepth; // 0xF8
	[TooltipAttribute] // RVA: 0x291E30 Offset: 0x291F31 VA: 0x291E30
	[SerializeField] // RVA: 0x291E30 Offset: 0x291F31 VA: 0x291E30
	public float m_LureDumpMsec; // 0xFC
	[SerializeField] // RVA: 0x291E80 Offset: 0x291F81 VA: 0x291E80
	[TooltipAttribute] // RVA: 0x291E80 Offset: 0x291F81 VA: 0x291E80
	public FishingConfig.FixCameraConfig m_BattleCamera; // 0x100
	[TooltipAttribute] // RVA: 0x291ED0 Offset: 0x291FD1 VA: 0x291ED0
	[SerializeField] // RVA: 0x291ED0 Offset: 0x291FD1 VA: 0x291ED0
	public float[] m_BattleCameraAngleBorder; // 0x108
	[TooltipAttribute] // RVA: 0x291F20 Offset: 0x292021 VA: 0x291F20
	[SerializeField] // RVA: 0x291F20 Offset: 0x292021 VA: 0x291F20
	public float[] m_BattleCameraAngleLimit; // 0x110
	[SerializeField] // RVA: 0x291F70 Offset: 0x292071 VA: 0x291F70
	[TooltipAttribute] // RVA: 0x291F70 Offset: 0x292071 VA: 0x291F70
	public int m_BattleCameraLerpCount; // 0x118
	[SerializeField] // RVA: 0x291FC0 Offset: 0x2920C1 VA: 0x291FC0
	[TooltipAttribute] // RVA: 0x291FC0 Offset: 0x2920C1 VA: 0x291FC0
	public int m_BattleCameraReverseLerpCount; // 0x11C
	[SerializeField] // RVA: 0x292010 Offset: 0x292111 VA: 0x292010
	[TooltipAttribute] // RVA: 0x292010 Offset: 0x292111 VA: 0x292010
	public FadeType m_DefeatFadeOutType; // 0x120
	[SerializeField] // RVA: 0x292060 Offset: 0x292161 VA: 0x292060
	[TooltipAttribute] // RVA: 0x292060 Offset: 0x292161 VA: 0x292060
	public float m_DefeatAnimeFrame; // 0x124
	[SerializeField] // RVA: 0x2920B0 Offset: 0x2921B1 VA: 0x2920B0
	[TooltipAttribute] // RVA: 0x2920B0 Offset: 0x2921B1 VA: 0x2920B0
	public float m_DefeatFadeStartFrame; // 0x128
	[TooltipAttribute] // RVA: 0x292100 Offset: 0x292201 VA: 0x292100
	[SerializeField] // RVA: 0x292100 Offset: 0x292201 VA: 0x292100
	public FadeType m_ResultFadeInType; // 0x12C
	[SerializeField] // RVA: 0x292150 Offset: 0x292251 VA: 0x292150
	[TooltipAttribute] // RVA: 0x292150 Offset: 0x292251 VA: 0x292150
	public FishingConfig.FixCameraConfig m_ResultCamera; // 0x130
	[SerializeField] // RVA: 0x2921A0 Offset: 0x2922A1 VA: 0x2921A0
	[TooltipAttribute] // RVA: 0x2921A0 Offset: 0x2922A1 VA: 0x2921A0
	public float m_ResultPlayerRotY; // 0x138
	[TooltipAttribute] // RVA: 0x2921F0 Offset: 0x2922F1 VA: 0x2921F0
	[SerializeField] // RVA: 0x2921F0 Offset: 0x2922F1 VA: 0x2921F0
	public float m_HitPopupTimeSecond; // 0x13C
	[TooltipAttribute] // RVA: 0x292240 Offset: 0x292341 VA: 0x292240
	[SerializeField] // RVA: 0x292240 Offset: 0x292341 VA: 0x292240
	public float m_LethalTimeSecond; // 0x140
	[TooltipAttribute] // RVA: 0x292290 Offset: 0x292391 VA: 0x292290
	[SerializeField] // RVA: 0x292290 Offset: 0x292391 VA: 0x292290
	public float m_LethalIncrease; // 0x144
	[TooltipAttribute] // RVA: 0x2922E0 Offset: 0x2923E1 VA: 0x2922E0
	[SerializeField] // RVA: 0x2922E0 Offset: 0x2923E1 VA: 0x2922E0
	public float m_LethalDecrease; // 0x148
	[TooltipAttribute] // RVA: 0x292330 Offset: 0x292431 VA: 0x292330
	[SerializeField] // RVA: 0x292330 Offset: 0x292431 VA: 0x292330
	public float m_SmashStickSpeed; // 0x14C
	[SerializeField] // RVA: 0x292380 Offset: 0x292481 VA: 0x292380
	[TooltipAttribute] // RVA: 0x292380 Offset: 0x292481 VA: 0x292380
	public float m_AttackPower; // 0x150
	[SerializeField] // RVA: 0x2923D0 Offset: 0x2924D1 VA: 0x2923D0
	[TooltipAttribute] // RVA: 0x2923D0 Offset: 0x2924D1 VA: 0x2923D0
	public float m_StickWaitFrameAtAttack; // 0x154
	[SerializeField] // RVA: 0x292420 Offset: 0x292521 VA: 0x292420
	[TooltipAttribute] // RVA: 0x292420 Offset: 0x292521 VA: 0x292420
	public float m_AtAttackWaitFrameAtStick; // 0x158
	[SerializeField] // RVA: 0x292470 Offset: 0x292571 VA: 0x292470
	[TooltipAttribute] // RVA: 0x292470 Offset: 0x292571 VA: 0x292470
	public FishingConfig.AngleBorder m_AngleBorder; // 0x160
	[SerializeField] // RVA: 0x2924C0 Offset: 0x2925C1 VA: 0x2924C0
	[TooltipAttribute] // RVA: 0x2924C0 Offset: 0x2925C1 VA: 0x2924C0
	public float m_RadarAngle; // 0x168
	[SerializeField] // RVA: 0x292510 Offset: 0x292611 VA: 0x292510
	[TooltipAttribute] // RVA: 0x292510 Offset: 0x292611 VA: 0x292510
	public float m_RadarShadowScale; // 0x16C
	[SerializeField] // RVA: 0x292560 Offset: 0x292661 VA: 0x292560
	[TooltipAttribute] // RVA: 0x292560 Offset: 0x292661 VA: 0x292560
	public float m_RadarDistanceMax; // 0x170
	[SerializeField] // RVA: 0x2925B0 Offset: 0x2926B1 VA: 0x2925B0
	[TooltipAttribute] // RVA: 0x2925B0 Offset: 0x2926B1 VA: 0x2925B0
	public float m_RadarDistanceMin; // 0x174
	[SerializeField] // RVA: 0x292600 Offset: 0x292701 VA: 0x292600
	[TooltipAttribute] // RVA: 0x292600 Offset: 0x292701 VA: 0x292600
	public float m_RadarEscapeRate; // 0x178
	[SerializeField] // RVA: 0x292650 Offset: 0x292751 VA: 0x292650
	[TooltipAttribute] // RVA: 0x292650 Offset: 0x292751 VA: 0x292650
	public float m_RadarStopCounterRate; // 0x17C
	[TooltipAttribute] // RVA: 0x2926A0 Offset: 0x2927A1 VA: 0x2926A0
	[SerializeField] // RVA: 0x2926A0 Offset: 0x2927A1 VA: 0x2926A0
	public float m_FishEscapeSec; // 0x180
	[SerializeField] // RVA: 0x2926F0 Offset: 0x2927F1 VA: 0x2926F0
	[TooltipAttribute] // RVA: 0x2926F0 Offset: 0x2927F1 VA: 0x2926F0
	public float m_MinFishCounterTime; // 0x184
	[SerializeField] // RVA: 0x292740 Offset: 0x292841 VA: 0x292740
	[TooltipAttribute] // RVA: 0x292740 Offset: 0x292841 VA: 0x292740
	public float m_LethalRecoveryHPPercent; // 0x188
	[SerializeField] // RVA: 0x292790 Offset: 0x292891 VA: 0x292790
	[TooltipAttribute] // RVA: 0x292790 Offset: 0x292891 VA: 0x292790
	public float m_HPGaugeMoveWait; // 0x18C
	[TooltipAttribute] // RVA: 0x2927E0 Offset: 0x2928E1 VA: 0x2927E0
	[SerializeField] // RVA: 0x2927E0 Offset: 0x2928E1 VA: 0x2927E0
	public float m_HPGaugeMoveSpeed; // 0x190
	[TooltipAttribute] // RVA: 0x292830 Offset: 0x292931 VA: 0x292830
	[SerializeField] // RVA: 0x292830 Offset: 0x292931 VA: 0x292830
	public float m_FirstAttackDamageRate; // 0x194
	[TooltipAttribute] // RVA: 0x292880 Offset: 0x292981 VA: 0x292880
	[SerializeField] // RVA: 0x292880 Offset: 0x292981 VA: 0x292880
	public float m_AssistShowSec; // 0x198
	[TooltipAttribute] // RVA: 0x2928D0 Offset: 0x2929D1 VA: 0x2928D0
	[SerializeField] // RVA: 0x2928D0 Offset: 0x2929D1 VA: 0x2928D0
	public float m_BattleSplashInterval; // 0x19C
	[SerializeField] // RVA: 0x292920 Offset: 0x292A21 VA: 0x292920
	[TooltipAttribute] // RVA: 0x292920 Offset: 0x292A21 VA: 0x292920
	public float m_BattleCounterSplashInterval; // 0x1A0

	// Methods

	// RVA: 0x2EF3650 Offset: 0x2EF3751 VA: 0x2EF3650
	private void Start() { }

	// RVA: 0x2EF3660 Offset: 0x2EF3761 VA: 0x2EF3660
	private void Update() { }

	// RVA: 0x2EF3670 Offset: 0x2EF3771 VA: 0x2EF3670
	protected void .ctor() { }
}

