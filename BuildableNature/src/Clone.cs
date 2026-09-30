using System;
using PieceManager;
using UnityEngine;

namespace BuildableNature;

public class Clone
{
    public GameObject Prefab;
    public GameObject Source;
    public string sourceId;
    public string prefix = "piece_";
    public string suffix = "_bn";
    public bool loaded;
    public event Action<GameObject> OnCreated;
    public Clone(string sourceId)
    {
        this.sourceId = sourceId;
        BuildPiece.clones.Add(this);
    }

    public void Create()
    {
        if (loaded) return;
        if (!BuildPiece.TryGetPrefab(sourceId, out Source))
        {
            BuildableNaturePlugin.BuildableNatureLogger.LogWarning("Failed to find " + sourceId);
            return;
        }
        
        Prefab = UnityEngine.Object.Instantiate(Source, BuildableNaturePlugin.m_root.transform);
        Prefab.name = prefix + sourceId + suffix;
        Prefab.RemovePathfindingBlockers();
        OnCreated?.Invoke(Prefab);
        loaded = true;
    }
}