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

    public class OCTG
    {
        public Xml xml { get; set; }
        public DbDataSources dbDataSources { get; set; }
    }
    public class OADM
    {
        public string CompnyName { get; set; }
        public string CompnyAddr { get; set; }
        public string Country { get; set; }
        public string Phone1 { get; set; }
        public string E_Mail { get; set; }
        public string Manager { get; set; }
        public string CompType { get; set; }
        public string MainCurncy { get; set; }
        public string SysCurrncy { get; set; }
        public string TaxIdNum { get; set; }
        public string XmlPath { get; set; }
    }
    public class OADMS
    {
        public OADM OADM { get; set; }
    }

    public class ADM1
    {
        public string Street { get; set; }
        public object StreetF { get; set; }
        public object Block { get; set; }
        public object BlockF { get; set; }
        public string City { get; set; }
        public object CityF { get; set; }
        public string ZipCode { get; set; }
        public object ZipCodeF { get; set; }
        public string County { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string IntrntAdrs { get; set; }
        public string GlblLocNum { get; set; }
  
    }

    public class ADM1S
    {
        public ADM1 ADM1 { get; set; }
    }

    public class ObjetosSAP
    {
        public OINV OINV { get; set; }
        public OCRD OCRD { get; set; }
        public INV1 INV1 { get; set; }
        public OCTG OCTG { get; set; }
        public OADMS OADMS { get; set; }
        public ADM1S ADM1S { get; set; }

        // public OADMS OADMS { get; set; }
    }


}
