// Namespace: System.Threading
[ComVisibleAttribute] // RVA: 0x473370 Offset: 0x473471 VA: 0x473370
public static class Monitor // TypeDefIndex: 766
{
	// Methods

	// RVA: 0x34F2F70 Offset: 0x34F3071 VA: 0x34F2F70
	public static void Enter(object obj) { }

	// RVA: 0x34E3CA0 Offset: 0x34E3DA1 VA: 0x34E3CA0
	public static void Enter(object obj, ref bool lockTaken) { }

	// RVA: 0x34F2F80 Offset: 0x34F3081 VA: 0x34F2F80
	private static void ThrowLockTakenException() { }

	[ReliabilityContractAttribute] // RVA: 0x47C770 Offset: 0x47C871 VA: 0x47C770
	// RVA: 0x34E3D20 Offset: 0x34E3E21 VA: 0x34E3D20
	public static void Exit(object obj) { }

	// RVA: 0x34F3060 Offset: 0x34F3161 VA: 0x34F3060
	public static void TryEnter(object obj, ref bool lockTaken) { }

	// RVA: 0x34F3180 Offset: 0x34F3281 VA: 0x34F3180
	public static bool Wait(object obj, int millisecondsTimeout, bool exitContext) { }

	// RVA: 0x34E47D0 Offset: 0x34E48D1 VA: 0x34E47D0
	public static bool Wait(object obj, int millisecondsTimeout) { }

	// RVA: 0x34F32B0 Offset: 0x34F33B1 VA: 0x34F32B0
	public static void Pulse(object obj) { }

	// RVA: 0x34E3FB0 Offset: 0x34E40B1 VA: 0x34E3FB0
	public static void PulseAll(object obj) { }

	// RVA: 0x34F33F0 Offset: 0x34F34F1 VA: 0x34F33F0
	private static bool Monitor_test_synchronised(object obj) { }

	// RVA: 0x34F3400 Offset: 0x34F3501 VA: 0x34F3400
	private static void Monitor_pulse(object obj) { }

	// RVA: 0x34F3310 Offset: 0x34F3411 VA: 0x34F3310
	private static void ObjPulse(object obj) { }

	// RVA: 0x34F3410 Offset: 0x34F3511 VA: 0x34F3410
	private static void Monitor_pulse_all(object obj) { }

	// RVA: 0x34F3380 Offset: 0x34F3481 VA: 0x34F3380
	private static void ObjPulseAll(object obj) { }

	// RVA: 0x34F3420 Offset: 0x34F3521 VA: 0x34F3420
	private static bool Monitor_wait(object obj, int ms) { }

	// RVA: 0x34F31F0 Offset: 0x34F32F1 VA: 0x34F31F0
	private static bool ObjWait(bool exitContext, int millisecondsTimeout, object obj) { }

	// RVA: 0x34F3430 Offset: 0x34F3531 VA: 0x34F3430
	private static void try_enter_with_atomic_var(object obj, int millisecondsTimeout, ref bool lockTaken) { }

	// RVA: 0x34F30E0 Offset: 0x34F31E1 VA: 0x34F30E0
	private static void ReliableEnterTimeout(object obj, int timeout, ref bool lockTaken) { }

	// RVA: 0x34F2FF0 Offset: 0x34F30F1 VA: 0x34F2FF0
	private static void ReliableEnter(object obj, ref bool lockTaken) { }
}

