// Namespace: nn.friends
public static class Friends // TypeDefIndex: 14748
{
	// Fields
	public const int FriendCountMax = 300;
	public const int BlockedUserCountMax = 100;
	public const long PresenceAppFieldSize = 192;
	public const int InAppScreenNameLengthMax = 20;
	public const int GetProfileCountMax = 100;
	public const long ProfileImageSizeMax = 131072;
	public const int NotificationCountMax = 100;
	public const int FriendInvitationInviteeCountMax = 16;
	public const long FriendInvitationApplicationParameterSizeMax = 1024;

	// Properties
	public static ErrorRange ResultNotInitialized { get; }
	public static ErrorRange ResultInvalidArgument { get; }
	public static ErrorRange ResultUserNotOpened { get; }
	public static ErrorRange ResultNetworkServiceAccountNotLinked { get; }
	public static ErrorRange ResultOwnNetworkServiceAccountSpecified { get; }
	public static ErrorRange ResultInternetRequestNotAccepted { get; }
	public static ErrorRange ResultNotCalled { get; }
	public static ErrorRange ResultCallInProgress { get; }
	public static ErrorRange ResultCanceled { get; }
	public static ErrorRange ResultProfileImageCacheNotFound { get; }
	public static ErrorRange ResultOutOfMemory { get; }
	public static ErrorRange ResultOutOfResource { get; }
	public static ErrorRange ResultReservedKey { get; }
	public static ErrorRange ResultDuplicatedKey { get; }
	public static ErrorRange ResultNotificationNotFound { get; }
	public static ErrorRange ResultPlayHistoryRegistrationKeyBroken { get; }
	public static ErrorRange ResultOwnPlayHistoryRegistrationKey { get; }
	public static ErrorRange ResultAppletCanceled { get; }
	public static ErrorRange ResultApplicationInfoNotRegistered { get; }
	public static ErrorRange ResultNotPermitted { get; }
	public static ErrorRange ResultInvalidOperation { get; }
	public static ErrorRange ResultNotImplemented { get; }
	public static ErrorRange ResultResponseFormatError { get; }
	public static ErrorRange ResultHttpError { get; }
	public static ErrorRange ResultServerError { get; }

	// Methods

	// RVA: 0x269E6D0 Offset: 0x269E7D1 VA: 0x269E6D0
	public static extern void Initialize() { }

	// RVA: 0x269E6E0 Offset: 0x269E7E1 VA: 0x269E6E0
	public static Result GetFriendList(ref int outCount, NetworkServiceAccountId[] outAccountIds, Uid uid, int offset, FriendFilter filter) { }

	// RVA: 0x269E710 Offset: 0x269E811 VA: 0x269E710
	private static extern Result GetFriendList(ref int outCount, [In] [Out] NetworkServiceAccountId[] outAccountIds, Uid uid, int offset, int count, FriendFilter filter) { }

	// RVA: 0x269E740 Offset: 0x269E841 VA: 0x269E740
	public static Result GetFriendList(ref int outCount, NetworkServiceAccountId[] outAccountIds, int offset, FriendFilter filter) { }

	// RVA: 0x269E770 Offset: 0x269E871 VA: 0x269E770
	private static extern Result GetFriendList(ref int outCount, [In] [Out] NetworkServiceAccountId[] outAccountIds, int offset, int count, FriendFilter filter) { }

	// RVA: 0x269E7A0 Offset: 0x269E8A1 VA: 0x269E7A0
	public static Result GetFriendList(ref int outCount, Friend[] outFriends, Uid uid, int offset, FriendFilter filter) { }

	// RVA: 0x269E7D0 Offset: 0x269E8D1 VA: 0x269E7D0
	private static extern Result GetFriendList(ref int outCount, [In] [Out] Friend[] outFriends, Uid uid, int offset, int count, FriendFilter filter) { }

	// RVA: 0x269E800 Offset: 0x269E901 VA: 0x269E800
	public static Result GetFriendList(ref int outCount, Friend[] outFriends, int offset, FriendFilter filter) { }

	// RVA: 0x269E830 Offset: 0x269E931 VA: 0x269E830
	private static extern Result GetFriendList(ref int outCount, [In] [Out] Friend[] outFriends, int offset, int count, FriendFilter filter) { }

	// RVA: 0x269E860 Offset: 0x269E961 VA: 0x269E860
	public static Result UpdateFriendInfo(Friend[] outFriends, Uid uid, NetworkServiceAccountId[] accountIds) { }

