// Namespace: nn.friends
public sealed class NotificationQueue : IDisposable // TypeDefIndex: 14751
{
	// Fields
	private IntPtr queue; // 0x10

	// Methods

	// RVA: 0x235E6B0 Offset: 0x235E7B1 VA: 0x235E6B0
	public void .ctor() { }

	// RVA: 0x235E720 Offset: 0x235E821 VA: 0x235E720 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x235E830 Offset: 0x235E931 VA: 0x235E830 Slot: 4
	public void Dispose() { }

	// RVA: 0x235E7D0 Offset: 0x235E8D1 VA: 0x235E7D0
	private void Dispose(bool disposing) { }

	// RVA: 0x235E8F0 Offset: 0x235E9F1 VA: 0x235E8F0
	public Result Initialize(Uid uid) { }

	// RVA: 0x235E930 Offset: 0x235EA31 VA: 0x235E930
	public Result Initialize() { }

	// RVA: 0x235E970 Offset: 0x235EA71 VA: 0x235E970
	public void Terminate() { }

	// RVA: 0x235E990 Offset: 0x235EA91 VA: 0x235E990
	public Uid GetUid() { }

	// RVA: 0x235E9B0 Offset: 0x235EAB1 VA: 0x235E9B0
	public Result Clear() { }

	// RVA: 0x235E9F0 Offset: 0x235EAF1 VA: 0x235E9F0
	public Result Pop(ref NotificationInfo outInfo) { }

	// RVA: 0x235EA30 Offset: 0x235EB31 VA: 0x235EA30
	public bool Exists() { }

	// RVA: 0x235E710 Offset: 0x235E811 VA: 0x235E710
	private static extern IntPtr Create() { }

	// RVA: 0x235E8E0 Offset: 0x235E9E1 VA: 0x235E8E0
	private static extern void Destroy(IntPtr pQueue) { }

	// RVA: 0x235E910 Offset: 0x235EA11 VA: 0x235E910
	private static extern Result Initialize(IntPtr pQueue, Uid uid) { }

	// RVA: 0x235E950 Offset: 0x235EA51 VA: 0x235E950
	private static extern Result Initialize(IntPtr pQueue) { }

	// RVA: 0x235E980 Offset: 0x235EA81 VA: 0x235E980
	private static extern void Terminate(IntPtr pQueue) { }

	// RVA: 0x235E9A0 Offset: 0x235EAA1 VA: 0x235E9A0
	private static extern Uid GetUid(IntPtr pQueue) { }

	// RVA: 0x235E9D0 Offset: 0x235EAD1 VA: 0x235E9D0
	private static extern Result Clear(IntPtr pQueue) { }

	// RVA: 0x235EA10 Offset: 0x235EB11 VA: 0x235EA10
	private static extern Result Pop(IntPtr pQueue, ref NotificationInfo outInfo) { }

	// RVA: 0x235EA50 Offset: 0x235EB51 VA: 0x235EA50
	private static extern bool Exists(IntPtr pQueue) { }
}

