// Namespace: Unity.IO.LowLevel.Unsafe
[NativeAsStructAttribute] // RVA: 0x43B0D0 Offset: 0x43B1D1 VA: 0x43B0D0
[RequiredByNativeCodeAttribute] // RVA: 0x43B0D0 Offset: 0x43B1D1 VA: 0x43B0D0
[NativeConditionalAttribute] // RVA: 0x43B0D0 Offset: 0x43B1D1 VA: 0x43B0D0
public class AsyncReadManagerMetricsFilters // TypeDefIndex: 3355
{
	// Fields
	[NativeNameAttribute] // RVA: 0x441DC0 Offset: 0x441EC1 VA: 0x441DC0
	internal ulong[] TypeIDs; // 0x10
	[NativeNameAttribute] // RVA: 0x441E00 Offset: 0x441F01 VA: 0x441E00
	internal ProcessingState[] States; // 0x18
	[NativeNameAttribute] // RVA: 0x441E40 Offset: 0x441F41 VA: 0x441E40
	internal FileReadType[] ReadTypes; // 0x20
	[NativeNameAttribute] // RVA: 0x441E80 Offset: 0x441F81 VA: 0x441E80
	internal Priority[] PriorityLevels; // 0x28
	[NativeNameAttribute] // RVA: 0x441EC0 Offset: 0x441FC1 VA: 0x441EC0
	internal AssetLoadingSubsystem[] Subsystems; // 0x30
}

