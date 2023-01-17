// Namespace: nn.hid
public static class DebugPad // TypeDefIndex: 14628
{
	// Fields
	public const int StateCountMax = 16;

	// Methods

	// RVA: 0x2EA8410 Offset: 0x2EA8511 VA: 0x2EA8410
	public static void Initialize() { }

	// RVA: 0x2EA8420 Offset: 0x2EA8521 VA: 0x2EA8420
	public static void GetState(ref DebugPadState pOutValue) { }

	// RVA: 0x2EA8430 Offset: 0x2EA8531 VA: 0x2EA8430
	public static int GetStates([Out] DebugPadState[] pOutValues, int count) { }
}

