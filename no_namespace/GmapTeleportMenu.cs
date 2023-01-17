// Namespace: 
public sealed class GmapTeleportMenu.DecideEventHandler : MulticastDelegate // TypeDefIndex: 10361
{
	// Methods

	// RVA: 0x1F9F140 Offset: 0x1F9F241 VA: 0x1F9F140
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F9F160 Offset: 0x1F9F261 VA: 0x1F9F160 Slot: 13
	public virtual void Invoke(GmapSpot gmapSpot) { }

	// RVA: 0x1F9F4C0 Offset: 0x1F9F5C1 VA: 0x1F9F4C0 Slot: 14
	public virtual IAsyncResult BeginInvoke(GmapSpot gmapSpot, AsyncCallback callback, object object) { }

	// RVA: 0x1F9F4F0 Offset: 0x1F9F5F1 VA: 0x1F9F4F0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x276AF0 Offset: 0x276BF1 VA: 0x276AF0
private sealed class GmapTeleportMenu.GmapTeleportMenuItem.<>c__DisplayClass7_0 // TypeDefIndex: 10362
{
	// Fields
	public GmapTeleportMenu menu; // 0x10
	public GmapTeleportMenu.GmapTeleportMenuItem <>4__this; // 0x18

	// Methods

	// RVA: 0x1DCD970 Offset: 0x1DCDA71 VA: 0x1DCD970
	public void .ctor() { }

	// RVA: 0x1DCD980 Offset: 0x1DCDA81 VA: 0x1DCD980
	internal void <ACall>b__0() { }
}

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

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x276B00 Offset: 0x276C01 VA: 0x276B00
private sealed class GmapTeleportMenu.<>c__DisplayClass3_0 // TypeDefIndex: 10364
{
	// Fields
	public List<BasicMenuItem> list; // 0x10
	public Action closeMapAndBarFunc; // 0x18

	// Methods

	// RVA: 0x1F9EF50 Offset: 0x1F9F051 VA: 0x1F9EF50
	public void .ctor() { }

	// RVA: 0x1F9EF60 Offset: 0x1F9F061 VA: 0x1F9EF60
	internal void <AddMenuItems>b__0(GmapSpot spot) { }
}

