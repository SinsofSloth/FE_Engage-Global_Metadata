// Namespace: 
public sealed class UnitSelectMenu.UnitSelectMenuItem.SelectEventHandler : MulticastDelegate // TypeDefIndex: 14256
{
	// Methods

	// RVA: 0x2D6A900 Offset: 0x2D6AA01 VA: 0x2D6A900
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2D6A920 Offset: 0x2D6AA21 VA: 0x2D6A920 Slot: 13
	public virtual void Invoke(Unit unit) { }

	// RVA: 0x2D6AC80 Offset: 0x2D6AD81 VA: 0x2D6AC80 Slot: 14
	public virtual IAsyncResult BeginInvoke(Unit unit, AsyncCallback callback, object object) { }

	// RVA: 0x2D6ACB0 Offset: 0x2D6ADB1 VA: 0x2D6ACB0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public class UnitSelectMenu.UnitSelectMenuItem : BasicMenuItem // TypeDefIndex: 14257
{
	// Fields
	private Unit m_Unit; // 0x68
	private bool m_IsDecided; // 0x70
	private UnitSelectMenu.UnitSelectMenuItem.SelectEventHandler m_SelectEventHander; // 0x78

	// Methods

	// RVA: 0x1ED6B90 Offset: 0x1ED6C91 VA: 0x1ED6B90
	public void .ctor(Unit unit, UnitSelectMenu.UnitSelectMenuItem.SelectEventHandler selectEventHandler) { }

	// RVA: 0x1ED6BE0 Offset: 0x1ED6CE1 VA: 0x1ED6BE0
	public Unit Decide() { }

	// RVA: 0x1ED6BF0 Offset: 0x1ED6CF1 VA: 0x1ED6BF0
	public void Cancel() { }

	// RVA: 0x1ED6C00 Offset: 0x1ED6D01 VA: 0x1ED6C00 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x1ED6DF0 Offset: 0x1ED6EF1 VA: 0x1ED6DF0 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x1ED6E00 Offset: 0x1ED6F01 VA: 0x1ED6E00
	public Unit GetUnit() { }

	// RVA: 0x1ED6E10 Offset: 0x1ED6F11 VA: 0x1ED6E10
	public bool IsDecided() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x279880 Offset: 0x279981 VA: 0x279880
private sealed class UnitSelectMenu.<>c__DisplayClass8_0 // TypeDefIndex: 14258
{
	// Fields
	public List<UnitSelectMenu.UnitSelectMenuItem> unitMenuItemList; // 0x10

	// Methods

	// RVA: 0x1ED6A20 Offset: 0x1ED6B21 VA: 0x1ED6A20
	public void .ctor() { }

	// RVA: 0x1ED6A30 Offset: 0x1ED6B31 VA: 0x1ED6A30
	internal void <CreateBind>b__0(Unit unit) { }
}

