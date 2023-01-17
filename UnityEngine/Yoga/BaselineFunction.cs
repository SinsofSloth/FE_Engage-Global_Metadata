// Namespace: UnityEngine.Yoga
internal sealed class BaselineFunction : MulticastDelegate // TypeDefIndex: 7563
{
	// Methods

	// RVA: 0x1C68CE0 Offset: 0x1C68DE1 VA: 0x1C68CE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C68D00 Offset: 0x1C68E01 VA: 0x1C68D00 Slot: 13
	public virtual float Invoke(YogaNode node, float width, float height) { }

	// RVA: 0x1C690A0 Offset: 0x1C691A1 VA: 0x1C690A0 Slot: 14
	public virtual IAsyncResult BeginInvoke(YogaNode node, float width, float height, AsyncCallback callback, object object) { }

	// RVA: 0x1C69150 Offset: 0x1C69251 VA: 0x1C69150 Slot: 15
	public virtual float EndInvoke(IAsyncResult result) { }
}

