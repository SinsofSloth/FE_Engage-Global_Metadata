// Namespace: App
internal class RelayServerMetaData // TypeDefIndex: 12863
{
	// Fields
	public const int BufferSize = 2048;
	public const int BufferOnServerSize = 1024;
	private const ushort Version = 4;
	private byte[] m_Buffer; // 0x10
	private Stream m_Stream; // 0x18
	private byte[] m_BufferOnServer; // 0x20
	private int m_SizeOnServer; // 0x28
	private ulong m_DataId; // 0x30
	private string m_DataCode; // 0x38
	private long m_UpdatedUnixTimeOnServer; // 0x40
	private bool m_IsSecret; // 0x48
	private string m_Cid; // 0x50
	private long m_BeginUnixTime; // 0x58
	private long m_EndUnixTime; // 0x60
	private byte m_Turn; // 0x68
	private RelayServerMetaData.States m_State; // 0x6C
	private List<ulong> m_PlayerIds; // 0x70
	private List<string> m_PlayerNames; // 0x78
	private List<string> m_Pids; // 0x80
	private uint m_PlayingCount; // 0x88
	private Dictionary<string, RelayAwardeeData> m_Awardees; // 0x90
	private RandomSeed m_AwardRandomSeed; // 0x98

	// Properties
	public byte[] Buffer { get; }
	public int Size { get; }
	public byte[] BufferOnServer { get; }
	public int SizeOnServer { get; }
	public ulong DataId { get; set; }
	public string DataCode { get; set; }
	public long UpdatedUnixTimeOnServer { get; set; }
	public bool IsSecret { get; set; }
	public ulong OwnerId { get; }
	public string OwnerName { get; }
	public string Cid { get; }
	public long BeginUnixTime { get; }
	public long EndUnixTime { get; }
	public int Turn { get; set; }
	public bool IsEnd { get; }
	public bool IsCompleted { get; }
	public List<ulong> PlayerIds { get; }
	public List<string> PlayerNames { get; }
	public List<string> Pids { get; }
	public uint PlayingCount { get; set; }
	public Dictionary<string, RelayAwardeeData> Awardees { get; set; }

	// Methods

	// RVA: 0x24C1720 Offset: 0x24C1821 VA: 0x24C1720
	public void .ctor() { }

	// RVA: 0x24BBDB0 Offset: 0x24BBEB1 VA: 0x24BBDB0
	public RelayServerMetaData Clone() { }

	// RVA: 0x24C19E0 Offset: 0x24C1AE1 VA: 0x24C19E0
	public void SetOwner(ulong principalId, string name) { }

	// RVA: 0x24C1B00 Offset: 0x24C1C01 VA: 0x24C1B00
	public void SetCid(string cid) { }

	// RVA: 0x24C1B10 Offset: 0x24C1C11 VA: 0x24C1B10
	public void SetBinary(byte[] bin) { }

	// RVA: 0x24C1B70 Offset: 0x24C1C71 VA: 0x24C1B70
	public void SetBinary(List<byte> bin) { }

	// RVA: 0x24C1C00 Offset: 0x24C1D01 VA: 0x24C1C00
	public void UpdateBufferOnServer() { }

	// RVA: 0x24C2130 Offset: 0x24C2231 VA: 0x24C2130
	public void Begin() { }

	// RVA: 0x24C21F0 Offset: 0x24C22F1 VA: 0x24C21F0
	public void Complete() { }

	// RVA: 0x24C2330 Offset: 0x24C2431 VA: 0x24C2330
	public void GameOver() { }

	// RVA: 0x24C2410 Offset: 0x24C2511 VA: 0x24C2410
	public void ComplementTime(long unixTime) { }

	// RVA: 0x24C1A70 Offset: 0x24C1B71 VA: 0x24C1A70
	public void AddPlayer(ulong principalId, string name) { }

	// RVA: 0x24C2440 Offset: 0x24C2541 VA: 0x24C2440
	public void AddPid(string pid) { }

	// RVA: 0x24C2540 Offset: 0x24C2641 VA: 0x24C2540
	public string GetOwnerName() { }

	// RVA: 0x24C2620 Offset: 0x24C2721 VA: 0x24C2620
	public string GetPlayerName(int index) { }

	// RVA: 0x24C26E0 Offset: 0x24C27E1 VA: 0x24C26E0
	public Random CreateAwardRandom() { }

	// RVA: 0x24C18E0 Offset: 0x24C19E1 VA: 0x24C18E0
	public void Clear() { }

	// RVA: 0x24C1C70 Offset: 0x24C1D71 VA: 0x24C1C70
	public void Serialize() { }

