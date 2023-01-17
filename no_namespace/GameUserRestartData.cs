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
public class GameUserRestartData.VariableWriter : Dictionary<string, int> // TypeDefIndex: 13621
{
	// Methods

	// RVA: 0x22EC230 Offset: 0x22EC331 VA: 0x22EC230
	public void Read(bool isNetwork = False) { }

	// RVA: 0x22EC600 Offset: 0x22EC701 VA: 0x22EC600
	public void Read(string header) { }

	// RVA: 0x22EC310 Offset: 0x22EC411 VA: 0x22EC310
	public void Write() { }

	// RVA: 0x22EC1D0 Offset: 0x22EC2D1 VA: 0x22EC1D0
	public void .ctor() { }
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
public class GameUserRestartData.GameConfigWriter : Stream // TypeDefIndex: 13623
{
	// Methods

	// RVA: 0x22EA500 Offset: 0x22EA601 VA: 0x22EA500
	public void .ctor() { }

	// RVA: 0x22EA510 Offset: 0x22EA611 VA: 0x22EA510
	public void Read() { }

	// RVA: 0x22EA5A0 Offset: 0x22EA6A1 VA: 0x22EA5A0
	public void Write() { }
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
public class GameUserRestartData.GrowthWriter : Dictionary<string, GameUserRestartData.Growth> // TypeDefIndex: 13625
{
	// Methods

	// RVA: 0x22EA6F0 Offset: 0x22EA7F1 VA: 0x22EA6F0
	public void Read() { }

	// RVA: 0x22EA9E0 Offset: 0x22EAAE1 VA: 0x22EA9E0
	public void Write() { }

	// RVA: 0x22EB030 Offset: 0x22EB131 VA: 0x22EB030
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

// Namespace: 
public class GameUserRestartData.RestartStream : Stream // TypeDefIndex: 13627
{
	// Fields
	public const int Version = 3;
	public const int MaxSize = 2097152;
	public const int MagicNumber = 539035145;

	// Methods

	// RVA: 0x22EB5B0 Offset: 0x22EB6B1 VA: 0x22EB5B0
	public void .ctor() { }

	// RVA: 0x22EB5C0 Offset: 0x22EB6C1 VA: 0x22EB5C0
	public ChapterData TryReadHeader() { }

	// RVA: 0x22EB750 Offset: 0x22EB851 VA: 0x22EB750
	public bool IsEnable() { }

	// RVA: 0x22EB770 Offset: 0x22EB871 VA: 0x22EB770
	public void Save() { }

	// RVA: 0x22EBA60 Offset: 0x22EBB61 VA: 0x22EBA60
	public bool Load(bool keepLevel, bool keepAchieve, bool completed) { }
}

