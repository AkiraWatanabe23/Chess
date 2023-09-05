using UnityEngine;

public class Debugger : SingletonMonoBehaviour<Debugger>
{
    [SerializeField]
    private bool _debugMode = false;

    public bool DebugMode => _debugMode;

    protected override bool DontDestroyOnLoad => true;
}
