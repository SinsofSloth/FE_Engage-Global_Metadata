// Namespace: System.IO
internal class FileSystemEnumerableIterator<TSource> : Iterator<TSource> // TypeDefIndex: 626
{
	// Fields
	private SearchResultHandler<TSource> _resultHandler; // 0x0
	private List<Directory.SearchData> searchStack; // 0x0
	private Directory.SearchData searchData; // 0x0
	private string searchCriteria; // 0x0
	private SafeFindHandle _hnd; // 0x0
	private bool needsParentPathDiscoveryDemand; // 0x0
	private bool empty; // 0x0
	private string userPath; // 0x0
	private SearchOption searchOption; // 0x0
	private string fullPath; // 0x0
	private string normalizedSearchPath; // 0x0
	private bool _checkHost; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(string path, string originalUserPath, string searchPattern, SearchOption searchOption, SearchResultHandler<TSource> resultHandler, bool checkHost) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D4520 Offset: 0x33D4621 VA: 0x33D4520
	|-FileSystemEnumerableIterator<object>..ctor
	|-FileSystemEnumerableIterator<string>..ctor
	*/

	// RVA: -1 Offset: -1
	private void CommonInit() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D48B0 Offset: 0x33D49B1 VA: 0x33D48B0
	|-FileSystemEnumerableIterator<object>.CommonInit
	*/

	// RVA: -1 Offset: -1
	private void .ctor(string fullPath, string normalizedSearchPath, string searchCriteria, string userPath, SearchOption searchOption, SearchResultHandler<TSource> resultHandler, bool checkHost) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D4B20 Offset: 0x33D4C21 VA: 0x33D4B20
	|-FileSystemEnumerableIterator<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected override Iterator<TSource> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D4DA0 Offset: 0x33D4EA1 VA: 0x33D4DA0
	|-FileSystemEnumerableIterator<object>.Clone
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected override void Dispose(bool disposing) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D4E70 Offset: 0x33D4F71 VA: 0x33D4E70
	|-FileSystemEnumerableIterator<object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D4F40 Offset: 0x33D5041 VA: 0x33D4F40
	|-FileSystemEnumerableIterator<object>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private SearchResult CreateSearchResult(Directory.SearchData localSearchData, Win32Native.WIN32_FIND_DATA findData) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D5420 Offset: 0x33D5521 VA: 0x33D5420
	|-FileSystemEnumerableIterator<object>.CreateSearchResult
	*/

	// RVA: -1 Offset: -1
	private void HandleError(int hr, string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D5500 Offset: 0x33D5601 VA: 0x33D5500
	|-FileSystemEnumerableIterator<object>.HandleError
	*/

	// RVA: -1 Offset: -1
	private void AddSearchableDirsToStack(Directory.SearchData localSearchData) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D5540 Offset: 0x33D5641 VA: 0x33D5540
	|-FileSystemEnumerableIterator<object>.AddSearchableDirsToStack
	*/

	// RVA: -1 Offset: -1
	internal void DoDemand(string fullPathToDemand) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D58C0 Offset: 0x33D59C1 VA: 0x33D58C0
	|-FileSystemEnumerableIterator<object>.DoDemand
	*/

	// RVA: -1 Offset: -1
	private static string NormalizeSearchPattern(string searchPattern) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D58D0 Offset: 0x33D59D1 VA: 0x33D58D0
	|-FileSystemEnumerableIterator<object>.NormalizeSearchPattern
	*/

	// RVA: -1 Offset: -1
	private static string GetNormalizedSearchCriteria(string fullSearchString, string fullPathMod) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D59C0 Offset: 0x33D5AC1 VA: 0x33D59C0
	|-FileSystemEnumerableIterator<object>.GetNormalizedSearchCriteria
	*/

	// RVA: -1 Offset: -1
	private static string GetFullSearchString(string fullPath, string searchPattern) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33D5A70 Offset: 0x33D5B71 VA: 0x33D5A70
	|-FileSystemEnumerableIterator<object>.GetFullSearchString
	*/
}

