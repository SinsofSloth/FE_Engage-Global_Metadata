// Namespace: App
public class MinigameAssistDialog : BasicDialog // TypeDefIndex: 11270
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x297340 Offset: 0x297441 VA: 0x297340
	private MinigameAssistDialog.DecideEventHandler <EventHandler>k__BackingField; // 0xD8
	private static string[] ConfirmLabels; // 0x0
	private static string[] YesLabels; // 0x8
	private static string[] NoLabels; // 0x10
	private static string[] CancelLabels; // 0x18

	// Properties
	public MinigameAssistDialog.DecideEventHandler EventHandler { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C3FC0 Offset: 0x2C40C1 VA: 0x2C3FC0
	// RVA: 0x22794D0 Offset: 0x22795D1 VA: 0x22794D0
	public MinigameAssistDialog.DecideEventHandler get_EventHandler() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3FD0 Offset: 0x2C40D1 VA: 0x2C3FD0
	// RVA: 0x22794E0 Offset: 0x22795E1 VA: 0x22794E0
	public void set_EventHandler(MinigameAssistDialog.DecideEventHandler value) { }

	// RVA: 0x22794F0 Offset: 0x22795F1 VA: 0x22794F0
	public void .ctor(List<BasicMenuItem> menuItemList, BasicDialogContent menuContent, MinigameAssistDialog.DecideEventHandler eventHandler) { }

	// RVA: 0x2279540 Offset: 0x2279641 VA: 0x2279540
	public static MinigameAssistDialog CreateBind(ProcInst super, MinigameAssistDialog.MinigameType type, MinigameAssistDialog.DecideEventHandler eventHandler) { }

	// RVA: 0x2279860 Offset: 0x2279961 VA: 0x2279860 Slot: 30
	public override string GetName() { }

	// RVA: 0x22798B0 Offset: 0x22799B1 VA: 0x22798B0 Slot: 26
	public override void OnClose() { }

	// RVA: 0x2279960 Offset: 0x2279A61 VA: 0x2279960 Slot: 50
	protected override BasicMenu.Result ACall() { }

	// RVA: 0x22799B0 Offset: 0x2279AB1 VA: 0x22799B0 Slot: 51
	protected override BasicMenu.Result BCall() { }

	// RVA: 0x22799E0 Offset: 0x2279AE1 VA: 0x22799E0
	private static void .cctor() { }
}

