// Namespace: Microsoft.Win32
internal class UnixRegistryApi : IRegistryApi // TypeDefIndex: 94
{
	// Methods

	// RVA: 0x34C9D60 Offset: 0x34C9E61 VA: 0x34C9D60
	private static string ToUnix(string keyname) { }

	// RVA: 0x34C9DB0 Offset: 0x34C9EB1 VA: 0x34C9DB0
	private static bool IsWellKnownKey(string parentKeyName, string keyname) { }

	// RVA: 0x34C9EF0 Offset: 0x34C9FF1 VA: 0x34C9EF0 Slot: 4
	public RegistryKey OpenSubKey(RegistryKey rkey, string keyname, bool writable) { }

	// RVA: 0x34CA020 Offset: 0x34CA121 VA: 0x34CA020 Slot: 5
	public void Flush(RegistryKey rkey) { }

	// RVA: 0x34CA0B0 Offset: 0x34CA1B1 VA: 0x34CA0B0 Slot: 6
	public void Close(RegistryKey rkey) { }

	// RVA: 0x34CA120 Offset: 0x34CA221 VA: 0x34CA120 Slot: 7
	public object GetValue(RegistryKey rkey, string name, object default_value, RegistryValueOptions options) { }

	// RVA: 0x34CA1F0 Offset: 0x34CA2F1 VA: 0x34CA1F0 Slot: 8
	public string[] GetSubKeyNames(RegistryKey rkey) { }

	// RVA: 0x34CA270 Offset: 0x34CA371 VA: 0x34CA270 Slot: 9
	public string ToString(RegistryKey rkey) { }

	// RVA: 0x34CA010 Offset: 0x34CA111 VA: 0x34CA010
	private RegistryKey CreateSubKey(RegistryKey rkey, string keyname, bool writable) { }

	// RVA: 0x34CA280 Offset: 0x34CA381 VA: 0x34CA280
	private RegistryKey CreateSubKey(RegistryKey rkey, string keyname, bool writable, bool is_volatile) { }

	// RVA: 0x34CA440 Offset: 0x34CA541 VA: 0x34CA440 Slot: 10
	public IntPtr GetHandle(RegistryKey key) { }

	// RVA: 0x34CA480 Offset: 0x34CA581 VA: 0x34CA480
	public void .ctor() { }
}

