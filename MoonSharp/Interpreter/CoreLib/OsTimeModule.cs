// Namespace: MoonSharp.Interpreter.CoreLib
[MoonSharpModuleAttribute] // RVA: 0xDDC0 Offset: 0xDEC1 VA: 0xDDC0
public class OsTimeModule // TypeDefIndex: 6244
{
	// Fields
	private static DateTime Time0; // 0x0
	private static DateTime Epoch; // 0x8

	// Methods

	// RVA: 0x2BC3AE0 Offset: 0x2BC3BE1 VA: 0x2BC3AE0
	private static DynValue GetUnixTime(DateTime dateTime, Nullable<DateTime> epoch) { }

	// RVA: 0x2BC3C90 Offset: 0x2BC3D91 VA: 0x2BC3C90
	private static DateTime FromUnixTime(double unixtime) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11CC0 Offset: 0x11DC1 VA: 0x11CC0
	// RVA: 0x2BC3D80 Offset: 0x2BC3E81 VA: 0x2BC3D80
	public static DynValue clock(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11CD0 Offset: 0x11DD1 VA: 0x11CD0
	// RVA: 0x2BC3E60 Offset: 0x2BC3F61 VA: 0x2BC3E60
	public static DynValue difftime(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11CE0 Offset: 0x11DE1 VA: 0x11CE0
	// RVA: 0x2BC3F60 Offset: 0x2BC4061 VA: 0x2BC3F60
	public static DynValue time(ScriptExecutionContext executionContext, CallbackArguments args) { }

	// RVA: 0x2BC4080 Offset: 0x2BC4181 VA: 0x2BC4080
	private static DateTime ParseTimeTable(Table t) { }

	// RVA: 0x2BC4330 Offset: 0x2BC4431 VA: 0x2BC4330
	private static Nullable<int> GetTimeTableField(Table t, string key) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11CF0 Offset: 0x11DF1 VA: 0x11CF0
	// RVA: 0x2BC4410 Offset: 0x2BC4511 VA: 0x2BC4410
	public static DynValue date(ScriptExecutionContext executionContext, CallbackArguments args) { }

	// RVA: 0x2BC49A0 Offset: 0x2BC4AA1 VA: 0x2BC49A0
	private static string StrFTime(string format, DateTime d) { }

	// RVA: 0x2BC5120 Offset: 0x2BC5221 VA: 0x2BC5120
	public void .ctor() { }

	// RVA: 0x2BC5130 Offset: 0x2BC5231 VA: 0x2BC5130
	private static void .cctor() { }
}

