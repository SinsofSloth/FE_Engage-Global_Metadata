// Namespace: App
internal class NexKillBonus : SingletonClass<NexKillBonus> // TypeDefIndex: 12732
{
	// Fields
	public const int MaxWidth = 32;
	public const int MaxHeight = 32;
	private const int MaxPostData = 1;
	private const int Period = 365;
	public const int MaxCount = 10000;
	private const int StreamBufferSize = 8200;
	private const int GetBufferSize = 8200;
	private int[,,] m_Data; // 0x20
	private bool m_IsSucceeded; // 0x28
	private Stream m_SerializeStream; // 0x30
	private byte[] m_SerializeStreamBuffer; // 0x38

	// Properties
	public int[,,] Data { get; }
	public bool IsSucceeded { get; }
	protected override int Version { get; }

	// Methods

	// RVA: 0x23556E0 Offset: 0x23557E1 VA: 0x23556E0 Slot: 5
	protected override void OnCreate() { }

	// RVA: 0x2355860 Offset: 0x2355961 VA: 0x2355860
	public bool Download(ProcInst super, string cid) { }

	// RVA: 0x23558F0 Offset: 0x23559F1 VA: 0x23558F0
	public bool Upload(ProcInst super, string cid, MapKillBonus.CountImage killCountImage, MapKillBonus.CountImage killedCountImage) { }

	// RVA: 0x23558E0 Offset: 0x23559E1 VA: 0x23558E0
	public void ClearSucceeded() { }

	// RVA: 0x2355920 Offset: 0x2355A21 VA: 0x2355920
	public int[,,] get_Data() { }

	// RVA: 0x2355930 Offset: 0x2355A31 VA: 0x2355930
	public bool get_IsSucceeded() { }

	// RVA: 0x2355940 Offset: 0x2355A41 VA: 0x2355940
	private void SetData(string cid, byte[] data) { }

	// RVA: 0x2355C00 Offset: 0x2355D01 VA: 0x2355C00
	private void CreateData(MapKillBonus.CountImage killCountImage, MapKillBonus.CountImage killedCountImage, out byte[] data, out uint dataSize) { }

	// RVA: 0x2355C60 Offset: 0x2355D61 VA: 0x2355C60
	private void AddCounts(NexKillBonus.Kinds kind, MapKillBonus.CountImage countImage) { }

	// RVA: 0x2355F10 Offset: 0x2356011 VA: 0x2355F10 Slot: 4
	protected override int get_Version() { }

	// RVA: 0x2355DB0 Offset: 0x2355EB1 VA: 0x2355DB0
	private void Serialize(out byte[] data, out uint dataSize) { }

	// RVA: 0x2355950 Offset: 0x2355A51 VA: 0x2355950
	private void Deserialize(byte[] data) { }

	// RVA: 0x23558C0 Offset: 0x23559C1 VA: 0x23558C0
	private void ClearData() { }

	// RVA: 0x2355F20 Offset: 0x2356021 VA: 0x2355F20
	public void .ctor() { }
}

