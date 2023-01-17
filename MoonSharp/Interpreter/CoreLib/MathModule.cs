// Namespace: MoonSharp.Interpreter.CoreLib
[MoonSharpModuleAttribute] // RVA: 0xDD00 Offset: 0xDE01 VA: 0xDD00
public class MathModule // TypeDefIndex: 6241
{
	// Fields
	[MoonSharpModuleConstantAttribute] // RVA: 0xEDE0 Offset: 0xEEE1 VA: 0xEDE0
	public const double pi = 3.141592653589793;
	[MoonSharpModuleConstantAttribute] // RVA: 0xEDF0 Offset: 0xEEF1 VA: 0xEDF0
	public const double huge = 1.7976931348623157E+308;

	// Methods

	// RVA: 0x2BB1EE0 Offset: 0x2BB1FE1 VA: 0x2BB1EE0
	private static Random GetRandom(Script s) { }

	// RVA: 0x2BB1F90 Offset: 0x2BB2091 VA: 0x2BB1F90
	private static void SetRandom(Script s, Random random) { }

	// RVA: 0x2BB2070 Offset: 0x2BB2171 VA: 0x2BB2070
	public static void MoonSharpInit(Table globalTable, Table ioTable) { }

	// RVA: 0x2BB20E0 Offset: 0x2BB21E1 VA: 0x2BB20E0
	private static DynValue exec1(CallbackArguments args, string funcName, Func<double, double> func) { }

	// RVA: 0x2BB21B0 Offset: 0x2BB22B1 VA: 0x2BB21B0
	private static DynValue exec2(CallbackArguments args, string funcName, Func<double, double, double> func) { }

	// RVA: 0x2BB22A0 Offset: 0x2BB23A1 VA: 0x2BB22A0
	private static DynValue exec2n(CallbackArguments args, string funcName, double defVal, Func<double, double, double> func) { }

	// RVA: 0x2BB23B0 Offset: 0x2BB24B1 VA: 0x2BB23B0
	private static DynValue execaccum(CallbackArguments args, string funcName, Func<double, double, double> func) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11A40 Offset: 0x11B41 VA: 0x11A40
	// RVA: 0x2BB2560 Offset: 0x2BB2661 VA: 0x2BB2560
	public static DynValue abs(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11A50 Offset: 0x11B51 VA: 0x11A50
	// RVA: 0x2BB26A0 Offset: 0x2BB27A1 VA: 0x2BB26A0
	public static DynValue acos(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11A60 Offset: 0x11B61 VA: 0x11A60
	// RVA: 0x2BB27E0 Offset: 0x2BB28E1 VA: 0x2BB27E0
	public static DynValue asin(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11A70 Offset: 0x11B71 VA: 0x11A70
	// RVA: 0x2BB2920 Offset: 0x2BB2A21 VA: 0x2BB2920
	public static DynValue atan(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11A80 Offset: 0x11B81 VA: 0x11A80
	// RVA: 0x2BB2A60 Offset: 0x2BB2B61 VA: 0x2BB2A60
	public static DynValue atan2(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11A90 Offset: 0x11B91 VA: 0x11A90
	// RVA: 0x2BB2BA0 Offset: 0x2BB2CA1 VA: 0x2BB2BA0
	public static DynValue ceil(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11AA0 Offset: 0x11BA1 VA: 0x11AA0
	// RVA: 0x2BB2CE0 Offset: 0x2BB2DE1 VA: 0x2BB2CE0
	public static DynValue cos(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11AB0 Offset: 0x11BB1 VA: 0x11AB0
	// RVA: 0x2BB2E20 Offset: 0x2BB2F21 VA: 0x2BB2E20
	public static DynValue cosh(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11AC0 Offset: 0x11BC1 VA: 0x11AC0
	// RVA: 0x2BB2F60 Offset: 0x2BB3061 VA: 0x2BB2F60
	public static DynValue deg(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11AD0 Offset: 0x11BD1 VA: 0x11AD0
	// RVA: 0x2BB30A0 Offset: 0x2BB31A1 VA: 0x2BB30A0
	public static DynValue exp(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11AE0 Offset: 0x11BE1 VA: 0x11AE0
	// RVA: 0x2BB31E0 Offset: 0x2BB32E1 VA: 0x2BB31E0
	public static DynValue floor(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11AF0 Offset: 0x11BF1 VA: 0x11AF0
	// RVA: 0x2BB3320 Offset: 0x2BB3421 VA: 0x2BB3320
	public static DynValue fmod(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11B00 Offset: 0x11C01 VA: 0x11B00
	// RVA: 0x2BB3460 Offset: 0x2BB3561 VA: 0x2BB3460
	public static DynValue frexp(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11B10 Offset: 0x11C11 VA: 0x11B10
	// RVA: 0x2BB3710 Offset: 0x2BB3811 VA: 0x2BB3710
	public static DynValue ldexp(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11B20 Offset: 0x11C21 VA: 0x11B20
	// RVA: 0x2BB3850 Offset: 0x2BB3951 VA: 0x2BB3850
	public static DynValue log(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11B30 Offset: 0x11C31 VA: 0x11B30
	// RVA: 0x2BB39B0 Offset: 0x2BB3AB1 VA: 0x2BB39B0
	public static DynValue max(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11B40 Offset: 0x11C41 VA: 0x11B40
	// RVA: 0x2BB3AF0 Offset: 0x2BB3BF1 VA: 0x2BB3AF0
	public static DynValue min(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11B50 Offset: 0x11C51 VA: 0x11B50
	// RVA: 0x2BB3C30 Offset: 0x2BB3D31 VA: 0x2BB3C30
	public static DynValue modf(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11B60 Offset: 0x11C61 VA: 0x11B60
	// RVA: 0x2BB3DF0 Offset: 0x2BB3EF1 VA: 0x2BB3DF0
	public static DynValue pow(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11B70 Offset: 0x11C71 VA: 0x11B70
	// RVA: 0x2BB3F30 Offset: 0x2BB4031 VA: 0x2BB3F30
	public static DynValue rad(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11B80 Offset: 0x11C81 VA: 0x11B80
	// RVA: 0x2BB4070 Offset: 0x2BB4171 VA: 0x2BB4070
	public static DynValue random(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11B90 Offset: 0x11C91 VA: 0x11B90
	// RVA: 0x2BB42D0 Offset: 0x2BB43D1 VA: 0x2BB42D0
	public static DynValue randomseed(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11BA0 Offset: 0x11CA1 VA: 0x11BA0
	// RVA: 0x2BB4450 Offset: 0x2BB4551 VA: 0x2BB4450
	public static DynValue sin(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11BB0 Offset: 0x11CB1 VA: 0x11BB0
	// RVA: 0x2BB4590 Offset: 0x2BB4691 VA: 0x2BB4590
	public static DynValue sinh(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11BC0 Offset: 0x11CC1 VA: 0x11BC0
	// RVA: 0x2BB46D0 Offset: 0x2BB47D1 VA: 0x2BB46D0
	public static DynValue sqrt(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11BD0 Offset: 0x11CD1 VA: 0x11BD0
	// RVA: 0x2BB4810 Offset: 0x2BB4911 VA: 0x2BB4810
	public static DynValue tan(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11BE0 Offset: 0x11CE1 VA: 0x11BE0
	// RVA: 0x2BB4950 Offset: 0x2BB4A51 VA: 0x2BB4950
	public static DynValue tanh(ScriptExecutionContext executionContext, CallbackArguments args) { }

	// RVA: 0x2BB4A90 Offset: 0x2BB4B91 VA: 0x2BB4A90
	public void .ctor() { }
}

