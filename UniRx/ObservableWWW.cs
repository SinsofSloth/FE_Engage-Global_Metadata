// Namespace: UniRx
[ObsoleteAttribute] // RVA: 0x13130 Offset: 0x13231 VA: 0x13130
public static class ObservableWWW // TypeDefIndex: 6728
{
	// Methods

	// RVA: 0x19EB080 Offset: 0x19EB181 VA: 0x19EB080
	public static IObservable<string> Get(string url, Dictionary<string, string> headers, IProgress<float> progress) { }

	// RVA: 0x19EB1D0 Offset: 0x19EB2D1 VA: 0x19EB1D0
	public static IObservable<byte[]> GetAndGetBytes(string url, Dictionary<string, string> headers, IProgress<float> progress) { }

	// RVA: 0x19EB320 Offset: 0x19EB421 VA: 0x19EB320
	public static IObservable<WWW> GetWWW(string url, Dictionary<string, string> headers, IProgress<float> progress) { }

	// RVA: 0x19EB470 Offset: 0x19EB571 VA: 0x19EB470
	public static IObservable<string> Post(string url, byte[] postData, IProgress<float> progress) { }

	// RVA: 0x19EB5C0 Offset: 0x19EB6C1 VA: 0x19EB5C0
	public static IObservable<string> Post(string url, byte[] postData, Dictionary<string, string> headers, IProgress<float> progress) { }

	// RVA: 0x19EB730 Offset: 0x19EB831 VA: 0x19EB730
	public static IObservable<string> Post(string url, WWWForm content, IProgress<float> progress) { }

	// RVA: 0x19EB880 Offset: 0x19EB981 VA: 0x19EB880
	public static IObservable<string> Post(string url, WWWForm content, Dictionary<string, string> headers, IProgress<float> progress) { }

	// RVA: 0x19EBA10 Offset: 0x19EBB11 VA: 0x19EBA10
	public static IObservable<byte[]> PostAndGetBytes(string url, byte[] postData, IProgress<float> progress) { }

	// RVA: 0x19EBB60 Offset: 0x19EBC61 VA: 0x19EBB60
	public static IObservable<byte[]> PostAndGetBytes(string url, byte[] postData, Dictionary<string, string> headers, IProgress<float> progress) { }

	// RVA: 0x19EBCD0 Offset: 0x19EBDD1 VA: 0x19EBCD0
	public static IObservable<byte[]> PostAndGetBytes(string url, WWWForm content, IProgress<float> progress) { }

	// RVA: 0x19EBE20 Offset: 0x19EBF21 VA: 0x19EBE20
	public static IObservable<byte[]> PostAndGetBytes(string url, WWWForm content, Dictionary<string, string> headers, IProgress<float> progress) { }

	// RVA: 0x19EBFB0 Offset: 0x19EC0B1 VA: 0x19EBFB0
	public static IObservable<WWW> PostWWW(string url, byte[] postData, IProgress<float> progress) { }

	// RVA: 0x19EC100 Offset: 0x19EC201 VA: 0x19EC100
	public static IObservable<WWW> PostWWW(string url, byte[] postData, Dictionary<string, string> headers, IProgress<float> progress) { }

	// RVA: 0x19EC270 Offset: 0x19EC371 VA: 0x19EC270
	public static IObservable<WWW> PostWWW(string url, WWWForm content, IProgress<float> progress) { }

	// RVA: 0x19EC3C0 Offset: 0x19EC4C1 VA: 0x19EC3C0
	public static IObservable<WWW> PostWWW(string url, WWWForm content, Dictionary<string, string> headers, IProgress<float> progress) { }

	// RVA: 0x19EC550 Offset: 0x19EC651 VA: 0x19EC550
	public static IObservable<AssetBundle> LoadFromCacheOrDownload(string url, int version, IProgress<float> progress) { }

	// RVA: 0x19EC6A0 Offset: 0x19EC7A1 VA: 0x19EC6A0
	public static IObservable<AssetBundle> LoadFromCacheOrDownload(string url, int version, uint crc, IProgress<float> progress) { }

	// RVA: 0x19EC7F0 Offset: 0x19EC8F1 VA: 0x19EC7F0
	public static IObservable<AssetBundle> LoadFromCacheOrDownload(string url, Hash128 hash128, IProgress<float> progress) { }

	// RVA: 0x19EC940 Offset: 0x19ECA41 VA: 0x19EC940
	public static IObservable<AssetBundle> LoadFromCacheOrDownload(string url, Hash128 hash128, uint crc, IProgress<float> progress) { }

	// RVA: 0x19ECA90 Offset: 0x19ECB91 VA: 0x19ECA90
	private static Dictionary<string, string> MergeHash(Dictionary<string, string> wwwFormHeaders, Dictionary<string, string> externalHeaders) { }

	[IteratorStateMachineAttribute] // RVA: 0x16890 Offset: 0x16991 VA: 0x16890
	// RVA: 0x19ECBE0 Offset: 0x19ECCE1 VA: 0x19ECBE0
	private static IEnumerator Fetch(WWW www, IObserver<WWW> observer, IProgress<float> reportProgress, CancellationToken cancel) { }

	[IteratorStateMachineAttribute] // RVA: 0x16900 Offset: 0x16A01 VA: 0x16900
	// RVA: 0x19ECCA0 Offset: 0x19ECDA1 VA: 0x19ECCA0
	private static IEnumerator FetchText(WWW www, IObserver<string> observer, IProgress<float> reportProgress, CancellationToken cancel) { }

	[IteratorStateMachineAttribute] // RVA: 0x16970 Offset: 0x16A71 VA: 0x16970
	// RVA: 0x19ECD60 Offset: 0x19ECE61 VA: 0x19ECD60
	private static IEnumerator FetchBytes(WWW www, IObserver<byte[]> observer, IProgress<float> reportProgress, CancellationToken cancel) { }

	[IteratorStateMachineAttribute] // RVA: 0x169E0 Offset: 0x16AE1 VA: 0x169E0
	// RVA: 0x19ECE20 Offset: 0x19ECF21 VA: 0x19ECE20
	private static IEnumerator FetchAssetBundle(WWW www, IObserver<AssetBundle> observer, IProgress<float> reportProgress, CancellationToken cancel) { }
}

