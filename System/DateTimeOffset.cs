// Namespace: System
[Serializable]
public struct DateTimeOffset : IComparable, IFormattable, ISerializable, IDeserializationCallback, IComparable<DateTimeOffset>, IEquatable<DateTimeOffset> // TypeDefIndex: 198
{
	// Fields
	public static readonly DateTimeOffset MinValue; // 0x0
	public static readonly DateTimeOffset MaxValue; // 0x10
	private DateTime m_dateTime; // 0x0
	private short m_offsetMinutes; // 0x8

	// Properties
	public static DateTimeOffset UtcNow { get; }
	public DateTime DateTime { get; }
	public DateTime UtcDateTime { get; }
	public DateTime LocalDateTime { get; }
	private DateTime ClockDateTime { get; }
	public TimeSpan Offset { get; }

	// Methods

	// RVA: 0x35C0760 Offset: 0x35C0861 VA: 0x35C0760
	public void .ctor(long ticks, TimeSpan offset) { }

	// RVA: 0x35C09E0 Offset: 0x35C0AE1 VA: 0x35C09E0
	public void .ctor(DateTime dateTime) { }

	// RVA: 0x35C0AA0 Offset: 0x35C0BA1 VA: 0x35C0AA0
	public void .ctor(DateTime dateTime, TimeSpan offset) { }

	// RVA: 0x35C0C40 Offset: 0x35C0D41 VA: 0x35C0C40
	public static DateTimeOffset get_UtcNow() { }

	// RVA: 0x35C0D90 Offset: 0x35C0E91 VA: 0x35C0D90
	public DateTime get_DateTime() { }

	// RVA: 0x35C0E60 Offset: 0x35C0F61 VA: 0x35C0E60
	public DateTime get_UtcDateTime() { }

	// RVA: 0x35C0EE0 Offset: 0x35C0FE1 VA: 0x35C0EE0
	public DateTime get_LocalDateTime() { }

	// RVA: 0x35C0DA0 Offset: 0x35C0EA1 VA: 0x35C0DA0
	private DateTime get_ClockDateTime() { }

	// RVA: 0x35C1010 Offset: 0x35C1111 VA: 0x35C1010
	public TimeSpan get_Offset() { }

	// RVA: 0x35C1050 Offset: 0x35C1151 VA: 0x35C1050
	public DateTimeOffset Add(TimeSpan timeSpan) { }

	// RVA: 0x35C10D0 Offset: 0x35C11D1 VA: 0x35C10D0 Slot: 4
	private int System.IComparable.CompareTo(object obj) { }

	// RVA: 0x35C12B0 Offset: 0x35C13B1 VA: 0x35C12B0 Slot: 8
	public int CompareTo(DateTimeOffset other) { }

	// RVA: 0x35C1410 Offset: 0x35C1511 VA: 0x35C1410 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x35C1570 Offset: 0x35C1671 VA: 0x35C1570 Slot: 9
	public bool Equals(DateTimeOffset other) { }

	// RVA: 0x35C1660 Offset: 0x35C1761 VA: 0x35C1660 Slot: 7
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x35C1800 Offset: 0x35C1901 VA: 0x35C1800 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x35C18E0 Offset: 0x35C19E1 VA: 0x35C18E0
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x35C1AB0 Offset: 0x35C1BB1 VA: 0x35C1AB0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x35C1B40 Offset: 0x35C1C41 VA: 0x35C1B40
	public TimeSpan Subtract(DateTimeOffset value) { }

	// RVA: 0x35C1C30 Offset: 0x35C1D31 VA: 0x35C1C30 Slot: 3
	public override string ToString() { }

	// RVA: 0x35C1D10 Offset: 0x35C1E11 VA: 0x35C1D10 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x35C0800 Offset: 0x35C0901 VA: 0x35C0800
	private static short ValidateOffset(TimeSpan offset) { }

	// RVA: 0x35C0920 Offset: 0x35C0A21 VA: 0x35C0920
	private static DateTime ValidateDate(DateTime dateTime, TimeSpan offset) { }

	// RVA: 0x35C1E10 Offset: 0x35C1F11 VA: 0x35C1E10
	public static DateTimeOffset op_Implicit(DateTime dateTime) { }

	// RVA: 0x35C1ED0 Offset: 0x35C1FD1 VA: 0x35C1ED0
	public static TimeSpan op_Subtraction(DateTimeOffset left, DateTimeOffset right) { }

	// RVA: 0x35C1FF0 Offset: 0x35C20F1 VA: 0x35C1FF0
	private static void .cctor() { }
}

