// Namespace: App
public class SoundWwise // TypeDefIndex: 13822
{
	// Fields
	public static string WwiseGlobalObjectName; // 0x0
	public static string AudioListenerObjectName; // 0x8
	private static GameObject s_WwiseGlobalObject; // 0x10
	private static GameObject s_audioListenerObject; // 0x18

	// Methods

	// RVA: 0x2916EF0 Offset: 0x2916FF1 VA: 0x2916EF0
	public static void Init(GameObject WwiseGlobalObject) { }

	// RVA: 0x2916FB0 Offset: 0x29170B1 VA: 0x2916FB0
	public static GameObject GetWwiseGlobalObject() { }

	// RVA: 0x29170B0 Offset: 0x29171B1 VA: 0x29170B0
	public static GameObject GetAudioListenerObject() { }

	// RVA: 0x2917220 Offset: 0x2917321 VA: 0x2917220
	public static void SetLanguage(Language.Voices language) { }

	// RVA: 0x29172F0 Offset: 0x29173F1 VA: 0x29172F0
	public static AKRESULT PrepareEvent(string eventName) { }

	// RVA: 0x29173D0 Offset: 0x29174D1 VA: 0x29173D0
	public static AKRESULT PrepareEvent(string[] eventNameArray) { }

	// RVA: 0x29175E0 Offset: 0x29176E1 VA: 0x29175E0
	public static AKRESULT PrepareEventAsync(string eventName, out SoundSystem.ResultSoundLoad resultSoundLoad) { }

	// RVA: 0x29176C0 Offset: 0x29177C1 VA: 0x29176C0
	public static AKRESULT PrepareEventAsync(string[] eventNameArray, out SoundSystem.ResultSoundLoad resultSoundLoad) { }

	// RVA: 0x2917480 Offset: 0x2917581 VA: 0x2917480
	private static string[] CalcPrepareEventNameArray(string[] eventNameArray) { }

	// RVA: 0x2917830 Offset: 0x2917931 VA: 0x2917830
	public static void UnprepareEvent(string eventName) { }

	// RVA: 0x2917910 Offset: 0x2917A11 VA: 0x2917910
	public static void UnprepareEvent(string[] eventNameArray) { }

	// RVA: 0x2917B30 Offset: 0x2917C31 VA: 0x2917B30
	public static void ClearPrepareEvent(string[] eventNameArray) { }

	// RVA: 0x29179D0 Offset: 0x2917AD1 VA: 0x29179D0
	private static string[] CalcUnprepareEventNameArray(string[] eventNameArray) { }

	// RVA: 0x2917BB0 Offset: 0x2917CB1 VA: 0x2917BB0
	public static AKRESULT PrepareSwitch(string switchGroupName, string switchName) { }

	// RVA: 0x2917CE0 Offset: 0x2917DE1 VA: 0x2917CE0
	public static AKRESULT PrepareSwitch(string switchGroupName, string[] switchNameArray) { }

	// RVA: 0x2917E30 Offset: 0x2917F31 VA: 0x2917E30
	public static AKRESULT PrepareSwitchAsync(string switchGroupName, string switchName, out SoundSystem.ResultSoundLoad resultSoundLoad) { }

	// RVA: 0x2917F70 Offset: 0x2918071 VA: 0x2917F70
	public static AKRESULT PrepareSwitchAsync(string switchGroupName, string[] switchNameArray, out SoundSystem.ResultSoundLoad resultSoundLoad) { }

	// RVA: 0x2917D60 Offset: 0x2917E61 VA: 0x2917D60
	private static AKRESULT PrepareGameSync(AkGroupType groupType, string gameSyncGroupName, string[] gameSyncNameArray) { }

	// RVA: 0x2918000 Offset: 0x2918101 VA: 0x2918000
	private static AKRESULT PrepareGameSyncAsync(AkGroupType groupType, string gameSyncGroupName, string[] gameSyncNameArray, out SoundSystem.ResultSoundLoad resultSoundLoad) { }

	// RVA: 0x2918190 Offset: 0x2918291 VA: 0x2918190
	private static string[] CalcPrepareGameSyncNameArray(AkGroupType groupType, string gameSyncGroupName, string[] gameSyncNameArray) { }

	// RVA: 0x2918300 Offset: 0x2918401 VA: 0x2918300
	public static void UnprepareSwitch(string switchGroupName, string switchName) { }

	// RVA: 0x2918440 Offset: 0x2918541 VA: 0x2918440
	public static void UnprepareSwitch(string switchGroupName, string[] switchNameArray) { }

	// RVA: 0x2918630 Offset: 0x2918731 VA: 0x2918630
	public static void ClearPrepareSwitch(string switchGroupName, string[] switchNameArray) { }

	// RVA: 0x2918790 Offset: 0x2918891 VA: 0x2918790
	private static void UnprepareGameSync(AkGroupType groupType, string gameSyncGroupName, string[] gameSyncNameArray) { }

	// RVA: 0x29184C0 Offset: 0x29185C1 VA: 0x29184C0
	private static string[] CalcUnprepareGameSyncNameArray(AkGroupType groupType, string gameSyncGroupName, string[] gameSyncNameArray) { }

