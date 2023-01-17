// Namespace: App
public class MapOverlap : SingletonClass<MapOverlap> // TypeDefIndex: 12202
{
	// Fields
	public const int MaxCount = 128;
	private MapImageCoreByte m_Image; // 0x20
	private MapOverlap.List m_List; // 0x28

	// Properties
	protected override int Version { get; }

	// Methods

	// RVA: 0x2216910 Offset: 0x2216A11 VA: 0x2216910
	private MapOverlap.Data SetImpl(int x, int z, TerrainData terrain, int turn, Force.Type phase, bool create) { }

	// RVA: 0x2216C60 Offset: 0x2216D61 VA: 0x2216C60
	private bool RemoveImpl(int x, int z) { }

	// RVA: 0x2216D30 Offset: 0x2216E31 VA: 0x2216D30
	private bool RemoveImpl(int i) { }

	// RVA: 0x2216E00 Offset: 0x2216F01 VA: 0x2216E00
	private void ClearImpl() { }

	// RVA: 0x2216E40 Offset: 0x2216F41 VA: 0x2216E40
	private void CreateEffectImpl() { }

	// RVA: 0x2216E50 Offset: 0x2216F51 VA: 0x2216E50
	private void UpdateEffectImpl() { }

	// RVA: 0x2216E60 Offset: 0x2216F61 VA: 0x2216E60
	public static int Get(int x, int z) { }

	// RVA: 0x2216F30 Offset: 0x2217031 VA: 0x2216F30
	public static int GetCount() { }

	// RVA: 0x2216FB0 Offset: 0x22170B1 VA: 0x2216FB0
	public static TerrainData GetTerrain(int i) { }

	// RVA: 0x2217090 Offset: 0x2217191 VA: 0x2217090
	public static TerrainData GetTerrain(int x, int z) { }

	// RVA: 0x22171A0 Offset: 0x22172A1 VA: 0x22171A0
	public static int GetX(int i) { }

	// RVA: 0x2217240 Offset: 0x2217341 VA: 0x2217240
	public static int GetZ(int i) { }

	// RVA: 0x22172E0 Offset: 0x22173E1 VA: 0x22172E0
	public static MapOverlap.Data GetData(int i) { }

	// RVA: 0x2203710 Offset: 0x2203811 VA: 0x2203710
	public static MapOverlap.Data GetData(int x, int z) { }

	// RVA: 0x2217370 Offset: 0x2217471 VA: 0x2217370
	public static int GetMoveCost(int x, int z) { }

	// RVA: 0x2217390 Offset: 0x2217491 VA: 0x2217390
	public static int GetFlyCost(int x, int z) { }

	// RVA: 0x22173B0 Offset: 0x22174B1 VA: 0x22173B0
	public static bool Set(int x, int z, int index, int turn = -1, Force.Type phase = 7) { }

	// RVA: 0x2206340 Offset: 0x2206441 VA: 0x2206340
	public static bool Set(int x, int z, string tid, int turn = -1, Force.Type phase = 7) { }

	// RVA: 0x22174E0 Offset: 0x22175E1 VA: 0x22174E0
	public static bool Set(int x, int z, TerrainData terrain, int turn = -1, Force.Type phase = 7) { }

	// RVA: 0x22175B0 Offset: 0x22176B1 VA: 0x22175B0
	public static bool Remove(int x, int z) { }

	// RVA: 0x2217640 Offset: 0x2217741 VA: 0x2217640
	public static bool Remove(int i) { }

	// RVA: 0x2217760 Offset: 0x2217861 VA: 0x2217760
	public static void Clear() { }

	// RVA: 0x2217800 Offset: 0x2217901 VA: 0x2217800
	public static void CreateEffect() { }

	// RVA: 0x2217880 Offset: 0x2217981 VA: 0x2217880
	public static void UpdateEffect() { }

	// RVA: 0x2206290 Offset: 0x2206391 VA: 0x2206290
	public static bool CanCreation(Unit attacker, int x, int z, string tid) { }

	// RVA: 0x2217C80 Offset: 0x2217D81 VA: 0x2217C80
	public static bool CanCreation(Unit attacker, int x, int z, int index) { }

	// RVA: 0x2217900 Offset: 0x2217A01 VA: 0x2217900
	public static bool CanCreation(Unit attacker, int x, int z, TerrainData data) { }

	// RVA: 0x2217D30 Offset: 0x2217E31 VA: 0x2217D30
	public static bool CanRemove(Unit attacker, int x, int z) { }

	// RVA: 0x2217E30 Offset: 0x2217F31 VA: 0x2217E30
	public static MapOverlap.Data FindBreakable(int x, int z) { }

	// RVA: 0x2218070 Offset: 0x2218171 VA: 0x2218070 Slot: 4
	protected override int get_Version() { }

	// RVA: 0x2218080 Offset: 0x2218181 VA: 0x2218080 Slot: 11
	protected override void OnSerialize(Stream stream) { }

	// RVA: 0x22181F0 Offset: 0x22182F1 VA: 0x22181F0 Slot: 12
	protected override void OnDeserialize(Stream stream, int version) { }

	// RVA: 0x22187E0 Offset: 0x22188E1 VA: 0x22187E0
	public void .ctor() { }
}

