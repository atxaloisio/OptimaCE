//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Produto_Imposto
    {
        public long Id { get; set; }
        public Nullable<int> nCodProd { get; set; }
        public string cCodIntProd { get; set; }
        public string cCodIntImp { get; set; }
        public string cCupomFiscal { get; set; }
        public string cUfOrigem { get; set; }
        public string cUfDestino { get; set; }
        public string cCFOP { get; set; }
        public string cCNAECliente { get; set; }
        public string cContribICMS { get; set; }
        public string cCSTCOFINS { get; set; }
        public string cTpCalcCOFINS { get; set; }
        public Nullable<decimal> nValUnTribCOFINS { get; set; }
        public Nullable<decimal> nAliqCOFINS { get; set; }
        public string cECFNaoTrib { get; set; }
        public string cECFSubstTrib { get; set; }
        public string cECFIsento { get; set; }
        public string cCSTICMS { get; set; }
        public string cOrigemICMS { get; set; }
        public string cModBCICMS { get; set; }
        public Nullable<decimal> nRedBCICMS { get; set; }
        public Nullable<decimal> nAliqICMS { get; set; }
        public Nullable<decimal> nPercDifICMS { get; set; }
        public Nullable<decimal> nPercFCP { get; set; }
        public Nullable<decimal> nAlIntUFDest { get; set; }
        public Nullable<decimal> nAlInterestUFs { get; set; }
        public Nullable<decimal> nPercICMSIE { get; set; }
        public string cCSOSNICMS_SN { get; set; }
        public string cOrigemICMS_SN { get; set; }
        public string cModBCICMS_SN { get; set; }
        public Nullable<decimal> nAlCredICMS_SN { get; set; }
        public Nullable<decimal> nRedBCICMS_SN { get; set; }
        public Nullable<decimal> nAliqICMS_SN { get; set; }
        public string cModBCICMSST { get; set; }
        public Nullable<decimal> nMargValAdICMSST { get; set; }
        public Nullable<decimal> nRedBCICMSST { get; set; }
        public Nullable<decimal> nAliqICMSST { get; set; }
        public Nullable<decimal> nAliqOPICMSST { get; set; }
        public string cCEST { get; set; }
        public string cCSTIPI { get; set; }
        public string cTpCalcIPI { get; set; }
        public Nullable<decimal> nAliqIPI { get; set; }
        public Nullable<decimal> nValUnTribIPI { get; set; }
        public string cEnqIPI { get; set; }
        public string cCSTPIS { get; set; }
        public string cTpCalcPIS { get; set; }
        public Nullable<decimal> nAliqPIS { get; set; }
        public Nullable<decimal> nValUnTribPIS { get; set; }
        public string cInfAdicNF { get; set; }
    }
}
