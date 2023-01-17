// Namespace: 
public enum FishingRodSelectMenu.Result2 // TypeDefIndex: 10610
{
	// Fields
	public int value__; // 0x0
	public const FishingRodSelectMenu.Result2 RodA = 0;
	public const FishingRodSelectMenu.Result2 RodB = 1;
	public const FishingRodSelectMenu.Result2 RodC = 2;
	public const FishingRodSelectMenu.Result2 End = 3;
}

// Namespace: 
private class FishingRodSelectMenu.RodItem : BasicMenuItem // TypeDefIndex: 10612
{
	// Fields
	private const string cTextureRootPath = "UI/Hub/Fishing/Textures/";
	private const string cAtlasPath = "Fishing";
	private const string cTextureLarge = "Large";
	private const string cTextureMiddle = "Medium";
	private const string cTextureSmall = "Small";
	private FishingRodSelectMenu.DecideEventHandler m_DecideEventHandler; // 0x68
	protected GameObject m_MenuObj; // 0x70
	private List<ForecastFishData> m_FishList; // 0x78
	private StickType m_Result; // 0x80
	public string m_Label; // 0x88
	protected Transform m_ItemTrans; // 0x90
	private List<Sprite> m_Sprites; // 0x98

	// Methods

	// RVA: 0x22DD0C0 Offset: 0x22DD1C1 VA: 0x22DD0C0
	public void .ctor(FishingRodSelectMenu.DecideEventHandler eventHandler, GameObject menuObj, Transform trans, StickType result, List<ForecastFishData> fishList) { }

	// RVA: 0x22DDA90 Offset: 0x22DDB91 VA: 0x22DDA90 Slot: 10
	public override void OnBuild() { }

	// RVA: 0x22DDAA0 Offset: 0x22DDBA1 VA: 0x22DDAA0 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x22DDAB0 Offset: 0x22DDBB1 VA: 0x22DDAB0 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x22DE3B0 Offset: 0x22DE4B1 VA: 0x22DE3B0 Slot: 13
	public override void OnDeselect() { }

	// RVA: 0x22DE4A0 Offset: 0x22DE5A1 VA: 0x22DE4A0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x22DE4E0 Offset: 0x22DE5E1 VA: 0x22DE4E0 Slot: 15
	public override void OnClose() { }
}

// Namespace: 
private class FishingRodSelectMenu.RodBItem : FishingRodSelectMenu.RodItem // TypeDefIndex: 10614
{
	// Methods

	// RVA: 0x22DD3B0 Offset: 0x22DD4B1 VA: 0x22DD3B0
	public void .ctor(FishingRodSelectMenu.DecideEventHandler eventHandler, GameObject menuObj, Transform itemTrans, List<ForecastFishData> fishList) { }

	// RVA: 0x22DD550 Offset: 0x22DD651 VA: 0x22DD550 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x22DD560 Offset: 0x22DD661 VA: 0x22DD560 Slot: 4
	public override string GetName() { }

	// RVA: 0x22DD5E0 Offset: 0x22DD6E1 VA: 0x22DD5E0 Slot: 14
	public override void OnCursorMoveEnd() { }
}

