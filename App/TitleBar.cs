// Namespace: App
public class TitleBar : MonoBehaviour // TypeDefIndex: 13459
{
	// Fields
	private const string PrefabPath = "UI/Common/ContentTitle/Prefabs/ContentTitleRoot";
	public Animator m_AnimatorHeader; // 0x18
	public Animator m_AnimatorFooter; // 0x20
	[HeaderAttribute] // RVA: 0x29C190 Offset: 0x29C291 VA: 0x29C190
	public TitleBar.Title m_Title0; // 0x28
	public TitleBar.Title m_Title1; // 0x30
	[HeaderAttribute] // RVA: 0x29C1D0 Offset: 0x29C2D1 VA: 0x29C1D0
	public TitleBar.Values m_Values0; // 0x38
	public TitleBar.Values m_Values1; // 0x40
	[RangeAttribute] // RVA: 0x29C210 Offset: 0x29C311 VA: 0x29C210
	[HeaderAttribute] // RVA: 0x29C210 Offset: 0x29C311 VA: 0x29C210
	public float m_CountTime; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x29C270 Offset: 0x29C371 VA: 0x29C270
	private static TitleBar <Instance>k__BackingField; // 0x0
	private TitleBar.Title m_CurrentTitle; // 0x50
	private TitleBar.Values m_CurrentValues; // 0x58
	private string m_HeaderTitle; // 0x60
	private string m_HeaderTitleHelp; // 0x68
	private string m_HeaderKeyHelp; // 0x70
	private TitleBar.FooterType m_FooterType; // 0x78
	private bool m_IsShowHeader; // 0x7C
	private bool m_IsShowFooter; // 0x7D
	private bool m_IsOpenHeader; // 0x7E
	private bool m_IsOpenFooter; // 0x7F
	private bool m_IsSameFooter; // 0x80
	private TitleBar.Num m_NumDisplay; // 0x88
	private TitleBar.Num m_NumCurrent; // 0x90
	private TitleBar.Num m_NumCountValue; // 0x98
	private float m_NumCount; // 0xA0
	private List<ValueCountController> m_ValueCountList; // 0xA8

