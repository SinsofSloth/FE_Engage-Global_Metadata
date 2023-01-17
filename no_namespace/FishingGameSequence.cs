// Namespace: 
private struct FishingGameSequence.LureRoot // TypeDefIndex: 10590
{
	// Fields
	public float x; // 0x0
	public float y; // 0x4
	public float frame; // 0x8

	// Methods

	// RVA: 0x22DC670 Offset: 0x22DC771 VA: 0x22DC670
	public void .ctor(float setX, float setY, float setFrame) { }
}

// Namespace: 
private enum FishingGameSequence.FishingAngleState // TypeDefIndex: 10592
{
	// Fields
	public int value__; // 0x0
	public const FishingGameSequence.FishingAngleState Center = 0;
	public const FishingGameSequence.FishingAngleState Right = 1;
	public const FishingGameSequence.FishingAngleState Left = 2;
	public const FishingGameSequence.FishingAngleState Lethal = 3;
	public const FishingGameSequence.FishingAngleState AngleStateCount = 4;
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x276FC0 Offset: 0x2770C1 VA: 0x276FC0
[Serializable]
private sealed class FishingGameSequence.<>c // TypeDefIndex: 10594
{
	// Fields
	public static readonly FishingGameSequence.<>c <>9; // 0x0
	public static FishingRodSelectMenu.DecideEventHandler <>9__188_0; // 0x8
	public static FishingContinueDialog.DecideEventHandler <>9__215_0; // 0x10
	public static ProcBoolMethod <>9__248_0; // 0x18
	public static ProcBoolMethod <>9__248_1; // 0x20

	// Methods

	// RVA: 0x22DC420 Offset: 0x22DC521 VA: 0x22DC420
	private static void .cctor() { }

	// RVA: 0x22DC490 Offset: 0x22DC591 VA: 0x22DC490
	public void .ctor() { }

	// RVA: 0x22DC4A0 Offset: 0x22DC5A1 VA: 0x22DC4A0
	internal void <CreateRodSelectMenu>b__188_0(StickType r) { }

	// RVA: 0x22DC510 Offset: 0x22DC611 VA: 0x22DC510
	internal void <CreateContinueDialog>b__215_0(bool r) { }

	// RVA: 0x22DC590 Offset: 0x22DC691 VA: 0x22DC590
	internal bool <CreateBind>b__248_0() { }

	// RVA: 0x22DC600 Offset: 0x22DC701 VA: 0x22DC600
	internal bool <CreateBind>b__248_1() { }
}

