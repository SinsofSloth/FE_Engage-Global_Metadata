// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x4F140 Offset: 0x4F241 VA: 0x4F140
[NativeHeaderAttribute] // RVA: 0x4F140 Offset: 0x4F241 VA: 0x4F140
[NativeHeaderAttribute] // RVA: 0x4F140 Offset: 0x4F241 VA: 0x4F140
[RequireComponent] // RVA: 0x4F140 Offset: 0x4F241 VA: 0x4F140
public sealed class ParticleSystemRenderer : Renderer // TypeDefIndex: 4848
{
	// Properties
	[NativeNameAttribute] // RVA: 0x514B0 Offset: 0x515B1 VA: 0x514B0
	public ParticleSystemRenderSpace alignment { get; set; }
	public ParticleSystemRenderMode renderMode { get; set; }
	public ParticleSystemSortMode sortMode { get; set; }
	public float lengthScale { get; set; }
	public float velocityScale { get; set; }
	public float cameraVelocityScale { get; set; }
	public float normalDirection { get; set; }
	public float shadowBias { get; set; }
	public float sortingFudge { get; set; }
	public float minParticleSize { get; set; }
	public float maxParticleSize { get; set; }
	public Vector3 pivot { get; set; }
	public Vector3 flip { get; set; }
	public SpriteMaskInteraction maskInteraction { get; set; }
	public Material trailMaterial { get; set; }
	public bool enableGPUInstancing { get; set; }
	public bool allowRoll { get; set; }
	public bool freeformStretching { get; set; }
	public bool rotateWithStretchDirection { get; set; }
	public Mesh mesh { get; set; }
	public int meshCount { get; }
	public int activeVertexStreamsCount { get; }

	// Methods

	[ObsoleteAttribute] // RVA: 0x505C0 Offset: 0x506C1 VA: 0x505C0
	// RVA: 0x1C34F60 Offset: 0x1C35061 VA: 0x1C34F60
	public void EnableVertexStreams(ParticleSystemVertexStreams streams) { }

	[ObsoleteAttribute] // RVA: 0x50600 Offset: 0x50701 VA: 0x50600
	// RVA: 0x1C35630 Offset: 0x1C35731 VA: 0x1C35630
	public void DisableVertexStreams(ParticleSystemVertexStreams streams) { }

	[ObsoleteAttribute] // RVA: 0x50640 Offset: 0x50741 VA: 0x50640
	// RVA: 0x1C35640 Offset: 0x1C35741 VA: 0x1C35640
	public bool AreVertexStreamsEnabled(ParticleSystemVertexStreams streams) { }

	[ObsoleteAttribute] // RVA: 0x50680 Offset: 0x50781 VA: 0x50680
	// RVA: 0x1C358F0 Offset: 0x1C359F1 VA: 0x1C358F0
	public ParticleSystemVertexStreams GetEnabledVertexStreams(ParticleSystemVertexStreams streams) { }

	[ObsoleteAttribute] // RVA: 0x506C0 Offset: 0x507C1 VA: 0x506C0
	// RVA: 0x1C34F70 Offset: 0x1C35071 VA: 0x1C34F70
	internal void Internal_SetVertexStreams(ParticleSystemVertexStreams streams, bool enabled) { }

	[ObsoleteAttribute] // RVA: 0x50700 Offset: 0x50801 VA: 0x50700
	// RVA: 0x1C35670 Offset: 0x1C35771 VA: 0x1C35670
	internal ParticleSystemVertexStreams Internal_GetEnabledVertexStreams(ParticleSystemVertexStreams streams) { }

	// RVA: 0x1C359F0 Offset: 0x1C35AF1 VA: 0x1C359F0
	public ParticleSystemRenderSpace get_alignment() { }

	// RVA: 0x1C35A40 Offset: 0x1C35B41 VA: 0x1C35A40
	public void set_alignment(ParticleSystemRenderSpace value) { }

	// RVA: 0x1C35A90 Offset: 0x1C35B91 VA: 0x1C35A90
	public ParticleSystemRenderMode get_renderMode() { }

	// RVA: 0x1C35AE0 Offset: 0x1C35BE1 VA: 0x1C35AE0
	public void set_renderMode(ParticleSystemRenderMode value) { }

