// Namespace: MoonSharp.Interpreter.CoreLib
[MoonSharpModuleAttribute] // RVA: 0xDC40 Offset: 0xDD41 VA: 0xDC40
public class IoModule // TypeDefIndex: 6237
{
	// Methods

	// RVA: 0x3319200 Offset: 0x3319301 VA: 0x3319200
	public static void MoonSharpInit(Table globalTable, Table ioTable) { }

	// RVA: 0x3319690 Offset: 0x3319791 VA: 0x3319690
	private static DynValue __index_callback(ScriptExecutionContext executionContext, CallbackArguments args) { }

	// RVA: 0x3319830 Offset: 0x3319931 VA: 0x3319830
	private static DynValue GetStandardFile(Script S, StandardFileType file) { }

	// RVA: 0x3319440 Offset: 0x3319541 VA: 0x3319440
	private static void SetStandardFile(Script S, StandardFileType file, Stream optionsStream) { }

	// RVA: 0x3319900 Offset: 0x3319A01 VA: 0x3319900
	private static FileUserDataBase GetDefaultFile(ScriptExecutionContext executionContext, StandardFileType file) { }

	// RVA: 0x3319AA0 Offset: 0x3319BA1 VA: 0x3319AA0
	private static void SetDefaultFile(ScriptExecutionContext executionContext, StandardFileType file, FileUserDataBase fileHandle) { }

	// RVA: 0x3319AD0 Offset: 0x3319BD1 VA: 0x3319AD0
	internal static void SetDefaultFile(Script script, StandardFileType file, FileUserDataBase fileHandle) { }

	// RVA: 0x3319BF0 Offset: 0x3319CF1 VA: 0x3319BF0
	public static void SetDefaultFile(Script script, StandardFileType file, Stream stream) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11900 Offset: 0x11A01 VA: 0x11900
	// RVA: 0x3319C40 Offset: 0x3319D41 VA: 0x3319C40
	public static DynValue close(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11910 Offset: 0x11A11 VA: 0x11910
	// RVA: 0x3319CE0 Offset: 0x3319DE1 VA: 0x3319CE0
	public static DynValue flush(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11920 Offset: 0x11A21 VA: 0x11920
	// RVA: 0x3319E20 Offset: 0x3319F21 VA: 0x3319E20
	public static DynValue input(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11930 Offset: 0x11A31 VA: 0x11930
	// RVA: 0x331A0A0 Offset: 0x331A1A1 VA: 0x331A0A0
	public static DynValue output(ScriptExecutionContext executionContext, CallbackArguments args) { }

	// RVA: 0x3319E30 Offset: 0x3319F31 VA: 0x3319E30
	private static DynValue HandleDefaultStreamSetter(ScriptExecutionContext executionContext, CallbackArguments args, StandardFileType defaultFiles) { }

	// RVA: 0x331A0B0 Offset: 0x331A1B1 VA: 0x331A0B0
	private static Encoding GetUTF8Encoding() { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11940 Offset: 0x11A41 VA: 0x11940
	// RVA: 0x331A1B0 Offset: 0x331A2B1 VA: 0x331A1B0
	public static DynValue lines(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11950 Offset: 0x11A51 VA: 0x11950
	// RVA: 0x331A990 Offset: 0x331AA91 VA: 0x331A990
	public static DynValue open(ScriptExecutionContext executionContext, CallbackArguments args) { }

	// RVA: 0x331A8D0 Offset: 0x331A9D1 VA: 0x331A8D0
	public static string IoExceptionToLuaMessage(Exception ex, string filename) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11960 Offset: 0x11A61 VA: 0x11960
	// RVA: 0x331B0D0 Offset: 0x331B1D1 VA: 0x331B0D0
	public static DynValue type(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11970 Offset: 0x11A71 VA: 0x11970
	// RVA: 0x331B290 Offset: 0x331B391 VA: 0x331B290
	public static DynValue read(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11980 Offset: 0x11A81 VA: 0x11980
	// RVA: 0x331B2C0 Offset: 0x331B3C1 VA: 0x331B2C0
	public static DynValue write(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11990 Offset: 0x11A91 VA: 0x11990
	// RVA: 0x331B2F0 Offset: 0x331B3F1 VA: 0x331B2F0
	public static DynValue tmpfile(ScriptExecutionContext executionContext, CallbackArguments args) { }

	// RVA: 0x331A110 Offset: 0x331A211 VA: 0x331A110
	private static FileUserDataBase Open(ScriptExecutionContext executionContext, string filename, Encoding encoding, string mode) { }

	// RVA: 0x331B520 Offset: 0x331B621 VA: 0x331B520
	public void .ctor() { }
}

