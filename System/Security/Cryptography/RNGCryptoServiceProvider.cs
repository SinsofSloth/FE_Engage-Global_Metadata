// Namespace: System.Security.Cryptography
public sealed class RNGCryptoServiceProvider : RandomNumberGenerator // TypeDefIndex: 971
{
	// Fields
	private static object _lock; // 0x0
	private IntPtr _handle; // 0x10

	// Methods

	// RVA: 0x3B6B900 Offset: 0x3B6BA01 VA: 0x3B6B900
	private static void .cctor() { }

	// RVA: 0x3B6B9A0 Offset: 0x3B6BAA1 VA: 0x3B6B9A0
	public void .ctor() { }

	// RVA: 0x3B6BA40 Offset: 0x3B6BB41 VA: 0x3B6BA40
	private void Check() { }

	// RVA: 0x3B6B990 Offset: 0x3B6BA91 VA: 0x3B6B990
	private static bool RngOpen() { }

	// RVA: 0x3B6BA30 Offset: 0x3B6BB31 VA: 0x3B6BA30
	private static IntPtr RngInitialize(byte[] seed) { }

	// RVA: 0x3B6BAE0 Offset: 0x3B6BBE1 VA: 0x3B6BAE0
	private static IntPtr RngGetBytes(IntPtr handle, byte[] data) { }

	// RVA: 0x3B6BAF0 Offset: 0x3B6BBF1 VA: 0x3B6BAF0
	private static void RngClose(IntPtr handle) { }

	// RVA: 0x3B6BB00 Offset: 0x3B6BC01 VA: 0x3B6BB00 Slot: 6
	public override void GetBytes(byte[] data) { }

	// RVA: 0x3B6BD00 Offset: 0x3B6BE01 VA: 0x3B6BD00 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x3B6BDE0 Offset: 0x3B6BEE1 VA: 0x3B6BDE0 Slot: 5
	protected override void Dispose(bool disposing) { }
}

