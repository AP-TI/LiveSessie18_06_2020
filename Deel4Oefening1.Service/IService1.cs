using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Deel4Oefening1.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        List<Boete> GetBoetes();

        [OperationContract]
        void AddBoete(int betalingsnr, int spelersnr, DateTime datum, decimal bedrag);
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "Deel4Oefening1.Service.ContractType".
    [DataContract]
    public class Boete
    {
        [DataMember]
        public int Betalingsnr { get; set; }
        [DataMember]
        public int Spelersnr { get; set; }
        [DataMember]
        public DateTime Datum { get; set; }
        [DataMember]
        public decimal Bedrag { get; set; }
    }
}
