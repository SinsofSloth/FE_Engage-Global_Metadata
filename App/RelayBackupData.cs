// Namespace: App
internal class RelayBackupData // TypeDefIndex: 12859
{
	// Fields
	private const int BufferSizeReplay = 262144;
	private const int BufferSizeAll = 3145728;
	private const byte VersionReplay = 0;
	private const byte VersionAll = 1;
	private RelayBackupData.Kinds m_Kind; // 0x10
	private byte[] m_Buffer; // 0x18
	private Stream m_Stream; // 0x20
	private GameSaveData m_SaveData; // 0x28

	// Methods

	// RVA: 0x2537620 Offset: 0x2537721 VA: 0x2537620
	public void .ctor(RelayBackupData.Kinds kind) { }

	// RVA: 0x253B540 Offset: 0x253B641 VA: 0x253B540
	public void Clear() { }

	// RVA: 0x253F6A0 Offset: 0x253F7A1 VA: 0x253F6A0
	public void Serialize() { }

	// RVA: 0x253F8D0 Offset: 0x253F9D1 VA: 0x253F8D0
	public void Deserialize() { }

	// RVA: 0x253F6C0 Offset: 0x253F7C1 VA: 0x253F6C0
	private void SerializeForReplay() { }

	// RVA: 0x253F8F0 Offset: 0x253F9F1 VA: 0x253F8F0
	private void DeserializeForReplay() { }

	// RVA: 0x253F820 Offset: 0x253F921 VA: 0x253F820
	private void SerializeForAll() { }

	// RVA: 0x253FA00 Offset: 0x253FB01 VA: 0x253FA00
	private void DeserializeForAll() { }

	// RVA: 0x253F680 Offset: 0x253F781 VA: 0x253F680
	private static int GetBufferSize(RelayBackupData.Kinds kind) { }
}

