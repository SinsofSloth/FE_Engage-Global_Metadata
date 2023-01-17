// Namespace: App
[DefaultMemberAttribute] // RVA: 0x277EF0 Offset: 0x277FF1 VA: 0x277EF0
public class MapMaterial // TypeDefIndex: 12188
{
	// Fields
	private List<MapMaterial.Node> m_List; // 0x10

	// Properties
	public int Count { get; }
	public MapMaterial.Node Item { get; }

	// Methods

	// RVA: 0x220D490 Offset: 0x220D591 VA: 0x220D490
	public void .ctor() { }

	// RVA: 0x220D520 Offset: 0x220D621 VA: 0x220D520
	public MapMaterial.Node Find(MapMaterial.Kinds kind, string material, string property) { }

	// RVA: 0x220D680 Offset: 0x220D781 VA: 0x220D680
	public MapMaterial.Node TryAdd(MapMaterial.Kinds kind, string material, string property) { }

	// RVA: 0x220D760 Offset: 0x220D861 VA: 0x220D760
	public int get_Count() { }

	// RVA: 0x220D7B0 Offset: 0x220D8B1 VA: 0x220D7B0
	public MapMaterial.Node get_Item(int i) { }

	// RVA: 0x220D820 Offset: 0x220D921 VA: 0x220D820
	public IEnumerator<MapMaterial.Node> GetEnumerator() { }
}

