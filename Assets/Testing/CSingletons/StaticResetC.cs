namespace C
{
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.SceneManagement;

    public interface IStaticResettableC
    {
        void ResetStatics();
    }

    [DefaultExecutionOrder(-1000)]
    public class StaticResetC : MonoBehaviour, ISerializationCallbackReceiver
    {
        [SerializeField]
        private List<MonoBehaviour> Resettables = new List<MonoBehaviour>();

        public void OnBeforeSerialize() 
        {
            foreach (var go in GameObject.FindObjectsOfType<GameObject>())
            {
                foreach (var r in go.GetComponentsInChildren<IStaticResettableC>())
                {
                    this.Resettables.Add((MonoBehaviour)r);
                }
            }
        }

        public void OnAfterDeserialize()
        {
            foreach (var b in this.Resettables)
            {
                ((IStaticResettableC)b).ResetStatics();
            }

            Resettables.Clear();
            // both scene manager and FindObjectsOfType could not operate during OnAfterDeserialize.
        }
    }
}