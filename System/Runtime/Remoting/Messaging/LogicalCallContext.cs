// Namespace: System.Runtime.Remoting.Messaging
[ComVisibleAttribute] // RVA: 0x4750C0 Offset: 0x4751C1 VA: 0x4750C0
[Serializable]
public sealed class LogicalCallContext : ISerializable, ICloneable // TypeDefIndex: 1180
{
	// Fields
	private static Type s_callContextType; // 0x0
	private const string s_CorrelationMgrSlotName = "System.Diagnostics.Trace.CorrelationManagerSlot";
	private Hashtable m_Datastore; // 0x10
	private CallContextRemotingData m_RemotingData; // 0x18
	private CallContextSecurityData m_SecurityData; // 0x20
	private object m_HostContext; // 0x28
	private bool m_IsCorrelationMgr; // 0x30
	private Header[] _sendHeaders; // 0x38
	private Header[] _recvHeaders; // 0x40

	// Properties
	public bool HasInfo { get; }
	private bool HasUserData { get; }
	private Hashtable Datastore { get; }

	// Methods

	// RVA: 0x34209F0 Offset: 0x3420AF1 VA: 0x34209F0
	internal void .ctor() { }

	// RVA: 0x3420A00 Offset: 0x3420B01 VA: 0x3420A00
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x3420E20 Offset: 0x3420F21 VA: 0x3420E20 Slot: 4
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x34211B0 Offset: 0x34212B1 VA: 0x34211B0 Slot: 5
	public object Clone() { }

	// RVA: 0x3421890 Offset: 0x3421991 VA: 0x3421890
	internal void Merge(LogicalCallContext lc) { }

	// RVA: 0x3421B80 Offset: 0x3421C81 VA: 0x3421B80
	public bool get_HasInfo() { }

	// RVA: 0x3421180 Offset: 0x3421281 VA: 0x3421180
	private bool get_HasUserData() { }

	// RVA: 0x3420D90 Offset: 0x3420E91 VA: 0x3420D90
	private Hashtable get_Datastore() { }

	// RVA: 0x3421C30 Offset: 0x3421D31 VA: 0x3421C30
	private static void .cctor() { }
}

