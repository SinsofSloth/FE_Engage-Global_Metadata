// Namespace: 
public class SpringSetupComponentDefiners.ComponentDefiner // TypeDefIndex: 6398
{
	// Fields
	protected Type componentType; // 0x10

	// Methods

	// RVA: 0x3A75ED0 Offset: 0x3A75FD1 VA: 0x3A75ED0
	public void .ctor(Type newType) { }

	// RVA: 0x3A7EA90 Offset: 0x3A7EB91 VA: 0x3A7EA90
	public bool TryToAppendDefinition(StringBuilder builder, GameObject rootObject) { }

	// RVA: 0x3A7EBA0 Offset: 0x3A7ECA1 VA: 0x3A7EBA0
	public void AppendDefinition(StringBuilder builder, Component component) { }

	// RVA: 0x3A7EC40 Offset: 0x3A7ED41 VA: 0x3A7EC40
	public Component BuildFromDefinition(GameObject owner, Queue<string> definitionItems) { }

	// RVA: 0x3A7EE10 Offset: 0x3A7EF11 VA: 0x3A7EE10 Slot: 4
	protected virtual string GetTypeToken() { }

	// RVA: 0x3A7EE20 Offset: 0x3A7EF21 VA: 0x3A7EE20 Slot: 5
	protected virtual void AppendProperties(StringBuilder builder, Component component) { }

	// RVA: -1 Offset: -1
	protected static void AppendRecordItem<T>(StringBuilder builder, T item, char separator = '\x2c') { }
	/* GenericInstMethod :
	|
	|-RVA: 0x388A8B0 Offset: 0x388A9B1 VA: 0x388A8B0
	|-SpringSetupComponentDefiners.ComponentDefiner.AppendRecordItem<object>
	|-SpringSetupComponentDefiners.ComponentDefiner.AppendRecordItem<string>
	*/

	// RVA: 0x3A7EF30 Offset: 0x3A7F031 VA: 0x3A7EF30
	protected static string GetComponentName(Component component) { }

	// RVA: 0x3A7EFE0 Offset: 0x3A7F0E1 VA: 0x3A7EFE0 Slot: 6
	protected virtual Component InternalBuildFromDefinition(GameObject owner, Queue<string> definitionItems) { }
}

