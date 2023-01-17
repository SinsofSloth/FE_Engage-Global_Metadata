// Namespace: 
private sealed class CFNetwork.CFProxyAutoConfigurationResultCallback : MulticastDelegate // TypeDefIndex: 2174
{
	// Methods

	// RVA: 0x1916280 Offset: 0x1916381 VA: 0x1916280
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x19162A0 Offset: 0x19163A1 VA: 0x19162A0 Slot: 13
	public virtual void Invoke(IntPtr client, IntPtr proxyList, IntPtr error) { }

	// RVA: 0x1916500 Offset: 0x1916601 VA: 0x1916500 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr client, IntPtr proxyList, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0x19165C0 Offset: 0x19166C1 VA: 0x19165C0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2FAF0 Offset: 0x2FBF1 VA: 0x2FAF0
private sealed class CFNetwork.<>c__DisplayClass13_0 // TypeDefIndex: 2176
{
	// Fields
	public CFProxy[] proxies; // 0x10
	public CFRunLoop runLoop; // 0x18

	// Methods

	// RVA: 0x1916080 Offset: 0x1916181 VA: 0x1916080
	public void .ctor() { }

	// RVA: 0x1916090 Offset: 0x1916191 VA: 0x1916090
	internal void <ExecuteProxyAutoConfigurationURL>b__0(IntPtr client, IntPtr proxyList, IntPtr error) { }
}