	// Properties
	public static TitleBar Instance { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2CB9F0 Offset: 0x2CBAF1 VA: 0x2CB9F0
	// RVA: 0x25DE7F0 Offset: 0x25DE8F1 VA: 0x25DE7F0
	public static TitleBar get_Instance() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CBA00 Offset: 0x2CBB01 VA: 0x2CBA00
	// RVA: 0x25DE860 Offset: 0x25DE961 VA: 0x25DE860
	private static void set_Instance(TitleBar value) { }

	// RVA: 0x25DE8E0 Offset: 0x25DE9E1 VA: 0x25DE8E0
	public static void CreateAsync(ProcInst super) { }

	// RVA: 0x25DEB90 Offset: 0x25DEC91 VA: 0x25DEB90
	private static void LoadPrefabAsync() { }

	// RVA: 0x25DEC30 Offset: 0x25DED31 VA: 0x25DEC30
	private static bool IsLoadingPrefab() { }

	// RVA: 0x25DECC0 Offset: 0x25DEDC1 VA: 0x25DECC0
	private static void CreateInstance() { }

	// RVA: 0x25DED90 Offset: 0x25DEE91 VA: 0x25DED90
	private static TitleBar Create() { }

	// RVA: 0x25DEEC0 Offset: 0x25DEFC1 VA: 0x25DEEC0
	private void Update() { }

	// RVA: 0x25DF690 Offset: 0x25DF791 VA: 0x25DF690
	public void HideHeader() { }

	// RVA: 0x25DF730 Offset: 0x25DF831 VA: 0x25DF730
	public void HideHeaderKeyHelp(string keyHelp) { }

	// RVA: 0x25DF820 Offset: 0x25DF921 VA: 0x25DF820
	public void HideFooter() { }

	// RVA: 0x25DFA30 Offset: 0x25DFB31 VA: 0x25DFA30
	public void ShowHeader() { }

	// RVA: 0x25DFAD0 Offset: 0x25DFBD1 VA: 0x25DFAD0
	public void ShowHeaderKeyHelp() { }

	// RVA: 0x25DFB30 Offset: 0x25DFC31 VA: 0x25DFB30
	public void ShowFooter() { }

	// RVA: 0x25DFBD0 Offset: 0x25DFCD1 VA: 0x25DFBD0
	public bool IsOpenHeader() { }

	// RVA: 0x25DFBE0 Offset: 0x25DFCE1 VA: 0x25DFBE0
	public bool IsOpenFooter() { }

	// RVA: 0x25DFBF0 Offset: 0x25DFCF1 VA: 0x25DFBF0
	public bool OpenHeader(string title, string titleHelp, string keyHelpId) { }

	// RVA: 0x25DFFF0 Offset: 0x25E00F1 VA: 0x25DFFF0
	public void OpenHeaderSortie(string title, string titleHelp, string keyHelpId, int unitNum, int unitMaxNum) { }

	// RVA: 0x25E0210 Offset: 0x25E0311 VA: 0x25E0210
	public void OpenFooter(TitleBar.FooterType type) { }

	// RVA: 0x25E0ED0 Offset: 0x25E0FD1 VA: 0x25E0ED0
	public void CloseHeader() { }

	// RVA: 0x25E1080 Offset: 0x25E1181 VA: 0x25E1080
	public void CloseFooter() { }

	// RVA: 0x25E0E70 Offset: 0x25E0F71 VA: 0x25E0E70
	public void UpdateFooterValues() { }

	// RVA: 0x25E00E0 Offset: 0x25E01E1 VA: 0x25E00E0
	public void SetUnitNum(int num, int maxNum = 0) { }

	// RVA: 0x25DF7D0 Offset: 0x25DF8D1 VA: 0x25DF7D0
	private void TransitHeader(string title, string titleHelp, string keyHelpId) { }

	// RVA: 0x25E1F10 Offset: 0x25E2011 VA: 0x25E1F10
	private TitleBar.AnimType GetAnimType(Animator animator) { }

	// RVA: 0x25E0F90 Offset: 0x25E1091 VA: 0x25E0F90
	private void ClearHeaderAnim() { }

	// RVA: 0x25E12A0 Offset: 0x25E13A1 VA: 0x25E12A0
	private void ClearFooterAnim() { }

	// RVA: 0x25E1DB0 Offset: 0x25E1EB1 VA: 0x25E1DB0
	private bool IsHeaderSortie() { }

	// RVA: 0x25DFDC0 Offset: 0x25DFEC1 VA: 0x25DFDC0
	private void SetTitle(string title, string titleHelp, string keyHelpId) { }

	// RVA: 0x25E2020 Offset: 0x25E2121 VA: 0x25E2020
	private bool IsFooterTypeGold() { }

	// RVA: 0x25E2030 Offset: 0x25E2131 VA: 0x25E2030
	private bool IsFooterTypePieceOfBond() { }

	// RVA: 0x25E2040 Offset: 0x25E2141 VA: 0x25E2040
	private bool IsFooterTypeRefine() { }

	// RVA: 0x25E2050 Offset: 0x25E2151 VA: 0x25E2050
	private bool IsFooterTypeRefineGod() { }

	// RVA: 0x25E2060 Offset: 0x25E2161 VA: 0x25E2060
	private bool IsFooterTypeProof() { }

	// RVA: 0x25E2070 Offset: 0x25E2171 VA: 0x25E2070
	private bool IsFooterTypeRelayTicket() { }

	// RVA: 0x25E0480 Offset: 0x25E0581 VA: 0x25E0480
	private void InitFooterValue(TitleBar.Values values) { }

	// RVA: 0x25DF400 Offset: 0x25DF501 VA: 0x25DF400
	private void SetFooterValue() { }

	// RVA: 0x25E1390 Offset: 0x25E1491 VA: 0x25E1390
	private void SetFooterCountValue() { }

	// RVA: 0x25E21C0 Offset: 0x25E22C1 VA: 0x25E21C0
	private void SetMaterialActive(TitleBar.Values values, int index, Sprite iconSprite, string name) { }

	// RVA: 0x25E2680 Offset: 0x25E2781 VA: 0x25E2680
	private void SetMaterialValue(TitleBar.Values values, int index, int value) { }

	// RVA: 0x25E2520 Offset: 0x25E2621 VA: 0x25E2520
	private void UpdateValueMoney(TitleBar.Values values) { }

	// RVA: 0x25E25D0 Offset: 0x25E26D1 VA: 0x25E25D0
	private void UpdateValuePieceOfBond(TitleBar.Values values) { }

	// RVA: 0x25E24A0 Offset: 0x25E25A1 VA: 0x25E24A0
	private void UpdateValueRefine(TitleBar.Values values) { }

	// RVA: 0x25E2120 Offset: 0x25E2221 VA: 0x25E2120
	private void UpdateValueRefineGod(TitleBar.Values values) { }

	// RVA: 0x25E2430 Offset: 0x25E2531 VA: 0x25E2430
	private void UpdateValueProof(TitleBar.Values values) { }

	// RVA: 0x25E2500 Offset: 0x25E2601 VA: 0x25E2500
	private void UpdateValueRelayTicket(TitleBar.Values values) { }

	// RVA: 0x25E1DD0 Offset: 0x25E1ED1 VA: 0x25E1DD0
	private void TransitTitleAnim() { }

	// RVA: 0x25E1C70 Offset: 0x25E1D71 VA: 0x25E1C70
	private void TransitValuesAnim() { }

	// RVA: 0x25E27B0 Offset: 0x25E28B1 VA: 0x25E27B0
	private TitleBar.Title GetHiddenTitle() { }

	// RVA: 0x25E27D0 Offset: 0x25E28D1 VA: 0x25E27D0
	private TitleBar.Values GetHiddenValues() { }

	// RVA: 0x25E27F0 Offset: 0x25E28F1 VA: 0x25E27F0
	public void .ctor() { }

	// RVA: 0x25E2950 Offset: 0x25E2A51 VA: 0x25E2950
	private static void .cctor() { }
}

