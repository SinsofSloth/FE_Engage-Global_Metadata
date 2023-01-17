// Namespace: App
[Serializable]
public abstract class FishingConfig_Base : MonoBehaviour // TypeDefIndex: 10564
{
	// Fields
	[SerializeField] // RVA: 0x28F5C0 Offset: 0x28F6C1 VA: 0x28F5C0
	[HeaderAttribute] // RVA: 0x28F5C0 Offset: 0x28F6C1 VA: 0x28F5C0
	[TooltipAttribute] // RVA: 0x28F5C0 Offset: 0x28F6C1 VA: 0x28F5C0
	public Vector3 m_PlayerBasePos; // 0x18
	[SerializeField] // RVA: 0x28F630 Offset: 0x28F731 VA: 0x28F630
	[TooltipAttribute] // RVA: 0x28F630 Offset: 0x28F731 VA: 0x28F630
	public Vector3 m_PlayerBaseRot; // 0x24
	[TooltipAttribute] // RVA: 0x28F680 Offset: 0x28F781 VA: 0x28F680
	[SerializeField] // RVA: 0x28F680 Offset: 0x28F781 VA: 0x28F680
	[HeaderAttribute] // RVA: 0x28F680 Offset: 0x28F781 VA: 0x28F680
	public Vector3 m_SolaBasePos; // 0x30
	[TooltipAttribute] // RVA: 0x28F6F0 Offset: 0x28F7F1 VA: 0x28F6F0
	[SerializeField] // RVA: 0x28F6F0 Offset: 0x28F7F1 VA: 0x28F6F0
	public Vector3 m_SolaBaseRot; // 0x3C
	[SerializeField] // RVA: 0x28F740 Offset: 0x28F841 VA: 0x28F740
	[TooltipAttribute] // RVA: 0x28F740 Offset: 0x28F841 VA: 0x28F740
	public float m_WaterSurfaceHeight; // 0x48
	[SerializeField] // RVA: 0x28F790 Offset: 0x28F891 VA: 0x28F790
	[TooltipAttribute] // RVA: 0x28F790 Offset: 0x28F891 VA: 0x28F790
	public float m_NormalFOV; // 0x4C
	[SerializeField] // RVA: 0x28F7E0 Offset: 0x28F8E1 VA: 0x28F7E0
	[TooltipAttribute] // RVA: 0x28F7E0 Offset: 0x28F8E1 VA: 0x28F7E0
	public float m_WaitFOV; // 0x50
	[SerializeField] // RVA: 0x28F830 Offset: 0x28F931 VA: 0x28F830
	[TooltipAttribute] // RVA: 0x28F830 Offset: 0x28F931 VA: 0x28F830
	public float m_CameraDistance; // 0x54
	[TooltipAttribute] // RVA: 0x28F880 Offset: 0x28F981 VA: 0x28F880
	[SerializeField] // RVA: 0x28F880 Offset: 0x28F981 VA: 0x28F880
	public float m_CameraHeight; // 0x58
	[SerializeField] // RVA: 0x28F8D0 Offset: 0x28F9D1 VA: 0x28F8D0
	[TooltipAttribute] // RVA: 0x28F8D0 Offset: 0x28F9D1 VA: 0x28F8D0
	public Vector3 m_CameraOffset; // 0x5C
	[TooltipAttribute] // RVA: 0x28F920 Offset: 0x28FA21 VA: 0x28F920
	[SerializeField] // RVA: 0x28F920 Offset: 0x28FA21 VA: 0x28F920
	public FixCameraConfig m_RodSelectCamera; // 0x68

	// Methods

	// RVA: 0x2EF3AA0 Offset: 0x2EF3BA1 VA: 0x2EF3AA0
	protected void .ctor() { }
}

