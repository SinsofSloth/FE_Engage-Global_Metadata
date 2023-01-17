// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x43CA60 Offset: 0x43CB61 VA: 0x43CA60
[NativeHeaderAttribute] // RVA: 0x43CA60 Offset: 0x43CB61 VA: 0x43CA60
[NativeHeaderAttribute] // RVA: 0x43CA60 Offset: 0x43CB61 VA: 0x43CA60
[StaticAccessorAttribute] // RVA: 0x43CA60 Offset: 0x43CB61 VA: 0x43CA60
public sealed class RenderSettings : Object // TypeDefIndex: 3458
{
	// Properties
	[ObsoleteAttribute] // RVA: 0x4598E0 Offset: 0x4599E1 VA: 0x4598E0
	public static float ambientSkyboxAmount { get; set; }
	[NativePropertyAttribute] // RVA: 0x459920 Offset: 0x459A21 VA: 0x459920
	public static bool fog { get; set; }
	[NativePropertyAttribute] // RVA: 0x459960 Offset: 0x459A61 VA: 0x459960
	public static float fogStartDistance { get; set; }
	[NativePropertyAttribute] // RVA: 0x4599A0 Offset: 0x459AA1 VA: 0x4599A0
	public static float fogEndDistance { get; set; }
	public static FogMode fogMode { get; set; }
	public static Color fogColor { get; set; }
	public static float fogDensity { get; set; }
	public static AmbientMode ambientMode { get; set; }
	public static Color ambientSkyColor { get; set; }
	public static Color ambientEquatorColor { get; set; }
	public static Color ambientGroundColor { get; set; }
	public static float ambientIntensity { get; set; }
	[NativePropertyAttribute] // RVA: 0x4599E0 Offset: 0x459AE1 VA: 0x4599E0
	public static Color ambientLight { get; set; }
	public static Color subtractiveShadowColor { get; set; }
	[NativePropertyAttribute] // RVA: 0x459A20 Offset: 0x459B21 VA: 0x459A20
	public static Material skybox { get; set; }
	public static Light sun { get; set; }
	public static SphericalHarmonicsL2 ambientProbe { get; set; }
	public static Cubemap customReflection { get; set; }
	public static float reflectionIntensity { get; set; }
	public static int reflectionBounces { get; set; }
	public static DefaultReflectionMode defaultReflectionMode { get; set; }
	public static int defaultReflectionResolution { get; set; }
	public static float haloStrength { get; set; }
	public static float flareStrength { get; set; }
	public static float flareFadeSpeed { get; set; }

	// Methods

	// RVA: 0x31D9EB0 Offset: 0x31D9FB1 VA: 0x31D9EB0
	public static float get_ambientSkyboxAmount() { }

	// RVA: 0x31D9F30 Offset: 0x31DA031 VA: 0x31D9F30
	public static void set_ambientSkyboxAmount(float value) { }

	// RVA: 0x31D9FD0 Offset: 0x31DA0D1 VA: 0x31D9FD0
	private void .ctor() { }

	// RVA: 0x31DA040 Offset: 0x31DA141 VA: 0x31DA040
	public static bool get_fog() { }

	// RVA: 0x31DA080 Offset: 0x31DA181 VA: 0x31DA080
	public static void set_fog(bool value) { }

	// RVA: 0x31DA0D0 Offset: 0x31DA1D1 VA: 0x31DA0D0
	public static float get_fogStartDistance() { }

	// RVA: 0x31DA110 Offset: 0x31DA211 VA: 0x31DA110
	public static void set_fogStartDistance(float value) { }

	// RVA: 0x31DA160 Offset: 0x31DA261 VA: 0x31DA160
	public static float get_fogEndDistance() { }

	// RVA: 0x31DA1A0 Offset: 0x31DA2A1 VA: 0x31DA1A0
	public static void set_fogEndDistance(float value) { }

	// RVA: 0x31DA1F0 Offset: 0x31DA2F1 VA: 0x31DA1F0
	public static FogMode get_fogMode() { }

	// RVA: 0x31DA230 Offset: 0x31DA331 VA: 0x31DA230
	public static void set_fogMode(FogMode value) { }

	// RVA: 0x31DA280 Offset: 0x31DA381 VA: 0x31DA280
	public static Color get_fogColor() { }

	// RVA: 0x31DA330 Offset: 0x31DA431 VA: 0x31DA330
	public static void set_fogColor(Color value) { }

