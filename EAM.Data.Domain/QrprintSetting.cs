﻿using EAM.Data.Comm;
using NPoco;

namespace EAM.Data.Domain
{
    [TableName("QRPRINTSETTING")]
    [PrimaryKey("ID")]
    public class QrprintSetting : IEntity<int>
    {
        [Column("ID")]
        public int EntityId { get; set; }

        [Column("PRINTSET")]
        public string Printset { get; set; }
        [Column("PRINTTITLEX")]
        public string PrintTitleX { get; set; }
        [Column("PRINTTITLEY")]
        public string PrintTitleY { get; set; }
        [Column("PRINTCODEX")]
        public string PrintcodeX { get; set; }
        [Column("PRINTCODEY")]
        public string PrintcodeY { get; set; }
        [Column("LABLENAME")]
        public string LableName { get; set; }
        [Column("LABLECONTACT")]
        public string LableContact { get; set; }

        [Column("PRINTFONTSIZE")]
        public string PrintFontSize { get; set; }
       
    }
}