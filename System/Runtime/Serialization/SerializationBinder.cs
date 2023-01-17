// Namespace: System.Runtime.Serialization
[ComVisibleAttribute] // RVA: 0x474740 Offset: 0x474841 VA: 0x474740
[Serializable]
public abstract class SerializationBinder // TypeDefIndex: 1015
{
	// Methods

	// RVA: 0x3618110 Offset: 0x3618211 VA: 0x3618110 Slot: 4
	public virtual void BindToName(Type serializedType, out string assemblyName, out string typeName) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract Type BindToType(string assemblyName, string typeName);

	// RVA: 0x3618150 Offset: 0x3618251 VA: 0x3618150
	protected void .ctor() { }
}

