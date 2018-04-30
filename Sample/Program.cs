using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    class Program
    {
        static GamePayDBEntities db = new GamePayDBEntities();

        static void Main(string[] args)
        {

            var sample1 = db.type_PayWay.FirstOrDefault(a => a.ID == 1001).Name;
            //            SELECT TOP(1) 
            //    [Extent1].[ID] AS[ID], 
            //    [Extent1].[Name] AS[Name], 
            //    [Extent1].[ViewText] AS[ViewText], 
            //    [Extent1].[LinkUrl] AS[LinkUrl], 
            //    [Extent1].[IsValid] AS[IsValid], 
            //    [Extent1].[FeeRate] AS[FeeRate], 
            //    [Extent1].[Sort] AS[Sort], 
            //    [Extent1].[PayTypeId]
            //        AS[PayTypeId]
            //FROM[dbo].[type_PayWay]
            //        AS[Extent1]
            //WHERE 1001 = [Extent1].[ID]

            var count = db.type_PayWay.Count(a=>a.ID>1001);
            
            var count2 = db.type_PayWay.Where(a => a.ID > 1001).Count();
            var count3 = (from a in db.type_PayWay
                          where a.ID > 1001
                          select a).Count();

            //三种写法都是
            //        SELECT
            //[GroupBy1].[A1] AS[C1]
            //FROM(SELECT
            //    COUNT(1) AS[A1]
            //    FROM[dbo].[type_PayWay] AS[Extent1]
            //    WHERE[Extent1].[ID] > 1001
            //)  AS[GroupBy1]

        }


    }
}
