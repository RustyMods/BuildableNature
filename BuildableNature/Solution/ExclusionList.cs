using System.Collections.Generic;

namespace BuildableNature.Solution;

public static class ExclusionList
{
    public static bool IsExcluded(string name)
    {
        List<string> exclusion = new()
        {
            "CargoCrate",
            "Pickable_DvergerThing",
            "Beech_Sapling"
            // "PineTree"
        };
        return exclusion.Contains(name);
    }
}