// Namespace: App
[Serializable]
public abstract class FishingConfig_Battle : MonoBehaviour // TypeDefIndex: 10566
{
	// Fields
	[TooltipAttribute] // RVA: 0x28F970 Offset: 0x28FA71 VA: 0x28F970
	[SerializeField] // RVA: 0x28F970 Offset: 0x28FA71 VA: 0x28F970
	public FixCameraConfig m_BattleCamera; // 0x18
	[TooltipAttribute] // RVA: 0x28F9C0 Offset: 0x28FAC1 VA: 0x28F9C0
	[SerializeField] // RVA: 0x28F9C0 Offset: 0x28FAC1 VA: 0x28F9C0
	public float[] m_BattleCameraAngleBorder; // 0x20
	[SerializeField] // RVA: 0x28FA10 Offset: 0x28FB11 VA: 0x28FA10
	[TooltipAttribute] // RVA: 0x28FA10 Offset: 0x28FB11 VA: 0x28FA10
	public float[] m_BattleCameraAngleLimit; // 0x28
	[TooltipAttribute] // RVA: 0x28FA60 Offset: 0x28FB61 VA: 0x28FA60
	[SerializeField] // RVA: 0x28FA60 Offset: 0x28FB61 VA: 0x28FA60
	public int m_BattleCameraLerpCount; // 0x30
	[TooltipAttribute] // RVA: 0x28FAB0 Offset: 0x28FBB1 VA: 0x28FAB0
	[SerializeField] // RVA: 0x28FAB0 Offset: 0x28FBB1 VA: 0x28FAB0
	public int m_BattleCameraReverseLerpCount; // 0x34
	[TooltipAttribute] // RVA: 0x28FB00 Offset: 0x28FC01 VA: 0x28FB00
	[SerializeField] // RVA: 0x28FB00 Offset: 0x28FC01 VA: 0x28FB00
	public float m_HitPopupTimeSecond; // 0x38
	[TooltipAttribute] // RVA: 0x28FB50 Offset: 0x28FC51 VA: 0x28FB50
	[SerializeField] // RVA: 0x28FB50 Offset: 0x28FC51 VA: 0x28FB50
	public float m_ReadyLethalSecond; // 0x3C
	[TooltipAttribute] // RVA: 0x28FBA0 Offset: 0x28FCA1 VA: 0x28FBA0
	[SerializeField] // RVA: 0x28FBA0 Offset: 0x28FCA1 VA: 0x28FBA0
	public float m_LethalTimeSecond; // 0x40
	[TooltipAttribute] // RVA: 0x28FBF0 Offset: 0x28FCF1 VA: 0x28FBF0
	[SerializeField] // RVA: 0x28FBF0 Offset: 0x28FCF1 VA: 0x28FBF0
	public float m_LethalIncrease; // 0x44
	[TooltipAttribute] // RVA: 0x28FC40 Offset: 0x28FD41 VA: 0x28FC40
	[SerializeField] // RVA: 0x28FC40 Offset: 0x28FD41 VA: 0x28FC40
	public float m_LethalDecrease; // 0x48
	[TooltipAttribute] // RVA: 0x28FC90 Offset: 0x28FD91 VA: 0x28FC90
	[SerializeField] // RVA: 0x28FC90 Offset: 0x28FD91 VA: 0x28FC90
	public float m_AttackPower; // 0x4C
	[TooltipAttribute] // RVA: 0x28FCE0 Offset: 0x28FDE1 VA: 0x28FCE0
	[SerializeField] // RVA: 0x28FCE0 Offset: 0x28FDE1 VA: 0x28FCE0
	public float m_StickWaitFrameAtAttack; // 0x50
	[TooltipAttribute] // RVA: 0x28FD30 Offset: 0x28FE31 VA: 0x28FD30
	[SerializeField] // RVA: 0x28FD30 Offset: 0x28FE31 VA: 0x28FD30
	public float m_AtAttackWaitFrameAtStick; // 0x54
	[TooltipAttribute] // RVA: 0x28FD80 Offset: 0x28FE81 VA: 0x28FD80
	[SerializeField] // RVA: 0x28FD80 Offset: 0x28FE81 VA: 0x28FD80
	public FishingConfig_Battle.AngleBorder m_AngleBorder; // 0x58
	[SerializeField] // RVA: 0x28FDD0 Offset: 0x28FED1 VA: 0x28FDD0
	[TooltipAttribute] // RVA: 0x28FDD0 Offset: 0x28FED1 VA: 0x28FDD0
	public float m_RadarAngle; // 0x60
	[TooltipAttribute] // RVA: 0x28FE20 Offset: 0x28FF21 VA: 0x28FE20
	[SerializeField] // RVA: 0x28FE20 Offset: 0x28FF21 VA: 0x28FE20
	public float m_RadarShadowScale; // 0x64
	[SerializeField] // RVA: 0x28FE70 Offset: 0x28FF71 VA: 0x28FE70
	[TooltipAttribute] // RVA: 0x28FE70 Offset: 0x28FF71 VA: 0x28FE70
	public float m_RadarDistanceMax; // 0x68
	[SerializeField] // RVA: 0x28FEC0 Offset: 0x28FFC1 VA: 0x28FEC0
	[TooltipAttribute] // RVA: 0x28FEC0 Offset: 0x28FFC1 VA: 0x28FEC0
	public float m_RadarDistanceMin; // 0x6C
	[SerializeField] // RVA: 0x28FF10 Offset: 0x290011 VA: 0x28FF10
	[TooltipAttribute] // RVA: 0x28FF10 Offset: 0x290011 VA: 0x28FF10
	public float m_RadarEscapeRate; // 0x70
	[SerializeField] // RVA: 0x28FF60 Offset: 0x290061 VA: 0x28FF60
	[TooltipAttribute] // RVA: 0x28FF60 Offset: 0x290061 VA: 0x28FF60
	public float m_RadarStopCounterRate; // 0x74
	[TooltipAttribute] // RVA: 0x28FFB0 Offset: 0x2900B1 VA: 0x28FFB0
	[SerializeField] // RVA: 0x28FFB0 Offset: 0x2900B1 VA: 0x28FFB0
	public float m_FishEscapeSec; // 0x78
	[TooltipAttribute] // RVA: 0x290000 Offset: 0x290101 VA: 0x290000
	[SerializeField] // RVA: 0x290000 Offset: 0x290101 VA: 0x290000
	public float m_MinFishCounterTime; // 0x7C
	[TooltipAttribute] // RVA: 0x290050 Offset: 0x290151 VA: 0x290050
	[SerializeField] // RVA: 0x290050 Offset: 0x290151 VA: 0x290050
	public float m_ForceCounterTime; // 0x80
	[TooltipAttribute] // RVA: 0x2900A0 Offset: 0x2901A1 VA: 0x2900A0
	[SerializeField] // RVA: 0x2900A0 Offset: 0x2901A1 VA: 0x2900A0
	public float m_LethalRecoveryHPPercent; // 0x84
	[TooltipAttribute] // RVA: 0x2900F0 Offset: 0x2901F1 VA: 0x2900F0
	[SerializeField] // RVA: 0x2900F0 Offset: 0x2901F1 VA: 0x2900F0
	public float m_HPGaugeMoveWait; // 0x88
	[SerializeField] // RVA: 0x290140 Offset: 0x290241 VA: 0x290140
	[TooltipAttribute] // RVA: 0x290140 Offset: 0x290241 VA: 0x290140
	public float m_HPGaugeMoveSpeed; // 0x8C
	[SerializeField] // RVA: 0x290190 Offset: 0x290291 VA: 0x290190
	[TooltipAttribute] // RVA: 0x290190 Offset: 0x290291 VA: 0x290190
	public float m_FirstAttackDamageRate; // 0x90
	[SerializeField] // RVA: 0x2901E0 Offset: 0x2902E1 VA: 0x2901E0
	[TooltipAttribute] // RVA: 0x2901E0 Offset: 0x2902E1 VA: 0x2901E0
	public float m_AssistShowSec; // 0x94
	[TooltipAttribute] // RVA: 0x290230 Offset: 0x290331 VA: 0x290230
	[SerializeField] // RVA: 0x290230 Offset: 0x290331 VA: 0x290230
	public float m_BattleSplashInterval; // 0x98
	[SerializeField] // RVA: 0x290280 Offset: 0x290381 VA: 0x290280
	[TooltipAttribute] // RVA: 0x290280 Offset: 0x290381 VA: 0x290280
	public float m_BattleCounterSplashInterval; // 0x9C

