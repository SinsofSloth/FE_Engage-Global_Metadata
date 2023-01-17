// Namespace: 
[FlagsAttribute] // RVA: 0x277F30 Offset: 0x278031 VA: 0x277F30
public enum MapMind.Done // TypeDefIndex: 12190
{
	// Fields
	public int value__; // 0x0
	public const MapMind.Done Talk = 1;
	public const MapMind.Done Trade = 2;
	public const MapMind.Done Putoff = 4;
	public const MapMind.Done Transporter = 8;
	public const MapMind.Done Action = 16;
	public const MapMind.Done Sight = 32;
}

// Namespace: 
public struct MapMind.Record.Value // TypeDefIndex: 12192
{
	// Fields
	public Unit unit; // 0x0
	public int x; // 0x8
	public int z; // 0xC
	public bool isChanged; // 0x10
	public int engageCount; // 0x14
	public UnitItem unitItem; // 0x18

	// Methods

	// RVA: 0x21E5B90 Offset: 0x21E5C91 VA: 0x21E5B90
	public void .ctor(Unit unit) { }

	// RVA: 0x21E5D60 Offset: 0x21E5E61 VA: 0x21E5D60
	public void Cancel() { }
}

// Namespace: 
public class MapMind.CommandStack // TypeDefIndex: 12194
{
	// Fields
	private Stack<MapMind.Record> m_Statck; // 0x10

	// Properties
	public bool Exist { get; }

	// Methods

	// RVA: 0x240CEA0 Offset: 0x240CFA1 VA: 0x240CEA0
	public MapMind.Type Peek() { }

	// RVA: 0x240CF30 Offset: 0x240D031 VA: 0x240CF30
	public void Push(MapMind.Type type, Unit unit, Unit link) { }

	// RVA: 0x240D2B0 Offset: 0x240D3B1 VA: 0x240D2B0
	public bool Pop() { }

	// RVA: 0x240D4B0 Offset: 0x240D5B1 VA: 0x240D4B0
	public void Decide() { }

	// RVA: 0x240D560 Offset: 0x240D661 VA: 0x240D560
	public void Clear() { }

	// RVA: 0x240D5C0 Offset: 0x240D6C1 VA: 0x240D5C0
	public bool get_Exist() { }

	// RVA: 0x240D290 Offset: 0x240D391 VA: 0x240D290
	private void TryAddAchieveEngage(MapMind.Type type, Unit unit) { }

	// RVA: 0x240D610 Offset: 0x240D711 VA: 0x240D610
	public void .ctor() { }
}

// Namespace: 
public class MapMind.MultiTargets : List<MapMind.Target> // TypeDefIndex: 12196
{
	// Methods

	// RVA: 0x240D710 Offset: 0x240D811 VA: 0x240D710
	public void .ctor() { }

	// RVA: 0x240D7A0 Offset: 0x240D8A1 VA: 0x240D7A0
	public bool Exists(Unit unit) { }

	// RVA: 0x240D860 Offset: 0x240D961 VA: 0x240D860
	public int IndexOf(Unit unit) { }

	// RVA: 0x240D920 Offset: 0x240DA21 VA: 0x240D920
	public int IndexOf(TerrainData terrain) { }

	// RVA: 0x240D9E0 Offset: 0x240DAE1 VA: 0x240D9E0
	public int IndexOf(int x, int z) { }

	// RVA: 0x240DAD0 Offset: 0x240DBD1 VA: 0x240DAD0
	public void Add(Unit unit) { }

	// RVA: 0x240DAF0 Offset: 0x240DBF1 VA: 0x240DAF0
	public void Add(int x, int z, Unit unit) { }

	// RVA: 0x240DD50 Offset: 0x240DE51 VA: 0x240DD50
	public void Add(int x, int z, string tid) { }

	// RVA: 0x240DE00 Offset: 0x240DF01 VA: 0x240DE00
	public void Add(int x, int z, TerrainData terrain) { }

	// RVA: 0x240DFF0 Offset: 0x240E0F1 VA: 0x240DFF0
	public void Add(Unit unit, int value) { }

	// RVA: 0x240E120 Offset: 0x240E221 VA: 0x240E120
	public void Add(int x, int z) { }

	// RVA: 0x240E270 Offset: 0x240E371 VA: 0x240E270
	public void Remove(Unit unit) { }

	// RVA: 0x240E370 Offset: 0x240E471 VA: 0x240E370
	public Vector3 GetCneter() { }

	// RVA: 0x24105F0 Offset: 0x24106F1 VA: 0x24105F0
	public int GetUnitCount() { }
}

