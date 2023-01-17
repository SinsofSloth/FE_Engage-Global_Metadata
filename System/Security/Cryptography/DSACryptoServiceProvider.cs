// Namespace: System.Security.Cryptography
[ComVisibleAttribute] // RVA: 0x474340 Offset: 0x474441 VA: 0x474340
public sealed class DSACryptoServiceProvider : DSA // TypeDefIndex: 968
{
	// Fields
	private KeyPairPersistence store; // 0x20
	private bool persistKey; // 0x28
	private bool persisted; // 0x29
	private bool privateKeyExportable; // 0x2A
	private bool m_disposed; // 0x2B
	private DSAManaged dsa; // 0x30
	private static bool useMachineKeyStore; // 0x0

	// Properties
	public override int KeySize { get; }
	[ComVisibleAttribute] // RVA: 0x47E1A0 Offset: 0x47E2A1 VA: 0x47E1A0
	public bool PublicOnly { get; }

	// Methods

	// RVA: 0x35AD5D0 Offset: 0x35AD6D1 VA: 0x35AD5D0
	public void .ctor() { }

	// RVA: 0x35AE1B0 Offset: 0x35AE2B1 VA: 0x35AE1B0
	public void .ctor(int dwKeySize) { }

	// RVA: 0x35AE1F0 Offset: 0x35AE2F1 VA: 0x35AE1F0
	private void Common(int dwKeySize, bool parameters) { }

	// RVA: 0x35AE670 Offset: 0x35AE771 VA: 0x35AE670 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x35AE6F0 Offset: 0x35AE7F1 VA: 0x35AE6F0 Slot: 6
	public override int get_KeySize() { }

	// RVA: 0x35AE700 Offset: 0x35AE801 VA: 0x35AE700
	public bool get_PublicOnly() { }

	// RVA: 0x35AE820 Offset: 0x35AE921 VA: 0x35AE820 Slot: 10
	public override DSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0x35AE8E0 Offset: 0x35AE9E1 VA: 0x35AE8E0 Slot: 11
	public override void ImportParameters(DSAParameters parameters) { }

	// RVA: 0x35AE950 Offset: 0x35AEA51 VA: 0x35AE950 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x35AE9C0 Offset: 0x35AEAC1 VA: 0x35AE9C0
	private void OnKeyGenerated(object sender, EventArgs e) { }
}