	// Methods

	// RVA: 0x2EF3BB0 Offset: 0x2EF3CB1 VA: 0x2EF3BB0
	private void Start() { }

	// RVA: 0x2EF3BC0 Offset: 0x2EF3CC1 VA: 0x2EF3BC0
	private void Update() { }

	// RVA: 0x2EF3BD0 Offset: 0x2EF3CD1 VA: 0x2EF3BD0
	protected void .ctor() { }
}

// Namespace: App
[Serializable]
public abstract class FishingConfig_Defeat : MonoBehaviour // TypeDefIndex: 10567
{
	// Fields
	[TooltipAttribute] // RVA: 0x2903C0 Offset: 0x2904C1 VA: 0x2903C0
	[SerializeField] // RVA: 0x2903C0 Offset: 0x2904C1 VA: 0x2903C0
	public Vector3 m_SolaDefeatRot; // 0x18
	[SerializeField] // RVA: 0x290410 Offset: 0x290511 VA: 0x290410
	[TooltipAttribute] // RVA: 0x290410 Offset: 0x290511 VA: 0x290410
	public FadeType m_DefeatFadeOutType; // 0x24
	[SerializeField] // RVA: 0x290460 Offset: 0x290561 VA: 0x290460
	[TooltipAttribute] // RVA: 0x290460 Offset: 0x290561 VA: 0x290460
	public float m_DefeatAnimeFrame; // 0x28
	[SerializeField] // RVA: 0x2904B0 Offset: 0x2905B1 VA: 0x2904B0
	[TooltipAttribute] // RVA: 0x2904B0 Offset: 0x2905B1 VA: 0x2904B0
	public float m_SuccessStartFrame; // 0x2C
	[SerializeField] // RVA: 0x290500 Offset: 0x290601 VA: 0x290500
	[TooltipAttribute] // RVA: 0x290500 Offset: 0x290601 VA: 0x290500
	public float m_DefeatFadeStartFrame; // 0x30

