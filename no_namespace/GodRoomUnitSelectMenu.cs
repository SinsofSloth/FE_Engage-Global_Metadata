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

