// Namespace: UnityEngine.Yoga
internal sealed class MeasureFunction : MulticastDelegate // TypeDefIndex: 7564
{
	// Methods

	// RVA: 0x1C69180 Offset: 0x1C69281 VA: 0x1C69180
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C691A0 Offset: 0x1C692A1 VA: 0x1C691A0 Slot: 13
	public virtual YogaSize Invoke(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode) { }

	// RVA: 0x1C69580 Offset: 0x1C69681 VA: 0x1C69580 Slot: 14
	public virtual IAsyncResult BeginInvoke(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode, AsyncCallback callback, object object) { }

	// RVA: 0x1C69670 Offset: 0x1C69771 VA: 0x1C69670 Slot: 15
	public virtual YogaSize EndInvoke(IAsyncResult result) { }
}

