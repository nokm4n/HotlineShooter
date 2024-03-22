public abstract class Singleton<T> where T : Singleton<T>, new()
{
	private static T _Instance = new T();
	public static T Instance => _Instance;
}
