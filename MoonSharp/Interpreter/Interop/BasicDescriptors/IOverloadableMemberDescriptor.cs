// Namespace: MoonSharp.Interpreter.Interop.BasicDescriptors
public interface IOverloadableMemberDescriptor : IMemberDescriptor // TypeDefIndex: 6167
{
	// Properties
	public abstract Type ExtensionMethodType { get; }
	public abstract ParameterDescriptor[] Parameters { get; }
	public abstract Type VarArgsArrayType { get; }
	public abstract Type VarArgsElementType { get; }
	public abstract string SortDiscriminant { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract DynValue Execute(Script script, object obj, ScriptExecutionContext context, CallbackArguments args);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Type get_ExtensionMethodType();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract ParameterDescriptor[] get_Parameters();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract Type get_VarArgsArrayType();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Type get_VarArgsElementType();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string get_SortDiscriminant();
}

