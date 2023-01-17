// Namespace: App
public class AIValue // TypeDefIndex: 9465
{
	// Fields
	private const int Version = 0;
	private AIValue.UnionValue m_V; // 0x10

	// Properties
	public int X { get; }
	public int Z { get; }

	// Methods

	// RVA: 0x2B10700 Offset: 0x2B10801 VA: 0x2B10700
	public int get_X() { }

	// RVA: 0x2B10710 Offset: 0x2B10811 VA: 0x2B10710
	public int get_Z() { }

	// RVA: 0x2B10720 Offset: 0x2B10821 VA: 0x2B10720
	public int GetValue() { }

	// RVA: 0x2B10730 Offset: 0x2B10831 VA: 0x2B10730
	public void SetValue(short v) { }

	// RVA: 0x2B10740 Offset: 0x2B10841 VA: 0x2B10740
	public void SetPosition(byte x, byte z) { }

	// RVA: 0x2B10750 Offset: 0x2B10851 VA: 0x2B10750
	public PersonData GetPerson() { }

	// RVA: 0x2B10890 Offset: 0x2B10991 VA: 0x2B10890
	public JobData GetJob() { }

	// RVA: 0x2B10960 Offset: 0x2B10A61 VA: 0x2B10960
	public TerrainData GetTerrain() { }

	// RVA: 0x2B10A30 Offset: 0x2B10B31 VA: 0x2B10A30
	public ItemData GetItem() { }

	// RVA: 0x2B10B00 Offset: 0x2B10C01 VA: 0x2B10B00
	public List<AIData> GetAI() { }

	// RVA: 0x2B10BD0 Offset: 0x2B10CD1 VA: 0x2B10BD0
	public string GetAIName() { }

	// RVA: 0x2B10C40 Offset: 0x2B10D41 VA: 0x2B10C40
	public bool IsValidFlagValue() { }

	// RVA: 0x2B10C50 Offset: 0x2B10D51 VA: 0x2B10C50
	public int GetFlagValue() { }

	// RVA: 0x2B10D80 Offset: 0x2B10E81 VA: 0x2B10D80
	public string SetValue(string str) { }

	// RVA: 0x2B116E0 Offset: 0x2B117E1 VA: 0x2B116E0
	public bool IsSignal() { }

	// RVA: 0x2B116F0 Offset: 0x2B117F1 VA: 0x2B116F0
	public bool IsDefault() { }

	// RVA: 0x2B11700 Offset: 0x2B11801 VA: 0x2B11700
	public bool IsMax() { }

	// RVA: 0x2B11710 Offset: 0x2B11811 VA: 0x2B11710
	public bool IsSkip() { }

	// RVA: 0x2B11720 Offset: 0x2B11821 VA: 0x2B11720
	public bool IsArgument() { }

	// RVA: 0x2B11740 Offset: 0x2B11841 VA: 0x2B11740
	public AIValue GetArgument(AIValue.Order order, Unit unit) { }

	// RVA: 0x2B11760 Offset: 0x2B11861 VA: 0x2B11760
	public void Serialize(Stream stream) { }

	// RVA: 0x2B117A0 Offset: 0x2B118A1 VA: 0x2B117A0
	public void Deserialize(Stream stream) { }

	// RVA: 0x2B10820 Offset: 0x2B10921 VA: 0x2B10820
	private string GetString() { }

	// RVA: 0x2B11420 Offset: 0x2B11521 VA: 0x2B11420
	public static void ParseCoord(string str, ref int index, out int x, out int z) { }

	// RVA: 0x2B115C0 Offset: 0x2B116C1 VA: 0x2B115C0
	public static void ParseNumber(string str, ref int index, out int number) { }

	// RVA: 0x2B119D0 Offset: 0x2B11AD1 VA: 0x2B119D0
	public static int SkipSpace(string str, int index) { }

	// RVA: 0x2B11A40 Offset: 0x2B11B41 VA: 0x2B11A40
	private static bool IsNumber(char c) { }

	// RVA: 0x2B11A60 Offset: 0x2B11B61 VA: 0x2B11A60
	public void .ctor() { }
}

