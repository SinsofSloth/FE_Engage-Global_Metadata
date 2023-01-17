// Namespace: System.Security.Principal
[ComVisibleAttribute] // RVA: 0x473B90 Offset: 0x473C91 VA: 0x473B90
[Serializable]
public class WindowsIdentity : ClaimsIdentity, IIdentity, IDeserializationCallback, ISerializable, IDisposable // TypeDefIndex: 895
{
	// Fields
	private IntPtr _token; // 0x78
	private string _type; // 0x80
	private WindowsAccountType _account; // 0x88
	private bool _authenticated; // 0x8C
	private string _name; // 0x90
	private SerializationInfo _info; // 0x98
	private static IntPtr invalidWindows; // 0x0

	// Properties
	public sealed override string AuthenticationType { get; }
	public override string Name { get; }

	// Methods

	// RVA: 0x34D3540 Offset: 0x34D3641 VA: 0x34D3540
	public void .ctor(IntPtr userToken, string type, WindowsAccountType acctType, bool isAuthenticated) { }

	// RVA: 0x34D3740 Offset: 0x34D3841 VA: 0x34D3740
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	[ComVisibleAttribute] // RVA: 0x47CE20 Offset: 0x47CF21 VA: 0x47CE20
	// RVA: 0x34D3780 Offset: 0x34D3881 VA: 0x34D3780 Slot: 14
	public void Dispose() { }

	// RVA: 0x34D37C0 Offset: 0x34D38C1 VA: 0x34D37C0
	public static WindowsIdentity GetCurrent() { }

	// RVA: 0x34D3880 Offset: 0x34D3981 VA: 0x34D3880 Slot: 15
	public virtual WindowsImpersonationContext Impersonate() { }

	// RVA: 0x34D3980 Offset: 0x34D3A81 VA: 0x34D3980 Slot: 6
	public sealed override string get_AuthenticationType() { }

	// RVA: 0x34D3990 Offset: 0x34D3A91 VA: 0x34D3990 Slot: 8
	public override string get_Name() { }

	// RVA: 0x34D3A40 Offset: 0x34D3B41 VA: 0x34D3A40 Slot: 12
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x34D3D70 Offset: 0x34D3E71 VA: 0x34D3D70 Slot: 13
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x34D35C0 Offset: 0x34D36C1 VA: 0x34D35C0
	private void SetToken(IntPtr token) { }

	// RVA: 0x34D3870 Offset: 0x34D3971 VA: 0x34D3870
	internal static IntPtr GetCurrentToken() { }

	// RVA: 0x34D3A30 Offset: 0x34D3B31 VA: 0x34D3A30
	private static string GetTokenName(IntPtr token) { }

	// RVA: 0x34D3EF0 Offset: 0x34D3FF1 VA: 0x34D3EF0
	private static void .cctor() { }
}

