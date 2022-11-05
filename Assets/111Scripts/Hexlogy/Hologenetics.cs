using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
using UnityEngine;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using Horoscope;
using System.Collections;
using Hexlibrium;
using HEXLIBRIUM;
using Horoscope.Model;
// using HYPERCUBE;
// using Palmmedia.ReportGenerator.Core.Common;
using Unity.VisualScripting;
using UnityEngine.Assertions;
using UnityEngine.UI;
using State = Pixelplacement.State;

public class Hologenetics : MonoBehaviour
{
    public TextMeshProUGUI name;
    public TextMeshProUGUI email;
    public TextMeshProUGUI wallet;
    
    public TextMeshProUGUI place;
    
    public TextMeshProUGUI hourTime;
    public TextMeshProUGUI minTime;
    
    [SerializeField] public TMP_Text birthDay;
    [SerializeField] public TMP_Text birthMonth;
    [SerializeField] public TMP_Text birthYear;
    
    
    
    [SerializeField] public TMP_Text gregorianInput;
    //public TMPText.text y;

    int _year;
    int _month;
    int _day;
    
    // public TextMeshProUGUI email;
    // public TextMeshProUGUI place;

    public Button buttonUpload;
    
    public Button[] buttonArray;
    public TextMeshProUGUI[] buttonTextArray;
  

    public Transform content;
    
    private float timeClock;
    // Start is called before the first frame update

    public HolonDateTime holonDateTime;
    public DateTime gregorian;
    
    void Update()
    {
     
        
        List<string> _hologenetics = new List<string>();
        _hologenetics.Add("Aeon");
        _hologenetics.Insert(1,"chronos");
       // Debug.Log(_hologenetics[0]);
        
        //Dictionary<string, Hexagrams> hexagram = new Dictionary<string, Hexagrams>();
        //Hexagrams h00 = new Hexagrams("Alchemist", 1);
        //hexagram.Add("Metal", h00);
        //Debug.Log(hexagram);
        
        
        // The Long Count calendar ends in 5200 Mayan year. (≒5125 solar years)
        // The last date "12.19.19.17.19" will be "December 20, 2012".
        //     and It is rumored that "the human race perish at the next day"
        
        // 1 long count＝13 baktun=1872000 days≒5125 solar years
        // 1 baktun=20 k'atun=144000 days（≒400 years）
        // 1 k'atun=20 tun=7200 days（≒20 years）
        // 1 tun=18 winal=360 days（≒1 year）
        //var winal = 20 var kin= 20 days（≒1 month）

        //int num = 0;
        _year = Convert.ToInt32(birthYear);
        //year.ConvertTo<int>();

        LeapYear(_year);

        int LeapYear(int leapYear)
        {
            int _leapYear4 = leapYear % 4;
            int _leapYear100 = leapYear % 100;

            if (_leapYear4 == 0)
            {
                //Debug.Log("Leap Year");
            }
            else if(_leapYear4 != 0)
            {
                //Debug.Log("Not Leap Year");
            }
            else
            {
                //Debug.Log("no year"); 
            } ;
            
       

            return leapYear;
        } ;

        //int yy;
        Year(_year);
        
        int Year(int yyyy)
        {
            int yy = yyyy % 100;
            int y0 = yy % 10;
            int y1 = yy / 10;
            int y01 = Math.Abs(10-(y1 + y0));
            
            //yy.GetHashCode();

            switch (y01)
            {
                case 1: 
                    Debug.Log("White Water");
                    break;
                case 2: 
                    Debug.Log("Black Earth");
                    break;
                case 3: 
                    Debug.Log("Green Light Wood");
                    break;
                case 4: 
                    Debug.Log("Green Dark Wood");
                    break;
                case 5: 
                    Debug.Log("Yellow Earth");
                    break;
                case 6: 
                    Debug.Log("White Metal");
                    break;
                case 7: 
                    Debug.Log("Red Metal");
                    break;
                case 8: 
                    Debug.Log("White Earth");
                    break;
                case 9: 
                    Debug.Log("Purple Fire");
                    break;
            }
            //Console.WriteLine(yy);
            //Debug.Log(y01);

            return yyyy;
        }
        
        _month = Convert.ToInt32(birthMonth);
     
        Month(07);

         int Month(int mm)
         {
            
                 int m00 = mm/64;
                 
                 //0.015625
                 //0.03125
                 //0.046875
                 //0.0625
                 //0.078125
                 //0.09375
                 //0.109375
                 //0.125
                 //0.140625
                 //0.15625
                 //0.171875
                 //0.1875
                 
                 switch (mm)
                 {
                     case 01:
                         Debug.Log("January");
                         break;
                     case 02:
                         Debug.Log("February");
                         break;
                     case 03:
                         Debug.Log("March");
                         break;
                     case 04:
                         Debug.Log("April");
                         break;
                     case 05:
                         Debug.Log("May");
                         break;
                     case 06:
                         Debug.Log("June");
                         break;
                     case 07:
                         Debug.Log("July");
                         break;
                     case 08:
                         Debug.Log("August");
                         break;
                     case 09:
                         Debug.Log("September");
                         break;
                     case 10:
                         Debug.Log("October");
                         break;
                     case 11:
                         Debug.Log("November");
                         break;
                     case 12:
                         Debug.Log("December");
                         break;
                 }
             
      
              return mm;
         }
         
         _day = Convert.ToInt32(birthDay);
     
 }
    
