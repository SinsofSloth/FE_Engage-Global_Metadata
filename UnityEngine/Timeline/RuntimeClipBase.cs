// Namespace: UnityEngine.Timeline
internal abstract class RuntimeClipBase : RuntimeElement // TypeDefIndex: 5661
{
	// Properties
	public abstract double start { get; }
	public abstract double duration { get; }
	public override long intervalStart { get; }
	public override long intervalEnd { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 11
	public abstract double get_start();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract double get_duration();

	// RVA: 0x36A8880 Offset: 0x36A8981 VA: 0x36A8880 Slot: 6
	public override long get_intervalStart() { }

	// RVA: 0x36A8910 Offset: 0x36A8A11 VA: 0x36A8910 Slot: 7
	public override long get_intervalEnd() { }

	// RVA: 0x36A7E60 Offset: 0x36A7F61 VA: 0x36A7E60
	protected void .ctor() { }
}

