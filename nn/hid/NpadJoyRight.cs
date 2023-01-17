// Namespace: nn.hid
public static class NpadJoyRight // TypeDefIndex: 14660
{
	// Methods

	// RVA: 0x2360D70 Offset: 0x2360E71 VA: 0x2360D70
	public static extern void GetState(ref NpadJoyRightState pOutValue, NpadId npadId) { }

	// RVA: 0x235F110 Offset: 0x235F211 VA: 0x235F110
	public static extern void GetState(ref NpadState pOutValue, NpadId npadId) { }

	// RVA: 0x2360D80 Offset: 0x2360E81 VA: 0x2360D80
	public static extern int GetStates([Out] NpadJoyRightState[] pOutValues, int count, NpadId npadId) { }

	// RVA: 0x235FA80 Offset: 0x235FB81 VA: 0x235FA80
	public static extern int GetStates([Out] NpadStateArrayItem[] pOutValues, int count, NpadId npadId) { }
}

