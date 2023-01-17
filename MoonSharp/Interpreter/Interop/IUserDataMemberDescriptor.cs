// Namespace: MoonSharp.Interpreter.Interop
public interface IUserDataMemberDescriptor // TypeDefIndex: 6068
{
	// Properties
	public abstract string Name { get; }
	public abstract Type Type { get; }
	public abstract UserDataMemberType MemberType { get; }
	public abstract bool IsStatic { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Type get_Type();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract DynValue GetValue(Script script, object obj);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool SetValue(Script script, object obj, DynValue value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract UserDataMemberType get_MemberType();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Optimize();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool get_IsStatic();
}

