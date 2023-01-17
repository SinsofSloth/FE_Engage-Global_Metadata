// Namespace: App
public class RefineShopExchangeMenuTop : ProcInst // TypeDefIndex: 11132
{
	// Fields
	private RefineShopExchangeRoot m_RefineShopExchangeRoot; // 0x70
	private RefineShopExchangeTargetMenu m_RefineShopExchangeTargetMenu; // 0x78
	private RefineShopExchangeSourceMenu m_RefineShopExchangeSourceMenu; // 0x80
	private RefineShopExchangeCountMenu m_RefineShopExchangeCountMenu; // 0x88
	private RefineShopExchangeResultPopup m_RefineShopExchangeResultPopup; // 0x90
	private RefineShopExchangeMenuTop.CloseEventHandler m_CloseEventHandler; // 0x98
	private BasicMenu.Result m_Result; // 0xA0
	private string m_TargetMaterialId; // 0xA8
	private string m_SourceMaterialId; // 0xB0
	private int m_TargetMaterialCount; // 0xB8
	private int m_SourceMaterialCount; // 0xBC

	// Methods

	// RVA: 0x2C67BD0 Offset: 0x2C67CD1 VA: 0x2C67BD0
	public static RefineShopExchangeMenuTop CreateBind(ProcInst super, RefineShopExchangeMenuTop.CloseEventHandler closeEventHandler) { }

	// RVA: 0x2C67D70 Offset: 0x2C67E71 VA: 0x2C67D70
	private ProcDesc[] CreateDesc() { }

	// RVA: 0x2C67CD0 Offset: 0x2C67DD1 VA: 0x2C67CD0
	private void .ctor(ProcInst super, RefineShopExchangeMenuTop.CloseEventHandler closeEventHandler) { }

	// RVA: 0x2C68530 Offset: 0x2C68631 VA: 0x2C68530
	private void StartSequence() { }

	// RVA: 0x2C68750 Offset: 0x2C68851 VA: 0x2C68750
	private void CreateSelectTargetMenu() { }

	// RVA: 0x2C68C30 Offset: 0x2C68D31 VA: 0x2C68C30
	private void OnClose() { }

	// RVA: 0x2C68C40 Offset: 0x2C68D41 VA: 0x2C68C40
	private void OnDecideTarget(string materialName) { }

	// RVA: 0x2C68CC0 Offset: 0x2C68DC1 VA: 0x2C68CC0
	private void CreateSelectSourceMenu() { }

	// RVA: 0x2C692E0 Offset: 0x2C693E1 VA: 0x2C692E0
	private void OnCloseSourceMenu() { }

	// RVA: 0x2C692F0 Offset: 0x2C693F1 VA: 0x2C692F0
	private void OnDecideSource(string materialName) { }

	// RVA: 0x2C69300 Offset: 0x2C69401 VA: 0x2C69300
	private void CreateCountMenu() { }

	// RVA: 0x2C695A0 Offset: 0x2C696A1 VA: 0x2C695A0
	private void OnDecideCount(int sourceCount, int targetCount, int targetOverflow) { }

	// RVA: 0x2C696A0 Offset: 0x2C697A1 VA: 0x2C696A0
	private void Exchange() { }

	// RVA: 0x2C69F30 Offset: 0x2C6A031 VA: 0x2C69F30
	private void EndSequence() { }

	// RVA: 0x2C69F50 Offset: 0x2C6A051 VA: 0x2C69F50
	public void Destroy() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C37B0 Offset: 0x2C38B1 VA: 0x2C37B0
	// RVA: 0x2C6A0D0 Offset: 0x2C6A1D1 VA: 0x2C6A0D0
	private bool <CreateDesc>b__14_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C37C0 Offset: 0x2C38C1 VA: 0x2C37C0
	// RVA: 0x2C6A0E0 Offset: 0x2C6A1E1 VA: 0x2C6A0E0
	private bool <CreateDesc>b__14_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C37D0 Offset: 0x2C38D1 VA: 0x2C37D0
	// RVA: 0x2C6A0F0 Offset: 0x2C6A1F1 VA: 0x2C6A0F0
	private bool <CreateDesc>b__14_2() { }
}

