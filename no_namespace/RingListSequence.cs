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
public class RingListSequence.GodPageData : RingListSequence.PageData // TypeDefIndex: 13109
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x29B9D0 Offset: 0x29BAD1 VA: 0x29B9D0
	private GodData <Data>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x29B9E0 Offset: 0x29BAE1 VA: 0x29B9E0
	private int <RelatedGroupIndex>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x29B9F0 Offset: 0x29BAF1 VA: 0x29B9F0
	private int <RelatedGroupPageDataNum>k__BackingField; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x29BA00 Offset: 0x29BB01 VA: 0x29BA00
	private BasicMenuSelect <MenuSelect>k__BackingField; // 0x28

	// Properties
	public GodData Data { get; set; }
	public int RelatedGroupIndex { get; set; }
	public int RelatedGroupPageDataNum { get; set; }
	public BasicMenuSelect MenuSelect { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2CB250 Offset: 0x2CB351 VA: 0x2CB250
	// RVA: 0x1F50AD0 Offset: 0x1F50BD1 VA: 0x1F50AD0
	public GodData get_Data() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB260 Offset: 0x2CB361 VA: 0x2CB260
	// RVA: 0x1F50AE0 Offset: 0x1F50BE1 VA: 0x1F50AE0
	public void set_Data(GodData value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB270 Offset: 0x2CB371 VA: 0x2CB270
	// RVA: 0x1F50AF0 Offset: 0x1F50BF1 VA: 0x1F50AF0
	public int get_RelatedGroupIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB280 Offset: 0x2CB381 VA: 0x2CB280
	// RVA: 0x1F50B00 Offset: 0x1F50C01 VA: 0x1F50B00
	public void set_RelatedGroupIndex(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB290 Offset: 0x2CB391 VA: 0x2CB290
	// RVA: 0x1F50B10 Offset: 0x1F50C11 VA: 0x1F50B10
	public void set_RelatedGroupPageDataNum(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB2A0 Offset: 0x2CB3A1 VA: 0x2CB2A0
	// RVA: 0x1F50B20 Offset: 0x1F50C21 VA: 0x1F50B20
	public int get_RelatedGroupPageDataNum() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB2B0 Offset: 0x2CB3B1 VA: 0x2CB2B0
	// RVA: 0x1F50B30 Offset: 0x1F50C31 VA: 0x1F50B30
	public void set_MenuSelect(BasicMenuSelect value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB2C0 Offset: 0x2CB3C1 VA: 0x2CB2C0
	// RVA: 0x1F50B40 Offset: 0x1F50C41 VA: 0x1F50B40
	public BasicMenuSelect get_MenuSelect() { }

	// RVA: 0x1F50B50 Offset: 0x1F50C51 VA: 0x1F50B50
	public void Build(GodData godData) { }

	// RVA: 0x1F50360 Offset: 0x1F50461 VA: 0x1F50360
	public int GetMaxBondLevel() { }

	// RVA: 0x1F50BE0 Offset: 0x1F50CE1 VA: 0x1F50BE0
	public int GetToLv() { }

	// RVA: 0x1F50CF0 Offset: 0x1F50DF1 VA: 0x1F50CF0
	public void .ctor() { }
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
private class RingListSequence.PageDataList.GodComparer : IComparer<RingListSequence.GodPageData> // TypeDefIndex: 13111
{
	// Methods

	// RVA: 0x21F71D0 Offset: 0x21F72D1 VA: 0x21F71D0 Slot: 4
	public int Compare(RingListSequence.GodPageData a, RingListSequence.GodPageData b) { }

	// RVA: 0x21F71F0 Offset: 0x21F72F1 VA: 0x21F71F0
	public void .ctor() { }
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
private class RingListSequence.PageDataList : List<RingListSequence.PageData> // TypeDefIndex: 13113
{
	// Methods

	// RVA: 0x1F50D30 Offset: 0x1F50E31 VA: 0x1F50D30
	public void Build() { }

	// RVA: 0x1F516E0 Offset: 0x1F517E1 VA: 0x1F516E0
	public void .ctor() { }
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
private class RingListSequence.CharaArrowGroup // TypeDefIndex: 13115
{
	// Fields
	private GameObject m_RootObject; // 0x10
	private Image m_LeftArrowImage; // 0x18
	private Image m_RightArrowImage; // 0x20

	// Methods

	// RVA: 0x1F4E230 Offset: 0x1F4E331 VA: 0x1F4E230
	public void .ctor(GameObject rootObject) { }

	// RVA: 0x1F4E390 Offset: 0x1F4E491 VA: 0x1F4E390
	public void ShowAll() { }

	// RVA: 0x1F4E3D0 Offset: 0x1F4E4D1 VA: 0x1F4E3D0
	public void HideAll() { }
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
private class RingListSequence.CharaImage : IDisposable // TypeDefIndex: 13117
{
	// Fields
	private GameObject m_RootObject; // 0x10
	private Animator m_RootAnimator; // 0x18
	private Image m_CharaImage; // 0x20
	private Image m_FrameImage; // 0x28
	private Image m_BackImage; // 0x30
	private Material m_CharaMaterial; // 0x38
	private Material m_FrameMaterial; // 0x40

	// Methods

	// RVA: 0x1F4E410 Offset: 0x1F4E511 VA: 0x1F4E410
	public void .ctor(GameObject rootObject) { }

	// RVA: 0x1F4E5B0 Offset: 0x1F4E6B1 VA: 0x1F4E5B0 Slot: 4
	public void Dispose() { }

	// RVA: 0x1F4E630 Offset: 0x1F4E731 VA: 0x1F4E630
	public void FadeIn() { }

	// RVA: 0x1F4E6C0 Offset: 0x1F4E7C1 VA: 0x1F4E6C0
	public void FadeOut() { }

	// RVA: 0x1F4E750 Offset: 0x1F4E851 VA: 0x1F4E750
	public void ChangeImage(RingListSequence.PageData pageData) { }

	// RVA: 0x1F4E840 Offset: 0x1F4E941 VA: 0x1F4E840
	private void ChangeGodChara(RingListSequence.GodPageData godPageData) { }

	// RVA: 0x1F4E990 Offset: 0x1F4EA91 VA: 0x1F4E990
	private void ChangeRingChara(RingListSequence.RingPageData ringPageData) { }

	// RVA: 0x1F4EB80 Offset: 0x1F4EC81 VA: 0x1F4EB80
	private void SetCharaImageSprite(Sprite sprite) { }

	// RVA: 0x1F4ECF0 Offset: 0x1F4EDF1 VA: 0x1F4ECF0
	private void SetFrameImageSprite(Sprite sprite) { }
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
private enum RingListSequence.CharaInfoWindow.CharaDescriptionText // TypeDefIndex: 13119
{
	// Fields
	public int value__; // 0x0
	public const RingListSequence.CharaInfoWindow.CharaDescriptionText Overview = 0;
	public const RingListSequence.CharaInfoWindow.CharaDescriptionText Commentary = 1;
	public const RingListSequence.CharaInfoWindow.CharaDescriptionText SourceTitleHeader = 2;
	public const RingListSequence.CharaInfoWindow.CharaDescriptionText SourceTitleBody0 = 3;
	public const RingListSequence.CharaInfoWindow.CharaDescriptionText SourceTitleBody1 = 4;
	public const RingListSequence.CharaInfoWindow.CharaDescriptionText Max = 5;
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
private class RingListSequence.RingListWindow.RingInfo.Gain // TypeDefIndex: 13121
{
	// Fields
	private TextMeshProUGUI m_NameText; // 0x10
	private TextMeshProUGUI m_ParamText; // 0x18

	// Methods

	// RVA: 0x2D7DE60 Offset: 0x2D7DF61 VA: 0x2D7DE60
	public void .ctor(GameObject rootObject) { }

	// RVA: 0x2D7DF70 Offset: 0x2D7E071 VA: 0x2D7DF70
	public void SetName(CapabilityDefinition.Type capabilityType, bool isOpend) { }

	// RVA: 0x2D7E080 Offset: 0x2D7E181 VA: 0x2D7E080
	public void SetParam(int capabilityEnhance) { }
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
private class RingListSequence.RingListWindow.SkillInfo // TypeDefIndex: 13123
{
	// Fields
	private GameObject m_RootObject; // 0x10
	private Image m_IconImage; // 0x18
	private TextMeshProUGUI m_NameText; // 0x20
	private TextMeshProUGUI m_DescriptionText; // 0x28

	// Methods

	// RVA: 0x21F7840 Offset: 0x21F7941 VA: 0x21F7840
	public void .ctor(GameObject rootObject) { }

	// RVA: 0x21F79E0 Offset: 0x21F7AE1 VA: 0x21F79E0
	public void Clear() { }

	// RVA: 0x21F7A60 Offset: 0x21F7B61 VA: 0x21F7A60
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
private class RingListSequence.RingListWindow // TypeDefIndex: 13125
{
	// Fields
	private GameObject m_RootObject; // 0x10
	private TextMeshProUGUI m_TitleText; // 0x18
	private RingListSequence.RingListWindow.RingInfo[] m_RingInfo; // 0x20
	private RingListSequence.RingListWindow.SkillInfo m_SkillInfo; // 0x28

	// Methods

	// RVA: 0x1F519A0 Offset: 0x1F51AA1 VA: 0x1F519A0
	public void .ctor(GameObject rootObject) { }

	// RVA: 0x1F51DF0 Offset: 0x1F51EF1 VA: 0x1F51DF0
	public void Clear() { }

	// RVA: 0x1F51E90 Offset: 0x1F51F91 VA: 0x1F51E90
	public void SetData(RingListSequence.RingPageData ringPageData) { }

	// RVA: 0x1F51DE0 Offset: 0x1F51EE1 VA: 0x1F51DE0
	public void Show() { }

	// RVA: 0x1F51F50 Offset: 0x1F52051 VA: 0x1F51F50
	public void Hide() { }
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
public class RingListSequence.GodAndRingListWindow.MenuItem : BasicMenuItem // TypeDefIndex: 13127
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x29BA90 Offset: 0x29BB91 VA: 0x29BA90
	private RingListSequence.PageData <PageData>k__BackingField; // 0x68

	// Properties
	public RingListSequence.PageData PageData { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2CB3D0 Offset: 0x2CB4D1 VA: 0x2CB3D0
	// RVA: 0x21F63C0 Offset: 0x21F64C1 VA: 0x21F63C0
	public RingListSequence.PageData get_PageData() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB3E0 Offset: 0x2CB4E1 VA: 0x2CB3E0
	// RVA: 0x21F63D0 Offset: 0x21F64D1 VA: 0x21F63D0
	public void set_PageData(RingListSequence.PageData value) { }

	// RVA: 0x21F63E0 Offset: 0x21F64E1 VA: 0x21F63E0
	public void .ctor(RingListSequence.PageData pageData) { }

	// RVA: 0x21F6420 Offset: 0x21F6521 VA: 0x21F6420 Slot: 4
	public override string GetName() { }

	// RVA: 0x21F6750 Offset: 0x21F6851 VA: 0x21F6750 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x21F6630 Offset: 0x21F6731 VA: 0x21F6630
	private bool IsGod() { }

	// RVA: 0x21F66C0 Offset: 0x21F67C1 VA: 0x21F66C0
	private bool IsRing() { }

	// RVA: 0x21F6760 Offset: 0x21F6861 VA: 0x21F6760 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x21F6920 Offset: 0x21F6A21 VA: 0x21F6920 Slot: 19
	public override BasicMenu.Result BCall() { }
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
public class RingListSequence.GodAndRingListWindow.MenuItemContent : BasicMenuItemContent // TypeDefIndex: 13129
{
	// Fields
	private UnitMenuItemSetter m_Setter; // 0x48

	// Methods

	// RVA: 0x21F6A80 Offset: 0x21F6B81 VA: 0x21F6A80 Slot: 5
	public override TextMeshProUGUI GetTextMeshProComponent() { }

	// RVA: 0x21F6AA0 Offset: 0x21F6BA1 VA: 0x21F6AA0 Slot: 8
	public override void Build(BasicMenuItem menuItem) { }

	// RVA: 0x21F6E90 Offset: 0x21F6F91 VA: 0x21F6E90 Slot: 7
	protected override void UpdateTextColor() { }

	// RVA: 0x21F6B60 Offset: 0x21F6C61 VA: 0x21F6B60
	public void SetupByMenuItem(RingListSequence.GodAndRingListWindow.MenuItem menuItem) { }

	// RVA: 0x21F6EE0 Offset: 0x21F6FE1 VA: 0x21F6EE0
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
private enum RingListSequence.Label // TypeDefIndex: 13131
{
	// Fields
	public int value__; // 0x0
	public const RingListSequence.Label Start = 0;
	public const RingListSequence.Label End = 1;
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

