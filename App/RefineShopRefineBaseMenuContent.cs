// Namespace: App
public class RefineShopRefineBaseMenuContent : BasicMenuContent // TypeDefIndex: 11151
{
	// Fields
	public TextMeshProUGUI m_CaptionText; // 0xE8
	public RefineShopRefineBaseMenuContent.KindIcon[] m_KindIcon; // 0xF0
	private int m_EnabledItemKindCount; // 0xF8

	// Methods

	// RVA: 0x2C6E720 Offset: 0x2C6E821 VA: 0x2C6E720 Slot: 31
	protected override void Start() { }

	// RVA: 0x2C6E930 Offset: 0x2C6EA31 VA: 0x2C6E930 Slot: 4
	public override int GetMenuItemContentMax() { }

	// RVA: 0x2C6E950 Offset: 0x2C6EA51 VA: 0x2C6E950 Slot: 10
	protected override float CalcCursorMovedPosY(int menuItemIndex) { }

	// RVA: 0x2C6D8A0 Offset: 0x2C6D9A1 VA: 0x2C6D8A0
	public void SetKind(ItemData.Kinds kind) { }

	// RVA: 0x2C6DB30 Offset: 0x2C6DC31 VA: 0x2C6DB30
	public int GetKindNum() { }

	// RVA: 0x2C6DCC0 Offset: 0x2C6DDC1 VA: 0x2C6DCC0
	public int GetKindIndex(ItemData.Kinds kind) { }

	// RVA: 0x2C6E090 Offset: 0x2C6E191 VA: 0x2C6E090
	public ItemData.Kinds SetToPrevKind(ItemData.Kinds kind) { }

	// RVA: 0x2C6E4A0 Offset: 0x2C6E5A1 VA: 0x2C6E4A0
	public ItemData.Kinds SetToNextKind(ItemData.Kinds kind) { }

	// RVA: 0x2C6E050 Offset: 0x2C6E151 VA: 0x2C6E050
	public bool IsFirstKind(ItemData.Kinds kind) { }

	// RVA: 0x2C6E450 Offset: 0x2C6E551 VA: 0x2C6E450
	public bool IsLastKind(ItemData.Kinds kind) { }

	// RVA: 0x2C6DA20 Offset: 0x2C6DB21 VA: 0x2C6DA20
	public void EnableItemKind(ItemData.Kinds kind, bool enabled) { }

	// RVA: 0x2C6E890 Offset: 0x2C6E991 VA: 0x2C6E890
	private void UpdateGetKindCount() { }

	// RVA: 0x2C6EA40 Offset: 0x2C6EB41 VA: 0x2C6EA40
	public int GetKindCount() { }

	// RVA: 0x2C6EA50 Offset: 0x2C6EB51 VA: 0x2C6EA50
	public void .ctor() { }
}

