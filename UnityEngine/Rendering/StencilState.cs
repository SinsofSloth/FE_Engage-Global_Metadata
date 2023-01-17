// Namespace: UnityEngine.Rendering
public struct StencilState : IEquatable<StencilState> // TypeDefIndex: 3966
{
	// Fields
	private byte m_Enabled; // 0x0
	private byte m_ReadMask; // 0x1
	private byte m_WriteMask; // 0x2
	private byte m_Padding; // 0x3
	private byte m_CompareFunctionFront; // 0x4
	private byte m_PassOperationFront; // 0x5
	private byte m_FailOperationFront; // 0x6
	private byte m_ZFailOperationFront; // 0x7
	private byte m_CompareFunctionBack; // 0x8
	private byte m_PassOperationBack; // 0x9
	private byte m_FailOperationBack; // 0xA
	private byte m_ZFailOperationBack; // 0xB

	// Properties
	public static StencilState defaultValue { get; }
	public bool enabled { get; set; }
	public byte readMask { get; }
	public byte writeMask { get; }
	public CompareFunction compareFunctionFront { get; set; }
	public StencilOp passOperationFront { get; set; }
	public StencilOp failOperationFront { get; set; }
	public StencilOp zFailOperationFront { get; set; }
	public CompareFunction compareFunctionBack { get; set; }
	public StencilOp passOperationBack { get; set; }
	public StencilOp failOperationBack { get; set; }
	public StencilOp zFailOperationBack { get; set; }

	// Methods

	// RVA: 0x31DB4A0 Offset: 0x31DB5A1 VA: 0x31DB4A0
	public static StencilState get_defaultValue() { }

	// RVA: 0x31F22D0 Offset: 0x31F23D1 VA: 0x31F22D0
	public void .ctor(bool enabled = True, byte readMask = 255, byte writeMask = 255, CompareFunction compareFunction = 8, StencilOp passOperation = 0, StencilOp failOperation = 0, StencilOp zFailOperation = 0) { }

	// RVA: 0x31F23B0 Offset: 0x31F24B1 VA: 0x31F23B0
	public void .ctor(bool enabled, byte readMask, byte writeMask, CompareFunction compareFunctionFront, StencilOp passOperationFront, StencilOp failOperationFront, StencilOp zFailOperationFront, CompareFunction compareFunctionBack, StencilOp passOperationBack, StencilOp failOperationBack, StencilOp zFailOperationBack) { }

	// RVA: 0x31F24B0 Offset: 0x31F25B1 VA: 0x31F24B0
	public bool get_enabled() { }

	// RVA: 0x31F2520 Offset: 0x31F2621 VA: 0x31F2520
	public void set_enabled(bool value) { }

	// RVA: 0x31F25A0 Offset: 0x31F26A1 VA: 0x31F25A0
	public byte get_readMask() { }

	// RVA: 0x31F25B0 Offset: 0x31F26B1 VA: 0x31F25B0
	public byte get_writeMask() { }

	// RVA: 0x31F25C0 Offset: 0x31F26C1 VA: 0x31F25C0
	public void SetCompareFunction(CompareFunction value) { }

	// RVA: 0x31F25F0 Offset: 0x31F26F1 VA: 0x31F25F0
	public void SetPassOperation(StencilOp value) { }

	// RVA: 0x31F2620 Offset: 0x31F2721 VA: 0x31F2620
	public void SetFailOperation(StencilOp value) { }

	// RVA: 0x31F2650 Offset: 0x31F2751 VA: 0x31F2650
	public void SetZFailOperation(StencilOp value) { }

	// RVA: 0x31F2680 Offset: 0x31F2781 VA: 0x31F2680
	public CompareFunction get_compareFunctionFront() { }

	// RVA: 0x31F25D0 Offset: 0x31F26D1 VA: 0x31F25D0
	public void set_compareFunctionFront(CompareFunction value) { }

	// RVA: 0x31F2690 Offset: 0x31F2791 VA: 0x31F2690
	public StencilOp get_passOperationFront() { }

	// RVA: 0x31F2600 Offset: 0x31F2701 VA: 0x31F2600
	public void set_passOperationFront(StencilOp value) { }

	// RVA: 0x31F26A0 Offset: 0x31F27A1 VA: 0x31F26A0
	public StencilOp get_failOperationFront() { }

	// RVA: 0x31F2630 Offset: 0x31F2731 VA: 0x31F2630
	public void set_failOperationFront(StencilOp value) { }

	// RVA: 0x31F26B0 Offset: 0x31F27B1 VA: 0x31F26B0
	public StencilOp get_zFailOperationFront() { }

	// RVA: 0x31F2660 Offset: 0x31F2761 VA: 0x31F2660
	public void set_zFailOperationFront(StencilOp value) { }

	// RVA: 0x31F26C0 Offset: 0x31F27C1 VA: 0x31F26C0
	public CompareFunction get_compareFunctionBack() { }

	// RVA: 0x31F25E0 Offset: 0x31F26E1 VA: 0x31F25E0
	public void set_compareFunctionBack(CompareFunction value) { }

	// RVA: 0x31F26D0 Offset: 0x31F27D1 VA: 0x31F26D0
	public StencilOp get_passOperationBack() { }

	// RVA: 0x31F2610 Offset: 0x31F2711 VA: 0x31F2610
	public void set_passOperationBack(StencilOp value) { }

	// RVA: 0x31F26E0 Offset: 0x31F27E1 VA: 0x31F26E0
	public StencilOp get_failOperationBack() { }

	// RVA: 0x31F2640 Offset: 0x31F2741 VA: 0x31F2640
	public void set_failOperationBack(StencilOp value) { }

	// RVA: 0x31F26F0 Offset: 0x31F27F1 VA: 0x31F26F0
	public StencilOp get_zFailOperationBack() { }

	// RVA: 0x31F2670 Offset: 0x31F2771 VA: 0x31F2670
	public void set_zFailOperationBack(StencilOp value) { }

	// RVA: 0x31DB740 Offset: 0x31DB841 VA: 0x31DB740 Slot: 4
	public bool Equals(StencilState other) { }

	// RVA: 0x31F2700 Offset: 0x31F2801 VA: 0x31F2700 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x31DB980 Offset: 0x31DBA81 VA: 0x31DB980 Slot: 2
	public override int GetHashCode() { }
}

