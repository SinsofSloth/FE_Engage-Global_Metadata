// Namespace: MoonSharp.Interpreter.REPL
public class ReplHistoryInterpreter : ReplInterpreter // TypeDefIndex: 6039
{
	// Fields
	private string[] m_History; // 0x28
	private int m_Last; // 0x30
	private int m_Navi; // 0x34

	// Methods

	// RVA: 0x30141E0 Offset: 0x30142E1 VA: 0x30141E0
	public void .ctor(Script script, int historySize) { }

	// RVA: 0x3014340 Offset: 0x3014441 VA: 0x3014340 Slot: 7
	public override DynValue Evaluate(string input) { }

	// RVA: 0x3014850 Offset: 0x3014951 VA: 0x3014850
	public string HistoryPrev() { }

	// RVA: 0x30148D0 Offset: 0x30149D1 VA: 0x30148D0
	public string HistoryNext() { }
}

