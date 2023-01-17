// Namespace: 
internal sealed class DateTimeParse.MatchNumberDelegate : MulticastDelegate // TypeDefIndex: 226
{
	// Methods

	// RVA: 0x35E88B0 Offset: 0x35E89B1 VA: 0x35E88B0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x35E88D0 Offset: 0x35E89D1 VA: 0x35E88D0 Slot: 13
	public virtual bool Invoke(ref __DTString str, int digitLen, out int result) { }

	// RVA: 0x35E8B40 Offset: 0x35E8C41 VA: 0x35E8B40 Slot: 14
	public virtual IAsyncResult BeginInvoke(ref __DTString str, int digitLen, out int result, AsyncCallback callback, object object) { }

	// RVA: 0x35E8C20 Offset: 0x35E8D21 VA: 0x35E8C20 Slot: 15
	public virtual bool EndInvoke(ref __DTString str, out int result, IAsyncResult __result) { }
}

// Namespace: 
internal enum DateTimeParse.TM // TypeDefIndex: 228
{
	// Fields
	public int value__; // 0x0
	public const DateTimeParse.TM NotSet = -1;
	public const DateTimeParse.TM AM = 0;
	public const DateTimeParse.TM PM = 1;
}