	// Methods

	// RVA: 0x2EF3DE0 Offset: 0x2EF3EE1 VA: 0x2EF3DE0
	protected void .ctor() { }
}

// Namespace: App
[Serializable]
public abstract class FishingConfig_MoveCircle : MonoBehaviour // TypeDefIndex: 10568
{
	// Fields
	[SerializeField] // RVA: 0x290550 Offset: 0x290651 VA: 0x290550
	[TooltipAttribute] // RVA: 0x290550 Offset: 0x290651 VA: 0x290550
	public float m_CameraRotateSpeed; // 0x18
	[SerializeField] // RVA: 0x2905A0 Offset: 0x2906A1 VA: 0x2905A0
	[TooltipAttribute] // RVA: 0x2905A0 Offset: 0x2906A1 VA: 0x2905A0
	public float m_DistanceMoveSpeed; // 0x1C
	[TooltipAttribute] // RVA: 0x2905F0 Offset: 0x2906F1 VA: 0x2905F0
	[SerializeField] // RVA: 0x2905F0 Offset: 0x2906F1 VA: 0x2905F0
	public float m_RotateMinimum; // 0x20
	[SerializeField] // RVA: 0x290640 Offset: 0x290741 VA: 0x290640
	[TooltipAttribute] // RVA: 0x290640 Offset: 0x290741 VA: 0x290640
	public float m_RotateMax; // 0x24
	[TooltipAttribute] // RVA: 0x290690 Offset: 0x290791 VA: 0x290690
	[SerializeField] // RVA: 0x290690 Offset: 0x290791 VA: 0x290690
	public float m_DistanceMinimum; // 0x28
	[SerializeField] // RVA: 0x2906E0 Offset: 0x2907E1 VA: 0x2906E0
	[TooltipAttribute] // RVA: 0x2906E0 Offset: 0x2907E1 VA: 0x2906E0
	public float m_DistanceMax; // 0x2C
	[SerializeField] // RVA: 0x290730 Offset: 0x290831 VA: 0x290730
	[TooltipAttribute] // RVA: 0x290730 Offset: 0x290831 VA: 0x290730
	public float m_RipplesInterval; // 0x30
	[SerializeField] // RVA: 0x290780 Offset: 0x290881 VA: 0x290780
	[TooltipAttribute] // RVA: 0x290780 Offset: 0x290881 VA: 0x290780
	public Vector3[] m_RipplesPosList; // 0x38
	[TooltipAttribute] // RVA: 0x2907D0 Offset: 0x2908D1 VA: 0x2907D0
	[SerializeField] // RVA: 0x2907D0 Offset: 0x2908D1 VA: 0x2907D0
	public float m_RipplesRandomRange; // 0x40

	// Methods

	// RVA: 0x2EF3E40 Offset: 0x2EF3F41 VA: 0x2EF3E40
	protected void .ctor() { }
}

