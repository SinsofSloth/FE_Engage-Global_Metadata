// Namespace: App
public class MapImageRange // TypeDefIndex: 12113
{
	// Fields
	private const int Version = 1;
	private MapImageCoreBit m_Image; // 0x10
	private List<MapImageRange.Pos> m_Poss; // 0x18

	// Properties
	public int Count { get; }

	// Methods

	// RVA: 0x246C920 Offset: 0x246CA21 VA: 0x246C920
	public void Clear() { }

	// RVA: 0x246C990 Offset: 0x246CA91 VA: 0x246C990
	public void Add(int x, int z) { }

	// RVA: 0x246CA60 Offset: 0x246CB61 VA: 0x246CA60
	public void Delete(int x, int z) { }

	// RVA: 0x246CBC0 Offset: 0x246CCC1 VA: 0x246CBC0
	public bool Get(int x, int z) { }

	// RVA: 0x246CC00 Offset: 0x246CD01 VA: 0x246CC00
	public int get_Count() { }

	// RVA: 0x246CC50 Offset: 0x246CD51 VA: 0x246CC50
	public int GetX(int i) { }

	// RVA: 0x246CCC0 Offset: 0x246CDC1 VA: 0x246CCC0
	public int GetZ(int i) { }

	// RVA: 0x246CD30 Offset: 0x246CE31 VA: 0x246CD30
	public void Sort() { }

	// RVA: 0x246CE60 Offset: 0x246CF61 VA: 0x246CE60
	public void OpenFan(int startX, int startZ, int targetX, int targetZ, int angle) { }

	// RVA: 0x246CFF0 Offset: 0x246D0F1 VA: 0x246CFF0
	public void Serialize(Stream stream) { }

	// RVA: 0x246D100 Offset: 0x246D201 VA: 0x246D100
	public void Deserialize(Stream stream) { }

	// RVA: 0x246D300 Offset: 0x246D401 VA: 0x246D300
	public void .ctor() { }
}

