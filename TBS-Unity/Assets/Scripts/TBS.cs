using UnityEngine;

public class TBS : MonoBehaviour
{
    [SerializeField]
    private TBSFaction[] factions;

    private int turn;
    private int active = -1;

    public void EndTurn()
    {
        active = (active + 1) % factions.Length;
        turn += 1;
        
        Debug.Log("Turn " + turn + ": " + factions[active]);
    }
    
    void Awake()
    {
        if (active < 0)
        {
            EndTurn();
        }
    }
}
