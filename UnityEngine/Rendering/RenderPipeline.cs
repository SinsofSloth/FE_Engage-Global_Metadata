// Namespace: UnityEngine.Rendering
public abstract class RenderPipeline // TypeDefIndex: 3950
{
	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x444DC0 Offset: 0x444EC1 VA: 0x444DC0
	[CompilerGeneratedAttribute] // RVA: 0x444DC0 Offset: 0x444EC1 VA: 0x444DC0
	private bool <disposed>k__BackingField; // 0x10

	// Properties
	public bool disposed { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void Render(ScriptableRenderContext context, Camera[] cameras);

	// RVA: 0x31D7840 Offset: 0x31D7941 VA: 0x31D7840 Slot: 5
	protected virtual void ProcessRenderRequests(ScriptableRenderContext context, Camera camera, List<Camera.RenderRequest> renderRequests) { }

	// RVA: 0x31D7850 Offset: 0x31D7951 VA: 0x31D7850
	protected static void BeginFrameRendering(ScriptableRenderContext context, Camera[] cameras) { }

	// RVA: 0x31D7A10 Offset: 0x31D7B11 VA: 0x31D7A10
	protected static void BeginCameraRendering(ScriptableRenderContext context, Camera camera) { }

	// RVA: 0x31D7BD0 Offset: 0x31D7CD1 VA: 0x31D7BD0
	protected static void EndFrameRendering(ScriptableRenderContext context, Camera[] cameras) { }

	// RVA: 0x31D7D90 Offset: 0x31D7E91 VA: 0x31D7D90
	protected static void EndCameraRendering(ScriptableRenderContext context, Camera camera) { }

	// RVA: 0x31D7F50 Offset: 0x31D8051 VA: 0x31D7F50
	internal void InternalRender(ScriptableRenderContext context, Camera[] cameras) { }

	// RVA: 0x31D7FE0 Offset: 0x31D80E1 VA: 0x31D7FE0
	internal void InternalRenderWithRequests(ScriptableRenderContext context, Camera[] cameras, List<Camera.RenderRequest> renderRequests) { }

	[CompilerGeneratedAttribute] // RVA: 0x454290 Offset: 0x454391 VA: 0x454290
	// RVA: 0x31D8090 Offset: 0x31D8191 VA: 0x31D8090
	public bool get_disposed() { }

	[CompilerGeneratedAttribute] // RVA: 0x4542A0 Offset: 0x4543A1 VA: 0x4542A0
	// RVA: 0x31D80A0 Offset: 0x31D81A1 VA: 0x31D80A0
	private void set_disposed(bool value) { }

	// RVA: 0x31D80B0 Offset: 0x31D81B1 VA: 0x31D80B0
	internal void Dispose() { }

	// RVA: 0x31D8140 Offset: 0x31D8241 VA: 0x31D8140 Slot: 6
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x31D8150 Offset: 0x31D8251 VA: 0x31D8150
	protected void .ctor() { }
}

