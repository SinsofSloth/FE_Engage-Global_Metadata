// Namespace: 
public enum GameUserRestartData.Targtes // TypeDefIndex: 13620
{
	// Fields
	public int value__; // 0x0
	public const GameUserRestartData.Targtes Chapter = 0;
	public const GameUserRestartData.Targtes Sortie = 1;
	public const GameUserRestartData.Targtes Num = 2;
	public const GameUserRestartData.Targtes None = -1;
}

// Namespace: 
public class GameUserRestartData.RecordWriter : Dictionary<string, int> // TypeDefIndex: 13622
{
	// Methods

	// RVA: 0x22EB090 Offset: 0x22EB191 VA: 0x22EB090
	public void Read(UnitRecord.Kinds kind) { }

	// RVA: 0x22EB2F0 Offset: 0x22EB3F1 VA: 0x22EB2F0
	public void Write(UnitRecord.Kinds kind) { }

	// RVA: 0x22EB550 Offset: 0x22EB651 VA: 0x22EB550
	public void .ctor() { }
}

// Namespace: 
public class GameUserRestartData.Growth // TypeDefIndex: 13624
{
	// Fields
	public JobData Job; // 0x10
	public int Level; // 0x18
	public int Exp; // 0x1C
	public Capability GrowCapability; // 0x20
	public UnitBaseCapability LevelCapability; // 0x28

	// Methods

	// RVA: 0x22EA630 Offset: 0x22EA731 VA: 0x22EA630
	public void .ctor() { }
}

// Namespace: 
public class GameUserRestartData.CompleteWriter // TypeDefIndex: 13626
{
	// Fields
	private ChapterData m_Chapter; // 0x10
	private List<ChapterRecord.Record> m_Records; // 0x18
	private int[] m_Encounters; // 0x20

	// Methods

	// RVA: 0x22E9F30 Offset: 0x22EA031 VA: 0x22E9F30
	public void Read() { }

	// RVA: 0x22EA110 Offset: 0x22EA211 VA: 0x22EA110
	public void Write() { }

	// RVA: 0x22EA430 Offset: 0x22EA531 VA: 0x22EA430
	public void .ctor() { }
}