	// RVA: 0x31DA3D0 Offset: 0x31DA4D1 VA: 0x31DA3D0
	public static float get_fogDensity() { }

	// RVA: 0x31DA410 Offset: 0x31DA511 VA: 0x31DA410
	public static void set_fogDensity(float value) { }

	// RVA: 0x31DA460 Offset: 0x31DA561 VA: 0x31DA460
	public static AmbientMode get_ambientMode() { }

	// RVA: 0x31DA4A0 Offset: 0x31DA5A1 VA: 0x31DA4A0
	public static void set_ambientMode(AmbientMode value) { }

	// RVA: 0x31DA4F0 Offset: 0x31DA5F1 VA: 0x31DA4F0
	public static Color get_ambientSkyColor() { }

	// RVA: 0x31DA5A0 Offset: 0x31DA6A1 VA: 0x31DA5A0
	public static void set_ambientSkyColor(Color value) { }

	// RVA: 0x31DA640 Offset: 0x31DA741 VA: 0x31DA640
	public static Color get_ambientEquatorColor() { }

	// RVA: 0x31DA6F0 Offset: 0x31DA7F1 VA: 0x31DA6F0
	public static void set_ambientEquatorColor(Color value) { }

	// RVA: 0x31DA790 Offset: 0x31DA891 VA: 0x31DA790
	public static Color get_ambientGroundColor() { }

	// RVA: 0x31DA840 Offset: 0x31DA941 VA: 0x31DA840
	public static void set_ambientGroundColor(Color value) { }

	// RVA: 0x31D9EF0 Offset: 0x31D9FF1 VA: 0x31D9EF0
	public static float get_ambientIntensity() { }

	// RVA: 0x31D9F80 Offset: 0x31DA081 VA: 0x31D9F80
	public static void set_ambientIntensity(float value) { }

	// RVA: 0x31DA8E0 Offset: 0x31DA9E1 VA: 0x31DA8E0
	public static Color get_ambientLight() { }

	// RVA: 0x31DA990 Offset: 0x31DAA91 VA: 0x31DA990
	public static void set_ambientLight(Color value) { }

	// RVA: 0x31DAA30 Offset: 0x31DAB31 VA: 0x31DAA30
	public static Color get_subtractiveShadowColor() { }

	// RVA: 0x31DAAE0 Offset: 0x31DABE1 VA: 0x31DAAE0
	public static void set_subtractiveShadowColor(Color value) { }

	// RVA: 0x31DAB80 Offset: 0x31DAC81 VA: 0x31DAB80
	public static Material get_skybox() { }

	// RVA: 0x31DABC0 Offset: 0x31DACC1 VA: 0x31DABC0
	public static void set_skybox(Material value) { }

	// RVA: 0x31DAC10 Offset: 0x31DAD11 VA: 0x31DAC10
	public static Light get_sun() { }

	// RVA: 0x31DAC50 Offset: 0x31DAD51 VA: 0x31DAC50
	public static void set_sun(Light value) { }

	[NativeMethodAttribute] // RVA: 0x4485E0 Offset: 0x4486E1 VA: 0x4485E0
	// RVA: 0x31DACA0 Offset: 0x31DADA1 VA: 0x31DACA0
	public static SphericalHarmonicsL2 get_ambientProbe() { }

	// RVA: 0x31DADA0 Offset: 0x31DAEA1 VA: 0x31DADA0
	public static void set_ambientProbe(SphericalHarmonicsL2 value) { }

	// RVA: 0x31DAE40 Offset: 0x31DAF41 VA: 0x31DAE40
	public static Cubemap get_customReflection() { }

	// RVA: 0x31DAE80 Offset: 0x31DAF81 VA: 0x31DAE80
	public static void set_customReflection(Cubemap value) { }

	// RVA: 0x31DAED0 Offset: 0x31DAFD1 VA: 0x31DAED0
	public static float get_reflectionIntensity() { }

	// RVA: 0x31DAF10 Offset: 0x31DB011 VA: 0x31DAF10
	public static void set_reflectionIntensity(float value) { }

	// RVA: 0x31DAF60 Offset: 0x31DB061 VA: 0x31DAF60
	public static int get_reflectionBounces() { }

	// RVA: 0x31DAFA0 Offset: 0x31DB0A1 VA: 0x31DAFA0
	public static void set_reflectionBounces(int value) { }

