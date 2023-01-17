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

