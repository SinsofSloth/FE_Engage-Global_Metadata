// Namespace: MoonSharp.Interpreter.Compatibility.Frameworks
internal abstract class FrameworkReflectionBase : FrameworkBase // TypeDefIndex: 6263
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 36
	public abstract Type GetTypeInfoFromType(Type t);

	// RVA: 0x3312780 Offset: 0x3312881 VA: 0x3312780 Slot: 6
	public override Assembly GetAssembly(Type t) { }

	// RVA: 0x33127B0 Offset: 0x33128B1 VA: 0x33127B0 Slot: 7
	public override Type GetBaseType(Type t) { }

	// RVA: 0x33127E0 Offset: 0x33128E1 VA: 0x33127E0 Slot: 5
	public override bool IsValueType(Type t) { }

	// RVA: 0x3312810 Offset: 0x3312911 VA: 0x3312810 Slot: 13
	public override bool IsInterface(Type t) { }

	// RVA: 0x3312840 Offset: 0x3312941 VA: 0x3312840 Slot: 11
	public override bool IsNestedPublic(Type t) { }

	// RVA: 0x3312870 Offset: 0x3312971 VA: 0x3312870 Slot: 12
	public override bool IsAbstract(Type t) { }

	// RVA: 0x33128A0 Offset: 0x33129A1 VA: 0x33128A0 Slot: 10
	public override bool IsEnum(Type t) { }

	// RVA: 0x33128D0 Offset: 0x33129D1 VA: 0x33128D0 Slot: 9
	public override bool IsGenericTypeDefinition(Type t) { }

	// RVA: 0x3312900 Offset: 0x3312A01 VA: 0x3312900 Slot: 8
	public override bool IsGenericType(Type t) { }

	// RVA: 0x3312930 Offset: 0x3312A31 VA: 0x3312930 Slot: 14
	public override Attribute[] GetCustomAttributes(Type t, bool inherit) { }

	// RVA: 0x33129E0 Offset: 0x3312AE1 VA: 0x33129E0 Slot: 15
	public override Attribute[] GetCustomAttributes(Type t, Type at, bool inherit) { }

	// RVA: 0x3312680 Offset: 0x3312781 VA: 0x3312680
	protected void .ctor() { }
}

