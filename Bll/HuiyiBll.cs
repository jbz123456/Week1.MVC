using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Model;

namespace Bll
{
    public class HuiyiBll
    {
        HuiyiDal dal = new HuiyiDal();
        public List<Huiyi> huiyis()
        {
            return dal.huiyis();
        }
        public List<Didian> didians()
        {
            return dal.didians();
        }
        public List<Canhuizhe> canhuizhes()
        {
            return dal.canhuizhes();
        }
        public int Add(Huiyi h)
        {
            return dal.Add(h);
        }
    }
}
