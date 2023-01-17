// Namespace: UniRx.Async
[ExtensionAttribute] // RVA: 0x28230 Offset: 0x28331 VA: 0x28230
public static class UnityAsyncExtensions // TypeDefIndex: 5147
{
	// Methods

	[ExtensionAttribute] // RVA: 0x2DE00 Offset: 0x2DF01 VA: 0x2DE00
	// RVA: 0x2E88CB0 Offset: 0x2E88DB1 VA: 0x2E88CB0
	public static IAwaiter GetAwaiter(JobHandle jobHandle) { }

	[ExtensionAttribute] // RVA: 0x2DE10 Offset: 0x2DF11 VA: 0x2DE10
	// RVA: 0x2E88ED0 Offset: 0x2E88FD1 VA: 0x2E88ED0
	public static UniTask ToUniTask(JobHandle jobHandle, CancellationToken cancellation) { }

	[ExtensionAttribute] // RVA: 0x2DE20 Offset: 0x2DF21 VA: 0x2DE20
	// RVA: 0x2E890D0 Offset: 0x2E891D1 VA: 0x2E890D0
	public static UniTask ConfigureAwait(JobHandle jobHandle, PlayerLoopTiming waitTiming, CancellationToken cancellation) { }

	[ExtensionAttribute] // RVA: 0x2DE30 Offset: 0x2DF31 VA: 0x2DE30
	// RVA: 0x2E891E0 Offset: 0x2E892E1 VA: 0x2E891E0
	public static UnityAsyncExtensions.AsyncOperationAwaiter GetAwaiter(AsyncOperation asyncOperation) { }

	[ExtensionAttribute] // RVA: 0x2DE40 Offset: 0x2DF41 VA: 0x2DE40
	// RVA: 0x2E89260 Offset: 0x2E89361 VA: 0x2E89260
	public static UniTask ToUniTask(AsyncOperation asyncOperation) { }

	[ExtensionAttribute] // RVA: 0x2DE50 Offset: 0x2DF51 VA: 0x2DE50
	// RVA: 0x2E89320 Offset: 0x2E89421 VA: 0x2E89320
	public static UniTask ConfigureAwait(AsyncOperation asyncOperation, IProgress<float> progress, PlayerLoopTiming timing = 4, CancellationToken cancellation) { }

	[ExtensionAttribute] // RVA: 0x2DE60 Offset: 0x2DF61 VA: 0x2DE60
	// RVA: 0x2E89450 Offset: 0x2E89551 VA: 0x2E89450
	public static UnityAsyncExtensions.ResourceRequestAwaiter GetAwaiter(ResourceRequest resourceRequest) { }

	[ExtensionAttribute] // RVA: 0x2DE70 Offset: 0x2DF71 VA: 0x2DE70
	// RVA: 0x2E894D0 Offset: 0x2E895D1 VA: 0x2E894D0
	public static UniTask<Object> ToUniTask(ResourceRequest resourceRequest) { }

	[ExtensionAttribute] // RVA: 0x2DE80 Offset: 0x2DF81 VA: 0x2DE80
	// RVA: 0x2E895B0 Offset: 0x2E896B1 VA: 0x2E895B0
	public static UniTask<Object> ConfigureAwait(ResourceRequest resourceRequest, IProgress<float> progress, PlayerLoopTiming timing = 4, CancellationToken cancellation) { }

	[ExtensionAttribute] // RVA: 0x2DE90 Offset: 0x2DF91 VA: 0x2DE90
	// RVA: 0x2E89700 Offset: 0x2E89801 VA: 0x2E89700
	public static IAwaiter GetAwaiter(WWW www) { }

	[ExtensionAttribute] // RVA: 0x2DEA0 Offset: 0x2DFA1 VA: 0x2DEA0
	// RVA: 0x2E89840 Offset: 0x2E89941 VA: 0x2E89840
	public static UniTask ToUniTask(WWW www) { }

