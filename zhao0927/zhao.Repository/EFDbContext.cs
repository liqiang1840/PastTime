using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using Zhao.Domain;

namespace zhao.Repository
{
   
        public class EFDbContext : DbContext
        {
            private const string SCHEMA_NAME_SALES = "Sales";
            private const string SCHEMA_NAME_LOG = "Log";
            /// <summary>
            /// OrderNumber最大长度
            /// </summary>
            private const int ORDERNUMBER_MAXLENGTH = 20;
            /// <summary>
            /// 操作人最大长度
            /// </summary>
            private const int OPERATORNAME_MAXLENGTH = 30;
            /// <summary>
            /// Currency code 最大长度
            /// </summary>
            private const int CURRENCYCODE_MAXLENGTH = 3;
            /// <summary>
            /// Notes 最大长度
            /// </summary>
            private const int NOTES_MAXLENGTH = 200;

            public EFDbContext()
                : this("name=OMSDbMaster")
            {
            }

            internal EFDbContext(string nameOrConnectionString)
                : base(nameOrConnectionString)
            {
                Database.SetInitializer<EFDbContext>(null);
            }

            /// <summary>
            /// 订单数据集
            /// </summary>
            public IDbSet<News> News { get; set; }

            public IDbSet<Catalog> Catalog { get; set; }

            public IDbSet<Author> Author { get; set; }

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                /* 
                 * 自定义Object与ER模型映射
                 */
                //
                modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
                //
                #region Order
                modelBuilder.Entity<News>().ToTable("News", SCHEMA_NAME_SALES);
                modelBuilder.Entity<News>().Ignore(o => o.StoreID);
                modelBuilder.Entity<Order>().Ignore(o => o.ShippingAddress);
                modelBuilder.Entity<Order>().Ignore(o => o.UserDefinedShippingFee);
                modelBuilder.Entity<Order>().Ignore(o => o.ActualAvailableAmount);
                modelBuilder.Entity<Order>().Ignore(o => o.ActualReceived);
                modelBuilder.Entity<Order>().Ignore(o => o.ActualRefunded);
                modelBuilder.Entity<Order>().Ignore(o => o.PaymentStatus);
                modelBuilder.Entity<Order>().Ignore(o => o.FulfillmentStatus);
                modelBuilder.Entity<Order>().Ignore(o => o.LockStatus);
                modelBuilder.Entity<Order>().Ignore(o => o.Status);
                modelBuilder.Entity<Order>().Ignore(o => o.CompositeState);
                modelBuilder.Entity<Order>().Ignore(o => o.PaymentState);
                modelBuilder.Entity<Order>().Ignore(o => o.FulfillmentState);
                modelBuilder.Entity<Order>().Ignore(o => o.LockState);
                modelBuilder.Entity<Order>().Ignore(o => o.SalesChannelType);
                modelBuilder.Entity<Order>().Ignore(o => o.ShippingMethod);
                modelBuilder.Entity<Order>().Ignore(o => o.UserDefinedShippingMethod);
                modelBuilder.Entity<Order>().Ignore(o => o.CurrencyCode);
                modelBuilder.Entity<Order>().Ignore(o => o.TxnCouponMergeSalesDetails);
                modelBuilder.Entity<Order>().Ignore(o => o.PaymentTxns);
                modelBuilder.Entity<Order>().Ignore(o => o.WrappingOptions);
                modelBuilder.Entity<Order>().Ignore(o => o.Misc);
                modelBuilder.Entity<Order>().Ignore(o => o.CustomerOrderth);
                modelBuilder.Entity<Order>().Ignore(o => o.FulfillmentPriority);
                modelBuilder.Entity<Order>().Ignore(o => o.FulfillmentPolicy);
                modelBuilder.Entity<Order>().Ignore(o => o.CustomerService);
                modelBuilder.Entity<Order>().Ignore(o => o.Customer);
                modelBuilder.Entity<Order>().Ignore(o => o.Memos);
                modelBuilder.Entity<Order>().Ignore(o => o.StatusHistoryList);
                //
                modelBuilder.Entity<Order>().Property(o => o.CreateBy).HasColumnType("varchar").HasMaxLength(OPERATORNAME_MAXLENGTH).IsUnicode(false);
                modelBuilder.Entity<Order>().Property(o => o.ModifyBy).HasColumnType("varchar").HasMaxLength(OPERATORNAME_MAXLENGTH).IsUnicode(false);
                modelBuilder.Entity<Order>().Property(o => o.OrderNumber).HasColumnType("varchar").HasMaxLength(ORDERNUMBER_MAXLENGTH).IsUnicode(false).IsRequired();
                modelBuilder.Entity<Order>().Property(o => o.OrderDate).HasColumnName("CreateOn").IsRequired();
                modelBuilder.Entity<Order>().Property(o => o.LastModified).HasColumnName("ModifyOn").IsOptional();
                modelBuilder.Entity<Order>().Property(o => o.StatusValue).HasColumnName("OrderStatus").IsRequired();
                modelBuilder.Entity<Order>().Property(o => o.FulfillmentStatusValue).HasColumnName("FulfillmentStatus").IsRequired();
                modelBuilder.Entity<Order>().Property(o => o.LockStatusValue).HasColumnName("LockStatus").IsRequired();
                modelBuilder.Entity<Order>().Property(o => o.PaymentStatusValue).HasColumnName("PaymentStatus").IsRequired();
                modelBuilder.Entity<Order>().Property(o => o.FulfillmentPolicyValue).HasColumnName("FufillmentPolicy").IsRequired();
                modelBuilder.Entity<Order>().Property(o => o.FulfillmentPriorityValue).HasColumnName("FufillmentPriority").IsRequired();
                modelBuilder.Entity<Order>().Property(o => o.SalesChannelTypeValue).HasColumnName("SalesChannelType").IsRequired();
                modelBuilder.Entity<Order>().Property(o => o.ShippingMethodValue).HasColumnName("ShippingMethod").IsRequired();
                modelBuilder.Entity<Order>().Property(o => o.CurrencyCodeName).HasColumnName("CurrencyCode").HasColumnType("char").HasMaxLength(CURRENCYCODE_MAXLENGTH).IsUnicode(false).IsRequired();
                modelBuilder.Entity<Order>().Property(o => o.LastPaymentConfirmed).HasColumnName("PaymentConfirmed").IsOptional();
                modelBuilder.Entity<Order>().Property(o => o.TotalPaid).HasColumnName("CapturedAmount").IsRequired();
                modelBuilder.Entity<Order>().Property(o => o.TotalRefunded).HasColumnName("RefundedAmount").IsRequired();
                modelBuilder.Entity<Order>().Property(o => o.OrderTypeValue).HasColumnName("OrderType").IsRequired();
                modelBuilder.Entity<Order>().Property(o => o.OrderDiscount).HasColumnName("DiscountTotal").IsRequired();
                modelBuilder.Entity<Order>().Property(o => o.BulkRateFee).HasColumnName("BulkRateFee").IsOptional();
                modelBuilder.Entity<Order>().Property(o => o.CompleteOn).HasColumnName("CompleteOn").IsOptional();
                modelBuilder.Entity<Order>().Property(o => o.Version).HasColumnType("timestamp").IsRowVersion();
                modelBuilder.Entity<Order>().Property(o => o.ExchangeRate).HasPrecision(10, 4);

