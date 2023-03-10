// Namespace: UnityEngine.Rendering
public enum PassType // TypeDefIndex: 3892
{
	// Fields
	public int value__; // 0x0
	public const PassType Normal = 0;
	public const PassType Vertex = 1;
	public const PassType VertexLM = 2;
	[ObsoleteAttribute] // RVA: 0x444620 Offset: 0x444721 VA: 0x444620
	public const PassType VertexLMRGBM = 3;
	public const PassType ForwardBase = 4;
	public const PassType ForwardAdd = 5;
	public const PassType LightPrePassBase = 6;
	public const PassType LightPrePassFinal = 7;
	public const PassType ShadowCaster = 8;
	public const PassType Deferred = 10;
	public const PassType Meta = 11;
	public const PassType MotionVectors = 12;
	public const PassType ScriptableRenderPipeline = 13;
	public const PassType ScriptableRenderPipelineDefaultUnlit = 14;
}

