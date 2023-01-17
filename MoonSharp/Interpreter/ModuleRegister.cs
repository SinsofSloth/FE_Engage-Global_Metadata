// Namespace: MoonSharp.Interpreter
[ExtensionAttribute] // RVA: 0xD5F0 Offset: 0xD6F1 VA: 0xD5F0
public static class ModuleRegister // TypeDefIndex: 5979
{
	// Methods

	[ExtensionAttribute] // RVA: 0xFC80 Offset: 0xFD81 VA: 0xFC80
	// RVA: 0x2BB7D60 Offset: 0x2BB7E61 VA: 0x2BB7D60
	public static Table RegisterCoreModules(Table table, CoreModules modules) { }

	[ExtensionAttribute] // RVA: 0xFC90 Offset: 0xFD91 VA: 0xFC90
	// RVA: 0x2BB8230 Offset: 0x2BB8331 VA: 0x2BB8230
	public static Table RegisterConstants(Table table) { }

	[ExtensionAttribute] // RVA: 0xFCA0 Offset: 0xFDA1 VA: 0xFCA0
	// RVA: 0x2BB8880 Offset: 0x2BB8981 VA: 0x2BB8880
	public static Table RegisterModuleType(Table gtable, Type t) { }

	// RVA: 0x2BB9FC0 Offset: 0x2BBA0C1 VA: 0x2BB9FC0
	private static void RegisterScriptFieldAsConst(FieldInfo fi, object o, Table table, Type t, string name) { }

	// RVA: 0x2BB9E30 Offset: 0x2BB9F31 VA: 0x2BB9E30
	private static void RegisterScriptField(FieldInfo fi, object o, Table table, Type t, string name) { }

	// RVA: 0x2BB9A70 Offset: 0x2BB9B71 VA: 0x2BB9A70
	private static Table CreateModuleNamespace(Table gtable, Type t) { }

	[ExtensionAttribute] // RVA: 0xFCB0 Offset: 0xFDB1 VA: 0xFCB0
	// RVA: -1 Offset: -1
	public static Table RegisterModuleType<T>(Table table) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2966E30 Offset: 0x2966F31 VA: 0x2966E30
	|-ModuleRegister.RegisterModuleType<BasicModule>
	|-ModuleRegister.RegisterModuleType<Bit32Module>
	|-ModuleRegister.RegisterModuleType<CoroutineModule>
	|-ModuleRegister.RegisterModuleType<DebugModule>
	|-ModuleRegister.RegisterModuleType<DynamicModule>
	|-ModuleRegister.RegisterModuleType<ErrorHandlingModule>
	|-ModuleRegister.RegisterModuleType<IoModule>
	|-ModuleRegister.RegisterModuleType<JsonModule>
	|-ModuleRegister.RegisterModuleType<LoadModule>
	|-ModuleRegister.RegisterModuleType<MathModule>
	|-ModuleRegister.RegisterModuleType<MetaTableModule>
	|-ModuleRegister.RegisterModuleType<object>
	|-ModuleRegister.RegisterModuleType<OsSystemModule>
	|-ModuleRegister.RegisterModuleType<OsTimeModule>
	|-ModuleRegister.RegisterModuleType<StringModule>
	|-ModuleRegister.RegisterModuleType<TableIteratorsModule>
	|-ModuleRegister.RegisterModuleType<TableModule>
	|-ModuleRegister.RegisterModuleType<TableModule_Globals>
	*/
}

