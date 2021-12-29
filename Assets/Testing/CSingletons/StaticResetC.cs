//namespace C
//{
//    using System.Collections.Generic;
//    using UnityEngine;
//    using UnityEngine.SceneManagement;

//    public interface IStaticResettableC
//    {
//        void ResetStatics();
//    }

//    public class StaticResetC : MonoBehaviour, ISerializationCallbackReceiver
//    {
//        [SerializeField, HideInInspector]
//        private List<MonoBehaviour> Resettables = new List<MonoBehaviour>();

//        public void OnBeforeSerialize()
//        {
//            //this.Resettables.Clear();
//            foreach (var go in GameObject.FindObjectsOfType<GameObject>())
//            {
//                foreach (var r in go.GetComponents<IStaticResettableC>())
//                {
//                    var m = (MonoBehaviour)r;
//                    //if (!this.Resettables.Contains(m))
//                    //{
//                    this.Resettables.Add(m);
//                    //}
//                }
//            }
//        }

//        public void OnAfterDeserialize()
//        {
//            foreach (var b in this.Resettables)
//            {
//                ((IStaticResettableC)b).ResetStatics();
//            }

//            Resettables.Clear();
//            // both scene manager and FindObjectsOfType could not operate during OnAfterDeserialize.
//        }
//    }
//}