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

