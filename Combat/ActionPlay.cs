// Namespace: Combat
internal sealed class ActionPlay : ActionBase // TypeDefIndex: 8422
{
	// Fields
	private int m_Hash; // 0x28
	private bool m_WaitIdle; // 0x2C
	private float m_StartTime; // 0x30

	// Properties
	public override string Name { get; }
	public override bool AbortByInterrupt { get; }

	// Methods

	// RVA: 0x2EC84C0 Offset: 0x2EC85C1 VA: 0x2EC84C0 Slot: 5
	public override string get_Name() { }

	// RVA: 0x2EC8560 Offset: 0x2EC8661 VA: 0x2EC8560 Slot: 11
	public override bool get_AbortByInterrupt() { }

	// RVA: 0x2EC8570 Offset: 0x2EC8671 VA: 0x2EC8570
	public void .ctor(Character chr, int hash, bool waitIdle = True, float startTime = -1) { }

	// RVA: 0x2EC8600 Offset: 0x2EC8701 VA: 0x2EC8600 Slot: 6
	public override void OnEnter() { }

	// RVA: 0x2EC8620 Offset: 0x2EC8721 VA: 0x2EC8620 Slot: 7
	public override void OnUpdate() { }
}

