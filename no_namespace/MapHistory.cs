// Namespace: 
private enum MapHistory.Mode // TypeDefIndex: 12032
{
	// Fields
	public int value__; // 0x0
	public const MapHistory.Mode None = 0;
	public const MapHistory.Mode Write = 1;
	public const MapHistory.Mode Read = 2;
}

// Namespace: 
private class MapHistory.CommandWriter : Stream // TypeDefIndex: 12034
{
	// Fields
	private const int BufferSize = 5120;
	private byte m_Type; // 0x28

	// Properties
	public int Type { get; }
	public int Size { get; }

	// Methods

	// RVA: 0x1D45D80 Offset: 0x1D45E81 VA: 0x1D45D80
	public void .ctor() { }

	// RVA: 0x1D45D90 Offset: 0x1D45E91 VA: 0x1D45D90
	public void Prepare(byte type) { }

	// RVA: 0x1D45DC0 Offset: 0x1D45EC1 VA: 0x1D45DC0
	public void WriteVariableKey(string key) { }

	// RVA: 0x1D45DD0 Offset: 0x1D45ED1 VA: 0x1D45DD0
	public static void WriteVariableKey(Stream stream, string key) { }

	// RVA: 0x1D45EA0 Offset: 0x1D45FA1 VA: 0x1D45EA0
	public void WriteGid(string gid) { }

	// RVA: 0x1D45F70 Offset: 0x1D46071 VA: 0x1D45F70
	public void WriteTid(string tid) { }

	// RVA: 0x1D45F80 Offset: 0x1D46081 VA: 0x1D45F80
	public static void WriteTid(Stream stream, string tid) { }

	// RVA: 0x1D46050 Offset: 0x1D46151 VA: 0x1D46050
	public void WriteIid(string iid) { }

	// RVA: 0x1D46120 Offset: 0x1D46221 VA: 0x1D46120
	public void WritePid(string pid) { }

	// RVA: 0x1D461F0 Offset: 0x1D462F1 VA: 0x1D461F0
	public void WriteJid(string jid) { }

	// RVA: 0x1D462C0 Offset: 0x1D463C1 VA: 0x1D462C0
	public void WriteSid(string sid) { }

	// RVA: 0x1D46390 Offset: 0x1D46491 VA: 0x1D46390
	public void WriteEffectName(string name) { }

	// RVA: 0x1D46460 Offset: 0x1D46561 VA: 0x1D46460
	public void WriteMaterialString(string str) { }

	// RVA: 0x1D46530 Offset: 0x1D46631 VA: 0x1D46530
	public void WriteRnid(string rnid) { }

	// RVA: 0x1D46600 Offset: 0x1D46701 VA: 0x1D46600
	public void WriteRandom(Random random) { }

	// RVA: 0x1D46640 Offset: 0x1D46741 VA: 0x1D46640
	public int get_Type() { }

	// RVA: 0x1D46650 Offset: 0x1D46751 VA: 0x1D46650
	public int get_Size() { }
}

// Namespace: 
private abstract class MapHistory.Base<T> // TypeDefIndex: 12036
{
	// Fields
	protected const int StreamAdditionalSize = 4;
	protected byte[] m_CommandStreamBuffer; // 0x0
	protected Stream m_CommandStream; // 0x0
	protected MapHistory.Command[] m_Commands; // 0x0
	protected int m_NumCommand; // 0x0
	protected int m_NumSplit; // 0x0
	private static T s_Instance; // 0x0

	// Properties
	public int CurrentIndex { get; }
	protected virtual uint CommandStreamBufferSize { get; }
	protected virtual uint MaxCommandCount { get; }
	public static T Instance { get; }

	// Methods

	// RVA: -1 Offset: -1
	private void Initialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF94B0 Offset: 0x1DF95B1 VA: 0x1DF94B0
	|-MapHistory.Base<object>.Initialize
	*/

	// RVA: -1 Offset: -1 Slot: 4
	protected virtual void OnInitialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF95D0 Offset: 0x1DF96D1 VA: 0x1DF95D0
	|-MapHistory.Base<object>.OnInitialize
	*/

	// RVA: -1 Offset: -1
	private void Delete() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF95E0 Offset: 0x1DF96E1 VA: 0x1DF95E0
	|-MapHistory.Base<object>.Delete
	*/

	// RVA: -1 Offset: -1 Slot: 5
	protected virtual void OnDelete() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF95F0 Offset: 0x1DF96F1 VA: 0x1DF95F0
	|-MapHistory.Base<object>.OnDelete
	*/

