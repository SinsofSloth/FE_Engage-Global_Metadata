// Namespace: App
[ExecuteAlways] // RVA: 0x274E10 Offset: 0x274F11 VA: 0x274E10
public abstract class TerrainExporter : MonoBehaviour // TypeDefIndex: 8999
{
	// Fields
	[SerializeField] // RVA: 0x2857F0 Offset: 0x2858F1 VA: 0x2857F0
	[HideInInspector] // RVA: 0x2857F0 Offset: 0x2858F1 VA: 0x2857F0
	private Vector3 m_TerrainSize; // 0x18
	[SerializeField] // RVA: 0x285830 Offset: 0x285931 VA: 0x285830
	[HideInInspector] // RVA: 0x285830 Offset: 0x285931 VA: 0x285830
	private string m_OriginalTerrainGuid; // 0x28

	// Properties
	public TerrainData OriginalTerrainData { get; set; }
	public Vector3 TerrainSize { get; }

	// Methods

	// RVA: 0x25D59E0 Offset: 0x25D5AE1 VA: 0x25D59E0
	public TerrainData get_OriginalTerrainData() { }

	// RVA: 0x25D59F0 Offset: 0x25D5AF1 VA: 0x25D59F0
	public void set_OriginalTerrainData(TerrainData value) { }

	// RVA: 0x25D5A00 Offset: 0x25D5B01 VA: 0x25D5A00
	public Vector3 get_TerrainSize() { }

	// RVA: 0x25D5A10 Offset: 0x25D5B11 VA: 0x25D5A10
	protected void .ctor() { }
}

