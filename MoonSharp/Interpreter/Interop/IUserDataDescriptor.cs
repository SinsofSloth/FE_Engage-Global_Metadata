// Namespace: MoonSharp.Interpreter.Interop
public interface IUserDataDescriptor // TypeDefIndex: 6067
{
	// Properties
	public abstract string Name { get; }
	public abstract Type Type { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Type get_Type();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract DynValue Index(Script script, object obj, DynValue index, bool isDirectIndexing);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool SetIndex(Script script, object obj, DynValue index, DynValue value, bool isDirectIndexing);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string AsString(object obj);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract DynValue MetaIndex(Script script, object obj, string metaname);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool IsTypeCompatible(Type type, object obj);
}

