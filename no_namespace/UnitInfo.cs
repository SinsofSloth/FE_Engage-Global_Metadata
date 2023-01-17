// Namespace: 
public class UnitInfo0MenuItem : MapNavigationStatusBasicMenuItem // TypeDefIndex: 7744
{
	// Methods

	// RVA: 0x23F3750 Offset: 0x23F3851 VA: 0x23F3750
	public void .ctor() { }

	// RVA: 0x23F37F0 Offset: 0x23F38F1 VA: 0x23F37F0 Slot: 12
	public override void OnSelect() { }
}

// Namespace: 
public class UnitInfo1MenuItem : MapNavigationStatusBasicMenuItem // TypeDefIndex: 7745
{
	// Methods

	// RVA: 0x23F3880 Offset: 0x23F3981 VA: 0x23F3880
	public void .ctor() { }

	// RVA: 0x23F3920 Offset: 0x23F3A21 VA: 0x23F3920 Slot: 12
	public override void OnSelect() { }
}

// Namespace: 
public class UnitInfo2MenuItem : MapNavigationStatusBasicMenuItem // TypeDefIndex: 7746
{
	// Methods

	// RVA: 0x23F39C0 Offset: 0x23F3AC1 VA: 0x23F39C0
	public void .ctor() { }

	// RVA: 0x23F3A60 Offset: 0x23F3B61 VA: 0x23F3A60 Slot: 12
	public override void OnSelect() { }
}

// Namespace: 
public class UnitInfo3MenuItem : MapNavigationStatusBasicMenuItem // TypeDefIndex: 7747
{
	// Methods

	// RVA: 0x23F3B00 Offset: 0x23F3C01 VA: 0x23F3B00
	public void .ctor() { }

	// RVA: 0x23F3BA0 Offset: 0x23F3CA1 VA: 0x23F3BA0 Slot: 12
	public override void OnSelect() { }
}

// Namespace: 
public class UnitInfo4MenuItem : MapNavigationStatusBasicMenuItem // TypeDefIndex: 7748
{
	// Methods

	// RVA: 0x23F3C40 Offset: 0x23F3D41 VA: 0x23F3C40
	public void .ctor() { }

	// RVA: 0x23F3CE0 Offset: 0x23F3DE1 VA: 0x23F3CE0 Slot: 12
	public override void OnSelect() { }
}

// Namespace: 
public class UnitInfo5MenuItem : MapNavigationStatusBasicMenuItem // TypeDefIndex: 7749
{
	// Methods

	// RVA: 0x23F3D80 Offset: 0x23F3E81 VA: 0x23F3D80
	public void .ctor() { }

	// RVA: 0x23F3E20 Offset: 0x23F3F21 VA: 0x23F3E20 Slot: 12
	public override void OnSelect() { }
}

// Namespace: 
public class UnitInfo6MenuItem : MapNavigationStatusBasicMenuItem // TypeDefIndex: 7750
{
	// Methods

	// RVA: 0x23F3EC0 Offset: 0x23F3FC1 VA: 0x23F3EC0
	public void .ctor() { }

	// RVA: 0x23F3F60 Offset: 0x23F4061 VA: 0x23F3F60 Slot: 12
	public override void OnSelect() { }
}

// Namespace: 
public enum UnitInfo.Mode // TypeDefIndex: 11843
{
	// Fields
	public int value__; // 0x0
	public const UnitInfo.Mode Simple = 0;
	public const UnitInfo.Mode Hide = 1;
	public const UnitInfo.Mode ModelOnly = 2;
	public const UnitInfo.Mode Num = 3;
}

// Namespace: 
public enum UnitInfo.Side // TypeDefIndex: 11844
{
	// Fields
	public int value__; // 0x0
	public const UnitInfo.Side Left = 0;
	public const UnitInfo.Side Right = 1;
	public const UnitInfo.Side Num = 2;
}

// Namespace: 
private class UnitInfo.Window // TypeDefIndex: 11845
{
	// Fields
	private Stack<UnitInfo.Mode> m_ModeStack; // 0x10
	private Unit m_Unit; // 0x18
	private GodUnit m_God; // 0x20
	private int m_UnitX; // 0x28
	private int m_UnitZ; // 0x2C
	private UnitInfoWindow m_UnitInfoWindowSimple; // 0x30
	private UnitInfoWindowCharaModel m_UnitInfoWindowCharaModel; // 0x38
	private bool m_IsVisible; // 0x40
	private bool m_IsDuplicateRenderTexture; // 0x41
	private bool m_IsReverse; // 0x42
	private bool m_IsHideStatus; // 0x43

	// Methods

