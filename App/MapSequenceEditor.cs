// Namespace: App
public class MapSequenceEditor : SingletonProcInst<MapSequenceEditor> // TypeDefIndex: 11994
{
	// Fields
	private List<MapEditorObjectData> m_ObjectList; // 0x78
	private int m_Index; // 0x80
	private VersusMapEditContent m_MapEditSelect; // 0x88
	public static readonly string PutEffectPath; // 0x0
	private int m_OldX; // 0x90
	private int m_OldZ; // 0x94
	[CompilerGeneratedAttribute] // RVA: 0x299AC0 Offset: 0x299BC1 VA: 0x299AC0
	private bool <IsDisableInfo>k__BackingField; // 0x98
	private bool m_IsSettable; // 0x99
	private int m_PrevRotate; // 0x9C
	private bool m_IsPlayableFailure; // 0xA0

	// Properties
	private MapEditorObjectData SelectObject { get; }
	public bool IsDisableInfo { get; set; }
	public static string EndConfirmTitleMid { get; }
	public static string EndConfirmNoSaveTitleMid { get; }
	public static string EndConfirmYesMid { get; }
	public static string EndConfirmNoMid { get; }

	// Methods

	// RVA: 0x1D8A180 Offset: 0x1D8A281 VA: 0x1D8A180
	private MapEditorObjectData get_SelectObject() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C72A0 Offset: 0x2C73A1 VA: 0x2C72A0
	// RVA: 0x1D8A1F0 Offset: 0x1D8A2F1 VA: 0x1D8A1F0
	public bool get_IsDisableInfo() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C72B0 Offset: 0x2C73B1 VA: 0x2C72B0
	// RVA: 0x1D8A200 Offset: 0x1D8A301 VA: 0x1D8A200
	private void set_IsDisableInfo(bool value) { }

	// RVA: 0x1D8A210 Offset: 0x1D8A311 VA: 0x1D8A210 Slot: 9
	protected override void OnCreate() { }

	// RVA: 0x1D8A340 Offset: 0x1D8A441 VA: 0x1D8A340 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x1D8A460 Offset: 0x1D8A561 VA: 0x1D8A460
	private void LoadResources() { }

	// RVA: 0x1D8A530 Offset: 0x1D8A631 VA: 0x1D8A530
	private bool IsLoadingResources() { }

	// RVA: 0x1D8A5C0 Offset: 0x1D8A6C1 VA: 0x1D8A5C0
	private void StartSequence() { }

	// RVA: 0x1D8A6A0 Offset: 0x1D8A7A1 VA: 0x1D8A6A0
	private void EndSequence() { }

	// RVA: 0x1D8A760 Offset: 0x1D8A861 VA: 0x1D8A760
	private void UnloadResources() { }

	// RVA: 0x1D8A810 Offset: 0x1D8A911 VA: 0x1D8A810
	private void MainMenu() { }

	// RVA: 0x1D8A820 Offset: 0x1D8A921 VA: 0x1D8A820
	private void BeginFreeCursor() { }

	// RVA: 0x1D8A990 Offset: 0x1D8AA91 VA: 0x1D8A990
	private void UpdateSettableStatus() { }

	// RVA: 0x1D8AAE0 Offset: 0x1D8ABE1 VA: 0x1D8AAE0
	private void TickFreeCursor() { }

	// RVA: 0x1D8D1E0 Offset: 0x1D8D2E1 VA: 0x1D8D1E0
	private bool UpdateRotateObject() { }

	// RVA: 0x1D8CBE0 Offset: 0x1D8CCE1 VA: 0x1D8CBE0
	private void UpdateCursor() { }

	// RVA: 0x1D8E060 Offset: 0x1D8E161 VA: 0x1D8E060
	private bool CanPut() { }

	// RVA: 0x1D8DA20 Offset: 0x1D8DB21 VA: 0x1D8DA20
	private void UpdateCursorColor() { }

	// RVA: 0x1D8DB60 Offset: 0x1D8DC61 VA: 0x1D8DB60
	private void SetActiveUnit(Unit target) { }

	// RVA: 0x1D8A960 Offset: 0x1D8AA61 VA: 0x1D8A960
	private void UpdateInfoPanels() { }

	// RVA: 0x1D8DFB0 Offset: 0x1D8E0B1 VA: 0x1D8DFB0
	private void UpdateKeyHelp() { }

	// RVA: 0x1D8DF10 Offset: 0x1D8E011 VA: 0x1D8DF10
	private void CursorSound() { }

	// RVA: 0x1D8BD00 Offset: 0x1D8BE01 VA: 0x1D8BD00
	private void UpdateFailureStatus() { }

	// RVA: 0x1D8CB70 Offset: 0x1D8CC71 VA: 0x1D8CB70
	private void PlayFailure() { }

	// RVA: 0x1D8D9A0 Offset: 0x1D8DAA1 VA: 0x1D8D9A0
	private void PlayRotateSE() { }

	// RVA: 0x1D8D160 Offset: 0x1D8D261 VA: 0x1D8D160
	private void PlayUndoSE() { }

	// RVA: 0x1D8BE50 Offset: 0x1D8BF51 VA: 0x1D8BE50
	private Unit GetPlayerUnitCursor() { }

	// RVA: 0x1D8C160 Offset: 0x1D8C261 VA: 0x1D8C160
	private bool IsSortieCursor() { }

