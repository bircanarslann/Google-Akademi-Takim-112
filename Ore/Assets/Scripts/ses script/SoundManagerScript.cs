using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip playerWalkSound, playerFireSound, jumpSound, fallsound, enemyDeathSound, enemyFireSound, playerHitSound, enemyHitSound;
    static AudioSource audioSrc;
    // Start is called before the first frame update

    void Start()
    {
        playerWalkSound = Resources.Load<AudioClip>("oyuncuy�r�me");
        playerFireSound = Resources.Load<AudioClip>("oyuncuate�");
        jumpSound = Resources.Load<AudioClip>("oyuncuz�plama");
        fallsound = Resources.Load<AudioClip>("oyuncud��me");
        enemyDeathSound = Resources.Load<AudioClip>("d��man�l�m");
        enemyFireSound = Resources.Load<AudioClip>("d��manate�");
        playerHitSound = Resources.Load<AudioClip>("oyuncuhasaryeme");
        enemyHitSound = Resources.Load<AudioClip>("d��manhasaryeme");

        audioSrc = GetComponent<AudioSource>(); 

    }
    public static void StopSound()
    {
        audioSrc.Stop();
    }

    // Update is called once per frame
    void Update() {
    }
    //bu sesleri kullanmak i�in unity i�inden �ncelikle yeni att���m ismi bunlara kar��l�k gelen assetleri oyun i�ine at�n�z
    //ard�ndan yeni bir GameObject olu�turun ve ona SoundManager ismini verin 

    //buna Audio Source componentini ekleyin ve play on awake in tikini kald�r�n yoksa oyunu a�t���n�z anda sa��r olabilirsiniz
    //ard�ndan bu scripti yeni ekledi�iniz componenta yap��t�r�n

    //
    // bu listedeki scritpleri herhangi bir yerde kullanmak i�in �rnek;
    // oyuncu i�in z�plama sesini mi eklemek istiyorsunuz, onun i�in oyuncunun kontrolc� scriptingedi 
    // if statement� bulun ve �u kodu ekleyin SoundManagerScript.PlaySound ("oyuncuz�plama");
    // kodu robotun ate� etmesine mi eklemek istiyor sunuz o zaman oraya ekleyip tek de�i�tirece�iniz �ey 
    //parantez i�ini a�a��daki listedeki isimlere g�re de�i�tirmek
    //bkz.  SoundManagerScript.Playsound ("d��manate�");
    //robotun hasar yeme sesi i�in ise onun i�in gerekli if state inin alt�na yukar�daki kodun ve parantez i�ide
    //kar��l�k gelecek sesin yaz�l�p yap��t�r�lmas� yeterli

    //e�er bir�eyi becerememi�sem hemen haber verin d�zeltmeye �al���r�m
    //e�er siz ses eklemek isterseniz yapaca��n�z �ey �nce bir sesi assetlere atmak ard�ndan
    //yukar�da void start�n alt�nda kalan yere soldan bir isim vermek,
    // ard�ndan parantez i�indeki yere de dosya ismini vermeniz ard�ndan da a�a��da playsound scriptinde yeni bir case a�arak oraya 
    //tekrardan dosya ismi vermeniz yeterli, �rnek;
    //
    //can�m�n�stedi�i�sim = Resources.Load<AudioClip>("istedi�imSesDosyas�n�n�smi");

    //case "istedi�imSesDosyas�n�n�smi":
    //  audioSrc.PlayOneShot(can�m�n�stedi�i�sim);
    //tek verebilece�im �neri semicolonu unutmay�n :I 

    public static void PlaySound (string clip)
    {
        switch(clip) {
            case "oyuncuy�r�me":
                audioSrc.PlayOneShot(playerWalkSound);
                break;
           
            case "oyuncud��me":
                audioSrc.PlayOneShot(fallsound);
                audioSrc.loop = false;
                break;
                
            case "oyuncuate�":
                audioSrc.PlayOneShot(playerFireSound);
                audioSrc.loop = false;
                break;

            case "oyuncuz�plama":
                audioSrc.PlayOneShot(jumpSound);
                audioSrc.loop = false;
                break;

            case "d��man�l�m":
                audioSrc.PlayOneShot(enemyDeathSound);
                break;

            case "d��manate�":
                audioSrc.PlayOneShot(enemyFireSound);
                break;

            case "oyuncuhasaryeme":
                audioSrc.PlayOneShot(playerHitSound);
                break;

            case "d��manhasaryeme":
                audioSrc.PlayOneShot(enemyHitSound);
                break;

        }
    }
   
}
