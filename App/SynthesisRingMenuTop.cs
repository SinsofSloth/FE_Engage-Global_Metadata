// Namespace: App
public class SynthesisRingMenuTop // TypeDefIndex: 11238
{
	// Fields
	private SynthesisRingRoot m_SynthesisRingRoot; // 0x10
	private SynthesisRingBaseRingMenu m_SynthesisRingBaseRingMenu; // 0x18
	private SynthesisRingMenuTop.DecideEventHandler m_DecideEventHandler; // 0x20
	private RingData m_RingData; // 0x28
	private int m_CountBaseRing; // 0x30
	private int m_CountPieceOfBonds; // 0x34
	private int m_GodUnitIndex; // 0x38
	private BasicMenuSelect m_MenuSelect; // 0x40

	// Methods

	// RVA: 0x292F570 Offset: 0x292F671 VA: 0x292F570
	public static SynthesisRingMenuTop CreateBind(ProcInst super, int initialGodUnitIndex, BasicMenuSelect initialMenuSelect, SynthesisRingMenuTop.DecideEventHandler decideEventHandler) { }

	// RVA: 0x292F910 Offset: 0x292FA11 VA: 0x292F910
	public void Destroy() { }

	// RVA: 0x292F600 Offset: 0x292F701 VA: 0x292F600
	private void .ctor(ProcInst super, int initialGodUnitIndex, BasicMenuSelect initialMenuSelect, SynthesisRingMenuTop.DecideEventHandler decideEventHandler) { }

	// RVA: 0x292FC30 Offset: 0x292FD31 VA: 0x292FC30
	public void OnSelect(RingData ringData) { }

	// RVA: 0x292FD70 Offset: 0x292FE71 VA: 0x292FD70
	private void OnDecideSynthesis(RingData ringData, int countBaseRing, int countPieceOfBonds, int godUnitIndex, BasicMenuSelect menuSelect) { }

	// RVA: 0x292FFF0 Offset: 0x29300F1 VA: 0x292FFF0
	private void OnYesToConfirm() { }

	// RVA: 0x29300A0 Offset: 0x29301A1 VA: 0x29300A0
	public void OnCancelClose() { }
}

