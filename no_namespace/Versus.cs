// Namespace: 
public enum Versus.Mode // TypeDefIndex: 13748
{
	// Fields
	public int value__; // 0x0
	public const Versus.Mode None = 0;
	public const Versus.Mode Edit = 1;
	public const Versus.Mode Casual = 2;
	public const Versus.Mode Ranked = 3;
	public const Versus.Mode Replay = 4;
	public const Versus.Mode MockBattle = 5;
}

// Namespace: 
public enum Versus.MapResult // TypeDefIndex: 13750
{
	// Fields
	public int value__; // 0x0
	public const Versus.MapResult Win = 0;
	public const Versus.MapResult Lose = 1;
	public const Versus.MapResult None = 2;
	public const Versus.MapResult Abort = 3;
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x279280 Offset: 0x279381 VA: 0x279280
private sealed class Versus.VersusCheck.<>c__DisplayClass4_0 // TypeDefIndex: 13752
{
	// Fields
	public bool isValid; // 0x10

	// Methods

	// RVA: 0x2D6B550 Offset: 0x2D6B651 VA: 0x2D6B550
	public void .ctor() { }

	// RVA: 0x2D6B560 Offset: 0x2D6B661 VA: 0x2D6B560
	internal void <ValidateUnits>b__0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2792A0 Offset: 0x2793A1 VA: 0x2792A0
private sealed class Versus.VersusCheck.<>c__DisplayClass14_0 // TypeDefIndex: 13754
{
	// Fields
	public List<string> idList; // 0x10
	public bool isValid; // 0x18

	// Methods

	// RVA: 0x2D6B3D0 Offset: 0x2D6B4D1 VA: 0x2D6B3D0
	public void .ctor() { }

	// RVA: 0x2D6B3E0 Offset: 0x2D6B4E1 VA: 0x2D6B3E0
	internal void <ValidateForce>b__0(Unit unit) { }
}

// Namespace: 
private class Versus.MapObjectCounter // TypeDefIndex: 13756
{
	// Fields
	private Dictionary<MapEditorCategoryData, int> m_Dict; // 0x10

	// Methods

	// RVA: 0x1EE0980 Offset: 0x1EE0A81 VA: 0x1EE0980
	public void .ctor() { }

	// RVA: 0x1EE0A10 Offset: 0x1EE0B11 VA: 0x1EE0A10
	public void Add(string objName) { }

	// RVA: 0x1EE0B60 Offset: 0x1EE0C61 VA: 0x1EE0B60
	public Dictionary.Enumerator<MapEditorCategoryData, int> GetEnumerator() { }
}

// Namespace: 
private class Versus.DownloadHistory.CheckData // TypeDefIndex: 13758
{
	// Fields
	public bool m_IsDownloaded; // 0x10
	public long m_DataTime; // 0x18

	// Methods

	// RVA: 0x2D6B220 Offset: 0x2D6B321 VA: 0x2D6B220
	public void Reset() { }

	// RVA: 0x2D6B230 Offset: 0x2D6B331 VA: 0x2D6B230
	public bool IsDownloaded() { }

	// RVA: 0x2D6B330 Offset: 0x2D6B431 VA: 0x2D6B330
	public long GetElapsedTime() { }

	// RVA: 0x2D6B3C0 Offset: 0x2D6B4C1 VA: 0x2D6B3C0
	public void .ctor() { }
}