	// RVA: 0x1ED0C60 Offset: 0x1ED0D61 VA: 0x1ED0C60
	public void .ctor(Stack<UnitInfo.Mode> modeStack, Unit unit, bool isDuplicateRenderTexture, bool isReverse, bool isHideStatus) { }

	// RVA: 0x1ED0D00 Offset: 0x1ED0E01 VA: 0x1ED0D00
	public void Destroy() { }

	// RVA: 0x1ED0D30 Offset: 0x1ED0E31 VA: 0x1ED0D30
	public void PrepareCharaModel() { }

	// RVA: 0x1ED0DB0 Offset: 0x1ED0EB1 VA: 0x1ED0DB0
	public bool IsPreparingCharaModel() { }

	// RVA: 0x1ED0DC0 Offset: 0x1ED0EC1 VA: 0x1ED0DC0
	public void PrepareWindow() { }

	// RVA: 0x1ED0E60 Offset: 0x1ED0F61 VA: 0x1ED0E60
	public bool IsPreparingWindow() { }

	// RVA: 0x1ED0E70 Offset: 0x1ED0F71 VA: 0x1ED0E70
	public void Postprepare() { }

	// RVA: 0x1ED1190 Offset: 0x1ED1291 VA: 0x1ED1190
	public void Tick() { }

	// RVA: 0x1ED0F00 Offset: 0x1ED1001 VA: 0x1ED0F00
	public void SetUnit(Unit unit, bool bUpdateStatus, bool bRelax = False, bool bReverseRotation = True, bool isDelayLoad = True, Action onSetupDoneCallback) { }

	// RVA: 0x1ED1230 Offset: 0x1ED1331 VA: 0x1ED1230
	public void ResetUnit(bool bRelax = False, bool bReverseRotation = True, bool isDelayLoad = True) { }

	// RVA: 0x1ED1310 Offset: 0x1ED1411 VA: 0x1ED1310
	public void SetUnitHub(Unit unit, bool bRelax = False, bool bReverseRotation = True, bool isDelayLoad = True) { }

	// RVA: 0x1ED1380 Offset: 0x1ED1481 VA: 0x1ED1380
	public void SetUnitRelay(PersonData person, JobData job, UnitEdit edit) { }

	// RVA: 0x1ED13E0 Offset: 0x1ED14E1 VA: 0x1ED13E0
	public void PlayCharaVoice(string personSwitchName, string engageSwitchName, string eventName) { }

	// RVA: 0x1ED13F0 Offset: 0x1ED14F1 VA: 0x1ED13F0
	public void ReserveCharaVoice(string personSwitchName, string engageSwitchName, string eventName) { }

	// RVA: 0x1ED1400 Offset: 0x1ED1501 VA: 0x1ED1400
	public void PlayReservedCharaVoice() { }

	// RVA: 0x1ED1410 Offset: 0x1ED1511 VA: 0x1ED1410
	public void AddCharaRot(Quaternion quaternion) { }

	// RVA: 0x1ED1420 Offset: 0x1ED1521 VA: 0x1ED1420
	public void SetLeftCameraAdjustY() { }

	// RVA: 0x1ED1430 Offset: 0x1ED1531 VA: 0x1ED1430
	public void SetWeaponShopChara() { }

	// RVA: 0x1ED1440 Offset: 0x1ED1541 VA: 0x1ED1440
	public void SetSummonChara() { }

	// RVA: 0x1ED1450 Offset: 0x1ED1551 VA: 0x1ED1450
	public void SetGod(GodUnit god, bool bRelax, bool bReverseRotation = True, Action onSetupDoneCallback) { }

	// RVA: 0x1ED1530 Offset: 0x1ED1631 VA: 0x1ED1530
	public void SetEfficacyAttack(bool isEfficacy) { }

	// RVA: 0x1ED1540 Offset: 0x1ED1641 VA: 0x1ED1540
	public void SetRelaxAnime(float transitionDuration) { }

	// RVA: 0x1ED1550 Offset: 0x1ED1651 VA: 0x1ED1550
	public void SetStatusAnime(float transitionDuration) { }

	// RVA: 0x1ED1560 Offset: 0x1ED1661 VA: 0x1ED1560
	public void SetFortuneTellingGoodAnime(bool isAllowUnitNull) { }

	// RVA: 0x1ED1570 Offset: 0x1ED1671 VA: 0x1ED1570
	public void SetFortuneTellingBadAnime(bool isAllowUnitNull) { }

	// RVA: 0x1ED1580 Offset: 0x1ED1681 VA: 0x1ED1580
	public void SetSelectGodNormalFace() { }

	// RVA: 0x1ED1590 Offset: 0x1ED1691 VA: 0x1ED1590
	public void UpdateCurrentUnit() { }

