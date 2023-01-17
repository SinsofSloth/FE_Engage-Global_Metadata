// Namespace: nn.ngc
public static class ProfanityFilterForPlatformRegionChina // TypeDefIndex: 14544
{
	// Methods

	// RVA: 0x29E6B20 Offset: 0x29E6C21 VA: 0x29E6B20
	public static extern Result CheckProfanityWords(ref bool pOutCheckResult, [In] string pText) { }

	// RVA: 0x29E6B70 Offset: 0x29E6C71 VA: 0x29E6B70
	public static extern Result CheckProfanityWords(ref bool pOutCheckResult, [In] StringBuilder pText) { }

	// RVA: 0x29E6BC0 Offset: 0x29E6CC1 VA: 0x29E6BC0
	public static extern Result MaskProfanityWords([In] [Out] StringBuilder pOutText) { }
}