                modelBuilder.Entity<Order>().Property(o => o.ShippingInsuranceAmount).HasColumnName("ShippingInsuranceAmount").IsOptional();
                modelBuilder.Entity<Order>().Property(o => o.ShippingInsuranceEnabled).HasColumnName("ShippingInsuranceEnabled").IsRequired();
                // 配置主外键关系
                // 一对一
                modelBuilder.Entity<Order>().HasRequired(o => o.OrderShippingAddress).WithRequiredPrincipal();
                modelBuilder.Entity<Order>().HasRequired(o => o.OrderWrappingOptions).WithRequiredPrincipal();
                modelBuilder.Entity<Order>().HasRequired(o => o.OrderMisc).WithRequiredPrincipal();
                // 一对多
                modelBuilder.Entity<Order>().HasMany(o => o.Lines).WithRequired(o => o.Order).HasForeignKey(o => o.OrderID);
                modelBuilder.Entity<Order>().HasMany(o => o.Txns).WithRequired(o => o.Order).HasForeignKey(o => o.OrderID);
                modelBuilder.Entity<Order>().HasMany(o => o.SalesDetails).WithRequired().HasForeignKey(o => o.OrderID);
                modelBuilder.Entity<Order>().HasMany(o => o.HandlingFeeList).WithRequired(o => o.Order).HasForeignKey(o => o.OrderID);
                modelBuilder.Entity<Order>().HasMany(o => o.FulfillmentOrders).WithRequired(o => o.Order).HasForeignKey(o => o.OrderID);
                //modelBuilder.Entity<Order>().HasMany(o => o.Memos).WithRequired().HasForeignKey(o => o.OrderID);
                //modelBuilder.Entity<Order>().HasMany(o => o.StatusHistoryList).WithRequired().HasForeignKey(o => o.OrderID);
                #endregion
                //
                #region OrderLine
                modelBuilder.Entity<OrderLine>().ToTable("OrderLine", SCHEMA_NAME_SALES);
                modelBuilder.Entity<OrderLine>().Property(ol => ol.IsCanceled).HasColumnName("IsCanceled").IsRequired();
                modelBuilder.Entity<OrderLine>().Property(ol => ol.IsFeatured).HasColumnName("IsFeatured").IsOptional();
                modelBuilder.Entity<OrderLine>().Property(ol => ol.IsMIC).HasColumnName("IsMIC").IsOptional();
                modelBuilder.Entity<OrderLine>().Ignore(ol => ol.SellingPrice);
                modelBuilder.Entity<OrderLine>().Ignore(ol => ol.SellingPriceMode);
                modelBuilder.Entity<OrderLine>().Ignore(ol => ol.DiscountMode);
                modelBuilder.Entity<OrderLine>().Ignore(ol => ol.DiscountRate);
                modelBuilder.Entity<OrderLine>().Ignore(ol => ol.LineDiscount);
                modelBuilder.Entity<OrderLine>().Ignore(ol => ol.LineAllDiscount);
                modelBuilder.Entity<OrderLine>().Ignore(ol => ol.Order);
                modelBuilder.Entity<OrderLine>().Ignore(ol => ol.ParentSku);
                modelBuilder.Entity<OrderLine>().Property(ol => ol.ProductTypeValue).HasColumnName("ProductType").IsRequired();
                modelBuilder.Entity<OrderLine>().Property(ol => ol.Version).HasColumnType("timestamp").IsRowVersion();
                modelBuilder.Entity<OrderLine>().Property(ol => ol.CreateBy).HasColumnName("CreateBy").HasColumnType("varchar").HasMaxLength(OPERATORNAME_MAXLENGTH).IsRequired();
                modelBuilder.Entity<OrderLine>().Property(ol => ol.ModifyBy).HasColumnName("ModifyBy").HasColumnType("varchar").HasMaxLength(OPERATORNAME_MAXLENGTH).IsOptional();
                modelBuilder.Entity<OrderLine>().Property(ol => ol.Notes).HasColumnName("Notes").HasColumnType("nvarchar").HasMaxLength(NOTES_MAXLENGTH).IsOptional();
                #endregion
                // 
                #region Address
                modelBuilder.Entity<OrderShippingAddress>().ToTable("OrderShippingAddress", SCHEMA_NAME_SALES);
                modelBuilder.ComplexType<Address>().Ignore(a => a.CountryCode);
                modelBuilder.ComplexType<Address>().Property(a => a.CountryCodeName).HasColumnName("CountryCode").HasColumnType("char").IsRequired();
                modelBuilder.ComplexType<Address>().Property(a => a.State).HasColumnName("State").IsRequired();
                modelBuilder.ComplexType<Address>().Property(a => a.City).HasColumnName("City").IsRequired();
                modelBuilder.ComplexType<Address>().Property(a => a.Street1).HasColumnName("Street1").IsRequired();
                modelBuilder.ComplexType<Address>().Property(a => a.Street2).HasColumnName("Street2").IsOptional();
                modelBuilder.ComplexType<Address>().Property(a => a.PostalCode).HasColumnName("PostalCode").IsRequired();
                modelBuilder.ComplexType<Address>().Property(a => a.FirstName).HasColumnName("FirstName").IsRequired();
                modelBuilder.ComplexType<Address>().Property(a => a.LastName).HasColumnName("LastName").IsRequired();
                modelBuilder.ComplexType<Address>().Property(a => a.PhoneNumber).HasColumnName("PhoneNumber").IsOptional();
                #endregion
                //
                #region WrappingOptions
                modelBuilder.Entity<OrderWrappingOptions>().ToTable("OrderWrappingOptions", SCHEMA_NAME_SALES);
                modelBuilder.ComplexType<WrappingOptions>().Ignore(w => w.GreetingMessage);
                //modelBuilder.ComplexType<WrappingOptions>().Property(w => w.GreetingMessage.Body);
                modelBuilder.ComplexType<WrappingOptions>().Ignore(w => w.WrapperType);
                modelBuilder.ComplexType<WrappingOptions>().Ignore(w => w.PriceDisplayMode);
                modelBuilder.ComplexType<WrappingOptions>().Property(w => w.WrapperTypeValue).HasColumnName("WrapperType").IsRequired();
                modelBuilder.ComplexType<WrappingOptions>().Property(w => w.PriceDisplayModeValue).HasColumnName("PriceDisplayMode").IsRequired();
                #endregion
                //
                #region Misc
                modelBuilder.Entity<OrderMisc>().HasKey(om => om.OrderID).ToTable("OrderMisc", SCHEMA_NAME_SALES);
                modelBuilder.ComplexType<Misc>().Property(m => m.DropShippingBatchID).HasColumnName("DropShippingBatchID").IsOptional();
                modelBuilder.ComplexType<Misc>().Property(m => m.GroupBuyingProjectID).HasColumnName("GroupBuyingProjectID").IsOptional();
                modelBuilder.ComplexType<Misc>().Property(m => m.CustomerMemo).HasColumnName("CustomerMemo").IsOptional();
                modelBuilder.ComplexType<Misc>().Property(m => m.Notes).HasColumnName("Notes").IsOptional();
                modelBuilder.ComplexType<Misc>().Property(m => m.LockExpiration).HasColumnName("LockExpiration").IsOptional();
                modelBuilder.ComplexType<Misc>().Property(m => m.Ref1).HasColumnName("Ref1").IsOptional();
                modelBuilder.ComplexType<Misc>().Property(m => m.Ref2).HasColumnName("Ref2").IsOptional();
                modelBuilder.ComplexType<Misc>().Property(m => m.Ref3).HasColumnName("Ref3").IsOptional();
                modelBuilder.ComplexType<Misc>().Property(m => m.Ref4).HasColumnName("Ref4").IsOptional();
                #endregion
                //
                #region Txn
                modelBuilder.Entity<Txn>().ToTable("Txn", SCHEMA_NAME_SALES);
                modelBuilder.Entity<Txn>().Ignore(t => t.PaymentMethod);
                modelBuilder.Entity<Txn>().Ignore(t => t.TxnType);
                modelBuilder.Entity<Txn>().Ignore(t => t.CurrencyCode);
                modelBuilder.Entity<Txn>().Ignore(t => t.Order);
                modelBuilder.Entity<Txn>().Property(t => t.PaymentMethodValue).HasColumnName("PaymentMethod").IsRequired();
                modelBuilder.Entity<Txn>().Property(t => t.TxnTypeValue).HasColumnName("TxnType").IsRequired();
                modelBuilder.Entity<Txn>().Property(t => t.CurrencyCodeValue).HasColumnName("CurrencyCode").IsRequired();
                modelBuilder.Entity<Txn>().Property(t => t.OrderNumber).HasColumnName("OrderNumber").HasColumnType("varchar").HasMaxLength(ORDERNUMBER_MAXLENGTH).IsRequired();
                modelBuilder.Entity<Txn>().Property(t => t.PaymentTxnID).HasColumnName("PaymentTxnID").HasColumnType("varchar").IsRequired();
                modelBuilder.Entity<Txn>().Property(t => t.PaymentParentTxnID).HasColumnName("PaymentParentTxnID").HasColumnType("varchar");
                modelBuilder.Entity<Txn>().Property(t => t.TxnData).HasColumnName("TxnData").HasColumnType("varchar");
                modelBuilder.Entity<Txn>().Property(t => t.Notes).HasColumnName("Notes").HasColumnType("varchar");

