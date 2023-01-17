// Namespace: 
public sealed class Ngc.MaskTextResultFunction : MulticastDelegate // TypeDefIndex: 9142
{
	// Methods

	// RVA: 0x1F1A000 Offset: 0x1F1A101 VA: 0x1F1A000
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F1A020 Offset: 0x1F1A121 VA: 0x1F1A020 Slot: 13
	public virtual void Invoke(bool isSuccess, string resultText, int ngWordCount) { }

	// RVA: 0x1F1A280 Offset: 0x1F1A381 VA: 0x1F1A280 Slot: 14
	public virtual IAsyncResult BeginInvoke(bool isSuccess, string resultText, int ngWordCount, AsyncCallback callback, object object) { }

	// RVA: 0x1F1A350 Offset: 0x1F1A451 VA: 0x1F1A350 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class Ngc.CheckMultiTextResultFunction : MulticastDelegate // TypeDefIndex: 9144
{
	// Methods

	// RVA: 0x1F19230 Offset: 0x1F19331 VA: 0x1F19230
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F19250 Offset: 0x1F19351 VA: 0x1F19250 Slot: 13
	public virtual void Invoke(bool[] isOk) { }

	// RVA: 0x1F195B0 Offset: 0x1F196B1 VA: 0x1F195B0 Slot: 14
	public virtual IAsyncResult BeginInvoke(bool[] isOk, AsyncCallback callback, object object) { }

	// RVA: 0x1F195E0 Offset: 0x1F196E1 VA: 0x1F195E0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private abstract class Ngc.MaskTextSequenceBase : ProcInst // TypeDefIndex: 9146
{
	// Fields
	protected Ngc.MaskTextSequenceBase.Data[] m_Data; // 0x70
	private Thread m_Thread; // 0x78

	// Methods

	// RVA: 0x1F19E70 Offset: 0x1F19F71 VA: 0x1F19E70
	protected void .ctor(string text) { }

	// RVA: 0x1F19620 Offset: 0x1F19721 VA: 0x1F19620
	protected void .ctor(List<string> texts) { }

	// RVA: 0x1F1A470 Offset: 0x1F1A571 VA: 0x1F1A470
	private void StartThread() { }

	// RVA: 0x1F1A550 Offset: 0x1F1A651 VA: 0x1F1A550
	private void WaitThread() { }

	// RVA: -1 Offset: -1 Slot: 18
	protected abstract void CallResultFunc();

	// RVA: 0x1F1A5A0 Offset: 0x1F1A6A1 VA: 0x1F1A5A0
	private void Result() { }

	// RVA: 0x1F1A5B0 Offset: 0x1F1A6B1 VA: 0x1F1A5B0
	private static void ThreadFunc(object obj) { }

	// RVA: 0x1F1A8A0 Offset: 0x1F1A9A1 VA: 0x1F1A8A0
	private static ProfanityFilter.PatternList GetPatterns() { }

	// RVA: 0x1F198D0 Offset: 0x1F199D1 VA: 0x1F198D0
	protected void CreateBindImpl(ProcInst super) { }
}

// Namespace: 
private class Ngc.CheckTextSequence : Ngc.MaskTextSequenceBase // TypeDefIndex: 9148
{
	// Fields
	private Ngc.CheckTextResultFunction m_ResultFunc; // 0x80

	// Methods

	// RVA: 0x1F19E40 Offset: 0x1F19F41 VA: 0x1F19E40
	private void .ctor(string text, Ngc.CheckTextResultFunction resultFunc) { }

	// RVA: 0x1F19F10 Offset: 0x1F1A011 VA: 0x1F19F10 Slot: 18
	protected override void CallResultFunc() { }

	// RVA: 0x1F19F70 Offset: 0x1F1A071 VA: 0x1F19F70
	public static void CreateBind(ProcInst super, string text, Ngc.CheckTextResultFunction resultFunc) { }
}

