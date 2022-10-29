using UnityEngine;

namespace PlasmaAPI.Packs.ImportModel
{
    /// <summary>
    /// Interface for classes that create materials.
    /// </summary>
    internal interface IMaterialFactory
    {
        Material Create(string shaderName);
    }
}