// Namespace: 
public sealed class DataStore.ResultListCB : MulticastDelegate // TypeDefIndex: 14894
{
	// Methods

	// RVA: 0x1E11C90 Offset: 0x1E11D91 VA: 0x1E11C90
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1E11CB0 Offset: 0x1E11DB1 VA: 0x1E11CB0 Slot: 13
	public virtual void Invoke(AsyncResult asyncResult, List<DataStoreResult> resultList) { }

	// RVA: 0x1E12020 Offset: 0x1E12121 VA: 0x1E12020 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncResult asyncResult, List<DataStoreResult> resultList, AsyncCallback callback, object object) { }

	// RVA: 0x1E12050 Offset: 0x1E12151 VA: 0x1E12050 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class DataStore.GetObjectCB : MulticastDelegate // TypeDefIndex: 14896
{
	// Methods

	// RVA: 0x1E0ED00 Offset: 0x1E0EE01 VA: 0x1E0ED00
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1E0ED20 Offset: 0x1E0EE21 VA: 0x1E0ED20 Slot: 13
	public virtual void Invoke(AsyncResult asyncResult, byte[] data) { }

	// RVA: 0x1E0F090 Offset: 0x1E0F191 VA: 0x1E0F090 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncResult asyncResult, byte[] data, AsyncCallback callback, object object) { }

	// RVA: 0x1E0F0C0 Offset: 0x1E0F1C1 VA: 0x1E0F0C0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class DataStore.GetMetaListCB : MulticastDelegate // TypeDefIndex: 14898
{
	// Methods

	// RVA: 0x1E0E900 Offset: 0x1E0EA01 VA: 0x1E0E900
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1E0E920 Offset: 0x1E0EA21 VA: 0x1E0E920 Slot: 13
	public virtual void Invoke(AsyncResult asyncResult, List<DataStoreMetaInfo> info, List<DataStoreResult> resultList) { }

	// RVA: 0x1E0ECC0 Offset: 0x1E0EDC1 VA: 0x1E0ECC0 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncResult asyncResult, List<DataStoreMetaInfo> info, List<DataStoreResult> resultList, AsyncCallback callback, object object) { }

	// RVA: 0x1E0ECF0 Offset: 0x1E0EDF1 VA: 0x1E0ECF0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class DataStore.RatingInfoAllSlotCB : MulticastDelegate // TypeDefIndex: 14900
{
	// Methods

	// RVA: 0x1E104B0 Offset: 0x1E105B1 VA: 0x1E104B0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1E104D0 Offset: 0x1E105D1 VA: 0x1E104D0 Slot: 13
	public virtual void Invoke(AsyncResult asyncResult, Dictionary<sbyte, DataStoreRatingInfo> info) { }

	// RVA: 0x1E10840 Offset: 0x1E10941 VA: 0x1E10840 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncResult asyncResult, Dictionary<sbyte, DataStoreRatingInfo> info, AsyncCallback callback, object object) { }

	// RVA: 0x1E10870 Offset: 0x1E10971 VA: 0x1E10870 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class DataStore.RatingInfoListCB : MulticastDelegate // TypeDefIndex: 14902
{
	// Methods

	// RVA: 0x1E10E70 Offset: 0x1E10F71 VA: 0x1E10E70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1E10E90 Offset: 0x1E10F91 VA: 0x1E10E90 Slot: 13
	public virtual void Invoke(AsyncResult asyncResult, List<DataStoreRatingInfo> info, List<DataStoreResult> resultList) { }

	// RVA: 0x1E11230 Offset: 0x1E11331 VA: 0x1E11230 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncResult asyncResult, List<DataStoreRatingInfo> info, List<DataStoreResult> resultList, AsyncCallback callback, object object) { }

	// RVA: 0x1E11260 Offset: 0x1E11361 VA: 0x1E11260 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class DataStore.GetPersistenceInfoCB : MulticastDelegate // TypeDefIndex: 14904
{
	// Methods

	// RVA: 0x1E0F8A0 Offset: 0x1E0F9A1 VA: 0x1E0F8A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1E0F8C0 Offset: 0x1E0F9C1 VA: 0x1E0F8C0 Slot: 13
	public virtual void Invoke(AsyncResult asyncResult, DataStorePersistenceInfo info) { }

	// RVA: 0x1E0FC30 Offset: 0x1E0FD31 VA: 0x1E0FC30 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncResult asyncResult, DataStorePersistenceInfo info, AsyncCallback callback, object object) { }

	// RVA: 0x1E0FC60 Offset: 0x1E0FD61 VA: 0x1E0FC60 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class DataStore.GetPasswordInfoCB : MulticastDelegate // TypeDefIndex: 14906
{
	// Methods

	// RVA: 0x1E0F0D0 Offset: 0x1E0F1D1 VA: 0x1E0F0D0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1E0F0F0 Offset: 0x1E0F1F1 VA: 0x1E0F0F0 Slot: 13
	public virtual void Invoke(AsyncResult asyncResult, DataStorePasswordInfo info) { }

	// RVA: 0x1E0F460 Offset: 0x1E0F561 VA: 0x1E0F460 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncResult asyncResult, DataStorePasswordInfo info, AsyncCallback callback, object object) { }

	// RVA: 0x1E0F490 Offset: 0x1E0F591 VA: 0x1E0F490 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public enum DataStore.Permission // TypeDefIndex: 14908
{
	// Fields
	public int value__; // 0x0
	public const DataStore.Permission PERMISSION_PUBLIC = 0;
	public const DataStore.Permission PERMISSION_FRIEND = 1;
	public const DataStore.Permission PERMISSION_SPECIFIED = 2;
	public const DataStore.Permission PERMISSION_PRIVATE = 3;
	public const DataStore.Permission PERMISSION_SPECIFIED_FRIEND = 4;
}

// Namespace: 
[FlagsAttribute] // RVA: 0x27ACB0 Offset: 0x27ADB1 VA: 0x27ACB0
public enum DataStore.ModificationFlag // TypeDefIndex: 14910
{
	// Fields
	public int value__; // 0x0
	public const DataStore.ModificationFlag MODIFICATION_FLAG_NONE = 0;
	public const DataStore.ModificationFlag MODIFICATION_FLAG_NAME = 1;
	public const DataStore.ModificationFlag MODIFICATION_FLAG_ACCESS_PERMISSION = 2;
	public const DataStore.ModificationFlag MODIFICATION_FLAG_UPDATE_PERMISSION = 4;
	public const DataStore.ModificationFlag MODIFICATION_FLAG_PERIOD = 8;
	public const DataStore.ModificationFlag MODIFICATION_FLAG_METABINARY = 16;
	public const DataStore.ModificationFlag MODIFICATION_FLAG_TAGS = 32;
	public const DataStore.ModificationFlag MODIFICATION_FLAG_UPDATED_TIME = 64;
	public const DataStore.ModificationFlag MODIFICATION_FLAG_DATA_TYPE = 128;
	public const DataStore.ModificationFlag MODIFICATION_FLAG_STATUS = 512;
}

// Namespace: 
[FlagsAttribute] // RVA: 0x27ACC0 Offset: 0x27ADC1 VA: 0x27ACC0
public enum DataStore.ComparisonFlag // TypeDefIndex: 14912
{
	// Fields
	public int value__; // 0x0
	public const DataStore.ComparisonFlag COMPARISON_FLAG_NONE = 0;
	public const DataStore.ComparisonFlag COMPARISON_FLAG_NAME = 1;
	public const DataStore.ComparisonFlag COMPARISON_FLAG_ACCESS_PERMISSION = 2;
	public const DataStore.ComparisonFlag COMPARISON_FLAG_UPDATE_PERMISSION = 4;
	public const DataStore.ComparisonFlag COMPARISON_FLAG_PERIOD = 8;
	public const DataStore.ComparisonFlag COMPARISON_FLAG_METABINARY = 16;
	public const DataStore.ComparisonFlag COMPARISON_FLAG_TAGS = 32;
	public const DataStore.ComparisonFlag COMPARISON_FLAG_DATA_TYPE = 64;
	public const DataStore.ComparisonFlag COMPARISON_FLAG_STATUS = 256;
	public const DataStore.ComparisonFlag COMPARISON_FLAG_ALL = 65535;
}

// Namespace: 
public enum DataStore.SearchTarget // TypeDefIndex: 14914
{
	// Fields
	public int value__; // 0x0
	public const DataStore.SearchTarget SEARCH_TARGET_ANYBODY = 0;
	public const DataStore.SearchTarget SEARCH_TARGET_FRIEND = 1;
}

// Namespace: 
public enum DataStore.SearchSortOrder // TypeDefIndex: 14916
{
	// Fields
	public int value__; // 0x0
	public const DataStore.SearchSortOrder SEARCH_SORT_ORDER_ASC = 0;
	public const DataStore.SearchSortOrder SEARCH_SORT_ORDER_DESC = 1;
}

// Namespace: 
public enum DataStore.RatingLockType // TypeDefIndex: 14918
{
	// Fields
	public int value__; // 0x0
	public const DataStore.RatingLockType RATING_LOCK_NONE = 0;
	public const DataStore.RatingLockType RATING_LOCK_INTERVAL = 1;
	public const DataStore.RatingLockType RATING_LOCK_PERIOD = 2;
	public const DataStore.RatingLockType RATING_LOCK_PERMANENT = 3;
}

// Namespace: 
[FlagsAttribute] // RVA: 0x27ACE0 Offset: 0x27ADE1 VA: 0x27ACE0
internal enum DataStore.RatingInternalFlag // TypeDefIndex: 14920
{
	// Fields
	public int value__; // 0x0
	public const DataStore.RatingInternalFlag RATING_INTERNAL_FLAG_USE_RANGE_MIN = 2;
	public const DataStore.RatingInternalFlag RATING_INTERNAL_FLAG_USE_RANGE_MAX = 4;
}

// Namespace: 
public enum DataStore.SearchResultTotalCountType // TypeDefIndex: 14922
{
	// Fields
	public int value__; // 0x0
	public const DataStore.SearchResultTotalCountType SEARCH_RESULT_TOTAL_EXACT = 0;
	public const DataStore.SearchResultTotalCountType SEARCH_RESULT_TOTAL_MINIMUM = 1;
	public const DataStore.SearchResultTotalCountType SEARCH_RESULT_TOTAL_ESTIMATE = 2;
	public const DataStore.SearchResultTotalCountType SEARCH_RESULT_TOTAL_DISABLED = 3;
}

