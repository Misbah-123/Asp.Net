using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace code_first_approach.Models
{
    public class Makeuplayer
    {
        public List<Makeup> getallrecords()
        {
            MakeuoContext obj = new MakeuoContext();
            List<Makeup> list = obj.Make.ToList();
            return list;


        }
    }
}