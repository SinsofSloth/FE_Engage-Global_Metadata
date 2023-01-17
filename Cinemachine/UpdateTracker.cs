// Namespace: Cinemachine
[DocumentationSortingAttribute] // RVA: 0x1BA40 Offset: 0x1BB41 VA: 0x1BA40
internal class UpdateTracker // TypeDefIndex: 5869
{
	// Fields
	private static Dictionary<Transform, UpdateTracker.UpdateStatus> mUpdateStatus; // 0x0
	private static List<Transform> sToDelete; // 0x8
	private static float mLastUpdateTime; // 0x10

	// Methods

	[RuntimeInitializeOnLoadMethodAttribute] // RVA: 0x24060 Offset: 0x24161 VA: 0x24060
	// RVA: 0x1A873A0 Offset: 0x1A874A1 VA: 0x1A873A0
	private static void InitializeModule() { }

	// RVA: 0x1A87420 Offset: 0x1A87521 VA: 0x1A87420
	private static void UpdateTargets(UpdateTracker.UpdateClock currentClock) { }

	// RVA: 0x1A87740 Offset: 0x1A87841 VA: 0x1A87740
	public static UpdateTracker.UpdateClock GetPreferredUpdate(Transform target) { }

	// RVA: 0x1A87920 Offset: 0x1A87A21 VA: 0x1A87920
	public static void OnUpdate(UpdateTracker.UpdateClock currentClock) { }

	// RVA: 0x1A87A20 Offset: 0x1A87B21 VA: 0x1A87A20
	public void .ctor() { }

	// RVA: 0x1A87A30 Offset: 0x1A87B31 VA: 0x1A87A30
	private static void .cctor() { }
}

