// Namespace: nn.hid
public struct TouchScreenState16 // TypeDefIndex: 14717
{
	// Fields
	public const int TouchCount = 16;
	public long samplingNumber; // 0x0
	public int count; // 0x8
	private int _reserved; // 0xC
	public TouchScreenState16.TouchStateArray16 touches; // 0x10

	// Methods

	// RVA: 0x25E85E0 Offset: 0x25E86E1 VA: 0x25E85E0
	public void SetDefault() { }
}

