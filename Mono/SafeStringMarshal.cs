// Namespace: Mono
internal struct SafeStringMarshal : IDisposable // TypeDefIndex: 21
{
	// Fields
	private readonly string str; // 0x0
	private IntPtr marshaled_string; // 0x8

	// Properties
	public IntPtr Value { get; }

	// Methods

	// RVA: 0x3611AA0 Offset: 0x3611BA1 VA: 0x3611AA0
	public static IntPtr StringToUtf8(string str) { }

	// RVA: 0x3611AB0 Offset: 0x3611BB1 VA: 0x3611AB0
	public static void GFree(IntPtr ptr) { }

	// RVA: 0x3611AC0 Offset: 0x3611BC1 VA: 0x3611AC0
	public void .ctor(string str) { }

	// RVA: 0x3611B20 Offset: 0x3611C21 VA: 0x3611B20
	public IntPtr get_Value() { }

	// RVA: 0x3611B90 Offset: 0x3611C91 VA: 0x3611B90 Slot: 4
	public void Dispose() { }
}

