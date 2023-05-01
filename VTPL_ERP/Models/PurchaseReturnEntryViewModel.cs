﻿using ERP.DAL.Dto;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VTPL_ERP.Models
{
    public class PurchaseReturnEntryViewModel
    {
        public string DebitNoteNo { get; set; }
        public DateTime DebitNoteDate { get; set; }
        public string DebitNoteDateDisplay { get; set; }
        public string PurchaseReturnDateString { get; set; }
        public List<AccountPartyMasterDto> SupplierList { get; set; }
        public List<InventoryMasterDto> StockItemList { get; set; }
        public List<OtherChargesMasterDto> OtherChargesList { get; set; }
        public List<PurchaseReturnEntryDetailsViewModel> PurchaseReturnEntryDetails { get; set; }
        public List<PurchaseReturnEntryOtherChargesDetailsViewModel> PurchaseReturnEntryOtherChargesDetails { get; set; }

        public List<PurchaseEntryDetailsDto> PurchaseEntryDetailsData { get; set; }
        public List<PEOtherChargesDetailsDto> PEOtherChargesDetailsData { get; set; }
        public List<PurchaseReturnEntryDetailsDto> PurchaseReturnEntryDetailsData { get; set; }
        public List<PurchaseReturnEntryOtherChargesDetailsDto> PurchaseReturnEntryOtherChargesDetailsData { get; set; }

        public SelectList SupplierSelectList { get; set; }
        public SelectList StockItemSelectList { get; set; }
        public SelectList OtherChargesSelectList { get; set; }
        public SelectList PurchaseEntrySelectList { get; set; }
        public SelectList BranchSelectList { get; set; }

        public string SelectedSupplierId { get; set; }
        public int SelectedStockItemId { get; set; }
        public int SelectedOtherChargesId { get; set; }
        public string SelectedPEId { get; set; }
        public int SelectedBranchId { get; set; }

        public int BranchId { get; set; }
        public string OriginalPurchaseEntryId { get; set; }
        public string SupplierId { get; set; }
        public decimal CurrentBalance { get; set; }
        public string PurchaseAccount { get; set; }
        public string Narration { get; set; }
        public int TotalQty { get; set; }
        public decimal Amount { get; set; }
        public decimal OtherCharges { get; set; }
        public decimal DiscAmount { get; set; }
        public decimal SGST { get; set; }
        public decimal CGST { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TotalTaxAmount { get; set; }
        public decimal RoundOff { get; set; }
        public DateTime? Created_Date { get; set; }
        public DateTime? Modified_Date { get; set; }
        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }
        public string PageMode { get; set; }
        public string BranchName { get; set; }
        public string SupplierName { get; set; }
        public string SupplierAddress { get; set; }
        public string SupplierGSTNumber { get; set; }
        public string SupplierPANNumber { get; set; }
        public string SupplierStateTINNo { get; set; }
        public string SupplierStateName { get; set; }
        public string JsonOtherChargesData { get; set; }
        public List<string> StockSerialIds { get; set; }
    }
}