// Namespace: App
[Serializable]
public abstract class FishingConfig_Result : MonoBehaviour // TypeDefIndex: 10569
{
	// Fields
	[TooltipAttribute] // RVA: 0x290820 Offset: 0x290921 VA: 0x290820
	[SerializeField] // RVA: 0x290820 Offset: 0x290921 VA: 0x290820
	public float m_ResultTime; // 0x18
	[TooltipAttribute] // RVA: 0x290870 Offset: 0x290971 VA: 0x290870
	[SerializeField] // RVA: 0x290870 Offset: 0x290971 VA: 0x290870
	public FadeType m_ResultFadeInType; // 0x1C
	[SerializeField] // RVA: 0x2908C0 Offset: 0x2909C1 VA: 0x2908C0
	[TooltipAttribute] // RVA: 0x2908C0 Offset: 0x2909C1 VA: 0x2908C0
	public FixCameraConfig m_ResultCamera; // 0x20
	[SerializeField] // RVA: 0x290910 Offset: 0x290A11 VA: 0x290910
	[TooltipAttribute] // RVA: 0x290910 Offset: 0x290A11 VA: 0x290910
	public float m_ResultPlayerRotY; // 0x28

	// Methods

	// RVA: 0x2EF3F80 Offset: 0x2EF4081 VA: 0x2EF3F80
	protected void .ctor() { }
}

// Namespace: App
[Serializable]
public abstract class FishingConfig_ThrowIn : MonoBehaviour // TypeDefIndex: 10570
{
	// Fields
	[SerializeField] // RVA: 0x290960 Offset: 0x290A61 VA: 0x290960
	[TooltipAttribute] // RVA: 0x290960 Offset: 0x290A61 VA: 0x290960
	public float m_ThrowInTime; // 0x18
	[SerializeField] // RVA: 0x2909B0 Offset: 0x290AB1 VA: 0x2909B0
	[TooltipAttribute] // RVA: 0x2909B0 Offset: 0x290AB1 VA: 0x2909B0
	public float m_ThrowSEPlaySec; // 0x1C
	[SerializeField] // RVA: 0x290A00 Offset: 0x290B01 VA: 0x290A00
	[TooltipAttribute] // RVA: 0x290A00 Offset: 0x290B01 VA: 0x290A00
	public float m_ThrowCameraChangeSec; // 0x20
	[SerializeField] // RVA: 0x290A50 Offset: 0x290B51 VA: 0x290A50
	[TooltipAttribute] // RVA: 0x290A50 Offset: 0x290B51 VA: 0x290A50
	public float m_ThrowInSinkSec; // 0x24

	// Methods

	// RVA: 0x2EF4100 Offset: 0x2EF4201 VA: 0x2EF4100
	protected void .ctor() { }
}

// Namespace: App
[Serializable]
public abstract class FishingConfig_WaitCancel : MonoBehaviour // TypeDefIndex: 10571
{
	// Fields
	[SerializeField] // RVA: 0x290AA0 Offset: 0x290BA1 VA: 0x290AA0
	[TooltipAttribute] // RVA: 0x290AA0 Offset: 0x290BA1 VA: 0x290AA0
	public float m_CancelTime; // 0x18
	[TooltipAttribute] // RVA: 0x290AF0 Offset: 0x290BF1 VA: 0x290AF0
	[SerializeField] // RVA: 0x290AF0 Offset: 0x290BF1 VA: 0x290AF0
	public float m_CancelPullTime; // 0x1C
	[TooltipAttribute] // RVA: 0x290B40 Offset: 0x290C41 VA: 0x290B40
	[SerializeField] // RVA: 0x290B40 Offset: 0x290C41 VA: 0x290B40
	public float m_CancelFadeOutTime; // 0x20
	[TooltipAttribute] // RVA: 0x290B90 Offset: 0x290C91 VA: 0x290B90
	[SerializeField] // RVA: 0x290B90 Offset: 0x290C91 VA: 0x290B90
	public float m_CancelFadeInTime; // 0x24

	// Methods

	// RVA: 0x2EF4140 Offset: 0x2EF4241 VA: 0x2EF4140
	protected void .ctor() { }
}

