// Namespace: App
public class UnitPool // TypeDefIndex: 13537
{
	// Fields
	public const int UnitMax = 250;
	public const int MapForceUnitMax = 64;
	public const int GuestMax = 20;
	private const int Version = 0;
	private static Unit[] s_Units; // 0x0
	private static Force[] s_Forces; // 0x8

	// Methods

	// RVA: 0x20837C0 Offset: 0x20838C1 VA: 0x20837C0
	public static void Initialize() { }

	// RVA: 0x2083C00 Offset: 0x2083D01 VA: 0x2083C00
	public static void Reset() { }

	// RVA: 0x2083E10 Offset: 0x2083F11 VA: 0x2083E10
	public static int GetCount(uint forceMask) { }

	// RVA: 0x20841F0 Offset: 0x20842F1 VA: 0x20841F0
	public static Unit Get(int index) { }

	// RVA: 0x2084280 Offset: 0x2084381 VA: 0x2084280
	public static Unit GetDirect(int index) { }

	// RVA: 0x2084300 Offset: 0x2084401 VA: 0x2084300
	public static Unit GetFirst(uint forceMask, int startForceIndex = 0) { }

	// RVA: 0x2084440 Offset: 0x2084541 VA: 0x2084440
	public static Unit GetLast(uint forceMask, int startForceIndex = 7) { }

	// RVA: 0x20844F0 Offset: 0x20845F1 VA: 0x20844F0
	public static Unit GetHero(bool considerRelay = False) { }

	// RVA: 0x2084B40 Offset: 0x2084C41 VA: 0x2084B40
	public static Unit GetFromPerson(PersonData person, bool considerRelay = False) { }

	// RVA: 0x2085160 Offset: 0x2085261 VA: 0x2085160
	public static Unit TryGetFromPerson(string pid, bool considerRelay = False) { }

	// RVA: 0x2085210 Offset: 0x2085311 VA: 0x2085210
	public static Unit GetFromPerson(string pid, bool considerRelay = False) { }

	// RVA: 0x20852A0 Offset: 0x20853A1 VA: 0x20852A0
	public static Unit GetFromPerson(PersonData person, uint forceMask) { }

	// RVA: 0x2085560 Offset: 0x2085661 VA: 0x2085560
	public static Unit GetFromPerson(string pid, uint forceMask) { }

	// RVA: 0x20855F0 Offset: 0x20856F1 VA: 0x20855F0
	public static Unit GetFromFace(PersonData person, bool considerRelay = False) { }

	// RVA: 0x2085880 Offset: 0x2085981 VA: 0x2085880
	public static Unit GetFromFace(string pid, bool considerRelay = False) { }

	// RVA: 0x20843C0 Offset: 0x20844C1 VA: 0x20843C0
	public static Force GetForce(int index) { }

	// RVA: 0x2085910 Offset: 0x2085A11 VA: 0x2085910
	public static void Serialize(Stream stream, uint forceMask) { }

	// RVA: 0x2085A50 Offset: 0x2085B51 VA: 0x2085A50
	public static void Deserialize(Stream stream) { }

	// RVA: 0x2085DB0 Offset: 0x2085EB1 VA: 0x2085DB0
	public static void DeserializeForOnline(Stream stream) { }

	// RVA: 0x2085A60 Offset: 0x2085B61 VA: 0x2085A60
	private static void DeserializeImpl(Stream stream, bool isOnline) { }

	// RVA: 0x2085DC0 Offset: 0x2085EC1 VA: 0x2085DC0
	public static int CalcIdent(Unit unit) { }

	// RVA: 0x20860C0 Offset: 0x20861C1 VA: 0x20860C0
	public static Unit GetFromIdent(Force.Type force, int ident) { }

	// RVA: 0x20864A0 Offset: 0x20865A1 VA: 0x20864A0
	public static Unit GetEnemyIdent(Force.Type force, int ident) { }

	// RVA: 0x2086A40 Offset: 0x2086B41 VA: 0x2086A40
	public static void Dump() { }

	// RVA: 0x2086A50 Offset: 0x2086B51 VA: 0x2086A50
	public void .ctor() { }
}

