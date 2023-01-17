// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x4EDF0 Offset: 0x4EEF1 VA: 0x4EDF0
[RequireComponent] // RVA: 0x4EDF0 Offset: 0x4EEF1 VA: 0x4EDF0
[NativeHeaderAttribute] // RVA: 0x4EDF0 Offset: 0x4EEF1 VA: 0x4EDF0
[NativeHeaderAttribute] // RVA: 0x4EDF0 Offset: 0x4EEF1 VA: 0x4EDF0
[UsedByNativeCodeAttribute] // RVA: 0x4EDF0 Offset: 0x4EEF1 VA: 0x4EDF0
[NativeHeaderAttribute] // RVA: 0x4EDF0 Offset: 0x4EEF1 VA: 0x4EDF0
[NativeHeaderAttribute] // RVA: 0x4EDF0 Offset: 0x4EEF1 VA: 0x4EDF0
[NativeHeaderAttribute] // RVA: 0x4EDF0 Offset: 0x4EEF1 VA: 0x4EDF0
[NativeHeaderAttribute] // RVA: 0x4EDF0 Offset: 0x4EEF1 VA: 0x4EDF0
[NativeHeaderAttribute] // RVA: 0x4EDF0 Offset: 0x4EEF1 VA: 0x4EDF0
public sealed class ParticleSystem : Component // TypeDefIndex: 4832
{
	// Properties
	[ObsoleteAttribute] // RVA: 0x50F30 Offset: 0x51031 VA: 0x50F30
	public float startDelay { get; set; }
	[ObsoleteAttribute] // RVA: 0x50F70 Offset: 0x51071 VA: 0x50F70
	public bool loop { get; set; }
	[ObsoleteAttribute] // RVA: 0x50FB0 Offset: 0x510B1 VA: 0x50FB0
	public bool playOnAwake { get; set; }
	[ObsoleteAttribute] // RVA: 0x50FF0 Offset: 0x510F1 VA: 0x50FF0
	public float duration { get; }
	[ObsoleteAttribute] // RVA: 0x51030 Offset: 0x51131 VA: 0x51030
	public float playbackSpeed { get; set; }
	[ObsoleteAttribute] // RVA: 0x51070 Offset: 0x51171 VA: 0x51070
	public bool enableEmission { get; set; }
	[ObsoleteAttribute] // RVA: 0x510B0 Offset: 0x511B1 VA: 0x510B0
	public float emissionRate { get; set; }
	[ObsoleteAttribute] // RVA: 0x510F0 Offset: 0x511F1 VA: 0x510F0
	public float startSpeed { get; set; }
	[ObsoleteAttribute] // RVA: 0x51130 Offset: 0x51231 VA: 0x51130
	public float startSize { get; set; }
	[ObsoleteAttribute] // RVA: 0x51170 Offset: 0x51271 VA: 0x51170
	public Color startColor { get; set; }
	[ObsoleteAttribute] // RVA: 0x511B0 Offset: 0x512B1 VA: 0x511B0
	public float startRotation { get; set; }
	[ObsoleteAttribute] // RVA: 0x511F0 Offset: 0x512F1 VA: 0x511F0
	public Vector3 startRotation3D { get; set; }
	[ObsoleteAttribute] // RVA: 0x51230 Offset: 0x51331 VA: 0x51230
	public float startLifetime { get; set; }
	[ObsoleteAttribute] // RVA: 0x51270 Offset: 0x51371 VA: 0x51270
	public float gravityModifier { get; set; }
	[ObsoleteAttribute] // RVA: 0x512B0 Offset: 0x513B1 VA: 0x512B0
	public int maxParticles { get; set; }
	[ObsoleteAttribute] // RVA: 0x512F0 Offset: 0x513F1 VA: 0x512F0
	public ParticleSystemSimulationSpace simulationSpace { get; set; }
	[ObsoleteAttribute] // RVA: 0x51330 Offset: 0x51431 VA: 0x51330
	public ParticleSystemScalingMode scalingMode { get; set; }
	[ObsoleteAttribute] // RVA: 0x51370 Offset: 0x51471 VA: 0x51370
	public bool automaticCullingEnabled { get; }
	public bool isPlaying { get; }
	public bool isEmitting { get; }
	public bool isStopped { get; }
	public bool isPaused { get; }
	public int particleCount { get; }
	public float time { get; set; }
	public uint randomSeed { get; set; }
	public bool useAutoRandomSeed { get; set; }
	public bool proceduralSimulationSupported { get; }
	public ParticleSystem.MainModule main { get; }
	public ParticleSystem.EmissionModule emission { get; }
	public ParticleSystem.ShapeModule shape { get; }
	public ParticleSystem.VelocityOverLifetimeModule velocityOverLifetime { get; }
	public ParticleSystem.LimitVelocityOverLifetimeModule limitVelocityOverLifetime { get; }
	public ParticleSystem.InheritVelocityModule inheritVelocity { get; }
	public ParticleSystem.LifetimeByEmitterSpeedModule lifetimeByEmitterSpeed { get; }
	public ParticleSystem.ForceOverLifetimeModule forceOverLifetime { get; }
	public ParticleSystem.ColorOverLifetimeModule colorOverLifetime { get; }
	public ParticleSystem.ColorBySpeedModule colorBySpeed { get; }
	public ParticleSystem.SizeOverLifetimeModule sizeOverLifetime { get; }
	public ParticleSystem.SizeBySpeedModule sizeBySpeed { get; }
	public ParticleSystem.RotationOverLifetimeModule rotationOverLifetime { get; }
	public ParticleSystem.RotationBySpeedModule rotationBySpeed { get; }
	public ParticleSystem.ExternalForcesModule externalForces { get; }
	public ParticleSystem.NoiseModule noise { get; }
	public ParticleSystem.CollisionModule collision { get; }
	public ParticleSystem.TriggerModule trigger { get; }
	public ParticleSystem.SubEmittersModule subEmitters { get; }
	public ParticleSystem.TextureSheetAnimationModule textureSheetAnimation { get; }
	public ParticleSystem.LightsModule lights { get; }
	public ParticleSystem.TrailModule trails { get; }
	public ParticleSystem.CustomDataModule customData { get; }