	// RVA: 0x269E8A0 Offset: 0x269E9A1 VA: 0x269E8A0
	private static extern Result UpdateFriendInfo([In] [Out] Friend[] outFriends, Uid uid, [In] NetworkServiceAccountId[] accountIds, int count) { }

	// RVA: 0x269E8D0 Offset: 0x269E9D1 VA: 0x269E8D0
	public static Result UpdateFriendInfo(Friend[] outFriends, NetworkServiceAccountId[] accountIds) { }

	// RVA: 0x269E910 Offset: 0x269EA11 VA: 0x269E910
	private static extern Result UpdateFriendInfo([In] [Out] Friend[] outFriends, NetworkServiceAccountId[] accountIds, int count) { }

	// RVA: 0x269E940 Offset: 0x269EA41 VA: 0x269E940
	public static Result EnsureFriendListAvailable(AsyncContext outAsync, Uid uid) { }

	// RVA: 0x269E980 Offset: 0x269EA81 VA: 0x269E980
	public static extern Result CheckFriendListAvailability(ref bool outIsAvailable, Uid uid) { }

	// RVA: 0x269E9A0 Offset: 0x269EAA1 VA: 0x269E9A0
	public static extern Result CheckFriendListAvailability(ref bool outIsAvailable) { }

	// RVA: 0x269E960 Offset: 0x269EA61 VA: 0x269E960
	private static extern Result EnsureFriendListAvailable(IntPtr outAsync, Uid uid) { }

	// RVA: 0x269E9C0 Offset: 0x269EAC1 VA: 0x269E9C0
	public static Result EnsureFriendListAvailable(AsyncContext outAsync) { }

	// RVA: 0x269E9E0 Offset: 0x269EAE1 VA: 0x269E9E0
	private static extern Result EnsureFriendListAvailable(IntPtr outAsync) { }

	// RVA: 0x269EA00 Offset: 0x269EB01 VA: 0x269EA00
	public static Result GetBlockedUserList(ref int outCount, NetworkServiceAccountId[] outAccountIds, Uid uid, int offset) { }

	// RVA: 0x269EA30 Offset: 0x269EB31 VA: 0x269EA30
	private static extern Result GetBlockedUserList(ref int outCount, [In] [Out] NetworkServiceAccountId[] outAccountIds, Uid uid, int offset, int count) { }

	// RVA: 0x269EA60 Offset: 0x269EB61 VA: 0x269EA60
	public static Result GetBlockedUserList(ref int outCount, NetworkServiceAccountId[] outAccountIds, int offset) { }

	// RVA: 0x269EA90 Offset: 0x269EB91 VA: 0x269EA90
	private static extern Result GetBlockedUserList(ref int outCount, [In] [Out] NetworkServiceAccountId[] outAccountIds, int offset, int count) { }

	// RVA: 0x269EAC0 Offset: 0x269EBC1 VA: 0x269EAC0
	public static Result GetProfileList(AsyncContext outAsync, Profile[] outProfiles, Uid uid, NetworkServiceAccountId[] accountIds) { }

	// RVA: 0x269EB30 Offset: 0x269EC31 VA: 0x269EB30
	public static extern Result CheckBlockedUserListAvailability(ref bool outIsAvailable, Uid uid) { }

	// RVA: 0x269EB50 Offset: 0x269EC51 VA: 0x269EB50
	public static extern Result CheckBlockedUserListAvailability(ref bool outIsAvailable) { }

	// RVA: 0x269EB70 Offset: 0x269EC71 VA: 0x269EB70
	public static Result EnsureBlockedUserListAvailable(AsyncContext outAsync, Uid uid) { }

	// RVA: 0x269EB90 Offset: 0x269EC91 VA: 0x269EB90
	private static extern Result EnsureBlockedUserListAvailable(IntPtr outAsync, Uid uid) { }

	// RVA: 0x269EBB0 Offset: 0x269ECB1 VA: 0x269EBB0
	public static Result EnsureBlockedUserListAvailable(AsyncContext outAsync) { }

	// RVA: 0x269EBD0 Offset: 0x269ECD1 VA: 0x269EBD0
	private static extern Result EnsureBlockedUserListAvailable(IntPtr outAsync) { }

	// RVA: 0x269EB00 Offset: 0x269EC01 VA: 0x269EB00
	private static extern Result GetProfileList(IntPtr outAsync, [In] [Out] Profile[] outProfiles, Uid uid, [In] NetworkServiceAccountId[] accountIds, int count) { }

	// RVA: 0x269EBF0 Offset: 0x269ECF1 VA: 0x269EBF0
	public static Result GetProfileList(AsyncContext outAsync, Profile[] outProfiles, NetworkServiceAccountId[] accountIds) { }

