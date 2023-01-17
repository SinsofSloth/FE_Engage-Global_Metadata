// Namespace: App
public class MapImage : SingletonClass<MapImage> // TypeDefIndex: 12098
{
	// Fields
	public const int MaxWidthBit = 5;
	public const int MaxHeightBit = 5;
	public const int MaxWidth = 32;
	public const int MaxHeight = 32;
	public const int MaxSize = 1024;
	public const int MaxOuter = 128;
	private string m_Name; // 0x20
	private MapImageUnit m_Unit; // 0x28
	private MapImageTerrain m_Terrain; // 0x30
	private MapImageCost m_Cost; // 0x38
	private MapImageDanger m_Danger; // 0x40
	private MapImageTalk m_Talk; // 0x48
	private MapImageRange m_Range; // 0x50
	private MapImageHistory m_History; // 0x58
	private List<MapImage.BackupTerrain> m_BackupTerrains; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x299AF0 Offset: 0x299BF1 VA: 0x299AF0
	private int <W>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x299B00 Offset: 0x299C01 VA: 0x299B00
	private int <H>k__BackingField; // 0x6C
	[CompilerGeneratedAttribute] // RVA: 0x299B10 Offset: 0x299C11 VA: 0x299B10
	private int <PlayAreaX>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x299B20 Offset: 0x299C21 VA: 0x299B20
	private int <PlayAreaZ>k__BackingField; // 0x74
	[CompilerGeneratedAttribute] // RVA: 0x299B30 Offset: 0x299C31 VA: 0x299B30
	private int <PlayAreaW>k__BackingField; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x299B40 Offset: 0x299C41 VA: 0x299B40
	private int <PlayAreaH>k__BackingField; // 0x7C
	[CompilerGeneratedAttribute] // RVA: 0x299B50 Offset: 0x299C51 VA: 0x299B50
	private int <X1>k__BackingField; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x299B60 Offset: 0x299C61 VA: 0x299B60
	private int <Z1>k__BackingField; // 0x84
	[CompilerGeneratedAttribute] // RVA: 0x299B70 Offset: 0x299C71 VA: 0x299B70
	private int <X2>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x299B80 Offset: 0x299C81 VA: 0x299B80
	private int <Z2>k__BackingField; // 0x8C
	[CompilerGeneratedAttribute] // RVA: 0x299B90 Offset: 0x299C91 VA: 0x299B90
	private int <PlayAreaX1>k__BackingField; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x299BA0 Offset: 0x299CA1 VA: 0x299BA0
	private int <PlayAreaZ1>k__BackingField; // 0x94
	[CompilerGeneratedAttribute] // RVA: 0x299BB0 Offset: 0x299CB1 VA: 0x299BB0
	private int <PlayAreaX2>k__BackingField; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x299BC0 Offset: 0x299CC1 VA: 0x299BC0
	private int <PlayAreaZ2>k__BackingField; // 0x9C

	// Properties
	protected override int Version { get; }
	public int X { get; }
	public int Z { get; }
	public int W { get; set; }
	public int H { get; set; }
	public int PlayAreaX { get; set; }
	public int PlayAreaZ { get; set; }
	public int PlayAreaW { get; set; }
	public int PlayAreaH { get; set; }
	public int X1 { get; set; }
	public int Z1 { get; set; }
	public int X2 { get; set; }
	public int Z2 { get; set; }
	public int PlayAreaX1 { get; set; }
	public int PlayAreaZ1 { get; set; }
	public int PlayAreaX2 { get; set; }
	public int PlayAreaZ2 { get; set; }
	public MapImageUnit Unit { get; }
	public MapImageTerrain Terrain { get; }
	public MapImageCost Cost { get; }
	public MapImageDanger Danger { get; }
	public MapImageTalk Talk { get; }
	public MapImageRange Range { get; }
	public MapImageHistory History { get; }
	public string Name { get; }

	// Methods

	// RVA: 0x21E01B0 Offset: 0x21E02B1 VA: 0x21E01B0
	public void .ctor() { }

	// RVA: 0x21E0420 Offset: 0x21E0521 VA: 0x21E0420
	private static TerrainData GetPutTerrain(string tid, bool nullable) { }

	// RVA: 0x21E0580 Offset: 0x21E0681 VA: 0x21E0580
	public void Setup(MapTerrain terrain, bool isResume = False) { }

	// RVA: 0x21E0D80 Offset: 0x21E0E81 VA: 0x21E0D80
	public void SetSize(int w, int h) { }

	// RVA: 0x21E0DC0 Offset: 0x21E0EC1 VA: 0x21E0DC0
	public bool IsOutOfMap(int x, int z) { }

