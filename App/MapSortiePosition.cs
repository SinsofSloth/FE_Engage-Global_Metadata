// Namespace: App
public class MapSortiePosition : SingletonClass<MapSortiePosition> // TypeDefIndex: 12238
{
	// Fields
	private const int MaxCount = 48;
	private MapSortiePosition.Data[] m_Data; // 0x20
	private int m_DataCount; // 0x28

	// Properties
	public int Count { get; }
	protected override int Version { get; }

	// Methods

	// RVA: 0x2743000 Offset: 0x2743101 VA: 0x2743000
	public void .ctor() { }

	// RVA: 0x2743090 Offset: 0x2743191 VA: 0x2743090
	public void Prepare() { }

	// RVA: 0x27431D0 Offset: 0x27432D1 VA: 0x27431D0
	public void Cleanup() { }

	// RVA: 0x2743200 Offset: 0x2743301 VA: 0x2743200
	public bool Add(int x, int z, float angle = 0) { }

	// RVA: 0x27431C0 Offset: 0x27432C1 VA: 0x27431C0
	public void Reset() { }

	// RVA: 0x27433E0 Offset: 0x27434E1 VA: 0x27433E0
	public MapSortiePosition.Data Get(int index) { }

	// RVA: 0x2743420 Offset: 0x2743521 VA: 0x2743420
	public int GetIndex(int x, int z) { }

	// RVA: 0x27434A0 Offset: 0x27435A1 VA: 0x27434A0
	public int get_Count() { }

	// RVA: 0x27434B0 Offset: 0x27435B1 VA: 0x27434B0 Slot: 4
	protected override int get_Version() { }

	// RVA: 0x27434C0 Offset: 0x27435C1 VA: 0x27434C0 Slot: 11
	protected override void OnSerialize(Stream stream) { }

	// RVA: 0x27435B0 Offset: 0x27436B1 VA: 0x27435B0 Slot: 12
	protected override void OnDeserialize(Stream stream, int version) { }
}

