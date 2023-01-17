// Namespace: App
internal abstract class HubMoveState // TypeDefIndex: 10739
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool IsEnd();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Start(bool resume = False);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Update();

	[ConditionalAttribute] // RVA: 0x2C0B50 Offset: 0x2C0C51 VA: 0x2C0B50
	// RVA: 0x2BEFD30 Offset: 0x2BEFE31 VA: 0x2BEFD30 Slot: 7
	public virtual void OnDrawGizmos() { }

	// RVA: 0x2BEFD40 Offset: 0x2BEFE41 VA: 0x2BEFD40
	protected void .ctor() { }
}

