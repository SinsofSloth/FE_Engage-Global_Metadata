// Namespace: App
public class EncountMob // TypeDefIndex: 10255
{
	// Fields
	private string m_EJid; // 0x10
	private GmapSpot.EncountPersonType m_Type; // 0x18
	private byte m_Rank; // 0x1C
	private byte m_Cycle; // 0x1D
	private byte m_PlayerDispos; // 0x1E
	private byte m_EnemyDispos; // 0x1F
	private RandomSeed m_Seed; // 0x20
	private EncountUnitData.RareType m_RareType; // 0x30
	private byte m_ExpRareCount; // 0x34
	private byte m_GoldRareCount; // 0x35
	private string m_LeaderJid; // 0x38
	private byte m_LeaderGender; // 0x40
	private const int Version = 4;

	// Properties
	public int Rank { get; set; }
	private int LeaderRank { get; }
	public int Cycle { get; set; }
	public int PlayerDispos { get; set; }
	public int EnemyDispos { get; set; }
	public RandomSeed Seed { get; }
	public EncountUnitData.RareType RareType { get; }
	private int ExpRareCount { set; }
	private int GoldRareCount { set; }
	private Gender LeaderGender { get; set; }

	// Methods

	// RVA: 0x25F8DD0 Offset: 0x25F8ED1 VA: 0x25F8DD0
	public void .ctor() { }

	// RVA: 0x25F8EE0 Offset: 0x25F8FE1 VA: 0x25F8EE0
	public string Dump() { }

	// RVA: 0x25F9260 Offset: 0x25F9361 VA: 0x25F9260
	public void Appear(GmapSpot.EncountPersonType type, int rank, string ejid, string spotId) { }

	// RVA: 0x25F95F0 Offset: 0x25F96F1 VA: 0x25F95F0
	private bool DecideEncountRare(string spotId, out EncountUnitData.RareType rareType, out int rareNum) { }

	// RVA: 0x25F9E60 Offset: 0x25F9F61 VA: 0x25F9E60
	private EncountUnitData.RareType DecideEnemyType(string nationName) { }

	// RVA: 0x25FA070 Offset: 0x25FA171 VA: 0x25FA070
	private int GetEnemyRate(string nationName, EncountUnitData.RareType rareType) { }

	// RVA: 0x25FA330 Offset: 0x25FA431 VA: 0x25FA330
	private int GetEnemyRateAvarage(EncountUnitData.RareType rareType) { }

	// RVA: 0x25F9EF0 Offset: 0x25F9FF1 VA: 0x25F9EF0
	private int DecideEnemyNum(int nationLevel) { }

	// RVA: 0x25F8E60 Offset: 0x25F8F61 VA: 0x25F8E60
	public void Clear() { }

	// RVA: 0x25F9770 Offset: 0x25F9871 VA: 0x25F9770
	private void SetRandomEncountJob(string ejid) { }

	// RVA: 0x25F9990 Offset: 0x25F9A91 VA: 0x25F9990
	public JobData GetEncountJob(Random random, int level, bool isLeader = False, bool isIgnoreMageCannon = False) { }

	// RVA: 0x25F7CF0 Offset: 0x25F7DF1 VA: 0x25F7CF0
	public JobData GetLeaderJob() { }

	// RVA: 0x25FA460 Offset: 0x25FA561 VA: 0x25FA460
	public PersonData GetEncountPerson(Random random, JobData job, EncountUnitData.RareType unitRareType) { }

	// RVA: 0x25FA480 Offset: 0x25FA581 VA: 0x25FA480
	public PersonData GetLeaderPerson(EncountUnitData.RareType unitRareType) { }

	// RVA: 0x25F7CB0 Offset: 0x25F7DB1 VA: 0x25F7CB0
	public PersonData GetIconPerson() { }

	// RVA: 0x25FA6A0 Offset: 0x25FA7A1 VA: 0x25FA6A0
	public int GetRareCount() { }

	// RVA: 0x25F7D80 Offset: 0x25F7E81 VA: 0x25F7D80
	public static PersonData TryGetHighJobPerson(PersonData person, JobData job) { }

	// RVA: 0x25FA6D0 Offset: 0x25FA7D1 VA: 0x25FA6D0
	public void Serialize(Stream stream) { }

	// RVA: 0x25FA7E0 Offset: 0x25FA8E1 VA: 0x25FA7E0
	public void Deserialize(Stream stream) { }

	// RVA: 0x25FB200 Offset: 0x25FB301 VA: 0x25FB200
	private void Correct() { }

	// RVA: 0x25FB330 Offset: 0x25FB431 VA: 0x25FB330
	public int get_Rank() { }

	// RVA: 0x25F98B0 Offset: 0x25F99B1 VA: 0x25F98B0
	private void set_Rank(int value) { }

	// RVA: 0x25F9910 Offset: 0x25F9A11 VA: 0x25F9910
	private int get_LeaderRank() { }

	// RVA: 0x25FB340 Offset: 0x25FB441 VA: 0x25FB340
	public int get_Cycle() { }

	// RVA: 0x25F98C0 Offset: 0x25F99C1 VA: 0x25F98C0
	private void set_Cycle(int value) { }

	// RVA: 0x25FB350 Offset: 0x25FB451 VA: 0x25FB350
	public int get_PlayerDispos() { }

	// RVA: 0x25F98D0 Offset: 0x25F99D1 VA: 0x25F98D0
	private void set_PlayerDispos(int value) { }

	// RVA: 0x25FB360 Offset: 0x25FB461 VA: 0x25FB360
	public int get_EnemyDispos() { }

	// RVA: 0x25F98E0 Offset: 0x25F99E1 VA: 0x25F98E0
	private void set_EnemyDispos(int value) { }

	// RVA: 0x25FB370 Offset: 0x25FB471 VA: 0x25FB370
	public RandomSeed get_Seed() { }

	// RVA: 0x25FB380 Offset: 0x25FB481 VA: 0x25FB380
	public EncountUnitData.RareType get_RareType() { }

	// RVA: 0x25F98F0 Offset: 0x25F99F1 VA: 0x25F98F0
	private void set_ExpRareCount(int value) { }

	// RVA: 0x25F9900 Offset: 0x25F9A01 VA: 0x25F9900
	private void set_GoldRareCount(int value) { }

	// RVA: 0x25FA680 Offset: 0x25FA781 VA: 0x25FA680
	private Gender get_LeaderGender() { }

	// RVA: 0x25F9E50 Offset: 0x25F9F51 VA: 0x25F9E50
	private void set_LeaderGender(Gender value) { }
}

