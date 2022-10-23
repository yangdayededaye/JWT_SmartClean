using JWT_SmartClean;
using JWT_SmartClean.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VM.Core;

namespace JWT_SmartClean
{
    public class SoftConfig
    {
        public static string _SoftName = "智能清洗V1.0";

        public static JWT_SmartCleanEntities db = new JWT_SmartCleanEntities();

        public static int CabNo = int.Parse(ConfigurationManager.AppSettings["CabNo"].ToString());
        public static UserCls user = new UserCls("000", "admin");
        
        //调试模式
        public static bool IsDebug = ConfigurationManager.AppSettings["IsDebug"].ToString() == "1" ? true : false;

        public static Dictionary<int, string> _WarnMap = new Dictionary<int, string>();

        public static List<VmProcedure> processList = null;//流程
        //工件信息集合
        public static List<WorkPiece> lstWorkPiece = new List<WorkPiece>();

    }
}
