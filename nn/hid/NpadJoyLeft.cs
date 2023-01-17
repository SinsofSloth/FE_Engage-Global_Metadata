// Namespace: nn.hid
public static class NpadJoyLeft // TypeDefIndex: 14658
{
	// Methods

	// RVA: 0x23609B0 Offset: 0x2360AB1 VA: 0x23609B0
	public static extern void GetState(ref NpadJoyLeftState pOutValue, NpadId npadId) { }

	// RVA: 0x235F100 Offset: 0x235F201 VA: 0x235F100
	public static extern void GetState(ref NpadState pOutValue, NpadId npadId) { }

	// RVA: 0x23609C0 Offset: 0x2360AC1 VA: 0x23609C0
	public static extern int GetStates([Out] NpadJoyLeftState[] pOutValues, int count, NpadId npadId) { }

	// RVA: 0x235F940 Offset: 0x235FA41 VA: 0x235F940
	public static extern int GetStates([Out] NpadStateArrayItem[] pOutValues, int count, NpadId npadId) { }
}

