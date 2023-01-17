// Namespace: System.Linq.Expressions
[DefaultMemberAttribute] // RVA: 0x3F980 Offset: 0x3FA81 VA: 0x3F980
internal class BlockExpressionList : IList<Expression>, ICollection<Expression>, IEnumerable<Expression>, IEnumerable // TypeDefIndex: 2801
{
	// Fields
	private readonly BlockExpression _block; // 0x10
	private readonly Expression _arg0; // 0x18

	// Properties
	public Expression Item { get; set; }
	public int Count { get; }
	[ExcludeFromCodeCoverageAttribute] // RVA: 0x42510 Offset: 0x42611 VA: 0x42510
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x2E51920 Offset: 0x2E51A21 VA: 0x2E51920
	internal void .ctor(BlockExpression provider, Expression arg0) { }

	// RVA: 0x2E51970 Offset: 0x2E51A71 VA: 0x2E51970 Slot: 6
	public int IndexOf(Expression item) { }

	[ExcludeFromCodeCoverageAttribute] // RVA: 0x41AB0 Offset: 0x41BB1 VA: 0x41AB0
	// RVA: 0x2E51A20 Offset: 0x2E51B21 VA: 0x2E51A20 Slot: 7
	public void Insert(int index, Expression item) { }

	[ExcludeFromCodeCoverageAttribute] // RVA: 0x41AC0 Offset: 0x41BC1 VA: 0x41AC0
	// RVA: 0x2E51A50 Offset: 0x2E51B51 VA: 0x2E51A50 Slot: 8
	public void RemoveAt(int index) { }

	// RVA: 0x2E51A80 Offset: 0x2E51B81 VA: 0x2E51A80 Slot: 4
	public Expression get_Item(int index) { }

	[ExcludeFromCodeCoverageAttribute] // RVA: 0x41AD0 Offset: 0x41BD1 VA: 0x41AD0
	// RVA: 0x2E51AA0 Offset: 0x2E51BA1 VA: 0x2E51AA0 Slot: 5
	public void set_Item(int index, Expression value) { }

	[ExcludeFromCodeCoverageAttribute] // RVA: 0x41AE0 Offset: 0x41BE1 VA: 0x41AE0
	// RVA: 0x2E51AD0 Offset: 0x2E51BD1 VA: 0x2E51AD0 Slot: 11
	public void Add(Expression item) { }

	[ExcludeFromCodeCoverageAttribute] // RVA: 0x41AF0 Offset: 0x41BF1 VA: 0x41AF0
	// RVA: 0x2E51B00 Offset: 0x2E51C01 VA: 0x2E51B00 Slot: 12
	public void Clear() { }

	// RVA: 0x2E51B30 Offset: 0x2E51C31 VA: 0x2E51B30 Slot: 13
	public bool Contains(Expression item) { }

	// RVA: 0x2E51BE0 Offset: 0x2E51CE1 VA: 0x2E51BE0 Slot: 14
	public void CopyTo(Expression[] array, int index) { }

	// RVA: 0x2E51E00 Offset: 0x2E51F01 VA: 0x2E51E00 Slot: 9
	public int get_Count() { }

	// RVA: 0x2E51E10 Offset: 0x2E51F11 VA: 0x2E51E10 Slot: 10
	public bool get_IsReadOnly() { }

	[ExcludeFromCodeCoverageAttribute] // RVA: 0x41B00 Offset: 0x41C01 VA: 0x41B00
	// RVA: 0x2E51E40 Offset: 0x2E51F41 VA: 0x2E51E40 Slot: 15
	public bool Remove(Expression item) { }

	[IteratorStateMachineAttribute] // RVA: 0x41B10 Offset: 0x41C11 VA: 0x41B10
	// RVA: 0x2E51E70 Offset: 0x2E51F71 VA: 0x2E51E70 Slot: 16
	public IEnumerator<Expression> GetEnumerator() { }

	// RVA: 0x2E51EF0 Offset: 0x2E51FF1 VA: 0x2E51EF0 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

