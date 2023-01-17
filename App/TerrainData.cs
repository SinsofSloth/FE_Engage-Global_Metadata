// Namespace: App
[DebuggerDisplayAttribute] // RVA: 0x276690 Offset: 0x276791 VA: 0x276690
public class TerrainData : StructData<TerrainData> // TypeDefIndex: 10102
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x28D650 Offset: 0x28D751 VA: 0x28D650
	private string <Tid>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x28D660 Offset: 0x28D761 VA: 0x28D660
	private string <Name>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x28D670 Offset: 0x28D771 VA: 0x28D670
	private string <CostName>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x28D680 Offset: 0x28D781 VA: 0x28D680
	private int <CostType>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x28D690 Offset: 0x28D791 VA: 0x28D690
	private TerrainData.Layers <Layer>k__BackingField; // 0x3C
	[CompilerGeneratedAttribute] // RVA: 0x28D6A0 Offset: 0x28D7A1 VA: 0x28D6A0
	private TerrainData.Prohibitions <Prohibition>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x28D6B0 Offset: 0x28D7B1 VA: 0x28D6B0
	private TerrainData.Commands <Command>k__BackingField; // 0x44
	[CompilerGeneratedAttribute] // RVA: 0x28D6C0 Offset: 0x28D7C1 VA: 0x28D6C0
	private byte <Sight>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x28D6D0 Offset: 0x28D7D1 VA: 0x28D6D0
	private TerrainData.Destroyers <Destroyer>k__BackingField; // 0x4C
	[CompilerGeneratedAttribute] // RVA: 0x28D6E0 Offset: 0x28D7E1 VA: 0x28D6E0
	private int <Hp_N>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x28D6F0 Offset: 0x28D7F1 VA: 0x28D6F0
	private int <Hp_H>k__BackingField; // 0x54
	[CompilerGeneratedAttribute] // RVA: 0x28D700 Offset: 0x28D801 VA: 0x28D700
	private int <Hp_L>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x28D710 Offset: 0x28D811 VA: 0x28D710
	private sbyte <Defense>k__BackingField; // 0x5C
	[CompilerGeneratedAttribute] // RVA: 0x28D720 Offset: 0x28D821 VA: 0x28D720
	private sbyte <Avoid>k__BackingField; // 0x5D
	[CompilerGeneratedAttribute] // RVA: 0x28D730 Offset: 0x28D831 VA: 0x28D730
	private sbyte <PlayerDefense>k__BackingField; // 0x5E
	[CompilerGeneratedAttribute] // RVA: 0x28D740 Offset: 0x28D841 VA: 0x28D740
	private sbyte <EnemyDefense>k__BackingField; // 0x5F
	[CompilerGeneratedAttribute] // RVA: 0x28D750 Offset: 0x28D851 VA: 0x28D750
	private sbyte <PlayerAvoid>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x28D760 Offset: 0x28D861 VA: 0x28D760
	private sbyte <EnemyAvoid>k__BackingField; // 0x61
	[CompilerGeneratedAttribute] // RVA: 0x28D770 Offset: 0x28D871 VA: 0x28D770
	private sbyte <Heal>k__BackingField; // 0x62
	[CompilerGeneratedAttribute] // RVA: 0x28D780 Offset: 0x28D881 VA: 0x28D780
	private byte <Life>k__BackingField; // 0x63
	[CompilerGeneratedAttribute] // RVA: 0x28D790 Offset: 0x28D891 VA: 0x28D790
	private byte <MoveCost>k__BackingField; // 0x64
	[CompilerGeneratedAttribute] // RVA: 0x28D7A0 Offset: 0x28D8A1 VA: 0x28D7A0
	private byte <FlyCost>k__BackingField; // 0x65
	[CompilerGeneratedAttribute] // RVA: 0x28D7B0 Offset: 0x28D8B1 VA: 0x28D7B0
	private sbyte <MoveFirst>k__BackingField; // 0x66
	[CompilerGeneratedAttribute] // RVA: 0x28D7C0 Offset: 0x28D8C1 VA: 0x28D7C0
	private float <Offset>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x28D7D0 Offset: 0x28D8D1 VA: 0x28D7D0
	private byte <ColorR>k__BackingField; // 0x6C
	[CompilerGeneratedAttribute] // RVA: 0x28D7E0 Offset: 0x28D8E1 VA: 0x28D7E0
	private byte <ColorG>k__BackingField; // 0x6D
	[CompilerGeneratedAttribute] // RVA: 0x28D7F0 Offset: 0x28D8F1 VA: 0x28D7F0
	private byte <ColorB>k__BackingField; // 0x6E
	[CompilerGeneratedAttribute] // RVA: 0x28D800 Offset: 0x28D901 VA: 0x28D800
	private Color <Color>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x28D810 Offset: 0x28D911 VA: 0x28D810
	private string <ChangeTid>k__BackingField; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x28D820 Offset: 0x28D921 VA: 0x28D820
	private string <ChangeEncount>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x28D830 Offset: 0x28D931 VA: 0x28D830
	private float <Height>k__BackingField; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x28D840 Offset: 0x28D941 VA: 0x28D840
	private string <PutEffect>k__BackingField; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x28D850 Offset: 0x28D951 VA: 0x28D850
	private string <Minimap>k__BackingField; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x28D860 Offset: 0x28D961 VA: 0x28D860
	private string <CannonSkill>k__BackingField; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x28D870 Offset: 0x28D971 VA: 0x28D870
	private byte <CannonShellsN>k__BackingField; // 0xB0
	[CompilerGeneratedAttribute] // RVA: 0x28D880 Offset: 0x28D981 VA: 0x28D880
	private byte <CannonShellsH>k__BackingField; // 0xB1
	[CompilerGeneratedAttribute] // RVA: 0x28D890 Offset: 0x28D991 VA: 0x28D890
	private byte <CannonShellsL>k__BackingField; // 0xB2
	[CompilerGeneratedAttribute] // RVA: 0x28D8A0 Offset: 0x28D9A1 VA: 0x28D8A0
	private TerrainData.Flags <Flag>k__BackingField; // 0xB4
	[CompilerGeneratedAttribute] // RVA: 0x28D8B0 Offset: 0x28D9B1 VA: 0x28D8B0
	private byte <PutAllow>k__BackingField; // 0xB8
	[CompilerGeneratedAttribute] // RVA: 0x28D8C0 Offset: 0x28D9C1 VA: 0x28D8C0
	private string <AsciiName>k__BackingField; // 0xC0

	// Properties
	public string Tid { get; set; }
	public string Name { get; set; }
	public string CostName { get; set; }
	public int CostType { get; set; }
	public TerrainData.Layers Layer { get; set; }
	public TerrainData.Prohibitions Prohibition { get; set; }
	public TerrainData.Commands Command { get; set; }
	public byte Sight { get; set; }
	public TerrainData.Destroyers Destroyer { get; set; }
	public int Hp_N { get; set; }
	public int Hp_H { get; set; }
	public int Hp_L { get; set; }
	public sbyte Defense { get; set; }
	public sbyte Avoid { get; set; }
	public sbyte PlayerDefense { get; set; }
	public sbyte EnemyDefense { get; set; }
	public sbyte PlayerAvoid { get; set; }
	public sbyte EnemyAvoid { get; set; }
	public sbyte Heal { get; set; }
	public byte Life { get; set; }
	public byte MoveCost { get; set; }
	public byte FlyCost { get; set; }
	public sbyte MoveFirst { get; set; }
	public float Offset { get; set; }
	public byte ColorR { get; set; }
	public byte ColorG { get; set; }
	public byte ColorB { get; set; }
	public Color Color { get; set; }
	public string ChangeTid { get; set; }
	public string ChangeEncount { get; set; }
	public float Height { get; set; }
	public string PutEffect { get; set; }
	public string Minimap { get; set; }
	public string CannonSkill { get; set; }
	public byte CannonShellsN { get; set; }
	public byte CannonShellsH { get; set; }
	public byte CannonShellsL { get; set; }
	public TerrainData.Flags Flag { get; set; }
	public byte PutAllow { get; set; }
	public string AsciiName { get; set; }

	// Methods

	// RVA: 0x25D49E0 Offset: 0x25D4AE1 VA: 0x25D49E0
	public static void Load() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCB50 Offset: 0x2BCC51 VA: 0x2BCB50
	// RVA: 0x25D4A90 Offset: 0x25D4B91 VA: 0x25D4A90
	public string get_Tid() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCB60 Offset: 0x2BCC61 VA: 0x2BCB60
	// RVA: 0x25D4AA0 Offset: 0x25D4BA1 VA: 0x25D4AA0
	private void set_Tid(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCB70 Offset: 0x2BCC71 VA: 0x2BCB70
	// RVA: 0x25D4AB0 Offset: 0x25D4BB1 VA: 0x25D4AB0
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCB80 Offset: 0x2BCC81 VA: 0x2BCB80
	// RVA: 0x25D4AC0 Offset: 0x25D4BC1 VA: 0x25D4AC0
	private void set_Name(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCB90 Offset: 0x2BCC91 VA: 0x2BCB90
	// RVA: 0x25D4AD0 Offset: 0x25D4BD1 VA: 0x25D4AD0
	public string get_CostName() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCBA0 Offset: 0x2BCCA1 VA: 0x2BCBA0
	// RVA: 0x25D4AE0 Offset: 0x25D4BE1 VA: 0x25D4AE0
	private void set_CostName(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCBB0 Offset: 0x2BCCB1 VA: 0x2BCBB0
	// RVA: 0x25D4AF0 Offset: 0x25D4BF1 VA: 0x25D4AF0
	public int get_CostType() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCBC0 Offset: 0x2BCCC1 VA: 0x2BCBC0
	// RVA: 0x25D4B00 Offset: 0x25D4C01 VA: 0x25D4B00
	private void set_CostType(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCBD0 Offset: 0x2BCCD1 VA: 0x2BCBD0
	// RVA: 0x25D4B10 Offset: 0x25D4C11 VA: 0x25D4B10
	public TerrainData.Layers get_Layer() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCBE0 Offset: 0x2BCCE1 VA: 0x2BCBE0
	// RVA: 0x25D4B20 Offset: 0x25D4C21 VA: 0x25D4B20
	private void set_Layer(TerrainData.Layers value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCBF0 Offset: 0x2BCCF1 VA: 0x2BCBF0
	// RVA: 0x25D4B30 Offset: 0x25D4C31 VA: 0x25D4B30
	public TerrainData.Prohibitions get_Prohibition() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCC00 Offset: 0x2BCD01 VA: 0x2BCC00
	// RVA: 0x25D4B40 Offset: 0x25D4C41 VA: 0x25D4B40
	private void set_Prohibition(TerrainData.Prohibitions value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCC10 Offset: 0x2BCD11 VA: 0x2BCC10
	// RVA: 0x25D4B50 Offset: 0x25D4C51 VA: 0x25D4B50
	public TerrainData.Commands get_Command() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCC20 Offset: 0x2BCD21 VA: 0x2BCC20
	// RVA: 0x25D4B60 Offset: 0x25D4C61 VA: 0x25D4B60
	private void set_Command(TerrainData.Commands value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCC30 Offset: 0x2BCD31 VA: 0x2BCC30
	// RVA: 0x25D4B70 Offset: 0x25D4C71 VA: 0x25D4B70
	public byte get_Sight() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCC40 Offset: 0x2BCD41 VA: 0x2BCC40
	// RVA: 0x25D4B80 Offset: 0x25D4C81 VA: 0x25D4B80
	private void set_Sight(byte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCC50 Offset: 0x2BCD51 VA: 0x2BCC50
	// RVA: 0x25D4B90 Offset: 0x25D4C91 VA: 0x25D4B90
	public TerrainData.Destroyers get_Destroyer() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCC60 Offset: 0x2BCD61 VA: 0x2BCC60
	// RVA: 0x25D4BA0 Offset: 0x25D4CA1 VA: 0x25D4BA0
	private void set_Destroyer(TerrainData.Destroyers value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCC70 Offset: 0x2BCD71 VA: 0x2BCC70
	// RVA: 0x25D4BB0 Offset: 0x25D4CB1 VA: 0x25D4BB0
	public int get_Hp_N() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCC80 Offset: 0x2BCD81 VA: 0x2BCC80
	// RVA: 0x25D4BC0 Offset: 0x25D4CC1 VA: 0x25D4BC0
	private void set_Hp_N(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCC90 Offset: 0x2BCD91 VA: 0x2BCC90
	// RVA: 0x25D4BD0 Offset: 0x25D4CD1 VA: 0x25D4BD0
	public int get_Hp_H() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCCA0 Offset: 0x2BCDA1 VA: 0x2BCCA0
	// RVA: 0x25D4BE0 Offset: 0x25D4CE1 VA: 0x25D4BE0
	private void set_Hp_H(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCCB0 Offset: 0x2BCDB1 VA: 0x2BCCB0
	// RVA: 0x25D4BF0 Offset: 0x25D4CF1 VA: 0x25D4BF0
	public int get_Hp_L() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCCC0 Offset: 0x2BCDC1 VA: 0x2BCCC0
	// RVA: 0x25D4C00 Offset: 0x25D4D01 VA: 0x25D4C00
	private void set_Hp_L(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCCD0 Offset: 0x2BCDD1 VA: 0x2BCCD0
	// RVA: 0x25D4C10 Offset: 0x25D4D11 VA: 0x25D4C10
	public sbyte get_Defense() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCCE0 Offset: 0x2BCDE1 VA: 0x2BCCE0
	// RVA: 0x25D4C20 Offset: 0x25D4D21 VA: 0x25D4C20
	private void set_Defense(sbyte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCCF0 Offset: 0x2BCDF1 VA: 0x2BCCF0
	// RVA: 0x25D4C30 Offset: 0x25D4D31 VA: 0x25D4C30
	public sbyte get_Avoid() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCD00 Offset: 0x2BCE01 VA: 0x2BCD00
	// RVA: 0x25D4C40 Offset: 0x25D4D41 VA: 0x25D4C40
	private void set_Avoid(sbyte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCD10 Offset: 0x2BCE11 VA: 0x2BCD10
	// RVA: 0x25D4C50 Offset: 0x25D4D51 VA: 0x25D4C50
	public sbyte get_PlayerDefense() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCD20 Offset: 0x2BCE21 VA: 0x2BCD20
	// RVA: 0x25D4C60 Offset: 0x25D4D61 VA: 0x25D4C60
	private void set_PlayerDefense(sbyte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCD30 Offset: 0x2BCE31 VA: 0x2BCD30
	// RVA: 0x25D4C70 Offset: 0x25D4D71 VA: 0x25D4C70
	public sbyte get_EnemyDefense() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCD40 Offset: 0x2BCE41 VA: 0x2BCD40
	// RVA: 0x25D4C80 Offset: 0x25D4D81 VA: 0x25D4C80
	private void set_EnemyDefense(sbyte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCD50 Offset: 0x2BCE51 VA: 0x2BCD50
	// RVA: 0x25D4C90 Offset: 0x25D4D91 VA: 0x25D4C90
	public sbyte get_PlayerAvoid() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCD60 Offset: 0x2BCE61 VA: 0x2BCD60
	// RVA: 0x25D4CA0 Offset: 0x25D4DA1 VA: 0x25D4CA0
	private void set_PlayerAvoid(sbyte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCD70 Offset: 0x2BCE71 VA: 0x2BCD70
	// RVA: 0x25D4CB0 Offset: 0x25D4DB1 VA: 0x25D4CB0
	public sbyte get_EnemyAvoid() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCD80 Offset: 0x2BCE81 VA: 0x2BCD80
	// RVA: 0x25D4CC0 Offset: 0x25D4DC1 VA: 0x25D4CC0
	private void set_EnemyAvoid(sbyte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCD90 Offset: 0x2BCE91 VA: 0x2BCD90
	// RVA: 0x25D4CD0 Offset: 0x25D4DD1 VA: 0x25D4CD0
	public sbyte get_Heal() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCDA0 Offset: 0x2BCEA1 VA: 0x2BCDA0
	// RVA: 0x25D4CE0 Offset: 0x25D4DE1 VA: 0x25D4CE0
	private void set_Heal(sbyte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCDB0 Offset: 0x2BCEB1 VA: 0x2BCDB0
	// RVA: 0x25D4CF0 Offset: 0x25D4DF1 VA: 0x25D4CF0
	public byte get_Life() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCDC0 Offset: 0x2BCEC1 VA: 0x2BCDC0
	// RVA: 0x25D4D00 Offset: 0x25D4E01 VA: 0x25D4D00
	private void set_Life(byte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCDD0 Offset: 0x2BCED1 VA: 0x2BCDD0
	// RVA: 0x25D4D10 Offset: 0x25D4E11 VA: 0x25D4D10
	public byte get_MoveCost() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCDE0 Offset: 0x2BCEE1 VA: 0x2BCDE0
	// RVA: 0x25D4D20 Offset: 0x25D4E21 VA: 0x25D4D20
	private void set_MoveCost(byte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCDF0 Offset: 0x2BCEF1 VA: 0x2BCDF0
	// RVA: 0x25D4D30 Offset: 0x25D4E31 VA: 0x25D4D30
	public byte get_FlyCost() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCE00 Offset: 0x2BCF01 VA: 0x2BCE00
	// RVA: 0x25D4D40 Offset: 0x25D4E41 VA: 0x25D4D40
	private void set_FlyCost(byte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCE10 Offset: 0x2BCF11 VA: 0x2BCE10
	// RVA: 0x25D4D50 Offset: 0x25D4E51 VA: 0x25D4D50
	public sbyte get_MoveFirst() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCE20 Offset: 0x2BCF21 VA: 0x2BCE20
	// RVA: 0x25D4D60 Offset: 0x25D4E61 VA: 0x25D4D60
	private void set_MoveFirst(sbyte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCE30 Offset: 0x2BCF31 VA: 0x2BCE30
	// RVA: 0x25D4D70 Offset: 0x25D4E71 VA: 0x25D4D70
	public float get_Offset() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCE40 Offset: 0x2BCF41 VA: 0x2BCE40
	// RVA: 0x25D4D80 Offset: 0x25D4E81 VA: 0x25D4D80
	private void set_Offset(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCE50 Offset: 0x2BCF51 VA: 0x2BCE50
	// RVA: 0x25D4D90 Offset: 0x25D4E91 VA: 0x25D4D90
	public byte get_ColorR() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCE60 Offset: 0x2BCF61 VA: 0x2BCE60
	// RVA: 0x25D4DA0 Offset: 0x25D4EA1 VA: 0x25D4DA0
	private void set_ColorR(byte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCE70 Offset: 0x2BCF71 VA: 0x2BCE70
	// RVA: 0x25D4DB0 Offset: 0x25D4EB1 VA: 0x25D4DB0
	public byte get_ColorG() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCE80 Offset: 0x2BCF81 VA: 0x2BCE80
	// RVA: 0x25D4DC0 Offset: 0x25D4EC1 VA: 0x25D4DC0
	private void set_ColorG(byte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCE90 Offset: 0x2BCF91 VA: 0x2BCE90
	// RVA: 0x25D4DD0 Offset: 0x25D4ED1 VA: 0x25D4DD0
	public byte get_ColorB() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCEA0 Offset: 0x2BCFA1 VA: 0x2BCEA0
	// RVA: 0x25D4DE0 Offset: 0x25D4EE1 VA: 0x25D4DE0
	private void set_ColorB(byte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCEB0 Offset: 0x2BCFB1 VA: 0x2BCEB0
	// RVA: 0x25D4DF0 Offset: 0x25D4EF1 VA: 0x25D4DF0
	public Color get_Color() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCEC0 Offset: 0x2BCFC1 VA: 0x2BCEC0
	// RVA: 0x25D4E00 Offset: 0x25D4F01 VA: 0x25D4E00
	private void set_Color(Color value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCED0 Offset: 0x2BCFD1 VA: 0x2BCED0
	// RVA: 0x25D4E20 Offset: 0x25D4F21 VA: 0x25D4E20
	public string get_ChangeTid() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCEE0 Offset: 0x2BCFE1 VA: 0x2BCEE0
	// RVA: 0x25D4E30 Offset: 0x25D4F31 VA: 0x25D4E30
	private void set_ChangeTid(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCEF0 Offset: 0x2BCFF1 VA: 0x2BCEF0
	// RVA: 0x25D4E40 Offset: 0x25D4F41 VA: 0x25D4E40
	public string get_ChangeEncount() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCF00 Offset: 0x2BD001 VA: 0x2BCF00
	// RVA: 0x25D4E50 Offset: 0x25D4F51 VA: 0x25D4E50
	private void set_ChangeEncount(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCF10 Offset: 0x2BD011 VA: 0x2BCF10
	// RVA: 0x25D4E60 Offset: 0x25D4F61 VA: 0x25D4E60
	public float get_Height() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCF20 Offset: 0x2BD021 VA: 0x2BCF20
	// RVA: 0x25D4E70 Offset: 0x25D4F71 VA: 0x25D4E70
	private void set_Height(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCF30 Offset: 0x2BD031 VA: 0x2BCF30
	// RVA: 0x25D4E80 Offset: 0x25D4F81 VA: 0x25D4E80
	public string get_PutEffect() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCF40 Offset: 0x2BD041 VA: 0x2BCF40
	// RVA: 0x25D4E90 Offset: 0x25D4F91 VA: 0x25D4E90
	private void set_PutEffect(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCF50 Offset: 0x2BD051 VA: 0x2BCF50
	// RVA: 0x25D4EA0 Offset: 0x25D4FA1 VA: 0x25D4EA0
	public string get_Minimap() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCF60 Offset: 0x2BD061 VA: 0x2BCF60
	// RVA: 0x25D4EB0 Offset: 0x25D4FB1 VA: 0x25D4EB0
	private void set_Minimap(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCF70 Offset: 0x2BD071 VA: 0x2BCF70
	// RVA: 0x25D4EC0 Offset: 0x25D4FC1 VA: 0x25D4EC0
	public string get_CannonSkill() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCF80 Offset: 0x2BD081 VA: 0x2BCF80
	// RVA: 0x25D4ED0 Offset: 0x25D4FD1 VA: 0x25D4ED0
	private void set_CannonSkill(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCF90 Offset: 0x2BD091 VA: 0x2BCF90
	// RVA: 0x25D4EE0 Offset: 0x25D4FE1 VA: 0x25D4EE0
	public byte get_CannonShellsN() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCFA0 Offset: 0x2BD0A1 VA: 0x2BCFA0
	// RVA: 0x25D4EF0 Offset: 0x25D4FF1 VA: 0x25D4EF0
	private void set_CannonShellsN(byte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCFB0 Offset: 0x2BD0B1 VA: 0x2BCFB0
	// RVA: 0x25D4F00 Offset: 0x25D5001 VA: 0x25D4F00
	public byte get_CannonShellsH() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCFC0 Offset: 0x2BD0C1 VA: 0x2BCFC0
	// RVA: 0x25D4F10 Offset: 0x25D5011 VA: 0x25D4F10
	private void set_CannonShellsH(byte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCFD0 Offset: 0x2BD0D1 VA: 0x2BCFD0
	// RVA: 0x25D4F20 Offset: 0x25D5021 VA: 0x25D4F20
	public byte get_CannonShellsL() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCFE0 Offset: 0x2BD0E1 VA: 0x2BCFE0
	// RVA: 0x25D4F30 Offset: 0x25D5031 VA: 0x25D4F30
	private void set_CannonShellsL(byte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BCFF0 Offset: 0x2BD0F1 VA: 0x2BCFF0
	// RVA: 0x25D4F40 Offset: 0x25D5041 VA: 0x25D4F40
	public TerrainData.Flags get_Flag() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD000 Offset: 0x2BD101 VA: 0x2BD000
	// RVA: 0x25D4F50 Offset: 0x25D5051 VA: 0x25D4F50
	private void set_Flag(TerrainData.Flags value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD010 Offset: 0x2BD111 VA: 0x2BD010
	// RVA: 0x25D4F60 Offset: 0x25D5061 VA: 0x25D4F60
	public byte get_PutAllow() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD020 Offset: 0x2BD121 VA: 0x2BD020
	// RVA: 0x25D4F70 Offset: 0x25D5071 VA: 0x25D4F70
	private void set_PutAllow(byte value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD030 Offset: 0x2BD131 VA: 0x2BD030
	// RVA: 0x25D4F80 Offset: 0x25D5081 VA: 0x25D4F80
	public string get_AsciiName() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD040 Offset: 0x2BD141 VA: 0x2BD040
	// RVA: 0x25D4F90 Offset: 0x25D5091 VA: 0x25D4F90
	private void set_AsciiName(string value) { }

	// RVA: 0x25D4FA0 Offset: 0x25D50A1 VA: 0x25D4FA0
	public bool IsDoor() { }

	// RVA: 0x25D4FB0 Offset: 0x25D50B1 VA: 0x25D4FB0
	public bool IsTreasure() { }

	// RVA: 0x25D4FC0 Offset: 0x25D50C1 VA: 0x25D4FC0
	public bool IsVisit() { }

	// RVA: 0x25D4FD0 Offset: 0x25D50D1 VA: 0x25D4FD0
	public bool IsBowCannon() { }

	// RVA: 0x25D4FE0 Offset: 0x25D50E1 VA: 0x25D4FE0
	public bool IsMagicCannon() { }

	// RVA: 0x25D4FF0 Offset: 0x25D50F1 VA: 0x25D4FF0
	public bool IsFireCannon() { }

	// RVA: 0x25D5000 Offset: 0x25D5101 VA: 0x25D5000
	public bool IsNotShadow() { }

	// RVA: 0x25D5010 Offset: 0x25D5111 VA: 0x25D5010
	public bool IsFootSmoke() { }

	// RVA: 0x25D5020 Offset: 0x25D5121 VA: 0x25D5020
	public bool IsFootprint() { }

	// RVA: 0x25D5030 Offset: 0x25D5131 VA: 0x25D5030
	public bool IsRoof() { }

	// RVA: 0x25D5040 Offset: 0x25D5141 VA: 0x25D5040
	public bool IsSightMasking() { }

	// RVA: 0x25D5050 Offset: 0x25D5151 VA: 0x25D5050
	public bool IsTorch() { }

	// RVA: 0x25D5070 Offset: 0x25D5171 VA: 0x25D5070
	public bool IsCannon() { }

	// RVA: 0x25D5080 Offset: 0x25D5181 VA: 0x25D5080
	public bool IsNotStun() { }

	// RVA: 0x25D5090 Offset: 0x25D5191 VA: 0x25D5090
	public bool IsNotEngageAdd() { }

	// RVA: 0x25D50A0 Offset: 0x25D51A1 VA: 0x25D50A0
	public bool IsFlyEnable() { }

	// RVA: 0x25D50B0 Offset: 0x25D51B1 VA: 0x25D50B0
	public bool IsHelpSpot() { }

	// RVA: 0x25D50C0 Offset: 0x25D51C1 VA: 0x25D50C0
	public bool IsEngageHeal() { }

	// RVA: 0x25D50D0 Offset: 0x25D51D1 VA: 0x25D50D0
	public bool IsNotTarget() { }

	// RVA: 0x25D50F0 Offset: 0x25D51F1 VA: 0x25D50F0
	public bool IsNotWarp() { }

	// RVA: 0x25D5110 Offset: 0x25D5211 VA: 0x25D5110
	public bool IsHideBreakIcon() { }

	// RVA: 0x25D5120 Offset: 0x25D5221 VA: 0x25D5120
	public bool IsShowPhaseIcon() { }

	// RVA: 0x25D5130 Offset: 0x25D5231 VA: 0x25D5130
	public bool IsImmobile() { }

	// RVA: 0x25D5140 Offset: 0x25D5241 VA: 0x25D5140
	public bool IsDamageHalfDisplay() { }

	// RVA: 0x25D5150 Offset: 0x25D5251 VA: 0x25D5150
	public string GetName() { }

	// RVA: 0x25D51C0 Offset: 0x25D52C1 VA: 0x25D51C0
	public bool IsFlightOnly() { }

	// RVA: 0x25D5220 Offset: 0x25D5321 VA: 0x25D5220
	public bool IsBreakable() { }

	// RVA: 0x25D5240 Offset: 0x25D5341 VA: 0x25D5240
	public bool CanPutAllow(int costType) { }

	// RVA: 0x25D5250 Offset: 0x25D5351 VA: 0x25D5250
	public bool CanPutAllow() { }

	// RVA: 0x25D5260 Offset: 0x25D5361 VA: 0x25D5260
	public bool CanBreakable(Force.Type force) { }

	// RVA: 0x25D52B0 Offset: 0x25D53B1 VA: 0x25D52B0
	public int GetHP() { }

	// RVA: 0x25D5480 Offset: 0x25D5581 VA: 0x25D5480
	public bool CanUnitCommand(Unit unit) { }

	// RVA: 0x25D54E0 Offset: 0x25D55E1 VA: 0x25D54E0
	public SkillData GetCannonSkill() { }

	// RVA: 0x25D5580 Offset: 0x25D5681 VA: 0x25D5580
	public int GetCannonShells() { }

	// RVA: 0x25D5750 Offset: 0x25D5851 VA: 0x25D5750 Slot: 4
	public override void OnBuild() { }

	// RVA: 0x25D57C0 Offset: 0x25D58C1 VA: 0x25D57C0 Slot: 5
	public override void OnCompleted() { }

	// RVA: 0x25D5930 Offset: 0x25D5A31 VA: 0x25D5930 Slot: 8
	public override string GetDebugName() { }

	// RVA: 0x25D5940 Offset: 0x25D5A41 VA: 0x25D5940
	public void .ctor() { }
}

