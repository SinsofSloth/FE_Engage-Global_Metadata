// Namespace: 
public sealed class InteractionSystem.InteractionDelegate : MulticastDelegate // TypeDefIndex: 14414
{
	// Methods

	// RVA: 0x2221240 Offset: 0x2221341 VA: 0x2221240
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2221260 Offset: 0x2221361 VA: 0x2221260 Slot: 13
	public virtual void Invoke(FullBodyBipedEffector effectorType, InteractionObject interactionObject) { }

	// RVA: 0x22214D0 Offset: 0x22215D1 VA: 0x22214D0 Slot: 14
	public virtual IAsyncResult BeginInvoke(FullBodyBipedEffector effectorType, InteractionObject interactionObject, AsyncCallback callback, object object) { }

	// RVA: 0x2221570 Offset: 0x2221671 VA: 0x2221570 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

