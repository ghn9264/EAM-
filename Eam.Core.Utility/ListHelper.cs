﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Compression;



namespace Eam.Core.Utility
{
        public static class ListHelper
        {
            /// <summary>
            /// 按指定数量对List分组
            /// </summary>
            /// <typeparam name="T"></typeparam>
            /// <param name="list"></param>
            /// <param name="groupNum"></param>
            /// <returns></returns>
            public static List<List<T>> GetListGroup<T>(List<T> list, int groupNum)
            {
                List<List<T>> listGroup = new List<List<T>>();
                for (int i = 0; i < list.Count(); i += groupNum)
                {
                    listGroup.Add(list.Skip(i).Take(groupNum).ToList());
                }
                return listGroup;
            }

           

        }
        
        
    }
 

