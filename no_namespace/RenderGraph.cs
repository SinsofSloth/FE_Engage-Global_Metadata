// Namespace: 
internal sealed class RenderGraph.OnGraphRegisteredDelegate : MulticastDelegate // TypeDefIndex: 4471
{
	// Methods

	// RVA: 0x3553130 Offset: 0x3553231 VA: 0x3553130
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3553150 Offset: 0x3553251 VA: 0x3553150 Slot: 13
	public virtual void Invoke(RenderGraph graph) { }

	// RVA: 0x35534B0 Offset: 0x35535B1 VA: 0x35534B0 Slot: 14
	public virtual IAsyncResult BeginInvoke(RenderGraph graph, AsyncCallback callback, object object) { }

	// RVA: 0x35534E0 Offset: 0x35535E1 VA: 0x35534E0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

