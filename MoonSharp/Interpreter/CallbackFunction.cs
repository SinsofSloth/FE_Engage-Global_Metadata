// Namespace: MoonSharp.Interpreter
public sealed class CallbackFunction : RefIdObject // TypeDefIndex: 5926
{
	// Fields
	private static InteropAccessMode m_DefaultAccessMode; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0xE1C0 Offset: 0xE2C1 VA: 0xE1C0
	private string <Name>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0xE1D0 Offset: 0xE2D1 VA: 0xE1D0
	private Func<ScriptExecutionContext, CallbackArguments, DynValue> <ClrCallback>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0xE1E0 Offset: 0xE2E1 VA: 0xE1E0
	private object <AdditionalData>k__BackingField; // 0x28

	// Properties
	public string Name { get; set; }
	public Func<ScriptExecutionContext, CallbackArguments, DynValue> ClrCallback { get; set; }
	public static InteropAccessMode DefaultAccessMode { get; set; }
	public object AdditionalData { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0xF3F0 Offset: 0xF4F1 VA: 0xF3F0
	// RVA: 0x30F5440 Offset: 0x30F5541 VA: 0x30F5440
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0xF400 Offset: 0xF501 VA: 0xF400
	// RVA: 0x30F5450 Offset: 0x30F5551 VA: 0x30F5450
	private void set_Name(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0xF410 Offset: 0xF511 VA: 0xF410
	// RVA: 0x30F5460 Offset: 0x30F5561 VA: 0x30F5460
	public Func<ScriptExecutionContext, CallbackArguments, DynValue> get_ClrCallback() { }

	[CompilerGeneratedAttribute] // RVA: 0xF420 Offset: 0xF521 VA: 0xF420
	// RVA: 0x30F5470 Offset: 0x30F5571 VA: 0x30F5470
	private void set_ClrCallback(Func<ScriptExecutionContext, CallbackArguments, DynValue> value) { }

	// RVA: 0x30EAD60 Offset: 0x30EAE61 VA: 0x30EAD60
	public void .ctor(Func<ScriptExecutionContext, CallbackArguments, DynValue> callBack, string name) { }

	// RVA: 0x30F5480 Offset: 0x30F5581 VA: 0x30F5480
	public DynValue Invoke(ScriptExecutionContext executionContext, IList<DynValue> args, bool isMethodCall = False) { }

	// RVA: 0x30F5650 Offset: 0x30F5751 VA: 0x30F5650
	public static InteropAccessMode get_DefaultAccessMode() { }

	// RVA: 0x30F56C0 Offset: 0x30F57C1 VA: 0x30F56C0
	public static void set_DefaultAccessMode(InteropAccessMode value) { }

	// RVA: 0x30F5790 Offset: 0x30F5891 VA: 0x30F5790
	public static CallbackFunction FromDelegate(Script script, Delegate del, InteropAccessMode accessMode = 7) { }

	// RVA: 0x30F5870 Offset: 0x30F5971 VA: 0x30F5870
	public static CallbackFunction FromMethodInfo(Script script, MethodInfo mi, object obj, InteropAccessMode accessMode = 7) { }

	[CompilerGeneratedAttribute] // RVA: 0xF430 Offset: 0xF531 VA: 0xF430
	// RVA: 0x30F5940 Offset: 0x30F5A41 VA: 0x30F5940
	public object get_AdditionalData() { }

	[CompilerGeneratedAttribute] // RVA: 0xF440 Offset: 0xF541 VA: 0xF440
	// RVA: 0x30F5950 Offset: 0x30F5A51 VA: 0x30F5950
	public void set_AdditionalData(object value) { }

	// RVA: 0x30F5960 Offset: 0x30F5A61 VA: 0x30F5960
	public static bool CheckCallbackSignature(MethodInfo mi, bool requirePublicVisibility) { }

	// RVA: 0x30F5B50 Offset: 0x30F5C51 VA: 0x30F5B50
	private static void .cctor() { }
}

