// Namespace: App
public class MapTerrainInfo : SingletonClass<MapTerrainInfo> // TypeDefIndex: 12490
{
	// Fields
	private static readonly string PrefabPath; // 0x0
	private TResourceHandle<GameObject> m_PrefabHandle; // 0x20
	private MapTerrainInfo.MapTerrainInfoSingle[] m_MapTerrainInfoSingles; // 0x28
	private static Unit m_CalcUnit; // 0x8
	private static BattleInfo m_BattleInfo; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x29A370 Offset: 0x29A471 VA: 0x29A370
	private MapTerrainInfo.MapTerrainInfoSingle <Edit>k__BackingField; // 0x30

	// Properties
	public MapTerrainInfo.MapTerrainInfoSingle Left { get; }
	public MapTerrainInfo.MapTerrainInfoSingle Right { get; }
	public MapTerrainInfo.MapTerrainInfoSingle Edit { get; set; }

	// Methods

	// RVA: 0x2752FA0 Offset: 0x27530A1 VA: 0x2752FA0
	public void .ctor() { }

	// RVA: 0x2753120 Offset: 0x2753221 VA: 0x2753120
	public bool IsLoading() { }

	// RVA: 0x2753150 Offset: 0x2753251 VA: 0x2753150
	public void ShowAll() { }

	// RVA: 0x27531B0 Offset: 0x27532B1 VA: 0x27531B0
	public void HideAll() { }

	// RVA: 0x2753210 Offset: 0x2753311 VA: 0x2753210
	public void EventShowAll() { }

	// RVA: 0x2753270 Offset: 0x2753371 VA: 0x2753270
	public void EventHideAll() { }

	// RVA: 0x27532D0 Offset: 0x27533D1 VA: 0x27532D0
	public bool IsShowAny() { }

	// RVA: 0x2753340 Offset: 0x2753441 VA: 0x2753340
	private static Unit GetCurrentUnit(int x, int z) { }

	// RVA: 0x27534E0 Offset: 0x27535E1 VA: 0x27534E0 Slot: 5
	protected override void OnCreate() { }

	// RVA: 0x2753640 Offset: 0x2753741 VA: 0x2753640 Slot: 6
	protected override void OnDispose() { }

	// RVA: 0x27536D0 Offset: 0x27537D1 VA: 0x27536D0
	private void CreateObjects() { }

	// RVA: 0x2753650 Offset: 0x2753751 VA: 0x2753650
	private void DeleteObjects() { }

	// RVA: 0x2753810 Offset: 0x2753911 VA: 0x2753810
	public MapTerrainInfo.MapTerrainInfoSingle get_Left() { }

	// RVA: 0x2753840 Offset: 0x2753941 VA: 0x2753840
	public MapTerrainInfo.MapTerrainInfoSingle get_Right() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9630 Offset: 0x2C9731 VA: 0x2C9630
	// RVA: 0x2753870 Offset: 0x2753971 VA: 0x2753870
	public MapTerrainInfo.MapTerrainInfoSingle get_Edit() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9640 Offset: 0x2C9741 VA: 0x2C9640
	// RVA: 0x2753880 Offset: 0x2753981 VA: 0x2753880
	private void set_Edit(MapTerrainInfo.MapTerrainInfoSingle value) { }

	// RVA: 0x2753890 Offset: 0x2753991 VA: 0x2753890
	public void CreateEdit() { }

	// RVA: 0x27539B0 Offset: 0x2753AB1 VA: 0x27539B0
	public void DeleteEdit() { }

	// RVA: 0x2753A00 Offset: 0x2753B01 VA: 0x2753A00
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9650 Offset: 0x2C9751 VA: 0x2C9650
	// RVA: 0x2753AF0 Offset: 0x2753BF1 VA: 0x2753AF0
	private void <OnCreate>b__15_0(GameObject _) { }
}

