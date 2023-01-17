// Namespace: UnityEngine.Experimental.Rendering.RenderGraphModule
[DebuggerDisplayAttribute] // RVA: 0x3B210 Offset: 0x3B311 VA: 0x3B210
internal sealed class RenderGraphPass<PassData> : RenderGraphPass // TypeDefIndex: 4482
{
	// Fields
	internal PassData data; // 0x0
	internal RenderFunc<PassData> renderFunc; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public override void Execute(RenderGraphContext renderGraphContext) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF2070 Offset: 0x2FF2171 VA: 0x2FF2070
	|-RenderGraphPass<object>.Execute
	*/

	// RVA: -1 Offset: -1
	public void Initialize(int passIndex, PassData passData, string passName, ProfilingSampler sampler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF20D0 Offset: 0x2FF21D1 VA: 0x2FF20D0
	|-RenderGraphPass<object>.Initialize
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override void Release(RenderGraphObjectPool pool) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF2150 Offset: 0x2FF2251 VA: 0x2FF2150
	|-RenderGraphPass<object>.Release
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override bool HasRenderFunc() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF21D0 Offset: 0x2FF22D1 VA: 0x2FF21D0
	|-RenderGraphPass<object>.HasRenderFunc
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF21E0 Offset: 0x2FF22E1 VA: 0x2FF21E0
	|-RenderGraphPass<object>..ctor
	*/
}

