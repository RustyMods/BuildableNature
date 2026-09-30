using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Object;

namespace BuildableNature;

public static class Extensions
{
    extension(GameObject prefab)
    {
        public void Remove<T>() where T : Component
        {
            if (!prefab.TryGetComponent(out T component)) return;
            DestroyImmediate(component);
        }

        public void SetLayerRecursively(int layer)
        {
            if (prefab.layer is 8 or 16) return;
            prefab.layer = layer;
            for (int i = 0; i < prefab.transform.childCount; ++i)
            {
                var child = prefab.transform.GetChild(i);
                SetLayerRecursively(child.gameObject, layer);
            }
        }

        public bool HasCollider()
        {
            if (prefab.TryGetComponent(out BoxCollider collider)) return true;
            collider = prefab.GetComponentInChildren<BoxCollider>();
            if (collider != null) return true;
            if (prefab.TryGetComponent(out SphereCollider sphereCollider)) return true;
            sphereCollider = prefab.GetComponentInChildren<SphereCollider>();
            return sphereCollider != null;
        }

        public Collider AddCollider(float modifier = 1f)
        {
            var renderer = prefab.GetComponentInChildren<MeshRenderer>();
            if (renderer == null) return null;
            GameObject root = new GameObject("collider");
            root.transform.SetParent(prefab.transform);
            BoxCollider collider = root.AddComponent<BoxCollider>();
            var bounds = renderer.bounds;

            Vector3 size = new Vector3(1f, bounds.size.y * modifier, 1f);
            Vector3 center = bounds.center;
            center.y = bounds.center.y + bounds.size.y * 0.5f * (1f - modifier);

            collider.size = size;
            collider.center = center;
            return collider;
        }

        public GameObject CreateAndSetUnderModel()
        {
            List<Transform> children = [];
            for (int i = 0; i < prefab.transform.childCount; ++i)
            {
                var child = prefab.transform.GetChild(i);
                children.Add(child);
            }
            GameObject model = new GameObject("model");
            model.transform.SetParent(prefab.transform);
            for (int i = 0; i < children.Count; ++i)
            {
                var child = children[i];
                child.SetParent(model.transform);
            }
            return model;
        }

        public void RemovePathfindingBlockers()
        {
            foreach (var collider in prefab.GetComponentsInChildren<SphereCollider>())
            {
                if (!collider.name.Contains("Pathfinding")) continue;
                DestroyImmediate(collider.gameObject);
            }
        }
    }
    
    public static Vector3[] GetLocalCorners(this BoxCollider box)
    {
        Vector3 c = box.center;
        Vector3 scale = box.transform.localScale;
        Vector3 size = box.size;
        bool vertical = box.transform.localRotation.z != 0f;
        Vector3 result;
        if (vertical) result = new Vector3(
            size.x * scale.y, 
            size.y * scale.x, 
            size.z * scale.z);
        else result = new Vector3(
            size.x * scale.x, 
            size.y * scale.y, 
            size.z * scale.z);
        Vector3 e = result * 0.5f;

        var corners = new Vector3[8];
        int i = 0;
        for (int x = -1; x <= 1; x += 2)
        for (int y = -1; y <= 1; y += 2)
        for (int z = -1; z <= 1; z += 2)
            corners[i++] = c + new Vector3(
                e.x * x, 
                e.y * y, 
                e.z * z);
        return corners;
    }
}