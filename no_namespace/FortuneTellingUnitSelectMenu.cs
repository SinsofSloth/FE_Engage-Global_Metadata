// Namespace: 
public sealed class FortuneTellingUnitSelectMenu.DecideEventHandler : MulticastDelegate // TypeDefIndex: 10629
{
	// Methods

	// RVA: 0x22DFE70 Offset: 0x22DFF71 VA: 0x22DFE70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x22DFE90 Offset: 0x22DFF91 VA: 0x22DFE90 Slot: 13
	public virtual void Invoke(Unit unit) { }

	// RVA: 0x22E01F0 Offset: 0x22E02F1 VA: 0x22E01F0 Slot: 14
	public virtual IAsyncResult BeginInvoke(Unit unit, AsyncCallback callback, object object) { }

	// RVA: 0x22E0220 Offset: 0x22E0321 VA: 0x22E0220 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public class FortuneTellingUnitSelectMenu.FortuneTellingUnitSelectMenuItem : BasicMenuItem // TypeDefIndex: 10630
{
	// Fields
	private Unit m_Unit; // 0x68
	private bool m_bSelect; // 0x70
	public FortuneTellingUnitSelectMenu.DecideEventHandler m_DecideEventHandler; // 0x78

	// Methods

	// RVA: 0x22E0230 Offset: 0x22E0331 VA: 0x22E0230
	public void .ctor(Unit unit, FortuneTellingUnitSelectMenu.DecideEventHandler decideEventHandler, Unit selectUnit) { }

	// RVA: 0x22E02A0 Offset: 0x22E03A1 VA: 0x22E02A0 Slot: 4
	public override string GetName() { }

	// RVA: 0x22E02B0 Offset: 0x22E03B1 VA: 0x22E02B0 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x22E02D0 Offset: 0x22E03D1 VA: 0x22E02D0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x22E0320 Offset: 0x22E0421 VA: 0x22E0320 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x22E0350 Offset: 0x22E0451 VA: 0x22E0350
	public Unit GetUnit() { }
}