                #endregion
                //
                #region SalesActivityDetail
                modelBuilder.Entity<OrderSalesDetail>().ToTable("SalesActivityDetail", SCHEMA_NAME_SALES);
                modelBuilder.ComplexType<SalesDetail>().Property(s => s.IsAutomatic).HasColumnName("IsAutomatic").IsRequired();
                modelBuilder.ComplexType<SalesDetail>().Property(s => s.SalesXml).HasColumnName("SalesXml").IsRequired();
                modelBuilder.ComplexType<SalesDetail>().Property(s => s.SalesEventID).HasColumnName("SalesEventID").IsRequired();
                modelBuilder.ComplexType<SalesDetail>().Property(s => s.CouponCode).HasColumnName("CouponCode").IsOptional();
                modelBuilder.ComplexType<SalesDetail>().Property(s => s.Notes).HasColumnName("Notes").IsOptional();

                #endregion
                //
                #region OrderHandlingFeeHistory
                modelBuilder.Entity<OrderHandlingFee>().ToTable("OrderHandlingFeeHistory", SCHEMA_NAME_SALES);
                modelBuilder.Entity<OrderHandlingFee>().Ignore(ohf => ohf.Order);
                modelBuilder.Entity<OrderHandlingFee>().HasKey(ohf => ohf.ID);
                modelBuilder.Entity<OrderHandlingFee>().Property(ohf => ohf.Amount).HasColumnName("Amount").IsRequired();
                modelBuilder.Entity<OrderHandlingFee>().Property(ohf => ohf.HandlingFeeTypeValue).HasColumnName("HandlingFeeType").IsRequired();
                modelBuilder.Entity<OrderHandlingFee>().Property(ohf => ohf.HandlingFeeStatusValue).HasColumnName("HandlingFeeStatus").IsRequired();
                modelBuilder.Entity<OrderHandlingFee>().Property(ohf => ohf.CreateOn).HasColumnName("CreateOn").IsRequired();
                modelBuilder.Entity<OrderHandlingFee>().Property(ohf => ohf.CreateBy).HasColumnName("CreateBy").IsRequired();
                #endregion
                //
                #region OrderStatusHistory
                modelBuilder.Entity<OrderStatusHistory>().ToTable("OrderStatusHistory", SCHEMA_NAME_SALES);
                modelBuilder.Entity<OrderStatusHistory>().Property(ohf => ohf.StatusType).HasColumnName("StatusType").IsRequired();
                modelBuilder.Entity<OrderStatusHistory>().Property(ohf => ohf.Status).HasColumnName("Status").IsRequired();
                modelBuilder.Entity<OrderStatusHistory>().Property(ohf => ohf.Notes).HasColumnName("Notes").HasColumnType("nvarchar").HasMaxLength(NOTES_MAXLENGTH);
                modelBuilder.Entity<OrderStatusHistory>().Property(ohf => ohf.ChangeOn).HasColumnName("ChangeOn").IsRequired();
                modelBuilder.Entity<OrderStatusHistory>().Property(ohf => ohf.ChangeBy).HasColumnName("ChangeBy").HasColumnType("varchar").HasMaxLength(OPERATORNAME_MAXLENGTH).IsRequired();
                #endregion
                //
                #region OrderMemo
                modelBuilder.Entity<OrderMemo>().ToTable("OrderMemo", SCHEMA_NAME_SALES);
                modelBuilder.Entity<OrderMemo>().Ignore(om => om.AudienceType);
                modelBuilder.Entity<OrderMemo>().Ignore(om => om.SourceType);
                modelBuilder.Entity<OrderMemo>().Property(om => om.SourceTypeValue).HasColumnName("SourceType").IsRequired();
                modelBuilder.Entity<OrderMemo>().Property(om => om.AudienceTypeValue).HasColumnName("AudienceType").IsRequired();
                #endregion

