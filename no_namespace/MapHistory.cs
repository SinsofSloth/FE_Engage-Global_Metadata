// Namespace: 
public struct MapHistory.SerializeDisabled : IDisposable // TypeDefIndex: 12031
{
	// Fields
	private bool m_IsPrevDisabled; // 0x0

	// Methods

	// RVA: 0x24022C0 Offset: 0x24023C1 VA: 0x24022C0
	public void .ctor(bool isDisabled) { }

	// RVA: 0x2402350 Offset: 0x2402451 VA: 0x2402350 Slot: 4
	public void Dispose() { }
}

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
private struct MapHistory.Command // TypeDefIndex: 12033
{
	// Fields
	private byte m_Type; // 0x0
	private ushort m_Size; // 0x2
	private int m_Offset; // 0x4

	// Properties
	public int Type { get; set; }
	public int Size { get; set; }
	public int Offset { get; set; }
	public int Tail { get; }

	// Methods

	// RVA: 0x1D44F90 Offset: 0x1D45091 VA: 0x1D44F90
	public int get_Type() { }

	// RVA: 0x1D44FA0 Offset: 0x1D450A1 VA: 0x1D44FA0
	public void set_Type(int value) { }

	// RVA: 0x1D44FB0 Offset: 0x1D450B1 VA: 0x1D44FB0
	public int get_Size() { }

	// RVA: 0x1D44FC0 Offset: 0x1D450C1 VA: 0x1D44FC0
	public void set_Size(int value) { }

	// RVA: 0x1D44FD0 Offset: 0x1D450D1 VA: 0x1D44FD0
	public int get_Offset() { }

	// RVA: 0x1D44FE0 Offset: 0x1D450E1 VA: 0x1D44FE0
	public void set_Offset(int value) { }

	// RVA: 0x1D44FF0 Offset: 0x1D450F1 VA: 0x1D44FF0
	public int get_Tail() { }

	// RVA: 0x1D45000 Offset: 0x1D45101 VA: 0x1D45000
	public void Clear() { }

	// RVA: 0x1D45010 Offset: 0x1D45111 VA: 0x1D45010
	public void Serialize(Stream stream) { }

	// RVA: 0x1D45060 Offset: 0x1D45161 VA: 0x1D45060
	public void Deserialize(Stream stream) { }
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
private class MapHistory.CommandReader : Stream // TypeDefIndex: 12035
{
	// Fields
	protected byte m_Type; // 0x28

	// Properties
	public int Type { get; }

	// Methods

	// RVA: 0x1D451E0 Offset: 0x1D452E1 VA: 0x1D451E0
	public void .ctor(byte[] commandStreamBuffer) { }

	// RVA: 0x1D451F0 Offset: 0x1D452F1 VA: 0x1D451F0
	public void Prepare(MapHistory.Command command) { }

	// RVA: 0x1D45200 Offset: 0x1D45301 VA: 0x1D45200
	public string ReadVariableKey() { }

	// RVA: 0x1D45210 Offset: 0x1D45311 VA: 0x1D45210
	public static string ReadVariableKey(Stream stream) { }

	// RVA: 0x1D452F0 Offset: 0x1D453F1 VA: 0x1D452F0
	public string ReadGid() { }

	// RVA: 0x1D453D0 Offset: 0x1D454D1 VA: 0x1D453D0
	public GodData ReadGodData() { }

	// RVA: 0x1D45460 Offset: 0x1D45561 VA: 0x1D45460
	public string ReadTid() { }

	// RVA: 0x1D45470 Offset: 0x1D45571 VA: 0x1D45470
	public static string ReadTid(Stream stream) { }

	// RVA: 0x1D45550 Offset: 0x1D45651 VA: 0x1D45550
	public string ReadIid() { }

	// RVA: 0x1D45630 Offset: 0x1D45731 VA: 0x1D45630
	public ItemData ReadItemData() { }

	// RVA: 0x1D456C0 Offset: 0x1D457C1 VA: 0x1D456C0
	public string ReadPid() { }

	// RVA: 0x1D457A0 Offset: 0x1D458A1 VA: 0x1D457A0
	public void SkipPid() { }

	// RVA: 0x1D457F0 Offset: 0x1D458F1 VA: 0x1D457F0
	public string ReadJid() { }

	// RVA: 0x1D458D0 Offset: 0x1D459D1 VA: 0x1D458D0
	public void SkipJid() { }

	// RVA: 0x1D45920 Offset: 0x1D45A21 VA: 0x1D45920
	public string ReadSid() { }

	// RVA: 0x1D45A00 Offset: 0x1D45B01 VA: 0x1D45A00
	public SkillData ReadSkillData() { }

	// RVA: 0x1D45A90 Offset: 0x1D45B91 VA: 0x1D45A90
	public string ReadEffectName() { }

	// RVA: 0x1D45B70 Offset: 0x1D45C71 VA: 0x1D45B70
	public string ReadMaterialString() { }

	// RVA: 0x1D45C50 Offset: 0x1D45D51 VA: 0x1D45C50
	public string ReadRnid() { }

	// RVA: 0x1D45D30 Offset: 0x1D45E31 VA: 0x1D45D30
	public void ReadRandom(Random random) { }

	// RVA: 0x1D45D70 Offset: 0x1D45E71 VA: 0x1D45D70
	public int get_Type() { }
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
private enum MapHistory.CommonType // TypeDefIndex: 12037
{
	// Fields
	public int value__; // 0x0
	public const MapHistory.CommonType None = 0;
	public const MapHistory.CommonType Split = 1;
	public const MapHistory.CommonType Custom = 2;
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
public sealed class MapHistory.UnitMapBase.NoEmptyFunction<T, U> : MulticastDelegate // TypeDefIndex: 12039
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A4DB0 Offset: 0x31A4EB1 VA: 0x31A4DB0
	|-MapHistory.UnitMapBase.NoEmptyFunction<object, MapHistory.ReplayUnitMap.Data>..ctor
	|
	|-RVA: 0x31A5020 Offset: 0x31A5121 VA: 0x31A5020
	|-MapHistory.UnitMapBase.NoEmptyFunction<object, MapHistory.RewindUnitMap.Data>..ctor
	|-MapHistory.UnitMapBase.NoEmptyFunction<MapHistory.RewindUnitMap, MapHistory.RewindUnitMap.Data>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual void Invoke() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A4DD0 Offset: 0x31A4ED1 VA: 0x31A4DD0
	|-MapHistory.UnitMapBase.NoEmptyFunction<object, MapHistory.ReplayUnitMap.Data>.Invoke
	|
	|-RVA: 0x31A5040 Offset: 0x31A5141 VA: 0x31A5040
	|-MapHistory.UnitMapBase.NoEmptyFunction<object, MapHistory.RewindUnitMap.Data>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A4FE0 Offset: 0x31A50E1 VA: 0x31A4FE0
	|-MapHistory.UnitMapBase.NoEmptyFunction<object, MapHistory.ReplayUnitMap.Data>.BeginInvoke
	|
	|-RVA: 0x31A5250 Offset: 0x31A5351 VA: 0x31A5250
	|-MapHistory.UnitMapBase.NoEmptyFunction<object, MapHistory.RewindUnitMap.Data>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A5010 Offset: 0x31A5111 VA: 0x31A5010
	|-MapHistory.UnitMapBase.NoEmptyFunction<object, MapHistory.ReplayUnitMap.Data>.EndInvoke
	|
	|-RVA: 0x31A5280 Offset: 0x31A5381 VA: 0x31A5280
	|-MapHistory.UnitMapBase.NoEmptyFunction<object, MapHistory.RewindUnitMap.Data>.EndInvoke
	*/
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
private abstract class MapHistory.IdMapBase<T> : SingletonClass<T> // TypeDefIndex: 12041
{
	// Fields
	protected List<string> m_Ids; // 0x0
	protected Dictionary<string, byte> m_IdIndexDict; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EAF6A0 Offset: 0x1EAF7A1 VA: 0x1EAF6A0
	|-MapHistory.IdMapBase<object>..ctor
	|-MapHistory.IdMapBase<MapHistory.RewindNameMap>..ctor
	*/