    public string[,,] tzolkin = new string[1, 21, 14]
    {
        {
            {"00000","Magnetic","Lunar","Electric","Self Existing","Overtone","Rhythmic","Resonant","Galactic","Solar","Planetary","Spectral","Crystal","Cosmic"},
            {"Dragon","Magnetic","Lunar","Electric","Self Existing","Overtone","Rhythmic","Resonant","Galactic","Solar","Planetary","Spectral","Crystal","Cosmic"},
            {"Wind","Magnetic","Lunar","Electric","Self Existing","Overtone","Rhythmic","Resonant","Galactic","Solar","Planetary","Spectral","Crystal","Cosmic"},
            {"Night","Magnetic","Lunar","Electric","Self Existing","Overtone","Rhythmic","Resonant","Galactic","Solar","Planetary","Spectral","Crystal","Cosmic"},
            {"Seed","Magnetic","Lunar","Electric","Self Existing","Overtone","Rhythmic","Resonant","Galactic","Solar","Planetary","Spectral","Crystal","Cosmic"},
            {"Serpent","Magnetic","Lunar","Electric","Self Existing","Overtone","Rhythmic","Resonant","Galactic","Solar","Planetary","Spectral","Crystal","Cosmic"},
            {"World brigder","Magnetic","Lunar","Electric","Self Existing","Overtone","Rhythmic","Resonant","Galactic","Solar","Planetary","Spectral","Crystal","Cosmic"},
            {"Hand","Magnetic","Lunar","Electric","Self Existing","Overtone","Rhythmic","Resonant","Galactic","Solar","Planetary","Spectral","Crystal","Cosmic"},
            {"Star","Magnetic","Lunar","Electric","Self Existing","Overtone","Rhythmic","Resonant","Galactic","Solar","Planetary","Spectral","Crystal","Cosmic"},
            {"Moon","Magnetic","Lunar","Electric","Self Existing","Overtone","Rhythmic","Resonant","Galactic","Solar","Planetary","Spectral","Crystal","Cosmic"},
            {"Dog","Magnetic","Lunar","Electric","Self Existing","Overtone","Rhythmic","Resonant","Galactic","Solar","Planetary","Spectral","Crystal","Cosmic"},
            {"Monkey","Magnetic","Lunar","Electric","Self Existing","Overtone","Rhythmic","Resonant","Galactic","Solar","Planetary","Spectral","Crystal","Cosmic"},
            {"Human","Magnetic","Lunar","Electric","Self Existing","Overtone","Rhythmic","Resonant","Galactic","Solar","Planetary","Spectral","Crystal","Cosmic"},
            {"Sky walker","Magnetic","Lunar","Electric","Self Existing","Overtone","Rhythmic","Resonant","Galactic","Solar","Planetary","Spectral","Crystal","Cosmic"},
            {"Wizard","Magnetic","Lunar","Electric","Self Existing","Overtone","Rhythmic","Resonant","Galactic","Solar","Planetary","Spectral","Crystal","Cosmic"},
            {"Eagel","Magnetic","Lunar","Electric","Self Existing","Overtone","Rhythmic","Resonant","Galactic","Solar","Planetary","Spectral","Crystal","Cosmic"},
            {"Warrior","Magnetic","Lunar","Electric","Self Existing","Overtone","Rhythmic","Resonant","Galactic","Solar","Planetary","Spectral","Crystal","Cosmic"},
            {"Earth","Magnetic","Lunar","Electric","Self Existing","Overtone","Rhythmic","Resonant","Galactic","Solar","Planetary","Spectral","Crystal","Cosmic"},
            {"Mirror","Magnetic","Lunar","Electric","Self Existing","Overtone","Rhythmic","Resonant","Galactic","Solar","Planetary","Spectral","Crystal","Cosmic"},
            {"Storm","Magnetic","Lunar","Electric","Self Existing","Overtone","Rhythmic","Resonant","Galactic","Solar","Planetary","Spectral","Crystal","Cosmic"},
            {"Sun","Magnetic","Lunar","Electric","Self Existing","Overtone","Rhythmic","Resonant","Galactic","Solar","Planetary","Spectral","Crystal","Cosmic"}
           
        
        }
    };
    
