using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RIS_lab6
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMobileService" in both code and config file together.
    [ServiceContract]
    public interface IMobileService
    {
        [OperationContract]
        void addQuestionnaire(questionnaire quest);
        [OperationContract]
        int[] statOS();
        [OperationContract]
        int statRead();
        [OperationContract]
        int statPrice();

    }
}
