// Namespace: System.IO
internal abstract class SearchResultHandler<TSource> // TypeDefIndex: 627
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract bool IsResultIncluded(SearchResult result);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-SearchResultHandler<object>.IsResultIncluded
	*/

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract TSource CreateObject(SearchResult result);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-SearchResultHandler<object>.CreateObject
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3002540 Offset: 0x3002641 VA: 0x3002540
	|-SearchResultHandler<object>..ctor
	|-SearchResultHandler<string>..ctor
	*/
}

