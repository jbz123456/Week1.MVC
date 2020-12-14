using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Dal
{
    public class HuiyiDal
    {
        //显示
        public List<Huiyi> huiyis()
        {
            try
            {
                string sql = "select * from Huiyi A inner join Didian b on a.AId=b.AId inner join Canhuizhe c on A.CId = c.CId";
                return DbHelper.GetList<Huiyi>(sql);
            }
            catch (Exception)
            {

                throw;
            }

        }
        //地点下拉
        public List<Didian> didians()
        {
            try
            {
                string sql = "select * from Didian";
                return DbHelper.GetList<Didian>(sql);
            }
            catch (Exception)
            {

                throw;
            }

        }
        //参会人下拉
        public List<Canhuizhe> canhuizhes()
        {
            try
            {
                string sql = "select * from Canhuizhe";
                return DbHelper.GetList<Canhuizhe>(sql);
            }
            catch (Exception)
            {

                throw;
            }

        }
        //添加
        public int Add(Huiyi h)
        {
            try
            {
                string sql = $" insert into Huiyi(HuiyiNei,StartTime,AId,CId,BeiZhu,HuiyiName,Shipin) values('{h.HuiyiNei}','{h.StartTime}',{h.AId},{h.CId},'{h.BeiZhu}','{h.HuiyiName}',{h.Shipin})";
                return DbHelper.Execute(sql);
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
