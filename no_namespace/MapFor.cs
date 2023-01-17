// Namespace: 
public sealed class MapFor.UnitSkillFunction : MulticastDelegate // TypeDefIndex: 12019
{
	// Methods

	// RVA: 0x1D42370 Offset: 0x1D42471 VA: 0x1D42370
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1D42390 Offset: 0x1D42491 VA: 0x1D42390 Slot: 13
	public virtual void Invoke(Unit unit, SkillData skill) { }

	// RVA: 0x1D42700 Offset: 0x1D42801 VA: 0x1D42700 Slot: 14
	public virtual IAsyncResult BeginInvoke(Unit unit, SkillData skill, AsyncCallback callback, object object) { }

	// RVA: 0x1D42730 Offset: 0x1D42831 VA: 0x1D42730 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

