using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zhao.Repository
{
    public static class EFDbContextFactory
    {
        /// <summary>
        /// 获取当前调用上下文的<see cref="EFDbContext"/>实例，可写可读。
        /// </summary>
        /// <returns></returns>
        //public static EFDbContext GetDbContext()
        //{
        //    const string dbContextName = "name=OMSDbMaster";
        //    //IInvokeContextContainer container = InvokeContextContainerFactory.GetContainer();
        //    EFDbContext dbContext = (EFDbContext)container.GetData(dbContextName);
        //    if (dbContext == null)
        //    {
        //        dbContext = new EFDbContext(dbContextName);
        //        container.SetData(dbContextName, dbContext);
        //    }

        //    return dbContext;
        //}

        /// <summary>
        /// 获取当前调用上下文的<see cref="EFDbContext"/>只读实例。
        /// </summary>
        /// <returns></returns>
        //internal static EFDbContext GetReadonlyDbContext()
        //{
        //    const string dbContextName = "name=OMSDbSlave";
        //    IInvokeContextContainer container = InvokeContextContainerFactory.GetContainer();
        //    EFDbContext dbContext = (EFDbContext)container.GetData(dbContextName);
        //    if (dbContext == null)
        //    {
        //        dbContext = new EFDbContext(dbContextName);
        //        container.SetData(dbContextName, dbContext);
        //    }

        //    return dbContext;
        //}
    }
}
