// Namespace: UnityEngine.Experimental.GlobalIllumination
public static class LightmapperUtils // TypeDefIndex: 4017
{
	// Methods

	// RVA: 0x2F2AB30 Offset: 0x2F2AC31 VA: 0x2F2AB30
	public static LightMode Extract(LightmapBakeType baketype) { }

	// RVA: 0x2F2AB50 Offset: 0x2F2AC51 VA: 0x2F2AB50
	public static LinearColor ExtractIndirect(Light l) { }

	// RVA: 0x2F2AF90 Offset: 0x2F2B091 VA: 0x2F2AF90
	public static float ExtractInnerCone(Light l) { }

	// RVA: 0x2F2B010 Offset: 0x2F2B111 VA: 0x2F2B010
	private static Color ExtractColorTemperature(Light l) { }

	// RVA: 0x2F2B030 Offset: 0x2F2B131 VA: 0x2F2B030
	private static void ApplyColorTemperature(Color cct, ref LinearColor lightColor) { }

	// RVA: 0x2F2B300 Offset: 0x2F2B401 VA: 0x2F2B300
	public static void Extract(Light l, ref DirectionalLight dir) { }

	// RVA: 0x2F2B550 Offset: 0x2F2B651 VA: 0x2F2B550
	public static void Extract(Light l, ref PointLight point) { }

	// RVA: 0x2F2B7A0 Offset: 0x2F2B8A1 VA: 0x2F2B7A0
	public static void Extract(Light l, ref SpotLight spot) { }

	// RVA: 0x2F2BAD0 Offset: 0x2F2BBD1 VA: 0x2F2BAD0
	public static void Extract(Light l, ref RectangleLight rect) { }

	// RVA: 0x2F2BD60 Offset: 0x2F2BE61 VA: 0x2F2BD60
	public static void Extract(Light l, ref DiscLight disc) { }

	// RVA: 0x2F2BFF0 Offset: 0x2F2C0F1 VA: 0x2F2BFF0
	public static void Extract(Light l, out Cookie cookie) { }
}

