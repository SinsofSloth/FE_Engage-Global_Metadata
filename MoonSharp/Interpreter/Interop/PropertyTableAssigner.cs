// Namespace: MoonSharp.Interpreter.Interop
public class PropertyTableAssigner<T> : IPropertyTableAssigner // TypeDefIndex: 6074
{
	// Fields
	private PropertyTableAssigner m_InternalAssigner; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(string[] expectedMissingProperties) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A85A10 Offset: 0x2A85B11 VA: 0x2A85A10
	|-PropertyTableAssigner<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void AddExpectedMissingProperty(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A85AF0 Offset: 0x2A85BF1 VA: 0x2A85AF0
	|-PropertyTableAssigner<object>.AddExpectedMissingProperty
	*/

	// RVA: -1 Offset: -1
	public void AssignObject(T obj, Table data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A85B00 Offset: 0x2A85C01 VA: 0x2A85B00
	|-PropertyTableAssigner<object>.AssignObject
	*/

	// RVA: -1 Offset: -1
	public PropertyTableAssigner GetTypeUnsafeAssigner() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A85B10 Offset: 0x2A85C11 VA: 0x2A85B10
	|-PropertyTableAssigner<object>.GetTypeUnsafeAssigner
	*/

	// RVA: -1 Offset: -1
	public void SetSubassignerForType(Type propertyType, IPropertyTableAssigner assigner) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A85B20 Offset: 0x2A85C21 VA: 0x2A85B20
	|-PropertyTableAssigner<object>.SetSubassignerForType
	*/

	// RVA: -1 Offset: -1
	public void SetSubassigner<SubassignerType>(PropertyTableAssigner<SubassignerType> assigner) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2553D90 Offset: 0x2553E91 VA: 0x2553D90
	|-PropertyTableAssigner<object>.SetSubassigner<object>
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private void MoonSharp.Interpreter.Interop.IPropertyTableAssigner.AssignObjectUnchecked(object o, Table data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A85B30 Offset: 0x2A85C31 VA: 0x2A85B30
	|-PropertyTableAssigner<object>.MoonSharp.Interpreter.Interop.IPropertyTableAssigner.AssignObjectUnchecked
	*/
}

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