                #region OrderChangeReason
                modelBuilder.Entity<OrderChangeReason>().ToTable("OrderChangeReason");
                modelBuilder.Entity<OrderChangeReason>().Ignore(om => om.ChangeType);
                modelBuilder.Entity<OrderChangeReason>().Ignore(om => om.OperatorType);
                modelBuilder.Entity<OrderChangeReason>().Property(o => o.ChangeTypeValue).HasColumnName("ChangeType").IsRequired();
                modelBuilder.Entity<OrderChangeReason>().Property(o => o.OperatorTypeValue).HasColumnName("OperatorType").IsRequired();
                #endregion

                #region OrderChange
                //modelBuilder.Entity<OrderChange>().ToTable("OrderChange");
                //modelBuilder.Entity<OrderChange>().Ignore(o => o.NotifyType);
                //modelBuilder.Entity<OrderChange>().Property(o => o.NotifyTypeValue).HasColumnName("NotifyType").IsRequired();
                #endregion

                #region OrderChangeNotify
                //modelBuilder.Entity<OrderChangeNotify>().ToTable("OrderChangeNotify");
                #endregion

                #region Refund

                // Refund
                modelBuilder.Entity<Refund>().ToTable("OrderRefund", SCHEMA_NAME_SALES);
                modelBuilder.Entity<Refund>().Ignore(r => r.Order);
                modelBuilder.Entity<Refund>().Property(r => r.RefundStatusValue).IsConcurrencyToken(true);
                modelBuilder.Entity<Refund>().Property(r => r.OrderNumber).HasColumnType("Varchar").HasMaxLength(ORDERNUMBER_MAXLENGTH).IsRequired();
                modelBuilder.Entity<Refund>().Property(r => r.RefundReasonValue).HasColumnName("RefundReason").IsRequired();
                modelBuilder.Entity<Refund>().Property(r => r.RefundStatusValue).HasColumnName("RefundStatus").IsRequired();
                modelBuilder.Entity<Refund>().Property(r => r.RefundMethodValue).HasColumnName("RefundMethod").IsRequired();
                modelBuilder.Entity<Refund>().Property(r => r.CurrencyCodeName).HasColumnName("CurrencyCode").IsRequired();

