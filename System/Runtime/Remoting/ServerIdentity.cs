// Namespace: System.Runtime.Remoting
internal abstract class ServerIdentity : Identity // TypeDefIndex: 1107
{
	// Fields
	protected Type _objectType; // 0x48
	protected MarshalByRefObject _serverObject; // 0x50
	protected IMessageSink _serverSink; // 0x58
	protected Context _context; // 0x60
	protected Lease _lease; // 0x68

	// Properties
	public Type ObjectType { get; }
	public Lease Lease { get; }
	public Context Context { get; set; }

	// Methods

	// RVA: 0x361BEC0 Offset: 0x361BFC1 VA: 0x361BEC0
	public void .ctor(string objectUri, Context context, Type objectType) { }

	// RVA: 0x361BF10 Offset: 0x361C011 VA: 0x361BF10
	public Type get_ObjectType() { }

	// RVA: 0x361BF20 Offset: 0x361C021 VA: 0x361BF20
	public void StartTrackingLifetime(ILease lease) { }

	// RVA: 0x361C0C0 Offset: 0x361C1C1 VA: 0x361C0C0 Slot: 5
	public virtual void OnLifetimeExpired() { }

	// RVA: 0x361C190 Offset: 0x361C291 VA: 0x361C190 Slot: 4
	public override ObjRef CreateObjRef(Type requestedType) { }

	// RVA: 0x361C350 Offset: 0x361C451 VA: 0x361C350
	public void AttachServerObject(MarshalByRefObject serverObject, Context context) { }

	// RVA: 0x361C4B0 Offset: 0x361C5B1 VA: 0x361C4B0
	public Lease get_Lease() { }

	// RVA: 0x361C4C0 Offset: 0x361C5C1 VA: 0x361C4C0
	public Context get_Context() { }

	// RVA: 0x361C4D0 Offset: 0x361C5D1 VA: 0x361C4D0
	public void set_Context(Context value) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract IMessage SyncObjectProcessMessage(IMessage msg);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink);

	// RVA: 0x361C0D0 Offset: 0x361C1D1 VA: 0x361C0D0
	protected void DisposeServerObject() { }
}

