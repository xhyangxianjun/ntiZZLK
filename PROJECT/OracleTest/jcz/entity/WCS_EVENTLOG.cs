﻿using System;
using System.Linq;
using System.Text;

namespace entity
{
    ///<summary>
    ///
    ///</summary>
    public partial class WCS_EVENTLOG
    {
           public WCS_EVENTLOG(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string WAREHOUSEID {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string EVENTLOG {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CREATETIME {get;set;}

    }
}
