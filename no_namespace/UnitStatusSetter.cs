// Namespace: 
private enum UnitStatusSetter.ForceType // TypeDefIndex: 12686
{
	// Fields
	public int value__; // 0x0
	public const UnitStatusSetter.ForceType Player = 0;
	public const UnitStatusSetter.ForceType Enemy = 1;
	public const UnitStatusSetter.ForceType Ally = 2;
	public const UnitStatusSetter.ForceType F4th = 3;
	public const UnitStatusSetter.ForceType Count = 4;
}

// Namespace: 
private enum UnitStatusSetter.GodBuffType // TypeDefIndex: 12688
{
	// Fields
	public int value__; // 0x0
	public const UnitStatusSetter.GodBuffType Blue = 0;
	public const UnitStatusSetter.GodBuffType Red = 1;
	public const UnitStatusSetter.GodBuffType Count = 2;
}

// Namespace: 
public enum UnitStatusSetter.RingType // TypeDefIndex: 12690
{
	// Fields
	public int value__; // 0x0
	public const UnitStatusSetter.RingType God = 0;
	public const UnitStatusSetter.RingType Ring = 1;
	public const UnitStatusSetter.RingType DarkGod = 2;
	public const UnitStatusSetter.RingType None = 3;
}

// Namespace: 
[Serializable]
public class UnitStatusSetter.ValueParam // TypeDefIndex: 12692
{
	// Fields
	private UnitStatusSetter m_setter; // 0x10
	public GameObject m_root; // 0x18
	private TextMeshProUGUI m_title; // 0x20
	private TextMeshProUGUI m_value; // 0x28
	private Image m_upArrow; // 0x30
	private GameObject m_godUpBalloon; // 0x38
	private Image m_balloonImage; // 0x40
	private TextMeshProUGUI m_godUpValue; // 0x48
	private Image m_godBuffImage; // 0x50

	// Methods

	// RVA: 0x1EDA910 Offset: 0x1EDAA11 VA: 0x1EDA910
	public void Init(UnitStatusSetter setter) { }

	// RVA: 0x1EDAB40 Offset: 0x1EDAC41 VA: 0x1EDAB40
	public void SetOverride(TextMeshProUGUI text, Image arrow) { }

	// RVA: 0x1EDAB80 Offset: 0x1EDAC81 VA: 0x1EDAB80
	public void SetOverrideTitle(string title) { }

	// RVA: 0x1EDAC00 Offset: 0x1EDAD01 VA: 0x1EDAC00
	public void SetValue(UnitParamDetail detail, bool isLimit, bool isGodChange) { }

	// RVA: 0x1EDAD00 Offset: 0x1EDAE01 VA: 0x1EDAD00
	public void SetValueNoEnhance(UnitParamDetail detail, bool isLimit) { }

	// RVA: 0x1ED9390 Offset: 0x1ED9491 VA: 0x1ED9390
	public void SetValueDirect(string str, int dir, bool isLimit) { }

	// RVA: 0x1EDADE0 Offset: 0x1EDAEE1 VA: 0x1EDADE0
	public void SetBalloon(int upValue, UnitStatusSetter.RingType ringType) { }

	// RVA: 0x1ED9480 Offset: 0x1ED9581 VA: 0x1ED9480
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class UnitStatusSetter.ItemSetter // TypeDefIndex: 12694
{
	// Fields
	public GameObject m_root; // 0x10
	private GameObject m_icon; // 0x18
	private TextMeshProUGUI m_name; // 0x20
	private TextMeshProUGUI m_count; // 0x28
	private Image m_godBuffImage; // 0x30
	private UnitStatusSetter m_setter; // 0x38

	// Methods

	// RVA: 0x1ED9490 Offset: 0x1ED9591 VA: 0x1ED9490
	public void Init(UnitStatusSetter setter) { }

	// RVA: 0x1ED9620 Offset: 0x1ED9721 VA: 0x1ED9620
	public void Disable() { }

	// RVA: 0x1ED96A0 Offset: 0x1ED97A1 VA: 0x1ED96A0
	public void SetEmpty(UnitStatusSetter.RingType ringType = 3) { }

	// RVA: 0x1ED9830 Offset: 0x1ED9931 VA: 0x1ED9830
	public void Set(Unit unit, UnitItem unitItem, bool isActive, bool isEquip) { }

	// RVA: 0x1ED9F20 Offset: 0x1EDA021 VA: 0x1ED9F20
	public void SetEngageItemData(Unit unit, ItemData itemData) { }

	// RVA: 0x1EDA250 Offset: 0x1EDA351 VA: 0x1EDA250
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class UnitStatusSetter.WeaponLevelSetter // TypeDefIndex: 12696
{
	// Fields
	public GameObject m_root; // 0x10
	private Image m_icon; // 0x18
	private TextMeshProUGUI m_level; // 0x20

	// Methods

	// RVA: 0x1EDAFB0 Offset: 0x1EDB0B1 VA: 0x1EDAFB0
	public void Init() { }

	// RVA: 0x1EDB0C0 Offset: 0x1EDB1C1 VA: 0x1EDB0C0
	public void Set(ItemData.Kinds kind, WeaponLevel.Kind level, int diff, JobData jobData) { }

	// RVA: 0x1EDB240 Offset: 0x1EDB341 VA: 0x1EDB240
	public void .ctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x278750 Offset: 0x278851 VA: 0x278750
private sealed class UnitStatusSetter.<>c__DisplayClass76_0 // TypeDefIndex: 12698
{
	// Fields
	public GodUnit god; // 0x10
	public Unit unit; // 0x18
	public UnitRing ring; // 0x20

	// Methods

	// RVA: 0x1ED9160 Offset: 0x1ED9261 VA: 0x1ED9160
	public void .ctor() { }

	// RVA: 0x1ED9170 Offset: 0x1ED9271 VA: 0x1ED9170
	internal void <SetDataTempRing>b__0() { }
}

