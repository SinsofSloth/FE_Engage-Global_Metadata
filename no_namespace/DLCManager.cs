// Namespace: 
public enum DLCManager.Content // TypeDefIndex: 13824
{
	// Fields
	public int value__; // 0x0
	public const DLCManager.Content E0 = 0;
	public const DLCManager.Content H0 = 1;
	public const DLCManager.Content Num = 2;
}

// Namespace: 
private class DLCManager.MountData // TypeDefIndex: 13825
{
	// Fields
	public DLCManager.Content content; // 0x10
	public byte[] mountBuffer; // 0x18
	public string mountName; // 0x20

	// Methods

	// RVA: 0x1E0DD10 Offset: 0x1E0DE11 VA: 0x1E0DD10
	public void .ctor() { }
}

// Namespace: 
private class DLCManager.DLCList // TypeDefIndex: 13826
{
	// Fields
	public DLCManager.Content content; // 0x10
	public bool hasContent; // 0x14

	// Methods

	// RVA: 0x1E0DD00 Offset: 0x1E0DE01 VA: 0x1E0DD00
	public void .ctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2792C0 Offset: 0x2793C1 VA: 0x2792C0
private sealed class DLCManager.<>c__DisplayClass14_0 // TypeDefIndex: 13827
{
	// Fields
	public DLCManager.Content content; // 0x10

	// Methods

	// RVA: 0x1E0DCD0 Offset: 0x1E0DDD1 VA: 0x1E0DCD0
	public void .ctor() { }

	// RVA: 0x1E0DCE0 Offset: 0x1E0DDE1 VA: 0x1E0DCE0
	internal bool <MountDLC>b__0(DLCManager.MountData x) { }
}

