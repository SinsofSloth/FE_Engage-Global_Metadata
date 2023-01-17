// Namespace: System.Runtime.Remoting.Messaging
[ComVisibleAttribute] // RVA: 0x475100 Offset: 0x475201 VA: 0x475100
[CLSCompliantAttribute] // RVA: 0x475100 Offset: 0x475201 VA: 0x475100
[Serializable]
public class ConstructionCall : MethodCall, IConstructionCallMessage, IMessage, IMethodCallMessage, IMethodMessage // TypeDefIndex: 1194
{
	// Fields
	private IActivator _activator; // 0x68
	private object[] _activationAttributes; // 0x70
	private IList _contextProperties; // 0x78
	private Type _activationType; // 0x80
	private string _activationTypeName; // 0x88
	private bool _isContextOk; // 0x90
	private RemotingProxy _sourceProxy; // 0x98

	// Properties
	internal bool IsContextOk { get; set; }
	public Type ActivationType { get; }
	public string ActivationTypeName { get; }
	public IActivator Activator { get; set; }
	public object[] CallSiteActivationAttributes { get; }
	public IList ContextProperties { get; }
	public override IDictionary Properties { get; }
	internal RemotingProxy SourceProxy { get; set; }

	// Methods

	// RVA: 0x33B0460 Offset: 0x33B0561 VA: 0x33B0460
	internal void .ctor(Type type) { }

	// RVA: 0x33B04D0 Offset: 0x33B05D1 VA: 0x33B04D0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x33B04E0 Offset: 0x33B05E1 VA: 0x33B04E0 Slot: 22
	internal override void InitDictionary() { }

	// RVA: 0x33B0650 Offset: 0x33B0751 VA: 0x33B0650
	internal bool get_IsContextOk() { }

	// RVA: 0x33B0660 Offset: 0x33B0761 VA: 0x33B0660
	internal void set_IsContextOk(bool value) { }

	// RVA: 0x33B0670 Offset: 0x33B0771 VA: 0x33B0670 Slot: 24
	public Type get_ActivationType() { }

	// RVA: 0x33B0760 Offset: 0x33B0861 VA: 0x33B0760 Slot: 25
	public string get_ActivationTypeName() { }

	// RVA: 0x33B0770 Offset: 0x33B0871 VA: 0x33B0770 Slot: 26
	public IActivator get_Activator() { }

	// RVA: 0x33B0780 Offset: 0x33B0881 VA: 0x33B0780 Slot: 27
	public void set_Activator(IActivator value) { }

	// RVA: 0x33B0790 Offset: 0x33B0891 VA: 0x33B0790 Slot: 28
	public object[] get_CallSiteActivationAttributes() { }

	// RVA: 0x33B07A0 Offset: 0x33B08A1 VA: 0x33B07A0
	internal void SetActivationAttributes(object[] attributes) { }

	// RVA: 0x33B07B0 Offset: 0x33B08B1 VA: 0x33B07B0 Slot: 29
	public IList get_ContextProperties() { }

	// RVA: 0x33B0840 Offset: 0x33B0941 VA: 0x33B0840 Slot: 19
	internal override void InitMethodProperty(string key, object value) { }

	// RVA: 0x33B0AE0 Offset: 0x33B0BE1 VA: 0x33B0AE0 Slot: 20
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x33B0CA0 Offset: 0x33B0DA1 VA: 0x33B0CA0 Slot: 21
	public override IDictionary get_Properties() { }

	// RVA: 0x33B0CB0 Offset: 0x33B0DB1 VA: 0x33B0CB0
	internal RemotingProxy get_SourceProxy() { }

	// RVA: 0x33B0CC0 Offset: 0x33B0DC1 VA: 0x33B0CC0
	internal void set_SourceProxy(RemotingProxy value) { }
}

