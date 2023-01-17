// Namespace: App
internal abstract class MemberInfoItem<T> : MenuItem // TypeDefIndex: 8952
{
	// Fields
	protected object m_Object; // 0x0
	protected T m_Info; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	protected void .ctor(object obj, T info) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x293A280 Offset: 0x293A381 VA: 0x293A280
	|-MemberInfoItem<FieldInfo>..ctor
	|-MemberInfoItem<object>..ctor
	|-MemberInfoItem<PropertyInfo>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 22
	public override bool IsEnable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x293A2D0 Offset: 0x293A3D1 VA: 0x293A2D0
	|-MemberInfoItem<FieldInfo>.IsEnable
	|-MemberInfoItem<object>.IsEnable
	|-MemberInfoItem<PropertyInfo>.IsEnable
	*/

	// RVA: -1 Offset: -1 Slot: 23
	public override bool IsVisible() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x293A450 Offset: 0x293A551 VA: 0x293A450
	|-MemberInfoItem<FieldInfo>.IsVisible
	|-MemberInfoItem<object>.IsVisible
	|-MemberInfoItem<PropertyInfo>.IsVisible
	*/

	// RVA: -1 Offset: -1 Slot: 29
	public override int GetColumnCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x293A460 Offset: 0x293A561 VA: 0x293A460
	|-MemberInfoItem<FieldInfo>.GetColumnCount
	|-MemberInfoItem<object>.GetColumnCount
	|-MemberInfoItem<PropertyInfo>.GetColumnCount
	*/

	// RVA: -1 Offset: -1 Slot: 31
	public override float GetColumnWidth0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x293A470 Offset: 0x293A571 VA: 0x293A470
	|-MemberInfoItem<FieldInfo>.GetColumnWidth0
	|-MemberInfoItem<object>.GetColumnWidth0
	|-MemberInfoItem<PropertyInfo>.GetColumnWidth0
	*/

	// RVA: -1 Offset: -1 Slot: 32
	public override float GetColumnWidth1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x293A480 Offset: 0x293A581 VA: 0x293A480
	|-MemberInfoItem<FieldInfo>.GetColumnWidth1
	|-MemberInfoItem<object>.GetColumnWidth1
	|-MemberInfoItem<PropertyInfo>.GetColumnWidth1
	*/

	// RVA: -1 Offset: -1 Slot: 42
	public override string GetColumnName0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x293A490 Offset: 0x293A591 VA: 0x293A490
	|-MemberInfoItem<FieldInfo>.GetColumnName0
	|-MemberInfoItem<object>.GetColumnName0
	|-MemberInfoItem<PropertyInfo>.GetColumnName0
	*/

	// RVA: -1 Offset: -1 Slot: 43
	public override string GetColumnName1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x293A4A0 Offset: 0x293A5A1 VA: 0x293A4A0
	|-MemberInfoItem<FieldInfo>.GetColumnName1
	|-MemberInfoItem<object>.GetColumnName1
	|-MemberInfoItem<PropertyInfo>.GetColumnName1
	*/

	// RVA: -1 Offset: -1 Slot: 54
	public override MenuItem.Align GetColumnAlign1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x293A530 Offset: 0x293A631 VA: 0x293A530
	|-MemberInfoItem<FieldInfo>.GetColumnAlign1
	|-MemberInfoItem<object>.GetColumnAlign1
	|-MemberInfoItem<PropertyInfo>.GetColumnAlign1
	*/

	// RVA: -1 Offset: -1 Slot: 72
	protected abstract object GetValue();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-MemberInfoItem<object>.GetValue
	*/

	// RVA: -1 Offset: -1 Slot: 73
	protected abstract void SetValue(object value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-MemberInfoItem<object>.SetValue
	*/

	// RVA: -1 Offset: -1 Slot: 74
	protected abstract Type GetValueType();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-MemberInfoItem<object>.GetValueType
	*/

	// RVA: -1 Offset: -1 Slot: 70
	public override void OnLeftRight(int step, bool isTrigger) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x293A540 Offset: 0x293A641 VA: 0x293A540
	|-MemberInfoItem<FieldInfo>.OnLeftRight
	|-MemberInfoItem<object>.OnLeftRight
	|-MemberInfoItem<PropertyInfo>.OnLeftRight
	*/
}

