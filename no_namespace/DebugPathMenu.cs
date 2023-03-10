// Namespace: 
[FlagsAttribute] // RVA: 0x2751E0 Offset: 0x2752E1 VA: 0x2751E0
public enum DebugPathMenu.Categories // TypeDefIndex: 9104
{
	// Fields
	public int value__; // 0x0
	public const DebugPathMenu.Categories PC = 1;
	public const DebugPathMenu.Categories Assets = 2;
	public const DebugPathMenu.Categories All = 3;
}

// Namespace: 
public enum DebugPathMenu.Result // TypeDefIndex: 9105
{
	// Fields
	public int value__; // 0x0
	public const DebugPathMenu.Result Selected = 0;
	public const DebugPathMenu.Result Canceled = 1;
}

// Namespace: 
public class DebugPathMenu.Setting // TypeDefIndex: 9106
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x286BE0 Offset: 0x286CE1 VA: 0x286BE0
	private DebugPathMenu.Categories <Categories>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x286BF0 Offset: 0x286CF1 VA: 0x286BF0
	private bool <IsDirectoryOnly>k__BackingField; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x286C00 Offset: 0x286D01 VA: 0x286C00
	private string <InitialDirectoryPath>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x286C10 Offset: 0x286D11 VA: 0x286C10
	private Action<string> <OnSelect>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x286C20 Offset: 0x286D21 VA: 0x286C20
	private Action <OnCancel>k__BackingField; // 0x28

	// Properties
	public DebugPathMenu.Categories Categories { get; set; }
	public bool IsDirectoryOnly { get; set; }
	public string InitialDirectoryPath { get; set; }
	public Action<string> OnSelect { get; set; }
	public Action OnCancel { get; set; }

	// Methods

	// RVA: 0x1E15E70 Offset: 0x1E15F71 VA: 0x1E15E70
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AE380 Offset: 0x2AE481 VA: 0x2AE380
	// RVA: 0x1E15ED0 Offset: 0x1E15FD1 VA: 0x1E15ED0
	public DebugPathMenu.Categories get_Categories() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AE390 Offset: 0x2AE491 VA: 0x2AE390
	// RVA: 0x1E15EE0 Offset: 0x1E15FE1 VA: 0x1E15EE0
	public void set_Categories(DebugPathMenu.Categories value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AE3A0 Offset: 0x2AE4A1 VA: 0x2AE3A0
	// RVA: 0x1E15EF0 Offset: 0x1E15FF1 VA: 0x1E15EF0
	public bool get_IsDirectoryOnly() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AE3B0 Offset: 0x2AE4B1 VA: 0x2AE3B0
	// RVA: 0x1E15F00 Offset: 0x1E16001 VA: 0x1E15F00
	public void set_IsDirectoryOnly(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AE3C0 Offset: 0x2AE4C1 VA: 0x2AE3C0
	// RVA: 0x1E15F10 Offset: 0x1E16011 VA: 0x1E15F10
	public string get_InitialDirectoryPath() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AE3D0 Offset: 0x2AE4D1 VA: 0x2AE3D0
	// RVA: 0x1E15F20 Offset: 0x1E16021 VA: 0x1E15F20
	public void set_InitialDirectoryPath(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AE3E0 Offset: 0x2AE4E1 VA: 0x2AE3E0
	// RVA: 0x1E15F30 Offset: 0x1E16031 VA: 0x1E15F30
	public Action<string> get_OnSelect() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AE3F0 Offset: 0x2AE4F1 VA: 0x2AE3F0
	// RVA: 0x1E15F40 Offset: 0x1E16041 VA: 0x1E15F40
	public void set_OnSelect(Action<string> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AE400 Offset: 0x2AE501 VA: 0x2AE400
	// RVA: 0x1E15F50 Offset: 0x1E16051 VA: 0x1E15F50
	public Action get_OnCancel() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AE410 Offset: 0x2AE511 VA: 0x2AE410
	// RVA: 0x1E15F60 Offset: 0x1E16061 VA: 0x1E15F60
	public void set_OnCancel(Action value) { }
}

// Namespace: 
private class DebugPathMenu.EntryData // TypeDefIndex: 9107
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x286C30 Offset: 0x286D31 VA: 0x286C30
	private bool <IsDirectory>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x286C40 Offset: 0x286D41 VA: 0x286C40
	private string <Name>k__BackingField; // 0x18

	// Properties
	public bool IsDirectory { get; set; }
	public string Name { get; set; }

	// Methods

	// RVA: 0x1E14B70 Offset: 0x1E14C71 VA: 0x1E14B70
	public void .ctor(bool isDirectory, string name) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AE420 Offset: 0x2AE521 VA: 0x2AE420
	// RVA: 0x1E15220 Offset: 0x1E15321 VA: 0x1E15220
	public bool get_IsDirectory() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AE430 Offset: 0x2AE531 VA: 0x2AE430
	// RVA: 0x1E15230 Offset: 0x1E15331 VA: 0x1E15230
	public void set_IsDirectory(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AE440 Offset: 0x2AE541 VA: 0x2AE440
	// RVA: 0x1E15240 Offset: 0x1E15341 VA: 0x1E15240
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AE450 Offset: 0x2AE551 VA: 0x2AE450
	// RVA: 0x1E15250 Offset: 0x1E15351 VA: 0x1E15250
	public void set_Name(string value) { }
}

// Namespace: 
private class DebugPathMenu.EntryMenuItem : MenuItem // TypeDefIndex: 9108
{
	// Fields
	private const float MinWidth = 300;
	private DebugPathMenu.Setting m_Setting; // 0x20
	private string m_CurrentPath; // 0x28
	private DebugPathMenu.EntryData m_EntryData; // 0x30

	// Methods

	// RVA: 0x1E155C0 Offset: 0x1E156C1 VA: 0x1E155C0
	public void .ctor(DebugPathMenu.Setting setting, string currentPath, DebugPathMenu.EntryData entryData) { }

	// RVA: 0x1E15640 Offset: 0x1E15741 VA: 0x1E15640 Slot: 5
	public override string GetName() { }

	// RVA: 0x1E15650 Offset: 0x1E15751 VA: 0x1E15650 Slot: 7
	public override string GetHelp() { }

	// RVA: 0x1E15710 Offset: 0x1E15811 VA: 0x1E15710 Slot: 31
	public override float GetColumnWidth0() { }

	// RVA: 0x1E15740 Offset: 0x1E15841 VA: 0x1E15740 Slot: 12
	public override MenuItem.Result ACall() { }

	// RVA: 0x1E15A90 Offset: 0x1E15B91 VA: 0x1E15A90 Slot: 14
	public override MenuItem.Result XCall() { }

	// RVA: 0x1E15B20 Offset: 0x1E15C21 VA: 0x1E15B20 Slot: 13
	public override MenuItem.Result BCall() { }

	// RVA: 0x1E15970 Offset: 0x1E15A71 VA: 0x1E15970
	private MenuItem.Result Decide() { }

	// RVA: 0x1E15810 Offset: 0x1E15911 VA: 0x1E15810
	private MenuItem.Result MoveToParent() { }

	// RVA: 0x1E15920 Offset: 0x1E15A21 VA: 0x1E15920
	private MenuItem.Result MoveToSub() { }

	// RVA: 0x1E15DD0 Offset: 0x1E15ED1 VA: 0x1E15DD0
	private MenuItem.Result Cancel() { }
}

// Namespace: 
private class DebugPathMenu.PCDriveMenu // TypeDefIndex: 9109
{
	// Methods

	// RVA: 0x1E15BD0 Offset: 0x1E15CD1 VA: 0x1E15BD0
	public static void CreateBind(ProcInst super, DebugPathMenu.Setting setting) { }

	// RVA: 0x1E15E40 Offset: 0x1E15F41 VA: 0x1E15E40
	public void .ctor() { }
}

// Namespace: 
private class DebugPathMenu.EntryMenu // TypeDefIndex: 9110
{
	// Methods

	// RVA: 0x1E15260 Offset: 0x1E15361 VA: 0x1E15260
	public static void CreateBind(ProcInst super, DebugPathMenu.Setting setting, string parentPath, bool isRoot = False) { }

	// RVA: 0x1E15630 Offset: 0x1E15731 VA: 0x1E15630
	public void .ctor() { }
}

// Namespace: 
private class DebugPathMenu.CategoriesMenu.PCMenuItem : MenuItem // TypeDefIndex: 9111
{
	// Fields
	private DebugPathMenu.Setting m_Setting; // 0x20

	// Methods

	// RVA: 0x1DC1F00 Offset: 0x1DC2001 VA: 0x1DC1F00
	public void .ctor(DebugPathMenu.Setting setting) { }

	// RVA: 0x1DC1F40 Offset: 0x1DC2041 VA: 0x1DC1F40 Slot: 5
	public override string GetName() { }

	// RVA: 0x1DC1F90 Offset: 0x1DC2091 VA: 0x1DC1F90 Slot: 12
	public override MenuItem.Result ACall() { }
}

// Namespace: 
private class DebugPathMenu.CategoriesMenu.AssetsMenuItem : MenuItem // TypeDefIndex: 9112
{
	// Fields
	private DebugPathMenu.Setting m_Setting; // 0x20

	// Methods

	// RVA: 0x1DC1E20 Offset: 0x1DC1F21 VA: 0x1DC1E20
	public void .ctor(DebugPathMenu.Setting setting) { }

	// RVA: 0x1DC1E60 Offset: 0x1DC1F61 VA: 0x1DC1E60 Slot: 5
	public override string GetName() { }

	// RVA: 0x1DC1EB0 Offset: 0x1DC1FB1 VA: 0x1DC1EB0 Slot: 12
	public override MenuItem.Result ACall() { }
}

// Namespace: 
private class DebugPathMenu.CategoriesMenu // TypeDefIndex: 9113
{
	// Methods

	// RVA: 0x1E144A0 Offset: 0x1E145A1 VA: 0x1E144A0
	public static void CreateBind(ProcInst super, DebugPathMenu.Setting setting) { }

	// RVA: 0x1E145B0 Offset: 0x1E146B1 VA: 0x1E145B0
	public void .ctor() { }
}

// Namespace: 
private class DebugPathMenu.ShowError.ErrorMenuItem : MenuItem // TypeDefIndex: 9114
{
	// Fields
	private string m_Error; // 0x20

	// Methods

	// RVA: 0x1DC2050 Offset: 0x1DC2151 VA: 0x1DC2050
	public void .ctor(string error) { }

	// RVA: 0x1DC2090 Offset: 0x1DC2191 VA: 0x1DC2090 Slot: 5
	public override string GetName() { }

	// RVA: 0x1DC20A0 Offset: 0x1DC21A1 VA: 0x1DC20A0 Slot: 12
	public override MenuItem.Result ACall() { }

	// RVA: 0x1DC20B0 Offset: 0x1DC21B1 VA: 0x1DC20B0 Slot: 13
	public override MenuItem.Result BCall() { }
}

// Namespace: 
private class DebugPathMenu.ShowError // TypeDefIndex: 9115
{
	// Methods

	// RVA: 0x1E154D0 Offset: 0x1E155D1 VA: 0x1E154D0
	public static void CreateBind(ProcInst super, string message) { }

	// RVA: 0x1E15F70 Offset: 0x1E16071 VA: 0x1E15F70
	public void .ctor() { }
}

// Namespace: 
public class DebugPathMenu.Directory.EnumResult // TypeDefIndex: 9116
{
	// Fields
	public List<DebugPathMenu.EntryData> Entries; // 0x10
	public string ErrorMessage; // 0x18

	// Methods

	// RVA: 0x1DC1FC0 Offset: 0x1DC20C1 VA: 0x1DC1FC0
	public void .ctor(List<DebugPathMenu.EntryData> entries) { }

	// RVA: 0x1DC2000 Offset: 0x1DC2101 VA: 0x1DC2000
	public void .ctor(string errorMessage) { }

	// RVA: 0x1DC2040 Offset: 0x1DC2141 VA: 0x1DC2040
	public bool IsFailure() { }
}

// Namespace: 
private class DebugPathMenu.Directory // TypeDefIndex: 9117
{
	// Methods

	// RVA: 0x1E145C0 Offset: 0x1E146C1 VA: 0x1E145C0
	public static DebugPathMenu.Directory.EnumResult EnumEntries(DebugPathMenu.Setting setting, string path) { }

	// RVA: 0x1E148F0 Offset: 0x1E149F1 VA: 0x1E148F0
	public static bool IsExists(string path) { }

	// RVA: 0x1E145D0 Offset: 0x1E146D1 VA: 0x1E145D0
	private static DebugPathMenu.Directory.EnumResult EnumEntriesNX(DebugPathMenu.Setting setting, string path) { }

	// RVA: 0x1E149B0 Offset: 0x1E14AB1 VA: 0x1E149B0
	private static DebugPathMenu.EntryData MakeEntryDataNX(bool isDirectory, string entryName) { }

	// RVA: 0x1E14950 Offset: 0x1E14A51 VA: 0x1E14950
	private static bool IsExistsNX(string path) { }

	// RVA: 0x1E14BC0 Offset: 0x1E14CC1 VA: 0x1E14BC0
	private static DebugPathMenu.Directory.EnumResult EnumEntriesWin(DebugPathMenu.Setting setting, string path) { }

	// RVA: 0x1E14F90 Offset: 0x1E15091 VA: 0x1E14F90
	private static DebugPathMenu.EntryData MakeEntryDataWin(bool isDirectory, string fullPath) { }

	// RVA: 0x1E15200 Offset: 0x1E15301 VA: 0x1E15200
	private static bool IsExistsWin(string path) { }

	// RVA: 0x1E15210 Offset: 0x1E15311 VA: 0x1E15210
	public void .ctor() { }
}

// Namespace: 
private class DebugPathMenu.Path // TypeDefIndex: 9118
{
	// Methods

	// RVA: 0x1E14AC0 Offset: 0x1E14BC1 VA: 0x1E14AC0
	public static string NormalizeForDirectory(string originalPath) { }

	// RVA: 0x1E14B60 Offset: 0x1E14C61 VA: 0x1E14B60
	public static string NormalizeForFile(string originalPath) { }

	// RVA: 0x1E15E50 Offset: 0x1E15F51 VA: 0x1E15E50
	public static string NormalizePathSeparator(string originalPath) { }

	// RVA: 0x1E15B30 Offset: 0x1E15C31 VA: 0x1E15B30
	public static string GetParentDirectory(string originalPath) { }

	// RVA: 0x1E15080 Offset: 0x1E15181 VA: 0x1E15080
	public static string GetDirectoryName(string originalPath) { }

	// RVA: 0x1E15190 Offset: 0x1E15291 VA: 0x1E15190
	public static string GetFileName(string originalPath) { }

	// RVA: 0x1E15E60 Offset: 0x1E15F61 VA: 0x1E15E60
	public void .ctor() { }
}

