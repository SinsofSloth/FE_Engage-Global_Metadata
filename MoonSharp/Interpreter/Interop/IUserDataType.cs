// Namespace: MoonSharp.Interpreter.Interop
public interface IUserDataType // TypeDefIndex: 6069
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract DynValue Index(Script script, DynValue index, bool isDirectIndexing);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool SetIndex(Script script, DynValue index, DynValue value, bool isDirectIndexing);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract DynValue MetaIndex(Script script, string metaname);
}

