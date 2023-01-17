// Namespace: App
public class MascotFoodEatSequence : SingletonProcInst<MascotFoodEatSequence> // TypeDefIndex: 10849
{
	// Fields
	private FoodstuffData m_foodStuffData; // 0x78

	// Properties
	private HubPlayerController PlayerController { get; }
	private HubUnitController Player { get; }
	private HubMascotController Mascot { get; }

	// Methods

	// RVA: 0x28515C0 Offset: 0x28516C1 VA: 0x28515C0
	public void .ctor(FoodstuffData foodstuffData) { }

	// RVA: 0x2851660 Offset: 0x2851761 VA: 0x2851660
	private HubPlayerController get_PlayerController() { }

	// RVA: 0x2851670 Offset: 0x2851771 VA: 0x2851670
	private HubUnitController get_Player() { }

	// RVA: 0x28516D0 Offset: 0x28517D1 VA: 0x28516D0
	private HubMascotController get_Mascot() { }

	// RVA: 0x2851770 Offset: 0x2851871 VA: 0x2851770
	private void InitEatFood() { }

	[IteratorStateMachineAttribute] // RVA: 0x2C25A0 Offset: 0x2C26A1 VA: 0x2C25A0
	// RVA: 0x2852390 Offset: 0x2852491 VA: 0x2852390
	private IEnumerator EatFood() { }

	// RVA: 0x2852410 Offset: 0x2852511 VA: 0x2852410
	private void ExitEatFood() { }

	// RVA: 0x2852D60 Offset: 0x2852E61 VA: 0x2852D60
	private void GetBond() { }

	// RVA: 0x2852E20 Offset: 0x2852F21 VA: 0x2852E20
	private ProcDesc[] CreateDesc() { }

	// RVA: 0x28534A0 Offset: 0x28535A1 VA: 0x28534A0
	public static void CreateBind(ProcInst super, FoodstuffData foodstuffData) { }
}

