// Namespace: System.Runtime.Remoting
internal abstract class Identity // TypeDefIndex: 1095
{
	// Fields
	protected string _objectUri; // 0x10
	protected IMessageSink _channelSink; // 0x18
	protected IMessageSink _envoySink; // 0x20
	private DynamicPropertyCollection _clientDynamicProperties; // 0x28
	private DynamicPropertyCollection _serverDynamicProperties; // 0x30
	protected ObjRef _objRef; // 0x38
	private bool _disposed; // 0x40

	// Properties
	public IMessageSink ChannelSink { get; set; }
	public IMessageSink EnvoySink { get; }
	public string ObjectUri { get; set; }
	public bool IsConnected { get; }
	public bool Disposed { get; set; }
	public DynamicPropertyCollection ClientDynamicProperties { get; }
	public bool HasServerDynamicSinks { get; }

	// Methods

	// RVA: 0x340D0D0 Offset: 0x340D1D1 VA: 0x340D0D0
	public void .ctor(string objectUri) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract ObjRef CreateObjRef(Type requestedType);

	// RVA: 0x340D110 Offset: 0x340D211 VA: 0x340D110
	public IMessageSink get_ChannelSink() { }

	// RVA: 0x340D120 Offset: 0x340D221 VA: 0x340D120
	public void set_ChannelSink(IMessageSink value) { }

	// RVA: 0x340D130 Offset: 0x340D231 VA: 0x340D130
	public IMessageSink get_EnvoySink() { }

	// RVA: 0x340D140 Offset: 0x340D241 VA: 0x340D140
	public string get_ObjectUri() { }

	// RVA: 0x340D150 Offset: 0x340D251 VA: 0x340D150
	public void set_ObjectUri(string value) { }

	// RVA: 0x340D160 Offset: 0x340D261 VA: 0x340D160
	public bool get_IsConnected() { }

	// RVA: 0x340D170 Offset: 0x340D271 VA: 0x340D170
	public bool get_Disposed() { }

	// RVA: 0x340D180 Offset: 0x340D281 VA: 0x340D180
	public void set_Disposed(bool value) { }

	// RVA: 0x340D190 Offset: 0x340D291 VA: 0x340D190
	public DynamicPropertyCollection get_ClientDynamicProperties() { }

	// RVA: 0x340D220 Offset: 0x340D321 VA: 0x340D220
	public bool get_HasServerDynamicSinks() { }

	// RVA: 0x340D240 Offset: 0x340D341 VA: 0x340D240
	public void NotifyClientDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	// RVA: 0x340D2C0 Offset: 0x340D3C1 VA: 0x340D2C0
	public void NotifyServerDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }
}

