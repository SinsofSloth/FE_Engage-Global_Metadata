// Namespace: 
[FlagsAttribute] // RVA: 0x277CE0 Offset: 0x277DE1 VA: 0x277CE0
public enum MapDispos.Flag // TypeDefIndex: 11951
{
	// Fields
	public int value__; // 0x0
	public const MapDispos.Flag Focus = 1;
	public const MapDispos.Flag FocusUnit = 2;
	public const MapDispos.Flag Forced = 4;
	public const MapDispos.Flag Warp = 8;
	public const MapDispos.Flag NotForced = 16;
	public const MapDispos.Flag Loose = 32;
	public const MapDispos.Flag FixedSpeed = 65536;
	public const MapDispos.Flag Dead = 131072;
	public const MapDispos.Flag StatusFixed = 262144;
	public const MapDispos.Flag SuppressWarning = 524288;
	public const MapDispos.Flag Instant = 1048576;
	public const MapDispos.Flag Bind = 2097152;
}

// Namespace: 
public class MapDispos.FlagField : BitField32 // TypeDefIndex: 11952
{
	// Methods

	// RVA: 0x1D3B590 Offset: 0x1D3B691 VA: 0x1D3B590
	public void Set(MapDispos.Flag f) { }

	// RVA: 0x1D3B5A0 Offset: 0x1D3B6A1 VA: 0x1D3B5A0
	public bool Test(MapDispos.Flag f) { }

	// RVA: 0x1D3B5B0 Offset: 0x1D3B6B1 VA: 0x1D3B5B0
	public bool Not(MapDispos.Flag f) { }

	// RVA: 0x1D3B5C0 Offset: 0x1D3B6C1 VA: 0x1D3B5C0
	public void Clear(MapDispos.Flag f) { }

	// RVA: 0x1D3B5D0 Offset: 0x1D3B6D1 VA: 0x1D3B5D0
	public void Reset(MapDispos.Flag f) { }

	// RVA: 0x1D3B5E0 Offset: 0x1D3B6E1 VA: 0x1D3B5E0
	public void .ctor() { }
}

