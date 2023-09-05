using System;

public abstract class Singleton<T>
{
    public static T Instance { get; private set; }

    public Singleton()
    {
        Instance ??= (T)Activator.CreateInstance(typeof(T));
    }
}
