using System;
using System.Collections.Generic;
using System.ServiceModel;
using Database;

namespace WCF_Childpee
{
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        int RegDevice(DateTime extraditionDate);

        [OperationContract]
        List<Device> GetDevices();

        [OperationContract]
        List<Patient> GetPatients();

        [OperationContract]
        int RegPatients(int age, int deviceId, string name, string deviceassigned);

        [OperationContract]
        void RemoveDevice(int deviceId);

        [OperationContract]
        List<Measurement> GetmeasureList();

        [OperationContract]
        void AddinformationManually(string manuallyTime, int measurementId, bool value);

    }
}
