// Namespace: System.Security.Cryptography
[ComVisibleAttribute] // RVA: 0x474180 Offset: 0x474281 VA: 0x474180
public sealed class RSACryptoServiceProvider : RSA // TypeDefIndex: 946
{
	// Fields
	private static CspProviderFlags s_UseMachineKeyStore; // 0x0
	private KeyPairPersistence store; // 0x20
	private bool persistKey; // 0x28
	private bool persisted; // 0x29
	private bool privateKeyExportable; // 0x2A
	private bool m_disposed; // 0x2B
	private RSAManaged rsa; // 0x30

	// Properties
	public static bool UseMachineKeyStore { get; }
	public override int KeySize { get; }
	[ComVisibleAttribute] // RVA: 0x47E140 Offset: 0x47E241 VA: 0x47E140
	public bool PublicOnly { get; }

	// Methods

	// RVA: 0x3B6C8E0 Offset: 0x3B6C9E1 VA: 0x3B6C8E0
	public static bool get_UseMachineKeyStore() { }

	// RVA: 0x3B6BE80 Offset: 0x3B6BF81 VA: 0x3B6BE80
	public void .ctor() { }

	// RVA: 0x3B6C980 Offset: 0x3B6CA81 VA: 0x3B6C980
	public void .ctor(CspParameters parameters) { }

	// RVA: 0x3B6C940 Offset: 0x3B6CA41 VA: 0x3B6C940
	public void .ctor(int dwKeySize) { }

	// RVA: 0x3B6C9E0 Offset: 0x3B6CAE1 VA: 0x3B6C9E0
	public void .ctor(int dwKeySize, CspParameters parameters) { }

	// RVA: 0x3B6CA50 Offset: 0x3B6CB51 VA: 0x3B6CA50
	private void Common(int dwKeySize, bool parameters) { }

	// RVA: 0x3B6CD50 Offset: 0x3B6CE51 VA: 0x3B6CD50
	private void Common(CspParameters p) { }

	// RVA: 0x3B6D040 Offset: 0x3B6D141 VA: 0x3B6D040 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x3B6D0C0 Offset: 0x3B6D1C1 VA: 0x3B6D0C0 Slot: 6
	public override int get_KeySize() { }

	// RVA: 0x3B6D0E0 Offset: 0x3B6D1E1 VA: 0x3B6D0E0
	public bool get_PublicOnly() { }

	// RVA: 0x3B6D1D0 Offset: 0x3B6D2D1 VA: 0x3B6D1D0 Slot: 10
	public override RSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0x3B6D310 Offset: 0x3B6D411 VA: 0x3B6D310 Slot: 11
	public override void ImportParameters(RSAParameters parameters) { }

	// RVA: 0x3B6D380 Offset: 0x3B6D481 VA: 0x3B6D380 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x3B6D3F0 Offset: 0x3B6D4F1 VA: 0x3B6D3F0
	private void OnKeyGenerated(object sender, EventArgs e) { }
}

