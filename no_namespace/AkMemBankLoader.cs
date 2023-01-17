// Namespace: 
public class AkMemBankLoader : MonoBehaviour // TypeDefIndex: 8031
{
	// Fields
	private const int WaitMs = 50;
	private const long AK_BANK_PLATFORM_DATA_ALIGNMENT = 16;
	private const long AK_BANK_PLATFORM_DATA_ALIGNMENT_MASK = 15;
	public string bankName; // 0x18
	public bool isLocalizedBank; // 0x20
	private string m_bankPath; // 0x28
	[HideInInspector] // RVA: 0x27ECC0 Offset: 0x27EDC1 VA: 0x27ECC0
	public uint ms_bankID; // 0x30
	private IntPtr ms_pInMemoryBankPtr; // 0x38
	private GCHandle ms_pinnedArray; // 0x40
	private UnityWebRequest ms_www; // 0x48

	// Methods

	// RVA: 0x317EB90 Offset: 0x317EC91 VA: 0x317EB90
	private void Start() { }

	// RVA: 0x317ED90 Offset: 0x317EE91 VA: 0x317ED90
	public void LoadNonLocalizedBank(string in_bankFilename) { }

	// RVA: 0x317EBB0 Offset: 0x317ECB1 VA: 0x317EBB0
	public void LoadLocalizedBank(string in_bankFilename) { }

	// RVA: 0x317EFC0 Offset: 0x317F0C1 VA: 0x317EFC0
	private uint AllocateAlignedBuffer(byte[] data) { }

	[IteratorStateMachineAttribute] // RVA: 0x2A7220 Offset: 0x2A7321 VA: 0x2A7220
	// RVA: 0x317F1F0 Offset: 0x317F2F1 VA: 0x317F1F0
	private IEnumerator LoadFile() { }

	// RVA: 0x317EF30 Offset: 0x317F031 VA: 0x317EF30
	private void DoLoadBank(string in_bankPath) { }

	// RVA: 0x317F270 Offset: 0x317F371 VA: 0x317F270
	private void OnDestroy() { }

	// RVA: 0x317F330 Offset: 0x317F431 VA: 0x317F330
	public void .ctor() { }
}