	// Methods

	[ObsoleteAttribute] // RVA: 0x4F830 Offset: 0x4F931 VA: 0x4F830
	// RVA: 0x1C2F7B0 Offset: 0x1C2F8B1 VA: 0x1C2F7B0
	public void Emit(Vector3 position, Vector3 velocity, float size, float lifetime, Color32 color) { }

	[ObsoleteAttribute] // RVA: 0x4F870 Offset: 0x4F971 VA: 0x4F870
	// RVA: 0x1C2F9E0 Offset: 0x1C2FAE1 VA: 0x1C2F9E0
	public void Emit(ParticleSystem.Particle particle) { }

	// RVA: 0x1C2FA30 Offset: 0x1C2FB31 VA: 0x1C2FA30
	public float get_startDelay() { }

	// RVA: 0x1C2FB10 Offset: 0x1C2FC11 VA: 0x1C2FB10
	public void set_startDelay(float value) { }

	// RVA: 0x1C2FBD0 Offset: 0x1C2FCD1 VA: 0x1C2FBD0
	public bool get_loop() { }

	// RVA: 0x1C2FC80 Offset: 0x1C2FD81 VA: 0x1C2FC80
	public void set_loop(bool value) { }

	// RVA: 0x1C2FD40 Offset: 0x1C2FE41 VA: 0x1C2FD40
	public bool get_playOnAwake() { }

	// RVA: 0x1C2FDF0 Offset: 0x1C2FEF1 VA: 0x1C2FDF0
	public void set_playOnAwake(bool value) { }

	// RVA: 0x1C2FEB0 Offset: 0x1C2FFB1 VA: 0x1C2FEB0
	public float get_duration() { }

	// RVA: 0x1C2FF60 Offset: 0x1C30061 VA: 0x1C2FF60
	public float get_playbackSpeed() { }

	// RVA: 0x1C30010 Offset: 0x1C30111 VA: 0x1C30010
	public void set_playbackSpeed(float value) { }

	// RVA: 0x1C300D0 Offset: 0x1C301D1 VA: 0x1C300D0
	public bool get_enableEmission() { }

	// RVA: 0x1C301B0 Offset: 0x1C302B1 VA: 0x1C301B0
	public void set_enableEmission(bool value) { }

	// RVA: 0x1C30270 Offset: 0x1C30371 VA: 0x1C30270
	public float get_emissionRate() { }

	// RVA: 0x1C30320 Offset: 0x1C30421 VA: 0x1C30320
	public void set_emissionRate(float value) { }

