// Namespace: System.Runtime.InteropServices
[ComVisibleAttribute] // RVA: 0x476120 Offset: 0x476221 VA: 0x476120
public interface ICustomMarshaler // TypeDefIndex: 1310
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object MarshalNativeToManaged(IntPtr pNativeData);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IntPtr MarshalManagedToNative(object ManagedObj);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void CleanUpNativeData(IntPtr pNativeData);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void CleanUpManagedData(object ManagedObj);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int GetNativeDataSize();
}

