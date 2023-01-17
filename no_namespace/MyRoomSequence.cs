// Namespace: 
private enum MyRoomSequence.Label // TypeDefIndex: 11369
{
	// Fields
	public int value__; // 0x0
	public const MyRoomSequence.Label Entry = 0;
	public const MyRoomSequence.Label Select = 1;
	public const MyRoomSequence.Label Reliance = 2;
	public const MyRoomSequence.Label RelianceMain = 3;
	public const MyRoomSequence.Label WakeupConfirm = 4;
	public const MyRoomSequence.Label WakeupMain = 5;
	public const MyRoomSequence.Label WakeupExit = 6;
	public const MyRoomSequence.Label Recall = 7;
	public const MyRoomSequence.Label RecallReliance = 8;
	public const MyRoomSequence.Label RecallWakeup = 9;
	public const MyRoomSequence.Label RecallMovie = 10;
	public const MyRoomSequence.Label RecallMusic = 11;
	public const MyRoomSequence.Label SetDifficulty = 12;
	public const MyRoomSequence.Label Exit = 13;
}

// Namespace: 
private class MyRoomSequence.SleepConfirmDialog.ConfirmDialogItemYes : BasicDialogItemYes // TypeDefIndex: 11370
{
	// Methods

	// RVA: 0x21ED470 Offset: 0x21ED571 VA: 0x21ED470
	public void .ctor() { }

	// RVA: 0x21ED500 Offset: 0x21ED601 VA: 0x21ED500 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
private class MyRoomSequence.SleepConfirmDialog.ConfirmDialogItemNo : BasicDialogItemNo // TypeDefIndex: 11371
{
	// Methods

	// RVA: 0x21ED3E0 Offset: 0x21ED4E1 VA: 0x21ED3E0
	public void .ctor() { }
}

// Namespace: 
private class MyRoomSequence.SleepConfirmDialog : YesNoDialog // TypeDefIndex: 11372
{
	// Methods

	// RVA: 0x26E4270 Offset: 0x26E4371 VA: 0x26E4270
	private void .ctor(List<BasicMenuItem> menuItemList) { }

	// RVA: 0x26E42F0 Offset: 0x26E43F1 VA: 0x26E42F0
	public static void CreateBind(ProcInst super) { }
}

// Namespace: 
private class MyRoomSequence.RelianceUnitMenuItem : BasicMenuItem // TypeDefIndex: 11373
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x297BB0 Offset: 0x297CB1 VA: 0x297BB0
	private readonly PersonData <Self>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x297BC0 Offset: 0x297CC1 VA: 0x297BC0
	private readonly PersonData <Target>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x297BD0 Offset: 0x297CD1 VA: 0x297BD0
	private readonly bool <CanLevelUp>k__BackingField; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x297BE0 Offset: 0x297CE1 VA: 0x297BE0
	private readonly RelianceData.Level <Level>k__BackingField; // 0x7C

	// Properties
	public PersonData Self { get; }
	public PersonData Target { get; }
	public bool CanLevelUp { get; }
	public RelianceData.Level Level { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C51A0 Offset: 0x2C52A1 VA: 0x2C51A0
	// RVA: 0x26E3F80 Offset: 0x26E4081 VA: 0x26E3F80
	public PersonData get_Self() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C51B0 Offset: 0x2C52B1 VA: 0x2C51B0
	// RVA: 0x26E3F90 Offset: 0x26E4091 VA: 0x26E3F90
	public PersonData get_Target() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C51C0 Offset: 0x2C52C1 VA: 0x2C51C0
	// RVA: 0x26E3FA0 Offset: 0x26E40A1 VA: 0x26E3FA0
	public bool get_CanLevelUp() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C51D0 Offset: 0x2C52D1 VA: 0x2C51D0
	// RVA: 0x26E3FB0 Offset: 0x26E40B1 VA: 0x26E3FB0
	public RelianceData.Level get_Level() { }

	// RVA: 0x26E3ED0 Offset: 0x26E3FD1 VA: 0x26E3ED0
	public void .ctor(PersonData self, PersonData target) { }

	// RVA: 0x26E3FC0 Offset: 0x26E40C1 VA: 0x26E3FC0 Slot: 4
	public override string GetName() { }

	// RVA: 0x26E41C0 Offset: 0x26E42C1 VA: 0x26E41C0 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
private class MyRoomSequence.RelianceListMenu : BasicMenu // TypeDefIndex: 11374
{
	// Methods

	// RVA: 0x26E3AF0 Offset: 0x26E3BF1 VA: 0x26E3AF0
	protected void .ctor(List<BasicMenuItem> menuItemList, ProcInst super) { }

	// RVA: 0x26E3B70 Offset: 0x26E3C71 VA: 0x26E3B70 Slot: 30
	public override string GetName() { }

	// RVA: 0x26E3BC0 Offset: 0x26E3CC1 VA: 0x26E3BC0 Slot: 9
	protected override void OnCreate() { }

	// RVA: 0x26E3BD0 Offset: 0x26E3CD1 VA: 0x26E3BD0 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x26E3BE0 Offset: 0x26E3CE1 VA: 0x26E3BE0
	public static void CreateBind(ProcInst super) { }
}

