
namespace PPTVideo
{
    public class global
    {
        public static bool bProgramBar = true;

        public static FormLogin fl = new FormLogin();

        public static FormInit fi = new FormInit();

        public static bool bOpenFunctions = false;

        public static bool bRunProress = true;

        public static string strLoginUser = "";

        public static string strOneWav = "";
        public static string strTwoWav = "";
        public static string strThreeWav = "";
        public static string strFourWav = "";
        public static string strFiveWav = "";
        public static string strSixWav = "";
        public static string strSevenWav = "";
        public static string strEightWav = "";
        public static string strNineWav = "";
        public static string strTenWav = "";


        //Hui
        /////////////////////////////////////////////////////////////////////
        //是否脸部增强
        public static bool m_enhancer = false;
        //脸部表达强度
        public static double m_expression_scale = 1.0;
        //选择的声音模型的索引
        public static string m_index = "0";
        //是否上传了数字人形象
        public static bool numberPersonConfig = true;
        //是否上传了VITS模型
        public static bool vitsConfig = true;
        //训练模型的名字
        public static string modelName = "";
        //是否进行生成视频配置
        public static bool videoConfig = false;

        //1 ： 数字人没有动作
        //2 ： 数字人有动作
        public static int digitalMotion = 1;

        //插入数字人的选项
        //  1 ： 全部都插入
        //  2 ： 全部都没有插入
        //  3 ： 部分插入
        public static int intoDigitalOperation = 1;

        //是否选择了使用模型使用
        public static bool useModelAudio = false;

        /////////////////////////////////////////////////////////////////////


    }
}
