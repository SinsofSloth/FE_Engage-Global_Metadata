// Namespace: 
[VisibleToOtherModulesAttribute] // RVA: 0x441210 Offset: 0x441311 VA: 0x441210
internal sealed class PlayableBinding.CreateOutputMethod : MulticastDelegate // TypeDefIndex: 3989
{
	// Methods

	// RVA: 0x3854EA0 Offset: 0x3854FA1 VA: 0x3854EA0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3854EC0 Offset: 0x3854FC1 VA: 0x3854EC0 Slot: 13
	public virtual PlayableOutput Invoke(PlayableGraph graph, string name) { }

	// RVA: 0x3855140 Offset: 0x3855241 VA: 0x3855140 Slot: 14
	public virtual IAsyncResult BeginInvoke(PlayableGraph graph, string name, AsyncCallback callback, object object) { }

	// RVA: 0x38551E0 Offset: 0x38552E1 VA: 0x38551E0 Slot: 15
	public virtual PlayableOutput EndInvoke(IAsyncResult result) { }
}

