// Namespace: nn.hid
public static class Gesture // TypeDefIndex: 14636
{
	// Fields
	public const int PointCountMax = 4;
	public const int StateCountMax = 16;

	// Methods

	// RVA: 0x28E0DF0 Offset: 0x28E0EF1 VA: 0x28E0DF0
	public static extern void Initialize() { }

	// RVA: 0x28E0E00 Offset: 0x28E0F01 VA: 0x28E0E00
	public static extern int GetStates([In] [Out] GestureState[] pOutValues, int count) { }
}

