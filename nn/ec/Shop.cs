// Namespace: nn.ec
public static class Shop // TypeDefIndex: 14771
{
	// Methods

	// RVA: 0x232F5F0 Offset: 0x232F6F1 VA: 0x232F5F0
	public static extern void ShowApplicationInformation(ulong applicationId) { }

	// RVA: 0x232F600 Offset: 0x232F701 VA: 0x232F600
	public static extern void ShowApplicationInformation(ulong applicationId, UserHandle selectedUser) { }

	// RVA: 0x232F630 Offset: 0x232F731 VA: 0x232F630
	public static extern void ShowAddOnContentList(ulong applicationId) { }

	// RVA: 0x232F640 Offset: 0x232F741 VA: 0x232F640
	public static extern void ShowAddOnContentList(ulong applicationId, UserHandle selectedUser) { }

	// RVA: 0x232F670 Offset: 0x232F771 VA: 0x232F670
	public static extern void ShowSubscriptionList(ulong applicationId) { }

	// RVA: 0x232F680 Offset: 0x232F781 VA: 0x232F680
	public static extern void ShowSubscriptionList(ulong applicationId, UserHandle selectedUser) { }

	// RVA: 0x232F6B0 Offset: 0x232F7B1 VA: 0x232F6B0
	public static extern void ShowSubscriptionList(ulong applicationId, CourseId courseId) { }

	// RVA: 0x232F710 Offset: 0x232F811 VA: 0x232F710
	public static extern void ShowSubscriptionList(ulong applicationId, CourseId courseId, UserHandle selectedUser) { }

	// RVA: 0x232F790 Offset: 0x232F891 VA: 0x232F790
	public static extern void ShowConsumableItemList(ulong applicationId) { }

	// RVA: 0x232F7A0 Offset: 0x232F8A1 VA: 0x232F7A0
	public static extern void ShowConsumableItemList(ulong applicationId, UserHandle selectedUser) { }

	// RVA: 0x232F7D0 Offset: 0x232F8D1 VA: 0x232F7D0
	public static extern void ShowConsumableItemDetail(ulong applicationId, ConsumableId consumableId, NsUid nsUid) { }

	// RVA: 0x232F840 Offset: 0x232F941 VA: 0x232F840
	public static extern void ShowConsumableItemDetail(ulong applicationId, ConsumableId consumableId, NsUid nsUid, UserHandle selectedUser) { }

	// RVA: 0x232F8D0 Offset: 0x232F9D1 VA: 0x232F8D0
	public static extern void ShowEnterCodeScene() { }

	// RVA: 0x232F8E0 Offset: 0x232F9E1 VA: 0x232F8E0
	public static extern void ShowEnterCodeScene(UserHandle selectedUser) { }

	// RVA: 0x232F910 Offset: 0x232FA11 VA: 0x232F910
	public static extern void ShowShopProductDetails(NsUid nsuid) { }

	// RVA: 0x232F920 Offset: 0x232FA21 VA: 0x232F920
	public static extern void ShowShopProductDetails(NsUid nsuid, UserHandle selectedUser) { }

	// RVA: 0x232F950 Offset: 0x232FA51 VA: 0x232F950
	public static void ShowShopProductList(NsUid[] nsuidList, string listName) { }

	// RVA: 0x232F9A0 Offset: 0x232FAA1 VA: 0x232F9A0
	private static extern void ShowShopProductList(NsUid[] nsuidList, int nsuidCount, string listName) { }

	// RVA: 0x232F9F0 Offset: 0x232FAF1 VA: 0x232F9F0
	public static void ShowShopProductList(NsUid[] nsuidList, string listName, UserHandle selectedUser) { }

	// RVA: 0x232FA70 Offset: 0x232FB71 VA: 0x232FA70
	private static extern void ShowShopProductList(NsUid[] nsuidList, int nsuidCount, string listName, UserHandle selectedUser) { }

	// RVA: 0x232FAF0 Offset: 0x232FBF1 VA: 0x232FAF0
	public static extern NsUid MakeNsUid(string str) { }
}

