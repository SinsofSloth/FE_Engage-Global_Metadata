// Namespace: 
public sealed class GodRoomUnitSelectMenu.DecideEventHandler : MulticastDelegate // TypeDefIndex: 10994
{
	// Methods

	// RVA: 0x1FA38C0 Offset: 0x1FA39C1 VA: 0x1FA38C0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1FA38E0 Offset: 0x1FA39E1 VA: 0x1FA38E0 Slot: 13
	public virtual void Invoke(Unit unit, List<GodUnit> godList) { }

	// RVA: 0x1FA3C50 Offset: 0x1FA3D51 VA: 0x1FA3C50 Slot: 14
	public virtual IAsyncResult BeginInvoke(Unit unit, List<GodUnit> godList, AsyncCallback callback, object object) { }

	// RVA: 0x1FA3C80 Offset: 0x1FA3D81 VA: 0x1FA3C80 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public class GodRoomUnitSelectMenu.GodRoomUnitSelectMenuItem : BasicMenuItem // TypeDefIndex: 10995
{
	// Fields
	private int m_Index; // 0x64
	private Unit m_Unit; // 0x68
	public GodRoomUnitSelectMenu.DecideEventHandler m_DecideEventHandler; // 0x70

	// Methods

	// RVA: 0x1FA3CE0 Offset: 0x1FA3DE1 VA: 0x1FA3CE0
	public void .ctor(int index, Unit unit, GodRoomUnitSelectMenu.DecideEventHandler decideEventHandler) { }

	// RVA: 0x1FA3F90 Offset: 0x1FA4091 VA: 0x1FA3F90 Slot: 4
	public override string GetName() { }

	// RVA: 0x1FA3FA0 Offset: 0x1FA40A1 VA: 0x1FA3FA0 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x1FA3EE0 Offset: 0x1FA3FE1 VA: 0x1FA3EE0 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x1FA3FB0 Offset: 0x1FA40B1 VA: 0x1FA3FB0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x1FA4070 Offset: 0x1FA4171 VA: 0x1FA4070 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x1FA4110 Offset: 0x1FA4211 VA: 0x1FA4110
	public Unit GetUnit() { }
}

// Namespace: 
public class GodRoomUnitSelectMenu.GodRoomUnitSelectEmptyMenuItem : GodRoomUnitSelectMenu.GodRoomUnitSelectMenuItem // TypeDefIndex: 10996
{
	// Methods

	// RVA: 0x1FA3C90 Offset: 0x1FA3D91 VA: 0x1FA3C90
	public void .ctor() { }

	// RVA: 0x1FA3D40 Offset: 0x1FA3E41 VA: 0x1FA3D40 Slot: 4
	public override string GetName() { }

	// RVA: 0x1FA3DC0 Offset: 0x1FA3EC1 VA: 0x1FA3DC0 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x1FA3DD0 Offset: 0x1FA3ED1 VA: 0x1FA3DD0 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x1FA3F80 Offset: 0x1FA4081 VA: 0x1FA3F80 Slot: 18
	public override BasicMenu.Result ACall() { }
}