	// RVA: 0x1C304B0 Offset: 0x1C305B1 VA: 0x1C304B0
	public float get_startSpeed() { }

	// RVA: 0x1C30560 Offset: 0x1C30661 VA: 0x1C30560
	public void set_startSpeed(float value) { }

	// RVA: 0x1C30620 Offset: 0x1C30721 VA: 0x1C30620
	public float get_startSize() { }

	// RVA: 0x1C306D0 Offset: 0x1C307D1 VA: 0x1C306D0
	public void set_startSize(float value) { }

	// RVA: 0x1C30790 Offset: 0x1C30891 VA: 0x1C30790
	public Color get_startColor() { }

	// RVA: 0x1C308B0 Offset: 0x1C309B1 VA: 0x1C308B0
	public void set_startColor(Color value) { }

	// RVA: 0x1C30AC0 Offset: 0x1C30BC1 VA: 0x1C30AC0
	public float get_startRotation() { }

	// RVA: 0x1C30B70 Offset: 0x1C30C71 VA: 0x1C30B70
	public void set_startRotation(float value) { }

	// RVA: 0x1C30C30 Offset: 0x1C30D31 VA: 0x1C30C30
	public Vector3 get_startRotation3D() { }

	// RVA: 0x1C30E20 Offset: 0x1C30F21 VA: 0x1C30E20
	public void set_startRotation3D(Vector3 value) { }

	// RVA: 0x1C30FF0 Offset: 0x1C310F1 VA: 0x1C30FF0
	public float get_startLifetime() { }

	// RVA: 0x1C310A0 Offset: 0x1C311A1 VA: 0x1C310A0
	public void set_startLifetime(float value) { }

	// RVA: 0x1C31160 Offset: 0x1C31261 VA: 0x1C31160
	public float get_gravityModifier() { }

	// RVA: 0x1C31210 Offset: 0x1C31311 VA: 0x1C31210
	public void set_gravityModifier(float value) { }

	// RVA: 0x1C312D0 Offset: 0x1C313D1 VA: 0x1C312D0
	public int get_maxParticles() { }

	// RVA: 0x1C31380 Offset: 0x1C31481 VA: 0x1C31380
	public void set_maxParticles(int value) { }

	// RVA: 0x1C31440 Offset: 0x1C31541 VA: 0x1C31440
	public ParticleSystemSimulationSpace get_simulationSpace() { }

	// RVA: 0x1C314F0 Offset: 0x1C315F1 VA: 0x1C314F0
	public void set_simulationSpace(ParticleSystemSimulationSpace value) { }

	// RVA: 0x1C315B0 Offset: 0x1C316B1 VA: 0x1C315B0
	public ParticleSystemScalingMode get_scalingMode() { }

	// RVA: 0x1C31660 Offset: 0x1C31761 VA: 0x1C31660
	public void set_scalingMode(ParticleSystemScalingMode value) { }

	// RVA: 0x1C31720 Offset: 0x1C31821 VA: 0x1C31720
	public bool get_automaticCullingEnabled() { }

	[NativeNameAttribute] // RVA: 0x4F8B0 Offset: 0x4F9B1 VA: 0x4F8B0
	// RVA: 0x1C317C0 Offset: 0x1C318C1 VA: 0x1C317C0
	public bool get_isPlaying() { }

	[NativeNameAttribute] // RVA: 0x4F8F0 Offset: 0x4F9F1 VA: 0x4F8F0
	// RVA: 0x1C31810 Offset: 0x1C31911 VA: 0x1C31810
	public bool get_isEmitting() { }

	[NativeNameAttribute] // RVA: 0x4F930 Offset: 0x4FA31 VA: 0x4F930
	// RVA: 0x1C31860 Offset: 0x1C31961 VA: 0x1C31860
	public bool get_isStopped() { }

	[NativeNameAttribute] // RVA: 0x4F970 Offset: 0x4FA71 VA: 0x4F970
	// RVA: 0x1C318B0 Offset: 0x1C319B1 VA: 0x1C318B0
	public bool get_isPaused() { }

	[NativeNameAttribute] // RVA: 0x4F9B0 Offset: 0x4FAB1 VA: 0x4F9B0
	// RVA: 0x1C31900 Offset: 0x1C31A01 VA: 0x1C31900
	public int get_particleCount() { }