	// RVA: 0x21E0DF0 Offset: 0x21E0EF1 VA: 0x21E0DF0
	public bool IsOutOfPlayArea(int x, int z) { }

	// RVA: 0x21E0E20 Offset: 0x21E0F21 VA: 0x21E0E20
	public bool CanTarget(int x, int z) { }

	// RVA: 0x21E0F40 Offset: 0x21E1041 VA: 0x21E0F40
	public bool CanTarget(int x, int z, Unit unit) { }

	// RVA: 0x21E1110 Offset: 0x21E1211 VA: 0x21E1110
	public bool CanTarget(int x, int z, bool isConsiderNotTarget) { }

	// RVA: 0x21E1230 Offset: 0x21E1331 VA: 0x21E1230 Slot: 4
	protected override int get_Version() { }

	// RVA: 0x21E1240 Offset: 0x21E1341 VA: 0x21E1240 Slot: 11
	protected override void OnSerialize(Stream stream) { }

	// RVA: 0x21E1750 Offset: 0x21E1851 VA: 0x21E1750 Slot: 12
	protected override void OnDeserialize(Stream stream, int version) { }

	// RVA: 0x21E1AD0 Offset: 0x21E1BD1 VA: 0x21E1AD0
	public int get_X() { }

	// RVA: 0x21E1AE0 Offset: 0x21E1BE1 VA: 0x21E1AE0
	public int get_Z() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C7A20 Offset: 0x2C7B21 VA: 0x2C7A20
	// RVA: 0x21E1AF0 Offset: 0x21E1BF1 VA: 0x21E1AF0
	public int get_W() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C7A30 Offset: 0x2C7B31 VA: 0x2C7A30
	// RVA: 0x21E1B00 Offset: 0x21E1C01 VA: 0x21E1B00
	private void set_W(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C7A40 Offset: 0x2C7B41 VA: 0x2C7A40
	// RVA: 0x21E1B10 Offset: 0x21E1C11 VA: 0x21E1B10
	public int get_H() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C7A50 Offset: 0x2C7B51 VA: 0x2C7A50
	// RVA: 0x21E1B20 Offset: 0x21E1C21 VA: 0x21E1B20
	private void set_H(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C7A60 Offset: 0x2C7B61 VA: 0x2C7A60
	// RVA: 0x21E1B30 Offset: 0x21E1C31 VA: 0x21E1B30
	public int get_PlayAreaX() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C7A70 Offset: 0x2C7B71 VA: 0x2C7A70
	// RVA: 0x21E1B40 Offset: 0x21E1C41 VA: 0x21E1B40
	private void set_PlayAreaX(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C7A80 Offset: 0x2C7B81 VA: 0x2C7A80
	// RVA: 0x21E1B50 Offset: 0x21E1C51 VA: 0x21E1B50
	public int get_PlayAreaZ() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C7A90 Offset: 0x2C7B91 VA: 0x2C7A90
	// RVA: 0x21E1B60 Offset: 0x21E1C61 VA: 0x21E1B60
	private void set_PlayAreaZ(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C7AA0 Offset: 0x2C7BA1 VA: 0x2C7AA0
	// RVA: 0x21E1B70 Offset: 0x21E1C71 VA: 0x21E1B70
	public int get_PlayAreaW() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C7AB0 Offset: 0x2C7BB1 VA: 0x2C7AB0
	// RVA: 0x21E1B80 Offset: 0x21E1C81 VA: 0x21E1B80
	private void set_PlayAreaW(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C7AC0 Offset: 0x2C7BC1 VA: 0x2C7AC0
	// RVA: 0x21E1B90 Offset: 0x21E1C91 VA: 0x21E1B90
	public int get_PlayAreaH() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C7AD0 Offset: 0x2C7BD1 VA: 0x2C7AD0
	// RVA: 0x21E1BA0 Offset: 0x21E1CA1 VA: 0x21E1BA0
	private void set_PlayAreaH(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C7AE0 Offset: 0x2C7BE1 VA: 0x2C7AE0
	// RVA: 0x21E1BB0 Offset: 0x21E1CB1 VA: 0x21E1BB0
	public int get_X1() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C7AF0 Offset: 0x2C7BF1 VA: 0x2C7AF0
	// RVA: 0x21E1BC0 Offset: 0x21E1CC1 VA: 0x21E1BC0
	private void set_X1(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C7B00 Offset: 0x2C7C01 VA: 0x2C7B00
	// RVA: 0x21E1BD0 Offset: 0x21E1CD1 VA: 0x21E1BD0
	public int get_Z1() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C7B10 Offset: 0x2C7C11 VA: 0x2C7B10
	// RVA: 0x21E1BE0 Offset: 0x21E1CE1 VA: 0x21E1BE0
	private void set_Z1(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C7B20 Offset: 0x2C7C21 VA: 0x2C7B20
	// RVA: 0x21E1BF0 Offset: 0x21E1CF1 VA: 0x21E1BF0
	public int get_X2() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C7B30 Offset: 0x2C7C31 VA: 0x2C7B30
	// RVA: 0x21E1C00 Offset: 0x21E1D01 VA: 0x21E1C00
	private void set_X2(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C7B40 Offset: 0x2C7C41 VA: 0x2C7B40
	// RVA: 0x21E1C10 Offset: 0x21E1D11 VA: 0x21E1C10
	public int get_Z2() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C7B50 Offset: 0x2C7C51 VA: 0x2C7B50
	// RVA: 0x21E1C20 Offset: 0x21E1D21 VA: 0x21E1C20
	private void set_Z2(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C7B60 Offset: 0x2C7C61 VA: 0x2C7B60
	// RVA: 0x21E1C30 Offset: 0x21E1D31 VA: 0x21E1C30
	public int get_PlayAreaX1() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C7B70 Offset: 0x2C7C71 VA: 0x2C7B70
	// RVA: 0x21E1C40 Offset: 0x21E1D41 VA: 0x21E1C40
	private void set_PlayAreaX1(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C7B80 Offset: 0x2C7C81 VA: 0x2C7B80
	// RVA: 0x21E1C50 Offset: 0x21E1D51 VA: 0x21E1C50
	public int get_PlayAreaZ1() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C7B90 Offset: 0x2C7C91 VA: 0x2C7B90
	// RVA: 0x21E1C60 Offset: 0x21E1D61 VA: 0x21E1C60
	private void set_PlayAreaZ1(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C7BA0 Offset: 0x2C7CA1 VA: 0x2C7BA0
	// RVA: 0x21E1C70 Offset: 0x21E1D71 VA: 0x21E1C70
	public int get_PlayAreaX2() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C7BB0 Offset: 0x2C7CB1 VA: 0x2C7BB0
	// RVA: 0x21E1C80 Offset: 0x21E1D81 VA: 0x21E1C80
	private void set_PlayAreaX2(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C7BC0 Offset: 0x2C7CC1 VA: 0x2C7BC0
	// RVA: 0x21E1C90 Offset: 0x21E1D91 VA: 0x21E1C90
	public int get_PlayAreaZ2() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C7BD0 Offset: 0x2C7CD1 VA: 0x2C7BD0
	// RVA: 0x21E1CA0 Offset: 0x21E1DA1 VA: 0x21E1CA0
	private void set_PlayAreaZ2(int value) { }

	// RVA: 0x21E1CB0 Offset: 0x21E1DB1 VA: 0x21E1CB0
	public MapImageUnit get_Unit() { }

	// RVA: 0x21E1CC0 Offset: 0x21E1DC1 VA: 0x21E1CC0
	public MapImageTerrain get_Terrain() { }

	// RVA: 0x21E1CD0 Offset: 0x21E1DD1 VA: 0x21E1CD0
	public MapImageCost get_Cost() { }

	// RVA: 0x21E1CE0 Offset: 0x21E1DE1 VA: 0x21E1CE0
	public MapImageDanger get_Danger() { }

	// RVA: 0x21E1CF0 Offset: 0x21E1DF1 VA: 0x21E1CF0
	public MapImageTalk get_Talk() { }

	// RVA: 0x21E1D00 Offset: 0x21E1E01 VA: 0x21E1D00
	public MapImageRange get_Range() { }

	// RVA: 0x21E1D10 Offset: 0x21E1E11 VA: 0x21E1D10
	public MapImageHistory get_History() { }

	// RVA: 0x21E1D20 Offset: 0x21E1E21 VA: 0x21E1D20
	public string get_Name() { }

	// RVA: 0x21E1D30 Offset: 0x21E1E31 VA: 0x21E1D30
	public Unit GetTargetUnit(int x, int z) { }

	// RVA: 0x21E1DE0 Offset: 0x21E1EE1 VA: 0x21E1DE0
	public Unit GetTargetUnit(int x, int z, bool allowAsphyxiation) { }

	// RVA: 0x21E1EC0 Offset: 0x21E1FC1 VA: 0x21E1EC0
	public int ClampX(int x) { }

	// RVA: 0x21E1EE0 Offset: 0x21E1FE1 VA: 0x21E1EE0
	public int ClampZ(int z) { }
}

