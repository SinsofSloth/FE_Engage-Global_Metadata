// Namespace: System
[Serializable]
public sealed class ConsoleCancelEventArgs : EventArgs // TypeDefIndex: 186
{
	// Fields
	private ConsoleSpecialKey _type; // 0x10
	private bool _cancel; // 0x14

	// Properties
	public bool Cancel { get; }

	// Methods

	// RVA: 0x33AFBA0 Offset: 0x33AFCA1 VA: 0x33AFBA0
	internal void .ctor(ConsoleSpecialKey type) { }

	// RVA: 0x33AFF90 Offset: 0x33B0091 VA: 0x33AFF90
	public bool get_Cancel() { }

	// RVA: 0x33AFFA0 Offset: 0x33B00A1 VA: 0x33AFFA0
	internal void .ctor() { }
}

