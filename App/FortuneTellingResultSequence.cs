// Namespace: App
public class FortuneTellingResultSequence : SingletonProcInst<FortuneTellingResultSequence> // TypeDefIndex: 10626
{
	// Fields
	private static readonly string[] ResPaths; // 0x0
	private Animator m_RootAnim; // 0x78
	private Animator m_CardAnim; // 0x80
	private GameObject m_ObjCharaImage; // 0x88
	private GameObject m_ObjUnitName; // 0x90
	private GameObject m_ObjResultMessage; // 0x98
	private GameObject m_GameObject; // 0xA0
	private FortuneTellingResultMenu m_Window; // 0xA8
	private static Unit m_unit; // 0x8

	// Methods

	// RVA: 0x2A03280 Offset: 0x2A03381 VA: 0x2A03280
	public static string ResPath(FortuneTellingResultSequence.ResId id) { }

	// RVA: 0x2A03550 Offset: 0x2A03651 VA: 0x2A03550
	public static void CreateBind(ProcInst super, Unit unit, Character character) { }

	// RVA: 0x2A036B0 Offset: 0x2A037B1 VA: 0x2A036B0
	private void .ctor() { }

	// RVA: 0x2A03730 Offset: 0x2A03831 VA: 0x2A03730
	private ProcDesc[] CreateDesc() { }

	// RVA: 0x2A03E50 Offset: 0x2A03F51 VA: 0x2A03E50
	private void LoadRes() { }

	// RVA: 0x2A03F60 Offset: 0x2A04061 VA: 0x2A03F60
	private bool IsLoadingRes() { }

	// RVA: 0x2A04060 Offset: 0x2A04161 VA: 0x2A04060
	private void Open() { }

	// RVA: 0x2A04550 Offset: 0x2A04651 VA: 0x2A04550
	private bool IsAnimEnd() { }

	// RVA: 0x2A04630 Offset: 0x2A04731 VA: 0x2A04630
	private void ResultTalk() { }

	// RVA: 0x2A04870 Offset: 0x2A04971 VA: 0x2A04870
	private void MenuClose() { }

	// RVA: 0x2A04A30 Offset: 0x2A04B31 VA: 0x2A04A30
	private bool IsMenuClose() { }

	// RVA: 0x2A04AE0 Offset: 0x2A04BE1 VA: 0x2A04AE0
	private void MenuCloseEnd() { }

	// RVA: 0x2A04D20 Offset: 0x2A04E21 VA: 0x2A04D20
	private static void .cctor() { }
}

