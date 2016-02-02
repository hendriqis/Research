using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QIS.Data.Core.Dal;
using System.Data;

namespace PivotReporting.Model
{
    public static class BusinessLayer
    {
        #region vPivotRegistration
        public static List<vPivotRegistration> GetvPivotRegistrationList(string filterExpression)
        {
            List<vPivotRegistration> result = new List<vPivotRegistration>();
            IDbContext ctx = DbFactory.Configure();
            try
            {
                DbHelper helper = new DbHelper(typeof(vPivotRegistration));
                ctx.CommandText = helper.Select(filterExpression);
                using (IDataReader reader = DaoBase.GetDataReader(ctx))
                    while (reader.Read())
                        result.Add((vPivotRegistration)helper.IDataReaderToObject(reader, new vPivotRegistration()));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            finally
            {
                ctx.Close();
            }
            return result;
        }
        #endregion

        #region vPivotOutpatientTrx
        public static List<vPivotOutpatientTrx> GetvPivotOutpatientTrxList(string filterExpression)
        {
            List<vPivotOutpatientTrx> result = new List<vPivotOutpatientTrx>();
            IDbContext ctx = DbFactory.Configure();
            try
            {
                DbHelper helper = new DbHelper(typeof(vPivotOutpatientTrx));
                ctx.CommandText = helper.Select(filterExpression);
                using (IDataReader reader = DaoBase.GetDataReader(ctx))
                    while (reader.Read())
                        result.Add((vPivotOutpatientTrx)helper.IDataReaderToObject(reader, new vPivotOutpatientTrx()));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            finally
            {
                ctx.Close();
            }
            return result;
        }
        #endregion

        #region vPivotInpatientPayment
        public static List<vPivotInpatientPayment> GetvPivotInpatientPaymentList(string filterExpression)
        {
            List<vPivotInpatientPayment> result = new List<vPivotInpatientPayment>();
            IDbContext ctx = DbFactory.Configure();
            try
            {
                DbHelper helper = new DbHelper(typeof(vPivotInpatientPayment));
                ctx.CommandText = helper.Select(filterExpression);
                using (IDataReader reader = DaoBase.GetDataReader(ctx))
                    while (reader.Read())
                        result.Add((vPivotInpatientPayment)helper.IDataReaderToObject(reader, new vPivotInpatientPayment()));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            finally
            {
                ctx.Close();
            }
            return result;
        }
        #endregion

        #region vPivotOutpatientPayment
        public static List<vPivotOutpatientPayment> GetvPivotOutpatientPaymentList(string filterExpression)
        {
            List<vPivotOutpatientPayment> result = new List<vPivotOutpatientPayment>();
            IDbContext ctx = DbFactory.Configure();
            try
            {
                DbHelper helper = new DbHelper(typeof(vPivotOutpatientPayment));
                ctx.CommandText = helper.Select(filterExpression);
                using (IDataReader reader = DaoBase.GetDataReader(ctx))
                    while (reader.Read())
                        result.Add((vPivotOutpatientPayment)helper.IDataReaderToObject(reader, new vPivotOutpatientPayment()));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            finally
            {
                ctx.Close();
            }
            return result;
        }
        #endregion

        #region Revenue Pivot
        #region vPivotInpatientRevenue
        public static List<vPivotInpatientRevenue> GetvPivotInpatientRevenueList(string filterExpression)
        {
            List<vPivotInpatientRevenue> result = new List<vPivotInpatientRevenue>();
            IDbContext ctx = DbFactory.Configure();
            try
            {
                DbHelper helper = new DbHelper(typeof(vPivotInpatientRevenue));
                ctx.CommandText = helper.Select(filterExpression);
                using (IDataReader reader = DaoBase.GetDataReader(ctx))
                    while (reader.Read())
                        result.Add((vPivotInpatientRevenue)helper.IDataReaderToObject(reader, new vPivotInpatientRevenue()));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            finally
            {
                ctx.Close();
            }
            return result;
        }
        #endregion

        #region vPivotOutpatientRevenue
        public static List<vPivotOutpatientRevenue> GetvPivotOutpatientRevenueList(string filterExpression)
        {
            List<vPivotOutpatientRevenue> result = new List<vPivotOutpatientRevenue>();
            IDbContext ctx = DbFactory.Configure();
            try
            {
                DbHelper helper = new DbHelper(typeof(vPivotOutpatientRevenue));
                ctx.CommandText = helper.Select(filterExpression);
                using (IDataReader reader = DaoBase.GetDataReader(ctx))
                    while (reader.Read())
                        result.Add((vPivotOutpatientRevenue)helper.IDataReaderToObject(reader, new vPivotOutpatientRevenue()));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            finally
            {
                ctx.Close();
            }
            return result;
        }
        #endregion

        #region vPivotEmergencyRevenue
        public static List<vPivotEmergencyRevenue> GetvPivotEmergencyRevenueList(string filterExpression)
        {
            List<vPivotEmergencyRevenue> result = new List<vPivotEmergencyRevenue>();
            IDbContext ctx = DbFactory.Configure();
            try
            {
                DbHelper helper = new DbHelper(typeof(vPivotEmergencyRevenue));
                ctx.CommandText = helper.Select(filterExpression);
                using (IDataReader reader = DaoBase.GetDataReader(ctx))
                    while (reader.Read())
                        result.Add((vPivotEmergencyRevenue)helper.IDataReaderToObject(reader, new vPivotEmergencyRevenue()));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            finally
            {
                ctx.Close();
            }
            return result;
        }
        #endregion

        #region vPivotRevenue
        public static List<vPivotRevenue> GetvPivotRevenueList(string filterExpression)
        {
            List<vPivotRevenue> result = new List<vPivotRevenue>();
            IDbContext ctx = DbFactory.Configure();
            try
            {
                DbHelper helper = new DbHelper(typeof(vPivotRevenue));
                ctx.CommandText = helper.Select(filterExpression);
                using (IDataReader reader = DaoBase.GetDataReader(ctx))
                    while (reader.Read())
                        result.Add((vPivotRevenue)helper.IDataReaderToObject(reader, new vPivotRevenue()));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            finally
            {
                ctx.Close();
            }
            return result;
        }
        #endregion
        #region vPivotMDRevenue
        public static List<vPivotMDRevenue> GetvPivotMDRevenueList(string filterExpression)
        {
            List<vPivotMDRevenue> result = new List<vPivotMDRevenue>();
            IDbContext ctx = DbFactory.Configure();
            try
            {
                DbHelper helper = new DbHelper(typeof(vPivotMDRevenue));
                ctx.CommandText = helper.Select(filterExpression);
                using (IDataReader reader = DaoBase.GetDataReader(ctx))
                    while (reader.Read())
                        result.Add((vPivotMDRevenue)helper.IDataReaderToObject(reader, new vPivotMDRevenue()));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            finally
            {
                ctx.Close();
            }
            return result;
        }
        #endregion

        #region vPivotLBRevenue
        public static List<vPivotLBRevenue> GetvPivotLBRevenueList(string filterExpression)
        {
            List<vPivotLBRevenue> result = new List<vPivotLBRevenue>();
            IDbContext ctx = DbFactory.Configure();
            try
            {
                DbHelper helper = new DbHelper(typeof(vPivotLBRevenue));
                ctx.CommandText = helper.Select(filterExpression);
                using (IDataReader reader = DaoBase.GetDataReader(ctx))
                    while (reader.Read())
                        result.Add((vPivotLBRevenue)helper.IDataReaderToObject(reader, new vPivotLBRevenue()));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            finally
            {
                ctx.Close();
            }
            return result;
        }
        #endregion
        #endregion

        #region Prescription Pivot
        public static List<vPivotPrescription> GetvPivotPrescriptionList(string filterExpression)
        {
            List<vPivotPrescription> result = new List<vPivotPrescription>();
            IDbContext ctx = DbFactory.Configure();
            try
            {
                DbHelper helper = new DbHelper(typeof(vPivotPrescription));
                ctx.CommandText = helper.Select(filterExpression);
                using (IDataReader reader = DaoBase.GetDataReader(ctx))
                    while (reader.Read())
                        result.Add((vPivotPrescription)helper.IDataReaderToObject(reader, new vPivotPrescription()));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            finally
            {
                ctx.Close();
            }
            return result;
        }

        public static List<vPivotBPJSInpatientPrescription> GetvPivotBPJSInpatientPrescriptionList(string filterExpression)
        {
            List<vPivotBPJSInpatientPrescription> result = new List<vPivotBPJSInpatientPrescription>();
            IDbContext ctx = DbFactory.Configure();
            try
            {
                DbHelper helper = new DbHelper(typeof(vPivotBPJSInpatientPrescription));
                ctx.CommandText = helper.Select(filterExpression);
                using (IDataReader reader = DaoBase.GetDataReader(ctx))
                    while (reader.Read())
                        result.Add((vPivotBPJSInpatientPrescription)helper.IDataReaderToObject(reader, new vPivotBPJSInpatientPrescription()));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            finally
            {
                ctx.Close();
            }
            return result;
        }

        public static List<vPivotBPJSOutpatientPrescription> GetvPivotBPJSOutpatientPrescriptionList(string filterExpression)
        {
            List<vPivotBPJSOutpatientPrescription> result = new List<vPivotBPJSOutpatientPrescription>();
            IDbContext ctx = DbFactory.Configure();
            try
            {
                DbHelper helper = new DbHelper(typeof(vPivotBPJSOutpatientPrescription));
                ctx.CommandText = helper.Select(filterExpression);
                using (IDataReader reader = DaoBase.GetDataReader(ctx))
                    while (reader.Read())
                        result.Add((vPivotBPJSOutpatientPrescription)helper.IDataReaderToObject(reader, new vPivotBPJSOutpatientPrescription()));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            finally
            {
                ctx.Close();
            }
            return result;
        }
        #endregion
    }
}
