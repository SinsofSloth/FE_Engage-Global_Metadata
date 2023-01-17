// Namespace: 
public sealed class MinigameAssistDialog.DecideEventHandler : MulticastDelegate // TypeDefIndex: 11266
{
	// Methods

	// RVA: 0x2153640 Offset: 0x2153741 VA: 0x2153640
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2153660 Offset: 0x2153761 VA: 0x2153660 Slot: 13
	public virtual void Invoke(int set) { }

	// RVA: 0x2153890 Offset: 0x2153991 VA: 0x2153890 Slot: 14
	public virtual IAsyncResult BeginInvoke(int set, AsyncCallback callback, object object) { }

	// RVA: 0x2153920 Offset: 0x2153A21 VA: 0x2153920 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public enum MinigameAssistDialog.AssistResult // TypeDefIndex: 11268
{
	// Fields
	public int value__; // 0x0
	public const MinigameAssistDialog.AssistResult Yes = 0;
	public const MinigameAssistDialog.AssistResult No = 1;
	public const MinigameAssistDialog.AssistResult Cancel = 2;
}

