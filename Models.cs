namespace Summary.Liyam
{
    using System;
    using System.Collections.Generic;

    public class ProductSubmitModel
    {
        public string EntityName { get; set; }
        public string ActionType { get; set; }
        public Goods Entity { get; set; }
    }

    public class Goods
    {
        public string CostOrIncomeStr { get; set; }
        public string GoodsTypeStr { get; set; }
        public string GoodsSubTypeStr { get; set; }
        public string LockedStr { get; set; }
        public string HasVatStr { get; set; }
        public string Message { get; set; }
        public int MessageType { get; set; }
        public int GoodsGroup_GoodsGroupId { get; set; }
        public string GoodsGroup_Title { get; set; }
        public int GoodsGroup_Code { get; set; }
        public string GoodsGroup_Lookup { get; set; }
        public string GoodsSubGroup_Title { get; set; }
        public int GoodsSubGroup_Code { get; set; }
        public string GoodsSubGroup_Lookup { get; set; }
        public string FullTitle { get; set; }
        public string FullCode { get; set; }
        public string Unit_Title { get; set; }
        public string BaseUnit_Title { get; set; }
        public string Unit_Lookup { get; set; }
        public string BaseUnit_Lookup { get; set; }
        public int Ratio { get; set; }
        public string JsonData { get; set; }
        public decimal GoodsAmount { get; set; }
        public decimal LastBuyPrice { get; set; }
        public decimal LastSalePrice { get; set; }
        public decimal Amount { get; set; }
        public int? WarehouseId { get; set; }
        public string Warehouse_Title { get; set; }
        public string ServiceDetail_Lookup { get; set; }
        public string ServiceLedger_Lookup { get; set; }
        public string ServiceLevel5_Lookup { get; set; }
        public string ServiceDetail_Title { get; set; }
        public string ServiceLedger_Title { get; set; }
        public string ServiceLevel5_Title { get; set; }
        public string ServiceDetail_FullCode { get; set; }
        public string ServiceLedger_FullCode { get; set; }
        public string ServiceLevel5_FullCode { get; set; }
        public string AttributesStr { get; set; }
        public string RelatedGoods_Lookup { get; set; }
        public string ServiceGroup_Lookup { get; set; }
        public int GoodsId { get; set; }
        public object GoodsGroup { get; set; }
        public int GoodsSubGroupId { get; set; }
        public object GoodsSubGroup { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Model { get; set; }
        public int UnitId { get; set; }
        public object Unit { get; set; }
        public bool IsDualUnit { get; set; }
        public int BaseUnitId { get; set; }
        public int GoodsType { get; set; }
        public int CostOrIncome { get; set; }
        public string TechnicalCode { get; set; }
        public string Barcode { get; set; }
        public string ExternalCode { get; set; }
        public bool HasVAT { get; set; }
        public decimal? VatPercent { get; set; }
        public bool Locked { get; set; }
        public int? OrderPoint { get; set; }
        public int? StagnantLimit { get; set; }
        public int? ServiceDetailId { get; set; }
        public int? ServiceLedgerId { get; set; }
        public int ServiceLevel5Id { get; set; }
        public string StuffId { get; set; }
        public string CurrencyISOCode { get; set; }
        public bool ShowInQuickInvoice { get; set; }
        public bool HasGuaranty { get; set; }
        public int GoodsSubType { get; set; }
        public string RelatedGoods { get; set; }
        public int? ServiceGroupId { get; set; }
        public string AttributeSignature { get; set; }
        public List<object> Attributes { get; set; } = new List<object>();
        public DateTime CreatedDate { get; set; }
        public int? CreatedUserID { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedUserID { get; set; }
    }

}