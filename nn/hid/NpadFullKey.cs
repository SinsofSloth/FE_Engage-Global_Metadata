// Namespace: nn.hid
public static class NpadFullKey // TypeDefIndex: 14646
{
	// Methods

	// RVA: 0x235FCF0 Offset: 0x235FDF1 VA: 0x235FCF0
	public static extern void GetState(ref NpadFullKeyState pOutValue, NpadId npadId) { }

	// RVA: 0x235F0D0 Offset: 0x235F1D1 VA: 0x235F0D0
	public static extern void GetState(ref NpadState pOutValue, NpadId npadId) { }

	// RVA: 0x235FD00 Offset: 0x235FE01 VA: 0x235FD00
	public static extern int GetStates([Out] NpadFullKeyState[] pOutValues, int count, NpadId npadId) { }

	// RVA: 0x235F580 Offset: 0x235F681 VA: 0x235F580
	public static extern int GetStates([Out] NpadStateArrayItem[] pOutValues, int count, NpadId npadId) { }
}

