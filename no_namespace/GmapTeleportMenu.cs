// Namespace: 
public class GmapTeleportMenu.GmapTeleportMenuItem : BasicMenuItem // TypeDefIndex: 10363
{
	// Fields
	private GmapSpot m_GmapSpot; // 0x68
	private Vector3 m_SpotPosition; // 0x70
	private Action m_CloseMapAndBarFunc; // 0x80
	private bool m_IsCameraFocus; // 0x88

	// Properties
	public GmapSpot Spot { get; }

	// Methods

	// RVA: 0x1F9F020 Offset: 0x1F9F121 VA: 0x1F9F020
	public void .ctor(GmapSpot gmapSpot, Action closeMapAndBarFunc) { }

	// RVA: 0x1F9F500 Offset: 0x1F9F601 VA: 0x1F9F500 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x1F9F660 Offset: 0x1F9F761 VA: 0x1F9F660 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x1F9F7A0 Offset: 0x1F9F8A1 VA: 0x1F9F7A0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x1F9F910 Offset: 0x1F9FA11 VA: 0x1F9F910 Slot: 4
	public override string GetName() { }

	// RVA: 0x1F9F9A0 Offset: 0x1F9FAA1 VA: 0x1F9F9A0
	public GmapSpot get_Spot() { }
}

