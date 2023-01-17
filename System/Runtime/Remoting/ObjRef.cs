// Namespace: System.Runtime.Remoting
[ComVisibleAttribute] // RVA: 0x474A10 Offset: 0x474B11 VA: 0x474A10
[Serializable]
public class ObjRef : IObjectReference, ISerializable // TypeDefIndex: 1098
{
	// Fields
	private IChannelInfo channel_info; // 0x10
	private string uri; // 0x18
	private IRemotingTypeInfo typeInfo; // 0x20
	private IEnvoyInfo envoyInfo; // 0x28
	private int flags; // 0x30
	private Type _serverType; // 0x38
	private static int MarshalledObjectRef; // 0x0
	private static int WellKnowObjectRef; // 0x4

	// Properties
	internal bool IsReferenceToWellKnow { get; }
	public virtual IChannelInfo ChannelInfo { get; }
	public virtual IEnvoyInfo EnvoyInfo { get; set; }
	public virtual IRemotingTypeInfo TypeInfo { get; set; }
	public virtual string URI { get; set; }
	internal Type ServerType { get; }

	// Methods

	// RVA: 0x3862190 Offset: 0x3862291 VA: 0x3862190
	public void .ctor() { }

	// RVA: 0x3862270 Offset: 0x3862371 VA: 0x3862270
	internal void .ctor(string uri, IChannelInfo cinfo) { }

	// RVA: 0x38622B0 Offset: 0x38623B1 VA: 0x38622B0
	internal ObjRef DeserializeInTheCurrentDomain(int domainId, byte[] tInfo) { }

	// RVA: 0x3862400 Offset: 0x3862501 VA: 0x3862400
	internal byte[] SerializeType() { }

	// RVA: 0x3862480 Offset: 0x3862581 VA: 0x3862480
	internal void .ctor(Type type, string url, object remoteChannelData) { }

	// RVA: 0x38625A0 Offset: 0x38626A1 VA: 0x38625A0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x3862A90 Offset: 0x3862B91 VA: 0x3862A90
	internal bool get_IsReferenceToWellKnow() { }

	[ReliabilityContractAttribute] // RVA: 0x47D1E0 Offset: 0x47D2E1 VA: 0x47D1E0
	// RVA: 0x3862B10 Offset: 0x3862C11 VA: 0x3862B10 Slot: 6
	public virtual IChannelInfo get_ChannelInfo() { }

	// RVA: 0x3862B20 Offset: 0x3862C21 VA: 0x3862B20 Slot: 7
	public virtual IEnvoyInfo get_EnvoyInfo() { }

	// RVA: 0x3862B30 Offset: 0x3862C31 VA: 0x3862B30 Slot: 8
	public virtual void set_EnvoyInfo(IEnvoyInfo value) { }

	// RVA: 0x3862B40 Offset: 0x3862C41 VA: 0x3862B40 Slot: 9
	public virtual IRemotingTypeInfo get_TypeInfo() { }

	// RVA: 0x3862B50 Offset: 0x3862C51 VA: 0x3862B50 Slot: 10
	public virtual void set_TypeInfo(IRemotingTypeInfo value) { }

	// RVA: 0x3862B60 Offset: 0x3862C61 VA: 0x3862B60 Slot: 11
	public virtual string get_URI() { }

	// RVA: 0x3862B70 Offset: 0x3862C71 VA: 0x3862B70 Slot: 12
	public virtual void set_URI(string value) { }

	// RVA: 0x3862B80 Offset: 0x3862C81 VA: 0x3862B80 Slot: 13
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x3862D70 Offset: 0x3862E71 VA: 0x3862D70 Slot: 14
	public virtual object GetRealObject(StreamingContext context) { }

	// RVA: 0x3862200 Offset: 0x3862301 VA: 0x3862200
	internal void UpdateChannelInfo() { }

	// RVA: 0x3862E40 Offset: 0x3862F41 VA: 0x3862E40
	internal Type get_ServerType() { }

	// RVA: 0x3862FA0 Offset: 0x38630A1 VA: 0x3862FA0
	private static void .cctor() { }
}

