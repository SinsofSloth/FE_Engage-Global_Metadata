// Namespace: System.Resources
[ComVisibleAttribute] // RVA: 0x4715B0 Offset: 0x4716B1 VA: 0x4715B0
public sealed class ResourceReader : IResourceReader, IEnumerable, IDisposable // TypeDefIndex: 495
{
	// Fields
	private BinaryReader _store; // 0x10
	internal Dictionary<string, ResourceLocator> _resCache; // 0x18
	private long _nameSectionOffset; // 0x20
	private long _dataSectionOffset; // 0x28
	private int[] _nameHashes; // 0x30
	private int* _nameHashesPtr; // 0x38
	private int[] _namePositions; // 0x40
	private int* _namePositionsPtr; // 0x48
	private RuntimeType[] _typeTable; // 0x50
	private int[] _typeNamePositions; // 0x58
	private BinaryFormatter _objFormatter; // 0x60
	private int _numResources; // 0x68
	private UnmanagedMemoryStream _ums; // 0x70
	private int _version; // 0x78

	// Methods

	// RVA: 0x3223030 Offset: 0x3223131 VA: 0x3223030
	internal void .ctor(Stream stream, Dictionary<string, ResourceLocator> resCache) { }

	// RVA: 0x32232C0 Offset: 0x32233C1 VA: 0x32232C0 Slot: 4
	public void Close() { }

	// RVA: 0x3223390 Offset: 0x3223491 VA: 0x3223390 Slot: 7
	public void Dispose() { }

	// RVA: 0x32232D0 Offset: 0x32233D1 VA: 0x32232D0
	private void Dispose(bool disposing) { }

	// RVA: 0x32233A0 Offset: 0x32234A1 VA: 0x32233A0
	internal static int ReadUnalignedI4(int* p) { }

	// RVA: 0x32233B0 Offset: 0x32234B1 VA: 0x32233B0
	private void SkipString() { }

	// RVA: 0x3223460 Offset: 0x3223561 VA: 0x3223460
	private int GetNameHash(int index) { }

	// RVA: 0x32234B0 Offset: 0x32235B1 VA: 0x32234B0
	private int GetNamePosition(int index) { }

	// RVA: 0x32235D0 Offset: 0x32236D1 VA: 0x32235D0 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x32235E0 Offset: 0x32236E1 VA: 0x32235E0 Slot: 5
	public IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x32236A0 Offset: 0x32237A1 VA: 0x32236A0
	internal ResourceReader.ResourceEnumerator GetEnumeratorInternal() { }

	// RVA: 0x3223710 Offset: 0x3223811 VA: 0x3223710
	internal int FindPosForResource(string name) { }

	// RVA: 0x3223B90 Offset: 0x3223C91 VA: 0x3223B90
	private bool CompareStringEqualsName(string name) { }

	// RVA: 0x3223D90 Offset: 0x3223E91 VA: 0x3223D90
	private string AllocateStringForNameIndex(int index, out int dataOffset) { }

	// RVA: 0x3224650 Offset: 0x3224751 VA: 0x3224650
	private object GetValueForNameIndex(int index) { }

	// RVA: 0x3224AF0 Offset: 0x3224BF1 VA: 0x3224AF0
	internal string LoadString(int pos) { }

	// RVA: 0x32250F0 Offset: 0x32251F1 VA: 0x32250F0
	internal object LoadObject(int pos) { }

	// RVA: 0x3225130 Offset: 0x3225231 VA: 0x3225130
	internal object LoadObject(int pos, out ResourceTypeCode typeCode) { }

	// RVA: 0x32248D0 Offset: 0x32249D1 VA: 0x32248D0
	internal object LoadObjectV1(int pos) { }

	// RVA: 0x32251D0 Offset: 0x32252D1 VA: 0x32251D0
	private object _LoadObjectV1(int pos) { }

	// RVA: 0x32249E0 Offset: 0x3224AE1 VA: 0x32249E0
	internal object LoadObjectV2(int pos, out ResourceTypeCode typeCode) { }

	// RVA: 0x3225BE0 Offset: 0x3225CE1 VA: 0x3225BE0
	private object _LoadObjectV2(int pos, out ResourceTypeCode typeCode) { }

	// RVA: 0x3225A40 Offset: 0x3225B41 VA: 0x3225A40
	private object DeserializeObject(int typeIndex) { }

	// RVA: 0x3223140 Offset: 0x3223241 VA: 0x3223140
	private void ReadResources() { }

	// RVA: 0x3226270 Offset: 0x3226371 VA: 0x3226270
	private void _ReadResources() { }

	// RVA: 0x3224D90 Offset: 0x3224E91 VA: 0x3224D90
	private RuntimeType FindType(int typeIndex) { }
}

