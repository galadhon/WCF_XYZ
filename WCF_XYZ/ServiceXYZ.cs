using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity.Validation;

namespace WCF_XYZ
{
    public class ServiceXyz : IServiceXyz
    {
        /// <summary>
        /// Retorna uma lista de clientes para atualização
        /// </summary>
        /// <param name="partner">login do parceiro</param>
        /// <param name="qtdValue">Quantidade máxima de clientes a retornar</param>
        /// <returns>Lista de clientes</returns>
        /// <remarks></remarks>
        public CustomerData[] GetCustomersForUpdate(string partner, int qtdValue)
        {
            if (qtdValue <= 0)
            {
                throw new ArgumentNullException("qtdValue");
            }
            using (var context = new XYZ_DataEntities())
            {
                var list = (from c in context.Customer
                    where c.CustBirthDate == null && c.PartnerCustomer == null
                    select new CustomerData{
                        CustId = c.CustId, 
                        CustName = c.CustName, 
                        CustBirthDate = c.CustBirthDate, 
                        CustPhone = c.CustPhone, 
                        CustAddr = c.CustAddr, 
                        CustZip = c.CustZip, 
                        CustCity = c.CustCity, 
                        CustState = c.CustState, 
                        CustCellPhone = c.CustCellPhone
			        }).Take(qtdValue).ToList();
                foreach (var customer in list)
                {
                    context.PartnerCustomer.Add(new PartnerCustomer{ CustId = customer.CustId, PartId = partner});
                }
                context.SaveChanges();
                    
                return list.ToArray();
            }
        }

        /// <summary>
        /// Retorna uma lista de clientes baseado no filtro passado como parâmetro
        /// </summary>
        /// <remarks>O filtro a ser adodato é composto de cada campo do registro de clientes, quando preenchido.</remarks>
        /// <param name="cust">Filtro de clientes</param>
        /// <returns>Lista de clientes baseada no filtro</returns>
        public CustomerData[] GetCustomers(CustomerData cust)
        {
            using (var context = new XYZ_DataEntities())
            {
                IQueryable<Customer> query = context.Customer;
                if (cust.CustId > 0)
                    query = query.Where(c => c.CustId == cust.CustId);
                if (!string.IsNullOrEmpty(cust.CustName))
                    query = query.Where(c => c.CustName.Contains(cust.CustName));
                if (cust.CustBirthDate != null)
                    query = query.Where(c => c.CustBirthDate == cust.CustBirthDate);
                if (!string.IsNullOrEmpty(cust.CustCellPhone))
                    query = query.Where(c => c.CustCellPhone.Contains(cust.CustCellPhone));
                if (!string.IsNullOrEmpty(cust.CustPhone))
                    query = query.Where(c => c.CustPhone.Contains(cust.CustPhone));
                if (!string.IsNullOrEmpty(cust.CustAddr))
                    query = query.Where(c => c.CustAddr.Contains(cust.CustAddr));
                if (!string.IsNullOrEmpty(cust.CustZip))
                    query = query.Where(c => c.CustZip == cust.CustZip);
                if (!string.IsNullOrEmpty(cust.CustCity))
                    query = query.Where(c => c.CustCity.Contains(cust.CustCity));
                if (!string.IsNullOrEmpty(cust.CustState))
                    query = query.Where(c => c.CustState == cust.CustState);
                return query.Select(x => new CustomerData{
                        CustId = x.CustId, 
                        CustName = x.CustName, 
                        CustBirthDate = x.CustBirthDate, 
                        CustPhone = x.CustPhone, 
                        CustAddr = x.CustAddr, 
                        CustZip = x.CustZip, 
                        CustCity = x.CustCity, 
                        CustState = x.CustState, 
                        CustCellPhone = x.CustCellPhone
			        }).ToArray();
            }
        }

        /// <summary>
        /// Atualiza uma lista de clientes
        /// </summary>
        /// <param name="partner">login do parceiro</param>
        /// <param name="cust">Lista de clientes a atualizar</param>
        /// <returns>Lista de clientes onde a atualização não foi possivel</returns>
        public CustomerError[] SetCustomers(string partner, CustomerData[] cust)
        {
            IList<CustomerError> errorList = new List<CustomerError>();
            using (var context = new XYZ_DataEntities())
            {
                foreach (var customer in cust)
                {
                    try
                    {
                        var c = context.Customer.Single(x => x.CustId == customer.CustId);

                        // atualiza os novos campos de telefone celular e data de aniversário
                        c.CustCellPhone = customer.CustCellPhone;
                        c.CustBirthDate = customer.CustBirthDate;

                        // atualização de dados cadastrais previamente existentes
                        c.CustPhone = customer.CustPhone;
                        c.CustAddr = customer.CustAddr;
                        c.CustZip = customer.CustZip;
                        c.CustCity = customer.CustCity;
                        c.CustState = customer.CustState;

                        context.SaveChanges();
                    }
                    catch (DbEntityValidationException dbEx)
                    {
                        foreach (var validationErrors in dbEx.EntityValidationErrors)
                        {
                            foreach (var validationError in validationErrors.ValidationErrors)
                            {
                                errorList.Add(new CustomerError
                                {
                                    Customer = customer,
                                    Error = string.Format("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage)
                                });
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        errorList.Add(new CustomerError
                        {
                            Customer = customer,
                            Error = e.Message
                        });
                    }
                     
                }
                // remove informação de que um parceiro adquiriu os dados do cliente
                var list = (from p in context.PartnerCustomer
                            where p.PartId == partner
                            select p);
                foreach (var p in list)
                {
                    context.PartnerCustomer.Remove(context.PartnerCustomer.Single(x => x.CustId == p.CustId));
                }
                context.SaveChanges();
            }
            return errorList.ToArray();
        }
    }
}
