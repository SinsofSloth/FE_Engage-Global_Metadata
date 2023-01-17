// Namespace: MoonSharp.Interpreter.Interop
public class PropertyTableAssigner : IPropertyTableAssigner // TypeDefIndex: 6075
{
	// Fields
	private Type m_Type; // 0x10
	private Dictionary<string, PropertyInfo> m_PropertyMap; // 0x18
	private Dictionary<Type, IPropertyTableAssigner> m_SubAssigners; // 0x20

	// Methods

	// RVA: 0x3010340 Offset: 0x3010441 VA: 0x3010340
	public void .ctor(Type type, string[] expectedMissingProperties) { }

	// RVA: 0x30109E0 Offset: 0x3010AE1 VA: 0x30109E0
	public void AddExpectedMissingProperty(string name) { }

	// RVA: 0x3010A40 Offset: 0x3010B41 VA: 0x3010A40
	private bool TryAssignProperty(object obj, string name, DynValue value) { }

	// RVA: 0x3010D70 Offset: 0x3010E71 VA: 0x3010D70
	private void AssignProperty(object obj, string name, DynValue value) { }

	// RVA: 0x3010EA0 Offset: 0x3010FA1 VA: 0x3010EA0
	public void AssignObject(object obj, Table data) { }

	// RVA: 0x30114F0 Offset: 0x30115F1 VA: 0x30114F0
	public void SetSubassignerForType(Type propertyType, IPropertyTableAssigner assigner) { }

	// RVA: 0x30117E0 Offset: 0x30118E1 VA: 0x30117E0 Slot: 4
	private void MoonSharp.Interpreter.Interop.IPropertyTableAssigner.AssignObjectUnchecked(object obj, Table data) { }
}

