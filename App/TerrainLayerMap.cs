// Namespace: App
[DefaultMemberAttribute] // RVA: 0x274E60 Offset: 0x274F61 VA: 0x274E60
public class TerrainLayerMap : TerrainMap // TypeDefIndex: 9006
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x2859B0 Offset: 0x285AB1 VA: 0x2859B0
	private int <Count>k__BackingField; // 0x18
	private float[,,] m_AlphaMaps; // 0x20

	// Properties
	public int Count { get; set; }
	public float Item { get; set; }

	// Methods

	// RVA: 0x25D6120 Offset: 0x25D6221 VA: 0x25D6120
	public void .ctor() { }

	// RVA: 0x25D6130 Offset: 0x25D6231 VA: 0x25D6130
	public void .ctor(Terrain terrain) { }

	// RVA: 0x25D6160 Offset: 0x25D6261 VA: 0x25D6160
	public void .ctor(TerrainData data) { }

	// RVA: 0x25D6210 Offset: 0x25D6311 VA: 0x25D6210
	public void .ctor(int width, int height, int layers) { }

	// RVA: 0x25D62C0 Offset: 0x25D63C1 VA: 0x25D62C0 Slot: 4
	protected override void ReadData(TerrainData data) { }

	// RVA: 0x25D6360 Offset: 0x25D6461 VA: 0x25D6360 Slot: 5
	protected override void WriteData(TerrainData data) { }

	// RVA: 0x25D6380 Offset: 0x25D6481 VA: 0x25D6380
	private int GetCurrentLayer(int x, int y) { }

	// RVA: 0x25D6430 Offset: 0x25D6531 VA: 0x25D6430
	private float GetMaxAlpha(int x, int y) { }

	// RVA: 0x25D64F0 Offset: 0x25D65F1 VA: 0x25D64F0
	public void Normalize() { }

	// RVA: 0x25D6630 Offset: 0x25D6731 VA: 0x25D6630
	public void Normalize(int layer) { }

	// RVA: 0x25D6930 Offset: 0x25D6A31 VA: 0x25D6930
	public void FillLayer(int layer) { }

	// RVA: 0x25D6A80 Offset: 0x25D6B81 VA: 0x25D6A80
	public void SlopLayer(TerrainData data, int layer) { }

	// RVA: 0x25D6C30 Offset: 0x25D6D31 VA: 0x25D6C30
	public void ClearLayer(int layer) { }

	// RVA: 0x25D6CE0 Offset: 0x25D6DE1 VA: 0x25D6CE0
	public void UpdateSoft() { }

	// RVA: 0x25D6D30 Offset: 0x25D6E31 VA: 0x25D6D30
	public void UpdateSoft(int layer) { }

	[CompilerGeneratedAttribute] // RVA: 0x2ADDF0 Offset: 0x2ADEF1 VA: 0x2ADDF0
	// RVA: 0x25D7070 Offset: 0x25D7171 VA: 0x25D7070
	public int get_Count() { }

	[CompilerGeneratedAttribute] // RVA: 0x2ADE00 Offset: 0x2ADF01 VA: 0x2ADE00
	// RVA: 0x25D7080 Offset: 0x25D7181 VA: 0x25D7080
	public void set_Count(int value) { }

	// RVA: 0x25D7090 Offset: 0x25D7191 VA: 0x25D7090
	public float get_Item(int x, int y, int layer) { }

	// RVA: 0x25D7100 Offset: 0x25D7201 VA: 0x25D7100
	public void set_Item(int x, int y, int layer, float value) { }
}

