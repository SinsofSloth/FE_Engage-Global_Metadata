// Namespace: App
public abstract class ProfileCardVisualBaseMenuItem : BasicMenuItem // TypeDefIndex: 11668
{
	// Fields
	protected bool m_Decided; // 0x64

	// Methods

	// RVA: 0x2EE7E10 Offset: 0x2EE7F11 VA: 0x2EE7E10
	public void .ctor(bool initialSelect) { }

	// RVA: 0x2EE7E40 Offset: 0x2EE7F41 VA: 0x2EE7E40 Slot: 10
	public override void OnBuild() { }

	// RVA: 0x2EE7FB0 Offset: 0x2EE80B1 VA: 0x2EE7FB0 Slot: 11
	public override void OnBuildMenuItemContent() { }

	// RVA: 0x2EE7E50 Offset: 0x2EE7F51 VA: 0x2EE7E50
	public void SetInitialColor() { }

	// RVA: 0x2EE7FE0 Offset: 0x2EE80E1 VA: 0x2EE7FE0
	public void UpdateFixedCursor() { }

	// RVA: 0x2EE8140 Offset: 0x2EE8241 VA: 0x2EE8140
	public void UpdateNewIcon() { }

	// RVA: -1 Offset: -1 Slot: 27
	protected abstract bool IsNewArrival();

	// RVA: -1 Offset: -1 Slot: 28
	protected abstract void SetAlreadyRead();

	// RVA: 0x2EE8460 Offset: 0x2EE8561 VA: 0x2EE8460
	public void SetDecided(bool decided) { }

	// RVA: 0x2EE84A0 Offset: 0x2EE85A1 VA: 0x2EE84A0 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x2EE88A0 Offset: 0x2EE89A1 VA: 0x2EE88A0 Slot: 14
	public override void OnCursorMoveEnd() { }

	// RVA: 0x2EE88B0 Offset: 0x2EE89B1 VA: 0x2EE88B0 Slot: 13
	public override void OnDeselect() { }

	// RVA: 0x2EE88E0 Offset: 0x2EE89E1 VA: 0x2EE88E0 Slot: 18
	public override BasicMenu.Result ACall() { }
}

