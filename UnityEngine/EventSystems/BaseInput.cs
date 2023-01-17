// Namespace: UnityEngine.EventSystems
public class BaseInput : UIBehaviour // TypeDefIndex: 4417
{
	// Properties
	public virtual string compositionString { get; }
	public virtual IMECompositionMode imeCompositionMode { get; set; }
	public virtual Vector2 compositionCursorPos { get; set; }
	public virtual bool mousePresent { get; }
	public virtual Vector2 mousePosition { get; }
	public virtual Vector2 mouseScrollDelta { get; }
	public virtual bool touchSupported { get; }
	public virtual int touchCount { get; }

	// Methods

	// RVA: 0x1A3E040 Offset: 0x1A3E141 VA: 0x1A3E040 Slot: 17
	public virtual string get_compositionString() { }

	// RVA: 0x1A3E050 Offset: 0x1A3E151 VA: 0x1A3E050 Slot: 18
	public virtual IMECompositionMode get_imeCompositionMode() { }

	// RVA: 0x1A3E060 Offset: 0x1A3E161 VA: 0x1A3E060 Slot: 19
	public virtual void set_imeCompositionMode(IMECompositionMode value) { }

	// RVA: 0x1A3E070 Offset: 0x1A3E171 VA: 0x1A3E070 Slot: 20
	public virtual Vector2 get_compositionCursorPos() { }

	// RVA: 0x1A3E080 Offset: 0x1A3E181 VA: 0x1A3E080 Slot: 21
	public virtual void set_compositionCursorPos(Vector2 value) { }

	// RVA: 0x1A3E090 Offset: 0x1A3E191 VA: 0x1A3E090 Slot: 22
	public virtual bool get_mousePresent() { }

	// RVA: 0x1A3E0A0 Offset: 0x1A3E1A1 VA: 0x1A3E0A0 Slot: 23
	public virtual bool GetMouseButtonDown(int button) { }

	// RVA: 0x1A3E0B0 Offset: 0x1A3E1B1 VA: 0x1A3E0B0 Slot: 24
	public virtual bool GetMouseButtonUp(int button) { }

	// RVA: 0x1A3E0C0 Offset: 0x1A3E1C1 VA: 0x1A3E0C0 Slot: 25
	public virtual bool GetMouseButton(int button) { }

	// RVA: 0x1A3E0D0 Offset: 0x1A3E1D1 VA: 0x1A3E0D0 Slot: 26
	public virtual Vector2 get_mousePosition() { }

	// RVA: 0x1A3E0E0 Offset: 0x1A3E1E1 VA: 0x1A3E0E0 Slot: 27
	public virtual Vector2 get_mouseScrollDelta() { }

	// RVA: 0x1A3E0F0 Offset: 0x1A3E1F1 VA: 0x1A3E0F0 Slot: 28
	public virtual bool get_touchSupported() { }

	// RVA: 0x1A3E100 Offset: 0x1A3E201 VA: 0x1A3E100 Slot: 29
	public virtual int get_touchCount() { }

	// RVA: 0x1A3E110 Offset: 0x1A3E211 VA: 0x1A3E110 Slot: 30
	public virtual Touch GetTouch(int index) { }

	// RVA: 0x1A3E170 Offset: 0x1A3E271 VA: 0x1A3E170 Slot: 31
	public virtual float GetAxisRaw(string axisName) { }

	// RVA: 0x1A3E180 Offset: 0x1A3E281 VA: 0x1A3E180 Slot: 32
	public virtual bool GetButtonDown(string buttonName) { }

	// RVA: 0x1A3E190 Offset: 0x1A3E291 VA: 0x1A3E190
	public void .ctor() { }
}

