// Namespace: nn.hid
public static class NpadJoyDual // TypeDefIndex: 14656
{
	// Methods

	// RVA: 0x23605F0 Offset: 0x23606F1 VA: 0x23605F0
	public static extern void GetState(ref NpadJoyDualState pOutValue, NpadId npadId) { }

	// RVA: 0x235F0F0 Offset: 0x235F1F1 VA: 0x235F0F0
	public static extern void GetState(ref NpadState pOutValue, NpadId npadId) { }

	// RVA: 0x2360600 Offset: 0x2360701 VA: 0x2360600
	public static extern int GetStates([Out] NpadJoyDualState[] pOutValues, int count, NpadId npadId) { }

	// RVA: 0x235F800 Offset: 0x235F901 VA: 0x235F800
	public static extern int GetStates([Out] NpadStateArrayItem[] pOutValues, int count, NpadId npadId) { }
}

