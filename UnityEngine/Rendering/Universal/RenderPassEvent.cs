// Namespace: UnityEngine.Rendering.Universal
[MovedFromAttribute] // RVA: 0x47F8A0 Offset: 0x47F9A1 VA: 0x47F8A0
public enum RenderPassEvent // TypeDefIndex: 5318
{
	// Fields
	public int value__; // 0x0
	public const RenderPassEvent BeforeRendering = 0;
	public const RenderPassEvent BeforeRenderingShadows = 50;
	public const RenderPassEvent AfterRenderingShadows = 100;
	public const RenderPassEvent BeforeRenderingPrepasses = 150;
	public const RenderPassEvent AfterRenderingPrePasses = 200;
	public const RenderPassEvent BeforeRenderingOpaques = 250;
	public const RenderPassEvent AfterRenderingOpaques = 300;
	public const RenderPassEvent BeforeRenderingSkybox = 350;
	public const RenderPassEvent AfterRenderingSkybox = 400;
	public const RenderPassEvent BeforeRenderingTransparents = 450;
	public const RenderPassEvent AfterRenderingTransparents = 500;
	public const RenderPassEvent BeforeRenderingPostProcessing = 550;
	public const RenderPassEvent AfterRenderingPostProcessing = 600;
	public const RenderPassEvent AfterRendering = 1000;
}