	[ExtensionAttribute] // RVA: 0x2DEB0 Offset: 0x2DFB1 VA: 0x2DEB0
	// RVA: 0x2E89990 Offset: 0x2E89A91 VA: 0x2E89990
	public static UniTask ConfigureAwait(WWW www, IProgress<float> progress, PlayerLoopTiming timing = 4, CancellationToken cancellation) { }

	[ExtensionAttribute] // RVA: 0x2DEC0 Offset: 0x2DFC1 VA: 0x2DEC0
	// RVA: 0x2E89AC0 Offset: 0x2E89BC1 VA: 0x2E89AC0
	public static UnityAsyncExtensions.UnityWebRequestAsyncOperationAwaiter GetAwaiter(UnityWebRequestAsyncOperation asyncOperation) { }

	[ExtensionAttribute] // RVA: 0x2DED0 Offset: 0x2DFD1 VA: 0x2DED0
	// RVA: 0x2E89B40 Offset: 0x2E89C41 VA: 0x2E89B40
	public static UniTask<UnityWebRequest> ToUniTask(UnityWebRequestAsyncOperation asyncOperation) { }

	[ExtensionAttribute] // RVA: 0x2DEE0 Offset: 0x2DFE1 VA: 0x2DEE0
	// RVA: 0x2E89C20 Offset: 0x2E89D21 VA: 0x2E89C20
	public static UniTask<UnityWebRequest> ConfigureAwait(UnityWebRequestAsyncOperation asyncOperation, IProgress<float> progress, PlayerLoopTiming timing = 4, CancellationToken cancellation) { }

	[ExtensionAttribute] // RVA: 0x2DEF0 Offset: 0x2DFF1 VA: 0x2DEF0
	// RVA: 0x2E89D70 Offset: 0x2E89E71 VA: 0x2E89D70
	public static AsyncUnityEventHandler GetAsyncEventHandler(UnityEvent unityEvent, CancellationToken cancellationToken) { }

	[ExtensionAttribute] // RVA: 0x2DF00 Offset: 0x2E001 VA: 0x2DF00
	// RVA: 0x2E89DE0 Offset: 0x2E89EE1 VA: 0x2E89DE0
	public static UniTask OnInvokeAsync(UnityEvent unityEvent, CancellationToken cancellationToken) { }

	[ExtensionAttribute] // RVA: 0x2DF10 Offset: 0x2E011 VA: 0x2DF10
	// RVA: 0x2E89E70 Offset: 0x2E89F71 VA: 0x2E89E70
	public static IAsyncClickEventHandler GetAsyncClickEventHandler(Button button) { }

	[ExtensionAttribute] // RVA: 0x2DF20 Offset: 0x2E021 VA: 0x2DF20
	// RVA: 0x2E89EF0 Offset: 0x2E89FF1 VA: 0x2E89EF0
	public static IAsyncClickEventHandler GetAsyncClickEventHandler(Button button, CancellationToken cancellationToken) { }

	[ExtensionAttribute] // RVA: 0x2DF30 Offset: 0x2E031 VA: 0x2DF30
	// RVA: 0x2E89F70 Offset: 0x2E8A071 VA: 0x2E89F70
	public static UniTask OnClickAsync(Button button) { }

	[ExtensionAttribute] // RVA: 0x2DF40 Offset: 0x2E041 VA: 0x2DF40
	// RVA: 0x2E8A000 Offset: 0x2E8A101 VA: 0x2E8A000
	public static UniTask OnClickAsync(Button button, CancellationToken cancellationToken) { }

	[ExtensionAttribute] // RVA: 0x2DF50 Offset: 0x2E051 VA: 0x2DF50
	// RVA: 0x2E8A090 Offset: 0x2E8A191 VA: 0x2E8A090
	public static IAsyncValueChangedEventHandler<bool> GetAsyncValueChangedEventHandler(Toggle toggle) { }

