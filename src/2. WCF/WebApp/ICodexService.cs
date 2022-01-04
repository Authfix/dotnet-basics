using MyCompany.Codex.Dtos;
using System.Collections.Generic;
using System.ServiceModel;

namespace MyCompany.Codex.WebApp
{
    [ServiceContract]
    public interface ICodexService
    {
        [OperationContract]
        IEnumerable<CreatureDto> GetCreatures();
    }
}
