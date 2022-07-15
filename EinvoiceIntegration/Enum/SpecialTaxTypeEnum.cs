﻿namespace EinvoiceIntegration.Enum
{
    public enum SpecialTaxTypeEnum
    {
        /// <summary>
        /// 無特種稅率
        /// </summary>
        None = 0,

        /// <summary>
        /// 特種飲食業
        /// 稅率: 25%
        /// 描述: 酒家及有陪侍服務之茶室、咖啡廳、酒吧
        /// </summary>
        SpecType1 = 1,

        /// <summary>
        /// 特種飲食業
        /// 稅率: 15%
        /// 描述: 銀行業、保險業、信託投資業、證券業、期貨業、票券業及典當業之專屬本業收入(不含銀行業、保險業經營銀行、保險本業收入)
        /// </summary>
        SpecType2 = 2,

        /// <summary>
        /// 金融業-其他專屬本業
        /// 稅率: 2%
        /// 描述: 其他專屬本業之銷售額(不含銀行業、保險業經營銀行、保險本業收入)
        /// </summary>
        SpecType3 = 3,

        /// <summary>
        /// 金融業-再保費收入
        /// 稅率: 1%
        /// 描述: 保險業之再保費收入
        /// </summary>
        SpecType4 = 4,

        /// <summary>
        /// 金融業-非專屬本業
        /// 稅率: 5%
        /// 描述: 銀行業、保險業、信託投資業、證券業、期貨業、票券業及典當業之非專屬本業收入
        /// </summary>
        SpecType5 = 5,

        /// <summary>
        /// 金融業-銷售額(適用於民國103年07月以後銷售額)
        /// 稅率: 5%
        /// 銀行業、保險業經營銀行、保險本業收入(適用於民國103年07月以後銷售額)
        /// </summary>
        SpecType6 = 6,

        /// <summary>
        /// 金融業-銷售額(適用於民國103年06月以前銷售額)
        /// 稅率: 5%
        /// 描述: 銀行業、保險業經營銀行、保險本業收入 (適用於民國103年06月以前銷售額)
        /// </summary>
        SpecType7 = 7,

        /// <summary>
        /// 空白
        /// 稅率: 0%
        /// 描述: 空白
        /// </summary>
        SpecType8 = 8,
    }
}