// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2726C0 Offset: 0x2727C1 VA: 0x2726C0
private sealed class AkMemBankLoader.<LoadFile>d__14 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 8030
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public AkMemBankLoader <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2A7290 Offset: 0x2A7391 VA: 0x2A7290
	// RVA: 0x24B5D60 Offset: 0x24B5E61 VA: 0x24B5D60
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2A72A0 Offset: 0x2A73A1 VA: 0x2A72A0
	// RVA: 0x24B5D90 Offset: 0x24B5E91 VA: 0x24B5D90 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x24B5DA0 Offset: 0x24B5EA1 VA: 0x24B5DA0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2A72B0 Offset: 0x2A73B1 VA: 0x2A72B0
	// RVA: 0x24B5F80 Offset: 0x24B6081 VA: 0x24B5F80 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2A72C0 Offset: 0x2A73C1 VA: 0x2A72C0
	// RVA: 0x24B5F90 Offset: 0x24B6091 VA: 0x24B5F90 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2A72D0 Offset: 0x2A73D1 VA: 0x2A72D0
	// RVA: 0x24B5FD0 Offset: 0x24B60D1 VA: 0x24B5FD0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

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

