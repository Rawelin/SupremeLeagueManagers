using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using SLMContextDB;

namespace SupremeLeagueManager.Models.Global
{
    public static class ErrorHandling
    {
        public static void InsertError(Exception ex)
        {
            ErrorTableApp errorTableApp = new ErrorTableApp();

            try
            {
                errorTableApp.Date = DateTime.Now;
                errorTableApp.InnerException = ex.InnerException is null ? "" : ex.InnerException.ToString();
                errorTableApp.Message = ex.Message is null ? "" : ex.Message.ToString();
                errorTableApp.Source = ex.Source is null ? "" : ex.Source.ToString();
                errorTableApp.StackTrace = ex.StackTrace is null ? "" : ex.StackTrace.ToString();
                errorTableApp.TargetSite = ex.TargetSite is null ? "" : ex.TargetSite.ToString();
                errorTableApp.UserLogin = "pawelka";

                using (var slmCtx = new Entities())
                {
                    slmCtx.ErrorTableApp.Add(errorTableApp);
                    slmCtx.SaveChanges();
                }
            }
            catch (Exception)
            {

            }
            finally
            {

            }
        }

        public static void InsertError(string serviceName, string className, string methodName, Exception ex)
        {
            ErrorTableApp errorTableApp = new ErrorTableApp();

            try
            {
                errorTableApp.Date = DateTime.Now;
                errorTableApp.Service = serviceName;
                errorTableApp.Class = className;
                errorTableApp.Method = methodName;
                errorTableApp.InnerException = ex.InnerException is null ? "" : ex.InnerException.ToString();
                errorTableApp.Message = ex.Message is null ? "" : ex.Message.ToString();
                errorTableApp.Source = ex.Source is null ? "" : ex.Source.ToString();
                errorTableApp.StackTrace = ex.StackTrace is null ? "" : ex.StackTrace.ToString();
                errorTableApp.TargetSite = ex.TargetSite is null ? "" : ex.TargetSite.ToString();
                errorTableApp.UserLogin = "pawelka";

                using (var slmCtx = new Entities())
                {
                    slmCtx.ErrorTableApp.Add(errorTableApp);
                    slmCtx.SaveChanges();
                }
            }
            catch (Exception e)
            {
                InsertError("", "ErrorHandling", "InsertError", e);
            }
            finally
            {

            }
        }

        //public static void InsertValues(string cls, string meth, string desc, string val1, string val2, string val3, string val4, string val5, string val6, string login)
        //{
        //    try
        //    {
        //        ValueTestTableApp valueTest = new ValueTestTableApp();
        //        valueTest.DateTime = DateTime.Now;
        //        valueTest.Class = cls;
        //        valueTest.Method = meth;
        //        valueTest.Description = desc;
        //        valueTest.Value_1 = val1;
        //        valueTest.Value_2 = val2;
        //        valueTest.Value_3 = val3;
        //        valueTest.Value_4 = val4;
        //        valueTest.Value_5 = val5;
        //        valueTest.Value_6 = val6;
        //        valueTest.UserLogin = login;

        //        using (var slmCtx = new Entities())
        //        {
        //            slmCtx.ValueTestTableApp.Add(valueTest);
        //            slmCtx.SaveChanges();
        //        }
        //    }
        //    catch (Exception)
        //    {

        //    }
        //    finally
        //    {

        //    }
        //}
    }
}