	// RVA: 0x1ED1620 Offset: 0x1ED1721 VA: 0x1ED1620
	public Unit GetUnit() { }

	// RVA: 0x1ED1630 Offset: 0x1ED1731 VA: 0x1ED1630
	public GodUnit GetGod() { }

	// RVA: 0x1ED1640 Offset: 0x1ED1741 VA: 0x1ED1640
	public RenderTexture GetRenderTexture() { }

	// RVA: 0x1ED1650 Offset: 0x1ED1751 VA: 0x1ED1650
	public Camera GetFaceCameraComponent() { }

	// RVA: 0x1ED1660 Offset: 0x1ED1761 VA: 0x1ED1660
	public UnitInfoCharaImageMaskOffset GetCharaImageMask() { }

	// RVA: 0x1ED1670 Offset: 0x1ED1771 VA: 0x1ED1670
	public void SetVisible(bool isVisible) { }

	// RVA: 0x1ED16A0 Offset: 0x1ED17A1 VA: 0x1ED16A0
	public void ToggleVisible() { }

	// RVA: 0x1ED16B0 Offset: 0x1ED17B1 VA: 0x1ED16B0
	public bool IsVisible() { }

	// RVA: 0x1ED16C0 Offset: 0x1ED17C1 VA: 0x1ED16C0
	public void SetVisibleOfStatus(UnitInfo.Mode mode, bool isVisible) { }

	// RVA: 0x1ED16F0 Offset: 0x1ED17F1 VA: 0x1ED16F0
	public bool IsVisibleStatus(UnitInfo.Mode mode) { }

	// RVA: 0x1ED1710 Offset: 0x1ED1811 VA: 0x1ED1710
	public void CharaOnlyOn(bool isChangeCharaModelAnim) { }

	// RVA: 0x1ED1750 Offset: 0x1ED1851 VA: 0x1ED1750
	public void CharaOnlyOff() { }

	// RVA: 0x1ED1790 Offset: 0x1ED1891 VA: 0x1ED1790
	public bool IsCharaOnlyTransition() { }

	// RVA: 0x1ED17A0 Offset: 0x1ED18A1 VA: 0x1ED17A0
	public void UpdateStandByAnime(UnitItem unitItem, bool isWeaponShop = False) { }

	// RVA: 0x1ED17B0 Offset: 0x1ED18B1 VA: 0x1ED17B0
	public void SetCreateReserveUnitItem(UnitItem unitItem, bool isOverride) { }

	// RVA: 0x1ED17C0 Offset: 0x1ED18C1 VA: 0x1ED17C0
	public void HideWeapon() { }

	// RVA: 0x1ED17D0 Offset: 0x1ED18D1 VA: 0x1ED17D0
	public bool IsLoadingCharaModel() { }

	// RVA: 0x1ED17E0 Offset: 0x1ED18E1 VA: 0x1ED17E0
	public void TransparentOn() { }

	// RVA: 0x1ED1810 Offset: 0x1ED1911 VA: 0x1ED1810
	public void TransparentOff() { }

	// RVA: 0x1ED10A0 Offset: 0x1ED11A1 VA: 0x1ED10A0
	public void UpdateVisible() { }

	// RVA: 0x1ED1840 Offset: 0x1ED1941 VA: 0x1ED1840
	public GameObject GetCurrentWindowObject() { }

	// RVA: 0x1ED18A0 Offset: 0x1ED19A1 VA: 0x1ED18A0
	public Transform GetHeadLocator() { }

	// RVA: 0x1ED18B0 Offset: 0x1ED19B1 VA: 0x1ED18B0
	public void SetHeadLocator(Transform loc, float weight, bool isWeightInterpolated) { }

	// RVA: 0x1ED18C0 Offset: 0x1ED19C1 VA: 0x1ED18C0
	public void SetHeadLocator(Vector3 pos) { }

	// RVA: 0x1ED18D0 Offset: 0x1ED19D1 VA: 0x1ED18D0
	public void SetLookAt(Transform transform) { }

	// RVA: 0x1ED18E0 Offset: 0x1ED19E1 VA: 0x1ED18E0
	public void SetLookAtCamera() { }

	// RVA: 0x1ED18F0 Offset: 0x1ED19F1 VA: 0x1ED18F0
	public void SetEyesWeight(float eyesWeight) { }

	// RVA: 0x1ED1900 Offset: 0x1ED1A01 VA: 0x1ED1900
	public bool IsCharaVisible() { }

	// RVA: 0x1ED11A0 Offset: 0x1ED12A1 VA: 0x1ED11A0
	public void SetUnitStatusWindow() { }
}

