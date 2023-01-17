// Namespace: 
public enum UpdateTracker.UpdateClock // TypeDefIndex: 5867
{
	// Fields
	public int value__; // 0x0
	public const UpdateTracker.UpdateClock Fixed = 0;
	public const UpdateTracker.UpdateClock Late = 1;
}

// Namespace: 
private class UpdateTracker.UpdateStatus // TypeDefIndex: 5868
{
	// Fields
	private const int kWindowSize = 30;
	private int windowStart; // 0x10
	private int numWindowLateUpdateMoves; // 0x14
	private int numWindowFixedUpdateMoves; // 0x18
	private int numWindows; // 0x1C
	private int lastFrameUpdated; // 0x20
	private Matrix4x4 lastPos; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x22240 Offset: 0x22341 VA: 0x22240
	private UpdateTracker.UpdateClock <PreferredUpdate>k__BackingField; // 0x64

	// Properties
	public UpdateTracker.UpdateClock PreferredUpdate { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x24070 Offset: 0x24171 VA: 0x24070
	// RVA: 0x1C6C510 Offset: 0x1C6C611 VA: 0x1C6C510
	public UpdateTracker.UpdateClock get_PreferredUpdate() { }

	[CompilerGeneratedAttribute] // RVA: 0x24080 Offset: 0x24181 VA: 0x24080
	// RVA: 0x1C6C520 Offset: 0x1C6C621 VA: 0x1C6C520
	private void set_PreferredUpdate(UpdateTracker.UpdateClock value) { }

	// RVA: 0x1C6C530 Offset: 0x1C6C631 VA: 0x1C6C530
	public void .ctor(int currentFrame, Matrix4x4 pos) { }

	// RVA: 0x1C6C590 Offset: 0x1C6C691 VA: 0x1C6C590
	public void OnUpdate(int currentFrame, UpdateTracker.UpdateClock currentClock, Matrix4x4 pos) { }
}

