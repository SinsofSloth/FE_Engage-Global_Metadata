// Namespace: nn.hid
public static class NpadJoy // TypeDefIndex: 14654
{
	// Properties
	public static ErrorRange ResultDualConnected { get; }
	public static ErrorRange ResultSameJoyTypeConnected { get; }

	// Methods

	// RVA: 0x2360470 Offset: 0x2360571 VA: 0x2360470
	public static extern NpadJoyAssignmentMode GetAssignment(NpadId npadId) { }

	// RVA: 0x2360480 Offset: 0x2360581 VA: 0x2360480
	public static extern void SetAssignmentModeSingle(NpadId npadId) { }

	// RVA: 0x2360490 Offset: 0x2360591 VA: 0x2360490
	public static extern void SetAssignmentModeSingle(NpadId npadId, NpadJoyDeviceType deviceType) { }

	// RVA: 0x23604A0 Offset: 0x23605A1 VA: 0x23604A0
	public static extern void SetAssignmentModeSingle(ref NpadId pOutValue, NpadId npadId, NpadJoyDeviceType deviceType) { }

	// RVA: 0x23604B0 Offset: 0x23605B1 VA: 0x23604B0
	public static extern void SetAssignmentModeDual(NpadId npadId) { }

	// RVA: 0x23604C0 Offset: 0x23605C1 VA: 0x23604C0
	public static extern Result MergeSingleAsDual(NpadId npadId1, NpadId npadId2) { }

	// RVA: 0x23604E0 Offset: 0x23605E1 VA: 0x23604E0
	public static extern void SwapAssignment(NpadId npadId1, NpadId npadId2) { }

	// RVA: 0x23604F0 Offset: 0x23605F1 VA: 0x23604F0
	public static extern void SetHoldType(NpadJoyHoldType holdType) { }

	// RVA: 0x2360500 Offset: 0x2360601 VA: 0x2360500
	public static extern NpadJoyHoldType GetHoldType() { }

	// RVA: 0x2360510 Offset: 0x2360611 VA: 0x2360510
	public static extern void StartLrAssignmentMode() { }

	// RVA: 0x2360520 Offset: 0x2360621 VA: 0x2360520
	public static extern void StopLrAssignmentMode() { }

	// RVA: 0x2360530 Offset: 0x2360631 VA: 0x2360530
	public static extern void SetHandheldActivationMode(NpadHandheldActivationMode activationMode) { }

	// RVA: 0x2360540 Offset: 0x2360641 VA: 0x2360540
	public static extern NpadHandheldActivationMode GetHandheldActivationMode() { }

	// RVA: 0x2360550 Offset: 0x2360651 VA: 0x2360550
	public static extern void SetCommunicationMode(NpadCommunicationMode mode) { }

	// RVA: 0x2360560 Offset: 0x2360661 VA: 0x2360560
	public static extern NpadCommunicationMode GetCommunicationMode() { }

	// RVA: 0x2360570 Offset: 0x2360671 VA: 0x2360570
	public static ErrorRange get_ResultDualConnected() { }

	// RVA: 0x23605B0 Offset: 0x23606B1 VA: 0x23605B0
	public static ErrorRange get_ResultSameJoyTypeConnected() { }
}

