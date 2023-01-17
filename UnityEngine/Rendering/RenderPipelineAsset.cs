// Namespace: UnityEngine.Rendering
public abstract class RenderPipelineAsset : ScriptableObject // TypeDefIndex: 3951
{
	// Properties
	public virtual string[] renderingLayerMaskNames { get; }
	public virtual Material defaultMaterial { get; }
	public virtual Shader autodeskInteractiveShader { get; }
	public virtual Shader autodeskInteractiveTransparentShader { get; }
	public virtual Shader autodeskInteractiveMaskedShader { get; }
	public virtual Shader terrainDetailLitShader { get; }
	public virtual Shader terrainDetailGrassShader { get; }
	public virtual Shader terrainDetailGrassBillboardShader { get; }
	public virtual Material defaultParticleMaterial { get; }
	public virtual Material defaultLineMaterial { get; }
	public virtual Material defaultTerrainMaterial { get; }
	public virtual Material defaultUIMaterial { get; }
	public virtual Material defaultUIOverdrawMaterial { get; }
	public virtual Material defaultUIETC1SupportedMaterial { get; }
	public virtual Material default2DMaterial { get; }
	public virtual Shader defaultShader { get; }
	public virtual Shader defaultSpeedTree7Shader { get; }
	public virtual Shader defaultSpeedTree8Shader { get; }

	// Methods

	// RVA: 0x31D8160 Offset: 0x31D8261 VA: 0x31D8160
	internal RenderPipeline InternalCreatePipeline() { }

	// RVA: 0x31D8480 Offset: 0x31D8581 VA: 0x31D8480 Slot: 4
	public virtual string[] get_renderingLayerMaskNames() { }

	// RVA: 0x31D8490 Offset: 0x31D8591 VA: 0x31D8490 Slot: 5
	public virtual Material get_defaultMaterial() { }

	// RVA: 0x31D84A0 Offset: 0x31D85A1 VA: 0x31D84A0 Slot: 6
	public virtual Shader get_autodeskInteractiveShader() { }

	// RVA: 0x31D84B0 Offset: 0x31D85B1 VA: 0x31D84B0 Slot: 7
	public virtual Shader get_autodeskInteractiveTransparentShader() { }

	// RVA: 0x31D84C0 Offset: 0x31D85C1 VA: 0x31D84C0 Slot: 8
	public virtual Shader get_autodeskInteractiveMaskedShader() { }

	// RVA: 0x31D84D0 Offset: 0x31D85D1 VA: 0x31D84D0 Slot: 9
	public virtual Shader get_terrainDetailLitShader() { }

	// RVA: 0x31D84E0 Offset: 0x31D85E1 VA: 0x31D84E0 Slot: 10
	public virtual Shader get_terrainDetailGrassShader() { }

	// RVA: 0x31D84F0 Offset: 0x31D85F1 VA: 0x31D84F0 Slot: 11
	public virtual Shader get_terrainDetailGrassBillboardShader() { }

	// RVA: 0x31D8500 Offset: 0x31D8601 VA: 0x31D8500 Slot: 12
	public virtual Material get_defaultParticleMaterial() { }

	// RVA: 0x31D8510 Offset: 0x31D8611 VA: 0x31D8510 Slot: 13
	public virtual Material get_defaultLineMaterial() { }

	// RVA: 0x31D8520 Offset: 0x31D8621 VA: 0x31D8520 Slot: 14
	public virtual Material get_defaultTerrainMaterial() { }

	// RVA: 0x31D8530 Offset: 0x31D8631 VA: 0x31D8530 Slot: 15
	public virtual Material get_defaultUIMaterial() { }

	// RVA: 0x31D8540 Offset: 0x31D8641 VA: 0x31D8540 Slot: 16
	public virtual Material get_defaultUIOverdrawMaterial() { }

	// RVA: 0x31D8550 Offset: 0x31D8651 VA: 0x31D8550 Slot: 17
	public virtual Material get_defaultUIETC1SupportedMaterial() { }

	// RVA: 0x31D8560 Offset: 0x31D8661 VA: 0x31D8560 Slot: 18
	public virtual Material get_default2DMaterial() { }

	// RVA: 0x31D8570 Offset: 0x31D8671 VA: 0x31D8570 Slot: 19
	public virtual Shader get_defaultShader() { }

	// RVA: 0x31D8580 Offset: 0x31D8681 VA: 0x31D8580 Slot: 20
	public virtual Shader get_defaultSpeedTree7Shader() { }

	// RVA: 0x31D8590 Offset: 0x31D8691 VA: 0x31D8590 Slot: 21
	public virtual Shader get_defaultSpeedTree8Shader() { }

	// RVA: -1 Offset: -1 Slot: 22
	protected abstract RenderPipeline CreatePipeline();

	// RVA: 0x31D85A0 Offset: 0x31D86A1 VA: 0x31D85A0 Slot: 23
	protected virtual void OnValidate() { }

	// RVA: 0x31D8D00 Offset: 0x31D8E01 VA: 0x31D8D00 Slot: 24
	protected virtual void OnDisable() { }

	// RVA: 0x31D8D70 Offset: 0x31D8E71 VA: 0x31D8D70
	protected void .ctor() { }
}