	// RVA: 0x269EC30 Offset: 0x269ED31 VA: 0x269EC30
	private static extern Result GetProfileList(IntPtr outAsync, [In] [Out] Profile[] outProfiles, [In] NetworkServiceAccountId[] accountIds, int count) { }

	// RVA: 0x269EC60 Offset: 0x269ED61 VA: 0x269EC60
	public static extern Result DeclareOpenOnlinePlaySession(Uid uid) { }

	// RVA: 0x269EC80 Offset: 0x269ED81 VA: 0x269EC80
	public static extern Result DeclareOpenOnlinePlaySession() { }

	// RVA: 0x269ECA0 Offset: 0x269EDA1 VA: 0x269ECA0
	public static extern Result DeclareCloseOnlinePlaySession(Uid uid) { }

	// RVA: 0x269ECC0 Offset: 0x269EDC1 VA: 0x269ECC0
	public static extern Result DeclareCloseOnlinePlaySession() { }

	// RVA: 0x269ECE0 Offset: 0x269EDE1 VA: 0x269ECE0
	public static extern Result GetPlayHistoryRegistrationKey(ref PlayHistoryRegistrationKey outKey, Uid uid, bool isLocalPlay) { }

	// RVA: 0x269ED00 Offset: 0x269EE01 VA: 0x269ED00
	public static extern Result GetPlayHistoryRegistrationKey(ref PlayHistoryRegistrationKey outKey, bool isLocalPlay) { }

	// RVA: 0x269ED20 Offset: 0x269EE21 VA: 0x269ED20
	public static extern Result AddPlayHistory(Uid uid, PlayHistoryRegistrationKey key, InAppScreenName inAppScreenName, InAppScreenName myInAppScreenName) { }

	// RVA: 0x269EE40 Offset: 0x269EF41 VA: 0x269EE40
	public static extern Result AddPlayHistory(PlayHistoryRegistrationKey key, InAppScreenName inAppScreenName, InAppScreenName myInAppScreenName) { }

	// RVA: 0x269EF50 Offset: 0x269F051 VA: 0x269EF50
	public static bool TryPopFriendInvitationNotificationInfo(ref Uid pOutUid, ref long pOutSize, byte[] pOutBuffer) { }

	// RVA: 0x269EF80 Offset: 0x269F081 VA: 0x269EF80
	private static extern bool TryPopFriendInvitationNotificationInfo(ref Uid pOutUid, ref long pOutSize, [In] [Out] byte[] pOutBuffer, long bufferSize) { }

	// RVA: 0x269EFB0 Offset: 0x269F0B1 VA: 0x269EFB0
	public static extern Result ShowFriendList(Uid uid) { }

	// RVA: 0x269EFD0 Offset: 0x269F0D1 VA: 0x269EFD0
	public static extern Result ShowUserDetailInfo(Uid uid, NetworkServiceAccountId accountId, InAppScreenName myInAppScreenName, InAppScreenName inAppScreenName) { }

	// RVA: 0x269F0D0 Offset: 0x269F1D1 VA: 0x269F0D0
	public static extern Result StartSendingFriendRequest(Uid uid, NetworkServiceAccountId accountId, InAppScreenName myInAppScreenName, InAppScreenName inAppScreenName) { }

	// RVA: 0x269F1D0 Offset: 0x269F2D1 VA: 0x269F1D0
	public static extern Result ShowMethodsOfSendingFriendRequest(Uid uid) { }

	// RVA: 0x269F1F0 Offset: 0x269F2F1 VA: 0x269F1F0
	public static extern Result StartFacedFriendRequest(Uid uid) { }

	// RVA: 0x269F210 Offset: 0x269F311 VA: 0x269F210
	public static extern Result ShowReceivedFriendRequestList(Uid uid) { }

	// RVA: 0x269F230 Offset: 0x269F331 VA: 0x269F230
	public static extern Result ShowBlockedUserList(Uid uid) { }

	// RVA: 0x269F250 Offset: 0x269F351 VA: 0x269F250
	public static Result StartFriendInvitation(Uid uid, int maxInviteeCount, FriendInvitationGameModeDescription description, byte[] pAppParameter) { }

	// RVA: 0x269F310 Offset: 0x269F411 VA: 0x269F310
	private static extern Result StartFriendInvitation(Uid uid, int maxInviteeCount, FriendInvitationGameModeDescription description, [In] byte[] pAppParameter, long appParameterSize) { }

