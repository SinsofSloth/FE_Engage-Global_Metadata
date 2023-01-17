// Namespace: App
public class FishingPictureItem : BasicMenuItem // TypeDefIndex: 10599
{
	// Fields
	private const string cTextureAtlasPath = "UI/Hub/Fishing/Textures/Fishing";
	private const string cTextureRankLarge = "SizeBaseGold";
	private const string cTextureRankMiddle = "SizeBaseSilver";
	private const string cTextureRankSmall = "SizeBaseBronze";
	private const string cTextureGyotakuLarge = "Fish_UnknownL";
	private const string cTextureGyotakuMiddle = "Fish_UnknownM";
	private const string cTextureGyotakuSmall = "Fish_UnknownS";
	private string[] cTextureGyotakuList; // 0x68
	protected Transform m_InfoWindow; // 0x70
	protected Transform m_Gyotaku; // 0x78
	private FishingFishData m_FishData; // 0x80
	private Sprite[] m_Sprites; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x292D90 Offset: 0x292E91 VA: 0x292D90
	private int <FishSize>k__BackingField; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x292DA0 Offset: 0x292EA1 VA: 0x292DA0
	private bool <IsCrown>k__BackingField; // 0x94
	[CompilerGeneratedAttribute] // RVA: 0x292DB0 Offset: 0x292EB1 VA: 0x292DB0
	private bool <IsUnknown>k__BackingField; // 0x95

	// Properties
	public int FishSize { get; set; }
	public bool IsCrown { get; set; }
	public bool IsUnknown { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2BFB90 Offset: 0x2BFC91 VA: 0x2BFB90
	// RVA: 0x29F03E0 Offset: 0x29F04E1 VA: 0x29F03E0
	public int get_FishSize() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BFBA0 Offset: 0x2BFCA1 VA: 0x2BFBA0
	// RVA: 0x29F03F0 Offset: 0x29F04F1 VA: 0x29F03F0
	private void set_FishSize(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BFBB0 Offset: 0x2BFCB1 VA: 0x2BFBB0
	// RVA: 0x29F0400 Offset: 0x29F0501 VA: 0x29F0400
	public bool get_IsCrown() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BFBC0 Offset: 0x2BFCC1 VA: 0x2BFBC0
	// RVA: 0x29F0410 Offset: 0x29F0511 VA: 0x29F0410
	private void set_IsCrown(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BFBD0 Offset: 0x2BFCD1 VA: 0x2BFBD0
	// RVA: 0x29F0420 Offset: 0x29F0521 VA: 0x29F0420
	public bool get_IsUnknown() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BFBE0 Offset: 0x2BFCE1 VA: 0x2BFBE0
	// RVA: 0x29F0430 Offset: 0x29F0531 VA: 0x29F0430
	private void set_IsUnknown(bool value) { }

	// RVA: 0x29F0440 Offset: 0x29F0541 VA: 0x29F0440
	public void .ctor() { }

	// RVA: 0x29EE4D0 Offset: 0x29EE5D1 VA: 0x29EE4D0
	public void .ctor(FishingFishData setData, GameObject setMenu) { }

	// RVA: 0x29F06A0 Offset: 0x29F07A1 VA: 0x29F06A0 Slot: 4
	public override string GetName() { }

	// RVA: 0x29F0790 Offset: 0x29F0891 VA: 0x29F0790 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x29F07A0 Offset: 0x29F08A1 VA: 0x29F07A0 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x29F1AA0 Offset: 0x29F1BA1 VA: 0x29F1AA0 Slot: 13
	public override void OnDeselect() { }

	// RVA: 0x29F1AB0 Offset: 0x29F1BB1 VA: 0x29F1AB0 Slot: 15
	public override void OnClose() { }
}

