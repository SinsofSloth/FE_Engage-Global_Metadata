// Namespace: 
private sealed class OSSpecificSynchronizationContext.InvocationEntryDelegate : MulticastDelegate // TypeDefIndex: 772
{
	// Methods

	// RVA: 0x35EFFB0 Offset: 0x35F00B1 VA: 0x35EFFB0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x35EFFD0 Offset: 0x35F00D1 VA: 0x35EFFD0 Slot: 13
	public virtual void Invoke(IntPtr arg) { }

	// RVA: 0x35F0200 Offset: 0x35F0301 VA: 0x35F0200 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr arg, AsyncCallback callback, object object) { }

	// RVA: 0x35F0290 Offset: 0x35F0391 VA: 0x35F0290 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[AttributeUsageAttribute] // RVA: 0x473410 Offset: 0x473511 VA: 0x473410
private sealed class OSSpecificSynchronizationContext.MonoPInvokeCallbackAttribute : Attribute // TypeDefIndex: 773
{
	// Methods

	// RVA: 0x35F02A0 Offset: 0x35F03A1 VA: 0x35F02A0
	public void .ctor(Type t) { }
}

// Namespace: 
private class OSSpecificSynchronizationContext.InvocationContext // TypeDefIndex: 774
{
	// Fields
	private SendOrPostCallback m_Delegate; // 0x10
	private object m_State; // 0x18

	// Methods

	// RVA: 0x35EFF50 Offset: 0x35F0051 VA: 0x35EFF50
	public void .ctor(SendOrPostCallback d, object state) { }

	// RVA: 0x35EFFA0 Offset: 0x35F00A1 VA: 0x35EFFA0
	public void Invoke() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x473430 Offset: 0x473531 VA: 0x473430
[Serializable]
private sealed class OSSpecificSynchronizationContext.<>c // TypeDefIndex: 775
{
	// Fields
	public static readonly OSSpecificSynchronizationContext.<>c <>9; // 0x0
	public static ConditionalWeakTable.CreateValueCallback<object, OSSpecificSynchronizationContext> <>9__3_0; // 0x8

	// Methods

	// RVA: 0x35EFE60 Offset: 0x35EFF61 VA: 0x35EFE60
	private static void .cctor() { }

	// RVA: 0x35EFED0 Offset: 0x35EFFD1 VA: 0x35EFED0
	public void .ctor() { }

	// RVA: 0x35EFEE0 Offset: 0x35EFFE1 VA: 0x35EFEE0
	internal OSSpecificSynchronizationContext <Get>b__3_0(object _osContext) { }
}

