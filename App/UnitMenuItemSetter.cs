// Namespace: App
public class UnitMenuItemSetter : MonoBehaviour // TypeDefIndex: 12685
{
	// Fields
	public Image m_SelectBg; // 0x18
	public Image m_SubFrame; // 0x20
	public TextMeshProUGUI m_UnitName; // 0x28
	public Image m_Face; // 0x30
	public Image m_Icon; // 0x38
	public GameObject m_IconCheck; // 0x40
	public TextMeshProUGUI m_Message; // 0x48

	// Methods

	// RVA: 0x2443A40 Offset: 0x2443B41 VA: 0x2443A40
	public static void Setup(GameObject obj, ref UnitMenuItemSetter setter) { }

	// RVA: 0x2443BA0 Offset: 0x2443CA1 VA: 0x2443BA0
	public static void Setup(UnitMenuItemSetter setter) { }

	// RVA: 0x2443CA0 Offset: 0x2443DA1 VA: 0x2443CA0
	public void SetUnit(Unit unit, bool isShowIcon) { }

	// RVA: 0x2443EC0 Offset: 0x2443FC1 VA: 0x2443EC0
	public void SetMenuItemSelectColor(BasicMenuItem menuItem, UnitMenuItemSetter.SubFrame subFrame = 0) { }

	// RVA: 0x24442A0 Offset: 0x24443A1 VA: 0x24442A0
	public void .ctor() { }
}

