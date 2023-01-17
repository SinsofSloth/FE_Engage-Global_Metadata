// Namespace: 
private class AkBankManager.BankHandle // TypeDefIndex: 7920
{
	// Fields
	protected readonly string bankName; // 0x10
	protected uint m_BankID; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x27D5B0 Offset: 0x27D6B1 VA: 0x27D5B0
	private int <RefCount>k__BackingField; // 0x1C

	// Properties
	public int RefCount { get; set; }

	// Methods

	// RVA: 0x24B1000 Offset: 0x24B1101 VA: 0x24B1000
	public void .ctor(string name) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A6F90 Offset: 0x2A7091 VA: 0x2A6F90
	// RVA: 0x24B1890 Offset: 0x24B1991 VA: 0x24B1890
	public int get_RefCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A6FA0 Offset: 0x2A70A1 VA: 0x2A6FA0
	// RVA: 0x24B18A0 Offset: 0x24B19A1 VA: 0x24B18A0
	private void set_RefCount(int value) { }

	// RVA: 0x24B18B0 Offset: 0x24B19B1 VA: 0x24B18B0 Slot: 4
	public virtual AKRESULT DoLoadBank() { }

	// RVA: 0x24B1930 Offset: 0x24B1A31 VA: 0x24B1930
	public void LoadBank() { }

	// RVA: 0x24B1B00 Offset: 0x24B1C01 VA: 0x24B1B00 Slot: 5
	public virtual void UnloadBank() { }

	// RVA: 0x24B1A60 Offset: 0x24B1B61 VA: 0x24B1A60
	public void IncRef() { }

	// RVA: 0x24B1CB0 Offset: 0x24B1DB1 VA: 0x24B1CB0
	public void DecRef() { }

	// RVA: 0x24B1240 Offset: 0x24B1341 VA: 0x24B1240
	protected void LogLoadResult(AKRESULT result) { }
}

// Namespace: 
private class AkBankManager.AsyncBankHandle : AkBankManager.BankHandle // TypeDefIndex: 7921
{
	// Fields
	private readonly AkCallbackManager.BankCallback bankCallback; // 0x20

	// Methods

	// RVA: 0x24B0FB0 Offset: 0x24B10B1 VA: 0x24B0FB0
	public void .ctor(string name, AkCallbackManager.BankCallback callback) { }

	// RVA: 0x24B1040 Offset: 0x24B1141 VA: 0x24B1040
	private static void GlobalBankCallback(uint in_bankID, IntPtr in_pInMemoryBankPtr, AKRESULT in_eLoadResult, object in_Cookie) { }

	// RVA: 0x24B1790 Offset: 0x24B1891 VA: 0x24B1790 Slot: 4
	public override AKRESULT DoLoadBank() { }
}

// Namespace: 
private class AkBankManager.DecodableBankHandle : AkBankManager.BankHandle // TypeDefIndex: 7922
{
	// Fields
	private readonly bool decodeBank; // 0x20
	private readonly string decodedBankPath; // 0x28
	private readonly bool saveDecodedBank; // 0x30

	// Methods

	// RVA: 0x24B1D50 Offset: 0x24B1E51 VA: 0x24B1D50
	public void .ctor(string name, bool save) { }

	// RVA: 0x24B2110 Offset: 0x24B2211 VA: 0x24B2110 Slot: 4
	public override AKRESULT DoLoadBank() { }

	// RVA: 0x24B22E0 Offset: 0x24B23E1 VA: 0x24B22E0 Slot: 5
	public override void UnloadBank() { }
}

// Namespace: 
public static class AkBankManager // TypeDefIndex: 7923
{
	// Fields
	private static readonly Dictionary<string, AkBankManager.BankHandle> m_BankHandles; // 0x0
	private static readonly List<AkBankManager.BankHandle> BanksToUnload; // 0x8

	// Methods

	// RVA: 0x2ED2720 Offset: 0x2ED2821 VA: 0x2ED2720
	internal static void DoUnloadBanks() { }

	// RVA: 0x2ED2880 Offset: 0x2ED2981 VA: 0x2ED2880
	internal static void Reset() { }

	// RVA: 0x2ED2930 Offset: 0x2ED2A31 VA: 0x2ED2930
	public static void LoadInitBank(bool doReset = True) { }

	// RVA: 0x2ED2AB0 Offset: 0x2ED2BB1 VA: 0x2ED2AB0
	public static void UnloadInitBank() { }

	// RVA: 0x2ED2B40 Offset: 0x2ED2C41 VA: 0x2ED2B40
	public static void LoadBank(string name, bool decodeBank, bool saveDecodedBank) { }

	// RVA: 0x2ED2D60 Offset: 0x2ED2E61 VA: 0x2ED2D60
	public static void LoadBankAsync(string name, AkCallbackManager.BankCallback callback) { }

	// RVA: 0x2ED2F90 Offset: 0x2ED3091 VA: 0x2ED2F90
	public static void UnloadBank(string name) { }

	// RVA: 0x2ED3110 Offset: 0x2ED3211 VA: 0x2ED3110
	private static void .cctor() { }
}

