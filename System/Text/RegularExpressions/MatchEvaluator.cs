// Namespace: System.Text.RegularExpressions
[Serializable]
public sealed class MatchEvaluator : MulticastDelegate // TypeDefIndex: 2246
{
	// Methods

	// RVA: 0x1AC5EF0 Offset: 0x1AC5FF1 VA: 0x1AC5EF0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1AC5F10 Offset: 0x1AC6011 VA: 0x1AC5F10 Slot: 13
	public virtual string Invoke(Match match) { }

	// RVA: 0x1AC6270 Offset: 0x1AC6371 VA: 0x1AC6270 Slot: 14
	public virtual IAsyncResult BeginInvoke(Match match, AsyncCallback callback, object object) { }

	// RVA: 0x1AC62A0 Offset: 0x1AC63A1 VA: 0x1AC62A0 Slot: 15
	public virtual string EndInvoke(IAsyncResult result) { }
}

