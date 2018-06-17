using System.Globalization;

namespace KukSoft.ToolKit.DataTypes.Enums
{
    public class Culture : Enum<Culture, int>
    {
        private int _lcid;
        protected Culture(int value, string name) : base(value, name)
        {
            _lcid = value;
        }
        public CultureInfo Info => new CultureInfo(_lcid);

        public static Culture Invariant => new Culture(0x007F, string.Empty);
        /// <summary>
        /// af (54)
        /// </summary>
        public static Culture Afrikaans => new Culture(0x0036, "af");
        /// <summary>
        /// af-ZA (1078)
        /// </summary>
        public static Culture AfrikaansSouthAfrica => new Culture(0x0436, "af-ZA");
        /// <summary>
        /// sq (28)
        /// </summary>
        public static Culture Albanian => new Culture(0x001C, "sq");
        /// <summary>
        /// sq-AL (1052)
        /// </summary>
        public static Culture AlbanianAlbania => new Culture(0x041C, "sq-AL");
        /// <summary>
        /// gsw (132)
        /// </summary>
        public static Culture Alsatian => new Culture(0x0084, "gsw");
        /// <summary>
        /// gsw-FR (1156)
        /// </summary>
        public static Culture AlsatianFrance => new Culture(0x0484, "gsw-FR");
        /// <summary>
        /// am (94)
        /// </summary>
        public static Culture Amharic => new Culture(0x005E, "am");
        /// <summary>
        /// am-ET (1118)
        /// </summary>
        public static Culture AmharicEthiopia => new Culture(0x045E, "am-ET");
        /// <summary>
        /// ar (1)
        /// </summary>
        public static Culture Arabic => new Culture(0x0001, "ar");
        /// <summary>
        /// ar-DZ (5121)
        /// </summary>
        public static Culture ArabicAlgeria => new Culture(0x1401, "ar-DZ");
        /// <summary>
        /// ar-BH (15361)
        /// </summary>
        public static Culture ArabicBahrain => new Culture(0x3C01, "ar-BH");
        /// <summary>
        /// ar-EG (3073)
        /// </summary>
        public static Culture ArabicEgypt => new Culture(0x0c01, "ar-EG");
        /// <summary>
        /// ar-IQ (2049)
        /// </summary>
        public static Culture ArabicIraq => new Culture(0x0801, "ar-IQ");
        /// <summary>
        /// ar-JO (11265)
        /// </summary>
        public static Culture ArabicJordan => new Culture(0x2C01, "ar-JO");
        /// <summary>
        /// ar-KW (13313)
        /// </summary>
        public static Culture ArabicKuwait => new Culture(0x3401, "ar-KW");
        /// <summary>
        /// ar-LB (12289)
        /// </summary>
        public static Culture ArabicLebanon => new Culture(0x3001, "ar-LB");
        /// <summary>
        /// ar-LY (4097)
        /// </summary>
        public static Culture ArabicLibya => new Culture(0x1001, "ar-LY");
        /// <summary>
        /// ar-MA (6145)
        /// </summary>
        public static Culture ArabicMorocco => new Culture(0x1801, "ar-MA");
        /// <summary>
        /// ar-OM (8193)
        /// </summary>
        public static Culture ArabicOman => new Culture(0x2001, "ar-OM");
        /// <summary>
        /// ar-QA (16385)
        /// </summary>
        public static Culture ArabicQatar => new Culture(0x4001, "ar-QA");
        /// <summary>
        /// ar-SA (1025)
        /// </summary>
        public static Culture ArabicSaudiArabia => new Culture(0x0401, "ar-SA");
        /// <summary>
        /// ar-SY (10241)
        /// </summary>
        public static Culture ArabicSyria => new Culture(0x2801, "ar-SY");
        /// <summary>
        /// ar-TN (7169)
        /// </summary>
        public static Culture ArabicTunisia => new Culture(0x1C01, "ar-TN");
        /// <summary>
        /// ar-AE (14337)
        /// </summary>
        public static Culture ArabicUAE => new Culture(0x3801, "ar-AE");
        /// <summary>
        /// ar-YE (9217)
        /// </summary>
        public static Culture ArabicYemen => new Culture(0x2401, "ar-YE");
        /// <summary>
        /// hy (43)
        /// </summary>
        public static Culture Armenian => new Culture(0x002B, "hy");
        /// <summary>
        /// hy-AM (1067)
        /// </summary>
        public static Culture ArmenianArmenia => new Culture(0x042B, "hy-AM");
        /// <summary>
        /// as (77)
        /// </summary>
        public static Culture Assamese => new Culture(0x004D, "as");
        /// <summary>
        /// as-IN (1101)
        /// </summary>
        public static Culture AssameseIndia => new Culture(0x044D, "as-IN");
        /// <summary>
        /// az-Cyrl (29740)
        /// </summary>
        public static Culture AzerbaijaniCyrl => new Culture(0x742C, "az-Cyrl");
        /// <summary>
        /// az-Cyrl-AZ (2092)
        /// </summary>
        public static Culture AzerbaijaniCyrlAzerbaijan => new Culture(0x082C, "az-Cyrl-AZ");
        /// <summary>
        /// az (44)
        /// </summary>
        public static Culture Azerbaijani => new Culture(0x002C, "az");
        /// <summary>
        /// az-Latn (30764)
        /// </summary>
        public static Culture AzerbaijaniLatn => new Culture(0x782C, "az-Latn");
        /// <summary>
        /// az-Latn-AZ (1068)
        /// </summary>
        public static Culture AzerbaijaniLatnAzerbaijan => new Culture(0x042C, "az-Latn-AZ");
        /// <summary>
        /// bn (69)
        /// </summary>
        public static Culture Bangla => new Culture(0x0045, "bn");
        /// <summary>
        /// bn-BD (2117)
        /// </summary>
        public static Culture BanglaBangladesh => new Culture(0x0845, "bn-BD");
        /// <summary>
        /// bn-IN (1093)
        /// </summary>
        public static Culture BanglaIndia => new Culture(0x0445, "bn-IN");
        /// <summary>
        /// ba (109)
        /// </summary>
        public static Culture Bashkir => new Culture(0x006D, "ba");
        /// <summary>
        /// ba-RU (1133)
        /// </summary>
        public static Culture BashkirRussia => new Culture(0x046D, "ba-RU");
        /// <summary>
        /// eu (45)
        /// </summary>
        public static Culture Basque => new Culture(0x002D, "eu");
        /// <summary>
        /// eu-ES (1069)
        /// </summary>
        public static Culture BasqueSpain => new Culture(0x042D, "eu-ES");
        /// <summary>
        /// be (35)
        /// </summary>
        public static Culture Belarusian => new Culture(0x0023, "be");
        /// <summary>
        /// be-BY (1059)
        /// </summary>
        public static Culture BelarusianBelarus => new Culture(0x0423, "be-BY");
        /// <summary>
        /// bs-Cyrl (25626)
        /// </summary>
        public static Culture BosnianCyrl => new Culture(0x641A, "bs-Cyrl");
        /// <summary>
        /// bs-Cyrl-BA (8218)
        /// </summary>
        public static Culture BosnianCyrlBosniaAndHerzegovina => new Culture(0x201A, "bs-Cyrl-BA");
        /// <summary>
        /// bs-Latn (26650)
        /// </summary>
        public static Culture BosnianLatn => new Culture(0x681A, "bs-Latn");
        /// <summary>
        /// bs (30746)
        /// </summary>
        public static Culture Bosnian => new Culture(0x781A, "bs");
        /// <summary>
        /// bs-Latn-BA (5146)
        /// </summary>
        public static Culture BosnianLatnBosniaAndHerzegovina => new Culture(0x141A, "bs-Latn-BA");
        /// <summary>
        /// br (126)
        /// </summary>
        public static Culture Breton => new Culture(0x007E, "br");
        /// <summary>
        /// br-FR (1150)
        /// </summary>
        public static Culture BretonFrance => new Culture(0x047E, "br-FR");
        /// <summary>
        /// bg (2)
        /// </summary>
        public static Culture Bulgarian => new Culture(0x0002, "bg");
        /// <summary>
        /// bg-BG (1026)
        /// </summary>
        public static Culture BulgarianBulgaria => new Culture(0x0402, "bg-BG");
        /// <summary>
        /// my (85)
        /// </summary>
        public static Culture Burmese => new Culture(0x0055, "my");
        /// <summary>
        /// my-MM (1109)
        /// </summary>
        public static Culture BurmeseMyanmar => new Culture(0x0455, "my-MM");
        /// <summary>
        /// ca (3)
        /// </summary>
        public static Culture Catalan => new Culture(0x0003, "ca");
        /// <summary>
        /// ca-ES (1027)
        /// </summary>
        public static Culture CatalanSpain => new Culture(0x0403, "ca-ES");
        /// <summary>
        /// ku (146)
        /// </summary>
        public static Culture Kurdish => new Culture(0x0092, "ku");
        /// <summary>
        /// ku-Arab (31890)
        /// </summary>
        public static Culture KurdishArab => new Culture(0x7c92, "ku-Arab");
        /// <summary>
        /// ku-Arab-IQ (1170)
        /// </summary>
        public static Culture KurdishIraq => new Culture(0x0492, "ku-Arab-IQ");
        /// <summary>
        /// chr (92)
        /// </summary>
        public static Culture Cherokee => new Culture(0x005C, "chr");
        /// <summary>
        /// chr-Cher (31836)
        /// </summary>
        public static Culture CherokeeCher => new Culture(0x7c5C, "chr-Cher");
        /// <summary>
        /// chr-Cher-US (1116)
        /// </summary>
        public static Culture CherokeeUnitedStates => new Culture(0x045C, "chr-Cher-US");
        /// <summary>
        /// zh-Hans (4)
        /// </summary>
        public static Culture ChineseHans => new Culture(0x0004, "zh-Hans");
        /// <summary>
        /// zh (30724)
        /// </summary>
        public static Culture Chinese => new Culture(0x7804, "zh");
        /// <summary>
        /// zh-CN (2052)
        /// </summary>
        public static Culture ChineseHansChina => new Culture(0x0804, "zh-CN");
        /// <summary>
        /// zh-SG (4100)
        /// </summary>
        public static Culture ChineseHansSingapore => new Culture(0x1004, "zh-SG");
        /// <summary>
        /// zh-Hant (31748)
        /// </summary>
        public static Culture ChineseHant => new Culture(0x7C04, "zh-Hant");
        /// <summary>
        /// zh-HK (3076)
        /// </summary>
        public static Culture ChineseHantHongKong => new Culture(0x0C04, "zh-HK");
        /// <summary>
        /// zh-MO (5124)
        /// </summary>
        public static Culture ChineseHantMacao => new Culture(0x1404, "zh-MO");
        /// <summary>
        /// zh-TW (1028)
        /// </summary>
        public static Culture ChineseHantTaiwan => new Culture(0x0404, "zh-TW");
        /// <summary>
        /// co (131)
        /// </summary>
        public static Culture Corsican => new Culture(0x0083, "co");
        /// <summary>
        /// co-FR (1155)
        /// </summary>
        public static Culture CorsicanFrance => new Culture(0x0483, "co-FR");
        /// <summary>
        /// bs, hr, or sr (26)
        /// </summary>
        public static Culture Croatian => new Culture(0x001A, "bs, hr, or sr");
        /// <summary>
        /// hr-HR (1050)
        /// </summary>
        public static Culture CroatianCroatia => new Culture(0x041A, "hr-HR");
        /// <summary>
        /// hr-BA (4122)
        /// </summary>
        public static Culture CroatianBosniaAndHerzegovina => new Culture(0x101A, "hr-BA");
        /// <summary>
        /// cs (5)
        /// </summary>
        public static Culture Czech => new Culture(0x0005, "cs");
        /// <summary>
        /// cs-CZ (1029)
        /// </summary>
        public static Culture CzechCzechRepublic => new Culture(0x0405, "cs-CZ");
        /// <summary>
        /// da (6)
        /// </summary>
        public static Culture Danish => new Culture(0x0006, "da");
        /// <summary>
        /// da-DK (1030)
        /// </summary>
        public static Culture DanishDenmark => new Culture(0x0406, "da-DK");
        /// <summary>
        /// prs (140)
        /// </summary>
        public static Culture Dari => new Culture(0x008C, "prs");
        /// <summary>
        /// prs-AF (1164)
        /// </summary>
        public static Culture DariAfghanistan => new Culture(0x048C, "prs-AF");
        /// <summary>
        /// dv (101)
        /// </summary>
        public static Culture Divehi => new Culture(0x0065, "dv");
        /// <summary>
        /// dv-MV (1125)
        /// </summary>
        public static Culture DivehiMaldives => new Culture(0x0465, "dv-MV");
        /// <summary>
        /// nl (19)
        /// </summary>
        public static Culture Dutch => new Culture(0x0013, "nl");
        /// <summary>
        /// nl-BE (2067)
        /// </summary>
        public static Culture DutchBelgium => new Culture(0x0813, "nl-BE");
        /// <summary>
        /// nl-NL (1043)
        /// </summary>
        public static Culture DutchNetherlands => new Culture(0x0413, "nl-NL");
        /// <summary>
        /// dz-BT (3153)
        /// </summary>
        public static Culture DzongkhaBhutan => new Culture(0x0C51, "dz-BT");
        /// <summary>
        /// en (9)
        /// </summary>
        public static Culture English => new Culture(0x0009, "en");
        /// <summary>
        /// en-AU (3081)
        /// </summary>
        public static Culture EnglishAustralia => new Culture(0x0C09, "en-AU");
        /// <summary>
        /// en-BZ (10249)
        /// </summary>
        public static Culture EnglishBelize => new Culture(0x2809, "en-BZ");
        /// <summary>
        /// en-CA (4105)
        /// </summary>
        public static Culture EnglishCanada => new Culture(0x1009, "en-CA");
        /// <summary>
        /// en-029 (9225)
        /// </summary>
        public static Culture EnglishCaribbean => new Culture(0x2409, "en-029");
        /// <summary>
        /// en-HK (15369)
        /// </summary>
        public static Culture EnglishHongKong => new Culture(0x3C09, "en-HK");
        /// <summary>
        /// en-IN (16393)
        /// </summary>
        public static Culture EnglishIndia => new Culture(0x4009, "en-IN");
        /// <summary>
        /// en-IE (6153)
        /// </summary>
        public static Culture EnglishIreland => new Culture(0x1809, "en-IE");
        /// <summary>
        /// en-JM (8201)
        /// </summary>
        public static Culture EnglishJamaica => new Culture(0x2009, "en-JM");
        /// <summary>
        /// en-MY (17417)
        /// </summary>
        public static Culture EnglishMalaysia => new Culture(0x4409, "en-MY");
        /// <summary>
        /// en-NZ (5129)
        /// </summary>
        public static Culture EnglishNewZealand => new Culture(0x1409, "en-NZ");
        /// <summary>
        /// en-PH (13321)
        /// </summary>
        public static Culture EnglishPhilippines => new Culture(0x3409, "en-PH");
        /// <summary>
        /// en-SG (18441)
        /// </summary>
        public static Culture EnglishSingapore => new Culture(0x4809, "en-SG");
        /// <summary>
        /// en-ZA (7177)
        /// </summary>
        public static Culture EnglishSouthAfrica => new Culture(0x1C09, "en-ZA");
        /// <summary>
        /// en-TT (11273)
        /// </summary>
        public static Culture EnglishTrinidadAndTobago => new Culture(0x2c09, "en-TT");
        /// <summary>
        /// en-GB (2057)
        /// </summary>
        public static Culture EnglishUnitedKingdom => new Culture(0x0809, "en-GB");
        /// <summary>
        /// en-US (1033)
        /// </summary>
        public static Culture EnglishUnitedStates => new Culture(0x0409, "en-US");
        /// <summary>
        /// en-ZW (12297)
        /// </summary>
        public static Culture EnglishZimbabwe => new Culture(0x3009, "en-ZW");
        /// <summary>
        /// et (37)
        /// </summary>
        public static Culture Estonian => new Culture(0x0025, "et");
        /// <summary>
        /// et-EE (1061)
        /// </summary>
        public static Culture EstonianEstonia => new Culture(0x0425, "et-EE");
        /// <summary>
        /// fo (56)
        /// </summary>
        public static Culture Faroese => new Culture(0x0038, "fo");
        /// <summary>
        /// fo-FO (1080)
        /// </summary>
        public static Culture FaroeseFaroeIslands => new Culture(0x0438, "fo-FO");
        /// <summary>
        /// fil (100)
        /// </summary>
        public static Culture Filipino => new Culture(0x0064, "fil");
        /// <summary>
        /// fil-PH (1124)
        /// </summary>
        public static Culture FilipinoPhilippines => new Culture(0x0464, "fil-PH");
        /// <summary>
        /// fi (11)
        /// </summary>
        public static Culture Finnish => new Culture(0x000B, "fi");
        /// <summary>
        /// fi-FI (1035)
        /// </summary>
        public static Culture FinnishFinland => new Culture(0x040B, "fi-FI");
        /// <summary>
        /// fr (12)
        /// </summary>
        public static Culture French => new Culture(0x000C, "fr");
        /// <summary>
        /// fr-BE (2060)
        /// </summary>
        public static Culture FrenchBelgium => new Culture(0x080C, "fr-BE");
        /// <summary>
        /// fr-CM (11276)
        /// </summary>
        public static Culture FrenchCameroon => new Culture(0x2c0C, "fr-CM");
        /// <summary>
        /// fr-CA (3084)
        /// </summary>
        public static Culture FrenchCanada => new Culture(0x0c0C, "fr-CA");
        /// <summary>
        /// fr-CD (9228)
        /// </summary>
        public static Culture FrenchCongo => new Culture(0x240C, "fr-CD");
        /// <summary>
        /// fr-CI (12300)
        /// </summary>
        public static Culture FrenchIvoryCoast => new Culture(0x300C, "fr-CI");
        /// <summary>
        /// fr-FR (1036)
        /// </summary>
        public static Culture FrenchFrance => new Culture(0x040C, "fr-FR");
        /// <summary>
        /// fr-HT (15372)
        /// </summary>
        public static Culture FrenchHaiti => new Culture(0x3c0C, "fr-HT");
        /// <summary>
        /// fr-LU (5132)
        /// </summary>
        public static Culture FrenchLuxembourg => new Culture(0x140C, "fr-LU");
        /// <summary>
        /// fr-ML (13324)
        /// </summary>
        public static Culture FrenchMali => new Culture(0x340C, "fr-ML");
        /// <summary>
        /// fr-MA (14348)
        /// </summary>
        public static Culture FrenchMorocco => new Culture(0x380C, "fr-MA");
        /// <summary>
        /// fr-MC (6156)
        /// </summary>
        public static Culture FrenchMonaco => new Culture(0x180C, "fr-MC");
        /// <summary>
        /// fr-RE (8204)
        /// </summary>
        public static Culture FrenchReunion => new Culture(0x200C, "fr-RE");
        /// <summary>
        /// fr-SN (10252)
        /// </summary>
        public static Culture FrenchSenegal => new Culture(0x280C, "fr-SN");
        /// <summary>
        /// fr-CH (4108)
        /// </summary>
        public static Culture FrenchSwitzerland => new Culture(0x100C, "fr-CH");
        /// <summary>
        /// fy (98)
        /// </summary>
        public static Culture Frisian => new Culture(0x0062, "fy");
        /// <summary>
        /// fy-NL (1122)
        /// </summary>
        public static Culture FrisianNetherlands => new Culture(0x0462, "fy-NL");
        /// <summary>
        /// ff (103)
        /// </summary>
        public static Culture Fulah => new Culture(0x0067, "ff");
        /// <summary>
        /// ff-Latn (31847)
        /// </summary>
        public static Culture FulahLatn => new Culture(0x7C67, "ff-Latn");
        /// <summary>
        /// ff-Latn-SN (2151)
        /// </summary>
        public static Culture FulahSenegal => new Culture(0x0867, "ff-Latn-SN");
        /// <summary>
        /// gl (86)
        /// </summary>
        public static Culture Galician => new Culture(0x0056, "gl");
        /// <summary>
        /// gl-ES (1110)
        /// </summary>
        public static Culture GalicianSpain => new Culture(0x0456, "gl-ES");
        /// <summary>
        /// ka (55)
        /// </summary>
        public static Culture Georgian => new Culture(0x0037, "ka");
        /// <summary>
        /// ka-GE (1079)
        /// </summary>
        public static Culture GeorgianGeorgia => new Culture(0x0437, "ka-GE");
        /// <summary>
        /// de (7)
        /// </summary>
        public static Culture German => new Culture(0x0007, "de");
        /// <summary>
        /// de-AT (3079)
        /// </summary>
        public static Culture GermanAustria => new Culture(0x0C07, "de-AT");
        /// <summary>
        /// de-DE (1031)
        /// </summary>
        public static Culture GermanGermany => new Culture(0x0407, "de-DE");
        /// <summary>
        /// de-LI (5127)
        /// </summary>
        public static Culture GermanLiechtenstein => new Culture(0x1407, "de-LI");
        /// <summary>
        /// de-LU (4103)
        /// </summary>
        public static Culture GermanLuxembourg => new Culture(0x1007, "de-LU");
        /// <summary>
        /// de-CH (2055)
        /// </summary>
        public static Culture GermanSwitzerland => new Culture(0x0807, "de-CH");
        /// <summary>
        /// el (8)
        /// </summary>
        public static Culture Greek => new Culture(0x0008, "el");
        /// <summary>
        /// el-GR (1032)
        /// </summary>
        public static Culture GreekGreece => new Culture(0x0408, "el-GR");
        /// <summary>
        /// kl (111)
        /// </summary>
        public static Culture Greenlandic => new Culture(0x006F, "kl");
        /// <summary>
        /// kl-GL (1135)
        /// </summary>
        public static Culture GreenlandicGreenland => new Culture(0x046F, "kl-GL");
        /// <summary>
        /// gn (116)
        /// </summary>
        public static Culture Guarani => new Culture(0x0074, "gn");
        /// <summary>
        /// gn-PY (1140)
        /// </summary>
        public static Culture GuaraniParaguay => new Culture(0x0474, "gn-PY");
        /// <summary>
        /// gu (71)
        /// </summary>
        public static Culture Gujarati => new Culture(0x0047, "gu");
        /// <summary>
        /// gu-IN (1095)
        /// </summary>
        public static Culture GujaratiIndia => new Culture(0x0447, "gu-IN");
        /// <summary>
        /// ha (104)
        /// </summary>
        public static Culture Hausa => new Culture(0x0068, "ha");
        /// <summary>
        /// ha-Latn (31848)
        /// </summary>
        public static Culture HausaLatn => new Culture(0x7C68, "ha-Latn");
        /// <summary>
        /// ha-Latn-NG (1128)
        /// </summary>
        public static Culture HausaLatnNigeria => new Culture(0x0468, "ha-Latn-NG");
        /// <summary>
        /// haw (117)
        /// </summary>
        public static Culture Hawaiian => new Culture(0x0075, "haw");
        /// <summary>
        /// haw-US (1141)
        /// </summary>
        public static Culture HawaiianUnitedStates => new Culture(0x0475, "haw-US");
        /// <summary>
        /// he (13)
        /// </summary>
        public static Culture Hebrew => new Culture(0x000D, "he");
        /// <summary>
        /// he-IL (1037)
        /// </summary>
        public static Culture HebrewIsrael => new Culture(0x040D, "he-IL");
        /// <summary>
        /// hi (57)
        /// </summary>
        public static Culture Hindi => new Culture(0x0039, "hi");
        /// <summary>
        /// hi-IN (1081)
        /// </summary>
        public static Culture HindiIndia => new Culture(0x0439, "hi-IN");
        /// <summary>
        /// hu (14)
        /// </summary>
        public static Culture Hungarian => new Culture(0x000E, "hu");
        /// <summary>
        /// hu-HU (1038)
        /// </summary>
        public static Culture HungarianHungary => new Culture(0x040E, "hu-HU");
        /// <summary>
        /// is (15)
        /// </summary>
        public static Culture Icelandic => new Culture(0x000F, "is");
        /// <summary>
        /// is-IS (1039)
        /// </summary>
        public static Culture IcelandicIceland => new Culture(0x040F, "is-IS");
        /// <summary>
        /// ig (112)
        /// </summary>
        public static Culture Igbo => new Culture(0x0070, "ig");
        /// <summary>
        /// ig-NG (1136)
        /// </summary>
        public static Culture IgboNigeria => new Culture(0x0470, "ig-NG");
        /// <summary>
        /// id (33)
        /// </summary>
        public static Culture Indonesian => new Culture(0x0021, "id");
        /// <summary>
        /// id-ID (1057)
        /// </summary>
        public static Culture IndonesianIndonesia => new Culture(0x0421, "id-ID");
        /// <summary>
        /// iu (93)
        /// </summary>
        public static Culture Inuktitut => new Culture(0x005D, "iu");
        /// <summary>
        /// iu-Latn (31837)
        /// </summary>
        public static Culture InuktitutLatn => new Culture(0x7C5D, "iu-Latn");
        /// <summary>
        /// iu-Latn-CA (2141)
        /// </summary>
        public static Culture InuktitutLatnCanada => new Culture(0x085D, "iu-Latn-CA");
        /// <summary>
        /// iu-Cans (30813)
        /// </summary>
        public static Culture InuktitutCans => new Culture(0x785D, "iu-Cans");
        /// <summary>
        /// iu-Cans-CA (1117)
        /// </summary>
        public static Culture InuktitutCansCanada => new Culture(0x045d, "iu-Cans-CA");
        /// <summary>
        /// ga (60)
        /// </summary>
        public static Culture Irish => new Culture(0x003C, "ga");
        /// <summary>
        /// ga-IE (2108)
        /// </summary>
        public static Culture IrishIreland => new Culture(0x083C, "ga-IE");
        /// <summary>
        /// it (16)
        /// </summary>
        public static Culture Italian => new Culture(0x0010, "it");
        /// <summary>
        /// it-IT (1040)
        /// </summary>
        public static Culture ItalianItaly => new Culture(0x0410, "it-IT");
        /// <summary>
        /// it-CH (2064)
        /// </summary>
        public static Culture ItalianSwitzerland => new Culture(0x0810, "it-CH");
        /// <summary>
        /// ja (17)
        /// </summary>
        public static Culture Japanese => new Culture(0x0011, "ja");
        /// <summary>
        /// ja-JP (1041)
        /// </summary>
        public static Culture JapaneseJapan => new Culture(0x0411, "ja-JP");
        /// <summary>
        /// kn (75)
        /// </summary>
        public static Culture Kannada => new Culture(0x004B, "kn");
        /// <summary>
        /// kn-IN (1099)
        /// </summary>
        public static Culture KannadaIndia => new Culture(0x044B, "kn-IN");
        /// <summary>
        /// ks (96)
        /// </summary>
        public static Culture Kashmiri => new Culture(0x0060, "ks");
        /// <summary>
        /// ks-Arab (1120)
        /// </summary>
        public static Culture KashmiriArab => new Culture(0x0460, "ks-Arab");
        /// <summary>
        /// kk (63)
        /// </summary>
        public static Culture Kazakh => new Culture(0x003F, "kk");
        /// <summary>
        /// kk-KZ (1087)
        /// </summary>
        public static Culture KazakhKazakhstan => new Culture(0x043F, "kk-KZ");
        /// <summary>
        /// km (83)
        /// </summary>
        public static Culture Khmer => new Culture(0x0053, "km");
        /// <summary>
        /// km-KH (1107)
        /// </summary>
        public static Culture KhmerCambodia => new Culture(0x0453, "km-KH");
        /// <summary>
        /// quc (134)
        /// </summary>
        public static Culture Quiche => new Culture(0x0086, "quc");
        /// <summary>
        /// quc-Latn-GT (1158)
        /// </summary>
        public static Culture QuicheGuatemala => new Culture(0x0486, "quc-Latn-GT");
        /// <summary>
        /// rw (135)
        /// </summary>
        public static Culture Kinyarwanda => new Culture(0x0087, "rw");
        /// <summary>
        /// rw-RW (1159)
        /// </summary>
        public static Culture KinyarwandaRwanda => new Culture(0x0487, "rw-RW");
        /// <summary>
        /// sw (65)
        /// </summary>
        public static Culture Kiswahili => new Culture(0x0041, "sw");
        /// <summary>
        /// sw-KE (1089)
        /// </summary>
        public static Culture KiswahiliKenya => new Culture(0x0441, "sw-KE");
        /// <summary>
        /// kok (87)
        /// </summary>
        public static Culture Konkani => new Culture(0x0057, "kok");
        /// <summary>
        /// kok-IN (1111)
        /// </summary>
        public static Culture KonkaniIndia => new Culture(0x0457, "kok-IN");
        /// <summary>
        /// ko (18)
        /// </summary>
        public static Culture Korean => new Culture(0x0012, "ko");
        /// <summary>
        /// ko-KR (1042)
        /// </summary>
        public static Culture KoreanKorea => new Culture(0x0412, "ko-KR");
        /// <summary>
        /// ky (64)
        /// </summary>
        public static Culture Kyrgyz => new Culture(0x0040, "ky");
        /// <summary>
        /// ky-KG (1088)
        /// </summary>
        public static Culture KyrgyzKyrgyzstan => new Culture(0x0440, "ky-KG");
        /// <summary>
        /// lo (84)
        /// </summary>
        public static Culture Lao => new Culture(0x0054, "lo");
        /// <summary>
        /// lo-LA (1108)
        /// </summary>
        public static Culture LaoLaos => new Culture(0x0454, "lo-LA");
        /// <summary>
        /// lv (38)
        /// </summary>
        public static Culture Latvian => new Culture(0x0026, "lv");
        /// <summary>
        /// lv-LV (1062)
        /// </summary>
        public static Culture LatvianLatvia => new Culture(0x0426, "lv-LV");
        /// <summary>
        /// lt (39)
        /// </summary>
        public static Culture Lithuanian => new Culture(0x0027, "lt");
        /// <summary>
        /// lt-LT (1063)
        /// </summary>
        public static Culture LithuanianLithuania => new Culture(0x0427, "lt-LT");
        /// <summary>
        /// dsb (31790)
        /// </summary>
        public static Culture LowerSorbian => new Culture(0x7C2E, "dsb");
        /// <summary>
        /// dsb-DE (2094)
        /// </summary>
        public static Culture LowerSorbianGermany => new Culture(0x082E, "dsb-DE");
        /// <summary>
        /// lb (110)
        /// </summary>
        public static Culture Luxembourgish => new Culture(0x006E, "lb");
        /// <summary>
        /// lb-LU (1134)
        /// </summary>
        public static Culture LuxembourgishLuxembourg => new Culture(0x046E, "lb-LU");
        /// <summary>
        /// mk (47)
        /// </summary>
        public static Culture Macedonian => new Culture(0x002F, "mk");
        /// <summary>
        /// mk-MK (1071)
        /// </summary>
        public static Culture MacedonianMacedonia => new Culture(0x042F, "mk-MK");
        /// <summary>
        /// ms (62)
        /// </summary>
        public static Culture Malay => new Culture(0x003E, "ms");
        /// <summary>
        /// ms-BN (2110)
        /// </summary>
        public static Culture MalayBrunei => new Culture(0x083E, "ms-BN");
        /// <summary>
        /// ms-MY (1086)
        /// </summary>
        public static Culture MalayMalaysia => new Culture(0x043E, "ms-MY");
        /// <summary>
        /// ml (76)
        /// </summary>
        public static Culture Malayalam => new Culture(0x004C, "ml");
        /// <summary>
        /// ml-IN (1100)
        /// </summary>
        public static Culture MalayalamIndia => new Culture(0x044C, "ml-IN");
        /// <summary>
        /// mt (58)
        /// </summary>
        public static Culture Maltese => new Culture(0x003A, "mt");
        /// <summary>
        /// mt-MT (1082)
        /// </summary>
        public static Culture MalteseMalta => new Culture(0x043A, "mt-MT");
        /// <summary>
        /// mi (129)
        /// </summary>
        public static Culture Maori => new Culture(0x0081, "mi");
        /// <summary>
        /// mi-NZ (1153)
        /// </summary>
        public static Culture MaoriNewZealand => new Culture(0x0481, "mi-NZ");
        /// <summary>
        /// arn (122)
        /// </summary>
        public static Culture Mapudungun => new Culture(0x007A, "arn");
        /// <summary>
        /// arn-CL (1146)
        /// </summary>
        public static Culture MapudungunChile => new Culture(0x047A, "arn-CL");
        /// <summary>
        /// mr (78)
        /// </summary>
        public static Culture Marathi => new Culture(0x004E, "mr");
        /// <summary>
        /// mr-IN (1102)
        /// </summary>
        public static Culture MarathiIndia => new Culture(0x044E, "mr-IN");
        /// <summary>
        /// moh (124)
        /// </summary>
        public static Culture Mohawk => new Culture(0x007C, "moh");
        /// <summary>
        /// moh-CA (1148)
        /// </summary>
        public static Culture MohawkCanada => new Culture(0x047C, "moh-CA");
        /// <summary>
        /// mn (80)
        /// </summary>
        public static Culture Mongolian => new Culture(0x0050, "mn");
        /// <summary>
        /// mn-Cyrl (30800)
        /// </summary>
        public static Culture MongolianCyrl => new Culture(0x7850, "mn-Cyrl");
        /// <summary>
        /// mn-MN (1104)
        /// </summary>
        public static Culture MongolianCyrlMongolia => new Culture(0x0450, "mn-MN");
        /// <summary>
        /// mn-Mong (31824)
        /// </summary>
        public static Culture MongolianMong => new Culture(0x7C50, "mn-Mong");
        /// <summary>
        /// mn-Mong-CN (2128)
        /// </summary>
        public static Culture MongolianMongChina => new Culture(0x0850, "mn-Mong-CN");
        /// <summary>
        /// mn-Mong-MN (3152)
        /// </summary>
        public static Culture MongolianMongMongolia => new Culture(0x0C50, "mn-Mong-MN");
        /// <summary>
        /// ne (97)
        /// </summary>
        public static Culture Nepali => new Culture(0x0061, "ne");
        /// <summary>
        /// ne-IN (2145)
        /// </summary>
        public static Culture NepaliIndia => new Culture(0x0861, "ne-IN");
        /// <summary>
        /// ne-NP (1121)
        /// </summary>
        public static Culture NepaliNepal => new Culture(0x0461, "ne-NP");
        /// <summary>
        /// no (20)
        /// </summary>
        public static Culture Norwegian => new Culture(0x0014, "no");
        /// <summary>
        /// nb (31764)
        /// </summary>
        public static Culture NorwegianBokmal => new Culture(0x7C14, "nb");
        /// <summary>
        /// nb-NO (1044)
        /// </summary>
        public static Culture NorwegianBokmalNorway => new Culture(0x0414, "nb-NO");
        /// <summary>
        /// nn (30740)
        /// </summary>
        public static Culture NorwegianNynorsk => new Culture(0x7814, "nn");
        /// <summary>
        /// nn-NO (2068)
        /// </summary>
        public static Culture NorwegianNynorskNorway => new Culture(0x0814, "nn-NO");
        /// <summary>
        /// oc (130)
        /// </summary>
        public static Culture Occitan => new Culture(0x0082, "oc");
        /// <summary>
        /// oc-FR (1154)
        /// </summary>
        public static Culture OccitanFrance => new Culture(0x0482, "oc-FR");
        /// <summary>
        /// or (72)
        /// </summary>
        public static Culture Odia => new Culture(0x0048, "or");
        /// <summary>
        /// or-IN (1096)
        /// </summary>
        public static Culture OdiaIndia => new Culture(0x0448, "or-IN");
        /// <summary>
        /// om (114)
        /// </summary>
        public static Culture Oromo => new Culture(0x0072, "om");
        /// <summary>
        /// om-ET (1138)
        /// </summary>
        public static Culture OromoEthiopia => new Culture(0x0472, "om-ET");
        /// <summary>
        /// ps (99)
        /// </summary>
        public static Culture Pashto => new Culture(0x0063, "ps");
        /// <summary>
        /// ps-AF (1123)
        /// </summary>
        public static Culture PashtoAfghanistan => new Culture(0x0463, "ps-AF");
        /// <summary>
        /// fa (41)
        /// </summary>
        public static Culture Persian => new Culture(0x0029, "fa");
        /// <summary>
        /// fa-IR (1065)
        /// </summary>
        public static Culture PersianIran => new Culture(0x0429, "fa-IR");
        /// <summary>
        /// pl (21)
        /// </summary>
        public static Culture Polish => new Culture(0x0015, "pl");
        /// <summary>
        /// pl-PL (1045)
        /// </summary>
        public static Culture PolishPoland => new Culture(0x0415, "pl-PL");
        /// <summary>
        /// pt (22)
        /// </summary>
        public static Culture Portuguese => new Culture(0x0016, "pt");
        /// <summary>
        /// pt-BR (1046)
        /// </summary>
        public static Culture PortugueseBrazil => new Culture(0x0416, "pt-BR");
        /// <summary>
        /// pt-PT (2070)
        /// </summary>
        public static Culture PortuguesePortugal => new Culture(0x0816, "pt-PT");
        /// <summary>
        /// qps-ploca (1534)
        /// </summary>
        public static Culture PseudoAsia => new Culture(0x05FE, "qps-ploca");
        /// <summary>
        /// qps-ploc (1281)
        /// </summary>
        public static Culture Pseudo => new Culture(0x0501, "qps-ploc");
        /// <summary>
        /// qps-plocm (2559)
        /// </summary>
        public static Culture PseudoMirrored => new Culture(0x09FF, "qps-plocm");
        /// <summary>
        /// pa (70)
        /// </summary>
        public static Culture Punjabi => new Culture(0x0046, "pa");
        /// <summary>
        /// pa-Arab (31814)
        /// </summary>
        public static Culture PunjabiArab => new Culture(0x7C46, "pa-Arab");
        /// <summary>
        /// pa-IN (1094)
        /// </summary>
        public static Culture PunjabiIndia => new Culture(0x0446, "pa-IN");
        /// <summary>
        /// pa-Arab-PK (2118)
        /// </summary>
        public static Culture PunjabiPakistan => new Culture(0x0846, "pa-Arab-PK");
        /// <summary>
        /// quz (107)
        /// </summary>
        public static Culture Quechua => new Culture(0x006B, "quz");
        /// <summary>
        /// quz-BO (1131)
        /// </summary>
        public static Culture QuechuaBolivia => new Culture(0x046B, "quz-BO");
        /// <summary>
        /// quz-EC (2155)
        /// </summary>
        public static Culture QuechuaEcuador => new Culture(0x086B, "quz-EC");
        /// <summary>
        /// quz-PE (3179)
        /// </summary>
        public static Culture QuechuaPeru => new Culture(0x0C6B, "quz-PE");
        /// <summary>
        /// ro (24)
        /// </summary>
        public static Culture Romanian => new Culture(0x0018, "ro");
        /// <summary>
        /// ro-MD (2072)
        /// </summary>
        public static Culture RomanianMoldova => new Culture(0x0818, "ro-MD");
        /// <summary>
        /// ro-RO (1048)
        /// </summary>
        public static Culture RomanianRomania => new Culture(0x0418, "ro-RO");
        /// <summary>
        /// rm (23)
        /// </summary>
        public static Culture Romansh => new Culture(0x0017, "rm");
        /// <summary>
        /// rm-CH (1047)
        /// </summary>
        public static Culture RomanshSwitzerland => new Culture(0x0417, "rm-CH");
        /// <summary>
        /// ru (25)
        /// </summary>
        public static Culture Russian => new Culture(0x0019, "ru");
        /// <summary>
        /// ru-MD (2073)
        /// </summary>
        public static Culture RussianMoldova => new Culture(0x0819, "ru-MD");
        /// <summary>
        /// ru-RU (1049)
        /// </summary>
        public static Culture RussianRussia => new Culture(0x0419, "ru-RU");
        /// <summary>
        /// sah (133)
        /// </summary>
        public static Culture Sakha => new Culture(0x0085, "sah");
        /// <summary>
        /// sah-RU (1157)
        /// </summary>
        public static Culture SakhaRussia => new Culture(0x0485, "sah-RU");
        /// <summary>
        /// smn (28731)
        /// </summary>
        public static Culture SamiInari => new Culture(0x703B, "smn");
        /// <summary>
        /// smn-FI (9275)
        /// </summary>
        public static Culture SamiInariFinland => new Culture(0x243B, "smn-FI");
        /// <summary>
        /// smj (31803)
        /// </summary>
        public static Culture SamiLule => new Culture(0x7C3B, "smj");
        /// <summary>
        /// smj-NO (4155)
        /// </summary>
        public static Culture SamiLuleNorway => new Culture(0x103B, "smj-NO");
        /// <summary>
        /// smj-SE (5179)
        /// </summary>
        public static Culture SamiLuleSweden => new Culture(0x143B, "smj-SE");
        /// <summary>
        /// se (59)
        /// </summary>
        public static Culture SamiNorthern => new Culture(0x003B, "se");
        /// <summary>
        /// se-FI (3131)
        /// </summary>
        public static Culture SamiNorthernFinland => new Culture(0x0C3B, "se-FI");
        /// <summary>
        /// se-NO (1083)
        /// </summary>
        public static Culture SamiNorthernNorway => new Culture(0x043B, "se-NO");
        /// <summary>
        /// se-SE (2107)
        /// </summary>
        public static Culture SamiNorthernSweden => new Culture(0x083B, "se-SE");
        /// <summary>
        /// sms (29755)
        /// </summary>
        public static Culture SamiSkolt => new Culture(0x743B, "sms");
        /// <summary>
        /// sms-FI (8251)
        /// </summary>
        public static Culture SamiSkoltFinland => new Culture(0x203B, "sms-FI");
        /// <summary>
        /// sma (30779)
        /// </summary>
        public static Culture SamiSouthern => new Culture(0x783B, "sma");
        /// <summary>
        /// sma-NO (6203)
        /// </summary>
        public static Culture SamiSouthernNorway => new Culture(0x183B, "sma-NO");
        /// <summary>
        /// sma-SE (7227)
        /// </summary>
        public static Culture SamiSouthernSweden => new Culture(0x1C3B, "sma-SE");
        /// <summary>
        /// sa (79)
        /// </summary>
        public static Culture Sanskrit => new Culture(0x004F, "sa");
        /// <summary>
        /// sa-IN (1103)
        /// </summary>
        public static Culture SanskritIndia => new Culture(0x044F, "sa-IN");
        /// <summary>
        /// gd (145)
        /// </summary>
        public static Culture ScottishGaelic => new Culture(0x0091, "gd");
        /// <summary>
        /// gd-GB (1169)
        /// </summary>
        public static Culture ScottishGaelicUnitedKingdom => new Culture(0x0491, "gd-GB");
        /// <summary>
        /// sr-Cyrl (27674)
        /// </summary>
        public static Culture SerbianCyrl => new Culture(0x6C1A, "sr-Cyrl");
        /// <summary>
        /// sr-Cyrl-BA (7194)
        /// </summary>
        public static Culture SerbianCyrlBosniaAndHerzegovina => new Culture(0x1C1A, "sr-Cyrl-BA");
        /// <summary>
        /// sr-Cyrl-ME (12314)
        /// </summary>
        public static Culture SerbianCyrlMontenegro => new Culture(0x301A, "sr-Cyrl-ME");
        /// <summary>
        /// sr-Cyrl-RS (10266)
        /// </summary>
        public static Culture SerbianCyrlSerbia => new Culture(0x281A, "sr-Cyrl-RS");
        /// <summary>
        /// sr-Cyrl-CS (3098)
        /// </summary>
        public static Culture SerbianCyrlSerbiaAndMontenegro => new Culture(0x0C1A, "sr-Cyrl-CS");
        /// <summary>
        /// sr-Latn (28698)
        /// </summary>
        public static Culture SerbianLatn => new Culture(0x701A, "sr-Latn");
        /// <summary>
        /// sr (31770)
        /// </summary>
        public static Culture Serbian => new Culture(0x7C1A, "sr");
        /// <summary>
        /// sr-Latn-BA (6170)
        /// </summary>
        public static Culture SerbianLatnBosniaAndHerzegovina => new Culture(0x181A, "sr-Latn-BA");
        /// <summary>
        /// sr-Latn-ME (11290)
        /// </summary>
        public static Culture SerbianLatnMontenegro => new Culture(0x2c1A, "sr-Latn-ME");
        /// <summary>
        /// sr-Latn-RS (9242)
        /// </summary>
        public static Culture SerbianLatnSerbia => new Culture(0x241A, "sr-Latn-RS");
        /// <summary>
        /// sr-Latn-CS (2074)
        /// </summary>
        public static Culture SerbianLatnSerbiaAndMontenegro => new Culture(0x081A, "sr-Latn-CS");
        /// <summary>
        /// nso (108)
        /// </summary>
        public static Culture SesothoSaLeboa => new Culture(0x006C, "nso");
        /// <summary>
        /// nso-ZA (1132)
        /// </summary>
        public static Culture SesothoSaLeboaSouthAfrica => new Culture(0x046C, "nso-ZA");
        /// <summary>
        /// tn (50)
        /// </summary>
        public static Culture Setswana => new Culture(0x0032, "tn");
        /// <summary>
        /// tn-BW (2098)
        /// </summary>
        public static Culture SetswanaBotswana => new Culture(0x0832, "tn-BW");
        /// <summary>
        /// tn-ZA (1074)
        /// </summary>
        public static Culture SetswanaSouthAfrica => new Culture(0x0432, "tn-ZA");
        /// <summary>
        /// sd (89)
        /// </summary>
        public static Culture Sindhi => new Culture(0x0059, "sd");
        /// <summary>
        /// sd-Arab (31833)
        /// </summary>
        public static Culture SindhiArab => new Culture(0x7C59, "sd-Arab");
        /// <summary>
        /// sd-Arab-PK (2137)
        /// </summary>
        public static Culture SindhiPakistan => new Culture(0x0859, "sd-Arab-PK");
        /// <summary>
        /// si (91)
        /// </summary>
        public static Culture Sinhala => new Culture(0x005B, "si");
        /// <summary>
        /// si-LK (1115)
        /// </summary>
        public static Culture SinhalaSriLanka => new Culture(0x045B, "si-LK");
        /// <summary>
        /// sk (27)
        /// </summary>
        public static Culture Slovak => new Culture(0x001B, "sk");
        /// <summary>
        /// sk-SK (1051)
        /// </summary>
        public static Culture SlovakSlovakia => new Culture(0x041B, "sk-SK");
        /// <summary>
        /// sl (36)
        /// </summary>
        public static Culture Slovenian => new Culture(0x0024, "sl");
        /// <summary>
        /// sl-SI (1060)
        /// </summary>
        public static Culture SlovenianSlovenia => new Culture(0x0424, "sl-SI");
        /// <summary>
        /// so (119)
        /// </summary>
        public static Culture Somali => new Culture(0x0077, "so");
        /// <summary>
        /// so-SO (1143)
        /// </summary>
        public static Culture SomaliSomalia => new Culture(0x0477, "so-SO");
        /// <summary>
        /// st (48)
        /// </summary>
        public static Culture Sotho => new Culture(0x0030, "st");
        /// <summary>
        /// st-ZA (1072)
        /// </summary>
        public static Culture SothoSouthAfrica => new Culture(0x0430, "st-ZA");
        /// <summary>
        /// es (10)
        /// </summary>
        public static Culture Spanish => new Culture(0x000A, "es");
        /// <summary>
        /// es-AR (11274)
        /// </summary>
        public static Culture SpanishArgentina => new Culture(0x2C0A, "es-AR");
        /// <summary>
        /// es-VE (8202)
        /// </summary>
        public static Culture SpanishVenezuela => new Culture(0x200A, "es-VE");
        /// <summary>
        /// es-BO (16394)
        /// </summary>
        public static Culture SpanishBolivia => new Culture(0x400A, "es-BO");
        /// <summary>
        /// es-CL (13322)
        /// </summary>
        public static Culture SpanishChile => new Culture(0x340A, "es-CL");
        /// <summary>
        /// es-CO (9226)
        /// </summary>
        public static Culture SpanishColombia => new Culture(0x240A, "es-CO");
        /// <summary>
        /// es-CR (5130)
        /// </summary>
        public static Culture SpanishCostaRica => new Culture(0x140A, "es-CR");
        /// <summary>
        /// es-CU (23562)
        /// </summary>
        public static Culture SpanishCuba => new Culture(0x5c0A, "es-CU");
        /// <summary>
        /// es-DO (7178)
        /// </summary>
        public static Culture SpanishDominicanRepublic => new Culture(0x1c0A, "es-DO");
        /// <summary>
        /// es-EC (12298)
        /// </summary>
        public static Culture SpanishEcuador => new Culture(0x300A, "es-EC");
        /// <summary>
        /// es-SV (17418)
        /// </summary>
        public static Culture SpanishElSalvador => new Culture(0x440A, "es-SV");
        /// <summary>
        /// es-GT (4106)
        /// </summary>
        public static Culture SpanishGuatemala => new Culture(0x100A, "es-GT");
        /// <summary>
        /// es-HN (18442)
        /// </summary>
        public static Culture SpanishHonduras => new Culture(0x480A, "es-HN");
        /// <summary>
        /// es-419 (22538)
        /// </summary>
        public static Culture SpanishLatinAmerica => new Culture(0x580A, "es-419");
        /// <summary>
        /// es-MX (2058)
        /// </summary>
        public static Culture SpanishMexico => new Culture(0x080A, "es-MX");
        /// <summary>
        /// es-NI (19466)
        /// </summary>
        public static Culture SpanishNicaragua => new Culture(0x4C0A, "es-NI");
        /// <summary>
        /// es-PA (6154)
        /// </summary>
        public static Culture SpanishPanama => new Culture(0x180A, "es-PA");
        /// <summary>
        /// es-PY (15370)
        /// </summary>
        public static Culture SpanishParaguay => new Culture(0x3C0A, "es-PY");
        /// <summary>
        /// es-PE (10250)
        /// </summary>
        public static Culture SpanishPeru => new Culture(0x280A, "es-PE");
        /// <summary>
        /// es-PR (20490)
        /// </summary>
        public static Culture SpanishPuertoRico => new Culture(0x500A, "es-PR");
        /// <summary>
        /// es-ES_tradnl (1034)
        /// </summary>
        public static Culture SpanishSpainTrad => new Culture(0x040A, "es-ES_tradnl");
        /// <summary>
        /// es-ES (3082)
        /// </summary>
        public static Culture SpanishSpain => new Culture(0x0c0A, "es-ES");
        /// <summary>
        /// es-US (21514)
        /// </summary>
        public static Culture SpanishUnitedStates => new Culture(0x540A, "es-US");
        /// <summary>
        /// es-UY (14346)
        /// </summary>
        public static Culture SpanishUruguay => new Culture(0x380A, "es-UY");
        /// <summary>
        /// sv (29)
        /// </summary>
        public static Culture Swedish => new Culture(0x001D, "sv");
        /// <summary>
        /// sv-FI (2077)
        /// </summary>
        public static Culture SwedishFinland => new Culture(0x081D, "sv-FI");
        /// <summary>
        /// sv-SE (1053)
        /// </summary>
        public static Culture SwedishSweden => new Culture(0x041D, "sv-SE");
        /// <summary>
        /// syr (90)
        /// </summary>
        public static Culture Syriac => new Culture(0x005A, "syr");
        /// <summary>
        /// syr-SY (1114)
        /// </summary>
        public static Culture SyriacSyria => new Culture(0x045A, "syr-SY");
        /// <summary>
        /// tg (40)
        /// </summary>
        public static Culture Tajik => new Culture(0x0028, "tg");
        /// <summary>
        /// tg-Cyrl (31784)
        /// </summary>
        public static Culture TajikCyrl => new Culture(0x7C28, "tg-Cyrl");
        /// <summary>
        /// tg-Cyrl-TJ (1064)
        /// </summary>
        public static Culture TajikCyrlTajikistan => new Culture(0x0428, "tg-Cyrl-TJ");
        /// <summary>
        /// tzm (95)
        /// </summary>
        public static Culture Tamazight => new Culture(0x005F, "tzm");
        /// <summary>
        /// tzm-Latn (31839)
        /// </summary>
        public static Culture TamazightLatn => new Culture(0x7C5F, "tzm-Latn");
        /// <summary>
        /// tzm-Latn-DZ (2143)
        /// </summary>
        public static Culture TamazightLatnAlgeria => new Culture(0x085F, "tzm-Latn-DZ");
        /// <summary>
        /// ta (73)
        /// </summary>
        public static Culture Tamil => new Culture(0x0049, "ta");
        /// <summary>
        /// ta-IN (1097)
        /// </summary>
        public static Culture TamilIndia => new Culture(0x0449, "ta-IN");
        /// <summary>
        /// ta-LK (2121)
        /// </summary>
        public static Culture TamilSriLanka => new Culture(0x0849, "ta-LK");
        /// <summary>
        /// tt (68)
        /// </summary>
        public static Culture Tatar => new Culture(0x0044, "tt");
        /// <summary>
        /// tt-RU (1092)
        /// </summary>
        public static Culture TatarRussia => new Culture(0x0444, "tt-RU");
        /// <summary>
        /// te (74)
        /// </summary>
        public static Culture Telugu => new Culture(0x004A, "te");
        /// <summary>
        /// te-IN (1098)
        /// </summary>
        public static Culture TeluguIndia => new Culture(0x044A, "te-IN");
        /// <summary>
        /// th (30)
        /// </summary>
        public static Culture Thai => new Culture(0x001E, "th");
        /// <summary>
        /// th-TH (1054)
        /// </summary>
        public static Culture ThaiThailand => new Culture(0x041E, "th-TH");
        /// <summary>
        /// bo (81)
        /// </summary>
        public static Culture Tibetan => new Culture(0x0051, "bo");
        /// <summary>
        /// bo-CN (1105)
        /// </summary>
        public static Culture TibetanChina => new Culture(0x0451, "bo-CN");
        /// <summary>
        /// ti (115)
        /// </summary>
        public static Culture Tigrinya => new Culture(0x0073, "ti");
        /// <summary>
        /// ti-ER (2163)
        /// </summary>
        public static Culture TigrinyaEritrea => new Culture(0x0873, "ti-ER");
        /// <summary>
        /// ti-ET (1139)
        /// </summary>
        public static Culture TigrinyaEthiopia => new Culture(0x0473, "ti-ET");
        /// <summary>
        /// ts (49)
        /// </summary>
        public static Culture Tsonga => new Culture(0x0031, "ts");
        /// <summary>
        /// ts-ZA (1073)
        /// </summary>
        public static Culture TsongaSouthAfrica => new Culture(0x0431, "ts-ZA");
        /// <summary>
        /// tr (31)
        /// </summary>
        public static Culture Turkish => new Culture(0x001F, "tr");
        /// <summary>
        /// tr-TR (1055)
        /// </summary>
        public static Culture TurkishTurkey => new Culture(0x041F, "tr-TR");
        /// <summary>
        /// tk (66)
        /// </summary>
        public static Culture Turkmen => new Culture(0x0042, "tk");
        /// <summary>
        /// tk-TM (1090)
        /// </summary>
        public static Culture TurkmenTurkmenistan => new Culture(0x0442, "tk-TM");
        /// <summary>
        /// uk (34)
        /// </summary>
        public static Culture Ukrainian => new Culture(0x0022, "uk");
        /// <summary>
        /// uk-UA (1058)
        /// </summary>
        public static Culture UkrainianUkraine => new Culture(0x0422, "uk-UA");
        /// <summary>
        /// dsb or hsb (46)
        /// </summary>
        public static Culture UpperSorbian => new Culture(0x002E, "dsb or hsb");
        /// <summary>
        /// hsb-DE (1070)
        /// </summary>
        public static Culture UpperSorbianGermany => new Culture(0x042E, "hsb-DE");
        /// <summary>
        /// ur (32)
        /// </summary>
        public static Culture Urdu => new Culture(0x0020, "ur");
        /// <summary>
        /// ur-IN (2080)
        /// </summary>
        public static Culture UrduIndia => new Culture(0x0820, "ur-IN");
        /// <summary>
        /// ur-PK (1056)
        /// </summary>
        public static Culture UrduPakistan => new Culture(0x0420, "ur-PK");
        /// <summary>
        /// ug (128)
        /// </summary>
        public static Culture Uyghur => new Culture(0x0080, "ug");
        /// <summary>
        /// ug-CN (1152)
        /// </summary>
        public static Culture UyghurChina => new Culture(0x0480, "ug-CN");
        /// <summary>
        /// uz-Cyrl (30787)
        /// </summary>
        public static Culture UzbekCyrl => new Culture(0x7843, "uz-Cyrl");
        /// <summary>
        /// uz-Cyrl-UZ (2115)
        /// </summary>
        public static Culture UzbekCyrlUzbekistan => new Culture(0x0843, "uz-Cyrl-UZ");
        /// <summary>
        /// uz (67)
        /// </summary>
        public static Culture Uzbek => new Culture(0x0043, "uz");
        /// <summary>
        /// uz-Latn (31811)
        /// </summary>
        public static Culture UzbekLatn => new Culture(0x7C43, "uz-Latn");
        /// <summary>
        /// uz-Latn-UZ (1091)
        /// </summary>
        public static Culture UzbekLatnUzbekistan => new Culture(0x0443, "uz-Latn-UZ");
        /// <summary>
        /// ca-ES-valencia (2051)
        /// </summary>
        public static Culture ValencianSpain => new Culture(0x0803, "ca-ES-valencia");
        /// <summary>
        /// ve (51)
        /// </summary>
        public static Culture Venda => new Culture(0x0033, "ve");
        /// <summary>
        /// ve-ZA (1075)
        /// </summary>
        public static Culture VendaSouthAfrica => new Culture(0x0433, "ve-ZA");
        /// <summary>
        /// vi (42)
        /// </summary>
        public static Culture Vietnamese => new Culture(0x002A, "vi");
        /// <summary>
        /// vi-VN (1066)
        /// </summary>
        public static Culture VietnameseVietnam => new Culture(0x042A, "vi-VN");
        /// <summary>
        /// cy (82)
        /// </summary>
        public static Culture Welsh => new Culture(0x0052, "cy");
        /// <summary>
        /// cy-GB (1106)
        /// </summary>
        public static Culture WelshUnitedKingdom => new Culture(0x0452, "cy-GB");
        /// <summary>
        /// wo (136)
        /// </summary>
        public static Culture Wolof => new Culture(0x0088, "wo");
        /// <summary>
        /// wo-SN (1160)
        /// </summary>
        public static Culture WolofSenegal => new Culture(0x0488, "wo-SN");
        /// <summary>
        /// xh (52)
        /// </summary>
        public static Culture Xhosa => new Culture(0x0034, "xh");
        /// <summary>
        /// xh-ZA (1076)
        /// </summary>
        public static Culture XhosaSouthAfrica => new Culture(0x0434, "xh-ZA");
        /// <summary>
        /// ii (120)
        /// </summary>
        public static Culture Yi => new Culture(0x0078, "ii");
        /// <summary>
        /// ii-CN (1144)
        /// </summary>
        public static Culture YiChina => new Culture(0x0478, "ii-CN");
        /// <summary>
        /// yo (106)
        /// </summary>
        public static Culture Yoruba => new Culture(0x006A, "yo");
        /// <summary>
        /// yo-NG (1130)
        /// </summary>
        public static Culture YorubaNigeria => new Culture(0x046A, "yo-NG");
        /// <summary>
        /// zu (53)
        /// </summary>
        public static Culture Zulu => new Culture(0x0035, "zu");
        /// <summary>
        /// zu-ZA (1077)
        /// </summary>
        public static Culture ZuluSouthAfrica => new Culture(0x0435, "zu-ZA");

    }
}