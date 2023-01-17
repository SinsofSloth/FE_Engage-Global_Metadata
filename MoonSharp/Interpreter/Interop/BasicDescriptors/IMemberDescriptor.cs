// Namespace: MoonSharp.Interpreter.Interop.BasicDescriptors
public interface IMemberDescriptor // TypeDefIndex: 6163
{
	// Properties
	public abstract bool IsStatic { get; }
	public abstract string Name { get; }
	public abstract MemberDescriptorAccess MemberAccess { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IsStatic();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract MemberDescriptorAccess get_MemberAccess();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract DynValue GetValue(Script script, object obj);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void SetValue(Script script, object obj, DynValue value);
}