	// RVA: 0x24C2750 Offset: 0x24C2851 VA: 0x24C2750
	public bool Deserialize() { }

	// RVA: 0x24C3830 Offset: 0x24C3931 VA: 0x24C3830
	public byte[] get_Buffer() { }

	// RVA: 0x24C2120 Offset: 0x24C2221 VA: 0x24C2120
	public int get_Size() { }

	// RVA: 0x24C3840 Offset: 0x24C3941 VA: 0x24C3840
	public byte[] get_BufferOnServer() { }

	// RVA: 0x24C3850 Offset: 0x24C3951 VA: 0x24C3850
	public int get_SizeOnServer() { }

	// RVA: 0x24C3860 Offset: 0x24C3961 VA: 0x24C3860
	public ulong get_DataId() { }

	// RVA: 0x24C3870 Offset: 0x24C3971 VA: 0x24C3870
	public void set_DataId(ulong value) { }

	// RVA: 0x24C3880 Offset: 0x24C3981 VA: 0x24C3880
	public string get_DataCode() { }

	// RVA: 0x24C3890 Offset: 0x24C3991 VA: 0x24C3890
	public void set_DataCode(string value) { }

	// RVA: 0x24C38A0 Offset: 0x24C39A1 VA: 0x24C38A0
	public long get_UpdatedUnixTimeOnServer() { }

	// RVA: 0x24C38B0 Offset: 0x24C39B1 VA: 0x24C38B0
	public void set_UpdatedUnixTimeOnServer(long value) { }

	// RVA: 0x24C38C0 Offset: 0x24C39C1 VA: 0x24C38C0
	public bool get_IsSecret() { }

	// RVA: 0x24C38D0 Offset: 0x24C39D1 VA: 0x24C38D0
	public void set_IsSecret(bool value) { }

	// RVA: 0x24C38E0 Offset: 0x24C39E1 VA: 0x24C38E0
	public ulong get_OwnerId() { }

	// RVA: 0x24C25C0 Offset: 0x24C26C1 VA: 0x24C25C0
	public string get_OwnerName() { }

	// RVA: 0x24C3940 Offset: 0x24C3A41 VA: 0x24C3940
	public string get_Cid() { }

	// RVA: 0x24C3950 Offset: 0x24C3A51 VA: 0x24C3950
	public long get_BeginUnixTime() { }

	// RVA: 0x24C3960 Offset: 0x24C3A61 VA: 0x24C3960
	public long get_EndUnixTime() { }

	// RVA: 0x24C3970 Offset: 0x24C3A71 VA: 0x24C3970
	public int get_Turn() { }

	// RVA: 0x24C3980 Offset: 0x24C3A81 VA: 0x24C3980
	public void set_Turn(int value) { }

	// RVA: 0x24C39C0 Offset: 0x24C3AC1 VA: 0x24C39C0
	public bool get_IsEnd() { }

	// RVA: 0x24C39D0 Offset: 0x24C3AD1 VA: 0x24C39D0
	public bool get_IsCompleted() { }

	// RVA: 0x24C39E0 Offset: 0x24C3AE1 VA: 0x24C39E0
	public List<ulong> get_PlayerIds() { }

	// RVA: 0x24C39F0 Offset: 0x24C3AF1 VA: 0x24C39F0
	public List<string> get_PlayerNames() { }

	// RVA: 0x24C3A00 Offset: 0x24C3B01 VA: 0x24C3A00
	public List<string> get_Pids() { }

	// RVA: 0x24C3A10 Offset: 0x24C3B11 VA: 0x24C3A10
	public uint get_PlayingCount() { }

	// RVA: 0x24C3A20 Offset: 0x24C3B21 VA: 0x24C3A20
	public void set_PlayingCount(uint value) { }

	// RVA: 0x24C3A30 Offset: 0x24C3B31 VA: 0x24C3A30
	public Dictionary<string, RelayAwardeeData> get_Awardees() { }

	// RVA: 0x24C3A40 Offset: 0x24C3B41 VA: 0x24C3A40
	public void set_Awardees(Dictionary<string, RelayAwardeeData> value) { }

	// RVA: 0x24C21D0 Offset: 0x24C22D1 VA: 0x24C21D0
	private void TrySetBeginUnixTime(long unixTime) { }

	// RVA: 0x24C22D0 Offset: 0x24C23D1 VA: 0x24C22D0
	private void TrySetEndUnixTime(long unixTime) { }

	// RVA: 0x24C22F0 Offset: 0x24C23F1 VA: 0x24C22F0
	private void SetAwardRandomSeed() { }
}

