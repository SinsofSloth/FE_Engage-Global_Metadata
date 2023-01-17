// Namespace: UniRx
[ExtensionAttribute] // RVA: 0x128A0 Offset: 0x129A1 VA: 0x128A0
public static class WebRequestExtensions // TypeDefIndex: 6471
{
	// Methods

	// RVA: -1 Offset: -1
	private static IObservable<TResult> AbortableDeferredAsyncRequest<TResult>(Func<AsyncCallback, object, IAsyncResult> begin, Func<IAsyncResult, TResult> end, WebRequest request) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x386F080 Offset: 0x386F181 VA: 0x386F080
	|-WebRequestExtensions.AbortableDeferredAsyncRequest<HttpWebResponse>
	|-WebRequestExtensions.AbortableDeferredAsyncRequest<object>
	|-WebRequestExtensions.AbortableDeferredAsyncRequest<Stream>
	|-WebRequestExtensions.AbortableDeferredAsyncRequest<WebResponse>
	*/

	[ExtensionAttribute] // RVA: 0x13EB0 Offset: 0x13FB1 VA: 0x13EB0
	// RVA: 0x1AFC1E0 Offset: 0x1AFC2E1 VA: 0x1AFC1E0
	public static IObservable<WebResponse> GetResponseAsObservable(WebRequest request) { }

	[ExtensionAttribute] // RVA: 0x13EC0 Offset: 0x13FC1 VA: 0x13EC0
	// RVA: 0x1AFC2E0 Offset: 0x1AFC3E1 VA: 0x1AFC2E0
	public static IObservable<HttpWebResponse> GetResponseAsObservable(HttpWebRequest request) { }

	[ExtensionAttribute] // RVA: 0x13ED0 Offset: 0x13FD1 VA: 0x13ED0
	// RVA: 0x1AFC450 Offset: 0x1AFC551 VA: 0x1AFC450
	public static IObservable<Stream> GetRequestStreamAsObservable(WebRequest request) { }
}

