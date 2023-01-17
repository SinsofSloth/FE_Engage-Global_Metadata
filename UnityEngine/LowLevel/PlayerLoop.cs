// Namespace: UnityEngine.LowLevel
[MovedFromAttribute] // RVA: 0x43FBE0 Offset: 0x43FCE1 VA: 0x43FBE0
public class PlayerLoop // TypeDefIndex: 3722
{
	// Methods

	// RVA: 0x3496950 Offset: 0x3496A51 VA: 0x3496950
	public static PlayerLoopSystem GetDefaultPlayerLoop() { }

	// RVA: 0x3496C60 Offset: 0x3496D61 VA: 0x3496C60
	public static void SetPlayerLoop(PlayerLoopSystem loop) { }

	// RVA: 0x3496D60 Offset: 0x3496E61 VA: 0x3496D60
	private static int PlayerLoopSystemToInternal(PlayerLoopSystem sys, ref List<PlayerLoopSystemInternal> internalSys) { }

	// RVA: 0x3496A10 Offset: 0x3496B11 VA: 0x3496A10
	private static PlayerLoopSystem InternalToPlayerLoopSystem(PlayerLoopSystemInternal[] internalSys, ref int offset) { }

	[NativeMethodAttribute] // RVA: 0x452E30 Offset: 0x452F31 VA: 0x452E30
	// RVA: 0x34969D0 Offset: 0x3496AD1 VA: 0x34969D0
	private static PlayerLoopSystemInternal[] GetDefaultPlayerLoopInternal() { }

	[NativeMethodAttribute] // RVA: 0x452E70 Offset: 0x452F71 VA: 0x452E70
	// RVA: 0x3496F10 Offset: 0x3497011 VA: 0x3496F10
	private static void SetPlayerLoopInternal(PlayerLoopSystemInternal[] loop) { }
}

