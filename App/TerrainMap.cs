// Namespace: App
public class TerrainMap // TypeDefIndex: 9004
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x285990 Offset: 0x285A91 VA: 0x285990
	private int <Width>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x2859A0 Offset: 0x285AA1 VA: 0x2859A0
	private int <Height>k__BackingField; // 0x14

	// Properties
	public int Width { get; set; }
	public int Height { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2ADDB0 Offset: 0x2ADEB1 VA: 0x2ADDB0
	// RVA: 0x25D7170 Offset: 0x25D7271 VA: 0x25D7170
	public int get_Width() { }

	[CompilerGeneratedAttribute] // RVA: 0x2ADDC0 Offset: 0x2ADEC1 VA: 0x2ADDC0
	// RVA: 0x25D7180 Offset: 0x25D7281 VA: 0x25D7180
	protected void set_Width(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2ADDD0 Offset: 0x2ADED1 VA: 0x2ADDD0
	// RVA: 0x25D7190 Offset: 0x25D7291 VA: 0x25D7190
	public int get_Height() { }

	[CompilerGeneratedAttribute] // RVA: 0x2ADDE0 Offset: 0x2ADEE1 VA: 0x2ADDE0
	// RVA: 0x25D71A0 Offset: 0x25D72A1 VA: 0x25D71A0
	protected void set_Height(int value) { }

	// RVA: 0x25D71B0 Offset: 0x25D72B1 VA: 0x25D71B0
	public bool IsInside(int x, int y) { }

	// RVA: 0x25D71E0 Offset: 0x25D72E1 VA: 0x25D71E0
	public bool IsOutside(int x, int y) { }

	// RVA: 0x25D5A80 Offset: 0x25D5B81 VA: 0x25D5A80
	public void Read(Terrain terrain) { }

	// RVA: 0x25D5C30 Offset: 0x25D5D31 VA: 0x25D5C30
	public void Read(TerrainData data) { }

	// RVA: 0x25D7210 Offset: 0x25D7311 VA: 0x25D7210
	public void Write(Terrain terrain) { }

	// RVA: 0x25D72C0 Offset: 0x25D73C1 VA: 0x25D72C0
	public void Write(TerrainData data) { }

	// RVA: 0x25D7360 Offset: 0x25D7461 VA: 0x25D7360 Slot: 4
	protected virtual void ReadData(TerrainData data) { }

	// RVA: 0x25D7370 Offset: 0x25D7471 VA: 0x25D7370 Slot: 5
	protected virtual void WriteData(TerrainData data) { }

	// RVA: 0x25D5A40 Offset: 0x25D5B41 VA: 0x25D5A40
	public void .ctor() { }
}

