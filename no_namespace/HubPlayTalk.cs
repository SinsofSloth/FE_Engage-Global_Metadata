// Namespace: 
public enum HubPlayTalk.TalkType // TypeDefIndex: 10750
{
	// Fields
	public int value__; // 0x0
	public const HubPlayTalk.TalkType Normal = 0;
	public const HubPlayTalk.TalkType Shop = 1;
	public const HubPlayTalk.TalkType Event = 2;
}

// Namespace: 
private class HubPlayTalk.CallPuppetEvent : ProcInst // TypeDefIndex: 10751
{
	// Fields
	private string File; // 0x70
	private string Mid; // 0x78

	// Methods

	// RVA: 0x1FB5840 Offset: 0x1FB5941 VA: 0x1FB5840
	public static void CreateBind(ProcInst super, string file, string mid) { }

	// RVA: 0x1FB58F0 Offset: 0x1FB59F1 VA: 0x1FB58F0
	private void .ctor(string file, string mid) { }

	// RVA: 0x1FB5BE0 Offset: 0x1FB5CE1 VA: 0x1FB5BE0
	private void Entry() { }

	// RVA: 0x1FB5C00 Offset: 0x1FB5D01 VA: 0x1FB5C00
	private void Main() { }

	// RVA: 0x1FB5C10 Offset: 0x1FB5D11 VA: 0x1FB5C10
	private void Exit() { }

	// RVA: 0x1FB5940 Offset: 0x1FB5A41 VA: 0x1FB5940
	private ProcDesc[] CreateDesc() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x277240 Offset: 0x277341 VA: 0x277240
[Serializable]
private sealed class HubPlayTalk.<>c // TypeDefIndex: 10752
{
	// Fields
	public static readonly HubPlayTalk.<>c <>9; // 0x0
	public static Action<HubUnitController> <>9__59_0; // 0x8
	public static Action<HubUnitController> <>9__60_0; // 0x10
	public static Action<HubUnitController> <>9__60_1; // 0x18

	// Methods

	// RVA: 0x1FB5760 Offset: 0x1FB5861 VA: 0x1FB5760
	private static void .cctor() { }

	// RVA: 0x1FB57D0 Offset: 0x1FB58D1 VA: 0x1FB57D0
	public void .ctor() { }

	// RVA: 0x1FB57E0 Offset: 0x1FB58E1 VA: 0x1FB57E0
	internal void <ReturnTalk>b__59_0(HubUnitController o) { }

	// RVA: 0x1FB5800 Offset: 0x1FB5901 VA: 0x1FB5800
	internal void <ReturnTalkEvent>b__60_0(HubUnitController o) { }

	// RVA: 0x1FB5820 Offset: 0x1FB5921 VA: 0x1FB5820
	internal void <ReturnTalkEvent>b__60_1(HubUnitController o) { }
}