	// RVA: 0x1C35B30 Offset: 0x1C35C31 VA: 0x1C35B30
	public ParticleSystemSortMode get_sortMode() { }

	// RVA: 0x1C35B80 Offset: 0x1C35C81 VA: 0x1C35B80
	public void set_sortMode(ParticleSystemSortMode value) { }

	// RVA: 0x1C35BD0 Offset: 0x1C35CD1 VA: 0x1C35BD0
	public float get_lengthScale() { }

	// RVA: 0x1C35C20 Offset: 0x1C35D21 VA: 0x1C35C20
	public void set_lengthScale(float value) { }

	// RVA: 0x1C35C70 Offset: 0x1C35D71 VA: 0x1C35C70
	public float get_velocityScale() { }

	// RVA: 0x1C35CC0 Offset: 0x1C35DC1 VA: 0x1C35CC0
	public void set_velocityScale(float value) { }

	// RVA: 0x1C35D10 Offset: 0x1C35E11 VA: 0x1C35D10
	public float get_cameraVelocityScale() { }

	// RVA: 0x1C35D60 Offset: 0x1C35E61 VA: 0x1C35D60
	public void set_cameraVelocityScale(float value) { }

	// RVA: 0x1C35DB0 Offset: 0x1C35EB1 VA: 0x1C35DB0
	public float get_normalDirection() { }

	// RVA: 0x1C35E00 Offset: 0x1C35F01 VA: 0x1C35E00
	public void set_normalDirection(float value) { }

	// RVA: 0x1C35E50 Offset: 0x1C35F51 VA: 0x1C35E50
	public float get_shadowBias() { }

	// RVA: 0x1C35EA0 Offset: 0x1C35FA1 VA: 0x1C35EA0
	public void set_shadowBias(float value) { }

	// RVA: 0x1C35EF0 Offset: 0x1C35FF1 VA: 0x1C35EF0
	public float get_sortingFudge() { }

	// RVA: 0x1C35F40 Offset: 0x1C36041 VA: 0x1C35F40
	public void set_sortingFudge(float value) { }

	// RVA: 0x1C35F90 Offset: 0x1C36091 VA: 0x1C35F90
	public float get_minParticleSize() { }

	// RVA: 0x1C35FE0 Offset: 0x1C360E1 VA: 0x1C35FE0
	public void set_minParticleSize(float value) { }

	// RVA: 0x1C36030 Offset: 0x1C36131 VA: 0x1C36030
	public float get_maxParticleSize() { }

	// RVA: 0x1C36080 Offset: 0x1C36181 VA: 0x1C36080
	public void set_maxParticleSize(float value) { }

	// RVA: 0x1C360D0 Offset: 0x1C361D1 VA: 0x1C360D0
	public Vector3 get_pivot() { }

	// RVA: 0x1C36180 Offset: 0x1C36281 VA: 0x1C36180
	public void set_pivot(Vector3 value) { }

	// RVA: 0x1C36230 Offset: 0x1C36331 VA: 0x1C36230
	public Vector3 get_flip() { }

	// RVA: 0x1C362E0 Offset: 0x1C363E1 VA: 0x1C362E0
	public void set_flip(Vector3 value) { }

	// RVA: 0x1C36390 Offset: 0x1C36491 VA: 0x1C36390
	public SpriteMaskInteraction get_maskInteraction() { }

	// RVA: 0x1C363E0 Offset: 0x1C364E1 VA: 0x1C363E0
	public void set_maskInteraction(SpriteMaskInteraction value) { }

	// RVA: 0x1C36430 Offset: 0x1C36531 VA: 0x1C36430
	public Material get_trailMaterial() { }

	// RVA: 0x1C36480 Offset: 0x1C36581 VA: 0x1C36480
	public void set_trailMaterial(Material value) { }

	// RVA: 0x1C364D0 Offset: 0x1C365D1 VA: 0x1C364D0
	public bool get_enableGPUInstancing() { }

	// RVA: 0x1C36520 Offset: 0x1C36621 VA: 0x1C36520
	public void set_enableGPUInstancing(bool value) { }

	// RVA: 0x1C36570 Offset: 0x1C36671 VA: 0x1C36570
	public bool get_allowRoll() { }

	// RVA: 0x1C365C0 Offset: 0x1C366C1 VA: 0x1C365C0
	public void set_allowRoll(bool value) { }

