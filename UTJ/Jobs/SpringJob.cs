// Namespace: UTJ.Jobs
[BurstCompileAttribute] // RVA: 0x5B4E0 Offset: 0x5B5E1 VA: 0x5B4E0
public struct SpringJob : IJobParallelFor // TypeDefIndex: 6450
{
	// Fields
	[ReadOnlyAttribute] // RVA: 0x5BBD0 Offset: 0x5BCD1 VA: 0x5BBD0
	public NativeArray<SpringJobElement> jobManagers; // 0x0
	[ReadOnlyAttribute] // RVA: 0x5BBE0 Offset: 0x5BCE1 VA: 0x5BBE0
	public NativeArray<SpringForceComponent> forces; // 0x10
	public int forceCount; // 0x20

	// Methods

	// RVA: 0x311E090 Offset: 0x311E191 VA: 0x311E090 Slot: 4
	private void Unity.Jobs.IJobParallelFor.Execute(int index) { }
}

