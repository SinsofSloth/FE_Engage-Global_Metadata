// Namespace: System
[ComVisibleAttribute] // RVA: 0x471090 Offset: 0x471191 VA: 0x471090
[Serializable]
public abstract class MulticastDelegate : Delegate // TypeDefIndex: 379
{
	// Fields
	private Delegate[] delegates; // 0x68

	// Methods

	// RVA: 0x34FCC90 Offset: 0x34FCD91 VA: 0x34FCC90 Slot: 9
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x34FCCA0 Offset: 0x34FCDA1 VA: 0x34FCCA0 Slot: 6
	protected sealed override object DynamicInvokeImpl(object[] args) { }

	// RVA: 0x34FCD40 Offset: 0x34FCE41 VA: 0x34FCD40 Slot: 0
	public sealed override bool Equals(object obj) { }

	// RVA: 0x34FCEC0 Offset: 0x34FCFC1 VA: 0x34FCEC0 Slot: 2
	public sealed override int GetHashCode() { }

	// RVA: 0x34FCED0 Offset: 0x34FCFD1 VA: 0x34FCED0 Slot: 8
	protected override MethodInfo GetMethodImpl() { }

	// RVA: 0x34FCF20 Offset: 0x34FD021 VA: 0x34FCF20 Slot: 10
	public sealed override Delegate[] GetInvocationList() { }

	// RVA: 0x34FD010 Offset: 0x34FD111 VA: 0x34FD010 Slot: 11
	protected sealed override Delegate CombineImpl(Delegate follow) { }

	// RVA: 0x34FD2B0 Offset: 0x34FD3B1 VA: 0x34FD2B0
	private int LastIndexOf(Delegate[] haystack, Delegate[] needle) { }

	// RVA: 0x34FD3F0 Offset: 0x34FD4F1 VA: 0x34FD3F0 Slot: 12
	protected sealed override Delegate RemoveImpl(Delegate value) { }
}

