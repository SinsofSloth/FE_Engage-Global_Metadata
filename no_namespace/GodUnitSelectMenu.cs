// Namespace: 
public sealed class GodUnitSelectMenu.DecideEventHandler : MulticastDelegate // TypeDefIndex: 11732
{
	// Methods

	// RVA: 0x1FA4260 Offset: 0x1FA4361 VA: 0x1FA4260
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1FA4280 Offset: 0x1FA4381 VA: 0x1FA4280 Slot: 13
	public virtual void Invoke(BasicMenu.Result result, GodUnit god, RingCleaningSequence.GodType type) { }

	// RVA: 0x1FA4510 Offset: 0x1FA4611 VA: 0x1FA4510 Slot: 14
	public virtual IAsyncResult BeginInvoke(BasicMenu.Result result, GodUnit god, RingCleaningSequence.GodType type, AsyncCallback callback, object object) { }

	// RVA: 0x1FA45D0 Offset: 0x1FA46D1 VA: 0x1FA45D0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x277AB0 Offset: 0x277BB1 VA: 0x277AB0
private sealed class GodUnitSelectMenu.<>c__DisplayClass3_0 // TypeDefIndex: 11734
{
	// Fields
	public List<BasicMenuItem> menuItemList; // 0x10
	public GodUnitSelectMenu.SelectEventHandler selectEventHandler; // 0x18
	public GodUnitSelectMenu.DecideEventHandler decideEventHandler; // 0x20
	public GodUnit selectedGod; // 0x28

	// Methods

	// RVA: 0x1FA4120 Offset: 0x1FA4221 VA: 0x1FA4120
	public void .ctor() { }

	// RVA: 0x1FA4130 Offset: 0x1FA4231 VA: 0x1FA4130
	internal void <CreateBind>b__0(GodUnit god) { }
}

