// Namespace: 
[Serializable]
public class AkCommonCommSettings // TypeDefIndex: 7945
{
	// Fields
	[TooltipAttribute] // RVA: 0x27E240 Offset: 0x27E341 VA: 0x27E240
	public uint m_PoolSize; // 0x10
	public static ushort DefaultDiscoveryBroadcastPort; // 0x0
	[TooltipAttribute] // RVA: 0x27E280 Offset: 0x27E381 VA: 0x27E280
	public ushort m_DiscoveryBroadcastPort; // 0x14
	[TooltipAttribute] // RVA: 0x27E2C0 Offset: 0x27E3C1 VA: 0x27E2C0
	public ushort m_CommandPort; // 0x16
	[TooltipAttribute] // RVA: 0x27E300 Offset: 0x27E401 VA: 0x27E300
	public ushort m_NotificationPort; // 0x18
	[TooltipAttribute] // RVA: 0x27E340 Offset: 0x27E441 VA: 0x27E340
	public bool m_InitializeSystemComms; // 0x1A
	[TooltipAttribute] // RVA: 0x27E380 Offset: 0x27E481 VA: 0x27E380
	public string m_NetworkName; // 0x20
	[TooltipAttribute] // RVA: 0x27E3C0 Offset: 0x27E4C1 VA: 0x27E3C0
	public AkCommunicationSettings.AkCommSystem m_commSystem; // 0x28

	// Methods

	// RVA: 0x316A080 Offset: 0x316A181 VA: 0x316A080 Slot: 4
	public virtual void CopyTo(AkCommunicationSettings settings) { }

	// RVA: 0x316A6B0 Offset: 0x316A7B1 VA: 0x316A6B0 Slot: 5
	public virtual void Validate() { }

	// RVA: 0x316A6C0 Offset: 0x316A7C1 VA: 0x316A6C0
	public void .ctor() { }

	// RVA: 0x316A750 Offset: 0x316A851 VA: 0x316A750
	private static void .cctor() { }
}

