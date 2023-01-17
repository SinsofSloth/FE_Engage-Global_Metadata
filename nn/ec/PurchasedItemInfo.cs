// Namespace: nn.ec
public struct PurchasedItemInfo // TypeDefIndex: 14769
{
	// Fields
	public PurchasedItemInfo.Type type; // 0x0
	public NetworkServiceAccountId nsaId; // 0x8
	internal CourseId _courseId; // 0x10

	// Methods

	// RVA: 0x2EF12D0 Offset: 0x2EF13D1 VA: 0x2EF12D0
	public CourseId GetCourseId() { }

	// RVA: 0x2EF1370 Offset: 0x2EF1471 VA: 0x2EF1370
	private static extern CourseId GetCourseId(PurchasedItemInfo info) { }
}

