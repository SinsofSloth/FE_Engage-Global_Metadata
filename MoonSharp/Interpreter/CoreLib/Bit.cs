// Namespace: MoonSharp.Interpreter.CoreLib
[MoonSharpModuleAttribute] // RVA: 0xDAE0 Offset: 0xDBE1 VA: 0xDAE0
public class Bit32Module // TypeDefIndex: 6230
{
	// Fields
	private static readonly uint[] MASKS; // 0x0

	// Methods

	// RVA: 0x30EE1B0 Offset: 0x30EE2B1 VA: 0x30EE1B0
	private static uint ToUInt32(DynValue v) { }

	// RVA: 0x30EE260 Offset: 0x30EE361 VA: 0x30EE260
	private static int ToInt32(DynValue v) { }

	// RVA: 0x30EE310 Offset: 0x30EE411 VA: 0x30EE310
	private static uint NBitMask(int bits) { }

	// RVA: 0x30EE400 Offset: 0x30EE501 VA: 0x30EE400
	public static uint Bitwise(string funcName, CallbackArguments args, Func<uint, uint, uint> accumFunc) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x116F0 Offset: 0x117F1 VA: 0x116F0
	// RVA: 0x30EE640 Offset: 0x30EE741 VA: 0x30EE640
	public static DynValue extract(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11700 Offset: 0x11801 VA: 0x11700
	// RVA: 0x30EEB70 Offset: 0x30EEC71 VA: 0x30EEB70
	public static DynValue replace(ScriptExecutionContext executionContext, CallbackArguments args) { }

	// RVA: 0x30EE9A0 Offset: 0x30EEAA1 VA: 0x30EE9A0
	private static void ValidatePosWidth(string func, int argPos, int pos, int width) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11710 Offset: 0x11811 VA: 0x11710
	// RVA: 0x30EEEC0 Offset: 0x30EEFC1 VA: 0x30EEEC0
	public static DynValue arshift(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11720 Offset: 0x11821 VA: 0x11720
	// RVA: 0x30EF070 Offset: 0x30EF171 VA: 0x30EF070
	public static DynValue rshift(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11730 Offset: 0x11831 VA: 0x11730
	// RVA: 0x30EF220 Offset: 0x30EF321 VA: 0x30EF220
	public static DynValue lshift(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11740 Offset: 0x11841 VA: 0x11740
	// RVA: 0x30EF3D0 Offset: 0x30EF4D1 VA: 0x30EF3D0
	public static DynValue band(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11750 Offset: 0x11851 VA: 0x11750
	// RVA: 0x30EF560 Offset: 0x30EF661 VA: 0x30EF560
	public static DynValue btest(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11760 Offset: 0x11861 VA: 0x11760
	// RVA: 0x30EF700 Offset: 0x30EF801 VA: 0x30EF700
	public static DynValue bor(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11770 Offset: 0x11871 VA: 0x11770
	// RVA: 0x30EF890 Offset: 0x30EF991 VA: 0x30EF890
	public static DynValue bnot(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11780 Offset: 0x11881 VA: 0x11780
	// RVA: 0x30EF9F0 Offset: 0x30EFAF1 VA: 0x30EF9F0
	public static DynValue bxor(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x11790 Offset: 0x11891 VA: 0x11790
	// RVA: 0x30EFB80 Offset: 0x30EFC81 VA: 0x30EFB80
	public static DynValue lrotate(ScriptExecutionContext executionContext, CallbackArguments args) { }

	[MoonSharpModuleMethodAttribute] // RVA: 0x117A0 Offset: 0x118A1 VA: 0x117A0
	// RVA: 0x30EFD40 Offset: 0x30EFE41 VA: 0x30EFD40
	public static DynValue rrotate(ScriptExecutionContext executionContext, CallbackArguments args) { }

	// RVA: 0x30EFF00 Offset: 0x30F0001 VA: 0x30EFF00
	public void .ctor() { }

	// RVA: 0x30EFF10 Offset: 0x30F0011 VA: 0x30EFF10
	private static void .cctor() { }
}

