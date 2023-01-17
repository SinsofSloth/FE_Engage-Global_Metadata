// Namespace: 
private enum UnitInfoViewerSetting.Seq // TypeDefIndex: 9078
{
	// Fields
	public int value__; // 0x0
	public const UnitInfoViewerSetting.Seq WaitHidingCanvas = 0;
	public const UnitInfoViewerSetting.Seq WaitReshowingCanvas = 1;
	public const UnitInfoViewerSetting.Seq Normal = 2;
}

// Namespace: 
[Serializable]
public class UnitInfoViewerSetting.UnitData // TypeDefIndex: 9079
{
	// Fields
	public string person; // 0x10
	public string job; // 0x18
	public string weapon; // 0x20
	public string force; // 0x28

	// Methods

	// RVA: 0x1ED2FE0 Offset: 0x1ED30E1 VA: 0x1ED2FE0
	public void .ctor() { }
}

// Namespace: 
public static class UnitInfoViewerSetting.ForceList // TypeDefIndex: 9080
{
	// Fields
	public static readonly Force.Type[] Types; // 0x0
	public static readonly string[] Names; // 0x8

	// Methods

	// RVA: 0x1ED2B60 Offset: 0x1ED2C61 VA: 0x1ED2B60
	public static int GetIndex(string name) { }

	// RVA: 0x1ED2C00 Offset: 0x1ED2D01 VA: 0x1ED2C00
	public static Force.Type GetForceType(string name) { }

	// RVA: 0x1ED2D00 Offset: 0x1ED2E01 VA: 0x1ED2D00
	public static string GetName(Force.Type forceType) { }

	// RVA: 0x1ED2DE0 Offset: 0x1ED2EE1 VA: 0x1ED2DE0
	private static void .cctor() { }
}