	[NativeNameAttribute] // RVA: 0x4F9F0 Offset: 0x4FAF1 VA: 0x4F9F0
	// RVA: 0x1C31950 Offset: 0x1C31A51 VA: 0x1C31950
	public float get_time() { }

	[NativeNameAttribute] // RVA: 0x4FA30 Offset: 0x4FB31 VA: 0x4FA30
	// RVA: 0x1C319A0 Offset: 0x1C31AA1 VA: 0x1C319A0
	public void set_time(float value) { }

	[NativeNameAttribute] // RVA: 0x4FA70 Offset: 0x4FB71 VA: 0x4FA70
	// RVA: 0x1C319F0 Offset: 0x1C31AF1 VA: 0x1C319F0
	public uint get_randomSeed() { }

	[NativeNameAttribute] // RVA: 0x4FAB0 Offset: 0x4FBB1 VA: 0x4FAB0
	// RVA: 0x1C31A40 Offset: 0x1C31B41 VA: 0x1C31A40
	public void set_randomSeed(uint value) { }

	[NativeNameAttribute] // RVA: 0x4FAF0 Offset: 0x4FBF1 VA: 0x4FAF0
	// RVA: 0x1C31A90 Offset: 0x1C31B91 VA: 0x1C31A90
	public bool get_useAutoRandomSeed() { }

	[NativeNameAttribute] // RVA: 0x4FB30 Offset: 0x4FC31 VA: 0x4FB30
	// RVA: 0x1C31AE0 Offset: 0x1C31BE1 VA: 0x1C31AE0
	public void set_useAutoRandomSeed(bool value) { }

	// RVA: 0x1C31770 Offset: 0x1C31871 VA: 0x1C31770
	public bool get_proceduralSimulationSupported() { }

	[FreeFunctionAttribute] // RVA: 0x4FB70 Offset: 0x4FC71 VA: 0x4FB70
	// RVA: 0x1C31B30 Offset: 0x1C31C31 VA: 0x1C31B30
	internal float GetParticleCurrentSize(ref ParticleSystem.Particle particle) { }

	[FreeFunctionAttribute] // RVA: 0x4FBC0 Offset: 0x4FCC1 VA: 0x4FBC0
	// RVA: 0x1C31B80 Offset: 0x1C31C81 VA: 0x1C31B80
	internal Vector3 GetParticleCurrentSize3D(ref ParticleSystem.Particle particle) { }

	[FreeFunctionAttribute] // RVA: 0x4FC10 Offset: 0x4FD11 VA: 0x4FC10
	// RVA: 0x1C31C50 Offset: 0x1C31D51 VA: 0x1C31C50
	internal Color32 GetParticleCurrentColor(ref ParticleSystem.Particle particle) { }

	[FreeFunctionAttribute] // RVA: 0x4FC60 Offset: 0x4FD61 VA: 0x4FC60
	// RVA: 0x1C31D10 Offset: 0x1C31E11 VA: 0x1C31D10
	internal int GetParticleMeshIndex(ref ParticleSystem.Particle particle) { }

	[FreeFunctionAttribute] // RVA: 0x4FCB0 Offset: 0x4FDB1 VA: 0x4FCB0
	// RVA: 0x1C31D60 Offset: 0x1C31E61 VA: 0x1C31D60
	public void SetParticles([Out] ParticleSystem.Particle[] particles, int size, int offset) { }

	// RVA: 0x1C31DD0 Offset: 0x1C31ED1 VA: 0x1C31DD0
	public void SetParticles([Out] ParticleSystem.Particle[] particles, int size) { }

	// RVA: 0x1C31E30 Offset: 0x1C31F31 VA: 0x1C31E30
	public void SetParticles([Out] ParticleSystem.Particle[] particles) { }

	[FreeFunctionAttribute] // RVA: 0x4FD00 Offset: 0x4FE01 VA: 0x4FD00
	// RVA: 0x1C31E90 Offset: 0x1C31F91 VA: 0x1C31E90
	private void SetParticlesWithNativeArray(IntPtr particles, int particlesLength, int size, int offset) { }

	// RVA: 0x1C31F00 Offset: 0x1C32001 VA: 0x1C31F00
	public void SetParticles([Out] NativeArray<ParticleSystem.Particle> particles, int size, int offset) { }

