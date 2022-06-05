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
        playerWalkSound = Resources.Load<AudioClip>("oyuncuyürüme");
        playerFireSound = Resources.Load<AudioClip>("oyuncuateþ");
        jumpSound = Resources.Load<AudioClip>("oyuncuzýplama");
        fallsound = Resources.Load<AudioClip>("oyuncudüþme");
        enemyDeathSound = Resources.Load<AudioClip>("düþmanölüm");
        enemyFireSound = Resources.Load<AudioClip>("düþmanateþ");
        playerHitSound = Resources.Load<AudioClip>("oyuncuhasaryeme");
        enemyHitSound = Resources.Load<AudioClip>("düþmanhasaryeme");

        audioSrc = GetComponent<AudioSource>(); 

    }
    public static void StopSound()
    {
        audioSrc.Stop();
    }

    // Update is called once per frame
    void Update() {
    }
    //bu sesleri kullanmak için unity içinden öncelikle yeni attýðým ismi bunlara karþýlýk gelen assetleri oyun içine atýnýz
    //ardýndan yeni bir GameObject oluþturun ve ona SoundManager ismini verin 

    //buna Audio Source componentini ekleyin ve play on awake in tikini kaldýrýn yoksa oyunu açtýðýnýz anda saðýr olabilirsiniz
    //ardýndan bu scripti yeni eklediðiniz componenta yapýþtýrýn

    //
    // bu listedeki scritpleri herhangi bir yerde kullanmak için örnek;
    // oyuncu için zýplama sesini mi eklemek istiyorsunuz, onun için oyuncunun kontrolcü scriptingedi 
    // if statementý bulun ve þu kodu ekleyin SoundManagerScript.PlaySound ("oyuncuzýplama");
    // kodu robotun ateþ etmesine mi eklemek istiyor sunuz o zaman oraya ekleyip tek deðiþtireceðiniz þey 
    //parantez içini aþaðýdaki listedeki isimlere göre deðiþtirmek
    //bkz.  SoundManagerScript.Playsound ("düþmanateþ");
    //robotun hasar yeme sesi için ise onun için gerekli if state inin altýna yukarýdaki kodun ve parantez içide
    //karþýlýk gelecek sesin yazýlýp yapýþtýrýlmasý yeterli

    //eðer birþeyi becerememiþsem hemen haber verin düzeltmeye çalýþýrým
    //eðer siz ses eklemek isterseniz yapacaðýnýz þey önce bir sesi assetlere atmak ardýndan
    //yukarýda void startýn altýnda kalan yere soldan bir isim vermek,
    // ardýndan parantez içindeki yere de dosya ismini vermeniz ardýndan da aþaðýda playsound scriptinde yeni bir case açarak oraya 
    //tekrardan dosya ismi vermeniz yeterli, örnek;
    //
    //canýmýnÝstediðiÝsim = Resources.Load<AudioClip>("istediðimSesDosyasýnýnÝsmi");

    //case "istediðimSesDosyasýnýnÝsmi":
    //  audioSrc.PlayOneShot(canýmýnÝstediðiÝsim);
    //tek verebileceðim öneri semicolonu unutmayýn :I 

    public static void PlaySound (string clip)
    {
        switch(clip) {
            case "oyuncuyürüme":
                audioSrc.PlayOneShot(playerWalkSound);
                break;
           
            case "oyuncudüþme":
                audioSrc.PlayOneShot(fallsound);
                audioSrc.loop = false;
                break;
                
            case "oyuncuateþ":
                audioSrc.PlayOneShot(playerFireSound);
                audioSrc.loop = false;
                break;

            case "oyuncuzýplama":
                audioSrc.PlayOneShot(jumpSound);
                audioSrc.loop = false;
                break;

            case "düþmanölüm":
                audioSrc.PlayOneShot(enemyDeathSound);
                break;

            case "düþmanateþ":
                audioSrc.PlayOneShot(enemyFireSound);
                break;

            case "oyuncuhasaryeme":
                audioSrc.PlayOneShot(playerHitSound);
                break;

            case "düþmanhasaryeme":
                audioSrc.PlayOneShot(enemyHitSound);
                break;

        }
    }
   
}