	// RVA: 0x1C36610 Offset: 0x1C36711 VA: 0x1C36610
	public bool get_freeformStretching() { }

	// RVA: 0x1C36660 Offset: 0x1C36761 VA: 0x1C36660
	public void set_freeformStretching(bool value) { }

	// RVA: 0x1C366B0 Offset: 0x1C367B1 VA: 0x1C366B0
	public bool get_rotateWithStretchDirection() { }

	// RVA: 0x1C36700 Offset: 0x1C36801 VA: 0x1C36700
	public void set_rotateWithStretchDirection(bool value) { }

	[FreeFunctionAttribute] // RVA: 0x50740 Offset: 0x50841 VA: 0x50740
	// RVA: 0x1C36750 Offset: 0x1C36851 VA: 0x1C36750
	public Mesh get_mesh() { }

	[FreeFunctionAttribute] // RVA: 0x50790 Offset: 0x50891 VA: 0x50790
	// RVA: 0x1C367A0 Offset: 0x1C368A1 VA: 0x1C367A0
	public void set_mesh(Mesh value) { }

	[FreeFunctionAttribute] // RVA: 0x507E0 Offset: 0x508E1 VA: 0x507E0
	[RequiredByNativeCodeAttribute] // RVA: 0x507E0 Offset: 0x508E1 VA: 0x507E0
	// RVA: 0x1C367F0 Offset: 0x1C368F1 VA: 0x1C367F0
	public int GetMeshes([Out] Mesh[] meshes) { }

	[FreeFunctionAttribute] // RVA: 0x50840 Offset: 0x50941 VA: 0x50840
	// RVA: 0x1C36840 Offset: 0x1C36941 VA: 0x1C36840
	public void SetMeshes(Mesh[] meshes, int size) { }

	// RVA: 0x1C368A0 Offset: 0x1C369A1 VA: 0x1C368A0
	public void SetMeshes(Mesh[] meshes) { }

	// RVA: 0x1C36900 Offset: 0x1C36A01 VA: 0x1C36900
	public int get_meshCount() { }

	// RVA: 0x1C36950 Offset: 0x1C36A51 VA: 0x1C36950
	public void BakeMesh(Mesh mesh, bool useTransform = False) { }

	// RVA: 0x1C369C0 Offset: 0x1C36AC1 VA: 0x1C369C0
	public void BakeMesh(Mesh mesh, Camera camera, bool useTransform = False) { }

	// RVA: 0x1C36A30 Offset: 0x1C36B31 VA: 0x1C36A30
	public void BakeTrailsMesh(Mesh mesh, bool useTransform = False) { }

	// RVA: 0x1C36AA0 Offset: 0x1C36BA1 VA: 0x1C36AA0
	public void BakeTrailsMesh(Mesh mesh, Camera camera, bool useTransform = False) { }

	// RVA: 0x1C35900 Offset: 0x1C35A01 VA: 0x1C35900
	public int get_activeVertexStreamsCount() { }

	[FreeFunctionAttribute] // RVA: 0x50890 Offset: 0x50991 VA: 0x50890
	// RVA: 0x1C359A0 Offset: 0x1C35AA1 VA: 0x1C359A0
	public void SetActiveVertexStreams(List<ParticleSystemVertexStream> streams) { }

	[FreeFunctionAttribute] // RVA: 0x508E0 Offset: 0x509E1 VA: 0x508E0
	// RVA: 0x1C35950 Offset: 0x1C35A51 VA: 0x1C35950
	public void GetActiveVertexStreams(List<ParticleSystemVertexStream> streams) { }

	// RVA: 0x1C36B10 Offset: 0x1C36C11 VA: 0x1C36B10
	public void .ctor() { }

	// RVA: 0x1C36130 Offset: 0x1C36231 VA: 0x1C36130
	private void get_pivot_Injected(out Vector3 ret) { }

	// RVA: 0x1C361E0 Offset: 0x1C362E1 VA: 0x1C361E0
	private void set_pivot_Injected(ref Vector3 value) { }

	// RVA: 0x1C36290 Offset: 0x1C36391 VA: 0x1C36290
	private void get_flip_Injected(out Vector3 ret) { }

	// RVA: 0x1C36340 Offset: 0x1C36441 VA: 0x1C36340
	private void set_flip_Injected(ref Vector3 value) { }
}

