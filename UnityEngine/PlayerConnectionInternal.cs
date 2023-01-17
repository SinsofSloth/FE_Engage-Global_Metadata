// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x43DE60 Offset: 0x43DF61 VA: 0x43DE60
internal class PlayerConnectionInternal : IPlayerEditorConnectionNative // TypeDefIndex: 3550
{
	// Methods

	// RVA: 0x3496230 Offset: 0x3496331 VA: 0x3496230 Slot: 6
	private void UnityEngine.IPlayerEditorConnectionNative.SendMessage(Guid messageId, byte[] data, int playerId) { }

	// RVA: 0x34963E0 Offset: 0x34964E1 VA: 0x34963E0 Slot: 7
	private bool UnityEngine.IPlayerEditorConnectionNative.TrySendMessage(Guid messageId, byte[] data, int playerId) { }

	// RVA: 0x3496590 Offset: 0x3496691 VA: 0x3496590 Slot: 8
	private void UnityEngine.IPlayerEditorConnectionNative.Poll() { }

	// RVA: 0x3496610 Offset: 0x3496711 VA: 0x3496610 Slot: 9
	private void UnityEngine.IPlayerEditorConnectionNative.RegisterInternal(Guid messageId) { }

	// RVA: 0x34966F0 Offset: 0x34967F1 VA: 0x34966F0 Slot: 10
	private void UnityEngine.IPlayerEditorConnectionNative.UnregisterInternal(Guid messageId) { }

	// RVA: 0x34967D0 Offset: 0x34968D1 VA: 0x34967D0 Slot: 4
	private void UnityEngine.IPlayerEditorConnectionNative.Initialize() { }

	// RVA: 0x3496850 Offset: 0x3496951 VA: 0x3496850 Slot: 11
	private bool UnityEngine.IPlayerEditorConnectionNative.IsConnected() { }

	// RVA: 0x34968D0 Offset: 0x34969D1 VA: 0x34968D0 Slot: 5
	private void UnityEngine.IPlayerEditorConnectionNative.DisconnectAll() { }

	[FreeFunctionAttribute] // RVA: 0x44E8E0 Offset: 0x44E9E1 VA: 0x44E8E0
	// RVA: 0x3496890 Offset: 0x3496991 VA: 0x3496890
	private static bool IsConnected() { }

	[FreeFunctionAttribute] // RVA: 0x44E920 Offset: 0x44EA21 VA: 0x44E920
	// RVA: 0x3496810 Offset: 0x3496911 VA: 0x3496810
	private static void Initialize() { }

	[FreeFunctionAttribute] // RVA: 0x44E960 Offset: 0x44EA61 VA: 0x44E960
	// RVA: 0x34966A0 Offset: 0x34967A1 VA: 0x34966A0
	private static void RegisterInternal(string messageId) { }

	[FreeFunctionAttribute] // RVA: 0x44E9A0 Offset: 0x44EAA1 VA: 0x44E9A0
	// RVA: 0x3496780 Offset: 0x3496881 VA: 0x3496780
	private static void UnregisterInternal(string messageId) { }

	[FreeFunctionAttribute] // RVA: 0x44E9E0 Offset: 0x44EAE1 VA: 0x44E9E0
	// RVA: 0x3496380 Offset: 0x3496481 VA: 0x3496380
	private static void SendMessage(string messageId, byte[] data, int playerId) { }

	[FreeFunctionAttribute] // RVA: 0x44EA20 Offset: 0x44EB21 VA: 0x44EA20
	// RVA: 0x3496530 Offset: 0x3496631 VA: 0x3496530
	private static bool TrySendMessage(string messageId, byte[] data, int playerId) { }

	[FreeFunctionAttribute] // RVA: 0x44EA60 Offset: 0x44EB61 VA: 0x44EA60
	// RVA: 0x34965D0 Offset: 0x34966D1 VA: 0x34965D0
	private static void PollInternal() { }

	[FreeFunctionAttribute] // RVA: 0x44EAA0 Offset: 0x44EBA1 VA: 0x44EAA0
	// RVA: 0x3496910 Offset: 0x3496A11 VA: 0x3496910
	private static void DisconnectAll() { }

	// RVA: 0x34947B0 Offset: 0x34948B1 VA: 0x34947B0
	public void .ctor() { }
}

