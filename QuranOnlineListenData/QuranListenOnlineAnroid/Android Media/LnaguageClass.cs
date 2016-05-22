using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Android_Media
{
    class LnaguageClass
    {
        int LanguageSelect = 1; // lanuage selected 1-arabic 2- english

        //get list of Recites
        public List<AuthorClass> AutherList()
        {
            //120 read of quran
            List<AuthorClass> AutherListInfo = new List<AuthorClass>();
            if (LanguageSelect == 1)
            {
                AutherListInfo.Add(new AuthorClass("shatri", "ابو بكر الشاطري"));
                AutherListInfo.Add(new AuthorClass("ahmad_huth", "أحمد الحذيفي"));
                AutherListInfo.Add(new AuthorClass("hawashi", " أحمد الحواشي"));
                AutherListInfo.Add(new AuthorClass("trabulsi", " أحمد الطرابلسي"));
                AutherListInfo.Add(new AuthorClass("ajm", "أحمد بن علي العجمي "));
                AutherListInfo.Add(new AuthorClass("trablsi", " أحمد خضر الطرابلسي"));
                AutherListInfo.Add(new AuthorClass("saud", "أحمد سعود "));
                AutherListInfo.Add(new AuthorClass("saber", " أحمد صابر"));
                AutherListInfo.Add(new AuthorClass("Aamer", "أحمد عامر "));
                AutherListInfo.Add(new AuthorClass("ahmad_nu", " أحمد نعينع"));
                AutherListInfo.Add(new AuthorClass("akil", " أخيل عبدالحي روا "));
                AutherListInfo.Add(new AuthorClass("akrm", " أكرم العلاقمي"));
                ////put in store
                AutherListInfo.Add(new AuthorClass("akdr", " إبراهيم الأخضر"));
                AutherListInfo.Add(new AuthorClass("IbrahemSadan", " إبراهيم السعدان"));
                AutherListInfo.Add(new AuthorClass("abkr", " إدريس أبكر"));
                AutherListInfo.Add(new AuthorClass("jbreen", " ابراهيم الجبرين"));
                AutherListInfo.Add(new AuthorClass("jormy", " ابراهيم الجرمي"));
                AutherListInfo.Add(new AuthorClass("ibrahim_dosri_warsh", " ابراهيم الدوسري"));
                AutherListInfo.Add(new AuthorClass("3siri", "ابراهيم العسيري "));
                AutherListInfo.Add(new AuthorClass("zamri", " استاذ زامري "));
                AutherListInfo.Add(new AuthorClass("3zazi", "الحسيني العزازي "));
                AutherListInfo.Add(new AuthorClass("dokali", " الدوكالي محمد العالم"));
                AutherListInfo.Add(new AuthorClass("alzain", " الزين محمد أحمد"));
                AutherListInfo.Add(new AuthorClass("omran", "العشري عمران "));
                AutherListInfo.Add(new AuthorClass("koshi", " العيون الكوشي"));
                AutherListInfo.Add(new AuthorClass("fateh", " الفاتح محمد الزبير"));
                AutherListInfo.Add(new AuthorClass("qari", "القارئ ياسين "));

                ///new qura
                AutherListInfo.Add(new AuthorClass("twfeeq", " توفيق الصايغ")); //**
                AutherListInfo.Add(new AuthorClass("jamal", " جمال شاكر عبدالله"));
                AutherListInfo.Add(new AuthorClass("jaman", " جمعان العصيمي"));
                AutherListInfo.Add(new AuthorClass("hatem", " حاتم فريد الواع"));
                AutherListInfo.Add(new AuthorClass("qht", " خالد القحطاني"));
                AutherListInfo.Add(new AuthorClass("mohna", " خالد المهنا"));
                AutherListInfo.Add(new AuthorClass("kafi", " خالد عبدالكافي"));
                AutherListInfo.Add(new AuthorClass("tnjy", "خليفة الطنيجي"));
                AutherListInfo.Add(new AuthorClass("hamza", " داود حمزة"));
                AutherListInfo.Add(new AuthorClass("ifrad", " رشيد إفراد"));
                AutherListInfo.Add(new AuthorClass("zaki", " زكي داغستاني"));
                AutherListInfo.Add(new AuthorClass("sami_dosr", " سامي الدوسري"));
                AutherListInfo.Add(new AuthorClass("s_gmd", " سعد الغامدي")); //**
                AutherListInfo.Add(new AuthorClass("shur", "سعود الشريم"));  //**
                AutherListInfo.Add(new AuthorClass("shl", " سهل ياسين"));
                AutherListInfo.Add(new AuthorClass("sayed", " سيد رمضان"));
                AutherListInfo.Add(new AuthorClass("taher", "شيرزاد عبدالرحمن طاهر"));
                AutherListInfo.Add(new AuthorClass("hkm", " صابر عبدالحكم"));
                AutherListInfo.Add(new AuthorClass("sahood", " صالح الصاهود"));
                AutherListInfo.Add(new AuthorClass("s_bud", " صلاح البدير"));
                AutherListInfo.Add(new AuthorClass("salah_hashim_m", " صلاح الهاشم"));
                AutherListInfo.Add(new AuthorClass("bu_khtr", "صلاح بو خاطر"));//**
                AutherListInfo.Add(new AuthorClass("tareq", "طارق عبدالغني دعوب"));
                AutherListInfo.Add(new AuthorClass("a_klb", " عادل الكلباني"));
                AutherListInfo.Add(new AuthorClass("ryan", " عادل ريان"));
                AutherListInfo.Add(new AuthorClass("thubti", " عبدالبارئ الثبيتي"));
                AutherListInfo.Add(new AuthorClass("bari", " عبدالبارئ محمد"));
                AutherListInfo.Add(new AuthorClass("bari_molm", " عبدالبارئ محمد م"));
                AutherListInfo.Add(new AuthorClass("basit", " عبدالباسط عبدالصمد ح"));
                AutherListInfo.Add(new AuthorClass("basit_warsh", " عبدالباسط عبدالصمد و"));//**
                AutherListInfo.Add(new AuthorClass("basit_mjwd", " عبدالباسط عبدالصمد  م"));
                AutherListInfo.Add(new AuthorClass("sds", " عبدالرحمن السديس"));//**
                AutherListInfo.Add(new AuthorClass("soufi_klf", " عبدالرشيد صوفي"));
                AutherListInfo.Add(new AuthorClass("soufi", "عبدالرشيد صوفي س"));
                AutherListInfo.Add(new AuthorClass("a_ahmed", " عبدالعزيز الأحمد"));
                AutherListInfo.Add(new AuthorClass("brmi", " عبدالله البريمي"));
                AutherListInfo.Add(new AuthorClass("Abdullahk", " عبدالله الكندري"));
                AutherListInfo.Add(new AuthorClass("mtrod", " عبدالله المطرود"));
                AutherListInfo.Add(new AuthorClass("bsfr", " عبدالله بصفر"));
                AutherListInfo.Add(new AuthorClass("kyat", " عبدالله خياط"));
                AutherListInfo.Add(new AuthorClass("jhn", " عبدالله عواد الجهني"));
                AutherListInfo.Add(new AuthorClass("mohsin_harthi", " عبدالمحسن الحارثي"));
                AutherListInfo.Add(new AuthorClass("obk", " عبدالمحسن العبيكان"));
                AutherListInfo.Add(new AuthorClass("qasm", " عبدالمحسن القاسم"));
                AutherListInfo.Add(new AuthorClass("kanakeri", " عبدالهادي أحمد كناكري"));
                AutherListInfo.Add(new AuthorClass("wdod", " عبدالودود حنيف"));
                AutherListInfo.Add(new AuthorClass("abo_hashim", " علي أبو هاشم"));
                AutherListInfo.Add(new AuthorClass("huthifi_qalon", " علي الحذيفي"));
                AutherListInfo.Add(new AuthorClass("hthfi", " علي بن عبدالرحمن الحذيفي"));
                AutherListInfo.Add(new AuthorClass("a_jbr", " علي جابر"));
                AutherListInfo.Add(new AuthorClass("hajjaj", " علي حجاج السويسي"));
                AutherListInfo.Add(new AuthorClass("hafz", " عماد زهير حافظ"));
                AutherListInfo.Add(new AuthorClass("frs_a", " فارس عباد"));
                AutherListInfo.Add(new AuthorClass("lafi", " لافي العوني"));
                AutherListInfo.Add(new AuthorClass("zaml", " ماجد الزامل"));
                AutherListInfo.Add(new AuthorClass("shaibat", "مالك شيبة الحمد"));
                AutherListInfo.Add(new AuthorClass("maher_m", " ماهر المعيقلي"));
                AutherListInfo.Add(new AuthorClass("maher", " ماهر المعيقلي ح"));
                AutherListInfo.Add(new AuthorClass("shaksh", " ماهر شخاشير"));
                AutherListInfo.Add(new AuthorClass("ayyub", " محمد أيوب"));
                AutherListInfo.Add(new AuthorClass("braak", " محمد البراك")); //**
                AutherListInfo.Add(new AuthorClass("tblawi", " محمد الطبلاوي"));
                AutherListInfo.Add(new AuthorClass("mhsny", " محمد المحيسني"));
                AutherListInfo.Add(new AuthorClass("monshed", " محمد المنشد"));
                AutherListInfo.Add(new AuthorClass("jbrl", " محمد جبريل"));
                AutherListInfo.Add(new AuthorClass("rashad", "محمد رشاد الشريف"));
                AutherListInfo.Add(new AuthorClass("shah", " محمد صالح"));
                AutherListInfo.Add(new AuthorClass("minsh", " محمد صديق المنشاوي"));//**
                AutherListInfo.Add(new AuthorClass("minsh_mjwd", "محمد صديق المنشاوي م"));
                AutherListInfo.Add(new AuthorClass("abdullah_dori", " محمد عبدالحكيم"));
                AutherListInfo.Add(new AuthorClass("khan", " محمد عثمان خان"));
                AutherListInfo.Add(new AuthorClass("mrifai", " محمود الرفاعي"));
                AutherListInfo.Add(new AuthorClass("sheimy", " محمود الشيمي"));
                AutherListInfo.Add(new AuthorClass("husr", " محمود خليل الحصري"));
                AutherListInfo.Add(new AuthorClass("bna_mjwd", " محمود علي البنا"));
                AutherListInfo.Add(new AuthorClass("afs", " مشاري العفاسي")); //**
                AutherListInfo.Add(new AuthorClass("mustafa", " مصطفى إسماعيل"));
                AutherListInfo.Add(new AuthorClass("lahoni", " مصطفى اللاهوني"));
                AutherListInfo.Add(new AuthorClass("ra3ad", " مصطفى رعد العزاوي"));
                AutherListInfo.Add(new AuthorClass("harthi", " معيض الحارثي"));
                AutherListInfo.Add(new AuthorClass("muftah_thakwan", " مفتاح السلطني"));
                AutherListInfo.Add(new AuthorClass("bilal", " موسى بلال"));
                AutherListInfo.Add(new AuthorClass("qtm", " ناصر القطامي"));
                AutherListInfo.Add(new AuthorClass("nabil", "  نبيل الرفاعي"));
                AutherListInfo.Add(new AuthorClass("namh", " نعمة الحسان"));//^^
                AutherListInfo.Add(new AuthorClass("hani", " هاني الرفاعي"));
                AutherListInfo.Add(new AuthorClass("waleed", " وليد النائحي"));
                AutherListInfo.Add(new AuthorClass("yasser", " ياسر الدوسري"));
                AutherListInfo.Add(new AuthorClass("qurashi", " ياسر القرشي"));
                AutherListInfo.Add(new AuthorClass("mzroyee", "ياسر المزروعي"));
                AutherListInfo.Add(new AuthorClass("yahya", " يحيى حوا"));
                AutherListInfo.Add(new AuthorClass("yousef", " يوسف الشويعي"));
                AutherListInfo.Add(new AuthorClass("noah", "يوسف بن نوح أحمد"));


            }





            else
            {
                AutherListInfo.Add(new AuthorClass("shatri", "Abo Bakr AL-shtri"));
                AutherListInfo.Add(new AuthorClass("ahmad_huth", "Ahmed Al-hadefy"));
                AutherListInfo.Add(new AuthorClass("hawashi", " Ahmed Al-hoshy"));
                AutherListInfo.Add(new AuthorClass("trabulsi", " Ahmed Al-triblsy"));
                AutherListInfo.Add(new AuthorClass("ajm", "Ahmed Al-ajmey "));
                AutherListInfo.Add(new AuthorClass("trablsi", " Ahmed Kudar Triblsy"));
                AutherListInfo.Add(new AuthorClass("saud", "Ahmed Suaad"));
                AutherListInfo.Add(new AuthorClass("saber", "Ahmed Sabar"));
                AutherListInfo.Add(new AuthorClass("Aamer", "Ahmed Amar"));
                AutherListInfo.Add(new AuthorClass("ahmad_nu", "Ahmed Nineei"));
                AutherListInfo.Add(new AuthorClass("akil", "Kalel Abd-alhie"));
                AutherListInfo.Add(new AuthorClass("akrm", " Akram AL-alkime"));
                AutherListInfo.Add(new AuthorClass("akdr", " Abrihim Kudar"));
                AutherListInfo.Add(new AuthorClass("IbrahemSadan", " Abrihim sadan"));
                AutherListInfo.Add(new AuthorClass("abkr", " Adress bakir"));
                AutherListInfo.Add(new AuthorClass("jbreen", " Abrihim jabrin"));
                AutherListInfo.Add(new AuthorClass("jormy", "Abrihim jazme"));
                AutherListInfo.Add(new AuthorClass("ibrahim_dosri_warsh", "  Abrihim dosey"));
                AutherListInfo.Add(new AuthorClass("3siri", "Abrihim aseriy"));
                AutherListInfo.Add(new AuthorClass("zamri", "mister Ramze"));
                AutherListInfo.Add(new AuthorClass("3zazi", "Al-husaney Al-azaze"));
                AutherListInfo.Add(new AuthorClass("dokali", " Al-dokaley mohammed al-alm"));
                AutherListInfo.Add(new AuthorClass("alzain", " Alzin mohammed ahmed"));
                AutherListInfo.Add(new AuthorClass("omran", "Al-ashire auomran"));
                AutherListInfo.Add(new AuthorClass("koshi", " Al eyon alkoshe"));
                AutherListInfo.Add(new AuthorClass("fateh", " Al-fatih mohamed alzober"));
                AutherListInfo.Add(new AuthorClass("qari", "Yasen al-kare "));
                /// update
                ///new qura
                AutherListInfo.Add(new AuthorClass("twfeeq", "Tofek alsaek"));
                AutherListInfo.Add(new AuthorClass("jamal", "jamal shakr abd"));
                AutherListInfo.Add(new AuthorClass("jaman", " joman al asime"));
                AutherListInfo.Add(new AuthorClass("hatem", "hatem fared alwaey"));
                AutherListInfo.Add(new AuthorClass("qht", "khiled alkahtine"));
                AutherListInfo.Add(new AuthorClass("mohna", " khilid almihin"));
                AutherListInfo.Add(new AuthorClass("kafi", " khilid almihin"));
                AutherListInfo.Add(new AuthorClass("tnjy", "kalefa altabnjey"));
                AutherListInfo.Add(new AuthorClass("hamza", "dawood hamza"));
                AutherListInfo.Add(new AuthorClass("ifrad", " rashed afrad"));
                AutherListInfo.Add(new AuthorClass("zaki", "zake dakistine"));
                AutherListInfo.Add(new AuthorClass("sami_dosr", "same aldosirey"));
                AutherListInfo.Add(new AuthorClass("s_gmd", "saad alkamade"));
                AutherListInfo.Add(new AuthorClass("shur", "sauuad alshirem"));
                AutherListInfo.Add(new AuthorClass("shl", " sahil yasin"));
                AutherListInfo.Add(new AuthorClass("sayed", " sayed ramadan"));
                AutherListInfo.Add(new AuthorClass("taher", "sherzad abd rahman"));
                AutherListInfo.Add(new AuthorClass("hkm", " sabar abd alhakam"));
                AutherListInfo.Add(new AuthorClass("sahood", " saleh alsahood"));
                AutherListInfo.Add(new AuthorClass("s_bud", "salah al badeer"));
                AutherListInfo.Add(new AuthorClass("salah_hashim_m", "salah alhashim"));
                AutherListInfo.Add(new AuthorClass("bu_khtr", "salah abo katar"));
                AutherListInfo.Add(new AuthorClass("tareq", "tarek abd alkane"));
                AutherListInfo.Add(new AuthorClass("a_klb", " adel alklabine"));
                AutherListInfo.Add(new AuthorClass("ryan", " adel rayan"));
                AutherListInfo.Add(new AuthorClass("thubti", "abd al barey"));
                AutherListInfo.Add(new AuthorClass("bari", "abd albarey mohammed"));
                AutherListInfo.Add(new AuthorClass("bari_molm", " abd albarey mohammed M"));
                AutherListInfo.Add(new AuthorClass("basit", "abd albasit abd samad H"));
                AutherListInfo.Add(new AuthorClass("basit_warsh", " abd albasit abd samad w"));
                AutherListInfo.Add(new AuthorClass("basit_mjwd", " abd albasit abd samad M"));
                AutherListInfo.Add(new AuthorClass("sds", " abd alrihman alsides"));
                AutherListInfo.Add(new AuthorClass("soufi_klf", " abd rashed sofe"));
                AutherListInfo.Add(new AuthorClass("soufi", "abd rashed sofe S"));
                AutherListInfo.Add(new AuthorClass("a_ahmed", "abd alaziz samad  "));
                AutherListInfo.Add(new AuthorClass("brmi", " abd alah barimey"));
                AutherListInfo.Add(new AuthorClass("Abdullahk", " abd alah kindry"));
                AutherListInfo.Add(new AuthorClass("mtrod", " abd alah matrood"));
                AutherListInfo.Add(new AuthorClass("bsfr", " abd alah basfar"));
                AutherListInfo.Add(new AuthorClass("kyat", " abd alah kayat"));
                AutherListInfo.Add(new AuthorClass("jhn", "abd alah awad"));
                AutherListInfo.Add(new AuthorClass("mohsin_harthi", " abd ahmmahsin alharithey"));
                AutherListInfo.Add(new AuthorClass("obk", " bd ahmmahsin alabekan"));
                AutherListInfo.Add(new AuthorClass("qasm", " bd ahmmahsin alkasim"));
                AutherListInfo.Add(new AuthorClass("kanakeri", " abd alhidey ahmed "));
                AutherListInfo.Add(new AuthorClass("wdod", " abd awadood"));
                AutherListInfo.Add(new AuthorClass("abo_hashim", " ali abo hasim"));
                AutherListInfo.Add(new AuthorClass("huthifi_qalon", " ali alhithefy"));
                AutherListInfo.Add(new AuthorClass("hthfi", " ali bin abd alrahman"));
                AutherListInfo.Add(new AuthorClass("a_jbr", " ali jabar"));
                AutherListInfo.Add(new AuthorClass("hajjaj", " ali hajaj "));
                AutherListInfo.Add(new AuthorClass("hafz", " amad zoheer"));
                AutherListInfo.Add(new AuthorClass("frs_a", " faaris abad"));
                AutherListInfo.Add(new AuthorClass("lafi", " lafey alawwney"));
                AutherListInfo.Add(new AuthorClass("zaml", " majad alzamel"));
                AutherListInfo.Add(new AuthorClass("shaibat", "malak shiba"));
                AutherListInfo.Add(new AuthorClass("maher_m", " maheer al maeekly"));
                AutherListInfo.Add(new AuthorClass("maher", " maheer al maeekly H"));
                AutherListInfo.Add(new AuthorClass("shaksh", " maheer shkasher"));
                AutherListInfo.Add(new AuthorClass("ayyub", " mohammed ayoob"));
                AutherListInfo.Add(new AuthorClass("braak", " mohammed barak"));
                AutherListInfo.Add(new AuthorClass("tblawi", " mohammed altablaye"));
                AutherListInfo.Add(new AuthorClass("mhsny", " mohammed almahsaney"));
                AutherListInfo.Add(new AuthorClass("monshed", "mohammed al minshid"));
                AutherListInfo.Add(new AuthorClass("jbrl", " mohamed jabril"));
                AutherListInfo.Add(new AuthorClass("rashad", " mohamed rashid "));
                AutherListInfo.Add(new AuthorClass("shah", " mohamed salih"));
                AutherListInfo.Add(new AuthorClass("minsh", " mohammed sadeek alminshawe"));
                AutherListInfo.Add(new AuthorClass("minsh_mjwd", "mohammed sadeek alminshawe M"));
                AutherListInfo.Add(new AuthorClass("abdullah_dori", " Mohamed abd alhakeem"));
                AutherListInfo.Add(new AuthorClass("khan", " mohammed athman kan"));
                AutherListInfo.Add(new AuthorClass("mrifai", " mahmood alrifaey"));
                AutherListInfo.Add(new AuthorClass("sheimy", " mahmmod alshimey"));
                AutherListInfo.Add(new AuthorClass("husr", " mahmood kaley"));
                AutherListInfo.Add(new AuthorClass("bna_mjwd", " mahmood ali"));
                AutherListInfo.Add(new AuthorClass("afs", " masharey alafasy"));
                AutherListInfo.Add(new AuthorClass("mustafa", " mostaa asmael"));
                AutherListInfo.Add(new AuthorClass("lahoni", " mostafa allahoney"));
                AutherListInfo.Add(new AuthorClass("ra3ad", " mostafa raeed"));
                AutherListInfo.Add(new AuthorClass("harthi", " maeeth alharithey"));
                AutherListInfo.Add(new AuthorClass("muftah_thakwan", " mafatf alsoltaney"));
                AutherListInfo.Add(new AuthorClass("bilal", "mosa balal"));
                AutherListInfo.Add(new AuthorClass("qtm", "nasar alkamatey"));
                AutherListInfo.Add(new AuthorClass("nabil", "nabeel alrafaeey"));
                AutherListInfo.Add(new AuthorClass("namh", "naama alhasan"));
                AutherListInfo.Add(new AuthorClass("hani", "haney alrafaey"));
                AutherListInfo.Add(new AuthorClass("waleed", " waleed alhaneha"));
                AutherListInfo.Add(new AuthorClass("yasser", " yasar dosary"));
                AutherListInfo.Add(new AuthorClass("qurashi", " yasar korashey"));
                AutherListInfo.Add(new AuthorClass("mzroyee", "yasar mazroey"));
                AutherListInfo.Add(new AuthorClass("yahya", " yahya hawa"));
                AutherListInfo.Add(new AuthorClass("yousef", " yoousif alshwaeey "));
                AutherListInfo.Add(new AuthorClass("noah", "yousfi bin nooh"));
            }

            return (AutherListInfo);

        }

        //get list of Aya
        public List<AuthorClass> GuranAya(String ReciteName)
        {

            List<AuthorClass> ListAya = new List<AuthorClass>();

            if (LanguageSelect == 1)
            {
                ListAya.Add(new AuthorClass("001", " الفاتحة"));
                ListAya.Add(new AuthorClass("002", "البقرة"));
                ListAya.Add(new AuthorClass("003", "ال عمران "));
                ListAya.Add(new AuthorClass("004", "النساء"));
                ListAya.Add(new AuthorClass("005", " المائدة"));
                ListAya.Add(new AuthorClass("006", " الانعام"));
                ListAya.Add(new AuthorClass("007", " الأعراف"));
                ListAya.Add(new AuthorClass("008", " الأنفال"));
                ListAya.Add(new AuthorClass("009", " التوبة "));
                ListAya.Add(new AuthorClass("010", " يونس"));
                ListAya.Add(new AuthorClass("011", " هود"));
                ListAya.Add(new AuthorClass("012", " يوسف"));
                ListAya.Add(new AuthorClass("013", " الرعد"));
                ListAya.Add(new AuthorClass("014", " إبراهيم"));
                ListAya.Add(new AuthorClass("015", " الحجر"));
                ListAya.Add(new AuthorClass("016", " النحل"));
                ListAya.Add(new AuthorClass("017", " الإسراء"));
                ListAya.Add(new AuthorClass("018", " الكهف"));
                ListAya.Add(new AuthorClass("019", " مريم"));
                ListAya.Add(new AuthorClass("020", " طه"));
                ListAya.Add(new AuthorClass("021", " الأنبياء"));
                ListAya.Add(new AuthorClass("022", " الحج"));
                ListAya.Add(new AuthorClass("023", " المؤمنون"));
                ListAya.Add(new AuthorClass("024", " النّور"));
                ListAya.Add(new AuthorClass("025", "  الفرقان "));
                ListAya.Add(new AuthorClass("026", "  الشعراء "));
                ListAya.Add(new AuthorClass("027", " النّمل"));
                ListAya.Add(new AuthorClass("028", " القصص"));
                ListAya.Add(new AuthorClass("029", " العنكبوت"));
                ListAya.Add(new AuthorClass("030", " الرّوم"));
                ListAya.Add(new AuthorClass("031", " لقمان"));
                ListAya.Add(new AuthorClass("032", " السجدة"));
                ListAya.Add(new AuthorClass("033", " الأحزاب"));
                ListAya.Add(new AuthorClass("034", " سبأ"));
                ListAya.Add(new AuthorClass("035", " فاطر"));
                ListAya.Add(new AuthorClass("036", " يس"));
                ListAya.Add(new AuthorClass("037", " الصافات"));
                ListAya.Add(new AuthorClass("038", " ص"));
                ListAya.Add(new AuthorClass("039", " الزمر"));
                ListAya.Add(new AuthorClass("040", " غافر"));
                ListAya.Add(new AuthorClass("041", " فصّلت"));
                ListAya.Add(new AuthorClass("042", " الشورى"));
                ListAya.Add(new AuthorClass("043", " الزخرف"));
                ListAya.Add(new AuthorClass("044", " الدّخان"));
                ListAya.Add(new AuthorClass("045", " الجاثية"));
                ListAya.Add(new AuthorClass("046", " الأحقاف"));
                ListAya.Add(new AuthorClass("047", " محمد"));
                ListAya.Add(new AuthorClass("048", " الفتح"));
                ListAya.Add(new AuthorClass("049", " الحجرات"));
                ListAya.Add(new AuthorClass("050", " ق"));
                ListAya.Add(new AuthorClass("051", " الذاريات"));
                ListAya.Add(new AuthorClass("052", " الطور"));
                ListAya.Add(new AuthorClass("053", " النجم"));
                ListAya.Add(new AuthorClass("054", " القمر"));
                ListAya.Add(new AuthorClass("055", " الرحمن"));
                ListAya.Add(new AuthorClass("056", " الواقعة"));
                ListAya.Add(new AuthorClass("057", " الحديد"));
                ListAya.Add(new AuthorClass("058", " المجادلة"));
                ListAya.Add(new AuthorClass("059", " الحشر"));
                ListAya.Add(new AuthorClass("060", " الممتحنة"));
                ListAya.Add(new AuthorClass("061", " الصف"));
                ListAya.Add(new AuthorClass("062", " الجمعة"));
                ListAya.Add(new AuthorClass("063", " المنافقون"));
                ListAya.Add(new AuthorClass("064", " التغابن"));
                ListAya.Add(new AuthorClass("065", " الطلاق"));
                ListAya.Add(new AuthorClass("066", " التحريم"));
                ListAya.Add(new AuthorClass("067", " الملك"));
                ListAya.Add(new AuthorClass("068", " القلم"));
                ListAya.Add(new AuthorClass("069", " الحاقة"));
                ListAya.Add(new AuthorClass("070", " المعارج"));
                ListAya.Add(new AuthorClass("071", " نوح"));
                ListAya.Add(new AuthorClass("072", " الجن"));
                ListAya.Add(new AuthorClass("073", " المزّمّل"));
                ListAya.Add(new AuthorClass("074", " المدّثر"));
                ListAya.Add(new AuthorClass("075", " القيامة"));
                ListAya.Add(new AuthorClass("076", " الإنسان"));
                ListAya.Add(new AuthorClass("077", " المرسلات"));
                ListAya.Add(new AuthorClass("078", " النبأ"));
                ListAya.Add(new AuthorClass("079", " النازعات"));
                ListAya.Add(new AuthorClass("080", " عبس"));
                ListAya.Add(new AuthorClass("081", " التكوير"));
                ListAya.Add(new AuthorClass("082", " الإنفطار"));
                ListAya.Add(new AuthorClass("083", " المطفّفين"));
                ListAya.Add(new AuthorClass("084", " الإنشقاق"));
                ListAya.Add(new AuthorClass("085", " البروج"));
                ListAya.Add(new AuthorClass("086", " الطارق"));
                ListAya.Add(new AuthorClass("087", " الأعلى"));
                ListAya.Add(new AuthorClass("088", " الغاشية"));
                ListAya.Add(new AuthorClass("089", " الفجر"));
                ListAya.Add(new AuthorClass("090", " البلد"));
                ListAya.Add(new AuthorClass("091", " الشمس"));
                ListAya.Add(new AuthorClass("092", " الليل"));
                ListAya.Add(new AuthorClass("093", " الضحى"));
                ListAya.Add(new AuthorClass("094", " الشرح"));
                ListAya.Add(new AuthorClass("095", " التين"));
                ListAya.Add(new AuthorClass("096", " العلق"));
                ListAya.Add(new AuthorClass("097", " القدر"));
                ListAya.Add(new AuthorClass("098", " البينة"));
                ListAya.Add(new AuthorClass("099", " الزلزلة"));
                ListAya.Add(new AuthorClass("100", " العاديات"));
                ListAya.Add(new AuthorClass("101", " القارعة"));
                ListAya.Add(new AuthorClass("102", " التكاثر"));
                ListAya.Add(new AuthorClass("103", " العصر"));
                ListAya.Add(new AuthorClass("104", " الهمزة"));
                ListAya.Add(new AuthorClass("105", " الفيل"));
                ListAya.Add(new AuthorClass("106", " قريش"));
                ListAya.Add(new AuthorClass("107", " الماعون"));
                ListAya.Add(new AuthorClass("108", " الكوثر"));
                ListAya.Add(new AuthorClass("109", " الكافرون"));
                ListAya.Add(new AuthorClass("110", " النصر"));
                ListAya.Add(new AuthorClass("111", " المسد"));
                ListAya.Add(new AuthorClass("112", " الإخلاص"));
                ListAya.Add(new AuthorClass("113", " الفلق"));
                ListAya.Add(new AuthorClass("114", " النّاس"));
            }
            else
            {
                //english aya
                ListAya.Add(new AuthorClass("001", "Al-Fatihah "));
                ListAya.Add(new AuthorClass("002", "Al-Baqarah "));
                ListAya.Add(new AuthorClass("003", "Al-'Imran "));
                ListAya.Add(new AuthorClass("004", "An-Nisa' "));
                ListAya.Add(new AuthorClass("005", "Al-Ma'idah "));
                ListAya.Add(new AuthorClass("006", "Al-An'am "));
                ListAya.Add(new AuthorClass("007", "Al-A'raf "));
                ListAya.Add(new AuthorClass("008", "Al-Anfal "));
                ListAya.Add(new AuthorClass("009", "Al-Bara'at  "));
                ListAya.Add(new AuthorClass("010", "Yunus  "));
                ListAya.Add(new AuthorClass("011", " Hud(Hud)"));
                ListAya.Add(new AuthorClass("012", " Yusuf "));
                ListAya.Add(new AuthorClass("013", "Ar - Ra'd  "));
                ListAya.Add(new AuthorClass("014", "Ibrahim "));
                ListAya.Add(new AuthorClass("015", " Al - Hijr "));
                ListAya.Add(new AuthorClass("016", " An - Nahl "));
                ListAya.Add(new AuthorClass("017", " Bani Isra'il "));
                ListAya.Add(new AuthorClass("018", " Al-Kahf  "));
                ListAya.Add(new AuthorClass("019", "Maryam "));
                ListAya.Add(new AuthorClass("020", "Ta Ha  "));
                ListAya.Add(new AuthorClass("021", "Al-Anbiya' "));
                ListAya.Add(new AuthorClass("022", "Al-Hajj "));
                ListAya.Add(new AuthorClass("023", "Al-Mu'minun "));
                ListAya.Add(new AuthorClass("024", "An-Nur "));
                ListAya.Add(new AuthorClass("025", "Al-Furqan "));
                ListAya.Add(new AuthorClass("026", "Ash-Shu'ara' "));
                ListAya.Add(new AuthorClass("027", "An-Naml "));
                ListAya.Add(new AuthorClass("028", "Al-Qasas "));
                ListAya.Add(new AuthorClass("029", "Al-'Ankabut "));
                ListAya.Add(new AuthorClass("030", "Ar-Rum "));
                ListAya.Add(new AuthorClass("031", "Luqman "));
                ListAya.Add(new AuthorClass("032", "As-Sajdah "));
                ListAya.Add(new AuthorClass("033", "Al-Ahzab "));
                ListAya.Add(new AuthorClass("034", "Al-Saba'  "));
                ListAya.Add(new AuthorClass("035", "Al-Fatir "));
                ListAya.Add(new AuthorClass("036", "Ya Sin "));
                ListAya.Add(new AuthorClass("037", "As-Saffat"));
                ListAya.Add(new AuthorClass("038", "Sad "));
                ListAya.Add(new AuthorClass("039", "Az-Zumar "));
                ListAya.Add(new AuthorClass("040", "Al-Mu'min "));
                ListAya.Add(new AuthorClass("041", "Ha Mim "));
                ListAya.Add(new AuthorClass("042", "Ash-Shura "));
                ListAya.Add(new AuthorClass("043", "Az-Zukhruf "));
                ListAya.Add(new AuthorClass("044", "Ad-Dukhan "));
                ListAya.Add(new AuthorClass("045", "Al-Jathiyah  "));
                ListAya.Add(new AuthorClass("046", "Al-Ahqaf "));
                ListAya.Add(new AuthorClass("047", "Muhammad "));
                ListAya.Add(new AuthorClass("048", "Al-Fath "));
                ListAya.Add(new AuthorClass("049", "Al-Hujurat "));
                ListAya.Add(new AuthorClass("050", "Qaf  "));
                ListAya.Add(new AuthorClass("051", "Ad-Dhariyat "));
                ListAya.Add(new AuthorClass("052", "At-Tur "));
                ListAya.Add(new AuthorClass("053", "An-Najm "));
                ListAya.Add(new AuthorClass("054", "Al-Qamar "));
                ListAya.Add(new AuthorClass("055", "Ar-Rahman "));
                ListAya.Add(new AuthorClass("056", "Al-Waqi'ah "));
                ListAya.Add(new AuthorClass("057", "Al-Hadid "));
                ListAya.Add(new AuthorClass("058", "Al-Mujadilah "));
                ListAya.Add(new AuthorClass("059", "Al-Hashr "));
                ListAya.Add(new AuthorClass("060", "Al-Mumtahanah "));
                ListAya.Add(new AuthorClass("061", "As-Saff "));
                ListAya.Add(new AuthorClass("062", "Al-Jumu'ah "));
                ListAya.Add(new AuthorClass("063", "Al-Munafiqun "));
                ListAya.Add(new AuthorClass("064", "At-Taghabun "));
                ListAya.Add(new AuthorClass("065", "At-Talaq "));
                ListAya.Add(new AuthorClass("066", "At-Tahrim "));
                ListAya.Add(new AuthorClass("067", "Al-Mulk "));
                ListAya.Add(new AuthorClass("068", "Al-Qalam "));
                ListAya.Add(new AuthorClass("069", "Al-Haqqah "));
                ListAya.Add(new AuthorClass("070", "Al-Ma'arij "));
                ListAya.Add(new AuthorClass("071", "Nuh  "));
                ListAya.Add(new AuthorClass("072", "Al-Jinn "));
                ListAya.Add(new AuthorClass("073", "Al-Muzzammil "));
                ListAya.Add(new AuthorClass("074", "Al-Muddaththir "));
                ListAya.Add(new AuthorClass("075", "Al-Qiyamah "));
                ListAya.Add(new AuthorClass("076", "Al-Insan "));
                ListAya.Add(new AuthorClass("077", "Al-Mursalat "));
                ListAya.Add(new AuthorClass("078", "An-Naba'  "));
                ListAya.Add(new AuthorClass("079", "An-Nazi'at "));
                ListAya.Add(new AuthorClass("080", "'Abasa  "));
                ListAya.Add(new AuthorClass("081", "At-Takwir "));
                ListAya.Add(new AuthorClass("082", "Al-Infitar "));
                ListAya.Add(new AuthorClass("083", "At-Tatfif "));
                ListAya.Add(new AuthorClass("084", "Al-Inshiqaq "));
                ListAya.Add(new AuthorClass("085", "Al-Buruj "));
                ListAya.Add(new AuthorClass("086", "At-Tariq "));
                ListAya.Add(new AuthorClass("087", "Al-A'la "));
                ListAya.Add(new AuthorClass("088", "Al-Ghashiyah "));
                ListAya.Add(new AuthorClass("089", "Al-Fajr "));
                ListAya.Add(new AuthorClass("090", "Al-Balad "));
                ListAya.Add(new AuthorClass("091", "Ash-Shams "));
                ListAya.Add(new AuthorClass("092", "Al-Lail "));
                ListAya.Add(new AuthorClass("093", "Ad-Duha "));
                ListAya.Add(new AuthorClass("094", "Al-Inshirah "));
                ListAya.Add(new AuthorClass("095", "At-Tin "));
                ListAya.Add(new AuthorClass("096", "Al-'Alaq  "));
                ListAya.Add(new AuthorClass("097", " Al-Qadr "));
                ListAya.Add(new AuthorClass("098", " Al-Bayyinah "));
                ListAya.Add(new AuthorClass("099", " Al-Zilzal  "));
                ListAya.Add(new AuthorClass("100", " Al-'Adiyat "));
                ListAya.Add(new AuthorClass("101", " Al-Qari'ah "));
                ListAya.Add(new AuthorClass("102", "At-Takathur "));
                ListAya.Add(new AuthorClass("103", "Al-'Asr "));
                ListAya.Add(new AuthorClass("104", "Al-Humazah "));
                ListAya.Add(new AuthorClass("105", "Al-Fil "));
                ListAya.Add(new AuthorClass("106", "Al-Quraish "));
                ListAya.Add(new AuthorClass("107", "Al-Ma'un  "));
                ListAya.Add(new AuthorClass("108", "Al-Kauthar "));
                ListAya.Add(new AuthorClass("109", "Al-Kafirun "));
                ListAya.Add(new AuthorClass("110", "An-Nasr "));
                ListAya.Add(new AuthorClass("111", " Al-Lahab "));
                ListAya.Add(new AuthorClass("112", " Al-Ikhlas "));
                ListAya.Add(new AuthorClass("113", "Al-Falaq "));
                ListAya.Add(new AuthorClass("114", " An-Nas  "));
            }


            ListBeginEndAya ListRange = new ListBeginEndAya();
            ListRange = autherRanageDetermine(ReciteName);
            List<AuthorClass> ListAyaRanage = new List<AuthorClass>();
            //IsolatedStorageFile isoStore = IsolatedStorageFile.GetUserStoreForApplication();
            String AYAPAth;

            for (int i = ListRange.beginR; i < ListRange.endread; i++)
            {
                try
                {


                    AuthorClass ac = new AuthorClass();
                    ac = ListAya[i];

                    AYAPAth = "http://server" + serverNumber(ReciteName) + ".mp3quran.net/" + ReciteName + "/" + ac.ServerName + ".mp3";
                    ListAyaRanage.Add(new AuthorClass(ac.ServerName, ac.RealName, " ", AYAPAth));

                }
                catch (Exception ex) { }


            }
            return (ListAyaRanage);
        }

        //operation doing in backend to bring pure links for aya
        #region Server Managment 
        public String serverNumber(String EnglishName)
        {
            String ArabicName = "11";
            if (EnglishName.Contains("shatri"))
                ArabicName = "11";
            if (EnglishName.Contains("ahmad_huth"))
                ArabicName = "8";
            if (EnglishName.Contains("hawashi"))
                ArabicName = "11";
            if (EnglishName.Contains("trabulsi"))
                ArabicName = "10";
            if (EnglishName.Contains("ajm"))
                ArabicName = "10";
            if (EnglishName.Contains("trablsi"))
                ArabicName = "10";
            if (EnglishName.Contains("saud"))
                ArabicName = "11";
            if (EnglishName.Contains("saber"))
                ArabicName = "8";
            if (EnglishName.Contains("Aamer"))
                ArabicName = "10";
            if (EnglishName.Contains("ahmad_nu"))
                ArabicName = "11";
            if (EnglishName.Contains("akil"))
                ArabicName = "12";
            if (EnglishName.Contains("akrm"))
                ArabicName = "9";
            if (EnglishName.Contains("akdr"))
                ArabicName = "6";
            if (EnglishName.Contains("IbrahemSadan"))
                ArabicName = "10";
            if (EnglishName.Contains("abkr"))
                ArabicName = "6";
            if (EnglishName.Contains("jbreen"))
                ArabicName = "6";
            if (EnglishName.Contains("jormy"))
                ArabicName = "11";
            if (EnglishName.Contains("ibrahim_dosri_warsh"))
                ArabicName = "10";
            if (EnglishName.Contains("3siri"))
                ArabicName = "6";
            if (EnglishName.Contains("zamri"))
                ArabicName = "12";
            if (EnglishName.Contains("3zazi"))
                ArabicName = "8";
            if (EnglishName.Contains("dokali"))
                ArabicName = "7";
            if (EnglishName.Contains("alzain"))
                ArabicName = "9";
            if (EnglishName.Contains("omran"))
                ArabicName = "9";
            if (EnglishName.Contains("koshi"))
                ArabicName = "11";
            if (EnglishName.Contains("fateh"))
                ArabicName = "6";
            if (EnglishName.Contains("qari"))
                ArabicName = "11";
            if (EnglishName.Contains("twfeeq"))
                ArabicName = "6";
            if (EnglishName.Contains("jamal"))
                ArabicName = "6";
            if (EnglishName.Contains("jaman"))
                ArabicName = "6";
            if (EnglishName.Contains("hatem"))
                ArabicName = "11";
            if (EnglishName.Contains("qht"))
                ArabicName = "10";
            if (EnglishName.Contains("mohna"))
                ArabicName = "11";
            if (EnglishName.Contains("kafi"))
                ArabicName = "11";
            if (EnglishName.Contains("tnjy"))
                ArabicName = "12";
            if (EnglishName.Contains("hamza"))
                ArabicName = "9";
            if (EnglishName.Contains("ifrad"))
                ArabicName = "12";
            if (EnglishName.Contains("zaki"))
                ArabicName = "9";
            if (EnglishName.Contains("sami_dosr"))
                ArabicName = "8";
            if (EnglishName.Contains("s_gmd"))
                ArabicName = "7";
            if (EnglishName.Contains("shur"))
                ArabicName = "7";
            if (EnglishName.Contains("shl"))
                ArabicName = "6";
            if (EnglishName.Contains("sayed"))
                ArabicName = "12";
            if (EnglishName.Contains("taher"))
                ArabicName = "12";
            if (EnglishName.Contains("hkm"))
                ArabicName = "12";
            if (EnglishName.Contains("sahood"))
                ArabicName = "8";
            if (EnglishName.Contains("s_bud"))
                ArabicName = "6";
            if (EnglishName.Contains("salah_hashim_m"))
                ArabicName = "12";
            if (EnglishName.Contains("bu_khtr"))
                ArabicName = "8";
            if (EnglishName.Contains("tareq"))
                ArabicName = "10";
            if (EnglishName.Contains("a_klb"))
                ArabicName = "8";
            if (EnglishName.Contains("ryan"))
                ArabicName = "8";
            if (EnglishName.Contains("thubti"))
                ArabicName = "6";
            if (EnglishName.Contains("bari"))
                ArabicName = "12";
            if (EnglishName.Contains("bari_molm"))
                ArabicName = "10";
            if (EnglishName.Contains("basit"))
                ArabicName = "7";
            if (EnglishName.Contains("basit_warsh"))
                ArabicName = "10";
            if (EnglishName.Contains("basit_mjwd"))
                ArabicName = "13";
            if (EnglishName.Contains("sds"))
                ArabicName = "11";
            if (EnglishName.Contains("soufi_klf"))
                ArabicName = "9";
            if (EnglishName.Contains("soufi"))
                ArabicName = "9";
            if (EnglishName.Contains("a_ahmed"))
                ArabicName = "11";
            if (EnglishName.Contains("brmi"))
                ArabicName = "8";
            if (EnglishName.Contains("Abdullahk"))
                ArabicName = "10";
            if (EnglishName.Contains("mtrod"))
                ArabicName = "8";
            if (EnglishName.Contains("bsfr"))
                ArabicName = "6";
            if (EnglishName.Contains("kyat"))
                ArabicName = "12";
            if (EnglishName.Contains("jhn"))
                ArabicName = "13";
            if (EnglishName.Contains("mohsin_harthi"))
                ArabicName = "6";
            if (EnglishName.Contains("obk"))
                ArabicName = "12";
            if (EnglishName.Contains("qasm"))
                ArabicName = "8";
            if (EnglishName.Contains("kanakeri"))
                ArabicName = "6";
            if (EnglishName.Contains("wdod"))
                ArabicName = "8";
            if (EnglishName.Contains("abo_hashim"))
                ArabicName = "9";
            if (EnglishName.Contains("huthifi_qalon"))
                ArabicName = "9";
            if (EnglishName.Contains("hthfi"))
                ArabicName = "9";
            if (EnglishName.Contains("a_jbr"))
                ArabicName = "11";
            if (EnglishName.Contains("hajjaj"))
                ArabicName = "9";
            if (EnglishName.Contains("hafz"))
                ArabicName = "6";
            if (EnglishName.Contains("frs_a"))
                ArabicName = "8";
            if (EnglishName.Contains("lafi"))
                ArabicName = "6";
            if (EnglishName.Contains("zaml"))
                ArabicName = "9";
            if (EnglishName.Contains("shaibat"))
                ArabicName = "9";
            if (EnglishName.Contains("maher_m"))
                ArabicName = "12";
            if (EnglishName.Contains("maher"))
                ArabicName = "12";
            if (EnglishName.Contains("shaksh"))
                ArabicName = "10";
            if (EnglishName.Contains("ayyub"))
                ArabicName = "8";
            if (EnglishName.Contains("braak"))
                ArabicName = "13";
            if (EnglishName.Contains("tblawi"))
                ArabicName = "12";
            if (EnglishName.Contains("mhsny"))
                ArabicName = "11";
            if (EnglishName.Contains("monshed"))
                ArabicName = "10";
            if (EnglishName.Contains("jbrl"))
                ArabicName = "8";
            if (EnglishName.Contains("rashad"))
                ArabicName = "10";
            if (EnglishName.Contains("shah"))
                ArabicName = "12";
            if (EnglishName.Contains("minsh"))
                ArabicName = "10";
            if (EnglishName.Contains("minsh_mjwd"))
                ArabicName = "11";
            if (EnglishName.Contains("abdullah_dori"))
                ArabicName = "12";
            if (EnglishName.Contains("khan"))
                ArabicName = "6";
            if (EnglishName.Contains("mrifai"))
                ArabicName = "11";
            if (EnglishName.Contains("sheimy"))
                ArabicName = "10";
            if (EnglishName.Contains("husr"))
                ArabicName = "13";
            if (EnglishName.Contains("bna_mjwd"))
                ArabicName = "8";
            if (EnglishName.Contains("afs"))
                ArabicName = "8";
            if (EnglishName.Contains("mustafa"))
                ArabicName = "8";
            if (EnglishName.Contains("lahoni"))
                ArabicName = "6";
            if (EnglishName.Contains("ra3ad"))
                ArabicName = "8";
            if (EnglishName.Contains("harthi"))
                ArabicName = "8";
            if (EnglishName.Contains("muftah_thakwan"))
                ArabicName = "11";
            if (EnglishName.Contains("bilal"))
                ArabicName = "11";
            if (EnglishName.Contains("qtm"))
                ArabicName = "6";
            if (EnglishName.Contains("nabil"))
                ArabicName = "9";
            if (EnglishName.Contains("namh"))
                ArabicName = "8";
            if (EnglishName.Contains("hani"))
                ArabicName = "8";
            if (EnglishName.Contains("waleed"))
                ArabicName = "9";
            if (EnglishName.Contains("yasser"))
                ArabicName = "11";
            if (EnglishName.Contains("qurashi"))
                ArabicName = "9";
            if (EnglishName.Contains("mzroyee"))
                ArabicName = "9";
            if (EnglishName.Contains("yahya"))
                ArabicName = "12";
            if (EnglishName.Contains("yousef"))
                ArabicName = "9";
            if (EnglishName.Contains("noah"))
                ArabicName = "8";
            if (EnglishName.Contains("shatri"))
                ArabicName = "11";
            if (EnglishName.Contains("ahmad_huth"))
                ArabicName = "8";
            if (EnglishName.Contains("hawashi"))
                ArabicName = "11";
            if (EnglishName.Contains("trabulsi"))
                ArabicName = "10";
            if (EnglishName.Contains("ajm"))
                ArabicName = "10";
            if (EnglishName.Contains("trablsi"))
                ArabicName = "10";
            if (EnglishName.Contains("saud"))
                ArabicName = "11";
            if (EnglishName.Contains("saber"))
                ArabicName = "8";
            if (EnglishName.Contains("Aamer"))
                ArabicName = "10";
            if (EnglishName.Contains("ahmad_nu"))
                ArabicName = "11";
            if (EnglishName.Contains("akil"))
                ArabicName = "12";
            if (EnglishName.Contains("akrm"))
                ArabicName = "9";
            if (EnglishName.Contains("akdr"))
                ArabicName = "6";
            if (EnglishName.Contains("IbrahemSadan"))
                ArabicName = "10";
            if (EnglishName.Contains("abkr"))
                ArabicName = "6";
            if (EnglishName.Contains("jbreen"))
                ArabicName = "6";
            if (EnglishName.Contains("jormy"))
                ArabicName = "11";
            if (EnglishName.Contains("ibrahim_dosri_warsh"))
                ArabicName = "10";
            if (EnglishName.Contains("3siri"))
                ArabicName = "6";
            if (EnglishName.Contains("zamri"))
                ArabicName = "12";
            if (EnglishName.Contains("3zazi"))
                ArabicName = "8";
            if (EnglishName.Contains("dokali"))
                ArabicName = "7";
            if (EnglishName.Contains("alzain"))
                ArabicName = "9";
            if (EnglishName.Contains("omran"))
                ArabicName = "9";
            if (EnglishName.Contains("koshi"))
                ArabicName = "11";
            if (EnglishName.Contains("fateh"))
                ArabicName = "6";
            if (EnglishName.Contains("qari"))
                ArabicName = "11";
            if (EnglishName.Contains("twfeeq"))
                ArabicName = "6";
            if (EnglishName.Contains("jamal"))
                ArabicName = "6";
            if (EnglishName.Contains("jaman"))
                ArabicName = "6";
            if (EnglishName.Contains("hatem"))
                ArabicName = "11";
            if (EnglishName.Contains("qht"))
                ArabicName = "10";
            if (EnglishName.Contains("mohna"))
                ArabicName = "11";
            if (EnglishName.Contains("kafi"))
                ArabicName = "11";
            if (EnglishName.Contains("tnjy"))
                ArabicName = "12";
            if (EnglishName.Contains("hamza"))
                ArabicName = "9";
            if (EnglishName.Contains("ifrad"))
                ArabicName = "12";
            if (EnglishName.Contains("zaki"))
                ArabicName = "9";
            if (EnglishName.Contains("sami_dosr"))
                ArabicName = "8";
            if (EnglishName.Contains("s_gmd"))
                ArabicName = "7";
            if (EnglishName.Contains("shur"))
                ArabicName = "7";
            if (EnglishName.Contains("shl"))
                ArabicName = "6";
            if (EnglishName.Contains("sayed"))
                ArabicName = "12";
            if (EnglishName.Contains("taher"))
                ArabicName = "12";
            if (EnglishName.Contains("hkm"))
                ArabicName = "12";
            if (EnglishName.Contains("sahood"))
                ArabicName = "8";
            if (EnglishName.Contains("s_bud"))
                ArabicName = "6";
            if (EnglishName.Contains("salah_hashim_m"))
                ArabicName = "12";
            if (EnglishName.Contains("bu_khtr"))
                ArabicName = "8";
            if (EnglishName.Contains("tareq"))
                ArabicName = "10";
            if (EnglishName.Contains("a_klb"))
                ArabicName = "8";
            if (EnglishName.Contains("ryan"))
                ArabicName = "8";
            if (EnglishName.Contains("thubti"))
                ArabicName = "6";
            if (EnglishName.Contains("bari"))
                ArabicName = "12";
            if (EnglishName.Contains("bari_molm"))
                ArabicName = "10";
            if (EnglishName.Contains("basit"))
                ArabicName = "7";
            if (EnglishName.Contains("basit_warsh"))
                ArabicName = "10";
            if (EnglishName.Contains("basit_mjwd"))
                ArabicName = "13";
            if (EnglishName.Contains("sds"))
                ArabicName = "11";
            if (EnglishName.Contains("soufi_klf"))
                ArabicName = "9";
            if (EnglishName.Contains("soufi"))
                ArabicName = "9";
            if (EnglishName.Contains("a_ahmed"))
                ArabicName = "11";
            if (EnglishName.Contains("brmi"))
                ArabicName = "8";
            if (EnglishName.Contains("Abdullahk"))
                ArabicName = "10";
            if (EnglishName.Contains("mtrod"))
                ArabicName = "8";
            if (EnglishName.Contains("bsfr"))
                ArabicName = "6";
            if (EnglishName.Contains("kyat"))
                ArabicName = "12";
            if (EnglishName.Contains("jhn"))
                ArabicName = "13";
            if (EnglishName.Contains("mohsin_harthi"))
                ArabicName = "6";
            if (EnglishName.Contains("obk"))
                ArabicName = "12";
            if (EnglishName.Contains("qasm"))
                ArabicName = "8";
            if (EnglishName.Contains("kanakeri"))
                ArabicName = "6";
            if (EnglishName.Contains("wdod"))
                ArabicName = "8";
            if (EnglishName.Contains("abo_hashim"))
                ArabicName = "9";
            if (EnglishName.Contains("huthifi_qalon"))
                ArabicName = "9";
            if (EnglishName.Contains("hthfi"))
                ArabicName = "9";
            if (EnglishName.Contains("a_jbr"))
                ArabicName = "11";
            if (EnglishName.Contains("hajjaj"))
                ArabicName = "9";
            if (EnglishName.Contains("hafz"))
                ArabicName = "6";
            if (EnglishName.Contains("frs_a"))
                ArabicName = "8";
            if (EnglishName.Contains("lafi"))
                ArabicName = "6";
            if (EnglishName.Contains("zaml"))
                ArabicName = "9";
            if (EnglishName.Contains("shaibat"))
                ArabicName = "9";
            if (EnglishName.Contains("maher_m"))
                ArabicName = "12";
            if (EnglishName.Contains("maher"))
                ArabicName = "12";
            if (EnglishName.Contains("shaksh"))
                ArabicName = "10";
            if (EnglishName.Contains("ayyub"))
                ArabicName = "8";
            if (EnglishName.Contains("braak"))
                ArabicName = "13";
            if (EnglishName.Contains("tblawi"))
                ArabicName = "12";
            if (EnglishName.Contains("mhsny"))
                ArabicName = "11";
            if (EnglishName.Contains("monshed"))
                ArabicName = "10";
            if (EnglishName.Contains("jbrl"))
                ArabicName = "8";
            if (EnglishName.Contains("rashad"))
                ArabicName = "10";
            if (EnglishName.Contains("shah"))
                ArabicName = "12";
            if (EnglishName.Contains("minsh"))
                ArabicName = "10";
            if (EnglishName.Contains("minsh_mjwd"))
                ArabicName = "11";
            if (EnglishName.Contains("abdullah_dori"))
                ArabicName = "12";
            if (EnglishName.Contains("khan"))
                ArabicName = "6";
            if (EnglishName.Contains("mrifai"))
                ArabicName = "11";
            if (EnglishName.Contains("sheimy"))
                ArabicName = "10";
            if (EnglishName.Contains("husr"))
                ArabicName = "13";
            if (EnglishName.Contains("bna_mjwd"))
                ArabicName = "8";
            if (EnglishName.Contains("afs"))
                ArabicName = "8";
            if (EnglishName.Contains("mustafa"))
                ArabicName = "8";
            if (EnglishName.Contains("lahoni"))
                ArabicName = "6";
            if (EnglishName.Contains("ra3ad"))
                ArabicName = "8";
            if (EnglishName.Contains("harthi"))
                ArabicName = "8";
            if (EnglishName.Contains("muftah_thakwan"))
                ArabicName = "11";
            if (EnglishName.Contains("bilal"))
                ArabicName = "11";
            if (EnglishName.Contains("qtm"))
                ArabicName = "6";
            if (EnglishName.Contains("nabil"))
                ArabicName = "9";
            if (EnglishName.Contains("namh"))
                ArabicName = "8";
            if (EnglishName.Contains("hani"))
                ArabicName = "8";
            if (EnglishName.Contains("waleed"))
                ArabicName = "9";
            if (EnglishName.Contains("yasser"))
                ArabicName = "11";
            if (EnglishName.Contains("qurashi"))
                ArabicName = "9";
            if (EnglishName.Contains("mzroyee"))
                ArabicName = "9";
            if (EnglishName.Contains("yahya"))
                ArabicName = "12";
            if (EnglishName.Contains("yousef"))
                ArabicName = "9";
            if (EnglishName.Contains("noah"))
                ArabicName = "8";
            return ArabicName;


        }

        public static ListBeginEndAya autherRanageDetermine(String EnglishName)
        {
            ListBeginEndAya authLengther = new ListBeginEndAya();

            authLengther.beginR = 0;
            authLengther.endread = 114;
            if (EnglishName.Length == 0)
            {
                authLengther.beginR = 0;
                authLengther.endread = 114;
            }
            else if (EnglishName.Contains("saud"))
            {
                authLengther.beginR = 84;
                authLengther.endread = 114;
            }

            else if (EnglishName.Contains("akil"))
            {
                authLengther.beginR = 49;
                authLengther.endread = 56;
            }

            else if (EnglishName.Contains("IbrahemSadan"))
            {
                authLengther.beginR = 0;
                authLengther.endread = 20;
            }

            else if (EnglishName.Contains("jbreen"))
            {
                authLengther.beginR = 18;
                authLengther.endread = 114;
            }
            else if (EnglishName.Contains("jormy"))
            {
                authLengther.beginR = 39;
                authLengther.endread = 41;
            }

            else if (EnglishName.Contains("3siri"))
            {
                authLengther.beginR = 0;
                authLengther.endread = 75;
            }
            else if (EnglishName.Contains("zamri"))
            {
                authLengther.beginR = 2;
                authLengther.endread = 76;
            }
            else if (EnglishName.Contains("3zazi"))
            {
                authLengther.beginR = 57;
                authLengther.endread = 114;
            }

            else if (EnglishName.Contains("hamza"))
            {
                authLengther.beginR = 1;
                authLengther.endread = 114;

            }
            else if (EnglishName.Contains("sami_dosr"))
            {
                authLengther.beginR = 28;
                authLengther.endread = 114;

            }
            else if (EnglishName.Contains("brmi"))
            {
                authLengther.beginR = 48;
                authLengther.endread = 114;

            }
            else if (EnglishName.Contains("abo_hashim"))
            {
                authLengther.beginR = 49;
                authLengther.endread = 58;

            }
            else if (EnglishName.Contains("lafi"))
            {
                authLengther.beginR = 29;
                authLengther.endread = 114;

            }
            else if (EnglishName.Contains("zaml"))
            {
                authLengther.beginR = 12;
                authLengther.endread = 114;

            }
            else if (EnglishName.Contains("shaibat"))
            {
                authLengther.beginR = 77;
                authLengther.endread = 114;

            }
            else if (EnglishName.Contains("braak"))
            {
                authLengther.beginR = 49;
                authLengther.endread = 114;

            }


            else if (EnglishName.Contains("maher_m"))
            {
                authLengther.beginR = 77;
                authLengther.endread = 114;

            }
            return authLengther;


        }

        public class ListBeginEndAya
        {
            public int beginR;
            public int endread;
        }
        #endregion
    }
}