	// RVA: -1 Offset: -1
	protected int EntryInternal(string id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EAF830 Offset: 0x1EAF931 VA: 0x1EAF830
	|-MapHistory.IdMapBase<object>.EntryInternal
	*/

	// RVA: -1 Offset: -1
	protected int EntryInternal(string id, byte index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EAF890 Offset: 0x1EAF991 VA: 0x1EAF890
	|-MapHistory.IdMapBase<object>.EntryInternal
	|-MapHistory.IdMapBase<MapHistory.RewindNameMap>.EntryInternal
	*/

	// RVA: -1 Offset: -1
	protected byte GetNextIndex() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EAF980 Offset: 0x1EAFA81 VA: 0x1EAF980
	|-MapHistory.IdMapBase<object>.GetNextIndex
	|-MapHistory.IdMapBase<MapHistory.RewindNameMap>.GetNextIndex
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EAF9D0 Offset: 0x1EAFAD1 VA: 0x1EAF9D0
	|-MapHistory.IdMapBase<object>.Clear
	|-MapHistory.IdMapBase<MapHistory.RewindNameMap>.Clear
	*/

	// RVA: -1 Offset: -1
	protected string TryGetInternal(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EAFA50 Offset: 0x1EAFB51 VA: 0x1EAFA50
	|-MapHistory.IdMapBase<object>.TryGetInternal
	|-MapHistory.IdMapBase<MapHistory.RewindNameMap>.TryGetInternal
	*/

	[ConditionalAttribute] // RVA: 0x2C7560 Offset: 0x2C7661 VA: 0x2C7560
	// RVA: -1 Offset: -1
	public void DbgDump(StringBuilder sb) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EAFAE0 Offset: 0x1EAFBE1 VA: 0x1EAFAE0
	|-MapHistory.IdMapBase<object>.DbgDump
	*/

	[ConditionalAttribute] // RVA: 0x2C75A0 Offset: 0x2C76A1 VA: 0x2C75A0
	// RVA: -1 Offset: -1
	protected void DbgError(string message) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EAFAF0 Offset: 0x1EAFBF1 VA: 0x1EAFAF0
	|-MapHistory.IdMapBase<object>.DbgError
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
private class MapHistory.VariableMap : MapHistory.IdMap<MapHistory.VariableMap> // TypeDefIndex: 12043
{
	// Properties
	public List<string> Keys { get; }

	// Methods

	// RVA: 0x2402490 Offset: 0x2402591 VA: 0x2402490
	public void .ctor() { }

	// RVA: 0x24024F0 Offset: 0x24025F1 VA: 0x24024F0
	public List<string> get_Keys() { }
}

// Namespace: 
private class MapHistory.GidMap : MapHistory.IdMap<MapHistory.GidMap> // TypeDefIndex: 12044
{
	// Methods

	// RVA: 0x1D466C0 Offset: 0x1D467C1 VA: 0x1D466C0
	public void .ctor() { }
}

// Namespace: 
private class MapHistory.TidMap : MapHistory.IdMap<MapHistory.TidMap> // TypeDefIndex: 12045
{
	// Methods

	// RVA: 0x2402430 Offset: 0x2402531 VA: 0x2402430
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
private class MapHistory.PidMap : MapHistory.IdMap<MapHistory.PidMap> // TypeDefIndex: 12047
{
	// Methods

	// RVA: 0x1D46840 Offset: 0x1D46941 VA: 0x1D46840
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
private class MapHistory.SidMap : MapHistory.IdMap<MapHistory.SidMap> // TypeDefIndex: 12049
{
	// Methods

	// RVA: 0x24023D0 Offset: 0x24024D1 VA: 0x24023D0
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
private class MapHistory.EffectNameMap : MapHistory.IdMap<MapHistory.EffectNameMap> // TypeDefIndex: 12051
{
	// Methods

	// RVA: 0x1D46660 Offset: 0x1D46761 VA: 0x1D46660
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
private enum MapHistory.Replay.ReadResult // TypeDefIndex: 12053
{
	// Fields
	public int value__; // 0x0
	public const MapHistory.Replay.ReadResult Next = 0;
	public const MapHistory.Replay.ReadResult Mind = 1;
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
public sealed class MapHistory.Replay.SaveAsync.SaveMethod : MulticastDelegate // TypeDefIndex: 12055
{
	// Methods

	// RVA: 0x2D7C880 Offset: 0x2D7C981 VA: 0x2D7C880
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2D7C8A0 Offset: 0x2D7C9A1 VA: 0x2D7C8A0 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x2D7CAB0 Offset: 0x2D7CBB1 VA: 0x2D7CAB0 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x2D7CAE0 Offset: 0x2D7CBE1 VA: 0x2D7CAE0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
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
private enum MapHistory.Replay.SaveAsyncThread.Status // TypeDefIndex: 12057
{
	// Fields
	public int value__; // 0x0
	public const MapHistory.Replay.SaveAsyncThread.Status Wait = 0;
	public const MapHistory.Replay.SaveAsyncThread.Status Run = 1;
	public const MapHistory.Replay.SaveAsyncThread.Status End = 2;
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
private class MapHistory.Replay.TurnSave : SingletonClass<MapHistory.Replay.TurnSave> // TypeDefIndex: 12059
{
	// Fields
	private const int StreamBufferSize = 262144;
	private byte[] m_StreamBuffer; // 0x20
	private Stream m_Stream; // 0x28
	private MapHistory.Replay.SaveAsync.SaveMethod m_SaveAsyncMethod; // 0x30

	// Properties
	protected override int Version { get; }

	// Methods

	// RVA: 0x21E3900 Offset: 0x21E3A01 VA: 0x21E3900 Slot: 5
	protected override void OnCreate() { }

	// RVA: 0x21E3A30 Offset: 0x21E3B31 VA: 0x21E3A30
	public void Write(ProcInst super) { }

	// RVA: 0x21E3A40 Offset: 0x21E3B41 VA: 0x21E3A40
	public void Read() { }

	// RVA: 0x21E3A60 Offset: 0x21E3B61 VA: 0x21E3A60
	private void WriteToStream() { }

	// RVA: 0x21E3A50 Offset: 0x21E3B51 VA: 0x21E3A50
	private void ReadFromStream() { }

	// RVA: 0x21E3A20 Offset: 0x21E3B21 VA: 0x21E3A20
	private void Clear() { }

	// RVA: 0x21E3A90 Offset: 0x21E3B91 VA: 0x21E3A90 Slot: 4
	protected override int get_Version() { }

	// RVA: 0x21E3AA0 Offset: 0x21E3BA1 VA: 0x21E3AA0 Slot: 11
	protected override void OnSerialize(Stream stream) { }

	// RVA: 0x21E3AC0 Offset: 0x21E3BC1 VA: 0x21E3AC0 Slot: 12
	protected override void OnDeserialize(Stream stream, int version) { }

	// RVA: 0x21E3BE0 Offset: 0x21E3CE1 VA: 0x21E3BE0
	public void .ctor() { }
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
private enum MapHistory.ReplayType // TypeDefIndex: 12061
{
	// Fields
	public int value__; // 0x0
	public const MapHistory.ReplayType PhaseBegin = 2;
	public const MapHistory.ReplayType PhaseNext = 3;
	public const MapHistory.ReplayType Mind = 4;
	public const MapHistory.ReplayType Engage = 5;
	public const MapHistory.ReplayType GodChange = 6;
	public const MapHistory.ReplayType UnitItemList = 7;
	public const MapHistory.ReplayType Surrender = 8;
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
private class MapHistory.ReplayCommandReader : MapHistory.CommandReader // TypeDefIndex: 12063
{
	// Methods

	// RVA: 0x1D46CE0 Offset: 0x1D46DE1 VA: 0x1D46CE0
	public void .ctor(byte[] commandStreamBuffer) { }

	// RVA: 0x1D4B700 Offset: 0x1D4B801 VA: 0x1D4B700
	public Unit ReadUnit() { }

	// RVA: 0x1D4B8C0 Offset: 0x1D4B9C1 VA: 0x1D4B8C0
	public int ReadUnitByIndex() { }

	// RVA: 0x1D4DB50 Offset: 0x1D4DC51 VA: 0x1D4DB50
	public void ReadUnitItem(UnitItem item) { }

	// RVA: 0x1D4CB70 Offset: 0x1D4CC71 VA: 0x1D4CB70
	public void ReadUnitItemList(UnitItemList itemList) { }

	// RVA: 0x1D4C830 Offset: 0x1D4C931 VA: 0x1D4C830
	public void ReadMultiTargets(MapMind.MultiTargets targets) { }

	// RVA: 0x1D4C7D0 Offset: 0x1D4C8D1 VA: 0x1D4C7D0
	public Force.Type ReadForce() { }
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
private class MapHistory.ReplayUnitMap : MapHistory.UnitMapBase<MapHistory.ReplayUnitMap, MapHistory.ReplayUnitMap.Data> // TypeDefIndex: 12065
{
	// Methods

	// RVA: 0x1D4E2B0 Offset: 0x1D4E3B1 VA: 0x1D4E2B0
	public void .ctor() { }
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
private struct MapHistory.ReplayAppearanceMap.Leaving // TypeDefIndex: 12067
{
	// Fields
	public byte turn; // 0x0
	public byte mapHistoryIndex; // 0x1
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
public enum MapHistory.Rewind.IsEngagings // TypeDefIndex: 12069
{
	// Fields
	public int value__; // 0x0
	public const MapHistory.Rewind.IsEngagings FromUnit = 0;
	public const MapHistory.Rewind.IsEngagings True = 1;
	public const MapHistory.Rewind.IsEngagings False = 2;
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
private enum MapHistory.Rewind.SplitArgs // TypeDefIndex: 12071
{
	// Fields
	public int value__; // 0x0
	public const MapHistory.Rewind.SplitArgs Default = 0;
	public const MapHistory.Rewind.SplitArgs PickUp = 1;
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
private enum MapHistory.Rewind.RangeType // TypeDefIndex: 12073
{
	// Fields
	public int value__; // 0x0
	public const MapHistory.Rewind.RangeType ByAdd = 0;
	public const MapHistory.Rewind.RangeType ByClear = 1;
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
private struct MapHistory.Rewind.LatestInspectorData // TypeDefIndex: 12075
{
	// Fields
	public byte x; // 0x0
	public byte z; // 0x1
	public bool isChecked; // 0x2

	// Methods

	// RVA: 0x21E44C0 Offset: 0x21E45C1 VA: 0x21E44C0
	public void .ctor(int x, int z) { }
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
private class MapHistory.Rewind.OverlapDataPool : Pool.List<MapHistory.Rewind.OverlapData> // TypeDefIndex: 12077
{
	// Methods

	// RVA: 0x21E4A40 Offset: 0x21E4B41 VA: 0x21E4A40
	public void .ctor(int max) { }
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
private struct MapHistory.Rewind.WorkLayerData // TypeDefIndex: 12079
{
	// Fields
	public byte group; // 0x0
	public bool enable; // 0x1

	// Methods

	// RVA: 0x21E4AA0 Offset: 0x21E4BA1 VA: 0x21E4AA0
	public void .ctor(int group, bool enable) { }
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
[CompilerGeneratedAttribute] // RVA: 0x277E10 Offset: 0x277F11 VA: 0x277E10
private sealed class MapHistory.Rewind.<>c__DisplayClass97_0 // TypeDefIndex: 12081
{
	// Fields
	public byte unitCount; // 0x10
	public MapHistory.Rewind <>4__this; // 0x18

	// Methods

	// RVA: 0x21E3D20 Offset: 0x21E3E21 VA: 0x21E3D20
	public void .ctor() { }

	// RVA: 0x21E3D30 Offset: 0x21E3E31 VA: 0x21E3D30
	internal void <SerializeLatest>b__0(Unit unit) { }

	// RVA: 0x21E3D40 Offset: 0x21E3E41 VA: 0x21E3D40
	internal void <SerializeLatest>b__1(Unit unit) { }
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
private class MapHistory.Rewind : MapHistory.Base<MapHistory.Rewind> // TypeDefIndex: 12083
{
	// Fields
	private const int MaxLogCommand = 4;
	private const int Version = 35;
	private MapHistory.Mode m_Mode; // 0x30
	private int m_UseCount; // 0x34
	private MapHistory.RewindCommandWriter[] m_Writers; // 0x38
	private MapHistory.RewindCommandWriter m_Writer; // 0x40
	private MapHistory.RewindCommandReader m_Reader; // 0x48
	private int m_PreviewIndex; // 0x50
	private Stream m_LatestStream; // 0x58
	private Dictionary<int, string> m_GodChangedInfos; // 0x60
	private List<MapHistory.Rewind.LatestInspectorData> m_LatestInspectors; // 0x68
	private HashSet<string> m_AbsentPids; // 0x70
	private string m_FieldBgmPlayerPhaseBgm; // 0x78
	private string m_FieldBgmEnemyPhaseBgm; // 0x80
	private string m_FieldBgmAllyPhaseBgm; // 0x88
	private string m_FieldBgmWarSituation; // 0x90
	private int m_FieldBgmSpecialTurn; // 0x98
	private string m_PostChangeBgmEvent; // 0xA0
	private MapHistory.Rewind.BattleCalcData m_BattleCalcData; // 0xA8
	private int m_UnitPhaseCountPos; // 0xB0
	private int m_UnitPhaseCount; // 0xB4
	private int m_UnitPhaseBeginOnePos; // 0xB8
	private int m_UnitPhaseBeginCountPos; // 0xBC
	private int m_UnitPhaseBeginCount; // 0xC0
	private int m_UnitPhaseBeginFlags; // 0xC4
	private int m_TerrainSetCountPos; // 0xC8
	private int m_TerrainSetCount; // 0xCC
	private int m_OverlapCountPos; // 0xD0
	private int m_OverlapCount; // 0xD4
	private int m_RangeCountPos; // 0xD8
	private int m_RangeCount; // 0xDC
	private int m_EffectDeleteCountPos; // 0xE0
	private int m_EffectDeleteCount; // 0xE4
	private bool m_HasMaterialFloat; // 0xE8
	private bool m_HasMaterialColor; // 0xE9
	private int m_PositionListCountPos; // 0xEC
	private List<byte> m_PositionListUnits; // 0xF0
	private List<MapHistory.Rewind.WorkTerrainData> m_WorkTerrains; // 0xF8
	private MapHistory.Rewind.OverlapDataPool m_OverlapPool; // 0x100
	private Dictionary<int, MapHistory.Rewind.OverlapData> m_LatestOverlaps; // 0x108
	private Dictionary<int, MapHistory.Rewind.OverlapData> m_PostapplyOverlaps; // 0x110
	private MapKillBonus.KindImage m_KillBonusKindImage; // 0x118
	private SkillArray m_Skills; // 0x120
	private UnitItem m_UnitItem; // 0x128
	private UnitItemList m_UnitItemList; // 0x130
	private GameParam.Holder m_MaxUseCountNormalHolder; // 0x138
	private GameParam.Holder m_MaxUseCountHardHolder; // 0x140
	private GameParam.Holder m_MaxUseCountLunaticHolder; // 0x148
	private GameParam.Holder m_MaxSplitHolder; // 0x150

	// Properties
	protected override uint CommandStreamBufferSize { get; }

	// Methods

	// RVA: 0x1D4E310 Offset: 0x1D4E411 VA: 0x1D4E310 Slot: 4
	protected override void OnInitialize() { }

	// RVA: 0x1D4EBF0 Offset: 0x1D4ECF1 VA: 0x1D4EBF0 Slot: 5
	protected override void OnDelete() { }

	// RVA: 0x1D4EFD0 Offset: 0x1D4F0D1 VA: 0x1D4EFD0
	public bool IsEnable() { }

	// RVA: 0x1D4F230 Offset: 0x1D4F331 VA: 0x1D4F230
	public void Enable() { }

	// RVA: 0x1D4F3B0 Offset: 0x1D4F4B1 VA: 0x1D4F3B0
	public void Disable() { }

	[ConditionalAttribute] // RVA: 0x2C7700 Offset: 0x2C7801 VA: 0x2C7700
	// RVA: 0x1D4F430 Offset: 0x1D4F531 VA: 0x1D4F430
	public void DbgSetUseCount(int count) { }

	// RVA: 0x1D4F470 Offset: 0x1D4F571 VA: 0x1D4F470
	public int GetUseCount() { }

	// RVA: 0x1D4F090 Offset: 0x1D4F191 VA: 0x1D4F090
	public int GetMaxUseCount() { }

	// RVA: 0x1D4F480 Offset: 0x1D4F581 VA: 0x1D4F480
	public void Reset() { }

	// RVA: 0x1D4F300 Offset: 0x1D4F401 VA: 0x1D4F300
	public void Begin() { }

	// RVA: 0x1D4F540 Offset: 0x1D4F641 VA: 0x1D4F540
	public void End() { }

	// RVA: 0x1D4F550 Offset: 0x1D4F651 VA: 0x1D4F550
	public void Split() { }

	// RVA: 0x1D4F5F0 Offset: 0x1D4F6F1 VA: 0x1D4F5F0
	private void SplitForPickUp() { }

	// RVA: 0x1D4F670 Offset: 0x1D4F771 VA: 0x1D4F670
	public void EngageCancel(Unit unit) { }

	// RVA: 0x1D4F700 Offset: 0x1D4F801 VA: 0x1D4F700
	public void GodChangeCancel(Unit unit) { }

	// RVA: 0x1D4F790 Offset: 0x1D4F891 VA: 0x1D4F790 Slot: 7
	protected override int GetCommandEngage() { }

	// RVA: 0x1D4F7A0 Offset: 0x1D4F8A1 VA: 0x1D4F7A0 Slot: 8
	protected override int GetCommandGodChange() { }

	// RVA: 0x1D4F7B0 Offset: 0x1D4F8B1 VA: 0x1D4F7B0 Slot: 10
	protected override Unit GetUnitForCommandEngage(int commandIndex) { }

	// RVA: 0x1D4F9C0 Offset: 0x1D4FAC1 VA: 0x1D4F9C0 Slot: 11
	protected override Unit GetUnitForCommandGodChange(int commandIndex) { }

	// RVA: 0x1D4FAE0 Offset: 0x1D4FBE1 VA: 0x1D4FAE0
	public bool CreateLog(int index, MapHistory.RewindLog result) { }

	// RVA: 0x1D501A0 Offset: 0x1D502A1 VA: 0x1D501A0
	public bool CheckLogExists() { }

	// RVA: 0x1D502D0 Offset: 0x1D503D1 VA: 0x1D502D0
	public bool GetCursorPos(int index, out int x, out int z) { }

	// RVA: 0x1D50480 Offset: 0x1D50581 VA: 0x1D50480
	public bool IsPhaseBegin(int index) { }

	// RVA: 0x1D50560 Offset: 0x1D50661 VA: 0x1D50560
	public void PreviewSetup() { }

	// RVA: 0x1D51060 Offset: 0x1D51161 VA: 0x1D51060
	public bool PreviewApply(int index) { }

	// RVA: 0x1D549E0 Offset: 0x1D54AE1 VA: 0x1D549E0
	public void PreviewDecide() { }

	// RVA: 0x1D54E50 Offset: 0x1D54F51 VA: 0x1D54E50
	public void PreviewCancel() { }

	// RVA: 0x1D54FD0 Offset: 0x1D550D1 VA: 0x1D54FD0
	public bool IsPreviewing() { }

	// RVA: 0x1D54FE0 Offset: 0x1D550E1 VA: 0x1D54FE0
	public Unit PreviewGetUnit(int mapHistoryIndex) { }

	// RVA: 0x1D55100 Offset: 0x1D55201 VA: 0x1D55100
	public void Serialize(Stream stream) { }

	// RVA: 0x1D555A0 Offset: 0x1D556A1 VA: 0x1D555A0
	public void Deserialize(Stream stream) { }

	// RVA: 0x1D55A70 Offset: 0x1D55B71 VA: 0x1D55A70
	private void Delete(int index) { }

	// RVA: 0x1D55B10 Offset: 0x1D55C11 VA: 0x1D55B10
	private void DeleteFromLast(MapHistory.RewindType type) { }

	// RVA: 0x1D55B70 Offset: 0x1D55C71 VA: 0x1D55B70
	private MapHistory.RewindType GetLastCommandType() { }

	// RVA: 0x1D55BC0 Offset: 0x1D55CC1 VA: 0x1D55BC0
	private int FindLastIndexUntilSplit(MapHistory.RewindType type, int startIndex) { }

	// RVA: 0x1D55C30 Offset: 0x1D55D31 VA: 0x1D55C30
	private int FindLastIndexUntilSplit(MapHistory.RewindType type) { }

	// RVA: 0x1D4F5D0 Offset: 0x1D4F6D1 VA: 0x1D4F5D0
	private bool CanWrite() { }

	// RVA: 0x1D55CA0 Offset: 0x1D55DA1 VA: 0x1D55CA0
	private bool IsTransferType(int commandType, out int version) { }

	// RVA: 0x1D55CD0 Offset: 0x1D55DD1 VA: 0x1D55CD0
	private void OnUnitMapNoEmpty() { }

	// RVA: 0x1D560D0 Offset: 0x1D561D1 VA: 0x1D560D0 Slot: 6
	protected override void Preadd(MapHistory.CommandWriter writer) { }

	// RVA: 0x1D560E0 Offset: 0x1D561E1 VA: 0x1D560E0
	private void DeleteOldCommandsIfNotEnoughSpace(MapHistory.CommandWriter writer) { }

	// RVA: 0x1D55F40 Offset: 0x1D56041 VA: 0x1D55F40
	private void DeleteOldCommands(int newTopCommandIndex, int numDeleteSplit) { }

	// RVA: 0x1D4F4E0 Offset: 0x1D4F5E1 VA: 0x1D4F4E0
	private void DeleteOldCommandsAll() { }

	// RVA: 0x1D56300 Offset: 0x1D56401 VA: 0x1D56300
	private void DeleteUnneededUnits(int newTopCommandIndex = -1) { }

	// RVA: 0x1D564D0 Offset: 0x1D565D1 VA: 0x1D564D0 Slot: 13
	protected override void PredeleteCommand(int commandIndex) { }

	// RVA: 0x1D564E0 Offset: 0x1D565E1 VA: 0x1D564E0 Slot: 14
	protected override void DeleteCommandError() { }

	// RVA: 0x1D54D60 Offset: 0x1D54E61 VA: 0x1D54D60
	private int CountSplit(int nextNumCommand) { }

	// RVA: 0x1D50730 Offset: 0x1D50831 VA: 0x1D50730
	private void SerializeLatest() { }

	// RVA: 0x1D51A70 Offset: 0x1D51B71 VA: 0x1D51A70
	private void DeserializeLatest() { }

	// RVA: 0x1D57250 Offset: 0x1D57351 VA: 0x1D57250
	private void DeserializeLatestClearUnits() { }

	// RVA: 0x1D572B0 Offset: 0x1D573B1 VA: 0x1D572B0
	private Unit DeserializeLatestFindUnit(byte mapHistoryIndex) { }

	// RVA: 0x1D56540 Offset: 0x1D56641 VA: 0x1D56540
	private void SerializeReliance(Stream stream) { }

	// RVA: 0x1D575B0 Offset: 0x1D576B1 VA: 0x1D575B0
	private void DeserializeReliance(Stream stream) { }

	// RVA: 0x1D566C0 Offset: 0x1D567C1 VA: 0x1D566C0
	private void SerializeTerrain(Stream stream) { }

	// RVA: 0x1D577E0 Offset: 0x1D578E1 VA: 0x1D577E0
	private void DeserializeTerrain(Stream stream) { }

	// RVA: 0x1D56980 Offset: 0x1D56A81 VA: 0x1D56980
	private void SaveLatestInspectorData() { }

	// RVA: 0x1D56E40 Offset: 0x1D56F41 VA: 0x1D56E40
	private void SerializeMapObject(Stream stream) { }

	// RVA: 0x1D580D0 Offset: 0x1D581D1 VA: 0x1D580D0
	private void DeserializeMapObject(Stream stream) { }

	// RVA: 0x1D57E10 Offset: 0x1D57F11 VA: 0x1D57E10
	private void RestoreLatestInspectorData() { }

	// RVA: 0x1D56B70 Offset: 0x1D56C71 VA: 0x1D56B70
	private void SerializeInspector(Stream stream) { }

	// RVA: 0x1D57B70 Offset: 0x1D57C71 VA: 0x1D57B70
	private void DeserializeInspector(Stream stream) { }

	// RVA: 0x1D57100 Offset: 0x1D57201 VA: 0x1D57100
	private void SerializeVariable(Stream stream) { }

	// RVA: 0x1D58BE0 Offset: 0x1D58CE1 VA: 0x1D58BE0
	private void SerializeVariableOne(Stream stream, string key) { }

	// RVA: 0x1D58390 Offset: 0x1D58491 VA: 0x1D58390
	private void DeserializeVariable(Stream stream) { }

	// RVA: 0x1D505D0 Offset: 0x1D506D1 VA: 0x1D505D0
	private void PrepareOverlapsForPreviewSetup() { }

	// RVA: 0x1D51790 Offset: 0x1D51891 VA: 0x1D51790
	private void PrepareOverlapsForPreviewApply() { }

	// RVA: 0x1D54750 Offset: 0x1D54851 VA: 0x1D54750
	private void UpdateOverlaps() { }

	// RVA: 0x1D58E10 Offset: 0x1D58F11 VA: 0x1D58E10
	private void UpdateOverlapsNew(MapHistory.Rewind.OverlapData overlapData) { }

	// RVA: 0x1D58A90 Offset: 0x1D58B91 VA: 0x1D58A90
	public static PokeInspector GetPokeInspector(int x, int z) { }

	// RVA: 0x1D58F80 Offset: 0x1D59081 VA: 0x1D58F80
	public void ReserveFieldBgmPhaseBgm(string playerPhaseBgm, string enemyPhaseBgm, string allyPhaseBgm) { }

	// RVA: 0x1D58FD0 Offset: 0x1D590D1 VA: 0x1D58FD0
	public void ReserveFieldBgmWarSituation(string warSituationStateName) { }

	// RVA: 0x1D57300 Offset: 0x1D57401 VA: 0x1D57300
	public static void ApplyChangeGod(Unit unit, string gid, bool forEngageImpl = False) { }

	// RVA: 0x1D58FE0 Offset: 0x1D590E1 VA: 0x1D58FE0 Slot: 15
	protected override uint get_CommandStreamBufferSize() { }

	[ConditionalAttribute] // RVA: 0x2C7740 Offset: 0x2C7841 VA: 0x2C7740
	// RVA: 0x1D58FF0 Offset: 0x1D590F1 VA: 0x1D58FF0
	public void DbgDump() { }

	[ConditionalAttribute] // RVA: 0x2C7780 Offset: 0x2C7881 VA: 0x2C7780
	// RVA: 0x1D59450 Offset: 0x1D59551 VA: 0x1D59450
	public void DbgCreateSnapshot() { }

	[ConditionalAttribute] // RVA: 0x2C77C0 Offset: 0x2C78C1 VA: 0x2C77C0
	// RVA: 0x1D59460 Offset: 0x1D59561 VA: 0x1D59460
	private void DbgCompareSnapshot() { }

	[ConditionalAttribute] // RVA: 0x2C7800 Offset: 0x2C7901 VA: 0x2C7800
	// RVA: 0x1D59470 Offset: 0x1D59571 VA: 0x1D59470
	public void DbgDeleteSnapshot(int index) { }

	[ConditionalAttribute] // RVA: 0x2C7840 Offset: 0x2C7941 VA: 0x2C7840
	// RVA: 0x1D59480 Offset: 0x1D59581 VA: 0x1D59480
	private void DbgOnDeleteOldCommands(int newTopCommandIndex = -1) { }

	[ConditionalAttribute] // RVA: 0x2C7880 Offset: 0x2C7981 VA: 0x2C7880
	// RVA: 0x1D59490 Offset: 0x1D59591 VA: 0x1D59490
	private void DbgOnDeleteCommand(int commandIndex) { }

	[ConditionalAttribute] // RVA: 0x2C78C0 Offset: 0x2C79C1 VA: 0x2C78C0
	// RVA: 0x1D594A0 Offset: 0x1D595A1 VA: 0x1D594A0
	private void DbgPatchVersionCheck() { }

	[ConditionalAttribute] // RVA: 0x2C7900 Offset: 0x2C7A01 VA: 0x2C7900
	// RVA: 0x1D594B0 Offset: 0x1D595B1 VA: 0x1D594B0
	private static void DbgPatchVersionCheckLog(string s) { }

	// RVA: 0x1D594C0 Offset: 0x1D595C1 VA: 0x1D594C0
	public void PhaseBegin() { }

	// RVA: 0x1D598B0 Offset: 0x1D599B1 VA: 0x1D598B0
	public void PhaseNext() { }

	// RVA: 0x1D599E0 Offset: 0x1D59AE1 VA: 0x1D599E0
	public void PickUp(Unit unit) { }

	// RVA: 0x1D59C50 Offset: 0x1D59D51 VA: 0x1D59C50
	public void CancelPickUp() { }

	// RVA: 0x1D59D60 Offset: 0x1D59E61 VA: 0x1D59D60
	public void Mind() { }

	// RVA: 0x1D59FA0 Offset: 0x1D5A0A1 VA: 0x1D59FA0
	private void Fixed() { }

	// RVA: 0x1D5BAA0 Offset: 0x1D5BBA1 VA: 0x1D5BAA0
	public void Talk(Unit fromUnit, Unit toUnit) { }

	// RVA: 0x1D5A0A0 Offset: 0x1D5A1A1 VA: 0x1D5A0A0
	private void Attack() { }

	// RVA: 0x1D5A2D0 Offset: 0x1D5A3D1 VA: 0x1D5A2D0
	private void Rod() { }

	// RVA: 0x1D5A4C0 Offset: 0x1D5A5C1 VA: 0x1D5A4C0
	private void EngageCharge() { }

	// RVA: 0x1D5A5C0 Offset: 0x1D5A6C1 VA: 0x1D5A5C0
	private void Destroy() { }

	// RVA: 0x1D5A6A0 Offset: 0x1D5A7A1 VA: 0x1D5A6A0
	private void ItemUse() { }

	// RVA: 0x1D5BB60 Offset: 0x1D5BC61 VA: 0x1D5BB60
	public void Trade(Unit fromUnit, Unit toUnit) { }

	// RVA: 0x1D5BC80 Offset: 0x1D5BD81 VA: 0x1D5BC80
	public void TradeUndone(Unit unit) { }

	// RVA: 0x1D5A7C0 Offset: 0x1D5A8C1 VA: 0x1D5A7C0
	private void Visit() { }

	// RVA: 0x1D5A890 Offset: 0x1D5A991 VA: 0x1D5A890
	private void Breakdown() { }

	// RVA: 0x1D5A980 Offset: 0x1D5AA81 VA: 0x1D5A980
	private void Escape() { }

	// RVA: 0x1D5AA50 Offset: 0x1D5AB51 VA: 0x1D5AA50
	private void Door() { }

	// RVA: 0x1D5AB20 Offset: 0x1D5AC21 VA: 0x1D5AB20
	private void Torch() { }

	// RVA: 0x1D5AC10 Offset: 0x1D5AD11 VA: 0x1D5AC10
	private void TreasureBox() { }

	// RVA: 0x1D5BE30 Offset: 0x1D5BF31 VA: 0x1D5BE30
	public void Transporter(Unit unit) { }

	// RVA: 0x1D5ACE0 Offset: 0x1D5ADE1 VA: 0x1D5ACE0
	private void Dance() { }

	// RVA: 0x1D5ADD0 Offset: 0x1D5AED1 VA: 0x1D5ADD0
	private void Guard() { }

	// RVA: 0x1D5B0B0 Offset: 0x1D5B1B1 VA: 0x1D5B0B0
	private void OverlapSkill() { }

	// RVA: 0x1D5B180 Offset: 0x1D5B281 VA: 0x1D5B180
	private void CommandSkill() { }

	// RVA: 0x1D5B2B0 Offset: 0x1D5B3B1 VA: 0x1D5B2B0
	private void VisionCreate() { }

	// RVA: 0x1D5B380 Offset: 0x1D5B481 VA: 0x1D5B380
	private void VisionDelete() { }

	// RVA: 0x1D5B450 Offset: 0x1D5B551 VA: 0x1D5B450
	private void DestroyVillage() { }

	// RVA: 0x1D5BF30 Offset: 0x1D5C031 VA: 0x1D5BF30
	public void EventBattle() { }

	// RVA: 0x1D5BFE0 Offset: 0x1D5C0E1 VA: 0x1D5BFE0
	public void BattleCalc(BattleInfo info) { }

	// RVA: 0x1D5C3E0 Offset: 0x1D5C4E1 VA: 0x1D5C3E0
	public void GainItem(Unit unit, UnitItem item) { }

	// RVA: 0x1D5C4A0 Offset: 0x1D5C5A1 VA: 0x1D5C4A0
	public void EquipItem(Unit unit) { }

	// RVA: 0x1D5C4B0 Offset: 0x1D5C5B1 VA: 0x1D5C4B0
	public void TakeOffItem(Unit unit) { }

	// RVA: 0x1D5C4C0 Offset: 0x1D5C5C1 VA: 0x1D5C4C0
	public void SortItem(Unit unit) { }

	// RVA: 0x1D5C4D0 Offset: 0x1D5C5D1 VA: 0x1D5C4D0
	public void PutOffItem(Unit unit, bool fromMenu) { }

	// RVA: 0x1D5C6B0 Offset: 0x1D5C7B1 VA: 0x1D5C6B0
	public void MindDone() { }

	// RVA: 0x1D5CD10 Offset: 0x1D5CE11 VA: 0x1D5CD10
	public void Status(Unit unit) { }

	// RVA: 0x1D5CDD0 Offset: 0x1D5CED1 VA: 0x1D5CDD0
	public void Status(Unit unit, long status) { }

	// RVA: 0x1D5CE90 Offset: 0x1D5CF91 VA: 0x1D5CE90
	public void Hp(Unit unit) { }

	// RVA: 0x1D5CF50 Offset: 0x1D5D051 VA: 0x1D5CF50
	public void Hp(Unit unit, int hp) { }

	// RVA: 0x1D5D010 Offset: 0x1D5D111 VA: 0x1D5D010
	public void BaseCapability(Unit unit, int index) { }

	// RVA: 0x1D5D0E0 Offset: 0x1D5D1E1 VA: 0x1D5D0E0
	public void EngageCount(Unit unit) { }

	// RVA: 0x1D5D1A0 Offset: 0x1D5D2A1 VA: 0x1D5D1A0
	public void EngageCount(Unit unit, int engageCount) { }

	// RVA: 0x1D5D260 Offset: 0x1D5D361 VA: 0x1D5D260
	public void ExtraSight(Unit unit) { }

	// RVA: 0x1D5D320 Offset: 0x1D5D421 VA: 0x1D5D320
	public void Exp(Unit unit) { }

	// RVA: 0x1D5D400 Offset: 0x1D5D501 VA: 0x1D5D400
	public void LevelUp(Unit unit) { }

	// RVA: 0x1D5D530 Offset: 0x1D5D631 VA: 0x1D5D530
	public void ClassChange(Unit unit) { }

	// RVA: 0x1D5D6D0 Offset: 0x1D5D7D1 VA: 0x1D5D6D0
	public void Position(Unit unit) { }

	// RVA: 0x1D5D790 Offset: 0x1D5D891 VA: 0x1D5D790
	public void Position(Unit unit, int newX, int newZ) { }

	// RVA: 0x1D5D870 Offset: 0x1D5D971 VA: 0x1D5D870
	public void AngleOnce(Unit unit) { }

	// RVA: 0x1D5D9F0 Offset: 0x1D5DAF1 VA: 0x1D5D9F0
	public void PrivateSkill(Unit unit) { }

	// RVA: 0x1D5DAB0 Offset: 0x1D5DBB1 VA: 0x1D5DAB0
	public void EnhanceFactorItem(Unit unit) { }

	// RVA: 0x1D5DB70 Offset: 0x1D5DC71 VA: 0x1D5DB70
	public void AIActive(Unit unit) { }

	// RVA: 0x1D5DC40 Offset: 0x1D5DD41 VA: 0x1D5DC40
	public void AIBand(Unit unit) { }

	// RVA: 0x1D5DD20 Offset: 0x1D5DE21 VA: 0x1D5DD20
	public void AIPriority(Unit unit) { }

	// RVA: 0x1D5DDE0 Offset: 0x1D5DEE1 VA: 0x1D5DDE0
	public void AISequence(Unit unit, AIValue.Order order) { }

	// RVA: 0x1D5DED0 Offset: 0x1D5DFD1 VA: 0x1D5DED0
	public void AIValue(Unit unit, AIValue.Order order, int index) { }

	// RVA: 0x1D5DFF0 Offset: 0x1D5E0F1 VA: 0x1D5DFF0
	public void AIProhibitEngageAttack(Unit unit) { }

	// RVA: 0x1D5E0B0 Offset: 0x1D5E1B1 VA: 0x1D5E0B0
	public void AIProhibitRod(Unit unit) { }

	// RVA: 0x1D5E170 Offset: 0x1D5E271 VA: 0x1D5E170
	public void AIProhibitOverlap(Unit unit) { }

	// RVA: 0x1D5E230 Offset: 0x1D5E331 VA: 0x1D5E230
	public void AIEngageAttackOnceDone(Unit unit) { }

	// RVA: 0x1D5E300 Offset: 0x1D5E401 VA: 0x1D5E300
	public void AIRerewarp(Unit unit) { }

	// RVA: 0x1D5E410 Offset: 0x1D5E511 VA: 0x1D5E410
	public void AIRerewarpCount(Unit unit) { }

	// RVA: 0x1D5E4D0 Offset: 0x1D5E5D1 VA: 0x1D5E4D0
	public void Engage(Unit unit, Unit linkUnit, bool isEvent, bool isForceLink, MapHistory.Rewind.IsEngagings rewindIsEngage) { }

	// RVA: 0x1D5E820 Offset: 0x1D5E921 VA: 0x1D5E820
	private void EngageImpl(Unit unit, Unit linkUnit, bool withName, MapHistory.Rewind.IsEngagings rewindIsEngage) { }

	// RVA: 0x1D5EA90 Offset: 0x1D5EB91 VA: 0x1D5EA90
	private void ChangeGodForEngageImpl(Unit unit, MapHistory.Rewind.IsEngagings rewindIsEngage) { }

	// RVA: 0x1D5E780 Offset: 0x1D5E881 VA: 0x1D5E780
	private bool IsEngaging(Unit unit, MapHistory.Rewind.IsEngagings rewindIsEngage) { }

	// RVA: 0x1D5ECB0 Offset: 0x1D5EDB1 VA: 0x1D5ECB0
	public void Dead(Unit unit) { }

	// RVA: 0x1D5ED90 Offset: 0x1D5EE91 VA: 0x1D5ED90
	public void Transfer(Unit unit, Force.Type nextForceType) { }

	// RVA: 0x1D5F380 Offset: 0x1D5F481 VA: 0x1D5F380
	public void Revive(Unit unit) { }

	// RVA: 0x1D5F470 Offset: 0x1D5F571 VA: 0x1D5F470
	public void UnitPhaseBeginAllBegin() { }

	// RVA: 0x1D5F4E0 Offset: 0x1D5F5E1 VA: 0x1D5F4E0
	public void UnitPhaseBeginOneBegin(Unit unit) { }

	// RVA: 0x1D5F570 Offset: 0x1D5F671 VA: 0x1D5F570
	public void UnitPhaseBeginStatus(Unit unit) { }

	// RVA: 0x1D5F620 Offset: 0x1D5F721 VA: 0x1D5F620
	public void UnitPhaseBeginPrivateSkill(Unit unit) { }

	// RVA: 0x1D5F6A0 Offset: 0x1D5F7A1 VA: 0x1D5F6A0
	public void UnitPhaseBeginExtraSight(Unit unit) { }

	// RVA: 0x1D5F720 Offset: 0x1D5F821 VA: 0x1D5F720
	public void UnitPhaseBeginEngageTurn(Unit unit) { }

	// RVA: 0x1D5F7A0 Offset: 0x1D5F8A1 VA: 0x1D5F7A0
	public void UnitPhaseBeginEngage(Unit unit) { }

	// RVA: 0x1D5F840 Offset: 0x1D5F941 VA: 0x1D5F840
	public void UnitPhaseBeginEngageCount(Unit unit) { }

	// RVA: 0x1D5F8C0 Offset: 0x1D5F9C1 VA: 0x1D5F8C0
	public void UnitPhaseBeginAIProhibitEngageAttack(Unit unit) { }

	// RVA: 0x1D5F940 Offset: 0x1D5FA41 VA: 0x1D5F940
	public void UnitPhaseBeginAIProhibitRod(Unit unit) { }

	// RVA: 0x1D5F9C0 Offset: 0x1D5FAC1 VA: 0x1D5F9C0
	public void UnitPhaseBeginAIProhibitOverlap(Unit unit) { }

	// RVA: 0x1D5FA40 Offset: 0x1D5FB41 VA: 0x1D5FA40
	public void UnitPhaseBeginMultiChangeGod(Unit unit, GodData godData) { }

	// RVA: 0x1D5FAC0 Offset: 0x1D5FBC1 VA: 0x1D5FAC0
	public void UnitPhaseBeginPosition(Unit unit) { }

	// RVA: 0x1D5FB40 Offset: 0x1D5FC41 VA: 0x1D5FB40
	public void UnitPhaseBeginOneEnd(Unit unit) { }

	// RVA: 0x1D5FBC0 Offset: 0x1D5FCC1 VA: 0x1D5FBC0
	public void UnitPhaseBeginAllEnd() { }

	// RVA: 0x1D5F600 Offset: 0x1D5F701 VA: 0x1D5F600
	private void UnitPhaseBeginAdd(MapHistory.RewindUnitPhaseBeginKinds kind) { }

	// RVA: 0x1D5F5F0 Offset: 0x1D5F6F1 VA: 0x1D5F5F0
	private bool UnitPhaseBeginTest(MapHistory.RewindUnitPhaseBeginKinds kind) { }

	// RVA: 0x1D5FC70 Offset: 0x1D5FD71 VA: 0x1D5FC70
	private bool UnitPhaseBeginTest(int flag, MapHistory.RewindUnitPhaseBeginKinds kind) { }

	// RVA: 0x1D5FC60 Offset: 0x1D5FD61 VA: 0x1D5FC60
	private int UnitPhaseBeginKind2Flag(MapHistory.RewindUnitPhaseBeginKinds kind) { }

	// RVA: 0x1D5FC80 Offset: 0x1D5FD81 VA: 0x1D5FC80
	public void UnitPhaseEndAllBegin() { }

	// RVA: 0x1D5FCF0 Offset: 0x1D5FDF1 VA: 0x1D5FCF0
	public void UnitPhaseEndOne(Unit unit) { }

	// RVA: 0x1D5FD70 Offset: 0x1D5FE71 VA: 0x1D5FD70
	public void UnitPhaseEndAllEnd() { }

	// RVA: 0x1D5FE10 Offset: 0x1D5FF11 VA: 0x1D5FE10
	public void UnitItem(Unit unit, int index) { }

	// RVA: 0x1D5C5F0 Offset: 0x1D5C6F1 VA: 0x1D5C5F0
	public void UnitItemList(Unit unit) { }

	// RVA: 0x1D5BD10 Offset: 0x1D5BE11 VA: 0x1D5BD10
	private void UnitItemListOnce(Unit unit) { }

	// RVA: 0x1D5FEF0 Offset: 0x1D5FFF1 VA: 0x1D5FEF0
	public void Dispos(Unit unit) { }

	// RVA: 0x1D5FFA0 Offset: 0x1D600A1 VA: 0x1D5FFA0
	public void GodCreate(GodData godData) { }

	// RVA: 0x1D60040 Offset: 0x1D60141 VA: 0x1D60040
	public void GodDelete(GodUnit godUnit) { }

	// RVA: 0x1D600F0 Offset: 0x1D601F1 VA: 0x1D600F0
	public void GodConnect(Unit unit) { }

	// RVA: 0x1D601C0 Offset: 0x1D602C1 VA: 0x1D601C0
	public void GodDisconnect(Unit unit) { }

	// RVA: 0x1D60290 Offset: 0x1D60391 VA: 0x1D60290
	public void GodChange(Unit unit) { }

	// RVA: 0x1D604B0 Offset: 0x1D605B1 VA: 0x1D604B0
	public void GodExp(GodUnit godUnit, Unit unit) { }

	// RVA: 0x1D60590 Offset: 0x1D60691 VA: 0x1D60590
	public void GodLevelUp(GodUnit godUnit, Unit unit) { }

	// RVA: 0x1D606B0 Offset: 0x1D607B1 VA: 0x1D606B0
	public void GodDarkness(GodUnit godUnit) { }

	// RVA: 0x1D60770 Offset: 0x1D60871 VA: 0x1D60770
	public void GodState(Unit unit, int index) { }

	// RVA: 0x1D60850 Offset: 0x1D60951 VA: 0x1D60850
	public void RelianceScore(Unit unitA, Unit unitB) { }

	// RVA: 0x1D60990 Offset: 0x1D60A91 VA: 0x1D60990
	public void TransporterData(int index, Transporter.Data data) { }

	// RVA: 0x1D60B60 Offset: 0x1D60C61 VA: 0x1D60B60
	public void CannonShells(CannonInspector cannonInspector) { }

	// RVA: 0x1D60C60 Offset: 0x1D60D61 VA: 0x1D60C60
	public void TerrainOpen(int x, int z) { }

	// RVA: 0x1D60D20 Offset: 0x1D60E21 VA: 0x1D60D20
	public void TerrainBroken(int x, int z) { }

	// RVA: 0x1D60DE0 Offset: 0x1D60EE1 VA: 0x1D60DE0
	public void TerrainAction(int x, int z, MapObject.Actions action) { }

	// RVA: 0x1D60EC0 Offset: 0x1D60FC1 VA: 0x1D60EC0
	public void TerrainSetBegin() { }

	// RVA: 0x1D60F50 Offset: 0x1D61051 VA: 0x1D60F50
	public void TerrainSet(int x, int z) { }

	// RVA: 0x1D61100 Offset: 0x1D61201 VA: 0x1D61100
	public void TerrainSetEnd() { }

	// RVA: 0x1D611D0 Offset: 0x1D612D1 VA: 0x1D611D0
	public void OverlapBegin() { }

	// RVA: 0x1D61260 Offset: 0x1D61361 VA: 0x1D61260
	public void Overlap(int x, int z, string tid) { }

	// RVA: 0x1D61390 Offset: 0x1D61491 VA: 0x1D61390
	public void OverlapEnd() { }

	// RVA: 0x1D61460 Offset: 0x1D61561 VA: 0x1D61460
	public void Gold(int gold) { }

	// RVA: 0x1D61510 Offset: 0x1D61611 VA: 0x1D61510
	public void Material(ItemData.Kinds kind) { }

	// RVA: 0x1D616B0 Offset: 0x1D617B1 VA: 0x1D616B0
	public void PieceOfBond() { }

	// RVA: 0x1D617C0 Offset: 0x1D618C1 VA: 0x1D617C0
	public void Variable(string key) { }

	// RVA: 0x1D61A30 Offset: 0x1D61B31 VA: 0x1D61A30
	public void WinRule() { }

	// RVA: 0x1D61B40 Offset: 0x1D61C41 VA: 0x1D61B40
	public void WinRuleEnemyNum() { }

	// RVA: 0x1D61C20 Offset: 0x1D61D21 VA: 0x1D61C20
	public void WinRuleLimitTurn() { }

	// RVA: 0x1D61D00 Offset: 0x1D61E01 VA: 0x1D61D00
	public void WinRuleMID() { }

	// RVA: 0x1D61DF0 Offset: 0x1D61EF1 VA: 0x1D61DF0
	public void FieldBgmPhaseBgm(string playerPhaseBgm, string enemyPhaseBgm, string allyPhaseBgm) { }

	// RVA: 0x1D61ED0 Offset: 0x1D61FD1 VA: 0x1D61ED0
	public void FieldBgmWarSituation(string warSituationStateName) { }

	// RVA: 0x1D61F80 Offset: 0x1D62081 VA: 0x1D61F80
	public void EngageBreak(Unit unit) { }

	// RVA: 0x1D62040 Offset: 0x1D62141 VA: 0x1D62040
	public void RangeBegin() { }

	// RVA: 0x1D620C0 Offset: 0x1D621C1 VA: 0x1D620C0
	public void Range(int x, int z) { }

	// RVA: 0x1D621E0 Offset: 0x1D622E1 VA: 0x1D621E0
	public void RangeEnd() { }

	// RVA: 0x1D62290 Offset: 0x1D62391 VA: 0x1D62290
	public void RangeClear() { }

	// RVA: 0x1D624C0 Offset: 0x1D625C1 VA: 0x1D624C0
	public void GodEscaping(GodUnit godUnit) { }

	// RVA: 0x1D62580 Offset: 0x1D62681 VA: 0x1D62580
	public void GodNotifyLevelCapTalk(GodUnit godUnit, Unit unit) { }

	// RVA: 0x1D62640 Offset: 0x1D62741 VA: 0x1D62640
	public void DangerShowing(Unit unit) { }

	// RVA: 0x1D62800 Offset: 0x1D62901 VA: 0x1D62800
	public void MapKillBonus(int x, int z, MapKillBonus.Kinds kind) { }

	// RVA: 0x1D62940 Offset: 0x1D62A41 VA: 0x1D62940
	public void GodDirty(GodUnit godUnit) { }

	// RVA: 0x1D62A00 Offset: 0x1D62B01 VA: 0x1D62A00
	public void EffectCreate(string name, Vector3 position, Quaternion rotation) { }

	// RVA: 0x1D62B20 Offset: 0x1D62C21 VA: 0x1D62B20
	public void EffectDeleteBegin() { }

	// RVA: 0x1D62B90 Offset: 0x1D62C91 VA: 0x1D62B90
	public void EffectDelete(string name, Vector3 position, Quaternion rotation) { }

	// RVA: 0x1D62C60 Offset: 0x1D62D61 VA: 0x1D62C60
	public void EffectDeleteEnd() { }

	// RVA: 0x1D62D10 Offset: 0x1D62E11 VA: 0x1D62D10
	public void MaterialFloatBegin(string name, string material, string property) { }

	// RVA: 0x1D62D90 Offset: 0x1D62E91 VA: 0x1D62D90
	public void MaterialFloat(float val) { }

	// RVA: 0x1D62E10 Offset: 0x1D62F11 VA: 0x1D62E10
	public void MaterialFloatEnd() { }

	// RVA: 0x1D62EB0 Offset: 0x1D62FB1 VA: 0x1D62EB0
	public void MaterialColorBegin(string name, string material, string property) { }

	// RVA: 0x1D62F30 Offset: 0x1D63031 VA: 0x1D62F30
	public void MaterialColor(Color color) { }

	// RVA: 0x1D62FE0 Offset: 0x1D630E1 VA: 0x1D62FE0
	public void MaterialColorEnd() { }

	// RVA: 0x1D63080 Offset: 0x1D63181 VA: 0x1D63080
	public void FieldBgmSpecialTurn(int turn) { }

	// RVA: 0x1D63130 Offset: 0x1D63231 VA: 0x1D63130
	public void PostChangeBgmEvent(string eventName) { }

	// RVA: 0x1D63250 Offset: 0x1D63351 VA: 0x1D63250
	public void TerrainEndurance(int x, int z, int hp, int maxHp) { }

	// RVA: 0x1D63340 Offset: 0x1D63441 VA: 0x1D63340
	public void TerrainState(int x, int z, int state) { }

	// RVA: 0x1D63420 Offset: 0x1D63521 VA: 0x1D63420
	public void LoseRuleMID() { }

	// RVA: 0x1D63510 Offset: 0x1D63611 VA: 0x1D63510
	public void BattleStart(Unit unit, MapMind.Type mind) { }

	// RVA: 0x1D63600 Offset: 0x1D63701 VA: 0x1D63600
	public void PhaseBeginAfter() { }

	// RVA: 0x1D63690 Offset: 0x1D63791 VA: 0x1D63690
	public void ClearRing(Unit unit) { }

	// RVA: 0x1D63760 Offset: 0x1D63861 VA: 0x1D63760
	public void MapKillBonusCount(int x, int z, MapKillBonus.Kinds kind) { }

	// RVA: 0x1D638F0 Offset: 0x1D639F1 VA: 0x1D638F0
	public void UnitRecord(Unit unit, UnitRecord.Kinds kind) { }

	// RVA: 0x1D639D0 Offset: 0x1D63AD1 VA: 0x1D639D0
	public void SkillCharge() { }

	// RVA: 0x1D5F2A0 Offset: 0x1D5F3A1 VA: 0x1D5F2A0
	public void ExtraHpStock(Unit unit, bool isSet) { }

	// RVA: 0x1D63A20 Offset: 0x1D63B21 VA: 0x1D63A20
	public void EngageTurn(Unit unit) { }

	// RVA: 0x1D5B520 Offset: 0x1D5B621 VA: 0x1D5B520
	private void EngageWait() { }

	// RVA: 0x1D5B700 Offset: 0x1D5B801 VA: 0x1D5B700
	private void EngageSummon() { }

	// RVA: 0x1D63AE0 Offset: 0x1D63BE1 VA: 0x1D63AE0
	public void MapSightUsable() { }

	// RVA: 0x1D63BC0 Offset: 0x1D63CC1 VA: 0x1D63BC0
	public void PlainHpStock(Unit unit) { }

	// RVA: 0x1D5C3D0 Offset: 0x1D5C4D1 VA: 0x1D5C3D0
	private void MageCannonUnitItemListOnce(Unit unit) { }

	// RVA: 0x1D5B7D0 Offset: 0x1D5B8D1 VA: 0x1D5B7D0
	private void Contract() { }

	// RVA: 0x1D5B8A0 Offset: 0x1D5B9A1 VA: 0x1D5B8A0
	private void FullBullet() { }

	// RVA: 0x1D63C80 Offset: 0x1D63D81 VA: 0x1D63C80
	public void ResetLockTarget(Unit unit) { }

	// RVA: 0x1D5B980 Offset: 0x1D5BA81 VA: 0x1D5B980
	private void Enchant() { }

	// RVA: 0x1D63D40 Offset: 0x1D63E41 VA: 0x1D63D40
	public void EnchantWeapon() { }

	// RVA: 0x1D63E80 Offset: 0x1D63F81 VA: 0x1D63E80
	public void AIBulletPattern(Unit unit) { }

	// RVA: 0x1D63F40 Offset: 0x1D64041 VA: 0x1D63F40
	public void PositionListBegin() { }

	// RVA: 0x1D63FE0 Offset: 0x1D640E1 VA: 0x1D63FE0
	public void PositionList(Unit unit) { }

	// RVA: 0x1D640D0 Offset: 0x1D641D1 VA: 0x1D640D0
	public void PositionListEnd() { }

	// RVA: 0x1D641B0 Offset: 0x1D642B1 VA: 0x1D641B0
	public void AIMoveLimit(Unit unit) { }

	// RVA: 0x1D642B0 Offset: 0x1D643B1 VA: 0x1D642B0
	public void TerrainActionMove(int x, int z, int movedX, int movedZ, MapObject.Actions action, int state) { }

	// RVA: 0x1D643D0 Offset: 0x1D644D1 VA: 0x1D643D0
	public void AIMagicShieldOnceDone(Unit unit) { }

	// RVA: 0x1D644A0 Offset: 0x1D645A1 VA: 0x1D644A0
	public void RandomGame() { }

	// RVA: 0x1D64550 Offset: 0x1D64651 VA: 0x1D64550
	public void FullBulletAttack() { }

	// RVA: 0x1D645A0 Offset: 0x1D646A1 VA: 0x1D645A0
	public void LockTarget(Unit unit) { }

	// RVA: 0x1D646A0 Offset: 0x1D647A1 VA: 0x1D646A0
	public void AIEnchantWeaponDone(Unit unit) { }

	// RVA: 0x1D4FBF0 Offset: 0x1D4FCF1 VA: 0x1D4FBF0
	private bool CreateLogOne(MapHistory.RewindLogBuilder builder, int index) { }

	// RVA: 0x1D64770 Offset: 0x1D64871 VA: 0x1D64770
	private bool CreateLogPhaseBegin(MapHistory.RewindLogBuilder builder) { }

	// RVA: 0x1D64980 Offset: 0x1D64A81 VA: 0x1D64980
	private bool CreateLogPhaseNext(MapHistory.RewindLogBuilder builder) { }

	// RVA: 0x1D649D0 Offset: 0x1D64AD1 VA: 0x1D649D0
	private bool CreateLogPickUp(MapHistory.RewindLogBuilder builder) { }

	// RVA: 0x1D64AF0 Offset: 0x1D64BF1 VA: 0x1D64AF0
	private bool CreateLogFixed(MapHistory.RewindLogBuilder builder) { }

	// RVA: 0x1D64B90 Offset: 0x1D64C91 VA: 0x1D64B90
	private bool CreateLogTalk(MapHistory.RewindLogBuilder builder) { }

	// RVA: 0x1D64C20 Offset: 0x1D64D21 VA: 0x1D64C20
	private bool CreateLogAttack(MapHistory.RewindLogBuilder builder) { }

	// RVA: 0x1D64E50 Offset: 0x1D64F51 VA: 0x1D64E50
	private bool CreateLogRod(MapHistory.RewindLogBuilder builder) { }

	// RVA: 0x1D65060 Offset: 0x1D65161 VA: 0x1D65060
	private bool CreateLogEngageCharge(MapHistory.RewindLogBuilder builder) { }

	// RVA: 0x1D650F0 Offset: 0x1D651F1 VA: 0x1D650F0
	private bool CreateLogDestroy(MapHistory.RewindLogBuilder builder) { }

	// RVA: 0x1D65170 Offset: 0x1D65271 VA: 0x1D65170
	private bool CreateLogItemUse(MapHistory.RewindLogBuilder builder) { }

	// RVA: 0x1D65250 Offset: 0x1D65351 VA: 0x1D65250
	private bool CreateLogTrade(MapHistory.RewindLogBuilder builder) { }

	// RVA: 0x1D65300 Offset: 0x1D65401 VA: 0x1D65300
	private bool CreateLogVisit(MapHistory.RewindLogBuilder builder) { }

	// RVA: 0x1D65380 Offset: 0x1D65481 VA: 0x1D65380
	private bool CreateLogBreakdown(MapHistory.RewindLogBuilder builder) { }

	// RVA: 0x1D65480 Offset: 0x1D65581 VA: 0x1D65480
	private bool CreateLogEscape(MapHistory.RewindLogBuilder builder) { }

	// RVA: 0x1D65500 Offset: 0x1D65601 VA: 0x1D65500
	private bool CreateLogDoor(MapHistory.RewindLogBuilder builder) { }

	// RVA: 0x1D65580 Offset: 0x1D65681 VA: 0x1D65580
	private bool CreateLogTorch(MapHistory.RewindLogBuilder builder) { }

	// RVA: 0x1D65640 Offset: 0x1D65741 VA: 0x1D65640
	private bool CreateLogTreasureBox(MapHistory.RewindLogBuilder builder) { }

	// RVA: 0x1D656C0 Offset: 0x1D657C1 VA: 0x1D656C0
	private bool CreateLogTransporter(MapHistory.RewindLogBuilder builder) { }

	// RVA: 0x1D65750 Offset: 0x1D65851 VA: 0x1D65750
	private bool CreateLogDance(MapHistory.RewindLogBuilder builder) { }

	// RVA: 0x1D657E0 Offset: 0x1D658E1 VA: 0x1D657E0
	private bool CreateLogGuard(MapHistory.RewindLogBuilder builder) { }

	// RVA: 0x1D658D0 Offset: 0x1D659D1 VA: 0x1D658D0
	private bool CreateLogOverlapSkill(MapHistory.RewindLogBuilder builder) { }

	// RVA: 0x1D65950 Offset: 0x1D65A51 VA: 0x1D65950
	private bool CreateLogCommandSkill(MapHistory.RewindLogBuilder builder) { }

	// RVA: 0x1D65AD0 Offset: 0x1D65BD1 VA: 0x1D65AD0
	private bool CreateLogVisionCreate(MapHistory.RewindLogBuilder builder) { }

	// RVA: 0x1D65B50 Offset: 0x1D65C51 VA: 0x1D65B50
	private bool CreateLogVisionDelete(MapHistory.RewindLogBuilder builder) { }

	// RVA: 0x1D65BD0 Offset: 0x1D65CD1 VA: 0x1D65BD0
	private bool CreateLogDestroyVillage(MapHistory.RewindLogBuilder builder) { }

	// RVA: 0x1D65C50 Offset: 0x1D65D51 VA: 0x1D65C50
	private bool CreateLogEngage(MapHistory.RewindLogBuilder builder) { }

	// RVA: 0x1D65DA0 Offset: 0x1D65EA1 VA: 0x1D65DA0
	private bool CreateLogDead(MapHistory.RewindLogBuilder builder) { }

	// RVA: 0x1D65E40 Offset: 0x1D65F41 VA: 0x1D65E40
	private bool CreateLogGainItem(MapHistory.RewindLogBuilder builder) { }

	// RVA: 0x1D65EA0 Offset: 0x1D65FA1 VA: 0x1D65EA0
	private bool CreateLogGodChange(MapHistory.RewindLogBuilder builder) { }

	// RVA: 0x1D65EB0 Offset: 0x1D65FB1 VA: 0x1D65EB0
	private bool CreateLogEngageBreak(MapHistory.RewindLogBuilder builder) { }

	// RVA: 0x1D66010 Offset: 0x1D66111 VA: 0x1D66010
	private bool CreateLogPutOff(MapHistory.RewindLogBuilder builder) { }

	// RVA: 0x1D660A0 Offset: 0x1D661A1 VA: 0x1D660A0
	private bool CreateLogPhaseBeginAfter(MapHistory.RewindLogBuilder builder) { }

	// RVA: 0x1D660C0 Offset: 0x1D661C1 VA: 0x1D660C0
	private bool CreateLogEngageWait(MapHistory.RewindLogBuilder builder) { }

	// RVA: 0x1D660D0 Offset: 0x1D661D1 VA: 0x1D660D0
	private bool CreateLogEngageSummon(MapHistory.RewindLogBuilder builder) { }

	// RVA: 0x1D660E0 Offset: 0x1D661E1 VA: 0x1D660E0
	private bool CreateLogContract(MapHistory.RewindLogBuilder builder) { }

	// RVA: 0x1D660F0 Offset: 0x1D661F1 VA: 0x1D660F0
	private bool CreateLogFullBullet(MapHistory.RewindLogBuilder builder) { }

	// RVA: 0x1D66100 Offset: 0x1D66201 VA: 0x1D66100
	private bool CreateLogEnchant(MapHistory.RewindLogBuilder builder) { }

	// RVA: 0x1D53330 Offset: 0x1D53431 VA: 0x1D53330
	private void PreviewApplyOne(int index) { }

	// RVA: 0x1D546E0 Offset: 0x1D547E1 VA: 0x1D546E0
	private void PreviewApplyOneInv(int index) { }

	// RVA: 0x1D66110 Offset: 0x1D66211 VA: 0x1D66110
	private void PreviewApplyPhaseBegin() { }

	// RVA: 0x1D661E0 Offset: 0x1D662E1 VA: 0x1D661E0
	private void PreviewApplyPhaseNext() { }

	// RVA: 0x1D66350 Offset: 0x1D66451 VA: 0x1D66350
	private void PreviewApplyPickUp() { }

	// RVA: 0x1D66460 Offset: 0x1D66561 VA: 0x1D66460
	private void PreviewApplyRod() { }

	// RVA: 0x1D66520 Offset: 0x1D66621 VA: 0x1D66520
	private void PreviewApplyEngageCharge() { }

	// RVA: 0x1D66610 Offset: 0x1D66711 VA: 0x1D66610
	private void PreviewApplyItemUse() { }

	// RVA: 0x1D666C0 Offset: 0x1D667C1 VA: 0x1D666C0
	private void PreviewApplyTrade() { }

	// RVA: 0x1D66740 Offset: 0x1D66841 VA: 0x1D66740
	private void PreviewApplyTransporter() { }

	// RVA: 0x1D66790 Offset: 0x1D66891 VA: 0x1D66790
	private void PreviewApplyBattleCalc() { }

	// RVA: 0x1D66AB0 Offset: 0x1D66BB1 VA: 0x1D66AB0
	private void PreviewApplyStatus() { }

	// RVA: 0x1D66AF0 Offset: 0x1D66BF1 VA: 0x1D66AF0
	private void PreviewApplyHp() { }

	// RVA: 0x1D66B40 Offset: 0x1D66C41 VA: 0x1D66B40
	private void PreviewApplyBaseCapability() { }

	// RVA: 0x1D66BE0 Offset: 0x1D66CE1 VA: 0x1D66BE0
	private void PreviewApplyEngageCount() { }

	// RVA: 0x1D66C30 Offset: 0x1D66D31 VA: 0x1D66C30
	private void PreviewApplyExtraSight() { }

	// RVA: 0x1D66CF0 Offset: 0x1D66DF1 VA: 0x1D66CF0
	private void PreviewApplyExp() { }

	// RVA: 0x1D66E50 Offset: 0x1D66F51 VA: 0x1D66E50
	private void PreviewApplyLevelUp() { }

	// RVA: 0x1D67060 Offset: 0x1D67161 VA: 0x1D67060
	private void PreviewApplyClassChange() { }

	// RVA: 0x1D67350 Offset: 0x1D67451 VA: 0x1D67350
	public void PreviewApplyPosition() { }

	// RVA: 0x1D673C0 Offset: 0x1D674C1 VA: 0x1D673C0
	public void PreviewApplyAngle() { }

	// RVA: 0x1D67480 Offset: 0x1D67581 VA: 0x1D67480
	public void PreviewApplyPrivateSkill() { }

	// RVA: 0x1D674D0 Offset: 0x1D675D1 VA: 0x1D674D0
	public void PreviewApplyEnhanceFactorItem() { }

	// RVA: 0x1D67520 Offset: 0x1D67621 VA: 0x1D67520
	public void PreviewApplyAIActive() { }

	// RVA: 0x1D675A0 Offset: 0x1D676A1 VA: 0x1D675A0
	public void PreviewApplyAIBand() { }

	// RVA: 0x1D676F0 Offset: 0x1D677F1 VA: 0x1D676F0
	public void PreviewApplyAIPriority() { }

	// RVA: 0x1D67770 Offset: 0x1D67871 VA: 0x1D67770
	public void PreviewApplyAISequence() { }

	// RVA: 0x1D67810 Offset: 0x1D67911 VA: 0x1D67810
	public void PreviewApplyAIValue() { }

	// RVA: 0x1D67980 Offset: 0x1D67A81 VA: 0x1D67980
	public void PreviewApplyAIProhibitEngageAttack() { }

	// RVA: 0x1D67A00 Offset: 0x1D67B01 VA: 0x1D67A00
	public void PreviewApplyAIProhibitRod() { }

	// RVA: 0x1D67A80 Offset: 0x1D67B81 VA: 0x1D67A80
	public void PreviewApplyAIProhibitOverlap() { }

	// RVA: 0x1D67B00 Offset: 0x1D67C01 VA: 0x1D67B00
	public void PreviewApplyAIEngageAttackOnceDone() { }

	// RVA: 0x1D67BE0 Offset: 0x1D67CE1 VA: 0x1D67BE0
	public void PreviewApplyAIRerewarp() { }

	// RVA: 0x1D67D60 Offset: 0x1D67E61 VA: 0x1D67D60
	public void PreviewApplyAIRerewarpCount() { }

	// RVA: 0x1D67DE0 Offset: 0x1D67EE1 VA: 0x1D67DE0
	public void PreviewApplyEngage() { }

	// RVA: 0x1D4F810 Offset: 0x1D4F911 VA: 0x1D4F810
	private void ReadEngage(out Unit unit) { }

	// RVA: 0x1D6FC60 Offset: 0x1D6FD61 VA: 0x1D6FC60
	private void PreviewApplyEngageImpl(bool withName, bool isForceLink) { }

	// RVA: 0x1D70010 Offset: 0x1D70111 VA: 0x1D70010
	private void PreviewApplyChangeGodForEngageImpl(Unit unit) { }

	// RVA: 0x1D67F90 Offset: 0x1D68091 VA: 0x1D67F90
	public void PreviewApplyTransfer(int version) { }

	// RVA: 0x1D55EE0 Offset: 0x1D55FE1 VA: 0x1D55EE0
	private void ReadTransfer(int version, out int mapHistoryIndex, out Force.Type forceType, out Force.Type nextForceType) { }

	// RVA: 0x1D700E0 Offset: 0x1D701E1 VA: 0x1D700E0
	private void ReadTransfer(int version, out int mapHistoryIndex, out Force.Type forceType, out Force.Type nextForceType, out Unit prevUnit, out long status, out bool isReadUnitItemList, out bool isGodChanged, out string gid, out string actualGid, out string rnid) { }

	// RVA: 0x1D70440 Offset: 0x1D70541 VA: 0x1D70440
	private void ReadTransferImpl(int version, out int mapHistoryIndex, out Force.Type forceType, out Force.Type nextForceType, out int prevUnitMapHistoryIndex, out long status, out bool isReadUnitItemList, out bool isGodChanged, out string gid, out string actualGid, out string rnid) { }

	// RVA: 0x1D70220 Offset: 0x1D70321 VA: 0x1D70220
	public void ChangeGodForTransfer(int version, Unit unit, string gid) { }

	// RVA: 0x1D70770 Offset: 0x1D70871 VA: 0x1D70770
	public void ChangeGodForTransferV0(Unit unit) { }

	// RVA: 0x1D70830 Offset: 0x1D70931 VA: 0x1D70830
	public void ChangeGodForTransferV1(Unit unit, string gid) { }

	// RVA: 0x1D70300 Offset: 0x1D70401 VA: 0x1D70300
	public void SetGodDataForTransfer(Unit unit, string gid) { }

	// RVA: 0x1D703D0 Offset: 0x1D704D1 VA: 0x1D703D0
	public void SetRingOwnerForTransfer(Unit unit, string rnid) { }

	// RVA: 0x1D68200 Offset: 0x1D68301 VA: 0x1D68200
	public void PreviewApplyRevive(int version) { }

	// RVA: 0x1D68320 Offset: 0x1D68421 VA: 0x1D68320
	public void PreviewApplyUnitPhaseBegin() { }

	// RVA: 0x1D68FE0 Offset: 0x1D690E1 VA: 0x1D68FE0
	public void PreviewApplyUnitPhaseEnd() { }

	// RVA: 0x1D69090 Offset: 0x1D69191 VA: 0x1D69090
	public void PreviewApplyUnitItem() { }

	// RVA: 0x1D69120 Offset: 0x1D69221 VA: 0x1D69120
	public void PreviewApplyUnitItemList() { }

	// RVA: 0x1D70840 Offset: 0x1D70941 VA: 0x1D70840
	private void ReadUnitItemList(out Unit unit) { }

	// RVA: 0x1D69170 Offset: 0x1D69271 VA: 0x1D69170
	public void PreviewApplyDispos() { }

	// RVA: 0x1D69210 Offset: 0x1D69311 VA: 0x1D69210
	public void PreviewApplyGodCreate() { }

	// RVA: 0x1D69240 Offset: 0x1D69341 VA: 0x1D69240
	public void PreviewApplyGodDelete() { }

	// RVA: 0x1D69270 Offset: 0x1D69371 VA: 0x1D69270
	public void PreviewApplyGodConnect() { }

	// RVA: 0x1D69300 Offset: 0x1D69401 VA: 0x1D69300
	public void PreviewApplyGodDisconnect() { }

	// RVA: 0x1D69380 Offset: 0x1D69481 VA: 0x1D69380
	public void PreviewApplyGodChange() { }

	// RVA: 0x1D70880 Offset: 0x1D70981 VA: 0x1D70880
	private void ReadGodChange(out string name) { }

	// RVA: 0x1D4FA70 Offset: 0x1D4FB71 VA: 0x1D4FA70
	private void ReadGodChange(out Unit unit, out string gid) { }

	// RVA: 0x1D694B0 Offset: 0x1D695B1 VA: 0x1D694B0
	public void PreviewApplyGodExp() { }

	// RVA: 0x1D695A0 Offset: 0x1D696A1 VA: 0x1D695A0
	public void PreviewApplyGodLevelUp(int version) { }

	// RVA: 0x1D697A0 Offset: 0x1D698A1 VA: 0x1D697A0
	public void PreviewApplyGodDarkness() { }

	// RVA: 0x1D69860 Offset: 0x1D69961 VA: 0x1D69860
	public void PreviewApplyGodState() { }

	// RVA: 0x1D69930 Offset: 0x1D69A31 VA: 0x1D69930
	public void PreviewApplyRelianceScore() { }

	// RVA: 0x1D699D0 Offset: 0x1D69AD1 VA: 0x1D699D0
	public void PreviewApplyTransporterData() { }

	// RVA: 0x1D69AE0 Offset: 0x1D69BE1 VA: 0x1D69AE0
	public void PreviewApplyCannonShells() { }

	// RVA: 0x1D69C40 Offset: 0x1D69D41 VA: 0x1D69C40
	public void PreviewApplyTerrainOpen() { }

	// RVA: 0x1D69D70 Offset: 0x1D69E71 VA: 0x1D69D70
	public void PreviewApplyTerrainBroken() { }

	// RVA: 0x1D6C3E0 Offset: 0x1D6C4E1 VA: 0x1D6C3E0
	public void PreviewApplyTerrainAction() { }

	// RVA: 0x1D69E90 Offset: 0x1D69F91 VA: 0x1D69E90
	public void PreviewApplyTerrainSet() { }

	// RVA: 0x1D6A060 Offset: 0x1D6A161 VA: 0x1D6A060
	public void PreviewApplyOverlap() { }

	// RVA: 0x1D6FB50 Offset: 0x1D6FC51 VA: 0x1D6FB50
	private void PreviewApplyOverlapOne() { }

	// RVA: 0x1D6A120 Offset: 0x1D6A221 VA: 0x1D6A120
	public void PreviewApplyGold() { }

	// RVA: 0x1D6A230 Offset: 0x1D6A331 VA: 0x1D6A230
	public void PreviewApplyMaterial() { }

	// RVA: 0x1D6A460 Offset: 0x1D6A561 VA: 0x1D6A460
	public void PreviewApplyPieceOfBond() { }

	// RVA: 0x1D6A620 Offset: 0x1D6A721 VA: 0x1D6A620
	public void PreviewApplyVariable() { }

	// RVA: 0x1D6AC50 Offset: 0x1D6AD51 VA: 0x1D6AC50
	public void PreviewApplyKizunaRecord() { }

	// RVA: 0x1D6AD90 Offset: 0x1D6AE91 VA: 0x1D6AD90
	public void PreviewApplyWinRule() { }

	// RVA: 0x1D6AEE0 Offset: 0x1D6AFE1 VA: 0x1D6AEE0
	public void PreviewApplyWinRuleEnemyNum() { }

	// RVA: 0x1D6AFB0 Offset: 0x1D6B0B1 VA: 0x1D6AFB0
	public void PreviewApplyWinRuleLimitTurn() { }

	// RVA: 0x1D6B0C0 Offset: 0x1D6B1C1 VA: 0x1D6B0C0
	public void PreviewApplyWinRuleMID() { }

	// RVA: 0x1D6B5F0 Offset: 0x1D6B6F1 VA: 0x1D6B5F0
	public void PreviewApplyFieldBgmPhaseBgm() { }

	// RVA: 0x1D6BD40 Offset: 0x1D6BE41 VA: 0x1D6BD40
	public void PreviewApplyFieldBgmWarSituation() { }

	// RVA: 0x1D6C020 Offset: 0x1D6C121 VA: 0x1D6C020
	public void PreviewApplyRange() { }

	// RVA: 0x1D6C2D0 Offset: 0x1D6C3D1 VA: 0x1D6C2D0
	public void PreviewApplyGodEscaping() { }

	// RVA: 0x1D6C390 Offset: 0x1D6C491 VA: 0x1D6C390
	public void PreviewApplyGodNotifyLevelCapTalk() { }

	// RVA: 0x1D6C520 Offset: 0x1D6C621 VA: 0x1D6C520
	public void PreviewApplyDangerShowing() { }

	// RVA: 0x1D6C600 Offset: 0x1D6C701 VA: 0x1D6C600
	public void PreviewApplyMapKillBonus() { }

	// RVA: 0x1D6C7B0 Offset: 0x1D6C8B1 VA: 0x1D6C7B0
	public void PreviewApplyPutOff() { }

	// RVA: 0x1D6C800 Offset: 0x1D6C901 VA: 0x1D6C800
	public void PreviewApplyGodDirty() { }

	// RVA: 0x1D6C880 Offset: 0x1D6C981 VA: 0x1D6C880
	public void PreviewApplyEffectCreate() { }

	// RVA: 0x1D6F260 Offset: 0x1D6F361 VA: 0x1D6F260
	public void PreviewApplyEffectCreateInv() { }

	// RVA: 0x1D6CAF0 Offset: 0x1D6CBF1 VA: 0x1D6CAF0
	public void PreviewApplyEffectDelete() { }

	// RVA: 0x1D6F6F0 Offset: 0x1D6F7F1 VA: 0x1D6F6F0
	public void PreviewApplyEffectDeleteInv() { }

	// RVA: 0x1D6CFA0 Offset: 0x1D6D0A1 VA: 0x1D6CFA0
	public void PreviewApplyMaterialFloat() { }

	// RVA: 0x1D6D0F0 Offset: 0x1D6D1F1 VA: 0x1D6D0F0
	public void PreviewApplyMaterialColor() { }

	// RVA: 0x1D6D400 Offset: 0x1D6D501 VA: 0x1D6D400
	public void PreviewApplyFieldBgmSpecialTurn() { }

	// RVA: 0x1D6D4B0 Offset: 0x1D6D5B1 VA: 0x1D6D4B0
	public void PreviewApplyPostChangeBgmEvent() { }

	// RVA: 0x1D6D730 Offset: 0x1D6D831 VA: 0x1D6D730
	public void PreviewApplyTerrainEndurance() { }

	// RVA: 0x1D6D8C0 Offset: 0x1D6D9C1 VA: 0x1D6D8C0
	public void PreviewApplyTerrainState() { }

	// RVA: 0x1D6DA00 Offset: 0x1D6DB01 VA: 0x1D6DA00
	public void PreviewApplyLoseRuleMID() { }

	// RVA: 0x1D6DF30 Offset: 0x1D6E031 VA: 0x1D6DF30
	public void PreviewApplyBattleStart() { }

	// RVA: 0x1D6DF70 Offset: 0x1D6E071 VA: 0x1D6DF70
	public void PreviewApplyClearRing() { }

	// RVA: 0x1D6DFB0 Offset: 0x1D6E0B1 VA: 0x1D6DFB0
	public void PreviewApplyMapKillBonusCount() { }

	// RVA: 0x1D6E160 Offset: 0x1D6E261 VA: 0x1D6E160
	public void PreviewApplyUnitRecord() { }

	// RVA: 0x1D6E2C0 Offset: 0x1D6E3C1 VA: 0x1D6E2C0
	public void PreviewApplyExtraHpStock() { }

	// RVA: 0x1D6E410 Offset: 0x1D6E511 VA: 0x1D6E410
	private void PreviewApplyEngageTurn() { }

	// RVA: 0x1D6E460 Offset: 0x1D6E561 VA: 0x1D6E460
	private void PreviewApplyEngageWait() { }

	// RVA: 0x1D6E550 Offset: 0x1D6E651 VA: 0x1D6E550
	private void PreviewApplyMapSightUsable() { }

	// RVA: 0x1D6E660 Offset: 0x1D6E761 VA: 0x1D6E660
	public void PreviewApplyPlainHpStock() { }

	// RVA: 0x1D6E6F0 Offset: 0x1D6E7F1 VA: 0x1D6E6F0
	private void PreviewApplyFullBullet() { }

	// RVA: 0x1D6E780 Offset: 0x1D6E881 VA: 0x1D6E780
	private void PreviewApplyResetLockTarget() { }

	// RVA: 0x1D6E810 Offset: 0x1D6E911 VA: 0x1D6E810
	private void PreviewApplyEnchant() { }

	// RVA: 0x1D6E8C0 Offset: 0x1D6E9C1 VA: 0x1D6E8C0
	private void PreviewApplyEnchantWeapon() { }

	// RVA: 0x1D6EA20 Offset: 0x1D6EB21 VA: 0x1D6EA20
	public void PreviewApplyAIBulletPattern() { }

	// RVA: 0x1D6EAA0 Offset: 0x1D6EBA1 VA: 0x1D6EAA0
	public void PreviewApplyPositionList() { }

	// RVA: 0x1D6EB50 Offset: 0x1D6EC51 VA: 0x1D6EB50
	public void PreviewApplyAIMoveLimit() { }

	// RVA: 0x1D6ED30 Offset: 0x1D6EE31 VA: 0x1D6ED30
	public void PreviewApplyTerrainActionMove() { }

	// RVA: 0x1D6EFC0 Offset: 0x1D6F0C1 VA: 0x1D6EFC0
	public void PreviewApplyAIMagicShieldOnceDone() { }

	// RVA: 0x1D6F0A0 Offset: 0x1D6F1A1 VA: 0x1D6F0A0
	public void PreviewApplyRandomGame() { }

	// RVA: 0x1D6F0F0 Offset: 0x1D6F1F1 VA: 0x1D6F0F0
	private void PreviewApplyLockTarget() { }

	// RVA: 0x1D6F180 Offset: 0x1D6F281 VA: 0x1D6F180
	public void PreviewApplyAIEnchantWeaponDone() { }

	[ConditionalAttribute] // RVA: 0x2C7940 Offset: 0x2C7A41 VA: 0x2C7940
	// RVA: 0x1D708D0 Offset: 0x1D709D1 VA: 0x1D708D0
	private void DbgDumpCommand(StringBuilder sb, int index) { }

	// RVA: 0x1D708E0 Offset: 0x1D709E1 VA: 0x1D708E0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C7980 Offset: 0x2C7A81 VA: 0x2C7980
	// RVA: 0x1D70A50 Offset: 0x1D70B51 VA: 0x1D70A50
	private void <SerializeTerrain>b__103_0(int x, int z) { }
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
private enum MapHistory.RewindUnitPhaseBeginKinds // TypeDefIndex: 12085
{
	// Fields
	public byte value__; // 0x0
	public const MapHistory.RewindUnitPhaseBeginKinds Status = 0;
	public const MapHistory.RewindUnitPhaseBeginKinds PrivateSkill = 1;
	public const MapHistory.RewindUnitPhaseBeginKinds ExtraSight = 2;
	public const MapHistory.RewindUnitPhaseBeginKinds EngageTurn = 3;
	public const MapHistory.RewindUnitPhaseBeginKinds Engage = 4;
	public const MapHistory.RewindUnitPhaseBeginKinds AIProhibitEngageAttack = 5;
	public const MapHistory.RewindUnitPhaseBeginKinds AIProhibitRod = 6;
	public const MapHistory.RewindUnitPhaseBeginKinds AIProhibitOverlap = 7;
	public const MapHistory.RewindUnitPhaseBeginKinds EngageCount = 8;
	public const MapHistory.RewindUnitPhaseBeginKinds MultiChangeGod = 9;
	public const MapHistory.RewindUnitPhaseBeginKinds Position = 10;
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
private class MapHistory.RewindCommandWriter : MapHistory.CommandWriter // TypeDefIndex: 12087
{
	// Methods

	// RVA: 0x23FD730 Offset: 0x23FD831 VA: 0x23FD730
	public void Prepare(MapHistory.RewindType type) { }

	// RVA: 0x23FD740 Offset: 0x23FD841 VA: 0x23FD740
	public void WriteUnitAndName(Unit unit) { }

	// RVA: 0x23FD770 Offset: 0x23FD871 VA: 0x23FD770
	public void WriteUnit(Unit unit) { }

	// RVA: 0x23FD830 Offset: 0x23FD931 VA: 0x23FD830
	public void WriteName(Unit unit) { }

	// RVA: 0x23FDA60 Offset: 0x23FDB61 VA: 0x23FDA60
	public void WritePosition(Unit unit) { }

	// RVA: 0x23FDAA0 Offset: 0x23FDBA1 VA: 0x23FDAA0
	public void WriteStatus(Unit unit) { }

	// RVA: 0x23FDB10 Offset: 0x23FDC11 VA: 0x23FDB10
	public void WriteStatus(long status) { }

	// RVA: 0x23FDB20 Offset: 0x23FDC21 VA: 0x23FDB20
	public void WriteHp(Unit unit) { }

	// RVA: 0x23FDB30 Offset: 0x23FDC31 VA: 0x23FDB30
	public void WriteHp(int hp) { }

	// RVA: 0x23FDB40 Offset: 0x23FDC41 VA: 0x23FDB40
	public void WriteBaseCapability(Unit unit, int index) { }

	// RVA: 0x23FDBC0 Offset: 0x23FDCC1 VA: 0x23FDBC0
	public void WriteBaseCapabilityAll(Unit unit) { }

	// RVA: 0x23FDD90 Offset: 0x23FDE91 VA: 0x23FDD90
	public void WriteGrowCapabilityAll(Unit unit) { }

	// RVA: 0x23FDF70 Offset: 0x23FE071 VA: 0x23FDF70
	public void WriteLevelCapabilityAll(Unit unit) { }

	// RVA: 0x23FDBD0 Offset: 0x23FDCD1 VA: 0x23FDBD0
	private void WriteUnitBaseCapabilityAll(UnitBaseCapability capability) { }

	// RVA: 0x23FDF80 Offset: 0x23FE081 VA: 0x23FDF80
	public void WriteEngageCount(Unit unit) { }

	// RVA: 0x23FDF90 Offset: 0x23FE091 VA: 0x23FDF90
	public void WriteEngageCount(int engageCount) { }

	// RVA: 0x23FDFA0 Offset: 0x23FE0A1 VA: 0x23FDFA0
	public void WriteEngageTurn(Unit unit) { }

	// RVA: 0x23FDFB0 Offset: 0x23FE0B1 VA: 0x23FDFB0
	public void WriteShowInSearchMap(Unit unit, int moveX = -1, int moveZ = -1) { }

	// RVA: 0x23FE110 Offset: 0x23FE211 VA: 0x23FE110
	public void WriteTurn(int turn) { }

	// RVA: 0x23FE120 Offset: 0x23FE221 VA: 0x23FE120
	public void WriteForce(Force.Type forceType) { }

	// RVA: 0x23FE130 Offset: 0x23FE231 VA: 0x23FE130
	public void WriteSkills(SkillArray skills) { }

	// RVA: 0x23FE150 Offset: 0x23FE251 VA: 0x23FE150
	public void WriteUnitPhaseBeginKinds(MapHistory.RewindUnitPhaseBeginKinds kind) { }

	// RVA: 0x23FE160 Offset: 0x23FE261 VA: 0x23FE160
	public void WriteUnitItem(UnitItem item) { }

	// RVA: 0x23FE180 Offset: 0x23FE281 VA: 0x23FE180
	public void WriteUnitItemList(UnitItemList itemList) { }

	// RVA: 0x23FE1A0 Offset: 0x23FE2A1 VA: 0x23FE1A0
	public void WriteGodUnit(GodUnit godUnit) { }

	// RVA: 0x23FE250 Offset: 0x23FE351 VA: 0x23FE250
	public void WriteTransporterData(Transporter.Data data) { }

	// RVA: 0x23FE270 Offset: 0x23FE371 VA: 0x23FE270
	public void WriteOverlap(int x, int z) { }

	// RVA: 0x23FE280 Offset: 0x23FE381 VA: 0x23FE280
	public static void WriteOverlap(Stream stream, int x, int z) { }

	// RVA: 0x23FE3E0 Offset: 0x23FE4E1 VA: 0x23FE3E0
	public void WriteUnitIconInfo(Unit unit) { }

	// RVA: 0x23FEC70 Offset: 0x23FED71 VA: 0x23FEC70
	public void WriteLockTarget(Unit unit) { }

	// RVA: 0x23FED30 Offset: 0x23FEE31 VA: 0x23FED30
	public void OverwriteByte(int pos, byte val) { }

	// RVA: 0x23FEDA0 Offset: 0x23FEEA1 VA: 0x23FEDA0
	public void OverwriteUshort(int pos, ushort val) { }

	// RVA: 0x23FEE10 Offset: 0x23FEF11 VA: 0x23FEE10
	public void .ctor() { }
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
public struct MapHistory.RewindUnitMap.Data : MapHistory.UnitMapBase.IData<MapHistory.RewindUnitMap, MapHistory.RewindUnitMap.Data> // TypeDefIndex: 12089
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x299AE0 Offset: 0x299BE1 VA: 0x299AE0
	private Unit <unit>k__BackingField; // 0x0
	public Force.Type forceType; // 0x8
	public Stream stream; // 0x10
	public byte[] buffer; // 0x18
	public bool isRestoredInPreview; // 0x20
	public bool isCreatedInPreview; // 0x21
	public bool isUsedInPreview; // 0x22
	public bool isBeforeDisposInPreview; // 0x23

	// Properties
	public Unit unit { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C7990 Offset: 0x2C7A91 VA: 0x2C7990
	[IsReadOnlyAttribute] // RVA: 0x2C7990 Offset: 0x2C7A91 VA: 0x2C7990
	// RVA: 0x21E4EB0 Offset: 0x21E4FB1 VA: 0x21E4EB0 Slot: 4
	public Unit get_unit() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C79D0 Offset: 0x2C7AD1 VA: 0x2C79D0
	// RVA: 0x21E4EC0 Offset: 0x21E4FC1 VA: 0x21E4EC0 Slot: 5
	public void set_unit(Unit value) { }

	// RVA: 0x21E4ED0 Offset: 0x21E4FD1 VA: 0x21E4ED0 Slot: 6
	public bool IsUsed() { }

	// RVA: 0x21E4EF0 Offset: 0x21E4FF1 VA: 0x21E4EF0 Slot: 7
	public void Clear() { }
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
private class MapHistory.RewindNameMap : MapHistory.IdMapBase<MapHistory.RewindNameMap> // TypeDefIndex: 12091
{
	// Fields
	private const byte IdMask = 127;
	private const byte EditNameBit = 128;

	// Properties
	protected override int Version { get; }

	// Methods

	// RVA: 0x23FFEE0 Offset: 0x23FFFE1 VA: 0x23FFEE0
	public void .ctor() { }

	// RVA: 0x23FD8E0 Offset: 0x23FD9E1 VA: 0x23FD8E0
	public int Entry(Unit unit) { }

	// RVA: 0x23FBD50 Offset: 0x23FBE51 VA: 0x23FBD50
	public string TryGet(int index) { }

	// RVA: 0x23FFF40 Offset: 0x2400041 VA: 0x23FFF40 Slot: 4
	protected override int get_Version() { }

	// RVA: 0x23FFF50 Offset: 0x2400051 VA: 0x23FFF50 Slot: 11
	protected override void OnSerialize(Stream stream) { }

	// RVA: 0x2400120 Offset: 0x2400221 VA: 0x2400120 Slot: 12
	protected override void OnDeserialize(Stream stream, int version) { }
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
public class MapHistory.RewindLog.UnitIcon // TypeDefIndex: 12093
{
	// Fields
	private PersonData m_Person; // 0x10
	private JobData m_Job; // 0x18
	private ItemData.Kinds m_ItemKind; // 0x20
	private bool m_IsFemale; // 0x24
	private bool m_IsEngage; // 0x25
	private GodData m_God; // 0x28

	// Properties
	public PersonData Person { get; }
	public JobData Job { get; }
	public ItemData.Kinds ItemKind { get; }
	public bool IsFemale { get; }
	public bool IsEngage { get; }
	public GodData God { get; }

	// Methods

	// RVA: 0x21E4AC0 Offset: 0x21E4BC1 VA: 0x21E4AC0
	public void .ctor() { }

	// RVA: 0x21E4B20 Offset: 0x21E4C21 VA: 0x21E4B20
	public void Clear() { }

	// RVA: 0x21E4B70 Offset: 0x21E4C71 VA: 0x21E4B70
	public bool IsValid() { }

	// RVA: 0x21E4B80 Offset: 0x21E4C81 VA: 0x21E4B80
	public void Set(string pid, string jid, ItemData.Kinds itemKind, bool isFemale, bool isEngage, string gid) { }

	// RVA: 0x21E4DA0 Offset: 0x21E4EA1 VA: 0x21E4DA0
	public void SetEngage(string gid) { }

	// RVA: 0x21E4E50 Offset: 0x21E4F51 VA: 0x21E4E50
	public PersonData get_Person() { }

	// RVA: 0x21E4E60 Offset: 0x21E4F61 VA: 0x21E4E60
	public JobData get_Job() { }

	// RVA: 0x21E4E70 Offset: 0x21E4F71 VA: 0x21E4E70
	public ItemData.Kinds get_ItemKind() { }

	// RVA: 0x21E4E80 Offset: 0x21E4F81 VA: 0x21E4E80
	public bool get_IsFemale() { }

	// RVA: 0x21E4E90 Offset: 0x21E4F91 VA: 0x21E4E90
	public bool get_IsEngage() { }

	// RVA: 0x21E4EA0 Offset: 0x21E4FA1 VA: 0x21E4EA0
	public GodData get_God() { }
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

// Namespace: 
private class MapHistory.RewindLogBuilder // TypeDefIndex: 12095
{
	// Fields
	private MapHistory.RewindLog m_Log; // 0x10
	private bool m_IsNeedToBuild; // 0x18

	// Properties
	public MapHistory.RewindLog Log { get; }
	public bool IsNeedToBuild { get; }

	// Methods

	// RVA: 0x23FFDF0 Offset: 0x23FFEF1 VA: 0x23FFDF0
	public void .ctor() { }

	// RVA: 0x23FFE60 Offset: 0x23FFF61 VA: 0x23FFE60
	public void Prepare(MapHistory.RewindLog log) { }

	// RVA: 0x23FFE30 Offset: 0x23FFF31 VA: 0x23FFE30
	public void Clear() { }

	// RVA: 0x23FFEB0 Offset: 0x23FFFB1 VA: 0x23FFEB0
	public void NeedToBuild() { }

	// RVA: 0x23FFEC0 Offset: 0x23FFFC1 VA: 0x23FFEC0
	public MapHistory.RewindLog get_Log() { }

	// RVA: 0x23FFED0 Offset: 0x23FFFD1 VA: 0x23FFED0
	public bool get_IsNeedToBuild() { }
}

