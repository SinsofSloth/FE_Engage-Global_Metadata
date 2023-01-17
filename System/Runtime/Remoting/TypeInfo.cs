// Namespace: System.Runtime.Remoting
[Serializable]
internal class TypeInfo : IRemotingTypeInfo // TypeDefIndex: 1115
{
	// Fields
	private string serverType; // 0x10
	private string[] serverHierarchy; // 0x18
	private string[] interfacesImplemented; // 0x20

	// Properties
	public string TypeName { get; }

	// Methods

	// RVA: 0x3642660 Offset: 0x3642761 VA: 0x3642660
	public void .ctor(Type type) { }

	// RVA: 0x3642B10 Offset: 0x3642C11 VA: 0x3642B10 Slot: 4
	public string get_TypeName() { }

	// RVA: 0x3642B20 Offset: 0x3642C21 VA: 0x3642B20 Slot: 5
	public bool CanCastTo(Type fromType, object o) { }
}

