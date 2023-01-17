// Namespace: UnityEngine.SubsystemsImplementation
[NativeHeaderAttribute] // RVA: 0x78F80 Offset: 0x79081 VA: 0x78F80
public static class SubsystemDescriptorStore // TypeDefIndex: 4759
{
	// Fields
	private static List<IntegratedSubsystemDescriptor> s_IntegratedDescriptors; // 0x0
	private static List<SubsystemDescriptorWithProvider> s_StandaloneDescriptors; // 0x8
	private static List<SubsystemDescriptor> s_DeprecatedDescriptors; // 0x10

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x791A0 Offset: 0x792A1 VA: 0x791A0
	// RVA: 0x1C640A0 Offset: 0x1C641A1 VA: 0x1C640A0
	internal static void InitializeManagedDescriptor(IntPtr ptr, IntegratedSubsystemDescriptor desc) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x791B0 Offset: 0x792B1 VA: 0x791B0
	// RVA: 0x1C64140 Offset: 0x1C64241 VA: 0x1C64140
	internal static void ClearManagedDescriptors() { }

	// RVA: 0x1C642D0 Offset: 0x1C643D1 VA: 0x1C642D0
	private static void ReportSingleSubsystemAnalytics(string id) { }

	// RVA: -1 Offset: -1
	internal static void RegisterDescriptor<TDescriptor, TBaseTypeInList>(TDescriptor descriptor, List<TBaseTypeInList> storeInList) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20233A0 Offset: 0x20234A1 VA: 0x20233A0
	|-SubsystemDescriptorStore.RegisterDescriptor<object, object>
	|-SubsystemDescriptorStore.RegisterDescriptor<SubsystemDescriptor, SubsystemDescriptor>
	*/

	// RVA: 0x1C63FE0 Offset: 0x1C640E1 VA: 0x1C63FE0
	internal static void RegisterDeprecatedDescriptor(SubsystemDescriptor descriptor) { }

	// RVA: 0x1C64320 Offset: 0x1C64421 VA: 0x1C64320
	private static void .cctor() { }
}

