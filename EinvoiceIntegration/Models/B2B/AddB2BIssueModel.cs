﻿using EinvoiceIntegration.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EinvoiceIntegration.Models.B2B
{
    public class AddB2BIssueModel : BaseModel
    {
        public class Item
        {
            /// <summary>
            /// 商品排列順序
            /// </summary>
            [Display(Name = "明細排列序號")]
            [Range(0, int.MaxValue)]
            public int ItemSeq { get; set; }

            /// <summary>
            /// 商品名稱
            /// </summary>
            [Required]
            [Display(Name = "商品名稱")]
            [StringLength(100)]
            public string ItemName { get; set; }

            /// <summary>
            /// 商品數量
            /// </summary>
            [Required]
            [Display(Name = "商品數量")]
            [Range(0, 99999)]
            public decimal ItemCount { get; set; }

            /// <summary>
            /// 商品單位
            /// </summary>
            [Required]
            [Display(Name = "商品單位")]
            [StringLength(6)]
            public string ItemWord { get; set; }

            /// <summary>
            /// 商品價格
            /// </summary>
            [Required]
            [Display(Name = "單價")]
            [Range(-99999999, 99999999)]
            public decimal ItemPrice { get; set; }

            /// <summary>
            /// 商品稅額
            /// 1：應稅
            /// 2：零稅率
            /// 3：免稅
            /// </summary>
            [Display(Name = "課稅別")]
            [RegularExpression("^[1|2|3|9]{1}$")]
            public string ItemTaxType { get; set; }

            /// <summary>
            /// 商品合計(含稅金額)
            /// </summary>
            [Required]
            [Display(Name = "商品合計金額")]
            [Range(-999999999999, 999999999999)]
            public decimal ItemAmount { get; set; }

            /// <summary>
            /// 商品備註說明
            /// </summary>
            [Display(Name = "商品備註(單一欄位備註)")]
            [StringLength(40)]
            public string ItemRemark { get; set; }
        }

        /// <summary>
        /// 發票開立日期
        /// </summary>
        [Display(Name = "發票開立日期")]
        public DateTime? InvoiceDate { get; set; }

        /// <summary>
        /// 發票開立時間
        /// 格式為 HH:mm:ss
        /// </summary>
        [Display(Name = "發票開立時間")]
        [StringLength(8, MinimumLength = 0, ErrorMessage = "發票開立時間格式錯誤")]
        public string InvoiceTime { get; set; }


        /// <summary>
        /// 相關號碼(廠商自訂編號)
        /// 不可重複 唯一值
        /// </summary>
        [Required]
        [Display(Name = "相關號碼(廠商自訂編號)")]
        [StringLength(30)]
        public string RelateNumber { get; set; }

        /// <summary>
        /// 客戶編號
        /// </summary>
        [Display(Name = "客戶編號")]
        [StringLength(20)]
        [RegularExpression("^[A-Za-z0-9]+$")]
        public string CustomerID { get; set; }

        /// <summary>
        /// 統一編號(客戶)
        /// </summary>
        [Display(Name = "統一編號(客戶)")]
        [RegularExpression("^[0]{10}$|^[0-9]{8}$", ErrorMessage = "{0} 格式錯誤")]
        public string CustomerIdentifier { get; set; }

        /// <summary>
        /// 客戶名稱
        /// </summary>
        [Display(Name = "客戶名稱")]
        [StringLength(60)]
        public string CustomerName { get; set; }

        /// <summary>
        /// 客戶地址
        /// </summary>
        [Display(Name = "客戶地址")]
        [StringLength(100)]
        public string CustomerAddr { get; set; }

        /// <summary>
        /// 客戶手機號碼
        /// </summary>
        [Display(Name = "客戶手機號碼")]
        [StringLength(20)]
        [RegularExpression("^[0-9]{1,20}$")]
        public string CustomerPhone { get; set; }

        /// <summary>
        /// EMail(客戶)
        /// </summary>
        [Display(Name = "EMail(客戶)")]
        [StringLength(80)]
        [ValidateEmail(separator = new char[] { ';' })]
        public string CustomerEmail { get; set; }

        /// <summary>
        /// 通關方式
        /// </summary>
        [Display(Name = "通關方式")]
        [RegularExpression("^[1-2]{0,1}$")]
        public string ClearanceMark { get; set; }

        /// <summary>
        /// 列印註記
        /// </summary>
        [Display(Name = "列印註記")]
        [RegularExpression("^[0,1]{1}$")]
        public int Print { get; set; }

        /// <summary>
        /// 捐贈註記
        /// </summary>
        [Display(Name = "捐贈註記")]
        [RegularExpression("^[0-1]{1}$")]
        public int Donation { get; set; }

        /// <summary>
        /// 捐贈碼
        /// </summary>
        [Display(Name = "捐贈碼")]
        [StringLength(10)]
        [RegularExpression("^([0-9]{3,7}|[xX][0-9]{2,6})$")]
        public string LoveCode { get; set; }

        /// <summary>
        /// 載具類別
        /// </summary>
        [Display(Name = "載具類別")]
        [RegularExpression(@"^[\s|1|2|3]{1}$")]
        public string CarrierType { get; set; }

        /// <summary>
        /// 載具編號
        /// </summary>
        [Display(Name = "載具編號")]
        [StringLength(64)]
        public string CarrierNum { get; set; }

        /// <summary>
        /// 課稅類別
        /// </summary>
        [Required]
        [Display(Name = "課稅別")]
        [RegularExpression("^[1|2|3|9]{1}$")]
        public string TaxType { get; set; }

        /// <summary>
        /// 發票總金額
        /// </summary>
        [Required]
        [Display(Name = "應稅銷售額合計")]
        [Range(0, int.MaxValue)]
        public int SalesAmount { get; set; }

        /// <summary>
        /// 發票備註
        /// </summary>
        [Display(Name = "發票備註")]
        [StringLength(200)]
        public string InvoiceRemark { get; set; }

        /// <summary>
        /// 字軌類別
        ///     07:一般稅額
        ///     08:特種稅額計
        /// </summary>
        [Required]
        [Display(Name = "發票類別")]
        [RegularExpression("^0[7,8]{1}$")]
        public string InvType { get; set; }

        /// <summary>
        /// 商品單價是否含稅
        /// 預設為含稅價
        ///     1:含稅
        ///     0:未稅
        /// </summary>
        [Required]
        [Display(Name = "是否含稅")]
        [RegularExpression("^[0,1]{1}$")]
        public string Vat { get; set; }

        /// <summary>
        /// 商品明細
        /// </summary>
        [Required]
        [Display(Name = "商品明細")]
        [ValidateObject]
        public List<Item> Items { get; set; }
    }
}
