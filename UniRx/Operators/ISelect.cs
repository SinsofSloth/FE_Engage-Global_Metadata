// Namespace: UniRx.Operators
internal interface ISelect<TR> // TypeDefIndex: 7039
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IObservable<TR> CombinePredicate(Func<TR, bool> predicate);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISelect<object>.CombinePredicate
	*/
}

