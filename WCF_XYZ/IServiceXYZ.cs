using System;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace WCF_XYZ
{
    [ServiceContract]
    public interface IServiceXyz
    {
        [OperationContract]
        CustomerData[] GetCustomers(CustomerData cust);

        [OperationContract]
        CustomerData[] GetCustomersForUpdate(string partner, int qtdValue);

        [OperationContract]
        CustomerError[] SetCustomers(string partner, CustomerData[] cust);

    }

    [DataContract]
    public class CustomerError
    {
        [DataMember]
        public CustomerData Customer { get; set; }
        [DataMember]
        public string Error { get; set; }
    }

    [DataContract]
    public class CustomerData
    {
        [DataMember]
        public int CustId { get; set; }
        [DataMember]
        public string CustName { get; set; }
        [DataMember]
        public DateTime? CustBirthDate { get; set; }
        [DataMember]
        public string CustPhone { get; set; }
        [DataMember]
        public string CustAddr { get; set; }
        [DataMember]
        public string CustZip { get; set; }
        [DataMember]
        public string CustCity { get; set; }
        [DataMember]
        public string CustState { get; set; }
        [DataMember]
        public string CustCellPhone { get; set; }
    }
}

