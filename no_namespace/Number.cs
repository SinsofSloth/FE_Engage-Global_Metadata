// Namespace: 
[FriendAccessAllowedAttribute] // RVA: 0x470710 Offset: 0x470811 VA: 0x470710
internal struct Number.NumberBuffer // TypeDefIndex: 281
{
	// Fields
	public static readonly int NumberBufferBytes; // 0x0
	private byte* baseAddress; // 0x0
	public char* digits; // 0x8
	public int precision; // 0x10
	public int scale; // 0x14
	public bool sign; // 0x18

	// Methods

	// RVA: 0x35EEEA0 Offset: 0x35EEFA1 VA: 0x35EEEA0
	public void .ctor(byte* stackBuffer) { }

	// RVA: 0x35EEEC0 Offset: 0x35EEFC1 VA: 0x35EEEC0
	public byte* PackForNative() { }

	// RVA: 0x35EEEF0 Offset: 0x35EEFF1 VA: 0x35EEEF0
	private static void .cctor() { }
}

