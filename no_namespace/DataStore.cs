// Namespace: 
public sealed class DataStore.PostCB : MulticastDelegate // TypeDefIndex: 14893
{
	// Methods

	// RVA: 0x1E10070 Offset: 0x1E10171 VA: 0x1E10070
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1E10090 Offset: 0x1E10191 VA: 0x1E10090 Slot: 13
	public virtual void Invoke(AsyncResult asyncResult, ulong dataId) { }

	// RVA: 0x1E10400 Offset: 0x1E10501 VA: 0x1E10400 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncResult asyncResult, ulong dataId, AsyncCallback callback, object object) { }

	// RVA: 0x1E104A0 Offset: 0x1E105A1 VA: 0x1E104A0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

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
public sealed class DataStore.SearchObjectCB : MulticastDelegate // TypeDefIndex: 14895
{
	// Methods

	// RVA: 0x1E12060 Offset: 0x1E12161 VA: 0x1E12060
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1E12080 Offset: 0x1E12181 VA: 0x1E12080 Slot: 13
	public virtual void Invoke(AsyncResult asyncResult, DataStoreSearchResult result) { }

	// RVA: 0x1E123F0 Offset: 0x1E124F1 VA: 0x1E123F0 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncResult asyncResult, DataStoreSearchResult result, AsyncCallback callback, object object) { }

	// RVA: 0x1E12420 Offset: 0x1E12521 VA: 0x1E12420 Slot: 15
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
public sealed class DataStore.GetMetaCB : MulticastDelegate // TypeDefIndex: 14897
{
	// Methods

	// RVA: 0x1E0E530 Offset: 0x1E0E631 VA: 0x1E0E530
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1E0E550 Offset: 0x1E0E651 VA: 0x1E0E550 Slot: 13
	public virtual void Invoke(AsyncResult asyncResult, DataStoreMetaInfo info) { }

	// RVA: 0x1E0E8C0 Offset: 0x1E0E9C1 VA: 0x1E0E8C0 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncResult asyncResult, DataStoreMetaInfo info, AsyncCallback callback, object object) { }

	// RVA: 0x1E0E8F0 Offset: 0x1E0E9F1 VA: 0x1E0E8F0 Slot: 15
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
public sealed class DataStore.RatingInfoCB : MulticastDelegate // TypeDefIndex: 14899
{
	// Methods

	// RVA: 0x1E10880 Offset: 0x1E10981 VA: 0x1E10880
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1E108A0 Offset: 0x1E109A1 VA: 0x1E108A0 Slot: 13
	public virtual void Invoke(AsyncResult asyncResult, DataStoreRatingInfo info) { }

	// RVA: 0x1E10DC0 Offset: 0x1E10EC1 VA: 0x1E10DC0 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncResult asyncResult, DataStoreRatingInfo info, AsyncCallback callback, object object) { }

	// RVA: 0x1E10E60 Offset: 0x1E10F61 VA: 0x1E10E60 Slot: 15
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
public sealed class DataStore.RatingInfoWithLogCB : MulticastDelegate // TypeDefIndex: 14901
{
	// Methods

	// RVA: 0x1E11270 Offset: 0x1E11371 VA: 0x1E11270
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1E11290 Offset: 0x1E11391 VA: 0x1E11290 Slot: 13
	public virtual void Invoke(AsyncResult asyncResult, DataStoreRatingInfo info, DataStoreRatingLog log) { }

	// RVA: 0x1E117D0 Offset: 0x1E118D1 VA: 0x1E117D0 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncResult asyncResult, DataStoreRatingInfo info, DataStoreRatingLog log, AsyncCallback callback, object object) { }

	// RVA: 0x1E11880 Offset: 0x1E11981 VA: 0x1E11880 Slot: 15
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
public sealed class DataStore.RatingInfosListCB : MulticastDelegate // TypeDefIndex: 14903
{
	// Methods

	// RVA: 0x1E11890 Offset: 0x1E11991 VA: 0x1E11890
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1E118B0 Offset: 0x1E119B1 VA: 0x1E118B0 Slot: 13
	public virtual void Invoke(AsyncResult asyncResult, List<Dictionary<sbyte, DataStoreRatingInfo>> info, List<DataStoreResult> resultList) { }

	// RVA: 0x1E11C50 Offset: 0x1E11D51 VA: 0x1E11C50 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncResult asyncResult, List<Dictionary<sbyte, DataStoreRatingInfo>> info, List<DataStoreResult> resultList, AsyncCallback callback, object object) { }

	// RVA: 0x1E11C80 Offset: 0x1E11D81 VA: 0x1E11C80 Slot: 15
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
public sealed class DataStore.GetPersistenceInfoListCB : MulticastDelegate // TypeDefIndex: 14905
{
	// Methods

	// RVA: 0x1E0FC70 Offset: 0x1E0FD71 VA: 0x1E0FC70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1E0FC90 Offset: 0x1E0FD91 VA: 0x1E0FC90 Slot: 13
	public virtual void Invoke(AsyncResult asyncResult, List<DataStorePersistenceInfo> info, List<DataStoreResult> resultList) { }

