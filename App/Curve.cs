// Namespace: App
public class Curve // TypeDefIndex: 9181
{
	// Methods

	// RVA: 0x23C1050 Offset: 0x23C1151 VA: 0x23C1050
	public static float Calc(Curve.Type type, float prev, float next, float now, float term = 1, int num = 2) { }

	// RVA: 0x23C16B0 Offset: 0x23C17B1 VA: 0x23C16B0
	public static float Lerp(float prev, float next, float now, float term = 1, int unused = 0) { }

	// RVA: 0x23C16D0 Offset: 0x23C17D1 VA: 0x23C16D0
	public static Vector3 Lerp(Vector3 prev, Vector3 next, float now, float term = 1, int unused = 0) { }

	// RVA: 0x23C1710 Offset: 0x23C1811 VA: 0x23C1710
	public static Color Lerp(Color prev, Color next, float now, float term = 1, int unused = 0) { }

	// RVA: 0x23C1760 Offset: 0x23C1861 VA: 0x23C1760
	public static float Accel(float prev, float next, float now, float term = 1, int num = 3) { }

	// RVA: 0x23C17F0 Offset: 0x23C18F1 VA: 0x23C17F0
	public static float Decel(float prev, float next, float now, float term = 1, int num = 3) { }

	// RVA: 0x23C1890 Offset: 0x23C1991 VA: 0x23C1890
	public static float AcDecel(float prev, float next, float now, float term = 1, int num = 3) { }

	// RVA: 0x23C19E0 Offset: 0x23C1AE1 VA: 0x23C19E0
	public static float DecAccel(float prev, float next, float now, float term = 1, int num = 3) { }

	// RVA: 0x23C1B30 Offset: 0x23C1C31 VA: 0x23C1B30
	public static float LerpDecel(float prev, float next, float now, float term = 1, int num = 3) { }

	// RVA: 0x23C1BF0 Offset: 0x23C1CF1 VA: 0x23C1BF0
	public static float LerpAccel(float prev, float next, float now, float term = 1, int num = 3) { }

	// RVA: 0x23C1CA0 Offset: 0x23C1DA1 VA: 0x23C1CA0
	public static float DecelLerp(float prev, float next, float now, float term = 1, int num = 3) { }

	// RVA: 0x23C1D60 Offset: 0x23C1E61 VA: 0x23C1D60
	public static float AccelLerp(float prev, float next, float now, float term = 1, int num = 3) { }

	// RVA: 0x23C1E10 Offset: 0x23C1F11 VA: 0x23C1E10
	public static float LerpSyncTime(float prev, float next, float now, float term = 1, int unused = 0) { }

	// RVA: 0x23C1ED0 Offset: 0x23C1FD1 VA: 0x23C1ED0
	public static Vector3 LerpSyncTime(Vector3 prev, Vector3 next, float now, float term = 1, int unused = 0) { }

	// RVA: 0x23C2090 Offset: 0x23C2191 VA: 0x23C2090
	public static Color LerpSyncTime(Color prev, Color next, float now, float term = 1, int unused = 0) { }

	// RVA: 0x23C22D0 Offset: 0x23C23D1 VA: 0x23C22D0
	public static Vector3 Hermite(Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3, float t) { }

	// RVA: 0x23C2370 Offset: 0x23C2471 VA: 0x23C2370
	public static Vector2 Hermite(Vector2 v0, Vector2 v1, Vector2 v2, Vector2 v3, float t) { }

	// RVA: 0x23C23F0 Offset: 0x23C24F1 VA: 0x23C23F0
	public static Vector3 CatmullRom(Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3, float t) { }

	// RVA: 0x23C24B0 Offset: 0x23C25B1 VA: 0x23C24B0
	public static Vector2 CatmullRom(Vector2 v0, Vector2 v1, Vector2 v2, Vector2 v3, float t) { }

	// RVA: 0x23C2540 Offset: 0x23C2641 VA: 0x23C2540
	public void .ctor() { }
}

