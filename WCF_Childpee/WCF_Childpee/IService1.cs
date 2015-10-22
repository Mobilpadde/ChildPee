using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Database;

namespace WCF_Childpee
{
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        void RegDevice(int id, string extraditionDate);

        [OperationContract]
        List<Device> GetDevices();

        [OperationContract]
        List<Patient> GetPatients();

        [OperationContract]
        void RegPatients(int age, int deviceId, int id, string name);

        [OperationContract]
        void RemoveDevice(int deviceId);

        [OperationContract]
        List<Measurement> GetmesureList();

        [OperationContract]
        void AddinformationManually(string manuallyTime, int measurementId, bool value);

    }
}
