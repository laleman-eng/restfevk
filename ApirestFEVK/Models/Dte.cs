using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ApirestFEVK.Models
{

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class MntPagos
    {
        public string FchPago { get; set; }
        public string MntPago { get; set; }
        public string GlosaPagos { get; set; }

    }

    public class IdDoc
    {
        public string TipoDTE { get; set; }
        public int Folio { get; set; }
        public string FchEmis { get; set; }
        public int IndNoRebaja { get; set; }
        public int TipoDespacho { get; set; }
        public int IndTraslado { get; set; }
        public string TpoImpresion { get; set; }
        public int IndServicio { get; set; }
        public int MntBruto { get; set; }
        public int TpoTranCompra { get; set; }
        public int TpoTranVenta { get; set; }
        public int FmaPago { get; set; }
        public int FmaPagExp { get; set; }
        public string FchCancel { get; set; }
        public int MntCancel { get; set; }
        public int SaldoInsol { get; set; }
        public List<MntPagos> MntPagos { get; set; }
        public string MedioPago { get; set; }
        public string TpoCtaPago { get; set; }
        public string NumCtaPago { get; set; }
        public string BcoPago { get; set; }
        public string TermPagoCdg { get; set; }
        public string TermPagoGlosa { get; set; }
        public int TermPagoDias { get; set; }
        public string FchVenc { get; set; }

    }

    public class GuiaExport
    {
        public int CdgTraslado { get; set; }
        public int FolioAut { get; set; }
        public DateTime FchAut { get; set; }

    }

    public class Emisor
    {
        public string RUTEmisor { get; set; }
        public string RznSoc { get; set; }
        public string GiroEmis { get; set; }
        public string Telefono { get; set; }
        public string CorreoEmisor { get; set; }
        public int Acteco { get; set; }
        public GuiaExport GuiaExport { get; set; }
        public string Sucursal { get; set; }
        public String CdgSIISucur { get; set; }
        public string DirOrigen { get; set; }
        public string CmnaOrigen { get; set; }
        public string CiudadOrigen { get; set; }
        public string CdgVendedor { get; set; }
        public string IdAdicEmisor { get; set; }

    }

    public class Extranjero
    {
        public string NumId { get; set; }
        public string Nacionalidad { get; set; }

    }

    public class Receptor
    {
        public string RUTRecep { get; set; }
        public string CdgIntRecep { get; set; }
        public string RznSocRecep { get; set; }
        public Extranjero Extranjero { get; set; }
        public string GiroRecep { get; set; }
        public string Contacto { get; set; }
        public string CorreoRecep { get; set; }
        public string DirRecep { get; set; }
        public string CmnaRecep { get; set; }
        public string CiudadRecep { get; set; }
        public string DirPostal { get; set; }
        public string CmnaPostal { get; set; }
        public string CiudadPostal { get; set; }

    }

    public class Chofer
    {
        public string RUTChofer { get; set; }
        public string NombreChofer { get; set; }

    }

    public class TipoBulto
    {
        public int CodTpoBultos { get; set; }
        public int CantBultos { get; set; }
        public string Marcas { get; set; }
        public string IdContainer { get; set; }
        public string Sello { get; set; }
        public string EmisorSello { get; set; }

    }

    public class Aduana
    {
        public int CodModVenta { get; set; }
        public int CodClauVenta { get; set; }
        public int TotClauVenta { get; set; }
        public int CodViaTransp { get; set; }
        public string NombreTransp { get; set; }
        public string RUTCiaTransp { get; set; }
        public string NomCiaTransp { get; set; }
        public string IdAdicTransp { get; set; }
        public string Booking { get; set; }
        public string Operador { get; set; }
        public int CodPtoEmbarque { get; set; }
        public string IdAdicPtoEmb { get; set; }
        public int CodPtoDesemb { get; set; }
        public string IdAdicPtoDesemb { get; set; }
        public int Tara { get; set; }
        public int CodUnidMedTara { get; set; }
        public int PesoBruto { get; set; }
        public int CodUnidPesoBruto { get; set; }
        public int PesoNeto { get; set; }
        public int CodUnidPesoNeto { get; set; }
        public int TotItems { get; set; }
        public int TotBultos { get; set; }
        public List<TipoBulto> TipoBultos { get; set; }
        public int MntFlete { get; set; }
        public int MntSeguro { get; set; }
        public int CodPaisRecep { get; set; }
        public int CodPaisDestin { get; set; }

    }

    public class Transporte
    {
        public string Patente { get; set; }
        public string RUTTrans { get; set; }
        public Chofer Chofer { get; set; }
        public string DirDest { get; set; }
        public string CmnaDest { get; set; }
        public string CiudadDest { get; set; }
        public Aduana Aduana { get; set; }

    }

    public class ImptoReten
    {
        public string TipoImp { get; set; }
        public int TasaImp { get; set; }
        public int MontoImp { get; set; }

    }

    public class Comisiones
    {
        public int ValComNeto { get; set; }
        public int ValComExe { get; set; }
        public int ValComIVA { get; set; }
        public int NroLinCom { get; set; }
        public string TipoMovim { get; set; }
        public string Glosa { get; set; }
        public int TasaComision { get; set; }

    }

    public class Totales
    {
        public int MntNeto { get; set; }
        public int MntExe { get; set; }
        public int MntBase { get; set; }
        public int MntMargenCom { get; set; }
        public int TasaIVA { get; set; }
        public int IVA { get; set; }
        public List<ImptoReten> ImptoReten { get; set; }
        public int IVANoRet { get; set; }
        public int CredEC { get; set; }
        public Comisiones Comisiones { get; set; }
        public int MntTotal { get; set; }
        public int MontoNF { get; set; }
        public int SaldoAnterior { get; set; }
        public int VlrPagar { get; set; }
        public string TpoMoneda { get; set; }

    }

    public class ImpRetOtrMnda
    {
        public string TipoImpOtrMnda { get; set; }
        public int TasaImpOtrMnda { get; set; }
        public int VlrImpOtrMnda { get; set; }

    }

    public class OtraMoneda
    {
        public string TpoMoneda { get; set; }
        public int TpoCambio { get; set; }
        public int MntNetoOtrMnda { get; set; }
        public int MntExeOtrMnda { get; set; }
        public int MntFaeCarneOtrMnda { get; set; }
        public int MntMargComOtrMnda { get; set; }
        public int IVAOtrMnda { get; set; }
        public List<ImpRetOtrMnda> ImpRetOtrMnda { get; set; }
        public int IVANoRetOtrMnda { get; set; }
        public int MntTotOtrMnda { get; set; }

    }

    public class Encabezado
    {
        public IdDoc IdDoc { get; set; }
        public Emisor Emisor { get; set; }
        public string RUTMandante { get; set; }
        public Receptor Receptor { get; set; }
        public string RUTSolicita { get; set; }
        public Transporte Transporte { get; set; }
        public Totales Totales { get; set; }
        public OtraMoneda OtraMoneda { get; set; }

    }

    public class CdgItem
    {
        public string TpoCodigo { get; set; }
        public string VlrCodigo { get; set; }

    }

    public class Retenedor
    {
        public string IndAgente { get; set; }
        public int MntBaseFaena { get; set; }
        public int MntMargComer { get; set; }
        public int PrcConsFinal { get; set; }

    }

    public class OtrMnda
    {
        public int PrcOtrMon { get; set; }
        public string Moneda { get; set; }
        public int FctConv { get; set; }
        public int DctoOtrMnda { get; set; }
        public int RecargoOtrMnda { get; set; }
        public int MontoItemOtrMnda { get; set; }

    }

    public class Detalle
    {
        public int NroLinDet { get; set; }
        public List<CdgItem> CdgItem { get; set; }
        public int IndExe { get; set; }
        public Retenedor Retenedor { get; set; }
        public string NmbItem { get; set; }
        public string DscItem { get; set; }
        public int QtyRef { get; set; }
        public string UnmdRef { get; set; }
        public int PrcRef { get; set; }
        public int QtyItem { get; set; }
        public DateTime FchElabor { get; set; }
        public DateTime FchVencim { get; set; }
        public string UnmdItem { get; set; }
        public int PrcItem { get; set; }
        public OtrMnda OtrMnda { get; set; }
        public int DescuentoPct { get; set; }
        public int DescuentoMonto { get; set; }
        public int RecargoPct { get; set; }
        public int RecargoMonto { get; set; }
        public string CodImpAdic { get; set; }
        public int MontoItem { get; set; }
        public string TpoDocLiq { get; set; }

    }

    public class DscRcgGlobal
    {
        public int NroLinDR { get; set; }
        public string TpoMov { get; set; }
        public string GlosaDR { get; set; }
        public string TpoValor { get; set; }
        public int ValorDR { get; set; }
        public int ValorDROtrMnda { get; set; }
        public int IndExeDR { get; set; }

    }

    public class Referencia
    {
        public int NroLinRef { get; set; }
        public string TpoDocRef { get; set; }
        public int IndGlobal { get; set; }
        public string FolioRef { get; set; }
        public string RUTOtr { get; set; }
        public DateTime FchRef { get; set; }
        public int CodRef { get; set; }
        public string RazonRef { get; set; }

    }

    public class Comisione
    {
        public int ValComNeto { get; set; }
        public int ValComExe { get; set; }
        public int ValComIVA { get; set; }
        public int NroLinCom { get; set; }
        public string TipoMovim { get; set; }
        public string Glosa { get; set; }
        public int TasaComision { get; set; }

    }

    public class Extra
    {
        public int FolioInterno { get; set; }
        public string Extra1 { get; set; }
        public string Extra2 { get; set; }
        public string Extra3 { get; set; }
        public string Extra4 { get; set; }
        public string Extra5 { get; set; }
        public string Extra6 { get; set; }
        public string Extra7 { get; set; }
        public string Extra8 { get; set; }
        public string Extra9 { get; set; }
        public string Extra10 { get; set; }
        public string Extra11 { get; set; }
        public string Extra12 { get; set; }
        public string Extra13 { get; set; }
        public string Extra14 { get; set; }
        public string Extra15 { get; set; }
        public string Extra16 { get; set; }
        public string Extra17 { get; set; }
        public string Extra18 { get; set; }
        public string Extra19 { get; set; }
        public string Extra20 { get; set; }

    }

    public class Documento
    {
        public Encabezado Encabezado { get; set; }
        public List<Detalle> Detalle { get; set; }
        public List<DscRcgGlobal> DscRcgGlobal { get; set; }
        public List<Referencia> Referencia { get; set; }
        public List<Comisione> Comisiones { get; set; }
        public Extra Extra { get; set; }
        public string TED { get; set; }

    }

    public class Dte
    {
        public Documento Documento { get; set; }

    }




}