       public string[,,] iching = new string[1, 8, 8]
    {
        {
            {"0","0","0","0","0","0","0","0",},
            {"0","0","0","0","0","0","0","0",},
            {"0","0","0","0","0","0","0","0",},
            {"0","0","0","0","0","0","0","0",},
            {"0","0","0","0","0","0","0","0",},
            {"0","0","0","0","0","0","0","0",},
            {"0","0","0","0","0","0","0","0",},
            {"0","0","0","0","0","0","0","0",}
        }
    };

  
    void Zodiac()
    {
        var givenDate = new DateTime(1988, 10, 06);

        var givenTime = new DateTime(1988, 10, 06, 9, 30, 30);

        //var hd = new HumanDesignDateModel(1988, 10, 06, 21, 30, 60);

        var givenDateToString = givenDate.ToShortDateString(); //($"\n {givenDate.ToShortDateString()}");

        //var hdm = Horoscope.HumanDesign.GetHumanDesignForDate(givenTime);
        
        //Debug.Log();

        //_year = int.Parse(year.text);

        // var _year_ = year.text;
        //
        // //int num = Convert.ToInt32(_year_);
        //
        //
        //
        //int.TryParse(year.text, out _year);
        //
        //Debug.Log(_year);

        //var zodiacSignFor2018 = (ChineseZodiac.GetChineseZodiacElementBasedOnYear(_year)).ToString();
        //buttonTextArray[0].text = zodiacSignFor2018;

//        var zodiacSignForDate= ChineseZodiac.GetZodiacSignForDate(givenDate);
//        buttonTextArray[1].text  = ($"\n {zodiacSignForDate.ZodiacEnglishTranslation}"); //{new DateTime(1966, 2, 12).ToShortDateString()} is 
        
//        var allChineseZodiacSignsYin = ChineseZodiac.GetAllZodiacSignsForYinYang(YinYang.Yin);
//        buttonTextArray[2].text = ($"\n {YinYang.Yin}");
//        foreach (var currentZodiacSign in allChineseZodiacSignsYin)
        //{
//            buttonTextArray[3].text = ($"-\t{currentZodiacSign.ZodiacName} - {currentZodiacSign.ZodiacEnglishTranslation}");
        //}
        
//        var zodiacSign = Horoscope.Zodiac.GetZodiacSignForDate(givenDate);
        
//        buttonTextArray[4].text = ($" {zodiacSign.ZodiacName} "); //E, {zodiacSign.ZodiacEnglishTranslation} , {zodiacSign.ZodiacDuration}

//        var HumanDesign = Horoscope.DateTimeExtensions.GetZodiacSign(DateTime.Now);

        //Debug.Log(HumanDesign);


        // var allFireChineseSigns = ChineseZodiac.GetAllZodiacSignsForAnElement(ChineseZodiacElements.Fire);
        // Debug.Log($"\nGet a list of all Chinese zodiac signs that are associated with {ChineseZodiacElements.Fire}");
        // foreach (var currentZodiacSign in allFireChineseSigns)
        // {
        //     Debug.Log($"-\t{currentZodiacSign.ZodiacEnglishTranslation}");
        // }

        // var dragonZodiacSign = ChineseZodiac.GetZodiacSign(ChineseZodiacSigns.Dragon);
        // buttonTextArray[0].text = ($"\n{ChineseZodiacSigns.Dragon}"); //, {dragonZodiacSign.ZodiacPersonality}

        // Another option would be:

        // var anotherZodiacSign = givenDate.GetChineseZodiacSign();
        // buttonTextArray[3].text = ($"\n  {anotherZodiacSign.ZodiacEnglishTranslation}"); //{givenDate.ToShortDateString()} is

        // var allChineseZodiacSigns = ChineseZodiac.GetAllZodiacSigns();
        // //buttonTextArray[4].text = ($"\nGet a list of all Chinese zodiac signs");
        // foreach (var currentZodiacSign in allChineseZodiacSigns)
        // {
        //     buttonTextArray[4].text = ($"-\t{currentZodiacSign.ZodiacName} - {currentZodiacSign.ZodiacEnglishTranslation}");
        // }



        // Another option would be:
        // var givenDate2 = givenDate;
        // var anotherZodiacSign2 = givenDate2.GetZodiacSign();
        // buttonTextArray[9].text = ($"\n {givenDate2.ToShortDateString()}");
        // buttonTextArray[10].text = ($" {anotherZodiacSign2.ZodiacName} , {anotherZodiacSign2.ZodiacEnglishTranslation} , {anotherZodiacSign2.ZodiacDuration}");

        //var capriconZodiacSign = Horoscope.Zodiac.GetZodiacSign(ZodiacSigns.Capricorn);
        //buttonTextArray[11].text = ($"\n {ZodiacSigns.Capricorn}");
        //buttonTextArray[0].text = (capriconZodiacSign.ZodiacDuration);

        // var allZodiacSigns = Horoscope.Zodiac.GetAllZodiacSigns();
        // buttonTextArray[0].text = ($"\nGet a list of all zodiac signs");
        // foreach (var currentZodiacSign in allZodiacSigns)
        // {
        //     buttonTextArray[0].text = ($"-\t{currentZodiacSign.ZodiacName}");
        // }




    }
    
