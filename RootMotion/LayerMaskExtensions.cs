// Namespace: RootMotion
[ExtensionAttribute] // RVA: 0x2798F0 Offset: 0x2799F1 VA: 0x2798F0
public static class LayerMaskExtensions // TypeDefIndex: 14306
{
	// Methods

	// RVA: 0x1F82200 Offset: 0x1F82301 VA: 0x1F82200
	public static bool Contains(LayerMask mask, int layer) { }

	// RVA: 0x1F82260 Offset: 0x1F82361 VA: 0x1F82260
	public static LayerMask Create(string[] layerNames) { }

	// RVA: 0x1F82330 Offset: 0x1F82431 VA: 0x1F82330
	public static LayerMask Create(int[] layerNumbers) { }

	// RVA: 0x1F82280 Offset: 0x1F82381 VA: 0x1F82280
	public static LayerMask NamesToMask(string[] layerNames) { }

	// RVA: 0x1F823D0 Offset: 0x1F824D1 VA: 0x1F823D0
	public static LayerMask LayerNumbersToMask(int[] layerNumbers) { }

	[ExtensionAttribute] // RVA: 0x2CE5B0 Offset: 0x2CE6B1 VA: 0x2CE5B0
	// RVA: 0x1F82470 Offset: 0x1F82571 VA: 0x1F82470
	public static LayerMask Inverse(LayerMask original) { }

	[ExtensionAttribute] // RVA: 0x2CE5C0 Offset: 0x2CE6C1 VA: 0x2CE5C0
	// RVA: 0x1F824A0 Offset: 0x1F825A1 VA: 0x1F824A0
	public static LayerMask AddToMask(LayerMask original, string[] layerNames) { }

	[ExtensionAttribute] // RVA: 0x2CE5D0 Offset: 0x2CE6D1 VA: 0x2CE5D0
	// RVA: 0x1F824F0 Offset: 0x1F825F1 VA: 0x1F824F0
	public static LayerMask RemoveFromMask(LayerMask original, string[] layerNames) { }

	[ExtensionAttribute] // RVA: 0x2CE5E0 Offset: 0x2CE6E1 VA: 0x2CE5E0
	// RVA: 0x1F82560 Offset: 0x1F82661 VA: 0x1F82560
	public static string[] MaskToNames(LayerMask original) { }

	[ExtensionAttribute] // RVA: 0x2CE5F0 Offset: 0x2CE6F1 VA: 0x2CE5F0
	// RVA: 0x1F82670 Offset: 0x1F82771 VA: 0x1F82670
	public static int[] MaskToNumbers(LayerMask original) { }

	[ExtensionAttribute] // RVA: 0x2CE600 Offset: 0x2CE701 VA: 0x2CE600
	// RVA: 0x1F82760 Offset: 0x1F82861 VA: 0x1F82760
	public static string MaskToString(LayerMask original) { }

	[ExtensionAttribute] // RVA: 0x2CE610 Offset: 0x2CE711 VA: 0x2CE610
	// RVA: 0x1F827D0 Offset: 0x1F828D1 VA: 0x1F827D0
	public static string MaskToString(LayerMask original, string delimiter) { }
}

