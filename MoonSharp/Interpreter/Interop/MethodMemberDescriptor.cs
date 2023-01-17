// Namespace: MoonSharp.Interpreter.Interop
public class MethodMemberDescriptor : FunctionMemberDescriptorBase, IOptimizableDescriptor, IWireableDescriptor // TypeDefIndex: 6113
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xE820 Offset: 0xE921 VA: 0xE820
	private MethodBase <MethodInfo>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0xE830 Offset: 0xE931 VA: 0xE830
	private InteropAccessMode <AccessMode>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0xE840 Offset: 0xE941 VA: 0xE840
	private bool <IsConstructor>k__BackingField; // 0x54
	private Func<object, object[], object> m_OptimizedFunc; // 0x58
	private Action<object, object[]> m_OptimizedAction; // 0x60
	private bool m_IsAction; // 0x68
	private bool m_IsArrayCtor; // 0x69

	// Properties
	public MethodBase MethodInfo { get; set; }
	public InteropAccessMode AccessMode { get; set; }
	public bool IsConstructor { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x108A0 Offset: 0x109A1 VA: 0x108A0
	// RVA: 0x2BB5A80 Offset: 0x2BB5B81 VA: 0x2BB5A80
	public MethodBase get_MethodInfo() { }

	[CompilerGeneratedAttribute] // RVA: 0x108B0 Offset: 0x109B1 VA: 0x108B0
	// RVA: 0x2BB5A90 Offset: 0x2BB5B91 VA: 0x2BB5A90
	private void set_MethodInfo(MethodBase value) { }

	[CompilerGeneratedAttribute] // RVA: 0x108C0 Offset: 0x109C1 VA: 0x108C0
	// RVA: 0x2BB5AA0 Offset: 0x2BB5BA1 VA: 0x2BB5AA0
	public InteropAccessMode get_AccessMode() { }

	[CompilerGeneratedAttribute] // RVA: 0x108D0 Offset: 0x109D1 VA: 0x108D0
	// RVA: 0x2BB5AB0 Offset: 0x2BB5BB1 VA: 0x2BB5AB0
	private void set_AccessMode(InteropAccessMode value) { }

	[CompilerGeneratedAttribute] // RVA: 0x108E0 Offset: 0x109E1 VA: 0x108E0
	// RVA: 0x2BB5AC0 Offset: 0x2BB5BC1 VA: 0x2BB5AC0
	public bool get_IsConstructor() { }

	[CompilerGeneratedAttribute] // RVA: 0x108F0 Offset: 0x109F1 VA: 0x108F0
	// RVA: 0x2BB5AD0 Offset: 0x2BB5BD1 VA: 0x2BB5AD0
	private void set_IsConstructor(bool value) { }

	// RVA: 0x2BB5AE0 Offset: 0x2BB5BE1 VA: 0x2BB5AE0
	public void .ctor(MethodBase methodBase, InteropAccessMode accessMode = 7) { }

	// RVA: 0x2BB67A0 Offset: 0x2BB68A1 VA: 0x2BB67A0
	public static MethodMemberDescriptor TryCreateIfVisible(MethodBase methodBase, InteropAccessMode accessMode, bool forceVisibility = False) { }

	// RVA: 0x2BB6390 Offset: 0x2BB6491 VA: 0x2BB6390
	public static bool CheckMethodIsCompatible(MethodBase methodBase, bool throwException) { }

	// RVA: 0x2BB6880 Offset: 0x2BB6981 VA: 0x2BB6880 Slot: 16
	public override DynValue Execute(Script script, object obj, ScriptExecutionContext context, CallbackArguments args) { }

	// RVA: 0x2BB6B30 Offset: 0x2BB6C31 VA: 0x2BB6B30 Slot: 19
	private void MoonSharp.Interpreter.Interop.BasicDescriptors.IOptimizableDescriptor.Optimize() { }

	// RVA: 0x2BB7480 Offset: 0x2BB7581 VA: 0x2BB7480 Slot: 20
	public void PrepareForWiring(Table t) { }
}