	// RVA: 0x1C31FB0 Offset: 0x1C320B1 VA: 0x1C31FB0
	public void SetParticles([Out] NativeArray<ParticleSystem.Particle> particles, int size) { }

	// RVA: 0x1C32060 Offset: 0x1C32161 VA: 0x1C32060
	public void SetParticles([Out] NativeArray<ParticleSystem.Particle> particles) { }

	[FreeFunctionAttribute] // RVA: 0x4FD50 Offset: 0x4FE51 VA: 0x4FD50
	// RVA: 0x1C32110 Offset: 0x1C32211 VA: 0x1C32110
	public int GetParticles([Out] ParticleSystem.Particle[] particles, int size, int offset) { }

	// RVA: 0x1C32180 Offset: 0x1C32281 VA: 0x1C32180
	public int GetParticles([Out] ParticleSystem.Particle[] particles, int size) { }

	// RVA: 0x1C321E0 Offset: 0x1C322E1 VA: 0x1C321E0
	public int GetParticles([Out] ParticleSystem.Particle[] particles) { }

	[FreeFunctionAttribute] // RVA: 0x4FDA0 Offset: 0x4FEA1 VA: 0x4FDA0
	// RVA: 0x1C32240 Offset: 0x1C32341 VA: 0x1C32240
	private int GetParticlesWithNativeArray(IntPtr particles, int particlesLength, int size, int offset) { }

	// RVA: 0x1C322B0 Offset: 0x1C323B1 VA: 0x1C322B0
	public int GetParticles([Out] NativeArray<ParticleSystem.Particle> particles, int size, int offset) { }

	// RVA: 0x1C32360 Offset: 0x1C32461 VA: 0x1C32360
	public int GetParticles([Out] NativeArray<ParticleSystem.Particle> particles, int size) { }

	// RVA: 0x1C32410 Offset: 0x1C32511 VA: 0x1C32410
	public int GetParticles([Out] NativeArray<ParticleSystem.Particle> particles) { }

	[FreeFunctionAttribute] // RVA: 0x4FDF0 Offset: 0x4FEF1 VA: 0x4FDF0
	// RVA: 0x1C324C0 Offset: 0x1C325C1 VA: 0x1C324C0
	public void SetCustomParticleData(List<Vector4> customData, ParticleSystemCustomData streamIndex) { }

	[FreeFunctionAttribute] // RVA: 0x4FE40 Offset: 0x4FF41 VA: 0x4FE40
	// RVA: 0x1C32520 Offset: 0x1C32621 VA: 0x1C32520
	public int GetCustomParticleData(List<Vector4> customData, ParticleSystemCustomData streamIndex) { }

	// RVA: 0x1C32580 Offset: 0x1C32681 VA: 0x1C32580
	public ParticleSystem.PlaybackState GetPlaybackState() { }

	// RVA: 0x1C32650 Offset: 0x1C32751 VA: 0x1C32650
	public void SetPlaybackState(ParticleSystem.PlaybackState playbackState) { }

	[FreeFunctionAttribute] // RVA: 0x4FE90 Offset: 0x4FF91 VA: 0x4FE90
	// RVA: 0x1C326F0 Offset: 0x1C327F1 VA: 0x1C326F0
	private void GetTrailDataInternal(ref ParticleSystem.Trails trailData) { }

	// RVA: 0x1C32740 Offset: 0x1C32841 VA: 0x1C32740
	public ParticleSystem.Trails GetTrails() { }

	[FreeFunctionAttribute] // RVA: 0x4FEE0 Offset: 0x4FFE1 VA: 0x4FEE0
	// RVA: 0x1C328F0 Offset: 0x1C329F1 VA: 0x1C328F0
	public void SetTrails(ParticleSystem.Trails trailData) { }

	[FreeFunctionAttribute] // RVA: 0x4FF30 Offset: 0x50031 VA: 0x4FF30
	// RVA: 0x1C32990 Offset: 0x1C32A91 VA: 0x1C32990
	public void Simulate(float t, bool withChildren, bool restart, bool fixedTimeStep) { }

	// RVA: 0x1C32A10 Offset: 0x1C32B11 VA: 0x1C32A10
	public void Simulate(float t, bool withChildren, bool restart) { }

	// RVA: 0x1C32A80 Offset: 0x1C32B81 VA: 0x1C32A80
	public void Simulate(float t, bool withChildren) { }

