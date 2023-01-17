// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x43EF00 Offset: 0x43F001 VA: 0x43EF00
[StaticAccessorAttribute] // RVA: 0x43EF00 Offset: 0x43F001 VA: 0x43EF00
public class Time // TypeDefIndex: 3638
{
	// Properties
	[NativePropertyAttribute] // RVA: 0x45A390 Offset: 0x45A491 VA: 0x45A390
	public static float time { get; }
	[NativePropertyAttribute] // RVA: 0x45A3D0 Offset: 0x45A4D1 VA: 0x45A3D0
	public static double timeAsDouble { get; }
	[NativePropertyAttribute] // RVA: 0x45A410 Offset: 0x45A511 VA: 0x45A410
	public static float timeSinceLevelLoad { get; }
	public static float deltaTime { get; }
	public static float fixedTime { get; }
	public static float unscaledTime { get; }
	public static float unscaledDeltaTime { get; }
	public static float fixedDeltaTime { get; set; }
	public static float maximumDeltaTime { get; set; }
	public static float smoothDeltaTime { get; }
	public static float maximumParticleDeltaTime { set; }
	public static float timeScale { get; set; }
	public static int frameCount { get; }
	[NativePropertyAttribute] // RVA: 0x45A450 Offset: 0x45A551 VA: 0x45A450
	public static float realtimeSinceStartup { get; }
	[NativePropertyAttribute] // RVA: 0x45A490 Offset: 0x45A591 VA: 0x45A490
	public static double realtimeSinceStartupAsDouble { get; }

	// Methods

	// RVA: 0x3845D80 Offset: 0x3845E81 VA: 0x3845D80
	public static float get_time() { }

	// RVA: 0x3845DC0 Offset: 0x3845EC1 VA: 0x3845DC0
	public static double get_timeAsDouble() { }

	// RVA: 0x3845E00 Offset: 0x3845F01 VA: 0x3845E00
	public static float get_timeSinceLevelLoad() { }

	// RVA: 0x3845E40 Offset: 0x3845F41 VA: 0x3845E40
	public static float get_deltaTime() { }

	// RVA: 0x3845E80 Offset: 0x3845F81 VA: 0x3845E80
	public static float get_fixedTime() { }

	// RVA: 0x3845EC0 Offset: 0x3845FC1 VA: 0x3845EC0
	public static float get_unscaledTime() { }

	// RVA: 0x3845F00 Offset: 0x3846001 VA: 0x3845F00
	public static float get_unscaledDeltaTime() { }

	// RVA: 0x3845F40 Offset: 0x3846041 VA: 0x3845F40
	public static float get_fixedDeltaTime() { }

	// RVA: 0x3845F80 Offset: 0x3846081 VA: 0x3845F80
	public static void set_fixedDeltaTime(float value) { }

	// RVA: 0x3845FD0 Offset: 0x38460D1 VA: 0x3845FD0
	public static float get_maximumDeltaTime() { }

	// RVA: 0x3846010 Offset: 0x3846111 VA: 0x3846010
	public static void set_maximumDeltaTime(float value) { }

	// RVA: 0x3846060 Offset: 0x3846161 VA: 0x3846060
	public static float get_smoothDeltaTime() { }

	// RVA: 0x38460A0 Offset: 0x38461A1 VA: 0x38460A0
	public static void set_maximumParticleDeltaTime(float value) { }

	// RVA: 0x38460F0 Offset: 0x38461F1 VA: 0x38460F0
	public static float get_timeScale() { }

	// RVA: 0x3846130 Offset: 0x3846231 VA: 0x3846130
	public static void set_timeScale(float value) { }

	// RVA: 0x3846180 Offset: 0x3846281 VA: 0x3846180
	public static int get_frameCount() { }

	// RVA: 0x38461C0 Offset: 0x38462C1 VA: 0x38461C0
	public static float get_realtimeSinceStartup() { }

	// RVA: 0x3846200 Offset: 0x3846301 VA: 0x3846200
	public static double get_realtimeSinceStartupAsDouble() { }
}