                // 主外键关系
                modelBuilder.Entity<Refund>().HasMany(r => r.RefundOperationList).WithRequired().HasForeignKey(r => r.RefundID);
                modelBuilder.Entity<Refund>().HasMany(r => r.RefundItemList).WithRequired().HasForeignKey(r => r.RefundID);

                // RefundOperation
                modelBuilder.Entity<RefundOperation>().ToTable("OrderRefundOperation", SCHEMA_NAME_SALES);
                modelBuilder.Entity<RefundOperation>().Ignore(r => r.OperateType);
                modelBuilder.Entity<RefundOperation>().Property(r => r.RefundID).IsRequired();

                modelBuilder.Entity<RefundOperation>().Property(r => r.RefundOperateTypeValue).HasColumnName("RefundOperateType").IsRequired();
                modelBuilder.Entity<RefundOperation>().Property(r => r.Notes).HasColumnName("OperateNotes").IsRequired();

                //RefundItem
                modelBuilder.Entity<RefundItem>().ToTable("OrderRefundItem", SCHEMA_NAME_SALES);
                modelBuilder.Entity<RefundItem>().Ignore(r => r.ItemType);
                modelBuilder.Entity<RefundItem>().Property(r => r.RefundID).IsRequired();

                modelBuilder.Entity<RefundItem>().Property(r => r.ItemTypeValue).HasColumnName("ItemType").IsRequired();
                #endregion

