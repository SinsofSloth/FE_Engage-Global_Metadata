// Namespace: App
public class MapEditHistory : SingletonClass<MapEditHistory> // TypeDefIndex: 11975
{
	// Fields
	private const int MaxCommandCount = 64;
	private List<MapEditHistory.MapEditCommand> m_CommandList; // 0x20
	private int m_Index; // 0x28

	// Methods

	// RVA: 0x21AF6D0 Offset: 0x21AF7D1 VA: 0x21AF6D0 Slot: 5
	protected override void OnCreate() { }

	// RVA: 0x21AF7F0 Offset: 0x21AF8F1 VA: 0x21AF7F0 Slot: 6
	protected override void OnDispose() { }

	// RVA: 0x21AF800 Offset: 0x21AF901 VA: 0x21AF800
	public bool Undo() { }

	// RVA: 0x21AF940 Offset: 0x21AFA41 VA: 0x21AF940
	public void Redo() { }

	// RVA: 0x21AF760 Offset: 0x21AF861 VA: 0x21AF760
	public void Clear() { }

	// RVA: 0x21AF950 Offset: 0x21AFA51 VA: 0x21AF950
	public void AddCreateObject(int x, int z, string objectName) { }

	// RVA: 0x21AFB10 Offset: 0x21AFC11 VA: 0x21AFB10
	public void AddDeleteObject(int x, int z, string deleteObjectName, int rotate) { }

	// RVA: 0x21AFBB0 Offset: 0x21AFCB1 VA: 0x21AFBB0
	public void AddReplaceObject(int x, int z, int deleteRotate, string deleteObjName, string createObjName) { }

	// RVA: 0x21AFC50 Offset: 0x21AFD51 VA: 0x21AFC50
	public void AddRotateObject(int x, int z, int prevRotate, int nextRotate) { }

	// RVA: 0x21AF9E0 Offset: 0x21AFAE1 VA: 0x21AF9E0
	private void AddCommand(MapEditHistory.MapEditCommand command) { }

	// RVA: 0x21AFCF0 Offset: 0x21AFDF1 VA: 0x21AFCF0
	private void ListAddImpl(MapEditHistory.MapEditCommand command) { }

	// RVA: 0x21AF8E0 Offset: 0x21AF9E1 VA: 0x21AF8E0
	private void ListRemoveAtImpl(int index) { }

	// RVA: 0x21AFD50 Offset: 0x21AFE51 VA: 0x21AFD50
	public void Dump() { }

	// RVA: 0x21AFED0 Offset: 0x21AFFD1 VA: 0x21AFED0
	public void .ctor() { }
}