	// RVA: 0x1E10030 Offset: 0x1E10131 VA: 0x1E10030 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncResult asyncResult, List<DataStorePersistenceInfo> info, List<DataStoreResult> resultList, AsyncCallback callback, object object) { }

	// RVA: 0x1E10060 Offset: 0x1E10161 VA: 0x1E10060 Slot: 15
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
public sealed class DataStore.GetPasswordInfoListCB : MulticastDelegate // TypeDefIndex: 14907
{
	// Methods

	// RVA: 0x1E0F4A0 Offset: 0x1E0F5A1 VA: 0x1E0F4A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1E0F4C0 Offset: 0x1E0F5C1 VA: 0x1E0F4C0 Slot: 13
	public virtual void Invoke(AsyncResult asyncResult, List<DataStorePasswordInfo> info, List<DataStoreResult> resultList) { }

	// RVA: 0x1E0F860 Offset: 0x1E0F961 VA: 0x1E0F860 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncResult asyncResult, List<DataStorePasswordInfo> info, List<DataStoreResult> resultList, AsyncCallback callback, object object) { }

	// RVA: 0x1E0F890 Offset: 0x1E0F991 VA: 0x1E0F890 Slot: 15
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
[FlagsAttribute] // RVA: 0x27ACA0 Offset: 0x27ADA1 VA: 0x27ACA0
public enum DataStore.DataFlag // TypeDefIndex: 14909
{
	// Fields
	public int value__; // 0x0
	public const DataStore.DataFlag DATA_FLAG_NONE = 0;
	public const DataStore.DataFlag DATA_FLAG_NEED_REVIEW = 1;
	public const DataStore.DataFlag DATA_FLAG_PERIOD_FROM_LAST_REFERRED = 2;
	public const DataStore.DataFlag DATA_FLAG_USE_READ_LOCK = 4;
	public const DataStore.DataFlag DATA_FLAG_USE_NOTIFICATION_ON_POST = 8;
	public const DataStore.DataFlag DATA_FLAG_USE_NOTIFICATION_ON_UPDATE = 16;
	public const DataStore.DataFlag DATA_FLAG_NOT_USE_FILESERVER = 32;
	public const DataStore.DataFlag DATA_FLAG_NEED_COMPLETION = 64;
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
public enum DataStore.DataStatus // TypeDefIndex: 14911
{
	// Fields
	public int value__; // 0x0
	public const DataStore.DataStatus DATA_STATUS_NONE = 0;
	public const DataStore.DataStatus DATA_STATUS_PENDING = 2;
	public const DataStore.DataStatus DATA_STATUS_REJECTED = 5;
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
public enum DataStore.SearchType // TypeDefIndex: 14913
{
	// Fields
	public int value__; // 0x0
	public const DataStore.SearchType SEARCH_TYPE_PUBLIC = 1;
	public const DataStore.SearchType SEARCH_TYPE_SEND_FRIEND = 2;
	public const DataStore.SearchType SEARCH_TYPE_SEND_SPECIFIED = 3;
	public const DataStore.SearchType SEARCH_TYPE_SEND_SPECIFIED_FRIEND = 4;
	public const DataStore.SearchType SEARCH_TYPE_SEND = 5;
	public const DataStore.SearchType SEARCH_TYPE_FRIEND = 6;
	public const DataStore.SearchType SEARCH_TYPE_RECEIVED_SPECIFIED = 7;
	public const DataStore.SearchType SEARCH_TYPE_RECEIVED = 8;
	public const DataStore.SearchType SEARCH_TYPE_PRIVATE = 9;
	public const DataStore.SearchType SEARCH_TYPE_OWN = 10;
	public const DataStore.SearchType SEARCH_TYPE_OWN_PENDING = 12;
	public const DataStore.SearchType SEARCH_TYPE_OWN_REJECTED = 13;
	public const DataStore.SearchType SEARCH_TYPE_OWN_ALL = 14;
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
public enum DataStore.SearchSortColumn // TypeDefIndex: 14915
{
	// Fields
	public int value__; // 0x0
	public const DataStore.SearchSortColumn SEARCH_SORT_COLUMN_DATAID = 0;
	public const DataStore.SearchSortColumn SEARCH_SORT_COLUMN_CREATED_TIME = 5;
	public const DataStore.SearchSortColumn SEARCH_SORT_COLUMN_UPDATED_TIME = 6;
	public const DataStore.SearchSortColumn SEARCH_SORT_COLUMN_RATING0 = 64;
	public const DataStore.SearchSortColumn SEARCH_SORT_COLUMN_RATING1 = 65;
	public const DataStore.SearchSortColumn SEARCH_SORT_COLUMN_RATING2 = 66;
	public const DataStore.SearchSortColumn SEARCH_SORT_COLUMN_RATING3 = 67;
	public const DataStore.SearchSortColumn SEARCH_SORT_COLUMN_RATING4 = 68;
	public const DataStore.SearchSortColumn SEARCH_SORT_COLUMN_RATING5 = 69;
	public const DataStore.SearchSortColumn SEARCH_SORT_COLUMN_RATING6 = 70;
	public const DataStore.SearchSortColumn SEARCH_SORT_COLUMN_RATING7 = 71;
	public const DataStore.SearchSortColumn SEARCH_SORT_COLUMN_RATING8 = 72;
	public const DataStore.SearchSortColumn SEARCH_SORT_COLUMN_RATING9 = 73;
	public const DataStore.SearchSortColumn SEARCH_SORT_COLUMN_RATING10 = 74;
	public const DataStore.SearchSortColumn SEARCH_SORT_COLUMN_RATING11 = 75;
	public const DataStore.SearchSortColumn SEARCH_SORT_COLUMN_RATING12 = 76;
	public const DataStore.SearchSortColumn SEARCH_SORT_COLUMN_RATING13 = 77;
	public const DataStore.SearchSortColumn SEARCH_SORT_COLUMN_RATING14 = 78;
	public const DataStore.SearchSortColumn SEARCH_SORT_COLUMN_RATING15 = 79;
	public const DataStore.SearchSortColumn SEARCH_SORT_COLUMN_RATING_AVERAGE0 = 96;
	public const DataStore.SearchSortColumn SEARCH_SORT_COLUMN_RATING_AVERAGE1 = 97;
	public const DataStore.SearchSortColumn SEARCH_SORT_COLUMN_RATING_AVERAGE2 = 98;
	public const DataStore.SearchSortColumn SEARCH_SORT_COLUMN_RATING_AVERAGE3 = 99;
	public const DataStore.SearchSortColumn SEARCH_SORT_COLUMN_RATING_AVERAGE4 = 100;
	public const DataStore.SearchSortColumn SEARCH_SORT_COLUMN_RATING_AVERAGE5 = 101;
	public const DataStore.SearchSortColumn SEARCH_SORT_COLUMN_RATING_AVERAGE6 = 102;
	public const DataStore.SearchSortColumn SEARCH_SORT_COLUMN_RATING_AVERAGE7 = 103;
	public const DataStore.SearchSortColumn SEARCH_SORT_COLUMN_RATING_AVERAGE8 = 104;
	public const DataStore.SearchSortColumn SEARCH_SORT_COLUMN_RATING_AVERAGE9 = 105;
	public const DataStore.SearchSortColumn SEARCH_SORT_COLUMN_RATING_AVERAGE10 = 106;
	public const DataStore.SearchSortColumn SEARCH_SORT_COLUMN_RATING_AVERAGE11 = 107;
	public const DataStore.SearchSortColumn SEARCH_SORT_COLUMN_RATING_AVERAGE12 = 108;
	public const DataStore.SearchSortColumn SEARCH_SORT_COLUMN_RATING_AVERAGE13 = 109;
	public const DataStore.SearchSortColumn SEARCH_SORT_COLUMN_RATING_AVERAGE14 = 110;
	public const DataStore.SearchSortColumn SEARCH_SORT_COLUMN_RATING_AVERAGE15 = 111;
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
[FlagsAttribute] // RVA: 0x27ACD0 Offset: 0x27ADD1 VA: 0x27ACD0
public enum DataStore.ResultFlag // TypeDefIndex: 14917
{
	// Fields
	public int value__; // 0x0
	public const DataStore.ResultFlag RESULT_FLAG_TAGS = 1;
	public const DataStore.ResultFlag RESULT_FLAG_RATINGS = 2;
	public const DataStore.ResultFlag RESULT_FLAG_METABINARY = 4;
	public const DataStore.ResultFlag RESULT_FLAG_PERMITTED_IDS = 8;
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
public enum DataStore.RatingFlag // TypeDefIndex: 14919
{
	// Fields
	public int value__; // 0x0
	public const DataStore.RatingFlag RATING_FLAG_MODIFIABLE = 4;
	public const DataStore.RatingFlag RATING_FLAG_ROUND_MINUS = 8;
	public const DataStore.RatingFlag RATING_FLAG_DISABLE_SELF_RATING = 16;
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
public enum DataStore.RatingLockPeriod // TypeDefIndex: 14921
{
	// Fields
	public int value__; // 0x0
	public const DataStore.RatingLockPeriod RATING_LOCK_PERIOD_MON = -1;
	public const DataStore.RatingLockPeriod RATING_LOCK_PERIOD_TUE = -2;
	public const DataStore.RatingLockPeriod RATING_LOCK_PERIOD_WED = -3;
	public const DataStore.RatingLockPeriod RATING_LOCK_PERIOD_THU = -4;
	public const DataStore.RatingLockPeriod RATING_LOCK_PERIOD_FRI = -5;
	public const DataStore.RatingLockPeriod RATING_LOCK_PERIOD_SAT = -6;
	public const DataStore.RatingLockPeriod RATING_LOCK_PERIOD_SUN = -7;
	public const DataStore.RatingLockPeriod RATING_LOCK_PERIOD_DAY1 = -17;
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