	[ExtensionAttribute] // RVA: 0x2DF60 Offset: 0x2E061 VA: 0x2DF60
	// RVA: 0x2E8A130 Offset: 0x2E8A231 VA: 0x2E8A130
	public static IAsyncValueChangedEventHandler<bool> GetAsyncValueChangedEventHandler(Toggle toggle, CancellationToken cancellationToken) { }

	[ExtensionAttribute] // RVA: 0x2DF70 Offset: 0x2E071 VA: 0x2DF70
	// RVA: 0x2E8A1D0 Offset: 0x2E8A2D1 VA: 0x2E8A1D0
	public static UniTask<bool> OnValueChangedAsync(Toggle toggle) { }

	[ExtensionAttribute] // RVA: 0x2DF80 Offset: 0x2E081 VA: 0x2DF80
	// RVA: 0x2E8A290 Offset: 0x2E8A391 VA: 0x2E8A290
	public static UniTask<bool> OnValueChangedAsync(Toggle toggle, CancellationToken cancellationToken) { }

	[ExtensionAttribute] // RVA: 0x2DF90 Offset: 0x2E091 VA: 0x2DF90
	// RVA: 0x2E8A340 Offset: 0x2E8A441 VA: 0x2E8A340
	public static IAsyncValueChangedEventHandler<float> GetAsyncValueChangedEventHandler(Scrollbar scrollbar) { }

	[ExtensionAttribute] // RVA: 0x2DFA0 Offset: 0x2E0A1 VA: 0x2DFA0
	// RVA: 0x2E8A3E0 Offset: 0x2E8A4E1 VA: 0x2E8A3E0
	public static IAsyncValueChangedEventHandler<float> GetAsyncValueChangedEventHandler(Scrollbar scrollbar, CancellationToken cancellationToken) { }

	[ExtensionAttribute] // RVA: 0x2DFB0 Offset: 0x2E0B1 VA: 0x2DFB0
	// RVA: 0x2E8A480 Offset: 0x2E8A581 VA: 0x2E8A480
	public static UniTask<float> OnValueChangedAsync(Scrollbar scrollbar) { }

	[ExtensionAttribute] // RVA: 0x2DFC0 Offset: 0x2E0C1 VA: 0x2DFC0
	// RVA: 0x2E8A540 Offset: 0x2E8A641 VA: 0x2E8A540
	public static UniTask<float> OnValueChangedAsync(Scrollbar scrollbar, CancellationToken cancellationToken) { }

	[ExtensionAttribute] // RVA: 0x2DFD0 Offset: 0x2E0D1 VA: 0x2DFD0
	// RVA: 0x2E8A5F0 Offset: 0x2E8A6F1 VA: 0x2E8A5F0
	public static IAsyncValueChangedEventHandler<Vector2> GetAsyncValueChangedEventHandler(ScrollRect scrollRect) { }

	[ExtensionAttribute] // RVA: 0x2DFE0 Offset: 0x2E0E1 VA: 0x2DFE0
	// RVA: 0x2E8A690 Offset: 0x2E8A791 VA: 0x2E8A690
	public static IAsyncValueChangedEventHandler<Vector2> GetAsyncValueChangedEventHandler(ScrollRect scrollRect, CancellationToken cancellationToken) { }

	[ExtensionAttribute] // RVA: 0x2DFF0 Offset: 0x2E0F1 VA: 0x2DFF0
	// RVA: 0x2E8A730 Offset: 0x2E8A831 VA: 0x2E8A730
	public static UniTask<Vector2> OnValueChangedAsync(ScrollRect scrollRect) { }

	[ExtensionAttribute] // RVA: 0x2E000 Offset: 0x2E101 VA: 0x2E000
	// RVA: 0x2E8A7F0 Offset: 0x2E8A8F1 VA: 0x2E8A7F0
	public static UniTask<Vector2> OnValueChangedAsync(ScrollRect scrollRect, CancellationToken cancellationToken) { }

