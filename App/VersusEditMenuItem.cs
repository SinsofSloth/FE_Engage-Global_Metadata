// Namespace: App
public class VersusEditMenuItem : BasicMenuItem // TypeDefIndex: 13725
{
	// Fields
	private MapEditorObjectData m_Data; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x29C930 Offset: 0x29CA31 VA: 0x29C930
	private string <Name>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x29C940 Offset: 0x29CA41 VA: 0x29C940
	private int <Index>k__BackingField; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x29C950 Offset: 0x29CA51 VA: 0x29C950
	private string <CategoryIcon>k__BackingField; // 0x80
	private MapEditorCategoryData m_Category; // 0x88
	private Action<MapEditorCategoryData> m_OnSelectCallback; // 0x90

	// Properties
	public string Name { get; set; }
	public int Index { get; set; }
	public string CategoryIcon { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2CD1C0 Offset: 0x2CD2C1 VA: 0x2CD1C0
	// RVA: 0x2A4A5C0 Offset: 0x2A4A6C1 VA: 0x2A4A5C0
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CD1D0 Offset: 0x2CD2D1 VA: 0x2CD1D0
	// RVA: 0x2A4A5D0 Offset: 0x2A4A6D1 VA: 0x2A4A5D0
	private void set_Name(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CD1E0 Offset: 0x2CD2E1 VA: 0x2CD1E0
	// RVA: 0x2A4A5E0 Offset: 0x2A4A6E1 VA: 0x2A4A5E0
	public int get_Index() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CD1F0 Offset: 0x2CD2F1 VA: 0x2CD1F0
	// RVA: 0x2A4A5F0 Offset: 0x2A4A6F1 VA: 0x2A4A5F0
	private void set_Index(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CD200 Offset: 0x2CD301 VA: 0x2CD200
	// RVA: 0x2A4A600 Offset: 0x2A4A701 VA: 0x2A4A600
	public string get_CategoryIcon() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CD210 Offset: 0x2CD311 VA: 0x2CD210
	// RVA: 0x2A4A610 Offset: 0x2A4A711 VA: 0x2A4A610
	private void set_CategoryIcon(string value) { }

	// RVA: 0x2A489F0 Offset: 0x2A48AF1 VA: 0x2A489F0
	public void .ctor(int index, MapEditorObjectData data, Action<MapEditorCategoryData> onSelectCallback) { }

	// RVA: 0x2A4A620 Offset: 0x2A4A721 VA: 0x2A4A620 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2A4A670 Offset: 0x2A4A771 VA: 0x2A4A670 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x2A4A6C0 Offset: 0x2A4A7C1 VA: 0x2A4A6C0 Slot: 12
	public override void OnSelect() { }
}

