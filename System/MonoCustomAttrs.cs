// Namespace: System
internal static class MonoCustomAttrs // TypeDefIndex: 376
{
	// Fields
	private static Assembly corlib; // 0x0
	[ThreadStaticAttribute] // RVA: 0x478190 Offset: 0x478291 VA: 0x478190
	private static Dictionary<Type, AttributeUsageAttribute> usage_cache; // 0x80000000
	private static readonly AttributeUsageAttribute DefaultAttributeUsage; // 0x8

	// Methods

	// RVA: 0x34F53E0 Offset: 0x34F54E1 VA: 0x34F53E0
	private static bool IsUserCattrProvider(object obj) { }

	// RVA: 0x34F55E0 Offset: 0x34F56E1 VA: 0x34F55E0
	internal static object[] GetCustomAttributesInternal(ICustomAttributeProvider obj, Type attributeType, bool pseudoAttrs) { }

	// RVA: 0x34F55F0 Offset: 0x34F56F1 VA: 0x34F55F0
	internal static object[] GetPseudoCustomAttributes(ICustomAttributeProvider obj, Type attributeType) { }

	// RVA: 0x34F5AD0 Offset: 0x34F5BD1 VA: 0x34F5AD0
	private static object[] GetPseudoCustomAttributes(Type type) { }

	// RVA: 0x34F5C50 Offset: 0x34F5D51 VA: 0x34F5C50
	internal static object[] GetCustomAttributesBase(ICustomAttributeProvider obj, Type attributeType, bool inheritedOnly) { }

	// RVA: 0x34F46E0 Offset: 0x34F47E1 VA: 0x34F46E0
	internal static object[] GetCustomAttributes(ICustomAttributeProvider obj, Type attributeType, bool inherit) { }

	// RVA: 0x34F44C0 Offset: 0x34F45C1 VA: 0x34F44C0
	internal static object[] GetCustomAttributes(ICustomAttributeProvider obj, bool inherit) { }

	// RVA: 0x34F62D0 Offset: 0x34F63D1 VA: 0x34F62D0
	private static CustomAttributeData[] GetCustomAttributesDataInternal(ICustomAttributeProvider obj) { }

	// RVA: 0x34F62E0 Offset: 0x34F63E1 VA: 0x34F62E0
	internal static IList<CustomAttributeData> GetCustomAttributesData(ICustomAttributeProvider obj) { }

	// RVA: 0x34F4170 Offset: 0x34F4271 VA: 0x34F4170
	internal static bool IsDefined(ICustomAttributeProvider obj, Type attributeType, bool inherit) { }

	// RVA: 0x34F63B0 Offset: 0x34F64B1 VA: 0x34F63B0
	internal static bool IsDefinedInternal(ICustomAttributeProvider obj, Type AttributeType) { }

	// RVA: 0x34F63C0 Offset: 0x34F64C1 VA: 0x34F63C0
	private static PropertyInfo GetBasePropertyDefinition(MonoProperty property) { }

	// RVA: 0x34F6730 Offset: 0x34F6831 VA: 0x34F6730
	private static EventInfo GetBaseEventDefinition(MonoEvent evt) { }

	// RVA: 0x34F5E20 Offset: 0x34F5F21 VA: 0x34F5E20
	private static ICustomAttributeProvider GetBase(ICustomAttributeProvider obj) { }

	// RVA: 0x34F69C0 Offset: 0x34F6AC1 VA: 0x34F69C0
	private static AttributeUsageAttribute RetrieveAttributeUsageNoCache(Type attributeType) { }

	// RVA: 0x34F6130 Offset: 0x34F6231 VA: 0x34F6130
	private static AttributeUsageAttribute RetrieveAttributeUsage(Type attributeType) { }

	// RVA: 0x34F6C30 Offset: 0x34F6D31 VA: 0x34F6C30
	private static void .cctor() { }
}