	// RVA: 0x1D8C460 Offset: 0x1D8C561 VA: 0x1D8C460
	private bool IsSettableArea() { }

	// RVA: 0x1D8E9C0 Offset: 0x1D8EAC1 VA: 0x1D8E9C0
	private void EndFreeCursor() { }

	// RVA: 0x1D8A950 Offset: 0x1D8AA51 VA: 0x1D8A950
	private void ShowKeyHelp() { }

	// RVA: 0x1D8CFE0 Offset: 0x1D8D0E1 VA: 0x1D8CFE0
	private void HideKeyHelp() { }

	// RVA: 0x1D8E400 Offset: 0x1D8E501 VA: 0x1D8E400
	private void TerrainInfoUpdate() { }

	// RVA: 0x1D8EB70 Offset: 0x1D8EC71 VA: 0x1D8EB70
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x1D8C750 Offset: 0x1D8C851 VA: 0x1D8C750
	private GameObject SetMapObject(MapEditorObjectData objData) { }

	// RVA: 0x1D8F6A0 Offset: 0x1D8F7A1 VA: 0x1D8F6A0
	private void InitializeSelectObject() { }

	// RVA: 0x1D8D060 Offset: 0x1D8D161 VA: 0x1D8D060
	private bool TryPrevSelectObject(bool isTrigger) { }

	// RVA: 0x1D8D0E0 Offset: 0x1D8D1E1 VA: 0x1D8D0E0
	private bool TryNextSelectObject(bool isTrigger) { }

	// RVA: 0x1D8E6F0 Offset: 0x1D8E7F1 VA: 0x1D8E6F0
	private void UpdateInfo() { }

	// RVA: 0x1D8F800 Offset: 0x1D8F901 VA: 0x1D8F800
	private void PlayBgm() { }

	// RVA: 0x1D8F8C0 Offset: 0x1D8F9C1 VA: 0x1D8F8C0
	private void StopBgm() { }

	// RVA: 0x1D8F980 Offset: 0x1D8FA81 VA: 0x1D8F980
	public static string get_EndConfirmTitleMid() { }

	// RVA: 0x1D8F9D0 Offset: 0x1D8FAD1 VA: 0x1D8F9D0
	public static string get_EndConfirmNoSaveTitleMid() { }

	// RVA: 0x1D8FA20 Offset: 0x1D8FB21 VA: 0x1D8FA20
	public static string get_EndConfirmYesMid() { }

	// RVA: 0x1D8FA70 Offset: 0x1D8FB71 VA: 0x1D8FA70
	public static string get_EndConfirmNoMid() { }

	// RVA: 0x1D8FAC0 Offset: 0x1D8FBC1 VA: 0x1D8FAC0
	public static bool IsCasualField() { }

	// RVA: 0x1D8F610 Offset: 0x1D8F711 VA: 0x1D8F610
	public void .ctor() { }

	// RVA: 0x1D8FB60 Offset: 0x1D8FC61 VA: 0x1D8FB60
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C72C0 Offset: 0x2C73C1 VA: 0x2C72C0
	// RVA: 0x1D8FBD0 Offset: 0x1D8FCD1 VA: 0x1D8FBD0
	private void <TickFreeCursor>g__ToOneCallback|24_0(int index) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C72D0 Offset: 0x2C73D1 VA: 0x2C72D0
	// RVA: 0x1D8FC50 Offset: 0x1D8FD51 VA: 0x1D8FC50
	private void <TickFreeCursor>g__OnSelectCallback|24_1(MapEditorCategoryData category) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C72E0 Offset: 0x2C73E1 VA: 0x2C72E0
	// RVA: 0x1D8FC60 Offset: 0x1D8FD61 VA: 0x1D8FC60
	private void <TickFreeCursor>g__OnCloseCallback|24_2() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C72F0 Offset: 0x2C73F1 VA: 0x2C72F0
	// RVA: 0x1D8FC70 Offset: 0x1D8FD71 VA: 0x1D8FC70
	private void <TickFreeCursor>b__24_5() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C7300 Offset: 0x2C7401 VA: 0x2C7300
	// RVA: 0x1D8FCF0 Offset: 0x1D8FDF1 VA: 0x1D8FCF0
	private void <TickFreeCursor>b__24_6() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C7310 Offset: 0x2C7411 VA: 0x2C7310
	// RVA: 0x1D8FD00 Offset: 0x1D8FE01 VA: 0x1D8FD00
	private void <TickFreeCursor>b__24_3(long _) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C7320 Offset: 0x2C7421 VA: 0x2C7320
	// RVA: 0x1D8FD30 Offset: 0x1D8FE31 VA: 0x1D8FD30
	private void <TickFreeCursor>b__24_4(long _) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C7330 Offset: 0x2C7431 VA: 0x2C7330
	// RVA: 0x1D8FD60 Offset: 0x1D8FE61 VA: 0x1D8FD60
	private void <InitializeSelectObject>b__48_0(MapEditorObjectData data) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C7340 Offset: 0x2C7441 VA: 0x2C7340
	// RVA: 0x1D8FDC0 Offset: 0x1D8FEC1 VA: 0x1D8FDC0
	private void <UpdateInfo>b__51_0(MapEditorObjectData data) { }
}

