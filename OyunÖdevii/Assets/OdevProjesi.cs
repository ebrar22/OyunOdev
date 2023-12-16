using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class odevprojesiiçerik : MonoBehaviour
{
    void Start()
    {
        int sayi1 = 18;
        int sayi2 = 90;
        List<int> liste = Listele(sayi1, sayi2);
        Debug.Log("Sayılar arası liste: " + string.Join(" - ", liste));
        List<int> ciftsayilar = ListeleCiftSayilar(sayi1, sayi2);
        Debug.Log("Çift sayılar arası liste: " + string.Join(" - ", ciftsayilar));
        List<int> tekSayilar = TekSayilariListele(sayi1, sayi2);
        Debug.Log("Tek sayılar arası liste: " + string.Join(" - ", tekSayilar));
        List<int> dordeBolunenSayilar = DordeBolunenSayilarListele(sayi1, sayi2);
        Debug.Log("Dörde bölünen sayılar liste: " + string.Join(" - ", dordeBolunenSayilar));
        List<int> beseBolunenSayilar = BeseBolunenSayilarListele(sayi1, sayi2);
        Debug.Log("Beşe bölünen sayılar liste: " + string.Join(" - ", beseBolunenSayilar));
    }
    List<int> Listele(int baslangic, int bitis)
    {
        List<int> sayiListesi = new List<int>();

        for (int i = baslangic; i <= bitis; i++)
        {
            sayiListesi.Add(i);
        }

        return sayiListesi;
    }
    List<int> ListeleCiftSayilar(int baslangic, int bitis)
    {
        List<int> ciftSayiListesi = new List<int>();


        for (int i = baslangic; i <= bitis; i++)
        {
            if (i % 2 == 0)
            {
                ciftSayiListesi.Add(i);
            }
        }

        return ciftSayiListesi;
    }
    List<int> TekSayilariListele(int baslangic, int bitis)
    {
        List<int> tekSayilar = new List<int>();

        if (baslangic % 2 == 0)
        {
            baslangic++;
        }

        for (int i = baslangic; i <= bitis; i += 2)
        {
            tekSayilar.Add(i);
        }

        return tekSayilar;
    }
    List<int> BeseBolunenSayilarListele(int baslangic, int bitis)
    {
        List<int> beseBolunenSayilar = new List<int>();

        for (int i = baslangic; i <= bitis; i++)
        {
            if (i % 5 == 0)
            {
                beseBolunenSayilar.Add(i);
            }
        }

        return beseBolunenSayilar;
    }

    List<int> DordeBolunenSayilarListele(int baslangic, int bitis)
    {
        List<int> dordeBolunenSayilar = new List<int>();

        for (int i = baslangic; i <= bitis; i++)
        {
            if (i % 4 == 0)
            {
                dordeBolunenSayilar.Add(i);
            }
        }

        return dordeBolunenSayilar;
    }

}
