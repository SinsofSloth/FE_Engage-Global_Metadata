// Namespace: 
public enum MapMind.Type // TypeDefIndex: 12189
{
	// Fields
	public int value__; // 0x0
	public const MapMind.Type None = 0;
	public const MapMind.Type Fixed = 1;
	public const MapMind.Type Talk = 2;
	public const MapMind.Type Attack = 3;
	public const MapMind.Type EngageStart = 4;
	public const MapMind.Type EngageLink = 5;
	public const MapMind.Type EngageAttack = 6;
	public const MapMind.Type EngageRod = 7;
	public const MapMind.Type EngageRewarp = 8;
	public const MapMind.Type EngageCharge = 9;
	public const MapMind.Type Cannon = 10;
	public const MapMind.Type Destroy = 11;
	public const MapMind.Type Rod = 12;
	public const MapMind.Type ItemUse = 13;
	public const MapMind.Type Item = 14;
	public const MapMind.Type Trade = 15;
	public const MapMind.Type Visit = 16;
	public const MapMind.Type Breakdown = 17;
	public const MapMind.Type BreakdownEnemy = 18;
	public const MapMind.Type Escape = 19;
	public const MapMind.Type Breakthrough = 20;
	public const MapMind.Type Door = 21;
	public const MapMind.Type Torch = 22;
	public const MapMind.Type TreasureBox = 23;
	public const MapMind.Type Transporter = 24;
	public const MapMind.Type RodWarp = 25;
	public const MapMind.Type RodWarpDest = 26;
	public const MapMind.Type RodRewarp = 27;
	public const MapMind.Type RodRewarpDest = 28;
	public const MapMind.Type RodRescue = 29;
	public const MapMind.Type RodInterference = 30;
	public const MapMind.Type RodTorch = 31;
	public const MapMind.Type RodCreation = 32;
	public const MapMind.Type RodNodus = 33;
	public const MapMind.Type Dance = 34;
	public const MapMind.Type Guard = 35;
	public const MapMind.Type DragonVein = 36;
	public const MapMind.Type OverlapSkill = 37;
	public const MapMind.Type CommandSkill = 38;
	public const MapMind.Type VisionCreate = 39;
	public const MapMind.Type VisionDelete = 40;
	public const MapMind.Type GodChange = 41;
	public const MapMind.Type DestroyVillage = 42;
	public const MapMind.Type TurnEnd = 43;
	public const MapMind.Type Surrender = 44;
	public const MapMind.Type Informal = 45;
	public const MapMind.Type RodHeal = 46;
	public const MapMind.Type RodMagicShield = 47;
	public const MapMind.Type FullBullet = 48;
	public const MapMind.Type EngageWait = 49;
	public const MapMind.Type EngageSummon = 50;
	public const MapMind.Type ItemMenu = 51;
	public const MapMind.Type EnchantMenu = 52;
	public const MapMind.Type Enchant = 53;
	public const MapMind.Type Contract = 54;
	public const MapMind.Type SubMenu = 55;
}

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
public sealed class MapMind.DoneField : BitFieldTemplate32<MapMind.Done> // TypeDefIndex: 12191
{
	// Methods

	// RVA: 0x240D6A0 Offset: 0x240D7A1 VA: 0x240D6A0 Slot: 5
	protected override int ToInt(MapMind.Done value) { }

	// RVA: 0x240D6B0 Offset: 0x240D7B1 VA: 0x240D6B0
	public void .ctor() { }
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
internal struct MapMind.Record // TypeDefIndex: 12193
{
	// Fields
	public MapMind.Type type; // 0x0
	public MapMind.Record.Value main; // 0x8
	public MapMind.Record.Value link; // 0x28

	// Methods

	// RVA: 0x240D1F0 Offset: 0x240D2F1 VA: 0x240D1F0
	public void .ctor(MapMind.Type type, Unit unit, Unit link) { }

	// RVA: 0x240D480 Offset: 0x240D581 VA: 0x240D480
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
public struct MapMind.Target // TypeDefIndex: 12195
{
	// Fields
	public Unit Unit; // 0x0
	public TerrainData Terrain; // 0x8
	public sbyte X; // 0x10
	public sbyte Z; // 0x11

	// Properties
	public sbyte Value { get; set; }
	public Vector3 Position { get; }

	// Methods

	// RVA: 0x24106A0 Offset: 0x24107A1 VA: 0x24106A0
	public sbyte get_Value() { }

	// RVA: 0x24106B0 Offset: 0x24107B1 VA: 0x24106B0
	public void set_Value(sbyte value) { }

	// RVA: 0x240E480 Offset: 0x240E581 VA: 0x240E480
	public Vector3 get_Position() { }
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

