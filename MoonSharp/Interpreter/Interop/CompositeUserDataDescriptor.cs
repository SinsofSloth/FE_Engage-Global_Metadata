// Namespace: MoonSharp.Interpreter.Interop
public class CompositeUserDataDescriptor : IUserDataDescriptor // TypeDefIndex: 6082
{
	// Fields
	private List<IUserDataDescriptor> m_Descriptors; // 0x10
	private Type m_Type; // 0x18

	// Properties
	public IList<IUserDataDescriptor> Descriptors { get; }
	public string Name { get; }
	public Type Type { get; }

	// Methods

	// RVA: 0x30F9200 Offset: 0x30F9301 VA: 0x30F9200
	public void .ctor(List<IUserDataDescriptor> descriptors, Type type) { }

	// RVA: 0x30F9250 Offset: 0x30F9351 VA: 0x30F9250
	public IList<IUserDataDescriptor> get_Descriptors() { }

	// RVA: 0x30F9260 Offset: 0x30F9361 VA: 0x30F9260 Slot: 4
	public string get_Name() { }

	// RVA: 0x30F92D0 Offset: 0x30F93D1 VA: 0x30F92D0 Slot: 5
	public Type get_Type() { }

	// RVA: 0x30F92E0 Offset: 0x30F93E1 VA: 0x30F92E0 Slot: 6
	public DynValue Index(Script script, object obj, DynValue index, bool isNameIndex) { }

	// RVA: 0x30F94E0 Offset: 0x30F95E1 VA: 0x30F94E0 Slot: 7
	public bool SetIndex(Script script, object obj, DynValue index, DynValue value, bool isNameIndex) { }

	// RVA: 0x30F96E0 Offset: 0x30F97E1 VA: 0x30F96E0 Slot: 8
	public string AsString(object obj) { }

	// RVA: 0x30F9700 Offset: 0x30F9801 VA: 0x30F9700 Slot: 9
	public DynValue MetaIndex(Script script, object obj, string metaname) { }

	// RVA: 0x30F98F0 Offset: 0x30F99F1 VA: 0x30F98F0 Slot: 10
	public bool IsTypeCompatible(Type type, object obj) { }
}