     void ZodiacToHD()
    {
        var allFireChineseSigns = ChineseZodiac.GetAllZodiacSignsForAnElement(ChineseZodiacElements.Fire);
        Debug.Log($"\nGet a list of all Chinese zodiac signs that are associated with {ChineseZodiacElements.Fire}");
        foreach (var currentZodiacSign in allFireChineseSigns)
        {
            Debug.Log($"-\t{currentZodiacSign.ZodiacEnglishTranslation}");
        }
    
        var dragonZodiacSign = ChineseZodiac.GetZodiacSign(ChineseZodiacSigns.Dragon);
        buttonTextArray[0].text = ($"\nPersonality trait for {ChineseZodiacSigns.Dragon} people: {dragonZodiacSign.ZodiacPersonality}");
    
         var zodiacSignFor2018 = (ChineseZodiac.GetChineseZodiacElementBasedOnYear(1988)).ToString();
        buttonTextArray[1].text =($"\nChinese zodiDebug.Logac element for 2018 is {zodiacSignFor2018}");
    
        var zodiacSignForDate= ChineseZodiac.GetZodiacSignForDate(new DateTime(1988, 10, 06));
        //buttonText01.text  = ($"\nChinese zodiac sign for {new DateTime(1966, 2, 12).ToShortDateString()} is {zodiacSignForDate.ZodiacEnglishTranslation}");
    
        // Another option would be:
        var givenDate = new DateTime(1988, 10, 06);
        var anotherZodiacSign = givenDate.GetChineseZodiacSign();
        buttonTextArray[2].text = ($"\nChinese zodiac sign for {givenDate.ToShortDateString()} is {anotherZodiacSign.ZodiacEnglishTranslation}");
    
        var allChineseZodiacSigns = ChineseZodiac.GetAllZodiacSigns();
        buttonTextArray[3].text = ($"\nGet a list of all Chinese zodiac signs");
        foreach (var currentZodiacSign in allChineseZodiacSigns)
        {
            buttonTextArray[4].text = ($"-\t{currentZodiacSign.ZodiacName} - {currentZodiacSign.ZodiacEnglishTranslation}");
        }
    
        var allChineseZodiacSignsYin = ChineseZodiac.GetAllZodiacSignsForYinYang(YinYang.Yin);
        buttonTextArray[5].text = ($"\nGet a list of all Chinese zodiac signs associated with {YinYang.Yin}");
        foreach (var currentZodiacSign in allChineseZodiacSignsYin)
        {
            buttonTextArray[6].text = ($"-\t{currentZodiacSign.ZodiacName} - {currentZodiacSign.ZodiacEnglishTranslation}");
        }
        //
        //
        //
        var zodiacSign = Horoscope.Zodiac.GetZodiacSignForDate(new DateTime(1988, 10, 06));
        buttonTextArray[7].text = ($"\nZodiac details for {new DateTime(1988, 10, 06).ToShortDateString()}");
        buttonTextArray[8].text = ($"Name: {zodiacSign.ZodiacName} English name: {zodiacSign.ZodiacEnglishTranslation} Duration: {zodiacSign.ZodiacDuration}");
    
        // Another option would be:
        var givenDate2 = new DateTime(1988, 10, 06);
        var anotherZodiacSign2 = givenDate2.GetZodiacSign();
        buttonTextArray[9].text = ($"\nZodiac details for {givenDate2.ToShortDateString()}");
        buttonTextArray[10].text = ($"Name: {anotherZodiacSign2.ZodiacName} English name: {anotherZodiacSign2.ZodiacEnglishTranslation} Duration: {anotherZodiacSign2.ZodiacDuration}");
    
        var capriconZodiacSign = Horoscope.Zodiac.GetZodiacSign(ZodiacSigns.Capricorn);
        buttonTextArray[11].text = ($"\nZodiac duration for {ZodiacSigns.Capricorn}");
        //buttonTextArray[0].text = (capriconZodiacSign.ZodiacDuration);
    
        // var allZodiacSigns = Horoscope.Zodiac.GetAllZodiacSigns();
        // buttonTextArray[0].text = ($"\nGet a list of all zodiac signs");
        // foreach (var currentZodiacSign in allZodiacSigns)
        // {
        //     buttonTextArray[0].text = ($"-\t{currentZodiacSign.ZodiacName}");
        // }
        
        
        
        
    }

  
}

/*
The mind is an geometriclly organization 

The mind grows in six branchs

Stimilus
Seratonina calcium

The eight unfolding path

*/