	// RVA: 0x31DAFF0 Offset: 0x31DB0F1 VA: 0x31DAFF0
	public static DefaultReflectionMode get_defaultReflectionMode() { }

	// RVA: 0x31DB030 Offset: 0x31DB131 VA: 0x31DB030
	public static void set_defaultReflectionMode(DefaultReflectionMode value) { }

	// RVA: 0x31DB080 Offset: 0x31DB181 VA: 0x31DB080
	public static int get_defaultReflectionResolution() { }

	// RVA: 0x31DB0C0 Offset: 0x31DB1C1 VA: 0x31DB0C0
	public static void set_defaultReflectionResolution(int value) { }

	// RVA: 0x31DB110 Offset: 0x31DB211 VA: 0x31DB110
	public static float get_haloStrength() { }

	// RVA: 0x31DB150 Offset: 0x31DB251 VA: 0x31DB150
	public static void set_haloStrength(float value) { }

	// RVA: 0x31DB1A0 Offset: 0x31DB2A1 VA: 0x31DB1A0
	public static float get_flareStrength() { }

	// RVA: 0x31DB1E0 Offset: 0x31DB2E1 VA: 0x31DB1E0
	public static void set_flareStrength(float value) { }

	// RVA: 0x31DB230 Offset: 0x31DB331 VA: 0x31DB230
	public static float get_flareFadeSpeed() { }

	// RVA: 0x31DB270 Offset: 0x31DB371 VA: 0x31DB270
	public static void set_flareFadeSpeed(float value) { }

	[FreeFunctionAttribute] // RVA: 0x448620 Offset: 0x448721 VA: 0x448620
	// RVA: 0x31DB2C0 Offset: 0x31DB3C1 VA: 0x31DB2C0
	internal static Object GetRenderSettings() { }

	[StaticAccessorAttribute] // RVA: 0x448660 Offset: 0x448761 VA: 0x448660
	// RVA: 0x31DB300 Offset: 0x31DB401 VA: 0x31DB300
	internal static void Reset() { }

	// RVA: 0x31DA2E0 Offset: 0x31DA3E1 VA: 0x31DA2E0
	private static void get_fogColor_Injected(out Color ret) { }

	// RVA: 0x31DA380 Offset: 0x31DA481 VA: 0x31DA380
	private static void set_fogColor_Injected(ref Color value) { }

	// RVA: 0x31DA550 Offset: 0x31DA651 VA: 0x31DA550
	private static void get_ambientSkyColor_Injected(out Color ret) { }

	// RVA: 0x31DA5F0 Offset: 0x31DA6F1 VA: 0x31DA5F0
	private static void set_ambientSkyColor_Injected(ref Color value) { }

	// RVA: 0x31DA6A0 Offset: 0x31DA7A1 VA: 0x31DA6A0
	private static void get_ambientEquatorColor_Injected(out Color ret) { }

	// RVA: 0x31DA740 Offset: 0x31DA841 VA: 0x31DA740
	private static void set_ambientEquatorColor_Injected(ref Color value) { }

	// RVA: 0x31DA7F0 Offset: 0x31DA8F1 VA: 0x31DA7F0
	private static void get_ambientGroundColor_Injected(out Color ret) { }

	// RVA: 0x31DA890 Offset: 0x31DA991 VA: 0x31DA890
	private static void set_ambientGroundColor_Injected(ref Color value) { }

	// RVA: 0x31DA940 Offset: 0x31DAA41 VA: 0x31DA940
	private static void get_ambientLight_Injected(out Color ret) { }

	// RVA: 0x31DA9E0 Offset: 0x31DAAE1 VA: 0x31DA9E0
	private static void set_ambientLight_Injected(ref Color value) { }

	// RVA: 0x31DAA90 Offset: 0x31DAB91 VA: 0x31DAA90
	private static void get_subtractiveShadowColor_Injected(out Color ret) { }

	// RVA: 0x31DAB30 Offset: 0x31DAC31 VA: 0x31DAB30
	private static void set_subtractiveShadowColor_Injected(ref Color value) { }

	// RVA: 0x31DAD50 Offset: 0x31DAE51 VA: 0x31DAD50
	private static void get_ambientProbe_Injected(out SphericalHarmonicsL2 ret) { }

	// RVA: 0x31DADF0 Offset: 0x31DAEF1 VA: 0x31DADF0
	private static void set_ambientProbe_Injected(ref SphericalHarmonicsL2 value) { }
}

