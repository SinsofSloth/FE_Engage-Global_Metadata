// Namespace: UnityEngine.Rendering
public static class ColorUtils // TypeDefIndex: 4621
{
	// Fields
	public static float s_LightMeterCalibrationConstant; // 0x0
	public static float s_LensAttenuation; // 0x4

	// Properties
	public static float lensImperfectionExposureScale { get; }

	// Methods

	// RVA: 0x1B2BC30 Offset: 0x1B2BD31 VA: 0x1B2BC30
	public static float get_lensImperfectionExposureScale() { }

	// RVA: 0x1B2BCB0 Offset: 0x1B2BDB1 VA: 0x1B2BCB0
	public static float StandardIlluminantY(float x) { }

	// RVA: 0x1B2BCF0 Offset: 0x1B2BDF1 VA: 0x1B2BCF0
	public static Vector3 CIExyToLMS(float x, float y) { }

	// RVA: 0x1B2BDB0 Offset: 0x1B2BEB1 VA: 0x1B2BDB0
	public static Vector3 ColorBalanceToLMSCoeffs(float temperature, float tint) { }

	// RVA: 0x1B2BF80 Offset: 0x1B2C081 VA: 0x1B2BF80
	public static ValueTuple<Vector4, Vector4, Vector4> PrepareShadowsMidtonesHighlights(in Vector4 inShadows, in Vector4 inMidtones, in Vector4 inHighlights) { }

	// RVA: 0x1B2C1F0 Offset: 0x1B2C2F1 VA: 0x1B2C1F0
	public static ValueTuple<Vector4, Vector4, Vector4> PrepareLiftGammaGain(in Vector4 inLift, in Vector4 inGamma, in Vector4 inGain) { }

	// RVA: 0x1B2C570 Offset: 0x1B2C671 VA: 0x1B2C570
	public static ValueTuple<Vector4, Vector4> PrepareSplitToning(in Vector4 inShadows, in Vector4 inHighlights, float balance) { }

	// RVA: 0x1B2C520 Offset: 0x1B2C621 VA: 0x1B2C520
	public static float Luminance(in Color color) { }

	// RVA: 0x1B2C610 Offset: 0x1B2C711 VA: 0x1B2C610
	public static float ComputeEV100(float aperture, float shutterSpeed, float ISO) { }

	// RVA: 0x1B2C640 Offset: 0x1B2C741 VA: 0x1B2C640
	public static float ConvertEV100ToExposure(float EV100) { }

	// RVA: 0x1B2C730 Offset: 0x1B2C831 VA: 0x1B2C730
	public static float ConvertExposureToEV100(float exposure) { }

	// RVA: 0x1B2C820 Offset: 0x1B2C921 VA: 0x1B2C820
	public static float ComputeEV100FromAvgLuminance(float avgLuminance) { }

	// RVA: 0x1B2C8B0 Offset: 0x1B2C9B1 VA: 0x1B2C8B0
	public static float ComputeISO(float aperture, float shutterSpeed, float targetEV100) { }

	// RVA: 0x1B2C8F0 Offset: 0x1B2C9F1 VA: 0x1B2C8F0
	public static uint ToHex(Color c) { }

	// RVA: 0x1B2C960 Offset: 0x1B2CA61 VA: 0x1B2C960
	public static Color ToRGBA(uint hex) { }

	// RVA: 0x1B2C9E0 Offset: 0x1B2CAE1 VA: 0x1B2C9E0
	private static void .cctor() { }
}

