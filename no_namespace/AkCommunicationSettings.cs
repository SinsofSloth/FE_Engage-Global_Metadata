// Namespace: 
public class AkCommunicationSettings : IDisposable // TypeDefIndex: 7907
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public AkThreadProperties commsThreadProperties { get; set; }
	public uint uPoolSize { get; set; }
	public ushort uDiscoveryBroadcastPort { get; set; }
	public ushort uCommandPort { get; set; }
	public ushort uNotificationPort { get; set; }
	public AkCommunicationSettings.AkCommSystem commSystem { get; set; }
	public bool bInitSystemLib { get; set; }
	public string szAppNetworkName { get; set; }

	// Methods

	// RVA: 0x316D840 Offset: 0x316D941 VA: 0x316D840
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x316D880 Offset: 0x316D981 VA: 0x316D880
	internal static IntPtr getCPtr(AkCommunicationSettings obj) { }

	// RVA: 0x316D8E0 Offset: 0x316D9E1 VA: 0x316D8E0 Slot: 5
	internal virtual void setCPtr(IntPtr cPtr) { }

	// RVA: 0x316D910 Offset: 0x316DA11 VA: 0x316D910 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x316D980 Offset: 0x316DA81 VA: 0x316D980 Slot: 6
	public virtual void Dispose() { }

	// RVA: 0x316DB10 Offset: 0x316DC11 VA: 0x316DB10
	public void .ctor() { }

	// RVA: 0x316DBA0 Offset: 0x316DCA1 VA: 0x316DBA0
	public void set_commsThreadProperties(AkThreadProperties value) { }

	// RVA: 0x316DC30 Offset: 0x316DD31 VA: 0x316DC30
	public AkThreadProperties get_commsThreadProperties() { }

	// RVA: 0x316A330 Offset: 0x316A431 VA: 0x316A330
	public void set_uPoolSize(uint value) { }

	// RVA: 0x316DD10 Offset: 0x316DE11 VA: 0x316DD10
	public uint get_uPoolSize() { }

	// RVA: 0x316A3B0 Offset: 0x316A4B1 VA: 0x316A3B0
	public void set_uDiscoveryBroadcastPort(ushort value) { }

	// RVA: 0x316DD80 Offset: 0x316DE81 VA: 0x316DD80
	public ushort get_uDiscoveryBroadcastPort() { }

	// RVA: 0x316A430 Offset: 0x316A531 VA: 0x316A430
	public void set_uCommandPort(ushort value) { }

	// RVA: 0x316DDF0 Offset: 0x316DEF1 VA: 0x316DDF0
	public ushort get_uCommandPort() { }

	// RVA: 0x316A4B0 Offset: 0x316A5B1 VA: 0x316A4B0
	public void set_uNotificationPort(ushort value) { }

	// RVA: 0x316DE60 Offset: 0x316DF61 VA: 0x316DE60
	public ushort get_uNotificationPort() { }

	// RVA: 0x316A5B0 Offset: 0x316A6B1 VA: 0x316A5B0
	public void set_commSystem(AkCommunicationSettings.AkCommSystem value) { }

	// RVA: 0x316DED0 Offset: 0x316DFD1 VA: 0x316DED0
	public AkCommunicationSettings.AkCommSystem get_commSystem() { }

	// RVA: 0x316A530 Offset: 0x316A631 VA: 0x316A530
	public void set_bInitSystemLib(bool value) { }

	// RVA: 0x316DF40 Offset: 0x316E041 VA: 0x316DF40
	public bool get_bInitSystemLib() { }

	// RVA: 0x316A630 Offset: 0x316A731 VA: 0x316A630
	public void set_szAppNetworkName(string value) { }

	// RVA: 0x316DFB0 Offset: 0x316E0B1 VA: 0x316DFB0
	public string get_szAppNetworkName() { }
}

