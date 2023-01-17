// Namespace: nn.hid
public static class NpadHandheld // TypeDefIndex: 14648
{
	// Methods

	// RVA: 0x23600B0 Offset: 0x23601B1 VA: 0x23600B0
	public static extern void GetState(ref NpadHandheldState pOutValue, NpadId npadId) { }

	// RVA: 0x235F0E0 Offset: 0x235F1E1 VA: 0x235F0E0
	public static extern void GetState(ref NpadState pOutValue, NpadId npadId) { }

	// RVA: 0x23600C0 Offset: 0x23601C1 VA: 0x23600C0
	public static extern int GetStates([Out] NpadHandheldState[] pOutValues, int count, NpadId npadId) { }

	// RVA: 0x235F6C0 Offset: 0x235F7C1 VA: 0x235F6C0
	public static extern int GetStates([Out] NpadStateArrayItem[] pOutValues, int count, NpadId npadId) { }
}

