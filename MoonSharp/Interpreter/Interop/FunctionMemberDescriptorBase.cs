// Namespace: MoonSharp.Interpreter.Interop
public abstract class FunctionMemberDescriptorBase : IOverloadableMemberDescriptor, IMemberDescriptor // TypeDefIndex: 6087
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xE720 Offset: 0xE821 VA: 0xE720
	private bool <IsStatic>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0xE730 Offset: 0xE831 VA: 0xE730
	private string <Name>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0xE740 Offset: 0xE841 VA: 0xE740
	private string <SortDiscriminant>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0xE750 Offset: 0xE851 VA: 0xE750
	private ParameterDescriptor[] <Parameters>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0xE760 Offset: 0xE861 VA: 0xE760
	private Type <ExtensionMethodType>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0xE770 Offset: 0xE871 VA: 0xE770
	private Type <VarArgsArrayType>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0xE780 Offset: 0xE881 VA: 0xE780
	private Type <VarArgsElementType>k__BackingField; // 0x40

	// Properties
	public bool IsStatic { get; set; }
	public string Name { get; set; }
	public string SortDiscriminant { get; set; }
	public ParameterDescriptor[] Parameters { get; set; }
	public Type ExtensionMethodType { get; set; }
	public Type VarArgsArrayType { get; set; }
	public Type VarArgsElementType { get; set; }
	public MemberDescriptorAccess MemberAccess { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x106A0 Offset: 0x107A1 VA: 0x106A0
	// RVA: 0x3314C90 Offset: 0x3314D91 VA: 0x3314C90 Slot: 10
	public bool get_IsStatic() { }

	[CompilerGeneratedAttribute] // RVA: 0x106B0 Offset: 0x107B1 VA: 0x106B0
	// RVA: 0x3314CA0 Offset: 0x3314DA1 VA: 0x3314CA0
	private void set_IsStatic(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x106C0 Offset: 0x107C1 VA: 0x106C0
	// RVA: 0x3314CB0 Offset: 0x3314DB1 VA: 0x3314CB0 Slot: 11
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x106D0 Offset: 0x107D1 VA: 0x106D0
	// RVA: 0x3314CC0 Offset: 0x3314DC1 VA: 0x3314CC0
	private void set_Name(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x106E0 Offset: 0x107E1 VA: 0x106E0
	// RVA: 0x3314CD0 Offset: 0x3314DD1 VA: 0x3314CD0 Slot: 9
	public string get_SortDiscriminant() { }

	[CompilerGeneratedAttribute] // RVA: 0x106F0 Offset: 0x107F1 VA: 0x106F0
	// RVA: 0x3314CE0 Offset: 0x3314DE1 VA: 0x3314CE0
	private void set_SortDiscriminant(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x10700 Offset: 0x10801 VA: 0x10700
	// RVA: 0x3314CF0 Offset: 0x3314DF1 VA: 0x3314CF0 Slot: 6
	public ParameterDescriptor[] get_Parameters() { }

	[CompilerGeneratedAttribute] // RVA: 0x10710 Offset: 0x10811 VA: 0x10710
	// RVA: 0x3314D00 Offset: 0x3314E01 VA: 0x3314D00
	private void set_Parameters(ParameterDescriptor[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x10720 Offset: 0x10821 VA: 0x10720
	// RVA: 0x3314D10 Offset: 0x3314E11 VA: 0x3314D10 Slot: 5
	public Type get_ExtensionMethodType() { }

	[CompilerGeneratedAttribute] // RVA: 0x10730 Offset: 0x10831 VA: 0x10730
	// RVA: 0x3314D20 Offset: 0x3314E21 VA: 0x3314D20
	private void set_ExtensionMethodType(Type value) { }

	[CompilerGeneratedAttribute] // RVA: 0x10740 Offset: 0x10841 VA: 0x10740
	// RVA: 0x3314D30 Offset: 0x3314E31 VA: 0x3314D30 Slot: 7
	public Type get_VarArgsArrayType() { }

	[CompilerGeneratedAttribute] // RVA: 0x10750 Offset: 0x10851 VA: 0x10750
	// RVA: 0x3314D40 Offset: 0x3314E41 VA: 0x3314D40
	private void set_VarArgsArrayType(Type value) { }

	[CompilerGeneratedAttribute] // RVA: 0x10760 Offset: 0x10861 VA: 0x10760
	// RVA: 0x3314D50 Offset: 0x3314E51 VA: 0x3314D50 Slot: 8
	public Type get_VarArgsElementType() { }

	[CompilerGeneratedAttribute] // RVA: 0x10770 Offset: 0x10871 VA: 0x10770
	// RVA: 0x3314D60 Offset: 0x3314E61 VA: 0x3314D60
	private void set_VarArgsElementType(Type value) { }

	// RVA: 0x3314D70 Offset: 0x3314E71 VA: 0x3314D70
	protected void Initialize(string funcName, bool isStatic, ParameterDescriptor[] parameters, bool isExtensionMethod) { }

	// RVA: 0x3314FF0 Offset: 0x33150F1 VA: 0x3314FF0
	public Func<ScriptExecutionContext, CallbackArguments, DynValue> GetCallback(Script script, object obj) { }

	// RVA: 0x3315100 Offset: 0x3315201 VA: 0x3315100
	public CallbackFunction GetCallbackFunction(Script script, object obj) { }

	// RVA: 0x33151A0 Offset: 0x33152A1 VA: 0x33151A0
	public DynValue GetCallbackAsDynValue(Script script, object obj) { }

	// RVA: 0x3315280 Offset: 0x3315381 VA: 0x3315280
	public static DynValue CreateCallbackDynValue(Script script, MethodInfo mi, object obj) { }

	// RVA: 0x3315310 Offset: 0x3315411 VA: 0x3315310 Slot: 15
	protected virtual object[] BuildArgumentList(Script script, object obj, ScriptExecutionContext context, CallbackArguments args, out List<int> outParams) { }

	// RVA: 0x3315B70 Offset: 0x3315C71 VA: 0x3315B70
	protected static DynValue BuildReturnValue(Script script, List<int> outParams, object[] pars, object retv) { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract DynValue Execute(Script script, object obj, ScriptExecutionContext context, CallbackArguments args);

	// RVA: 0x3315E00 Offset: 0x3315F01 VA: 0x3315E00 Slot: 12
	public MemberDescriptorAccess get_MemberAccess() { }

	// RVA: 0x3315E10 Offset: 0x3315F11 VA: 0x3315E10 Slot: 17
	public virtual DynValue GetValue(Script script, object obj) { }

	// RVA: 0x3315E60 Offset: 0x3315F61 VA: 0x3315E60 Slot: 18
	public virtual void SetValue(Script script, object obj, DynValue v) { }

	// RVA: 0x3315E70 Offset: 0x3315F71 VA: 0x3315E70
	protected void .ctor() { }
}

