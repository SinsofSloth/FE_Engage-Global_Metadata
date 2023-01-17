// Namespace: UnityEngine.Experimental.Rendering.RenderGraphModule
public sealed class RenderFunc<PassData> : MulticastDelegate // TypeDefIndex: 4464
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF1CA0 Offset: 0x2FF1DA1 VA: 0x2FF1CA0
	|-RenderFunc<object>..ctor
	|-RenderFunc<RenderGraph.ProfilingScopePassData>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke(PassData data, RenderGraphContext renderGraphContext) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF1CC0 Offset: 0x2FF1DC1 VA: 0x2FF1CC0
	|-RenderFunc<object>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(PassData data, RenderGraphContext renderGraphContext, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF2030 Offset: 0x2FF2131 VA: 0x2FF2030
	|-RenderFunc<object>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF2060 Offset: 0x2FF2161 VA: 0x2FF2060
	|-RenderFunc<object>.EndInvoke
	*/
}

