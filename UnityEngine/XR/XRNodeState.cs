// Namespace: UnityEngine.XR
[UsedByNativeCodeAttribute] // RVA: 0x588A0 Offset: 0x589A1 VA: 0x588A0
public struct XRNodeState // TypeDefIndex: 4862
{
	// Fields
	private XRNode m_Type; // 0x0
	private AvailableTrackingData m_AvailableFields; // 0x4
	private Vector3 m_Position; // 0x8
	private Quaternion m_Rotation; // 0x14
	private Vector3 m_Velocity; // 0x24
	private Vector3 m_AngularVelocity; // 0x30
	private Vector3 m_Acceleration; // 0x3C
	private Vector3 m_AngularAcceleration; // 0x48
	private int m_Tracked; // 0x54
	private ulong m_UniqueID; // 0x58

	// Properties
	public ulong uniqueID { set; }
	public XRNode nodeType { set; }
	public bool tracked { set; }

	// Methods

	// RVA: 0x1C4EF40 Offset: 0x1C4F041 VA: 0x1C4EF40
	public void set_uniqueID(ulong value) { }

	// RVA: 0x1C4EF50 Offset: 0x1C4F051 VA: 0x1C4EF50
	public void set_nodeType(XRNode value) { }

	// RVA: 0x1C4EF60 Offset: 0x1C4F061 VA: 0x1C4EF60
	public void set_tracked(bool value) { }
}

