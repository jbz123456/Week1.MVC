using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Huiyi
    {
        public int Id { get; set; }
        public string HuiyiNei { get; set; }
        public DateTime StartTime { get; set; }
        public string ATime
        {
            get
            {
                return StartTime.ToString("yyyy-MM-dd");
            }
        }
        public int AId { get; set; }
        public int CId { get; set; }
        public string BeiZhu { get; set; }
        public int Shipin { get; set; }
        public string AShipin
        {
            get
            {
                if (Shipin == 1)
                {
                    return "需要";
                }
                else
                {
                    return "不需要";
                }
            }
        }
        public string Preple { get; set; }
        public string Address { get; set; }
        public string HuiyiName { get; set; }
    }
}
