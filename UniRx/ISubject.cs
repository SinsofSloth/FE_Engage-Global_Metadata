// Namespace: UniRx
public interface ISubject<TSource, TResult> : IObserver<TSource>, IObservable<TResult> // TypeDefIndex: 6639
{}

// Namespace: UniRx
public interface ISubject<T> : ISubject<T, T>, IObserver<T>, IObservable<T> // TypeDefIndex: 6640
{}