	// RVA: 0x1C32AF0 Offset: 0x1C32BF1 VA: 0x1C32AF0
	public void Simulate(float t) { }

	[FreeFunctionAttribute] // RVA: 0x4FF80 Offset: 0x50081 VA: 0x4FF80
	// RVA: 0x1C32B50 Offset: 0x1C32C51 VA: 0x1C32B50
	public void Play(bool withChildren) { }

	// RVA: 0x1C32BA0 Offset: 0x1C32CA1 VA: 0x1C32BA0
	public void Play() { }

	[FreeFunctionAttribute] // RVA: 0x4FFD0 Offset: 0x500D1 VA: 0x4FFD0
	// RVA: 0x1C32BF0 Offset: 0x1C32CF1 VA: 0x1C32BF0
	public void Pause(bool withChildren) { }

	// RVA: 0x1C32C40 Offset: 0x1C32D41 VA: 0x1C32C40
	public void Pause() { }

	[FreeFunctionAttribute] // RVA: 0x50020 Offset: 0x50121 VA: 0x50020
	// RVA: 0x1C32C90 Offset: 0x1C32D91 VA: 0x1C32C90
	public void Stop(bool withChildren, ParticleSystemStopBehavior stopBehavior) { }

	// RVA: 0x1C32CF0 Offset: 0x1C32DF1 VA: 0x1C32CF0
	public void Stop(bool withChildren) { }

	// RVA: 0x1C32D50 Offset: 0x1C32E51 VA: 0x1C32D50
	public void Stop() { }

	[FreeFunctionAttribute] // RVA: 0x50070 Offset: 0x50171 VA: 0x50070
	// RVA: 0x1C32DA0 Offset: 0x1C32EA1 VA: 0x1C32DA0
	public void Clear(bool withChildren) { }

	// RVA: 0x1C32DF0 Offset: 0x1C32EF1 VA: 0x1C32DF0
	public void Clear() { }

	[FreeFunctionAttribute] // RVA: 0x500C0 Offset: 0x501C1 VA: 0x500C0
	// RVA: 0x1C32E40 Offset: 0x1C32F41 VA: 0x1C32E40
	public bool IsAlive(bool withChildren) { }

	// RVA: 0x1C32E90 Offset: 0x1C32F91 VA: 0x1C32E90
	public bool IsAlive() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x50110 Offset: 0x50211 VA: 0x50110
	// RVA: 0x1C32EE0 Offset: 0x1C32FE1 VA: 0x1C32EE0
	public void Emit(int count) { }

	[NativeNameAttribute] // RVA: 0x50120 Offset: 0x50221 VA: 0x50120
	// RVA: 0x1C32F30 Offset: 0x1C33031 VA: 0x1C32F30
	private void Emit_Internal(int count) { }

	[NativeNameAttribute] // RVA: 0x50160 Offset: 0x50261 VA: 0x50160
	// RVA: 0x1C32F80 Offset: 0x1C33081 VA: 0x1C32F80
	public void Emit(ParticleSystem.EmitParams emitParams, int count) { }

	[NativeNameAttribute] // RVA: 0x501A0 Offset: 0x502A1 VA: 0x501A0
	// RVA: 0x1C2F990 Offset: 0x1C2FA91 VA: 0x1C2F990
	private void EmitOld_Internal(ref ParticleSystem.Particle particle) { }

	// RVA: 0x1C33040 Offset: 0x1C33141 VA: 0x1C33040
	public void TriggerSubEmitter(int subEmitterIndex) { }

	// RVA: 0x1C33100 Offset: 0x1C33201 VA: 0x1C33100
	public void TriggerSubEmitter(int subEmitterIndex, ref ParticleSystem.Particle particle) { }

	[FreeFunctionAttribute] // RVA: 0x501E0 Offset: 0x502E1 VA: 0x501E0
	// RVA: 0x1C33180 Offset: 0x1C33281 VA: 0x1C33180
	internal void TriggerSubEmitterForParticle(int subEmitterIndex, ParticleSystem.Particle particle) { }

	[FreeFunctionAttribute] // RVA: 0x50230 Offset: 0x50331 VA: 0x50230
	// RVA: 0x1C330A0 Offset: 0x1C331A1 VA: 0x1C330A0
	public void TriggerSubEmitter(int subEmitterIndex, List<ParticleSystem.Particle> particles) { }