	// RVA: 0x269F3D0 Offset: 0x269F4D1 VA: 0x269F3D0
	public static Result StartSendingFriendInvitation(Uid uid, NetworkServiceAccountId[] pInvitees, FriendInvitationGameModeDescription description, byte[] pAppParameter) { }

	// RVA: 0x269F4A0 Offset: 0x269F5A1 VA: 0x269F4A0
	private static extern Result StartSendingFriendInvitation(Uid uid, [In] NetworkServiceAccountId[] pInvitees, int inviteeCount, FriendInvitationGameModeDescription description, [In] byte[] pAppParameter, long appParameterSize) { }

	// RVA: 0x269F570 Offset: 0x269F671 VA: 0x269F570
	public static ErrorRange get_ResultNotInitialized() { }

	// RVA: 0x269F5B0 Offset: 0x269F6B1 VA: 0x269F5B0
	public static ErrorRange get_ResultInvalidArgument() { }

	// RVA: 0x269F5F0 Offset: 0x269F6F1 VA: 0x269F5F0
	public static ErrorRange get_ResultUserNotOpened() { }

	// RVA: 0x269F630 Offset: 0x269F731 VA: 0x269F630
	public static ErrorRange get_ResultNetworkServiceAccountNotLinked() { }

	// RVA: 0x269F670 Offset: 0x269F771 VA: 0x269F670
	public static ErrorRange get_ResultOwnNetworkServiceAccountSpecified() { }

	// RVA: 0x269F6B0 Offset: 0x269F7B1 VA: 0x269F6B0
	public static ErrorRange get_ResultInternetRequestNotAccepted() { }

	// RVA: 0x269F6F0 Offset: 0x269F7F1 VA: 0x269F6F0
	public static ErrorRange get_ResultNotCalled() { }

	// RVA: 0x269F730 Offset: 0x269F831 VA: 0x269F730
	public static ErrorRange get_ResultCallInProgress() { }

	// RVA: 0x269F770 Offset: 0x269F871 VA: 0x269F770
	public static ErrorRange get_ResultCanceled() { }

	// RVA: 0x269F7B0 Offset: 0x269F8B1 VA: 0x269F7B0
	public static ErrorRange get_ResultProfileImageCacheNotFound() { }

	// RVA: 0x269F7F0 Offset: 0x269F8F1 VA: 0x269F7F0
	public static ErrorRange get_ResultOutOfMemory() { }

	// RVA: 0x269F830 Offset: 0x269F931 VA: 0x269F830
	public static ErrorRange get_ResultOutOfResource() { }

	// RVA: 0x269F870 Offset: 0x269F971 VA: 0x269F870
	public static ErrorRange get_ResultReservedKey() { }

	// RVA: 0x269F8B0 Offset: 0x269F9B1 VA: 0x269F8B0
	public static ErrorRange get_ResultDuplicatedKey() { }

	// RVA: 0x269F8F0 Offset: 0x269F9F1 VA: 0x269F8F0
	public static ErrorRange get_ResultNotificationNotFound() { }

	// RVA: 0x269F930 Offset: 0x269FA31 VA: 0x269F930
	public static ErrorRange get_ResultPlayHistoryRegistrationKeyBroken() { }

	// RVA: 0x269F970 Offset: 0x269FA71 VA: 0x269F970
	public static ErrorRange get_ResultOwnPlayHistoryRegistrationKey() { }

	// RVA: 0x269F9B0 Offset: 0x269FAB1 VA: 0x269F9B0
	public static ErrorRange get_ResultAppletCanceled() { }

	// RVA: 0x269F9F0 Offset: 0x269FAF1 VA: 0x269F9F0
	public static ErrorRange get_ResultApplicationInfoNotRegistered() { }

	// RVA: 0x269FA30 Offset: 0x269FB31 VA: 0x269FA30
	public static ErrorRange get_ResultNotPermitted() { }

	// RVA: 0x269FA70 Offset: 0x269FB71 VA: 0x269FA70
	public static ErrorRange get_ResultInvalidOperation() { }

	// RVA: 0x269FAB0 Offset: 0x269FBB1 VA: 0x269FAB0
	public static ErrorRange get_ResultNotImplemented() { }

	// RVA: 0x269FAF0 Offset: 0x269FBF1 VA: 0x269FAF0
	public static ErrorRange get_ResultResponseFormatError() { }

	// RVA: 0x269FB30 Offset: 0x269FC31 VA: 0x269FB30
	public static ErrorRange get_ResultHttpError() { }

	// RVA: 0x269FB70 Offset: 0x269FC71 VA: 0x269FB70
	public static ErrorRange get_ResultServerError() { }
}

