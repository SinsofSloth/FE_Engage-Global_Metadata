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

