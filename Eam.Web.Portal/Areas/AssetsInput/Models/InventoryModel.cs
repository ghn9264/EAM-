﻿using System;

namespace Eam.Web.Portal.Areas.AssetsInput.Models
{
    public class InventoryModel
    {
        public int EntityId { get; set; }

        //盘点人
        public string InventoryPerson { get; set; }

        //盘点时间
        public DateTime InventoryDate { get; set; }

        //盘点计划编号
        public string InventoryFormNo { get; set; }
    }
}