// Namespace: System.Runtime.Remoting.Proxies
internal class TransparentProxy // TypeDefIndex: 1122
{
	// Fields
	public RealProxy _rp; // 0x10
	private RuntimeRemoteClassHandle _class; // 0x18
	private bool _custom_type_info; // 0x20

	// Properties
	private bool IsContextBoundObject { get; }
	private Context TargetContext { get; }

	// Methods

	// RVA: 0x1B26890 Offset: 0x1B26991 VA: 0x1B26890
	internal RuntimeType GetProxyType() { }

	// RVA: 0x1B26980 Offset: 0x1B26A81 VA: 0x1B26980
	private bool get_IsContextBoundObject() { }

	// RVA: 0x1B269A0 Offset: 0x1B26AA1 VA: 0x1B269A0
	private Context get_TargetContext() { }

	// RVA: 0x1B269B0 Offset: 0x1B26AB1 VA: 0x1B269B0
	private bool InCurrentContext() { }

	// RVA: 0x1B26A10 Offset: 0x1B26B11 VA: 0x1B26A10
	internal object LoadRemoteFieldNew(IntPtr classPtr, IntPtr fieldPtr) { }

	// RVA: 0x1B26D10 Offset: 0x1B26E11 VA: 0x1B26D10
	internal void StoreRemoteField(IntPtr classPtr, IntPtr fieldPtr, object arg) { }

	// RVA: 0x1B27020 Offset: 0x1B27121 VA: 0x1B27020
	public void .ctor() { }
}

