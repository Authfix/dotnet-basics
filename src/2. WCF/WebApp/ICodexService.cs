using MyCompany.Codex.WebApp.Dtos;
using System.Collections.Generic;
using System.ServiceModel;

namespace MyCompany.Codex.WebApp
{
    [ServiceContract]
    public interface ICodexService
    {

        [OperationContract]
        IEnumerable<Creature> GetCreatures();
    }
}
