// Namespace: Microsoft.Win32
internal class KeyHandler // TypeDefIndex: 93
{
	// Fields
	private static Hashtable key_to_handler; // 0x0
	private static Hashtable dir_to_handler; // 0x8
	public string Dir; // 0x10
	private string ActualDir; // 0x18
	public bool IsVolatile; // 0x20
	private Hashtable values; // 0x28
	private string file; // 0x30
	private bool dirty; // 0x38
	private static string user_store; // 0x10
	private static string machine_store; // 0x18

	// Properties
	public bool IsMarkedForDeletion { get; }
	private static string UserStore { get; }
	private static string MachineStore { get; }

	// Methods

	// RVA: 0x3414760 Offset: 0x3414861 VA: 0x3414760
	private static void .cctor() { }

	// RVA: 0x3414B20 Offset: 0x3414C21 VA: 0x3414B20
	private void .ctor(RegistryKey rkey, string basedir) { }

	// RVA: 0x3414B30 Offset: 0x3414C31 VA: 0x3414B30
	private void .ctor(RegistryKey rkey, string basedir, bool is_volatile) { }

	// RVA: 0x3414E40 Offset: 0x3414F41 VA: 0x3414E40
	public void Load() { }

	// RVA: 0x34154C0 Offset: 0x34155C1 VA: 0x34154C0
	private void LoadKey(SecurityElement se) { }

	// RVA: 0x3415BF0 Offset: 0x3415CF1 VA: 0x3415BF0
	public RegistryKey Ensure(RegistryKey rkey, string extra, bool writable, bool is_volatile) { }

	// RVA: 0x3415FF0 Offset: 0x34160F1 VA: 0x3415FF0
	public RegistryKey Probe(RegistryKey rkey, string extra, bool writable) { }

	// RVA: 0x3415F60 Offset: 0x3416061 VA: 0x3415F60
	private static string CombineName(RegistryKey rkey, string extra) { }

	// RVA: 0x34166C0 Offset: 0x34167C1 VA: 0x34166C0
	private static long GetSystemBootTime() { }

	// RVA: 0x3416A20 Offset: 0x3416B21 VA: 0x3416A20
	private static long GetRegisteredBootTime(string path) { }

	// RVA: 0x3416D20 Offset: 0x3416E21 VA: 0x3416D20
	private static void SaveRegisteredBootTime(string path, long btime) { }

	// RVA: 0x34148A0 Offset: 0x34149A1 VA: 0x34148A0
	private static void CleanVolatileKeys() { }

	// RVA: 0x3416480 Offset: 0x3416581 VA: 0x3416480
	public static bool VolatileKeyExists(string dir) { }

	// RVA: 0x3414D70 Offset: 0x3414E71 VA: 0x3414D70
	public static string GetVolatileDir(string dir) { }

	// RVA: 0x34173C0 Offset: 0x34174C1 VA: 0x34173C0
	public static KeyHandler Lookup(RegistryKey rkey, bool createNonExisting) { }

	// RVA: 0x3417260 Offset: 0x3417361 VA: 0x3417260
	private static string GetRootFromDir(string dir) { }

	// RVA: 0x3417850 Offset: 0x3417951 VA: 0x3417850
	public static void Drop(RegistryKey rkey) { }

	// RVA: 0x3417D70 Offset: 0x3417E71 VA: 0x3417D70
	public object GetValue(string name, RegistryValueOptions options) { }

	// RVA: 0x3418010 Offset: 0x3418111 VA: 0x3418010
	public string[] GetSubKeyNames() { }

	// RVA: 0x34184A0 Offset: 0x34185A1 VA: 0x34184A0
	public void Flush() { }

	// RVA: 0x3419100 Offset: 0x3419201 VA: 0x3419100
	public bool ValueExists(string name) { }

	// RVA: 0x3417F80 Offset: 0x3418081 VA: 0x3417F80
	public bool get_IsMarkedForDeletion() { }

	// RVA: 0x3419230 Offset: 0x3419331 VA: 0x3419230 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x34185E0 Offset: 0x34186E1 VA: 0x34185E0
	private void Save() { }

	// RVA: 0x3416F40 Offset: 0x3417041 VA: 0x3416F40
	private static string get_UserStore() { }

	// RVA: 0x3417080 Offset: 0x3417181 VA: 0x3417080
	private static string get_MachineStore() { }
}

