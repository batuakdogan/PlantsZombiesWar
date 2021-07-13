using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(Rigidbody2D))]
public class Saldiranlar : MonoBehaviour {

    //[Range(0f,2f)]
    private float SuAnkiHiz;
    private GameObject mevcutHedef;
    private Animator objeninAnimatoru;

    [Tooltip("Kaç saniyede bir doğacağını buraya giriniz.")]
    public float kacSaniyedeBirDogacak;
	// Use this for initialization
	void Start () {
        //Rigidbody2D objeninRigidbodysi = gameObject.AddComponent<Rigidbody2D>();
        //objeninRigidbodysi.isKinematic = true;
        objeninAnimatoru = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.left * SuAnkiHiz * Time.deltaTime);
        if (!mevcutHedef)
        {
            objeninAnimatoru.SetBool("SaldiriVarMi", false);
        }
	}

    
    
    public void SuAnkiHiziAyarla(float hiz)
    {
        SuAnkiHiz = hiz;
    }

    public void ZararVer(float zararMiktari)
    {
        if (mevcutHedef)
        {
            Saglik saglik = mevcutHedef.GetComponent<Saglik>();
            if (saglik)
            {
                saglik.ZararAl(zararMiktari);
            }
        }
    }

    public void HedefiBelirle(GameObject hedefimiz)
    {
        mevcutHedef = hedefimiz;
    }

}
