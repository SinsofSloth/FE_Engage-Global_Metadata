// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x78F40 Offset: 0x79041 VA: 0x78F40
public static class SubsystemManager // TypeDefIndex: 4758
{
	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x79000 Offset: 0x79101 VA: 0x79000
	[CompilerGeneratedAttribute] // RVA: 0x79000 Offset: 0x79101 VA: 0x79000
	private static Action beforeReloadSubsystems; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x79040 Offset: 0x79141 VA: 0x79040
	[DebuggerBrowsableAttribute] // RVA: 0x79040 Offset: 0x79141 VA: 0x79040
	private static Action afterReloadSubsystems; // 0x8
	private static List<IntegratedSubsystem> s_IntegratedSubsystems; // 0x10
	private static List<SubsystemWithProvider> s_StandaloneSubsystems; // 0x18
	private static List<Subsystem> s_DeprecatedSubsystems; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x79080 Offset: 0x79181 VA: 0x79080
	[DebuggerBrowsableAttribute] // RVA: 0x79080 Offset: 0x79181 VA: 0x79080
	private static Action reloadSubsytemsStarted; // 0x28
	[DebuggerBrowsableAttribute] // RVA: 0x790C0 Offset: 0x791C1 VA: 0x790C0
	[CompilerGeneratedAttribute] // RVA: 0x790C0 Offset: 0x791C1 VA: 0x790C0
	private static Action reloadSubsytemsCompleted; // 0x30

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x79160 Offset: 0x79261 VA: 0x79160
	// RVA: 0x1C64490 Offset: 0x1C64591 VA: 0x1C64490
	private static void ReloadSubsystemsStarted() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x79170 Offset: 0x79271 VA: 0x79170
	// RVA: 0x1C64590 Offset: 0x1C64691 VA: 0x1C64590
	private static void ReloadSubsystemsCompleted() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x79180 Offset: 0x79281 VA: 0x79180
	// RVA: 0x1C64690 Offset: 0x1C64791 VA: 0x1C64690
	private static void InitializeIntegratedSubsystem(IntPtr ptr, IntegratedSubsystem subsystem) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x79190 Offset: 0x79291 VA: 0x79190
	// RVA: 0x1C64750 Offset: 0x1C64851 VA: 0x1C64750
	private static void ClearSubsystems() { }

	// RVA: 0x1C64930 Offset: 0x1C64A31 VA: 0x1C64930
	private static void StaticConstructScriptingClassMap() { }

	// RVA: 0x1C64970 Offset: 0x1C64A71 VA: 0x1C64970
	private static void .cctor() { }

	// RVA: -1 Offset: -1
	public static void GetSubsystems<T>(List<T> subsystems) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2023A60 Offset: 0x2023B61 VA: 0x2023A60
	|-SubsystemManager.GetSubsystems<object>
	*/

	// RVA: -1 Offset: -1
	private static void AddSubsystemSubset<TBaseTypeInList, TQueryType>(List<TBaseTypeInList> copyFrom, List<TQueryType> copyTo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2023760 Offset: 0x2023861 VA: 0x2023760
	|-SubsystemManager.AddSubsystemSubset<object, object>
	*/

	// RVA: 0x1C64AE0 Offset: 0x1C64BE1 VA: 0x1C64AE0
	internal static IntegratedSubsystem GetIntegratedSubsystemByPtr(IntPtr ptr) { }

	// RVA: -1 Offset: -1
	public static void GetInstances<T>(List<T> subsystems) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20239E0 Offset: 0x2023AE1 VA: 0x20239E0
	|-SubsystemManager.GetInstances<object>
	|-SubsystemManager.GetInstances<XRDisplaySubsystem>
	*/
}

