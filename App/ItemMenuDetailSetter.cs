// Namespace: App
public class ItemMenuDetailSetter : MonoBehaviour // TypeDefIndex: 12568
{
	// Fields
	public TextMeshProUGUI m_MenuTitle; // 0x18
	public TextMeshProUGUI m_ContentsTitle; // 0x20
	[HeaderAttribute] // RVA: 0x29AC30 Offset: 0x29AD31 VA: 0x29AC30
	public TextMeshProUGUI m_TitleAtk; // 0x28
	public TextMeshProUGUI m_ValueAtk; // 0x30
	public Image m_IconAtk; // 0x38
	[SpaceAttribute] // RVA: 0x29AC70 Offset: 0x29AD71 VA: 0x29AC70
	public TextMeshProUGUI m_TitleHit; // 0x40
	public TextMeshProUGUI m_ValueHit; // 0x48
	public Image m_IconHit; // 0x50
	[SpaceAttribute] // RVA: 0x29AC90 Offset: 0x29AD91 VA: 0x29AC90
	public TextMeshProUGUI m_TitleCrit; // 0x58
	public TextMeshProUGUI m_ValueCrit; // 0x60
	public Image m_IconCrit; // 0x68
	[SpaceAttribute] // RVA: 0x29ACB0 Offset: 0x29ADB1 VA: 0x29ACB0
	public TextMeshProUGUI m_TitleAvo; // 0x70
	public TextMeshProUGUI m_ValueAvo; // 0x78
	public Image m_IconAvo; // 0x80
	[SpaceAttribute] // RVA: 0x29ACD0 Offset: 0x29ADD1 VA: 0x29ACD0
	public GameObject m_ObjectSpd; // 0x88
	public TextMeshProUGUI m_TitleSpd; // 0x90
	public TextMeshProUGUI m_ValueSpd; // 0x98
	public Image m_IconSpd; // 0xA0
	[SpaceAttribute] // RVA: 0x29ACF0 Offset: 0x29ADF1 VA: 0x29ACF0
	public GameObject m_ObjectWeight; // 0xA8
	public TextMeshProUGUI m_TitleWeight; // 0xB0
	public TextMeshProUGUI m_ValueWeight; // 0xB8
	public Image m_IconWeight; // 0xC0
	[SpaceAttribute] // RVA: 0x29AD10 Offset: 0x29AE11 VA: 0x29AD10
	public TextMeshProUGUI m_TitleRange; // 0xC8
	public TextMeshProUGUI m_ValueRange; // 0xD0
	[SpaceAttribute] // RVA: 0x29AD30 Offset: 0x29AE31 VA: 0x29AD30
	public TextMeshProUGUI m_TitleSecure; // 0xD8
	public TextMeshProUGUI m_ValueSecure; // 0xE0
	public Image m_IconSecure; // 0xE8
	[SpaceAttribute] // RVA: 0x29AD50 Offset: 0x29AE51 VA: 0x29AD50
	public TextMeshProUGUI m_TitleWeaponLevel; // 0xF0
	public TextMeshProUGUI m_ValueWeaponLevel; // 0xF8
	public Image m_IconWeaponLevel; // 0x100
	public TextMeshProUGUI m_WeaponLevelNothing; // 0x108
	[SpaceAttribute] // RVA: 0x29AD70 Offset: 0x29AE71 VA: 0x29AD70
	public TextMeshProUGUI m_TitleEfficacy; // 0x110
	public Image[] m_EfficacyIcons; // 0x118
	public TextMeshProUGUI m_EfficacyNothing; // 0x120
	[HeaderAttribute] // RVA: 0x29AD90 Offset: 0x29AE91 VA: 0x29AD90
	public TextMeshProUGUI m_ContentsText; // 0x128
	public TextMeshProUGUI m_ContentsEngWep; // 0x130
	public TextMeshProUGUI m_ContentsEnchant; // 0x138
	public TextMeshProUGUI m_ContentsSubText; // 0x140
	[CompilerGeneratedAttribute] // RVA: 0x29ADD0 Offset: 0x29AED1 VA: 0x29ADD0
	private bool <IsEnchantMode>k__BackingField; // 0x148
	private string m_ContentsTitleMID; // 0x150
	private string m_AtkTitleMID; // 0x158
	private Color m_ColorValueAtk; // 0x160
	private Color m_ColorValueHit; // 0x170
	private Color m_ColorValueCrit; // 0x180
	private Color m_ColorValueAvo; // 0x190
	private Color m_ColorValueSpd; // 0x1A0
	private Color m_ColorValueWeight; // 0x1B0
	private Color m_ColorValueSecure; // 0x1C0
	private Unit m_TmpUnit; // 0x1D0
	private BattleInfo m_BattleInfo; // 0x1D8
	private BattleInfo m_TmpBattleInfo; // 0x1E0

	// Properties
	private bool IsEnchantMode { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C99B0 Offset: 0x2C9AB1 VA: 0x2C99B0
	// RVA: 0x244CC90 Offset: 0x244CD91 VA: 0x244CC90
	private bool get_IsEnchantMode() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C99C0 Offset: 0x2C9AC1 VA: 0x2C99C0
	// RVA: 0x244CCA0 Offset: 0x244CDA1 VA: 0x244CCA0
	private void set_IsEnchantMode(bool value) { }

	// RVA: 0x244CCB0 Offset: 0x244CDB1 VA: 0x244CCB0
	public void SetEnchantMode(bool isEnchant) { }

	// RVA: 0x244CCC0 Offset: 0x244CDC1 VA: 0x244CCC0
	private void Start() { }

	// RVA: 0x244CE10 Offset: 0x244CF11 VA: 0x244CE10 Slot: 4
	public virtual void SetData(UnitItem selectedItem) { }

	// RVA: 0x244E7E0 Offset: 0x244E8E1 VA: 0x244E7E0 Slot: 5
	public virtual void SetData(Unit unit, UnitItem selectedItem) { }

	// RVA: 0x2451960 Offset: 0x2451A61 VA: 0x2451960 Slot: 6
	public virtual void SetData(UnitItem unitItemBase, UnitItem unitItemTarget, Unit unit) { }

	// RVA: 0x2453CE0 Offset: 0x2453DE1 VA: 0x2453CE0 Slot: 7
	public virtual void SetData(UnitItem unitItem, ItemMenuDetailSetter.Kind kind, int value) { }

	// RVA: 0x2455250 Offset: 0x2455351 VA: 0x2455250 Slot: 8
	public virtual void SetMenuTitle(string title) { }

	// RVA: 0x24552D0 Offset: 0x24553D1 VA: 0x24552D0
	public void SetContentsText(string message) { }

	// RVA: 0x244E060 Offset: 0x244E161 VA: 0x244E060
	private void SetRangeText(int rI, int rO) { }

	// RVA: 0x244E2F0 Offset: 0x244E3F1 VA: 0x244E2F0
	private void SetContentsText(UnitItem item) { }

	// RVA: 0x244E4F0 Offset: 0x244E5F1 VA: 0x244E4F0
	private void TrySetUpDownIcon(Image icon, out Color color, int before, int now) { }

	// RVA: 0x24539F0 Offset: 0x2453AF1 VA: 0x24539F0
	private void TrySetUpDownIconForWeight(Image icon, out Color color, int before, int now) { }

	// RVA: 0x244DF40 Offset: 0x244E041 VA: 0x244DF40
	private void PlayAnim(bool isOpen) { }

	// RVA: 0x2455350 Offset: 0x2455451 VA: 0x2455350
	public void .ctor() { }
}

