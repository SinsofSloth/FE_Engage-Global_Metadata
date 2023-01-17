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

