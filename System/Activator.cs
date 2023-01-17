// Namespace: System
[ComVisibleAttribute] // RVA: 0x46FBB0 Offset: 0x46FCB1 VA: 0x46FBB0
[ClassInterfaceAttribute] // RVA: 0x46FBB0 Offset: 0x46FCB1 VA: 0x46FBB0
[ComDefaultInterfaceAttribute] // RVA: 0x46FBB0 Offset: 0x46FCB1 VA: 0x46FBB0
public sealed class Activator // TypeDefIndex: 162
{
	// Methods

	// RVA: 0x355B1D0 Offset: 0x355B2D1 VA: 0x355B1D0
	public static object CreateInstance(Type type, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture) { }

	// RVA: 0x355B1E0 Offset: 0x355B2E1 VA: 0x355B1E0
	public static object CreateInstance(Type type, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes) { }

	// RVA: 0x355B400 Offset: 0x355B501 VA: 0x355B400
	public static object CreateInstance(Type type, object[] args) { }

	// RVA: 0x355B420 Offset: 0x355B521 VA: 0x355B420
	public static object CreateInstance(Type type) { }

	// RVA: 0x355B430 Offset: 0x355B531 VA: 0x355B430
	public static object CreateInstance(Type type, bool nonPublic) { }

	// RVA: -1 Offset: -1
	public static T CreateInstance<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255AF00 Offset: 0x255B001 VA: 0x255AF00
	|-Activator.CreateInstance<CoreUnsafeUtils.DefaultKeyGetter<Hash128>>
	|
	|-RVA: 0x255B070 Offset: 0x255B171 VA: 0x255B070
	|-Activator.CreateInstance<object>
	*/
}