// Namespace: 
public class MapDispos.Pos // TypeDefIndex: 11953
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x299A70 Offset: 0x299B71 VA: 0x299A70
	private int <X>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x299A80 Offset: 0x299B81 VA: 0x299A80
	private int <Z>k__BackingField; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x299A90 Offset: 0x299B91 VA: 0x299A90
	private DisposData.Directions <Dir>k__BackingField; // 0x18

	// Properties
	public int X { get; set; }
	public int Z { get; set; }
	public DisposData.Directions Dir { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C7220 Offset: 0x2C7321 VA: 0x2C7220
	// RVA: 0x1D3B5F0 Offset: 0x1D3B6F1 VA: 0x1D3B5F0
	public int get_X() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C7230 Offset: 0x2C7331 VA: 0x2C7230
	// RVA: 0x1D3B600 Offset: 0x1D3B701 VA: 0x1D3B600
	public void set_X(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C7240 Offset: 0x2C7341 VA: 0x2C7240
	// RVA: 0x1D3B610 Offset: 0x1D3B711 VA: 0x1D3B610
	public int get_Z() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C7250 Offset: 0x2C7351 VA: 0x2C7250
	// RVA: 0x1D3B620 Offset: 0x1D3B721 VA: 0x1D3B620
	public void set_Z(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C7260 Offset: 0x2C7361 VA: 0x2C7260
	// RVA: 0x1D3B630 Offset: 0x1D3B731 VA: 0x1D3B630
	public DisposData.Directions get_Dir() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C7270 Offset: 0x2C7371 VA: 0x2C7270
	// RVA: 0x1D3B640 Offset: 0x1D3B741 VA: 0x1D3B640
	public void set_Dir(DisposData.Directions value) { }

	// RVA: 0x1D3B650 Offset: 0x1D3B751 VA: 0x1D3B650
	public void .ctor() { }
}

// Namespace: 
private class MapDispos.PosList : List<MapDispos.Pos> // TypeDefIndex: 11954
{
	// Methods

	// RVA: 0x1D3B660 Offset: 0x1D3B761 VA: 0x1D3B660
	public void .ctor() { }

	// RVA: 0x1D3B6F0 Offset: 0x1D3B7F1 VA: 0x1D3B6F0
	public void Register(List<DisposData> dataList, int limit) { }

	// RVA: 0x1D38DE0 Offset: 0x1D38EE1 VA: 0x1D38DE0
	public MapDispos.Pos PopFront() { }

	// RVA: 0x1D3B820 Offset: 0x1D3B921 VA: 0x1D3B820
	public bool TryRemove(DisposData data) { }
}

// Namespace: 
public enum MapDispos.ActualData.CalcResults // TypeDefIndex: 11955
{
	// Fields
	public int value__; // 0x0
	public const MapDispos.ActualData.CalcResults None = 0;
	public const MapDispos.ActualData.CalcResults Success = 1;
	public const MapDispos.ActualData.CalcResults Failure = 2;
	public const MapDispos.ActualData.CalcResults Disable = 3;
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x277CF0 Offset: 0x277DF1 VA: 0x277CF0
[Serializable]
private sealed class MapDispos.ActualData.<>c // TypeDefIndex: 11956
{
	// Fields
	public static readonly MapDispos.ActualData.<>c <>9; // 0x0
	public static Predicate<Unit> <>9__38_0; // 0x8

	// Methods

	// RVA: 0x21E2D60 Offset: 0x21E2E61 VA: 0x21E2D60
	private static void .cctor() { }

	// RVA: 0x21E2DD0 Offset: 0x21E2ED1 VA: 0x21E2DD0
	public void .ctor() { }

	// RVA: 0x21E2DE0 Offset: 0x21E2EE1 VA: 0x21E2DE0
	internal bool <GetUnit>b__38_0(Unit u) { }
}

// Namespace: 
private class MapDispos.ActualData // TypeDefIndex: 11957
{
	// Fields
	private DisposData m_Data; // 0x10
	private DisposData m_PositionData; // 0x18
	private MapDispos.ActualData.CalcResults m_CalcResult; // 0x20
	private int m_UnitIndex; // 0x24
	private int m_CalcAppearX; // 0x28
	private int m_CalcAppearZ; // 0x2C
	private int m_CalcDisposX; // 0x30
	private int m_CalcDisposZ; // 0x34
	private DisposData.Directions m_Direction; // 0x38

	// Properties
	public DisposData Data { get; }
	public int DataDisposX { get; }
	public int DataDisposZ { get; }
	public MapDispos.ActualData.CalcResults CalcResult { get; }
	public int UnitIndex { get; }
	public int CalcAppearX { get; }
	public int CalcAppearZ { get; }
	public int CalcDisposX { get; }
	public int CalcDisposZ { get; }
	public DisposData.Directions DisposDir { get; }
	private PersonData DataPerson { get; }
	private Force.Type DataForceType { get; }
	private int DataAppearX { get; }
	private int DataAppearZ { get; }

	// Methods

	// RVA: 0x1D39090 Offset: 0x1D39191 VA: 0x1D39090
	public void .ctor(DisposData data, DisposData positionData) { }

	// RVA: 0x1D39100 Offset: 0x1D39201 VA: 0x1D39100
	public bool Calc(MapDispos.Flag disposFlag) { }

	// RVA: 0x1D3A2F0 Offset: 0x1D3A3F1 VA: 0x1D3A2F0
	public void UnitMove(Unit unit, int x, int z, MapDeployTemplate.Flag<MapDeploy> moveFlag) { }

	// RVA: 0x1D3A430 Offset: 0x1D3A531 VA: 0x1D3A430
	public DisposData get_Data() { }

	// RVA: 0x1D3A440 Offset: 0x1D3A541 VA: 0x1D3A440
	public int get_DataDisposX() { }

	// RVA: 0x1D3A450 Offset: 0x1D3A551 VA: 0x1D3A450
	public int get_DataDisposZ() { }

	// RVA: 0x1D3A460 Offset: 0x1D3A561 VA: 0x1D3A460
	public MapDispos.ActualData.CalcResults get_CalcResult() { }

	// RVA: 0x1D3A470 Offset: 0x1D3A571 VA: 0x1D3A470
	public int get_UnitIndex() { }

	// RVA: 0x1D3A480 Offset: 0x1D3A581 VA: 0x1D3A480
	public int get_CalcAppearX() { }

	// RVA: 0x1D3A490 Offset: 0x1D3A591 VA: 0x1D3A490
	public int get_CalcAppearZ() { }

	// RVA: 0x1D3A4A0 Offset: 0x1D3A5A1 VA: 0x1D3A4A0
	public int get_CalcDisposX() { }

	// RVA: 0x1D3A4B0 Offset: 0x1D3A5B1 VA: 0x1D3A4B0
	public int get_CalcDisposZ() { }

	// RVA: 0x1D3A4C0 Offset: 0x1D3A5C1 VA: 0x1D3A4C0
	public DisposData.Directions get_DisposDir() { }

	// RVA: 0x1D39990 Offset: 0x1D39A91 VA: 0x1D39990
	private bool CalcDisposXZ(Unit unit, out int disposX, out int disposZ) { }

	// RVA: 0x1D3A0C0 Offset: 0x1D3A1C1 VA: 0x1D3A0C0
	private bool CalcApperXZ(Unit unit, int disposX, int disposZ, out int appearX, out int appearZ) { }

	// RVA: 0x1D3AA90 Offset: 0x1D3AB91 VA: 0x1D3AA90
	private bool IsForced(MapDispos.Flag flag) { }

	// RVA: 0x1D39400 Offset: 0x1D39501 VA: 0x1D39400
	private bool IsEnable(MapDispos.Flag flag) { }

	// RVA: 0x1D3A240 Offset: 0x1D3A341 VA: 0x1D3A240
	private bool IsCreate() { }

	// RVA: 0x1D39680 Offset: 0x1D39781 VA: 0x1D39680
	private Unit GetUnit(MapDispos.Flag disposFlag) { }

	// RVA: 0x1D3AC10 Offset: 0x1D3AD11 VA: 0x1D3AC10
	private TerrainData GetTerrain(int x, int z) { }

	// RVA: 0x1D3A4D0 Offset: 0x1D3A5D1 VA: 0x1D3A4D0
	private bool IsOutOfPlayArea(Unit unit, int x, int z) { }

	// RVA: 0x1D3A680 Offset: 0x1D3A781 VA: 0x1D3A680
	private bool IsUnitExist(Unit unit, int x, int z) { }

	// RVA: 0x1D3AD40 Offset: 0x1D3AE41 VA: 0x1D3AD40
	private bool IsTerrainImmobile(int x, int z) { }

	// RVA: 0x1D3A840 Offset: 0x1D3A941 VA: 0x1D3A840
	private bool IsTerrainImmobile(Unit unit, int x, int z) { }

	// RVA: 0x1D3A970 Offset: 0x1D3AA71 VA: 0x1D3A970
	private void UnitAIMoveLimitForBigUnit(Unit unit, MapDeployTemplate.Flag<MapDeploy> moveFlag) { }

	// RVA: 0x1D3ADA0 Offset: 0x1D3AEA1 VA: 0x1D3ADA0
	private PersonData get_DataPerson() { }

	// RVA: 0x1D3A230 Offset: 0x1D3A331 VA: 0x1D3A230
	private Force.Type get_DataForceType() { }

	// RVA: 0x1D3AA40 Offset: 0x1D3AB41 VA: 0x1D3AA40
	private int get_DataAppearX() { }

	// RVA: 0x1D3AA50 Offset: 0x1D3AB51 VA: 0x1D3AA50
	private int get_DataAppearZ() { }
}

// Namespace: 
private class MapDispos.ActualDataList : List<MapDispos.ActualData> // TypeDefIndex: 11958
{
	// Methods

	// RVA: 0x1D3ADB0 Offset: 0x1D3AEB1 VA: 0x1D3ADB0
	public void .ctor(List<DisposData> dataList) { }

	// RVA: 0x1D3B160 Offset: 0x1D3B261 VA: 0x1D3B160
	public void .ctor(List<DisposData> dataList, List<DisposData> positionDataList) { }

	// RVA: 0x1D3B350 Offset: 0x1D3B451 VA: 0x1D3B350
	public bool Calc(MapDispos.Flag disposFlag) { }

	// RVA: 0x1D3AFC0 Offset: 0x1D3B0C1 VA: 0x1D3AFC0
	private List<DisposData> Filter(List<DisposData> dataList) { }
}

// Namespace: 
private class MapDispos.ProcDispos : ProcInst // TypeDefIndex: 11959
{
	// Fields
	private static int s_ProcessCount; // 0x0
	private MapDispos.ActualDataList m_List; // 0x70
	private MapDispos.FlagField m_DisposFlag; // 0x78

	// Methods

	// RVA: 0x1D3B920 Offset: 0x1D3BA21 VA: 0x1D3B920
	public static void Create(ProcInst super, MapDispos.ActualDataList list, MapDispos.Flag disposFlag) { }

	// RVA: 0x1D3C310 Offset: 0x1D3C411 VA: 0x1D3C310
	public static bool IsExist() { }

	// RVA: 0x1D3C220 Offset: 0x1D3C321 VA: 0x1D3C220
	public void .ctor(MapDispos.ActualDataList list, MapDispos.Flag disposFlag) { }

	// RVA: 0x1D3C380 Offset: 0x1D3C481 VA: 0x1D3C380 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x1D3C4D0 Offset: 0x1D3C5D1 VA: 0x1D3C4D0
	private void Load() { }

	// RVA: 0x1D3C760 Offset: 0x1D3C861 VA: 0x1D3C760
	private void WaitLoad() { }

	// RVA: 0x1D3C8D0 Offset: 0x1D3C9D1 VA: 0x1D3C8D0
	private void Focus() { }

	// RVA: 0x1D3CB90 Offset: 0x1D3CC91 VA: 0x1D3CB90
	private void Dispos() { }

	// RVA: 0x1D3CFA0 Offset: 0x1D3D0A1 VA: 0x1D3CFA0
	private void WaitDispos() { }

	// RVA: 0x1D3BD30 Offset: 0x1D3BE31 VA: 0x1D3BD30
	private static bool InstantIfPossible(MapDispos.ActualDataList list, MapDispos.Flag disposFlag) { }

	// RVA: 0x1D3D110 Offset: 0x1D3D211 VA: 0x1D3D110
	private static bool CheckHide(MapDispos.ActualDataList list) { }

	// RVA: 0x1D3C9B0 Offset: 0x1D3CAB1 VA: 0x1D3C9B0
	private static bool CalcFocusPos(MapDispos.ActualDataList list, out int focusX, out int focusZ) { }

	// RVA: 0x1D3D260 Offset: 0x1D3D361 VA: 0x1D3D260
	private static void .cctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x277D00 Offset: 0x277E01 VA: 0x277D00
private sealed class MapDispos.<>c__DisplayClass15_0 // TypeDefIndex: 11960
{
	// Fields
	public MapEditData editData; // 0x10

	// Methods

	// RVA: 0x1D38A20 Offset: 0x1D38B21 VA: 0x1D38A20
	public void .ctor() { }

	// RVA: 0x1D38A30 Offset: 0x1D38B31 VA: 0x1D38A30
	internal void <CreateFirstVersusRanked>b__0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x277D10 Offset: 0x277E11 VA: 0x277D10
[Serializable]
private sealed class MapDispos.<>c // TypeDefIndex: 11961
{
	// Fields
	public static readonly MapDispos.<>c <>9; // 0x0
	public static Action<Unit> <>9__18_0; // 0x8
	public static Action<Unit> <>9__18_1; // 0x10
	public static Action<Unit> <>9__18_2; // 0x18
	public static Action<Unit> <>9__20_0; // 0x20
	public static Action<Unit> <>9__20_1; // 0x28
	public static Action<Unit> <>9__20_2; // 0x30
	public static Action<Unit> <>9__25_0; // 0x38
	public static Action<Unit> <>9__25_1; // 0x40
	public static Action<Unit> <>9__25_2; // 0x48
	public static Action<Unit> <>9__25_5; // 0x50
	public static Action<Unit> <>9__25_6; // 0x58

	// Methods

	// RVA: 0x1D385A0 Offset: 0x1D386A1 VA: 0x1D385A0
	private static void .cctor() { }

	// RVA: 0x1D38610 Offset: 0x1D38711 VA: 0x1D38610
	public void .ctor() { }

	// RVA: 0x1D38620 Offset: 0x1D38721 VA: 0x1D38620
	internal void <CreateVersusPlayerTeam>b__18_0(Unit unit) { }

	// RVA: 0x1D38640 Offset: 0x1D38741 VA: 0x1D38640
	internal void <CreateVersusPlayerTeam>b__18_1(Unit unit) { }

	// RVA: 0x1D38660 Offset: 0x1D38761 VA: 0x1D38660
	internal void <CreateVersusPlayerTeam>b__18_2(Unit unit) { }

	// RVA: 0x1D38690 Offset: 0x1D38791 VA: 0x1D38690
	internal void <CreateVersusEditTeam>b__20_0(Unit unit) { }

	// RVA: 0x1D386B0 Offset: 0x1D387B1 VA: 0x1D386B0
	internal void <CreateVersusEditTeam>b__20_1(Unit unit) { }

	// RVA: 0x1D38730 Offset: 0x1D38831 VA: 0x1D38730
	internal void <CreateVersusEditTeam>b__20_2(Unit unit) { }

	// RVA: 0x1D38760 Offset: 0x1D38861 VA: 0x1D38760
	internal void <CreatePlayerTeam>b__25_0(Unit unit) { }

	// RVA: 0x1D38880 Offset: 0x1D38981 VA: 0x1D38880
	internal void <CreatePlayerTeam>b__25_1(Unit unit) { }

	// RVA: 0x1D38950 Offset: 0x1D38A51 VA: 0x1D38950
	internal void <CreatePlayerTeam>b__25_2(Unit unit) { }

	// RVA: 0x1D389D0 Offset: 0x1D38AD1 VA: 0x1D389D0
	internal void <CreatePlayerTeam>b__25_5(Unit unit) { }

	// RVA: 0x1D389F0 Offset: 0x1D38AF1 VA: 0x1D389F0
	internal void <CreatePlayerTeam>b__25_6(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x277D20 Offset: 0x277E21 VA: 0x277D20
private sealed class MapDispos.<>c__DisplayClass20_0 // TypeDefIndex: 11962
{
	// Fields
	public Stack<MapDispos.Pos> posStack; // 0x10
	public MapEditData editData; // 0x18

	// Methods

	// RVA: 0x1D38B10 Offset: 0x1D38C11 VA: 0x1D38B10
	public void .ctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x277D30 Offset: 0x277E31 VA: 0x277D30
private sealed class MapDispos.<>c__DisplayClass20_1 // TypeDefIndex: 11963
{
	// Fields
	public int count; // 0x10
	public int sortieCount; // 0x14
	public MapDispos.<>c__DisplayClass20_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x1D38B20 Offset: 0x1D38C21 VA: 0x1D38B20
	public void .ctor() { }

	// RVA: 0x1D38B30 Offset: 0x1D38C31 VA: 0x1D38B30
	internal void <CreateVersusEditTeam>b__3(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x277D40 Offset: 0x277E41 VA: 0x277D40
private sealed class MapDispos.<>c__DisplayClass20_2 // TypeDefIndex: 11964
{
	// Fields
	public int count; // 0x10
	public int sortieCount; // 0x14
	public MapDispos.<>c__DisplayClass20_0 CS$<>8__locals2; // 0x18

	// Methods

	// RVA: 0x1D38BE0 Offset: 0x1D38CE1 VA: 0x1D38BE0
	public void .ctor() { }

	// RVA: 0x1D38BF0 Offset: 0x1D38CF1 VA: 0x1D38BF0
	internal void <CreateVersusEditTeam>b__4(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x277D50 Offset: 0x277E51 VA: 0x277D50
private sealed class MapDispos.<>c__DisplayClass25_0 // TypeDefIndex: 11965
{
	// Fields
	public MapDispos.PosList posList; // 0x10

	// Methods

	// RVA: 0x1D38CB0 Offset: 0x1D38DB1 VA: 0x1D38CB0
	public void .ctor() { }

	// RVA: 0x1D38CC0 Offset: 0x1D38DC1 VA: 0x1D38CC0
	internal void <CreatePlayerTeam>b__3(Unit unit) { }

	// RVA: 0x1D38E80 Offset: 0x1D38F81 VA: 0x1D38E80
	internal void <CreatePlayerTeam>b__4(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x277D60 Offset: 0x277E61 VA: 0x277D60
private sealed class MapDispos.<>c__DisplayClass37_0 // TypeDefIndex: 11966
{
	// Fields
	public int count; // 0x10

	// Methods

	// RVA: 0x1D38F60 Offset: 0x1D39061 VA: 0x1D38F60
	public void .ctor() { }

	// RVA: 0x1D38F70 Offset: 0x1D39071 VA: 0x1D38F70
	internal void <GetSortieLimit>b__0(Unit unit) { }

	// RVA: 0x1D39000 Offset: 0x1D39101 VA: 0x1D39000
	internal void <GetSortieLimit>b__1(Unit unit) { }
}

