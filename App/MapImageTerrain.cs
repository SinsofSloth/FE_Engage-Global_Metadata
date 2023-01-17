// Namespace: App
public class MapImageTerrain // TypeDefIndex: 12117
{
	// Fields
	private MapImageCoreByte m_Original; // 0x10
	private MapImageCoreByte m_Base; // 0x18
	private MapImageCoreByte m_Result; // 0x20
	private List<MapImageTerrain.MinimapInfo> m_MinimapInfos; // 0x28
	private List<MapImageTerrain.MinimapInfo> m_MinimapBuffer; // 0x30

	// Properties
	public MapImageCoreByte Original { get; }
	public MapImageCoreByte Base { get; }
	public List<MapImageTerrain.MinimapInfo> MinimapInfos { get; }

	// Methods

	// RVA: 0x246F9C0 Offset: 0x246FAC1 VA: 0x246F9C0
	public void .ctor() { }

	// RVA: 0x246FC40 Offset: 0x246FD41 VA: 0x246FC40
	public void Clear() { }

	// RVA: 0x246FCD0 Offset: 0x246FDD1 VA: 0x246FCD0
	public MapImageCoreByte get_Original() { }

	// RVA: 0x246FCE0 Offset: 0x246FDE1 VA: 0x246FCE0
	public MapImageCoreByte get_Base() { }

	// RVA: 0x246FCF0 Offset: 0x246FDF1 VA: 0x246FCF0
	public List<MapImageTerrain.MinimapInfo> get_MinimapInfos() { }

	// RVA: 0x246FD00 Offset: 0x246FE01 VA: 0x246FD00
	public void Update() { }

	// RVA: 0x2470040 Offset: 0x2470141 VA: 0x2470040
	private void UpdateMinimap() { }

	// RVA: 0x24703B0 Offset: 0x24704B1 VA: 0x24703B0
	public void UpdateForEvent() { }

	// RVA: 0x2470770 Offset: 0x2470871 VA: 0x2470770
	public byte Get(int x, int z) { }

	// RVA: 0x24707F0 Offset: 0x24708F1 VA: 0x24707F0
	public TerrainData GetData(int x, int z) { }

	// RVA: 0x24708C0 Offset: 0x24709C1 VA: 0x24708C0 Slot: 2
	public override int GetHashCode() { }
}

