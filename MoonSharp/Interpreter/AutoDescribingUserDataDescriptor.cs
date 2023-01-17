// Namespace: MoonSharp.Interpreter
internal class AutoDescribingUserDataDescriptor : IUserDataDescriptor // TypeDefIndex: 5969
{
	// Fields
	private string m_FriendlyName; // 0x10
	private Type m_Type; // 0x18

	// Properties
	public string Name { get; }
	public Type Type { get; }

	// Methods

	// RVA: 0x30E9670 Offset: 0x30E9771 VA: 0x30E9670
	public void .ctor(Type type, string friendlyName) { }

	// RVA: 0x30E96C0 Offset: 0x30E97C1 VA: 0x30E96C0 Slot: 4
	public string get_Name() { }

	// RVA: 0x30E96D0 Offset: 0x30E97D1 VA: 0x30E96D0 Slot: 5
	public Type get_Type() { }

	// RVA: 0x30E96E0 Offset: 0x30E97E1 VA: 0x30E96E0 Slot: 6
	public DynValue Index(Script script, object obj, DynValue index, bool isDirectIndexing) { }

	// RVA: 0x30E97D0 Offset: 0x30E98D1 VA: 0x30E97D0 Slot: 7
	public bool SetIndex(Script script, object obj, DynValue index, DynValue value, bool isDirectIndexing) { }

	// RVA: 0x30E98D0 Offset: 0x30E99D1 VA: 0x30E98D0 Slot: 8
	public string AsString(object obj) { }

	// RVA: 0x30E98F0 Offset: 0x30E99F1 VA: 0x30E98F0 Slot: 9
	public DynValue MetaIndex(Script script, object obj, string metaname) { }

	// RVA: 0x30E99E0 Offset: 0x30E9AE1 VA: 0x30E99E0 Slot: 10
	public bool IsTypeCompatible(Type type, object obj) { }
}

