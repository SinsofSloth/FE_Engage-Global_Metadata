// Namespace: 
[FlagsAttribute] // RVA: 0x2790B0 Offset: 0x2791B1 VA: 0x2790B0
private enum GameSkip.Status // TypeDefIndex: 13602
{
	// Fields
	public int value__; // 0x0
	public const GameSkip.Status Disable = 1;
	public const GameSkip.Status Trigger = 2;
	public const GameSkip.Status Escape = 4;
	public const GameSkip.Status ShortSkipable = 8;
	public const GameSkip.Status ShortSkipping = 16;
	public const GameSkip.Status TriggerAI = 32;
	public const GameSkip.Status DisableAISkip = 64;
}

// Namespace: 
private enum GameSkip.Result // TypeDefIndex: 13604
{
	// Fields
	public int value__; // 0x0
	public const GameSkip.Result None = 0;
	public const GameSkip.Result ShortSkip = 1;
	public const GameSkip.Result LongSkip = 2;
}

// Namespace: 
private class GameSkip.ProcSuspend : ProcInst // TypeDefIndex: 13606
{
	// Methods

	// RVA: 0x22E9620 Offset: 0x22E9721 VA: 0x22E9620 Slot: 9
	protected override void OnCreate() { }

	// RVA: 0x22E9640 Offset: 0x22E9741 VA: 0x22E9640 Slot: 6
	protected override void OnTick() { }

	// RVA: 0x22E9650 Offset: 0x22E9751 VA: 0x22E9650 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x22E9660 Offset: 0x22E9761 VA: 0x22E9660
	public void .ctor() { }
}