	[FreeFunctionAttribute] // RVA: 0x50280 Offset: 0x50381 VA: 0x50280
	// RVA: 0x1C33240 Offset: 0x1C33341 VA: 0x1C33240
	public static void ResetPreMappedBufferMemory() { }

	[FreeFunctionAttribute] // RVA: 0x502D0 Offset: 0x503D1 VA: 0x502D0
	// RVA: 0x1C33280 Offset: 0x1C33381 VA: 0x1C33280
	public static void SetMaximumPreMappedBufferCounts(int vertexBuffersCount, int indexBuffersCount) { }

	[NativeNameAttribute] // RVA: 0x50320 Offset: 0x50421 VA: 0x50320
	// RVA: 0x1C332D0 Offset: 0x1C333D1 VA: 0x1C332D0
	public void AllocateAxisOfRotationAttribute() { }

	[NativeNameAttribute] // RVA: 0x50360 Offset: 0x50461 VA: 0x50360
	// RVA: 0x1C33320 Offset: 0x1C33421 VA: 0x1C33320
	public void AllocateMeshIndexAttribute() { }

	[NativeNameAttribute] // RVA: 0x503A0 Offset: 0x504A1 VA: 0x503A0
	// RVA: 0x1C33370 Offset: 0x1C33471 VA: 0x1C33370
	public void AllocateCustomDataAttribute(ParticleSystemCustomData stream) { }

	// RVA: 0x1C333C0 Offset: 0x1C334C1 VA: 0x1C333C0
	internal void* GetManagedJobData() { }

	// RVA: 0x1C33410 Offset: 0x1C33511 VA: 0x1C33410
	internal JobHandle GetManagedJobHandle() { }

	// RVA: 0x1C334C0 Offset: 0x1C335C1 VA: 0x1C334C0
	internal void SetManagedJobHandle(JobHandle handle) { }

	[FreeFunctionAttribute] // RVA: 0x503E0 Offset: 0x504E1 VA: 0x503E0
	// RVA: 0x1C33570 Offset: 0x1C33671 VA: 0x1C33570
	internal static JobHandle ScheduleManagedJob(ref JobsUtility.JobScheduleParameters parameters, void* additionalData) { }

	[ThreadSafeAttribute] // RVA: 0x50430 Offset: 0x50531 VA: 0x50430
	// RVA: 0x1C33640 Offset: 0x1C33741 VA: 0x1C33640
	internal static void CopyManagedJobData(void* systemPtr, out NativeParticleData particleData) { }

	// RVA: 0x1C2FA90 Offset: 0x1C2FB91 VA: 0x1C2FA90
	public ParticleSystem.MainModule get_main() { }

	// RVA: 0x1C30130 Offset: 0x1C30231 VA: 0x1C30130
	public ParticleSystem.EmissionModule get_emission() { }

	// RVA: 0x1C336B0 Offset: 0x1C337B1 VA: 0x1C336B0
	public ParticleSystem.ShapeModule get_shape() { }

	// RVA: 0x1C336F0 Offset: 0x1C337F1 VA: 0x1C336F0
	public ParticleSystem.VelocityOverLifetimeModule get_velocityOverLifetime() { }

	// RVA: 0x1C33730 Offset: 0x1C33831 VA: 0x1C33730
	public ParticleSystem.LimitVelocityOverLifetimeModule get_limitVelocityOverLifetime() { }

	// RVA: 0x1C33770 Offset: 0x1C33871 VA: 0x1C33770
	public ParticleSystem.InheritVelocityModule get_inheritVelocity() { }

	// RVA: 0x1C337B0 Offset: 0x1C338B1 VA: 0x1C337B0
	public ParticleSystem.LifetimeByEmitterSpeedModule get_lifetimeByEmitterSpeed() { }

	// RVA: 0x1C337F0 Offset: 0x1C338F1 VA: 0x1C337F0
	public ParticleSystem.ForceOverLifetimeModule get_forceOverLifetime() { }

	// RVA: 0x1C33830 Offset: 0x1C33931 VA: 0x1C33830
	public ParticleSystem.ColorOverLifetimeModule get_colorOverLifetime() { }

	// RVA: 0x1C33870 Offset: 0x1C33971 VA: 0x1C33870
	public ParticleSystem.ColorBySpeedModule get_colorBySpeed() { }

	// RVA: 0x1C338B0 Offset: 0x1C339B1 VA: 0x1C338B0
	public ParticleSystem.SizeOverLifetimeModule get_sizeOverLifetime() { }

