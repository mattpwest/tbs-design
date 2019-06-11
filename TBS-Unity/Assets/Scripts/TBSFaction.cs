using UnityEngine;

[CreateAssetMenu(fileName = "Faction", menuName = "TBS/Faction", order = 51)]
public class TBSFaction : ScriptableObject
{
    [SerializeField] private string name;
    [SerializeField] private Color color;
    
    public string Name => name;
    public Color Color => color;

    public override string ToString()
    {
        return name;
    }
}
