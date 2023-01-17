// Namespace: 
public enum MapKillBonus.Kinds // TypeDefIndex: 12172
{
	// Fields
	public int value__; // 0x0
	public const MapKillBonus.Kinds None = 0;
	public const MapKillBonus.Kinds Kill = 1;
	public const MapKillBonus.Kinds Killed = 2;
	public const MapKillBonus.Kinds Max = 3;
}

// Namespace: 
public struct MapKillBonus.Work.Pos // TypeDefIndex: 12173
{
	// Fields
	public ushort x; // 0x0
	public ushort z; // 0x2
}

// Namespace: 
private struct MapKillBonus.Work // TypeDefIndex: 12174
{
	// Fields
	public MapKillBonus.Work.Pos[] positions; // 0x0
	public List<int> rates0; // 0x8
	public List<int> rates1; // 0x10
}

// Namespace: 
public class MapKillBonus.KindImage : MapImageCoreByte // TypeDefIndex: 12175
{
	// Methods

	// RVA: 0x240C740 Offset: 0x240C841 VA: 0x240C740
	public void SetKind(int index, MapKillBonus.Kinds kind) { }

	// RVA: 0x240C180 Offset: 0x240C281 VA: 0x240C180
	public void SetKind(int x, int z, MapKillBonus.Kinds kind) { }

	// RVA: 0x240C7B0 Offset: 0x240C8B1 VA: 0x240C7B0
	public MapKillBonus.Kinds GetKind(int index) { }

	// RVA: 0x240BA70 Offset: 0x240BB71 VA: 0x240BA70
	public MapKillBonus.Kinds GetKind(int x, int z) { }

	// RVA: 0x240C820 Offset: 0x240C921 VA: 0x240C820
	public void .ctor() { }
}

// Namespace: 
public class MapKillBonus.CountImage : MapImageCore<short> // TypeDefIndex: 12176
{
	// Methods

	// RVA: 0x240B530 Offset: 0x240B631 VA: 0x240B530 Slot: 5
	public override void Add(int index, short v) { }

	// RVA: 0x240B570 Offset: 0x240B671 VA: 0x240B570
	public void .ctor() { }
}

// Namespace: 
public struct MapKillBonus.KillBonus // TypeDefIndex: 12177
{
	// Fields
	public string iid; // 0x0

	// Methods

	// RVA: 0x240C430 Offset: 0x240C531 VA: 0x240C430
	public void Clear() { }

	// RVA: 0x240C440 Offset: 0x240C541 VA: 0x240C440
	public void Serialize(Stream stream) { }

	// RVA: 0x240C520 Offset: 0x240C621 VA: 0x240C520
	public void Deserialize(Stream stream, int version) { }
}

// Namespace: 
public struct MapKillBonus.KilledBonus // TypeDefIndex: 12178
{
	// Fields
	public KilledBonusData.Kinds kind; // 0x0
	public int value; // 0x4

	// Methods

	// RVA: 0x240C5F0 Offset: 0x240C6F1 VA: 0x240C5F0
	public void Clear() { }

	// RVA: 0x240C600 Offset: 0x240C701 VA: 0x240C600
	public void Serialize(Stream stream) { }

	// RVA: 0x240C640 Offset: 0x240C741 VA: 0x240C640
	public void Deserialize(Stream stream, int version) { }
}

// Namespace: 
private class MapKillBonus.DownloadSequence : ProcInst // TypeDefIndex: 12179
{
	// Fields
	private string m_Cid; // 0x70

	// Methods

	// RVA: 0x240B5D0 Offset: 0x240B6D1 VA: 0x240B5D0
	private void .ctor(string cid) { }

	// RVA: 0x240B610 Offset: 0x240B711 VA: 0x240B610
	private void Get() { }

	// RVA: 0x240B6A0 Offset: 0x240B7A1 VA: 0x240B6A0
	private void Setup() { }

	// RVA: 0x240B720 Offset: 0x240B821 VA: 0x240B720
	public static void CreateBind(ProcInst super, string cid) { }
}

// Namespace: 
private class MapKillBonus.GainSequence : ProcInst // TypeDefIndex: 12180
{
	// Fields
	private Unit m_Unit; // 0x70
	private MapKillBonus.Kinds m_Kind; // 0x78

	// Methods

	// RVA: 0x240B960 Offset: 0x240BA61 VA: 0x240B960
	private void .ctor(Unit unit) { }

	// RVA: 0x240BAF0 Offset: 0x240BBF1 VA: 0x240BAF0
	private void Gain() { }

	// RVA: 0x240BB10 Offset: 0x240BC11 VA: 0x240BB10
	private void GainKillBonus() { }

	// RVA: 0x240BC40 Offset: 0x240BD41 VA: 0x240BC40
	private void GainKilledBonus() { }

	// RVA: 0x240BF40 Offset: 0x240C041 VA: 0x240BF40
	private ref MapKillBonus.KilledBonus GetKilledBonus(Unit unit) { }

	// RVA: 0x240C010 Offset: 0x240C111 VA: 0x240C010
	private void Update() { }

	// RVA: 0x240C200 Offset: 0x240C301 VA: 0x240C200
	public static void CreateBind(ProcInst super, Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x277EA0 Offset: 0x277FA1 VA: 0x277EA0
private sealed class MapKillBonus.<>c__DisplayClass44_0 // TypeDefIndex: 12181
{
	// Fields
	public int[,,] netData; // 0x10
	public int netKind; // 0x18

	// Methods

	// RVA: 0x240B480 Offset: 0x240B581 VA: 0x240B480
	public void .ctor() { }

	// RVA: 0x240B490 Offset: 0x240B591 VA: 0x240B490
	internal int <DecideCells>b__0(MapKillBonus.Work.Pos a, MapKillBonus.Work.Pos b) { }
}