	[ExtensionAttribute] // RVA: 0x2E010 Offset: 0x2E111 VA: 0x2E010
	// RVA: 0x2E8A8A0 Offset: 0x2E8A9A1 VA: 0x2E8A8A0
	public static IAsyncValueChangedEventHandler<float> GetAsyncValueChangedEventHandler(Slider slider) { }

	[ExtensionAttribute] // RVA: 0x2E020 Offset: 0x2E121 VA: 0x2E020
	// RVA: 0x2E8A940 Offset: 0x2E8AA41 VA: 0x2E8A940
	public static IAsyncValueChangedEventHandler<float> GetAsyncValueChangedEventHandler(Slider slider, CancellationToken cancellationToken) { }

	[ExtensionAttribute] // RVA: 0x2E030 Offset: 0x2E131 VA: 0x2E030
	// RVA: 0x2E8A9E0 Offset: 0x2E8AAE1 VA: 0x2E8A9E0
	public static UniTask<float> OnValueChangedAsync(Slider slider) { }

	[ExtensionAttribute] // RVA: 0x2E040 Offset: 0x2E141 VA: 0x2E040
	// RVA: 0x2E8AAA0 Offset: 0x2E8ABA1 VA: 0x2E8AAA0
	public static UniTask<float> OnValueChangedAsync(Slider slider, CancellationToken cancellationToken) { }

	[ExtensionAttribute] // RVA: 0x2E050 Offset: 0x2E151 VA: 0x2E050
	// RVA: 0x2E8AB50 Offset: 0x2E8AC51 VA: 0x2E8AB50
	public static IAsyncEndEditEventHandler<string> GetAsyncEndEditEventHandler(InputField inputField) { }

	[ExtensionAttribute] // RVA: 0x2E060 Offset: 0x2E161 VA: 0x2E060
	// RVA: 0x2E8ABF0 Offset: 0x2E8ACF1 VA: 0x2E8ABF0
	public static IAsyncEndEditEventHandler<string> GetAsyncEndEditEventHandler(InputField inputField, CancellationToken cancellationToken) { }

	[ExtensionAttribute] // RVA: 0x2E070 Offset: 0x2E171 VA: 0x2E070
	// RVA: 0x2E8AC90 Offset: 0x2E8AD91 VA: 0x2E8AC90
	public static UniTask<string> OnEndEditAsync(InputField inputField) { }

	[ExtensionAttribute] // RVA: 0x2E080 Offset: 0x2E181 VA: 0x2E080
	// RVA: 0x2E8AD50 Offset: 0x2E8AE51 VA: 0x2E8AD50
	public static UniTask<string> OnEndEditAsync(InputField inputField, CancellationToken cancellationToken) { }

	[ExtensionAttribute] // RVA: 0x2E090 Offset: 0x2E191 VA: 0x2E090
	// RVA: 0x2E8AE00 Offset: 0x2E8AF01 VA: 0x2E8AE00
	public static IAsyncValueChangedEventHandler<int> GetAsyncValueChangedEventHandler(Dropdown dropdown) { }

	[ExtensionAttribute] // RVA: 0x2E0A0 Offset: 0x2E1A1 VA: 0x2E0A0
	// RVA: 0x2E8AEA0 Offset: 0x2E8AFA1 VA: 0x2E8AEA0
	public static IAsyncValueChangedEventHandler<int> GetAsyncValueChangedEventHandler(Dropdown dropdown, CancellationToken cancellationToken) { }

	[ExtensionAttribute] // RVA: 0x2E0B0 Offset: 0x2E1B1 VA: 0x2E0B0
	// RVA: 0x2E8AF40 Offset: 0x2E8B041 VA: 0x2E8AF40
	public static UniTask<int> OnValueChanged(Dropdown dropdown) { }

	[ExtensionAttribute] // RVA: 0x2E0C0 Offset: 0x2E1C1 VA: 0x2E0C0
	// RVA: 0x2E8B000 Offset: 0x2E8B101 VA: 0x2E8B000
	public static UniTask<int> OnValueChanged(Dropdown dropdown, CancellationToken cancellationToken) { }
}

