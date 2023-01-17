// Namespace: App
public abstract class BasicItemMenuItem : BasicMenuItem // TypeDefIndex: 12506
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 27
	public abstract UnitItem GetUnitItem();

	// RVA: 0x28F4060 Offset: 0x28F4161 VA: 0x28F4060 Slot: 28
	public virtual Unit GetUnit() { }

	// RVA: 0x28F4070 Offset: 0x28F4171 VA: 0x28F4070 Slot: 29
	protected virtual Unit GetRecieverUnit() { }

	// RVA: 0x28F4080 Offset: 0x28F4181 VA: 0x28F4080 Slot: 30
	public virtual string GetBlankText() { }

	// RVA: 0x28F40D0 Offset: 0x28F41D1 VA: 0x28F40D0 Slot: 31
	public virtual bool IsVisibleItemIconOnBlank() { }

	// RVA: 0x28F40E0 Offset: 0x28F41E1 VA: 0x28F40E0 Slot: 10
	public override void OnBuild() { }

	// RVA: 0x28F40F0 Offset: 0x28F41F1 VA: 0x28F40F0 Slot: 11
	public override void OnBuildMenuItemContent() { }

	// RVA: 0x28F4100 Offset: 0x28F4201 VA: 0x28F4100 Slot: 7
	public override void SetTextColor(Color color, bool bInactive) { }

	// RVA: 0x28F46E0 Offset: 0x28F47E1 VA: 0x28F46E0 Slot: 32
	public virtual void SetInitialColor() { }

	// RVA: 0x28F4B50 Offset: 0x28F4C51 VA: 0x28F4B50 Slot: 33
	public virtual bool IsEffective() { }

	// RVA: 0x28F5760 Offset: 0x28F5861 VA: 0x28F5760
	protected void .ctor() { }
}

