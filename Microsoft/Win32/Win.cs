// Namespace: Microsoft.Win32
internal class Win32RegistryApi : IRegistryApi // TypeDefIndex: 95
{
	// Fields
	private readonly int NativeBytesPerCharacter; // 0x10

	// Methods

	// RVA: 0x34D1680 Offset: 0x34D1781 VA: 0x34D1680
	private static extern int RegCloseKey(IntPtr keyHandle) { }

	// RVA: 0x34D1700 Offset: 0x34D1801 VA: 0x34D1700
	private static extern int RegFlushKey(IntPtr keyHandle) { }

	// RVA: 0x34D1780 Offset: 0x34D1881 VA: 0x34D1780
	private static extern int RegOpenKeyEx(IntPtr keyBase, string keyName, IntPtr reserved, int access, out IntPtr keyHandle) { }

	// RVA: 0x34D1830 Offset: 0x34D1931 VA: 0x34D1830
	internal static extern int RegEnumKeyEx(IntPtr keyHandle, int dwIndex, char* lpName, ref int lpcbName, int[] lpReserved, [Out] StringBuilder lpClass, int[] lpcbClass, long[] lpftLastWriteTime) { }

	// RVA: 0x34D1950 Offset: 0x34D1A51 VA: 0x34D1950
	private static extern int RegQueryValueEx(IntPtr keyBase, string valueName, IntPtr reserved, ref RegistryValueKind type, IntPtr zero, ref int dataSize) { }

	// RVA: 0x34D1A20 Offset: 0x34D1B21 VA: 0x34D1A20
	private static extern int RegQueryValueEx(IntPtr keyBase, string valueName, IntPtr reserved, ref RegistryValueKind type, [Out] byte[] data, ref int dataSize) { }

	// RVA: 0x34D1BC0 Offset: 0x34D1CC1 VA: 0x34D1BC0
	private static extern int RegQueryValueEx(IntPtr keyBase, string valueName, IntPtr reserved, ref RegistryValueKind type, ref int data, ref int dataSize) { }

	// RVA: 0x34D1C90 Offset: 0x34D1D91 VA: 0x34D1C90
	private static extern int RegQueryValueEx(IntPtr keyBase, string valueName, IntPtr reserved, ref RegistryValueKind type, ref long data, ref int dataSize) { }

	// RVA: 0x34D1D60 Offset: 0x34D1E61 VA: 0x34D1D60
	internal static extern int RegQueryInfoKey(IntPtr hKey, [Out] StringBuilder lpClass, int[] lpcbClass, IntPtr lpReserved_MustBeZero, ref int lpcSubKeys, int[] lpcbMaxSubKeyLen, int[] lpcbMaxClassLen, ref int lpcValues, int[] lpcbMaxValueNameLen, int[] lpcbMaxValueLen, int[] lpcbSecurityDescriptor, int[] lpftLastWriteTime) { }

	// RVA: 0x34D1EB0 Offset: 0x34D1FB1 VA: 0x34D1EB0 Slot: 10
	public IntPtr GetHandle(RegistryKey key) { }

	// RVA: 0x34D1F30 Offset: 0x34D2031 VA: 0x34D1F30
	private static bool IsHandleValid(RegistryKey key) { }

	// RVA: 0x34D1F40 Offset: 0x34D2041 VA: 0x34D1F40 Slot: 7
	public object GetValue(RegistryKey rkey, string name, object defaultValue, RegistryValueOptions options) { }

	// RVA: 0x34D2590 Offset: 0x34D2691 VA: 0x34D2590
	private int GetBinaryValue(RegistryKey rkey, string name, RegistryValueKind type, out byte[] data, int size) { }

	// RVA: 0x34D26B0 Offset: 0x34D27B1 VA: 0x34D26B0 Slot: 11
	public int SubKeyCount(RegistryKey rkey) { }

	// RVA: 0x34D2820 Offset: 0x34D2921 VA: 0x34D2820 Slot: 4
	public RegistryKey OpenSubKey(RegistryKey rkey, string keyName, bool writable) { }

	// RVA: 0x34D2A80 Offset: 0x34D2B81 VA: 0x34D2A80 Slot: 5
	public void Flush(RegistryKey rkey) { }

	// RVA: 0x34D2B60 Offset: 0x34D2C61 VA: 0x34D2B60 Slot: 6
	public void Close(RegistryKey rkey) { }

	// RVA: 0x34D2C60 Offset: 0x34D2D61 VA: 0x34D2C60 Slot: 8
	public string[] GetSubKeyNames(RegistryKey rkey) { }

	// RVA: 0x34D2400 Offset: 0x34D2501 VA: 0x34D2400
	private void GenerateException(int errorCode) { }

	// RVA: 0x34D2ED0 Offset: 0x34D2FD1 VA: 0x34D2ED0 Slot: 9
	public string ToString(RegistryKey rkey) { }

	// RVA: 0x34D2A20 Offset: 0x34D2B21 VA: 0x34D2A20
	internal static string CombineName(RegistryKey rkey, string localName) { }

	// RVA: 0x34D2EE0 Offset: 0x34D2FE1 VA: 0x34D2EE0
	public void .ctor() { }
}

// Namespace: Microsoft.Win32
internal static class Win32Native // TypeDefIndex: 97
{
	// Methods

	// RVA: 0x34D15E0 Offset: 0x34D16E1 VA: 0x34D15E0
	public static string GetMessage(int hr) { }

	// RVA: 0x34D1670 Offset: 0x34D1771 VA: 0x34D1670
	public static int MakeHRFromErrorCode(int errorCode) { }
}

