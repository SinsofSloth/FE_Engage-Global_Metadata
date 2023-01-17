// Namespace: UnityEngine
public class AndroidJavaProxy // TypeDefIndex: 7512
{
	// Fields
	public readonly AndroidJavaClass javaInterface; // 0x10
	internal IntPtr proxyObject; // 0x18
	private static readonly GlobalJavaObjectRef s_JavaLangSystemClass; // 0x0
	private static readonly IntPtr s_HashCodeMethodID; // 0x8

	// Methods

	// RVA: 0x3EFEF40 Offset: 0x3EFF041 VA: 0x3EFEF40
	public void .ctor(string javaInterface) { }

	// RVA: 0x3EFF040 Offset: 0x3EFF141 VA: 0x3EFF040
	public void .ctor(AndroidJavaClass javaInterface) { }

	// RVA: 0x3EFF0B0 Offset: 0x3EFF1B1 VA: 0x3EFF0B0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x3EFF180 Offset: 0x3EFF281 VA: 0x3EFF180 Slot: 4
	public virtual AndroidJavaObject Invoke(string methodName, object[] args) { }

	// RVA: 0x3F005F0 Offset: 0x3F006F1 VA: 0x3F005F0 Slot: 5
	public virtual AndroidJavaObject Invoke(string methodName, AndroidJavaObject[] javaArgs) { }

	// RVA: 0x3F01040 Offset: 0x3F01141 VA: 0x3F01040
	internal AndroidJavaObject GetProxyObject() { }

	// RVA: 0x3F003B0 Offset: 0x3F004B1 VA: 0x3F003B0
	internal IntPtr GetRawProxy() { }

	// RVA: 0x3F010C0 Offset: 0x3F011C1 VA: 0x3F010C0
	private static void .cctor() { }
}

