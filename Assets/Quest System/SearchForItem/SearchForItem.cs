using Lean.Pool;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
public class SearchForItem : MonoBehaviour
{
    IQR_mono _iQr_Mono;
    // Start is called before the first frame update
    void Start()
    {
        _iQr_Mono = GetComponent<IQR_mono>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Player"))
            foreach (var task in ServiceLocator.Instance.GetService<QuestBase>().CurrentTasksClasses)//todo
            {
                if (this.gameObject.tag == task.ObjectRelatedTag)
                {

                    
                    _iQr_Mono.IPO_PackageManager.InteractBehaviours();
                    //task.UpdateCondition();
                    ////ugly code
                    //if (this.gameObject.tag == "RedJewelBrooch") {

                    //    ServiceLocator.Instance.GetService<GameManager>().Flowchart.SetBooleanVariable("HasRedJewel", true);

                    //}

                    //LeanPool.Despawn(this);
                }
            }
    }
    public void PickUpItem()
    {


        foreach (var task in ServiceLocator.Instance.GetService<QuestBase>().CurrentTasksClasses)//todo
        {
            if (this.gameObject.tag == task.ObjectRelatedTag)
            {

                //_iQr_Mono.IPO_PackageManager.InteractBehaviours();
                task.UpdateCondition();
                //ugly code
                if (this.gameObject.tag == "RedJewelBrooch")
                {

                    ServiceLocator.Instance.GetService<GameManager>().Flowchart.SetBooleanVariable("HasRedJewel", true);

                }

                LeanPool.Despawn(this);
            }
        }

    }
}
