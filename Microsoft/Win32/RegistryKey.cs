// Namespace: Microsoft.Win32
[ComVisibleAttribute] // RVA: 0x46F790 Offset: 0x46F891 VA: 0x46F790
public sealed class RegistryKey : MarshalByRefObject, IDisposable // TypeDefIndex: 88
{
	// Fields
	private object handle; // 0x18
	private SafeRegistryHandle safe_handle; // 0x20
	private object hive; // 0x28
	private readonly string qname; // 0x30
	private readonly bool isRemoteRoot; // 0x38
	private readonly bool isWritable; // 0x39
	private static readonly IRegistryApi RegistryApi; // 0x0

	// Properties
	public string Name { get; }
	[ComVisibleAttribute] // RVA: 0x47DC40 Offset: 0x47DD41 VA: 0x47DC40
	[MonoTODOAttribute] // RVA: 0x47DC40 Offset: 0x47DD41 VA: 0x47DC40
	public SafeRegistryHandle Handle { get; }
	internal bool IsRoot { get; }
	internal RegistryHive Hive { get; }
	internal object InternalHandle { get; }

	// Methods

	// RVA: 0x3B75180 Offset: 0x3B75281 VA: 0x3B75180
	private static void .cctor() { }

	// RVA: 0x3B75130 Offset: 0x3B75231 VA: 0x3B75130
	internal void .ctor(RegistryHive hiveId) { }

	// RVA: 0x3B75270 Offset: 0x3B75371 VA: 0x3B75270
	internal void .ctor(RegistryHive hiveId, IntPtr keyHandle, bool remoteRoot) { }

	// RVA: 0x3B754E0 Offset: 0x3B755E1 VA: 0x3B754E0
	internal void .ctor(object data, string keyName, bool writable) { }

	// RVA: 0x3B75540 Offset: 0x3B75641 VA: 0x3B75540
	internal static bool IsEquals(RegistryKey a, RegistryKey b) { }

	// RVA: 0x3B755E0 Offset: 0x3B756E1 VA: 0x3B755E0 Slot: 6
	public void Dispose() { }

	// RVA: 0x3B75790 Offset: 0x3B75891 VA: 0x3B75790
	public string get_Name() { }

	// RVA: 0x3B757A0 Offset: 0x3B758A1 VA: 0x3B757A0
	public void Flush() { }

	// RVA: 0x3B75660 Offset: 0x3B75761 VA: 0x3B75660
	public void Close() { }

	// RVA: 0x3B75890 Offset: 0x3B75991 VA: 0x3B75890
	public SafeRegistryHandle get_Handle() { }

	// RVA: 0x3B75AA0 Offset: 0x3B75BA1 VA: 0x3B75AA0
	public RegistryKey OpenSubKey(string name) { }

	// RVA: 0x3B75AB0 Offset: 0x3B75BB1 VA: 0x3B75AB0
	public RegistryKey OpenSubKey(string name, bool writable) { }

	// RVA: 0x3B75CF0 Offset: 0x3B75DF1 VA: 0x3B75CF0
	public object GetValue(string name) { }

	// RVA: 0x3B75D00 Offset: 0x3B75E01 VA: 0x3B75D00
	public object GetValue(string name, object defaultValue) { }

	// RVA: 0x3B75E50 Offset: 0x3B75F51 VA: 0x3B75E50
	public string[] GetSubKeyNames() { }

	// RVA: 0x3B75F80 Offset: 0x3B76081 VA: 0x3B75F80 Slot: 3
	public override string ToString() { }

	// RVA: 0x3B75880 Offset: 0x3B75981 VA: 0x3B75880
	internal bool get_IsRoot() { }

	// RVA: 0x3B760B0 Offset: 0x3B761B1 VA: 0x3B760B0
	internal RegistryHive get_Hive() { }

	// RVA: 0x3B76160 Offset: 0x3B76261 VA: 0x3B76160
	internal object get_InternalHandle() { }

	// RVA: 0x3B75A30 Offset: 0x3B75B31 VA: 0x3B75A30
	private void AssertKeyStillValid() { }

	// RVA: 0x3B75C80 Offset: 0x3B75D81 VA: 0x3B75C80
	private void AssertKeyNameLength(string name) { }

	// RVA: 0x3B76170 Offset: 0x3B76271 VA: 0x3B76170
	internal static string DecodeString(byte[] data) { }

	// RVA: 0x3B76210 Offset: 0x3B76311 VA: 0x3B76210
	internal static IOException CreateMarkedForDeletionException() { }

	// RVA: 0x3B753A0 Offset: 0x3B754A1 VA: 0x3B753A0
	private static string GetHiveName(RegistryHive hive) { }
}

