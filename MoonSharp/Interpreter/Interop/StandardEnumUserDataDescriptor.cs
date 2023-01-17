// Namespace: MoonSharp.Interpreter.Interop
public class StandardEnumUserDataDescriptor : DispatchingUserDataDescriptor // TypeDefIndex: 6124
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xE8F0 Offset: 0xE9F1 VA: 0xE8F0
	private Type <UnderlyingType>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0xE900 Offset: 0xEA01 VA: 0xE900
	private bool <IsUnsigned>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0xE910 Offset: 0xEA11 VA: 0xE910
	private bool <IsFlags>k__BackingField; // 0x49
	private Func<object, ulong> m_EnumToULong; // 0x50
	private Func<ulong, object> m_ULongToEnum; // 0x58
	private Func<object, long> m_EnumToLong; // 0x60
	private Func<long, object> m_LongToEnum; // 0x68

	// Properties
	public Type UnderlyingType { get; set; }
	public bool IsUnsigned { get; set; }
	public bool IsFlags { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x10A40 Offset: 0x10B41 VA: 0x10A40
	// RVA: 0x3020E50 Offset: 0x3020F51 VA: 0x3020E50
	public Type get_UnderlyingType() { }

	[CompilerGeneratedAttribute] // RVA: 0x10A50 Offset: 0x10B51 VA: 0x10A50
	// RVA: 0x3020E60 Offset: 0x3020F61 VA: 0x3020E60
	private void set_UnderlyingType(Type value) { }

	[CompilerGeneratedAttribute] // RVA: 0x10A60 Offset: 0x10B61 VA: 0x10A60
	// RVA: 0x3020E70 Offset: 0x3020F71 VA: 0x3020E70
	public bool get_IsUnsigned() { }

	[CompilerGeneratedAttribute] // RVA: 0x10A70 Offset: 0x10B71 VA: 0x10A70
	// RVA: 0x3020E80 Offset: 0x3020F81 VA: 0x3020E80
	private void set_IsUnsigned(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x10A80 Offset: 0x10B81 VA: 0x10A80
	// RVA: 0x3020E90 Offset: 0x3020F91 VA: 0x3020E90
	public bool get_IsFlags() { }

	[CompilerGeneratedAttribute] // RVA: 0x10A90 Offset: 0x10B91 VA: 0x10A90
	// RVA: 0x3020EA0 Offset: 0x3020FA1 VA: 0x3020EA0
	private void set_IsFlags(bool value) { }

	// RVA: 0x3020EB0 Offset: 0x3020FB1 VA: 0x3020EB0
	public void .ctor(Type enumType, string friendlyName, string[] names, object[] values, Type underlyingType) { }

	// RVA: 0x30212A0 Offset: 0x30213A1 VA: 0x30212A0
	private void FillMemberList(string[] names, object[] values) { }

	// RVA: 0x3021770 Offset: 0x3021871 VA: 0x3021770
	private void AddEnumMethod(string name, DynValue dynValue) { }

	// RVA: 0x3021840 Offset: 0x3021941 VA: 0x3021840
	private long GetValueSigned(DynValue dv) { }

	// RVA: 0x3022150 Offset: 0x3022251 VA: 0x3022150
	private ulong GetValueUnsigned(DynValue dv) { }

	// RVA: 0x3022A50 Offset: 0x3022B51 VA: 0x3022A50
	private DynValue CreateValueSigned(long value) { }

	// RVA: 0x3022B00 Offset: 0x3022C01 VA: 0x3022B00
	private DynValue CreateValueUnsigned(ulong value) { }

	// RVA: 0x3021970 Offset: 0x3021A71 VA: 0x3021970
	private void CreateSignedConversionFunctions() { }

	// RVA: 0x3022270 Offset: 0x3022371 VA: 0x3022270
	private void CreateUnsignedConversionFunctions() { }

	// RVA: 0x3022BB0 Offset: 0x3022CB1 VA: 0x3022BB0
	private DynValue PerformBinaryOperationS(string funcName, ScriptExecutionContext ctx, CallbackArguments args, Func<long, long, DynValue> operation) { }

	// RVA: 0x3022CE0 Offset: 0x3022DE1 VA: 0x3022CE0
	private DynValue PerformBinaryOperationU(string funcName, ScriptExecutionContext ctx, CallbackArguments args, Func<ulong, ulong, DynValue> operation) { }

	// RVA: 0x3022E10 Offset: 0x3022F11 VA: 0x3022E10
	private DynValue PerformBinaryOperationS(string funcName, ScriptExecutionContext ctx, CallbackArguments args, Func<long, long, long> operation) { }

	// RVA: 0x3022F20 Offset: 0x3023021 VA: 0x3022F20
	private DynValue PerformBinaryOperationU(string funcName, ScriptExecutionContext ctx, CallbackArguments args, Func<ulong, ulong, ulong> operation) { }

	// RVA: 0x3023030 Offset: 0x3023131 VA: 0x3023030
	private DynValue PerformUnaryOperationS(string funcName, ScriptExecutionContext ctx, CallbackArguments args, Func<long, long> operation) { }

	// RVA: 0x3023150 Offset: 0x3023251 VA: 0x3023150
	private DynValue PerformUnaryOperationU(string funcName, ScriptExecutionContext ctx, CallbackArguments args, Func<ulong, ulong> operation) { }

	// RVA: 0x3023270 Offset: 0x3023371 VA: 0x3023270
	internal DynValue Callback_Or(ScriptExecutionContext ctx, CallbackArguments args) { }

	// RVA: 0x30234A0 Offset: 0x30235A1 VA: 0x30234A0
	internal DynValue Callback_And(ScriptExecutionContext ctx, CallbackArguments args) { }

	// RVA: 0x30236D0 Offset: 0x30237D1 VA: 0x30236D0
	internal DynValue Callback_Xor(ScriptExecutionContext ctx, CallbackArguments args) { }

	// RVA: 0x3023900 Offset: 0x3023A01 VA: 0x3023900
	internal DynValue Callback_BwNot(ScriptExecutionContext ctx, CallbackArguments args) { }

	// RVA: 0x3023B30 Offset: 0x3023C31 VA: 0x3023B30
	internal DynValue Callback_HasAll(ScriptExecutionContext ctx, CallbackArguments args) { }

	// RVA: 0x3023D60 Offset: 0x3023E61 VA: 0x3023D60
	internal DynValue Callback_HasAny(ScriptExecutionContext ctx, CallbackArguments args) { }

	// RVA: 0x3023F90 Offset: 0x3024091 VA: 0x3023F90 Slot: 19
	public override bool IsTypeCompatible(Type type, object obj) { }

	// RVA: 0x3024030 Offset: 0x3024131 VA: 0x3024030 Slot: 18
	public override DynValue MetaIndex(Script script, object obj, string metaname) { }
}

