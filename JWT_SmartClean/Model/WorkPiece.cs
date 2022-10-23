using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWT_SmartClean.Model
{
    public class WorkPiece
    {
        public int Index { get; set; }
        public EWorkPieceType Type { get; set; }
        public bool IsExist { get; set; }
        public string Ocr { get; set; }
        public string BarCode { get; set; }
        //吸嘴
        public string MouseResult { get; set; }
        //划痕
        public string ReflectBoardResult { get; set; }
    }

    public enum EWorkPieceType
    {
        small=0,
        big=1,
        superbig=2
    }

}