                #region OrderDeadLetter

                modelBuilder.Entity<OrderDeadLetter>().ToTable("OrderDeadLetter", SCHEMA_NAME_LOG);
                modelBuilder.Entity<OrderDeadLetter>().Property(t => t.DeadLetterTypeValue).HasColumnName("DeadLetterType").IsRequired();
                modelBuilder.Entity<OrderDeadLetter>().Property(t => t.StatusValue).HasColumnName("Status").IsRequired();

                #endregion

                #region FulfillmentOrder
                modelBuilder.Entity<FulfillmentOrder>().ToTable("FulfillmentOrder", SCHEMA_NAME_SALES);
                modelBuilder.Entity<FulfillmentOrder>().Ignore(fo => fo.Order);
                modelBuilder.Entity<FulfillmentOrder>().Ignore(fo => fo.Lines);
                modelBuilder.Entity<FulfillmentOrder>().Ignore(fo => fo.ActualLines);
                modelBuilder.Entity<FulfillmentOrder>().Ignore(fo => fo.FulfillmentPolicy);
                modelBuilder.Entity<FulfillmentOrder>().Ignore(fo => fo.BizType);
                modelBuilder.Entity<FulfillmentOrder>().Ignore(fo => fo.FulfillmentStatus);
                modelBuilder.Entity<FulfillmentOrder>().Ignore(fo => fo.BizTypeDisplayName);
                modelBuilder.Entity<FulfillmentOrder>().Ignore(fo => fo.FulfillmentStatusDisplayName);
                modelBuilder.Entity<FulfillmentOrder>().Ignore(fo => fo.LockStatus);

                modelBuilder.Entity<FulfillmentOrder>().Property(fo => fo.FSCID).HasColumnName("FSCID").IsOptional();
                modelBuilder.Entity<FulfillmentOrder>().Property(fo => fo.LastPickedForFulfillment).HasColumnName("LastPickedForFulfillment").IsOptional();
                modelBuilder.Entity<FulfillmentOrder>().Property(fo => fo.FulfillmentPolicyValue).HasColumnName("FulfillmentPolicy").IsRequired();
                modelBuilder.Entity<FulfillmentOrder>().Property(fo => fo.BizTypeValue).HasColumnName("BizType").IsRequired();
                modelBuilder.Entity<FulfillmentOrder>().Property(fo => fo.FulfillmentStatusValue).HasColumnName("FulfillmentStatus").IsRequired();
                modelBuilder.Entity<FulfillmentOrder>().Property(fo => fo.LockStatusValue).HasColumnName("LockStatus").IsRequired();

                #endregion
            }
        }
    
}
