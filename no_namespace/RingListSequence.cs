// Namespace: 
public abstract class RingListSequence.PageData // TypeDefIndex: 13108
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x29B9C0 Offset: 0x29BAC1 VA: 0x29B9C0
	private int <PageIndex>k__BackingField; // 0x10

	// Properties
	public int PageIndex { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2CB230 Offset: 0x2CB331 VA: 0x2CB230
	// RVA: 0x1F50D10 Offset: 0x1F50E11 VA: 0x1F50D10
	public int get_PageIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB240 Offset: 0x2CB341 VA: 0x2CB240
	// RVA: 0x1F50D20 Offset: 0x1F50E21 VA: 0x1F50D20
	public void set_PageIndex(int value) { }

	// RVA: 0x1F50D00 Offset: 0x1F50E01 VA: 0x1F50D00
	protected void .ctor() { }
}

// Namespace: 
public class RingListSequence.RingPageData : RingListSequence.PageData // TypeDefIndex: 13110
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x29BA10 Offset: 0x29BB11 VA: 0x29BA10
	private RingData <Data>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x29BA20 Offset: 0x29BB21 VA: 0x29BA20
	private RingData <DataRankC>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x29BA30 Offset: 0x29BB31 VA: 0x29BA30
	private RingData <DataRankB>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x29BA40 Offset: 0x29BB41 VA: 0x29BA40
	private RingData <DataRankA>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x29BA50 Offset: 0x29BB51 VA: 0x29BA50
	private RingData <DataRankS>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x29BA60 Offset: 0x29BB61 VA: 0x29BA60
	private RingListSequence.GodPageData <RelatedGodPageData>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x29BA70 Offset: 0x29BB71 VA: 0x29BA70
	private int <RelatedGroupIndex>k__BackingField; // 0x48
	public static int SpecialGroupPageDataNum; // 0x0

	// Properties
	public RingData Data { get; set; }
	public RingData DataRankC { get; set; }
	public RingData DataRankB { get; set; }
	public RingData DataRankA { get; set; }
	public RingData DataRankS { get; set; }
	public RingListSequence.GodPageData RelatedGodPageData { get; set; }
	public int RelatedGroupIndex { get; set; }
	public int RelatedGroupPageDataNum { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2CB2D0 Offset: 0x2CB3D1 VA: 0x2CB2D0
	// RVA: 0x1F51F60 Offset: 0x1F52061 VA: 0x1F51F60
	public RingData get_Data() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB2E0 Offset: 0x2CB3E1 VA: 0x2CB2E0
	// RVA: 0x1F51F70 Offset: 0x1F52071 VA: 0x1F51F70
	public void set_Data(RingData value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB2F0 Offset: 0x2CB3F1 VA: 0x2CB2F0
	// RVA: 0x1F51F80 Offset: 0x1F52081 VA: 0x1F51F80
	public RingData get_DataRankC() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB300 Offset: 0x2CB401 VA: 0x2CB300
	// RVA: 0x1F51F90 Offset: 0x1F52091 VA: 0x1F51F90
	public void set_DataRankC(RingData value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB310 Offset: 0x2CB411 VA: 0x2CB310
	// RVA: 0x1F51FA0 Offset: 0x1F520A1 VA: 0x1F51FA0
	public RingData get_DataRankB() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB320 Offset: 0x2CB421 VA: 0x2CB320
	// RVA: 0x1F51FB0 Offset: 0x1F520B1 VA: 0x1F51FB0
	public void set_DataRankB(RingData value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB330 Offset: 0x2CB431 VA: 0x2CB330
	// RVA: 0x1F51FC0 Offset: 0x1F520C1 VA: 0x1F51FC0
	public RingData get_DataRankA() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB340 Offset: 0x2CB441 VA: 0x2CB340
	// RVA: 0x1F51FD0 Offset: 0x1F520D1 VA: 0x1F51FD0
	public void set_DataRankA(RingData value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB350 Offset: 0x2CB451 VA: 0x2CB350
	// RVA: 0x1F51FE0 Offset: 0x1F520E1 VA: 0x1F51FE0
	public RingData get_DataRankS() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB360 Offset: 0x2CB461 VA: 0x2CB360
	// RVA: 0x1F51FF0 Offset: 0x1F520F1 VA: 0x1F51FF0
	public void set_DataRankS(RingData value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB370 Offset: 0x2CB471 VA: 0x2CB370
	// RVA: 0x1F52000 Offset: 0x1F52101 VA: 0x1F52000
	public RingListSequence.GodPageData get_RelatedGodPageData() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB380 Offset: 0x2CB481 VA: 0x2CB380
	// RVA: 0x1F52010 Offset: 0x1F52111 VA: 0x1F52010
	public void set_RelatedGodPageData(RingListSequence.GodPageData value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB390 Offset: 0x2CB491 VA: 0x2CB390
	// RVA: 0x1F52020 Offset: 0x1F52121 VA: 0x1F52020
	public int get_RelatedGroupIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB3A0 Offset: 0x2CB4A1 VA: 0x2CB3A0
	// RVA: 0x1F52030 Offset: 0x1F52131 VA: 0x1F52030
	public void set_RelatedGroupIndex(int value) { }

	// RVA: 0x1F52040 Offset: 0x1F52141 VA: 0x1F52040
	public int get_RelatedGroupPageDataNum() { }

	// RVA: 0x1F520C0 Offset: 0x1F521C1 VA: 0x1F520C0
	public bool Build(RingData ringData) { }

	// RVA: 0x1F52160 Offset: 0x1F52261 VA: 0x1F52160
	public bool IsGotRankC() { }

	// RVA: 0x1F52170 Offset: 0x1F52271 VA: 0x1F52170
	public bool IsGotRankB() { }

	// RVA: 0x1F52180 Offset: 0x1F52281 VA: 0x1F52180
	public bool IsGotRankA() { }

	// RVA: 0x1F52190 Offset: 0x1F52291 VA: 0x1F52190
	public bool IsGotRankS() { }

	// RVA: 0x1F503A0 Offset: 0x1F504A1 VA: 0x1F503A0
	public int GetGotRankNum() { }

	// RVA: 0x1F4EE30 Offset: 0x1F4EF31 VA: 0x1F4EE30
	public RingData.Ranks GetGotMaxRank() { }

	// RVA: 0x1F521A0 Offset: 0x1F522A1 VA: 0x1F521A0
	public void .ctor() { }

	// RVA: 0x1F521B0 Offset: 0x1F522B1 VA: 0x1F521B0
	private static void .cctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x278A60 Offset: 0x278B61 VA: 0x278A60
private sealed class RingListSequence.PageDataList.<>c__DisplayClass1_0 // TypeDefIndex: 13112
{
	// Fields
	public List<RingListSequence.GodPageData> godPageDataList; // 0x10
	public List<RingListSequence.RingPageData> ringPageDataList; // 0x18

	// Methods

	// RVA: 0x21F6EF0 Offset: 0x21F6FF1 VA: 0x21F6EF0
	public void .ctor() { }

	// RVA: 0x21F6F00 Offset: 0x21F7001 VA: 0x21F6F00
	internal void <Build>b__0(GodData godData) { }

	// RVA: 0x21F6FF0 Offset: 0x21F70F1 VA: 0x21F6FF0
	internal void <Build>b__1(RingData ringData) { }
}

// Namespace: 
private class RingListSequence.RelatedGroupWindow // TypeDefIndex: 13114
{
	// Fields
	private GameObject m_RootObject; // 0x10
	private TextMeshProUGUI m_GroupNameText; // 0x18
	private string m_CurrentWorldMid; // 0x20

	// Methods

	// RVA: 0x1F51760 Offset: 0x1F51861 VA: 0x1F51760
	public void .ctor(GameObject rootObject) { }

	// RVA: 0x1F51840 Offset: 0x1F51941 VA: 0x1F51840
	public void SetText(RingListSequence.PageData pageData) { }
}

// Namespace: 
private class RingListSequence.CharaImageController : IDisposable // TypeDefIndex: 13116
{
	// Fields
	private const int CharaImageMax = 2;
	private GameObject m_RootObject; // 0x10
	private RingListSequence.CharaImage[] m_CharaImage; // 0x18
	private int m_CurrentCharaImageIndex; // 0x20

	// Methods

	// RVA: 0x1F4EEA0 Offset: 0x1F4EFA1 VA: 0x1F4EEA0
	public void .ctor(GameObject rootObject) { }

	// RVA: 0x1F4F080 Offset: 0x1F4F181 VA: 0x1F4F080 Slot: 4
	public void Dispose() { }

	// RVA: 0x1F4F160 Offset: 0x1F4F261 VA: 0x1F4F160
	public void ChangeImage(RingListSequence.PageData pageData) { }
}

// Namespace: 
private class RingListSequence.CharaNavigation // TypeDefIndex: 13118
{
	// Fields
	private const int PointMax = 13;
	private GameObject m_RootObject; // 0x10
	private Image[] m_PointImage; // 0x18
	private int m_PointNum; // 0x20
	private int m_CurrentPointIndex; // 0x24

	// Methods

	// RVA: 0x1F50420 Offset: 0x1F50521 VA: 0x1F50420
	public void .ctor(GameObject rootObject) { }

	// RVA: 0x1F50600 Offset: 0x1F50701 VA: 0x1F50600
	public void Setup(int currentPointIndex, int pointNum) { }

	// RVA: 0x1F506F0 Offset: 0x1F507F1 VA: 0x1F506F0
	public void SetCurrentPointIndex(int currentPointIndex) { }
}

// Namespace: 
private class RingListSequence.CharaInfoWindow // TypeDefIndex: 13120
{
	// Fields
	private TextMeshProUGUI m_CharaNameText; // 0x10
	private TextMeshProUGUI m_RingNameText; // 0x18
	private TextMeshProUGUI[] m_CharaDescriptionText; // 0x20
	private Image m_RingImage; // 0x28

	// Methods

	// RVA: 0x1F4F370 Offset: 0x1F4F471 VA: 0x1F4F370
	public void .ctor(GameObject rootObject) { }

	// RVA: 0x1F4F790 Offset: 0x1F4F891 VA: 0x1F4F790
	public void Clear() { }

	// RVA: 0x1F4F900 Offset: 0x1F4FA01 VA: 0x1F4F900
	public void SetPageData(RingListSequence.PageData pageData) { }

	// RVA: 0x1F4F9F0 Offset: 0x1F4FAF1 VA: 0x1F4F9F0
	private void SetPageData(RingListSequence.GodPageData godPageData) { }

	// RVA: 0x1F4FE20 Offset: 0x1F4FF21 VA: 0x1F4FE20
	private void SetPageData(RingListSequence.RingPageData ringPageData) { }
}

// Namespace: 
private class RingListSequence.RingListWindow.RingInfo // TypeDefIndex: 13122
{
	// Fields
	private const int GainMax = 3;
	private RingData.Ranks m_Rank; // 0x10
	private GameObject m_RootObject; // 0x18
	private Image m_RingImage; // 0x20
	private RingListSequence.RingListWindow.RingInfo.Gain[] m_Gain; // 0x28

	// Methods

	// RVA: 0x21F7200 Offset: 0x21F7301 VA: 0x21F7200
	public void .ctor(GameObject rootObject, RingData.Ranks rank) { }

	// RVA: 0x21F75B0 Offset: 0x21F76B1 VA: 0x21F75B0
	public void Clear() { }

	// RVA: 0x21F76C0 Offset: 0x21F77C1 VA: 0x21F76C0
	public void SetData(RingData ringData) { }
}

// Namespace: 
private enum RingListSequence.RingListWindow.RingInfoRank // TypeDefIndex: 13124
{
	// Fields
	public int value__; // 0x0
	public const RingListSequence.RingListWindow.RingInfoRank C = 0;
	public const RingListSequence.RingListWindow.RingInfoRank B = 1;
	public const RingListSequence.RingListWindow.RingInfoRank A = 2;
	public const RingListSequence.RingListWindow.RingInfoRank S = 3;
	public const RingListSequence.RingListWindow.RingInfoRank Max = 4;
}

// Namespace: 
public class RingListSequence.GodAndRingListWindow.Menu : BasicMenu // TypeDefIndex: 13126
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x29BA80 Offset: 0x29BB81 VA: 0x29BA80
	private RingListSequence.PageData <SelectedPageData>k__BackingField; // 0xC8

	// Properties
	public RingListSequence.PageData SelectedPageData { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2CB3B0 Offset: 0x2CB4B1 VA: 0x2CB3B0
	// RVA: 0x21F5E40 Offset: 0x21F5F41 VA: 0x21F5E40
	public RingListSequence.PageData get_SelectedPageData() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB3C0 Offset: 0x2CB4C1 VA: 0x2CB3C0
	// RVA: 0x21F5E50 Offset: 0x21F5F51 VA: 0x21F5E50
	public void set_SelectedPageData(RingListSequence.PageData value) { }

	// RVA: 0x21F5E60 Offset: 0x21F5F61 VA: 0x21F5E60
	private void .ctor(List<BasicMenuItem> menuItemList, BasicMenuContent menuContent) { }

	// RVA: 0x21F5E70 Offset: 0x21F5F71 VA: 0x21F5E70
	public static RingListSequence.GodAndRingListWindow.Menu CreateMenuBind(List<BasicMenuItem> menuItemList, RingListSequence.PageData currentPageData, ProcInst super) { }

	// RVA: 0x21F6240 Offset: 0x21F6341 VA: 0x21F6240 Slot: 9
	protected override void OnCreate() { }

	// RVA: 0x21F62E0 Offset: 0x21F63E1 VA: 0x21F62E0 Slot: 10
	protected override void OnDispose() { }
}

// Namespace: 
public class RingListSequence.GodAndRingListWindow.MenuContent : GodUnitSelectMenuContent // TypeDefIndex: 13128
{
	// Methods

	// RVA: 0x21F63A0 Offset: 0x21F64A1 VA: 0x21F63A0 Slot: 4
	public override int GetMenuItemContentMax() { }

	// RVA: 0x21F5F80 Offset: 0x21F6081 VA: 0x21F5F80
	public static RingListSequence.GodAndRingListWindow.MenuContent CreateContent() { }

	// RVA: 0x21F63B0 Offset: 0x21F64B1 VA: 0x21F63B0
	public void .ctor() { }
}

// Namespace: 
private class RingListSequence.GodAndRingListWindow // TypeDefIndex: 13130
{
	// Fields
	private GameObject m_RootObject; // 0x10
	private RingListSequence.GodAndRingListWindow.Menu m_Menu; // 0x18

	// Methods

	// RVA: 0x1F50850 Offset: 0x1F50951 VA: 0x1F50850
	public void .ctor(GameObject rootObject) { }

	// RVA: 0x1F50890 Offset: 0x1F50991 VA: 0x1F50890
	public void Delete() { }

	// RVA: 0x1F508B0 Offset: 0x1F509B1 VA: 0x1F508B0
	public void CreateBind(ProcInst super, RingListSequence.PageData currentPageData) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x278A70 Offset: 0x278B71 VA: 0x278A70
[Serializable]
private sealed class RingListSequence.<>c // TypeDefIndex: 13132
{
	// Fields
	public static readonly RingListSequence.<>c <>9; // 0x0
	public static RingListSkillMenu.CancelEventHandler <>9__42_0; // 0x8

	// Methods

	// RVA: 0x1F4E1A0 Offset: 0x1F4E2A1 VA: 0x1F4E1A0
	private static void .cctor() { }

	// RVA: 0x1F4E210 Offset: 0x1F4E311 VA: 0x1F4E210
	public void .ctor() { }

	// RVA: 0x1F4E220 Offset: 0x1F4E321 VA: 0x1F4E220
	internal BasicMenu.Result <SetPageData>b__42_0() { }
}

