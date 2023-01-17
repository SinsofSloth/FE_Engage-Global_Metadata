// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class SerStack // TypeDefIndex: 1080
{
	// Fields
	internal object[] objects; // 0x10
	internal string stackId; // 0x18
	internal int top; // 0x20

	// Methods

	// RVA: 0x3617DA0 Offset: 0x3617EA1 VA: 0x3617DA0
	internal void .ctor(string stackId) { }

	// RVA: 0x3617E30 Offset: 0x3617F31 VA: 0x3617E30
	internal void Push(object obj) { }

	// RVA: 0x3617FD0 Offset: 0x36180D1 VA: 0x3617FD0
	internal object Pop() { }

	// RVA: 0x3617F40 Offset: 0x3618041 VA: 0x3617F40
	internal void IncreaseCapacity() { }

	// RVA: 0x3618050 Offset: 0x3618151 VA: 0x3618050
	internal object Peek() { }

	// RVA: 0x36180A0 Offset: 0x36181A1 VA: 0x36180A0
	internal object PeekPeek() { }

	// RVA: 0x36180F0 Offset: 0x36181F1 VA: 0x36180F0
	internal bool IsEmpty() { }
}

