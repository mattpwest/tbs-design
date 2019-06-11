using UnityEngine;

public class TBSInput : MonoBehaviour
{
    [SerializeField]
    private KeyCode endTurnKey;
    
    [SerializeField]
    private TBS tbs;
    
    void Update()
    {
        if (Input.GetKeyDown(endTurnKey))
        {
            tbs.EndTurn();
        }
    }
}
