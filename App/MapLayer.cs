// Namespace: App
[DefaultMemberAttribute] // RVA: 0x277EB0 Offset: 0x277FB1 VA: 0x277EB0
public class MapLayer : SingletonClass<MapLayer> // TypeDefIndex: 12185
{
	// Fields
	private MapLayer.List m_List; // 0x20

	// Properties
	public int Count { get; }
	public MapLayer.Data Item { get; }
	protected override int Version { get; }

	// Methods

	// RVA: 0x220C800 Offset: 0x220C901 VA: 0x220C800
	public int get_Count() { }

	// RVA: 0x220C850 Offset: 0x220C951 VA: 0x220C850
	public MapLayer.Data get_Item(int i) { }

	// RVA: 0x220C8C0 Offset: 0x220C9C1 VA: 0x220C8C0
	public void Clear() { }

	// RVA: 0x220C920 Offset: 0x220CA21 VA: 0x220C920
	public void Add(MapLayer.Data data) { }

	// RVA: 0x220C980 Offset: 0x220CA81 VA: 0x220C980
	public void Add(int x, int z, int w, int h, int group, string tid, bool enable = True) { }

	// RVA: 0x220CAC0 Offset: 0x220CBC1 VA: 0x220CAC0
	public void SetEnable(int x, int z, bool enable) { }

	// RVA: 0x220CC60 Offset: 0x220CD61 VA: 0x220CC60
	public void SetEnable(int group, bool enable) { }

	// RVA: 0x22018D0 Offset: 0x22019D1 VA: 0x22018D0
	public MapLayer.Data Find(int x, int z) { }

	// RVA: 0x220CD40 Offset: 0x220CE41 VA: 0x220CD40 Slot: 4
	protected override int get_Version() { }

	// RVA: 0x220CD50 Offset: 0x220CE51 VA: 0x220CD50 Slot: 11
	protected override void OnSerialize(Stream stream) { }

	// RVA: 0x220CE80 Offset: 0x220CF81 VA: 0x220CE80 Slot: 12
	protected override void OnDeserialize(Stream stream, int version) { }

	// RVA: 0x220D390 Offset: 0x220D491 VA: 0x220D390
	public void .ctor() { }
}

