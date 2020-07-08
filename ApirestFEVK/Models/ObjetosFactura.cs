using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApirestFEVK.Models
{
    public class ObjetosFactura
    {
    }

    public class Xml
    {
        public string version { get; set; }
        public string encoding { get; set; }
    }

    public class Cell
    {
        public string uid { get; set; }
        public string value { get; set; }
    }

    public class Cells
    {
        public IList<Cell> cell { get; set; }
    }

    public class Row
    {
        public Cells cells { get; set; }
    }

    public class Rows
    {
        public Row row { get; set; }
    }

    public class DbDataSources
    {
        public string uid { get; set; }
        public Rows rows { get; set; }
    }

    public class OINV
    {
        public Xml xml { get; set; }
        public DbDataSources dbDataSources { get; set; }
    }

    public class OCRD
    {
        public Xml xml { get; set; }
        public DbDataSources dbDataSources { get; set; }
    }

    public class INV1
    {
        public Xml xml { get; set; }
        public DbDataSources dbDataSources { get; set; }
    }

    public class ObjetosSAP
    {
        public OINV OINV { get; set; }
        public OCRD OCRD { get; set; }
        public INV1 INV1 { get; set; }
    }


}
