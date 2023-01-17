// Namespace: UnityEngine
internal class AttributeHelperEngine // TypeDefIndex: 3571
{
	// Fields
	public static DisallowMultipleComponent[] _disallowMultipleComponentArray; // 0x0
	public static ExecuteInEditMode[] _executeInEditModeArray; // 0x8
	public static RequireComponent[] _requireComponentArray; // 0x10

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x44EFC0 Offset: 0x44F0C1 VA: 0x44EFC0
	// RVA: 0x2F0AD80 Offset: 0x2F0AE81 VA: 0x2F0AD80
	private static Type GetParentTypeDisallowingMultipleInclusion(Type type) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x44EFD0 Offset: 0x44F0D1 VA: 0x44EFD0
	// RVA: 0x2F0AEA0 Offset: 0x2F0AFA1 VA: 0x2F0AEA0
	private static Type[] GetRequiredComponents(Type klass) { }

	// RVA: 0x2F0B250 Offset: 0x2F0B351 VA: 0x2F0B250
	private static int GetExecuteMode(Type klass) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x44EFE0 Offset: 0x44F0E1 VA: 0x44EFE0
	// RVA: 0x2F0B370 Offset: 0x2F0B471 VA: 0x2F0B370
	private static int CheckIsEditorScript(Type klass) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x44EFF0 Offset: 0x44F0F1 VA: 0x44EFF0
	// RVA: 0x2F0B470 Offset: 0x2F0B571 VA: 0x2F0B470
	private static int GetDefaultExecutionOrderFor(Type klass) { }

	// RVA: -1 Offset: -1
	private static T GetCustomAttributeOfType<T>(Type klass) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2299160 Offset: 0x2299261 VA: 0x2299160
	|-AttributeHelperEngine.GetCustomAttributeOfType<DefaultExecutionOrder>
	|-AttributeHelperEngine.GetCustomAttributeOfType<object>
	*/

	// RVA: 0x2F0B520 Offset: 0x2F0B621 VA: 0x2F0B520
	private static void .cctor() { }
}

