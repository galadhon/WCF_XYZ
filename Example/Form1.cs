using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Example.ServiceReference1;
using WCF_XYZ;
using IServiceXyz = Example.ServiceReference1.IServiceXyz;

namespace Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataSet1.ReadXml("Example.xml");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // gera uma lista com os dados da tabela Customer
            IEnumerable<DataRow> table = dataSet1.Tables["Customer"].AsEnumerable();
            IList<CustomerData> list = table.Select(c => new CustomerData
            {
                CustId = c.Field<int>("CustId"),
                CustName = c.Field<string>("CustName"),
                CustBirthDate = c.Field<DateTime?>("CustBirthDate"),
                CustPhone = c.Field<string>("CustPhone"),
                CustAddr = c.Field<string>("CustAddr"),
                CustZip = c.Field<string>("CustZip"),
                CustCity = c.Field<string>("CustCity"),
                CustState = c.Field<string>("CustState"),
                CustCellPhone = c.Field<string>("CustCellPhone")
            }).ToList();

            // chama o serviço para atualizar os dados
            IServiceXyz client = new ServiceXyzClient();
            client.SetCustomers("Empresa1", list.ToArray());

            // chama o serviço para pegar novos dados
            list = client.GetCustomersForUpdate("Empresa1", 15).ToList();

            // limpa a tabela local e salva os dados adquiridos no serviço
            dataSet1.Tables["Customer"].Clear();
            foreach (CustomerData c in list)
            {
                DataRow row = dataSet1.Tables["Customer"].NewRow();
                row.SetField("CustId",c.CustId);
                row.SetField("CustName", c.CustName);
                row.SetField("CustBirthDate", c.CustBirthDate);
                row.SetField("CustPhone", c.CustPhone);
                row.SetField("CustAddr", c.CustAddr);
                row.SetField("CustZip", c.CustZip);
                row.SetField("CustCity", c.CustCity);
                row.SetField("CustState", c.CustState);
                row.SetField("CustCellPhone", c.CustCellPhone);
                dataSet1.Tables["Customer"].Rows.Add(row);
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataSet1.WriteXml("Example.xml");
        }
    }
}
