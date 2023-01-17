// Namespace: System
[Serializable]
internal class DefaultBinder : Binder // TypeDefIndex: 204
{
	// Methods

	// RVA: 0x371FF70 Offset: 0x3720071 VA: 0x371FF70 Slot: 4
	public override MethodBase BindToMethod(BindingFlags bindingAttr, MethodBase[] match, ref object[] args, ParameterModifier[] modifiers, CultureInfo cultureInfo, string[] names, out object state) { }

	// RVA: 0x3722600 Offset: 0x3722701 VA: 0x3722600 Slot: 5
	public override FieldInfo BindToField(BindingFlags bindingAttr, FieldInfo[] match, object value, CultureInfo cultureInfo) { }

	// RVA: 0x3722C20 Offset: 0x3722D21 VA: 0x3722C20 Slot: 6
	public override MethodBase SelectMethod(BindingFlags bindingAttr, MethodBase[] match, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x3723590 Offset: 0x3723691 VA: 0x3723590 Slot: 7
	public override PropertyInfo SelectProperty(BindingFlags bindingAttr, PropertyInfo[] match, Type returnType, Type[] indexes, ParameterModifier[] modifiers) { }

	// RVA: 0x3724940 Offset: 0x3724A41 VA: 0x3724940 Slot: 8
	public override object ChangeType(object value, Type type, CultureInfo cultureInfo) { }

	// RVA: 0x37249A0 Offset: 0x3724AA1 VA: 0x37249A0 Slot: 9
	public override void ReorderArgumentArray(ref object[] args, object state) { }

	// RVA: 0x3724C70 Offset: 0x3724D71 VA: 0x3724C70
	public static MethodBase ExactBinding(MethodBase[] match, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x3725070 Offset: 0x3725171 VA: 0x3725070
	public static PropertyInfo ExactPropertyBinding(PropertyInfo[] match, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x37243D0 Offset: 0x37244D1 VA: 0x37243D0
	private static int FindMostSpecific(ParameterInfo[] p1, int[] paramOrder1, Type paramArrayType1, ParameterInfo[] p2, int[] paramOrder2, Type paramArrayType2, Type[] types, object[] args) { }

	// RVA: 0x3724020 Offset: 0x3724121 VA: 0x3724020
	private static int FindMostSpecificType(Type c1, Type c2, Type t) { }

	// RVA: 0x3722410 Offset: 0x3722511 VA: 0x3722410
	private static int FindMostSpecificMethod(MethodBase m1, int[] paramOrder1, Type paramArrayType1, MethodBase m2, int[] paramOrder2, Type paramArrayType2, Type[] types, object[] args) { }

	// RVA: 0x3722A90 Offset: 0x3722B91 VA: 0x3722A90
	private static int FindMostSpecificField(FieldInfo cur1, FieldInfo cur2) { }

	// RVA: 0x37247B0 Offset: 0x37248B1 VA: 0x37247B0
	private static int FindMostSpecificProperty(PropertyInfo cur1, PropertyInfo cur2) { }

	// RVA: 0x3725380 Offset: 0x3725481 VA: 0x3725380
	internal static bool CompareMethodSigAndName(MethodBase m1, MethodBase m2) { }

	// RVA: 0x37254E0 Offset: 0x37255E1 VA: 0x37254E0
	internal static int GetHierarchyDepth(Type t) { }

	// RVA: 0x3724EE0 Offset: 0x3724FE1 VA: 0x3724EE0
	internal static MethodBase FindMostDerivedNewSlotMeth(MethodBase[] match, int cMatches) { }

	// RVA: 0x3722290 Offset: 0x3722391 VA: 0x3722290
	private static void ReorderParams(int[] paramOrder, object[] vars) { }

	// RVA: 0x3721F40 Offset: 0x3722041 VA: 0x3721F40
	private static bool CreateParamOrder(int[] paramOrder, ParameterInfo[] pars, string[] names) { }

	// RVA: 0x3723320 Offset: 0x3723421 VA: 0x3723320
	private static bool CanConvertPrimitive(RuntimeType source, RuntimeType target) { }

	// RVA: 0x3722190 Offset: 0x3722291 VA: 0x3722190
	private static bool CanConvertPrimitiveObjectToType(object source, RuntimeType type) { }

	// RVA: 0x3725590 Offset: 0x3725691 VA: 0x3725590
	public void .ctor() { }
}

