// Namespace: nn.account
public static class Account // TypeDefIndex: 14779
{
	// Fields
	public const int UserCountMax = 8;
	public const int ProfileImageBytesMax = 131072;
	public const int SaveDataThumbnailImageBytesMax = 147456;

	// Properties
	public static ErrorRange ResultCancelled { get; }
	public static ErrorRange ResultCancelledByUser { get; }
	public static ErrorRange ResultUserNotExist { get; }

	// Methods

	// RVA: 0x2B240D0 Offset: 0x2B241D1 VA: 0x2B240D0
	public static extern Result GetUserCount(ref int pOutCount) { }

	// RVA: 0x2B240F0 Offset: 0x2B241F1 VA: 0x2B240F0
	public static extern Result GetUserExistence(ref bool pOutExistence, Uid user) { }

	// RVA: 0x2B24110 Offset: 0x2B24211 VA: 0x2B24110
	public static Result ListAllUsers(ref int pOutActualLength, Uid[] outUsers) { }

	// RVA: 0x2B241E0 Offset: 0x2B242E1 VA: 0x2B241E0
	private static extern Result ListAllUsers(ref int pOutActualLength, [Out] Uid[] outUsers, int arrayLength) { }

	// RVA: 0x2B242B0 Offset: 0x2B243B1 VA: 0x2B242B0
	public static Result ListOpenUsers(ref int pOutActualLength, Uid[] outUsers) { }

	// RVA: 0x2B24380 Offset: 0x2B24481 VA: 0x2B24380
	private static extern Result ListOpenUsers(ref int pOutActualLength, [Out] Uid[] outUsers, int arrayLength) { }

	// RVA: 0x2B24450 Offset: 0x2B24551 VA: 0x2B24450
	public static extern Result GetLastOpenedUser(ref Uid pOutUser) { }

	// RVA: 0x2B23DC0 Offset: 0x2B23EC1 VA: 0x2B23DC0
	public static extern Result GetNickname(ref Nickname pOut, Uid user) { }

	// RVA: 0x2B24470 Offset: 0x2B24571 VA: 0x2B24470
	public static Result LoadProfileImage(ref long pOutActualSize, byte[] outImage, Uid user) { }

	// RVA: 0x2B244A0 Offset: 0x2B245A1 VA: 0x2B244A0
	private static extern Result LoadProfileImage(ref long pOutActualSize, byte[] outImage, long bufferSize, Uid user) { }

	// RVA: 0x2B23A70 Offset: 0x2B23B71 VA: 0x2B23A70
	public static extern void Initialize() { }

	// RVA: 0x2B23A80 Offset: 0x2B23B81 VA: 0x2B23A80
	public static extern bool TryOpenPreselectedUser(ref UserHandle pOutHandle) { }

	// RVA: 0x2B244D0 Offset: 0x2B245D1 VA: 0x2B244D0
	public static extern Result ListQualifiedUsers(ref int pOutActualLength, Uid[] outUsers, int arrayLength) { }

	// RVA: 0x2B24500 Offset: 0x2B24601 VA: 0x2B24500
	public static extern void CloseUser(UserHandle handle) { }

	// RVA: 0x2B23AA0 Offset: 0x2B23BA1 VA: 0x2B23AA0
	public static extern Result GetUserId(ref Uid pOut, UserHandle handle) { }

	// RVA: 0x2B24530 Offset: 0x2B24631 VA: 0x2B24530
	public static Result StoreSaveDataThumbnailImage(Uid user, byte[] imageBuffer) { }

	// RVA: 0x2B24560 Offset: 0x2B24661 VA: 0x2B24560
	private static extern Result StoreSaveDataThumbnailImage(Uid user, byte[] imageBuffer, long imageBufferSize) { }

	// RVA: 0x2B24590 Offset: 0x2B24691 VA: 0x2B24590
	public static extern Result DeleteSaveDataThumbnailImage(Uid user) { }

	// RVA: 0x2B245B0 Offset: 0x2B246B1 VA: 0x2B245B0
	public static ErrorRange get_ResultCancelled() { }

	// RVA: 0x2B245F0 Offset: 0x2B246F1 VA: 0x2B245F0
	public static ErrorRange get_ResultCancelledByUser() { }

	// RVA: 0x2B24630 Offset: 0x2B24731 VA: 0x2B24630
	public static ErrorRange get_ResultUserNotExist() { }

	// RVA: 0x2B24670 Offset: 0x2B24771 VA: 0x2B24670
	public static extern Result ShowUserSelector(ref Uid pOut, UserSelectionSettings arg) { }

	// RVA: 0x2B246B0 Offset: 0x2B247B1 VA: 0x2B246B0
	public static extern Result ShowUserSelector(ref Uid pOut) { }

	// RVA: 0x2B246D0 Offset: 0x2B247D1 VA: 0x2B246D0
	public static extern Result ShowUserCreator() { }

	// RVA: 0x2B246F0 Offset: 0x2B247F1 VA: 0x2B246F0
	public static Result ShowUserSelector(ref Uid pOut, UserSelectionSettings arg, bool suspendUnityThreads) { }

	// RVA: 0x2B24780 Offset: 0x2B24881 VA: 0x2B24780
	public static Result ShowUserSelector(ref Uid pOut, bool suspendUnityThreads) { }

	// RVA: 0x2B247E0 Offset: 0x2B248E1 VA: 0x2B247E0
	public static Result ShowUserCreator(bool suspendUnityThreads) { }
}