// Namespace: App
[Serializable]
public abstract class FishingConfig_WaitCatch : MonoBehaviour // TypeDefIndex: 10572
{
	// Fields
	[SerializeField] // RVA: 0x290BE0 Offset: 0x290CE1 VA: 0x290BE0
	[TooltipAttribute] // RVA: 0x290BE0 Offset: 0x290CE1 VA: 0x290BE0
	public float m_FishChangeAppearTime; // 0x18
	[TooltipAttribute] // RVA: 0x290C30 Offset: 0x290D31 VA: 0x290C30
	[SerializeField] // RVA: 0x290C30 Offset: 0x290D31 VA: 0x290C30
	public float m_FishChangePercentage; // 0x1C
	[SerializeField] // RVA: 0x290C80 Offset: 0x290D81 VA: 0x290C80
	[TooltipAttribute] // RVA: 0x290C80 Offset: 0x290D81 VA: 0x290C80
	public float m_FishFaintPercentage; // 0x20
	[SerializeField] // RVA: 0x290CD0 Offset: 0x290DD1 VA: 0x290CD0
	[TooltipAttribute] // RVA: 0x290CD0 Offset: 0x290DD1 VA: 0x290CD0
	public int m_FishFaintMaxCount; // 0x24
	[SerializeField] // RVA: 0x290D20 Offset: 0x290E21 VA: 0x290D20
	[TooltipAttribute] // RVA: 0x290D20 Offset: 0x290E21 VA: 0x290D20
	public float m_FishCatchingTimeMax; // 0x28
	[SerializeField] // RVA: 0x290D70 Offset: 0x290E71 VA: 0x290D70
	[TooltipAttribute] // RVA: 0x290D70 Offset: 0x290E71 VA: 0x290D70
	public Vector3 m_LureCameraDiff; // 0x2C
	[SerializeField] // RVA: 0x290DC0 Offset: 0x290EC1 VA: 0x290DC0
	[TooltipAttribute] // RVA: 0x290DC0 Offset: 0x290EC1 VA: 0x290DC0
	public Vector3 m_LureCameraRot; // 0x38
	[SerializeField] // RVA: 0x290E10 Offset: 0x290F11 VA: 0x290E10
	[TooltipAttribute] // RVA: 0x290E10 Offset: 0x290F11 VA: 0x290E10
	public float m_AssistShowSec; // 0x44
	[SerializeField] // RVA: 0x290E60 Offset: 0x290F61 VA: 0x290E60
	[TooltipAttribute] // RVA: 0x290E60 Offset: 0x290F61 VA: 0x290E60
	public float m_FakeVibeTimeMult; // 0x48
	[TooltipAttribute] // RVA: 0x290EB0 Offset: 0x290FB1 VA: 0x290EB0
	[SerializeField] // RVA: 0x290EB0 Offset: 0x290FB1 VA: 0x290EB0
	public float m_CatchVibeTimeMult; // 0x4C
	[SerializeField] // RVA: 0x290F00 Offset: 0x291001 VA: 0x290F00
	[TooltipAttribute] // RVA: 0x290F00 Offset: 0x291001 VA: 0x290F00
	public float m_CatchVibePower_Tiny; // 0x50
	[SerializeField] // RVA: 0x290F50 Offset: 0x291051 VA: 0x290F50
	[TooltipAttribute] // RVA: 0x290F50 Offset: 0x291051 VA: 0x290F50
	public float m_CatchVibeTime_Tiny; // 0x54
	[SerializeField] // RVA: 0x290FA0 Offset: 0x2910A1 VA: 0x290FA0
	[TooltipAttribute] // RVA: 0x290FA0 Offset: 0x2910A1 VA: 0x290FA0
	public float m_CatchVibePower_Middle; // 0x58
	[TooltipAttribute] // RVA: 0x290FF0 Offset: 0x2910F1 VA: 0x290FF0
	[SerializeField] // RVA: 0x290FF0 Offset: 0x2910F1 VA: 0x290FF0
	public float m_CatchVibeTime_Middle; // 0x5C
	[SerializeField] // RVA: 0x291040 Offset: 0x291141 VA: 0x291040
	[TooltipAttribute] // RVA: 0x291040 Offset: 0x291141 VA: 0x291040
	public float m_CatchVibePower_Giant; // 0x60
	[SerializeField] // RVA: 0x291090 Offset: 0x291191 VA: 0x291090
	[TooltipAttribute] // RVA: 0x291090 Offset: 0x291191 VA: 0x291090
	public float m_CatchVibeTime_Giant; // 0x64

	// Methods

	// RVA: 0x2EF4180 Offset: 0x2EF4281 VA: 0x2EF4180
	protected void .ctor() { }
}

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