	// RVA: 0x1C338F0 Offset: 0x1C339F1 VA: 0x1C338F0
	public ParticleSystem.SizeBySpeedModule get_sizeBySpeed() { }

	// RVA: 0x1C33930 Offset: 0x1C33A31 VA: 0x1C33930
	public ParticleSystem.RotationOverLifetimeModule get_rotationOverLifetime() { }

	// RVA: 0x1C33970 Offset: 0x1C33A71 VA: 0x1C33970
	public ParticleSystem.RotationBySpeedModule get_rotationBySpeed() { }

	// RVA: 0x1C339B0 Offset: 0x1C33AB1 VA: 0x1C339B0
	public ParticleSystem.ExternalForcesModule get_externalForces() { }

	// RVA: 0x1C339F0 Offset: 0x1C33AF1 VA: 0x1C339F0
	public ParticleSystem.NoiseModule get_noise() { }

	// RVA: 0x1C33A30 Offset: 0x1C33B31 VA: 0x1C33A30
	public ParticleSystem.CollisionModule get_collision() { }

	// RVA: 0x1C33A70 Offset: 0x1C33B71 VA: 0x1C33A70
	public ParticleSystem.TriggerModule get_trigger() { }

	// RVA: 0x1C33AB0 Offset: 0x1C33BB1 VA: 0x1C33AB0
	public ParticleSystem.SubEmittersModule get_subEmitters() { }

	// RVA: 0x1C33AF0 Offset: 0x1C33BF1 VA: 0x1C33AF0
	public ParticleSystem.TextureSheetAnimationModule get_textureSheetAnimation() { }

	// RVA: 0x1C33B30 Offset: 0x1C33C31 VA: 0x1C33B30
	public ParticleSystem.LightsModule get_lights() { }

	// RVA: 0x1C33B70 Offset: 0x1C33C71 VA: 0x1C33B70
	public ParticleSystem.TrailModule get_trails() { }

	// RVA: 0x1C33BB0 Offset: 0x1C33CB1 VA: 0x1C33BB0
	public ParticleSystem.CustomDataModule get_customData() { }

	// RVA: 0x1C33BF0 Offset: 0x1C33CF1 VA: 0x1C33BF0
	public void .ctor() { }

	// RVA: 0x1C31BF0 Offset: 0x1C31CF1 VA: 0x1C31BF0
	private void GetParticleCurrentSize3D_Injected(ref ParticleSystem.Particle particle, out Vector3 ret) { }

	// RVA: 0x1C31CB0 Offset: 0x1C31DB1 VA: 0x1C31CB0
	private void GetParticleCurrentColor_Injected(ref ParticleSystem.Particle particle, out Color32 ret) { }

	// RVA: 0x1C32600 Offset: 0x1C32701 VA: 0x1C32600
	private void GetPlaybackState_Injected(out ParticleSystem.PlaybackState ret) { }

	// RVA: 0x1C326A0 Offset: 0x1C327A1 VA: 0x1C326A0
	private void SetPlaybackState_Injected(ref ParticleSystem.PlaybackState playbackState) { }

	// RVA: 0x1C32940 Offset: 0x1C32A41 VA: 0x1C32940
	private void SetTrails_Injected(ref ParticleSystem.Trails trailData) { }

	// RVA: 0x1C32FE0 Offset: 0x1C330E1 VA: 0x1C32FE0
	private void Emit_Injected(ref ParticleSystem.EmitParams emitParams, int count) { }

	// RVA: 0x1C331E0 Offset: 0x1C332E1 VA: 0x1C331E0
	private void TriggerSubEmitterForParticle_Injected(int subEmitterIndex, ref ParticleSystem.Particle particle) { }

	// RVA: 0x1C33470 Offset: 0x1C33571 VA: 0x1C33470
	private void GetManagedJobHandle_Injected(out JobHandle ret) { }

	// RVA: 0x1C33520 Offset: 0x1C33621 VA: 0x1C33520
	private void SetManagedJobHandle_Injected(ref JobHandle handle) { }

	// RVA: 0x1C335E0 Offset: 0x1C336E1 VA: 0x1C335E0
	private static void ScheduleManagedJob_Injected(ref JobsUtility.JobScheduleParameters parameters, void* additionalData, out JobHandle ret) { }
}