	// RVA: -1 Offset: -1
	protected bool Add(MapHistory.CommandWriter writer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF9600 Offset: 0x1DF9701 VA: 0x1DF9600
	|-MapHistory.Base<object>.Add
	|-MapHistory.Base<MapHistory.Replay>.Add
	|-MapHistory.Base<MapHistory.Rewind>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected virtual void Preadd(MapHistory.CommandWriter writer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF96E0 Offset: 0x1DF97E1 VA: 0x1DF96E0
	|-MapHistory.Base<object>.Preadd
	|-MapHistory.Base<MapHistory.Replay>.Preadd
	*/

	// RVA: -1 Offset: -1
	protected bool AddSplit(MapHistory.CommandWriter writer, byte arg = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF96F0 Offset: 0x1DF97F1 VA: 0x1DF96F0
	|-MapHistory.Base<object>.AddSplit
	|-MapHistory.Base<MapHistory.Replay>.AddSplit
	|-MapHistory.Base<MapHistory.Rewind>.AddSplit
	*/

	// RVA: -1 Offset: -1
	protected bool Overwrite(MapHistory.CommandWriter writer, int commandIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF9760 Offset: 0x1DF9861 VA: 0x1DF9760
	|-MapHistory.Base<object>.Overwrite
	|-MapHistory.Base<MapHistory.Replay>.Overwrite
	*/

	// RVA: -1 Offset: -1
	protected void CommandStackCancel(Unit unit, int targetCommandType, int relatedCommandType = -1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF9840 Offset: 0x1DF9941 VA: 0x1DF9840
	|-MapHistory.Base<object>.CommandStackCancel
	|-MapHistory.Base<MapHistory.Replay>.CommandStackCancel
	|-MapHistory.Base<MapHistory.Rewind>.CommandStackCancel
	*/

	// RVA: -1 Offset: -1 Slot: 7
	protected virtual int GetCommandEngage() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF9970 Offset: 0x1DF9A71 VA: 0x1DF9970
	|-MapHistory.Base<object>.GetCommandEngage
	*/

	// RVA: -1 Offset: -1 Slot: 8
	protected virtual int GetCommandGodChange() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF9980 Offset: 0x1DF9A81 VA: 0x1DF9980
	|-MapHistory.Base<object>.GetCommandGodChange
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected virtual int GetCommandUnitItemList() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF9990 Offset: 0x1DF9A91 VA: 0x1DF9990
	|-MapHistory.Base<object>.GetCommandUnitItemList
	|-MapHistory.Base<MapHistory.Rewind>.GetCommandUnitItemList
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected virtual Unit GetUnitForCommandEngage(int commandIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF99A0 Offset: 0x1DF9AA1 VA: 0x1DF99A0
	|-MapHistory.Base<object>.GetUnitForCommandEngage
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected virtual Unit GetUnitForCommandGodChange(int commandIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF99B0 Offset: 0x1DF9AB1 VA: 0x1DF99B0
	|-MapHistory.Base<object>.GetUnitForCommandGodChange
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected virtual Unit GetUnitForCommandUnitItemList(int commandIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF99C0 Offset: 0x1DF9AC1 VA: 0x1DF99C0
	|-MapHistory.Base<object>.GetUnitForCommandUnitItemList
	|-MapHistory.Base<MapHistory.Rewind>.GetUnitForCommandUnitItemList
	*/

	// RVA: -1 Offset: -1
	protected bool TryDeleteCommand(int commandIndex, Unit unit, int targetCommandType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF99D0 Offset: 0x1DF9AD1 VA: 0x1DF99D0
	|-MapHistory.Base<object>.TryDeleteCommand
	*/

	// RVA: -1 Offset: -1
	protected bool DeleteCommand(int commandIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF9B00 Offset: 0x1DF9C01 VA: 0x1DF9B00
	|-MapHistory.Base<object>.DeleteCommand
	*/

	// RVA: -1 Offset: -1 Slot: 13
	protected virtual void PredeleteCommand(int commandIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF9D20 Offset: 0x1DF9E21 VA: 0x1DF9D20
	|-MapHistory.Base<object>.PredeleteCommand
	|-MapHistory.Base<MapHistory.Replay>.PredeleteCommand
	*/

	// RVA: -1 Offset: -1 Slot: 14
	protected virtual void DeleteCommandError() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF9D30 Offset: 0x1DF9E31 VA: 0x1DF9D30
	|-MapHistory.Base<object>.DeleteCommandError
	|-MapHistory.Base<MapHistory.Replay>.DeleteCommandError
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF9D40 Offset: 0x1DF9E41 VA: 0x1DF9D40
	|-MapHistory.Base<object>.Clear
	|-MapHistory.Base<MapHistory.Rewind>.Clear
	*/

	// RVA: -1 Offset: -1
	public int get_CurrentIndex() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF9DD0 Offset: 0x1DF9ED1 VA: 0x1DF9DD0
	|-MapHistory.Base<object>.get_CurrentIndex
	|-MapHistory.Base<MapHistory.Rewind>.get_CurrentIndex
	*/

	// RVA: -1 Offset: -1
	public int GetLastSplitIndex() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF9DE0 Offset: 0x1DF9EE1 VA: 0x1DF9DE0
	|-MapHistory.Base<object>.GetLastSplitIndex
	|-MapHistory.Base<MapHistory.Rewind>.GetLastSplitIndex
	*/

	// RVA: -1 Offset: -1
	public int GetNextSplitIndex(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF9E60 Offset: 0x1DF9F61 VA: 0x1DF9E60
	|-MapHistory.Base<object>.GetNextSplitIndex
	|-MapHistory.Base<MapHistory.Rewind>.GetNextSplitIndex
	*/

	// RVA: -1 Offset: -1
	public int GetPrevSplitIndex(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF9ED0 Offset: 0x1DF9FD1 VA: 0x1DF9ED0
	|-MapHistory.Base<object>.GetPrevSplitIndex
	|-MapHistory.Base<MapHistory.Rewind>.GetPrevSplitIndex
	*/

	// RVA: -1 Offset: -1
	protected void SerializeCommands(Stream stream) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF9F30 Offset: 0x1DFA031 VA: 0x1DF9F30
	|-MapHistory.Base<object>.SerializeCommands
	|-MapHistory.Base<MapHistory.Replay>.SerializeCommands
	|-MapHistory.Base<MapHistory.Rewind>.SerializeCommands
	*/

	// RVA: -1 Offset: -1
	protected void DeserializeCommands(Stream stream) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF9FD0 Offset: 0x1DFA0D1 VA: 0x1DF9FD0
	|-MapHistory.Base<object>.DeserializeCommands
	|-MapHistory.Base<MapHistory.Replay>.DeserializeCommands
	|-MapHistory.Base<MapHistory.Rewind>.DeserializeCommands
	*/

	// RVA: -1 Offset: -1
	protected void SerializeCommandStream(Stream stream) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DFA180 Offset: 0x1DFA281 VA: 0x1DFA180
	|-MapHistory.Base<object>.SerializeCommandStream
	|-MapHistory.Base<MapHistory.Replay>.SerializeCommandStream
	|-MapHistory.Base<MapHistory.Rewind>.SerializeCommandStream
	*/

	// RVA: -1 Offset: -1
	protected void DeserializeCommandStream(Stream stream) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DFA1A0 Offset: 0x1DFA2A1 VA: 0x1DFA1A0
	|-MapHistory.Base<object>.DeserializeCommandStream
	|-MapHistory.Base<MapHistory.Replay>.DeserializeCommandStream
	|-MapHistory.Base<MapHistory.Rewind>.DeserializeCommandStream
	*/

	// RVA: -1 Offset: -1 Slot: 15
	protected virtual uint get_CommandStreamBufferSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DFA2C0 Offset: 0x1DFA3C1 VA: 0x1DFA2C0
	|-MapHistory.Base<object>.get_CommandStreamBufferSize
	|-MapHistory.Base<MapHistory.Replay>.get_CommandStreamBufferSize
	*/

	// RVA: -1 Offset: -1 Slot: 16
	protected virtual uint get_MaxCommandCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DFA2D0 Offset: 0x1DFA3D1 VA: 0x1DFA2D0
	|-MapHistory.Base<object>.get_MaxCommandCount
	|-MapHistory.Base<MapHistory.Replay>.get_MaxCommandCount
	|-MapHistory.Base<MapHistory.Rewind>.get_MaxCommandCount
	*/

	// RVA: -1 Offset: -1
	public static void TryCreateInstance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DFA2E0 Offset: 0x1DFA3E1 VA: 0x1DFA2E0
	|-MapHistory.Base<object>.TryCreateInstance
	|-MapHistory.Base<MapHistory.Replay>.TryCreateInstance
	|-MapHistory.Base<MapHistory.Rewind>.TryCreateInstance
	*/

	// RVA: -1 Offset: -1
	public static void TryDeleteInstance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DFA480 Offset: 0x1DFA581 VA: 0x1DFA480
	|-MapHistory.Base<object>.TryDeleteInstance
	|-MapHistory.Base<MapHistory.Replay>.TryDeleteInstance
	|-MapHistory.Base<MapHistory.Rewind>.TryDeleteInstance
	*/

	// RVA: -1 Offset: -1
	public static T get_Instance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DFA5C0 Offset: 0x1DFA6C1 VA: 0x1DFA5C0
	|-MapHistory.Base<object>.get_Instance
	|-MapHistory.Base<MapHistory.Replay>.get_Instance
	|-MapHistory.Base<MapHistory.Rewind>.get_Instance
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DFA610 Offset: 0x1DFA711 VA: 0x1DFA610
	|-MapHistory.Base<object>..ctor
	|-MapHistory.Base<MapHistory.Replay>..ctor
	|-MapHistory.Base<MapHistory.Rewind>..ctor
	*/
}

// Namespace: 
public interface MapHistory.UnitMapBase.IData<T, U> // TypeDefIndex: 12038
{
	// Properties
	public abstract Unit unit { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Unit get_unit();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_unit(Unit value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool IsUsed();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void Clear();
}

// Namespace: 
private class MapHistory.UnitMapBase<T, U> : SingletonClass<T> // TypeDefIndex: 12040
{
	// Fields
	protected const int MaxDataCount = 250;
	protected U[] m_Data; // 0x0
	protected MapHistory.UnitMapBase.NoEmptyFunction<T, U> m_NoEmptyFunction; // 0x0

	// Properties
	public MapHistory.UnitMapBase.NoEmptyFunction<T, U> NoEmpty { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF0A60 Offset: 0x2DF0B61 VA: 0x2DF0A60
	|-MapHistory.UnitMapBase<object, MapHistory.ReplayUnitMap.Data>..ctor
	|-MapHistory.UnitMapBase<MapHistory.ReplayUnitMap, MapHistory.ReplayUnitMap.Data>..ctor
	|
	|-RVA: 0x2DF10B0 Offset: 0x2DF11B1 VA: 0x2DF10B0
	|-MapHistory.UnitMapBase<object, MapHistory.RewindUnitMap.Data>..ctor
	|-MapHistory.UnitMapBase<MapHistory.RewindUnitMap, MapHistory.RewindUnitMap.Data>..ctor
	*/

	// RVA: -1 Offset: -1
	public void EntryAll() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF0B70 Offset: 0x2DF0C71 VA: 0x2DF0B70
	|-MapHistory.UnitMapBase<object, MapHistory.ReplayUnitMap.Data>.EntryAll
	|-MapHistory.UnitMapBase<MapHistory.ReplayUnitMap, MapHistory.ReplayUnitMap.Data>.EntryAll
	|
	|-RVA: 0x2DF11C0 Offset: 0x2DF12C1 VA: 0x2DF11C0
	|-MapHistory.UnitMapBase<object, MapHistory.RewindUnitMap.Data>.EntryAll
	|-MapHistory.UnitMapBase<MapHistory.RewindUnitMap, MapHistory.RewindUnitMap.Data>.EntryAll
	*/

	// RVA: -1 Offset: -1
	protected void EntryAllImpl() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF0BF0 Offset: 0x2DF0CF1 VA: 0x2DF0BF0
	|-MapHistory.UnitMapBase<object, MapHistory.ReplayUnitMap.Data>.EntryAllImpl
	|
	|-RVA: 0x2DF1240 Offset: 0x2DF1341 VA: 0x2DF1240
	|-MapHistory.UnitMapBase<object, MapHistory.RewindUnitMap.Data>.EntryAllImpl
	|-MapHistory.UnitMapBase<MapHistory.RewindUnitMap, MapHistory.RewindUnitMap.Data>.EntryAllImpl
	*/

	// RVA: -1 Offset: -1
	public int Entry(Unit unit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF0CC0 Offset: 0x2DF0DC1 VA: 0x2DF0CC0
	|-MapHistory.UnitMapBase<object, MapHistory.ReplayUnitMap.Data>.Entry
	|-MapHistory.UnitMapBase<MapHistory.ReplayUnitMap, MapHistory.ReplayUnitMap.Data>.Entry
	|
	|-RVA: 0x2DF1310 Offset: 0x2DF1411 VA: 0x2DF1310
	|-MapHistory.UnitMapBase<object, MapHistory.RewindUnitMap.Data>.Entry
	|-MapHistory.UnitMapBase<MapHistory.RewindUnitMap, MapHistory.RewindUnitMap.Data>.Entry
	*/

	// RVA: -1 Offset: -1
	public void Delete(Unit unit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF0E30 Offset: 0x2DF0F31 VA: 0x2DF0E30
	|-MapHistory.UnitMapBase<object, MapHistory.ReplayUnitMap.Data>.Delete
	|-MapHistory.UnitMapBase<MapHistory.ReplayUnitMap, MapHistory.ReplayUnitMap.Data>.Delete
	|
	|-RVA: 0x2DF1480 Offset: 0x2DF1581 VA: 0x2DF1480
	|-MapHistory.UnitMapBase<object, MapHistory.RewindUnitMap.Data>.Delete
	*/

	// RVA: -1 Offset: -1
	public void Delete(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF0E90 Offset: 0x2DF0F91 VA: 0x2DF0E90
	|-MapHistory.UnitMapBase<object, MapHistory.ReplayUnitMap.Data>.Delete
	|
	|-RVA: 0x2DF14E0 Offset: 0x2DF15E1 VA: 0x2DF14E0
	|-MapHistory.UnitMapBase<object, MapHistory.RewindUnitMap.Data>.Delete
	|-MapHistory.UnitMapBase<MapHistory.RewindUnitMap, MapHistory.RewindUnitMap.Data>.Delete
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF0EE0 Offset: 0x2DF0FE1 VA: 0x2DF0EE0
	|-MapHistory.UnitMapBase<object, MapHistory.ReplayUnitMap.Data>.Clear
	|
	|-RVA: 0x2DF1530 Offset: 0x2DF1631 VA: 0x2DF1530
	|-MapHistory.UnitMapBase<object, MapHistory.RewindUnitMap.Data>.Clear
	|-MapHistory.UnitMapBase<MapHistory.RewindUnitMap, MapHistory.RewindUnitMap.Data>.Clear
	*/

	// RVA: -1 Offset: -1
	public Unit TryGet(int index, bool withError = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF0F50 Offset: 0x2DF1051 VA: 0x2DF0F50
	|-MapHistory.UnitMapBase<object, MapHistory.ReplayUnitMap.Data>.TryGet
	|-MapHistory.UnitMapBase<MapHistory.ReplayUnitMap, MapHistory.ReplayUnitMap.Data>.TryGet
	|
	|-RVA: 0x2DF15A0 Offset: 0x2DF16A1 VA: 0x2DF15A0
	|-MapHistory.UnitMapBase<object, MapHistory.RewindUnitMap.Data>.TryGet
	|-MapHistory.UnitMapBase<MapHistory.RewindUnitMap, MapHistory.RewindUnitMap.Data>.TryGet
	*/

	// RVA: -1 Offset: -1
	public MapHistory.UnitMapBase.NoEmptyFunction<T, U> get_NoEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF0FA0 Offset: 0x2DF10A1 VA: 0x2DF0FA0
	|-MapHistory.UnitMapBase<object, MapHistory.ReplayUnitMap.Data>.get_NoEmpty
	|
	|-RVA: 0x2DF15F0 Offset: 0x2DF16F1 VA: 0x2DF15F0
	|-MapHistory.UnitMapBase<object, MapHistory.RewindUnitMap.Data>.get_NoEmpty
	*/

	// RVA: -1 Offset: -1
	public void set_NoEmpty(MapHistory.UnitMapBase.NoEmptyFunction<T, U> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF0FB0 Offset: 0x2DF10B1 VA: 0x2DF0FB0
	|-MapHistory.UnitMapBase<object, MapHistory.ReplayUnitMap.Data>.set_NoEmpty
	|
	|-RVA: 0x2DF1600 Offset: 0x2DF1701 VA: 0x2DF1600
	|-MapHistory.UnitMapBase<object, MapHistory.RewindUnitMap.Data>.set_NoEmpty
	|-MapHistory.UnitMapBase<MapHistory.RewindUnitMap, MapHistory.RewindUnitMap.Data>.set_NoEmpty
	*/

	// RVA: -1 Offset: -1
	protected int FindUnusedIndex() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF0FC0 Offset: 0x2DF10C1 VA: 0x2DF0FC0
	|-MapHistory.UnitMapBase<object, MapHistory.ReplayUnitMap.Data>.FindUnusedIndex
	|
	|-RVA: 0x2DF1610 Offset: 0x2DF1711 VA: 0x2DF1610
	|-MapHistory.UnitMapBase<object, MapHistory.RewindUnitMap.Data>.FindUnusedIndex
	*/

	[ConditionalAttribute] // RVA: 0x2C74C0 Offset: 0x2C75C1 VA: 0x2C74C0
	// RVA: -1 Offset: -1
	public void DbgDump(StringBuilder sb) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF1030 Offset: 0x2DF1131 VA: 0x2DF1030
	|-MapHistory.UnitMapBase<object, MapHistory.ReplayUnitMap.Data>.DbgDump
	|
	|-RVA: 0x2DF1680 Offset: 0x2DF1781 VA: 0x2DF1680
	|-MapHistory.UnitMapBase<object, MapHistory.RewindUnitMap.Data>.DbgDump
	*/

	[ConditionalAttribute] // RVA: 0x2C7500 Offset: 0x2C7601 VA: 0x2C7500
	// RVA: -1 Offset: -1
	protected void DbgError(string message) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF1040 Offset: 0x2DF1141 VA: 0x2DF1040
	|-MapHistory.UnitMapBase<object, MapHistory.ReplayUnitMap.Data>.DbgError
	|
	|-RVA: 0x2DF1690 Offset: 0x2DF1791 VA: 0x2DF1690
	|-MapHistory.UnitMapBase<object, MapHistory.RewindUnitMap.Data>.DbgError
	*/

	[CompilerGeneratedAttribute] // RVA: 0x2C7540 Offset: 0x2C7641 VA: 0x2C7540
	// RVA: -1 Offset: -1
	private void <EntryAllImpl>b__7_0(Unit unit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF1050 Offset: 0x2DF1151 VA: 0x2DF1050
	|-MapHistory.UnitMapBase<object, MapHistory.ReplayUnitMap.Data>.<EntryAllImpl>b__7_0
	|
	|-RVA: 0x2DF16A0 Offset: 0x2DF17A1 VA: 0x2DF16A0
	|-MapHistory.UnitMapBase<object, MapHistory.RewindUnitMap.Data>.<EntryAllImpl>b__7_0
	*/

	[CompilerGeneratedAttribute] // RVA: 0x2C7550 Offset: 0x2C7651 VA: 0x2C7550
	// RVA: -1 Offset: -1
	private void <EntryAllImpl>b__7_1(Unit unit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DF1080 Offset: 0x2DF1181 VA: 0x2DF1080
	|-MapHistory.UnitMapBase<object, MapHistory.ReplayUnitMap.Data>.<EntryAllImpl>b__7_1
	|
	|-RVA: 0x2DF16D0 Offset: 0x2DF17D1 VA: 0x2DF16D0
	|-MapHistory.UnitMapBase<object, MapHistory.RewindUnitMap.Data>.<EntryAllImpl>b__7_1
	*/
}

// Namespace: 
private abstract class MapHistory.IdMap<T> : MapHistory.IdMapBase<T> // TypeDefIndex: 12042
{
	// Properties
	protected override int Version { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EAFB00 Offset: 0x1EAFC01 VA: 0x1EAFB00
	|-MapHistory.IdMap<object>..ctor
	|-MapHistory.IdMap<MapHistory.EffectNameMap>..ctor
	|-MapHistory.IdMap<MapHistory.GidMap>..ctor
	|-MapHistory.IdMap<MapHistory.IidMap>..ctor
	|-MapHistory.IdMap<MapHistory.JidMap>..ctor
	|-MapHistory.IdMap<MapHistory.MaterialStringMap>..ctor
	|-MapHistory.IdMap<MapHistory.PidMap>..ctor
	|-MapHistory.IdMap<MapHistory.RnidMap>..ctor
	|-MapHistory.IdMap<MapHistory.SidMap>..ctor
	|-MapHistory.IdMap<MapHistory.TidMap>..ctor
	|-MapHistory.IdMap<MapHistory.VariableMap>..ctor
	*/

	// RVA: -1 Offset: -1
	public int Entry(string id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EAFB20 Offset: 0x1EAFC21 VA: 0x1EAFB20
	|-MapHistory.IdMap<object>.Entry
	|-MapHistory.IdMap<MapHistory.EffectNameMap>.Entry
	|-MapHistory.IdMap<MapHistory.GidMap>.Entry
	|-MapHistory.IdMap<MapHistory.IidMap>.Entry
	|-MapHistory.IdMap<MapHistory.JidMap>.Entry
	|-MapHistory.IdMap<MapHistory.MaterialStringMap>.Entry
	|-MapHistory.IdMap<MapHistory.PidMap>.Entry
	|-MapHistory.IdMap<MapHistory.RnidMap>.Entry
	|-MapHistory.IdMap<MapHistory.SidMap>.Entry
	|-MapHistory.IdMap<MapHistory.TidMap>.Entry
	|-MapHistory.IdMap<MapHistory.VariableMap>.Entry
	*/

	// RVA: -1 Offset: -1
	public string TryGet(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EAFB40 Offset: 0x1EAFC41 VA: 0x1EAFB40
	|-MapHistory.IdMap<object>.TryGet
	|-MapHistory.IdMap<MapHistory.EffectNameMap>.TryGet
	|-MapHistory.IdMap<MapHistory.GidMap>.TryGet
	|-MapHistory.IdMap<MapHistory.IidMap>.TryGet
	|-MapHistory.IdMap<MapHistory.JidMap>.TryGet
	|-MapHistory.IdMap<MapHistory.MaterialStringMap>.TryGet
	|-MapHistory.IdMap<MapHistory.PidMap>.TryGet
	|-MapHistory.IdMap<MapHistory.RnidMap>.TryGet
	|-MapHistory.IdMap<MapHistory.SidMap>.TryGet
	|-MapHistory.IdMap<MapHistory.TidMap>.TryGet
	|-MapHistory.IdMap<MapHistory.VariableMap>.TryGet
	*/

	// RVA: -1 Offset: -1 Slot: 4
	protected override int get_Version() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EAFB60 Offset: 0x1EAFC61 VA: 0x1EAFB60
	|-MapHistory.IdMap<object>.get_Version
	|-MapHistory.IdMap<MapHistory.EffectNameMap>.get_Version
	|-MapHistory.IdMap<MapHistory.GidMap>.get_Version
	|-MapHistory.IdMap<MapHistory.IidMap>.get_Version
	|-MapHistory.IdMap<MapHistory.JidMap>.get_Version
	|-MapHistory.IdMap<MapHistory.MaterialStringMap>.get_Version
	|-MapHistory.IdMap<MapHistory.PidMap>.get_Version
	|-MapHistory.IdMap<MapHistory.RnidMap>.get_Version
	|-MapHistory.IdMap<MapHistory.SidMap>.get_Version
	|-MapHistory.IdMap<MapHistory.TidMap>.get_Version
	|-MapHistory.IdMap<MapHistory.VariableMap>.get_Version
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected override void OnSerialize(Stream stream) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EAFB70 Offset: 0x1EAFC71 VA: 0x1EAFB70
	|-MapHistory.IdMap<object>.OnSerialize
	|-MapHistory.IdMap<MapHistory.EffectNameMap>.OnSerialize
	|-MapHistory.IdMap<MapHistory.GidMap>.OnSerialize
	|-MapHistory.IdMap<MapHistory.IidMap>.OnSerialize
	|-MapHistory.IdMap<MapHistory.JidMap>.OnSerialize
	|-MapHistory.IdMap<MapHistory.MaterialStringMap>.OnSerialize
	|-MapHistory.IdMap<MapHistory.PidMap>.OnSerialize
	|-MapHistory.IdMap<MapHistory.RnidMap>.OnSerialize
	|-MapHistory.IdMap<MapHistory.SidMap>.OnSerialize
	|-MapHistory.IdMap<MapHistory.TidMap>.OnSerialize
	|-MapHistory.IdMap<MapHistory.VariableMap>.OnSerialize
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected override void OnDeserialize(Stream stream, int version) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EAFC40 Offset: 0x1EAFD41 VA: 0x1EAFC40
	|-MapHistory.IdMap<object>.OnDeserialize
	|-MapHistory.IdMap<MapHistory.EffectNameMap>.OnDeserialize
	|-MapHistory.IdMap<MapHistory.GidMap>.OnDeserialize
	|-MapHistory.IdMap<MapHistory.IidMap>.OnDeserialize
	|-MapHistory.IdMap<MapHistory.JidMap>.OnDeserialize
	|-MapHistory.IdMap<MapHistory.MaterialStringMap>.OnDeserialize
	|-MapHistory.IdMap<MapHistory.PidMap>.OnDeserialize
	|-MapHistory.IdMap<MapHistory.RnidMap>.OnDeserialize
	|-MapHistory.IdMap<MapHistory.SidMap>.OnDeserialize
	|-MapHistory.IdMap<MapHistory.TidMap>.OnDeserialize
	|-MapHistory.IdMap<MapHistory.VariableMap>.OnDeserialize
	*/
}

// Namespace: 
private class MapHistory.GidMap : MapHistory.IdMap<MapHistory.GidMap> // TypeDefIndex: 12044
{
	// Methods

	// RVA: 0x1D466C0 Offset: 0x1D467C1 VA: 0x1D466C0
	public void .ctor() { }
}

// Namespace: 
private class MapHistory.IidMap : MapHistory.IdMap<MapHistory.IidMap> // TypeDefIndex: 12046
{
	// Methods

	// RVA: 0x1D46720 Offset: 0x1D46821 VA: 0x1D46720
	public void .ctor() { }
}

// Namespace: 
private class MapHistory.JidMap : MapHistory.IdMap<MapHistory.JidMap> // TypeDefIndex: 12048
{
	// Methods

	// RVA: 0x1D46780 Offset: 0x1D46881 VA: 0x1D46780
	public void .ctor() { }
}

// Namespace: 
private class MapHistory.RnidMap : MapHistory.IdMap<MapHistory.RnidMap> // TypeDefIndex: 12050
{
	// Methods

	// RVA: 0x2402260 Offset: 0x2402361 VA: 0x2402260
	public void .ctor() { }
}

// Namespace: 
private class MapHistory.MaterialStringMap : MapHistory.IdMap<MapHistory.MaterialStringMap> // TypeDefIndex: 12052
{
	// Methods

	// RVA: 0x1D467E0 Offset: 0x1D468E1 VA: 0x1D467E0
	public void .ctor() { }
}

// Namespace: 
private struct MapHistory.Replay.OverwriteStreamScope : IDisposable // TypeDefIndex: 12054
{
	// Fields
	private Stream m_Stream; // 0x0
	private int m_SavedPos; // 0x8

	// Methods

	// RVA: 0x21E2E50 Offset: 0x21E2F51 VA: 0x21E2E50
	public void .ctor(Stream stream, int overwritePos) { }

	// RVA: 0x21E2EA0 Offset: 0x21E2FA1 VA: 0x21E2EA0 Slot: 4
	public void Dispose() { }
}

// Namespace: 
private class MapHistory.Replay.SaveAsync : ProcInst // TypeDefIndex: 12056
{
	// Fields
	private static MapHistory.Replay.SaveAsyncThread s_Thread; // 0x0
	private MapHistory.Replay.SaveAsync.SaveMethod m_SaveMethod; // 0x70

	// Methods

	// RVA: 0x21E2EC0 Offset: 0x21E2FC1 VA: 0x21E2EC0
	private void .ctor(MapHistory.Replay.SaveAsync.SaveMethod method) { }

	// RVA: 0x21E2F00 Offset: 0x21E3001 VA: 0x21E2F00
	private void Start() { }

	// RVA: 0x21E2FE0 Offset: 0x21E30E1 VA: 0x21E2FE0
	private bool IsRunning() { }

	// RVA: 0x21E3110 Offset: 0x21E3211 VA: 0x21E3110
	public static void CreateBind(ProcInst super, MapHistory.Replay.SaveAsync.SaveMethod saveMethod) { }

	// RVA: 0x21E3370 Offset: 0x21E3471 VA: 0x21E3370
	public static void CreateThread() { }

	// RVA: 0x21E3590 Offset: 0x21E3691 VA: 0x21E3590
	public static void DestroyThread() { }
}

// Namespace: 
private class MapHistory.Replay.SaveAsyncThread // TypeDefIndex: 12058
{
	// Fields
	private Thread m_Thread; // 0x10
	private object m_Lock; // 0x18
	private AutoResetEvent m_Event; // 0x20
	private MapHistory.Replay.SaveAsyncThread.Status m_Status; // 0x28
	private MapHistory.Replay.SaveAsync.SaveMethod m_SaveMethod; // 0x30

	// Methods

	// RVA: 0x21E3400 Offset: 0x21E3501 VA: 0x21E3400
	public void .ctor() { }

	// RVA: 0x21E2F90 Offset: 0x21E3091 VA: 0x21E2F90
	public void Start(MapHistory.Replay.SaveAsync.SaveMethod method) { }

	// RVA: 0x21E3030 Offset: 0x21E3131 VA: 0x21E3030
	public bool IsRunning() { }

	// RVA: 0x21E3640 Offset: 0x21E3741 VA: 0x21E3640
	public void Destroy() { }

	// RVA: 0x21E36A0 Offset: 0x21E37A1 VA: 0x21E36A0
	public static void ThreadFunction(object obj) { }
}

// Namespace: 
private class MapHistory.Replay : MapHistory.Base<MapHistory.Replay> // TypeDefIndex: 12060
{
	// Fields
	private const int Version = 4;
	private const byte SnapshotVersion = 3;
	private MapHistory.Mode m_Mode; // 0x30
	private MapHistory.ReplayCommandWriter m_Writer; // 0x38
	private MapHistory.ReplayCommandReader m_Reader; // 0x40
	private byte[] m_InitialStreamBuffer; // 0x48
	private Stream m_InitialStream; // 0x50
	private int m_LastEngageIndex; // 0x58
	private int m_FirstGodChangeIndex; // 0x5C
	private int m_LastGodChangeIndex; // 0x60
	private int m_FirstUnitItemListIndex; // 0x64
	private int m_ReadIndex; // 0x68
	private bool m_IsReadPhaseBegin; // 0x6C
	private GameConfig.AnimeType m_SavedBattleType; // 0x70
	private GameConfig.AnimeType m_SavedSupportType; // 0x74
	private GameConfig.EngageAnimeType m_SavedEngageAnim; // 0x78
	private List<byte> m_RelayTakeOverTurns; // 0x80

	// Methods

	// RVA: 0x1D468A0 Offset: 0x1D469A1 VA: 0x1D468A0 Slot: 4
	protected override void OnInitialize() { }

	// RVA: 0x1D46D00 Offset: 0x1D46E01 VA: 0x1D46D00 Slot: 5
	protected override void OnDelete() { }

	// RVA: 0x1D46FC0 Offset: 0x1D470C1 VA: 0x1D46FC0
	public void Begin(ProcInst super) { }

	// RVA: 0x1D470B0 Offset: 0x1D471B1 VA: 0x1D470B0
	public void End() { }

	// RVA: 0x1D47180 Offset: 0x1D47281 VA: 0x1D47180
	public void Split() { }

	// RVA: 0x1D47200 Offset: 0x1D47301 VA: 0x1D47200
	public void EngageCancel(Unit unit) { }

	// RVA: 0x1D47280 Offset: 0x1D47381 VA: 0x1D47280
	public void GodChangeCancel(Unit unit) { }

	// RVA: 0x1D47300 Offset: 0x1D47401 VA: 0x1D47300 Slot: 7
	protected override int GetCommandEngage() { }

	// RVA: 0x1D47310 Offset: 0x1D47411 VA: 0x1D47310 Slot: 8
	protected override int GetCommandGodChange() { }

	// RVA: 0x1D47320 Offset: 0x1D47421 VA: 0x1D47320 Slot: 9
	protected override int GetCommandUnitItemList() { }

	// RVA: 0x1D47330 Offset: 0x1D47431 VA: 0x1D47330 Slot: 10
	protected override Unit GetUnitForCommandEngage(int commandIndex) { }

	// RVA: 0x1D473D0 Offset: 0x1D474D1 VA: 0x1D473D0 Slot: 11
	protected override Unit GetUnitForCommandGodChange(int commandIndex) { }

	// RVA: 0x1D47470 Offset: 0x1D47571 VA: 0x1D47470 Slot: 12
	protected override Unit GetUnitForCommandUnitItemList(int commandIndex) { }

	// RVA: 0x1D47510 Offset: 0x1D47611 VA: 0x1D47510
	public void AfterCommandStackCancel(Unit unit) { }

	// RVA: 0x1D47700 Offset: 0x1D47801 VA: 0x1D47700
	public void SetReadMode() { }

	// RVA: 0x1D478F0 Offset: 0x1D479F1 VA: 0x1D478F0
	public bool IsReadMode() { }

	// RVA: 0x1D47900 Offset: 0x1D47A01 VA: 0x1D47900
	public bool Read() { }

	// RVA: 0x1D47BE0 Offset: 0x1D47CE1 VA: 0x1D47BE0
	public bool HasReadData() { }

	// RVA: 0x1D47C00 Offset: 0x1D47D01 VA: 0x1D47C00
	public bool IsReadDataLastTurn() { }

	// RVA: 0x1D47D50 Offset: 0x1D47E51 VA: 0x1D47D50
	public void SkipReadDataToLastTurn() { }

	// RVA: 0x1D47CA0 Offset: 0x1D47DA1 VA: 0x1D47CA0
	private void GetReadIndexAboutLastTurn(out int lastTurnIndex, out int thresholdIndex) { }

	// RVA: 0x1D48070 Offset: 0x1D48171 VA: 0x1D48070
	private int FindReadIndexOfLastTurn() { }

	// RVA: 0x1D48130 Offset: 0x1D48231 VA: 0x1D48130
	private int FindReadIndexOfPrevPhaseEnd(int phaseBeginIndex) { }

	// RVA: 0x1D48260 Offset: 0x1D48361 VA: 0x1D48260
	private int FindReadIndexOfSkippedPhaseNext(int startIndex) { }

	// RVA: 0x1D483C0 Offset: 0x1D484C1 VA: 0x1D483C0
	public void EndReadMode() { }

	// RVA: 0x1D48490 Offset: 0x1D48591 VA: 0x1D48490
	public void RegisterAllUnits() { }

	// RVA: 0x1D48530 Offset: 0x1D48631 VA: 0x1D48530
	public void RegisterAppearanceUnit(Unit unit) { }

	// RVA: 0x1D487A0 Offset: 0x1D488A1 VA: 0x1D487A0
	public void RegisterLeavingUnit(Unit unit) { }

	// RVA: 0x1D48940 Offset: 0x1D48A41 VA: 0x1D48940
	public void Leaving(Unit unit) { }

	// RVA: 0x1D489E0 Offset: 0x1D48AE1 VA: 0x1D489E0
	public bool GetAppearanceAndLeavingIndexes(out int[] appearanceIndexes, out int[] leavingIndexes) { }

	// RVA: 0x1D48E20 Offset: 0x1D48F21 VA: 0x1D48E20
	public Unit CreateAppearanceUnit(int index) { }

	// RVA: 0x1D48FF0 Offset: 0x1D490F1 VA: 0x1D48FF0
	public Unit GetLeavingUnit(int index) { }

	// RVA: 0x1D49190 Offset: 0x1D49291 VA: 0x1D49190
	public void RegisterRelayTakeOverTiming() { }

	// RVA: 0x1D49250 Offset: 0x1D49351 VA: 0x1D49250
	public bool IsRelayTakeOverTiming() { }

	// RVA: 0x1D493A0 Offset: 0x1D494A1 VA: 0x1D493A0
	public void DoTurnSave(ProcInst super) { }

	// RVA: 0x1D494A0 Offset: 0x1D495A1 VA: 0x1D494A0
	public void Serialize(Stream stream) { }

	// RVA: 0x1D49840 Offset: 0x1D49941 VA: 0x1D49840
	public void Deserialize(Stream stream) { }

	// RVA: 0x1D471F0 Offset: 0x1D472F1 VA: 0x1D471F0
	private bool CanWrite() { }

	// RVA: 0x1D46CF0 Offset: 0x1D46DF1 VA: 0x1D46CF0
	private void ClearSavedCommandIndex() { }

	// RVA: 0x1D47810 Offset: 0x1D47911 VA: 0x1D47810
	private void SetPlayersToReplay() { }

	// RVA: 0x1D47EE0 Offset: 0x1D47FE1 VA: 0x1D47EE0
	private void SetReplayPlayerForRelay() { }

	// RVA: 0x1D46FE0 Offset: 0x1D470E1 VA: 0x1D46FE0
	private void SerializeInitial(ProcInst super) { }

	// RVA: 0x1D47800 Offset: 0x1D47901 VA: 0x1D47800
	private void DeserializeInitial() { }

	// RVA: 0x1D49D30 Offset: 0x1D49E31 VA: 0x1D49D30
	private static void SerializeSnapshot(Stream stream) { }

	// RVA: 0x1D49FE0 Offset: 0x1D4A0E1 VA: 0x1D49FE0
	private static void DeserializeSnapshot(Stream stream) { }

	[ConditionalAttribute] // RVA: 0x2C75E0 Offset: 0x2C76E1 VA: 0x2C75E0
	// RVA: 0x1D4A5D0 Offset: 0x1D4A6D1 VA: 0x1D4A5D0
	public void DbgDump() { }

	// RVA: 0x1D4A9A0 Offset: 0x1D4AAA1 VA: 0x1D4A9A0
	public void PhaseBegin() { }

	// RVA: 0x1D4AB30 Offset: 0x1D4AC31 VA: 0x1D4AB30
	public void PhaseNext() { }

	// RVA: 0x1D4ABD0 Offset: 0x1D4ACD1 VA: 0x1D4ABD0
	public void CancelUnitCommand() { }

	// RVA: 0x1D4AF10 Offset: 0x1D4B011 VA: 0x1D4AF10
	public void Mind() { }

	// RVA: 0x1D4B3F0 Offset: 0x1D4B4F1 VA: 0x1D4B3F0
	public void Engage(Unit unit, Unit linkUnit) { }

	// RVA: 0x1D4AE50 Offset: 0x1D4AF51 VA: 0x1D4AE50
	private void OverwriteEngagePos(Stream stream, int x, int z) { }

	// RVA: 0x1D4B4D0 Offset: 0x1D4B5D1 VA: 0x1D4B4D0
	public void GodChange(Unit unit) { }

	// RVA: 0x1D4AEB0 Offset: 0x1D4AFB1 VA: 0x1D4AEB0
	private void OverwriteGodChangePos(Stream stream, int x, int z) { }

	// RVA: 0x1D4B7F0 Offset: 0x1D4B8F1 VA: 0x1D4B7F0
	private void ToggleGodChangeEnabled(Stream stream) { }

	// RVA: 0x1D4B840 Offset: 0x1D4B941 VA: 0x1D4B840
	public void Trade(Unit fromUnit, Unit toUnit) { }

	// RVA: 0x1D4B870 Offset: 0x1D4B971 VA: 0x1D4B870
	public void Trade(Unit unit) { }

	// RVA: 0x1D4B880 Offset: 0x1D4B981 VA: 0x1D4B880
	public void EquipItem(Unit unit) { }

	// RVA: 0x1D4B890 Offset: 0x1D4B991 VA: 0x1D4B890
	public void TakeOffItem(Unit unit) { }

	// RVA: 0x1D4B8A0 Offset: 0x1D4B9A1 VA: 0x1D4B8A0
	public void SortItem(Unit unit) { }

	// RVA: 0x1D4B8B0 Offset: 0x1D4B9B1 VA: 0x1D4B8B0
	public void PutOffItem(Unit unit, bool fromMenu) { }

	// RVA: 0x1D47520 Offset: 0x1D47621 VA: 0x1D47520
	private void UnitItemList(Unit unit) { }

	// RVA: 0x1D4BA30 Offset: 0x1D4BB31 VA: 0x1D4BA30
	public void Dead(Unit unit) { }

	// RVA: 0x1D4BAF0 Offset: 0x1D4BBF1 VA: 0x1D4BAF0
	public void Dispos(Unit unit) { }

	// RVA: 0x1D4BBB0 Offset: 0x1D4BCB1 VA: 0x1D4BBB0
	public void VisionDelete(Unit unit) { }

	// RVA: 0x1D4BBC0 Offset: 0x1D4BCC1 VA: 0x1D4BBC0
	public void Surrender() { }

	// RVA: 0x1D4BC30 Offset: 0x1D4BD31 VA: 0x1D4BC30
	public void SummonDelete(Unit unit) { }

	// RVA: 0x1D47960 Offset: 0x1D47A61 VA: 0x1D47960
	private MapHistory.Replay.ReadResult ReadOne(int index) { }

	// RVA: 0x1D4BC40 Offset: 0x1D4BD41 VA: 0x1D4BC40
	private MapHistory.Replay.ReadResult ReadPhaseBegin() { }

	// RVA: 0x1D481C0 Offset: 0x1D482C1 VA: 0x1D481C0
	private void ReadPhaseBegin(out Force.Type force, Random random) { }

	// RVA: 0x1D4BCE0 Offset: 0x1D4BDE1 VA: 0x1D4BCE0
	private MapHistory.Replay.ReadResult ReadPhaseNext() { }

	// RVA: 0x1D4BDA0 Offset: 0x1D4BEA1 VA: 0x1D4BDA0
	private MapHistory.Replay.ReadResult ReadMind() { }

	// RVA: 0x1D4C3A0 Offset: 0x1D4C4A1 VA: 0x1D4C3A0
	private MapHistory.Replay.ReadResult ReadEngage() { }

	// RVA: 0x1D473A0 Offset: 0x1D474A1 VA: 0x1D473A0
	private void ReadEngage(out Unit unit) { }

	// RVA: 0x1D4C520 Offset: 0x1D4C621 VA: 0x1D4C520
	private MapHistory.Replay.ReadResult ReadGodChange() { }

	// RVA: 0x1D47440 Offset: 0x1D47541 VA: 0x1D47440
	private void ReadGodChange(out Unit unit) { }

	// RVA: 0x1D4C6E0 Offset: 0x1D4C7E1 VA: 0x1D4C6E0
	private MapHistory.Replay.ReadResult ReadUnitItemList() { }

	// RVA: 0x1D474E0 Offset: 0x1D475E1 VA: 0x1D474E0
	private void ReadUnitItemList(out Unit unit) { }

	// RVA: 0x1D4C730 Offset: 0x1D4C831 VA: 0x1D4C730
	private MapHistory.Replay.ReadResult ReadSurrender() { }

	// RVA: 0x1D4C9C0 Offset: 0x1D4CAC1 VA: 0x1D4C9C0
	private void SetupMindRoutes(Unit unit) { }

	[ConditionalAttribute] // RVA: 0x2C7620 Offset: 0x2C7721 VA: 0x2C7620
	// RVA: 0x1D4CC80 Offset: 0x1D4CD81 VA: 0x1D4CC80
	private void DbgDumpCommand(StringBuilder sb, int index) { }

	// RVA: 0x1D4CC90 Offset: 0x1D4CD91 VA: 0x1D4CC90
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C7660 Offset: 0x2C7761 VA: 0x2C7660
	// RVA: 0x1D4CCF0 Offset: 0x1D4CDF1 VA: 0x1D4CCF0
	private void <SerializeInitial>b__58_0() { }
}

// Namespace: 
private class MapHistory.ReplayCommandWriter : MapHistory.CommandWriter // TypeDefIndex: 12062
{
	// Methods

	// RVA: 0x1D4AAF0 Offset: 0x1D4ABF1 VA: 0x1D4AAF0
	public void Prepare(MapHistory.ReplayType type) { }

	// RVA: 0x1D4B1D0 Offset: 0x1D4B2D1 VA: 0x1D4B1D0
	public void WriteUnit(Unit unit) { }

	// RVA: 0x1D4E0B0 Offset: 0x1D4E1B1 VA: 0x1D4E0B0
	public void WriteUnitItem(UnitItem item) { }

	// RVA: 0x1D4B920 Offset: 0x1D4BA21 VA: 0x1D4B920
	public void WriteUnitItemList(UnitItemList itemList) { }

	// RVA: 0x1D4B290 Offset: 0x1D4B391 VA: 0x1D4B290
	public void WriteMultiTargets(MapMind.MultiTargets targets) { }

	// RVA: 0x1D4AB20 Offset: 0x1D4AC21 VA: 0x1D4AB20
	public void WriteForce(Force.Type forceType) { }

	// RVA: 0x1D46CD0 Offset: 0x1D46DD1 VA: 0x1D46CD0
	public void .ctor() { }
}

// Namespace: 
public struct MapHistory.ReplayUnitMap.Data : MapHistory.UnitMapBase.IData<MapHistory.ReplayUnitMap, MapHistory.ReplayUnitMap.Data> // TypeDefIndex: 12064
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x299AD0 Offset: 0x299BD1 VA: 0x299AD0
	private Unit <unit>k__BackingField; // 0x0

	// Properties
	public Unit unit { get; set; }

	// Methods

	[IsReadOnlyAttribute] // RVA: 0x2C7670 Offset: 0x2C7771 VA: 0x2C7670
	[CompilerGeneratedAttribute] // RVA: 0x2C7670 Offset: 0x2C7771 VA: 0x2C7670
	// RVA: 0x21E3C60 Offset: 0x21E3D61 VA: 0x21E3C60 Slot: 4
	public Unit get_unit() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C76B0 Offset: 0x2C77B1 VA: 0x2C76B0
	// RVA: 0x21E3C70 Offset: 0x21E3D71 VA: 0x21E3C70 Slot: 5
	public void set_unit(Unit value) { }

	// RVA: 0x21E3C80 Offset: 0x21E3D81 VA: 0x21E3C80 Slot: 6
	public bool IsUsed() { }

	// RVA: 0x21E3C90 Offset: 0x21E3D91 VA: 0x21E3C90 Slot: 7
	public void Clear() { }
}

// Namespace: 
private struct MapHistory.ReplayAppearanceMap.Appearance // TypeDefIndex: 12066
{
	// Fields
	public byte turn; // 0x0
	public byte[] buffer; // 0x8
	public Stream stream; // 0x10
}

// Namespace: 
private class MapHistory.ReplayAppearanceMap : SingletonClass<MapHistory.ReplayAppearanceMap> // TypeDefIndex: 12068
{
	// Fields
	private const int MaxTurn = 50;
	private const int MaxAppearancePerTurn = 10;
	private const int MaxLeavingPerTurn = 10;
	private const int MaxAppearance = 500;
	private const int MaxLeaving = 500;
	private const int AppearanceStreamBufferSize = 5376;
	private MapHistory.ReplayAppearanceMap.Appearance[] m_Appearances; // 0x20
	private int m_AppearanceCount; // 0x28
	private MapHistory.ReplayAppearanceMap.Leaving[] m_Leavings; // 0x30
	private int m_LeavingCount; // 0x38
	private int[] m_RetAppearanceIndexes; // 0x40
	private int[] m_RetLeavingIndexes; // 0x48

	// Properties
	protected override int Version { get; }

	// Methods

	// RVA: 0x1D4CD00 Offset: 0x1D4CE01 VA: 0x1D4CD00 Slot: 5
	protected override void OnCreate() { }

	// RVA: 0x1D48640 Offset: 0x1D48741 VA: 0x1D48640
	public int RegisterAppearanceUnit(Unit unit) { }

	// RVA: 0x1D48850 Offset: 0x1D48951 VA: 0x1D48850
	public int RegisterLeavingUnit(Unit unit) { }

	// RVA: 0x1D48AB0 Offset: 0x1D48BB1 VA: 0x1D48AB0
	public bool GetIndexes(out int[] appearanceIndexes, out int[] leavingIndexes) { }

	// RVA: 0x1D48F80 Offset: 0x1D49081 VA: 0x1D48F80
	public Unit CreateAppearanceUnit(int index) { }

	// RVA: 0x1D490A0 Offset: 0x1D491A1 VA: 0x1D490A0
	public Unit GetLeavingUnit(int index) { }

	// RVA: 0x1D4CE00 Offset: 0x1D4CF01 VA: 0x1D4CE00
	private void SerializeForAppearance(Stream stream, Unit unit) { }

	// RVA: 0x1D4CF70 Offset: 0x1D4D071 VA: 0x1D4CF70
	private Unit DeserializeForAppearance(Stream stream) { }

	// RVA: 0x1D4D260 Offset: 0x1D4D361 VA: 0x1D4D260 Slot: 4
	protected override int get_Version() { }

	// RVA: 0x1D4D270 Offset: 0x1D4D371 VA: 0x1D4D270 Slot: 11
	protected override void OnSerialize(Stream stream) { }

	// RVA: 0x1D4D3B0 Offset: 0x1D4D4B1 VA: 0x1D4D3B0 Slot: 12
	protected override void OnDeserialize(Stream stream, int version) { }

	[ConditionalAttribute] // RVA: 0x2C76C0 Offset: 0x2C77C1 VA: 0x2C76C0
	// RVA: 0x1D4D7A0 Offset: 0x1D4D8A1 VA: 0x1D4D7A0
	public void DbgDump(StringBuilder sb) { }

	// RVA: 0x1D4DAD0 Offset: 0x1D4DBD1 VA: 0x1D4DAD0
	public void .ctor() { }
}

// Namespace: 
private enum MapHistory.Rewind.WriterKind // TypeDefIndex: 12070
{
	// Fields
	public int value__; // 0x0
	public const MapHistory.Rewind.WriterKind Common = 0;
	public const MapHistory.Rewind.WriterKind TerrainSet = 1;
	public const MapHistory.Rewind.WriterKind Overlap = 2;
	public const MapHistory.Rewind.WriterKind Num = 3;
}

// Namespace: 
private enum MapHistory.Rewind.InspectorType // TypeDefIndex: 12072
{
	// Fields
	public int value__; // 0x0
	public const MapHistory.Rewind.InspectorType Cannon = 0;
	public const MapHistory.Rewind.InspectorType Breakable = 1;
}

// Namespace: 
private class MapHistory.Rewind.BattleCalcData // TypeDefIndex: 12074
{
	// Fields
	private List<Unit> m_SavedUnits; // 0x10
	private List<Unit> m_WorkUnits; // 0x18
	private List<PokeInspector> m_SavedInspectors; // 0x20
	private List<PokeInspector> m_WorkInspectors; // 0x28
	private List<MapOverlap.Data> m_SavedOverlaps; // 0x30
	private List<MapOverlap.Data> m_WorkOverlaps; // 0x38

	// Methods

	// RVA: 0x21E3DB0 Offset: 0x21E3EB1 VA: 0x21E3DB0
	public void .ctor() { }

	// RVA: 0x21E3F70 Offset: 0x21E4071 VA: 0x21E3F70
	public void Clear() { }

	// RVA: 0x21E4010 Offset: 0x21E4111 VA: 0x21E4010
	public void ClearWork() { }

	// RVA: 0x21E40B0 Offset: 0x21E41B1 VA: 0x21E40B0
	public void Add(Unit unit) { }

	// RVA: 0x21E4110 Offset: 0x21E4211 VA: 0x21E4110
	public void Add(PokeInspector inspector) { }

	// RVA: 0x21E4170 Offset: 0x21E4271 VA: 0x21E4170
	public void Add(MapOverlap.Data overlap) { }

	// RVA: -1 Offset: -1
	private void Add<T>(List<T> work, List<T> saved, T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x388A8F0 Offset: 0x388A9F1 VA: 0x388A8F0
	|-MapHistory.Rewind.BattleCalcData.Add<object>
	|-MapHistory.Rewind.BattleCalcData.Add<PokeInspector>
	|-MapHistory.Rewind.BattleCalcData.Add<Unit>
	|-MapHistory.Rewind.BattleCalcData.Add<MapOverlap.Data>
	*/

	// RVA: 0x21E41D0 Offset: 0x21E42D1 VA: 0x21E41D0
	public int GetUnitCount() { }

	// RVA: 0x21E4220 Offset: 0x21E4321 VA: 0x21E4220
	public Unit GetUnit(int index) { }

	// RVA: 0x21E4290 Offset: 0x21E4391 VA: 0x21E4290
	public int GetInspectorCount() { }

	// RVA: 0x21E42E0 Offset: 0x21E43E1 VA: 0x21E42E0
	public PokeInspector GetInspector(int index) { }

	// RVA: 0x21E4350 Offset: 0x21E4451 VA: 0x21E4350
	public int GetOverlapCount() { }

	// RVA: 0x21E43A0 Offset: 0x21E44A1 VA: 0x21E43A0
	public MapOverlap.Data GetOverlap(int index) { }

	// RVA: 0x21E4410 Offset: 0x21E4511 VA: 0x21E4410
	public void Save() { }

	// RVA: -1 Offset: -1
	private void Save<T>(List<T> work, List<T> saved) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x388A970 Offset: 0x388AA71 VA: 0x388A970
	|-MapHistory.Rewind.BattleCalcData.Save<object>
	|-MapHistory.Rewind.BattleCalcData.Save<PokeInspector>
	|-MapHistory.Rewind.BattleCalcData.Save<Unit>
	|-MapHistory.Rewind.BattleCalcData.Save<MapOverlap.Data>
	*/
}

// Namespace: 
public class MapHistory.Rewind.OverlapData : Pool.Node // TypeDefIndex: 12076
{
	// Fields
	public bool hasData; // 0x10
	public byte x; // 0x11
	public byte z; // 0x12
	public byte hp; // 0x13
	public byte life; // 0x14
	public short turn; // 0x16
	public byte phase; // 0x18
	public byte tidMapIndex; // 0x19
	public bool isDone; // 0x1A

	// Methods

	// RVA: 0x21E4670 Offset: 0x21E4771 VA: 0x21E4670 Slot: 4
	public override void OnEnter() { }

	// RVA: 0x21E4690 Offset: 0x21E4791 VA: 0x21E4690 Slot: 5
	public override void OnExit() { }

	// RVA: 0x21E46A0 Offset: 0x21E47A1 VA: 0x21E46A0
	public void Set(MapOverlap.Data mapOverlapData) { }

	// RVA: 0x21E47F0 Offset: 0x21E48F1 VA: 0x21E47F0
	public void Set(MapHistory.Rewind.OverlapData other) { }

	// RVA: 0x21E4840 Offset: 0x21E4941 VA: 0x21E4840
	public bool IsSame(MapOverlap.Data mapOverlapData) { }

	// RVA: 0x21E48F0 Offset: 0x21E49F1 VA: 0x21E48F0
	public TerrainData TryGetTerrain() { }

	// RVA: 0x21E4A10 Offset: 0x21E4B11 VA: 0x21E4A10
	public int GetKey() { }

	// RVA: 0x21E4A20 Offset: 0x21E4B21 VA: 0x21E4A20
	public static int GetKey(int x, int z) { }

	// RVA: 0x21E4A30 Offset: 0x21E4B31 VA: 0x21E4A30
	public void .ctor() { }
}

// Namespace: 
private struct MapHistory.Rewind.WorkTerrainData // TypeDefIndex: 12078
{
	// Fields
	public byte x; // 0x0
	public byte z; // 0x1
	public byte index; // 0x2

	// Methods

	// RVA: 0x21E4AB0 Offset: 0x21E4BB1 VA: 0x21E4AB0
	public void .ctor(int x, int z, int index) { }
}

// Namespace: 
private struct MapHistory.Rewind.ModeScope : IDisposable // TypeDefIndex: 12080
{
	// Fields
	private MapHistory.Mode m_PrevMode; // 0x0

	// Methods

	// RVA: 0x21E44D0 Offset: 0x21E45D1 VA: 0x21E44D0
	public void .ctor(MapHistory.Mode mode) { }

	// RVA: 0x21E45C0 Offset: 0x21E46C1 VA: 0x21E45C0 Slot: 4
	public void Dispose() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x277E20 Offset: 0x277F21 VA: 0x277E20
private sealed class MapHistory.Rewind.<>c__DisplayClass108_0 // TypeDefIndex: 12082
{
	// Fields
	public MapInspector inspector; // 0x10

	// Methods

	// RVA: 0x21E3CA0 Offset: 0x21E3DA1 VA: 0x21E3CA0
	public void .ctor() { }

	// RVA: 0x21E3CB0 Offset: 0x21E3DB1 VA: 0x21E3CB0
	internal bool <RestoreLatestInspectorData>b__0(MapHistory.Rewind.LatestInspectorData data) { }
}

// Namespace: 
private enum MapHistory.RewindType // TypeDefIndex: 12084
{
	// Fields
	public int value__; // 0x0
	public const MapHistory.RewindType PhaseBegin = 2;
	public const MapHistory.RewindType PhaseNext = 3;
	public const MapHistory.RewindType PickUp = 4;
	public const MapHistory.RewindType Fixed = 5;
	public const MapHistory.RewindType Talk = 6;
	public const MapHistory.RewindType Attack = 7;
	public const MapHistory.RewindType Rod = 8;
	public const MapHistory.RewindType EngageCharge = 9;
	public const MapHistory.RewindType Destroy = 10;
	public const MapHistory.RewindType ItemUse = 11;
	public const MapHistory.RewindType Trade = 12;
	public const MapHistory.RewindType Visit = 13;
	public const MapHistory.RewindType Breakdown = 14;
	public const MapHistory.RewindType Escape = 15;
	public const MapHistory.RewindType Door = 16;
	public const MapHistory.RewindType Torch = 17;
	public const MapHistory.RewindType TreasureBox = 18;
	public const MapHistory.RewindType Transporter = 19;
	public const MapHistory.RewindType Dance = 20;
	public const MapHistory.RewindType Guard = 21;
	public const MapHistory.RewindType OverlapSkill = 22;
	public const MapHistory.RewindType CommandSkill = 23;
	public const MapHistory.RewindType VisionCreate = 24;
	public const MapHistory.RewindType VisionDelete = 25;
	public const MapHistory.RewindType DestroyVillage = 26;
	public const MapHistory.RewindType EventBattle = 27;
	public const MapHistory.RewindType BattleCalc = 28;
	public const MapHistory.RewindType MindDone = 29;
	public const MapHistory.RewindType GainItem = 30;
	public const MapHistory.RewindType Status = 31;
	public const MapHistory.RewindType Hp = 32;
	public const MapHistory.RewindType BaseCapability = 33;
	public const MapHistory.RewindType EngageCount = 34;
	public const MapHistory.RewindType ExtraSight = 35;
	public const MapHistory.RewindType Exp = 36;
	public const MapHistory.RewindType LevelUp = 37;
	public const MapHistory.RewindType ClassChange = 38;
	public const MapHistory.RewindType Position = 39;
	public const MapHistory.RewindType Angle = 40;
	public const MapHistory.RewindType PrivateSkill = 41;
	public const MapHistory.RewindType EnhanceFactorItem = 42;
	public const MapHistory.RewindType AIActive = 43;
	public const MapHistory.RewindType AIBand = 44;
	public const MapHistory.RewindType AIPriority = 45;
	public const MapHistory.RewindType AISequence = 46;
	public const MapHistory.RewindType AIValue = 47;
	public const MapHistory.RewindType AIProhibitEngageAttack = 48;
	public const MapHistory.RewindType AIProhibitRod = 49;
	public const MapHistory.RewindType AIProhibitOverlap = 50;
	public const MapHistory.RewindType AIRerewarp = 51;
	public const MapHistory.RewindType AIRerewarpCount = 52;
	public const MapHistory.RewindType Engage = 53;
	public const MapHistory.RewindType Dead = 54;
	public const MapHistory.RewindType TransferV0 = 55;
	public const MapHistory.RewindType ReviveV0 = 56;
	public const MapHistory.RewindType UnitPhaseBegin = 57;
	public const MapHistory.RewindType UnitPhaseEnd = 58;
	public const MapHistory.RewindType UnitItem = 59;
	public const MapHistory.RewindType UnitItemList = 60;
	public const MapHistory.RewindType Dispos = 61;
	public const MapHistory.RewindType GodCreate = 62;
	public const MapHistory.RewindType GodDelete = 63;
	public const MapHistory.RewindType GodConnect = 64;
	public const MapHistory.RewindType GodDisconnect = 65;
	public const MapHistory.RewindType GodChange = 66;
	public const MapHistory.RewindType GodExp = 67;
	public const MapHistory.RewindType GodLevelUpV0 = 68;
	public const MapHistory.RewindType GodDarkness = 69;
	public const MapHistory.RewindType GodState = 70;
	public const MapHistory.RewindType RelianceScore = 71;
	public const MapHistory.RewindType TransporterData = 72;
	public const MapHistory.RewindType CannonShells = 73;
	public const MapHistory.RewindType TerrainOpen = 74;
	public const MapHistory.RewindType TerrainBroken = 75;
	public const MapHistory.RewindType TerrainSet = 76;
	public const MapHistory.RewindType Overlap = 77;
	public const MapHistory.RewindType Gold = 78;
	public const MapHistory.RewindType Material = 79;
	public const MapHistory.RewindType PieceOfBond = 80;
	public const MapHistory.RewindType Variable = 81;
	public const MapHistory.RewindType KizunaRecord = 82;
	public const MapHistory.RewindType WinRule = 83;
	public const MapHistory.RewindType WinRuleEnemyNum = 84;
	public const MapHistory.RewindType WinRuleLimitTurn = 85;
	public const MapHistory.RewindType WinRuleMID = 86;
	public const MapHistory.RewindType FieldBgmPhaseBgm = 87;
	public const MapHistory.RewindType FieldBgmWarSituation = 88;
	public const MapHistory.RewindType EngageBreak = 89;
	public const MapHistory.RewindType Range = 90;
	public const MapHistory.RewindType GodEscaping = 91;
	public const MapHistory.RewindType GodNotifyLevelCapTalk = 92;
	public const MapHistory.RewindType AIEngageAttackOnceDone = 93;
	public const MapHistory.RewindType TerrainAction = 94;
	public const MapHistory.RewindType DangerShowing = 95;
	public const MapHistory.RewindType MapKillBonus = 96;
	public const MapHistory.RewindType PutOff = 97;
	public const MapHistory.RewindType GodDirty = 98;
	public const MapHistory.RewindType EffectCreate = 99;
	public const MapHistory.RewindType EffectDelete = 100;
	public const MapHistory.RewindType MaterialFloat = 101;
	public const MapHistory.RewindType MaterialColor = 102;
	public const MapHistory.RewindType FieldBgmSpecialTurn = 103;
	public const MapHistory.RewindType PostChangeBgmEvent = 104;
	public const MapHistory.RewindType TerrainEndurance = 105;
	public const MapHistory.RewindType TerrainState = 106;
	public const MapHistory.RewindType LoseRuleMID = 107;
	public const MapHistory.RewindType BattleStart = 108;
	public const MapHistory.RewindType PhaseBeginAfter = 109;
	public const MapHistory.RewindType ClearRing = 110;
	public const MapHistory.RewindType MapKillBonusCount = 111;
	public const MapHistory.RewindType UnitRecord = 112;
	public const MapHistory.RewindType ExtraHpStock = 113;
	public const MapHistory.RewindType EngageTurn = 114;
	public const MapHistory.RewindType EngageWait = 115;
	public const MapHistory.RewindType EngageSummon = 116;
	public const MapHistory.RewindType TransferV1 = 117;
	public const MapHistory.RewindType MapSightUsable = 118;
	public const MapHistory.RewindType PlainHpStock = 119;
	public const MapHistory.RewindType Contract = 120;
	public const MapHistory.RewindType FullBullet = 121;
	public const MapHistory.RewindType ResetLockTarget = 122;
	public const MapHistory.RewindType ReviveV1 = 123;
	public const MapHistory.RewindType Enchant = 124;
	public const MapHistory.RewindType EnchantWeapon = 125;
	public const MapHistory.RewindType AIBulletPattern = 126;
	public const MapHistory.RewindType GodLevelUpV1 = 127;
	public const MapHistory.RewindType PositionList = 128;
	public const MapHistory.RewindType AIMoveLimit = 129;
	public const MapHistory.RewindType TerrainActionMove = 130;
	public const MapHistory.RewindType AIMagicShieldOnceDone = 131;
	public const MapHistory.RewindType RandomGame = 132;
	public const MapHistory.RewindType LockTarget = 133;
	public const MapHistory.RewindType AIEnchantWeaponDone = 134;
}

// Namespace: 
private enum MapHistory.RewindVariableType // TypeDefIndex: 12086
{
	// Fields
	public int value__; // 0x0
	public const MapHistory.RewindVariableType None = 0;
	public const MapHistory.RewindVariableType String = 1;
	public const MapHistory.RewindVariableType Number = 2;
}

// Namespace: 
private class MapHistory.RewindCommandReader : MapHistory.CommandReader // TypeDefIndex: 12088
{
	// Fields
	private SkillArray m_DummySkills; // 0x30
	private UnitItem m_DummyUnitItem; // 0x38

	// Methods

	// RVA: 0x23FBA30 Offset: 0x23FBB31 VA: 0x23FBA30
	public void .ctor(byte[] commandStreamBuffer) { }

	// RVA: 0x23FBAF0 Offset: 0x23FBBF1 VA: 0x23FBAF0
	public Unit ReadUnit() { }

	// RVA: 0x23FBBE0 Offset: 0x23FBCE1 VA: 0x23FBBE0
	public int ReadUnitByIndex() { }

	// RVA: 0x23FBC40 Offset: 0x23FBD41 VA: 0x23FBC40
	public void SkipUnit() { }

	// RVA: 0x23FBC90 Offset: 0x23FBD91 VA: 0x23FBC90
	public string ReadName() { }

	// RVA: 0x23FBEE0 Offset: 0x23FBFE1 VA: 0x23FBEE0
	public int ReadNameByIndex() { }

	// RVA: 0x23FBF40 Offset: 0x23FC041 VA: 0x23FBF40
	public void SkipName() { }

	// RVA: 0x23FBF90 Offset: 0x23FC091 VA: 0x23FBF90
	public void ReadPosition(out int x, out int z) { }

	// RVA: 0x23FC030 Offset: 0x23FC131 VA: 0x23FC030
	public long ReadStatus() { }

	// RVA: 0x23FC0E0 Offset: 0x23FC1E1 VA: 0x23FC0E0
	public int ReadHp() { }

	// RVA: 0x23FC140 Offset: 0x23FC241 VA: 0x23FC140
	public sbyte ReadBaseCapability() { }

	// RVA: 0x23FC1A0 Offset: 0x23FC2A1 VA: 0x23FC1A0
	public void ReadBaseCapabilityAll(UnitBaseCapability capability) { }

	// RVA: 0x23FC4F0 Offset: 0x23FC5F1 VA: 0x23FC4F0
	public void ReadGrowCapabilityAll(Capability capability) { }

	// RVA: 0x23FC860 Offset: 0x23FC961 VA: 0x23FC860
	public void ReadLevelCapabilityAll(UnitBaseCapability capability) { }

	// RVA: 0x23FC1B0 Offset: 0x23FC2B1 VA: 0x23FC1B0
	private void ReadUnitBaseCapabilityAll(UnitBaseCapability capability) { }

	// RVA: 0x23FC870 Offset: 0x23FC971 VA: 0x23FC870
	public int ReadEngageCount() { }

	// RVA: 0x23FC8D0 Offset: 0x23FC9D1 VA: 0x23FC8D0
	public int ReadEngageTurn() { }

	// RVA: 0x23FC930 Offset: 0x23FCA31 VA: 0x23FC930
	public bool ReadShowInSearchMap() { }

	// RVA: 0x23FC9E0 Offset: 0x23FCAE1 VA: 0x23FC9E0
	public int ReadTurn() { }

	// RVA: 0x23FCAA0 Offset: 0x23FCBA1 VA: 0x23FCAA0
	public Force.Type ReadForce() { }

	// RVA: 0x23FCB00 Offset: 0x23FCC01 VA: 0x23FCB00
	public void ReadSkills(SkillArray skills) { }

	// RVA: 0x23FCB30 Offset: 0x23FCC31 VA: 0x23FCB30
	public MapHistory.RewindUnitPhaseBeginKinds ReadUnitPhaseBeginKinds() { }

	// RVA: 0x23FCB90 Offset: 0x23FCC91 VA: 0x23FCB90
	public void ReadUnitItem(UnitItem item) { }

	// RVA: 0x23FCBB0 Offset: 0x23FCCB1 VA: 0x23FCBB0
	public void ReadUnitItemList(UnitItemList itemList) { }

	// RVA: 0x23FCBD0 Offset: 0x23FCCD1 VA: 0x23FCBD0
	public GodUnit ReadGodUnit(bool includeReserved = False) { }

	// RVA: 0x23FCCA0 Offset: 0x23FCDA1 VA: 0x23FCCA0
	public void ReadTransporterData(Transporter.Data data) { }

	// RVA: 0x23FCCC0 Offset: 0x23FCDC1 VA: 0x23FCCC0
	public void ReadOverlap(MapHistory.Rewind.OverlapData overlapData) { }

	// RVA: 0x23FCF90 Offset: 0x23FD091 VA: 0x23FCF90
	public static void ReadOverlap(Stream stream, out bool hasData, out int x, out int z, out int hp, out int life, out int turn, out Force.Type phase, out string tid) { }

	// RVA: 0x23FCCD0 Offset: 0x23FCDD1 VA: 0x23FCCD0
	public static void ReadOverlap(Stream stream, MapHistory.Rewind.OverlapData overlapData) { }

	// RVA: 0x23FD280 Offset: 0x23FD381 VA: 0x23FD280
	public void ReadUnitIconInfo(out string pid, out string jid, out ItemData.Kinds itemKind, out bool isFemale, out bool isEngage, out string gid) { }

	// RVA: 0x23FD470 Offset: 0x23FD571 VA: 0x23FD470
	public void SkipUnitIconInfo() { }

	// RVA: 0x23FD5E0 Offset: 0x23FD6E1 VA: 0x23FD5E0
	public bool ReadLockTarget(out int targetX, out int targetZ) { }
}

// Namespace: 
private class MapHistory.RewindUnitMap : MapHistory.UnitMapBase<MapHistory.RewindUnitMap, MapHistory.RewindUnitMap.Data> // TypeDefIndex: 12090
{
	// Fields
	private const int StreamBufferSize = 5120;

	// Properties
	protected override int Version { get; }

	// Methods

	// RVA: 0x24014C0 Offset: 0x24015C1 VA: 0x24014C0
	public void Preserve(Unit unit, Force.Type nextForceType) { }

	// RVA: 0x2401650 Offset: 0x2401751 VA: 0x2401650
	public void Restore(int index, Unit prevUnit) { }

	// RVA: 0x2401910 Offset: 0x2401A11 VA: 0x2401910
	public void BeforeDispos(int index) { }

	// RVA: 0x2401980 Offset: 0x2401A81 VA: 0x2401980
	public void PreviewLatest() { }

	// RVA: 0x2401A40 Offset: 0x2401B41 VA: 0x2401A40
	public void PreviewDecide() { }

	// RVA: 0x2401C50 Offset: 0x2401D51 VA: 0x2401C50
	public void PreviewCancel() { }

	// RVA: 0x2401B40 Offset: 0x2401C41 VA: 0x2401B40
	public void PreviewDeleteRestoredUnit(int index) { }

	// RVA: 0x2401C10 Offset: 0x2401D11 VA: 0x2401C10
	public void PreviewCleanup(int index) { }

	// RVA: 0x2401CD0 Offset: 0x2401DD1 VA: 0x2401CD0 Slot: 4
	protected override int get_Version() { }

	// RVA: 0x2401CE0 Offset: 0x2401DE1 VA: 0x2401CE0 Slot: 11
	protected override void OnSerialize(Stream stream) { }

	// RVA: 0x2401E20 Offset: 0x2401F21 VA: 0x2401E20 Slot: 12
	protected override void OnDeserialize(Stream stream, int version) { }

	// RVA: 0x2402200 Offset: 0x2402301 VA: 0x2402200
	public void .ctor() { }
}

// Namespace: 
private class MapHistory.RewindRelianceMap : SingletonClass<MapHistory.RewindRelianceMap> // TypeDefIndex: 12092
{
	// Fields
	private List<uint> m_Ids; // 0x20
	private bool m_IsUnitMapVer; // 0x28

	// Properties
	public List<uint> Ids { get; }
	protected override int Version { get; }

	// Methods

	// RVA: 0x2400710 Offset: 0x2400811 VA: 0x2400710
	public void .ctor() { }

	// RVA: 0x2400890 Offset: 0x2400991 VA: 0x2400890
	public void Entry(Unit unitA, Unit unitB) { }

	// RVA: 0x2400830 Offset: 0x2400931 VA: 0x2400830
	public void Clear() { }

	// RVA: 0x2400AA0 Offset: 0x2400BA1 VA: 0x2400AA0
	public UnitRelianceData TryGetRelianceData(uint id) { }

	// RVA: 0x2400B10 Offset: 0x2400C11 VA: 0x2400B10
	private void GetPids(uint id, out string pidA, out string pidB) { }

	// RVA: 0x2400C00 Offset: 0x2400D01 VA: 0x2400C00
	private void GetUnits(uint id, out Unit unitA, out Unit unitB) { }

	// RVA: 0x2400D20 Offset: 0x2400E21 VA: 0x2400D20
	public List<uint> get_Ids() { }

	// RVA: 0x2400D30 Offset: 0x2400E31 VA: 0x2400D30 Slot: 4
	protected override int get_Version() { }

	// RVA: 0x2400D40 Offset: 0x2400E41 VA: 0x2400D40 Slot: 11
	protected override void OnSerialize(Stream stream) { }

	// RVA: 0x2400E10 Offset: 0x2400F11 VA: 0x2400E10 Slot: 12
	protected override void OnDeserialize(Stream stream, int version) { }

	// RVA: 0x2400A90 Offset: 0x2400B91 VA: 0x2400A90
	private static uint Index2Id(int mapHistoryIndexA, int mapHistoryIndexB) { }

	// RVA: 0x2400D00 Offset: 0x2400E01 VA: 0x2400D00
	private static void Id2Index(uint id, out int mapHistoryIndexA, out int mapHistoryIndexB) { }

	[ConditionalAttribute] // RVA: 0x2C79E0 Offset: 0x2C7AE1 VA: 0x2C79E0
	// RVA: 0x2400FD0 Offset: 0x24010D1 VA: 0x2400FD0
	public void DbgDump(StringBuilder sb) { }
}

// Namespace: 
public class MapHistory.RewindLog // TypeDefIndex: 12094
{
	// Fields
	public const int MaxItem = 10;
	public const int MaxDeadUnitIcon = 10;
	private MapHistory.RewindLog.UnitIcon m_ActorUnitIcon; // 0x10
	private int m_ActorMapHistoryIndex; // 0x18
	private string m_ActorName; // 0x20
	private string m_Action; // 0x28
	private ItemData[] m_Items; // 0x30
	private int m_ItemCount; // 0x38
	private MapHistory.RewindLog.UnitIcon[] m_DeadUnitIcons; // 0x40
	private int m_DeadUnitIconCount; // 0x48
	private int m_Priority; // 0x4C
	private bool m_IsForCheck; // 0x50
	private Force.Type m_ForceType; // 0x54
	private Force.Type m_PrevForceType; // 0x58

	// Properties
	public MapHistory.RewindLog.UnitIcon ActorUnitIcon { get; }
	public int ActorMapHistoryIndex { get; }
	public string ActorName { get; set; }
	public string Action { get; }
	public ItemData[] Items { get; }
	public int ItemCount { get; }
	public MapHistory.RewindLog.UnitIcon[] DeadUnitIcons { get; }
	public int DeadUnitIconCount { get; }
	public bool IsForCheck { get; set; }
	public bool IsPhaseBegin { get; }
	public Force.Type PhaseBeginForce { get; set; }
	public bool HasPrevForce { get; }
	public Force.Type PrevForce { get; set; }

	// Methods

	// RVA: 0x23FEE20 Offset: 0x23FEF21 VA: 0x23FEE20
	public void .ctor() { }

	// RVA: 0x23FF230 Offset: 0x23FF331 VA: 0x23FF230
	public void Clear() { }

	// RVA: 0x23FF4E0 Offset: 0x23FF5E1 VA: 0x23FF4E0
	public bool IsValid() { }

	// RVA: 0x23FF510 Offset: 0x23FF611 VA: 0x23FF510
	public void SetActorUnitIcon(string pid, string jid, ItemData.Kinds itemKind, bool isFemale, bool isEngage, string gid) { }

	// RVA: 0x23FF530 Offset: 0x23FF631 VA: 0x23FF530
	public void SetActorUnitIconEngage(string gid) { }

	// RVA: 0x23FF550 Offset: 0x23FF651 VA: 0x23FF550
	public void SetActorMapHistoryIndex(int mapHistoryIndex) { }

	// RVA: 0x23FF570 Offset: 0x23FF671 VA: 0x23FF570
	public void ClearActor() { }

	// RVA: 0x23FF5B0 Offset: 0x23FF6B1 VA: 0x23FF5B0
	public void SetAction(string mhid) { }

	// RVA: 0x23FF740 Offset: 0x23FF841 VA: 0x23FF740
	public void SetAction(string mhid, string arg) { }

	// RVA: 0x23FF870 Offset: 0x23FF971 VA: 0x23FF870
	public void SetAction(string mhid, string arg0, string arg1) { }

	// RVA: 0x23FF6D0 Offset: 0x23FF7D1 VA: 0x23FF6D0
	private void SetAction(string action, int priority) { }

	// RVA: 0x23FF9B0 Offset: 0x23FFAB1 VA: 0x23FF9B0
	public void AddItem(string iid) { }

	// RVA: 0x23FFAC0 Offset: 0x23FFBC1 VA: 0x23FFAC0
	public void AddDeadUnit(string pid, string jid, ItemData.Kinds itemKind, bool isFemale, bool isEngage, string gid) { }

	// RVA: 0x23FFB80 Offset: 0x23FFC81 VA: 0x23FFB80
	public void DeleteDeadUnitIcons() { }

	// RVA: 0x23FFCD0 Offset: 0x23FFDD1 VA: 0x23FFCD0
	public MapHistory.RewindLog.UnitIcon get_ActorUnitIcon() { }

	// RVA: 0x23FFCE0 Offset: 0x23FFDE1 VA: 0x23FFCE0
	public int get_ActorMapHistoryIndex() { }

	// RVA: 0x23FFCF0 Offset: 0x23FFDF1 VA: 0x23FFCF0
	public string get_ActorName() { }

	// RVA: 0x23FFD00 Offset: 0x23FFE01 VA: 0x23FFD00
	public void set_ActorName(string value) { }

	// RVA: 0x23FFD10 Offset: 0x23FFE11 VA: 0x23FFD10
	public string get_Action() { }

	// RVA: 0x23FFD20 Offset: 0x23FFE21 VA: 0x23FFD20
	public ItemData[] get_Items() { }

	// RVA: 0x23FFD30 Offset: 0x23FFE31 VA: 0x23FFD30
	public int get_ItemCount() { }

	// RVA: 0x23FFD40 Offset: 0x23FFE41 VA: 0x23FFD40
	public MapHistory.RewindLog.UnitIcon[] get_DeadUnitIcons() { }

	// RVA: 0x23FFD50 Offset: 0x23FFE51 VA: 0x23FFD50
	public int get_DeadUnitIconCount() { }

	// RVA: 0x23FFD60 Offset: 0x23FFE61 VA: 0x23FFD60
	public bool get_IsForCheck() { }

	// RVA: 0x23FFD70 Offset: 0x23FFE71 VA: 0x23FFD70
	public void set_IsForCheck(bool value) { }

	// RVA: 0x23FFD80 Offset: 0x23FFE81 VA: 0x23FFD80
	public bool get_IsPhaseBegin() { }

	// RVA: 0x23FFD90 Offset: 0x23FFE91 VA: 0x23FFD90
	public Force.Type get_PhaseBeginForce() { }

	// RVA: 0x23FFDA0 Offset: 0x23FFEA1 VA: 0x23FFDA0
	public void set_PhaseBeginForce(Force.Type value) { }

	// RVA: 0x23FFDB0 Offset: 0x23FFEB1 VA: 0x23FFDB0
	public bool get_HasPrevForce() { }

	// RVA: 0x23FFDC0 Offset: 0x23FFEC1 VA: 0x23FFDC0
	public Force.Type get_PrevForce() { }

	// RVA: 0x23FFDD0 Offset: 0x23FFED1 VA: 0x23FFDD0
	public void set_PrevForce(Force.Type value) { }
}

