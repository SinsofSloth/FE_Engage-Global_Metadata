// Namespace: nn.err
public struct ErrorCode // TypeDefIndex: 14767
{
	// Fields
	public uint category; // 0x0
	public uint number; // 0x4

	// Methods

	// RVA: 0x26056A0 Offset: 0x26057A1 VA: 0x26056A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2605750 Offset: 0x2605851 VA: 0x2605750
	public bool IsValid() { }

	// RVA: 0x2605770 Offset: 0x2605871 VA: 0x2605770
	private static extern bool IsValid(ErrorCode errorCode) { }

	// RVA: 0x2605790 Offset: 0x2605891 VA: 0x2605790
	public static extern ErrorCode GetInvalidErrorCode() { }
}

