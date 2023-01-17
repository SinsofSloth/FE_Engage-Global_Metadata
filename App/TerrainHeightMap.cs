// Namespace: App
[DefaultMemberAttribute] // RVA: 0x274E20 Offset: 0x274F21 VA: 0x274E20
public class TerrainHeightMap : TerrainMap // TypeDefIndex: 9005
{
	// Fields
	private float[,] m_HeightMap; // 0x18

	// Properties
	public float Item { get; set; }

	// Methods

	// RVA: 0x25D5A30 Offset: 0x25D5B31 VA: 0x25D5A30
	public void .ctor() { }

	// RVA: 0x25D5A50 Offset: 0x25D5B51 VA: 0x25D5A50
	public void .ctor(Terrain terrain) { }

	// RVA: 0x25D5B80 Offset: 0x25D5C81 VA: 0x25D5B80
	public void .ctor(TerrainData data) { }

	// RVA: 0x25D5CD0 Offset: 0x25D5DD1 VA: 0x25D5CD0 Slot: 4
	protected override void ReadData(TerrainData data) { }

	// RVA: 0x25D5DE0 Offset: 0x25D5EE1 VA: 0x25D5DE0 Slot: 5
	protected override void WriteData(TerrainData data) { }

	// RVA: 0x25D5F30 Offset: 0x25D6031 VA: 0x25D5F30
	public void FillHeight(float height) { }

	// RVA: 0x25D5FC0 Offset: 0x25D60C1 VA: 0x25D5FC0
	public void MoveHeight(float height) { }

	// RVA: 0x25D6060 Offset: 0x25D6161 VA: 0x25D6060
	public float get_Item(int x, int y) { }

	// RVA: 0x25D60B0 Offset: 0x25D61B1 VA: 0x25D60B0
	public void set_Item(int x, int y, float value) { }
}

