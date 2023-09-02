/// <summary> 棋譜 </summary>
public class GameRecord
{
    private string _record = "";

    public string Record => _record;

    /// <summary> 棋譜に追記する </summary>
    public void Recording(string data)
    {
        _record += data;
    }

    /// <summary> 棋譜をリセットする </summary>
    public void ResetRecord()
    {
        _record = "";
    }
}