	// RVA: 0x29186F0 Offset: 0x29187F1 VA: 0x29186F0
	private static void ClearPrepareGameSync(AkGroupType groupType, string gameSyncGroupName, string[] gameSyncNameArray) { }

	// RVA: 0x2918860 Offset: 0x2918961 VA: 0x2918860
	public static void ClearPrepare() { }

	// RVA: 0x2918900 Offset: 0x2918A01 VA: 0x2918900
	public static bool IsEventLoaded(string eventName) { }

	// RVA: 0x29189C0 Offset: 0x2918AC1 VA: 0x29189C0
	public static uint PostEvent(string eventName, GameObject gameObject) { }

	// RVA: 0x2918A40 Offset: 0x2918B41 VA: 0x2918A40
	public static uint PostEvent(string eventName, GameObject gameObject, uint flag, AkCallbackManager.EventCallback callback, object cookie) { }

	// RVA: 0x2918AE0 Offset: 0x2918BE1 VA: 0x2918AE0
	public static AKRESULT ExecuteActionOnEvent(string eventName, AkActionOnEventType eventType, int msec, AkCurveInterpolation interpolation, GameObject gameObject, uint playingId) { }

	// RVA: 0x2918B90 Offset: 0x2918C91 VA: 0x2918B90
	public static void StopSoundOnEvent(string eventName, int msec, GameObject gameObject, uint playingId) { }

	// RVA: 0x2918C70 Offset: 0x2918D71 VA: 0x2918C70
	public static void PauseSoundOnEvent(string eventName, int msec, GameObject gameObject, uint playingId) { }

	// RVA: 0x2918D50 Offset: 0x2918E51 VA: 0x2918D50
	public static void ResumeSoundOnEvent(string eventName, int msec, GameObject gameObject, uint playingId) { }

	// RVA: 0x2918E30 Offset: 0x2918F31 VA: 0x2918E30
	public static void SetVolume(float vol, GameObject gameObject) { }

	// RVA: 0x2918F60 Offset: 0x2919061 VA: 0x2918F60
	public static void StopByPlayingID(uint playingId, int msec) { }

	// RVA: 0x2918FE0 Offset: 0x29190E1 VA: 0x2918FE0
	public static bool GetState(string stateGroupName, out uint value) { }

	// RVA: 0x2919080 Offset: 0x2919181 VA: 0x2919080
	public static bool GetSwitch(string switchGroupName, GameObject gameObjectId, out uint value) { }

	// RVA: 0x2919130 Offset: 0x2919231 VA: 0x2919130
	public static bool GetGameParameter(string paramName, out float value) { }

	// RVA: 0x29191F0 Offset: 0x29192F1 VA: 0x29191F0
	public static bool GetGameParameter(string paramName, GameObject gameObjectId, out float value) { }

	// RVA: 0x29192B0 Offset: 0x29193B1 VA: 0x29192B0
	public static bool SetState(string stateGroupName, string stateName) { }

	// RVA: 0x2919370 Offset: 0x2919471 VA: 0x2919370
	public static bool SetState(string stateGroupName, uint stateValue) { }

	// RVA: 0x2919420 Offset: 0x2919521 VA: 0x2919420
	public static bool SetSwitch(string switchGroupName, string switchName, GameObject gameObjectId) { }

	// RVA: 0x29194E0 Offset: 0x29195E1 VA: 0x29194E0
	public static bool SetSwitch(string switchGroupName, uint switchValue, GameObject gameObjectId) { }

	// RVA: 0x29195A0 Offset: 0x29196A1 VA: 0x29195A0
	public static bool SetGameParameter(string paramName, float value, int msec) { }

	// RVA: 0x2919650 Offset: 0x2919751 VA: 0x2919650
	public static bool SetGameParameter(string paramName, float value, GameObject gameObjectId, int msec) { }

	// RVA: 0x2919700 Offset: 0x2919801 VA: 0x2919700
	public static bool ResetGameParameter(string paramName, int msec) { }

	// RVA: 0x29197B0 Offset: 0x29198B1 VA: 0x29197B0
	public static bool ResetGameParameter(string paramName, GameObject gameObjectId, int msec) { }

	// RVA: 0x2919860 Offset: 0x2919961 VA: 0x2919860
	public static int GetPlayPosition(uint playingId, int positionOffset) { }

	// RVA: 0x2919940 Offset: 0x2919A41 VA: 0x2919940
	public static bool SetPosition(GameObject gameObject, Vector3 pos, Vector3 forward, Vector3 up) { }

	// RVA: 0x2919A80 Offset: 0x2919B81 VA: 0x2919A80
	public static Vector3 GetAudioListenerPosistion() { }

	// RVA: 0x2919B60 Offset: 0x2919C61 VA: 0x2919B60
	public static Quaternion GetAudioListenerRotation() { }

	// RVA: 0x2919C40 Offset: 0x2919D41 VA: 0x2919C40
	public static void SetAudioListenerPosistion(Vector3 listenerPos) { }

	// RVA: 0x2919D40 Offset: 0x2919E41 VA: 0x2919D40
	public static void SetAudioListenerRotation(Quaternion listenerRot) { }

	// RVA: 0x2919E40 Offset: 0x2919F41 VA: 0x2919E40
	public void .ctor() { }

	// RVA: 0x2919E50 Offset: 0x2919F51 VA: 0x2919E50
	private static void .cctor() { }
}

