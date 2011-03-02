using System;
using System.IO;
using System.Xml;

namespace AnujBank
{
    public class PaymentInstructionService
    {
        public String OutputPath = "Output\\";
        private int counter=1;
        public  void Generate(Payment payment)
        {
            CreateOutPutDirectoryIfDoesNotExist();
            CreateOutputXml(payment);
        }

        private void CreateOutputXml(Payment payment)
        {
            using (var writer = new XmlTextWriter(OutputPath + counter + ".xml", null))
            {
                counter++;
                writer.WriteStartElement("payment-instruction");
                WriteElement(writer, "account", payment.Account);
                WriteElement(writer, "amount", payment.Amount);
                WriteElement(writer, "date", payment.Date);
                WriteElement(writer, "type", payment.GetTransactionType());
                writer.WriteEndElement();
            }
        }

        private void WriteElement(XmlTextWriter writer, string elementName, object value)
        {
            writer.WriteStartElement(elementName);
            writer.WriteValue(value);
            writer.WriteEndElement();
        }

       

        private void CreateOutPutDirectoryIfDoesNotExist()
        {
             if(!Directory.Exists(OutputPath))
             {
                Directory.CreateDirectory(OutputPath);
             }
        }
    }
}