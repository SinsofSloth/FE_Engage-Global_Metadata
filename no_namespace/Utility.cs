// Namespace: 
public class Utility.GPUBuffer<T> // TypeDefIndex: 7570
{
	// Fields
	private IntPtr buffer; // 0x0
}

// Namespace: 
public sealed class Utility.AcquireNexUniqueIdCB : MulticastDelegate // TypeDefIndex: 15018
{
	// Methods

	// RVA: 0x1EDDC40 Offset: 0x1EDDD41 VA: 0x1EDDC40
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1EDDC60 Offset: 0x1EDDD61 VA: 0x1EDDC60 Slot: 13
	public virtual void Invoke(AsyncResult asyncResult, ulong nexUniqueId) { }

	// RVA: 0x1EDDFD0 Offset: 0x1EDE0D1 VA: 0x1EDDFD0 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncResult asyncResult, ulong nexUniqueId, AsyncCallback callback, object object) { }

	// RVA: 0x1EDE070 Offset: 0x1EDE171 VA: 0x1EDE070 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class Utility.AcquireNexUniqueIdWithPasswordCB : MulticastDelegate // TypeDefIndex: 15019
{
	// Methods

	// RVA: 0x1EDE080 Offset: 0x1EDE181 VA: 0x1EDE080
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1EDE0A0 Offset: 0x1EDE1A1 VA: 0x1EDE0A0 Slot: 13
	public virtual void Invoke(AsyncResult asyncResult, UniqueIdInfo uniqueIdInfo) { }

	// RVA: 0x1EDE410 Offset: 0x1EDE511 VA: 0x1EDE410 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncResult asyncResult, UniqueIdInfo uniqueIdInfo, AsyncCallback callback, object object) { }

	// RVA: 0x1EDE440 Offset: 0x1EDE541 VA: 0x1EDE440 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class Utility.GetAssociatedNexUniqueIdWithMyPrincipalIdCB : MulticastDelegate // TypeDefIndex: 15020
{
	// Methods

	// RVA: 0x1EDE450 Offset: 0x1EDE551 VA: 0x1EDE450
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1EDE470 Offset: 0x1EDE571 VA: 0x1EDE470 Slot: 13
	public virtual void Invoke(AsyncResult asyncResult, UniqueIdInfo uniqueIdInfo) { }

	// RVA: 0x1EDE7E0 Offset: 0x1EDE8E1 VA: 0x1EDE7E0 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncResult asyncResult, UniqueIdInfo uniqueIdInfo, AsyncCallback callback, object object) { }

	// RVA: 0x1EDE810 Offset: 0x1EDE911 VA: 0x1EDE810 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class Utility.GetAssociatedNexUniqueIdWithMyPrincipalIdListCB : MulticastDelegate // TypeDefIndex: 15021
{
	// Methods

	// RVA: 0x1EDE820 Offset: 0x1EDE921 VA: 0x1EDE820
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1EDE840 Offset: 0x1EDE941 VA: 0x1EDE840 Slot: 13
	public virtual void Invoke(AsyncResult asyncResult, List<UniqueIdInfo> uniqueIdInfo) { }

	// RVA: 0x1EDEBB0 Offset: 0x1EDECB1 VA: 0x1EDEBB0 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncResult asyncResult, List<UniqueIdInfo> uniqueIdInfo, AsyncCallback callback, object object) { }

	// RVA: 0x1EDEBE0 Offset: 0x1EDECE1 VA: 0x1EDEBE0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class Utility.GetIntegerSettingsCB : MulticastDelegate // TypeDefIndex: 15022
{
	// Methods

	// RVA: 0x1EDEBF0 Offset: 0x1EDECF1 VA: 0x1EDEBF0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1EDEC10 Offset: 0x1EDED11 VA: 0x1EDEC10 Slot: 13
	public virtual void Invoke(AsyncResult asyncResult, Dictionary<ushort, int> integerSettings) { }

	// RVA: 0x1EDEF80 Offset: 0x1EDF081 VA: 0x1EDEF80 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncResult asyncResult, Dictionary<ushort, int> integerSettings, AsyncCallback callback, object object) { }

	// RVA: 0x1EDEFB0 Offset: 0x1EDF0B1 VA: 0x1EDEFB0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

