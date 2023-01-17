// Namespace: App
public class GiftContent : BasicMenuContent // TypeDefIndex: 10634
{
	// Fields
	private const string PrefabPath = "UI/Hub/Gift/Prefabs/GiftRoot";
	private const string UIName = "GiftMenu";
	private GameObject m_helpText; // 0xE8
	[SerializeField] // RVA: 0x293020 Offset: 0x293121 VA: 0x293020
	private GameObject m_Gift; // 0xF0
	[SerializeField] // RVA: 0x293030 Offset: 0x293131 VA: 0x293030
	private GameObject m_ItemCount; // 0xF8

	// Methods

	// RVA: 0x28E1700 Offset: 0x28E1801 VA: 0x28E1700
	public static void LoadPrefabAsync() { }

	// RVA: 0x28E17A0 Offset: 0x28E18A1 VA: 0x28E17A0
	public static bool IsLoadingPrefab() { }

	// RVA: 0x28E1820 Offset: 0x28E1921 VA: 0x28E1820
	public static void UnloadPrefab() { }

	// RVA: 0x28E18A0 Offset: 0x28E19A1 VA: 0x28E18A0
	public static GiftContent Create() { }

	// RVA: 0x28E1960 Offset: 0x28E1A61 VA: 0x28E1960
	public static void Destroy() { }

	// RVA: 0x28E19F0 Offset: 0x28E1AF1 VA: 0x28E19F0
	public void SetHelpText(string help) { }

	// RVA: 0x28E1A70 Offset: 0x28E1B71 VA: 0x28E1A70 Slot: 27
	public override void AfterBuild() { }

	// RVA: 0x28E1AB0 Offset: 0x28E1BB1 VA: 0x28E1AB0 Slot: 10
	protected override float CalcCursorMovedPosY(int menuItemIndex) { }

	// RVA: 0x28E1B70 Offset: 0x28E1C71 VA: 0x28E1B70 Slot: 4
	public override int GetMenuItemContentMax() { }

	// RVA: 0x28E1B80 Offset: 0x28E1C81 VA: 0x28E1B80 Slot: 21
	public override float CalcW() { }

	// RVA: 0x28E1BF0 Offset: 0x28E1CF1 VA: 0x28E1BF0 Slot: 22
	public override float CalcH() { }

	// RVA: 0x28E1C60 Offset: 0x28E1D61 VA: 0x28E1C60 Slot: 30
	protected override void Awake() { }

	// RVA: 0x28E1E60 Offset: 0x28E1F61 VA: 0x28E1E60
	public void .ctor() { }
}

